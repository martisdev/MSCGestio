<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantSubj
    Inherits System.Windows.Forms.Form

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
    	Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMantSubj))
    	Me.QualsevolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    	Me.PerNomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    	Me.cmdExit = New System.Windows.Forms.Button()
    	Me.txtBuscar = New System.Windows.Forms.ToolStripTextBox()
    	Me.cmdSortir = New System.Windows.Forms.ToolStripButton()
    	Me.cmdRefrescar = New System.Windows.Forms.ToolStripButton()
    	Me.PerIDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    	Me.OptionBuscar = New System.Windows.Forms.ToolStripSplitButton()
    	Me.lbUltim = New System.Windows.Forms.Label()
    	Me.gridDades = New System.Windows.Forms.DataGridView()
    	Me.ColumnID = New System.Windows.Forms.DataGridViewTextBoxColumn()
    	Me.ColumnNom = New System.Windows.Forms.DataGridViewTextBoxColumn()
    	Me.lbVaris = New System.Windows.Forms.Label()
    	Me.txtNom = New System.Windows.Forms.TextBox()
    	Me.Label2 = New System.Windows.Forms.Label()
    	Me.Label1 = New System.Windows.Forms.Label()
    	Me.lbID = New System.Windows.Forms.Label()
    	Me.picUnLock = New System.Windows.Forms.PictureBox()
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
    	Me.lbNou = New System.Windows.Forms.Label()
    	Me.picLock = New System.Windows.Forms.PictureBox()
    	Me.TabControlMesInfo = New System.Windows.Forms.TabControl()
    	Me.TabPage1 = New System.Windows.Forms.TabPage()
    	Me.TabPage3 = New System.Windows.Forms.TabPage()
    	Me.DataGridViewTemes = New System.Windows.Forms.DataGridView()
    	Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    	Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    	Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
    	Me.ProgarmaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    	Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
    	Me.EdicióToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    	Me.mnuModif = New System.Windows.Forms.ToolStripMenuItem()
    	Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
    	Me.mnuNew = New System.Windows.Forms.ToolStripMenuItem()
    	Me.mnuDel = New System.Windows.Forms.ToolStripMenuItem()
    	Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
    	Me.mnuRefresh = New System.Windows.Forms.ToolStripMenuItem()
    	Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
    	Me.mnu_Help = New System.Windows.Forms.ToolStripMenuItem()
    	CType(Me.gridDades,System.ComponentModel.ISupportInitialize).BeginInit
    	CType(Me.picUnLock,System.ComponentModel.ISupportInitialize).BeginInit
    	Me.ToolStrip1.SuspendLayout
    	CType(Me.picLock,System.ComponentModel.ISupportInitialize).BeginInit
    	Me.TabControlMesInfo.SuspendLayout
    	Me.TabPage1.SuspendLayout
    	Me.TabPage3.SuspendLayout
    	CType(Me.DataGridViewTemes,System.ComponentModel.ISupportInitialize).BeginInit
    	Me.MenuStrip1.SuspendLayout
    	Me.SuspendLayout
    	'
    	'QualsevolToolStripMenuItem
    	'
    	Me.QualsevolToolStripMenuItem.Checked = true
    	Me.QualsevolToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
    	Me.QualsevolToolStripMenuItem.Name = "QualsevolToolStripMenuItem"
    	Me.QualsevolToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
    	Me.QualsevolToolStripMenuItem.Tag = "0"
    	Me.QualsevolToolStripMenuItem.Text = "Qualsevol"
    	'
    	'PerNomToolStripMenuItem
    	'
    	Me.PerNomToolStripMenuItem.Name = "PerNomToolStripMenuItem"
    	Me.PerNomToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
    	Me.PerNomToolStripMenuItem.Tag = "1"
    	Me.PerNomToolStripMenuItem.Text = "Per Nom"
    	'
    	'cmdExit
    	'
    	Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
    	Me.cmdExit.Location = New System.Drawing.Point(-13, 22)
    	Me.cmdExit.Name = "cmdExit"
    	Me.cmdExit.Size = New System.Drawing.Size(34, 11)
    	Me.cmdExit.TabIndex = 94
    	Me.cmdExit.Text = "Button1"
    	Me.cmdExit.UseVisualStyleBackColor = true
    	'
    	'txtBuscar
    	'
    	Me.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    	Me.txtBuscar.Name = "txtBuscar"
    	Me.txtBuscar.Size = New System.Drawing.Size(55, 39)
    	Me.txtBuscar.Text = "Buscar.."
    	'
    	'cmdSortir
    	'
    	Me.cmdSortir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    	Me.cmdSortir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    	Me.cmdSortir.Image = CType(resources.GetObject("cmdSortir.Image"),System.Drawing.Image)
    	Me.cmdSortir.ImageTransparentColor = System.Drawing.Color.Magenta
    	Me.cmdSortir.Name = "cmdSortir"
    	Me.cmdSortir.Size = New System.Drawing.Size(36, 36)
    	Me.cmdSortir.Text = "Sortir"
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
    	'PerIDToolStripMenuItem
    	'
    	Me.PerIDToolStripMenuItem.Name = "PerIDToolStripMenuItem"
    	Me.PerIDToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
    	Me.PerIDToolStripMenuItem.Tag = "0"
    	Me.PerIDToolStripMenuItem.Text = "Per ID"
    	'
    	'OptionBuscar
    	'
    	Me.OptionBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    	Me.OptionBuscar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PerIDToolStripMenuItem, Me.PerNomToolStripMenuItem, Me.QualsevolToolStripMenuItem})
    	Me.OptionBuscar.Image = CType(resources.GetObject("OptionBuscar.Image"),System.Drawing.Image)
    	Me.OptionBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
    	Me.OptionBuscar.Name = "OptionBuscar"
    	Me.OptionBuscar.Size = New System.Drawing.Size(48, 36)
    	Me.OptionBuscar.Text = "Buscar"
    	Me.OptionBuscar.ToolTipText = "Opcions de recerca"
    	'
    	'lbUltim
    	'
    	Me.lbUltim.AutoSize = true
    	Me.lbUltim.BackColor = System.Drawing.Color.Lime
    	Me.lbUltim.Location = New System.Drawing.Point(401, 60)
    	Me.lbUltim.Name = "lbUltim"
    	Me.lbUltim.Size = New System.Drawing.Size(13, 13)
    	Me.lbUltim.TabIndex = 102
    	Me.lbUltim.Text = "0"
    	Me.lbUltim.Visible = false
    	'
    	'gridDades
    	'
    	Me.gridDades.AllowUserToAddRows = false
    	Me.gridDades.AllowUserToDeleteRows = false
    	Me.gridDades.BackgroundColor = System.Drawing.SystemColors.Window
    	Me.gridDades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    	Me.gridDades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnID, Me.ColumnNom})
    	Me.gridDades.Dock = System.Windows.Forms.DockStyle.Fill
    	Me.gridDades.Location = New System.Drawing.Point(3, 3)
    	Me.gridDades.Name = "gridDades"
    	Me.gridDades.ReadOnly = true
    	Me.gridDades.RowHeadersVisible = false
    	Me.gridDades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    	Me.gridDades.ShowEditingIcon = false
    	Me.gridDades.Size = New System.Drawing.Size(503, 179)
    	Me.gridDades.TabIndex = 104
    	'
    	'ColumnID
    	'
    	Me.ColumnID.HeaderText = "ID"
    	Me.ColumnID.Name = "ColumnID"
    	Me.ColumnID.ReadOnly = true
    	'
    	'ColumnNom
    	'
    	Me.ColumnNom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    	Me.ColumnNom.HeaderText = "Nom"
    	Me.ColumnNom.Name = "ColumnNom"
    	Me.ColumnNom.ReadOnly = true
    	'
    	'lbVaris
    	'
    	Me.lbVaris.ForeColor = System.Drawing.Color.Blue
    	Me.lbVaris.Location = New System.Drawing.Point(226, 122)
    	Me.lbVaris.Name = "lbVaris"
    	Me.lbVaris.Size = New System.Drawing.Size(174, 41)
    	Me.lbVaris.TabIndex = 103
    	Me.lbVaris.Text = "Aquest ID ( VARIS) és un comodí, no es pot borrar."
    	Me.lbVaris.Visible = false
    	'
    	'txtNom
    	'
    	Me.txtNom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
    	    	    	Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    	Me.txtNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    	Me.txtNom.Enabled = false
    	Me.txtNom.Location = New System.Drawing.Point(138, 166)
    	Me.txtNom.Name = "txtNom"
    	Me.txtNom.Size = New System.Drawing.Size(312, 20)
    	Me.txtNom.TabIndex = 101
    	'
    	'Label2
    	'
    	Me.Label2.Location = New System.Drawing.Point(47, 171)
    	Me.Label2.Name = "Label2"
    	Me.Label2.Size = New System.Drawing.Size(68, 13)
    	Me.Label2.TabIndex = 100
    	Me.Label2.Text = "Nom:"
    	Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
    	'
    	'Label1
    	'
    	Me.Label1.Location = New System.Drawing.Point(47, 134)
    	Me.Label1.Name = "Label1"
    	Me.Label1.Size = New System.Drawing.Size(68, 13)
    	Me.Label1.TabIndex = 99
    	Me.Label1.Text = "Identificador:"
    	Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
    	'
    	'lbID
    	'
    	Me.lbID.AutoSize = true
    	Me.lbID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.lbID.Location = New System.Drawing.Point(138, 134)
    	Me.lbID.Name = "lbID"
    	Me.lbID.Size = New System.Drawing.Size(14, 13)
    	Me.lbID.TabIndex = 98
    	Me.lbID.Text = "0"
    	'
    	'picUnLock
    	'
    	Me.picUnLock.Image = CType(resources.GetObject("picUnLock.Image"),System.Drawing.Image)
    	Me.picUnLock.Location = New System.Drawing.Point(377, 70)
    	Me.picUnLock.Name = "picUnLock"
    	Me.picUnLock.Size = New System.Drawing.Size(40, 34)
    	Me.picUnLock.TabIndex = 96
    	Me.picUnLock.TabStop = false
    	Me.picUnLock.Visible = false
    	'
    	'ToolStrip1
    	'
    	Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
    	Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdPrimer, Me.cmdPrevi, Me.cmdSeguent, Me.cmdUltim, Me.lbPosition, Me.ToolStripLabel1, Me.lbRecCount, Me.ToolStripSeparator1, Me.cmdNou, Me.cmdBloqueix, Me.cmdBorrar, Me.cmdSalvar, Me.ToolStripSeparator2, Me.cmdRefrescar, Me.cmdSortir, Me.OptionBuscar, Me.txtBuscar})
    	Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
    	Me.ToolStrip1.Name = "ToolStrip1"
    	Me.ToolStrip1.Size = New System.Drawing.Size(592, 39)
    	Me.ToolStrip1.TabIndex = 93
    	Me.ToolStrip1.Text = "ToolStrip1"
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
    	'cmdPrevi
    	'
    	Me.cmdPrevi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    	Me.cmdPrevi.Image = CType(resources.GetObject("cmdPrevi.Image"),System.Drawing.Image)
    	Me.cmdPrevi.ImageTransparentColor = System.Drawing.Color.Magenta
    	Me.cmdPrevi.Name = "cmdPrevi"
    	Me.cmdPrevi.Size = New System.Drawing.Size(36, 36)
    	Me.cmdPrevi.Text = "Anterior"
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
    	'ToolStripLabel1
    	'
    	Me.ToolStripLabel1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.ToolStripLabel1.Name = "ToolStripLabel1"
    	Me.ToolStripLabel1.Size = New System.Drawing.Size(16, 36)
    	Me.ToolStripLabel1.Text = "/"
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
    	'cmdNou
    	'
    	Me.cmdNou.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    	Me.cmdNou.Image = CType(resources.GetObject("cmdNou.Image"),System.Drawing.Image)
    	Me.cmdNou.ImageTransparentColor = System.Drawing.Color.Magenta
    	Me.cmdNou.Name = "cmdNou"
    	Me.cmdNou.Size = New System.Drawing.Size(36, 36)
    	Me.cmdNou.Text = "Nou"
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
    	'ToolStripSeparator2
    	'
    	Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
    	Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
    	'
    	'lbNou
    	'
    	Me.lbNou.AutoSize = true
    	Me.lbNou.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.lbNou.ForeColor = System.Drawing.Color.Red
    	Me.lbNou.Location = New System.Drawing.Point(136, 90)
    	Me.lbNou.Name = "lbNou"
    	Me.lbNou.Size = New System.Drawing.Size(61, 25)
    	Me.lbNou.TabIndex = 97
    	Me.lbNou.Text = "NOU"
    	Me.lbNou.Visible = false
    	'
    	'picLock
    	'
    	Me.picLock.Image = CType(resources.GetObject("picLock.Image"),System.Drawing.Image)
    	Me.picLock.Location = New System.Drawing.Point(332, 71)
    	Me.picLock.Name = "picLock"
    	Me.picLock.Size = New System.Drawing.Size(39, 35)
    	Me.picLock.TabIndex = 95
    	Me.picLock.TabStop = false
    	Me.picLock.Visible = false
    	'
    	'TabControlMesInfo
    	'
    	Me.TabControlMesInfo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
    	    	    	Or System.Windows.Forms.AnchorStyles.Left)  _
    	    	    	Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    	Me.TabControlMesInfo.Controls.Add(Me.TabPage1)
    	Me.TabControlMesInfo.Controls.Add(Me.TabPage3)
    	Me.TabControlMesInfo.Location = New System.Drawing.Point(30, 192)
    	Me.TabControlMesInfo.Name = "TabControlMesInfo"
    	Me.TabControlMesInfo.SelectedIndex = 0
    	Me.TabControlMesInfo.Size = New System.Drawing.Size(517, 211)
    	Me.TabControlMesInfo.TabIndex = 243
    	'
    	'TabPage1
    	'
    	Me.TabPage1.Controls.Add(Me.gridDades)
    	Me.TabPage1.Location = New System.Drawing.Point(4, 22)
    	Me.TabPage1.Name = "TabPage1"
    	Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
    	Me.TabPage1.Size = New System.Drawing.Size(509, 185)
    	Me.TabPage1.TabIndex = 0
    	Me.TabPage1.Text = "LListat Clas. Subjectiva"
    	Me.TabPage1.UseVisualStyleBackColor = true
    	'
    	'TabPage3
    	'
    	Me.TabPage3.Controls.Add(Me.DataGridViewTemes)
    	Me.TabPage3.Location = New System.Drawing.Point(4, 22)
    	Me.TabPage3.Name = "TabPage3"
    	Me.TabPage3.Size = New System.Drawing.Size(509, 185)
    	Me.TabPage3.TabIndex = 2
    	Me.TabPage3.Text = "Cançons d'aquesta classificació"
    	Me.TabPage3.UseVisualStyleBackColor = true
    	'
    	'DataGridViewTemes
    	'
    	Me.DataGridViewTemes.AllowUserToAddRows = false
    	Me.DataGridViewTemes.AllowUserToDeleteRows = false
    	Me.DataGridViewTemes.BackgroundColor = System.Drawing.SystemColors.Window
    	Me.DataGridViewTemes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    	Me.DataGridViewTemes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
    	Me.DataGridViewTemes.Dock = System.Windows.Forms.DockStyle.Fill
    	Me.DataGridViewTemes.Location = New System.Drawing.Point(0, 0)
    	Me.DataGridViewTemes.Name = "DataGridViewTemes"
    	Me.DataGridViewTemes.ReadOnly = true
    	Me.DataGridViewTemes.RowHeadersVisible = false
    	Me.DataGridViewTemes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    	Me.DataGridViewTemes.ShowEditingIcon = false
    	Me.DataGridViewTemes.Size = New System.Drawing.Size(509, 185)
    	Me.DataGridViewTemes.TabIndex = 237
    	'
    	'DataGridViewTextBoxColumn5
    	'
    	Me.DataGridViewTextBoxColumn5.DataPropertyName = "tema_id"
    	Me.DataGridViewTextBoxColumn5.HeaderText = "ID"
    	Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
    	Me.DataGridViewTextBoxColumn5.ReadOnly = true
    	Me.DataGridViewTextBoxColumn5.Visible = false
    	Me.DataGridViewTextBoxColumn5.Width = 50
    	'
    	'DataGridViewTextBoxColumn6
    	'
    	Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    	Me.DataGridViewTextBoxColumn6.DataPropertyName = "tema_titol"
    	Me.DataGridViewTextBoxColumn6.HeaderText = "Nom"
    	Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
    	Me.DataGridViewTextBoxColumn6.ReadOnly = true
    	'
    	'MenuStrip1
    	'
    	Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgarmaToolStripMenuItem, Me.EdicióToolStripMenuItem, Me.ToolStripMenuItem1})
    	Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
    	Me.MenuStrip1.Name = "MenuStrip1"
    	Me.MenuStrip1.Size = New System.Drawing.Size(592, 24)
    	Me.MenuStrip1.TabIndex = 244
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
    	Me.EdicióToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuModif, Me.mnuSave, Me.mnuNew, Me.mnuDel, Me.ToolStripSeparator3, Me.mnuRefresh})
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
    	'ToolStripSeparator3
    	'
    	Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
    	Me.ToolStripSeparator3.Size = New System.Drawing.Size(161, 6)
    	'
    	'mnuRefresh
    	'
    	Me.mnuRefresh.Name = "mnuRefresh"
    	Me.mnuRefresh.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R),System.Windows.Forms.Keys)
    	Me.mnuRefresh.Size = New System.Drawing.Size(164, 22)
    	Me.mnuRefresh.Text = "Refrescar"
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
    	AddHandler Me.mnu_Help.Click, AddressOf Me.Mnu_HelpClick
    	'
    	'frmMantSubj
    	'
    	Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    	Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    	Me.CancelButton = Me.cmdExit
    	Me.ClientSize = New System.Drawing.Size(592, 416)
    	Me.Controls.Add(Me.ToolStrip1)
    	Me.Controls.Add(Me.MenuStrip1)
    	Me.Controls.Add(Me.TabControlMesInfo)
    	Me.Controls.Add(Me.lbUltim)
    	Me.Controls.Add(Me.lbVaris)
    	Me.Controls.Add(Me.txtNom)
    	Me.Controls.Add(Me.Label2)
    	Me.Controls.Add(Me.Label1)
    	Me.Controls.Add(Me.lbID)
    	Me.Controls.Add(Me.picUnLock)
    	Me.Controls.Add(Me.lbNou)
    	Me.Controls.Add(Me.picLock)
    	Me.Controls.Add(Me.cmdExit)
    	Me.MinimumSize = New System.Drawing.Size(600, 450)
    	Me.Name = "frmMantSubj"
    	Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    	Me.Text = "frmMantSubj"
    	CType(Me.gridDades,System.ComponentModel.ISupportInitialize).EndInit
    	CType(Me.picUnLock,System.ComponentModel.ISupportInitialize).EndInit
    	Me.ToolStrip1.ResumeLayout(false)
    	Me.ToolStrip1.PerformLayout
    	CType(Me.picLock,System.ComponentModel.ISupportInitialize).EndInit
    	Me.TabControlMesInfo.ResumeLayout(false)
    	Me.TabPage1.ResumeLayout(false)
    	Me.TabPage3.ResumeLayout(false)
    	CType(Me.DataGridViewTemes,System.ComponentModel.ISupportInitialize).EndInit
    	Me.MenuStrip1.ResumeLayout(false)
    	Me.MenuStrip1.PerformLayout
    	Me.ResumeLayout(false)
    	Me.PerformLayout
    End Sub
    Public mnu_Help As System.Windows.Forms.ToolStripMenuItem
    Friend ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QualsevolToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PerNomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents txtBuscar As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents cmdSortir As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents PerIDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionBuscar As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents lbUltim As System.Windows.Forms.Label
    Friend WithEvents gridDades As System.Windows.Forms.DataGridView
    Friend WithEvents ColumnID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnNom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbVaris As System.Windows.Forms.Label
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbID As System.Windows.Forms.Label
    Friend WithEvents picUnLock As System.Windows.Forms.PictureBox
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
    Friend WithEvents lbNou As System.Windows.Forms.Label
    Friend WithEvents picLock As System.Windows.Forms.PictureBox
    Friend WithEvents TabControlMesInfo As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridViewTemes As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ProgarmaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EdicióToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuModif As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuRefresh As System.Windows.Forms.ToolStripMenuItem
End Class
