<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPubli
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPubli))
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
        Me.cmdAssistBlocs = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.cmdBuscar = New System.Windows.Forms.ToolStripButton()
        Me.cmdSortir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.lbVuMeter = New System.Windows.Forms.ToolStripLabel()
        Me.lbAtencio = New System.Windows.Forms.ToolStripLabel()
        Me.cmdStop = New System.Windows.Forms.ToolStripButton()
        Me.cmdPlay = New System.Windows.Forms.ToolStripButton()
        Me.lbNou = New System.Windows.Forms.ToolStripLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProgarmaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReproductorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPlay = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStop = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuCalcDurada = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFinal = New System.Windows.Forms.ToolStripMenuItem()
        Me.EdicióToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModif = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDel = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditAudio = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuBuscar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_Help = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.TabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.gridDades = New MetroFramework.Controls.MetroGrid()
        Me.ColumnID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnNom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComboGridClient = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ComboGridProducte = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ColumnMarca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComboGridTarifa = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ColumnComent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnDurada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnDataCrea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnNumRadi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnDataIn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnDataOut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComboGridTecnic = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ComboGridLocutor = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ColumnActiva = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ColumnValida = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ColumnFacturada = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ColumnPropia = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ColumnDataRadi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.TabCtlDies = New MetroFramework.Controls.MetroTabControl()
        Me.TabPage3 = New MetroFramework.Controls.MetroTabPage()
        Me.PanelDia = New System.Windows.Forms.Panel()
        Me.PanelFrH = New System.Windows.Forms.Panel()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.PanelBlocs = New System.Windows.Forms.Panel()
        Me.CheckBox96 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox95 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox94 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox93 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox92 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox91 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox90 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox89 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox88 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox87 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox86 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox85 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox84 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox83 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox82 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox81 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox80 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox79 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox78 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox77 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox76 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox75 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox74 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox73 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox72 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox71 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox70 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox69 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox68 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox67 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox66 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox65 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox64 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox63 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox62 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox61 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox60 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox59 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox58 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox57 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox56 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox55 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox54 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox53 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox52 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox51 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox50 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox49 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox48 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox47 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox46 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox45 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox44 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox43 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox42 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox41 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox40 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox39 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox38 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox37 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox36 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox35 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox34 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox33 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox32 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox31 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox30 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox29 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox28 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox27 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox26 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox25 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox24 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox23 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox22 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox21 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox20 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox19 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox18 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox17 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox16 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox15 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox14 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox13 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox12 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox11 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox10 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox9 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox8 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox7 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox6 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox5 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox4 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox3 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox2 = New MetroFramework.Controls.MetroCheckBox()
        Me.CheckBox1 = New MetroFramework.Controls.MetroCheckBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.picPlay = New System.Windows.Forms.PictureBox()
        Me.picPause = New System.Windows.Forms.PictureBox()
        Me.picLock = New System.Windows.Forms.PictureBox()
        Me.picUnLock = New System.Windows.Forms.PictureBox()
        Me.txtDataOut = New MetroFramework.Controls.MetroDateTime()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.txtDataIn = New MetroFramework.Controls.MetroDateTime()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbNRadia = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ComboLocutor = New System.Windows.Forms.ComboBox()
        Me.lbLocutor = New System.Windows.Forms.LinkLabel()
        Me.ComboTecnic = New System.Windows.Forms.ComboBox()
        Me.lbTecnic = New System.Windows.Forms.LinkLabel()
        Me.chkPropia = New MetroFramework.Controls.MetroCheckBox()
        Me.chkFactura = New MetroFramework.Controls.MetroCheckBox()
        Me.chkValida = New MetroFramework.Controls.MetroCheckBox()
        Me.chkActive = New MetroFramework.Controls.MetroCheckBox()
        Me.lbDataCrea = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbID = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboTarifes = New System.Windows.Forms.ComboBox()
        Me.cbTarifa = New System.Windows.Forms.LinkLabel()
        Me.txtComent = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbDurada = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboProducte = New System.Windows.Forms.ComboBox()
        Me.lbProducte = New System.Windows.Forms.LinkLabel()
        Me.ComboClient = New System.Windows.Forms.ComboBox()
        Me.lbClient = New System.Windows.Forms.LinkLabel()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.picVuMeter = New System.Windows.Forms.PictureBox()
        Me.tmrDetalls = New System.Windows.Forms.Timer(Me.components)
        Me.tmrPlayer = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelAssistent = New System.Windows.Forms.Panel()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.ButtonHideAssist = New MetroFramework.Controls.MetroLink()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.chk_Hores_all = New MetroFramework.Controls.MetroCheckBox()
        Me.chk_DiesAll = New MetroFramework.Controls.MetroCheckBox()
        Me.cmdCalc = New MetroFramework.Controls.MetroTile()
        Me.chkRespect = New MetroFramework.Controls.MetroCheckBox()
        Me.txtMaxPubliDia = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumRadi = New System.Windows.Forms.TextBox()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.lstHoresDisp = New System.Windows.Forms.CheckedListBox()
        Me.lstDiesDisp = New System.Windows.Forms.CheckedListBox()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.buttonNovaPlantilla = New System.Windows.Forms.Button()
        Me.buttonExecutaPlantilla = New MetroFramework.Controls.MetroTile()
        Me.chkRespectTemplates = New MetroFramework.Controls.MetroCheckBox()
        Me.groupBoxEditPlantilla = New System.Windows.Forms.GroupBox()
        Me.buttonEsborrarPlantilla = New System.Windows.Forms.Button()
        Me.buttonEditarPlantilla = New System.Windows.Forms.Button()
        Me.lbNomPlantilla = New System.Windows.Forms.Label()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.comboBoxPlantillesPubli = New System.Windows.Forms.ComboBox()
        Me.PanelSearchPubli = New System.Windows.Forms.Panel()
        Me.lbTitleSearch = New MetroFramework.Controls.MetroLabel()
        Me.chkActual = New MetroFramework.Controls.MetroCheckBox()
        Me.chkPropiaSearch = New MetroFramework.Controls.MetroCheckBox()
        Me.chkFacturaSearch = New MetroFramework.Controls.MetroCheckBox()
        Me.chkValidaSearch = New MetroFramework.Controls.MetroCheckBox()
        Me.chkActiveSearch = New MetroFramework.Controls.MetroCheckBox()
        Me.ButtonSearch = New MetroFramework.Controls.MetroTile()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.txtMarcaSearch = New System.Windows.Forms.TextBox()
        Me.ComboProducSearch = New System.Windows.Forms.ComboBox()
        Me.ComboClientSearch = New System.Windows.Forms.ComboBox()
        Me.txtNomSearch = New System.Windows.Forms.TextBox()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.ButtonHideSearch = New MetroFramework.Controls.MetroLink()
        Me.pic_logo = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.gridDades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabCtlDies.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.PanelDia.SuspendLayout()
        Me.PanelFrH.SuspendLayout()
        Me.PanelBlocs.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.picPlay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPause, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUnLock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picVuMeter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelAssistent.SuspendLayout()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        Me.MetroTabPage2.SuspendLayout()
        Me.groupBoxEditPlantilla.SuspendLayout()
        Me.PanelSearchPubli.SuspendLayout()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdPrimer, Me.cmdPrevi, Me.cmdSeguent, Me.cmdUltim, Me.lbPosition, Me.ToolStripLabel1, Me.lbRecCount, Me.ToolStripSeparator1, Me.cmdNou, Me.cmdBloqueix, Me.cmdBorrar, Me.cmdSalvar, Me.cmdAssistBlocs, Me.ToolStripSeparator6, Me.cmdRefrescar, Me.cmdBuscar, Me.cmdSortir, Me.ToolStripSeparator5, Me.ToolStripSeparator2, Me.lbVuMeter, Me.lbAtencio, Me.cmdStop, Me.cmdPlay, Me.lbNou})
        Me.ToolStrip1.Location = New System.Drawing.Point(23, 78)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(946, 39)
        Me.ToolStrip1.TabIndex = 160
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
        Me.cmdBloqueix.Text = "Bloquejar"
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
        'cmdAssistBlocs
        '
        Me.cmdAssistBlocs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAssistBlocs.Enabled = False
        Me.cmdAssistBlocs.Image = CType(resources.GetObject("cmdAssistBlocs.Image"), System.Drawing.Image)
        Me.cmdAssistBlocs.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAssistBlocs.Name = "cmdAssistBlocs"
        Me.cmdAssistBlocs.Size = New System.Drawing.Size(36, 36)
        Me.cmdAssistBlocs.Text = "Assistent d'assignació"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 39)
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
        'cmdBuscar
        '
        Me.cmdBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdBuscar.Image = CType(resources.GetObject("cmdBuscar.Image"), System.Drawing.Image)
        Me.cmdBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(36, 36)
        Me.cmdBuscar.Text = "Buscar"
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
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(0, 36)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'lbVuMeter
        '
        Me.lbVuMeter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lbVuMeter.AutoSize = False
        Me.lbVuMeter.Name = "lbVuMeter"
        Me.lbVuMeter.Size = New System.Drawing.Size(100, 36)
        '
        'lbAtencio
        '
        Me.lbAtencio.Image = CType(resources.GetObject("lbAtencio.Image"), System.Drawing.Image)
        Me.lbAtencio.Name = "lbAtencio"
        Me.lbAtencio.Size = New System.Drawing.Size(97, 36)
        Me.lbAtencio.Text = "No existeix"
        Me.lbAtencio.Visible = False
        '
        'cmdStop
        '
        Me.cmdStop.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.cmdStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdStop.Image = CType(resources.GetObject("cmdStop.Image"), System.Drawing.Image)
        Me.cmdStop.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdStop.Name = "cmdStop"
        Me.cmdStop.Size = New System.Drawing.Size(36, 36)
        Me.cmdStop.Text = "Stop"
        '
        'cmdPlay
        '
        Me.cmdPlay.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.cmdPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdPlay.Image = CType(resources.GetObject("cmdPlay.Image"), System.Drawing.Image)
        Me.cmdPlay.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPlay.Name = "cmdPlay"
        Me.cmdPlay.Size = New System.Drawing.Size(36, 36)
        Me.cmdPlay.Text = "Play/Pausa"
        '
        'lbNou
        '
        Me.lbNou.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNou.ForeColor = System.Drawing.Color.Red
        Me.lbNou.Name = "lbNou"
        Me.lbNou.Size = New System.Drawing.Size(67, 36)
        Me.lbNou.Text = "NOU"
        Me.lbNou.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgarmaToolStripMenuItem, Me.ReproductorToolStripMenuItem, Me.EdicióToolStripMenuItem, Me.AjudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(641, 30)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(330, 26)
        Me.MenuStrip1.TabIndex = 159
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
        Me.ReproductorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPlay, Me.mnuStop, Me.ToolStripSeparator3, Me.mnuCalcDurada, Me.mnuFinal})
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
        Me.mnuPlay.Size = New System.Drawing.Size(204, 22)
        Me.mnuPlay.Tag = "1"
        Me.mnuPlay.Text = "Play/Pausa"
        '
        'mnuStop
        '
        Me.mnuStop.Image = CType(resources.GetObject("mnuStop.Image"), System.Drawing.Image)
        Me.mnuStop.Name = "mnuStop"
        Me.mnuStop.ShortcutKeys = System.Windows.Forms.Keys.F7
        Me.mnuStop.Size = New System.Drawing.Size(204, 22)
        Me.mnuStop.Tag = "2"
        Me.mnuStop.Text = "Stop"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(201, 6)
        '
        'mnuCalcDurada
        '
        Me.mnuCalcDurada.Enabled = False
        Me.mnuCalcDurada.Name = "mnuCalcDurada"
        Me.mnuCalcDurada.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F7), System.Windows.Forms.Keys)
        Me.mnuCalcDurada.Size = New System.Drawing.Size(204, 22)
        Me.mnuCalcDurada.Tag = "3"
        Me.mnuCalcDurada.Text = "Calcular Durada"
        '
        'mnuFinal
        '
        Me.mnuFinal.Name = "mnuFinal"
        Me.mnuFinal.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F9), System.Windows.Forms.Keys)
        Me.mnuFinal.Size = New System.Drawing.Size(204, 22)
        Me.mnuFinal.Tag = "4"
        Me.mnuFinal.Text = "Final Tema"
        '
        'EdicióToolStripMenuItem
        '
        Me.EdicióToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuModif, Me.mnuSave, Me.mnuNew, Me.mnuDel, Me.mnuEditAudio, Me.ToolStripSeparator4, Me.mnuBuscar, Me.mnuRefresh})
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
        Me.mnuModif.Size = New System.Drawing.Size(183, 22)
        Me.mnuModif.Text = "Modificar"
        '
        'mnuSave
        '
        Me.mnuSave.Enabled = False
        Me.mnuSave.Name = "mnuSave"
        Me.mnuSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuSave.Size = New System.Drawing.Size(183, 22)
        Me.mnuSave.Text = "Salvar"
        '
        'mnuNew
        '
        Me.mnuNew.Image = CType(resources.GetObject("mnuNew.Image"), System.Drawing.Image)
        Me.mnuNew.Name = "mnuNew"
        Me.mnuNew.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.mnuNew.Size = New System.Drawing.Size(183, 22)
        Me.mnuNew.Text = "Nou"
        '
        'mnuDel
        '
        Me.mnuDel.Enabled = False
        Me.mnuDel.Image = CType(resources.GetObject("mnuDel.Image"), System.Drawing.Image)
        Me.mnuDel.Name = "mnuDel"
        Me.mnuDel.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.mnuDel.Size = New System.Drawing.Size(183, 22)
        Me.mnuDel.Text = "Borrar"
        '
        'mnuEditAudio
        '
        Me.mnuEditAudio.Enabled = False
        Me.mnuEditAudio.Name = "mnuEditAudio"
        Me.mnuEditAudio.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.mnuEditAudio.Size = New System.Drawing.Size(183, 22)
        Me.mnuEditAudio.Text = "Editar l'àudio"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(180, 6)
        '
        'mnuBuscar
        '
        Me.mnuBuscar.Image = CType(resources.GetObject("mnuBuscar.Image"), System.Drawing.Image)
        Me.mnuBuscar.Name = "mnuBuscar"
        Me.mnuBuscar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.mnuBuscar.Size = New System.Drawing.Size(183, 22)
        Me.mnuBuscar.Text = "Buscar"
        '
        'mnuRefresh
        '
        Me.mnuRefresh.Image = CType(resources.GetObject("mnuRefresh.Image"), System.Drawing.Image)
        Me.mnuRefresh.Name = "mnuRefresh"
        Me.mnuRefresh.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.mnuRefresh.Size = New System.Drawing.Size(183, 22)
        Me.mnuRefresh.Text = "Refrescar"
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
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(26, 330)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(943, 222)
        Me.TabControl1.TabIndex = 180
        Me.TabControl1.UseSelectable = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.gridDades)
        Me.TabPage1.HorizontalScrollbarBarColor = True
        Me.TabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.TabPage1.HorizontalScrollbarSize = 2
        Me.TabPage1.Location = New System.Drawing.Point(4, 38)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage1.Size = New System.Drawing.Size(935, 180)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Llistat de falques"
        Me.TabPage1.UseVisualStyleBackColor = True
        Me.TabPage1.VerticalScrollbarBarColor = True
        Me.TabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.TabPage1.VerticalScrollbarSize = 3
        '
        'gridDades
        '
        Me.gridDades.AllowUserToAddRows = False
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
        Me.gridDades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnID, Me.ColumnNom, Me.ComboGridClient, Me.ComboGridProducte, Me.ColumnMarca, Me.ComboGridTarifa, Me.ColumnComent, Me.ColumnDurada, Me.ColumnDataCrea, Me.ColumnNumRadi, Me.ColumnDataIn, Me.ColumnDataOut, Me.ComboGridTecnic, Me.ComboGridLocutor, Me.ColumnActiva, Me.ColumnValida, Me.ColumnFacturada, Me.ColumnPropia, Me.ColumnDataRadi})
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
        Me.gridDades.Location = New System.Drawing.Point(3, 4)
        Me.gridDades.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gridDades.Name = "gridDades"
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
        Me.gridDades.Size = New System.Drawing.Size(929, 172)
        Me.gridDades.TabIndex = 1
        '
        'ColumnID
        '
        Me.ColumnID.DataPropertyName = "falc_id"
        Me.ColumnID.HeaderText = "ID"
        Me.ColumnID.Name = "ColumnID"
        Me.ColumnID.ReadOnly = True
        '
        'ColumnNom
        '
        Me.ColumnNom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnNom.DataPropertyName = "falc_nom"
        Me.ColumnNom.HeaderText = "Nom"
        Me.ColumnNom.Name = "ColumnNom"
        Me.ColumnNom.ReadOnly = True
        '
        'ComboGridClient
        '
        Me.ComboGridClient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ComboGridClient.DataPropertyName = "falc_client"
        Me.ComboGridClient.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.ComboGridClient.HeaderText = "Client"
        Me.ComboGridClient.Name = "ComboGridClient"
        Me.ComboGridClient.ReadOnly = True
        '
        'ComboGridProducte
        '
        Me.ComboGridProducte.DataPropertyName = "falc_producte"
        Me.ComboGridProducte.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.ComboGridProducte.HeaderText = "Producte"
        Me.ComboGridProducte.Name = "ComboGridProducte"
        Me.ComboGridProducte.ReadOnly = True
        Me.ComboGridProducte.Visible = False
        '
        'ColumnMarca
        '
        Me.ColumnMarca.DataPropertyName = "falc_marca"
        Me.ColumnMarca.HeaderText = "Marca"
        Me.ColumnMarca.Name = "ColumnMarca"
        Me.ColumnMarca.ReadOnly = True
        Me.ColumnMarca.Visible = False
        '
        'ComboGridTarifa
        '
        Me.ComboGridTarifa.DataPropertyName = "falc_tarifa"
        Me.ComboGridTarifa.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.ComboGridTarifa.HeaderText = "Tarifa"
        Me.ComboGridTarifa.Name = "ComboGridTarifa"
        Me.ComboGridTarifa.ReadOnly = True
        Me.ComboGridTarifa.Visible = False
        '
        'ColumnComent
        '
        Me.ColumnComent.DataPropertyName = "falc_observ"
        Me.ColumnComent.HeaderText = "Comentàri"
        Me.ColumnComent.Name = "ColumnComent"
        Me.ColumnComent.ReadOnly = True
        Me.ColumnComent.Visible = False
        '
        'ColumnDurada
        '
        Me.ColumnDurada.DataPropertyName = "falc_durada"
        Me.ColumnDurada.HeaderText = "Durada"
        Me.ColumnDurada.Name = "ColumnDurada"
        Me.ColumnDurada.ReadOnly = True
        Me.ColumnDurada.Visible = False
        '
        'ColumnDataCrea
        '
        Me.ColumnDataCrea.DataPropertyName = "falc_datacreacio"
        Me.ColumnDataCrea.HeaderText = "Data Creació"
        Me.ColumnDataCrea.Name = "ColumnDataCrea"
        Me.ColumnDataCrea.ReadOnly = True
        Me.ColumnDataCrea.Visible = False
        '
        'ColumnNumRadi
        '
        Me.ColumnNumRadi.DataPropertyName = "falc_nradia"
        Me.ColumnNumRadi.HeaderText = "Núm. Radiacions"
        Me.ColumnNumRadi.Name = "ColumnNumRadi"
        Me.ColumnNumRadi.ReadOnly = True
        Me.ColumnNumRadi.Visible = False
        '
        'ColumnDataIn
        '
        Me.ColumnDataIn.DataPropertyName = "falc_datain"
        Me.ColumnDataIn.HeaderText = "Data In"
        Me.ColumnDataIn.Name = "ColumnDataIn"
        Me.ColumnDataIn.ReadOnly = True
        Me.ColumnDataIn.Visible = False
        '
        'ColumnDataOut
        '
        Me.ColumnDataOut.DataPropertyName = "falc_dataout"
        Me.ColumnDataOut.HeaderText = "Data Out"
        Me.ColumnDataOut.Name = "ColumnDataOut"
        Me.ColumnDataOut.ReadOnly = True
        Me.ColumnDataOut.Visible = False
        '
        'ComboGridTecnic
        '
        Me.ComboGridTecnic.DataPropertyName = "falc_tecnic"
        Me.ComboGridTecnic.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.ComboGridTecnic.HeaderText = "Tècnic"
        Me.ComboGridTecnic.Name = "ComboGridTecnic"
        Me.ComboGridTecnic.ReadOnly = True
        Me.ComboGridTecnic.Visible = False
        '
        'ComboGridLocutor
        '
        Me.ComboGridLocutor.DataPropertyName = "falc_locutor"
        Me.ComboGridLocutor.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.ComboGridLocutor.HeaderText = "Locutor"
        Me.ComboGridLocutor.Name = "ComboGridLocutor"
        Me.ComboGridLocutor.ReadOnly = True
        Me.ComboGridLocutor.Visible = False
        '
        'ColumnActiva
        '
        Me.ColumnActiva.DataPropertyName = "falc_activa"
        Me.ColumnActiva.HeaderText = "Activa"
        Me.ColumnActiva.Name = "ColumnActiva"
        Me.ColumnActiva.ReadOnly = True
        Me.ColumnActiva.Visible = False
        '
        'ColumnValida
        '
        Me.ColumnValida.DataPropertyName = "falc_valida"
        Me.ColumnValida.HeaderText = "Vàlida"
        Me.ColumnValida.Name = "ColumnValida"
        Me.ColumnValida.ReadOnly = True
        Me.ColumnValida.Visible = False
        '
        'ColumnFacturada
        '
        Me.ColumnFacturada.DataPropertyName = "falc_facturada"
        Me.ColumnFacturada.HeaderText = "facturada"
        Me.ColumnFacturada.Name = "ColumnFacturada"
        Me.ColumnFacturada.ReadOnly = True
        Me.ColumnFacturada.Visible = False
        '
        'ColumnPropia
        '
        Me.ColumnPropia.DataPropertyName = "falc_propia"
        Me.ColumnPropia.HeaderText = "Pròpia"
        Me.ColumnPropia.Name = "ColumnPropia"
        Me.ColumnPropia.ReadOnly = True
        Me.ColumnPropia.Visible = False
        '
        'ColumnDataRadi
        '
        Me.ColumnDataRadi.DataPropertyName = "falc_dataradi"
        Me.ColumnDataRadi.HeaderText = "Data Radiació"
        Me.ColumnDataRadi.Name = "ColumnDataRadi"
        Me.ColumnDataRadi.ReadOnly = True
        Me.ColumnDataRadi.Visible = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TabCtlDies)
        Me.TabPage2.HorizontalScrollbarBarColor = True
        Me.TabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.TabPage2.HorizontalScrollbarSize = 2
        Me.TabPage2.Location = New System.Drawing.Point(4, 38)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage2.Size = New System.Drawing.Size(935, 180)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Detall blocs a radiar"
        Me.TabPage2.UseVisualStyleBackColor = True
        Me.TabPage2.VerticalScrollbarBarColor = True
        Me.TabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.TabPage2.VerticalScrollbarSize = 3
        '
        'TabCtlDies
        '
        Me.TabCtlDies.Controls.Add(Me.TabPage3)
        Me.TabCtlDies.Controls.Add(Me.TabPage4)
        Me.TabCtlDies.Controls.Add(Me.TabPage5)
        Me.TabCtlDies.Controls.Add(Me.TabPage6)
        Me.TabCtlDies.Controls.Add(Me.TabPage7)
        Me.TabCtlDies.Controls.Add(Me.TabPage8)
        Me.TabCtlDies.Controls.Add(Me.TabPage9)
        Me.TabCtlDies.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabCtlDies.Location = New System.Drawing.Point(3, 4)
        Me.TabCtlDies.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabCtlDies.Name = "TabCtlDies"
        Me.TabCtlDies.SelectedIndex = 0
        Me.TabCtlDies.Size = New System.Drawing.Size(929, 172)
        Me.TabCtlDies.TabIndex = 0
        Me.TabCtlDies.UseSelectable = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.PanelDia)
        Me.TabPage3.HorizontalScrollbarBarColor = True
        Me.TabPage3.HorizontalScrollbarHighlightOnWheel = False
        Me.TabPage3.HorizontalScrollbarSize = 2
        Me.TabPage3.Location = New System.Drawing.Point(4, 38)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage3.Size = New System.Drawing.Size(921, 130)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Dilluns"
        Me.TabPage3.UseVisualStyleBackColor = True
        Me.TabPage3.VerticalScrollbarBarColor = True
        Me.TabPage3.VerticalScrollbarHighlightOnWheel = False
        Me.TabPage3.VerticalScrollbarSize = 3
        '
        'PanelDia
        '
        Me.PanelDia.Controls.Add(Me.PanelFrH)
        Me.PanelDia.Controls.Add(Me.Label38)
        Me.PanelDia.Controls.Add(Me.PanelBlocs)
        Me.PanelDia.Controls.Add(Me.Label39)
        Me.PanelDia.Controls.Add(Me.Label37)
        Me.PanelDia.Controls.Add(Me.Label36)
        Me.PanelDia.Controls.Add(Me.Label35)
        Me.PanelDia.Controls.Add(Me.Label34)
        Me.PanelDia.Controls.Add(Me.Label33)
        Me.PanelDia.Controls.Add(Me.Label32)
        Me.PanelDia.Controls.Add(Me.Label31)
        Me.PanelDia.Controls.Add(Me.Label30)
        Me.PanelDia.Controls.Add(Me.Label29)
        Me.PanelDia.Controls.Add(Me.Label28)
        Me.PanelDia.Controls.Add(Me.Label27)
        Me.PanelDia.Controls.Add(Me.Label26)
        Me.PanelDia.Controls.Add(Me.Label25)
        Me.PanelDia.Controls.Add(Me.Label24)
        Me.PanelDia.Controls.Add(Me.Label23)
        Me.PanelDia.Controls.Add(Me.Label22)
        Me.PanelDia.Controls.Add(Me.Label21)
        Me.PanelDia.Controls.Add(Me.Label20)
        Me.PanelDia.Controls.Add(Me.Label19)
        Me.PanelDia.Controls.Add(Me.Label18)
        Me.PanelDia.Controls.Add(Me.Label17)
        Me.PanelDia.Controls.Add(Me.Label16)
        Me.PanelDia.Controls.Add(Me.Label15)
        Me.PanelDia.Controls.Add(Me.Label14)
        Me.PanelDia.Controls.Add(Me.Label13)
        Me.PanelDia.Controls.Add(Me.Label12)
        Me.PanelDia.Controls.Add(Me.Label11)
        Me.PanelDia.Controls.Add(Me.Label10)
        Me.PanelDia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDia.Enabled = False
        Me.PanelDia.Location = New System.Drawing.Point(3, 4)
        Me.PanelDia.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelDia.Name = "PanelDia"
        Me.PanelDia.Size = New System.Drawing.Size(915, 122)
        Me.PanelDia.TabIndex = 0
        '
        'PanelFrH
        '
        Me.PanelFrH.Controls.Add(Me.Label63)
        Me.PanelFrH.Controls.Add(Me.Label62)
        Me.PanelFrH.Controls.Add(Me.Label61)
        Me.PanelFrH.Controls.Add(Me.Label60)
        Me.PanelFrH.Controls.Add(Me.Label59)
        Me.PanelFrH.Controls.Add(Me.Label58)
        Me.PanelFrH.Controls.Add(Me.Label57)
        Me.PanelFrH.Controls.Add(Me.Label56)
        Me.PanelFrH.Controls.Add(Me.Label55)
        Me.PanelFrH.Controls.Add(Me.Label54)
        Me.PanelFrH.Controls.Add(Me.Label53)
        Me.PanelFrH.Controls.Add(Me.Label52)
        Me.PanelFrH.Controls.Add(Me.Label51)
        Me.PanelFrH.Controls.Add(Me.Label50)
        Me.PanelFrH.Controls.Add(Me.Label49)
        Me.PanelFrH.Controls.Add(Me.Label48)
        Me.PanelFrH.Controls.Add(Me.Label47)
        Me.PanelFrH.Controls.Add(Me.Label46)
        Me.PanelFrH.Controls.Add(Me.Label45)
        Me.PanelFrH.Controls.Add(Me.Label44)
        Me.PanelFrH.Controls.Add(Me.Label43)
        Me.PanelFrH.Controls.Add(Me.Label42)
        Me.PanelFrH.Controls.Add(Me.Label41)
        Me.PanelFrH.Controls.Add(Me.Label40)
        Me.PanelFrH.Location = New System.Drawing.Point(23, 167)
        Me.PanelFrH.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelFrH.Name = "PanelFrH"
        Me.PanelFrH.Size = New System.Drawing.Size(834, 20)
        Me.PanelFrH.TabIndex = 63
        '
        'Label63
        '
        Me.Label63.BackColor = System.Drawing.Color.Red
        Me.Label63.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label63.Location = New System.Drawing.Point(782, 3)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(25, 10)
        Me.Label63.TabIndex = 23
        '
        'Label62
        '
        Me.Label62.BackColor = System.Drawing.Color.Red
        Me.Label62.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label62.Location = New System.Drawing.Point(747, 3)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(25, 10)
        Me.Label62.TabIndex = 22
        '
        'Label61
        '
        Me.Label61.BackColor = System.Drawing.Color.Red
        Me.Label61.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label61.Location = New System.Drawing.Point(713, 3)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(25, 10)
        Me.Label61.TabIndex = 21
        '
        'Label60
        '
        Me.Label60.BackColor = System.Drawing.Color.Red
        Me.Label60.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label60.Location = New System.Drawing.Point(679, 3)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(25, 10)
        Me.Label60.TabIndex = 20
        '
        'Label59
        '
        Me.Label59.BackColor = System.Drawing.Color.Red
        Me.Label59.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label59.Location = New System.Drawing.Point(645, 3)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(25, 10)
        Me.Label59.TabIndex = 19
        '
        'Label58
        '
        Me.Label58.BackColor = System.Drawing.Color.Red
        Me.Label58.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label58.Location = New System.Drawing.Point(609, 3)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(25, 10)
        Me.Label58.TabIndex = 18
        '
        'Label57
        '
        Me.Label57.BackColor = System.Drawing.Color.Red
        Me.Label57.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label57.Location = New System.Drawing.Point(575, 3)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(25, 10)
        Me.Label57.TabIndex = 17
        '
        'Label56
        '
        Me.Label56.BackColor = System.Drawing.Color.Red
        Me.Label56.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label56.Location = New System.Drawing.Point(542, 3)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(25, 10)
        Me.Label56.TabIndex = 16
        '
        'Label55
        '
        Me.Label55.BackColor = System.Drawing.Color.Red
        Me.Label55.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label55.Location = New System.Drawing.Point(512, 3)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(25, 10)
        Me.Label55.TabIndex = 15
        '
        'Label54
        '
        Me.Label54.BackColor = System.Drawing.Color.Red
        Me.Label54.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label54.Location = New System.Drawing.Point(476, 3)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(25, 10)
        Me.Label54.TabIndex = 14
        '
        'Label53
        '
        Me.Label53.BackColor = System.Drawing.Color.Red
        Me.Label53.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label53.Location = New System.Drawing.Point(441, 3)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(25, 10)
        Me.Label53.TabIndex = 13
        '
        'Label52
        '
        Me.Label52.BackColor = System.Drawing.Color.Red
        Me.Label52.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label52.Location = New System.Drawing.Point(408, 3)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(25, 10)
        Me.Label52.TabIndex = 12
        '
        'Label51
        '
        Me.Label51.BackColor = System.Drawing.Color.Red
        Me.Label51.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label51.Location = New System.Drawing.Point(374, 3)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(25, 10)
        Me.Label51.TabIndex = 11
        '
        'Label50
        '
        Me.Label50.BackColor = System.Drawing.Color.Red
        Me.Label50.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label50.Location = New System.Drawing.Point(342, 3)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(25, 10)
        Me.Label50.TabIndex = 10
        '
        'Label49
        '
        Me.Label49.BackColor = System.Drawing.Color.Red
        Me.Label49.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label49.Location = New System.Drawing.Point(307, 3)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(25, 10)
        Me.Label49.TabIndex = 9
        '
        'Label48
        '
        Me.Label48.BackColor = System.Drawing.Color.Red
        Me.Label48.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label48.Location = New System.Drawing.Point(273, 3)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(25, 10)
        Me.Label48.TabIndex = 8
        '
        'Label47
        '
        Me.Label47.BackColor = System.Drawing.Color.Red
        Me.Label47.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label47.Location = New System.Drawing.Point(239, 3)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(25, 10)
        Me.Label47.TabIndex = 7
        '
        'Label46
        '
        Me.Label46.BackColor = System.Drawing.Color.Red
        Me.Label46.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label46.Location = New System.Drawing.Point(205, 3)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(25, 10)
        Me.Label46.TabIndex = 6
        '
        'Label45
        '
        Me.Label45.BackColor = System.Drawing.Color.Red
        Me.Label45.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label45.Location = New System.Drawing.Point(171, 3)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(25, 10)
        Me.Label45.TabIndex = 5
        '
        'Label44
        '
        Me.Label44.BackColor = System.Drawing.Color.Red
        Me.Label44.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label44.Location = New System.Drawing.Point(139, 3)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(25, 10)
        Me.Label44.TabIndex = 4
        '
        'Label43
        '
        Me.Label43.BackColor = System.Drawing.Color.Red
        Me.Label43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label43.Location = New System.Drawing.Point(105, 3)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(25, 10)
        Me.Label43.TabIndex = 3
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.Color.Red
        Me.Label42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label42.Location = New System.Drawing.Point(71, 3)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(25, 10)
        Me.Label42.TabIndex = 2
        '
        'Label41
        '
        Me.Label41.BackColor = System.Drawing.Color.Red
        Me.Label41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label41.Location = New System.Drawing.Point(36, 3)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(25, 10)
        Me.Label41.TabIndex = 1
        '
        'Label40
        '
        Me.Label40.BackColor = System.Drawing.Color.Red
        Me.Label40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label40.Location = New System.Drawing.Point(3, 3)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(25, 10)
        Me.Label40.TabIndex = 0
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.ForeColor = System.Drawing.Color.Blue
        Me.Label38.Location = New System.Drawing.Point(0, 148)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(38, 17)
        Me.Label38.TabIndex = 60
        Me.Label38.Text = "Blocs"
        '
        'PanelBlocs
        '
        Me.PanelBlocs.Controls.Add(Me.CheckBox96)
        Me.PanelBlocs.Controls.Add(Me.CheckBox95)
        Me.PanelBlocs.Controls.Add(Me.CheckBox94)
        Me.PanelBlocs.Controls.Add(Me.CheckBox93)
        Me.PanelBlocs.Controls.Add(Me.CheckBox92)
        Me.PanelBlocs.Controls.Add(Me.CheckBox91)
        Me.PanelBlocs.Controls.Add(Me.CheckBox90)
        Me.PanelBlocs.Controls.Add(Me.CheckBox89)
        Me.PanelBlocs.Controls.Add(Me.CheckBox88)
        Me.PanelBlocs.Controls.Add(Me.CheckBox87)
        Me.PanelBlocs.Controls.Add(Me.CheckBox86)
        Me.PanelBlocs.Controls.Add(Me.CheckBox85)
        Me.PanelBlocs.Controls.Add(Me.CheckBox84)
        Me.PanelBlocs.Controls.Add(Me.CheckBox83)
        Me.PanelBlocs.Controls.Add(Me.CheckBox82)
        Me.PanelBlocs.Controls.Add(Me.CheckBox81)
        Me.PanelBlocs.Controls.Add(Me.CheckBox80)
        Me.PanelBlocs.Controls.Add(Me.CheckBox79)
        Me.PanelBlocs.Controls.Add(Me.CheckBox78)
        Me.PanelBlocs.Controls.Add(Me.CheckBox77)
        Me.PanelBlocs.Controls.Add(Me.CheckBox76)
        Me.PanelBlocs.Controls.Add(Me.CheckBox75)
        Me.PanelBlocs.Controls.Add(Me.CheckBox74)
        Me.PanelBlocs.Controls.Add(Me.CheckBox73)
        Me.PanelBlocs.Controls.Add(Me.CheckBox72)
        Me.PanelBlocs.Controls.Add(Me.CheckBox71)
        Me.PanelBlocs.Controls.Add(Me.CheckBox70)
        Me.PanelBlocs.Controls.Add(Me.CheckBox69)
        Me.PanelBlocs.Controls.Add(Me.CheckBox68)
        Me.PanelBlocs.Controls.Add(Me.CheckBox67)
        Me.PanelBlocs.Controls.Add(Me.CheckBox66)
        Me.PanelBlocs.Controls.Add(Me.CheckBox65)
        Me.PanelBlocs.Controls.Add(Me.CheckBox64)
        Me.PanelBlocs.Controls.Add(Me.CheckBox63)
        Me.PanelBlocs.Controls.Add(Me.CheckBox62)
        Me.PanelBlocs.Controls.Add(Me.CheckBox61)
        Me.PanelBlocs.Controls.Add(Me.CheckBox60)
        Me.PanelBlocs.Controls.Add(Me.CheckBox59)
        Me.PanelBlocs.Controls.Add(Me.CheckBox58)
        Me.PanelBlocs.Controls.Add(Me.CheckBox57)
        Me.PanelBlocs.Controls.Add(Me.CheckBox56)
        Me.PanelBlocs.Controls.Add(Me.CheckBox55)
        Me.PanelBlocs.Controls.Add(Me.CheckBox54)
        Me.PanelBlocs.Controls.Add(Me.CheckBox53)
        Me.PanelBlocs.Controls.Add(Me.CheckBox52)
        Me.PanelBlocs.Controls.Add(Me.CheckBox51)
        Me.PanelBlocs.Controls.Add(Me.CheckBox50)
        Me.PanelBlocs.Controls.Add(Me.CheckBox49)
        Me.PanelBlocs.Controls.Add(Me.CheckBox48)
        Me.PanelBlocs.Controls.Add(Me.CheckBox47)
        Me.PanelBlocs.Controls.Add(Me.CheckBox46)
        Me.PanelBlocs.Controls.Add(Me.CheckBox45)
        Me.PanelBlocs.Controls.Add(Me.CheckBox44)
        Me.PanelBlocs.Controls.Add(Me.CheckBox43)
        Me.PanelBlocs.Controls.Add(Me.CheckBox42)
        Me.PanelBlocs.Controls.Add(Me.CheckBox41)
        Me.PanelBlocs.Controls.Add(Me.CheckBox40)
        Me.PanelBlocs.Controls.Add(Me.CheckBox39)
        Me.PanelBlocs.Controls.Add(Me.CheckBox38)
        Me.PanelBlocs.Controls.Add(Me.CheckBox37)
        Me.PanelBlocs.Controls.Add(Me.CheckBox36)
        Me.PanelBlocs.Controls.Add(Me.CheckBox35)
        Me.PanelBlocs.Controls.Add(Me.CheckBox34)
        Me.PanelBlocs.Controls.Add(Me.CheckBox33)
        Me.PanelBlocs.Controls.Add(Me.CheckBox32)
        Me.PanelBlocs.Controls.Add(Me.CheckBox31)
        Me.PanelBlocs.Controls.Add(Me.CheckBox30)
        Me.PanelBlocs.Controls.Add(Me.CheckBox29)
        Me.PanelBlocs.Controls.Add(Me.CheckBox28)
        Me.PanelBlocs.Controls.Add(Me.CheckBox27)
        Me.PanelBlocs.Controls.Add(Me.CheckBox26)
        Me.PanelBlocs.Controls.Add(Me.CheckBox25)
        Me.PanelBlocs.Controls.Add(Me.CheckBox24)
        Me.PanelBlocs.Controls.Add(Me.CheckBox23)
        Me.PanelBlocs.Controls.Add(Me.CheckBox22)
        Me.PanelBlocs.Controls.Add(Me.CheckBox21)
        Me.PanelBlocs.Controls.Add(Me.CheckBox20)
        Me.PanelBlocs.Controls.Add(Me.CheckBox19)
        Me.PanelBlocs.Controls.Add(Me.CheckBox18)
        Me.PanelBlocs.Controls.Add(Me.CheckBox17)
        Me.PanelBlocs.Controls.Add(Me.CheckBox16)
        Me.PanelBlocs.Controls.Add(Me.CheckBox15)
        Me.PanelBlocs.Controls.Add(Me.CheckBox14)
        Me.PanelBlocs.Controls.Add(Me.CheckBox13)
        Me.PanelBlocs.Controls.Add(Me.CheckBox12)
        Me.PanelBlocs.Controls.Add(Me.CheckBox11)
        Me.PanelBlocs.Controls.Add(Me.CheckBox10)
        Me.PanelBlocs.Controls.Add(Me.CheckBox9)
        Me.PanelBlocs.Controls.Add(Me.CheckBox8)
        Me.PanelBlocs.Controls.Add(Me.CheckBox7)
        Me.PanelBlocs.Controls.Add(Me.CheckBox6)
        Me.PanelBlocs.Controls.Add(Me.CheckBox5)
        Me.PanelBlocs.Controls.Add(Me.CheckBox4)
        Me.PanelBlocs.Controls.Add(Me.CheckBox3)
        Me.PanelBlocs.Controls.Add(Me.CheckBox2)
        Me.PanelBlocs.Controls.Add(Me.CheckBox1)
        Me.PanelBlocs.Location = New System.Drawing.Point(23, 18)
        Me.PanelBlocs.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelBlocs.Name = "PanelBlocs"
        Me.PanelBlocs.Size = New System.Drawing.Size(834, 141)
        Me.PanelBlocs.TabIndex = 62
        '
        'CheckBox96
        '
        Me.CheckBox96.Location = New System.Drawing.Point(789, 106)
        Me.CheckBox96.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox96.Name = "CheckBox96"
        Me.CheckBox96.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox96.TabIndex = 95
        Me.CheckBox96.UseSelectable = True
        '
        'CheckBox95
        '
        Me.CheckBox95.Location = New System.Drawing.Point(789, 76)
        Me.CheckBox95.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox95.Name = "CheckBox95"
        Me.CheckBox95.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox95.TabIndex = 94
        Me.CheckBox95.UseSelectable = True
        '
        'CheckBox94
        '
        Me.CheckBox94.Location = New System.Drawing.Point(789, 46)
        Me.CheckBox94.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox94.Name = "CheckBox94"
        Me.CheckBox94.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox94.TabIndex = 93
        Me.CheckBox94.UseSelectable = True
        '
        'CheckBox93
        '
        Me.CheckBox93.Location = New System.Drawing.Point(789, 16)
        Me.CheckBox93.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox93.Name = "CheckBox93"
        Me.CheckBox93.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox93.TabIndex = 92
        Me.CheckBox93.UseSelectable = True
        '
        'CheckBox92
        '
        Me.CheckBox92.Location = New System.Drawing.Point(755, 106)
        Me.CheckBox92.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox92.Name = "CheckBox92"
        Me.CheckBox92.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox92.TabIndex = 91
        Me.CheckBox92.UseSelectable = True
        '
        'CheckBox91
        '
        Me.CheckBox91.Location = New System.Drawing.Point(755, 76)
        Me.CheckBox91.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox91.Name = "CheckBox91"
        Me.CheckBox91.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox91.TabIndex = 90
        Me.CheckBox91.UseSelectable = True
        '
        'CheckBox90
        '
        Me.CheckBox90.Location = New System.Drawing.Point(755, 46)
        Me.CheckBox90.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox90.Name = "CheckBox90"
        Me.CheckBox90.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox90.TabIndex = 89
        Me.CheckBox90.UseSelectable = True
        '
        'CheckBox89
        '
        Me.CheckBox89.Location = New System.Drawing.Point(755, 16)
        Me.CheckBox89.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox89.Name = "CheckBox89"
        Me.CheckBox89.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox89.TabIndex = 88
        Me.CheckBox89.UseSelectable = True
        '
        'CheckBox88
        '
        Me.CheckBox88.Location = New System.Drawing.Point(721, 106)
        Me.CheckBox88.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox88.Name = "CheckBox88"
        Me.CheckBox88.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox88.TabIndex = 87
        Me.CheckBox88.UseSelectable = True
        '
        'CheckBox87
        '
        Me.CheckBox87.Location = New System.Drawing.Point(721, 76)
        Me.CheckBox87.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox87.Name = "CheckBox87"
        Me.CheckBox87.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox87.TabIndex = 86
        Me.CheckBox87.UseSelectable = True
        '
        'CheckBox86
        '
        Me.CheckBox86.Location = New System.Drawing.Point(721, 46)
        Me.CheckBox86.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox86.Name = "CheckBox86"
        Me.CheckBox86.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox86.TabIndex = 85
        Me.CheckBox86.UseSelectable = True
        '
        'CheckBox85
        '
        Me.CheckBox85.Location = New System.Drawing.Point(721, 16)
        Me.CheckBox85.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox85.Name = "CheckBox85"
        Me.CheckBox85.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox85.TabIndex = 84
        Me.CheckBox85.UseSelectable = True
        '
        'CheckBox84
        '
        Me.CheckBox84.Location = New System.Drawing.Point(687, 106)
        Me.CheckBox84.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox84.Name = "CheckBox84"
        Me.CheckBox84.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox84.TabIndex = 83
        Me.CheckBox84.UseSelectable = True
        '
        'CheckBox83
        '
        Me.CheckBox83.Location = New System.Drawing.Point(687, 76)
        Me.CheckBox83.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox83.Name = "CheckBox83"
        Me.CheckBox83.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox83.TabIndex = 82
        Me.CheckBox83.UseSelectable = True
        '
        'CheckBox82
        '
        Me.CheckBox82.Location = New System.Drawing.Point(687, 46)
        Me.CheckBox82.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox82.Name = "CheckBox82"
        Me.CheckBox82.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox82.TabIndex = 81
        Me.CheckBox82.UseSelectable = True
        '
        'CheckBox81
        '
        Me.CheckBox81.Location = New System.Drawing.Point(687, 16)
        Me.CheckBox81.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox81.Name = "CheckBox81"
        Me.CheckBox81.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox81.TabIndex = 80
        Me.CheckBox81.UseSelectable = True
        '
        'CheckBox80
        '
        Me.CheckBox80.Location = New System.Drawing.Point(653, 106)
        Me.CheckBox80.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox80.Name = "CheckBox80"
        Me.CheckBox80.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox80.TabIndex = 79
        Me.CheckBox80.UseSelectable = True
        '
        'CheckBox79
        '
        Me.CheckBox79.Location = New System.Drawing.Point(653, 76)
        Me.CheckBox79.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox79.Name = "CheckBox79"
        Me.CheckBox79.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox79.TabIndex = 78
        Me.CheckBox79.UseSelectable = True
        '
        'CheckBox78
        '
        Me.CheckBox78.Location = New System.Drawing.Point(653, 46)
        Me.CheckBox78.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox78.Name = "CheckBox78"
        Me.CheckBox78.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox78.TabIndex = 77
        Me.CheckBox78.UseSelectable = True
        '
        'CheckBox77
        '
        Me.CheckBox77.Location = New System.Drawing.Point(653, 16)
        Me.CheckBox77.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox77.Name = "CheckBox77"
        Me.CheckBox77.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox77.TabIndex = 76
        Me.CheckBox77.UseSelectable = True
        '
        'CheckBox76
        '
        Me.CheckBox76.Location = New System.Drawing.Point(617, 106)
        Me.CheckBox76.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox76.Name = "CheckBox76"
        Me.CheckBox76.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox76.TabIndex = 75
        Me.CheckBox76.UseSelectable = True
        '
        'CheckBox75
        '
        Me.CheckBox75.Location = New System.Drawing.Point(617, 76)
        Me.CheckBox75.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox75.Name = "CheckBox75"
        Me.CheckBox75.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox75.TabIndex = 74
        Me.CheckBox75.UseSelectable = True
        '
        'CheckBox74
        '
        Me.CheckBox74.Location = New System.Drawing.Point(618, 46)
        Me.CheckBox74.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox74.Name = "CheckBox74"
        Me.CheckBox74.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox74.TabIndex = 73
        Me.CheckBox74.UseSelectable = True
        '
        'CheckBox73
        '
        Me.CheckBox73.Location = New System.Drawing.Point(618, 16)
        Me.CheckBox73.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox73.Name = "CheckBox73"
        Me.CheckBox73.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox73.TabIndex = 72
        Me.CheckBox73.UseSelectable = True
        '
        'CheckBox72
        '
        Me.CheckBox72.Location = New System.Drawing.Point(586, 106)
        Me.CheckBox72.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox72.Name = "CheckBox72"
        Me.CheckBox72.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox72.TabIndex = 71
        Me.CheckBox72.UseSelectable = True
        '
        'CheckBox71
        '
        Me.CheckBox71.Location = New System.Drawing.Point(586, 76)
        Me.CheckBox71.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox71.Name = "CheckBox71"
        Me.CheckBox71.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox71.TabIndex = 70
        Me.CheckBox71.UseSelectable = True
        '
        'CheckBox70
        '
        Me.CheckBox70.Location = New System.Drawing.Point(586, 46)
        Me.CheckBox70.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox70.Name = "CheckBox70"
        Me.CheckBox70.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox70.TabIndex = 69
        Me.CheckBox70.UseSelectable = True
        '
        'CheckBox69
        '
        Me.CheckBox69.Location = New System.Drawing.Point(586, 16)
        Me.CheckBox69.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox69.Name = "CheckBox69"
        Me.CheckBox69.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox69.TabIndex = 68
        Me.CheckBox69.UseSelectable = True
        '
        'CheckBox68
        '
        Me.CheckBox68.Location = New System.Drawing.Point(552, 106)
        Me.CheckBox68.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox68.Name = "CheckBox68"
        Me.CheckBox68.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox68.TabIndex = 67
        Me.CheckBox68.UseSelectable = True
        '
        'CheckBox67
        '
        Me.CheckBox67.Location = New System.Drawing.Point(552, 76)
        Me.CheckBox67.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox67.Name = "CheckBox67"
        Me.CheckBox67.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox67.TabIndex = 66
        Me.CheckBox67.UseSelectable = True
        '
        'CheckBox66
        '
        Me.CheckBox66.Location = New System.Drawing.Point(552, 46)
        Me.CheckBox66.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox66.Name = "CheckBox66"
        Me.CheckBox66.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox66.TabIndex = 65
        Me.CheckBox66.UseSelectable = True
        '
        'CheckBox65
        '
        Me.CheckBox65.Location = New System.Drawing.Point(552, 16)
        Me.CheckBox65.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox65.Name = "CheckBox65"
        Me.CheckBox65.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox65.TabIndex = 64
        Me.CheckBox65.UseSelectable = True
        '
        'CheckBox64
        '
        Me.CheckBox64.Location = New System.Drawing.Point(519, 106)
        Me.CheckBox64.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox64.Name = "CheckBox64"
        Me.CheckBox64.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox64.TabIndex = 63
        Me.CheckBox64.UseSelectable = True
        '
        'CheckBox63
        '
        Me.CheckBox63.Location = New System.Drawing.Point(519, 76)
        Me.CheckBox63.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox63.Name = "CheckBox63"
        Me.CheckBox63.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox63.TabIndex = 62
        Me.CheckBox63.UseSelectable = True
        '
        'CheckBox62
        '
        Me.CheckBox62.Location = New System.Drawing.Point(519, 46)
        Me.CheckBox62.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox62.Name = "CheckBox62"
        Me.CheckBox62.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox62.TabIndex = 61
        Me.CheckBox62.UseSelectable = True
        '
        'CheckBox61
        '
        Me.CheckBox61.Location = New System.Drawing.Point(519, 16)
        Me.CheckBox61.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox61.Name = "CheckBox61"
        Me.CheckBox61.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox61.TabIndex = 60
        Me.CheckBox61.UseSelectable = True
        '
        'CheckBox60
        '
        Me.CheckBox60.Location = New System.Drawing.Point(484, 106)
        Me.CheckBox60.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox60.Name = "CheckBox60"
        Me.CheckBox60.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox60.TabIndex = 59
        Me.CheckBox60.UseSelectable = True
        '
        'CheckBox59
        '
        Me.CheckBox59.Location = New System.Drawing.Point(484, 76)
        Me.CheckBox59.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox59.Name = "CheckBox59"
        Me.CheckBox59.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox59.TabIndex = 58
        Me.CheckBox59.UseSelectable = True
        '
        'CheckBox58
        '
        Me.CheckBox58.Location = New System.Drawing.Point(484, 46)
        Me.CheckBox58.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox58.Name = "CheckBox58"
        Me.CheckBox58.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox58.TabIndex = 57
        Me.CheckBox58.UseSelectable = True
        '
        'CheckBox57
        '
        Me.CheckBox57.Location = New System.Drawing.Point(484, 16)
        Me.CheckBox57.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox57.Name = "CheckBox57"
        Me.CheckBox57.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox57.TabIndex = 56
        Me.CheckBox57.UseSelectable = True
        '
        'CheckBox56
        '
        Me.CheckBox56.Location = New System.Drawing.Point(449, 106)
        Me.CheckBox56.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox56.Name = "CheckBox56"
        Me.CheckBox56.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox56.TabIndex = 55
        Me.CheckBox56.UseSelectable = True
        '
        'CheckBox55
        '
        Me.CheckBox55.Location = New System.Drawing.Point(449, 76)
        Me.CheckBox55.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox55.Name = "CheckBox55"
        Me.CheckBox55.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox55.TabIndex = 54
        Me.CheckBox55.UseSelectable = True
        '
        'CheckBox54
        '
        Me.CheckBox54.Location = New System.Drawing.Point(449, 46)
        Me.CheckBox54.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox54.Name = "CheckBox54"
        Me.CheckBox54.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox54.TabIndex = 53
        Me.CheckBox54.UseSelectable = True
        '
        'CheckBox53
        '
        Me.CheckBox53.Location = New System.Drawing.Point(449, 16)
        Me.CheckBox53.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox53.Name = "CheckBox53"
        Me.CheckBox53.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox53.TabIndex = 52
        Me.CheckBox53.UseSelectable = True
        '
        'CheckBox52
        '
        Me.CheckBox52.Location = New System.Drawing.Point(416, 106)
        Me.CheckBox52.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox52.Name = "CheckBox52"
        Me.CheckBox52.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox52.TabIndex = 51
        Me.CheckBox52.UseSelectable = True
        '
        'CheckBox51
        '
        Me.CheckBox51.Location = New System.Drawing.Point(416, 76)
        Me.CheckBox51.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox51.Name = "CheckBox51"
        Me.CheckBox51.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox51.TabIndex = 50
        Me.CheckBox51.UseSelectable = True
        '
        'CheckBox50
        '
        Me.CheckBox50.Location = New System.Drawing.Point(416, 46)
        Me.CheckBox50.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox50.Name = "CheckBox50"
        Me.CheckBox50.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox50.TabIndex = 49
        Me.CheckBox50.UseSelectable = True
        '
        'CheckBox49
        '
        Me.CheckBox49.Location = New System.Drawing.Point(416, 16)
        Me.CheckBox49.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox49.Name = "CheckBox49"
        Me.CheckBox49.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox49.TabIndex = 48
        Me.CheckBox49.UseSelectable = True
        '
        'CheckBox48
        '
        Me.CheckBox48.Location = New System.Drawing.Point(383, 106)
        Me.CheckBox48.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox48.Name = "CheckBox48"
        Me.CheckBox48.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox48.TabIndex = 47
        Me.CheckBox48.UseSelectable = True
        '
        'CheckBox47
        '
        Me.CheckBox47.Location = New System.Drawing.Point(383, 76)
        Me.CheckBox47.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox47.Name = "CheckBox47"
        Me.CheckBox47.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox47.TabIndex = 46
        Me.CheckBox47.UseSelectable = True
        '
        'CheckBox46
        '
        Me.CheckBox46.Location = New System.Drawing.Point(383, 46)
        Me.CheckBox46.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox46.Name = "CheckBox46"
        Me.CheckBox46.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox46.TabIndex = 45
        Me.CheckBox46.UseSelectable = True
        '
        'CheckBox45
        '
        Me.CheckBox45.Location = New System.Drawing.Point(383, 16)
        Me.CheckBox45.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox45.Name = "CheckBox45"
        Me.CheckBox45.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox45.TabIndex = 44
        Me.CheckBox45.UseSelectable = True
        '
        'CheckBox44
        '
        Me.CheckBox44.Location = New System.Drawing.Point(349, 106)
        Me.CheckBox44.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox44.Name = "CheckBox44"
        Me.CheckBox44.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox44.TabIndex = 43
        Me.CheckBox44.UseSelectable = True
        '
        'CheckBox43
        '
        Me.CheckBox43.Location = New System.Drawing.Point(349, 76)
        Me.CheckBox43.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox43.Name = "CheckBox43"
        Me.CheckBox43.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox43.TabIndex = 42
        Me.CheckBox43.UseSelectable = True
        '
        'CheckBox42
        '
        Me.CheckBox42.Location = New System.Drawing.Point(349, 46)
        Me.CheckBox42.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox42.Name = "CheckBox42"
        Me.CheckBox42.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox42.TabIndex = 41
        Me.CheckBox42.UseSelectable = True
        '
        'CheckBox41
        '
        Me.CheckBox41.Location = New System.Drawing.Point(349, 16)
        Me.CheckBox41.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox41.Name = "CheckBox41"
        Me.CheckBox41.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox41.TabIndex = 40
        Me.CheckBox41.UseSelectable = True
        '
        'CheckBox40
        '
        Me.CheckBox40.Location = New System.Drawing.Point(315, 106)
        Me.CheckBox40.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox40.Name = "CheckBox40"
        Me.CheckBox40.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox40.TabIndex = 39
        Me.CheckBox40.UseSelectable = True
        '
        'CheckBox39
        '
        Me.CheckBox39.Location = New System.Drawing.Point(315, 76)
        Me.CheckBox39.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox39.Name = "CheckBox39"
        Me.CheckBox39.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox39.TabIndex = 38
        Me.CheckBox39.UseSelectable = True
        '
        'CheckBox38
        '
        Me.CheckBox38.Location = New System.Drawing.Point(315, 46)
        Me.CheckBox38.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox38.Name = "CheckBox38"
        Me.CheckBox38.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox38.TabIndex = 37
        Me.CheckBox38.UseSelectable = True
        '
        'CheckBox37
        '
        Me.CheckBox37.Location = New System.Drawing.Point(315, 16)
        Me.CheckBox37.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox37.Name = "CheckBox37"
        Me.CheckBox37.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox37.TabIndex = 36
        Me.CheckBox37.UseSelectable = True
        '
        'CheckBox36
        '
        Me.CheckBox36.Location = New System.Drawing.Point(281, 106)
        Me.CheckBox36.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox36.Name = "CheckBox36"
        Me.CheckBox36.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox36.TabIndex = 35
        Me.CheckBox36.UseSelectable = True
        '
        'CheckBox35
        '
        Me.CheckBox35.Location = New System.Drawing.Point(281, 76)
        Me.CheckBox35.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox35.Name = "CheckBox35"
        Me.CheckBox35.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox35.TabIndex = 34
        Me.CheckBox35.UseSelectable = True
        '
        'CheckBox34
        '
        Me.CheckBox34.Location = New System.Drawing.Point(281, 46)
        Me.CheckBox34.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox34.Name = "CheckBox34"
        Me.CheckBox34.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox34.TabIndex = 33
        Me.CheckBox34.UseSelectable = True
        '
        'CheckBox33
        '
        Me.CheckBox33.Location = New System.Drawing.Point(281, 16)
        Me.CheckBox33.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox33.Name = "CheckBox33"
        Me.CheckBox33.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox33.TabIndex = 32
        Me.CheckBox33.UseSelectable = True
        '
        'CheckBox32
        '
        Me.CheckBox32.Location = New System.Drawing.Point(247, 106)
        Me.CheckBox32.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox32.Name = "CheckBox32"
        Me.CheckBox32.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox32.TabIndex = 31
        Me.CheckBox32.UseSelectable = True
        '
        'CheckBox31
        '
        Me.CheckBox31.Location = New System.Drawing.Point(247, 76)
        Me.CheckBox31.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox31.Name = "CheckBox31"
        Me.CheckBox31.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox31.TabIndex = 30
        Me.CheckBox31.UseSelectable = True
        '
        'CheckBox30
        '
        Me.CheckBox30.Location = New System.Drawing.Point(247, 46)
        Me.CheckBox30.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox30.Name = "CheckBox30"
        Me.CheckBox30.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox30.TabIndex = 29
        Me.CheckBox30.UseSelectable = True
        '
        'CheckBox29
        '
        Me.CheckBox29.Location = New System.Drawing.Point(247, 16)
        Me.CheckBox29.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox29.Name = "CheckBox29"
        Me.CheckBox29.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox29.TabIndex = 28
        Me.CheckBox29.UseSelectable = True
        '
        'CheckBox28
        '
        Me.CheckBox28.Location = New System.Drawing.Point(213, 106)
        Me.CheckBox28.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox28.Name = "CheckBox28"
        Me.CheckBox28.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox28.TabIndex = 27
        Me.CheckBox28.UseSelectable = True
        '
        'CheckBox27
        '
        Me.CheckBox27.Location = New System.Drawing.Point(213, 76)
        Me.CheckBox27.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox27.Name = "CheckBox27"
        Me.CheckBox27.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox27.TabIndex = 26
        Me.CheckBox27.UseSelectable = True
        '
        'CheckBox26
        '
        Me.CheckBox26.Location = New System.Drawing.Point(213, 46)
        Me.CheckBox26.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox26.Name = "CheckBox26"
        Me.CheckBox26.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox26.TabIndex = 25
        Me.CheckBox26.UseSelectable = True
        '
        'CheckBox25
        '
        Me.CheckBox25.Location = New System.Drawing.Point(213, 16)
        Me.CheckBox25.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox25.Name = "CheckBox25"
        Me.CheckBox25.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox25.TabIndex = 24
        Me.CheckBox25.UseSelectable = True
        '
        'CheckBox24
        '
        Me.CheckBox24.Location = New System.Drawing.Point(180, 106)
        Me.CheckBox24.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox24.Name = "CheckBox24"
        Me.CheckBox24.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox24.TabIndex = 23
        Me.CheckBox24.UseSelectable = True
        '
        'CheckBox23
        '
        Me.CheckBox23.Location = New System.Drawing.Point(180, 76)
        Me.CheckBox23.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox23.Name = "CheckBox23"
        Me.CheckBox23.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox23.TabIndex = 22
        Me.CheckBox23.UseSelectable = True
        '
        'CheckBox22
        '
        Me.CheckBox22.Location = New System.Drawing.Point(180, 46)
        Me.CheckBox22.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox22.Name = "CheckBox22"
        Me.CheckBox22.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox22.TabIndex = 21
        Me.CheckBox22.UseSelectable = True
        '
        'CheckBox21
        '
        Me.CheckBox21.Location = New System.Drawing.Point(180, 16)
        Me.CheckBox21.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox21.Name = "CheckBox21"
        Me.CheckBox21.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox21.TabIndex = 20
        Me.CheckBox21.UseSelectable = True
        '
        'CheckBox20
        '
        Me.CheckBox20.Location = New System.Drawing.Point(146, 106)
        Me.CheckBox20.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox20.Name = "CheckBox20"
        Me.CheckBox20.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox20.TabIndex = 19
        Me.CheckBox20.UseSelectable = True
        '
        'CheckBox19
        '
        Me.CheckBox19.Location = New System.Drawing.Point(146, 76)
        Me.CheckBox19.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox19.Name = "CheckBox19"
        Me.CheckBox19.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox19.TabIndex = 18
        Me.CheckBox19.UseSelectable = True
        '
        'CheckBox18
        '
        Me.CheckBox18.Location = New System.Drawing.Point(146, 46)
        Me.CheckBox18.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox18.Name = "CheckBox18"
        Me.CheckBox18.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox18.TabIndex = 17
        Me.CheckBox18.UseSelectable = True
        '
        'CheckBox17
        '
        Me.CheckBox17.Location = New System.Drawing.Point(146, 16)
        Me.CheckBox17.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox17.Name = "CheckBox17"
        Me.CheckBox17.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox17.TabIndex = 16
        Me.CheckBox17.UseSelectable = True
        '
        'CheckBox16
        '
        Me.CheckBox16.Location = New System.Drawing.Point(112, 106)
        Me.CheckBox16.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox16.Name = "CheckBox16"
        Me.CheckBox16.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox16.TabIndex = 15
        Me.CheckBox16.UseSelectable = True
        '
        'CheckBox15
        '
        Me.CheckBox15.Location = New System.Drawing.Point(112, 76)
        Me.CheckBox15.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox15.Name = "CheckBox15"
        Me.CheckBox15.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox15.TabIndex = 14
        Me.CheckBox15.UseSelectable = True
        '
        'CheckBox14
        '
        Me.CheckBox14.Location = New System.Drawing.Point(112, 46)
        Me.CheckBox14.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox14.Name = "CheckBox14"
        Me.CheckBox14.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox14.TabIndex = 13
        Me.CheckBox14.UseSelectable = True
        '
        'CheckBox13
        '
        Me.CheckBox13.Location = New System.Drawing.Point(112, 16)
        Me.CheckBox13.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox13.Name = "CheckBox13"
        Me.CheckBox13.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox13.TabIndex = 12
        Me.CheckBox13.UseSelectable = True
        '
        'CheckBox12
        '
        Me.CheckBox12.Location = New System.Drawing.Point(76, 106)
        Me.CheckBox12.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox12.Name = "CheckBox12"
        Me.CheckBox12.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox12.TabIndex = 11
        Me.CheckBox12.UseSelectable = True
        '
        'CheckBox11
        '
        Me.CheckBox11.Location = New System.Drawing.Point(76, 76)
        Me.CheckBox11.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox11.Name = "CheckBox11"
        Me.CheckBox11.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox11.TabIndex = 10
        Me.CheckBox11.UseSelectable = True
        '
        'CheckBox10
        '
        Me.CheckBox10.Location = New System.Drawing.Point(76, 46)
        Me.CheckBox10.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox10.Name = "CheckBox10"
        Me.CheckBox10.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox10.TabIndex = 9
        Me.CheckBox10.UseSelectable = True
        '
        'CheckBox9
        '
        Me.CheckBox9.Location = New System.Drawing.Point(76, 16)
        Me.CheckBox9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox9.TabIndex = 8
        Me.CheckBox9.UseSelectable = True
        '
        'CheckBox8
        '
        Me.CheckBox8.Location = New System.Drawing.Point(41, 106)
        Me.CheckBox8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox8.TabIndex = 7
        Me.CheckBox8.UseSelectable = True
        '
        'CheckBox7
        '
        Me.CheckBox7.Location = New System.Drawing.Point(41, 76)
        Me.CheckBox7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox7.TabIndex = 6
        Me.CheckBox7.UseSelectable = True
        '
        'CheckBox6
        '
        Me.CheckBox6.Location = New System.Drawing.Point(41, 46)
        Me.CheckBox6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox6.TabIndex = 5
        Me.CheckBox6.UseSelectable = True
        '
        'CheckBox5
        '
        Me.CheckBox5.Location = New System.Drawing.Point(41, 16)
        Me.CheckBox5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox5.TabIndex = 4
        Me.CheckBox5.UseSelectable = True
        '
        'CheckBox4
        '
        Me.CheckBox4.Location = New System.Drawing.Point(12, 106)
        Me.CheckBox4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox4.TabIndex = 3
        Me.CheckBox4.UseSelectable = True
        '
        'CheckBox3
        '
        Me.CheckBox3.Location = New System.Drawing.Point(12, 76)
        Me.CheckBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox3.TabIndex = 2
        Me.CheckBox3.UseSelectable = True
        '
        'CheckBox2
        '
        Me.CheckBox2.Location = New System.Drawing.Point(12, 46)
        Me.CheckBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.UseSelectable = True
        '
        'CheckBox1
        '
        Me.CheckBox1.Location = New System.Drawing.Point(12, 16)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.UseSelectable = True
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.ForeColor = System.Drawing.Color.Blue
        Me.Label39.Location = New System.Drawing.Point(826, 3)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(43, 17)
        Me.Label39.TabIndex = 61
        Me.Label39.Text = "Hores"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(808, 3)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(22, 17)
        Me.Label37.TabIndex = 59
        Me.Label37.Text = "23"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(775, 3)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(22, 17)
        Me.Label36.TabIndex = 58
        Me.Label36.Text = "22"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(741, 3)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(22, 17)
        Me.Label35.TabIndex = 57
        Me.Label35.Text = "21"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(707, 3)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(22, 17)
        Me.Label34.TabIndex = 56
        Me.Label34.Text = "20"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(673, 3)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(22, 17)
        Me.Label33.TabIndex = 55
        Me.Label33.Text = "19"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(639, 3)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(22, 17)
        Me.Label32.TabIndex = 54
        Me.Label32.Text = "18"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(605, 3)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(22, 17)
        Me.Label31.TabIndex = 53
        Me.Label31.Text = "17"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(572, 3)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(22, 17)
        Me.Label30.TabIndex = 52
        Me.Label30.Text = "16"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(538, 3)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(22, 17)
        Me.Label29.TabIndex = 51
        Me.Label29.Text = "15"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(504, 3)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(22, 17)
        Me.Label28.TabIndex = 50
        Me.Label28.Text = "14"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(470, 3)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(22, 17)
        Me.Label27.TabIndex = 49
        Me.Label27.Text = "13"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(436, 3)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(22, 17)
        Me.Label26.TabIndex = 48
        Me.Label26.Text = "12"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(402, 3)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(22, 17)
        Me.Label25.TabIndex = 47
        Me.Label25.Text = "11"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(369, 3)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(22, 17)
        Me.Label24.TabIndex = 46
        Me.Label24.Text = "10"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(335, 3)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(22, 17)
        Me.Label23.TabIndex = 45
        Me.Label23.Text = "09"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(301, 3)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(22, 17)
        Me.Label22.TabIndex = 44
        Me.Label22.Text = "08"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(267, 3)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(22, 17)
        Me.Label21.TabIndex = 43
        Me.Label21.Text = "07"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(233, 3)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(22, 17)
        Me.Label20.TabIndex = 42
        Me.Label20.Text = "06"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(199, 3)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(22, 17)
        Me.Label19.TabIndex = 41
        Me.Label19.Text = "05"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(166, 3)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(22, 17)
        Me.Label18.TabIndex = 40
        Me.Label18.Text = "04"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(132, 3)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(22, 17)
        Me.Label17.TabIndex = 39
        Me.Label17.Text = "03"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(98, 3)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(22, 17)
        Me.Label16.TabIndex = 38
        Me.Label16.Text = "02"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(64, 3)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(22, 17)
        Me.Label15.TabIndex = 37
        Me.Label15.Text = "01"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(30, 3)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(22, 17)
        Me.Label14.TabIndex = 36
        Me.Label14.Text = "00"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(0, 122)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(22, 17)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "45"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(0, 91)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(22, 17)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "30"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(0, 60)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(22, 17)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "15"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(0, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(22, 17)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "00"
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 38)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage4.Size = New System.Drawing.Size(921, 130)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Dimarts"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Location = New System.Drawing.Point(4, 38)
        Me.TabPage5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(921, 130)
        Me.TabPage5.TabIndex = 2
        Me.TabPage5.Text = "Dimecres"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'TabPage6
        '
        Me.TabPage6.Location = New System.Drawing.Point(4, 38)
        Me.TabPage6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(921, 130)
        Me.TabPage6.TabIndex = 3
        Me.TabPage6.Text = "Dijous"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'TabPage7
        '
        Me.TabPage7.Location = New System.Drawing.Point(4, 38)
        Me.TabPage7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(921, 130)
        Me.TabPage7.TabIndex = 4
        Me.TabPage7.Text = "Divendres"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'TabPage8
        '
        Me.TabPage8.Location = New System.Drawing.Point(4, 38)
        Me.TabPage8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Size = New System.Drawing.Size(921, 130)
        Me.TabPage8.TabIndex = 5
        Me.TabPage8.Text = "Dissabte"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'TabPage9
        '
        Me.TabPage9.Location = New System.Drawing.Point(4, 38)
        Me.TabPage9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Size = New System.Drawing.Size(921, 130)
        Me.TabPage9.TabIndex = 6
        Me.TabPage9.Text = "Diumenge"
        Me.TabPage9.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.picPlay)
        Me.Panel1.Controls.Add(Me.picPause)
        Me.Panel1.Controls.Add(Me.picLock)
        Me.Panel1.Controls.Add(Me.picUnLock)
        Me.Panel1.Controls.Add(Me.txtDataOut)
        Me.Panel1.Controls.Add(Me.Label64)
        Me.Panel1.Controls.Add(Me.txtDataIn)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.lbNRadia)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.ComboLocutor)
        Me.Panel1.Controls.Add(Me.lbLocutor)
        Me.Panel1.Controls.Add(Me.ComboTecnic)
        Me.Panel1.Controls.Add(Me.lbTecnic)
        Me.Panel1.Controls.Add(Me.chkPropia)
        Me.Panel1.Controls.Add(Me.chkFactura)
        Me.Panel1.Controls.Add(Me.chkValida)
        Me.Panel1.Controls.Add(Me.chkActive)
        Me.Panel1.Controls.Add(Me.lbDataCrea)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.lbID)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.ComboTarifes)
        Me.Panel1.Controls.Add(Me.cbTarifa)
        Me.Panel1.Controls.Add(Me.txtComent)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.lbDurada)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtMarca)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.ComboProducte)
        Me.Panel1.Controls.Add(Me.lbProducte)
        Me.Panel1.Controls.Add(Me.ComboClient)
        Me.Panel1.Controls.Add(Me.lbClient)
        Me.Panel1.Controls.Add(Me.txtNom)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(23, 119)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(946, 211)
        Me.Panel1.TabIndex = 181
        '
        'picPlay
        '
        Me.picPlay.ErrorImage = CType(resources.GetObject("picPlay.ErrorImage"), System.Drawing.Image)
        Me.picPlay.Image = CType(resources.GetObject("picPlay.Image"), System.Drawing.Image)
        Me.picPlay.Location = New System.Drawing.Point(7, 119)
        Me.picPlay.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picPlay.Name = "picPlay"
        Me.picPlay.Size = New System.Drawing.Size(19, 20)
        Me.picPlay.TabIndex = 189
        Me.picPlay.TabStop = False
        Me.picPlay.Visible = False
        '
        'picPause
        '
        Me.picPause.ErrorImage = CType(resources.GetObject("picPause.ErrorImage"), System.Drawing.Image)
        Me.picPause.Image = CType(resources.GetObject("picPause.Image"), System.Drawing.Image)
        Me.picPause.Location = New System.Drawing.Point(7, 157)
        Me.picPause.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picPause.Name = "picPause"
        Me.picPause.Size = New System.Drawing.Size(19, 18)
        Me.picPause.TabIndex = 190
        Me.picPause.TabStop = False
        Me.picPause.Visible = False
        '
        'picLock
        '
        Me.picLock.Image = CType(resources.GetObject("picLock.Image"), System.Drawing.Image)
        Me.picLock.Location = New System.Drawing.Point(7, 13)
        Me.picLock.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picLock.Name = "picLock"
        Me.picLock.Size = New System.Drawing.Size(35, 46)
        Me.picLock.TabIndex = 229
        Me.picLock.TabStop = False
        Me.picLock.Visible = False
        '
        'picUnLock
        '
        Me.picUnLock.Image = CType(resources.GetObject("picUnLock.Image"), System.Drawing.Image)
        Me.picUnLock.Location = New System.Drawing.Point(6, 67)
        Me.picUnLock.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picUnLock.Name = "picUnLock"
        Me.picUnLock.Size = New System.Drawing.Size(36, 44)
        Me.picUnLock.TabIndex = 230
        Me.picUnLock.TabStop = False
        Me.picUnLock.Visible = False
        '
        'txtDataOut
        '
        Me.txtDataOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDataOut.Enabled = False
        Me.txtDataOut.Location = New System.Drawing.Point(718, 30)
        Me.txtDataOut.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDataOut.MinimumSize = New System.Drawing.Size(0, 29)
        Me.txtDataOut.Name = "txtDataOut"
        Me.txtDataOut.Size = New System.Drawing.Size(221, 29)
        Me.txtDataOut.TabIndex = 8
        '
        'Label64
        '
        Me.Label64.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label64.Location = New System.Drawing.Point(619, 36)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(89, 17)
        Me.Label64.TabIndex = 226
        Me.Label64.Text = "Data Sortida"
        Me.Label64.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtDataIn
        '
        Me.txtDataIn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDataIn.Enabled = False
        Me.txtDataIn.Location = New System.Drawing.Point(718, 2)
        Me.txtDataIn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDataIn.MinimumSize = New System.Drawing.Size(0, 29)
        Me.txtDataIn.Name = "txtDataIn"
        Me.txtDataIn.Size = New System.Drawing.Size(221, 29)
        Me.txtDataIn.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.Location = New System.Drawing.Point(619, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 17)
        Me.Label6.TabIndex = 224
        Me.Label6.Text = "Data Entrada"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbNRadia
        '
        Me.lbNRadia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNRadia.Location = New System.Drawing.Point(514, 192)
        Me.lbNRadia.Name = "lbNRadia"
        Me.lbNRadia.Size = New System.Drawing.Size(32, 13)
        Me.lbNRadia.TabIndex = 223
        Me.lbNRadia.Text = "0"
        Me.lbNRadia.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(397, 190)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 17)
        Me.Label9.TabIndex = 222
        Me.Label9.Text = "Nº de radiacions"
        '
        'ComboLocutor
        '
        Me.ComboLocutor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboLocutor.Enabled = False
        Me.ComboLocutor.FormattingEnabled = True
        Me.ComboLocutor.Location = New System.Drawing.Point(718, 88)
        Me.ComboLocutor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboLocutor.Name = "ComboLocutor"
        Me.ComboLocutor.Size = New System.Drawing.Size(221, 25)
        Me.ComboLocutor.TabIndex = 10
        '
        'lbLocutor
        '
        Me.lbLocutor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbLocutor.Location = New System.Drawing.Point(619, 92)
        Me.lbLocutor.Name = "lbLocutor"
        Me.lbLocutor.Size = New System.Drawing.Size(89, 17)
        Me.lbLocutor.TabIndex = 220
        Me.lbLocutor.TabStop = True
        Me.lbLocutor.Text = "Locutor"
        Me.lbLocutor.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ComboTecnic
        '
        Me.ComboTecnic.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboTecnic.Enabled = False
        Me.ComboTecnic.FormattingEnabled = True
        Me.ComboTecnic.Location = New System.Drawing.Point(718, 60)
        Me.ComboTecnic.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboTecnic.Name = "ComboTecnic"
        Me.ComboTecnic.Size = New System.Drawing.Size(221, 25)
        Me.ComboTecnic.TabIndex = 9
        '
        'lbTecnic
        '
        Me.lbTecnic.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbTecnic.Location = New System.Drawing.Point(619, 64)
        Me.lbTecnic.Name = "lbTecnic"
        Me.lbTecnic.Size = New System.Drawing.Size(89, 17)
        Me.lbTecnic.TabIndex = 218
        Me.lbTecnic.TabStop = True
        Me.lbTecnic.Text = "Tècnic"
        Me.lbTecnic.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'chkPropia
        '
        Me.chkPropia.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkPropia.Enabled = False
        Me.chkPropia.Location = New System.Drawing.Point(808, 167)
        Me.chkPropia.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkPropia.Name = "chkPropia"
        Me.chkPropia.Size = New System.Drawing.Size(131, 22)
        Me.chkPropia.TabIndex = 14
        Me.chkPropia.Text = "Pròpia de la ràdio"
        Me.chkPropia.UseSelectable = True
        '
        'chkFactura
        '
        Me.chkFactura.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkFactura.Enabled = False
        Me.chkFactura.Location = New System.Drawing.Point(808, 145)
        Me.chkFactura.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkFactura.Name = "chkFactura"
        Me.chkFactura.Size = New System.Drawing.Size(131, 22)
        Me.chkFactura.TabIndex = 13
        Me.chkFactura.Text = "Facturada"
        Me.chkFactura.UseSelectable = True
        '
        'chkValida
        '
        Me.chkValida.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkValida.Enabled = False
        Me.chkValida.Location = New System.Drawing.Point(718, 166)
        Me.chkValida.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkValida.Name = "chkValida"
        Me.chkValida.Size = New System.Drawing.Size(84, 22)
        Me.chkValida.TabIndex = 12
        Me.chkValida.Text = "Vàlida"
        Me.chkValida.UseSelectable = True
        '
        'chkActive
        '
        Me.chkActive.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkActive.Enabled = False
        Me.chkActive.Location = New System.Drawing.Point(718, 143)
        Me.chkActive.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(84, 22)
        Me.chkActive.TabIndex = 11
        Me.chkActive.Text = "Activa"
        Me.chkActive.UseSelectable = True
        '
        'lbDataCrea
        '
        Me.lbDataCrea.AutoSize = True
        Me.lbDataCrea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDataCrea.Location = New System.Drawing.Point(191, 192)
        Me.lbDataCrea.Name = "lbDataCrea"
        Me.lbDataCrea.Size = New System.Drawing.Size(125, 13)
        Me.lbDataCrea.TabIndex = 211
        Me.lbDataCrea.Text = "2006-06-23 10:20:03"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(64, 190)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 17)
        Me.Label8.TabIndex = 210
        Me.Label8.Text = "Data de Creació"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbID
        '
        Me.lbID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbID.Location = New System.Drawing.Point(590, 9)
        Me.lbID.Name = "lbID"
        Me.lbID.Size = New System.Drawing.Size(23, 13)
        Me.lbID.TabIndex = 205
        Me.lbID.Text = "0"
        Me.lbID.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(480, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 17)
        Me.Label7.TabIndex = 204
        Me.Label7.Text = "Identificador"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ComboTarifes
        '
        Me.ComboTarifes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboTarifes.Enabled = False
        Me.ComboTarifes.FormattingEnabled = True
        Me.ComboTarifes.Location = New System.Drawing.Point(194, 116)
        Me.ComboTarifes.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboTarifes.Name = "ComboTarifes"
        Me.ComboTarifes.Size = New System.Drawing.Size(418, 25)
        Me.ComboTarifes.TabIndex = 5
        '
        'cbTarifa
        '
        Me.cbTarifa.Location = New System.Drawing.Point(64, 120)
        Me.cbTarifa.Name = "cbTarifa"
        Me.cbTarifa.Size = New System.Drawing.Size(124, 17)
        Me.cbTarifa.TabIndex = 202
        Me.cbTarifa.TabStop = True
        Me.cbTarifa.Text = "Tarifa"
        Me.cbTarifa.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtComent
        '
        Me.txtComent.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtComent.Enabled = False
        Me.txtComent.Location = New System.Drawing.Point(194, 145)
        Me.txtComent.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtComent.Multiline = True
        Me.txtComent.Name = "txtComent"
        Me.txtComent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtComent.Size = New System.Drawing.Size(514, 43)
        Me.txtComent.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(64, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 17)
        Me.Label5.TabIndex = 198
        Me.Label5.Text = "Observacions"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbDurada
        '
        Me.lbDurada.AutoSize = True
        Me.lbDurada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDurada.Location = New System.Drawing.Point(681, 192)
        Me.lbDurada.Name = "lbDurada"
        Me.lbDurada.Size = New System.Drawing.Size(57, 13)
        Me.lbDurada.TabIndex = 197
        Me.lbDurada.Text = "00:00:00"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(551, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 17)
        Me.Label4.TabIndex = 196
        Me.Label4.Text = "Durada"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtMarca
        '
        Me.txtMarca.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMarca.Enabled = False
        Me.txtMarca.Location = New System.Drawing.Point(194, 88)
        Me.txtMarca.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(418, 25)
        Me.txtMarca.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(64, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 17)
        Me.Label3.TabIndex = 194
        Me.Label3.Text = "Marca"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ComboProducte
        '
        Me.ComboProducte.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboProducte.Enabled = False
        Me.ComboProducte.FormattingEnabled = True
        Me.ComboProducte.Location = New System.Drawing.Point(194, 60)
        Me.ComboProducte.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboProducte.Name = "ComboProducte"
        Me.ComboProducte.Size = New System.Drawing.Size(418, 25)
        Me.ComboProducte.TabIndex = 3
        '
        'lbProducte
        '
        Me.lbProducte.Location = New System.Drawing.Point(64, 64)
        Me.lbProducte.Name = "lbProducte"
        Me.lbProducte.Size = New System.Drawing.Size(124, 17)
        Me.lbProducte.TabIndex = 192
        Me.lbProducte.TabStop = True
        Me.lbProducte.Text = "Producte"
        Me.lbProducte.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ComboClient
        '
        Me.ComboClient.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboClient.Enabled = False
        Me.ComboClient.FormattingEnabled = True
        Me.ComboClient.Location = New System.Drawing.Point(194, 32)
        Me.ComboClient.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboClient.Name = "ComboClient"
        Me.ComboClient.Size = New System.Drawing.Size(418, 25)
        Me.ComboClient.TabIndex = 2
        '
        'lbClient
        '
        Me.lbClient.Location = New System.Drawing.Point(64, 36)
        Me.lbClient.Name = "lbClient"
        Me.lbClient.Size = New System.Drawing.Size(124, 17)
        Me.lbClient.TabIndex = 190
        Me.lbClient.TabStop = True
        Me.lbClient.Text = "Client"
        Me.lbClient.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtNom
        '
        Me.txtNom.Enabled = False
        Me.txtNom.Location = New System.Drawing.Point(194, 4)
        Me.txtNom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(284, 25)
        Me.txtNom.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(64, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 17)
        Me.Label2.TabIndex = 188
        Me.Label2.Text = "Nom"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Location = New System.Drawing.Point(1101, 84)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(26, 25)
        Me.cmdExit.TabIndex = 182
        Me.cmdExit.Text = "Button1"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'picVuMeter
        '
        Me.picVuMeter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picVuMeter.BackColor = System.Drawing.SystemColors.Control
        Me.picVuMeter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picVuMeter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picVuMeter.Location = New System.Drawing.Point(832, 84)
        Me.picVuMeter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picVuMeter.Name = "picVuMeter"
        Me.picVuMeter.Size = New System.Drawing.Size(93, 29)
        Me.picVuMeter.TabIndex = 187
        Me.picVuMeter.TabStop = False
        '
        'tmrDetalls
        '
        Me.tmrDetalls.Interval = 500
        '
        'tmrPlayer
        '
        Me.tmrPlayer.Interval = 25
        '
        'Timer1
        '
        Me.Timer1.Interval = 25
        '
        'PanelAssistent
        '
        Me.PanelAssistent.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelAssistent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelAssistent.Controls.Add(Me.Label69)
        Me.PanelAssistent.Controls.Add(Me.ButtonHideAssist)
        Me.PanelAssistent.Controls.Add(Me.MetroTabControl1)
        Me.PanelAssistent.Location = New System.Drawing.Point(335, 42)
        Me.PanelAssistent.Name = "PanelAssistent"
        Me.PanelAssistent.Size = New System.Drawing.Size(323, 477)
        Me.PanelAssistent.TabIndex = 188
        Me.PanelAssistent.Visible = False
        '
        'Label69
        '
        Me.Label69.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Label69.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label69.Location = New System.Drawing.Point(-1, 0)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(323, 6)
        Me.Label69.TabIndex = 14
        '
        'ButtonHideAssist
        '
        Me.ButtonHideAssist.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonHideAssist.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonHideAssist.Image = CType(resources.GetObject("ButtonHideAssist.Image"), System.Drawing.Image)
        Me.ButtonHideAssist.ImageSize = 32
        Me.ButtonHideAssist.Location = New System.Drawing.Point(276, 5)
        Me.ButtonHideAssist.Name = "ButtonHideAssist"
        Me.ButtonHideAssist.Size = New System.Drawing.Size(40, 42)
        Me.ButtonHideAssist.TabIndex = 13
        Me.ButtonHideAssist.UseSelectable = True
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage2)
        Me.MetroTabControl1.Location = New System.Drawing.Point(2, 17)
        Me.MetroTabControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(316, 458)
        Me.MetroTabControl1.TabIndex = 12
        Me.MetroTabControl1.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.chk_Hores_all)
        Me.MetroTabPage1.Controls.Add(Me.chk_DiesAll)
        Me.MetroTabPage1.Controls.Add(Me.cmdCalc)
        Me.MetroTabPage1.Controls.Add(Me.chkRespect)
        Me.MetroTabPage1.Controls.Add(Me.txtMaxPubliDia)
        Me.MetroTabPage1.Controls.Add(Me.Label1)
        Me.MetroTabPage1.Controls.Add(Me.txtNumRadi)
        Me.MetroTabPage1.Controls.Add(Me.Label65)
        Me.MetroTabPage1.Controls.Add(Me.Label66)
        Me.MetroTabPage1.Controls.Add(Me.Label67)
        Me.MetroTabPage1.Controls.Add(Me.lstHoresDisp)
        Me.MetroTabPage1.Controls.Add(Me.lstDiesDisp)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 2
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(308, 416)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "Aleatori"
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 3
        '
        'chk_Hores_all
        '
        Me.chk_Hores_all.AutoSize = True
        Me.chk_Hores_all.Location = New System.Drawing.Point(171, 70)
        Me.chk_Hores_all.Name = "chk_Hores_all"
        Me.chk_Hores_all.Size = New System.Drawing.Size(44, 15)
        Me.chk_Hores_all.TabIndex = 20
        Me.chk_Hores_all.Text = "Tots"
        Me.chk_Hores_all.UseSelectable = True
        '
        'chk_DiesAll
        '
        Me.chk_DiesAll.AutoSize = True
        Me.chk_DiesAll.Location = New System.Drawing.Point(12, 70)
        Me.chk_DiesAll.Name = "chk_DiesAll"
        Me.chk_DiesAll.Size = New System.Drawing.Size(44, 15)
        Me.chk_DiesAll.TabIndex = 19
        Me.chk_DiesAll.Text = "Tots"
        Me.chk_DiesAll.UseSelectable = True
        '
        'cmdCalc
        '
        Me.cmdCalc.ActiveControl = Nothing
        Me.cmdCalc.Location = New System.Drawing.Point(8, 362)
        Me.cmdCalc.Name = "cmdCalc"
        Me.cmdCalc.Size = New System.Drawing.Size(292, 54)
        Me.cmdCalc.TabIndex = 18
        Me.cmdCalc.TileImage = CType(resources.GetObject("cmdCalc.TileImage"), System.Drawing.Image)
        Me.cmdCalc.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdCalc.UseSelectable = True
        Me.cmdCalc.UseTileImage = True
        '
        'chkRespect
        '
        Me.chkRespect.AutoSize = True
        Me.chkRespect.Location = New System.Drawing.Point(8, 252)
        Me.chkRespect.Name = "chkRespect"
        Me.chkRespect.Size = New System.Drawing.Size(187, 15)
        Me.chkRespect.TabIndex = 17
        Me.chkRespect.Text = "Respectar assignacions prèvies."
        Me.chkRespect.UseSelectable = True
        '
        'txtMaxPubliDia
        '
        Me.txtMaxPubliDia.Location = New System.Drawing.Point(241, 326)
        Me.txtMaxPubliDia.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtMaxPubliDia.Name = "txtMaxPubliDia"
        Me.txtMaxPubliDia.Size = New System.Drawing.Size(59, 25)
        Me.txtMaxPubliDia.TabIndex = 11
        Me.txtMaxPubliDia.Text = "5"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(-6, 330)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Nº màxim de radiacions per dia:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtNumRadi
        '
        Me.txtNumRadi.Location = New System.Drawing.Point(241, 286)
        Me.txtNumRadi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNumRadi.Name = "txtNumRadi"
        Me.txtNumRadi.Size = New System.Drawing.Size(60, 25)
        Me.txtNumRadi.TabIndex = 9
        Me.txtNumRadi.Text = "1"
        '
        'Label65
        '
        Me.Label65.BackColor = System.Drawing.Color.Transparent
        Me.Label65.Location = New System.Drawing.Point(-6, 290)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(241, 17)
        Me.Label65.TabIndex = 8
        Me.Label65.Text = "Nº de radiacions (setmanals):"
        Me.Label65.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.BackColor = System.Drawing.Color.Transparent
        Me.Label66.Location = New System.Drawing.Point(16, 48)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(192, 17)
        Me.Label66.TabIndex = 12
        Me.Label66.Text = "Assignar dies i hores possibles:"
        '
        'Label67
        '
        Me.Label67.BackColor = System.Drawing.Color.Transparent
        Me.Label67.ForeColor = System.Drawing.Color.Blue
        Me.Label67.Location = New System.Drawing.Point(3, 12)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(305, 36)
        Me.Label67.TabIndex = 7
        Me.Label67.Text = "Assignarà aleatòriament l'hora on ha de sonar la publicitat."
        '
        'lstHoresDisp
        '
        Me.lstHoresDisp.FormattingEnabled = True
        Me.lstHoresDisp.Location = New System.Drawing.Point(168, 92)
        Me.lstHoresDisp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstHoresDisp.Name = "lstHoresDisp"
        Me.lstHoresDisp.Size = New System.Drawing.Size(133, 144)
        Me.lstHoresDisp.TabIndex = 1
        '
        'lstDiesDisp
        '
        Me.lstDiesDisp.FormattingEnabled = True
        Me.lstDiesDisp.Location = New System.Drawing.Point(8, 92)
        Me.lstDiesDisp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstDiesDisp.Name = "lstDiesDisp"
        Me.lstDiesDisp.Size = New System.Drawing.Size(133, 144)
        Me.lstDiesDisp.TabIndex = 0
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.Controls.Add(Me.buttonNovaPlantilla)
        Me.MetroTabPage2.Controls.Add(Me.buttonExecutaPlantilla)
        Me.MetroTabPage2.Controls.Add(Me.chkRespectTemplates)
        Me.MetroTabPage2.Controls.Add(Me.groupBoxEditPlantilla)
        Me.MetroTabPage2.Controls.Add(Me.Label68)
        Me.MetroTabPage2.Controls.Add(Me.comboBoxPlantillesPubli)
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 2
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(308, 416)
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "Plantilles"
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 3
        '
        'buttonNovaPlantilla
        '
        Me.buttonNovaPlantilla.Image = CType(resources.GetObject("buttonNovaPlantilla.Image"), System.Drawing.Image)
        Me.buttonNovaPlantilla.Location = New System.Drawing.Point(71, 217)
        Me.buttonNovaPlantilla.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.buttonNovaPlantilla.Name = "buttonNovaPlantilla"
        Me.buttonNovaPlantilla.Size = New System.Drawing.Size(148, 58)
        Me.buttonNovaPlantilla.TabIndex = 10
        Me.buttonNovaPlantilla.UseVisualStyleBackColor = True
        '
        'buttonExecutaPlantilla
        '
        Me.buttonExecutaPlantilla.ActiveControl = Nothing
        Me.buttonExecutaPlantilla.Location = New System.Drawing.Point(71, 85)
        Me.buttonExecutaPlantilla.Name = "buttonExecutaPlantilla"
        Me.buttonExecutaPlantilla.Size = New System.Drawing.Size(148, 54)
        Me.buttonExecutaPlantilla.TabIndex = 19
        Me.buttonExecutaPlantilla.TileImage = CType(resources.GetObject("buttonExecutaPlantilla.TileImage"), System.Drawing.Image)
        Me.buttonExecutaPlantilla.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.buttonExecutaPlantilla.UseSelectable = True
        Me.buttonExecutaPlantilla.UseTileImage = True
        '
        'chkRespectTemplates
        '
        Me.chkRespectTemplates.AutoSize = True
        Me.chkRespectTemplates.Location = New System.Drawing.Point(4, 64)
        Me.chkRespectTemplates.Name = "chkRespectTemplates"
        Me.chkRespectTemplates.Size = New System.Drawing.Size(187, 15)
        Me.chkRespectTemplates.TabIndex = 12
        Me.chkRespectTemplates.Text = "Respectar assignacions prèvies."
        Me.chkRespectTemplates.UseSelectable = True
        '
        'groupBoxEditPlantilla
        '
        Me.groupBoxEditPlantilla.BackColor = System.Drawing.Color.Transparent
        Me.groupBoxEditPlantilla.Controls.Add(Me.buttonEsborrarPlantilla)
        Me.groupBoxEditPlantilla.Controls.Add(Me.buttonEditarPlantilla)
        Me.groupBoxEditPlantilla.Controls.Add(Me.lbNomPlantilla)
        Me.groupBoxEditPlantilla.Enabled = False
        Me.groupBoxEditPlantilla.Location = New System.Drawing.Point(4, 146)
        Me.groupBoxEditPlantilla.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.groupBoxEditPlantilla.Name = "groupBoxEditPlantilla"
        Me.groupBoxEditPlantilla.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.groupBoxEditPlantilla.Size = New System.Drawing.Size(293, 275)
        Me.groupBoxEditPlantilla.TabIndex = 8
        Me.groupBoxEditPlantilla.TabStop = False
        Me.groupBoxEditPlantilla.Text = "Edició"
        '
        'buttonEsborrarPlantilla
        '
        Me.buttonEsborrarPlantilla.Image = CType(resources.GetObject("buttonEsborrarPlantilla.Image"), System.Drawing.Image)
        Me.buttonEsborrarPlantilla.Location = New System.Drawing.Point(66, 205)
        Me.buttonEsborrarPlantilla.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.buttonEsborrarPlantilla.Name = "buttonEsborrarPlantilla"
        Me.buttonEsborrarPlantilla.Size = New System.Drawing.Size(148, 58)
        Me.buttonEsborrarPlantilla.TabIndex = 9
        Me.buttonEsborrarPlantilla.UseVisualStyleBackColor = True
        '
        'buttonEditarPlantilla
        '
        Me.buttonEditarPlantilla.Image = CType(resources.GetObject("buttonEditarPlantilla.Image"), System.Drawing.Image)
        Me.buttonEditarPlantilla.Location = New System.Drawing.Point(66, 140)
        Me.buttonEditarPlantilla.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.buttonEditarPlantilla.Name = "buttonEditarPlantilla"
        Me.buttonEditarPlantilla.Size = New System.Drawing.Size(148, 58)
        Me.buttonEditarPlantilla.TabIndex = 8
        Me.buttonEditarPlantilla.UseVisualStyleBackColor = True
        '
        'lbNomPlantilla
        '
        Me.lbNomPlantilla.BackColor = System.Drawing.Color.Transparent
        Me.lbNomPlantilla.Location = New System.Drawing.Point(7, 25)
        Me.lbNomPlantilla.Name = "lbNomPlantilla"
        Me.lbNomPlantilla.Size = New System.Drawing.Size(279, 30)
        Me.lbNomPlantilla.TabIndex = 0
        Me.lbNomPlantilla.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label68
        '
        Me.Label68.BackColor = System.Drawing.Color.Transparent
        Me.Label68.Location = New System.Drawing.Point(3, 9)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(191, 22)
        Me.Label68.TabIndex = 1
        Me.Label68.Text = "Nom"
        '
        'comboBoxPlantillesPubli
        '
        Me.comboBoxPlantillesPubli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxPlantillesPubli.FormattingEnabled = True
        Me.comboBoxPlantillesPubli.Location = New System.Drawing.Point(4, 32)
        Me.comboBoxPlantillesPubli.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.comboBoxPlantillesPubli.Name = "comboBoxPlantillesPubli"
        Me.comboBoxPlantillesPubli.Size = New System.Drawing.Size(292, 25)
        Me.comboBoxPlantillesPubli.TabIndex = 0
        '
        'PanelSearchPubli
        '
        Me.PanelSearchPubli.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelSearchPubli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelSearchPubli.Controls.Add(Me.lbTitleSearch)
        Me.PanelSearchPubli.Controls.Add(Me.chkActual)
        Me.PanelSearchPubli.Controls.Add(Me.chkPropiaSearch)
        Me.PanelSearchPubli.Controls.Add(Me.chkFacturaSearch)
        Me.PanelSearchPubli.Controls.Add(Me.chkValidaSearch)
        Me.PanelSearchPubli.Controls.Add(Me.chkActiveSearch)
        Me.PanelSearchPubli.Controls.Add(Me.ButtonSearch)
        Me.PanelSearchPubli.Controls.Add(Me.Label71)
        Me.PanelSearchPubli.Controls.Add(Me.Label72)
        Me.PanelSearchPubli.Controls.Add(Me.Label73)
        Me.PanelSearchPubli.Controls.Add(Me.Label74)
        Me.PanelSearchPubli.Controls.Add(Me.txtMarcaSearch)
        Me.PanelSearchPubli.Controls.Add(Me.ComboProducSearch)
        Me.PanelSearchPubli.Controls.Add(Me.ComboClientSearch)
        Me.PanelSearchPubli.Controls.Add(Me.txtNomSearch)
        Me.PanelSearchPubli.Controls.Add(Me.Label70)
        Me.PanelSearchPubli.Controls.Add(Me.ButtonHideSearch)
        Me.PanelSearchPubli.Location = New System.Drawing.Point(335, 42)
        Me.PanelSearchPubli.Name = "PanelSearchPubli"
        Me.PanelSearchPubli.Size = New System.Drawing.Size(323, 422)
        Me.PanelSearchPubli.TabIndex = 189
        Me.PanelSearchPubli.Visible = False
        '
        'lbTitleSearch
        '
        Me.lbTitleSearch.AutoSize = True
        Me.lbTitleSearch.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lbTitleSearch.Location = New System.Drawing.Point(28, 17)
        Me.lbTitleSearch.Name = "lbTitleSearch"
        Me.lbTitleSearch.Size = New System.Drawing.Size(119, 25)
        Me.lbTitleSearch.TabIndex = 42
        Me.lbTitleSearch.Text = "Buscar falca ..."
        '
        'chkActual
        '
        Me.chkActual.AutoSize = True
        Me.chkActual.Location = New System.Drawing.Point(114, 307)
        Me.chkActual.Name = "chkActual"
        Me.chkActual.Size = New System.Drawing.Size(191, 15)
        Me.chkActual.TabIndex = 41
        Me.chkActual.Text = "Vigents (actives i no caducades)"
        Me.chkActual.UseSelectable = True
        '
        'chkPropiaSearch
        '
        Me.chkPropiaSearch.AutoSize = True
        Me.chkPropiaSearch.Location = New System.Drawing.Point(114, 283)
        Me.chkPropiaSearch.Name = "chkPropiaSearch"
        Me.chkPropiaSearch.Size = New System.Drawing.Size(115, 15)
        Me.chkPropiaSearch.TabIndex = 40
        Me.chkPropiaSearch.Text = "Pròpia de la ràdio"
        Me.chkPropiaSearch.UseSelectable = True
        '
        'chkFacturaSearch
        '
        Me.chkFacturaSearch.AutoSize = True
        Me.chkFacturaSearch.Location = New System.Drawing.Point(114, 259)
        Me.chkFacturaSearch.Name = "chkFacturaSearch"
        Me.chkFacturaSearch.Size = New System.Drawing.Size(75, 15)
        Me.chkFacturaSearch.TabIndex = 39
        Me.chkFacturaSearch.Text = "Facturada"
        Me.chkFacturaSearch.UseSelectable = True
        '
        'chkValidaSearch
        '
        Me.chkValidaSearch.AutoSize = True
        Me.chkValidaSearch.Location = New System.Drawing.Point(114, 235)
        Me.chkValidaSearch.Name = "chkValidaSearch"
        Me.chkValidaSearch.Size = New System.Drawing.Size(54, 15)
        Me.chkValidaSearch.TabIndex = 38
        Me.chkValidaSearch.Text = "Vàlida"
        Me.chkValidaSearch.UseSelectable = True
        '
        'chkActiveSearch
        '
        Me.chkActiveSearch.AutoSize = True
        Me.chkActiveSearch.Location = New System.Drawing.Point(114, 211)
        Me.chkActiveSearch.Name = "chkActiveSearch"
        Me.chkActiveSearch.Size = New System.Drawing.Size(56, 15)
        Me.chkActiveSearch.TabIndex = 37
        Me.chkActiveSearch.Text = "Activa"
        Me.chkActiveSearch.UseSelectable = True
        '
        'ButtonSearch
        '
        Me.ButtonSearch.ActiveControl = Nothing
        Me.ButtonSearch.Location = New System.Drawing.Point(73, 349)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.Size = New System.Drawing.Size(199, 54)
        Me.ButtonSearch.TabIndex = 36
        Me.ButtonSearch.TileImage = CType(resources.GetObject("ButtonSearch.TileImage"), System.Drawing.Image)
        Me.ButtonSearch.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ButtonSearch.UseSelectable = True
        Me.ButtonSearch.UseTileImage = True
        '
        'Label71
        '
        Me.Label71.Location = New System.Drawing.Point(13, 183)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(94, 17)
        Me.Label71.TabIndex = 35
        Me.Label71.Text = "Marca"
        Me.Label71.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label72
        '
        Me.Label72.Location = New System.Drawing.Point(13, 147)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(94, 17)
        Me.Label72.TabIndex = 34
        Me.Label72.Text = "Producte"
        Me.Label72.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label73
        '
        Me.Label73.Location = New System.Drawing.Point(13, 110)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(94, 17)
        Me.Label73.TabIndex = 33
        Me.Label73.Text = "Client"
        Me.Label73.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label74
        '
        Me.Label74.Location = New System.Drawing.Point(13, 75)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(94, 17)
        Me.Label74.TabIndex = 32
        Me.Label74.Text = "Nom"
        Me.Label74.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtMarcaSearch
        '
        Me.txtMarcaSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMarcaSearch.Location = New System.Drawing.Point(114, 179)
        Me.txtMarcaSearch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtMarcaSearch.Name = "txtMarcaSearch"
        Me.txtMarcaSearch.Size = New System.Drawing.Size(197, 25)
        Me.txtMarcaSearch.TabIndex = 31
        '
        'ComboProducSearch
        '
        Me.ComboProducSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboProducSearch.FormattingEnabled = True
        Me.ComboProducSearch.Location = New System.Drawing.Point(114, 143)
        Me.ComboProducSearch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboProducSearch.Name = "ComboProducSearch"
        Me.ComboProducSearch.Size = New System.Drawing.Size(197, 25)
        Me.ComboProducSearch.TabIndex = 30
        '
        'ComboClientSearch
        '
        Me.ComboClientSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboClientSearch.FormattingEnabled = True
        Me.ComboClientSearch.Location = New System.Drawing.Point(114, 106)
        Me.ComboClientSearch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboClientSearch.Name = "ComboClientSearch"
        Me.ComboClientSearch.Size = New System.Drawing.Size(197, 25)
        Me.ComboClientSearch.TabIndex = 29
        '
        'txtNomSearch
        '
        Me.txtNomSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNomSearch.Location = New System.Drawing.Point(114, 71)
        Me.txtNomSearch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNomSearch.Name = "txtNomSearch"
        Me.txtNomSearch.Size = New System.Drawing.Size(197, 25)
        Me.txtNomSearch.TabIndex = 28
        '
        'Label70
        '
        Me.Label70.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Label70.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label70.Location = New System.Drawing.Point(-1, 0)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(323, 6)
        Me.Label70.TabIndex = 14
        '
        'ButtonHideSearch
        '
        Me.ButtonHideSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonHideSearch.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonHideSearch.Image = CType(resources.GetObject("ButtonHideSearch.Image"), System.Drawing.Image)
        Me.ButtonHideSearch.ImageSize = 32
        Me.ButtonHideSearch.Location = New System.Drawing.Point(276, 5)
        Me.ButtonHideSearch.Name = "ButtonHideSearch"
        Me.ButtonHideSearch.Size = New System.Drawing.Size(40, 42)
        Me.ButtonHideSearch.TabIndex = 13
        Me.ButtonHideSearch.UseSelectable = True
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
        'frmPubli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(992, 561)
        Me.Controls.Add(Me.pic_logo)
        Me.Controls.Add(Me.PanelAssistent)
        Me.Controls.Add(Me.picVuMeter)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.PanelSearchPubli)
        Me.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmPubli"
        Me.Padding = New System.Windows.Forms.Padding(23, 78, 23, 26)
        Me.Text = "Manteniment de la Publicitat"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.gridDades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabCtlDies.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.PanelDia.ResumeLayout(False)
        Me.PanelDia.PerformLayout()
        Me.PanelFrH.ResumeLayout(False)
        Me.PanelBlocs.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picPlay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPause, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUnLock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picVuMeter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelAssistent.ResumeLayout(False)
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.MetroTabPage1.PerformLayout()
        Me.MetroTabPage2.ResumeLayout(False)
        Me.MetroTabPage2.PerformLayout()
        Me.groupBoxEditPlantilla.ResumeLayout(False)
        Me.PanelSearchPubli.ResumeLayout(False)
        Me.PanelSearchPubli.PerformLayout()
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
    Friend WithEvents cmdAssistBlocs As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdSortir As System.Windows.Forms.ToolStripButton
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ProgarmaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReproductorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPlay As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuStop As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuCalcDurada As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EdicióToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuModif As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuBuscar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRefresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbDataCrea As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lbID As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ComboTarifes As System.Windows.Forms.ComboBox
    Friend WithEvents cbTarifa As System.Windows.Forms.LinkLabel
    Friend WithEvents txtComent As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbDurada As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMarca As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboProducte As System.Windows.Forms.ComboBox
    Friend WithEvents lbProducte As System.Windows.Forms.LinkLabel
    Friend WithEvents ComboClient As System.Windows.Forms.ComboBox
    Friend WithEvents lbClient As System.Windows.Forms.LinkLabel
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboLocutor As System.Windows.Forms.ComboBox
    Friend WithEvents lbLocutor As System.Windows.Forms.LinkLabel
    Friend WithEvents ComboTecnic As System.Windows.Forms.ComboBox
    Friend WithEvents lbTecnic As System.Windows.Forms.LinkLabel
    Friend WithEvents lbNRadia As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage8 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage9 As System.Windows.Forms.TabPage
    Friend WithEvents PanelDia As System.Windows.Forms.Panel
    Friend WithEvents PanelFrH As System.Windows.Forms.Panel
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents PanelBlocs As System.Windows.Forms.Panel
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents picLock As System.Windows.Forms.PictureBox
    Friend WithEvents picUnLock As System.Windows.Forms.PictureBox
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lbVuMeter As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lbAtencio As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmdPlay As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdStop As System.Windows.Forms.ToolStripButton
    Friend WithEvents picPlay As System.Windows.Forms.PictureBox
    Friend WithEvents picPause As System.Windows.Forms.PictureBox
    Friend WithEvents picVuMeter As System.Windows.Forms.PictureBox
    Friend WithEvents tmrDetalls As System.Windows.Forms.Timer
    Friend WithEvents tmrPlayer As System.Windows.Forms.Timer
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents mnuFinal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEditAudio As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AjudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnu_Help As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbNou As ToolStripLabel
    Friend WithEvents chkPropia As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chkFactura As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chkValida As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chkActive As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents txtDataOut As MetroFramework.Controls.MetroDateTime
    Friend WithEvents txtDataIn As MetroFramework.Controls.MetroDateTime
    Friend WithEvents TabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents TabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents TabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents TabCtlDies As MetroFramework.Controls.MetroTabControl
    Friend WithEvents TabPage3 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents CheckBox96 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox95 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox94 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox93 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox92 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox91 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox90 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox89 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox88 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox87 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox86 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox85 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox84 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox83 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox82 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox81 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox80 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox79 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox78 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox77 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox76 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox75 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox74 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox73 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox72 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox71 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox70 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox69 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox68 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox67 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox66 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox65 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox64 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox63 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox62 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox61 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox60 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox59 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox58 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox57 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox56 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox55 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox54 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox53 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox52 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox51 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox50 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox49 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox48 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox47 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox46 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox45 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox44 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox43 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox42 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox41 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox40 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox39 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox38 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox37 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox36 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox35 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox34 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox33 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox32 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox31 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox30 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox29 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox28 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox27 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox26 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox25 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox24 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox23 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox22 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox21 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox20 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox19 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox18 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox17 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox16 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox15 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox14 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox13 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox12 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox11 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox10 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox9 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox8 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox7 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox6 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox5 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox4 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox3 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox2 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CheckBox1 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents gridDades As MetroFramework.Controls.MetroGrid
    Friend WithEvents PanelAssistent As Panel
    Friend WithEvents ButtonHideAssist As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents chk_Hores_all As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chk_DiesAll As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents cmdCalc As MetroFramework.Controls.MetroTile
    Friend WithEvents chkRespect As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents txtMaxPubliDia As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNumRadi As TextBox
    Friend WithEvents Label65 As Label
    Friend WithEvents Label66 As Label
    Friend WithEvents Label67 As Label
    Friend WithEvents lstHoresDisp As CheckedListBox
    Friend WithEvents lstDiesDisp As CheckedListBox
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents buttonNovaPlantilla As Button
    Friend WithEvents buttonExecutaPlantilla As MetroFramework.Controls.MetroTile
    Friend WithEvents chkRespectTemplates As MetroFramework.Controls.MetroCheckBox
    Private WithEvents groupBoxEditPlantilla As GroupBox
    Friend WithEvents buttonEsborrarPlantilla As Button
    Friend WithEvents buttonEditarPlantilla As Button
    Private WithEvents lbNomPlantilla As Label
    Private WithEvents Label68 As Label
    Private WithEvents comboBoxPlantillesPubli As ComboBox
    Friend WithEvents Label69 As Label
    Friend WithEvents PanelSearchPubli As Panel
    Friend WithEvents Label70 As Label
    Friend WithEvents ButtonHideSearch As MetroFramework.Controls.MetroLink
    Friend WithEvents lbTitleSearch As MetroFramework.Controls.MetroLabel
    Friend WithEvents chkActual As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chkPropiaSearch As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chkFacturaSearch As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chkValidaSearch As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chkActiveSearch As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents ButtonSearch As MetroFramework.Controls.MetroTile
    Friend WithEvents Label71 As Label
    Friend WithEvents Label72 As Label
    Friend WithEvents Label73 As Label
    Friend WithEvents Label74 As Label
    Friend WithEvents txtMarcaSearch As TextBox
    Friend WithEvents ComboProducSearch As ComboBox
    Friend WithEvents ComboClientSearch As ComboBox
    Friend WithEvents txtNomSearch As TextBox
    Friend WithEvents ColumnID As DataGridViewTextBoxColumn
    Friend WithEvents ColumnNom As DataGridViewTextBoxColumn
    Friend WithEvents ComboGridClient As DataGridViewComboBoxColumn
    Friend WithEvents ComboGridProducte As DataGridViewComboBoxColumn
    Friend WithEvents ColumnMarca As DataGridViewTextBoxColumn
    Friend WithEvents ComboGridTarifa As DataGridViewComboBoxColumn
    Friend WithEvents ColumnComent As DataGridViewTextBoxColumn
    Friend WithEvents ColumnDurada As DataGridViewTextBoxColumn
    Friend WithEvents ColumnDataCrea As DataGridViewTextBoxColumn
    Friend WithEvents ColumnNumRadi As DataGridViewTextBoxColumn
    Friend WithEvents ColumnDataIn As DataGridViewTextBoxColumn
    Friend WithEvents ColumnDataOut As DataGridViewTextBoxColumn
    Friend WithEvents ComboGridTecnic As DataGridViewComboBoxColumn
    Friend WithEvents ComboGridLocutor As DataGridViewComboBoxColumn
    Friend WithEvents ColumnActiva As DataGridViewCheckBoxColumn
    Friend WithEvents ColumnValida As DataGridViewCheckBoxColumn
    Friend WithEvents ColumnFacturada As DataGridViewCheckBoxColumn
    Friend WithEvents ColumnPropia As DataGridViewCheckBoxColumn
    Friend WithEvents ColumnDataRadi As DataGridViewTextBoxColumn
    Friend WithEvents pic_logo As PictureBox
End Class
