Option Strict Off
Option Explicit On
Imports MySql.Data.MySqlClient
Imports System.Drawing.Drawing2D
'TODO: adaptar la pantalla per ensenyar el nº de radiacions i el backup dels fitxers d'àudio.
Public Class frmProgrames
	Dim blEnable As Boolean
	Dim blnNouRecord As Boolean
	Dim IsSaving As Boolean = False
	'Dim PathProgrames As String = ""
	'Dim PlayerNumPart As Short = 1
	Dim ID_sessio As Integer = 1
	
	Const MAX_WIDTH_IMG As Integer = 500
	Const MAX_HEIDTH_IMG As Integer = 375
	Dim Flat_Edit_Image As Boolean = False
	Dim ChangeSessions As Boolean = False
	
	#Region " Pantalla "
	Private Sub frmMant_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		CloseForm()
	End Sub
	
	Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
		Me.Close()
	End Sub
	
	Private Sub NewRecord()
		blnNouRecord = True
		DeSelectAllRowsGrid(gridDades)
		gridDades.AllowUserToAddRows = True
		gridDades.FirstDisplayedScrollingRowIndex = gridDades.NewRowIndex
		Me.gridDades.Rows(gridDades.NewRowIndex).Selected = True
		Me.gridDades.Rows(gridDades.NewRowIndex).Cells(0).Value = 0
		'establir Valors per defecte (automàticament incorporats al datagrid)
		NetejaPantalla()
		
		blEnable = False
		LockedRecord()
		
		Me.lbNou.Visible = True
		txtNom.Focus()
		
	End Sub
	
	Private Sub NetejaPantalla()
		Me.lbID.Text = 0
		Me.txtNom.Text = ""
		Me.ComboTematica.SelectedIndex = 0
		'Me.gridSessions.Rows.Clear()
		Me.chkActive.Checked = False
		Me.txtObserv.Text = ""
		Me.txtTwitter.Text = ""
		Me.txtTwitter_key.Text = ""
		Me.txtFaceBook.Text = ""
		Me.txtDurada.Value = "01/01/1970 01:00"
        Me.pigProgram.Image = pigProgram.ErrorImage
        pic_cloudDown.Visible = False
        ListViewTags.Items.Clear()
		
	End Sub
	
	Private Sub LockedRecord(Optional ByVal saved As Boolean = False)
		If Me.cmdSalvar.Enabled = True And saved = False Then
            If MetroFramework.MetroMessageBox.Show(Me, MSG_SAVE_DADES, MSG_ATENCIO, MessageBoxButtons.OKCancel, MessageBoxIcon.Information, 100) = DialogResult.OK Then SaveRecord()
        End If
		blEnable = Not blEnable
		If blEnable = False Then blnNouRecord = False
		ChangeSessions = False
		Me.txtObserv.Enabled = blEnable
		ComboTematica.Enabled = blEnable
		chkActive.Enabled = blEnable
		
		Me.txtNom.Enabled = blEnable
		Me.mnuDel.Enabled = blEnable
		Me.mnuCalcDurada.Enabled = blEnable
		Me.mnuNew.Enabled = blEnable
		Me.mnuDel.Enabled = blEnable
		mnuEditAudio.Enabled = blEnable
		Me.chkActive.Enabled = blEnable
		Me.cmdBorrar.Enabled = blEnable
		Me.lbNou.Visible = False
		Me.txtFaceBook.Enabled = blEnable
		Me.txtTwitter.Enabled = blEnable
		Me.txtTwitter_key.Enabled = blEnable
		Me.ButtonAddPig.Enabled = blEnable
		ButtonDelPic.Enabled = blEnable
		Me.txtDurada.Enabled = blEnable
		Me.ListViewTags.Enabled = blEnable
		mnuBorrarSessio.Enabled = blEnable
		gridSessions.Columns("ColumnSesMare").ReadOnly = Not blEnable
		
		
		If blEnable Then
			Me.cmdBloqueix.Image = Me.picUnLock.Image
		Else
			Me.cmdBloqueix.Image = Me.picLock.Image
			Me.cmdSalvar.Enabled = False
			Me.mnuSave.Enabled = False
		End If
	End Sub
	
	Private Sub FindRecord()
		If txtBuscar.Text.Length = 0 Or txtBuscar.Text =  LABEL_BUSCAR & "..." Then Exit Sub
		Dim StrSql As String = Me.txtBuscar.Text
		Dim OpcBusca As Short
		For i As Integer = 0 To OptionBuscar.DropDownItems.Count - 1
			If CType(OptionBuscar.DropDownItems(i), ToolStripMenuItem).Checked = True Then OpcBusca = i : Exit For
		Next i
		If Not IsNumeric(txtBuscar.Text) Then OpcBusca = Buscar.BUSCAR_NOM
		Select Case OpcBusca
			Case Buscar.BUSCAR_ID
				StrSql = "prg_id = " & txtBuscar.Text
			Case Buscar.BUSCAR_NOM
				StrSql = "prg_nom LIKE '%" & txtBuscar.Text & "%'"
			Case Buscar.BUSCAR_TOTS
				StrSql = "prg_nom LIKE '%" & txtBuscar.Text & "%' OR prg_id = " & txtBuscar.Text
		End Select
		
		establirRecordset(StrSql)
	End Sub
	
	Private Sub txtNom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNom.TextChanged
		Try
			Dim RowID As Integer = FindAfectatRow()
			Me.gridDades.Rows(RowID).Cells("ColumnNom").Value = AddSlashes(txtNom.Text)
			changed()
		Catch ex As Exception
		End Try
	End Sub
	
	Private Sub lstRecord_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
		FindRecord()
	End Sub
	
	
	Private Sub frmMant_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
		setLanguageForm()
		If My.Settings.TXT_CAPITALIZE = True Then
			Me.txtNom.CharacterCasing = CharacterCasing.Upper
			Me.txtObserv.CharacterCasing = CharacterCasing.Upper
		End If

        OmpleMnuTAGS()
		
		If Not frmMain.NoLoadRs Then establirRecordset()
		Dim UsrTipus As Integer = Usuari.UsrTipus
		Me.cmdNou.Enabled = IIf(UsrTipus > NivellUsers.USR_CONVIDAT, True, False)
		Me.mnuNew.Enabled = cmdNou.Enabled
		mnuNew.Enabled = IIf(UsrTipus > NivellUsers.USR_CONVIDAT, True, False)

        Me.ClientSize = New Size(frm_sice(0), frm_sice(1))
    End Sub


    Dim MSG_ERROR_SAVE_TEMATICA As String
    Dim MSG_ERROR_NUMERIC_VALUE As String

    Public Sub setLanguageForm()
		lang.StrForm = Me.Name


        MSG_ERROR_SAVE_TEMATICA = lang.getText("MSG_ERROR_SAVE_TEMATICA") '"La temàtica és obligatòria"
        MSG_ERROR_NUMERIC_VALUE = lang.getText("MSG_ERROR_NUMERIC_VALUE") '"Entreu un valor numèric"
        'Me.MenuStrip1.Text = "MenuStrip1"
        Me.ProgarmaToolStripMenuItem.Text = lang.getText("LABEL_PROGRAMA",True) '"Programa"
		Me.mnuExit.Text = lang.getText("LABEL_EXIT",True) '"Sortir"
		Me.ReproductorToolStripMenuItem.Text = lang.getText("LABEL_REPRODUCTOR",True) '"Reproductor"
		Me.mnuPlay.Text = lang.getText("LABEL_PLAY_PAUSA",True) '"Play/Pausa"
		Me.mnuStop.Text = lang.getText("LABEL_STOP",True) '"Stop"
		Me.mnuCalcDurada.Text = lang.getText("LABEL_CALC_DURADA",True) '"Calcular Durada"
		Me.mnuFinal.Text = lang.getText("LABEL_END_TEMA",True) '"Final Tema"
		Me.EdicióToolStripMenuItem.Text = lang.getText("mnuEdit.Text",True )'"Edició"
		Me.mnuModif.Text = lang.getText("LABEL_MODIFICAR",True )'"Modificar"
		Me.mnuSave.Text = lang.getText("LABEL_SALVAR",True) '"Salvar"
		Me.mnuNew.Text = lang.getText("LABEL_NEW",True) '"Nou"
		Me.mnuDel.Text = lang.getText("LABEL_DELETE",True) '"Borrar"
		Me.mnuEditAudio.Text = lang.getText("mnuEditAudio.Text",True) '"Editar l'àudio"
		Me.mnuBuscar.Text = lang.getText("LABEL_BUSCAR",True)'"Buscar"
		Me.mnuRefresh.Text = Lang.getText("LABEL_REFRESCAR",True)'"Refrescar"
		Me.ToolStripMenuItem8.Text =  lang.getText("mnu_Help",True) '"Ajuda"
		Me.mnu_Help.Text = lang.getText("mnuRefHelp.Text",True) '"Manual OnLine"
		Me.chkActive.Text = lang.getText("LABEL_ACTIVA", True) '"Actiu"
		Me.Label2.Text = lang.getText("LABEL_NOM",True) & ":" '"Nom:"
		Me.Label1.Text = lang.getText("LABEL_IDENTIFICADOR",True) & ":" '"Identificador:"
		Me.lbNou.Text = lang.getText("LABEL_NEW_UPPER",True) '"NOU"
		'Me.cmdExit.Text = "Button1"
		'Me.ToolStrip1.Text = "ToolStrip1"
		Me.cmdPrimer.Text = lang.getText("LABEL_GOTO_FIRSH",True)'"Primer"
		Me.cmdPrevi.Text = lang.getText("LABEL_GOTO_PREV",True)'"Anterior"
		Me.cmdSeguent.Text = lang.getText("LABEL_GOTO_NEXT",True)'"Següent"
		Me.cmdUltim.Text = lang.getText("LABEL_GOTO_LAST",True)'"Últim"
		Me.cmdNou.Text = lang.getText("LABEL_NEW",True) '"Nou"
		Me.cmdBloqueix.Text = lang.getText("LABEL_EDITAR",True) '"Editar"
		Me.cmdBorrar.Text = lang.getText("LABEL_DELETE",True) '"Borrar"
		Me.cmdSalvar.Text = lang.getText("LABEL_SALVAR",True) '"Salvar"
		Me.cmdRefrescar.Text = Lang.getText("LABEL_REFRESCAR",True)'"Refrescar"
		Me.OptionBuscar.Text = lang.getText("LABEL_BUSCAR",True)'"Buscar"
		Me.PerIDToolStripMenuItem.Text = lang.getText("mnu_Buscar_ID",True)'"Per ID"
		Me.PerNomToolStripMenuItem.Text = lang.getText("mnu_Buscar_NOM",True)'"Per Nom"
		Me.QualsevolToolStripMenuItem.Text = lang.getText("mnu_Buscar_QUALSEVOL",True)'"Qualsevol"
		Me.mnu_OnlyActive.Text = lang.getText("LABEL_ONLY_ACTIVES",True)'"Només actives"
		Me.cmdSortir.Text = lang.getText("LABEL_EXIT",True) '"Sortir"
		Me.Label9.Text = lang.getText("LABEL_ACCEPT_HTML",True) '"accepta HTML"
        Me.Label4.Text = lang.getText("HEADERTEXT_DURADA", True) '"Durada"		
        Me.Label5.Text = lang.getText("HEADERTEXT_TEMATICA",True) '"Temàtica"
		Me.ColumnID.HeaderText = lang.getText("HEADERTEXT_ID",True) '"ID"
		Me.ColumnNom.HeaderText = lang.getText("LABEL_NOM",True) '"Nom"
		Me.ColumnComboTematica.HeaderText =  lang.getText("HEADERTEXT_TEMATICA",True) '"Temàtica"
		Me.ColumnActiva.HeaderText = lang.getText("LABEL_ACTIVA",True) '"Activa"
		Me.ColumnPrgDurada.HeaderText = lang.getText("HEADERTEXT_DURADA",True) '"Durada"
		Me.cmdPlay.Text = lang.getText("LABEL_PLAY_PAUSA",True) '"Play/Pausa"
		Me.ColumnDurada.HeaderText = lang.getText("HEADERTEXT_DURADA",True) '"Durada"
		Me.cmdStop.Text = lang.getText("LABEL_STOP",True) '"Stop"
		Me.ColumnDataRadi.HeaderText = lang.getText("LABEL_DATA_RADIACIO",True) '"Data Radiació"
		Me.ColumnDataCrea.HeaderText = lang.getText("HEADERTEXT_DATE_CREA",True) '"Data Creació"
		Me.Label6.Text = lang.getText("LABEL_DESCRIPCIO",True) '"Descripció"
		Me.ColumnObserv.HeaderText = lang.getText("LABEL_OBSERVACIONS",True) '"Observacions"
		Me.lbAtencio.Text = lang.getText("LABEL_NO_EXIST_FILE",True) '"No existeix el fitxer"
		
		Me.lbTAGS.Text = lang.getText("LABEL_TAGS",True) '"Etiquetes"
        Me.GroupBoxSocialMedia.Text = lang.getText("TabPage1.Text") '"Xarxes socials"
        Me.label11.Text = lang.getText("LABEL_TWITTER_KEY", True) '"Twitter Key"
        Me.Label7.Text = lang.getText("LABEL_TWITTER", True) '"Twitter"
        Me.Label3.Text = lang.getText("LABEL_FACEBOOK",True ) '"FaceBook"				
		Me.ColumnFaceBook.HeaderText = Label3.Text  '"FaceBook"
		Me.ColumnTwitter.HeaderText = lang.getText("LABEL_TWITTER",True) '"Twitter"
		Me.ColumnTwitterKey.HeaderText = lang.getText("LABEL_TWITTER_KEY",True) '"Twitter Key"		
		'Me.ToolStrip2.Text = "ToolStrip2"		
		Me.TabPage4.Text = lang.getText("TabPage4.Text") '"Llistat de Programes"
		Me.TabPage5.Text = lang.getText("TabPage5.Text") '"Sessions enregistrades"
		Me.Label10.Text = lang.getText("Label10.Text") '"Parts de la mateixa sessió agrupats per colors"
		Me.Label8.Text = lang.getText("Label8.Text") '"Nota: Per programar una re-emissió aneu al calendari"
		Me.ColumnSES_ID.HeaderText = lang.getText("ColumnSES_ID.HeaderText") '"Sessió ID"		
		Me.ColumnNumRadi.HeaderText = lang.getText("ColumnNumRadi.HeaderText") '"Núm Radiació"
		Me.ColumnSesMare.HeaderText = lang.getText("ColumnSesMare.HeaderText") '"Part de la Sessió (ID)"
		Me.ColumnSesMare.ToolTipText = lang.getText("ColumnSesMare.ToolTipText") '"La mateixa sessió dividida en parts"
		Me.ColumnNPart.HeaderText = lang.getText("ColumnNPart.HeaderText") '"N. Part"
		Me.mnuBorrarSessio.Text = lang.getText("mnuBorrarSessio.Text") '"Borrar Sessió"
		Me.OpenFileDialog1.Filter = lang.getText("LABEL_IMAGE_FILES",True) & " |*.gif; *.jpg; *.jpeg; *.bmp" '"arxius d'imatges |*.gif; *.jpg; *.jpeg; *.bmp"
		Me.OpenFileDialog1.Title = lang.getText("LABEL_SELECT_FOTO_62KB",True) '"Seleccioneu una foto (Max. 62Kb)"
		Me.mnuAddTAG.Text = lang.getText("LABEL_ADD_TAG", True) '"Afegir TAG"
		Me.mnuTotsTags.Text = lang.getText("LABEL_TOTS",True) '"Tots"
		Me.mnuCatTAGS.Text = lang.getText("LABEL_CATEGORIES",True) '"Categories"
		Me.mnuExcludeTAG.Text = lang.getText("LABEL_DEL_TAG",True) '"Borrar TAG"
        Me.Text = lang.getText("Text") '"Manteniment de programes"

        Dim Cmb As New combo
        Cmb.OmpleCombo(ComboTematica, TAULES_DBS.TAULA_TEMATIQUES, TotsCap.CAP) : ComboTematica.SelectedValue = 0
        Cmb.OmpleCombo(gridDades.Columns("ColumnComboTematica"), TAULES_DBS.TAULA_TEMATIQUES, TotsCap.CAP)
    End Sub
	
	Friend Sub OmpleMnuTAGS()
        Dim db As New MSC.dbs(Cloud)
        Dim dtTagCat As DataTable = db.getTable("SELECT * FROM `list_tags` WHERE tag_parent>0 group by tag_parent")
		Dim CatID As Integer = 0
		Dim mnuTAGCATMare As ToolStripMenuItem
		For i As Integer = 0 To dtTagCat.Rows.Count - 1
			Dim IdTag As Integer = dtTagCat.Rows(i)("tag_parent")
			mnuTAGCATMare = New ToolStripMenuItem
			mnuTAGCATMare.Text = getNomTAG(IdTag)
			mnuTAGCATMare.Tag = IdTag
			mnuTAGCATMare.Name = "mnuCat" & IdTag
			mnuCatTAGS.DropDownItems.Add(mnuTAGCATMare)
			Dim colecCat() As DataRow = dsClient.Tables("list_tags").Select("tag_parent=" & IdTag)
			
			Dim mnuTAGCAT As ToolStripMenuItem
			For n As Integer = 0 To colecCat.Length - 1
				mnuTAGCAT = New ToolStripMenuItem
				mnuTAGCAT.Text = colecCat(n)("tag_nom").ToString
				mnuTAGCAT.Tag = colecCat(n)("tag_id").ToString
				mnuTAGCATMare.DropDownItems.Add(mnuTAGCAT)
				AddHandler mnuTAGCAT.Click, AddressOf mnuTAG_Click
			Next
		Next
		
		Dim colec() As DataRow = dsClient.Tables("list_tags").Select("")
		Dim mnuTAG As ToolStripMenuItem
		For i As Integer = 0 To colec.Length - 1
			mnuTAG = New ToolStripMenuItem
			mnuTAG.Text = colec(i)("tag_nom").ToString
			mnuTAG.Tag = colec(i)("tag_id").ToString
			mnuTotsTags.DropDownItems.Add(mnuTAG)
			AddHandler mnuTAG.Click, AddressOf mnuTAG_Click
		Next
	End Sub
	
	Private Sub mnuTAG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
		
		Dim item As New ListViewItem
		item.Text = CType(sender, ToolStripMenuItem).Text
		item.Tag = CType(sender, ToolStripMenuItem).Tag
		Me.ListViewTags.Items.Add(item)
        Dim db As New MSC.dbs(Cloud)
        Dim sCmd As String = "UPDATE list_tags SET tag_count=tag_count+1 WHERE tag_id=" & item.Tag & " ;"
		db.Update_ID(sCmd)
		changed()
		
	End Sub
	
	#End Region
	
	Private Sub CloseForm()
		If Me.cmdSalvar.Enabled = True Then
            If MetroFramework.MetroMessageBox.Show(Me, MSG_SAVE_DADES, MSG_ATENCIO, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, 100) = DialogResult.OK Then SaveRecord()
        End If
		If Bass.BASS_ChannelIsActive(StreamHandlePlay) Then Call Bass.BASS_StreamFree(StreamHandlePlay)
		MyAPP.CloseSesionClient(MyAPP.IDSesion_Client, DESCRIP_FORM_PROGRAMES)

    End Sub
	
	Private Sub SaveRecord()
        If Not MyAPP.PermisPerContinuar() Then MetroFramework.MetroMessageBox.Show(Me, MSG_SERVER_CLOSE, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Stop, 100) : Me.Close()
        If MetroFramework.MetroMessageBox.Show(Me, MSG_CONFIRM_SAVE_DADES, MSG_ATENCIO, MessageBoxButtons.YesNo, MessageBoxIcon.Question, 100) = DialogResult.No Then Exit Sub

        If Len(Me.txtNom.Text) = 0 Then
            MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_NOM, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
            txtNom.Focus()
            Exit Sub
        ElseIf Me.ComboTematica.SelectedValue < 1 Then
            MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_SAVE_TEMATICA, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
            Me.ComboTematica.Focus()
			Exit Sub
		End If
		IsSaving = True
		Dim Nom As String = AddSlashes(Me.txtNom.Text)
		Dim ID As Integer = Me.lbID.Text
		
		Dim Activa As Boolean = Me.chkActive.Checked
		Dim Durada As Date = Me.txtDurada.Value
		Dim Tematic As Short = Me.ComboTematica.SelectedValue
		Dim Descrip As String = AddSlashes(Me.txtObserv.Text)
		Dim FaceBook As String = Me.txtFaceBook.Text
		Dim twitter As String = Me.txtTwitter.Text
		Dim twitter_key As String = Me.txtTwitter_key.Text
        Dim db As New MSC.dbs(Cloud)
        Dim sCmd As String = ""        
		
		If blnNouRecord = True Then
			
			sCmd = "INSERT INTO programes ( prg_nom, prg_tematica, prg_atv, prg_descripcio, prg_facebook, prg_twitter,prg_twitter_key,prg_durada)"
			sCmd = sCmd & " VALUES "
			sCmd = sCmd & "( '" & Nom & "'"
			sCmd = sCmd & " , " & Tematic
			sCmd = sCmd & " , " & CShort(IIf(Activa, 1, 0))
			sCmd = sCmd & " , '" & Descrip & "'"
			sCmd = sCmd & " , '" & FaceBook & "'"
			sCmd = sCmd & " , '" & twitter & "'"
			sCmd = sCmd & " , '" & twitter_key & "'"
			sCmd = sCmd & " , '" & Durada.ToString("HH:mm:ss") & "'"
			sCmd = sCmd & ");"
			
			ID = db.New_ID(sCmd)
			Me.gridDades.Rows(gridDades.NewRowIndex).Cells(0).Value = ID
			Dim newRecord As DataGridViewRow = gridDades.Rows(gridDades.NewRowIndex)
			Dim dt As DataTable
			If gridDades.DataSource IsNot Nothing Then
				dt = gridDades.DataSource
			Else
				dt = New DataTable
				For col As Integer = 0 To gridDades.Columns.Count - 1
					Dim idColumn As DataColumn = New DataColumn()
					idColumn.ColumnName = gridDades.Columns(col).DataPropertyName
					idColumn.DataType = newRecord.Cells(col).ValueType
					dt.Columns.Add(idColumn)
				Next
			End If
			Dim newRow As DataRow = dt.NewRow
			For i As Integer = 0 To newRecord.Cells.Count - 1
				Try
					
					newRow(i) = newRecord.Cells(i).Value
				Catch ex As Exception									
					Select Case newRecord.Cells(i).ValueType.FullName						
						Case "System.String" : newRow(i) = ""
						Case "System.TimeSpan" : newRow(i) = "00:00:00"
						Case "System.DateTime" : newRow(i) = Now.ToString("yyyy-MM-dd HH:mm:ss")
						Case Else : newRow(i) = 0
					End Select						
				End Try
			Next
			dt.Rows.Add(newRow)
			gridDades.AllowUserToAddRows = False
		Else
			db.IniTransaction()
			sCmd = "UPDATE programes"
			sCmd = sCmd & " SET "
			sCmd = sCmd & " prg_nom = '" & Nom & "'"
			sCmd = sCmd & ", prg_tematica = " & Tematic
			sCmd = sCmd & ", prg_atv = " & CShort(IIf(Activa, 1, 0))
			sCmd = sCmd & ", prg_descripcio = '" & Descrip & "'"
			sCmd = sCmd & ", prg_facebook = '" & FaceBook & "'"
			sCmd = sCmd & ", prg_twitter = '" & twitter & "'"
			sCmd = sCmd & ", prg_twitter_key = '" & twitter_key & "'"
			sCmd = sCmd & ", prg_durada = '" & Durada.ToString("HH:mm:ss") & "'"
			
			sCmd = sCmd & " WHERE prg_id = " & ID & " ;"
			db.Update_ID(sCmd)
			If ChangeSessions = True Then
				For i As Integer = 0 To Me.gridSessions.RowCount - 1
					sCmd = "UPDATE prg_sessions SET ses_sessiomare=" & gridSessions.Rows(i).Cells("ColumnSesMare").Value.ToString  & _                    
						", ses_durada='" & gridSessions.Rows(i).Cells("ColumnDurada").Value.ToString  & "'" & _
						" WHERE ses_id=" & gridSessions.Rows(i).Cells("ColumnSES_ID").Value.ToString  & " ;"
					db.Update_ID(sCmd)
				Next
			End If
			'Salvar els tags.
			'Borrar Tags
			sCmd = "DELETE FROM tags_relationships WHERE fitxer_id =" & ID & " AND relation_tipfitxer=" & Tipus_Fitxers.FITXER_PROGRAMA & " ;"
            db.Delete_ID(sCmd)
            addCtlRadi(0, CShort(Tipus_Play.CTL_SQL), 0, "00:00:00", 0, 0, Usuari.UsrID, sCmd, 0, False)
            If ListViewTags.Items.Count > 0 Then
				sCmd = "INSERT INTO tags_relationships (relation_tipfitxer,fitxer_id,tag_id) VALUES "
				For Each item As ListViewItem In Me.ListViewTags.Items
					If sCmd.Length > 76 Then sCmd += ","
					sCmd += "(" & Tipus_Fitxers.FITXER_PROGRAMA & "," & ID & "," & item.Tag & ")"
				Next
				sCmd += ";"
				db.New_ID(sCmd)
			End If
			db.EndTransaction()
		End If
		db = Nothing
		IsSaving = False
		If Flat_Edit_Image = True Then savePig(ID)
		RefreshDataSet(TAULES_DBS.TAULA_PROGRAMES)
		RefreshDataSet(TAULES_DBS.TAULA_RELATIONSHIPS_TAGS)
		LockedRecord(True)
		Me.gridDades.Focus()
	End Sub
	
	Private Sub DeleteRecord()
		If blnNouRecord = True Then 
			LockedRecord(True)
			NetejaPantalla()
			gridDades.AllowUserToAddRows = False
			Exit Sub
		End If
		
		'TODO: s'han de borrar també les sessions d'aquest programa
		Dim MsgTxt As String = MSG_CONFIRM_DELETE_DADES
        If gridDades.SelectedRows.Count > 1 Then MsgTxt = String.Format(MSG_CONFIRM_DELETE_NUM_DADES, gridDades.SelectedRows.Count)
        If MetroFramework.MetroMessageBox.Show(Me, MsgTxt, MSG_ATENCIO, MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, 100) = DialogResult.Cancel Then Exit Sub

        Dim db As New MSC.dbs(Cloud)
        Dim StrSql As String = ""
		Dim Fitxer As String
		db.IniTransaction()
		For i As Short = 0 To gridDades.SelectedRows.Count - 1
			'Borrar programa
			Dim IDProg As String = gridDades.SelectedRows(i).Cells("ColumnID").Value.ToString
			StrSql = "DELETE FROM programes WHERE prg_id =" & IDProg & " ;"
            db.Delete_ID(StrSql)
            addCtlRadi(0, CShort(Tipus_Play.CTL_SQL), 0, "00:00:00", 0, 0, Usuari.UsrID, StrSql, 0, False)
            'Borrar sessions
            StrSql = "DELETE FROM prg_sessions WHERE ses_prg =" & IDProg & " ;"
			db.Delete_ID(StrSql)
			'Borrar Tags
			StrSql = "DELETE FROM tags_relationships WHERE fitxer_id =" & IDProg & " AND relation_tipfitxer=" & Tipus_Fitxers.FITXER_PROGRAMA & " ;"
			db.Delete_ID(StrSql)
			'Borrar fitxer 
			For e As Integer = 0 To gridSessions.Rows.Count - 1
				Dim Ses_ID As Integer = gridSessions.Rows(e).Cells("ColumnSES_ID").Value
				Fitxer = Params.PathProgrames & "\" & Ses_ID & ".mp3"
				If IO.File.Exists(Fitxer) Then
					Try
						IO.File.Delete(Fitxer)
					Catch ex As Exception
					End Try
				End If
			Next
		Next
		db.EndTransaction()
		db = Nothing
		'Borrar llistat        
		gridDades.AllowUserToDeleteRows = True
		For Each selectedrow As DataGridViewRow In gridDades.SelectedRows			
			gridDades.Rows.Remove(selectedrow)				
		Next
		gridDades.AllowUserToDeleteRows = False
		
		RefreshDataSet(TAULES_DBS.TAULA_PROGRAMES)
		RefreshDataSet(TAULES_DBS.TAULA_SESSIONS_PROGRAMES)
	End Sub
	
	Private Sub changed()
		If blEnable = True Then Me.cmdSalvar.Enabled = True : Me.mnuSave.Enabled = True
	End Sub
	
	Private Sub establirRecordset(Optional ByVal WhereSql As String = "")
		system.Windows.Forms.Cursor.Current = Cursors.AppStarting
		Dim StrSql As String = "SELECT prg_id,prg_nom,prg_tematica,prg_atv,prg_descripcio,prg_facebook,prg_twitter,prg_twitter_key,prg_durada,prg_hash, prg_propia FROM programes"
		If WhereSql.Length > 0 Then StrSql = StrSql & " WHERE " & WhereSql
        Dim db As New MSC.dbs(Cloud)

        gridDades.DataSource = db.getTable(StrSql)
		db = Nothing
		Me.lbRecCount.Text = gridDades.Rows.Count
        If gridDades.Rows.Count = 0 Then MetroFramework.MetroMessageBox.Show(Me, MSG_NO_ITEM_FOR_CONDITION, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, 100)
        gridDades.Focus()
		
		cmdBloqueix.Enabled = IIf(gridDades.Rows.Count And Usuari.UsrTipus > NivellUsers.USR_CONVIDAT, True, False)
		Me.mnuModif.Enabled = cmdBloqueix.Enabled
		system.Windows.Forms.Cursor.Current = Cursors.Default
		
	End Sub
	
	Private Sub chkActive_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkActive.CheckedChanged
		Try
			Dim RowID As Integer = FindAfectatRow()
			Me.gridDades.Rows(RowID).Cells("ColumnActiva").Value = chkActive.Checked
			changed()
		Catch ex As Exception
		End Try
	End Sub
	
	
	Private Sub cmdPrimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrimer.Click
		gridDades.Focus()
		System.Windows.Forms.SendKeys.Send("^{HOME}")
	End Sub
	
	Private Sub cmdPrevi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrevi.Click
		gridDades.Focus()
		System.Windows.Forms.SendKeys.Send("{UP}")
	End Sub
	
	Private Sub cmdSeguent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSeguent.Click
		gridDades.Focus()
		System.Windows.Forms.SendKeys.Send("{DOWN}")
	End Sub
	
	Private Sub cmdUltim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUltim.Click
		gridDades.Focus()
		System.Windows.Forms.SendKeys.Send("^{END}")
	End Sub
	
	Private Sub cmdSortir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSortir.Click
		Me.Close()
	End Sub
	
	Private Sub cmdRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefrescar.Click
		establirRecordset()
	End Sub
	
	Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionBuscar.Click
		FindRecord()
	End Sub
	
	Private Sub cmdSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalvar.Click
		SaveRecord()
	End Sub
	
	Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
		DeleteRecord()
	End Sub
	
	Private Sub cmdBloqueix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBloqueix.Click
		LockedRecord()
	End Sub
	
	Private Sub cmdNou_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNou.Click
		NewRecord()
	End Sub
	
	Private Sub mnuStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuStop.Click
		StopFitxer()
	End Sub
	
	Private Sub mnuCalcDurada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCalcDurada.Click
		Dim StrPathPlay As String
		Dim localHandlePlay As Integer
		StrPathPlay = Params.PathProgrames & "\" & ID_sessio & ".mp3"
		localHandlePlay = Bass.BASS_StreamCreateFile(StrPathPlay, 0, 0, 0)
		Dim len As Long = Bass.BASS_ChannelGetLength(localHandlePlay)
		gridSessions.SelectedRows(0).Cells("ColumnDurada").Value = TimeSerial(0, 0, Bass.BASS_ChannelBytes2Seconds(localHandlePlay, len)).ToString("HH:mm:ss")
		
		If localHandlePlay > 0 Then
			Bass.BASS_ChannelStop(localHandlePlay)
			Bass.BASS_StreamFree(localHandlePlay)
		End If
		changed()
		ChangeSessions= True 
	End Sub
	
	Private Sub mnuModif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuModif.Click
		LockedRecord()
	End Sub
	
	Private Sub mnuSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSave.Click
		SaveRecord()
	End Sub
	
	Private Sub mnuNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNew.Click
		NewRecord()
	End Sub
	
	Private Sub mnuDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDel.Click
		DeleteRecord()
	End Sub
	
	Private Sub mnuBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBuscar.Click
		FindRecord()
	End Sub
	
	Private Sub mnuRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRefresh.Click
		establirRecordset()
	End Sub
	
	Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
		Me.Close()
	End Sub
	
	Private Sub ComboTematica_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboTematica.SelectedIndexChanged
		Try
			Dim RowID As Integer = FindAfectatRow()
			Me.gridDades.Rows(RowID).Cells("ColumnComboTematica").Value = ComboTematica.SelectedValue
			changed()
		Catch ex As Exception
		End Try
	End Sub
	
	Private Sub txtObserv_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtObserv.TextChanged
		Try
			Dim RowID As Integer = FindAfectatRow()
			Me.gridDades.Rows(RowID).Cells("ColumnObserv").Value = AddSlashes(txtObserv.Text)
			changed()
		Catch ex As Exception
		End Try
	End Sub
	
	Private Sub gridDades_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridDades.CurrentCellChanged
		If IsSaving = True Then Exit Sub
		Me.lbAtencio.Visible = False
		Me.pic_cloudUp.Visible = False
		Me.pic_cloudDown.Visible = False
		tmrDetalls.Enabled = False
		Try
			If blEnable = True Then LockedRecord()
			Me.lbID.Text = gridDades.CurrentRow.Cells("ColumnID").Value
			Me.txtNom.Text = StripSlashes(gridDades.CurrentRow.Cells("ColumnNom").Value)
			Me.ComboTematica.SelectedValue = gridDades.CurrentRow.Cells("ColumnComboTematica").Value 'gridDades.CurrentRow.Cells(17).Value 'CType(gridDades.Columns("ColumnComboTematica"), DataGridViewComboBoxColumn).se
			Me.txtObserv.Text = StripSlashes(gridDades.CurrentRow.Cells("ColumnObserv").Value.ToString)
			Me.chkActive.Checked = gridDades.CurrentRow.Cells("ColumnActiva").Value
			Me.txtFaceBook.Text = gridDades.CurrentRow.Cells("ColumnFaceBook").Value.ToString
			Me.txtTwitter.Text = gridDades.CurrentRow.Cells("ColumnTwitter").Value.ToString
			Me.txtTwitter_key.Text = NoNul(gridDades.CurrentRow.Cells("ColumnTwitterKey").Value)
			Dim Ts As TimeSpan = gridDades.CurrentRow.Cells("ColumnPrgDurada").Value
			Dim propia As Boolean = CBool(gridDades.CurrentRow.Cells("ColumnPropia").Value)
			Dim Hash As String = NoNul(gridDades.CurrentRow.Cells("ColumnHash").Value)
			If Hash.Length >2 AndAlso propia = True Then
				Me.pic_cloudUp.Visible = True
			ElseIf Hash.Length >2 AndAlso propia = False  Then
				Me.pic_cloudDown.Visible = True  
			End If			
			
			Me.txtDurada.Value = New Date(1970, 1, 1, Ts.Hours, Ts.Minutes, 0)
			
			
			Me.lbPosition.Text = Me.gridDades.CurrentRow.Index + 1
			Me.cmdSalvar.Enabled = False
			'Busca tags
			ListViewTags.Items.Clear()
			Dim StrSql As String = "relation_tipfitxer=" & Tipus_Fitxers.FITXER_PROGRAMA & " AND fitxer_id=" & lbID.Text
			Dim colec() As DataRow = dsClient.Tables("tags_relationships").Select(StrSql)
			For i As Integer = 0 To colec.Length - 1
				Dim item As New ListViewItem
				item.Text = colec(i)("tag_nom").ToString
				item.Tag = colec(i)("tag_id").ToString
				Me.ListViewTags.Items.Add(item)
			Next
			colec = Nothing
			tmrDetalls.Enabled = True
		Catch ex As Exception
			NetejaPantalla()
		End Try
		
	End Sub
	
	'''' <summary>
	'''' Busca al calendari totes les sessions seleccionades.
	'''' </summary>
	'''' <remarks></remarks>
	'Private Sub refreshListCalendar()
	
	'    ListCalendar.Items.Clear()
	'    's'han de llistar les hores que hi ha al calendàri aquest programa 
	'    '1-Busquem quines pautes fan servir les sessions d'aquest programa
	
	'    If gridSessions.Rows.Count > 0 Then
	
	'        Dim StrIdSessio As String = ""
	'        For i As Integer = 0 To gridSessions.SelectedRows.Count - 1
	'            Dim Ses_ID As Integer = gridSessions.SelectedRows(i).Cells("ColumnSES_ID").Value
	'            If i > 0 Then StrIdSessio = StrIdSessio & " OR "
	'            StrIdSessio = StrIdSessio & "listPautaIdSessio = " & Ses_ID.ToString
	'        Next i
	'        If StrIdSessio.Length > 0 Then
	'            Dim list() As DataRow = dsClient.Tables("listpautes").Select(StrIdSessio)
	'            Dim Where As String = ""
	'            For Each NewRow As DataRow In list
	'                Dim IdPauta As Integer = NewRow("listPautaID").ToString()
	'                If Where.Length > 0 Then Where = Where & " OR "
	'                Where = Where & "calPautaId = " & IdPauta
	'            Next
	'            'readList.Close()
	'            If Where.Length > 1 Then
	'                'Busca al calendàri on es fa servir aquesta pauta.
	'                Dim listCal() As DataRow = dsClient.Tables("calendari").Select(Where)
	'                For Each NewRow As DataRow In listCal
	'                    Dim dataCal As String = NewRow("calData").ToString
	'                    Dim IDCal As Integer = NewRow("calID")
	'                    Dim NewItem As ListViewItem = ListCalendar.Items.Add(dataCal)
	'                    NewItem.Tag = IDCal
	'                Next
	'            End If
	'        End If
	'    End If
	'    Me.cmdDelPauta.Enabled = IIf(ListCalendar.Items.Count > 0, True, False)
	'End Sub
	
	Private Sub OpcionsBuscar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PerIDToolStripMenuItem.Click, PerNomToolStripMenuItem.Click, QualsevolToolStripMenuItem.Click
		For i As Integer = 0 To OptionBuscar.DropDownItems.Count - 1
			CType(OptionBuscar.DropDownItems(i), ToolStripMenuItem).Checked = False
		Next
		CType(sender, ToolStripMenuItem).Checked = True
	End Sub
	
	Private Sub txtBuscar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.GotFocus
		txtBuscar.Text = ""
	End Sub
	
	Private Sub txtBuscar_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuscar.KeyUp
		If e.KeyCode = Keys.Enter Then FindRecord()
	End Sub
	
	Private Sub txtBuscar_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.LostFocus
		FindRecord()
	End Sub
	
	Private Function FindAfectatRow() As Integer
		If blnNouRecord Then
			Return gridDades.NewRowIndex
		Else
			Return gridDades.CurrentRow.Index
		End If
	End Function
	
	#Region "Player"
	Dim VolMax As Single
	Dim Atack As Integer = 50
	Dim StreamHandlePlay As Integer
	Dim InSrolling As Boolean
	Dim isActive As Un4seen.Bass.BASSActive
	
	Private Sub PlayFitxer()
		isActive = Bass.BASS_ChannelIsActive(StreamHandlePlay)
		If isActive = BASSActive.BASS_ACTIVE_PLAYING Then
			Bass.BASS_ChannelPause(StreamHandlePlay)
		ElseIf isActive = BASSActive.BASS_ACTIVE_PAUSED Then
			Bass.BASS_ChannelPlay(StreamHandlePlay, False)
		Else
			Dim strPathFitxer As String = Params.PathProgrames & ID_sessio & ".mp3"
            If Not IO.File.Exists(strPathFitxer) Then MetroFramework.MetroMessageBox.Show(Me, MSG_FILE_NO_EXIST, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
            Bass.BASS_ChannelStop(StreamHandlePlay)
			StreamHandlePlay = Bass.BASS_StreamCreateFile(strPathFitxer, 0, 0, 0)
			If StreamHandlePlay = 0 Then
				'Can't play stream
				tmrPlayer.Enabled = False
				Exit Sub
			End If
			
			If Bass.BASS_ChannelPlay(StreamHandlePlay, False) = False Then
				'Can't play stream
				tmrPlayer.Enabled = False
				Exit Sub
			End If
			
		End If
		tmrPlayer.Enabled = True
	End Sub
	
	Private Sub stopFitxer()
		Bass.BASS_ChannelStop(StreamHandlePlay)
	End Sub

    Private Sub cmdPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPlay.Click
        ' Fer unPlay o un stop
        PlayFitxer()
    End Sub

    Private Sub cmdStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStop.Click
        stopFitxer()
    End Sub

    Private Sub tmrPlayer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPlayer.Tick
        Dim RealVol As Integer
        Dim LVol As Integer
        Dim RVol As Integer
        Dim vol As Integer = 0

        isActive = Bass.BASS_ChannelIsActive(StreamHandlePlay)
        Select Case isActive
            Case BASSActive.BASS_ACTIVE_STOPPED
                Me.cmdStop.Enabled = False
                cmdPlay.Image = Me.picPlay.Image
                Me.mnuStop.Enabled = False
                tmrPlayer.Enabled = False
            Case BASSActive.BASS_ACTIVE_PAUSED
                cmdPlay.Image = Me.picPlay.Image
            Case BASSActive.BASS_ACTIVE_PLAYING
                Me.cmdStop.Enabled = True
                cmdPlay.Image = Me.picPause.Image
                Me.mnuStop.Enabled = True
        End Select

        vol = Bass.BASS_ChannelGetLevel(StreamHandlePlay)
        If vol < 0 Then vol = 0
        LVol = Un4seen.Bass.Utils.HighWord(vol)
        RVol = Un4seen.Bass.Utils.LowWord(vol)
        RealVol = (LVol + RVol) / 2 'Volum màxim = 32768
        If VolMax < RealVol Then
            VolMax = RealVol
        Else
            ' s'ha de trobar la fórmula logarítmica (valor màxim 32769 )
            If VolMax > 32000 Then
                VolMax = VolMax - (10 * Atack)
            ElseIf VolMax > 30000 Then
                VolMax = VolMax - (15 * Atack)
            ElseIf VolMax > 25000 Then
                VolMax = VolMax - (25 * Atack)
            ElseIf VolMax > 20000 Then
                VolMax = VolMax - (35 * Atack)
            ElseIf VolMax > 10000 Then
                VolMax = VolMax - (50 * Atack)
            Else
                VolMax = VolMax - (100 * Atack)
            End If
        End If
        If isActive = BASSActive.BASS_ACTIVE_STOPPED Or isActive = BASSActive.BASS_ACTIVE_PAUSED Then LVol = 4 : RVol = 4

        '---------------------------------------------
        Dim bit As Bitmap = New Bitmap(picVuMeter.Width, picVuMeter.Height)
        Dim graph As Graphics = Graphics.FromImage(bit)
        Dim LimePen As New Pen(Color.Lime, 8)
        Dim PeakPen As New Pen(Color.Red, 8)
        Dim PositionPen As New Pen(Color.Black, 1)
        Dim x As Integer
        graph.SmoothingMode = SmoothingMode.AntiAlias

        ' Pinta Volum dreta i esquerra
        x = (RVol / 32768) * picVuMeter.Width
        If x > picVuMeter.Width Then x = picVuMeter.Width
        graph.DrawLine(LimePen, picVuMeter.Width - x, 8, picVuMeter.Width, 8)

        x = (LVol / 32768) * picVuMeter.Width
        If x > picVuMeter.Width Then x = picVuMeter.Width
        graph.DrawLine(LimePen, picVuMeter.Width - x, 8 + 12, picVuMeter.Width, 8 + 12)

        'Pinta posició
        Dim pos As Long = Bass.BASS_ChannelGetPosition(StreamHandlePlay)
        Dim len As Long = Bass.BASS_ChannelGetLength(StreamHandlePlay)
        Dim bpp As Double = len / CType(Me.picVuMeter.Width, Double) ' bytes per pixel        
        ' position (x) where to draw the line, Integer)
        x = CType(Math.Round(pos / bpp), Double)
        graph.DrawLine(PositionPen, x, 0, x, Me.picVuMeter.Height - 1)

        If VolMax > 0 Then
            'Pinta peak
            x = (VolMax / 32768) * picVuMeter.Width
            If x > picVuMeter.Width Then x = picVuMeter.Width
            graph.DrawLine(PeakPen, picVuMeter.Width - x, 8, picVuMeter.Width - x - 2, 8)
            graph.DrawLine(PeakPen, picVuMeter.Width - x, 8 + 12, picVuMeter.Width - x - 2, 8 + 12)
        End If

        'draw the visual onto the picturebox
        picVuMeter.Image = bit
        Try
            LimePen.Dispose()
            PeakPen.Dispose()
            graph.Dispose()
        Catch ex As Exception
        Finally
            LimePen = Nothing
            PeakPen = Nothing
            bit = Nothing
            graph = Nothing
        End Try

    End Sub

    Private Sub mnuPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPlay.Click, mnuStop.Click, mnuFinal.Click

        Select Case CType(sender, ToolStripMenuItem).Tag
            Case 1 : PlayFitxer()
            Case 2 : stopFitxer()
                'Case 3
                '    Dim len As Long = Bass.BASS_ChannelGetLength(StreamHandlePlay)
                '    Me.lbDurada.Text = TimeSerial(0, 0, Bass.BASS_ChannelBytes2Seconds(StreamHandlePlay, len))
                '    Dim RowID As Integer = FindAfectatRow()
                '    Me.gridDades.Rows(RowID).Cells(18).Value = lbDurada.Text
                '    changed()
            Case 4
                Dim len As Long = Bass.BASS_ChannelGetLength(StreamHandlePlay)
                Dim LenInSeg As Single = Bass.BASS_ChannelBytes2Seconds(StreamHandlePlay, len)
                Bass.BASS_ChannelSetPosition(StreamHandlePlay, CSng(LenInSeg - 20))
        End Select
    End Sub

    Private Sub picVuMeter_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picVuMeter.MouseClick
        'estableix la posicio del ratolí a sobre el Pig
        Dim len As Long = Bass.BASS_ChannelGetLength(StreamHandlePlay)
        Dim bpp As Double = len / CType(Me.picVuMeter.Width, Double) ' bytes per pixel        
        'Quin és el pixel on es troba el ratolí
        Dim pr As Integer = 0
        Dim LocalMousePosition As Point = picVuMeter.PointToClient(System.Windows.Forms.Cursor.Position)
        'Posició on s'ha de desplaçar        
        Dim PosADespla As Single = Bass.BASS_ChannelBytes2Seconds(StreamHandlePlay, CLng(LocalMousePosition.X * bpp))
        'Desplaçar-ho
        Bass.BASS_ChannelSetPosition(StreamHandlePlay, PosADespla)
    End Sub

#End Region

    Private Sub tmrDetalls_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDetalls.Tick

        tmrDetalls.Enabled = False
        Dim ExistFile As Boolean = False
        Dim db As New MSC.dbs(Cloud)
        Dim StrSql As String = "SELECT ses_id,ses_durada,ses_dataradiacio,ses_datacreacio,ses_numradiacions, ses_sessiomare FROM `prg_sessions` WHERE ses_prg=" & lbID.Text & ";"
        gridSessions.DataSource = db.getTable(StrSql)
        Dim SesioMare As Integer = 0
        Dim Part As Integer = 1
        Dim BackColorGrid As System.Drawing.Color = Color.White
        For i As Integer = 0 To gridSessions.RowCount - 1
            If gridSessions.Rows(i).Cells("ColumnSesMare").Value <> SesioMare Or SesioMare = 0 Then
                Part = 1
                SesioMare = gridSessions.Rows(i).Cells("ColumnSES_ID").Value
                If BackColorGrid <> Color.White Then
                    BackColorGrid = Color.White
                Else
                    BackColorGrid = Color.Gainsboro
                End If
            End If
            gridSessions.Rows(i).Cells("ColumnNPart").Value = "Part " & Part
            gridSessions.Rows(i).DefaultCellStyle.BackColor = BackColorGrid
            Part += 1
        Next
        If gridSessions.Rows.Count > 0 Then
            ID_sessio = gridSessions.Rows(0).Cells("ColumnSES_ID").Value
            Dim strPathFitxer As String = Params.PathProgrames & "\" & ID_sessio & ".mp3"
            ExistFile = IO.File.Exists(strPathFitxer)
            'refreshListCalendar()
        End If
        gridSessions.Refresh()
        db = Nothing
        'gridSessions.Refresh()
        Me.lbAtencio.Visible = Not ExistFile
        LoadPictureFromDBS(lbID.Text)
    End Sub

    Private Sub gridSessions_CellValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridSessions.CellValidated
        ChangeSessions = True
        changed()
    End Sub

    Private Sub gridSessions_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridSessions.SelectionChanged
        Try
            ID_sessio = gridSessions.SelectedRows(0).Cells("ColumnSES_ID").Value
            'PlayerNumPart = gridSessions.SelectedRows(0).Cells("ColumnPart").Value
            Dim strPathFitxer As String = Params.PathProgrames & "\" & ID_sessio & ".mp3"
            Me.lbAtencio.Visible = Not IO.File.Exists(strPathFitxer)
        Catch ex As Exception
            'ID_sesio = 0
        End Try
    End Sub

    Private Sub ButtonAddPig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAddPig.Click
        If Me.OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Me.pigProgram.Image = resizeImageFromPath(OpenFileDialog1.FileName, MAX_WIDTH_IMG, MAX_HEIDTH_IMG)
            Me.pigProgram.Cursor = Cursors.Hand
            Flat_Edit_Image = True
            changed()
        End If
    End Sub

    Private Sub ButtonDelPic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDelPic.Click
        Me.pigProgram.Image = pigProgram.ErrorImage
        Flat_Edit_Image = True
        Me.pigProgram.Cursor = Cursors.Default
        changed()
    End Sub

    Private Sub savePig(ByVal id_programa As Integer)
        If pigProgram.Image Is Nothing Then Exit Sub

        Dim ms As IO.MemoryStream = New IO.MemoryStream
        pigProgram.Image.Save(ms, Imaging.ImageFormat.Jpeg)

        Dim bytBLOBData(CInt(ms.Length - 1)) As Byte

        ms.Position = 0
        ms.Read(bytBLOBData, 0, CInt(ms.Length))

        Dim prm As New MySql.Data.MySqlClient.MySqlParameter("@Picture",
            MySql.Data.MySqlClient.MySqlDbType.Blob,
            bytBLOBData.Length, ParameterDirection.Input, False,
            0, 0, Nothing, DataRowVersion.Current, bytBLOBData)

        Dim db As New MSC.dbs(Cloud)
        Dim StrSql As String = "UPDATE programes SET prg_imatge=@Picture WHERE prg_id=" & id_programa.ToString & ";"
        db.ExecuteInstruc(StrSql, prm)
        db = Nothing

    End Sub


    Private Sub LoadPictureFromDBS(ByVal id_programa As Integer)

        Dim strSql As String = "SELECT prg_imatge FROM programes where prg_id=" & id_programa.ToString & " ;"
        Dim db As New MSC.dbs(Cloud)

        Dim dataTB As DataTable = db.getTable(strSql)
        Me.pigProgram.Image = Me.pigProgram.ErrorImage
        Me.pigProgram.Cursor = Cursors.Default
        Me.pigProgram.Cursor = Cursors.Default
        If dataTB Is Nothing Then Exit Sub
        If dataTB.Rows.Count > 0 Then
            Try
                Me.pigProgram.Image = GetImageFromByteArray(CType(dataTB.Rows(0)(0), Byte()))
                Me.pigProgram.Cursor = Cursors.Hand
            Catch ex As Exception
                Me.pigProgram.Image = Me.pigProgram.ErrorImage
                Me.pigProgram.Cursor = Cursors.Default
            End Try
        End If
        dataTB.Dispose()
        db = Nothing
    End Sub

    Private Sub pigContacte_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles pigProgram.DoubleClick
        If Me.pigProgram.Cursor = Cursors.Hand Then
            Try
                frmPicture.PictureBoxPersona.Image = pigProgram.Image
                frmPicture.Text = Me.txtNom.Text & " ( " & Me.txtNom.Text & " )"
                frmPicture.Show(Me)
            Catch ex As Exception
                frmPicture.WindowState = FormWindowState.Normal
            End Try
        End If
    End Sub

    Private Sub txtFaceBook_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFaceBook.TextChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ColumnFaceBook").Value = txtFaceBook.Text
            changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtTwitter_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTwitter.TextChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ColumnTwitter").Value = txtTwitter.Text
            changed()
        Catch ex As Exception
        End Try
    End Sub


    Private Sub mnuEditAudio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditAudio.Click

        Bass.BASS_ChannelStop(StreamHandlePlay)
        Bass.BASS_StreamFree(StreamHandlePlay)
        If ProgEditAudio.Length > 0 Then
            Dim PathFitxer As String = ""
            For i As Integer = 0 To gridSessions.SelectedRows.Count - 1
                Dim tempPath As String = Params.PathProgrames & "\" & gridSessions.SelectedRows(i).Cells("ColumnSES_ID").Value & ".mp3"
                If IO.File.Exists(tempPath) Then
                    PathFitxer += " " & Chr(34) & tempPath & Chr(34)
                End If
            Next
            If PathFitxer.Length < 3 Then Exit Sub


            Dim p As System.Diagnostics.Process = New System.Diagnostics.Process()
            p.StartInfo.Arguments = PathFitxer
            p.StartInfo.FileName = ProgEditAudio
            Try
                p.Start()
            Catch ex As Exception

                Throw
            End Try
        End If
    End Sub

    Private Sub mnuBorrarSessio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBorrarSessio.Click
        Dim MsgTxt As String = MSG_CONFIRM_DELETE_DADES
        If gridDades.SelectedRows.Count > 1 Then MsgTxt = String.Format(MSG_CONFIRM_DELETE_NUM_DADES, gridSessions.SelectedRows.Count)
        If MetroFramework.MetroMessageBox.Show(Me, MsgTxt, MSG_ATENCIO, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, 100) = DialogResult.Cancel Then Exit Sub

        Dim db As New MSC.dbs(Cloud)
        db.IniTransaction()
        For i As Short = 0 To gridDades.SelectedRows.Count - 1
            'Borrar sessions
            Dim IDSessio As String = gridSessions.SelectedRows(i).Cells("ColumnSES_ID").Value.ToString
            Dim StrSql As String = "DELETE FROM prg_sessions WHERE ses_id =" & IDSessio & " ;"
            db.Delete_ID(StrSql)
            addCtlRadi(0, CShort(Tipus_Play.CTL_SQL), 0, "00:00:00", 0, 0, Usuari.UsrID, StrSql, 0, False)
            StrSql = "UPDATE prg_sessions SET ses_sessiomare=0 WHERE ses_sessiomare=" & IDSessio & " ;"
            db.Update_ID(StrSql)
            'Borrar fitxer 
            Dim Fitxer As String = Params.PathProgrames & "\" & IDSessio.ToString & ".mp3"
            If IO.File.Exists(Fitxer) Then
                Try
                    IO.File.Delete(Fitxer)
                Catch ex As Exception
                End Try
            End If
        Next
        db.EndTransaction()
        db = Nothing

        'Borrar llistat        
        gridSessions.AllowUserToDeleteRows = True
        For Each selectedrow As DataGridViewRow In gridSessions.SelectedRows
            gridSessions.Rows.Remove(selectedrow)
        Next
        gridSessions.AllowUserToDeleteRows = False

        RefreshDataSet(TAULES_DBS.TAULA_SESSIONS_PROGRAMES)

    End Sub

    Private Sub gridSessions_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles gridSessions.DataError
        gridSessions.Rows(e.RowIndex).Cells("ColumnSesMare").Value = 0
        MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_NUMERIC_VALUE, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
    End Sub

    Private Sub txtDurada_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDurada.ValueChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ColumnPrgDurada").Value = txtDurada.Value.ToLongTimeString
            changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ListViewTags_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListViewTags.MouseDown
        Me.ContextMenuStripTags.Show(ListViewTags, Me.ListViewTags.PointToClient(System.Windows.Forms.Cursor.Position))
    End Sub

    Private Sub ContextMenuStripTags_Opening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStripTags.Opening
        Me.mnuExcludeTAG.Enabled = (Me.ListViewTags.Items.Count > 0)
    End Sub

    Private Sub mnuExcludeTAG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExcludeTAG.Click
        Dim listItem As ListViewItem
        For Each listItem In ListViewTags.SelectedItems
            ListViewTags.Items.Remove(listItem)
            Dim db As New MSC.dbs(Cloud)
            Dim sCmd As String = "UPDATE list_tags SET tag_count=tag_count-1 WHERE tag_id=" & listItem.Tag & " ;"
            db.Update_ID(sCmd)
            db = Nothing
        Next
        changed()
    End Sub

    Private Sub lbTAGS_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbTAGS.LinkClicked
        Dim tag_sel As String = ""
        Dim Nofind As Boolean = False
        Try
            tag_sel = ListViewTags.SelectedItems(0).Text
        Catch ex As Exception
            Nofind = True
        End Try

        Dim frmChill As New frmMantTags
        Try
            frmChill.IniTable()
            If Nofind = False Then frmChill.establirRecordset("tag_nom = '" & tag_sel & "'")
            If frmChill.ShowDialog = DialogResult.OK Then
                ListViewTags.Items.Clear()
                Dim StrSql As String = "relation_tipfitxer=" & Tipus_Fitxers.FITXER_PROGRAMA & " AND fitxer_id=" & lbID.Text
                Dim colec() As DataRow = dsClient.Tables("tags_relationships").Select(StrSql)
                For i As Integer = 0 To colec.Length - 1
                    Dim item As New ListViewItem
                    item.Text = colec(i)("tag_nom").ToString
                    item.Tag = colec(i)("tag_id").ToString
                    Me.ListViewTags.Items.Add(item)
                Next
                colec = Nothing
                OmpleMnuTAGS()
            End If
        Catch ex As Exception
        End Try
        frmChill = Nothing
    End Sub


    Private Sub mnu_Help_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_Help.Click
        Dim Proces As Process = New Process
        Try
            Process.Start(MSC.Help.HELP_GEST_PRODUCCIO_PROGRAMES.ToString)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub mnu_OnlyActive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_OnlyActive.Click
        establirRecordset(" prg_atv=1")
    End Sub

    Sub TxtTwitter_keyTextChanged(sender As Object, e As EventArgs) Handles txtTwitter_key.TextChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ColumnTwitterKey").Value = txtTwitter_key.Text
            changed()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub frmProgrames_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        Dim FitxerINI As New IniFile
        frm_sice(0) = Me.Width : frm_sice(1) = Me.Height
        FitxerINI.INIWrite(MyAPP.IniFile, "Data Gest", "size", frm_sice(0).ToString & "," & frm_sice(1).ToString)
    End Sub
End Class