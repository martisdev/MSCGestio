Option Strict Off
Option Explicit On

Public Class frmMantClients
	Dim Cancelled As Boolean
	Dim blEnable As Boolean
	Dim blnNouRecord As Boolean
	Dim IsSaving As Boolean = False
	
	Const TAULA_ID As TAULES_DBS = TAULES_DBS.TAULA_CLIENTS
	
	
	#Region " Pantalla "
	Private Sub frmMant_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		CloseForm()
	End Sub
	
	Private Sub cmdSortir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSortir.Click
		Me.Close()
	End Sub
	
	Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
		Me.Close()
	End Sub
	
	Private Sub cmdNou_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNou.Click
		NewRecord()
	End Sub
	
	Private Sub NewRecord()
		blnNouRecord = True
		DeSelectAllRowsGrid(gridDades)
		gridDades.AllowUserToAddRows = True
		gridDades.FirstDisplayedScrollingRowIndex = gridDades.NewRowIndex
		Me.gridDades.Rows(gridDades.NewRowIndex).Selected = True
		Me.gridDades.Rows(gridDades.NewRowIndex).Cells(0).Value = 0
		'establir Valors per defecte (automàticament incorporats al datagrid)
		NetejaPantalla()
		
		blEnable = False
		LockedRecord()
		
		Me.lbNou.Visible = True        
		txtNom.Focus()
		
	End Sub
	
	Private Sub NetejaPantalla()
		Me.lbID.Text = 0
		Me.txtNom.Text = ""
		Me.txtNomFisc.Text = ""
		Me.txtNif.Text = ""
		Me.txtDireccio.Text = ""
		Me.txtCiutat.Text = ""
		Me.txtZip.Text = ""
		Me.txtTelf.Text = ""
		Me.txtFax.Text = ""
		Me.txtNomContacte.Text = ""
		Me.txtObserv.Text = ""
		Me.lbDataCrea.Text = Strings.Format(Now, "yyyy-MM-dd HH:mm:ss")
		Me.ComboProducte.SelectedValue = 0
		Me.ComboAgents.SelectedValue = 0
		Me.txtEMail.Text = ""
		Me.chkActvWeb.Checked = False
		Me.txtNickWeb.Text = ""
		Me.txtPswWeb.Text = ""
	End Sub
	
	Private Sub cmdLocked_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBloqueix.Click
		LockedRecord()
	End Sub
	
	Private Sub LockedRecord(Optional ByVal saved As Boolean = False)
		If Me.cmdSalvar.Enabled = True And saved = False Then
            If MetroFramework.MetroMessageBox.Show(Me, MSG_SAVE_DADES, MSG_ATENCIO, MessageBoxButtons.OKCancel, MessageBoxIcon.Information, 100) = DialogResult.OK Then SaveRecord()
        End If
		blEnable = Not blEnable
		If blEnable = False Then blnNouRecord = False
		Me.txtNom.Enabled = blEnable
		'Me.PanelGeneral.Enabled = blEnable
		txtNomFisc.Enabled = blEnable
		txtNif.Enabled = blEnable
		cmdNif.Enabled = blEnable
		txtNomContacte.Enabled = blEnable
		ComboProducte.Enabled = blEnable
		ComboAgents.Enabled = blEnable
		txtObserv.Enabled = blEnable
		
		'Me.PanelLocalitz.Enabled = blEnable
		txtDireccio.Enabled = blEnable
		txtCiutat.Enabled = blEnable
		txtZip.Enabled = blEnable
		txtTelf.Enabled = blEnable
		txtFax.Enabled = blEnable
		txtEMail.Enabled = blEnable
		
		'Me.PanelWeb.Enabled = blEnable
		chkActvWeb.Enabled = blEnable
		txtNickWeb.Enabled = blEnable
		txtPswWeb.Enabled = blEnable
		
		Me.cmdBorrar.Enabled = blEnable
		Me.mnuDel.Enabled = blEnable
		
		Me.lbNou.Visible = False
		If blEnable Then
			Me.cmdBloqueix.Image = Me.picUnLock.Image
		Else
			Me.cmdBloqueix.Image = Me.picLock.Image
			Me.cmdSalvar.Enabled = False
			Me.mnuSave.Enabled = False
		End If
	End Sub
	
	Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
		DeleteRecord()
	End Sub
	
	Private Sub cmdSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalvar.Click
		SaveRecord()
	End Sub
	
	
	Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionBuscar.Click
		FindRecord()
	End Sub
	
	Private Sub FindRecord()
		If txtBuscar.Text.Length = 0 Or txtBuscar.Text = LABEL_BUSCAR & "..." Then Exit Sub
		Dim StrSql As String = Me.txtBuscar.Text
		Dim OpcBusca As Short
		For i As Integer = 0 To OptionBuscar.DropDownItems.Count - 1
			If CType(OptionBuscar.DropDownItems(i), ToolStripMenuItem).Checked = True Then OpcBusca = i : Exit For
		Next i
		If Not IsNumeric(txtBuscar.Text) Then OpcBusca = Buscar.BUSCAR_NOM
		Select Case OpcBusca
			Case Buscar.BUSCAR_ID
				StrSql = "cliID = " & txtBuscar.Text
			Case Buscar.BUSCAR_NOM
				StrSql = "cliNom LIKE '%" & txtBuscar.Text & "%'"
			Case Buscar.BUSCAR_TOTS
				StrSql = "cliNom LIKE '%" & txtBuscar.Text & "%' OR cliID = " & txtBuscar.Text
		End Select
		establirRecordset(StrSql)
	End Sub
	
	Private Sub cmdRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefrescar.Click
		establirRecordset()
	End Sub
	
	Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
		Cancelled = True
	End Sub
	
	Private Sub txtNif_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNif.LostFocus
		If txtNif.Text = "" Then Exit Sub
		Dim NumDNI As String = Strings.Left(Me.txtNif.Text, 8)
		Dim StrLletraNIF As String = ""
		Try
			StrLletraNIF = LletraNif(NumDNI)
		Catch ex As Exception
			
		Finally
            If UCase(Strings.Right(txtNif.Text, 1)) <> StrLletraNIF Then
                MetroFramework.MetroMessageBox.Show(Me, MSG_ERR_DNI_LLETRA, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
                txtNif.Text = ""
                txtNif.Focus()
            End If
        End Try
	End Sub
	
	Private Sub lstRecord_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
		FindRecord()
	End Sub
	
	Private Sub cmdPrimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrimer.Click
		Me.gridDades.Focus()
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

    Private Sub frmMant_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If isChild = False Then IniTable()
        If My.Settings.TXT_CAPITALIZE Then
            Me.txtNom.CharacterCasing = CharacterCasing.Upper
            Me.txtNomFisc.CharacterCasing = CharacterCasing.Upper
            Me.txtNomContacte.CharacterCasing = CharacterCasing.Upper
            Me.txtObserv.CharacterCasing = CharacterCasing.Upper
            Me.txtDireccio.CharacterCasing = CharacterCasing.Upper
            Me.txtCiutat.CharacterCasing = CharacterCasing.Upper
        End If


        If Not frmMain.NoLoadRs Then establirRecordset()

        Dim UserTip As Integer = Usuari.UsrTipus
        'Me.cmdBloqueix.Enabled = IIf(UserTip > NivellUsers.USR_CONVIDAT, True, False)                
        Me.cmdNou.Enabled = IIf(UserTip > NivellUsers.USR_CONVIDAT, True, False)
        mnuNew.Enabled = IIf(UserTip > NivellUsers.USR_CONVIDAT, True, False)

        Me.mnuNew.Visible = Me.cmdNou.Visible
        Me.ClientSize = New Size(frm_sice(0), frm_sice(1))

    End Sub

    Dim isChild As Boolean = False
    Friend Sub IniTable()
        setLanguageForm()
        Dim cmb As New combo
        cmb.OmpleCombo(ComboProducte, TAULES_DBS.TAULA_PRODUCTES, TotsCap.CAP)
        ComboProducte.SelectedValue = 0
        cmb.OmpleCombo(ComboAgents, TAULES_DBS.TAULA_AGENTS_COMERCIALS, TotsCap.CAP)
        ComboAgents.SelectedValue = 0
        isChild = True
    End Sub

    Dim MSG_INPUT_DNI As String
	Dim CAPTION_INPUT_DNI As String
    Dim MSG_INPUT_DNI_LLETRA As String
    Dim MSG_ERR_DNI_LLETRA As String
    Dim MSG_ERROR_INPUT_CLIENT As String
	Dim MSG_ERROR_INPUT_PRODUCTE As String
	
	Public Sub setLanguageForm()
        lang.StrForm = Me.Name

        MSG_INPUT_DNI = lang.getText("MSG_INPUT_DNI") '"Entri el DNI al qual vol trobar la lletra"
        MSG_ERR_DNI_LLETRA = lang.getText("MSG_ERR_DNI_LLETRA") 'El DNI no és correcte
        CAPTION_INPUT_DNI = lang.getText("CAPTION_INPUT_DNI") '"Buscar Lletra del NIF"
        MSG_INPUT_DNI_LLETRA = lang.getText("MSG_INPUT_DNI_LLETRA") '"la lletra del DNI correspon a {0} ."
        MSG_ERROR_INPUT_CLIENT = lang.getText("MSG_ERROR_INPUT_CLIENT") '"El nom del client és obligatori"
        MSG_ERROR_INPUT_PRODUCTE = lang.getText("MSG_ERROR_INPUT_PRODUCTE") '"És obligatori assignar un producte"
        'Me.MenuStrip1.Text = "MenuStrip1"
        Me.ProgarmaToolStripMenuItem.Text = lang.getText("LABEL_PROGRAMA",True) '"Programa"
		Me.mnuExit.Text = lang.getText("LABEL_EXIT",True) '"Sortir"
		Me.EdicióToolStripMenuItem.Text = lang.getText("mnuEdit.Text",True )'"Edició"
		Me.mnuModif.Text = lang.getText("LABEL_MODIFICAR",True )'"Modificar"
		Me.mnuSave.Text = lang.getText("LABEL_SALVAR",True) '"Salvar"
		Me.mnuNew.Text = lang.getText("LABEL_NEW",True) '"Nou"
		Me.mnuDel.Text = lang.getText("LABEL_DELETE",True) '"Borrar"
		Me.mnuRefresh.Text = lang.getText("LABEL_REFRESCAR",True)'"Refrescar"
		Me.ToolStripMenuItem1.Text = lang.getText("mnu_Help",True) '"Ajuda"
		Me.mnu_Help.Text = lang.getText("mnuRefHelp.Text",True) '"Manual OnLine"
		'Me.ToolStrip1.Text = "ToolStrip1"
		Me.cmdPrimer.Text = lang.getText("LABEL_GOTO_FIRSH",True)'"Primer"
		Me.cmdPrevi.Text = lang.getText("LABEL_GOTO_PREV",True)'"Anterior"
		Me.cmdSeguent.Text = lang.getText("LABEL_GOTO_NEXT",True)'"Següent"
		Me.cmdUltim.Text = lang.getText("LABEL_GOTO_LAST",True)'"Últim"
		Me.cmdNou.Text = lang.getText("LABEL_NEW",True) '"Nou"
		Me.cmdBloqueix.Text = lang.getText("LABEL_EDITAR",True) '"Bloquejar"
		Me.cmdBorrar.Text = Lang.getText("LABEL_DELETE",True)'"Borrar"
		Me.cmdSalvar.Text = lang.getText("LABEL_SAVE",True)'"Salvar"
		Me.cmdRefrescar.Text = lang.getText("LABEL_REFRESCAR",True)'"Refrescar"
		Me.OptionBuscar.Text = lang.getText("LABEL_BUSCAR",True)'"Buscar"
		Me.PerIDToolStripMenuItem.Text = lang.getText("mnu_Buscar_ID",True)'"Per ID"
		Me.PerNomToolStripMenuItem.Text = lang.getText("mnu_Buscar_NOM",True)'"Per Nom"
		Me.QualsevolToolStripMenuItem.Text = lang.getText("mnu_Buscar_QUALSEVOL",True)'"Qualsevol"
		Me.cmdSortir.Text = lang.getText("LABEL_EXIT",True) '"Sortir"
		Me.txtBuscar.Text = lang.getText("LABEL_BUSCAR",True)'"Buscar"
		Me.lbNou.Text = lang.getText("LABEL_NEW_UPPER",True) '"NOU"
		Me.Label2.Text = lang.getText("LABEL_NEW",True) '"Nom"
		Me.Label1.Text = lang.getText("LABEL_IDENTIFICADOR",True) & ":" '"Identificador"
		Me.ColumnID.HeaderText = lang.getText("HEADERTEXT_ID",True) '"ID"
		Me.ColumnNom.HeaderText = lang.getText("LABEL_NOM",True) '"Nom"
		Me.DataGridViewTextBoxColumn1.HeaderText = lang.getText("HEADERTEXT_ID",True) '"ID"
		Me.DataGridViewTextBoxColumn2.HeaderText = lang.getText("LABEL_NOM",True) '"Nom"
		'Me.cmdExit.Text = "Button1"
		Me.TabPageGeneral.Text = lang.getText("LABEL_GENERAL",True) '"General"
		Me.Label7.Text = lang.getText("LABEL_DATA_CREACIO",True) '"Data de creació"
		Me.Label3.Text = lang.getText("Label3.Text") '"Nom fiscal"
		Me.Label4.Text = lang.getText("Label4.Text") '"NIF/CIF"
		Me.Label6.Text = lang.getText("LABEL_OBSERVACIONS",True) '"Observacions"
		Me.lbAgent.Text = lang.getText("lbAgent.Text") '"Agent"
		Me.Label5.Text = lang.getText("Label5.Text") '"Persona de contacte"
		Me.lbProducte.Text = lang.getText("LABEL_PRODUCTE",True) '"Producte"
		Me.TabPageLocalitzacio.Text = lang.getText("LABEL_LOCALITZACIO",True) '"Localització"
		Me.Label9.Text = lang.getText("LABEL_ADRECA",True) '"Adreça"
		Me.lbEMail.Text = lang.getText("mnuRefMail.Text",True) '"E-Mail"
		Me.Label10.Text = lang.getText("LABEL_POBLACIO",True) '"Població"
		Me.Label13.Text = lang.getText("LABEL_FAX",True) '"Fax"
		Me.Label11.Text = lang.getText("LABEL_CODI_POSTAL",True) '"Codi Postal"
		Me.Label12.Text = lang.getText("Label12.Text") '"Telèfon"
		Me.TabPageWeb.Text = lang.getText("TabPageWeb.Text") '"Usuari Web"
		Me.Label20.Text = lang.getText("Label20.Text") '"NO emplenar el password si no es vol modificar"
		Me.chkActvWeb.Text = lang.getText("chkActvWeb.Text") '"Usuari web activat"
		Me.Label14.Text = lang.getText("Label14.Text") '"Nom d'usuari"
		Me.Label15.Text = lang.getText("LABEL_CONTRASENYA",True) '"Contrasenya"		
				
		Me.ColumnContact.HeaderText = lang.getText("ColumnContact.HeaderText") '"Contacte"
		Me.ColumnDataCrea.HeaderText = lang.getText("HEADERTEXT_DATE_CREA",True) '"Data Creació"	
				
		'Me.ColumnNFisc.HeaderText = lang.getText("LABEL_NOM") '"Nom Fiscal"
		'Me.ColumnNIF.HeaderText = lang.getText("HEADERTEXT_NAME") '"NIF"
		'Me.ColumnProducte.HeaderText = lang.getText("HEADERTEXT_NAME") '"Producte"
		'Me.ColumnAgent.HeaderText = lang.getText("HEADERTEXT_NAME") '"Agent"
		'Me.ColumnObserv.HeaderText = lang.getText("HEADERTEXT_NAME") '"Observ"
		
		'Me.ColumnAdreca.HeaderText = lang.getText("HEADERTEXT_NAME") '"Adreça"
		'Me.ColumnPoblacio.HeaderText = lang.getText("HEADERTEXT_NAME") '"Població"
		'Me.ColumnCP.HeaderText = lang.getText("HEADERTEXT_NAME") '"C.P."
		'Me.ColumnTelf.HeaderText = lang.getText("HEADERTEXT_NAME") '"Telf"
		'Me.ColumnFax.HeaderText = lang.getText("HEADERTEXT_NAME") '"Fax"
		'Me.ColumnMail.HeaderText = lang.getText("HEADERTEXT_NAME") '"E-mail"
		'Me.ColumnActiveWeb.HeaderText = lang.getText("HEADERTEXT_NAME") '"Web actiu"
		'Me.ColumnNick.HeaderText = lang.getText("HEADERTEXT_NAME") '"nick"
		
		Me.TabPage1.Text = lang.getText("TabPage1.Text") '"LListat Clients"
		Me.TabPage2.Text = lang.getText("TabPage2.Text") '"Anuncis del client"
		
		Me.Text = lang.getText("Text") '"Manteniment dels Clients"
		
		
	End Sub

#End Region

#Region " VarTables "
    'Seccio variable segons taula-----------------------------------------

    Public Sub establirRecordset(Optional ByVal Condi As String = "")
        system.Windows.Forms.Cursor.Current = Cursors.AppStarting

        Dim StrSql As String = "SELECT cli_id, cli_nom,cli_nomfiscal,cli_cifdni,cli_contacte" &
            ",cli_producte,cli_agent,cli_observ,cli_datacreacio,cli_direccio" &
            ",cli_ciutat,cli_zip,cli_telf,cli_fax,cli_email,cli_webactv,cli_webnick " &
            "FROM clients"
        If Condi.Length > 0 Then StrSql = StrSql & " WHERE " & Condi
        Dim db As New MSC.dbs(Cloud)
        gridDades.DataSource = db.getTable(StrSql)
        db = Nothing
        If gridDades.Rows.Count = 0 Then MetroFramework.MetroMessageBox.Show(Me, MSG_NO_ITEM_FOR_CONDITION, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, 100)
        Me.lbRecCount.Text = gridDades.Rows.Count
        gridDades.Focus()
        cmdBloqueix.Enabled = IIf(gridDades.Rows.Count And Usuari.UsrTipus > NivellUsers.USR_CONVIDAT, True, False)
        Me.mnuModif.Enabled = Me.cmdBloqueix.Enabled

        system.Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

    Friend ID As Integer
    Private Sub SaveRecord()
        If Not MyAPP.PermisPerContinuar() Then MetroFramework.MetroMessageBox.Show(Me, MSG_SERVER_CLOSE, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Stop, 100) : Me.Close()
        If MetroFramework.MetroMessageBox.Show(Me, MSG_CONFIRM_SAVE_DADES, MSG_ATENCIO, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, 100) = DialogResult.Cancel Then Exit Sub
        If Me.txtNom.TextLength = 0 Then
            MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_INPUT_CLIENT, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
            txtNom.Focus()
            Exit Sub
        ElseIf Me.ComboProducte.SelectedValue = 0 Then
            MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_INPUT_PRODUCTE, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
            ComboProducte.Focus()
			Exit Sub
		End If
		IsSaving = True
		Dim Nom As String = AddSlashes(Me.txtNom.Text)
		Dim NomFisc As String = AddSlashes(Me.txtNomFisc.Text)
		Dim NIF As String = AddSlashes(Me.txtNif.Text)
		Dim Direccio As String = AddSlashes(Me.txtDireccio.Text)
		Dim Ciutat As String = AddSlashes(Me.txtCiutat.Text)
		Dim Zip As String = IIf(Me.txtZip.TextLength = 0, "0", txtZip.Text.ToString)
		Dim Telf As String = AddSlashes(Me.txtTelf.Text)
		Dim Fax As String = AddSlashes(Me.txtFax.Text)
		Dim Contacte As String = AddSlashes(Me.txtNomContacte.Text)
		Dim Observ As String = AddSlashes(Me.txtObserv.Text)
		Dim EMail As String = AddSlashes(Me.txtEMail.Text)
		Dim Producte As Short = Me.ComboProducte.SelectedValue
		Dim IdAgent As Short = Me.ComboAgents.SelectedValue
		Dim WebActv As Boolean = chkActvWeb.Checked
		Dim WebNick As String = AddSlashes(Me.txtNickWeb.Text)
		Dim WebPsw As String = Me.txtPswWeb.Text
        Dim db As New MSC.dbs(Cloud)
        Dim StrSql As String = ""
        ID = lbID.Text
        If blnNouRecord Then
			StrSql = "INSERT INTO clients (cli_nom, cli_nomfiscal, cli_cifdni, cli_direccio"
			StrSql = StrSql & " , cli_ciutat, cli_zip, cli_telf, cli_fax, cli_contacte, cli_observ,cli_producte"
			StrSql = StrSql & ", cli_email, cli_forminf, cli_agent, cli_datacreacio, cli_webactv, cli_webnick"
			If WebPsw.Length > 0 Then StrSql = StrSql & ", cli_webpsw"
			StrSql = StrSql & ") "
			StrSql = StrSql & " VALUES "
			StrSql = StrSql & " ( '" & Nom & "'"
			StrSql = StrSql & ", '" & NomFisc & "'"
			StrSql = StrSql & ", '" & NIF & "'"
			StrSql = StrSql & ", '" & Direccio & "'"
			StrSql = StrSql & ", '" & Ciutat & "'"
			StrSql = StrSql & ", '" & Zip & "'"
			StrSql = StrSql & ", '" & Telf & "'"
			StrSql = StrSql & ", '" & Fax & "'"
			StrSql = StrSql & ", '" & Contacte & "'"
			StrSql = StrSql & ", '" & Observ & "'"
			StrSql = StrSql & ", " & Producte
			StrSql = StrSql & ", '" & EMail & "'"
			StrSql = StrSql & ", " & 0
			StrSql = StrSql & ", " & IdAgent
			StrSql = StrSql & ", '" & Now.ToString("yyyy-MM-dd HH:mm:ss") & "'"
			StrSql = StrSql & ", " & CShort(IIf(WebActv, 1, 0))
			StrSql = StrSql & ", '" & WebNick & "'"
            If WebPsw.Length > 0 Then StrSql = StrSql & ", HEX(AES_ENCRYPT('" & WebPsw & "','" & MY_SECRET_KEY_TO_ENCRYPT & "'))"

            StrSql = StrSql & ");"
			
			ID = db.New_ID(StrSql)
			
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
			StrSql = "UPDATE clients"
			StrSql = StrSql & " SET "
			StrSql = StrSql & " cli_nom = '" & Nom & "'"
			StrSql = StrSql & ", cli_nomfiscal = '" & NomFisc & "'"
			StrSql = StrSql & ", cli_cifdni = '" & NIF & "'"
			StrSql = StrSql & ", cli_direccio = '" & Direccio & "'"
			StrSql = StrSql & ", cli_ciutat = '" & Ciutat & "'"
			StrSql = StrSql & ", cli_zip = '" & Zip & "'"
			StrSql = StrSql & ", cli_telf = '" & Telf & "'"
			StrSql = StrSql & ", cli_fax = '" & Fax & "'"
			
			StrSql = StrSql & ", cli_contacte = '" & Contacte & "'"
			StrSql = StrSql & ", cli_observ = '" & Observ & "'"
			StrSql = StrSql & ", cli_producte = " & Producte
			StrSql = StrSql & ", cli_email = '" & EMail & "'"
			StrSql = StrSql & ", cli_forminf = " & 0
			StrSql = StrSql & ", cli_agent = " & IdAgent
			
			StrSql = StrSql & ", cli_webactv = " & CShort(IIf(WebActv, 1, 0))
			StrSql = StrSql & ", cli_webnick = '" & WebNick & "'"
            If WebPsw.Length > 0 Then StrSql = StrSql & ", cli_webpsw = HEX(AES_ENCRYPT('" & WebPsw & "','" & MY_SECRET_KEY_TO_ENCRYPT & "'))"

            StrSql = StrSql & " WHERE cli_id = " & ID & " ;"
			db.Update_ID(StrSql)
		End If
        RefreshDataSet(TAULA_ID)
        Me.DialogResult = DialogResult.OK

        db = Nothing
		IsSaving = False
		LockedRecord(True)
		blnNouRecord = False
		Me.gridDades.Focus()
	End Sub
	
	Private Sub DeleteRecord()
		If blnNouRecord = True Then 
			LockedRecord(True)
			NetejaPantalla()
			gridDades.AllowUserToAddRows = False
			Exit Sub
		End If

        If MetroFramework.MetroMessageBox.Show(Me, String.Format(MSG_CONFIRM_DELETE_NUM_DADES, gridDades.SelectedRows.Count), MSG_ATENCIO, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, 100) = DialogResult.Cancel Then Exit Sub

        Dim db As New MSC.dbs(Cloud)
        For i As Short = 0 To Me.gridDades.SelectedRows.Count - 1
			Dim ID As Integer = gridDades.SelectedRows(i).Cells(0).Value
            'Buscar dependènes
            If buscarDependencies(TAULA_ID, ID, Me) = True Then Exit Sub
            Dim StrSql As String = "DELETE FROM clients WHERE cli_id = " & ID

            db.Delete_ID(StrSql)
            addCtlRadi(0, CShort(Tipus_Play.CTL_SQL), 0, "00:00:00", 0, 0, Usuari.UsrID, StrSql, 0, False)
        Next
		For Each selectedrow As DataGridViewRow In gridDades.SelectedRows
			gridDades.Rows.Remove(selectedrow)
		Next
		db = Nothing			
		
		RefreshDataSet(TAULA_ID)
		If IsLoadForm("frmPubli") Then
			Dim MyCombo As ComboBox = frmPubli.ComboClient
			Dim comboGrid As DataGridViewComboBoxColumn = frmPubli.ComboGridClient
			Dim cmb As New combo
			cmb.OmpleCombo(MyCombo, TAULA_ID, TotsCap.CAP)
			cmb.OmpleCombo(comboGrid, TAULA_ID, TotsCap.CAP)
		End If
	End Sub
	
	Private Sub CloseForm()
		If Me.cmdSalvar.Enabled Then
            If MetroFramework.MetroMessageBox.Show(Me, MSG_SAVE_DADES, MSG_ATENCIO, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, 100) = DialogResult.OK Then SaveRecord()
        End If
        MyAPP.CloseSesionClient(MyAPP.IDSesion_Client, DESCRIP_FORM_CLIENTS)
    End Sub
	
	#End Region
	
	Private Sub txtZip_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtZip.KeyPress, txtTelf.KeyPress, txtFax.KeyPress
		Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
		If KeyAscii < Asc("0") Or KeyAscii > Asc("9") Then If KeyAscii <> 8 Then KeyAscii = 0
		e.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			e.Handled = True
		End If
		
	End Sub
	
	Private Sub lbEMail_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbEMail.LinkClicked
		If Len(txtEMail.Text) > 0 Then
			Dim Proces As Process = New Process
			
			Dim sParams As String = "mailto:" & txtEMail.Text & _
				"?subject=" & Params.NomRadio
			'sParams = sParams & "body=" '& Body
			
			Try
				Process.Start(sParams)
			Catch
			End Try
		End If
	End Sub
	
	Private Sub Changed()
		If blEnable = True Then Me.cmdSalvar.Enabled = True : mnuSave.Enabled = True
	End Sub
	
	Private Sub ComboProducte_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboProducte.KeyPress, ComboAgents.KeyPress
		e.KeyChar = UCase(e.KeyChar)
	End Sub
	
	Private Sub ComboProducte_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboProducte.TextChanged, ComboAgents.TextChanged
		Changed()
	End Sub
	
	Private Sub cmdNif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNif.Click
		Dim NumDNI As String
		On Error Resume Next
		NumDNI = InputBox(MSG_INPUT_DNI,CAPTION_INPUT_DNI )
        If Len(NumDNI) = 0 Then Exit Sub
        MetroFramework.MetroMessageBox.Show(Me, String.Format(MSG_INPUT_DNI_LLETRA, LletraNif(NumDNI)), My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Information, 100)
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
	
	Private Sub lbAgent_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbAgent.LinkClicked
        Dim FrmChild As New frmMantComercial
        Try
            FrmChild.IniTable()
            If ComboAgents.SelectedValue > 0 Then FrmChild.establirRecordset(" agent_nom = '" & Me.ComboAgents.Text & "'")
            If FrmChild.ShowDialog = DialogResult.OK Then
                Dim Cmb As New combo
                Cmb.OmpleCombo(ComboAgents, TAULES_DBS.TAULA_AGENTS_COMERCIALS, TotsCap.CAP)
                ComboAgents.SelectedValue = FrmChild.ID
            End If
        Catch ex As Exception
        End Try
        FrmChild = Nothing

    End Sub
	
	Private Sub mnuModif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuModif.Click
		LockedRecord()
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
	
	Private Sub mnuRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRefresh.Click
		establirRecordset()
	End Sub
	
	Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
		Me.Close()
	End Sub
	
	Private Sub chkActvWeb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkActvWeb.CheckedChanged
		Try
			Dim RowID As Integer = FindAfectatRow()
			Me.gridDades.Rows(RowID).Cells("ColumnActiveWeb").Value = chkActvWeb.Checked
			Changed()
		Catch ex As Exception
		End Try
	End Sub
	
	Private Sub gridDades_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridDades.CurrentCellChanged
		If IsSaving = True Then Exit Sub
		Try
			If blEnable = True Then LockedRecord()
			Me.lbID.Text = gridDades.CurrentRow.Cells(0).Value
			Me.txtNom.Text = StripSlashes(gridDades.CurrentRow.Cells(1).Value)
			Me.txtNomFisc.Text = StripSlashes(gridDades.CurrentRow.Cells(2).Value)
			Me.txtNif.Text = StripSlashes(gridDades.CurrentRow.Cells(3).Value)
			Me.txtNomContacte.Text = StripSlashes(gridDades.CurrentRow.Cells(4).Value)
			Me.ComboProducte.SelectedValue = gridDades.CurrentRow.Cells(5).Value
			Me.ComboAgents.SelectedValue = gridDades.CurrentRow.Cells(6).Value
			Me.txtObserv.Text = StripSlashes(gridDades.CurrentRow.Cells(7).Value)
			Me.lbDataCrea.Text = CDate(gridDades.CurrentRow.Cells(8).Value).ToString("yyyy-MM-dd HH:mm:ss")
			
			Me.txtDireccio.Text = StripSlashes(gridDades.CurrentRow.Cells(9).Value)
			Me.txtCiutat.Text = StripSlashes(gridDades.CurrentRow.Cells(10).Value)
			Me.txtZip.Text = gridDades.CurrentRow.Cells(11).Value
			Me.txtTelf.Text = StripSlashes(gridDades.CurrentRow.Cells(12).Value)
			Me.txtFax.Text = StripSlashes(gridDades.CurrentRow.Cells(13).Value)
			Me.txtEMail.Text = StripSlashes(gridDades.CurrentRow.Cells(14).Value)
			
			Me.chkActvWeb.Checked = CBool(gridDades.CurrentRow.Cells(15).Value)
			Me.txtNickWeb.Text = StripSlashes(gridDades.CurrentRow.Cells(16).Value)
			
			
			Me.lbPosition.Text = Me.gridDades.CurrentRow.Index + 1
			Me.cmdSalvar.Enabled = False
		Catch ex As Exception
			
		End Try
	End Sub
	
	Private Sub txtBuscar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.GotFocus
		txtBuscar.Text = ""
	End Sub
	
	Private Sub txtBuscar_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuscar.KeyUp
		If e.KeyCode = Keys.Enter Then FindRecord()
	End Sub
	
	Private Sub ToolStripTextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.LostFocus
		FindRecord()
	End Sub
	
	Private Sub PerNomToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PerNomToolStripMenuItem.Click
		For i As Integer = 0 To OptionBuscar.DropDownItems.Count - 1
			CType(OptionBuscar.DropDownItems(i), ToolStripMenuItem).Checked = False
		Next
		CType(sender, ToolStripMenuItem).Checked = True
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
			Me.gridDades.Rows(RowID).Cells("ColumnNom").Value = txtNom.Text
			Changed()
		Catch ex As Exception
		End Try
	End Sub
	
	Private Sub txtNomFisc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNomFisc.TextChanged
		Try
			Dim RowID As Integer = FindAfectatRow()
			Me.gridDades.Rows(RowID).Cells("ColumnNFisc").Value = txtNomFisc.Text
			Changed()
		Catch ex As Exception
		End Try
	End Sub
	
	Private Sub txtNif_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNif.TextChanged
		Try
			Dim RowID As Integer = FindAfectatRow()
			Me.gridDades.Rows(RowID).Cells("ColumnNIF").Value = txtNif.Text
			Changed()
		Catch ex As Exception
		End Try
	End Sub
	
	Private Sub txtNomContacte_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNomContacte.TextChanged
		Try
			Dim RowID As Integer = FindAfectatRow()
			Me.gridDades.Rows(RowID).Cells("ColumnContact").Value = txtNomContacte.Text
			Changed()
		Catch ex As Exception
		End Try
	End Sub
	
	Private Sub ComboProducte_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboProducte.SelectedIndexChanged
		Try
			Dim RowID As Integer = FindAfectatRow()
			Me.gridDades.Rows(RowID).Cells("ColumnProducte").Value = ComboProducte.SelectedValue
			Changed()
		Catch ex As Exception
		End Try
	End Sub
	
	Private Sub ComboAgents_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboAgents.SelectedIndexChanged
		Try
			Dim RowID As Integer = FindAfectatRow()
			Me.gridDades.Rows(RowID).Cells("ColumnAgent").Value = ComboAgents.SelectedValue
			Changed()
		Catch ex As Exception
		End Try
	End Sub
	
	Private Sub txtObserv_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtObserv.TextChanged
		Try
			Dim RowID As Integer = FindAfectatRow()
			Me.gridDades.Rows(RowID).Cells("ColumnObserv").Value = txtObserv.Text
			Changed()
		Catch ex As Exception
		End Try
	End Sub
	
	Private Sub txtDireccio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDireccio.TextChanged
		Try
			Dim RowID As Integer = FindAfectatRow()
			Me.gridDades.Rows(RowID).Cells("ColumnAdreca").Value = txtDireccio.Text
			Changed()
		Catch ex As Exception
		End Try
	End Sub
	
	Private Sub txtCiutat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCiutat.TextChanged
		Try
			Dim RowID As Integer = FindAfectatRow()
			Me.gridDades.Rows(RowID).Cells("ColumnPoblacio").Value = txtCiutat.Text
			Changed()
		Catch ex As Exception
		End Try
	End Sub
	
	Private Sub txtZip_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtZip.TextChanged
		Try
			Dim RowID As Integer = FindAfectatRow()
			Me.gridDades.Rows(RowID).Cells("ColumnCP").Value = txtZip.Text
			Changed()
		Catch ex As Exception
		End Try
	End Sub
	
	Private Sub txtTelf_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTelf.TextChanged
		Try
			Dim RowID As Integer = FindAfectatRow()
			Me.gridDades.Rows(RowID).Cells("ColumnTelf").Value = txtTelf.Text
			Changed()
		Catch ex As Exception
		End Try
	End Sub
	
	Private Sub txtFax_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFax.TextChanged
		Try
			Dim RowID As Integer = FindAfectatRow()
			Me.gridDades.Rows(RowID).Cells("ColumnFax").Value = txtFax.Text
			Changed()
		Catch ex As Exception
		End Try
	End Sub
	
	Private Sub txtEMail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEMail.TextChanged
		Try
			Dim RowID As Integer = FindAfectatRow()
			Me.gridDades.Rows(RowID).Cells("ColumnMail").Value = txtEMail.Text
			Changed()
		Catch ex As Exception
		End Try
	End Sub
	
	Private Sub txtNickWeb_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNickWeb.TextChanged
		Try
			Dim RowID As Integer = FindAfectatRow()
			Me.gridDades.Rows(RowID).Cells("ColumnNick").Value = txtNickWeb.Text
			Changed()
		Catch ex As Exception
		End Try
	End Sub
	
	Private Sub txtPswWeb_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPswWeb.TextChanged
		Try
			'Dim RowID As Integer = FindAfectatRow()
			'Me.gridDades.Rows(RowID).Cells("ColumnPasword").Value = txtPswWeb.Text
			Changed()
		Catch ex As Exception
		End Try
	End Sub
	
	Private Sub TabControlMesInfo_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TabControlMesInfo.MouseUp
		If TabControlMesInfo.SelectedIndex = 1 Then
            Dim db As New MSC.dbs(Cloud)
            Dim StrSql As String = "SELECT falc_id, falc_nom FROM `falques` where falc_client =" & Me.lbID.Text
			Dim dt As DataTable = db.getTable(StrSql)
			Me.DataGridViewAnuncis.DataSource = dt : DataGridViewAnuncis.Columns(1).HeaderText = Me.ColumnNom.HeaderText & " ( " & dt.Rows.Count  & " " & LABEL_REGISTRES & ")"			
		End If
	End Sub
	
	Private Sub Combo_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboProducte.KeyUp, ComboAgents.KeyUp
		Select Case e.KeyCode
			Case Keys.Left, Keys.Right, Keys.Up, Keys.Down
				Return
		End Select
		Dim MyComboBox As ComboBox = CType(sender, ComboBox)
		Dim Origen As TAULES_DBS
		
		Select Case MyComboBox.Name
			Case "ComboProducte" : Origen = TAULES_DBS.TAULA_PRODUCTES
			Case "ComboAgents" : Origen = TAULES_DBS.TAULA_AGENTS_COMERCIALS
		End Select
		refreshComboBoxKeyUp(MyComboBox, Origen, TotsCap.CAP)
		
	End Sub
	
	Private Sub Combo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles _
		ComboProducte.LostFocus, ComboAgents.LostFocus
		Dim MyComboBox As ComboBox = CType(sender, ComboBox)
		Dim ID As Integer = MyComboBox.SelectedValue
		Dim Origen As TAULES_DBS
		Select Case MyComboBox.Name
			Case "ComboProducte" : Origen = TAULES_DBS.TAULA_PRODUCTES
			Case "ComboAgents" : Origen = TAULES_DBS.TAULA_AGENTS_COMERCIALS
		End Select
		Dim Cmb As New combo
		Cmb.OmpleCombo(MyComboBox, Origen, TotsCap.CAP)
		MyComboBox.SelectedValue = ID
	End Sub
	
	Private Sub lbDataCrea_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbDataCrea.TextChanged
		Try
			Dim RowID As Integer = FindAfectatRow()
			Me.gridDades.Rows(RowID).Cells("ColumnDataCrea").Value = lbDataCrea.Text
			Changed()
		Catch ex As Exception
		End Try
	End Sub
	
	Private Sub mnu_Help_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_Help.Click
		Dim Proces As Process = New Process
		Try
			Process.Start(MSC.Help.HELP_GEST_PUBLICITAT_CLIENTS.ToString)
		Catch ex As Exception
		End Try
	End Sub

    Private Sub frmMantClients_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        Dim FitxerINI As New IniFile
        frm_sice(0) = Me.Width : frm_sice(1) = Me.Height
        FitxerINI.INIWrite(MyAPP.IniFile, "Data Gest", "size", frm_sice(0).ToString & "," & frm_sice(1).ToString)
    End Sub
End Class