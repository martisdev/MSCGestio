
Public Class frmCtlBlocs
	Private DragLV As System.Windows.Forms.ListViewItem 'The item being dragged
	Dim Changed As Boolean = False
	
	Private Sub CloseForm(ByVal e As System.Windows.Forms.FormClosingEventArgs)
		If Changed = True Then SalvarBlocAmbOrdre()
		If ListBuffer.Items.Count > 0 Then
			If MsgBox(MSG_PUBLI_NO_ASSIGNADA, vbOKCancel,MSG_ATENCIO) = MsgBoxResult.Cancel Then
				e.Cancel = True
				ListBuffer.Select()
				Exit Sub
			End If
		End If
		MyAPP.CloseSesionClient(MyAPP.IDSesion_Client, DESCRIP_FORM_CTL_PUBLICITAT)
		Me.Dispose()
	End Sub
	
	Private Sub frmCtlBlocs_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		CloseForm(e)
	End Sub
	
	Private Sub frmCtlBlocs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		setLanguageForm()
		Dim cmb As New combo
		cmb.OmpleCombo(Me.cmbListHores, TAULES_DBS.TAULA_BlocsPublicitat, TotsCap.NO_ADD)		
		txtDataDadiacio.Value = Now
		
	End Sub
	
	Dim MSG_PUBLI_NO_ASSIGNADA As String
	Dim MSG_ERROR_BLOC As String 
	Dim MSG_ERROR_SELECT_PUBLI As String 
	Dim MSG_PUBLI_TO_DIF_FANJA As String 
	
	Public Sub setLanguageForm()
		lang.StrForm = Me.Name
		
		MSG_PUBLI_NO_ASSIGNADA = lang.getText("MSG_PUBLI_NO_ASSIGNADA")'"Hi ha publicitat sense assignar a cap bloc, voleu continuar sortint?"
		MSG_ERROR_BLOC = lang.getText("MSG_ERROR_BLOC")'"S'ha d'assignar un bloc."
		MSG_ERROR_SELECT_PUBLI = lang.getText("MSG_ERROR_SELECT_PUBLI")'"S'ha de sel·leccionar una publicitat per poder-la moure."
		MSG_PUBLI_TO_DIF_FANJA = lang.getText("MSG_PUBLI_TO_DIF_FANJA")'"S'assignarà la falca a diferent franja horària (diferent preu) de la inicialment prevista, vols continuar?"
		
		Me.ColumnHeader1.Text = lang.getText("LABEL_NOM",True)
		Me.ColumnHeader2.Text =  lang.getText("HEADERTEXT_CLIENT",True)'"Client"
		Me.ColumnHeader3.Text = lang.getText("LABEL_PRODUCTE",True)'"Producte"
		Me.ColumnHeader4.Text = lang.getText("HEADERTEXT_LOCUTOR",True)'"Locutor"
		Me.ColumnHeader5.Text = lang.getText("HEADERTEXT_DURADA",True)'"Durada"
		Me.ColumnHeader7.Text = lang.getText("LABEL_NOM",True)'"Nom"
		Me.ColumnHeader8.Text = lang.getText("HEADERTEXT_CLIENT",True)'"Client"
		Me.ColumnHeader9.Text = lang.getText("LABEL_PRODUCTE",True)'"Producte"
		Me.ColumnHeader10.Text = lang.getText("HEADERTEXT_LOCUTOR",True)'"Locutor"
		Me.ColumnHeader11.Text = lang.getText("HEADERTEXT_DURADA",True)'"Durada"
		
		Me.Label7.Text = lang.getText("Label7.Text")'"Bloc de publicitat"
		Me.Label6.Text = lang.getText("Label6.Text")'"Seleccionar dia:"
		Me.lbFrange.Text = lang.getText("lbFrange.Text")'"Franja"
		Me.ColumnHeader6.Text = lang.getText("ColumnHeader6.Text")'"Bloc Inicial"
		Me.ColumnHeader12.Text = lang.getText("ColumnHeader12.Text")'"Bloc Inicial"
		Me.Label3.Text = lang.getText("Label3.Text")'"Falques del bloc seleccionat"
		Me.Label4.Text = lang.getText("Label4.Text")'"Falques pendents d'assignar a un bloc ( No salvades)"
		Me.Label5.Text = lang.getText("Label5.Text")'"Arrossega les falques per establir l'ordre correlatiu dins del bloc en el qual han de sonar."
		Me.Text = lang.getText("Text")'"Control dels blocs publicitaris"
		
		
	End Sub
	
	Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
		
		Me.Close()
	End Sub
	
	Private Sub AddPubliFromBloc()
		Dim DateEsp As Date
		Dim Origen As String
		Dim rsDisp As DataTable
		Dim DataRadi As Date, DiaSem As Integer, Bloc As String
		Dim Frange As Object
		Dim Locutor As String
		
		If Changed = True Then SalvarBlocAmbOrdre() ' Abans, es procedirà a salvar l'anterior bloc.
		
		If Len(cmbListHores.Text) = 0 Then Exit Sub
		
		DataRadi = txtDataDadiacio.Value
		DateEsp = CDate( DateSerial(DataRadi.Year, DataRadi.Month, DataRadi.Day) & " " & Strings.Left(cmbListHores.Text, 2) & ":00")
		
		lbFrange.BackColor = CType( Choose(getBackColorFranHorFromDataHora(DateEsp) + 1, Color.Snow, Color.MistyRose, Color.LightSalmon, Color.Salmon, Color.DarkSalmon, Color.Tomato, Color.LightCoral, Color.Coral, Color.OrangeRed, Color.Red),System .Drawing .Color )
		
		Me.lbFrange.Text = Me.cmbListHores.Text
		
		DiaSem = Weekday(DataRadi, vbMonday)
		Bloc = cmbListHores.SelectedValue.ToString 
		'Bloc = Replace(Me.lbFrange.Text, ":", "")
		
		If Len(Bloc) = 0 Then
			MsgBox(MSG_ERROR_BLOC, MsgBoxStyle.Critical,MSG_ATENCIO)
			Exit Sub
		End If
		Me.ListBlocs.Items.Clear()
		Origen = "SELECT falques.falc_id, falques.falc_nom, clients.cli_nom, producte.produc_nom, falques.falc_locutor, falques.falc_durada "
		Origen = Origen + "FROM ((clients INNER JOIN falques ON clients.cli_id = falques.falc_client) "
		Origen = Origen + "INNER JOIN producte ON falques.falc_producte = producte.produc_id) "
		Origen = Origen + "INNER JOIN radiaciofalques" & DiaSem & " ON falques.falc_id = radiaciofalques" & DiaSem & ".radiID"
		Origen = Origen + " WHERE (((radiaciofalques" & DiaSem & "." & Bloc & ")= 1 ) AND ((falques.falc_datain)<= '" & Strings.Format(DataRadi, "yyyy/MM/dd") & "') AND ((falques.falc_dataout)>= '" & Strings.Format(DataRadi, "yyyy/MM/dd") & "' AND falques.falc_activa=1)) ORDER BY radiaciofalques" & DiaSem & ".radiOrdre ;"
		
		Dim db As New MSC.dbs
		rsDisp = db.getTable(Origen)
		For i As Integer = 0 To rsDisp.Rows.Count - 1
			Dim id As Integer = CInt(rsDisp.Rows(i)(0))
			Dim Nom As String = rsDisp.Rows(i)(1).ToString
			Dim Client As String = rsDisp.Rows(i)(2).ToString
			Dim Product As String = rsDisp.Rows(i)(3).ToString
			Dim IdLocutor As Integer = CInt(rsDisp.Rows(i)(4))
			Locutor = getNomLocutor(IdLocutor)
			Dim Durada As Date = CDate(rsDisp.Rows(i)(5).ToString)
			Dim StrDurada As String = Strings.Format(Durada, "mm:ss")
			Frange = Me.lbFrange.BackColor
			addLineListBlocs(id, Nom, Client, Product, Locutor, StrDurada)
		Next i
		db = Nothing
		rsDisp.Dispose()
		
		' Aixó només ho farem si la data és de futur
		Dim DataActual As Date = Today
		Dim HoraActual As Date = Now
		If DataActual > DataRadi Then
			Me.cmdAddBuffer.Enabled = False
		ElseIf DataActual = DateSerial(DataRadi.Year, DataRadi.Month, DataRadi.Day) Then
			If TimeSerial(HoraActual.Hour, HoraActual.Minute, 0) < TimeSerial(CShort(Strings.Left(lbFrange.Text, 2)), CShort(Strings.Right(HoraActual.Minute.ToString , 2)), 0) Then
				Me.cmdAddBuffer.Enabled = CBool(IIf(rsDisp.Rows.Count>0, IIf(Usuari.UsrTipus>0, True, False), False))
			Else
				Me.cmdAddBuffer.Enabled = False
			End If
		ElseIf DataActual < DataRadi Then
			Me.cmdAddBuffer.Enabled = CBool(IIf(rsDisp.Rows.Count>0, IIf(Usuari.UsrTipus>0, True, False), False))
		End If
		Me.ListBlocs.AllowDrop = (cmdAddBuffer.Enabled And ListBlocs.Items.Count > 1)
	End Sub
	
	Private Sub addLineListBlocs(ByVal id As Integer, ByVal Nom As String, ByVal Client As String, ByVal Product As String, ByVal Locutor As String, ByVal Durada As String, Optional ByVal IniBloc As String = "")
		Dim NewItem As ListViewItem
		
		NewItem = Me.ListBlocs.Items.Add(Nom)
		NewItem.Tag = id
		NewItem.SubItems.Insert(1, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, Client))
		NewItem.SubItems.Insert(2, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, Product))
		NewItem.SubItems.Insert(3, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, Locutor))
		NewItem.SubItems.Insert(4, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, Durada))
		If Len(IniBloc) > 0 Then NewItem.SubItems.Insert(5, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, IniBloc))
		
	End Sub
	
	Private Sub SalvarBlocAmbOrdre()
		Dim DiaSem As Integer = Weekday(txtDataDadiacio.Value, vbMonday)
		Dim Bloc As String = Me.cmbListHores.SelectedValue.ToString 
		Dim id As Integer
		Dim FalcIndex As Integer
		Dim db As New MSC.dbs
		Dim sCmd As String = ""
		For FalcIndex = 0 To ListBlocs.Items.Count - 1
			id = CInt(Me.ListBlocs.Items.Item(FalcIndex).Tag)
			
			sCmd = "UPDATE radiaciofalques" & DiaSem
			sCmd = sCmd & " SET "
			sCmd = sCmd & " " & Bloc & " = 1"
			sCmd = sCmd & ", radiOrdre = " & FalcIndex
			sCmd = sCmd & " WHERE radiID = " & id & " ;"
			db.Update_ID(sCmd)
		Next
		db = Nothing
		Changed = False
	End Sub
	
	Private Sub ListBlocsHores_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
		Try
			AddPubliFromBloc()
		Catch ex As Exception
			
		End Try
	End Sub
	
	Private Sub cmdAddBuffer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddBuffer.Click
		Dim id As Integer, Nom As String, Client As String, Product As String, Durada As String
		Dim idOrdre As Short = 0
		Dim DiaSem As Integer
		Dim Bloc As String
		Dim Locutor As String
		
		Try
			If Me.ListBlocs.FocusedItem Is Nothing Then
				idOrdre = 0
				id = CInt(Me.ListBlocs.Items(idOrdre).Tag)
			Else
				idOrdre = CShort(Me.ListBlocs.FocusedItem.Index)
				id = CInt(Me.ListBlocs.FocusedItem.Tag)
			End If
		Catch ex As Exception
			MsgBox(MSG_ERROR_SELECT_PUBLI, MsgBoxStyle.Exclamation, MSG_ATENCIO)
			Me.ListBlocs.Focus()
			Exit Sub
		End Try
		
		Nom = Me.ListBlocs.Items(idOrdre).Text
		Client = Me.ListBlocs.Items(idOrdre).SubItems(1).Text
		Product = Me.ListBlocs.Items(idOrdre).SubItems(2).Text
		Locutor = Me.ListBlocs.Items(idOrdre).SubItems(3).Text
		Durada = Me.ListBlocs.Items(idOrdre).SubItems(4).Text
		
		addLineListBuffer(id, Nom, Client, Product, Locutor, Durada)
		'borra els antics valors-----
		DiaSem = Weekday(txtDataDadiacio.Value, vbMonday)
		Bloc = Me.cmbListHores.SelectedValue.ToString 
		'Bloc = "radi" & Replace(Me.lbFrange.Text, ":", "")
		Dim db As New MSC.dbs
		Dim sCmd As String = "UPDATE radiaciofalques" & DiaSem
		sCmd = sCmd & " SET "
		sCmd = sCmd & "  " & Bloc & " = 0" '& CShort(IIf(piVal, 1, 0))
		sCmd = sCmd & ", radiOrdre = 50"
		sCmd = sCmd & " WHERE radiID = " & id & " ;"
		db.Update_ID(sCmd)
		db = Nothing
		'----------------------------
		Me.ListBlocs.Items.RemoveAt(ListBlocs.Items(idOrdre).Index)
		Me.cmdAddBlocs.Enabled = True
		txtDataDadiacio.Enabled = False
		If Me.ListBlocs.Items.Count = 0 Then
			Me.cmdAddBuffer.Enabled = False
		End If
		Me.ListBlocs.AllowDrop = (cmdAddBuffer.Enabled And ListBlocs.Items.Count > 1)
		cmbListHores.Focus()
	End Sub
	
	Private Sub cmdAddBlocs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddBlocs.Click
		Dim id As Integer
		Dim idOrdre As Short = 0
		Dim Frange As Color
		Try
			If Me.ListBuffer.FocusedItem Is Nothing Then
				idOrdre = 0
				id = CInt(Me.ListBuffer.Items(idOrdre).Tag)
			Else
				idOrdre = CShort(Me.ListBuffer.FocusedItem.Index)
				id = CInt(Me.ListBuffer.FocusedItem.Tag)
			End If
		Catch ex As Exception
			
			MsgBox(MSG_ERROR_SELECT_PUBLI, MsgBoxStyle.Exclamation, MSG_ATENCIO)
			Me.ListBuffer.Focus()
			Exit Sub
		End Try
		Frange = CType(Me.ListBuffer.Items(idOrdre).SubItems(1).Tag,Color)
		If Frange <> Me.lbFrange.BackColor Then
			If MsgBox(MSG_PUBLI_TO_DIF_FANJA, vbOKCancel, MSG_ATENCIO) = vbCancel Then Exit Sub
		End If
		
		Dim Nom As String = Me.ListBuffer.Items(idOrdre).Text
		Dim Client As String = Me.ListBuffer.Items(idOrdre).SubItems(1).Text
		Dim Product As String = Me.ListBuffer.Items(idOrdre).SubItems(2).Text
		Dim Locutor As String = Me.ListBuffer.Items(idOrdre).SubItems(3).Text
		Dim Durada As String = Me.ListBuffer.Items(idOrdre).SubItems(4).Text
		Dim IniBloc As String = Me.ListBuffer.Items(idOrdre).SubItems(5).Text
		
		addLineListBlocs(id, Nom, Client, Product, Locutor, Durada, IniBloc)
		Me.ListBuffer.Items.RemoveAt(ListBuffer.Items(idOrdre).Index)
		
		Me.cmdAddBuffer.Enabled = True
		If Me.ListBuffer.Items.Count = 0 Then
			Me.cmdAddBlocs.Enabled = False
			txtDataDadiacio.Enabled = True
		End If
		Me.ListBlocs.AllowDrop = (cmdAddBuffer.Enabled And ListBlocs.Items.Count > 1)        
		SalvarBlocAmbOrdre()
		cmbListHores.Focus()
	End Sub
	
	Private Sub addLineListBuffer(ByVal id As Integer, ByVal Nom As String, ByVal Client As String, ByVal Product As String, ByVal Locutor As String, ByVal Durada As String)
		Dim NewItem As ListViewItem
		Dim BackColor As Color
		
		BackColor = Me.lbFrange.BackColor
		
		NewItem = Me.ListBuffer.Items.Add(Nom)
		NewItem.Tag = id
		NewItem.SubItems.Insert(1, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, Client))
		NewItem.SubItems(1).Tag = BackColor
		NewItem.SubItems.Insert(2, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, Product))
		NewItem.SubItems.Insert(3, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, Locutor))
		NewItem.SubItems.Insert(4, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, Durada))
		NewItem.SubItems.Insert(5, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, Me.lbFrange.Text))
	End Sub
	
	Private Sub ListBlocs_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ListBlocs.DragDrop
		'Realitzem desplaçaments dins la mateixa llista
		Dim liNew As System.Windows.Forms.ListViewItem
		Dim pinfo As ListViewHitTestInfo
		Dim pt As Point
		Dim pti As Point
		Dim hitItem As System.Windows.Forms.ListViewItem
		
		Dim bNew As Boolean
		On Error Resume Next
		
		Dim position As New Point(e.X, e.Y)
		position = ListBlocs.PointToClient(position)
		
		hitItem = ListBlocs.HitTest(position).Item
		If hitItem Is Nothing Then
			liNew = ListBlocs.Items.Insert(ListBlocs.Items.Count, ListBlocs.Text)
		Else
			liNew = ListBlocs.Items.Insert(hitItem.Index, DragLV.Text)
			
		End If
		
		liNew.Tag = DragLV.Tag
		liNew.ImageKey = DragLV.ImageKey
		Dim i As Integer 
		Do Until i = DragLV.SubItems.Count
			If liNew.SubItems.Count > i Then
				liNew.SubItems(i).Text = DragLV.SubItems(i).Text
			Else
				liNew.SubItems.Insert(i, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, DragLV.SubItems(i).Text))
			End If
			liNew.SubItems.Item(i).Tag = DragLV.SubItems.Item(i).Tag
			i += 1
		Loop
		ListBlocs.Items.RemoveAt(DragLV.Index)
		liNew.Selected = True
		DragLV = Nothing
		Changed = True
		
	End Sub
	
	Private Sub ListBlocs_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ListBlocs.DragEnter
		e.Effect = DragDropEffects.Move
	End Sub
	
	Private Sub ListBlocs_ItemDrag(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles ListBlocs.ItemDrag
		DoDragDrop(e.Item, DragDropEffects.Move)
	End Sub
	
	Private Sub ListBlocs_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBlocs.MouseDown
		If e.Button = system.Windows.Forms.MouseButtons.Left Then
			DragLV = CType(sender, ListView).GetItemAt(e.X, e.Y)
		End If
	End Sub
	
	Private Sub cmbListHores_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbListHores.SelectedIndexChanged
		Try
			AddPubliFromBloc()
		Catch ex As Exception
			
		End Try
	End Sub
	
End Class