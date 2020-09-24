Option Strict On
Option Explicit On

Imports BassTags = Un4seen.Bass.AddOn.Tags.BassTags
Imports Un4seen.Bass
Imports MySql.Data.MySqlClient


Module mdlGestio
    Friend Const BETA_VERSION As Boolean = True
    Friend MyAPP As MSC.Control.MSC_Aplic
	Friend Usuari As MSC.User
	Friend Params As Parametres.clsParams
    Friend Lang As MSC.UserLanguage
    Friend Cloud As msc_cloud.Cloud = New msc_cloud.Cloud()
    'Friend ENABLE_JAMENDO As Boolean = True

    Friend DEV_PLAY As Short = 0
	
	Friend AmbTasquesPendents As Boolean = False
	Friend dsClient As New DataSet

    Friend ProgEditAudio As String = ""

    Enum listCalendar
        Setmana
        Dia
    End Enum


    Friend frm_sice() As Integer = {1022, 575}

#Region "General (dataset)"

    Friend Sub IniDataSet()
        Try
            'TODO: Aquesta funció i la següent som vastant similars, modificar codi per evitar duplicitats
            Dim SqlStr As String = ""
            Dim db As New MSC.dbs(Cloud)
            If db.resultConnection <> connect_State.CONNECT_OK Then
                'TODO: contemplar error de la connexió
            End If
            Dim da As MySqlDataAdapter

            '        style_relationships
            SqlStr = "SELECT `style_relationships_tipfitxer`,`style_relationships_fitxer`,`style_relationships_style`,`estils`.`estil_id`,`estil_nom` FROM `style_relationships`, `estils` where `style_relationships`.`style_relationships_style`=`estils`.`estil_id`;"
            da = db.getAdapter(SqlStr)
            da.Fill(dsClient, "style_relationships")

            '        adv_templates
            SqlStr = "SELECT * FROM `adv_templates`;"
            da = db.getAdapter(SqlStr)
            da.Fill(dsClient, "adv_templates")
            '        listaudio
            SqlStr = "SELECT * FROM `listaudio`;"
            da = db.getAdapter(SqlStr)
            da.Fill(dsClient, "listaudio")

            '        audios_params
            SqlStr = "SELECT * FROM `audios_params`;"
            da = db.getAdapter(SqlStr)
            da.Fill(dsClient, "audios_params")

            '        'botonsurs
            SqlStr = "SELECT * FROM `botonsurs`;"
            da = db.getAdapter(SqlStr)
            da.Fill(dsClient, "botonsurs")
            '        'ListPautes
            SqlStr = "SELECT * FROM `listpautes`;"
            da = db.getAdapter(SqlStr)
            da.Fill(dsClient, "listpautes")
            '        'Listblocs
            SqlStr = "SELECT * FROM `listblocs`;"
            da = db.getAdapter(SqlStr)
            da.Fill(dsClient, "listblocs")
            '        'programes
            SqlStr = "SELECT * FROM `programes`;"
            da = db.getAdapter(SqlStr)
            da.Fill(dsClient, "programes")
            '        'calendari
            SqlStr = "SELECT * FROM `calendari`;"
            da = db.getAdapter(SqlStr)
            da.Fill(dsClient, "calendari")

            '        'estils
            SqlStr = "SELECT * FROM `estils`;"
            da = db.getAdapter(SqlStr)
            da.Fill(dsClient, "estils")
            '        'idiomes
            SqlStr = "SELECT * FROM `idiomes`"
            da = db.getAdapter(SqlStr)
            da.Fill(dsClient, "idiomes")
            'subjectiv
            SqlStr = "SELECT * FROM `subjectiv`;"
            da = db.getAdapter(SqlStr)
            da.Fill(dsClient, "subjectiv")

            'producte
            SqlStr = "SELECT * FROM `producte`;"
            da = db.getAdapter(SqlStr)
            da.Fill(dsClient, "producte")
            'Agents
            SqlStr = "SELECT * FROM `agents`;"
            da = db.getAdapter(SqlStr)
            da.Fill(dsClient, "agents")
            'clients
            SqlStr = "SELECT * FROM `clients`;"
            da = db.getAdapter(SqlStr)
            da.Fill(dsClient, "clients")
            'tarifes
            SqlStr = "SELECT * FROM `tarifes`;"
            da = db.getAdapter(SqlStr)
            da.Fill(dsClient, "tarifes")
            'tecnic
            SqlStr = "SELECT * FROM `tecnic`;"
            da = db.getAdapter(SqlStr)
            da.Fill(dsClient, "tecnic")
            'locutor
            SqlStr = "SELECT * FROM `locutor`;"
            da = db.getAdapter(SqlStr)
            da.Fill(dsClient, "locutor")
            'falques
            SqlStr = "SELECT * FROM `falques`;"
            da = db.getAdapter(SqlStr)
            da.Fill(dsClient, "falques")

            'frangeshoraries
            SqlStr = "SELECT * FROM `frangeshoraries`;"
            da = db.getAdapter(SqlStr)
            da.Fill(dsClient, "frangeshoraries")
            'users
            SqlStr = "SELECT * FROM `users`;"
            da = db.getAdapter(SqlStr)
            da.Fill(dsClient, "users")
            'interprets
            SqlStr = "SELECT * FROM `interprets`;"
            da = db.getAdapter(SqlStr)
            da.Fill(dsClient, "interprets")

            'discos
            SqlStr = "SELECT * FROM `discos`;"
            da = db.getAdapter(SqlStr)
            da.Fill(dsClient, "discos")
            'companyies
            SqlStr = "SELECT * FROM `companyies`;"
            da = db.getAdapter(SqlStr)
            da.Fill(dsClient, "companyies")
            'proveidors
            SqlStr = "SELECT * FROM `proveidors`;"
            da = db.getAdapter(SqlStr)
            da.Fill(dsClient, "proveidors")

            'sequencia_pauta
            SqlStr = "SELECT * FROM `sequencia_pauta`;"
            da = db.getAdapter(SqlStr)
            da.Fill(dsClient, "sequencia_pauta")

            'Prog_Sessions
            SqlStr = "SELECT * FROM `prg_sessions`;"
            da = db.getAdapter(SqlStr)
            da.Fill(dsClient, "prg_sessions")


            'Mix programes + sessions
            'TODO: Error al intentar crear la columna Nom amb una concadenació.        
            SqlStr = "SELECT `prg_sessions`.`ses_id` as col_ID , CONCAT(`programes`.`prg_nom`,' (" & LB_EPISODE & ": ',`prg_sessions`.`ses_id`,', Data:',`prg_sessions`.`ses_datacreacio`,')') as col_Nom " &
            " FROM `programes` AS `programes`, `prg_sessions` AS `prg_sessions`" &
            " WHERE `programes`.`prg_id` = `prg_sessions`.`ses_prg`"

            'SqlStr = "SELECT `programes`.`prgNom`,`prg_sessions`.`ses_DataCreacio` ,`prg_sessions`.`ses_ID` " & _
            '             "FROM `programes` AS `programes`, `prg_sessions` AS `prg_sessions` " & _
            '             "WHERE `programes`.`prgID` = `prg_sessions`.`ses_prg_ID`"
            da = db.getAdapter(SqlStr)

            da.Fill(dsClient, "programes_sessions")

            'Blocs Publicitat
            'da = BlocsPublicitat()
            'da.Fill(dsClient, "blocspubli")

            'user_temes
            SqlStr = "SELECT * FROM `user_temes`;"
            da = db.getAdapter(SqlStr)
            da.Fill(dsClient, "user_temes")

            'user_audio
            SqlStr = "SELECT * FROM `user_audio`;"
            da = db.getAdapter(SqlStr)
            da.Fill(dsClient, "user_audio")

            'list_tags
            SqlStr = "SELECT * FROM `list_tags`;"
            da = db.getAdapter(SqlStr)
            da.Fill(dsClient, "list_tags")

            'tags_relationships
            'SqlStr = "SELECT * FROM `tags_relationships`;"
            SqlStr = "SELECT relation_tipfitxer,fitxer_id,tags_relationships.tag_id,tag_nom FROM tags_relationships, list_tags where tags_relationships.tag_id=list_tags.tag_id"
            da = db.getAdapter(SqlStr)
            da.Fill(dsClient, "tags_relationships")

            'news_categories
            SqlStr = "SELECT * FROM `news_categories`;"
            da = db.getAdapter(SqlStr)
            da.Fill(dsClient, "news_categories")

            da.Dispose()
            db = Nothing
        Catch ex As Exception

            MsgBox(ex.Message)
        End Try

    End Sub

    Friend Sub RefreshDataSet(ByVal IdTaula As TAULES_DBS)
		Dim SqlStr As String = ""
		Dim NomTaula As String = ""
		
		Select Case IdTaula
			Case TAULES_DBS.TAULA_IDIOMES
				SqlStr = "SELECT * FROM `idiomes` ;"
				NomTaula = "idiomes"
			Case TAULES_DBS.TAULA_LIST_AUDIO_USERS
				SqlStr = "SELECT * FROM `listaudio`;"
                NomTaula = "listaudio"

            Case TAULES_DBS.TAULA_AUDIO_USERS
                '        audios_params
                SqlStr = "SELECT * FROM `audios_params`;"
                NomTaula = "audios_params"
            Case TAULES_DBS.TAULA_LIST_BLOCS
				'Listblocs
				SqlStr = "SELECT * FROM `listblocs`;"
				NomTaula = "listblocs"			
			Case TAULES_DBS.TAULA_SEQUENCIES_PAUTA
				'sequencia_pauta
				SqlStr = "SELECT * FROM `sequencia_pauta`;"
				NomTaula = "sequencia_pauta"
			Case TAULES_DBS.TAULA_PAUTES
				'ListPautes
				SqlStr = "SELECT * FROM `listpautes`;"
				NomTaula = "listpautes"
			Case TAULES_DBS.TAULA_USUARIS
				SqlStr = "SELECT * FROM `users`;"
				NomTaula = "users"
			Case TAULES_DBS.TAULA_DISCOS
				SqlStr = "SELECT * FROM `discos`;"
				NomTaula = "discos"
			Case TAULES_DBS.TAULA_INTERPRETS
				SqlStr = "SELECT * FROM `interprets`;"
				NomTaula = "interprets"
			Case TAULES_DBS.TAULA_DISCOGRAFIQUES
				SqlStr = "SELECT * FROM `companyies`;"
				NomTaula = "companyies"
			Case TAULES_DBS.TAULA_CALENDARI
				SqlStr = "SELECT * FROM `calendari`;"
				NomTaula = "calendari"
			Case TAULES_DBS.TAULA_PROGRAMES
				SqlStr = "SELECT * FROM `programes`;"
				NomTaula = "programes"
			Case TAULES_DBS.TAULA_SESSIONS_PROGRAMES
				'Prog_Sessions
				SqlStr = "SELECT * FROM `prg_sessions`;"
				NomTaula = "prg_sessions"
			Case TAULES_DBS.TAULA_MIX_PROGRAMES_SESSIONS
				SqlStr = "SELECT `prg_sessions`.`ses_id` as col_ID , CONCAT(`programes`.`prg_nom`,' (Sessió: ',`prg_sessions`.`ses_id`,', Data:',`prg_sessions`.`ses_datacreacio`,')') as col_Nom " & _
					" FROM `programes` AS `programes`, `prg_sessions` AS `prg_sessions`" & _
					" WHERE `programes`.`prg_id` = `prg_sessions`.`ses_prg`"
				NomTaula = "programes_sessions"
			Case TAULES_DBS.TAULA_CLIENTS
				'clients
				SqlStr = "SELECT * FROM `clients`;"
				NomTaula = "clients"
			Case TAULES_DBS.TAULA_TECNICS
				SqlStr = "SELECT * FROM `tecnic`;"
				NomTaula = "tecnic"
			Case TAULES_DBS.TAULA_LOCUTORS
				SqlStr = "SELECT * FROM `locutor`;"
				NomTaula = "locutor"
			Case TAULES_DBS.TAULA_TARIFES
				SqlStr = "SELECT * FROM `tarifes`;"
				NomTaula = "tarifes"
			Case TAULES_DBS.TAULA_PRODUCTES
				SqlStr = "SELECT * FROM `producte`;"
				NomTaula = "producte"
			Case TAULES_DBS.TAULA_LIST_TAGS
				'user_audio
				SqlStr = "SELECT * FROM `list_tags`;"
				NomTaula = "list_tags"
			Case TAULES_DBS.TAULA_RELATIONSHIPS_TAGS
				'tags_relationships                
				SqlStr = "SELECT relation_tipfitxer,fitxer_id,tags_relationships.tag_id,tag_nom FROM tags_relationships, list_tags where tags_relationships.tag_id=list_tags.tag_id"
				NomTaula = "tags_relationships"
			Case TAULES_DBS.TAULA_USER_AUDIO
				SqlStr = "SELECT * FROM `user_audio`;"
				NomTaula = "user_audio"
			Case TAULES_DBS.TAULA_SUBJECTIV                
				SqlStr = "SELECT * FROM `subjectiv`;"
				NomTaula = "subjectiv"
			Case TAULES_DBS.TAULA_ESTILS
				SqlStr = "SELECT * FROM `estils`;"
				NomTaula = "estils"
			Case TAULES_DBS.TAULA_AGENTS_COMERCIALS
				SqlStr = "SELECT * FROM `agents`;"
				NomTaula = "agents"
			Case TAULES_DBS.TAULA_PUBLICITAT
				SqlStr = "SELECT * FROM `falques`;"
				NomTaula = "falques"
			Case TAULES_DBS.TAULA_PROVEIDORS
				SqlStr = "SELECT * FROM `proveidors`;"
				NomTaula = "proveidors"
			Case TAULES_DBS.TAULA_USER_TEMES
				SqlStr = "SELECT * FROM `user_temes`;"
				NomTaula = "user_temes"
			Case TAULES_DBS.TAULA_CATEGORIA_NEWS
				SqlStr = "SELECT * FROM `news_categories`;"
				NomTaula = "news_categories"
			Case TAULES_DBS.TAULA_ADV_TEMPLATES
				SqlStr = "SELECT * FROM `adv_templates`;"
				NomTaula = "adv_templates"
			Case TAULES_DBS.TAULA_STYLE_RELATIONSHIPS
				SqlStr = "SELECT `style_relationships_tipfitxer`,`style_relationships_fitxer`,`style_relationships_style`,`estils`.`estil_id`,`estil_nom` FROM `style_relationships`, `estils` where `style_relationships`.`style_relationships_style`=`estils`.`estil_id`;"
				NomTaula = "style_relationships"
			Case Else
				Exit Sub
		End Select

        Dim db As New MSC.dbs(Cloud)
        Dim da As New MySqlDataAdapter
		
		dsClient.Tables(NomTaula).Clear()
		Try
			da = db.getAdapter(SqlStr)
			da.Fill(dsClient, NomTaula)
		Catch ex As Exception
			MyAPP.Error_MSC.SalvarExcepcioNoControlada(ex, SqlStr, False)
		Finally
			da.Dispose()
			db = Nothing
		End Try
	End Sub

    Friend Function buscarDependencies(ByVal idTaula As TAULES_DBS, ByVal IDRegistre As Integer, frm As Form) As Boolean
        Dim taulaDescrip As String = ""
        Dim StrSql As String = ""
        Dim db As New MSC.dbs(Cloud)
        Dim Cont As Integer = 0
        Select Case idTaula
            Case TAULES_DBS.TAULA_ESTILS
                'Dependències a la taula Discos i temes
                taulaDescrip = "Discos"
                StrSql = "SELECT COUNT(disc_estil ) FROM discos WHERE disc_estil = " & IDRegistre.ToString
                Cont = CInt(db.ExecuteScalar(StrSql))
                If Cont = 0 Then
                    taulaDescrip = "AudioUser"
                    StrSql = "SELECT COUNT(audio_estil ) FROM audios_params WHERE audio_style = " & IDRegistre.ToString
                    Cont = CInt(db.ExecuteScalar(StrSql))
                End If
                'TODO: error s'ha de comprovar que tampoc hi sigui en un bloc musical			
            Case TAULES_DBS.TAULA_CLIENTS
                'dependències Publicitat
                taulaDescrip = "Publicitat"
                StrSql = "SELECT COUNT(falc_client ) FROM falques WHERE falc_client = " & IDRegistre.ToString
                Cont = CInt(db.ExecuteScalar(StrSql))
            Case TAULES_DBS.TAULA_PAUTES
                'Dependències a Calendari
                taulaDescrip = "Calendari"
                StrSql = "SELECT COUNT(cal_pauta ) FROM calendari WHERE cal_pauta = " & IDRegistre.ToString
                Cont = CInt(db.ExecuteScalar(StrSql))
            Case TAULES_DBS.TAULA_PROVEIDORS
                taulaDescrip = "Discos"
                StrSql = "SELECT COUNT(disc_propietari ) FROM discos WHERE disc_propietari = " & IDRegistre.ToString
                Cont = CInt(db.ExecuteScalar(StrSql))
            Case TAULES_DBS.TAULA_INTERPRETS
                taulaDescrip = "Discos"
                StrSql = "SELECT COUNT(disc_interpret ) FROM discos WHERE disc_interpret = " & IDRegistre.ToString
                Cont = CInt(db.ExecuteScalar(StrSql))
                If Cont = 0 Then
                    taulaDescrip = "Cançons"
                    StrSql = "SELECT COUNT(tema_interp ) FROM temes WHERE tema_interp = " & IDRegistre.ToString
                    Cont = CInt(db.ExecuteScalar(StrSql))
                End If
            Case TAULES_DBS.TAULA_SUBJECTIV
                taulaDescrip = "Cançons"
                StrSql = "SELECT COUNT(tema_subj ) FROM temes WHERE tema_subj = " & IDRegistre.ToString
                Cont = CInt(db.ExecuteScalar(StrSql))
                If Cont = 0 Then
                    taulaDescrip = "AudioUser"
                    StrSql = "SELECT COUNT(audio_estil ) FROM audios_params WHERE audio_style = " & IDRegistre.ToString
                    Cont = CInt(db.ExecuteScalar(StrSql))
                End If
            Case TAULES_DBS.TAULA_DISCOGRAFIQUES
                taulaDescrip = "Discos"
                StrSql = "SELECT COUNT(disc_cia ) FROM discos WHERE disc_cia = " & IDRegistre.ToString
                Cont = CInt(db.ExecuteScalar(StrSql))
            Case TAULES_DBS.TAULA_DISCOS
                taulaDescrip = "Cançons"
                StrSql = "SELECT COUNT(tema_disc ) FROM temes WHERE tema_disc = " & IDRegistre.ToString
                Cont = CInt(db.ExecuteScalar(StrSql))
            Case TAULES_DBS.TAULA_IDIOMES
                taulaDescrip = "Cançons"
                StrSql = "SELECT COUNT(tema_idioma ) FROM temes WHERE tema_idioma = " & IDRegistre.ToString
                Cont = CInt(db.ExecuteScalar(StrSql))
            Case TAULES_DBS.TAULA_PRODUCTES
                taulaDescrip = "Productes"
                StrSql = "SELECT COUNT(falc_producte ) FROM falques WHERE falc_producte = " & IDRegistre.ToString
                Cont = CInt(db.ExecuteScalar(StrSql))
            Case TAULES_DBS.TAULA_TARIFES
                taulaDescrip = "Tarifes"
                StrSql = "SELECT COUNT(falc_tarifa ) FROM falques WHERE falc_tarifa = " & IDRegistre.ToString
                Cont = CInt(db.ExecuteScalar(StrSql))
            Case TAULES_DBS.TAULA_TECNICS
                taulaDescrip = "Tècnics"
                StrSql = "SELECT COUNT(falc_tecnic ) FROM falques WHERE falc_tecnic= " & IDRegistre.ToString
                Cont = CInt(db.ExecuteScalar(StrSql))
            Case TAULES_DBS.TAULA_LOCUTORS
                taulaDescrip = "Locutors"
                StrSql = "SELECT COUNT(falc_locutor ) FROM falques WHERE falc_locutor = " & IDRegistre.ToString
                Cont = CInt(db.ExecuteScalar(StrSql))
            Case TAULES_DBS.TAULA_LIST_TAGS
                taulaDescrip = "Tags"
                StrSql = "SELECT COUNT(tag_id) FROM tags_relationships WHERE tag_id = " & IDRegistre.ToString
                Cont = CInt(db.ExecuteScalar(StrSql))
            Case TAULES_DBS.TAULA_CATEGORIA_NEWS
                taulaDescrip = "news_categories"
                StrSql = "SELECT COUNT(news_id) FROM noticies WHERE news_tipusid = " & IDRegistre.ToString
                Cont = CInt(db.ExecuteScalar(StrSql))
        End Select
        db = Nothing
        If Cont > 0 Then
            MetroFramework.MetroMessageBox.Show(frm, String.Format(MSC_ERROR_DEPENDENCIES, taulaDescrip), MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
            Return True
        Else
            Return False
        End If
    End Function

#End Region

#Region "Botons Usuaris"

    Friend Function getBotonsOptionsFromIDUsr(ByRef piIDUsr As Short) As DataTable
		If piIDUsr = 999 Then piIDUsr = 0
		
		Dim sCmd As String = "botoUsrID = " & piIDUsr
		Return getDataTableFromDataSet("botonsurs", sCmd)
		
	End Function

    Friend Sub UpdateUsrBotonsOptions(ByRef piIDUsr As Short, Buttonval() As Boolean, strColAU As String)

        Dim sCmd As String
        If piIDUsr = 999 Then piIDUsr = 0

        Dim SqlCondi As String = ""
        For i As Integer = 0 To Buttonval.Length - 1
            If i = 0 Then
                SqlCondi = " boto" & (i + 1).ToString & "=" & IIf(Buttonval(i), 1, 0).ToString
            Else
                SqlCondi += ", boto" & (i + 1).ToString & "=" & IIf(Buttonval(i), 1, 0).ToString
            End If
        Next
        sCmd = "UPDATE botonsurs"
        sCmd = sCmd & " SET "
        sCmd = sCmd & SqlCondi
        sCmd = sCmd & strColAU
        sCmd = sCmd & " WHERE botoUsrID = " & piIDUsr & " ;"
        Dim db As New MSC.dbs(Cloud)
        db.Update_ID(sCmd)
        db = Nothing
    End Sub

#End Region

    Function getIDlistAudioUser(nom As String) As Integer
        Dim colec() As DataRow = dsClient.Tables("listaudio").Select("audio_nom='" & nom & "'")
        Try
            Return CInt(colec(0)("audio_id"))
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Function getIDAudioUser(nom As String) As Integer
        Dim colec() As DataRow = dsClient.Tables("audios_params").Select("audio_nom='" & nom & "'")
        Try
            Return CInt(colec(0)("audio_id"))
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Friend Function getLogoAudioUser(id As Integer) As Integer
        Dim colec() As DataRow = dsClient.Tables("listaudio").Select("audio_id=" & id)
        Try
            Return CInt(colec(0)("audio_image"))
        Catch ex As Exception
            Return 2
        End Try
    End Function

    Friend Function getNameAudioUser(id As Integer) As String
        Dim colec() As DataRow = dsClient.Tables("audios_params").Select("audio_id=" & id)
        Try
            Return colec(0)("audio_nom").ToString
        Catch ex As Exception
            Return ""
        End Try
    End Function

#Region "Falques Publicitàries"

    Friend Function getNomLocutor(ByVal LocutorID As Integer) As String
		Dim sCmd As String = "locu_id = " & LocutorID
		Dim colec() As DataRow = dsClient.Tables("locutor").Select(sCmd)
		Try
			Dim ret As String = colec(0)("locu_nom").ToString
			colec = Nothing
			Return ret
		Catch ex As Exception
			Return LIST_NO_DEF
		End Try
	End Function
	
	Friend Function getNomInterpret(ByVal InterpID As Integer) As String
		Dim sCmd As String = "interp_id = " & InterpID
		Dim colec() As DataRow = dsClient.Tables("interprets").Select(sCmd)
		Try
			Dim ret As String = colec(0)("interp_nom").ToString
			colec = Nothing
			Return ret
		Catch ex As Exception
			Return LIST_NO_DEF
		End Try
	End Function
	
	
	
	Friend Function getBackColorFranHorFromDataHora(ByRef DataHoraEsp As Date) As Integer
		Dim Column As String
		Dim StrSql As String
		Dim DiaSem As Short
		
		DiaSem = CShort(Weekday(DataHoraEsp, FirstDayOfWeek.Monday))
		Column = "fran" & DataHoraEsp.ToString("HH") & "h"
		StrSql = "SELECT " & Column & " FROM frangeshoraries WHERE franID = " & DiaSem

        Dim db As New MSC.dbs(Cloud)
        Dim retVal As Integer = CInt(db.ExecuteScalar(StrSql))
		db = Nothing
		Return retVal
		
	End Function
	
	Friend Function getColorFrangeHoraria(ByRef DataHoraEsp As Date)As Color
		Dim DiaSem As Short = CShort(Weekday(DataHoraEsp, FirstDayOfWeek.Monday))
		Dim StrSql As String = "franID = " & DiaSem		
		Dim colec() As DataRow = dsClient.Tables("frangeshoraries").Select(StrSql)
		Dim Column As String = "fran" & DataHoraEsp.ToString("HH") & "h"
		Dim ret As Integer  = CInt(colec(0)(Column).ToString)
		Return CType(Choose(ret+1, Color.Yellow, Color.MistyRose, Color.LightSalmon, Color.Salmon, Color.DarkSalmon, Color.Tomato, Color.LightCoral, Color.Coral, Color.OrangeRed, Color.Red),Color)
	End Function	
	
	Friend Function getImport(ByRef DataEmissio As Date, ByVal Tarifa As Single) As Double
		Dim Increment As Short = CShort(getTantPerCentFranHorFromDataHora(DataEmissio))
		Return Tarifa * (Increment / 100) + Tarifa
	End Function
	
	Friend Function getTantPerCentFranHorFromDataHora(ByRef DataEsp As Date) As Integer
		Dim DiaSem As Short = CShort(Weekday(DataEsp, FirstDayOfWeek.Monday))
		Dim Hora As Short = CShort(Hour(DataEsp))
		Dim ListCols As String = "fran" & Hora.ToString("00") & "h"
		Dim StrSql As String = "SELECT " & ListCols & " FROM frangeshoraries WHERE franID = " & DiaSem
        Dim db As New MSC.dbs(Cloud)
        Dim retVal As Short = CShort(db.ExecuteScalar(StrSql))
		db = Nothing
		Return getTantPerCentFranHorFromID(retVal)
		
	End Function
	
	Friend Function getTantPerCentFranHorFromID(ByRef pi_id As Short) As Integer
		Dim dataTB As DataTable = ListIncremTarifFrangHora()
		Dim row As DataRow
		Dim currentRows() As DataRow = dataTB.Select("frhoID=" & pi_id, Nothing, DataViewRowState.CurrentRows)
		For Each row In currentRows
			Dim List_id As Integer = CInt(row("frhoID"))
			If List_id = pi_id Then
				Dim ret As Integer = CInt(row("frhoIncrement"))
				row = Nothing
				Return ret
			End If
		Next
	End Function
	
	Friend Sub createBlocs(ByRef IDFalca As Short, ByVal IsPropia As Boolean)
        Dim db As New MSC.dbs(Cloud)
        For DiaSetman As Short = 1 To 7
			Dim sCmd As String = "INSERT INTO radiaciofalques" & DiaSetman & " ( radiID, radiOrdre)"
			sCmd = sCmd & " VALUES "
			sCmd = sCmd & " ( " & IDFalca
			sCmd = sCmd & ", " & CShort(IIf(IsPropia, 99, 0))
			sCmd = sCmd & ");"
			db.New_ID(sCmd)
		Next
		db = Nothing
	End Sub
	
	Friend Sub UpdateDades00_04(ByRef DiaSem As Short, ByRef pi_id As Short, ByRef pi0005 As Boolean, ByRef pi0020 As Boolean, ByRef pi0040 As Boolean, ByRef pi0050 As Boolean, ByRef pi0105 As Boolean, ByRef pi0120 As Boolean, ByRef pi0140 As Boolean, ByRef pi0150 As Boolean, ByRef pi0205 As Boolean, ByRef pi0220 As Boolean, ByRef pi0240 As Boolean, ByRef pi0250 As Boolean, ByRef pi0305 As Boolean, ByRef pi0320 As Boolean, ByRef pi0340 As Boolean, ByRef pi0350 As Boolean, ByRef pi0405 As Boolean, ByRef pi0420 As Boolean, ByRef pi0440 As Boolean, ByRef pi0450 As Boolean)
		
		Dim sCmd As String
		
		sCmd = "UPDATE radiaciofalques" & DiaSem
		sCmd = sCmd & " SET "
		sCmd = sCmd & "  radi0005 = " & CShort(IIf(pi0005, 1, 0))
		sCmd = sCmd & ", radi0020 = " & CShort(IIf(pi0020, 1, 0))
		sCmd = sCmd & ", radi0040 = " & CShort(IIf(pi0040, 1, 0))
		sCmd = sCmd & ", radi0050 = " & CShort(IIf(pi0050, 1, 0))
		sCmd = sCmd & ", radi0105 = " & CShort(IIf(pi0105, 1, 0))
		sCmd = sCmd & ", radi0120 = " & CShort(IIf(pi0120, 1, 0))
		sCmd = sCmd & ", radi0140 = " & CShort(IIf(pi0140, 1, 0))
		sCmd = sCmd & ", radi0150 = " & CShort(IIf(pi0150, 1, 0))
		sCmd = sCmd & ", radi0205 = " & CShort(IIf(pi0205, 1, 0))
		sCmd = sCmd & ", radi0220 = " & CShort(IIf(pi0220, 1, 0))
		sCmd = sCmd & ", radi0240 = " & CShort(IIf(pi0240, 1, 0))
		sCmd = sCmd & ", radi0250 = " & CShort(IIf(pi0250, 1, 0))
		sCmd = sCmd & ", radi0305 = " & CShort(IIf(pi0305, 1, 0))
		sCmd = sCmd & ", radi0320 = " & CShort(IIf(pi0320, 1, 0))
		sCmd = sCmd & ", radi0340 = " & CShort(IIf(pi0340, 1, 0))
		sCmd = sCmd & ", radi0350 = " & CShort(IIf(pi0350, 1, 0))
		sCmd = sCmd & ", radi0405 = " & CShort(IIf(pi0405, 1, 0))
		sCmd = sCmd & ", radi0420 = " & CShort(IIf(pi0420, 1, 0))
		sCmd = sCmd & ", radi0440 = " & CShort(IIf(pi0440, 1, 0))
		sCmd = sCmd & ", radi0450 = " & CShort(IIf(pi0450, 1, 0))
		
		sCmd = sCmd & " WHERE radiID = " & pi_id & " ;"

        Dim db As New MSC.dbs(Cloud)
        db.Update_ID(sCmd)
		db = Nothing
	End Sub
	
	Friend Sub UpdateDades05_09(ByRef DiaSem As Short, ByRef pi_id As Short _
		, ByRef pi0505 As Boolean, ByRef pi0520 As Boolean _
		, ByRef pi0540 As Boolean, ByRef pi0550 As Boolean _
		, ByRef pi0605 As Boolean, ByRef pi0620 As Boolean _
		, ByRef pi0640 As Boolean, ByRef pi0650 As Boolean _
		, ByRef pi0705 As Boolean, ByRef pi0720 As Boolean _
		, ByRef pi0740 As Boolean, ByRef pi0750 As Boolean _
		, ByRef pi0805 As Boolean, ByRef pi0820 As Boolean _
		, ByRef pi0840 As Boolean, ByRef pi0850 As Boolean _
		, ByRef pi0905 As Boolean, ByRef pi0920 As Boolean _
		, ByRef pi0940 As Boolean, ByRef pi0950 As Boolean)
		
		Dim sCmd As String
		
		sCmd = "UPDATE radiaciofalques" & DiaSem
		sCmd = sCmd & " SET "
		sCmd = sCmd & " radi0505 = " & CShort(IIf(pi0505, 1, 0))
		sCmd = sCmd & ", radi0505 = " & CShort(IIf(pi0505, 1, 0))
		sCmd = sCmd & ", radi0505 = " & CShort(IIf(pi0505, 1, 0))
		sCmd = sCmd & ", radi0520 = " & CShort(IIf(pi0520, 1, 0))
		sCmd = sCmd & ", radi0540 = " & CShort(IIf(pi0540, 1, 0))
		sCmd = sCmd & ", radi0550 = " & CShort(IIf(pi0550, 1, 0))
		sCmd = sCmd & ", radi0605 = " & CShort(IIf(pi0605, 1, 0))
		sCmd = sCmd & ", radi0620 = " & CShort(IIf(pi0620, 1, 0))
		sCmd = sCmd & ", radi0640 = " & CShort(IIf(pi0640, 1, 0))
		sCmd = sCmd & ", radi0650 = " & CShort(IIf(pi0650, 1, 0))
		sCmd = sCmd & ", radi0705 = " & CShort(IIf(pi0705, 1, 0))
		sCmd = sCmd & ", radi0720 = " & CShort(IIf(pi0720, 1, 0))
		sCmd = sCmd & ", radi0740 = " & CShort(IIf(pi0740, 1, 0))
		sCmd = sCmd & ", radi0750 = " & CShort(IIf(pi0750, 1, 0))
		sCmd = sCmd & ", radi0805 = " & CShort(IIf(pi0805, 1, 0))
		sCmd = sCmd & ", radi0820 = " & CShort(IIf(pi0820, 1, 0))
		sCmd = sCmd & ", radi0840 = " & CShort(IIf(pi0840, 1, 0))
		sCmd = sCmd & ", radi0850 = " & CShort(IIf(pi0850, 1, 0))
		sCmd = sCmd & ", radi0905 = " & CShort(IIf(pi0905, 1, 0))
		sCmd = sCmd & ", radi0920 = " & CShort(IIf(pi0920, 1, 0))
		sCmd = sCmd & ", radi0940 = " & CShort(IIf(pi0940, 1, 0))
		sCmd = sCmd & ", radi0950 = " & CShort(IIf(pi0950, 1, 0))
		
		sCmd = sCmd & " WHERE radiID = " & pi_id & " ;"

        Dim db As New MSC.dbs(Cloud)
        db.Update_ID(sCmd)
		db = Nothing
	End Sub
	
	Friend Sub UpdateDades10_14(ByRef DiaSem As Short, ByRef pi_id As Short, ByRef pi1005 As Boolean, ByRef pi1020 As Boolean, ByRef pi1040 As Boolean, ByRef pi1050 As Boolean, ByRef pi1105 As Boolean, ByRef pi1120 As Boolean, ByRef pi1140 As Boolean, ByRef pi1150 As Boolean, ByRef pi1205 As Boolean, ByRef pi1220 As Boolean, ByRef pi1240 As Boolean, ByRef pi1250 As Boolean, ByRef pi1305 As Boolean, ByRef pi1320 As Boolean, ByRef pi1340 As Boolean, ByRef pi1350 As Boolean, ByRef pi1405 As Boolean, ByRef pi1420 As Boolean, ByRef pi1440 As Boolean, ByRef pi1450 As Boolean)
		
		Dim sCmd As String
		
		sCmd = "UPDATE radiaciofalques" & DiaSem
		sCmd = sCmd & " SET "
		sCmd = sCmd & " radi1005 = " & CShort(IIf(pi1005, 1, 0))
		sCmd = sCmd & ", radi1020 = " & CShort(IIf(pi1020, 1, 0))
		sCmd = sCmd & ", radi1040 = " & CShort(IIf(pi1040, 1, 0))
		sCmd = sCmd & ", radi1050 = " & CShort(IIf(pi1050, 1, 0))
		sCmd = sCmd & ", radi1105 = " & CShort(IIf(pi1105, 1, 0))
		sCmd = sCmd & ", radi1120 = " & CShort(IIf(pi1120, 1, 0))
		sCmd = sCmd & ", radi1140 = " & CShort(IIf(pi1140, 1, 0))
		sCmd = sCmd & ", radi1150 = " & CShort(IIf(pi1150, 1, 0))
		sCmd = sCmd & ", radi1205 = " & CShort(IIf(pi1205, 1, 0))
		sCmd = sCmd & ", radi1220 = " & CShort(IIf(pi1220, 1, 0))
		sCmd = sCmd & ", radi1240 = " & CShort(IIf(pi1240, 1, 0))
		sCmd = sCmd & ", radi1250 = " & CShort(IIf(pi1250, 1, 0))
		sCmd = sCmd & ", radi1305 = " & CShort(IIf(pi1305, 1, 0))
		sCmd = sCmd & ", radi1320 = " & CShort(IIf(pi1320, 1, 0))
		sCmd = sCmd & ", radi1340 = " & CShort(IIf(pi1340, 1, 0))
		sCmd = sCmd & ", radi1350 = " & CShort(IIf(pi1350, 1, 0))
		sCmd = sCmd & ", radi1405 = " & CShort(IIf(pi1405, 1, 0))
		sCmd = sCmd & ", radi1420 = " & CShort(IIf(pi1420, 1, 0))
		sCmd = sCmd & ", radi1440 = " & CShort(IIf(pi1440, 1, 0))
		sCmd = sCmd & ", radi1450 = " & CShort(IIf(pi1450, 1, 0))
		
		sCmd = sCmd & " WHERE radiID = " & pi_id & " ;"

        Dim db As New MSC.dbs(Cloud)
        db.Update_ID(sCmd)
		db = Nothing
	End Sub
	
	Friend Sub UpdateDades15_19(ByRef DiaSem As Short, ByRef pi_id As Short, ByRef pi1505 As Boolean, ByRef pi1520 As Boolean, ByRef pi1540 As Boolean, ByRef pi1550 As Boolean, ByRef pi1605 As Boolean, ByRef pi1620 As Boolean, ByRef pi1640 As Boolean, ByRef pi1650 As Boolean, ByRef pi1705 As Boolean, ByRef pi1720 As Boolean, ByRef pi1740 As Boolean, ByRef pi1750 As Boolean, ByRef pi1805 As Boolean, ByRef pi1820 As Boolean, ByRef pi1840 As Boolean, ByRef pi1850 As Boolean, ByRef pi1905 As Boolean, ByRef pi1920 As Boolean, ByRef pi1940 As Boolean, ByRef pi1950 As Boolean)
		
		Dim sCmd As String
		
		sCmd = "UPDATE radiaciofalques" & DiaSem
		sCmd = sCmd & " SET "
		sCmd = sCmd & " radi1505 = " & CShort(IIf(pi1505, 1, 0))
		sCmd = sCmd & ", radi1520 = " & CShort(IIf(pi1520, 1, 0))
		sCmd = sCmd & ", radi1540 = " & CShort(IIf(pi1540, 1, 0))
		sCmd = sCmd & ", radi1550 = " & CShort(IIf(pi1550, 1, 0))
		sCmd = sCmd & ", radi1605 = " & CShort(IIf(pi1605, 1, 0))
		sCmd = sCmd & ", radi1620 = " & CShort(IIf(pi1620, 1, 0))
		sCmd = sCmd & ", radi1640 = " & CShort(IIf(pi1640, 1, 0))
		sCmd = sCmd & ", radi1650 = " & CShort(IIf(pi1650, 1, 0))
		sCmd = sCmd & ", radi1705 = " & CShort(IIf(pi1705, 1, 0))
		sCmd = sCmd & ", radi1720 = " & CShort(IIf(pi1720, 1, 0))
		sCmd = sCmd & ", radi1740 = " & CShort(IIf(pi1740, 1, 0))
		sCmd = sCmd & ", radi1750 = " & CShort(IIf(pi1750, 1, 0))
		sCmd = sCmd & ", radi1805 = " & CShort(IIf(pi1805, 1, 0))
		sCmd = sCmd & ", radi1820 = " & CShort(IIf(pi1820, 1, 0))
		sCmd = sCmd & ", radi1840 = " & CShort(IIf(pi1840, 1, 0))
		sCmd = sCmd & ", radi1850 = " & CShort(IIf(pi1850, 1, 0))
		sCmd = sCmd & ", radi1905 = " & CShort(IIf(pi1905, 1, 0))
		sCmd = sCmd & ", radi1920 = " & CShort(IIf(pi1920, 1, 0))
		sCmd = sCmd & ", radi1940 = " & CShort(IIf(pi1940, 1, 0))
		sCmd = sCmd & ", radi1950 = " & CShort(IIf(pi1950, 1, 0))
		
		sCmd = sCmd & " WHERE radiID = " & pi_id & " ;"

        Dim db As New MSC.dbs(Cloud)
        db.Update_ID(sCmd)
		db = Nothing
	End Sub
	
	Friend Sub UpdateDades20_23(ByRef DiaSem As Short, ByRef pi_id As Short, ByRef pi2005 As Boolean, ByRef pi2020 As Boolean, ByRef pi2040 As Boolean, ByRef pi2050 As Boolean, ByRef pi2105 As Boolean, ByRef pi2120 As Boolean, ByRef pi2140 As Boolean, ByRef pi2150 As Boolean, ByRef pi2205 As Boolean, ByRef pi2220 As Boolean, ByRef pi2240 As Boolean, ByRef pi2250 As Boolean, ByRef pi2305 As Boolean, ByRef pi2320 As Boolean, ByRef pi2340 As Boolean, ByRef pi2350 As Boolean)
		
		Dim sCmd As String
		
		sCmd = "UPDATE radiaciofalques" & DiaSem
		sCmd = sCmd & " SET "
		sCmd = sCmd & " radi2005 = " & CShort(IIf(pi2005, 1, 0))
		sCmd = sCmd & ", radi2020 = " & CShort(IIf(pi2020, 1, 0))
		sCmd = sCmd & ", radi2040 = " & CShort(IIf(pi2040, 1, 0))
		sCmd = sCmd & ", radi2050 = " & CShort(IIf(pi2050, 1, 0))
		sCmd = sCmd & ", radi2105 = " & CShort(IIf(pi2105, 1, 0))
		sCmd = sCmd & ", radi2120 = " & CShort(IIf(pi2120, 1, 0))
		sCmd = sCmd & ", radi2140 = " & CShort(IIf(pi2140, 1, 0))
		sCmd = sCmd & ", radi2150 = " & CShort(IIf(pi2150, 1, 0))
		sCmd = sCmd & ", radi2205 = " & CShort(IIf(pi2205, 1, 0))
		sCmd = sCmd & ", radi2220 = " & CShort(IIf(pi2220, 1, 0))
		sCmd = sCmd & ", radi2240 = " & CShort(IIf(pi2240, 1, 0))
		sCmd = sCmd & ", radi2250 = " & CShort(IIf(pi2250, 1, 0))
		sCmd = sCmd & ", radi2305 = " & CShort(IIf(pi2305, 1, 0))
		sCmd = sCmd & ", radi2320 = " & CShort(IIf(pi2320, 1, 0))
		sCmd = sCmd & ", radi2340 = " & CShort(IIf(pi2340, 1, 0))
		sCmd = sCmd & ", radi2350 = " & CShort(IIf(pi2350, 1, 0))
		sCmd = sCmd & " WHERE radiID = " & pi_id & " ;"
        Dim db As New MSC.dbs(Cloud)
        db.Update_ID(sCmd)
		db = Nothing
	End Sub
	
	#End Region
		
	Friend Sub OmplircomboBoxProgramSessions(ByRef Cmb As ComboBox, optional Condi As String= "" )
        'Omplir comboBoxProgrames
        Dim SqlStr As String = "SELECT `prg_sessions`.`ses_id` as col_ID , CONCAT(`programes`.`prg_nom`,' (" & LB_EPISODE & ": ',`prg_sessions`.`ses_id`,', Data:',`prg_sessions`.`ses_datacreacio`,')') as col_Nom " &
            " FROM `programes` AS `programes`, `prg_sessions` AS `prg_sessions`" &
            " WHERE `programes`.`prg_id` = `prg_sessions`.`ses_prg`" ' AND ses_sessiomare=0"
        If Condi.Length> 0 Then SqlStr = SqlStr & " AND (prg_nom LIKE '%" & AddSlashes(Condi) & "%' OR ses_datacreacio LIKE '%" & AddSlashes(Condi) & "%') ;"
        Dim db As New MSC.dbs(Cloud)
        Dim dTable As DataTable = db.getTable(SqlStr)
		
		Dim table As DataTable = New DataTable()
		Dim column As DataColumn
		Dim row As DataRow = Nothing
		
		column = New DataColumn()
		column.DataType = System.Type.GetType("System.Int32")
		column.ColumnName = "col_ID"
		table.Columns.Add(column)
		
		column = New DataColumn()
		column.DataType = Type.GetType("System.String")
		column.ColumnName = "col_Nom"
		table.Columns.Add(column)
		For i As Integer = 0 To dTable.Rows.Count - 1
			row = table.NewRow()
			row("col_ID") = dTable.Rows(i)(0)
			Select Case dTable.Rows(i)(1).GetType.FullName
				Case "System.Byte[]"
					row("col_Nom") = System.Text.Encoding.Default.GetString(CType(dTable.Rows(i)(1), Byte()))
				Case "System.String"
					row("col_Nom") = dTable.Rows(i)(1).ToString
			End Select
			table.Rows.Add(row)
		Next
		With Cmb
			.DataSource = table
			.DisplayMember = "col_Nom"
			.ValueMember = "col_ID"
		End With
		If Condi.Length>0 Then
			Cmb.Text = Condi
			Cmb.SelectionStart = Condi.Length			
		End If
				
		dTable.Dispose()
		db = Nothing
		
	End Sub


    Friend Function getImageDisc(disc_str As String) As Image
        Dim db As New MSC.dbs(Cloud)
        Dim StrSql As String = ""
        StrSql = "SELECT disc_id FROM discos WHERE disc_nom = '" & disc_str & "';"
        Dim disc_id As Integer = CInt(db.ExecuteScalar(StrSql))
        StrSql = "SELECT img_image FROM image_discos WHERE img_disc=" & disc_id & " ;"
        Try
            Return GetImageFromByteArray(CType(db.ExecuteScalar(StrSql), Byte()))
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    ' llenguatge
    Friend DESCRIP_FORM_RIPPER As String
    Friend DESCRIP_FORM_PROGRAMES As String
    Friend DESCRIP_FORM_DISCOS As String
    Friend DESCRIP_FORM_TEMES As String
    Friend DESCRIP_FORM_NEWS As String
    Friend DESCRIP_FORM_EXITS As String
    Friend DESCRIP_FORM_INTERPRET As String
    Friend DESCRIP_FORM_ESTIL As String
    Friend DESCRIP_FORM_CLAS_SUBJ As String
    Friend DESCRIP_FORM_DISCOGRAFIQUES As String
    Friend DESCRIP_FORM_IDIOMES As String
    Friend DESCRIP_FORM_CAT_NEWS As String
    Friend DESCRIP_FORM_PROVEIDORS As String
    Friend DESCRIP_FORM_GRAFICS As String
    Friend DESCRIP_FORM_EQUIVAL As String
    Friend DESCRIP_FORM_ESDEVENIMENT As String
    Friend DESCRIP_FORM_TAGS As String
    Friend DESCRIP_FORM_PUBLICITAT As String
    Friend DESCRIP_FORM_CTL_PUBLICITAT As String
    Friend DESCRIP_FORM_CLIENTS As String
    Friend DESCRIP_FORM_PRODUCTES As String
    Friend DESCRIP_FORM_TARIFES As String
    Friend DESCRIP_FORM_LOCUTOR As String
    Friend DESCRIP_FORM_TECNIC As String
    Friend DESCRIP_FORM_COMERCIAL As String
    'Friend DESCRIP_FORM_PLANTILLES  As String 
    Friend DESCRIP_FORM_FRANGES As String
    Friend DESCRIP_FORM_INFORMES As String
    Friend DESCRIP_FORM_BLOCS As String
    Friend DESCRIP_FORM_PAUTES As String
    Friend DESCRIP_FORM_CALENDARI As String
    Friend DESCRIP_FORM_LOGGER As String
    Friend DESCRIP_FORM_PODCAST As String
    Friend DESCRIP_FORM_CTL_RADIA As String
    Friend DESCRIP_FORM_PARAMS As String
    Friend DESCRIP_FORM_BKP_DBS As String
    Friend DESCRIP_FORM_EXPORT_FILES As String
    Friend DESCRIP_FORM_MANT_USERS As String
    Friend DESCRIP_FORM_EDIT_USERS As String
    Friend DESCRIP_FORM_JAMENDO As String

    Friend MSG_ATENCIO As String = "" ' "Atenció"
    Friend MSG_NO_STOP_APP As String = ""
	Friend MSG_SAVE_DADES As String = ""  
	Friend MSG_ERROR_SAVE_DADES As String = ""
	Friend MSG_YES As String 
	Friend MSG_NOT As String 
	
	Friend MSG_SERVER_CLOSE As String = ""
	
	Friend MSG_SYSTEM_STANBY_DIRECTE As String = ""
	Friend MSG_SYSTEM_STANBY_CENTRAL As String = ""
	Friend MSG_CONFIRM_SAVE_DADES As String = ""
	Friend MSG_CONFIRM_DELETE_DADES As String = ""
	Friend MSG_CONFIRM_DELETE_NUM_DADES As String = ""
	Friend MSG_SAVED_DATA As String = ""
	Friend MSG_MORE_INFO As String = ""
	Friend MSG_SELECT_DIR As String 
	Friend MSG_FTP_ERROR_CONNECT As String = ""
	Friend MSG_FTP_CONNECT_OK As String = ""
	Friend MSG_FTP_CONNECTING As String = ""
	Friend MSG_FTP_CONNECT_CLOSE As String = ""
	Friend MSG_NO_ITEM_FOR_CONDITION As String = ""
	Friend LABEL_BUSCAR As String
	Friend LIST_NO_DEF As String 
	Friend LIST_CAP As String
	Friend MSG_ROWS_AFFECTED As String 
	Friend MSG_NOT_DELETE_ID As String 
	Friend MSG_NOT_EDIT_ID As String
	Friend MSG_ID_VARIS_NO_BORRAR As String
	Friend LABEL_REGISTRES As String
	Friend LABEL_AVANCAT As String 
	Friend LABEL_SENZILL As String 
	Friend MSG_ERROR_DELETE_FILE As String
	Friend MSG_OK As String 
	
	Friend NOM_TIPUS_USER_CONVIDAT As String
	Friend NOM_TIPUS_USER_EDITOR As String
	Friend NOM_TIPUS_USER_ADMIN As String
	Friend NOM_TIPUS_USER_DEVELOP As String
	Friend MSG_ALTERNATIVE_DIR As String
	Friend MSG_ERROR_ALTERNATIVE_DIR As String 
	Friend LABEL_DELETE As String 
	Friend MSG_FILE_NO_EXIST As String 
	Friend MSG_ERROR_NOM As String
    Friend MSG_ADVANCED_SERVICE_DISABLED As String = ""
    Friend MSC_ERROR_DEPENDENCIES As String = ""

    Friend MSG_PLEASE_REGISTRY As String
    Friend MSG_UP_TO_DATE As String
    Friend MSG_UPDATE_AVARIABLE As String
    Friend MSG_URGENT_UPDATE As String
    Friend LB_EPISODE As String = ""
    Friend MSG_UPDATE_DATA As String = ""

    Friend Sub setLanguageGlobal()

        MSG_UPDATE_DATA = Lang.getText("MSG_UPDATE_DATA", True) '"Updating data in {0}"
        LB_EPISODE = lang.getText("LB_EPISODI", True) ' "Episodi"
        MSG_ATENCIO = lang.getText("MSG_ATENCIO", True) ' "Atenció"
        MSG_NO_STOP_APP = lang.getText("MSG_NO_STOP_APP", True)
        MSG_SAVE_DADES = lang.getText("MSG_SAVE_DADES", True) '"S'ha modificat dades, voleu salvar-les?"    
        MSG_ERROR_SAVE_DADES = lang.getText("MSG_ERROR_SAVE_DADES", True) ' Error al salvar les dades
        MSG_CONFIRM_SAVE_DADES = lang.getText("MSG_CONFIRM_SAVE_DADES", True) '"Segur que vols salvar les dades?"
        MSG_SERVER_CLOSE = lang.getText("MSG_SERVER_CLOSE", True) '"El servidor ha tancat aquesta pantalla"


        MSG_PLEASE_REGISTRY = lang.getText("MSG_PLEASE_REGISTRY", True)
        MSG_UP_TO_DATE = lang.getText("MSG_UP_TO_DATE", True)
        MSG_UPDATE_AVARIABLE = lang.getText("MSG_UPDATE_AVARIABLE", True)
        MSG_URGENT_UPDATE = lang.getText("MSG_URGENT_UPDATE", True)

        MSG_SYSTEM_STANBY_DIRECTE = lang.getText("MSG_SYSTEM_STANBY_DIRECTE", True)
        MSG_SYSTEM_STANBY_CENTRAL = lang.getText("MSG_SYSTEM_STANBY_CENTRAL", True)

        MSG_ERROR_NOM = lang.getText("MSG_ERROR_NOM", True) '"És obligatori especificar un nom."

        MSG_MORE_INFO = lang.getText("MSG_MORE_INFO", True)
        'TODO: Error, retorna nul
        'MSG_YES = lang.getText("YES",True)
        MSG_YES = lang.getText("OK", True)
        MSG_NOT = lang.getText("NOT", True)

        MSG_OK = lang.getText("OK", True)

        LIST_NO_DEF = lang.getText("LIST_NO_DEF", True) 'NO DEF.	
        LIST_CAP = lang.getText("VALUE_CAP", True) '<CAP>

        MSG_SELECT_DIR = lang.getText("MSG_SELECT_DIR", True) ' "Selecciona un directori"
        MSG_FTP_ERROR_CONNECT = lang.getText("MSG_FTP_ERROR_CONNECT", True) ' "Error al connectar"
        MSG_FTP_CONNECT_OK = lang.getText("MSG_FTP_CONNECT_OK", True) '"Connexió realitzada"
        MSG_FTP_CONNECT_CLOSE = lang.getText("MSG_FTP_CONNECT_CLOSE", True) '"La connexió FTP està tancada"
        MSG_FTP_CONNECTING = lang.getText("MSG_FTP_CONNECTING", True) '""Connectant a {0}""	
        MSG_CONFIRM_DELETE_DADES = lang.getText("MSG_CONFIRM_DELETE_DADES", True) '"Segur que vols borrar permanentment aquest ítem?"
        MSG_CONFIRM_DELETE_NUM_DADES = lang.getText("MSG_CONFIRM_DELETE_NUM_DADES", True) '""Segur que vols borrar permanentment {0} ítems?"
        MSG_SAVED_DATA = lang.getText("MSG_SAVED_DATA", True) ' "Dades salvades"
        MSG_NO_ITEM_FOR_CONDITION = lang.getText("MSG_NO_ITEM_FOR_CONDITION", True) ' ""Cap ítem compleix les condicions requerides""
        LABEL_BUSCAR = lang.getText("LABEL_BUSCAR", True) 'Buscar		
        MSG_ROWS_AFFECTED = lang.getText("MSG_ROWS_AFFECTED", True) '"Operació realitzada, {0} registres afectats"		

        MSG_NOT_DELETE_ID = lang.getText("MSG_NOT_DELETE_ID", True) '"No es pot borrar aquest ítem"
        MSG_NOT_EDIT_ID = lang.getText("MSG_NOT_EDIT_ID", True) '"No es pot modificar aquest ítem"
        MSG_ID_VARIS_NO_BORRAR = lang.getText("MSG_ID_VARIS_NO_BORRAR", True) '"Aquest ID ( VARIS) és un comodí, no es pot borrar."
        LABEL_REGISTRES = lang.getText("LABEL_REGISTRES", True) ' Registres
        LABEL_AVANCAT = lang.getText("LABEL_AVANCAT", True) '"Avançats>>"
        LABEL_SENZILL = lang.getText("LABEL_SENZILL", True) '"<<Senzill"
        MSG_ERROR_DELETE_FILE = lang.getText("MSG_ERROR_DELETE_FILE", True) ' "Error al intentar borrar el fitxer : {0}"

        NOM_TIPUS_USER_CONVIDAT = lang.getText("NOM_TIPUS_USER_CONVIDAT", True) '"Convidat"
        NOM_TIPUS_USER_EDITOR = lang.getText("NOM_TIPUS_USER_EDITOR", True) '"Editor"
        NOM_TIPUS_USER_ADMIN = lang.getText("NOM_TIPUS_USER_ADMIN", True) '"Administrador"
        NOM_TIPUS_USER_DEVELOP = lang.getText("NOM_TIPUS_USER_DEVELOP", True) '"Programador"

        MSG_ALTERNATIVE_DIR = lang.getText("MSG_ALTERNATIVE_DIR", True) '"Directori alternatiu"
        MSG_ERROR_ALTERNATIVE_DIR = lang.getText("MSG_ERROR_ALTERNATIVE_DIR", True) '"No teniu accés als fitxers compartits, no es pot importar"
        MSG_FILE_NO_EXIST = lang.getText("MSG_FILE_NO_EXIST", True) '"El fitxer no existeix"
        LABEL_DELETE = lang.getText("LABEL_DELETE", True)

        MSG_ADVANCED_SERVICE_DISABLED = lang.getText("MSG_ADVANCED_SERVICE_DISABLED", True) ' "Advanced service disabled"
        MSC_ERROR_DEPENDENCIES = lang.getText("MSC_ERROR_DEPENDENCIES", True) '"No es pot borrar, hi han creades dependències, a {0}."        

        mdlFrontEnd.setLanguage()

    End Sub

    Friend Function resizeImage(MyImage As Image, size As Integer) As Image
        Return New Bitmap(MyImage, New Size(size, size))
    End Function
End Module

