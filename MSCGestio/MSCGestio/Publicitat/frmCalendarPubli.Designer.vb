'
' Creado por SharpDevelop.
' Usuario: Marti
' Fecha: 15/09/2017
' Hora: 12:39
' 
' Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
'
Partial Class frmCalendarPubli
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCalendarPubli))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProgarmaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_Help = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.cmdExitTool = New System.Windows.Forms.ToolStripButton()
        Me.cmdBorrar = New System.Windows.Forms.ToolStripButton()
        Me.cmdBloqueix = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.lbInfoSave = New System.Windows.Forms.ToolStripLabel()
        Me.PanelCalendar = New System.Windows.Forms.Panel()
        Me.picCalendar = New System.Windows.Forms.PictureBox()
        Me.picHores = New System.Windows.Forms.PictureBox()
        Me.PictureBoxCalendar = New System.Windows.Forms.PictureBox()
        Me.dtpDataRadi = New System.Windows.Forms.DateTimePicker()
        Me.buttonResizeCalendarMenys = New System.Windows.Forms.Button()
        Me.buttonResizeCalendarMes = New System.Windows.Forms.Button()
        Me.pnlDies = New System.Windows.Forms.Panel()
        Me.lbDll = New System.Windows.Forms.Label()
        Me.lbDts = New System.Windows.Forms.Label()
        Me.lbDres = New System.Windows.Forms.Label()
        Me.lbDj = New System.Windows.Forms.Label()
        Me.lbDv = New System.Windows.Forms.Label()
        Me.lbDs = New System.Windows.Forms.Label()
        Me.lbDg = New System.Windows.Forms.Label()
        Me.cmdActual = New System.Windows.Forms.Button()
        Me.cmdPost = New System.Windows.Forms.Button()
        Me.cmdAnt = New System.Windows.Forms.Button()
        Me.ImageListCalendar = New System.Windows.Forms.ImageList(Me.components)
        Me.cmbExit = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.picLock = New System.Windows.Forms.PictureBox()
        Me.picUnLock = New System.Windows.Forms.PictureBox()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.picProduc = New System.Windows.Forms.PictureBox()
        Me.cmdSalvar = New MetroFramework.Controls.MetroLink()
        Me.picLocutor = New System.Windows.Forms.PictureBox()
        Me.cmbListHoresDetall = New System.Windows.Forms.ComboBox()
        Me.dtpDetallData = New System.Windows.Forms.DateTimePicker()
        Me.lbNomDetall = New System.Windows.Forms.Label()
        Me.MetroLink1 = New MetroFramework.Controls.MetroLink()
        Me.PanelPubli = New MetroFramework.Controls.MetroPanel()
        Me.lnkLocutor = New MetroFramework.Controls.MetroLink()
        Me.MetroLink2 = New MetroFramework.Controls.MetroLink()
        Me.pic_logo = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.PanelCalendar.SuspendLayout()
        CType(Me.picCalendar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxCalendar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDies.SuspendLayout()
        CType(Me.picLock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUnLock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel2.SuspendLayout()
        CType(Me.picProduc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLocutor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPubli.SuspendLayout()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgarmaToolStripMenuItem, Me.AjudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(813, 30)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(162, 26)
        Me.MenuStrip1.TabIndex = 16
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProgarmaToolStripMenuItem
        '
        Me.ProgarmaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExit})
        Me.ProgarmaToolStripMenuItem.Image = CType(resources.GetObject("ProgarmaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ProgarmaToolStripMenuItem.Name = "ProgarmaToolStripMenuItem"
        Me.ProgarmaToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.ProgarmaToolStripMenuItem.Text = "Programa"
        '
        'mnuExit
        '
        Me.mnuExit.Image = CType(resources.GetObject("mnuExit.Image"), System.Drawing.Image)
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(102, 22)
        Me.mnuExit.Text = "Sortir"
        '
        'AjudaToolStripMenuItem
        '
        Me.AjudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_Help})
        Me.AjudaToolStripMenuItem.Image = CType(resources.GetObject("AjudaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AjudaToolStripMenuItem.Name = "AjudaToolStripMenuItem"
        Me.AjudaToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.AjudaToolStripMenuItem.Text = "Ajuda"
        '
        'mnu_Help
        '
        Me.mnu_Help.Image = CType(resources.GetObject("mnu_Help.Image"), System.Drawing.Image)
        Me.mnu_Help.Name = "mnu_Help"
        Me.mnu_Help.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.mnu_Help.Size = New System.Drawing.Size(174, 22)
        Me.mnu_Help.Text = "Manual OnLine"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdExitTool, Me.cmdBorrar, Me.cmdBloqueix, Me.ToolStripLabel1, Me.lbInfoSave})
        Me.ToolStrip1.Location = New System.Drawing.Point(23, 78)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(976, 39)
        Me.ToolStrip1.TabIndex = 17
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
        'cmdBorrar
        '
        Me.cmdBorrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.cmdBorrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdBorrar.Enabled = False
        Me.cmdBorrar.Image = CType(resources.GetObject("cmdBorrar.Image"), System.Drawing.Image)
        Me.cmdBorrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(36, 36)
        Me.cmdBorrar.Text = "Borrar"
        '
        'cmdBloqueix
        '
        Me.cmdBloqueix.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.cmdBloqueix.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdBloqueix.Image = CType(resources.GetObject("cmdBloqueix.Image"), System.Drawing.Image)
        Me.cmdBloqueix.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdBloqueix.Name = "cmdBloqueix"
        Me.cmdBloqueix.Size = New System.Drawing.Size(36, 36)
        Me.cmdBloqueix.Text = "Editar ítem"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel1.AutoSize = False
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(75, 36)
        '
        'lbInfoSave
        '
        Me.lbInfoSave.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lbInfoSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.lbInfoSave.Image = CType(resources.GetObject("lbInfoSave.Image"), System.Drawing.Image)
        Me.lbInfoSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.lbInfoSave.Name = "lbInfoSave"
        Me.lbInfoSave.Size = New System.Drawing.Size(32, 36)
        Me.lbInfoSave.Visible = False
        '
        'PanelCalendar
        '
        Me.PanelCalendar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelCalendar.AutoScroll = True
        Me.PanelCalendar.BackColor = System.Drawing.SystemColors.Window
        Me.PanelCalendar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelCalendar.Controls.Add(Me.picCalendar)
        Me.PanelCalendar.Controls.Add(Me.picHores)
        Me.PanelCalendar.Location = New System.Drawing.Point(10, 196)
        Me.PanelCalendar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelCalendar.Name = "PanelCalendar"
        Me.PanelCalendar.Size = New System.Drawing.Size(989, 367)
        Me.PanelCalendar.TabIndex = 194
        '
        'picCalendar
        '
        Me.picCalendar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picCalendar.BackColor = System.Drawing.SystemColors.Window
        Me.picCalendar.Location = New System.Drawing.Point(51, 6)
        Me.picCalendar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picCalendar.Name = "picCalendar"
        Me.picCalendar.Size = New System.Drawing.Size(916, 1306)
        Me.picCalendar.TabIndex = 3
        Me.picCalendar.TabStop = False
        '
        'picHores
        '
        Me.picHores.BackColor = System.Drawing.SystemColors.Window
        Me.picHores.Location = New System.Drawing.Point(3, 4)
        Me.picHores.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picHores.Name = "picHores"
        Me.picHores.Size = New System.Drawing.Size(42, 1308)
        Me.picHores.TabIndex = 6
        Me.picHores.TabStop = False
        '
        'PictureBoxCalendar
        '
        Me.PictureBoxCalendar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxCalendar.Image = CType(resources.GetObject("PictureBoxCalendar.Image"), System.Drawing.Image)
        Me.PictureBoxCalendar.Location = New System.Drawing.Point(10, 154)
        Me.PictureBoxCalendar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBoxCalendar.Name = "PictureBoxCalendar"
        Me.PictureBoxCalendar.Size = New System.Drawing.Size(37, 42)
        Me.PictureBoxCalendar.TabIndex = 21
        Me.PictureBoxCalendar.TabStop = False
        Me.PictureBoxCalendar.Tag = "2"
        '
        'dtpDataRadi
        '
        Me.dtpDataRadi.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dtpDataRadi.Location = New System.Drawing.Point(490, 121)
        Me.dtpDataRadi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpDataRadi.Name = "dtpDataRadi"
        Me.dtpDataRadi.Size = New System.Drawing.Size(257, 25)
        Me.dtpDataRadi.TabIndex = 4
        Me.dtpDataRadi.Value = New Date(2010, 1, 26, 0, 0, 0, 0)
        '
        'buttonResizeCalendarMenys
        '
        Me.buttonResizeCalendarMenys.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonResizeCalendarMenys.Location = New System.Drawing.Point(978, 121)
        Me.buttonResizeCalendarMenys.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.buttonResizeCalendarMenys.Name = "buttonResizeCalendarMenys"
        Me.buttonResizeCalendarMenys.Size = New System.Drawing.Size(21, 25)
        Me.buttonResizeCalendarMenys.TabIndex = 30
        Me.buttonResizeCalendarMenys.Text = "-"
        Me.buttonResizeCalendarMenys.UseVisualStyleBackColor = True
        '
        'buttonResizeCalendarMes
        '
        Me.buttonResizeCalendarMes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonResizeCalendarMes.Location = New System.Drawing.Point(954, 121)
        Me.buttonResizeCalendarMes.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.buttonResizeCalendarMes.Name = "buttonResizeCalendarMes"
        Me.buttonResizeCalendarMes.Size = New System.Drawing.Size(21, 25)
        Me.buttonResizeCalendarMes.TabIndex = 29
        Me.buttonResizeCalendarMes.Text = "+"
        Me.buttonResizeCalendarMes.UseVisualStyleBackColor = True
        '
        'pnlDies
        '
        Me.pnlDies.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlDies.BackColor = System.Drawing.SystemColors.Window
        Me.pnlDies.Controls.Add(Me.lbDll)
        Me.pnlDies.Controls.Add(Me.lbDts)
        Me.pnlDies.Controls.Add(Me.lbDres)
        Me.pnlDies.Controls.Add(Me.lbDj)
        Me.pnlDies.Controls.Add(Me.lbDv)
        Me.pnlDies.Controls.Add(Me.lbDs)
        Me.pnlDies.Controls.Add(Me.lbDg)
        Me.pnlDies.Location = New System.Drawing.Point(62, 154)
        Me.pnlDies.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlDies.Name = "pnlDies"
        Me.pnlDies.Size = New System.Drawing.Size(937, 39)
        Me.pnlDies.TabIndex = 20
        '
        'lbDll
        '
        Me.lbDll.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbDll.BackColor = System.Drawing.SystemColors.Window
        Me.lbDll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDll.Location = New System.Drawing.Point(0, 21)
        Me.lbDll.Name = "lbDll"
        Me.lbDll.Size = New System.Drawing.Size(530, 17)
        Me.lbDll.TabIndex = 12
        Me.lbDll.Text = "Label2"
        Me.lbDll.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbDts
        '
        Me.lbDts.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbDts.BackColor = System.Drawing.SystemColors.Window
        Me.lbDts.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDts.Location = New System.Drawing.Point(59, 21)
        Me.lbDts.Name = "lbDts"
        Me.lbDts.Size = New System.Drawing.Size(530, 17)
        Me.lbDts.TabIndex = 13
        Me.lbDts.Text = "Label5"
        Me.lbDts.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbDres
        '
        Me.lbDres.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbDres.BackColor = System.Drawing.SystemColors.Window
        Me.lbDres.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDres.Location = New System.Drawing.Point(119, 21)
        Me.lbDres.Name = "lbDres"
        Me.lbDres.Size = New System.Drawing.Size(530, 17)
        Me.lbDres.TabIndex = 14
        Me.lbDres.Text = "Label8"
        Me.lbDres.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbDj
        '
        Me.lbDj.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbDj.BackColor = System.Drawing.SystemColors.Window
        Me.lbDj.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDj.Location = New System.Drawing.Point(178, 21)
        Me.lbDj.Name = "lbDj"
        Me.lbDj.Size = New System.Drawing.Size(530, 17)
        Me.lbDj.TabIndex = 15
        Me.lbDj.Text = "Label9"
        Me.lbDj.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbDv
        '
        Me.lbDv.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbDv.BackColor = System.Drawing.SystemColors.Window
        Me.lbDv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDv.Location = New System.Drawing.Point(238, 21)
        Me.lbDv.Name = "lbDv"
        Me.lbDv.Size = New System.Drawing.Size(538, 17)
        Me.lbDv.TabIndex = 16
        Me.lbDv.Text = "Label10"
        Me.lbDv.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbDs
        '
        Me.lbDs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbDs.BackColor = System.Drawing.SystemColors.Window
        Me.lbDs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDs.Location = New System.Drawing.Point(304, 21)
        Me.lbDs.Name = "lbDs"
        Me.lbDs.Size = New System.Drawing.Size(538, 17)
        Me.lbDs.TabIndex = 17
        Me.lbDs.Text = "Label11"
        Me.lbDs.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbDg
        '
        Me.lbDg.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbDg.BackColor = System.Drawing.SystemColors.Window
        Me.lbDg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDg.Location = New System.Drawing.Point(371, 21)
        Me.lbDg.Name = "lbDg"
        Me.lbDg.Size = New System.Drawing.Size(538, 17)
        Me.lbDg.TabIndex = 18
        Me.lbDg.Text = "Label12"
        Me.lbDg.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmdActual
        '
        Me.cmdActual.Location = New System.Drawing.Point(101, 121)
        Me.cmdActual.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdActual.Name = "cmdActual"
        Me.cmdActual.Size = New System.Drawing.Size(61, 25)
        Me.cmdActual.TabIndex = 10
        Me.cmdActual.Text = "Avui"
        Me.cmdActual.UseVisualStyleBackColor = True
        '
        'cmdPost
        '
        Me.cmdPost.Location = New System.Drawing.Point(164, 121)
        Me.cmdPost.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdPost.Name = "cmdPost"
        Me.cmdPost.Size = New System.Drawing.Size(37, 25)
        Me.cmdPost.TabIndex = 9
        Me.cmdPost.Text = ">"
        Me.cmdPost.UseVisualStyleBackColor = True
        '
        'cmdAnt
        '
        Me.cmdAnt.Location = New System.Drawing.Point(62, 121)
        Me.cmdAnt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdAnt.Name = "cmdAnt"
        Me.cmdAnt.Size = New System.Drawing.Size(37, 25)
        Me.cmdAnt.TabIndex = 8
        Me.cmdAnt.Text = "<"
        Me.cmdAnt.UseVisualStyleBackColor = True
        '
        'ImageListCalendar
        '
        Me.ImageListCalendar.ImageStream = CType(resources.GetObject("ImageListCalendar.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListCalendar.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListCalendar.Images.SetKeyName(0, "Sin título-1.gif")
        Me.ImageListCalendar.Images.SetKeyName(1, "calendar2.gif")
        Me.ImageListCalendar.Images.SetKeyName(2, "calendar_date.png")
        '
        'cmbExit
        '
        Me.cmbExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmbExit.Location = New System.Drawing.Point(100, 90)
        Me.cmbExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbExit.Name = "cmbExit"
        Me.cmbExit.Size = New System.Drawing.Size(24, 19)
        Me.cmbExit.TabIndex = 195
        Me.cmbExit.Text = "Button1"
        Me.cmbExit.UseVisualStyleBackColor = True
        '
        'picLock
        '
        Me.picLock.Image = CType(resources.GetObject("picLock.Image"), System.Drawing.Image)
        Me.picLock.Location = New System.Drawing.Point(195, 43)
        Me.picLock.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picLock.Name = "picLock"
        Me.picLock.Size = New System.Drawing.Size(45, 46)
        Me.picLock.TabIndex = 197
        Me.picLock.TabStop = False
        Me.picLock.Visible = False
        '
        'picUnLock
        '
        Me.picUnLock.Image = CType(resources.GetObject("picUnLock.Image"), System.Drawing.Image)
        Me.picUnLock.Location = New System.Drawing.Point(247, 42)
        Me.picUnLock.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picUnLock.Name = "picUnLock"
        Me.picUnLock.Size = New System.Drawing.Size(47, 44)
        Me.picUnLock.TabIndex = 198
        Me.picUnLock.TabStop = False
        Me.picUnLock.Visible = False
        '
        'panel2
        '
        Me.panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel2.BackColor = System.Drawing.Color.Transparent
        Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel2.Controls.Add(Me.picProduc)
        Me.panel2.Controls.Add(Me.cmdSalvar)
        Me.panel2.Controls.Add(Me.picLocutor)
        Me.panel2.Controls.Add(Me.cmbListHoresDetall)
        Me.panel2.Controls.Add(Me.dtpDetallData)
        Me.panel2.Controls.Add(Me.lbNomDetall)
        Me.panel2.Location = New System.Drawing.Point(54, 80)
        Me.panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(727, 35)
        Me.panel2.TabIndex = 199
        '
        'picProduc
        '
        Me.picProduc.Image = CType(resources.GetObject("picProduc.Image"), System.Drawing.Image)
        Me.picProduc.Location = New System.Drawing.Point(631, 2)
        Me.picProduc.Name = "picProduc"
        Me.picProduc.Size = New System.Drawing.Size(30, 30)
        Me.picProduc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picProduc.TabIndex = 203
        Me.picProduc.TabStop = False
        Me.picProduc.Visible = False
        '
        'cmdSalvar
        '
        Me.cmdSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdSalvar.Enabled = False
        Me.cmdSalvar.Image = CType(resources.GetObject("cmdSalvar.Image"), System.Drawing.Image)
        Me.cmdSalvar.ImageSize = 30
        Me.cmdSalvar.Location = New System.Drawing.Point(692, 0)
        Me.cmdSalvar.Name = "cmdSalvar"
        Me.cmdSalvar.Size = New System.Drawing.Size(30, 30)
        Me.cmdSalvar.TabIndex = 8
        Me.cmdSalvar.UseSelectable = True
        '
        'picLocutor
        '
        Me.picLocutor.Image = CType(resources.GetObject("picLocutor.Image"), System.Drawing.Image)
        Me.picLocutor.Location = New System.Drawing.Point(591, 2)
        Me.picLocutor.Name = "picLocutor"
        Me.picLocutor.Size = New System.Drawing.Size(34, 30)
        Me.picLocutor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLocutor.TabIndex = 202
        Me.picLocutor.TabStop = False
        Me.picLocutor.Visible = False
        '
        'cmbListHoresDetall
        '
        Me.cmbListHoresDetall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbListHoresDetall.Enabled = False
        Me.cmbListHoresDetall.FormattingEnabled = True
        Me.cmbListHoresDetall.Location = New System.Drawing.Point(401, 4)
        Me.cmbListHoresDetall.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbListHoresDetall.Name = "cmbListHoresDetall"
        Me.cmbListHoresDetall.Size = New System.Drawing.Size(184, 25)
        Me.cmbListHoresDetall.TabIndex = 7
        '
        'dtpDetallData
        '
        Me.dtpDetallData.Enabled = False
        Me.dtpDetallData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDetallData.Location = New System.Drawing.Point(217, 4)
        Me.dtpDetallData.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpDetallData.Name = "dtpDetallData"
        Me.dtpDetallData.Size = New System.Drawing.Size(178, 25)
        Me.dtpDetallData.TabIndex = 5
        Me.dtpDetallData.Value = New Date(2010, 1, 26, 0, 0, 0, 0)
        '
        'lbNomDetall
        '
        Me.lbNomDetall.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbNomDetall.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNomDetall.Location = New System.Drawing.Point(4, 3)
        Me.lbNomDetall.Name = "lbNomDetall"
        Me.lbNomDetall.Size = New System.Drawing.Size(208, 26)
        Me.lbNomDetall.TabIndex = 0
        Me.lbNomDetall.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MetroLink1
        '
        Me.MetroLink1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLink1.BackColor = System.Drawing.Color.Transparent
        Me.MetroLink1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroLink1.Location = New System.Drawing.Point(0, 0)
        Me.MetroLink1.Name = "MetroLink1"
        Me.MetroLink1.Size = New System.Drawing.Size(104, 21)
        Me.MetroLink1.TabIndex = 200
        Me.MetroLink1.Text = "MetroLink1 fgh fgh f"
        Me.MetroLink1.UseCustomBackColor = True
        Me.MetroLink1.UseSelectable = True
        Me.MetroLink1.UseStyleColors = True
        '
        'PanelPubli
        '
        Me.PanelPubli.BackColor = System.Drawing.Color.White
        Me.PanelPubli.Controls.Add(Me.MetroLink1)
        Me.PanelPubli.Controls.Add(Me.lnkLocutor)
        Me.PanelPubli.Controls.Add(Me.MetroLink2)
        Me.PanelPubli.HorizontalScrollbarBarColor = True
        Me.PanelPubli.HorizontalScrollbarHighlightOnWheel = False
        Me.PanelPubli.HorizontalScrollbarSize = 10
        Me.PanelPubli.Location = New System.Drawing.Point(381, 17)
        Me.PanelPubli.Name = "PanelPubli"
        Me.PanelPubli.Size = New System.Drawing.Size(104, 50)
        Me.PanelPubli.TabIndex = 201
        Me.PanelPubli.UseCustomBackColor = True
        Me.PanelPubli.VerticalScrollbarBarColor = True
        Me.PanelPubli.VerticalScrollbarHighlightOnWheel = False
        Me.PanelPubli.VerticalScrollbarSize = 10
        Me.PanelPubli.Visible = False
        '
        'lnkLocutor
        '
        Me.lnkLocutor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lnkLocutor.Image = CType(resources.GetObject("lnkLocutor.Image"), System.Drawing.Image)
        Me.lnkLocutor.Location = New System.Drawing.Point(15, 24)
        Me.lnkLocutor.Name = "lnkLocutor"
        Me.lnkLocutor.Size = New System.Drawing.Size(23, 23)
        Me.lnkLocutor.TabIndex = 201
        Me.lnkLocutor.UseSelectable = True
        '
        'MetroLink2
        '
        Me.MetroLink2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroLink2.Image = CType(resources.GetObject("MetroLink2.Image"), System.Drawing.Image)
        Me.MetroLink2.Location = New System.Drawing.Point(44, 24)
        Me.MetroLink2.Name = "MetroLink2"
        Me.MetroLink2.Size = New System.Drawing.Size(23, 23)
        Me.MetroLink2.TabIndex = 202
        Me.MetroLink2.UseSelectable = True
        '
        'pic_logo
        '
        Me.pic_logo.Image = CType(resources.GetObject("pic_logo.Image"), System.Drawing.Image)
        Me.pic_logo.Location = New System.Drawing.Point(25, 25)
        Me.pic_logo.Name = "pic_logo"
        Me.pic_logo.Size = New System.Drawing.Size(40, 40)
        Me.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_logo.TabIndex = 267
        Me.pic_logo.TabStop = False
        '
        'frmCalendarPubli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmbExit
        Me.ClientSize = New System.Drawing.Size(1022, 575)
        Me.Controls.Add(Me.pic_logo)
        Me.Controls.Add(Me.PanelPubli)
        Me.Controls.Add(Me.PictureBoxCalendar)
        Me.Controls.Add(Me.pnlDies)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.PanelCalendar)
        Me.Controls.Add(Me.dtpDataRadi)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.buttonResizeCalendarMenys)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.buttonResizeCalendarMes)
        Me.Controls.Add(Me.cmbExit)
        Me.Controls.Add(Me.picLock)
        Me.Controls.Add(Me.cmdActual)
        Me.Controls.Add(Me.picUnLock)
        Me.Controls.Add(Me.cmdPost)
        Me.Controls.Add(Me.cmdAnt)
        Me.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmCalendarPubli"
        Me.Padding = New System.Windows.Forms.Padding(23, 78, 23, 26)
        Me.Text = "Calendari Publicitat"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.PanelCalendar.ResumeLayout(False)
        CType(Me.picCalendar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxCalendar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDies.ResumeLayout(False)
        CType(Me.picLock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUnLock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel2.ResumeLayout(False)
        CType(Me.picProduc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLocutor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPubli.ResumeLayout(False)
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdBorrar As System.Windows.Forms.ToolStripButton
    Private lbInfoSave As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmbListHoresDetall As System.Windows.Forms.ComboBox
    Private lbNomDetall As System.Windows.Forms.Label
    Friend WithEvents dtpDetallData As System.Windows.Forms.DateTimePicker
    Private panel2 As System.Windows.Forms.Panel
    Friend picUnLock As System.Windows.Forms.PictureBox
    Friend picLock As System.Windows.Forms.PictureBox
    Friend ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents cmbExit As System.Windows.Forms.Button
    Friend ImageListCalendar As System.Windows.Forms.ImageList
    Friend WithEvents picCalendar As System.Windows.Forms.PictureBox
    Friend picHores As System.Windows.Forms.PictureBox
    Friend WithEvents cmdAnt As System.Windows.Forms.Button
    Friend WithEvents cmdPost As System.Windows.Forms.Button
    Friend WithEvents cmdActual As System.Windows.Forms.Button
    Friend lbDg As System.Windows.Forms.Label
    Friend lbDs As System.Windows.Forms.Label
    Friend lbDv As System.Windows.Forms.Label
    Friend lbDj As System.Windows.Forms.Label
    Friend lbDres As System.Windows.Forms.Label
    Friend lbDts As System.Windows.Forms.Label
    Friend lbDll As System.Windows.Forms.Label
    Friend pnlDies As System.Windows.Forms.Panel
    Private WithEvents buttonResizeCalendarMes As System.Windows.Forms.Button
    Private WithEvents buttonResizeCalendarMenys As System.Windows.Forms.Button
    Friend WithEvents dtpDataRadi As System.Windows.Forms.DateTimePicker
    Friend WithEvents PictureBoxCalendar As System.Windows.Forms.PictureBox
    Friend PanelCalendar As System.Windows.Forms.Panel
    Friend WithEvents cmdBloqueix As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdExitTool As System.Windows.Forms.ToolStripButton
    Friend ToolStrip1 As System.Windows.Forms.ToolStrip
    Public WithEvents mnu_Help As System.Windows.Forms.ToolStripMenuItem
    Friend AjudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend ProgarmaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents cmdSalvar As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLink1 As MetroFramework.Controls.MetroLink
    Friend WithEvents PanelPubli As MetroFramework.Controls.MetroPanel
    Friend WithEvents picLocutor As PictureBox
    Friend WithEvents picProduc As PictureBox
    Friend WithEvents MetroLink2 As MetroFramework.Controls.MetroLink
    Friend WithEvents lnkLocutor As MetroFramework.Controls.MetroLink
    Friend WithEvents pic_logo As PictureBox
End Class
