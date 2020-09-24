<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTest
    Inherits MetroFramework.Forms.MetroForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTest))
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
        Me.cmdPrint = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdBuscar = New System.Windows.Forms.ToolStripButton()
        Me.cmdRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdSortir = New System.Windows.Forms.ToolStripButton()
        Me.cmbMenu = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripSeparator()
        Me.lbNew = New System.Windows.Forms.ToolStripLabel()
        Me.lbAtencio = New System.Windows.Forms.ToolStripLabel()
        Me.lbVuMeter = New System.Windows.Forms.ToolStripLabel()
        Me.cmdStop = New System.Windows.Forms.ToolStripButton()
        Me.cmdPlay = New System.Windows.Forms.ToolStripButton()
        Me.picVuMeter = New System.Windows.Forms.PictureBox()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.cmdOnPauta = New MetroFramework.Controls.MetroToggle()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.picDisc = New System.Windows.Forms.PictureBox()
        Me.MetroComboBox1 = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLink1 = New MetroFramework.Controls.MetroLink()
        Me.MetroLink3 = New MetroFramework.Controls.MetroLink()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.picVuMeter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroTabControl1.SuspendLayout()
        CType(Me.picDisc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdPrimer, Me.cmdPrevi, Me.cmdSeguent, Me.cmdUltim, Me.lbPosition, Me.ToolStripLabel1, Me.lbRecCount, Me.ToolStripSeparator1, Me.cmdNou, Me.cmdBloqueix, Me.cmdBorrar, Me.cmdSalvar, Me.cmdPrint, Me.ToolStripSeparator2, Me.cmdBuscar, Me.cmdRefrescar, Me.ToolStripSeparator7, Me.cmdSortir, Me.cmbMenu, Me.ToolStripButton1, Me.lbNew, Me.lbAtencio, Me.lbVuMeter, Me.cmdStop, Me.cmdPlay})
        Me.ToolStrip1.Location = New System.Drawing.Point(20, 60)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(982, 39)
        Me.ToolStrip1.TabIndex = 65
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
        'cmdPrint
        '
        Me.cmdPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(36, 36)
        Me.cmdPrint.Text = "Imprimir llistat"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'cmdBuscar
        '
        Me.cmdBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdBuscar.Image = CType(resources.GetObject("cmdBuscar.Image"), System.Drawing.Image)
        Me.cmdBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(36, 36)
        Me.cmdBuscar.Text = "Buscar"
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
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 39)
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
        'cmbMenu
        '
        Me.cmbMenu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.cmbMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmbMenu.Image = CType(resources.GetObject("cmbMenu.Image"), System.Drawing.Image)
        Me.cmbMenu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmbMenu.Name = "cmbMenu"
        Me.cmbMenu.Size = New System.Drawing.Size(36, 36)
        Me.cmbMenu.Text = "ToolStripButton2"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(6, 39)
        '
        'lbNew
        '
        Me.lbNew.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNew.ForeColor = System.Drawing.Color.Red
        Me.lbNew.Name = "lbNew"
        Me.lbNew.Size = New System.Drawing.Size(78, 37)
        Me.lbNew.Text = "NOU"
        Me.lbNew.Visible = False
        '
        'lbAtencio
        '
        Me.lbAtencio.Font = New System.Drawing.Font("Segoe UI Symbol", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAtencio.Image = CType(resources.GetObject("lbAtencio.Image"), System.Drawing.Image)
        Me.lbAtencio.Name = "lbAtencio"
        Me.lbAtencio.Size = New System.Drawing.Size(60, 36)
        Me.lbAtencio.Text = "No Exist."
        Me.lbAtencio.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        Me.lbAtencio.ToolTipText = "No existeix el fitxer"
        Me.lbAtencio.Visible = False
        '
        'lbVuMeter
        '
        Me.lbVuMeter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lbVuMeter.AutoSize = False
        Me.lbVuMeter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.lbVuMeter.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.lbVuMeter.Name = "lbVuMeter"
        Me.lbVuMeter.Size = New System.Drawing.Size(175, 36)
        '
        'cmdStop
        '
        Me.cmdStop.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.cmdStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdStop.Image = CType(resources.GetObject("cmdStop.Image"), System.Drawing.Image)
        Me.cmdStop.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdStop.Name = "cmdStop"
        Me.cmdStop.Size = New System.Drawing.Size(36, 36)
        Me.cmdStop.Text = "ToolStripButton4"
        '
        'cmdPlay
        '
        Me.cmdPlay.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.cmdPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdPlay.Image = CType(resources.GetObject("cmdPlay.Image"), System.Drawing.Image)
        Me.cmdPlay.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPlay.Name = "cmdPlay"
        Me.cmdPlay.Size = New System.Drawing.Size(36, 36)
        Me.cmdPlay.Text = "ToolStripButton3"
        '
        'picVuMeter
        '
        Me.picVuMeter.BackColor = System.Drawing.SystemColors.Control
        Me.picVuMeter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picVuMeter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picVuMeter.Location = New System.Drawing.Point(749, 67)
        Me.picVuMeter.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.picVuMeter.Name = "picVuMeter"
        Me.picVuMeter.Size = New System.Drawing.Size(175, 26)
        Me.picVuMeter.TabIndex = 193
        Me.picVuMeter.TabStop = False
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage2)
        Me.MetroTabControl1.Location = New System.Drawing.Point(23, 290)
        Me.MetroTabControl1.Multiline = True
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(967, 264)
        Me.MetroTabControl1.TabIndex = 194
        Me.MetroTabControl1.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(959, 222)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "Cançons disponibles segons el filtre realitzat"
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 10
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(959, 222)
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "Agrupació de diferents cançons"
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 10
        '
        'cmdOnPauta
        '
        Me.cmdOnPauta.AutoSize = True
        Me.cmdOnPauta.Location = New System.Drawing.Point(445, 107)
        Me.cmdOnPauta.Name = "cmdOnPauta"
        Me.cmdOnPauta.Size = New System.Drawing.Size(80, 17)
        Me.cmdOnPauta.TabIndex = 195
        Me.cmdOnPauta.Text = "Off"
        Me.cmdOnPauta.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Location = New System.Drawing.Point(253, 105)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(117, 23)
        Me.MetroLabel1.TabIndex = 196
        Me.MetroLabel1.Text = "Identificador"
        Me.MetroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel2.Location = New System.Drawing.Point(378, 107)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(17, 19)
        Me.MetroLabel2.TabIndex = 197
        Me.MetroLabel2.Text = "0"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.Location = New System.Drawing.Point(57, 142)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(117, 23)
        Me.MetroLabel3.TabIndex = 198
        Me.MetroLabel3.Text = "Títol"
        Me.MetroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MetroTextBox1
        '
        '
        '
        '
        Me.MetroTextBox1.CustomButton.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.MetroTextBox1.CustomButton.Location = New System.Drawing.Point(453, 1)
        Me.MetroTextBox1.CustomButton.Name = ""
        Me.MetroTextBox1.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.MetroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox1.CustomButton.TabIndex = 1
        Me.MetroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox1.CustomButton.UseSelectable = True
        Me.MetroTextBox1.DisplayIcon = True
        Me.MetroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.MetroTextBox1.Lines = New String(-1) {}
        Me.MetroTextBox1.Location = New System.Drawing.Point(194, 132)
        Me.MetroTextBox1.MaxLength = 32767
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox1.SelectedText = ""
        Me.MetroTextBox1.SelectionLength = 0
        Me.MetroTextBox1.SelectionStart = 0
        Me.MetroTextBox1.ShortcutsEnabled = True
        Me.MetroTextBox1.ShowButton = True
        Me.MetroTextBox1.Size = New System.Drawing.Size(481, 29)
        Me.MetroTextBox1.TabIndex = 199
        Me.MetroTextBox1.UseSelectable = True
        Me.MetroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'picDisc
        '
        Me.picDisc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picDisc.Location = New System.Drawing.Point(802, 103)
        Me.picDisc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picDisc.Name = "picDisc"
        Me.picDisc.Size = New System.Drawing.Size(200, 200)
        Me.picDisc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDisc.TabIndex = 200
        Me.picDisc.TabStop = False
        Me.picDisc.Tag = "nofoto"
        '
        'MetroComboBox1
        '
        Me.MetroComboBox1.FormattingEnabled = True
        Me.MetroComboBox1.ItemHeight = 23
        Me.MetroComboBox1.Location = New System.Drawing.Point(194, 187)
        Me.MetroComboBox1.Name = "MetroComboBox1"
        Me.MetroComboBox1.Size = New System.Drawing.Size(453, 29)
        Me.MetroComboBox1.TabIndex = 201
        Me.MetroComboBox1.UseSelectable = True
        '
        'MetroLink1
        '
        Me.MetroLink1.Image = CType(resources.GetObject("MetroLink1.Image"), System.Drawing.Image)
        Me.MetroLink1.ImageSize = 30
        Me.MetroLink1.Location = New System.Drawing.Point(646, 185)
        Me.MetroLink1.Name = "MetroLink1"
        Me.MetroLink1.NoFocusImage = CType(resources.GetObject("MetroLink1.NoFocusImage"), System.Drawing.Image)
        Me.MetroLink1.Size = New System.Drawing.Size(29, 31)
        Me.MetroLink1.TabIndex = 202
        Me.MetroLink1.UseSelectable = True
        '
        'MetroLink3
        '
        Me.MetroLink3.FontSize = MetroFramework.MetroLinkSize.Medium
        Me.MetroLink3.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.MetroLink3.Location = New System.Drawing.Point(99, 185)
        Me.MetroLink3.Name = "MetroLink3"
        Me.MetroLink3.Size = New System.Drawing.Size(75, 29)
        Me.MetroLink3.TabIndex = 208
        Me.MetroLink3.Text = "Intèrpret"
        Me.MetroLink3.UseCustomForeColor = True
        Me.MetroLink3.UseSelectable = True
        '
        'FormTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1022, 575)
        Me.Controls.Add(Me.MetroLink3)
        Me.Controls.Add(Me.MetroLink1)
        Me.Controls.Add(Me.MetroComboBox1)
        Me.Controls.Add(Me.picDisc)
        Me.Controls.Add(Me.MetroTextBox1)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.cmdOnPauta)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Controls.Add(Me.picVuMeter)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "FormTest"
        Me.Text = "Pantalla test"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.picVuMeter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroTabControl1.ResumeLayout(False)
        CType(Me.picDisc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

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
    Friend WithEvents cmdPrint As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents cmdBuscar As ToolStripButton
    Friend WithEvents cmdRefrescar As ToolStripButton
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents cmdSortir As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripSeparator
    Friend WithEvents lbVuMeter As ToolStripLabel
    Friend WithEvents lbAtencio As ToolStripLabel
    Friend WithEvents cmbMenu As ToolStripButton
    Friend WithEvents cmdStop As ToolStripButton
    Friend WithEvents cmdPlay As ToolStripButton
    Friend WithEvents picVuMeter As PictureBox
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents cmdOnPauta As MetroFramework.Controls.MetroToggle
    Friend WithEvents lbNew As ToolStripLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents picDisc As PictureBox
    Friend WithEvents MetroComboBox1 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLink1 As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLink3 As MetroFramework.Controls.MetroLink
End Class
