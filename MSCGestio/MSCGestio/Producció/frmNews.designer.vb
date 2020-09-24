<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNews
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNews))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.cmdPrimer = New System.Windows.Forms.ToolStripButton()
        Me.cmdPrevi = New System.Windows.Forms.ToolStripButton()
        Me.cmdSeguent = New System.Windows.Forms.ToolStripButton()
        Me.cmdUltim = New System.Windows.Forms.ToolStripButton()
        Me.lbPosition = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.lbRecCount = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdNou = New System.Windows.Forms.ToolStripButton()
        Me.cmdBloqueix = New System.Windows.Forms.ToolStripButton()
        Me.cmdBorrar = New System.Windows.Forms.ToolStripButton()
        Me.cmdSalvar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.OptionBuscar = New System.Windows.Forms.ToolStripSplitButton()
        Me.PerIDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerTitularToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerQualsevolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_vigents = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdSortir = New System.Windows.Forms.ToolStripButton()
        Me.txtBuscar = New System.Windows.Forms.ToolStripTextBox()
        Me.lbNou = New System.Windows.Forms.ToolStripLabel()
        Me.PanelGeneral = New System.Windows.Forms.Panel()
        Me.ChkActiva = New MetroFramework.Controls.MetroToggle()
        Me.lbCategoria = New System.Windows.Forms.LinkLabel()
        Me.txtAutor = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbClicks = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDataOut = New System.Windows.Forms.DateTimePicker()
        Me.txtDataIn = New System.Windows.Forms.DateTimePicker()
        Me.ButtonAddPig = New MetroFramework.Controls.MetroButton()
        Me.ButtonDelPic = New MetroFramework.Controls.MetroButton()
        Me.picture = New System.Windows.Forms.PictureBox()
        Me.lbTAGS = New System.Windows.Forms.LinkLabel()
        Me.ListViewTags = New System.Windows.Forms.ListView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbDataCrea = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.lbUltim = New System.Windows.Forms.Label()
        Me.picLock = New System.Windows.Forms.PictureBox()
        Me.picUnLock = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.comboCategoria = New System.Windows.Forms.ComboBox()
        Me.txtCos = New System.Windows.Forms.TextBox()
        Me.txtTitular = New System.Windows.Forms.TextBox()
        Me.lbID = New System.Windows.Forms.Label()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.gridDades = New MetroFramework.Controls.MetroGrid()
        Me.ColumnID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnTipus = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ColumnTitular = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnCos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnDataCrea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnDataPubli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnDataOut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnActiva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnCliks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnAutor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProgarmaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.EdicióToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModif = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDel = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_Help = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.tmrDetalls = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMenuStripTags = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuAddTAG = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTotsTags = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCatTAGS = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExcludeTAG = New System.Windows.Forms.ToolStripMenuItem()
        Me.pic_logo = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1.SuspendLayout()
        Me.PanelGeneral.SuspendLayout()
        CType(Me.picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.picLock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUnLock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridDades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStripTags.SuspendLayout()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdPrimer, Me.cmdPrevi, Me.cmdSeguent, Me.cmdUltim, Me.lbPosition, Me.ToolStripLabel1, Me.lbRecCount, Me.ToolStripSeparator1, Me.cmdNou, Me.cmdBloqueix, Me.cmdBorrar, Me.cmdSalvar, Me.ToolStripSeparator2, Me.cmdRefrescar, Me.OptionBuscar, Me.cmdSortir, Me.txtBuscar, Me.lbNou})
        Me.ToolStrip1.Location = New System.Drawing.Point(23, 78)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(976, 39)
        Me.ToolStrip1.TabIndex = 38
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'cmdPrimer
        '
        Me.cmdPrimer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdPrimer.Image = CType(resources.GetObject("cmdPrimer.Image"), System.Drawing.Image)
        Me.cmdPrimer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPrimer.Name = "cmdPrimer"
        Me.cmdPrimer.Size = New System.Drawing.Size(36, 36)
        Me.cmdPrimer.Text = "Primer"
        '
        'cmdPrevi
        '
        Me.cmdPrevi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdPrevi.Image = CType(resources.GetObject("cmdPrevi.Image"), System.Drawing.Image)
        Me.cmdPrevi.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPrevi.Name = "cmdPrevi"
        Me.cmdPrevi.Size = New System.Drawing.Size(36, 36)
        Me.cmdPrevi.Text = "Anterior"
        '
        'cmdSeguent
        '
        Me.cmdSeguent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdSeguent.Image = CType(resources.GetObject("cmdSeguent.Image"), System.Drawing.Image)
        Me.cmdSeguent.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSeguent.Name = "cmdSeguent"
        Me.cmdSeguent.Size = New System.Drawing.Size(36, 36)
        Me.cmdSeguent.Text = "Següent"
        '
        'cmdUltim
        '
        Me.cmdUltim.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdUltim.Image = CType(resources.GetObject("cmdUltim.Image"), System.Drawing.Image)
        Me.cmdUltim.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdUltim.Name = "cmdUltim"
        Me.cmdUltim.Size = New System.Drawing.Size(36, 36)
        Me.cmdUltim.Text = "Últim"
        '
        'lbPosition
        '
        Me.lbPosition.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPosition.Name = "lbPosition"
        Me.lbPosition.Size = New System.Drawing.Size(16, 36)
        Me.lbPosition.Text = "0"
        Me.lbPosition.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(16, 36)
        Me.ToolStripLabel1.Text = "/"
        '
        'lbRecCount
        '
        Me.lbRecCount.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRecCount.Name = "lbRecCount"
        Me.lbRecCount.Size = New System.Drawing.Size(16, 36)
        Me.lbRecCount.Text = "0"
        Me.lbRecCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'cmdNou
        '
        Me.cmdNou.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdNou.Image = CType(resources.GetObject("cmdNou.Image"), System.Drawing.Image)
        Me.cmdNou.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdNou.Name = "cmdNou"
        Me.cmdNou.Size = New System.Drawing.Size(36, 36)
        Me.cmdNou.Text = "Nou"
        '
        'cmdBloqueix
        '
        Me.cmdBloqueix.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdBloqueix.Enabled = False
        Me.cmdBloqueix.Image = CType(resources.GetObject("cmdBloqueix.Image"), System.Drawing.Image)
        Me.cmdBloqueix.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdBloqueix.Name = "cmdBloqueix"
        Me.cmdBloqueix.Size = New System.Drawing.Size(36, 36)
        Me.cmdBloqueix.Text = "Editar"
        '
        'cmdBorrar
        '
        Me.cmdBorrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdBorrar.Enabled = False
        Me.cmdBorrar.Image = CType(resources.GetObject("cmdBorrar.Image"), System.Drawing.Image)
        Me.cmdBorrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(36, 36)
        Me.cmdBorrar.Text = "Borrar"
        '
        'cmdSalvar
        '
        Me.cmdSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdSalvar.Enabled = False
        Me.cmdSalvar.Image = CType(resources.GetObject("cmdSalvar.Image"), System.Drawing.Image)
        Me.cmdSalvar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSalvar.Name = "cmdSalvar"
        Me.cmdSalvar.Size = New System.Drawing.Size(36, 36)
        Me.cmdSalvar.Text = "Salvar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'cmdRefrescar
        '
        Me.cmdRefrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdRefrescar.Image = CType(resources.GetObject("cmdRefrescar.Image"), System.Drawing.Image)
        Me.cmdRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdRefrescar.Name = "cmdRefrescar"
        Me.cmdRefrescar.Size = New System.Drawing.Size(36, 36)
        Me.cmdRefrescar.Text = "Refrescar"
        '
        'OptionBuscar
        '
        Me.OptionBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OptionBuscar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PerIDToolStripMenuItem, Me.PerTitularToolStripMenuItem, Me.PerQualsevolToolStripMenuItem, Me.mnu_vigents})
        Me.OptionBuscar.Image = CType(resources.GetObject("OptionBuscar.Image"), System.Drawing.Image)
        Me.OptionBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OptionBuscar.Name = "OptionBuscar"
        Me.OptionBuscar.Size = New System.Drawing.Size(48, 36)
        Me.OptionBuscar.Text = "Buscar"
        '
        'PerIDToolStripMenuItem
        '
        Me.PerIDToolStripMenuItem.Name = "PerIDToolStripMenuItem"
        Me.PerIDToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.PerIDToolStripMenuItem.Text = "Per ID"
        '
        'PerTitularToolStripMenuItem
        '
        Me.PerTitularToolStripMenuItem.Name = "PerTitularToolStripMenuItem"
        Me.PerTitularToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.PerTitularToolStripMenuItem.Text = "Per Titular"
        '
        'PerQualsevolToolStripMenuItem
        '
        Me.PerQualsevolToolStripMenuItem.Checked = True
        Me.PerQualsevolToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.PerQualsevolToolStripMenuItem.Name = "PerQualsevolToolStripMenuItem"
        Me.PerQualsevolToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.PerQualsevolToolStripMenuItem.Text = "Per Qualsevol"
        '
        'mnu_vigents
        '
        Me.mnu_vigents.Name = "mnu_vigents"
        Me.mnu_vigents.Size = New System.Drawing.Size(153, 22)
        Me.mnu_vigents.Text = "Només vigents"
        Me.mnu_vigents.ToolTipText = "Actives i entre dates"
        '
        'cmdSortir
        '
        Me.cmdSortir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.cmdSortir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdSortir.Image = CType(resources.GetObject("cmdSortir.Image"), System.Drawing.Image)
        Me.cmdSortir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSortir.Name = "cmdSortir"
        Me.cmdSortir.Size = New System.Drawing.Size(36, 36)
        Me.cmdSortir.Text = "Sortir"
        '
        'txtBuscar
        '
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(116, 39)
        '
        'lbNou
        '
        Me.lbNou.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNou.ForeColor = System.Drawing.Color.Red
        Me.lbNou.Name = "lbNou"
        Me.lbNou.Size = New System.Drawing.Size(61, 36)
        Me.lbNou.Text = "NOU"
        Me.lbNou.Visible = False
        '
        'PanelGeneral
        '
        Me.PanelGeneral.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelGeneral.Controls.Add(Me.ChkActiva)
        Me.PanelGeneral.Controls.Add(Me.lbCategoria)
        Me.PanelGeneral.Controls.Add(Me.txtAutor)
        Me.PanelGeneral.Controls.Add(Me.Label9)
        Me.PanelGeneral.Controls.Add(Me.lbClicks)
        Me.PanelGeneral.Controls.Add(Me.Label8)
        Me.PanelGeneral.Controls.Add(Me.Label7)
        Me.PanelGeneral.Controls.Add(Me.txtDataOut)
        Me.PanelGeneral.Controls.Add(Me.txtDataIn)
        Me.PanelGeneral.Controls.Add(Me.ButtonAddPig)
        Me.PanelGeneral.Controls.Add(Me.ButtonDelPic)
        Me.PanelGeneral.Controls.Add(Me.picture)
        Me.PanelGeneral.Controls.Add(Me.lbTAGS)
        Me.PanelGeneral.Controls.Add(Me.ListViewTags)
        Me.PanelGeneral.Controls.Add(Me.Label6)
        Me.PanelGeneral.Controls.Add(Me.lbDataCrea)
        Me.PanelGeneral.Controls.Add(Me.Label5)
        Me.PanelGeneral.Controls.Add(Me.ToolStrip2)
        Me.PanelGeneral.Controls.Add(Me.lbUltim)
        Me.PanelGeneral.Controls.Add(Me.picLock)
        Me.PanelGeneral.Controls.Add(Me.picUnLock)
        Me.PanelGeneral.Controls.Add(Me.Label4)
        Me.PanelGeneral.Controls.Add(Me.Label3)
        Me.PanelGeneral.Controls.Add(Me.Label1)
        Me.PanelGeneral.Controls.Add(Me.comboCategoria)
        Me.PanelGeneral.Controls.Add(Me.txtCos)
        Me.PanelGeneral.Controls.Add(Me.txtTitular)
        Me.PanelGeneral.Controls.Add(Me.lbID)
        Me.PanelGeneral.Location = New System.Drawing.Point(26, 121)
        Me.PanelGeneral.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelGeneral.Name = "PanelGeneral"
        Me.PanelGeneral.Size = New System.Drawing.Size(973, 326)
        Me.PanelGeneral.TabIndex = 45
        '
        'ChkActiva
        '
        Me.ChkActiva.AutoSize = True
        Me.ChkActiva.Enabled = False
        Me.ChkActiva.Location = New System.Drawing.Point(446, 2)
        Me.ChkActiva.Name = "ChkActiva"
        Me.ChkActiva.Size = New System.Drawing.Size(80, 21)
        Me.ChkActiva.TabIndex = 270
        Me.ChkActiva.Text = "Off"
        Me.ChkActiva.UseSelectable = True
        '
        'lbCategoria
        '
        Me.lbCategoria.Location = New System.Drawing.Point(21, 27)
        Me.lbCategoria.Name = "lbCategoria"
        Me.lbCategoria.Size = New System.Drawing.Size(126, 17)
        Me.lbCategoria.TabIndex = 269
        Me.lbCategoria.TabStop = True
        Me.lbCategoria.Text = "Categoria"
        Me.lbCategoria.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtAutor
        '
        Me.txtAutor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtAutor.Enabled = False
        Me.txtAutor.Location = New System.Drawing.Point(516, 299)
        Me.txtAutor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAutor.Name = "txtAutor"
        Me.txtAutor.Size = New System.Drawing.Size(142, 25)
        Me.txtAutor.TabIndex = 268
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.Location = New System.Drawing.Point(401, 303)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 17)
        Me.Label9.TabIndex = 267
        Me.Label9.Text = "Autor:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbClicks
        '
        Me.lbClicks.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbClicks.AutoSize = True
        Me.lbClicks.Location = New System.Drawing.Point(730, 243)
        Me.lbClicks.Name = "lbClicks"
        Me.lbClicks.Size = New System.Drawing.Size(15, 17)
        Me.lbClicks.TabIndex = 266
        Me.lbClicks.Text = "0"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.Location = New System.Drawing.Point(619, 243)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 17)
        Me.Label8.TabIndex = 265
        Me.Label8.Text = "Clicks:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.Location = New System.Drawing.Point(21, 302)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 17)
        Me.Label7.TabIndex = 264
        Me.Label7.Text = "Data Caducitat:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtDataOut
        '
        Me.txtDataOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtDataOut.Enabled = False
        Me.txtDataOut.Location = New System.Drawing.Point(154, 298)
        Me.txtDataOut.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDataOut.Name = "txtDataOut"
        Me.txtDataOut.Size = New System.Drawing.Size(234, 25)
        Me.txtDataOut.TabIndex = 263
        '
        'txtDataIn
        '
        Me.txtDataIn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtDataIn.Enabled = False
        Me.txtDataIn.Location = New System.Drawing.Point(154, 271)
        Me.txtDataIn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDataIn.Name = "txtDataIn"
        Me.txtDataIn.Size = New System.Drawing.Size(234, 25)
        Me.txtDataIn.TabIndex = 262
        '
        'ButtonAddPig
        '
        Me.ButtonAddPig.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonAddPig.Enabled = False
        Me.ButtonAddPig.Location = New System.Drawing.Point(905, 24)
        Me.ButtonAddPig.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonAddPig.Name = "ButtonAddPig"
        Me.ButtonAddPig.Size = New System.Drawing.Size(28, 26)
        Me.ButtonAddPig.TabIndex = 260
        Me.ButtonAddPig.Text = "+"
        Me.ButtonAddPig.UseSelectable = True
        '
        'ButtonDelPic
        '
        Me.ButtonDelPic.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonDelPic.Enabled = False
        Me.ButtonDelPic.Location = New System.Drawing.Point(939, 24)
        Me.ButtonDelPic.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonDelPic.Name = "ButtonDelPic"
        Me.ButtonDelPic.Size = New System.Drawing.Size(28, 26)
        Me.ButtonDelPic.TabIndex = 261
        Me.ButtonDelPic.Text = "-"
        Me.ButtonDelPic.UseSelectable = True
        '
        'picture
        '
        Me.picture.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picture.ErrorImage = CType(resources.GetObject("picture.ErrorImage"), System.Drawing.Image)
        Me.picture.Image = CType(resources.GetObject("picture.Image"), System.Drawing.Image)
        Me.picture.InitialImage = CType(resources.GetObject("picture.InitialImage"), System.Drawing.Image)
        Me.picture.Location = New System.Drawing.Point(733, 52)
        Me.picture.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picture.Name = "picture"
        Me.picture.Size = New System.Drawing.Size(234, 165)
        Me.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picture.TabIndex = 259
        Me.picture.TabStop = False
        '
        'lbTAGS
        '
        Me.lbTAGS.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbTAGS.Location = New System.Drawing.Point(21, 220)
        Me.lbTAGS.Name = "lbTAGS"
        Me.lbTAGS.Size = New System.Drawing.Size(126, 17)
        Me.lbTAGS.TabIndex = 258
        Me.lbTAGS.TabStop = True
        Me.lbTAGS.Text = "Etiquetes"
        Me.lbTAGS.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ListViewTags
        '
        Me.ListViewTags.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListViewTags.Enabled = False
        Me.ListViewTags.Location = New System.Drawing.Point(154, 221)
        Me.ListViewTags.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListViewTags.Name = "ListViewTags"
        Me.ListViewTags.Size = New System.Drawing.Size(416, 47)
        Me.ListViewTags.TabIndex = 257
        Me.ListViewTags.UseCompatibleStateImageBehavior = False
        Me.ListViewTags.View = System.Windows.Forms.View.SmallIcon
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.Location = New System.Drawing.Point(21, 274)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 17)
        Me.Label6.TabIndex = 66
        Me.Label6.Text = "Data Publicació:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbDataCrea
        '
        Me.lbDataCrea.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbDataCrea.AutoSize = True
        Me.lbDataCrea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDataCrea.Location = New System.Drawing.Point(730, 223)
        Me.lbDataCrea.Name = "lbDataCrea"
        Me.lbDataCrea.Size = New System.Drawing.Size(0, 13)
        Me.lbDataCrea.TabIndex = 65
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.Location = New System.Drawing.Point(619, 221)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 17)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "Data Creació"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip2.AutoSize = False
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator3, Me.ToolStripButton3})
        Me.ToolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip2.Location = New System.Drawing.Point(933, 191)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(29, 88)
        Me.ToolStrip2.TabIndex = 63
        Me.ToolStrip2.Text = "ToolStrip2"
        Me.ToolStrip2.Visible = False
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(27, 20)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        Me.ToolStripButton1.ToolTipText = "Negreta"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(27, 20)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        Me.ToolStripButton2.ToolTipText = "Cursiva"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(27, 6)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(27, 20)
        Me.ToolStripButton3.Text = "ToolStripButton3"
        Me.ToolStripButton3.ToolTipText = "Link"
        '
        'lbUltim
        '
        Me.lbUltim.AutoSize = True
        Me.lbUltim.BackColor = System.Drawing.Color.Lime
        Me.lbUltim.Location = New System.Drawing.Point(664, 6)
        Me.lbUltim.Name = "lbUltim"
        Me.lbUltim.Size = New System.Drawing.Size(15, 17)
        Me.lbUltim.TabIndex = 62
        Me.lbUltim.Text = "0"
        Me.lbUltim.Visible = False
        '
        'picLock
        '
        Me.picLock.Image = CType(resources.GetObject("picLock.Image"), System.Drawing.Image)
        Me.picLock.Location = New System.Drawing.Point(560, -2)
        Me.picLock.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picLock.Name = "picLock"
        Me.picLock.Size = New System.Drawing.Size(45, 46)
        Me.picLock.TabIndex = 60
        Me.picLock.TabStop = False
        Me.picLock.Visible = False
        '
        'picUnLock
        '
        Me.picUnLock.Image = CType(resources.GetObject("picUnLock.Image"), System.Drawing.Image)
        Me.picUnLock.Location = New System.Drawing.Point(611, -2)
        Me.picUnLock.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picUnLock.Name = "picUnLock"
        Me.picUnLock.Size = New System.Drawing.Size(47, 44)
        Me.picUnLock.TabIndex = 61
        Me.picUnLock.TabStop = False
        Me.picUnLock.Visible = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(21, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 17)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Cos"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(21, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 17)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Titular"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(126, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 17)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "id:"
        '
        'comboCategoria
        '
        Me.comboCategoria.Enabled = False
        Me.comboCategoria.FormattingEnabled = True
        Me.comboCategoria.Location = New System.Drawing.Point(154, 24)
        Me.comboCategoria.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.comboCategoria.Name = "comboCategoria"
        Me.comboCategoria.Size = New System.Drawing.Size(355, 25)
        Me.comboCategoria.TabIndex = 1
        '
        'txtCos
        '
        Me.txtCos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCos.Enabled = False
        Me.txtCos.Location = New System.Drawing.Point(154, 141)
        Me.txtCos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCos.Multiline = True
        Me.txtCos.Name = "txtCos"
        Me.txtCos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCos.Size = New System.Drawing.Size(573, 76)
        Me.txtCos.TabIndex = 3
        '
        'txtTitular
        '
        Me.txtTitular.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTitular.Enabled = False
        Me.txtTitular.Location = New System.Drawing.Point(154, 52)
        Me.txtTitular.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTitular.Multiline = True
        Me.txtTitular.Name = "txtTitular"
        Me.txtTitular.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTitular.Size = New System.Drawing.Size(573, 85)
        Me.txtTitular.TabIndex = 2
        '
        'lbID
        '
        Me.lbID.AutoSize = True
        Me.lbID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbID.Location = New System.Drawing.Point(159, 6)
        Me.lbID.Name = "lbID"
        Me.lbID.Size = New System.Drawing.Size(14, 13)
        Me.lbID.TabIndex = 49
        Me.lbID.Text = "0"
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Location = New System.Drawing.Point(100, 86)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(21, 19)
        Me.cmdExit.TabIndex = 46
        Me.cmdExit.Text = "Button1"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'gridDades
        '
        Me.gridDades.AllowUserToAddRows = False
        Me.gridDades.AllowUserToDeleteRows = False
        Me.gridDades.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.gridDades.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.gridDades.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridDades.BackgroundColor = System.Drawing.SystemColors.Window
        Me.gridDades.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gridDades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.gridDades.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridDades.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.gridDades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridDades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnID, Me.ColumnTipus, Me.ColumnTitular, Me.ColumnCos, Me.ColumnDataCrea, Me.ColumnDataPubli, Me.ColumnDataOut, Me.ColumnActiva, Me.ColumnCliks, Me.ColumnAutor})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridDades.DefaultCellStyle = DataGridViewCellStyle3
        Me.gridDades.EnableHeadersVisualStyles = False
        Me.gridDades.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.gridDades.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gridDades.Location = New System.Drawing.Point(26, 450)
        Me.gridDades.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gridDades.Name = "gridDades"
        Me.gridDades.ReadOnly = True
        Me.gridDades.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridDades.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.gridDades.RowHeadersVisible = False
        Me.gridDades.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.gridDades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridDades.ShowEditingIcon = False
        Me.gridDades.Size = New System.Drawing.Size(973, 113)
        Me.gridDades.TabIndex = 153
        '
        'ColumnID
        '
        Me.ColumnID.DataPropertyName = "news_id"
        Me.ColumnID.HeaderText = "ID"
        Me.ColumnID.Name = "ColumnID"
        Me.ColumnID.ReadOnly = True
        Me.ColumnID.Width = 50
        '
        'ColumnTipus
        '
        Me.ColumnTipus.DataPropertyName = "news_tipusid"
        Me.ColumnTipus.HeaderText = "Tipus"
        Me.ColumnTipus.Name = "ColumnTipus"
        Me.ColumnTipus.ReadOnly = True
        Me.ColumnTipus.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColumnTipus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ColumnTipus.Visible = False
        '
        'ColumnTitular
        '
        Me.ColumnTitular.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnTitular.DataPropertyName = "news_titular"
        Me.ColumnTitular.HeaderText = "Titular"
        Me.ColumnTitular.Name = "ColumnTitular"
        Me.ColumnTitular.ReadOnly = True
        '
        'ColumnCos
        '
        Me.ColumnCos.DataPropertyName = "news_cos"
        Me.ColumnCos.HeaderText = "cos"
        Me.ColumnCos.Name = "ColumnCos"
        Me.ColumnCos.ReadOnly = True
        Me.ColumnCos.Visible = False
        '
        'ColumnDataCrea
        '
        Me.ColumnDataCrea.DataPropertyName = "news_datacreacio"
        Me.ColumnDataCrea.HeaderText = "Data Creació"
        Me.ColumnDataCrea.Name = "ColumnDataCrea"
        Me.ColumnDataCrea.ReadOnly = True
        Me.ColumnDataCrea.Visible = False
        '
        'ColumnDataPubli
        '
        Me.ColumnDataPubli.DataPropertyName = "news_datapublicacio"
        Me.ColumnDataPubli.HeaderText = "Data Publicació"
        Me.ColumnDataPubli.Name = "ColumnDataPubli"
        Me.ColumnDataPubli.ReadOnly = True
        Me.ColumnDataPubli.Width = 120
        '
        'ColumnDataOut
        '
        Me.ColumnDataOut.DataPropertyName = "news_datacaducitat"
        Me.ColumnDataOut.HeaderText = "Data Caducitat"
        Me.ColumnDataOut.Name = "ColumnDataOut"
        Me.ColumnDataOut.ReadOnly = True
        Me.ColumnDataOut.Width = 120
        '
        'ColumnActiva
        '
        Me.ColumnActiva.DataPropertyName = "news_activa"
        Me.ColumnActiva.HeaderText = "Activa"
        Me.ColumnActiva.Name = "ColumnActiva"
        Me.ColumnActiva.ReadOnly = True
        Me.ColumnActiva.Visible = False
        Me.ColumnActiva.Width = 50
        '
        'ColumnCliks
        '
        Me.ColumnCliks.DataPropertyName = "news_clicks"
        Me.ColumnCliks.HeaderText = "Clicks"
        Me.ColumnCliks.Name = "ColumnCliks"
        Me.ColumnCliks.ReadOnly = True
        Me.ColumnCliks.Visible = False
        Me.ColumnCliks.Width = 50
        '
        'ColumnAutor
        '
        Me.ColumnAutor.DataPropertyName = "news_autor"
        Me.ColumnAutor.HeaderText = "Autor"
        Me.ColumnAutor.Name = "ColumnAutor"
        Me.ColumnAutor.ReadOnly = True
        Me.ColumnAutor.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgarmaToolStripMenuItem, Me.EdicióToolStripMenuItem, Me.ToolStripMenuItem8})
        Me.MenuStrip1.Location = New System.Drawing.Point(789, 30)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(229, 26)
        Me.MenuStrip1.TabIndex = 154
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
        'EdicióToolStripMenuItem
        '
        Me.EdicióToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuModif, Me.mnuSave, Me.mnuNew, Me.mnuDel, Me.ToolStripSeparator4, Me.mnuRefresh})
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
        'mnuNew
        '
        Me.mnuNew.Image = CType(resources.GetObject("mnuNew.Image"), System.Drawing.Image)
        Me.mnuNew.Name = "mnuNew"
        Me.mnuNew.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.mnuNew.Size = New System.Drawing.Size(164, 22)
        Me.mnuNew.Text = "Nou"
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
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(161, 6)
        '
        'mnuRefresh
        '
        Me.mnuRefresh.Image = CType(resources.GetObject("mnuRefresh.Image"), System.Drawing.Image)
        Me.mnuRefresh.Name = "mnuRefresh"
        Me.mnuRefresh.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.mnuRefresh.Size = New System.Drawing.Size(164, 22)
        Me.mnuRefresh.Text = "Refrescar"
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
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "arxius d'imatges |*.gif; *.jpg; *.jpeg; *.bmp"
        Me.OpenFileDialog1.Title = "Seleccioneu una foto (Max. 62Kb)"
        '
        'tmrDetalls
        '
        Me.tmrDetalls.Interval = 500
        '
        'ContextMenuStripTags
        '
        Me.ContextMenuStripTags.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAddTAG, Me.mnuExcludeTAG})
        Me.ContextMenuStripTags.Name = "ContextMenuStripTags"
        Me.ContextMenuStripTags.Size = New System.Drawing.Size(131, 48)
        '
        'mnuAddTAG
        '
        Me.mnuAddTAG.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTotsTags, Me.mnuCatTAGS})
        Me.mnuAddTAG.Name = "mnuAddTAG"
        Me.mnuAddTAG.Size = New System.Drawing.Size(130, 22)
        Me.mnuAddTAG.Text = "Afegir TAG"
        '
        'mnuTotsTags
        '
        Me.mnuTotsTags.Name = "mnuTotsTags"
        Me.mnuTotsTags.Size = New System.Drawing.Size(130, 22)
        Me.mnuTotsTags.Text = "Tots"
        '
        'mnuCatTAGS
        '
        Me.mnuCatTAGS.Name = "mnuCatTAGS"
        Me.mnuCatTAGS.Size = New System.Drawing.Size(130, 22)
        Me.mnuCatTAGS.Text = "Categories"
        '
        'mnuExcludeTAG
        '
        Me.mnuExcludeTAG.Enabled = False
        Me.mnuExcludeTAG.Name = "mnuExcludeTAG"
        Me.mnuExcludeTAG.Size = New System.Drawing.Size(130, 22)
        Me.mnuExcludeTAG.Text = "Borrar TAG"
        '
        'pic_logo
        '
        Me.pic_logo.Image = CType(resources.GetObject("pic_logo.Image"), System.Drawing.Image)
        Me.pic_logo.Location = New System.Drawing.Point(25, 25)
        Me.pic_logo.Name = "pic_logo"
        Me.pic_logo.Size = New System.Drawing.Size(40, 40)
        Me.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_logo.TabIndex = 266
        Me.pic_logo.TabStop = False
        '
        'frmNews
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(1022, 575)
        Me.Controls.Add(Me.pic_logo)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.gridDades)
        Me.Controls.Add(Me.PanelGeneral)
        Me.Controls.Add(Me.cmdExit)
        Me.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmNews"
        Me.Padding = New System.Windows.Forms.Padding(23, 78, 23, 26)
        Me.Text = "Redacció de Notícies"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.PanelGeneral.ResumeLayout(False)
        Me.PanelGeneral.PerformLayout()
        CType(Me.picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.picLock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUnLock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridDades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStripTags.ResumeLayout(False)
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdPrimer As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdPrevi As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdSeguent As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdUltim As System.Windows.Forms.ToolStripButton
    Friend WithEvents lbPosition As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lbRecCount As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdNou As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdBloqueix As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdBorrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdSalvar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdSortir As System.Windows.Forms.ToolStripButton
    Friend WithEvents PanelGeneral As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents comboCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents txtCos As System.Windows.Forms.TextBox
    Friend WithEvents txtTitular As System.Windows.Forms.TextBox
    Friend WithEvents lbID As System.Windows.Forms.Label
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents picLock As System.Windows.Forms.PictureBox
    Friend WithEvents picUnLock As System.Windows.Forms.PictureBox
    Friend WithEvents lbUltim As System.Windows.Forms.Label
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents OptionBuscar As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents txtBuscar As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbDataCrea As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PerIDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PerTitularToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PerQualsevolToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ProgarmaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EdicióToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuModif As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuRefresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnu_Help As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbTAGS As System.Windows.Forms.LinkLabel
    Friend WithEvents ListViewTags As System.Windows.Forms.ListView
    Friend WithEvents picture As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDataOut As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDataIn As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbClicks As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtAutor As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tmrDetalls As System.Windows.Forms.Timer
    Friend WithEvents ContextMenuStripTags As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuAddTAG As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTotsTags As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCatTAGS As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExcludeTAG As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColumnID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnTipus As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents ColumnTitular As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnCos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnDataCrea As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnDataPubli As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnDataOut As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnActiva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnCliks As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnAutor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mnu_vigents As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbCategoria As System.Windows.Forms.LinkLabel
    Friend WithEvents lbNou As ToolStripLabel
    Friend WithEvents gridDades As MetroFramework.Controls.MetroGrid
    Friend WithEvents ButtonAddPig As MetroFramework.Controls.MetroButton
    Friend WithEvents ButtonDelPic As MetroFramework.Controls.MetroButton
    Friend WithEvents ChkActiva As MetroFramework.Controls.MetroToggle
    Friend WithEvents pic_logo As PictureBox
End Class
