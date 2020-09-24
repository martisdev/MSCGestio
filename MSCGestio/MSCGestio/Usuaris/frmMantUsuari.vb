Option Strict Off
Option Explicit On
Imports MySql.Data.MySqlClient

Public Class frmMantUsuari
	
	Private Structure audioUserVisible
		Dim AUV_ID As Integer
		Dim AUV_Visible As Boolean
	End Structure
	
	Dim AUV(0) As audioUserVisible
	
	Private Structure TemesFavorits
		Dim TF_TemaID As Integer
		Dim TF_Value As Boolean
	End Structure
	
	Dim TF() As TemesFavorits
	
	Dim blEnable As Boolean = False
	
	Private Sub frmMantUsuari_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		setLanguageForm()
		Me.Text += " ( " & Usuari.UsrNom & " )"
		Me.lbID.Text = Usuari.UsrID
		Me.txtNomUser.Text = Usuari.UsrNom


        Dim StrUserTipus As String = ""
		Select Case Usuari.UsrTipus
			Case mdlMscDefines.NivellUsers.USR_CONVIDAT : StrUserTipus = NOM_TIPUS_USER_CONVIDAT
			Case mdlMscDefines.NivellUsers.USR_USUARI : StrUserTipus = NOM_TIPUS_USER_EDITOR
			Case mdlMscDefines.NivellUsers.USR_ADMINISTRADOR : StrUserTipus = NOM_TIPUS_USER_ADMIN
			Case mdlMscDefines.NivellUsers.USR_PROGRAMADOR : StrUserTipus = NOM_TIPUS_USER_DEVELOP
		End Select
		Me.lbTipusUser.Text = StrUserTipus
        Dim db As New MSC.dbs(Cloud)
        Dim StrSql As String = "SELECT * FROM users WHERE usr_id=" & Me.lbID.Text & " ;"
		Dim rsUser As DataTable = db.getTable(StrSql)
		
		Me.lbUserDataCreacio.Text = rsUser.Rows(0)("usr_datacreacio")
		Me.lbDataUltConex.Text = NoNul(rsUser.Rows(0)("usr_dataultconex").ToString)
		Me.lbdataUltdesconex.Text = NoNul(rsUser.Rows(0)("usr_dataultdesconex").ToString)
		Me.lbNIntentsErr.Text = rsUser.Rows(0)("usr_intentserr").ToString
		Me.lbDataUltIntErr.Text = IIf(rsUser.Rows(0)("usr_dataultinternterr").ToString = "01/01/1970 00:00:00", "", rsUser.Rows(0)("usr_dataultinternterr").ToString)
		Me.lbPswErr.Text = NoNul(rsUser.Rows(0)("usr_errpsw").ToString)
		Me.lbCaducUser.Text = IIf(rsUser.Rows(0)("usr_caducitat").ToString = "30/12/1899 00:00:00", "", rsUser.Rows(0)("usr_caducitat").ToString)
		Me.lbCaducPassword.Text = IIf(rsUser.Rows(0)("usr_caducpsw").ToString = "30/12/1899 00:00:00", "", rsUser.Rows(0)("usr_caducpsw").ToString)

        ' llistats de programes / pantalles assignat a l'usuari
        Dim userFrm As String() = Split(rsUser.Rows(0)("usr_applications").ToString, ",")
        For N As Short = 0 To 11 ' Nº d'aplicatius
            Dim dr As New DataGridViewRow
            dr = gridListProgs.Rows(gridListProgs.Rows.Add())

            dr.Cells("ColumnID").Value = N
            dr.Cells("ColumnEnable").Value = CBool(userFrm(N))
            dr.Cells("ColumnNomPrg").Value = getNomAplic(N)
            dr.Cells("ColumnDescrip").Value = getDescripAplic(N)
        Next

        'Llistar el historial de connexions de l'usuari
        StrSql = "SELECT connex_id,connex_ip,connex_host,connex_aplic,connex_datain FROM connexions WHERE connex_usuari='" & txtNomUser.Text & "' ;"
		Dim dtConnex As DataTable = db.getTable(StrSql)
		DataGridViewLog.DataSource = dtConnex
		
		'Llistar els audios visibles (per tots)
		StrSql = "SELECT audio_id,audio_nom FROM `listaudio` WHERE audio_visible=1"
		DataGridViewAudioUsers.DataSource = db.getTable(StrSql)
		
		'BUG: No sé perquè però, no es visualitza el resultat (poder fer-ho amb una sentència complexa en el pas prèvi)
		ReDim AUV(DataGridViewAudioUsers.Rows.Count)
		For i As Integer = 0 To DataGridViewAudioUsers.Rows.Count - 1
			Dim AudioID As Integer = DataGridViewAudioUsers.Rows(i).Cells("ColumnAudioID").Value
			AUV(i).AUV_ID = AudioID
            AUV(i).AUV_Visible = IsAudioForUser(AudioID, Me.lbID.Text)
            DataGridViewAudioUsers.Rows(i).Cells("ColumnAudioVisible").Value = IIf(AUV(i).AUV_Visible = True, 1, 0)
        Next
        DataGridViewAudioUsers.Refresh()
        ' Llistat de les cançons favorites de l'usuari
        StrSql = "SELECT tema_id, tema_titol, tema_interp, tema_disc, tema_durada," &
            "tema_idioma, tema_temps, tema_subj, tema_ritme,tema_any,tema_numradiacions, " &
            "IFNULL(tema_id=usrtema_tema,0) as temFav, " &
            "usrtema_datain as temFavDataIn " &
            "FROM(temes) " &
            "left JOIN (SELECT usrtema_tema, usrtema_datain FROM `user_temes` WHERE usrtema_user=" & Me.lbID.Text & " )tb " &
            "on tema_id=usrtema_tema ;"

        Me.gridTemes.DataSource = db.getTable(StrSql)
		db = Nothing
		
	End Sub
	
	Dim MSG_ERROR_NOM_BUIT As String 
	Dim MSG_ERROR_NUM_CARACTERS As String
	Dim MSG_ERROR_ALIES As String 
	Dim MSG_ERROR_PASSWORDS As String 
	Dim LABEL_ADD_FAVORITES As String 
	Dim LABEL_DEL_FAVORITES As String
	Dim LABEL_MAKE_VISIBLE As String 
	Dim LABEL_MAKE_INVISIBLE As String
	
	
	Public Sub setLanguageForm()
		lang.StrForm = Me.Name
		
		MSG_ERROR_NOM_BUIT = lang.getText("MSG_ERROR_NOM_BUIT") '"En nom d'usuari no pot estar buit"
		MSG_ERROR_NUM_CARACTERS = lang.getText("MSG_ERROR_NUM_CARACTERS") '"Mínim 4 caràcters"
		MSG_ERROR_ALIES = lang.getText("MSG_ERROR_ALIES") '"No coincideixen els dos àlies"
		MSG_ERROR_PASSWORDS = lang.getText("MSG_ERROR_PASSWORDS") '"No coincideixen les dues contrasenyes"
		LABEL_ADD_FAVORITES = lang.getText("LABEL_ADD_FAVORITES",True) '"Afegir a Favorites"
		LABEL_DEL_FAVORITES = lang.getText("mnuDellFav_text",True) '"Esborrar de Favorites"
		LABEL_MAKE_VISIBLE = lang.getText("LABEL_MAKE_VISIBLE") '"Fer-lo visible"
		LABEL_MAKE_INVISIBLE = lang.getText("LABEL_MAKE_INVISIBLE") '"Fer-lo invisible"		
		
		Me.ColumnID.HeaderText = lang.getText("HEADERTEXT_ID",True) '"ID"
		Me.ColumnAudioID.HeaderText = lang.getText("HEADERTEXT_ID",True) '"ID"		
		Me.columnFavID.HeaderText = lang.getText("HEADERTEXT_ID",True) '"ID"
		Me.DataGridViewTextBoxColumn1.HeaderText = lang.getText("HEADERTEXT_ID",True) '"ID"
		Me.ColumnTitol.HeaderText = lang.getText("HEADERTEXT_TITOL",True) '"Titol"
		Me.comboInterp.HeaderText =  lang.getText("HEADERTEXT_INTERP",True) '"Intèrpret"
		Me.comboDisc.HeaderText = lang.getText("HEADERTEXT_DISC",True) '"Disc"
        Me.Column3.HeaderText = lang.getText("HEADERTEXT_DURADA", True) '"Durada"		
        Me.ColumnIdioma.HeaderText = lang.getText("HEADERTEXT_IDIOMA",True) '"Idioma"
		Me.ColumnTemp.HeaderText = lang.getText("LABEL_CLAS_TEMP",True) '"Clas. Temporal
		Me.ColumnSub.HeaderText = lang.getText("LABEL_CLAS_SUBJ",True) '"Clas. Subjectiva"
		Me.ColumnRitme.HeaderText = lang.getText("HEADERTEXT_RITME",True) '"Ritme"
		Me.ColumnAny.HeaderText = lang.getText("HEADERTEXT_ANY",True) '"Any"
		Me.ColumnRadia.HeaderText = lang.getText("HEADERTEXT_N_RADIA",True) '"Nº Radiacions
		Me.mnuAddDelFav.Text = LABEL_ADD_FAVORITES
		'Me.MenuStrip1.Text = "MenuStrip1"
		Me.cmdBloqueix.Text = lang.getText("LABEL_EDITAR",True) '"Editar"
		Me.cmdSalvar.Text = lang.getText("LABEL_SAVE",True)'"Salvar"
		Me.cmdSortir.Text = lang.getText("LABEL_EXIT",True) '"Sortir"		
		Me.ProgarmaToolStripMenuItem.Text = lang.getText("LABEL_PROGRAMA",True) '"Programa"	
		Me.mnuExit.Text = lang.getText("LABEL_EXIT",True) '"Sortir"
		Me.EdicióToolStripMenuItem.Text = lang.getText("mnuEdit.Text",True )'"Edició"
		Me.mnuModif.Text = lang.getText("LABEL_MODIFICAR",True )'"Modificar"
		Me.mnuSave.Text = lang.getText("LABEL_SAVE",True)'"Salvar"
		Me.AjudaToolStripMenuItem.Text = lang.getText("mnu_Help",True) '"Ajuda"
		Me.mnu_Help.Text = lang.getText("mnuRefHelp.Text",True) '"Manual OnLine"
		
		Me.Label1.Text = lang.getText("Label1.Text") & ":" '"Nom d'usuari :"
		Me.Label2.Text = lang.getText("Label2.Text") & ":"'"Nou Àlies :"
		Me.Label3.Text = lang.getText("Label3.Text") & ":"'"Repetir Àlies :"
		Me.GroupBoxAlies.Text = lang.getText("GroupBoxAlies.Text") '"Canviar l'àlies"
		
		Me.GroupBoxPassword.Text = lang.getText("GroupBoxPassword.Text") '"Canviar contrasenya"
		Me.Label20.Text = lang.getText("Label20.Text") '"Omplir si es vol modificar"
		Me.Label6.Text = Label20.Text '"Omplir si es vol modificar"
		Me.Label5.Text = lang.getText("Label5.Text") & ":"'"Repetir Contrasenya :"
		Me.Label4.Text = lang.getText("Label4.Text") & ":"'"Nova Contrasenya :"
		Me.lbTipusUser.Text = lang.getText("NOM_TIPUS_USER_CONVIDAT",True) '"Convidat"
		Me.Label7.Text = lang.getText("Label7.Text") & ":"'"Tipus d'usuari :"
		Me.Label8.Text = lang.getText("LABEL_DATA_CREACIO",True) & ":"'"Data de Creació :"
		Me.TabPage1.Text = lang.getText("TabPage1.Text") '"Pantalles / Programes"
		Me.ColumnEnable.HeaderText = lang.getText("ColumnEnable.HeaderText") '"Marcada"
		Me.ColumnNomPrg.HeaderText = lang.getText("ColumnNomPrg.HeaderText") '"Programa / Pantalla"
		Me.ColumnDescrip.HeaderText = lang.getText("LABEL_DESCRIPCIO",True) '"Descripció"
		Me.Label9.Text = lang.getText("Label9.Text") '"Només lectura, modificable només per l'administrador"
		Me.TabPage4.Text = lang.getText("TabPage4.Text") '"Àudio Visibles"
		Me.ColumnAudioVisible.HeaderText = lang.getText("LABEL_VISIBLE",True) '"Visible"
		Me.ColumnAudioNom.HeaderText = lang.getText("ColumnAudioNom.HeaderText") '"Nom Àudio"
		Me.TabPage5.Text = lang.getText("TabPage5.Text") '"Temes favorits"
		Me.ColumnFav.HeaderText = lang.getText("HEADERTEXT_FAVORITES",True) '"Favorites"
		Me.ColumnDataIn.HeaderText = lang.getText("ColumnDataIn.HeaderText") '"Data In Favor."
		Me.TabPage2.Text = lang.getText("LABEL_INSPECTOR",True) '"Inspector"
		'Me.lbCaducPassword.Text = "fsdf"
		Me.Label19.Text = lang.getText("Label19.Text") '"Caducitat Contrasenya :"
		'Me.lbCaducUser.Text = "fsdf"
		Me.Label17.Text = lang.getText("Label17.Text") & ":"'"Caducitat usuari :"
		Me.Label10.Text = lang.getText("Label10.Text") '"El tipus d'usuari només és modificable per l'administrador"
		'Me.lbPswErr.Text = "fsdf"
		'Me.lbDataUltIntErr.Text = "fsdf"
		Me.Label15.Text = lang.getText("LABEL_ULTIM_PASSWORD_ERR",True) & ":"'"Últim PassWord erroni :"
		Me.Label14.Text = lang.getText("LABEL_DATA_ULT_INTENT_ERR",True) & ":"'"Data últim intent erroni :"
		Me.Label13.Text = lang.getText("Label13.Text") & ":"'"Intents erronis a la últ. connexió :"
		Me.Label12.Text = lang.getText("LABEL_DATA_ULT_DESCONNEX",True) & ":"'"Data última desconnexió :"
		Me.Label11.Text = lang.getText("LABEL_DATA_ULT_CONNEX",True) & ":"'"Data última connexió :"
		Me.TabPage3.Text = lang.getText("TabPage3.Text") '"Historial de Connexions"
		Me.DataGridViewTextBoxColumn2.HeaderText = lang.getText("LABEL_IP",True) '"IP"
		Me.DataGridViewTextBoxColumn3.HeaderText = lang.getText("LABEL_HOST",True) '"Host"
		Me.DataGridViewTextBoxColumn5.HeaderText = lang.getText("LABEL_APLICACIO",True) '"Aplicació"
		Me.DataGridViewTextBoxColumn6.HeaderText = lang.getText("LABEL_DATA_CONNEX",True) '"Data Connex."
		'Me.ToolStrip1.Text = "ToolStrip1"
		Me.mnuAudioVisible.Text = lang.getText("mnuAudioVisible.Text") '"Fer àudio visible"
		Me.Text = lang.getText("Text") '"Gestió de l'usuari"
        Dim Cmb As New combo
        Cmb.OmpleCombo(Me.comboInterp, TAULES_DBS.TAULA_INTERPRETS, TotsCap.CAP)
        Cmb.OmpleCombo(Me.comboDisc, TAULES_DBS.TAULA_DISCOS, TotsCap.CAP)


    End Sub
	
	
	Private Sub cmdSortir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSortir.Click
		Me.Close()
	End Sub
	
	Private Sub LockedRecord()
		blEnable = Not blEnable
		Me.txtNomUser.Enabled = blEnable
		'GroupBoxPassword.Enabled = blEnable
		txtNouPasword.Enabled = blEnable
		txtRepetirPassword.Enabled = blEnable
		
		'GroupBoxAlies.Enabled = blEnable
		txtNouNick.Enabled = blEnable
		txtRepetirNick.Enabled = blEnable
		
		DataGridViewAudioUsers.ReadOnly = blEnable
		Me.gridTemes.ReadOnly = blEnable
		Me.mnuAddDelFav.Enabled = blEnable
		Me.mnuAudioVisible.Enabled = blEnable
		If blEnable Then
			Me.cmdBloqueix.Image = Me.picUnLock.Image
		Else
			Me.cmdBloqueix.Image = Me.picLock.Image
			Me.cmdSalvar.Enabled = False
			Me.mnuSave.Enabled = False
		End If
	End Sub
	
	Private Sub Changed()
		If blEnable = True Then Me.cmdSalvar.Enabled = True : Me.mnuSave.Enabled = True
	End Sub
	
	Private Sub txtTOTS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNomUser.TextChanged, txtNouNick.TextChanged _
		, txtRepetirNick.TextChanged, txtNouPasword.TextChanged, txtRepetirPassword.TextChanged
		Changed()
	End Sub
	
	Private Sub cmdSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalvar.Click        
		SaveRecord()
	End Sub
	
	Private Sub SaveRecord()
        If Not MyAPP.PermisPerContinuar() Then MetroFramework.MetroMessageBox.Show(Me, MSG_SERVER_CLOSE, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Stop, 100) : Me.Close()
        If Me.txtNomUser.Text.Length < 1 Then
            MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_NOM_BUIT, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
            txtNomUser.Focus()
            Exit Sub
        End If
        Dim StrSql As String = "UPDATE users SET  usr_nom = '" & Me.txtNomUser.Text.Trim & "'"

        If Me.txtNouNick.Text.Length = 0 Then
            'No fer res
        ElseIf Me.txtNouNick.Text.Length < 4 Then
            MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_NUM_CARACTERS, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
            txtNouNick.Text = ""
			txtRepetirNick.Text = ""
			txtNouNick.Focus()
			Exit Sub
		Else
            If Me.txtNouNick.Text.Trim <> Me.txtRepetirNick.Text.Trim Then
                MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_ALIES, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
                txtNouNick.Text = ""
                txtRepetirNick.Text = ""
                txtNouNick.Focus()
                Exit Sub
            Else
                'Tot OK
                StrSql += ", usr_alies = HEX(AES_ENCRYPT('" & txtNouNick.Text.Trim & "','" & MY_SECRET_KEY_TO_ENCRYPT & "'))"
			End If
		End If

        If Me.txtNouPasword.Text.Length = 0 Then
            'No fer res
        ElseIf Me.txtNouPasword.Text.Length < 4 Then
            MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_NUM_CARACTERS, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
            txtNouPasword.Text = ""
			txtRepetirPassword.Text = ""
			txtNouPasword.Focus()
			Exit Sub
		Else
            If Me.txtNouPasword.Text.Trim <> Me.txtRepetirPassword.Text.Trim Then
                MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_PASSWORDS, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
                txtNouPasword.Text = ""
                txtRepetirPassword.Text = ""
                txtNouPasword.Focus()
                Exit Sub
            Else
                'tot OK 
                StrSql += ", usr_password = HEX(AES_ENCRYPT('" & txtNouPasword.Text & "','" & MY_SECRET_KEY_TO_ENCRYPT & "'))"
				StrSql += ", usr_caducpsw = '1899-12-30'" ' Un cop canviem el password ja no caduca
			End If
		End If

        If MetroFramework.MetroMessageBox.Show(Me, MSG_CONFIRM_SAVE_DADES, MSG_ATENCIO, MessageBoxButtons.YesNo, MessageBoxIcon.Question, 100) = DialogResult.No Then Exit Sub

        StrSql += " WHERE usr_id = " & Me.lbID.Text & " ;"
        Dim db As New MSC.dbs(Cloud)
        db.IniTransaction()
		db.Update_ID(StrSql)
		
		'Salvem el audios visibles de l'usari        
		StrSql = "DELETE FROM user_audio WHERE user_id=" & Me.lbID.Text & " ;"
		db.Delete_ID(StrSql)
		StrSql = "INSERT INTO user_audio (user_id, audio_id, visible) VALUES "
		For i As Integer = 0 To AUV.Length - 1
			If i > 0 Then StrSql += ", "
			StrSql += "(" & Me.lbID.Text & ", " & AUV(i).AUV_ID & ", " & IIf(AUV(i).AUV_Visible = True, 1, 0) & ")"
		Next
		StrSql += " ;"
		db.New_ID(StrSql)
		' Els temes preferits es salven directament, de moment
		
		db.EndTransaction()
		db = Nothing
		
		RefreshDataSet(TAULES_DBS.TAULA_USER_AUDIO)
        frmMain.lbUserNom.Text = Me.txtNomUser.Text
        LockedRecord()
	End Sub
	
	Private Sub cmdBloqueix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBloqueix.Click
		LockedRecord()
	End Sub
	
	Private Function IsAudioForUser(ByVal AudioID As Integer, ByVal IDUsuari As Integer) As Boolean
		If Usuari.UsrID = 0 Then Return True
		If Usuari.UsrID > 0 Then
			Dim StrSql As String = "user_id=" & IDUsuari & " AND audio_id=" & AudioID
			Dim colec() As DataRow = dsClient.Tables("user_audio").Select(StrSql, "user_id")
			If colec.Length = 0 Then
				Return True
			Else
				Return CBool(colec(0)("visible"))
			End If
		End If
		
		Return True
		
	End Function
	
	Private Sub DataGridViewAudioUsers_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridViewAudioUsers.MouseDoubleClick
		
		Me.ContextMenuStripEditLists.Show(DataGridViewAudioUsers, e.X, e.Y)
	End Sub
	
	Private Sub gridTemes_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gridTemes.MouseDoubleClick
		
		Me.ContextMenuStripEditLists.Show(gridTemes, e.X, e.Y)
		
	End Sub
	
	Private Sub ContextMenuStripEditLists_Opening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStripEditLists.Opening
		Select Case ContextMenuStripEditLists.SourceControl.Name
			Case "gridTemes"
				Me.mnuAddDelFav.Visible = True
				Me.mnuAudioVisible.Visible = False
				If gridTemes.SelectedRows(0).Cells("ColumnFav").Value = 1 Then
					mnuAddDelFav.Text = LABEL_DEL_FAVORITES
					mnuAddDelFav.Image = Me.ImageListFavorites.Images.Item("favNO")
				Else
					mnuAddDelFav.Text = LABEL_ADD_FAVORITES
					mnuAddDelFav.Image = Me.ImageListFavorites.Images.Item("favSi")
				End If
			Case "DataGridViewAudioUsers"
				Me.mnuAddDelFav.Visible = False
				Me.mnuAudioVisible.Visible = True
				If DataGridViewAudioUsers.SelectedRows(0).Cells("ColumnAudioVisible").Value = 1 Then
					mnuAudioVisible.Text = LABEL_MAKE_INVISIBLE
				Else
					mnuAudioVisible.Text = LABEL_MAKE_VISIBLE
				End If
		End Select
	End Sub
	
	Private Sub mnuAudioVisible_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAudioVisible.Click
		
		'AUV(AUV.Length).AUV_ID = DataGridViewAudioUsers.SelectedRows(0).Cells("ColumnAudioID").Value
		If DataGridViewAudioUsers.SelectedRows(0).Cells("ColumnAudioVisible").Value = 1 Then
			DataGridViewAudioUsers.SelectedRows(0).Cells("ColumnAudioVisible").Value = 0
			AUV(DataGridViewAudioUsers.SelectedRows(0).Index).AUV_Visible = False
			
		Else
			DataGridViewAudioUsers.SelectedRows(0).Cells("ColumnAudioVisible").Value = 1
			AUV(DataGridViewAudioUsers.SelectedRows(0).Index).AUV_Visible = True
		End If
		Changed()
	End Sub
	
	Private Sub mnuAddDelFav_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAddDelFav.Click
        '        mnuAddDelFav.Checked = Not mnuAddDelFav.Checked
        Dim db As New MSC.dbs(Cloud)
        Dim SqlStr As String = ""
		Dim TemID As Integer = gridTemes.SelectedRows(0).Cells("columnFavID").Value
		If gridTemes.SelectedRows(0).Cells("ColumnFav").Value = 1 Then
			gridTemes.SelectedRows(0).Cells("ColumnFav").Value = 0
			SqlStr = "DELETE FROM user_temes WHERE usrtema_tema=" & TemID & " AND usrtema_user=" & Usuari.UsrID & " ;"
			db.Delete_ID(SqlStr)
		Else
			gridTemes.SelectedRows(0).Cells("ColumnFav").Value = 1
			SqlStr = "INSERT into user_temes (usrtema_user,usrtema_tema, usrtema_datain) VALUES (" & Usuari.UsrID & "," & TemID & ",now());"
			db.New_ID(SqlStr)
		End If
		db = Nothing
		Changed()
	End Sub
	
	Private Sub mnuSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSave.Click
		SaveRecord()
	End Sub
	
	Private Sub mnuModif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuModif.Click
		LockedRecord()
	End Sub
	
	Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
		Me.Close()
	End Sub
	
	Private Sub mnu_Help_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_Help.Click
		Dim Proces As Process = New Process
		Try
			Process.Start(MSC.Help.HELP_GEST_USUARIS_MANTENIMENT.ToString)
		Catch ex As Exception
		End Try
	End Sub

    Sub FrmMantUsuariFormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MyAPP.CloseSesionClient(MyAPP.IDSesion_Client, DESCRIP_FORM_MANT_USERS)
        Me.Dispose()
    End Sub
End Class