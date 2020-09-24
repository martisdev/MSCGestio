Option Strict Off
Option Explicit On

Imports BassCd = Un4seen.Bass.AddOn.Cd.BassCd
Imports BassTags = Un4seen.Bass.AddOn.Tags.BassTags
Imports Un4seen.Bass
Imports Un4seen.Bass.Misc

Imports Freedb
Imports MySql.Data.MySqlClient
Imports System.Drawing.Drawing2D
Imports System.Threading


Public Class frmImport
	
	Dim Cancelled As Boolean
	
	'Dim CDDB_Server As String = m_freedb.MAIN_FREEDB_ADDRESS '"us.freedb.org"
	Dim CDDB_Server As String = "us.freedb.org"
	Dim CDDB_Username As String = "abc"
	Dim CDDB_HostName As String = "abc.company"
	Private Const CDDB_ClientName As String = "Freedb_abc"
	Private Const CDDB_Version As String = "1.0"
	
	Private Sub CloseForm()


        If Bass.BASS_ChannelIsActive(StreamHandlePlay) Then Call Bass.BASS_StreamFree(StreamHandlePlay)


        MyAPP.CloseSesionClient(MyAPP.IDSesion_Client, DESCRIP_FORM_RIPPER)
        Me.Dispose()
    End Sub

    Private Sub frmImport_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If AmbTasquesPendents = True Then e.Cancel = True : Exit Sub
        CloseForm()
    End Sub

    Private Sub cmbExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbExit.Click
        Me.Close()
    End Sub

    Private Sub frmImport_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setLanguageForm()

        TestWriteDir()

        'VALORS PER DEFECTE
        LoadCDDrives()

        'Me.txtDataRegSession.MaxDate = Now
        txtDataRegSession.Value = Now.AddDays(-1)

        GroupDBS.Enabled = IIf(Usuari.UsrTipus > mdlMscDefines.NivellUsers.USR_USUARI, True, False)
        mnuEditListComboBoxSeparadors.SelectedIndex = 0
        Me.ClientSize = New Size(frm_sice(0), frm_sice(1))
    End Sub

    Dim MSG_ERROR_CD_READ As String
    Dim MSG_ERROR_DISC As String
    Dim MSG_ERROR_INTERPRET As String
    Dim MSG_CANCEL_IMPORT As String
    Dim MSG_ERROR_CDDB_GET_INFO As String
    Dim MSG_ERROR_CDDB_SELECT_INPUT As String
    Dim MSG_ERROR_CDDB_NO_FOUND_CD As String
    Dim MSG_ERROR_CDDB_DISABLE_INPUT As String
    Dim MSG_ERROR_CDDB_GET_INFO_SERVER As String
    Dim MSC_LABEL_INFO_IMPORT As String
    Dim MSC_ERROR_ASSIGNAR_PRG As String
    Dim LABEL_DISC As String
    Dim LABEL_INTERP As String
    Dim LABEL_ESTIL As String
    Dim LABEL_ANY As String

    Public Sub setLanguageForm()
        lang.StrForm = Me.Name

        MSC_ERROR_ASSIGNAR_PRG = "S'ha d'assignar un programa"
        MSG_ERROR_CD_READ = lang.getText("MSG_ERROR_CD_READ") '"La unitat de CD no està apunt o no es pot llegir el CD. Detalls: {0}" 
        MSG_ERROR_DISC = lang.getText("MSG_ERROR_DISC") '"És obligatori assignar un disc"
        MSG_ERROR_INTERPRET = lang.getText("MSG_INTERP_OBLIGATORI", True) '"És obligatori especificar un intèrpret, pots especificar 'Varis'."
        MSG_CANCEL_IMPORT = lang.getText("MSG_CANCEL_IMPORT") '"Vols cancelar totes les importacions?"
        MSG_ERROR_CDDB_GET_INFO = lang.getText("MSG_ERROR_CDDB_GET_INFO") '"No està apunt per rebre la informació del CD. {0}"
        MSG_ERROR_CDDB_SELECT_INPUT = lang.getText("MSG_ERROR_CDDB_SELECT_INPUT") '"S'ha de seleccionar una entrada. torna a provar-ho."
        MSG_ERROR_CDDB_NO_FOUND_CD = lang.getText("MSG_ERROR_CDDB_NO_FOUND_CD") '"Consulta fallida, no s'ha trobat cap coinciència. Codi: {0}"
        MSG_ERROR_CDDB_DISABLE_INPUT = lang.getText("MSG_ERROR_CDDB_DISABLE_INPUT") '"No està apunt per rebre la entrada de CD. Codi: {0}"
        MSG_ERROR_CDDB_GET_INFO_SERVER = lang.getText("MSG_ERROR_CDDB_GET_INFO_SERVER") '"Recullint informació dels servidors"
        'Me.mnuRipper.Text = "MenuStrip1"


        Me.mnuApplication.Text = lang.getText("LABEL_PROGRAMA", True) '"Programa"
        Me.mnuAppExit.Text = lang.getText("LABEL_EXIT", True) '"Sortir"

        Me.mnuEdit.Text = lang.getText("mnuEdit.Text", True) '"Edició" 
        Me.mnuEditItem.Text = lang.getText("LABEL_EDIT_ITEM", True) '"Edició" 
        Me.mnuHelp.Text = lang.getText("mnu_Help", True) '"Ajuda
        'Me.mnuHelpAbout.Text = lang.getText("mnuRefMSC.Text", True) '"Sobre MSC"
        'Me.mnuHelpWeb.Text = lang.getText("mnuRefWeb.Text", True) '"MSC a Internet"
        Me.mnuHelpManual.Text = lang.getText("mnuRefHelp.Text", True) '"Manual OnLine"

        Me.mnuPlayer.Text = lang.getText("LABEL_REPRODUCTOR", True) '"Reproductor"
        Me.mnuPlay.Text = lang.getText("LABEL_PLAY_PAUSA", True) '"Play/Pausa"
        Me.cmdPlay.ToolTipText = mnuPlay.Text
        Me.mnuStop.Text = lang.getText("LABEL_STOP", True) '"Stop"
        Me.cmdStop.ToolTipText = mnuStop.Text
        Me.mnuEndTrack.Text = lang.getText("LABEL_END_TEMA", True) '"Final Tema"

        Me.mnuEditDelete.Text = lang.getText("LABEL_DELETE", True) '"Borrar"
        Me.mnuEditAudio.Text = lang.getText("mnuEditAudio.Text", True) '"Editar l'àudio"


        Me.cmdDel.ToolTipText = lang.getText("LABEL_DEL_SELECT", True) '"LABEL_DEL_SELECT"
        'Me.cmdExitTool.Text = lang.getText("LABEL_EXIT",True) '"Sortir"
        LABEL_DISC = lang.getText("HEADERTEXT_DISC", True) '"Disc"
        LABEL_INTERP = lang.getText("HEADERTEXT_INTERP", True) '"Intèrpret"
        LABEL_ESTIL = lang.getText("HEADERTEXT_ESTIL", True) '"Estil"
        LABEL_ANY = lang.getText("HEADERTEXT_ANY", True) '"Any"

        Me.lbDisc.Text = LABEL_DISC
        Me.lbInterp.Text = LABEL_INTERP
        Me.lbEstil.Text = LABEL_ESTIL
        Me.ColumnHeader4.Text = LABEL_ANY

        Me.lbIdioma.Text = lang.getText("HEADERTEXT_IDIOMA", True) '"Idioma"
        Me.Label10.Text = lang.getText("LABEL_COMPOSITOR", True) '"Compositor"
        Me.GroupBoxProgrames.Text = lang.getText("FITXER_PROGRAMA", True) ''"Programes"
        Me.ColumnHeader1.Text = lang.getText("HEADERTEXT_TITOL", True) '"Títol"
        Me.ColumnHeader2.Text = lang.getText("HEADERTEXT_INTERP", True) '"Intèrpret"
        Me.ColumnHeader3.Text = lang.getText("HEADERTEXT_DURADA", True) '"Durada"

        Me.ToolStripMenuItem1.Text = lang.getText("LABEL_PLAY_PAUSA", True) '"Play/Pausa"
        Me.ToolStripMenuItem2.Text = lang.getText("LABEL_STOP", True) '"Stop"
        Me.mnuCalcDurada.Text = lang.getText("LABEL_CALC_DURADA", True) '"Calcular Durada"
        Me.mnuFinal.Text = lang.getText("LABEL_END_TEMA", True) '"Final Tema"
        Me.ToolStripMenuItem3.Text = lang.getText("LABEL_PLAY_PAUSA", True) '"Play/Pausa"
        Me.ToolStripMenuItem4.Text = lang.getText("LABEL_STOP", True) '"Stop"
        Me.ToolStripMenuItem5.Text = lang.getText("LABEL_CALC_DURADA", True) '"Calcular Durada"
        Me.ToolStripMenuItem6.Text = lang.getText("LABEL_END_TEMA", True) '"Final Tema"


        Me.cmdAddFitxers.Text = lang.getText("cmdAddFitxers.Text") '"Afegir fitxers"
        Me.cmdAddFitxers.ToolTipText = lang.getText("cmdAddFitxers.ToolTipText") '"Carregar fitxers"
        Me.cmdRipper.Text = lang.getText("LABEL_IMPORTAR", True) '"Importar"
        cmdImport.Text = lang.getText("LABEL_IMPORTAR", True)
        Me.cmdRipper.ToolTipText = lang.getText("cmdRipper.ToolTipText") '"Importar / Codificar fitxers"
        Me.ToolStripLabel1.Text = lang.getText("ToolStripLabel1.Text") '"CD-ROM:"
        Me.comboBoxCdDrivers.ToolTipText = lang.getText("comboBoxCdDrivers.ToolTipText") '"Llistat d'unitats de CD-Rom"
        Me.cmdCDDB.Text = lang.getText("cmdCDDB.Text") '"Connectar a CDDB"
        Me.cmdCDDB.ToolTipText = lang.getText("cmdCDDB.ToolTipText") '"Connectar amb servidor remot CDDB"
        Me.cmdCheck.Text = lang.getText("LABEL_SELECT_TOT", True) '"Seleccionar tot"
        Me.cmdCheck.ToolTipText = lang.getText("cmdCheck.ToolTipText") '"Sel.lecconar tots els fitxers"

        'Me.cmdExitTool.ToolTipText = lang.getText("LABEL_TANCAR_PANTALLA",True) '"Tancar pantalla"




        Me.lbAtencio.Text = lang.getText("lbAtencio.Text") '"No hi han permisos d'escriptura en el directori destí"
        Me.GroupDBS.Text = lang.getText("GroupDBS.Text") '"Importar a la base de dades"
        'Me.CheckBox1.Text = lang.getText("LABEL_PUBLICAR_WEB",true) '"Publicar al web"

        MSC_LABEL_INFO_IMPORT = lang.getText("lbInfoImport.Text") '"Importa fitxer d'àudio cap a Música"
        lbInfoImport.Text = MSC_LABEL_INFO_IMPORT & " " & Me.comboBoxOpcions.Text
        Me.GroupBox2.Text = lang.getText("GroupBox2.Text") '"Crear disc a partir del tag"
        Me.cmdCreaDiscFromTag.Text = lang.getText("cmdCreaDiscFromTag.Text") '"Crear "
        Me.Label13.Text = lang.getText("HEADERTEXT_ANY", True) '"Any"
        Me.Label1.Text = lang.getText("Label1.Text") '"Es crearà una nova entrada a la base de dades per cada trac de la llista."
        Me.Label19.Text = lang.getText("Label19.Text") '"Atenció: Assegureu-vos que l'ordre de les parts és el correcte"
        Me.Label18.Text = lang.getText("Label18.Text") '"Hora d'enregistrament"
        Me.Label17.Text = lang.getText("Label17.Text") '"Data d'enregistrament"
        Me.Label9.Text = lang.getText("Label9.Text") '"Els tracks importats es consideren parts de la mateixa sessió."		

        Me.columnHeader5.Text = lang.getText("columnHeader5.Text") '"BPM"
        Me.mnuTítolIntèrpret.Text = lang.getText("LABEL_TITOL_INTERPRET", True) '"Títol<>Intèrpret"
        Me.mnuCapturarIntèrpretTítol.Text = lang.getText("LABEL_CAPTURA_INTERP_TITOL", True) '"Capturar: Intèrpret - Títol"
        Me.mnuCapturarTítolIntèrpret.Text = lang.getText("CAPTURA_TITOL_INTERP", True) '"Capturar: Títol - Intèrpret"
        'Me.cmbExit.Text = "Button1"
        Me.OpenFileDialog1.Filter = lang.getText("LABEL_IMAGE_FILES", True) & " |*.gif; *.jpg; *.jpeg; *.bmp" '"arxius d'imatges |*.gif; *.jpg; *.jpeg; *.bmp"
        Me.OpenFileDialog1.Title = lang.getText("LABEL_SELECT_FOTOGRAFIA", True) '"Seleccioneu una fotografia"
        'OpenFileDialog.Filter = "Fitxers MP3 (*.mp3) |*.mp3; |Fitxers Wave (*.wav) |*.wav; |Fitxers Ogg (*.ogg)|*.ogg; |Fitxers Wma (*.wma) |*.wma"
        Me.OpenFileDialog.Filter = lang.getText("OpenFileDialog.Filter") & " MP3 (*.mp3) |*.mp3; |Fitxers Wave (*.wav) |*.wav" '"Fitxers MP3 (*.mp3) |*.mp3; |Fitxers Wave (*.wav) |*.wav"

        label2.Text = lang.getText("LABEL_DESCRIPCIO", True) '"Descripció"
        chkPubliPodcast.Text = lang.getText("LABEL_PUBLICAR_POCAST", True) '"Publicar al podcasting"
        chk_PrgCalendar.Text = lang.getText("LABEL_PROGRAMAR_CALENDARI", True) '"Programar al calendari"		

        Me.Text = lang.getText("Text") '"Importar fitxers ( Ripper)"

        Dim Cmb As New combo
        Cmb.OmpleCombo(cbEstil, TAULES_DBS.TAULA_ESTILS, TotsCap.CAP) : cbEstil.SelectedValue = 0
        Cmb.OmpleCombo(cbInterp, TAULES_DBS.TAULA_INTERPRETS, TotsCap.CAP) : cbInterp.SelectedValue = 0
        Cmb.OmpleCombo(cbIdioma, TAULES_DBS.TAULA_IDIOMES, TotsCap.CAP, "lang_visible=1") : cbIdioma.SelectedValue = 0
        Cmb.OmpleCombo(cbDisc, TAULES_DBS.TAULA_DISCOS, TotsCap.CAP) : cbDisc.SelectedValue = 0
        Cmb.OmpleCombo(Me.ComboBoxProgrames, TAULES_DBS.TAULA_PROGRAMES, TotsCap.CAP) : ComboBoxProgrames.SelectedValue = 0
        Cmb.OmpleCombo(Me.comboBoxOpcions, TAULES_DBS.TAULA_TIPUS_FITXER, TotsCap.NO_ADD) : comboBoxOpcions.SelectedValue = 0
    End Sub

    Private Sub TestWriteDir()
        'comprova el Path si té permisos d'escriptura.
        Dim NomAudio As String = ""
        Dim PathDef As String = ""

        Select Case Me.comboBoxOpcions.SelectedValue
            Case Tipus_Fitxers.FITXER_MUSICA : PathDef = Params.PathMusica
            Case Tipus_Fitxers.FITXER_PUBLICITAT : PathDef = Params.PathPublicitat
            Case Tipus_Fitxers.FITXER_PROGRAMA : PathDef = Params.PathProgrames
            Case Else 'Tipus_Fitxers.FITXER_AUDIO_USR
                PathDef = Params.PathAudioUser
        End Select
        Try
            Dim ArchTest As New IO.FileStream(PathDef & "test.txt", IO.FileMode.Create)
            ArchTest.Close()
            IO.File.Delete(PathDef & "test.txt")
            lbAtencio.Visible = False
            'Dim UserTipus As NivellUsers = CType(Usuari.UsrTipus, NivellUsers)
            'Me.cmdRipper.Enabled = IIf(UserTipus > NivellUsers.USR_CONVIDAT, True, False)
            'cmdImport.Enabled = IIf(UserTipus > NivellUsers.USR_CONVIDAT, True, False)
        Catch ex As Exception
            cmdRipper.Enabled = False
            cmdImport.Enabled = False
            lbAtencio.Visible = True
        End Try
    End Sub

    Private Sub txtAny_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAny.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        If KeyAscii < Asc("0") Or KeyAscii > Asc("9") Then If KeyAscii <> 8 Then KeyAscii = 0
        e.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub cbDisc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbDisc.KeyDown
        If e.KeyCode = Keys.Enter Then
            RefreshCombosDisc()
        End If
    End Sub

    Private Sub KeyPress_ComboBoxMusic(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbInterp.KeyPress, cbIdioma.KeyPress, cbEstil.KeyPress, cbDisc.KeyPress


        e.KeyChar = UCase(e.KeyChar)

    End Sub

    Private Sub KeyUp_ComboBoxMusic(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbInterp.KeyUp, cbIdioma.KeyUp, cbEstil.KeyUp, cbDisc.KeyUp


        Select Case e.KeyCode
            Case Keys.Left, Keys.Right, Keys.Up, Keys.Down
                Return
        End Select
        Dim MyComboBox As ComboBox = CType(sender, ComboBox)
        Dim Origen As TAULES_DBS

        Select Case MyComboBox.Name
            Case "cbDisc" : Origen = TAULES_DBS.TAULA_DISCOS
            Case "cbEstil" : Origen = TAULES_DBS.TAULA_ESTILS
            Case "cbIdioma" : Origen = TAULES_DBS.TAULA_IDIOMES
            Case "cbInterp" : Origen = TAULES_DBS.TAULA_INTERPRETS
        End Select
        refreshComboBoxKeyUp(MyComboBox, Origen, TotsCap.CAP)

    End Sub


    Private Sub TextChanged_ComboBoxMusic(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbInterp.TextChanged, cbIdioma.TextChanged, cbEstil.TextChanged, cbDisc.TextChanged _

        'Dim index As Integer = _
        '        CType(sender, ComboBox).FindStringExact(CType(sender, ComboBox).Text())
        'If index < 0 Then
        '    'no existeix el que es busca
        'End If

    End Sub

    Private Sub LoadCDDrives()
        Try
            comboBoxCdDrivers.Items.Clear()

            Dim MAXDRIVES As Integer = 23
            Dim a As Integer = 0
            Dim cdi As New Un4seen.Bass.AddOn.Cd.BASS_CD_INFO
            While (a < MAXDRIVES And BassCd.BASS_CD_GetInfo(a, cdi) <> 0)
                comboBoxCdDrivers.Items.Add(cdi.DriveLetter & ": " & cdi.vendor & " " & cdi.product & " " & cdi.rev)
                a = a + 1
            End While
            If comboBoxCdDrivers.Items.Count > 0 Then comboBoxCdDrivers.SelectedIndex = 0
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
        End Try
    End Sub


    Private Sub LoadFitxers()
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.AppStarting
        Dim i As Short
        Static InitPath As String
        With OpenFileDialog
            .FileName = ""
            .Title = LABEL_BUSCAR & " ..."
            .Multiselect = True
            .ShowReadOnly = False
            .InitialDirectory = InitPath
            '.Filter = "Fitxers MP3 (*.mp3) |*.mp3; |Fitxers Wave (*.wav) |*.wav; |Fitxers Ogg (*.ogg)|*.ogg; |Fitxers Wma (*.wma) |*.wma"
            '.Filter = "Fitxers MP3 (*.mp3) |*.mp3; |Fitxers Wave (*.wav) |*.wav"
            If .ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                For i = 0 To CShort(.FileNames.Length - 1)
                    Dim path As String = .FileNames(i)
                    addListTracksAudios(path)
                    System.Windows.Forms.Application.DoEvents()
                Next i
                Dim pathCover As String = System.IO.Path.GetDirectoryName(.FileNames(0)) & "\cover.jpg"
                If IO.File.Exists(pathCover) = True Then picDisc.Image = resizeImageFromPath(pathCover, MAX_WIDTH_IMG, MAX_HEIDTH_IMG)
            End If
            InitPath = .FileName
        End With
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub addListTracksAudios(ByVal Path As String)
        AmbTasquesPendents = True
        'Primer capturem la informació
        Dim NomDisc As String = ""
        Dim interp As String = ""
        Dim Any As String = ""

        Dim Estil As String = ""
        Dim Title As String = ""
        Dim Duration As String = ""
        Dim BPM As Single
        Dim Handle As Integer = 0
        Dim tLength As Single
        Dim lenTrack As Long
        Dim ImageDisk As Image = Nothing
        Select Case UCase(IO.Path.GetExtension(Path))
            Case ".MP3"
                Handle = Bass.BASS_StreamCreateFile(Path, 0, 0, BASSFlag.BASS_DEFAULT)
                If Params.ID3Tag = True Then
                    Dim TI As New Un4seen.Bass.AddOn.Tags.TAG_INFO
                    If (BassTags.BASS_TAG_GetFromFile(Handle, TI)) Then
                        If My.Settings.TXT_CAPITALIZE Then
                            interp = TI.artist.ToUpper
                            Title = TI.title.ToUpper
                            Estil = TI.genre.ToUpper
                            NomDisc = TI.album.ToUpper
                        Else
                            interp = TI.artist
                            Title = TI.title
                            Estil = TI.genre
                            NomDisc = TI.album
                        End If
                        Any = TI.year
                        If TI.PictureCount > 0 Then
                            ImageDisk = resizeImageFromImage(TI.PictureGetImage(0), MAX_WIDTH_IMG, MAX_HEIDTH_IMG)
                        End If
                    End If
                End If
                lenTrack = Bass.BASS_ChannelGetLength(Handle)
                tLength = Bass.BASS_ChannelBytes2Seconds(Handle, lenTrack)
                Duration = Un4seen.Bass.Utils.FixTimespan(tLength, "HHMMSS")

                If (comboBoxOpcions.SelectedValue = Tipus_Fitxers.FITXER_MUSICA Or comboBoxOpcions.SelectedValue > 600) And Duration < "00:20:00" Then
                    BPM = getBPMFitxer(Path, Me.Handle)
                Else
                    BPM = 0
                End If
                Bass.BASS_StreamFree(Handle)
            Case ".WAV"
                Handle = Bass.BASS_StreamCreateFile(Path, 0, 0, BASSFlag.BASS_DEFAULT)
                lenTrack = Bass.BASS_ChannelGetLength(Handle)
                tLength = Bass.BASS_ChannelBytes2Seconds(Handle, lenTrack)
                Duration = Un4seen.Bass.Utils.FixTimespan(tLength, "HHMMSS")
                If (comboBoxOpcions.SelectedValue = Tipus_Fitxers.FITXER_MUSICA Or comboBoxOpcions.SelectedValue > 600) And Duration < "00:20:00" Then
                    BPM = getBPMFitxer(Path, Me.Handle)
                Else
                    BPM = 0
                End If

                Bass.BASS_StreamFree(Handle)
            Case ".CDA"
                Title = "Track 0" & (lsvTrackList.Items.Count + 1)
                Dim StreamHandleCD As Integer = BassCd.BASS_CD_StreamCreateFile(Path, BASSFlag.BASS_STREAM_AUTOFREE)
                Dim len As Long = Bass.BASS_ChannelGetLength(StreamHandleCD)
                Duration = TimeSerial(0, 0, Bass.BASS_ChannelBytes2Seconds(StreamHandleCD, len))
                If (comboBoxOpcions.SelectedValue = Tipus_Fitxers.FITXER_MUSICA Or comboBoxOpcions.SelectedValue > 600) And Duration < "00:20:00" Then
                    'TODO: Error al calcular BPM en CDs	
                    BPM = 0 'getBPMFitxer(Path,Me.Handle)
                Else
                    BPM = 0
                End If

                Dim IDCdDrive As Integer = Me.comboBoxCdDrivers.SelectedIndex
                For z As Integer = 0 To comboBoxCdDrivers.Items.Count - 1
                    Dim info As New Un4seen.Bass.AddOn.Cd.BASS_CD_INFO
                    BassCd.BASS_CD_GetInfo(z, info)
                    Dim ds As String = info.DriveLetter.ToString & ":\"
                    If IO.Path.GetPathRoot(Path) = ds Then
                        IDCdDrive = z
                        comboBoxCdDrivers.Tag = z
                    End If
                Next

                Try
                    Dim query As String = BassCd.BASS_CD_GetID(IDCdDrive, Un4seen.Bass.AddOn.Cd.BASSCDId.BASS_CDID_CDDB)
                    query = Replace(query, " ", "+")
                    cmdCDDB.Tag = query
                    cmdCDDB.Enabled = True
                Catch ex As Exception
                    '//give up
                    cmdCDDB.Tag = ""
                    comboBoxCdDrivers.Tag = ""
                    cmdCDDB.Enabled = False
                    MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_CD_READ, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
                    Return
                End Try

                BassCd.BASS_CD_Release(comboBoxCdDrivers.SelectedIndex)

                'Bass.BASS_StreamFree(Handle)
        End Select
        If Title.Length = 0 Then Title = GetFileName(Path, True)
        If interp.Length = 0 Then interp = GetFileName(Path, True)
        If Any.Length = 0 Then Any = ""
        If Estil.Length = 0 Then Estil = ""

        ' Nova línia al llistat
        Dim NewItem As System.Windows.Forms.ListViewItem
        NewItem = lsvTrackList.Items.Add(Title)
        NewItem.Tag = Path
        NewItem.SubItems.Insert(1, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, interp))
        NewItem.SubItems.Insert(2, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, Duration))
        NewItem.SubItems.Insert(3, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, CStr(Any)))
        NewItem.SubItems.Insert(4, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, CStr(CInt(BPM))))

        'Si cal es crea la opció del disc nou
        If NomDisc.Length > 0 Then OpcioDiscNou(NomDisc, interp, Any, ImageDisk, Estil)
        Me.cmdImport.Enabled = True
        Me.cmdRipper.Enabled = True
        AmbTasquesPendents = False
    End Sub

    Private Sub OpcioDiscNou(ByVal NomDisc As String, ByVal Interp As String, ByVal Any As String, ByVal ImageDisk As Image, ByVal Estil As String)
        'Ensenya la info capturada
        Me.lbInfoAny.Text = Any
        Me.lbInfoDisc.Text = NomDisc
        Me.lbInfoInterp.Text = Interp
        Me.lbInfoEstil.Text = Estil

        lbCreaDisc.Visible = True
        lbCreaDisc.Text = LABEL_DISC & ": " & NomDisc & vbCr _
            & LABEL_INTERP & " :" & Interp & vbCr _
            & LABEL_ESTIL & " :" & Estil & vbCr _
            & LABEL_ANY & " :" & Any & vbCr

        If ImageDisk IsNot Nothing Then
            Me.picDisc.Image = ImageDisk
            Me.picDisc.Tag = "savefoto"
        Else
            Me.picDisc.Image = picDisc.ErrorImage
            Me.picDisc.Tag = "nofoto"
        End If

        'Busca el disc si ja existeix
        'TODO: error al buscar caràcters comodí
        Dim sCmd As String = "disc_nom LIKE '" & AddSlashes(NomDisc) & "'"
        Dim colec() As DataRow
        Try
            colec = dsClient.Tables("discos").Select(sCmd)
            If colec.Length > 0 Then
                Me.cbDisc.SelectedValue = colec(0)("disc_id")
                RefreshCombosDisc()
                Me.cmdCreaDiscFromTag.Enabled = False
                Me.picDisc.Enabled = False
            Else
                'No existeix, habilita el botó per la creació ràpida
                Me.cmdCreaDiscFromTag.Enabled = True
                Me.picDisc.Enabled = True
            End If
        Catch ex As Exception
            Beep()
        Finally
            colec = Nothing
        End Try
    End Sub

    Private Sub cmdAddFitxers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddFitxers.Click
        LoadFitxers()
    End Sub

    Private Sub lsvTrackList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsvTrackList.DoubleClick
        PlayFitxer()
    End Sub

    Private Sub ShowEditTag()
        frmTagRipper.MyimportFrm = Me
        frmTagRipper.LoadValorsTrack()
    End Sub

    Private Sub comboBoxCdDrivers_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBoxCdDrivers.SelectedIndexChanged
        lsvTrackList.Items.Clear()
        If Not BassCd.BASS_CD_IsReady(comboBoxCdDrivers.SelectedIndex) Then
            cmdCDDB.Tag = ""
            cmdCDDB.Enabled = False
            Exit Sub
        End If

        Dim nTracks As Integer = BassCd.BASS_CD_GetTracks(comboBoxCdDrivers.SelectedIndex)
        If nTracks = -1 Then
            cmdCDDB.Tag = ""
            cmdCDDB.Enabled = False
            Exit Sub
        End If
        Dim info As New Un4seen.Bass.AddOn.Cd.BASS_CD_INFO
        BassCd.BASS_CD_GetInfo(comboBoxCdDrivers.SelectedIndex, info)
        Dim Unitat As String = info.DriveLetter
        For A As Integer = 0 To nTracks - 1
            Dim Path As String = Unitat & ":\Track" & Strings.Format(A + 1, "00") & ".cda"
            addListTracksAudios(Path)
        Next

    End Sub

    Private Sub cmdCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCheck.Click
        Dim i As Short
        For i = 0 To CShort(Me.lsvTrackList.Items.Count - 1)
            Me.lsvTrackList.Items(i).Checked = True
        Next i
    End Sub

    Private Sub BorrarFitxer()
        If lsvTrackList.Items.Count = 0 Then Return
        Dim i As Short = Me.lsvTrackList.Items.Count - 1
        Do Until i < 0
            Try
                If Me.lsvTrackList.Items.Item(i).Selected = True Then Me.lsvTrackList.Items.RemoveAt(i)
                i = i - 1
            Catch ex As Exception
                Exit Do
            End Try
        Loop
        Me.picDisc.Image = Me.picDisc.ErrorImage
        Me.picDisc.Tag = ""
        Me.picDisc.Enabled = False
        Me.cmdCreaDiscFromTag.Enabled = False
        lbCreaDisc.Visible = False
        Me.cmdRipper.Enabled = (lsvTrackList.Items.Count > 0)
        Me.cmdImport.Enabled = (lsvTrackList.Items.Count > 0)
    End Sub

    Private Sub lsvTrackList_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lsvTrackList.DragDrop
        Dim filenames As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())
        For Each file As String In filenames
            addListTracksAudios(file)
        Next
    End Sub

    Private Sub lsvTrackList_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lsvTrackList.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim files() As String = e.Data.GetData(DataFormats.FileDrop, True)
            If UCase(Microsoft.VisualBasic.Right(files(0), 3)) = "MP3" _
                Or UCase(Microsoft.VisualBasic.Right(files(0), 3)) = "WAV" _
                Or UCase(Microsoft.VisualBasic.Right(files(0), 3)) = "CDA" _
                Or UCase(Microsoft.VisualBasic.Right(files(0), 3)) = "OGG" Then

                e.Effect = DragDropEffects.Copy
            Else
                'és un fitxer no reconegut per el programa    
                e.Effect = DragDropEffects.None
            End If
        End If
    End Sub

    Private Sub lsvTrackList_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsvTrackList.Resize
        CType(sender, ListView).Columns(0).Width = CType(sender, ListView).Width \ 3
        CType(sender, ListView).Columns(1).Width = CType(sender, ListView).Width \ 3
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

    Private Sub RipFitxer()
        If Not MyAPP.PermisPerContinuar() Then MetroFramework.MetroMessageBox.Show(Me, MSG_SERVER_CLOSE, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Stop, 100) : Exit Sub

        If Me.comboBoxOpcions.SelectedValue = Tipus_Fitxers.FITXER_MUSICA Then
            If cbDisc.SelectedValue < 1 Then
                MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_DISC, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
                cbDisc.Focus()
                Exit Sub
            ElseIf Me.cbInterp.SelectedValue < 1 Then
                MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_INTERPRET, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
                Me.cbInterp.SelectedValue = 1
                Exit Sub
            End If
        End If

        BlokUnblokPantalla(False)

        Cancelled = False
        Me.cmdAddFitxers.Enabled = False
        Me.cmdRipper.Enabled = False
        cmdImport.Enabled = False

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.AppStarting

        Dim PathDef As String 'És el Path final on s´ha de copiar el fitxer

        'Dim NomAudioUser As String = ""
        Dim IdAudioUser As Integer = 0
        Select Case Me.comboBoxOpcions.SelectedValue
            Case Tipus_Fitxers.FITXER_MUSICA : PathDef = Params.PathMusica
            Case Tipus_Fitxers.FITXER_PUBLICITAT : PathDef = Params.PathPublicitat
            Case Tipus_Fitxers.FITXER_PROGRAMA : PathDef = Params.PathProgrames
            Case Else 'Tipus_Fitxers.FITXER_AUDIO_USR
                IdAudioUser = comboBoxOpcions.SelectedValue - 600
                PathDef = Params.PathAudioUser
        End Select
        Dim InitName As String

        Dim NamePrg As String = ""
        Dim SqlStr As String = ""
        Dim db As New MSC.dbs(Cloud)
        Dim SessioMare As Integer = 0
        Dim NewIdPod() As Integer
        For i As Short = 0 To Me.lsvTrackList.Items.Count - 1

            If Cancelled Then If MetroFramework.MetroMessageBox.Show(Me, MSG_CANCEL_IMPORT, MSG_ATENCIO, MessageBoxButtons.YesNo, MessageBoxIcon.Question, 100) = DialogResult.Yes Then Exit For
            System.Windows.Forms.Application.DoEvents()
            If lsvTrackList.Items.Item(i).Checked = True Then
                lsvTrackList.Items.Item(i).ForeColor = Color.Silver
                Dim pb As New MetroFramework.Controls.MetroProgressBar
                pb = ListView_AddProgressBar(lsvTrackList, i, 2)
                pb.Maximum = 100
                pb.Value = 1


                Dim Titol As String = AddSlashes(lsvTrackList.Items.Item(i).Text)
                If Len(Titol) >= 50 Then Titol = Strings.Left(Titol, 46) & "..."

                Dim path As String = (lsvTrackList.Items.Item(i).Tag) ' És el Path on es troba el fitxer                
                Dim Duration As Date = IIf(Me.lsvTrackList.Items.Item(i).SubItems(2).Text.Length > 0, lsvTrackList.Items.Item(i).SubItems(2).Text, "00:00:00")
                Dim BPM As Integer = IIf(Me.lsvTrackList.Items.Item(i).SubItems(4).Text.Length > 0, CInt(lsvTrackList.Items.Item(i).SubItems(4).Text), 0)
                System.Windows.Forms.Application.DoEvents()
                Select Case comboBoxOpcions.SelectedValue
                    Case Tipus_Fitxers.FITXER_MUSICA
                        'BUSCAR SI JA EXISTEIX A LA DBS
                        Dim StrInterp As String = AddSlashes(lsvTrackList.Items.Item(i).SubItems.Item(1).Text)
                        Dim Interp As Short
                        SqlStr = "SELECT interp_id FROM interprets WHERE interp_nom LIKE '%" & StrInterp & "%' "

                        Dim rs As DataTable = db.getTable(SqlStr)
                        If rs.Rows.Count = 1 Then
                            Interp = CShort(rs.Rows(0)(0)) 'OK
                            'TODO: 'problema n'ha trobat més d'un
                        ElseIf rs.Rows.Count > 1 Then
                            Interp = CShort(rs.Rows(0)(0))
                        ElseIf rs.Rows.Count = 0 Then
                            SqlStr = "INSERT INTO interprets (interp_nom ) VALUES ('" & StrInterp & "');"
                            Interp = db.New_ID(SqlStr) 's'ha de crear nou
                            'RefreshDataSet(TAULES_DBS.TAULA_INTERPRETS)

                        End If

                        Dim Disc As Short = IIf(Len(cbDisc.SelectedIndex) > 0, Me.cbDisc.SelectedValue, 0)
                        Dim Compos As String = IIf(Len(Me.txtCompositor.Text) > 0, AddSlashes(Me.txtCompositor.Text), " ")
                        'Dim Estil As Short = IIf(Len(Me.cbEstil.SelectedIndex) > 0, Me.cbEstil.SelectedValue, 0)
                        Dim Idioma As Short = IIf(Len(Me.cbIdioma.SelectedIndex) > 0, Me.cbIdioma.SelectedValue, 0)

                        Dim AnyPubli As Short = IIf(Len(txtAny.Text) > 0, Val(Me.txtAny.Text), 0)


                        SqlStr = "INSERT INTO temes (tema_interp, tema_disc, tema_compositor "
                        SqlStr = SqlStr & ", tema_idioma, tema_durada, tema_titol, tema_any, tema_datain,tema_pautain,tema_ritme)"

                        SqlStr = SqlStr & " VALUES "
                        SqlStr = SqlStr & "( " & Interp
                        SqlStr = SqlStr & ", " & Disc
                        SqlStr = SqlStr & ", '" & Compos & "'"
                        SqlStr = SqlStr & ", " & Idioma
                        SqlStr = SqlStr & ", '" & Duration.ToString("HH:mm:ss") & "'"
                        SqlStr = SqlStr & ", '" & Titol & "'"
                        SqlStr = SqlStr & ", " & AnyPubli
                        SqlStr = SqlStr & ", '" & Now.ToString("yyyy-MM-dd HH:mm:ss") & "'"
                        SqlStr = SqlStr & ", " & IIf(Params.FilesActives, 1, 0)
                        SqlStr = SqlStr & ", " & BPM
                        SqlStr = SqlStr & ");"

                        InitName = db.New_ID(SqlStr)

                        'insert styles
                        If cbEstil.SelectedValue > 0 Then
                            SqlStr = "INSERT INTO style_relationships (`style_relationships_tipfitxer`,style_relationships_fitxer,`style_relationships_style`) " &
                                                            "VALUES ( " & Tipus_Fitxers.FITXER_MUSICA & "," & InitName & "," & CInt(cbEstil.SelectedValue) & ") ;"
                            db.New_ID(SqlStr)
                            RefreshDataSet(TAULES_DBS.TAULA_STYLE_RELATIONSHIPS)
                        End If
                    Case Tipus_Fitxers.FITXER_PROGRAMA
                        Dim Prg_id As Integer = ComboBoxProgrames.SelectedValue

                        Dim DateReg As Date = New Date(Me.txtDataRegSession.Value.Year, Me.txtDataRegSession.Value.Month, Me.txtDataRegSession.Value.Day, Me.txtHoraRegSession.Value.Hour, Me.txtHoraRegSession.Value.Minute, Me.txtHoraRegSession.Value.Second)
                        Dim DateCalendar As Date = New Date(Me.txtDataIn.Value.Year, Me.txtDataIn.Value.Month, Me.txtDataIn.Value.Day, Me.txtHoraIni.Value.Hour, Me.txtHoraIni.Value.Minute, Me.txtHoraIni.Value.Second)

                        If Prg_id = 0 Then MetroFramework.MetroMessageBox.Show(Me, MSC_ERROR_ASSIGNAR_PRG, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100) : BlokUnblokPantalla(True) : Exit Sub
                        Dim Descrip As String = AddSlashes(Me.txtDescrip.Text)

                        SqlStr = "INSERT INTO prg_sessions ( ses_prg, ses_durada, ses_datacreacio, ses_sessiomare) "
                        SqlStr = SqlStr & " VALUES "
                        SqlStr = SqlStr & " ( " & Prg_id
                        SqlStr = SqlStr & " , '" & Duration.ToString("HH:mm:ss") & "'"
                        SqlStr = SqlStr & " , '" & DateReg.ToString("yyyy-MM-dd HH:mm:ss") & "'"
                        SqlStr = SqlStr & " , " & SessioMare
                        SqlStr = SqlStr & ");"

                        InitName = db.New_ID(SqlStr)
                        If i = 0 Then SessioMare = InitName

                        If chkPubliPodcast.Checked = True Then
                            Try
                                ReDim Preserve NewIdPod(i)
                            Catch ex As Exception
                                ReDim Preserve NewIdPod(0)
                            End Try
                            Dim NameFitxerPotcast As String = ""
                            If i = 0 Then
                                NameFitxerPotcast = RemoveInvalidFileNameChars(Me.ComboBoxProgrames.Text.Trim.ToLower & "-" & Now.ToString("yyyyMMddHHmm")).Replace(" ", "_") & ".mp3"
                            Else
                                NameFitxerPotcast = RemoveInvalidFileNameChars(Me.ComboBoxProgrames.Text.Trim.ToLower & "-" & Now.ToString("yyyyMMddHHmm") & "part" & i + 1).Replace(" ", "_") & ".mp3"
                            End If

                            SqlStr = "INSERT INTO podcasting (pod_tipusfitxer, pod_id_origen, pod_durada,pod_datacreacio, pod_datapubli, pod_dataout, pod_descrip, pod_file) " &
                                                            "VALUES ( 5, " & InitName & ",'" & Duration.ToString("HH:mm:ss") & "','" & Now.ToString("yyyy-MM-dd HH:mm:ss") & "','" & DateCalendar.ToString("yyyy-MM-dd HH:mm:ss") & "','" & DateCalendar.AddDays(Cloud.DiesPermanenciaPodcast).ToString("yyyy-MM-dd") & "','" & Descrip & "', '" & NameFitxerPotcast & "' );"
                            NewIdPod(i) = db.New_ID(SqlStr)
                        End If
                        If Me.chk_PrgCalendar.Checked = True Then

                            Dim IdPauta As Integer = db.ExecuteScalar("SELECT listpauta_id FROM listpautes WHERE listpauta_sessio =" & InitName & ";")
                            If IdPauta = 0 Then
                                'S'ha de crear la pauta
                                SqlStr = "INSERT INTO listpautes ( listpauta_titol, listpauta_datacreacio, listpauta_sessio, listpauta_sequencia)"
                                SqlStr = SqlStr & " VALUES "
                                SqlStr = SqlStr & "( '" & AddSlashes(Me.ComboBoxProgrames.Text) & "'"
                                SqlStr = SqlStr & ", '" & Now.ToString("yyyy-MM-dd HH:mm:ss") & "'"
                                SqlStr = SqlStr & ", " & InitName
                                SqlStr = SqlStr & ", " & Params.Sequencia_Programs
                                SqlStr = SqlStr & ");"
                                IdPauta = db.New_ID(SqlStr)

                                SqlStr = "INSERT INTO pautes_params (pauta_bloc,list_pauta) VALUES (" & BLC_DEF & "," & IdPauta & "), (" & BLC_DEF & "," & IdPauta & ");"
                                db.ExecuteInstruc(SqlStr)
                            End If
                            ' comprovar que la data no existeixi ja al calendari.
                            'Si és així simplement fer un update.	
                            If i = 0 Then
                                Dim cal_id_exist As Integer = CInt(db.ExecuteScalar("SELECT cal_id FROM calendari where cal_data= '" & DateCalendar.ToString("yyyy-MM-dd HH:mm:ss") & "';"))
                                'Dim dtTable As DataTable= db.getTable("SELECT cal_id FROM calendari where cal_data= '" & data.ToString("yyyy-MM-dd HH:mm:ss") & "';")
                                'If dtTable.Rows.Count  > 0 Then cal_id_exist = dtTable.Rows (0)("cal_id")
                                'Buscar la duració total si hi han parts
                                Dim ToatlDuration As DateTime
                                For indx As Integer = 0 To lsvTrackList.Items.Count - 1
                                    If Me.lsvTrackList.Items.Item(i).Checked = True Then
                                        Dim MyDuration As TimeSpan = TimeSpan.Parse(IIf(Me.lsvTrackList.Items.Item(indx).SubItems(2).Text.Length > 0, lsvTrackList.Items.Item(indx).SubItems(2).Text, "00:00:00"))
                                        ToatlDuration = ToatlDuration.Add(MyDuration) '+ New DateTime( 1907,1,1,MyDuration.Hour,MyDuration.Minute,MyDuration.Second)' ToatlDuration.AddHours( + MyDuration 							
                                    End If
                                Next indx
                                If cal_id_exist > 0 Then
                                    SqlStr = "UPDATE calendari SET"
                                    SqlStr += " cal_data ='" & DateCalendar.ToString("yyyy-MM-dd HH:mm:ss") & "' "
                                    SqlStr += ", cal_tipassig = " & CInt(Tipus_AssigDataCalendari.PROGRAM_DATA_HORA)
                                    SqlStr += ", cal_prgtipus = " & CInt(Tipus_Emissio.TIP_AUTOMATIC)
                                    SqlStr += ", cal_pauta = " & IdPauta.ToString
                                    SqlStr += ", cal_descripcio ='" & AddSlashes(Descrip) & "'"
                                    SqlStr += ", cal_prog = " & Prg_id.ToString
                                    SqlStr += ", cal_durada ='" & ToatlDuration.ToString("HH:mm:ss") & "'"
                                    SqlStr += ", cal_reemissio = " & CShort(IIf(Me.chkRemissio.Checked = True, 1, 0))
                                    SqlStr += " WHERE cal_id = " & cal_id_exist & " ;"
                                Else
                                    SqlStr = "INSERT INTO calendari (cal_data, cal_tipassig, cal_prgtipus, cal_pauta, cal_descripcio, cal_prog, cal_durada, cal_reemissio) VALUES "

                                    SqlStr = SqlStr & " ( '" & DateCalendar.ToString("yyyy-MM-dd HH:mm:ss") & "'"
                                    SqlStr = SqlStr & ", " & CInt(Tipus_AssigDataCalendari.PROGRAM_DATA_HORA)
                                    SqlStr = SqlStr & ", " & CInt(Tipus_Emissio.TIP_AUTOMATIC)
                                    SqlStr = SqlStr & ", " & IdPauta.ToString
                                    SqlStr = SqlStr & ", '" & AddSlashes(Descrip) & "'"
                                    SqlStr = SqlStr & ", " & Prg_id.ToString
                                    SqlStr = SqlStr & ", '" & ToatlDuration.ToString("HH:mm:ss") & "'"
                                    SqlStr = SqlStr & ", " & CShort(IIf(Me.chkRemissio.Checked = True, 1, 0))
                                    SqlStr = SqlStr & ")"
                                End If

                                db.ExecuteInstruc(SqlStr)
                                'If WindowIsOpen("frmCalendari")
                                If IsLoadForm("frmCalendari") Then
                                    RefreshDataSet(TAULES_DBS.TAULA_CALENDARI)
                                    RefreshDataSet(TAULES_DBS.TAULA_MIX_PROGRAMES_SESSIONS)
                                    OmplircomboBoxProgramSessions(frmCalendari.ComboBoxProgrames)
                                    frmCalendari.dtpDataRadi.Value = DateCalendar
                                End If
                            End If
                        End If
                        'Si és un programa compartit al núvol, sha de pujar
                        If Me.pic_Cloud.Visible = True And Cloud.ClientType = Cloud.client_type.RADIO_WITH_SERVICES Then
                            Try
                                Dim ActualDBS As String = "dbs=" & MyAPP.getIndexDBS
                                Dim ActualPath As String = Chr(34) & "path=" & path & Chr(34)
                                Dim othersArg As String = "log=1 cloud=1"
                                Dim argProgram As String = "prg=" & Prg_id
                                ' InitName id de la sessió

                                Dim ProcessCloud As New ProcessStartInfo
                                ProcessCloud.FileName = My.Application.Info.DirectoryPath & "\MSCUpload.exe"
                                ProcessCloud.Arguments = ActualDBS & " " & ActualPath & " " & othersArg & " " & argProgram
                                Process.Start(ProcessCloud)
                            Catch ex As Exception
                            End Try
                        End If
                    Case Tipus_Fitxers.FITXER_PUBLICITAT
                        SqlStr = "INSERT INTO falques ( falc_nom, falc_datain, falc_dataout, falc_durada, falc_datacreacio,falc_activa,falc_tarifa)"
                        SqlStr = SqlStr & " VALUES "
                        SqlStr = SqlStr & "( '" & Titol & "'"
                        SqlStr = SqlStr & ", '" & Now.ToString("yyyy-MM-dd") & "'"
                        SqlStr = SqlStr & ", '" & Now.AddDays(Params.DaysDateOut).ToString("yyyy-MM-dd") & "'"
                        SqlStr = SqlStr & ", '" & Duration.ToString("HH:mm:ss") & "'"
                        SqlStr = SqlStr & ", '" & Now.ToString("yyyy-MM-dd HH:mm:ss") & "'"
                        SqlStr = SqlStr & ", " & IIf(Params.FilesActives, 1, 0)
                        SqlStr = SqlStr & ", " & Params.TarifaDef
                        SqlStr = SqlStr & ");"

                        InitName = db.New_ID(SqlStr)
                        createBlocs(InitName, False)
                    Case Else 'Tipus_Fitxers.FITXER_AUDIO_USR
                        'Els fitxers audio_usr
                        'TODO: establir estil i subj.
                        SqlStr = "INSERT INTO audios_params (audio_nom, audio_actv, audio_durada,listaudio_id, audio_style, audio_subj,audio_ritme)"
                        SqlStr = SqlStr & " VALUES "
                        SqlStr = SqlStr & " ( '" & Titol & "'"
                        SqlStr = SqlStr & ", " & IIf(Params.FilesActives, 1, 0)
                        SqlStr = SqlStr & ", '" & Duration.ToString("HH:mm:ss") & "'"
                        SqlStr = SqlStr & ", " & IdAudioUser
                        SqlStr = SqlStr & ", " & 0
                        SqlStr = SqlStr & ", " & 0
                        SqlStr = SqlStr & ", " & BPM
                        SqlStr = SqlStr & ");"

                        InitName = db.New_ID(SqlStr)
                End Select
                Dim FitxerDesti As String = PathDef & InitName & ".mp3"
                'Codificar a MP3
                ImportEncodeFile(path, FitxerDesti, pb)
                pb.Visible = False
                pb = Nothing
            End If
        Next i
        db = Nothing
        If comboBoxOpcions.SelectedValue = Tipus_Fitxers.FITXER_MUSICA Then
            RefreshDataSet(TAULES_DBS.TAULA_INTERPRETS)
            'RefreshDataSet(TAULES_DBS.TAULA_TEMES)        
        ElseIf comboBoxOpcions.SelectedValue = Tipus_Fitxers.FITXER_PROGRAMA Then
            RefreshDataSet(TAULES_DBS.TAULA_SESSIONS_PROGRAMES)
            RefreshDataSet(TAULES_DBS.TAULA_MIX_PROGRAMES_SESSIONS)
        ElseIf comboBoxOpcions.SelectedValue = Tipus_Fitxers.FITXER_PUBLICITAT Then
            RefreshDataSet(TAULES_DBS.TAULA_PUBLICITAT)
        ElseIf comboBoxOpcions.SelectedValue = Tipus_Fitxers.FITXER_AUDIO_USR Then
            RefreshDataSet(TAULES_DBS.TAULA_AUDIO_USERS)
        End If

        Me.picDisc.Enabled = False
        Me.cmdCreaDiscFromTag.Enabled = False

        ' Feina feta, Borra els que hi seleccionats a la llista.
        For counter As Integer = lsvTrackList.Items.Count - 1 To 0 Step -1
            If lsvTrackList.Items.Item(counter).ForeColor = Color.Silver Then
                lsvTrackList.Items.RemoveAt(counter)
            End If
        Next
        Me.cmdAddFitxers.Enabled = True
        Me.cmdRipper.Enabled = (Me.lsvTrackList.Items.Count > 0)
        cmdImport.Enabled = (Me.lsvTrackList.Items.Count > 0)
        BlokUnblokPantalla(True)
        'TODO: fer-ho per threadhead
        If IsNothing(NewIdPod) = False AndAlso NewIdPod.Length > 0 AndAlso Cloud.ClientType = Cloud.client_type.RADIO_WITH_SERVICES Then
            OpenFrmPodCast(NewIdPod)
        End If
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub BlokUnblokPantalla(blEnableas As Boolean)
        GroupDBS.Enabled = blEnableas
        Me.cmdPlay.Enabled = blEnableas
        Me.mnuPlay.Enabled = blEnableas
        AmbTasquesPendents = Not blEnableas
    End Sub

    Public Sub OpenFrmPodCast(NewIdPod() As Integer)
        Dim frmPodCast As New frmPodCast
        frmPodCast.Show()
        frmPodCast.AutomaticUploadFitxer(NewIdPod)
    End Sub

    Private Sub ImportEncodeFile(path As String, FitxerDesti As String, ProgressRipper As MetroFramework.Controls.MetroProgressBar)
        'Dim OptQuality As modLAME.QUALTIY_PRESET = Choose(VB6.GetItemData(cmbQuality, cmbQuality.SelectedIndex), modLAME.QUALTIY_PRESET.LQP_NORMAL_QUALITY, modLAME.QUALTIY_PRESET.LQP_LOW_QUALITY, modLAME.QUALTIY_PRESET.LQP_HIGH_QUALITY, modLAME.QUALTIY_PRESET.LQP_VOICE_QUALITY, modLAME.QUALTIY_PRESET.LQP_R3MIX, modLAME.QUALTIY_PRESET.LQP_VERYHIGH_QUALITY, modLAME.QUALTIY_PRESET.LQP_STANDARD, modLAME.QUALTIY_PRESET.LQP_FAST_STANDARD, modLAME.QUALTIY_PRESET.LQP_EXTREME, modLAME.QUALTIY_PRESET.LQP_FAST_EXTREME, modLAME.QUALTIY_PRESET.LQP_INSANE, modLAME.QUALTIY_PRESET.LQP_ABR, modLAME.QUALTIY_PRESET.LQP_CBR, modLAME.QUALTIY_PRESET.LQP_MEDIUM, modLAME.QUALTIY_PRESET.LQP_FAST_MEDIUM)
        'Dim OptSampleBit As mdlMscDefines.SampleBit = Choose(VB6.GetItemData(cmbSampleBit, cmbSampleBit.SelectedIndex), mdlMscDefines.SampleBit.SAMPLE_BITS_8, mdlMscDefines.SampleBit.SAMPLE_BITS_16)
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

        Dim OptSampleRate As EncoderLAME.SAMPLERATE
        Select Case Params.SampleRate
            Case "22050" : OptSampleRate = EncoderLAME.SAMPLERATE.Hz_22050
            Case "32000" : OptSampleRate = EncoderLAME.SAMPLERATE.Hz_32000
            Case "44100" : OptSampleRate = EncoderLAME.SAMPLERATE.Hz_44100
            Case "48000" : OptSampleRate = EncoderLAME.SAMPLERATE.Hz_48000
        End Select

        Dim OptAudioChannels As EncoderLAME.LAMEMode
        Select Case Params.Channels
            Case "STEREO" : OptAudioChannels = EncoderLAME.LAMEMode.Stereo
            Case "JOINT-STEREO" : OptAudioChannels = EncoderLAME.LAMEMode.JointStereo
            Case "STEREO FORCED" : OptAudioChannels = EncoderLAME.LAMEMode.ForcedJointStereo
            Case "MONO" : OptAudioChannels = EncoderLAME.LAMEMode.Mono
        End Select

        Select Case UCase(IO.Path.GetExtension(path))
            Case ".MP3"
                ProgressRipper.ProgressBarStyle = ProgressBarStyle.Marquee
                'Ja està fet només  s'ha de copiar
                Try
                    IO.File.Copy(path, FitxerDesti, True)
                Catch ex As Exception
                End Try

            Case ".WAV"

                Dim stream As Integer = Bass.BASS_StreamCreateFile(path, 0, 0, BASSFlag.BASS_STREAM_DECODE)
                With ProgressRipper
                    Dim sLength As Single = Bass.BASS_ChannelBytes2Seconds(stream, Bass.BASS_ChannelGetLength(stream))
                    Try
                        .Maximum = sLength
                        .Value = 0
                    Catch ex As Exception
                    End Try
                End With

                Dim l As New EncoderLAME(stream)
                l.InputFile = Nothing 'STDIN
                l.OutputFile = FitxerDesti
                l.LAME_Bitrate = CInt(OptBitRate)
                l.LAME_Mode = OptAudioChannels
                l.LAME_TargetSampleRate = OptSampleRate
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
            Case ".CDA"

                Dim strmPlay As Integer = BassCd.BASS_CD_StreamCreateFile(path, BASSFlag.BASS_STREAM_DECODE Or BASSFlag.BASS_STREAM_PRESCAN)
                If strmPlay = 0 Then
                    'Error al accedir al CD
                End If
                With ProgressRipper
                    Dim sLength As Single = Bass.BASS_ChannelBytes2Seconds(strmPlay, Bass.BASS_ChannelGetLength(strmPlay))
                    Try
                        .Maximum = sLength
                        .Value = 0
                    Catch ex As Exception
                    End Try
                End With

                Dim l As New EncoderLAME(strmPlay)
                l.InputFile = Nothing 'STDIN
                l.OutputFile = FitxerDesti
                l.LAME_Bitrate = CInt(OptBitRate)
                l.LAME_Mode = OptAudioChannels
                l.LAME_TargetSampleRate = OptSampleRate
                l.LAME_Quality = EncoderLAME.LAMEQuality.Quality
                l.Start(Nothing, IntPtr.Zero, False)
                ' decode the stream (if not using a decoding channel, simply call "Bass.BASS_ChannelPlay" here) 
                Dim encBuffer(65536) As Byte ' our dummy encoder buffer 
                While Bass.BASS_ChannelIsActive(strmPlay) = BASSActive.BASS_ACTIVE_PLAYING
                    ' getting sample data will automatically feed the encoder 
                    Dim len As Integer = Bass.BASS_ChannelGetData(strmPlay, encBuffer, encBuffer.Length)

                    Dim Pos As Single = Bass.BASS_ChannelBytes2Seconds(strmPlay, Bass.BASS_ChannelGetPosition(strmPlay))
                    ProgressRipper.Value = Pos
                    Application.DoEvents()
                    Threading.Thread.Sleep(1)

                End While
                l.Stop() ' finish
                Bass.BASS_StreamFree(strmPlay)
        End Select
    End Sub


    Private Sub cmdRipper_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRipper.Click, cmdImport.Click
        RipFitxer()
    End Sub

    Private Sub RefreshCombosDisc()
        If Me.cbDisc.SelectedValue.ToString.Length = 0 Then Exit Sub
        Dim strSql As String = "SELECT disc_interpret, disc_estil , disc_any FROM discos WHERE disc_id = " & Me.cbDisc.SelectedValue
        Dim db As New MSC.dbs(Cloud)
        Dim rs As DataTable = db.getTable(strSql)
        If rs.Rows.Count > 0 Then
            Me.cbInterp.SelectedValue = rs.Rows(0)(0)
            Me.cbEstil.SelectedValue = rs.Rows(0)(1)
            Me.txtAny.Text = rs.Rows(0)(2).ToString
        End If
        db = Nothing

    End Sub

#Region "CDDB"

    Private Sub GetCDTracks(ByVal path As String, ByVal cdEntry As CDEntry)
        Dim directoryEntries() As String
        If IO.Directory.Exists(path) = True Then
            directoryEntries = System.IO.Directory.GetFileSystemEntries(path)
            If directoryEntries.GetLength(0) > 1 Then
                For i As Short = 0 To directoryEntries.Length - 1
                    Try
                        Dim track As Track = cdEntry.Tracks(i)
                        lsvTrackList.Items(i).Text = track.Title
                        lsvTrackList.Items(i).SubItems(1).Text = cdEntry.Artist
                        lsvTrackList.Items(i).SubItems(2).Text = cdEntry.Year
                    Catch ex As Exception
                        Exit For
                    End Try
                Next i
            End If
        End If
    End Sub

    Private Sub cmdCDDB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCDDB.Click
        If lsvTrackList.Items.Count = 0 Then Exit Sub
        System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
        MetroProgressSpinnerCDDB.Visible = True

        Application.DoEvents()

        Dim m_freedb As FreedbHelper
        m_freedb = New FreedbHelper
        m_freedb.ClientName = CDDB_ClientName
        m_freedb.Version = CDDB_Version
        m_freedb.SetDefaultSiteAddress(CDDB_Server)
        m_freedb.UserName = CDDB_Username
        m_freedb.Hostname = CDDB_HostName

        Application.DoEvents()


        Dim IDCdDrive As Integer  'Me.comboBoxCdDrivers.SelectedIndex
        If comboBoxCdDrivers.Tag.ToString.Length > 0 Then
            IDCdDrive = CInt(comboBoxCdDrivers.Tag)
        Else
            IDCdDrive = Me.comboBoxCdDrivers.SelectedIndex
        End If

        Dim query As String = cmdCDDB.Tag

        Dim QueryResult As QueryResult = Nothing
        Dim coll As QueryResultCollection = Nothing
        Dim code As String = String.Empty
        Try
            Application.DoEvents()

            code = m_freedb.Query(query, QueryResult, coll)
        Catch ex As Exception
            MetroProgressSpinnerCDDB.Visible = False
            MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_CDDB_GET_INFO, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
            Exit Sub
        End Try

        '//inexact match or multiple mathes show selection dialog
        If code = FreedbHelper.ResponseCodes.CODE_210 Or code = FreedbHelper.ResponseCodes.CODE_211 Then
            'Hi ha més d'una entrada, ensenyar DialogResult per escollir
            Dim dlg As New frmCDDBMultipleResult
            dlg.CDDBMultipleResult(coll)
            Dim result As DialogResult = dlg.ShowDialog()
            If (result = System.Windows.Forms.DialogResult.Cancel) Then
                MetroProgressSpinnerCDDB.Visible = False
                MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_CDDB_SELECT_INPUT, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
                Exit Sub
            End If
            QueryResult = dlg.SelectedQueryResult
        ElseIf code <> FreedbHelper.ResponseCodes.CODE_200 Then
            MetroProgressSpinnerCDDB.Visible = False
            MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_CDDB_NO_FOUND_CD, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
            Exit Sub
        End If

        'queryResult now contains the results of our query.
        Dim cdEntry As CDEntry = Nothing
        Application.DoEvents()

        code = m_freedb.Read(QueryResult, cdEntry)
        If code <> FreedbHelper.ResponseCodes.CODE_210 Then
            MetroFramework.MetroMessageBox.Show(Me, String.Format(MSG_ERROR_CDDB_DISABLE_INPUT, code), MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
        End If
        Dim info As New Un4seen.Bass.AddOn.Cd.BASS_CD_INFO
        BassCd.BASS_CD_GetInfo(IDCdDrive, info)
        GetCDTracks(info.DriveLetter + ":\\", cdEntry)
        Application.DoEvents()

        CalcDoradaTacksCD()

        Dim Artist As String = IIf(My.Settings.TXT_CAPITALIZE = True, cdEntry.Artist.Trim.ToUpper, cdEntry.Artist.Trim)
        Dim Title As String = IIf(My.Settings.TXT_CAPITALIZE = True, cdEntry.Title.Trim.ToUpper, cdEntry.Title.Trim)
        Dim Estil As String = IIf(My.Settings.TXT_CAPITALIZE = True, cdEntry.Genre.Trim.ToUpper, cdEntry.Genre.Trim)
        If Title.Length > 0 Then OpcioDiscNou(Title, Artist, cdEntry.Year, Nothing, Estil)
        MetroProgressSpinnerCDDB.Visible = False
    End Sub
    Private Sub CalcDoradaTacksCD()
        For i As Short = 0 To Me.lsvTrackList.Items.Count - 1
            Application.DoEvents()

            Dim Path As String = lsvTrackList.Items(i).Tag
            Dim strmHandle As Integer = BassCd.BASS_CD_StreamCreateFile(Path, BASSFlag.BASS_STREAM_AUTOFREE)
            Dim len As Long = Bass.BASS_ChannelGetLength(strmHandle)
            Dim Duration As String = TimeSerial(0, 0, Bass.BASS_ChannelBytes2Seconds(strmHandle, len)).ToString("HH:mm:ss")
            lsvTrackList.Items(i).SubItems(2).Text = Duration
        Next i
    End Sub

#End Region

    Private Sub lbDisc_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbDisc.LinkClicked
        Dim FrmChild As New frmDiscos
        Try
            FrmChild.IniTable()
            If cbDisc.SelectedValue > 0 Then FrmChild.getListDiscos(" disc_nom = '" & Me.cbDisc.Text & "'")
            If FrmChild.ShowDialog = DialogResult.OK Then
                Dim Cmb As New combo
                Cmb.OmpleCombo(cbDisc, TAULES_DBS.TAULA_DISCOS, TotsCap.CAP)
                cbDisc.SelectedValue = FrmChild.ID
            End If
        Catch ex As Exception
        End Try
        FrmChild = Nothing
    End Sub

    Private Sub lbInterp_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbInterp.LinkClicked
        Dim FrmChild As New frmMantInterp
        Try
            FrmChild.IniTable()
            If cbInterp.SelectedValue > 0 Then FrmChild.establirRecordset(" interp_nom = '" & Me.cbInterp.Text & "'")
            If FrmChild.ShowDialog = DialogResult.OK Then
                Dim Cmb As New combo
                Cmb.OmpleCombo(cbInterp, TAULES_DBS.TAULA_INTERPRETS, TotsCap.CAP)
                cbInterp.SelectedValue = FrmChild.ID
            End If
        Catch ex As Exception
        End Try
        FrmChild = Nothing
    End Sub

    Private Sub lbEstil_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbEstil.LinkClicked
        Dim FrmChild As New frmMantEstil
        Try
            FrmChild.IniTable()
            If cbEstil.SelectedValue > 0 Then FrmChild.establirRecordset(" estil_nom = '" & Me.cbEstil.Text & "'")
            If FrmChild.ShowDialog = DialogResult.OK Then
                Dim Cmb As New combo
                Cmb.OmpleCombo(cbEstil, TAULES_DBS.TAULA_ESTILS, TotsCap.CAP)
                cbEstil.SelectedValue = FrmChild.ID
            End If
        Catch ex As Exception
        End Try
        FrmChild = Nothing
    End Sub

    Private Sub lbIdioma_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbIdioma.LinkClicked
        Dim FrmChild As New frmMantIdioma
        Try
            FrmChild.IniTable()
            If cbIdioma.SelectedValue > 0 Then FrmChild.establirRecordset(" nom_nadiu = '" & Me.cbIdioma.Text & "'")
            If FrmChild.ShowDialog = DialogResult.OK Then
                Dim Cmb As New combo
                Cmb.OmpleCombo(cbIdioma, TAULES_DBS.TAULA_IDIOMES, TotsCap.CAP)
                cbIdioma.SelectedValue = FrmChild.ID
            End If
        Catch ex As Exception
        End Try
        FrmChild = Nothing
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
            If lsvTrackList.Items.Count = 0 Then Exit Sub
            Dim Id As Short
            Dim StrPathPlay As String
            Try
                Id = lsvTrackList.FocusedItem.Index
            Catch ex As Exception
                Id = 0
            Finally
                StrPathPlay = lsvTrackList.Items(Id).Tag
            End Try

            If Not IO.File.Exists(StrPathPlay) Then MetroFramework.MetroMessageBox.Show(Me, "El fitxer " & StrPathPlay & " no existeix.", MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100) : Exit Sub
            Bass.BASS_ChannelStop(StreamHandlePlay)
            Select Case UCase(IO.Path.GetExtension(StrPathPlay))
                Case ".CDA"
                    StreamHandlePlay = BassCd.BASS_CD_StreamCreateFile(StrPathPlay, BASSFlag.BASS_STREAM_AUTOFREE)
                Case Else ' .mp3 .wav
                    StreamHandlePlay = Bass.BASS_StreamCreateFile(StrPathPlay, 0, 0, BASSFlag.BASS_DEFAULT)
            End Select

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

    Private Sub mnuPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFinal.Click, mnuCalcDurada.Click, mnuStop.Click, mnuPlay.Click, mnuEndTrack.Click

        Select Case CType(sender, ToolStripMenuItem).Tag
            Case 1 : PlayFitxer()
            Case 2 : stopFitxer()
            Case 3
                Dim len As Long = Bass.BASS_ChannelGetLength(StreamHandlePlay)
                Dim LenInSeg As Single = Bass.BASS_ChannelBytes2Seconds(StreamHandlePlay, len)
                Bass.BASS_ChannelSetPosition(StreamHandlePlay, CSng(LenInSeg - 20))
        End Select
    End Sub

#End Region

    Private Sub cmdCreaDiscFromTag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCreaDiscFromTag.Click
        Dim interpStr As String = AddSlashes(Me.lbInfoInterp.Text)
        Dim Any As String = Me.lbInfoAny.Text
        Dim NomDisc As String = AddSlashes(Me.lbInfoDisc.Text)
        Dim EstilStr As String = AddSlashes(Me.lbInfoEstil.Text)
        Dim Estil As Short
        Dim Interp As Short
        Me.cmdCreaDiscFromTag.Enabled = False

        'Busca Interpret
        Dim db As New MSC.dbs(Cloud)
        Dim sCmd As String = "interp_nom = '" & Replace(interpStr, "'", "") & "'"
        dsClient.Tables("interprets").CaseSensitive = False
        Dim colec() As DataRow = dsClient.Tables("interprets").Select(sCmd)

        If colec.Length = 1 Then
            Interp = colec(0)("interp_id")
        ElseIf colec.Length > 1 Then
            Dim frmSElectInterp As New frmSelectItem(1, " interp_nom Like '%" & Replace(interpStr, "'", "") & "%'", interpStr)
            If frmSElectInterp.ShowDialog() = System.Windows.Forms.DialogResult.Cancel Then
                Interp = CreateNewInterp(interpStr)
            Else
                Interp = frmSElectInterp.ID_SELECT
            End If
            frmSElectInterp.Dispose()
            frmSElectInterp = Nothing
        ElseIf colec.Length = 0 Then
            Interp = CreateNewInterp(interpStr)
        End If
        'Busca Estil
        sCmd = "estil_nom = '" & EstilStr & "'"
        dsClient.Tables("estils").CaseSensitive = False
        colec = dsClient.Tables("estils").Select(sCmd)
        If colec.Length = 1 Then
            Estil = colec(0)("estil_id")
        ElseIf colec.Length > 1 Then
            Dim frmSElectEstil As New frmSelectItem(0, "estil_nom LIKE '%" & EstilStr & "%'", EstilStr)
            If frmSElectEstil.ShowDialog() = System.Windows.Forms.DialogResult.Cancel Then
                Estil = CreateNewEstil(EstilStr)
            Else
                Estil = frmSElectEstil.ID_SELECT
            End If
            frmSElectEstil.Dispose()
            frmSElectEstil = Nothing
        ElseIf colec.Length = 0 Then
            Estil = CreateNewEstil(EstilStr)
        End If

        If Any.Length = 0 Then Any = 0
        sCmd = "INSERT INTO discos ( disc_datain , disc_any, disc_nom,"
        sCmd = sCmd & "disc_numtracs, disc_format, disc_estil, "
        sCmd = sCmd & " disc_interpret,disc_codibar,disc_web,disc_comentari)"
        sCmd = sCmd & " VALUES "
        sCmd = sCmd & " ( '" & Now.ToString("yyyy-MM-dd HH:mm:ss") & "'"
        sCmd = sCmd & ", " & Any
        sCmd = sCmd & ", '" & NomDisc & "'"
        sCmd = sCmd & ", " & Me.lsvTrackList.Items.Count
        sCmd = sCmd & ", " & formats.MP3
        sCmd = sCmd & ", " & Estil
        sCmd = sCmd & ", " & Interp
        sCmd = sCmd & ", '" & LIST_NO_DEF & "'"
        sCmd = sCmd & ", ' '"
        sCmd = sCmd & ", ' '"

        sCmd = sCmd & ");"
        Dim ID As Integer = db.New_ID(sCmd)
        Dim cover As Image = picDisc.Image
        If Me.picDisc.Tag = "savefoto" Then InsertPig(ID, cover)
        Dim Cmb As New combo
        RefreshDataSet(TAULES_DBS.TAULA_DISCOS)
        Cmb.OmpleCombo(cbDisc, TAULES_DBS.TAULA_DISCOS, TotsCap.CAP)
        RefreshDataSet(TAULES_DBS.TAULA_INTERPRETS)
        Cmb.OmpleCombo(cbInterp, TAULES_DBS.TAULA_INTERPRETS, TotsCap.CAP)
        RefreshDataSet(TAULES_DBS.TAULA_ESTILS)
        Cmb.OmpleCombo(cbEstil, TAULES_DBS.TAULA_ESTILS, TotsCap.CAP)

        cbDisc.SelectedValue = ID
        RefreshCombosDisc()
        colec = Nothing
        db = Nothing

    End Sub

    Private Function CreateNewEstil(Str As String) As Integer
        Dim db As New MSC.dbs(Cloud)
        Dim sCmd As String = "INSERT INTO estils (estil_nom ) VALUES ('" & Str & "');"
        Dim ret As Integer = db.New_ID(sCmd) 's'ha de crear nou
        db = Nothing
        Return ret
    End Function

    Private Function CreateNewInterp(Str As String) As Integer
        Dim db As New MSC.dbs(Cloud)
        Dim sCmd As String = "INSERT INTO interprets (interp_nom ) VALUES ('" & Str & "');"
        Dim ret As Integer = db.New_ID(sCmd) 's'ha de crear nou
        db = Nothing
        Return ret
    End Function

    Private Sub txtVDEF_DateOut_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        If KeyAscii < Asc("0") Or KeyAscii > Asc("9") Then If KeyAscii <> 8 Then KeyAscii = 0
        e.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub mnuEditAudio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Bass.BASS_ChannelStop(StreamHandlePlay)
        Bass.BASS_StreamFree(StreamHandlePlay)
        If ProgEditAudio.Length > 0 Then
            Dim PathFitxer As String = ""
            For i As Integer = 0 To lsvTrackList.SelectedItems.Count - 1
                Dim tempPath As String = Me.lsvTrackList.SelectedItems(i).Tag
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

    Private Sub picDisc_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles picDisc.DoubleClick
        If Me.OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Me.picDisc.Image = resizeImageFromPath(OpenFileDialog1.FileName, MAX_WIDTH_IMG, MAX_HEIDTH_IMG)
            picDisc.Cursor = Cursors.Hand
            picDisc.Tag = "savefoto"
        End If

    End Sub

    Private Sub mnu_Help_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Sub MnuTítolIntèrpretClick(sender As Object, e As EventArgs) Handles mnuTítolIntèrpret.Click, mnuCapturarTítolIntèrpret.Click, mnuCapturarIntèrpretTítol.Click
        Dim Index As Short = CShort(CType(sender, ToolStripMenuItem).Tag)
        Dim separador As String = Choose(mnuEditListComboBoxSeparadors.SelectedIndex + 1, "-", "_", "/", "\").ToString
        Dim ArrayValues(4) As String
        For i As Integer = 0 To lsvTrackList.SelectedItems.Count - 1
            Select Case Index
                Case 0
                    Dim StrInterp As String = lsvTrackList.SelectedItems.Item(i).SubItems.Item(1).Text
                    Dim StrTitol As String = lsvTrackList.SelectedItems.Item(i).SubItems.Item(0).Text
                    lsvTrackList.SelectedItems.Item(i).SubItems.Item(1).Text = StrTitol.Trim
                    lsvTrackList.SelectedItems.Item(i).SubItems.Item(0).Text = StrInterp.Trim
                Case 1
                    Try
                        ParseDelimStr(lsvTrackList.SelectedItems.Item(i).SubItems.Item(0).Text, separador, ArrayValues)
                        lsvTrackList.SelectedItems.Item(i).SubItems.Item(1).Text = ArrayValues(1).Trim
                        lsvTrackList.SelectedItems.Item(i).SubItems.Item(0).Text = ArrayValues(2).Trim
                    Catch ex As Exception
                    End Try
                Case 2
                    Try
                        ParseDelimStr(lsvTrackList.SelectedItems.Item(i).SubItems.Item(0).Text, separador, ArrayValues)
                        lsvTrackList.SelectedItems.Item(i).SubItems.Item(0).Text = ArrayValues(1).Trim
                        lsvTrackList.SelectedItems.Item(i).SubItems.Item(1).Text = ArrayValues(2).Trim
                    Catch ex As Exception
                    End Try
            End Select
        Next

    End Sub

    Sub MnuEditSelectOpening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mnuEditSelect.Opening

        mnuTítolIntèrpret.Enabled = CBool(lsvTrackList.SelectedItems.Count > 0)
        mnuCapturarIntèrpretTítol.Enabled = CBool(lsvTrackList.SelectedItems.Count > 0)
        mnuCapturarTítolIntèrpret.Enabled = CBool(lsvTrackList.SelectedItems.Count > 0)
        mnuEditListComboBoxSeparadors.Enabled = CBool(lsvTrackList.SelectedItems.Count > 0)
    End Sub

    Sub Chk_PrgCalendarCheckedChanged(sender As Object, e As EventArgs) Handles chk_PrgCalendar.CheckedChanged
        Me.groupBoxCalendar.Visible = chk_PrgCalendar.Checked
    End Sub

    Sub ComboBoxProgramesSelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxProgrames.SelectedIndexChanged
        'Si és un programa compartit al núvol s'ha de penjar
        Dim prg_id As Integer = Me.ComboBoxProgrames.SelectedValue
        If prg_id > 0 Then pic_Cloud.Visible = IsProgramaForUploadCloud(prg_id)

        chkPubliPodcast.Enabled = (prg_id > 0)
        Me.chk_PrgCalendar.Enabled = (prg_id > 0)
        If prg_id = 0 Then
            chkPubliPodcast.Checked = False
            chk_PrgCalendar.Checked = False
        End If

    End Sub

    Sub SortirToolStripMenuItemClick(sender As Object, e As EventArgs) Handles mnuAppExit.Click
        Me.Close()
    End Sub

    Sub ComboBoxOpcionsSelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBoxOpcions.SelectedIndexChanged
        Me.GroupMusic.Visible = False
        GroupBoxProgrames.Visible = False
        Me.GroupMusic.Visible = (Me.comboBoxOpcions.SelectedValue = Tipus_Fitxers.FITXER_MUSICA)
        GroupBoxProgrames.Visible = (Me.comboBoxOpcions.SelectedValue = Tipus_Fitxers.FITXER_PROGRAMA)
        lbInfoImport.Text = MSC_LABEL_INFO_IMPORT & " " & comboBoxOpcions.Text

        TestWriteDir()
    End Sub

    Private Sub picVuMeter_MouseClick(sender As Object, e As MouseEventArgs) Handles picVuMeter.MouseClick
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

#Region "Common basic Buttons"

    Private Sub buttonExit_Click(sender As Object, e As EventArgs) Handles cmdSortir.Click
        Me.Close()
    End Sub

    Private Sub mnuAppExit_Click(sender As Object, e As EventArgs) Handles mnuAppExit.Click
        Me.Close()
    End Sub

    Private Sub mnuHelpManual_Click(sender As Object, e As EventArgs) Handles mnuHelpManual.Click
        Dim Proces As Process = New Process
        Try
            Process.Start(MSC.Help.HELP_GEST_IMPORT.ToString)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdDel_Click(sender As Object, e As EventArgs) Handles cmdDel.Click
        BorrarFitxer()
    End Sub

    Private Sub frmImport_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        Dim FitxerINI As New IniFile
        frm_sice(0) = Me.Width : frm_sice(1) = Me.Height
        FitxerINI.INIWrite(MyAPP.IniFile, "Data Gest", "size", frm_sice(0).ToString & "," & frm_sice(1).ToString)
    End Sub

    Private Sub mnuEditItem_Click(sender As Object, e As EventArgs) Handles mnuEditItem.Click
        ShowEditTag()
    End Sub

#End Region

End Class
