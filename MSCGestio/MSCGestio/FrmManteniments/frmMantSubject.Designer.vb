﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMantSubject
    Inherits MetroFramework.Forms.MetroForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMantSubject))
        Me.TabControlMesInfo = New MetroFramework.Controls.MetroTabControl()
        Me.TabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.gridDades = New MetroFramework.Controls.MetroGrid()
        Me.ColumnID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnNom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.DataGridViewTemes = New MetroFramework.Controls.MetroGrid()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.picLock = New System.Windows.Forms.PictureBox()
        Me.lbUltim = New System.Windows.Forms.Label()
        Me.lbVaris = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbID = New System.Windows.Forms.Label()
        Me.cmdExit = New System.Windows.Forms.Button()
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
        Me.cmdRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.OptionBuscar = New System.Windows.Forms.ToolStripSplitButton()
        Me.PerIDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerNomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QualsevolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdSortir = New System.Windows.Forms.ToolStripButton()
        Me.txtBuscar = New System.Windows.Forms.ToolStripTextBox()
        Me.lbNou = New System.Windows.Forms.ToolStripLabel()
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
        Me.TabControlMesInfo.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.gridDades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridViewTemes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUnLock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControlMesInfo
        '
        Me.TabControlMesInfo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControlMesInfo.Controls.Add(Me.TabPage1)
        Me.TabControlMesInfo.Controls.Add(Me.TabPage2)
        Me.TabControlMesInfo.Location = New System.Drawing.Point(23, 207)
        Me.TabControlMesInfo.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.TabControlMesInfo.Name = "TabControlMesInfo"
        Me.TabControlMesInfo.SelectedIndex = 0
        Me.TabControlMesInfo.Size = New System.Drawing.Size(654, 249)
        Me.TabControlMesInfo.TabIndex = 252
        Me.TabControlMesInfo.UseSelectable = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.gridDades)
        Me.TabPage1.HorizontalScrollbarBarColor = True
        Me.TabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.TabPage1.HorizontalScrollbarSize = 4
        Me.TabPage1.Location = New System.Drawing.Point(4, 38)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.TabPage1.Size = New System.Drawing.Size(646, 207)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "LListat Clas. Subjectiva"
        Me.TabPage1.UseVisualStyleBackColor = True
        Me.TabPage1.VerticalScrollbarBarColor = True
        Me.TabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.TabPage1.VerticalScrollbarSize = 6
        '
        'gridDades
        '
        Me.gridDades.AllowUserToAddRows = False
        Me.gridDades.AllowUserToDeleteRows = False
        Me.gridDades.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.gridDades.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
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
        Me.gridDades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnID, Me.ColumnNom})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridDades.DefaultCellStyle = DataGridViewCellStyle3
        Me.gridDades.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridDades.EnableHeadersVisualStyles = False
        Me.gridDades.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.gridDades.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gridDades.Location = New System.Drawing.Point(3, 5)
        Me.gridDades.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
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
        Me.gridDades.Size = New System.Drawing.Size(640, 197)
        Me.gridDades.TabIndex = 128
        '
        'ColumnID
        '
        Me.ColumnID.HeaderText = "ID"
        Me.ColumnID.Name = "ColumnID"
        Me.ColumnID.ReadOnly = True
        '
        'ColumnNom
        '
        Me.ColumnNom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnNom.HeaderText = "Nom"
        Me.ColumnNom.Name = "ColumnNom"
        Me.ColumnNom.ReadOnly = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGridViewTemes)
        Me.TabPage2.HorizontalScrollbarBarColor = True
        Me.TabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.TabPage2.HorizontalScrollbarSize = 4
        Me.TabPage2.Location = New System.Drawing.Point(4, 38)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.TabPage2.Size = New System.Drawing.Size(703, 130)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Cançons d'aquesta classificació"
        Me.TabPage2.UseVisualStyleBackColor = True
        Me.TabPage2.VerticalScrollbarBarColor = True
        Me.TabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.TabPage2.VerticalScrollbarSize = 6
        '
        'DataGridViewTemes
        '
        Me.DataGridViewTemes.AllowUserToAddRows = False
        Me.DataGridViewTemes.AllowUserToDeleteRows = False
        Me.DataGridViewTemes.AllowUserToResizeRows = False
        Me.DataGridViewTemes.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridViewTemes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridViewTemes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridViewTemes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTemes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTemes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewTemes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTemes.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTemes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewTemes.EnableHeadersVisualStyles = False
        Me.DataGridViewTemes.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.DataGridViewTemes.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridViewTemes.Location = New System.Drawing.Point(3, 5)
        Me.DataGridViewTemes.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.DataGridViewTemes.Name = "DataGridViewTemes"
        Me.DataGridViewTemes.ReadOnly = True
        Me.DataGridViewTemes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTemes.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTemes.RowHeadersVisible = False
        Me.DataGridViewTemes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridViewTemes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewTemes.ShowEditingIcon = False
        Me.DataGridViewTemes.Size = New System.Drawing.Size(697, 120)
        Me.DataGridViewTemes.TabIndex = 236
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "disc_id"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        Me.DataGridViewTextBoxColumn3.Width = 50
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "disc_nom"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Nom"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'picLock
        '
        Me.picLock.Image = CType(resources.GetObject("picLock.Image"), System.Drawing.Image)
        Me.picLock.Location = New System.Drawing.Point(662, 124)
        Me.picLock.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.picLock.Name = "picLock"
        Me.picLock.Size = New System.Drawing.Size(52, 60)
        Me.picLock.TabIndex = 244
        Me.picLock.TabStop = False
        Me.picLock.Visible = False
        '
        'lbUltim
        '
        Me.lbUltim.AutoSize = True
        Me.lbUltim.BackColor = System.Drawing.Color.Lime
        Me.lbUltim.Location = New System.Drawing.Point(629, 128)
        Me.lbUltim.Name = "lbUltim"
        Me.lbUltim.Size = New System.Drawing.Size(15, 17)
        Me.lbUltim.TabIndex = 250
        Me.lbUltim.Text = "0"
        Me.lbUltim.Visible = False
        '
        'lbVaris
        '
        Me.lbVaris.ForeColor = System.Drawing.Color.Blue
        Me.lbVaris.Location = New System.Drawing.Point(310, 125)
        Me.lbVaris.Name = "lbVaris"
        Me.lbVaris.Size = New System.Drawing.Size(237, 42)
        Me.lbVaris.TabIndex = 251
        Me.lbVaris.Text = "Aquest ID ( VARIS) és un comodí, no es pot borrar."
        Me.lbVaris.Visible = False
        '
        'txtNom
        '
        Me.txtNom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNom.Enabled = False
        Me.txtNom.Location = New System.Drawing.Point(189, 172)
        Me.txtNom.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(281, 25)
        Me.txtNom.TabIndex = 249
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(28, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 22)
        Me.Label2.TabIndex = 248
        Me.Label2.Text = "Nom:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(25, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 22)
        Me.Label1.TabIndex = 247
        Me.Label1.Text = "Identificador:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbID
        '
        Me.lbID.AutoSize = True
        Me.lbID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbID.Location = New System.Drawing.Point(186, 128)
        Me.lbID.Name = "lbID"
        Me.lbID.Size = New System.Drawing.Size(14, 13)
        Me.lbID.TabIndex = 246
        Me.lbID.Text = "0"
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Location = New System.Drawing.Point(38, 98)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(27, 18)
        Me.cmdExit.TabIndex = 243
        Me.cmdExit.Text = "Button1"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'picUnLock
        '
        Me.picUnLock.Image = CType(resources.GetObject("picUnLock.Image"), System.Drawing.Image)
        Me.picUnLock.Location = New System.Drawing.Point(723, 122)
        Me.picUnLock.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.picUnLock.Name = "picUnLock"
        Me.picUnLock.Size = New System.Drawing.Size(55, 58)
        Me.picUnLock.TabIndex = 245
        Me.picUnLock.TabStop = False
        Me.picUnLock.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdPrimer, Me.cmdPrevi, Me.cmdSeguent, Me.cmdUltim, Me.lbPosition, Me.ToolStripLabel1, Me.lbRecCount, Me.ToolStripSeparator1, Me.cmdNou, Me.cmdBloqueix, Me.cmdBorrar, Me.cmdSalvar, Me.ToolStripSeparator2, Me.cmdRefrescar, Me.OptionBuscar, Me.cmdSortir, Me.txtBuscar, Me.lbNou})
        Me.ToolStrip1.Location = New System.Drawing.Point(23, 78)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(654, 39)
        Me.ToolStrip1.TabIndex = 253
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
        Me.OptionBuscar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PerIDToolStripMenuItem, Me.PerNomToolStripMenuItem, Me.QualsevolToolStripMenuItem})
        Me.OptionBuscar.Image = CType(resources.GetObject("OptionBuscar.Image"), System.Drawing.Image)
        Me.OptionBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OptionBuscar.Name = "OptionBuscar"
        Me.OptionBuscar.Size = New System.Drawing.Size(48, 36)
        Me.OptionBuscar.Text = "Buscar"
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
        Me.QualsevolToolStripMenuItem.Checked = True
        Me.QualsevolToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.QualsevolToolStripMenuItem.Name = "QualsevolToolStripMenuItem"
        Me.QualsevolToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.QualsevolToolStripMenuItem.Text = "Qualsevol"
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
        Me.lbNou.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNou.ForeColor = System.Drawing.Color.Red
        Me.lbNou.Name = "lbNou"
        Me.lbNou.Size = New System.Drawing.Size(51, 36)
        Me.lbNou.Text = "Nou"
        Me.lbNou.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgarmaToolStripMenuItem, Me.EdicióToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(447, 39)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 4, 0, 4)
        Me.MenuStrip1.Size = New System.Drawing.Size(230, 28)
        Me.MenuStrip1.TabIndex = 254
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
        'frmMantSubject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(700, 481)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.TabControlMesInfo)
        Me.Controls.Add(Me.picLock)
        Me.Controls.Add(Me.lbUltim)
        Me.Controls.Add(Me.lbVaris)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbID)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.picUnLock)
        Me.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMantSubject"
        Me.Padding = New System.Windows.Forms.Padding(23, 78, 23, 26)
        Me.Text = "frmMantSubject"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.TabControlMesInfo.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.gridDades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridViewTemes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUnLock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControlMesInfo As MetroFramework.Controls.MetroTabControl
    Friend WithEvents TabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents gridDades As MetroFramework.Controls.MetroGrid
    Friend WithEvents ColumnID As DataGridViewTextBoxColumn
    Friend WithEvents ColumnNom As DataGridViewTextBoxColumn
    Friend WithEvents TabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents DataGridViewTemes As MetroFramework.Controls.MetroGrid
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents picLock As PictureBox
    Friend WithEvents lbUltim As Label
    Friend WithEvents lbVaris As Label
    Friend WithEvents txtNom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbID As Label
    Friend WithEvents cmdExit As Button
    Friend WithEvents picUnLock As PictureBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents cmdPrimer As ToolStripButton
    Friend WithEvents cmdPrevi As ToolStripButton
    Friend WithEvents cmdSeguent As ToolStripButton
    Friend WithEvents cmdUltim As ToolStripButton
    Friend WithEvents lbPosition As ToolStripLabel
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents lbRecCount As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents cmdNou As ToolStripButton
    Friend WithEvents cmdBloqueix As ToolStripButton
    Friend WithEvents cmdBorrar As ToolStripButton
    Friend WithEvents cmdSalvar As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents cmdRefrescar As ToolStripButton
    Friend WithEvents OptionBuscar As ToolStripSplitButton
    Friend WithEvents PerIDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PerNomToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QualsevolToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmdSortir As ToolStripButton
    Friend WithEvents txtBuscar As ToolStripTextBox
    Friend WithEvents lbNou As ToolStripLabel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ProgarmaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents EdicióToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuModif As ToolStripMenuItem
    Friend WithEvents mnuSave As ToolStripMenuItem
    Friend WithEvents mnuNew As ToolStripMenuItem
    Friend WithEvents mnuDel As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents mnuRefresh As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Public WithEvents mnu_Help As ToolStripMenuItem
End Class
