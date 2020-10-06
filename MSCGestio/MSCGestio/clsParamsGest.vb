Option Strict On
Option Explicit On
Imports System
Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Xml

Namespace Parametres

    Friend Class clsParams
        Friend blModif As Boolean = False
        'Taula: Parametres

        Dim param_FilesActives As Boolean
        Dim param_ID3Tag As Boolean
        Dim param_TarifaDef As Short
        Dim param_DaysDateOut As Short

        Dim param_PathArrelAudios As String
        Dim param_PathAlternativeAudios As String
        Dim IsPathAlternative As Boolean = False
        Dim param_PathProgrames As String
        Dim param_PathSenyalHora As String
        Dim param_CtlUsrCartut As Boolean
        Dim param_HoresTop As Short
        Dim param_HoresHitTop As Short
        Dim param_HoresHit As Short
        Dim param_HoresOld As Short
        Dim param_HoresOldTop As Short
        Dim param_NomRadio As String
        Dim param_NomsCarpetaAudiosUser As String
        Dim param_LogoEmpresa As Image
        Dim param_HoresBorrInterp As Short
        Dim param_IntervRitme As Short
        Dim param_PathMusica As String
        Dim param_PathPublicitat As String
        Dim param_PathDefPauta As String
        Dim param_CanviCat As Boolean
        Dim param_NTopHit As Short
        Dim param_NHitOld As Short
        Dim param_BorInterpIni As Boolean
        Dim param_PathAudioUser As String
        Dim param_VersioDBS As String
        Dim param_NomsCarpetaBlocs As String
        Dim param_ActvTabProgram As Boolean
        Dim param_Moneda As Short
        Dim param_ContraValor As Short
        Dim param_Canvi As Double

        Dim param_ProgramacioDefecte As Short
        Dim param_CommentDesconnexio As String


        Dim param_ActvSrvEmergenci As Boolean
        Dim param_ErrEmail As String
        Dim param_SendToDevelop As Boolean


        Dim param_MaxRadiTop As Short
        Dim param_MaxRadiHit As Short
        Dim param_MaxRadiOld As Short

        Dim param_AtvPSW As Boolean
        Dim param_TempPasPoxConex As Date
        Dim param_IntentsUsers As Short

        Dim param_Threshold As Integer
        Dim param_Attack As Short
        Dim param_VolNormalize As Integer
        Dim param_VolIni As Short

        Dim param_SegIniLoad As Short
        Dim param_MSegOClock As Short
        Dim param_FHExacte As Boolean
        Dim param_VolFader As Short
        Dim param_MilFader As Short
        Dim param_MilSegSH As Short
        'Dim param_NomAudio1 As String
        'Dim param_NomAudio2 As String
        Dim param_NumTracsVotWeb As Short
        Dim param_NumVotWebTorn As Short



        Dim param_Sequencia_Programs As Short
        Dim param_MailServerCR As String
        Dim param_UserNameCR As String
        Dim param_PasswordCR As String
        Dim param_RemitentCR As String
        Dim param_intervalCR As Integer
        Dim param_PathAudioUsers As String
        Dim param_PathBackups As String
        Dim param_PathSaveLogger As String

        Dim param_TimeRefrestInstruc As Short
        Dim param_FaceBook As String
        Dim param_Twitter As String
        Dim param_TwitterKey As String

        Dim param_MinutsDiscProhivit As Integer

        'Codificació Àudio
        Dim param_BitRate As String
        Dim param_SampleRate As String
        Dim param_Channels As String

        'AutoSaveBackup
        Dim param_LastBackup As Date
        'web de la ràdio
        Dim param_web As String

        'Idioma interface
        Dim param_Lang As String

        ''Servidor Streaming
        'Dim param_StreamSampleRate As String
        'Dim param_StreamBitRate As String
        'Dim param_Streamchannels As Integer
        'Dim param_StreamServerType As Integer
        'Dim param_StreamServer As String
        'Dim param_StreamPort As Integer
        'Dim param_StreamMountPoint As String
        'Dim param_StreamPassword As String
        Dim param_StreamStyle As String
        'Dim param_Stream_Url As String

        'cloud
        Dim param_ClientKey As String
        Dim param_ClientID As Integer
        Dim param_OnLine As Boolean = False

        Private Sub IniParams()

            Dim db As New MSC.dbs(Cloud)
            Dim dt As DataTable = db.getTable("SELECT params_valor FROM config_params ;")


            param_FilesActives = CBool(dt.Rows(CONFIG.paramFilesActives - 1)("params_valor"))
            param_ID3Tag = CBool(dt.Rows(CONFIG.paramID3Tag - 1)("params_valor"))
            param_TarifaDef = CShort(dt.Rows(CONFIG.paramTarifaDef - 1)("params_valor"))
            param_DaysDateOut = CShort(dt.Rows(CONFIG.paramDaysDateOut - 1)("params_valor"))
            param_NomsCarpetaAudiosUser = StripSlashes(dt.Rows(CONFIG.paramNomsCarpetaAudiosUser - 1)("params_valor").ToString)
            param_ActvSrvEmergenci = CBool(dt.Rows(CONFIG.paramActvSrvEmergenci - 1)("params_valor"))
            param_ErrEmail = StripSlashes(dt.Rows(CONFIG.paramErrEmail - 1)("params_valor").ToString)
            param_SendToDevelop = CBool(dt.Rows(CONFIG.paramSendToDevelop - 1)("params_valor"))

            param_NomRadio = StripSlashes(dt.Rows(CONFIG.paramNomClient - 1)("params_valor").ToString)
            param_web = StripSlashes(dt.Rows(CONFIG.paramWeb - 1)("params_valor").ToString)

            param_FaceBook = StripSlashes(dt.Rows(CONFIG.paramFaceBook - 1)("params_valor").ToString)
            param_Twitter = StripSlashes(dt.Rows(CONFIG.paramTwitter - 1)("params_valor").ToString)

            param_TimeRefrestInstruc = 15000

            param_PathArrelAudios = StripSlashes(dt.Rows(CONFIG.paramPathArrelAudios - 1)("params_valor").ToString)

            If IO.Directory.Exists(param_PathArrelAudios) = False Then
                Dim FitxerINI As New IniFile
                param_PathAlternativeAudios = FitxerINI.INIRead(MyAPP.IniFile, "Data Control", "AlternativeDir", "")
                If IO.Directory.Exists(param_PathAlternativeAudios) = True Then
                    param_PathArrelAudios = param_PathAlternativeAudios
                    IsPathAlternative = True
                End If
            End If

            Dim separador As String = "\"
            If param_PathArrelAudios.IndexOf("\") = -1 Then separador = "/"

            param_PathProgrames = param_PathArrelAudios & separador & DIR_PROGRAMES & separador
            param_PathMusica = param_PathArrelAudios & separador & DIR_MUSICA & separador
            param_PathPublicitat = param_PathArrelAudios & separador & DIR_PUBLICITAT & separador
            param_PathDefPauta = param_PathArrelAudios & separador & DIR_PAUTES & separador
            param_PathAudioUser = param_PathArrelAudios & separador & DIR_AUDIOUSER & separador
            param_PathBackups = param_PathArrelAudios & separador & DIR_BACKUPS & separador

            'load image Logo
            Try
                Dim bytes() As Byte = Convert.FromBase64String(dt.Rows(CONFIG.paramLogoEmpresa - 1)("params_valor").ToString)
                Dim MS As New System.IO.MemoryStream(bytes)
                param_LogoEmpresa = Image.FromStream(MS)
            Catch ex As Exception
                param_LogoEmpresa = Nothing
            End Try

            param_ProgramacioDefecte = CShort(dt.Rows(CONFIG.paramProgramacioDefecte - 1)("params_valor"))
            param_CommentDesconnexio = StripSlashes(dt.Rows(CONFIG.paramCommentDesconnexio - 1)("params_valor").ToString)

            param_PathSenyalHora = StripSlashes(dt.Rows(CONFIG.paramSenyalHoraria - 1)("params_valor").ToString)
            param_CtlUsrCartut = CBool(dt.Rows(CONFIG.paramCtlUsrCartut - 1)("params_valor"))

            param_NTopHit = CShort(dt.Rows(CONFIG.paramNTopHit - 1)("params_valor"))
            param_NHitOld = CShort(dt.Rows(CONFIG.paramNHitOld - 1)("params_valor"))

            param_ActvTabProgram = CBool(dt.Rows(CONFIG.paramActvTabProgram - 1)("params_valor"))
            param_Threshold = CInt(dt.Rows(CONFIG.paramThreshold - 1)("params_valor"))
            param_Attack = CShort(dt.Rows(CONFIG.paramAttack - 1)("params_valor"))
            param_VolNormalize = CInt(dt.Rows(CONFIG.paramVolNormalize - 1)("params_valor"))
            param_VolIni = CShort(dt.Rows(CONFIG.paramVolIni - 1)("params_valor"))

            'param_NomAudio1 = StripSlashes(dt.Rows(CONFIG.paramNomAudio1 - 1)("params_valor").ToString)
            'param_NomAudio2 = StripSlashes(dt.Rows(CONFIG.paramNomAudio2 - 1)("params_valor").ToString)
            param_HoresTop = CShort(dt.Rows(CONFIG.paramHoresTop - 1)("params_valor"))
            param_HoresHitTop = CShort(dt.Rows(CONFIG.paramHoresHitTop - 1)("params_valor"))
            param_HoresHit = CShort(dt.Rows(CONFIG.paramHoresHit - 1)("params_valor"))
            param_HoresOld = CShort(dt.Rows(CONFIG.paramHoresOld - 1)("params_valor"))
            param_HoresOldTop = CShort(dt.Rows(CONFIG.paramHoresOldTop - 1)("params_valor"))


            param_HoresBorrInterp = CShort(dt.Rows(CONFIG.paramHoresBorrInterp - 1)("params_valor"))
            param_IntervRitme = CShort(dt.Rows(CONFIG.paramIntervRitme - 1)("params_valor"))
            param_CanviCat = CBool(dt.Rows(CONFIG.paramCanviCat - 1)("params_valor"))
            param_BorInterpIni = CBool(dt.Rows(CONFIG.paramBorInterpIni - 1)("params_valor"))
            param_VersioDBS = StripSlashes(dt.Rows(CONFIG.paramVersioDBS - 1)("params_valor").ToString)
            param_NomsCarpetaBlocs = StripSlashes(dt.Rows(CONFIG.paramNomsCarpetaBlocs - 1)("params_valor").ToString)
            param_Moneda = CShort(dt.Rows(CONFIG.paramMoneda - 1)("params_valor"))
            param_ContraValor = CShort(dt.Rows(CONFIG.paramContraValor - 1)("params_valor"))
            param_Canvi = CDbl(dt.Rows(CONFIG.paramCanvi - 1)("params_valor"))
            'param_InputRadio = CShort(dt.Rows(CONFIG.paramInputRadio - 1)("params_valor"))
            param_MaxRadiTop = CShort(dt.Rows(CONFIG.paramMaxRadiTop - 1)("params_valor"))
            param_MaxRadiHit = CShort(dt.Rows(CONFIG.paramMaxRadiHit - 1)("params_valor"))
            param_MaxRadiOld = CShort(dt.Rows(CONFIG.paramMaxRadiOld - 1)("params_valor"))
            param_AtvPSW = CBool(dt.Rows(CONFIG.paramAtvPSW - 1)("params_valor"))
            param_TempPasPoxConex = CDate(dt.Rows(CONFIG.paramTempPasPoxConex - 1)("params_valor").ToString)
            param_IntentsUsers = CShort(dt.Rows(CONFIG.paramIntentsUsers - 1)("params_valor"))
            param_SegIniLoad = CShort(dt.Rows(CONFIG.paramSegIniLoad - 1)("params_valor"))
            param_MSegOClock = CShort(dt.Rows(CONFIG.paramMSegOClock - 1)("params_valor"))
            param_FHExacte = CBool(dt.Rows(CONFIG.paramFHExacte - 1)("params_valor"))
            param_VolFader = CShort(dt.Rows(CONFIG.paramVolFader - 1)("params_valor"))
            param_MilFader = CShort(dt.Rows(CONFIG.paramMilFader - 1)("params_valor"))
            param_MilSegSH = CShort(dt.Rows(CONFIG.paramMilSegSH - 1)("params_valor"))
            param_NumTracsVotWeb = CShort(dt.Rows(CONFIG.paramNumTracsVotWeb - 1)("params_valor"))
            param_NumVotWebTorn = CShort(dt.Rows(CONFIG.paramNumVotWebTorn - 1)("params_valor"))

            param_Sequencia_Programs = CShort(dt.Rows(CONFIG.paramSequencia - 1)("params_valor"))


            param_TwitterKey = StripSlashes(dt.Rows(CONFIG.paramTwitterKey - 1)("params_valor").ToString)
            param_MinutsDiscProhivit = CInt(dt.Rows(CONFIG.paramMinutsDiscProhivit - 1)("params_valor"))

            param_PathSaveLogger = (dt.Rows(CONFIG.paramPathSaveLogger - 1)("params_valor").ToString)

            'Codificació Àudio
            param_BitRate = dt.Rows(CONFIG.paramBitRate - 1)("params_valor").ToString
            param_SampleRate = dt.Rows(CONFIG.paramSampleRate - 1)("params_valor").ToString
            param_Channels = dt.Rows(CONFIG.paramChannels - 1)("params_valor").ToString

            'AutoSaveBackup
            param_LastBackup = CDate((dt.Rows(CONFIG.paramLastBackup - 1)("params_valor")))
            ' idioma interficie
            param_Lang = dt.Rows(CONFIG.paramLang - 1)("params_valor").ToString


            'control remot
            param_MailServerCR = StripSlashes(dt.Rows(CONFIG.paramMailServerCR - 1)("params_valor").ToString)
            param_UserNameCR = StripSlashes(dt.Rows(CONFIG.paramUserNameCR - 1)("params_valor").ToString)
            param_RemitentCR = StripSlashes(dt.Rows(CONFIG.paramRemitentCR - 1)("params_valor").ToString)
            param_intervalCR = CInt(dt.Rows(CONFIG.paramIntervalCR - 1)("params_valor"))


            'cloud OnLine
            param_OnLine = CBool(dt.Rows(CONFIG.paramOnLine - 1)("params_valor"))

            Dim StrSql As String = "SELECT AES_DECRYPT(UNHEX(params_valor),'" & Cloud.MSC_PRI_SECRET_KEY & "') as psw FROM config_params WHERE params_id = " & CONFIG.paramPasswordCR
            Try
                param_PasswordCR = Encoding.ASCII.GetString(CType(db.ExecuteScalar(StrSql), Byte()))
            Catch ex As Exception
                param_PasswordCR = ""
            End Try

            'cloud			
            param_ClientID = CInt(dt.Rows(CONFIG.paramClientID - 1)("params_valor"))
            StrSql = "SELECT AES_DECRYPT(UNHEX(params_valor),'" & Cloud.MSC_PRI_SECRET_KEY & "') as psw FROM config_params WHERE params_id = " & CONFIG.paramClientKey
            Try
                param_ClientKey = Encoding.ASCII.GetString(CType(db.ExecuteScalar(StrSql), Byte()))
            Catch ex As Exception
                param_ClientKey = ""
            End Try
            If param_OnLine = True AndAlso param_ClientKey.Length > 0 Then
                Try
                    Dim user As String = getMD5Hash(param_NomRadio)
                    Cloud.Register(param_ClientKey, user, param_Lang, GENERAL_VERSION)
                    Cloud.IniFTP()
                    Cloud.IniStream()
                Catch ex As Exception
                    param_OnLine = False
                    param_ClientKey = ""
                    param_ClientID = -1
                End Try
            End If

            blModif = False
            dt.Dispose()
            db = Nothing
        End Sub

        Friend Sub SaveParams(change_Cartutx As Boolean, change_ConnexCentral As Boolean, change_CtlRemot As Boolean,
            change_CtlUsers As Boolean, change_DirMagatzem As Boolean, change_Emergencies As Boolean, change_EncoderAudio As Boolean,
            change_IntegraWeb As Boolean, change_Moneda As Boolean, change_MSCControler As Boolean,
            change_MSCDirecte As Boolean, change_ParamsGenerals As Boolean, change_ReglesMusic As Boolean, change_SequenciPautes As Boolean,
            change_SistemDades As Boolean, change_Streaming As Boolean)
            Dim StrSql As String = ""
            Dim db As New MSC.dbs(Cloud)

            If change_Cartutx = True Then
                StrSql += "UPDATE config_params SET params_valor='" & CShort(IIf(param_ActvTabProgram, 1, 0)) & "' WHERE params_id=" & CONFIG.paramActvTabProgram & " ;"
                StrSql += "UPDATE config_params SET params_valor='" & CShort(IIf(param_CtlUsrCartut, 1, 0)) & "' WHERE params_id=" & CONFIG.paramCtlUsrCartut & " ;"
                db.Update_ID(StrSql) : StrSql = ""
            End If
            If change_ConnexCentral = True Then
                StrSql += "UPDATE config_params SET params_valor='" & param_VolFader & "' WHERE params_id=" & CONFIG.paramVolFader & " ;"
                StrSql += "UPDATE config_params SET params_valor='" & param_MilFader & "' WHERE params_id=" & CONFIG.paramMilFader & " ;"

                db.Update_ID(StrSql) : StrSql = ""
            End If
            If change_CtlRemot = True Then
                StrSql += "UPDATE config_params SET params_valor='" & param_RemitentCR & "' WHERE params_id=" & CONFIG.paramRemitentCR & " ;"
                StrSql += "UPDATE config_params SET params_valor='" & param_MailServerCR & "' WHERE params_id=" & CONFIG.paramMailServerCR & " ;"
                StrSql += "UPDATE config_params SET params_valor='" & param_UserNameCR & "' WHERE params_id=" & CONFIG.paramUserNameCR & " ;"
                StrSql += "UPDATE config_params SET params_valor='" & param_intervalCR & "' WHERE params_id=" & CONFIG.paramIntervalCR & " ;"
                db.Update_ID(StrSql) : StrSql = ""
                If Not IsNothing(param_PasswordCR) AndAlso param_PasswordCR.Length > 0 Then
                    StrSql = "UPDATE config_params SET params_valor= HEX(AES_ENCRYPT('" & param_PasswordCR & "','" & Cloud.MSC_PRI_SECRET_KEY & "')) WHERE params_id=" & CONFIG.paramPasswordCR & " ;"
                    db.Update_ID(StrSql) : StrSql = ""
                End If


            End If
            If change_CtlUsers = True Then
                StrSql += "UPDATE config_params SET params_valor='" & param_IntentsUsers & "' WHERE params_id=" & CONFIG.paramIntentsUsers & " ;"
                StrSql += "UPDATE config_params SET params_valor='" & param_TempPasPoxConex & "' WHERE params_id=" & CONFIG.paramTempPasPoxConex & " ;"
                StrSql += "UPDATE config_params SET params_valor='" & CShort(IIf(param_AtvPSW, 1, 0)) & "' WHERE params_id=" & CONFIG.paramAtvPSW & " ;"
                db.Update_ID(StrSql) : StrSql = ""

            End If
            If change_DirMagatzem Then
                StrSql += "UPDATE config_params SET params_valor='" & AddSlashes(param_PathArrelAudios) & "' WHERE params_id=" & CONFIG.paramPathArrelAudios & " ;"
                db.Update_ID(StrSql) : StrSql = ""
            End If

            If change_Emergencies = True Then
                StrSql += "UPDATE config_params SET params_valor='" & CShort(IIf(param_ActvSrvEmergenci, 1, 0)) & "' WHERE params_id=" & CONFIG.paramActvSrvEmergenci & " ;"
                StrSql += "UPDATE config_params SET params_valor='" & param_ErrEmail & "' WHERE params_id=" & CONFIG.paramErrEmail & " ;"
                StrSql += "UPDATE config_params SET params_valor='" & CShort(IIf(param_SendToDevelop, 1, 0)) & "' WHERE params_id=" & CONFIG.paramSendToDevelop & " ;"


                db.Update_ID(StrSql) : StrSql = ""
            End If
            If change_EncoderAudio = True Then
                'Codificació Àudio
                StrSql += "UPDATE config_params SET params_valor='" & param_BitRate & "' WHERE params_id=" & CONFIG.paramBitRate & " ;"
                StrSql += "UPDATE config_params SET params_valor='" & param_SampleRate & "' WHERE params_id=" & CONFIG.paramSampleRate & " ;"
                StrSql += "UPDATE config_params SET params_valor='" & param_Channels & "' WHERE params_id=" & CONFIG.paramChannels & " ;"
                db.Update_ID(StrSql) : StrSql = ""
                StrSql += "UPDATE config_params SET params_valor='" & CShort(IIf(param_FilesActives, 1, 0)) & "' WHERE params_id=" & CONFIG.paramFilesActives & " ;"
                StrSql += "UPDATE config_params SET params_valor='" & CShort(IIf(param_ID3Tag, 1, 0)) & "' WHERE params_id=" & CONFIG.paramID3Tag & " ;"
                db.Update_ID(StrSql) : StrSql = ""
            End If
            If change_IntegraWeb = True Then
                StrSql += "UPDATE config_params SET params_valor='" & param_NumTracsVotWeb & "' WHERE params_id=" & CONFIG.paramNumTracsVotWeb & " ;"
                StrSql += "UPDATE config_params SET params_valor='" & param_NumVotWebTorn & "' WHERE params_id=" & CONFIG.paramNumVotWebTorn & " ;"
                db.Update_ID(StrSql) : StrSql = ""
            End If

            If change_Moneda = True Then
                StrSql += "UPDATE config_params SET params_valor='" & param_Moneda & "' WHERE params_id=" & CONFIG.paramMoneda & " ;"
                StrSql += "UPDATE config_params SET params_valor='" & param_ContraValor & "' WHERE params_id=" & CONFIG.paramContraValor & " ;"
                StrSql += "UPDATE config_params SET params_valor='" & param_Canvi & "' WHERE params_id=" & CONFIG.paramCanvi & " ;"
                db.Update_ID(StrSql) : StrSql = ""
                StrSql += "UPDATE config_params SET params_valor='" & param_TarifaDef & "' WHERE params_id=" & CONFIG.paramTarifaDef & " ;"
                StrSql += "UPDATE config_params SET params_valor='" & param_DaysDateOut & "' WHERE params_id=" & CONFIG.paramDaysDateOut & " ;"
                db.Update_ID(StrSql) : StrSql = ""
            End If
            If change_MSCControler = True Then
                StrSql += "UPDATE config_params SET params_valor='" & AddSlashes(param_PathSenyalHora) & "' WHERE params_id=" & CONFIG.paramSenyalHoraria & " ;"
                StrSql += "UPDATE config_params SET params_valor='" & param_MilSegSH & "' WHERE params_id=" & CONFIG.paramMilSegSH & " ;"
                db.Update_ID(StrSql) : StrSql = ""
            End If
            If change_MSCDirecte = True Then
                'StrSql += "UPDATE config_params SET params_valor='" & param_SegIniLoad & "' WHERE params_id=" & CONFIG.paramSegIniLoad & " ;" 
                StrSql += "UPDATE config_params SET params_valor='" & param_MSegOClock & "' WHERE params_id=" & CONFIG.paramMSegOClock & " ;"
                StrSql += "UPDATE config_params SET params_valor='" & CShort(IIf(param_FHExacte, 1, 0)) & "' WHERE params_id=" & CONFIG.paramFHExacte & " ;"
                StrSql += "UPDATE config_params SET params_valor='" & CShort(IIf(param_BorInterpIni, 1, 0)) & "' WHERE params_id=" & CONFIG.paramBorInterpIni & " ;"
                db.Update_ID(StrSql) : StrSql = ""
            End If
            If change_ParamsGenerals = True Then
                StrSql += "UPDATE config_params SET params_valor='" & AddSlashes(param_NomRadio) & "' WHERE params_id=" & CONFIG.paramNomClient & " ;"
                StrSql += "UPDATE config_params SET params_valor='" & AddSlashes(param_web) & "' WHERE params_id=" & CONFIG.paramWeb & " ;"
                StrSql += "UPDATE config_params SET params_valor='" & CShort(IIf(param_OnLine, 1, 0)) & "' WHERE params_id=" & CONFIG.paramOnLine & " ;"
                StrSql += "UPDATE config_params SET params_valor='" & AddSlashes(param_CommentDesconnexio) & "' WHERE params_id=" & CONFIG.paramCommentDesconnexio & " ;"
                db.Update_ID(StrSql) : StrSql = ""
                StrSql += "UPDATE config_params SET params_valor='" & AddSlashes(param_FaceBook) & "' WHERE params_id=" & CONFIG.paramFaceBook & " ;"
                StrSql += "UPDATE config_params SET params_valor='" & AddSlashes(param_Twitter) & "' WHERE params_id=" & CONFIG.paramTwitter & " ;"
                StrSql += "UPDATE config_params SET params_valor='" & AddSlashes(param_TwitterKey) & "' WHERE params_id=" & CONFIG.paramTwitterKey & " ;"
                db.Update_ID(StrSql) : StrSql = ""
                StrSql += "UPDATE config_params SET params_valor='" & CShort(param_ProgramacioDefecte) & "' WHERE params_id=" & CONFIG.paramProgramacioDefecte & " ;"
                StrSql += "UPDATE config_params SET params_valor='" & param_Lang & "' WHERE params_id=" & CONFIG.paramLang & " ;"
                StrSql += "UPDATE config_params SET params_valor='" & AddSlashes(param_NomsCarpetaBlocs) & "' WHERE params_id=" & CONFIG.paramNomsCarpetaBlocs & " ;"
                StrSql += "UPDATE config_params SET params_valor='" & AddSlashes(param_NomsCarpetaAudiosUser) & "' WHERE params_id=" & CONFIG.paramNomsCarpetaAudiosUser & " ;"
                db.Update_ID(StrSql) : StrSql = ""
                If Not IsNothing(param_LogoEmpresa) Then
                    Dim ms As IO.MemoryStream = New IO.MemoryStream
                    param_LogoEmpresa.Save(ms, Imaging.ImageFormat.Jpeg)
                    StrSql = "UPDATE config_params SET params_valor='" & Convert.ToBase64String(ms.ToArray) & "' WHERE params_id=" & CONFIG.paramLogoEmpresa & " ;"
                    db.Update_ID(StrSql) : StrSql = ""
                End If
            End If
            If change_ReglesMusic = True Then
                StrSql += "UPDATE config_params SET params_valor='" & param_HoresTop & "' WHERE params_id=" & CONFIG.paramHoresTop & " ;"
                StrSql += "UPDATE config_params SET params_valor='" & param_HoresHitTop & "' WHERE params_id=" & CONFIG.paramHoresHitTop & " ;"
                StrSql += "UPDATE config_params SET params_valor='" & param_HoresHit & "' WHERE params_id=" & CONFIG.paramHoresHit & " ;"
                StrSql += "UPDATE config_params SET params_valor='" & param_HoresOld & "' WHERE params_id=" & CONFIG.paramHoresOld & " ;"
                db.Update_ID(StrSql) : StrSql = ""
                StrSql += "UPDATE config_params SET params_valor='" & param_HoresOldTop & "' WHERE params_id=" & CONFIG.paramHoresOldTop & " ;"
                StrSql += "UPDATE config_params SET params_valor='" & param_HoresBorrInterp & "' WHERE params_id=" & CONFIG.paramHoresBorrInterp & " ;"
                StrSql += "UPDATE config_params SET params_valor='" & param_IntervRitme & "' WHERE params_id=" & CONFIG.paramIntervRitme & " ;"
                StrSql += "UPDATE config_params SET params_valor='" & param_MinutsDiscProhivit & "' WHERE params_id=" & CONFIG.paramMinutsDiscProhivit & " ;"
                db.Update_ID(StrSql) : StrSql = ""
                StrSql += "UPDATE config_params SET params_valor='" & CShort(IIf(param_CanviCat, 1, 0)) & "' WHERE params_id=" & CONFIG.paramCanviCat & " ;"
                StrSql += "UPDATE config_params SET params_valor='" & param_NTopHit & "' WHERE params_id=" & CONFIG.paramNTopHit & " ;"
                StrSql += "UPDATE config_params SET params_valor='" & param_NHitOld & "' WHERE params_id=" & CONFIG.paramNHitOld & " ;"
                StrSql += "UPDATE config_params SET params_valor='" & param_MaxRadiTop & "' WHERE params_id=" & CONFIG.paramMaxRadiTop & " ;"
                db.Update_ID(StrSql) : StrSql = ""
                StrSql += "UPDATE config_params SET params_valor='" & param_MaxRadiHit & "' WHERE params_id=" & CONFIG.paramMaxRadiHit & " ;"
                StrSql += "UPDATE config_params SET params_valor='" & param_MaxRadiOld & "' WHERE params_id=" & CONFIG.paramMaxRadiOld & " ;"

                db.Update_ID(StrSql) : StrSql = ""
            End If
            If change_SequenciPautes = True Then
                StrSql += "UPDATE config_params SET params_valor='" & param_Sequencia_Programs & "' WHERE params_id=" & CONFIG.paramSequencia & " ;"
                db.Update_ID(StrSql) : StrSql = ""
            End If
            If change_SistemDades = True Then
                StrSql += "UPDATE config_params SET params_valor='" & param_LastBackup.ToString("yyyy-MM-dd HH:mm:ss") & "' WHERE params_id=" & CONFIG.paramLastBackup & " ;"
                db.Update_ID(StrSql) : StrSql = ""
            End If
            If change_Streaming = True Then
                'StrSql += "UPDATE config_params SET params_valor='" & AddSlashes(param_UrlStreaming) & "' WHERE params_id=" & CONFIG.paramURLStreaming & " ;"
                StrSql += "UPDATE config_params SET params_valor='" & param_StreamStyle & "' WHERE params_id=" & CONFIG.paramStreamStyle & " ;"
                db.Update_ID(StrSql) : StrSql = ""
            End If

            blModif = False
            db = Nothing
        End Sub

        Sub New()
            IniParams()
        End Sub

        Friend ReadOnly Property ClientKey() As String
            Get
                Return param_ClientKey
            End Get
        End Property

        Friend ReadOnly Property ClientID() As Integer
            Get
                Return param_ClientID
            End Get
        End Property

        Friend ReadOnly Property IsAlternativeDir() As Boolean
            Get
                Return IsPathAlternative
            End Get
        End Property

        Friend Property Lang() As String
            Get
                Return param_Lang
            End Get
            Set(ByVal Value As String)
                blModif = True
                param_Lang = Value
            End Set
        End Property

        Friend Property NomsCarpetaAudiosUser() As String
            Get
                Return param_NomsCarpetaAudiosUser
            End Get
            Set(ByVal Value As String)
                blModif = True
                param_NomsCarpetaAudiosUser = Value
            End Set
        End Property



        Friend Property Web() As String
            Get
                Return param_web
            End Get
            Set(ByVal Value As String)
                blModif = True
                param_web = Value
            End Set
        End Property

        Friend Property FaceBook() As String
            Get
                Return param_FaceBook
            End Get
            Set(ByVal Value As String)
                blModif = True
                param_FaceBook = Value
            End Set
        End Property

        Friend Property Twitter() As String
            Get
                Return param_Twitter
            End Get
            Set(ByVal Value As String)
                blModif = True
                param_Twitter = Value
            End Set
        End Property

        Friend Property TwitterKey() As String
            Get
                Return param_TwitterKey
            End Get
            Set(ByVal Value As String)
                blModif = True
                param_TwitterKey = Value
            End Set
        End Property

        Friend Property PathArrelAudios() As String
            Get
                Return param_PathArrelAudios
            End Get
            Set(ByVal Value As String)
                blModif = True
                param_PathArrelAudios = Value
            End Set
        End Property

        Friend Property PathProgrames() As String
            Get
                Return param_PathProgrames
            End Get
            Set(ByVal value As String)
                param_PathProgrames = value
            End Set
        End Property

        Friend Property PathMusica() As String
            Get
                Return param_PathMusica
            End Get
            Set(ByVal value As String)
                param_PathMusica = value
            End Set
        End Property

        Friend Property PathPublicitat() As String
            Get
                Return param_PathPublicitat
            End Get
            Set(ByVal value As String)
                param_PathPublicitat = value
            End Set
        End Property

        Friend Property PathDefPauta() As String
            Get
                Return param_PathDefPauta
            End Get
            Set(ByVal value As String)
                param_PathDefPauta = value
            End Set
        End Property

        Friend Property PathSaveLogger() As String
            Get
                Return param_PathSaveLogger
            End Get
            Set(ByVal Value As String)
                blModif = True
                param_PathSaveLogger = Value
            End Set
        End Property

        Friend Property PathSenyalHora() As String
            Get
                Return param_PathSenyalHora
            End Get
            Set(ByVal Value As String)
                blModif = True
                param_PathSenyalHora = Value
            End Set
        End Property

        Friend Property CtlUsrCartut() As Boolean
            Get
                Return param_CtlUsrCartut
            End Get
            Set(ByVal Value As Boolean)
                blModif = True
                param_CtlUsrCartut = Value
            End Set
        End Property

        Friend Property ID3Tag() As Boolean
            Get
                Return param_ID3Tag
            End Get
            Set(ByVal Value As Boolean)
                blModif = True
                param_ID3Tag = Value
            End Set
        End Property

        Friend Property FilesActives() As Boolean
            Get
                Return param_FilesActives
            End Get
            Set(ByVal Value As Boolean)
                blModif = True
                param_FilesActives = Value
            End Set
        End Property

        Friend Property DaysDateOut() As Short
            Get
                Return param_DaysDateOut
            End Get
            Set(ByVal Value As Short)
                blModif = True
                param_DaysDateOut = Value
            End Set
        End Property

        Friend Property TarifaDef() As Short
            Get
                Return param_TarifaDef
            End Get
            Set(ByVal Value As Short)
                blModif = True
                param_TarifaDef = Value
            End Set
        End Property

        Friend Property HoresTop() As Short
            Get
                Return param_HoresTop
            End Get
            Set(ByVal Value As Short)
                blModif = True
                param_HoresTop = Value
            End Set
        End Property

        Friend Property HoresHitTop() As Short
            Get
                Return param_HoresHitTop
            End Get
            Set(ByVal Value As Short)
                blModif = True
                param_HoresHitTop = Value
            End Set
        End Property

        Friend Property HoresHit() As Short
            Get
                Return param_HoresHit
            End Get
            Set(ByVal Value As Short)
                blModif = True
                param_HoresHit = Value
            End Set
        End Property

        Friend Property HoresOld() As Short
            Get
                Return param_HoresOld
            End Get
            Set(ByVal Value As Short)
                blModif = True
                param_HoresOld = Value
            End Set
        End Property

        Friend Property HoresOldTop() As Short
            Get
                Return param_HoresOldTop
            End Get
            Set(ByVal Value As Short)
                blModif = True
                param_HoresOldTop = Value
            End Set
        End Property

        Friend Property NomRadio() As String
            Get
                Return param_NomRadio
            End Get
            Set(ByVal Value As String)
                blModif = True
                param_NomRadio = Value
            End Set
        End Property

        Friend Property LogoEmpresa() As Image
            Get
                Return param_LogoEmpresa
            End Get
            Set(ByVal img As Image)
                blModif = True
                param_LogoEmpresa = img
            End Set
        End Property

        Friend Property HoresBorrInterp() As Short
            Get
                Return param_HoresBorrInterp
            End Get
            Set(ByVal Value As Short)
                blModif = True
                param_HoresBorrInterp = Value
            End Set
        End Property

        Friend Property IntervRitme() As Short
            Get
                Return param_IntervRitme
            End Get
            Set(ByVal Value As Short)
                blModif = True
                param_IntervRitme = Value
            End Set
        End Property



        Friend Property CanviCat() As Boolean
            Get
                Return param_CanviCat
            End Get
            Set(ByVal Value As Boolean)
                blModif = True
                param_CanviCat = Value
            End Set
        End Property

        Friend Property ProgramacioDefecte() As Short
            Get
                Return param_ProgramacioDefecte
            End Get
            Set(ByVal Value As Short)
                blModif = True
                param_ProgramacioDefecte = Value
            End Set
        End Property


        Friend Property NTopHit() As Short
            Get
                Return param_NTopHit
            End Get
            Set(ByVal Value As Short)
                blModif = True
                param_NTopHit = Value
            End Set
        End Property

        Friend Property NHitOld() As Short
            Get
                Return param_NHitOld
            End Get
            Set(ByVal Value As Short)
                blModif = True
                param_NHitOld = Value
            End Set
        End Property

        Friend Property BorInterpIni() As Boolean
            Get
                Return param_BorInterpIni
            End Get
            Set(ByVal Value As Boolean)
                blModif = True
                param_BorInterpIni = Value
            End Set
        End Property

        Friend Property PathAudioUser() As String
            Get
                Return param_PathAudioUser
            End Get
            Set(ByVal value As String)
                param_PathAudioUser = value
            End Set
        End Property

        Friend Property PathBackups() As String
            Get
                Return param_PathBackups
            End Get
            Set(ByVal value As String)
                param_PathBackups = value
            End Set
        End Property


        Friend Property NomsCarpetaBlocs() As String
            Get
                Return param_NomsCarpetaBlocs
            End Get
            Set(ByVal Value As String)
                param_NomsCarpetaBlocs = Value
            End Set
        End Property

        Friend Property ActvTabProgram() As Boolean
            Get
                Return param_ActvTabProgram
            End Get
            Set(ByVal Value As Boolean)
                blModif = True
                param_ActvTabProgram = Value
            End Set
        End Property

        Friend Property Moneda() As Short
            Get
                Return param_Moneda
            End Get
            Set(ByVal Value As Short)
                blModif = True
                param_Moneda = Value
            End Set
        End Property

        Friend Property ContraValor() As Short
            Get
                Return param_ContraValor
            End Get
            Set(ByVal Value As Short)
                blModif = True
                param_ContraValor = Value
            End Set
        End Property

        Friend Property Canvi() As Double
            Get
                Return param_Canvi
            End Get
            Set(ByVal Value As Double)
                blModif = True
                param_Canvi = Value
            End Set
        End Property

        Friend Property ErrEmail() As String
            Get
                Return param_ErrEmail
            End Get
            Set(ByVal Value As String)
                param_ErrEmail = Value
            End Set
        End Property

        Friend Property SendToDevelop() As Boolean
            Get
                Return param_SendToDevelop
            End Get
            Set(ByVal Value As Boolean)
                blModif = True
                param_SendToDevelop = Value
            End Set
        End Property


        Friend Property ActvSrvEmergenci() As Boolean
            Get
                Return param_ActvSrvEmergenci
            End Get
            Set(ByVal Value As Boolean)
                blModif = True
                param_ActvSrvEmergenci = Value
            End Set
        End Property

        '        Friend Property InputRadio() As Short
        '            Get
        '                Return param_InputRadio
        '            End Get
        '            Set(ByVal Value As Short)
        '                blModif = True
        '                param_InputRadio = Value
        '            End Set
        '        End Property

        Friend Property MaxRadiTop() As Short
            Get
                Return param_MaxRadiTop
            End Get
            Set(ByVal Value As Short)
                blModif = True
                param_MaxRadiTop = Value
            End Set
        End Property

        Friend Property MaxRadiHit() As Short
            Get
                Return param_MaxRadiHit
            End Get
            Set(ByVal Value As Short)
                blModif = True
                param_MaxRadiHit = Value
            End Set
        End Property

        Friend Property MaxRadiOld() As Short
            Get
                Return param_MaxRadiOld
            End Get
            Set(ByVal Value As Short)
                blModif = True
                param_MaxRadiOld = Value
            End Set
        End Property

        'Taula: Parametres2
        Friend Property Threshold() As Integer
            Get
                Return param_Threshold
            End Get
            Set(ByVal Value As Integer)
                blModif = True
                param_Threshold = Value
            End Set
        End Property

        Friend Property Attack() As Short
            Get
                Return param_Attack
            End Get
            Set(ByVal Value As Short)
                blModif = True
                param_Attack = Value
            End Set
        End Property

        Friend Property VolNormalize() As Integer
            Get
                Return param_VolNormalize
            End Get
            Set(ByVal Value As Integer)
                blModif = True
                param_VolNormalize = Value
            End Set
        End Property

        Friend Property VolIni() As Short
            Get
                Return param_VolIni
            End Get
            Set(ByVal Value As Short)
                blModif = True
                param_VolIni = Value
            End Set
        End Property


        Friend Property SegIniLoad() As Short
            Get
                Return param_SegIniLoad
            End Get
            Set(ByVal Value As Short)
                blModif = True
                param_SegIniLoad = Value
            End Set
        End Property

        Friend Property MSegOClock() As Short
            Get
                Return param_MSegOClock
            End Get
            Set(ByVal Value As Short)
                blModif = True
                param_MSegOClock = Value
            End Set
        End Property

        Friend Property FHExacte() As Boolean
            Get
                Return param_FHExacte
            End Get
            Set(ByVal Value As Boolean)
                blModif = True
                param_FHExacte = Value
            End Set
        End Property

        Friend Property VolFader() As Short
            Get
                Return param_VolFader
            End Get
            Set(ByVal Value As Short)
                blModif = True
                param_VolFader = Value
            End Set
        End Property

        Friend Property MilFader() As Short
            Get
                Return param_MilFader
            End Get
            Set(ByVal Value As Short)
                blModif = True
                param_MilFader = Value
            End Set
        End Property

        Friend Property MilSegSH() As Short
            Get
                Return param_MilSegSH
            End Get
            Set(ByVal Value As Short)
                blModif = True
                param_MilSegSH = Value
            End Set
        End Property

        'Friend Property NomAudio1() As String
        '    Get
        '        Return param_NomAudio1
        '    End Get
        '    Set(ByVal Value As String)
        '        blModif = True
        '        param_NomAudio1 = Value
        '    End Set
        'End Property

        'Friend Property NomAudio2() As String
        '    Get
        '        Return param_NomAudio2
        '    End Get
        '    Set(ByVal Value As String)
        '        blModif = True
        '        param_NomAudio2 = Value
        '    End Set
        'End Property

        Friend Property NumTracsVotWeb() As Short
            Get
                Return param_NumTracsVotWeb
            End Get
            Set(ByVal Value As Short)
                blModif = True
                param_NumTracsVotWeb = Value
            End Set
        End Property

        Friend Property NumVotWebTorn() As Short
            Get
                Return param_NumVotWebTorn
            End Get
            Set(ByVal Value As Short)
                blModif = True
                param_NumVotWebTorn = Value
            End Set
        End Property

        Friend Property VersioDBS() As String
            Get
                Return param_VersioDBS
            End Get
            Set(ByVal Value As String)
                blModif = True
                param_VersioDBS = Value
            End Set
        End Property


        Friend Property AtvPSW() As Boolean
            Get
                Return param_AtvPSW
            End Get
            Set(ByVal Value As Boolean)
                blModif = True
                param_AtvPSW = Value
            End Set
        End Property

        'param_TempPasPoxConex
        Friend Property TempPasPoxConex() As Date
            Get
                Return param_TempPasPoxConex
            End Get
            Set(ByVal Value As Date)
                blModif = True
                param_TempPasPoxConex = Value
            End Set
        End Property

        Friend Property IntentsUsers() As Short
            Get
                Return param_IntentsUsers
            End Get
            Set(ByVal Value As Short)
                blModif = True
                param_IntentsUsers = Value
            End Set
        End Property

        Friend Property Sequencia_Programs() As Short
            Get
                Return param_Sequencia_Programs
            End Get
            Set(ByVal Value As Short)
                blModif = True
                param_Sequencia_Programs = Value
            End Set
        End Property

        Friend Property MailServerCR() As String
            Get
                Return param_MailServerCR
            End Get
            Set(ByVal Value As String)
                blModif = True
                param_MailServerCR = Value
            End Set
        End Property

        Friend Property UserNameCR() As String
            Get
                Return param_UserNameCR
            End Get
            Set(ByVal Value As String)
                blModif = True
                param_UserNameCR = Value
            End Set
        End Property

        Friend Property PasswordCR() As String
            Get
                Return param_PasswordCR
            End Get
            Set(ByVal Value As String)
                blModif = True
                param_PasswordCR = Value
            End Set
        End Property

        Friend Property RemitentCR() As String
            Get
                Return param_RemitentCR
            End Get
            Set(ByVal Value As String)
                blModif = True
                param_RemitentCR = Value
            End Set
        End Property

        Friend Property intervalCR() As Integer
            Get
                Return param_intervalCR
            End Get
            Set(ByVal value As Integer)
                param_intervalCR = value
            End Set
        End Property

        Friend Property TimeRefrestInstruc() As Short
            Get
                Return param_TimeRefrestInstruc
            End Get
            Set(ByVal Value As Short)
                blModif = True
                param_TimeRefrestInstruc = Value
            End Set
        End Property

        Friend Property MinutsDiscProhivit() As Integer
            Get
                Return param_MinutsDiscProhivit
            End Get
            Set(ByVal Value As Integer)
                blModif = True
                param_MinutsDiscProhivit = Value
            End Set
        End Property

        'Codificació Àudio
        Friend Property BitRate() As String
            Get
                Return param_BitRate
            End Get
            Set(ByVal Value As String)
                blModif = True
                param_BitRate = Value
            End Set
        End Property

        Friend Property SampleRate() As String
            Get
                Return param_SampleRate
            End Get
            Set(ByVal Value As String)
                blModif = True
                param_SampleRate = Value
            End Set
        End Property

        Friend Property Channels() As String
            Get
                Return param_Channels
            End Get
            Set(ByVal Value As String)
                blModif = True
                param_Channels = Value
            End Set
        End Property

        Friend Property CommentDesconnexio() As String
            Get
                Return param_CommentDesconnexio
            End Get
            Set(ByVal Value As String)
                blModif = True
                param_CommentDesconnexio = Value
            End Set
        End Property


        Friend Property LastBackup() As Date
            Get
                Return param_LastBackup
            End Get
            Set(ByVal Value As Date)
                blModif = True
                param_LastBackup = Value

                Dim StrSql As String = "UPDATE config_params SET params_valor='" & param_LastBackup.ToString("yyyy-MM-dd HH:mm:ss") & "' WHERE params_id=" & CONFIG.paramLastBackup & " ;"
                Dim db As New MSC.dbs(Cloud)
                db.Update_ID(StrSql)
                db = Nothing
            End Set
        End Property

        Friend Property StreamStyle() As String
            Get
                Return param_StreamStyle
            End Get
            Set(ByVal Value As String)
                blModif = True
                param_StreamStyle = Value
            End Set
        End Property

        Friend Property OnLine() As Boolean
            Get
                Return param_OnLine
            End Get
            Set(ByVal Value As Boolean)
                blModif = True
                param_OnLine = Value
            End Set
        End Property

    End Class

End Namespace