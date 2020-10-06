Option Strict Off
Option Explicit On
Imports System.Drawing.Drawing2D
Public Class frmAudios
    Dim blEnable As Boolean
    Dim blnNouRecord As Boolean
    Dim IsSaving As Boolean = False

    Dim NomAudio As String
    Dim ID_Audio As Integer
    Dim PathAudio As String
    Dim _bpm As Misc.BPMCounter = New Misc.BPMCounter(20, 44100)


    Public Sub EstablirTaula(ByVal my_NomAudio As String)
        'carrègar pantalla de la taula

        ID_Audio = getIDlistAudioUser(my_NomAudio)

        NomAudio = my_NomAudio
        'Establir el path dels fitxers
        PathAudio = Params.PathAudioUser
        pic_logo.Image = frmMain.imgListMnu.Images(getLogoAudioUser(ID_Audio))
        Me.Show()
    End Sub


    Private Sub CloseForm()
        If Me.cmdSalvar.Enabled Then
            If MetroFramework.MetroMessageBox.Show(Me, MSG_SAVE_DADES, MSG_ATENCIO, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, 100) = DialogResult.OK Then SaveRecord()
        End If
        If Bass.BASS_ChannelIsActive(StreamHandlePlay) Then Call Bass.BASS_StreamFree(StreamHandlePlay)
        MyAPP.CloseSesionClient(MyAPP.IDSesion_Client, NomAudio)
    End Sub

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
        Me.txtNom.Text = ""
        Me.ComboEstil.SelectedValue = 0
        Me.ComboSubj.SelectedValue = 0
        Me.chkActive.Checked = False
        Me.lbDurada.Text = "00:00:00"
        Me.lbUltimaRadi.Text = ""
        Me.txtRitme.Text = 0
    End Sub

    Private Sub LockedRecord(Optional ByVal saved As Boolean = False)
        If Me.cmdSalvar.Enabled = True And saved = False Then
            If MetroFramework.MetroMessageBox.Show(Me, MSG_SAVE_DADES, MSG_ATENCIO, MessageBoxButtons.OKCancel, MessageBoxIcon.Information, 100) = DialogResult.OK Then SaveRecord()
        End If
        blEnable = Not blEnable
        If blEnable = False Then blnNouRecord = False
        Me.txtNom.Enabled = blEnable
        Me.ComboEstil.Enabled = blEnable
        Me.ComboSubj.Enabled = blEnable
        Me.chkActive.Enabled = blEnable
        Me.cmdBorrar.Enabled = blEnable
        Me.lbRitme.Enabled = blEnable
        Me.mnuDel.Enabled = blEnable
        mnuEditAudio.Enabled = blEnable

        Me.mnuCalcDurada.Enabled = blEnable
        Me.txtRitme.Enabled = blEnable
        Me.lbNou.Visible = False
        If blEnable Then
            Me.cmdBloqueix.Image = Me.picUnLock.Image
        Else
            Me.cmdBloqueix.Image = Me.picLock.Image
            Me.cmdSalvar.Enabled = False
            Me.mnuSave.Enabled = blEnable
        End If
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
                StrSql = "audio_id = " & txtBuscar.Text.Trim
            Case Buscar.BUSCAR_NOM
                StrSql = "audio_nom LIKE '%" & txtBuscar.Text.Trim & "%'"
            Case Buscar.BUSCAR_TOTS
                StrSql = "audio_nom LIKE '%" & txtBuscar.Text.Trim & "%' OR audio_id = " & txtBuscar.Text.Trim
        End Select

        establirRecordset(StrSql)
    End Sub

    Private Sub OpcionsBuscar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PerIDToolStripMenuItem.Click, PerNomToolStripMenuItem.Click, QualsevolToolStripMenuItem.Click
        For i As Integer = 0 To optionBuscar.DropDownItems.Count - 1
            CType(optionBuscar.DropDownItems(i), ToolStripMenuItem).Checked = False
        Next
        CType(sender, ToolStripMenuItem).Checked = True
    End Sub

    Private Sub txtNom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNom.TextChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ColumnNom").Value = AddSlashes(txtNom.Text)
            Changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub lstRecord_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        FindRecord()
    End Sub

    Private Sub frmMant_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        setLanguageForm()
        If My.Settings.TXT_CAPITALIZE Then Me.txtNom.CharacterCasing = CharacterCasing.Upper


        If Not frmMain.NoLoadRs Then establirRecordset()
        Dim UsrTipus As Integer = Usuari.UsrTipus
        'Me.cmdBloqueix.Enabled = IIf(UsrTipus > NivellUsers.USR_CONVIDAT, True, False)
        'Me.mnuModif.Enabled = cmdBloqueix.Enabled
        Me.cmdNou.Enabled = IIf(UsrTipus > NivellUsers.USR_CONVIDAT, True, False)
        Me.cmdNou.Visible = frmMain.VisibleNew
        mnuNew.Enabled = IIf(UsrTipus > NivellUsers.USR_CONVIDAT, True, False)
        Me.mnuNew.Visible = frmMain.VisibleNew

        Me.ClientSize = New Size(frm_sice(0), frm_sice(1))

        PathAudio = Params.PathAudioUser
        _bpm.BPMHistorySize = 8
        _bpm.MinBPM = 30
        _bpm.MaxBPM = 180
    End Sub

    Public Sub setLanguageForm()
        lang.StrForm = Me.Name

        Me.chkActive.Text = lang.getText("LABEL_ACTIVA", True) '"Activa"
        Me.Label4.Text = lang.getText("LABEL_ULT_RADIACIO", True) '"Última radiació"
        Me.Label3.Text = lang.getText("HEADERTEXT_DURADA", True) '"Durada"		
        Me.lbClasSubj.Text = lang.getText("LABEL_CLAS_SUBJ", True) '"Clas. Subjectiva"
        Me.lbEstil.Text = lang.getText("HEADERTEXT_ESTIL", True) '"Estil"
        Me.Label2.Text = lang.getText("LABEL_NOM", True) & ":" '"Nom:"
        'Me.cmdExit.Text = "Button1"
        Me.Label1.Text = lang.getText("LABEL_IDENTIFICADOR", True) & ":" '"Identificador:"
        Me.lbNou.Text = lang.getText("LABEL_NEW_UPPER", True) '"NOU"
        'Me.MenuStrip1.Text = "MenuStrip1"
        Me.ProgarmaToolStripMenuItem.Text = lang.getText("LABEL_PROGRAMA", True) '"Programa"
        Me.mnuExit.Text = lang.getText("LABEL_EXIT", True) '"Sortir"
        Me.ReproductorToolStripMenuItem.Text = lang.getText("LABEL_REPRODUCTOR", True) '"Reproductor"
        Me.mnuPlay.Text = lang.getText("LABEL_PLAY_PAUSA", True) '"Play/Pausa"
        Me.mnuStop.Text = lang.getText("LABEL_STOP", True) '"Stop"
        Me.mnuCalcDurada.Text = lang.getText("LABEL_CALC_DURADA", True) '"Calcular Durada"
        Me.mnuFinal.Text = lang.getText("LABEL_END_TEMA", True) '"Final Tema"
        Me.EdicióToolStripMenuItem.Text = lang.getText("mnuEdit.Text", True) '"Edició"
        Me.mnuModif.Text = lang.getText("LABEL_MODIFICAR", True) '"Modificar"
        Me.mnuSave.Text = lang.getText("LABEL_SALVAR", True) '"Salvar"
        Me.mnuNew.Text = lang.getText("LABEL_NEW", True) '"Nou"
        Me.mnuDel.Text = lang.getText("LABEL_DELETE", True) '"Borrar"
        Me.mnuEditAudio.Text = lang.getText("mnuEditAudio.Text", True) '"Editar l'àudio"
        Me.mnuBuscar.Text = lang.getText("LABEL_BUSCAR", True) '"Buscar"
        Me.mnuRefresh.Text = lang.getText("LABEL_REFRESCAR", True) '"Refrescar"
        Me.ToolStripMenuItem8.Text = lang.getText("mnu_Help", True) '"Ajuda"
        Me.mnu_Help.Text = lang.getText("mnuRefHelp.Text", True) '"Manual OnLine"
        'Me.ToolStrip1.Text = "ToolStrip1"
        Me.cmdPrimer.Text = lang.getText("LABEL_GOTO_FIRSH", True) '"Primer"
        Me.cmdPrevi.Text = lang.getText("LABEL_GOTO_PREV", True) '"Anterior"
        Me.cmdSeguent.Text = lang.getText("LABEL_GOTO_NEXT", True) '"Següent"
        Me.cmdUltim.Text = lang.getText("LABEL_GOTO_LAST", True) '"Últim"
        lang.getText("LABEL_NEW", True) '"Nou"
        Me.cmdBloqueix.Text = lang.getText("LABEL_EDITAR", True) '"Editar"
        Me.cmdBorrar.Text = lang.getText("LABEL_DELETE", True) '"Borrar"
        Me.cmdSalvar.Text = lang.getText("LABEL_SALVAR", True) '"Salvar"
        Me.cmdRefrescar.Text = lang.getText("LABEL_REFRESCAR", True) '"Refrescar"
        Me.optionBuscar.Text = lang.getText("LABEL_BUSCAR", True) '"Buscar"
        Me.PerIDToolStripMenuItem.Text = lang.getText("mnu_Buscar_ID", True) '"Per ID"
        Me.PerNomToolStripMenuItem.Text = lang.getText("mnu_Buscar_NOM", True) '"Per Nom"
        Me.QualsevolToolStripMenuItem.Text = lang.getText("mnu_Buscar_QUALSEVOL", True) '"Qualsevol"
        Me.mnu_actives.Text = lang.getText("LABEL_ONLY_ACTIVES", True) '"Només actives"
        Me.cmdSortir.Text = lang.getText("LABEL_EXIT", True) '"Sortir"
        Me.lbRitme.Text = lang.getText("HEADERTEXT_RITME", True) '"Ritme"
        Me.ColumnID.HeaderText = lang.getText("HEADERTEXT_ID", True) '"ID"
        Me.ColumnNom.HeaderText = lang.getText("LABEL_NOM", True) '"Nom"
        Me.ColumnEstil.HeaderText = lang.getText("HEADERTEXT_ESTIL", True) '"Estil"
        Me.ColumnSubj.HeaderText = lang.getText("HEADERTEXT_SUBJECT", True) '"Subject"		
        Me.ColumnActiva.HeaderText = lang.getText("LABEL_ACTIVA", True) '"Activa"
        Me.ColumnDurada.HeaderText = lang.getText("HEADERTEXT_DURADA", True) '"Durada"
        Me.ColumnRitme.HeaderText = lang.getText("HEADERTEXT_RITME", True) '"Ritme"
        Me.ColumnDataRadi.HeaderText = lang.getText("LABEL_DATA_RADIACIO", True) '"Data Radiació"
        'Me.ToolStrip2.Text = "ToolStrip2"
        Me.lbAtencio.Text = lang.getText("LABEL_NO_EXIST_FILE", True) '"No existeix el fitxer"
        Me.cmdPlay.Text = lang.getText("LABEL_PLAY_PAUSA", True) '"Play/Pausa"
        Me.cmdStop.Text = lang.getText("LABEL_STOP", True) '"Stop"
        'Me.Text = lang.getText("Text") '"Manteniment de" ...
        Dim asa As String = lang.getText("TEXT")
        Me.Text = String.Format(lang.getText("TEXT"), NomAudio)

        Dim Cmb As New combo
        Cmb.OmpleCombo(ComboEstil, TAULES_DBS.TAULA_ESTILS, TotsCap.CAP) : ComboEstil.SelectedValue = 0
        Cmb.OmpleCombo(Me.ColumnEstil, TAULES_DBS.TAULA_ESTILS, TotsCap.CAP) : ComboEstil.SelectedValue = 0
        Cmb.OmpleCombo(ComboSubj, TAULES_DBS.TAULA_SUBJECTIV, TotsCap.CAP) : ComboSubj.SelectedValue = 0
        Cmb.OmpleCombo(Me.ColumnSubj, TAULES_DBS.TAULA_SUBJECTIV, TotsCap.CAP) : ComboSubj.SelectedValue = 0
    End Sub

#End Region
    Private Sub SaveRecord()
        If Not MyAPP.PermisPerContinuar() Then MetroFramework.MetroMessageBox.Show(Me, MSG_SERVER_CLOSE, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Stop, 100) : Me.Close()
        If MetroFramework.MetroMessageBox.Show(Me, MSG_CONFIRM_SAVE_DADES, MSG_ATENCIO, MessageBoxButtons.YesNo, MessageBoxIcon.Question, 100) = DialogResult.No Then Exit Sub

        If Len(Me.txtNom.Text) = 0 Then Exit Sub
        IsSaving = True
        Dim Nom As String = AddSlashes(Me.txtNom.Text)
        Dim ID As Integer = Me.lbID.Text
        Dim Durada As String = Me.lbDurada.Text
        Dim Activa As Boolean = Me.chkActive.Checked
        Dim Estil As Short = Me.ComboEstil.SelectedValue
        Dim Subj As Short = Me.ComboSubj.SelectedValue
        Dim Ritme As Short = Me.txtRitme.Text
        Dim db As New MSC.dbs(Cloud)
        Dim sCmd As String
        If blnNouRecord = True Then
            sCmd = "INSERT INTO audios_params (audio_nom,listaudio_id, audio_actv, audio_ritme, audio_durada"
            sCmd = sCmd & ", audio_style, audio_subj)"
            sCmd = sCmd & " VALUES "
            sCmd = sCmd & " ( '" & Nom & "'"
            sCmd = sCmd & ", " & ID_Audio
            sCmd = sCmd & ", " & CShort(IIf(Activa, 1, 0))
            sCmd = sCmd & ", " & Ritme
            sCmd = sCmd & ", '" & Durada & "'"
            sCmd = sCmd & ", " & Estil
            sCmd = sCmd & ", " & Subj
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
            sCmd = "UPDATE audios_params"
            sCmd = sCmd & " SET "
            sCmd = sCmd & " audio_nom = '" & Nom & "'"
            sCmd = sCmd & ", audio_actv = " & CShort(IIf(Activa, 1, 0))
            sCmd = sCmd & ", audio_ritme = " & Ritme
            sCmd = sCmd & ", audio_durada = '" & Durada & "'"
            sCmd = sCmd & ", audio_style = " & Estil
            sCmd = sCmd & ", audio_subj = " & Subj
            sCmd = sCmd & " WHERE audio_id = " & ID & " ;"

            db.Update_ID(sCmd)
        End If

        db = Nothing
        IsSaving = False
        LockedRecord(True)
        blnNouRecord = False
        Me.gridDades.Focus()
    End Sub

    Private Sub establirRecordset(Optional ByVal Condi As String = "")
        System.Windows.Forms.Cursor.Current = Cursors.AppStarting
        Dim StrSql As String = "SELECT audio_id , audio_nom, audio_style, audio_subj, audio_actv, audio_durada, audio_ritme, audio_dataradiacio FROM audios_params"
        If Condi.Length > 0 Then
            StrSql = StrSql & " WHERE " & Condi & "  AND listaudio_id=" & ID_Audio & ";"
        Else
            StrSql = StrSql & " WHERE listaudio_id=" & ID_Audio & ";"
        End If
        Dim db As New MSC.dbs(Cloud)

        Dim rs As DataTable = db.getTable(StrSql)
        gridDades.DataSource = rs
        Me.lbRecCount.Text = rs.Rows.Count
        gridDades.Focus()
        If rs.Rows.Count = 0 Then MetroFramework.MetroMessageBox.Show(Me, MSG_NO_ITEM_FOR_CONDITION, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, 100)
        cmdBloqueix.Enabled = IIf(rs.Rows.Count And Usuari.UsrTipus > NivellUsers.USR_CONVIDAT, True, False)
        Me.mnuModif.Enabled = cmdBloqueix.Enabled
        System.Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

    Private Sub DeleteRecord()
        If blnNouRecord = True Then
            LockedRecord(True)
            NetejaPantalla()
            gridDades.AllowUserToAddRows = False
            Exit Sub
        End If

        Dim MsgTxt As String = MSG_CONFIRM_DELETE_DADES
        If gridDades.SelectedRows.Count > 1 Then MsgTxt = String.Format(MSG_CONFIRM_DELETE_NUM_DADES, gridDades.SelectedRows.Count)
        If MetroFramework.MetroMessageBox.Show(Me, MsgTxt, MSG_ATENCIO, MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, 100) = DialogResult.Cancel Then Exit Sub


        Dim db As New MSC.dbs(Cloud)
        Dim StrSql As String = ""
        Dim Fitxer As String

        db.IniTransaction()
        For i As Short = 0 To gridDades.SelectedRows.Count - 1
            'Borrar dbs
            Dim ID As String = gridDades.SelectedRows(i).Cells("ColumnID").Value.ToString
            StrSql = "DELETE FROM audios_params WHERE audio_id=" & ID & " ;"
            db.Delete_ID(StrSql)
            addCtlRadi(0, CShort(Tipus_Play.CTL_SQL), 0, "00:00:00", 0, 0, Usuari.UsrID, StrSql, 0, False)
            'Borrar fitxer 
            Fitxer = PathAudio & ID.ToString & ".mp3"
            If IO.File.Exists(Fitxer) Then
                Try
                    IO.File.Delete(Fitxer)
                Catch ex As Exception
                    MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_DELETE_FILE, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
                End Try
            End If
        Next
        db.EndTransaction()

        'Borrar llistat   
        lbRecCount.Text = CInt(lbRecCount.Text) - gridDades.SelectedRows.Count
        gridDades.AllowUserToDeleteRows = True
        For Each selectedrow As DataGridViewRow In gridDades.SelectedRows
            gridDades.Rows.Remove(selectedrow)
        Next
        gridDades.AllowUserToDeleteRows = False
        RefreshDataSet(TAULES_DBS.TAULA_AUDIO_USERS)

    End Sub

    Private Sub Changed()
        If blEnable = True Then Me.cmdSalvar.Enabled = True : Me.mnuSave.Enabled = True
    End Sub

    Private Sub chkActive_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkActive.CheckedChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ColumnActiva").Value = chkActive.Checked
            Changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ComboBackup_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboEstil.KeyPress, ComboSubj.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub ComboEstil_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboEstil.SelectedIndexChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ColumnEstil").Value = ComboEstil.SelectedValue
            Changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub lbEstil_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbEstil.LinkClicked
        Dim FrmChild As New frmMantEstil
        Try
            FrmChild.IniTable()
            If ComboEstil.SelectedValue > 0 Then FrmChild.establirRecordset(" estil_nom = '" & Me.ComboEstil.Text & "'")
            If FrmChild.ShowDialog = DialogResult.OK Then
                Dim Cmb As New combo
                Cmb.OmpleCombo(ComboEstil, TAULES_DBS.TAULA_ESTILS, TotsCap.CAP)
                ComboEstil.SelectedValue = FrmChild.ID
            End If
        Catch ex As Exception
        End Try
        FrmChild = Nothing

    End Sub

    Private Sub lbClasSubj_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbClasSubj.LinkClicked
        Dim FrmChild As New frmMantSubject
        Try
            FrmChild.IniTable()
            If ComboSubj.SelectedValue > 0 Then FrmChild.establirRecordset(" subj_nom = '" & Me.ComboSubj.Text & "'")
            If FrmChild.ShowDialog = DialogResult.OK Then
                Dim Cmb As New combo
                Cmb.OmpleCombo(ComboSubj, TAULES_DBS.TAULA_SUBJECTIV, TotsCap.CAP)
                ComboSubj.SelectedValue = FrmChild.ID
            End If
        Catch ex As Exception
        End Try
        FrmChild = Nothing
    End Sub

    Private Sub txtRitme_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRitme.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        If KeyAscii < Asc("0") Or KeyAscii > Asc("9") Then If KeyAscii <> 8 Then KeyAscii = 0
        e.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
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

    Private Sub cmdNou_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNou.Click
        NewRecord()
    End Sub

    Private Sub cmdBloqueix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBloqueix.Click
        LockedRecord()
    End Sub

    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
        DeleteRecord()
    End Sub

    Private Sub cmdSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalvar.Click
        SaveRecord()
    End Sub

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optionBuscar.Click
        FindRecord()
    End Sub

    Private Sub cmdRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefrescar.Click
        establirRecordset()
    End Sub

    Private Sub cmdSortir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSortir.Click
        Me.Close()
    End Sub

    Private Sub lbRitme_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lbRitme.MouseDown
        _bpm.TapBeat()
        Me.txtRitme.Text = _bpm.TappedBPM.ToString("#00")
    End Sub

    Private Sub txtRitme_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRitme.TextChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ColumnRitme").Value = txtRitme.Text
            Changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        Me.Close()
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

    Private Sub mnuNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNew.Click
        NewRecord()
    End Sub

    Private Sub mnuBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBuscar.Click
        FindRecord()
    End Sub

    Private Sub mnuRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRefresh.Click
        establirRecordset()
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
        Me.lbAtencio.Visible = False
        tmrDetalls.Enabled = False

        Try
            If blEnable = True Then LockedRecord()
            Me.lbID.Text = gridDades.CurrentRow.Cells(0).Value
            Me.txtNom.Text = StripSlashes(gridDades.CurrentRow.Cells(1).Value)
            Me.lbDurada.Text = gridDades.CurrentRow.Cells(5).Value.ToString
            Me.lbUltimaRadi.Text = gridDades.CurrentRow.Cells(7).Value.ToString
            Me.chkActive.Checked = gridDades.CurrentRow.Cells(4).Value
            Me.txtRitme.Text = gridDades.CurrentRow.Cells(6).Value

            Me.ComboEstil.SelectedValue = gridDades.CurrentRow.Cells(2).Value
            Me.ComboSubj.SelectedValue = gridDades.CurrentRow.Cells(3).Value
            Me.lbPosition.Text = gridDades.CurrentRow.Index + 1
            tmrDetalls.Enabled = True
        Catch ex As Exception
            Me.lbID.Text = 0
            Me.txtNom.Text = ""
            Me.lbDurada.Text = "00:00:00"
            Me.lbUltimaRadi.Text = ""
            Me.chkActive.Checked = False
            Me.txtRitme.Text = "0"

            Me.ComboEstil.SelectedValue = 0
            Me.ComboSubj.SelectedValue = 0
            Me.lbPosition.Text = 0
        End Try

        Me.cmdSalvar.Enabled = False
    End Sub

    Private Function FindAfectatRow() As Integer
        If blnNouRecord Then
            Return gridDades.NewRowIndex
        Else
            Return gridDades.CurrentRow.Index
        End If
    End Function

    Private Sub ComboSubj_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboSubj.SelectedIndexChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ColumnSubj").Value = ComboSubj.SelectedValue
            Changed()
        Catch ex As Exception
        End Try
    End Sub

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
            Dim strPathFitxer As String = PathAudio & Me.lbID.Text & ".mp3"
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

    Private Sub PauseFitxer()
        If isActive = BASSActive.BASS_ACTIVE_PLAYING Then Bass.BASS_ChannelPause(StreamHandlePlay)
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

    Private Sub mnuPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPlay.Click, mnuStop.Click, mnuCalcDurada.Click, mnuFinal.Click

        Select Case CType(sender, ToolStripMenuItem).Tag
            Case 1 : PlayFitxer()
            Case 2 : stopFitxer()
            Case 3
                Dim len As Long = Bass.BASS_ChannelGetLength(StreamHandlePlay)
                Me.lbDurada.Text = TimeSerial(0, 0, Bass.BASS_ChannelBytes2Seconds(StreamHandlePlay, len))
                Dim RowID As Integer = FindAfectatRow()
                Me.gridDades.Rows(RowID).Cells(18).Value = lbDurada.Text
                Changed()
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

        Dim strPathFitxer As String = PathAudio & Me.lbID.Text & ".mp3"
        Me.lbAtencio.Visible = Not IO.File.Exists(strPathFitxer)
    End Sub

    Private Sub Combo_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles _
        ComboEstil.KeyUp, ComboSubj.KeyUp
        Select Case e.KeyCode
            Case Keys.Left, Keys.Right, Keys.Up, Keys.Down
                Return
        End Select
        Dim MyComboBox As ComboBox = CType(sender, ComboBox)
        Dim Origen As TAULES_DBS

        Select Case MyComboBox.Name
            Case "ComboEstil" : Origen = TAULES_DBS.TAULA_ESTILS
            Case "ComboSubj" : Origen = TAULES_DBS.TAULA_SUBJECTIV
        End Select
        refreshComboBoxKeyUp(MyComboBox, Origen, TotsCap.CAP)
    End Sub

    Private Sub Combo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboEstil.LostFocus, ComboSubj.LostFocus
        Dim MyComboBox As ComboBox = CType(sender, ComboBox)
        Dim ID As Integer = MyComboBox.SelectedValue
        Dim Origen As TAULES_DBS
        Select Case MyComboBox.Name
            Case "ComboEstil" : Origen = TAULES_DBS.TAULA_ESTILS
            Case "ComboSubj" : Origen = TAULES_DBS.TAULA_SUBJECTIV
        End Select
        Dim Cmb As New combo
        Cmb.OmpleCombo(MyComboBox, Origen, TotsCap.CAP)
        MyComboBox.SelectedValue = ID
    End Sub

    Private Sub mnuEditAudio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditAudio.Click

        Bass.BASS_ChannelStop(StreamHandlePlay)
        Bass.BASS_StreamFree(StreamHandlePlay)
        If ProgEditAudio.Length > 0 Then
            Dim PathFitxer As String = ""
            For i As Integer = 0 To gridDades.SelectedRows.Count - 1
                Dim tempPath As String = PathAudio & gridDades.SelectedRows(i).Cells(0).Value & ".mp3"
                If IO.File.Exists(tempPath) Then
                    PathFitxer += " " & Chr(34) & tempPath & Chr(34)
                End If
            Next
            If PathFitxer.Length < 3 Then Exit Sub

            Dim p As System.Diagnostics.Process = New System.Diagnostics.Process()
            p.StartInfo.Arguments = PathFitxer.Trim
            p.StartInfo.FileName = ProgEditAudio
            Try
                p.Start()
            Catch ex As Exception

                Throw
            End Try
        End If
    End Sub

    Private Sub mnu_Help_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_Help.Click
        Dim Proces As Process = New Process
        Try
            Process.Start(MSC.Help.HELP_GEST_PRODUCCIO_AUDIO_USER.ToString)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub mnu_actives_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_actives.Click
        establirRecordset(" audio_activ=1 AND listaudio_id=" & ID_Audio)
    End Sub

    Private Sub frmPromos_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        Dim FitxerINI As New IniFile
        frm_sice(0) = Me.Width : frm_sice(1) = Me.Height
        FitxerINI.INIWrite(MyAPP.IniFile, "Data Gest", "size", frm_sice(0).ToString & "," & frm_sice(1).ToString)
    End Sub
End Class