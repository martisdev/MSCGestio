<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBKPDBS
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBKPDBS))
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.chk_excludeTables = New MetroFramework.Controls.MetroCheckBox()
        Me.chkZip = New MetroFramework.Controls.MetroCheckBox()
        Me.chkEncrip = New MetroFramework.Controls.MetroCheckBox()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkDelConnex = New MetroFramework.Controls.MetroCheckBox()
        Me.chkDelCtlRadia = New MetroFramework.Controls.MetroCheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.linkWebHelp = New System.Windows.Forms.LinkLabel()
        Me.label3 = New System.Windows.Forms.Label()
        Me.lbAtencio = New System.Windows.Forms.Label()
        Me.tmrAtencio = New System.Windows.Forms.Timer(Me.components)
        Me.lbInfoProgress = New System.Windows.Forms.Label()
        Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.folderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.TabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.cmdBKP = New MetroFramework.Controls.MetroTile()
        Me.txtDesti = New MetroFramework.Controls.MetroTextBox()
        Me.TabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.cmdRestore = New MetroFramework.Controls.MetroTile()
        Me.txtOrigen = New MetroFramework.Controls.MetroTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.progressBKP = New MetroFramework.Controls.MetroProgressBar()
        Me.cmdSortir = New MetroFramework.Controls.MetroLink()
        Me.lbBkpInfoProcess = New MetroFramework.Controls.MetroLabel()
        Me.groupBox2.SuspendLayout()
        Me.groupBox3.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.MetroTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox2
        '
        Me.groupBox2.BackColor = System.Drawing.Color.Transparent
        Me.groupBox2.Controls.Add(Me.chk_excludeTables)
        Me.groupBox2.Controls.Add(Me.chkZip)
        Me.groupBox2.Controls.Add(Me.chkEncrip)
        Me.groupBox2.Controls.Add(Me.groupBox3)
        Me.groupBox2.Location = New System.Drawing.Point(15, 66)
        Me.groupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.groupBox2.Size = New System.Drawing.Size(518, 247)
        Me.groupBox2.TabIndex = 2
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Opcions"
        '
        'chk_excludeTables
        '
        Me.chk_excludeTables.AutoSize = True
        Me.chk_excludeTables.Location = New System.Drawing.Point(65, 155)
        Me.chk_excludeTables.Name = "chk_excludeTables"
        Me.chk_excludeTables.Size = New System.Drawing.Size(384, 15)
        Me.chk_excludeTables.TabIndex = 1
        Me.chk_excludeTables.Text = "Exclude tables log (connections, radiation control, user connections)"
        Me.chk_excludeTables.UseSelectable = True
        '
        'chkZip
        '
        Me.chkZip.AutoSize = True
        Me.chkZip.Location = New System.Drawing.Point(65, 205)
        Me.chkZip.Name = "chkZip"
        Me.chkZip.Size = New System.Drawing.Size(117, 15)
        Me.chkZip.TabIndex = 3
        Me.chkZip.Text = "Comprimir en ZIP"
        Me.chkZip.UseSelectable = True
        Me.chkZip.Visible = False
        '
        'chkEncrip
        '
        Me.chkEncrip.AutoSize = True
        Me.chkEncrip.Location = New System.Drawing.Point(65, 180)
        Me.chkEncrip.Name = "chkEncrip"
        Me.chkEncrip.Size = New System.Drawing.Size(70, 15)
        Me.chkEncrip.TabIndex = 2
        Me.chkEncrip.Text = "Encriptar"
        Me.chkEncrip.UseSelectable = True
        Me.chkEncrip.Visible = False
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.chkDelConnex)
        Me.groupBox3.Controls.Add(Me.chkDelCtlRadia)
        Me.groupBox3.Location = New System.Drawing.Point(43, 26)
        Me.groupBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.groupBox3.Size = New System.Drawing.Size(418, 109)
        Me.groupBox3.TabIndex = 0
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Tasques prèvies"
        '
        'chkDelConnex
        '
        Me.chkDelConnex.AutoSize = True
        Me.chkDelConnex.Location = New System.Drawing.Point(22, 76)
        Me.chkDelConnex.Name = "chkDelConnex"
        Me.chkDelConnex.Size = New System.Drawing.Size(186, 15)
        Me.chkDelConnex.TabIndex = 1
        Me.chkDelConnex.Text = "Borrar l'historial de connexions"
        Me.chkDelConnex.UseSelectable = True
        '
        'chkDelCtlRadia
        '
        Me.chkDelCtlRadia.AutoSize = True
        Me.chkDelCtlRadia.Location = New System.Drawing.Point(22, 42)
        Me.chkDelCtlRadia.Name = "chkDelCtlRadia"
        Me.chkDelCtlRadia.Size = New System.Drawing.Size(318, 15)
        Me.chkDelCtlRadia.TabIndex = 0
        Me.chkDelCtlRadia.Text = "Borrar l'historial de radiació més antic de dues setmanes"
        Me.chkDelCtlRadia.UseSelectable = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Directori destí:"
        '
        'groupBox1
        '
        Me.groupBox1.BackColor = System.Drawing.Color.Transparent
        Me.groupBox1.Controls.Add(Me.linkWebHelp)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.ForeColor = System.Drawing.Color.Red
        Me.groupBox1.Location = New System.Drawing.Point(0, 101)
        Me.groupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.groupBox1.Size = New System.Drawing.Size(521, 141)
        Me.groupBox1.TabIndex = 2
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Atenció"
        Me.groupBox1.Visible = False
        '
        'linkWebHelp
        '
        Me.linkWebHelp.Location = New System.Drawing.Point(62, 89)
        Me.linkWebHelp.Name = "linkWebHelp"
        Me.linkWebHelp.Size = New System.Drawing.Size(429, 30)
        Me.linkWebHelp.TabIndex = 1
        Me.linkWebHelp.TabStop = True
        Me.linkWebHelp.Text = "http://comunitat.msc-soft.com"
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(44, 39)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(416, 41)
        Me.label3.TabIndex = 0
        Me.label3.Text = "Si aquesta pantalla us dona un error, consulteu el manual per configurar el vostr" &
    "e servidor."
        '
        'lbAtencio
        '
        Me.lbAtencio.AutoSize = True
        Me.lbAtencio.ForeColor = System.Drawing.Color.Blue
        Me.lbAtencio.Location = New System.Drawing.Point(40, 66)
        Me.lbAtencio.Name = "lbAtencio"
        Me.lbAtencio.Size = New System.Drawing.Size(525, 17)
        Me.lbAtencio.TabIndex = 0
        Me.lbAtencio.Text = "Fer qualsevol operació en aquesta pantalla pot suposar un perill per tot el siste" &
    "ma MSC."
        '
        'tmrAtencio
        '
        Me.tmrAtencio.Enabled = True
        Me.tmrAtencio.Interval = 1000
        '
        'lbInfoProgress
        '
        Me.lbInfoProgress.AutoSize = True
        Me.lbInfoProgress.Location = New System.Drawing.Point(42, 691)
        Me.lbInfoProgress.Name = "lbInfoProgress"
        Me.lbInfoProgress.Size = New System.Drawing.Size(0, 17)
        Me.lbInfoProgress.TabIndex = 4
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.TabPage1)
        Me.MetroTabControl1.Controls.Add(Me.TabPage2)
        Me.MetroTabControl1.Location = New System.Drawing.Point(39, 85)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(544, 447)
        Me.MetroTabControl1.TabIndex = 0
        Me.MetroTabControl1.UseSelectable = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.cmdBKP)
        Me.TabPage1.Controls.Add(Me.txtDesti)
        Me.TabPage1.Controls.Add(Me.groupBox2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.HorizontalScrollbarBarColor = True
        Me.TabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.TabPage1.HorizontalScrollbarSize = 2
        Me.TabPage1.Location = New System.Drawing.Point(4, 38)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(536, 405)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Salvar Dades"
        Me.TabPage1.VerticalScrollbarBarColor = True
        Me.TabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.TabPage1.VerticalScrollbarSize = 4
        '
        'cmdBKP
        '
        Me.cmdBKP.ActiveControl = Nothing
        Me.cmdBKP.Enabled = False
        Me.cmdBKP.Location = New System.Drawing.Point(124, 338)
        Me.cmdBKP.Name = "cmdBKP"
        Me.cmdBKP.Size = New System.Drawing.Size(288, 64)
        Me.cmdBKP.TabIndex = 3
        Me.cmdBKP.TileImage = CType(resources.GetObject("cmdBKP.TileImage"), System.Drawing.Image)
        Me.cmdBKP.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdBKP.UseSelectable = True
        Me.cmdBKP.UseTileImage = True
        '
        'txtDesti
        '
        '
        '
        '
        Me.txtDesti.CustomButton.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.txtDesti.CustomButton.Location = New System.Drawing.Point(490, 1)
        Me.txtDesti.CustomButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDesti.CustomButton.Name = ""
        Me.txtDesti.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtDesti.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDesti.CustomButton.TabIndex = 1
        Me.txtDesti.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDesti.CustomButton.UseSelectable = True
        Me.txtDesti.Lines = New String(-1) {}
        Me.txtDesti.Location = New System.Drawing.Point(15, 32)
        Me.txtDesti.MaxLength = 32767
        Me.txtDesti.Name = "txtDesti"
        Me.txtDesti.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDesti.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDesti.SelectedText = ""
        Me.txtDesti.SelectionLength = 0
        Me.txtDesti.SelectionStart = 0
        Me.txtDesti.ShortcutsEnabled = True
        Me.txtDesti.ShowButton = True
        Me.txtDesti.Size = New System.Drawing.Size(518, 29)
        Me.txtDesti.TabIndex = 1
        Me.txtDesti.UseSelectable = True
        Me.txtDesti.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDesti.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.cmdRestore)
        Me.TabPage2.Controls.Add(Me.txtOrigen)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.groupBox1)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.HorizontalScrollbarBarColor = True
        Me.TabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.TabPage2.HorizontalScrollbarSize = 2
        Me.TabPage2.Location = New System.Drawing.Point(4, 38)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(536, 405)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Restaurar Dades"
        Me.TabPage2.VerticalScrollbarBarColor = True
        Me.TabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.TabPage2.VerticalScrollbarSize = 4
        '
        'cmdRestore
        '
        Me.cmdRestore.ActiveControl = Nothing
        Me.cmdRestore.Enabled = False
        Me.cmdRestore.Location = New System.Drawing.Point(124, 338)
        Me.cmdRestore.Name = "cmdRestore"
        Me.cmdRestore.Size = New System.Drawing.Size(288, 64)
        Me.cmdRestore.TabIndex = 3
        Me.cmdRestore.TileImage = CType(resources.GetObject("cmdRestore.TileImage"), System.Drawing.Image)
        Me.cmdRestore.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdRestore.UseSelectable = True
        Me.cmdRestore.UseTileImage = True
        '
        'txtOrigen
        '
        '
        '
        '
        Me.txtOrigen.CustomButton.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.txtOrigen.CustomButton.Location = New System.Drawing.Point(494, 1)
        Me.txtOrigen.CustomButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtOrigen.CustomButton.Name = ""
        Me.txtOrigen.CustomButton.Size = New System.Drawing.Size(29, 29)
        Me.txtOrigen.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtOrigen.CustomButton.TabIndex = 1
        Me.txtOrigen.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtOrigen.CustomButton.UseSelectable = True
        Me.txtOrigen.Lines = New String(-1) {}
        Me.txtOrigen.Location = New System.Drawing.Point(0, 35)
        Me.txtOrigen.MaxLength = 32767
        Me.txtOrigen.Name = "txtOrigen"
        Me.txtOrigen.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtOrigen.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtOrigen.SelectedText = ""
        Me.txtOrigen.SelectionLength = 0
        Me.txtOrigen.SelectionStart = 0
        Me.txtOrigen.ShortcutsEnabled = True
        Me.txtOrigen.ShowButton = True
        Me.txtOrigen.Size = New System.Drawing.Size(524, 31)
        Me.txtOrigen.TabIndex = 1
        Me.txtOrigen.UseSelectable = True
        Me.txtOrigen.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtOrigen.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(3, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Fitxer a restaurar :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(-154, -80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Directori destí:"
        '
        'progressBKP
        '
        Me.progressBKP.HideProgressText = False
        Me.progressBKP.Location = New System.Drawing.Point(39, 566)
        Me.progressBKP.Name = "progressBKP"
        Me.progressBKP.Size = New System.Drawing.Size(540, 26)
        Me.progressBKP.TabIndex = 6
        Me.progressBKP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdSortir
        '
        Me.cmdSortir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdSortir.Image = CType(resources.GetObject("cmdSortir.Image"), System.Drawing.Image)
        Me.cmdSortir.ImageSize = 32
        Me.cmdSortir.Location = New System.Drawing.Point(543, 21)
        Me.cmdSortir.Name = "cmdSortir"
        Me.cmdSortir.Size = New System.Drawing.Size(40, 42)
        Me.cmdSortir.TabIndex = 4
        Me.cmdSortir.UseSelectable = True
        '
        'lbBkpInfoProcess
        '
        Me.lbBkpInfoProcess.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbBkpInfoProcess.AutoSize = True
        Me.lbBkpInfoProcess.Location = New System.Drawing.Point(39, 599)
        Me.lbBkpInfoProcess.Name = "lbBkpInfoProcess"
        Me.lbBkpInfoProcess.Size = New System.Drawing.Size(0, 0)
        Me.lbBkpInfoProcess.TabIndex = 7
        '
        'frmBKPDBS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdSortir
        Me.ClientSize = New System.Drawing.Size(593, 624)
        Me.Controls.Add(Me.lbBkpInfoProcess)
        Me.Controls.Add(Me.cmdSortir)
        Me.Controls.Add(Me.progressBKP)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Controls.Add(Me.lbInfoProgress)
        Me.Controls.Add(Me.lbAtencio)
        Me.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBKPDBS"
        Me.Padding = New System.Windows.Forms.Padding(23, 78, 23, 26)
        Me.Resizable = False
        Me.Text = "Còpies de seguretat de la base de dades"
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.MetroTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private groupBox3 As System.Windows.Forms.GroupBox
    Private groupBox2 As System.Windows.Forms.GroupBox
    Private label3 As System.Windows.Forms.Label
    Private WithEvents linkWebHelp As System.Windows.Forms.LinkLabel
    Private groupBox1 As System.Windows.Forms.GroupBox
    Private folderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Private openFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbAtencio As System.Windows.Forms.Label
    Friend WithEvents tmrAtencio As System.Windows.Forms.Timer
    Friend WithEvents lbInfoProgress As System.Windows.Forms.Label
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents TabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents TabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents chkZip As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chkEncrip As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chkDelConnex As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chkDelCtlRadia As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents cmdBKP As MetroFramework.Controls.MetroTile
    Friend WithEvents txtDesti As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents progressBKP As MetroFramework.Controls.MetroProgressBar
    Friend WithEvents cmdSortir As MetroFramework.Controls.MetroLink
    Friend WithEvents cmdRestore As MetroFramework.Controls.MetroTile
    Friend WithEvents txtOrigen As MetroFramework.Controls.MetroTextBox
    Friend WithEvents chk_excludeTables As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents lbBkpInfoProcess As MetroFramework.Controls.MetroLabel
End Class
