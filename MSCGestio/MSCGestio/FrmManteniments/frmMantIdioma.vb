Option Strict Off
Option Explicit On

Public Class frmMantIdioma
	Dim blEnable As Boolean
	Dim blnNouRecord As Boolean
	Dim IsSaving As Boolean = False
	
	Const TAULA_ID As TAULES_DBS = TAULES_DBS.TAULA_IDIOMES
	
	
	Dim COLUMN_ID As String = ""
	Dim COLUMN_NOM As String = ""
	Dim TAULA_NOM As String = ""


#Region " Pantalla "

    Private Sub frmMant_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		CloseForm()
	End Sub
	
	Private Sub frmMant_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        IniTable()

        If My.Settings.TXT_CAPITALIZE Then
			Me.txtNomNadiu.CharacterCasing = CharacterCasing.Upper
			Me.txtNomInter.CharacterCasing = CharacterCasing.Upper
		End If


        If Not frmMain.NoLoadRs Then establirRecordset()
		Me.cmdNou.Visible = IIf(Usuari.UsrTipus > NivellUsers.USR_CONVIDAT, True, False)
		Me.mnuNew.Visible = Me.cmdNou.Visible
	End Sub

    Friend Sub IniTable()
        getVarTables(TAULA_ID, TAULA_NOM, COLUMN_ID, COLUMN_NOM)
        setLanguageForm()
    End Sub

    Dim FORM_DESCRIP As String 
	Dim CONNEX_DESCRIP As String 
	
	Public Sub setLanguageForm()
		lang.StrForm = Me.Name
		
		FORM_DESCRIP = lang.getText("Text") '"Manteniment Idiomes"
		CONNEX_DESCRIP = lang.getText("LABEL_IDIOMES",True) 'Idiomes"		
		Me.ColumnNom.HeaderText = lang.getText("ColumnNom.HeaderText") '"Nom Internacional"
		Me.ColumnNomNadiu.HeaderText = lang.getText("ColumnNomNadiu.HeaderText") '"Nom Nadiu"		
		Me.ColumnVisible.HeaderText = lang.getText("ColumnVisible.HeaderText") '"Visible"
		Me.Label8.Text = lang.getText("Label8.Text") '"fer visible només les que estan en ús"
		Me.Label7.Text = lang.getText("Label7.Text") '"Codificació segons ISO 369-1"
		
		Me.Label2.Text = lang.getText("ColumnNom.HeaderText") & ":" '"Nom Interacional:"
		Me.Label3.Text = lang.getText("ColumnNomNadiu.HeaderText") & ":"'"Nom nadiu:"
		Me.chkVisible.Text = lang.getText("LABEL_VISIBLE",True) 'visible
		'Me.Column369_1.HeaderText = lang.getText("CONNEX_DESCRIP") '"369_1"
		'Me.Column369_2_369_5.HeaderText = lang.getText("CONNEX_DESCRIP") '"369_2_369_5"
		'Me.Column369_3.HeaderText = lang.getText("CONNEX_DESCRIP") '"369_3"
		'Me.Label4.Text = "369-1:"
		'Me.Label5.Text = "369-2/369-5:"
		'Me.Label6.Text = "369-3:"
		
		Me.ColumnID.HeaderText = lang.getText("HEADERTEXT_ID",True) '"ID"
		'Me.cmdExit.Text = "Button1"
		Me.ColumnID.HeaderText = lang.getText("HEADERTEXT_ID",True) '"ID"
		Me.ColumnNom.HeaderText = lang.getText("LABEL_NOM",True) '"Nom"
		Me.PerNomToolStripMenuItem.Text = lang.getText("mnu_Buscar_NOM",True)'"Per Nom"
		Me.PerIDToolStripMenuItem.Text = lang.getText("mnu_Buscar_ID",True)'"Per ID"
		Me.QualsevolToolStripMenuItem.Text = lang.getText("mnu_Buscar_QUALSEVOL",True)'"Qualsevol"
		Me.OptionBuscar.Text = lang.getText("LABEL_BUSCAR",True)'"Buscar"
		Me.OptionBuscar.ToolTipText = lang.getText("mnu_Buscar_ToolTipText",True)'"Opcions de recerca"
		Me.lbVaris.Text = MSG_ID_VARIS_NO_BORRAR	
		Me.lbNou.Text = lang.getText("LABEL_NEW_UPPER",True) '"NOU"
		
		Me.Label1.Text = lang.getText("LABEL_IDENTIFICADOR",True) & ":" '"Identificador:"
		'Me.Button1.Text = "Button1"
		Me.txtBuscar.Text = lang.getText("LABEL_BUSCAR",True) & ".." '"Buscar.."
		'Me.ToolStrip1.Text = "ToolStrip1"
		Me.cmdPrimer.Text = lang.getText("LABEL_GOTO_FIRSH",True)'"Primer"
		Me.cmdPrevi.Text = lang.getText("LABEL_GOTO_PREV",True)'"Anterior"
		Me.cmdSeguent.Text = lang.getText("LABEL_GOTO_NEXT",True)'"Següent"
		Me.cmdUltim.Text = lang.getText("LABEL_GOTO_LAST",True)'"Últim"
		Me.cmdNou.Text = lang.getText("LABEL_NEW",True) '"Nou"
		Me.cmdBloqueix.Text = lang.getText("LABEL_EDITAR",True) '"Editar"
		Me.cmdBorrar.Text = lang.getText("LABEL_DELETE",True) '"Borrar"
		Me.cmdSalvar.Text = lang.getText("LABEL_SAVE",True)'"Salvar"
		Me.cmdRefrescar.Text = Lang.getText("LABEL_REFRESCAR",True)'"Refrescar"
		Me.cmdSortir.Text = lang.getText("LABEL_EXIT",True) '"Sortir"
		
		
		
		'Me.MenuStrip1.Text = "MenuStrip1"
		Me.ProgarmaToolStripMenuItem.Text = lang.getText("LABEL_PROGRAMA",True) '"Programa"
		Me.mnuExit.Text = lang.getText("LABEL_EXIT",True) '"Sortir"
		Me.EdicióToolStripMenuItem.Text = lang.getText("mnuEdit.Text",True )'"Edició"
		Me.mnuModif.Text = lang.getText("LABEL_MODIFICAR",True )'"Modificar"
		Me.mnuSave.Text = lang.getText("LABEL_SALVAR",True) '"Salvar"
		Me.mnuNew.Text = lang.getText("LABEL_NEW",True) '"Nou"
		Me.mnuDel.Text = lang.getText("LABEL_DELETE",True) '"Borrar"
		Me.mnuRefresh.Text = lang.getText("LABEL_REFRESCAR",True)'"Refrescar"
		Me.ToolStripMenuItem1.Text = lang.getText("mnu_Help",True) '"Ajuda"
		Me.mnu_Help.Text = lang.getText("mnuRefHelp.Text",True) '"Manual OnLine"				
		Me.Text = FORM_DESCRIP
		
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
	
	Private Sub cmdLocked_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBloqueix.Click
		LockedRecord()
	End Sub
	
	Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
		DeleteRecord()
	End Sub
	
	Private Sub cmdSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalvar.Click
		SaveRecord()
	End Sub
	
	Private Sub cmdPrimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrimer.Click
		gridDades.Focus()
		System.Windows.Forms.SendKeys.Send("^{HOME}")
	End Sub
	
	Private Sub cmdPrevi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrevi.Click
		gridDades.Focus()
		System.Windows.Forms.SendKeys.Send("{UP}")
	End Sub
	
	Private Sub cmdRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefrescar.Click
		establirRecordset()
	End Sub
	
	Private Sub cmdSeguent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSeguent.Click
		gridDades.Focus()
		System.Windows.Forms.SendKeys.Send("{DOWN}")
	End Sub
	
	Private Sub cmdUltim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUltim.Click
		
		gridDades.Focus()
		System.Windows.Forms.SendKeys.Send("^{END}")
	End Sub
	
	Private Sub txtNom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNomInter.TextChanged
		Try
			Dim RowID As Integer = FindAfectatRow()
			Me.gridDades.Rows(RowID).Cells("ColumnNom").Value = txtNomInter.Text
			If blEnable = True Then Me.cmdSalvar.Enabled = True
		Catch ex As Exception
		End Try
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
	
	Private Sub gridDades_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridDades.CurrentCellChanged
		If IsSaving = True Then Exit Sub
		Try
			If blEnable = True Then LockedRecord()
			Me.lbID.Text = gridDades.CurrentRow.Cells("ColumnID").Value
			Me.txtNomInter.Text = StripSlashes(gridDades.CurrentRow.Cells("ColumnNom").Value)
			Me.txtNomNadiu.Text = StripSlashes(gridDades.CurrentRow.Cells("ColumnNomNadiu").Value)
			Me.chkVisible.Checked = gridDades.CurrentRow.Cells("ColumnVisible").Value
			Me.txt369_1.Text = StripSlashes(gridDades.CurrentRow.Cells("Column369_1").Value)
			Me.txt369_2_369_5.Text = StripSlashes(gridDades.CurrentRow.Cells("Column369_2_369_5").Value)
			Me.txt369_3.Text = StripSlashes(gridDades.CurrentRow.Cells("Column369_3").Value)
			Me.lbPosition.Text = gridDades.CurrentRow.Index
			Me.lbVaris.Visible = IIf(lbID.Text = 1, True, False)
		Catch ex As Exception
			Me.lbID.Text = 0
			Me.txtNomInter.Text = ""
			Me.txtNomNadiu.Text = ""
			Me.chkVisible.Checked = False
			Me.txt369_1.Text = ""
			Me.txt369_2_369_5.Text = ""
			Me.txt369_3.Text = ""
			Me.lbVaris.Visible = False
		End Try
	End Sub
	
	#End Region
	
	#Region " Funcions internes"
	
	Friend Sub establirRecordset(Optional ByVal Condi As String = "")
		system.Windows.Forms.Cursor.Current = Cursors.AppStarting
		
		Dim StrSql As String = "SELECT * FROM " & TAULA_NOM
		If Condi.Length > 0 Then StrSql = StrSql & " WHERE " & Condi
        Dim db As New MSC.dbs(Cloud)
        Me.gridDades.DataSource = db.getTable(StrSql)
		Me.lbRecCount.Text = gridDades.Rows.Count
		db = Nothing
		gridDades.Focus()
        If gridDades.Rows.Count = 0 Then MetroFramework.MetroMessageBox.Show(Me, MSG_NO_ITEM_FOR_CONDITION, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, 100)

        cmdBloqueix.Enabled = IIf(gridDades.Rows.Count And Usuari.UsrTipus > NivellUsers.USR_CONVIDAT, True, False)
		Me.mnuModif.Enabled = Me.cmdBloqueix.Enabled
		system.Windows.Forms.Cursor.Current = Cursors.Default
	End Sub

    Friend ID As Integer
    Private Sub SaveRecord()
        If Me.lbVaris.Visible Then MetroFramework.MetroMessageBox.Show(Me, MSG_NOT_EDIT_ID, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, 100) : Exit Sub
        If Not MyAPP.PermisPerContinuar() Then MetroFramework.MetroMessageBox.Show(Me, MSG_SERVER_CLOSE, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Stop, 100) : Me.Close()
        If MetroFramework.MetroMessageBox.Show(Me, MSG_CONFIRM_SAVE_DADES, MSG_ATENCIO, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, 100) = DialogResult.Cancel Then Exit Sub

        If Len(Me.txtNomInter.Text) = 0 Then Exit Sub
		IsSaving = True
        ID = Me.lbID.Text
        Dim NomInter As String = AddSlashes(Me.txtNomInter.Text)
		Dim NomNadiu As String = AddSlashes(Me.txtNomNadiu.Text)
		Dim D369_1 As String = AddSlashes(Me.txt369_1.Text)
		Dim D369_2 As String = AddSlashes(Me.txt369_2_369_5.Text)
		Dim D369_3 As String = AddSlashes(Me.txt369_3.Text)
		Dim Visible As Boolean = Me.chkVisible.Checked

        Dim db As New MSC.dbs(Cloud)
        If blnNouRecord = True Then
			Dim StrSql As String = "INSERT INTO `idiomes` (`lang_639-1`,`lang_639-2/639-5`,`lang_639-3`,`nom_internacional`,`nom_nadiu`,`lang_visible`) VALUES" _
				& "('" & D369_1 & "','" & D369_2 & "','" & D369_3 & "','" & NomInter & "','" & NomNadiu & "'," & Visible & " );"
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
			Dim StrSql As String = "UPDATE idiomes SET " _
				& " `lang_639-1`='" & D369_1 & "'," _
				& " `lang_639-2/639-5`='" & D369_2 & "'," _
				& " `lang_639-3`='" & D369_3 & "'," _
				& " `nom_internacional`='" & NomInter & "'," _
				& " `nom_nadiu`='" & NomNadiu & "'," _
				& " `lang_visible`=" & IIf(Visible = True, 1, 0) & "" _
				& " WHERE(" & COLUMN_ID & " = " & ID & ");"
			db.Update_ID(StrSql)
		End If

        RefreshDataSet(TAULA_ID)
        Me.DialogResult = DialogResult.OK

        db = Nothing
		IsSaving = False
		LockedRecord(True)
		blnNouRecord = False
		gridDades.Focus()
	End Sub
	
	Private Sub DeleteRecord()
		If blnNouRecord = True Then 
			LockedRecord(True)
			NetejaPantalla()
			gridDades.AllowUserToAddRows = False
			Exit Sub
		End If
        If Me.lbVaris.Visible Then MetroFramework.MetroMessageBox.Show(Me, MSG_NOT_DELETE_ID, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, 100) : Exit Sub
        If MetroFramework.MetroMessageBox.Show(Me, String.Format(MSG_CONFIRM_DELETE_NUM_DADES, gridDades.SelectedRows.Count), MSG_ATENCIO, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, 100) = DialogResult.Cancel Then Exit Sub

        Dim db As New MSC.dbs(Cloud)
        For i As Short = 0 To Me.gridDades.SelectedRows.Count - 1
			Dim ID As Integer = gridDades.SelectedRows(i).Cells(0).Value
            'Buscar dependènes
            If buscarDependencies(TAULA_ID, ID, Me) = True Then Exit Sub
            Dim StrSql As String = "DELETE FROM " & TAULA_NOM & " WHERE " & COLUMN_ID & "=" & ID

            db.Delete_ID(StrSql)
            addCtlRadi(0, CShort(Tipus_Play.CTL_SQL), 0, "00:00:00", 0, 0, Usuari.UsrID, StrSql, 0, False)
        Next
		For Each selectedrow As DataGridViewRow In gridDades.SelectedRows
			gridDades.Rows.Remove(selectedrow)
		Next
		db = Nothing
		RefreshDataSet(TAULA_ID)
		For i As Short = 0 To 1
			Dim MyCombo As ComboBox = Nothing
			Select Case i
				Case 0 : If IsLoadForm("frmTemes") Then MyCombo = frmTemes.ComboIdioma
				Case 1 : If IsLoadForm("frmImport") Then MyCombo = frmImport.cbIdioma
			End Select
			If MyCombo IsNot Nothing Then
				Dim Cmb As New combo
				Cmb.OmpleCombo(MyCombo, TAULA_ID, TotsCap.CAP, "lang_visible=1")
			End If
		Next i
		
	End Sub
	
	Private Sub CloseForm()
		If Me.cmdSalvar.Enabled Then
            If MetroFramework.MetroMessageBox.Show(Me, MSG_SAVE_DADES, MSG_ATENCIO, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, 100) = DialogResult.OK Then SaveRecord()
        End If

        MyAPP.CloseSesionClient(MyAPP.IDSesion_Client, DESCRIP_FORM_IDIOMES)
    End Sub
	
	Private Sub OpcionsBuscar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PerIDToolStripMenuItem.Click, PerNomToolStripMenuItem.Click, QualsevolToolStripMenuItem.Click
		For i As Integer = 0 To OptionBuscar.DropDownItems.Count - 1
			CType(OptionBuscar.DropDownItems(i), ToolStripMenuItem).Checked = False
		Next
		CType(sender, ToolStripMenuItem).Checked = True
	End Sub
	
	Private Sub FindRecord()
		If txtBuscar.Text.Length = 0 Or txtBuscar.Text = LABEL_BUSCAR & "..." Then Exit Sub
		Dim StrSql As String = Me.txtBuscar.Text
		Dim OpcBusca As Short
		For i As Integer = 0 To OptionBuscar.DropDownItems.Count - 1
			If CType(OptionBuscar.DropDownItems(i), ToolStripMenuItem).Checked = True Then OpcBusca = i : Exit For
		Next i
		If Not IsNumeric(txtBuscar.Text) Then OpcBusca = Buscar.BUSCAR_NOM
		Select Case OpcBusca
			Case Buscar.BUSCAR_ID
				StrSql = COLUMN_ID & " = " & txtBuscar.Text
			Case Buscar.BUSCAR_NOM
				StrSql = COLUMN_NOM & " LIKE '%" & txtBuscar.Text & "%'"
			Case Buscar.BUSCAR_TOTS
				StrSql = COLUMN_NOM & " LIKE '%" & txtBuscar.Text & "%' OR " & COLUMN_ID & " = " & txtBuscar.Text
		End Select
		
		establirRecordset(StrSql)
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
		txtNomInter.Focus()
		
	End Sub
	
	Private Sub NetejaPantalla()
		Me.txtNomInter.Text = ""
		Me.txtNomNadiu.Text = ""
		Me.chkVisible.Checked = False
		Me.txt369_1.Text = ""
		Me.txt369_2_369_5.Text = ""
		Me.txt369_3.Text = ""
		Me.lbID.Text = 0
		Me.lbVaris.Visible = False
	End Sub
	
	Private Sub LockedRecord(Optional ByVal saved As Boolean = False)
		If Me.cmdSalvar.Enabled = True And saved = False Then
            If MetroFramework.MetroMessageBox.Show(Me, MSG_SAVE_DADES, MSG_ATENCIO, MessageBoxButtons.OKCancel, MessageBoxIcon.Information, 100) = DialogResult.OK Then SaveRecord()
        End If
		blEnable = Not blEnable
		If blEnable = False Then blnNouRecord = False
		Me.txtNomInter.Enabled = blEnable
		Me.txtNomNadiu.Enabled = blEnable
		Me.txt369_3.Enabled = blEnable
		Me.txt369_2_369_5.Enabled = blEnable
		Me.txt369_1.Enabled = blEnable
		Me.chkVisible.Enabled = blEnable
		Me.cmdBorrar.Enabled = blEnable
		Me.lbNou.Visible = False
		If blEnable Then
			Me.cmdBloqueix.Image = Me.picUnLock.Image
		Else
			Me.cmdBloqueix.Image = Me.picLock.Image
			Me.cmdSalvar.Enabled = False
		End If
	End Sub
	
	Private Function FindAfectatRow() As Integer
		If blnNouRecord Then
			Return gridDades.NewRowIndex
		Else
			Return gridDades.CurrentRow.Index
		End If
	End Function
	
	#End Region
	
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
	
	Private Sub mnuRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRefresh.Click
		establirRecordset()
	End Sub
	
	#End Region
	
	
	
	Private Sub Changed()
		If blEnable = True Then Me.cmdSalvar.Enabled = True : mnuSave.Enabled = True
	End Sub
	
	Private Sub txtNomNadiu_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNomNadiu.TextChanged
		Try
			Dim RowID As Integer = FindAfectatRow()
			Me.gridDades.Rows(RowID).Cells("ColumnNomNadiu").Value = txtNomNadiu.Text
			If blEnable = True Then Me.cmdSalvar.Enabled = True
		Catch ex As Exception
		End Try
		
	End Sub
	
	Private Sub txt369_1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt369_1.TextChanged
		Try
			Dim RowID As Integer = FindAfectatRow()
			Me.gridDades.Rows(RowID).Cells("Column369_1").Value = txt369_1.Text
			Changed()
		Catch ex As Exception
		End Try
		
	End Sub
	
	Private Sub txt369_2_369_5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt369_2_369_5.TextChanged
		Try
			Dim RowID As Integer = FindAfectatRow()
			Me.gridDades.Rows(RowID).Cells("Column369_2_369_5").Value = txt369_2_369_5.Text
			Changed()
		Catch ex As Exception
		End Try
	End Sub
	
	Private Sub txt369_3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt369_3.TextChanged
		Try
			Dim RowID As Integer = FindAfectatRow()
			Me.gridDades.Rows(RowID).Cells("Column369_3").Value = txt369_3.Text
			Changed()
		Catch ex As Exception
		End Try
	End Sub
	
	Private Sub chkVisible_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVisible.CheckedChanged
		Try
			Dim RowID As Integer = FindAfectatRow()
			Me.gridDades.Rows(RowID).Cells("ColumnVisible").Value = chkVisible.Checked
			Changed()
		Catch ex As Exception
		End Try
	End Sub
	
	Private Sub mnu_Help_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_Help.Click
		Dim Proces As Process = New Process
		Try
			Process.Start(MSC.Help.HELP_GEST_PRODUCCIO.ToString)
		Catch ex As Exception
		End Try
	End Sub

End Class