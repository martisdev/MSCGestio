Option Strict Off
Option Explicit On
Imports System.Threading

Public Class frmPrgLogger
	Dim blEnable As Boolean = True
	Dim mblnNewDates As Boolean
	
	Dim ShowCalendar As listCalendar = listCalendar.Setmana
	
	Dim UnitatMin As Double
	Dim UnitatDies As Integer
	Dim PuntIniXDies(7) As Integer
	Dim MargeItems As Integer = 2
	
	Dim DefAtvRec As Boolean
	Dim DefBitrate As String
	Dim DefSample As String
	Dim DefChannels As Integer
	Dim DefDurada As Date
	
	
	Private Sub cmdSortir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSortir.Click
		Me.Close()
	End Sub
	
	Private Sub EstablirOpcionsPautaReEmissio()
		If Me.optDataHoraReEmissor.Checked = True Then
			Me.txtDataReemissor.Enabled = True
			Me.txtHoraRemissio.Enabled = True
			Me.ComboDiaSetmanaReEmissor.Enabled = False
		ElseIf Me.optSetmHoraReEmissor.Checked = True Then
			Me.txtDataReemissor.Enabled = False
			Me.txtHoraRemissio.Enabled = True
			Me.ComboDiaSetmanaReEmissor.Enabled = True
		End If
	End Sub
	
	Private Sub frmLogger_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		MyAPP.CloseSesionClient(MyAPP.IDSesion_Client, DESCRIP_FORM_LOGGER)
		Me.Dispose()
	End Sub
	
	Private Sub frmLogger_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		
		setLanguageForm()


        Me.cmdNou.Visible = IIf(Usuari.UsrTipus > NivellUsers.USR_CONVIDAT, True, False)
		Me.mnuNew.Visible = Me.cmdNou.Visible
		Me.cmdBloqueix.Enabled = IIf(Usuari.UsrTipus > NivellUsers.USR_CONVIDAT, True, False)
		Me.mnuModif.Enabled = Me.cmdBloqueix.Enabled

        PictureBoxCalendar.Image = Me.ImageListCalendar.Images(2)
        ShowCalendar = listCalendar.Setmana


        DateTimePickerCalendar.Value = Now
        Me.ClientSize = New Size(frm_sice(0), frm_sice(1))
        LoadDefValues()
        LockedRecord(True)
        'BuscaHoresFromID(Now)
        PintaHores()

    End Sub
	
	Dim MSG_ASSIGN_PROGRAMA As String 
	Dim MSG_SAVE_PROGRAMA As String 
	Dim MSG_ASSIGN_REMISSIO As String 
	'Dim MSG_DEL_PROGRAMACIO_CADUC As String 
	'Dim MSG_DEL_PROGRAMACIO As String 
	Dim LABEL_GOTO_AVUI As String 
	Dim LABEL_GOTO_DIA_ABANS As String
	Dim LABEL_GOTO_DIA_DESPRES As String
	Dim LABEL_GOTO_SETMANA_ABANS As String
	Dim LABEL_GOTO_SETMANA_DESPRES As String	
	Dim ME_TEXT As String 
	Dim LABEL_DIA_SETMANA_HORA As String 
	
	Public Sub setLanguageForm()
		lang.StrForm = Me.Name

        MSG_ASSIGN_PROGRAMA = lang.getText("MSG_ASSIGN_PROGRAMA")'"S'ha d'assignar un programa"
		MSG_SAVE_PROGRAMA = lang.getText("MSG_SAVE_PROGRAMA")'"S'ha de salvar el programa per poder fer la remissió"
		MSG_ASSIGN_REMISSIO =  lang.getText("MSG_ASSIGN_REMISSIO")'"S'ha d'assignar un dia de remissió"
		'MSG_DEL_PROGRAMACIO_CADUC = lang.getText("MSG_DEL_PROGRAMACIO_CADUC")'"Segur que vols borrar la programació caducada?"
		'MSG_DEL_PROGRAMACIO = 	lang.getText("MSG_DEL_PROGRAMACIO")'"Segur que vols borrar tota la programació?"
		
		LABEL_GOTO_AVUI = lang.getText("LABEL_GOTO_AVUI",True)'"Vés a avui"		
		LABEL_GOTO_DIA_ABANS = lang.getText("LABEL_UN_DIA_ABANS",True)'"Un dia abans"
		LABEL_GOTO_DIA_DESPRES = lang.getText("LABEL_UN_DIA_DESPRES",True)'"Un dia després"
		LABEL_GOTO_SETMANA_ABANS = lang.getText("LABEL_UNA_SETMANA_ABANS",True)'"Una setmana abans"
		LABEL_GOTO_SETMANA_DESPRES = lang.getText("LABEL_UNA_SETMANA_DESPRES",True)'"Una setmana després"
		ToolTip1.SetToolTip(cmdAnt, LABEL_GOTO_SETMANA_ABANS)
		ToolTip1.SetToolTip(cmdActual, LABEL_GOTO_AVUI)
		ToolTip1.SetToolTip(cmdPost, LABEL_GOTO_SETMANA_DESPRES)
		
		LABEL_DIA_SETMANA_HORA = lang.getText("ASSIGN_CALENDAR_DIA_SETMANA", True)'"Dia Setmana/Hora"
		
		
		'TODO:	
		'Me.ToolStrip1.Text = "ToolStrip1"
		Me.cmdExitTool.ToolTipText = lang.getText("LABEL_TANCAR_PANTALLA",True) '"Tancar pantalla"
		Me.cmdNou.Text = lang.getText("cmdNou.Text") '"Nou ítem"
		Me.cmdBloqueix.Text = lang.getText("LABEL_EDIT_ITEM",True) '"Editar ítem"
		
		
		Me.cmdDel.Text = lang.getText("cmdDel.Text") '"Borrar ítem"
		Me.cmdDel.ToolTipText = lang.getText("LABEL_DEL_ITEM",True) '"Borrar ítem"
		Me.cmdSalvar.Text = lang.getText("LABEL_SALVAR_ITEM",True) '"Salvar ítem"
		
		'Me.MenuStrip1.Text = "MenuStrip1"
		Me.ldNou.Text = lang.getText("LABEL_NEW_UPPER",True)'"NOU"
		Me.ProgarmaToolStripMenuItem.Text = lang.getText("LABEL_PROGRAMA",True) '"Programa"
		Me.mnuExit.Text = lang.getText("LABEL_EXIT",True) '"Sortir"
		Me.EdicióToolStripMenuItem.Text = lang.getText("mnuEdit.Text",True )'"Edició"
		Me.mnuModif.Text = lang.getText("LABEL_MODIFICAR",True )'"Modificar"
		Me.mnuSave.Text = lang.getText("LABEL_SALVAR",True) '"Salvar"
		Me.mnuNew.Text = lang.getText("LABEL_NEW",True) '"Nou"
		Me.mnuDel.Text = lang.getText("LABEL_DELETE",True) '"Borrar"
		Me.ToolStripMenuItem1.Text = lang.getText("mnu_Help",True) '"Ajuda"
		Me.mnu_Help.Text = lang.getText("mnuRefHelp.Text",True) '"Manual OnLine"	
		Me.GroupPRG.Text = lang.getText("LABEL_PROGRAMA",True)'"Programa"
		Me.Label12.Text = lang.getText("LABEL_NOM",True)'"Nom"
		'Me.lbDts.Text = "Label5"
		'Me.lbDres.Text = "Label8"
		'Me.lbDj.Text = "Label9"
		'Me.lbDv.Text = "Label10"
		'Me.lbDs.Text = "Label11"
		'Me.lbDg.Text = "Label12"
		Me.GroupBoxInfoCalendar.Text = lang.getText("LABEL_LLEGENDA_CALENDARI",True)'"Llegenda del calendari"
		Me.lbNomDirecte.Text = lang.getText("lbNomDirecte.Text")'"Enregistrament programat per una data"
		Me.lbNomCentral.Text = lang.getText("lbNomCentral.Text")'"Enregistrament programat per un dia de la setmana"		
		Me.cmdActual.Text = lang.getText("LABEL_AVUI",True)'"Avui"
		Me.lbFet.Text = lang.getText("MSG_BKP_FET",True)'"Còpia realitzada"
		Me.Label8.Text = lang.getText("HEADERTEXT_DURADA",True) '"Durada"
		
		Me.optSetmHora.Text = lang.getText("LABEL_DIES_SETMANA_DLL_DT",True)'"Dies de la setmana (Dll, Dt,Dc,..)"
		Me.optDataHora.Text = lang.getText("LABEL_PER_DATA_CONCRET",True)'"Per una data en concret"
		Me.Label3.Text = lang.getText("LABEL_HORA_INICI",True)'"Hora inici"
		Me.chkPodcasting.Text = lang.getText("LABEL_PUBLICAR_WEB",True)'"Publicar al web"		
		
		Me.Label14.Text = lang.getText("Label14.Text")'"Dia (el següent)"
		Me.Label15.Text = lang.getText("HEADERTEXT_HORA",True)'"Hora"
		Me.Label60.Text = lang.getText("HEADERTEXT_DATA",True)'"Data"
		Me.Label16.Text = lang.getText("HEADERTEXT_DATA",True)'"Data"
		Me.optSetmHoraReEmissor.Text = lang.getText("ASSIGN_CALENDAR_DIA_SETMANA",True)'"Dia Setmana/Hora"
		Me.optDataHoraReEmissor.Text = lang.getText("optDataHoraReEmissor.Text")'"Data/Hora"
		Me.GroupEmissio.Text = lang.getText("LABEL_REMISSIO",True)'"Remissió"
		Me.chkReEmissio.Text = GroupEmissio.Text'"Remissió"
		Me.chksaveAsPrg.Text = lang.getText("chksaveAsPrg.Text")'"Salvar com a nova sessió d'un programa"
		Me.GroupQualitat.Text = lang.getText("LABEL_QUALITAT",True)'"Qualitat"
		Me.Label9.Text = lang.getText("LABEL_CANALS_AUDIO",True)'"Canals d'audio"
		Me.Label10.Text = lang.getText("LABEL_FREQUENCIA_HZ",True)'"Freqüència (Hz)"
		Me.Label11.Text = lang.getText("LABEL_BITRATE",True)'"Bitrate (Kbps)"
		Me.Text = lang.getText("Text")'"Programació de la còpia testimoni (Logger)"
		ME_TEXT = lang.getText("Text")
		
		'todo:
		Me.cmdDelMassive.Text = "Eliminació massiva del Calendari" 'lang.getText("cmdDelCaduc.Text") '"Borrar els ítems de dates caducades"
        'Me.cmdDelAll.Text = lang.getText("cmdDelAll.Text") '"Borrar tots els ítems"

        Dim cmb As New combo
        cmb.OmpleCombo(Me.ComboBoxSelectQualitatRec, TAULES_DBS.TAULA_MP3_QUALITY, TotsCap.NO_ADD)
        cmb.OmpleCombo(ComboDiaSetmanaReEmissor, TAULES_DBS.TAULA_DIES_SETMANA, TotsCap.CAP) : ComboDiaSetmanaReEmissor.SelectedValue = 0
        cmb.OmpleCombo(Me.ComboBoxProgrames, TAULES_DBS.TAULA_PROGRAMES, TotsCap.CAP) : ComboBoxProgrames.SelectedValue = 0
        ComboBoxSelectQualitatRec.SelectedValue = 0
        cmb = Nothing
    End Sub
	
	Private Sub LoadDefValues()

        Dim db As New MSC.dbs(Cloud)
        Dim SqlStr As String = "SELECT log_defrec,log_bitrate, log_samplerate, log_canals, log_durada FROM prglogger WHERE log_id=1"
		Dim rsLogDef As DataTable = db.getTable(SqlStr)
		
		DefAtvRec = CBool(rsLogDef.Rows(0)("log_defrec"))
		DefBitrate = rsLogDef.Rows(0)("log_bitrate").ToString
		DefSample = rsLogDef.Rows(0)("log_samplerate").ToString
		DefChannels = CInt(rsLogDef.Rows(0)("log_canals"))
		DefDurada = CDate(rsLogDef.Rows(0)("log_durada").ToString)
		rsLogDef.Dispose()
		db = Nothing
		
	End Sub
	
	Private Sub chksaveAsPrg_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chksaveAsPrg.CheckedChanged
		GroupPRG.Enabled = IIf(chksaveAsPrg.Enabled, chksaveAsPrg.Checked, False)
	End Sub
	
	Private Sub chkReEmissio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkReEmissio.CheckedChanged
		GroupEmissio.Enabled = chkReEmissio.Checked
	End Sub
	
	Private Sub optDataHoraReEmissor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optDataHoraReEmissor.CheckedChanged, optSetmHoraReEmissor.CausesValidationChanged
		EstablirOpcionsPautaReEmissio()
	End Sub
	
	Private Sub cmdExitTool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExitTool.Click
		Me.Close()
	End Sub
	
	Private Sub cmdBloqueix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBloqueix.Click
		LockedRecord()
	End Sub
	
	Private Sub LockedRecord(Optional ByVal saved As Boolean = False)
		If Me.cmdSalvar.Enabled = True And saved = False Then
            If MetroFramework.MetroMessageBox.Show(Me, MSG_SAVE_DADES, MSG_ATENCIO, MessageBoxButtons.YesNo, MessageBoxIcon.Question, 100) = DialogResult.Yes Then SaveRecord()
        End If
		blEnable = Not blEnable
		mblnNewDates = False
		txtDataOut.Visible = False
		Me.cmdDel.Enabled = blEnable		
		Me.cmdDelMassive.Enabled = blEnable
		Me.ldNou.Visible = False
		'PanelSelectHores.Enabled = True
		GroupAssigTemp.Enabled = blEnable
		GroupQualitat.Enabled = blEnable
		chksaveAsPrg.Enabled = blEnable
		GroupPRG.Enabled = IIf(blEnable = True, chksaveAsPrg.Checked, False)
		chkPodcasting.Enabled = blEnable
		
		'MonthCalendar1.MaxSelectionCount = 1
		
		If blEnable Then
			Me.cmdBloqueix.Image = Me.picUnLock.Image
		Else
			Me.cmdBloqueix.Image = Me.picLock.Image
			Me.cmdSalvar.Enabled = False            
		End If
	End Sub
	
	Private Sub cmdNou_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNou.Click
		NewRecord()
	End Sub
	
	Private Sub NewRecord()
		NetejaPantalla()
		blEnable = False
		LockedRecord()
		mblnNewDates = True
		txtDataOut.Visible = True
		Me.ldNou.Visible = True
		Me.ComboBoxSelectQualitatRec.SelectedIndex = 1
		ComboBoxQualitatRec(1)
		'PanelSelectHores.Enabled = False
		lbFet.Visible = False
	End Sub
	
	Private Sub NetejaPantalla()
		'Valors per defecte
		Me.chksaveAsPrg.Checked = False
		Me.optSetmHora.Checked = True
		Me.txtHoraIni.Value = "01/01/1970 00:00:00"
		Me.ComboBoxProgrames.SelectedValue = 0
		Me.chkReEmissio.Checked = False
		Me.optSetmHoraReEmissor.Checked = True
		Me.chkPodcasting.Checked = False
		Me.lbID.Text = 0
	End Sub
	
	Private Sub SaveRecord()
        If Not MyAPP.PermisPerContinuar() Then MetroFramework.MetroMessageBox.Show(Me, MSG_SERVER_CLOSE, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Stop, 100) : Me.Close()
        If MetroFramework.MetroMessageBox.Show(Me, MSG_CONFIRM_SAVE_DADES, MSG_ATENCIO, MessageBoxButtons.YesNo, MessageBoxIcon.Question, 100) = DialogResult.No Then Exit Sub

        Dim SavePRG As Boolean = Me.chksaveAsPrg.Checked
		Dim blRE As Boolean = Me.chkReEmissio.Checked
		
		Dim gBitRate As String = ComboBitRate.Text
		Dim SampleRate As String = ComboSampleRate.Text
		Dim CanalsAudio As Short = Me.ComboCanalsAudio.SelectedIndex +1 ' 1=MONO 2= STEREO
		Dim TipAssig As Short = IIf(optDataHora.Checked, Tipus_AssigDataCalendari.PROGRAM_DATA_HORA, Tipus_AssigDataCalendari.PROGRAM_DIA_SETMANA_HORA)
		Dim DateReg As Date = New Date(txtDataIn.Value.Year, txtDataIn.Value.Month, txtDataIn.Value.Day, txtHoraIni.Value.Hour, txtHoraIni.Value.Minute, txtHoraIni.Value.Second)
		'TODO: si estic programant un interval de dates només té sentit programar DiaSetman/Hora i la variable "REDateReg" no pot ser més petita que l'interval inicial.
		Dim REDateReg As Date = New Date(txtDataReemissor.Value.Year, txtDataReemissor.Value.Month, txtDataReemissor.Value.Day, txtHoraRemissio.Value.Hour, txtHoraRemissio.Value.Minute, txtHoraRemissio.Value.Second)
		Dim Durada As Date = Me.txtDurada.Text
		Dim DefRec As Boolean = True
		Dim PRG_ID As Integer = Me.ComboBoxProgrames.SelectedValue
		
		Dim RETipAssig As Short = IIf(optDataHoraReEmissor.Checked, Tipus_AssigDataCalendari.PROGRAM_DATA_HORA, Tipus_AssigDataCalendari.PROGRAM_DIA_SETMANA_HORA)

        If Me.ComboBoxProgrames.SelectedValue = 0 And SavePRG = True Then
            MetroFramework.MetroMessageBox.Show(Me, MSG_ASSIGN_PROGRAMA, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
            Me.ComboBoxProgrames.Focus()
            Exit Sub
        ElseIf blRE = True And SavePRG = False Then
            MetroFramework.MetroMessageBox.Show(Me, MSG_SAVE_PROGRAMA, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
            Me.ComboBoxProgrames.Focus()
            Exit Sub
        ElseIf Me.ComboDiaSetmanaReEmissor.SelectedValue = 0 And blRE = True And optSetmHoraReEmissor.Checked = True Then
            MetroFramework.MetroMessageBox.Show(Me, MSG_ASSIGN_REMISSIO, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
            Me.ComboDiaSetmanaReEmissor.Focus()
			Exit Sub
		End If
		
		If TipAssig = Tipus_AssigDataCalendari.PROGRAM_DIA_SETMANA_HORA Then
			Dim DiaSetm As Short = Weekday(txtDataIn.Value, FirstDayOfWeek.Monday)
		End If
		
		If RETipAssig = Tipus_AssigDataCalendari.PROGRAM_DIA_SETMANA_HORA And blRE = True Then
			Dim REDiaSetm As Short = Me.ComboDiaSetmanaReEmissor.SelectedIndex + 1
			Do While REDiaSetm <> Weekday(REDateReg, FirstDayOfWeek.Monday)
				'Només pot anar endavant 
				REDateReg = REDateReg.AddDays(1)
			Loop
		End If
		Dim publiWeb As Boolean = Me.chkPodcasting.Checked
        Dim db As New MSC.dbs(Cloud)
        Dim StrSql As String
		ProgressBar.Maximum = DateDiff(DateInterval.Day, txtDataIn.Value, txtDataOut.Value)
		ProgressBar.Value = 0
		ProgressBar.Visible = True
		
		If mblnNewDates Then
			Dim NewID As Integer = 0
			'fer Bucle ....
			StrSql = "INSERT INTO prglogger (log_bitrate, log_samplerate, log_canals"
			StrSql = StrSql & ", log_saveprg, log_tipassig, log_datereg"
			StrSql = StrSql & ", log_durada, log_defrec, log_program, log_re"
			StrSql = StrSql & ", log_retipassig, log_redata, log_publiweb)"
			StrSql = StrSql & " VALUES "
			
			Dim strValues As String = " ( '" & gBitRate & "'"
			strValues = strValues & ", '" & SampleRate & "'"
			strValues = strValues & ", " & CanalsAudio
			strValues = strValues & ", " & CShort(IIf(SavePRG, 1, 0))
			strValues = strValues & ", " & TipAssig
			strValues = strValues & ", '" & DateReg.ToString("yyyy-MM-dd HH:mm:ss") & "'"
			strValues = strValues & ", '" & Durada.ToString("HH:mm:ss") & "'"
			strValues = strValues & ", " & CShort(IIf(DefRec, 1, 0))
			strValues = strValues & ", " & PRG_ID
			strValues = strValues & ", " & CShort(IIf(blRE, 1, 0))
			strValues = strValues & ", " & RETipAssig
			strValues = strValues & ", '" & REDateReg.ToString("yyyy-MM-dd HH:mm:ss") & "'"
			strValues = strValues & ", " & CShort(IIf(publiWeb, 1, 0))
			strValues = strValues & ")"
			
			My.Application.DoEvents()
			NewID = db.New_ID(StrSql & strValues & " ;")
			Thread.Sleep(50)
			If TipAssig = Tipus_AssigDataCalendari.PROGRAM_DIA_SETMANA_HORA Then
				DateReg = DateReg.AddDays(7)
				REDateReg = REDateReg.AddDays(7)
				Dim DateEnd As Date = New Date(txtDataOut.Value.Year, txtDataOut.Value.Month, txtDataOut.Value.Day, 23, 59, 59)
				Do While DateReg < DateEnd
					'If strValues.Length > 0 Then strValues = strValues & ","
					strValues = " ( '" & gBitRate & "'"
					strValues = strValues & ", '" & SampleRate & "'"
					strValues = strValues & ", " & CanalsAudio
					strValues = strValues & ", " & CShort(IIf(SavePRG, 1, 0))
					strValues = strValues & ", " & TipAssig
					strValues = strValues & ", '" & DateReg.ToString("yyyy-MM-dd HH:mm:ss") & "'"
					strValues = strValues & ", '" & Durada.ToString("HH:mm:ss") & "'"
					strValues = strValues & ", " & CShort(IIf(DefRec, 1, 0))
					strValues = strValues & ", " & PRG_ID
					strValues = strValues & ", " & CShort(IIf(blRE, 1, 0))
					strValues = strValues & ", " & RETipAssig
					strValues = strValues & ", '" & REDateReg.ToString("yyyy-MM-dd HH:mm:ss") & "'"
					strValues = strValues & ", " & CShort(IIf(publiWeb, 1, 0))
					strValues = strValues & ")"
					DateReg = DateReg.AddDays(7)
					REDateReg = REDateReg.AddDays(7)
					
					ProgressBar.Value = ProgressBar.Value + 7
					My.Application.DoEvents()
					Thread.Sleep(50)
					NewID = db.New_ID(StrSql & strValues & " ;")
					strValues = ""
				Loop
			End If
			Me.lbID.Text = NewID.ToString
		Else
			Dim ID As Integer = Me.lbID.Text
			
			StrSql = "UPDATE prglogger"
			StrSql = StrSql & " SET "
			StrSql = StrSql & " log_bitrate = '" & gBitRate & "'"
			StrSql = StrSql & ", log_samplerate = '" & SampleRate & "'"
			StrSql = StrSql & ", log_canals = " & CanalsAudio
			StrSql = StrSql & ", log_saveprg = " & CShort(IIf(SavePRG, 1, 0))
			StrSql = StrSql & ", log_tipassig = " & TipAssig
			StrSql = StrSql & ", log_datereg = '" & DateReg.ToString("yyyy-MM-dd HH:mm:ss") & "'"
			StrSql = StrSql & ", log_durada = '" & Durada.ToString("HH:mm:ss") & "'"
			StrSql = StrSql & ", log_defrec = " & CShort(IIf(DefRec, 1, 0))
			StrSql = StrSql & ", log_program = " & PRG_ID
			StrSql = StrSql & ", log_re = " & CShort(IIf(blRE, 1, 0))
			StrSql = StrSql & ", log_retipassig = " & RETipAssig
			StrSql = StrSql & ", log_redata = '" & REDateReg.ToString("yyyy-MM-dd HH:mm:ss") & "'"
			StrSql = StrSql & ", log_publiweb = " & CShort(IIf(publiWeb, 1, 0))
			
			StrSql = StrSql & " WHERE log_id = " & ID & " ;"
			
			db.Update_ID(StrSql)
			Thread.Sleep(50)
			
		End If
		db = Nothing
		ProgressBar.Visible = False
		LockedRecord(True)
		BuscaItemsCalendari()
	End Sub
	
	
	Private Sub cmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDel.Click
		DeleteRecord()
	End Sub

    Private Sub DeleteRecord()
        If MetroFramework.MetroMessageBox.Show(Me, MSG_CONFIRM_DELETE_DADES, MSG_ATENCIO, MessageBoxButtons.YesNo, MessageBoxIcon.Question, 100) = DialogResult.No Then Exit Sub

        Dim StrSql As String
        StrSql = "DELETE FROM prglogger WHERE log_id = " & Me.lbID.Text & " ;"
        Dim db As New MSC.dbs(Cloud)
        db.Delete_ID(StrSql)
        addCtlRadi(0, CShort(Tipus_Play.CTL_SQL), 0, "00:00:00", 0, 0, Usuari.UsrID, StrSql, 0, False)
        db = Nothing
        NetejaPantalla()
        BuscaItemsCalendari()
    End Sub

    Private Sub Changed()
		If blEnable = True Then Me.cmdSalvar.Enabled = True
	End Sub
	
	Private Sub comboHores_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
		ComboBitRate.SelectedIndexChanged, _
		ComboSampleRate.SelectedIndexChanged, _
		ComboCanalsAudio.SelectedIndexChanged, _
		chksaveAsPrg.CheckedChanged, _
		chkReEmissio.CheckedChanged, _
		optDataHora.CheckedChanged, _
		optDataHoraReEmissor.CheckedChanged, _
		txtDataReemissor.ValueChanged, _
		txtHoraRemissio.ValueChanged, _
		ComboDiaSetmanaReEmissor.SelectedIndexChanged, _
		chkPodcasting.CheckedChanged, _
		txtHoraIni.ValueChanged, txtDurada.ValueChanged
		Changed()
	End Sub
	
	Private Sub cmdSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalvar.Click
		SaveRecord()
	End Sub
	
	Private Sub ComboBoxSelectQualitatRec_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxSelectQualitatRec.SelectedIndexChanged
		ComboBoxQualitatRec(ComboBoxSelectQualitatRec.SelectedIndex)
	End Sub
	
	Private Sub ComboBoxQualitatRec(ByVal Index As Integer)
		Select Case Index
			Case 0
				ComboBitRate.Text = DefBitrate
				ComboSampleRate.Text = DefSample
				Me.ComboCanalsAudio.SelectedIndex = DefChannels
				Me.txtDurada.Value = New Date(1970, 1, 1, DefDurada.Hour, DefDurada.Minute, DefDurada.Second, DateTimeKind.Local)
			Case 1
				ComboBitRate.Text = "192"
				ComboSampleRate.Text = "44100"
				Me.ComboCanalsAudio.SelectedIndex = 1
				txtDurada.Value = CDate("01/01/1970 1:00:00")
			Case 2
				ComboBitRate.Text = "64"
				ComboSampleRate.Text = "22050"
				Me.ComboCanalsAudio.SelectedIndex = 0
				Me.txtDurada.Value = New Date(1970, 1, 1, DefDurada.Hour, DefDurada.Minute, DefDurada.Second, DateTimeKind.Local)
			Case Else
				ComboBitRate.Text = DefBitrate
				ComboSampleRate.Text = DefSample
				Me.ComboCanalsAudio.SelectedIndex = DefChannels
				Me.txtDurada.Value = New Date(1970, 1, 1, DefDurada.Hour, DefDurada.Minute, DefDurada.Second, DateTimeKind.Local)
		End Select
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
	
	Private Sub ComboBoxProgrames_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBoxProgrames.KeyUp
		Select Case e.KeyCode
			Case Keys.Left, Keys.Right, Keys.Up, Keys.Down
				Return
		End Select
		refreshComboBoxKeyUp(ComboBoxProgrames, TAULES_DBS.TAULA_PROGRAMES, TotsCap.CAP)
	End Sub
	
	Private Sub PintaDies()
		If ShowCalendar = listCalendar.Setmana Then
			Dim Monday As Date = DateTimePickerCalendar.Value.AddDays(-Weekday(DateTimePickerCalendar.Value, FirstDayOfWeek.Monday) + 1)
			For i As Integer = 0 To 6
				Try
					Dim labelDia As Label = CType(pnlDies.Controls(i), Label)
					
					Dim x As Integer = ((pnlDies.Width / 7) * i)
					labelDia.Location = New Point(x, 5)
					labelDia.Size = New Size((pnlDies.Width / 7), 13)
					
					Dim DataLabel As Date = Monday.AddDays(i)
					Dim Str As String = ""
					If pnlDies.Width < 500 Then
						Str = DataLabel.ToString("ddd") & " ( " & DataLabel.ToString("dd") & ") "
					ElseIf pnlDies.Width < 700 Then
						Str = DataLabel.ToString("ddd") & " ( " & DataLabel.ToString("d MMM") & ") "
					Else
						Str = DataLabel.ToString("dddd") & " ( " & DataLabel.ToString("d MMM") & ") "
					End If
					labelDia.Text = Str
					labelDia.Tag = DataLabel
					labelDia.Visible = True
					If DateDiff(DateInterval.Day, DataLabel, DateTimePickerCalendar.Value) = 0 Then
						labelDia.ForeColor = Color.Blue
					Else
						labelDia.ForeColor = Color.Black
					End If
				Catch ex As Exception
				End Try
			Next
		Else
			For i As Integer = 0 To 6
				Dim labelDia As Label = CType(pnlDies.Controls(i), Label)
				labelDia.Visible = False
			Next
			Dim labelDia2 As Label = CType(pnlDies.Controls(3), Label)
			labelDia2.Visible = True
			labelDia2.Text = DateTimePickerCalendar.Value.ToString("dddd") & " ( " & DateTimePickerCalendar.Value.ToString("d  MMM") & ") "
			labelDia2.Location = New Point((pnlDies.Width / 3), 5)
			labelDia2.Size = New Size((pnlDies.Width / 3), 13)
		End If
		pnlDies.Refresh()
		
	End Sub
	
	Private Sub PintaCalendar()
		picCalendar.Image = Nothing
		Dim bitmap As Bitmap = New Bitmap(picCalendar.Width, Me.picCalendar.Height)
		Dim g As Graphics = Nothing
		g = Graphics.FromImage(bitmap)
		Dim ColorMalla As Color = Color.FromArgb(193, 193, 193)
		Dim p As Pen = New Pen(ColorMalla)
		
		Dim Unitat As Integer = (picCalendar.Height / 96)
		UnitatMin = (Unitat / 30) * 2
		Dim y As Integer = Unitat
		Dim Min As Integer = 0
		g.DrawLine(p, 0, 0, picCalendar.Width, 0)
		Do Until y >= picCalendar.Height
			If y Mod (Unitat * 2) = 0 Then
				g.DrawLine(p, 0, y, picCalendar.Width, y)
			End If
			y += Unitat
		Loop
		
		Dim Dia As Integer = 0
		Dim x As Integer = 0
		If ShowCalendar = listCalendar.Setmana Then
			UnitatDies = picCalendar.Width / 49
			For i As Integer = 0 To 6
				x = (picCalendar.Width / 7) * i
				g.DrawLine(p, x, 0, x, picCalendar.Height)
				PuntIniXDies(Dia) = x + MargeItems
				Dia += 1
			Next
		Else
			UnitatDies = picCalendar.Width / 9
			For i As Integer = 0 To 2
				x = (picCalendar.Width / 3) * i
				g.DrawLine(p, x, 0, x, picCalendar.Height)
			Next
		End If
		g.DrawLine(p, CInt(picCalendar.Width - 1), 0, CInt(picCalendar.Width - 1), picCalendar.Height)
		
		If Not p Is Nothing Then
			p.Dispose()
		End If
		If Not g Is Nothing Then
			g.Dispose()
		End If
		
		Me.picCalendar.Image = bitmap
		
		'repinta els items del calendari
		PintaItemsCalendar()
	End Sub
	
	Private Sub PintaItemsCalendar()
		For Each MyPanel As Control In picCalendar.Controls
			If (TypeOf MyPanel Is Panel) Then
				
				Dim Duration As Integer = CInt(CType(MyPanel.Controls("lbDurada"), Label).Text)
				Dim DataProg As Date = CDate(CType(MyPanel.Controls("lbDataProg"), Label).Text)
				
				Dim nd As Short = 3
				If ShowCalendar = listCalendar.Setmana Then nd = 7
				MyPanel.Size = New Size((UnitatDies * nd) - (MargeItems * 2), Duration * UnitatMin)
				
				Dim x As Integer = (picCalendar.Width / 3) + 2
				If ShowCalendar = listCalendar.Setmana Then x = PuntIniXDies(Weekday(DataProg, FirstDayOfWeek.Monday) - 1)
				
				Dim y As Integer = (DataProg.Hour * 60 + DataProg.Minute) * UnitatMin + (UnitatMin * 30)
				MyPanel.Location = New Point(x, y)
			End If
		Next
		
	End Sub
	
	Private Sub PintaHores()
		'Pinta Hores
		picHores.Image = Nothing
		
		Dim bitmap As Bitmap = New Bitmap(picHores.Width, Me.picHores.Height)
		Dim g As Graphics = Nothing
		g = Graphics.FromImage(bitmap)
		Dim ColorMalla As Color = Color.FromArgb(193, 193, 193)
		Dim p As Pen = New Pen(ColorMalla)
		
		Dim UnitatTemps As Integer = picHores.Height / 96		
		Dim y As Integer = UnitatTemps
		Dim Min As Integer = 0		
		Do Until y >= picHores.Height
			If y Mod (UnitatTemps * 2) = 0 Then
				g.DrawLine(p, picHores.Width - 6, y, picHores.Width, y)
				
				Dim ts As TimeSpan = New TimeSpan(0, Min, 0)
				Min += 30
				Dim str As String = String.Format("{0:00}:{1:00}", ts.Hours, ts.Minutes)
				g.DrawString(str, New Font("Microsoft Sans Serif", 8), Brushes.Black , 0, y - 6)					
			Else
				g.DrawLine(p, picHores.Width - 4, y, picHores.Width, y)
			End If
			y += UnitatTemps
		Loop		 
		Me.picHores.Image = bitmap
		
		If Not p Is Nothing Then
			p.Dispose()
		End If
		If Not g Is Nothing Then
			g.Dispose()
		End If
		
	End Sub
	
	Friend Sub BuscaItemsCalendari()
		' Buscar la pauta per tot el dia seleccionat
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.AppStarting
		picCalendar.Controls.Clear()
		PintaDies()
		
		Dim StrSql As String = ""
        If ShowCalendar = listCalendar.Setmana Then
            Dim dataIni As Date = DateTimePickerCalendar.Value
            Dim dayDiff As Integer = Weekday(dataIni, FirstDayOfWeek.Monday) - DayOfWeek.Monday
            Dim Dilluns As Date = dataIni.AddDays(-dayDiff)
            Dim Diumenge As Date = Dilluns.AddDays(6)
            StrSql = "SELECT * FROM prglogger WHERE  (date(log_datereg) BETWEEN '" & Dilluns.ToString("yyyy-MM-dd") & "' AND '" & Diumenge.ToString("yyyy-MM-dd") & "')" & " ORDER BY log_datereg ASC"
        Else
            StrSql = "SELECT * FROM prglogger WHERE date(log_datereg) =  '" & DateTimePickerCalendar.Value.ToString("yyyy-MM-dd") & "' ORDER BY log_datereg ASC"
		End If

        Dim db As New MSC.dbs(Cloud)
        Dim dTable As DataTable = db.getTable(StrSql)
		For i As Integer = 0 To dTable.Rows.Count - 1
			
			Dim LogID As Integer = dTable.Rows(i)("log_id")
			Dim PrgID As Integer = dTable.Rows(i)("log_program")
			Dim SavePrg As Boolean = CBool(dTable.Rows(i)("log_saveprg"))
			Dim TipAssg As Integer = dTable.Rows(i)("log_tipassig")
			
			Dim dateIni As Date = CDate(dTable.Rows(i)("log_datereg"))
			Dim Durada As TimeSpan = dTable.Rows(i)("log_durada")
			Dim BitRate As String = dTable.Rows(i)("log_bitrate").ToString
			Dim SampleRate As String = dTable.Rows(i)("log_samplerate").ToString
			Dim AudioCanals As String = IIf(CInt(dTable.Rows(i)("log_canals")) = 1, "Mono", "Stereo")
			Dim RE As Boolean = CBool(dTable.Rows(i)("log_re"))
			Dim DataRE As Date = CDate(dTable.Rows(i)("log_redata"))
			Dim PupliWeb As Boolean = CBool(dTable.Rows(i)("log_publiweb"))
			Dim Fet As Boolean = CBool(dTable.Rows(i)("log_fet"))
			
			Dim Nom As String = ""
			If PrgID > 0 And SavePrg = True Then
				Nom = getNomPrograma(PrgID)
			Else
				Nom = SampleRate & " Hz (" & BitRate & " Kbps)"
			End If
			
			
			'Dim BorStyle As Boolean = True
			Dim toolTip As String = Nom
			toolTip += vbCrLf & "Hora inici: " & dateIni.ToLongTimeString & _
				vbCrLf & "Hora final: " & dateIni.AddMinutes(Durada.TotalMinutes).ToLongTimeString & _
				vbCrLf & "Qualitat: " & SampleRate & " Hz," & BitRate & " Kbps," & AudioCanals
			If RE = True Then toolTip += vbCrLf & "Reemissió: " & DataRE.ToLongDateString
			If PupliWeb = True Then toolTip += vbCrLf & "Publicar al Web (FTP)"
			If Fet = True Then toolTip += vbCrLf & "Còpia realitzada"
			toolTip += vbCrLf & "Tipus d'assignació: " & IIf(TipAssg = 0, "Per un dia de la setmana", "Per una data concreta")
			
			NewPanelProgramacio(LogID, Nom, dateIni, Durada.TotalMinutes, TipAssg, toolTip)
		Next
		dTable.Dispose()
		db = Nothing
		System.Windows.Forms.Cursor.Current = Cursors.Default
		
	End Sub
	
	Private Sub PictureBoxCalendar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBoxCalendar.Click
		ToolTip1.RemoveAll()
		If ShowCalendar = listCalendar.Dia Then
			PictureBoxCalendar.Image = Me.ImageListCalendar.Images(2)
			'           PictureBoxCalendar.Tag = 1
			ShowCalendar = listCalendar.Setmana
			ToolTip1.SetToolTip(cmdAnt, LABEL_GOTO_SETMANA_ABANS )
			ToolTip1.SetToolTip(cmdActual, LABEL_GOTO_AVUI)
			ToolTip1.SetToolTip(cmdPost,LABEL_GOTO_SETMANA_DESPRES )
		Else
			PictureBoxCalendar.Image = Me.ImageListCalendar.Images(1)
			'          PictureBoxCalendar.Tag = 2
			ShowCalendar = listCalendar.Dia
			ToolTip1.SetToolTip(cmdAnt, LABEL_GOTO_DIA_ABANS )
			ToolTip1.SetToolTip(cmdActual,LABEL_GOTO_AVUI )
			ToolTip1.SetToolTip(cmdPost,LABEL_GOTO_DIA_DESPRES )
		End If
		PintaHores()
		PintaCalendar()
		BuscaItemsCalendari()
	End Sub
	
	Private Sub cmdAnt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnt.Click
		If ShowCalendar = listCalendar.Setmana Then
			DateTimePickerCalendar.Value = DateTimePickerCalendar.Value.AddDays(-7)
		Else
			DateTimePickerCalendar.Value = DateTimePickerCalendar.Value.AddDays(-1)
		End If
	End Sub
	
	Private Sub cmdActual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdActual.Click
		DateTimePickerCalendar.Value = Now
	End Sub
	
	Private Sub cmdPost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPost.Click
		If ShowCalendar = listCalendar.Setmana Then
			DateTimePickerCalendar.Value = DateTimePickerCalendar.Value.AddDays(7)
		Else
			DateTimePickerCalendar.Value = DateTimePickerCalendar.Value.AddDays(1)
		End If
	End Sub
	
	Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePickerCalendar.ValueChanged
		BuscaItemsCalendari()
	End Sub
	
	Private Sub frmPrgLogger_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
		Try
			PintaDies()			
			PintaCalendar()
		Catch ex As Exception			
		End Try
	End Sub
	
	Private Sub NewPanelProgramacio(ByVal IdLog As Integer, ByVal NomLog As String, ByVal DataProg As Date, ByVal Duration As Integer, ByVal TipAssig As Integer, ByVal toolTip As String)
		
		Dim PanelPrgramacio As New Panel
		PanelPrgramacio.Name = IdLog & "-" & DataProg.ToString
		Dim LbLink As New LinkLabel
		LbLink.Name = "LbLink"
		LbLink.Text = NomLog
		LbLink.Tag = IdLog
		LbLink.TextAlign = ContentAlignment.MiddleCenter
		LbLink.Parent = PanelPrgramacio
		LbLink.BackColor = Color.Transparent
		LbLink.Dock = DockStyle.Fill
		AddHandler LbLink.Click, AddressOf ClikOnlink
		
		Me.ToolTip1.SetToolTip(LbLink, toolTip)
		Me.ToolTip1.SetToolTip(PanelPrgramacio, toolTip)
		
		Dim lbDurada As New Label
		lbDurada.Name = "lbDurada"
		lbDurada.Text = Duration
		lbDurada.Visible = False
		lbDurada.Parent = PanelPrgramacio
		
		Dim lbDataProg As New Label
		lbDataProg.Name = "lbDataProg"
		lbDataProg.Text = DataProg
		lbDataProg.Visible = False
		lbDataProg.Parent = PanelPrgramacio
		
		If TipAssig = 0 Then			
			PanelPrgramacio.BackgroundImage = Me.picCalTaronja.Image
		Else
			PanelPrgramacio.BackgroundImage = Me.picCalBlau.Image 			
		End If		
		PanelPrgramacio.BackgroundImageLayout = ImageLayout.Stretch		
		PanelPrgramacio.Parent = Me.picCalendar
		PintaItemsCalendar()
	End Sub
	
	Private Sub ClikOnlink(ByVal sender As System.Object, ByVal e As System.EventArgs)
		Dim id As Integer = CType(sender, LinkLabel).Tag
		ShowLoggerFromID(id)
	End Sub
	
	Private Sub ShowLoggerFromID(ByVal id As Integer)
		
		Dim StrSql As String = "SELECT * FROM  prglogger WHERE log_id = " & id
        Dim db As New MSC.dbs(Cloud)

        Dim rsLog As DataTable = db.getTable(StrSql)
		'Omplir pantalla   
		Dim DataRadi As Date = rsLog.Rows(0)("log_datereg").ToString
		Me.txtDataIn.Value = DataRadi
		ComboBitRate.Text = rsLog.Rows(0)("log_bitrate").ToString
		ComboSampleRate.Text = rsLog.Rows(0)("log_samplerate").ToString
		Me.ComboCanalsAudio.SelectedIndex = CInt(rsLog.Rows(0)("log_canals"))-1
		Me.chksaveAsPrg.Checked = CBool(rsLog.Rows(0)("log_saveprg"))
		If rsLog.Rows(0)("log_tipassig") = Tipus_AssigDataCalendari.PROGRAM_DIA_SETMANA_HORA Then
			Me.optSetmHora.Checked = True
		Else
			Me.optDataHora.Checked = True
		End If
		lbFet.Visible = CBool(rsLog.Rows(0)("log_fet"))
		'Me.ComboDiaSetmana.SelectedIndex = DataRadi.DayOfWeek - 1
		Dim HoraIni As Date = DataRadi.ToString("HH:mm:ss")
		Me.txtHoraIni.Value = New Date(1970, 1, 1, Hour(HoraIni), Minute(HoraIni), Second(HoraIni), DateTimeKind.Local)
		Dim Durada As Date = CDate(rsLog.Rows(0)("log_durada").ToString)
		Me.txtDurada.Value = New Date(1970, 1, 1, Hour(Durada), Minute(Durada), Second(Durada), DateTimeKind.Local)
		Me.ComboBoxProgrames.SelectedValue = CInt(rsLog.Rows(0)("log_program"))
		Me.chkReEmissio.Checked = CBool(rsLog.Rows(0)("log_re"))
		If rsLog.Rows(0)("log_retipassig") = Tipus_AssigDataCalendari.PROGRAM_DIA_SETMANA_HORA Then
			Me.optSetmHoraReEmissor.Checked = True
		Else
			Me.optDataHoraReEmissor.Checked = True
		End If
		
		Dim DataRE As Date = rsLog.Rows(0)("log_redata").ToString
		Me.txtDataReemissor.Value = DataRE
		Me.ComboDiaSetmanaReEmissor.SelectedIndex = Weekday(DataRE, FirstDayOfWeek.Monday) - 1
		
		txtHoraRemissio.Value = DataRE.ToString
		Me.chkPodcasting.Checked = CBool(rsLog.Rows(0)("log_publiweb"))
		Me.lbID.Text = rsLog.Rows(0)("log_id").ToString
		Me.Text = ME_TEXT & " (" & DataRadi.ToLongDateString & " " & DataRadi.ToShortTimeString & ")"
		
		rsLog.Dispose()
		db = Nothing
		
	End Sub
	
	Private Sub txtDataIn_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDataIn.ValueChanged
		Changed()
		txtDataReemissor.Value = txtDataIn.Value
		txtDataOut.MinDate = txtDataIn.Value
		If optSetmHora.Checked = True Then
			optSetmHora.Text = LABEL_DIA_SETMANA_HORA & " (" & txtDataIn.Value.ToString("dddd") & ")"
		Else
			optSetmHora.Text = LABEL_DIA_SETMANA_HORA
		End If
	End Sub
	
	Private Sub mnu_Help_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_Help.Click
		Dim Proces As Process = New Process
		Try
			Process.Start(MSC.Help.HELP_GEST_AUTOMATITZACIO_LOGGER.ToString)
		Catch ex As Exception
		End Try
	End Sub

    Sub CmdDelMassiveClick(sender As Object, e As EventArgs) Handles cmdDelMassive.Click
        Try
            frmDelLogger.Show(Me)
        Catch ex As Exception
            frmDelLogger.WindowState = FormWindowState.Normal
        End Try

    End Sub

    Sub ButtonResizeCalendarMesClick(sender As Object, e As EventArgs) Handles buttonResizeCalendarMes.Click, buttonResizeCalendarMenys.Click

        If CType(sender, Button).Text = "+" Then
            If picHores.Height > 4000 Then Exit Sub
            picHores.Height = picHores.Height + 384

        Else
            If picHores.Height < 500 Then Exit Sub
            picHores.Height = picHores.Height - 384
        End If

        picCalendar.Height = picHores.Height
        PintaHores()
        PintaCalendar()
    End Sub

    Private Sub frmPrgLogger_ResizeEnd(sender As Object, e As EventArgs) Handles MyBase.ResizeEnd
        Dim FitxerINI As New IniFile
        frm_sice(0) = Me.Width : frm_sice(1) = Me.Height
        FitxerINI.INIWrite(MyAPP.IniFile, "Data Gest", "size", frm_sice(0).ToString & "," & frm_sice(1).ToString)
    End Sub
End Class