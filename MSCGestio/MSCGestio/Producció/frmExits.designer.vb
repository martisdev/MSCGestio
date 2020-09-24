<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmExits
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmExits))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.MetroListViewTops = New MetroFramework.Controls.MetroListView()
        Me.ColumnHeaderTitol = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderInterp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderTop = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderDataIn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderDataOut = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderDataTop = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderNumIn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderVots = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderSetmames = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderDV = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.cmdDel = New MetroFramework.Controls.MetroTile()
        Me.cmdAdd = New MetroFramework.Controls.MetroTile()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDataIn = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstMusicDisp = New MetroFramework.Controls.MetroListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProgarmaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReproductorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPlay = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStop = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFinal = New System.Windows.Forms.ToolStripMenuItem()
        Me.EdicióToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModif = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDel = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_Help = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.cmdSortir = New System.Windows.Forms.ToolStripButton()
        Me.lbVuMeter = New System.Windows.Forms.ToolStripLabel()
        Me.cmdStop = New System.Windows.Forms.ToolStripButton()
        Me.cmdPlay = New System.Windows.Forms.ToolStripButton()
        Me.cmdPrint = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdBloqueix = New System.Windows.Forms.ToolStripButton()
        Me.cmdSalvar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.picVuMeter = New System.Windows.Forms.PictureBox()
        Me.tmrPlayer = New System.Windows.Forms.Timer(Me.components)
        Me.picPause = New System.Windows.Forms.PictureBox()
        Me.picPlay = New System.Windows.Forms.PictureBox()
        Me.picLock = New System.Windows.Forms.PictureBox()
        Me.picUnLock = New System.Windows.Forms.PictureBox()
        Me.pic_logo = New System.Windows.Forms.PictureBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.picVuMeter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPause, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUnLock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(23, 125)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.MetroListViewTops)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdDel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdAdd)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtDataIn)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lstMusicDisp)
        Me.SplitContainer1.Size = New System.Drawing.Size(1032, 430)
        Me.SplitContainer1.SplitterDistance = 261
        Me.SplitContainer1.SplitterWidth = 5
        Me.SplitContainer1.TabIndex = 3
        '
        'MetroListViewTops
        '
        Me.MetroListViewTops.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroListViewTops.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderTitol, Me.ColumnHeaderInterp, Me.ColumnHeaderTop, Me.ColumnHeaderDataIn, Me.ColumnHeaderDataOut, Me.ColumnHeaderDataTop, Me.ColumnHeaderNumIn, Me.ColumnHeaderVots, Me.ColumnHeaderSetmames, Me.ColumnHeaderDV})
        Me.MetroListViewTops.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MetroListViewTops.FullRowSelect = True
        Me.MetroListViewTops.LargeImageList = Me.ImageList1
        Me.MetroListViewTops.Location = New System.Drawing.Point(5, 4)
        Me.MetroListViewTops.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MetroListViewTops.Name = "MetroListViewTops"
        Me.MetroListViewTops.OwnerDraw = True
        Me.MetroListViewTops.Size = New System.Drawing.Size(1022, 184)
        Me.MetroListViewTops.SmallImageList = Me.ImageList1
        Me.MetroListViewTops.StateImageList = Me.ImageList1
        Me.MetroListViewTops.TabIndex = 189
        Me.MetroListViewTops.UseCompatibleStateImageBehavior = False
        Me.MetroListViewTops.UseSelectable = True
        Me.MetroListViewTops.View = System.Windows.Forms.View.Details
        '
        'ColumnHeaderTitol
        '
        Me.ColumnHeaderTitol.Text = "Títol tema"
        Me.ColumnHeaderTitol.Width = 300
        '
        'ColumnHeaderInterp
        '
        Me.ColumnHeaderInterp.Text = "Interpret"
        Me.ColumnHeaderInterp.Width = 250
        '
        'ColumnHeaderTop
        '
        Me.ColumnHeaderTop.Text = "TOP"
        Me.ColumnHeaderTop.Width = 40
        '
        'ColumnHeaderDataIn
        '
        Me.ColumnHeaderDataIn.Text = "Data IN"
        Me.ColumnHeaderDataIn.Width = 120
        '
        'ColumnHeaderDataOut
        '
        Me.ColumnHeaderDataOut.Text = "Data Out"
        Me.ColumnHeaderDataOut.Width = 120
        '
        'ColumnHeaderDataTop
        '
        Me.ColumnHeaderDataTop.Text = "Data TOP"
        Me.ColumnHeaderDataTop.Width = 120
        '
        'ColumnHeaderNumIn
        '
        Me.ColumnHeaderNumIn.Text = "Núm IN"
        Me.ColumnHeaderNumIn.Width = 40
        '
        'ColumnHeaderVots
        '
        Me.ColumnHeaderVots.Text = "Vots"
        Me.ColumnHeaderVots.Width = 40
        '
        'ColumnHeaderSetmames
        '
        Me.ColumnHeaderSetmames.Text = "Setmanes"
        Me.ColumnHeaderSetmames.Width = 40
        '
        'ColumnHeaderDV
        '
        Me.ColumnHeaderDV.Text = "DV"
        Me.ColumnHeaderDV.Width = 40
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ImageList1.Images.SetKeyName(0, "new")
        Me.ImageList1.Images.SetKeyName(1, "altres")
        Me.ImageList1.Images.SetKeyName(2, "n1")
        '
        'cmdDel
        '
        Me.cmdDel.ActiveControl = Nothing
        Me.cmdDel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdDel.Enabled = False
        Me.cmdDel.Location = New System.Drawing.Point(471, 192)
        Me.cmdDel.Name = "cmdDel"
        Me.cmdDel.Size = New System.Drawing.Size(222, 64)
        Me.cmdDel.TabIndex = 7
        Me.cmdDel.TileImage = CType(resources.GetObject("cmdDel.TileImage"), System.Drawing.Image)
        Me.cmdDel.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdDel.UseSelectable = True
        Me.cmdDel.UseTileImage = True
        '
        'cmdAdd
        '
        Me.cmdAdd.ActiveControl = Nothing
        Me.cmdAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdAdd.Enabled = False
        Me.cmdAdd.Location = New System.Drawing.Point(237, 192)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(222, 64)
        Me.cmdAdd.TabIndex = 6
        Me.cmdAdd.TileImage = CType(resources.GetObject("cmdAdd.TileImage"), System.Drawing.Image)
        Me.cmdAdd.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdAdd.UseSelectable = True
        Me.cmdAdd.UseTileImage = True
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(756, 217)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(259, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Index DV: Dies a la llista / nº de vots"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(753, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Arrossega els temes per canviar l'ordre."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(3, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(512, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Busca tots els HITs , TOPs i HITTOPs amb data d'entrada major o igual a l'especif" &
    "icada"
        '
        'txtDataIn
        '
        Me.txtDataIn.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtDataIn.Enabled = False
        Me.txtDataIn.Location = New System.Drawing.Point(756, 127)
        Me.txtDataIn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDataIn.Name = "txtDataIn"
        Me.txtDataIn.Size = New System.Drawing.Size(234, 25)
        Me.txtDataIn.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label2.Location = New System.Drawing.Point(587, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Data d'entrada"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lstMusicDisp
        '
        Me.lstMusicDisp.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstMusicDisp.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.lstMusicDisp.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lstMusicDisp.FullRowSelect = True
        Me.lstMusicDisp.Location = New System.Drawing.Point(3, 4)
        Me.lstMusicDisp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstMusicDisp.Name = "lstMusicDisp"
        Me.lstMusicDisp.OwnerDraw = True
        Me.lstMusicDisp.Size = New System.Drawing.Size(1024, 115)
        Me.lstMusicDisp.TabIndex = 0
        Me.lstMusicDisp.UseCompatibleStateImageBehavior = False
        Me.lstMusicDisp.UseSelectable = True
        Me.lstMusicDisp.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Títol Tema"
        Me.ColumnHeader6.Width = 300
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Intèrpret"
        Me.ColumnHeader7.Width = 300
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Data entrada"
        Me.ColumnHeader8.Width = 250
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgarmaToolStripMenuItem, Me.ReproductorToolStripMenuItem, Me.EdicióToolStripMenuItem, Me.ToolStripMenuItem8})
        Me.MenuStrip1.Location = New System.Drawing.Point(761, 30)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(330, 26)
        Me.MenuStrip1.TabIndex = 182
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
        'ReproductorToolStripMenuItem
        '
        Me.ReproductorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPlay, Me.mnuStop, Me.ToolStripSeparator3, Me.mnuFinal})
        Me.ReproductorToolStripMenuItem.Image = CType(resources.GetObject("ReproductorToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReproductorToolStripMenuItem.Name = "ReproductorToolStripMenuItem"
        Me.ReproductorToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.ReproductorToolStripMenuItem.Text = "Reproductor"
        '
        'mnuPlay
        '
        Me.mnuPlay.Image = CType(resources.GetObject("mnuPlay.Image"), System.Drawing.Image)
        Me.mnuPlay.Name = "mnuPlay"
        Me.mnuPlay.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.mnuPlay.Size = New System.Drawing.Size(176, 22)
        Me.mnuPlay.Tag = "1"
        Me.mnuPlay.Text = "Play/Pausa"
        '
        'mnuStop
        '
        Me.mnuStop.Image = CType(resources.GetObject("mnuStop.Image"), System.Drawing.Image)
        Me.mnuStop.Name = "mnuStop"
        Me.mnuStop.ShortcutKeys = System.Windows.Forms.Keys.F7
        Me.mnuStop.Size = New System.Drawing.Size(176, 22)
        Me.mnuStop.Tag = "2"
        Me.mnuStop.Text = "Stop"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(173, 6)
        '
        'mnuFinal
        '
        Me.mnuFinal.Name = "mnuFinal"
        Me.mnuFinal.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F9), System.Windows.Forms.Keys)
        Me.mnuFinal.Size = New System.Drawing.Size(176, 22)
        Me.mnuFinal.Tag = "4"
        Me.mnuFinal.Text = "Final Tema"
        '
        'EdicióToolStripMenuItem
        '
        Me.EdicióToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuModif, Me.mnuSave, Me.mnuDel})
        Me.EdicióToolStripMenuItem.Image = CType(resources.GetObject("EdicióToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EdicióToolStripMenuItem.Name = "EdicióToolStripMenuItem"
        Me.EdicióToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.EdicióToolStripMenuItem.Text = "Edició"
        '
        'mnuModif
        '
        Me.mnuModif.Enabled = False
        Me.mnuModif.Name = "mnuModif"
        Me.mnuModif.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.mnuModif.Size = New System.Drawing.Size(164, 22)
        Me.mnuModif.Text = "Modificar"
        '
        'mnuSave
        '
        Me.mnuSave.Enabled = False
        Me.mnuSave.Image = CType(resources.GetObject("mnuSave.Image"), System.Drawing.Image)
        Me.mnuSave.Name = "mnuSave"
        Me.mnuSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuSave.Size = New System.Drawing.Size(164, 22)
        Me.mnuSave.Text = "Salvar"
        '
        'mnuDel
        '
        Me.mnuDel.Enabled = False
        Me.mnuDel.Image = CType(resources.GetObject("mnuDel.Image"), System.Drawing.Image)
        Me.mnuDel.Name = "mnuDel"
        Me.mnuDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Delete), System.Windows.Forms.Keys)
        Me.mnuDel.Size = New System.Drawing.Size(164, 22)
        Me.mnuDel.Text = "Borrar"
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
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(36, 36)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdSortir, Me.lbVuMeter, Me.cmdStop, Me.cmdPlay, Me.cmdPrint, Me.ToolStripSeparator2, Me.cmdBloqueix, Me.cmdSalvar, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(23, 78)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1045, 43)
        Me.ToolStrip1.TabIndex = 183
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'cmdSortir
        '
        Me.cmdSortir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.cmdSortir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdSortir.Image = CType(resources.GetObject("cmdSortir.Image"), System.Drawing.Image)
        Me.cmdSortir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSortir.Name = "cmdSortir"
        Me.cmdSortir.Size = New System.Drawing.Size(40, 40)
        Me.cmdSortir.Text = "Sortir"
        '
        'lbVuMeter
        '
        Me.lbVuMeter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lbVuMeter.AutoSize = False
        Me.lbVuMeter.Name = "lbVuMeter"
        Me.lbVuMeter.Size = New System.Drawing.Size(150, 40)
        '
        'cmdStop
        '
        Me.cmdStop.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.cmdStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdStop.Enabled = False
        Me.cmdStop.Image = CType(resources.GetObject("cmdStop.Image"), System.Drawing.Image)
        Me.cmdStop.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdStop.Name = "cmdStop"
        Me.cmdStop.Size = New System.Drawing.Size(40, 40)
        Me.cmdStop.Text = "Stop"
        '
        'cmdPlay
        '
        Me.cmdPlay.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.cmdPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdPlay.Image = CType(resources.GetObject("cmdPlay.Image"), System.Drawing.Image)
        Me.cmdPlay.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPlay.Name = "cmdPlay"
        Me.cmdPlay.Size = New System.Drawing.Size(40, 40)
        Me.cmdPlay.Text = "Play/Pausa"
        '
        'cmdPrint
        '
        Me.cmdPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(40, 40)
        Me.cmdPrint.Text = "Imprimir llistat"
        Me.cmdPrint.Visible = False
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 43)
        '
        'cmdBloqueix
        '
        Me.cmdBloqueix.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdBloqueix.Enabled = False
        Me.cmdBloqueix.Image = CType(resources.GetObject("cmdBloqueix.Image"), System.Drawing.Image)
        Me.cmdBloqueix.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdBloqueix.Name = "cmdBloqueix"
        Me.cmdBloqueix.Size = New System.Drawing.Size(40, 40)
        Me.cmdBloqueix.Text = "Editar"
        '
        'cmdSalvar
        '
        Me.cmdSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdSalvar.Enabled = False
        Me.cmdSalvar.Image = CType(resources.GetObject("cmdSalvar.Image"), System.Drawing.Image)
        Me.cmdSalvar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSalvar.Name = "cmdSalvar"
        Me.cmdSalvar.Size = New System.Drawing.Size(40, 40)
        Me.cmdSalvar.Text = "Salvar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 43)
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.Location = New System.Drawing.Point(1041, 88)
        Me.cmdClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(16, 20)
        Me.cmdClose.TabIndex = 0
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'picVuMeter
        '
        Me.picVuMeter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picVuMeter.BackColor = System.Drawing.SystemColors.Control
        Me.picVuMeter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picVuMeter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picVuMeter.Location = New System.Drawing.Point(882, 84)
        Me.picVuMeter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picVuMeter.Name = "picVuMeter"
        Me.picVuMeter.Size = New System.Drawing.Size(142, 32)
        Me.picVuMeter.TabIndex = 184
        Me.picVuMeter.TabStop = False
        '
        'tmrPlayer
        '
        Me.tmrPlayer.Interval = 25
        '
        'picPause
        '
        Me.picPause.ErrorImage = CType(resources.GetObject("picPause.ErrorImage"), System.Drawing.Image)
        Me.picPause.Image = CType(resources.GetObject("picPause.Image"), System.Drawing.Image)
        Me.picPause.Location = New System.Drawing.Point(674, 22)
        Me.picPause.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picPause.Name = "picPause"
        Me.picPause.Size = New System.Drawing.Size(19, 18)
        Me.picPause.TabIndex = 186
        Me.picPause.TabStop = False
        Me.picPause.Visible = False
        '
        'picPlay
        '
        Me.picPlay.ErrorImage = CType(resources.GetObject("picPlay.ErrorImage"), System.Drawing.Image)
        Me.picPlay.Image = CType(resources.GetObject("picPlay.Image"), System.Drawing.Image)
        Me.picPlay.Location = New System.Drawing.Point(649, 20)
        Me.picPlay.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picPlay.Name = "picPlay"
        Me.picPlay.Size = New System.Drawing.Size(19, 20)
        Me.picPlay.TabIndex = 185
        Me.picPlay.TabStop = False
        Me.picPlay.Visible = False
        '
        'picLock
        '
        Me.picLock.Image = CType(resources.GetObject("picLock.Image"), System.Drawing.Image)
        Me.picLock.Location = New System.Drawing.Point(680, 48)
        Me.picLock.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picLock.Name = "picLock"
        Me.picLock.Size = New System.Drawing.Size(36, 46)
        Me.picLock.TabIndex = 187
        Me.picLock.TabStop = False
        Me.picLock.Visible = False
        '
        'picUnLock
        '
        Me.picUnLock.Image = CType(resources.GetObject("picUnLock.Image"), System.Drawing.Image)
        Me.picUnLock.Location = New System.Drawing.Point(632, 48)
        Me.picUnLock.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picUnLock.Name = "picUnLock"
        Me.picUnLock.Size = New System.Drawing.Size(36, 50)
        Me.picUnLock.TabIndex = 188
        Me.picUnLock.TabStop = False
        Me.picUnLock.Visible = False
        '
        'pic_logo
        '
        Me.pic_logo.Image = CType(resources.GetObject("pic_logo.Image"), System.Drawing.Image)
        Me.pic_logo.Location = New System.Drawing.Point(25, 25)
        Me.pic_logo.Name = "pic_logo"
        Me.pic_logo.Size = New System.Drawing.Size(40, 40)
        Me.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_logo.TabIndex = 265
        Me.pic_logo.TabStop = False
        '
        'frmExits
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdClose
        Me.ClientSize = New System.Drawing.Size(1091, 572)
        Me.Controls.Add(Me.pic_logo)
        Me.Controls.Add(Me.picLock)
        Me.Controls.Add(Me.picUnLock)
        Me.Controls.Add(Me.picPause)
        Me.Controls.Add(Me.picPlay)
        Me.Controls.Add(Me.picVuMeter)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmExits"
        Me.Padding = New System.Windows.Forms.Padding(23, 78, 23, 26)
        Me.Text = "LLista d'èxits"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.picVuMeter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPause, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUnLock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDataIn As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ProgarmaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReproductorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPlay As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuStop As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuFinal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EdicióToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuModif As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents lbVuMeter As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmdStop As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdPlay As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdSalvar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdSortir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents picVuMeter As System.Windows.Forms.PictureBox
    Friend WithEvents tmrPlayer As System.Windows.Forms.Timer
    Friend WithEvents picPause As System.Windows.Forms.PictureBox
    Friend WithEvents picPlay As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdBloqueix As System.Windows.Forms.ToolStripButton
    Friend WithEvents picLock As System.Windows.Forms.PictureBox
    Friend WithEvents picUnLock As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnu_Help As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lstMusicDisp As MetroFramework.Controls.MetroListView
    Friend WithEvents cmdDel As MetroFramework.Controls.MetroTile
    Friend WithEvents cmdAdd As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroListViewTops As MetroFramework.Controls.MetroListView
    Friend WithEvents ColumnHeaderTop As ColumnHeader
    Friend WithEvents ColumnHeaderTitol As ColumnHeader
    Friend WithEvents ColumnHeaderInterp As ColumnHeader
    Friend WithEvents ColumnHeaderDataIn As ColumnHeader
    Friend WithEvents ColumnHeaderDataOut As ColumnHeader
    Friend WithEvents ColumnHeaderDataTop As ColumnHeader
    Friend WithEvents ColumnHeaderNumIn As ColumnHeader
    Friend WithEvents ColumnHeaderVots As ColumnHeader
    Friend WithEvents ColumnHeaderSetmames As ColumnHeader
    Friend WithEvents ColumnHeaderDV As ColumnHeader
    Friend WithEvents pic_logo As PictureBox
End Class
