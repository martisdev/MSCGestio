Option Strict Off
Option Explicit On

Public Class frmMantSubject
    Dim blEnable As Boolean
    Dim blnNouRecord As Boolean
    Dim IsSaving As Boolean = False

    Const TAULA_ID As TAULES_DBS = TAULES_DBS.TAULA_SUBJECTIV

    Dim COLUMN_ID As String = ""
    Dim COLUMN_NOM As String = ""
    Dim TAULA_NOM As String = ""

    '----------------------------    



#Region " Pantalla "

    Private Sub changed()
        If blEnable = True Then Me.cmdSalvar.Enabled = True : mnuSave.Enabled = True
    End Sub

    Private Sub frmMant_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        CloseForm()
    End Sub

    Private Sub frmMantSubject_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        IniTable()
        If My.Settings.TXT_CAPITALIZE Then Me.txtNom.CharacterCasing = CharacterCasing.Upper

        If Not frmMain.NoLoadRs Then establirRecordset()
        'Me.cmdBloqueix.Enabled = IIf(usuari.UsrTipus > NivellUsers.USR_CONVIDAT, True, False)
        Me.cmdNou.Visible = IIf(Usuari.UsrTipus > NivellUsers.USR_CONVIDAT, True, False)
        Me.mnuNew.Visible = Me.cmdNou.Visible
    End Sub

    Friend Sub IniTable()
        setLanguageForm()
        getVarTables(TAULA_ID, TAULA_NOM, COLUMN_ID, COLUMN_NOM)
        gridDades.Columns("columnID").DataPropertyName = COLUMN_ID
        gridDades.Columns("columnNom").DataPropertyName = COLUMN_NOM
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

    Private Sub txtNom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNom.TextChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ColumnNom").Value = txtNom.Text
            changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtBuscar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.GotFocus
        txtBuscar.Text = ""
    End Sub


    Private Sub txtBuscar_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.LostFocus
        FindRecord()
    End Sub

    Private Sub gridDades_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridDades.CurrentCellChanged
        If IsSaving = True Then Exit Sub
        Try
            If blEnable = True Then LockedRecord()
            Me.lbID.Text = gridDades.CurrentRow.Cells("ColumnID").Value
            Me.txtNom.Text = StripSlashes(gridDades.CurrentRow.Cells("ColumnNom").Value)
            Me.lbPosition.Text = gridDades.CurrentRow.Index
            Me.lbVaris.Visible = IIf(lbID.Text = 1, True, False)
        Catch ex As Exception
            Me.lbID.Text = 0
            Me.txtNom.Text = ""
            Me.lbVaris.Visible = False
        End Try
    End Sub

    Dim FORM_DESCRIP As String = "Manteniment Subjectivitat"
    Dim CONNEX_DESCRIP As String = "Classificació Subjectiva"

    Public Sub setLanguageForm()
        lang.StrForm = Me.Name

        FORM_DESCRIP = lang.getText("Text") '"Manteniment Subjectivitat"
        Me.TabPage1.Text = lang.getText("TabPage1.Text") '""LListat Clas. Subjectiva""
        Me.TabPage2.Text = lang.getText("TabPage2.Text") '"Cançons d'aquesta classificació"
        CONNEX_DESCRIP = lang.getText("LABEL_CLASSIFICACIO_SUBJ", True) '"Classificació Subjectiva"

        'Me.cmdExit.Text = "Button1"
        Me.ColumnID.HeaderText = lang.getText("HEADERTEXT_ID", True) '"ID"
        Me.ColumnNom.HeaderText = lang.getText("LABEL_NOM", True) '"Nom"
        Me.PerNomToolStripMenuItem.Text = lang.getText("mnu_Buscar_NOM", True) '"Per Nom"
        Me.PerIDToolStripMenuItem.Text = lang.getText("mnu_Buscar_ID", True) '"Per ID"
        Me.QualsevolToolStripMenuItem.Text = lang.getText("mnu_Buscar_QUALSEVOL", True) '"Qualsevol"
        Me.OptionBuscar.Text = lang.getText("LABEL_BUSCAR", True) '"Buscar"
        Me.OptionBuscar.ToolTipText = lang.getText("mnu_Buscar_ToolTipText", True) '"Opcions de recerca"
        Me.lbVaris.Text = MSG_ID_VARIS_NO_BORRAR
        Me.lbNou.Text = lang.getText("LABEL_NEW_UPPER", True) '"NOU"
        Me.Label2.Text = lang.getText("LABEL_NOM", True) & ":" '"Nom:"
        Me.Label1.Text = lang.getText("LABEL_IDENTIFICADOR", True) & ":" '"Identificador:"
        'Me.Button1.Text = "Button1"
        Me.txtBuscar.Text = lang.getText("LABEL_BUSCAR", True) & ".." '"Buscar.."
        'Me.ToolStrip1.Text = "ToolStrip1"
        Me.cmdPrimer.Text = lang.getText("LABEL_GOTO_FIRSH", True) '"Primer"
        Me.cmdPrevi.Text = lang.getText("LABEL_GOTO_PREV", True) '"Anterior"
        Me.cmdSeguent.Text = lang.getText("LABEL_GOTO_NEXT", True) '"Següent"
        Me.cmdUltim.Text = lang.getText("LABEL_GOTO_LAST", True) '"Últim"
        Me.cmdNou.Text = lang.getText("LABEL_NEW", True) '"Nou"
        Me.cmdBloqueix.Text = lang.getText("LABEL_EDITAR", True) '"Editar"
        Me.cmdBorrar.Text = lang.getText("LABEL_DELETE", True) '"Borrar"
        Me.cmdSalvar.Text = lang.getText("LABEL_SAVE", True) '"Salvar"
        Me.cmdRefrescar.Text = lang.getText("LABEL_REFRESCAR", True) '"Refrescar"
        Me.cmdSortir.Text = lang.getText("LABEL_EXIT", True) '"Sortir"		

        Me.DataGridViewTextBoxColumn3.HeaderText = lang.getText("HEADERTEXT_ID", True) '"ID"
        Me.DataGridViewTextBoxColumn4.HeaderText = lang.getText("LABEL_NOM", True) '"Nom"
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

    End Sub

#End Region

#Region " Funcions internes"

    Friend Sub establirRecordset(Optional ByVal Condi As String = "")
        System.Windows.Forms.Cursor.Current = Cursors.AppStarting

        Dim StrSql As String = "SELECT " & COLUMN_ID & ", " & COLUMN_NOM & " FROM " & TAULA_NOM
        If Condi.Length > 0 Then StrSql = StrSql & " WHERE " & Condi
        Dim db As New MSC.dbs(Cloud)
        Me.gridDades.DataSource = db.getTable(StrSql)
        Me.lbRecCount.Text = gridDades.Rows.Count
        db = Nothing
        gridDades.Focus()
        If gridDades.Rows.Count = 0 Then MetroFramework.MetroMessageBox.Show(Me, MSG_NO_ITEM_FOR_CONDITION, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, 100)

        cmdBloqueix.Enabled = IIf(gridDades.Rows.Count And Usuari.UsrTipus > NivellUsers.USR_CONVIDAT, True, False)
        Me.mnuModif.Enabled = Me.cmdBloqueix.Enabled
        System.Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

    Friend ID As Integer
    Private Sub SaveRecord()
        If Me.lbVaris.Visible Then MetroFramework.MetroMessageBox.Show(Me, MSG_NOT_EDIT_ID, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, 100) : Exit Sub
        If Not MyAPP.PermisPerContinuar() Then MetroFramework.MetroMessageBox.Show(Me, MSG_SERVER_CLOSE, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Stop, 100) : Me.Close()
        If MetroFramework.MetroMessageBox.Show(Me, MSG_CONFIRM_SAVE_DADES, MSG_ATENCIO, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, 100) = DialogResult.Cancel Then Exit Sub

        If Len(Me.txtNom.Text) = 0 Then Exit Sub
        IsSaving = True
        Dim Nom As String = AddSlashes(Me.txtNom.Text)
        ID = Me.lbID.Text
        Dim db As New MSC.dbs(Cloud)
        If blnNouRecord = True Then
            Dim StrSql As String = "INSERT INTO " & TAULA_NOM & " ( " & COLUMN_NOM & " ) VALUES ('" & Nom & "')"
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
            Dim StrSql As String = "UPDATE " & TAULA_NOM & " SET " & COLUMN_NOM & "='" & Nom & "' WHERE " & COLUMN_ID & " = " & ID
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
    End Sub

    Private Sub CloseForm()
        If Me.cmdSalvar.Enabled Then
            If MetroFramework.MetroMessageBox.Show(Me, MSG_SAVE_DADES, MSG_ATENCIO, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, 100) = DialogResult.OK Then SaveRecord()
        End If

        MyAPP.CloseSesionClient(MyAPP.IDSesion_Client, DESCRIP_FORM_CLAS_SUBJ)

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
        Me.txtNom.Text = ""
        Me.lbID.Text = 0
        Me.lbVaris.Visible = False

        blEnable = False
        LockedRecord()

        Me.lbNou.Visible = True

        txtNom.Focus()

    End Sub

    Private Sub LockedRecord(Optional ByVal saved As Boolean = False)
        If Me.cmdSalvar.Enabled = True And saved = False Then
            If MetroFramework.MetroMessageBox.Show(Me, MSG_SAVE_DADES, MSG_ATENCIO, MessageBoxButtons.OKCancel, MessageBoxIcon.Information, 100) = DialogResult.OK Then SaveRecord()
        End If
        blEnable = Not blEnable
        If blEnable = False Then blnNouRecord = False
        Me.txtNom.Enabled = blEnable
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

    Private Sub TabControlMesInfo_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TabControlMesInfo.MouseUp
        If TabControlMesInfo.SelectedIndex = 1 Then
            Dim db As New MSC.dbs(Cloud)
            Dim StrSql As String = "SELECT tema_id, tema_titol FROM `temes` where tema_subj =" & Me.lbID.Text
            Me.DataGridViewTemes.DataSource = db.getTable(StrSql) : DataGridViewTemes.Columns(1).HeaderText = Me.ColumnNom.HeaderText & " ( " & DataGridViewTemes.Rows.Count & " " & LABEL_REGISTRES & ")"
            db = Nothing
        End If
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

    Private Sub mnuRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRefresh.Click
        establirRecordset()
    End Sub

    Private Sub mnu_Help_Click(sender As Object, e As EventArgs) Handles mnu_Help.Click

    End Sub

    Private Sub txtBuscar_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyUp
        If e.KeyCode = Keys.Enter Then FindRecord()
    End Sub

#End Region


End Class