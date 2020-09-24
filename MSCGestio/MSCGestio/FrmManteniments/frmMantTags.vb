Option Strict Off
Option Explicit On

Public Class frmMantTags
	
	Dim blEnable As Boolean = False
	Dim blnNouRecord As Boolean = False
	Dim IsSaving As Boolean = False
	
	Private Sub frmMantTags_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		CloseForm()
	End Sub
	
	Private Sub frmMantTags_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IsChild = False Then IniTable()
        If My.Settings.TXT_CAPITALIZE Then Me.txtNom.CharacterCasing = CharacterCasing.Upper

        If Not frmMain.NoLoadRs Then establirRecordset()
        'Me.cmdBloqueix.Enabled = IIf(usuari.UsrTipus > NivellUsers.USR_CONVIDAT, True, False)
        Me.cmdNou.Visible = IIf(Usuari.UsrTipus > NivellUsers.USR_CONVIDAT, True, False)
        Me.mnuNew.Visible = Me.cmdNou.Visible
    End Sub

    Dim IsChild As Boolean = False
    Friend Sub IniTable()
        setLanguageForm()

        IsChild = True
    End Sub


    Dim FORM_DESCRIP As String = "Manteniment Tags"
	Dim CONNEX_DESCRIP As String = "Tags"
	
	Public Sub setLanguageForm()
		lang.StrForm = Me.Name
		
		FORM_DESCRIP = lang.getText("Text") '"Manteniment Tags"
		CONNEX_DESCRIP = lang.getText("CONNEX_DESCRIP") '"Tags"
		Me.Label4.Text = lang.getText("Label4.Text") '"Tag Mare"
		Me.label3.Text = lang.getText("label3.Text") '"Nº de Clicks"
		
		
		'Me.cmdExit.Text = "Button1"
		Me.ColumnID.HeaderText = lang.getText("HEADERTEXT_ID",True) '"ID"
        Me.ColumnNom.HeaderText = lang.getText("LABEL_NOM", True) '"Nom"
        Me.ColumnParent.HeaderText = Me.Label4.Text
        Me.PerNomToolStripMenuItem.Text = lang.getText("mnu_Buscar_NOM",True)'"Per Nom"
		Me.PerIDToolStripMenuItem.Text = lang.getText("mnu_Buscar_ID",True)'"Per ID"
		Me.QualsevolToolStripMenuItem.Text = lang.getText("mnu_Buscar_QUALSEVOL",True)'"Qualsevol"
		Me.OptionBuscar.Text = lang.getText("LABEL_BUSCAR",True)'"Buscar"
		Me.OptionBuscar.ToolTipText = lang.getText("mnu_Buscar_ToolTipText",True)'"Opcions de recerca"
		
		Me.lbNou.Text = lang.getText("LABEL_NEW_UPPER",True) '"NOU"
		Me.Label2.Text = lang.getText("LABEL_NOM",True) & ":" '"Nom:"
		Me.Label1.Text = lang.getText("LABEL_IDENTIFICADOR",True) & ":" '"Identificador:"
		'Me.Button1.Text = "Button1"
		Me.txtBuscar.Text = lang.getText("LABEL_BUSCAR",True) & ".." '"Buscar.."
		'Me.ToolStrip1.Text = "ToolStrip1"
		Me.cmdPrimer.Text = lang.getText("LABEL_GOTO_FIRSH",True)'"Primer"
		Me.cmdPrevi.Text = lang.getText("LABEL_GOTO_PREV",True) '"Anterior"
        Me.cmdUltim.Text = lang.getText("LABEL_GOTO_NEXT", True) '"Següent"
        Me.cmdUltim.Text = lang.getText("LABEL_GOTO_LAST", True) '"Últim"
        Me.cmdNou.Text = lang.getText("LABEL_NEW", True) '"Nou"
        Me.cmdBloqueix.Text = lang.getText("LABEL_EDITAR", True) '"Editar"
        Me.cmdBorrar.Text = lang.getText("LABEL_DELETE", True) '"Borrar"
        Me.cmdSalvar.Text = lang.getText("LABEL_SAVE", True) '"Salvar"
        Me.cmdRefrescar.Text = lang.getText("LABEL_REFRESCAR", True) '"Refrescar"
        Me.cmdSortir.Text = lang.getText("LABEL_EXIT", True) '"Sortir"		

        'Me.MenuStrip1.Text = "MenuStrip1"
        Me.ProgarmaToolStripMenuItem.Text = lang.getText("LABEL_PROGRAMA", True) '"Programa"
        Me.mnuExit.Text = lang.getText("LABEL_EXIT", True) '"Sortir"
        Me.EdicióToolStripMenuItem.Text = lang.getText("mnuEdit.Text", True) '"Edició"
        Me.mnuModif.Text = lang.getText("LABEL_MODIFICAR", True) '"Modificar"
        Me.mnuSave.Text = lang.getText("LABEL_SALVAR", True) '"Salvar"
        Me.mnuNew.Text = lang.getText("LABEL_NEW", True) '"Nou"
        Me.mnuDel.Text = lang.getText("LABEL_DELETE", True) '"Borrar"
        Me.mnuRefresh.Text = lang.getText("LABEL_REFRESCAR", True) '"Refrescar"
        Me.ToolStripMenuItem1.Text = lang.getText("mnu_Help", True) '"Ajuda"
        Me.mnu_Help.Text = lang.getText("mnuRefHelp.Text", True) '"Manual OnLine"				
        Me.Text = FORM_DESCRIP

        Dim Cmb As New combo
        Cmb.OmpleCombo(ColumnParent, TAULES_DBS.TAULA_LIST_TAGS, TotsCap.CAP)
        Cmb.OmpleCombo(ComboBoxTags, TAULES_DBS.TAULA_LIST_TAGS, TotsCap.CAP) : ComboBoxTags.SelectedValue = 0

    End Sub


    Friend Sub establirRecordset(Optional ByVal Condi As String = "")
        System.Windows.Forms.Cursor.Current = Cursors.AppStarting
        Dim db As New MSC.dbs(Cloud)

        Dim StrSql As String = "SELECT * FROM list_tags"
        If Condi.Length > 0 Then StrSql = StrSql & " WHERE " & Condi

        Me.gridDades.DataSource = db.getTable(StrSql)
        Me.lbRecCount.Text = gridDades.Rows.Count
        gridDades.Focus()
        If gridDades.Rows.Count = 0 Then MetroFramework.MetroMessageBox.Show(Me, MSG_NO_ITEM_FOR_CONDITION, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, 100)

        cmdBloqueix.Enabled = IIf(gridDades.Rows.Count And Usuari.UsrTipus > NivellUsers.USR_CONVIDAT, True, False)
        Me.mnuModif.Enabled = Me.cmdBloqueix.Enabled
        System.Windows.Forms.Cursor.Current = Cursors.Default

    End Sub

    Private Sub cmdSortir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSortir.Click
        Me.Close()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub gridDades_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridDades.CurrentCellChanged
        If IsSaving = True Then Exit Sub
        Try
            If blEnable = True Then LockedRecord()
            Me.lbID.Text = gridDades.CurrentRow.Cells("ColumnID").Value
            Me.txtNom.Text = gridDades.CurrentRow.Cells("ColumnNom").Value
            Me.ComboBoxTags.SelectedValue = gridDades.CurrentRow.Cells("ColumnParent").Value
            Me.lbNumCliks.Text = gridDades.CurrentRow.Cells("ColumnCount").Value
            Me.lbPosition.Text = gridDades.CurrentRow.Index
        Catch ex As Exception
            BorrarPantalla()
        End Try
    End Sub

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


    Private Sub BorrarPantalla()
        Me.lbID.Text = ""
        Me.txtNom.Text = ""
        Me.ComboBoxTags.SelectedItem = 0
        Me.lbNumCliks.Text = ""
    End Sub

    Private Sub LockedRecord(Optional ByVal saved As Boolean = False)
        If Me.cmdSalvar.Enabled = True And saved = False Then
            If MetroFramework.MetroMessageBox.Show(Me, MSG_SAVE_DADES, MSG_ATENCIO, MessageBoxButtons.OKCancel, MessageBoxIcon.Information, 100) = DialogResult.OK Then SaveRecord()
        End If
        blEnable = Not blEnable
        If blEnable = False Then blnNouRecord = False
        Me.txtNom.Enabled = blEnable
        Me.ComboBoxTags.Enabled = blEnable
        Me.cmdBorrar.Enabled = blEnable
        Me.lbNou.Visible = False
        If blEnable Then
            Me.cmdBloqueix.Image = Me.picUnLock.Image
        Else
            Me.cmdBloqueix.Image = Me.picLock.Image
            Me.cmdSalvar.Enabled = False
        End If
    End Sub

    Friend ID As Integer
    Private Sub SaveRecord()
        If Not MyAPP.PermisPerContinuar() Then MetroFramework.MetroMessageBox.Show(Me, MSG_SERVER_CLOSE, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Stop, 100) : Me.Close()
        If MetroFramework.MetroMessageBox.Show(Me, MSG_CONFIRM_SAVE_DADES, MSG_ATENCIO, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, 100) = DialogResult.Cancel Then Exit Sub

        If Len(Me.txtNom.Text) = 0 Then Exit Sub
        IsSaving = True
        Dim Nom As String = AddSlashes(Me.txtNom.Text)
        ID = Me.lbID.Text
        Dim IdPare As Integer = Me.ComboBoxTags.SelectedValue
        Dim db As New MSC.dbs(Cloud)
        If blnNouRecord = True Then
            Dim StrSql As String = "INSERT INTO list_tags ( tag_nom,tag_parent ) VALUES ('" & Nom & "', " & IdPare & ") "
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
            Dim StrSql As String = "UPDATE list_tags SET tag_nom ='" & Nom & "',tag_parent= " & IdPare & "  WHERE tag_id = " & ID
            db.Update_ID(StrSql)
        End If

        RefreshDataSet(TAULES_DBS.TAULA_LIST_TAGS)
        Me.DialogResult = DialogResult.OK

        Dim Cmb As New combo
        Cmb.OmpleCombo(ColumnParent, TAULES_DBS.TAULA_LIST_TAGS, TotsCap.CAP)
        Dim OldValue As Integer = ComboBoxTags.SelectedValue
        Cmb.OmpleCombo(ComboBoxTags, TAULES_DBS.TAULA_LIST_TAGS, TotsCap.CAP) : ComboBoxTags.SelectedValue = OldValue

        db = Nothing
        IsSaving = False
        LockedRecord(True)
        blnNouRecord = False
        gridDades.Focus()
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

    End Sub

    Private Sub DeleteRecord()
        If blnNouRecord = True Then
            LockedRecord(True)
            NetejaPantalla()
            gridDades.AllowUserToAddRows = False
            Exit Sub
        End If
        If MetroFramework.MetroMessageBox.Show(Me, String.Format(MSG_CONFIRM_DELETE_NUM_DADES, gridDades.SelectedRows.Count), MSG_ATENCIO, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, 100) = DialogResult.Cancel Then Exit Sub

        Dim db As New MSC.dbs(Cloud)
        For i As Short = 0 To Me.gridDades.SelectedRows.Count - 1
            Dim ID As Integer = gridDades.SelectedRows(i).Cells(0).Value
            'Buscar dependènes
            If buscarDependencies(TAULES_DBS.TAULA_LIST_TAGS, ID, Me) = True Then Exit Sub
            Dim StrSql As String = "DELETE FROM list_tags WHERE tag_id=" & ID

            db.Delete_ID(StrSql)
            addCtlRadi(0, CShort(Tipus_Play.CTL_SQL), 0, "00:00:00", 0, 0, Usuari.UsrID, StrSql, 0, False)
        Next
        For Each selectedrow As DataGridViewRow In gridDades.SelectedRows
            gridDades.Rows.Remove(selectedrow)
        Next
        db = Nothing

        RefreshDataSet(TAULES_DBS.TAULA_LIST_TAGS)
        If IsLoadForm("frmProgrames") Then frmProgrames.OmpleMnuTAGS()
    End Sub

    Private Sub CloseForm()
        If Me.cmdSalvar.Enabled Then
            If MetroFramework.MetroMessageBox.Show(Me, MSG_SAVE_DADES, MSG_ATENCIO, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, 100) = DialogResult.OK Then SaveRecord()
        End If

        MyAPP.CloseSesionClient(MyAPP.IDSesion_Client, DESCRIP_FORM_TAGS)
    End Sub

    Private Sub cmdBloqueix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBloqueix.Click
        LockedRecord()
    End Sub

    Private Sub cmdNou_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNou.Click
        NewRecord()
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

    Private Sub txtBuscar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        txtBuscar.Text = ""
    End Sub

    Private Sub txtBuscar_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuscar.KeyUp
        If e.KeyCode = Keys.Enter Then FindRecord()
    End Sub

    Private Sub txtBuscar_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        FindRecord()
    End Sub

    Private Sub txtNom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNom.TextChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ColumnNom").Value = txtNom.Text
            Changed()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub Changed()
        If blEnable = True Then Me.cmdSalvar.Enabled = True : mnuSave.Enabled = True
    End Sub


    Private Function FindAfectatRow() As Integer
        If blnNouRecord Then
            Return gridDades.NewRowIndex
        Else
            Return gridDades.CurrentRow.Index
        End If
    End Function

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
                StrSql = "tag_id =" & txtBuscar.Text
            Case Buscar.BUSCAR_NOM
                StrSql = "tag_nom LIKE '%" & txtBuscar.Text & "%'"
            Case Buscar.BUSCAR_TOTS
                StrSql = "tag_nom LIKE '%" & txtBuscar.Text & "%' OR tag_id = " & txtBuscar.Text
        End Select

        establirRecordset(StrSql)
    End Sub


    Private Sub OpcionsBuscar(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For i As Integer = 0 To OptionBuscar.DropDownItems.Count - 1
            CType(OptionBuscar.DropDownItems(i), ToolStripMenuItem).Checked = False
        Next
        CType(sender, ToolStripMenuItem).Checked = True
    End Sub

    Private Sub ComboBoxTags_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxTags.SelectedIndexChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ColumnParent").Value = ComboBoxTags.SelectedValue

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

    Private Sub cmdLocked_Click(sender As Object, e As EventArgs)

    End Sub
End Class