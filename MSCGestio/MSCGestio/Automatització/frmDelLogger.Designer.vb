'
' Creado por SharpDevelop.
' Usuario: Marti
' Fecha: 19/01/2017
' Hora: 09:13
' 
' Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
'
Partial Class frmDelLogger
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDelLogger))
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdSortir = New MetroFramework.Controls.MetroLink()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.cmdDelTot = New MetroFramework.Controls.MetroTile()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.cmdDelCaduc = New MetroFramework.Controls.MetroTile()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MetroTabPage3 = New MetroFramework.Controls.MetroTabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtDelEntreDataOut = New MetroFramework.Controls.MetroDateTime()
        Me.txtDelEntreDataIn = New MetroFramework.Controls.MetroDateTime()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.cmdDelEntreDates = New MetroFramework.Controls.MetroTile()
        Me.label10 = New System.Windows.Forms.Label()
        Me.MetroTabPage4 = New MetroFramework.Controls.MetroTabPage()
        Me.ComboBoxProgrames = New MetroFramework.Controls.MetroComboBox()
        Me.label13 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDelProgramaOut = New MetroFramework.Controls.MetroDateTime()
        Me.txtDelProgramaIn = New MetroFramework.Controls.MetroDateTime()
        Me.label11 = New System.Windows.Forms.Label()
        Me.label12 = New System.Windows.Forms.Label()
        Me.cmdDelPrograma = New MetroFramework.Controls.MetroTile()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        Me.MetroTabPage2.SuspendLayout()
        Me.MetroTabPage3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.MetroTabPage4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Image = CType(resources.GetObject("cmdExit.Image"), System.Drawing.Image)
        Me.cmdExit.Location = New System.Drawing.Point(404, 34)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(21, 29)
        Me.cmdExit.TabIndex = 0
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
        Me.cmdSortir.TabIndex = 1
        Me.cmdSortir.UseSelectable = True
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage2)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage3)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage4)
        Me.MetroTabControl1.Location = New System.Drawing.Point(17, 92)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(420, 356)
        Me.MetroTabControl1.TabIndex = 10
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
        Me.MetroTabPage1.Size = New System.Drawing.Size(412, 314)
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
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Eliminació de tots els registres del logger"
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.Controls.Add(Me.cmdDelCaduc)
        Me.MetroTabPage2.Controls.Add(Me.Label2)
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 10
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(412, 314)
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
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Eliminació dels registres del logger caducats"
        '
        'MetroTabPage3
        '
        Me.MetroTabPage3.Controls.Add(Me.GroupBox3)
        Me.MetroTabPage3.Controls.Add(Me.cmdDelEntreDates)
        Me.MetroTabPage3.Controls.Add(Me.label10)
        Me.MetroTabPage3.HorizontalScrollbarBarColor = True
        Me.MetroTabPage3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.HorizontalScrollbarSize = 10
        Me.MetroTabPage3.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage3.Name = "MetroTabPage3"
        Me.MetroTabPage3.Size = New System.Drawing.Size(412, 314)
        Me.MetroTabPage3.TabIndex = 2
        Me.MetroTabPage3.Text = "Entre dates"
        Me.MetroTabPage3.VerticalScrollbarBarColor = True
        Me.MetroTabPage3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.VerticalScrollbarSize = 10
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
        Me.GroupBox3.TabIndex = 32
        Me.GroupBox3.TabStop = False
        '
        'txtDelEntreDataOut
        '
        Me.txtDelEntreDataOut.Location = New System.Drawing.Point(103, 59)
        Me.txtDelEntreDataOut.MinimumSize = New System.Drawing.Size(4, 29)
        Me.txtDelEntreDataOut.Name = "txtDelEntreDataOut"
        Me.txtDelEntreDataOut.Size = New System.Drawing.Size(207, 29)
        Me.txtDelEntreDataOut.TabIndex = 1
        '
        'txtDelEntreDataIn
        '
        Me.txtDelEntreDataIn.Location = New System.Drawing.Point(103, 24)
        Me.txtDelEntreDataIn.MinimumSize = New System.Drawing.Size(4, 29)
        Me.txtDelEntreDataIn.Name = "txtDelEntreDataIn"
        Me.txtDelEntreDataIn.Size = New System.Drawing.Size(209, 29)
        Me.txtDelEntreDataIn.TabIndex = 0
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
        'cmdDelEntreDates
        '
        Me.cmdDelEntreDates.ActiveControl = Nothing
        Me.cmdDelEntreDates.Location = New System.Drawing.Point(124, 271)
        Me.cmdDelEntreDates.Name = "cmdDelEntreDates"
        Me.cmdDelEntreDates.Size = New System.Drawing.Size(169, 39)
        Me.cmdDelEntreDates.TabIndex = 0
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
        Me.label10.TabIndex = 30
        Me.label10.Text = "Eliminació de tots els registres del logger programats entre les dates"
        '
        'MetroTabPage4
        '
        Me.MetroTabPage4.Controls.Add(Me.ComboBoxProgrames)
        Me.MetroTabPage4.Controls.Add(Me.label13)
        Me.MetroTabPage4.Controls.Add(Me.GroupBox1)
        Me.MetroTabPage4.Controls.Add(Me.cmdDelPrograma)
        Me.MetroTabPage4.HorizontalScrollbarBarColor = True
        Me.MetroTabPage4.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage4.HorizontalScrollbarSize = 10
        Me.MetroTabPage4.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage4.Name = "MetroTabPage4"
        Me.MetroTabPage4.Size = New System.Drawing.Size(412, 314)
        Me.MetroTabPage4.TabIndex = 3
        Me.MetroTabPage4.Text = "Programa"
        Me.MetroTabPage4.VerticalScrollbarBarColor = True
        Me.MetroTabPage4.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage4.VerticalScrollbarSize = 10
        '
        'ComboBoxProgrames
        '
        Me.ComboBoxProgrames.FormattingEnabled = True
        Me.ComboBoxProgrames.ItemHeight = 23
        Me.ComboBoxProgrames.Location = New System.Drawing.Point(46, 81)
        Me.ComboBoxProgrames.Name = "ComboBoxProgrames"
        Me.ComboBoxProgrames.Size = New System.Drawing.Size(325, 29)
        Me.ComboBoxProgrames.TabIndex = 0
        Me.ComboBoxProgrames.UseSelectable = True
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
        Me.label13.TabIndex = 33
        Me.label13.Text = "Eliminació de tots els registres del logger programats entre les dates assignats " &
    "al programa"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtDelProgramaOut)
        Me.GroupBox1.Controls.Add(Me.txtDelProgramaIn)
        Me.GroupBox1.Controls.Add(Me.label11)
        Me.GroupBox1.Controls.Add(Me.label12)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(46, 106)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(324, 110)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        '
        'txtDelProgramaOut
        '
        Me.txtDelProgramaOut.Location = New System.Drawing.Point(103, 59)
        Me.txtDelProgramaOut.MinimumSize = New System.Drawing.Size(4, 29)
        Me.txtDelProgramaOut.Name = "txtDelProgramaOut"
        Me.txtDelProgramaOut.Size = New System.Drawing.Size(207, 29)
        Me.txtDelProgramaOut.TabIndex = 1
        '
        'txtDelProgramaIn
        '
        Me.txtDelProgramaIn.Location = New System.Drawing.Point(103, 24)
        Me.txtDelProgramaIn.MinimumSize = New System.Drawing.Size(4, 29)
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
        'frmDelLogger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(455, 471)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Controls.Add(Me.cmdSortir)
        Me.Controls.Add(Me.cmdExit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(455, 471)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(455, 471)
        Me.Name = "frmDelLogger"
        Me.Resizable = False
        Me.Text = "Eliminació Massiva "
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.MetroTabPage2.ResumeLayout(False)
        Me.MetroTabPage3.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.MetroTabPage4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdSortir As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage3 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage4 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents cmdDelTot As MetroFramework.Controls.MetroTile
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdDelCaduc As MetroFramework.Controls.MetroTile
    Friend WithEvents Label2 As Label
    Friend WithEvents cmdDelEntreDates As MetroFramework.Controls.MetroTile
    Friend WithEvents label10 As Label
    Friend WithEvents cmdDelPrograma As MetroFramework.Controls.MetroTile
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtDelEntreDataOut As MetroFramework.Controls.MetroDateTime
    Friend WithEvents txtDelEntreDataIn As MetroFramework.Controls.MetroDateTime
    Friend WithEvents label8 As Label
    Friend WithEvents label9 As Label
    Friend WithEvents ComboBoxProgrames As MetroFramework.Controls.MetroComboBox
    Friend WithEvents label13 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtDelProgramaOut As MetroFramework.Controls.MetroDateTime
    Friend WithEvents txtDelProgramaIn As MetroFramework.Controls.MetroDateTime
    Friend WithEvents label11 As Label
    Friend WithEvents label12 As Label
End Class
