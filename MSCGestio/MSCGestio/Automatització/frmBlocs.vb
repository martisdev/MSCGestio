Option Strict Off
Option Explicit On

Public Class frmBlocs
	Dim blEnable As Boolean
	Dim mblnNouBloc As Boolean
	Private DragLV As System.Windows.Forms.ListViewItem 'The item being dragged
	Dim InfoMsg As frmTip
	
	Dim Tolerancia As Short = 0
	
	Private Sub CloseForm()
        If Me.cmdSalvar.Enabled Then
            If MetroFramework.MetroMessageBox.Show(Me, MSG_SAVE_MODIF, MSG_ATENCIO, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, 100) = DialogResult.OK Then SaveRecord()
        End If
            MyAPP.CloseSesionClient(MyAPP.IDSesion_Client, DESCRIP_FORM_BLOCS)
		Me.Dispose()
	End Sub
	
	Private Sub frmBlocs_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		CloseForm()
	End Sub
	
	Private Sub cmdExitTool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExitTool.Click
		Me.Close()
	End Sub
	
	Private Sub TabClasBloc_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TabClasBloc.MouseDown
		
	End Sub
	
	Private Sub TabClasBloc_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TabClasBloc.MouseUp
		
		TabBlocs.Parent = TabClasBloc.TabPages(TabClasBloc.SelectedIndex)
		refrescarTabBlocs(Me.TabClasBloc.SelectedIndex + 1)
		RefrescarCarpeta()
	End Sub
	
	Private Sub frmBlocs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		setLanguageForm()
		If My.Settings.TXT_CAPITALIZE Then
			Me.txtComent.CharacterCasing = CharacterCasing.Upper
			Me.txtTitol.CharacterCasing = CharacterCasing.Upper
		End If
		Tolerancia = Params.IntervRitme
		
		Dim NomCarp() As String = Split(Params.NomsCarpetaBlocs, ",")
		For i As Integer = 0 To NomCarp.Length - 1
			If i = 0 Then
				TabClasBloc.TabPages(0).Text = IIf(NomCarp(i).Length > 0, NomCarp(i).ToString, "Genèrics")
			Else
                If NomCarp(i).Length > 0 Then TabClasBloc.TabPages.Add(NomCarp(i).ToString)
            End If
			Dim mnuEnvia As ToolStripMenuItem
			mnuEnvia = New ToolStripMenuItem
			mnuEnvia.Text = NomCarp(i)
			mnuEnvia.Tag = i+1
			mnuEnvia.Visible = True
			mnuEnviarBloc.DropDownItems.Add(mnuEnvia)
			
			AddHandler mnuEnvia.Click, AddressOf mnuEnviarBloc_Click			
		Next



        Me.cmdBloqueix.Enabled = IIf(Usuari.UsrTipus > NivellUsers.USR_CONVIDAT, True, False)
		Me.mnuModif.Enabled = Me.cmdBloqueix.Enabled
		Me.cmdNou.Visible = IIf(Usuari.UsrTipus, True, False)
		
		Me.mnuNew.Visible = Me.cmdNou.Visible
        Me.ClientSize = New Size(frm_sice(0), frm_sice(1))
    End Sub
	
	Dim MSG_SAVE_MODIF As String = ""
	Dim VALUE_CAP As String = ""
	Dim LABEL_NOU_BLOC As String = ""
	Dim MSG_ERR_IMPUT_LINE_BLOC As String = ""
	Dim MSG_ERR_DELETE_PROHIBIT As String = ""
	Dim MSG_DELETE_BLOC_NAME As String = ""
    Dim MSG_ERR_MOVE_PROHIBIT As String = ""


    Public Sub setLanguageForm()
		lang.StrForm = Me.Name
		
		MSG_SAVE_MODIF = lang.getText("MSG_SAVE_MODIF")'"Vols salvar les modificacions?"
		MSG_ERR_IMPUT_LINE_BLOC = lang.getText("MSG_ERR_IMPUT_LINE_BLOC")'"S'han d'entrar valors, al meny a una línia del bloc"
		MSG_ERR_DELETE_PROHIBIT = lang.getText("MSG_ERR_DELETE_PROHIBIT")'"Aquest Bloc és de sistema, no es pot borrar"
		MSG_ERR_MOVE_PROHIBIT = lang.getText("MSG_ERR_MOVE_PROHIBIT")'"Aquest bloc no es pot moure"
		MSG_DELETE_BLOC_NAME = lang.getText("MSG_DELETE_BLOC_NAME")'"Segur que vol borrar el bloc anomenat: {0}?"
		VALUE_CAP = lang.getText("VALUE_CAP",True)'"<CAP>"
		LABEL_NOU_BLOC = lang.getText("LABEL_NOU_BLOC")'"Nou Bloc"
		
		Me.cmdExitTool.ToolTipText = lang.getText("LABEL_TANCAR_PANTALLA",True)'"Tancar pantalla"
		Me.cmdNou.Text = lang.getText("cmdNou.Text")'"Nou bloc musical"
		Me.cmdBloqueix.Text = lang.getText("LABEL_EDITAR",True)'"Editar"
		Me.cmdDel.Text = lang.getText("cmdDel.Text")'"Borrar bloc musical"
		Me.cmdDel.ToolTipText = lang.getText("LABEL_ESBORRAR_FITXER",True)'"esborrar fitxer"
		Me.cmdSalvar.Text = lang.getText("cmdSalvar.Text")'"salvar bloc musical"
		Me.ToolStripLabel1.Text = lang.getText("ToolStripLabel1.Text") & ":"'"Localitzar bloc musical:"
		Me.mnuEnviarBloc.Text = lang.getText("mnuEnviarBloc.Text") & " ..."'"Enviar a ..."
		Me.TabPage3.Text = lang.getText("TabPage3.Text")'"Pauta defecte"
		Me.grupBloc.Text = lang.getText("grupBloc.Text")'"Dades del bloc seleccionat"
		Me.cmdAddineBloc.Text = lang.getText("cmdAddineBloc.Text")'"Nova linea de filtre"
		Me.lbPrincipal.Text = lang.getText("lbPrincipal.Text")'"Aquest bloc (BLOC PRINCIPAL) no es pot borrar (sí canviar els seus paràmetres)."
		Me.Label3.Text = lang.getText("LABEL_DATA_CREACIO",True) & ":"'"Data de creació:"
		Me.Label2.Text = lang.getText("LABEL_DESCRIPCIO",True) & ":"'"Descripció:"
		Me.TabPage4.Text = lang.getText("TabPage4.Text")'"Detall Bloc"
		
		Me.ColumnID.HeaderText = lang.getText("HEADERTEXT_ID",True)'"ID"
		Me.ColumnEstil.HeaderText = lang.getText("HEADERTEXT_ESTIL",True)'"Estils"
		Me.ColumnTemp.HeaderText = lang.getText("HEADERTEXT_CLAS_TEMP",True)'"Temporalitat"
		Me.ColumnSubjec.HeaderText = lang.getText("HEADERTEXT_SUBJECT",True)'"Clas. Subjectiva"
		Me.ColumnRitme.HeaderText = lang.getText("HEADERTEXT_RITME",True)'"Ritme"
		Me.ColumnIdioma.HeaderText = lang.getText("HEADERTEXT_IDIOMA",True)'"Idioma"
		Me.ColumnRestric.HeaderText = lang.getText("LABEL_RETRICCIO",True) '"Restricció"

        Me.TabPage8.Text = lang.getText("TabPage8.Text") '"Veure disponibilitat de temes"

        Me.ColumnTitol.HeaderText = lang.getText("HEADERTEXT_TITOL",True)'"Titol"
		Me.ColumnInterp.HeaderText = lang.getText("HEADERTEXT_INTERP",True)'"Intèrpret"
		Me.ColumnDurada.HeaderText = lang.getText("HEADERTEXT_DURADA",True)'"Durada"
		Me.ColumnDisc.HeaderText = lang.getText("HEADERTEXT_DISC",True)'"Disc"
		Me.Column1.HeaderText = lang.getText("HEADERTEXT_ID",True)'"ID"
		
		Me.Label4.Text = lang.getText("Label4.Text") & ":"'"Nº de cançons disponibles:"
		Me.Label1.Text = lang.getText("HEADERTEXT_TITOL",True)& ":"'"Títol:"
		Me.ldNou.Text = lang.getText("LABEL_NEW_UPPER",True)'"NOU"
		Me.ProgarmaToolStripMenuItem.Text = lang.getText("LABEL_PROGRAMA",True)'"Programa"
		Me.mnuExit.Text = lang.getText("LABEL_EXIT",True)'"Sortir"
		Me.EdicióToolStripMenuItem.Text = lang.getText("mnuEdit.Text",True)'"Edició"
		Me.mnuModif.Text = lang.getText("LABEL_MODIFICAR",True)'"Modificar"
		Me.mnuNew.Text = lang.getText("LABEL_NEW",True)'"Nou"
		Me.mnuSave.Text = lang.getText("LABEL_SALVAR",True)'"Salvar"
		Me.mnuDel.Text = lang.getText("LABEL_DELETE",True)'"Borrar"
		Me.AjudaToolStripMenuItem.Text = lang.getText("mnu_Help",True)'"Ajuda"
		Me.mnu_Help.Text = lang.getText("mnuRefHelp.Text", True) '"Manual OnLine"
        Me.label5.Text = lang.getText("Label5.Text") 'Tecla "SUPR" per eliminar linea seleccionada.

        Me.Text = lang.getText("Text") '"Gestió dels BLocs"
        Dim cmb As New combo
        cmb.OmpleCombo(Me.ColumnEstil, TAULES_DBS.TAULA_ESTILS, TotsCap.TOTS)
        cmb.OmpleCombo(Me.ColumnIdioma, TAULES_DBS.TAULA_IDIOMES, TotsCap.TOTS)
        cmb.OmpleCombo(Me.ColumnTemp, TAULES_DBS.TAULA_TEMPORALITAT, TotsCap.TOTS)
        cmb.OmpleCombo(Me.ColumnSubjec, TAULES_DBS.TAULA_SUBJECTIV, TotsCap.TOTS)
        cmb.OmpleCombo(Me.ColumnRestric, TAULES_DBS.TAULA_RESTRICCIONS, TotsCap.NO_ADD)

        cmb.OmpleCombo(ComboBlocs, TAULES_DBS.TAULA_BLOCS_MUSICALS, TotsCap.CAP) : ComboBlocs.SelectedValue = 1

    End Sub
	
	Private Sub ActualitCarpeta()
		'Només per fer recerques des del combobox
		If Me.ComboBlocs.Text <> VALUE_CAP And Val(ComboBlocs.SelectedValue) > 0 Then
			Dim StrSql As String = "listbloc_id = " & ComboBlocs.SelectedValue
            Dim rowsListBlocs() As DataRow = dsClient.Tables("listblocs").Select(StrSql)
            Dim IndT1 As Integer = rowsListBlocs(0)("listbloc_clasbloc") - 1
			Me.TabClasBloc.SelectTab(IndT1)
			TabBlocs.Parent = TabClasBloc.TabPages(IndT1)
			refrescarTabBlocs(IndT1 + 1)
			Dim IndT2 As Integer = rowsListBlocs(0)("listbloc_id")
			For i As Integer = 0 To TabBlocs.TabPages.Count - 1
				If Me.TabBlocs.TabPages(i).Tag = IndT2 Then
					Me.TabBlocs.SelectTab(i)
                    grupBloc.Parent = Me.TabBlocs.TabPages(i)
                    grupBloc.BackColor = System.Drawing.Color.Transparent
                    Call RefrescarCarpeta()
					Exit For
				End If
			Next i
		End If
	End Sub
	
	Private Sub RefrescarCarpeta()
		blEnable = True
		LockedRecord()        
		If TabBlocs.SelectedTab.Tag = Nothing Then
			borraPantalla()
			Exit Sub
		End If
		
		Dim StrSql As String = "listbloc_id = " & Me.TabBlocs.SelectedTab.Tag
		StrSql = StrSql + " AND listbloc_clasbloc = " & TabClasBloc.SelectedIndex + 1
		Dim rowsListBlocs() As DataRow = dsClient.Tables("listblocs").Select(StrSql)
		
		If rowsListBlocs.Length = 0 Then exit Sub 
		
		Me.lbID.Text = rowsListBlocs(0)("listbloc_id").ToString
		lbPrincipal.Visible = IIf(lbID.Text = 1, True, False)
		Me.txtTitol.Text = StripSlashes(rowsListBlocs(0)("listbloc_titol").ToString)
		Me.txtComent.Text = StripSlashes(rowsListBlocs(0)("listbloc_coment").ToString)
		Me.lbDataCreacio.Text = rowsListBlocs(0)("listbloc_datacreacio").ToString
		
		StrSql = "SELECT bloc_id,bloc_estil,bloc_temp,bloc_subj,bloc_ritme,bloc_idioma,bloc_restric FROM blocs_params WHERE list_bloc_id=" & Me.TabBlocs.SelectedTab.Tag & " ;"
        Dim db As New MSC.dbs(Cloud)
        DataGridViewFiltre.DataSource = db.getTable(StrSql)
		db = Nothing
	End Sub
	
	Private Sub refrescarTabBlocs(ByVal ClasBloc As Integer)
		
		Dim i As Integer = 0
		Dim StrSql As String = "listbloc_clasbloc = " & ClasBloc
		Dim rowsListBlocs() As DataRow = dsClient.Tables("listblocs").Select(StrSql, "listbloc_id ASC")
		Me.TabBlocs.TabPages.Clear()
		If rowsListBlocs.Length = 0 Then
			Me.TabBlocs.TabPages.Add(0, "")
			grupBloc.Visible = False
		Else
			For Each NewRow As DataRow In rowsListBlocs
				Me.TabBlocs.TabPages.Add(i, NewRow("listbloc_titol").ToString)
				Me.TabBlocs.TabPages.Item(i).Tag = NewRow("listbloc_id").ToString
				Me.TabBlocs.TabPages.Item(i).ToolTipText = NewRow("listbloc_coment").ToString
				i = i + 1
			Next NewRow
			grupBloc.Visible = True
		End If
		grupBloc.Parent = Me.TabBlocs.TabPages.Item(0)
		
		rowsListBlocs = Nothing
		
	End Sub
	
	Private Sub cmdBloqueix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBloqueix.Click
		LockedRecord()
	End Sub
	
	Private Sub LockedRecord(Optional ByVal saved As Boolean = False)
        If Me.cmdSalvar.Enabled = True And saved = False Then
            If MetroFramework.MetroMessageBox.Show(Me, MSG_SAVE_DADES, MSG_ATENCIO, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, 100) = MsgBoxResult.Ok Then SaveRecord()
        End If
        blEnable = Not blEnable
		
		'Me.grupBloc.Enabled = blEnable
		txtTitol.Enabled = blEnable
		txtComent.Enabled = blEnable
		cmdAddineBloc.Enabled = blEnable
		DataGridViewFiltre.ReadOnly = Not blEnable
		DataGridViewFiltre.AllowUserToAddRows = blEnable
		DataGridViewFiltre.AllowUserToDeleteRows = blEnable
		
		Me.cmdDel.Enabled = blEnable
		
		mnuEnviarBloc.Enabled = blEnable
		mblnNouBloc = False
		Me.ldNou.Visible = False
		If blEnable Then
			Me.cmdBloqueix.Image = Me.picUnLock.Image
		Else
			Me.cmdBloqueix.Image = Me.picLock.Image
			Me.cmdSalvar.Enabled = False
		End If
	End Sub
	
	Private Sub NouBloc()
		
		lbPrincipal.Visible = False
		borraPantalla()
		'DataGridViewFiltre.AllowUserToAddRows = True
		blEnable = False
		LockedRecord()
		
		mblnNouBloc = True
		Me.ldNou.Visible = True
		TabBlocs.TabPages(TabBlocs.SelectedIndex).Text = LABEL_NOU_BLOC
		
		For i As Integer = 0 To DataGridViewFiltre.Rows.Count - 1
			Try
				DataGridViewFiltre.Rows.RemoveAt(0)
			Catch ex As Exception
				Exit Sub
			End Try
		Next
		
		Me.txtTitol.Focus()
	End Sub
	
	Private Sub borraPantalla()
		Me.txtTitol.Text = ""
		Me.txtComent.Text = ""
		Me.lbID.Text = 0
		Me.lbDataCreacio.Text = Now
		'Me.ComboBlocs.SelectedValue = 0
		'Me.DataGridViewFiltre.DataSource = Nothing
	End Sub
	
	Private Sub txtRitme_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
		Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
		If KeyAscii < Asc("0") Or KeyAscii > Asc("9") Then If KeyAscii <> 8 Then KeyAscii = 0
		e.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			e.Handled = True
		End If
	End Sub
	
	Private Sub comboEstil_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles _
		ComboBlocs.KeyPress
		e.KeyChar = UCase(e.KeyChar)
	End Sub
	
	
	Private Sub Changed()
		If blEnable = True Then Me.cmdSalvar.Enabled = True : mnuSave.Enabled = True
	End Sub
	
	Private Sub TabBlocs_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TabBlocs.MouseUp
		grupBloc.Parent = Me.TabBlocs.TabPages(TabBlocs.SelectedIndex)
		RefrescarCarpeta()
	End Sub
	
	Private Sub ComboBlocs_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBlocs.KeyUp
		Select Case e.KeyCode
			Case Keys.Left, Keys.Right, Keys.Up, Keys.Down
				Return
		End Select
		Dim MyComboBox As ComboBox = CType(sender, ComboBox)
		Dim Origen As TAULES_DBS = TAULES_DBS.TAULA_BLOCS_MUSICALS
		
		refreshComboBoxKeyUp(MyComboBox, Origen, TotsCap.CAP)
	End Sub
	
	Private Sub Combo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBlocs.LostFocus
		Dim MyComboBox As ComboBox = CType(sender, ComboBox)
		Dim ID As Integer = MyComboBox.SelectedValue
		Dim Origen As TAULES_DBS = TAULES_DBS.TAULA_BLOCS_MUSICALS
		Dim cmb As New combo
		cmb.OmpleCombo(MyComboBox, Origen, TotsCap.CAP)
		MyComboBox.SelectedValue = ID
	End Sub
	
	Private Sub ComboBlocs_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBlocs.SelectedIndexChanged
		ActualitCarpeta()
	End Sub
	
	Private Sub SaveRecord()
		Dim Titol, Coment As String
		Dim DataCrea As Date
		Dim piClasBloc As Short
        Dim BlocID As Integer = CInt(Me.lbID.Text)

        If Not MyAPP.PermisPerContinuar() Then MetroFramework.MetroMessageBox.Show(Me, MSG_SERVER_CLOSE, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Stop, 100) : Me.Close()


        If MetroFramework.MetroMessageBox.Show(Me, MSG_SAVE_DADES, MSG_ATENCIO, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, 100) = MsgBoxResult.Cancel Then Exit Sub
        If Me.DataGridViewFiltre.RowCount = 0 Then
            MetroFramework.MetroMessageBox.Show(Me, MSG_ERR_IMPUT_LINE_BLOC, MSG_ATENCIO, MessageBoxButtons.OKCancel, MessageBoxIcon.Error, 100)
            Exit Sub
        End If

        Titol = AddSlashes(Me.txtTitol.Text)
		If Len(Titol) = 0 Then Titol = " "
		Coment = AddSlashes(Me.txtComent.Text)
		If Len(Coment) = 0 Then Coment = " "
		DataCrea = CDate(Me.lbDataCreacio.Text)
		
		piClasBloc = TabClasBloc.SelectedIndex + 1
        Dim db As New MSC.dbs(Cloud)
        Dim StrSql As String = ""
		If mblnNouBloc Then
			StrSql = "INSERT INTO listblocs ( listbloc_titol, listbloc_coment, listbloc_datacreacio, listbloc_clasbloc)"
			StrSql = StrSql & " VALUES "
			StrSql = StrSql & " ( '" & Titol & "'"
			StrSql = StrSql & ", '" & Coment & "'"
			StrSql = StrSql & ", '" & Now.ToString("yyyy-MM-dd HH:mm:ss") & "'"
			StrSql = StrSql & ", " & piClasBloc
			StrSql = StrSql & ");"
			
			BlocID = db.New_ID(StrSql)
			StrSql = "INSERT INTO blocs_params (list_bloc_id) VALUES (" & BlocID & ");"
			db.ExecuteInstruc(StrSql)
		Else
			StrSql = "UPDATE listblocs"
			StrSql = StrSql & " SET"
			StrSql = StrSql & " listbloc_titol = '" & Titol & "'"
			StrSql = StrSql & ", listbloc_coment = '" & Coment & "'"
			StrSql = StrSql & ", listbloc_clasbloc = " & piClasBloc
			StrSql = StrSql & " WHERE listbloc_id = " & BlocID & " ;"
			
			db.Update_ID(StrSql)
			StrSql = "DELETE FROM blocs_params WHERE list_bloc_ID=" & BlocID
            db.ExecuteInstruc(StrSql)
            addCtlRadi(0, CShort(Tipus_Play.CTL_SQL), 0, "00:00:00", 0, 0, Usuari.UsrID, StrSql, 0, False)
        End If
		'Omple els blocs
		DataGridViewFiltre.AllowUserToAddRows = False
		
		StrSql = "INSERT INTO blocs_params ( bloc_estil, bloc_temp "
		StrSql = StrSql & ", bloc_subj, bloc_ritme, bloc_idioma, bloc_restric,list_bloc_id)"
		StrSql = StrSql & " VALUES "
		
		For i As Integer = 0 To DataGridViewFiltre.RowCount - 1
			Dim Estil As Short = 0
			Dim Temp As Short = 0
			Dim Subj As Short = 0
			Try
				Estil = DataGridViewFiltre.Rows(i).Cells("ColumnEstil").Value
				Temp = DataGridViewFiltre.Rows(i).Cells("ColumnTemp").Value
				Subj = DataGridViewFiltre.Rows(i).Cells("ColumnSubjec").Value
			Catch ex As Exception
				Exit For
			End Try
			Dim Ritme As Short = 0
			Try
				Ritme = DataGridViewFiltre.Rows(i).Cells("ColumnRitme").Value
			Catch ex As Exception
				Ritme = 0
			End Try
			Dim Idioma As Short = DataGridViewFiltre.Rows(i).Cells("ColumnIdioma").Value
			Dim Restric As Short = 0
			Try
				Restric = DataGridViewFiltre.Rows(i).Cells("ColumnRestric").Value
			Catch ex As Exception
				
			End Try
			
			If i > 0 Then StrSql = StrSql & ", "
			StrSql = StrSql & "( " & Estil
			StrSql = StrSql & ", " & Temp
			StrSql = StrSql & ", " & Subj
			StrSql = StrSql & ", " & Ritme
			StrSql = StrSql & ", " & Idioma
			StrSql = StrSql & ", " & Restric
			StrSql = StrSql & ", " & BlocID
			StrSql = StrSql & ")"
		Next
		StrSql = StrSql & ";"
		db.New_ID(StrSql)
		db = Nothing
		DataGridViewFiltre.AllowUserToAddRows = True
		'End Omple els blocs
		
		LockedRecord(True)
		RefreshDataSet(TAULES_DBS.TAULA_LIST_BLOCS)
		Dim cmb As New combo
		cmb.OmpleCombo(ComboBlocs, TAULES_DBS.TAULA_BLOCS_MUSICALS, TotsCap.CAP) : ComboBlocs.SelectedValue = 0
		ComboBlocs.SelectedIndex = ComboBlocs.FindStringExact(Titol)
		
		If mblnNouBloc Then refrescarTabBlocs(piClasBloc)
		
	End Sub
	
	Private Sub cmdNou_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNou.Click
		NouBloc()
	End Sub
	
	Private Sub cmdSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalvar.Click
		SaveRecord()
	End Sub
	
	Private Sub DeleteRecord()
		Dim idBloc As Short
		Dim TitolBloc As String
		Dim PautUtilitz As String = ""
		TitolBloc = Me.txtTitol.Text
		idBloc = CShort(Me.lbID.Text)
        If idBloc = 1 Then
            MetroFramework.MetroMessageBox.Show(Me, MSG_ERR_DELETE_PROHIBIT, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
            Exit Sub
        End If
        If MetroFramework.MetroMessageBox.Show(Me, String.Format(MSG_DELETE_BLOC_NAME, TitolBloc), MSG_ATENCIO, MessageBoxButtons.YesNo, MessageBoxIcon.Question, 100) = MsgBoxResult.No Then Exit Sub

        Dim StrSql As String = "DELETE FROM listblocs WHERE listbloc_id=" & idBloc
        Dim db As New MSC.dbs(Cloud)
        db.Delete_ID(StrSql)
        addCtlRadi(0, CShort(Tipus_Play.CTL_SQL), 0, "00:00:00", 0, 0, Usuari.UsrID, StrSql, 0, False)
        StrSql = "DELETE FROM blocs_params WHERE list_bloc_id=" & idBloc
        db.Delete_ID(StrSql)
        db = Nothing
		RefreshDataSet(TAULES_DBS.TAULA_LIST_BLOCS)
		Dim cmb As New combo
		cmb.OmpleCombo(ComboBlocs, TAULES_DBS.TAULA_BLOCS_MUSICALS, TotsCap.CAP) : ComboBlocs.SelectedValue = 0
		ComboBlocs.SelectedIndex = 0
		
		refrescarTabBlocs(TabClasBloc.SelectedIndex + 1)
	End Sub
	
	Private Sub cmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDel.Click
		DeleteRecord()
	End Sub

    Private Sub TabDetall_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TabDetall.MouseUp
        If TabDetall.SelectedIndex = 1 Then
            Dim StrSql As String = ""
            Dim Origen As String
            Dim Estil As Short = 0
            Dim Temp As Short = 0
            Dim Subject As Short = 0
            Dim Ritme As Short = 0
            Dim Idioma As Short = 0
            Dim Restric As Short = 0
            Try
                Estil = DataGridViewFiltre.CurrentRow.Cells(1).Value
            Catch ex As Exception
                Estil = 0
            End Try
            Try
                Temp = DataGridViewFiltre.CurrentRow.Cells(2).Value
            Catch ex As Exception
                Temp = 0
            End Try
            Try
                Subject = DataGridViewFiltre.CurrentRow.Cells(3).Value
            Catch ex As Exception
                Subject = 0
            End Try
            Try
                Ritme = DataGridViewFiltre.CurrentRow.Cells(4).Value
            Catch ex As Exception
                Ritme = 0
            End Try
            Try
                Idioma = DataGridViewFiltre.CurrentRow.Cells(5).Value
            Catch ex As Exception
                Idioma = 0
            End Try
            Try
                Restric = DataGridViewFiltre.CurrentRow.Cells(6).Value
            Catch ex As Exception
                Restric = 0
            End Try

            If Estil > 0 Then

                If Len(StrSql) > 0 Then StrSql = StrSql & " AND "
                Dim sCmd As String = "style_relationships_tipfitxer = " & Tipus_Fitxers.FITXER_MUSICA & " AND `style_relationships_style` = " & Estil
                Dim colec() As DataRow = dsClient.Tables("style_relationships").Select(sCmd)
                Dim LocalStrSql As String = "("
                For i As Integer = 0 To colec.Length - 1
                    If LocalStrSql.Length > 3 Then LocalStrSql += " OR "
                    Dim tema_id As Integer = colec(i)("style_relationships_fitxer").ToString
                    LocalStrSql += "tema_id = " & tema_id
                Next
                StrSql += LocalStrSql & ")"
            End If
            If Idioma > 0 Then
                If Len(StrSql) > 0 Then StrSql = StrSql & " AND "
                StrSql = StrSql & " temes.tema_idioma = " & Idioma
            End If
            If Temp > 0 Then
                If Len(StrSql) > 0 Then StrSql = StrSql & " AND "
                StrSql = StrSql & " temes.tema_temps = " & Temp
            End If
            If Subject > 0 Then
                If Len(StrSql) > 0 Then StrSql = StrSql & " AND "
                StrSql = StrSql & " temes.tema_subj = " & Subject
            End If
            If Ritme > 0 Then
                If Len(StrSql) > 0 Then StrSql = StrSql & " AND "

                Dim VarRitme1 As Short = Ritme - Tolerancia
                Dim VarRitme2 As Short = Ritme + Tolerancia
                StrSql = StrSql & " (temes.tema_ritme BETWEEN " & VarRitme1 & " AND " & VarRitme2 & ")"
            End If
            If Restric = 0 Then
                If Len(StrSql) > 0 Then StrSql = StrSql & " AND "
                StrSql = StrSql & " temes.tema_restric = 0"
            ElseIf Restric = 2 Then
                If Len(StrSql) > 0 Then StrSql = StrSql & " AND "
                StrSql = StrSql & " temes.tema_restric = 1"
            End If

            If Len(StrSql) > 0 Then StrSql = StrSql & " AND "
            StrSql = StrSql & " temes.tema_pautain = 1 "

            Origen = "SELECT temes.tema_id, temes.tema_titol, interprets.interp_nom, temes.tema_durada, discos.disc_nom"
            Origen = Origen & " FROM interprets INNER JOIN (discos INNER JOIN temes"
            Origen = Origen & " ON discos.disc_id = temes.tema_disc) ON interprets.interp_id = temes.tema_interp "
            Origen = Origen & " WHERE " & StrSql
            Origen = Origen & " ORDER BY temes.tema_id ;"
            Dim db As New MSC.dbs(Cloud)
            DataGridViewTemes.DataSource = db.getTable(Origen)
            lbRecCount.Text = DataGridViewTemes.Rows.Count.ToString
            db = Nothing
        End If
    End Sub

    'Private Sub ListTemes_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    '    If e.Button = Windows.Forms.MouseButtons.Right Then
    '        Dim Tipus As Tipus_Play, id As Integer
    '        Dim Caracters As String
    '        Dim strText As String
    '        On Error Resume Next

    '        Tipus = Tipus_Play.CTL_MUSICA
    '        id = ListTemes.FocusedItem.Tag
    '        strText = strInfoFitxer(Tipus, id)
    '        InfoMsg = New frmTip
    '        InfoMsg.ShowMessage(strText, "Més info ..", IconStyles.Information, ContentAlignment.MiddleCenter, , , True, , , , , Themes.WinXpStyle, MessageBoxButtons.OK)
    '    End If
    'End Sub

    'Private Sub ListTemes_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    '    If e.Button = Windows.Forms.MouseButtons.Right Then
    '        InfoMsg.Close()
    '    End If
    'End Sub

    Private Sub cmbExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbExit.Click
        Me.Close()
    End Sub

    Private Sub mnuEnviarBloc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim idBloc As Short = Me.lbID.Text
        If idBloc = 1 Then
            MetroFramework.MetroMessageBox.Show(Me, MSG_ERR_MOVE_PROHIBIT, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
            Exit Sub
        End If
        Dim ClasBlocCanvi As Short = CType(sender, ToolStripMenuItem).Tag

        Dim db As New MSC.dbs(Cloud)
        Dim StrSql As String = "UPDATE listblocs"
        StrSql = StrSql & " SET  listbloc_clasbloc = " & ClasBlocCanvi
        StrSql = StrSql & " WHERE listbloc_id = " & idBloc & " ;"
        db.Update_ID(StrSql)
        db = Nothing
        RefreshDataSet(TAULES_DBS.TAULA_LIST_BLOCS)
        TabBlocs.Parent = TabClasBloc.TabPages(TabClasBloc.SelectedIndex)
        refrescarTabBlocs(Me.TabClasBloc.SelectedIndex + 1)
        RefrescarCarpeta()

    End Sub

    Private Sub DataGridViewFiltre_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewFiltre.CellValueChanged
        Changed()
    End Sub

    Private Sub txtTitol_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTitol.TextChanged
        Changed()
        If mblnNouBloc = True Then TabBlocs.TabPages(TabBlocs.SelectedIndex).Text = txtTitol.Text
    End Sub

    Private Sub txtComent_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtComent.TextChanged
        Changed()
    End Sub

    Private Sub DataGridViewTemes_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            Dim Tipus As Tipus_Play, id As Integer
            Dim Caracters As String
            Dim strText As String
            On Error Resume Next

            Tipus = Tipus_Play.CTL_MUSICA
            'TODO: falta la columna id
            id = DataGridViewTemes.CurrentRow.Cells(0).Value
            strText = strInfoFitxer(Tipus, id)
            InfoMsg = New frmTip
            InfoMsg.ShowMessage(strText, "Més info ..", IconStyles.Information, ContentAlignment.MiddleCenter, , , True, , , , , Themes.WinXpStyle, MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub DataGridViewTemes_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            InfoMsg.Close()
        End If
    End Sub

#Region "nemú estandard (funcions bàsiques)"

    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub

    Private Sub mnuNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNew.Click
        NouBloc()
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

    Private Sub DataGridViewFiltre_UserDeletedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs)
        Changed()
    End Sub

    Private Sub DataGridViewFiltre_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGridViewFiltre.DataError

    End Sub

    Private Sub mnu_Help_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_Help.Click
		Dim Proces As Process = New Process
		Try
			Process.Start(MSC.Help.HELP_GEST_AUTOMATITZACIO_BLOCS.ToString)
		Catch ex As Exception
		End Try
	End Sub

    Private Sub frmBlocs_Leave(sender As Object, e As EventArgs) Handles Me.Leave

    End Sub

    Private Sub frmBlocs_ResizeEnd(sender As Object, e As EventArgs) Handles MyBase.ResizeEnd
        Dim FitxerINI As New IniFile
        frm_sice(0) = Me.Width : frm_sice(1) = Me.Height
        FitxerINI.INIWrite(MyAPP.IniFile, "Data Gest", "size", frm_sice(0).ToString & "," & frm_sice(1).ToString)
    End Sub
End Class