Option Strict Off
Option Explicit On
Imports System.Drawing.Drawing2D

Public Class frmTemes
	Dim PathMusica As String = ""
	Dim _bpm As Misc.BPMCounter = New Misc.BPMCounter(20, 44100)
	
	Dim blEnable As Boolean
	Dim blnNouRecord As Boolean
	Dim IsSaving As Boolean = False
	
	Dim OnPauta As Boolean
	Dim gridActual As DataGridView
	
	Private Sub CloseForm()
        If Me.cmdSalvar.Enabled Then
            If MetroFramework.MetroMessageBox.Show(Me, MSG_SAVE_DADES, MSG_ATENCIO, MessageBoxButtons.YesNo, MessageBoxIcon.Information, 100) = DialogResult.Yes Then SaveRecord()
        End If
        If Bass.BASS_ChannelIsActive(StreamHandlePlay) Then Call Bass.BASS_StreamFree(StreamHandlePlay)        
		If IsLoadForm("frmBuscarTemes") = True Then frmBuscarTemes.Close()
        MyAPP.CloseSesionClient(MyAPP.IDSesion_Client, DESCRIP_FORM_TEMES)
    End Sub
	
	Private Sub frmTemes_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		CloseForm()
	End Sub

    Private Sub cmdSortir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSortir.Click, cmdExit.Click
        Me.Close()
    End Sub

    Friend Sub getListTemes(Optional ByRef StrSql As String = "")
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.AppStarting
        gridDades.AllowUserToAddRows = True
        Dim Columns As String = "tema_id, tema_titol,tema_interp, tema_disc, tema_compositor, tema_comentari,tema_pautain, tema_instrument,tema_restric ,tema_forcemaxradi, tema_idioma, tema_temps, tema_subj, tema_ritme, tema_any, tema_intro, tema_durada, tema_numradiacions, tema_datain, tema_dataradiacio, tema_votes "
        Dim Origen As String = "SELECT " & Columns
        Origen = Origen & " FROM   temes"

        If Len(StrSql) > 0 Then
            Origen = Origen & " WHERE " & StrSql
        End If
        If InStr(Origen, "ORDER BY", CompareMethod.Text) = 0 Then Origen = Origen & " ORDER BY temes.tema_id ;"
        Dim db As New MSC.dbs(Cloud)
        'TODO: S'ha de fer StripSlashes(texte)
        gridDades.DataSource = db.getTable(Origen)
        If gridDades.Rows.Count Then
            Me.lbRecCount.Text = gridDades.Rows.Count
            gridDades.Focus()
        Else
            MetroFramework.MetroMessageBox.Show(Me, MSG_NO_ITEM_FOR_CONDITION, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
        End If
        db = Nothing
        'Me.cmdBloqueix.Enabled = IIf(gridTemes.Rows.Count And Usuari.UsrTipus > NivellUsers.USR_CONVIDAT, True, False)
        gridDades.AllowUserToAddRows = False
        Me.cmdBloqueix.Enabled = True
        Me.mnuModif.Enabled = Me.cmdBloqueix.Enabled
        Me.Refresh()
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub BorrarDadesPantalla(ByRef Tots As Boolean)
        On Error Resume Next
        Me.LbID.Text = ""
        Me.txtTitol.Text = ""
        Me.txtComent.Text = ""
        Me.txtRitme.Text = ""
        Me.txtIntro.Text = "00:00:00"
        Me.lbDurada.Text = "00:00:00"
        Me.chkOnPauta.Checked = False
        'Me.cmdOnPauta.Text = LABEL_DESACTIVADA
        'cmdOnPauta.Image = Me.picOutPauta.Image
        OnPauta = False

        Me.LbDataIn.Text = CStr(Now)

        If Tots Then
            Me.txtCompos.Text = ""
            Me.txtAny.Text = ""
            Me.ComboDisc.SelectedValue = 0
            Me.listViewEstils.Items.Clear()
            Me.ComboIdioma.SelectedValue = 0
            Me.ComboInterp.SelectedValue = 0
            Me.ComboTemp.SelectedValue = 0
            Me.ComboSubj.SelectedValue = 0
        Else
            If Not CType(mnuValorsItems.DropDownItems(0), ToolStripMenuItem).Checked Then Me.ComboInterp.SelectedValue = 0
            If Not CType(mnuValorsItems.DropDownItems(1), ToolStripMenuItem).Checked Then Me.ComboDisc.SelectedValue = 0
            If Not CType(mnuValorsItems.DropDownItems(2), ToolStripMenuItem).Checked Then Me.txtCompos.Text = ""
            If Not CType(mnuValorsItems.DropDownItems(4), ToolStripMenuItem).Checked Then Me.ComboIdioma.SelectedValue = 0
            If Not CType(mnuValorsItems.DropDownItems(5), ToolStripMenuItem).Checked Then Me.ComboTemp.SelectedValue = 0
            If Not CType(mnuValorsItems.DropDownItems(6), ToolStripMenuItem).Checked Then Me.ComboSubj.SelectedValue = 0
            If Not CType(mnuValorsItems.DropDownItems(7), ToolStripMenuItem).Checked Then Me.txtAny.Text = ""
        End If
        Me.txtTitol.Focus()
    End Sub


    Private Sub frmTemes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        setLanguageForm()
        If My.Settings.TXT_CAPITALIZE Then
            Me.txtTitol.CharacterCasing = CharacterCasing.Upper
            Me.txtCompos.CharacterCasing = CharacterCasing.Upper
            Me.txtComent.CharacterCasing = CharacterCasing.Upper
        End If

        gridActual = Me.gridDades

        ' Omple el mnu estils (més utilitzats)
        Dim SqlStr As String = "SELECT estils.estil_id, estil_nom, count(*) as aaa FROM `style_relationships`, `estils` where `style_relationships`.`style_relationships_style`=`estils`.`estil_id` group by style_relationships_style order by aaa desc limit 25;"
        Dim db As New MSC.dbs(Cloud)
        Dim mytable As DataTable = db.getTable(SqlStr)
        For i As Integer = 0 To mytable.Rows.Count - 1
            Dim mnuListMoreUsed As ToolStripMenuItem
            mnuListMoreUsed = New ToolStripMenuItem
            mnuListMoreUsed.Text = mytable.Rows(i)("estil_nom")
            mnuListMoreUsed.Tag = mytable.Rows(i)("estil_id")
            mnuListMoreUsed.Visible = True
            mnuEstilsMesUtilitzats.DropDownItems.Add(mnuListMoreUsed)
            AddHandler mnuListMoreUsed.Click, AddressOf addEstil_Click
        Next

        SqlStr = "SELECT estils.estil_id, estil_nom FROM estils ;"
        mytable = db.getTable(SqlStr)
        For i As Integer = 0 To mytable.Rows.Count - 1
            Dim my_item As New ToolStripMenuItem
            my_item.Name = "mnuEstil_" & mytable.Rows(i)("estil_id")
            my_item.Text = mytable.Rows(i)("estil_nom")
            my_item.Tag = mytable.Rows(i)("estil_id")
            ComboBoxMnuEstils.Items.Add(my_item)
        Next
        '		ComboBoxMnuEstils.SelectedItem = 0
        mytable = Nothing
        db = Nothing


        If Not IsLoadForm("frmDiscos") And Not frmMain.NoLoadRs Then getListTemes()

        ' control tipus usuari        
        Me.cmdNou.Visible = frmMain.VisibleNew
        Me.mnuNew.Visible = frmMain.VisibleNew
        Dim TipUsr As NivellUsers = Usuari.UsrTipus
        mnuNew.Enabled = IIf(TipUsr > NivellUsers.USR_CONVIDAT, True, False)
        'Me.mnuModif.Enabled = IIf(TipUsr > NivellUsers.USR_CONVIDAT, True, False)
        cmdPrint.Enabled = IIf(TipUsr > NivellUsers.USR_CONVIDAT, True, False)


        ' Carrèga els valors del MSC.ini
        Dim FitxerINI As New IniFile
        CType(mnuValorsItems.DropDownItems(0), ToolStripMenuItem).Checked = CBool(FitxerINI.INIRead(MyAPP.IniFile, "Data Control", "VALOR0", "0"))
        CType(mnuValorsItems.DropDownItems(1), ToolStripMenuItem).Checked = CBool(FitxerINI.INIRead(MyAPP.IniFile, "Data Control", "VALOR1", "0"))
        CType(mnuValorsItems.DropDownItems(2), ToolStripMenuItem).Checked = CBool(FitxerINI.INIRead(MyAPP.IniFile, "Data Control", "VALOR2", "0"))
        CType(mnuValorsItems.DropDownItems(3), ToolStripMenuItem).Checked = CBool(FitxerINI.INIRead(MyAPP.IniFile, "Data Control", "VALOR3", "0"))
        CType(mnuValorsItems.DropDownItems(4), ToolStripMenuItem).Checked = CBool(FitxerINI.INIRead(MyAPP.IniFile, "Data Control", "VALOR4", "0"))
        CType(mnuValorsItems.DropDownItems(5), ToolStripMenuItem).Checked = CBool(FitxerINI.INIRead(MyAPP.IniFile, "Data Control", "VALOR5", "0"))
        CType(mnuValorsItems.DropDownItems(6), ToolStripMenuItem).Checked = CBool(FitxerINI.INIRead(MyAPP.IniFile, "Data Control", "VALOR6", "0"))
        CType(mnuValorsItems.DropDownItems(7), ToolStripMenuItem).Checked = CBool(FitxerINI.INIRead(MyAPP.IniFile, "Data Control", "VALOR7", "0"))

        Me.ClientSize = New Size(frm_sice(0), frm_sice(1))


        PathMusica = Params.PathMusica

        _bpm.BPMHistorySize = 8
        _bpm.MinBPM = 30
        _bpm.MaxBPM = 180

    End Sub

    Dim LABEL_DINS_LLISTA As String
    Dim LABEL_FORA_LLISTA As String
    Dim LABEL_TRACK_NUM As String
    Dim MSG_ERROR_SAVE_ITEM As String
    Dim MSG_NO_TEMES_MODIF_MASSIVE As String
    Dim MSG_LLISTA_EXIT_INI_POS As String
    Dim LABEL_LLISTA_EXITS As String
    Dim LABEL_LLISTA_TEMES As String
    Dim MSG_ESCRIU_TITOL As String
    Dim TITLE_RADIACIO_TEMA As String
    Dim MSG_TOTAL_RADIACIONS As String

    Dim MSG_ERROR_ESPECIF_INTERPRET As String
    Dim MSG_ERROR_ESPECIF_DISC As String
    Dim MSG_CONFIRM_CANCEL As String
    Dim MSG_MODIF_REALITZADA As String
    Dim MSG_EXPORT_REALITZADA As String

    Public Sub setLanguageForm()
        lang.StrForm = Me.Name

        LABEL_DINS_LLISTA = lang.getText("LABEL_DINS_LLISTA") '"Dins Llista"
        LABEL_FORA_LLISTA = lang.getText("LABEL_FORA_LLISTA") '"Fora Llista"
        LABEL_TRACK_NUM = lang.getText("LABEL_TRACK_NUM") '"TRACK Nº"
        MSG_ERROR_SAVE_ITEM = lang.getText("MSG_ERROR_SAVE_ITEM") '"Error al intentar salvar les dades, comprova que totes les dades siguin correctes"
        MSG_NO_TEMES_MODIF_MASSIVE = lang.getText("MSG_NO_TEMES_MODIF_MASSIVE") '"No hi han temes agrupats per modificar-los massivament"
        MSG_LLISTA_EXIT_INI_POS = lang.getText("MSG_LLISTA_EXIT_INI_POS") '"En quina posició inicial"
        LABEL_LLISTA_EXITS = lang.getText("LABEL_LLISTA_EXITS", True) '"Llista d'èxits"
        LABEL_LLISTA_TEMES = lang.getText("LABEL_LLISTA_TEMES") '"Llistat de temes"
        MSG_ESCRIU_TITOL = lang.getText("MSG_ESCRIU_TITOL", True) '"Escriu un títol pel llistat"
        TITLE_RADIACIO_TEMA = lang.getText("TITLE_RADIACIO_TEMA") '"Radiació del Tema : {0}" 
        MSG_TOTAL_RADIACIONS = lang.getText("MSG_TOTAL_RADIACIONS") '"Total nº de radiacions: {0}"

        'Me.ToolStrip1.Text = "ToolStrip1"
        Me.cmdPrimer.Text = lang.getText("LABEL_GOTO_FIRSH", True) '"Primer"
        Me.cmdPrevi.Text = lang.getText("LABEL_GOTO_PREV", True) '"Anterior"
        Me.cmdSeguent.Text = lang.getText("LABEL_GOTO_NEXT", True) '"Següent"
        Me.cmdUltim.Text = lang.getText("LABEL_GOTO_LAST", True) '"Últim"
        Me.cmdNou.Text = lang.getText("LABEL_NEW", True) '"Nou"
        Me.cmdBloqueix.Text = lang.getText("LABEL_EDITAR", True) '"Editar"
        Me.cmdBorrar.Text = lang.getText("LABEL_DELETE", True) '"Borrar"
        Me.cmdSalvar.Text = lang.getText("LABEL_SAVE", True) '"Salvar"		
        Me.cmdBuscar.Text = lang.getText("LABEL_BUSCAR", True) '"Buscar"
        Me.cmdRefrescar.Text = lang.getText("LABEL_REFRESCAR", True) '"Refrescar"
        Me.cmdSortir.Text = lang.getText("LABEL_EXIT", True) '"Sortir"
        Me.cmdPlay.Text = lang.getText("LABEL_PLAY_PAUSA", True) '"Play/Pausa"
        Me.cmdStop.Text = lang.getText("LABEL_STOP", True) '"Stop"
        Me.comboGridtemInterp.HeaderText = lang.getText("HEADERTEXT_INTERP", True) '"Intèrpret"
        Me.comboGridTemDisc.HeaderText = lang.getText("HEADERTEXT_DISC", True) '"Disc"
        Me.Column5.HeaderText = lang.getText("LABEL_COMPOSITOR", True) '"Compositor"						
        Me.Column16.HeaderText = lang.getText("HEADERTEXT_RITME", True) '"Ritme"
        Me.DataGridViewTextBoxColumn1.HeaderText = lang.getText("HEADERTEXT_ID", True) '"ID"		
        Me.comboGridTemSelInterp.HeaderText = lang.getText("HEADERTEXT_INTERP", True) '"Intèrpret"
        Me.comboGridTemSelDisc.HeaderText = lang.getText("HEADERTEXT_DISC", True) '"Disc"
        Me.DataGridViewTextBoxColumn3.HeaderText = lang.getText("LABEL_COMPOSITOR", True) '"Compositor"
        Me.comboGridTemSelEstil.HeaderText = lang.getText("HEADERTEXT_ESTIL", True) '"Estil"		
        Me.DataGridViewTextBoxColumn5.HeaderText = lang.getText("HEADERTEXT_RITME", True) '"Ritme"
        Me.DataGridViewTextBoxColumn8.HeaderText = lang.getText("HEADERTEXT_DURADA", True) '"Durada"
        Me.lbBPM.Text = lang.getText("HEADERTEXT_RITME", True) '"Ritme"		
        Me.lbEstil.Text = lang.getText("HEADERTEXT_ESTIL", True) '"Estil"
        Me.lbActvlLista.Text = LABEL_FORA_LLISTA
        Me.lbNou.Text = lang.getText("LABEL_NEW_UPPER", True) ' "NOU"
        Me.Label3.Text = lang.getText("LABEL_COMPOSITOR", True) '"Compositor"
        Me.lbDisc.Text = lang.getText("HEADERTEXT_DISC", True) '"Disc"		
        Me.Label1.Text = lang.getText("LABEL_IDENTIFICADOR", True) & ":" '"Identificador:"
        'Me.MenuStrip1.Text = "MenuStrip1"
        Me.mnuApplication.Text = lang.getText("LABEL_PROGRAMA", True) '"Programa"		
        Me.mnuAppExit.Text = lang.getText("LABEL_EXIT", True) '"Sortir"
        Me.mnuPlayer.Text = lang.getText("LABEL_REPRODUCTOR", True) '"Reproductor"
        Me.mnuPlay.Text = lang.getText("LABEL_PLAY_PAUSA", True) '"Play/Pausa"
        Me.mnuStop.Text = lang.getText("LABEL_STOP", True) '"Stop"
        Me.mnuCalDurada.Text = lang.getText("LABEL_CALC_DURADA", True) '"Calcular Durada"		
        Me.mnuFinal.Text = lang.getText("LABEL_END_TEMA", True) '"Final Tema"
        Me.mnuEdit.Text = lang.getText("mnuEdit.Text", True) '"Edició"
        Me.mnuModif.Text = lang.getText("LABEL_MODIFICAR", True) '"Modificar"
        Me.mnuSave.Text = lang.getText("LABEL_SALVAR", True) '"Salvar"
        Me.mnuNew.Text = lang.getText("LABEL_NEW", True) '"Nou"
        Me.mnuDel.Text = lang.getText("LABEL_DELETE", True) '"Borrar"
        Me.mnuEditAudio.Text = lang.getText("mnuEditAudio.Text", True) '"Editar l'àudio"		
        Me.mnuBuscar.Text = lang.getText("LABEL_BUSCAR", True) '"Buscar"
        Me.mnuRefresh.Text = lang.getText("LABEL_REFRESCAR", True) '"Refrescar"        
        Me.mnuColumVisiblesDurada.Text = lang.getText("HEADERTEXT_DURADA", True) '"Durada"
        Me.mnuHelp.Text = lang.getText("mnu_Help", True) '"Ajuda"
        Me.mnuHelpManual.Text = lang.getText("mnuRefHelp.Text", True) '"Manual OnLine"
        Me.EstilToolStripMenuItem.Text = lang.getText("HEADERTEXT_ESTIL", True) '"Estil"
        Me.IntèrpretToolStripMenuItem.Text = lang.getText("HEADERTEXT_INTERP", True) '"Intèrpret"
        Me.lbInterp.Text = lang.getText("HEADERTEXT_INTERP", True) '"Intèrpret"
        Me.DiscToolStripMenuItem.Text = lang.getText("HEADERTEXT_DISC", True) '"Disc"
        Me.ColumnID.HeaderText = lang.getText("HEADERTEXT_ID", True) '"ID"
        Me.Column19.HeaderText = lang.getText("HEADERTEXT_DURADA", True) '"Durada"
        Me.Label11.Text = lang.getText("HEADERTEXT_DURADA", True) '"Durada"
        Me.mnuColumVisiblesRitme.Text = lang.getText("HEADERTEXT_RITME", True) '"Ritme"
        Me.Column7.HeaderText = lang.getText("LABEL_ACTIVA", True) '"Activa"
        Me.CompositorToolStripMenuItem.Text = lang.getText("LABEL_COMPOSITOR", True) '"Compositor"
        Me.Label4.Text = lang.getText("LABEL_COMMENT", True) '"Comentari"
        Me.Column8.HeaderText = lang.getText("LABEL_INSTRUMENTAL", True) '"Intrumental"
        Me.DataGridViewCheckBoxColumn2.HeaderText = lang.getText("LABEL_INSTRUMENTAL", True) '"Intrumental"
        Me.chkInstrument.Text = lang.getText("LABEL_INSTRUMENTAL", True) '"Intrumental"
        Me.Column2.HeaderText = lang.getText("HEADERTEXT_TITOL", True) '"Titol"
        Me.Label2.Text = lang.getText("HEADERTEXT_TITOL", True) '"Titol"
        Me.DataGridViewTextBoxColumn2.HeaderText = lang.getText("HEADERTEXT_TITOL", True) '"Titol"		
        Me.Column18.HeaderText = lang.getText("LABEL_INTRO", True) '"Intro"
        Me.DataGridViewTextBoxColumn7.HeaderText = lang.getText("LABEL_INTRO", True) '"Intro"
        Me.Label10.Text = lang.getText("LABEL_INTRO", True) '"Intro"
        Me.Column9.HeaderText = lang.getText("LABEL_RETRICCIO", True) '"restricció"
        Me.DataGridViewCheckBoxColumn3.HeaderText = lang.getText("LABEL_RETRICCIO", True) '"restricció"
        Me.chkRestric.Text = lang.getText("LABEL_RETRICCIO", True) '"restricció"
        Me.comboGridTemIdioma.HeaderText = lang.getText("HEADERTEXT_IDIOMA", True) '"Idioma"
        Me.comboGridTemSelIdioma.HeaderText = lang.getText("HEADERTEXT_IDIOMA", True) '"Idioma"
        Me.lbIdioma.Text = lang.getText("HEADERTEXT_IDIOMA", True) '"Idioma"
        Me.IdiomaToolStripMenuItem.Text = lang.getText("HEADERTEXT_IDIOMA", True) '"Idioma"
        Me.mnuColumVisiblesIdioma.Text = lang.getText("HEADERTEXT_IDIOMA", True) '"Idioma"
        Me.Column17.HeaderText = lang.getText("HEADERTEXT_ANY", True) '"Any"
        Me.DataGridViewTextBoxColumn6.HeaderText = lang.getText("HEADERTEXT_ANY", True) '"Any"
        Me.Label9.Text = lang.getText("HEADERTEXT_ANY", True) '"Any"
        Me.AnyToolStripMenuItem.Text = lang.getText("HEADERTEXT_ANY", True) '"Any"
        Me.mnuColumVisiblesAny.Text = lang.getText("HEADERTEXT_ANY", True) '"Any"
        Me.Column20.HeaderText = lang.getText("HEADERTEXT_N_RADIA", True) '"Nº Radiacions"
        Me.DataGridViewTextBoxColumn9.HeaderText = lang.getText("HEADERTEXT_N_RADIA", True) '"Nº Radiacions"
        Me.mnuColumVisiblesRadi.Text = lang.getText("HEADERTEXT_N_RADIA", True) '"Nº Radiacions"
        Me.Column3.HeaderText = lang.getText("LABEL_DATA_IN_", True) '"Data In"
        Me.DataGridViewTextBoxColumn17.HeaderText = lang.getText("LABEL_DATA_IN_", True) '"Data In"
        Me.Column4.HeaderText = lang.getText("LABEL_DATA_RADIACIO", True) '"Data radiació"
        Me.DataGridViewTextBoxColumn18.HeaderText = lang.getText("LABEL_DATA_RADIACIO", True) '"Data radiació"
        Me.ClasTemporalToolStripMenuItem.Text = lang.getText("LABEL_CLAS_TEMP", True) '"Clas. Temporal"
        Me.mnuColumVisiblesTemp.Text = lang.getText("LABEL_CLAS_TEMP", True) '"Clas. Temporal"
        Me.Label5.Text = lang.getText("LABEL_CLAS_TEMP", True) '"Clas. Temporal"
        Me.ClasSubjeToolStripMenuItem.Text = lang.getText("LABEL_CLAS_SUBJ", True) '"Clas. Subjectiva"
        Me.mnuColumVisiblesSubj.Text = lang.getText("LABEL_CLAS_SUBJ", True) '"Clas. Subjectiva"
        Me.lbClasSubj.Text = lang.getText("LABEL_CLAS_SUBJ", True) '"Clas. Subjectiva"
        Me.Label12.Text = lang.getText("HEADERTEXT_N_RADIA", True) '"Nº radiacions"		
        Me.chkOnPauta.Text = lang.getText("LABEL_DESACTIVA", True) '"Desactivada"
        'Me.lbDataUltimRadi.Text = "2001-02-12 11:12:00"
        Me.Label7.Text = lang.getText("LABEL_ULT_RADIACIO", True) '"Última radiació"
        'Me.LbDataIn.Text = "2001-02-12 11:12:00"
        Me.Label6.Text = lang.getText("LABEL_DATA_IN", True) '"Data entrada"		
        Me.Label17.Text = lang.getText("LABEL_DATA_OUT", True) & ":" '"Data Sortida:"		

        Me.Column6.HeaderText = lang.getText("LABEL_COMMENT", True) '"Coment"
        Me.DataGridViewTextBoxColumn4.HeaderText = lang.getText("Column6.HeaderText") '"Coment"

        Me.comboGridTemSelTemp.HeaderText = lang.getText("comboGridTemSelTemp.HeaderText") '"Temporalitat"
        Me.comboGridTemTempo.HeaderText = lang.getText("comboGridTemSelTemp.HeaderText") '"Temporalitat"

        Me.comboGridTemSelSubj.HeaderText = lang.getText("comboGridTemSelSubj.HeaderText") '"Subjectivitat"
        Me.comboGridTemSubj.HeaderText = lang.getText("comboGridTemSelSubj.HeaderText") '"Subjectivitat"


        Me.Column10.HeaderText = lang.getText("Column10.HeaderText") '"Force Max. Radi."
        Me.DataGridViewCheckBoxColumn4.HeaderText = lang.getText("Column10.HeaderText") '"Force Max. Radi."

        Me.ColumnVotes.HeaderText = lang.getText("ColumnVots.HeaderText") '"Nº Vots"
        Me.ColumnVots.HeaderText = lang.getText("ColumnVots.HeaderText") '"Nº Vots"
        Me.Label8.Text = lang.getText("ColumnVots.HeaderText") '"Nº Vots"		
        Me.mnuColumVisiblesVots.Text = lang.getText("ColumnVots.HeaderText") '"Nº Vots"

        Me.Label16.Text = lang.getText("LABEL_DATA_ENTRADA", True) & ":" '"Data d'entrada:"
        Me.lbIsTop.Text = lang.getText("LABEL_TOP", True) '"TOP"
        Me.cmdLlistaExitsIN.Text = lang.getText("cmdLlistaExitsIN.Text") '"Entrar a la Llista"
        Me.cmdLlistaExitsOUT.Text = lang.getText("cmdLlistaExitsOUT.Text") '"Treure de la llista"		
        Me.mnuAddTot.Text = lang.getText("mnuAddTot.Text") '"Afegir tot a la agrupació"
        Me.mnuAddSelect.Text = lang.getText("mnuAddSelect.Text") '"Afegir selecció a la agrupació"
        Me.TabPage2.Text = lang.getText("TabPage2.Text") '"Agrupació de diferents cançons"
        Me.DataGridViewCheckBoxColumn1.HeaderText = lang.getText("DataGridViewCheckBoxColumn1.HeaderText") '"Pauta In"
        Me.mnuDelTot.Text = lang.getText("mnuDelTot.Text") '"Borrar tota la agrupació"
        Me.mnuDelSelect.Text = lang.getText("mnuDelSelect.Text") '"Borrar la selecció"		
        Me.mnuModifMassive.Text = lang.getText("mnuModifMassive.Text") '"Modificació massiva de dades"
        Me.Label15.Text = lang.getText("Label15.Text") & ":" '"Nº d'entada a llista:"
        Me.Label14.Text = lang.getText("LABEL_DATA_TOP", True) & ":" '"Data TOP:"
        Me.Label13.Text = lang.getText("Label13.Text") & ":" '"Número a la llista:"
        Me.chkForceMax.Text = lang.getText("chkForceMax.Text") '"Forçar Nº màxim de radiacions"
        Me.mnuCalcIntro.Text = lang.getText("mnuCalcIntro.Text") '"Calcular Intro"
        Me.mnuValorsItems.Text = lang.getText("mnuValorsItems.Text") '"Conservar valors anteriors"		
        Me.mnuFindUltRadi.Text = lang.getText("mnuFindUltRadi.Text") '"Historial radiació"
        Me.mnuUltimTemaMare.Text = lang.getText("LABEL_ULTIMES_CANCONS_RADIADES", True) '"Últimes cançons radiades"

        Me.mnuUltimTema10.Text = "10 " & lang.getText("LABEL_RESULTS", True) '"10 resultats"
        Me.mnuUltimTema25.Text = "25 " & lang.getText("LABEL_RESULTS", True) '"25 resultats"
        Me.mnuUltimTema50.Text = "50 " & lang.getText("LABEL_RESULTS", True) '"50 resultats"
        Me.mnuUltimTema100.Text = "100 " & lang.getText("LABEL_RESULTS", True) '"100 resultats"

        Me.mnuColumVisiblesMare.Text = lang.getText("LABEL_COLUMN_OPCIONAL_VISIBLE", True) ' "Columnes opcionals visibles"		
        Me.cmdPrint.Text = lang.getText("LABEL_IMPRIMIR_LLISTAT", True) '"Imprimir llistat"
        Me.lbAtencio.Text = lang.getText("LABEL_NO_EXIST", True) '"No Exist."
        Me.lbAtencio.ToolTipText = lang.getText("LABEL_NO_EXIST_FILE", True) '"No existeix el fitxer"
        Me.TabPage1.Text = lang.getText("TabPage1.Text") '"Cançons disponibles segons el filtre realitzat"									
        Me.groupBoxAltres.Text = lang.getText("FITXER_ALTRES", True) '"Altres"
        Me.groupBoxLlistaExits.Text = lang.getText("LABEL_LLISTA_EXITS", True) '"Llista Èxits"
        Me.mnuEstilsDelete.Text = lang.getText("LABEL_DELETE", True) '"esborrar"
        Me.mnuEstilsMesUtilitzats.Text = lang.getText("mnuEstilsMesUtilitzats.Text")
        '-------------
        MSG_ERROR_ESPECIF_INTERPRET = lang.getText("MSG_INTERP_OBLIGATORI", True) '"És obligatori especificar un intèrpret, pots especificar 'Varis'."
        MSG_ERROR_ESPECIF_DISC = lang.getText("MSG_ERROR_ESPECIF_DISC") '"És obligatori especificar un disc."
        MSG_CONFIRM_CANCEL = lang.getText("MSG_CONFIRM_CANCEL") '"Vols cancelar totes les modificacions?"
        MSG_MODIF_REALITZADA = lang.getText("MSG_MODIF_REALITZADA") '"Modificació massiva realitzada"		
        MSG_EXPORT_REALITZADA = lang.getText("MSG_EXPORT_REALITZADA") '"Exportació massiva realitzada"

        Me.lbAtention.Text = lang.getText("lbAtention.Text") '"Modificar Massivament la base de dades pot suposar una pèdua irreparable de dades."
        Me.chkActiveInterp.Text = lang.getText("LABEL_ACTIVA_MODIF") '"Activar modificació"
        Me.chkActiveDisc.Text = lang.getText("LABEL_ACTIVA_MODIF") '
        Me.chkActiveEstil.Text = lang.getText("LABEL_ACTIVA_MODIF") '
        Me.chkActiveIdioma.Text = lang.getText("LABEL_ACTIVA_MODIF") '
        Me.chkActiveClasTemp.Text = lang.getText("LABEL_ACTIVA_MODIF") '				
        Me.chkActiveOnPauta.Text = lang.getText("LABEL_ACTIVA_MODIF") '
        Me.chkActiveAny.Text = lang.getText("LABEL_ACTIVA_MODIF") '
        Me.chkActiveIntrum.Text = lang.getText("LABEL_ACTIVA_MODIF") '
        Me.chkActiveForca.Text = lang.getText("LABEL_ACTIVA_MODIF") '
        Me.chkActiveRestric.Text = lang.getText("LABEL_ACTIVA_MODIF") '
        Me.chkActiveClasSubj.Text = lang.getText("LABEL_ACTIVA_MODIF") '

        Me.chkOnOffMassive.Text = lang.getText("chkOnOffMassive.Text") '"Activada / desactivada"
        Me.Label21.Text = lang.getText("HEADERTEXT_ANY", True) '"Any"
        Me.chkInstrumentMassive.Text = lang.getText("LABEL_INSTRUMENTAL", True) '"Instrumental"
        Me.chkForceMaxMassive.Text = lang.getText("chkForceMax.Text") '"Forçar nº  Màxim de radiacions"
        Me.chkRestricMassive.Text = lang.getText("LABEL_RETRICCIO", True) '"Restricció"
        Me.cmdCalcBPM.Text = lang.getText("cmdCalcBPM.Text") '"Calcular BPM"        
        Me.MetroTabPage1.Text = lang.getText("LABEL_GENERAL", True) '"General"
        Me.Label18.Text = lang.getText("HEADERTEXT_INTERP", True) '"Intrèpret"
        Me.Label19.Text = lang.getText("LABEL_ALBUMS", True) '"Disc"
        Me.Label20.Text = lang.getText("HEADERTEXT_ESTIL", True) '"Estil"
        Me.Label22.Text = lang.getText("HEADERTEXT_IDIOMA", True) '"Idioma"
        Me.Label23.Text = lang.getText("LABEL_CLAS_TEMP", True) '"Clas. Temporal"		
        Me.Label24.Text = lang.getText("LABEL_CLAS_SUBJ", True) '"Clas. Subjectiva"
        Me.MetroTabPage2.Text = lang.getText("FITXER_ALTRES", True) '"Altres"
        Me.Label25.Text = lang.getText("label25.Text") '"Recalcular el ritme de les cançons."
        Me.Label26.Text = lang.getText("label26.Text") '"Recalcular durada real de les cançons."
        Me.cmdCalcDurada.Text = lang.getText("cmdCalcDurada.Text") '"Calcular Durada"
        Me.Label27.Text = lang.getText("Label27.Text") '"Radomitzant es modifica la data de radiació d'una forma aleatòria, així s'evitarà una sensació repetitiva a la pauta."
        Me.cmdRandom.Text = lang.getText("cmdRandom.Text") '"Randomitzar"
        '-----------------
        Me.Text = lang.getText("Text") '"Gestió de Cançons"

        Dim Cmb As New combo
        ' Omple el combo estils		
        'Cmb.OmpleCombo(ComboBoxMnuEstils.ComboBox, TAULES_DBS.TAULA_ESTILS, TotsCap.CAP) : ComboBoxMnuEstils.ComboBox.SelectedValue = 0
        ' Omple el combo d'Interp
        Cmb.OmpleCombo(ComboInterp, TAULES_DBS.TAULA_INTERPRETS, TotsCap.CAP) : ComboInterp.SelectedValue = 0
        Cmb.OmpleCombo(Me.comboGridtemInterp, TAULES_DBS.TAULA_INTERPRETS, TotsCap.CAP)
        Cmb.OmpleCombo(Me.comboGridTemSelInterp, TAULES_DBS.TAULA_INTERPRETS, TotsCap.CAP)
        ' Omple el combo Discos
        Cmb.OmpleCombo(ComboDisc, TAULES_DBS.TAULA_DISCOS, TotsCap.CAP) : ComboDisc.SelectedValue = 0
        Cmb.OmpleCombo(Me.comboGridTemDisc, TAULES_DBS.TAULA_DISCOS, TotsCap.CAP)
        Cmb.OmpleCombo(Me.comboGridTemSelDisc, TAULES_DBS.TAULA_DISCOS, TotsCap.CAP)
        ' Omple el combo subjectiva
        Cmb.OmpleCombo(ComboSubj, TAULES_DBS.TAULA_SUBJECTIV, TotsCap.CAP) : ComboSubj.SelectedValue = 0
        Cmb.OmpleCombo(Me.comboGridTemSubj, TAULES_DBS.TAULA_SUBJECTIV, TotsCap.CAP)
        Cmb.OmpleCombo(Me.comboGridTemSelSubj, TAULES_DBS.TAULA_SUBJECTIV, TotsCap.CAP)
        ' Omple el combo temporal
        Cmb.OmpleCombo(ComboTemp, TAULES_DBS.TAULA_TEMPORALITAT, TotsCap.CAP) : ComboTemp.SelectedValue = 0
        Cmb.OmpleCombo(Me.comboGridTemTempo, TAULES_DBS.TAULA_TEMPORALITAT, TotsCap.CAP)
        Cmb.OmpleCombo(Me.comboGridTemSelTemp, TAULES_DBS.TAULA_TEMPORALITAT, TotsCap.CAP)
        ' Omple el combo Idioma
        Cmb.OmpleCombo(ComboIdioma, TAULES_DBS.TAULA_IDIOMES, TotsCap.CAP, "lang_visible=1") : ComboIdioma.SelectedValue = 0
        Cmb.OmpleCombo(Me.comboGridTemIdioma, TAULES_DBS.TAULA_IDIOMES, TotsCap.CAP, "lang_visible=1")
        Cmb.OmpleCombo(Me.comboGridTemSelIdioma, TAULES_DBS.TAULA_IDIOMES, TotsCap.CAP, "lang_visible=1")

        Cmb.OmpleCombo(ComboEstil, TAULES_DBS.TAULA_ESTILS, TotsCap.CAP) : ComboEstil.SelectedValue = 0
        ' Omple el combo d'Interp
        Cmb.OmpleCombo(ComboBoxInterp, TAULES_DBS.TAULA_INTERPRETS, TotsCap.CAP) : ComboInterp.SelectedValue = 0
        ' Omple el combo Discos
        Cmb.OmpleCombo(ComboBoxDisc, TAULES_DBS.TAULA_DISCOS, TotsCap.CAP) : ComboDisc.SelectedValue = 0
        ' Omple el combo subjectiva
        Cmb.OmpleCombo(ComboClasSubj, TAULES_DBS.TAULA_SUBJECTIV, TotsCap.CAP) : ComboClasSubj.SelectedValue = 0
        ' Omple el combo temporal
        Cmb.OmpleCombo(ComboClasTemp, TAULES_DBS.TAULA_TEMPORALITAT, TotsCap.CAP) : ComboClasTemp.SelectedValue = 0
        ' Omple el combo Idioma
        Cmb.OmpleCombo(ComboBoxIdioma, TAULES_DBS.TAULA_IDIOMES, TotsCap.CAP) : ComboIdioma.SelectedValue = 0
    End Sub

    Private Sub ShowValuesTema()
        If IsSaving = True Then Exit Sub
        Me.lbAtencio.Visible = False
        tmrDetalls.Enabled = False
        Try
            If blEnable = True Then LockedRecord()

            LbID.Text = gridActual.CurrentRow.Cells(0).Value
            txtTitol.Text = StripSlashes(gridActual.CurrentRow.Cells(1).Value)
            txtCompos.Text = StripSlashes(gridActual.CurrentRow.Cells(4).Value)
            txtComent.Text = StripSlashes(NoNul(gridActual.CurrentRow.Cells(5).Value))
            txtRitme.Text = gridActual.CurrentRow.Cells(13).Value

            txtIntro.Text = gridActual.CurrentRow.Cells(15).Value.ToString
            Dim Segons As Integer = SecondDec(txtIntro.Text)
            Try
                Me.scrollIntro.Value = 360 - Segons
            Catch ex As Exception
                Me.scrollIntro.Value = Me.scrollIntro.Minimum
            End Try

            lbDurada.Text = gridActual.CurrentRow.Cells(16).Value.ToString
            OnPauta = gridActual.CurrentRow.Cells(6).Value
            chkOnPauta.Checked = OnPauta
            'Me.cmdOnPauta.Image = IIf(OnPauta = True, picInPauta.Image, picOutPauta.Image)
            'Me.cmdOnPauta.Text = IIf(OnPauta = True, LABEL_ACTIVADA, LABEL_DESACTIVADA)

            LbDataIn.Text = gridActual.CurrentRow.Cells(18).Value
            Me.lbDataUltimRadi.Text = gridActual.CurrentRow.Cells(19).Value
            Me.lbNumRadia.Text = gridActual.CurrentRow.Cells(17).Value

            Me.ComboIdioma.SelectedValue = gridActual.CurrentRow.Cells(10).Value
            Me.ComboTemp.SelectedValue = gridActual.CurrentRow.Cells(11).Value
            Me.ComboSubj.SelectedValue = gridActual.CurrentRow.Cells(12).Value
            Me.ComboDisc.SelectedValue = gridActual.CurrentRow.Cells(3).Value
            Me.ComboInterp.SelectedValue = gridActual.CurrentRow.Cells(2).Value

            RefreshStyles(LbID.Text)

            Me.txtAny.Text = gridActual.CurrentRow.Cells(14).Value.ToString
            Me.chkInstrument.Checked = gridActual.CurrentRow.Cells(7).Value
            Me.chkForceMax.Checked = gridActual.CurrentRow.Cells(9).Value
            Me.chkRestric.Checked = gridActual.CurrentRow.Cells(8).Value
            Me.lbVots.Text = gridActual.CurrentRow.Cells(20).Value

            picDisc.Image = getImageFromDisc(Me.ComboDisc.SelectedValue)
            tmrDetalls.Enabled = True
            lbPosition.Text = gridActual.CurrentRow.Index + 1
        Catch ex As Exception
            BorrarDadesPantalla(True)
        End Try
        Me.cmdSalvar.Enabled = False
    End Sub

    Friend Sub RefreshStyles(id As Integer)
        listViewEstils.Items.Clear()
        Dim sCmd As String = "style_relationships_tipfitxer = " & Tipus_Fitxers.FITXER_MUSICA & " AND style_relationships_fitxer = " & id
        Dim colec() As DataRow = dsClient.Tables("style_relationships").Select(sCmd)
        For i As Integer = 0 To colec.Length - 1
            Dim item As New ListViewItem
            item.Text = colec(i)("estil_nom").ToString
            item.Tag = colec(i)("estil_id").ToString
            Me.listViewEstils.Items.Add(item)
        Next
    End Sub

    Private Function getEstilsTema(tema_id As Integer)
        Dim sCmd As String = "style_relationships_tipfitxer = " & Tipus_Fitxers.FITXER_MUSICA & " AND style_relationships_fitxer = " & tema_id
        Dim colec() As DataRow = dsClient.Tables("style_relationships").Select(sCmd)
        Try
            Dim ret(colec.Length) As String
            For I As Integer = 0 To colec.Length - 1
                ret(I) = getNomEstil(colec(0)("style_relationships_style").ToString)
            Next I

            colec = Nothing
            Return ret
        Catch ex As Exception
            Return LIST_NO_DEF
        End Try
    End Function

    Private Function getImageFromDisc(disc_id As Integer) As Image
        Dim db As New MSC.dbs(Cloud)
        Dim StrSql As String = "SELECT img_image FROM image_discos where img_disc=" & disc_id
        Try
            Dim ImgDisc As Image = GetImageFromByteArray(CType(db.ExecuteScalar(StrSql), Byte()))
            If ImgDisc Is Nothing Then
                db = Nothing
                Return Nothing
            Else
                db = Nothing
                Return ImgDisc
            End If
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Private Sub RefresTemLlistaExits()
        'Reset----        
        Me.lbNumlLista.Text = ""
        Me.lbNumInLlista.Text = ""
        Me.lbDataInLlista.Text = ""
        Me.lbDataTop.Text = ""
        Me.lbDataOutLlista.Text = ""
        Me.lbActvlLista.Text = LABEL_FORA_LLISTA
        lbIsTop.Visible = False
        '------------
        Dim strSql As String = "SELECT * FROM llistaexits WHERE tops_id =" & Me.LbID.Text
        Dim db As New MSC.dbs(Cloud)
        Dim rs As DataTable = db.getTable(strSql)
        If rs.Rows.Count Then
            Me.lbNumlLista.Text = rs.Rows(0)(1).ToString
            lbIsTop.Visible = IIf(rs.Rows(0)(1) = 1, True, False)
            Me.lbNumInLlista.Text = rs.Rows(0)(2).ToString
            Me.lbDataInLlista.Text = rs.Rows(0)(3).ToString
            Me.lbDataTop.Text = IIf(rs.Rows(0)(4) = "01/01/1970", "", rs.Rows(0)(4).ToString)
            Me.lbDataOutLlista.Text = IIf(rs.Rows(0)(5) = "01/01/1970", "", rs.Rows(0)(5).ToString)
            Dim OnList As Boolean = CBool(rs.Rows(0)(6))
            Me.lbActvlLista.Text = IIf(OnList, LABEL_DINS_LLISTA, LABEL_FORA_LLISTA)
        End If
        rs.Dispose()
        db = Nothing
    End Sub

    Private Sub cmdOnPauta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOnPauta.Click
        OnPauta = Not OnPauta
        chkOnPauta.Checked = OnPauta
        Dim RowID As Integer = FindAfectatRow()
        Me.gridDades.Rows(RowID).Cells(6).Value = OnPauta
        Changed()
    End Sub

    Private Sub cmdRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefrescar.Click
        RefreshRecord()
    End Sub

    Friend Sub RefreshRecord()
        getListTemes()
    End Sub

    Private Sub txtRitme_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRitme.KeyPress, txtAny.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        If KeyAscii < Asc("0") Or KeyAscii > Asc("9") Then If KeyAscii <> 8 Then KeyAscii = 0
        e.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub Changed()
        If blEnable = True Then Me.cmdSalvar.Enabled = True : mnuSave.Enabled = True
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

    Private Sub NewRecord()
        blnNouRecord = True
        DeSelectAllRowsGrid(gridActual)
        gridActual.AllowUserToAddRows = True
        gridActual.FirstDisplayedScrollingRowIndex = gridActual.NewRowIndex
        Me.gridActual.Rows(gridActual.NewRowIndex).Selected = True
        Me.gridActual.Rows(gridActual.NewRowIndex).Cells(0).Value = 0
        'establir Valors per defecte (automàticament incorporats al datagrid)
        BorrarDadesPantalla(False)

        lbNou.Visible = True
        Me.LbID.Text = 0
        blEnable = False
        LockedRecord()
        Me.lbNou.Visible = True

        txtTitol.Focus()
    End Sub

    Private Sub LockedRecord(Optional ByVal saved As Boolean = False)
        If Me.cmdSalvar.Enabled = True And saved = False Then
            If MetroFramework.MetroMessageBox.Show(Me, MSG_SAVE_DADES, MSG_ATENCIO, MessageBoxButtons.OKCancel, MessageBoxIcon.Information, 100) = DialogResult.OK Then SaveRecord()
        End If
        blEnable = Not blEnable
        If blEnable = False Then blnNouRecord = False

        txtTitol.Enabled = blEnable
        ComboInterp.Enabled = blEnable
        ComboDisc.Enabled = blEnable
        'Me.Panel1.Enabled = blEnable

        listViewEstils.Enabled = blEnable
        ComboIdioma.Enabled = blEnable
        ComboTemp.Enabled = blEnable
        ComboSubj.Enabled = blEnable
        txtRitme.Enabled = blEnable
        lbBPM.Enabled = blEnable
        txtAny.Enabled = blEnable
        txtIntro.Enabled = blEnable
        scrollIntro.Enabled = blEnable

        'Me.Panel2.Enabled = blEnable
        chkOnPauta.Enabled = blEnable
        chkInstrument.Enabled = blEnable
        chkRestric.Enabled = blEnable
        chkForceMax.Enabled = blEnable

        'Me.Panel3.Enabled = blEnable
        txtTitol.Enabled = blEnable
        ComboInterp.Enabled = blEnable
        ComboDisc.Enabled = blEnable
        txtCompos.Enabled = blEnable
        txtComent.Enabled = blEnable

        'Me.Panel4.Enabled = blEnable
        cmdLlistaExitsIN.Enabled = False
        cmdLlistaExitsOUT.Enabled = False
        If blEnable = True Then cmdLlistaExitsIN.Enabled = (IsNumeric(Me.lbNumInLlista.Text) = False)
        If blEnable = True Then cmdLlistaExitsOUT.Enabled = (IsNumeric(Me.lbNumInLlista.Text) = True)

        Me.mnuCalcIntro.Enabled = blEnable
        Me.mnuCalDurada.Enabled = blEnable
        mnuEditAudio.Enabled = blEnable

        Me.mnuDel.Enabled = blEnable
        Me.mnuNew.Enabled = blEnable

        mnuValorsItems.Enabled = blEnable
        mnuModifMassive.Enabled = blEnable

        Me.cmdBorrar.Enabled = blEnable
        Me.lbNou.Visible = False
        If blEnable Then
            Me.cmdBloqueix.Image = Me.picUnLock.Image
        Else
            Me.cmdBloqueix.Image = Me.picLock.Image
            Me.cmdSalvar.Enabled = False
            mnuSave.Enabled = False
        End If
    End Sub

    Private Sub DeleteRecord()

        If blnNouRecord = True Then
            LockedRecord(True)
            BorrarDadesPantalla(False)
            gridDades.AllowUserToAddRows = False
            Exit Sub
        End If

        Dim MsgTxt As String = MSG_CONFIRM_DELETE_DADES
        If gridActual.SelectedRows.Count > 1 Then MsgTxt = String.Format(MSG_CONFIRM_DELETE_NUM_DADES, gridDades.SelectedRows.Count)

        If MetroFramework.MetroMessageBox.Show(Me, MsgTxt, MSG_ATENCIO, MessageBoxButtons.OKCancel, MessageBoxIcon.Information, 100) = DialogResult.Cancel Then Exit Sub


        Dim db As New MSC.dbs(Cloud)
        Dim StrSql As String = ""
        Dim Fitxer As String
        Dim fileWave As String

        db.IniTransaction()
        For i As Short = 0 To gridActual.SelectedRows.Count - 1
            'Borrar dbs			
            Dim ID As String = gridActual.SelectedRows(i).Cells(0).Value.ToString
            StrSql = "DELETE FROM temes WHERE tema_id = " & ID & " ;"
            db.Delete_ID(StrSql)
            addCtlRadi(0, CShort(Tipus_Play.CTL_SQL), 0, "00:00:00", 0, 0, Usuari.UsrID, StrSql, 0, False)
            'Borrar fitxer 			
            Fitxer = PathMusica & ID.ToString & ".mp3"
            fileWave = PathMusica & ID.ToString & ".wf"
            If IO.File.Exists(Fitxer) Then
                Try
                    IO.File.Delete(Fitxer)
                    If IO.File.Exists(fileWave) = True Then IO.File.Delete(fileWave)
                Catch ex As Exception
                    MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_DELETE_FILE, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
                End Try
            End If
        Next
        db.EndTransaction()
        db = Nothing
        'Borrar llistat      
        lbRecCount.Text = CInt(lbRecCount.Text) - gridActual.SelectedRows.Count
        gridActual.AllowUserToDeleteRows = True
        For Each selectedrow As DataGridViewRow In gridActual.SelectedRows
            gridActual.Rows.Remove(selectedrow)
        Next
        gridActual.AllowUserToDeleteRows = False
        RefreshDataSet(TAULES_DBS.TAULA_TEMES)

    End Sub

    Private Sub SaveRecord()
        Dim Titol As String
        Dim Interp, Disc As Short
        Dim Comp, Coment As String
        Dim Temps, Subj As Short
        Dim Backup, Ritme As Short
        Dim Intro, Durada As String

        Dim Idioma As Short
        Dim AnyPubli As Short
        Dim ForceMax, Instrument, Restric As Boolean

        If Not MyAPP.PermisPerContinuar() Then MetroFramework.MetroMessageBox.Show(Me, MSG_SERVER_CLOSE, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Stop, 100) : Me.Close()
        Try

            If MetroFramework.MetroMessageBox.Show(Me, MSG_CONFIRM_SAVE_DADES, MSG_ATENCIO, MessageBoxButtons.YesNo, MessageBoxIcon.Question, 100) = DialogResult.No Then Exit Sub
            ' el procediment de creació del codi de barres està pendent d'estandaritzar
            'TODO
            If Me.ComboInterp.SelectedValue < 1 Then
                MetroFramework.MetroMessageBox.Show(Me, "És obligatori especificar un intèrpret, pots especificar 'Varis'.", MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
                ComboInterp.SelectedValue = 1
                Exit Sub
            ElseIf Me.ComboDisc.SelectedValue < 1 Then
                MetroFramework.MetroMessageBox.Show(Me, "És obligatori especificar un disc.", MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
                Me.ComboDisc.Focus()
                Exit Sub
            End If
            IsSaving = True
            Dim ID As Integer = Me.LbID.Text
            Titol = AddSlashes(IIf(Len(txtTitol.Text) = 0, LABEL_TRACK_NUM & " " & Me.LbID.Text, Me.txtTitol.Text))
            Coment = AddSlashes(Me.txtComent.Text)
            Comp = AddSlashes(Me.txtCompos.Text)
            Ritme = IIf(Len(txtRitme.Text) = 0, 0, Me.txtRitme.Text)
            Intro = IIf(Len(txtIntro.Text) = 0, "00:00:00", Me.txtIntro.Text)
            Durada = Me.lbDurada.Text

            Disc = Me.ComboDisc.SelectedValue
            Interp = Me.ComboInterp.SelectedValue
            Idioma = Me.ComboIdioma.SelectedValue
            Temps = Me.ComboTemp.SelectedValue
            Subj = Me.ComboSubj.SelectedValue

            AnyPubli = IIf(Len(Me.txtAny.Text) > 0, txtAny.Text, 0)
            Instrument = IIf(Me.chkInstrument.CheckState, True, False)
            ForceMax = IIf(Me.chkForceMax.CheckState, True, False)
            Restric = IIf(Me.chkRestric.CheckState, True, False)

            Dim db As New MSC.dbs(Cloud)
            Dim sCmd As String
            If blnNouRecord = True Then

                sCmd = "INSERT INTO temes ( tema_interp, tema_titol, tema_disc, tema_compositor, tema_comentari "
                sCmd = sCmd & ",  tema_idioma, tema_temps, tema_subj"
                sCmd = sCmd & ", tema_ritme, tema_intro, tema_durada, tema_datain, tema_pautain, tema_any,tema_instrument,tema_forcemaxradi,tema_restric)"
                sCmd = sCmd & " VALUES "
                sCmd = sCmd & "( " & Interp
                sCmd = sCmd & ", '" & Titol & "'"
                sCmd = sCmd & ", " & Disc
                sCmd = sCmd & ", '" & Comp & "'"
                sCmd = sCmd & ", '" & Coment & "'"
                sCmd = sCmd & ", " & Idioma
                sCmd = sCmd & ", " & Temps
                sCmd = sCmd & ", " & Subj
                sCmd = sCmd & ", " & Ritme
                sCmd = sCmd & ", '" & Intro & "'"
                sCmd = sCmd & ", '" & Durada & "'"
                sCmd = sCmd & ", '" & Now.ToString("yyyy-MM-dd HH:mm:ss") & "'"
                sCmd = sCmd & ", " & CShort(IIf(OnPauta, 1, 0))
                sCmd = sCmd & ", " & AnyPubli
                sCmd = sCmd & ", " & CShort(IIf(Instrument, 1, 0))
                sCmd = sCmd & ", " & CShort(IIf(ForceMax, 1, 0))
                sCmd = sCmd & ", " & CShort(IIf(Restric, 1, 0))
                sCmd = sCmd & ");"

                ID = db.New_ID(sCmd)
                Me.gridActual.Rows(gridActual.NewRowIndex).Cells(0).Value = ID
                Dim newRecord As DataGridViewRow = gridActual.Rows(gridActual.NewRowIndex)
                Dim dt As DataTable
                If gridActual.DataSource IsNot Nothing Then
                    dt = gridActual.DataSource
                Else
                    dt = New DataTable
                    For col As Integer = 0 To gridActual.Columns.Count - 1
                        Dim idColumn As DataColumn = New DataColumn()
                        idColumn.ColumnName = gridActual.Columns(col).DataPropertyName
                        idColumn.DataType = gridActual.Columns(col).ValueType
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
                gridActual.AllowUserToAddRows = False
            Else
                sCmd = "UPDATE temes "
                sCmd = sCmd & " SET"
                sCmd = sCmd & " tema_titol = '" & Titol & "'"
                sCmd = sCmd & ",tema_interp = " & Interp
                sCmd = sCmd & ",tema_disc = " & Disc
                sCmd = sCmd & ",tema_compositor = '" & Comp & "'"
                sCmd = sCmd & ",tema_comentari = '" & Coment & "'"
                sCmd = sCmd & ",tema_idioma = " & Idioma
                sCmd = sCmd & ",tema_temps = " & Temps
                sCmd = sCmd & ",tema_subj = " & Subj
                sCmd = sCmd & ",tema_ritme  = " & Ritme
                sCmd = sCmd & ",tema_intro = '" & Intro & "'"
                sCmd = sCmd & ",tema_durada = '" & Durada & "'"
                sCmd = sCmd & ",tema_pautain = " & CShort(IIf(OnPauta, 1, 0))
                sCmd = sCmd & ",tema_any = " & AnyPubli
                sCmd = sCmd & ",tema_instrument = " & CShort(IIf(Instrument, 1, 0))
                sCmd = sCmd & ",tema_forcemaxradi = " & CShort(IIf(ForceMax, 1, 0))
                sCmd = sCmd & ",tema_restric = " & CShort(IIf(Restric, 1, 0))
                sCmd = sCmd & " WHERE tema_id = " & ID

                db.Update_ID(sCmd)

            End If

            Dim strValues As String = ""
            For i As Integer = 0 To Me.listViewEstils.Items.Count - 1
                If strValues.Length > 3 Then strValues += ","
                strValues += "( " & Tipus_Fitxers.FITXER_MUSICA & "," & ID & "," & CInt(listViewEstils.Items(i).Tag) & ")"
            Next
            db.ExecuteInstruc("DELETE FROM style_relationships WHERE style_relationships_tipfitxer=" & Tipus_Fitxers.FITXER_MUSICA & " AND style_relationships_fitxer=" & ID)
            If strValues.Length > 0 Then
                sCmd = "INSERT INTO style_relationships (`style_relationships_tipfitxer`,style_relationships_fitxer,`style_relationships_style`) VALUES " & strValues
                db.New_ID(sCmd)
            End If
            RefreshDataSet(TAULES_DBS.TAULA_STYLE_RELATIONSHIPS)
            db = Nothing
            IsSaving = False
            LockedRecord(True)
            Me.gridActual.Focus()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_SAVE_ITEM, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
            Err.Clear()
        End Try
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

    Private Sub scrollIntro_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles scrollIntro.Scroll
        Me.txtIntro.Text = TimeSerial(0, 0, 360 - scrollIntro.Value)
        Changed()
    End Sub

    Private Sub KeyPress_Combo(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles _
         ComboDisc.KeyPress, ComboIdioma.KeyPress, ComboSubj.KeyPress, ComboTemp.KeyPress, ComboInterp.KeyPress

        If My.Settings.TXT_CAPITALIZE Then e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub KeyUp_Combo(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles _
         ComboDisc.KeyUp _
        , ComboIdioma.KeyUp, ComboSubj.KeyUp, ComboTemp.KeyUp, ComboInterp.KeyUp

        Select Case e.KeyCode
            Case Keys.Left, Keys.Right, Keys.Up, Keys.Down
                Return
        End Select
        Dim MyComboBox As ComboBox = CType(sender, ComboBox)
        Dim Origen As TAULES_DBS
        Select Case MyComboBox.Name
            Case "ComboInterp" : Origen = TAULES_DBS.TAULA_INTERPRETS
            Case "ComboDisc" : Origen = TAULES_DBS.TAULA_DISCOS
            Case "ComboEstil" : Origen = TAULES_DBS.TAULA_ESTILS
            Case "ComboIdioma" : Origen = TAULES_DBS.TAULA_IDIOMES
            Case "ComboSubj" : Origen = TAULES_DBS.TAULA_SUBJECTIV
            Case "ComboTemp" : Origen = TAULES_DBS.TAULA_TEMPORALITAT
        End Select
        refreshComboBoxKeyUp(MyComboBox, Origen, TotsCap.CAP)

    End Sub

    Private Sub Combo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)

        Dim MyComboBox As ComboBox = CType(sender, ComboBox)
        Dim ID As Integer = MyComboBox.SelectedValue
        Dim Origen As TAULES_DBS
        Select Case MyComboBox.Name
            Case "ComboInterp" : Origen = TAULES_DBS.TAULA_INTERPRETS
            Case "ComboDisc" : Origen = TAULES_DBS.TAULA_DISCOS
            Case "ComboIdioma" : Origen = TAULES_DBS.TAULA_IDIOMES
            Case "ComboSubj" : Origen = TAULES_DBS.TAULA_SUBJECTIV
            Case "ComboTemp" : Origen = TAULES_DBS.TAULA_TEMPORALITAT
        End Select
        Dim Cmb As New combo
        Cmb.OmpleCombo(MyComboBox, Origen, TotsCap.CAP)
        MyComboBox.SelectedValue = ID
    End Sub


    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAppExit.Click
        Me.Close()
    End Sub

    Private Sub mnuModif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuModif.Click _
        , mnuDel.Click, mnuSave.Click, mnuNew.Click, mnuBuscar.Click, mnuRefresh.Click
        Select Case CType(sender, ToolStripMenuItem).Tag
            Case 1 : LockedRecord() '"Modificar"
            Case 2 : SaveRecord() '"Salvar"
            Case 3 : NewRecord() '"Nou"
            Case 4 : DeleteRecord() '"Borrar"
            Case 5 : FindRecord() '"Buscar"
            Case 6 : RefreshRecord() '"Refrescar"
        End Select
    End Sub

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        FindRecord()
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

    Private Sub Click_ToolStripMenuItem(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
        IntèrpretToolStripMenuItem.Click, DiscToolStripMenuItem.Click _
        , CompositorToolStripMenuItem.Click, EstilToolStripMenuItem.Click _
        , IdiomaToolStripMenuItem.Click, ClasTemporalToolStripMenuItem.Click _
        , ClasSubjeToolStripMenuItem.Click, AnyToolStripMenuItem.Click

        CType(sender, ToolStripMenuItem).Checked = Not CType(sender, ToolStripMenuItem).Checked
        Dim FitxerINI As New IniFile
        FitxerINI.INIWrite(MyAPP.IniFile, "Data Control", "VALOR" & CType(sender, ToolStripMenuItem).Tag, IIf(CType(sender, ToolStripMenuItem).Checked, 1, 0))
    End Sub

    Private Sub mnuAddTot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAddTot.Click
        gridTemesSelect.AllowUserToAddRows = True

        For i As Integer = 0 To Me.gridDades.Rows.Count - 1
            Dim r2 As DataGridViewRow = gridDades.Rows(i).Clone
            Dim CI As Integer = 0
            For Each cell As DataGridViewCell In gridDades.Rows(i).Cells
                r2.Cells(CI).Value = cell.Value
                CI = CI + 1
            Next
            Me.gridTemesSelect.Rows.Add(r2)
        Next
        gridTemesSelect.Refresh()
        gridTemesSelect.AllowUserToAddRows = False
    End Sub

    Private Sub mnuAddSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAddSelect.Click

        gridTemesSelect.AllowUserToAddRows = True
        For I As Integer = 0 To Me.gridDades.SelectedRows.Count - 1
            Dim r2 As DataGridViewRow = gridDades.SelectedRows(I).Clone
            Dim CI As Integer = 0
            For Each cell As DataGridViewCell In gridDades.SelectedRows(I).Cells
                r2.Cells(CI).Value = cell.Value
                CI = CI + 1
            Next
            Me.gridTemesSelect.Rows.Add(r2)
        Next
        gridTemesSelect.Refresh()
        gridTemesSelect.AllowUserToAddRows = False
    End Sub


    Private Sub mnuDelTot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDelTot.Click
        gridTemesSelect.AllowUserToDeleteRows = True
        Me.gridTemesSelect.Rows.Clear()
        gridTemesSelect.AllowUserToDeleteRows = False
    End Sub

    Private Sub mnuDelSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDelSelect.Click
        gridTemesSelect.AllowUserToDeleteRows = True
        For i As Integer = 0 To gridTemesSelect.SelectedRows.Count - 1
            Dim row As DataGridViewRow = gridTemesSelect.SelectedRows(i)
            gridTemesSelect.Rows.Remove(row)
        Next
        gridTemesSelect.AllowUserToDeleteRows = False
    End Sub

    Private Sub mnuModifMassive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuModifMassive.Click
        If gridTemesSelect.Rows.Count Then
            PanelModifMassive.Location = New Point((Me.DisplayRectangle.Width - PanelModifMassive.Width) / 2, 5)
            PanelModifMassive.Visible = True
        Else
            MetroFramework.MetroMessageBox.Show(Me, MSG_NO_TEMES_MODIF_MASSIVE, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
        End If
    End Sub

    Private Sub cmdLlistaExitsOUT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLlistaExitsOUT.Click
        BorrarEntradaLlistaExits()
    End Sub

    Private Sub cmdLlistaExitsIN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLlistaExitsIN.Click
        NovaEntradaLlistaExits()
    End Sub

    Private Sub NovaEntradaLlistaExits()
        Dim db As New MSC.dbs(Cloud)
        Dim NunIntro As Short
        If Me.LbID.Text > 0 Then
            Try
                NunIntro = CShort(InputBox(MSG_LLISTA_EXIT_INI_POS, LABEL_LLISTA_EXITS))
            Catch ex As Exception
                'No s'ha escrit un número
                NunIntro = 99
            End Try

            Dim sCmd As String = "INSERT INTO llistaexits (tops_id, tops_numllista,tops_numintro, tops_datain"
            If NunIntro = 1 Then sCmd = sCmd & ", tops_datatop"
            sCmd = sCmd & ") VALUES "
            sCmd = sCmd & " ( " & Me.LbID.Text
            sCmd = sCmd & " , " & NunIntro
            sCmd = sCmd & " , " & NunIntro
            sCmd = sCmd & " , '" & Now.ToString("yyyy-MM-dd HH:mm:ss") & "'"
            If NunIntro = 1 Then sCmd = sCmd & " , '" & Now.ToString("yyyy-MM-dd HH:mm:ss") & "'"
            sCmd = sCmd & ");"
            db.New_ID(sCmd)

            db = Nothing
            Me.ComboTemp.SelectedValue = mdlMscDefines.CatTemp.TOP_
            RefresTemLlistaExits()
        End If
    End Sub

    Private Sub BorrarEntradaLlistaExits()
        If Len(Me.lbNumlLista.Text) > 0 Then
            Dim db As New MSC.dbs(Cloud)
            Dim sCmd As String = "UPDATE llistaexits"
            sCmd = sCmd & " SET "
            sCmd = sCmd & " tops_activa = 0 "
            sCmd = sCmd & ", tops_dataout = '" & Now.ToString("yyyy-MM-dd HH:mm:ss") & "'"
            sCmd = sCmd & " WHERE tops_id = " & Me.LbID.Text & " ;"
            db.Update_ID(sCmd)
            db = Nothing
            RefresTemLlistaExits()
            Me.cmdLlistaExitsOUT.Enabled = False
        End If
    End Sub


    Private Sub lbBPM_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lbBPM.MouseDown
        _bpm.TapBeat()
        Me.txtRitme.Text = _bpm.TappedBPM.ToString("#00")
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        'TODO: Habilitar informes.
        Dim frmPRT As New frmPrint
        Dim StrTitol As String = InputBox(MSG_ESCRIU_TITOL, MSG_ATENCIO, LABEL_LLISTA_TEMES)
        If Len(StrTitol) < 2 Then StrTitol = LABEL_LLISTA_TEMES
        frmPRT.DefineLlistat(gridActual, frmPrint.Tipusllistats.LLISTAT_Temes, StrTitol)

        'If Me.TabControl1.SelectedIndex = 0 Then
        '    frmPRT.DefineLlistat(Me.gridTemes, frmPrint.Tipusllistats.LLISTAT_Temes, StrTitol)
        'Else
        '    frmPRT.DefineLlistat(Me.gridTemesSelect, frmPrint.Tipusllistats.LLISTAT_Temes, StrTitol)
        'End If
        Try
            frmPRT.Show(Me)
        Catch ex As Exception
            frmPRT.WindowState = FormWindowState.Normal
        End Try
    End Sub

    Private Sub mnuUltimTema_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuUltimTema10.Click, mnuUltimTema100.Click, mnuUltimTema25.Click, mnuUltimTema50.Click
        Dim NumLimit As Short = CShort(CType(sender, ToolStripMenuItem).Tag)


        Dim sqlStr As String = "SELECT ctl_fitxer FROM controlradiacio WHERE ctl_tipfitxer = 2 order by ctl_id desc limit " & NumLimit & ";"
        Dim db As New MSC.dbs(Cloud)
        Dim rsCtl As DataTable = db.getTable(sqlStr)
        Dim StrTemes As String = ""
        For i As Integer = 0 To rsCtl.Rows.Count - 1
            If StrTemes.Length > 0 Then StrTemes = StrTemes & " OR  "
            StrTemes = StrTemes & "tema_id = " & rsCtl.Rows(i)(0).ToString
        Next i
        rsCtl.Dispose()
        db = Nothing

        StrTemes = StrTemes & " ORDER By tema_dataradiacio desc"
        getListTemes(StrTemes)
    End Sub

    Private Sub mnuColumVisibles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuColumVisiblesVots.Click, mnuColumVisiblesTemp.Click, mnuColumVisiblesSubj.Click, mnuColumVisiblesRitme.Click, mnuColumVisiblesRadi.Click, mnuColumVisiblesIdioma.Click, mnuColumVisiblesDurada.Click, mnuColumVisiblesAny.Click

        Dim Check As Boolean = Not CType(sender, ToolStripMenuItem).Checked
        CType(sender, ToolStripMenuItem).Checked = Check
        Dim IdColumn As Integer = CType(sender, ToolStripMenuItem).Tag
        Me.gridDades.Columns(IdColumn).Visible = Check
        Me.gridTemesSelect.Columns(IdColumn).Visible = Check

    End Sub


    Private Sub mnuFindUltRadi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFindUltRadi.Click
        Dim TemaID As Short = CShort(Me.LbID.Text)
        Dim sqlStr As String = "SELECT `controlradiacio`.`ctl_dataradiacio` FROM `controlradiacio` WHERE ( `controlradiacio`.`ctl_fitxer` = " & TemaID & " ) AND ( ( `controlradiacio`.`ctl_tipfitxer` = 2 ) ) ORDER BY `controlradiacio`.`ctl_dataradiacio` DESC"
        Dim StrInfo As String = ""
        Dim db As New MSC.dbs(Cloud)
        Dim rsHist As DataTable = db.getTable(sqlStr)
        For i As Integer = 0 To rsHist.Rows.Count - 1
            StrInfo = StrInfo & rsHist.Rows(i)("ctl_dataradiacio").ToString
            StrInfo = StrInfo & vbCrLf
        Next
        db = Nothing
        rsHist.Dispose()
        StrInfo = StrInfo & vbCrLf & String.Format(MSG_TOTAL_RADIACIONS, rsHist.Rows.Count)
        Dim InfoMsg As frmTip = New frmTip
        InfoMsg.ShowMessage(StrInfo, String.Format(TITLE_RADIACIO_TEMA, Me.txtTitol.Text), IconStyles.Information, ContentAlignment.MiddleCenter, , , True, , , , , Themes.WinXpStyle, MessageBoxButtons.OK)
    End Sub

    Private Sub gridTemes_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridDades.CurrentCellChanged, gridTemesSelect.CurrentCellChanged
        ShowValuesTema()
    End Sub

    Private Sub gridTemes_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles gridDades.DataError
        'Per evitar missatge al crear nou item
    End Sub

#Region "Edita datagrid"

    Private Function FindAfectatRow() As Integer
        If blnNouRecord Then
            Return gridActual.NewRowIndex
        Else
            Return gridActual.CurrentRow.Index
        End If
    End Function

    Private Sub txtTitol_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTitol.TextChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Dim co As String = gridActual.Columns(1).Name
            Me.gridActual.Rows(RowID).Cells(1).Value = txtTitol.Text
            Changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ComboInterp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboInterp.SelectedIndexChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Dim co As String = gridActual.Columns(2).Name
            Me.gridActual.Rows(RowID).Cells(2).Value = ComboInterp.SelectedValue
            Changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ComboDisc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboDisc.SelectedIndexChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Dim co As String = gridActual.Columns(3).Name
            Me.gridActual.Rows(RowID).Cells(3).Value = ComboDisc.SelectedValue
            Changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtCompos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCompos.TextChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Dim co As String = gridActual.Columns(4).Name
            Me.gridActual.Rows(RowID).Cells(4).Value = txtCompos.Text
            Changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtComent_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtComent.TextChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Dim co As String = gridActual.Columns(5).Name
            Me.gridActual.Rows(RowID).Cells(5).Value = txtComent.Text

            Changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ComboIdioma_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboIdioma.SelectedIndexChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Dim co As String = gridActual.Columns(10).Name
            Me.gridActual.Rows(RowID).Cells(10).Value = ComboIdioma.SelectedValue

            Changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ComboTemp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboTemp.SelectedIndexChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Dim co As String = gridActual.Columns(11).Name
            Me.gridActual.Rows(RowID).Cells(11).Value = ComboTemp.SelectedValue

            Changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ComboSubj_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboSubj.SelectedIndexChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Dim co As String = gridActual.Columns(12).Name
            Me.gridActual.Rows(RowID).Cells(12).Value = ComboSubj.SelectedValue

            Changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub chkInstrument_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkInstrument.CheckedChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Dim co As String = gridActual.Columns(7).Name
            Me.gridActual.Rows(RowID).Cells(7).Value = chkInstrument.Checked

            Changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub chkRestric_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRestric.CheckedChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Dim co As String = gridActual.Columns(8).Name
            Me.gridActual.Rows(RowID).Cells(8).Value = chkRestric.Checked
            Changed()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub chkForceMax_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkForceMax.CheckedChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Dim co As String = gridActual.Columns(9).Name
            Me.gridActual.Rows(RowID).Cells(9).Value = chkForceMax.Checked
            Changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtRitme_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRitme.TextChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Dim co As String = gridActual.Columns(13).Name
            Me.gridActual.Rows(RowID).Cells(13).Value = txtRitme.Text

            Changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtAny_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAny.TextChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Dim co As String = gridActual.Columns(14).Name
            Me.gridActual.Rows(RowID).Cells(14).Value = txtAny.Text

            Changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtIntro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIntro.TextChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Dim co As String = gridActual.Columns(15).Name
            Me.gridActual.Rows(RowID).Cells(15).Value = txtIntro.Text

            Changed()
        Catch ex As Exception
        End Try
    End Sub

#End Region

    Private Sub TabControl1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.Click
        If Me.TabControl1.SelectedIndex = 0 Then
            gridActual = Me.gridDades
        Else
            gridActual = Me.gridTemesSelect
        End If
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
            Dim strPathFitxer As String = PathMusica & Me.LbID.Text & ".mp3"

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

    Private Sub stopFitxer()
        Bass.BASS_ChannelStop(StreamHandlePlay)
        Bass.BASS_StreamFree(StreamHandlePlay)
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

    Private Sub mnuPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPlay.Click, mnuStop.Click, mnuCalDurada.Click, mnuCalcIntro.Click, mnuFinal.Click

        Select Case CType(sender, ToolStripMenuItem).Tag
            Case 1 : PlayFitxer()
            Case 2 : stopFitxer()
            Case 3 '"Calcular Durada"
                Dim len As Long = Bass.BASS_ChannelGetLength(StreamHandlePlay)
                Me.lbDurada.Text = TimeSerial(0, 0, Bass.BASS_ChannelBytes2Seconds(StreamHandlePlay, len))
                Dim RowID As Integer = FindAfectatRow()
                Me.gridDades.Rows(RowID).Cells(16).Value = lbDurada.Text
                Changed()
            Case 4 '"Calcular Intro"
                Dim Pos As Long = Bass.BASS_ChannelGetPosition(StreamHandlePlay)
                Me.txtIntro.Text = TimeSerial(0, 0, Bass.BASS_ChannelBytes2Seconds(StreamHandlePlay, Pos)) : Changed()
            Case 5 '"Final Tema"
                Dim len As Long = Bass.BASS_ChannelGetLength(StreamHandlePlay)
                Dim LenInSeg As Single = Bass.BASS_ChannelBytes2Seconds(StreamHandlePlay, len)
                Bass.BASS_ChannelSetPosition(StreamHandlePlay, CSng(LenInSeg - 20))
        End Select
    End Sub


#End Region


    Private Sub tmrDetalls_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDetalls.Tick
        'Tornar a consultar a la dbs els detalls del la cançó.
        tmrDetalls.Enabled = False
        RefresTemLlistaExits()
        Dim strPathFitxer As String = PathMusica & Me.LbID.Text & ".mp3"
        Me.lbAtencio.Visible = Not IO.File.Exists(strPathFitxer)

    End Sub

    Private Sub mnuEditAudio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditAudio.Click

        Bass.BASS_ChannelStop(StreamHandlePlay)
        Bass.BASS_StreamFree(StreamHandlePlay)
        If ProgEditAudio.Length > 0 Then
            Dim PathFitxer As String = ""

            For i As Integer = 0 To gridActual.SelectedRows.Count - 1
                Dim tempPath As String = PathMusica & gridActual.SelectedRows(i).Cells(0).Value & ".mp3"
                If IO.File.Exists(tempPath) Then
                    PathFitxer += " " & Chr(34) & tempPath & Chr(34)
                End If
            Next
            If PathFitxer.Length < 3 Then Exit Sub
            Try
                Dim p As System.Diagnostics.Process = New System.Diagnostics.Process()
                p.StartInfo.Arguments = PathFitxer.Trim
                p.StartInfo.FileName = ProgEditAudio
                p.Start()
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub mnu_Help_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHelpManual.Click
        Dim Proces As Process = New Process
        Try
            Process.Start(MSC.Help.HELP_GEST_PRODUCCIO_CANCONS.ToString)
        Catch ex As Exception
        End Try
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

    Sub PicFilterClick(sender As Object, e As EventArgs) Handles MetroLink1.Click, MetroLink2.Click, MetroLink6.Click, MetroLink5.Click, MetroLink4.Click, MetroLink3.Click, MetroLink8.Click
        Dim MyFilter As MetroFramework.Controls.MetroLink = CType(sender, MetroFramework.Controls.MetroLink)
        Dim StrSql As String = ""
        Select Case MyFilter.Tag
            Case TAULES_DBS.TAULA_ESTILS

                If Me.listViewEstils.SelectedItems.Count > 0 Then
                    Dim estil_id As Integer
                    estil_id = listViewEstils.SelectedItems(0).Tag

                    Dim sCmd As String = "style_relationships_tipfitxer = " & Tipus_Fitxers.FITXER_MUSICA & " AND `style_relationships_style` = " & estil_id
                    Dim colec() As DataRow = dsClient.Tables("style_relationships").Select(sCmd)

                    For i As Integer = 0 To colec.Length - 1
                        If StrSql.Length > 3 Then StrSql += " OR "
                        Dim tema_id As Integer = colec(i)("style_relationships_fitxer").ToString
                        StrSql += "tema_id = " & tema_id
                    Next

                Else
                    Exit Sub
                End If
            Case TAULES_DBS.TAULA_SUBJECTIV
                If ComboSubj.SelectedValue > 0 Then
                    StrSql = "tema_subj = " & Me.ComboSubj.SelectedValue
                Else
                    Exit Sub
                End If
            Case TAULES_DBS.TAULA_INTERPRETS
                If Me.ComboInterp.SelectedValue > 0 Then
                    StrSql = "tema_interp = " & Me.ComboInterp.SelectedValue
                Else
                    Exit Sub
                End If
            Case TAULES_DBS.TAULA_IDIOMES
                If ComboIdioma.SelectedValue > 0 Then
                    StrSql = "tema_idioma = " & Me.ComboIdioma.SelectedValue
                Else
                    Exit Sub
                End If
            Case TAULES_DBS.TAULA_TEMPORALITAT
                If ComboTemp.SelectedValue > 0 Then
                    StrSql = "tema_temps = " & Me.ComboTemp.SelectedValue
                Else
                    Exit Sub
                End If
            Case TAULES_DBS.TAULA_DISCOS
                If ComboDisc.SelectedValue > 0 Then
                    StrSql = "tema_disc = " & Me.ComboDisc.SelectedValue
                Else
                    Exit Sub
                End If
            Case 100
                If IsNumeric(txtRitme.Text) Then
                    Dim BPM As Integer = Me.txtRitme.Text
                    StrSql = "tema_ritme BETWEEN " & BPM - 20 & " AND " & BPM + 20 ' ritme
                Else
                    Exit Sub
                End If
            Case 101
                If IsNumeric(txtAny.Text) AndAlso txtAny.Text > 0 Then
                    StrSql = "tema_any = " & Me.txtAny.Text ' any
                Else
                    Exit Sub
                End If

        End Select
        getListTemes(StrSql)

    End Sub

    Sub ListViewEstilsMouseDown(sender As Object, e As MouseEventArgs) Handles listViewEstils.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            Me.contextMenuStripEstils.Show(listViewEstils, Me.listViewEstils.PointToClient(System.Windows.Forms.Cursor.Position))
        End If
    End Sub

    Sub addEstil_Click(sender As Object, e As EventArgs)
        Dim estil_id As Integer = CInt(CType(sender, ToolStripMenuItem).Tag)
        Dim estil_nom As String = CType(sender, ToolStripMenuItem).Text.ToString

        Dim item As New ListViewItem
        item.Text = estil_nom
        item.Tag = estil_id
        Me.listViewEstils.Items.Add(item)
        Changed()

    End Sub

    Sub MnuEstilsDeleteClick(sender As Object, e As EventArgs) Handles mnuEstilsDelete.Click
        Try
            listViewEstils.SelectedItems(0).Remove()
            Changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub lbInterp_Click(sender As Object, e As EventArgs) Handles lbInterp.Click
        Dim FrmChild As New frmMantInterp
        Try
            FrmChild.IniTable()
            If ComboInterp.SelectedValue > 0 Then FrmChild.establirRecordset(" interp_nom = '" & Me.ComboInterp.Text & "'")
            If FrmChild.ShowDialog = DialogResult.OK Then
                Dim Cmb As New combo
                Cmb.OmpleCombo(ComboInterp, TAULES_DBS.TAULA_INTERPRETS, TotsCap.CAP)
                ComboInterp.SelectedValue = FrmChild.ID
            End If
        Catch ex As Exception
        End Try
        FrmChild = Nothing
    End Sub

    Private Sub lbDisc_Click(sender As Object, e As EventArgs) Handles lbDisc.Click
        Dim FrmChild As New frmDiscos
        Try
            FrmChild.IniTable()
            If ComboDisc.SelectedValue > 0 Then FrmChild.getListDiscos(" disc_nom = '" & Me.ComboDisc.Text & "'")
            If FrmChild.ShowDialog = DialogResult.OK Then
                Dim Cmb As New combo
                Cmb.OmpleCombo(ComboDisc, TAULES_DBS.TAULA_DISCOS, TotsCap.CAP)
                ComboDisc.SelectedValue = FrmChild.ID
            End If
        Catch ex As Exception
        End Try
        FrmChild = Nothing

    End Sub

    Private Sub lbEstil_Click(sender As Object, e As EventArgs) Handles lbEstil.Click
        Dim FrmChild As New frmMantEstil
        Try
            Dim Nom_estil As String = ""
            If Me.listViewEstils.SelectedItems.Count > 0 Then
                Nom_estil = listViewEstils.SelectedItems(0).Text
            Else
                Nom_estil = ""
            End If
            FrmChild.IniTable()
            If Nom_estil.Length > 0 Then FrmChild.establirRecordset(" estil_nom = '" & Nom_estil & "'")
            If FrmChild.ShowDialog = DialogResult.OK Then
                RefreshStyles(LbID.Text)
            End If
        Catch ex As Exception
        End Try
        FrmChild = Nothing

    End Sub

    Private Sub lbIdioma_Click(sender As Object, e As EventArgs) Handles lbIdioma.Click
        Dim FrmChild As New frmMantIdioma
        Try
            FrmChild.IniTable()
            If ComboIdioma.SelectedValue > 0 Then FrmChild.establirRecordset(" nom_nadiu = '" & Me.ComboIdioma.Text & "'")
            If FrmChild.ShowDialog = DialogResult.OK Then
                Dim Cmb As New combo
                Cmb.OmpleCombo(ComboIdioma, TAULES_DBS.TAULA_IDIOMES, TotsCap.CAP)
                ComboIdioma.SelectedValue = FrmChild.ID
            End If
        Catch ex As Exception
        End Try
        FrmChild = Nothing
    End Sub

    Private Sub lbClasSubj_Click(sender As Object, e As EventArgs) Handles lbClasSubj.Click
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

    Private Sub frmTemes_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
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

    Private Sub buttonHideMassive_Click(sender As Object, e As EventArgs) Handles buttonHideMassive.Click
        If Me.ProgressBar.Visible = True Then Exit Sub
        PanelModifMassive.Visible = False
    End Sub

    Dim MouseIsDown As Boolean = False
    Dim MouseIsDownLoc As Point = Nothing
    Private Sub PanelAssistent_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelModifMassive.MouseMove
        If e.Button = MouseButtons.Left Then
            If MouseIsDown = False Then
                MouseIsDown = True
                MouseIsDownLoc = New Point(e.X, e.Y)
            End If
            PanelModifMassive.Location = New Point(Me.Location.X + e.X - MouseIsDownLoc.X, PanelModifMassive.Location.Y + e.Y - MouseIsDownLoc.Y)
        End If
    End Sub

    Private Sub PanelAssistent_MouseUp(sender As Object, e As MouseEventArgs) Handles PanelModifMassive.MouseUp
        MouseIsDown = False
    End Sub

    Dim Cancelled As Boolean
    Dim streamBPM As Integer
    Dim PathTemes As String = Params.PathMusica & "\"
    Dim Id_List As Short
    Dim isActv As Un4seen.Bass.BASSActive
    Dim PosFinal As Single
    Dim frmMusic As frmTemes

    Private Sub chkInterp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkActiveInterp.CheckedChanged
        Me.ComboBoxInterp.Enabled = chkActiveInterp.Checked
        If ComboBoxInterp.Enabled Then ComboBoxInterp.Focus()
    End Sub

    Private Sub chkDisc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkActiveDisc.CheckedChanged
        Me.ComboBoxDisc.Enabled = chkActiveDisc.Checked
        If ComboBoxDisc.Enabled Then ComboBoxDisc.Focus()
    End Sub

    Private Sub chkEstil_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkActiveEstil.CheckedChanged
        Me.ComboEstil.Enabled = chkActiveEstil.Checked
        If ComboEstil.Enabled Then ComboEstil.Focus()
    End Sub

    Private Sub chkIdioma_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkActiveIdioma.CheckedChanged
        Me.ComboBoxIdioma.Enabled = chkActiveIdioma.Checked
        If ComboBoxIdioma.Enabled Then ComboBoxIdioma.Focus()
    End Sub

    Private Sub chkClasTemp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkActiveClasTemp.CheckedChanged
        Me.ComboClasTemp.Enabled = chkActiveClasTemp.Checked
        If ComboClasTemp.Enabled Then ComboClasTemp.Focus()
    End Sub

    Private Sub chkClasSubj_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkActiveClasSubj.CheckedChanged
        Me.ComboClasSubj.Enabled = chkActiveClasSubj.Checked
        If ComboClasSubj.Enabled Then ComboClasSubj.Focus()
    End Sub

    Private Sub chkActiveOnPauta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkActiveOnPauta.CheckedChanged
        Me.chkOnOffMassive.Enabled = chkActiveOnPauta.Checked
    End Sub

    Private Sub chkActiveAny_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkActiveAny.CheckedChanged
        Me.TextBoxAny.Enabled = chkActiveAny.Checked
    End Sub

    Private Sub chkActiveIntrum_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkActiveIntrum.CheckedChanged
        Me.chkInstrumentMassive.Enabled = chkActiveIntrum.Checked
    End Sub

    Private Sub chkActiveForca_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkActiveForca.CheckedChanged
        Me.chkForceMaxMassive.Enabled = chkActiveForca.Checked
    End Sub

    Private Sub chkActiveRestric_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkActiveRestric.CheckedChanged
        Me.chkRestricMassive.Enabled = chkActiveRestric.Checked
    End Sub

    Private Sub TextBoxAny_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxAny.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        If KeyAscii < Asc("0") Or KeyAscii > Asc("9") Then If KeyAscii <> 8 Then KeyAscii = 0
        e.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub cmdCalc_Click(sender As Object, e As EventArgs) Handles cmdCalc.Click
        Dim i As Short
        If Me.chkActiveInterp.Checked = True Then
            If Me.ComboInterp.SelectedValue < 1 Then
                MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_ESPECIF_INTERPRET, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
                ComboInterp.SelectedValue = 1
                Exit Sub
            End If
        End If
        If Me.chkActiveDisc.Checked = True Then
            If Me.ComboDisc.SelectedValue < 1 Then
                MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_ESPECIF_DISC, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
                Me.ComboDisc.Focus()
                Exit Sub
            End If
        End If

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.AppStarting
        Cancelled = False
        Me.ProgressBar.Visible = True
        Me.cmdCancel.Visible = True
        Me.cmdExit.Enabled = False
        buttonHideMassive.Enabled = False
        AmbTasquesPendents = True
        ProgressBar.Maximum = Me.gridTemesSelect.Rows.Count

        Dim db As New MSC.dbs(Cloud)
        For i = 0 To Me.gridTemesSelect.Rows.Count - 1
            If Cancelled Then If MetroFramework.MetroMessageBox.Show(Me, MSG_CONFIRM_CANCEL, MSG_ATENCIO, MessageBoxButtons.YesNo, MessageBoxIcon.Question, 100) = DialogResult.Yes Then Exit For

            Dim id As Short = Me.gridTemesSelect.Rows(i).Cells(0).Value
            Dim Titol As String = Me.gridTemesSelect.Rows(i).Cells(1).Value
            Dim Interp As Short = Me.ComboBoxInterp.SelectedValue
            Dim Disc As Short = Me.ComboBoxDisc.SelectedValue
            Dim Estil As Short = Me.ComboEstil.SelectedValue
            Dim Idioma As Short = Me.ComboBoxIdioma.SelectedValue
            Dim Temps As Short = Me.ComboClasTemp.SelectedValue
            Dim Subj As Short = Me.ComboClasSubj.SelectedValue


            Dim PautaIn As Boolean = Me.chkOnOffMassive.Checked
            Dim AnyPubli As String = Me.TextBoxAny.Text
            Dim Instrument As Boolean = Me.chkInstrumentMassive.Checked
            Dim ForceMax As Boolean = Me.chkForceMaxMassive.Checked
            Dim Restric As Boolean = Me.chkRestricMassive.Checked

            Dim sCmd As String = "UPDATE temes "
            sCmd = sCmd & " SET"
            sCmd = sCmd & " tema_titol = '" & AddSlashes(Titol) & "'"
            If Me.chkActiveInterp.Checked = True Then sCmd = sCmd & ",tema_interp = " & Interp
            If chkActiveDisc.Checked = True Then sCmd = sCmd & ",tema_disc = " & Disc

            If Me.chkActiveIdioma.Checked = True Then sCmd = sCmd & ",tema_idioma = " & Idioma
            If chkActiveClasTemp.Checked = True Then sCmd = sCmd & ",tema_temps = " & Temps
            If chkActiveClasSubj.Checked = True Then sCmd = sCmd & ",tema_subj = " & Subj
            If chkActiveOnPauta.Checked = True Then sCmd = sCmd & ",tema_pautain = " & CShort(IIf(PautaIn, 1, 0))
            If chkActiveAny.Checked = True Then sCmd = sCmd & ",tema_any = " & AnyPubli
            If chkActiveIntrum.Checked = True Then sCmd = sCmd & ",tema_instrument = " & CShort(IIf(Instrument, 1, 0))
            If chkActiveForca.Checked = True Then sCmd = sCmd & ",tema_forcemaxradi = " & CShort(IIf(ForceMax, 1, 0))
            If chkActiveRestric.Checked = True Then sCmd = sCmd & ",tema_restric = " & CShort(IIf(Restric, 1, 0))
            sCmd = sCmd & " WHERE tema_id = " & id
            db.Update_ID(sCmd)

            If Me.chkActiveEstil.Checked = True Then
                sCmd = "INSERT INTO style_relationships (`style_relationships_tipfitxer`,style_relationships_fitxer,`style_relationships_style`) VALUES ( " & Tipus_Fitxers.FITXER_MUSICA & "," & id & "," & ComboEstil.SelectedValue & ")"
                db.Update_ID(sCmd)
            End If

            If chkActiveInterp.Checked = True Then Me.gridTemesSelect.Rows(i).Cells(2).Value = ComboBoxInterp.SelectedValue
            If chkActiveDisc.Checked = True Then Me.gridTemesSelect.Rows(i).Cells(3).Value = ComboBoxDisc.SelectedValue
            If chkActiveOnPauta.Checked = True Then Me.gridTemesSelect.CurrentRow.Cells(6).Value = PautaIn
            If chkActiveIntrum.Checked = True Then Me.gridTemesSelect.Rows(i).Cells(7).Value = Instrument
            If chkActiveRestric.Checked = True Then Me.gridTemesSelect.Rows(i).Cells(8).Value = Restric
            If chkActiveForca.Checked = True Then Me.gridTemesSelect.Rows(i).Cells(9).Value = ForceMax

            If chkActiveIdioma.Checked = True Then Me.gridTemesSelect.Rows(i).Cells(10).Value = ComboBoxIdioma.SelectedValue
            If chkActiveClasTemp.Checked = True Then Me.gridTemesSelect.Rows(i).Cells(11).Value = ComboClasTemp.SelectedValue
            If chkActiveClasSubj.Checked = True Then Me.gridTemesSelect.Rows(i).Cells(13).Value = ComboClasSubj.SelectedValue
            If chkActiveAny.Checked = True Then Me.gridTemesSelect.Rows(i).Cells(15).Value = AnyPubli

            gridTemesSelect.Refresh()
            System.Windows.Forms.Application.DoEvents()
            Me.Refresh()
            If Cancelled Then Exit For
            ProgressBar.Value = i
        Next i
        db = Nothing
        If Me.chkActiveEstil.Checked = True Then
            RefreshDataSet(TAULES_DBS.TAULA_STYLE_RELATIONSHIPS)
            Me.RefreshStyles(Me.gridTemesSelect.Rows(0).Cells(0).Value)
        End If

        Me.ProgressBar.Visible = False
        Me.cmdCancel.Visible = False
        Me.cmdExit.Enabled = True
        buttonHideMassive.Enabled = True
        AmbTasquesPendents = False

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Me.RefreshRecord()
        MetroFramework.MetroMessageBox.Show(Me, MSG_MODIF_REALITZADA, My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Information, 100)
    End Sub

    Private Sub cmdRandom_Click(sender As Object, e As EventArgs) Handles cmdRandom.Click
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.AppStarting
        Cancelled = False
        Me.ProgressBar.Visible = True
        Me.cmdCancel.Visible = True
        Me.cmdExit.Enabled = False
        buttonHideMassive.Enabled = False
        ProgressBar.Maximum = Me.gridTemesSelect.Rows.Count - 1
        Dim db As New MSC.dbs(Cloud)
        For i As Short = 0 To Me.gridTemesSelect.Rows.Count - 1
            Dim idTema As Short = Me.gridTemesSelect.Rows(i).Cells(0).Value
            Dim NewDataRadi As Date = GetRandomDate(Now.AddDays(-100), Now)
            Dim sCmd As String = "UPDATE temes SET"
            sCmd = sCmd & " tema_dataradiacio = '" & NewDataRadi.ToString("yyyy-MM-dd HH:mm:ss") & "'"
            sCmd = sCmd & " WHERE tema_id = " & idTema & " ;"
            db.Update_ID(sCmd)
            ProgressBar.Value = i
            System.Windows.Forms.Application.DoEvents()
            If Cancelled Then Exit For
            ProgressBar.Value = i
        Next i
        db = Nothing
        Me.ProgressBar.Visible = False
        Me.cmdCancel.Visible = False
        Me.cmdExit.Enabled = True
        buttonHideMassive.Enabled = True
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        MetroFramework.MetroMessageBox.Show(Me, MSG_MODIF_REALITZADA, My.Application.Info.AssemblyName, MessageBoxButtons.YesNo, MessageBoxIcon.Information, 100)
    End Sub

    Private Sub cmdCalcDurada_Click(sender As Object, e As EventArgs) Handles cmdCalcDurada.Click
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.AppStarting
        Cancelled = False
        Me.ProgressBar.Visible = True
        Me.cmdCancel.Visible = True
        Me.cmdExit.Enabled = False
        buttonHideMassive.Enabled = False
        ProgressBar.Maximum = Me.gridTemesSelect.Rows.Count - 1
        Dim db As New MSC.dbs(Cloud)
        For i As Short = 0 To Me.gridTemesSelect.Rows.Count - 1
            Dim _fileName As String = PathTemes & Me.gridTemesSelect.Rows(i).Cells(0).Value & ".mp3"
            Dim idTema As Short = Me.gridTemesSelect.Rows(i).Cells(0).Value
            If IO.File.Exists(_fileName) = True Then
                Dim stream As Integer = Bass.BASS_StreamCreateFile(_fileName, 0, 0, BASSFlag.BASS_DEFAULT)
                Dim len As Long = Bass.BASS_ChannelGetLength(stream)
                Dim DuradaReal As Date = TimeSerial(0, 0, Bass.BASS_ChannelBytes2Seconds(stream, len))
                Dim sCmd As String = "UPDATE temes "
                sCmd = sCmd & " SET"
                sCmd = sCmd & " tema_durada = '" & DuradaReal & "'"
                sCmd = sCmd & " WHERE tema_id = " & idTema & " ;"
                db.Update_ID(sCmd)
                'ensenyeu a la pantalla
                'frmMusic.lstTemesSelect.Items.Item(i).SubItems(2).Text = DuradaReal.ToString("HH:mm:ss")
            End If

            System.Windows.Forms.Application.DoEvents()
            If Cancelled Then Exit For
            ProgressBar.Value = i
        Next i
        db = Nothing
        Me.ProgressBar.Visible = False
        Me.cmdCancel.Visible = False
        Me.cmdExit.Enabled = True
        buttonHideMassive.Enabled = True
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        MetroFramework.MetroMessageBox.Show(Me, MSG_MODIF_REALITZADA, My.Application.Info.AssemblyName, MessageBoxButtons.YesNo, MessageBoxIcon.Information, 100)
    End Sub

    Private Sub cmdCalcBPM_Click(sender As Object, e As EventArgs) Handles cmdCalcBPM.Click
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.AppStarting
        Dim db As New MSC.dbs(Cloud)
        AmbTasquesPendents = True
        ProgressBar.Maximum = Me.gridTemesSelect.Rows.Count - 1
        Me.ProgressBar.Visible = True
        Me.cmdCancel.Visible = True
        cmdExit.Enabled = False
        buttonHideMassive.Enabled = False
        cmdCalcBPM.Enabled = False
        For i As Integer = 0 To Me.gridTemesSelect.Rows.Count - 1
            Dim temID As Integer = Me.gridTemesSelect.Rows(i).Cells(0).Value
            Dim PathFitxer As String = PathTemes & temID & ".mp3"
            If IO.File.Exists(PathFitxer) Then
                Dim bpmDecode As Single = getBPMFitxer(PathFitxer, Me.Handle)
                db.ExecuteInstruc("UPDATE temes SET tema_ritme=" & CInt(bpmDecode) & " WHERE tema_id=" & temID & " ;")
            End If
            ProgressBar.Value = i
            System.Windows.Forms.Application.DoEvents()
            If Cancelled = True Then Exit For
        Next
        db = Nothing
        cmdCalcBPM.Enabled = True
        Me.ProgressBar.Visible = False
        Me.cmdCancel.Visible = False
        AmbTasquesPendents = False
        cmdExit.Enabled = True
        buttonHideMassive.Enabled = True
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        MetroFramework.MetroMessageBox.Show(Me, MSG_MODIF_REALITZADA, My.Application.Info.AssemblyName, MessageBoxButtons.YesNo, MessageBoxIcon.Information, 100)
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Cancelled = True
    End Sub
End Class