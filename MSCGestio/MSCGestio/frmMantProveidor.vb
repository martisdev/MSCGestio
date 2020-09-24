Option Strict Off
Option Explicit On

Public Class frmMantProveidor    
    Dim blEnable As Boolean
    Dim blnNouRecord As Boolean    

    Const TAULA_ID As TAULES_DBS = TAULES_DBS.TAULA_PROVEIDORS
    Dim COLUMN_ID As String = ""
    Dim COLUMN_NOM As String = ""
    Dim TAULA_NOM As String = ""

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

        Me.txtNom.Text = ""
        Me.txtCiutat.Text = ""
        Me.txtComent.Text = ""
        Me.txtCP.Text = ""
        Me.txtDireccio.Text = ""
        Me.txtEMail.Text = ""
        Me.txtFax.Text = ""
        Me.txtMobil.Text = ""
        Me.txtProvincia.Text = ""
        Me.txtTelf.Text = ""

        gridDades.AllowUserToAddRows = True
        gridDades.FirstDisplayedScrollingRowIndex = gridDades.NewRowIndex
        'gridDades.BeginEdit(False)
        Me.gridDades.Rows(gridDades.NewRowIndex).Cells(0).Value = 0

        blEnable = False
        LockedRecord()

        Me.lbNou.Visible = True
        blnNouRecord = True
        txtNom.Focus()

    End Sub

    Private Sub cmdLocked_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBloqueix.Click
        LockedRecord()
    End Sub

    Private Sub LockedRecord()
        blEnable = Not blEnable
        blnNouRecord = False
        Me.PanelAdreca.Enabled = blEnable
        Me.PanelTelf.Enabled = blEnable
        Me.txtComent.Enabled = blEnable
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

    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
        DeleteRecord()
    End Sub

    Private Sub cmdSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalvar.Click
        SaveRecord()
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

    Private Sub cmdRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefrescar.Click
        establirRecordset()
    End Sub


    Private Sub txtCP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCP.KeyPress, txtFax.KeyPress, txtTelf.KeyPress, txtMobil.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        If KeyAscii < Asc("0") Or KeyAscii > Asc("9") Then If KeyAscii <> 8 Then KeyAscii = 0
        e.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub lstRecord_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        FindRecord()
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
        getVarTables(TAULA_ID, TAULA_NOM, COLUMN_ID, COLUMN_NOM)        

        If Not frmMain.NoLoadRs Then establirRecordset()
        'Me.cmdBloqueix.Enabled = IIf(Usuari.UsrTipus > NivellUsers.USR_CONVIDAT, True, False)
        Me.cmdNou.Visible = IIf(Usuari.UsrTipus > NivellUsers.USR_CONVIDAT, True, False)

        Me.mnuNew.Visible = Me.cmdNou.Visible

    End Sub

    Private Sub lbEMail_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbEMail.LinkClicked
        If Len(txtEMail.Text) > 0 Then
            Try
                Call Shell(txtEMail.Text) 'enviarEmail(Me.txtEMail.Text)
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub changed()
        If blEnable = True Then Me.cmdSalvar.Enabled = True
    End Sub

#End Region
#Region " VarTables "
    'Seccio variable segons taula-----------------------------------------
    Public Sub establirRecordset(Optional ByVal Condi As String = "")
        Windows.Forms.Cursor.Current = Cursors.AppStarting
        Dim StrSql As String = "SELECT " & COLUMN_ID & ", " & COLUMN_NOM & ",propDireccio,propCiutat,propProv,propCP,propTelf,propFax,propTMobil,propMail,propComent  FROM " & TAULA_NOM
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
        Dim Direccio As String = TractarStrings(Me.txtDireccio.Text)
        Dim Ciutat As String = TractarStrings(Me.txtCiutat.Text)
        Dim Provincia As String = TractarStrings(Me.txtProvincia.Text)
        Dim CP As String = TractarStrings(Me.txtCP.Text)
        Dim Telf As String = TractarStrings(Me.txtTelf.Text)
        Dim Fax As String = TractarStrings(Me.txtFax.Text)
        Dim Mobil As String = TractarStrings(Me.txtMobil.Text)
        Dim Mail As String = TractarStrings(Me.txtEMail.Text, True)
        Dim Coment As String = TractarStrings(Me.txtComent.Text)

        Dim ID As Integer = Me.lbID.Text
        Dim db As New MSC.db.clsDBS
        If blnNouRecord = True Then
            Dim StrSql As String = "INSERT INTO " & TAULA_NOM
            StrSql = StrSql & " ( " & COLUMN_NOM & ",propDireccio,propCiutat,propProv,propCP,propTelf,propFax,propTMobil,propMail,propComent ) VALUES "
            StrSql = StrSql & "('" & Nom & "','" & Direccio & "','" & Ciutat & "', '" & Provincia & "','" & CP & "', '" & Telf & "', '" & Fax & "', '" & Mobil & "','" & Mail & "','" & Coment & "' )"            
            ID = db.New_ID(StrSql)
            Me.gridDades.Rows(gridDades.NewRowIndex).Cells(0).Value = ID
            gridDades.EndEdit()
            gridDades.AllowUserToAddRows = False
        Else
            Dim StrSql As String = "UPDATE " & TAULA_NOM & " SET "
            StrSql = StrSql & COLUMN_NOM & "='" & Nom & "'"
            StrSql = StrSql & ", propDireccio='" & Direccio & "'"
            StrSql = StrSql & ", propCiutat='" & Ciutat & "'"
            StrSql = StrSql & ", propProv='" & Provincia & "'"
            StrSql = StrSql & ", propCP='" & CP & "'"
            StrSql = StrSql & ", propTelf='" & Telf & "'"
            StrSql = StrSql & ", propFax='" & Fax & "'"
            StrSql = StrSql & ", propTMobil='" & Mobil & "'"
            StrSql = StrSql & ", propMail='" & Mail & "'"
            StrSql = StrSql & ", propComent='" & Coment & "'"
            StrSql = StrSql & " WHERE " & COLUMN_ID & " = " & ID
            db.Update_ID(StrSql)
        End If
        RefreshDataSet(TAULA_ID)
        For i As Short = 0 To 4
            Dim combo As ComboBox = Nothing
            If IsLoadForm("frmDiscos") Then
                combo = frmDiscos.ComboProveidor
                OmpleCombo(combo, TAULA_ID, TotsCap.CAP)
                combo.SelectedValue = ID                
            End If
        Next i

        LockedRecord()
        blnNouRecord = False
        Me.gridDades.Focus()
    End Sub

    Private Sub DeleteRecord()
        If MsgBox("Segur que vols borrar permanentment aquest ítem?", vbYesNo, "Atenció") = vbNo Then Exit Sub        
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
        MyAPP.CloseSesionClient(MyAPP.IDSesion_Client, "Proveïdors")
    End Sub

#End Region

    Private Sub gridDades_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridDades.CurrentCellChanged
        Try

            Me.lbID.Text = gridDades.CurrentRow.Cells("ColumnID").Value
            Me.txtNom.Text = gridDades.CurrentRow.Cells("ColumnNom").Value
            Me.txtDireccio.Text = gridDades.CurrentRow.Cells("ColumnAdreca").Value
            Me.txtCiutat.Text = gridDades.CurrentRow.Cells("ColumnPoblacio").Value
            Me.txtProvincia.Text = gridDades.CurrentRow.Cells("ColumnProvincia").Value
            Me.txtCP.Text = gridDades.CurrentRow.Cells("ColumnCP").Value
            Me.txtTelf.Text = gridDades.CurrentRow.Cells("ColumnTelf").Value
            Me.txtFax.Text = gridDades.CurrentRow.Cells("ColumnFax").Value
            Me.txtMobil.Text = gridDades.CurrentRow.Cells("ColumnTMobil").Value
            Me.txtEMail.Text = gridDades.CurrentRow.Cells("ColumnMail").Value
            Me.txtComent.Text = gridDades.CurrentRow.Cells("ColumnComent").Value

            Me.lbPosition.Text = gridDades.CurrentRow.Index
        Catch ex As Exception
            Me.lbID.Text = 0
            Me.txtNom.Text = ""
            Me.txtDireccio.Text = ""
            Me.txtCiutat.Text = ""
            Me.txtProvincia.Text = ""
            Me.txtCP.Text = ""
            Me.txtTelf.Text = ""
            Me.txtFax.Text = ""
            Me.txtMobil.Text = ""
            Me.txtEMail.Text = ""
            Me.txtComent.Text = ""
        End Try
        Me.cmdSalvar.Enabled = False
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

    Private Sub txtNom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNom.TextChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ColumnNom").Value = TractarStrings(txtNom.Text, True)
            changed()
        Catch ex As Exception
        End Try

    End Sub


    Private Sub txtDireccio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDireccio.TextChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ColumnAdreca").Value = TractarStrings(txtDireccio.Text, True)
            changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtCiutat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCiutat.TextChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ColumnPoblacio").Value = TractarStrings(txtCiutat.Text, True)
            changed()            
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtCP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCP.TextChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ColumnCP").Value = TractarStrings(txtCP.Text, True)
            changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtProvincia_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProvincia.TextChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ColumnProvincia").Value = TractarStrings(txtProvincia.Text, True)
            changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtTelf_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTelf.TextChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ColumnTelf").Value = TractarStrings(txtTelf.Text, True)
            changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtMobil_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMobil.TextChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ColumnTMobil").Value = TractarStrings(txtMobil.Text, True)
            changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtFax_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFax.TextChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ColumnFax").Value = TractarStrings(txtFax.Text, True)
            changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtEMail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEMail.TextChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ColumnMail").Value = TractarStrings(txtEMail.Text, True)
            changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtComent_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtComent.TextChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ColumnComent").Value = TractarStrings(txtComent.Text, True)
            changed()
        Catch ex As Exception
        End Try
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
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