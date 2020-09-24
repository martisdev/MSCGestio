Option Strict Off
Option Explicit On

Public Class frmMantBKPAudio
    'TODO: Error de concepte al no ensenyar tots els fitxer que hi han assignats al backup
    Dim Cancelled As Boolean
    Dim blEnable As Boolean
    Dim blnNouRecord As Boolean


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
        Me.lbID.Text = 0
        Me.ComboTipFitx.SelectedIndex = 0
        Me.chkSaved.Checked = False
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


    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FindRecord()
    End Sub

    Private Sub FindRecord()
        If txtBuscar.Text.Length = 0 Or txtBuscar.Text = "Buscar..." Then Exit Sub
        Dim StrSql As String = Me.txtBuscar.Text
        Dim OpcBusca As Short
        For i As Integer = 0 To optionBuscar.DropDownItems.Count - 1
            If CType(optionBuscar.DropDownItems(i), ToolStripMenuItem).Checked = True Then OpcBusca = i : Exit For
        Next i
        If Not IsNumeric(txtBuscar.Text) Then OpcBusca = Buscar.BUSCAR_NOM
        Select Case OpcBusca
            Case Buscar.BUSCAR_ID
                StrSql = "backID = " & txtBuscar.Text
            Case Buscar.BUSCAR_NOM
                StrSql = "backBackup LIKE '%" & txtBuscar.Text.Trim & "%'"
            Case Buscar.BUSCAR_TOTS
                StrSql = "backBackup LIKE '%" & txtBuscar.Text.Trim & "%' OR backID = " & txtBuscar.Text.Trim
        End Select

        establirRecordset(StrSql)
    End Sub

    Private Sub cmdRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefrescar.Click
        establirRecordset()
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Cancelled = True
    End Sub

    Private Sub txtNom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNom.TextChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ColumnNom").Value = TractarStrings(txtNom.Text, True)
            Changed()
        Catch ex As Exception
        End Try

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

        OmpleCombo(ComboTipFitx, TAULES_DBS.TAULA_TIPUS_FITXER, TotsCap.CAP)

        If Not frmMain.NoLoadRs Then establirRecordset()

        'Me.cmdBloqueix.Enabled = IIf(Usuari.UsrTipus > NivellUsers.USR_CONVIDAT, True, False)
        Me.cmdNou.Enabled = IIf(Usuari.UsrTipus > NivellUsers.USR_CONVIDAT, True, False)
        Me.mnuNew.Visible = Me.cmdNou.Visible

    End Sub

#End Region
#Region " VarTables "
    'Seccio variable segons taula-----------------------------------------

    Private Sub ShowValuesID()
        Try
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
        Windows.Forms.Cursor.Current = Cursors.AppStarting
        Dim StrSql As String = "SELECT * FROM backups"
        If Len(ValStr) > 0 Then StrSql = StrSql & " WHERE " & ValStr
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
        If Not MyAPP.PermisPerContinuar Then MsgBox("El servidor ha tancat la pantalla", MsgBoxStyle.Exclamation, "Atenció") : Me.Close()

        If MsgBox("Segur que vols salvar les dades", vbOKCancel, "Atenció") = vbCancel Then Exit Sub

        If Len(Me.txtNom.Text) = 0 Then Exit Sub
        Dim Nom As String = TractarStrings(Me.txtNom.Text)
        Dim ID As Integer = Me.lbID.Text
        Dim TipFitxer As Short = Me.ComboTipFitx.SelectedIndex
        Dim blSaved As Boolean = Me.chkSaved.Checked
        Dim db As New MSC.db.clsDBS
        Dim StrSql As String
        If blnNouRecord = True Then

            StrSql = "INSERT INTO backups (backBackup, backTipFitx, backSaved)"
            StrSql = StrSql & " VALUES "
            StrSql = StrSql & " ( '" & Nom & "'"
            StrSql = StrSql & " , " & TipFitxer
            StrSql = StrSql & ", " & CShort(IIf(blSaved, 1, 0))
            StrSql = StrSql & ");"

            ID = db.New_ID(StrSql)
            Me.gridDades.Rows(gridDades.NewRowIndex).Cells(0).Value = ID
            gridDades.EndEdit()
            gridDades.AllowUserToAddRows = False
        Else
            StrSql = "UPDATE backups"
            StrSql = StrSql & " SET "
            StrSql = StrSql & " backBackup = '" & Nom & "'"            
            StrSql = StrSql & ", backTipFitx = " & TipFitxer
            StrSql = StrSql & ", backSaved = " & CShort(IIf(blSaved, 1, 0)) & "' WHERE backID = " & ID
            db.Update_ID(StrSql)
        End If
        RefreshDataSet(TAULES_DBS.TAULA_BACKUPS)
        For i As Short = 0 To 5
            Dim combo As ComboBox = Nothing
            Select Case i
                Case 0 : If IsLoadForm("frmPubli") Then combo = frmPubli.ComboBackup
                Case 1 : If IsLoadForm("frmTemes") Then combo = frmTemes.ComboBackup
                Case 2 : If IsLoadForm("frmImport") Then combo = frmImport.cbBackup
                Case 3 : If IsLoadForm("frmjingels") Then combo = frmJingels.ComboBackup
                Case 4 : If IsLoadForm("frmPromos") Then combo = frmPromos.ComboBackup
                Case 5 : If IsLoadForm("frmAudio") Then combo = frmAudio.ComboBackup
            End Select
            If combo IsNot Nothing Then
                OmpleCombo(combo, TAULES_DBS.TAULA_BACKUPS, TotsCap.CAP)
                combo.SelectedValue = ID
            End If
        Next i

        LockedRecord()
        blnNouRecord = False
        gridDades.Focus()
    End Sub

    Private Sub DeleteRecord()
        If MsgBox("Segur que vols borrar permanentment aquest ítem?", vbYesNo, "Atenció") = vbNo Then Exit Sub
        'Buscar dependènes a Discos i temes i borrar equivalències
        If buscarDependencies(TAULES_DBS.TAULA_BACKUPS, Me.lbID.Text) = True Then Exit Sub
        Dim StrSql As String = "DELETE FROM backups WHERE backID=" & Me.lbID.Text
        Dim db As New MSC.db.clsDBS
        db.Delete_ID(StrSql)
        Me.gridDades.Rows.RemoveAt(lbPosition.Text)

    End Sub

    Private Sub CloseForm()
        If Me.cmdSalvar.Enabled Then
            If MsgBox("Vols salvar les modificacions?", vbOKCancel) = vbOK Then SaveRecord()
        End If

        MyAPP.CloseSesionClient(MyAPP.IDSesion_Client, "Backups Audio")
    End Sub

#End Region

    Private Sub cmdPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPath.Click
        Me.txtPath.Text = BrowseForFolder(Me.Handle, "Selecciona un directori")
        Me.cmdSalvarFitxers.Enabled = IIf(Len(txtPath.Text) > 2, True, False)
    End Sub

    Private Sub cmdAllTrack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAllTrack.Click
        Windows.Forms.Cursor.Current = Cursors.AppStarting
        For i As Short = 0 To Me.lstFitxers.Items.Count - 1
            Dim NomFitxer As String = lstFitxers.Items(i).Tag
            lstFitxers.Items.Item(i).Checked = IO.File.Exists(NomFitxer)
        Next
        Windows.Forms.Cursor.Current = Cursors.Default
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
        Windows.Forms.Cursor.Current = Cursors.AppStarting
        Dim db As New MSC.db.clsDBS
        Dim StrSql As String = ""
        Select Case Me.ComboTipFitx.SelectedValue
            Case 0
                '<CAP>
                Windows.Forms.Cursor.Current = Cursors.Default
                Exit Sub
            Case Tipus_Fitxers.FITXER_MUSICA
                path = Params.PathMusica & "\"
                getVarTables(TAULES_DBS.TAULA_TEMES, NomTaula, ColumID, ColumNom)
                ColumBackupID = "temBackupID"
            Case Tipus_Fitxers.FITXER_PROMOS
                path = Params.PathPromos & "\"
                getVarTables(TAULES_DBS.TAULA_PROMOCIONS, NomTaula, ColumID, ColumNom)
                ColumBackupID = "proBackupID"
            Case Tipus_Fitxers.FITXER_JINGELS
                path = Params.PathJingels & "\"
                getVarTables(TAULES_DBS.TAULA_JINGELS, NomTaula, ColumID, ColumNom)
                ColumBackupID = "jingBackupID"
            Case Tipus_Fitxers.FITXER_PUBLICITAT
                path = Params.PathPublicitat & "\"
                getVarTables(TAULES_DBS.TAULA_PUBLICITAT, NomTaula, ColumID, ColumNom)
                ColumBackupID = "falcBackupID"
            Case Tipus_Fitxers.FITXER_PROGRAMA
                path = Params.PathProgrames & "\"
                getVarTables(TAULES_DBS.TAULA_PROGRAMES, NomTaula, ColumID, ColumNom)
                ColumBackupID = "prgBackupID"
            Case Else
                'Tipus_Fitxers.FITXER_AUDIO_USR
                Dim tipFitxer As Short = Me.ComboTipFitx.SelectedValue
                Dim NomAudio As String = "audio" & (tipFitxer - 100)
                path = Params.PathAudioUser & "\" & NomAudio & "\"
                StrSql = "SELECT audioID,audioNom FROM " & NomAudio & " WHERE audioBackupID=" & Me.lbID.Text & " ORDER BY audioNom"
                taula = db.getTable(strsql)
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

        Me.lbTamany.Text = Strings.Format(TotalSize / 1024, "###,###,###") + "Mb"
        Me.lbNFitxers.Text = FExist & "/" & taula.Rows.Count
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

    Private Sub cmdSalvarFitxers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalvarFitxers.Click
        Windows.Forms.Cursor.Current = Cursors.AppStarting
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

        MsgBox("Còpia de seguretat realitzada", vbInformation)
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

    Private Sub lstFitxers_ItemChecked(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lstFitxers.ItemChecked
        Dim item As System.Windows.Forms.ListViewItem = e.Item
        If item.Checked = True Then
            Dim NomFitxer As String = item.Tag
            If Not IO.File.Exists(NomFitxer) Then
                item.Checked = False
                MsgBox("No existeix el fitxer al disc dur", vbExclamation)
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

    Private Sub txtBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.Click

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

End Class