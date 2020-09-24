'
' Creado por SharpDevelop.
' Usuario: nomai_000
' Fecha: 10/12/2015
' Hora: 0:25
' 
' Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
'

Imports System.Drawing.Drawing2D
Imports BassTags = Un4seen.Bass.AddOn.Tags.BassTags

Public Partial Class frmExport
	Dim Cancelled As Boolean	
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Dim MSG_CONFIRM_CANCEL As String 	
	Dim MSG_EXPORT_REALITZADA As String
    Dim MSG_DIR_DESTINATION As String
    Dim MSG_LABEL_TOTAL As String
    Dim MSG_LABEL_ESPAI_NECESSARI As String


    Public Sub setLanguageForm()
		lang.StrForm = Me.Name

        MSG_LABEL_TOTAL = lang.getText("LABEL_TOTAL", True) 'Total
        MSG_LABEL_ESPAI_NECESSARI = lang.getText("MSG_LABEL_ESPAI_NECESSARI") ' Espai necessari
        MSG_CONFIRM_CANCEL = lang.getText("MSG_CANCEL_EXPORT")'"Vols cancelar totes les exportacions?"		
		MSG_EXPORT_REALITZADA = lang.getText("MSG_EXPORT_REALITZADA")'"Exportació realitzada"
		MSG_DIR_DESTINATION = lang.getText("LABEL_DIR_DESTI",True) '"Directori destí"
		
		
		Me.mnuExit.Text = lang.getText("LABEL_PROGRAMA",True) '"Programa"
		Me.SortirToolStripMenuItem.Text = lang.getText("LABEL_EXIT",True) '"Sortir"
		Me.cmdExitTool.Text = lang.getText("LABEL_EXIT",True) '"Sortir"
		Me.PlayToolStripMenuItem.Text = lang.getText("LABEL_REPRODUCTOR",True) '"Reproductor"
		Me.mnuPlay.Text = lang.getText("LABEL_PLAY_PAUSA",True) '"Play/Pausa"
		Me.mnuStop.Text = lang.getText("LABEL_STOP",True) '"Stop"
		Me.ToolStripMenuItem8.Text = lang.getText("mnu_Help",True) '"Ajuda"
		Me.mnu_Help.Text = lang.getText("mnuRefHelp.Text",True) '"Manual OnLine"
		Me.cmdBuscar.Text = lang.getText("LABEL_BUSCAR",True)'"Buscar"
		Me.cmdPlay.Text = lang.getText("LABEL_PLAY_PAUSA",True) '"Play"
		Me.cmdStop.Text = lang.getText("LABEL_STOP",True) '"Stop"
		Me.ColumnID.HeaderText = lang.getText("HEADERTEXT_ID",True)'"ID"
		Me.ColumnTitol.HeaderText = lang.getText("HEADERTEXT_TITOL",True)'"Títol"
		
		Me.ColumnSubTitol.HeaderText = lang.getText("ColumnSubTitol.HeaderText")'"Subtítol"		
		Me.recercaAbancadaDeCançonsToolStripMenuItem.Text = lang.getText("recercaAbancadaDeCançonsToolStripMenuItem.Text")'"Recerca avançada de cançons"
		Me.cmdCheck.Text = lang.getText("LABEL_SELECT_TOT",True)'"Seleccionar tot"
		Me.cmdCheck.ToolTipText = Me.cmdCheck.Text
		Me.cmdPlay.ToolTipText = lang.getText("LABEL_REPRODUIR_FITXER",True)'"Reproduïr fitxer"		
		Me.cmdStop.ToolTipText = lang.getText("cmdStop.ToolTipText")'"Stop reproducció"
		Me.mnuFindNomesActius.Text = lang.getText("LABEL_NOMES_FITXERS_CATIUS",True)'"Només fitxers actius"		
		Me.lbAtencio.Text = lang.getText("LABEL_NO_EXIST",True)'"No Exist."
		Me.lbAtencio.ToolTipText = lang.getText("LABEL_NO_EXIST_FILE",True)'"No existeix el fitxer"
		'Me.groupBoxExport.Text = "Exportació fitxers de la base de dades"		
		
		labelTipus.Text = lang.getText("LABEL_TIPUS_FITXER",True)& ":"			
		Me.GroupBox1.Text = lang.getText("GroupBox1.Text")'"Espai requerit al disc dur"		
		Me.cmdCalcHD.Text = lang.getText("LABEL_CALCULAR",True)'"Calcular"
		lbInfoHD.Text = lang.getText("LABEL_PENDENT",True)& " ..."
		Me.lbDesti.Text = lang.getText("LABEL_DESTI",True)'"Destí"
		Me.Text = lang.getText("Text") '"Exportació de fitxers"
        Dim Cmb As New combo
        Cmb.OmpleCombo(Me.ComboBoxOpcions, TAULES_DBS.TAULA_TIPUS_FITXER, TotsCap.NO_ADD) : ComboBoxOpcions.SelectedValue = 1

    End Sub

    Sub FrmExportLoad(sender As Object, e As EventArgs) Handles MyBase.Load

        setLanguageForm()

        refreshListToExport()
        Me.ClientSize = New Size(frm_sice(0), frm_sice(1))

    End Sub

    Friend Sub refreshListToExport()
        recercaAbancadaDeCançonsToolStripMenuItem.Enabled = False

        Dim StrSql As String = ""
        Dim NomCarpeta As String = ComboBoxOpcions.Text
        Dim StrActv As String = ""
        dataGridViewFitxers.Rows.Clear()
        dataGridViewFitxers.Columns("columnAny").Visible = False
        dataGridViewFitxers.Columns("columnEstil").Visible = False
        Dim aa As Integer = Me.ComboBoxOpcions.SelectedValue
        Select Case Me.ComboBoxOpcions.SelectedValue
            Case Tipus_Fitxers.FITXER_MUSICA
                If mnuFindNomesActius.Checked Then StrActv = "AND `temes`.`tema_pautain`= 1"
                StrSql = "SELECT DISTINCT `temes`.`tema_id` as col_id, `temes`.`tema_titol` as col_titol, `interprets`.`interp_nom` as col_subtitol, `discos`.`disc_nom` as nom_carpeta FROM `temes`,  `interprets`, `discos` WHERE ( `temes`.`tema_interp`=`interprets`.`interp_id` AND `tema_disc`=`disc_id` " & StrActv & " ) ORDER BY `temes`.`tema_titol`, `interprets`.`interp_nom` "
                recercaAbancadaDeCançonsToolStripMenuItem.Enabled = True
                NomCarpeta = ""
                dataGridViewFitxers.Columns("columnAny").Visible = True
                dataGridViewFitxers.Columns("columnEstil").Visible = True
            Case Tipus_Fitxers.FITXER_PUBLICITAT
                If mnuFindNomesActius.Checked Then StrActv = "WHERE `falc_activa`= 1"
                StrSql = "SELECT falques.falc_id as col_id , falques.falc_nom as col_titol, clients.cli_nom as col_subtitol FROM falques INNER JOIN clients ON falques.falc_client = clients.cli_id  " & StrActv & " ;"
            Case Tipus_Fitxers.FITXER_PROGRAMA
                If mnuFindNomesActius.Checked Then StrActv = "AND `prg_atv`= 1"
                StrSql = "SELECT `prg_sessions`.`ses_id` as col_id ,  CONCAT(`programes`.`prg_nom`,' (Sessió=',`prg_sessions`.`ses_id`,' Data=',DATE_FORMAT(`prg_sessions`.`ses_datacreacio`,'%Y-%m-%d'),')') as col_titol , '" & Params.NomRadio() & "' as col_subtitol ,`programes`.`prg_nom` as nom_carpeta " &
                    " FROM `programes` AS `programes`, `prg_sessions` AS `prg_sessions`" &
                    " WHERE `programes`.`prg_id` = `prg_sessions`.`ses_prg` AND ses_sessiomare=0 " & StrActv & " ;"
                NomCarpeta = ""
            Case Else 'Tipus_Fitxers.FITXER_AUDIO_USR	
                Dim IDAudioUser As Integer = ComboBoxOpcions.SelectedValue - 600
                If mnuFindNomesActius.Checked Then StrActv = "AND `audio_actv`= 1"
                StrSql = "SELECT `audio_id` as col_id, `audio_nom` as col_titol, '" & Params.NomRadio() & "' as col_subtitol FROM audios_params WHERE listaudio_id=" & IDAudioUser & " " & StrActv & " ;"

        End Select
        Dim dbs As New MSC.dbs(Cloud)
        Dim dt As DataTable = dbs.getTable(StrSql)

        For i As Integer = 0 To dt.Rows.Count - 1
            Dim ID As Integer = CInt(dt.Rows(i)("col_id"))
            Dim titol As String = dt.Rows(i)("col_titol").ToString
            Dim subtitol As String = dt.Rows(i)("col_subtitol").ToString
            If NomCarpeta.Length = 0 Then NomCarpeta = dt.Rows(i)("nom_carpeta").ToString

            Dim rowIndex As Integer = dataGridViewFitxers.Rows.Add(New String() {ID, False, titol, subtitol})
            dataGridViewFitxers.Rows(rowIndex).Tag = NomCarpeta
        Next

    End Sub

    Sub FrmExportFormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Dim Cancel As Boolean = e.Cancel
        Dim UnloadMode As System.Windows.Forms.CloseReason = e.CloseReason
        Select Case UnloadMode
            Case CloseReason.UserClosing
                If Me.cmdSortir.Enabled = False Then
                    WindowState = System.Windows.Forms.FormWindowState.Minimized
                    Cancel = True
                Else
                    CloseForm()
                End If
            Case System.Windows.Forms.CloseReason.TaskManagerClosing
                MetroFramework.MetroMessageBox.Show(Me, MSG_NO_STOP_APP, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
                Cancel = True
                WindowState = System.Windows.Forms.FormWindowState.Minimized
            Case System.Windows.Forms.CloseReason.WindowsShutDown
                CloseForm()
            Case Else
                Cancel = True
                WindowState = System.Windows.Forms.FormWindowState.Minimized
        End Select
        e.Cancel = Cancel
    End Sub

    Private Sub CloseForm()
        If Bass.BASS_ChannelIsActive(StreamHandlePlay) Then Call Bass.BASS_StreamFree(StreamHandlePlay)
        MyAPP.CloseSesionClient(MyAPP.IDSesion_Client, DESCRIP_FORM_EXPORT_FILES)
        Me.Dispose()
    End Sub

    Sub CmdSortirClick(sender As Object, e As EventArgs) Handles cmdSortir.Click
        Me.Close()
    End Sub

    Sub ButtonPathDestiClick(sender As Object, e As EventArgs) Handles txtPathDesti.ButtonClick
        folderBrowserDialog1.Description = MSG_DIR_DESTINATION
        If folderBrowserDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Me.txtPathDesti.Text = folderBrowserDialog1.SelectedPath
        End If
    End Sub

    Sub CmdExportClick(sender As Object, e As EventArgs) Handles cmdExport.Click
        Dim NouNomFitxer As String
        Dim PathDesti As String
        Dim y As Integer = 0

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.AppStarting
        Cancelled = False
        Me.ProgressBarTasc.Visible = True
        Me.cmdCancel.Visible = True
        Me.cmdSortir.Enabled = False
        cmdExitTool.Enabled = False
        SortirToolStripMenuItem.Enabled = False
        AmbTasquesPendents = True

        Dim PathArrel As String = ""
        Select Case Me.ComboBoxOpcions.SelectedValue
            Case Tipus_Fitxers.FITXER_MUSICA : PathArrel = Params.PathMusica
            Case Tipus_Fitxers.FITXER_PUBLICITAT : PathArrel = Params.PathPublicitat
            Case Tipus_Fitxers.FITXER_PROGRAMA : PathArrel = Params.PathProgrames
            Case Else : PathArrel = Params.PathAudioUser 'Tipus_Fitxers.FITXER_AUDIO_USR							
        End Select

        ProgressBarTasc.Maximum = dataGridViewFitxers.Rows.Count - 1

        For i As Integer = 0 To dataGridViewFitxers.Rows.Count - 1
            If Cancelled Then If MetroFramework.MetroMessageBox.Show(Me, MSG_CONFIRM_CANCEL, MSG_ATENCIO, MessageBoxButtons.YesNo, MessageBoxIcon.Question, 100) = DialogResult.Yes Then Exit For
            Dim sel As Boolean = CBool(dataGridViewFitxers.Rows(i).Cells("ColumnSelect").Value)
            If sel = True Then
                Dim FileID As Integer = CInt(dataGridViewFitxers.Rows(i).Cells("ColumnID").Value)
                Dim PathFitxer As String = PathArrel & FileID & ".mp3"
                If IO.File.Exists(PathFitxer) Then
                    Dim Titol As String = dataGridViewFitxers.Rows(i).Cells("ColumnTitol").Value.ToString
                    Dim Subtitol As String = dataGridViewFitxers.Rows(i).Cells("ColumnSubTitol").Value.ToString
                    Dim NomCarpeta As String = RemoveInvalidFileNameChars(dataGridViewFitxers.Rows(i).Tag.ToString).ToString

                    Dim any As String = ""
                    Try
                        any = dataGridViewFitxers.Rows(i).Cells("ColumnAny").Value.ToString
                    Catch ex As Exception
                    End Try
                    Dim estil As String = ""
                    Try
                        estil = dataGridViewFitxers.Rows(i).Cells("ColumnEstil").Value.ToString
                    Catch ex As Exception

                    End Try
                    PathDesti = Me.txtPathDesti.Text & "\" & NomCarpeta

                    Try
                        If Not IO.Directory.Exists(PathDesti) Then
                            IO.Directory.CreateDirectory(PathDesti)
                            If ComboBoxOpcions.SelectedValue = Tipus_Fitxers.FITXER_MUSICA Then
                                'crea el pictureCover
                                Dim coverImg As Image = getImageDisc(NomCarpeta)
                                If Not coverImg Is Nothing Then coverImg.Save(PathDesti & "\cover.jpg", Imaging.ImageFormat.Jpeg)
                            End If
                        End If
                        Do
                            If y = 0 Then
                                NouNomFitxer = Titol & " - " & Subtitol
                                If ComboBoxOpcions.SelectedValue = Tipus_Fitxers.FITXER_MUSICA Then NouNomFitxer += " - " & NomCarpeta & " - " & estil & " - " & any
                                NouNomFitxer += " .mp3"
                            Else
                                NouNomFitxer = Titol & " - " & Subtitol & " (" & y & ")"
                                If ComboBoxOpcions.SelectedValue = Tipus_Fitxers.FITXER_MUSICA Then NouNomFitxer += " - " & NomCarpeta & " - " & estil & " - " & any
                                NouNomFitxer += " .mp3"
                            End If

                            PathDesti += "\" & RemoveInvalidFileNameChars(NouNomFitxer)
                            If Not IO.File.Exists(PathDesti) Then
                                y = 0
                                Exit Do
                            Else
                                y = y + 1
                            End If
                        Loop
                        IO.File.Copy(PathFitxer, PathDesti)
                    Catch ex As Exception
                        MetroFramework.MetroMessageBox.Show(Me, ex.Message, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 150)
                    End Try
                Else
                    dataGridViewFitxers.Rows(i).Cells("ColumnSelect").Style.BackColor = Color.Red
                End If
            End If
            System.Windows.Forms.Application.DoEvents()
            If Cancelled Then Exit For
            ProgressBarTasc.Value = i
        Next i

        Me.ProgressBarTasc.Visible = False
        Me.cmdCancel.Enabled = False
        Me.cmdSortir.Enabled = True
        cmdExitTool.Enabled = True
        SortirToolStripMenuItem.Enabled = True
        AmbTasquesPendents = False

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        MetroFramework.MetroMessageBox.Show(Me, MSG_EXPORT_REALITZADA, My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Information, 100)

    End Sub

    Sub CmdExitToolClick(sender As Object, e As EventArgs) Handles cmdExitTool.Click
        Me.Close()
    End Sub

    Sub TxtPathDestiTextChanged(sender As Object, e As EventArgs) Handles txtPathDesti.TextChanged
        Me.cmdExport.Enabled = IO.Directory.Exists(Me.txtPathDesti.Text)
    End Sub

    Sub SortirToolStripMenuItemClick(sender As Object, e As EventArgs) Handles SortirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Sub MnuFindNomesActiusClick(sender As Object, e As EventArgs) Handles mnuFindNomesActius.Click
        mnuFindNomesActius.Checked = Not mnuFindNomesActius.Checked
        refreshListToExport()
    End Sub

    Sub CmdCheckClick(sender As Object, e As EventArgs) Handles cmdCheck.Click
        For i As Integer = 0 To dataGridViewFitxers.Rows.Count - 1
            dataGridViewFitxers.Rows(i).Cells("ColumnSelect").Value = True
        Next
    End Sub

    Sub MnuPlayClick(sender As Object, e As EventArgs) Handles mnuPlay.Click
        PlayFitxer()
    End Sub

    Sub MnuStopClick(sender As Object, e As EventArgs) Handles mnuStop.Click
        stopFitxer()
    End Sub

    Sub CmdStopClick(sender As Object, e As EventArgs) Handles cmdStop.Click
        stopFitxer()
    End Sub

    Sub CmdPlayClick(sender As Object, e As EventArgs) Handles cmdPlay.Click
        PlayFitxer()
    End Sub

#Region "Player"
    Dim VolMax As Single
    Dim Atack As Integer = 50
    Dim StreamHandlePlay As Integer
    Dim InSrolling As Boolean
    Dim isActive As Un4seen.Bass.BASSActive
    Dim strPathFitxer As String

    Private Sub PlayFitxer()
        isActive = Bass.BASS_ChannelIsActive(StreamHandlePlay)
        If isActive = BASSActive.BASS_ACTIVE_PLAYING Then
            Bass.BASS_ChannelPause(StreamHandlePlay)
        ElseIf isActive = BASSActive.BASS_ACTIVE_PAUSED Then
            Bass.BASS_ChannelPlay(StreamHandlePlay, False)
        Else

            If Not IO.File.Exists(strPathFitxer) Then MetroFramework.MetroMessageBox.Show(Me, "El fitxer " & strPathFitxer & " no existeix.", MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
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

    Private Sub stopFitxer()
        Bass.BASS_ChannelStop(StreamHandlePlay)
        Bass.BASS_StreamFree(StreamHandlePlay)
    End Sub

    Sub PicVuMeterMouseClick(sender As Object, e As MouseEventArgs) Handles picVuMeter.MouseClick
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

    Sub DataGridViewFitxersCurrentCellChanged(sender As Object, e As EventArgs) Handles dataGridViewFitxers.CurrentCellChanged
        Dim PathArrel As String = ""
        Select Case Me.ComboBoxOpcions.SelectedValue
            Case Tipus_Fitxers.FITXER_MUSICA : PathArrel = Params.PathMusica
            Case Tipus_Fitxers.FITXER_PUBLICITAT : PathArrel = Params.PathPublicitat
            Case Tipus_Fitxers.FITXER_PROGRAMA : PathArrel = Params.PathProgrames
            Case Else : PathArrel = Params.PathAudioUser 'Tipus_Fitxers.FITXER_AUDIO_USR							
        End Select
        Try
            strPathFitxer = PathArrel & dataGridViewFitxers.CurrentRow.Cells("ColumnID").Value & ".mp3"
            lbAtencio.Visible = Not IO.File.Exists(strPathFitxer)
        Catch ex As Exception
            lbAtencio.Visible = False
        End Try
    End Sub

    Sub TmrPlayerTick(sender As Object, e As EventArgs) Handles tmrPlayer.Tick
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

    Private Sub FindRecord()
        Try
            If IsLoadForm("frmBuscarTemes") = True Then
                frmBuscarTemes.Visible = True
            Else
                frmBuscarTemes.Show(Me)
            End If
            TimerQuery.Enabled = True
        Catch ex As Exception

        End Try
    End Sub

    Sub RecercaAbancadaDeCançonsToolStripMenuItemClick(sender As Object, e As EventArgs) Handles recercaAbancadaDeCançonsToolStripMenuItem.Click
        FindRecord()
    End Sub

    Public Sub getListTemes(Optional ByRef StrSql As String = "")
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.AppStarting

        dataGridViewFitxers.Rows.Clear()
        Dim Origen As String = ""
        If StrSql.Length > 0 Then
            Origen = "SELECT DISTINCT `temes`.`tema_id` as col_id, `temes`.`tema_titol` as col_titol, `interprets`.`interp_nom` as col_subtitol, disc_nom as col_disc , disc_any FROM `temes`,  `interprets` , `discos` WHERE ( `temes`.`tema_interp`=`interprets`.`interp_id` ) AND (tema_disc=disc_id) AND " & StrSql & " ORDER BY `temes`.`tema_titol`, `interprets`.`interp_nom` "
        End If

        Dim db As New MSC.dbs(Cloud)
        Dim dt As DataTable = db.getTable(Origen)
        If Not IsNothing(dt) Then
            For i As Integer = 0 To dt.Rows.Count - 1
                Dim ID As Integer = CInt(dt.Rows(i)("col_id"))
                Dim titol As String = dt.Rows(i)("col_titol").ToString
                Dim subtitol As String = dt.Rows(i)("col_subtitol").ToString
                Dim TitolDisc As String = dt.Rows(i)("col_disc").ToString
                Dim Any As String = dt.Rows(i)("disc_any").ToString


                Dim sCmd As String = "style_relationships_tipfitxer = " & Tipus_Fitxers.FITXER_MUSICA & " AND style_relationships_fitxer = " & ID
                Dim colec() As DataRow = dsClient.Tables("style_relationships").Select(sCmd)
                Dim estil As String = ""
                Try
                    estil = colec(0)("estil_nom").ToString()
                Catch ex As Exception
                    estil = ""
                End Try



                Dim rowIndex As Integer = dataGridViewFitxers.Rows.Add(New String() {ID, False, titol, subtitol, Any, estil})
                dataGridViewFitxers.Rows(rowIndex).Tag = TitolDisc
            Next
        End If
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub


    Sub Mnu_HelpClick(sender As Object, e As EventArgs) Handles mnu_Help.Click
        Dim Proces As Process = New Process
        Try
            Process.Start(MSC.Help.HELP_GEST_AUTOMATITZACIO_EXPORT.ToString)
        Catch ex As Exception
        End Try
    End Sub

    Sub ComboBoxOpcionsSelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxOpcions.SelectedIndexChanged
        refreshListToExport()
    End Sub

    Sub CmdCalcHDClick(sender As Object, e As EventArgs) Handles cmdCalcHD.Click
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.AppStarting
        Cancelled = False
        Me.ProgressBarTasc.Visible = True
        Me.cmdCancel.Visible = True
        Me.cmdSortir.Enabled = False
        cmdExitTool.Enabled = False
        SortirToolStripMenuItem.Enabled = False
        AmbTasquesPendents = True

        Dim Ocupacio As Double = 0
        Dim NumFitxers As Integer = 0
        ProgressBarTasc.Maximum = dataGridViewFitxers.Rows.Count - 1
        Dim PathArrel As String = ""
        Select Case Me.ComboBoxOpcions.SelectedValue
            Case Tipus_Fitxers.FITXER_MUSICA : PathArrel = Params.PathMusica
            Case Tipus_Fitxers.FITXER_PUBLICITAT : PathArrel = Params.PathPublicitat
            Case Tipus_Fitxers.FITXER_PROGRAMA : PathArrel = Params.PathProgrames
            Case Else : PathArrel = Params.PathAudioUser 'Tipus_Fitxers.FITXER_AUDIO_USR							
        End Select

        For i As Integer = 0 To dataGridViewFitxers.Rows.Count - 1
            'If Cancelled Then If MsgBox("Vols cancelar totes les modificacions?", MsgBoxStyle.YesNo, MSG_ATENCIO) = MsgBoxResult.Yes Then Exit For
            Dim sel As Boolean = CBool(dataGridViewFitxers.Rows(i).Cells("ColumnSelect").Value)
            If sel = True Then
                Dim trackID As Integer = dataGridViewFitxers.Rows(i).Cells(0).Value
                Dim PathFitxer As String = PathArrel & "\" & trackID & ".mp3"
                If IO.File.Exists(PathFitxer) Then
                    Dim fFile As New IO.FileInfo(PathFitxer)
                    Ocupacio = Ocupacio + fFile.Length
                    NumFitxers += 1
                End If
            End If
            System.Windows.Forms.Application.DoEvents()
            If Cancelled Then Exit For
            ProgressBarTasc.Value = i
        Next i
        Me.lbInfoHD.Text = MSG_LABEL_TOTAL & " " & NumFitxers.ToString & " , " & MSG_LABEL_ESPAI_NECESSARI & " : " & (Ocupacio \ 1024 + 1).ToString("###,###,###") & " KB"
        Me.ProgressBarTasc.Visible = False
        Me.cmdCancel.Enabled = False
        Me.cmdSortir.Enabled = True
        cmdExitTool.Enabled = True
        SortirToolStripMenuItem.Enabled = True
        AmbTasquesPendents = False

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Cancelled = True
    End Sub

    Private Sub frmExport_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        Dim FitxerINI As New IniFile
        frm_sice(0) = Me.Width : frm_sice(1) = Me.Height
        FitxerINI.INIWrite(MyAPP.IniFile, "Data Gest", "size", frm_sice(0).ToString & "," & frm_sice(1).ToString)
    End Sub

    Private Sub TimerQuery_Tick(sender As Object, e As EventArgs) Handles TimerQuery.Tick

        If IsLoadForm("frmBuscarTemes") = True Then
            If frmBuscarTemes.SqlQuery.Length > 3 Then
                getListTemes(frmBuscarTemes.SqlQuery)
                frmBuscarTemes.SqlQuery = ""
            End If
        End If

    End Sub
End Class
