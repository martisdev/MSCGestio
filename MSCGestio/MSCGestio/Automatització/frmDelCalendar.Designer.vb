<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDelCalendar
    Inherits MetroFramework.Forms.MetroForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDelCalendar))
        Me.ComboBoxProgrames = New System.Windows.Forms.ComboBox()
        Me.label13 = New System.Windows.Forms.Label()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtDelProgramaOut = New MetroFramework.Controls.MetroDateTime()
        Me.txtDelProgramaIn = New MetroFramework.Controls.MetroDateTime()
        Me.label11 = New System.Windows.Forms.Label()
        Me.label12 = New System.Windows.Forms.Label()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdSortir = New MetroFramework.Controls.MetroLink()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.cmdDelTot = New MetroFramework.Controls.MetroTile()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MetroTabPage5 = New MetroFramework.Controls.MetroTabPage()
        Me.cmdDelEntreDates = New MetroFramework.Controls.MetroTile()
        Me.label10 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtDelEntreDataOut = New MetroFramework.Controls.MetroDateTime()
        Me.txtDelEntreDataIn = New MetroFramework.Controls.MetroDateTime()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.MetroTabPage6 = New MetroFramework.Controls.MetroTabPage()
        Me.cmdDelPrograma = New MetroFramework.Controls.MetroTile()
        Me.MetroTabPage3 = New MetroFramework.Controls.MetroTabPage()
        Me.GrupHores = New System.Windows.Forms.GroupBox()
        Me.MetroRadioButton19 = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroRadioButton20 = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroRadioButton21 = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroRadioButton22 = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroRadioButton23 = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroRadioButton24 = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroRadioButton13 = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroRadioButton14 = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroRadioButton15 = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroRadioButton16 = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroRadioButton17 = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroRadioButton18 = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroRadioButton6 = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroRadioButton7 = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroRadioButton9 = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroRadioButton10 = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroRadioButton11 = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroRadioButton12 = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroRadioButton5 = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroRadioButton4 = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroRadioButton3 = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroRadioButton2 = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroRadioButton1 = New MetroFramework.Controls.MetroRadioButton()
        Me.RadioButton8 = New MetroFramework.Controls.MetroRadioButton()
        Me.GrupDies = New System.Windows.Forms.GroupBox()
        Me.RadioButton7 = New MetroFramework.Controls.MetroRadioButton()
        Me.RadioButton6 = New MetroFramework.Controls.MetroRadioButton()
        Me.RadioButton5 = New MetroFramework.Controls.MetroRadioButton()
        Me.RadioButton4 = New MetroFramework.Controls.MetroRadioButton()
        Me.RadioButton3 = New MetroFramework.Controls.MetroRadioButton()
        Me.RadioButton2 = New MetroFramework.Controls.MetroRadioButton()
        Me.RadioButton1 = New MetroFramework.Controls.MetroRadioButton()
        Me.cmdDelDiaHora = New MetroFramework.Controls.MetroTile()
        Me.txtDataOut = New MetroFramework.Controls.MetroDateTime()
        Me.txtDataIn = New MetroFramework.Controls.MetroDateTime()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.cmdDelCaduc = New MetroFramework.Controls.MetroTile()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProgressSpinnerCaducats = New MetroFramework.Controls.MetroProgressSpinner()
        Me.groupBox2.SuspendLayout()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        Me.MetroTabPage5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.MetroTabPage6.SuspendLayout()
        Me.MetroTabPage3.SuspendLayout()
        Me.GrupHores.SuspendLayout()
        Me.GrupDies.SuspendLayout()
        Me.MetroTabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBoxProgrames
        '
        Me.ComboBoxProgrames.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxProgrames.FormattingEnabled = True
        Me.ComboBoxProgrames.Location = New System.Drawing.Point(46, 81)
        Me.ComboBoxProgrames.Name = "ComboBoxProgrames"
        Me.ComboBoxProgrames.Size = New System.Drawing.Size(324, 25)
        Me.ComboBoxProgrames.TabIndex = 0
        '
        'label13
        '
        Me.label13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label13.BackColor = System.Drawing.Color.Transparent
        Me.label13.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label13.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.label13.Location = New System.Drawing.Point(49, 19)
        Me.label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(319, 59)
        Me.label13.TabIndex = 8
        Me.label13.Text = "Eliminació de tots els registres del calendari programats entre les dates assigna" &
    "ts al programa"
        '
        'groupBox2
        '
        Me.groupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBox2.BackColor = System.Drawing.Color.Transparent
        Me.groupBox2.Controls.Add(Me.txtDelProgramaOut)
        Me.groupBox2.Controls.Add(Me.txtDelProgramaIn)
        Me.groupBox2.Controls.Add(Me.label11)
        Me.groupBox2.Controls.Add(Me.label12)
        Me.groupBox2.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox2.Location = New System.Drawing.Point(46, 106)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(324, 110)
        Me.groupBox2.TabIndex = 7
        Me.groupBox2.TabStop = False
        '
        'txtDelProgramaOut
        '
        Me.txtDelProgramaOut.Location = New System.Drawing.Point(103, 59)
        Me.txtDelProgramaOut.MinimumSize = New System.Drawing.Size(0, 29)
        Me.txtDelProgramaOut.Name = "txtDelProgramaOut"
        Me.txtDelProgramaOut.Size = New System.Drawing.Size(207, 29)
        Me.txtDelProgramaOut.TabIndex = 1
        '
        'txtDelProgramaIn
        '
        Me.txtDelProgramaIn.Location = New System.Drawing.Point(103, 24)
        Me.txtDelProgramaIn.MinimumSize = New System.Drawing.Size(0, 29)
        Me.txtDelProgramaIn.Name = "txtDelProgramaIn"
        Me.txtDelProgramaIn.Size = New System.Drawing.Size(209, 29)
        Me.txtDelProgramaIn.TabIndex = 0
        '
        'label11
        '
        Me.label11.Location = New System.Drawing.Point(5, 61)
        Me.label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(87, 25)
        Me.label11.TabIndex = 12
        Me.label11.Text = "Data Fí"
        Me.label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'label12
        '
        Me.label12.Location = New System.Drawing.Point(5, 26)
        Me.label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(87, 25)
        Me.label12.TabIndex = 11
        Me.label12.Text = "Data Inici"
        Me.label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Image = CType(resources.GetObject("cmdExit.Image"), System.Drawing.Image)
        Me.cmdExit.Location = New System.Drawing.Point(398, 34)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(28, 26)
        Me.cmdExit.TabIndex = 3
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'cmdSortir
        '
        Me.cmdSortir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdSortir.Image = CType(resources.GetObject("cmdSortir.Image"), System.Drawing.Image)
        Me.cmdSortir.ImageSize = 32
        Me.cmdSortir.Location = New System.Drawing.Point(394, 26)
        Me.cmdSortir.Name = "cmdSortir"
        Me.cmdSortir.Size = New System.Drawing.Size(40, 42)
        Me.cmdSortir.TabIndex = 8
        Me.cmdSortir.UseSelectable = True
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage5)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage6)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage3)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage2)
        Me.MetroTabControl1.Location = New System.Drawing.Point(13, 95)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(425, 355)
        Me.MetroTabControl1.TabIndex = 1
        Me.MetroTabControl1.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.cmdDelTot)
        Me.MetroTabPage1.Controls.Add(Me.Label1)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(417, 313)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "Tot"
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'cmdDelTot
        '
        Me.cmdDelTot.ActiveControl = Nothing
        Me.cmdDelTot.Location = New System.Drawing.Point(124, 271)
        Me.cmdDelTot.Name = "cmdDelTot"
        Me.cmdDelTot.Size = New System.Drawing.Size(169, 39)
        Me.cmdDelTot.TabIndex = 0
        Me.cmdDelTot.Text = "Esborrar"
        Me.cmdDelTot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdDelTot.TileImage = CType(resources.GetObject("cmdDelTot.TileImage"), System.Drawing.Image)
        Me.cmdDelTot.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDelTot.UseSelectable = True
        Me.cmdDelTot.UseTileImage = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(49, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(319, 64)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Eliminació de tots els registres del calendari"
        '
        'MetroTabPage5
        '
        Me.MetroTabPage5.Controls.Add(Me.cmdDelEntreDates)
        Me.MetroTabPage5.Controls.Add(Me.label10)
        Me.MetroTabPage5.Controls.Add(Me.GroupBox3)
        Me.MetroTabPage5.HorizontalScrollbarBarColor = True
        Me.MetroTabPage5.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage5.HorizontalScrollbarSize = 10
        Me.MetroTabPage5.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage5.Name = "MetroTabPage5"
        Me.MetroTabPage5.Size = New System.Drawing.Size(417, 313)
        Me.MetroTabPage5.TabIndex = 4
        Me.MetroTabPage5.Text = "Entre dates"
        Me.MetroTabPage5.VerticalScrollbarBarColor = True
        Me.MetroTabPage5.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage5.VerticalScrollbarSize = 10
        '
        'cmdDelEntreDates
        '
        Me.cmdDelEntreDates.ActiveControl = Nothing
        Me.cmdDelEntreDates.Location = New System.Drawing.Point(124, 271)
        Me.cmdDelEntreDates.Name = "cmdDelEntreDates"
        Me.cmdDelEntreDates.Size = New System.Drawing.Size(169, 39)
        Me.cmdDelEntreDates.TabIndex = 22
        Me.cmdDelEntreDates.Text = "Esborrar"
        Me.cmdDelEntreDates.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdDelEntreDates.TileImage = CType(resources.GetObject("cmdDelEntreDates.TileImage"), System.Drawing.Image)
        Me.cmdDelEntreDates.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDelEntreDates.UseSelectable = True
        Me.cmdDelEntreDates.UseTileImage = True
        '
        'label10
        '
        Me.label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label10.BackColor = System.Drawing.Color.Transparent
        Me.label10.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.label10.Location = New System.Drawing.Point(49, 19)
        Me.label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(319, 64)
        Me.label10.TabIndex = 20
        Me.label10.Text = "Eliminació de tots els registres del calendari programats entre les dates"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.txtDelEntreDataOut)
        Me.GroupBox3.Controls.Add(Me.txtDelEntreDataIn)
        Me.GroupBox3.Controls.Add(Me.label8)
        Me.GroupBox3.Controls.Add(Me.label9)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(46, 106)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(324, 110)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        '
        'txtDelEntreDataOut
        '
        Me.txtDelEntreDataOut.Location = New System.Drawing.Point(103, 59)
        Me.txtDelEntreDataOut.MinimumSize = New System.Drawing.Size(0, 29)
        Me.txtDelEntreDataOut.Name = "txtDelEntreDataOut"
        Me.txtDelEntreDataOut.Size = New System.Drawing.Size(207, 29)
        Me.txtDelEntreDataOut.TabIndex = 14
        '
        'txtDelEntreDataIn
        '
        Me.txtDelEntreDataIn.Location = New System.Drawing.Point(103, 24)
        Me.txtDelEntreDataIn.MinimumSize = New System.Drawing.Size(0, 29)
        Me.txtDelEntreDataIn.Name = "txtDelEntreDataIn"
        Me.txtDelEntreDataIn.Size = New System.Drawing.Size(209, 29)
        Me.txtDelEntreDataIn.TabIndex = 13
        '
        'label8
        '
        Me.label8.Location = New System.Drawing.Point(5, 61)
        Me.label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(87, 25)
        Me.label8.TabIndex = 12
        Me.label8.Text = "Data Fí"
        Me.label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'label9
        '
        Me.label9.Location = New System.Drawing.Point(5, 26)
        Me.label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(87, 25)
        Me.label9.TabIndex = 11
        Me.label9.Text = "Data Inici"
        Me.label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'MetroTabPage6
        '
        Me.MetroTabPage6.Controls.Add(Me.cmdDelPrograma)
        Me.MetroTabPage6.Controls.Add(Me.ComboBoxProgrames)
        Me.MetroTabPage6.Controls.Add(Me.label13)
        Me.MetroTabPage6.Controls.Add(Me.groupBox2)
        Me.MetroTabPage6.HorizontalScrollbarBarColor = True
        Me.MetroTabPage6.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage6.HorizontalScrollbarSize = 10
        Me.MetroTabPage6.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage6.Name = "MetroTabPage6"
        Me.MetroTabPage6.Size = New System.Drawing.Size(417, 313)
        Me.MetroTabPage6.TabIndex = 5
        Me.MetroTabPage6.Text = "Programa"
        Me.MetroTabPage6.VerticalScrollbarBarColor = True
        Me.MetroTabPage6.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage6.VerticalScrollbarSize = 10
        '
        'cmdDelPrograma
        '
        Me.cmdDelPrograma.ActiveControl = Nothing
        Me.cmdDelPrograma.Location = New System.Drawing.Point(124, 271)
        Me.cmdDelPrograma.Name = "cmdDelPrograma"
        Me.cmdDelPrograma.Size = New System.Drawing.Size(169, 39)
        Me.cmdDelPrograma.TabIndex = 1
        Me.cmdDelPrograma.Text = "Esborrar"
        Me.cmdDelPrograma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdDelPrograma.TileImage = CType(resources.GetObject("cmdDelPrograma.TileImage"), System.Drawing.Image)
        Me.cmdDelPrograma.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDelPrograma.UseSelectable = True
        Me.cmdDelPrograma.UseTileImage = True
        '
        'MetroTabPage3
        '
        Me.MetroTabPage3.Controls.Add(Me.GrupHores)
        Me.MetroTabPage3.Controls.Add(Me.GrupDies)
        Me.MetroTabPage3.Controls.Add(Me.cmdDelDiaHora)
        Me.MetroTabPage3.Controls.Add(Me.txtDataOut)
        Me.MetroTabPage3.Controls.Add(Me.txtDataIn)
        Me.MetroTabPage3.Controls.Add(Me.Label4)
        Me.MetroTabPage3.Controls.Add(Me.Label3)
        Me.MetroTabPage3.HorizontalScrollbarBarColor = True
        Me.MetroTabPage3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.HorizontalScrollbarSize = 10
        Me.MetroTabPage3.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage3.Name = "MetroTabPage3"
        Me.MetroTabPage3.Size = New System.Drawing.Size(417, 313)
        Me.MetroTabPage3.TabIndex = 2
        Me.MetroTabPage3.Text = "Dia-Hora"
        Me.MetroTabPage3.VerticalScrollbarBarColor = True
        Me.MetroTabPage3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.VerticalScrollbarSize = 10
        '
        'GrupHores
        '
        Me.GrupHores.BackColor = System.Drawing.Color.Transparent
        Me.GrupHores.Controls.Add(Me.MetroRadioButton19)
        Me.GrupHores.Controls.Add(Me.MetroRadioButton20)
        Me.GrupHores.Controls.Add(Me.MetroRadioButton21)
        Me.GrupHores.Controls.Add(Me.MetroRadioButton22)
        Me.GrupHores.Controls.Add(Me.MetroRadioButton23)
        Me.GrupHores.Controls.Add(Me.MetroRadioButton24)
        Me.GrupHores.Controls.Add(Me.MetroRadioButton13)
        Me.GrupHores.Controls.Add(Me.MetroRadioButton14)
        Me.GrupHores.Controls.Add(Me.MetroRadioButton15)
        Me.GrupHores.Controls.Add(Me.MetroRadioButton16)
        Me.GrupHores.Controls.Add(Me.MetroRadioButton17)
        Me.GrupHores.Controls.Add(Me.MetroRadioButton18)
        Me.GrupHores.Controls.Add(Me.MetroRadioButton6)
        Me.GrupHores.Controls.Add(Me.MetroRadioButton7)
        Me.GrupHores.Controls.Add(Me.MetroRadioButton9)
        Me.GrupHores.Controls.Add(Me.MetroRadioButton10)
        Me.GrupHores.Controls.Add(Me.MetroRadioButton11)
        Me.GrupHores.Controls.Add(Me.MetroRadioButton12)
        Me.GrupHores.Controls.Add(Me.MetroRadioButton5)
        Me.GrupHores.Controls.Add(Me.MetroRadioButton4)
        Me.GrupHores.Controls.Add(Me.MetroRadioButton3)
        Me.GrupHores.Controls.Add(Me.MetroRadioButton2)
        Me.GrupHores.Controls.Add(Me.MetroRadioButton1)
        Me.GrupHores.Controls.Add(Me.RadioButton8)
        Me.GrupHores.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrupHores.Location = New System.Drawing.Point(180, 84)
        Me.GrupHores.Name = "GrupHores"
        Me.GrupHores.Size = New System.Drawing.Size(202, 174)
        Me.GrupHores.TabIndex = 30
        Me.GrupHores.TabStop = False
        Me.GrupHores.Text = "Hores dia"
        '
        'MetroRadioButton19
        '
        Me.MetroRadioButton19.AutoSize = True
        Me.MetroRadioButton19.Location = New System.Drawing.Point(141, 131)
        Me.MetroRadioButton19.Name = "MetroRadioButton19"
        Me.MetroRadioButton19.Size = New System.Drawing.Size(35, 15)
        Me.MetroRadioButton19.TabIndex = 23
        Me.MetroRadioButton19.Tag = "23"
        Me.MetroRadioButton19.Text = "23"
        Me.MetroRadioButton19.UseSelectable = True
        '
        'MetroRadioButton20
        '
        Me.MetroRadioButton20.AutoSize = True
        Me.MetroRadioButton20.Location = New System.Drawing.Point(141, 110)
        Me.MetroRadioButton20.Name = "MetroRadioButton20"
        Me.MetroRadioButton20.Size = New System.Drawing.Size(35, 15)
        Me.MetroRadioButton20.TabIndex = 22
        Me.MetroRadioButton20.Tag = "22"
        Me.MetroRadioButton20.Text = "22"
        Me.MetroRadioButton20.UseSelectable = True
        '
        'MetroRadioButton21
        '
        Me.MetroRadioButton21.AutoSize = True
        Me.MetroRadioButton21.Location = New System.Drawing.Point(141, 89)
        Me.MetroRadioButton21.Name = "MetroRadioButton21"
        Me.MetroRadioButton21.Size = New System.Drawing.Size(35, 15)
        Me.MetroRadioButton21.TabIndex = 21
        Me.MetroRadioButton21.Tag = "21"
        Me.MetroRadioButton21.Text = "21"
        Me.MetroRadioButton21.UseSelectable = True
        '
        'MetroRadioButton22
        '
        Me.MetroRadioButton22.AutoSize = True
        Me.MetroRadioButton22.Location = New System.Drawing.Point(141, 68)
        Me.MetroRadioButton22.Name = "MetroRadioButton22"
        Me.MetroRadioButton22.Size = New System.Drawing.Size(35, 15)
        Me.MetroRadioButton22.TabIndex = 20
        Me.MetroRadioButton22.Tag = "20"
        Me.MetroRadioButton22.Text = "20"
        Me.MetroRadioButton22.UseSelectable = True
        '
        'MetroRadioButton23
        '
        Me.MetroRadioButton23.AutoSize = True
        Me.MetroRadioButton23.Location = New System.Drawing.Point(141, 47)
        Me.MetroRadioButton23.Name = "MetroRadioButton23"
        Me.MetroRadioButton23.Size = New System.Drawing.Size(35, 15)
        Me.MetroRadioButton23.TabIndex = 19
        Me.MetroRadioButton23.Tag = "19"
        Me.MetroRadioButton23.Text = "19"
        Me.MetroRadioButton23.UseSelectable = True
        '
        'MetroRadioButton24
        '
        Me.MetroRadioButton24.AutoSize = True
        Me.MetroRadioButton24.Location = New System.Drawing.Point(141, 26)
        Me.MetroRadioButton24.Name = "MetroRadioButton24"
        Me.MetroRadioButton24.Size = New System.Drawing.Size(35, 15)
        Me.MetroRadioButton24.TabIndex = 18
        Me.MetroRadioButton24.Tag = "18"
        Me.MetroRadioButton24.Text = "18"
        Me.MetroRadioButton24.UseSelectable = True
        '
        'MetroRadioButton13
        '
        Me.MetroRadioButton13.AutoSize = True
        Me.MetroRadioButton13.Location = New System.Drawing.Point(100, 131)
        Me.MetroRadioButton13.Name = "MetroRadioButton13"
        Me.MetroRadioButton13.Size = New System.Drawing.Size(35, 15)
        Me.MetroRadioButton13.TabIndex = 17
        Me.MetroRadioButton13.Tag = "17"
        Me.MetroRadioButton13.Text = "17"
        Me.MetroRadioButton13.UseSelectable = True
        '
        'MetroRadioButton14
        '
        Me.MetroRadioButton14.AutoSize = True
        Me.MetroRadioButton14.Location = New System.Drawing.Point(100, 110)
        Me.MetroRadioButton14.Name = "MetroRadioButton14"
        Me.MetroRadioButton14.Size = New System.Drawing.Size(35, 15)
        Me.MetroRadioButton14.TabIndex = 16
        Me.MetroRadioButton14.Tag = "16"
        Me.MetroRadioButton14.Text = "16"
        Me.MetroRadioButton14.UseSelectable = True
        '
        'MetroRadioButton15
        '
        Me.MetroRadioButton15.AutoSize = True
        Me.MetroRadioButton15.Location = New System.Drawing.Point(100, 89)
        Me.MetroRadioButton15.Name = "MetroRadioButton15"
        Me.MetroRadioButton15.Size = New System.Drawing.Size(35, 15)
        Me.MetroRadioButton15.TabIndex = 15
        Me.MetroRadioButton15.Tag = "15"
        Me.MetroRadioButton15.Text = "15"
        Me.MetroRadioButton15.UseSelectable = True
        '
        'MetroRadioButton16
        '
        Me.MetroRadioButton16.AutoSize = True
        Me.MetroRadioButton16.Location = New System.Drawing.Point(100, 68)
        Me.MetroRadioButton16.Name = "MetroRadioButton16"
        Me.MetroRadioButton16.Size = New System.Drawing.Size(35, 15)
        Me.MetroRadioButton16.TabIndex = 14
        Me.MetroRadioButton16.Tag = "14"
        Me.MetroRadioButton16.Text = "14"
        Me.MetroRadioButton16.UseSelectable = True
        '
        'MetroRadioButton17
        '
        Me.MetroRadioButton17.AutoSize = True
        Me.MetroRadioButton17.Location = New System.Drawing.Point(100, 47)
        Me.MetroRadioButton17.Name = "MetroRadioButton17"
        Me.MetroRadioButton17.Size = New System.Drawing.Size(35, 15)
        Me.MetroRadioButton17.TabIndex = 13
        Me.MetroRadioButton17.Tag = "13"
        Me.MetroRadioButton17.Text = "13"
        Me.MetroRadioButton17.UseSelectable = True
        '
        'MetroRadioButton18
        '
        Me.MetroRadioButton18.AutoSize = True
        Me.MetroRadioButton18.Location = New System.Drawing.Point(100, 26)
        Me.MetroRadioButton18.Name = "MetroRadioButton18"
        Me.MetroRadioButton18.Size = New System.Drawing.Size(35, 15)
        Me.MetroRadioButton18.TabIndex = 12
        Me.MetroRadioButton18.Tag = "12"
        Me.MetroRadioButton18.Text = "12"
        Me.MetroRadioButton18.UseSelectable = True
        '
        'MetroRadioButton6
        '
        Me.MetroRadioButton6.AutoSize = True
        Me.MetroRadioButton6.Location = New System.Drawing.Point(59, 131)
        Me.MetroRadioButton6.Name = "MetroRadioButton6"
        Me.MetroRadioButton6.Size = New System.Drawing.Size(35, 15)
        Me.MetroRadioButton6.TabIndex = 11
        Me.MetroRadioButton6.Tag = "11"
        Me.MetroRadioButton6.Text = "11"
        Me.MetroRadioButton6.UseSelectable = True
        '
        'MetroRadioButton7
        '
        Me.MetroRadioButton7.AutoSize = True
        Me.MetroRadioButton7.Location = New System.Drawing.Point(59, 110)
        Me.MetroRadioButton7.Name = "MetroRadioButton7"
        Me.MetroRadioButton7.Size = New System.Drawing.Size(35, 15)
        Me.MetroRadioButton7.TabIndex = 10
        Me.MetroRadioButton7.Tag = "10"
        Me.MetroRadioButton7.Text = "10"
        Me.MetroRadioButton7.UseSelectable = True
        '
        'MetroRadioButton9
        '
        Me.MetroRadioButton9.AutoSize = True
        Me.MetroRadioButton9.Location = New System.Drawing.Point(59, 89)
        Me.MetroRadioButton9.Name = "MetroRadioButton9"
        Me.MetroRadioButton9.Size = New System.Drawing.Size(35, 15)
        Me.MetroRadioButton9.TabIndex = 9
        Me.MetroRadioButton9.Tag = "9"
        Me.MetroRadioButton9.Text = "09"
        Me.MetroRadioButton9.UseSelectable = True
        '
        'MetroRadioButton10
        '
        Me.MetroRadioButton10.AutoSize = True
        Me.MetroRadioButton10.Location = New System.Drawing.Point(59, 68)
        Me.MetroRadioButton10.Name = "MetroRadioButton10"
        Me.MetroRadioButton10.Size = New System.Drawing.Size(35, 15)
        Me.MetroRadioButton10.TabIndex = 8
        Me.MetroRadioButton10.Tag = "8"
        Me.MetroRadioButton10.Text = "08"
        Me.MetroRadioButton10.UseSelectable = True
        '
        'MetroRadioButton11
        '
        Me.MetroRadioButton11.AutoSize = True
        Me.MetroRadioButton11.Location = New System.Drawing.Point(59, 47)
        Me.MetroRadioButton11.Name = "MetroRadioButton11"
        Me.MetroRadioButton11.Size = New System.Drawing.Size(35, 15)
        Me.MetroRadioButton11.TabIndex = 7
        Me.MetroRadioButton11.Tag = "7"
        Me.MetroRadioButton11.Text = "07"
        Me.MetroRadioButton11.UseSelectable = True
        '
        'MetroRadioButton12
        '
        Me.MetroRadioButton12.AutoSize = True
        Me.MetroRadioButton12.Location = New System.Drawing.Point(59, 26)
        Me.MetroRadioButton12.Name = "MetroRadioButton12"
        Me.MetroRadioButton12.Size = New System.Drawing.Size(35, 15)
        Me.MetroRadioButton12.TabIndex = 6
        Me.MetroRadioButton12.Tag = "6"
        Me.MetroRadioButton12.Text = "06"
        Me.MetroRadioButton12.UseSelectable = True
        '
        'MetroRadioButton5
        '
        Me.MetroRadioButton5.AutoSize = True
        Me.MetroRadioButton5.Location = New System.Drawing.Point(18, 131)
        Me.MetroRadioButton5.Name = "MetroRadioButton5"
        Me.MetroRadioButton5.Size = New System.Drawing.Size(35, 15)
        Me.MetroRadioButton5.TabIndex = 5
        Me.MetroRadioButton5.Tag = "5"
        Me.MetroRadioButton5.Text = "05"
        Me.MetroRadioButton5.UseSelectable = True
        '
        'MetroRadioButton4
        '
        Me.MetroRadioButton4.AutoSize = True
        Me.MetroRadioButton4.Location = New System.Drawing.Point(18, 110)
        Me.MetroRadioButton4.Name = "MetroRadioButton4"
        Me.MetroRadioButton4.Size = New System.Drawing.Size(35, 15)
        Me.MetroRadioButton4.TabIndex = 4
        Me.MetroRadioButton4.Tag = "4"
        Me.MetroRadioButton4.Text = "04"
        Me.MetroRadioButton4.UseSelectable = True
        '
        'MetroRadioButton3
        '
        Me.MetroRadioButton3.AutoSize = True
        Me.MetroRadioButton3.Location = New System.Drawing.Point(18, 89)
        Me.MetroRadioButton3.Name = "MetroRadioButton3"
        Me.MetroRadioButton3.Size = New System.Drawing.Size(35, 15)
        Me.MetroRadioButton3.TabIndex = 3
        Me.MetroRadioButton3.Tag = "3"
        Me.MetroRadioButton3.Text = "03"
        Me.MetroRadioButton3.UseSelectable = True
        '
        'MetroRadioButton2
        '
        Me.MetroRadioButton2.AutoSize = True
        Me.MetroRadioButton2.Location = New System.Drawing.Point(18, 68)
        Me.MetroRadioButton2.Name = "MetroRadioButton2"
        Me.MetroRadioButton2.Size = New System.Drawing.Size(35, 15)
        Me.MetroRadioButton2.TabIndex = 2
        Me.MetroRadioButton2.Tag = "2"
        Me.MetroRadioButton2.Text = "02"
        Me.MetroRadioButton2.UseSelectable = True
        '
        'MetroRadioButton1
        '
        Me.MetroRadioButton1.AutoSize = True
        Me.MetroRadioButton1.Location = New System.Drawing.Point(18, 47)
        Me.MetroRadioButton1.Name = "MetroRadioButton1"
        Me.MetroRadioButton1.Size = New System.Drawing.Size(35, 15)
        Me.MetroRadioButton1.TabIndex = 1
        Me.MetroRadioButton1.Tag = "1"
        Me.MetroRadioButton1.Text = "01"
        Me.MetroRadioButton1.UseSelectable = True
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.Location = New System.Drawing.Point(18, 26)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(35, 15)
        Me.RadioButton8.TabIndex = 0
        Me.RadioButton8.Tag = "0"
        Me.RadioButton8.Text = "00"
        Me.RadioButton8.UseSelectable = True
        '
        'GrupDies
        '
        Me.GrupDies.BackColor = System.Drawing.Color.Transparent
        Me.GrupDies.Controls.Add(Me.RadioButton7)
        Me.GrupDies.Controls.Add(Me.RadioButton6)
        Me.GrupDies.Controls.Add(Me.RadioButton5)
        Me.GrupDies.Controls.Add(Me.RadioButton4)
        Me.GrupDies.Controls.Add(Me.RadioButton3)
        Me.GrupDies.Controls.Add(Me.RadioButton2)
        Me.GrupDies.Controls.Add(Me.RadioButton1)
        Me.GrupDies.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrupDies.Location = New System.Drawing.Point(49, 84)
        Me.GrupDies.Name = "GrupDies"
        Me.GrupDies.Size = New System.Drawing.Size(113, 175)
        Me.GrupDies.TabIndex = 29
        Me.GrupDies.TabStop = False
        Me.GrupDies.Text = "Dies Setmana"
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.Location = New System.Drawing.Point(15, 144)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(78, 15)
        Me.RadioButton7.TabIndex = 6
        Me.RadioButton7.Tag = "7"
        Me.RadioButton7.Text = "Diumenge"
        Me.RadioButton7.UseSelectable = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(15, 124)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(67, 15)
        Me.RadioButton6.TabIndex = 5
        Me.RadioButton6.Tag = "6"
        Me.RadioButton6.Text = "Dissabte"
        Me.RadioButton6.UseSelectable = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(15, 104)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(75, 15)
        Me.RadioButton5.TabIndex = 4
        Me.RadioButton5.Tag = "5"
        Me.RadioButton5.Text = "Divendres"
        Me.RadioButton5.UseSelectable = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(15, 84)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(56, 15)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.Tag = "4"
        Me.RadioButton4.Text = "Dijous"
        Me.RadioButton4.UseSelectable = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(15, 64)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(72, 15)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.Tag = "3"
        Me.RadioButton3.Text = "Dimecres"
        Me.RadioButton3.UseSelectable = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(15, 44)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(64, 15)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Tag = "2"
        Me.RadioButton2.Text = "Dimarts"
        Me.RadioButton2.UseSelectable = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(15, 24)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(59, 15)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.Tag = "1"
        Me.RadioButton1.Text = "Dilluns"
        Me.RadioButton1.UseSelectable = True
        '
        'cmdDelDiaHora
        '
        Me.cmdDelDiaHora.ActiveControl = Nothing
        Me.cmdDelDiaHora.Location = New System.Drawing.Point(124, 271)
        Me.cmdDelDiaHora.Name = "cmdDelDiaHora"
        Me.cmdDelDiaHora.Size = New System.Drawing.Size(169, 39)
        Me.cmdDelDiaHora.TabIndex = 2
        Me.cmdDelDiaHora.Text = "Esborrar"
        Me.cmdDelDiaHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdDelDiaHora.TileImage = CType(resources.GetObject("cmdDelDiaHora.TileImage"), System.Drawing.Image)
        Me.cmdDelDiaHora.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDelDiaHora.UseSelectable = True
        Me.cmdDelDiaHora.UseTileImage = True
        '
        'txtDataOut
        '
        Me.txtDataOut.Location = New System.Drawing.Point(144, 48)
        Me.txtDataOut.MinimumSize = New System.Drawing.Size(0, 29)
        Me.txtDataOut.Name = "txtDataOut"
        Me.txtDataOut.Size = New System.Drawing.Size(207, 29)
        Me.txtDataOut.TabIndex = 1
        '
        'txtDataIn
        '
        Me.txtDataIn.Location = New System.Drawing.Point(144, 13)
        Me.txtDataIn.MinimumSize = New System.Drawing.Size(0, 29)
        Me.txtDataIn.Name = "txtDataIn"
        Me.txtDataIn.Size = New System.Drawing.Size(209, 29)
        Me.txtDataIn.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(46, 50)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 25)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Data Fí"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 15)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 25)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Data Inici"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.Controls.Add(Me.ProgressSpinnerCaducats)
        Me.MetroTabPage2.Controls.Add(Me.cmdDelCaduc)
        Me.MetroTabPage2.Controls.Add(Me.Label2)
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 10
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(417, 313)
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "Caducat"
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 10
        '
        'cmdDelCaduc
        '
        Me.cmdDelCaduc.ActiveControl = Nothing
        Me.cmdDelCaduc.Location = New System.Drawing.Point(124, 271)
        Me.cmdDelCaduc.Name = "cmdDelCaduc"
        Me.cmdDelCaduc.Size = New System.Drawing.Size(169, 39)
        Me.cmdDelCaduc.TabIndex = 0
        Me.cmdDelCaduc.Text = "Esborrar"
        Me.cmdDelCaduc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdDelCaduc.TileImage = CType(resources.GetObject("cmdDelCaduc.TileImage"), System.Drawing.Image)
        Me.cmdDelCaduc.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDelCaduc.UseSelectable = True
        Me.cmdDelCaduc.UseTileImage = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(49, 19)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(319, 64)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Eliminació dels registres del calendari caducats"
        '
        'ProgressSpinnerCaducats
        '
        Me.ProgressSpinnerCaducats.Location = New System.Drawing.Point(140, 73)
        Me.ProgressSpinnerCaducats.Maximum = 100
        Me.ProgressSpinnerCaducats.Name = "ProgressSpinnerCaducats"
        Me.ProgressSpinnerCaducats.Size = New System.Drawing.Size(135, 120)
        Me.ProgressSpinnerCaducats.TabIndex = 27
        Me.ProgressSpinnerCaducats.UseSelectable = True
        Me.ProgressSpinnerCaducats.Visible = False
        '
        'frmDelCalendar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(455, 471)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Controls.Add(Me.cmdSortir)
        Me.Controls.Add(Me.cmdExit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(455, 471)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(455, 471)
        Me.Name = "frmDelCalendar"
        Me.Resizable = False
        Me.Text = "Eliminació Massiva "
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.groupBox2.ResumeLayout(False)
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.MetroTabPage5.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.MetroTabPage6.ResumeLayout(False)
        Me.MetroTabPage3.ResumeLayout(False)
        Me.GrupHores.ResumeLayout(False)
        Me.GrupHores.PerformLayout()
        Me.GrupDies.ResumeLayout(False)
        Me.GrupDies.PerformLayout()
        Me.MetroTabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend ComboBoxProgrames As System.Windows.Forms.ComboBox
    Friend label12 As System.Windows.Forms.Label
    Friend label11 As System.Windows.Forms.Label
    Friend groupBox2 As System.Windows.Forms.GroupBox
    Friend label13 As System.Windows.Forms.Label
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents txtDelProgramaOut As MetroFramework.Controls.MetroDateTime
    Friend WithEvents txtDelProgramaIn As MetroFramework.Controls.MetroDateTime
    Friend WithEvents cmdSortir As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage3 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage5 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents cmdDelEntreDates As MetroFramework.Controls.MetroTile
    Friend WithEvents label10 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtDelEntreDataOut As MetroFramework.Controls.MetroDateTime
    Friend WithEvents txtDelEntreDataIn As MetroFramework.Controls.MetroDateTime
    Friend WithEvents label8 As Label
    Friend WithEvents label9 As Label
    Friend WithEvents MetroTabPage6 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents cmdDelPrograma As MetroFramework.Controls.MetroTile
    Friend WithEvents txtDataOut As MetroFramework.Controls.MetroDateTime
    Friend WithEvents txtDataIn As MetroFramework.Controls.MetroDateTime
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmdDelCaduc As MetroFramework.Controls.MetroTile
    Friend WithEvents Label2 As Label
    Friend WithEvents cmdDelTot As MetroFramework.Controls.MetroTile
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdDelDiaHora As MetroFramework.Controls.MetroTile
    Friend WithEvents GrupHores As GroupBox
    Friend WithEvents MetroRadioButton19 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroRadioButton20 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroRadioButton21 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroRadioButton22 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroRadioButton23 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroRadioButton24 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroRadioButton13 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroRadioButton14 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroRadioButton15 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroRadioButton16 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroRadioButton17 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroRadioButton18 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroRadioButton6 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroRadioButton7 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroRadioButton9 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroRadioButton10 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroRadioButton11 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroRadioButton12 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroRadioButton5 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroRadioButton4 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroRadioButton3 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroRadioButton2 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroRadioButton1 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents RadioButton8 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents GrupDies As GroupBox
    Friend WithEvents RadioButton7 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents RadioButton6 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents RadioButton5 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents RadioButton4 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents RadioButton3 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents RadioButton2 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents RadioButton1 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents ProgressSpinnerCaducats As MetroFramework.Controls.MetroProgressSpinner
End Class
