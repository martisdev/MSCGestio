'
' Creado por SharpDevelop.
' Usuario: Marti
' Fecha: 08/09/2016
' Hora: 09:09
' 
' Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
'
Imports System.Xml 
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports Un4seen.Bass.Misc

Public Partial Class frmJamendo
	
	Private Structure Albums
		Dim id As String 
		Dim name As String
		Dim releasedate As String
		Dim artist_id As String
		Dim artist_name As String
		Dim image_album As String
		Dim zip As String
		Dim shorturl As String
		Dim shareurl As String
		Dim tags As String 
		Dim description As String 
	End Structure
	
	Private Structure AudioTracks
		Dim id As String 
		Dim name As String
		Dim duration As String 				
		Dim artist_id As String
		Dim artist_name As String 
		Dim artist_idstr As String 
		Dim album_name As String 
		Dim album_id As String 				
		Dim licence As String 
		Dim position As String
		Dim releasedate As String 
		Dim album_image As String 		
		Dim audio As String 
		Dim audiodownload As String 		
		Dim prourl As String
		Dim shorturl As String 
		Dim shareurl As String 
		Dim image As String
		Dim musicinfo As MusicInfoTrack
	End Structure
	
	Private Structure MusicInfoTrack
		Dim vocalinstrumental As String 
		Dim lang As String 
		Dim gender As String 
		Dim acousticelectric As String 
		Dim speed As String 
		Dim tagsGenres As String
		Dim tagsInstruments As String
		Dim tagsVartags As String
	End Structure	
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()

        '
        ' TODO : Add constructor code after InitializeComponents
        '
        mnuUrlJamendo.Text = URL_WEB_JAMENDO
    End Sub

    Private Sub CloseForm()
        Dim FitxerINI As New IniFile
        FitxerINI.INIWrite(MyAPP.IniFile, "Data Gest", "jamendo_https", IIf(Me.mnuHTTPS.Checked = True, 1, 0).ToString)

        If Bass.BASS_ChannelIsActive(StreamHandlePlay) = BASSActive.BASS_ACTIVE_PLAYING Then Call Bass.BASS_StreamFree(StreamHandlePlay)

        MyAPP.CloseSesionClient(MyAPP.IDSesion_Client, DESCRIP_FORM_JAMENDO)
        Me.Dispose()
    End Sub

    Sub FrmJamendoFormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CloseForm()
    End Sub




    Dim MyAlbums() As Albums
    Dim Listtracks() As AudioTracks

    Sub MnuLimitClick(sender As Object, e As EventArgs) Handles toolStripMenuItem6.Click, toolStripMenuItem5.Click, toolStripMenuItem4.Click, toolStripMenuItem3.Click, toolStripMenuItem2.Click
        For i As Integer = 0 To mnuLimit.DropDownItems.Count - 1
            CType(mnuLimit.DropDownItems(i), ToolStripMenuItem).Checked = False
        Next

        Dim MyMnu As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
        MyMnu.Checked = Not MyMnu.Checked
        LIMIT_rows = MyMnu.Text
    End Sub

    Private Sub LlistarTracks(URL_REQUEST As String)
        'ensenya detall i llistat de cançons
        lsvTrackList.Items.Clear()
        DeleteDetallTrack()
        Listtracks = Nothing
        Me.cmdRipper.Enabled = False
        cmdImport.Enabled = False

        Dim xmlDoc As New XmlDocument()
        Try
            xmlDoc.Load(URL_REQUEST)
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
            Exit Sub
        End Try

        Dim nodeHeaders As XmlNodeList = xmlDoc.DocumentElement.SelectNodes("headers")
        Dim status As String = nodeHeaders.Item(0).SelectSingleNode("status").InnerText
        lbRecCount.Text = nodeHeaders.Item(0).SelectSingleNode("results_count").InnerText
        If status = "success" Then
            Dim nodeTracks As XmlNodeList = xmlDoc.DocumentElement.SelectNodes("results/tracks/track")
            ReDim Listtracks(nodeTracks.Count - 1)
            For i As Integer = 0 To nodeTracks.Count - 1
                Listtracks(i).id = nodeTracks.Item(i).SelectSingleNode("id").InnerText
                Listtracks(i).name = nodeTracks.Item(i).SelectSingleNode("name").InnerText
                Listtracks(i).duration = nodeTracks.Item(i).SelectSingleNode("duration").InnerText
                Listtracks(i).artist_id = nodeTracks.Item(i).SelectSingleNode("artist_id").InnerText
                Listtracks(i).artist_name = nodeTracks.Item(i).SelectSingleNode("artist_name").InnerText
                Listtracks(i).artist_idstr = nodeTracks.Item(i).SelectSingleNode("artist_idstr").InnerText
                Listtracks(i).album_name = nodeTracks.Item(i).SelectSingleNode("album_name").InnerText
                Listtracks(i).album_id = nodeTracks.Item(i).SelectSingleNode("album_id").InnerText
                Listtracks(i).licence = nodeTracks.Item(i).SelectSingleNode("license_ccurl").InnerText
                Listtracks(i).position = nodeTracks.Item(i).SelectSingleNode("position").InnerText
                Listtracks(i).releasedate = nodeTracks.Item(i).SelectSingleNode("releasedate").InnerText
                Listtracks(i).album_image = nodeTracks.Item(i).SelectSingleNode("album_image").InnerText
                Listtracks(i).audio = nodeTracks.Item(i).SelectSingleNode("audio").InnerText
                Listtracks(i).audiodownload = nodeTracks.Item(i).SelectSingleNode("audiodownload").InnerText
                Listtracks(i).prourl = nodeTracks.Item(i).SelectSingleNode("prourl").InnerText
                Listtracks(i).shorturl = nodeTracks.Item(i).SelectSingleNode("shorturl").InnerText
                Listtracks(i).shareurl = nodeTracks.Item(i).SelectSingleNode("shareurl").InnerText
                Listtracks(i).image = nodeTracks.Item(i).SelectSingleNode("image").InnerText
                Dim nodeMusicInfo As XmlNodeList = nodeTracks.Item(i).SelectNodes("musicinfo")
                For mi As Integer = 0 To nodeMusicInfo.Count - 1
                    Listtracks(i).musicinfo.vocalinstrumental = nodeMusicInfo.Item(mi).SelectSingleNode("vocalinstrumental").InnerText
                    Listtracks(i).musicinfo.lang = nodeMusicInfo.Item(mi).SelectSingleNode("lang").InnerText
                    Listtracks(i).musicinfo.gender = nodeMusicInfo.Item(mi).SelectSingleNode("gender").InnerText
                    Listtracks(i).musicinfo.acousticelectric = nodeMusicInfo.Item(mi).SelectSingleNode("acousticelectric").InnerText
                    Listtracks(i).musicinfo.speed = nodeMusicInfo.Item(mi).SelectSingleNode("speed").InnerText

                    Dim nodegenres As XmlNodeList = nodeMusicInfo.Item(mi).SelectNodes("tags/genres/genre")
                    For g As Integer = 0 To nodegenres.Count - 1
                        If g > 0 Then Listtracks(i).musicinfo.tagsGenres += ","
                        Listtracks(i).musicinfo.tagsGenres += nodegenres.Item(g).InnerText
                    Next

                    Dim nodeInstruments As XmlNodeList = nodeMusicInfo.Item(mi).SelectNodes("tags/instruments/instrument")
                    For ins As Integer = 0 To nodeInstruments.Count - 1
                        If ins > 0 Then Listtracks(i).musicinfo.tagsInstruments += ","
                        Listtracks(i).musicinfo.tagsInstruments += nodeInstruments.Item(ins).InnerText
                    Next

                    Dim nodevartag As XmlNodeList = nodeMusicInfo.Item(mi).SelectNodes("tags/vartags/vartag")
                    For vt As Integer = 0 To nodeInstruments.Count - 1
                        If vt > 0 Then Listtracks(i).musicinfo.tagsVartags += ","
                        Try
                            Listtracks(i).musicinfo.tagsVartags += nodevartag.Item(vt).InnerText
                        Catch ex As Exception
                        End Try
                    Next
                Next

                Dim data(5) As String
                data(0) = Listtracks(i).name
                data(1) = Listtracks(i).artist_name
                data(2) = Listtracks(i).album_name
                data(3) = Un4seen.Bass.Utils.FixTimespan(CDbl(Listtracks(i).duration), "HHMMSS")
                data(4) = CDate(Listtracks(i).releasedate).ToString("yyyy")
                Dim item As New ListViewItem(data)
                item.Tag = Listtracks(i).audio
                lsvTrackList.Items.Add(item)
                Application.DoEvents()
            Next
            Me.cmdRipper.Enabled = (nodeTracks.Count > 0)
            cmdImport.Enabled = cmdRipper.Enabled
        Else
            Dim code As String = nodeHeaders.Item(0).SelectSingleNode("code").InnerText
            Dim error_message As String = nodeHeaders.Item(0).SelectSingleNode("error_message").InnerText
            Dim warnings As String = nodeHeaders.Item(0).SelectSingleNode("warnings").InnerText
            Dim results_count As String = nodeHeaders.Item(0).SelectSingleNode("results_count").InnerText
            Dim InfoRequest As String = MSG_ERROR_QUERY & "Status:" & status & " Code:" & code & " Message:" & error_message & " warning:" & warnings & " results:" & results_count
            MetroFramework.MetroMessageBox.Show(Me, InfoRequest, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Information, 100)
            Me.cmdRipper.Enabled = False
            cmdImport.Enabled = cmdRipper.Enabled
        End If
    End Sub

    Sub ListViewTemesClick(sender As Object, e As EventArgs)
        'Detall
        Dim Id As Integer = lsvTrackList.FocusedItem.Index
    End Sub

    Function ListView_AddProgressBar(ByRef pListView As System.Windows.Forms.ListView, ByVal ListViewItemIndex As Integer, ByVal ColumnIndex As Integer) As MetroFramework.Controls.MetroProgressBar
        Dim r As Rectangle
        Dim pb As New MetroFramework.Controls.MetroProgressBar
        'AddHandler pb.Click, AddressOf Click_BotoTack

        r = pListView.Items(ListViewItemIndex).Bounds()
        r.Width = pListView.Columns(ColumnIndex).Width
        If ColumnIndex > 0 Then
            r.X = r.X + pListView.Columns(ColumnIndex - 1).Width
        End If
        pb.Parent = pListView
        pb.SetBounds(r.X, r.Y, r.Width, r.Height)
        pb.HideProgressText = False
        pb.TextAlign = ContentAlignment.MiddleCenter
        pb.Visible = True
        Return pb
    End Function

    Sub CmdRipperClick(sender As Object, e As EventArgs) Handles cmdRipper.Click, cmdImport.Click

        If MyAPP.PermisPerContinuar() = False Then MetroFramework.MetroMessageBox.Show(Me, MSG_SERVER_CLOSE, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Stop, 100) : Exit Sub
        BlokUnblokPantalla(False)

        Cancelled = False

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.AppStarting
        'ProgressRipper.Maximum = Me.lsvTrackList.Items.Count
        For i As Integer = 0 To Me.lsvTrackList.Items.Count - 1

            If lsvTrackList.Items.Item(i).Checked = True Then
                lsvTrackList.Items.Item(i).ForeColor = Color.Silver
                Dim pb As New MetroFramework.Controls.MetroProgressBar
                pb = ListView_AddProgressBar(lsvTrackList, i, 2)
                pb.Maximum = 100
                pb.Value = 1


                'lsvTrackList.Items.Item(i).ForeColor = Color.Silver
                Dim db As New MSC.dbs(Cloud)
                Dim SqlStr As String = ""

                Dim path As String = Listtracks(i).audiodownload
                Dim Duration As Date = CDate(lsvTrackList.Items.Item(i).SubItems(3).Text)
                Dim Proveidor As Integer = getIDProveidor("Jamendo.com")
                Dim AnyPubli As Short = CShort(lsvTrackList.Items.Item(i).SubItems.Item(4).Text)

                Dim estilsstr() As String = Split(Listtracks(i).musicinfo.tagsGenres, ",")
                Dim Estil As Long = 0
                Try
                    Estil = getIDEstil(estilsstr(0).Trim)
                    If Estil = 0 Then
                        'S'ha de crear
                        SqlStr = "INSERT INTO estils (estil_nom, estil_visible) VALUES ('" & AddSlashes(estilsstr(0)) & "',1);"
                        Estil = db.New_ID(SqlStr)
                        RefreshDataSet(TAULES_DBS.TAULA_ESTILS)
                    End If
                Catch ex As Exception
                    Estil = 0
                End Try
                pb.Value = 2
                'BUSCAR SI JA EXISTEIX A LA DBS
                Dim StrInterp As String = AddSlashes(lsvTrackList.Items.Item(i).SubItems.Item(1).Text)
                Dim Interp As Short
                SqlStr = "SELECT interp_id FROM interprets WHERE interp_nom = '" & StrInterp & "' "

                Dim rs As DataTable = db.getTable(SqlStr)
                If rs.Rows.Count = 1 Then
                    Interp = CShort(rs.Rows(0)(0)) 'OK
                    'TODO: 'problema n'ha trobat més d'un
                ElseIf rs.Rows.Count > 1 Then
                    Interp = CShort(rs.Rows(0)(0))
                ElseIf rs.Rows.Count = 0 Then
                    SqlStr = "INSERT INTO interprets (interp_nom ) VALUES ('" & StrInterp & "');"
                    Interp = db.New_ID(SqlStr) 's'ha de crear nou
                    RefreshDataSet(TAULES_DBS.TAULA_INTERPRETS)
                End If
                pb.Value = 3
                'Disc
                Static Disc_jamendo As Integer
                Static Disc_id As Long
                If Disc_jamendo = Listtracks(i).album_id Then
                    'ja l'hem fet avans ja hi ha assignat Disc_id				
                Else
                    'No està fet o ha canviat
                    'comprovem existècia 
                    Disc_id = getIDDisc(Listtracks(i).album_name)
                    'creem
                    If Disc_id = 0 Then
                        'S'ha de crear
                        SqlStr = "INSERT INTO discos ( disc_datain , disc_any, disc_nom," &
                            "disc_numtracs, disc_format, disc_estil, " &
                            " disc_interpret,disc_web,disc_comentari,disc_propietari)" &
                            " values (" &
                            "'" & Now.ToString("yyyy-MM-dd HH:mm:ss") & "'" &
                            ", " & AnyPubli &
                            ", '" & AddSlashes(Listtracks(i).album_name) & "'" &
                            ", " & Me.lsvTrackList.Items.Count &
                            ", " & formats.MP3 &
                            ", " & Estil &
                            ", " & Interp &
                            ",' '" &
                            ",' '" &
                            ", " & Proveidor &
                            ");"

                        Application.DoEvents()
                        Disc_id = db.New_ID(SqlStr)

                        Dim cover As Image = getImageFromURL(Listtracks(i).album_image)
                        InsertPig(Disc_id, cover)

                        RefreshDataSet(TAULES_DBS.TAULA_DISCOS)
                    End If
                    Disc_jamendo = CInt(Listtracks(i).album_id)
                End If
                Dim Titol As String = AddSlashes(lsvTrackList.Items.Item(i).Text)
                If Len(Titol) >= 50 Then Titol = Strings.Left(Titol, 46) & "..."

                'Dim Disc As Short '= IIf(Len(cbDisc.SelectedIndex) > 0, Me.cbDisc.SelectedValue, 0)								
                pb.Value = 4
                Dim Idioma As Integer = getIDLangFromCode(Listtracks(i).musicinfo.lang)
                Dim Backup As Short = 0

                SqlStr = "INSERT INTO temes (tema_interp, tema_disc "
                SqlStr = SqlStr & ", tema_idioma, tema_durada, tema_titol, tema_any, tema_datain,tema_pautain,tema_compositor)"
                SqlStr = SqlStr & " VALUES "
                SqlStr = SqlStr & "( " & Interp
                SqlStr = SqlStr & ", " & Disc_id
                SqlStr = SqlStr & ", " & Idioma
                SqlStr = SqlStr & ", '" & Duration.ToString("HH:mm:ss") & "'"
                SqlStr = SqlStr & ", '" & Titol & "'"
                SqlStr = SqlStr & ", " & AnyPubli
                SqlStr = SqlStr & ", '" & Now.ToString("yyyy-MM-dd HH:mm:ss") & "'"
                SqlStr = SqlStr & ", " & IIf(Params.FilesActives, 1, 0).ToString
                SqlStr = SqlStr & ", ' '"
                SqlStr = SqlStr & ");"

                'Codifica el fitxer
                Application.DoEvents()
                Dim new_id As Long = db.New_ID(SqlStr)

                If estilsstr.Length > 0 Then
                    Dim estils_ids(estilsstr.Length - 1) As Integer
                    For r As Integer = 0 To estilsstr.Length - 1
                        Dim tempstl As Integer = getIDEstil(estilsstr(r))
                        If tempstl = 0 Then
                            SqlStr = "INSERT INTO estils (estil_nom, estil_visible) VALUES ('" & estilsstr(r) & "',1);"
                            tempstl = CInt(db.New_ID(SqlStr))
                        End If
                        estils_ids(r) = tempstl
                    Next
                    Dim strValues As String = ""
                    For p As Integer = 0 To estils_ids.Length - 1
                        If strValues.Length > 3 Then strValues += ","
                        strValues += "( " & Tipus_Fitxers.FITXER_MUSICA & "," & new_id & "," & estils_ids(p) & ")"
                    Next
                    SqlStr = "INSERT INTO style_relationships (`style_relationships_tipfitxer`,style_relationships_fitxer,`style_relationships_style`) VALUES " & strValues
                    db.New_ID(SqlStr)
                    RefreshDataSet(TAULES_DBS.TAULA_STYLE_RELATIONSHIPS)
                End If
                pb.Value = 5
                'insert into music_jamendo
                SqlStr = "INSERT INTO music_jamendo (`mj_msc_id`,`mj_jamendo_id`,`mj_jamendo_artist`,`mj_jamendo_album`, `mj_jamendo_shareurl`) VALUES (" & new_id & ",'" & Listtracks(i).id & "','" & Listtracks(i).artist_id & "','" & Listtracks(i).album_id & "','" & Listtracks(i).shareurl & "');"
                db.New_ID(SqlStr)
                Dim FitxerDesti As String = Params.PathMusica & new_id & ".mp3"

                EncodeFile(path, FitxerDesti, pb)

                Dim BPM As Single = getBPMFitxer(FitxerDesti, Me.Handle)
                If BPM > 0 Then
                    SqlStr = "UPDATE `temes` SET `tema_ritme`=" & CInt(BPM).ToString & " WHERE `tema_id`=" & new_id & " ;"
                    db.Update_ID(SqlStr)
                End If


                pb.Visible = False
                pb = Nothing
            End If
        Next

        ' Feina feta, Borra els que he seleccionats a la llista.
        For counter As Integer = lsvTrackList.Items.Count - 1 To 0 Step -1
            If lsvTrackList.Items.Item(counter).ForeColor = Color.Silver Then
                lsvTrackList.Items.RemoveAt(counter)
                'TODO : Listtracks.RemoveAt(counter)				
            End If
        Next

        BlokUnblokPantalla(True)
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub EncodeFile(remoteURI As String, PathDesti As String, ProgressRipper As MetroFramework.Controls.MetroProgressBar)
        Dim stream As Integer = Bass.BASS_StreamCreateURL(remoteURI, 0, BASSFlag.BASS_STREAM_DECODE, Nothing, 0)
        With ProgressRipper
            Dim sLength As Single = Bass.BASS_ChannelBytes2Seconds(stream, Bass.BASS_ChannelGetLength(stream))
            Try
                .Maximum = sLength
                .Value = 0
            Catch ex As Exception
            End Try
        End With

        Dim OptBitRate As EncoderLAME.BITRATE
        Select Case Params.BitRate
            Case "32" : OptBitRate = EncoderLAME.BITRATE.kbps_32
            Case "56" : OptBitRate = EncoderLAME.BITRATE.kbps_56
            Case "80" : OptBitRate = EncoderLAME.BITRATE.kbps_80
            Case "128" : OptBitRate = EncoderLAME.BITRATE.kbps_128
            Case "192" : OptBitRate = EncoderLAME.BITRATE.kbps_192
            Case "224" : OptBitRate = EncoderLAME.BITRATE.kbps_224
            Case "256" : OptBitRate = EncoderLAME.BITRATE.kbps_256
            Case "320" : OptBitRate = EncoderLAME.BITRATE.kbps_320
        End Select
        Dim OptSampleRate As Single
        Bass.BASS_ChannelGetAttribute(stream, BASSAttribute.BASS_ATTRIB_FREQ, OptSampleRate)
        Dim OptAudioChannels As EncoderLAME.LAMEMode = EncoderLAME.LAMEMode.Stereo

        Dim l As New EncoderLAME(stream)
        l.InputFile = Nothing 'STDIN
        l.OutputFile = PathDesti
        l.LAME_Bitrate = CInt(OptBitRate)
        l.LAME_Mode = OptAudioChannels
        l.LAME_TargetSampleRate = CInt(OptSampleRate)
        l.LAME_Quality = EncoderLAME.LAMEQuality.Quality
        l.Start(Nothing, IntPtr.Zero, False)
        ' decode the stream (if not using a decoding channel, simply call "Bass.BASS_ChannelPlay" here) 
        Dim encBuffer(65536) As Byte ' our dummy encoder buffer 
        While Bass.BASS_ChannelIsActive(stream) = BASSActive.BASS_ACTIVE_PLAYING
            ' getting sample data will automatically feed the encoder 
            Dim len As Integer = Bass.BASS_ChannelGetData(stream, encBuffer, encBuffer.Length)
            Dim Pos As Single = Bass.BASS_ChannelBytes2Seconds(stream, Bass.BASS_ChannelGetPosition(stream))
            ProgressRipper.Value = Pos
            Application.DoEvents()
            Threading.Thread.Sleep(1)
        End While
        l.Stop() ' finish
        Bass.BASS_StreamFree(stream)

    End Sub

    Dim Cancelled As Boolean

    Private Sub BlokUnblokPantalla(blEnableas As Boolean)
        cmdHideExit.Enabled = blEnableas
        Me.cmdSortir.Enabled = blEnableas
        cmdBuscar.Enabled = blEnableas
        Me.cmdPlay.Enabled = blEnableas
        Me.mnuPlay.Enabled = blEnableas
        AmbTasquesPendents = Not blEnableas
        Me.cmdRipper.Enabled = blEnableas
    End Sub

    Sub LsvTrackListResize(sender As Object, e As EventArgs) Handles lsvTrackList.Resize
        CType(sender, ListView).Columns(0).Width = CType(sender, ListView).Width \ 3.5
        CType(sender, ListView).Columns(1).Width = CType(sender, ListView).Width \ 3.5
    End Sub

    Sub FrmJamendoLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim FitxerINI As New IniFile
        Me.mnuHTTPS.Checked = CBool(FitxerINI.INIRead(MyAPP.IniFile, "Data Gest", "jamendo_https", "1"))

        setLanguageForm()
        Me.ClientSize = New Size(frm_sice(0), frm_sice(1))
    End Sub

    Dim MSG_ERROR_QUERY As String
    Dim LABEL_FILTERS As String

    Public Sub setLanguageForm()
        lang.StrForm = Me.Name

        MSG_ERROR_QUERY = lang.getText("MSG_ERROR_QUERY") '"Info consulta" & " => "
        LABEL_FILTERS = lang.getText("LABEL_FILTERS") & ":" '"Filtre:" 


        Me.mnuApplication.Text = lang.getText("LABEL_PROGRAMA", True) '"Programa"
        Me.mnuAppExit.Text = lang.getText("LABEL_EXIT", True) '"Sortir"
        Me.mnuHelp.Text = lang.getText("mnu_Help", True) '"Ajuda        
        Me.mnuHelpManual.Text = lang.getText("mnuRefHelp.Text", True) '"Manual OnLine"

        ' Me.cmdSortir.Text = lang.getText("LABEL_EXIT", True) '"Sortir"


        Me.mnuPlayer.Text = lang.getText("LABEL_REPRODUCTOR", True) '"Reproductor"
        Me.mnuPlay.Text = lang.getText("LABEL_PLAY_PAUSA", True) '"Play/Pausa"
        Me.cmdPlay.ToolTipText = mnuPlay.Text
        Me.mnuStop.Text = lang.getText("LABEL_STOP", True) '"Stop"
        Me.cmdStop.ToolTipText = mnuStop.Text
        Me.mnuEndTrack.Text = lang.getText("LABEL_END_TEMA", True) '"Final Tema"

        Me.cmdRipper.Text = lang.getText("cmdRipper.Text") '"Importar"
        Me.cmdRipper.ToolTipText = lang.getText("cmdRipper.ToolTipText") '"Importar / Codificar fitxers"

        Me.ColumnHeader1.Text = lang.getText("HEADERTEXT_TITOL", True) '"Títol"
        Me.ColumnHeader2.Text = lang.getText("HEADERTEXT_INTERP", True) '"Intèrpret"
        Me.ColumnHeader3.Text = lang.getText("HEADERTEXT_DURADA", True) '"Durada"
        Me.ColumnHeader4.Text = lang.getText("HEADERTEXT_ANY", True) '"Any"
        Me.label13.Text = lang.getText("HEADERTEXT_ESTIL", True) & ":" '"Estil"
        Me.label11.Text = lang.getText("HEADERTEXT_TITOL", True) & ":" '"Títol"
        Me.cmdBuscar.Text = lang.getText("LABEL_BUSCAR", True) '"Buscar"
        Me.cmdBuscar.ToolTipText = lang.getText("LABEL_BUSCAR", True) '"Buscar"
        Me.columnHeader6.Text = lang.getText("HEADERTEXT_DISC", True) '"Àlbum"		
        Me.label12.Text = lang.getText("HEADERTEXT_INTERP", True) & ":" '"Intèrpret"
        Me.label9.Text = lang.getText("DATA_PUBLICACIO", True) & ":" '"Data publicació:"
        Me.label1.Text = lang.getText("HEADERTEXT_DISC", True) & ":" '"Àlbum:"

        Me.mnuFilterBy.Text = lang.getText("mnuFilterBy.Text") '"Filtrar per"
        Me.popularitatToolStripMenuItem.Text = lang.getText("popularitatToolStripMenuItem.Text") '"Popularitat"
        Me.escoltadesToolStripMenuItem.Text = lang.getText("escoltadesToolStripMenuItem.Text") '"Escoltades"		
        Me.bbaixadesToolStripMenuItem.Text = lang.getText("bbaixadesToolStripMenuItem.Text") '"Baixades"		
        Me.emergentsToolStripMenuItem.Text = lang.getText("emergentsToolStripMenuItem.Text") '"Emergents"
        Me.lesMésPopularsToolStripMenuItem.Text = lang.getText("LABEL_TOTAL", True) '"Total"
        Me.lesMésEscoltadesToolStripMenuItem.Text = lang.getText("LABEL_TOTAL", True) '"Total"
        Me.lesMesBaixadesToolStripMenuItem.Text = lang.getText("LABEL_TOTAL", True) '"Total"
        Me.delMesToolStripMenuItem2.Text = lang.getText("LABEL_MENSUAL") '"Mensual"
        Me.delMesToolStripMenuItem1.Text = lang.getText("LABEL_MENSUAL") '"Mensual"
        Me.delMesToolStripMenuItem.Text = lang.getText("LABEL_MENSUAL") '"Total"'"Mensual"
        Me.deLaSetmanaToolStripMenuItem2.Text = lang.getText("LABEL_SETMANAL") '"Setmanal"
        Me.deLaSetmanaToolStripMenuItem1.Text = lang.getText("LABEL_SETMANAL") '"Setmanal"
        Me.deLaSetmanaToolStripMenuItem.Text = lang.getText("LABEL_SETMANAL") '"Setmanal"		
        Me.mnuLimit.Text = lang.getText("mnuLimit.Text") '"Limitador"
        Me.nomArtistaToolStripMenuItem.Text = lang.getText("nomArtistaToolStripMenuItem.Text") '"Buscar Artista:"
        Me.nomÀlbumToolStripMenuItem.Text = lang.getText("nomÀlbumToolStripMenuItem.Text") '"Buscar Àlbum"
        Me.buscarTotToolStripMenuItem.Text = lang.getText("buscarTotToolStripMenuItem.Text") '"Buscar Tot"		
        Me.cmdCheck.ToolTipText = lang.getText("cmdCheck.Text") '"Seleccionar tot"		
        Me.groupBox2.Text = lang.getText("groupBox2.Text") '"Detall cançó"
        Me.label3.Text = lang.getText("label3.Text") & ":" '"acousticelectric:"
        Me.label4.Text = lang.getText("label4.Text") & ":" '"speed:"
        Me.label2.Text = lang.getText("label2.Text") & ":" '"gender:"
        Me.label15.Text = lang.getText("LABEL_TAGS", True) & ":" '"Tags:"
        Me.label14.Text = lang.getText("label14.Text") & ":" '"Instruments:"		
        Me.cmbBuscaTracksSimilar.Text = lang.getText("cmbBuscaTracksSimilar.Text") '"Buscar semblants"		
        Me.label10.Text = lang.getText("LABEL_WEB", True) & ":" '"Link:"		
        Me.label8.Text = lang.getText("label8.Text") & ":" '"Llicència:"		

        mnuHTTPS.Text = lang.getText("mnuHTTPS.Text")  '"Connexió segura HTTPS"		
        Me.Text = lang.getText("Text") '"Importar procedent de Jamendo.com"

    End Sub

#Region "Player"

    Dim VolMax As Single
    Dim Atack As Integer = 50
    Dim StreamHandlePlay As Integer
    Dim InSrolling As Boolean
    Dim isActive As Un4seen.Bass.BASSActive

    Sub ListViewTemesDoubleClick(sender As Object, e As EventArgs) Handles lsvTrackList.DoubleClick
        'TODO: Poder millor editar
        stopFitxer()
        PlayFitxer()
    End Sub

    Private Sub PlayFitxer()
        isActive = Bass.BASS_ChannelIsActive(StreamHandlePlay)
        If isActive = BASSActive.BASS_ACTIVE_PLAYING Then
            Bass.BASS_ChannelPause(StreamHandlePlay)
        ElseIf isActive = BASSActive.BASS_ACTIVE_PAUSED Then
            Bass.BASS_ChannelPlay(StreamHandlePlay, False)
        Else
            If lsvTrackList.Items.Count = 0 Then Exit Sub
            Dim Id As Integer
            Dim StrPathPlay As String
            Try
                Id = lsvTrackList.FocusedItem.Index
            Catch ex As Exception
                Id = 0
            Finally
                StrPathPlay = lsvTrackList.Items(Id).Tag.ToString
            End Try
            Bass.BASS_ChannelStop(StreamHandlePlay)
            StreamHandlePlay = Bass.BASS_StreamCreateURL(StrPathPlay, 0, BASSFlag.BASS_STREAM_AUTOFREE, Nothing, IntPtr.Zero)
            If StreamHandlePlay = 0 Then
                'Dim err As BASSError = Bass.BASS_ErrorGetCode()
                'MsgBox(StrPathPlay & " hl:" & StreamHandlePlay & " Err:" & err.ToString)                
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
        picVuMeter.BackgroundImage = bit
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

    Sub CmdStopClick(sender As Object, e As EventArgs)
        stopFitxer()
    End Sub

    Sub CmdPlayClick(sender As Object, e As EventArgs)
        PlayFitxer()
    End Sub

    Sub MnuPlayClick(sender As Object, e As EventArgs) Handles mnuStop.Click, mnuEndTrack.Click, mnuPlay.Click
        Select Case CInt(CType(sender, ToolStripMenuItem).Tag)
            Case 1 : PlayFitxer()
            Case 2 : stopFitxer()
            Case 3
                Dim len As Long = Bass.BASS_ChannelGetLength(StreamHandlePlay)
                Dim LenInSeg As Double = Bass.BASS_ChannelBytes2Seconds(StreamHandlePlay, len)
                Bass.BASS_ChannelSetPosition(StreamHandlePlay, CSng(LenInSeg - 20))
        End Select
    End Sub

    Sub PicVuMeterMouseClick(sender As Object, e As MouseEventArgs) Handles picVuMeter.MouseClick
        'estableix la posicio del ratolí a sobre el Pig
        Dim len As Long = Bass.BASS_ChannelGetLength(StreamHandlePlay)
        Dim bpp As Double = len / CType(Me.picVuMeter.Width, Double) ' bytes per pixel        
        'Quin és el pixel on es troba el ratolí
        Dim pr As Integer = 0
        Dim LocalMousePosition As Point = picVuMeter.PointToClient(System.Windows.Forms.Cursor.Position)
        'Posició on s'ha de desplaçar        
        Dim PosADespla As Double = Bass.BASS_ChannelBytes2Seconds(StreamHandlePlay, CLng(LocalMousePosition.X * bpp))
        'Desplaçar-ho
        Bass.BASS_ChannelSetPosition(StreamHandlePlay, PosADespla)
    End Sub

#End Region

#Region "RequestJamendo"

    Dim URL_TRACKS As String = "tracks/"
    Dim URL_SIMILAR As String = "similar/"
    Dim URL_FILTER As String = "&boost=buzzrate" 'Per defecte emergents
    Dim LIMIT_rows As Integer = 25

    Sub CmdBuscarClick(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        'Sempre busquem tracks
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.AppStarting
        cmdBuscar.Enabled = False

        Dim URL_REQUEST As String = IIf(mnuHTTPS.Checked = True, URL_API_JAMENDO_HTTPS, URL_API_JAMENDO_HTTP).ToString & VERSION_API_JAMENDO & URL_TRACKS & "?client_id=" & CLIENT_ID_JAMENDO & "&format=" & FORMAT_DOC & "&limit=" & LIMIT_rows & "&include=musicinfo" & URL_FILTER
        LlistarTracks(URL_REQUEST)

        cmdBuscar.Enabled = True
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    Sub CmbBuscaTracksSimilarClick(sender As Object, e As EventArgs) Handles cmbBuscaTracksSimilar.Click
        If CInt(Me.lbID.Text) = 0 Then Exit Sub
        Dim URL_REQUEST As String = IIf(mnuHTTPS.Checked = True, URL_API_JAMENDO_HTTPS, URL_API_JAMENDO_HTTP).ToString & VERSION_API_JAMENDO & URL_TRACKS & URL_SIMILAR &
            "?client_id=" & CLIENT_ID_JAMENDO & "&format=" & FORMAT_DOC &
            "&limit=" & LIMIT_rows & "&include=musicinfo" &
            "&id=" & Me.lbID.Text &
            "&no_artist=" & lbDT_interp.Tag.ToString

        LlistarTracks(URL_REQUEST)
    End Sub

    Sub LbDT_interpClick(sender As Object, e As EventArgs) Handles lbDT_interp.Click
        If CInt(Me.lbID.Text) = 0 Then Exit Sub
        Dim URL_REQUEST As String = IIf(mnuHTTPS.Checked = True, URL_API_JAMENDO_HTTPS, URL_API_JAMENDO_HTTP).ToString & VERSION_API_JAMENDO & URL_TRACKS &
            "?client_id=" & CLIENT_ID_JAMENDO & "&format=" & FORMAT_DOC &
            "&limit=" & LIMIT_rows & "&include=musicinfo" &
            "&artist_id=" & Me.lbDT_interp.Tag.ToString

        LlistarTracks(URL_REQUEST)
    End Sub

    Sub linkTag_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

        Dim MyLink As LinkLabel = CType(sender, LinkLabel)
        Dim URL_REQUEST As String = IIf(mnuHTTPS.Checked = True, URL_API_JAMENDO_HTTPS, URL_API_JAMENDO_HTTP).ToString & VERSION_API_JAMENDO & URL_TRACKS &
            "?client_id=" & CLIENT_ID_JAMENDO & "&format=" & FORMAT_DOC &
            "&limit=" & LIMIT_rows & "&include=musicinfo" &
            "&tags=" & MyLink.Text

        LlistarTracks(URL_REQUEST)
    End Sub

    Sub LbDT_AlbumLinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbDT_Album.LinkClicked
        If Me.lbID.Text = 0 Then Exit Sub
        Dim URL_REQUEST As String = IIf(mnuHTTPS.Checked = True, URL_API_JAMENDO_HTTPS, URL_API_JAMENDO_HTTP).ToString & VERSION_API_JAMENDO & URL_TRACKS &
            "?client_id=" & CLIENT_ID_JAMENDO & "&format=" & FORMAT_DOC &
            "&limit=" & LIMIT_rows & "&include=musicinfo" &
            "&album_id=" & lbDT_Album.Tag.ToString

        LlistarTracks(URL_REQUEST)
    End Sub

    Sub LbDT_SpeedLinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbDT_Speed.LinkClicked, lbDT_gender.LinkClicked, lbDT_acusticelectic.LinkClicked
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.AppStarting
        cmdBuscar.Enabled = False
        Dim MyLink As LinkLabel = CType(sender, LinkLabel)
        Dim URL_REQUEST As String = IIf(mnuHTTPS.Checked = True, URL_API_JAMENDO_HTTPS, URL_API_JAMENDO_HTTP).ToString & VERSION_API_JAMENDO & URL_TRACKS &
            "?client_id=" & CLIENT_ID_JAMENDO & "&format=" & FORMAT_DOC &
            "&limit=" & LIMIT_rows & "&include=musicinfo" &
            "&search=" & MyLink.Text

        LlistarTracks(URL_REQUEST)

        cmdBuscar.Enabled = True
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

#End Region


    Sub LsvTrackListSelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvTrackList.SelectedIndexChanged
        'Oplim el detall del track
        If lsvTrackList.SelectedItems.Count = 0 Then Exit Sub
        Dim id_track As Integer = Me.lsvTrackList.SelectedItems(0).Index
        ShowDetallTrack(id_track)
    End Sub

    Private Sub ShowDetallTrack(track_id As Integer)
        DeleteDetallTrack()
        lbID.Text = Listtracks(track_id).id
        Me.lbDT_Titol.Text = Listtracks(track_id).name
        Me.lbDT_interp.Text = Listtracks(track_id).artist_name
        Me.lbDT_interp.Tag = Listtracks(track_id).artist_id
        Me.lbDT_Album.Text = Listtracks(track_id).album_name
        lbDT_Album.Tag = Listtracks(track_id).album_id
        Me.lbDT_llicencia.Text = Listtracks(track_id).licence
        Me.lbDT_DataPublicacio.Text = Listtracks(track_id).releasedate
        Me.lbDT_shareURL.Text = Listtracks(track_id).shorturl
        Me.lbDT_gender.Text = Listtracks(track_id).musicinfo.gender
        Me.lbDT_acusticelectic.Text = Listtracks(track_id).musicinfo.acousticelectric
        Me.lbDT_Speed.Text = Listtracks(track_id).musicinfo.speed


        If Listtracks(track_id).album_image.Length > 1 Then
            Dim imgAlbum As Image = getImageFromURL(Listtracks(track_id).album_image)
            picDT_Image.Image = imgAlbum
        Else
            picDT_Image.Image = Nothing
        End If
        'tags estils		
        Dim estils() As String = Split(Listtracks(track_id).musicinfo.tagsGenres, ",")
        For i As Integer = 0 To estils.Length - 1
            Dim linktag As New LinkLabel
            linktag.Parent = listTagsEstil
            linktag.Text = estils(i)
            linktag.AutoSize = True
            AddHandler linktag.LinkClicked, AddressOf linkTag_LinkClicked
        Next
        'tags instruments		
        Dim instruments() As String = Split(Listtracks(track_id).musicinfo.tagsInstruments, ",")
        For i As Integer = 0 To instruments.Length - 1
            Dim linktag As New LinkLabel
            linktag.Parent = Me.listTagsInstruments
            linktag.Text = instruments(i)
            linktag.AutoSize = True
            AddHandler linktag.LinkClicked, AddressOf linkTag_LinkClicked
        Next
        'Tags varis		
        Dim varis() As String = Split(Listtracks(track_id).musicinfo.tagsVartags, ",")
        For i As Integer = 0 To varis.Length - 1
            Dim linktag As New LinkLabel
            linktag.Parent = Me.listTagsVaris
            linktag.Text = varis(i)
            linktag.AutoSize = True
            AddHandler linktag.LinkClicked, AddressOf linkTag_LinkClicked
        Next

    End Sub

    Private Sub DeleteDetallTrack()
        lbID.Text = "0"
        lbDT_Titol.Text = ""
        lbDT_interp.Text = ""
        Me.lbDT_Album.Text = ""
        lbDT_Album.Tag = ""
        Me.lbDT_llicencia.Text = ""
        Me.lbDT_DataPublicacio.Text = ""
        Me.lbDT_shareURL.Text = ""
        picDT_Image.Image = Nothing
        listTagsEstil.Controls.Clear()
        listTagsInstruments.Controls.Clear()
        listTagsVaris.Controls.Clear()
        Me.lbDT_gender.Text = ""
        Me.lbDT_acusticelectic.Text = ""
        Me.lbDT_Speed.Text = ""
    End Sub

    Sub MnuFilterByButtonClick(sender As Object, e As EventArgs) Handles lesMésPopularsToolStripMenuItem.Click, lesMésEscoltadesToolStripMenuItem.Click, lesMesBaixadesToolStripMenuItem.Click, emergentsToolStripMenuItem.Click, delMesToolStripMenuItem2.Click, delMesToolStripMenuItem1.Click, delMesToolStripMenuItem.Click, deLaSetmanaToolStripMenuItem2.Click, deLaSetmanaToolStripMenuItem1.Click, deLaSetmanaToolStripMenuItem.Click

        For Each mnuItem As ToolStripMenuItem In mnuFilterBy.DropDownItems
            mnuItem.Checked = False
            Try
                For Each mnuSubItem As ToolStripMenuItem In mnuItem.DropDownItems
                    If mnuSubItem.GetType Is GetType(ToolStripMenuItem) Then mnuSubItem.Checked = False
                Next
            Catch ex As Exception
            End Try
        Next

        Dim MyMnu As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
        MyMnu.Checked = Not MyMnu.Checked

        Select Case CInt(MyMnu.Tag)
            Case 1 : URL_FILTER = "&boost=popularity_total" '			
            Case 2 : URL_FILTER = "&boost=popularity_week" '
            Case 3 : URL_FILTER = "&boost=popularity_month" '
            Case 4 : URL_FILTER = "&boost=listens_total" '
            Case 5 : URL_FILTER = "&boost=listens_week" '
            Case 6 : URL_FILTER = "&boost=listens_month" '
            Case 7 : URL_FILTER = "&boost=downloads_total" '
            Case 8 : URL_FILTER = "&boost=downloads_week" '
            Case 9 : URL_FILTER = "&boost=downloads_month" '
            Case 10 : URL_FILTER = "&boost=buzzrate" '
        End Select
        mnuFilterBy.Text = LABEL_FILTERS & " " & MyMnu.OwnerItem.Text & " - " & MyMnu.Text
    End Sub

    Sub TxtBuscarTotKeyUp(sender As Object, e As KeyEventArgs) Handles txtNomArtista.KeyUp, txtNomAlbum.KeyUp, txtBuscarTot.KeyUp
        If e.KeyCode = Keys.Enter Then
            For Each mnuItem As ToolStripMenuItem In mnuFilterBy.DropDownItems
                mnuItem.Checked = False
                Try
                    For Each mnuSubItem As ToolStripMenuItem In mnuItem.DropDownItems
                        mnuSubItem.Checked = False
                    Next
                Catch ex As Exception
                    Exit For
                End Try
            Next
            Dim MyMnu As ToolStripTextBox = CType(sender, ToolStripTextBox)
            Select Case MyMnu.Name
                Case "txtNomArtista"
                    URL_FILTER = "&artist_name=" & MyMnu.Text.ToString.Replace(" ", "+")
                    Me.txtNomAlbum.Text = ""
                    Me.txtBuscarTot.Text = ""
                Case "txtNomAlbum"
                    URL_FILTER = "&album_name=" & MyMnu.Text.ToString.Replace(" ", "+")
                    Me.txtNomArtista.Text = ""
                    Me.txtBuscarTot.Text = ""
                Case "txtBuscarTot"
                    URL_FILTER = "&search=" & MyMnu.Text.ToString.Replace(" ", "+")
                    Me.txtNomArtista.Text = ""
                    Me.txtNomAlbum.Text = ""
            End Select
            mnuFilterBy.Text = LABEL_FILTERS & " " & MyMnu.OwnerItem.Text & " - " & MyMnu.Text
        End If
    End Sub

    Sub LbDT_shareURLLinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbDT_shareURL.LinkClicked, lbDT_llicencia.LinkClicked
        Dim MyLink As LinkLabel = CType(sender, LinkLabel)
        Dim Proces As Process = New Process
        Try
            Process.Start(MyLink.Text)
        Catch ex As Exception
        End Try
    End Sub

    Sub CmdCheckClick(sender As Object, e As EventArgs) Handles cmdCheck.Click
        Dim i As Short
        For i = 0 To CShort(Me.lsvTrackList.Items.Count - 1)
            Me.lsvTrackList.Items(i).Checked = True
        Next i
    End Sub

    Sub Mnu_HelpClick(sender As Object, e As EventArgs) Handles mnuHelpManual.Click
        Dim Proces As Process = New Process
        Try
            Process.Start(MSC.Help.HELP_GEST_IMPORT_JAMENDO.ToString)
        Catch ex As Exception

        End Try
    End Sub


    Sub MnuHTTPSClick(sender As Object, e As EventArgs) Handles mnuHTTPS.Click
        mnuHTTPS.Checked = Not mnuHTTPS.Checked
    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub mnuUrlJamendo_Click(sender As Object, e As EventArgs) Handles mnuUrlJamendo.Click
        Dim Proces As Process = New Process
        Try
            Process.Start(mnuUrlJamendo.Text)
        Catch ex As Exception
        End Try
    End Sub

#Region "Common basic Buttons"



    Private Sub buttonExit_Click(sender As Object, e As EventArgs) Handles cmdSortir.Click
        Me.Close()
    End Sub

    Private Sub mnuAppExit_Click(sender As Object, e As EventArgs) Handles cmdHideExit.Click, mnuAppExit.Click
        Me.Close()
    End Sub

    Private Sub mnuHelpManual_Click(sender As Object, e As EventArgs)
        Dim Proces As Process = New Process
        Try
            Process.Start(MSC.Help.HELP_DIRECTE.ToString)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub mnuHelpWeb_Click(sender As Object, e As EventArgs)
        Dim Proces As Process = New Process
        Try
            Process.Start(MSC.Help.WEB_DEF_MSC.ToString)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs)
        FrmSplash.Show(Me)
    End Sub

    Private Sub mnuHelpMail_Click(sender As Object, e As EventArgs)
        'TODO: omplir el missatge
        'Dim Texte As String = "Res de res"

        'Dim message As New MailMessage(EMAIL_DEF_MSC, FROM_EMAIL_MSC, Params.NomRadio, Texte)
        'Dim emailClient As New SmtpClient(EMAIL_SERVER_MSC)
        'emailClient.Send(message)
        Dim Proces As Process = New Process

        Dim sParams As String = "mailto:" & MSC.Help.EMAIL_SUPORT.ToString &
            "?subject=" & Params.NomRadio
        'sParams = sParams & "?body=" '& Body

        Try
            Process.Start(sParams)
        Catch
        End Try
    End Sub

    Private Sub frmJamendo_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        Dim FitxerINI As New IniFile
        frm_sice(0) = Me.Width : frm_sice(1) = Me.Height
        FitxerINI.INIWrite(MyAPP.IniFile, "Data Gest", "size", frm_sice(0).ToString & "," & frm_sice(1).ToString)
    End Sub

    Private Sub cmdPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStop.Click, cmdPlay.Click
        ' Fer unPlay o un stop
        PlayFitxer()
    End Sub

    Private Sub cmdStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        stopFitxer()
    End Sub


#End Region

End Class

