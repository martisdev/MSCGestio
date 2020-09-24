Option Strict Off
Option Explicit On
Imports System.Drawing.Drawing2D
Public Class frmPubli
	
	Dim blEnable As Boolean
	Public ModifBlocs As Boolean
	Dim blnNouRecord As Boolean
	Dim IsSaving As Boolean = False
	
	Dim PathPubli As String
    Friend Blocs(7, 95) As Boolean


    Private Sub CloseForm()
        If Me.cmdSalvar.Enabled = True Then
            If MetroFramework.MetroMessageBox.Show(Me, MSG_SAVE_DADES, MSG_ATENCIO, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, 100) = DialogResult.OK Then SaveRecord()
        End If
        If Bass.BASS_ChannelIsActive(StreamHandlePlay) Then Call Bass.BASS_StreamFree(StreamHandlePlay)
        MyAPP.CloseSesionClient(MyAPP.IDSesion_Client, DESCRIP_FORM_PUBLICITAT)
    End Sub
	
	Private Sub frmPubli_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		CloseForm()
	End Sub
	
	Private Sub TabCtlDies_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TabCtlDies.MouseUp
		PanelDia.Parent = TabCtlDies.TabPages(TabCtlDies.SelectedIndex)
		actualitzarListBlocs()
		refreshFrangesHora(TabCtlDies.SelectedIndex + 1)
	End Sub
	
	Private Sub cmdSortir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSortir.Click
		Me.Close()
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
	
	Public Sub getListFalques(Optional ByVal Condi As String = "")
		system.Windows.Forms.Cursor.Current = Cursors.AppStarting
        Dim StrSql As String = "SELECT falc_id, falc_nom, falc_client, falc_producte, falc_marca, falc_tarifa, falc_observ, falc_durada, falc_datacreacio, falc_nradia, falc_datain, falc_dataout, falc_tecnic,falc_locutor, falc_activa, falc_valida, falc_facturada, falc_propia, falc_dataradi FROM falques"
        If Condi.Length > 0 Then StrSql = StrSql & " WHERE " & Condi
        Dim db As New MSC.dbs(Cloud)

        Me.gridDades.DataSource = db.getTable(StrSql)
		db = Nothing
		Me.lbRecCount.Text = gridDades.Rows.Count

        If gridDades.Rows.Count = 0 Then MetroFramework.MetroMessageBox.Show(Me, MSG_NO_ITEM_FOR_CONDITION, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, 100)
        cmdBloqueix.Enabled = IIf(gridDades.Rows.Count And Usuari.UsrTipus > NivellUsers.USR_CONVIDAT, True, False)
		Me.mnuModif.Enabled = cmdBloqueix.Enabled
		gridDades.Focus()
		system.Windows.Forms.Cursor.Current = Cursors.Default
	End Sub

    Private Sub FindRecord()
        PanelSearchPubli.Location = New Point((Me.DisplayRectangle.Width - PanelSearchPubli.Width) / 2, 5)
        PanelSearchPubli.Show()
    End Sub

    Private Sub lockedRecord(Optional ByVal saved As Boolean = False)
        If Me.cmdSalvar.Enabled = True And saved = False Then
            If MetroFramework.MetroMessageBox.Show(Me, MSG_SAVE_DADES, MSG_ATENCIO, MessageBoxButtons.OKCancel, MessageBoxIcon.Information, 100) = DialogResult.OK Then SaveRecord()
        End If
        blEnable = Not blEnable
		If blEnable = False Then blnNouRecord = False 'si estem bloquejant
		ModifBlocs = False
		PanelDia.Enabled = blEnable
		'Me.Panel1.Enabled = blEnable
		txtNom.Enabled = blEnable
		ComboClient.Enabled = blEnable
		ComboProducte.Enabled = blEnable
		txtMarca.Enabled = blEnable
		ComboTarifes.Enabled = blEnable
		txtComent.Enabled = blEnable
		txtDataIn.Enabled = blEnable
		txtDataOut.Enabled = blEnable
		ComboTecnic.Enabled = blEnable
        ComboLocutor.Enabled = blEnable
        chkActive.Enabled = blEnable
		chkValida.Enabled = blEnable
		chkFactura.Enabled = blEnable
		chkPropia.Enabled = blEnable
		
		
		Me.cmdAssistBlocs.Enabled = blEnable
		
		Me.mnuCalcDurada.Enabled = blEnable
		Me.mnuDel.Enabled = blEnable
		'Me.mnuNew.Enabled = blEnable
		mnuEditAudio.Enabled = blEnable
		Me.cmdBorrar.Enabled = blEnable
		Me.lbNou.Visible = False
		If blEnable Then
			Me.cmdBloqueix.Image = Me.picUnLock.Image
		Else
			Me.cmdBloqueix.Image = Me.picLock.Image
			Me.cmdSalvar.Enabled = False
			Me.mnuSave.Enabled = False
		End If
	End Sub
	
	Private Sub NewRecord()
		blnNouRecord = True
		DeSelectAllRowsGrid(gridDades)
		gridDades.AllowUserToAddRows = True
		gridDades.FirstDisplayedScrollingRowIndex = gridDades.NewRowIndex
		Me.gridDades.Rows(gridDades.NewRowIndex).Selected = True
		Me.gridDades.Rows(gridDades.NewRowIndex).Cells(0).Value = 0
		'establir Valors per defecte (automàticament incorporats al datagrid)
		
		
		'gridDades.MultiSelect = False
		BorraPantalla()
		'gridDades.MultiSelect = True
		blEnable = False
		lockedRecord()        
		
		Me.lbNou.Visible = True
		Me.txtNom.Focus()
		
	End Sub
	
	Private Sub BorraPantalla()
		Me.lbID.Text = 0
		
		Me.txtNom.Text = ""
		Me.txtComent.Text = ""
		Me.txtMarca.Text = ""
		
		Me.lbDataCrea.Text = ""
		Me.lbDurada.Text = "00:00:00"
		Me.txtDataIn.Value = Now
		Me.txtDataOut.Value = Now
		Me.lbNRadia.Text = 0
		
		Me.chkActive.Checked = False
		Me.chkFactura.Checked = False
		Me.chkValida.Checked = False
		Me.chkPropia.Checked = False
		
		Me.ComboClient.SelectedValue = 0
		Me.ComboProducte.SelectedValue = 0
        Me.ComboTarifes.SelectedValue = 0
        Me.ComboTecnic.SelectedValue = 0
		Me.ComboLocutor.SelectedValue = 0
	End Sub
	
	Private Sub DeleteRecord()
		
		If blnNouRecord = True Then 
			LockedRecord(True)
			BorraPantalla()
			gridDades.AllowUserToAddRows = False
			Exit Sub
		End If

        If MetroFramework.MetroMessageBox.Show(Me, String.Format(MSG_CONFIRM_DELETE_NUM_DADES, gridDades.SelectedRows.Count), MSG_ATENCIO, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, 100) = DialogResult.Cancel Then Exit Sub

        Dim db As New MSC.dbs(Cloud)
        Dim StrSql As String = ""
		Dim Fitxer As String
		
		db.IniTransaction()
		For i As Short = 0 To gridDades.SelectedRows.Count - 1
			'Borrar dbs
			Dim ID As String = gridDades.SelectedRows(i).Cells("ColumnID").Value.ToString
			StrSql = "DELETE FROM falques WHERE falc_id=" & ID & " ;"
            db.Delete_ID(StrSql)
            addCtlRadi(0, CShort(Tipus_Play.CTL_SQL), 0, "00:00:00", 0, 0, Usuari.UsrID, StrSql, 0, False)

            'Borrar Radiacifalques
            For u As Short = 1 To 7
				StrSql = "DELETE FROM radiaciofalques" & u.ToString & " WHERE radiID=" & lbID.Text
				db.Delete_ID(StrSql)
			Next u
			
			'Borrar fitxer 
			Fitxer = PathPubli & ID.ToString & ".mp3"
			If IO.File.Exists(Fitxer) Then
                Try
                    IO.File.Delete(Fitxer)
                Catch ex As Exception
                    MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_DELETE_FILE, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
                End Try
			End If
		Next
		db.EndTransaction()
		db = Nothing
		'Borrar llistat   
		lbRecCount.Text = CInt(lbRecCount.Text) - gridDades.SelectedRows.Count
		gridDades.AllowUserToDeleteRows = True
		For Each selectedrow As DataGridViewRow In gridDades.SelectedRows
			gridDades.Rows.Remove(selectedrow)
		Next
		gridDades.AllowUserToDeleteRows = False
		RefreshDataSet(TAULES_DBS.TAULA_PUBLICITAT)
		
	End Sub
	
	Private Sub SaveRecord()
		Dim Nom, Observ As String
		Dim Client, Product As Short
		Dim Marca As String
		Dim Tarifa As Short
		Dim DataIn, DataOut As Date
        Dim Vali, Activ, Fact As Boolean
        Dim Durada As Date
		Dim IsPropia As Boolean
		Dim tecnic As Short
		Dim Locutor As Short

        If Not MyAPP.PermisPerContinuar() Then MetroFramework.MetroMessageBox.Show(Me, MSG_SERVER_CLOSE, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Stop, 100) : Me.Close()
        If MetroFramework.MetroMessageBox.Show(Me, MSG_CONFIRM_SAVE_DADES, MSG_ATENCIO, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, 100) = DialogResult.Cancel Then Exit Sub
        If Len(Me.txtNom.Text) = 0 Then
            MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_NOM, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
            Exit Sub
        ElseIf Me.ComboClient.SelectedValue < 1 Then
            MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_CLIENT, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
            Exit Sub
        ElseIf Me.ComboProducte.SelectedValue < 1 Then
            MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_PRODUCTE, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
            Exit Sub
        ElseIf Me.ComboTarifes.SelectedValue < 1 Then
            MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_TARIFA, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
            Exit Sub
		End If
		IsSaving = True
		Nom = AddSlashes(Me.txtNom.Text)
		Observ = AddSlashes(Me.txtComent.Text)
		Marca = AddSlashes(Me.txtMarca.Text)
		
		DataIn = Me.txtDataIn.Value
		DataOut = Me.txtDataOut.Value
		
		Activ = Me.chkActive.Checked
		Vali = Me.chkValida.Checked
		Fact = Me.chkFactura.Checked
		IsPropia = Me.chkPropia.Checked
		Durada = CDate(Me.lbDurada.Text)
		
		Client = Me.ComboClient.SelectedValue
		Product = ComboProducte.SelectedValue
        Tarifa = ComboTarifes.SelectedValue
        tecnic = Me.ComboTecnic.SelectedValue
		Locutor = Me.ComboLocutor.SelectedValue
		Dim StrSql As String = ""
		Dim ID As Integer = lbID.Text
        Dim db As New MSC.dbs(Cloud)
        If blnNouRecord Then
			StrSql = "INSERT INTO falques (falc_client, falc_nom, falc_observ, falc_marca, falc_activa"
			StrSql = StrSql & ", falc_facturada, falc_producte, falc_datain, falc_dataout, falc_tarifa, falc_valida"
            StrSql = StrSql & ", falc_durada, falc_propia, falc_tecnic, falc_locutor, falc_datacreacio)"

            StrSql = StrSql & " VALUES "
			StrSql = StrSql & "( " & Client
			StrSql = StrSql & ", '" & Nom & "'"
			StrSql = StrSql & ", '" & Observ & "'"
			StrSql = StrSql & ", '" & Marca & "'"
			StrSql = StrSql & ", " & CShort(IIf(Activ, 1, 0))
			StrSql = StrSql & ", " & CShort(IIf(Fact, 1, 0))
			StrSql = StrSql & ", " & Product
			StrSql = StrSql & ", '" & DataIn.ToString("yyyy-MM-dd") & "'"
			StrSql = StrSql & ", '" & DataOut.ToString("yyyy-MM-dd") & "'"
			StrSql = StrSql & ", " & Tarifa
			StrSql = StrSql & ", " & CShort(IIf(Vali, 1, 0))
            StrSql = StrSql & ", '" & Durada.ToString("HH:mm:ss") & "'"
            StrSql = StrSql & ", " & CShort(IIf(IsPropia, 1, 0))
			StrSql = StrSql & ", " & tecnic
			StrSql = StrSql & ", " & Locutor
			StrSql = StrSql & ", '" & Now.ToString("yyyy-MM-dd HH:mm:ss") & "'"
			StrSql = StrSql & ");"
			
			ID = db.New_ID(StrSql)
			createBlocs(ID, IsPropia)
			If ModifBlocs Then salvarBlocs(ID)
			
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
				gridDades.DataSource = dt
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
			StrSql = "UPDATE falques"
			StrSql = StrSql & " SET "
			StrSql = StrSql & " falc_client = " & Client
			StrSql = StrSql & ", falc_nom = '" & Nom & "'"
			StrSql = StrSql & ", falc_observ = '" & Observ & "'"
			StrSql = StrSql & ", falc_marca = '" & Marca & "'"
			StrSql = StrSql & ", falc_activa = " & CShort(IIf(Activ, 1, 0))
			StrSql = StrSql & ", falc_facturada = " & CShort(IIf(Fact, 1, 0))
			StrSql = StrSql & ", falc_producte = " & Product
			StrSql = StrSql & ", falc_datain = '" & DataIn.ToString("yyyy-MM-dd") & "'"
			StrSql = StrSql & ", falc_dataout = '" & DataOut.ToString("yyyy-MM-dd") & "'"
			StrSql = StrSql & ", falc_tarifa = " & Tarifa
			StrSql = StrSql & ", falc_valida = " & CShort(IIf(Vali, 1, 0))
            StrSql = StrSql & ", falc_durada = '" & Durada.ToString("HH:mm:ss") & "'"
            StrSql = StrSql & ", falc_propia = " & CShort(IIf(IsPropia, 1, 0))
			StrSql = StrSql & ", falc_tecnic = " & tecnic
			StrSql = StrSql & ", falc_locutor = " & Locutor
			StrSql = StrSql & " WHERE falc_id = " & ID & " ;"
			
			db.Update_ID(StrSql)
			
			If ModifBlocs Then salvarBlocs(CShort(ID))
		End If
		db = Nothing
		IsSaving = False
		lockedRecord(True)
		ModifBlocs = False
	End Sub
	
	Private Sub cmdRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefrescar.Click
		getListFalques()
	End Sub
	
	Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
		FindRecord()
	End Sub
	
	Private Sub cmdSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalvar.Click
		SaveRecord()
	End Sub
	
	Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
		DeleteRecord()
	End Sub
	
	Private Sub cmdBloqueix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBloqueix.Click
		lockedRecord()
	End Sub
	
	Private Sub cmdNou_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNou.Click
		NewRecord()
	End Sub
	
	Private Sub frmPubli_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
		setLanguageForm()
        If My.Settings.TXT_CAPITALIZE Then
            Me.txtComent.CharacterCasing = CharacterCasing.Upper
            Me.txtNom.CharacterCasing = CharacterCasing.Upper
            Me.txtMarca.CharacterCasing = CharacterCasing.Upper
        End If

        If Not frmMain.NoLoadRs Then getListFalques()
		
		Dim UsrTipus As Integer = Usuari.UsrTipus
		'Me.cmdBloqueix.Enabled = IIf(UsrTipus > NivellUsers.USR_CONVIDAT, True, False)
		'Me.mnuModif.Enabled = cmdBloqueix.Enabled
		Me.cmdNou.Enabled = IIf(UsrTipus > NivellUsers.USR_CONVIDAT, True, False)
		Me.cmdNou.Visible = frmMain.VisibleNew
		mnuNew.Enabled = IIf(UsrTipus > NivellUsers.USR_CONVIDAT, True, False)
		Me.mnuNew.Visible = frmMain.VisibleNew

        PathPubli = Params.PathPublicitat
        Dim rsDiesSetman As DataTable = DiesSetmana()
        For i As Integer = 0 To rsDiesSetman.Rows.Count - 1
            Me.lstDiesDisp.Items.Add(rsDiesSetman.Rows(i)(1).ToString)
        Next
        For a As Integer = 0 To 23 ' Nº d'aplicatius
            Me.lstHoresDisp.Items.Add(Strings.Format(a, "00") & ":00")
        Next
        Me.ClientSize = New Size(frm_sice(0), frm_sice(1))

    End Sub
	
	
	Dim MSG_ERROR_CLIENT As String
	Dim MSG_ERROR_PRODUCTE As String
	Dim MSG_ERROR_TARIFA As String

    Dim MSG_ERROR_NUM_MINIM_RADIA As String
    Dim MSG_ERROR_NUM_BLOCS As String
    Dim MSG_ERROR_NUM_DIES As String
    Dim MSG_PROCESS_END As String

    Public Sub setLanguageForm()
		lang.StrForm = Me.Name
				
		MSG_ERROR_CLIENT = lang.getText("MSG_ERROR_CLIENT")'"És obligatori especificar un Client."
		MSG_ERROR_PRODUCTE = lang.getText("MSG_ERROR_PRODUCTE")'"És obligatori especificar un producte."
		MSG_ERROR_TARIFA = lang.getText("MSG_ERROR_TARIFA")'"És obligatori especificar una tarifa."
		
		'Me.ToolStrip1.Text = "ToolStrip1"
		Me.cmdPrimer.Text = lang.getText("LABEL_GOTO_FIRSH",True)'"Primer"
		Me.cmdPrevi.Text = lang.getText("LABEL_GOTO_PREV",True)'"Anterior"
		Me.cmdSeguent.Text = lang.getText("LABEL_GOTO_NEXT",True)'"Següent"
		Me.cmdUltim.Text = lang.getText("LABEL_GOTO_LAST",True)'"Últim"
		Me.cmdNou.Text = lang.getText("LABEL_NEW",True) '"Nou"
		'Me.cmdBloqueix.Text = "Bloquejar"
		Me.cmdBorrar.Text = lang.getText("LABEL_DELETE",True) '"Borrar
		Me.cmdSalvar.Text = lang.getText("LABEL_SAVE",True)'"Salvar"
		Me.cmdRefrescar.Text = Lang.getText("LABEL_REFRESCAR",True)'"Refrescar"
		Me.cmdBuscar.Text = lang.getText("LABEL_BUSCAR",True)'"Buscar"
		Me.cmdSortir.Text = lang.getText("LABEL_EXIT",True) '"Sortir"		
		Me.cmdStop.Text = lang.getText("LABEL_STOP",True) '"Stop"
		Me.cmdPlay.Text = lang.getText("LABEL_PLAY_PAUSA",True) '"Play/Pausa"
		'Me.MenuStrip1.Text = "MenuStrip1"
		Me.ProgarmaToolStripMenuItem.Text = lang.getText("LABEL_PROGRAMA",True) '"Programa"	
		Me.mnuExit.Text = lang.getText("LABEL_EXIT",True) '"Sortir"
		Me.ReproductorToolStripMenuItem.Text = lang.getText("LABEL_REPRODUCTOR",True) '"Reproductor"
		Me.mnuPlay.Text = lang.getText("LABEL_PLAY_PAUSA",True) '"Play/Pausa"
		Me.mnuStop.Text =  lang.getText("LABEL_STOP",True) '"Stop"
		Me.mnuCalcDurada.Text =  lang.getText("LABEL_CALC_DURADA",True) '"Calcular Durada"
		Me.mnuFinal.Text = lang.getText("LABEL_END_TEMA",True) '"Final Tema"
		Me.EdicióToolStripMenuItem.Text = lang.getText("mnuEdit.Text",True )'"Edició"
		Me.mnuModif.Text = lang.getText("LABEL_MODIFICAR",True )'"Modificar"
		Me.mnuSave.Text = lang.getText("LABEL_SALVAR",True) '"Salvar"
		Me.mnuNew.Text = lang.getText("LABEL_NEW",True) '"Nou"
		Me.mnuDel.Text = lang.getText("LABEL_DELETE",True) '"Borrar"
		Me.mnuEditAudio.Text = lang.getText("mnuEditAudio.Text",True) '"Editar l'àudio"
		Me.mnuBuscar.Text = lang.getText("LABEL_BUSCAR",True)'"Buscar"
		Me.mnuRefresh.Text = Lang.getText("LABEL_REFRESCAR",True)'"Refrescar"
		Me.AjudaToolStripMenuItem.Text = lang.getText("mnu_Help",True) '"Ajuda"
		Me.mnu_Help.Text = lang.getText("mnuRefHelp.Text",True) '"Manual OnLine"		
		Me.ColumnID.HeaderText = lang.getText("HEADERTEXT_ID",True) '"ID"
		Me.ColumnNom.HeaderText = lang.getText("LABEL_NOM",True) '"Nom"
		Me.ColumnComent.HeaderText = lang.getText("LABEL_COMMENT",True) '"Comentari"
        Me.ColumnDurada.HeaderText = lang.getText("HEADERTEXT_DURADA", True) '"Durada"		
        Me.ColumnActiva.HeaderText = lang.getText("LABEL_ACTIVA",True) '"Activa"
		Me.TabPage3.Text = lang.getText("NAME_DILLUNS",True)'"Dilluns"
		Me.TabPage4.Text = lang.getText("NAME_DIMARTS",True)'"Dimarts"
		Me.TabPage5.Text = lang.getText("NAME_DIMECRES",True)'"Dimecres"
		Me.TabPage6.Text = lang.getText("NAME_DIJOUS",True)'"Dijous"
		Me.TabPage7.Text = lang.getText("NAME_DIVENDRES",True)'"Divendres"
		Me.TabPage8.Text = lang.getText("NAME_DISSABTE",True) '"Dissabte"
        Me.TabPage9.Text = lang.getText("NAME_DIUMENGE", True) '"Diumenge"		
        Me.chkActive.Text = lang.getText("LABEL_ACTIVA",True) '"Activa"
		Me.Label7.Text = lang.getText("LABEL_IDENTIFICADOR",True) '"Identificador"
		Me.Label4.Text = lang.getText("HEADERTEXT_DURADA",True) '"Durada"
		Me.Label2.Text = lang.getText("LABEL_NOM",True) '"Nom"
		Me.lbNou.Text = lang.getText("LABEL_NEW_UPPER",True) ' "NOU"
		Me.ComboGridClient.HeaderText = lang.getText("HEADERTEXT_CLIENT",True) '"Client"
		Me.ComboGridProducte.HeaderText = lang.getText("LABEL_PRODUCTE",True) '"Producte"
		Me.ColumnMarca.HeaderText = lang.getText("LABEL_MARCA",True) '"Marca"
		Me.ColumnDataCrea.HeaderText = lang.getText("HEADERTEXT_DATE_CREA",True) '"Data Creació"
		Me.ColumnNumRadi.HeaderText = lang.getText("LABEL_NUM_RADIACIONS",True) '"Núm. Radiacions"
		Me.ColumnDataIn.HeaderText = lang.getText("LABEL_DATA_IN_",True) '"Data In"
		Me.ComboGridLocutor.HeaderText = lang.getText("HEADERTEXT_LOCUTOR",True) '"Locutor"		
		Me.ColumnDataRadi.HeaderText = lang.getText("LABEL_DATA_RADIACIO",True) '"Data Radiació"
		Me.lbLocutor.Text = lang.getText("HEADERTEXT_LOCUTOR",True) '"Locutor"	
		Me.Label3.Text = lang.getText("LABEL_MARCA",True) '"Marca"
		Me.lbProducte.Text = lang.getText("LABEL_PRODUCTE",True) '"Producte"
		Me.lbClient.Text = lang.getText("HEADERTEXT_CLIENT",True) '"Client"	
		
		Me.lbAtencio.Text = lang.getText("LABEL_NO_EXIST",True)'"No existeix"
		Me.cmdAssistBlocs.Text = lang.getText("cmdAssistBlocs.Text")'"Assistent d'assignació"
		Me.TabPage1.Text = lang.getText("TabPage1.Text")'"Llistat de falques"
		Me.cbTarifa.Text = lang.getText("cbTarifa.Text")'"Tarifa"
		Me.ComboGridTarifa.HeaderText = cbTarifa.Text '"Tarifa"
		Me.ColumnDataOut.HeaderText = lang.getText("LABEL_DATA_OUT",True)'"Data Out"
		
		Me.ColumnValida.HeaderText = lang.getText("LABEL_VALIDA",True)'"Vàlida"
		Me.ColumnFacturada.HeaderText = lang.getText("LABEL_FACTURADA",True)'"facturada"
		Me.ColumnPropia.HeaderText = lang.getText("ColumnPropia.HeaderText")'"Pròpia"
		Me.TabPage2.Text = lang.getText("TabPage2.Text")'"Detall blocs a radiar"		
		Me.Label38.Text = lang.getText("Label38.Text")'"Blocs"
		Me.Label39.Text = lang.getText("LABEL_HORES",True)'"Hores"				
		Me.Label64.Text = lang.getText("LABEL_DATA_OUT",True)'"Data Sortida"
		Me.Label6.Text = lang.getText("LABEL_DATA_IN",True)'"Data Entrada"
		Me.Label9.Text = lang.getText("LABEL_NUM_RADIACIONS",True)'"Nº de radiacions"
		Me.lbTecnic.Text = lang.getText("lbTecnic.Text")'"Tècnic"
		Me.ComboGridTecnic.HeaderText = lbTecnic.Text'"Tècnic"
		Me.chkPropia.Text = lang.getText("LABEL_PROPIA_RADIO",True)'"Pròpia de la ràdio"
		Me.chkFactura.Text = lang.getText("LABEL_FACTURADA",True)'"Facturada"
		Me.chkValida.Text = lang.getText("LABEL_VALIDA",True)'"Vàlida"		
		Me.Label8.Text = lang.getText("LABEL_DATA_CREACIO",True)'"Data de Creació"		
		
		Me.Label5.Text = lang.getText("LABEL_OBSERVACIONS",True) '"Observacions"		
        'Me.cmdExit.Text = "Button1"

        '---------------------
        MSG_ERROR_NUM_MINIM_RADIA = lang.getText("MSG_ERROR_NUM_MINIM_RADIA") '"El número de radiació mínim és 1."
        MSG_ERROR_NUM_BLOCS = lang.getText("MSG_ERROR_NUM_BLOCS") '"No es poden assignar tants blocs en tant poques hores i dies."
        MSG_ERROR_NUM_DIES = lang.getText("MSG_ERROR_NUM_DIES") '"La publicitat no hi cap en tants pocs dies."
        MSG_PROCESS_END = lang.getText("MSG_PROCESS_END") '"Assignació realitzada."			

        Me.Label66.Text = lang.getText("Label4.Text") '"Assignar dies i hores possibles:"
        Me.Label1.Text = lang.getText("Label2.Text") '"Nº màxim de radiacions per dia:"
        Me.Label65.Text = lang.getText("Label1.Text") '"Nº de radiacions (setmanals):"
        Me.chkRespect.Text = lang.getText("chkRespect.Text") '"Respectar assignacions prèvies."
        chkRespectTemplates.Text = lang.getText("chkRespect.Text")
        chk_DiesAll.Text = lang.getText("LABEL_TOTS", True) '"Tots"
        Me.chk_Hores_all.Text = lang.getText("LABEL_TOTS", True) '"Tots"        
        Me.Label67.Text = lang.getText("Label3.Text") '"Assignarà aleatòriament l'hora on ha de sonar la publicitat."
        Me.MetroTabPage1.Text = lang.getText("MetroTabPage1.Text") '"Aleatori"
        Me.MetroTabPage2.Text = lang.getText("MetroTabPage2.Text") '"Plantilles"
        Label5.Text = lang.getText("LABEL_NOM", True) ' nom
        groupBoxEditPlantilla.Text = lang.getText("LABEL_EDITAR", True) ' Editar		
        '--------------------
        '-------------
        Me.Label68.Text = lang.getText("LABEL_NOM", True) '"Nom"
        Me.Label73.Text = lang.getText("HEADERTEXT_CLIENT", True) '"Client"
        Me.Label72.Text = lang.getText("LABEL_PRODUCTE", True) '"Producte"
        Me.Label71.Text = lang.getText("LABEL_MARCA", True) '"Marca"
        Me.chkActiveSearch.Text = lang.getText("LABEL_ACTIVA", True) '"Activa"

        Me.chkPropiaSearch.Text = lang.getText("LABEL_PROPIA_RADIO", True) '"Pròpia de la ràdio"
        Me.chkFacturaSearch.Text = lang.getText("LABEL_FACTURADA", True) '"Facturada"
        Me.chkValidaSearch.Text = lang.getText("LABEL_VALIDA", True) '"Vàlida"		
        Me.chkActual.Text = lang.getText("chkActual.Text") '"Vigents (actives i no caducades)"
        Me.lbTitleSearch.Text = lang.getText("lbTitleSearch.Text") '"Buscar falca ..."		
        '---------------
        Me.Text = lang.getText("Text") '"Manteniment de la Publicitat"
        Dim Cmb As New combo
        Cmb.OmpleCombo(ComboClient, TAULES_DBS.TAULA_CLIENTS, TotsCap.CAP) : ComboClient.SelectedValue = 0
        Cmb.OmpleCombo(ComboGridClient, TAULES_DBS.TAULA_CLIENTS, TotsCap.CAP)
        Cmb.OmpleCombo(ComboProducte, TAULES_DBS.TAULA_PRODUCTES, TotsCap.CAP) : ComboProducte.SelectedValue = 0
        Cmb.OmpleCombo(ComboGridProducte, TAULES_DBS.TAULA_PRODUCTES, TotsCap.CAP)
        Cmb.OmpleCombo(ComboTarifes, TAULES_DBS.TAULA_TARIFES, TotsCap.CAP) : ComboTarifes.SelectedValue = 0
        Cmb.OmpleCombo(ComboGridTarifa, TAULES_DBS.TAULA_TARIFES, TotsCap.CAP)
        Cmb.OmpleCombo(ComboTecnic, TAULES_DBS.TAULA_TECNICS, TotsCap.CAP) : ComboTecnic.SelectedValue = 0
        Cmb.OmpleCombo(ComboGridTecnic, TAULES_DBS.TAULA_TECNICS, TotsCap.CAP)
        Cmb.OmpleCombo(ComboLocutor, TAULES_DBS.TAULA_LOCUTORS, TotsCap.CAP) : ComboLocutor.SelectedValue = 0
        Cmb.OmpleCombo(ComboGridLocutor, TAULES_DBS.TAULA_LOCUTORS, TotsCap.CAP)

        Cmb.OmpleCombo(ComboClientSearch, TAULES_DBS.TAULA_CLIENTS, TotsCap.CAP) : ComboClientSearch.SelectedValue = 0
        Cmb.OmpleCombo(ComboProducSearch, TAULES_DBS.TAULA_PRODUCTES, TotsCap.CAP) : ComboProducSearch.SelectedValue = 0
        'Templates               
        Cmb.OmpleCombo(comboBoxPlantillesPubli, TAULES_DBS.TAULA_ADV_TEMPLATES, TotsCap.CAP) : comboBoxPlantillesPubli.SelectedValue = 0

    End Sub
	
	Private Sub ShowValuesID()
		If IsSaving = True Then Exit Sub
		Try
			If blEnable = True Then lockedRecord()
			Me.lbAtencio.Visible = False
			tmrDetalls.Enabled = False
			Me.lbID.Text = gridDades.CurrentRow.Cells("columnID").Value
			
			Me.txtNom.Text = StripSlashes(gridDades.CurrentRow.Cells("columnNom").Value)
			Me.txtComent.Text = StripSlashes(NoNul(gridDades.CurrentRow.Cells("columnComent").Value))
			Me.txtMarca.Text = StripSlashes(NoNul(gridDades.CurrentRow.Cells("columnMarca").Value))
			Me.chkActive.Checked = gridDades.CurrentRow.Cells("columnActiva").Value
			Me.chkFactura.Checked = gridDades.CurrentRow.Cells("columnFacturada").Value
			
			Me.lbDataCrea.Text = gridDades.CurrentRow.Cells("columnDataCrea").Value.ToString
			Me.lbDurada.Text = gridDades.CurrentRow.Cells("columnDurada").Value.ToString   '"HH:mm:ss"
			Me.txtDataIn.Value = gridDades.CurrentRow.Cells("columnDataIn").Value.ToString
			Me.txtDataOut.Value = gridDades.CurrentRow.Cells("columnDataOut").Value.ToString
			Me.lbNRadia.Text = gridDades.CurrentRow.Cells("ColumnNumRadi").Value
			
			Me.chkValida.Checked = gridDades.CurrentRow.Cells("columnValida").Value
			Me.chkPropia.Checked = gridDades.CurrentRow.Cells("columnPropia").Value
			
			Me.ComboClient.SelectedValue = gridDades.CurrentRow.Cells("ComboGridClient").Value
			Me.ComboProducte.SelectedValue = gridDades.CurrentRow.Cells("ComboGridProducte").Value
            Me.ComboTarifes.SelectedValue = gridDades.CurrentRow.Cells("ComboGridTarifa").Value
            Me.ComboTecnic.SelectedValue = gridDades.CurrentRow.Cells("ComboGridTecnic").Value
			Me.ComboLocutor.SelectedValue = gridDades.CurrentRow.Cells("ComboGridLocutor").Value
			
			Me.lbPosition.Text = gridDades.CurrentRow.Index + 1
			tmrDetalls.Enabled = True
		Catch ex As Exception
			BorraPantalla()
		End Try
		Me.cmdSalvar.Enabled = False
	End Sub

    Private Sub KeyPress_Combo(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles _
         ComboClient.KeyPress, ComboLocutor.KeyPress _
        , ComboProducte.KeyPress, ComboTarifes.KeyPress, ComboTecnic.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub TextChanged_Combo(ByVal sender As Object, ByVal e As System.EventArgs) Handles _
         ComboClient.TextChanged, ComboLocutor.TextChanged _
        , ComboProducte.TextChanged, ComboTarifes.TextChanged, ComboTecnic.TextChanged

        Changed()
    End Sub

    Private Sub KeyUp_Combo(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles _
         ComboClient.KeyUp, ComboLocutor.KeyUp _
        , ComboProducte.KeyUp, ComboTarifes.KeyUp, ComboTecnic.KeyUp
        Select Case e.KeyCode
            Case Keys.Left, Keys.Right, Keys.Up, Keys.Down
                Return
        End Select
        Dim MyComboBox As ComboBox = CType(sender, ComboBox)
        Dim Origen As TAULES_DBS

        Select Case MyComboBox.Name
            Case "ComboClient" : Origen = TAULES_DBS.TAULA_CLIENTS
            Case "ComboLocutor" : Origen = TAULES_DBS.TAULA_LOCUTORS
            Case "ComboProducte" : Origen = TAULES_DBS.TAULA_PRODUCTES
            Case "ComboTarifes" : Origen = TAULES_DBS.TAULA_TARIFES
            Case "ComboTecnic" : Origen = TAULES_DBS.TAULA_TECNICS
        End Select
        refreshComboBoxKeyUp(MyComboBox, Origen, TotsCap.CAP)

    End Sub

    Private Sub Combo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles _
         ComboClient.LostFocus, ComboLocutor.LostFocus _
        , ComboProducte.LostFocus, ComboTarifes.LostFocus, ComboTecnic.LostFocus
        Dim MyComboBox As ComboBox = CType(sender, ComboBox)
        Dim ID As Integer = MyComboBox.SelectedValue
        Dim Origen As TAULES_DBS
        Select Case MyComboBox.Name
            Case "ComboClient" : Origen = TAULES_DBS.TAULA_CLIENTS
            Case "ComboLocutor" : Origen = TAULES_DBS.TAULA_LOCUTORS
            Case "ComboProducte" : Origen = TAULES_DBS.TAULA_PRODUCTES
            Case "ComboTarifes" : Origen = TAULES_DBS.TAULA_TARIFES
            Case "ComboTecnic" : Origen = TAULES_DBS.TAULA_TECNICS
        End Select
        Dim Cmb As New combo
        Cmb.OmpleCombo(MyComboBox, Origen, TotsCap.CAP)
        MyComboBox.SelectedValue = ID
    End Sub


    Private Sub Click_CheckBox(ByVal sender As Object, ByVal e As System.EventArgs) Handles _
        CheckBox1.Click, CheckBox2.Click, CheckBox3.Click, CheckBox4.Click, CheckBox5.Click, CheckBox6.Click, CheckBox7.Click, CheckBox8.Click, CheckBox9.Click, CheckBox10.Click _
        , CheckBox11.Click, CheckBox12.Click, CheckBox13.Click, CheckBox14.Click, CheckBox15.Click, CheckBox16.Click, CheckBox17.Click, CheckBox18.Click, CheckBox19.Click, CheckBox20.Click _
        , CheckBox21.Click, CheckBox22.Click, CheckBox23.Click, CheckBox24.Click, CheckBox25.Click, CheckBox26.Click, CheckBox27.Click, CheckBox28.Click, CheckBox29.Click, CheckBox30.Click _
        , CheckBox31.Click, CheckBox32.Click, CheckBox33.Click, CheckBox34.Click, CheckBox35.Click, CheckBox36.Click, CheckBox37.Click, CheckBox38.Click, CheckBox39.Click, CheckBox40.Click _
        , CheckBox41.Click, CheckBox42.Click, CheckBox43.Click, CheckBox44.Click, CheckBox45.Click, CheckBox46.Click, CheckBox47.Click, CheckBox48.Click, CheckBox49.Click, CheckBox50.Click _
        , CheckBox51.Click, CheckBox52.Click, CheckBox53.Click, CheckBox54.Click, CheckBox55.Click, CheckBox56.Click, CheckBox57.Click, CheckBox58.Click, CheckBox59.Click, CheckBox60.Click _
        , CheckBox61.Click, CheckBox62.Click, CheckBox63.Click, CheckBox64.Click, CheckBox65.Click, CheckBox66.Click, CheckBox67.Click, CheckBox68.Click, CheckBox69.Click, CheckBox70.Click _
        , CheckBox71.Click, CheckBox72.Click, CheckBox73.Click, CheckBox74.Click, CheckBox75.Click, CheckBox76.Click, CheckBox77.Click, CheckBox78.Click, CheckBox79.Click, CheckBox80.Click _
        , CheckBox81.Click, CheckBox82.Click, CheckBox83.Click, CheckBox84.Click, CheckBox85.Click, CheckBox86.Click, CheckBox87.Click, CheckBox88.Click, CheckBox89.Click, CheckBox90.Click _
        , CheckBox91.Click, CheckBox92.Click, CheckBox93.Click, CheckBox94.Click, CheckBox95.Click, CheckBox96.Click

        Dim Dia As Short = Me.TabCtlDies.SelectedIndex
        Dim NumBloc As Short = CType(sender, MetroFramework.Controls.MetroCheckBox).TabIndex
        Blocs(Dia, NumBloc) = CType(sender, MetroFramework.Controls.MetroCheckBox).Checked
        ModifBlocs = True
        Changed()
    End Sub

    Friend Sub Changed()
        If blEnable = True Then Me.cmdSalvar.Enabled = True : mnuSave.Enabled = True
    End Sub

    Public Sub actualitzarListBlocs()

        'If lbID.Text = 0 Then Exit Sub

        Dim dia As Short = Me.TabCtlDies.SelectedIndex
        Dim i As Short
        For i = 0 To 95
            Dim NomCheck As String = "CheckBox" & i + 1
            Dim chk As MetroFramework.Controls.MetroCheckBox = CType(PanelBlocs.Controls(NomCheck), MetroFramework.Controls.MetroCheckBox)
            chk.Checked = Blocs(dia, i)
        Next i
        Me.cmdSalvar.Enabled = False : mnuSave.Enabled = False
        Me.Refresh()
    End Sub

    Private Sub ConsultaListBlocs()
        If lbID.Text = 0 Then Exit Sub
        Dim db As New MSC.dbs(Cloud)
        Dim rs As DataTable = Nothing
        For dia As Short = 1 To 7
            Dim StrSql As String = "SELECT * FROM radiaciofalques" & dia & " WHERE radiID = " & Me.lbID.Text & ";"
            rs = db.getTable(StrSql)
            If rs.Rows.Count > 0 Then
                For NumBloc As Short = 0 To 95
                    Dim ValorBloc As Boolean = rs.Rows(0)(NumBloc + 1)
                    'TODO: aquest procediment no és correcte, no sé exactament quin és el problema
                    Blocs(dia - 1, NumBloc) = ValorBloc
                Next NumBloc
            End If
        Next dia
        db = Nothing
        rs.Dispose()
        actualitzarListBlocs()
    End Sub

    Private Sub TabControl1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TabControl1.MouseUp
        actualitzarListBlocs()
        refreshFrangesHora(TabCtlDies.SelectedIndex + 1)
    End Sub

    Private Sub txtDataIn_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDataIn.ValueChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ColumnDataIn").Value = txtDataIn.Value
            Changed()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub salvarBlocs(ByRef IDFalca As Short)
        For DiaSetman As Short = 0 To 6
            UpdateDades00_04(DiaSetman + 1, IDFalca, Blocs(DiaSetman, 0), Blocs(DiaSetman, 1), Blocs(DiaSetman, 2), Blocs(DiaSetman, 3), Blocs(DiaSetman, 4), Blocs(DiaSetman, 5), Blocs(DiaSetman, 6), Blocs(DiaSetman, 7), Blocs(DiaSetman, 8), Blocs(DiaSetman, 9), Blocs(DiaSetman, 10), Blocs(DiaSetman, 11), Blocs(DiaSetman, 12), Blocs(DiaSetman, 13), Blocs(DiaSetman, 14), Blocs(DiaSetman, 15), Blocs(DiaSetman, 16), Blocs(DiaSetman, 17), Blocs(DiaSetman, 18), Blocs(DiaSetman, 19))
            UpdateDades05_09(DiaSetman + 1, IDFalca, Blocs(DiaSetman, 20), Blocs(DiaSetman, 21), Blocs(DiaSetman, 22), Blocs(DiaSetman, 23), Blocs(DiaSetman, 24), Blocs(DiaSetman, 25), Blocs(DiaSetman, 26), Blocs(DiaSetman, 27), Blocs(DiaSetman, 28), Blocs(DiaSetman, 29), Blocs(DiaSetman, 30), Blocs(DiaSetman, 31), Blocs(DiaSetman, 32), Blocs(DiaSetman, 33), Blocs(DiaSetman, 34), Blocs(DiaSetman, 35), Blocs(DiaSetman, 36), Blocs(DiaSetman, 37), Blocs(DiaSetman, 38), Blocs(DiaSetman, 39))
            UpdateDades10_14(DiaSetman + 1, IDFalca, Blocs(DiaSetman, 40), Blocs(DiaSetman, 41), Blocs(DiaSetman, 42), Blocs(DiaSetman, 43), Blocs(DiaSetman, 44), Blocs(DiaSetman, 45), Blocs(DiaSetman, 46), Blocs(DiaSetman, 47), Blocs(DiaSetman, 48), Blocs(DiaSetman, 49), Blocs(DiaSetman, 50), Blocs(DiaSetman, 51), Blocs(DiaSetman, 52), Blocs(DiaSetman, 53), Blocs(DiaSetman, 54), Blocs(DiaSetman, 55), Blocs(DiaSetman, 56), Blocs(DiaSetman, 57), Blocs(DiaSetman, 58), Blocs(DiaSetman, 59))
            UpdateDades15_19(DiaSetman + 1, IDFalca, Blocs(DiaSetman, 60), Blocs(DiaSetman, 61), Blocs(DiaSetman, 62), Blocs(DiaSetman, 63), Blocs(DiaSetman, 64), Blocs(DiaSetman, 65), Blocs(DiaSetman, 66), Blocs(DiaSetman, 67), Blocs(DiaSetman, 68), Blocs(DiaSetman, 69), Blocs(DiaSetman, 70), Blocs(DiaSetman, 71), Blocs(DiaSetman, 72), Blocs(DiaSetman, 73), Blocs(DiaSetman, 74), Blocs(DiaSetman, 75), Blocs(DiaSetman, 76), Blocs(DiaSetman, 77), Blocs(DiaSetman, 78), Blocs(DiaSetman, 79))
            UpdateDades20_23(DiaSetman + 1, IDFalca, Blocs(DiaSetman, 80), Blocs(DiaSetman, 81), Blocs(DiaSetman, 82), Blocs(DiaSetman, 83), Blocs(DiaSetman, 84), Blocs(DiaSetman, 85), Blocs(DiaSetman, 86), Blocs(DiaSetman, 87), Blocs(DiaSetman, 88), Blocs(DiaSetman, 89), Blocs(DiaSetman, 90), Blocs(DiaSetman, 91), Blocs(DiaSetman, 92), Blocs(DiaSetman, 93), Blocs(DiaSetman, 94), Blocs(DiaSetman, 95))
        Next DiaSetman
    End Sub


    Private Sub cmdAssistBlocs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAssistBlocs.Click
        PanelAssistent.Location = New Point((Me.DisplayRectangle.Width - PanelAssistent.Width) / 2, 5)
        PanelAssistent.Visible = True
    End Sub

    Private Sub refreshFrangesHora(ByVal Dia As Integer)
        Dim db As New MSC.dbs(Cloud)
        Dim StrSql As String = "SELECT * FROM frangeshoraries WHERE franID = " & Dia
        Dim rs As DataTable = db.getTable(StrSql)
        For i As Integer = 0 To 23
            Dim NomLabel As String = "label" & (40 + i).ToString
            CType(PanelFrH.Controls(NomLabel), Label).BackColor = Choose(rs.Rows(0)(i) + 1 _
                , Color.Snow, Color.MistyRose, Color.LightSalmon, Color.Salmon, Color.DarkSalmon _
                , Color.Tomato, Color.LightCoral, Color.Coral, Color.OrangeRed, Color.Red)
        Next
        db = Nothing
        rs.Dispose()

    End Sub

    Private Sub lbClient_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbClient.LinkClicked
        Dim FrmChild As New frmMantClients
        Try
            FrmChild.IniTable()
            If ComboClient.SelectedValue > 0 Then FrmChild.establirRecordset(" cli_nom = '" & Me.ComboClient.Text & "'")
            If FrmChild.ShowDialog = DialogResult.OK Then
                Dim Cmb As New combo
                Cmb.OmpleCombo(ComboClient, TAULES_DBS.TAULA_CLIENTS, TotsCap.CAP)
                ComboClient.SelectedValue = FrmChild.ID
            End If
        Catch ex As Exception
        End Try
        FrmChild = Nothing

    End Sub

    Private Sub lbLocutor_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbLocutor.LinkClicked
        Dim FrmChild As New frmMantLocutors
        Try
            FrmChild.IniTable()
            If ComboLocutor.SelectedValue > 0 Then FrmChild.establirRecordset(" locu_nom = '" & Me.ComboLocutor.Text & "'")
            If FrmChild.ShowDialog = DialogResult.OK Then
                Dim Cmb As New combo
                Cmb.OmpleCombo(ComboLocutor, TAULES_DBS.TAULA_LOCUTORS, TotsCap.CAP)
                ComboLocutor.SelectedValue = FrmChild.ID
            End If
        Catch ex As Exception
        End Try
        FrmChild = Nothing
    End Sub

    Private Sub lbTecnic_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbTecnic.LinkClicked
        Dim FrmChild As New frmMantTecnic
        Try
            FrmChild.IniTable()
            If ComboTecnic.SelectedValue > 0 Then FrmChild.establirRecordset(" tecnic_nom = '" & Me.ComboTecnic.Text & "'")
            If FrmChild.ShowDialog = DialogResult.OK Then
                Dim Cmb As New combo
                Cmb.OmpleCombo(ComboTecnic, TAULES_DBS.TAULA_TECNICS, TotsCap.CAP)
                ComboTecnic.SelectedValue = FrmChild.ID
            End If
        Catch ex As Exception
        End Try
        FrmChild = Nothing
    End Sub

    Private Sub cbTarifa_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles cbTarifa.LinkClicked
        Dim FrmChild As New frmMantTarifa
        Try
            FrmChild.IniTable()
            If ComboTarifes.SelectedValue > 0 Then FrmChild.establirRecordset(" tarif_nom = '" & Me.ComboTarifes.Text & "'")
            If FrmChild.ShowDialog = DialogResult.OK Then
                Dim Cmb As New combo
                Cmb.OmpleCombo(ComboTarifes, TAULES_DBS.TAULA_TARIFES, TotsCap.CAP)
                ComboTarifes.SelectedValue = FrmChild.ID
            End If
        Catch ex As Exception
        End Try
        FrmChild = Nothing
    End Sub

    Private Sub lbProducte_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbProducte.LinkClicked
        Dim FrmChild As New frmMantProductes
        Try
            FrmChild.IniTable()
            If ComboProducte.SelectedValue > 0 Then FrmChild.establirRecordset(" produc_nom = '" & Me.ComboProducte.Text & "'")
            If FrmChild.ShowDialog = DialogResult.OK Then
                Dim Cmb As New combo
                Cmb.OmpleCombo(ComboProducte, TAULES_DBS.TAULA_PRODUCTES, TotsCap.CAP)
                ComboProducte.SelectedValue = FrmChild.ID
            End If
        Catch ex As Exception
        End Try
        FrmChild = Nothing
    End Sub

    Private Sub mnuStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuStop.Click
        stopFitxer()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub mnuModif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuModif.Click
        lockedRecord()
    End Sub

    Private Sub mnuSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSave.Click
        SaveRecord()
    End Sub

    Private Sub mnuNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNew.Click
        NewRecord()
    End Sub

    Private Sub mnuDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDel.Click
        DeleteRecord()
    End Sub

    Private Sub mnuBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBuscar.Click
        FindRecord()
    End Sub

    Private Sub mnuRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRefresh.Click
        getListFalques()
    End Sub

    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub

    Private Sub chkActive_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkActive.CheckedChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ColumnActiva").Value = chkActive.Checked
            Changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub chkValida_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkValida.CheckedChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ColumnValida").Value = chkValida.Checked
            Changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub chkFactura_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFactura.CheckedChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ColumnFacturada").Value = chkFactura.Checked
            Changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub chkPropia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPropia.CheckedChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ColumnPropia").Value = chkPropia.Checked
            Changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub gridDades_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridDades.CurrentCellChanged
        ShowValuesID()
    End Sub

    Private Function FindAfectatRow() As Integer
        If blnNouRecord Then
            Return gridDades.NewRowIndex
        Else
            Return gridDades.CurrentRow.Index
        End If
    End Function

    Private Sub txtNom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNom.TextChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ColumnNom").Value = AddSlashes(txtNom.Text)
            Changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ComboClient_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboClient.SelectedIndexChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ComboGridClient").Value = ComboClient.SelectedValue
            Changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ComboProducte_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboProducte.SelectedIndexChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ComboGridProducte").Value = ComboProducte.SelectedValue
            Changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtMarca_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMarca.TextChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ColumnMarca").Value = AddSlashes(txtMarca.Text)
            Changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ComboTarifes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboTarifes.SelectedIndexChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ComboGridTarifa").Value = ComboTarifes.SelectedValue
            Changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtComent_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtComent.TextChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ColumnComent").Value = AddSlashes(txtComent.Text)
            Changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtDataOut_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDataOut.ValueChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ColumnDataOut").Value = txtDataOut.Value
            Changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ComboTecnic_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboTecnic.SelectedIndexChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ComboGridTecnic").Value = ComboTecnic.SelectedValue
            Changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ComboLocutor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboLocutor.SelectedIndexChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells("ComboGridLocutor").Value = ComboLocutor.SelectedValue
            Changed()
        Catch ex As Exception
        End Try
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
            Dim strPathFitxer As String = PathPubli & Me.lbID.Text & ".mp3"
            If Not IO.File.Exists(strPathFitxer) Then MetroFramework.MetroMessageBox.Show(Me, MSG_FILE_NO_EXIST, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Question, 100)
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
		Dim LimePen As New Pen(Color.Lime, 5)
		Dim PeakPen As New Pen(Color.Red, 5)
		Dim PositionPen As New Pen(Color.Black, 1)
		Dim x As Integer
		graph.SmoothingMode = SmoothingMode.AntiAlias
		
		' Pinta Volum dreta i esquerra
		x = (RVol / 32768) * picVuMeter.Width
		If x > picVuMeter.Width Then x = picVuMeter.Width
		graph.DrawLine(LimePen, picVuMeter.Width - x, 4, picVuMeter.Width, 4)
		
		x = (LVol / 32768) * picVuMeter.Width
		If x > picVuMeter.Width Then x = picVuMeter.Width
		graph.DrawLine(LimePen, picVuMeter.Width - x, 8 + 4, picVuMeter.Width, 8 + 4)
		
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
			graph.DrawLine(PeakPen, picVuMeter.Width - x, 4, picVuMeter.Width - x - 2, 4)
			graph.DrawLine(PeakPen, picVuMeter.Width - x, 8 + 4, picVuMeter.Width - x - 2, 8 + 4)
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
	
	Private Sub mnuPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPlay.Click, mnuStop.Click, mnuCalcDurada.Click, mnuFinal.Click
		
		Select Case CType(sender, ToolStripMenuItem).Tag
			Case 1 : PlayFitxer()
			Case 2 : stopFitxer()
			Case 3
				Dim len As Long = Bass.BASS_ChannelGetLength(StreamHandlePlay)
				Me.lbDurada.Text = TimeSerial(0, 0, Bass.BASS_ChannelBytes2Seconds(StreamHandlePlay, len))
				Dim RowID As Integer = FindAfectatRow()
				Me.gridDades.Rows(RowID).Cells(18).Value = lbDurada.Text
				Changed()
			Case 4
				Dim len As Long = Bass.BASS_ChannelGetLength(StreamHandlePlay)
				Dim LenInSeg As Single = Bass.BASS_ChannelBytes2Seconds(StreamHandlePlay, len)
				Bass.BASS_ChannelSetPosition(StreamHandlePlay, CSng(LenInSeg - 20))
		End Select
	End Sub
	
	Private Sub picVuMeter_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picVuMeter.MouseClick
		'estableix la posicio del ratolí a sobre el Pig
		Dim len As Long = Bass.BASS_ChannelGetLength(StreamHandlePlay)
		Dim bpp As Double = len / CType(Me.picVuMeter.Width, Double) ' bytes per pixel        
		'Quin és el pixel on es troba el ratolí
		Dim pr As Integer = 0
		Dim LocalMousePosition As Point = picVuMeter.PointToClient(system.Windows.Forms.Cursor.Position)
		'Posició on s'ha de desplaçar        
		Dim PosADespla As Single = Bass.BASS_ChannelBytes2Seconds(StreamHandlePlay, CLng(LocalMousePosition.X * bpp))
		'Desplaçar-ho
		Bass.BASS_ChannelSetPosition(StreamHandlePlay, PosADespla)
	End Sub
	
	#End Region
	
	Private Sub tmrDetalls_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrDetalls.Tick
		tmrDetalls.Enabled = False
		ConsultaListBlocs()
		If Me.TabControl1.TabIndex = 1 Then actualitzarListBlocs()
		Dim strPathFitxer As String = PathPubli & Me.lbID.Text & ".mp3"
		Me.lbAtencio.Visible = Not IO.File.Exists(strPathFitxer)
	End Sub
	
	Private Sub gridDades_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles gridDades.DataError
		
	End Sub
	
	Private Sub mnuEditAudio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditAudio.Click
		
		Bass.BASS_ChannelStop(StreamHandlePlay)
		Bass.BASS_StreamFree(StreamHandlePlay)
		If ProgEditAudio.Length > 0 Then
			Dim PathFitxer As String = ""
			For i As Integer = 0 To gridDades.SelectedRows.Count - 1
				Dim tempPath As String = PathPubli & gridDades.SelectedRows(i).Cells(0).Value & ".mp3"
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
	
	Private Sub mnu_Help_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_Help.Click
		Dim Proces As Process = New Process
		Try
			Process.Start(MSC.Help.HELP_GEST_PUBLICITAT_FALQUES.ToString)
		Catch ex As Exception
		End Try
	End Sub

    Private Sub frmPubli_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        Dim FitxerINI As New IniFile
        frm_sice(0) = Me.Width : frm_sice(1) = Me.Height
        FitxerINI.INIWrite(MyAPP.IniFile, "Data Gest", "size", frm_sice(0).ToString & "," & frm_sice(1).ToString)
    End Sub

    Private Sub ButtonHideAssist_Click(sender As Object, e As EventArgs) Handles ButtonHideAssist.Click
        Me.PanelAssistent.Visible = False
    End Sub

    Private Sub cmdCalc_Click(sender As Object, e As EventArgs) Handles cmdCalc.Click
        Dim i As Short
        Dim Count As Short
        Dim MaxRadi As Short
        Dim FactorMax As Short
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.AppStarting
        ' inici del càlcul
        Dim NumRadi As Short = Val(Me.txtNumRadi.Text)
        If NumRadi = 0 Then
            MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_NUM_MINIM_RADIA, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
            txtNumRadi.Text = CStr(1)
            'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            Exit Sub
        End If

        For i = 0 To 23
            If Me.lstHoresDisp.GetItemChecked(i) Then MaxRadi = MaxRadi + 4
        Next
        For i = 0 To 6
            If Me.lstDiesDisp.GetItemChecked(i) Then FactorMax = FactorMax + 1
        Next
        MaxRadi = MaxRadi * FactorMax

        If MaxRadi < NumRadi Then
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_NUM_BLOCS, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
            Exit Sub
        End If
        'El nº de dies x nº maxRadiDia > NºRadiacions
        If (FactorMax * Val(Me.txtMaxPubliDia.Text)) < NumRadi Then
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_NUM_DIES, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
            Exit Sub
        End If
        If chkRespect.Checked = False Then
            'Inicialment borrar tots els blocs marcats
            For dia As Short = 0 To 6
                For NBloc As Short = 0 To 95
                    Blocs(dia, NBloc) = False
                Next NBloc
            Next dia
        End If
        ' Inicialitza el generador de nº aelatòris
        Randomize()

        Do
            Dim Dia As Short = Rnd() * 10
            Dim NBloc As Short = Rnd() * 100
            Dim TmpBD As Short

            If Dia > 6 Or NBloc > 95 Then GoTo LineNextAssign
            'El dia està activat??
            If Me.lstDiesDisp.GetItemChecked(Dia) = True Then
                'La hora està activada?
                Dim Hora As Short = NBloc \ 4
                If Me.lstHoresDisp.GetItemChecked(Hora) = True Then
                    'Comprovar si ja tenim el NumMax de pautes per dia
                    TmpBD = 0
                    For b As Short = 0 To 95
                        If Blocs(Dia, b) = True Then TmpBD = TmpBD + 1
                    Next b
                    If Blocs(Dia, NBloc) = False And TmpBD < Val(txtMaxPubliDia.Text) Then
                        Blocs(Dia, NBloc) = True
                        Count = Count + 1
                    End If
                    If Count = NumRadi Then Exit Do
                End If
            End If
LineNextAssign:
        Loop

        ModifBlocs = True
        actualitzarListBlocs()
        Changed()
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        MetroFramework.MetroMessageBox.Show(Me, MSG_PROCESS_END, My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Information, 100)
    End Sub

    Private Sub txtNumRadi_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumRadi.KeyPress, txtMaxPubliDia.KeyPress

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        If KeyAscii < Asc("0") Or KeyAscii > Asc("9") Then If KeyAscii <> 8 Then KeyAscii = 0
        e.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub


    Sub ComboBoxPlantillesPubliSelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBoxPlantillesPubli.SelectedIndexChanged
        If comboBoxPlantillesPubli.SelectedValue > 0 Then
            lbNomPlantilla.Text = comboBoxPlantillesPubli.Text
            Me.buttonExecutaPlantilla.Enabled = True
        Else
            lbNomPlantilla.Text = ""
            Me.buttonExecutaPlantilla.Enabled = False
        End If
        groupBoxEditPlantilla.Enabled = (comboBoxPlantillesPubli.SelectedValue > 0)
    End Sub

    Sub ButtonNovaPlantillaClick(sender As Object, e As EventArgs) Handles buttonNovaPlantilla.Click
        Dim frmTemplates As New frmPlantillesPublicitat
        frmTemplates.ID_TO_EDIT = 0
        frmTemplates.ShowDialog()
        If frmTemplates.DialogResult = System.Windows.Forms.DialogResult.OK Then
            Dim ret_id As Integer = frmTemplates.ID_TO_EDIT
            Dim Cmb As New combo
            Cmb.OmpleCombo(comboBoxPlantillesPubli, TAULES_DBS.TAULA_ADV_TEMPLATES, TotsCap.CAP) : comboBoxPlantillesPubli.SelectedValue = ret_id
            Cmb = Nothing
        End If
        frmTemplates = Nothing
    End Sub

    Sub ButtonEditarPlantillaClick(sender As Object, e As EventArgs) Handles buttonEditarPlantilla.Click
        Dim frmTemplates As New frmPlantillesPublicitat
        frmTemplates.ID_TO_EDIT = comboBoxPlantillesPubli.SelectedValue
        frmTemplates.ShowDialog()
        frmTemplates = Nothing
    End Sub

    Sub ButtonEsborrarPlantillaClick(sender As Object, e As EventArgs) Handles buttonEsborrarPlantilla.Click
        Dim dbs As New MSC.dbs(Cloud)
        Dim StrSql As String = "DELETE FROM adv_templates WHERE template_id= " & comboBoxPlantillesPubli.SelectedValue & ";"
        dbs.Delete_ID(StrSql)
        addCtlRadi(0, CShort(Tipus_Play.CTL_SQL), 0, "00:00:00", 0, 0, Usuari.UsrID, StrSql, 0, False)
        RefreshDataSet(TAULES_DBS.TAULA_ADV_TEMPLATES)
        Dim Cmb As New combo
        Cmb.OmpleCombo(comboBoxPlantillesPubli, TAULES_DBS.TAULA_ADV_TEMPLATES, TotsCap.CAP) : comboBoxPlantillesPubli.SelectedValue = 0
        Cmb = Nothing
        dbs = Nothing
        Me.lbNomPlantilla.Text = ""
    End Sub

    Sub ButtonExecutaPlantillaClick(sender As Object, e As EventArgs) Handles buttonExecutaPlantilla.Click
        If comboBoxPlantillesPubli.SelectedValue = 0 Then
            Exit Sub
        End If
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.AppStarting
        Dim condi As String = "template_id = " & comboBoxPlantillesPubli.SelectedValue
        Dim rows() As DataRow = dsClient.Tables("adv_templates").Select(condi)
        Dim retvalue As String = rows(0)("template_values").ToString

        If Me.chkRespectTemplates.Checked = False Then deleteBlocsOnFrm()
        Dim valorsArray() As String = Split(rows(0)("template_values").ToString, ",")

        For i As Integer = 0 To valorsArray.Length - 1
            Dim dia As Integer = valorsArray(i).Substring(0, 1)
            Dim bloc As Integer = valorsArray(i).Substring(1, 2)
            Blocs(dia, bloc) = True
        Next
        ModifBlocs = True
        actualitzarListBlocs()
        Changed()
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        MetroFramework.MetroMessageBox.Show(Me, MSG_PROCESS_END, My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Information, 100)

    End Sub

    Private Sub deleteBlocsOnFrm()
        For day As Integer = 0 To 6 'Monday is 0
            For n_bloc As Integer = 0 To 95
                Blocs(day, n_bloc) = False
            Next
        Next
    End Sub

    Private Sub chk_DiesAll_CheckedChanged(sender As Object, e As EventArgs) Handles chk_DiesAll.CheckedChanged
        Dim Chk As Boolean = chk_DiesAll.Checked
        For i As Integer = 0 To 6
            Me.lstDiesDisp.SetItemChecked(i, Chk)
        Next i
    End Sub

    Private Sub chk_Hores_all_CheckedChanged(sender As Object, e As EventArgs) Handles chk_Hores_all.CheckedChanged
        Dim chk As Boolean = chk_Hores_all.Checked
        For i As Integer = 0 To 23
            Me.lstHoresDisp.SetItemChecked(i, chk)
        Next i
    End Sub

    Dim MouseIsDown As Boolean = False
    Dim MouseIsDownLoc As Point = Nothing
    Private Sub PanelAssistent_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelAssistent.MouseMove
        If e.Button = MouseButtons.Left Then
            If MouseIsDown = False Then
                MouseIsDown = True
                MouseIsDownLoc = New Point(e.X, e.Y)
            End If
            PanelAssistent.Location = New Point(Me.Location.X + e.X - MouseIsDownLoc.X, PanelAssistent.Location.Y + e.Y - MouseIsDownLoc.Y)
        End If
    End Sub

    Private Sub PanelAssistent_MouseUp(sender As Object, e As MouseEventArgs) Handles PanelAssistent.MouseUp
        MouseIsDown = False
    End Sub

    Private Sub ButtonHideSearch_Click(sender As Object, e As EventArgs) Handles ButtonHideSearch.Click
        PanelSearchPubli.Hide()
    End Sub

    Private Sub ComboClientSearch_TabIndexChanged(sender As Object, e As EventArgs) Handles ComboClientSearch.TabIndexChanged, ComboProducSearch.TabIndexChanged
        Dim index As Integer = CType(sender, ComboBox).FindStringExact(CType(sender, ComboBox).Text())
        If index < 0 Then
            'no existeix el que es busca
        End If
    End Sub

    Private Sub ComboClientSearch_KeyUp(sender As Object, e As KeyEventArgs) Handles ComboClientSearch.KeyUp, ComboProducSearch.KeyUp
        Select Case e.KeyCode
            Case Keys.Left, Keys.Right, Keys.Up, Keys.Down
                Return
        End Select
        Dim MyComboBox As ComboBox = CType(sender, ComboBox)
        Dim Origen As TAULES_DBS

        Select Case MyComboBox.Name
            Case "ComboClientSearch" : Origen = TAULES_DBS.TAULA_CLIENTS
            Case "ComboProducSearch" : Origen = TAULES_DBS.TAULA_PRODUCTES
        End Select
        refreshComboBoxKeyUp(MyComboBox, Origen, TotsCap.TOTS)
    End Sub

    Private Sub ComboClientSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboClientSearch.KeyPress, ComboProducSearch.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click
        Dim StrSql As String = ""
        If Len(Me.txtNomSearch.Text) > 0 Then StrSql = "falc_nom LIKE '%" & Me.txtNomSearch.Text & "%'"
        If CInt(Me.ComboClientSearch.SelectedValue) > 0 Then
            If Len(StrSql) > 0 Then StrSql = StrSql + " AND "
            StrSql = StrSql + "falc_client = " & Me.ComboClientSearch.SelectedValue.ToString
        End If
        If CInt(Me.ComboProducSearch.SelectedValue) > 0 Then
            If Len(StrSql) > 0 Then StrSql = StrSql + " AND "
            StrSql = StrSql + "falc_Producte = " & ComboProducSearch.SelectedValue.ToString
        End If
        If Len(Me.txtMarcaSearch.Text) > 0 Then
            If Len(StrSql) > 0 Then StrSql = StrSql + " AND "
            StrSql = StrSql + "falc_marca LIKE '%" & Me.txtMarcaSearch.Text & "%'"
        End If
        If Me.chkActiveSearch.Checked = True Then
            If Len(StrSql) > 0 Then StrSql = StrSql + " AND "
            StrSql = StrSql + "falc_activa = 1 "
        End If
        If Me.chkValidaSearch.Checked = True Then
            If Len(StrSql) > 0 Then StrSql = StrSql + " AND "
            StrSql = StrSql + "falc_valida = 1 "
        End If
        If Me.chkFacturaSearch.Checked = True Then
            If Len(StrSql) > 0 Then StrSql = StrSql + " AND "
            StrSql = StrSql + "falc_facturada = 1 "
        End If
        If Me.chkPropiaSearch.Checked = True Then
            If Len(StrSql) > 0 Then StrSql = StrSql + " AND "
            StrSql = StrSql + "falc_propia = 1 "
        End If
        If Me.chkActual.Checked = True Then
            If Len(StrSql) > 0 Then StrSql = StrSql + " AND "
            StrSql = StrSql + "falc_activa = 1 AND falc_datain <= '" & Today.ToString("yyyy-MM-dd") & "' AND falc_dataout >= '" & Today.ToString("yyyy-MM-dd") & "'"
        End If
        getListFalques(StrSql)
    End Sub

    Private Sub PanelSearchPubli_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelSearchPubli.MouseMove
        If e.Button = MouseButtons.Left Then
            If MouseIsDown = False Then
                MouseIsDown = True
                MouseIsDownLoc = New Point(e.X, e.Y)
            End If
            PanelSearchPubli.Location = New Point(Me.Location.X + e.X - MouseIsDownLoc.X, PanelSearchPubli.Location.Y + e.Y - MouseIsDownLoc.Y)
        End If
    End Sub

    Private Sub PanelSearchPubli_MouseUp(sender As Object, e As MouseEventArgs) Handles PanelSearchPubli.MouseUp
        MouseIsDown = False
    End Sub
End Class