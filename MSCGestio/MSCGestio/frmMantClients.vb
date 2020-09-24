Option Strict Off
Option Explicit On

Public Class frmMantClients
    Dim Cancelled As Boolean
    Dim blEnable As Boolean
    Dim blnNouRecord As Boolean
    Const TAULA_ID As TAULES_DBS = TAULES_DBS.TAULA_CLIENTS

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
        Me.lbID.Text = 0
        Me.txtNom.Text = ""
        Me.txtNomFisc.Text = ""
        Me.txtNif.Text = ""
        Me.txtDireccio.Text = ""
        Me.txtCiutat.Text = ""
        Me.txtZip.Text = ""
        Me.txtTelf.Text = ""
        Me.txtFax.Text = ""

        Me.txtNomContacte.Text = ""
        Me.txtObserv.Text = ""
        Me.lbDataCrea.Text = Strings.Format(Now, "yyyy-MM-dd HH:mm:ss")
        Me.ComboProducte.SelectedIndex = 0
        Me.txtEMail.Text = ""
        Me.ComboAgents.SelectedIndex = 0

        Me.chkActvWeb.Checked = False
        Me.txtNickWeb.Text = ""
        Me.txtPswWeb.Text = ""

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
        Me.txtNom.Enabled = blEnable
        Me.PanelGeneral.Enabled = blEnable
        Me.PanelLocalitz.Enabled = blEnable
        Me.PanelWeb.Enabled = blEnable
        Me.cmdBorrar.Enabled = blEnable
        Me.mnuDel.Enabled = blEnable

        Me.lbNou.Visible = False
        If blEnable Then
            Me.cmdBloqueix.Image = Me.picUnLock.Image
        Else
            Me.cmdBloqueix.Image = Me.picLock.Image
            Me.cmdSalvar.Enabled = False
            Me.mnuSave.Enabled = False
        End If
    End Sub

    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
        DeleteRecord()
    End Sub

    Private Sub cmdSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalvar.Click
        SaveRecord()
    End Sub


    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionBuscar.Click
        FindRecord()
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
                StrSql = "cliID = " & txtBuscar.Text
            Case Buscar.BUSCAR_NOM
                StrSql = "cliNom LIKE '%" & txtBuscar.Text & "%'"
            Case Buscar.BUSCAR_TOTS
                StrSql = "cliNom LIKE '%" & txtBuscar.Text & "%' OR cliID = " & txtBuscar.Text
        End Select
        establirRecordset(StrSql)
    End Sub

    Private Sub cmdRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefrescar.Click
        establirRecordset()
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Cancelled = True
    End Sub

    Private Sub txtNif_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNif.LostFocus
        If txtNif.Text = "" Then Exit Sub
        Dim NumDNI As String = Strings.Left(Me.txtNif.Text, 8)
        Dim StrLletraNIF As String = ""
        Try
            StrLletraNIF = LletraNif(NumDNI)
        Catch ex As Exception

        Finally
            If UCase(Strings.Right(txtNif.Text, 1)) <> StrLletraNIF Then
                MsgBox("El NIF NO és correcte")
                txtNif.Text = ""
                txtNif.Focus()
            End If
        End Try
    End Sub

    Private Sub lstRecord_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        FindRecord()
    End Sub

    Private Sub cmdPrimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrimer.Click
        Me.gridDades.Focus()
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

        OmpleCombo(ComboProducte, TAULES_DBS.TAULA_PRODUCTES, TotsCap.CAP)
        ComboProducte.SelectedValue = 0
        OmpleCombo(ComboAgents, TAULES_DBS.TAULA_AGENTS_COMERCIALS, TotsCap.CAP)
        ComboAgents.SelectedValue = 0

        If Not frmMain.NoLoadRs Then establirRecordset()

        Dim UserTip As Integer = Usuari.UsrTipus
        'Me.cmdBloqueix.Enabled = IIf(UserTip > NivellUsers.USR_CONVIDAT, True, False)                
        Me.cmdNou.Enabled = IIf(UserTip > NivellUsers.USR_CONVIDAT, True, False)
        mnuNew.Enabled = IIf(UserTip > NivellUsers.USR_CONVIDAT, True, False)

        Me.mnuNew.Visible = Me.cmdNou.Visible

    End Sub
#End Region

#Region " VarTables "
    'Seccio variable segons taula-----------------------------------------

    Public Sub establirRecordset(Optional ByVal Condi As String = "")
        Windows.Forms.Cursor.Current = Cursors.AppStarting

        Dim StrSql As String = "SELECT cliID, cliNom,cliNomFiscal,cliCifDni,cliContacte,cliProducteID,cliAgent,cliObserv,cliDataCrea,cliDireccio,cliCiutat,cliZip,cliTelf,cliFax,cliEMail,cliWebActv,cliWebNick,cliWebPSW FROM clients"
        If Condi.Length > 0 Then StrSql = StrSql & " WHERE " & Condi
        Dim db As New MSC.db.clsDBS
        gridDades.DataSource = db.getTable(StrSql)

        If gridDades.Rows.Count = 0 Then MsgBox("Cap ítem compleix les condicions requerides")
        Me.lbRecCount.Text = gridDades.Rows.Count
        gridDades.Focus()
        cmdBloqueix.Enabled = IIf(gridDades.Rows.Count And Usuari.UsrTipus > NivellUsers.USR_CONVIDAT, True, False)
        Me.mnuModif.Enabled = Me.cmdBloqueix.Enabled

        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

    Private Sub SaveRecord()
        If Not MyAPP.PermisPerContinuar() Then MsgBox("El servidor ha tancat aquesta pantalla", vbOKOnly, "Atenció") : Me.Close()
        If MsgBox("Segur que vols salvar les dades", vbOKCancel, "Atenció") = vbCancel Then Exit Sub
        If Me.txtNom.TextLength = 0 Then
            MsgBox("El nom del client és obligatori")
            txtNom.Focus()
            Exit Sub
        ElseIf Me.ComboProducte.SelectedIndex = 0 Then
            MsgBox("És obligatori assignar un producte")
            ComboProducte.Focus()
            Exit Sub
        End If

        Dim Nom As String = TractarStrings(Me.txtNom.Text)
        Dim NomFisc As String = TractarStrings(Me.txtNomFisc.Text)
        Dim NIF As String = TractarStrings(Me.txtNif.Text)
        Dim Direccio As String = TractarStrings(Me.txtDireccio.Text)
        Dim Ciutat As String = TractarStrings(Me.txtCiutat.Text)
        Dim Zip As String = IIf(Me.txtZip.TextLength = 0, "0", txtZip.Text.ToString)
        Dim Telf As String = TractarStrings(Me.txtTelf.Text)
        Dim Fax As String = TractarStrings(Me.txtFax.Text)
        Dim Contacte As String = TractarStrings(Me.txtNomContacte.Text)
        Dim Observ As String = TractarStrings(Me.txtObserv.Text)
        Dim EMail As String = TractarStrings(Me.txtEMail.Text)
        Dim Producte As Short = Me.ComboProducte.SelectedValue
        Dim IdAgent As Short = Me.ComboAgents.SelectedValue
        Dim WebActv As Boolean = chkActvWeb.Checked
        Dim WebNick As String = TractarStrings(Me.txtNickWeb.Text, True)
        Dim WebPsw As String = TractarStrings(Me.txtPswWeb.Text, True)
        Dim db As New MSC.db.clsDBS
        Dim StrSql As String = ""
        Dim ID As Integer = lbID.Text
        If blnNouRecord Then
            StrSql = "INSERT INTO clients (cliNom, cliNomFiscal, cliCifDni, cliDireccio"
            StrSql = StrSql & " , cliCiutat, cliZIP, cliTelf, cliFax, cliContacte, cliObserv,cliProducteID"
            StrSql = StrSql & ", cliEMail, cliFormInf, cliAgent, cliDataCrea, cliWebActv, cliWebNick, cliWebPSW)"
            StrSql = StrSql & " VALUES "
            StrSql = StrSql & " ( '" & Nom & "'"
            StrSql = StrSql & ", '" & NomFisc & "'"
            StrSql = StrSql & ", '" & NIF & "'"
            StrSql = StrSql & ", '" & Direccio & "'"
            StrSql = StrSql & ", '" & Ciutat & "'"
            StrSql = StrSql & ", '" & Zip & "'"
            StrSql = StrSql & ", '" & Telf & "'"
            StrSql = StrSql & ", '" & Fax & "'"
            StrSql = StrSql & ", '" & Contacte & "'"
            StrSql = StrSql & ", '" & Observ & "'"
            StrSql = StrSql & ", " & Producte
            StrSql = StrSql & ", '" & EMail & "'"
            StrSql = StrSql & ", " & 0
            StrSql = StrSql & ", " & IdAgent
            StrSql = StrSql & ", '" & Now.ToString("yyyy-MM-dd HH:mm:ss") & "'"
            StrSql = StrSql & ", " & CShort(IIf(WebActv, 1, 0))
            StrSql = StrSql & ", '" & WebNick & "'"
            StrSql = StrSql & ", '" & WebPsw & "'"

            StrSql = StrSql & ");"

            ID = db.New_ID(StrSql)

            Me.gridDades.Rows(gridDades.NewRowIndex).Cells(0).Value = ID
            gridDades.EndEdit()
            gridDades.AllowUserToAddRows = False

        Else
            StrSql = "UPDATE clients"
            StrSql = StrSql & " SET "
            StrSql = StrSql & " cliNom = '" & Nom & "'"
            StrSql = StrSql & ", cliNomFiscal = '" & NomFisc & "'"
            StrSql = StrSql & ", cliCifDni = '" & NIF & "'"
            StrSql = StrSql & ", cliDireccio = '" & Direccio & "'"
            StrSql = StrSql & ", cliCiutat = '" & Ciutat & "'"
            StrSql = StrSql & ", cliZIP = '" & Zip & "'"
            StrSql = StrSql & ", cliTelf = '" & Telf & "'"
            StrSql = StrSql & ", cliFax = '" & Fax & "'"
            'StrSql = StrSql & ", cliSucursal = '" & Sucursal & "'"
            'StrSql = StrSql & ", cliCompte = '" & Compte & "'"
            'StrSql = StrSql & ", cliTitular = '" & Titular & "'"
            'StrSql = StrSql & ", cliBancID = " & Banc
            'StrSql = StrSql & ", cliCondiciopagament = " & CondiPag
            StrSql = StrSql & ", cliContacte = '" & Contacte & "'"
            StrSql = StrSql & ", cliObserv = '" & Observ & "'"
            StrSql = StrSql & ", cliProducteID = " & Producte
            StrSql = StrSql & ", cliEMail = '" & EMail & "'"
            StrSql = StrSql & ", cliFormInf = " & 0
            StrSql = StrSql & ", cliAgent = " & IdAgent

            StrSql = StrSql & ", cliWebActv = " & CShort(IIf(WebActv, 1, 0))
            StrSql = StrSql & ", cliWebNick = '" & WebNick & "'"
            StrSql = StrSql & ", cliWebPSW = '" & WebPsw & "'"

            StrSql = StrSql & " WHERE cliID = " & ID & " ;"
            db.Update_ID(StrSql)
        End If
        RefreshDataSet(TAULA_ID)
        For i As Short = 0 To 4
            Dim combo As ComboBox = Nothing
            If IsLoadForm("frmPubli") Then
                combo = frmPubli.ComboClient
                OmpleCombo(combo, TAULA_ID, TotsCap.CAP)
                combo.SelectedValue = ID
                OmpleCombo(frmPubli.ComboGridClient, TAULA_ID, TotsCap.CAP)
            End If
        Next i

        LockedRecord()
        blnNouRecord = False
        Me.gridDades.Focus()
    End Sub

    Private Sub DeleteRecord()
        If MsgBox("Segur que vols borrar permanentment aquest Client?", MsgBoxStyle.YesNo, "Atenció") = MsgBoxResult.No Then Exit Sub

        If buscarDependencies(TAULA_ID, Me.lbID.Text) = True Then Exit Sub
        Dim db As New MSC.db.clsDBS
        Dim sCmd As String = "DELETE FROM clients WHERE cliID = " & Me.lbID.Text & " ;"

        db.Delete_ID(sCmd)
        Me.gridDades.Rows.RemoveAt(lbPosition.Text)
    End Sub

    Private Sub CloseForm()
        If Me.cmdSalvar.Enabled Then
            If MsgBox("Vols salvar les modificacions?", vbOKCancel) = vbOK Then SaveRecord()
        End If
        MyAPP.CloseSesionClient(MyAPP.IDSesion_Client, "Clients")
    End Sub

#End Region

    Private Sub txtZip_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtZip.KeyPress, txtTelf.KeyPress, txtFax.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        If KeyAscii < Asc("0") Or KeyAscii > Asc("9") Then If KeyAscii <> 8 Then KeyAscii = 0
        e.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            e.Handled = True
        End If

    End Sub

    Private Sub lbEMail_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbEMail.LinkClicked
        If Len(txtEMail.Text) > 0 Then
            Try
                Call Shell(txtEMail.Text) 'enviarEmail(Me.txtEMail.Text)
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub Changed()
        If blEnable = True Then Me.cmdSalvar.Enabled = True : mnuSave.Enabled = True
    End Sub

    Private Sub ComboProducte_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboProducte.KeyPress, ComboAgents.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub ComboProducte_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboProducte.TextChanged, ComboAgents.TextChanged
        Changed()
    End Sub

    Private Sub cmdNif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNif.Click
        Dim NumDNI As String
        On Error Resume Next
        NumDNI = InputBox("Entri el DNI al qual vol trobar la lletra", "Buscar Lletra del NIF")
        If Len(NumDNI) = 0 Then Exit Sub
        MsgBox("la lletra del DNI correspon a " & LletraNif(NumDNI) & " .")

    End Sub

    Private Sub lbProducte_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbProducte.LinkClicked
        Try
            frmMantProductes.Show(Me)
        Catch ex As Exception
            frmMantProductes.WindowState = FormWindowState.Normal
        End Try        
        frmMantProductes.establirRecordset("producNom = '" & Me.ComboProducte.Text & "'")
    End Sub

    Private Sub lbAgent_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbAgent.LinkClicked
        Try
            frmMantComercial.Show(Me)
        Catch ex As Exception
            frmMantComercial.WindowState = FormWindowState.Normal
        End Try        
        frmMantComercial.establirRecordset("agentNom = '" & Me.ComboAgents.Text & "'")
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

    Private Sub mnuRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRefresh.Click
        establirRecordset()
    End Sub

    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub

    Private Sub chkActvWeb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkActvWeb.CheckedChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ColumnActiveWeb").Value = chkActvWeb.Checked
            Changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub gridDades_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridDades.CurrentCellChanged
        Try
            Me.lbID.Text = gridDades.CurrentRow.Cells(0).Value
            Me.txtNom.Text = gridDades.CurrentRow.Cells(1).Value
            Me.txtNomFisc.Text = gridDades.CurrentRow.Cells(2).Value
            Me.txtNif.Text = gridDades.CurrentRow.Cells(3).Value
            Me.txtNomContacte.Text = gridDades.CurrentRow.Cells(4).Value
            Me.ComboProducte.SelectedValue = gridDades.CurrentRow.Cells(5).Value
            Me.ComboAgents.SelectedValue = gridDades.CurrentRow.Cells(6).Value
            Me.txtObserv.Text = gridDades.CurrentRow.Cells(7).Value
            Me.lbDataCrea.Text = CDate(gridDades.CurrentRow.Cells(8).Value).ToString("yyyy-MM-dd HH:mm:ss")

            Me.txtDireccio.Text = gridDades.CurrentRow.Cells(9).Value
            Me.txtCiutat.Text = gridDades.CurrentRow.Cells(10).Value
            Me.txtZip.Text = gridDades.CurrentRow.Cells(11).Value
            Me.txtTelf.Text = gridDades.CurrentRow.Cells(12).Value
            Me.txtFax.Text = gridDades.CurrentRow.Cells(13).Value
            Me.txtEMail.Text = gridDades.CurrentRow.Cells(14).Value

            Me.chkActvWeb.Checked = CBool(gridDades.CurrentRow.Cells(15).Value)
            Me.txtNickWeb.Text = gridDades.CurrentRow.Cells(16).Value
            Me.txtPswWeb.Text = gridDades.CurrentRow.Cells(17).Value

            Me.lbPosition.Text = Me.gridDades.CurrentRow.Index + 1
            Me.cmdSalvar.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtBuscar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.GotFocus
        txtBuscar.Text = ""
    End Sub

    Private Sub txtBuscar_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuscar.KeyUp
        If e.KeyCode = Keys.Enter Then FindRecord()
    End Sub

    Private Sub ToolStripTextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.LostFocus
        FindRecord()
    End Sub

    Private Sub PerNomToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PerNomToolStripMenuItem.Click
        For i As Integer = 0 To OptionBuscar.DropDownItems.Count - 1
            CType(OptionBuscar.DropDownItems(i), ToolStripMenuItem).Checked = False
        Next
        CType(sender, ToolStripMenuItem).Checked = True
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
            Changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtNomFisc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNomFisc.TextChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ColumnNFisc").Value = TractarStrings(txtNomFisc.Text, True)
            Changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtNif_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNif.TextChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ColumnNIF").Value = TractarStrings(txtNif.Text, True)
            Changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtNomContacte_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNomContacte.TextChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ColumnContact").Value = TractarStrings(txtNomContacte.Text, True)
            Changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ComboProducte_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboProducte.SelectedIndexChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ColumnProducte").Value = ComboProducte.SelectedValue
            Changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ComboAgents_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboAgents.SelectedIndexChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ColumnAgent").Value = ComboAgents.SelectedValue
            Changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtObserv_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtObserv.TextChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ColumnObserv").Value = TractarStrings(txtObserv.Text, True)
            Changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtDireccio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDireccio.TextChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ColumnAdreca").Value = TractarStrings(txtDireccio.Text, True)
            Changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtCiutat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCiutat.TextChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ColumnPoblacio").Value = TractarStrings(txtCiutat.Text, True)
            Changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtZip_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtZip.TextChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ColumnCP").Value = TractarStrings(txtZip.Text, True)
            Changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtTelf_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTelf.TextChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ColumnTelf").Value = TractarStrings(txtTelf.Text, True)
            Changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtFax_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFax.TextChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ColumnFax").Value = TractarStrings(txtFax.Text, True)
            Changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtEMail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEMail.TextChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ColumnMail").Value = TractarStrings(txtEMail.Text, True)
            Changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtNickWeb_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNickWeb.TextChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ColumnNick").Value = TractarStrings(txtNickWeb.Text, True)
            Changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtPswWeb_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPswWeb.TextChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ColumnPasword").Value = TractarStrings(txtPswWeb.Text, True)
            Changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TabControlMesInfo_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TabControlMesInfo.MouseUp
        If TabControlMesInfo.SelectedIndex = 1 Then
            Dim db As New MSC.db.clsDBS
            Dim StrSql As String = "SELECT falcID, falcNomFalca FROM `falques` where falcCientID =" & Me.lbID.Text
            Dim dt As DataTable = db.getTable(StrSql)
            Me.DataGridViewAnuncis.DataSource = dt : DataGridViewAnuncis.Columns(1).HeaderText = "Nom ( " & dt.Rows.Count & " registres) "
        End If
    End Sub

    Private Sub Combo_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboProducte.KeyUp, ComboAgents.KeyUp
        Select Case e.KeyCode
            Case Keys.Left, Keys.Right, Keys.Up, Keys.Down
                Return
        End Select
        Dim MyComboBox As ComboBox = CType(sender, ComboBox)
        Dim Origen As TAULES_DBS

        Select Case MyComboBox.Name
            Case "ComboProducte" : Origen = TAULES_DBS.TAULA_PRODUCTES
            Case "ComboAgents" : Origen = TAULES_DBS.TAULA_AGENTS_COMERCIALS
        End Select
        refreshComboBoxKeyUp(MyComboBox, Origen, TotsCap.CAP)

    End Sub

End Class