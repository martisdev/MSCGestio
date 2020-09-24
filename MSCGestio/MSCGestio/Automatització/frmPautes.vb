Option Strict Off
Option Explicit On

Public Class frmPautes
	Dim blEnable As Boolean
	Dim mblnNewDates As Boolean = False
	Private DragLV As System.Windows.Forms.ListViewItem 'The item being dragged
	Dim InfoMsg As frmTip
	
	
	Private Sub CloseForm()

        MyAPP.CloseSesionClient(MyAPP.IDSesion_Client, DESCRIP_FORM_PAUTES)
		Me.Dispose()
	End Sub
	
	Private Sub frmPautes_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		CloseForm()
	End Sub
	
	Private Sub frmPautes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load        
		setLanguageForm()
		If My.Settings.TXT_CAPITALIZE Then
			Me.txtComent.CharacterCasing = CharacterCasing.Upper
			Me.txtTitolPauta.CharacterCasing = CharacterCasing.Upper
		End If
		If Not frmMain.NoLoadRs Then establirRecordset()
		refrescarLListaBlocs()
        ' Control d'usuaris
        Me.cmdNou.Visible = IIf(Usuari.UsrTipus > NivellUsers.USR_CONVIDAT, True, False)
		Me.cmdBloqueix.Enabled = IIf(Usuari.UsrTipus > NivellUsers.USR_CONVIDAT, True, False)

        Me.mnuNew.Visible = Me.cmdNou.Visible
        Me.ClientSize = New Size(frm_sice(0), frm_sice(1))
    End Sub
	
	Dim MSG_ERR_MIN_BLOC As String = "S'ha d'entrar algun bloc"
    Dim MSG_ERR_NAME_BLOC As String = "S'ha d'assignar un nom a la pauta"
    Dim LABEL_NUM_USED As String = "Nº d'utilitzacions: {0}"
    Dim MSG_ERR_PAUTA_DEF_DETETE As String

    Public Sub setLanguageForm()
		lang.StrForm = Me.Name

        MSG_ERR_PAUTA_DEF_DETETE = lang.getText("MSG_ERR_PAUTA_DEF_DETETE") '"Aquesta pauta (PAUTA DEFECTE) és de sistema, no es pot borrar"
        MSG_ERR_MIN_BLOC = lang.getText("MSG_ERR_MIN_BLOC") '"S'ha d'entrar algun bloc"
        MSG_ERR_NAME_BLOC = lang.getText("MSG_ERR_NAME_BLOC") '"S'ha d'assignar un nom a la pauta"        
        LABEL_NUM_USED = lang.getText("LABEL_NUM_USED") '"Nº d'utilitzacions: {0}"		


        Me.cmdSortir.Text = lang.getText("LABEL_EXIT",True)'"Sortir"
		Me.mnuExit.Text = lang.getText("LABEL_EXIT",True)'"Sortir"
		Me.EdicióToolStripMenuItem.Text = lang.getText("mnuEdit.Text",True)'"Edició"		
		Me.mnuSave.Text = lang.getText("LABEL_SAVE",True)'"Salvar"
		Me.mnuDel.Text = lang.getText("LABEL_DELETE",True)'"Borrar"		
		Me.cmdBorrar.Text = lang.getText("LABEL_DELETE",True)'"Borrar"
		Me.cmdSalvar.Text = lang.getText("LABEL_SAVE",True)'"Salvar"	
		Me.ToolStripMenuItem1.Text = lang.getText("mnu_Help",True)'"Ajuda"
		Me.mnu_Help.Text = lang.getText("mnuRefHelp.Text",True)'"Manual OnLine"
		
		Me.mnuModif.Text = lang.getText("LABEL_MODIFICAR",True )'"Modificar"
		Me.mnuNew.Text = lang.getText("LABEL_NEW",True)'"Nou"
		Me.cmdNou.Text = lang.getText("LABEL_NEW",True)'"Nou"
		Me.lbNou.Text = lang.getText("LABEL_NEW_UPPER",True)'"NOU"
		Me.cmdPrimer.Text = lang.getText("LABEL_GOTO_FIRSH",True)'"Primer"
		Me.cmdPrevi.Text = lang.getText("LABEL_GOTO_PREV",True)'"Anterior"
		Me.cmdSeguent.Text = lang.getText("LABEL_GOTO_NEXT",True)'"Següent"
		Me.cmdUltim.Text = lang.getText("LABEL_GOTO_LAST",True)'"Últim"		
		Me.cmdBloqueix.Text = lang.getText("LABEL_BLOCK",True)'"Bloquejar"
		Me.cmdRefrescar.Text = lang.getText("LABEL_REFRESCAR",True)'"Refrescar"
		Me.OptionBuscar.Text = lang.getText("LABEL_SEARCH",True)'"Buscar"	
		
	
		Me.Label1.Text = lang.getText("Label1.Text") & ":"'"Buscar bloc musical:"
		Me.ColumnHeader1.Text = lang.getText("ColumnHeader1.Text") & " ..."'"Blocs disponibles ..."
		
		Me.chkOrderClassTemp.Text = lang.getText("chkOrderClassTemp.Text")'"Prioritzar cançons segons classificació temporal"
		Me.chkMusicWeb.Text = lang.getText("chkMusicWeb.Text")'"La audiència pot escollir les cançons (Web)"
		Me.Label8.Text = lang.getText("Label8.Text") & ":" '"Programa Associat:"
		Me.Label6.Text = lang.getText("LABEL_DATA_CREACIO",true) & ":" '"Data de creació:"
		Me.Label5.Text = lang.getText("LABEL_DESCRIPCIO",True) & ":" '"Descripció:"
		Me.Label4.Text = lang.getText("HEADERTEXT_TITOL",True) & ":"'"Títol:"
		Me.Label3.Text = lang.getText("Label3.Text")'"Arrossega els blocs per canviar l'ordre."
		Me.Label2.Text = lang.getText("LABEL_BLOCS_MUSIC",True) & ":"'"Blocs musicals:"
		Me.ColumnHeader2.Text = lang.getText("ColumnHeader2.Text")'"Títol bloc"
		Me.lbUtilCal.Text =  String.Format( LABEL_NUM_USED,0) '"Nº d'utilitzacions: 0"
		'Me.MenuStrip1.Text = lang.getText("MenuStrip1.Text")'"MenuStrip1"
		Me.ProgarmaToolStripMenuItem.Text = lang.getText("LABEL_PROGRAMA",True)'"Programa"
		
		
		Me.ColumnID.HeaderText = lang.getText("HEADERTEXT_ID",True)'"ID"
		Me.ColumnTitol.HeaderText = lang.getText("HEADERTEXT_TITOL",True)'"Titol"
		Me.ColumnComent.HeaderText = lang.getText("LABEL_COMMENT",True)'"Coment"
		Me.ColumnUltRadi.HeaderText = lang.getText("ColumnUltRadi.HeaderText")'"Data Ult Radi"
		Me.ColumnDataCrea.HeaderText = lang.getText("HEADERTEXT_DATE_CREA",True)'"Data Creació"
		Me.ColumnIDSessio.HeaderText = lang.getText("ColumnIDSessio.HeaderText")'"Prg Sessió"
		Me.ColumnMusicWeb.HeaderText = lang.getText("ColumnMusicWeb.HeaderText")'"Music Web"
		Me.ColumnClasTemp.HeaderText = lang.getText("ColumnClasTemp.HeaderText")'"OrdreTemp."
		Me.Label9.Text = lang.getText("Label9.Text")& ":"'"Seqüència:"
		Me.ColumnSequencia.HeaderText = Label9.Text '"Seqüència"
		Me.TabPage1.Text = lang.getText("LABEL_GENERAL",True)'"General"
		
		Me.TabPage2.Text = lang.getText("TabPage2.Text")'"Utilització de la pauta al calendari."
		'Me.ToolStrip1.Text = "ToolStrip1"
		
		Me.PerIDToolStripMenuItem.Text = lang.getText("mnu_Buscar_ID",True)'"Per ID"
		Me.PerNomToolStripMenuItem.Text = lang.getText("mnu_Buscar_NOM",True)'"Per Nom"
		Me.QualsevolToolStripMenuItem.Text = lang.getText("mnu_Buscar_QUALSEVOL",True)'"Qualsevol"
		Me.ProgramesAssociatsToolStripMenuItem.Text = lang.getText("ProgramesAssociatsToolStripMenuItem.Text")'"Programes associats"
		
		Me.Text = lang.getText("Text") '"Gestió de les Pautes"

        Dim Cmb As New combo
        Cmb.OmpleCombo(Me.ComboBoxSequencia, TAULES_DBS.TAULA_SEQUENCIES_PAUTA, TotsCap.NO_ADD)
    End Sub
	
	Private Sub refrescarLListaBlocs()
		
		Dim StrSql As String = "listbloc_titol LIKE '%" & Me.txtBuscaBloc.Text & "%'"
		Dim colec() As DataRow = dsClient.Tables("listblocs").Select(StrSql)
		
		Me.listBlocs.Items.Clear()
		Dim NewItem As ListViewItem
		For Each NewRow As DataRow In colec
			NewItem = Me.listBlocs.Items.Add(NewRow("listbloc_titol").ToString)
			NewItem.Tag = NewRow("listbloc_id").ToString
			NewItem.ToolTipText = NewRow("listbloc_coment").ToString
		Next NewRow
		colec = Nothing
	End Sub
	
	Private Sub cmdAddBloc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddBloc.Click
		AddItem()
	End Sub
	
	Private Sub Changed()        
		If blEnable = True Then Me.cmdSalvar.Enabled = True : mnuSave.Enabled = True
	End Sub
	
	Private Sub cmdDelBloc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelBloc.Click
		DeleteItem()
	End Sub
	
	Private Sub AddItem()
		Dim NewItem As ListViewItem
		Dim Item As Integer
		Try
			Item = Me.listBlocs.FocusedItem.Index
		Catch ex As Exception
			Item = 0
		End Try
		
		NewItem = Me.ListViewPauta.Items.Add(Me.listBlocs.Items.Item(Item).Text)
		NewItem.Tag = Me.listBlocs.Items.Item(Item).Tag
		NewItem.ToolTipText = Me.listBlocs.Items.Item(Item).ToolTipText
		
		Me.cmdDelBloc.Enabled = True
		Changed()
	End Sub
	
	Private Sub DeleteItem()
		Dim IdDel As Short
		Try
			IdDel = ListViewPauta.FocusedItem.Index
		Catch ex As Exception
			IdDel = ListViewPauta.Items.Count - 1
		End Try
		Me.ListViewPauta.Items.RemoveAt(IdDel)
		Me.cmdBorrar.Enabled = IIf(ListViewPauta.Items.Count, True, False)
		Changed()
	End Sub
	
	Private Sub listBlocs_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles listBlocs.DoubleClick
		If Me.cmdAddBloc.Enabled Then AddItem()
	End Sub
	
	Private Sub ListViewPauta_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListViewPauta.DoubleClick
		DeleteItem()
	End Sub

    Private Sub cmdBuscarBloc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscaBloc.ButtonClick
        refrescarLListaBlocs()
    End Sub

    Private Sub txtBuscaBloc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscaBloc.KeyPress
        If Asc(e.KeyChar) = 13 Then refrescarLListaBlocs()
    End Sub

    Private Sub LockedRecord(Optional ByVal saved As Boolean = False)
        If Me.cmdSalvar.Enabled = True And saved = False Then
            If MetroFramework.MetroMessageBox.Show(Me, MSG_SAVE_DADES, MSG_ATENCIO, MessageBoxButtons.OKCancel, MessageBoxIcon.Information, 100) = DialogResult.OK Then SaveRecord()

        End If
            Me.lbNou.Visible = False
        mblnNewDates = False
        blEnable = Not blEnable

        Me.cmdDelBloc.Enabled = blEnable
        Me.cmdBorrar.Enabled = blEnable
        cmdAddBloc.Enabled = blEnable
        'PanelDetall.Enabled = blEnable
        txtTitolPauta.Enabled = blEnable
        txtComent.Enabled = blEnable
        chkMusicWeb.Enabled = blEnable
        chkOrderClassTemp.Enabled = blEnable
        ComboBoxSequencia.Enabled = blEnable

        ListViewPauta.Enabled = blEnable
        Me.lbNou.Visible = False
        If blEnable Then
            Me.cmdBloqueix.Image = Me.picUnLock.Image
        Else
            Me.cmdBloqueix.Image = Me.picLock.Image
            Me.cmdSalvar.Enabled = False
        End If
    End Sub

    Private Sub cmbExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbExit.Click
        Me.Close()
    End Sub

    Private Sub DeleteRecord()

        Dim MsgTxt As String = MSG_CONFIRM_DELETE_DADES
        If gridDades.SelectedRows.Count > 1 Then MsgTxt = String.Format(MSG_CONFIRM_DELETE_NUM_DADES, gridDades.SelectedRows.Count)
        If MetroFramework.MetroMessageBox.Show(Me, MsgTxt, MSG_ATENCIO, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, 100) = DialogResult.Cancel Then Exit Sub
        Dim db As New MSC.dbs(Cloud)
        Dim StrSql As String = ""

        db.IniTransaction()
        For i As Short = 0 To gridDades.SelectedRows.Count - 1
            Dim ID As Integer = 0
            Try
                ID = CInt(gridDades.SelectedRows(i).Cells("ColumnID").Value)
                'No es pot borrar és de sistema
                If ID = 1 Then MetroFramework.MetroMessageBox.Show(Me, MSG_ERR_PAUTA_DEF_DETETE, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100) : Exit Sub
                'No es pot borrar una pauta si s'està fent servir a calendari
                If buscarDependencies(TAULES_DBS.TAULA_PAUTES, ID, Me) = True Then
                    Exit Sub
                End If
            Catch ex As Exception
                MetroFramework.MetroMessageBox.Show(Me, MSG_ERR_NAME_BLOC, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
                Exit Sub
            End Try
            'Borrar dbs
            StrSql = "DELETE FROM pautes_params WHERE list_pauta= " & ID & " ;"
            db.Delete_ID(StrSql)
            StrSql = "DELETE FROM listpautes WHERE listpauta_id= " & ID & " ;"
            db.Delete_ID(StrSql)
        Next
        db.EndTransaction()
        addCtlRadi(0, CShort(Tipus_Play.CTL_SQL), 0, "00:00:00", 0, 0, Usuari.UsrID, "DELETE FROM listpautes", 0, False)
        'Borrar llistat        
        lbRecCount.Text = CInt(lbRecCount.Text) - gridDades.SelectedRows.Count
        gridDades.AllowUserToDeleteRows = True
        For Each selectedrow As DataGridViewRow In gridDades.SelectedRows
            gridDades.Rows.Remove(selectedrow)
        Next
        db = Nothing
        gridDades.AllowUserToDeleteRows = False
        RefreshDataSet(TAULES_DBS.TAULA_PAUTES)
    End Sub

    Private Sub SaveRecord()
        If Not MyAPP.PermisPerContinuar() Then MetroFramework.MetroMessageBox.Show(Me, MSG_SERVER_CLOSE, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Stop, 100) : Me.Close()

        If MetroFramework.MetroMessageBox.Show(Me, MSG_CONFIRM_SAVE_DADES, MSG_ATENCIO, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, 100) = DialogResult.Cancel Then Exit Sub
        If ListViewPauta.Items.Count = 0 Then
            MetroFramework.MetroMessageBox.Show(Me, MSG_ERR_MIN_BLOC, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
            Exit Sub
        End If
        If Len(Me.txtTitolPauta.Text) = 0 Then
            MetroFramework.MetroMessageBox.Show(Me, MSG_ERR_NAME_BLOC, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
            Exit Sub
        End If
        Dim NomTaula As String = ""

        Dim Coment As String = SaveNul(AddSlashes(txtComent.Text))
        Dim Titol As String = AddSlashes(Me.txtTitolPauta.Text)
        Dim SessioID As Integer = Me.lbNomProgramSessio.Tag
        Dim MusicWeb As Boolean = Me.chkMusicWeb.Checked
        Dim OrderClassTemp As Boolean = Me.chkOrderClassTemp.Checked
        Dim SequencioID As Integer = Me.ComboBoxSequencia.SelectedValue
        Dim db As New MSC.dbs(Cloud)
        Dim StrSQL As String = ""

        If mblnNewDates Then
            StrSQL = "INSERT INTO listpautes (listpauta_titol ,listpauta_coment , listpauta_sessio, listpauta_musicweb, listpauta_orderclasstemp,listpauta_sequencia) "
            StrSQL = StrSQL & " VALUES "
            StrSQL = StrSQL & "( '" & Titol & "'"
            StrSQL = StrSQL & ", '" & Coment & "'"
            StrSQL = StrSQL & ", " & SessioID
            StrSQL = StrSQL & ", " & CShort(IIf(MusicWeb, 1, 0))
            StrSQL = StrSQL & ", " & CShort(IIf(OrderClassTemp, 1, 0))
            StrSQL = StrSQL & ", " & SequencioID
            StrSQL = StrSQL & ")"

            Dim NewId As Integer = db.New_ID(StrSQL)
            lbID.Text = NewId.ToString
            mblnNewDates = False
        Else
            StrSQL = "UPDATE listpautes SET "

            StrSQL = StrSQL & "listpauta_titol = '" & Titol & "'"
            If Coment.Length > 1 Then StrSQL = StrSQL & ",listpauta_coment = '" & Coment & "'"
            StrSQL = StrSQL & ",listpauta_sessio = " & SessioID
            StrSQL = StrSQL & ",listpauta_musicweb = " & CShort(IIf(MusicWeb, 1, 0))
            StrSQL = StrSQL & ",listpauta_orderclasstemp = " & CShort(IIf(OrderClassTemp, 1, 0))
            StrSQL = StrSQL & ", listpauta_sequencia = " & SequencioID
            StrSQL = StrSQL & " WHERE listpauta_id=" & Me.lbID.Text

            db.Update_ID(StrSQL)

            StrSQL = "DELETE FROM pautes_params WHERE list_pauta=" & Me.lbID.Text & " ;"
            db.Delete_ID(StrSQL)
        End If
        StrSQL = "INSERT INTO pautes_params (pauta_bloc,list_pauta) VALUES "
        For i As Integer = 0 To ListViewPauta.Items.Count - 1
            If i > 0 Then StrSQL = StrSQL & ", "
            StrSQL = StrSQL & " (" & ListViewPauta.Items.Item(i).Tag & ", " & lbID.Text & " )"
        Next i
        StrSQL = StrSQL & " ;"
        db.New_ID(StrSQL)


        LockedRecord(True)
        RefreshDataSet(TAULES_DBS.TAULA_PAUTES)

        MetroFramework.MetroMessageBox.Show(Me, MSG_SAVED_DATA, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information, 100)

        db = Nothing
    End Sub

    Private Sub ListViewPauta_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ListViewPauta.DragDrop
        'Realitzem desplaçaments dins la mateixa llista
        Dim liNew As System.Windows.Forms.ListViewItem
        Dim pinfo As ListViewHitTestInfo
        Dim pt As Point
        Dim pti As Point
        Dim hitItem As System.Windows.Forms.ListViewItem
        Dim i As Short
        Dim bNew As Boolean
        On Error Resume Next

        Dim position As New Point(e.X, e.Y)
        position = ListViewPauta.PointToClient(position)

        hitItem = ListViewPauta.HitTest(position).Item
        If hitItem Is Nothing Then
            liNew = ListViewPauta.Items.Insert(ListViewPauta.Items.Count, ListViewPauta.Text)
        Else
            liNew = ListViewPauta.Items.Insert(hitItem.Index, DragLV.Text)
        End If

        liNew.Tag = DragLV.Tag
        liNew.ImageKey = DragLV.ImageKey

        Do Until i = DragLV.SubItems.Count
            If liNew.SubItems.Count > i Then
                liNew.SubItems(i).Text = DragLV.SubItems(i).Text
            Else
                liNew.SubItems.Insert(i, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, DragLV.SubItems(i).Text))
            End If
            liNew.SubItems.Item(i).Tag = DragLV.SubItems.Item(i).Tag
            i = i + 1
        Loop
        ListViewPauta.Items.RemoveAt(DragLV.Index)
        liNew.Selected = True
        DragLV = Nothing
        Changed()
    End Sub

    Private Sub ListViewPauta_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ListViewPauta.DragEnter
        e.Effect = DragDropEffects.Move
    End Sub

    Private Sub ListViewPauta_ItemDrag(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles ListViewPauta.ItemDrag
        DoDragDrop(e.Item, DragDropEffects.Move)
    End Sub

    Private Sub ListViewPauta_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListViewPauta.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            DragLV = CType(sender, ListView).GetItemAt(e.X, e.Y)
        End If
    End Sub

    Private Sub txtTitolPauta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTitolPauta.TextChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells(1).Value = txtTitolPauta.Text
            Changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtComent_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtComent.TextChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells(2).Value = txtComent.Text
            Changed()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub NewRecord()

        Me.ListViewPauta.Items.Clear()
        Me.txtTitolPauta.Text = ""
        Me.txtComent.Text = ""
        Me.lbDataCreacio.Text = Now

        Dim StrSql As String = "SELECT Max(listpauta_id) FROM listpautes"
        Dim db As New MSC.dbs(Cloud)
        Me.lbID.Text = (CInt(db.ExecuteScalar(StrSql)) + 1).ToString
        gridDades.AllowUserToAddRows = True
        gridDades.FirstDisplayedScrollingRowIndex = gridDades.NewRowIndex
        db = Nothing
        LockedRecord()
        mblnNewDates = True
        Me.lbNou.Visible = True
    End Sub


    Private Sub establirRecordset(Optional ByVal WhereSql As String = "")
        System.Windows.Forms.Cursor.Current = Cursors.AppStarting
        Dim StrSql As String = "SELECT listpauta_id,listpauta_titol,listpauta_coment,listpauta_dataultradiacio,listpauta_datacreacio,listpauta_sessio,listpauta_musicweb,listpauta_orderclasstemp,listpauta_sequencia FROM listpautes"

        If WhereSql.Length > 0 Then StrSql = StrSql & " WHERE " & WhereSql

        Dim db As New MSC.dbs(Cloud)
        gridDades.DataSource = db.getTable(StrSql)
        db = Nothing
        Me.lbRecCount.Text = gridDades.Rows.Count
        If gridDades.Rows.Count = 0 Then MetroFramework.MetroMessageBox.Show(Me, MSG_NO_ITEM_FOR_CONDITION, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
        gridDades.Focus()

        cmdBloqueix.Enabled = IIf(gridDades.Rows.Count And Usuari.UsrTipus > NivellUsers.USR_CONVIDAT, True, False)
        Me.mnuModif.Enabled = cmdBloqueix.Enabled
        System.Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

    Private Sub listBlocs_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles listBlocs.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            Dim strText As String = strInfoFitxer(Tipus_Play.CTL_MUSICA, Me.listBlocs.FocusedItem.Tag, True)
            InfoMsg = New frmTip
            InfoMsg.ShowMessage(strText, MSG_MORE_INFO, IconStyles.Information, ContentAlignment.MiddleCenter, , , True, , , , , Themes.WinXpStyle, MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub listBlocs_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles listBlocs.MouseUp
        If e.Button = System.Windows.Forms.MouseButtons.Right Then InfoMsg.Close()
    End Sub

    Private Sub chkMusicWeb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMusicWeb.CheckedChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells(6).Value = chkMusicWeb.Checked
            Changed()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ComboBoxSequencia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxSequencia.SelectedIndexChanged
        Try
            Dim RowID As Integer = FindAfectatRow()
            Me.gridDades.Rows(RowID).Cells(8).Value = ComboBoxSequencia.SelectedValue
            Changed()
        Catch ex As Exception
        End Try

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

    Private Sub cmdSortir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub cmdRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefrescar.Click
        establirRecordset()
    End Sub

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionBuscar.Click
        Dim StrSql As String = ""
        establirRecordset(StrSql)
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

    Private Sub cmdNou_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNou.Click
        NewRecord()
    End Sub

    Private Sub cmdSortir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSortir.Click
        Me.Close()
    End Sub

#End Region


    Private Sub gridDades_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridDades.CurrentCellChanged
        ListViewPauta.Items.Clear()
        Try
            'Dades de la llista de pautes
            If blEnable = True Then LockedRecord()
            Me.lbID.Text = gridDades.CurrentRow.Cells(0).Value
            Me.txtTitolPauta.Text = StripSlashes(NoNul(gridDades.CurrentRow.Cells(1).Value.ToString))
            Me.txtComent.Text = StripSlashes(NoNul(gridDades.CurrentRow.Cells(2).Value.ToString))
            Me.chkMusicWeb.Checked = gridDades.CurrentRow.Cells(6).Value
            Me.chkOrderClassTemp.Checked = gridDades.CurrentRow.Cells(7).Value
            Me.lbDataCreacio.Text = NoNul(gridDades.CurrentRow.Cells(4).Value.ToString)
            Me.ComboBoxSequencia.SelectedValue = gridDades.CurrentRow.Cells(8).Value

            Dim Id_Sessio As Integer = gridDades.CurrentRow.Cells(5).Value
            Dim StrSql As String = "ses_ID =" & Id_Sessio.ToString
            Dim colecSessio() As DataRow = dsClient.Tables("prg_sessions").Select(StrSql)
            If colecSessio.Length > 0 Then
                Dim Id_prg As Integer = colecSessio(0)("ses_prg")
                lbNomProgramSessio.Text = getNomPrograma(Id_prg)
                lbNomProgramSessio.Tag = Id_Sessio
            Else
                lbNomProgramSessio.Text = ""
                lbNomProgramSessio.Tag = 0
            End If
            colecSessio = Nothing
            ' Detall dels blocs emprats a la pauta.
            StrSql = "SELECT * FROM pautes_params WHERE list_pauta=" & lbID.Text
            Dim db As New MSC.dbs(Cloud)
            Dim rs As DataTable
            ' Accedeix directament a la pauta_params            
            rs = db.getTable(StrSql)
            ListViewPauta.Items.Clear()
            If rs.Rows.Count Then
                Dim NewItem As ListViewItem
                For i As Integer = 0 To rs.Rows.Count - 1
                    Dim BlocID As Short = rs.Rows(i)("pauta_bloc")
                    NewItem = Me.ListViewPauta.Items.Add(getNomBloc(BlocID))
                    NewItem.Tag = BlocID
                Next i
            End If
            db = Nothing
            rs.Dispose()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub TabControl1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If TabControl1.SelectedIndex = 1 Then
            ' Mostra info del calendari------------------
            Dim StrSql As String
            Dim StrSqlCal As String = "cal_pauta = " & Me.lbID.Text
            Dim list() As DataRow = dsClient.Tables("calendari").Select(StrSqlCal)
            lbUtilCal.Text = String.Format(LABEL_NUM_USED, list.Length)
            lstOnUtilitza.Items.Clear()
            For Each NewRow As DataRow In list
                StrSql = ""
                Dim DataPauta As Date = NewRow("cal_data").ToString
                If NewRow("cal_tipassig") Then
                    ' Per Data i Hora
                    StrSql = StrSql + " Data: " & vbTab & Strings.Format(DataPauta, "long Date")
                    StrSql = StrSql + vbTab & " Hora: " & DataPauta.ToString("HH")
                Else
                    ' Per Dia de la setmana i Hora
                    Dim StrDiaSetmena As String = getNomDiaSetmana(DataPauta.DayOfWeek) 'DataPauta
                    StrSql = StrSql + " Dia Setmana: " & vbTab & WeekdayName(Weekday(DataPauta, FirstDayOfWeek.Monday), False, FirstDayOfWeek.Monday)
                    If Len(StrDiaSetmena) < 8 Then StrSql = StrSql + vbTab
                    StrSql = StrSql + vbTab & " Hora: " & vbTab & DataPauta.ToString("HH")
                End If
                Me.lstOnUtilitza.Items.Add(StrSql)
            Next NewRow
            list = Nothing
        End If
    End Sub

    Private Sub txtBuscar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.GotFocus
		txtBuscar.Text = ""
	End Sub
	
	Private Sub txtBuscar_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuscar.KeyUp
		If e.KeyCode = Keys.Enter Then FindRecord()
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
				StrSql = "listpauta_id = " & txtBuscar.Text
			Case Buscar.BUSCAR_NOM
				StrSql = "listpauta_titol LIKE '%" & txtBuscar.Text & "%'"
			Case Buscar.BUSCAR_TOTS
				StrSql = "listpauta_titol LIKE '%" & txtBuscar.Text & "%' OR listpauta_id = " & txtBuscar.Text
		End Select
		establirRecordset(StrSql)
	End Sub
	
	Private Sub ProgramesAssociatsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgramesAssociatsToolStripMenuItem.Click
		establirRecordset("listpauta_sessio>0")
	End Sub
	
	Private Function FindAfectatRow() As Integer
		If mblnNewDates Then
			Return gridDades.NewRowIndex
		Else
			Return gridDades.CurrentRow.Index
		End If
	End Function
	
	Private Sub chkOrderClassTemp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOrderClassTemp.CheckedChanged
		Try
			Dim RowID As Integer = FindAfectatRow()
			Me.gridDades.Rows(RowID).Cells(7).Value = chkOrderClassTemp.Checked
			Changed()
		Catch ex As Exception
		End Try
		
	End Sub
	
	Private Sub mnu_Help_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_Help.Click
		Dim Proces As Process = New Process
		Try
			Process.Start(MSC.Help.HELP_GEST_AUTOMATITZACIO_PAUTES.ToString)
		Catch ex As Exception
		End Try
	End Sub

    Private Sub frmPautes_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        Dim FitxerINI As New IniFile
        frm_sice(0) = Me.Width : frm_sice(1) = Me.Height
        FitxerINI.INIWrite(MyAPP.IniFile, "Data Gest", "size", frm_sice(0).ToString & "," & frm_sice(1).ToString)
    End Sub
End Class