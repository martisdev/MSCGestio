'
' Creado por SharpDevelop.
' Usuario: Marti
' Fecha: 14/12/2017
' Hora: 16:53
' 
' Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
'
Partial Class frmPlantillesPublicitat
    Inherits MetroFramework.Forms.MetroForm

    ''' <summary>
    ''' Designer variable used to keep track of non-visual components.
    ''' </summary>
    Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPlantillesPublicitat))
        Me.TabCtlDies = New MetroFramework.Controls.MetroTabControl()
        Me.TabPage3 = New MetroFramework.Controls.MetroTabPage()
        Me.PanelDia = New System.Windows.Forms.Panel()
        Me.PanelFrH = New System.Windows.Forms.Panel()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.PanelBlocs = New System.Windows.Forms.Panel()
        Me.CheckBox96 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox95 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox94 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox93 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox92 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox91 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox90 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox89 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox88 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox87 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox86 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox85 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox84 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox83 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox82 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox81 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox80 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox79 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox78 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox77 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox76 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox75 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox74 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox73 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox72 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox71 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox70 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox69 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox68 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox67 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox66 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox65 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox64 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox63 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox62 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox61 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox60 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox59 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox58 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox57 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox56 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox55 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox54 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox53 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox52 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox51 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox50 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox49 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox48 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox47 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox46 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox45 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox44 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox43 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox42 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox41 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox40 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox39 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox38 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox37 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox36 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox35 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox34 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox33 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox32 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox31 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox30 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox29 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox28 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox27 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox26 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox25 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox24 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox23 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox22 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox21 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox20 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox19 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox18 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox17 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox16 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox15 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox14 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox13 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox12 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox11 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox10 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox9 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox8 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox7 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox6 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox5 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox4 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox3 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox2 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox1 = New MetroFramework.Controls.MetroCheckBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabPage4 = New MetroFramework.Controls.MetroTabPage()
        Me.TabPage5 = New MetroFramework.Controls.MetroTabPage()
        Me.TabPage6 = New MetroFramework.Controls.MetroTabPage()
        Me.TabPage7 = New MetroFramework.Controls.MetroTabPage()
        Me.TabPage8 = New MetroFramework.Controls.MetroTabPage()
        Me.TabPage9 = New MetroFramework.Controls.MetroTabPage()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.cmdExitTool = New System.Windows.Forms.ToolStripButton()
        Me.cmdSalvar = New System.Windows.Forms.ToolStripButton()
        Me.lbNom = New System.Windows.Forms.ToolStripLabel()
        Me.txtNomPlantilla = New System.Windows.Forms.ToolStripTextBox()
        Me.lbNEW = New System.Windows.Forms.ToolStripLabel()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.TabCtlDies.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.PanelDia.SuspendLayout()
        Me.PanelFrH.SuspendLayout()
        Me.PanelBlocs.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabCtlDies
        '
        Me.TabCtlDies.Controls.Add(Me.TabPage3)
        Me.TabCtlDies.Controls.Add(Me.TabPage4)
        Me.TabCtlDies.Controls.Add(Me.TabPage5)
        Me.TabCtlDies.Controls.Add(Me.TabPage6)
        Me.TabCtlDies.Controls.Add(Me.TabPage7)
        Me.TabCtlDies.Controls.Add(Me.TabPage8)
        Me.TabCtlDies.Controls.Add(Me.TabPage9)
        Me.TabCtlDies.Location = New System.Drawing.Point(20, 102)
        Me.TabCtlDies.Name = "TabCtlDies"
        Me.TabCtlDies.SelectedIndex = 0
        Me.TabCtlDies.Size = New System.Drawing.Size(744, 192)
        Me.TabCtlDies.TabIndex = 1
        Me.TabCtlDies.UseSelectable = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.PanelDia)
        Me.TabPage3.HorizontalScrollbarBarColor = True
        Me.TabPage3.HorizontalScrollbarHighlightOnWheel = False
        Me.TabPage3.HorizontalScrollbarSize = 10
        Me.TabPage3.Location = New System.Drawing.Point(4, 38)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(736, 150)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Dilluns"
        Me.TabPage3.UseVisualStyleBackColor = True
        Me.TabPage3.VerticalScrollbarBarColor = True
        Me.TabPage3.VerticalScrollbarHighlightOnWheel = False
        Me.TabPage3.VerticalScrollbarSize = 10
        '
        'PanelDia
        '
        Me.PanelDia.Controls.Add(Me.PanelFrH)
        Me.PanelDia.Controls.Add(Me.Label38)
        Me.PanelDia.Controls.Add(Me.PanelBlocs)
        Me.PanelDia.Controls.Add(Me.Label39)
        Me.PanelDia.Controls.Add(Me.Label37)
        Me.PanelDia.Controls.Add(Me.Label36)
        Me.PanelDia.Controls.Add(Me.Label35)
        Me.PanelDia.Controls.Add(Me.Label34)
        Me.PanelDia.Controls.Add(Me.Label33)
        Me.PanelDia.Controls.Add(Me.Label32)
        Me.PanelDia.Controls.Add(Me.Label31)
        Me.PanelDia.Controls.Add(Me.Label30)
        Me.PanelDia.Controls.Add(Me.Label29)
        Me.PanelDia.Controls.Add(Me.Label28)
        Me.PanelDia.Controls.Add(Me.Label27)
        Me.PanelDia.Controls.Add(Me.Label26)
        Me.PanelDia.Controls.Add(Me.Label25)
        Me.PanelDia.Controls.Add(Me.Label24)
        Me.PanelDia.Controls.Add(Me.Label23)
        Me.PanelDia.Controls.Add(Me.Label22)
        Me.PanelDia.Controls.Add(Me.Label21)
        Me.PanelDia.Controls.Add(Me.Label20)
        Me.PanelDia.Controls.Add(Me.Label19)
        Me.PanelDia.Controls.Add(Me.Label18)
        Me.PanelDia.Controls.Add(Me.Label17)
        Me.PanelDia.Controls.Add(Me.Label16)
        Me.PanelDia.Controls.Add(Me.Label15)
        Me.PanelDia.Controls.Add(Me.Label14)
        Me.PanelDia.Controls.Add(Me.Label13)
        Me.PanelDia.Controls.Add(Me.Label12)
        Me.PanelDia.Controls.Add(Me.Label11)
        Me.PanelDia.Controls.Add(Me.Label10)
        Me.PanelDia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDia.Location = New System.Drawing.Point(3, 3)
        Me.PanelDia.Name = "PanelDia"
        Me.PanelDia.Size = New System.Drawing.Size(730, 144)
        Me.PanelDia.TabIndex = 0
        '
        'PanelFrH
        '
        Me.PanelFrH.Controls.Add(Me.Label63)
        Me.PanelFrH.Controls.Add(Me.Label62)
        Me.PanelFrH.Controls.Add(Me.Label61)
        Me.PanelFrH.Controls.Add(Me.Label60)
        Me.PanelFrH.Controls.Add(Me.Label59)
        Me.PanelFrH.Controls.Add(Me.Label58)
        Me.PanelFrH.Controls.Add(Me.Label57)
        Me.PanelFrH.Controls.Add(Me.Label56)
        Me.PanelFrH.Controls.Add(Me.Label55)
        Me.PanelFrH.Controls.Add(Me.Label54)
        Me.PanelFrH.Controls.Add(Me.Label53)
        Me.PanelFrH.Controls.Add(Me.Label52)
        Me.PanelFrH.Controls.Add(Me.Label51)
        Me.PanelFrH.Controls.Add(Me.Label50)
        Me.PanelFrH.Controls.Add(Me.Label49)
        Me.PanelFrH.Controls.Add(Me.Label48)
        Me.PanelFrH.Controls.Add(Me.Label47)
        Me.PanelFrH.Controls.Add(Me.Label46)
        Me.PanelFrH.Controls.Add(Me.Label45)
        Me.PanelFrH.Controls.Add(Me.Label44)
        Me.PanelFrH.Controls.Add(Me.Label43)
        Me.PanelFrH.Controls.Add(Me.Label42)
        Me.PanelFrH.Controls.Add(Me.Label41)
        Me.PanelFrH.Controls.Add(Me.Label40)
        Me.PanelFrH.Location = New System.Drawing.Point(20, 128)
        Me.PanelFrH.Name = "PanelFrH"
        Me.PanelFrH.Size = New System.Drawing.Size(715, 15)
        Me.PanelFrH.TabIndex = 63
        '
        'Label63
        '
        Me.Label63.BackColor = System.Drawing.Color.Red
        Me.Label63.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label63.Location = New System.Drawing.Point(670, 2)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(22, 8)
        Me.Label63.TabIndex = 23
        '
        'Label62
        '
        Me.Label62.BackColor = System.Drawing.Color.Red
        Me.Label62.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label62.Location = New System.Drawing.Point(640, 2)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(22, 8)
        Me.Label62.TabIndex = 22
        '
        'Label61
        '
        Me.Label61.BackColor = System.Drawing.Color.Red
        Me.Label61.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label61.Location = New System.Drawing.Point(611, 2)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(22, 8)
        Me.Label61.TabIndex = 21
        '
        'Label60
        '
        Me.Label60.BackColor = System.Drawing.Color.Red
        Me.Label60.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label60.Location = New System.Drawing.Point(582, 2)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(22, 8)
        Me.Label60.TabIndex = 20
        '
        'Label59
        '
        Me.Label59.BackColor = System.Drawing.Color.Red
        Me.Label59.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label59.Location = New System.Drawing.Point(553, 2)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(22, 8)
        Me.Label59.TabIndex = 19
        '
        'Label58
        '
        Me.Label58.BackColor = System.Drawing.Color.Red
        Me.Label58.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label58.Location = New System.Drawing.Point(522, 2)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(22, 8)
        Me.Label58.TabIndex = 18
        '
        'Label57
        '
        Me.Label57.BackColor = System.Drawing.Color.Red
        Me.Label57.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label57.Location = New System.Drawing.Point(493, 2)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(22, 8)
        Me.Label57.TabIndex = 17
        '
        'Label56
        '
        Me.Label56.BackColor = System.Drawing.Color.Red
        Me.Label56.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label56.Location = New System.Drawing.Point(465, 2)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(22, 8)
        Me.Label56.TabIndex = 16
        '
        'Label55
        '
        Me.Label55.BackColor = System.Drawing.Color.Red
        Me.Label55.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label55.Location = New System.Drawing.Point(439, 2)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(22, 8)
        Me.Label55.TabIndex = 15
        '
        'Label54
        '
        Me.Label54.BackColor = System.Drawing.Color.Red
        Me.Label54.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label54.Location = New System.Drawing.Point(408, 2)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(22, 8)
        Me.Label54.TabIndex = 14
        '
        'Label53
        '
        Me.Label53.BackColor = System.Drawing.Color.Red
        Me.Label53.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label53.Location = New System.Drawing.Point(378, 2)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(22, 8)
        Me.Label53.TabIndex = 13
        '
        'Label52
        '
        Me.Label52.BackColor = System.Drawing.Color.Red
        Me.Label52.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label52.Location = New System.Drawing.Point(350, 2)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(22, 8)
        Me.Label52.TabIndex = 12
        '
        'Label51
        '
        Me.Label51.BackColor = System.Drawing.Color.Red
        Me.Label51.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label51.Location = New System.Drawing.Point(321, 2)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(22, 8)
        Me.Label51.TabIndex = 11
        '
        'Label50
        '
        Me.Label50.BackColor = System.Drawing.Color.Red
        Me.Label50.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label50.Location = New System.Drawing.Point(293, 2)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(22, 8)
        Me.Label50.TabIndex = 10
        '
        'Label49
        '
        Me.Label49.BackColor = System.Drawing.Color.Red
        Me.Label49.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label49.Location = New System.Drawing.Point(263, 2)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(22, 8)
        Me.Label49.TabIndex = 9
        '
        'Label48
        '
        Me.Label48.BackColor = System.Drawing.Color.Red
        Me.Label48.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label48.Location = New System.Drawing.Point(234, 2)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(22, 8)
        Me.Label48.TabIndex = 8
        '
        'Label47
        '
        Me.Label47.BackColor = System.Drawing.Color.Red
        Me.Label47.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label47.Location = New System.Drawing.Point(205, 2)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(22, 8)
        Me.Label47.TabIndex = 7
        '
        'Label46
        '
        Me.Label46.BackColor = System.Drawing.Color.Red
        Me.Label46.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label46.Location = New System.Drawing.Point(176, 2)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(22, 8)
        Me.Label46.TabIndex = 6
        '
        'Label45
        '
        Me.Label45.BackColor = System.Drawing.Color.Red
        Me.Label45.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label45.Location = New System.Drawing.Point(147, 2)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(22, 8)
        Me.Label45.TabIndex = 5
        '
        'Label44
        '
        Me.Label44.BackColor = System.Drawing.Color.Red
        Me.Label44.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label44.Location = New System.Drawing.Point(119, 2)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(22, 8)
        Me.Label44.TabIndex = 4
        '
        'Label43
        '
        Me.Label43.BackColor = System.Drawing.Color.Red
        Me.Label43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label43.Location = New System.Drawing.Point(90, 2)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(22, 8)
        Me.Label43.TabIndex = 3
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.Color.Red
        Me.Label42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label42.Location = New System.Drawing.Point(61, 2)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(22, 8)
        Me.Label42.TabIndex = 2
        '
        'Label41
        '
        Me.Label41.BackColor = System.Drawing.Color.Red
        Me.Label41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label41.Location = New System.Drawing.Point(31, 2)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(22, 8)
        Me.Label41.TabIndex = 1
        '
        'Label40
        '
        Me.Label40.BackColor = System.Drawing.Color.Red
        Me.Label40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label40.Location = New System.Drawing.Point(3, 2)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(22, 8)
        Me.Label40.TabIndex = 0
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.ForeColor = System.Drawing.Color.Blue
        Me.Label38.Location = New System.Drawing.Point(0, 113)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(33, 13)
        Me.Label38.TabIndex = 60
        Me.Label38.Text = "Blocs"
        '
        'PanelBlocs
        '
        Me.PanelBlocs.Controls.Add(Me.CheckBox96)
        Me.PanelBlocs.Controls.Add(Me.CheckBox95)
        Me.PanelBlocs.Controls.Add(Me.CheckBox94)
        Me.PanelBlocs.Controls.Add(Me.CheckBox93)
        Me.PanelBlocs.Controls.Add(Me.CheckBox92)
        Me.PanelBlocs.Controls.Add(Me.CheckBox91)
        Me.PanelBlocs.Controls.Add(Me.CheckBox90)
        Me.PanelBlocs.Controls.Add(Me.CheckBox89)
        Me.PanelBlocs.Controls.Add(Me.CheckBox88)
        Me.PanelBlocs.Controls.Add(Me.CheckBox87)
        Me.PanelBlocs.Controls.Add(Me.CheckBox86)
        Me.PanelBlocs.Controls.Add(Me.CheckBox85)
        Me.PanelBlocs.Controls.Add(Me.CheckBox84)
        Me.PanelBlocs.Controls.Add(Me.CheckBox83)
        Me.PanelBlocs.Controls.Add(Me.CheckBox82)
        Me.PanelBlocs.Controls.Add(Me.CheckBox81)
        Me.PanelBlocs.Controls.Add(Me.CheckBox80)
        Me.PanelBlocs.Controls.Add(Me.CheckBox79)
        Me.PanelBlocs.Controls.Add(Me.CheckBox78)
        Me.PanelBlocs.Controls.Add(Me.CheckBox77)
        Me.PanelBlocs.Controls.Add(Me.CheckBox76)
        Me.PanelBlocs.Controls.Add(Me.CheckBox75)
        Me.PanelBlocs.Controls.Add(Me.CheckBox74)
        Me.PanelBlocs.Controls.Add(Me.CheckBox73)
        Me.PanelBlocs.Controls.Add(Me.CheckBox72)
        Me.PanelBlocs.Controls.Add(Me.CheckBox71)
        Me.PanelBlocs.Controls.Add(Me.CheckBox70)
        Me.PanelBlocs.Controls.Add(Me.CheckBox69)
        Me.PanelBlocs.Controls.Add(Me.CheckBox68)
        Me.PanelBlocs.Controls.Add(Me.CheckBox67)
        Me.PanelBlocs.Controls.Add(Me.CheckBox66)
        Me.PanelBlocs.Controls.Add(Me.CheckBox65)
        Me.PanelBlocs.Controls.Add(Me.CheckBox64)
        Me.PanelBlocs.Controls.Add(Me.CheckBox63)
        Me.PanelBlocs.Controls.Add(Me.CheckBox62)
        Me.PanelBlocs.Controls.Add(Me.CheckBox61)
        Me.PanelBlocs.Controls.Add(Me.CheckBox60)
        Me.PanelBlocs.Controls.Add(Me.CheckBox59)
        Me.PanelBlocs.Controls.Add(Me.CheckBox58)
        Me.PanelBlocs.Controls.Add(Me.CheckBox57)
        Me.PanelBlocs.Controls.Add(Me.CheckBox56)
        Me.PanelBlocs.Controls.Add(Me.CheckBox55)
        Me.PanelBlocs.Controls.Add(Me.CheckBox54)
        Me.PanelBlocs.Controls.Add(Me.CheckBox53)
        Me.PanelBlocs.Controls.Add(Me.CheckBox52)
        Me.PanelBlocs.Controls.Add(Me.CheckBox51)
        Me.PanelBlocs.Controls.Add(Me.CheckBox50)
        Me.PanelBlocs.Controls.Add(Me.CheckBox49)
        Me.PanelBlocs.Controls.Add(Me.CheckBox48)
        Me.PanelBlocs.Controls.Add(Me.CheckBox47)
        Me.PanelBlocs.Controls.Add(Me.CheckBox46)
        Me.PanelBlocs.Controls.Add(Me.CheckBox45)
        Me.PanelBlocs.Controls.Add(Me.CheckBox44)
        Me.PanelBlocs.Controls.Add(Me.CheckBox43)
        Me.PanelBlocs.Controls.Add(Me.CheckBox42)
        Me.PanelBlocs.Controls.Add(Me.CheckBox41)
        Me.PanelBlocs.Controls.Add(Me.CheckBox40)
        Me.PanelBlocs.Controls.Add(Me.CheckBox39)
        Me.PanelBlocs.Controls.Add(Me.CheckBox38)
        Me.PanelBlocs.Controls.Add(Me.CheckBox37)
        Me.PanelBlocs.Controls.Add(Me.CheckBox36)
        Me.PanelBlocs.Controls.Add(Me.CheckBox35)
        Me.PanelBlocs.Controls.Add(Me.CheckBox34)
        Me.PanelBlocs.Controls.Add(Me.CheckBox33)
        Me.PanelBlocs.Controls.Add(Me.CheckBox32)
        Me.PanelBlocs.Controls.Add(Me.CheckBox31)
        Me.PanelBlocs.Controls.Add(Me.CheckBox30)
        Me.PanelBlocs.Controls.Add(Me.CheckBox29)
        Me.PanelBlocs.Controls.Add(Me.CheckBox28)
        Me.PanelBlocs.Controls.Add(Me.CheckBox27)
        Me.PanelBlocs.Controls.Add(Me.CheckBox26)
        Me.PanelBlocs.Controls.Add(Me.CheckBox25)
        Me.PanelBlocs.Controls.Add(Me.CheckBox24)
        Me.PanelBlocs.Controls.Add(Me.CheckBox23)
        Me.PanelBlocs.Controls.Add(Me.CheckBox22)
        Me.PanelBlocs.Controls.Add(Me.CheckBox21)
        Me.PanelBlocs.Controls.Add(Me.CheckBox20)
        Me.PanelBlocs.Controls.Add(Me.CheckBox19)
        Me.PanelBlocs.Controls.Add(Me.CheckBox18)
        Me.PanelBlocs.Controls.Add(Me.CheckBox17)
        Me.PanelBlocs.Controls.Add(Me.CheckBox16)
        Me.PanelBlocs.Controls.Add(Me.CheckBox15)
        Me.PanelBlocs.Controls.Add(Me.CheckBox14)
        Me.PanelBlocs.Controls.Add(Me.CheckBox13)
        Me.PanelBlocs.Controls.Add(Me.CheckBox12)
        Me.PanelBlocs.Controls.Add(Me.CheckBox11)
        Me.PanelBlocs.Controls.Add(Me.CheckBox10)
        Me.PanelBlocs.Controls.Add(Me.CheckBox9)
        Me.PanelBlocs.Controls.Add(Me.CheckBox8)
        Me.PanelBlocs.Controls.Add(Me.CheckBox7)
        Me.PanelBlocs.Controls.Add(Me.CheckBox6)
        Me.PanelBlocs.Controls.Add(Me.CheckBox5)
        Me.PanelBlocs.Controls.Add(Me.CheckBox4)
        Me.PanelBlocs.Controls.Add(Me.CheckBox3)
        Me.PanelBlocs.Controls.Add(Me.CheckBox2)
        Me.PanelBlocs.Controls.Add(Me.CheckBox1)
        Me.PanelBlocs.Location = New System.Drawing.Point(20, 14)
        Me.PanelBlocs.Name = "PanelBlocs"
        Me.PanelBlocs.Size = New System.Drawing.Size(715, 108)
        Me.PanelBlocs.TabIndex = 62
        '
        'CheckBox96
        '
        Me.CheckBox96.Location = New System.Drawing.Point(676, 81)
        Me.CheckBox96.Name = "CheckBox96"
        Me.CheckBox96.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox96.TabIndex = 95
        Me.CheckBox96.UseSelectable = True
        '
        'CheckBox95
        '
        Me.CheckBox95.Location = New System.Drawing.Point(676, 58)
        Me.CheckBox95.Name = "CheckBox95"
        Me.CheckBox95.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox95.TabIndex = 94
        Me.CheckBox95.UseSelectable = True
        '
        'CheckBox94
        '
        Me.CheckBox94.Location = New System.Drawing.Point(676, 35)
        Me.CheckBox94.Name = "CheckBox94"
        Me.CheckBox94.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox94.TabIndex = 93
        Me.CheckBox94.UseSelectable = True
        '
        'CheckBox93
        '
        Me.CheckBox93.Location = New System.Drawing.Point(676, 12)
        Me.CheckBox93.Name = "CheckBox93"
        Me.CheckBox93.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox93.TabIndex = 92
        Me.CheckBox93.UseSelectable = True
        '
        'CheckBox92
        '
        Me.CheckBox92.Location = New System.Drawing.Point(647, 81)
        Me.CheckBox92.Name = "CheckBox92"
        Me.CheckBox92.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox92.TabIndex = 91
        Me.CheckBox92.UseSelectable = True
        '
        'CheckBox91
        '
        Me.CheckBox91.Location = New System.Drawing.Point(647, 58)
        Me.CheckBox91.Name = "CheckBox91"
        Me.CheckBox91.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox91.TabIndex = 90
        Me.CheckBox91.UseSelectable = True
        '
        'CheckBox90
        '
        Me.CheckBox90.Location = New System.Drawing.Point(647, 35)
        Me.CheckBox90.Name = "CheckBox90"
        Me.CheckBox90.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox90.TabIndex = 89
        Me.CheckBox90.UseSelectable = True
        '
        'CheckBox89
        '
        Me.CheckBox89.Location = New System.Drawing.Point(647, 12)
        Me.CheckBox89.Name = "CheckBox89"
        Me.CheckBox89.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox89.TabIndex = 88
        Me.CheckBox89.UseSelectable = True
        '
        'CheckBox88
        '
        Me.CheckBox88.Location = New System.Drawing.Point(618, 81)
        Me.CheckBox88.Name = "CheckBox88"
        Me.CheckBox88.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox88.TabIndex = 87
        Me.CheckBox88.UseSelectable = True
        '
        'CheckBox87
        '
        Me.CheckBox87.Location = New System.Drawing.Point(618, 58)
        Me.CheckBox87.Name = "CheckBox87"
        Me.CheckBox87.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox87.TabIndex = 86
        Me.CheckBox87.UseSelectable = True
        '
        'CheckBox86
        '
        Me.CheckBox86.Location = New System.Drawing.Point(618, 35)
        Me.CheckBox86.Name = "CheckBox86"
        Me.CheckBox86.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox86.TabIndex = 85
        Me.CheckBox86.UseSelectable = True
        '
        'CheckBox85
        '
        Me.CheckBox85.Location = New System.Drawing.Point(618, 12)
        Me.CheckBox85.Name = "CheckBox85"
        Me.CheckBox85.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox85.TabIndex = 84
        Me.CheckBox85.UseSelectable = True
        '
        'CheckBox84
        '
        Me.CheckBox84.Location = New System.Drawing.Point(589, 81)
        Me.CheckBox84.Name = "CheckBox84"
        Me.CheckBox84.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox84.TabIndex = 83
        Me.CheckBox84.UseSelectable = True
        '
        'CheckBox83
        '
        Me.CheckBox83.Location = New System.Drawing.Point(589, 58)
        Me.CheckBox83.Name = "CheckBox83"
        Me.CheckBox83.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox83.TabIndex = 82
        Me.CheckBox83.UseSelectable = True
        '
        'CheckBox82
        '
        Me.CheckBox82.Location = New System.Drawing.Point(589, 35)
        Me.CheckBox82.Name = "CheckBox82"
        Me.CheckBox82.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox82.TabIndex = 81
        Me.CheckBox82.UseSelectable = True
        '
        'CheckBox81
        '
        Me.CheckBox81.Location = New System.Drawing.Point(589, 12)
        Me.CheckBox81.Name = "CheckBox81"
        Me.CheckBox81.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox81.TabIndex = 80
        Me.CheckBox81.UseSelectable = True
        '
        'CheckBox80
        '
        Me.CheckBox80.Location = New System.Drawing.Point(560, 81)
        Me.CheckBox80.Name = "CheckBox80"
        Me.CheckBox80.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox80.TabIndex = 79
        Me.CheckBox80.UseSelectable = True
        '
        'CheckBox79
        '
        Me.CheckBox79.Location = New System.Drawing.Point(560, 58)
        Me.CheckBox79.Name = "CheckBox79"
        Me.CheckBox79.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox79.TabIndex = 78
        Me.CheckBox79.UseSelectable = True
        '
        'CheckBox78
        '
        Me.CheckBox78.Location = New System.Drawing.Point(560, 35)
        Me.CheckBox78.Name = "CheckBox78"
        Me.CheckBox78.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox78.TabIndex = 77
        Me.CheckBox78.UseSelectable = True
        '
        'CheckBox77
        '
        Me.CheckBox77.Location = New System.Drawing.Point(560, 12)
        Me.CheckBox77.Name = "CheckBox77"
        Me.CheckBox77.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox77.TabIndex = 76
        Me.CheckBox77.UseSelectable = True
        '
        'CheckBox76
        '
        Me.CheckBox76.Location = New System.Drawing.Point(529, 81)
        Me.CheckBox76.Name = "CheckBox76"
        Me.CheckBox76.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox76.TabIndex = 75
        Me.CheckBox76.UseSelectable = True
        '
        'CheckBox75
        '
        Me.CheckBox75.Location = New System.Drawing.Point(529, 58)
        Me.CheckBox75.Name = "CheckBox75"
        Me.CheckBox75.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox75.TabIndex = 74
        Me.CheckBox75.UseSelectable = True
        '
        'CheckBox74
        '
        Me.CheckBox74.Location = New System.Drawing.Point(530, 35)
        Me.CheckBox74.Name = "CheckBox74"
        Me.CheckBox74.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox74.TabIndex = 73
        Me.CheckBox74.UseSelectable = True
        '
        'CheckBox73
        '
        Me.CheckBox73.Location = New System.Drawing.Point(530, 12)
        Me.CheckBox73.Name = "CheckBox73"
        Me.CheckBox73.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox73.TabIndex = 72
        Me.CheckBox73.UseSelectable = True
        '
        'CheckBox72
        '
        Me.CheckBox72.Location = New System.Drawing.Point(502, 81)
        Me.CheckBox72.Name = "CheckBox72"
        Me.CheckBox72.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox72.TabIndex = 71
        Me.CheckBox72.UseSelectable = True
        '
        'CheckBox71
        '
        Me.CheckBox71.Location = New System.Drawing.Point(502, 58)
        Me.CheckBox71.Name = "CheckBox71"
        Me.CheckBox71.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox71.TabIndex = 70
        Me.CheckBox71.UseSelectable = True
        '
        'CheckBox70
        '
        Me.CheckBox70.Location = New System.Drawing.Point(502, 35)
        Me.CheckBox70.Name = "CheckBox70"
        Me.CheckBox70.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox70.TabIndex = 69
        Me.CheckBox70.UseSelectable = True
        '
        'CheckBox69
        '
        Me.CheckBox69.Location = New System.Drawing.Point(502, 12)
        Me.CheckBox69.Name = "CheckBox69"
        Me.CheckBox69.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox69.TabIndex = 68
        Me.CheckBox69.UseSelectable = True
        '
        'CheckBox68
        '
        Me.CheckBox68.Location = New System.Drawing.Point(473, 81)
        Me.CheckBox68.Name = "CheckBox68"
        Me.CheckBox68.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox68.TabIndex = 67
        Me.CheckBox68.UseSelectable = True
        '
        'CheckBox67
        '
        Me.CheckBox67.Location = New System.Drawing.Point(473, 58)
        Me.CheckBox67.Name = "CheckBox67"
        Me.CheckBox67.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox67.TabIndex = 66
        Me.CheckBox67.UseSelectable = True
        '
        'CheckBox66
        '
        Me.CheckBox66.Location = New System.Drawing.Point(473, 35)
        Me.CheckBox66.Name = "CheckBox66"
        Me.CheckBox66.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox66.TabIndex = 65
        Me.CheckBox66.UseSelectable = True
        '
        'CheckBox65
        '
        Me.CheckBox65.Location = New System.Drawing.Point(473, 12)
        Me.CheckBox65.Name = "CheckBox65"
        Me.CheckBox65.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox65.TabIndex = 64
        Me.CheckBox65.UseSelectable = True
        '
        'CheckBox64
        '
        Me.CheckBox64.Location = New System.Drawing.Point(445, 81)
        Me.CheckBox64.Name = "CheckBox64"
        Me.CheckBox64.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox64.TabIndex = 63
        Me.CheckBox64.UseSelectable = True
        '
        'CheckBox63
        '
        Me.CheckBox63.Location = New System.Drawing.Point(445, 58)
        Me.CheckBox63.Name = "CheckBox63"
        Me.CheckBox63.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox63.TabIndex = 62
        Me.CheckBox63.UseSelectable = True
        '
        'CheckBox62
        '
        Me.CheckBox62.Location = New System.Drawing.Point(445, 35)
        Me.CheckBox62.Name = "CheckBox62"
        Me.CheckBox62.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox62.TabIndex = 61
        Me.CheckBox62.UseSelectable = True
        '
        'CheckBox61
        '
        Me.CheckBox61.Location = New System.Drawing.Point(445, 12)
        Me.CheckBox61.Name = "CheckBox61"
        Me.CheckBox61.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox61.TabIndex = 60
        Me.CheckBox61.UseSelectable = True
        '
        'CheckBox60
        '
        Me.CheckBox60.Location = New System.Drawing.Point(415, 81)
        Me.CheckBox60.Name = "CheckBox60"
        Me.CheckBox60.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox60.TabIndex = 59
        Me.CheckBox60.UseSelectable = True
        '
        'CheckBox59
        '
        Me.CheckBox59.Location = New System.Drawing.Point(415, 58)
        Me.CheckBox59.Name = "CheckBox59"
        Me.CheckBox59.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox59.TabIndex = 58
        Me.CheckBox59.UseSelectable = True
        '
        'CheckBox58
        '
        Me.CheckBox58.Location = New System.Drawing.Point(415, 35)
        Me.CheckBox58.Name = "CheckBox58"
        Me.CheckBox58.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox58.TabIndex = 57
        Me.CheckBox58.UseSelectable = True
        '
        'CheckBox57
        '
        Me.CheckBox57.Location = New System.Drawing.Point(415, 12)
        Me.CheckBox57.Name = "CheckBox57"
        Me.CheckBox57.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox57.TabIndex = 56
        Me.CheckBox57.UseSelectable = True
        '
        'CheckBox56
        '
        Me.CheckBox56.Location = New System.Drawing.Point(385, 81)
        Me.CheckBox56.Name = "CheckBox56"
        Me.CheckBox56.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox56.TabIndex = 55
        Me.CheckBox56.UseSelectable = True
        '
        'CheckBox55
        '
        Me.CheckBox55.Location = New System.Drawing.Point(385, 58)
        Me.CheckBox55.Name = "CheckBox55"
        Me.CheckBox55.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox55.TabIndex = 54
        Me.CheckBox55.UseSelectable = True
        '
        'CheckBox54
        '
        Me.CheckBox54.Location = New System.Drawing.Point(385, 35)
        Me.CheckBox54.Name = "CheckBox54"
        Me.CheckBox54.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox54.TabIndex = 53
        Me.CheckBox54.UseSelectable = True
        '
        'CheckBox53
        '
        Me.CheckBox53.Location = New System.Drawing.Point(385, 12)
        Me.CheckBox53.Name = "CheckBox53"
        Me.CheckBox53.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox53.TabIndex = 52
        Me.CheckBox53.UseSelectable = True
        '
        'CheckBox52
        '
        Me.CheckBox52.Location = New System.Drawing.Point(357, 81)
        Me.CheckBox52.Name = "CheckBox52"
        Me.CheckBox52.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox52.TabIndex = 51
        Me.CheckBox52.UseSelectable = True
        '
        'CheckBox51
        '
        Me.CheckBox51.Location = New System.Drawing.Point(357, 58)
        Me.CheckBox51.Name = "CheckBox51"
        Me.CheckBox51.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox51.TabIndex = 50
        Me.CheckBox51.UseSelectable = True
        '
        'CheckBox50
        '
        Me.CheckBox50.Location = New System.Drawing.Point(357, 35)
        Me.CheckBox50.Name = "CheckBox50"
        Me.CheckBox50.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox50.TabIndex = 49
        Me.CheckBox50.UseSelectable = True
        '
        'CheckBox49
        '
        Me.CheckBox49.Location = New System.Drawing.Point(357, 12)
        Me.CheckBox49.Name = "CheckBox49"
        Me.CheckBox49.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox49.TabIndex = 48
        Me.CheckBox49.UseSelectable = True
        '
        'CheckBox48
        '
        Me.CheckBox48.Location = New System.Drawing.Point(328, 81)
        Me.CheckBox48.Name = "CheckBox48"
        Me.CheckBox48.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox48.TabIndex = 47
        Me.CheckBox48.UseSelectable = True
        '
        'CheckBox47
        '
        Me.CheckBox47.Location = New System.Drawing.Point(328, 58)
        Me.CheckBox47.Name = "CheckBox47"
        Me.CheckBox47.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox47.TabIndex = 46
        Me.CheckBox47.UseSelectable = True
        '
        'CheckBox46
        '
        Me.CheckBox46.Location = New System.Drawing.Point(328, 35)
        Me.CheckBox46.Name = "CheckBox46"
        Me.CheckBox46.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox46.TabIndex = 45
        Me.CheckBox46.UseSelectable = True
        '
        'CheckBox45
        '
        Me.CheckBox45.Location = New System.Drawing.Point(328, 12)
        Me.CheckBox45.Name = "CheckBox45"
        Me.CheckBox45.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox45.TabIndex = 44
        Me.CheckBox45.UseSelectable = True
        '
        'CheckBox44
        '
        Me.CheckBox44.Location = New System.Drawing.Point(299, 81)
        Me.CheckBox44.Name = "CheckBox44"
        Me.CheckBox44.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox44.TabIndex = 43
        Me.CheckBox44.UseSelectable = True
        '
        'CheckBox43
        '
        Me.CheckBox43.Location = New System.Drawing.Point(299, 58)
        Me.CheckBox43.Name = "CheckBox43"
        Me.CheckBox43.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox43.TabIndex = 42
        Me.CheckBox43.UseSelectable = True
        '
        'CheckBox42
        '
        Me.CheckBox42.Location = New System.Drawing.Point(299, 35)
        Me.CheckBox42.Name = "CheckBox42"
        Me.CheckBox42.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox42.TabIndex = 41
        Me.CheckBox42.UseSelectable = True
        '
        'CheckBox41
        '
        Me.CheckBox41.Location = New System.Drawing.Point(299, 12)
        Me.CheckBox41.Name = "CheckBox41"
        Me.CheckBox41.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox41.TabIndex = 40
        Me.CheckBox41.UseSelectable = True
        '
        'CheckBox40
        '
        Me.CheckBox40.Location = New System.Drawing.Point(270, 81)
        Me.CheckBox40.Name = "CheckBox40"
        Me.CheckBox40.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox40.TabIndex = 39
        Me.CheckBox40.UseSelectable = True
        '
        'CheckBox39
        '
        Me.CheckBox39.Location = New System.Drawing.Point(270, 58)
        Me.CheckBox39.Name = "CheckBox39"
        Me.CheckBox39.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox39.TabIndex = 38
        Me.CheckBox39.UseSelectable = True
        '
        'CheckBox38
        '
        Me.CheckBox38.Location = New System.Drawing.Point(270, 35)
        Me.CheckBox38.Name = "CheckBox38"
        Me.CheckBox38.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox38.TabIndex = 37
        Me.CheckBox38.UseSelectable = True
        '
        'CheckBox37
        '
        Me.CheckBox37.Location = New System.Drawing.Point(270, 12)
        Me.CheckBox37.Name = "CheckBox37"
        Me.CheckBox37.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox37.TabIndex = 36
        Me.CheckBox37.UseSelectable = True
        '
        'CheckBox36
        '
        Me.CheckBox36.Location = New System.Drawing.Point(241, 81)
        Me.CheckBox36.Name = "CheckBox36"
        Me.CheckBox36.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox36.TabIndex = 35
        Me.CheckBox36.UseSelectable = True
        '
        'CheckBox35
        '
        Me.CheckBox35.Location = New System.Drawing.Point(241, 58)
        Me.CheckBox35.Name = "CheckBox35"
        Me.CheckBox35.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox35.TabIndex = 34
        Me.CheckBox35.UseSelectable = True
        '
        'CheckBox34
        '
        Me.CheckBox34.Location = New System.Drawing.Point(241, 35)
        Me.CheckBox34.Name = "CheckBox34"
        Me.CheckBox34.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox34.TabIndex = 33
        Me.CheckBox34.UseSelectable = True
        '
        'CheckBox33
        '
        Me.CheckBox33.Location = New System.Drawing.Point(241, 12)
        Me.CheckBox33.Name = "CheckBox33"
        Me.CheckBox33.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox33.TabIndex = 32
        Me.CheckBox33.UseSelectable = True
        '
        'CheckBox32
        '
        Me.CheckBox32.Location = New System.Drawing.Point(212, 81)
        Me.CheckBox32.Name = "CheckBox32"
        Me.CheckBox32.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox32.TabIndex = 31
        Me.CheckBox32.UseSelectable = True
        '
        'CheckBox31
        '
        Me.CheckBox31.Location = New System.Drawing.Point(212, 58)
        Me.CheckBox31.Name = "CheckBox31"
        Me.CheckBox31.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox31.TabIndex = 30
        Me.CheckBox31.UseSelectable = True
        '
        'CheckBox30
        '
        Me.CheckBox30.Location = New System.Drawing.Point(212, 35)
        Me.CheckBox30.Name = "CheckBox30"
        Me.CheckBox30.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox30.TabIndex = 29
        Me.CheckBox30.UseSelectable = True
        '
        'CheckBox29
        '
        Me.CheckBox29.Location = New System.Drawing.Point(212, 12)
        Me.CheckBox29.Name = "CheckBox29"
        Me.CheckBox29.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox29.TabIndex = 28
        Me.CheckBox29.UseSelectable = True
        '
        'CheckBox28
        '
        Me.CheckBox28.Location = New System.Drawing.Point(183, 81)
        Me.CheckBox28.Name = "CheckBox28"
        Me.CheckBox28.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox28.TabIndex = 27
        Me.CheckBox28.UseSelectable = True
        '
        'CheckBox27
        '
        Me.CheckBox27.Location = New System.Drawing.Point(183, 58)
        Me.CheckBox27.Name = "CheckBox27"
        Me.CheckBox27.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox27.TabIndex = 26
        Me.CheckBox27.UseSelectable = True
        '
        'CheckBox26
        '
        Me.CheckBox26.Location = New System.Drawing.Point(183, 35)
        Me.CheckBox26.Name = "CheckBox26"
        Me.CheckBox26.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox26.TabIndex = 25
        Me.CheckBox26.UseSelectable = True
        '
        'CheckBox25
        '
        Me.CheckBox25.Location = New System.Drawing.Point(183, 12)
        Me.CheckBox25.Name = "CheckBox25"
        Me.CheckBox25.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox25.TabIndex = 24
        Me.CheckBox25.UseSelectable = True
        '
        'CheckBox24
        '
        Me.CheckBox24.Location = New System.Drawing.Point(154, 81)
        Me.CheckBox24.Name = "CheckBox24"
        Me.CheckBox24.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox24.TabIndex = 23
        Me.CheckBox24.UseSelectable = True
        '
        'CheckBox23
        '
        Me.CheckBox23.Location = New System.Drawing.Point(154, 58)
        Me.CheckBox23.Name = "CheckBox23"
        Me.CheckBox23.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox23.TabIndex = 22
        Me.CheckBox23.UseSelectable = True
        '
        'CheckBox22
        '
        Me.CheckBox22.Location = New System.Drawing.Point(154, 35)
        Me.CheckBox22.Name = "CheckBox22"
        Me.CheckBox22.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox22.TabIndex = 21
        Me.CheckBox22.UseSelectable = True
        '
        'CheckBox21
        '
        Me.CheckBox21.Location = New System.Drawing.Point(154, 12)
        Me.CheckBox21.Name = "CheckBox21"
        Me.CheckBox21.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox21.TabIndex = 20
        Me.CheckBox21.UseSelectable = True
        '
        'CheckBox20
        '
        Me.CheckBox20.Location = New System.Drawing.Point(125, 81)
        Me.CheckBox20.Name = "CheckBox20"
        Me.CheckBox20.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox20.TabIndex = 19
        Me.CheckBox20.UseSelectable = True
        '
        'CheckBox19
        '
        Me.CheckBox19.Location = New System.Drawing.Point(125, 58)
        Me.CheckBox19.Name = "CheckBox19"
        Me.CheckBox19.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox19.TabIndex = 18
        Me.CheckBox19.UseSelectable = True
        '
        'CheckBox18
        '
        Me.CheckBox18.Location = New System.Drawing.Point(125, 35)
        Me.CheckBox18.Name = "CheckBox18"
        Me.CheckBox18.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox18.TabIndex = 17
        Me.CheckBox18.UseSelectable = True
        '
        'CheckBox17
        '
        Me.CheckBox17.Location = New System.Drawing.Point(125, 12)
        Me.CheckBox17.Name = "CheckBox17"
        Me.CheckBox17.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox17.TabIndex = 16
        Me.CheckBox17.UseSelectable = True
        '
        'CheckBox16
        '
        Me.CheckBox16.Location = New System.Drawing.Point(96, 81)
        Me.CheckBox16.Name = "CheckBox16"
        Me.CheckBox16.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox16.TabIndex = 15
        Me.CheckBox16.UseSelectable = True
        '
        'CheckBox15
        '
        Me.CheckBox15.Location = New System.Drawing.Point(96, 58)
        Me.CheckBox15.Name = "CheckBox15"
        Me.CheckBox15.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox15.TabIndex = 14
        Me.CheckBox15.UseSelectable = True
        '
        'CheckBox14
        '
        Me.CheckBox14.Location = New System.Drawing.Point(96, 35)
        Me.CheckBox14.Name = "CheckBox14"
        Me.CheckBox14.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox14.TabIndex = 13
        Me.CheckBox14.UseSelectable = True
        '
        'CheckBox13
        '
        Me.CheckBox13.Location = New System.Drawing.Point(96, 12)
        Me.CheckBox13.Name = "CheckBox13"
        Me.CheckBox13.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox13.TabIndex = 12
        Me.CheckBox13.UseSelectable = True
        '
        'CheckBox12
        '
        Me.CheckBox12.Location = New System.Drawing.Point(65, 81)
        Me.CheckBox12.Name = "CheckBox12"
        Me.CheckBox12.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox12.TabIndex = 11
        Me.CheckBox12.UseSelectable = True
        '
        'CheckBox11
        '
        Me.CheckBox11.Location = New System.Drawing.Point(65, 58)
        Me.CheckBox11.Name = "CheckBox11"
        Me.CheckBox11.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox11.TabIndex = 10
        Me.CheckBox11.UseSelectable = True
        '
        'CheckBox10
        '
        Me.CheckBox10.Location = New System.Drawing.Point(65, 35)
        Me.CheckBox10.Name = "CheckBox10"
        Me.CheckBox10.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox10.TabIndex = 9
        Me.CheckBox10.UseSelectable = True
        '
        'CheckBox9
        '
        Me.CheckBox9.Location = New System.Drawing.Point(65, 12)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox9.TabIndex = 8
        Me.CheckBox9.UseSelectable = True
        '
        'CheckBox8
        '
        Me.CheckBox8.Location = New System.Drawing.Point(35, 81)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox8.TabIndex = 7
        Me.CheckBox8.UseSelectable = True
        '
        'CheckBox7
        '
        Me.CheckBox7.Location = New System.Drawing.Point(35, 58)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox7.TabIndex = 6
        Me.CheckBox7.UseSelectable = True
        '
        'CheckBox6
        '
        Me.CheckBox6.Location = New System.Drawing.Point(35, 35)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox6.TabIndex = 5
        Me.CheckBox6.UseSelectable = True
        '
        'CheckBox5
        '
        Me.CheckBox5.Location = New System.Drawing.Point(35, 12)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox5.TabIndex = 4
        Me.CheckBox5.UseSelectable = True
        '
        'CheckBox4
        '
        Me.CheckBox4.Location = New System.Drawing.Point(10, 81)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox4.TabIndex = 3
        Me.CheckBox4.UseSelectable = True
        '
        'CheckBox3
        '
        Me.CheckBox3.Location = New System.Drawing.Point(10, 58)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox3.TabIndex = 2
        Me.CheckBox3.UseSelectable = True
        '
        'CheckBox2
        '
        Me.CheckBox2.Location = New System.Drawing.Point(10, 35)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.UseSelectable = True
        '
        'CheckBox1
        '
        Me.CheckBox1.Location = New System.Drawing.Point(10, 13)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.UseSelectable = True
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.ForeColor = System.Drawing.Color.Blue
        Me.Label39.Location = New System.Drawing.Point(708, 2)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(35, 13)
        Me.Label39.TabIndex = 61
        Me.Label39.Text = "Hores"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(693, 2)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(19, 13)
        Me.Label37.TabIndex = 59
        Me.Label37.Text = "23"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(664, 2)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(19, 13)
        Me.Label36.TabIndex = 58
        Me.Label36.Text = "22"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(635, 2)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(19, 13)
        Me.Label35.TabIndex = 57
        Me.Label35.Text = "21"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(606, 2)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(19, 13)
        Me.Label34.TabIndex = 56
        Me.Label34.Text = "20"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(577, 2)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(19, 13)
        Me.Label33.TabIndex = 55
        Me.Label33.Text = "19"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(548, 2)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(19, 13)
        Me.Label32.TabIndex = 54
        Me.Label32.Text = "18"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(519, 2)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(19, 13)
        Me.Label31.TabIndex = 53
        Me.Label31.Text = "17"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(490, 2)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(19, 13)
        Me.Label30.TabIndex = 52
        Me.Label30.Text = "16"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(461, 2)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(19, 13)
        Me.Label29.TabIndex = 51
        Me.Label29.Text = "15"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(432, 2)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(19, 13)
        Me.Label28.TabIndex = 50
        Me.Label28.Text = "14"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(403, 2)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(19, 13)
        Me.Label27.TabIndex = 49
        Me.Label27.Text = "13"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(374, 2)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(19, 13)
        Me.Label26.TabIndex = 48
        Me.Label26.Text = "12"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(345, 2)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(19, 13)
        Me.Label25.TabIndex = 47
        Me.Label25.Text = "11"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(316, 2)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(19, 13)
        Me.Label24.TabIndex = 46
        Me.Label24.Text = "10"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(287, 2)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(19, 13)
        Me.Label23.TabIndex = 45
        Me.Label23.Text = "09"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(258, 2)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(19, 13)
        Me.Label22.TabIndex = 44
        Me.Label22.Text = "08"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(229, 2)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(19, 13)
        Me.Label21.TabIndex = 43
        Me.Label21.Text = "07"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(200, 2)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(19, 13)
        Me.Label20.TabIndex = 42
        Me.Label20.Text = "06"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(171, 2)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(19, 13)
        Me.Label19.TabIndex = 41
        Me.Label19.Text = "05"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(142, 2)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(19, 13)
        Me.Label18.TabIndex = 40
        Me.Label18.Text = "04"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(113, 2)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(19, 13)
        Me.Label17.TabIndex = 39
        Me.Label17.Text = "03"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(84, 2)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(19, 13)
        Me.Label16.TabIndex = 38
        Me.Label16.Text = "02"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(55, 2)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(19, 13)
        Me.Label15.TabIndex = 37
        Me.Label15.Text = "01"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(26, 2)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(19, 13)
        Me.Label14.TabIndex = 36
        Me.Label14.Text = "00"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(0, 98)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(19, 13)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "45"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(0, 74)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(19, 13)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "30"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(0, 50)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(19, 13)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "15"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(0, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(19, 13)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "00"
        '
        'TabPage4
        '
        Me.TabPage4.HorizontalScrollbarBarColor = True
        Me.TabPage4.HorizontalScrollbarHighlightOnWheel = False
        Me.TabPage4.HorizontalScrollbarSize = 10
        Me.TabPage4.Location = New System.Drawing.Point(4, 38)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(736, 150)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Dimarts"
        Me.TabPage4.UseVisualStyleBackColor = True
        Me.TabPage4.VerticalScrollbarBarColor = True
        Me.TabPage4.VerticalScrollbarHighlightOnWheel = False
        Me.TabPage4.VerticalScrollbarSize = 10
        '
        'TabPage5
        '
        Me.TabPage5.HorizontalScrollbarBarColor = True
        Me.TabPage5.HorizontalScrollbarHighlightOnWheel = False
        Me.TabPage5.HorizontalScrollbarSize = 10
        Me.TabPage5.Location = New System.Drawing.Point(4, 38)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(736, 150)
        Me.TabPage5.TabIndex = 2
        Me.TabPage5.Text = "Dimecres"
        Me.TabPage5.UseVisualStyleBackColor = True
        Me.TabPage5.VerticalScrollbarBarColor = True
        Me.TabPage5.VerticalScrollbarHighlightOnWheel = False
        Me.TabPage5.VerticalScrollbarSize = 10
        '
        'TabPage6
        '
        Me.TabPage6.HorizontalScrollbarBarColor = True
        Me.TabPage6.HorizontalScrollbarHighlightOnWheel = False
        Me.TabPage6.HorizontalScrollbarSize = 10
        Me.TabPage6.Location = New System.Drawing.Point(4, 38)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(736, 150)
        Me.TabPage6.TabIndex = 3
        Me.TabPage6.Text = "Dijous"
        Me.TabPage6.UseVisualStyleBackColor = True
        Me.TabPage6.VerticalScrollbarBarColor = True
        Me.TabPage6.VerticalScrollbarHighlightOnWheel = False
        Me.TabPage6.VerticalScrollbarSize = 10
        '
        'TabPage7
        '
        Me.TabPage7.HorizontalScrollbarBarColor = True
        Me.TabPage7.HorizontalScrollbarHighlightOnWheel = False
        Me.TabPage7.HorizontalScrollbarSize = 10
        Me.TabPage7.Location = New System.Drawing.Point(4, 38)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(736, 150)
        Me.TabPage7.TabIndex = 4
        Me.TabPage7.Text = "Divendres"
        Me.TabPage7.UseVisualStyleBackColor = True
        Me.TabPage7.VerticalScrollbarBarColor = True
        Me.TabPage7.VerticalScrollbarHighlightOnWheel = False
        Me.TabPage7.VerticalScrollbarSize = 10
        '
        'TabPage8
        '
        Me.TabPage8.HorizontalScrollbarBarColor = True
        Me.TabPage8.HorizontalScrollbarHighlightOnWheel = False
        Me.TabPage8.HorizontalScrollbarSize = 10
        Me.TabPage8.Location = New System.Drawing.Point(4, 38)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Size = New System.Drawing.Size(736, 150)
        Me.TabPage8.TabIndex = 5
        Me.TabPage8.Text = "Dissabte"
        Me.TabPage8.UseVisualStyleBackColor = True
        Me.TabPage8.VerticalScrollbarBarColor = True
        Me.TabPage8.VerticalScrollbarHighlightOnWheel = False
        Me.TabPage8.VerticalScrollbarSize = 10
        '
        'TabPage9
        '
        Me.TabPage9.HorizontalScrollbarBarColor = True
        Me.TabPage9.HorizontalScrollbarHighlightOnWheel = False
        Me.TabPage9.HorizontalScrollbarSize = 10
        Me.TabPage9.Location = New System.Drawing.Point(4, 38)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Size = New System.Drawing.Size(736, 150)
        Me.TabPage9.TabIndex = 6
        Me.TabPage9.Text = "Diumenge"
        Me.TabPage9.UseVisualStyleBackColor = True
        Me.TabPage9.VerticalScrollbarBarColor = True
        Me.TabPage9.VerticalScrollbarHighlightOnWheel = False
        Me.TabPage9.VerticalScrollbarSize = 10
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdExitTool, Me.cmdSalvar, Me.lbNom, Me.txtNomPlantilla, Me.lbNEW})
        Me.ToolStrip1.Location = New System.Drawing.Point(20, 60)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(747, 39)
        Me.ToolStrip1.TabIndex = 18
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'cmdExitTool
        '
        Me.cmdExitTool.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.cmdExitTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdExitTool.Image = CType(resources.GetObject("cmdExitTool.Image"), System.Drawing.Image)
        Me.cmdExitTool.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdExitTool.Name = "cmdExitTool"
        Me.cmdExitTool.Size = New System.Drawing.Size(36, 36)
        Me.cmdExitTool.Text = "Sortir"
        Me.cmdExitTool.ToolTipText = "Tancar pantalla"
        '
        'cmdSalvar
        '
        Me.cmdSalvar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.cmdSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdSalvar.Enabled = False
        Me.cmdSalvar.Image = CType(resources.GetObject("cmdSalvar.Image"), System.Drawing.Image)
        Me.cmdSalvar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSalvar.Name = "cmdSalvar"
        Me.cmdSalvar.Size = New System.Drawing.Size(36, 36)
        Me.cmdSalvar.Text = "Salvar ítem"
        '
        'lbNom
        '
        Me.lbNom.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNom.Name = "lbNom"
        Me.lbNom.Size = New System.Drawing.Size(37, 36)
        Me.lbNom.Text = "Nom:"
        '
        'txtNomPlantilla
        '
        Me.txtNomPlantilla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNomPlantilla.Name = "txtNomPlantilla"
        Me.txtNomPlantilla.Size = New System.Drawing.Size(250, 39)
        '
        'lbNEW
        '
        Me.lbNEW.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNEW.ForeColor = System.Drawing.Color.Red
        Me.lbNEW.Name = "lbNEW"
        Me.lbNEW.Size = New System.Drawing.Size(56, 36)
        Me.lbNEW.Text = "NEW"
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Location = New System.Drawing.Point(735, 69)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(26, 21)
        Me.cmdExit.TabIndex = 183
        Me.cmdExit.Text = "Button1"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'frmPlantillesPublicitat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(787, 309)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.TabCtlDies)
        Me.Controls.Add(Me.cmdExit)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPlantillesPublicitat"
        Me.Resizable = False
        Me.Text = "Plantilles Publicitat"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.TabCtlDies.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.PanelDia.ResumeLayout(False)
        Me.PanelDia.PerformLayout()
        Me.PanelFrH.ResumeLayout(False)
        Me.PanelBlocs.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private lbNEW As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Private lbNom As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmdSalvar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdExitTool As System.Windows.Forms.ToolStripButton
    Friend ToolStrip1 As System.Windows.Forms.ToolStrip
    Private WithEvents txtNomPlantilla As System.Windows.Forms.ToolStripTextBox
    Friend Label10 As System.Windows.Forms.Label
    Friend Label11 As System.Windows.Forms.Label
    Friend Label12 As System.Windows.Forms.Label
    Friend Label13 As System.Windows.Forms.Label
    Friend Label14 As System.Windows.Forms.Label
    Friend Label15 As System.Windows.Forms.Label
    Friend Label16 As System.Windows.Forms.Label
    Friend Label17 As System.Windows.Forms.Label
    Friend Label18 As System.Windows.Forms.Label
    Friend Label19 As System.Windows.Forms.Label
    Friend Label20 As System.Windows.Forms.Label
    Friend Label21 As System.Windows.Forms.Label
    Friend Label22 As System.Windows.Forms.Label
    Friend Label23 As System.Windows.Forms.Label
    Friend Label24 As System.Windows.Forms.Label
    Friend Label25 As System.Windows.Forms.Label
    Friend Label26 As System.Windows.Forms.Label
    Friend Label27 As System.Windows.Forms.Label
    Friend Label28 As System.Windows.Forms.Label
    Friend Label29 As System.Windows.Forms.Label
    Friend Label30 As System.Windows.Forms.Label
    Friend Label31 As System.Windows.Forms.Label
    Friend Label32 As System.Windows.Forms.Label
    Friend Label33 As System.Windows.Forms.Label
    Friend Label34 As System.Windows.Forms.Label
    Friend Label35 As System.Windows.Forms.Label
    Friend Label36 As System.Windows.Forms.Label
    Friend Label37 As System.Windows.Forms.Label
    Friend Label39 As System.Windows.Forms.Label
    Friend PanelBlocs As System.Windows.Forms.Panel
    Friend Label38 As System.Windows.Forms.Label
    Friend Label40 As System.Windows.Forms.Label
    Friend Label41 As System.Windows.Forms.Label
    Friend Label42 As System.Windows.Forms.Label
    Friend Label43 As System.Windows.Forms.Label
    Friend Label44 As System.Windows.Forms.Label
    Friend Label45 As System.Windows.Forms.Label
    Friend Label46 As System.Windows.Forms.Label
    Friend Label47 As System.Windows.Forms.Label
    Friend Label48 As System.Windows.Forms.Label
    Friend Label49 As System.Windows.Forms.Label
    Friend Label50 As System.Windows.Forms.Label
    Friend Label51 As System.Windows.Forms.Label
    Friend Label52 As System.Windows.Forms.Label
    Friend Label53 As System.Windows.Forms.Label
    Friend Label54 As System.Windows.Forms.Label
    Friend Label55 As System.Windows.Forms.Label
    Friend Label56 As System.Windows.Forms.Label
    Friend Label57 As System.Windows.Forms.Label
    Friend Label58 As System.Windows.Forms.Label
    Friend Label59 As System.Windows.Forms.Label
    Friend Label60 As System.Windows.Forms.Label
    Friend Label61 As System.Windows.Forms.Label
    Friend Label62 As System.Windows.Forms.Label
    Friend Label63 As System.Windows.Forms.Label
    Friend PanelFrH As System.Windows.Forms.Panel
    Friend PanelDia As System.Windows.Forms.Panel
    Friend WithEvents CheckBox1 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox2 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox3 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox4 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox5 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox6 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox7 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox8 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox9 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox10 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox11 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox12 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox13 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox14 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox15 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox16 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox17 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox18 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox19 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox20 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox21 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox22 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox23 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox24 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox25 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox26 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox27 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox28 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox29 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox30 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox31 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox32 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox33 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox34 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox35 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox36 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox37 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox38 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox39 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox40 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox41 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox42 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox43 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox44 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox45 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox46 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox47 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox48 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox49 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox50 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox51 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox52 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox53 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox54 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox55 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox56 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox57 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox58 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox59 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox60 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox61 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox62 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox63 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox64 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox65 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox66 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox67 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox68 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox69 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox70 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox71 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox72 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox73 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox74 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox75 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox76 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox77 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox78 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox79 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox80 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox81 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox82 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox83 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox84 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox85 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox86 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox87 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox88 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox89 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox90 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox91 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox92 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox93 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox94 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox95 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox96 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents TabPage9 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents TabPage8 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents TabPage7 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents TabPage6 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents TabPage5 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents TabPage4 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents TabPage3 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents TabCtlDies As MetroFramework.Controls.MetroTabControl
End Class
