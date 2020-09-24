'
' Creado por SharpDevelop.
' Usuario: nomai_000
' Fecha: 10/12/2015
' Hora: 0:25
' 
' Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
'
Partial Class frmExport
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmExport))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cmdSortir = New System.Windows.Forms.Button()
        Me.mnuGeneral = New System.Windows.Forms.MenuStrip()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.SortirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPlay = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStop = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_Help = New System.Windows.Forms.ToolStripMenuItem()
        Me.picVuMeter = New System.Windows.Forms.PictureBox()
        Me.cmdExitTool = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.cmdBuscar = New System.Windows.Forms.ToolStripSplitButton()
        Me.mnuFindNomesActius = New System.Windows.Forms.ToolStripMenuItem()
        Me.recercaAbancadaDeCançonsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.labelTipus = New System.Windows.Forms.ToolStripLabel()
        Me.labelComboBoxOpcions = New System.Windows.Forms.ToolStripLabel()
        Me.cmdCheck = New System.Windows.Forms.ToolStripButton()
        Me.lbVuMeter = New System.Windows.Forms.ToolStripLabel()
        Me.cmdStop = New System.Windows.Forms.ToolStripButton()
        Me.cmdPlay = New System.Windows.Forms.ToolStripButton()
        Me.lbAtencio = New System.Windows.Forms.ToolStripLabel()
        Me.groupBoxExport = New System.Windows.Forms.GroupBox()
        Me.MetroComboBox1 = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.ProgressBarTasc = New MetroFramework.Controls.MetroProgressBar()
        Me.cmdCancel = New MetroFramework.Controls.MetroTile()
        Me.cmdExport = New MetroFramework.Controls.MetroTile()
        Me.txtPathDesti = New MetroFramework.Controls.MetroTextBox()
        Me.dataGridViewFitxers = New MetroFramework.Controls.MetroGrid()
        Me.ColumnID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnSelect = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ColumnTitol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnSubTitol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnAny = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnEstil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdCalcHD = New MetroFramework.Controls.MetroButton()
        Me.lbInfoHD = New System.Windows.Forms.Label()
        Me.lbDesti = New System.Windows.Forms.Label()
        Me.folderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.tmrPlayer = New System.Windows.Forms.Timer(Me.components)
        Me.ComboBoxOpcions = New MetroFramework.Controls.MetroComboBox()
        Me.picPlay = New System.Windows.Forms.PictureBox()
        Me.picPause = New System.Windows.Forms.PictureBox()
        Me.TimerQuery = New System.Windows.Forms.Timer(Me.components)
        Me.pic_logo = New System.Windows.Forms.PictureBox()
        Me.mnuGeneral.SuspendLayout()
        CType(Me.picVuMeter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.groupBoxExport.SuspendLayout()
        CType(Me.dataGridViewFitxers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picPlay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPause, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdSortir
        '
        Me.cmdSortir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdSortir.Image = CType(resources.GetObject("cmdSortir.Image"), System.Drawing.Image)
        Me.cmdSortir.Location = New System.Drawing.Point(752, 71)
        Me.cmdSortir.Name = "cmdSortir"
        Me.cmdSortir.Size = New System.Drawing.Size(22, 22)
        Me.cmdSortir.TabIndex = 3
        Me.cmdSortir.UseVisualStyleBackColor = True
        '
        'mnuGeneral
        '
        Me.mnuGeneral.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mnuGeneral.BackColor = System.Drawing.Color.Transparent
        Me.mnuGeneral.Dock = System.Windows.Forms.DockStyle.None
        Me.mnuGeneral.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExit, Me.PlayToolStripMenuItem, Me.ToolStripMenuItem8})
        Me.mnuGeneral.Location = New System.Drawing.Point(756, 30)
        Me.mnuGeneral.Name = "mnuGeneral"
        Me.mnuGeneral.Size = New System.Drawing.Size(262, 24)
        Me.mnuGeneral.TabIndex = 4
        Me.mnuGeneral.Text = "MenuStrip1"
        '
        'mnuExit
        '
        Me.mnuExit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SortirToolStripMenuItem})
        Me.mnuExit.Image = CType(resources.GetObject("mnuExit.Image"), System.Drawing.Image)
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(87, 20)
        Me.mnuExit.Text = "Programa"
        '
        'SortirToolStripMenuItem
        '
        Me.SortirToolStripMenuItem.Image = CType(resources.GetObject("SortirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SortirToolStripMenuItem.Name = "SortirToolStripMenuItem"
        Me.SortirToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.SortirToolStripMenuItem.Text = "Sortir"
        '
        'PlayToolStripMenuItem
        '
        Me.PlayToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPlay, Me.mnuStop})
        Me.PlayToolStripMenuItem.Image = CType(resources.GetObject("PlayToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PlayToolStripMenuItem.Name = "PlayToolStripMenuItem"
        Me.PlayToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.PlayToolStripMenuItem.Text = "Reproductor"
        '
        'mnuPlay
        '
        Me.mnuPlay.Image = CType(resources.GetObject("mnuPlay.Image"), System.Drawing.Image)
        Me.mnuPlay.Name = "mnuPlay"
        Me.mnuPlay.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.mnuPlay.Size = New System.Drawing.Size(151, 22)
        Me.mnuPlay.Tag = "1"
        Me.mnuPlay.Text = "Play/Pausa"
        '
        'mnuStop
        '
        Me.mnuStop.Image = CType(resources.GetObject("mnuStop.Image"), System.Drawing.Image)
        Me.mnuStop.Name = "mnuStop"
        Me.mnuStop.ShortcutKeys = System.Windows.Forms.Keys.F7
        Me.mnuStop.Size = New System.Drawing.Size(151, 22)
        Me.mnuStop.Tag = "2"
        Me.mnuStop.Text = "Stop"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_Help})
        Me.ToolStripMenuItem8.Image = CType(resources.GetObject("ToolStripMenuItem8.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(66, 20)
        Me.ToolStripMenuItem8.Text = "Ajuda"
        '
        'mnu_Help
        '
        Me.mnu_Help.Image = CType(resources.GetObject("mnu_Help.Image"), System.Drawing.Image)
        Me.mnu_Help.Name = "mnu_Help"
        Me.mnu_Help.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.mnu_Help.Size = New System.Drawing.Size(174, 22)
        Me.mnu_Help.Text = "Manual OnLine"
        '
        'picVuMeter
        '
        Me.picVuMeter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picVuMeter.BackColor = System.Drawing.SystemColors.Control
        Me.picVuMeter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picVuMeter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picVuMeter.Location = New System.Drawing.Point(782, 66)
        Me.picVuMeter.Name = "picVuMeter"
        Me.picVuMeter.Size = New System.Drawing.Size(175, 26)
        Me.picVuMeter.TabIndex = 189
        Me.picVuMeter.TabStop = False
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
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdBuscar, Me.labelTipus, Me.labelComboBoxOpcions, Me.cmdCheck, Me.cmdExitTool, Me.lbVuMeter, Me.cmdStop, Me.cmdPlay, Me.lbAtencio})
        Me.ToolStrip1.Location = New System.Drawing.Point(20, 60)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(982, 39)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'cmdBuscar
        '
        Me.cmdBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdBuscar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFindNomesActius, Me.recercaAbancadaDeCançonsToolStripMenuItem})
        Me.cmdBuscar.Image = CType(resources.GetObject("cmdBuscar.Image"), System.Drawing.Image)
        Me.cmdBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(48, 36)
        Me.cmdBuscar.Text = "Buscar"
        '
        'mnuFindNomesActius
        '
        Me.mnuFindNomesActius.Name = "mnuFindNomesActius"
        Me.mnuFindNomesActius.Size = New System.Drawing.Size(231, 22)
        Me.mnuFindNomesActius.Text = "Només fitxes actius"
        '
        'recercaAbancadaDeCançonsToolStripMenuItem
        '
        Me.recercaAbancadaDeCançonsToolStripMenuItem.Name = "recercaAbancadaDeCançonsToolStripMenuItem"
        Me.recercaAbancadaDeCançonsToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.recercaAbancadaDeCançonsToolStripMenuItem.Text = "Recerca avançada de cançons"
        '
        'labelTipus
        '
        Me.labelTipus.AutoSize = False
        Me.labelTipus.Name = "labelTipus"
        Me.labelTipus.Size = New System.Drawing.Size(100, 36)
        Me.labelTipus.Text = "Tipus de fitxer:"
        '
        'labelComboBoxOpcions
        '
        Me.labelComboBoxOpcions.AutoSize = False
        Me.labelComboBoxOpcions.Name = "labelComboBoxOpcions"
        Me.labelComboBoxOpcions.Size = New System.Drawing.Size(150, 36)
        '
        'cmdCheck
        '
        Me.cmdCheck.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdCheck.Image = CType(resources.GetObject("cmdCheck.Image"), System.Drawing.Image)
        Me.cmdCheck.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdCheck.Name = "cmdCheck"
        Me.cmdCheck.Size = New System.Drawing.Size(36, 36)
        Me.cmdCheck.Text = "Seleccionar tot"
        Me.cmdCheck.ToolTipText = "Sel.lecconar tots els fitxers"
        '
        'lbVuMeter
        '
        Me.lbVuMeter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lbVuMeter.AutoSize = False
        Me.lbVuMeter.Name = "lbVuMeter"
        Me.lbVuMeter.Size = New System.Drawing.Size(191, 25)
        '
        'cmdStop
        '
        Me.cmdStop.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.cmdStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdStop.Image = CType(resources.GetObject("cmdStop.Image"), System.Drawing.Image)
        Me.cmdStop.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdStop.Name = "cmdStop"
        Me.cmdStop.Size = New System.Drawing.Size(36, 36)
        Me.cmdStop.Text = "Stop"
        Me.cmdStop.ToolTipText = "Parar la reproducció"
        '
        'cmdPlay
        '
        Me.cmdPlay.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.cmdPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdPlay.Image = CType(resources.GetObject("cmdPlay.Image"), System.Drawing.Image)
        Me.cmdPlay.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPlay.Name = "cmdPlay"
        Me.cmdPlay.Size = New System.Drawing.Size(36, 36)
        Me.cmdPlay.Text = "Play"
        Me.cmdPlay.ToolTipText = "Reproduïr fitxer"
        '
        'lbAtencio
        '
        Me.lbAtencio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAtencio.Image = CType(resources.GetObject("lbAtencio.Image"), System.Drawing.Image)
        Me.lbAtencio.Name = "lbAtencio"
        Me.lbAtencio.Size = New System.Drawing.Size(54, 36)
        Me.lbAtencio.Text = "No Exist."
        Me.lbAtencio.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        Me.lbAtencio.ToolTipText = "No existeix el fitxer"
        Me.lbAtencio.Visible = False
        '
        'groupBoxExport
        '
        Me.groupBoxExport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBoxExport.Controls.Add(Me.MetroComboBox1)
        Me.groupBoxExport.Controls.Add(Me.MetroLabel1)
        Me.groupBoxExport.Controls.Add(Me.ProgressBarTasc)
        Me.groupBoxExport.Controls.Add(Me.cmdCancel)
        Me.groupBoxExport.Controls.Add(Me.cmdExport)
        Me.groupBoxExport.Controls.Add(Me.txtPathDesti)
        Me.groupBoxExport.Controls.Add(Me.dataGridViewFitxers)
        Me.groupBoxExport.Controls.Add(Me.GroupBox1)
        Me.groupBoxExport.Controls.Add(Me.lbDesti)
        Me.groupBoxExport.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBoxExport.Location = New System.Drawing.Point(20, 102)
        Me.groupBoxExport.Name = "groupBoxExport"
        Me.groupBoxExport.Size = New System.Drawing.Size(982, 458)
        Me.groupBoxExport.TabIndex = 191
        Me.groupBoxExport.TabStop = False
        '
        'MetroComboBox1
        '
        Me.MetroComboBox1.FormattingEnabled = True
        Me.MetroComboBox1.ItemHeight = 23
        Me.MetroComboBox1.Items.AddRange(New Object() {"%title% - %subtitle% - %album%", "%title% - %subtitle%"})
        Me.MetroComboBox1.Location = New System.Drawing.Point(176, 341)
        Me.MetroComboBox1.Name = "MetroComboBox1"
        Me.MetroComboBox1.Size = New System.Drawing.Size(382, 29)
        Me.MetroComboBox1.TabIndex = 204
        Me.MetroComboBox1.UseSelectable = True
        Me.MetroComboBox1.Visible = False
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Location = New System.Drawing.Point(73, 344)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(97, 23)
        Me.MetroLabel1.TabIndex = 203
        Me.MetroLabel1.Text = "Patern"
        Me.MetroLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.MetroLabel1.Visible = False
        '
        'ProgressBarTasc
        '
        Me.ProgressBarTasc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBarTasc.HideProgressText = False
        Me.ProgressBarTasc.Location = New System.Drawing.Point(176, 426)
        Me.ProgressBarTasc.Name = "ProgressBarTasc"
        Me.ProgressBarTasc.Size = New System.Drawing.Size(646, 17)
        Me.ProgressBarTasc.TabIndex = 202
        Me.ProgressBarTasc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ProgressBarTasc.Visible = False
        '
        'cmdCancel
        '
        Me.cmdCancel.ActiveControl = Nothing
        Me.cmdCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdCancel.Enabled = False
        Me.cmdCancel.Location = New System.Drawing.Point(287, 375)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(101, 44)
        Me.cmdCancel.TabIndex = 3
        Me.cmdCancel.TileImage = CType(resources.GetObject("cmdCancel.TileImage"), System.Drawing.Image)
        Me.cmdCancel.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdCancel.UseSelectable = True
        Me.cmdCancel.UseTileImage = True
        '
        'cmdExport
        '
        Me.cmdExport.ActiveControl = Nothing
        Me.cmdExport.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdExport.Enabled = False
        Me.cmdExport.Location = New System.Drawing.Point(439, 375)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(272, 44)
        Me.cmdExport.TabIndex = 2
        Me.cmdExport.TileImage = CType(resources.GetObject("cmdExport.TileImage"), System.Drawing.Image)
        Me.cmdExport.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdExport.UseSelectable = True
        Me.cmdExport.UseTileImage = True
        '
        'txtPathDesti
        '
        Me.txtPathDesti.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtPathDesti.CustomButton.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.txtPathDesti.CustomButton.Location = New System.Drawing.Point(622, 1)
        Me.txtPathDesti.CustomButton.Name = ""
        Me.txtPathDesti.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.txtPathDesti.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPathDesti.CustomButton.TabIndex = 1
        Me.txtPathDesti.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPathDesti.CustomButton.UseSelectable = True
        Me.txtPathDesti.Lines = New String(-1) {}
        Me.txtPathDesti.Location = New System.Drawing.Point(176, 257)
        Me.txtPathDesti.MaxLength = 32767
        Me.txtPathDesti.Name = "txtPathDesti"
        Me.txtPathDesti.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPathDesti.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPathDesti.SelectedText = ""
        Me.txtPathDesti.SelectionLength = 0
        Me.txtPathDesti.SelectionStart = 0
        Me.txtPathDesti.ShortcutsEnabled = True
        Me.txtPathDesti.ShowButton = True
        Me.txtPathDesti.Size = New System.Drawing.Size(646, 25)
        Me.txtPathDesti.TabIndex = 1
        Me.txtPathDesti.UseSelectable = True
        Me.txtPathDesti.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPathDesti.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'dataGridViewFitxers
        '
        Me.dataGridViewFitxers.AllowUserToAddRows = False
        Me.dataGridViewFitxers.AllowUserToDeleteRows = False
        Me.dataGridViewFitxers.AllowUserToResizeRows = False
        Me.dataGridViewFitxers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataGridViewFitxers.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataGridViewFitxers.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataGridViewFitxers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dataGridViewFitxers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridViewFitxers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dataGridViewFitxers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridViewFitxers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnID, Me.ColumnSelect, Me.ColumnTitol, Me.ColumnSubTitol, Me.ColumnAny, Me.ColumnEstil})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGridViewFitxers.DefaultCellStyle = DataGridViewCellStyle2
        Me.dataGridViewFitxers.EnableHeadersVisualStyles = False
        Me.dataGridViewFitxers.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dataGridViewFitxers.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataGridViewFitxers.Location = New System.Drawing.Point(8, 20)
        Me.dataGridViewFitxers.Name = "dataGridViewFitxers"
        Me.dataGridViewFitxers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridViewFitxers.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dataGridViewFitxers.RowHeadersVisible = False
        Me.dataGridViewFitxers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dataGridViewFitxers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGridViewFitxers.Size = New System.Drawing.Size(968, 231)
        Me.dataGridViewFitxers.TabIndex = 0
        '
        'ColumnID
        '
        Me.ColumnID.DataPropertyName = "col_id"
        Me.ColumnID.HeaderText = "ID"
        Me.ColumnID.Name = "ColumnID"
        Me.ColumnID.Visible = False
        '
        'ColumnSelect
        '
        Me.ColumnSelect.HeaderText = ""
        Me.ColumnSelect.Name = "ColumnSelect"
        Me.ColumnSelect.Width = 50
        '
        'ColumnTitol
        '
        Me.ColumnTitol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnTitol.DataPropertyName = "col_titol"
        Me.ColumnTitol.HeaderText = "Titol"
        Me.ColumnTitol.Name = "ColumnTitol"
        Me.ColumnTitol.ReadOnly = True
        '
        'ColumnSubTitol
        '
        Me.ColumnSubTitol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnSubTitol.DataPropertyName = "col_subtitol"
        Me.ColumnSubTitol.HeaderText = "Subtítol"
        Me.ColumnSubTitol.Name = "ColumnSubTitol"
        Me.ColumnSubTitol.ReadOnly = True
        '
        'ColumnAny
        '
        Me.ColumnAny.HeaderText = "Any"
        Me.ColumnAny.Name = "ColumnAny"
        Me.ColumnAny.ReadOnly = True
        Me.ColumnAny.Visible = False
        '
        'ColumnEstil
        '
        Me.ColumnEstil.HeaderText = "Estil"
        Me.ColumnEstil.Name = "ColumnEstil"
        Me.ColumnEstil.ReadOnly = True
        Me.ColumnEstil.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cmdCalcHD)
        Me.GroupBox1.Controls.Add(Me.lbInfoHD)
        Me.GroupBox1.Location = New System.Drawing.Point(176, 288)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(646, 44)
        Me.GroupBox1.TabIndex = 197
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Espai requerit al disc dur"
        '
        'cmdCalcHD
        '
        Me.cmdCalcHD.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCalcHD.Location = New System.Drawing.Point(578, 15)
        Me.cmdCalcHD.Name = "cmdCalcHD"
        Me.cmdCalcHD.Size = New System.Drawing.Size(62, 23)
        Me.cmdCalcHD.TabIndex = 0
        Me.cmdCalcHD.Text = "Calcular"
        Me.cmdCalcHD.UseSelectable = True
        '
        'lbInfoHD
        '
        Me.lbInfoHD.AutoSize = True
        Me.lbInfoHD.Location = New System.Drawing.Point(13, 22)
        Me.lbInfoHD.Name = "lbInfoHD"
        Me.lbInfoHD.Size = New System.Drawing.Size(68, 17)
        Me.lbInfoHD.TabIndex = 0
        Me.lbInfoHD.Text = "Pendent ..."
        '
        'lbDesti
        '
        Me.lbDesti.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbDesti.Location = New System.Drawing.Point(70, 257)
        Me.lbDesti.Name = "lbDesti"
        Me.lbDesti.Size = New System.Drawing.Size(100, 25)
        Me.lbDesti.TabIndex = 192
        Me.lbDesti.Text = "Destí"
        Me.lbDesti.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tmrPlayer
        '
        Me.tmrPlayer.Interval = 25
        '
        'ComboBoxOpcions
        '
        Me.ComboBoxOpcions.FormattingEnabled = True
        Me.ComboBoxOpcions.ItemHeight = 23
        Me.ComboBoxOpcions.Location = New System.Drawing.Point(186, 64)
        Me.ComboBoxOpcions.Name = "ComboBoxOpcions"
        Me.ComboBoxOpcions.Size = New System.Drawing.Size(136, 29)
        Me.ComboBoxOpcions.TabIndex = 1
        Me.ComboBoxOpcions.UseSelectable = True
        '
        'picPlay
        '
        Me.picPlay.ErrorImage = CType(resources.GetObject("picPlay.ErrorImage"), System.Drawing.Image)
        Me.picPlay.Image = CType(resources.GetObject("picPlay.Image"), System.Drawing.Image)
        Me.picPlay.Location = New System.Drawing.Point(774, 147)
        Me.picPlay.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.picPlay.Name = "picPlay"
        Me.picPlay.Size = New System.Drawing.Size(22, 26)
        Me.picPlay.TabIndex = 201
        Me.picPlay.TabStop = False
        Me.picPlay.Visible = False
        '
        'picPause
        '
        Me.picPause.ErrorImage = CType(resources.GetObject("picPause.ErrorImage"), System.Drawing.Image)
        Me.picPause.Image = CType(resources.GetObject("picPause.Image"), System.Drawing.Image)
        Me.picPause.Location = New System.Drawing.Point(774, 183)
        Me.picPause.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.picPause.Name = "picPause"
        Me.picPause.Size = New System.Drawing.Size(22, 24)
        Me.picPause.TabIndex = 200
        Me.picPause.TabStop = False
        Me.picPause.Visible = False
        '
        'TimerQuery
        '
        Me.TimerQuery.Interval = 500
        '
        'pic_logo
        '
        Me.pic_logo.Location = New System.Drawing.Point(25, 23)
        Me.pic_logo.Name = "pic_logo"
        Me.pic_logo.Size = New System.Drawing.Size(40, 40)
        Me.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_logo.TabIndex = 266
        Me.pic_logo.TabStop = False
        '
        'frmExport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdSortir
        Me.ClientSize = New System.Drawing.Size(1022, 575)
        Me.Controls.Add(Me.pic_logo)
        Me.Controls.Add(Me.ComboBoxOpcions)
        Me.Controls.Add(Me.groupBoxExport)
        Me.Controls.Add(Me.picVuMeter)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.mnuGeneral)
        Me.Controls.Add(Me.cmdSortir)
        Me.Controls.Add(Me.picPlay)
        Me.Controls.Add(Me.picPause)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmExport"
        Me.Text = "Exportació de fitxers"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.mnuGeneral.ResumeLayout(False)
        Me.mnuGeneral.PerformLayout()
        CType(Me.picVuMeter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.groupBoxExport.ResumeLayout(False)
        CType(Me.dataGridViewFitxers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picPlay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPause, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend lbInfoHD As System.Windows.Forms.Label
    Friend GroupBox1 As System.Windows.Forms.GroupBox
    Private labelComboBoxOpcions As System.Windows.Forms.ToolStripLabel
    Private labelTipus As System.Windows.Forms.ToolStripLabel
    Friend lbAtencio As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tmrPlayer As System.Windows.Forms.Timer
    Private WithEvents recercaAbancadaDeCançonsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents mnuFindNomesActius As System.Windows.Forms.ToolStripMenuItem
    Friend cmdBuscar As System.Windows.Forms.ToolStripSplitButton
    Private folderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Private lbDesti As System.Windows.Forms.Label
    Private groupBoxExport As System.Windows.Forms.GroupBox
    '	Friend opt_4 As System.Windows.Forms.RadioButton
    '	Friend opt_3 As System.Windows.Forms.RadioButton
    '	Friend opt_2 As System.Windows.Forms.RadioButton
    '	Friend opt_1 As System.Windows.Forms.RadioButton
    '	Friend opt_0 As System.Windows.Forms.RadioButton
    Friend WithEvents cmdStop As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdPlay As System.Windows.Forms.ToolStripButton
    Private lbVuMeter As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmdCheck As System.Windows.Forms.ToolStripButton
    Friend ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdExitTool As System.Windows.Forms.ToolStripButton
    Friend WithEvents picVuMeter As System.Windows.Forms.PictureBox
    Public WithEvents mnu_Help As System.Windows.Forms.ToolStripMenuItem
    Friend ToolStripMenuItem8 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuStop As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPlay As System.Windows.Forms.ToolStripMenuItem
    Friend PlayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SortirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend mnuGeneral As System.Windows.Forms.MenuStrip
    Friend WithEvents cmdSortir As System.Windows.Forms.Button
    Friend WithEvents ComboBoxOpcions As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cmdExport As MetroFramework.Controls.MetroTile
    Friend WithEvents txtPathDesti As MetroFramework.Controls.MetroTextBox
    Friend WithEvents dataGridViewFitxers As MetroFramework.Controls.MetroGrid
    Friend WithEvents cmdCalcHD As MetroFramework.Controls.MetroButton
    Friend WithEvents cmdCancel As MetroFramework.Controls.MetroTile
    Friend WithEvents ProgressBarTasc As MetroFramework.Controls.MetroProgressBar
    Friend WithEvents picPlay As PictureBox
    Friend WithEvents picPause As PictureBox
    Friend WithEvents TimerQuery As Timer
    Friend WithEvents MetroComboBox1 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ColumnID As DataGridViewTextBoxColumn
    Friend WithEvents ColumnSelect As DataGridViewCheckBoxColumn
    Friend WithEvents ColumnTitol As DataGridViewTextBoxColumn
    Friend WithEvents ColumnSubTitol As DataGridViewTextBoxColumn
    Friend WithEvents ColumnAny As DataGridViewTextBoxColumn
    Friend WithEvents ColumnEstil As DataGridViewTextBoxColumn
    Friend WithEvents pic_logo As PictureBox
End Class
