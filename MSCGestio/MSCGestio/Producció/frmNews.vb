Option Strict Off
Option Explicit On

Public Class frmNews
	Dim Cancelled As Boolean
	Dim blEnable As Boolean
	Dim blnNouRecord As Boolean
	Dim IsSaving As Boolean = False
	
	Const MAX_WIDTH_IMG As Integer = 500
	Const MAX_HEIDTH_IMG As Integer = 375
	Dim Flat_Edit_Image As Boolean = False
	
	Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
		Me.Close()
	End Sub
	
	Private Sub cmdSortir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSortir.Click
		Me.Close()
	End Sub
	
	Private Sub frmNews_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		CloseForm()
	End Sub
	
	Private Sub CloseForm()
		If Me.cmdSalvar.Enabled Then
            If MetroFramework.MetroMessageBox.Show(Me, MSG_SAVE_DADES, MSG_ATENCIO, MessageBoxButtons.YesNo, MessageBoxIcon.Information, 100) = DialogResult.Yes Then SaveRecord()
        End If
        MyAPP.CloseSesionClient(MyAPP.IDSesion_Client, DESCRIP_FORM_NEWS)
    End Sub
	
	Private Sub getListRecord(Optional ByVal Condi As String = "")        
		system.Windows.Forms.Cursor.Current = Cursors.AppStarting
		Dim StrSql As String = "SELECT news_id, news_tipusid, news_titular, news_cos, news_datacreacio,news_datapublicacio, news_datacaducitat, news_activa, news_clicks, news_autor FROM noticies"
		If Condi.Length > 0 Then StrSql = StrSql & " WHERE " & Condi
        Dim db As New MSC.dbs(Cloud)
        gridDades.DataSource = db.getTable(StrSql)
		db = Nothing

        If gridDades.Rows.Count = 0 Then MetroFramework.MetroMessageBox.Show(Me, MSG_NO_ITEM_FOR_CONDITION, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
        cmdBloqueix.Enabled = IIf(gridDades.Rows.Count And Usuari.UsrTipus > NivellUsers.USR_CONVIDAT, True, False)
		Me.mnuModif.Enabled = Me.cmdBloqueix.Enabled
		system.Windows.Forms.Cursor.Current = Cursors.Default
		
	End Sub
	
	Private Sub SaveRecord()
        If Not MyAPP.PermisPerContinuar() Then MetroFramework.MetroMessageBox.Show(Me, MSG_SERVER_CLOSE, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Stop, 100) : Me.Close()
        If MetroFramework.MetroMessageBox.Show(Me, MSG_CONFIRM_SAVE_DADES, MSG_ATENCIO, MessageBoxButtons.YesNo, MessageBoxIcon.Question, 100) = DialogResult.No Then Exit Sub

        If Len(Me.txtCos.Text) = 0 Then Exit Sub
		If Len(Me.txtTitular.Text) = 0 Then Exit Sub
		IsSaving = True
		Dim ID As Integer = Me.lbID.Text
		Dim Titular As String = AddSlashes(Me.txtTitular.Text)
		Dim Cos As String = AddSlashes(Me.txtCos.Text)
		Dim Tipus As Short = Me.comboCategoria.SelectedValue
		Dim actv As Boolean = Me.ChkActiva.Checked
		Dim DataIn As Date = Me.txtDataIn.Value
		Dim DataOut As Date = Me.txtDataOut.Value
		Dim Autor As String = AddSlashes(Me.txtAutor.Text)
		
		Dim sCmd As String
        Dim db As New MSC.dbs(Cloud)
        If blnNouRecord = True Then
			'TODO: Falta Imatge
			sCmd = "INSERT INTO noticies ( news_titular, news_tipusid"
			sCmd = sCmd & ", news_cos, news_activa, news_datacreacio,news_datapublicacio,news_datacaducitat,news_autor)"
			sCmd = sCmd & " VALUES "
			sCmd = sCmd & "( '" & Titular & "'"
			sCmd = sCmd & ", " & Tipus
			sCmd = sCmd & ", '" & Cos & "'"
			sCmd = sCmd & ", " & CShort(IIf(actv, 1, 0))
			sCmd = sCmd & ", '" & Now.ToString("yyyy-MM-dd HH:mm:ss") & "'"
			sCmd = sCmd & ", '" & DataIn.ToString("yyyy-MM-dd HH:mm:ss") & "'"
			sCmd = sCmd & ", '" & DataOut.ToString("yyyy-MM-dd HH:mm:ss") & "'"
			sCmd = sCmd & ", '" & Autor & "'"
			sCmd = sCmd & ");"
			
			ID = db.New_ID(sCmd)
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
			db.IniTransaction()
			sCmd = "UPDATE noticies "
			sCmd = sCmd & " SET"
			sCmd = sCmd & " news_titular = '" & Titular & "'"
			sCmd = sCmd & ", news_tipusid = " & Tipus
			sCmd = sCmd & ", news_cos = '" & Cos & "'"
			sCmd = sCmd & ", news_activa = " & CShort(IIf(actv, 1, 0))
			sCmd = sCmd & ", news_datapublicacio = '" & DataIn.ToString("yyyy-MM-dd HH:mm:ss") & "'"
			sCmd = sCmd & ", news_datacaducitat = '" & DataOut.ToString("yyyy-MM-dd HH:mm:ss") & "'"
			sCmd = sCmd & ", news_autor = '" & Autor & "'"
			
			sCmd = sCmd & " WHERE news_id=" & ID
			db.Update_ID(sCmd)
			
			'Salvar els tags.
			'Borrar Tags
			sCmd = "DELETE FROM tags_relationships WHERE fitxer_id =" & ID & " AND relation_tipfitxer=" & FITXER_NOTICIES & " ;"
			db.Delete_ID(sCmd)
			If ListViewTags.Items.Count > 0 Then
				sCmd = "INSERT INTO tags_relationships (relation_tipfitxer,fitxer_id,tag_id) VALUES "
				For Each item As ListViewItem In Me.ListViewTags.Items
					If sCmd.Length > 76 Then sCmd += ","
					sCmd += "(" & FITXER_NOTICIES & "," & ID & "," & item.Tag & ")"
				Next
				sCmd += ";"
				db.New_ID(sCmd)
			End If
			db.EndTransaction()
		End If
		If Flat_Edit_Image = True Then savePig(ID)
		db = Nothing
		IsSaving = False
		blEnable = True
		blnNouRecord = False
		LockedRecord(True)
		Me.gridDades.Focus()
		
	End Sub
	
	Private Sub DeleteRecord()
		If blnNouRecord = True Then 
			LockedRecord(True)
			NetejaPantalla()
			gridDades.AllowUserToAddRows = False
			Exit Sub
		End If
		Dim MsgTxt As String = MSG_CONFIRM_DELETE_DADES
		If gridDades.SelectedRows.Count > 1 Then MsgTxt =  String.Format(MSG_CONFIRM_DELETE_NUM_DADES,  gridDades.SelectedRows.Count )
        If MetroFramework.MetroMessageBox.Show(Me, MsgTxt, MSG_ATENCIO, MessageBoxButtons.OKCancel, MessageBoxIcon.Information, 100) = DialogResult.Cancel Then Exit Sub


        Dim db As New MSC.dbs(Cloud)
        Dim StrSql As String = ""
		
		db.IniTransaction()
		For i As Short = 0 To gridDades.SelectedRows.Count - 1
			'Borrar dbs
			Dim ID As String = gridDades.SelectedRows(i).Cells("ColumnID").Value.ToString
			StrSql = "DELETE FROM noticies WHERE news_id = " & ID & " ;"
            db.Delete_ID(StrSql)
            addCtlRadi(0, CShort(Tipus_Play.CTL_SQL), 0, "00:00:00", 0, 0, Usuari.UsrID, StrSql, 0, False)
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
		'RefreshDataSet(TAULES_DBS.)
		
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
		Me.lbID.Text = Me.lbUltim.Text + 1
		
		blEnable = False
		LockedRecord()
		
		Me.lbNou.Visible = True
		
		comboCategoria.Focus()
	End Sub
	
	Private Sub NetejaPantalla()
		Me.txtCos.Text = ""
		Me.txtTitular.Text = ""
		Me.txtDataIn.Value = Now()
		Me.txtDataOut.Value = Now().AddDays(15)
		Me.lbDataCrea.Text = Now()
		Me.lbClicks.Text = 0
		Me.ListViewTags.Items.Clear()
		Me.comboCategoria.SelectedValue = 0
		Me.ChkActiva.Checked = False
	End Sub
	
	Private Sub LockedRecord(Optional ByVal saved As Boolean = False)
        If Me.cmdSalvar.Enabled = True And saved = False Then
            If MetroFramework.MetroMessageBox.Show(Me, MSG_SAVE_DADES, MSG_ATENCIO, MessageBoxButtons.OKCancel, MessageBoxIcon.Information, 100) = DialogResult.OK Then SaveRecord()
        End If
        blEnable = Not blEnable
		If blEnable = False Then blnNouRecord = False
		
		Me.txtTitular.Enabled = blEnable
		Me.txtCos.Enabled = blEnable
		Me.comboCategoria.Enabled = blEnable
		Me.txtDataIn.Enabled = blEnable
		Me.txtDataOut.Enabled = blEnable
		Me.txtAutor.Enabled = blEnable
		ListViewTags.Enabled = blEnable
		ChkActiva.Enabled = blEnable
		Me.ButtonAddPig.Enabled = blEnable
		ButtonDelPic.Enabled = blEnable
		
		Me.cmdBorrar.Enabled = blEnable
		Me.lbNou.Visible = False
		If blEnable Then
			Me.cmdBloqueix.Image = Me.picUnLock.Image
		Else
			Me.cmdBloqueix.Image = Me.picLock.Image
			Me.cmdSalvar.Enabled = False
		End If
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
	
	Private Sub cmdBloqueix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBloqueix.Click
		LockedRecord()
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
				StrSql = "news_id = " & txtBuscar.Text
			Case Buscar.BUSCAR_NOM
				StrSql = "news_titular LIKE '%" & txtBuscar.Text & "%'"
			Case Buscar.BUSCAR_TOTS
				StrSql = "news_titular LIKE '%" & txtBuscar.Text & "%' OR news_id = " & txtBuscar.Text
		End Select
		getListRecord(StrSql)
	End Sub
	
	Private Sub cmdRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefrescar.Click
		getListRecord()
	End Sub
	
	Private Sub Changed()
		If blEnable = True Then Me.cmdSalvar.Enabled = True : Me.mnuSave.Enabled = True
	End Sub
	
	Private Sub comboCategoria_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles comboCategoria.KeyUp
		Select Case e.KeyCode
			Case Keys.Left, Keys.Right, Keys.Up, Keys.Down
				Return
		End Select
		Dim MyComboBox As ComboBox = CType(sender, ComboBox)
		Dim Origen As TAULES_DBS = TAULES_DBS.TAULA_CATEGORIA_NEWS        
		refreshComboBoxKeyUp(MyComboBox, Origen, TotsCap.CAP)
		
	End Sub
	
	Private Sub comboCategoria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboCategoria.SelectedIndexChanged
		Try
			Dim RowID As Integer = FindAfectatRow()
			Me.gridDades.Rows(RowID).Cells("ColumnTipus").Value = comboCategoria.SelectedValue
			
			Changed()
		Catch ex As Exception
		End Try
	End Sub
	
	Private Sub frmNews_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
		setLanguageForm()
		If My.Settings.TXT_CAPITALIZE Then
			Me.txtTitular.CharacterCasing = CharacterCasing.Upper
			Me.txtCos.CharacterCasing = CharacterCasing.Upper
			Me.txtAutor.CharacterCasing = CharacterCasing.Upper
		End If

        'Me.cmdBloqueix.Enabled = IIf(Usuari.UsrTipus > NivellUsers.USR_CONVIDAT, True, False)
        Me.cmdNou.Visible = IIf(Usuari.UsrTipus > NivellUsers.USR_CONVIDAT, True, False)
		
		Me.mnuNew.Visible = Me.cmdNou.Visible
		OmpleMnuTAGS()

        If Not frmMain.NoLoadRs Then getListRecord()
        Me.ClientSize = New Size(frm_sice(0), frm_sice(1))
    End Sub
	
	Public Sub setLanguageForm()
		lang.StrForm = Me.Name			
		
		
		'Me.ToolStrip1.Text = "ToolStrip1"
		Me.cmdPrimer.Text = lang.getText("LABEL_GOTO_FIRSH",True)'"Primer"
		Me.cmdPrevi.Text = lang.getText("LABEL_GOTO_PREV",True)'"Anterior"
		Me.cmdSeguent.Text = lang.getText("LABEL_GOTO_NEXT",True)'"Següent"
		Me.cmdUltim.Text = lang.getText("LABEL_GOTO_LAST",True)'"Últim"
		Me.cmdNou.Text = lang.getText("LABEL_NEW",True) '"Nou"
		Me.cmdBloqueix.Text = lang.getText("LABEL_EDITAR",True) '"Editar"
		Me.cmdBorrar.Text = lang.getText("LABEL_DELETE",True) '"Borrar"
		Me.cmdSalvar.Text = lang.getText("LABEL_SAVE",True)'"Salvar"
		Me.cmdRefrescar.Text = Lang.getText("LABEL_REFRESCAR",True)'"Refrescar"
		Me.OptionBuscar.Text = lang.getText("LABEL_BUSCAR",True)'"Buscar"
		Me.PerIDToolStripMenuItem.Text = lang.getText("mnu_Buscar_ID",True)'"Per ID"		
		Me.PerQualsevolToolStripMenuItem.Text = lang.getText("mnu_Buscar_QUALSEVOL",True)'"Qualsevol"	
		Me.cmdSortir.Text = lang.getText("LABEL_EXIT",True) '"Sortir"
		Me.lbNou.Text = lang.getText("LABEL_NEW_UPPER",True) ' "NOU"
		Me.ProgarmaToolStripMenuItem.Text = lang.getText("LABEL_PROGRAMA",True) '"Programa"	
		Me.mnuExit.Text = lang.getText("LABEL_EXIT",True) '"Sortir"
		Me.EdicióToolStripMenuItem.Text = lang.getText("mnuEdit.Text",True )'"Edició"
		Me.mnuSave.Text = lang.getText("LABEL_SAVE",True)'"Salvar"
		Me.mnuNew.Text = lang.getText("LABEL_NEW",True) '"Nou"
		Me.mnuDel.Text = lang.getText("LABEL_DELETE",True) '"Borrar"
		Me.mnuModif.Text =  lang.getText("LABEL_MODIFICAR",True) '"Modificar"
		Me.mnuRefresh.Text = Lang.getText("LABEL_REFRESCAR",True)'"Refrescar"
		Me.ToolStripMenuItem8.Text = lang.getText("mnu_Help",True) '"Ajuda"
		Me.mnu_Help.Text = lang.getText("mnuRefHelp.Text",True) '"Manual OnLine"
		Me.Label5.Text = lang.getText("HEADERTEXT_DATE_CREA",True) '"Data Creació"
		Me.ChkActiva.Text = lang.getText("LABEL_ACTIVA",True) '"Activa"
		Me.ColumnID.HeaderText = lang.getText("HEADERTEXT_ID",True) '"ID"
		Me.ColumnDataCrea.HeaderText =  lang.getText("HEADERTEXT_DATE_CREA",True) '"Data Creació"
		Me.ColumnActiva.HeaderText = lang.getText("LABEL_ACTIVA",True) '"Activa"
		
		Me.PerTitularToolStripMenuItem.Text = lang.getText("PerTitularToolStripMenuItem.Text") '"Per Titular"
		Me.mnu_vigents.Text = lang.getText("mnu_vigents.Text") '"Només vigents"
		Me.mnu_vigents.ToolTipText = lang.getText("mnu_vigents.ToolTipText") '"Actives i entre dates"		
		Me.lbCategoria.Text = lang.getText("lbCategoria.Text") '"Categoria"
		Me.Label9.Text = lang.getText("Label9.Text") & ":" '"Autor:"
		Me.Label8.Text = lang.getText("LABEL_CLICKS",True) & ":" '"Clicks:"
		
		Me.lbTAGS.Text = lang.getText("LABEL_TAGS",True) '"Etiquetes"
		Me.Label6.Text = lang.getText("LABEL_DATA_PUBLICACIO",True) & ":" '"Data Publicació:"		
		'Me.ToolStrip2.Text = "ToolStrip2"
		'Me.ToolStripButton1.Text = "ToolStripButton1"
		'Me.ToolStripButton1.ToolTipText = "Negreta"
		'Me.ToolStripButton2.Text = "ToolStripButton2"
		'Me.ToolStripButton2.ToolTipText = "Cursiva"
		'Me.ToolStripButton3.Text = "ToolStripButton3"
		'Me.ToolStripButton3.ToolTipText = "Link"		
		
		
		Me.Label1.Text = lang.getText("HEADERTEXT_ID",True) & ":" '"id:"	
		Me.ColumnTipus.HeaderText = lang.getText("LABEL_TIPUS",True) '"Tipus"
		Me.Label3.Text = lang.getText("Label3.Text") '"Titular"
		Me.ColumnTitular.HeaderText = Label3.Text '"Titular"
		Me.Label4.Text = lang.getText("Label4.Text") '"Cos"
		Me.ColumnCos.HeaderText = Label4.Text  '"cos"
		Me.ColumnDataPubli.HeaderText = lang.getText("LABEL_DATA_PUBLICACIO",True) '"Data Publicació"
		Me.Label7.Text = lang.getText("Label7.Text") & ":" '"Data Caducitat:"
		Me.ColumnDataOut.HeaderText = lang.getText("Label7.Text") '"Data Caducitat"
		Me.ColumnCliks.HeaderText = lang.getText("LABEL_CLICKS",True) '"Clicks"
		Me.ColumnAutor.HeaderText = Me.Label9.Text '"Autor"
		'Me.MenuStrip1.Text = "MenuStrip1"					
		Me.OpenFileDialog1.Filter = lang.getText("LABEL_IMAGE_FILES",true) & " |*.gif; *.jpg; *.jpeg; *.bmp" '"arxius d'imatges |*.gif; *.jpg; *.jpeg; *.bmp"
		Me.OpenFileDialog1.Title = lang.getText("LABEL_SELECT_FOTO_62KB",True) '"Seleccioneu una foto (Max. 62Kb)"
		Me.mnuAddTAG.Text = lang.getText("LABEL_ADD_TAG",True) '"Afegir TAG"
		Me.mnuTotsTags.Text = lang.getText("LABEL_TOTS",True) '"Tots"
		Me.mnuCatTAGS.Text = lang.getText("LABEL_CATEGORIES",True) '"Categories"
		Me.mnuExcludeTAG.Text = lang.getText("LABEL_DEL_TAG",True) '"Borrar TAG"		
		Me.Text = lang.getText("Text") '"Redacció de Notícies"
        Dim Cmb As New combo
        Cmb.OmpleCombo(Me.comboCategoria, TAULES_DBS.TAULA_CATEGORIA_NEWS, TotsCap.CAP) : comboCategoria.SelectedValue = 0
        Cmb.OmpleCombo(Me.ColumnTipus, TAULES_DBS.TAULA_CATEGORIA_NEWS, TotsCap.CAP)

    End Sub
	
	
	Private Sub gridDades_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridDades.CurrentCellChanged
		If IsSaving = True Then Exit Sub
		Try
			If blEnable = True Then LockedRecord()
			Me.lbID.Text = gridDades.CurrentRow.Cells("ColumnID").Value
			Me.txtTitular.Text = StripSlashes(gridDades.CurrentRow.Cells("ColumnTitular").Value)
			Me.txtCos.Text = StripSlashes(gridDades.CurrentRow.Cells("ColumnCos").Value)
			Me.comboCategoria.SelectedValue = gridDades.CurrentRow.Cells("ColumnTipus").Value
			
			Me.lbDataCrea.Text = gridDades.CurrentRow.Cells("ColumnDataCrea").Value
			Me.txtDataIn.Value = gridDades.CurrentRow.Cells("ColumnDataPubli").Value
			Me.txtDataOut.Value = gridDades.CurrentRow.Cells("ColumnDataOut").Value
			Me.ChkActiva.Checked = gridDades.CurrentRow.Cells("ColumnActiva").Value
			Me.lbClicks.Text = gridDades.CurrentRow.Cells("ColumnCliks").Value
			Me.txtAutor.Text = gridDades.CurrentRow.Cells("ColumnAutor").Value
			
			'Busca tags
			ListViewTags.Items.Clear()
			Dim StrSql As String = "relation_tipfitxer=" & FITXER_NOTICIES & " AND fitxer_id=" & lbID.Text
			Dim colec() As DataRow = dsClient.Tables("tags_relationships").Select(StrSql)
			For i As Integer = 0 To colec.Length - 1
				Dim item As New ListViewItem
				item.Text = colec(i)("tag_nom").ToString
				item.Tag = colec(i)("tag_id").ToString
				Me.ListViewTags.Items.Add(item)
			Next
			colec = Nothing
			tmrDetalls.Enabled = True
			
			Me.lbPosition.Text = Me.gridDades.CurrentRow.Index + 1
			
		Catch ex As Exception
			Me.lbID.Text = 0
			Me.txtTitular.Text = ""
			Me.txtCos.Text = ""
			Me.lbDataCrea.Text = ""
			Me.txtDataIn.Value = Now()
			Me.txtDataOut.Value = Now().AddDays(15)
			Me.comboCategoria.SelectedValue = 0
			Me.lbClicks.Text = 0
			Me.ChkActiva.Checked = False
		End Try
		
	End Sub
	
	Private Function FindAfectatRow() As Integer
		If blnNouRecord Then
			Return gridDades.NewRowIndex
		Else
			Return gridDades.CurrentRow.Index
		End If
	End Function
	
	Private Sub txtTitular_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTitular.TextChanged
		Try
			Dim RowID As Integer = FindAfectatRow()
			Me.gridDades.Rows(RowID).Cells("ColumnTitular").Value = txtTitular.Text
			Changed()
		Catch ex As Exception
		End Try
	End Sub
	
	Private Sub txtCos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCos.TextChanged
		Try
			Dim RowID As Integer = FindAfectatRow()
			Me.gridDades.Rows(RowID).Cells("ColumnCos").Value = txtCos.Text
			Changed()
		Catch ex As Exception
		End Try
	End Sub
	
	Private Sub ChkActiva_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkActiva.CheckedChanged
		Try
			Dim RowID As Integer = FindAfectatRow()
			Me.gridDades.Rows(RowID).Cells("ColumnActiva").Value = ChkActiva.Checked
			Changed()
		Catch ex As Exception
		End Try
	End Sub
	
	Private Sub txtBuscar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.GotFocus
		txtBuscar.Text = ""
	End Sub
	
	Private Sub txtBuscar_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuscar.KeyUp
		If e.KeyCode = Keys.Enter Then FindRecord()
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
		getListRecord()
	End Sub
	
	#End Region
	
	Private Sub mnu_Help_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_Help.Click
		Dim Proces As Process = New Process
		Try
			Process.Start(MSC.Help.HELP_GEST_PRODUCCIO_NOTICIES.ToString)
		Catch ex As Exception
		End Try
	End Sub
	
	
	Private Sub pigProgram_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles picture.DoubleClick
		If Me.picture.Cursor = Cursors.Hand Then
			Try
				frmPicture.PictureBoxPersona.Image = picture.Image
				frmPicture.Text = Me.txtTitular.Text
				frmPicture.Show(Me)	
			Catch ex As Exception				
				frmPicture.WindowState = FormWindowState.Normal
			End Try
			
		End If
	End Sub
	
	Private Sub ButtonAddPig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAddPig.Click
		If Me.OpenFileDialog1.ShowDialog() = system.Windows.Forms.DialogResult.OK Then
			Me.picture.Image = resizeImageFromPath(OpenFileDialog1.FileName, MAX_WIDTH_IMG, MAX_HEIDTH_IMG)
			Me.picture.Cursor = Cursors.Hand
			Flat_Edit_Image = True
			changed()
		End If
	End Sub
	
	Private Sub ButtonDelPic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDelPic.Click
		Me.picture.Image = picture.ErrorImage
		Flat_Edit_Image = True
		Me.picture.Cursor = Cursors.Default
		changed()
	End Sub
	
	Private Sub tmrDetalls_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDetalls.Tick
		tmrDetalls.Enabled = False
		LoadPictureFromDBS(lbID.Text)
	End Sub
	
	Private Sub LoadPictureFromDBS(ByVal id_news As Integer)
		
		Dim strSql As String = "SELECT news_img FROM noticies where news_id=" & id_news.ToString & " ;"
        Dim db As New MSC.dbs(Cloud)

        Dim dataTB As DataTable = db.getTable(strSql)
		Me.picture.Image = Me.picture.ErrorImage
		Me.picture.Cursor = Cursors.Default
		Me.picture.Cursor = Cursors.Default
		If dataTB Is Nothing Then Exit Sub
		If dataTB.Rows.Count > 0 Then
			Try
				Me.picture.Image = GetImageFromByteArray(CType(dataTB.Rows(0)(0), Byte()))
				Me.picture.Cursor = Cursors.Hand
			Catch ex As Exception
				Me.picture.Image = Me.picture.ErrorImage
				Me.picture.Cursor = Cursors.Default
			End Try
		End If
		dataTB.Dispose()
		db = Nothing
	End Sub
	
	Friend Sub OmpleMnuTAGS()
        Dim db As New MSC.dbs(Cloud)
        Dim dtTagCat As DataTable = db.getTable("SELECT * FROM `list_tags` WHERE tag_parent>0 group by tag_parent")
		Dim CatID As Integer = 0
		Dim mnuTAGCATMare As ToolStripMenuItem
		For i As Integer = 0 To dtTagCat.Rows.Count - 1
			Dim IdTag As Integer = dtTagCat.Rows(i)("tag_parent")
			mnuTAGCATMare = New ToolStripMenuItem
			mnuTAGCATMare.Text = getNomTAG(IdTag)
			mnuTAGCATMare.Tag = IdTag
			mnuTAGCATMare.Name = "mnuCat" & IdTag
			mnuCatTAGS.DropDownItems.Add(mnuTAGCATMare)
			Dim colecCat() As DataRow = dsClient.Tables("list_tags").Select("tag_parent=" & IdTag)
			
			Dim mnuTAGCAT As ToolStripMenuItem
			For n As Integer = 0 To colecCat.Length - 1
				mnuTAGCAT = New ToolStripMenuItem
				mnuTAGCAT.Text = colecCat(n)("tag_nom").ToString
				mnuTAGCAT.Tag = colecCat(n)("tag_id").ToString
				mnuTAGCATMare.DropDownItems.Add(mnuTAGCAT)
				AddHandler mnuTAGCAT.Click, AddressOf mnuTAG_Click
			Next
		Next
		
		Dim colec() As DataRow = dsClient.Tables("list_tags").Select("")
		Dim mnuTAG As ToolStripMenuItem
		For i As Integer = 0 To colec.Length - 1
			mnuTAG = New ToolStripMenuItem
			mnuTAG.Text = colec(i)("tag_nom").ToString
			mnuTAG.Tag = colec(i)("tag_id").ToString
			mnuTotsTags.DropDownItems.Add(mnuTAG)
			AddHandler mnuTAG.Click, AddressOf mnuTAG_Click
		Next
	End Sub
	
	Private Sub mnuTAG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
		
		Dim item As New ListViewItem
		item.Text = CType(sender, ToolStripMenuItem).Text
		item.Tag = CType(sender, ToolStripMenuItem).Tag
		Me.ListViewTags.Items.Add(item)
        Dim db As New MSC.dbs(Cloud)
        Dim sCmd As String = "UPDATE list_tags SET tag_count=tag_count+1 WHERE tag_id=" & item.Tag & " ;"
		db.Update_ID(sCmd)
		changed()
		
	End Sub
	
	Private Sub ListViewTags_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListViewTags.MouseDown
		Me.ContextMenuStripTags.Show(ListViewTags, Me.ListViewTags.PointToClient(system.Windows.Forms.Cursor.Position))
	End Sub
	
	Private Sub ContextMenuStripTags_Opening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStripTags.Opening
		Me.mnuExcludeTAG.Enabled = (Me.ListViewTags.Items.Count > 0)
	End Sub
	
	Private Sub mnuExcludeTAG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExcludeTAG.Click
		Dim listItem As ListViewItem
		For Each listItem In ListViewTags.SelectedItems
			ListViewTags.Items.Remove(listItem)
            Dim db As New MSC.dbs(Cloud)
            Dim sCmd As String = "UPDATE list_tags SET tag_count=tag_count-1 WHERE tag_id=" & listItem.Tag & " ;"
			db.Update_ID(sCmd)
			db = Nothing
		Next
		changed()
	End Sub
	
	Private Sub lbTAGS_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbTAGS.LinkClicked
        Dim tag_sel As String = ""
        Dim Nofind As Boolean = False
        Try
            tag_sel = ListViewTags.SelectedItems(0).Text
        Catch ex As Exception
            Nofind = True
        End Try

        Dim frmChill As New frmMantTags
        Try
            frmChill.IniTable()

            If Nofind = False Then frmChill.establirRecordset("tag_nom = '" & tag_sel & "'")
            If frmChill.ShowDialog = DialogResult.OK Then
                ListViewTags.Items.Clear()
                Dim StrSql As String = "relation_tipfitxer=" & Tipus_Fitxers.FITXER_PROGRAMA & " AND fitxer_id=" & lbID.Text
                Dim colec() As DataRow = dsClient.Tables("tags_relationships").Select(StrSql)
                For i As Integer = 0 To colec.Length - 1
                    Dim item As New ListViewItem
                    item.Text = colec(i)("tag_nom").ToString
                    item.Tag = colec(i)("tag_id").ToString
                    Me.ListViewTags.Items.Add(item)
                Next
                colec = Nothing
                OmpleMnuTAGS()
            End If
        Catch ex As Exception
        End Try
        frmChill = Nothing

    End Sub
	
	Private Sub savePig(ByVal id_programa As Integer)
		
		If picture.Image Is Nothing Then Exit Sub
		Dim ms As IO.MemoryStream = New IO.MemoryStream
		picture.Image.Save(ms, Imaging.ImageFormat.Jpeg)
		
		Dim bytBLOBData(CInt(ms.Length - 1)) As Byte
		
		ms.Position = 0
		ms.Read(bytBLOBData, 0, CInt(ms.Length))
		
		Dim prm As New MySql.Data.MySqlClient.MySqlParameter("@Picture", _
			MySql.Data.MySqlClient.MySqlDbType.Blob, _
			bytBLOBData.Length, ParameterDirection.Input, False, _
			0, 0, Nothing, DataRowVersion.Current, bytBLOBData)

        Dim db As New MSC.dbs(Cloud)
        Dim StrSql As String = "UPDATE noticies SET news_img=@Picture WHERE news_id=" & id_programa.ToString & ";"
		db.ExecuteInstruc(StrSql, prm)
		db = Nothing
		
	End Sub
	
	Private Sub txtDataIn_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDataIn.ValueChanged
		Try
			Dim RowID As Integer = FindAfectatRow()
			Me.gridDades.Rows(RowID).Cells("ColumnDataPubli").Value = txtDataIn.Value
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
	
	Private Sub txtAutor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAutor.TextChanged
		Try
			Dim RowID As Integer = FindAfectatRow()
			Me.gridDades.Rows(RowID).Cells("ColumnAutor").Value = txtAutor.Text
			Changed()
		Catch ex As Exception
		End Try
	End Sub
	
	Private Sub mnu_vigents_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_vigents.Click
		getListRecord(" news_datapublicacio<= '" & Now.ToString("yyyy-MM-dd HH:mm:ss") & "' AND news_datacaducitat>= '" & Now.ToString("yyyy-MM-dd HH:mm:ss") & "' AND news_activa=1")
	End Sub
	
	Private Sub lbCategoria_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbCategoria.LinkClicked

        Dim frmChill As New frmMantCatNews
        Try
            frmChill.IniTable()
            If comboCategoria.SelectedValue > 0 Then frmChill.establirRecordset("cat_nom = '" & Me.comboCategoria.Text & "'")
            If frmChill.ShowDialog = DialogResult.OK Then
                Dim Cmb As New combo
                Cmb.OmpleCombo(comboCategoria, TAULES_DBS.TAULA_CATEGORIA_NEWS, TotsCap.CAP)
                comboCategoria.SelectedValue = frmChill.ID
            End If
        Catch ex As Exception
            frmMantInterp.WindowState = FormWindowState.Normal
        End Try
        frmChill = Nothing
    End Sub

    Private Sub frmNews_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        Dim FitxerINI As New IniFile
        frm_sice(0) = Me.Width : frm_sice(1) = Me.Height
        FitxerINI.INIWrite(MyAPP.IniFile, "Data Gest", "size", frm_sice(0).ToString & "," & frm_sice(1).ToString)
    End Sub
End Class