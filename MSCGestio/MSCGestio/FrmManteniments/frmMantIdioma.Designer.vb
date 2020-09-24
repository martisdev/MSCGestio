<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantIdioma
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMantIdioma))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lbPosition = New System.Windows.Forms.ToolStripLabel()
        Me.cmdUltim = New System.Windows.Forms.ToolStripButton()
        Me.lbRecCount = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cmdPrimer = New System.Windows.Forms.ToolStripButton()
        Me.txtBuscar = New System.Windows.Forms.ToolStripTextBox()
        Me.cmdSeguent = New System.Windows.Forms.ToolStripButton()
        Me.cmdPrevi = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdSalvar = New System.Windows.Forms.ToolStripButton()
        Me.cmdSortir = New System.Windows.Forms.ToolStripButton()
        Me.cmdRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.cmdNou = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdBorrar = New System.Windows.Forms.ToolStripButton()
        Me.cmdBloqueix = New System.Windows.Forms.ToolStripButton()
        Me.PerNomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerIDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QualsevolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gridDades = New MetroFramework.Controls.MetroGrid()
        Me.ColumnID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnNom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnNomNadiu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column369_1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column369_2_369_5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column369_3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnVisible = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.picLock = New System.Windows.Forms.PictureBox()
        Me.lbUltim = New System.Windows.Forms.Label()
        Me.lbNou = New System.Windows.Forms.Label()
        Me.lbID = New System.Windows.Forms.Label()
        Me.picUnLock = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.OptionBuscar = New System.Windows.Forms.ToolStripSplitButton()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbVaris = New System.Windows.Forms.Label()
        Me.txtNomInter = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNomNadiu = New System.Windows.Forms.TextBox()
        Me.chkVisible = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt369_1 = New System.Windows.Forms.TextBox()
        Me.txt369_2_369_5 = New System.Windows.Forms.TextBox()
        Me.txt369_3 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.gridDades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUnLock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbPosition
        '
        Me.lbPosition.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPosition.Name = "lbPosition"
        Me.lbPosition.Size = New System.Drawing.Size(16, 36)
        Me.lbPosition.Text = "0"
        Me.lbPosition.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'lbRecCount
        '
        Me.lbRecCount.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRecCount.Name = "lbRecCount"
        Me.lbRecCount.Size = New System.Drawing.Size(16, 36)
        Me.lbRecCount.Text = "0"
        Me.lbRecCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(16, 36)
        Me.ToolStripLabel1.Text = "/"
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
        'txtBuscar
        '
        Me.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(64, 39)
        Me.txtBuscar.Text = "Buscar.."
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
        'cmdPrevi
        '
        Me.cmdPrevi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdPrevi.Image = CType(resources.GetObject("cmdPrevi.Image"), System.Drawing.Image)
        Me.cmdPrevi.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPrevi.Name = "cmdPrevi"
        Me.cmdPrevi.Size = New System.Drawing.Size(36, 36)
        Me.cmdPrevi.Text = "Anterior"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
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
        'cmdRefrescar
        '
        Me.cmdRefrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdRefrescar.Image = CType(resources.GetObject("cmdRefrescar.Image"), System.Drawing.Image)
        Me.cmdRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdRefrescar.Name = "cmdRefrescar"
        Me.cmdRefrescar.Size = New System.Drawing.Size(36, 36)
        Me.cmdRefrescar.Text = "Refrescar"
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
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
        'PerNomToolStripMenuItem
        '
        Me.PerNomToolStripMenuItem.Name = "PerNomToolStripMenuItem"
        Me.PerNomToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.PerNomToolStripMenuItem.Tag = "1"
        Me.PerNomToolStripMenuItem.Text = "Per Nom"
        '
        'PerIDToolStripMenuItem
        '
        Me.PerIDToolStripMenuItem.Name = "PerIDToolStripMenuItem"
        Me.PerIDToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.PerIDToolStripMenuItem.Tag = "0"
        Me.PerIDToolStripMenuItem.Text = "Per ID"
        '
        'QualsevolToolStripMenuItem
        '
        Me.QualsevolToolStripMenuItem.Checked = True
        Me.QualsevolToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.QualsevolToolStripMenuItem.Name = "QualsevolToolStripMenuItem"
        Me.QualsevolToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.QualsevolToolStripMenuItem.Tag = "0"
        Me.QualsevolToolStripMenuItem.Text = "Qualsevol"
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
        Me.gridDades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnID, Me.ColumnNom, Me.ColumnNomNadiu, Me.Column369_1, Me.Column369_2_369_5, Me.Column369_3, Me.ColumnVisible})
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
        Me.gridDades.Location = New System.Drawing.Point(23, 262)
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
        Me.gridDades.Size = New System.Drawing.Size(650, 181)
        Me.gridDades.TabIndex = 7
        '
        'ColumnID
        '
        Me.ColumnID.DataPropertyName = "id_lang"
        Me.ColumnID.HeaderText = "ID"
        Me.ColumnID.Name = "ColumnID"
        Me.ColumnID.ReadOnly = True
        Me.ColumnID.Width = 30
        '
        'ColumnNom
        '
        Me.ColumnNom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnNom.DataPropertyName = "nom_internacional"
        Me.ColumnNom.HeaderText = "Nom Internacional"
        Me.ColumnNom.Name = "ColumnNom"
        Me.ColumnNom.ReadOnly = True
        '
        'ColumnNomNadiu
        '
        Me.ColumnNomNadiu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnNomNadiu.DataPropertyName = "nom_nadiu"
        Me.ColumnNomNadiu.HeaderText = "Nom Nadiu"
        Me.ColumnNomNadiu.Name = "ColumnNomNadiu"
        Me.ColumnNomNadiu.ReadOnly = True
        '
        'Column369_1
        '
        Me.Column369_1.DataPropertyName = "lang_639-1"
        Me.Column369_1.HeaderText = "369_1"
        Me.Column369_1.Name = "Column369_1"
        Me.Column369_1.ReadOnly = True
        Me.Column369_1.Visible = False
        '
        'Column369_2_369_5
        '
        Me.Column369_2_369_5.DataPropertyName = "lang_639-2/639-5"
        Me.Column369_2_369_5.HeaderText = "369_2_369_5"
        Me.Column369_2_369_5.Name = "Column369_2_369_5"
        Me.Column369_2_369_5.ReadOnly = True
        Me.Column369_2_369_5.Visible = False
        '
        'Column369_3
        '
        Me.Column369_3.DataPropertyName = "lang_639-3"
        Me.Column369_3.HeaderText = "369_3"
        Me.Column369_3.Name = "Column369_3"
        Me.Column369_3.ReadOnly = True
        Me.Column369_3.Visible = False
        '
        'ColumnVisible
        '
        Me.ColumnVisible.DataPropertyName = "lang_visible"
        Me.ColumnVisible.HeaderText = "Visible"
        Me.ColumnVisible.Name = "ColumnVisible"
        Me.ColumnVisible.ReadOnly = True
        Me.ColumnVisible.Width = 50
        '
        'picLock
        '
        Me.picLock.Image = CType(resources.GetObject("picLock.Image"), System.Drawing.Image)
        Me.picLock.Location = New System.Drawing.Point(577, 88)
        Me.picLock.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picLock.Name = "picLock"
        Me.picLock.Size = New System.Drawing.Size(45, 46)
        Me.picLock.TabIndex = 131
        Me.picLock.TabStop = False
        Me.picLock.Visible = False
        '
        'lbUltim
        '
        Me.lbUltim.AutoSize = True
        Me.lbUltim.BackColor = System.Drawing.Color.Lime
        Me.lbUltim.Location = New System.Drawing.Point(658, 88)
        Me.lbUltim.Name = "lbUltim"
        Me.lbUltim.Size = New System.Drawing.Size(15, 17)
        Me.lbUltim.TabIndex = 138
        Me.lbUltim.Text = "0"
        Me.lbUltim.Visible = False
        '
        'lbNou
        '
        Me.lbNou.AutoSize = True
        Me.lbNou.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNou.ForeColor = System.Drawing.Color.Red
        Me.lbNou.Location = New System.Drawing.Point(141, 86)
        Me.lbNou.Name = "lbNou"
        Me.lbNou.Size = New System.Drawing.Size(61, 25)
        Me.lbNou.TabIndex = 133
        Me.lbNou.Text = "NOU"
        Me.lbNou.Visible = False
        '
        'lbID
        '
        Me.lbID.AutoSize = True
        Me.lbID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbID.Location = New System.Drawing.Point(143, 129)
        Me.lbID.Name = "lbID"
        Me.lbID.Size = New System.Drawing.Size(14, 13)
        Me.lbID.TabIndex = 134
        Me.lbID.Text = "0"
        '
        'picUnLock
        '
        Me.picUnLock.Image = CType(resources.GetObject("picUnLock.Image"), System.Drawing.Image)
        Me.picUnLock.Location = New System.Drawing.Point(630, 86)
        Me.picUnLock.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picUnLock.Name = "picUnLock"
        Me.picUnLock.Size = New System.Drawing.Size(47, 44)
        Me.picUnLock.TabIndex = 132
        Me.picUnLock.TabStop = False
        Me.picUnLock.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdPrimer, Me.cmdPrevi, Me.cmdSeguent, Me.cmdUltim, Me.lbPosition, Me.ToolStripLabel1, Me.lbRecCount, Me.ToolStripSeparator1, Me.cmdNou, Me.cmdBloqueix, Me.cmdBorrar, Me.cmdSalvar, Me.ToolStripSeparator2, Me.cmdRefrescar, Me.cmdSortir, Me.OptionBuscar, Me.txtBuscar})
        Me.ToolStrip1.Location = New System.Drawing.Point(23, 78)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(654, 39)
        Me.ToolStrip1.TabIndex = 129
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'OptionBuscar
        '
        Me.OptionBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OptionBuscar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PerIDToolStripMenuItem, Me.PerNomToolStripMenuItem, Me.QualsevolToolStripMenuItem})
        Me.OptionBuscar.Image = CType(resources.GetObject("OptionBuscar.Image"), System.Drawing.Image)
        Me.OptionBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OptionBuscar.Name = "OptionBuscar"
        Me.OptionBuscar.Size = New System.Drawing.Size(48, 36)
        Me.OptionBuscar.Text = "Buscar"
        Me.OptionBuscar.ToolTipText = "Opcions de recerca"
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Location = New System.Drawing.Point(46, 85)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(24, 14)
        Me.cmdExit.TabIndex = 130
        Me.cmdExit.Text = "Button1"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(34, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 17)
        Me.Label1.TabIndex = 135
        Me.Label1.Text = "Identificador:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbVaris
        '
        Me.lbVaris.ForeColor = System.Drawing.Color.Blue
        Me.lbVaris.Location = New System.Drawing.Point(190, 125)
        Me.lbVaris.Name = "lbVaris"
        Me.lbVaris.Size = New System.Drawing.Size(454, 21)
        Me.lbVaris.TabIndex = 139
        Me.lbVaris.Text = "Aquest ID ( VARIS) és un comodí, no es pot borrar."
        Me.lbVaris.Visible = False
        '
        'txtNomInter
        '
        Me.txtNomInter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNomInter.Enabled = False
        Me.txtNomInter.Location = New System.Drawing.Point(143, 158)
        Me.txtNomInter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNomInter.Name = "txtNomInter"
        Me.txtNomInter.Size = New System.Drawing.Size(249, 25)
        Me.txtNomInter.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(34, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 17)
        Me.Label2.TabIndex = 136
        Me.Label2.Text = "Nom Interacional:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgarmaToolStripMenuItem, Me.EdicióToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(448, 30)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(229, 26)
        Me.MenuStrip1.TabIndex = 141
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
        Me.EdicióToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuModif, Me.mnuSave, Me.mnuNew, Me.mnuDel, Me.ToolStripSeparator3, Me.mnuRefresh})
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
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(161, 6)
        '
        'mnuRefresh
        '
        Me.mnuRefresh.Image = CType(resources.GetObject("mnuRefresh.Image"), System.Drawing.Image)
        Me.mnuRefresh.Name = "mnuRefresh"
        Me.mnuRefresh.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.mnuRefresh.Size = New System.Drawing.Size(164, 22)
        Me.mnuRefresh.Text = "Refrescar"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_Help})
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(66, 20)
        Me.ToolStripMenuItem1.Text = "Ajuda"
        '
        'mnu_Help
        '
        Me.mnu_Help.Image = CType(resources.GetObject("mnu_Help.Image"), System.Drawing.Image)
        Me.mnu_Help.Name = "mnu_Help"
        Me.mnu_Help.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.mnu_Help.Size = New System.Drawing.Size(174, 22)
        Me.mnu_Help.Text = "Manual OnLine"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(34, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 17)
        Me.Label3.TabIndex = 142
        Me.Label3.Text = "Nom nadiu:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtNomNadiu
        '
        Me.txtNomNadiu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNomNadiu.Enabled = False
        Me.txtNomNadiu.Location = New System.Drawing.Point(143, 196)
        Me.txtNomNadiu.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNomNadiu.Name = "txtNomNadiu"
        Me.txtNomNadiu.Size = New System.Drawing.Size(249, 25)
        Me.txtNomNadiu.TabIndex = 2
        '
        'chkVisible
        '
        Me.chkVisible.AutoSize = True
        Me.chkVisible.Location = New System.Drawing.Point(143, 233)
        Me.chkVisible.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkVisible.Name = "chkVisible"
        Me.chkVisible.Size = New System.Drawing.Size(65, 21)
        Me.chkVisible.TabIndex = 3
        Me.chkVisible.Text = "Visible"
        Me.chkVisible.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(478, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 17)
        Me.Label4.TabIndex = 145
        Me.Label4.Text = "369-1:"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(441, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 17)
        Me.Label5.TabIndex = 146
        Me.Label5.Text = "369-2/369-5:"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(478, 230)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 17)
        Me.Label6.TabIndex = 147
        Me.Label6.Text = "369-3:"
        '
        'txt369_1
        '
        Me.txt369_1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt369_1.Enabled = False
        Me.txt369_1.Location = New System.Drawing.Point(528, 154)
        Me.txt369_1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt369_1.Name = "txt369_1"
        Me.txt369_1.Size = New System.Drawing.Size(116, 25)
        Me.txt369_1.TabIndex = 4
        '
        'txt369_2_369_5
        '
        Me.txt369_2_369_5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt369_2_369_5.Enabled = False
        Me.txt369_2_369_5.Location = New System.Drawing.Point(528, 189)
        Me.txt369_2_369_5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt369_2_369_5.Name = "txt369_2_369_5"
        Me.txt369_2_369_5.Size = New System.Drawing.Size(116, 25)
        Me.txt369_2_369_5.TabIndex = 5
        '
        'txt369_3
        '
        Me.txt369_3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt369_3.Enabled = False
        Me.txt369_3.Location = New System.Drawing.Point(528, 224)
        Me.txt369_3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt369_3.Name = "txt369_3"
        Me.txt369_3.Size = New System.Drawing.Size(116, 25)
        Me.txt369_3.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(494, 447)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(179, 17)
        Me.Label7.TabIndex = 151
        Me.Label7.Text = "Codificació segons ISO 369-1"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(20, 447)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(223, 17)
        Me.Label8.TabIndex = 152
        Me.Label8.Text = "fer visible només les que estan en ús"
        '
        'frmMantIdioma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(700, 481)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt369_3)
        Me.Controls.Add(Me.txt369_2_369_5)
        Me.Controls.Add(Me.txt369_1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.chkVisible)
        Me.Controls.Add(Me.txtNomNadiu)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.gridDades)
        Me.Controls.Add(Me.picLock)
        Me.Controls.Add(Me.lbUltim)
        Me.Controls.Add(Me.lbNou)
        Me.Controls.Add(Me.lbID)
        Me.Controls.Add(Me.picUnLock)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbVaris)
        Me.Controls.Add(Me.txtNomInter)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMantIdioma"
        Me.Padding = New System.Windows.Forms.Padding(23, 78, 23, 26)
        Me.Text = "formMantIdioma"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        CType(Me.gridDades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUnLock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbPosition As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmdUltim As System.Windows.Forms.ToolStripButton
    Friend WithEvents lbRecCount As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmdPrimer As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtBuscar As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents cmdSeguent As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdPrevi As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdSalvar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdSortir As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdNou As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdBorrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdBloqueix As System.Windows.Forms.ToolStripButton
    Friend WithEvents PerNomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PerIDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QualsevolToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents picLock As System.Windows.Forms.PictureBox
    Friend WithEvents lbUltim As System.Windows.Forms.Label
    Friend WithEvents lbNou As System.Windows.Forms.Label
    Friend WithEvents lbID As System.Windows.Forms.Label
    Friend WithEvents picUnLock As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents OptionBuscar As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbVaris As System.Windows.Forms.Label
    Friend WithEvents txtNomInter As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
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
    Friend WithEvents ColumnID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnNom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnNomNadiu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column369_1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column369_2_369_5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column369_3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnVisible As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNomNadiu As System.Windows.Forms.TextBox
    Friend WithEvents chkVisible As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt369_1 As System.Windows.Forms.TextBox
    Friend WithEvents txt369_2_369_5 As System.Windows.Forms.TextBox
    Friend WithEvents txt369_3 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnu_Help As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gridDades As MetroFramework.Controls.MetroGrid
End Class
