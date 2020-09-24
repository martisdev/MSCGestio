<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantBKPAudio
    Inherits System.Windows.Forms.Form

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
    	Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMantBKPAudio))
    	Me.cmdSortir = New System.Windows.Forms.ToolStripButton()
    	Me.cmdRefrescar = New System.Windows.Forms.ToolStripButton()
    	Me.cmdExit = New System.Windows.Forms.Button()
    	Me.lbNou = New System.Windows.Forms.Label()
    	Me.txtNom = New System.Windows.Forms.TextBox()
    	Me.Label2 = New System.Windows.Forms.Label()
    	Me.Label1 = New System.Windows.Forms.Label()
    	Me.lbID = New System.Windows.Forms.Label()
    	Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
    	Me.cmdPrevi = New System.Windows.Forms.ToolStripButton()
    	Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
    	Me.picLock = New System.Windows.Forms.PictureBox()
    	Me.cmdPrimer = New System.Windows.Forms.ToolStripButton()
    	Me.cmdUltim = New System.Windows.Forms.ToolStripButton()
    	Me.lbPosition = New System.Windows.Forms.ToolStripLabel()
    	Me.cmdSeguent = New System.Windows.Forms.ToolStripButton()
    	Me.picUnLock = New System.Windows.Forms.PictureBox()
    	Me.cmdBloqueix = New System.Windows.Forms.ToolStripButton()
    	Me.cmdBorrar = New System.Windows.Forms.ToolStripButton()
    	Me.cmdSalvar = New System.Windows.Forms.ToolStripButton()
    	Me.cmdNou = New System.Windows.Forms.ToolStripButton()
    	Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
    	Me.lbRecCount = New System.Windows.Forms.ToolStripLabel()
    	Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
    	Me.optionBuscar = New System.Windows.Forms.ToolStripDropDownButton()
    	Me.PerIDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    	Me.PerNomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    	Me.QualsevolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    	Me.txtBuscar = New System.Windows.Forms.ToolStripTextBox()
    	Me.Label3 = New System.Windows.Forms.Label()
    	Me.ComboTipFitx = New System.Windows.Forms.ComboBox()
    	Me.chkSaved = New System.Windows.Forms.CheckBox()
    	Me.TabPageSave = New System.Windows.Forms.TabPage()
    	Me.PanelSave = New System.Windows.Forms.Panel()
    	Me.ProgressBar = New System.Windows.Forms.ProgressBar()
    	Me.cmdCancel = New System.Windows.Forms.Button()
    	Me.lstFitxers = New System.Windows.Forms.ListView()
    	Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader()
    	Me.lbTamany = New System.Windows.Forms.Label()
    	Me.Label6 = New System.Windows.Forms.Label()
    	Me.lbNFitxers = New System.Windows.Forms.Label()
    	Me.Label5 = New System.Windows.Forms.Label()
    	Me.cmdSalvarFitxers = New System.Windows.Forms.Button()
    	Me.cmdAllTrack = New System.Windows.Forms.Button()
    	Me.Label4 = New System.Windows.Forms.Label()
    	Me.cmdPath = New System.Windows.Forms.Button()
    	Me.txtPath = New System.Windows.Forms.TextBox()
    	Me.TabPage1 = New System.Windows.Forms.TabPage()
    	Me.gridDades = New System.Windows.Forms.DataGridView()
    	Me.ColumnID = New System.Windows.Forms.DataGridViewTextBoxColumn()
    	Me.ColumnNom = New System.Windows.Forms.DataGridViewTextBoxColumn()
    	Me.ColumnCBarres = New System.Windows.Forms.DataGridViewTextBoxColumn()
    	Me.ColumnTipus = New System.Windows.Forms.DataGridViewTextBoxColumn()
    	Me.ColumnSaved = New System.Windows.Forms.DataGridViewTextBoxColumn()
    	Me.TabControl1 = New System.Windows.Forms.TabControl()
    	Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
    	Me.ProgarmaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    	Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
    	Me.EdicióToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    	Me.mnuModif = New System.Windows.Forms.ToolStripMenuItem()
    	Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
    	Me.mnuNew = New System.Windows.Forms.ToolStripMenuItem()
    	Me.mnuDel = New System.Windows.Forms.ToolStripMenuItem()
    	Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
    	Me.mnuBuscar = New System.Windows.Forms.ToolStripMenuItem()
    	Me.mnuRefresh = New System.Windows.Forms.ToolStripMenuItem()
    	Me.KjToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator()
    	Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
    	Me.mnu_Help = New System.Windows.Forms.ToolStripMenuItem()
    	Me.lbInfoProgs = New System.Windows.Forms.Label()
    	Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
    	CType(Me.picLock,System.ComponentModel.ISupportInitialize).BeginInit
    	CType(Me.picUnLock,System.ComponentModel.ISupportInitialize).BeginInit
    	Me.ToolStrip1.SuspendLayout
    	Me.TabPageSave.SuspendLayout
    	Me.PanelSave.SuspendLayout
    	Me.TabPage1.SuspendLayout
    	CType(Me.gridDades,System.ComponentModel.ISupportInitialize).BeginInit
    	Me.TabControl1.SuspendLayout
    	Me.MenuStrip1.SuspendLayout
    	Me.SuspendLayout
    	'
    	'cmdSortir
    	'
    	Me.cmdSortir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    	Me.cmdSortir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    	Me.cmdSortir.Image = CType(resources.GetObject("cmdSortir.Image"),System.Drawing.Image)
    	Me.cmdSortir.ImageTransparentColor = System.Drawing.Color.Magenta
    	Me.cmdSortir.Name = "cmdSortir"
    	Me.cmdSortir.Size = New System.Drawing.Size(36, 36)
    	Me.cmdSortir.Text = "ToolStripButton11"
    	'
    	'cmdRefrescar
    	'
    	Me.cmdRefrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    	Me.cmdRefrescar.Image = CType(resources.GetObject("cmdRefrescar.Image"),System.Drawing.Image)
    	Me.cmdRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta
    	Me.cmdRefrescar.Name = "cmdRefrescar"
    	Me.cmdRefrescar.Size = New System.Drawing.Size(36, 36)
    	Me.cmdRefrescar.Text = "Refrescar"
    	'
    	'cmdExit
    	'
    	Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
    	Me.cmdExit.Location = New System.Drawing.Point(-22, 12)
    	Me.cmdExit.Name = "cmdExit"
    	Me.cmdExit.Size = New System.Drawing.Size(34, 16)
    	Me.cmdExit.TabIndex = 106
    	Me.cmdExit.Text = "Button1"
    	Me.cmdExit.UseVisualStyleBackColor = true
    	'
    	'lbNou
    	'
    	Me.lbNou.AutoSize = true
    	Me.lbNou.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.lbNou.ForeColor = System.Drawing.Color.Red
    	Me.lbNou.Location = New System.Drawing.Point(310, 70)
    	Me.lbNou.Name = "lbNou"
    	Me.lbNou.Size = New System.Drawing.Size(61, 25)
    	Me.lbNou.TabIndex = 109
    	Me.lbNou.Text = "NOU"
    	Me.lbNou.Visible = false
    	'
    	'txtNom
    	'
    	Me.txtNom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
    	    	    	Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    	Me.txtNom.Enabled = false
    	Me.txtNom.Location = New System.Drawing.Point(203, 98)
    	Me.txtNom.Name = "txtNom"
    	Me.txtNom.Size = New System.Drawing.Size(256, 20)
    	Me.txtNom.TabIndex = 113
    	'
    	'Label2
    	'
    	Me.Label2.Location = New System.Drawing.Point(101, 101)
    	Me.Label2.Name = "Label2"
    	Me.Label2.Size = New System.Drawing.Size(96, 13)
    	Me.Label2.TabIndex = 112
    	Me.Label2.Text = "Nom:"
    	Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
    	'
    	'Label1
    	'
    	Me.Label1.Location = New System.Drawing.Point(101, 79)
    	Me.Label1.Name = "Label1"
    	Me.Label1.Size = New System.Drawing.Size(96, 13)
    	Me.Label1.TabIndex = 111
    	Me.Label1.Text = "Identificador:"
    	Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
    	'
    	'lbID
    	'
    	Me.lbID.AutoSize = true
    	Me.lbID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.lbID.Location = New System.Drawing.Point(203, 79)
    	Me.lbID.Name = "lbID"
    	Me.lbID.Size = New System.Drawing.Size(14, 13)
    	Me.lbID.TabIndex = 110
    	Me.lbID.Text = "0"
    	'
    	'ToolStripSeparator2
    	'
    	Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
    	Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
    	'
    	'cmdPrevi
    	'
    	Me.cmdPrevi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    	Me.cmdPrevi.Image = CType(resources.GetObject("cmdPrevi.Image"),System.Drawing.Image)
    	Me.cmdPrevi.ImageTransparentColor = System.Drawing.Color.Magenta
    	Me.cmdPrevi.Name = "cmdPrevi"
    	Me.cmdPrevi.Size = New System.Drawing.Size(36, 36)
    	Me.cmdPrevi.Text = "Anterior"
    	'
    	'ToolStripLabel1
    	'
    	Me.ToolStripLabel1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.ToolStripLabel1.Name = "ToolStripLabel1"
    	Me.ToolStripLabel1.Size = New System.Drawing.Size(16, 36)
    	Me.ToolStripLabel1.Text = "/"
    	'
    	'picLock
    	'
    	Me.picLock.Image = CType(resources.GetObject("picLock.Image"),System.Drawing.Image)
    	Me.picLock.Location = New System.Drawing.Point(482, 79)
    	Me.picLock.Name = "picLock"
    	Me.picLock.Size = New System.Drawing.Size(39, 35)
    	Me.picLock.TabIndex = 107
    	Me.picLock.TabStop = false
    	Me.picLock.Visible = false
    	'
    	'cmdPrimer
    	'
    	Me.cmdPrimer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    	Me.cmdPrimer.Image = CType(resources.GetObject("cmdPrimer.Image"),System.Drawing.Image)
    	Me.cmdPrimer.ImageTransparentColor = System.Drawing.Color.Magenta
    	Me.cmdPrimer.Name = "cmdPrimer"
    	Me.cmdPrimer.Size = New System.Drawing.Size(36, 36)
    	Me.cmdPrimer.Text = "Primer"
    	'
    	'cmdUltim
    	'
    	Me.cmdUltim.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    	Me.cmdUltim.Image = CType(resources.GetObject("cmdUltim.Image"),System.Drawing.Image)
    	Me.cmdUltim.ImageTransparentColor = System.Drawing.Color.Magenta
    	Me.cmdUltim.Name = "cmdUltim"
    	Me.cmdUltim.Size = New System.Drawing.Size(36, 36)
    	Me.cmdUltim.Text = "Últim"
    	'
    	'lbPosition
    	'
    	Me.lbPosition.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.lbPosition.Name = "lbPosition"
    	Me.lbPosition.Size = New System.Drawing.Size(16, 36)
    	Me.lbPosition.Text = "0"
    	Me.lbPosition.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    	'
    	'cmdSeguent
    	'
    	Me.cmdSeguent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    	Me.cmdSeguent.Image = CType(resources.GetObject("cmdSeguent.Image"),System.Drawing.Image)
    	Me.cmdSeguent.ImageTransparentColor = System.Drawing.Color.Magenta
    	Me.cmdSeguent.Name = "cmdSeguent"
    	Me.cmdSeguent.Size = New System.Drawing.Size(36, 36)
    	Me.cmdSeguent.Text = "Següent"
    	'
    	'picUnLock
    	'
    	Me.picUnLock.Image = CType(resources.GetObject("picUnLock.Image"),System.Drawing.Image)
    	Me.picUnLock.Location = New System.Drawing.Point(481, 43)
    	Me.picUnLock.Name = "picUnLock"
    	Me.picUnLock.Size = New System.Drawing.Size(40, 34)
    	Me.picUnLock.TabIndex = 108
    	Me.picUnLock.TabStop = false
    	Me.picUnLock.Visible = false
    	'
    	'cmdBloqueix
    	'
    	Me.cmdBloqueix.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    	Me.cmdBloqueix.Enabled = false
    	Me.cmdBloqueix.Image = CType(resources.GetObject("cmdBloqueix.Image"),System.Drawing.Image)
    	Me.cmdBloqueix.ImageTransparentColor = System.Drawing.Color.Magenta
    	Me.cmdBloqueix.Name = "cmdBloqueix"
    	Me.cmdBloqueix.Size = New System.Drawing.Size(36, 36)
    	Me.cmdBloqueix.Text = "Editar"
    	'
    	'cmdBorrar
    	'
    	Me.cmdBorrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    	Me.cmdBorrar.Enabled = false
    	Me.cmdBorrar.Image = CType(resources.GetObject("cmdBorrar.Image"),System.Drawing.Image)
    	Me.cmdBorrar.ImageTransparentColor = System.Drawing.Color.Magenta
    	Me.cmdBorrar.Name = "cmdBorrar"
    	Me.cmdBorrar.Size = New System.Drawing.Size(36, 36)
    	Me.cmdBorrar.Text = "Borrar"
    	'
    	'cmdSalvar
    	'
    	Me.cmdSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    	Me.cmdSalvar.Enabled = false
    	Me.cmdSalvar.Image = CType(resources.GetObject("cmdSalvar.Image"),System.Drawing.Image)
    	Me.cmdSalvar.ImageTransparentColor = System.Drawing.Color.Magenta
    	Me.cmdSalvar.Name = "cmdSalvar"
    	Me.cmdSalvar.Size = New System.Drawing.Size(36, 36)
    	Me.cmdSalvar.Text = "Salvar"
    	'
    	'cmdNou
    	'
    	Me.cmdNou.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    	Me.cmdNou.Image = CType(resources.GetObject("cmdNou.Image"),System.Drawing.Image)
    	Me.cmdNou.ImageTransparentColor = System.Drawing.Color.Magenta
    	Me.cmdNou.Name = "cmdNou"
    	Me.cmdNou.Size = New System.Drawing.Size(36, 36)
    	Me.cmdNou.Text = "Nou"
    	'
    	'ToolStrip1
    	'
    	Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
    	Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdPrimer, Me.cmdPrevi, Me.cmdSeguent, Me.cmdUltim, Me.lbPosition, Me.ToolStripLabel1, Me.lbRecCount, Me.ToolStripSeparator1, Me.cmdNou, Me.cmdBloqueix, Me.cmdBorrar, Me.cmdSalvar, Me.ToolStripSeparator2, Me.cmdRefrescar, Me.cmdSortir, Me.optionBuscar, Me.txtBuscar})
    	Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
    	Me.ToolStrip1.Name = "ToolStrip1"
    	Me.ToolStrip1.Size = New System.Drawing.Size(594, 39)
    	Me.ToolStrip1.TabIndex = 105
    	Me.ToolStrip1.Text = "ToolStrip1"
    	'
    	'lbRecCount
    	'
    	Me.lbRecCount.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
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
    	'optionBuscar
    	'
    	Me.optionBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    	Me.optionBuscar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PerIDToolStripMenuItem, Me.PerNomToolStripMenuItem, Me.QualsevolToolStripMenuItem})
    	Me.optionBuscar.Image = CType(resources.GetObject("optionBuscar.Image"),System.Drawing.Image)
    	Me.optionBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
    	Me.optionBuscar.Name = "optionBuscar"
    	Me.optionBuscar.Size = New System.Drawing.Size(45, 36)
    	Me.optionBuscar.Text = "Buscar"
    	'
    	'PerIDToolStripMenuItem
    	'
    	Me.PerIDToolStripMenuItem.Name = "PerIDToolStripMenuItem"
    	Me.PerIDToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
    	Me.PerIDToolStripMenuItem.Text = "Per ID"
    	'
    	'PerNomToolStripMenuItem
    	'
    	Me.PerNomToolStripMenuItem.Name = "PerNomToolStripMenuItem"
    	Me.PerNomToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
    	Me.PerNomToolStripMenuItem.Text = "Per Nom"
    	'
    	'QualsevolToolStripMenuItem
    	'
    	Me.QualsevolToolStripMenuItem.Checked = true
    	Me.QualsevolToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
    	Me.QualsevolToolStripMenuItem.Name = "QualsevolToolStripMenuItem"
    	Me.QualsevolToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
    	Me.QualsevolToolStripMenuItem.Text = "Qualsevol"
    	'
    	'txtBuscar
    	'
    	Me.txtBuscar.Name = "txtBuscar"
    	Me.txtBuscar.Size = New System.Drawing.Size(100, 39)
    	Me.txtBuscar.Text = "Buscar..."
    	'
    	'Label3
    	'
    	Me.Label3.Location = New System.Drawing.Point(101, 127)
    	Me.Label3.Name = "Label3"
    	Me.Label3.Size = New System.Drawing.Size(96, 13)
    	Me.Label3.TabIndex = 118
    	Me.Label3.Text = "Tipus de fitxer:"
    	Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
    	'
    	'ComboTipFitx
    	'
    	Me.ComboTipFitx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    	Me.ComboTipFitx.Enabled = false
    	Me.ComboTipFitx.FormattingEnabled = true
    	Me.ComboTipFitx.Location = New System.Drawing.Point(203, 124)
    	Me.ComboTipFitx.Name = "ComboTipFitx"
    	Me.ComboTipFitx.Size = New System.Drawing.Size(204, 21)
    	Me.ComboTipFitx.TabIndex = 119
    	'
    	'chkSaved
    	'
    	Me.chkSaved.AutoSize = true
    	Me.chkSaved.Enabled = false
    	Me.chkSaved.Location = New System.Drawing.Point(203, 151)
    	Me.chkSaved.Name = "chkSaved"
    	Me.chkSaved.Size = New System.Drawing.Size(101, 17)
    	Me.chkSaved.TabIndex = 120
    	Me.chkSaved.Text = "Còpia realitzada"
    	Me.chkSaved.UseVisualStyleBackColor = true
    	'
    	'TabPageSave
    	'
    	Me.TabPageSave.Controls.Add(Me.PanelSave)
    	Me.TabPageSave.Location = New System.Drawing.Point(4, 22)
    	Me.TabPageSave.Name = "TabPageSave"
    	Me.TabPageSave.Padding = New System.Windows.Forms.Padding(3)
    	Me.TabPageSave.Size = New System.Drawing.Size(495, 215)
    	Me.TabPageSave.TabIndex = 1
    	Me.TabPageSave.Text = "Salvar fitxers"
    	Me.TabPageSave.UseVisualStyleBackColor = true
    	'
    	'PanelSave
    	'
    	Me.PanelSave.Controls.Add(Me.ProgressBar)
    	Me.PanelSave.Controls.Add(Me.cmdCancel)
    	Me.PanelSave.Controls.Add(Me.lstFitxers)
    	Me.PanelSave.Controls.Add(Me.lbTamany)
    	Me.PanelSave.Controls.Add(Me.Label6)
    	Me.PanelSave.Controls.Add(Me.lbNFitxers)
    	Me.PanelSave.Controls.Add(Me.Label5)
    	Me.PanelSave.Controls.Add(Me.cmdSalvarFitxers)
    	Me.PanelSave.Controls.Add(Me.cmdAllTrack)
    	Me.PanelSave.Controls.Add(Me.Label4)
    	Me.PanelSave.Controls.Add(Me.cmdPath)
    	Me.PanelSave.Controls.Add(Me.txtPath)
    	Me.PanelSave.Dock = System.Windows.Forms.DockStyle.Fill
    	Me.PanelSave.Enabled = false
    	Me.PanelSave.Location = New System.Drawing.Point(3, 3)
    	Me.PanelSave.Name = "PanelSave"
    	Me.PanelSave.Size = New System.Drawing.Size(489, 209)
    	Me.PanelSave.TabIndex = 0
    	'
    	'ProgressBar
    	'
    	Me.ProgressBar.Location = New System.Drawing.Point(14, 223)
    	Me.ProgressBar.Name = "ProgressBar"
    	Me.ProgressBar.Size = New System.Drawing.Size(383, 16)
    	Me.ProgressBar.TabIndex = 124
    	Me.ProgressBar.Visible = false
    	'
    	'cmdCancel
    	'
    	Me.cmdCancel.Location = New System.Drawing.Point(408, 222)
    	Me.cmdCancel.Name = "cmdCancel"
    	Me.cmdCancel.Size = New System.Drawing.Size(68, 19)
    	Me.cmdCancel.TabIndex = 125
    	Me.cmdCancel.Text = "Cancelar"
    	Me.cmdCancel.UseVisualStyleBackColor = true
    	Me.cmdCancel.Visible = false
    	'
    	'lstFitxers
    	'
    	Me.lstFitxers.CheckBoxes = true
    	Me.lstFitxers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2})
    	Me.lstFitxers.FullRowSelect = true
    	Me.lstFitxers.GridLines = true
    	Me.lstFitxers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
    	Me.lstFitxers.Location = New System.Drawing.Point(14, 28)
    	Me.lstFitxers.MultiSelect = false
    	Me.lstFitxers.Name = "lstFitxers"
    	Me.lstFitxers.Size = New System.Drawing.Size(462, 137)
    	Me.lstFitxers.TabIndex = 20
    	Me.lstFitxers.UseCompatibleStateImageBehavior = false
    	Me.lstFitxers.View = System.Windows.Forms.View.Details
    	'
    	'ColumnHeader2
    	'
    	Me.ColumnHeader2.Text = "Fitxer"
    	Me.ColumnHeader2.Width = 434
    	'
    	'lbTamany
    	'
    	Me.lbTamany.AutoSize = true
    	Me.lbTamany.ForeColor = System.Drawing.Color.Blue
    	Me.lbTamany.Location = New System.Drawing.Point(409, 168)
    	Me.lbTamany.Name = "lbTamany"
    	Me.lbTamany.Size = New System.Drawing.Size(31, 13)
    	Me.lbTamany.TabIndex = 19
    	Me.lbTamany.Text = "0 Mb"
    	'
    	'Label6
    	'
    	Me.Label6.AutoSize = true
    	Me.Label6.ForeColor = System.Drawing.Color.Blue
    	Me.Label6.Location = New System.Drawing.Point(162, 168)
    	Me.Label6.Name = "Label6"
    	Me.Label6.Size = New System.Drawing.Size(234, 13)
    	Me.Label6.TabIndex = 18
    	Me.Label6.Text = "Tamany necessari per fer la còpia de seguretat :"
    	'
    	'lbNFitxers
    	'
    	Me.lbNFitxers.AutoSize = true
    	Me.lbNFitxers.ForeColor = System.Drawing.Color.Blue
    	Me.lbNFitxers.Location = New System.Drawing.Point(101, 168)
    	Me.lbNFitxers.Name = "lbNFitxers"
    	Me.lbNFitxers.Size = New System.Drawing.Size(13, 13)
    	Me.lbNFitxers.TabIndex = 17
    	Me.lbNFitxers.Text = "0"
    	'
    	'Label5
    	'
    	Me.Label5.AutoSize = true
    	Me.Label5.ForeColor = System.Drawing.Color.Blue
    	Me.Label5.Location = New System.Drawing.Point(10, 168)
    	Me.Label5.Name = "Label5"
    	Me.Label5.Size = New System.Drawing.Size(67, 13)
    	Me.Label5.TabIndex = 16
    	Me.Label5.Text = "Nº de fitxers:"
    	'
    	'cmdSalvarFitxers
    	'
    	Me.cmdSalvarFitxers.Enabled = false
    	Me.cmdSalvarFitxers.Location = New System.Drawing.Point(218, 184)
    	Me.cmdSalvarFitxers.Name = "cmdSalvarFitxers"
    	Me.cmdSalvarFitxers.Size = New System.Drawing.Size(129, 20)
    	Me.cmdSalvarFitxers.TabIndex = 15
    	Me.cmdSalvarFitxers.Text = "Salvar Fitxers"
    	Me.cmdSalvarFitxers.UseVisualStyleBackColor = true
    	'
    	'cmdAllTrack
    	'
    	Me.cmdAllTrack.Location = New System.Drawing.Point(72, 184)
    	Me.cmdAllTrack.Name = "cmdAllTrack"
    	Me.cmdAllTrack.Size = New System.Drawing.Size(129, 20)
    	Me.cmdAllTrack.TabIndex = 14
    	Me.cmdAllTrack.Text = "Seleccionar tots"
    	Me.cmdAllTrack.UseVisualStyleBackColor = true
    	'
    	'Label4
    	'
    	Me.Label4.AutoSize = true
    	Me.Label4.Location = New System.Drawing.Point(11, 2)
    	Me.Label4.Name = "Label4"
    	Me.Label4.Size = New System.Drawing.Size(56, 13)
    	Me.Label4.TabIndex = 13
    	Me.Label4.Text = "Path destí"
    	'
    	'cmdPath
    	'
    	Me.cmdPath.Location = New System.Drawing.Point(449, 2)
    	Me.cmdPath.Name = "cmdPath"
    	Me.cmdPath.Size = New System.Drawing.Size(28, 21)
    	Me.cmdPath.TabIndex = 12
    	Me.cmdPath.Text = "..."
    	Me.cmdPath.UseVisualStyleBackColor = true
    	'
    	'txtPath
    	'
    	Me.txtPath.Location = New System.Drawing.Point(94, 2)
    	Me.txtPath.Name = "txtPath"
    	Me.txtPath.Size = New System.Drawing.Size(349, 20)
    	Me.txtPath.TabIndex = 11
    	'
    	'TabPage1
    	'
    	Me.TabPage1.Controls.Add(Me.gridDades)
    	Me.TabPage1.Location = New System.Drawing.Point(4, 22)
    	Me.TabPage1.Name = "TabPage1"
    	Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
    	Me.TabPage1.Size = New System.Drawing.Size(495, 215)
    	Me.TabPage1.TabIndex = 0
    	Me.TabPage1.Text = "Llistat de còpies de seguretat"
    	Me.TabPage1.UseVisualStyleBackColor = true
    	'
    	'gridDades
    	'
    	Me.gridDades.AllowUserToAddRows = false
    	Me.gridDades.AllowUserToDeleteRows = false
    	Me.gridDades.BackgroundColor = System.Drawing.SystemColors.Window
    	Me.gridDades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    	Me.gridDades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnID, Me.ColumnNom, Me.ColumnCBarres, Me.ColumnTipus, Me.ColumnSaved})
    	Me.gridDades.Dock = System.Windows.Forms.DockStyle.Fill
    	Me.gridDades.Location = New System.Drawing.Point(3, 3)
    	Me.gridDades.Name = "gridDades"
    	Me.gridDades.ReadOnly = true
    	Me.gridDades.RowHeadersVisible = false
    	Me.gridDades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    	Me.gridDades.ShowEditingIcon = false
    	Me.gridDades.Size = New System.Drawing.Size(489, 209)
    	Me.gridDades.TabIndex = 153
    	'
    	'ColumnID
    	'
    	Me.ColumnID.DataPropertyName = "bkp_id"
    	Me.ColumnID.HeaderText = "ID"
    	Me.ColumnID.Name = "ColumnID"
    	Me.ColumnID.ReadOnly = true
    	'
    	'ColumnNom
    	'
    	Me.ColumnNom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    	Me.ColumnNom.DataPropertyName = "bkp_nom"
    	Me.ColumnNom.HeaderText = "Nom"
    	Me.ColumnNom.Name = "ColumnNom"
    	Me.ColumnNom.ReadOnly = true
    	'
    	'ColumnCBarres
    	'
    	Me.ColumnCBarres.DataPropertyName = "bkp_codibar"
    	Me.ColumnCBarres.HeaderText = "CodiBarres"
    	Me.ColumnCBarres.Name = "ColumnCBarres"
    	Me.ColumnCBarres.ReadOnly = true
    	Me.ColumnCBarres.Visible = false
    	'
    	'ColumnTipus
    	'
    	Me.ColumnTipus.DataPropertyName = "bkp_tipfitxer"
    	Me.ColumnTipus.HeaderText = "TipusFitxer"
    	Me.ColumnTipus.Name = "ColumnTipus"
    	Me.ColumnTipus.ReadOnly = true
    	Me.ColumnTipus.Visible = false
    	'
    	'ColumnSaved
    	'
    	Me.ColumnSaved.DataPropertyName = "bkp_saved"
    	Me.ColumnSaved.HeaderText = "Saved"
    	Me.ColumnSaved.Name = "ColumnSaved"
    	Me.ColumnSaved.ReadOnly = true
    	Me.ColumnSaved.Visible = false
    	'
    	'TabControl1
    	'
    	Me.TabControl1.Controls.Add(Me.TabPage1)
    	Me.TabControl1.Controls.Add(Me.TabPageSave)
    	Me.TabControl1.Location = New System.Drawing.Point(56, 174)
    	Me.TabControl1.Name = "TabControl1"
    	Me.TabControl1.SelectedIndex = 0
    	Me.TabControl1.Size = New System.Drawing.Size(503, 241)
    	Me.TabControl1.TabIndex = 121
    	'
    	'MenuStrip1
    	'
    	Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgarmaToolStripMenuItem, Me.EdicióToolStripMenuItem, Me.ToolStripMenuItem1})
    	Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
    	Me.MenuStrip1.Name = "MenuStrip1"
    	Me.MenuStrip1.Size = New System.Drawing.Size(594, 24)
    	Me.MenuStrip1.TabIndex = 122
    	Me.MenuStrip1.Text = "MenuStrip1"
    	'
    	'ProgarmaToolStripMenuItem
    	'
    	Me.ProgarmaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExit})
    	Me.ProgarmaToolStripMenuItem.Name = "ProgarmaToolStripMenuItem"
    	Me.ProgarmaToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
    	Me.ProgarmaToolStripMenuItem.Text = "Programa"
    	'
    	'mnuExit
    	'
    	Me.mnuExit.Name = "mnuExit"
    	Me.mnuExit.Size = New System.Drawing.Size(102, 22)
    	Me.mnuExit.Text = "Sortir"
    	'
    	'EdicióToolStripMenuItem
    	'
    	Me.EdicióToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuModif, Me.mnuSave, Me.mnuNew, Me.mnuDel, Me.ToolStripSeparator4, Me.mnuBuscar, Me.mnuRefresh, Me.KjToolStripMenuItem})
    	Me.EdicióToolStripMenuItem.Name = "EdicióToolStripMenuItem"
    	Me.EdicióToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
    	Me.EdicióToolStripMenuItem.Text = "Edició"
    	'
    	'mnuModif
    	'
    	Me.mnuModif.Enabled = false
    	Me.mnuModif.Name = "mnuModif"
    	Me.mnuModif.ShortcutKeys = System.Windows.Forms.Keys.F2
    	Me.mnuModif.Size = New System.Drawing.Size(164, 22)
    	Me.mnuModif.Text = "Modificar"
    	'
    	'mnuSave
    	'
    	Me.mnuSave.Enabled = false
    	Me.mnuSave.Name = "mnuSave"
    	Me.mnuSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S),System.Windows.Forms.Keys)
    	Me.mnuSave.Size = New System.Drawing.Size(164, 22)
    	Me.mnuSave.Text = "Salvar"
    	'
    	'mnuNew
    	'
    	Me.mnuNew.Name = "mnuNew"
    	Me.mnuNew.ShortcutKeys = System.Windows.Forms.Keys.F4
    	Me.mnuNew.Size = New System.Drawing.Size(164, 22)
    	Me.mnuNew.Text = "Nou"
    	'
    	'mnuDel
    	'
    	Me.mnuDel.Enabled = false
    	Me.mnuDel.Name = "mnuDel"
    	Me.mnuDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Delete),System.Windows.Forms.Keys)
    	Me.mnuDel.Size = New System.Drawing.Size(164, 22)
    	Me.mnuDel.Text = "Borrar"
    	'
    	'ToolStripSeparator4
    	'
    	Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
    	Me.ToolStripSeparator4.Size = New System.Drawing.Size(161, 6)
    	'
    	'mnuBuscar
    	'
    	Me.mnuBuscar.Name = "mnuBuscar"
    	Me.mnuBuscar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F),System.Windows.Forms.Keys)
    	Me.mnuBuscar.Size = New System.Drawing.Size(164, 22)
    	Me.mnuBuscar.Text = "Buscar"
    	'
    	'mnuRefresh
    	'
    	Me.mnuRefresh.Name = "mnuRefresh"
    	Me.mnuRefresh.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R),System.Windows.Forms.Keys)
    	Me.mnuRefresh.Size = New System.Drawing.Size(164, 22)
    	Me.mnuRefresh.Text = "Refrescar"
    	'
    	'KjToolStripMenuItem
    	'
    	Me.KjToolStripMenuItem.Name = "KjToolStripMenuItem"
    	Me.KjToolStripMenuItem.Size = New System.Drawing.Size(161, 6)
    	'
    	'ToolStripMenuItem1
    	'
    	Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_Help})
    	Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
    	Me.ToolStripMenuItem1.Size = New System.Drawing.Size(50, 20)
    	Me.ToolStripMenuItem1.Text = "Ajuda"
    	'
    	'mnu_Help
    	'
    	Me.mnu_Help.Image = CType(resources.GetObject("mnu_Help.Image"),System.Drawing.Image)
    	Me.mnu_Help.Name = "mnu_Help"
    	Me.mnu_Help.ShortcutKeys = System.Windows.Forms.Keys.F1
    	Me.mnu_Help.Size = New System.Drawing.Size(174, 22)
    	Me.mnu_Help.Text = "Manual OnLine"
    	'
    	'lbInfoProgs
    	'
    	Me.lbInfoProgs.AutoSize = true
    	Me.lbInfoProgs.ForeColor = System.Drawing.SystemColors.ActiveCaption
    	Me.lbInfoProgs.Location = New System.Drawing.Point(413, 127)
    	Me.lbInfoProgs.Name = "lbInfoProgs"
    	Me.lbInfoProgs.Size = New System.Drawing.Size(180, 13)
    	Me.lbInfoProgs.TabIndex = 123
    	Me.lbInfoProgs.Text = "Referent a les sessions del programa"
    	Me.lbInfoProgs.Visible = false
    	'
    	'frmMantBKPAudio
    	'
    	Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    	Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    	Me.CancelButton = Me.cmdExit
    	Me.ClientSize = New System.Drawing.Size(594, 421)
    	Me.Controls.Add(Me.lbInfoProgs)
    	Me.Controls.Add(Me.ToolStrip1)
    	Me.Controls.Add(Me.MenuStrip1)
    	Me.Controls.Add(Me.TabControl1)
    	Me.Controls.Add(Me.chkSaved)
    	Me.Controls.Add(Me.ComboTipFitx)
    	Me.Controls.Add(Me.Label3)
    	Me.Controls.Add(Me.lbNou)
    	Me.Controls.Add(Me.txtNom)
    	Me.Controls.Add(Me.Label2)
    	Me.Controls.Add(Me.Label1)
    	Me.Controls.Add(Me.lbID)
    	Me.Controls.Add(Me.picLock)
    	Me.Controls.Add(Me.picUnLock)
    	Me.Controls.Add(Me.cmdExit)
    	Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    	Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
    	Me.MaximizeBox = false
    	Me.MinimumSize = New System.Drawing.Size(600, 450)
    	Me.Name = "frmMantBKPAudio"
    	Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    	Me.Text = "Manteniment dels Backups"
    	CType(Me.picLock,System.ComponentModel.ISupportInitialize).EndInit
    	CType(Me.picUnLock,System.ComponentModel.ISupportInitialize).EndInit
    	Me.ToolStrip1.ResumeLayout(false)
    	Me.ToolStrip1.PerformLayout
    	Me.TabPageSave.ResumeLayout(false)
    	Me.PanelSave.ResumeLayout(false)
    	Me.PanelSave.PerformLayout
    	Me.TabPage1.ResumeLayout(false)
    	CType(Me.gridDades,System.ComponentModel.ISupportInitialize).EndInit
    	Me.TabControl1.ResumeLayout(false)
    	Me.MenuStrip1.ResumeLayout(false)
    	Me.MenuStrip1.PerformLayout
    	Me.ResumeLayout(false)
    	Me.PerformLayout
    End Sub
    Friend WithEvents cmdSortir As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents lbNou As System.Windows.Forms.Label
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbID As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdPrevi As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents picLock As System.Windows.Forms.PictureBox
    Friend WithEvents cmdPrimer As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdUltim As System.Windows.Forms.ToolStripButton
    Friend WithEvents lbPosition As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmdSeguent As System.Windows.Forms.ToolStripButton
    Friend WithEvents picUnLock As System.Windows.Forms.PictureBox
    Friend WithEvents cmdBloqueix As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdBorrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdSalvar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdNou As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents lbRecCount As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboTipFitx As System.Windows.Forms.ComboBox
    Friend WithEvents chkSaved As System.Windows.Forms.CheckBox
    Friend WithEvents TabPageSave As System.Windows.Forms.TabPage
    Friend WithEvents PanelSave As System.Windows.Forms.Panel
    Friend WithEvents lstFitxers As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lbTamany As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbNFitxers As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmdSalvarFitxers As System.Windows.Forms.Button
    Friend WithEvents cmdAllTrack As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmdPath As System.Windows.Forms.Button
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents gridDades As System.Windows.Forms.DataGridView
    Friend WithEvents ProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ProgarmaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EdicióToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuModif As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuBuscar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRefresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KjToolStripMenuItem As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents optionBuscar As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents PerIDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PerNomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QualsevolToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtBuscar As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents lbInfoProgs As System.Windows.Forms.Label
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents ColumnID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnNom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnCBarres As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnTipus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnSaved As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnu_Help As System.Windows.Forms.ToolStripMenuItem
End Class
