Option Strict Off
Option Explicit On

Public Class frmDiscos
	Dim Cancelled As Boolean
	Dim blEnable As Boolean
	Dim blnNouRecord As Boolean
	Dim IsSaving As Boolean = False
	
	Public Column(5) As Boolean
	Dim FormatFitxer As Short
	Dim InfoMsg As frmTip
	
	Const MAX_WIDTH_IMG As Integer = 450 '124
	Const MAX_HEIDTH_IMG As Integer = 450 '165
	
	Private Sub CloseForm()
        If cmdSalvar.Enabled = True Then
            If MetroFramework.MetroMessageBox.Show(Me, MSG_SAVE_DADES, MSG_ATENCIO, MessageBoxButtons.YesNo, MessageBoxIcon.Information, 100) = DialogResult.Yes Then SaveRecord()
        End If
        MyAPP.CloseSesionClient(MyAPP.IDSesion_Client, DESCRIP_FORM_DISCOS)
    End Sub
	
	Private Sub frmDiscos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		CloseForm()
	End Sub
	
	Private Sub cmdSortir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSortir.Click
		Me.Close()
	End Sub
	
	Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
		Me.Close()
	End Sub
	
	Private Sub LockedRecord(Optional ByVal saved As Boolean = False)
        If Me.cmdSalvar.Enabled = True And saved = False Then
            If MetroFramework.MetroMessageBox.Show(Me, MSG_SAVE_DADES, MSG_ATENCIO, MessageBoxButtons.YesNo, MessageBoxIcon.Information, 100) = DialogResult.Yes Then SaveRecord()
        End If
        blEnable = Not blEnable
		If blEnable = False Then blnNouRecord = False
		
		'Me.Panel1.Enabled = blEnable
		txtAny.Enabled = blEnable
		txtNomDisc.Enabled = blEnable
		ComboInterp.Enabled = blEnable
		ComboCia.Enabled = blEnable
		ComboEstil.Enabled = blEnable
		txtComent.Enabled = blEnable
		txtWeb.Enabled = blEnable
		cmdAddCodiBar.Enabled = blEnable
		txtNTracs.Enabled = blEnable        
		Me.ComboProveidor.Enabled = IIf(Usuari.UsrTipus > mdlMscDefines.NivellUsers.USR_CONVIDAT, blEnable, False)
		txtEstant.Enabled = blEnable
		grupFormats.Enabled = blEnable
		ButtonAddPig.Enabled = blEnable
		ButtonDelPic.Enabled = blEnable
		
		Me.mnuDel.Enabled = blEnable
		Me.mnuNew.Enabled = blEnable
		Me.ButtonAddPig.Enabled = blEnable
		Me.ButtonDelPic.Enabled = blEnable
		Me.cmdBorrar.Enabled = blEnable
		Me.lbNou.Visible = False
		If blEnable Then
			Me.cmdBloqueix.Image = Me.picUnLock.Image
		Else
			Me.cmdBloqueix.Image = Me.picLock.Image
			Me.cmdSalvar.Enabled = False
		End If
	End Sub
	
	Private Sub cmdBloqueix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBloqueix.Click
		LockedRecord()
	End Sub

    Friend Sub getListDiscos(Optional ByRef condi As String = "")
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.AppStarting
        Cancelled = False

        Dim StrSql As String = "SELECT disc_id, disc_any, disc_nom, disc_interpret, disc_cia, disc_estil, disc_comentari, disc_web, disc_codibar, disc_numtracs, disc_propietari, disc_estanteria, disc_format, disc_datain FROM discos"
        If condi.Length > 0 Then StrSql = StrSql & " WHERE " & condi
        StrSql = StrSql & " ORDER BY disc_id ASC ;"
        Dim db As New MSC.dbs(Cloud)
        Me.gridDades.DataSource = db.getTable(StrSql)
        If gridDades.Rows.Count Then
            Me.lbRecCount.Text = CStr(gridDades.Rows.Count)
        Else
            BorrarDadesPantalla()
            'MetroFramework.MetroMessageBox.Show(Me, MSG_NO_ITEM_FOR_CONDITION, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
        End If
        Me.cmdBloqueix.Enabled = IIf(gridDades.Rows.Count And Usuari.UsrTipus > NivellUsers.USR_CONVIDAT, True, False)
        Me.mnuModif.Enabled = Me.cmdBloqueix.Enabled
        gridDades.Focus()
        db = Nothing
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub ShowValuesDiscos()
		If IsSaving = True Then Exit Sub
		Try
			If blEnable = True Then LockedRecord()
			Me.lbID.Text = gridDades.CurrentRow.Cells(0).Value
			Me.txtNomDisc.Text = StripSlashes(gridDades.CurrentRow.Cells("ColumnNom").Value)
			Me.txtAny.Text = NoNul(gridDades.CurrentRow.Cells("ColumnAny").Value)
			
			Me.txtComent.Text = StripSlashes(NoNul(gridDades.CurrentRow.Cells("ColumnComent").Value))
			Me.txtWeb.Text = StripSlashes(NoNul(gridDades.CurrentRow.Cells("ColumnWeb").Value))
			
			FormatFitxer = gridDades.CurrentRow.Cells("ColumnFormat").Value
			Dim strFormat As String = Choose(FormatFitxer + 1, "optAltres", "optCD", "optMP3", "optK7", "optVinil")
			CType(grupFormats.Controls(strFormat), RadioButton).Checked = True
			Me.lbDataIn.Text = gridDades.CurrentRow.Cells("ColumnDataIn").Value
			Me.txtNTracs.Text = gridDades.CurrentRow.Cells("ColumnNtrack").Value
			Me.txtEstant.Text = NoNul(gridDades.CurrentRow.Cells("ColumnPrestat").Value)
			If (gridDades.CurrentRow.Cells("ColumnCBarres").Value.ToString.Length = 0) Or (gridDades.CurrentRow.Cells("ColumnCBarres").Value.ToString Like MSG_BARCODE_NO_DEFINIT) Then
				Dim myfont As Font = New Font("Verdana", 8, FontStyle.Regular, GraphicsUnit.Point)
				Dim bit As Bitmap = New Bitmap(picCodiBar.Width, picCodiBar.Height)
				Dim graph As Graphics = Graphics.FromImage(bit)
				
				graph.DrawString(MSG_BARCODE_NO_DEFINIT, myfont, Drawing.Brushes.Black, 3, 4)
				picCodiBar.Image = bit
			Else
				cmdAddCodiBar.Tag = gridDades.CurrentRow.Cells("ColumnCBarres").Value
				picCodiBar.Image = DrawCodiBarres(StandarsCodiBarres.code39, cmdAddCodiBar.Tag)
			End If
			
			Me.ComboInterp.SelectedValue = gridDades.CurrentRow.Cells("gridComboInterp").Value
			Me.ComboCia.SelectedValue = gridDades.CurrentRow.Cells("gridComboCia").Value
			Me.ComboEstil.SelectedValue = gridDades.CurrentRow.Cells("gridComboEstil").Value
			Me.ComboProveidor.SelectedValue = IIf(Usuari.UsrTipus = NivellUsers.USR_CONVIDAT, 0, gridDades.CurrentRow.Cells("gridComboProveidor").Value)

            'Carrega imatge si existeix
            Dim db As New MSC.dbs(Cloud)
            Dim StrSql As String = "SELECT img_image FROM image_discos where img_disc=" & Me.lbID.Text
			Try
				Dim ImgDisc As Image = GetImageFromByteArray(CType(db.ExecuteScalar(StrSql), Byte()))
				If ImgDisc Is Nothing Then
					Me.picDisc.Image = picDiscDefecte.Image
					picDisc.Cursor = Cursors.Default
					picDiscDefecte.Tag = "fotodef"
				Else
					Me.picDisc.Image = ImgDisc 'GetImageFromByteArray(CType(db.ExecuteScalar(StrSql), Byte()))
					picDisc.Cursor = Cursors.Hand
					picDiscDefecte.Tag = "fotofromdbs"
				End If
			Catch ex As Exception
			End Try
			db = Nothing
			If TabControl1.SelectedIndex = 1 Then actualitzarListTemes(lbID.Text)
			lbPosition.Text = gridDades.CurrentRow.Index + 1
		Catch ex As Exception
			BorrarDadesPantalla()
		End Try
		'blnNouRecord = False
		Me.cmdSalvar.Enabled = False
		
	End Sub
	
	Private Sub BorrarDadesPantalla()
		
		Me.lbDataIn.Text = CStr(Now)
		
		Me.txtNomDisc.Text = ""
		Me.txtAny.Text = 0
		Me.txtComent.Text = ""
		Me.txtNTracs.Text = ""
		Me.txtWeb.Text = ""
		Me.txtEstant.Text = ""
		
		Me.ComboCia.SelectedValue = 0
		Me.ComboEstil.SelectedValue = 0
		Me.ComboInterp.SelectedValue = 0
		Me.ComboProveidor.SelectedValue = 0
		
		Me.picDisc.Image = picDiscDefecte.Image
		picDisc.Cursor = Cursors.Default
		picDiscDefecte.Tag = "fotodef"
		'Me.lbCodiBar.Text = MSG_BARCODE_NO_DEFINIT
	End Sub
	
	Private Sub actualitzarListTemes(ByVal IDDisc As Integer)
		Dim Origen As String
		Origen = "SELECT temes.tema_id, temes.tema_titol, interprets.interp_nom, temes.tema_pautain"
		Origen = Origen & " FROM (temes INNER JOIN interprets ON temes.tema_Interp = interprets.interp_id)"
		Origen = Origen & " WHERE (((temes.tema_disc)=" & IDDisc & "));"
        Dim db As New MSC.dbs(Cloud)
        gridTemes.DataSource = db.getTable(Origen)
		db = Nothing
		
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
	
	Private Sub cmdRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefrescar.Click
		getListDiscos()
	End Sub
	
	Private Sub frmDiscos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If isChild = False Then IniTable()
        If My.Settings.TXT_CAPITALIZE Then
			Me.txtComent.CharacterCasing = CharacterCasing.Upper
			Me.txtNomDisc.CharacterCasing = CharacterCasing.Upper
		End If
        ' control tipus usuari        
        Dim TipUsr As NivellUsers = Usuari.UsrTipus        
		mnuColumVisiblesSubj.Enabled = IIf(TipUsr > mdlMscDefines.NivellUsers.USR_CONVIDAT, True, False)
		
		'Me.cmdNou.Visible = frmMain.VisibleNew
		'Me.mnuNew.Visible = frmMain.VisibleNew
		mnuNew.Enabled = IIf(TipUsr > NivellUsers.USR_CONVIDAT, True, False)
		Me.cmdPrint.Enabled = IIf(TipUsr > NivellUsers.USR_CONVIDAT, True, False)
		Me.mnuModif.Enabled = IIf(TipUsr > NivellUsers.USR_CONVIDAT, True, False)
        Me.ClientSize = New Size(frm_sice(0), frm_sice(1))
    End Sub

    Dim isChild As Boolean = False
    Friend Sub IniTable()
        setLanguageForm()

        isChild = True
    End Sub

    Dim MSG_INTERP_OBLIGATORI As String 
	Dim MSG_ESTIL_OBLIGATORI As String 
	Dim MSG_BARCODE_NO_DEFINIT As String 
	Dim MSG_ERROR_DELETE_DEPENDENCIES As String 
	Dim LIST_DISCOS As String 
	Dim MSG_ESCRIU_TITOL As String
	Dim NAME_TEMES As String 
	
	Public Sub setLanguageForm()		
		lang.StrForm = Me.Name
		
		MSG_INTERP_OBLIGATORI  = lang.getText("MSG_INTERP_OBLIGATORI",True) '"És obligatori especificar un intèrpret, pots especificar 'Varis'."
		MSG_ESTIL_OBLIGATORI = lang.getText("MSG_ESTIL_OBLIGATORI") '"És obligatori especificar un estil, pots especificar 'Varis'."
		MSG_BARCODE_NO_DEFINIT =  lang.getText("MSG_BARCODE_NO_DEFINIT") '"NO DEFINIT"
		MSG_ERROR_DELETE_DEPENDENCIES = lang.getText("MSG_ERROR_DELETE_DEPENDENCIES") '"No es pot borrar, hi han temes que depenen d'aquest disc"
		LIST_DISCOS = lang.getText("LIST_DISCOS") '"Llistat de discos"
		MSG_ESCRIU_TITOL = lang.getText("MSG_ESCRIU_TITOL",True) '"Escriu un títol pel llistat"
		NAME_TEMES = lang.getText("NAME_TEMES") '"Temes"
		
		Me.ProgarmaToolStripMenuItem.Text = lang.getText("LABEL_PROGRAMA",True) '"Programa"
		Me.mnuExit.Text = lang.getText("LABEL_EXIT",True) '"Sortir"
		Me.EdicióToolStripMenuItem.Text = lang.getText("mnuEdit.Text",True )'"Edició"
		Me.mnuModif.Text = lang.getText("LABEL_MODIFICAR",True )'"Modificar"
		Me.mnuSave.Text = lang.getText("LABEL_SALVAR",True) '"Salvar"
		Me.mnuNew.Text = lang.getText("LABEL_NEW",True) '"Nou"
		Me.mnuDel.Text = lang.getText("LABEL_DELETE",True) '"Borrar"
		Me.mnuBuscar.Text = lang.getText("LABEL_BUSCAR",True)'"Buscar"
		Me.mnuRefresh.Text = Lang.getText("LABEL_REFRESCAR",True)'"Refrescar"		
		Me.ToolStripMenuItem8.Text = lang.getText("mnu_Help",True) '"Ajuda"
		Me.mnu_Help.Text = lang.getText("mnuRefHelp.Text",True) '"Manual OnLine"
		Me.cmdPrimer.Text = lang.getText("LABEL_GOTO_FIRSH",True)'"Primer"
		Me.cmdPrevi.Text = lang.getText("LABEL_GOTO_PREV",True)'"Anterior"
		Me.cmdSeguent.Text = lang.getText("LABEL_GOTO_NEXT",True)'"Següent"
		Me.cmdUltim.Text = lang.getText("LABEL_GOTO_LAST",True)'"Últim"
		Me.cmdNou.Text = lang.getText("LABEL_NEW",True) '"Nou"
		Me.cmdBloqueix.Text = lang.getText("LABEL_EDITAR",True) '"Editar"
		Me.cmdBorrar.Text = lang.getText("LABEL_DELETE",True) '"Borrar"
		Me.cmdSalvar.Text = lang.getText("LABEL_SAVE",True)'"Salvar"		
		Me.cmdBuscar.Text = lang.getText("LABEL_BUSCAR",True)'"Buscar"
		Me.cmdRefrescar.Text = Lang.getText("LABEL_REFRESCAR",True)'"Refrescar"
		Me.cmdSortir.Text = lang.getText("LABEL_EXIT",True) '"Sortir"		
		Me.ColumnID.HeaderText = lang.getText("HEADERTEXT_ID",True) '"ID"
		Me.ColumnNom.HeaderText = lang.getText("LABEL_NOM",True) '"Nom"
		Me.DataGridViewTextBoxColumn1.HeaderText = lang.getText("HEADERTEXT_ID",True) '"ID"
		Me.ButtonDelPic.Text = lang.getText("LABEL_DELETE",True) '"Borrar"
		Me.lbNou.Text = lang.getText("LABEL_NEW_UPPER",True) '"NOU"
		
		Me.mnuColumVisiblesMare.Text = lang.getText("LABEL_COLUMN_OPCIONAL_VISIBLE",True) '"Columnes opcionals visibles"
		Me.lbCia.Text = lang.getText("lbCia.Text") '"Discogràfica"
		Me.mnuColumVisiblesEstil.Text = lbCia.Text  '"Discogràfica"
		Me.mnuColumVisiblesIdioma.Text = lang.getText("HEADERTEXT_ESTIL",True) '"Estil" ?????
		Me.mnuColumVisiblesSubj.Text = lang.getText("LABEL_PROVEIDOR",True) '"Proveïdor"
		Me.cmdPrint.Text = lang.getText("LABEL_IMPRIMIR_LLISTAT",True) '"Inprimir llistat"
		Me.TabPage1.Text = lang.getText("TabPage1.Text") '"Llista de Discos"
		Me.ColumnAny.HeaderText = lang.getText("HEADERTEXT_ANY",True) '"Any"
		
		Me.lbInterp.Text = lang.getText("HEADERTEXT_INTERP",True) '"Intèrpret"
		Me.Column17.HeaderText = lbInterp.Text '"Intèrpret"
		Me.gridComboInterp.HeaderText = lbInterp.Text '"Intèrpret"
		Me.gridComboCia.HeaderText = lbCia.Text '"Discogràfica"
		Me.gridComboEstil.HeaderText = lang.getText("HEADERTEXT_ESTIL",True) '"Estil"
		'Me.ColumnComent.HeaderText = "Comentàri"
		'Me.ColumnWeb.HeaderText = "Web"
		'Me.ColumnCBarres.HeaderText = "Codi Barres"
		'Me.ColumnNtrack.HeaderText = "Núm. Tracks"
		'Me.gridComboProveidor.HeaderText = "Proveïdors"
		'Me.ColumnPrestat.HeaderText = "Prestatge"
		'Me.ColumnFormat.HeaderText = "Format"
		'Me.ColumnDataIn.HeaderText = "Data In"
		Me.TabPage2.Text = lang.getText("TabPage2.Text") '"Detall de cançons del disc"
		Me.Column16.HeaderText = lang.getText("HEADERTEXT_TITOL",True) '"Títol"
		
		
		Me.Column19.HeaderText = lang.getText("LABEL_ACTIVA",True) '"Activada"		
		Me.ButtonAddPig.Text = lang.getText("LABEL_ADD",true) '"afegir"
		Me.Label8.Text = lang.getText("LABEL_ACCEPT_HTML", True ) '"accepta HTML"
		Me.Label6.Text = lang.getText("LABEL_DATA_ENTRADA",True) '"Data d'entrada"
		Me.Label5.Text = lang.getText("Label5.Text") '"Títol disc"
		Me.grupFormats.Text = lang.getText("LABEL_FORMAT", True) '"Format"
		Me.optAltres.Text = lang.getText("FITXER_ALTRES",True) '"Altres"
		Me.optVinil.Text = lang.getText("LABEL_VINIL",True) '"Vinil"
		Me.optK7.Text = lang.getText("LABEL_K7",True) '"K7"
		Me.optMP3.Text = lang.getText("LABEL_MP3",True) '"MP3"
		Me.optCD.Text = lang.getText("LABEL_CD",True) '"CD"
		Me.Label4.Text = lang.getText("Label4.Text") '"Prestatge"
		Me.lbProveidor.Text = lang.getText("LABEL_PROVEIDOR",True) '"Proveïdor"
		Me.Label3.Text = lang.getText("Label3.Text") '"Nº de tracs"		
		
		
		Me.lbEstil.Text = lang.getText("HEADERTEXT_ESTIL",True) '"Estil"
		Me.lbWeb.Text = lang.getText("LABEL_WEB",True) '"Web"
		Me.Label7.Text = lang.getText("LABEL_COMMENT",True) '"Comentaris"
		Me.Label2.Text = lang.getText("LABEL_ANY_PUBLICACIO",True) '"Any de publicació"
		Me.Label1.Text = lang.getText("LABEL_IDENTIFICADOR",True) '"Identificador"
		Me.OpenFileDialog1.Filter = lang.getText("LABEL_IMAGE_FILES",True) & " |*.gif; *.jpg; *.jpeg; *.bmp" '"arxius d'imatges" & " |*.gif; *.jpg; *.jpeg; *.bmp"
        Me.OpenFileDialog1.Title = lang.getText("LABEL_SELECT_FOTOGRAFIA", True) '"Seleccioneu una fotografia"
        Me.lbScandCode.Text = lang.getText("LABEL_PASSAR_ESCANER", True) ' "Passeu l'escaner ..."

        Me.Text = lang.getText("Text") '"Gestió de discos"
        Dim Cmb As New combo
        Cmb.OmpleCombo(ComboInterp, TAULES_DBS.TAULA_INTERPRETS, TotsCap.CAP) : ComboInterp.SelectedValue = 0
        Cmb.OmpleCombo(gridComboInterp, TAULES_DBS.TAULA_INTERPRETS, TotsCap.CAP)
        Cmb.OmpleCombo(ComboCia, TAULES_DBS.TAULA_DISCOGRAFIQUES, TotsCap.CAP) : ComboCia.SelectedValue = 0
        Cmb.OmpleCombo(gridComboCia, TAULES_DBS.TAULA_DISCOGRAFIQUES, TotsCap.CAP)
        Cmb.OmpleCombo(ComboEstil, TAULES_DBS.TAULA_ESTILS, TotsCap.CAP) : ComboEstil.SelectedValue = 0
        Cmb.OmpleCombo(gridComboEstil, TAULES_DBS.TAULA_ESTILS, TotsCap.CAP)
        Cmb.OmpleCombo(ComboProveidor, TAULES_DBS.TAULA_PROVEIDORS, TotsCap.CAP) : ComboProveidor.SelectedValue = 0
        Cmb.OmpleCombo(gridComboProveidor, TAULES_DBS.TAULA_PROVEIDORS, TotsCap.CAP)

    End Sub
	
	Private Sub optCD_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optCD.CheckedChanged, optAltres.CheckedChanged, optK7.CheckedChanged, optMP3.CheckedChanged, optVinil.CheckedChanged
		FormatFitxer = CType(sender, RadioButton).Tag
		Try
			Dim RowID As Integer = FindAfectatRow()
			Me.gridDades.Rows(RowID).Cells("ColumnFormat").Value = FormatFitxer
			Changed()
		Catch ex As Exception
		End Try
		
	End Sub
	
	Private Sub NewRecord()
		blnNouRecord = True
		DeSelectAllRowsGrid(gridDades)
		gridDades.AllowUserToAddRows = True
		gridDades.FirstDisplayedScrollingRowIndex = gridDades.NewRowIndex
		Me.gridDades.Rows(gridDades.NewRowIndex).Selected = True
		Me.gridDades.Rows(gridDades.NewRowIndex).Cells(0).Value = 0
		'establir Valors per defecte (automàticament incorporats al datagrid)
		BorrarDadesPantalla()		
		blEnable = False
		LockedRecord()		
		lbNou.Visible = True
		Me.txtAny.Focus()
	End Sub
	
	Private Sub cmdNou_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNou.Click
		NewRecord()
	End Sub
	
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
	
	Private Sub mnuRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRefresh.Click
		getListDiscos()
	End Sub

    Private Sub mnuBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBuscar.Click
        FindRecord()
    End Sub

    Friend ID As Integer = 0
    Private Sub SaveRecord()
        If Not MyAPP.PermisPerContinuar() Then MetroFramework.MetroMessageBox.Show(Me, MSG_SERVER_CLOSE, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Stop, 100) : Me.Close()

        If MetroFramework.MetroMessageBox.Show(Me, MSG_CONFIRM_SAVE_DADES, MSG_ATENCIO, MessageBoxButtons.YesNo, MessageBoxIcon.Question, 100) = DialogResult.No Then Exit Sub

        If Me.ComboInterp.SelectedValue < 1 Then
            MetroFramework.MetroMessageBox.Show(Me, MSG_INTERP_OBLIGATORI, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
            ComboInterp.SelectedValue = 1
            Exit Sub
        ElseIf Me.ComboEstil.SelectedValue < 1 Then
            MetroFramework.MetroMessageBox.Show(Me, MSG_ESTIL_OBLIGATORI, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
            ComboEstil.SelectedValue = 1
            Exit Sub
        End If
        IsSaving = True
        Dim Estil As Short = Me.ComboEstil.SelectedValue
        Dim Interp As Short = Me.ComboInterp.SelectedValue
        Dim Cia As Short = Me.ComboCia.SelectedValue : If Cia < 0 Then Cia = 0
        Dim Propie As Short = Me.ComboProveidor.SelectedValue : If Propie < 0 Then Propie = 0

        Dim Nom As String = AddSlashes(Me.txtNomDisc.Text)
        Dim Coment As String = AddSlashes(Me.txtComent.Text)
        Dim DataIn As String = Me.lbDataIn.Text
        Dim Web As String = AddSlashes(Me.txtWeb.Text)
        Dim AnyPubli As Integer = IIf(Len(txtAny.Text) > 0, Me.txtAny.Text, 0)
        Dim NTracs As Integer = IIf(Len(txtNTracs.Text) > 0, Me.txtNTracs.Text, 0)
        Dim CodiBar As String = MSG_BARCODE_NO_DEFINIT
        If Me.cmdAddCodiBar.Tag IsNot Nothing Then CodiBar = AddSlashes(cmdAddCodiBar.Tag)
        Dim Estant As String = AddSlashes(Me.txtEstant.Text)

        ID = Me.lbID.Text
        Dim sCmd As String
        Dim DB As New MSC.dbs(Cloud)

        If blnNouRecord = True Then
            sCmd = "INSERT INTO discos ( disc_datain , disc_any, disc_nom,"
            sCmd = sCmd & "disc_numtracs, disc_comentari, disc_cia,disc_format, disc_estil, "
            sCmd = sCmd & " disc_interpret, disc_propietari, disc_web, disc_codibar, disc_estanteria)"
            sCmd = sCmd & " VALUES "
            sCmd = sCmd & " ( '" & Now.ToString("yyyy-MM-dd HH:mm:ss") & "'"
            sCmd = sCmd & ", " & AnyPubli
            sCmd = sCmd & ", '" & Nom & "'"
            sCmd = sCmd & ", " & NTracs
            sCmd = sCmd & ", '" & Coment & "'"
            sCmd = sCmd & ", " & Cia
            sCmd = sCmd & ", " & FormatFitxer
            sCmd = sCmd & ", " & Estil
            sCmd = sCmd & ", " & Interp
            sCmd = sCmd & ", " & Propie
            sCmd = sCmd & ", '" & Web & "'"
            sCmd = sCmd & ", '" & CodiBar & "'"
            sCmd = sCmd & ", '" & Estant & "'"
            sCmd = sCmd & ");"

            ID = DB.New_ID(sCmd)
            'salvar foto
            If Me.picDisc.Tag = "savefoto" Then InsertPig(ID)
            Me.gridDades.Rows(gridDades.NewRowIndex).Cells(0).Value = ID
            Dim newRecord As DataGridViewRow = gridDades.Rows(gridDades.NewRowIndex)
            Dim dt As DataTable
            If gridDades.DataSource IsNot Nothing Then
                dt = gridDades.DataSource
            Else
                dt = New DataTable
                For col As Integer = 0 To gridDades.Columns.Count - 1
                    Dim idColumn As DataColumn = New DataColumn()
                    idColumn.ColumnName = gridDades.Columns(col).DataPropertyName
                    idColumn.DataType = newRecord.Cells(col).ValueType
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
            gridDades.AllowUserToAddRows = False
        Else
            sCmd = "UPDATE discos "
            sCmd = sCmd & " SET "
            sCmd = sCmd & " disc_any = " & AnyPubli
            sCmd = sCmd & " , disc_nom = '" & Nom & "'"
            sCmd = sCmd & " , disc_numtracs = " & NTracs
            sCmd = sCmd & " , disc_comentari = '" & Coment & "'"
            sCmd = sCmd & " , disc_cia = " & Cia
            sCmd = sCmd & " , disc_format = " & FormatFitxer
            sCmd = sCmd & " , disc_estil = " & Estil
            sCmd = sCmd & " , disc_interpret = " & Interp
            sCmd = sCmd & " , disc_propietari = " & Propie
            sCmd = sCmd & " , disc_web = '" & Web & "'"
            sCmd = sCmd & " , disc_codibar = '" & CodiBar & "'"
            sCmd = sCmd & " , disc_estanteria = '" & Estant & "'"

            sCmd = sCmd & " WHERE disc_id = " & ID & " ;"

            DB.Update_ID(sCmd)

            'salvar foto
            If Me.picDisc.Tag = "savefoto" And picDiscDefecte.Tag = "fotofromdbs" Then
                UpdatePig(ID)
            ElseIf Me.picDisc.Tag = "savefoto" Then
                InsertPig(ID)
            ElseIf Me.picDisc.Tag = "delfoto" Then
                sCmd = "DELETE FROM image_discos WHERE img_disc = " & Me.lbID.Text & " ;"
                DB.Delete_ID(sCmd)
            End If
        End If
        DB = Nothing

        RefreshDataSet(TAULES_DBS.TAULA_DISCOS)
        Me.DialogResult = DialogResult.OK

        IsSaving = False
        blnNouRecord = False
        LockedRecord(True)
        Me.gridDades.Focus()
        'Exit Sub
        'MetroFramework.MetroMessageBox.Show(Me, "", MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)            
        'MsgBox("Error al intentar salvar les dades, comprova que totes les dades siguin correctes", MsgBoxStyle.Critical)
    End Sub

    Private Sub FindRecord()
        Try
            If IsLoadForm("frmBuscarDiscos") = True Then
                frmBuscarDiscos.Visible = True
            Else
                frmBuscarDiscos.Show(Me)
            End If
            TimerQuery.Enabled = True
        Catch ex As Exception
        End Try
    End Sub
	
	Private Sub DeleteRecord()
		
		If blnNouRecord = True Then 
			LockedRecord(True)
			BorrarDadesPantalla()
			gridDades.AllowUserToAddRows = False
			Exit Sub
		End If	
		
		
		Dim StrSql As String = ""
        Dim DB As New MSC.dbs(Cloud)

        If MetroFramework.MetroMessageBox.Show(Me, MSG_CONFIRM_DELETE_DADES, MSG_ATENCIO, MessageBoxButtons.YesNo, MessageBoxIcon.Stop, 100) = DialogResult.No Then Exit Sub
        If buscarDependencies(TAULES_DBS.TAULA_DISCOS, Me.lbID.Text, Me) = True Then Exit Sub
        ' No es pot borrar cap disc que tingui temes depenents
        StrSql = "SELECT tema_id FROM temes WHERE tema_disc = " & Me.lbID.Text
		Dim rs As DataTable = DB.getTable(StrSql)
        If rs.Rows.Count Then
            MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_DELETE_DEPENDENCIES, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
            Exit Sub
        End If
        StrSql = "DELETE FROM discos WHERE disc_id = " & Me.lbID.Text & " ;"

        DB.Delete_ID(StrSql)
        addCtlRadi(0, CShort(Tipus_Play.CTL_SQL), 0, "00:00:00", 0, 0, Usuari.UsrID, StrSql, 0, False)

        StrSql = "DELETE FROM image_discos WHERE img_disc = " & Me.lbID.Text & " ;"
		DB.Delete_ID(StrSql)
		
		DB = Nothing
		gridDades.Rows.RemoveAt(gridDades.CurrentRow.Index)
		gridDades.Focus()
	End Sub
	
	Private Sub cmdSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalvar.Click
		SaveRecord()
	End Sub
	
	Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
		DeleteRecord()
	End Sub
	Private Sub KeyPress_Combo(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboInterp.KeyPress, ComboCia.KeyPress, ComboEstil.KeyPress, ComboProveidor.KeyPress
		e.KeyChar = UCase(e.KeyChar)
	End Sub
	
	Private Sub TextChanged_Combo(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboInterp.TextChanged, ComboCia.TextChanged, ComboEstil.TextChanged, ComboProveidor.TextChanged
		Dim index As Integer = CType(sender, ComboBox).FindStringExact(CType(sender, ComboBox).Text())
		If index < 0 Then
			'no existeix el que es busca
		End If
		Changed()
	End Sub
	
	Private Sub txtAny_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAny.KeyPress, txtNTracs.KeyPress
		Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
		If KeyAscii < Asc("0") Or KeyAscii > Asc("9") Then If KeyAscii <> 8 Then KeyAscii = 0
		e.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			e.Handled = True
		End If
		
	End Sub
	
	Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
		FindRecord()
	End Sub
	
	Private Sub lbInterp_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbInterp.LinkClicked
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
	
	Private Sub lbEstil_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbEstil.LinkClicked
        Dim FrmChild As New frmMantEstil
        Try
            FrmChild.IniTable()
            If ComboEstil.SelectedValue > 0 Then FrmChild.establirRecordset(" estil_nom = '" & Me.ComboEstil.Text & "'")
            If FrmChild.ShowDialog = DialogResult.OK Then
                Dim Cmb As New combo
                Cmb.OmpleCombo(ComboEstil, TAULES_DBS.TAULA_ESTILS, TotsCap.CAP)
                ComboEstil.SelectedValue = FrmChild.ID
            End If
        Catch ex As Exception
        End Try
        FrmChild = Nothing
    End Sub
	
	Private Sub lbCia_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbCia.LinkClicked
        Dim FrmChild As New frmMantDicograf
        Try
            FrmChild.IniTable()
            If ComboCia.SelectedValue > 0 Then FrmChild.establirRecordset(" cia_nom = '" & Me.ComboCia.Text & "'")
            If FrmChild.ShowDialog = DialogResult.OK Then
                Dim Cmb As New combo
                Cmb.OmpleCombo(ComboCia, TAULES_DBS.TAULA_DISCOGRAFIQUES, TotsCap.CAP)
                ComboCia.SelectedValue = FrmChild.ID
            End If
        Catch ex As Exception
        End Try
        FrmChild = Nothing
    End Sub
	
	Private Sub lbProveidor_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbProveidor.LinkClicked
        If ComboProveidor.Enabled = True Then
            Dim FrmChild As New frmMantProveidor
            Try
                FrmChild.IniTable()
                If ComboProveidor.SelectedValue > 0 Then FrmChild.establirRecordset(" prov_nom = '" & Me.ComboProveidor.Text & "'")
                If FrmChild.ShowDialog = DialogResult.OK Then
                    Dim Cmb As New combo
                    Cmb.OmpleCombo(ComboProveidor, TAULES_DBS.TAULA_PROVEIDORS, TotsCap.CAP)
                    ComboProveidor.SelectedValue = FrmChild.ID
                End If
            Catch ex As Exception
            End Try
            FrmChild = Nothing
        End If
    End Sub
	
	Private Sub lbWeb_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbWeb.LinkClicked
		Dim Proces As Process = New Process
		Try
			NavigateWebURL(txtWeb.Text,getDefaultBrowser)
			'Process.Start(txtWeb.Text)
		Catch ex As Exception
		End Try
	End Sub
	
	
	Private Sub TabControl1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TabControl1.MouseUp
		Dim IDDisc As Integer = Me.lbID.Text
		If TabControl1.SelectedIndex = 1 Then actualitzarListTemes(IDDisc)
	End Sub
	
	Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
		Dim frmPRT As New frmPrint
		Dim StrTitol As String = InputBox(MSG_ESCRIU_TITOL, MSG_ATENCIO, LIST_DISCOS)
		If Len(StrTitol) < 2 Then StrTitol = LIST_DISCOS
		'TODO: HABILITAR Reports
		If Me.TabControl1.SelectedIndex = 0 Then
			frmPRT.DefineLlistat(Me.gridDades, frmPrint.Tipusllistats.LLISTAT_Discos, StrTitol)
		Else
			frmPRT.DefineLlistat(Me.gridTemes, frmPrint.Tipusllistats.LLISTAT_Discos, StrTitol)
		End If
		Try
			frmPRT.Show(Me)
		Catch ex As Exception
			frmPRT.WindowState = FormWindowState.Normal
		End Try
		
	End Sub
	
	Private Sub cmdAddCodiBar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddCodiBar.Click

        Try
            PanelScanCodi.Show()
        Catch ex As Exception
        End Try

    End Sub
	
	Private Sub gridDiscos_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles gridDades.DataError
		'TODO: Es crea aquest event per que no surtit el missatge d'error, però l'error hi és igualment
	End Sub
	
	Private Sub gridDiscos_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridDades.SelectionChanged
		ShowValuesDiscos()
	End Sub
	
	Private Sub gridTemes_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridTemes.CellDoubleClick
		If MyAPP.NovaConnex(NAME_TEMES, Usuari.UsrNom, True) = True Then
			Dim StrSql As String = "tema_id = " & Me.gridTemes.CurrentRow.Cells(0).Value
			Try
				frmTemes.Show(Me)
			Catch ex As Exception
				frmTemes.WindowState = FormWindowState.Normal
			End Try
			frmTemes.getListTemes(StrSql)
		End If
	End Sub
	
	Private Sub gridTemes_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles gridTemes.CellMouseDown
		If e.Button = system.Windows.Forms.MouseButtons.Right Then
			Dim Tipus As Tipus_Play, id As Integer
			Dim Caracters As String
			Dim strText As String
			On Error Resume Next
			
			Tipus = Tipus_Play.CTL_MUSICA
			id = gridTemes.CurrentRow.Cells(0).Value  'ListTemes.FocusedItem.Tag
			strText = strInfoFitxer(Tipus, id)
			InfoMsg = New frmTip
			InfoMsg.ShowMessage(strText, MSG_MORE_INFO, IconStyles.Information, ContentAlignment.MiddleCenter, , , True, , , , , Themes.WinXpStyle, MessageBoxButtons.OK)
		End If
	End Sub
	
	Private Sub gridTemes_CellMouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles gridTemes.CellMouseUp
		If e.Button = system.Windows.Forms.MouseButtons.Right Then
			InfoMsg.Close()
		End If
	End Sub
	
	Private Sub mnuColumVisibles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuColumVisiblesEstil.Click, _
		mnuColumVisiblesIdioma.Click, mnuColumVisiblesSubj.Click
		Dim Check As Boolean = Not CType(sender, ToolStripMenuItem).Checked
		CType(sender, ToolStripMenuItem).Checked = Check
		Dim IdColumn As Integer = CType(sender, ToolStripMenuItem).Tag
		Me.gridDades.Columns(IdColumn).Visible = Check
	End Sub
	
	Private Function FindAfectatRow() As Integer
		If blnNouRecord = True Then
			Return gridDades.NewRowIndex
		Else
			Return gridDades.CurrentRow.Index
		End If
	End Function
	
	Private Sub txtAny_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAny.TextChanged
		Try
			Dim RowID As Integer = FindAfectatRow()
			Me.gridDades.Rows(RowID).Cells("ColumnAny").Value = txtAny.Text
			Changed()
		Catch ex As Exception
		End Try
	End Sub
	
	Private Sub txtNomDisc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNomDisc.TextChanged
		Try
			Dim RowID As Integer = FindAfectatRow()
			Me.gridDades.Rows(RowID).Cells("ColumnNom").Value = txtNomDisc.Text
			Changed()
		Catch ex As Exception
		End Try
	End Sub
	
	Private Sub ComboInterp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboInterp.SelectedIndexChanged
		Try
			Dim RowID As Integer = FindAfectatRow()
			Me.gridDades.Rows(RowID).Cells("gridComboInterp").Value = ComboInterp.SelectedValue
			Changed()
		Catch ex As Exception
		End Try
	End Sub
	
	Private Sub ComboCia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboCia.SelectedIndexChanged
		Try
			Dim RowID As Integer = FindAfectatRow()
			Me.gridDades.Rows(RowID).Cells("gridComboCia").Value = ComboCia.SelectedValue
			Changed()
		Catch ex As Exception
		End Try
	End Sub
	
	Private Sub ComboEstil_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboEstil.SelectedIndexChanged
		Try
			Dim RowID As Integer = FindAfectatRow()
			Me.gridDades.Rows(RowID).Cells("gridComboEstil").Value = ComboEstil.SelectedValue
			Changed()
		Catch ex As Exception
		End Try
	End Sub
	
	Private Sub txtComent_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtComent.TextChanged
		Try
			Dim RowID As Integer = FindAfectatRow()
			Me.gridDades.Rows(RowID).Cells("ColumnComent").Value = txtComent.Text
			Changed()
		Catch ex As Exception
		End Try
	End Sub
	
	Private Sub txtWeb_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtWeb.TextChanged
		Try
			Dim RowID As Integer = FindAfectatRow()
			Me.gridDades.Rows(RowID).Cells("ColumnWeb").Value = txtWeb.Text
			Changed()
		Catch ex As Exception
		End Try
	End Sub
	
	Private Sub txtNTracs_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNTracs.TextChanged
		Try
			Dim RowID As Integer = FindAfectatRow()
			Me.gridDades.Rows(RowID).Cells("ColumnNtracks").Value = txtNTracs.Text
			Changed()
		Catch ex As Exception
		End Try
	End Sub
	
	Private Sub ComboProveidor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboProveidor.SelectedIndexChanged
		Try
			Dim RowID As Integer = FindAfectatRow()
			Me.gridDades.Rows(RowID).Cells("gridComboProveidor").Value = ComboProveidor.SelectedValue
			Changed()
		Catch ex As Exception
		End Try
	End Sub
	
	Private Sub txtEstant_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEstant.TextChanged
		Try
			Dim RowID As Integer = FindAfectatRow()
			Me.gridDades.Rows(RowID).Cells("ColumnPrestatge").Value = txtEstant.Text
			Changed()
		Catch ex As Exception
		End Try
	End Sub
	
	Private Sub Combo_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles _
		ComboInterp.KeyUp, ComboCia.KeyUp, _
		ComboEstil.KeyUp, _
		ComboProveidor.KeyUp
		Select Case e.KeyCode
			Case Keys.Left, Keys.Right, Keys.Up, Keys.Down
				Return
		End Select
		Dim MyComboBox As ComboBox = CType(sender, ComboBox)
		Dim Origen As TAULES_DBS
		
		Select Case MyComboBox.Name
			Case "ComboInterp" : Origen = TAULES_DBS.TAULA_INTERPRETS
			Case "ComboCia" : Origen = TAULES_DBS.TAULA_DISCOGRAFIQUES
			Case "ComboEstil" : Origen = TAULES_DBS.TAULA_ESTILS            
			Case "ComboProveidor" : Origen = TAULES_DBS.TAULA_PROVEIDORS
		End Select
		refreshComboBoxKeyUp(MyComboBox, Origen, TotsCap.CAP)
		
	End Sub
	
	Private Sub Combo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboInterp.LostFocus, ComboCia.LostFocus, _
		ComboEstil.LostFocus, _
		ComboProveidor.LostFocus
		Dim MyComboBox As ComboBox = CType(sender, ComboBox)
		Dim ID As Integer = MyComboBox.SelectedValue
		Dim Origen As TAULES_DBS
		Select Case MyComboBox.Name
			Case "ComboInterp" : Origen = TAULES_DBS.TAULA_INTERPRETS
			Case "ComboCia" : Origen = TAULES_DBS.TAULA_DISCOGRAFIQUES
			Case "ComboEstil" : Origen = TAULES_DBS.TAULA_ESTILS            
			Case "ComboProveidor" : Origen = TAULES_DBS.TAULA_PROVEIDORS
		End Select
		Dim Cmb As New combo
		Cmb.OmpleCombo(MyComboBox, Origen, TotsCap.CAP)
		MyComboBox.SelectedValue = ID
	End Sub
	
	
	Private Sub picDisc_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles picDisc.DoubleClick
		If Me.picDisc.Cursor = Cursors.Hand Then
			Try
				frmPicture.PictureBoxPersona.Image = picDisc.Image
				frmPicture.Text = Me.txtNomDisc.Text & " ( " & Me.ComboInterp.Text & " )"			
				frmPicture.Show(Me)				
			Catch ex As Exception
				frmPicture.WindowState = FormWindowState.Normal
			End Try			
		End If
	End Sub
	
	
	
	Private Sub ButtonAddPig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAddPig.Click
		
		If Me.OpenFileDialog1.ShowDialog() = system.Windows.Forms.DialogResult.OK Then
			Me.picDisc.Image = resizeImageFromPath(OpenFileDialog1.FileName, MAX_WIDTH_IMG, MAX_HEIDTH_IMG)
			picDisc.Cursor = Cursors.Hand
			picDisc.Tag = "savefoto"            
			Changed()
		End If
		
	End Sub
	
	Private Sub InsertPig(ByVal idDisc As Integer)
		
		If picDisc.Image Is Nothing Then Exit Sub
		
		Dim ms As IO.MemoryStream = New IO.MemoryStream				 
		picDisc.Image.Save(ms, Imaging.ImageFormat.Jpeg)
		
		Dim bytBLOBData(CInt(ms.Length - 1)) As Byte
		
		ms.Position = 0
		ms.Read(bytBLOBData, 0, CInt(ms.Length))
		
		Dim prm As New MySql.Data.MySqlClient.MySqlParameter("@Picture", _
			MySql.Data.MySqlClient.MySqlDbType.Blob, _
			bytBLOBData.Length, ParameterDirection.Input, False, _
			0, 0, Nothing, DataRowVersion.Current, bytBLOBData)

        Dim db As New MSC.dbs(Cloud)
        Dim StrSql As String = "INSERT `image_discos` SET img_disc=" & idDisc.ToString & ", img_image= @Picture ;"				
		db.ExecuteInstruc(StrSql, prm)	
		
		db = Nothing
	End Sub
	
	Private Sub UpdatePig(ByVal idDisc As Integer)
		
		If picDisc.Image Is Nothing Then Exit Sub
		
		Dim ms As IO.MemoryStream = New IO.MemoryStream				 
		picDisc.Image.Save(ms, Imaging.ImageFormat.Jpeg)
		
		Dim bytBLOBData(CInt(ms.Length - 1)) As Byte
		
		ms.Position = 0
		ms.Read(bytBLOBData, 0, CInt(ms.Length))
		
		Dim prm As New MySql.Data.MySqlClient.MySqlParameter("@Picture", _
			MySql.Data.MySqlClient.MySqlDbType.Blob, _
			bytBLOBData.Length, ParameterDirection.Input, False, _
			0, 0, Nothing, DataRowVersion.Current, bytBLOBData)

        Dim db As New MSC.dbs(Cloud)
        Dim StrSql As String = "UPDATE`image_discos` SET img_image= @Picture WHERE img_disc=" & idDisc.ToString & " ;"
		db.ExecuteInstruc(StrSql, prm)	
		
		db = Nothing
		
	End Sub	
	
	Private Sub ButtonDelPic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDelPic.Click
		
		Me.picDisc.Image = picDiscDefecte.Image
		picDisc.Cursor = Cursors.Default
		picDisc.Tag = "delfoto"
		Changed()
		
	End Sub
	
	Private Sub mnu_Help_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_Help.Click
		Dim Proces As Process = New Process
		Try
			Process.Start(MSC.Help.HELP_GEST_PRODUCCIO_DISCOS.ToString)
		Catch ex As Exception
		End Try
	End Sub

    Sub GridDadesCellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridDades.CellContentDoubleClick
        If MyAPP.NovaConnex(NAME_TEMES, Usuari.UsrNom, True) = True Then
            Dim StrSql As String = "tema_disc = " & Me.gridDades.CurrentRow.Cells(0).Value
            Try
                frmTemes.Show(Me)
            Catch ex As Exception
                frmTemes.WindowState = FormWindowState.Normal
            End Try
            frmTemes.getListTemes(StrSql)
        End If
    End Sub

    Private Sub frmDiscos_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        Dim FitxerINI As New IniFile
        frm_sice(0) = Me.Width : frm_sice(1) = Me.Height
        FitxerINI.INIWrite(MyAPP.IniFile, "Data Gest", "size", frm_sice(0).ToString & "," & frm_sice(1).ToString)
    End Sub

    Private Sub TimerQuery_Tick(sender As Object, e As EventArgs) Handles TimerQuery.Tick
        If IsLoadForm("frmBuscarDiscos") = True Then
            If frmBuscarDiscos.SqlQuery.Length > 3 Then
                getListDiscos(frmBuscarDiscos.SqlQuery)
                frmBuscarDiscos.SqlQuery = ""
            End If
        End If
    End Sub

    Private Sub txtCodiBarres_TextChanged(sender As Object, e As EventArgs) Handles txtCodiBarres.TextChanged
        picCodiBarres.Image = DrawCodiBarres(StandarsCodiBarres.code39, txtCodiBarres.Text)
    End Sub

    Private Sub ButtonCodiBarres_Click(sender As Object, e As EventArgs) Handles ButtonCodiBarres.Click
        If txtCodiBarres.TextLength > 0 Then
            cmdAddCodiBar.Tag = Me.txtCodiBarres.Text
            picCodiBar.Image = DrawCodiBarres(StandarsCodiBarres.code39, txtCodiBarres.Text)
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ColumnCBarres").Value = cmdAddCodiBar.Tag
            Changed()
        End If
    End Sub

    Private Sub ButtonHide_Click(sender As Object, e As EventArgs) Handles ButtonHide.Click
        PanelScanCodi.Hide()
    End Sub

    Dim MouseIsDown As Boolean = False
    Dim MouseIsDownLoc As Point = Nothing
    Private Sub PanelScanCodi_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelScanCodi.MouseMove
        If e.Button = MouseButtons.Left Then
            If MouseIsDown = False Then
                MouseIsDown = True
                MouseIsDownLoc = New Point(e.X, e.Y)
            End If
            PanelScanCodi.Location = New Point(Me.Location.X + e.X - MouseIsDownLoc.X, PanelScanCodi.Location.Y + e.Y - MouseIsDownLoc.Y)
        End If
    End Sub

    Private Sub PanelScanCodi_MouseUp(sender As Object, e As MouseEventArgs) Handles PanelScanCodi.MouseUp
        MouseIsDown = False
    End Sub
End Class