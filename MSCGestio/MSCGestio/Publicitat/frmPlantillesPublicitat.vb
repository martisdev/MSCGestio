
Public Partial Class frmPlantillesPublicitat
	
	Dim Blocs(6, 95) As Boolean
	Friend ID_TO_EDIT As Integer 	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
			
	End Sub
	
	Sub FrmPlantillesPublicitatLoad(sender As Object, e As EventArgs) Handles MyBase.Load
		setLanguageForm()
		If ID_TO_EDIT= 0 Then
			Me.lbNEW.Visible = True			
			Me.txtNomPlantilla.select()							  
		Else			
			Me.lbNEW.Visible = False			
			'search template
			Dim condi As String = "template_id = " & ID_TO_EDIT
			Dim rows() As DataRow = dsClient.Tables("adv_templates").Select(condi) 
			Me.txtNomPlantilla.Text = rows(0)("template_name").ToString 
			Dim retvalue As String = rows(0)("template_values").ToString
			
			deleteBlocs()
			Dim valorsArray() As String = Split (rows(0)("template_values").ToString,",")
			
			For i As Integer= 0 To valorsArray.Length -1
				Dim dia As Integer = valorsArray(i).Substring(0,1)
				Dim bloc As Integer = valorsArray(i).Substring(1,2)
				Blocs(dia,bloc)= True				
			Next
			actualitzarListBlocs()
		End If
		Me.cmdSalvar.Enabled = False
	End Sub
		
	Public Sub setLanguageForm()
		lang.StrForm = Me.Name
		
		Me.TabPage3.Text = lang.getText("NAME_DILLUNS",True)'"Dilluns"
		Me.TabPage4.Text = lang.getText("NAME_DIMARTS",True)'"Dimarts"
		Me.TabPage5.Text = lang.getText("NAME_DIMECRES",True)'"Dimecres"
		Me.TabPage6.Text = lang.getText("NAME_DIJOUS",True)'"Dijous"
		Me.TabPage7.Text = lang.getText("NAME_DIVENDRES",True)'"Divendres"
		Me.TabPage8.Text = lang.getText("NAME_DISSABTE",True)'"Dissabte"
		Me.TabPage9.Text = lang.getText("NAME_DIUMENGE",True)'"Diumenge"		
		Me.Label39.Text = lang.getText("LABEL_HORES",True)'"Hores"				
		Me.lbNom.Text = lang.getText("LABEL_NOM",True)& ":"' nom
		
		Me.Label38.Text = lang.getText("Label38.Text")'"Blocs"
		Me.lbNEW.Text = lang.getText("LABEL_NEW_UPPER",True)'"NEW"
		Me.Text =  lang.getText("Text")''"Plantilles Publicitat"
		refreshFrangesHora(TabCtlDies.SelectedIndex + 1)
	End Sub
		
	
	Sub TabCtlDiesMouseUp(sender As Object, e As MouseEventArgs) Handles TabCtlDies.MouseUp
		PanelDia.Parent = TabCtlDies.TabPages(TabCtlDies.SelectedIndex)
		actualitzarListBlocs()
		refreshFrangesHora(TabCtlDies.SelectedIndex + 1)		
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
	
	Sub TxtNomPlantillaTextChanged(sender As Object, e As EventArgs) Handles txtNomPlantilla.TextChanged
		Me.cmdSalvar.Enabled = True
	End Sub
	
	Sub CmdExitClick(sender As Object, e As EventArgs) Handles cmdExit.Click
		Me.Close()
	End Sub
	
	Sub CmdExitToolClick(sender As Object, e As EventArgs) Handles cmdExitTool.Click
		Me.Close()
	End Sub
	
	Private Sub deleteBlocs()
		For day As Integer = 0 To 6 'Monday is 0
			For n_bloc As Integer = 0 To 95
				Blocs(day,n_bloc)= False
			Next
		Next
	End Sub
	
	Private sub actualitzarListBlocs()	
		Dim dia As Short = Me.TabCtlDies.SelectedIndex
		Dim i As Short
		For i = 0 To 95
			Dim NomCheck As String = "CheckBox" & i + 1
			CType(PanelBlocs.Controls(NomCheck), CheckBox).Checked = Blocs(dia, i)
		Next i
	End Sub
	
	Sub CheckBox96Click(sender As Object, e As EventArgs) Handles CheckBox96.Click, CheckBox95.Click, CheckBox94.Click, CheckBox93.Click, CheckBox92.Click, CheckBox91.Click, CheckBox90.Click, CheckBox9.Click, CheckBox89.Click, CheckBox88.Click, CheckBox87.Click, CheckBox86.Click, CheckBox85.Click, CheckBox84.Click, CheckBox83.Click, CheckBox82.Click, CheckBox81.Click, CheckBox80.Click, CheckBox8.Click, CheckBox79.Click, CheckBox78.Click, CheckBox77.Click, CheckBox76.Click, CheckBox75.Click, CheckBox74.Click, CheckBox73.Click, CheckBox72.Click, CheckBox71.Click, CheckBox70.Click, CheckBox7.Click, CheckBox69.Click, CheckBox68.Click, CheckBox67.Click, CheckBox66.Click, CheckBox65.Click, CheckBox64.Click, CheckBox63.Click, CheckBox62.Click, CheckBox61.Click, CheckBox60.Click, CheckBox6.Click, CheckBox59.Click, CheckBox58.Click, CheckBox57.Click, CheckBox56.Click, CheckBox55.Click, CheckBox54.Click, CheckBox53.Click, CheckBox52.Click, CheckBox51.Click, CheckBox50.Click, CheckBox5.Click, CheckBox49.Click, CheckBox48.Click, CheckBox47.Click, CheckBox46.Click, CheckBox45.Click, CheckBox44.Click, CheckBox43.Click, CheckBox42.Click, CheckBox41.Click, CheckBox40.Click, CheckBox4.Click, CheckBox39.Click, CheckBox38.Click, CheckBox37.Click, CheckBox36.Click, CheckBox35.Click, CheckBox34.Click, CheckBox33.Click, CheckBox32.Click, CheckBox31.Click, CheckBox30.Click, CheckBox3.Click, CheckBox29.Click, CheckBox28.Click, CheckBox27.Click, CheckBox26.Click, CheckBox25.Click, CheckBox24.Click, CheckBox23.Click, CheckBox22.Click, CheckBox21.Click, CheckBox20.Click, CheckBox2.Click, CheckBox19.Click, CheckBox18.Click, CheckBox17.Click, CheckBox16.Click, CheckBox15.Click, CheckBox14.Click, CheckBox13.Click, CheckBox12.Click, CheckBox11.Click, CheckBox10.Click, CheckBox1.Click
		Dim Dia As Short = Me.TabCtlDies.SelectedIndex
		Dim NumBloc As Short = CType(sender, CheckBox).TabIndex
		Blocs(Dia, NumBloc) = CType(sender, CheckBox).Checked
		Me.cmdSalvar.Enabled = True
	End Sub
	
	Sub CmdSalvarClick(sender As Object, e As EventArgs) Handles cmdSalvar.Click
        Dim db As New MSC.dbs(Cloud)
        Dim StrSql As String 
		If Me.txtNomPlantilla.Text.Length< 1 Then
			MsgBox(MSG_ERROR_NOM, MsgBoxStyle.Critical,MSG_ATENCIO)
			Me.txtNomPlantilla.Focus ()
			Exit Sub
		End If
		dim NomBloc As String = AddSlashes(txtNomPlantilla.Text) 
		Dim StringBloc As String = BlocsToString()
		If ID_TO_EDIT= 0 Then
			'New	
			StrSql = "INSERT INTO adv_templates (`template_name`,`template_values`) VALUES ('" & NomBloc & "','" & StringBloc & "');"
			ID_TO_EDIT = db.New_ID(StrSql)
		Else
			'update
			StrSql = "UPDATE adv_templates SET template_name= '" & NomBloc & "', template_values= '" & StringBloc & "' WHERE template_id= " & ID_TO_EDIT & " ;"
			db.Update_ID(StrSql)
		End If
		Me.cmdSalvar.Enabled = False		
		RefreshDataSet(TAULES_DBS.TAULA_ADV_TEMPLATES)
		db = Nothing
		Me.DialogResult = System.Windows.Forms.DialogResult.OK
		Me.Close()
	End Sub
	Private Function BlocsToString() As String
		Dim tempStr As String = "" 
		For day As Integer = 0 To 6 'Monday is 0
			For n_bloc As Integer = 0 To 95
				If Blocs(day,n_bloc)= True Then
					If tempStr.Length > 0 Then tempStr += "," 					 
					tempStr += 	day.ToString  & n_bloc.ToString("00") 	
				End If
			Next
		Next
		Return tempStr
	End function
End Class
