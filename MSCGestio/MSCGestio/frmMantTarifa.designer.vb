﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantTarifa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMantTarifa))
        Me.cmdUltim = New System.Windows.Forms.ToolStripButton
        Me.cmdSeguent = New System.Windows.Forms.ToolStripButton
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.lbPosition = New System.Windows.Forms.ToolStripLabel
        Me.picUnLock = New System.Windows.Forms.PictureBox
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.cmdPrimer = New System.Windows.Forms.ToolStripButton
        Me.cmdPrevi = New System.Windows.Forms.ToolStripButton
        Me.lbRecCount = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdNou = New System.Windows.Forms.ToolStripButton
        Me.cmdBloqueix = New System.Windows.Forms.ToolStripButton
        Me.cmdBorrar = New System.Windows.Forms.ToolStripButton
        Me.cmdSalvar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdRefrescar = New System.Windows.Forms.ToolStripButton
        Me.cmdSortir = New System.Windows.Forms.ToolStripButton
        Me.OptionBuscar = New System.Windows.Forms.ToolStripSplitButton
        Me.PerIDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PerNomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.QualsevolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.txtBuscar = New System.Windows.Forms.ToolStripTextBox
        Me.lbNou = New System.Windows.Forms.Label
        Me.picLock = New System.Windows.Forms.PictureBox
        Me.gridDades = New System.Windows.Forms.DataGridView
        Me.ColumnID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColumnNom = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColumnDescrip = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColumnPreu = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.lbUltim = New System.Windows.Forms.Label
        Me.txtNom = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbID = New System.Windows.Forms.Label
        Me.cmdExit = New System.Windows.Forms.Button
        Me.lbUnitMoneda = New System.Windows.Forms.Label
        Me.lbUnitContraValor = New System.Windows.Forms.Label
        Me.lbContraValor = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtPreu = New System.Windows.Forms.TextBox
        Me.txtDescrip = New System.Windows.Forms.TextBox
        Me.TabControlMesInfo = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.DataGridViewAnuncis = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ProgarmaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem
        Me.EdicióToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuModif = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuNew = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuDel = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuRefresh = New System.Windows.Forms.ToolStripMenuItem
        CType(Me.picUnLock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.picLock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridDades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlMesInfo.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridViewAnuncis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
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
        'cmdSeguent
        '
        Me.cmdSeguent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdSeguent.Image = CType(resources.GetObject("cmdSeguent.Image"), System.Drawing.Image)
        Me.cmdSeguent.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSeguent.Name = "cmdSeguent"
        Me.cmdSeguent.Size = New System.Drawing.Size(36, 36)
        Me.cmdSeguent.Text = "Següent"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(16, 36)
        Me.ToolStripLabel1.Text = "/"
        '
        'lbPosition
        '
        Me.lbPosition.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPosition.Name = "lbPosition"
        Me.lbPosition.Size = New System.Drawing.Size(16, 36)
        Me.lbPosition.Text = "0"
        Me.lbPosition.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'picUnLock
        '
        Me.picUnLock.Image = CType(resources.GetObject("picUnLock.Image"), System.Drawing.Image)
        Me.picUnLock.Location = New System.Drawing.Point(470, 62)
        Me.picUnLock.Name = "picUnLock"
        Me.picUnLock.Size = New System.Drawing.Size(40, 34)
        Me.picUnLock.TabIndex = 108
        Me.picUnLock.TabStop = False
        Me.picUnLock.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdPrimer, Me.cmdPrevi, Me.cmdSeguent, Me.cmdUltim, Me.lbPosition, Me.ToolStripLabel1, Me.lbRecCount, Me.ToolStripSeparator1, Me.cmdNou, Me.cmdBloqueix, Me.cmdBorrar, Me.cmdSalvar, Me.ToolStripSeparator2, Me.cmdRefrescar, Me.cmdSortir, Me.OptionBuscar, Me.txtBuscar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(592, 39)
        Me.ToolStrip1.TabIndex = 105
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
        'PerIDToolStripMenuItem
        '
        Me.PerIDToolStripMenuItem.Name = "PerIDToolStripMenuItem"
        Me.PerIDToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.PerIDToolStripMenuItem.Tag = "0"
        Me.PerIDToolStripMenuItem.Text = "Per ID"
        '
        'PerNomToolStripMenuItem
        '
        Me.PerNomToolStripMenuItem.Name = "PerNomToolStripMenuItem"
        Me.PerNomToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.PerNomToolStripMenuItem.Tag = "1"
        Me.PerNomToolStripMenuItem.Text = "Per Nom"
        '
        'QualsevolToolStripMenuItem
        '
        Me.QualsevolToolStripMenuItem.Checked = True
        Me.QualsevolToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.QualsevolToolStripMenuItem.Name = "QualsevolToolStripMenuItem"
        Me.QualsevolToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.QualsevolToolStripMenuItem.Tag = "0"
        Me.QualsevolToolStripMenuItem.Text = "Qualsevol"
        '
        'txtBuscar
        '
        Me.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(55, 39)
        Me.txtBuscar.Text = "Buscar.."
        '
        'lbNou
        '
        Me.lbNou.AutoSize = True
        Me.lbNou.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNou.ForeColor = System.Drawing.Color.Red
        Me.lbNou.Location = New System.Drawing.Point(293, 63)
        Me.lbNou.Name = "lbNou"
        Me.lbNou.Size = New System.Drawing.Size(61, 25)
        Me.lbNou.TabIndex = 109
        Me.lbNou.Text = "NOU"
        Me.lbNou.Visible = False
        '
        'picLock
        '
        Me.picLock.Image = CType(resources.GetObject("picLock.Image"), System.Drawing.Image)
        Me.picLock.Location = New System.Drawing.Point(425, 63)
        Me.picLock.Name = "picLock"
        Me.picLock.Size = New System.Drawing.Size(39, 35)
        Me.picLock.TabIndex = 107
        Me.picLock.TabStop = False
        Me.picLock.Visible = False
        '
        'gridDades
        '
        Me.gridDades.AllowUserToAddRows = False
        Me.gridDades.AllowUserToDeleteRows = False
        Me.gridDades.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.gridDades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridDades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnID, Me.ColumnNom, Me.ColumnDescrip, Me.ColumnPreu})
        Me.gridDades.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridDades.Location = New System.Drawing.Point(3, 3)
        Me.gridDades.Name = "gridDades"
        Me.gridDades.ReadOnly = True
        Me.gridDades.RowHeadersVisible = False
        Me.gridDades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridDades.ShowEditingIcon = False
        Me.gridDades.Size = New System.Drawing.Size(503, 170)
        Me.gridDades.TabIndex = 116
        '
        'ColumnID
        '
        Me.ColumnID.DataPropertyName = "tarifID"
        Me.ColumnID.HeaderText = "ID"
        Me.ColumnID.Name = "ColumnID"
        Me.ColumnID.ReadOnly = True
        Me.ColumnID.Width = 50
        '
        'ColumnNom
        '
        Me.ColumnNom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnNom.DataPropertyName = "tarifNom"
        Me.ColumnNom.HeaderText = "Nom"
        Me.ColumnNom.Name = "ColumnNom"
        Me.ColumnNom.ReadOnly = True
        '
        'ColumnDescrip
        '
        Me.ColumnDescrip.DataPropertyName = "tarifDescrip"
        Me.ColumnDescrip.HeaderText = "Descrip"
        Me.ColumnDescrip.Name = "ColumnDescrip"
        Me.ColumnDescrip.ReadOnly = True
        Me.ColumnDescrip.Visible = False
        '
        'ColumnPreu
        '
        Me.ColumnPreu.DataPropertyName = "tarifPreu"
        Me.ColumnPreu.HeaderText = "Preu"
        Me.ColumnPreu.Name = "ColumnPreu"
        Me.ColumnPreu.ReadOnly = True
        '
        'lbUltim
        '
        Me.lbUltim.AutoSize = True
        Me.lbUltim.BackColor = System.Drawing.Color.Lime
        Me.lbUltim.Location = New System.Drawing.Point(422, 47)
        Me.lbUltim.Name = "lbUltim"
        Me.lbUltim.Size = New System.Drawing.Size(13, 13)
        Me.lbUltim.TabIndex = 114
        Me.lbUltim.Text = "0"
        Me.lbUltim.Visible = False
        '
        'txtNom
        '
        Me.txtNom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNom.Enabled = False
        Me.txtNom.Location = New System.Drawing.Point(209, 102)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(132, 20)
        Me.txtNom.TabIndex = 113
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(154, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 112
        Me.Label2.Text = "Nom:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(118, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 111
        Me.Label1.Text = "Identificador:"
        '
        'lbID
        '
        Me.lbID.AutoSize = True
        Me.lbID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbID.Location = New System.Drawing.Point(209, 70)
        Me.lbID.Name = "lbID"
        Me.lbID.Size = New System.Drawing.Size(14, 13)
        Me.lbID.TabIndex = 110
        Me.lbID.Text = "0"
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Location = New System.Drawing.Point(-6, 27)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(34, 11)
        Me.cmdExit.TabIndex = 106
        Me.cmdExit.Text = "Button1"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'lbUnitMoneda
        '
        Me.lbUnitMoneda.AutoSize = True
        Me.lbUnitMoneda.ForeColor = System.Drawing.Color.Blue
        Me.lbUnitMoneda.Location = New System.Drawing.Point(344, 159)
        Me.lbUnitMoneda.Name = "lbUnitMoneda"
        Me.lbUnitMoneda.Size = New System.Drawing.Size(13, 13)
        Me.lbUnitMoneda.TabIndex = 130
        Me.lbUnitMoneda.Text = "€"
        '
        'lbUnitContraValor
        '
        Me.lbUnitContraValor.AutoSize = True
        Me.lbUnitContraValor.ForeColor = System.Drawing.Color.Blue
        Me.lbUnitContraValor.Location = New System.Drawing.Point(441, 159)
        Me.lbUnitContraValor.Name = "lbUnitContraValor"
        Me.lbUnitContraValor.Size = New System.Drawing.Size(28, 13)
        Me.lbUnitContraValor.TabIndex = 129
        Me.lbUnitContraValor.Text = "Ptes"
        '
        'lbContraValor
        '
        Me.lbContraValor.ForeColor = System.Drawing.Color.Blue
        Me.lbContraValor.Location = New System.Drawing.Point(374, 159)
        Me.lbContraValor.Name = "lbContraValor"
        Me.lbContraValor.Size = New System.Drawing.Size(67, 13)
        Me.lbContraValor.TabIndex = 128
        Me.lbContraValor.Text = "0"
        Me.lbContraValor.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(157, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 127
        Me.Label4.Text = "Preu"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(126, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 126
        Me.Label3.Text = "Descripció:"
        '
        'txtPreu
        '
        Me.txtPreu.Enabled = False
        Me.txtPreu.Location = New System.Drawing.Point(209, 156)
        Me.txtPreu.Name = "txtPreu"
        Me.txtPreu.Size = New System.Drawing.Size(132, 20)
        Me.txtPreu.TabIndex = 125
        Me.txtPreu.Text = "0"
        '
        'txtDescrip
        '
        Me.txtDescrip.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescrip.Enabled = False
        Me.txtDescrip.Location = New System.Drawing.Point(209, 128)
        Me.txtDescrip.Name = "txtDescrip"
        Me.txtDescrip.Size = New System.Drawing.Size(348, 20)
        Me.txtDescrip.TabIndex = 124
        '
        'TabControlMesInfo
        '
        Me.TabControlMesInfo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControlMesInfo.Controls.Add(Me.TabPage1)
        Me.TabControlMesInfo.Controls.Add(Me.TabPage2)
        Me.TabControlMesInfo.Location = New System.Drawing.Point(40, 193)
        Me.TabControlMesInfo.Name = "TabControlMesInfo"
        Me.TabControlMesInfo.SelectedIndex = 0
        Me.TabControlMesInfo.Size = New System.Drawing.Size(517, 202)
        Me.TabControlMesInfo.TabIndex = 238
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.gridDades)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(509, 176)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "LListat Tarifes"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGridViewAnuncis)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(509, 176)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Anuncis amb aquesta tarifa"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridViewAnuncis
        '
        Me.DataGridViewAnuncis.AllowUserToAddRows = False
        Me.DataGridViewAnuncis.AllowUserToDeleteRows = False
        Me.DataGridViewAnuncis.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridViewAnuncis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewAnuncis.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.DataGridViewAnuncis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewAnuncis.Location = New System.Drawing.Point(3, 3)
        Me.DataGridViewAnuncis.Name = "DataGridViewAnuncis"
        Me.DataGridViewAnuncis.ReadOnly = True
        Me.DataGridViewAnuncis.RowHeadersVisible = False
        Me.DataGridViewAnuncis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewAnuncis.ShowEditingIcon = False
        Me.DataGridViewAnuncis.Size = New System.Drawing.Size(503, 170)
        Me.DataGridViewAnuncis.TabIndex = 236
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "falcID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        Me.DataGridViewTextBoxColumn3.Width = 50
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "falcNomFalca"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Nom"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgarmaToolStripMenuItem, Me.EdicióToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(592, 24)
        Me.MenuStrip1.TabIndex = 239
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProgarmaToolStripMenuItem
        '
        Me.ProgarmaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExit})
        Me.ProgarmaToolStripMenuItem.Name = "ProgarmaToolStripMenuItem"
        Me.ProgarmaToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ProgarmaToolStripMenuItem.Text = "Programa"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(111, 22)
        Me.mnuExit.Text = "Sortir"
        '
        'EdicióToolStripMenuItem
        '
        Me.EdicióToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuModif, Me.mnuSave, Me.mnuNew, Me.mnuDel, Me.ToolStripSeparator3, Me.mnuRefresh})
        Me.EdicióToolStripMenuItem.Name = "EdicióToolStripMenuItem"
        Me.EdicióToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.EdicióToolStripMenuItem.Text = "Edició"
        '
        'mnuModif
        '
        Me.mnuModif.Enabled = False
        Me.mnuModif.Name = "mnuModif"
        Me.mnuModif.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.mnuModif.Size = New System.Drawing.Size(171, 22)
        Me.mnuModif.Text = "Modificar"
        '
        'mnuSave
        '
        Me.mnuSave.Enabled = False
        Me.mnuSave.Name = "mnuSave"
        Me.mnuSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuSave.Size = New System.Drawing.Size(171, 22)
        Me.mnuSave.Text = "Salvar"
        '
        'mnuNew
        '
        Me.mnuNew.Name = "mnuNew"
        Me.mnuNew.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.mnuNew.Size = New System.Drawing.Size(171, 22)
        Me.mnuNew.Text = "Nou"
        '
        'mnuDel
        '
        Me.mnuDel.Enabled = False
        Me.mnuDel.Name = "mnuDel"
        Me.mnuDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Delete), System.Windows.Forms.Keys)
        Me.mnuDel.Size = New System.Drawing.Size(171, 22)
        Me.mnuDel.Text = "Borrar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(168, 6)
        '
        'mnuRefresh
        '
        Me.mnuRefresh.Name = "mnuRefresh"
        Me.mnuRefresh.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.mnuRefresh.Size = New System.Drawing.Size(171, 22)
        Me.mnuRefresh.Text = "Refrescar"
        '
        'frmMantTarifa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(592, 416)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TabControlMesInfo)
        Me.Controls.Add(Me.lbUnitMoneda)
        Me.Controls.Add(Me.lbUnitContraValor)
        Me.Controls.Add(Me.lbContraValor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPreu)
        Me.Controls.Add(Me.txtDescrip)
        Me.Controls.Add(Me.picUnLock)
        Me.Controls.Add(Me.lbNou)
        Me.Controls.Add(Me.picLock)
        Me.Controls.Add(Me.lbUltim)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbID)
        Me.Controls.Add(Me.cmdExit)
        Me.MinimumSize = New System.Drawing.Size(600, 450)
        Me.Name = "frmMantTarifa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMantTarifa"
        CType(Me.picUnLock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.picLock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridDades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlMesInfo.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridViewAnuncis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdUltim As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdSeguent As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lbPosition As System.Windows.Forms.ToolStripLabel
    Friend WithEvents picUnLock As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdPrimer As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdPrevi As System.Windows.Forms.ToolStripButton
    Friend WithEvents lbRecCount As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdNou As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdBloqueix As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdBorrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdSalvar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdSortir As System.Windows.Forms.ToolStripButton
    Friend WithEvents OptionBuscar As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents PerIDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PerNomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QualsevolToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtBuscar As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents lbNou As System.Windows.Forms.Label
    Friend WithEvents picLock As System.Windows.Forms.PictureBox
    Friend WithEvents gridDades As System.Windows.Forms.DataGridView
    Friend WithEvents lbUltim As System.Windows.Forms.Label
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbID As System.Windows.Forms.Label
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents lbUnitMoneda As System.Windows.Forms.Label
    Friend WithEvents lbUnitContraValor As System.Windows.Forms.Label
    Friend WithEvents lbContraValor As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPreu As System.Windows.Forms.TextBox
    Friend WithEvents txtDescrip As System.Windows.Forms.TextBox
    Friend WithEvents ColumnID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnNom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnDescrip As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnPreu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabControlMesInfo As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridViewAnuncis As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
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
