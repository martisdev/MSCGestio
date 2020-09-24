'
' Creado por SharpDevelop.
' Usuario: Marti
' Fecha: 30/03/2016
' Hora: 08:46
' 
' Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
'
Public Partial Class frmSelectItem
	Public ID_SELECT As Integer 
	dim StrCondi As String 
	dim StrToFind As String
	dim TypeOption As Short 
	Const TYPE_ESTIL As Integer = 0
	Const TYPE_INTERP As Integer = 1

    Public Sub New(opcio As Integer, strSql As String, nameTofind As String)
        ' The Me.InitializeComponent call is required for Windows Forms designer support.
        Me.InitializeComponent()
        TypeOption = opcio
        StrToFind = nameTofind
        StrCondi = strSql
        setLanguageForm()
        loadCombos()
    End Sub

    Sub ComboBoxOptionsMouseDoubleClick(sender As Object, e As MouseEventArgs)
		OptionSelected()
	End Sub

    Sub CmdTancarClick(sender As Object, e As EventArgs) Handles CmdTancar.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Sub CmdOkClick(sender As Object, e As EventArgs) Handles cmdOk.Click
        OptionSelected()
    End Sub

    Private Sub OptionSelected()
		ID_SELECT = CInt(Me.comboBoxOptions.SelectedValue)
		Me.DialogResult = system.Windows.Forms.DialogResult.OK
		Me.Close()
	End Sub
	
	Public Sub setLanguageForm()
		
		lang.StrForm = Me.Name
		Me.Label1.Text = lang.getText("Label1.Text") & " -> " & StrToFind '"Selecciona la opció que s'ajusta més"	
		Me.label2.Text =  lang.getText("Label2.Text") 'Cancelar equival a crear-lo nou
		Me.Text =  lang.getText("Text") 'Selecciona una opció
		
	End Sub
	
	
	Sub FrmSelectItemLoad(sender As Object, e As EventArgs)
		'setLanguageForm()		 		
		'loadCombos()		
	End Sub
	
	Private Sub loadCombos()
				Dim Cmb As New combo
		Select TypeOption
			Case TYPE_ESTIL: Cmb.OmpleCombo(comboBoxOptions, TAULES_DBS.TAULA_ESTILS, TotsCap.NO_ADD,StrCondi) 
			Case TYPE_INTERP: Cmb.OmpleCombo(comboBoxOptions, TAULES_DBS.TAULA_INTERPRETS, TotsCap.NO_ADD,StrCondi) 
		End Select		
		
	End Sub
		
	Sub ComboBoxOptionsKeyUp(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Enter Then 
			Select TypeOption
				Case TYPE_ESTIL: StrCondi = "estil_nom LIKE '%" & Me.comboBoxOptions.Text  & "%' "
				Case TYPE_INTERP: StrCondi = "interp_nom LIKE '%" & Me.comboBoxOptions.Text & "%' "
			End Select
			
			loadCombos()	
		End If
	End Sub
End Class
