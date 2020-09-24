Option Strict Off
Option Explicit On

Public Class frmMantTarifa
    Dim FactorMoney As Double

    Dim blEnable As Boolean
    Dim blnNouRecord As Boolean

    Const TAULA_ID As TAULES_DBS = TAULES_DBS.TAULA_TARIFES
    Const FORM_DESCRIP As String = "Manteniment Tarifes"
    Const CONNEX_DESCRIP As String = "Tarifes"

    Dim COLUMN_ID As String = ""
    Dim COLUMN_NOM As String = ""
    Dim TAULA_NOM As String = ""



#Region " Pantalla "

    Private Sub frmMant_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        CloseForm()
    End Sub

    Private Sub frmMant_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        getVarTables(TAULA_ID, TAULA_NOM, COLUMN_ID, COLUMN_NOM)

        gridDades.Columns("columnID").DataPropertyName = COLUMN_ID
        gridDades.Columns("columnNom").DataPropertyName = COLUMN_NOM
        Me.Text = FORM_DESCRIP
        If Not frmMain.NoLoadRs Then establirRecordset()
        'Me.cmdBloqueix.Enabled = IIf(Usuari.UsrTipus > NivellUsers.USR_CONVIDAT, True, False)
        Me.cmdNou.Visible = IIf(Usuari.UsrTipus > NivellUsers.USR_CONVIDAT, True, False)

        Me.mnuNew.Visible = Me.cmdNou.Visible


        FactorMoney = Params.Canvi
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
            Me.gridDades.Rows(RowID).Cells("ColumnNom").Value = TractarStrings(txtNom.Text, True)
            changed()
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
        Try
            Me.lbID.Text = gridDades.CurrentRow.Cells("ColumnID").Value
            Me.txtNom.Text = gridDades.CurrentRow.Cells("ColumnNom").Value
            Me.txtDescrip.Text = gridDades.CurrentRow.Cells("ColumnDescrip").Value
            Me.txtPreu.Text = gridDades.CurrentRow.Cells("ColumnPreu").Value

            Me.lbPosition.Text = gridDades.CurrentRow.Index
        Catch ex As Exception
            Me.lbID.Text = 0
            Me.txtNom.Text = ""            
        End Try
    End Sub

    Private Sub txtPreu_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPreu.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        If KeyAscii = 44 Or KeyAscii = 46 Then
            KeyAscii = 44
        ElseIf KeyAscii < Asc("0") Or KeyAscii > Asc("9") Then
            If KeyAscii <> 8 Then KeyAscii = 0
        End If
        e.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtPreu_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPreu.TextChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ColumnPreu").Value = TractarStrings(txtPreu.Text, True)
            changed()
        Catch ex As Exception
        End Try
        Try
            Me.lbContraValor.Text = Strings.Format(Me.txtPreu.Text * FactorMoney, "##,##")
        Catch ex As Exception
            Me.lbContraValor.Text = 0
        End Try

    End Sub

    Private Sub txtDescrip_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescrip.TextChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ColumnDescrip").Value = TractarStrings(txtDescrip.Text, True)
            changed()
        Catch ex As Exception
        End Try
    End Sub

#End Region

#Region " Funcions internes"

    Friend Sub establirRecordset(Optional ByVal Condi As String = "")
        Windows.Forms.Cursor.Current = Cursors.AppStarting

        Dim StrSql As String = "SELECT * FROM " & TAULA_NOM
        If Condi.Length > 0 Then StrSql = StrSql & " WHERE " & Condi
        Dim db As New MSC.db.clsDBS
        Me.gridDades.DataSource = db.getTable(StrSql)
        Me.lbRecCount.Text = gridDades.Rows.Count
        gridDades.Focus()
        If gridDades.Rows.Count = 0 Then MsgBox("Cap ítem compleix les condicions requerides")

        cmdBloqueix.Enabled = IIf(gridDades.Rows.Count And Usuari.UsrTipus > NivellUsers.USR_CONVIDAT, True, False)
        Me.mnuModif.Enabled = Me.cmdBloqueix.Enabled
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

    Private Sub SaveRecord()
        If Not MyAPP.PermisPerContinuar() Then MsgBox("El servidor ha tancat aquesta pantalla", vbOKOnly, "Atenció") : Me.Close()

        If MsgBox("Segur que vols salvar les dades", vbOKCancel, "Atenció") = vbCancel Then Exit Sub

        If Len(Me.txtNom.Text) = 0 Then Exit Sub
        Dim Nom As String = TractarStrings(Me.txtNom.Text)
        Dim ID As Integer = Me.lbID.Text
        Dim Descrip As String = TractarStrings(Me.txtDescrip.Text)
        Dim Preu As Double = Me.txtPreu.Text
        Dim StrSql As String
        Dim db As New MSC.db.clsDBS
        If blnNouRecord = True Then
            StrSql = "INSERT INTO tarifes (tarifNom, tarifDescrip, tarifPreu)"
            StrSql = StrSql & " VALUES "
            StrSql = StrSql & " ( '" & Nom & "'"
            StrSql = StrSql & " , '" & Descrip & "'"
            StrSql = StrSql & " , '" & Preu & "'"
            StrSql = StrSql & " );"

            ID = db.New_ID(StrSql)
            Me.gridDades.Rows(gridDades.NewRowIndex).Cells(0).Value = ID
            gridDades.EndEdit()
            gridDades.AllowUserToAddRows = False
        Else
            StrSql = "UPDATE tarifes"
            StrSql = StrSql & " SET "
            StrSql = StrSql & " tarifDescrip = '" & Descrip & "'"
            StrSql = StrSql & ", tarifNom = '" & Nom & "'"
            StrSql = StrSql & ", tarifPreu = '" & Preu & "'"
            StrSql = StrSql & " WHERE tarifID = " & ID & " ;"

            db.Update_ID(StrSql)
        End If
        RefreshDataSet(TAULA_ID)
        For i As Short = 0 To 4
            Dim combo As ComboBox = Nothing
            If IsLoadForm("frmPubli") Then
                combo = frmPubli.ComboTarifes
                OmpleCombo(combo, TAULA_ID, TotsCap.CAP)
                combo.SelectedValue = ID
                OmpleCombo(frmPubli.ComboGridTarifa, TAULA_ID, TotsCap.CAP)
            End If
        Next i

        LockedRecord()
        blnNouRecord = False
        gridDades.Focus()
    End Sub

    Private Sub DeleteRecord()
        If MsgBox("Segur que vols borrar permanentment aquest ítem?", vbYesNo, "Atenció") = vbNo Then Exit Sub
        'Buscar dependènes
        If buscarDependencies(TAULA_ID, Me.lbID.Text) = True Then Exit Sub
        Dim StrSql As String = "DELETE FROM " & TAULA_NOM & " WHERE " & COLUMN_ID & "=" & Me.lbID.Text
        Dim db As New MSC.db.clsDBS
        db.Delete_ID(StrSql)
        Me.gridDades.Rows.RemoveAt(lbPosition.Text)

    End Sub

    Private Sub CloseForm()
        If Me.cmdSalvar.Enabled Then
            If MsgBox("Vols salvar les modificacions?", vbOKCancel) = vbOK Then SaveRecord()
        End If

        MyAPP.CloseSesionClient(MyAPP.IDSesion_Client, CONNEX_DESCRIP)
    End Sub

    Private Sub OpcionsBuscar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PerIDToolStripMenuItem.Click, PerNomToolStripMenuItem.Click, QualsevolToolStripMenuItem.Click
        For i As Integer = 0 To OptionBuscar.DropDownItems.Count - 1
            CType(OptionBuscar.DropDownItems(i), ToolStripMenuItem).Checked = False
        Next
        CType(sender, ToolStripMenuItem).Checked = True
    End Sub

    Private Sub FindRecord()
        If txtBuscar.Text.Length = 0 Or txtBuscar.Text = "Buscar..." Then Exit Sub
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
        Me.txtNom.Text = ""
        Me.txtDescrip.Text = ""
        Me.txtPreu.Text = 0
        Me.lbID.Text = Me.lbUltim.Text + 1
        gridDades.AllowUserToAddRows = True
        gridDades.FirstDisplayedScrollingRowIndex = gridDades.NewRowIndex
        'gridDades.BeginEdit(False)
        Me.gridDades.Rows(gridDades.NewRowIndex).Cells(0).Value = lbID.Text

        blEnable = False
        LockedRecord()

        Me.lbNou.Visible = True
        blnNouRecord = True
        txtNom.Focus()

    End Sub

    Private Sub LockedRecord()
        blEnable = Not blEnable
        blnNouRecord = False
        Me.txtNom.Enabled = blEnable
        Me.txtDescrip.Enabled = blEnable
        Me.txtPreu.Enabled = blEnable

        Me.cmdBorrar.Enabled = blEnable
        Me.lbNou.Visible = False
        If blEnable Then
            Me.cmdBloqueix.Image = Me.picUnLock.Image
        Else
            Me.cmdBloqueix.Image = Me.picLock.Image
            Me.cmdSalvar.Enabled = False
        End If
    End Sub

    Private Sub changed()
        If blEnable = True Then Me.cmdSalvar.Enabled = True
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
            Dim db As New MSC.db.clsDBS
            Dim StrSql As String = "SELECT falcID, falcNomFalca FROM `falques` where falcTarifa =" & Me.lbID.Text
            Dim dt As DataTable = db.getTable(StrSql)
            Me.DataGridViewAnuncis.DataSource = dt : DataGridViewAnuncis.Columns(1).HeaderText = "Nom ( " & dt.Rows.Count & " registres) "
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

#End Region

End Class