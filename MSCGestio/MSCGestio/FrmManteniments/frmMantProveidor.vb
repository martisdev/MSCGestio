Option Strict Off
Option Explicit On

Public Class frmMantProveidor    
	Dim blEnable As Boolean
	Dim blnNouRecord As Boolean
	Dim IsSaving As Boolean = False
	
	Const TAULA_ID As TAULES_DBS = TAULES_DBS.TAULA_PROVEIDORS
	Dim COLUMN_ID As String = ""
	Dim COLUMN_NOM As String = ""
	Dim TAULA_NOM As String = ""
	
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
		Me.txtNom.Text = ""
		Me.txtCiutat.Text = ""
		Me.txtComent.Text = ""
		Me.txtCP.Text = ""
		Me.txtDireccio.Text = ""
		Me.txtEMail.Text = ""
		Me.txtFax.Text = ""
		Me.txtMobil.Text = ""
		Me.txtProvincia.Text = ""
		Me.txtTelf.Text = ""
		Me.lbID.Text = 0
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
		'Me.PanelAdreca.Enabled = blEnable
		txtDireccio.Enabled = blEnable
		txtCiutat.Enabled = blEnable
		txtCP.Enabled = blEnable
		txtProvincia.Enabled = blEnable
		
		'Me.PanelTelf.Enabled = blEnable
		txtTelf.Enabled = blEnable
		txtMobil.Enabled = blEnable
		txtFax.Enabled = blEnable
		txtEMail.Enabled = blEnable
		
		Me.txtComent.Enabled = blEnable
		Me.txtNom.Enabled = blEnable
		Me.cmdBorrar.Enabled = blEnable
		Me.lbNou.Visible = False
		If blEnable Then
			Me.cmdBloqueix.Image = Me.picUnLock.Image
		Else
			Me.cmdBloqueix.Image = Me.picLock.Image
			Me.cmdSalvar.Enabled = False
		End If
	End Sub
	
	Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
		DeleteRecord()
	End Sub
	
	Private Sub cmdSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalvar.Click
		SaveRecord()
	End Sub
	
	Private Sub OpcionsBuscar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PerIDToolStripMenuItem.Click, PerNomToolStripMenuItem.Click, QualsevolToolStripMenuItem.Click
		For i As Integer = 0 To OptionBuscar.DropDownItems.Count - 1
			CType(OptionBuscar.DropDownItems(i), ToolStripMenuItem).Checked = False
		Next
		CType(sender, ToolStripMenuItem).Checked = True
	End Sub
	
	
	Private Sub FindRecord()
		If txtBuscar.Text.Length = 0 Or txtBuscar.Text = "Buscar..." Then Exit Sub
		Dim StrSql As String = Me.txtBuscar.Text
		Dim OpcBusca As Short
		For i As Integer = 0 To OptionBuscar.DropDownItems.Count - 1
			If CType(OptionBuscar.DropDownItems(i), ToolStripMenuItem).Checked = True Then OpcBusca = i : Exit For
		Next i
		If Not IsNumeric(txtBuscar.Text) Then OpcBusca = Buscar.BUSCAR_NOM
		Select Case OpcBusca
			Case Buscar.BUSCAR_ID
				StrSql = COLUMN_ID & " = " & txtBuscar.Text
			Case Buscar.BUSCAR_NOM
				StrSql = COLUMN_NOM & " LIKE '%" & txtBuscar.Text & "%'"
			Case Buscar.BUSCAR_TOTS
				StrSql = COLUMN_NOM & " LIKE '%" & txtBuscar.Text & "%' OR " & COLUMN_ID & " = " & txtBuscar.Text
		End Select
		
		establirRecordset(StrSql)
	End Sub
	
	Private Sub cmdRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefrescar.Click
		establirRecordset()
	End Sub
	
	
	Private Sub txtCP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCP.KeyPress, txtFax.KeyPress, txtTelf.KeyPress, txtMobil.KeyPress
		Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
		'If KeyAscii < Asc("0") Or KeyAscii > Asc("9") Then If KeyAscii <> 8 Then KeyAscii = 0
		e.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			e.Handled = True
		End If
	End Sub
	
	Private Sub lstRecord_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
		FindRecord()
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
	
	Private Sub frmMant_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        IniTable()
        If My.Settings.TXT_CAPITALIZE Then
			Me.txtNom.CharacterCasing = CharacterCasing.Upper
			Me.txtDireccio.CharacterCasing = CharacterCasing.Upper
			Me.txtCiutat.CharacterCasing = CharacterCasing.Upper
			Me.txtProvincia.CharacterCasing = CharacterCasing.Upper
		End If

        If Not frmMain.NoLoadRs Then establirRecordset()
        'Me.cmdBloqueix.Enabled = IIf(Usuari.UsrTipus > NivellUsers.USR_CONVIDAT, True, False)
        Me.cmdNou.Visible = IIf(Usuari.UsrTipus > NivellUsers.USR_CONVIDAT, True, False)
        Me.mnuNew.Visible = Me.cmdNou.Visible
    End Sub

    Friend Sub IniTable()
        getVarTables(TAULA_ID, TAULA_NOM, COLUMN_ID, COLUMN_NOM)
        setLanguageForm()
    End Sub

    Public Sub setLanguageForm()
		lang.StrForm = Me.Name
		
		Me.ColumnID.HeaderText = lang.getText("HEADERTEXT_ID",True) '"ID"
		Me.ColumnNom.HeaderText = lang.getText("LABEL_NOM",True) '"Nom"
		Me.PerNomToolStripMenuItem.Text = lang.getText("mnu_Buscar_NOM",True)'"Per Nom"
		Me.PerIDToolStripMenuItem.Text = lang.getText("mnu_Buscar_ID",True)'"Per ID"
		Me.QualsevolToolStripMenuItem.Text = lang.getText("mnu_Buscar_QUALSEVOL",True)'"Qualsevol"
		Me.OptionBuscar.Text = lang.getText("LABEL_BUSCAR",True)'"Buscar"
		Me.OptionBuscar.ToolTipText = lang.getText("mnu_Buscar_ToolTipText",True)'"Opcions de recerca"
		
		Me.lbNou.Text = lang.getText("LABEL_NEW_UPPER",True) '"NOU"
		Me.Label2.Text = lang.getText("LABEL_NOM",True) & ":" '"Nom:"
		Me.Label1.Text = lang.getText("LABEL_IDENTIFICADOR",True) & ":" '"Identificador:"
		
		Me.txtBuscar.Text = lang.getText("LABEL_BUSCAR",True) & ".." '"Buscar.."		
		Me.cmdPrimer.Text = lang.getText("LABEL_GOTO_FIRSH",True)'"Primer"
		Me.cmdPrevi.Text = lang.getText("LABEL_GOTO_PREV",True)'"Anterior"
		Me.cmdSeguent.Text = lang.getText("LABEL_GOTO_NEXT",True)'"Següent"
		Me.cmdUltim.Text = lang.getText("LABEL_GOTO_LAST",True)'"Últim"
		Me.cmdNou.Text = lang.getText("LABEL_NEW",True) '"Nou"
		Me.cmdBloqueix.Text = lang.getText("LABEL_EDITAR",True) '"Editar"
		Me.cmdBorrar.Text = lang.getText("LABEL_DELETE",True) '"Borrar"
		Me.cmdSalvar.Text = lang.getText("LABEL_SAVE",True)'"Salvar"
		Me.cmdRefrescar.Text = Lang.getText("LABEL_REFRESCAR",True)'"Refrescar"
		Me.cmdSortir.Text = lang.getText("LABEL_EXIT",True) '"Sortir"
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
		
		Me.Label10.Text = lang.getText("LABEL_COMMENT",True) '"Comentari"
		Me.TabPage1.Text = lang.getText("LABEL_ADRECA",True) '"Adreça"
		Me.Label6.Text = lang.getText("Label6.Text") '"Provincia"
		Me.Label5.Text = lang.getText("LABEL_CODI_POSTAL",True) '"Codi Postal"
		Me.Label3.Text = lang.getText("LABEL_ADRECA",True) '"Adreça"
		Me.Label4.Text = lang.getText("LABEL_POBLACIO",True) '"Població"
		Me.TabPage2.Text = lang.getText("TabPage2.Text") '"Telèfons"
		Me.lbEMail.Text = lang.getText("mnuRefMail.Text",True) '"E-Mail"
		Me.Label7.Text = lang.getText("Label7.Text") '"Telèfon fix"
		Me.Label8.Text = lang.getText("Label8.Text") '"Telèfon Mòbil"
		Me.Label9.Text = lang.getText("LABEL_FAX",True) '"Fax"
		
		'Me.ColumnAdreca.HeaderText = "Direcció"
		'Me.ColumnPoblacio.HeaderText = "Ciutat"
		'Me.ColumnProvincia.HeaderText = "Provincia"
		'Me.ColumnCP.HeaderText = "C.P."
		'Me.ColumnTelf.HeaderText = "Telf."
		'Me.ColumnFax.HeaderText = "Fax"
		'Me.ColumnTMobil.HeaderText = "Telf. Mòbil"
		'Me.ColumnMail.HeaderText = "E-mail"
		'Me.ColumnComent.HeaderText = "Coment"
		'Me.ColumnCategoria.HeaderText = "Categoria"
		
		Me.Text = lang.getText("Text")'Manteniment de Proveïdors
		
		
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
	
	Private Sub changed()
		If blEnable = True Then Me.cmdSalvar.Enabled = True : mnuSave.Enabled = True
	End Sub
	
	#End Region
	#Region " VarTables "
	'Seccio variable segons taula-----------------------------------------
	Public Sub establirRecordset(Optional ByVal Condi As String = "")
		system.Windows.Forms.Cursor.Current = Cursors.AppStarting
		Dim StrSql As String = "SELECT " & COLUMN_ID & ", " & COLUMN_NOM & ",prov_direccio,prov_ciutat,prov_prov,prov_cp,prov_telf,prov_fax,prov_mobil,prov_email,prov_coment  FROM " & TAULA_NOM
		If Condi.Length > 0 Then StrSql = StrSql & " WHERE " & Condi
        Dim db As New MSC.dbs(Cloud)
        Me.gridDades.DataSource = db.getTable(StrSql)
		db = Nothing
		Me.lbRecCount.Text = gridDades.Rows.Count
		gridDades.Focus()

        If gridDades.Rows.Count = 0 Then MetroFramework.MetroMessageBox.Show(Me, MSG_NO_ITEM_FOR_CONDITION, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, 100)
        cmdBloqueix.Enabled = IIf(gridDades.Rows.Count And Usuari.UsrTipus > NivellUsers.USR_CONVIDAT, True, False)
		Me.mnuModif.Enabled = Me.cmdBloqueix.Enabled
		system.Windows.Forms.Cursor.Current = Cursors.Default
	End Sub

    Friend ID As Integer
    Private Sub SaveRecord()
        If Not MyAPP.PermisPerContinuar() Then MetroFramework.MetroMessageBox.Show(Me, MSG_SERVER_CLOSE, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Stop, 100) : Me.Close()
        If MetroFramework.MetroMessageBox.Show(Me, MSG_CONFIRM_SAVE_DADES, MSG_ATENCIO, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, 100) = DialogResult.Cancel Then Exit Sub

        If Len(Me.txtNom.Text) = 0 Then Exit Sub
        IsSaving = True
        Dim Nom As String = AddSlashes(Me.txtNom.Text)
        Dim Direccio As String = AddSlashes(Me.txtDireccio.Text)
        Dim Ciutat As String = AddSlashes(Me.txtCiutat.Text)
        Dim Provincia As String = AddSlashes(Me.txtProvincia.Text)
        Dim CP As Integer = 0
        Try
            CP = Me.txtCP.Text
        Catch ex As Exception
            CP = 0
        End Try

        Dim Telf As Integer = 0
        Try
            Telf = Me.txtTelf.Text
        Catch ex As Exception
            Telf = 0
        End Try
        Dim Fax As Integer = 0
        Try
            Fax = Me.txtFax.Text
        Catch ex As Exception
            Fax = 0
        End Try
        Dim Mobil As Integer = 0
        Try
            Mobil = Me.txtMobil.Text
        Catch ex As Exception
            Mobil = 0
        End Try

        Dim Mail As String = AddSlashes(Me.txtEMail.Text)
        Dim Coment As String = AddSlashes(Me.txtComent.Text)

        ID = Me.lbID.Text
        Dim db As New MSC.dbs(Cloud)
        If blnNouRecord = True Then
            Dim StrSql As String = "INSERT INTO " & TAULA_NOM
            StrSql = StrSql & " ( " & COLUMN_NOM & ",prov_direccio,prov_ciutat,prov_prov,prov_cp,prov_telf,prov_fax,prov_mobil,prov_email,prov_coment ) VALUES "
            StrSql = StrSql & "('" & Nom & "','" & Direccio & "','" & Ciutat & "', '" & Provincia & "'," & CP & ", " & Telf & ", " & Fax & ", " & Mobil & ",'" & Mail & "','" & Coment & "' )"
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
            Dim StrSql As String = "UPDATE " & TAULA_NOM & " SET "
            StrSql = StrSql & COLUMN_NOM & "='" & Nom & "'"
            StrSql = StrSql & ", prov_direccio='" & Direccio & "'"
            StrSql = StrSql & ", prov_ciutat='" & Ciutat & "'"
            StrSql = StrSql & ", prov_prov='" & Provincia & "'"
            StrSql = StrSql & ", prov_cp='" & CP & "'"
            StrSql = StrSql & ", prov_telf='" & Telf & "'"
            StrSql = StrSql & ", prov_fax='" & Fax & "'"
            StrSql = StrSql & ", prov_mobil='" & Mobil & "'"
            StrSql = StrSql & ", prov_email='" & Mail & "'"
            StrSql = StrSql & ", prov_coment='" & Coment & "'"
            StrSql = StrSql & " WHERE " & COLUMN_ID & " = " & ID
            db.Update_ID(StrSql)
        End If
        RefreshDataSet(TAULA_ID)
        For i As Short = 0 To 1
            Dim MyCombo As ComboBox = Nothing
            If IsLoadForm("frmDiscos") Then
                MyCombo = frmDiscos.ComboProveidor
                Dim Cmb As New combo
                Cmb.OmpleCombo(MyCombo, TAULA_ID, TotsCap.CAP)
                MyCombo.SelectedValue = ID
            End If
        Next i
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
            Dim StrSql As String = "DELETE FROM " & TAULA_NOM & " WHERE " & COLUMN_ID & "=" & ID

            db.Delete_ID(StrSql)
            addCtlRadi(0, CShort(Tipus_Play.CTL_SQL), 0, "00:00:00", 0, 0, Usuari.UsrID, StrSql, 0, False)
        Next
		For Each selectedrow As DataGridViewRow In gridDades.SelectedRows
			gridDades.Rows.Remove(selectedrow)
		Next
		db = Nothing
		
		RefreshDataSet(TAULA_ID)
		For i As Short = 0 To 1
			Dim MyCombo As ComboBox = Nothing
			If IsLoadForm("frmDiscos") Then
				MyCombo = frmDiscos.ComboProveidor
				Dim Cmb As New combo
				Cmb.OmpleCombo(MyCombo, TAULA_ID, TotsCap.CAP)
			End If
		Next i
		
	End Sub
	
	Private Sub CloseForm()
		If Me.cmdSalvar.Enabled Then
            If MetroFramework.MetroMessageBox.Show(Me, MSG_SAVE_DADES, MSG_ATENCIO, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, 100) = DialogResult.OK Then SaveRecord()
        End If
        MyAPP.CloseSesionClient(MyAPP.IDSesion_Client, DESCRIP_FORM_PROVEIDORS)
    End Sub
	
	#End Region
	
	Private Sub gridDades_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridDades.CurrentCellChanged
		If IsSaving = True Then Exit Sub
		Try
			If blEnable = True Then LockedRecord()
			Me.lbID.Text = gridDades.CurrentRow.Cells("ColumnID").Value
			Me.txtNom.Text = StripSlashes(NoNul(gridDades.CurrentRow.Cells("ColumnNom").Value))
			Me.txtDireccio.Text = StripSlashes(NoNul(gridDades.CurrentRow.Cells("ColumnAdreca").Value))
			Me.txtCiutat.Text = StripSlashes(NoNul(gridDades.CurrentRow.Cells("ColumnPoblacio").Value))
			Me.txtProvincia.Text = StripSlashes(NoNul(gridDades.CurrentRow.Cells("ColumnProvincia").Value))
			Me.txtCP.Text = NoNul(gridDades.CurrentRow.Cells("ColumnCP").Value)
			Me.txtTelf.Text = NoNul(gridDades.CurrentRow.Cells("ColumnTelf").Value)
			Me.txtFax.Text = NoNul(gridDades.CurrentRow.Cells("ColumnFax").Value)
			Me.txtMobil.Text = NoNul(gridDades.CurrentRow.Cells("ColumnTMobil").Value)
			Me.txtEMail.Text = NoNul(gridDades.CurrentRow.Cells("ColumnMail").Value)
			Me.txtComent.Text = StripSlashes(NoNul(gridDades.CurrentRow.Cells("ColumnComent").Value))
			
			Me.lbPosition.Text = gridDades.CurrentRow.Index
		Catch ex As Exception
			Me.lbID.Text = 0
			Me.txtNom.Text = ""
			Me.txtDireccio.Text = ""
			Me.txtCiutat.Text = ""
			Me.txtProvincia.Text = ""
			Me.txtCP.Text = ""
			Me.txtTelf.Text = ""
			Me.txtFax.Text = ""
			Me.txtMobil.Text = ""
			Me.txtEMail.Text = ""
			Me.txtComent.Text = ""
		End Try
		Me.cmdSalvar.Enabled = False
	End Sub
	
	Private Sub txtBuscar_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuscar.KeyUp
		If e.KeyCode = Keys.Enter Then FindRecord()
	End Sub
	
	Private Sub txtBuscar_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.LostFocus
		FindRecord()
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
			changed()
		Catch ex As Exception
		End Try
		
	End Sub
	
	
	Private Sub txtDireccio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDireccio.TextChanged
		Try
			Dim RowID As Integer = FindAfectatRow()
			Me.gridDades.Rows(RowID).Cells("ColumnAdreca").Value = txtDireccio.Text
			changed()
		Catch ex As Exception
		End Try
	End Sub
	
	Private Sub txtCiutat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCiutat.TextChanged
		Try
			Dim RowID As Integer = FindAfectatRow()
			Me.gridDades.Rows(RowID).Cells("ColumnPoblacio").Value = txtCiutat.Text
			changed()
		Catch ex As Exception
		End Try
	End Sub
	
	Private Sub txtCP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCP.TextChanged
		Try
			Dim RowID As Integer = FindAfectatRow()
			Me.gridDades.Rows(RowID).Cells("ColumnCP").Value = txtCP.Text
			changed()
		Catch ex As Exception
		End Try
	End Sub
	
	Private Sub txtProvincia_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProvincia.TextChanged
		Try
			Dim RowID As Integer = FindAfectatRow()
			Me.gridDades.Rows(RowID).Cells("ColumnProvincia").Value = txtProvincia.Text
			changed()
		Catch ex As Exception
		End Try
	End Sub
	
	Private Sub txtTelf_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTelf.TextChanged
		Try
			Dim RowID As Integer = FindAfectatRow()
			Me.gridDades.Rows(RowID).Cells("ColumnTelf").Value = txtTelf.Text
			changed()
		Catch ex As Exception
		End Try
	End Sub
	
	Private Sub txtMobil_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMobil.TextChanged
		Try
			Dim RowID As Integer = FindAfectatRow()
			Me.gridDades.Rows(RowID).Cells("ColumnTMobil").Value = txtMobil.Text
			changed()
		Catch ex As Exception
		End Try
	End Sub
	
	Private Sub txtFax_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFax.TextChanged
		Try
			Dim RowID As Integer = FindAfectatRow()
			Me.gridDades.Rows(RowID).Cells("ColumnFax").Value = txtFax.Text
			changed()
		Catch ex As Exception
		End Try
	End Sub
	
	Private Sub txtEMail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEMail.TextChanged
		Try
			Dim RowID As Integer = FindAfectatRow()
			Me.gridDades.Rows(RowID).Cells("ColumnMail").Value = txtEMail.Text
			changed()
		Catch ex As Exception
		End Try
	End Sub
	
	Private Sub txtComent_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtComent.TextChanged
		Try
			Dim RowID As Integer = FindAfectatRow()
			Me.gridDades.Rows(RowID).Cells("ColumnComent").Value = txtComent.Text
			changed()
		Catch ex As Exception
		End Try
	End Sub
	
	Protected Overrides Sub Finalize()
		MyBase.Finalize()
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
	
	Private Sub mnuRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRefresh.Click
		establirRecordset()
	End Sub
	
	#End Region
	
	Private Sub mnu_Help_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_Help.Click
		Dim Proces As Process = New Process
		Try
			Process.Start(MSC.Help.HELP_GEST_PUBLICITAT.ToString)
		Catch ex As Exception
		End Try
	End Sub
End Class