<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarDiscos
    Inherits MetroFramework.Forms.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscarDiscos))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdMoreFind = New MetroFramework.Controls.MetroTile()
        Me.cmdAddCodiBar = New MetroFramework.Controls.MetroTile()
        Me.cmdBuscar = New MetroFramework.Controls.MetroTile()
        Me.CmdTancar = New MetroFramework.Controls.MetroTile()
        Me.chkAddResult = New System.Windows.Forms.CheckBox()
        Me.fraAvanç = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ChkIgnoreFormat = New MetroFramework.Controls.MetroRadioButton()
        Me.optAltres = New MetroFramework.Controls.MetroRadioButton()
        Me.optVinil = New MetroFramework.Controls.MetroRadioButton()
        Me.optK7 = New MetroFramework.Controls.MetroRadioButton()
        Me.optMP3 = New MetroFramework.Controls.MetroRadioButton()
        Me.optCD = New MetroFramework.Controls.MetroRadioButton()
        Me.txtAnyPubli = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEstant = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboProveidor = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboCia = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNomDisc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboInterp = New System.Windows.Forms.ComboBox()
        Me.ComboEstil = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdSortir = New MetroFramework.Controls.MetroLink()
        Me.PanelScanCodi = New System.Windows.Forms.Panel()
        Me.buttonCancelSearch = New MetroFramework.Controls.MetroTile()
        Me.buttonSearchCode = New MetroFramework.Controls.MetroTile()
        Me.picCodiBarres = New System.Windows.Forms.PictureBox()
        Me.txtCodiBarres = New System.Windows.Forms.TextBox()
        Me.lbScandCode = New MetroFramework.Controls.MetroLabel()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.ButtonHide = New MetroFramework.Controls.MetroLink()
        Me.Panel1.SuspendLayout()
        Me.fraAvanç.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.PanelScanCodi.SuspendLayout()
        CType(Me.picCodiBarres, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.cmdMoreFind)
        Me.Panel1.Controls.Add(Me.cmdAddCodiBar)
        Me.Panel1.Controls.Add(Me.cmdBuscar)
        Me.Panel1.Location = New System.Drawing.Point(15, 219)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(434, 82)
        Me.Panel1.TabIndex = 21
        '
        'cmdMoreFind
        '
        Me.cmdMoreFind.ActiveControl = Nothing
        Me.cmdMoreFind.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdMoreFind.Location = New System.Drawing.Point(312, 11)
        Me.cmdMoreFind.Name = "cmdMoreFind"
        Me.cmdMoreFind.Size = New System.Drawing.Size(98, 55)
        Me.cmdMoreFind.TabIndex = 32
        Me.cmdMoreFind.Text = "Avançats>>"
        Me.cmdMoreFind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdMoreFind.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdMoreFind.UseSelectable = True
        Me.cmdMoreFind.UseTileImage = True
        '
        'cmdAddCodiBar
        '
        Me.cmdAddCodiBar.ActiveControl = Nothing
        Me.cmdAddCodiBar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAddCodiBar.Location = New System.Drawing.Point(7, 11)
        Me.cmdAddCodiBar.Name = "cmdAddCodiBar"
        Me.cmdAddCodiBar.Size = New System.Drawing.Size(89, 55)
        Me.cmdAddCodiBar.TabIndex = 31
        Me.cmdAddCodiBar.TileImage = CType(resources.GetObject("cmdAddCodiBar.TileImage"), System.Drawing.Image)
        Me.cmdAddCodiBar.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdAddCodiBar.UseSelectable = True
        Me.cmdAddCodiBar.UseTileImage = True
        '
        'cmdBuscar
        '
        Me.cmdBuscar.ActiveControl = Nothing
        Me.cmdBuscar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmdBuscar.Location = New System.Drawing.Point(111, 11)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(183, 55)
        Me.cmdBuscar.TabIndex = 5
        Me.cmdBuscar.TileImage = CType(resources.GetObject("cmdBuscar.TileImage"), System.Drawing.Image)
        Me.cmdBuscar.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdBuscar.UseSelectable = True
        Me.cmdBuscar.UseTileImage = True
        '
        'CmdTancar
        '
        Me.CmdTancar.ActiveControl = Nothing
        Me.CmdTancar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CmdTancar.Location = New System.Drawing.Point(407, 44)
        Me.CmdTancar.Name = "CmdTancar"
        Me.CmdTancar.Size = New System.Drawing.Size(18, 26)
        Me.CmdTancar.TabIndex = 4
        Me.CmdTancar.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CmdTancar.UseSelectable = True
        Me.CmdTancar.UseTileImage = True
        '
        'chkAddResult
        '
        Me.chkAddResult.AutoSize = True
        Me.chkAddResult.Location = New System.Drawing.Point(126, 439)
        Me.chkAddResult.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkAddResult.Name = "chkAddResult"
        Me.chkAddResult.Size = New System.Drawing.Size(184, 21)
        Me.chkAddResult.TabIndex = 21
        Me.chkAddResult.Text = "Afegir a la recerca anterior"
        Me.chkAddResult.UseVisualStyleBackColor = True
        '
        'fraAvanç
        '
        Me.fraAvanç.Controls.Add(Me.GroupBox2)
        Me.fraAvanç.Controls.Add(Me.txtAnyPubli)
        Me.fraAvanç.Controls.Add(Me.Label8)
        Me.fraAvanç.Controls.Add(Me.Label7)
        Me.fraAvanç.Controls.Add(Me.txtEstant)
        Me.fraAvanç.Controls.Add(Me.Label6)
        Me.fraAvanç.Controls.Add(Me.ComboProveidor)
        Me.fraAvanç.Controls.Add(Me.Label5)
        Me.fraAvanç.Controls.Add(Me.ComboCia)
        Me.fraAvanç.Location = New System.Drawing.Point(21, 216)
        Me.fraAvanç.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.fraAvanç.Name = "fraAvanç"
        Me.fraAvanç.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.fraAvanç.Size = New System.Drawing.Size(404, 215)
        Me.fraAvanç.TabIndex = 23
        Me.fraAvanç.TabStop = False
        Me.fraAvanç.Text = "Recerca avançada"
        Me.fraAvanç.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ChkIgnoreFormat)
        Me.GroupBox2.Controls.Add(Me.optAltres)
        Me.GroupBox2.Controls.Add(Me.optVinil)
        Me.GroupBox2.Controls.Add(Me.optK7)
        Me.GroupBox2.Controls.Add(Me.optMP3)
        Me.GroupBox2.Controls.Add(Me.optCD)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 152)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(384, 55)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Format"
        '
        'ChkIgnoreFormat
        '
        Me.ChkIgnoreFormat.AutoSize = True
        Me.ChkIgnoreFormat.Checked = True
        Me.ChkIgnoreFormat.Location = New System.Drawing.Point(7, 20)
        Me.ChkIgnoreFormat.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ChkIgnoreFormat.Name = "ChkIgnoreFormat"
        Me.ChkIgnoreFormat.Size = New System.Drawing.Size(61, 15)
        Me.ChkIgnoreFormat.TabIndex = 10
        Me.ChkIgnoreFormat.TabStop = True
        Me.ChkIgnoreFormat.Text = "Ignorar"
        Me.ChkIgnoreFormat.UseSelectable = True
        '
        'optAltres
        '
        Me.optAltres.AutoSize = True
        Me.optAltres.Location = New System.Drawing.Point(320, 20)
        Me.optAltres.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.optAltres.Name = "optAltres"
        Me.optAltres.Size = New System.Drawing.Size(53, 15)
        Me.optAltres.TabIndex = 9
        Me.optAltres.Text = "Altres"
        Me.optAltres.UseSelectable = True
        '
        'optVinil
        '
        Me.optVinil.AutoSize = True
        Me.optVinil.Location = New System.Drawing.Point(259, 20)
        Me.optVinil.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.optVinil.Name = "optVinil"
        Me.optVinil.Size = New System.Drawing.Size(46, 15)
        Me.optVinil.TabIndex = 8
        Me.optVinil.Text = "Vinil"
        Me.optVinil.UseSelectable = True
        '
        'optK7
        '
        Me.optK7.AutoSize = True
        Me.optK7.Location = New System.Drawing.Point(205, 20)
        Me.optK7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.optK7.Name = "optK7"
        Me.optK7.Size = New System.Drawing.Size(36, 15)
        Me.optK7.TabIndex = 7
        Me.optK7.Text = "K7"
        Me.optK7.UseSelectable = True
        '
        'optMP3
        '
        Me.optMP3.AutoSize = True
        Me.optMP3.Location = New System.Drawing.Point(141, 20)
        Me.optMP3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.optMP3.Name = "optMP3"
        Me.optMP3.Size = New System.Drawing.Size(47, 15)
        Me.optMP3.TabIndex = 6
        Me.optMP3.Text = "MP3"
        Me.optMP3.UseSelectable = True
        '
        'optCD
        '
        Me.optCD.AutoSize = True
        Me.optCD.Location = New System.Drawing.Point(85, 20)
        Me.optCD.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.optCD.Name = "optCD"
        Me.optCD.Size = New System.Drawing.Size(39, 15)
        Me.optCD.TabIndex = 5
        Me.optCD.Text = "CD"
        Me.optCD.UseSelectable = True
        '
        'txtAnyPubli
        '
        Me.txtAnyPubli.Location = New System.Drawing.Point(105, 118)
        Me.txtAnyPubli.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAnyPubli.Name = "txtAnyPubli"
        Me.txtAnyPubli.Size = New System.Drawing.Size(105, 25)
        Me.txtAnyPubli.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 124)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 17)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Any publicació"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 17)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Prestatge"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtEstant
        '
        Me.txtEstant.Location = New System.Drawing.Point(105, 86)
        Me.txtEstant.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtEstant.Name = "txtEstant"
        Me.txtEstant.Size = New System.Drawing.Size(291, 25)
        Me.txtEstant.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 17)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Proveïdor"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ComboProveidor
        '
        Me.ComboProveidor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboProveidor.FormattingEnabled = True
        Me.ComboProveidor.Location = New System.Drawing.Point(105, 54)
        Me.ComboProveidor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboProveidor.Name = "ComboProveidor"
        Me.ComboProveidor.Size = New System.Drawing.Size(291, 25)
        Me.ComboProveidor.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Companyia"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ComboCia
        '
        Me.ComboCia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboCia.FormattingEnabled = True
        Me.ComboCia.Location = New System.Drawing.Point(105, 18)
        Me.ComboCia.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboCia.Name = "ComboCia"
        Me.ComboCia.Size = New System.Drawing.Size(291, 25)
        Me.ComboCia.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(31, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(255, 17)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Buscar un disc segons un filtre determinat."
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(26, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 17)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Nom del Disc"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtNomDisc
        '
        Me.txtNomDisc.Location = New System.Drawing.Point(127, 111)
        Me.txtNomDisc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNomDisc.Name = "txtNomDisc"
        Me.txtNomDisc.Size = New System.Drawing.Size(298, 25)
        Me.txtNomDisc.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(23, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 17)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Intèrpret"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ComboInterp
        '
        Me.ComboInterp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboInterp.FormattingEnabled = True
        Me.ComboInterp.Location = New System.Drawing.Point(126, 145)
        Me.ComboInterp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboInterp.Name = "ComboInterp"
        Me.ComboInterp.Size = New System.Drawing.Size(298, 25)
        Me.ComboInterp.TabIndex = 2
        '
        'ComboEstil
        '
        Me.ComboEstil.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboEstil.FormattingEnabled = True
        Me.ComboEstil.Location = New System.Drawing.Point(126, 180)
        Me.ComboEstil.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboEstil.Name = "ComboEstil"
        Me.ComboEstil.Size = New System.Drawing.Size(298, 25)
        Me.ComboEstil.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(23, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 17)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Estil"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmdSortir
        '
        Me.cmdSortir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSortir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdSortir.Image = CType(resources.GetObject("cmdSortir.Image"), System.Drawing.Image)
        Me.cmdSortir.ImageSize = 32
        Me.cmdSortir.Location = New System.Drawing.Point(388, 32)
        Me.cmdSortir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdSortir.Name = "cmdSortir"
        Me.cmdSortir.Size = New System.Drawing.Size(41, 46)
        Me.cmdSortir.TabIndex = 244
        Me.cmdSortir.UseSelectable = True
        '
        'PanelScanCodi
        '
        Me.PanelScanCodi.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelScanCodi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelScanCodi.Controls.Add(Me.buttonCancelSearch)
        Me.PanelScanCodi.Controls.Add(Me.buttonSearchCode)
        Me.PanelScanCodi.Controls.Add(Me.picCodiBarres)
        Me.PanelScanCodi.Controls.Add(Me.txtCodiBarres)
        Me.PanelScanCodi.Controls.Add(Me.lbScandCode)
        Me.PanelScanCodi.Controls.Add(Me.Label69)
        Me.PanelScanCodi.Controls.Add(Me.ButtonHide)
        Me.PanelScanCodi.Location = New System.Drawing.Point(41, 11)
        Me.PanelScanCodi.Name = "PanelScanCodi"
        Me.PanelScanCodi.Size = New System.Drawing.Size(382, 278)
        Me.PanelScanCodi.TabIndex = 245
        Me.PanelScanCodi.Visible = False
        '
        'buttonCancelSearch
        '
        Me.buttonCancelSearch.ActiveControl = Nothing
        Me.buttonCancelSearch.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.buttonCancelSearch.Location = New System.Drawing.Point(50, 197)
        Me.buttonCancelSearch.Name = "buttonCancelSearch"
        Me.buttonCancelSearch.Size = New System.Drawing.Size(124, 43)
        Me.buttonCancelSearch.TabIndex = 254
        Me.buttonCancelSearch.TileImage = CType(resources.GetObject("buttonCancelSearch.TileImage"), System.Drawing.Image)
        Me.buttonCancelSearch.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.buttonCancelSearch.UseSelectable = True
        Me.buttonCancelSearch.UseTileImage = True
        '
        'buttonSearchCode
        '
        Me.buttonSearchCode.ActiveControl = Nothing
        Me.buttonSearchCode.Location = New System.Drawing.Point(180, 197)
        Me.buttonSearchCode.Name = "buttonSearchCode"
        Me.buttonSearchCode.Size = New System.Drawing.Size(163, 43)
        Me.buttonSearchCode.TabIndex = 253
        Me.buttonSearchCode.TileImage = CType(resources.GetObject("buttonSearchCode.TileImage"), System.Drawing.Image)
        Me.buttonSearchCode.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.buttonSearchCode.UseSelectable = True
        Me.buttonSearchCode.UseTileImage = True
        '
        'picCodiBarres
        '
        Me.picCodiBarres.Location = New System.Drawing.Point(50, 116)
        Me.picCodiBarres.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picCodiBarres.Name = "picCodiBarres"
        Me.picCodiBarres.Size = New System.Drawing.Size(294, 64)
        Me.picCodiBarres.TabIndex = 252
        Me.picCodiBarres.TabStop = False
        '
        'txtCodiBarres
        '
        Me.txtCodiBarres.Location = New System.Drawing.Point(50, 70)
        Me.txtCodiBarres.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCodiBarres.Name = "txtCodiBarres"
        Me.txtCodiBarres.Size = New System.Drawing.Size(293, 25)
        Me.txtCodiBarres.TabIndex = 251
        '
        'lbScandCode
        '
        Me.lbScandCode.AutoSize = True
        Me.lbScandCode.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lbScandCode.Location = New System.Drawing.Point(50, 35)
        Me.lbScandCode.Name = "lbScandCode"
        Me.lbScandCode.Size = New System.Drawing.Size(151, 25)
        Me.lbScandCode.TabIndex = 250
        Me.lbScandCode.Text = "Passa l'escanner ..."
        '
        'Label69
        '
        Me.Label69.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Label69.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label69.Location = New System.Drawing.Point(-1, 0)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(411, 6)
        Me.Label69.TabIndex = 14
        '
        'ButtonHide
        '
        Me.ButtonHide.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonHide.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonHide.Image = CType(resources.GetObject("ButtonHide.Image"), System.Drawing.Image)
        Me.ButtonHide.ImageSize = 32
        Me.ButtonHide.Location = New System.Drawing.Point(335, 5)
        Me.ButtonHide.Name = "ButtonHide"
        Me.ButtonHide.Size = New System.Drawing.Size(40, 42)
        Me.ButtonHide.TabIndex = 13
        Me.ButtonHide.UseSelectable = True
        '
        'frmBuscarDiscos
        '
        Me.AcceptButton = Me.cmdBuscar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CmdTancar
        Me.ClientSize = New System.Drawing.Size(464, 300)
        Me.Controls.Add(Me.PanelScanCodi)
        Me.Controls.Add(Me.cmdSortir)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboEstil)
        Me.Controls.Add(Me.CmdTancar)
        Me.Controls.Add(Me.ComboInterp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNomDisc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.fraAvanç)
        Me.Controls.Add(Me.chkAddResult)
        Me.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(464, 300)
        Me.Name = "frmBuscarDiscos"
        Me.Padding = New System.Windows.Forms.Padding(23, 78, 23, 26)
        Me.Resizable = False
        Me.Text = "Buscar disc ..."
        Me.Panel1.ResumeLayout(False)
        Me.fraAvanç.ResumeLayout(False)
        Me.fraAvanç.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.PanelScanCodi.ResumeLayout(False)
        Me.PanelScanCodi.PerformLayout()
        CType(Me.picCodiBarres, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents chkAddResult As System.Windows.Forms.CheckBox
    Friend WithEvents fraAvanç As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNomDisc As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboInterp As System.Windows.Forms.ComboBox
    Friend WithEvents ComboEstil As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ComboCia As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtEstant As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ComboProveidor As System.Windows.Forms.ComboBox
    Friend WithEvents txtAnyPubli As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdMoreFind As MetroFramework.Controls.MetroTile
    Friend WithEvents cmdAddCodiBar As MetroFramework.Controls.MetroTile
    Friend WithEvents cmdBuscar As MetroFramework.Controls.MetroTile
    Friend WithEvents CmdTancar As MetroFramework.Controls.MetroTile
    Friend WithEvents cmdSortir As MetroFramework.Controls.MetroLink
    Friend WithEvents ChkIgnoreFormat As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents optAltres As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents optVinil As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents optK7 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents optMP3 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents optCD As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents PanelScanCodi As Panel
    Friend WithEvents lbScandCode As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label69 As Label
    Friend WithEvents ButtonHide As MetroFramework.Controls.MetroLink
    Friend WithEvents buttonCancelSearch As MetroFramework.Controls.MetroTile
    Friend WithEvents buttonSearchCode As MetroFramework.Controls.MetroTile
    Friend WithEvents picCodiBarres As PictureBox
    Friend WithEvents txtCodiBarres As TextBox
End Class
