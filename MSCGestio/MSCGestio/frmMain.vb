Option Strict Off
Option Explicit On

Imports BassTags = Un4seen.Bass.AddOn.Tags.BassTags
Imports Un4seen.Bass
Imports System.Drawing
Imports System.Net.Mail
Imports System.Threading

Imports System.Security.AccessControl

Public Class frmMain
	Enum MNU_IMPORT
		MNU_IMPORT_RIPPER = 0
		MNU_IMPORT_JAMENDO = 1
	End Enum
	
	Enum MNU_PRG
		MNU_PRG_END = 0
	End Enum

    Enum MNU_MUSIC
		MNU_MUSIC_DISCOS = 0
		MNU_MUSIC_TEMES = 1


        MNU_MUSIC_PROGRAM = 6
		MNU_MUSIC_NEWS = 7
		MNU_MUSIC_LLISTA_EXITS = 9
		'Manteniment = 11
		MNU_MUSIC_PROVEI = 13
		MNU_MUSIC_GRAF = 15
		MNU_MUSIC_EQUIVAL_INTERP = 17
		MNU_MUSIC_ESDEVENIMENTS = 19
		'Opcions = 21        
	End Enum
	
	Enum MNU_MUSIC_MANT
		MNU_MUSIC_MANT_INTERP = 0
		MNU_MUSIC_MANT_ESTIL = 1
		MNU_MUSIC_MANT_SUBJ = 2
		MNU_MUSIC_MANT_CIA = 3
		MNU_MUSIC_MANT_IDIOMES = 4
		MNU_MUSIC_MANT_TAGS = 5
		MNU_MUSIC_MANT_CAT_NEWS = 6
	End Enum
	
	Enum MNU_MUSIC_OPCIO
		MNU_MUSIC_OPCIO_NO_LOAD_RS = 0
		MNU_MUSIC_OPCIO_VISIBLE_NEW = 1
	End Enum
	
	Enum MNU_PUBLI
		MNU_PUBLI_FALQUES = 0
		MNU_PUBLI_CTLBLOCS = 1
		MNU_PUBLI_LOCUTOR = 5
		MNU_PUBLI_TECNICS = 6
		MNU_PUBLI_AGENTCOMER = 7		
		MNU_PUBLI_FRANGES = 8 
		MNU_PUBLI_INFORMS = 10
	End Enum
	
	Enum MNU_PUBLI_MANT
		MNU_PUBLI_MANT_CLIENT = 0
		MNU_PUBLI_MANT_PRODUCT = 1
		MNU_PUBLI_MANT_TARIFA = 2
	End Enum
	
	Enum MNU_ATOMAT
		MNU_ATOMAT_BLOCS = 0
		MNU_ATOMAT_PAUTES = 1
		MNU_ATOMAT_CALENDAR = 2
		MNU_ATOMAT_LOGGER = 3
        MNU_ATOMAT_PODCAST = 4
        MNU_ATOMAT_CTLRADIACIO = 6
        MNU_ATOMAT_PARAMS = 8
    End Enum
	
	Enum MNU_ATOMAT_BKP		
		MNU_ATOMAT_BKP_DADES = 0
		MNU_ATOMAT_EXPORT_FILES = 1
	End Enum
	
	Enum MNU_USR
		MNU_USR_USR = 0
		MNU_USR_CANVIPSW = 1
		MNU_USR_INISESSIO = 2
	End Enum
	
	Enum MNU_REF
		MNU_REF_AUTORIT = 0
		MNU_REF_CREDITS = 1
		MNU_REF_WEB = 2
		MNU_REF_HELP = 3
		MNU_REF_EMAIL = 4
		MNU_REF_VERSIO = 5
		MNU_REF_MONITOR = 7
	End Enum
	
	Enum MNU_BOTONS
        MNU_BOTONS_RIPPER = 0
        MNU_BOTONS_JAMENDO = 1

        MNU_BOTONS_DISCOS = 3
        MNU_BOTONS_TEMES = 4
        MNU_BOTONS_PROGRAM = 5

        MNU_BOTONS_PUBLI = 7
        MNU_BOTONS_CTL_BLOCS = 8
        MNU_BOTONS_INFORM_RADI = 9

        MNU_BOTONS_BLOCS_MUSIC = 11
        MNU_BOTONS_PAUTES = 12
        MNU_BOTONS_CALENDAR = 13
        MNU_BOTONS_CTL_RADI = 14
        MNU_BOTONS_PROG_LOGGER = 15
        MNU_BOTONS_PODCASTING = 16
        MNU_BOTONS_PARAMS = 17

        MNU_BOTONS_AUDIO_USER = 18
    End Enum
	
	Public IsDebug As Boolean
	Public NoLoadRs As Boolean
	Public VisibleNew As Boolean
	Dim OldWinState As Short = FormWindowState.Normal
	
	Dim filInstucServer As Thread
	Dim RI As MSC.InstruccionsRemotes
	Dim ClientFTP As FtpClient

    Dim Location_x As Integer
    Dim screenID As Integer

    Private Sub frmMain_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        SetPositionMain()
    End Sub

    Private Sub SetPositionMain()
        If Screen.AllScreens.Length <= screenID Then screenID = 0
        Dim my_screen As Screen = Screen.AllScreens(screenID)
        'If Location_x < 0 Or my_screen.Bounds.X + my_screen.Bounds.Width < Location_x Then
        'Location_x = my_screen.Bounds.Width - 325 'Screen.PrimaryScreen.Bounds.Width - 325
        'End If

        Dim targetHeight As Integer = my_screen.Bounds.Height - 45
        Me.ClientSize = New Size(325, targetHeight)
        Me.Location = New Point(Location_x, my_screen.Bounds.Top)
        Me.Top = my_screen.Bounds.Top
        Try
            groupBotons.Controls(0).Select()
        Catch ex As Exception
        End Try
        Me.Refresh()
    End Sub

    Private Sub ResetPositionMain()
        Dim FitxerINI As New IniFile
        FitxerINI.INIDelete(MyAPP.IniFile, "Data Gest", "screenID")
        FitxerINI.INIDelete(MyAPP.IniFile, "Data Gest", "LOCATION_X")
    End Sub

    Private Sub frmMain_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate

        Dim my_screen As Screen = Screen.AllScreens(screenID)
        Dim old_width As Integer = Me.Width
        Dim new_width As Integer = 25
        Dim targetHeight As Integer = my_screen.Bounds.Height - 50
        Me.ClientSize = New Size(new_width, targetHeight)

        Me.Location = New Point(Location_x + old_width - new_width, my_screen.Bounds.Top)

    End Sub

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If AmbTasquesPendents = True Then
            e.Cancel = True
            WindowState = System.Windows.Forms.FormWindowState.Minimized
        Else
            saveBotons()

            Dim FitxerINI As New IniFile
            FitxerINI.INIWrite(MyAPP.IniFile, "Data Gest", "DEV_PLAY", cmbDevice.SelectedIndex)


            For i As Integer = 0 To Screen.AllScreens().Length - 1
                If Screen.AllScreens(i).DeviceName.ToString = Screen.FromControl(Me).DeviceName.ToString Then
                    FitxerINI.INIWrite(MyAPP.IniFile, "Data Gest", "screenID", i)
                    If Me.Width > 25 Then FitxerINI.INIWrite(MyAPP.IniFile, "Data Gest", "LOCATION_X", Me.Location.X)
                    Exit For
                End If
            Next

            'salvem el lleguatge actual (s'estableix per defecte)
            FitxerINI.INIWrite(MyAPP.IniFile, "Data Key", "DEF_LANG", lang.Code)


            FitxerINI = Nothing

            My.Settings.TXT_CAPITALIZE = Me.mnuTxtCapitalize.Checked
            My.Settings.LOADRS = mnuMusicOpcioLoadRS.Checked
            My.Settings.VisibleNew = mnuMusicOpcioBotoNew.Checked

            Try
                My.Settings.Save()
            Catch ex As Exception
            End Try
            Me.Hide()
        End If
    End Sub


    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
#If HideJamendo = "1" Then
    mnuImportJamendo.Visible = False
    mnuPrgBotonsJamendo.Visible = False
#End If

        setLanguageForm()
        RI = New MSC.InstruccionsRemotes(MyAPP.IDSesion_Client)
        filInstucServer = New Thread(AddressOf RI.getRemoteInstruccions)

        Dim ShortCut As Integer = 0

        Dim i As Short
        For i = 0 To My.Application.CommandLineArgs.Count - 1
            If My.Application.CommandLineArgs.Item(i).ToLower = "debug" Then IsDebug = True
            If My.Application.CommandLineArgs.Item(i).ToLower = "calendar" Then ShortCut = 1
            If My.Application.CommandLineArgs.Item(i).ToLower = "ripper" Then ShortCut = 2
            If My.Application.CommandLineArgs.Item(i).ToLower = "music" Then ShortCut = 3
            If My.Application.CommandLineArgs.Item(i).ToLower = "publi" Then ShortCut = 4
            If My.Application.CommandLineArgs.Item(i).ToLower = "reset" Then ResetPositionMain()
            'If My.Application.CommandLineArgs.Item(i).ToLower = "jamendo" Then ENABLE_JAMENDO = True

        Next i
        'mnuImportJamendo.Visible = ENABLE_JAMENDO
        'mnuPrgBotonsJamendo.Visible = ENABLE_JAMENDO

        mnuTxtCapitalize.Checked = My.Settings.TXT_CAPITALIZE 'BUG: No sé perqué però no estableix el checked.
        NoLoadRs = My.Settings.LOADRS
        VisibleNew = My.Settings.VisibleNew
        CType(mnuMusicOpcio.DropDownItems(MNU_MUSIC_OPCIO.MNU_MUSIC_OPCIO_NO_LOAD_RS), ToolStripMenuItem).Checked = NoLoadRs
        CType(mnuMusicOpcio.DropDownItems(MNU_MUSIC_OPCIO.MNU_MUSIC_OPCIO_VISIBLE_NEW), ToolStripMenuItem).Checked = VisibleNew

        mnuRefMare.DropDownItems.Add(LABEL_SERVER & ": " & MyAPP.getServerName & " / " & MyAPP.getDBSName)
        If Cloud.IsActive = True Then mnuRefMare.DropDownItems.Add(MSG_SYNC_CLOUD)

        CarregaListAudio()
        HabilitarPerUsuari()

        Dim FitxerINI As New IniFile
        screenID = FitxerINI.INIRead(MyAPP.IniFile, "Data Gest", "screenID", 0)
        Location_x = FitxerINI.INIRead(MyAPP.IniFile, "Data Gest", "LOCATION_X", Screen.PrimaryScreen.Bounds.Width - 325)

        Dim sz() As String = Split(FitxerINI.INIRead(MyAPP.IniFile, "Data Gest", "size", frm_sice(0).ToString & "," & frm_sice(1).ToString), ",")
        frm_sice(0) = CInt(sz(0)) : frm_sice(1) = CInt(sz(1))

        ProgEditAudio = FitxerINI.INIRead(MyAPP.IniFile, "Data Control", "ProgEditAudio", "")
        If ProgEditAudio.Length > 0 AndAlso IO.File.Exists(ProgEditAudio) Then
            Dim versionInfo As FileVersionInfo = System.Diagnostics.FileVersionInfo.GetVersionInfo(ProgEditAudio)
            Me.mnuProgEditAudio.Text = "Editor: " & versionInfo.FileDescription
        End If

        'Àudio
        listDevice()
        'Inicia el Rproductor d'àudio
        DEV_PLAY = CShort(FitxerINI.INIRead(MyAPP.IniFile, "Data Gest", "DEV_PLAY", "0"))
        FitxerINI = Nothing
        Try
            cmbDevice.SelectedIndex = DEV_PLAY
        Catch ex As Exception
        End Try

        Dim frmOpen As MetroFramework.Forms.MetroForm = frmImport
        Select Case ShortCut
            Case 1 'calendar
                frmOpen = New frmCalendari
                If MyAPP.NovaConnex(DESCRIP_FORM_CALENDARI, Usuari.UsrNom, True) = True Then frmOpen.Show()
            Case 2 'ripper
                frmOpen = New frmImport
                If MyAPP.NovaConnex(DESCRIP_FORM_RIPPER, Usuari.UsrNom, True) = True Then frmOpen.Show()
            Case 3 'music
                frmOpen = New frmTemes
                If MyAPP.NovaConnex(DESCRIP_FORM_TEMES, Usuari.UsrNom, True) = True Then frmOpen.Show()
            Case 4 'publi	
                frmOpen = New frmPubli
                If MyAPP.NovaConnex(DESCRIP_FORM_PUBLICITAT, Usuari.UsrNom, True) = True Then frmOpen.Show()
        End Select

        lbNomRadio.Text = Params.NomRadio()



        tmrHora.Enabled = True

    End Sub


    Dim LABEL_TANCAR As String
    Dim LABEL_SERVER As String
    Dim MSG_NO_TASKS As String
    Dim MSG_TASKS_PENDING As String
    Dim LABEL_INI_SYSTEM As String
    Dim LABEL_DONATION As String
    Dim MSG_SYNC_CLOUD As String

    Public Sub setLanguageForm()
        lang.StrForm = Me.Name
        setLanguageGlobal()

        MSG_SYNC_CLOUD = Lang.getText("LABEL_SYNC_CLOUD", True) '"Sincronitzat amb el núvol"
        LABEL_TANCAR = lang.getText("LABEL_CERRAR", True)
        LABEL_SERVER = lang.getText("LABEL_SERVER", True)
        LABEL_DONATION = lang.getText("LABEL_DONATE", True)
        LABEL_INI_SYSTEM = lang.getText("LABEL_INI_SYSTEM")

        Me.mnuPrgMare.Text = lang.getText("mnuPrgMare.Text") '"Pro&grama"		
        Me.mnuPrgClose.Text = lang.getText("LABEL_CERRAR", True) '"Tancar"
        Me.mnuPrgBotons.Text = lang.getText("mnuPrgBotons.Text") ' "Botons a la barra"

        Me.mnuPrgBotonsRipper.Text = lang.getText("LABEL_IMPORTAR", True) '"Ripper" ara Importar
        Me.mnuPrgBotonsDiscos.Text = lang.getText("LABEL_ALBUMS", True) '"Discos"

        Me.mnuPrgBotonsPrg.Text = lang.getText("NAME_PROGRAMES", True) '"Programes"
        DESCRIP_FORM_PROGRAMES = lang.getText("NAME_PROGRAMES", True) '"Programes"
        Me.mnuPrgBotonsPubli.Text = lang.getText("HEADERTEXT_PUBLICITAT", True) '"Publicitat"

        DESCRIP_FORM_INFORMES = lang.getText("mnuPubliInform.Text") '"Informes de Radiació"
        Me.mnuPubliInform.Text = DESCRIP_FORM_INFORMES

        Me.mnuPrgBotonsInform.Text = DESCRIP_FORM_INFORMES '"Informes de radiació"
        Me.mnuPrgBotonsBlocs.Text = lang.getText("LABEL_BLOCS_MUSIC", True) '"Blocs Musicals"

        Me.mnuPrgBotonsCalendar.Text = lang.getText("LABEL_CALENDAR", True) '"Calendari"

        Me.mnuPrgBotonsProgLogger.Text = lang.getText("mnuPrgBotonsProgLogger.Text") '"Logger Prog."
        Me.mnuPrgBotonsPodcasting.Text = lang.getText("LABEL_PODCASTING", True) '"Podcasting"

        Me.mnuImportMare.Text = lang.getText("mnuImportMare.Text") '"&Importar"

        DESCRIP_FORM_RIPPER = lang.getText("LABEL_IMPORTAR", True) '"Ripper" ara Importar
        Me.mnuImport.Text = DESCRIP_FORM_RIPPER
        DESCRIP_FORM_JAMENDO = "Jamendo Music"
        mnuImportJamendo.Text = DESCRIP_FORM_JAMENDO

        Me.mnuMusicMare.Text = lang.getText("mnuMusicMare.Text") '"&Producció"
        DESCRIP_FORM_DISCOS = lang.getText("LABEL_ALBUMS", True) '"Discos"
        Me.mnuMusicDiscos.Text = DESCRIP_FORM_DISCOS
        DESCRIP_FORM_TEMES = lang.getText("mnuMusicTemes.Text") '"Cançons"
        Me.mnuMusicTemes.Text = DESCRIP_FORM_TEMES
        Me.mnuPrgBotonsTemes.Text = DESCRIP_FORM_TEMES


        Me.mnuMusicProgs.Text = DESCRIP_FORM_PROGRAMES
        DESCRIP_FORM_NEWS = lang.getText("mnuMusicNews.Text") '"Notícies"
        Me.mnuMusicNews.Text = DESCRIP_FORM_NEWS
        DESCRIP_FORM_EXITS = lang.getText("LABEL_LLISTA_EXITS", True) '"Llista Èxits"
        Me.mnuMusicExits.Text = DESCRIP_FORM_EXITS

        DESCRIP_FORM_INTERPRET = lang.getText("LABEL_INTERPRETS", True) '"Intèrprets"
        Me.mnuMusicMantInterp.Text = DESCRIP_FORM_INTERPRET
        DESCRIP_FORM_ESTIL = lang.getText("LABEL_ESTILS", True) '"Estils"
        Me.mnuMusicMantEstils.Text = DESCRIP_FORM_ESTIL
        DESCRIP_FORM_CLAS_SUBJ = lang.getText("LABEL_CLASSIFICACIO_SUBJ", True) '"Classificació Subjectiva"
        Me.mnuMusicMantClasSubj.Text = DESCRIP_FORM_CLAS_SUBJ
        DESCRIP_FORM_DISCOGRAFIQUES = lang.getText("LABEL_COMPANY_DISCOS", True) '"Companyies Discogràfiques"
        Me.mnuMusicMantCiaDisco.Text = DESCRIP_FORM_DISCOGRAFIQUES
        DESCRIP_FORM_IDIOMES = lang.getText("LABEL_IDIOMES", True) '"Idiomes"
        Me.mnuMusicMantIdioma.Text = DESCRIP_FORM_IDIOMES
        DESCRIP_FORM_TAGS = lang.getText("mnuTags.Text") '"Tags (etiquetes)" 
        Me.mnuTags.Text = DESCRIP_FORM_TAGS
        DESCRIP_FORM_CAT_NEWS = lang.getText("mnuCatNews.Text") '"Categories Notícies"
        Me.mnuCatNews.Text = DESCRIP_FORM_CAT_NEWS
        DESCRIP_FORM_PROVEIDORS = lang.getText("mnuMusicProvei.Text") '"Proveïdors" 
        Me.mnuMusicProvei.Text = DESCRIP_FORM_PROVEIDORS
        DESCRIP_FORM_GRAFICS = lang.getText("LABEL_ESTADISTICA", True) '"Estadística"
        Me.mnuMusicGraf.Text = DESCRIP_FORM_GRAFICS
        DESCRIP_FORM_EQUIVAL = lang.getText("mnuMusicEquival.Text") '"Equivalència Intèrprets"
        Me.mnuMusicEquival.Text = DESCRIP_FORM_EQUIVAL
        DESCRIP_FORM_ESDEVENIMENT = lang.getText("mnuMusicEsdeveniment.Text") '"Esdeveniments"
        Me.mnuMusicEsdeveniment.Text = DESCRIP_FORM_ESDEVENIMENT

        Me.mnuMusicOpcio.Text = lang.getText("LABEL_OPCIONS", True) '"Opcions"
        Me.mnuMusicOpcioLoadRS.Text = lang.getText("mnuMusicOpcioLoadRS.Text") '"No carregar els recordsets al inici"
        Me.mnuTxtCapitalize.Text = lang.getText("mnuTxtCapitalize.Text") '"Text majúscules"
        Me.mnuMusicOpcioBotoNew.Text = lang.getText("mnuMusicOpcioBotoNew.Text") '"Ensenyar el botó NOU Ítem"
        Me.mnuProgEditAudio.Text = lang.getText("mnuProgEditAudio.Text") '"Escollir programa d'edició d'àudio"

        Me.mnuPubliMare.Text = lang.getText("HEADERTEXT_PUBLICITAT", True) '"P&ublicitat"
        DESCRIP_FORM_PUBLICITAT = lang.getText("HEADERTEXT_PUBLICITAT", True) '"Publicitat" 
        Me.mnuPubliFalc.Text = DESCRIP_FORM_PUBLICITAT
        DESCRIP_FORM_CTL_PUBLICITAT = lang.getText("mnuPubliBlocs.Text") '"Calendari publicitat"  
        Me.mnuPubliBlocs.Text = DESCRIP_FORM_CTL_PUBLICITAT
        Me.mnuPrgBotonsCtlBlocs.Text = DESCRIP_FORM_CTL_PUBLICITAT '"Control Blocs publicitàris"
        Me._mnuMusic_11.Text = lang.getText("_mnuMusic_11.Text") '"Manteniment"
        Me._mnuPubli_4.Text = _mnuMusic_11.Text '"Manteniment"
        DESCRIP_FORM_CLIENTS = lang.getText("mnuPubliMantClient.Text") '"Clients"
        Me.mnuPubliMantClient.Text = DESCRIP_FORM_CLIENTS
        DESCRIP_FORM_PRODUCTES = lang.getText("mnuPubliMantProduc.Text") '"Productes"
        Me.mnuPubliMantProduc.Text = DESCRIP_FORM_PRODUCTES
        DESCRIP_FORM_TARIFES = lang.getText("LABEL_TARIFES", True) '"Tarifes"
        Me.mnuPubliMantTarif.Text = DESCRIP_FORM_TARIFES
        DESCRIP_FORM_LOCUTOR = lang.getText("LABEL_LOCUTORS", True) '"Locutors"
        Me.mnuPubliLocutor.Text = DESCRIP_FORM_LOCUTOR
        DESCRIP_FORM_TECNIC = lang.getText("LABEL_TECNICS", True) '"Tècnics"
        Me.mnuPubliTecnic.Text = DESCRIP_FORM_TECNIC
        DESCRIP_FORM_COMERCIAL = lang.getText("mnuPubliAgent.Text") '"Agents comercials" 
        Me.mnuPubliAgent.Text = DESCRIP_FORM_COMERCIAL
        DESCRIP_FORM_FRANGES = lang.getText("mnuPubliFranges.Text") '"Franges Horàries"
        Me.mnuPubliFranges.Text = DESCRIP_FORM_FRANGES


        Me.mnuAutoMare.Text = lang.getText("mnuAutoMare.Text") '"&Automatització"
        DESCRIP_FORM_BLOCS = lang.getText("LABEL_BLOCS_MUSIC", True) '"Blocs Musicals"
        Me.mnuAutoBlocs.Text = DESCRIP_FORM_BLOCS
        DESCRIP_FORM_PAUTES = lang.getText("mnuAutoPautes.Text") '"Pautes"
        Me.mnuAutoPautes.Text = DESCRIP_FORM_PAUTES
        Me.mnuPrgBotonsPautes.Text = DESCRIP_FORM_PAUTES '"Pautes"
        DESCRIP_FORM_CALENDARI = lang.getText("LABEL_CALENDAR", True) '"Calendari"
        Me.mnuAutoCalendar.Text = DESCRIP_FORM_CALENDARI
        DESCRIP_FORM_LOGGER = lang.getText("mnuAutoLogger.Text") '"Programació Logger"
        Me.mnuAutoLogger.Text = DESCRIP_FORM_LOGGER
        DESCRIP_FORM_PODCAST = lang.getText("LABEL_PODCASTING", True) '"Podcasting"
        Me.mnuAutoPotcast.Text = DESCRIP_FORM_PODCAST
        DESCRIP_FORM_CTL_RADIA = lang.getText("LABEL_CONTROL_RADIACIO", True) '"Control de radiació"
        Me.mnuAutoCtlRadia.Text = DESCRIP_FORM_CTL_RADIA
        Me.mnuPrgBotonsCtlRadia.Text = DESCRIP_FORM_CTL_RADIA
        DESCRIP_FORM_PARAMS = lang.getText("LABEL_PARAMS_SISTEMA", True) '"Paràmetres del sistema"
        Me.mnuAutoParam.Text = DESCRIP_FORM_PARAMS
        mnuPrgBotonsSettings.Text = DESCRIP_FORM_PARAMS
        Me.mnuAutoBKP.Text = lang.getText("mnuAutoBKP.Text") '"Backups"		 
        DESCRIP_FORM_BKP_DBS = lang.getText("mnuAutoBkpDBS.Text") '"Backups Dades"
        Me.mnuAutoBkpDBS.Text = DESCRIP_FORM_BKP_DBS
        DESCRIP_FORM_EXPORT_FILES = lang.getText("DESCRIP_FORM_EXPORT_FILES", True) '"Exportar Fitxers"
        Me.mnuExportFiles.Text = DESCRIP_FORM_EXPORT_FILES '"Exportar Fitxers"

        Me.mnuUserMare.Text = lang.getText("mnuUserMare.Text") '"&Usuaris"
        DESCRIP_FORM_MANT_USERS = lang.getText("mnuUserMant.Text") '"Manteniment usuaris" 
        Me.mnuUserMant.Text = DESCRIP_FORM_MANT_USERS
        DESCRIP_FORM_EDIT_USERS = lang.getText("mnuUserChange.Text") '"Editar usuari actual"
        Me.mnuUserChange.Text = DESCRIP_FORM_EDIT_USERS
        Me.mnuIniSessio.Text = lang.getText("mnuIniSessio.Text") '"Iniciar sessió"

        Me.mnuRefMare.Text = lang.getText("mnu_Help", True) '"&Referent a ..."
        Me.mnuRefHelp.Text = lang.getText("mnuRefHelp.Text", True) '"Ajuda"
        Me.mnuRefWeb.Text = lang.getText("mnuRefWeb.Text", True) '"Web"
        Me.mnuRefMail.Text = lang.getText("mnuRefMail.Text", True) '"E-mail"
        Me.mnuRefMSC.Text = lang.getText("mnuRefMSC.Text", True) '"Sobre MSC"

        Me.mnuMonExe.Text = lang.getText("NAME_PRG_MONITOR", True) '"MSC Monitor"
        MSG_NO_TASKS = lang.getText("MSG_NO_TASKS", True) '"Sense tasques pendents"
        MSG_TASKS_PENDING = lang.getText("MSG_TASKS_PENDING", True) '"Amb tasques pendents"
        Me._txtDateTime.Text = lang.getText("txtDateTime.Text") '"    "
        Me._lbUserNom.Text = lang.getText("lbUserNom.Text") '"Nom USR"        
        Me._lbInfoProcesTasques.Text = MSG_NO_TASKS

        Me.Text = lang.getText("Text")  '"Gestió del sistema MSC "        

    End Sub

    Private Sub HabilitarPerUsuari()

        'Habilitar segons els permisos d'un usuari
        _lbUserNom.Text = Usuari.UsrNom
        Dim UserTipus As NivellUsers = CType(Usuari.UsrTipus, NivellUsers)

        Me.mnuImportMare.Enabled = Usuari.IsUsrForAplic(Usuari.UsrID, mdlMscDefines.Aplicatius.PRG_MANT_IMPORT)
        Me.mnuMusicMare.Enabled = Usuari.IsUsrForAplic(Usuari.UsrID, mdlMscDefines.Aplicatius.PRG_MANT_PRODUCCIO)
        If mnuMusicMare.Enabled Then mnuMusicMare.DropDownItems(MNU_MUSIC.MNU_MUSIC_PROVEI).Enabled = IIf(UserTipus > mdlMscDefines.NivellUsers.USR_CONVIDAT, True, False)
        mnuMusicOpcio.Enabled = Me.mnuMusicMare.Enabled

        'Me.mnuUserMare.Enabled = Usuari.IsUsrForAplic(Usuari.UsrID, mdlMscDefines.Aplicatius.PRG_MANT_AUTOMAT)

        Me.mnuAutoMare.Enabled = Usuari.IsUsrForAplic(Usuari.UsrID, mdlMscDefines.Aplicatius.PRG_MANT_AUTOMAT)
        Me.mnuPubliMare.Enabled = Usuari.IsUsrForAplic(Usuari.UsrID, mdlMscDefines.Aplicatius.PRG_MANT_PUBLI)
        If mnuPubliMare.Enabled Then mnuPubliMare.DropDownItems(MNU_PUBLI.MNU_PUBLI_INFORMS).Enabled = IIf(UserTipus > mdlMscDefines.NivellUsers.USR_CONVIDAT, True, False)
        Me.mnuAutoMare.DropDownItems(MNU_ATOMAT.MNU_ATOMAT_PARAMS).Enabled = IIf(UserTipus > mdlMscDefines.NivellUsers.USR_USUARI, True, False)
        If mnuAutoMare.Enabled Then mnuAutoMare.DropDownItems(MNU_ATOMAT.MNU_ATOMAT_LOGGER).Enabled = IIf(UserTipus > mdlMscDefines.NivellUsers.USR_CONVIDAT, True, False)
        If mnuAutoMare.Enabled Then mnuAutoMare.DropDownItems(MNU_ATOMAT.MNU_ATOMAT_PODCAST).Enabled = IIf(UserTipus > mdlMscDefines.NivellUsers.USR_CONVIDAT, True, False) And (cloud.ClientType = cloud.client_type.RADIO_WITH_SERVICES)

        mnuAutoBKP.DropDownItems(MNU_ATOMAT_BKP.MNU_ATOMAT_BKP_DADES).Enabled = IIf(UserTipus > mdlMscDefines.NivellUsers.USR_USUARI, True, False)

        mnuMusicEsdeveniment.Enabled = Usuari.IsUsrForAplic(Usuari.UsrID, mdlMscDefines.Aplicatius.PRG_MANT_AUTOMAT)

        mnuUserMare.DropDownItems(MNU_USR.MNU_USR_USR).Enabled = IIf(UserTipus > mdlMscDefines.NivellUsers.USR_USUARI, True, False)
        If mnuUserMare.DropDownItems(MNU_USR.MNU_USR_USR).Enabled = True Then mnuUserMare.DropDownItems(MNU_USR.MNU_USR_USR).Enabled = Usuari.IsUsrForAplic(Usuari.UsrID, mdlMscDefines.Aplicatius.PRG_MANT_AUTOMAT)
        mnuIniSessio.Enabled = IIf(Usuari.UsrID > 0, False, True)

        mnuPrgBotons.DropDownItems(MNU_BOTONS.MNU_BOTONS_RIPPER).Enabled = Usuari.IsUsrForAplic(Usuari.UsrID, mdlMscDefines.Aplicatius.PRG_MANT_IMPORT)
        mnuPrgBotons.DropDownItems(MNU_BOTONS.MNU_BOTONS_JAMENDO).Enabled = Usuari.IsUsrForAplic(Usuari.UsrID, mdlMscDefines.Aplicatius.PRG_MANT_IMPORT)
        mnuPrgBotons.DropDownItems(MNU_BOTONS.MNU_BOTONS_DISCOS).Enabled = Usuari.IsUsrForAplic(Usuari.UsrID, mdlMscDefines.Aplicatius.PRG_MANT_PRODUCCIO)
        mnuPrgBotons.DropDownItems(MNU_BOTONS.MNU_BOTONS_TEMES).Enabled = Usuari.IsUsrForAplic(Usuari.UsrID, mdlMscDefines.Aplicatius.PRG_MANT_PRODUCCIO)
        mnuPrgBotons.DropDownItems(MNU_BOTONS.MNU_BOTONS_PROGRAM).Enabled = Usuari.IsUsrForAplic(Usuari.UsrID, mdlMscDefines.Aplicatius.PRG_MANT_PRODUCCIO)
        mnuPrgBotons.DropDownItems(MNU_BOTONS.MNU_BOTONS_PUBLI).Enabled = Usuari.IsUsrForAplic(Usuari.UsrID, mdlMscDefines.Aplicatius.PRG_MANT_PUBLI)
        mnuPrgBotons.DropDownItems(MNU_BOTONS.MNU_BOTONS_CTL_BLOCS).Enabled = Usuari.IsUsrForAplic(Usuari.UsrID, mdlMscDefines.Aplicatius.PRG_MANT_PUBLI)
        mnuPrgBotons.DropDownItems(MNU_BOTONS.MNU_BOTONS_INFORM_RADI).Enabled = IIf(UserTipus > mdlMscDefines.NivellUsers.USR_CONVIDAT, True, False)
        If mnuPrgBotons.DropDownItems(MNU_BOTONS.MNU_BOTONS_INFORM_RADI).Enabled Then mnuPrgBotons.DropDownItems(MNU_BOTONS.MNU_BOTONS_INFORM_RADI).Enabled = Usuari.IsUsrForAplic(Usuari.UsrID, mdlMscDefines.Aplicatius.PRG_MANT_PUBLI)
        mnuPrgBotons.DropDownItems(MNU_BOTONS.MNU_BOTONS_BLOCS_MUSIC).Enabled = Usuari.IsUsrForAplic(Usuari.UsrID, mdlMscDefines.Aplicatius.PRG_MANT_AUTOMAT)
        mnuPrgBotons.DropDownItems(MNU_BOTONS.MNU_BOTONS_PAUTES).Enabled = Usuari.IsUsrForAplic(Usuari.UsrID, mdlMscDefines.Aplicatius.PRG_MANT_AUTOMAT)
        mnuPrgBotons.DropDownItems(MNU_BOTONS.MNU_BOTONS_CALENDAR).Enabled = Usuari.IsUsrForAplic(Usuari.UsrID, mdlMscDefines.Aplicatius.PRG_MANT_AUTOMAT)
        mnuPrgBotons.DropDownItems(MNU_BOTONS.MNU_BOTONS_CTL_RADI).Enabled = Usuari.IsUsrForAplic(Usuari.UsrID, mdlMscDefines.Aplicatius.PRG_MANT_AUTOMAT)
        mnuPrgBotons.DropDownItems(MNU_BOTONS.MNU_BOTONS_PROG_LOGGER).Enabled = Usuari.IsUsrForAplic(Usuari.UsrID, mdlMscDefines.Aplicatius.PRG_MANT_AUTOMAT)
        mnuPrgBotons.DropDownItems(MNU_BOTONS.MNU_BOTONS_PODCASTING).Enabled = Usuari.IsUsrForAplic(Usuari.UsrID, mdlMscDefines.Aplicatius.PRG_MANT_AUTOMAT) And (cloud.ClientType = cloud.client_type.RADIO_WITH_SERVICES)
        mnuPrgBotons.DropDownItems(MNU_BOTONS.MNU_BOTONS_PARAMS).Enabled = Usuari.IsUsrForAplic(Usuari.UsrID, mdlMscDefines.Aplicatius.PRG_MANT_AUTOMAT)

        'Consulta Botons per usuari
        DesmarcarBotonsUser()
        Dim rsBotons As DataTable = getBotonsOptionsFromIDUsr(Usuari.UsrID)
        If rsBotons.Rows.Count > 0 Then
            Dim id_boto As Integer = 1
            For i As Integer = 0 To mnuPrgBotons.DropDownItems.Count - 1
                If mnuPrgBotons.DropDownItems(i).GetType.Name = "ToolStripMenuItem" Then
                    Dim tsm_item As ToolStripMenuItem = CType(mnuPrgBotons.DropDownItems(i), ToolStripMenuItem)
                    If tsm_item.DropDownItems.Count > 0 Then
                        For d As Integer = 0 To tsm_item.DropDownItems.Count - 1
                            Dim sub_tsm_item As ToolStripMenuItem = CType(tsm_item.DropDownItems(d), ToolStripMenuItem)
                            Dim Nom_col As String = "boto_au" & getIDlistAudioUser(sub_tsm_item.Text)
                            sub_tsm_item.Checked = CBool(rsBotons.Rows(0)(Nom_col))
                        Next
                    Else
                        tsm_item.Checked = CBool(rsBotons.Rows(0)(id_boto))
                        id_boto += 1
                    End If
                End If
            Next

            CType(mnuPrgBotons.DropDownItems(MNU_BOTONS.MNU_BOTONS_JAMENDO), ToolStripMenuItem).Checked = False
        End If
        'Si accedim sense control d'usuaris, s'ha de deshabilitar la pantalla de canvi de password.
        mnuUserChange.Enabled = (Usuari.UsrID > 0)
        AddBotons()
    End Sub

    Private Sub DesmarcarBotonsUser()
        For i As Integer = 0 To mnuPrgBotons.DropDownItems.Count - 1
            If mnuPrgBotons.DropDownItems(i).GetType.Name = "ToolStripMenuItem" Then
                Dim tsm_item As ToolStripMenuItem = CType(mnuPrgBotons.DropDownItems(i), ToolStripMenuItem)
                If tsm_item.DropDownItems.Count > 0 Then
                    For d As Integer = 0 To tsm_item.DropDownItems.Count - 1
                        Dim sub_tsm_item As ToolStripMenuItem = CType(tsm_item.DropDownItems(d), ToolStripMenuItem)
                        sub_tsm_item.Checked = False
                    Next
                Else
                    tsm_item.Checked = False
                End If
            End If
        Next
    End Sub

    Private Sub mnuMusicOpcioLoadRS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMusicOpcioLoadRS.Click
        mnuMusicOpcioLoadRS.Checked = Not mnuMusicOpcioLoadRS.Checked
        NoLoadRs = mnuMusicOpcioLoadRS.Checked
        My.Settings.LOADRS = NoLoadRs
        My.Settings.Save()
    End Sub

    Private Sub mnuMusicOpcioBotoNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMusicOpcioBotoNew.Click
        mnuMusicOpcioBotoNew.Checked = Not mnuMusicOpcioBotoNew.Checked
        VisibleNew = mnuMusicOpcioBotoNew.Checked
        My.Settings.VisibleNew = VisibleNew
        My.Settings.Save()
    End Sub

    Private Sub mnuMonExe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMonExe.Click
        If IO.File.Exists(My.Application.Info.DirectoryPath & "\MSCMonitor.exe") Then
            Dim ProcesosLocales As Process() = Process.GetProcessesByName("MSCMonitor.exe")
            If ProcesosLocales.Length = 0 Then
                Try
                    Dim Proces As Process = New Process
                    Process.Start(My.Application.Info.DirectoryPath & "\MSCMonitor.exe", "show")
                Catch ex As Exception
                End Try
            End If
        End If
    End Sub

    Private Sub mnuRefMSC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRefMSC.Click

        Try
            FrmSplash.Show()
        Catch ex As Exception
            'frmSplash.WindowState = FormWindowState.Normal
        End Try

    End Sub

    Private Sub mnuRefMail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRefMail.Click
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

    Private Sub mnuRefWeb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRefWeb.Click
        Dim Proces As Process = New Process
        Try
            Process.Start(MSC.Help.WEB_DEF_MSC.ToString)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub mnuPrgClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPrgClose.Click
        Me.Close()
    End Sub

    Private Sub AddBotons()
        Dim BotoTrack As MetroFramework.Controls.MetroTile
        groupBotons.Controls.Clear()

        For i As Short = 0 To mnuPrgBotons.DropDownItems.Count - 1
            Try
                Dim tsm_item As ToolStripMenuItem = CType(mnuPrgBotons.DropDownItems(i), ToolStripMenuItem)

                If tsm_item.DropDownItems.Count > 0 Then
                    For d As Integer = 0 To tsm_item.DropDownItems.Count - 1
                        Dim sub_tsm_item As ToolStripMenuItem = CType(tsm_item.DropDownItems(d), ToolStripMenuItem)
                        If sub_tsm_item.Checked = True Then
                            Dim id As Integer = CInt(sub_tsm_item.Tag)
                            BotoTrack = New MetroFramework.Controls.MetroTile
                            BotoTrack.Parent = Me.groupBotons
                            BotoTrack.Tag = MNU_BOTONS.MNU_BOTONS_AUDIO_USER
                            BotoTrack.UseTileImage = True
                            BotoTrack.UseStyleColors = True

                            BotoTrack.Style = MetroFramework.MetroColorStyle.Green
                            BotoTrack.Size = New Size(130, 75)
                            BotoTrack.TileImage = imgListMnu.Images(CInt(sub_tsm_item.Tag))  'CType(mnuPrgBotons.DropDownItems(i), ToolStripMenuItem).Image
                            BotoTrack.TileImageAlign = ContentAlignment.MiddleCenter
                            BotoTrack.Text = sub_tsm_item.Text  'VB.Left(CType(mnuPrgBotons.DropDownItems(i), ToolStripMenuItem).Text, 10)
                            BotoTrack.TextAlign = ContentAlignment.BottomCenter

                            AddHandler BotoTrack.Click, AddressOf Click_BotoTack
                        End If
                    Next
                Else
                    If tsm_item.Checked = True Then
                        BotoTrack = New MetroFramework.Controls.MetroTile
                        BotoTrack.Parent = Me.groupBotons
                        BotoTrack.Tag = i
                        BotoTrack.UseTileImage = True
                        BotoTrack.UseStyleColors = True
                        'TODO: segons tipus de pantalla canvia el color
                        Select Case tsm_item.Tag
                            Case 0 : BotoTrack.Style = MetroFramework.MetroColorStyle.Green
                            Case 1 : BotoTrack.Style = MetroFramework.MetroColorStyle.Blue
                            Case 2 : BotoTrack.Style = MetroFramework.MetroColorStyle.Orange
                            Case 3 : BotoTrack.Style = MetroFramework.MetroColorStyle.Lime
                        End Select
                        BotoTrack.Size = New Size(130, 75)
                        Select Case i
                            Case MNU_BOTONS.MNU_BOTONS_PARAMS : BotoTrack.TileImage = imgListMnu.Images(12)
                            Case Else
                                BotoTrack.TileImage = imgListMnu.Images(i)
                        End Select
                        BotoTrack.TileImageAlign = ContentAlignment.MiddleCenter
                        BotoTrack.Text = tsm_item.Text
                        BotoTrack.TextAlign = ContentAlignment.BottomCenter

                        AddHandler BotoTrack.Click, AddressOf Click_BotoTack
                    End If
                End If
            Catch
            End Try
        Next i

        'Botó fitxer ini_'lang'.rtf
        If MyAPP.INISYSTEM = True Then
            BotoTrack = New MetroFramework.Controls.MetroTile
            BotoTrack.Parent = Me.groupBotons
            BotoTrack.Tag = 99
            BotoTrack.UseTileImage = True
            BotoTrack.UseStyleColors = True
            BotoTrack.Style = MetroFramework.MetroColorStyle.Red
            BotoTrack.Size = New Size(130, 75)
            BotoTrack.TileImage = imgListMnu.Images(18)
            BotoTrack.TileImageAlign = ContentAlignment.MiddleCenter
            BotoTrack.Text = LABEL_INI_SYSTEM
            BotoTrack.TextAlign = ContentAlignment.BottomRight
            AddHandler BotoTrack.Click, AddressOf Click_inisistem
        End If
        'Botó Update urgent
        If Cloud.News_Type = news_type.URGENT_UPDATE Then
            BotoTrack = New MetroFramework.Controls.MetroTile
            BotoTrack.Parent = Me.groupBotons
            BotoTrack.Tag = 99
            BotoTrack.UseTileImage = True
            BotoTrack.UseStyleColors = True
            BotoTrack.Style = MetroFramework.MetroColorStyle.Red
            BotoTrack.Size = New Size(260, 75)
            BotoTrack.TileImage = imgListMnu.Images(18)
            BotoTrack.TileImageAlign = ContentAlignment.TopCenter
            Dim msg() As String = MSG_URGENT_UPDATE.Split(".")
            BotoTrack.Text = msg(0) & vbCr & msg(1)
            BotoTrack.Tag = Cloud.News_URL
            BotoTrack.TextAlign = ContentAlignment.MiddleCenter
            AddHandler BotoTrack.Click, AddressOf lbInfoProcesTasques_Click
        End If
        'Botó Donation
        If Cloud.ClientType < Cloud.client_type.RADIO_WITH_SERVICES And Params.ClientKey.Length = 0 Then
            BotoTrack = New MetroFramework.Controls.MetroTile
            BotoTrack.Parent = Me.groupBotons
            BotoTrack.Tag = 100
            BotoTrack.UseTileImage = True
            BotoTrack.UseStyleColors = True
            BotoTrack.Style = MetroFramework.MetroColorStyle.Orange
            BotoTrack.Size = New Size(265, 75)
            BotoTrack.TileImage = imgListMnu.Images(34)
            BotoTrack.TileImageAlign = ContentAlignment.MiddleCenter
            BotoTrack.Text = LABEL_DONATION
            BotoTrack.TextAlign = ContentAlignment.BottomCenter
            AddHandler BotoTrack.Click, AddressOf Click_donate
        End If
        'create button exit
        BotoTrack = New MetroFramework.Controls.MetroTile
        BotoTrack.Parent = Me.groupBotons
        BotoTrack.Tag = 99
        BotoTrack.UseTileImage = True
        BotoTrack.UseStyleColors = True
        BotoTrack.Style = MetroFramework.MetroColorStyle.Red

        BotoTrack.Size = New Size(130, 75)
        BotoTrack.TileImage = imgListMnu.Images(17) 'mnuPrgClose.Image
        BotoTrack.TileImageAlign = ContentAlignment.MiddleCenter
        BotoTrack.Text = LABEL_TANCAR
        BotoTrack.TextAlign = ContentAlignment.BottomRight
        Me.CancelButton = BotoTrack
        AddHandler BotoTrack.Click, AddressOf Click_BotoTack
        Refresh()
    End Sub

    Private Sub Click_donate(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim my_Proces As Process = New Process
            my_Proces.Start(MSC.Help.WEB_DONATE_MSC.ToString)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Click_inisistem(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim name_ini As String = "ini_" & lang.Code & ".rtf"
            Process.Start(My.Application.Info.DirectoryPath & "\" & name_ini)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Click_BotoTack(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmOpen As MetroFramework.Forms.MetroForm
        Dim Flag As Boolean
        Dim StrFromInfo As String

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.AppStarting
        Select Case CType(sender, Button).Tag
            Case MNU_BOTONS.MNU_BOTONS_RIPPER : frmOpen = New frmImport : StrFromInfo = DESCRIP_FORM_RIPPER
            Case MNU_BOTONS.MNU_BOTONS_JAMENDO : frmOpen = New frmJamendo : StrFromInfo = DESCRIP_FORM_JAMENDO
            Case MNU_BOTONS.MNU_BOTONS_DISCOS : frmOpen = New frmDiscos : StrFromInfo = DESCRIP_FORM_DISCOS
            Case MNU_BOTONS.MNU_BOTONS_TEMES : frmOpen = New frmTemes : StrFromInfo = DESCRIP_FORM_TEMES
            Case MNU_BOTONS.MNU_BOTONS_PROGRAM : frmOpen = New frmProgrames : StrFromInfo = DESCRIP_FORM_PROGRAMES
            Case MNU_BOTONS.MNU_BOTONS_PUBLI : frmOpen = New frmPubli : StrFromInfo = DESCRIP_FORM_PUBLICITAT
            Case MNU_BOTONS.MNU_BOTONS_CTL_BLOCS : frmOpen = New frmCalendarPubli : StrFromInfo = DESCRIP_FORM_CTL_PUBLICITAT
            Case MNU_BOTONS.MNU_BOTONS_INFORM_RADI : frmOpen = New frmInformRadia : StrFromInfo = DESCRIP_FORM_INFORMES
            Case MNU_BOTONS.MNU_BOTONS_BLOCS_MUSIC : frmOpen = New frmBlocs : StrFromInfo = DESCRIP_FORM_BLOCS
            Case MNU_BOTONS.MNU_BOTONS_PAUTES : frmOpen = New frmPautes : StrFromInfo = DESCRIP_FORM_PAUTES
            Case MNU_BOTONS.MNU_BOTONS_CALENDAR : frmOpen = New frmCalendari : StrFromInfo = DESCRIP_FORM_CALENDARI
            Case MNU_BOTONS.MNU_BOTONS_CTL_RADI : frmOpen = New frmCtlRadia : StrFromInfo = DESCRIP_FORM_CTL_RADIA
            Case MNU_BOTONS.MNU_BOTONS_PROG_LOGGER : frmOpen = New frmPrgLogger : StrFromInfo = DESCRIP_FORM_LOGGER
            Case MNU_BOTONS.MNU_BOTONS_PODCASTING : frmOpen = New frmPodcast : StrFromInfo = DESCRIP_FORM_PODCAST
            Case MNU_BOTONS.MNU_BOTONS_PARAMS : frmOpen = New frmParams : StrFromInfo = DESCRIP_FORM_PARAMS
            Case MNU_BOTONS.MNU_BOTONS_AUDIO_USER
                Dim NomAudioUSR As String = CType(sender, Button).Text
                Dim au_id As Integer = 600 - CType(sender, Button).Tag
                Dim frmMyAudio As New frmAudios
                StrFromInfo = NomAudioUSR
                frmMyAudio.EstablirTaula(NomAudioUSR)
                frmOpen = frmMyAudio
            Case 99 : Me.Close() : Return
            Case Else
                Return
        End Select
        Flag = IsLoadForm(frmOpen.Name)
        If Not Flag Then
            If MyAPP.NovaConnex(StrFromInfo, Usuari.UsrNom, True) = True Then frmOpen.Show()
        Else
            frmOpen.WindowState = OldWinState
        End If
        LoadMnuPantalles()
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub LoadMnuPantalles()

        Do While mnuPrgMare.DropDownItems.Count > 4
            Try
                mnuPrgMare.DropDownItems.RemoveAt(mnuPrgMare.DropDownItems.Count - 1)
            Catch ex As Exception
                Exit Do
            End Try
        Loop

        mnuPrgMare.DropDownItems(2).Visible = IIf(My.Application.OpenForms.Count > 1, True, False)
        For i As Short = 0 To My.Application.OpenForms.Count - 1
            If My.Application.OpenForms.Item(i).Name.ToString <> "frmMain" And My.Application.OpenForms.Item(i).Visible = True And My.Application.OpenForms.Item(i).Text.Length > 1 Then
                Try
                    Dim Icona As Icon = My.Application.OpenForms.Item(i).Icon
                    Dim NouMnuPrg As ToolStripMenuItem = mnuPrgMare.DropDownItems.Add(My.Application.OpenForms.Item(i).Text, Icona.ToBitmap(), AddressOf Click_mnuPantalles)
                    NouMnuPrg.Tag = My.Application.OpenForms.Item(i).Name
                Catch
                End Try
            End If
        Next i
    End Sub

    Private Sub Click_mnuPantalles(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Name As String = CType(sender, ToolStripMenuItem).Tag
        Try
            'My.Application.OpenForms.Item(Name).WindowState = OldWinState
            My.Application.OpenForms.Item(Name).Focus()
        Catch
            LoadMnuPantalles()
        End Try
    End Sub

    Private Sub saveBotons()
        'Salva configuració botons
        Dim StrColAu As String = ""
        Dim Buttonval() As Boolean
        For i As Integer = 0 To mnuPrgBotons.DropDownItems.Count - 1
            If mnuPrgBotons.DropDownItems(i).GetType.Name = "ToolStripMenuItem" Then
                Dim tsm_item As ToolStripMenuItem = CType(mnuPrgBotons.DropDownItems(i), ToolStripMenuItem)
                If tsm_item.DropDownItems.Count > 0 Then
                    For d As Integer = 0 To tsm_item.DropDownItems.Count - 1
                        Dim sub_tsm_item As ToolStripMenuItem = CType(tsm_item.DropDownItems(d), ToolStripMenuItem)
                        Dim id As Integer = getIDlistAudioUser(sub_tsm_item.Text)
                        StrColAu += ", boto_au" & id & "=" & IIf(sub_tsm_item.Checked, 1, 0).ToString
                    Next
                Else
                    Dim Inxlen As Integer = 0
                    Try
                        Inxlen = Buttonval.Length
                    Catch ex As Exception
                        Inxlen = 0
                    End Try
                    ReDim Preserve Buttonval(Inxlen)
                    Buttonval(Inxlen) = tsm_item.Checked
                End If
            End If
        Next
        UpdateUsrBotonsOptions(Usuari.UsrID, Buttonval, StrColAu)
    End Sub

    Private Sub Click_mnuPrgBotons(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
        mnuPrgBotonsBlocs.Click, mnuPrgBotonsCalendar.Click, mnuPrgBotonsCtlBlocs.Click _
        , mnuPrgBotonsCtlRadia.Click, mnuPrgBotonsDiscos.Click, mnuPrgBotonsInform.Click _
        , mnuPrgBotonsPautes.Click, mnuPrgBotonsPrg.Click _
        , mnuPrgBotonsPubli.Click, mnuPrgBotonsRipper.Click, mnuPrgBotonsTemes.Click, mnuPrgBotonsProgLogger.Click, mnuPrgBotonsPodcasting.Click, mnuPrgBotonsJamendo.Click, mnuPrgBotonsSettings.Click

        CType(sender, ToolStripMenuItem).Checked = Not CType(sender, ToolStripMenuItem).Checked
        AddBotons()
    End Sub

    Private Sub mnuImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuImport.Click, mnuImportJamendo.Click
        If Params.IsAlternativeDir = True Then
            MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_ALTERNATIVE_DIR, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
            Exit Sub
        End If
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.AppStarting

        Dim frmOpen As MetroFramework.Forms.MetroForm = Nothing
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.AppStarting
        Select Case CType(sender, ToolStripMenuItem).Tag
            Case MNU_IMPORT.MNU_IMPORT_RIPPER : frmOpen = New frmImport
            Case MNU_IMPORT.MNU_IMPORT_JAMENDO : frmOpen = New frmJamendo
        End Select

        Dim Flag As Boolean = IsLoadForm(frmOpen.Name)
        If Not Flag Then
            If MyAPP.NovaConnex(CType(sender, ToolStripMenuItem).Text, Usuari.UsrNom, True) = True Then frmOpen.Show()
        Else
            frmOpen.WindowState = OldWinState
        End If
        LoadMnuPantalles()
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub Click_mnuMusic(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMusicDiscos.Click _
        , mnuMusicEquival.Click, mnuMusicExits.Click, mnuMusicGraf.Click _
        , mnuMusicProgs.Click _
        , mnuMusicProvei.Click, mnuMusicTemes.Click, mnuMusicEsdeveniment.Click _
        , mnuMusicNews.Click


        Dim frmOpen As MetroFramework.Forms.MetroForm
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.AppStarting
        Select Case CType(sender, ToolStripMenuItem).Tag
            Case MNU_MUSIC.MNU_MUSIC_DISCOS : frmOpen = New frmDiscos
            Case MNU_MUSIC.MNU_MUSIC_TEMES : frmOpen = New frmTemes
            Case MNU_MUSIC.MNU_MUSIC_PROGRAM : frmOpen = New frmProgrames
            Case MNU_MUSIC.MNU_MUSIC_LLISTA_EXITS : frmOpen = New frmExits
            Case MNU_MUSIC.MNU_MUSIC_PROVEI : frmOpen = New frmMantProveidor
            Case MNU_MUSIC.MNU_MUSIC_GRAF : frmOpen = New frmGrafics
            Case MNU_MUSIC.MNU_MUSIC_EQUIVAL_INTERP : frmOpen = New frmEquival
            Case MNU_MUSIC.MNU_MUSIC_ESDEVENIMENTS : frmOpen = New frmEsdeveniment
            Case MNU_MUSIC.MNU_MUSIC_NEWS : frmOpen = New frmNews
            Case Else
                Return
        End Select
        Dim Flag As Boolean = IsLoadForm(frmOpen.Name)
        If Not Flag Then
            If MyAPP.NovaConnex(CType(sender, ToolStripMenuItem).Text, Usuari.UsrNom, True) = True Then frmOpen.Show()
        Else
            frmOpen.WindowState = OldWinState
        End If
        LoadMnuPantalles()
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub Click_mnuPubli(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPubliAgent.Click _
        , mnuPubliBlocs.Click, mnuPubliFalc.Click, mnuPubliFranges.Click _
        , mnuPubliInform.Click, mnuPubliLocutor.Click, mnuPubliTecnic.Click

        Dim frmOpen As MetroFramework.Forms.MetroForm
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.AppStarting
        Select Case CType(sender, ToolStripMenuItem).Tag
            Case MNU_PUBLI.MNU_PUBLI_FALQUES : frmOpen = New frmPubli
            Case MNU_PUBLI.MNU_PUBLI_CTLBLOCS : frmOpen = New frmCalendarPubli
            Case MNU_PUBLI.MNU_PUBLI_LOCUTOR : frmOpen = New frmMantLocutors
            Case MNU_PUBLI.MNU_PUBLI_TECNICS : frmOpen = New frmMantTecnic
            Case MNU_PUBLI.MNU_PUBLI_AGENTCOMER : frmOpen = New frmMantComercial
            Case MNU_PUBLI.MNU_PUBLI_FRANGES : frmOpen = New frmFrangeHora
            Case MNU_PUBLI.MNU_PUBLI_INFORMS : frmOpen = New frmInformRadia
            Case Else
                Return
        End Select
        Dim Flag As Boolean = IsLoadForm(frmOpen.Name)
        If Not Flag Then
            If MyAPP.NovaConnex(CType(sender, ToolStripMenuItem).Text, Usuari.UsrNom, True) = True Then frmOpen.Show()
        Else
            frmOpen.WindowState = OldWinState
        End If
        LoadMnuPantalles()
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub Click_mnuAuto(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAutoBlocs.Click _
        , mnuAutoCalendar.Click, mnuAutoParam.Click _
        , mnuAutoCtlRadia.Click, mnuAutoPautes.Click _
        , mnuAutoLogger.Click, mnuAutoPotcast.Click
        Dim frmOpen As MetroFramework.Forms.MetroForm
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.AppStarting
        Select Case CType(sender, ToolStripMenuItem).Tag
            Case MNU_ATOMAT.MNU_ATOMAT_BLOCS : frmOpen = New frmBlocs
            Case MNU_ATOMAT.MNU_ATOMAT_PAUTES : frmOpen = New frmPautes
            Case MNU_ATOMAT.MNU_ATOMAT_CALENDAR : frmOpen = New frmCalendari
            Case MNU_ATOMAT.MNU_ATOMAT_LOGGER : frmOpen = New frmPrgLogger
            Case MNU_ATOMAT.MNU_ATOMAT_PODCAST : frmOpen = New frmPodcast
            Case MNU_ATOMAT.MNU_ATOMAT_CTLRADIACIO : frmOpen = New frmCtlRadia
            Case MNU_ATOMAT.MNU_ATOMAT_PARAMS : frmOpen = New frmParams
            Case Else
                Return
        End Select
        Dim Flag As Boolean = IsLoadForm(frmOpen.Name)
        If Not Flag Then
            If MyAPP.NovaConnex(CType(sender, ToolStripMenuItem).Text, Usuari.UsrNom, True) = True Then frmOpen.Show()
        Else
            frmOpen.WindowState = OldWinState
        End If
        LoadMnuPantalles()
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub Click_mnuUser(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuUserMant.Click, mnuUserChange.Click
        Dim frmOpen As MetroFramework.Forms.MetroForm = Nothing
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.AppStarting
        Select Case CType(sender, ToolStripMenuItem).Tag
            Case MNU_USR.MNU_USR_USR : frmOpen = New frmUsers
            Case MNU_USR.MNU_USR_CANVIPSW : frmOpen = New frmMantUsuari
        End Select
        Dim Flag As Boolean = IsLoadForm(frmOpen.Name)
        If Not Flag Then
            If MyAPP.NovaConnex(CType(sender, ToolStripMenuItem).Text, Usuari.UsrNom, True) = True Then frmOpen.Show()
        Else
            frmOpen.WindowState = OldWinState
        End If
        LoadMnuPantalles()
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub Click_mnuAutoBkp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAutoBkpDBS.Click, mnuExportFiles.Click
        Dim frmOpen As MetroFramework.Forms.MetroForm
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.AppStarting
        Select Case CType(sender, ToolStripMenuItem).Tag
            Case MNU_ATOMAT_BKP.MNU_ATOMAT_BKP_DADES : frmOpen = New frmBKPDBS
            Case MNU_ATOMAT_BKP.MNU_ATOMAT_EXPORT_FILES : frmOpen = New frmExport
            Case Else
                Return
        End Select
        Dim Flag As Boolean = IsLoadForm(frmOpen.Name)
        If Not Flag Then
            If MyAPP.NovaConnex(CType(sender, ToolStripMenuItem).Text, Usuari.UsrNom, True) = True Then frmOpen.Show()
        Else
            frmOpen.WindowState = OldWinState
        End If
        LoadMnuPantalles()
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub Click_mnuPubliMant(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPubliMantClient.Click _
        , mnuPubliMantProduc.Click _
        , mnuPubliMantTarif.Click

        Dim frmOpen As MetroFramework.Forms.MetroForm = Nothing
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.AppStarting
        Select Case CType(sender, ToolStripMenuItem).Tag
            Case MNU_PUBLI_MANT.MNU_PUBLI_MANT_CLIENT : frmOpen = New frmMantClients
            Case MNU_PUBLI_MANT.MNU_PUBLI_MANT_PRODUCT : frmOpen = New frmMantProductes
            Case MNU_PUBLI_MANT.MNU_PUBLI_MANT_TARIFA : frmOpen = New frmMantTarifa
        End Select
        Dim Flag As Boolean = IsLoadForm(frmOpen.Name)
        If Not Flag Then
            If MyAPP.NovaConnex(CType(sender, ToolStripMenuItem).Text, Usuari.UsrNom, True) = True Then frmOpen.Show()
        Else
            frmOpen.WindowState = OldWinState
        End If
        LoadMnuPantalles()
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub Click_mnuMusicMant(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMusicMantInterp.Click, mnuMusicMantCiaDisco.Click _
        , mnuMusicMantClasSubj.Click, mnuMusicMantEstils.Click _
        , mnuMusicMantIdioma.Click, mnuTags.Click, mnuCatNews.Click


        Dim frmOpen As MetroFramework.Forms.MetroForm = Nothing
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.AppStarting
        Select Case CType(sender, ToolStripMenuItem).Tag
            Case MNU_MUSIC_MANT.MNU_MUSIC_MANT_INTERP : frmOpen = New frmMantInterp
            Case MNU_MUSIC_MANT.MNU_MUSIC_MANT_ESTIL : frmOpen = New frmMantEstil
            Case MNU_MUSIC_MANT.MNU_MUSIC_MANT_SUBJ : frmOpen = New frmMantSubject
            Case MNU_MUSIC_MANT.MNU_MUSIC_MANT_CIA : frmOpen = New frmMantDicograf
            Case MNU_MUSIC_MANT.MNU_MUSIC_MANT_IDIOMES : frmOpen = New frmMantIdioma
            Case MNU_MUSIC_MANT.MNU_MUSIC_MANT_TAGS : frmOpen = New frmMantTags
            Case MNU_MUSIC_MANT.MNU_MUSIC_MANT_CAT_NEWS : frmOpen = New frmMantCatNews
        End Select
        Dim Flag As Boolean = IsLoadForm(frmOpen.Name)
        If Not Flag Then
            If MyAPP.NovaConnex(CType(sender, ToolStripMenuItem).Text, Usuari.UsrNom, True) = True Then frmOpen.Show()

        Else
            frmOpen.WindowState = OldWinState
            frmOpen.Focus()
        End If
        LoadMnuPantalles()
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default


    End Sub

    Public Sub CarregaListAudio()

        Dim NomCarp() As String = Split(Params.NomsCarpetaAudiosUser, ",")
        Dim db As New MSC.dbs(Cloud)
        For i As Integer = 0 To NomCarp.Length - 1
            Dim StrSql As String = "SELECT * FROM listaudio WHERE audio_carpeta= " & i & " ;"
            Dim rsAudio As DataTable = db.getTable(StrSql)
            If rsAudio.Rows.Count > 0 Then
                Dim mnucarp As New ToolStripMenuItem
                Dim mnu_botons_carp As New ToolStripMenuItem
                mnucarp.Text = NomCarp(i)
                mnu_botons_carp.Text = NomCarp(i)
                mnu_botons_carp.Enabled = Usuari.IsUsrForAplic(Usuari.UsrID, mdlMscDefines.Aplicatius.PRG_MANT_PRODUCCIO)
                mnu_botons_carp.Tag = 1
                mnuMusicMare.DropDownItems.Insert(6 + i, mnucarp)
                mnuPrgBotons.DropDownItems.Add(mnu_botons_carp)
                mnu_botons_carp.Enabled = Usuari.IsUsrForAplic(Usuari.UsrID, mdlMscDefines.Aplicatius.PRG_MANT_PRODUCCIO)
                mnuPrgBotons.Tag = -1
                For n As Integer = 0 To rsAudio.Rows.Count - 1
                    Dim name As String = rsAudio.Rows(n)("audio_nom").ToString
                    Dim imge_id As Integer = CInt(rsAudio.Rows(n)("audio_image"))
                    mnucarp.DropDownItems.Add(name, imgListMnu.Images(imge_id), AddressOf Click_mnuAudio)
                    Dim my_ts_item As ToolStripItem = mnu_botons_carp.DropDownItems.Add(name, Nothing, AddressOf Click_mnuPrgBotons)
                    my_ts_item.Tag = imge_id
                Next
            End If
        Next
        db = Nothing
    End Sub

    Private Sub Click_mnuAudio(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmOpen As New frmAudios
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.AppStarting

        Dim NomAudioUSR As String = CType(sender, ToolStripMenuItem).Text
        Dim Flag As Boolean = IsLoadForm(frmOpen.Text.ToString & NomAudioUSR)
        If Not Flag Then
            If MyAPP.NovaConnex(CType(sender, ToolStripMenuItem).Text, Usuari.UsrNom, True) = True Then frmOpen.EstablirTaula(NomAudioUSR)
        Else
            frmOpen.WindowState = OldWinState
        End If
        LoadMnuPantalles()
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub tmrHora_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrHora.Tick
        Me._txtDateTime.Text = Now.ToLongDateString & ", " & Now.ToLongTimeString 'FormatDateTime(Today, DateFormat.LongDate) & ", " & Now.ToString("HH:mm:ss")


        Static TmpShowNews As Date = Now.AddSeconds(1)
        Static BlAlternate As Boolean = True

        If TmpShowNews < Now Then
            TmpShowNews = Now.AddSeconds(10)
            If BlAlternate = True Then
                BlAlternate = False
                If Params.IsAlternativeDir = True Then
                    Me.lbInfoProcesTasques.Text = MSG_ALTERNATIVE_DIR
                    lbInfoProcesTasques.Image = Me.ImageListMesages.Images(0)
                Else
                    Me.lbInfoProcesTasques.Tag = Cloud.News_URL
                    Select Case Cloud.News_Type
                        Case news_type.PLEASE_REGISTRY
                            Me.lbInfoProcesTasques.Text = MSG_PLEASE_REGISTRY
                            lbInfoProcesTasques.Image = Me.ImageListMesages.Images(1)
                        Case news_type.UP_TO_DATE
                            Me.lbInfoProcesTasques.Text = MSG_UP_TO_DATE
                            lbInfoProcesTasques.Image = Me.ImageListMesages.Images(2)
                        Case news_type.UPDATE_AVARIABLE
                            Me.lbInfoProcesTasques.Text = MSG_UPDATE_AVARIABLE
                            lbInfoProcesTasques.Image = Me.ImageListMesages.Images(1)
                        Case news_type.URGENT_UPDATE
                            Me.lbInfoProcesTasques.Text = MSG_URGENT_UPDATE
                            lbInfoProcesTasques.Image = Me.ImageListMesages.Images(2)
                        Case news_type.NEWS_RSS
                            'Todo: capturar titular de le notícies de la web
                    End Select
                End If
                BlAlternate = True
            Else
                lbInfoProcesTasques.Tag = -1
                If AmbTasquesPendents = True Then
                    Me.lbInfoProcesTasques.Text = MSG_TASKS_PENDING
                    lbInfoProcesTasques.Image = Me.ImageListMesages.Images(0)
                Else
                    Me.lbInfoProcesTasques.Text = MSG_NO_TASKS
                    lbInfoProcesTasques.Image = Nothing
                End If

            End If
        End If

        '---------------------------
        'Buscar instruccions remotes
        '---------------------------    
        Static TempRefresh As Date
        Static Flag As Boolean
        If TempRefresh < Now And filInstucServer.IsAlive = False Then
            TempRefresh = Now.AddMilliseconds(5000)
            filInstucServer = New Thread(AddressOf RI.getRemoteInstruccions)
            filInstucServer.IsBackground = True
            filInstucServer.Priority = ThreadPriority.Normal
            filInstucServer.Start()
            Flag = True
        ElseIf filInstucServer.IsAlive = False And Flag = True Then
            Flag = False
            'Un cop s'ha establert a procedim segons els casos
            Select Case CType(RI.ServerInstrucValue, ServerInstruc)
                Case ServerInstruc.MSC_NO_INSTRUC ' No fer res
                Case ServerInstruc.MSC_END : Me.Close()
                Case ServerInstruc.GEST_CLOSE_ALL_FORM
                    Dim I As Integer = Application.OpenForms.Count - 1
                    Do
                        Try
                            If My.Application.OpenForms.Item(I).Name.ToString <> "frmMain" Then
                                My.Application.OpenForms.Item(I).Close()
                            Else
                                I -= 1
                            End If
                        Catch ex As Exception
                            I -= 1
                        End Try
                        If I = 0 Then Exit Do
                        If My.Application.OpenForms.Count = 1 Then Exit Do
                    Loop
                    LoadMnuPantalles()
                Case ServerInstruc.GEST_CLOSE_FORM_RIPPER : tancaPantalla("frmImport")
                Case ServerInstruc.GEST_CLOSE_FORM_DISCOS : tancaPantalla("frmDiscos")
                Case ServerInstruc.GEST_CLOSE_FORM_TEMES : tancaPantalla("frmTemes")
                Case ServerInstruc.GEST_CLOSE_FORM_JINGELS : tancaPantalla("frmJingels")
                'Case ServerInstruc.GEST_CLOSE_FORM_PROMOS : tancaPantalla("frmPromos")
                Case ServerInstruc.GEST_CLOSE_FORM_PROGRAMES : tancaPantalla("frmProgrames")
                Case ServerInstruc.GEST_CLOSE_FORM_NOTICIES : tancaPantalla("frmNews")
                Case ServerInstruc.GEST_CLOSE_FORM_LIST_EXITS : tancaPantalla("frmExits")
                Case ServerInstruc.GEST_CLOSE_FORM_INTERPRETS : tancaPantalla("frmMantInterp")
                Case ServerInstruc.GEST_CLOSE_FORM_ESTIL : tancaPantalla("frmMantEstil")
                Case ServerInstruc.GEST_CLOSE_FORM_SUBJECT : tancaPantalla("frmMantSubject")
                Case ServerInstruc.GEST_CLOSE_FORM_DISCOGRAFICA : tancaPantalla("frmMantDicograf")
                'Case ServerInstruc.GEST_CLOSE_FORM_NACIONALITATS : tancaPantalla("frmMantNacionalitats")
                Case ServerInstruc.GEST_CLOSE_FORM_IDIOMES : tancaPantalla("frmMantIdioma")
                Case ServerInstruc.GEST_CLOSE_FORM_PROVEIDORS : tancaPantalla("frmMantProveidor")
                Case ServerInstruc.GEST_CLOSE_FORM_GRAFICS : tancaPantalla("frmGrafics")
                Case ServerInstruc.GEST_CLOSE_FORM_EQUIVALENCIES : tancaPantalla("frmEquival")
                Case ServerInstruc.GEST_CLOSE_FORM_AUDIO_USERS : tancaPantalla("frmAudio")
                Case ServerInstruc.GEST_CLOSE_FORM_PUBILITAT : tancaPantalla("frmPubli")
                Case ServerInstruc.GEST_CLOSE_FORM_CONTROL_PUPLI : tancaPantalla("frmCtlBlocs")
                Case ServerInstruc.GEST_CLOSE_FORM_CLIENTS : tancaPantalla("frmMantClients")
                Case ServerInstruc.GEST_CLOSE_FORM_PRODUCTES : tancaPantalla("frmMantProductes")
                Case ServerInstruc.GEST_CLOSE_FORM_TARIFES : tancaPantalla("frmMantTarifa")
                Case ServerInstruc.GEST_CLOSE_FORM_LOCUTORS : tancaPantalla("frmMantLocutors")
                Case ServerInstruc.GEST_CLOSE_FORM_TECNICS : tancaPantalla("frmMantTecnic")
                Case ServerInstruc.GEST_CLOSE_FORM_FRANGES : tancaPantalla("frmFrangeHora")
                Case ServerInstruc.GEST_CLOSE_FORM_INFORMES : tancaPantalla("frmInformRadia")
                Case ServerInstruc.GEST_CLOSE_FORM_BLOCS : tancaPantalla("frmBlocs")
                Case ServerInstruc.GEST_CLOSE_FORM_PAUTES : tancaPantalla("frmPautes")
                Case ServerInstruc.GEST_CLOSE_FORM_CALENDARI : tancaPantalla("frmCalendari")
                Case ServerInstruc.GEST_CLOSE_FORM_LOGGER : tancaPantalla("frmPrgLogger")
                Case ServerInstruc.GEST_CLOSE_FORM_RADIACIO : tancaPantalla("frmCtlRadia")
                Case ServerInstruc.GEST_CLOSE_FORM_PARAMETRES : tancaPantalla("frmParametres")
                Case ServerInstruc.GEST_CLOSE_FORM_BKP_AUDIO : tancaPantalla("frmMantBKPAudio")
                Case ServerInstruc.GEST_CLOSE_FORM_MANT_AUDIO : tancaPantalla("frmRestoreAudio")
                Case ServerInstruc.GEST_CLOSE_FORM_BKP_DBS : tancaPantalla("frmBKPDBS")
                Case ServerInstruc.GEST_CLOSE_FORM_USERS : tancaPantalla("frmUsers")
                Case ServerInstruc.GEST_CLOSE_FORM_CATEGORIES_NEWS : tancaPantalla("frmMantCatNews")
            End Select
        End If
    End Sub

    Private Sub tancaPantalla(ByVal NomPantalla As String)
        My.Application.OpenForms.Item(NomPantalla).Close()
        LoadMnuPantalles()
    End Sub

    Private Sub mnuRefHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRefHelp.Click

        Dim Proces As Process = New Process
        Try
            Process.Start(MSC.Help.HELP_MAIN.ToString)
        Catch ex As Exception
        End Try

    End Sub

    Private Sub listDevice()
        Dim info As New BASS_DEVICEINFO
        Dim c As Integer = 1
        While Not (info Is Nothing)
            info = Bass.BASS_GetDeviceInfo(c)
            If info Is Nothing Then Exit While
            cmbDevice.Items.Add(info.name)
            c += 1
        End While
    End Sub

    Private Sub cmbDevice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDevice.Click
        DEV_PLAY = cmbDevice.SelectedIndex
        IniBASS_CTL(DEV_PLAY + 1, IntPtr.Zero)
    End Sub

    Sub CmbDeviceTextChanged(sender As Object, e As EventArgs) Handles cmbDevice.TextChanged
        DEV_PLAY = cmbDevice.SelectedIndex
        IniBASS_CTL(DEV_PLAY + 1, IntPtr.Zero)
    End Sub

    Private Sub mnuTxtCapitalize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTxtCapitalize.Click
        mnuTxtCapitalize.Checked = Not mnuTxtCapitalize.Checked
        My.Settings.TXT_CAPITALIZE = mnuTxtCapitalize.Checked
        My.Settings.Save()
    End Sub

    Private Sub mnuProgEditAudio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuProgEditAudio.Click
        With OpenFileDialog1
            .FileName = ""
            .Title = "Buscar Programa ..."
            .Multiselect = False
            .Filter = "Fitxers EXE (*.exe) |*.exe"
            If .ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Dim FitxerINI As New IniFile
                FitxerINI.INIWrite(MyAPP.IniFile, "Data Control", "ProgEditAudio", .FileName)
                FitxerINI = Nothing
                Dim versionInfo As FileVersionInfo = System.Diagnostics.FileVersionInfo.GetVersionInfo(.FileName)
                Me.mnuProgEditAudio.Text = "Editor: " & versionInfo.FileDescription
            End If
        End With
    End Sub

    Private Sub mnuIniSessio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuIniSessio.Click, lbUserNom.Click
        Usuari.ShowPassWordForm(lang.Code)
        If Usuari.UsrOK = True Then
            HabilitarPerUsuari()
        Else
            Close()
        End If
    End Sub

    Private Sub frmMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        SetPositionMain()
    End Sub

    Private Sub txtDateTime_Click(sender As Object, e As EventArgs) Handles txtDateTime.Click
        'todo: mostrar calendadi 
    End Sub

    Private Sub lbInfoProcesTasques_Click(sender As Object, e As EventArgs) Handles lbInfoProcesTasques.Click
        Try
            Dim My_url As String = ""
            If sender.GetType.FullName = "MetroFramework.Controls.MetroTile" Then
                My_url = CType(sender, MetroFramework.Controls.MetroTile).Tag.ToString
            ElseIf sender.GetType.FullName = "MetroFramework.Controls.MetroLink" Then
                My_url = CType(sender, MetroFramework.Controls.MetroLink).Tag.ToString
            End If
            If My_url <> "-1" Then
                Dim my_Proces As Process = New Process
                my_Proces.Start(My_url)
            End If
        Catch ex As Exception

        End Try

    End Sub

End Class
