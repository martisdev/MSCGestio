Option Strict Off
Option Explicit On

Public Class frmEsdeveniment

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
		grupEsdev.Enabled = True
		Me.cmbTipFitxer.Focus()
		cmdSave.Enabled = True
		Me.txtNom.Text = ""
		Me.cmbFitxer.SelectedValue = 0
		Me.lbNou.Visible = True
	End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click, cmdSortir.Click
        Me.Close()
    End Sub

    Private Sub frmEsdeveniment_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		MyAPP.CloseSesionClient(MyAPP.IDSesion_Client, DESCRIP_FORM_ESDEVENIMENT)
		Me.Dispose()
	End Sub
	
	Private Sub frmEsdeveniment_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
		setLanguageForm()
		If My.Settings.TXT_CAPITALIZE Then Me.txtNom.CharacterCasing = CharacterCasing.Upper

        Dim rsEsdev As DataTable = Cloud.GetTable("SELECT esdev_ID, esdev_nom,esdev_tipfitxer, esdev_dataradiacio, esdev_forcehora FROM esdeveniments")
        If rsEsdev IsNot Nothing Then
            For i As Integer = 0 To rsEsdev.Rows.Count - 1
                Dim Id As Short = rsEsdev.Rows(i)("esdev_ID")
                Dim Nom As String = rsEsdev.Rows(i)("esdev_nom").ToString
                Dim TipFitxer As Short = rsEsdev.Rows(i)("esdev_tipfitxer")
                Dim DataRadi As Date = CDate(rsEsdev.Rows(i)("esdev_dataradiacio"))
                Dim Force As Boolean = CBool(rsEsdev.Rows(i)("esdev_forcehora"))
                addLineEsdeveniment(Id, Nom, TipFitxer, DataRadi, Force)
            Next i
            rsEsdev.Dispose()
        End If
        Me.txtDataRadi.Value = Now
		txtHoraRadi.Value = Now.AddMinutes(6)
		
	End Sub
	
	 
	Dim MSG_ERROR_FILE As String
	Dim MSG_ESDEVENIMENT_PROGRAMAT As String 
	Dim NOM_MUSICA As String 
	Dim NOM_PROGRAMA As String 
	Dim NOM_PUBLICITAT As String 
	
	
	Public Sub setLanguageForm()		
		lang.StrForm = Me.Name
		
		NOM_MUSICA = lang.getText("FITXER_MUSICA",True)
		NOM_PROGRAMA = lang.getText("FITXER_PROGRAMA",True)
		NOM_PUBLICITAT = lang.getText("FITXER_PUBLICITAT",True)
				
		MSG_ERROR_FILE = lang.getText("MSG_ERROR_FILE") '"És imprescindible un fitxer!"
		MSG_ESDEVENIMENT_PROGRAMAT = lang.getText("MSG_ESDEVENIMENT_PROGRAMAT") '"Esdeveniment programat"
		
		Me.cmdSave.Text = lang.getText("LABEL_SAVE",True) '"Salvar"
		Me.cmdNew.Text = lang.getText("LABEL_NEW",True) '"Nou"
		Me.lbNou.Text = lang.getText("LABEL_NEW_UPPER",True) '"NOU"				
		Me.Label5.Text = lang.getText("LABEL_NOM",True) & ":"' "Nom:"
		Me.Label4.Text = lang.getText("HEADERTEXT_HORA",True) & ":"'"Hora:"
		Me.Label3.Text = lang.getText("HEADERTEXT_DATA",True) & ":"'"Data:"
		Me.ColumnHeader1.Text = lang.getText("LABEL_NOM",True) '"Nom"		
		Me.ColumnHeader3.Text = lang.getText("LABEL_DATA_RADIACIO",True) '"Data Radiació"
		Me.ColumnHeader4.Text = lang.getText("chkForceHora.Text") '"forçar"
		
		Me.TabPage1.Text = lang.getText("TabPage1.Text") '"Programar"
		Me.lbAtencio.Text = lang.getText("lbAtencio.Text") '"Atenció: després de reproduïr aquest fitxer es posarà en pausa."
		Me.Label7.Text = lang.getText("Label7.Text") '"NO abans de 5 min. hora actual"
		Me.chkForceHora.Text = lang.getText("chkForceHora.Text") '"Forçar hora de radiació"
		Me.Label2.Text = lang.getText("LABEL_FITXER",True) & ":" '"Fitxer:"
		Me.Label1.Text = lang.getText("LABEL_TIPUS_FITXER",True) & ":" '"Tipus de fitxers:"
		Me.chkIN.Text = lang.getText("LABEL_NOMES_FITXERS_CATIUS",True) '"Només fitxers actius"
		Me.TabPage2.Text = lang.getText("HEADERTEXT_LLISTAT",True) '"Llistat"
		Me.ColumnHeader2.Text = lang.getText("LABEL_T_FITXER",True) '"T. Fitxer"
		Me.cmdDelCaduc.Text = lang.getText("cmdDelCaduc.Text") '"Borrar caducats"
		Me.cmdDelSelect.Text = lang.getText("LABEL_DEL_SELECT",True) '"Borrar sel·lecció"
		Me.Label6.Text = lang.getText("Label6.Text") '"Programa qualsevol tipus de fitxer a una hora en concret."
		Me.Text = lang.getText("Text") '"Programar esdeveniments"

        Dim Cmb As New combo
        Cmb.OmpleCombo(cmbTipFitxer, TAULES_DBS.TAULA_TIPUS_FITXER, TotsCap.NO_ADD) ': cmbTipFitxer.SelectedValue = 0
    End Sub
	
	Private Sub cmbTipFitxer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipFitxer.SelectedIndexChanged
		refreshFitxers()
	End Sub
	
	Private Sub refreshFitxers()        
		
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.AppStarting
		cmbFitxer.DataSource = Nothing
		Dim tipFitxer As Short = Me.cmbTipFitxer.SelectedValue
		Dim Active As Short = IIf(Me.chkIN.Checked, 1, 0)
		Dim rs As DataTable
        Dim db As New MSC.dbs(Cloud)
        Dim StrSql As String
		Select Case tipFitxer
			Case Tipus_Fitxers.FITXER_MUSICA
				StrSql = "SELECT DISTINCT `temes`.`tema_id`, CONCAT_WS(' - ',`temes`.`tema_titol`, `interprets`.`interp_nom`)as temNom FROM `temes`,  `interprets` WHERE ( `temes`.`tema_interp`=`interprets`.`interp_id` AND `temes`.`tema_pautain`=" & Active & " ) ORDER BY `temes`.`tema_titol`, `interprets`.`interp_nom` "
                rs = db.getTable(StrSql)
            Case Tipus_Fitxers.FITXER_PUBLICITAT
				StrSql = "SELECT DISTINCT `falques`.`falc_id`, CONCAT_WS(' - ',`falques`.`falc_nom`, `clients`.`cli_nom`) columSum FROM `falques`,  `clients` WHERE ( `falques`.`falc_client` = `clients`.`cli_id` AND `falques`.`falc_activa` = " & Active & " ) ORDER BY `falques`.`falc_nom`, `clients`.`cli_nom`"
                rs = db.getTable(StrSql)
            Case Tipus_Fitxers.FITXER_PROGRAMA
                OmplircomboBoxProgramSessions(cmbFitxer)
				Exit Sub
            Case Else
                StrSql = "SELECT audio_id,audio_nom FROM audios_params WHERE audio_actv=" & Active & " AND listaudio_id=" & tipFitxer - 600 & " ORDER BY audio_nom"
                rs = db.getTable(StrSql)
		End Select
		
		With cmbFitxer
			.DisplayMember = rs.Columns(1).ColumnName
			.ValueMember = rs.Columns(0).ColumnName
			.DataSource = rs
			.SelectedValue = 0
		End With
		db = Nothing
		'Me.lbAtencio.Visible = (tipFitxer = Tipus_Fitxers.FITXER_JINGELS)
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If Me.txtNom.TextLength = 0 Then
            MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_NOM, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
            Me.txtNom.Focus()
            Exit Sub
        End If
        Dim Nom As String = AddSlashes(Me.txtNom.Text)
		Dim tipFitxer As Short = Me.cmbTipFitxer.SelectedValue
        If cmbFitxer.SelectedValue < 0 Then
            MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_FILE, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
            Me.cmbFitxer.Focus()
            Exit Sub
        End If
        Dim FitxerID As Short = Me.cmbFitxer.SelectedValue
		'test exist
		Dim PathArrel As String = ""
		Select tipFitxer 
			Case Tipus_Fitxers.FITXER_MUSICA : PathArrel = Params.PathMusica
            Case Tipus_Fitxers.FITXER_PUBLICITAT : PathArrel = Params.PathPublicitat 
			Case Tipus_Fitxers.FITXER_PROGRAMA : PathArrel = Params.PathProgrames			
			Case Else : PathArrel = Params.PathAudioUser 'Tipus_Fitxers.FITXER_AUDIO_USR							
		End Select
		Dim PathFitxer As String = PathArrel & FitxerID & ".mp3"
        If IO.File.Exists(PathFitxer) = False Then
            MetroFramework.MetroMessageBox.Show(Me, MSG_FILE_NO_EXIST, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
            Me.cmbFitxer.Focus()
            Exit Sub
        End If

        Dim DataRadi As Date = Me.txtDataRadi.Value.ToString("yyyy-MM-dd") & " " & Me.txtHoraRadi.Value.ToString("HH:mm:ss")
		Dim forceHora As Boolean = Me.chkForceHora.Checked
		
		Try
            Dim db As New MSC.dbs(Cloud)
            Dim sCmd As String = "INSERT INTO esdeveniments (esdev_nom, esdev_tipfitxer, esdev_fitxer, esdev_dataradiacio,esdev_forcehora)"
			sCmd = sCmd & " VALUES "
			sCmd = sCmd & " ( '" & Nom & "'"
			sCmd = sCmd & ", " & tipFitxer
			sCmd = sCmd & ", " & FitxerID
			sCmd = sCmd & ", '" & DataRadi.ToString("yyyy-MM-dd HH:mm:ss") & "'"
			sCmd = sCmd & ", " & CShort(IIf(forceHora, 1, 0))
			sCmd = sCmd & ");"
			
			Dim NewID As Short = db.New_ID(sCmd)
			addLineEsdeveniment(NewID, Nom, tipFitxer, DataRadi,forceHora)
			Me.cmdSave.Enabled = False
			Me.lbNou.Visible = False
			db = Nothing
		Catch ex As Exception
			
		End Try
        MetroFramework.MetroMessageBox.Show(Me, MSG_ESDEVENIMENT_PROGRAMAT, My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Information, 100)
    End Sub
	
	Private Sub addLineEsdeveniment(ByVal id As Short, ByVal Nom As String, ByVal TipFitxer As Short, ByVal DataRadi As Date, force As Boolean )
		Dim NewItem As System.Windows.Forms.ListViewItem
		Dim imageID As Short
		Dim NomFitxer As String
        Select Case TipFitxer
            Case 0 : Exit Sub
            Case 1 : imageID = TipFitxer : NomFitxer = NOM_MUSICA
            Case 4 : imageID = TipFitxer : NomFitxer = NOM_PROGRAMA
            Case 5 : imageID = TipFitxer : NomFitxer = NOM_PUBLICITAT
            Case Else : imageID = 0 : NomFitxer = getNomListAudio(TipFitxer - 600)
        End Select
        NewItem = ListEsdev.Items.Add(Nom)
		NewItem.Tag = CStr(id)
		NewItem.ImageIndex = imageID
		NewItem.SubItems.Insert(1, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, NomFitxer))
		NewItem.SubItems.Insert(2, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, DataRadi.ToString("yyyy-MM-dd HH:mm:ss")))
		NewItem.SubItems.Insert(3, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, IIf(force= True,MSG_YES,MSG_NOT)))
	End Sub
	
	Private Sub chkIN_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkIN.Click
		refreshFitxers()
	End Sub
	
	Private Sub cmdDelSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelSelect.Click
		Try
			Dim IdEsdev As Short = Me.ListEsdev.FocusedItem.Tag
			Dim sCmd As String = "DELETE FROM esdeveniments"
			sCmd = sCmd & " WHERE esdev_ID = " & IdEsdev & " ;"
            Dim db As New MSC.dbs(Cloud)
            db.Delete_ID(sCmd)
            db = Nothing
            addCtlRadi(0, CShort(Tipus_Play.CTL_SQL), 0, "00:00:00", 0, 0, Usuari.UsrID, sCmd, 0, False)
            ListEsdev.Items.Remove(ListEsdev.FocusedItem)
		Catch ex As Exception
			
		End Try
	End Sub
	
	Private Sub cmdDelCaduc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelCaduc.Click
		Dim I As Short = 0
		Do While ListEsdev.Items.Count > 0
			If Now > CDate(ListEsdev.Items(I).SubItems(2).Text) Then
				Dim IdEsdev As Short = ListEsdev.Items(I).Tag
				
				Dim sCmd As String = "DELETE FROM esdeveniments"
				sCmd = sCmd & " WHERE esdev_ID = " & IdEsdev & " ;"
                Dim db As New MSC.dbs(Cloud)
                db.Delete_ID(sCmd)
                addCtlRadi(0, CShort(Tipus_Play.CTL_SQL), 0, "00:00:00", 0, 0, Usuari.UsrID, sCmd, 0, False)
                db = Nothing
				ListEsdev.Items.RemoveAt(I)
			Else
				I = I + 1
			End If
			If ListEsdev.Items.Count = 0 Or I > (ListEsdev.Items.Count - 1) Then Exit Do
		Loop
	End Sub
	
	Private Sub cmbTipFitxer_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbTipFitxer.TextChanged
		Dim index As Integer = _
			CType(sender, ComboBox).FindStringExact(CType(sender, ComboBox).Text())
		If index < 0 Then
			'no existeix el que es busca
		End If
	End Sub
	
End Class