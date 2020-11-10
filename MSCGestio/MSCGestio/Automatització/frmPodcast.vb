Option Strict Off
Option Explicit On
Imports System.Drawing.Drawing2D
Imports Un4seen.Bass.Misc
Imports System.Net

Public Class frmPodcast
    Dim blEnable As Boolean
    Dim blnNouRecord As Boolean
    Dim PathFitxer As String = ""


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

    Private Sub cmdSortir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSortir.Click
        Me.Close()
    End Sub

    Private Sub cmdRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefrescar.Click
        establirRecordset()
    End Sub

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim tp As Integer = CType(sender, ToolStripMenuItem).Tag

        Dim StrSql As String = "pod_tipusfitxer= " & tp.ToString
        establirRecordset(StrSql)
    End Sub

    Private Sub cmdSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalvar.Click
        SaveRecord()
    End Sub

    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
        DeleteRecord()
    End Sub

    Private Sub cmdBloqueix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBloqueix.Click
        LockedRecord()
    End Sub

    Private Sub cmdNou_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNou.Click
        NewRecord()
    End Sub

    Private Sub cmdEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEnd.Click
        Me.Close()
    End Sub

#End Region

    Sub MnuFindOpcionsClick(sender As Object, e As EventArgs) Handles pendentsDePublicarToolStripMenuItem.Click, mnuFindOpcions.Click, caducadesToolStripMenuItem.Click

        Dim MyMnu As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
        Dim SqlStr As String = ""
        Select Case MyMnu.Tag
            Case 0 '"Actuals"
                SqlStr = "pod_datapubli <= '" & Now.ToString("yyyy-MM-dd HH:mm:ss") & "' AND pod_dataout >= '" & Now.ToString("yyyy-MM-dd") & "' ;"
            Case 1 '"Pendents de publicar"
                SqlStr = "pod_datapubli > '" & Now.ToString("yyyy-MM-dd HH:mm:ss") & "' ;"
            Case 2 ' Caducats
                SqlStr = " pod_dataout < '" & Now.ToString("yyyy-MM-dd") & "' ;"
        End Select
        establirRecordset(SqlStr)
    End Sub

    Friend Sub establirRecordset(Optional ByVal Condi As String = "")
        System.Windows.Forms.Cursor.Current = Cursors.AppStarting

        'Dim StrSql As String = "SELECT * FROM podcasting"
        'If Condi.Length > 0 Then StrSql = StrSql & " WHERE " & Condi

        Dim StrSql As String = ""
        If Me.cmbProgrames.SelectedValue = 0 Then
            'StrSql = "SELECT * FROM podcasting WHERE podcasting.pod_tipusfitxer = 5;"

            StrSql = "SELECT * FROM podcasting ;"
        Else
            StrSql = "SELECT podcasting.pod_id,podcasting.pod_tipusfitxer,podcasting.pod_id_origen,podcasting.pod_durada,podcasting.pod_descrip," &
                "podcasting.pod_datacreacio,podcasting.pod_datapubli,podcasting.pod_dataout, podcasting.pod_file " &
                "FROM podcasting, prg_sessions, programes WHERE podcasting.pod_id_origen= prg_sessions.ses_id " &
                "AND prg_sessions.ses_prg = programes.prg_id AND programes.prg_id = " & cmbProgrames.SelectedValue
        End If

        If Condi.Length > 0 Then StrSql = StrSql & " AND " & Condi
        Dim db As New MSC.dbs(Cloud)
        Me.gridDades.DataSource = db.getTable(StrSql)
        Me.lbRecCount.Text = gridDades.Rows.Count
        db = Nothing
        gridDades.Focus()
        If gridDades.Rows.Count = 0 Then
            'esBorra pantalla            
            txtDecrip.Text = ""
            Me.lbDataCrea.Text = Now.ToString("dd/MM/yyyy HH:mm:ss")
            Me.txtDataPublicacio.Value = Now()
            txtDataOut.Value = Now.AddDays(Cloud.DiesPermanenciaPodcast)
            ComboBoxTipus.SelectedValue = 5
            Me.lbFileName.Text = ""
            Me.lbDurada.Text = "00:00:00"
            'txtHoraOut.Value = New Date(txtDataOut.Value.Year, txtDataOut.Value.Month, txtDataOut.Value.Day, 0, 0, 0)			
            Me.lbID.Text = 0
            MetroFramework.MetroMessageBox.Show(Me, MSG_NO_ITEM_FOR_CONDITION, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
        End If

        cmdBloqueix.Enabled = IIf(gridDades.Rows.Count And Usuari.UsrTipus > NivellUsers.USR_CONVIDAT, True, False)
        Me.mnuModif.Enabled = Me.cmdBloqueix.Enabled
        System.Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

    Private Sub frmPodcast_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If AmbTasquesPendents = True Then
            e.Cancel = True
            WindowState = System.Windows.Forms.FormWindowState.Minimized
        Else
            CloseForm()
        End If
    End Sub

    Private Sub CloseForm()
        If Me.cmdSalvar.Enabled Then
            If MetroFramework.MetroMessageBox.Show(Me, MSG_SAVE_DADES, MSG_ATENCIO, MessageBoxButtons.YesNo, MessageBoxIcon.Question, 100) = DialogResult.Yes Then SaveRecord()
        End If
        DesconnectFTP()
        If Bass.BASS_ChannelIsActive(StreamHandlePlay) Then Call Bass.BASS_StreamFree(StreamHandlePlay)
        MyAPP.CloseSesionClient(MyAPP.IDSesion_Client, DESCRIP_FORM_PODCAST)
        Me.Dispose()
    End Sub

    Private Sub frmPodcast_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setLanguageForm()
        If My.Settings.TXT_CAPITALIZE Then Me.txtDecrip.CharacterCasing = CharacterCasing.Upper
        'Opcions del mnu_buscar (OptionBuscar)
        Dim rstf As DataTable = TipusFitxer(True)
        For i As Integer = 0 To rstf.Rows.Count - 1
            Dim mnuNewOpton As ToolStripMenuItem
            mnuNewOpton = New ToolStripMenuItem
            mnuNewOpton.Text = rstf.Rows(i)("tipFitxNom").ToString
            mnuNewOpton.Tag = rstf.Rows(i)("tipFitxID").ToString
            mnuNewOpton.Visible = True
            OptionBuscar.DropDownItems.Add(mnuNewOpton)
            AddHandler mnuNewOpton.Click, AddressOf cmdBuscar_Click
        Next i


        NoRefresh = False
        refreshFitxers()


        If Not frmMain.NoLoadRs Then establirRecordset()
        Me.ClientSize = New Size(frm_sice(0), frm_sice(1))
        'Me.cmdConnectFTP.visible = (Params.AccesWeb = ConnexioRemota.FTP)
        'Me.cmdDesConnectFTP.Visible =  (Params.AccesWeb = ConnexioRemota.FTP)

    End Sub

    Dim LABEL_LLISTAR As String = ""
    Public Sub setLanguageForm()
        lang.StrForm = Me.Name

        Me.ColumnTipus.HeaderText = lang.getText("LABEL_TIPUS_FITXER", True) '"Tipus Fitxer"

        Me.ColumnDurada.HeaderText = lang.getText("HEADERTEXT_DURADA", True) '"Durada"
        Me.ColumnDataCrea.HeaderText = lang.getText("HEADERTEXT_DATE_CREA", True) '"Data Creació"
        Me.ColumnDescrip.HeaderText = lang.getText("LABEL_DESCRIPCIO", True) '"Descripció"

        'Me.MenuStrip1.Text = "MenuStrip1"
        Me.ProgarmaToolStripMenuItem.Text = lang.getText("LABEL_PROGRAMA", True) '"Programa"
        Me.mnuExit.Text = lang.getText("LABEL_EXIT", True) '"Sortir"
        Me.mnuStop.Text = lang.getText("LABEL_STOP", True) '"Stop"

        Me.EdicióToolStripMenuItem.Text = lang.getText("mnuEdit.Text", True) '"Edició"
        Me.mnuModif.Text = lang.getText("LABEL_MODIFICAR", True) '"Modificar"
        Me.mnuSave.Text = lang.getText("LABEL_SALVAR", True) '"Salvar"
        Me.mnuNew.Text = lang.getText("LABEL_NEW", True) '"Nou"
        Me.mnuDel.Text = lang.getText("LABEL_DELETE", True) '"Borrar"
        Me.mnuEditAudio.Text = lang.getText("mnuEditAudio.Text", True) '"Editar l'àudio"
        Me.ToolStripMenuItem1.Text = lang.getText("mnu_Help", True) '"Ajuda"
        Me.mnu_Help.Text = lang.getText("mnuRefHelp.Text", True) '"Manual OnLine"
        'Me.ToolStrip1.Text = "ToolStrip1"
        Me.cmdPrimer.Text = lang.getText("LABEL_GOTO_FIRSH", True) '"Primer"
        Me.cmdPrevi.Text = lang.getText("LABEL_GOTO_PREV", True) '"Anterior"
        Me.cmdSeguent.Text = lang.getText("LABEL_GOTO_NEXT", True) '"Següent"
        Me.cmdUltim.Text = lang.getText("LABEL_GOTO_LAST", True) '"Últim"
        Me.cmdNou.Text = lang.getText("LABEL_NEW", True) '"Nou"
        Me.cmdBloqueix.Text = lang.getText("LABEL_BLOCK", True) '"Bloquejar"
        Me.cmdBorrar.Text = lang.getText("LABEL_DELETE", True) '"Borrar"
        Me.cmdSalvar.Text = lang.getText("LABEL_SAVE", True) '"Salvar"
        Me.cmdRefrescar.Text = lang.getText("LABEL_REFRESCAR", True) '"Refrescar"
        Me.OptionBuscar.Text = lang.getText("LABEL_BUSCAR", True) '"Buscar"
        Me.mnuFindOpcionsMare.Text = lang.getText("LABEL_OPCIONS", True) '"Opcions"
        Me.cmdSortir.Text = lang.getText("LABEL_EXIT", True) '"Sortir"		
        Me.cmdStop.Text = lang.getText("LABEL_STOP", True) '"Stop"
        Me.Label6.Text = lang.getText("LABEL_DESCRIPCIO", True) '"Descripció:"
        Me.Label4.Text = lang.getText("HEADERTEXT_DURADA", True) & ":" '"Durada:"
        Me.lbNou.Text = lang.getText("LABEL_NEW_UPPER", True) '"NOU"
        Me.Label7.Text = lang.getText("LABEL_ACCEPT_HTML", True) '"accepta HTML"
        Me.ColumnLocalID.HeaderText = lang.getText("HEADERTEXT_ID", True) '"ID"
        Me.ColumnLocalNom.HeaderText = lang.getText("LABEL_NOM", True) '"Nom"
        Me.ColumnLocalPlay.HeaderText = lang.getText("LABEL_PLAY", True) '"Play"
        Me.ColumnFTPPlay.HeaderText = lang.getText("LABEL_PLAY", True) '"Play"
        Me.mnuPlay.Text = lang.getText("LABEL_PLAY_PAUSA", True) '"Play/Pausa"
        Me.cmdPlay.Text = lang.getText("LABEL_PLAY_PAUSA", True) '"Play/Pausa"

        Me.ReproductorToolStripMenuItem.Text = lang.getText("ReproductorToolStripMenuItem.Text") '"Reproductor"		
        Me.ColumnPlayers.HeaderText = lang.getText("ColumnPlayers.HeaderText") '"Players"
        Me.ColumnOrigen.HeaderText = lang.getText("ColumnOrigen.HeaderText") '"Origen"
        Me.ColumnDataPubli.HeaderText = lang.getText("LABEL_DATA_IN_", True) '"Data Publi"
        Me.ColumnDataOut.HeaderText = lang.getText("LABEL_DATA_OUT", True) '"Data Out"		

        Me.mnuCalcDurada.Text = lang.getText("LABEL_CALC_DURADA", True) '"Calcular Durada"
        Me.mnuFinal.Text = lang.getText("mnuFinal.Text") '"Final Tema"



        Me.caducadesToolStripMenuItem.Text = lang.getText("caducadesToolStripMenuItem.Text") '"Caducades"

        'Me.ToolStripLabel2.Text = "ToolStripLabel2"
        'Me.cmdEnd.Text = "Button1"
        Me.Label1.Text = lang.getText("LABEL_IDENTIFICADOR", True) & ":" '"Identificador:"
        Me.Label2.Text = lang.getText("LABEL_TIPUS_FITXER", True) & ":" '"Tipus de fitxer:"
        Me.Label3.Text = lang.getText("LABEL_FITXER", True) & ":" '"Fitxer:"		
        Me.Label5.Text = lang.getText("LABEL_DATA_PUBLICACIO", True) & ":" '"Data Publicacio:"
        Me.Label64.Text = lang.getText("LABEL_DATA_OUT", True) & ":" '"Data Sortida:"				
        Me.chkIN.Text = lang.getText("chkIN.Text") '"Actius"
        Me.Label8.Text = lang.getText("HEADERTEXT_DATE_CREA", True) & ":" '"Data Creació:"
        Me.tabPage1.Text = lang.getText("tabPage1.Text") '"Detall del fitxer"
        Me.tabPageFTP.Text = lang.getText("tabPageFTP.Text") '"Treballs al Servidor"
        'Me.toolStrip2.Text = "toolStrip2"
        Me.lbInfoFTP.Text = lang.getText("lbInfoFTP.Text") '"Informació del Procés"
        Me.ColumnLocalTipus.HeaderText = lang.getText("LABEL_TIPUS", True) '"Tipus"
        Me.ColumnLocalPath.HeaderText = lang.getText("ColumnLocalPath.HeaderText") '"Fitxer"
        Me.ColumnLocalDataIn.HeaderText = lang.getText("LABEL_DATA_IN_", True) '"Data In"
        Me.ColumnLocalDataOut.HeaderText = lang.getText("LABEL_DATA_OUT", True) '"Data Out"
        Me.ColumnLocalSize.HeaderText = lang.getText("ColumnLocalSize.HeaderText") '"kb"		
        Me.ColumnFTPSize.HeaderText = lang.getText("ColumnLocalSize.HeaderText") '"kb"
        Me.label9.Text = lang.getText("label9.Text") '"Fitxers Locals"
        Me.label10.Text = lang.getText("label10.Text") '"Fitxers Remots"
        Me.toolStripFTPBotonera.Text = lang.getText("toolStripFTPBotonera.Text") '"Botons de gestió FTP"
        LABEL_LLISTAR = lang.getText("mnuLlistar.Text")
        Me.mnuLlistar.Text = LABEL_LLISTAR '"Llistar"
        Me.mnuShowAll.Text = lang.getText("LABEL_TOTS", True) '"Tots"
        Me.mnuShowActuals.Text = lang.getText("LABEL_ACTUALS", True) '"Actuals"
        Me.mnuFindOpcions.Text = lang.getText("LABEL_ACTUALS", True) '"Actuals"

        Me.mnuShowPendentPubli.Text = lang.getText("mnuShowPendentPubli.Text") '"Pendents de publicar"
        Me.pendentsDePublicarToolStripMenuItem.Text = mnuShowPendentPubli.Text '"Pendents de publicar"

        Me.mnuShowCaduc.Text = lang.getText("mnuShowCaduc.Text") '"Caducats"
        Me.mnuShowAllRemots.Text = lang.getText("mnuShowAllRemots.Text") '"Tots els remots"
        'Me.cmdConnectFTP.Text = lang.getText("cmdConnectFTP.Text")'"Connectar per FTP"
        'Me.cmdDesConnectFTP.Text = lang.getText("cmdDesConnectFTP.Text")'"Tancar FTP"
        Me.buttonExecTasquestFTP.Text = lang.getText("buttonExecTasquestFTP.Text") '"Executar Tasques"
        Me.ColumnFTPAction.HeaderText = lang.getText("ColumnFTPAction.HeaderText") '"Acció"
        Me.ColumnFTPPath.HeaderText = lang.getText("LABEL_FITXER", True) '"Fitxer"
        lbNomFitxer.Text = lang.getText("lbNomFitxer.Text") & ":" '"Nom Fitxer:"' lang.getText("lbNomFitxer.Text") & ":"'"Nom Fitxer:"
        Me.ColumnLocalNomFitxer.HeaderText = lbNomFitxer.Text

        Me.Text = lang.getText("LABEL_PODCASTING", True) '"PodCasting"					

        Dim Cmb As New combo
        Cmb.OmpleCombo(ComboBoxTipus, TAULES_DBS.TAULA_TIPUS_FITXER, TotsCap.CAP) : ComboBoxTipus.SelectedValue = 0
        Cmb.OmpleCombo(ColumnFTPAction, TAULES_DBS.TAULA_ACCIONS_FTP, TotsCap.NO_ADD)
        Cmb.OmpleCombo(comboboxGeneralTaskServer, TAULES_DBS.TAULA_ACCIONS_FTP, TotsCap.NO_ADD) : comboboxGeneralTaskServer.SelectedValue = 0
        Cmb.OmpleCombo(Me.cmbProgrames, TAULES_DBS.TAULA_PROGRAMES, TotsCap.TOTS) : cmbProgrames.SelectedValue = 0
    End Sub

    Private Sub gridDades_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridDades.CurrentCellChanged
        Try
            Me.lbID.Text = gridDades.CurrentRow.Cells("ColumnID").Value
            ComboBoxTipus.SelectedValue = gridDades.CurrentRow.Cells("ColumnTipus").Value
            cmbFitxer.SelectedValue = gridDades.CurrentRow.Cells("ColumnOrigen").Value
            lbDurada.Text = gridDades.CurrentRow.Cells("ColumnDurada").Value.ToString
            txtDecrip.Text = gridDades.CurrentRow.Cells("ColumnDescrip").Value
            txtDataOut.Value = CDate(gridDades.CurrentRow.Cells("ColumnDataOut").Value)
            'Dim daPu As Date = gridDades.CurrentRow.Cells("ColumnDataPubli").Value
            Me.txtDataPublicacio.Value = CDate(gridDades.CurrentRow.Cells("ColumnDataPubli").Value)
            Me.txtHoraPublicacio.Value = CDate(gridDades.CurrentRow.Cells("ColumnDataPubli").Value)
            Me.lbDataCrea.Text = gridDades.CurrentRow.Cells("ColumnDataCrea").Value.ToString
            Me.lbPosition.Text = gridDades.CurrentRow.Index
            Dim dataCrea As Date = Me.lbDataCrea.Text

            Me.lbFileName.Text = gridDades.CurrentRow.Cells("ColumnFile").Value.ToString 'RemoveInvalidFileNameChars("Nom Programa<>>::" & dataCrea.ToString ("yyyyMMdd"))
            'testRemoteFileExist(Params.DirRemote & "/" & Me.lbID.Text & ".mp3")
            Me.cmdSalvar.Enabled = False : mnuSave.Enabled = False
        Catch ex As Exception
        End Try
    End Sub

    Private Sub refreshFitxers()

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.AppStarting
        cmbFitxer.DataSource = Nothing
        Dim tipFitxer As Short = 5 ' Me.ComboBoxTipus.SelectedValue
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
                StrSql = "SELECT audio_id,audio_nom FROM audios_params WHERE audio_actv=" & Active & " AND listaudio_id=" & tipFitxer - 100 & " ORDER BY audio_nom"
                rs = db.getTable(StrSql)
        End Select
        If rs.Rows.Count = 0 Then
            Dim row As DataRow
            row = rs.NewRow() : row(0) = 0 : row(1) = LIST_NO_DEF : rs.Rows.Add(row)
        End If
        With cmbFitxer
            .DisplayMember = rs.Columns(1).ColumnName
            .ValueMember = rs.Columns(0).ColumnName
            .DataSource = rs
            .SelectedValue = 0
        End With
        db = Nothing
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub ComboBoxTipus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxTipus.SelectedIndexChanged
        lbIdTipus.Text = ComboBoxTipus.SelectedValue
        refreshFitxers()
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ColumnTipus").Value = ComboBoxTipus.SelectedValue
            Changed()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub LockedRecord(Optional ByVal saved As Boolean = False)

        If Me.cmdSalvar.Enabled = True And saved = False Then
            If MetroFramework.MetroMessageBox.Show(Me, MSG_SAVE_DADES, MSG_ATENCIO, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, 100) = DialogResult.OK Then SaveRecord()
        End If
        blEnable = Not blEnable
        If blEnable = False Then blnNouRecord = False
        toolStripFTPBotonera.Enabled = blEnable
        comboboxGeneralTaskServer.Enabled = blEnable
        If gridDades.Rows.Count > 0 Then

            Me.ComboBoxTipus.Enabled = blEnable
            chkIN.Enabled = blEnable
            cmbFitxer.Enabled = blEnable
            txtDataOut.Enabled = blEnable
            txtDataPublicacio.Enabled = blEnable
            txtHoraPublicacio.Enabled = blEnable
            'txtHoraOut.Enabled = blEnable
            txtDecrip.Enabled = blEnable
            toolStripFTPBotonera.Enabled = blEnable
            Me.mnuCalcDurada.Enabled = blEnable
            Me.cmdBorrar.Enabled = blEnable
            Me.lbNou.Visible = False
        End If

        If blEnable Then
            Me.cmdBloqueix.Image = Me.picUnLock.Image
        Else
            Me.cmdBloqueix.Image = Me.picLock.Image
            Me.cmdSalvar.Enabled = False
        End If
    End Sub

    Private Sub NewRecord()
        blnNouRecord = True
        DeSelectAllRowsGrid(gridDades)
        gridDades.AllowUserToAddRows = True
        gridDades.FirstDisplayedScrollingRowIndex = gridDades.NewRowIndex
        Me.gridDades.Rows(gridDades.NewRowIndex).Selected = True
        Me.gridDades.Rows(gridDades.NewRowIndex).Cells(0).Value = 0
        'establir Valors per defecte (automàticament incorporats al datagrid)        
        txtDecrip.Text = ""
        Me.lbDataCrea.Text = Now.ToString("dd/MM/yyyy HH:mm:ss")
        Me.txtDataPublicacio.Value = Now()
        txtDataOut.Value = Now.AddDays(Cloud.DiesPermanenciaPodcast)
        ComboBoxTipus.SelectedValue = 5
        Me.lbFileName.Text = ""
        'txtHoraOut.Value = New Date(txtDataOut.Value.Year, txtDataOut.Value.Month, txtDataOut.Value.Day, 0, 0, 0)

        Me.lbID.Text = 0
        blEnable = False
        LockedRecord()

        Me.lbNou.Visible = True
        cmbFitxer.Focus()
    End Sub



    Private Sub SaveRecord()

        If Not MyAPP.PermisPerContinuar() Then MetroFramework.MetroMessageBox.Show(Me, MSG_SERVER_CLOSE, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Stop, 100) : Me.Close()
        If MetroFramework.MetroMessageBox.Show(Me, MSG_CONFIRM_SAVE_DADES, MSG_ATENCIO, MessageBoxButtons.YesNo, MessageBoxIcon.Question, 100) = DialogResult.No Then Exit Sub
        Dim TipusFitxer As Integer = Me.ComboBoxTipus.SelectedValue 'Tipus_Fitxers.FITXER_PROGRAMA
        Dim id_origen As Integer = Me.cmbFitxer.SelectedValue
        Dim Durada As String = Me.lbDurada.Text
        Dim DataPubli As Date = New DateTime(txtDataPublicacio.Value.Year, txtDataPublicacio.Value.Month, txtDataPublicacio.Value.Day, txtHoraPublicacio.Value.Hour, txtHoraPublicacio.Value.Minute, txtHoraPublicacio.Value.Second) 'txtDataPublicacio.Value
        Dim DataOut As Date = Me.txtDataOut.Value
        Dim Descrip As String = AddSlashes(Me.txtDecrip.Text)

        Dim ID As Integer = Me.lbID.Text
        Dim db As New MSC.dbs(Cloud)
        If blnNouRecord = True Then
            Dim NomFitxer As String = Me.lbFileName.Text
            Dim StrSql As String = "INSERT INTO podcasting (pod_tipusfitxer, pod_id_origen, pod_durada,pod_datacreacio, pod_datapubli, pod_dataout, pod_descrip, pod_file) " &
                "VALUES (" & TipusFitxer & ", " & id_origen & ",'" & Durada & "','" & Now.ToString("yyyy-MM-dd HH:mm:ss") & "','" & DataPubli.ToString("yyyy-MM-dd HH:mm:ss") & "','" & DataOut.ToString("yyyy-MM-dd") & "','" & Descrip & "' ,'" & NomFitxer & "');"
            ID = db.New_ID(StrSql)

            gridDades.AllowUserToAddRows = False
            establirRecordset()
            gridDades.Focus()
            System.Windows.Forms.SendKeys.Send("^{END}")
        Else
            Dim StrSql As String = "UPDATE podcasting SET " &
                " pod_tipusfitxer=" & TipusFitxer &
                ", pod_id_origen=" & id_origen &
                ", pod_durada='" & Durada & "'" &
                ", pod_datapubli='" & DataPubli.ToString("yyyy-MM-dd HH:mm:ss") & "'" &
                ", pod_dataout='" & DataOut.ToString("yyyy-MM-dd") & "'" &
                ", pod_descrip='" & Descrip & "'" &
                " WHERE pod_id=" & ID.ToString & " ;"

            db.Update_ID(StrSql)
        End If
        db = Nothing
        LockedRecord(True)
        blnNouRecord = False
        gridDades.Focus()
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

    Private Sub cmbFitxer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFitxer.SelectedIndexChanged
        If IsNumeric(cmbFitxer.SelectedValue) = False Then Exit Sub
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ColumnOrigen").Value = cmbFitxer.SelectedValue
            Changed()
            PathFitxer = setPathToPlay(Me.ComboBoxTipus.SelectedValue)
        Catch ex As Exception
        End Try
        If blnNouRecord = True Then
            'Calcular durada del fitxer
            Dim HandlePlay As Integer = Bass.BASS_StreamCreateFile(PathFitxer, 0, 0, 0)
            If HandlePlay = 0 Then
                Me.lbDurada.Text = TimeSerial(0, 0, 0)
            Else
                Dim len As Long = Bass.BASS_ChannelGetLength(HandlePlay)
                Me.lbDurada.Text = TimeSerial(0, 0, Bass.BASS_ChannelBytes2Seconds(HandlePlay, len))
            End If
            Me.lbFileName.Text = createFileName(0, txtDataPublicacio.Value, cmbFitxer.SelectedValue)
        End If

    End Sub

    Private Sub lbDurada_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbDurada.TextChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ColumnDurada").Value = lbDurada.Text
            Changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtDataOut_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles  txtDataOut.ValueChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ColumnDataOut").Value = txtDataOut.Value.ToString("yyyy-MM-dd")
            Changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtDecrip_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDecrip.TextChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ColumnDescrip").Value = txtDecrip.Text
            Changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DeleteRecord()
        If MetroFramework.MetroMessageBox.Show(Me, MSG_CONFIRM_DELETE_DADES, MSG_ATENCIO, MessageBoxButtons.YesNo, MessageBoxIcon.Question, 100) = DialogResult.No Then Exit Sub
        Dim db As New MSC.dbs(Cloud)
        For i As Short = 0 To gridDades.SelectedRows.Count - 1
            'Borrar dbs			
            Dim ID As String = gridDades.SelectedRows(i).Cells("ColumnID").Value.ToString
            Dim StrSql As String = "DELETE FROM podcasting WHERE pod_id=" & ID & " ;"
            db.Delete_ID(StrSql)
            addCtlRadi(0, CShort(Tipus_Play.CTL_SQL), 0, "00:00:00", 0, 0, Usuari.UsrID, StrSql, 0, False)
            'Borrar fitxer ftp
            Dim nomfitxer As String = gridDades.SelectedRows(i).Cells("ColumnFile").Value.ToString
            If ClientFTP Is Nothing Then ConnectFTP()
            ClientFTP.DeleteFileOnServer(nomfitxer)
        Next

        For Each selectedrow As DataGridViewRow In gridDades.SelectedRows
            gridDades.Rows.Remove(selectedrow)
        Next
        db = Nothing
    End Sub

    Sub LbDataCreaTextChanged(sender As Object, e As EventArgs) Handles lbDataCrea.TextChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ColumnDataCrea").Value = Me.lbDataCrea.Text
            Changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtDataPublicacio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDataPublicacio.ValueChanged, txtHoraPublicacio.ValueChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ColumnDataPubli").Value = txtDataPublicacio.Value.ToString("yyyy-MM-dd") & " " & Me.txtHoraPublicacio.Value.ToString("HH:mm:ss")
            Changed()
        Catch ex As Exception
        End Try
        If blnNouRecord = True Then Me.lbFileName.Text = createFileName(0, txtDataPublicacio.Value, cmbFitxer.SelectedValue)
    End Sub

#Region "Player"
    Dim VolMax As Single
    Dim Atack As Integer = 50
    Dim StreamHandlePlay As Integer
    Dim InSrolling As Boolean
    Dim isActive As Un4seen.Bass.BASSActive


    Private Function setPathToPlay(TipFitxer As Integer) As String
        Select Case TipFitxer
            Case Tipus_Fitxers.FITXER_MUSICA : Return Params.PathMusica & cmbFitxer.SelectedValue.ToString & ".mp3"
            Case Tipus_Fitxers.FITXER_PROGRAMA : Return Params.PathProgrames & cmbFitxer.SelectedValue.ToString & ".mp3"
            Case Tipus_Fitxers.FITXER_PUBLICITAT : Return Params.PathPublicitat & cmbFitxer.SelectedValue.ToString & ".mp3"
            Case Else
                'Tipus_Fitxers.FITXER_AUDIO_USR 
                Return Params.PathAudioUser & gridDades.CurrentRow.Cells(2).Value.ToString & ".mp3"
        End Select
    End Function

    Private Sub PlayFitxer()
        'Bass.BASS_SetDevice(DEV_PLAY)
        isActive = Bass.BASS_ChannelIsActive(StreamHandlePlay)
        If isActive = BASSActive.BASS_ACTIVE_PLAYING Then
            Bass.BASS_ChannelPause(StreamHandlePlay)
        ElseIf isActive = BASSActive.BASS_ACTIVE_PAUSED Then
            Bass.BASS_ChannelPlay(StreamHandlePlay, False)
        Else
            Dim strPathFitxer As String = PathFitxer & Me.lbID.Text & ".mp3"
            If Not IO.File.Exists(PathFitxer) Then MetroFramework.MetroMessageBox.Show(Me, MSG_FILE_NO_EXIST, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
            Bass.BASS_ChannelStop(StreamHandlePlay)
            StreamHandlePlay = Bass.BASS_StreamCreateFile(PathFitxer, 0, 0, 0)
            If StreamHandlePlay = 0 Then
                'Can't play stream
                'MsgBox(Bass.BASS_ErrorGetCode )
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

        '---------------------------------------------
        Dim bit As Bitmap = New Bitmap(picVuMeter.Width, picVuMeter.Height)
        Dim graph As Graphics = Graphics.FromImage(bit)
        Dim LimePen As New Pen(Color.Lime, 5)
        Dim PeakPen As New Pen(Color.Red, 5)
        Dim PositionPen As New Pen(Color.Black, 1)
        Dim x As Integer
        graph.SmoothingMode = SmoothingMode.AntiAlias

        ' Pinta Volum dreta i esquerra
        x = (RVol / 32768) * picVuMeter.Width
        If x > picVuMeter.Width Then x = picVuMeter.Width
        graph.DrawLine(LimePen, picVuMeter.Width - x, 4, picVuMeter.Width, 4)

        x = (LVol / 32768) * picVuMeter.Width
        If x > picVuMeter.Width Then x = picVuMeter.Width
        graph.DrawLine(LimePen, picVuMeter.Width - x, 8 + 4, picVuMeter.Width, 8 + 4)

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
            graph.DrawLine(PeakPen, picVuMeter.Width - x, 4, picVuMeter.Width - x - 2, 4)
            graph.DrawLine(PeakPen, picVuMeter.Width - x, 8 + 4, picVuMeter.Width - x - 2, 8 + 4)
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

    Private Sub mnuPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPlay.Click, mnuStop.Click, mnuCalcDurada.Click

        Select Case CType(sender, ToolStripMenuItem).Tag
            Case 0 : PlayFitxer()'"Play/Pausa"
            Case 1 : stopFitxer()'"Stop"
            Case 2 '"Calcular Durada"
                Dim len As Long = Bass.BASS_ChannelGetLength(StreamHandlePlay)
                Me.lbDurada.Text = TimeSerial(0, 0, Bass.BASS_ChannelBytes2Seconds(StreamHandlePlay, len))
                Changed()
            Case 3 '"Final Tema"
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

    Private Sub mnuEditAudio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditAudio.Click

        Bass.BASS_ChannelStop(StreamHandlePlay)
        Bass.BASS_StreamFree(StreamHandlePlay)
        If ProgEditAudio.Length > 0 Then
            If IO.File.Exists(PathFitxer) = True Then
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
        End If
    End Sub

#End Region

#Region "FTP Gestió de fitxers"

    Dim ClientFTP As FtpClient

    Private Function testRemoteFileExist(ByVal PathFitxerRemot As String) As Boolean
        If ClientFTP IsNot Nothing Then
            'Ja estem connectats
            Return ClientFTP.CheckIfFtpFileExists(IO.Path.GetFileName(PathFitxerRemot))
        Else
            'No estem connectats
            Return False
        End If
    End Function

    Private Function getRemoteFileSize(ByVal PathFitxerRemot As String) As Long
        If ClientFTP IsNot Nothing Then
            'Ja estem connectats
            Return ClientFTP.getFileSize(IO.Path.GetFileName(PathFitxerRemot))
        Else
            'No estem connectats
            Return -1
        End If
    End Function

    Private Sub renameRemoteFile(ByVal PathOldFile As String, ByVal PathNewFile As String)
        If ClientFTP IsNot Nothing Then
            'Ja estem connectats
            ClientFTP.RenameFileOnServer(IO.Path.GetFileName(PathOldFile), IO.Path.GetFileName(PathNewFile))
        Else
            'No estem connectats				 
        End If
    End Sub

    Sub CmdConnectClick(sender As Object, e As EventArgs) Handles cmdConnectFTP.Click
        ConnectFTP()
    End Sub

    Private Sub ConnectFTP()
        lbInfoFTP.Text = "Connecting a " & Cloud.ServerFTP
        lbInfoFTP.Visible = True
        My.Application.DoEvents()
        'TODO: transforma la URL a IP i connectar per aquesta.
        'Dim IPEntry As IPHostEntry = Dns.GetHostAddresses(Params.ServerFTP)
        ClientFTP = New FtpClient("ftp://" & Cloud.ServerFTP, Cloud.UserFTP, Cloud.PswFTP)
        AddHandler ClientFTP.StatusChanged, AddressOf InfoFTPProcess
        Dim ftpDir As FtpDirectory = ClientFTP.ListDirectory(Cloud.DirRemote)
        If ftpDir Is Nothing Then
            ClientFTP = Nothing
            Exit Sub
        End If

    End Sub

    Sub CmdDesConnectClick(sender As Object, e As EventArgs) Handles cmdDesConnectFTP.Click
        DesconnectFTP()
    End Sub

    Private Sub DesconnectFTP()
        lbInfoFTP.Text = "Connectat"
        ClientFTP = Nothing
        'cmdConnectFTP.Enabled = True
        'cmdDesConnectFTP.Enabled = False
        buttonExecTasquestFTP.Enabled = False
        lbInfoFTP.Visible = False
        ProgressBarFTP.Visible = False
        txtPartsProces.Visible = False
    End Sub


    Private Sub InfoFTPProcess(ByVal newStatus As String)
        Try
            lbInfoFTP.Text = newStatus
            Dim msgFtp() As String = Split(newStatus, ",")
            If IsNumeric(msgFtp(0)) Then ProgressBarFTP.Value = CInt(msgFtp(0))
            My.Application.DoEvents()
        Catch ex As Exception
            'lbInfoFTP.Text = "fí de la connexió"

            'cmdConnectFTP.Enabled = True
            'cmdDesConnectFTP.Enabled = False
            'lbInfoFTP.Visible = False
            'txtPartsProces.Visible = False
        End Try

    End Sub

    Dim NumOffset As Integer = 0
    Dim NumLimit As Integer = 10
    Dim TotalRows As Integer = 0
    Dim SqlStrLimit As String = ""

    Sub mnuShow(sender As Object, e As EventArgs) Handles mnuShowPendentPubli.Click, mnuShowCaduc.Click, mnuShowAllRemots.Click, mnuShowAll.Click, mnuShowActuals.Click
        For i As Integer = 0 To mnuLlistar.DropDownItems.Count - 1
            CType(mnuLlistar.DropDownItems(i), ToolStripMenuItem).Checked = False
        Next
        Dim mnuShowItem As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
        mnuShowItem.Checked = Not mnuShowItem.Checked
        mnuLlistar.Text = LABEL_LLISTAR & ": " & mnuShowItem.Text
        NumOffset = 0
        Dim SqlStr As String = ""
        Dim CondiselectPrg As String = ""
        If cmbProgrames.SelectedValue > 0 Then
            CondiselectPrg = " AND programes.prg_id = " & cmbProgrames.SelectedValue
        End If
        Select Case mnuShowItem.Tag
            Case 0 ' "Tot"
                SqlStrLimit = "SELECT * FROM podcasting WHERE podcasting.pod_tipusfitxer = 5 ORDER BY pod_id DESC"
                SqlStr = "SELECT * FROM podcasting WHERE podcasting.pod_tipusfitxer = 5 ORDER BY pod_id DESC LIMIT " & NumOffset & ", " & NumLimit & " ;"
            Case 1 '"Actuals"
                SqlStrLimit = "SELECT podcasting.pod_file, podcasting.pod_id,podcasting.pod_tipusfitxer,podcasting.pod_id_origen,podcasting.pod_durada,podcasting.pod_descrip," &
                    "podcasting.pod_datacreacio,podcasting.pod_datapubli,podcasting.pod_dataout " &
                    "FROM podcasting, prg_sessions, programes WHERE podcasting.pod_id_origen= prg_sessions.ses_id " &
                    "AND prg_sessions.ses_prg = programes.prg_id " & CondiselectPrg & " AND  pod_datapubli <= '" & Now.ToString("yyyy-MM-dd") & "' AND pod_dataout >= '" & Now.ToString("yyyy-MM-dd") & "'  ORDER BY pod_id DESC"
                SqlStr = "SELECT podcasting.pod_file,podcasting.pod_id,podcasting.pod_tipusfitxer,podcasting.pod_id_origen,podcasting.pod_durada,podcasting.pod_descrip," &
                    "podcasting.pod_datacreacio,podcasting.pod_datapubli,podcasting.pod_dataout " &
                    "FROM podcasting, prg_sessions, programes WHERE podcasting.pod_id_origen= prg_sessions.ses_id " &
                    "AND prg_sessions.ses_prg = programes.prg_id " & CondiselectPrg & " AND  pod_datapubli <= '" & Now.ToString("yyyy-MM-dd") & "' AND pod_dataout >= '" & Now.ToString("yyyy-MM-dd") & "'  ORDER BY pod_id DESC LIMIT " & NumOffset & ", " & NumLimit & " ;"
            Case 2 '"Pendents de publicar"
                SqlStrLimit = "SELECT podcasting.pod_file,podcasting.pod_id,podcasting.pod_tipusfitxer,podcasting.pod_id_origen,podcasting.pod_durada,podcasting.pod_descrip," &
                    "podcasting.pod_datacreacio,podcasting.pod_datapubli,podcasting.pod_dataout " &
                    "FROM podcasting, prg_sessions, programes WHERE podcasting.pod_id_origen= prg_sessions.ses_id " &
                    "AND prg_sessions.ses_prg = programes.prg_id  " & CondiselectPrg & " AND pod_datapubli > '" & Now.ToString("yyyy-MM-dd") & "' ORDER BY pod_id DESC"
                SqlStr = "SELECT podcasting.pod_file,podcasting.pod_id,podcasting.pod_tipusfitxer,podcasting.pod_id_origen,podcasting.pod_durada,podcasting.pod_descrip," &
                    "podcasting.pod_datacreacio,podcasting.pod_datapubli,podcasting.pod_dataout " &
                    "FROM podcasting, prg_sessions, programes WHERE podcasting.pod_id_origen= prg_sessions.ses_id " &
                    "AND prg_sessions.ses_prg = programes.prg_id  " & CondiselectPrg & " AND pod_datapubli > '" & Now.ToString("yyyy-MM-dd") & "' ORDER BY pod_id DESC LIMIT " & NumOffset & ", " & NumLimit & " ;"
            Case 3 ' Caducats
                SqlStrLimit = "SELECT podcasting.pod_file, podcasting.pod_id,podcasting.pod_tipusfitxer,podcasting.pod_id_origen,podcasting.pod_durada,podcasting.pod_descrip," &
                    "podcasting.pod_datacreacio,podcasting.pod_datapubli,podcasting.pod_dataout " &
                    "FROM podcasting, prg_sessions, programes WHERE podcasting.pod_id_origen= prg_sessions.ses_id " &
                    "AND prg_sessions.ses_prg = programes.prg_id  " & CondiselectPrg & " AND pod_dataout < '" & Now.ToString("yyyy-MM-dd") & "' ORDER BY pod_id DESC"
                SqlStr = "SELECT podcasting.pod_file, podcasting.pod_id,podcasting.pod_tipusfitxer,podcasting.pod_id_origen,podcasting.pod_durada,podcasting.pod_descrip," &
                    "podcasting.pod_datacreacio,podcasting.pod_datapubli,podcasting.pod_dataout " &
                    "FROM podcasting, prg_sessions, programes WHERE podcasting.pod_id_origen= prg_sessions.ses_id " &
                    "AND prg_sessions.ses_prg = programes.prg_id  " & CondiselectPrg & " AND pod_dataout < '" & Now.ToString("yyyy-MM-dd") & "' ORDER BY pod_id DESC LIMIT " & NumOffset & ", " & NumLimit & " ;"
            Case 4 '"Tots els remots"
                SqlStrLimit = "SELECT * FROM podcasting WHERE podcasting.pod_tipusfitxer = 5 ORDER BY pod_id DESC"
                SqlStr = "SELECT * FROM podcasting WHERE podcasting.pod_tipusfitxer = 5 ORDER BY pod_id DESC LIMIT " & NumOffset & ", " & NumLimit & " ;"
        End Select
        Dim db As New MSC.dbs(Cloud)
        OmpleGridsTreballsLocals(db.getTable(SqlStr))

        db.ExecuteScalar(SqlStrLimit)
        TotalRows = CInt(db.ExecuteScalar("SELECT FOUND_ROWS();"))
        cmbAnt.Enabled = (TotalRows > 0)
        cmbNext.Enabled = (TotalRows > 0)
        Me.txtPostRecord.Text = NumOffset & "/" & TotalRows
    End Sub

    Private Sub OmpleGridsTreballsRemots()
        dataGridViewRemote.Rows.Clear()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        My.Application.DoEvents()

        For i As Integer = 0 To dataGridViewLocal.Rows.Count - 1
            Dim separador As String = "/"
            Try
                Dim uriAddress As New Uri(Cloud.DirRemote)
                separador = IIf(uriAddress.IsLoopback = True, "\", "/").ToString
            Catch ex As Exception
            End Try
            Dim NomFitxer As String = dataGridViewLocal.Rows(i).Cells("ColumnLocalNomFitxer").Value.ToString
            Dim PathRemote As String = Cloud.DirRemote & separador & NomFitxer
            Dim PathLocal As String = dataGridViewLocal.Rows(i).Cells("ColumnLocalPath").Value

            Dim drRemote As New DataGridViewRow
            drRemote = dataGridViewRemote.Rows(dataGridViewRemote.Rows.Add())
            drRemote.Cells("ColumnFTPAction").Value = 0
            drRemote.Cells("ColumnFTPPath").Value = PathRemote
            drRemote.Cells("ColumnFTPSize").Value = String.Format("{0:n}", getRemoteFileSize(PathRemote))
            If testRemoteFileExist(PathRemote) = False Then
                drRemote.Cells("ColumnFTPPath").Style.BackColor = Color.Red
                'drRemote.Cells("ColumnFTPChk").Value = 1
                drRemote.Cells("ColumnFTPAction").Value = CInt(AccionsRemoteFile.UPLOAD_FILE)
                buttonExecTasquestFTP.Enabled = True
            End If
            'Compara mides
            If drRemote.Cells("ColumnFTPSize").Value <> dataGridViewLocal.Rows(i).Cells("ColumnLocalSize").Value Then
                If drRemote.Cells("ColumnFTPSize").Value = "-1" Then
                    drRemote.Cells("ColumnFTPSize").Style.BackColor = Color.Red
                Else
                    drRemote.Cells("ColumnFTPSize").Style.BackColor = Color.Yellow
                End If
                buttonExecTasquestFTP.Enabled = True
            End If
            My.Application.DoEvents()
        Next
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub OmpleGridsTreballsLocals(Table As DataTable)
        dataGridViewLocal.Rows.Clear()
        dataGridViewRemote.Rows.Clear()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        My.Application.DoEvents()
        For z As Integer = 0 To Table.Rows.Count - 1
            Dim IDPodcast As Integer = Table.Rows(z)("pod_id")
            Dim IDFitxer As Integer = Table.Rows(z)("pod_id_origen")
            Dim TipFitxer As Integer = Table.Rows(z)("pod_tipusfitxer")
            Dim NomFile As String = Table.Rows(z)("pod_file").ToString
            Dim PathLocal As String = ""
            Select Case TipFitxer
                Case Tipus_Fitxers.FITXER_MUSICA : PathLocal = Params.PathMusica & IDFitxer.ToString & ".mp3"
                Case Tipus_Fitxers.FITXER_PROGRAMA : PathLocal = Params.PathProgrames & IDFitxer.ToString & ".mp3"
                Case Tipus_Fitxers.FITXER_PUBLICITAT : PathLocal = Params.PathPublicitat & IDFitxer.ToString & ".mp3"
                Case Else
                    'Tipus_Fitxers.FITXER_AUDIO_USR 
                    PathLocal = Params.PathAudioUser & IDFitxer.ToString & ".mp3"
            End Select

            Dim drLocal As New DataGridViewRow
            drLocal = dataGridViewLocal.Rows(dataGridViewLocal.Rows.Add())

            drLocal.Cells("ColumnLocalID").Value = IDPodcast
            drLocal.Cells("ColumnLocalNom").Value = getNomFitxerPodcast(TipFitxer, IDFitxer)
            drLocal.Cells("ColumnLocalDataIn").Value = CDate(Table.Rows(z)("pod_datapubli")).ToString("yyyy-MM-dd")
            drLocal.Cells("ColumnLocalDataOut").Value = CDate(Table.Rows(z)("pod_dataout")).ToString("yyyy-MM-dd")
            drLocal.Cells("ColumnLocalPath").Value = PathLocal
            drLocal.Cells("ColumnLocalNomFitxer").Value = NomFile
            If IO.File.Exists(PathLocal) = True Then
                Dim fInf As New IO.FileInfo(PathLocal)
                drLocal.Cells("ColumnLocalSize").Value = String.Format("{0:n}", fInf.Length)
            Else
                drLocal.Cells("ColumnLocalSize").Value = -1
                drLocal.Cells("ColumnLocalPath").Style.BackColor = Color.Red
            End If
            drLocal.Cells("ColumnLocalTipus").Value = getNomTipusFitxer(TipFitxer)

        Next
        Me.Cursor = System.Windows.Forms.Cursors.Default
        If Cloud.ServerFTP.Length > 5 AndAlso dataGridViewLocal.Rows.Count > 0 Then
            If ClientFTP Is Nothing Then ConnectFTP()
            OmpleGridsTreballsRemots()
        End If


    End Sub

    Sub ButtonExecTasquestFTPClick(sender As Object, e As EventArgs) Handles buttonExecTasquestFTP.Click
        ExecuteTasquesFTP()
    End Sub

    Private Sub ExecuteTasquesFTP()
        ProgressBarFTP.Visible = True

        Dim NumMaxProces As Integer = 0
        Dim NumProces As Integer = 0
        For s As Integer = 0 To dataGridViewRemote.Rows.Count - 1
            Dim IsChk As Boolean = dataGridViewRemote.Rows(s).Cells("ColumnFTPAction").Value > 0 'dataGridViewRemote.Rows (s).Cells ("ColumnFTPChk").Value
            If IsChk = True Then NumMaxProces += 1
        Next
        txtPartsProces.Visible = True
        For i As Integer = 0 To dataGridViewRemote.Rows.Count - 1
            AmbTasquesPendents = True
            ProgressBarFTP.Maximum = dataGridViewRemote.Rows.Count
            ProgressBarFTP.Value = i
            ProgressBarFTP.Style = System.Windows.Forms.ProgressBarStyle.Marquee
            NumProces += 1
            txtPartsProces.Text = NumProces.ToString & " / " & NumMaxProces.ToString
            My.Application.DoEvents()
            Dim bl As Boolean = CBool(dataGridViewRemote.Rows(i).Cells("ColumnFTPChk").Value)
            If bl = True Then
                Dim PathLocal As String = Me.dataGridViewLocal.Rows(i).Cells("ColumnLocalPath").Value
                If IO.File.Exists(PathLocal) = True Then
                    Dim PathRemote As String = dataGridViewRemote.Rows(i).Cells("ColumnFTPPath").Value
                    Select Case dataGridViewRemote.Rows(i).Cells("ColumnFTPAction").Value
                        Case AccionsRemoteFile.UPLOAD_FILE
                            Dim ftpDir As FtpDirectory = ClientFTP.ListDirectory(Cloud.DirRemote)
                            If ftpDir Is Nothing Then
                                lbInfoFTP.Text = MSG_FTP_CONNECT_CLOSE
                                Me.buttonExecTasquestFTP.Enabled = False
                                'Me.cmdDesConnectFTP.Enabled = False 
                                'Me.cmdConnectFTP.Enabled = True  
                                Exit Sub
                            End If
                            Dim rename As String = Me.dataGridViewLocal.Rows(i).Cells("ColumnLocalNomFitxer").Value.ToString
                            Dim FitxerTMPFTP As String = IO.Path.GetTempPath & rename
                            'resamplejar el fitxer
                            If Cloud.QSamplePodcast > 0 Then
                                ProgressBarFTP.Style = System.Windows.Forms.ProgressBarStyle.Marquee
                                InfoFTPProcess("Codificant fitxer ...")
                                Dim R_SampleRate As EncoderLAME.SAMPLERATE
                                Dim R_BitRate As EncoderLAME.BITRATE
                                Dim R_Chanels As EncoderLAME.LAMEMode
                                Select Case Cloud.QSamplePodcast
                                    Case 1
                                        R_SampleRate = EncoderLAME.SAMPLERATE.Hz_44100
                                        R_BitRate = EncoderLAME.BITRATE.kbps_192
                                        R_Chanels = EncoderLAME.LAMEMode.Stereo
                                    Case 2
                                        R_SampleRate = EncoderLAME.SAMPLERATE.Hz_44100
                                        R_BitRate = EncoderLAME.BITRATE.kbps_160
                                        R_Chanels = EncoderLAME.LAMEMode.Stereo
                                    Case 3
                                        R_SampleRate = EncoderLAME.SAMPLERATE.Hz_44100
                                        R_BitRate = EncoderLAME.BITRATE.kbps_128
                                        R_Chanels = EncoderLAME.LAMEMode.Stereo
                                    Case 4
                                        R_SampleRate = EncoderLAME.SAMPLERATE.Hz_44100
                                        R_BitRate = EncoderLAME.BITRATE.kbps_96
                                        R_Chanels = EncoderLAME.LAMEMode.Stereo
                                    Case 5
                                        R_SampleRate = EncoderLAME.SAMPLERATE.Hz_22050
                                        R_BitRate = EncoderLAME.BITRATE.kbps_64
                                        R_Chanels = EncoderLAME.LAMEMode.Stereo
                                    Case 6
                                        R_SampleRate = EncoderLAME.SAMPLERATE.Hz_22050
                                        R_BitRate = EncoderLAME.BITRATE.kbps_32
                                        R_Chanels = EncoderLAME.LAMEMode.Mono
                                End Select
                                Dim stream As Integer = Bass.BASS_StreamCreateFile(PathLocal, 0, 0, BASSFlag.BASS_STREAM_DECODE)
                                Dim l As New EncoderLAME(stream)
                                l.InputFile = Nothing 'STDIN
                                l.OutputFile = FitxerTMPFTP
                                l.LAME_Bitrate = CInt(R_BitRate)
                                l.LAME_Mode = R_Chanels
                                l.LAME_TargetSampleRate = R_SampleRate
                                l.LAME_Quality = EncoderLAME.LAMEQuality.Quality
                                l.Start(Nothing, IntPtr.Zero, False)
                                ' decode the stream (if not using a decoding channel, simply call "Bass.BASS_ChannelPlay" here) 
                                Dim encBuffer(65536) As Byte ' our dummy encoder buffer 
                                While Bass.BASS_ChannelIsActive(stream) = BASSActive.BASS_ACTIVE_PLAYING
                                    ' getting sample data will automatically feed the encoder 
                                    Dim len As Integer = Bass.BASS_ChannelGetData(stream, encBuffer, encBuffer.Length)
                                    ProgressBarFTP.Value = 1
                                    Application.DoEvents()
                                End While
                                l.Stop() ' finish
                                Bass.BASS_StreamFree(stream)
                                ProgressBarFTP.Style = System.Windows.Forms.ProgressBarStyle.Blocks
                            Else
                                IO.File.Copy(PathLocal, FitxerTMPFTP, True)
                            End If
                            Dim fi As IO.FileInfo
                            If IO.File.Exists(FitxerTMPFTP) = True Then
                                fi = New IO.FileInfo(FitxerTMPFTP)
                            Else
                                fi = New IO.FileInfo(PathLocal)
                            End If
                            ProgressBarFTP.Maximum = fi.Length
                            ProgressBarFTP.Style = System.Windows.Forms.ProgressBarStyle.Continuous
                            My.Application.DoEvents()
                            ClientFTP.Upload(fi)
                            If IO.File.Exists(FitxerTMPFTP) Then
                                Try
                                    IO.File.Delete(FitxerTMPFTP)
                                Catch ex As Exception
                                End Try
                            End If
                        Case AccionsRemoteFile.DELETE_FILE
                            ClientFTP.DeleteFileOnServer(IO.Path.GetFileName(PathRemote))
                        Case Else '???
                    End Select

                    dataGridViewRemote.Rows(i).Cells("ColumnFTPPath").Style.BackColor = Color.White
                End If
            End If
        Next
        ProgressBarFTP.Visible = False
        txtPartsProces.Visible = False
        AmbTasquesPendents = False
        'Refresca el llistat per obtenir els valors actuals
        OmpleGridsTreballsRemots()
    End Sub

    Friend Sub AutomaticUploadFitxer(idPod() As Integer)
        AmbTasquesPendents = True
        tabControl1.SelectedTab = tabControl1.TabPages(1)

        'Obrim la connexió FTP
        lbInfoFTP.Text = String.Format(MSG_FTP_CONNECTING, Cloud.ServerFTP)
        lbInfoFTP.Visible = True
        My.Application.DoEvents()
        ClientFTP = Nothing
        ClientFTP = New FtpClient("ftp://" & Cloud.ServerFTP, Cloud.UserFTP, Cloud.PswFTP)
        AddHandler ClientFTP.StatusChanged, AddressOf InfoFTPProcess
        Dim ftpDir As FtpDirectory = ClientFTP.ListDirectory(Cloud.DirRemote)
        If ftpDir Is Nothing Then
            lbInfoFTP.Text = MSG_FTP_CONNECT_CLOSE
            Me.buttonExecTasquestFTP.Enabled = False
            'Me.cmdDesConnectFTP.Enabled = False 
            'Me.cmdConnectFTP.Enabled = True 
            ClientFTP = Nothing
            Exit Sub
        End If

        Dim SqlStr As String = "SELECT * FROM podcasting WHERE"
        For i As Integer = 0 To idPod.Length - 1
            If SqlStr.Length > 30 Then SqlStr = SqlStr & " OR"
            SqlStr = SqlStr & " pod_id=" & idPod(i) & " "
        Next
        SqlStr = SqlStr & " ;"

        Dim db As New MSC.dbs(Cloud)
        OmpleGridsTreballsLocals(db.getTable(SqlStr))
        ExecuteTasquesFTP()
    End Sub

    Sub DataGridViewLocalCellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridViewLocal.CellContentClick
        If Me.dataGridViewLocal.Columns(e.ColumnIndex).Name = "ColumnLocalPlay" Then
            PathFitxer = dataGridViewLocal.Rows(e.RowIndex).Cells("ColumnLocalPath").Value
            If IO.File.Exists(PathFitxer) = True Then
                If StreamHandlePlay <> 0 Then Bass.BASS_StreamFree(StreamHandlePlay)
                PlayFitxer()
            End If
        End If
    End Sub

    Sub DataGridViewRemoteCellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridViewRemote.CellContentClick
        If Me.dataGridViewRemote.Columns(e.ColumnIndex).Name = "ColumnFTPPlay" Then
            PathFitxer = dataGridViewRemote.Rows(e.RowIndex).Cells("ColumnFTPPath").Value
            If testRemoteFileExist(PathFitxer) = True Then
                If StreamHandlePlay <> 0 Then Bass.BASS_StreamFree(StreamHandlePlay)
                Dim AbsolutePath As String = Cloud.ServerFTP & "/" & PathFitxer
                PathFitxer = AbsolutePath
                StreamHandlePlay = Bass.BASS_StreamCreateURL(PathFitxer, 0, BASSFlag.BASS_DEFAULT, Nothing, IntPtr.Zero)
                PlayFitxer()
            End If
        End If
        If Me.dataGridViewRemote.Columns(e.ColumnIndex).Name = "ColumnFTPChk" Then
            Dim chkValues As Boolean = dataGridViewRemote.Rows(e.RowIndex).Cells("ColumnFTPChk").Value
            If chkValues = True Then buttonExecTasquestFTP.Enabled = True
        End If
    End Sub

#End Region

    Sub MnuLimit_Click(sender As Object, e As EventArgs) Handles mnuLimit30.Click, mnuLimit20.Click, mnuLimit10.Click
        mnuLimit10.Checked = False
        Dim MyMnu As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
        NumLimit = CInt(MyMnu.Text)
        MyMnu.Checked = True
    End Sub

    Sub CmbGoTORocordClick(sender As Object, e As EventArgs) Handles cmbNext.Click, cmbAnt.Click
        cmbAnt.Enabled = True
        cmbNext.Enabled = True
        Dim MyButton As ToolStripButton = CType(sender, ToolStripButton)
        If MyButton.Text = "<" Then
            NumOffset = NumOffset - NumLimit
            If NumOffset < 0 Then NumOffset = 0 : cmbAnt.Enabled = False
        Else
            NumOffset = NumOffset + NumLimit
            If NumOffset > TotalRows Then NumOffset = TotalRows : cmbNext.Enabled = False
        End If
        Dim StrSql = SqlStrLimit & " LIMIT " & NumOffset & ", " & NumLimit & " ;"
        Dim db As New MSC.dbs(Cloud)
        OmpleGridsTreballsLocals(db.getTable(StrSql))
        Me.txtPostRecord.Text = NumOffset & "/" & TotalRows
    End Sub
    Dim NoRefresh As Boolean = True
    Sub CmbProgramesSelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProgrames.SelectedIndexChanged
        If NoRefresh = False Then establirRecordset()
    End Sub

    Sub ComboboxGeneralTaskServerSelectedIndexChanged(sender As Object, e As EventArgs) Handles comboboxGeneralTaskServer.SelectedIndexChanged

        For i As Integer = 0 To dataGridViewRemote.SelectedRows.Count - 1
            dataGridViewRemote.SelectedRows(i).Cells("ColumnFTPAction").Value = comboboxGeneralTaskServer.SelectedValue
        Next

    End Sub

    Private Sub frmPodcast_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        Dim FitxerINI As New IniFile
        frm_sice(0) = Me.Width : frm_sice(1) = Me.Height
        FitxerINI.INIWrite(MyAPP.IniFile, "Data Gest", "size", frm_sice(0).ToString & "," & frm_sice(1).ToString)
    End Sub

    Private Sub cmbFitxer_KeyUp(sender As Object, e As KeyEventArgs) Handles cmbFitxer.KeyUp
        Select Case e.KeyCode
            Case Keys.Left, Keys.Right, Keys.Up, Keys.Down, Keys.Back, Keys.ShiftKey, Keys.Return
                Return
        End Select
        If e.Shift = True AndAlso e.KeyCode = Keys.Home Then Return
        If e.Shift = True AndAlso e.KeyCode = Keys.End Then Return
        Dim condi As String = cmbFitxer.Text
        OmplircomboBoxProgramSessions(cmbFitxer, condi)
    End Sub

    Private Sub cmbFitxer_Leave(sender As Object, e As EventArgs) Handles cmbFitxer.Leave
        Dim ses_id As Integer = cmbFitxer.SelectedValue
        If ses_id = 0 Then
            OmplircomboBoxProgramSessions(cmbFitxer)
            cmbFitxer.Focus()
        Else
            If blnNouRecord = True Then
                If IO.File.Exists(PathFitxer) = False Then
                    MetroFramework.MetroMessageBox.Show(Me, MSG_FILE_NO_EXIST, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
                    cmbFitxer.Focus()
                End If
            End If
        End If
    End Sub
End Class