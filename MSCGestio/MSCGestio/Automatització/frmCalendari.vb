Option Strict Off
Option Explicit On
Imports MySql.Data.MySqlClient


Public Class frmCalendari
	Dim blEnable As Boolean
	Dim mblnNewDates As Boolean
	
	'Dim ActualDataCalendar As Date = Now
	Dim UnitatMin As Double
	Dim UnitatDies As Integer
	Dim PuntIniXDies(7) As Integer
	Dim MargeItems As Integer = 2
	
	
	Dim ShowCalendar As listCalendar = listCalendar.Setmana
	
	Private Sub CloseForm()
		'If Me.ToolbarEdit.Buttons.Item(4).Enabled Then
		'    If MsgBox("Vols salvar les modificacions?", vbOKCancel) = vbOK Then SaveRecord()
		'End If
		MyAPP.CloseSesionClient(MyAPP.IDSesion_Client, DESCRIP_FORM_CALENDARI)
		Me.Dispose()
	End Sub
	
	Private Sub frmCalendari_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		CloseForm()
	End Sub
	
	Private Sub cmdExitTool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExitTool.Click
		Me.Close()
	End Sub
	
	Private Sub cmbExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbExit.Click
		Me.Close()
	End Sub
	
	Private Sub EnableSegonsAssigPauta()
		
		Select Case cmbTipProg.SelectedIndex
			Case Tipus_Emissio.TIP_AUTOMATIC
				Me.panelDirecte.Visible = False
				Me.PanelAutomatic.Visible = True
				Me.lbProg.Visible = False
				Me.cmbProgrames.Visible = False
				cmdCapturaDuradaPrg.Visible = False
				Me.chk_reclogger.Visible = False
			Case Tipus_Emissio.TIP_CONEX_CENTRAL
				Me.panelDirecte.Visible = False
				Me.PanelAutomatic.Visible = False
				Me.chk_reclogger.Visible = False
				Me.lbInfo.Text = MSG_SYSTEM_STANBY_CENTRAL
				Me.lbProg.Visible = False
				Me.cmbProgrames.Visible = False
				cmdCapturaDuradaPrg.Visible = False
				Me.chk_Force.Visible = False				
			Case Tipus_Emissio.TIP_DIRECTE	
				Me.panelDirecte.Visible = True
				Me.PanelAutomatic.Visible = False
				Me.lbInfo.Text = MSG_SYSTEM_STANBY_DIRECTE
				Me.lbProg.Visible = True
				Me.cmbProgrames.Visible = True
				cmdCapturaDuradaPrg.Visible = True
				Me.chk_reclogger.Visible = mblnNewDates = True
				Me.chk_Force.Visible = True
		End Select
		If blEnable Then Changed()
	End Sub
	
	Private Sub Changed()
		If blEnable Then Me.cmdSalvar.Enabled = True : mnuSave.Enabled = True
	End Sub
	
	Private Sub cmdBloqueix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBloqueix.Click
		LockedRecord()
	End Sub
	
	Private Sub LockedRecord(Optional ByVal saved As Boolean = False)
        If Me.cmdSalvar.Enabled = True And saved = False Then
            If MetroFramework.MetroMessageBox.Show(Me, MSG_SAVE_DADES, MSG_ATENCIO, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, 100) = MsgBoxResult.Ok Then SaveRecord()
        End If
        blEnable = Not blEnable
		Me.grupAssignar.Enabled = blEnable
		Me.cmdDel.Enabled = blEnable
		Me.cmdDelCalendar.Enabled = blEnable
		Me.lbHora.Visible = True
		Me.txtHoraIni.Visible = True
		GrupDiesSetman.Visible = False
		chk_reclogger.Visible = False
		GroupBoxReemissio.Visible = False
		mblnNewDates = False
		txtDataOut.Visible = False
		chkPubliPodcast.Visible = False
		chkPubliPodcast.Checked = False
		chk_FromCloud.Enabled = False
		chk_FromCloud.Checked = False 
		Me.ldNou.Visible = False
		GroupBoxInfoCalendar.Visible = True
        Me.chk_Force.Enabled = blEnable
        If blEnable Then
			Me.cmdBloqueix.Image = Me.picUnLock.Image
		Else
			Me.cmdBloqueix.Image = Me.picLock.Image
			Me.cmdSalvar.Enabled = False
		End If
	End Sub
	
	Private Sub frmCalendari_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		setLanguageForm()

        OmplircomboBoxProgramSessions(ComboBoxProgrames)

        Me.dtpDataRadi.Value = Now
		cmdBloqueix.Enabled = IIf(Usuari.UsrTipus > NivellUsers.USR_CONVIDAT, True, False)
		Me.mnuModif.Enabled = cmdBloqueix.Enabled
		Me.cmdNou.Enabled = IIf(Usuari.UsrTipus > NivellUsers.USR_CONVIDAT, True, False)

        Me.mnuNew.Visible = Me.cmdNou.Visible

        PictureBoxCalendar.Image = Me.ImageListCalendar.Images(2)
		ShowCalendar = listCalendar.Setmana

        chk_FromCloud.Visible = cloud.IsActive
        chk_podcast.Enabled = cloud.IsActive
        Me.ClientSize = New Size(frm_sice(0), frm_sice(1))

        PintaHores()

    End Sub
	
	Dim CAPTION_TEXT As String = ""
	Dim OpenFileDialog1_Title As String = ""
	Dim OpenFileDialog1_Filter As String = ""	
	Dim MSG_DURADA_NO_VALIDA As String = ""
	Dim MSG_SET_SESSIO As String = ""
	Dim MSG_NO_ASSIG_DIA As String = ""
	Dim MSG_SURE_DEL_ITEM As String = ""
	Dim MSG_END_DEL_ROWS_AFECTATS As String = ""	
	
	Dim cmdAnt_Dia_ToolTip As String
	Dim cmdAnt_Setmana_ToolTip As String
	Dim cmdActual_ToolTip As String 
	Dim cmdPost_Dia_ToolTip As String 
	Dim cmdPost_Setmana_ToolTip As String
	Dim MSG_MINIM_OPTION_FILTER As String = ""
	
	
	Public Sub setLanguageForm()
		lang.StrForm = Me.Name
		
		CAPTION_TEXT = lang.getText("Text") '"Programació del calendari"
		OpenFileDialog1_Title = lang.getText("LABEL_BUSCAR",True) & "..."'"Buscar ..."
		OpenFileDialog1_Filter = lang.getText("OpenFileDialog1_Filter")'"Llistats"
		MSG_DURADA_NO_VALIDA = lang.getText("MSG_DURADA_NO_VALIDA")'"La durada no és vàlida"
		MSG_SET_SESSIO = lang.getText("MSG_SET_SESSIO")'"S'ha d'assignar una sessió"
		MSG_NO_ASSIG_DIA = lang.getText("MSG_NO_ASSIG_DIA")'"No hi ha cap dia assignat"
		MSG_SURE_DEL_ITEM = lang.getText("MSG_SURE_DEL_ITEM")'"Segur que vol borrar l'item del calendari ?"
		MSG_END_DEL_ROWS_AFECTATS = lang.getText("MSG_DELETED_ROWS_AFECTED",True)'"Operació realitzada, s'ha borrat {0} registres."
		
		cmdAnt_Dia_ToolTip = lang.getText("LABEL_UN_DIA_ABANS",True)'"Un dia abans"
		cmdAnt_Setmana_ToolTip = lang.getText("LABEL_UNA_SETMANA_ABANS",True)'"Una setmana abans"
		cmdActual_ToolTip =  lang.getText("LABEL_GOTO_AVUI",True)'"Vés a avui"
		cmdPost_Dia_ToolTip = lang.getText("LABEL_UN_DIA_DESPRES",True)'"Un dia després"
		cmdPost_Setmana_ToolTip = lang.getText("LABEL_UNA_SETMANA_DESPRES",True) '"Una setmana després"
        MSG_MINIM_OPTION_FILTER = lang.getText("MSG_MINIM_OPTION_FILTER") '"Mínim una opció de filtratge"

        ToolTip1.SetToolTip(cmdAnt, cmdAnt_Setmana_ToolTip)
		ToolTip1.SetToolTip(cmdActual, cmdActual_ToolTip)
		ToolTip1.SetToolTip(cmdPost, cmdPost_Setmana_ToolTip)
		ToolTip1.SetToolTip(Me.picFileNoExist, MSG_FILE_NO_EXIST)
		
		Me.cmdExitTool.ToolTipText = lang.getText("LABEL_TANCAR_PANTALLA",True)'"Tancar pantalla"
		Me.cmdNou.Text = lang.getText("cmdNou.Text")'"Nou ítem"
		Me.cmdBloqueix.Text = lang.getText("LABEL_EDIT_ITEM",True)'"Editar ítem"
		Me.cmdDelCalendar.Text = lang.getText("cmdDelCalendar.Text")'"Eliminació massiva del Calendari"
		Me.cmdDel.ToolTipText = lang.getText("LABEL_DEL_ITEM",True)'"Borrar fitxer"
		Me.cmdSalvar.Text = lang.getText("LABEL_SALVAR_ITEM",True)'"Salvar ítem"
		Me.ToolStripSplitButton1.Text = lang.getText("ToolStripSplitButton1.Text")'"Visualitza"
		Me.mnu_prg_direct.Text = lang.getText("mnu_prg_direct.Text")'"Prog: Directe"
		Me.mnu_prg_connex.Text = lang.getText("mnu_prg_connex.Text")'"Prog: Connexió"
		Me.mnu_pgr_automat.Text = lang.getText("mnu_pgr_automat.Text")'"Prog: Automàtic"
		Me.mnu_add_logger.Text = lang.getText("mnu_add_logger.Text")'"Solapar Logger"
		Me.ldNou.Text = lang.getText("LABEL_NEW_UPPER",True)'"NOU"
		Me.grupAssignar.Text = lang.getText("grupAssignar.Text")'"Assignació al calendari"
		Me.chkBolNoticies.Text = lang.getText("chkBolNoticies.Text")'"Butlletins a l'inici de l'hora (connectant amb central)"
		Me.Label1.Text = lang.getText("LABEL_DESCRIPCIO",True)'"Descripció"
		Me.Label6.Text = lang.getText("LABEL_ACCEPT_HTML", True )'"accepta HTML"
		Me.Label17.Text = lang.getText("HEADERTEXT_DURADA",True) 'Durada
		Me.Label60.Text = lang.getText("HEADERTEXT_DATA",True)'"Data"
		Me.GroupBoxTP.Text = lang.getText("GroupBoxTP.Text")'"Tipus de Programació"
		Me.chk_podcast.Text = lang.getText("chk_podcast.Text")'"Publicar al Web (Podcast)"
		Me.label120.Text = lang.getText("LABEL_HORES",True)'"hores"
		Me.Label11.Text = lang.getText("Label11.Text")'"Remissió al cap de"
		Me.lbProg.Text = lang.getText("LABEL_PROGRAMA",True)'"Programa"		
		
		Me.cmdCapturaDuradaPrg.Text = lang.getText("HEADERTEXT_DURADA",True)'"Durada"
		Me.toolTip1.SetToolTip(cmdCapturaDuradaPrg, lang.getText("cmdCapturaDuradaPrg.ToolTip"))
		Me.RadioButtonList.Text = lang.getText("HEADERTEXT_LLISTAT",True)'"Llistat"
		Me.RadioButtonRF.Text = lang.getText("LABEL_RADIO_FORMULA",True)'"Ràdio Fórmula"
		Me.RadioButtonPrg.Text = lang.getText("LABEL_PROGRAMA",True)'"Programa"
		Me.GroupBoxPrg.Text = lang.getText("LABEL_PROGRAMA",True)'"Programa"
		Me.chkPubliPodcast.Text = lang.getText("LABEL_PUBLICAR_POCAST",True)'"Publicar al Podcasting"
		Me.chkRemissio.Text = lang.getText("chkRemissio.Text")'"És una remissió"
		Me.cmdCapturaDuradaSessio.Text = lang.getText("cmdCapturaDuradaSessio.Text")'"Establir durada de la sessió"
		
		'Me.Label7.Text = lang.getText("LABEL_PROGRAMA",True)'"Sessió del  programa"
		Me.GroupBoxList.Text = lang.getText("HEADERTEXT_LLISTAT",True)'"LListat"
		Me.Label4.Text = lang.getText("Label4.Text")'"Llistat pre-definit (amb les Cartutxeres)"
		Me.GroupBoxRF.Text = lang.getText("LABEL_RADIO_FORMULA",True)'"Ràdio Fórmula"
		Me.Label3.Text = lang.getText("LABEL_NOM_PAUTA",True) & ":"'"Nom de la Pauta:"
		Me.chk_reclogger.Text = lang.getText("chk_reclogger.Text")'"Programar l'enregistrament"
		
		Me.lbHora.Text = lang.getText("LABEL_HORA_INICI",True)'"Hora Inici"
		Me.optionData.Text = lang.getText("LABEL_PER_DATA_CONCRET",True)'"Per una data en concret"
		Me.optionSemana.Text = lang.getText("LABEL_DIES_SETMANA_DLL_DT",True)'"Dies de la setmana (Dll, Dt,Dc,..)"
		Me.GrupDiesSetman.Text = lang.getText("GrupDiesSetman.Text")'"Dies inclosos"		
		Me.GroupBoxInfoCalendar.Text = lang.getText("LABEL_LLEGENDA_CALENDARI",True)'"Llegenda del calendari"
		Me.Label10.Text = lang.getText("Label10.Text")'"Provinent Logger"
		Me.lbNomDirecte.Text = lang.getText("lbNomDirecte.Text")'"Directe"
		Me.lbNomCentral.Text = lang.getText("lbNomCentral.Text")'"Central"
		Me.lbNomAutomat.Text = lang.getText("lbNomAutomat.Text")'"Automatica"
		Me.ProgarmaToolStripMenuItem.Text = lang.getText("LABEL_PROGRAMA",True)'"Programa"		
		Me.EdicióToolStripMenuItem.Text = lang.getText("mnuEdit.Text",True)'"Edició"
		Me.mnuModif.Text = lang.getText("LABEL_MODIFICAR",True)'"Modificar"
		Me.mnuNew.Text = lang.getText("LABEL_NEW",True)'"Nou"	
		Me.cmdActual.Text = lang.getText("LABEL_AVUI",True)'"Avui"
		
		Me.lbInfo.Text = MSG_SYSTEM_STANBY_DIRECTE
		Me.mnuExit.Text = lang.getText("LABEL_EXIT",True )'"Sortir"
		Me.mnuSave.Text = lang.getText("LABEL_SALVAR",True)'"Salvar"
		Me.mnuDel.Text = lang.getText("LABEL_DELETE",True)'"Borrar"
		Me.AjudaToolStripMenuItem.Text = lang.getText("mnu_Help",True)'"Ajuda"
		Me.mnu_Help.Text = lang.getText("mnuRefHelp.Text",True)'"Manual OnLine"
		
		Me.chk_FromCloud.Text = lang.getText("chk_FromCloud.Text")'"Procedent del núvol comunitari"
		Me.lbPendentBaixar.Text = lang.getText("lbPendentBaixar.Text") '"Pendent de baixar"				
        Me.chk_Force.Text = lang.getText("chk_Force.Text") '"Assegurar la continuitat amb MSC Continuitat"

        Dim Monday As Date = Me.dtpDataRadi.Value.AddDays(-Weekday(Me.dtpDataRadi.Value, FirstDayOfWeek.Monday) + 1)
        Me.chk_Dlls.Text = Monday.ToString("ddd") 'lang.getText("LABEL_dl", True)
        Me.chk_Dmrs.Text = Monday.AddDays(1).ToString("ddd") 'lang.getText("LABEL_dt", True)
        Me.chk_Dmres.Text = Monday.AddDays(2).ToString("ddd") 'lang.getText("LABEL_dc", True)
        Me.chk_Djs.Text = Monday.AddDays(3).ToString("ddd") 'lang.getText("LABEL_dj", True)
        Me.chk_Dvs.Text = Monday.AddDays(4).ToString("ddd") 'lang.getText("LABEL_dv", True)
        Me.chk_Dssap.Text = Monday.AddDays(5).ToString("ddd") 'lang.getText("LABEL_ds", True)
        Me.chk_Dge.Text = Monday.AddDays(6).ToString("ddd") 'lang.getText("LABEL_dg", True)


        Me.Text = CAPTION_TEXT
        Dim cmb As New combo
        cmb.OmpleCombo(cmbListPauta, TAULES_DBS.TAULA_PAUTES, TotsCap.CAP, "listpauta_sessio=0") : cmbListPauta.SelectedValue = 0
        cmb.OmpleCombo(Me.cmbTipProg, TAULES_DBS.TAULA_TIPUS_EMISSIO, TotsCap.NO_ADD)
        cmb.OmpleCombo(cmbProgrames, TAULES_DBS.TAULA_PROGRAMES, TotsCap.CAP, "prg_propia=1")
        cmb.OmpleCombo(cmbProgramesCloud, TAULES_DBS.TAULA_PROGRAMES, TotsCap.CAP, "len(prg_hash)>0 AND prg_propia=0")

        Me.lbNomAutomat.Text = getNomTipusProgramacio(Tipus_Emissio.TIP_AUTOMATIC)
        Me.lbNomCentral.Text = getNomTipusProgramacio(Tipus_Emissio.TIP_CONEX_CENTRAL)
        Me.lbNomDirecte.Text = getNomTipusProgramacio(Tipus_Emissio.TIP_DIRECTE)

    End Sub
	
	Private Sub NetejaPantalla()
		'Borra els valors anteriors
		Me.lbID.Text = 0
		Me.txtPauta.Text = ""
		chkBolNoticies.Checked = False
		cmbListPauta.SelectedValue = 0
		cmbTipProg.SelectedIndex = 0		
		Me.optionSemana.Checked = True				
		Me.txtDurada.Value = New Date(1970, 1, 1, 0, 0, 0)		
		Me.chkRemissio.Checked = False
		Me.chk_podcast.Checked = False
		Me.txtHoresReemissio.Text = "0"
		Me.ComboBoxProgrames.SelectedValue = 0
		Me.txtHoraIni.Value = New Date(1970, 1, 1, 0, 0, 0)
		Me.chk_reclogger.Checked = False
		Me.txtDescrip.Text = ""
		Me.chk_Force.Checked = False 
		
		Me.Text = CAPTION_TEXT
	End Sub

    Private Sub cmdFindPauta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPauta.ButtonClick
        With OpenFileDialog1
            .InitialDirectory = Params.PathDefPauta & "\"
            .Title = OpenFileDialog1_Title
            .Filter = OpenFileDialog1_Filter & " (*.ptc)|*.ptc"
            If .ShowDialog = System.Windows.Forms.DialogResult.OK Then Me.txtPauta.Text = .FileName
        End With
    End Sub

    Private Sub cmbAssigHora_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipProg.SelectedIndexChanged
		EnableSegonsAssigPauta()
	End Sub
	
	Private Sub cmbListPauta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbListPauta.KeyPress
		e.KeyChar = UCase(e.KeyChar)
	End Sub
	
	Private Sub cmbListPauta_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbListPauta.TextChanged
		Dim index As Integer = _
			CType(sender, ComboBox).FindStringExact(CType(sender, ComboBox).Text())
		If index < 0 Then
			'no existeix el que es busca
		End If
	End Sub
	
	Private Sub NewRecord()
		NetejaPantalla()
		blEnable = False
		LockedRecord()
		optionSemana.Checked = True
		GrupDiesSetman.Visible = optionSemana.Checked        
		txtDataOut.Visible = True
		Me.chkRemissio.Checked = False 
		chkPubliPodcast.Visible = True 
		chkPubliPodcast.Checked = False 
		mblnNewDates = True
		Me.ldNou.Visible = True
		GroupBoxInfoCalendar.Visible = False		
		Me.chk_reclogger.Visible = True
		Me.chk_reclogger.Checked = False
        chk_FromCloud.Enabled = True
    End Sub
	
	Private Sub cmdNou_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNou.Click
		NewRecord()
	End Sub
	
	Private Sub optionSemana_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optionSemana.CheckedChanged
		GrupDiesSetman.Visible = (optionSemana.Checked And mblnNewDates = True)
		
		Changed()
	End Sub
	
	Private Sub optionData_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optionData.CheckedChanged
		Me.txtDataOut.Visible = (Not optionData.Checked) And  (mblnNewDates = True)  
		Changed()
	End Sub
	
	Private Sub cmbListPauta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbListPauta.SelectedIndexChanged
		Changed()
	End Sub
	
	Private Sub txtPauta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPauta.TextChanged
		Changed()
	End Sub
	
	Private Sub chkBolNoticies_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBolNoticies.CheckedChanged
		Changed()
	End Sub

    Private Sub SaveRecord()

        If Not MyAPP.PermisPerContinuar() Then MetroFramework.MetroMessageBox.Show(Me, MSG_SERVER_CLOSE, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Stop, 100) : Me.Close()
        If MetroFramework.MetroMessageBox.Show(Me, MSG_CONFIRM_SAVE_DADES, MSG_ATENCIO, MessageBoxButtons.YesNo, MessageBoxIcon.Question, 100) = DialogResult.No Then Exit Sub

        Dim TipAssig As Integer = IIf(Me.optionSemana.Checked = True, 0, 1)
        Dim TipProgram As Tipus_Emissio = CType(Me.cmbTipProg.SelectedValue, Tipus_Emissio)
        Dim Durada As Date = Me.txtDurada.Value

        If Durada = "#1/1/1970#" Then MetroFramework.MetroMessageBox.Show(Me, MSG_DURADA_NO_VALIDA, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100) : Exit Sub
        If RadioButtonPrg.Checked = True AndAlso Me.ComboBoxProgrames.SelectedValue = 0 AndAlso TipProgram = Tipus_Emissio.TIP_AUTOMATIC AndAlso Me.chk_FromCloud.Checked = False Then
            MetroFramework.MetroMessageBox.Show(Me, MSG_SET_SESSIO, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100) : ComboBoxProgrames.Focus() : Exit Sub
        End If
        Dim StrSql As String = ""
        Dim ForceDirecte As Boolean = False
        If TipProgram = Tipus_Emissio.TIP_DIRECTE Then ForceDirecte = Me.chk_Force.Checked

        Dim BolNoticies As Boolean = Me.chkBolNoticies.Checked
        Dim IdPauta As Integer = Me.cmbListPauta.SelectedValue 'PAUTA_DEF
        Dim IdPrograma As Integer = 0
        Dim FitxPauta As String = ""
        Dim Descrip As String = Me.txtDescrip.Text
        Dim IsReemissio As Boolean = Me.chkRemissio.Checked
        Dim StrSqlPodCast() As String
        If RadioButtonPrg.Checked = False Then IsReemissio = False
        Dim IdSession As Integer = Me.ComboBoxProgrames.SelectedValue

        'Cloud
        Dim IsFromCloud As Boolean = False

        Dim data As Date = New Date(Me.txtDataIn.Value.Year, txtDataIn.Value.Month, txtDataIn.Value.Day, Me.txtHoraIni.Value.Hour, txtHoraIni.Value.Minute, txtHoraIni.Value.Second)
        Dim DuradaInSeconds As Integer = Me.txtDurada.Value.Second + (Me.txtDurada.Value.Minute * 60) + (Me.txtDurada.Value.Hour * 3600)
        Dim DataOUT As Date = New Date(Me.txtDataOut.Value.Year, txtDataOut.Value.Month, txtDataOut.Value.Day, txtHoraIni.Value.Hour, txtHoraIni.Value.Minute, txtHoraIni.Value.Second).AddSeconds(DuradaInSeconds)
        If TipAssig = Tipus_AssigDataCalendari.PROGRAM_DATA_HORA Then DataOUT = data
        Dim NumDies As Integer = DateDiff(DateInterval.Day, data, DataOUT)
        If NumDies < 1 Then NumDies = 1

        'comprova la assignació de dies per "TipAssig = Tipus_AssigDataCalendari.PROGRAM_DIA_SETMANA_HORA"
        If Me.chk_Dlls.Checked = False AndAlso Me.chk_Dmrs.Checked = False AndAlso Me.chk_Dmres.Checked = False _
            AndAlso Me.chk_Djs.Checked = False AndAlso Me.chk_Dvs.Checked = False AndAlso Me.chk_Dssap.Checked = False _
            AndAlso Me.chk_Dge.Checked = False AndAlso TipAssig = Tipus_AssigDataCalendari.PROGRAM_DIA_SETMANA_HORA _
            AndAlso mblnNewDates = True Then
            MetroFramework.MetroMessageBox.Show(Me, MSG_NO_ASSIG_DIA, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
            Exit Sub
        End If

        Dim db As New MSC.dbs(Cloud)
        db.IniTransaction()

        Select Case TipProgram
            Case Tipus_Emissio.TIP_AUTOMATIC
                If Me.RadioButtonRF.Checked Then
                    IdPauta = Me.cmbListPauta.SelectedValue
                ElseIf Me.RadioButtonPrg.Checked Then
                    'S'ha de crear la pauta
                    Dim NomPrograma As String = Me.ComboBoxProgrames.Text
                    IsFromCloud = Me.chk_FromCloud.Checked
                    If IsFromCloud = False Then
                        StrSql = "INSERT INTO listpautes ( listpauta_titol, listpauta_datacreacio, listpauta_sessio, listpauta_sequencia)"
                        StrSql = StrSql & " VALUES "
                        StrSql = StrSql & "( '" & AddSlashes(NomPrograma) & "'"
                        StrSql = StrSql & ", '" & Now.ToString("yyyy-MM-dd HH:mm:ss") & "'"
                        StrSql = StrSql & ", " & IdSession
                        StrSql = StrSql & ", " & Params.Sequencia_Programs
                        StrSql = StrSql & ");"
                        IdPauta = db.New_ID(StrSql)

                        StrSql = "INSERT INTO pautes_params (pauta_bloc,list_pauta) VALUES (" & BLC_DEF & "," & IdPauta & "), (" & BLC_DEF & "," & IdPauta & ");"
                        db.ExecuteInstruc(StrSql)
                    End If
                ElseIf Me.RadioButtonList.Checked Then
                    FitxPauta = Me.txtPauta.Text
                End If
            Case Tipus_Emissio.TIP_CONEX_CENTRAL
            Case Tipus_Emissio.TIP_DIRECTE
                IdPrograma = Me.cmbProgrames.SelectedValue
        End Select

        If mblnNewDates Then
            Dim NewID As Integer = 0
            'establir la dataIn al primer dia sel·lecconat
            If TipAssig = Tipus_AssigDataCalendari.PROGRAM_DIA_SETMANA_HORA Then
                Do
                    If data.DayOfWeek = DayOfWeek.Monday And Me.chk_Dlls.Checked Then Exit Do
                    If data.DayOfWeek = DayOfWeek.Tuesday And Me.chk_Dmrs.Checked Then Exit Do
                    If data.DayOfWeek = DayOfWeek.Wednesday And Me.chk_Dmres.Checked Then Exit Do
                    If data.DayOfWeek = DayOfWeek.Thursday And Me.chk_Djs.Checked Then Exit Do
                    If data.DayOfWeek = DayOfWeek.Friday And Me.chk_Dvs.Checked Then Exit Do
                    If data.DayOfWeek = DayOfWeek.Saturday And Me.chk_Dssap.Checked Then Exit Do
                    If data.DayOfWeek = DayOfWeek.Sunday And Me.chk_Dge.Checked Then Exit Do
                    data = data.AddDays(1)
                Loop
            End If
            ProgressBar.Maximum = NumDies
            'If ProgressBar.Maximum = 0 Then ProgressBar.Maximum = 1
            ProgressBar.Value = 0
            ProgressBar.Visible = True
            Dim StrInsertCal As String = "INSERT INTO calendari (cal_data, cal_tipassig, cal_prgtipus, cal_pauta, cal_pathpauta, cal_noticies, cal_descripcio, cal_prog, cal_durada, cal_reemissio, cal_logger, cal_force, cal_cloud) VALUES "
            Dim strValues As String = ""
            Dim MyQuery As String = ""
            Do While data <= DataOUT
                Dim NewIDLogger As Integer = 0
                'si prové del núvol crea la pauta per cada data
                If Me.RadioButtonPrg.Checked = True AndAlso IsFromCloud = True Then
                    IdSession = -1
                    Dim NomPrograma As String = cmbProgramesCloud.Text & " ( " & data.ToString("yyyy-MM-dd HH:mm:ss") & ")"
                    IdPrograma = cmbProgramesCloud.SelectedValue
                    Dim StrLisPauta As String = "INSERT INTO listpautes ( listpauta_titol, listpauta_datacreacio, listpauta_sessio, listpauta_sequencia)"
                    StrLisPauta += " VALUES "
                    StrLisPauta += "( '" & AddSlashes(NomPrograma) & "'"
                    StrLisPauta += ", '" & data.ToString("yyyy-MM-dd HH:mm:ss") & "'"
                    StrLisPauta += ", " & IdSession
                    StrLisPauta += ", " & Params.Sequencia_Programs
                    StrLisPauta += ");"
                    IdPauta = db.New_ID(StrLisPauta)

                    StrLisPauta = "INSERT INTO pautes_params (pauta_bloc,list_pauta) VALUES (" & BLC_DEF & "," & IdPauta & "), (" & BLC_DEF & "," & IdPauta & ");"
                    db.ExecuteInstruc(StrLisPauta)
                    'si s'ha de penjar crear item al logger
                    If Me.chkPubliPodcast.Checked = True Then
                        Dim SqlLogger As String = ""
                        SqlLogger = "INSERT INTO prglogger (log_bitrate, log_samplerate, log_canals"
                        SqlLogger = SqlLogger & ", log_saveprg, log_tipassig, log_datereg"
                        SqlLogger = SqlLogger & ", log_durada, log_defrec, log_program, log_publiweb"
                        SqlLogger = SqlLogger & ") VALUES "
                        SqlLogger = SqlLogger & " ( '192'"
                        SqlLogger = SqlLogger & ", '44100'"
                        SqlLogger = SqlLogger & ", 2"
                        SqlLogger = SqlLogger & ", 1"
                        SqlLogger = SqlLogger & ", " & TipAssig.ToString
                        SqlLogger = SqlLogger & ", '" & data.ToString("yyyy-MM-dd HH:mm:ss") & "'"
                        SqlLogger = SqlLogger & ", '" & Durada.ToString("HH:mm:ss") & "'"
                        SqlLogger = SqlLogger & ", 1"
                        SqlLogger = SqlLogger & ", " & IdPrograma
                        SqlLogger = SqlLogger & ", 1"
                        SqlLogger = SqlLogger & ")"
                        NewIDLogger = db.New_ID(SqlLogger)
                    End If
                End If
                ' comprovar que la data no existeixi ja al calendari i al logger.
                'Si és així simplement fer un update.	
                Dim log_id_exist As Integer = 0
                Dim cal_id_exist As Integer = 0
                Dim dtTable As DataTable = db.getTable("SELECT cal_id, cal_logger FROM calendari where cal_data= '" & data.ToString("yyyy-MM-dd HH:mm:ss") & "';")
                If dtTable.Rows.Count > 0 Then
                    log_id_exist = dtTable.Rows(0)("cal_logger")
                    cal_id_exist = dtTable.Rows(0)("cal_id")
                End If

                'Programar logger				
                If Me.chk_reclogger.Checked = True And Me.chk_reclogger.Visible = True Then
                    Dim SqlLogger As String = ""
                    If log_id_exist > 0 Then
                        SqlLogger = " UPDATE prglogger SET" &
                            " log_saveprg=" & CShort(IIf(IdPrograma > 0, 1, 0)) &
                            ", log_tipassig=" & TipAssig.ToString &
                            ", log_datereg='" & data.ToString("yyyy-MM-dd HH:mm:ss") & "' " &
                            ", log_durada='" & Durada.ToString("HH:mm:ss") & "'" &
                            ", log_program=" & IdPrograma &
                            ", log_publiweb=" & CShort(IIf(Me.chk_podcast.Checked, 1, 0)) &
                            " WHERE log_id=" & log_id_exist & " ;"
                        db.Update_ID(SqlLogger)
                    Else
                        SqlLogger = "INSERT INTO prglogger (log_bitrate, log_samplerate, log_canals"
                        SqlLogger = SqlLogger & ", log_saveprg, log_tipassig, log_datereg"
                        SqlLogger = SqlLogger & ", log_durada, log_defrec, log_program, log_publiweb"
                        Dim NumHoresRE As Integer = Me.txtHoresReemissio.Text
                        If NumHoresRE > 0 Then SqlLogger = SqlLogger & ", log_re, log_retipassig, log_redata"
                        SqlLogger = SqlLogger & ") VALUES "
                        SqlLogger = SqlLogger & " ( '192'"
                        SqlLogger = SqlLogger & ", '44100'"
                        SqlLogger = SqlLogger & ", 2"
                        SqlLogger = SqlLogger & ", 1"
                        SqlLogger = SqlLogger & ", " & TipAssig.ToString
                        SqlLogger = SqlLogger & ", '" & data.ToString("yyyy-MM-dd HH:mm:ss") & "'"
                        SqlLogger = SqlLogger & ", '" & Durada.ToString("HH:mm:ss") & "'"
                        SqlLogger = SqlLogger & ", 1"
                        SqlLogger = SqlLogger & ", " & IdPrograma
                        SqlLogger = SqlLogger & ", " & CShort(IIf(Me.chk_podcast.Checked, 1, 0))
                        If NumHoresRE > 0 Then
                            SqlLogger = SqlLogger & ", 1"
                            SqlLogger = SqlLogger & ", " & TipAssig.ToString
                            SqlLogger = SqlLogger & ", '" & data.AddHours(NumHoresRE).ToString("yyyy-MM-dd HH:mm:ss") & "'"
                        End If
                        SqlLogger = SqlLogger & ")"
                        NewIDLogger = db.New_ID(SqlLogger)
                    End If
                Else
                    'borrem el logger ja que ara no està assignat.
                    db.Delete_ID("DELETE FROM prglogger WHERE log_id = " & log_id_exist & ";")
                End If
                If Me.chkPubliPodcast.Checked = True And RadioButtonPrg.Checked = True And IsFromCloud = False Then
                    Try
                        ReDim Preserve StrSqlPodCast(StrSqlPodCast.Length + 1)
                    Catch ex As Exception
                        ReDim Preserve StrSqlPodCast(0)
                    End Try
                    Dim NomPrograma As String = getNomProgramaFromSession(Me.ComboBoxProgrames.SelectedValue)
                    Dim NameFitxerPotcast As String = RemoveInvalidFileNameChars(NomPrograma & "-" & Now.ToString("yyyyMMdd")).Replace(" ", "_") & ".mp3"
                    StrSqlPodCast(StrSqlPodCast.Length - 1) = "INSERT INTO podcasting (pod_tipusfitxer, pod_id_origen, pod_durada,pod_datacreacio, pod_datapubli, pod_dataout, pod_descrip, pod_file) " &
                        "VALUES ( 5, " & IdSession & ",'" & Durada.ToString("HH:mm:ss") & "','" & Now.ToString("yyyy-MM-dd HH:mm:ss") & "','" & data.ToString("yyyy-MM-dd") & "','" & data.AddDays(cloud.DiesPermanenciaPodcast).ToString("yyyy-MM-dd") & "','" & Descrip & "', '" & NameFitxerPotcast & "');"
                End If
                If cal_id_exist > 0 Then
                    Dim strUpdt As String = "UPDATE calendari SET"
                    strUpdt += " cal_data ='" & data.ToString("yyyy-MM-dd HH:mm:ss") & "' "
                    strUpdt += ", cal_tipassig = " & TipAssig.ToString
                    strUpdt += ", cal_prgtipus = " & TipProgram
                    strUpdt += ", cal_pauta = " & IdPauta.ToString
                    strUpdt += ", cal_pathpauta ='" & AddSlashes(FitxPauta) & "'"
                    strUpdt += ", cal_noticies = " & IIf(BolNoticies = True, 1, 0)
                    strUpdt += ", cal_descripcio ='" & AddSlashes(Descrip) & "'"
                    strUpdt += ", cal_prog = " & IdPrograma.ToString
                    strUpdt += ", cal_durada ='" & Durada.ToString("HH:mm:ss") & "'"
                    strUpdt += ", cal_reemissio = " & IIf(IsReemissio = True, 1, 0)
                    strUpdt += ", cal_force = " & IIf(ForceDirecte = True, 1, 0)
                    strUpdt += ", cal_cloud = " & IIf(IsFromCloud = True, 1, 0)
                    strUpdt += " WHERE cal_id = " & cal_id_exist & " ;"

                    db.Update_ID(strUpdt)
                Else
                    If strValues.Length > 0 Then strValues = strValues & ","
                    strValues = strValues & " ( '" & data.ToString("yyyy-MM-dd HH:mm:ss") & "'"
                    strValues = strValues & ", " & TipAssig.ToString
                    strValues = strValues & ", " & CInt(TipProgram)
                    strValues = strValues & ", " & IdPauta.ToString
                    strValues = strValues & ", '" & AddSlashes(FitxPauta) & "'"
                    strValues = strValues & ", " & CShort(IIf(BolNoticies, 1, 0))
                    strValues = strValues & ", '" & AddSlashes(Descrip) & "'"
                    strValues = strValues & ", " & IdPrograma.ToString
                    strValues = strValues & ", '" & Durada.ToString("HH:mm:ss") & "'"
                    strValues = strValues & ", " & CShort(IIf(IsReemissio, 1, 0))
                    strValues = strValues & ", " & NewIDLogger
                    strValues = strValues & ", " & CShort(IIf(ForceDirecte, 1, 0))
                    strValues = strValues & ", " & CShort(IIf(IsFromCloud, 1, 0))
                    strValues = strValues & ")"
                End If
                If TipAssig = Tipus_AssigDataCalendari.PROGRAM_DIA_SETMANA_HORA Then
                    Do
                        data = data.AddDays(1)
                        If data.DayOfWeek = DayOfWeek.Monday And Me.chk_Dlls.Checked Then Exit Do
                        If data.DayOfWeek = DayOfWeek.Tuesday And Me.chk_Dmrs.Checked Then Exit Do
                        If data.DayOfWeek = DayOfWeek.Wednesday And Me.chk_Dmres.Checked Then Exit Do
                        If data.DayOfWeek = DayOfWeek.Thursday And Me.chk_Djs.Checked Then Exit Do
                        If data.DayOfWeek = DayOfWeek.Friday And Me.chk_Dvs.Checked Then Exit Do
                        If data.DayOfWeek = DayOfWeek.Saturday And Me.chk_Dssap.Checked Then Exit Do
                        If data.DayOfWeek = DayOfWeek.Sunday And Me.chk_Dge.Checked Then Exit Do
                    Loop
                Else
                    data = data.AddDays(1)
                End If
                Try
                    ProgressBar.Value = ProgressBar.Value + 1
                Catch ex As Exception
                    ProgressBar.Maximum = ProgressBar.Value + 1
                End Try

                My.Application.DoEvents()
                'Salvar 7 dies en 7 dies
                If (DateDiff(DateInterval.Day, Me.txtDataIn.Value, data) Mod 7) = 0 Then
                    NewID = db.New_ID(StrInsertCal & strValues & " ;")
                    strValues = ""
                End If
            Loop
            If strValues.Length > 0 Then NewID = db.New_ID(StrInsertCal & strValues & " ;")
            Me.lbID.Text = NewID.ToString
            ProgressBar.Visible = False
            My.Application.DoEvents()
        Else
            'data = New Date(MonthCalendar1.SelectionStart.Year, MonthCalendar1.SelectionStart.Month, MonthCalendar1.SelectionStart.Day, Me.cmbHores.SelectedValue, 0, 0)
            Dim calID As Integer = Me.lbID.Text
            StrSql = "UPDATE calendari SET"
            StrSql = StrSql & " cal_data ='" & data.ToString("yyyy-MM-dd HH:mm:ss") & "' "
            StrSql = StrSql & ", cal_tipassig = " & TipAssig.ToString
            StrSql = StrSql & ", cal_prgtipus = " & TipProgram
            StrSql = StrSql & ", cal_pauta = " & IdPauta.ToString
            StrSql = StrSql & ", cal_pathpauta ='" & AddSlashes(FitxPauta) & "'"
            StrSql = StrSql & ", cal_noticies = " & IIf(BolNoticies = True, 1, 0)
            StrSql = StrSql & ", cal_descripcio ='" & AddSlashes(Descrip) & "'"
            StrSql = StrSql & ", cal_prog = " & IdPrograma.ToString
            StrSql = StrSql & ", cal_durada ='" & Durada.ToString("HH:mm:ss") & "'"
            StrSql = StrSql & ", cal_reemissio = " & IIf(IsReemissio = True, 1, 0)
            StrSql = StrSql & ", cal_force = " & IIf(ForceDirecte = True, 1, 0)
            StrSql = StrSql & " WHERE cal_id = " & calID & " ;"
            db.Update_ID(StrSql)
            Dim IDLogger As Integer = Me.lbIDLogger.Text
            If IDLogger > 0 Then
                'fer un update també del logger associat.
                StrSql = "UPDATE prglogger SET" &
                    " log_saveprg=" & CShort(IIf(IdPrograma > 0, 1, 0)) &
                    ", log_tipassig=" & TipAssig.ToString &
                    ", log_datereg='" & data.ToString("yyyy-MM-dd HH:mm:ss") & "' " &
                    ", log_durada='" & Durada.ToString("HH:mm:ss") & "'" &
                    ", log_program=" & IdPrograma &
                    ", log_publiweb=" & CShort(IIf(Me.chk_podcast.Checked, 1, 0)) &
                    " WHERE log_id=" & IDLogger & " ;"
                db.Update_ID(StrSql)
            End If
        End If
        db.EndTransaction()

        'RefreshDataSet(TAULES_DBS.TAULA_CALENDARI)
        BuscaItemsCalendari()
        LockedRecord(True)
        If IsNothing(StrSqlPodCast) = False AndAlso StrSqlPodCast.Length > 0 Then
            Dim NewIdPod(StrSqlPodCast.Length - 1) As Integer
            For i As Integer = 0 To StrSqlPodCast.Length - 1
                'For Each Str As String In StrSqlPodCast
                NewIdPod(i) = db.New_ID(StrSqlPodCast(i))
            Next
            If IsLoadForm("frmPodcast") = False Then frmPodCast.Show()
            frmPodCast.AutomaticUploadFitxer(NewIdPod)
        End If
        db = Nothing
        If IsLoadForm("frmPrgLogger") = True Then frmPrgLogger.BuscaItemsCalendari()
    End Sub

    Private Sub cmdSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalvar.Click
		SaveRecord()
	End Sub

    Private Sub DeleteRecord()
        If MetroFramework.MetroMessageBox.Show(Me, MSG_SURE_DEL_ITEM, MSG_ATENCIO, MessageBoxButtons.YesNo, MessageBoxIcon.Error, 100) = MsgBoxResult.Yes Then
            'si és un programa en diferit esborrem la alguna pauta relacionada.
            Dim db As New MSC.dbs(Cloud)
            Dim SqlStr As String = ""
            Dim TipProgram As Tipus_Emissio = CType(Me.cmbTipProg.SelectedValue, Tipus_Emissio)
            If TipProgram = Tipus_Emissio.TIP_AUTOMATIC AndAlso Me.RadioButtonPrg.Checked = True Then
                Dim pauta_id As Integer = CInt(Me.lbIDPauta.Text)
                SqlStr = "DELETE FROM listpautes WHERE `listpauta_id`=" & pauta_id & " ;"
                If pauta_id > 1 Then db.Delete_ID(SqlStr)
            End If

            SqlStr = "DELETE FROM calendari WHERE cal_id = " & Me.lbID.Text & " ;"
            Dim RowsAfect As Integer = db.Delete_ID(SqlStr)
            addCtlRadi(0, CShort(Tipus_Play.CTL_SQL), 0, "00:00:00", 0, 0, Usuari.UsrID, SqlStr, 0, False)
            db = Nothing
            MetroFramework.MetroMessageBox.Show(Me, String.Format(MSG_END_DEL_ROWS_AFECTATS, RowsAfect), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information, 100)
            blEnable = True
            LockedRecord()
            NetejaPantalla()
            BuscaItemsCalendari()
        End If
    End Sub

    Private Sub ShowCalendarFromID(ByVal ID As Integer)
		'TODO: fer les consultes al dataset general (dsClient.Tables("calendari").Select(sCmd))
		
		Dim StrSql As String = "SELECT * FROM calendari WHERE cal_id = " & ID
        Dim db As New MSC.dbs(Cloud)
        Dim calRs As DataTable = db.getTable(StrSql)
		
		'Omplir pantalla
		Me.lbID.Text = calRs.Rows(0)("cal_id").ToString
		Dim Data As Date = CDate(calRs.Rows(0)("cal_data").ToString)
		Me.txtHoraIni.Value = calRs.Rows(0)("cal_data").ToString
		Me.txtDataIn.Value = Data
		Me.optionData.Checked = (calRs.Rows(0)("cal_tipassig") = 1)
		Me.optionSemana.Checked = (calRs.Rows(0)("cal_tipassig") = 0)
		Me.cmbTipProg.SelectedValue = calRs.Rows(0)("cal_prgtipus")
		Dim IdPauta As Integer = CInt(calRs.Rows(0)("cal_pauta"))
		lbIDPauta.Text = IdPauta
		Me.cmbListPauta.SelectedValue = IdPauta
		Me.txtPauta.Text = StripSlashes(calRs.Rows(0)("cal_pathpauta").ToString)
		Me.chkBolNoticies.Checked = CBool(calRs.Rows(0)("cal_noticies"))
		Me.txtDescrip.Text = StripSlashes(calRs.Rows(0)("cal_descripcio").ToString)
		Me.cmbProgrames.SelectedValue = calRs.Rows(0)("cal_prog")
		Dim Durada As TimeSpan = calRs.Rows(0)("cal_durada")
		Me.txtDurada.Value = New Date(1970, 1, 1, Durada.Hours, Durada.Minutes, Durada.Seconds)
		Me.lbIDLogger.Text  = calRs.Rows(0)("cal_logger")
		Me.chk_Force.Checked = calRs.Rows(0)("cal_force")
		Me.chk_FromCloud.Checked = calRs.Rows(0)("cal_cloud")
		chkRemissio.Checked = calRs.Rows(0)("cal_reemissio")
		
		Me.Text = CAPTION_TEXT & " (" & Data.ToLongDateString & " " & Data.ToShortTimeString & ")"
		If calRs.Rows(0)("cal_pathpauta").ToString.Length > 3 Then
			RadioButtonList.Checked = True
			Me.txtPauta.Text = StripSlashes(calRs.Rows(0)("cal_pathpauta").ToString)
		Else
			'Buscar segons el ID de la pauta la resta d'informació			
			StrSql = "SELECT listpauta_sessio FROM listpautes WHERE listpauta_id=" & IdPauta & " ;"
			Dim IdSessio As Integer = db.ExecuteScalar(StrSql)
			If chk_FromCloud.Checked = True Then
				Me.cmbProgramesCloud.SelectedValue = calRs.Rows(0)("cal_prog")				
				Me.RadioButtonPrg.Checked = True				
				lbPendentBaixar.Visible = (IdSessio = -1)
			Else								
				If IdSessio > 0 Then
					OmplircomboBoxProgramSessions(ComboBoxProgrames)
					Me.ComboBoxProgrames.SelectedValue = IdSessio					
					Me.RadioButtonPrg.Checked = True
'					If IdSessio > 0 Then
'						Me.RadioButtonPrg.Checked = True
'					Else
'						Me.RadioButtonRF.Checked = True
'						'Me.cmbListPauta.SelectedValue = IdPauta
'					End If
				Else
					Me.RadioButtonRF.Checked = True
					'Me.cmbListPauta.SelectedValue = IdPauta
				End If				
			End If			
		End If
		db = Nothing		
		Me.cmdSalvar.Enabled = False
	End Sub
	
	
	Private Sub cmdDelCalendar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelCalendar.Click
		Try
			frmDelCalendar.Show(Me)	
		Catch ex As Exception	
			frmDelCalendar.WindowState = FormWindowState.Normal
		End Try
		
	End Sub
	
	Private Sub cmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDel.Click
		DeleteRecord()
	End Sub
	
	Private Sub txtDescrip_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescrip.TextChanged
		Changed()
	End Sub
	
	Private Sub RadioButtonAutomat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
		RadioButtonRF.CheckedChanged, RadioButtonPrg.CheckedChanged, RadioButtonList.CheckedChanged
		Select Case CType(sender, RadioButton).Name
			Case "RadioButtonRF"
				Me.GroupBoxRF.Visible = True
				Me.GroupBoxPrg.Visible = False
				Me.GroupBoxList.Visible = False
			Case "RadioButtonPrg"
				Me.GroupBoxRF.Visible = False
				Me.GroupBoxPrg.Visible = True
				Me.GroupBoxList.Visible = False
			Case "RadioButtonList"
				Me.GroupBoxRF.Visible = False
				Me.GroupBoxPrg.Visible = False
				Me.GroupBoxList.Visible = True
		End Select
		Changed()
		
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
	
	Private Sub chk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
		chk_Dlls.CheckedChanged, chk_Dge.CheckedChanged, chk_Djs.CheckedChanged, _
		chk_Dmres.CheckedChanged, chk_Dmrs.CheckedChanged, chk_Dssap.CheckedChanged, _
		chk_Dvs.CheckedChanged
		Changed()
	End Sub
	
	Private Sub NewPanelProgramacio(ByVal IdCalendar As Integer, ByVal NomProg As String, ByVal DataProg As Date, ByVal Duration As Integer, ByVal TipProgramació As Tipus_Emissio, ByVal TipAssig As Integer, ByVal toolTip As String, ByVal FromLogger As Boolean)
		
		Dim PanelPrgramacio As New Panel
		PanelPrgramacio.Visible = False
		PanelPrgramacio.Name = IdCalendar & "-" & DataProg.ToString
		Dim LbLink As New LinkLabel
		LbLink.Name = "LbLink"
		LbLink.Text = NomProg
		LbLink.Tag = IdCalendar
		LbLink.TextAlign = ContentAlignment.MiddleCenter
		LbLink.Parent = PanelPrgramacio
		LbLink.Dock = DockStyle.Fill
		LbLink.BackColor = Color.Transparent 
		If FromLogger = False Then AddHandler LbLink.Click, AddressOf ClikOnlink
		Me.ToolTip1.SetToolTip(LbLink, toolTip)
		Me.ToolTip1.SetToolTip(PanelPrgramacio, toolTip)
		
		Dim lbDurada As New Label
		lbDurada.Name = "lbDurada"
		lbDurada.Text = Duration
		lbDurada.Visible = False
		lbDurada.Parent = PanelPrgramacio
		lbDurada.BackColor = Color.Transparent
		
		Dim lbDataProg As New Label
		lbDataProg.Name = "lbDataProg"
		lbDataProg.Text = DataProg
		lbDataProg.Visible = False
		lbDataProg.Parent = PanelPrgramacio
		
		If TipProgramació = Tipus_Emissio.TIP_AUTOMATIC Then 			
			PanelPrgramacio.BackgroundImage = Me.picCalVerd.Image 		
		ElseIf TipProgramació = Tipus_Emissio.TIP_CONEX_CENTRAL Then 			
			PanelPrgramacio.BackgroundImage = Me.picCalTaronja.Image 
		ElseIf TipProgramació = Tipus_Emissio.TIP_DIRECTE Then 						
			PanelPrgramacio.BackgroundImage = Me.picCalBlau.Image 
		End If
		If FromLogger = True Then			
			PanelPrgramacio.BackgroundImage = Me.picCalLila.Image 
		End If
		
		PanelPrgramacio.BackgroundImageLayout = ImageLayout.Stretch
		PanelPrgramacio.Parent = Me.picCalendar
		 
		'PintaItemsCalendar()
	End Sub
	
	Private Sub ClikOnlink(ByVal sender As System.Object, ByVal e As System.EventArgs)
		Dim id As Integer = CType(sender, LinkLabel).Tag
		ShowCalendarFromID(id)
	End Sub
	
	Private Sub txtDurada_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDurada.ValueChanged
		Changed()
	End Sub
	
	Private Sub txtDataIn_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDataIn.ValueChanged
		Changed()
		txtDataOut.MinDate = txtDataIn.Value
	End Sub

    Private Sub txtDataOut_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDataOut.ValueChanged
        Changed()
    End Sub

    Private Sub cmdCapturaDuradaPrg_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCapturaDuradaPrg.Click
		Dim Durada As TimeSpan = getDuradaPrograma(cmbProgrames.SelectedValue)
		
		txtDurada.Value = New Date(1970, 1, 1, Durada.Hours, Durada.Minutes, Durada.Seconds)
		'	If Durada.TotalMinutes < 60 Then
		'		txtDurada.Value = New Date(1970, 1, 1, 1, 0, 0)
		'	Else
		'		txtDurada.Value = New Date(1970, 1, 1, Durada.Hours, Durada.Minutes, Durada.Seconds)
		'	End If
	End Sub
	
	Private Sub cmdCapturaDuradaSessio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCapturaDuradaSessio.Click
		Dim IdSession As Integer = ComboBoxProgrames.SelectedValue
		Dim StrSql As String = "SELECT ses_durada FROM prg_sessions WHERE ses_id=" & IdSession & " OR ses_sessiomare=" & IdSession & " ;"

        Dim db As New MSC.dbs(Cloud)
        Dim DT As DataTable = db.getTable(StrSql)
		Dim seg As Integer = 0
		For i As Integer = 0 To DT.Rows.Count - 1
			Dim Durada As TimeSpan = DT.Rows(i)("ses_durada")
			seg += Durada.TotalSeconds
		Next
		If seg < 3600 Then seg = 3600
		Try
			txtDurada.Value = New Date(1970, 1, 1, 0, 0, 0).AddSeconds(seg)	
		Catch ex As Exception
			txtDurada.Value = New Date(1970, 1, 1, 23, 59, 0)		
		End Try
		
		DT.Dispose()
		db = Nothing
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
	
	Private Sub PintaDies()
		If ShowCalendar = listCalendar.Setmana Then
			Dim Monday As Date = Me.dtpDataRadi.Value.AddDays(-Weekday(Me.dtpDataRadi.Value, FirstDayOfWeek.Monday) + 1)
			For i As Integer = 0 To 6
				Try
					Dim labelDia As Label = CType(pnlDies.Controls(i), Label)
					
					Dim x As Integer = ((pnlDies.Width / 7) * i)
					labelDia.Location = New Point(x, 5)
					labelDia.Size = New Size((pnlDies.Width / 7), 13)
                    Monday.AddDays(i).ToString("dd")
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
					If DateDiff(DateInterval.Day, DataLabel, Me.dtpDataRadi.Value) = 0 Then
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
			labelDia2.Text = Me.dtpDataRadi.Value.ToString("dddd") & " ( " & Me.dtpDataRadi.Value.ToString("d  MMM") & ") "
			labelDia2.Location = New Point((pnlDies.Width / 3), 5)
			labelDia2.Size = New Size((pnlDies.Width / 3), 13)
		End If
		pnlDies.Refresh()
		
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
				'g.DrawString(str, New Font("Tahoma", 8), Brushes.Black, 0, y - 6)
				g.DrawString(str,  new Font("Microsoft Sans Serif", 8, FontStyle.Regular ), Brushes.Black, 0, y - 6)
			Else
				g.DrawLine(p, picHores.Width - 4, y, picHores.Width, y)
			End If
			y = y + UnitatTemps
		Loop
		
		
		If Not p Is Nothing Then
			p.Dispose()
		End If
		If Not g Is Nothing Then
			g.Dispose()
		End If
		
		Me.picHores.Image = bitmap
	End Sub
	
	Friend Sub BuscaItemsCalendari()
		' Buscar la pauta per tot el dia seleccionat
		Dim toolTip As String = ""
		Dim Nom As String = ""
		Dim dateIni As Date
		Dim Durada As TimeSpan
		Dim TipAssg As Integer
		Dim StrSql As String = ""
		Dim dTable As DataTable = Nothing
        Dim db As New MSC.dbs(Cloud)

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.AppStarting
		picCalendar.Controls.Clear()
		
		PintaDies()


        Dim dataRadi As Date = New Date(dtpDataRadi.Value.Year, dtpDataRadi.Value.Month, dtpDataRadi.Value.Day, 0, 0, 0)
        'Dim WeekOfYear As Integer = System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetWeekOfYear(dataRadi, System.Globalization.CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday)

        Dim dayDiff As Integer = Weekday(dataRadi, FirstDayOfWeek.Monday) - DayOfWeek.Monday
        Dim Dilluns As Date = dataRadi.AddDays(-dayDiff)
        Dim Diumenge As Date = Dilluns.AddDays(6)

        'Busca les programacions futures del Logger
        If Me.mnu_add_logger.Checked = True Then
            If ShowCalendar = listCalendar.Setmana Then
                StrSql = "SELECT log_datereg, log_id, log_redata, log_retipassig,log_program, log_durada FROM prglogger WHERE (date(log_redata) BETWEEN '" & Dilluns.ToString("yyyy-MM-dd") & "' AND '" & Diumenge.ToString("yyyy-MM-dd") & "' ) AND log_re=1"
            Else
                StrSql = "SELECT log_datereg, log_id, log_redata, log_retipassig,log_program, log_durada FROM prglogger WHERE date(log_redata) =  '" & dataRadi.ToString("yyyy-MM-dd") & "' AND log_re=1"
            End If
			Dim Ara As Date = New Date(Now.Year, Now.Month, Now.Day, 0, 0, 0)
			If dataRadi <= Ara Then StrSql += " AND ADDTIME(log_datereg,log_durada) > NOW()"
			StrSql += " ORDER BY log_redata ASC"
			
			dTable = db.getTable(StrSql)
			For e As Integer = 0 To dTable.Rows.Count - 1
				Dim LogID As Integer = dTable.Rows(e)("log_id")
				Nom = getNomPrograma(dTable.Rows(e)("log_program"))
				dateIni = dTable.Rows(e)("log_redata")
				Durada = dTable.Rows(e)("log_durada")
				TipAssg = dTable.Rows(e)("log_retipassig")
                'TODO: Translate string
                toolTip = Nom
                toolTip += vbCrLf & "Hora inici: " & dateIni.ToLongTimeString &
                    vbCrLf & "Hora final: " & dateIni.AddMinutes(Durada.TotalMinutes).ToLongTimeString &
                    vbCrLf & "Tipus d'assignació: " & IIf(TipAssg = 1, "Per una data concreta", "Per un dia de la setmana") &
                    vbCrLf & "Tipus programació: Reemissió del programa" &
                    vbCrLf & "ATENCIÓ: Futura programació provinent del Logger " &
                    vbCrLf & "i del ítem amb data " & dTable.Rows(e)("log_datereg").ToString &
                    vbCrLf & "(no es visualitzarà el detall de la informació)"

                NewPanelProgramacio(LogID, Nom, dateIni, Durada.TotalMinutes, 5, TipAssg, toolTip, True)
				Sleep(10)
				My.Application.DoEvents()
			Next			
		End If
		Dim StrWhere As String = ""
        If ShowCalendar = listCalendar.Setmana Then
            StrWhere = " (date(cal_data) BETWEEN '" & Dilluns.ToString("yyyy-MM-dd") & "' AND '" & Diumenge.ToString("yyyy-MM-dd") & "')"
        Else
            StrWhere = " date(cal_data) =  '" & dataRadi.ToString("yyyy-MM-dd") & "'"            
		End If
		If Me.mnu_pgr_automat.Checked = False Or Me.mnu_prg_connex.Checked = False Or Me.mnu_prg_direct.Checked = False Then
			Dim ValorsSelect As String = ""
			If Me.mnu_pgr_automat.Checked Then ValorsSelect = Tipus_Emissio.TIP_AUTOMATIC
			If Me.mnu_prg_connex.Checked Then
				If ValorsSelect.Length > 0 Then ValorsSelect &= ","
				ValorsSelect &= Tipus_Emissio.TIP_CONEX_CENTRAL
			End If
			If Me.mnu_prg_direct.Checked Then
				If ValorsSelect.Length > 0 Then ValorsSelect &= ","
				ValorsSelect &= Tipus_Emissio.TIP_DIRECTE
			End If
			StrWhere &= " AND cal_prgtipus IN (" & ValorsSelect & ")"
		End If
		StrSql = "SELECT cal_id, cal_data, cal_tipassig, cal_prgtipus, cal_pauta, cal_pathpauta, cal_prog, cal_durada, cal_descripcio FROM calendari WHERE " & StrWhere & " ORDER BY cal_data ASC"
		dTable = db.getTable(StrSql)
		For i As Integer = 0 To dTable.Rows.Count - 1
			Dim CalID As Integer = dTable.Rows(i)("cal_id")
			Dim TipProg As Tipus_Emissio = CType(dTable.Rows(i)("cal_prgtipus"), Tipus_Emissio)
			
			Dim Descrip As String = dTable.Rows(i)("cal_descripcio").ToString
			Select Case TipProg
				Case Tipus_Emissio.TIP_AUTOMATIC
					If dTable.Rows(i)("cal_pathpauta").ToString.Length > 0 Then
						Nom = GetFileName(dTable.Rows(i)("cal_pathpauta").ToString)
					Else
						RefreshDataSet(TAULES_DBS.TAULA_PAUTES)
						Nom = getNomPauta(dTable.Rows(i)("cal_pauta"))
					End If
				Case Tipus_Emissio.TIP_CONEX_CENTRAL : Nom = "Connexió Central"
				Case Tipus_Emissio.TIP_DIRECTE : Nom = getNomPrograma(dTable.Rows(i)("cal_prog"))
			End Select
			
			TipAssg = dTable.Rows(i)("cal_tipassig")
			'Dim BorStyle As Boolean = True
			dateIni = dTable.Rows(i)("cal_data")
			Durada = dTable.Rows(i)("cal_durada")
			toolTip = Nom
			If Descrip.Length Then toolTip += vbCrLf & "Descripció: " & Descrip
			toolTip += vbCrLf & "Hora inici: " & dateIni.ToLongTimeString & _
				vbCrLf & "Hora final: " & dateIni.AddMinutes(Durada.TotalMinutes).ToLongTimeString & _
				vbCrLf & "Tipus d'assignació: " & IIf(TipAssg = 1, "Per una data concreta", "Per un dia de la setmana") & _
				vbCrLf & "Tipus programació: " & getNomTipusProgramacio(TipProg)
			'vbCrLf & "Identificador: " & CalID
			NewPanelProgramacio(CalID, Nom, dateIni, Durada.TotalMinutes, TipProg, TipAssg, toolTip, False)
			Sleep(10)
			My.Application.DoEvents()
		Next
		PintaItemsCalendar()
		dTable.Dispose()		
		db = Nothing
		System.Windows.Forms.Cursor.Current = Cursors.Default
		
	End Sub
	
	Private Sub PintaItemsCalendar()
		For Each MyPanel As Control In picCalendar.Controls
			If (TypeOf MyPanel Is Panel) Then
				MyPanel.Visible = True
				Static Old_date As Date
				Dim desplaca As Integer = 0 
				Dim Duration As Integer = CInt(CType(MyPanel.Controls("lbDurada"), Label).Text)
				Dim DataProg As Date = CDate(CType(MyPanel.Controls("lbDataProg"), Label).Text)
				If Old_date = DataProg Then
					desplaca = 1
				Else
					desplaca = 0
				End if
				Old_date = DataProg	
				Dim nd As Short = 3
				If ShowCalendar = listCalendar.Setmana Then nd = 7
				MyPanel.Size = New Size((UnitatDies * nd) - (MargeItems * 2), Duration * UnitatMin)
				
				Dim x As Integer = (picCalendar.Width / 3) + 2
				If ShowCalendar = listCalendar.Setmana Then x = PuntIniXDies(Weekday(DataProg, FirstDayOfWeek.Monday) - 1)
				
				Dim y As Integer = (DataProg.Hour * 60 + DataProg.Minute) * UnitatMin + (UnitatMin * 30)
				MyPanel.Location = New Point(x+ desplaca, y)
			End If
		Next		
	End Sub
	
	Private Sub cmdActual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdActual.Click
		Me.dtpDataRadi.Value = Now
	End Sub
	
	Private Sub cmdPost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPost.Click
		If ShowCalendar = listCalendar.Setmana Then
			Me.dtpDataRadi.Value = Me.dtpDataRadi.Value.AddDays(7)
		Else
			Me.dtpDataRadi.Value = Me.dtpDataRadi.Value.AddDays(1)
		End If
	End Sub
	
	Private Sub cmdAnt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnt.Click
		If ShowCalendar = listCalendar.Setmana Then
			Me.dtpDataRadi.Value = Me.dtpDataRadi.Value.AddDays(-7)
		Else
			Me.dtpDataRadi.Value = Me.dtpDataRadi.Value.AddDays(-1)
		End If
	End Sub
	
	Private Sub dtpDataRadi_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDataRadi.ValueChanged
		BuscaItemsCalendari()
	End Sub
	
	Private Sub frmCalendari_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
		Try
			PintaDies()			
			PintaCalendar()
		Catch ex As Exception
		End Try
	End Sub
	
	Private Sub PictureBoxCalendar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBoxCalendar.Click
		
		ToolTip1.RemoveAll()
		If ShowCalendar = listCalendar.Dia Then
			PictureBoxCalendar.Image = Me.ImageListCalendar.Images(2)
			'           PictureBoxCalendar.Tag = 1
			ShowCalendar = listCalendar.Setmana
			ToolTip1.SetToolTip(cmdAnt, cmdAnt_Setmana_ToolTip)
			ToolTip1.SetToolTip(cmdActual, cmdActual_ToolTip)
			ToolTip1.SetToolTip(cmdPost, cmdPost_Setmana_ToolTip)		
		Else
			PictureBoxCalendar.Image = Me.ImageListCalendar.Images(1)
			'          PictureBoxCalendar.Tag = 2
			ShowCalendar = listCalendar.Dia
			ToolTip1.SetToolTip(cmdAnt, cmdAnt_Dia_ToolTip)
			ToolTip1.SetToolTip(cmdActual, cmdActual_ToolTip)
			ToolTip1.SetToolTip(cmdPost, cmdPost_Dia_ToolTip)
		End If
		PintaHores()
		PintaCalendar()
		BuscaItemsCalendari()
	End Sub
	
	
	Private Sub mnu_Help_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_Help.Click
		Dim Proces As Process = New Process
		Try
			Process.Start(MSC.Help.HELP_GEST_AUTOMATITZACIO_CALENDARI.ToString)
		Catch ex As Exception
		End Try
	End Sub
	
	Private Sub txtHoresReemissio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHoresReemissio.KeyPress
		Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
		If KeyAscii < Asc("0") Or KeyAscii > Asc("9") Then If KeyAscii <> 8 Then KeyAscii = 0
		e.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			e.Handled = True
		End If
	End Sub
	
	Private Sub chk_reclogger_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_reclogger.CheckedChanged
		GroupBoxReemissio.Visible = chk_reclogger.Checked
	End Sub
	
	Private Sub txtHoresReemissio_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtHoresReemissio.LostFocus
		If txtHoresReemissio.Text.Length = 0 Then txtHoresReemissio.Text = 0
	End Sub
	
	Private Sub mnu_add_logger_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_add_logger.Click
		mnu_add_logger.Checked = Not mnu_add_logger.Checked
		BuscaItemsCalendari()
	End Sub
	
	Private Sub mnu_prg_direct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_prg_direct.Click, mnu_pgr_automat.Click, mnu_prg_connex.Click
		Dim mnu As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
		mnu.Checked = Not mnu.Checked
		If Me.mnu_pgr_automat.Checked = False And Me.mnu_prg_connex.Checked = False And Me.mnu_prg_direct.Checked = False Then
            'Error no visualitzaria res, tornem a establir el check
            MetroFramework.MetroMessageBox.Show(Me, MSG_MINIM_OPTION_FILTER, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
            mnu.Checked = True
			Exit Sub
		End If
		BuscaItemsCalendari()
	End Sub
	
	Private Sub txtHoraIni_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHoraIni.ValueChanged
		Changed()
	End Sub

    Sub ChkRemissioCheckedChanged(sender As Object, e As EventArgs) Handles chkRemissio.CheckedChanged
        Changed()
    End Sub

    Sub TxtHoresReemissio_TextChanged(sender As Object, e As EventArgs) Handles txtHoresReemissio.TextChanged
        Try
            Dim DataIni As Date = New Date(Me.txtDataIn.Value.Year, txtDataIn.Value.Month, txtDataIn.Value.Day, Me.txtHoraIni.Value.Hour, txtHoraIni.Value.Minute, txtHoraIni.Value.Second)
            Me.lbDataRemissio.Text = DataIni.AddHours(txtHoresReemissio.Text).ToString("yyyy-MM-dd HH:mm:ss")
        Catch ex As Exception
            Me.lbDataRemissio.Text = ""
        End Try

    End Sub

    Sub CmbProgramesSelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProgrames.SelectedIndexChanged
        'Si és un programa compartit al núvol és obligatori enregistrar-lo
        Dim prg_id As Integer = cmbProgrames.SelectedValue
        Dim retval As Boolean = IsProgramaShareCloud(prg_id)
        pic_Nuvol.Visible = retval
        Me.chk_reclogger.Checked = retval
        Changed()
    End Sub

    Sub ComboBoxProgramesSelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxProgrames.SelectedIndexChanged
        'Buscar el fitxer
        Try
            Dim ses_id As Integer = ComboBoxProgrames.SelectedValue
            Dim PathFile As String = Params.PathProgrames & "\" & ses_id.ToString & ".mp3"
            picFileNoExist.Visible = Not IO.File.Exists(PathFile)
            Changed()
        Catch ex As Exception
        End Try
    End Sub

    Sub Chk_ForceCheckedChanged(sender As Object, e As EventArgs) Handles chk_Force.CheckedChanged
        Changed()
    End Sub

    Sub Chk_FromCloudCheckedChanged(sender As Object, e As EventArgs) Handles chk_FromCloud.CheckedChanged
        Me.panelPrgCloud.Visible = chk_FromCloud.Checked
        Me.panelPrgLocal.Visible = Not chk_FromCloud.Checked
    End Sub


    Sub ComboBoxProgramesKeyUp(sender As Object, e As KeyEventArgs) Handles ComboBoxProgrames.KeyUp
        Select Case e.KeyCode
            Case Keys.Left, Keys.Right, Keys.Up, Keys.Down, Keys.Back, Keys.ShiftKey, Keys.Return
                Return
        End Select
        If e.Shift = True AndAlso e.KeyCode = Keys.Home Then Return
        If e.Shift = True AndAlso e.KeyCode = Keys.End Then Return
        Dim condi As String = ComboBoxProgrames.Text
        OmplircomboBoxProgramSessions(ComboBoxProgrames, condi)
    End Sub

    Sub ComboBoxProgramesLeave(sender As Object, e As EventArgs) Handles ComboBoxProgrames.Leave
        Dim ses_id As Integer = ComboBoxProgrames.SelectedValue
        If ses_id = 0 Then
            MetroFramework.MetroMessageBox.Show(Me, MSG_SET_SESSIO, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, 100)
            OmplircomboBoxProgramSessions(ComboBoxProgrames)
            'ComboBoxProgrames.Text = ""
            ComboBoxProgrames.Focus()
        End If
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
        'VScrollBarCalendar.Maximum = picHores.Height / 1.2
        PintaHores()
        PintaCalendar()
    End Sub

    Private Sub MetroCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chk_podcast.CheckedChanged
        Changed()
    End Sub

    Private Sub frmCalendari_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        Dim FitxerINI As New IniFile
        frm_sice(0) = Me.Width : frm_sice(1) = Me.Height
        FitxerINI.INIWrite(MyAPP.IniFile, "Data Gest", "size", frm_sice(0).ToString & "," & frm_sice(1).ToString)
    End Sub

    Private Sub GrupDiesSetman_VisibleChanged(sender As Object, e As EventArgs) Handles GrupDiesSetman.VisibleChanged
        If GrupDiesSetman.Visible = True Then
            GroupBoxTP.Location = New Point(13, 139)
            grupAssignar.Size = New Size(411, 495)
            'PanelButlletinsAndDescrip.Size = New Size(310, grupAssignar.Height - 365)
        Else
            GroupBoxTP.Location = New Point(13, 97)
            grupAssignar.Size = New Size(411, 453)
            'PanelButlletinsAndDescrip.Size = New Size(310, grupAssignar.Height - 315)
        End If
        PanelButlletinsAndDescrip.Location = New Point(PanelButlletinsAndDescrip.Location.X, GroupBoxTP.Location.Y + 272)

    End Sub
End Class