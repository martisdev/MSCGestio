Option Strict Off
Option Explicit On
'TODO: replantejament del sistema de BKPs (CDs mixtes)
Public Class frmMantBKPAudio
	'TODO: Error de concepte al no ensenyar tots els fitxer que hi han assignats al backup
	Dim Cancelled As Boolean
	Dim blEnable As Boolean
	Dim blnNouRecord As Boolean
	Dim IsSaving As Boolean = False
	
	
	#Region " Pantalla "
	Private Sub frmMant_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		CloseForm()
	End Sub
	
	Private Sub cmdSortir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSortir.Click
		Me.Close()
	End Sub
	
	Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
		Me.Close()
	End Sub
	
	Private Sub cmdNou_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNou.Click
		NewRecord()
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
		Me.txtNom.Text = ""
		Me.lbID.Text = 0
		Me.ComboTipFitx.SelectedIndex = 0
		Me.chkSaved.Checked = False	
	End Sub
	
	Private Sub cmdLocked_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBloqueix.Click
		LockedRecord()
	End Sub
	
	Private Sub LockedRecord(Optional ByVal saved As Boolean = False)
		If Me.cmdSalvar.Enabled = True And saved = False Then
			If MsgBox(MSG_SAVE_DADES, vbOKCancel, MSG_ATENCIO) = MsgBoxResult.Ok Then SaveRecord()
		End If
		blEnable = Not blEnable
		blnNouRecord = False
		Me.txtNom.Enabled = blEnable
		Me.ComboTipFitx.Enabled = blEnable
		Me.chkSaved.Enabled = blEnable
		Me.PanelSave.Enabled = blEnable
		
		Me.cmdBorrar.Enabled = blEnable
		Me.lbNou.Visible = False
		If blEnable Then
			Me.cmdBloqueix.Image = Me.picUnLock.Image
		Else
			Me.cmdBloqueix.Image = Me.picLock.Image
			Me.cmdSalvar.Enabled = False
		End If
	End Sub
	
	Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
		DeleteRecord()
	End Sub
	
	Private Sub cmdSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalvar.Click
		SaveRecord()
	End Sub
	
	Private Sub FindRecord()
		If txtBuscar.Text.Length = 0 Or txtBuscar.Text = LABEL_BUSCAR & "..." Then Exit Sub
		Dim StrSql As String = Me.txtBuscar.Text
		Dim OpcBusca As Short
		For i As Integer = 0 To optionBuscar.DropDownItems.Count - 1
			If CType(optionBuscar.DropDownItems(i), ToolStripMenuItem).Checked = True Then OpcBusca = i : Exit For
		Next i
		If Not IsNumeric(txtBuscar.Text) Then OpcBusca = Buscar.BUSCAR_NOM
		Select Case OpcBusca
			Case Buscar.BUSCAR_ID
				StrSql = "bkp_id = " & txtBuscar.Text
			Case Buscar.BUSCAR_NOM
				StrSql = "bkp_nom LIKE '%" & txtBuscar.Text.Trim & "%'"
			Case Buscar.BUSCAR_TOTS
				StrSql = "bkp_nom LIKE '%" & txtBuscar.Text.Trim & "%' OR bkp_id = " & txtBuscar.Text.Trim
		End Select
		
		establirRecordset(StrSql)
	End Sub
	
	Private Sub cmdRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefrescar.Click
		establirRecordset()
	End Sub
	
	Private Sub txtNom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNom.TextChanged
		Try
			Dim RowID As Integer = FindAfectatRow()
			Me.gridDades.Rows(RowID).Cells("ColumnNom").Value = txtNom.Text
			Changed()
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
	
	Private Sub frmMant_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
		setLanguageForm()
		Dim cmb As New combo
		cmb.OmpleCombo(ComboTipFitx, TAULES_DBS.TAULA_TIPUS_FITXER, TotsCap.CAP)
		ComboTipFitx.SelectedValue = 0
		
		If Not frmMain.NoLoadRs Then establirRecordset()
		
		'Me.cmdBloqueix.Enabled = IIf(Usuari.UsrTipus > NivellUsers.USR_CONVIDAT, True, False)
		Me.cmdNou.Enabled = IIf(Usuari.UsrTipus > NivellUsers.USR_CONVIDAT, True, False)
		Me.mnuNew.Visible = Me.cmdNou.Visible
		
	End Sub
	
	Dim MSG_BUSCA_DIR As String 
	Dim MSG_BKP_OK As String 
	Dim MSG_NO_EXIST_FILE As String 
	
	Public Sub setLanguageForm()
		lang.StrForm = Me.Name	
		
		MSG_BUSCA_DIR = lang.getText("MSG_BUSCA_DIR") '"Busca un directori"
		MSG_BKP_OK = lang.getText("MSG_BKP_OK") '"Còpia de seguretat realitzada"
		MSG_NO_EXIST_FILE = lang.getText("MSG_NO_EXIST_FILE") '"No existeix el fitxer al disc dur"
		
		'Me.cmdSortir.Text = "ToolStripButton11"
		'Me.ToolStrip1.Text = "ToolStrip1"
		'Me.cmdExit.Text = "Button1"
		'Me.MenuStrip1.Text = "MenuStrip1"
		
		Me.lbNou.Text =  lang.getText("LABEL_NEW_UPPER",True) '"NOU"
		Me.cmdNou.Text =  lang.getText("LABEL_NEW",True) '"Nou"
		Me.Label2.Text =  lang.getText("LABEL_NOM",True) & ":" '"Nom:"
		Me.cmdPrevi.Text = lang.getText("LABEL_GOTO_PREV",True)'"Anterior"
		Me.cmdPrimer.Text = lang.getText("LABEL_GOTO_FIRSH",True)'"Primer"
		Me.cmdUltim.Text = lang.getText("LABEL_GOTO_LAST",True)'"Últim"
		Me.cmdSeguent.Text = lang.getText("LABEL_GOTO_NEXT",True)'"Següent"
		Me.cmdBloqueix.Text = lang.getText("LABEL_EDITAR",True) 'Editar	
		Me.cmdBorrar.Text = lang.getText("LABEL_DELETE",True)'"Borrar"
		Me.cmdSalvar.Text = lang.getText("LABEL_SAVE",True)'"Salvar"
		Me.optionBuscar.Text =  lang.getText("LABEL_BUSCAR",True)'"Buscar"
		Me.ProgarmaToolStripMenuItem.Text = lang.getText("LABEL_PROGRAMA",True) '"Programa"
		Me.mnuExit.Text = lang.getText("LABEL_EXIT",True) '"Sortir"
		Me.EdicióToolStripMenuItem.Text = lang.getText("mnuEdit.Text",True )'"Edició"
		Me.mnuModif.Text = lang.getText("LABEL_MODIFICAR",True )'"Modificar"
		Me.mnuSave.Text = lang.getText("LABEL_SALVAR",True) '"Salvar"
		Me.mnuNew.Text = lang.getText("LABEL_NEW",True) '"Nou"
		Me.mnuDel.Text = lang.getText("LABEL_DELETE",True) '"Borrar"
		Me.mnuBuscar.Text = lang.getText("LABEL_SEARCH",True)'"Buscar"
		Me.mnuRefresh.Text = lang.getText("LABEL_REFRESCAR",True)'"Refrescar"
		Me.ToolStripMenuItem1.Text = lang.getText("mnu_Help",True) '"Ajuda"
		Me.mnu_Help.Text = lang.getText("mnuRefHelp.Text",True) '"Manual OnLine"
		Me.txtBuscar.Text = lang.getText("LABEL_BUSCAR",True) & "..."'"Buscar..."
		Me.cmdCancel.Text = lang.getText("CANCELAR",True) '"Cancelar"
		Me.ColumnID.HeaderText =  lang.getText("HEADERTEXT_ID",True) '"ID"
		Me.ColumnNom.HeaderText = lang.getText("LABEL_NOM",True) '"Nom"
		Me.Label1.Text = lang.getText("LABEL_IDENTIFICADOR",True) & ":" '"Identificador:"		
		Me.cmdRefrescar.Text = lang.getText("LABEL_REFRESCAR", True) '"Refrescar"
		
		Me.PerIDToolStripMenuItem.Text = lang.getText("mnu_Buscar_ID",True)'"Per ID"
		Me.PerNomToolStripMenuItem.Text = lang.getText("mnu_Buscar_NOM",True)'"Per Nom"
		Me.QualsevolToolStripMenuItem.Text = lang.getText("mnu_Buscar_QUALSEVOL",True)'"Qualsevol"
		
		Me.Label3.Text = lang.getText("LABEL_TIPUS_FITXER",True) & ":" '"Tipus de fitxer:"
		Me.chkSaved.Text = lang.getText("MSG_BKP_FET",True) '"Còpia realitzada"
		
		Me.Label6.Text = lang.getText("Label6.Text") & ":"'"Tamany necessari per fer la còpia de seguretat :"
		Me.Label5.Text = lang.getText("Label5.Text") & ":"'"Nº de fitxers:"
		Me.cmdSalvarFitxers.Text = lang.getText("cmdSalvarFitxers.Text") '"Salvar Fitxers"
		Me.TabPageSave.Text = cmdSalvarFitxers.Text '"Salvar fitxers"		
		Me.cmdAllTrack.Text = lang.getText("cmdAllTrack.Text") '"Seleccionar tots"
		Me.Label4.Text = lang.getText("LABEL_PATH_DESTI",True) '"Path destí"
		Me.TabPage1.Text = lang.getText("TabPage1.Text") '"Llistat de còpies de seguretat"		
		Me.ColumnCBarres.HeaderText = lang.getText("ColumnCBarres.HeaderText") '"CodiBarres"
		Me.ColumnTipus.HeaderText = lang.getText("ColumnTipus.HeaderText") '"TipusFitxer"
		Me.ColumnSaved.HeaderText = lang.getText("ColumnSaved.HeaderText") '"Saved"		
		Me.lbInfoProgs.Text = lang.getText("lbInfoProgs.Text") '"Referent a les sessions del programa"
		Me.Text = lang.getText("Text") '"Manteniment dels Backups"		
		
	End Sub
	
	
	#End Region
	#Region " VarTables "
	'Seccio variable segons taula-----------------------------------------
	
	Private Sub ShowValuesID()
		If IsSaving = True Then Exit Sub
		Try
			If blEnable = True Then LockedRecord()
			Me.lbID.Text = Me.gridDades.CurrentRow.Cells(0).Value.ToString
			Me.txtNom.Text = Me.gridDades.CurrentRow.Cells(1).Value.ToString
			Me.ComboTipFitx.SelectedValue = Me.gridDades.CurrentRow.Cells(3).Value
			Me.chkSaved.Checked = Me.gridDades.CurrentRow.Cells(4).Value.ToString
			Me.lbPosition.Text = Me.gridDades.CurrentRow.Index
			Me.cmdSalvar.Enabled = False
		Catch ex As Exception
			
		End Try
	End Sub
	
	Public Sub establirRecordset(Optional ByVal ValStr As String = "")
		system.Windows.Forms.Cursor.Current = Cursors.AppStarting
		Dim StrSql As String = "SELECT * FROM backups"
		If Len(ValStr) > 0 Then StrSql = StrSql & " WHERE " & ValStr
		Dim db As New MSC.dbs
		Me.gridDades.DataSource = db.getTable(StrSql)
		
		Me.lbRecCount.Text = gridDades.Rows.Count
		gridDades.Focus()
		
		If gridDades.Rows.Count = 0 Then MsgBox(MSG_NO_ITEM_FOR_CONDITION,vbCritical,MSG_ATENCIO)
		cmdBloqueix.Enabled = IIf(gridDades.Rows.Count And Usuari.UsrTipus > NivellUsers.USR_CONVIDAT, True, False)
		Me.mnuModif.Enabled = Me.cmdBloqueix.Enabled
		system.Windows.Forms.Cursor.Current = Cursors.Default
		db = Nothing
	End Sub
	
	Private Sub SaveRecord()
		If Not MyAPP.PermisPerContinuar Then MsgBox(MSG_SERVER_CLOSE, MsgBoxStyle.Exclamation, MSG_ATENCIO) : Me.Close()
		
		If MsgBox(MSG_CONFIRM_SAVE_DADES, vbOKCancel, MSG_ATENCIO) = vbCancel Then Exit Sub
		
		If Len(Me.txtNom.Text) = 0 Then Exit Sub
		IsSaving = True
		Dim Nom As String = AddSlashes(Me.txtNom.Text)
		Dim ID As Integer = Me.lbID.Text
		Dim TipFitxer As Short = Me.ComboTipFitx.SelectedValue
		Dim blSaved As Boolean = Me.chkSaved.Checked
		Dim db As New MSC.dbs
		Dim StrSql As String
		If blnNouRecord = True Then
			
			StrSql = "INSERT INTO backups (bkp_nom, bkp_tipfitxer, bkp_saved)"
			StrSql = StrSql & " VALUES "
			StrSql = StrSql & " ( '" & Nom & "'"
			StrSql = StrSql & " , " & TipFitxer
			StrSql = StrSql & ", " & CShort(IIf(blSaved, 1, 0))
			StrSql = StrSql & ");"
			
			ID = db.New_ID(StrSql)
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
				gridDades.DataSource = dt
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
			StrSql = "UPDATE backups"
			StrSql = StrSql & " SET "
			StrSql = StrSql & " bkp_nom = '" & Nom & "'"
			StrSql = StrSql & ", bkp_tipfitxer = " & TipFitxer
			StrSql = StrSql & ", bkp_saved = " & CShort(IIf(blSaved, 1, 0)) & " WHERE bkp_id = " & ID
			db.Update_ID(StrSql)
		End If
		RefreshDataSet(TAULES_DBS.TAULA_BACKUPS)
		For i As Short = 0 To 5
			Dim MyCombo As ComboBox = Nothing
			Select Case i
				Case 0 : If IsLoadForm("frmPubli") Then MyCombo = frmPubli.ComboBackup
				Case 1 : If IsLoadForm("frmTemes") Then MyCombo = frmTemes.ComboBackup
				Case 2 : If IsLoadForm("frmImport") Then MyCombo = frmImport.cbBackup
				Case 3 : If IsLoadForm("frmjingels") Then MyCombo = frmJingels.ComboBackup
				Case 4 : If IsLoadForm("frmPromos") Then MyCombo = frmPromos.ComboBackup
				Case 5 : If IsLoadForm("frmAudio") Then MyCombo = frmAudio.ComboBackup
			End Select
			If MyCombo IsNot Nothing Then
				Dim cmb As New combo
				cmb.OmpleCombo(MyCombo, TAULES_DBS.TAULA_BACKUPS, TotsCap.CAP)
				MyCombo.SelectedValue = ID
			End If
		Next i
		db = Nothing
		LockedRecord(True)
		blnNouRecord = False
		IsSaving = False
		gridDades.Focus()
	End Sub
	
	Private Sub DeleteRecord()
		
		If blnNouRecord = True Then 
			LockedRecord(True)
			NetejaPantalla()
			gridDades.AllowUserToAddRows = False
			Exit Sub
		End If
		
		If MsgBox(MSG_CONFIRM_DELETE_DADES, vbYesNo, MSG_ATENCIO) = vbNo Then Exit Sub
				Dim db As New MSC.dbs
		For i As Short = 0 To Me.gridDades.SelectedRows.Count - 1
			Dim ID As Integer = gridDades.SelectedRows(i).Cells(0).Value
			'Buscar dependènes
			If buscarDependencies(TAULES_DBS.TAULA_BACKUPS, ID) = True Then Exit Sub
			Dim StrSql As String = "DELETE FROM backups WHERE bkp_id=" & ID
			
			db.Delete_ID(StrSql)
		Next
		For Each selectedrow As DataGridViewRow In gridDades.SelectedRows
			gridDades.Rows.Remove(selectedrow)
		Next
		db = Nothing		
		RefreshDataSet(TAULES_DBS.TAULA_BACKUPS)
		'TODO: ACtualitzar combos altres pantalles
		
	End Sub
	
	Private Sub CloseForm()
		If Me.cmdSalvar.Enabled Then
			If MsgBox(MSG_CONFIRM_SAVE_DADES, vbOKCancel,MSG_ATENCIO) = vbOK Then SaveRecord()
		End If
		
		MyAPP.CloseSesionClient(MyAPP.IDSesion_Client, DESCRIP_FORM_BKP_AUDIO)
		Me.Dispose()
	End Sub
	
	#End Region
	
	Private Sub cmdPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPath.Click
		
		FolderBrowserDialog1.Description = MSG_BUSCA_DIR
		If FolderBrowserDialog1.ShowDialog() = system.Windows.Forms.DialogResult.OK Then
			Me.txtPath.Text = FolderBrowserDialog1.SelectedPath
		End If
		Me.cmdSalvarFitxers.Enabled = IIf(Len(txtPath.Text) > 2, True, False)
	End Sub
	
	Private Sub cmdAllTrack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAllTrack.Click
		system.Windows.Forms.Cursor.Current = Cursors.AppStarting
		For i As Short = 0 To Me.lstFitxers.Items.Count - 1
			Dim NomFitxer As String = lstFitxers.Items(i).Tag
			lstFitxers.Items.Item(i).Checked = IO.File.Exists(NomFitxer)
		Next
		system.Windows.Forms.Cursor.Current = Cursors.Default
	End Sub
	
	Private Sub TabControl1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TabControl1.MouseUp
		If TabControl1.SelectedIndex = 1 Then actualitzaListFitxer()
	End Sub
	
	Private Sub actualitzaListFitxer()
		Dim taula As DataTable = Nothing
		Dim path As String
		Dim Fitxer As String
		Dim FExist As Integer
		Dim TotalSize As Decimal
		
		Dim ColumID As String = ""
		Dim ColumNom As String = ""
		Dim NomTaula As String = ""
		Dim ColumBackupID As String = ""
		lstFitxers.Items.Clear()
		system.Windows.Forms.Cursor.Current = Cursors.AppStarting
		Dim db As New MSC.dbs
		Dim StrSql As String = ""
		Select Case Me.ComboTipFitx.SelectedValue
			Case 0
				'<CAP>
				system.Windows.Forms.Cursor.Current = Cursors.Default
				Exit Sub
			Case Tipus_Fitxers.FITXER_MUSICA
				path = Params.PathMusica & "\"
				getVarTables(TAULES_DBS.TAULA_TEMES, NomTaula, ColumID, ColumNom)
				ColumBackupID = "tema_backup"
			Case Tipus_Fitxers.FITXER_PROMOS
				path = Params.PathPromos & "\"
				getVarTables(TAULES_DBS.TAULA_PROMOCIONS, NomTaula, ColumID, ColumNom)
				ColumBackupID = "promo_backup"
			Case Tipus_Fitxers.FITXER_JINGELS
				path = Params.PathJingels & "\"
				getVarTables(TAULES_DBS.TAULA_JINGELS, NomTaula, ColumID, ColumNom)
				ColumBackupID = "jing_backup"
			Case Tipus_Fitxers.FITXER_PUBLICITAT
				path = Params.PathPublicitat & "\"
				getVarTables(TAULES_DBS.TAULA_PUBLICITAT, NomTaula, ColumID, ColumNom)
				ColumBackupID = "falc_backup"
			Case Tipus_Fitxers.FITXER_PROGRAMA
				path = Params.PathProgrames & "\"
				getVarTables(TAULES_DBS.TAULA_PROGRAMES, NomTaula, ColumID, ColumNom)
				ColumBackupID = "prg_backup"
			Case Else
				'BUG ??? Nom taula
				path = Params.PathAudioUser & "\"
				getVarTables(TAULES_DBS.TAULA_AUDIO_USERS, NomTaula, ColumID, ColumNom)
				ColumBackupID = "audio_backup"
		End Select
		
		StrSql = "SELECT " & ColumID & "," & ColumNom & " FROM " & NomTaula & " WHERE " & ColumBackupID & " = " & lbID.Text & " ORDER BY " & ColumNom
		
		If taula Is Nothing Then taula = db.getTable(StrSql)
		Dim NewItem As ListViewItem
		For i As Integer = 0 To taula.Rows.Count - 1
			Fitxer = path & taula.Rows(0)(0).ToString & ".MP3"
			NewItem = Me.lstFitxers.Items.Add(Fitxer & " ( " & taula.Rows(i)(1).ToString & ")")
			NewItem.Tag = Fitxer
			'S'ha de saver el tamany i si existeix  
			If IO.File.Exists(Fitxer) = True Then
				Dim FileSize As IO.FileInfo = New IO.FileInfo(Fitxer)
				If FileSize.Length > 0 Then TotalSize = TotalSize + FileSize.Length : FExist = FExist + 1
			Else
				NewItem.BackColor = Color.Red
			End If
		Next i
		db = Nothing
		Me.lbTamany.Text = Strings.Format(TotalSize / 1024, "###,###,###") + "Mb"
		Me.lbNFitxers.Text = FExist & "/" & taula.Rows.Count
		system.Windows.Forms.Cursor.Current = Cursors.Default
	End Sub
	
	Private Sub cmdSalvarFitxers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalvarFitxers.Click
		system.Windows.Forms.Cursor.Current = Cursors.AppStarting
		Me.ProgressBar.Visible = True
		Me.cmdCancel.Visible = True
		Cancelled = False
		ProgressBar.Maximum = lstFitxers.Items.Count
		Dim PathDesti As String = Me.txtPath.Text
		For N As Short = 0 To Me.lstFitxers.Items.Count - 1
			If lstFitxers.Items(N).Checked = True Then
				Dim PathFitxer As String = Me.lstFitxers.Items(N).Tag
				Dim NomFitxer As String = GetFileName(PathFitxer)
				Dim FitxerDesti As String = PathDesti & "\" & NomFitxer
				IO.File.Copy(PathFitxer, FitxerDesti)
			End If
			ProgressBar.Value = N
			System.Windows.Forms.Application.DoEvents()
			If Cancelled = True Then Exit For
		Next
		Me.ProgressBar.Visible = False
		Me.cmdCancel.Visible = False
		
		MsgBox(MSG_BKP_OK, vbInformation, My.Application.Info.AssemblyName)
		system.Windows.Forms.Cursor.Current = Cursors.Default
	End Sub
	
	Private Sub lstFitxers_ItemChecked(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lstFitxers.ItemChecked
		Dim item As System.Windows.Forms.ListViewItem = e.Item
		If item.Checked = True Then
			Dim NomFitxer As String = item.Tag
			If Not IO.File.Exists(NomFitxer) Then
				item.Checked = False
				MsgBox(MSG_NO_EXIST_FILE, vbExclamation,MSG_ATENCIO)
			End If
		End If
	End Sub
	
	Private Sub ComboTipFitx_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboTipFitx.SelectedIndexChanged
		Try
			Dim RowID As Integer = FindAfectatRow()
			Me.gridDades.Rows(RowID).Cells("ColumnTipus").Value = ComboTipFitx.SelectedValue
			Changed()
		Catch ex As Exception
		End Try
		lbInfoProgs.Visible = (ComboTipFitx.SelectedValue = Tipus_Fitxers.FITXER_PROGRAMA)
	End Sub
	
	Private Sub chkSaved_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSaved.CheckedChanged
		Try
			Dim RowID As Integer = FindAfectatRow()
			Me.gridDades.Rows(RowID).Cells("ColumnSaved").Value = chkSaved.Checked
			Changed()
		Catch ex As Exception
		End Try
		
	End Sub
	
	Private Sub gridDades_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridDades.CurrentCellChanged
		ShowValuesID()
	End Sub
	
	Private Sub Changed()
		If blEnable = True Then Me.cmdSalvar.Enabled = True
	End Sub
	
	Private Function FindAfectatRow() As Integer
		If blnNouRecord Then
			Return gridDades.NewRowIndex
		Else
			Return gridDades.CurrentRow.Index
		End If
	End Function
	
	Private Sub mnuBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBuscar.Click
		FindRecord()
	End Sub
	
	Private Sub mnuRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRefresh.Click
		establirRecordset()
	End Sub
	
	#Region "nemú estandard (funcions bàsiques)"
	
	Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
		Me.Close()
	End Sub
	
	Private Sub mnuNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNew.Click
		NewRecord()
	End Sub
	
	Private Sub mnuModif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuModif.Click
		LockedRecord()
	End Sub
	
	Private Sub mnuSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSave.Click
		SaveRecord()
	End Sub
	
	Private Sub mnuDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDel.Click
		DeleteRecord()
	End Sub
	
	#End Region
	
	Private Sub optionBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optionBuscar.Click
		FindRecord()
	End Sub
	
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
	
	Private Sub mnu_Help_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_Help.Click
		Dim Proces As Process = New Process
		Try
			Process.Start(MSC.Help.HELP_GEST_AUTOMATITZACIO_MANT_FITXERS.ToString)
		Catch ex As Exception
		End Try
	End Sub
End Class