<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParams
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
        Me.components = New System.ComponentModel.Container()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Directoris", 1, 1)
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Codificació Àudio", 15, 15)
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fitxers d'Àudio")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Moneda", 3, 3)
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Regles")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Seqüències Pautes", 9, 9)
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("MSC Directe", 4, 4, New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode6})
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Connexió Emissora Central")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Control Remot", 11, 11)
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("MSC Controler", 5, 5, New System.Windows.Forms.TreeNode() {TreeNode8, TreeNode9})
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("MSC Cartutxeres", 6, 6)
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Connexió d'accés", 7, 7)
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Servei d'emergència", 10, 10)
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Paràmetres", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode7, TreeNode10, TreeNode11, TreeNode12, TreeNode13})
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Dades", 20, 20)
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Usuaris", 12, 12)
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Programes")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Núvol Comunitari", New System.Windows.Forms.TreeNode() {TreeNode17})
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Integració web", 8, 8)
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Streaming", 16, 16)
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Services MSC-soft.com", 2, 2, New System.Windows.Forms.TreeNode() {TreeNode18, TreeNode19, TreeNode20})
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Equipat amb ...", 0, 0)
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Informació del Sistema")
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Crèdits", 2, 2, New System.Windows.Forms.TreeNode() {TreeNode22, TreeNode23})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmParams))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TreeViewParams = New System.Windows.Forms.TreeView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupCredits = New System.Windows.Forms.GroupBox()
        Me.MetroPanel3 = New MetroFramework.Controls.MetroPanel()
        Me.groupBox14 = New System.Windows.Forms.GroupBox()
        Me.label52 = New System.Windows.Forms.Label()
        Me.linkMysqlBackup = New System.Windows.Forms.LinkLabel()
        Me.lbVerMySqlBackup = New System.Windows.Forms.Label()
        Me.label84 = New System.Windows.Forms.Label()
        Me.GroupBox21 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.groupBox20 = New System.Windows.Forms.GroupBox()
        Me.label145 = New System.Windows.Forms.Label()
        Me.linkLabelJamendo = New System.Windows.Forms.LinkLabel()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Label92 = New System.Windows.Forms.Label()
        Me.LinkLbLame = New System.Windows.Forms.LinkLabel()
        Me.LinkLbBass = New System.Windows.Forms.LinkLabel()
        Me.Label95 = New System.Windows.Forms.Label()
        Me.lbVersioBass = New System.Windows.Forms.Label()
        Me.Label97 = New System.Windows.Forms.Label()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.LinkLbMySql = New System.Windows.Forms.LinkLabel()
        Me.lbVerMysql = New System.Windows.Forms.Label()
        Me.Label99 = New System.Windows.Forms.Label()
        Me.groupBoxCloudPrograms = New System.Windows.Forms.GroupBox()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.tabPagePrgCloudPropis = New MetroFramework.Controls.MetroTabPage()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LbInfoConvida = New MetroFramework.Controls.MetroLabel()
        Me.TxtCodeToShare = New MetroFramework.Controls.MetroTextBox()
        Me.ButtonSetSharePrg = New MetroFramework.Controls.MetroTile()
        Me.dataGridViewProgramsShared = New MetroFramework.Controls.MetroGrid()
        Me.Column_prg_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_prg_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_prg_emissora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_prg_hash = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_prg_state = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ColumnCli_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_prg_delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.pic_cloudUp = New System.Windows.Forms.PictureBox()
        Me.label54 = New System.Windows.Forms.Label()
        Me.label136 = New System.Windows.Forms.Label()
        Me.cmbProgramesPropis = New System.Windows.Forms.ComboBox()
        Me.tabPagePrgShareCloud = New MetroFramework.Controls.MetroTabPage()
        Me.lbInfoPrgCloud = New MetroFramework.Controls.MetroLabel()
        Me.ButtonImportProgram = New MetroFramework.Controls.MetroTile()
        Me.txtCodeShareImport = New MetroFramework.Controls.MetroTextBox()
        Me.dataGridViewProgramsCloud = New MetroFramework.Controls.MetroGrid()
        Me.dataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnFrom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pic_cloudDown = New System.Windows.Forms.PictureBox()
        Me.label139 = New System.Windows.Forms.Label()
        Me.grupSequencies = New System.Windows.Forms.GroupBox()
        Me.cmdDelSequenc = New MetroFramework.Controls.MetroButton()
        Me.cmdAddSequenc = New MetroFramework.Controls.MetroButton()
        Me.label116 = New System.Windows.Forms.Label()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.lbNovaSequ = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBoxSequencies = New System.Windows.Forms.ComboBox()
        Me.ListBoxSequencies = New System.Windows.Forms.ListBox()
        Me.DataGridViewValorsSequ = New System.Windows.Forms.DataGridView()
        Me.ColumnValors = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.groupBoxStreaming = New System.Windows.Forms.GroupBox()
        Me.groupBoxParamsServer = New System.Windows.Forms.GroupBox()
        Me.label128 = New System.Windows.Forms.Label()
        Me.txtEstil = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.label129 = New System.Windows.Forms.Label()
        Me.label130 = New System.Windows.Forms.Label()
        Me.txtMountpoint = New System.Windows.Forms.TextBox()
        Me.comboBoxServerStream = New System.Windows.Forms.ComboBox()
        Me.label131 = New System.Windows.Forms.Label()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.label132 = New System.Windows.Forms.Label()
        Me.txtServer = New System.Windows.Forms.TextBox()
        Me.label133 = New System.Windows.Forms.Label()
        Me.groupBoxQualityServer = New System.Windows.Forms.GroupBox()
        Me.txtStreamCannels = New MetroFramework.Controls.MetroTextBox()
        Me.txtStreamSampleRate = New MetroFramework.Controls.MetroTextBox()
        Me.txtStreamBitRate = New MetroFramework.Controls.MetroTextBox()
        Me.label28 = New System.Windows.Forms.Label()
        Me.label126 = New System.Windows.Forms.Label()
        Me.label127 = New System.Windows.Forms.Label()
        Me.txtURLStreaming = New System.Windows.Forms.TextBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.GroupInfoSistema = New System.Windows.Forms.GroupBox()
        Me.Label109 = New System.Windows.Forms.Label()
        Me.txtInformeSistema = New System.Windows.Forms.TextBox()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.lbVerAplic = New System.Windows.Forms.Label()
        Me.Label93 = New System.Windows.Forms.Label()
        Me.Label100 = New System.Windows.Forms.Label()
        Me.lbVerDBS = New System.Windows.Forms.Label()
        Me.grupWeb = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtNumTracs = New System.Windows.Forms.TextBox()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.txtNumVots = New System.Windows.Forms.TextBox()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.label113 = New System.Windows.Forms.Label()
        Me.label112 = New System.Windows.Forms.Label()
        Me.txtPermanenciaPodcast = New System.Windows.Forms.TextBox()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.ComboBoxSelectQualitatPodcast = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.PanelFTP = New System.Windows.Forms.Panel()
        Me.cmdTestFTP = New MetroFramework.Controls.MetroButton()
        Me.txtPswFTP = New System.Windows.Forms.TextBox()
        Me.txtUserFTP = New System.Windows.Forms.TextBox()
        Me.txtDirFTP = New System.Windows.Forms.TextBox()
        Me.txtServerFTP = New System.Windows.Forms.TextBox()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.grupConnRemot = New System.Windows.Forms.GroupBox()
        Me.sldMilFader = New MetroFramework.Controls.MetroTrackBar()
        Me.sldVolfader = New MetroFramework.Controls.MetroTrackBar()
        Me.Label88 = New System.Windows.Forms.Label()
        Me.lbMilFader = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbVolfader = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.grupControler = New System.Windows.Forms.GroupBox()
        Me.sldMilSegSH = New MetroFramework.Controls.MetroTrackBar()
        Me.txtSenyHora = New MetroFramework.Controls.MetroTextBox()
        Me.label91 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lbMilSegSH = New System.Windows.Forms.Label()
        Me.grupPath = New System.Windows.Forms.GroupBox()
        Me.lbPathBackup = New System.Windows.Forms.Label()
        Me.txtAternativeDir = New MetroFramework.Controls.MetroTextBox()
        Me.txtPathArrelAudio = New MetroFramework.Controls.MetroTextBox()
        Me.label134 = New System.Windows.Forms.Label()
        Me.lbPathPublicitat = New System.Windows.Forms.Label()
        Me.lbPathProgrames = New System.Windows.Forms.Label()
        Me.lbPathPautes = New System.Windows.Forms.Label()
        Me.lbPathAudioUser = New System.Windows.Forms.Label()
        Me.picKO = New System.Windows.Forms.PictureBox()
        Me.picOK = New System.Windows.Forms.PictureBox()
        Me.lbPathMusica = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.grupReparar = New System.Windows.Forms.GroupBox()
        Me.groupBox17 = New System.Windows.Forms.GroupBox()
        Me.buttonSincroWeb = New MetroFramework.Controls.MetroButton()
        Me.chkAllDBS = New MetroFramework.Controls.MetroCheckBox()
        Me.label140 = New System.Windows.Forms.Label()
        Me.groupBox16 = New System.Windows.Forms.GroupBox()
        Me.chkLastBKP = New MetroFramework.Controls.MetroCheckBox()
        Me.lbLastBKP = New System.Windows.Forms.Label()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.cmdProgresCancel = New MetroFramework.Controls.MetroButton()
        Me.ProgressBar = New MetroFramework.Controls.MetroProgressBar()
        Me.cmdReparIDs = New MetroFramework.Controls.MetroButton()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.GroupClients = New System.Windows.Forms.GroupBox()
        Me.lbOnline = New MetroFramework.Controls.MetroLabel()
        Me.chkOnLine = New MetroFramework.Controls.MetroToggle()
        Me.cmdActive = New MetroFramework.Controls.MetroTile()
        Me.groupBoxCloudShareOptions = New System.Windows.Forms.GroupBox()
        Me.chk_sharePrograms = New MetroFramework.Controls.MetroCheckBox()
        Me.cmdSalvarOptionsNuvol = New MetroFramework.Controls.MetroTile()
        Me.lbCientID = New System.Windows.Forms.Label()
        Me.txtClientKey = New System.Windows.Forms.TextBox()
        Me.Label85 = New System.Windows.Forms.Label()
        Me.LbClientKO = New System.Windows.Forms.Label()
        Me.LbClientOK = New System.Windows.Forms.Label()
        Me.grupParams = New System.Windows.Forms.GroupBox()
        Me.lbInfoProces = New System.Windows.Forms.Label()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.cmbLang = New System.Windows.Forms.ComboBox()
        Me.label125 = New System.Windows.Forms.Label()
        Me.txtWeb = New System.Windows.Forms.TextBox()
        Me.label124 = New System.Windows.Forms.Label()
        Me.label111 = New System.Windows.Forms.Label()
        Me.txtTwitterKey = New System.Windows.Forms.TextBox()
        Me.Label110 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTwitter = New System.Windows.Forms.TextBox()
        Me.txtFaceBook = New System.Windows.Forms.TextBox()
        Me.txtNomRadio = New System.Windows.Forms.TextBox()
        Me.cmdAddLogo = New System.Windows.Forms.Button()
        Me.imgLogo = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbNomRadio = New System.Windows.Forms.Label()
        Me.grupCarp = New System.Windows.Forms.GroupBox()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.grupCarpBlocs = New System.Windows.Forms.FlowLayoutPanel()
        Me.cmdAddCarpBlocs = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbCommentDesconnexio = New System.Windows.Forms.Label()
        Me.txtComentDesconnexio = New MetroFramework.Controls.MetroTextBox()
        Me.cmbTipProg = New System.Windows.Forms.ComboBox()
        Me.Label94 = New System.Windows.Forms.Label()
        Me.Label96 = New System.Windows.Forms.Label()
        Me.lbInfo = New System.Windows.Forms.Label()
        Me.lbRadForm = New System.Windows.Forms.Label()
        Me.grupMoneda = New System.Windows.Forms.GroupBox()
        Me.lbDies = New System.Windows.Forms.Label()
        Me.txtVDEF_DateOut = New System.Windows.Forms.TextBox()
        Me.lbDataOut = New System.Windows.Forms.Label()
        Me.txtCanvi = New System.Windows.Forms.TextBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.cmbContraValor = New System.Windows.Forms.ComboBox()
        Me.ComboBoxVDef_tarifa = New System.Windows.Forms.ComboBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.cmbMoneda = New System.Windows.Forms.ComboBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.lbTarifa = New System.Windows.Forms.Label()
        Me.grupCartut = New System.Windows.Forms.GroupBox()
        Me.chkCTL_USR_Cartux = New MetroFramework.Controls.MetroCheckBox()
        Me.chkActvTabProgram = New MetroFramework.Controls.MetroCheckBox()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.grupCategories = New System.Windows.Forms.GroupBox()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.lbTestHOld = New System.Windows.Forms.Label()
        Me.lbTestHHitTop = New System.Windows.Forms.Label()
        Me.lbTestHOldTop = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lbTestsHHit = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.lbTestHTop = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.lbTestHBorrInterp = New System.Windows.Forms.Label()
        Me.txtHTop = New System.Windows.Forms.TextBox()
        Me.label114 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtMinusProhivDisc = New System.Windows.Forms.TextBox()
        Me.txtHHit = New System.Windows.Forms.TextBox()
        Me.label115 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtHHitTop = New System.Windows.Forms.TextBox()
        Me.txtHBorrInterp = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtHOldTop = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtIntervRitme = New System.Windows.Forms.TextBox()
        Me.txtOld = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.txtNHitOld = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.txtNTopHit = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.chkCanviCat = New System.Windows.Forms.CheckBox()
        Me.txtMaxRadiOLD = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.txtMaxRadiHIT = New System.Windows.Forms.TextBox()
        Me.txtMaxRadiTop = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.grupSOS = New System.Windows.Forms.GroupBox()
        Me.labelActiveSOS = New MetroFramework.Controls.MetroLabel()
        Me.CheckBoxActiveSOS = New MetroFramework.Controls.MetroToggle()
        Me.buttonDelCtlLog = New MetroFramework.Controls.MetroButton()
        Me.txtPathLogErr = New MetroFramework.Controls.MetroTextBox()
        Me.label53 = New System.Windows.Forms.Label()
        Me.Label86 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.grupActiveSos = New System.Windows.Forms.GroupBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.chk_SendDevelop = New MetroFramework.Controls.MetroToggle()
        Me.cmdTestMailErr = New MetroFramework.Controls.MetroButton()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.txtMailDesti = New System.Windows.Forms.TextBox()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.txtMailRemitent = New System.Windows.Forms.TextBox()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.Label87 = New System.Windows.Forms.Label()
        Me.grupDBS = New System.Windows.Forms.GroupBox()
        Me.cmdAddDBS = New MetroFramework.Controls.MetroButton()
        Me.txtPathINI = New MetroFramework.Controls.MetroTextBox()
        Me.labelMltDBS = New MetroFramework.Controls.MetroLabel()
        Me.chkMltDBS = New MetroFramework.Controls.MetroToggle()
        Me.label51 = New System.Windows.Forms.Label()
        Me.GroupBoxDetallDBS = New System.Windows.Forms.GroupBox()
        Me.cmdExportConnection = New MetroFramework.Controls.MetroButton()
        Me.cmdDelDBS = New MetroFramework.Controls.MetroButton()
        Me.txtDBSPort = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDBSPassword = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDBSUser = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDBSHost = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDBSName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDBSDescip = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lstDBS = New System.Windows.Forms.ListBox()
        Me.grupDirecte = New System.Windows.Forms.GroupBox()
        Me.sldMSegOClok = New MetroFramework.Controls.MetroTrackBar()
        Me.chkForceHoraExect = New MetroFramework.Controls.MetroCheckBox()
        Me.chkBorHistInterp = New MetroFramework.Controls.MetroCheckBox()
        Me.lbMSegOClok = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.grupCR = New System.Windows.Forms.GroupBox()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.txtIntervalCR = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.DataGridViewInstruccionsCR = New MetroFramework.Controls.MetroGrid()
        Me.ColumnCodi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnAppDesti = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ColumnInstruc = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ColumnDescrip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonDelInstruccio = New MetroFramework.Controls.MetroButton()
        Me.ButtonAddInstrucioCR = New MetroFramework.Controls.MetroButton()
        Me.txtCodiCR = New System.Windows.Forms.TextBox()
        Me.ComboBoxListAplic = New System.Windows.Forms.ComboBox()
        Me.ComboBoxRemoteInstruc = New System.Windows.Forms.ComboBox()
        Me.txtDescripCR = New System.Windows.Forms.TextBox()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.txtPasswordCR = New System.Windows.Forms.TextBox()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.txtUsuariCR = New System.Windows.Forms.TextBox()
        Me.txtServerMailCR = New System.Windows.Forms.TextBox()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.txtRemitentCR = New System.Windows.Forms.TextBox()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.GroupBoxUsuaris = New System.Windows.Forms.GroupBox()
        Me.labelCtlPsw = New MetroFramework.Controls.MetroLabel()
        Me.chkCtlPsw = New MetroFramework.Controls.MetroToggle()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.cmdBorrHistori = New MetroFramework.Controls.MetroButton()
        Me.listURSErr = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label103 = New System.Windows.Forms.Label()
        Me.scrollMaxtemps = New System.Windows.Forms.VScrollBar()
        Me.txtMaxTemps = New System.Windows.Forms.TextBox()
        Me.Label98 = New System.Windows.Forms.Label()
        Me.txtIntentsUSR = New System.Windows.Forms.TextBox()
        Me.Label102 = New System.Windows.Forms.Label()
        Me.Label101 = New System.Windows.Forms.Label()
        Me.GroupBoxCodificacio = New System.Windows.Forms.GroupBox()
        Me.lbCaputeTag = New System.Windows.Forms.Label()
        Me.chkCaptureTag = New MetroFramework.Controls.MetroToggle()
        Me.lbFileDefActive = New System.Windows.Forms.Label()
        Me.chkVDef_activats = New MetroFramework.Controls.MetroToggle()
        Me.GroupCodecAudio = New System.Windows.Forms.GroupBox()
        Me.lbLameVer = New System.Windows.Forms.Label()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.chkPrivate = New System.Windows.Forms.CheckBox()
        Me.chkOriginal = New System.Windows.Forms.CheckBox()
        Me.chkCRC = New System.Windows.Forms.CheckBox()
        Me.chkCopyright = New System.Windows.Forms.CheckBox()
        Me.label121 = New System.Windows.Forms.Label()
        Me.label122 = New System.Windows.Forms.Label()
        Me.label123 = New System.Windows.Forms.Label()
        Me.cmbCodecAudioChannel = New System.Windows.Forms.ComboBox()
        Me.cmbCodecSampleRate = New System.Windows.Forms.ComboBox()
        Me.cmbCodecBitrate = New System.Windows.Forms.ComboBox()
        Me.label120 = New System.Windows.Forms.Label()
        Me.groupBox15 = New System.Windows.Forms.GroupBox()
        Me.chkRecord = New MetroFramework.Controls.MetroCheckBox()
        Me.Label104 = New System.Windows.Forms.Label()
        Me.fraConf = New System.Windows.Forms.GroupBox()
        Me.ComboBoxDuradaDef = New System.Windows.Forms.ComboBox()
        Me.Label105 = New System.Windows.Forms.Label()
        Me.Label106 = New System.Windows.Forms.Label()
        Me.Label107 = New System.Windows.Forms.Label()
        Me.Label108 = New System.Windows.Forms.Label()
        Me.cmbAudioChannel = New System.Windows.Forms.ComboBox()
        Me.cmbSampleRate = New System.Windows.Forms.ComboBox()
        Me.cmbBitrate = New System.Windows.Forms.ComboBox()
        Me.grupAudioUSR = New System.Windows.Forms.GroupBox()
        Me.GroupBoxCarpetes = New System.Windows.Forms.GroupBox()
        Me.FlowLayoutPanelCarpetes = New System.Windows.Forms.FlowLayoutPanel()
        Me.ButtonAddCarpeta = New System.Windows.Forms.Button()
        Me.gridAudioFiles = New MetroFramework.Controls.MetroGrid()
        Me.ColumnImageid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnImage = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_visible_cart = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ColumnVisible_cont = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ColumnCarp = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ColumnEnding = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Columnph = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cmdDelAudio = New MetroFramework.Controls.MetroButton()
        Me.cmdAddAudio = New MetroFramework.Controls.MetroButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProgramaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInternet = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.picLock = New System.Windows.Forms.PictureBox()
        Me.picUnLock = New System.Windows.Forms.PictureBox()
        Me.cmdSortir = New MetroFramework.Controls.MetroLink()
        Me.cmdSalvar = New MetroFramework.Controls.MetroTile()
        Me.CmdBloqueix = New MetroFramework.Controls.MetroLink()
        Me.lbAtencio = New MetroFramework.Controls.MetroLink()
        Me.lbSaved = New MetroFramework.Controls.MetroLink()
        Me.pic_logo = New System.Windows.Forms.PictureBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupCredits.SuspendLayout()
        Me.MetroPanel3.SuspendLayout()
        Me.groupBox14.SuspendLayout()
        Me.GroupBox21.SuspendLayout()
        Me.groupBox20.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.groupBoxCloudPrograms.SuspendLayout()
        Me.MetroTabControl1.SuspendLayout()
        Me.tabPagePrgCloudPropis.SuspendLayout()
        CType(Me.dataGridViewProgramsShared, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_cloudUp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPagePrgShareCloud.SuspendLayout()
        CType(Me.dataGridViewProgramsCloud, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_cloudDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupSequencies.SuspendLayout()
        CType(Me.DataGridViewValorsSequ, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBoxStreaming.SuspendLayout()
        Me.groupBoxParamsServer.SuspendLayout()
        Me.groupBoxQualityServer.SuspendLayout()
        Me.GroupInfoSistema.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.grupWeb.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.PanelFTP.SuspendLayout()
        Me.grupConnRemot.SuspendLayout()
        Me.grupControler.SuspendLayout()
        Me.grupPath.SuspendLayout()
        CType(Me.picKO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOK, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupReparar.SuspendLayout()
        Me.groupBox17.SuspendLayout()
        Me.groupBox16.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupClients.SuspendLayout()
        Me.groupBoxCloudShareOptions.SuspendLayout()
        Me.grupParams.SuspendLayout()
        Me.MetroPanel1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupCarp.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grupMoneda.SuspendLayout()
        Me.grupCartut.SuspendLayout()
        Me.grupCategories.SuspendLayout()
        Me.MetroPanel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grupSOS.SuspendLayout()
        Me.grupActiveSos.SuspendLayout()
        Me.grupDBS.SuspendLayout()
        Me.GroupBoxDetallDBS.SuspendLayout()
        Me.grupDirecte.SuspendLayout()
        Me.grupCR.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DataGridViewInstruccionsCR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxUsuaris.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBoxCodificacio.SuspendLayout()
        Me.GroupCodecAudio.SuspendLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox15.SuspendLayout()
        Me.fraConf.SuspendLayout()
        Me.grupAudioUSR.SuspendLayout()
        Me.GroupBoxCarpetes.SuspendLayout()
        CType(Me.gridAudioFiles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
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
        Me.SplitContainer1.Location = New System.Drawing.Point(25, 124)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TreeViewParams)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupCredits)
        Me.SplitContainer1.Panel2.Controls.Add(Me.groupBoxCloudPrograms)
        Me.SplitContainer1.Panel2.Controls.Add(Me.grupSequencies)
        Me.SplitContainer1.Panel2.Controls.Add(Me.groupBoxStreaming)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupInfoSistema)
        Me.SplitContainer1.Panel2.Controls.Add(Me.grupWeb)
        Me.SplitContainer1.Panel2.Controls.Add(Me.grupConnRemot)
        Me.SplitContainer1.Panel2.Controls.Add(Me.grupControler)
        Me.SplitContainer1.Panel2.Controls.Add(Me.grupPath)
        Me.SplitContainer1.Panel2.Controls.Add(Me.grupReparar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupClients)
        Me.SplitContainer1.Panel2.Controls.Add(Me.grupParams)
        Me.SplitContainer1.Panel2.Controls.Add(Me.grupMoneda)
        Me.SplitContainer1.Panel2.Controls.Add(Me.grupCartut)
        Me.SplitContainer1.Panel2.Controls.Add(Me.grupCategories)
        Me.SplitContainer1.Panel2.Controls.Add(Me.grupSOS)
        Me.SplitContainer1.Panel2.Controls.Add(Me.grupDBS)
        Me.SplitContainer1.Panel2.Controls.Add(Me.grupDirecte)
        Me.SplitContainer1.Panel2.Controls.Add(Me.grupCR)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBoxUsuaris)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBoxCodificacio)
        Me.SplitContainer1.Panel2.Controls.Add(Me.grupAudioUSR)
        Me.SplitContainer1.Size = New System.Drawing.Size(956, 433)
        Me.SplitContainer1.SplitterDistance = 322
        Me.SplitContainer1.TabIndex = 0
        '
        'TreeViewParams
        '
        Me.TreeViewParams.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeViewParams.ImageIndex = 0
        Me.TreeViewParams.ImageList = Me.ImageList1
        Me.TreeViewParams.Location = New System.Drawing.Point(0, 0)
        Me.TreeViewParams.Name = "TreeViewParams"
        TreeNode1.ImageIndex = 1
        TreeNode1.Name = "Node1"
        TreeNode1.SelectedImageIndex = 1
        TreeNode1.Tag = "1"
        TreeNode1.Text = "Directoris"
        TreeNode2.ImageIndex = 15
        TreeNode2.Name = "Nodo0"
        TreeNode2.SelectedImageIndex = 15
        TreeNode2.Tag = "20"
        TreeNode2.Text = "Codificació Àudio"
        TreeNode3.Name = "Node20"
        TreeNode3.Tag = "10"
        TreeNode3.Text = "Fitxers d'Àudio"
        TreeNode4.ImageIndex = 3
        TreeNode4.Name = "Node11"
        TreeNode4.SelectedImageIndex = 3
        TreeNode4.Tag = "2"
        TreeNode4.Text = "Moneda"
        TreeNode5.Name = "Node13"
        TreeNode5.Tag = "4"
        TreeNode5.Text = "Regles"
        TreeNode6.ImageIndex = 9
        TreeNode6.Name = "Nodo0"
        TreeNode6.SelectedImageIndex = 9
        TreeNode6.Tag = "6"
        TreeNode6.Text = "Seqüències Pautes"
        TreeNode7.ImageIndex = 4
        TreeNode7.Name = "Node12"
        TreeNode7.SelectedImageIndex = 4
        TreeNode7.Tag = "3"
        TreeNode7.Text = "MSC Directe"
        TreeNode8.Name = "Node16"
        TreeNode8.Tag = "8"
        TreeNode8.Text = "Connexió Emissora Central"
        TreeNode9.ImageIndex = 11
        TreeNode9.Name = "NodoCR"
        TreeNode9.SelectedImageIndex = 11
        TreeNode9.Tag = "14"
        TreeNode9.Text = "Control Remot"
        TreeNode10.ImageIndex = 5
        TreeNode10.Name = "Node15"
        TreeNode10.SelectedImageIndex = 5
        TreeNode10.Tag = "7"
        TreeNode10.Text = "MSC Controler"
        TreeNode11.ImageIndex = 6
        TreeNode11.Name = "Node18"
        TreeNode11.SelectedImageIndex = 6
        TreeNode11.Tag = "9"
        TreeNode11.Text = "MSC Cartutxeres"
        TreeNode12.ImageIndex = 7
        TreeNode12.Name = "Node19"
        TreeNode12.SelectedImageIndex = 7
        TreeNode12.Tag = "11"
        TreeNode12.Text = "Connexió d'accés"
        TreeNode13.ImageIndex = 10
        TreeNode13.Name = "Nodo1"
        TreeNode13.SelectedImageIndex = 10
        TreeNode13.Tag = "13"
        TreeNode13.Text = "Servei d'emergència"
        TreeNode14.Checked = True
        TreeNode14.Name = "Node0"
        TreeNode14.Tag = "0"
        TreeNode14.Text = "Paràmetres"
        TreeNode15.ImageIndex = 20
        TreeNode15.Name = "Nodo2"
        TreeNode15.SelectedImageIndex = 20
        TreeNode15.Tag = "16"
        TreeNode15.Text = "Dades"
        TreeNode16.ImageIndex = 12
        TreeNode16.Name = "Nodo0"
        TreeNode16.SelectedImageIndex = 12
        TreeNode16.Tag = "19"
        TreeNode16.Text = "Usuaris"
        TreeNode17.ForeColor = System.Drawing.Color.Gray
        TreeNode17.ImageKey = "program.gif"
        TreeNode17.Name = "Nodo0"
        TreeNode17.SelectedImageKey = "program.gif"
        TreeNode17.Tag = "23"
        TreeNode17.Text = "Programes"
        TreeNode18.ForeColor = System.Drawing.Color.Gray
        TreeNode18.ImageKey = "Cloud-blue.png"
        TreeNode18.Name = "Nodo0"
        TreeNode18.SelectedImageKey = "Cloud-blue.png"
        TreeNode18.Tag = "22"
        TreeNode18.Text = "Núvol Comunitari"
        TreeNode19.ForeColor = System.Drawing.Color.Gray
        TreeNode19.ImageIndex = 8
        TreeNode19.Name = "Nodo1"
        TreeNode19.SelectedImageIndex = 8
        TreeNode19.Tag = "12"
        TreeNode19.Text = "Integració web"
        TreeNode20.ForeColor = System.Drawing.Color.Gray
        TreeNode20.ImageIndex = 16
        TreeNode20.Name = "Nodo2"
        TreeNode20.SelectedImageIndex = 16
        TreeNode20.Tag = "21"
        TreeNode20.Text = "Streaming"
        TreeNode21.ImageIndex = 2
        TreeNode21.Name = "Node0"
        TreeNode21.SelectedImageIndex = 2
        TreeNode21.Tag = "22"
        TreeNode21.Text = "Services MSC-soft.com"
        TreeNode22.ImageIndex = 0
        TreeNode22.Name = "Nodo4"
        TreeNode22.SelectedImageIndex = 0
        TreeNode22.Tag = "18"
        TreeNode22.Text = "Equipat amb ..."
        TreeNode23.Name = "Nodo5"
        TreeNode23.Tag = "17"
        TreeNode23.Text = "Informació del Sistema"
        TreeNode24.ImageIndex = 2
        TreeNode24.Name = "Nodo0"
        TreeNode24.SelectedImageIndex = 2
        TreeNode24.Tag = "18"
        TreeNode24.Text = "Crèdits"
        Me.TreeViewParams.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode14, TreeNode15, TreeNode16, TreeNode21, TreeNode24})
        Me.TreeViewParams.SelectedImageIndex = 0
        Me.TreeViewParams.Size = New System.Drawing.Size(322, 433)
        Me.TreeViewParams.TabIndex = 0
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "params.gif")
        Me.ImageList1.Images.SetKeyName(1, "addFitxer.gif")
        Me.ImageList1.Images.SetKeyName(2, "MscLogo.ico")
        Me.ImageList1.Images.SetKeyName(3, "dollar.gif")
        Me.ImageList1.Images.SetKeyName(4, "logo-msc-continuity.png")
        Me.ImageList1.Images.SetKeyName(5, "controllerSiConnect.gif")
        Me.ImageList1.Images.SetKeyName(6, "cartut.ico")
        Me.ImageList1.Images.SetKeyName(7, "net.gif")
        Me.ImageList1.Images.SetKeyName(8, "web.ico")
        Me.ImageList1.Images.SetKeyName(9, "server.gif")
        Me.ImageList1.Images.SetKeyName(10, "pc-clinic.gif")
        Me.ImageList1.Images.SetKeyName(11, "mail.png")
        Me.ImageList1.Images.SetKeyName(12, "community_users.png")
        Me.ImageList1.Images.SetKeyName(13, "process.png")
        Me.ImageList1.Images.SetKeyName(14, "logologger.gif")
        Me.ImageList1.Images.SetKeyName(15, "temes.gif")
        Me.ImageList1.Images.SetKeyName(16, "icon-stream.ico")
        Me.ImageList1.Images.SetKeyName(17, "Cloud-blue.png")
        Me.ImageList1.Images.SetKeyName(18, "program.gif")
        Me.ImageList1.Images.SetKeyName(19, "clock.png")
        Me.ImageList1.Images.SetKeyName(20, "database.png")
        '
        'GroupCredits
        '
        Me.GroupCredits.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupCredits.Controls.Add(Me.MetroPanel3)
        Me.GroupCredits.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupCredits.Location = New System.Drawing.Point(0, 0)
        Me.GroupCredits.Name = "GroupCredits"
        Me.GroupCredits.Size = New System.Drawing.Size(630, 433)
        Me.GroupCredits.TabIndex = 22
        Me.GroupCredits.TabStop = False
        Me.GroupCredits.Text = "Crèdits"
        Me.GroupCredits.Visible = False
        '
        'MetroPanel3
        '
        Me.MetroPanel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroPanel3.AutoScroll = True
        Me.MetroPanel3.Controls.Add(Me.groupBox14)
        Me.MetroPanel3.Controls.Add(Me.GroupBox21)
        Me.MetroPanel3.Controls.Add(Me.groupBox20)
        Me.MetroPanel3.Controls.Add(Me.GroupBox9)
        Me.MetroPanel3.Controls.Add(Me.GroupBox10)
        Me.MetroPanel3.HorizontalScrollbar = True
        Me.MetroPanel3.HorizontalScrollbarBarColor = True
        Me.MetroPanel3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.HorizontalScrollbarSize = 10
        Me.MetroPanel3.Location = New System.Drawing.Point(6, 16)
        Me.MetroPanel3.Name = "MetroPanel3"
        Me.MetroPanel3.Size = New System.Drawing.Size(616, 413)
        Me.MetroPanel3.TabIndex = 1
        Me.MetroPanel3.VerticalScrollbar = True
        Me.MetroPanel3.VerticalScrollbarBarColor = True
        Me.MetroPanel3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.VerticalScrollbarSize = 10
        '
        'groupBox14
        '
        Me.groupBox14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBox14.Controls.Add(Me.label52)
        Me.groupBox14.Controls.Add(Me.linkMysqlBackup)
        Me.groupBox14.Controls.Add(Me.lbVerMySqlBackup)
        Me.groupBox14.Controls.Add(Me.label84)
        Me.groupBox14.Location = New System.Drawing.Point(3, 97)
        Me.groupBox14.Name = "groupBox14"
        Me.groupBox14.Size = New System.Drawing.Size(578, 90)
        Me.groupBox14.TabIndex = 6
        Me.groupBox14.TabStop = False
        Me.groupBox14.Text = "Còpies de seguretat"
        '
        'label52
        '
        Me.label52.AutoSize = True
        Me.label52.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.label52.Location = New System.Drawing.Point(16, 41)
        Me.label52.Name = "label52"
        Me.label52.Size = New System.Drawing.Size(418, 17)
        Me.label52.TabIndex = 3
        Me.label52.Text = "A tool to backup and restore MySQL database in C#/VB.NET/ASP.NET."
        '
        'linkMysqlBackup
        '
        Me.linkMysqlBackup.AutoSize = True
        Me.linkMysqlBackup.Location = New System.Drawing.Point(16, 63)
        Me.linkMysqlBackup.Name = "linkMysqlBackup"
        Me.linkMysqlBackup.Size = New System.Drawing.Size(233, 17)
        Me.linkMysqlBackup.TabIndex = 2
        Me.linkMysqlBackup.TabStop = True
        Me.linkMysqlBackup.Text = "https://mysqlbackupnet.codeplex.com/"
        '
        'lbVerMySqlBackup
        '
        Me.lbVerMySqlBackup.AutoSize = True
        Me.lbVerMySqlBackup.Location = New System.Drawing.Point(159, 20)
        Me.lbVerMySqlBackup.Name = "lbVerMySqlBackup"
        Me.lbVerMySqlBackup.Size = New System.Drawing.Size(42, 17)
        Me.lbVerMySqlBackup.TabIndex = 1
        Me.lbVerMySqlBackup.Text = "2.3.30"
        '
        'label84
        '
        Me.label84.AutoSize = True
        Me.label84.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label84.Location = New System.Drawing.Point(16, 19)
        Me.label84.Name = "label84"
        Me.label84.Size = New System.Drawing.Size(121, 13)
        Me.label84.TabIndex = 0
        Me.label84.Text = "MySqlBackup.NET :"
        '
        'GroupBox21
        '
        Me.GroupBox21.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox21.Controls.Add(Me.Label3)
        Me.GroupBox21.Controls.Add(Me.Label26)
        Me.GroupBox21.Controls.Add(Me.LinkLabel1)
        Me.GroupBox21.Location = New System.Drawing.Point(3, 322)
        Me.GroupBox21.Name = "GroupBox21"
        Me.GroupBox21.Size = New System.Drawing.Size(578, 81)
        Me.GroupBox21.TabIndex = 5
        Me.GroupBox21.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(19, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(317, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Windows Modern UI for .NET WinForms Applications"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(19, 17)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(100, 13)
        Me.Label26.TabIndex = 4
        Me.Label26.Text = "MetroFramework"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(19, 55)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(241, 17)
        Me.LinkLabel1.TabIndex = 3
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "https://thielj.github.io/MetroFramework/"
        '
        'groupBox20
        '
        Me.groupBox20.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBox20.Controls.Add(Me.label145)
        Me.groupBox20.Controls.Add(Me.linkLabelJamendo)
        Me.groupBox20.Location = New System.Drawing.Point(3, 407)
        Me.groupBox20.Name = "groupBox20"
        Me.groupBox20.Size = New System.Drawing.Size(578, 75)
        Me.groupBox20.TabIndex = 4
        Me.groupBox20.TabStop = False
        Me.groupBox20.Text = "Free music downloads"
        '
        'label145
        '
        Me.label145.AutoSize = True
        Me.label145.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.label145.Location = New System.Drawing.Point(19, 36)
        Me.label145.Name = "label145"
        Me.label145.Size = New System.Drawing.Size(509, 17)
        Me.label145.TabIndex = 7
        Me.label145.Text = "Discover free music downloads and streaming from thousands of independent artists" &
    "."
        '
        'linkLabelJamendo
        '
        Me.linkLabelJamendo.AutoSize = True
        Me.linkLabelJamendo.Location = New System.Drawing.Point(19, 55)
        Me.linkLabelJamendo.Name = "linkLabelJamendo"
        Me.linkLabelJamendo.Size = New System.Drawing.Size(164, 17)
        Me.linkLabelJamendo.TabIndex = 3
        Me.linkLabelJamendo.TabStop = True
        Me.linkLabelJamendo.Text = "https://www.jamendo.com/"
        '
        'GroupBox9
        '
        Me.GroupBox9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox9.Controls.Add(Me.Label92)
        Me.GroupBox9.Controls.Add(Me.LinkLbLame)
        Me.GroupBox9.Controls.Add(Me.LinkLbBass)
        Me.GroupBox9.Controls.Add(Me.Label95)
        Me.GroupBox9.Controls.Add(Me.lbVersioBass)
        Me.GroupBox9.Controls.Add(Me.Label97)
        Me.GroupBox9.Location = New System.Drawing.Point(3, 191)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(578, 127)
        Me.GroupBox9.TabIndex = 2
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Llibreries d'àudio"
        '
        'Label92
        '
        Me.Label92.AutoSize = True
        Me.Label92.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label92.Location = New System.Drawing.Point(16, 85)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(497, 17)
        Me.Label92.TabIndex = 6
        Me.Label92.Text = "LAME is a high quality MPEG Audio Layer III (MP3) encoder licensed under the LGPL" &
    "."
        '
        'LinkLbLame
        '
        Me.LinkLbLame.AutoSize = True
        Me.LinkLbLame.Location = New System.Drawing.Point(16, 105)
        Me.LinkLbLame.Name = "LinkLbLame"
        Me.LinkLbLame.Size = New System.Drawing.Size(167, 17)
        Me.LinkLbLame.TabIndex = 5
        Me.LinkLbLame.TabStop = True
        Me.LinkLbLame.Text = "http://lame.sourceforge.net"
        '
        'LinkLbBass
        '
        Me.LinkLbBass.AutoSize = True
        Me.LinkLbBass.Location = New System.Drawing.Point(16, 43)
        Me.LinkLbBass.Name = "LinkLbBass"
        Me.LinkLbBass.Size = New System.Drawing.Size(155, 17)
        Me.LinkLbBass.TabIndex = 4
        Me.LinkLbBass.TabStop = True
        Me.LinkLbBass.Text = "http://www.un4seen.com/"
        '
        'Label95
        '
        Me.Label95.AutoSize = True
        Me.Label95.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label95.Location = New System.Drawing.Point(16, 68)
        Me.Label95.Name = "Label95"
        Me.Label95.Size = New System.Drawing.Size(110, 13)
        Me.Label95.TabIndex = 3
        Me.Label95.Text = "The LAME Project"
        '
        'lbVersioBass
        '
        Me.lbVersioBass.AutoSize = True
        Me.lbVersioBass.Location = New System.Drawing.Point(161, 23)
        Me.lbVersioBass.Name = "lbVersioBass"
        Me.lbVersioBass.Size = New System.Drawing.Size(25, 17)
        Me.lbVersioBass.TabIndex = 2
        Me.lbVersioBass.Text = "2.4"
        '
        'Label97
        '
        Me.Label97.AutoSize = True
        Me.Label97.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label97.Location = New System.Drawing.Point(16, 22)
        Me.Label97.Name = "Label97"
        Me.Label97.Size = New System.Drawing.Size(120, 13)
        Me.Label97.TabIndex = 0
        Me.Label97.Text = "Bass Audio Library :"
        '
        'GroupBox10
        '
        Me.GroupBox10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox10.Controls.Add(Me.Label56)
        Me.GroupBox10.Controls.Add(Me.LinkLbMySql)
        Me.GroupBox10.Controls.Add(Me.lbVerMysql)
        Me.GroupBox10.Controls.Add(Me.Label99)
        Me.GroupBox10.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(578, 90)
        Me.GroupBox10.TabIndex = 1
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Servidor de dades"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label56.Location = New System.Drawing.Point(16, 41)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(293, 17)
        Me.Label56.TabIndex = 3
        Me.Label56.Text = "The world's most popular open source database"
        '
        'LinkLbMySql
        '
        Me.LinkLbMySql.AutoSize = True
        Me.LinkLbMySql.Location = New System.Drawing.Point(16, 63)
        Me.LinkLbMySql.Name = "LinkLbMySql"
        Me.LinkLbMySql.Size = New System.Drawing.Size(141, 17)
        Me.LinkLbMySql.TabIndex = 2
        Me.LinkLbMySql.TabStop = True
        Me.LinkLbMySql.Text = "http://www.mysql.com/"
        '
        'lbVerMysql
        '
        Me.lbVerMysql.AutoSize = True
        Me.lbVerMysql.Location = New System.Drawing.Point(159, 20)
        Me.lbVerMysql.Name = "lbVerMysql"
        Me.lbVerMysql.Size = New System.Drawing.Size(25, 17)
        Me.lbVerMysql.TabIndex = 1
        Me.lbVerMysql.Text = "5.5"
        '
        'Label99
        '
        Me.Label99.AutoSize = True
        Me.Label99.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label99.Location = New System.Drawing.Point(16, 19)
        Me.Label99.Name = "Label99"
        Me.Label99.Size = New System.Drawing.Size(96, 13)
        Me.Label99.TabIndex = 0
        Me.Label99.Text = "MySQL Server :"
        '
        'groupBoxCloudPrograms
        '
        Me.groupBoxCloudPrograms.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBoxCloudPrograms.Controls.Add(Me.MetroTabControl1)
        Me.groupBoxCloudPrograms.Enabled = False
        Me.groupBoxCloudPrograms.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBoxCloudPrograms.Location = New System.Drawing.Point(0, 0)
        Me.groupBoxCloudPrograms.Name = "groupBoxCloudPrograms"
        Me.groupBoxCloudPrograms.Size = New System.Drawing.Size(630, 433)
        Me.groupBoxCloudPrograms.TabIndex = 24
        Me.groupBoxCloudPrograms.TabStop = False
        Me.groupBoxCloudPrograms.Text = "Programes compartits"
        Me.groupBoxCloudPrograms.Visible = False
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.tabPagePrgCloudPropis)
        Me.MetroTabControl1.Controls.Add(Me.tabPagePrgShareCloud)
        Me.MetroTabControl1.Location = New System.Drawing.Point(9, 21)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(615, 392)
        Me.MetroTabControl1.TabIndex = 1
        Me.MetroTabControl1.UseSelectable = True
        '
        'tabPagePrgCloudPropis
        '
        Me.tabPagePrgCloudPropis.Controls.Add(Me.Label15)
        Me.tabPagePrgCloudPropis.Controls.Add(Me.LbInfoConvida)
        Me.tabPagePrgCloudPropis.Controls.Add(Me.TxtCodeToShare)
        Me.tabPagePrgCloudPropis.Controls.Add(Me.ButtonSetSharePrg)
        Me.tabPagePrgCloudPropis.Controls.Add(Me.dataGridViewProgramsShared)
        Me.tabPagePrgCloudPropis.Controls.Add(Me.pic_cloudUp)
        Me.tabPagePrgCloudPropis.Controls.Add(Me.label54)
        Me.tabPagePrgCloudPropis.Controls.Add(Me.label136)
        Me.tabPagePrgCloudPropis.Controls.Add(Me.cmbProgramesPropis)
        Me.tabPagePrgCloudPropis.HorizontalScrollbarBarColor = True
        Me.tabPagePrgCloudPropis.HorizontalScrollbarHighlightOnWheel = False
        Me.tabPagePrgCloudPropis.HorizontalScrollbarSize = 10
        Me.tabPagePrgCloudPropis.Location = New System.Drawing.Point(4, 38)
        Me.tabPagePrgCloudPropis.Name = "tabPagePrgCloudPropis"
        Me.tabPagePrgCloudPropis.Size = New System.Drawing.Size(607, 350)
        Me.tabPagePrgCloudPropis.TabIndex = 0
        Me.tabPagePrgCloudPropis.Text = "Programes Propis"
        Me.tabPagePrgCloudPropis.VerticalScrollbarBarColor = True
        Me.tabPagePrgCloudPropis.VerticalScrollbarHighlightOnWheel = False
        Me.tabPagePrgCloudPropis.VerticalScrollbarSize = 10
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(81, 60)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(123, 17)
        Me.Label15.TabIndex = 263
        Me.Label15.Text = "Codi per compartir:"
        '
        'LbInfoConvida
        '
        Me.LbInfoConvida.Location = New System.Drawing.Point(81, 116)
        Me.LbInfoConvida.Name = "LbInfoConvida"
        Me.LbInfoConvida.Size = New System.Drawing.Size(516, 32)
        Me.LbInfoConvida.Style = MetroFramework.MetroColorStyle.Blue
        Me.LbInfoConvida.TabIndex = 262
        Me.LbInfoConvida.Text = "Dona aquest codi a l'emissora amb qui vols compartir aquest programa"
        Me.LbInfoConvida.UseStyleColors = True
        Me.LbInfoConvida.WrapToLine = True
        '
        'TxtCodeToShare
        '
        '
        '
        '
        Me.TxtCodeToShare.CustomButton.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.TxtCodeToShare.CustomButton.Location = New System.Drawing.Point(484, 1)
        Me.TxtCodeToShare.CustomButton.Name = ""
        Me.TxtCodeToShare.CustomButton.Size = New System.Drawing.Size(31, 31)
        Me.TxtCodeToShare.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TxtCodeToShare.CustomButton.TabIndex = 1
        Me.TxtCodeToShare.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TxtCodeToShare.CustomButton.UseSelectable = True
        Me.TxtCodeToShare.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.TxtCodeToShare.Lines = New String(-1) {}
        Me.TxtCodeToShare.Location = New System.Drawing.Point(81, 79)
        Me.TxtCodeToShare.MaxLength = 32767
        Me.TxtCodeToShare.Name = "TxtCodeToShare"
        Me.TxtCodeToShare.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtCodeToShare.ReadOnly = True
        Me.TxtCodeToShare.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtCodeToShare.SelectedText = ""
        Me.TxtCodeToShare.SelectionLength = 0
        Me.TxtCodeToShare.SelectionStart = 0
        Me.TxtCodeToShare.ShortcutsEnabled = True
        Me.TxtCodeToShare.ShowButton = True
        Me.TxtCodeToShare.Size = New System.Drawing.Size(516, 33)
        Me.TxtCodeToShare.TabIndex = 261
        Me.TxtCodeToShare.UseSelectable = True
        Me.TxtCodeToShare.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TxtCodeToShare.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'ButtonSetSharePrg
        '
        Me.ButtonSetSharePrg.ActiveControl = Nothing
        Me.ButtonSetSharePrg.Location = New System.Drawing.Point(425, 13)
        Me.ButtonSetSharePrg.Name = "ButtonSetSharePrg"
        Me.ButtonSetSharePrg.Size = New System.Drawing.Size(172, 44)
        Me.ButtonSetSharePrg.TabIndex = 260
        Me.ButtonSetSharePrg.TileImage = CType(resources.GetObject("ButtonSetSharePrg.TileImage"), System.Drawing.Image)
        Me.ButtonSetSharePrg.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ButtonSetSharePrg.UseSelectable = True
        Me.ButtonSetSharePrg.UseTileImage = True
        '
        'dataGridViewProgramsShared
        '
        Me.dataGridViewProgramsShared.AllowUserToAddRows = False
        Me.dataGridViewProgramsShared.AllowUserToDeleteRows = False
        Me.dataGridViewProgramsShared.AllowUserToResizeRows = False
        Me.dataGridViewProgramsShared.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataGridViewProgramsShared.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataGridViewProgramsShared.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataGridViewProgramsShared.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dataGridViewProgramsShared.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridViewProgramsShared.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dataGridViewProgramsShared.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridViewProgramsShared.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column_prg_id, Me.Column_prg_nom, Me.Column_prg_emissora, Me.Column_prg_hash, Me.Column_prg_state, Me.ColumnCli_id, Me.Column_prg_delete})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGridViewProgramsShared.DefaultCellStyle = DataGridViewCellStyle2
        Me.dataGridViewProgramsShared.EnableHeadersVisualStyles = False
        Me.dataGridViewProgramsShared.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dataGridViewProgramsShared.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataGridViewProgramsShared.Location = New System.Drawing.Point(20, 165)
        Me.dataGridViewProgramsShared.Name = "dataGridViewProgramsShared"
        Me.dataGridViewProgramsShared.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridViewProgramsShared.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dataGridViewProgramsShared.RowHeadersVisible = False
        Me.dataGridViewProgramsShared.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dataGridViewProgramsShared.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGridViewProgramsShared.Size = New System.Drawing.Size(581, 184)
        Me.dataGridViewProgramsShared.TabIndex = 1
        '
        'Column_prg_id
        '
        Me.Column_prg_id.HeaderText = "ID"
        Me.Column_prg_id.Name = "Column_prg_id"
        Me.Column_prg_id.ReadOnly = True
        '
        'Column_prg_nom
        '
        Me.Column_prg_nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column_prg_nom.HeaderText = "Nom"
        Me.Column_prg_nom.Name = "Column_prg_nom"
        Me.Column_prg_nom.ReadOnly = True
        '
        'Column_prg_emissora
        '
        Me.Column_prg_emissora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column_prg_emissora.HeaderText = "Emissora"
        Me.Column_prg_emissora.Name = "Column_prg_emissora"
        Me.Column_prg_emissora.ReadOnly = True
        '
        'Column_prg_hash
        '
        Me.Column_prg_hash.HeaderText = "Hash"
        Me.Column_prg_hash.Name = "Column_prg_hash"
        Me.Column_prg_hash.ReadOnly = True
        Me.Column_prg_hash.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column_prg_hash.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column_prg_state
        '
        Me.Column_prg_state.HeaderText = "Active"
        Me.Column_prg_state.Name = "Column_prg_state"
        Me.Column_prg_state.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column_prg_state.Width = 50
        '
        'ColumnCli_id
        '
        Me.ColumnCli_id.HeaderText = "client"
        Me.ColumnCli_id.Name = "ColumnCli_id"
        Me.ColumnCli_id.ReadOnly = True
        Me.ColumnCli_id.Visible = False
        '
        'Column_prg_delete
        '
        Me.Column_prg_delete.HeaderText = ""
        Me.Column_prg_delete.Name = "Column_prg_delete"
        Me.Column_prg_delete.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column_prg_delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'pic_cloudUp
        '
        Me.pic_cloudUp.BackColor = System.Drawing.Color.Transparent
        Me.pic_cloudUp.Image = CType(resources.GetObject("pic_cloudUp.Image"), System.Drawing.Image)
        Me.pic_cloudUp.Location = New System.Drawing.Point(11, 7)
        Me.pic_cloudUp.Name = "pic_cloudUp"
        Me.pic_cloudUp.Size = New System.Drawing.Size(50, 50)
        Me.pic_cloudUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_cloudUp.TabIndex = 259
        Me.pic_cloudUp.TabStop = False
        '
        'label54
        '
        Me.label54.AutoSize = True
        Me.label54.BackColor = System.Drawing.Color.Transparent
        Me.label54.Location = New System.Drawing.Point(84, 7)
        Me.label54.Name = "label54"
        Me.label54.Size = New System.Drawing.Size(69, 17)
        Me.label54.TabIndex = 5
        Me.label54.Text = "Programa:"
        '
        'label136
        '
        Me.label136.AutoSize = True
        Me.label136.BackColor = System.Drawing.Color.Transparent
        Me.label136.Location = New System.Drawing.Point(23, 146)
        Me.label136.Name = "label136"
        Me.label136.Size = New System.Drawing.Size(141, 17)
        Me.label136.TabIndex = 7
        Me.label136.Text = "Programes compartits:"
        '
        'cmbProgramesPropis
        '
        Me.cmbProgramesPropis.FormattingEnabled = True
        Me.cmbProgramesPropis.Location = New System.Drawing.Point(81, 32)
        Me.cmbProgramesPropis.Name = "cmbProgramesPropis"
        Me.cmbProgramesPropis.Size = New System.Drawing.Size(319, 25)
        Me.cmbProgramesPropis.TabIndex = 0
        '
        'tabPagePrgShareCloud
        '
        Me.tabPagePrgShareCloud.Controls.Add(Me.lbInfoPrgCloud)
        Me.tabPagePrgShareCloud.Controls.Add(Me.ButtonImportProgram)
        Me.tabPagePrgShareCloud.Controls.Add(Me.txtCodeShareImport)
        Me.tabPagePrgShareCloud.Controls.Add(Me.dataGridViewProgramsCloud)
        Me.tabPagePrgShareCloud.Controls.Add(Me.pic_cloudDown)
        Me.tabPagePrgShareCloud.Controls.Add(Me.label139)
        Me.tabPagePrgShareCloud.HorizontalScrollbarBarColor = True
        Me.tabPagePrgShareCloud.HorizontalScrollbarHighlightOnWheel = False
        Me.tabPagePrgShareCloud.HorizontalScrollbarSize = 10
        Me.tabPagePrgShareCloud.Location = New System.Drawing.Point(4, 38)
        Me.tabPagePrgShareCloud.Name = "tabPagePrgShareCloud"
        Me.tabPagePrgShareCloud.Size = New System.Drawing.Size(607, 350)
        Me.tabPagePrgShareCloud.TabIndex = 1
        Me.tabPagePrgShareCloud.Text = "Programes del Núvol"
        Me.tabPagePrgShareCloud.VerticalScrollbarBarColor = True
        Me.tabPagePrgShareCloud.VerticalScrollbarHighlightOnWheel = False
        Me.tabPagePrgShareCloud.VerticalScrollbarSize = 10
        '
        'lbInfoPrgCloud
        '
        Me.lbInfoPrgCloud.Location = New System.Drawing.Point(68, 53)
        Me.lbInfoPrgCloud.Name = "lbInfoPrgCloud"
        Me.lbInfoPrgCloud.Size = New System.Drawing.Size(345, 54)
        Me.lbInfoPrgCloud.Style = MetroFramework.MetroColorStyle.Blue
        Me.lbInfoPrgCloud.TabIndex = 265
        Me.lbInfoPrgCloud.Text = "Enganxa el codi que t'han proporcionat"
        Me.lbInfoPrgCloud.UseStyleColors = True
        Me.lbInfoPrgCloud.WrapToLine = True
        '
        'ButtonImportProgram
        '
        Me.ButtonImportProgram.ActiveControl = Nothing
        Me.ButtonImportProgram.Location = New System.Drawing.Point(425, 13)
        Me.ButtonImportProgram.Name = "ButtonImportProgram"
        Me.ButtonImportProgram.Size = New System.Drawing.Size(172, 44)
        Me.ButtonImportProgram.TabIndex = 264
        Me.ButtonImportProgram.TileImage = CType(resources.GetObject("ButtonImportProgram.TileImage"), System.Drawing.Image)
        Me.ButtonImportProgram.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ButtonImportProgram.UseSelectable = True
        Me.ButtonImportProgram.UseTileImage = True
        '
        'txtCodeShareImport
        '
        '
        '
        '
        Me.txtCodeShareImport.CustomButton.Image = Nothing
        Me.txtCodeShareImport.CustomButton.Location = New System.Drawing.Point(313, 1)
        Me.txtCodeShareImport.CustomButton.Name = ""
        Me.txtCodeShareImport.CustomButton.Size = New System.Drawing.Size(31, 31)
        Me.txtCodeShareImport.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCodeShareImport.CustomButton.TabIndex = 1
        Me.txtCodeShareImport.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCodeShareImport.CustomButton.UseSelectable = True
        Me.txtCodeShareImport.CustomButton.Visible = False
        Me.txtCodeShareImport.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtCodeShareImport.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.txtCodeShareImport.Lines = New String(-1) {}
        Me.txtCodeShareImport.Location = New System.Drawing.Point(68, 13)
        Me.txtCodeShareImport.MaxLength = 32767
        Me.txtCodeShareImport.Name = "txtCodeShareImport"
        Me.txtCodeShareImport.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCodeShareImport.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCodeShareImport.SelectedText = ""
        Me.txtCodeShareImport.SelectionLength = 0
        Me.txtCodeShareImport.SelectionStart = 0
        Me.txtCodeShareImport.ShortcutsEnabled = True
        Me.txtCodeShareImport.Size = New System.Drawing.Size(345, 33)
        Me.txtCodeShareImport.TabIndex = 263
        Me.txtCodeShareImport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtCodeShareImport.UseSelectable = True
        Me.txtCodeShareImport.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCodeShareImport.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'dataGridViewProgramsCloud
        '
        Me.dataGridViewProgramsCloud.AllowUserToAddRows = False
        Me.dataGridViewProgramsCloud.AllowUserToDeleteRows = False
        Me.dataGridViewProgramsCloud.AllowUserToResizeRows = False
        Me.dataGridViewProgramsCloud.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataGridViewProgramsCloud.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataGridViewProgramsCloud.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataGridViewProgramsCloud.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dataGridViewProgramsCloud.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridViewProgramsCloud.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dataGridViewProgramsCloud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridViewProgramsCloud.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dataGridViewTextBoxColumn1, Me.dataGridViewTextBoxColumn2, Me.ColumnFrom, Me.dataGridViewCheckBoxColumn1})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGridViewProgramsCloud.DefaultCellStyle = DataGridViewCellStyle5
        Me.dataGridViewProgramsCloud.EnableHeadersVisualStyles = False
        Me.dataGridViewProgramsCloud.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dataGridViewProgramsCloud.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataGridViewProgramsCloud.Location = New System.Drawing.Point(13, 146)
        Me.dataGridViewProgramsCloud.Name = "dataGridViewProgramsCloud"
        Me.dataGridViewProgramsCloud.ReadOnly = True
        Me.dataGridViewProgramsCloud.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridViewProgramsCloud.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dataGridViewProgramsCloud.RowHeadersVisible = False
        Me.dataGridViewProgramsCloud.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dataGridViewProgramsCloud.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGridViewProgramsCloud.Size = New System.Drawing.Size(581, 343)
        Me.dataGridViewProgramsCloud.TabIndex = 262
        '
        'dataGridViewTextBoxColumn1
        '
        Me.dataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1"
        Me.dataGridViewTextBoxColumn1.ReadOnly = True
        '
        'dataGridViewTextBoxColumn2
        '
        Me.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dataGridViewTextBoxColumn2.HeaderText = "Nom"
        Me.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2"
        Me.dataGridViewTextBoxColumn2.ReadOnly = True
        '
        'ColumnFrom
        '
        Me.ColumnFrom.HeaderText = "From"
        Me.ColumnFrom.Name = "ColumnFrom"
        Me.ColumnFrom.ReadOnly = True
        '
        'dataGridViewCheckBoxColumn1
        '
        Me.dataGridViewCheckBoxColumn1.HeaderText = "Hash"
        Me.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1"
        Me.dataGridViewCheckBoxColumn1.ReadOnly = True
        Me.dataGridViewCheckBoxColumn1.Visible = False
        '
        'pic_cloudDown
        '
        Me.pic_cloudDown.BackColor = System.Drawing.Color.Transparent
        Me.pic_cloudDown.Image = CType(resources.GetObject("pic_cloudDown.Image"), System.Drawing.Image)
        Me.pic_cloudDown.Location = New System.Drawing.Point(11, 7)
        Me.pic_cloudDown.Name = "pic_cloudDown"
        Me.pic_cloudDown.Size = New System.Drawing.Size(50, 50)
        Me.pic_cloudDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_cloudDown.TabIndex = 260
        Me.pic_cloudDown.TabStop = False
        '
        'label139
        '
        Me.label139.AutoSize = True
        Me.label139.BackColor = System.Drawing.Color.Transparent
        Me.label139.Location = New System.Drawing.Point(25, 122)
        Me.label139.Name = "label139"
        Me.label139.Size = New System.Drawing.Size(204, 17)
        Me.label139.TabIndex = 13
        Me.label139.Text = "Programes procedents del núbol:"
        '
        'grupSequencies
        '
        Me.grupSequencies.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grupSequencies.Controls.Add(Me.cmdDelSequenc)
        Me.grupSequencies.Controls.Add(Me.cmdAddSequenc)
        Me.grupSequencies.Controls.Add(Me.label116)
        Me.grupSequencies.Controls.Add(Me.Label69)
        Me.grupSequencies.Controls.Add(Me.Label68)
        Me.grupSequencies.Controls.Add(Me.lbNovaSequ)
        Me.grupSequencies.Controls.Add(Me.Button2)
        Me.grupSequencies.Controls.Add(Me.Button1)
        Me.grupSequencies.Controls.Add(Me.ComboBoxSequencies)
        Me.grupSequencies.Controls.Add(Me.ListBoxSequencies)
        Me.grupSequencies.Controls.Add(Me.DataGridViewValorsSequ)
        Me.grupSequencies.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupSequencies.Location = New System.Drawing.Point(0, 0)
        Me.grupSequencies.Name = "grupSequencies"
        Me.grupSequencies.Size = New System.Drawing.Size(630, 433)
        Me.grupSequencies.TabIndex = 22
        Me.grupSequencies.TabStop = False
        Me.grupSequencies.Text = "Seqüències Pautes"
        Me.grupSequencies.Visible = False
        '
        'cmdDelSequenc
        '
        Me.cmdDelSequenc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdDelSequenc.Enabled = False
        Me.cmdDelSequenc.Location = New System.Drawing.Point(233, 318)
        Me.cmdDelSequenc.Name = "cmdDelSequenc"
        Me.cmdDelSequenc.Size = New System.Drawing.Size(83, 24)
        Me.cmdDelSequenc.TabIndex = 13
        Me.cmdDelSequenc.Text = "Esborrar"
        Me.cmdDelSequenc.UseSelectable = True
        '
        'cmdAddSequenc
        '
        Me.cmdAddSequenc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdAddSequenc.Enabled = False
        Me.cmdAddSequenc.Location = New System.Drawing.Point(111, 318)
        Me.cmdAddSequenc.Name = "cmdAddSequenc"
        Me.cmdAddSequenc.Size = New System.Drawing.Size(83, 24)
        Me.cmdAddSequenc.TabIndex = 12
        Me.cmdAddSequenc.Text = "Nova"
        Me.cmdAddSequenc.UseSelectable = True
        '
        'label116
        '
        Me.label116.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.label116.Location = New System.Drawing.Point(107, 371)
        Me.label116.Name = "label116"
        Me.label116.Size = New System.Drawing.Size(240, 52)
        Me.label116.TabIndex = 11
        Me.label116.Text = "Seqüència per defecte de la emissió automàtica de programes"
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Location = New System.Drawing.Point(362, 41)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(101, 17)
        Me.Label69.TabIndex = 10
        Me.Label69.Text = "Valors del llistat"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Location = New System.Drawing.Point(112, 41)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(199, 17)
        Me.Label68.TabIndex = 9
        Me.Label68.Text = "Llistat de seqüències disponibles"
        '
        'lbNovaSequ
        '
        Me.lbNovaSequ.AutoSize = True
        Me.lbNovaSequ.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNovaSequ.ForeColor = System.Drawing.Color.Red
        Me.lbNovaSequ.Location = New System.Drawing.Point(110, 19)
        Me.lbNovaSequ.Name = "lbNovaSequ"
        Me.lbNovaSequ.Size = New System.Drawing.Size(48, 17)
        Me.lbNovaSequ.TabIndex = 8
        Me.lbNovaSequ.Text = "NOVA"
        Me.lbNovaSequ.Visible = False
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(535, 118)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(23, 24)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "-"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(535, 87)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(23, 24)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "+"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBoxSequencies
        '
        Me.ComboBoxSequencies.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxSequencies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSequencies.Enabled = False
        Me.ComboBoxSequencies.FormattingEnabled = True
        Me.ComboBoxSequencies.Location = New System.Drawing.Point(357, 371)
        Me.ComboBoxSequencies.Name = "ComboBoxSequencies"
        Me.ComboBoxSequencies.Size = New System.Drawing.Size(172, 25)
        Me.ComboBoxSequencies.TabIndex = 3
        '
        'ListBoxSequencies
        '
        Me.ListBoxSequencies.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListBoxSequencies.FormattingEnabled = True
        Me.ListBoxSequencies.ItemHeight = 17
        Me.ListBoxSequencies.Location = New System.Drawing.Point(111, 60)
        Me.ListBoxSequencies.Name = "ListBoxSequencies"
        Me.ListBoxSequencies.Size = New System.Drawing.Size(205, 242)
        Me.ListBoxSequencies.TabIndex = 1
        '
        'DataGridViewValorsSequ
        '
        Me.DataGridViewValorsSequ.AllowUserToAddRows = False
        Me.DataGridViewValorsSequ.AllowUserToDeleteRows = False
        Me.DataGridViewValorsSequ.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewValorsSequ.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridViewValorsSequ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewValorsSequ.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnValors})
        Me.DataGridViewValorsSequ.Enabled = False
        Me.DataGridViewValorsSequ.Location = New System.Drawing.Point(357, 60)
        Me.DataGridViewValorsSequ.Name = "DataGridViewValorsSequ"
        Me.DataGridViewValorsSequ.RowHeadersVisible = False
        Me.DataGridViewValorsSequ.RowTemplate.Height = 24
        Me.DataGridViewValorsSequ.Size = New System.Drawing.Size(172, 287)
        Me.DataGridViewValorsSequ.TabIndex = 0
        '
        'ColumnValors
        '
        Me.ColumnValors.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnValors.DataPropertyName = "columnaID"
        Me.ColumnValors.HeaderText = "Valor"
        Me.ColumnValors.Name = "ColumnValors"
        '
        'groupBoxStreaming
        '
        Me.groupBoxStreaming.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBoxStreaming.Controls.Add(Me.groupBoxParamsServer)
        Me.groupBoxStreaming.Controls.Add(Me.groupBoxQualityServer)
        Me.groupBoxStreaming.Controls.Add(Me.txtURLStreaming)
        Me.groupBoxStreaming.Controls.Add(Me.Label50)
        Me.groupBoxStreaming.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBoxStreaming.Location = New System.Drawing.Point(0, 0)
        Me.groupBoxStreaming.Name = "groupBoxStreaming"
        Me.groupBoxStreaming.Size = New System.Drawing.Size(630, 433)
        Me.groupBoxStreaming.TabIndex = 1
        Me.groupBoxStreaming.TabStop = False
        Me.groupBoxStreaming.Text = "Streaming"
        Me.groupBoxStreaming.Visible = False
        '
        'groupBoxParamsServer
        '
        Me.groupBoxParamsServer.Controls.Add(Me.label128)
        Me.groupBoxParamsServer.Controls.Add(Me.txtEstil)
        Me.groupBoxParamsServer.Controls.Add(Me.txtPassword)
        Me.groupBoxParamsServer.Controls.Add(Me.label129)
        Me.groupBoxParamsServer.Controls.Add(Me.label130)
        Me.groupBoxParamsServer.Controls.Add(Me.txtMountpoint)
        Me.groupBoxParamsServer.Controls.Add(Me.comboBoxServerStream)
        Me.groupBoxParamsServer.Controls.Add(Me.label131)
        Me.groupBoxParamsServer.Controls.Add(Me.txtPort)
        Me.groupBoxParamsServer.Controls.Add(Me.label132)
        Me.groupBoxParamsServer.Controls.Add(Me.txtServer)
        Me.groupBoxParamsServer.Controls.Add(Me.label133)
        Me.groupBoxParamsServer.Enabled = False
        Me.groupBoxParamsServer.Location = New System.Drawing.Point(68, 196)
        Me.groupBoxParamsServer.Name = "groupBoxParamsServer"
        Me.groupBoxParamsServer.Size = New System.Drawing.Size(410, 213)
        Me.groupBoxParamsServer.TabIndex = 35
        Me.groupBoxParamsServer.TabStop = False
        Me.groupBoxParamsServer.Text = "Paràmetres del servidor"
        '
        'label128
        '
        Me.label128.Location = New System.Drawing.Point(9, 182)
        Me.label128.Name = "label128"
        Me.label128.Size = New System.Drawing.Size(136, 23)
        Me.label128.TabIndex = 9
        Me.label128.Text = "Estil"
        Me.label128.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtEstil
        '
        Me.txtEstil.Location = New System.Drawing.Point(151, 181)
        Me.txtEstil.Name = "txtEstil"
        Me.txtEstil.Size = New System.Drawing.Size(112, 25)
        Me.txtEstil.TabIndex = 8
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtPassword.Location = New System.Drawing.Point(151, 152)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.ReadOnly = True
        Me.txtPassword.Size = New System.Drawing.Size(112, 25)
        Me.txtPassword.TabIndex = 7
        '
        'label129
        '
        Me.label129.Location = New System.Drawing.Point(9, 20)
        Me.label129.Name = "label129"
        Me.label129.Size = New System.Drawing.Size(136, 23)
        Me.label129.TabIndex = 0
        Me.label129.Text = "Tipus de servidor:"
        Me.label129.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'label130
        '
        Me.label130.Location = New System.Drawing.Point(9, 153)
        Me.label130.Name = "label130"
        Me.label130.Size = New System.Drawing.Size(136, 23)
        Me.label130.TabIndex = 6
        Me.label130.Text = "Password:"
        Me.label130.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtMountpoint
        '
        Me.txtMountpoint.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtMountpoint.Location = New System.Drawing.Point(151, 119)
        Me.txtMountpoint.Name = "txtMountpoint"
        Me.txtMountpoint.ReadOnly = True
        Me.txtMountpoint.Size = New System.Drawing.Size(112, 25)
        Me.txtMountpoint.TabIndex = 5
        '
        'comboBoxServerStream
        '
        Me.comboBoxServerStream.BackColor = System.Drawing.SystemColors.ControlLight
        Me.comboBoxServerStream.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxServerStream.Enabled = False
        Me.comboBoxServerStream.FormattingEnabled = True
        Me.comboBoxServerStream.Items.AddRange(New Object() {"SHOUTcast V1", "SHOUTcast V2", "Icecast"})
        Me.comboBoxServerStream.Location = New System.Drawing.Point(151, 19)
        Me.comboBoxServerStream.Name = "comboBoxServerStream"
        Me.comboBoxServerStream.Size = New System.Drawing.Size(112, 25)
        Me.comboBoxServerStream.TabIndex = 1
        '
        'label131
        '
        Me.label131.Location = New System.Drawing.Point(9, 120)
        Me.label131.Name = "label131"
        Me.label131.Size = New System.Drawing.Size(136, 23)
        Me.label131.TabIndex = 4
        Me.label131.Text = "Mount Point:"
        Me.label131.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtPort
        '
        Me.txtPort.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtPort.Location = New System.Drawing.Point(151, 86)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.ReadOnly = True
        Me.txtPort.Size = New System.Drawing.Size(112, 25)
        Me.txtPort.TabIndex = 3
        '
        'label132
        '
        Me.label132.Location = New System.Drawing.Point(9, 87)
        Me.label132.Name = "label132"
        Me.label132.Size = New System.Drawing.Size(136, 23)
        Me.label132.TabIndex = 2
        Me.label132.Text = "Port:"
        Me.label132.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtServer
        '
        Me.txtServer.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtServer.Location = New System.Drawing.Point(151, 53)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.ReadOnly = True
        Me.txtServer.Size = New System.Drawing.Size(192, 25)
        Me.txtServer.TabIndex = 1
        '
        'label133
        '
        Me.label133.Location = New System.Drawing.Point(9, 54)
        Me.label133.Name = "label133"
        Me.label133.Size = New System.Drawing.Size(136, 23)
        Me.label133.TabIndex = 0
        Me.label133.Text = "Servidor:"
        Me.label133.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'groupBoxQualityServer
        '
        Me.groupBoxQualityServer.Controls.Add(Me.txtStreamCannels)
        Me.groupBoxQualityServer.Controls.Add(Me.txtStreamSampleRate)
        Me.groupBoxQualityServer.Controls.Add(Me.txtStreamBitRate)
        Me.groupBoxQualityServer.Controls.Add(Me.label28)
        Me.groupBoxQualityServer.Controls.Add(Me.label126)
        Me.groupBoxQualityServer.Controls.Add(Me.label127)
        Me.groupBoxQualityServer.Enabled = False
        Me.groupBoxQualityServer.Location = New System.Drawing.Point(68, 51)
        Me.groupBoxQualityServer.Name = "groupBoxQualityServer"
        Me.groupBoxQualityServer.Size = New System.Drawing.Size(410, 135)
        Me.groupBoxQualityServer.TabIndex = 34
        Me.groupBoxQualityServer.TabStop = False
        Me.groupBoxQualityServer.Text = "Qualitat streaming"
        '
        'txtStreamCannels
        '
        Me.txtStreamCannels.BackColor = System.Drawing.SystemColors.ControlLight
        '
        '
        '
        Me.txtStreamCannels.CustomButton.Image = Nothing
        Me.txtStreamCannels.CustomButton.Location = New System.Drawing.Point(78, 1)
        Me.txtStreamCannels.CustomButton.Name = ""
        Me.txtStreamCannels.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtStreamCannels.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtStreamCannels.CustomButton.TabIndex = 1
        Me.txtStreamCannels.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtStreamCannels.CustomButton.UseSelectable = True
        Me.txtStreamCannels.CustomButton.Visible = False
        Me.txtStreamCannels.Lines = New String(-1) {}
        Me.txtStreamCannels.Location = New System.Drawing.Point(151, 100)
        Me.txtStreamCannels.MaxLength = 32767
        Me.txtStreamCannels.Name = "txtStreamCannels"
        Me.txtStreamCannels.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStreamCannels.ReadOnly = True
        Me.txtStreamCannels.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtStreamCannels.SelectedText = ""
        Me.txtStreamCannels.SelectionLength = 0
        Me.txtStreamCannels.SelectionStart = 0
        Me.txtStreamCannels.ShortcutsEnabled = True
        Me.txtStreamCannels.Size = New System.Drawing.Size(106, 29)
        Me.txtStreamCannels.TabIndex = 39
        Me.txtStreamCannels.UseCustomBackColor = True
        Me.txtStreamCannels.UseSelectable = True
        Me.txtStreamCannels.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtStreamCannels.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtStreamSampleRate
        '
        Me.txtStreamSampleRate.BackColor = System.Drawing.SystemColors.ControlLight
        '
        '
        '
        Me.txtStreamSampleRate.CustomButton.Image = Nothing
        Me.txtStreamSampleRate.CustomButton.Location = New System.Drawing.Point(78, 1)
        Me.txtStreamSampleRate.CustomButton.Name = ""
        Me.txtStreamSampleRate.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtStreamSampleRate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtStreamSampleRate.CustomButton.TabIndex = 1
        Me.txtStreamSampleRate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtStreamSampleRate.CustomButton.UseSelectable = True
        Me.txtStreamSampleRate.CustomButton.Visible = False
        Me.txtStreamSampleRate.Lines = New String(-1) {}
        Me.txtStreamSampleRate.Location = New System.Drawing.Point(151, 67)
        Me.txtStreamSampleRate.MaxLength = 32767
        Me.txtStreamSampleRate.Name = "txtStreamSampleRate"
        Me.txtStreamSampleRate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStreamSampleRate.ReadOnly = True
        Me.txtStreamSampleRate.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtStreamSampleRate.SelectedText = ""
        Me.txtStreamSampleRate.SelectionLength = 0
        Me.txtStreamSampleRate.SelectionStart = 0
        Me.txtStreamSampleRate.ShortcutsEnabled = True
        Me.txtStreamSampleRate.Size = New System.Drawing.Size(106, 29)
        Me.txtStreamSampleRate.TabIndex = 38
        Me.txtStreamSampleRate.UseCustomBackColor = True
        Me.txtStreamSampleRate.UseSelectable = True
        Me.txtStreamSampleRate.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtStreamSampleRate.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtStreamBitRate
        '
        Me.txtStreamBitRate.BackColor = System.Drawing.SystemColors.ControlLight
        '
        '
        '
        Me.txtStreamBitRate.CustomButton.Image = Nothing
        Me.txtStreamBitRate.CustomButton.Location = New System.Drawing.Point(78, 1)
        Me.txtStreamBitRate.CustomButton.Name = ""
        Me.txtStreamBitRate.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtStreamBitRate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtStreamBitRate.CustomButton.TabIndex = 1
        Me.txtStreamBitRate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtStreamBitRate.CustomButton.UseSelectable = True
        Me.txtStreamBitRate.CustomButton.Visible = False
        Me.txtStreamBitRate.Lines = New String(-1) {}
        Me.txtStreamBitRate.Location = New System.Drawing.Point(151, 34)
        Me.txtStreamBitRate.MaxLength = 32767
        Me.txtStreamBitRate.Name = "txtStreamBitRate"
        Me.txtStreamBitRate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStreamBitRate.ReadOnly = True
        Me.txtStreamBitRate.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtStreamBitRate.SelectedText = ""
        Me.txtStreamBitRate.SelectionLength = 0
        Me.txtStreamBitRate.SelectionStart = 0
        Me.txtStreamBitRate.ShortcutsEnabled = True
        Me.txtStreamBitRate.Size = New System.Drawing.Size(106, 29)
        Me.txtStreamBitRate.TabIndex = 37
        Me.txtStreamBitRate.UseCustomBackColor = True
        Me.txtStreamBitRate.UseSelectable = True
        Me.txtStreamBitRate.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtStreamBitRate.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'label28
        '
        Me.label28.Location = New System.Drawing.Point(12, 103)
        Me.label28.Name = "label28"
        Me.label28.Size = New System.Drawing.Size(134, 23)
        Me.label28.TabIndex = 36
        Me.label28.Text = "Canals d'audio"
        Me.label28.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'label126
        '
        Me.label126.Location = New System.Drawing.Point(12, 70)
        Me.label126.Name = "label126"
        Me.label126.Size = New System.Drawing.Size(134, 23)
        Me.label126.TabIndex = 35
        Me.label126.Text = "Freqüència (Hz)"
        Me.label126.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'label127
        '
        Me.label127.Location = New System.Drawing.Point(12, 37)
        Me.label127.Name = "label127"
        Me.label127.Size = New System.Drawing.Size(134, 23)
        Me.label127.TabIndex = 34
        Me.label127.Text = "Bitrate (Kbps)"
        Me.label127.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtURLStreaming
        '
        Me.txtURLStreaming.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtURLStreaming.Enabled = False
        Me.txtURLStreaming.Location = New System.Drawing.Point(219, 20)
        Me.txtURLStreaming.Name = "txtURLStreaming"
        Me.txtURLStreaming.ReadOnly = True
        Me.txtURLStreaming.Size = New System.Drawing.Size(401, 25)
        Me.txtURLStreaming.TabIndex = 3
        '
        'Label50
        '
        Me.Label50.Location = New System.Drawing.Point(74, 21)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(137, 22)
        Me.Label50.TabIndex = 10
        Me.Label50.Text = "Streaming:"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupInfoSistema
        '
        Me.GroupInfoSistema.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupInfoSistema.Controls.Add(Me.Label109)
        Me.GroupInfoSistema.Controls.Add(Me.txtInformeSistema)
        Me.GroupInfoSistema.Controls.Add(Me.GroupBox11)
        Me.GroupInfoSistema.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupInfoSistema.Location = New System.Drawing.Point(0, 0)
        Me.GroupInfoSistema.Name = "GroupInfoSistema"
        Me.GroupInfoSistema.Size = New System.Drawing.Size(630, 433)
        Me.GroupInfoSistema.TabIndex = 21
        Me.GroupInfoSistema.TabStop = False
        Me.GroupInfoSistema.Text = "Informació del Sistema"
        Me.GroupInfoSistema.Visible = False
        '
        'Label109
        '
        Me.Label109.AutoSize = True
        Me.Label109.Location = New System.Drawing.Point(36, 109)
        Me.Label109.Name = "Label109"
        Me.Label109.Size = New System.Drawing.Size(126, 17)
        Me.Label109.TabIndex = 4
        Me.Label109.Text = "Informe del sistema:"
        '
        'txtInformeSistema
        '
        Me.txtInformeSistema.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInformeSistema.BackColor = System.Drawing.SystemColors.Control
        Me.txtInformeSistema.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInformeSistema.Location = New System.Drawing.Point(30, 130)
        Me.txtInformeSistema.Multiline = True
        Me.txtInformeSistema.Name = "txtInformeSistema"
        Me.txtInformeSistema.ReadOnly = True
        Me.txtInformeSistema.Size = New System.Drawing.Size(570, 291)
        Me.txtInformeSistema.TabIndex = 3
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.lbVerAplic)
        Me.GroupBox11.Controls.Add(Me.Label93)
        Me.GroupBox11.Controls.Add(Me.Label100)
        Me.GroupBox11.Controls.Add(Me.lbVerDBS)
        Me.GroupBox11.Location = New System.Drawing.Point(97, 20)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(308, 87)
        Me.GroupBox11.TabIndex = 0
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Versions"
        '
        'lbVerAplic
        '
        Me.lbVerAplic.AutoSize = True
        Me.lbVerAplic.Location = New System.Drawing.Point(211, 48)
        Me.lbVerAplic.Name = "lbVerAplic"
        Me.lbVerAplic.Size = New System.Drawing.Size(25, 17)
        Me.lbVerAplic.TabIndex = 13
        Me.lbVerAplic.Text = "7.5"
        '
        'Label93
        '
        Me.Label93.AutoSize = True
        Me.Label93.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label93.Location = New System.Drawing.Point(15, 52)
        Me.Label93.Name = "Label93"
        Me.Label93.Size = New System.Drawing.Size(169, 17)
        Me.Label93.TabIndex = 12
        Me.Label93.Text = "Versió de la aplicació : "
        '
        'Label100
        '
        Me.Label100.AutoSize = True
        Me.Label100.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label100.Location = New System.Drawing.Point(16, 22)
        Me.Label100.Name = "Label100"
        Me.Label100.Size = New System.Drawing.Size(135, 17)
        Me.Label100.TabIndex = 11
        Me.Label100.Text = "Versió de la DBS : "
        '
        'lbVerDBS
        '
        Me.lbVerDBS.AutoSize = True
        Me.lbVerDBS.Location = New System.Drawing.Point(209, 22)
        Me.lbVerDBS.Name = "lbVerDBS"
        Me.lbVerDBS.Size = New System.Drawing.Size(25, 17)
        Me.lbVerDBS.TabIndex = 10
        Me.lbVerDBS.Text = "5.6"
        '
        'grupWeb
        '
        Me.grupWeb.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grupWeb.Controls.Add(Me.GroupBox3)
        Me.grupWeb.Controls.Add(Me.GroupBox4)
        Me.grupWeb.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupWeb.Location = New System.Drawing.Point(0, 0)
        Me.grupWeb.Name = "grupWeb"
        Me.grupWeb.Size = New System.Drawing.Size(630, 433)
        Me.grupWeb.TabIndex = 12
        Me.grupWeb.TabStop = False
        Me.grupWeb.Text = "Integració web"
        Me.grupWeb.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtNumTracs)
        Me.GroupBox3.Controls.Add(Me.Label61)
        Me.GroupBox3.Controls.Add(Me.txtNumVots)
        Me.GroupBox3.Controls.Add(Me.Label60)
        Me.GroupBox3.Controls.Add(Me.Label59)
        Me.GroupBox3.Location = New System.Drawing.Point(52, 295)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(540, 135)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ràdio-Activa"
        '
        'txtNumTracs
        '
        Me.txtNumTracs.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtNumTracs.Enabled = False
        Me.txtNumTracs.Location = New System.Drawing.Point(181, 62)
        Me.txtNumTracs.Name = "txtNumTracs"
        Me.txtNumTracs.Size = New System.Drawing.Size(62, 25)
        Me.txtNumTracs.TabIndex = 9
        '
        'Label61
        '
        Me.Label61.ForeColor = System.Drawing.Color.Blue
        Me.Label61.Location = New System.Drawing.Point(31, 18)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(432, 34)
        Me.Label61.TabIndex = 17
        Me.Label61.Text = "La audiència pot escollir les cançons mitjançant la Web. La activació d'aquesta f" &
    "unció depèn de cada pauta"
        '
        'txtNumVots
        '
        Me.txtNumVots.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtNumVots.Enabled = False
        Me.txtNumVots.Location = New System.Drawing.Point(181, 89)
        Me.txtNumVots.Name = "txtNumVots"
        Me.txtNumVots.Size = New System.Drawing.Size(62, 25)
        Me.txtNumVots.TabIndex = 10
        '
        'Label60
        '
        Me.Label60.Location = New System.Drawing.Point(10, 90)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(169, 19)
        Me.Label60.TabIndex = 15
        Me.Label60.Text = "Nº de votacions per torn:"
        Me.Label60.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label59
        '
        Me.Label59.Location = New System.Drawing.Point(3, 63)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(176, 19)
        Me.Label59.TabIndex = 0
        Me.Label59.Text = "Number of songs to choice:"
        Me.Label59.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.label113)
        Me.GroupBox4.Controls.Add(Me.label112)
        Me.GroupBox4.Controls.Add(Me.txtPermanenciaPodcast)
        Me.GroupBox4.Controls.Add(Me.GroupBox13)
        Me.GroupBox4.Controls.Add(Me.PanelFTP)
        Me.GroupBox4.Location = New System.Drawing.Point(52, 19)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(540, 269)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Servidor Web Potcasting"
        '
        'label113
        '
        Me.label113.ForeColor = System.Drawing.Color.Blue
        Me.label113.Location = New System.Drawing.Point(251, 219)
        Me.label113.Name = "label113"
        Me.label113.Size = New System.Drawing.Size(277, 19)
        Me.label113.TabIndex = 18
        Me.label113.Text = "Data Caducitat = Data Publicació + dies"
        '
        'label112
        '
        Me.label112.Location = New System.Drawing.Point(6, 219)
        Me.label112.Name = "label112"
        Me.label112.Size = New System.Drawing.Size(156, 19)
        Me.label112.TabIndex = 8
        Me.label112.Text = "Dies de permanència"
        Me.label112.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtPermanenciaPodcast
        '
        Me.txtPermanenciaPodcast.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtPermanenciaPodcast.Enabled = False
        Me.txtPermanenciaPodcast.Location = New System.Drawing.Point(181, 216)
        Me.txtPermanenciaPodcast.Name = "txtPermanenciaPodcast"
        Me.txtPermanenciaPodcast.ReadOnly = True
        Me.txtPermanenciaPodcast.Size = New System.Drawing.Size(60, 25)
        Me.txtPermanenciaPodcast.TabIndex = 8
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.ComboBoxSelectQualitatPodcast)
        Me.GroupBox13.Controls.Add(Me.Label19)
        Me.GroupBox13.Location = New System.Drawing.Point(25, 158)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(495, 44)
        Me.GroupBox13.TabIndex = 6
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "Resamplejar arxius"
        '
        'ComboBoxSelectQualitatPodcast
        '
        Me.ComboBoxSelectQualitatPodcast.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ComboBoxSelectQualitatPodcast.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSelectQualitatPodcast.Enabled = False
        Me.ComboBoxSelectQualitatPodcast.FormattingEnabled = True
        Me.ComboBoxSelectQualitatPodcast.Items.AddRange(New Object() {"NO Resampejar", "192 Kbps, 44.100hz, Stereo", "160 Kbps, 44.100hz, Stereo", "128 Kbps, 44.100hz, Stereo", " 96 Kbps, 44.100hz, Stereo", " 64 Kbps, 22.050hz, Stereo", " 32 Kbps, 22.050hz, Mono"})
        Me.ComboBoxSelectQualitatPodcast.Location = New System.Drawing.Point(156, 13)
        Me.ComboBoxSelectQualitatPodcast.Name = "ComboBoxSelectQualitatPodcast"
        Me.ComboBoxSelectQualitatPodcast.Size = New System.Drawing.Size(136, 25)
        Me.ComboBoxSelectQualitatPodcast.TabIndex = 7
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(14, 16)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(124, 19)
        Me.Label19.TabIndex = 4
        Me.Label19.Text = "Qualitat"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'PanelFTP
        '
        Me.PanelFTP.Controls.Add(Me.cmdTestFTP)
        Me.PanelFTP.Controls.Add(Me.txtPswFTP)
        Me.PanelFTP.Controls.Add(Me.txtUserFTP)
        Me.PanelFTP.Controls.Add(Me.txtDirFTP)
        Me.PanelFTP.Controls.Add(Me.txtServerFTP)
        Me.PanelFTP.Controls.Add(Me.Label66)
        Me.PanelFTP.Controls.Add(Me.Label65)
        Me.PanelFTP.Controls.Add(Me.Label64)
        Me.PanelFTP.Controls.Add(Me.Label63)
        Me.PanelFTP.Location = New System.Drawing.Point(25, 22)
        Me.PanelFTP.Name = "PanelFTP"
        Me.PanelFTP.Size = New System.Drawing.Size(495, 131)
        Me.PanelFTP.TabIndex = 5
        '
        'cmdTestFTP
        '
        Me.cmdTestFTP.Enabled = False
        Me.cmdTestFTP.Location = New System.Drawing.Point(351, 93)
        Me.cmdTestFTP.Name = "cmdTestFTP"
        Me.cmdTestFTP.Size = New System.Drawing.Size(120, 31)
        Me.cmdTestFTP.TabIndex = 8
        Me.cmdTestFTP.Text = "Test FTP"
        Me.cmdTestFTP.UseSelectable = True
        '
        'txtPswFTP
        '
        Me.txtPswFTP.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtPswFTP.Enabled = False
        Me.txtPswFTP.Location = New System.Drawing.Point(156, 101)
        Me.txtPswFTP.Name = "txtPswFTP"
        Me.txtPswFTP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPswFTP.ReadOnly = True
        Me.txtPswFTP.Size = New System.Drawing.Size(136, 25)
        Me.txtPswFTP.TabIndex = 7
        '
        'txtUserFTP
        '
        Me.txtUserFTP.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtUserFTP.Enabled = False
        Me.txtUserFTP.Location = New System.Drawing.Point(156, 68)
        Me.txtUserFTP.Name = "txtUserFTP"
        Me.txtUserFTP.ReadOnly = True
        Me.txtUserFTP.Size = New System.Drawing.Size(136, 25)
        Me.txtUserFTP.TabIndex = 6
        '
        'txtDirFTP
        '
        Me.txtDirFTP.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtDirFTP.Enabled = False
        Me.txtDirFTP.Location = New System.Drawing.Point(156, 35)
        Me.txtDirFTP.Name = "txtDirFTP"
        Me.txtDirFTP.ReadOnly = True
        Me.txtDirFTP.Size = New System.Drawing.Size(319, 25)
        Me.txtDirFTP.TabIndex = 5
        '
        'txtServerFTP
        '
        Me.txtServerFTP.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtServerFTP.Enabled = False
        Me.txtServerFTP.Location = New System.Drawing.Point(156, 2)
        Me.txtServerFTP.Name = "txtServerFTP"
        Me.txtServerFTP.ReadOnly = True
        Me.txtServerFTP.Size = New System.Drawing.Size(320, 25)
        Me.txtServerFTP.TabIndex = 4
        '
        'Label66
        '
        Me.Label66.Location = New System.Drawing.Point(14, 104)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(124, 19)
        Me.Label66.TabIndex = 3
        Me.Label66.Text = "Contrasenya"
        Me.Label66.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label65
        '
        Me.Label65.Location = New System.Drawing.Point(14, 71)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(124, 19)
        Me.Label65.TabIndex = 2
        Me.Label65.Text = "Usuari"
        Me.Label65.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label64
        '
        Me.Label64.Location = New System.Drawing.Point(3, 38)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(135, 19)
        Me.Label64.TabIndex = 1
        Me.Label64.Text = "Directori del servidor"
        Me.Label64.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label63
        '
        Me.Label63.Location = New System.Drawing.Point(14, 5)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(124, 19)
        Me.Label63.TabIndex = 0
        Me.Label63.Text = "Servidor FTP"
        Me.Label63.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'grupConnRemot
        '
        Me.grupConnRemot.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grupConnRemot.Controls.Add(Me.sldMilFader)
        Me.grupConnRemot.Controls.Add(Me.sldVolfader)
        Me.grupConnRemot.Controls.Add(Me.Label88)
        Me.grupConnRemot.Controls.Add(Me.lbMilFader)
        Me.grupConnRemot.Controls.Add(Me.Label14)
        Me.grupConnRemot.Controls.Add(Me.Label13)
        Me.grupConnRemot.Controls.Add(Me.lbVolfader)
        Me.grupConnRemot.Controls.Add(Me.Label12)
        Me.grupConnRemot.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!)
        Me.grupConnRemot.Location = New System.Drawing.Point(0, 0)
        Me.grupConnRemot.Name = "grupConnRemot"
        Me.grupConnRemot.Size = New System.Drawing.Size(630, 433)
        Me.grupConnRemot.TabIndex = 6
        Me.grupConnRemot.TabStop = False
        Me.grupConnRemot.Text = "Connexió Emissora Central"
        Me.grupConnRemot.Visible = False
        '
        'sldMilFader
        '
        Me.sldMilFader.BackColor = System.Drawing.Color.Transparent
        Me.sldMilFader.Enabled = False
        Me.sldMilFader.Location = New System.Drawing.Point(131, 192)
        Me.sldMilFader.Maximum = 5000
        Me.sldMilFader.Minimum = -1000
        Me.sldMilFader.Name = "sldMilFader"
        Me.sldMilFader.Size = New System.Drawing.Size(374, 32)
        Me.sldMilFader.TabIndex = 9
        Me.sldMilFader.Value = 2500
        '
        'sldVolfader
        '
        Me.sldVolfader.BackColor = System.Drawing.Color.Transparent
        Me.sldVolfader.Enabled = False
        Me.sldVolfader.Location = New System.Drawing.Point(131, 49)
        Me.sldVolfader.Maximum = 200
        Me.sldVolfader.Name = "sldVolfader"
        Me.sldVolfader.Size = New System.Drawing.Size(374, 32)
        Me.sldVolfader.TabIndex = 8
        Me.sldVolfader.Value = 100
        '
        'Label88
        '
        Me.Label88.ForeColor = System.Drawing.Color.Blue
        Me.Label88.Location = New System.Drawing.Point(130, 236)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(393, 56)
        Me.Label88.TabIndex = 7
        Me.Label88.Text = "La configuració de la targeta de so i el canal d'entrada s'ha de gestionar direct" &
    "ament en el programa MSC Controller i en el PC que gestiona la continuïtat."
        '
        'lbMilFader
        '
        Me.lbMilFader.AutoSize = True
        Me.lbMilFader.Location = New System.Drawing.Point(520, 202)
        Me.lbMilFader.Name = "lbMilFader"
        Me.lbMilFader.Size = New System.Drawing.Size(15, 17)
        Me.lbMilFader.TabIndex = 6
        Me.lbMilFader.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(147, 177)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(226, 17)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Milisegons d'espera per fer el fader :"
        '
        'Label13
        '
        Me.Label13.ForeColor = System.Drawing.Color.Blue
        Me.Label13.Location = New System.Drawing.Point(130, 83)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(393, 49)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Augmenta o disminueix el temps que tarda en fer un Fader In o Fader Out. "
        '
        'lbVolfader
        '
        Me.lbVolfader.AutoSize = True
        Me.lbVolfader.Location = New System.Drawing.Point(520, 59)
        Me.lbVolfader.Name = "lbVolfader"
        Me.lbVolfader.Size = New System.Drawing.Size(15, 17)
        Me.lbVolfader.TabIndex = 2
        Me.lbVolfader.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(147, 35)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(117, 17)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Velocitat de Fader:"
        '
        'grupControler
        '
        Me.grupControler.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grupControler.Controls.Add(Me.sldMilSegSH)
        Me.grupControler.Controls.Add(Me.txtSenyHora)
        Me.grupControler.Controls.Add(Me.label91)
        Me.grupControler.Controls.Add(Me.Label18)
        Me.grupControler.Controls.Add(Me.Label17)
        Me.grupControler.Controls.Add(Me.Label16)
        Me.grupControler.Controls.Add(Me.lbMilSegSH)
        Me.grupControler.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupControler.Location = New System.Drawing.Point(0, 0)
        Me.grupControler.Name = "grupControler"
        Me.grupControler.Size = New System.Drawing.Size(630, 433)
        Me.grupControler.TabIndex = 5
        Me.grupControler.TabStop = False
        Me.grupControler.Text = "MSC Controler"
        Me.grupControler.Visible = False
        '
        'sldMilSegSH
        '
        Me.sldMilSegSH.BackColor = System.Drawing.Color.Transparent
        Me.sldMilSegSH.Enabled = False
        Me.sldMilSegSH.Location = New System.Drawing.Point(59, 150)
        Me.sldMilSegSH.Maximum = 1500
        Me.sldMilSegSH.Minimum = -1000
        Me.sldMilSegSH.Name = "sldMilSegSH"
        Me.sldMilSegSH.Size = New System.Drawing.Size(476, 39)
        Me.sldMilSegSH.TabIndex = 9
        Me.sldMilSegSH.Text = "MetroTrackBar1"
        Me.sldMilSegSH.Value = 0
        '
        'txtSenyHora
        '
        '
        '
        '
        Me.txtSenyHora.CustomButton.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.txtSenyHora.CustomButton.Location = New System.Drawing.Point(489, 2)
        Me.txtSenyHora.CustomButton.Name = ""
        Me.txtSenyHora.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtSenyHora.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSenyHora.CustomButton.TabIndex = 1
        Me.txtSenyHora.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSenyHora.CustomButton.UseSelectable = True
        Me.txtSenyHora.Enabled = False
        Me.txtSenyHora.Lines = New String(-1) {}
        Me.txtSenyHora.Location = New System.Drawing.Point(58, 56)
        Me.txtSenyHora.MaxLength = 32767
        Me.txtSenyHora.Name = "txtSenyHora"
        Me.txtSenyHora.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSenyHora.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSenyHora.SelectedText = ""
        Me.txtSenyHora.SelectionLength = 0
        Me.txtSenyHora.SelectionStart = 0
        Me.txtSenyHora.ShortcutsEnabled = True
        Me.txtSenyHora.ShowButton = True
        Me.txtSenyHora.Size = New System.Drawing.Size(517, 30)
        Me.txtSenyHora.TabIndex = 8
        Me.txtSenyHora.UseSelectable = True
        Me.txtSenyHora.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSenyHora.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'label91
        '
        Me.label91.Location = New System.Drawing.Point(64, 131)
        Me.label91.Name = "label91"
        Me.label91.Size = New System.Drawing.Size(180, 17)
        Me.label91.TabIndex = 7
        Me.label91.Text = "Sincronització dels senyals horaris:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.Blue
        Me.Label18.Location = New System.Drawing.Point(62, 91)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(478, 17)
        Me.Label18.TabIndex = 5
        Me.Label18.Text = "Atenció, el fitxer dels senyals horaris no pot tenir una durada superior a 1 minu" &
    "t."
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(58, 35)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(130, 17)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "Fitxer senyals horaris"
        '
        'Label16
        '
        Me.Label16.ForeColor = System.Drawing.Color.Blue
        Me.Label16.Location = New System.Drawing.Point(62, 194)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(340, 27)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Milisegons adicionals per avançar el punt d'inici dels senyals horaris "
        '
        'lbMilSegSH
        '
        Me.lbMilSegSH.Location = New System.Drawing.Point(538, 161)
        Me.lbMilSegSH.Name = "lbMilSegSH"
        Me.lbMilSegSH.Size = New System.Drawing.Size(37, 17)
        Me.lbMilSegSH.TabIndex = 1
        Me.lbMilSegSH.Text = "0"
        Me.lbMilSegSH.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'grupPath
        '
        Me.grupPath.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grupPath.Controls.Add(Me.lbPathBackup)
        Me.grupPath.Controls.Add(Me.txtAternativeDir)
        Me.grupPath.Controls.Add(Me.txtPathArrelAudio)
        Me.grupPath.Controls.Add(Me.label134)
        Me.grupPath.Controls.Add(Me.lbPathPublicitat)
        Me.grupPath.Controls.Add(Me.lbPathProgrames)
        Me.grupPath.Controls.Add(Me.lbPathPautes)
        Me.grupPath.Controls.Add(Me.lbPathAudioUser)
        Me.grupPath.Controls.Add(Me.picKO)
        Me.grupPath.Controls.Add(Me.picOK)
        Me.grupPath.Controls.Add(Me.lbPathMusica)
        Me.grupPath.Controls.Add(Me.Label47)
        Me.grupPath.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupPath.Location = New System.Drawing.Point(0, 0)
        Me.grupPath.Name = "grupPath"
        Me.grupPath.Size = New System.Drawing.Size(630, 433)
        Me.grupPath.TabIndex = 0
        Me.grupPath.TabStop = False
        Me.grupPath.Text = "Directoris Magatzem"
        Me.grupPath.Visible = False
        '
        'lbPathBackup
        '
        Me.lbPathBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbPathBackup.Location = New System.Drawing.Point(77, 319)
        Me.lbPathBackup.Name = "lbPathBackup"
        Me.lbPathBackup.Size = New System.Drawing.Size(490, 21)
        Me.lbPathBackup.TabIndex = 18
        Me.lbPathBackup.Text = "Backup"
        Me.lbPathBackup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAternativeDir
        '
        Me.txtAternativeDir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtAternativeDir.CustomButton.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        Me.txtAternativeDir.CustomButton.Location = New System.Drawing.Point(454, 1)
        Me.txtAternativeDir.CustomButton.Name = ""
        Me.txtAternativeDir.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.txtAternativeDir.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtAternativeDir.CustomButton.TabIndex = 1
        Me.txtAternativeDir.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtAternativeDir.CustomButton.UseSelectable = True
        Me.txtAternativeDir.Enabled = False
        Me.txtAternativeDir.Lines = New String(-1) {}
        Me.txtAternativeDir.Location = New System.Drawing.Point(77, 88)
        Me.txtAternativeDir.MaxLength = 32767
        Me.txtAternativeDir.Name = "txtAternativeDir"
        Me.txtAternativeDir.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAternativeDir.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAternativeDir.SelectedText = ""
        Me.txtAternativeDir.SelectionLength = 0
        Me.txtAternativeDir.SelectionStart = 0
        Me.txtAternativeDir.ShortcutsEnabled = True
        Me.txtAternativeDir.ShowButton = True
        Me.txtAternativeDir.Size = New System.Drawing.Size(478, 25)
        Me.txtAternativeDir.TabIndex = 17
        Me.txtAternativeDir.UseSelectable = True
        Me.txtAternativeDir.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtAternativeDir.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPathArrelAudio
        '
        Me.txtPathArrelAudio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtPathArrelAudio.CustomButton.Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
        Me.txtPathArrelAudio.CustomButton.Location = New System.Drawing.Point(454, 1)
        Me.txtPathArrelAudio.CustomButton.Name = ""
        Me.txtPathArrelAudio.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.txtPathArrelAudio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPathArrelAudio.CustomButton.TabIndex = 1
        Me.txtPathArrelAudio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPathArrelAudio.CustomButton.UseSelectable = True
        Me.txtPathArrelAudio.Enabled = False
        Me.txtPathArrelAudio.Lines = New String(-1) {}
        Me.txtPathArrelAudio.Location = New System.Drawing.Point(77, 39)
        Me.txtPathArrelAudio.MaxLength = 32767
        Me.txtPathArrelAudio.Name = "txtPathArrelAudio"
        Me.txtPathArrelAudio.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPathArrelAudio.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPathArrelAudio.SelectedText = ""
        Me.txtPathArrelAudio.SelectionLength = 0
        Me.txtPathArrelAudio.SelectionStart = 0
        Me.txtPathArrelAudio.ShortcutsEnabled = True
        Me.txtPathArrelAudio.ShowButton = True
        Me.txtPathArrelAudio.Size = New System.Drawing.Size(478, 25)
        Me.txtPathArrelAudio.TabIndex = 16
        Me.txtPathArrelAudio.UseSelectable = True
        Me.txtPathArrelAudio.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPathArrelAudio.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'label134
        '
        Me.label134.AutoSize = True
        Me.label134.Location = New System.Drawing.Point(80, 69)
        Me.label134.Name = "label134"
        Me.label134.Size = New System.Drawing.Size(119, 17)
        Me.label134.TabIndex = 13
        Me.label134.Text = "Directori alternatiu:"
        '
        'lbPathPublicitat
        '
        Me.lbPathPublicitat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbPathPublicitat.Location = New System.Drawing.Point(77, 282)
        Me.lbPathPublicitat.Name = "lbPathPublicitat"
        Me.lbPathPublicitat.Size = New System.Drawing.Size(490, 21)
        Me.lbPathPublicitat.TabIndex = 12
        Me.lbPathPublicitat.Text = "Publicitat"
        Me.lbPathPublicitat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbPathProgrames
        '
        Me.lbPathProgrames.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbPathProgrames.Location = New System.Drawing.Point(77, 245)
        Me.lbPathProgrames.Name = "lbPathProgrames"
        Me.lbPathProgrames.Size = New System.Drawing.Size(490, 21)
        Me.lbPathProgrames.TabIndex = 10
        Me.lbPathProgrames.Text = "Programes"
        Me.lbPathProgrames.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbPathPautes
        '
        Me.lbPathPautes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbPathPautes.Location = New System.Drawing.Point(77, 208)
        Me.lbPathPautes.Name = "lbPathPautes"
        Me.lbPathPautes.Size = New System.Drawing.Size(490, 21)
        Me.lbPathPautes.TabIndex = 9
        Me.lbPathPautes.Text = "Pautes"
        Me.lbPathPautes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbPathAudioUser
        '
        Me.lbPathAudioUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbPathAudioUser.Location = New System.Drawing.Point(77, 171)
        Me.lbPathAudioUser.Name = "lbPathAudioUser"
        Me.lbPathAudioUser.Size = New System.Drawing.Size(490, 21)
        Me.lbPathAudioUser.TabIndex = 7
        Me.lbPathAudioUser.Text = "audioUser"
        Me.lbPathAudioUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'picKO
        '
        Me.picKO.Image = CType(resources.GetObject("picKO.Image"), System.Drawing.Image)
        Me.picKO.Location = New System.Drawing.Point(8, 380)
        Me.picKO.Name = "picKO"
        Me.picKO.Size = New System.Drawing.Size(21, 24)
        Me.picKO.TabIndex = 5
        Me.picKO.TabStop = False
        Me.picKO.Visible = False
        '
        'picOK
        '
        Me.picOK.Image = CType(resources.GetObject("picOK.Image"), System.Drawing.Image)
        Me.picOK.Location = New System.Drawing.Point(38, 380)
        Me.picOK.Name = "picOK"
        Me.picOK.Size = New System.Drawing.Size(25, 26)
        Me.picOK.TabIndex = 4
        Me.picOK.TabStop = False
        Me.picOK.Visible = False
        '
        'lbPathMusica
        '
        Me.lbPathMusica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbPathMusica.Location = New System.Drawing.Point(77, 134)
        Me.lbPathMusica.Name = "lbPathMusica"
        Me.lbPathMusica.Size = New System.Drawing.Size(490, 21)
        Me.lbPathMusica.TabIndex = 3
        Me.lbPathMusica.Text = "musica"
        Me.lbPathMusica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(80, 23)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(207, 17)
        Me.Label47.TabIndex = 0
        Me.Label47.Text = "Directori arrel dels fitxers d'àudio:"
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'grupReparar
        '
        Me.grupReparar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grupReparar.Controls.Add(Me.groupBox17)
        Me.grupReparar.Controls.Add(Me.groupBox16)
        Me.grupReparar.Controls.Add(Me.GroupBox12)
        Me.grupReparar.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupReparar.Location = New System.Drawing.Point(0, 0)
        Me.grupReparar.Name = "grupReparar"
        Me.grupReparar.Size = New System.Drawing.Size(630, 433)
        Me.grupReparar.TabIndex = 18
        Me.grupReparar.TabStop = False
        Me.grupReparar.Text = "Sistema de Dades"
        '
        'groupBox17
        '
        Me.groupBox17.Controls.Add(Me.buttonSincroWeb)
        Me.groupBox17.Controls.Add(Me.chkAllDBS)
        Me.groupBox17.Controls.Add(Me.label140)
        Me.groupBox17.Location = New System.Drawing.Point(60, 292)
        Me.groupBox17.Name = "groupBox17"
        Me.groupBox17.Size = New System.Drawing.Size(527, 110)
        Me.groupBox17.TabIndex = 13
        Me.groupBox17.TabStop = False
        Me.groupBox17.Text = "Resincronitzar web"
        '
        'buttonSincroWeb
        '
        Me.buttonSincroWeb.Enabled = False
        Me.buttonSincroWeb.Location = New System.Drawing.Point(30, 57)
        Me.buttonSincroWeb.Name = "buttonSincroWeb"
        Me.buttonSincroWeb.Size = New System.Drawing.Size(156, 30)
        Me.buttonSincroWeb.TabIndex = 9
        Me.buttonSincroWeb.Text = "Sincronitzar"
        Me.buttonSincroWeb.UseSelectable = True
        '
        'chkAllDBS
        '
        Me.chkAllDBS.AutoSize = True
        Me.chkAllDBS.Enabled = False
        Me.chkAllDBS.Location = New System.Drawing.Point(30, 35)
        Me.chkAllDBS.Name = "chkAllDBS"
        Me.chkAllDBS.Size = New System.Drawing.Size(61, 15)
        Me.chkAllDBS.TabIndex = 8
        Me.chkAllDBS.Text = "All DBS"
        Me.chkAllDBS.UseSelectable = True
        '
        'label140
        '
        Me.label140.AutoSize = True
        Me.label140.ForeColor = System.Drawing.Color.Blue
        Me.label140.Location = New System.Drawing.Point(195, 64)
        Me.label140.Name = "label140"
        Me.label140.Size = New System.Drawing.Size(208, 17)
        Me.label140.TabIndex = 6
        Me.label140.Text = "Sincronitza les dades compartides"
        '
        'groupBox16
        '
        Me.groupBox16.Controls.Add(Me.chkLastBKP)
        Me.groupBox16.Controls.Add(Me.lbLastBKP)
        Me.groupBox16.Location = New System.Drawing.Point(58, 27)
        Me.groupBox16.Name = "groupBox16"
        Me.groupBox16.Size = New System.Drawing.Size(529, 100)
        Me.groupBox16.TabIndex = 12
        Me.groupBox16.TabStop = False
        Me.groupBox16.Text = "Còpies automàtiques de la base de dades"
        '
        'chkLastBKP
        '
        Me.chkLastBKP.AutoSize = True
        Me.chkLastBKP.Enabled = False
        Me.chkLastBKP.Location = New System.Drawing.Point(30, 33)
        Me.chkLastBKP.Name = "chkLastBKP"
        Me.chkLastBKP.Size = New System.Drawing.Size(167, 15)
        Me.chkLastBKP.TabIndex = 2
        Me.chkLastBKP.Text = "Activar la còpia automàtica"
        Me.chkLastBKP.UseSelectable = True
        '
        'lbLastBKP
        '
        Me.lbLastBKP.Location = New System.Drawing.Point(30, 66)
        Me.lbLastBKP.Name = "lbLastBKP"
        Me.lbLastBKP.Size = New System.Drawing.Size(413, 23)
        Me.lbLastBKP.TabIndex = 1
        Me.lbLastBKP.Text = "Última còpia : 2015-05-05 11:30:00"
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.cmdProgresCancel)
        Me.GroupBox12.Controls.Add(Me.ProgressBar)
        Me.GroupBox12.Controls.Add(Me.cmdReparIDs)
        Me.GroupBox12.Controls.Add(Me.Label55)
        Me.GroupBox12.Location = New System.Drawing.Point(59, 137)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(528, 151)
        Me.GroupBox12.TabIndex = 11
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Reparar"
        '
        'cmdProgresCancel
        '
        Me.cmdProgresCancel.Location = New System.Drawing.Point(425, 90)
        Me.cmdProgresCancel.Name = "cmdProgresCancel"
        Me.cmdProgresCancel.Size = New System.Drawing.Size(64, 17)
        Me.cmdProgresCancel.TabIndex = 13
        Me.cmdProgresCancel.Text = "Cancel"
        Me.cmdProgresCancel.UseSelectable = True
        Me.cmdProgresCancel.Visible = False
        '
        'ProgressBar
        '
        Me.ProgressBar.HideProgressText = False
        Me.ProgressBar.Location = New System.Drawing.Point(30, 89)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(384, 17)
        Me.ProgressBar.TabIndex = 12
        Me.ProgressBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ProgressBar.Visible = False
        '
        'cmdReparIDs
        '
        Me.cmdReparIDs.Enabled = False
        Me.cmdReparIDs.Location = New System.Drawing.Point(30, 30)
        Me.cmdReparIDs.Name = "cmdReparIDs"
        Me.cmdReparIDs.Size = New System.Drawing.Size(156, 30)
        Me.cmdReparIDs.TabIndex = 11
        Me.cmdReparIDs.Text = "Reparar IDs depenents"
        Me.cmdReparIDs.UseSelectable = True
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.ForeColor = System.Drawing.Color.Blue
        Me.Label55.Location = New System.Drawing.Point(195, 37)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(279, 17)
        Me.Label55.TabIndex = 6
        Me.Label55.Text = "Repara les dependències errònies de la BBDD."
        '
        'GroupClients
        '
        Me.GroupClients.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupClients.Controls.Add(Me.lbOnline)
        Me.GroupClients.Controls.Add(Me.chkOnLine)
        Me.GroupClients.Controls.Add(Me.cmdActive)
        Me.GroupClients.Controls.Add(Me.groupBoxCloudShareOptions)
        Me.GroupClients.Controls.Add(Me.lbCientID)
        Me.GroupClients.Controls.Add(Me.txtClientKey)
        Me.GroupClients.Controls.Add(Me.Label85)
        Me.GroupClients.Controls.Add(Me.LbClientKO)
        Me.GroupClients.Controls.Add(Me.LbClientOK)
        Me.GroupClients.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupClients.Location = New System.Drawing.Point(0, 0)
        Me.GroupClients.Name = "GroupClients"
        Me.GroupClients.Size = New System.Drawing.Size(630, 433)
        Me.GroupClients.TabIndex = 10
        Me.GroupClients.TabStop = False
        Me.GroupClients.Text = "Registre del servei"
        Me.GroupClients.Visible = False
        '
        'lbOnline
        '
        Me.lbOnline.AutoSize = True
        Me.lbOnline.Location = New System.Drawing.Point(345, 213)
        Me.lbOnline.Name = "lbOnline"
        Me.lbOnline.Size = New System.Drawing.Size(157, 19)
        Me.lbOnline.TabIndex = 25
        Me.lbOnline.Text = "Active sincronation online"
        '
        'chkOnLine
        '
        Me.chkOnLine.AutoSize = True
        Me.chkOnLine.Enabled = False
        Me.chkOnLine.Location = New System.Drawing.Point(228, 212)
        Me.chkOnLine.Name = "chkOnLine"
        Me.chkOnLine.Size = New System.Drawing.Size(80, 21)
        Me.chkOnLine.TabIndex = 24
        Me.chkOnLine.Text = "Off"
        Me.chkOnLine.UseSelectable = True
        '
        'cmdActive
        '
        Me.cmdActive.ActiveControl = Nothing
        Me.cmdActive.Enabled = False
        Me.cmdActive.Location = New System.Drawing.Point(230, 147)
        Me.cmdActive.Name = "cmdActive"
        Me.cmdActive.Size = New System.Drawing.Size(184, 46)
        Me.cmdActive.TabIndex = 23
        Me.cmdActive.Text = "Activació"
        Me.cmdActive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdActive.TileImage = CType(resources.GetObject("cmdActive.TileImage"), System.Drawing.Image)
        Me.cmdActive.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdActive.UseSelectable = True
        Me.cmdActive.UseTileImage = True
        '
        'groupBoxCloudShareOptions
        '
        Me.groupBoxCloudShareOptions.Controls.Add(Me.chk_sharePrograms)
        Me.groupBoxCloudShareOptions.Controls.Add(Me.cmdSalvarOptionsNuvol)
        Me.groupBoxCloudShareOptions.Enabled = False
        Me.groupBoxCloudShareOptions.Location = New System.Drawing.Point(97, 246)
        Me.groupBoxCloudShareOptions.Name = "groupBoxCloudShareOptions"
        Me.groupBoxCloudShareOptions.Size = New System.Drawing.Size(450, 188)
        Me.groupBoxCloudShareOptions.TabIndex = 22
        Me.groupBoxCloudShareOptions.TabStop = False
        '
        'chk_sharePrograms
        '
        Me.chk_sharePrograms.AutoSize = True
        Me.chk_sharePrograms.Location = New System.Drawing.Point(133, 48)
        Me.chk_sharePrograms.Name = "chk_sharePrograms"
        Me.chk_sharePrograms.Size = New System.Drawing.Size(137, 15)
        Me.chk_sharePrograms.TabIndex = 16
        Me.chk_sharePrograms.Text = "Compartir Programes"
        Me.chk_sharePrograms.UseSelectable = True
        '
        'cmdSalvarOptionsNuvol
        '
        Me.cmdSalvarOptionsNuvol.ActiveControl = Nothing
        Me.cmdSalvarOptionsNuvol.Enabled = False
        Me.cmdSalvarOptionsNuvol.Location = New System.Drawing.Point(133, 92)
        Me.cmdSalvarOptionsNuvol.Name = "cmdSalvarOptionsNuvol"
        Me.cmdSalvarOptionsNuvol.Size = New System.Drawing.Size(184, 41)
        Me.cmdSalvarOptionsNuvol.TabIndex = 15
        Me.cmdSalvarOptionsNuvol.TileImage = CType(resources.GetObject("cmdSalvarOptionsNuvol.TileImage"), System.Drawing.Image)
        Me.cmdSalvarOptionsNuvol.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdSalvarOptionsNuvol.UseSelectable = True
        Me.cmdSalvarOptionsNuvol.UseTileImage = True
        '
        'lbCientID
        '
        Me.lbCientID.BackColor = System.Drawing.Color.Lime
        Me.lbCientID.Location = New System.Drawing.Point(457, 17)
        Me.lbCientID.Name = "lbCientID"
        Me.lbCientID.Size = New System.Drawing.Size(18, 23)
        Me.lbCientID.TabIndex = 21
        Me.lbCientID.Text = "0"
        Me.lbCientID.Visible = False
        '
        'txtClientKey
        '
        Me.txtClientKey.AcceptsReturn = True
        Me.txtClientKey.BackColor = System.Drawing.SystemColors.Window
        Me.txtClientKey.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtClientKey.Enabled = False
        Me.txtClientKey.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClientKey.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtClientKey.Location = New System.Drawing.Point(97, 93)
        Me.txtClientKey.MaxLength = 0
        Me.txtClientKey.Multiline = True
        Me.txtClientKey.Name = "txtClientKey"
        Me.txtClientKey.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtClientKey.Size = New System.Drawing.Size(450, 45)
        Me.txtClientKey.TabIndex = 13
        Me.txtClientKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label85
        '
        Me.Label85.AutoSize = True
        Me.Label85.BackColor = System.Drawing.Color.Transparent
        Me.Label85.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label85.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label85.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label85.Location = New System.Drawing.Point(107, 75)
        Me.Label85.Name = "Label85"
        Me.Label85.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label85.Size = New System.Drawing.Size(91, 17)
        Me.Label85.TabIndex = 16
        Me.Label85.Text = "Clau Activació:"
        '
        'LbClientKO
        '
        Me.LbClientKO.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbClientKO.Image = CType(resources.GetObject("LbClientKO.Image"), System.Drawing.Image)
        Me.LbClientKO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LbClientKO.Location = New System.Drawing.Point(152, 16)
        Me.LbClientKO.Name = "LbClientKO"
        Me.LbClientKO.Size = New System.Drawing.Size(340, 51)
        Me.LbClientKO.TabIndex = 19
        Me.LbClientKO.Text = "Serveis avançats desactivats"
        Me.LbClientKO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LbClientOK
        '
        Me.LbClientOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbClientOK.Image = CType(resources.GetObject("LbClientOK.Image"), System.Drawing.Image)
        Me.LbClientOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LbClientOK.Location = New System.Drawing.Point(152, 16)
        Me.LbClientOK.Name = "LbClientOK"
        Me.LbClientOK.Size = New System.Drawing.Size(340, 51)
        Me.LbClientOK.TabIndex = 20
        Me.LbClientOK.Text = "Client amb seveis avançats"
        Me.LbClientOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LbClientOK.Visible = False
        '
        'grupParams
        '
        Me.grupParams.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grupParams.Controls.Add(Me.lbInfoProces)
        Me.grupParams.Controls.Add(Me.MetroPanel1)
        Me.grupParams.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!)
        Me.grupParams.Location = New System.Drawing.Point(0, 0)
        Me.grupParams.Name = "grupParams"
        Me.grupParams.Size = New System.Drawing.Size(630, 430)
        Me.grupParams.TabIndex = 11
        Me.grupParams.TabStop = False
        Me.grupParams.Text = "Paràmetres generals"
        Me.grupParams.Visible = False
        '
        'lbInfoProces
        '
        Me.lbInfoProces.AutoSize = True
        Me.lbInfoProces.Location = New System.Drawing.Point(244, 399)
        Me.lbInfoProces.Name = "lbInfoProces"
        Me.lbInfoProces.Size = New System.Drawing.Size(0, 17)
        Me.lbInfoProces.TabIndex = 9
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroPanel1.AutoScroll = True
        Me.MetroPanel1.Controls.Add(Me.GroupBox6)
        Me.MetroPanel1.Controls.Add(Me.grupCarp)
        Me.MetroPanel1.Controls.Add(Me.GroupBox1)
        Me.MetroPanel1.HorizontalScrollbar = True
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(8, 24)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(624, 410)
        Me.MetroPanel1.TabIndex = 18
        Me.MetroPanel1.VerticalScrollbar = True
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = True
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'GroupBox6
        '
        Me.GroupBox6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox6.Controls.Add(Me.cmbLang)
        Me.GroupBox6.Controls.Add(Me.label125)
        Me.GroupBox6.Controls.Add(Me.txtWeb)
        Me.GroupBox6.Controls.Add(Me.label124)
        Me.GroupBox6.Controls.Add(Me.label111)
        Me.GroupBox6.Controls.Add(Me.txtTwitterKey)
        Me.GroupBox6.Controls.Add(Me.Label110)
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.Controls.Add(Me.txtTwitter)
        Me.GroupBox6.Controls.Add(Me.txtFaceBook)
        Me.GroupBox6.Controls.Add(Me.txtNomRadio)
        Me.GroupBox6.Controls.Add(Me.cmdAddLogo)
        Me.GroupBox6.Controls.Add(Me.imgLogo)
        Me.GroupBox6.Controls.Add(Me.Label1)
        Me.GroupBox6.Controls.Add(Me.lbNomRadio)
        Me.GroupBox6.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(588, 283)
        Me.GroupBox6.TabIndex = 18
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Emissora"
        '
        'cmbLang
        '
        Me.cmbLang.Enabled = False
        Me.cmbLang.FormattingEnabled = True
        Me.cmbLang.Items.AddRange(New Object() {"Català", "English"})
        Me.cmbLang.Location = New System.Drawing.Point(191, 144)
        Me.cmbLang.Name = "cmbLang"
        Me.cmbLang.Size = New System.Drawing.Size(251, 25)
        Me.cmbLang.TabIndex = 7
        '
        'label125
        '
        Me.label125.Location = New System.Drawing.Point(15, 143)
        Me.label125.Name = "label125"
        Me.label125.Size = New System.Drawing.Size(167, 26)
        Me.label125.TabIndex = 14
        Me.label125.Text = "Idioma Interfície:"
        Me.label125.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtWeb
        '
        Me.txtWeb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtWeb.Enabled = False
        Me.txtWeb.Location = New System.Drawing.Point(191, 40)
        Me.txtWeb.Name = "txtWeb"
        Me.txtWeb.Size = New System.Drawing.Size(376, 25)
        Me.txtWeb.TabIndex = 2
        '
        'label124
        '
        Me.label124.Location = New System.Drawing.Point(16, 42)
        Me.label124.Name = "label124"
        Me.label124.Size = New System.Drawing.Size(166, 21)
        Me.label124.TabIndex = 13
        Me.label124.Text = "Adreça web:"
        Me.label124.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'label111
        '
        Me.label111.Location = New System.Drawing.Point(16, 118)
        Me.label111.Name = "label111"
        Me.label111.Size = New System.Drawing.Size(166, 25)
        Me.label111.TabIndex = 12
        Me.label111.Text = "Twitter Key:"
        Me.label111.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTwitterKey
        '
        Me.txtTwitterKey.Enabled = False
        Me.txtTwitterKey.Location = New System.Drawing.Point(191, 118)
        Me.txtTwitterKey.Name = "txtTwitterKey"
        Me.txtTwitterKey.Size = New System.Drawing.Size(251, 25)
        Me.txtTwitterKey.TabIndex = 6
        '
        'Label110
        '
        Me.Label110.Location = New System.Drawing.Point(16, 94)
        Me.Label110.Name = "Label110"
        Me.Label110.Size = New System.Drawing.Size(166, 21)
        Me.Label110.TabIndex = 8
        Me.Label110.Text = "Twitter:"
        Me.Label110.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "FaceBook:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTwitter
        '
        Me.txtTwitter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTwitter.Enabled = False
        Me.txtTwitter.Location = New System.Drawing.Point(191, 92)
        Me.txtTwitter.Name = "txtTwitter"
        Me.txtTwitter.Size = New System.Drawing.Size(376, 25)
        Me.txtTwitter.TabIndex = 5
        '
        'txtFaceBook
        '
        Me.txtFaceBook.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFaceBook.Enabled = False
        Me.txtFaceBook.Location = New System.Drawing.Point(191, 66)
        Me.txtFaceBook.Name = "txtFaceBook"
        Me.txtFaceBook.Size = New System.Drawing.Size(376, 25)
        Me.txtFaceBook.TabIndex = 4
        '
        'txtNomRadio
        '
        Me.txtNomRadio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNomRadio.Enabled = False
        Me.txtNomRadio.Location = New System.Drawing.Point(191, 14)
        Me.txtNomRadio.Name = "txtNomRadio"
        Me.txtNomRadio.Size = New System.Drawing.Size(376, 25)
        Me.txtNomRadio.TabIndex = 1
        '
        'cmdAddLogo
        '
        Me.cmdAddLogo.Enabled = False
        Me.cmdAddLogo.Location = New System.Drawing.Point(112, 246)
        Me.cmdAddLogo.Name = "cmdAddLogo"
        Me.cmdAddLogo.Size = New System.Drawing.Size(70, 26)
        Me.cmdAddLogo.TabIndex = 7
        Me.cmdAddLogo.Text = "Afegir logo"
        Me.cmdAddLogo.UseVisualStyleBackColor = True
        '
        'imgLogo
        '
        Me.imgLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imgLogo.Location = New System.Drawing.Point(191, 177)
        Me.imgLogo.Name = "imgLogo"
        Me.imgLogo.Size = New System.Drawing.Size(101, 95)
        Me.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgLogo.TabIndex = 3
        Me.imgLogo.TabStop = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 177)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Logo:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbNomRadio
        '
        Me.lbNomRadio.Location = New System.Drawing.Point(16, 16)
        Me.lbNomRadio.Name = "lbNomRadio"
        Me.lbNomRadio.Size = New System.Drawing.Size(166, 21)
        Me.lbNomRadio.TabIndex = 0
        Me.lbNomRadio.Text = "Nom de la ràdio:"
        Me.lbNomRadio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grupCarp
        '
        Me.grupCarp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grupCarp.Controls.Add(Me.Label57)
        Me.grupCarp.Controls.Add(Me.grupCarpBlocs)
        Me.grupCarp.Controls.Add(Me.cmdAddCarpBlocs)
        Me.grupCarp.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupCarp.Location = New System.Drawing.Point(12, 415)
        Me.grupCarp.Name = "grupCarp"
        Me.grupCarp.Size = New System.Drawing.Size(588, 123)
        Me.grupCarp.TabIndex = 11
        Me.grupCarp.TabStop = False
        Me.grupCarp.Text = "Temàtiques dels blocs musicals"
        '
        'Label57
        '
        Me.Label57.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label57.AutoSize = True
        Me.Label57.ForeColor = System.Drawing.Color.Blue
        Me.Label57.Location = New System.Drawing.Point(113, 103)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(216, 17)
        Me.Label57.TabIndex = 2
        Me.Label57.Text = "Les caselles sense nom es borraran"
        '
        'grupCarpBlocs
        '
        Me.grupCarpBlocs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grupCarpBlocs.Enabled = False
        Me.grupCarpBlocs.Location = New System.Drawing.Point(110, 21)
        Me.grupCarpBlocs.Name = "grupCarpBlocs"
        Me.grupCarpBlocs.Size = New System.Drawing.Size(457, 81)
        Me.grupCarpBlocs.TabIndex = 0
        '
        'cmdAddCarpBlocs
        '
        Me.cmdAddCarpBlocs.Enabled = False
        Me.cmdAddCarpBlocs.Location = New System.Drawing.Point(15, 21)
        Me.cmdAddCarpBlocs.Name = "cmdAddCarpBlocs"
        Me.cmdAddCarpBlocs.Size = New System.Drawing.Size(75, 28)
        Me.cmdAddCarpBlocs.TabIndex = 1
        Me.cmdAddCarpBlocs.Text = "Afegir.."
        Me.cmdAddCarpBlocs.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lbCommentDesconnexio)
        Me.GroupBox1.Controls.Add(Me.txtComentDesconnexio)
        Me.GroupBox1.Controls.Add(Me.cmbTipProg)
        Me.GroupBox1.Controls.Add(Me.Label94)
        Me.GroupBox1.Controls.Add(Me.Label96)
        Me.GroupBox1.Controls.Add(Me.lbInfo)
        Me.GroupBox1.Controls.Add(Me.lbRadForm)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 287)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(588, 121)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Calendari"
        '
        'lbCommentDesconnexio
        '
        Me.lbCommentDesconnexio.Location = New System.Drawing.Point(8, 92)
        Me.lbCommentDesconnexio.Name = "lbCommentDesconnexio"
        Me.lbCommentDesconnexio.Size = New System.Drawing.Size(159, 26)
        Me.lbCommentDesconnexio.TabIndex = 22
        Me.lbCommentDesconnexio.Text = "Comment:"
        Me.lbCommentDesconnexio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbCommentDesconnexio.Visible = False
        '
        'txtComentDesconnexio
        '
        '
        '
        '
        Me.txtComentDesconnexio.CustomButton.Image = Nothing
        Me.txtComentDesconnexio.CustomButton.Location = New System.Drawing.Point(368, 2)
        Me.txtComentDesconnexio.CustomButton.Name = ""
        Me.txtComentDesconnexio.CustomButton.Size = New System.Drawing.Size(19, 19)
        Me.txtComentDesconnexio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtComentDesconnexio.CustomButton.TabIndex = 1
        Me.txtComentDesconnexio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtComentDesconnexio.CustomButton.UseSelectable = True
        Me.txtComentDesconnexio.CustomButton.Visible = False
        Me.txtComentDesconnexio.Enabled = False
        Me.txtComentDesconnexio.Lines = New String(-1) {}
        Me.txtComentDesconnexio.Location = New System.Drawing.Point(191, 93)
        Me.txtComentDesconnexio.MaxLength = 32767
        Me.txtComentDesconnexio.Name = "txtComentDesconnexio"
        Me.txtComentDesconnexio.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtComentDesconnexio.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtComentDesconnexio.SelectedText = ""
        Me.txtComentDesconnexio.SelectionLength = 0
        Me.txtComentDesconnexio.SelectionStart = 0
        Me.txtComentDesconnexio.ShortcutsEnabled = True
        Me.txtComentDesconnexio.Size = New System.Drawing.Size(390, 24)
        Me.txtComentDesconnexio.TabIndex = 21
        Me.txtComentDesconnexio.UseSelectable = True
        Me.txtComentDesconnexio.Visible = False
        Me.txtComentDesconnexio.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtComentDesconnexio.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'cmbTipProg
        '
        Me.cmbTipProg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipProg.Enabled = False
        Me.cmbTipProg.FormattingEnabled = True
        Me.cmbTipProg.Location = New System.Drawing.Point(191, 15)
        Me.cmbTipProg.Name = "cmbTipProg"
        Me.cmbTipProg.Size = New System.Drawing.Size(391, 25)
        Me.cmbTipProg.TabIndex = 8
        '
        'Label94
        '
        Me.Label94.Location = New System.Drawing.Point(13, 15)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(159, 32)
        Me.Label94.TabIndex = 8
        Me.Label94.Text = "Programació per defecte:"
        Me.Label94.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label96
        '
        Me.Label96.AutoSize = True
        Me.Label96.Font = New System.Drawing.Font("Segoe UI Symbol", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label96.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label96.Location = New System.Drawing.Point(306, 42)
        Me.Label96.Name = "Label96"
        Me.Label96.Size = New System.Drawing.Size(280, 13)
        Me.Label96.TabIndex = 9
        Me.Label96.Text = "La durada per defecte és d'una hora (No modificable)"
        Me.Label96.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbInfo
        '
        Me.lbInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbInfo.Image = CType(resources.GetObject("lbInfo.Image"), System.Drawing.Image)
        Me.lbInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbInfo.Location = New System.Drawing.Point(72, 48)
        Me.lbInfo.Name = "lbInfo"
        Me.lbInfo.Size = New System.Drawing.Size(480, 42)
        Me.lbInfo.TabIndex = 19
        Me.lbInfo.Text = "Sistemes en standby, la continuïtat és responsabilitat del tècnic."
        Me.lbInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbRadForm
        '
        Me.lbRadForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRadForm.Image = CType(resources.GetObject("lbRadForm.Image"), System.Drawing.Image)
        Me.lbRadForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbRadForm.Location = New System.Drawing.Point(72, 45)
        Me.lbRadForm.Name = "lbRadForm"
        Me.lbRadForm.Size = New System.Drawing.Size(480, 47)
        Me.lbRadForm.TabIndex = 20
        Me.lbRadForm.Text = "Ràdio Fórmula musical, segons els paràmetres de la pauta per defecte. "
        Me.lbRadForm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbRadForm.Visible = False
        '
        'grupMoneda
        '
        Me.grupMoneda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grupMoneda.Controls.Add(Me.lbDies)
        Me.grupMoneda.Controls.Add(Me.txtVDEF_DateOut)
        Me.grupMoneda.Controls.Add(Me.lbDataOut)
        Me.grupMoneda.Controls.Add(Me.txtCanvi)
        Me.grupMoneda.Controls.Add(Me.Label46)
        Me.grupMoneda.Controls.Add(Me.cmbContraValor)
        Me.grupMoneda.Controls.Add(Me.ComboBoxVDef_tarifa)
        Me.grupMoneda.Controls.Add(Me.Label45)
        Me.grupMoneda.Controls.Add(Me.cmbMoneda)
        Me.grupMoneda.Controls.Add(Me.Label44)
        Me.grupMoneda.Controls.Add(Me.lbTarifa)
        Me.grupMoneda.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupMoneda.Location = New System.Drawing.Point(0, 0)
        Me.grupMoneda.Name = "grupMoneda"
        Me.grupMoneda.Size = New System.Drawing.Size(630, 433)
        Me.grupMoneda.TabIndex = 1
        Me.grupMoneda.TabStop = False
        Me.grupMoneda.Text = "Publicitat"
        Me.grupMoneda.Visible = False
        '
        'lbDies
        '
        Me.lbDies.AutoSize = True
        Me.lbDies.Location = New System.Drawing.Point(348, 194)
        Me.lbDies.Name = "lbDies"
        Me.lbDies.Size = New System.Drawing.Size(32, 17)
        Me.lbDies.TabIndex = 6
        Me.lbDies.Text = "dies"
        '
        'txtVDEF_DateOut
        '
        Me.txtVDEF_DateOut.Enabled = False
        Me.txtVDEF_DateOut.Location = New System.Drawing.Point(255, 190)
        Me.txtVDEF_DateOut.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtVDEF_DateOut.Name = "txtVDEF_DateOut"
        Me.txtVDEF_DateOut.Size = New System.Drawing.Size(70, 25)
        Me.txtVDEF_DateOut.TabIndex = 5
        Me.txtVDEF_DateOut.Text = "5"
        '
        'lbDataOut
        '
        Me.lbDataOut.Location = New System.Drawing.Point(54, 197)
        Me.lbDataOut.Name = "lbDataOut"
        Me.lbDataOut.Size = New System.Drawing.Size(182, 17)
        Me.lbDataOut.TabIndex = 4
        Me.lbDataOut.Text = "Data sortida: avui + "
        Me.lbDataOut.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtCanvi
        '
        Me.txtCanvi.Enabled = False
        Me.txtCanvi.Location = New System.Drawing.Point(255, 153)
        Me.txtCanvi.Name = "txtCanvi"
        Me.txtCanvi.Size = New System.Drawing.Size(158, 25)
        Me.txtCanvi.TabIndex = 5
        '
        'Label46
        '
        Me.Label46.Location = New System.Drawing.Point(10, 158)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(226, 21)
        Me.Label46.TabIndex = 4
        Me.Label46.Text = "Relació de canvi:"
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmbContraValor
        '
        Me.cmbContraValor.Enabled = False
        Me.cmbContraValor.FormattingEnabled = True
        Me.cmbContraValor.Location = New System.Drawing.Point(255, 116)
        Me.cmbContraValor.Name = "cmbContraValor"
        Me.cmbContraValor.Size = New System.Drawing.Size(158, 25)
        Me.cmbContraValor.TabIndex = 3
        '
        'ComboBoxVDef_tarifa
        '
        Me.ComboBoxVDef_tarifa.Enabled = False
        Me.ComboBoxVDef_tarifa.FormattingEnabled = True
        Me.ComboBoxVDef_tarifa.Location = New System.Drawing.Point(255, 42)
        Me.ComboBoxVDef_tarifa.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBoxVDef_tarifa.Name = "ComboBoxVDef_tarifa"
        Me.ComboBoxVDef_tarifa.Size = New System.Drawing.Size(160, 25)
        Me.ComboBoxVDef_tarifa.TabIndex = 2
        '
        'Label45
        '
        Me.Label45.Location = New System.Drawing.Point(10, 119)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(226, 21)
        Me.Label45.TabIndex = 2
        Me.Label45.Text = "Contra Valor:"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmbMoneda
        '
        Me.cmbMoneda.Enabled = False
        Me.cmbMoneda.FormattingEnabled = True
        Me.cmbMoneda.Location = New System.Drawing.Point(255, 79)
        Me.cmbMoneda.Name = "cmbMoneda"
        Me.cmbMoneda.Size = New System.Drawing.Size(158, 25)
        Me.cmbMoneda.TabIndex = 1
        '
        'Label44
        '
        Me.Label44.Location = New System.Drawing.Point(10, 80)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(226, 21)
        Me.Label44.TabIndex = 0
        Me.Label44.Text = "Moneda amb que es treballa:"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbTarifa
        '
        Me.lbTarifa.Location = New System.Drawing.Point(8, 45)
        Me.lbTarifa.Name = "lbTarifa"
        Me.lbTarifa.Size = New System.Drawing.Size(228, 17)
        Me.lbTarifa.TabIndex = 3
        Me.lbTarifa.Text = "Tarifa per defecte"
        Me.lbTarifa.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'grupCartut
        '
        Me.grupCartut.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grupCartut.Controls.Add(Me.chkCTL_USR_Cartux)
        Me.grupCartut.Controls.Add(Me.chkActvTabProgram)
        Me.grupCartut.Controls.Add(Me.Label58)
        Me.grupCartut.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupCartut.Location = New System.Drawing.Point(0, 0)
        Me.grupCartut.Name = "grupCartut"
        Me.grupCartut.Size = New System.Drawing.Size(630, 433)
        Me.grupCartut.TabIndex = 7
        Me.grupCartut.TabStop = False
        Me.grupCartut.Text = "MSC Cartutxeres"
        Me.grupCartut.Visible = False
        '
        'chkCTL_USR_Cartux
        '
        Me.chkCTL_USR_Cartux.AutoSize = True
        Me.chkCTL_USR_Cartux.Enabled = False
        Me.chkCTL_USR_Cartux.Location = New System.Drawing.Point(157, 106)
        Me.chkCTL_USR_Cartux.Name = "chkCTL_USR_Cartux"
        Me.chkCTL_USR_Cartux.Size = New System.Drawing.Size(200, 15)
        Me.chkCTL_USR_Cartux.TabIndex = 4
        Me.chkCTL_USR_Cartux.Text = "Control d'usuaris a les cartutxeres"
        Me.chkCTL_USR_Cartux.UseSelectable = True
        '
        'chkActvTabProgram
        '
        Me.chkActvTabProgram.AutoSize = True
        Me.chkActvTabProgram.Enabled = False
        Me.chkActvTabProgram.Location = New System.Drawing.Point(157, 74)
        Me.chkActvTabProgram.Name = "chkActvTabProgram"
        Me.chkActvTabProgram.Size = New System.Drawing.Size(269, 15)
        Me.chkActvTabProgram.TabIndex = 3
        Me.chkActvTabProgram.Text = "Tenir accesibilitat a les sessions dels programes"
        Me.chkActvTabProgram.UseSelectable = True
        '
        'Label58
        '
        Me.Label58.ForeColor = System.Drawing.Color.Blue
        Me.Label58.Location = New System.Drawing.Point(157, 135)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(332, 52)
        Me.Label58.TabIndex = 2
        Me.Label58.Text = "Ha d'estar activat el control d'usuaris. Per configurar-lo aneu a manteniment d'u" &
    "suaris."
        '
        'grupCategories
        '
        Me.grupCategories.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grupCategories.Controls.Add(Me.MetroPanel2)
        Me.grupCategories.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupCategories.Location = New System.Drawing.Point(0, 0)
        Me.grupCategories.Name = "grupCategories"
        Me.grupCategories.Size = New System.Drawing.Size(630, 430)
        Me.grupCategories.TabIndex = 2
        Me.grupCategories.TabStop = False
        Me.grupCategories.Text = "Regles Musicals"
        Me.grupCategories.Visible = False
        '
        'MetroPanel2
        '
        Me.MetroPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroPanel2.AutoScroll = True
        Me.MetroPanel2.Controls.Add(Me.lbTestHOld)
        Me.MetroPanel2.Controls.Add(Me.lbTestHHitTop)
        Me.MetroPanel2.Controls.Add(Me.lbTestHOldTop)
        Me.MetroPanel2.Controls.Add(Me.Label22)
        Me.MetroPanel2.Controls.Add(Me.lbTestsHHit)
        Me.MetroPanel2.Controls.Add(Me.Label31)
        Me.MetroPanel2.Controls.Add(Me.lbTestHTop)
        Me.MetroPanel2.Controls.Add(Me.Label32)
        Me.MetroPanel2.Controls.Add(Me.lbTestHBorrInterp)
        Me.MetroPanel2.Controls.Add(Me.txtHTop)
        Me.MetroPanel2.Controls.Add(Me.label114)
        Me.MetroPanel2.Controls.Add(Me.Label33)
        Me.MetroPanel2.Controls.Add(Me.txtMinusProhivDisc)
        Me.MetroPanel2.Controls.Add(Me.txtHHit)
        Me.MetroPanel2.Controls.Add(Me.label115)
        Me.MetroPanel2.Controls.Add(Me.Label34)
        Me.MetroPanel2.Controls.Add(Me.Label25)
        Me.MetroPanel2.Controls.Add(Me.txtHHitTop)
        Me.MetroPanel2.Controls.Add(Me.txtHBorrInterp)
        Me.MetroPanel2.Controls.Add(Me.Label35)
        Me.MetroPanel2.Controls.Add(Me.Label24)
        Me.MetroPanel2.Controls.Add(Me.txtHOldTop)
        Me.MetroPanel2.Controls.Add(Me.Label23)
        Me.MetroPanel2.Controls.Add(Me.Label36)
        Me.MetroPanel2.Controls.Add(Me.txtIntervRitme)
        Me.MetroPanel2.Controls.Add(Me.txtOld)
        Me.MetroPanel2.Controls.Add(Me.GroupBox2)
        Me.MetroPanel2.Controls.Add(Me.txtMaxRadiOLD)
        Me.MetroPanel2.Controls.Add(Me.Label40)
        Me.MetroPanel2.Controls.Add(Me.Label43)
        Me.MetroPanel2.Controls.Add(Me.Label41)
        Me.MetroPanel2.Controls.Add(Me.txtMaxRadiHIT)
        Me.MetroPanel2.Controls.Add(Me.txtMaxRadiTop)
        Me.MetroPanel2.Controls.Add(Me.Label42)
        Me.MetroPanel2.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetroPanel2.HorizontalScrollbar = True
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(4, 18)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(623, 409)
        Me.MetroPanel2.TabIndex = 18
        Me.MetroPanel2.VerticalScrollbar = True
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'lbTestHOld
        '
        Me.lbTestHOld.AutoSize = True
        Me.lbTestHOld.Location = New System.Drawing.Point(484, 315)
        Me.lbTestHOld.Name = "lbTestHOld"
        Me.lbTestHOld.Size = New System.Drawing.Size(86, 17)
        Me.lbTestHOld.TabIndex = 33
        Me.lbTestHOld.Text = "0 disponibles"
        Me.lbTestHOld.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbTestHHitTop
        '
        Me.lbTestHHitTop.AutoSize = True
        Me.lbTestHHitTop.Location = New System.Drawing.Point(246, 349)
        Me.lbTestHHitTop.Name = "lbTestHHitTop"
        Me.lbTestHHitTop.Size = New System.Drawing.Size(86, 17)
        Me.lbTestHHitTop.TabIndex = 31
        Me.lbTestHHitTop.Text = "0 disponibles"
        Me.lbTestHHitTop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbTestHOldTop
        '
        Me.lbTestHOldTop.AutoSize = True
        Me.lbTestHOldTop.Location = New System.Drawing.Point(484, 281)
        Me.lbTestHOldTop.Name = "lbTestHOldTop"
        Me.lbTestHOldTop.Size = New System.Drawing.Size(86, 17)
        Me.lbTestHOldTop.TabIndex = 32
        Me.lbTestHOldTop.Text = "0 disponibles"
        Me.lbTestHOldTop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(306, 15)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(90, 17)
        Me.Label22.TabIndex = 22
        Me.Label22.Text = "Interval Ritme:"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbTestsHHit
        '
        Me.lbTestsHHit.AutoSize = True
        Me.lbTestsHHit.Location = New System.Drawing.Point(246, 315)
        Me.lbTestsHHit.Name = "lbTestsHHit"
        Me.lbTestsHHit.Size = New System.Drawing.Size(86, 17)
        Me.lbTestsHHit.TabIndex = 30
        Me.lbTestsHHit.Text = "0 disponibles"
        Me.lbTestsHHit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label31
        '
        Me.Label31.ForeColor = System.Drawing.Color.Blue
        Me.Label31.Location = New System.Drawing.Point(17, 238)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(589, 38)
        Me.Label31.TabIndex = 0
        Me.Label31.Text = "Número de hores que han de passar fins que una cançó no torni a sonar. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Segons l" &
    "a 'classificació temporal' de la cançó podem definir un interval diferent."
        '
        'lbTestHTop
        '
        Me.lbTestHTop.AutoSize = True
        Me.lbTestHTop.Location = New System.Drawing.Point(244, 281)
        Me.lbTestHTop.Name = "lbTestHTop"
        Me.lbTestHTop.Size = New System.Drawing.Size(86, 17)
        Me.lbTestHTop.TabIndex = 29
        Me.lbTestHTop.Text = "0 disponibles"
        Me.lbTestHTop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(130, 281)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(35, 17)
        Me.Label32.TabIndex = 1
        Me.Label32.Text = "TOP:"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbTestHBorrInterp
        '
        Me.lbTestHBorrInterp.AutoSize = True
        Me.lbTestHBorrInterp.Location = New System.Drawing.Point(482, 100)
        Me.lbTestHBorrInterp.Name = "lbTestHBorrInterp"
        Me.lbTestHBorrInterp.Size = New System.Drawing.Size(86, 17)
        Me.lbTestHBorrInterp.TabIndex = 28
        Me.lbTestHBorrInterp.Text = "0 disponibles"
        Me.lbTestHBorrInterp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtHTop
        '
        Me.txtHTop.Enabled = False
        Me.txtHTop.Location = New System.Drawing.Point(172, 277)
        Me.txtHTop.Name = "txtHTop"
        Me.txtHTop.Size = New System.Drawing.Size(65, 25)
        Me.txtHTop.TabIndex = 2
        '
        'label114
        '
        Me.label114.ForeColor = System.Drawing.Color.Blue
        Me.label114.Location = New System.Drawing.Point(17, 210)
        Me.label114.Name = "label114"
        Me.label114.Size = New System.Drawing.Size(449, 24)
        Me.label114.TabIndex = 27
        Me.label114.Text = "Si el valor és 0 equival a no s'establir la prohibició."
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(134, 315)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(30, 17)
        Me.Label33.TabIndex = 3
        Me.Label33.Text = "HIT:"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMinusProhivDisc
        '
        Me.txtMinusProhivDisc.Enabled = False
        Me.txtMinusProhivDisc.Location = New System.Drawing.Point(408, 181)
        Me.txtMinusProhivDisc.Name = "txtMinusProhivDisc"
        Me.txtMinusProhivDisc.Size = New System.Drawing.Size(66, 25)
        Me.txtMinusProhivDisc.TabIndex = 21
        '
        'txtHHit
        '
        Me.txtHHit.Enabled = False
        Me.txtHHit.Location = New System.Drawing.Point(172, 311)
        Me.txtHHit.Name = "txtHHit"
        Me.txtHHit.Size = New System.Drawing.Size(65, 25)
        Me.txtHHit.TabIndex = 4
        '
        'label115
        '
        Me.label115.Location = New System.Drawing.Point(58, 177)
        Me.label115.Name = "label115"
        Me.label115.Size = New System.Drawing.Size(338, 33)
        Me.label115.TabIndex = 26
        Me.label115.Text = "Minuts que han de passar per poder repetir un disc:"
        Me.label115.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(112, 349)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(54, 17)
        Me.Label34.TabIndex = 5
        Me.Label34.Text = "HITTOP:"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label25
        '
        Me.Label25.ForeColor = System.Drawing.Color.Blue
        Me.Label25.Location = New System.Drawing.Point(17, 122)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(594, 59)
        Me.Label25.TabIndex = 25
        Me.Label25.Text = "Aquest valor no hauria de ser superior al valor més petit d'hores que han de pass" &
    "ar per repetir una cançó segons la seva categoria (veure ""Comptadors"")."
        '
        'txtHHitTop
        '
        Me.txtHHitTop.Enabled = False
        Me.txtHHitTop.Location = New System.Drawing.Point(172, 345)
        Me.txtHHitTop.Name = "txtHHitTop"
        Me.txtHHitTop.Size = New System.Drawing.Size(65, 25)
        Me.txtHHitTop.TabIndex = 6
        '
        'txtHBorrInterp
        '
        Me.txtHBorrInterp.Enabled = False
        Me.txtHBorrInterp.Location = New System.Drawing.Point(408, 96)
        Me.txtHBorrInterp.Name = "txtHBorrInterp"
        Me.txtHBorrInterp.Size = New System.Drawing.Size(66, 25)
        Me.txtHBorrInterp.TabIndex = 20
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(345, 281)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(58, 17)
        Me.Label35.TabIndex = 7
        Me.Label35.Text = "OLTTOP:"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(47, 92)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(349, 33)
        Me.Label24.TabIndex = 24
        Me.Label24.Text = "Hores que han de passar per poder repetir un intèrpret:"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtHOldTop
        '
        Me.txtHOldTop.Enabled = False
        Me.txtHOldTop.Location = New System.Drawing.Point(408, 277)
        Me.txtHOldTop.Name = "txtHOldTop"
        Me.txtHOldTop.Size = New System.Drawing.Size(65, 25)
        Me.txtHOldTop.TabIndex = 8
        '
        'Label23
        '
        Me.Label23.ForeColor = System.Drawing.Color.Blue
        Me.Label23.Location = New System.Drawing.Point(17, 43)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(594, 49)
        Me.Label23.TabIndex = 23
        Me.Label23.Text = "El paràmetre ""Interval Ritme"" expressa la tolerància del filtratge del ritme. Ex:" &
    " si assignem un interval de 20 , al filtrar cançons d'un ritme de 100 BPMs toler" &
    "arà ritmes de 80 fins a 120. "
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(366, 315)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(36, 17)
        Me.Label36.TabIndex = 9
        Me.Label36.Text = "OLD:"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtIntervRitme
        '
        Me.txtIntervRitme.Enabled = False
        Me.txtIntervRitme.Location = New System.Drawing.Point(408, 11)
        Me.txtIntervRitme.Name = "txtIntervRitme"
        Me.txtIntervRitme.Size = New System.Drawing.Size(66, 25)
        Me.txtIntervRitme.TabIndex = 19
        '
        'txtOld
        '
        Me.txtOld.Enabled = False
        Me.txtOld.Location = New System.Drawing.Point(408, 311)
        Me.txtOld.Name = "txtOld"
        Me.txtOld.Size = New System.Drawing.Size(65, 25)
        Me.txtOld.TabIndex = 10
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label39)
        Me.GroupBox2.Controls.Add(Me.txtNHitOld)
        Me.GroupBox2.Controls.Add(Me.Label38)
        Me.GroupBox2.Controls.Add(Me.txtNTopHit)
        Me.GroupBox2.Controls.Add(Me.Label37)
        Me.GroupBox2.Controls.Add(Me.chkCanviCat)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 381)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(599, 133)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Canvi automàtic de categoria"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.ForeColor = System.Drawing.Color.Blue
        Me.Label39.Location = New System.Drawing.Point(10, 110)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(446, 17)
        Me.Label39.TabIndex = 5
        Me.Label39.Text = "La categoria HitTop i OldTop s'interpreten com a Hit i Old respectivament. "
        '
        'txtNHitOld
        '
        Me.txtNHitOld.Enabled = False
        Me.txtNHitOld.Location = New System.Drawing.Point(401, 76)
        Me.txtNHitOld.Name = "txtNHitOld"
        Me.txtNHitOld.Size = New System.Drawing.Size(69, 25)
        Me.txtNHitOld.TabIndex = 4
        '
        'Label38
        '
        Me.Label38.Location = New System.Drawing.Point(40, 76)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(353, 24)
        Me.Label38.TabIndex = 3
        Me.Label38.Text = "Nº de radiacions per passar de Hit a Old:"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNTopHit
        '
        Me.txtNTopHit.Enabled = False
        Me.txtNTopHit.Location = New System.Drawing.Point(401, 44)
        Me.txtNTopHit.Name = "txtNTopHit"
        Me.txtNTopHit.Size = New System.Drawing.Size(69, 25)
        Me.txtNTopHit.TabIndex = 2
        '
        'Label37
        '
        Me.Label37.Location = New System.Drawing.Point(33, 44)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(360, 25)
        Me.Label37.TabIndex = 1
        Me.Label37.Text = "Nº de radiacions per passar de Top a Hit:"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkCanviCat
        '
        Me.chkCanviCat.AutoSize = True
        Me.chkCanviCat.Enabled = False
        Me.chkCanviCat.Location = New System.Drawing.Point(37, 20)
        Me.chkCanviCat.Name = "chkCanviCat"
        Me.chkCanviCat.Size = New System.Drawing.Size(169, 21)
        Me.chkCanviCat.TabIndex = 0
        Me.chkCanviCat.Text = "Activa el canvi automàtic"
        Me.chkCanviCat.UseVisualStyleBackColor = True
        '
        'txtMaxRadiOLD
        '
        Me.txtMaxRadiOLD.Enabled = False
        Me.txtMaxRadiOLD.Location = New System.Drawing.Point(408, 632)
        Me.txtMaxRadiOLD.Name = "txtMaxRadiOLD"
        Me.txtMaxRadiOLD.Size = New System.Drawing.Size(69, 25)
        Me.txtMaxRadiOLD.TabIndex = 18
        '
        'Label40
        '
        Me.Label40.ForeColor = System.Drawing.Color.Blue
        Me.Label40.Location = New System.Drawing.Point(17, 521)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(576, 56)
        Me.Label40.TabIndex = 12
        Me.Label40.Text = "A una cançó podem forçar-li el número màxim de radiacion segons la seva categoria" &
    ", passat aquestes radiacions deixarà d'estar activa. S'ha d'activar aquesta opci" &
    "ó a cada cançó en concret."
        '
        'Label43
        '
        Me.Label43.Location = New System.Drawing.Point(41, 632)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(361, 24)
        Me.Label43.TabIndex = 17
        Me.Label43.Text = "Nº Màxim de radiacions per un OLD:"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label41
        '
        Me.Label41.Location = New System.Drawing.Point(41, 578)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(361, 24)
        Me.Label41.TabIndex = 13
        Me.Label41.Text = "Nº Màxim de radiacions per un TOP:"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMaxRadiHIT
        '
        Me.txtMaxRadiHIT.Enabled = False
        Me.txtMaxRadiHIT.Location = New System.Drawing.Point(408, 605)
        Me.txtMaxRadiHIT.Name = "txtMaxRadiHIT"
        Me.txtMaxRadiHIT.Size = New System.Drawing.Size(69, 25)
        Me.txtMaxRadiHIT.TabIndex = 16
        '
        'txtMaxRadiTop
        '
        Me.txtMaxRadiTop.Enabled = False
        Me.txtMaxRadiTop.Location = New System.Drawing.Point(408, 578)
        Me.txtMaxRadiTop.Name = "txtMaxRadiTop"
        Me.txtMaxRadiTop.Size = New System.Drawing.Size(69, 25)
        Me.txtMaxRadiTop.TabIndex = 14
        '
        'Label42
        '
        Me.Label42.Location = New System.Drawing.Point(41, 605)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(361, 24)
        Me.Label42.TabIndex = 15
        Me.Label42.Text = "Nº Màxim de radiacions per un HIT:"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grupSOS
        '
        Me.grupSOS.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grupSOS.Controls.Add(Me.labelActiveSOS)
        Me.grupSOS.Controls.Add(Me.CheckBoxActiveSOS)
        Me.grupSOS.Controls.Add(Me.buttonDelCtlLog)
        Me.grupSOS.Controls.Add(Me.txtPathLogErr)
        Me.grupSOS.Controls.Add(Me.label53)
        Me.grupSOS.Controls.Add(Me.Label86)
        Me.grupSOS.Controls.Add(Me.Label20)
        Me.grupSOS.Controls.Add(Me.grupActiveSos)
        Me.grupSOS.Controls.Add(Me.Label87)
        Me.grupSOS.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!)
        Me.grupSOS.Location = New System.Drawing.Point(0, 0)
        Me.grupSOS.Name = "grupSOS"
        Me.grupSOS.Size = New System.Drawing.Size(630, 433)
        Me.grupSOS.TabIndex = 23
        Me.grupSOS.TabStop = False
        Me.grupSOS.Text = "Servei d'emergència"
        Me.grupSOS.Visible = False
        '
        'labelActiveSOS
        '
        Me.labelActiveSOS.AutoSize = True
        Me.labelActiveSOS.Location = New System.Drawing.Point(236, 20)
        Me.labelActiveSOS.Name = "labelActiveSOS"
        Me.labelActiveSOS.Size = New System.Drawing.Size(171, 19)
        Me.labelActiveSOS.TabIndex = 28
        Me.labelActiveSOS.Text = "Activar servei d'emergència"
        '
        'CheckBoxActiveSOS
        '
        Me.CheckBoxActiveSOS.AutoSize = True
        Me.CheckBoxActiveSOS.Enabled = False
        Me.CheckBoxActiveSOS.Location = New System.Drawing.Point(150, 20)
        Me.CheckBoxActiveSOS.Name = "CheckBoxActiveSOS"
        Me.CheckBoxActiveSOS.Size = New System.Drawing.Size(80, 21)
        Me.CheckBoxActiveSOS.TabIndex = 27
        Me.CheckBoxActiveSOS.Text = "Off"
        Me.CheckBoxActiveSOS.UseSelectable = True
        '
        'buttonDelCtlLog
        '
        Me.buttonDelCtlLog.Enabled = False
        Me.buttonDelCtlLog.Location = New System.Drawing.Point(565, 381)
        Me.buttonDelCtlLog.Name = "buttonDelCtlLog"
        Me.buttonDelCtlLog.Size = New System.Drawing.Size(50, 25)
        Me.buttonDelCtlLog.TabIndex = 26
        Me.buttonDelCtlLog.Text = "Esborrar"
        Me.buttonDelCtlLog.UseSelectable = True
        '
        'txtPathLogErr
        '
        Me.txtPathLogErr.BackColor = System.Drawing.SystemColors.InactiveBorder
        '
        '
        '
        Me.txtPathLogErr.CustomButton.Image = CType(resources.GetObject("resource.Image4"), System.Drawing.Image)
        Me.txtPathLogErr.CustomButton.Location = New System.Drawing.Point(509, 1)
        Me.txtPathLogErr.CustomButton.Name = ""
        Me.txtPathLogErr.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.txtPathLogErr.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPathLogErr.CustomButton.TabIndex = 1
        Me.txtPathLogErr.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPathLogErr.CustomButton.UseSelectable = True
        Me.txtPathLogErr.Enabled = False
        Me.txtPathLogErr.Lines = New String(-1) {}
        Me.txtPathLogErr.Location = New System.Drawing.Point(23, 381)
        Me.txtPathLogErr.MaxLength = 32767
        Me.txtPathLogErr.Name = "txtPathLogErr"
        Me.txtPathLogErr.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPathLogErr.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPathLogErr.SelectedText = ""
        Me.txtPathLogErr.SelectionLength = 0
        Me.txtPathLogErr.SelectionStart = 0
        Me.txtPathLogErr.ShortcutsEnabled = True
        Me.txtPathLogErr.ShowButton = True
        Me.txtPathLogErr.Size = New System.Drawing.Size(533, 25)
        Me.txtPathLogErr.TabIndex = 25
        Me.txtPathLogErr.UseCustomBackColor = True
        Me.txtPathLogErr.UseSelectable = True
        Me.txtPathLogErr.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPathLogErr.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'label53
        '
        Me.label53.Location = New System.Drawing.Point(26, 364)
        Me.label53.Name = "label53"
        Me.label53.Size = New System.Drawing.Size(100, 12)
        Me.label53.TabIndex = 21
        Me.label53.Text = "Localització:"
        '
        'Label86
        '
        Me.Label86.ForeColor = System.Drawing.Color.Blue
        Me.Label86.Location = New System.Drawing.Point(25, 46)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(617, 38)
        Me.Label86.TabIndex = 19
        Me.Label86.Text = "Utilitzeu aquesta funció per assabentar-vos al moment de qualsevol pèrdua de cont" &
    "inuïtat de la programació"
        '
        'Label20
        '
        Me.Label20.ForeColor = System.Drawing.Color.Blue
        Me.Label20.Location = New System.Drawing.Point(25, 319)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(555, 45)
        Me.Label20.TabIndex = 18
        Me.Label20.Text = resources.GetString("Label20.Text")
        '
        'grupActiveSos
        '
        Me.grupActiveSos.Controls.Add(Me.MetroLabel1)
        Me.grupActiveSos.Controls.Add(Me.chk_SendDevelop)
        Me.grupActiveSos.Controls.Add(Me.cmdTestMailErr)
        Me.grupActiveSos.Controls.Add(Me.Label74)
        Me.grupActiveSos.Controls.Add(Me.txtMailDesti)
        Me.grupActiveSos.Controls.Add(Me.Label72)
        Me.grupActiveSos.Controls.Add(Me.txtMailRemitent)
        Me.grupActiveSos.Controls.Add(Me.Label71)
        Me.grupActiveSos.Enabled = False
        Me.grupActiveSos.Location = New System.Drawing.Point(21, 77)
        Me.grupActiveSos.Margin = New System.Windows.Forms.Padding(2)
        Me.grupActiveSos.Name = "grupActiveSos"
        Me.grupActiveSos.Padding = New System.Windows.Forms.Padding(2)
        Me.grupActiveSos.Size = New System.Drawing.Size(594, 190)
        Me.grupActiveSos.TabIndex = 2
        Me.grupActiveSos.TabStop = False
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(221, 160)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(156, 19)
        Me.MetroLabel1.TabIndex = 29
        Me.MetroLabel1.Text = "Send errors to developer"
        '
        'chk_SendDevelop
        '
        Me.chk_SendDevelop.AutoSize = True
        Me.chk_SendDevelop.Checked = True
        Me.chk_SendDevelop.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_SendDevelop.Enabled = False
        Me.chk_SendDevelop.Location = New System.Drawing.Point(129, 160)
        Me.chk_SendDevelop.Name = "chk_SendDevelop"
        Me.chk_SendDevelop.Size = New System.Drawing.Size(80, 21)
        Me.chk_SendDevelop.TabIndex = 28
        Me.chk_SendDevelop.Text = "On"
        Me.chk_SendDevelop.UseSelectable = True
        '
        'cmdTestMailErr
        '
        Me.cmdTestMailErr.Enabled = False
        Me.cmdTestMailErr.Location = New System.Drawing.Point(129, 109)
        Me.cmdTestMailErr.Name = "cmdTestMailErr"
        Me.cmdTestMailErr.Size = New System.Drawing.Size(176, 34)
        Me.cmdTestMailErr.TabIndex = 11
        Me.cmdTestMailErr.Text = "Test"
        Me.cmdTestMailErr.UseSelectable = True
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.ForeColor = System.Drawing.Color.Blue
        Me.Label74.Location = New System.Drawing.Point(198, 83)
        Me.Label74.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(273, 17)
        Me.Label74.TabIndex = 8
        Me.Label74.Text = "És possible varis correus separats per comes"
        '
        'txtMailDesti
        '
        Me.txtMailDesti.Enabled = False
        Me.txtMailDesti.Location = New System.Drawing.Point(129, 54)
        Me.txtMailDesti.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMailDesti.Name = "txtMailDesti"
        Me.txtMailDesti.Size = New System.Drawing.Size(176, 25)
        Me.txtMailDesti.TabIndex = 5
        '
        'Label72
        '
        Me.Label72.Location = New System.Drawing.Point(8, 56)
        Me.Label72.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(113, 25)
        Me.Label72.TabIndex = 4
        Me.Label72.Text = "Correu destí"
        Me.Label72.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtMailRemitent
        '
        Me.txtMailRemitent.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtMailRemitent.Location = New System.Drawing.Point(129, 19)
        Me.txtMailRemitent.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMailRemitent.Name = "txtMailRemitent"
        Me.txtMailRemitent.ReadOnly = True
        Me.txtMailRemitent.Size = New System.Drawing.Size(176, 25)
        Me.txtMailRemitent.TabIndex = 3
        '
        'Label71
        '
        Me.Label71.Location = New System.Drawing.Point(8, 20)
        Me.Label71.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(113, 25)
        Me.Label71.TabIndex = 2
        Me.Label71.Text = "Correu remitent"
        Me.Label71.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label87
        '
        Me.Label87.ForeColor = System.Drawing.Color.Blue
        Me.Label87.Location = New System.Drawing.Point(25, 275)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(580, 40)
        Me.Label87.TabIndex = 20
        Me.Label87.Text = resources.GetString("Label87.Text")
        '
        'grupDBS
        '
        Me.grupDBS.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grupDBS.Controls.Add(Me.cmdAddDBS)
        Me.grupDBS.Controls.Add(Me.txtPathINI)
        Me.grupDBS.Controls.Add(Me.labelMltDBS)
        Me.grupDBS.Controls.Add(Me.chkMltDBS)
        Me.grupDBS.Controls.Add(Me.label51)
        Me.grupDBS.Controls.Add(Me.GroupBoxDetallDBS)
        Me.grupDBS.Controls.Add(Me.Label4)
        Me.grupDBS.Controls.Add(Me.lstDBS)
        Me.grupDBS.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupDBS.Location = New System.Drawing.Point(0, 0)
        Me.grupDBS.Name = "grupDBS"
        Me.grupDBS.Size = New System.Drawing.Size(630, 433)
        Me.grupDBS.TabIndex = 9
        Me.grupDBS.TabStop = False
        Me.grupDBS.Text = "Connexió d'accés"
        Me.grupDBS.Visible = False
        '
        'cmdAddDBS
        '
        Me.cmdAddDBS.Enabled = False
        Me.cmdAddDBS.Location = New System.Drawing.Point(23, 329)
        Me.cmdAddDBS.Name = "cmdAddDBS"
        Me.cmdAddDBS.Size = New System.Drawing.Size(191, 31)
        Me.cmdAddDBS.TabIndex = 19
        Me.cmdAddDBS.Text = "Nova"
        Me.cmdAddDBS.UseSelectable = True
        '
        'txtPathINI
        '
        '
        '
        '
        Me.txtPathINI.CustomButton.Image = CType(resources.GetObject("resource.Image5"), System.Drawing.Image)
        Me.txtPathINI.CustomButton.Location = New System.Drawing.Point(546, 2)
        Me.txtPathINI.CustomButton.Name = ""
        Me.txtPathINI.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.txtPathINI.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPathINI.CustomButton.TabIndex = 1
        Me.txtPathINI.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPathINI.CustomButton.UseSelectable = True
        Me.txtPathINI.Enabled = False
        Me.txtPathINI.Lines = New String(-1) {}
        Me.txtPathINI.Location = New System.Drawing.Point(23, 63)
        Me.txtPathINI.MaxLength = 32767
        Me.txtPathINI.Name = "txtPathINI"
        Me.txtPathINI.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPathINI.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPathINI.SelectedText = ""
        Me.txtPathINI.SelectionLength = 0
        Me.txtPathINI.SelectionStart = 0
        Me.txtPathINI.ShortcutsEnabled = True
        Me.txtPathINI.ShowButton = True
        Me.txtPathINI.Size = New System.Drawing.Size(572, 28)
        Me.txtPathINI.TabIndex = 18
        Me.txtPathINI.UseSelectable = True
        Me.txtPathINI.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPathINI.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'labelMltDBS
        '
        Me.labelMltDBS.AutoSize = True
        Me.labelMltDBS.Location = New System.Drawing.Point(223, 24)
        Me.labelMltDBS.Name = "labelMltDBS"
        Me.labelMltDBS.Size = New System.Drawing.Size(177, 19)
        Me.labelMltDBS.TabIndex = 17
        Me.labelMltDBS.Text = "Accés a múltiples connexions"
        '
        'chkMltDBS
        '
        Me.chkMltDBS.AutoSize = True
        Me.chkMltDBS.Enabled = False
        Me.chkMltDBS.Location = New System.Drawing.Point(137, 23)
        Me.chkMltDBS.Name = "chkMltDBS"
        Me.chkMltDBS.Size = New System.Drawing.Size(80, 21)
        Me.chkMltDBS.TabIndex = 16
        Me.chkMltDBS.Text = "Off"
        Me.chkMltDBS.UseSelectable = True
        '
        'label51
        '
        Me.label51.Location = New System.Drawing.Point(22, 44)
        Me.label51.Name = "label51"
        Me.label51.Size = New System.Drawing.Size(100, 20)
        Me.label51.TabIndex = 13
        Me.label51.Text = "Localització:"
        '
        'GroupBoxDetallDBS
        '
        Me.GroupBoxDetallDBS.Controls.Add(Me.cmdExportConnection)
        Me.GroupBoxDetallDBS.Controls.Add(Me.cmdDelDBS)
        Me.GroupBoxDetallDBS.Controls.Add(Me.txtDBSPort)
        Me.GroupBoxDetallDBS.Controls.Add(Me.Label8)
        Me.GroupBoxDetallDBS.Controls.Add(Me.txtDBSPassword)
        Me.GroupBoxDetallDBS.Controls.Add(Me.Label10)
        Me.GroupBoxDetallDBS.Controls.Add(Me.txtDBSUser)
        Me.GroupBoxDetallDBS.Controls.Add(Me.Label9)
        Me.GroupBoxDetallDBS.Controls.Add(Me.txtDBSHost)
        Me.GroupBoxDetallDBS.Controls.Add(Me.Label7)
        Me.GroupBoxDetallDBS.Controls.Add(Me.txtDBSName)
        Me.GroupBoxDetallDBS.Controls.Add(Me.Label6)
        Me.GroupBoxDetallDBS.Controls.Add(Me.txtDBSDescip)
        Me.GroupBoxDetallDBS.Controls.Add(Me.Label5)
        Me.GroupBoxDetallDBS.Enabled = False
        Me.GroupBoxDetallDBS.Location = New System.Drawing.Point(219, 105)
        Me.GroupBoxDetallDBS.Name = "GroupBoxDetallDBS"
        Me.GroupBoxDetallDBS.Size = New System.Drawing.Size(376, 322)
        Me.GroupBoxDetallDBS.TabIndex = 5
        Me.GroupBoxDetallDBS.TabStop = False
        '
        'cmdExportConnection
        '
        Me.cmdExportConnection.Enabled = False
        Me.cmdExportConnection.Location = New System.Drawing.Point(240, 222)
        Me.cmdExportConnection.Name = "cmdExportConnection"
        Me.cmdExportConnection.Size = New System.Drawing.Size(119, 31)
        Me.cmdExportConnection.TabIndex = 16
        Me.cmdExportConnection.Text = "Export"
        Me.cmdExportConnection.UseSelectable = True
        '
        'cmdDelDBS
        '
        Me.cmdDelDBS.Enabled = False
        Me.cmdDelDBS.Location = New System.Drawing.Point(105, 222)
        Me.cmdDelDBS.Name = "cmdDelDBS"
        Me.cmdDelDBS.Size = New System.Drawing.Size(119, 31)
        Me.cmdDelDBS.TabIndex = 15
        Me.cmdDelDBS.Text = "Esborrar"
        Me.cmdDelDBS.UseSelectable = True
        '
        'txtDBSPort
        '
        Me.txtDBSPort.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDBSPort.Location = New System.Drawing.Point(105, 137)
        Me.txtDBSPort.Name = "txtDBSPort"
        Me.txtDBSPort.Size = New System.Drawing.Size(254, 25)
        Me.txtDBSPort.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(6, 137)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 24)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Port:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDBSPassword
        '
        Me.txtDBSPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDBSPassword.Location = New System.Drawing.Point(105, 193)
        Me.txtDBSPassword.Name = "txtDBSPassword"
        Me.txtDBSPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtDBSPassword.Size = New System.Drawing.Size(254, 25)
        Me.txtDBSPassword.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(6, 193)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 24)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Contrasenya:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDBSUser
        '
        Me.txtDBSUser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDBSUser.Location = New System.Drawing.Point(105, 165)
        Me.txtDBSUser.Name = "txtDBSUser"
        Me.txtDBSUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtDBSUser.Size = New System.Drawing.Size(254, 25)
        Me.txtDBSUser.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(6, 165)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 24)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Usuari:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDBSHost
        '
        Me.txtDBSHost.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDBSHost.Location = New System.Drawing.Point(105, 109)
        Me.txtDBSHost.Name = "txtDBSHost"
        Me.txtDBSHost.Size = New System.Drawing.Size(254, 25)
        Me.txtDBSHost.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(6, 109)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 24)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Host o IP:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDBSName
        '
        Me.txtDBSName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDBSName.Location = New System.Drawing.Point(105, 81)
        Me.txtDBSName.Name = "txtDBSName"
        Me.txtDBSName.Size = New System.Drawing.Size(254, 25)
        Me.txtDBSName.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(6, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 24)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Nom DBS:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDBSDescip
        '
        Me.txtDBSDescip.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDBSDescip.Location = New System.Drawing.Point(105, 19)
        Me.txtDBSDescip.Multiline = True
        Me.txtDBSDescip.Name = "txtDBSDescip"
        Me.txtDBSDescip.Size = New System.Drawing.Size(254, 60)
        Me.txtDBSDescip.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(6, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 24)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Descripció"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(188, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Llistat de connexions possibles"
        '
        'lstDBS
        '
        Me.lstDBS.FormattingEnabled = True
        Me.lstDBS.ItemHeight = 17
        Me.lstDBS.Location = New System.Drawing.Point(23, 114)
        Me.lstDBS.Name = "lstDBS"
        Me.lstDBS.Size = New System.Drawing.Size(190, 208)
        Me.lstDBS.TabIndex = 2
        '
        'grupDirecte
        '
        Me.grupDirecte.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grupDirecte.Controls.Add(Me.sldMSegOClok)
        Me.grupDirecte.Controls.Add(Me.chkForceHoraExect)
        Me.grupDirecte.Controls.Add(Me.chkBorHistInterp)
        Me.grupDirecte.Controls.Add(Me.lbMSegOClok)
        Me.grupDirecte.Controls.Add(Me.Label21)
        Me.grupDirecte.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupDirecte.Location = New System.Drawing.Point(0, 0)
        Me.grupDirecte.Name = "grupDirecte"
        Me.grupDirecte.Size = New System.Drawing.Size(630, 433)
        Me.grupDirecte.TabIndex = 4
        Me.grupDirecte.TabStop = False
        Me.grupDirecte.Text = "MSC Directe"
        Me.grupDirecte.Visible = False
        '
        'sldMSegOClok
        '
        Me.sldMSegOClok.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sldMSegOClok.BackColor = System.Drawing.Color.Transparent
        Me.sldMSegOClok.Enabled = False
        Me.sldMSegOClok.Location = New System.Drawing.Point(217, 53)
        Me.sldMSegOClok.Maximum = 3000
        Me.sldMSegOClok.Minimum = -1000
        Me.sldMSegOClok.Name = "sldMSegOClok"
        Me.sldMSegOClok.Size = New System.Drawing.Size(308, 54)
        Me.sldMSegOClok.TabIndex = 11
        Me.sldMSegOClok.Text = "MetroTrackBar1"
        Me.sldMSegOClok.Value = 0
        '
        'chkForceHoraExect
        '
        Me.chkForceHoraExect.AutoSize = True
        Me.chkForceHoraExect.Enabled = False
        Me.chkForceHoraExect.Location = New System.Drawing.Point(29, 161)
        Me.chkForceHoraExect.Name = "chkForceHoraExect"
        Me.chkForceHoraExect.Size = New System.Drawing.Size(306, 15)
        Me.chkForceHoraExect.TabIndex = 10
        Me.chkForceHoraExect.Text = "Forçar la recerca d'un tema per quadar la hora al final."
        Me.chkForceHoraExect.UseSelectable = True
        '
        'chkBorHistInterp
        '
        Me.chkBorHistInterp.AutoSize = True
        Me.chkBorHistInterp.Enabled = False
        Me.chkBorHistInterp.Location = New System.Drawing.Point(30, 126)
        Me.chkBorHistInterp.Name = "chkBorHistInterp"
        Me.chkBorHistInterp.Size = New System.Drawing.Size(283, 15)
        Me.chkBorHistInterp.TabIndex = 9
        Me.chkBorHistInterp.Text = "Borrar historial d' intèrprets al iniciar el programa."
        Me.chkBorHistInterp.UseSelectable = True
        '
        'lbMSegOClok
        '
        Me.lbMSegOClok.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbMSegOClok.AutoSize = True
        Me.lbMSegOClok.Location = New System.Drawing.Point(531, 72)
        Me.lbMSegOClok.Name = "lbMSegOClok"
        Me.lbMSegOClok.Size = New System.Drawing.Size(36, 17)
        Me.lbMSegOClok.TabIndex = 7
        Me.lbMSegOClok.Text = "1001"
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(27, 55)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(161, 51)
        Me.Label21.TabIndex = 5
        Me.Label21.Text = "Milisegons de retard per ajustar l'inici de la pauta a l'inici d'hora."
        '
        'grupCR
        '
        Me.grupCR.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grupCR.Controls.Add(Me.Label83)
        Me.grupCR.Controls.Add(Me.txtIntervalCR)
        Me.grupCR.Controls.Add(Me.GroupBox5)
        Me.grupCR.Controls.Add(Me.Label78)
        Me.grupCR.Controls.Add(Me.txtPasswordCR)
        Me.grupCR.Controls.Add(Me.Label77)
        Me.grupCR.Controls.Add(Me.txtUsuariCR)
        Me.grupCR.Controls.Add(Me.txtServerMailCR)
        Me.grupCR.Controls.Add(Me.Label75)
        Me.grupCR.Controls.Add(Me.txtRemitentCR)
        Me.grupCR.Controls.Add(Me.Label76)
        Me.grupCR.Controls.Add(Me.Label73)
        Me.grupCR.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupCR.Location = New System.Drawing.Point(0, 0)
        Me.grupCR.Name = "grupCR"
        Me.grupCR.Size = New System.Drawing.Size(630, 433)
        Me.grupCR.TabIndex = 24
        Me.grupCR.TabStop = False
        Me.grupCR.Text = "Control Remot (via e-mail)"
        Me.grupCR.Visible = False
        '
        'Label83
        '
        Me.Label83.Location = New System.Drawing.Point(14, 130)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(156, 19)
        Me.Label83.TabIndex = 17
        Me.Label83.Text = "Interval de refesc (seg.)"
        Me.Label83.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtIntervalCR
        '
        Me.txtIntervalCR.Enabled = False
        Me.txtIntervalCR.Location = New System.Drawing.Point(176, 127)
        Me.txtIntervalCR.Name = "txtIntervalCR"
        Me.txtIntervalCR.Size = New System.Drawing.Size(94, 25)
        Me.txtIntervalCR.TabIndex = 9
        Me.txtIntervalCR.Text = "60"
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.DataGridViewInstruccionsCR)
        Me.GroupBox5.Controls.Add(Me.ButtonDelInstruccio)
        Me.GroupBox5.Controls.Add(Me.ButtonAddInstrucioCR)
        Me.GroupBox5.Controls.Add(Me.txtCodiCR)
        Me.GroupBox5.Controls.Add(Me.ComboBoxListAplic)
        Me.GroupBox5.Controls.Add(Me.ComboBoxRemoteInstruc)
        Me.GroupBox5.Controls.Add(Me.txtDescripCR)
        Me.GroupBox5.Controls.Add(Me.Label82)
        Me.GroupBox5.Controls.Add(Me.Label81)
        Me.GroupBox5.Controls.Add(Me.Label79)
        Me.GroupBox5.Controls.Add(Me.Label80)
        Me.GroupBox5.Location = New System.Drawing.Point(8, 150)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(612, 277)
        Me.GroupBox5.TabIndex = 15
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Llistat d'instruccions:"
        '
        'DataGridViewInstruccionsCR
        '
        Me.DataGridViewInstruccionsCR.AllowUserToAddRows = False
        Me.DataGridViewInstruccionsCR.AllowUserToDeleteRows = False
        Me.DataGridViewInstruccionsCR.AllowUserToResizeRows = False
        Me.DataGridViewInstruccionsCR.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewInstruccionsCR.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridViewInstruccionsCR.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridViewInstruccionsCR.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridViewInstruccionsCR.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewInstruccionsCR.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewInstruccionsCR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewInstruccionsCR.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnCodi, Me.ColumnAppDesti, Me.ColumnInstruc, Me.ColumnDescrip})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewInstruccionsCR.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewInstruccionsCR.EnableHeadersVisualStyles = False
        Me.DataGridViewInstruccionsCR.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.DataGridViewInstruccionsCR.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridViewInstruccionsCR.Location = New System.Drawing.Point(12, 140)
        Me.DataGridViewInstruccionsCR.Name = "DataGridViewInstruccionsCR"
        Me.DataGridViewInstruccionsCR.ReadOnly = True
        Me.DataGridViewInstruccionsCR.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewInstruccionsCR.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewInstruccionsCR.RowHeadersVisible = False
        Me.DataGridViewInstruccionsCR.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridViewInstruccionsCR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewInstruccionsCR.Size = New System.Drawing.Size(588, 128)
        Me.DataGridViewInstruccionsCR.TabIndex = 1
        '
        'ColumnCodi
        '
        Me.ColumnCodi.DataPropertyName = "instruc_id"
        Me.ColumnCodi.HeaderText = "Codi"
        Me.ColumnCodi.Name = "ColumnCodi"
        Me.ColumnCodi.ReadOnly = True
        '
        'ColumnAppDesti
        '
        Me.ColumnAppDesti.DataPropertyName = "instruc_App"
        Me.ColumnAppDesti.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.ColumnAppDesti.HeaderText = "Aplic Destí"
        Me.ColumnAppDesti.Name = "ColumnAppDesti"
        Me.ColumnAppDesti.ReadOnly = True
        '
        'ColumnInstruc
        '
        Me.ColumnInstruc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnInstruc.DataPropertyName = "instruc_accio"
        Me.ColumnInstruc.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.ColumnInstruc.HeaderText = "Instrucció"
        Me.ColumnInstruc.Name = "ColumnInstruc"
        Me.ColumnInstruc.ReadOnly = True
        '
        'ColumnDescrip
        '
        Me.ColumnDescrip.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnDescrip.DataPropertyName = "instruc_Descrip"
        Me.ColumnDescrip.HeaderText = "Descripció"
        Me.ColumnDescrip.Name = "ColumnDescrip"
        Me.ColumnDescrip.ReadOnly = True
        '
        'ButtonDelInstruccio
        '
        Me.ButtonDelInstruccio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonDelInstruccio.Enabled = False
        Me.ButtonDelInstruccio.Location = New System.Drawing.Point(471, 77)
        Me.ButtonDelInstruccio.Name = "ButtonDelInstruccio"
        Me.ButtonDelInstruccio.Size = New System.Drawing.Size(129, 25)
        Me.ButtonDelInstruccio.TabIndex = 21
        Me.ButtonDelInstruccio.Text = "Borrar instrucció"
        Me.ButtonDelInstruccio.UseSelectable = True
        '
        'ButtonAddInstrucioCR
        '
        Me.ButtonAddInstrucioCR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonAddInstrucioCR.Enabled = False
        Me.ButtonAddInstrucioCR.Location = New System.Drawing.Point(471, 47)
        Me.ButtonAddInstrucioCR.Name = "ButtonAddInstrucioCR"
        Me.ButtonAddInstrucioCR.Size = New System.Drawing.Size(129, 25)
        Me.ButtonAddInstrucioCR.TabIndex = 20
        Me.ButtonAddInstrucioCR.Text = "Afegir instrucció"
        Me.ButtonAddInstrucioCR.UseSelectable = True
        '
        'txtCodiCR
        '
        Me.txtCodiCR.Enabled = False
        Me.txtCodiCR.Location = New System.Drawing.Point(130, 20)
        Me.txtCodiCR.Name = "txtCodiCR"
        Me.txtCodiCR.Size = New System.Drawing.Size(88, 25)
        Me.txtCodiCR.TabIndex = 13
        Me.txtCodiCR.Text = "0"
        '
        'ComboBoxListAplic
        '
        Me.ComboBoxListAplic.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxListAplic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxListAplic.Enabled = False
        Me.ComboBoxListAplic.FormattingEnabled = True
        Me.ComboBoxListAplic.Location = New System.Drawing.Point(130, 47)
        Me.ComboBoxListAplic.Name = "ComboBoxListAplic"
        Me.ComboBoxListAplic.Size = New System.Drawing.Size(324, 25)
        Me.ComboBoxListAplic.TabIndex = 14
        '
        'ComboBoxRemoteInstruc
        '
        Me.ComboBoxRemoteInstruc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxRemoteInstruc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxRemoteInstruc.Enabled = False
        Me.ComboBoxRemoteInstruc.FormattingEnabled = True
        Me.ComboBoxRemoteInstruc.Location = New System.Drawing.Point(130, 77)
        Me.ComboBoxRemoteInstruc.Name = "ComboBoxRemoteInstruc"
        Me.ComboBoxRemoteInstruc.Size = New System.Drawing.Size(324, 25)
        Me.ComboBoxRemoteInstruc.TabIndex = 15
        '
        'txtDescripCR
        '
        Me.txtDescripCR.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripCR.Enabled = False
        Me.txtDescripCR.Location = New System.Drawing.Point(130, 106)
        Me.txtDescripCR.Name = "txtDescripCR"
        Me.txtDescripCR.Size = New System.Drawing.Size(470, 25)
        Me.txtDescripCR.TabIndex = 16
        '
        'Label82
        '
        Me.Label82.Location = New System.Drawing.Point(11, 108)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(113, 20)
        Me.Label82.TabIndex = 19
        Me.Label82.Text = "Descripció:"
        Me.Label82.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label81
        '
        Me.Label81.Location = New System.Drawing.Point(11, 22)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(113, 20)
        Me.Label81.TabIndex = 18
        Me.Label81.Text = "Codi:"
        Me.Label81.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label79
        '
        Me.Label79.Location = New System.Drawing.Point(11, 50)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(113, 20)
        Me.Label79.TabIndex = 16
        Me.Label79.Text = "Aplicació:"
        Me.Label79.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label80
        '
        Me.Label80.Location = New System.Drawing.Point(11, 79)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(113, 20)
        Me.Label80.TabIndex = 15
        Me.Label80.Text = "Instrucció:"
        Me.Label80.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label78
        '
        Me.Label78.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label78.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label78.Location = New System.Drawing.Point(373, 19)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(250, 19)
        Me.Label78.TabIndex = 9
        Me.Label78.Text = "Per activar-lo  introduïu un correu vàlid ."
        Me.Label78.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPasswordCR
        '
        Me.txtPasswordCR.Enabled = False
        Me.txtPasswordCR.Location = New System.Drawing.Point(176, 100)
        Me.txtPasswordCR.Name = "txtPasswordCR"
        Me.txtPasswordCR.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswordCR.Size = New System.Drawing.Size(186, 25)
        Me.txtPasswordCR.TabIndex = 8
        Me.txtPasswordCR.UseSystemPasswordChar = True
        '
        'Label77
        '
        Me.Label77.Location = New System.Drawing.Point(14, 103)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(156, 19)
        Me.Label77.TabIndex = 7
        Me.Label77.Text = "Comtrasenya Mail"
        Me.Label77.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtUsuariCR
        '
        Me.txtUsuariCR.Enabled = False
        Me.txtUsuariCR.Location = New System.Drawing.Point(176, 73)
        Me.txtUsuariCR.Name = "txtUsuariCR"
        Me.txtUsuariCR.Size = New System.Drawing.Size(186, 25)
        Me.txtUsuariCR.TabIndex = 6
        '
        'txtServerMailCR
        '
        Me.txtServerMailCR.Enabled = False
        Me.txtServerMailCR.Location = New System.Drawing.Point(176, 46)
        Me.txtServerMailCR.Name = "txtServerMailCR"
        Me.txtServerMailCR.Size = New System.Drawing.Size(186, 25)
        Me.txtServerMailCR.TabIndex = 4
        '
        'Label75
        '
        Me.Label75.Location = New System.Drawing.Point(14, 49)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(156, 19)
        Me.Label75.TabIndex = 3
        Me.Label75.Text = "Servidor Mail entrant"
        Me.Label75.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtRemitentCR
        '
        Me.txtRemitentCR.Enabled = False
        Me.txtRemitentCR.Location = New System.Drawing.Point(176, 19)
        Me.txtRemitentCR.Name = "txtRemitentCR"
        Me.txtRemitentCR.Size = New System.Drawing.Size(186, 25)
        Me.txtRemitentCR.TabIndex = 1
        '
        'Label76
        '
        Me.Label76.Location = New System.Drawing.Point(14, 76)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(156, 19)
        Me.Label76.TabIndex = 5
        Me.Label76.Text = "Usuari Mail"
        Me.Label76.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label73
        '
        Me.Label73.Location = New System.Drawing.Point(14, 22)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(156, 19)
        Me.Label73.TabIndex = 0
        Me.Label73.Text = "Control del remitent"
        Me.Label73.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBoxUsuaris
        '
        Me.GroupBoxUsuaris.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxUsuaris.Controls.Add(Me.labelCtlPsw)
        Me.GroupBoxUsuaris.Controls.Add(Me.chkCtlPsw)
        Me.GroupBoxUsuaris.Controls.Add(Me.GroupBox8)
        Me.GroupBoxUsuaris.Controls.Add(Me.scrollMaxtemps)
        Me.GroupBoxUsuaris.Controls.Add(Me.txtMaxTemps)
        Me.GroupBoxUsuaris.Controls.Add(Me.Label98)
        Me.GroupBoxUsuaris.Controls.Add(Me.txtIntentsUSR)
        Me.GroupBoxUsuaris.Controls.Add(Me.Label102)
        Me.GroupBoxUsuaris.Controls.Add(Me.Label101)
        Me.GroupBoxUsuaris.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxUsuaris.Location = New System.Drawing.Point(0, 0)
        Me.GroupBoxUsuaris.Name = "GroupBoxUsuaris"
        Me.GroupBoxUsuaris.Size = New System.Drawing.Size(630, 433)
        Me.GroupBoxUsuaris.TabIndex = 23
        Me.GroupBoxUsuaris.TabStop = False
        Me.GroupBoxUsuaris.Text = "Control d'Usuaris"
        Me.GroupBoxUsuaris.Visible = False
        '
        'labelCtlPsw
        '
        Me.labelCtlPsw.AutoSize = True
        Me.labelCtlPsw.Location = New System.Drawing.Point(311, 20)
        Me.labelCtlPsw.Name = "labelCtlPsw"
        Me.labelCtlPsw.Size = New System.Drawing.Size(145, 19)
        Me.labelCtlPsw.TabIndex = 17
        Me.labelCtlPsw.Text = "control d'usuaris activat"
        Me.labelCtlPsw.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkCtlPsw
        '
        Me.chkCtlPsw.AutoSize = True
        Me.chkCtlPsw.Enabled = False
        Me.chkCtlPsw.Location = New System.Drawing.Point(228, 19)
        Me.chkCtlPsw.Name = "chkCtlPsw"
        Me.chkCtlPsw.Size = New System.Drawing.Size(80, 21)
        Me.chkCtlPsw.TabIndex = 16
        Me.chkCtlPsw.Text = "Off"
        Me.chkCtlPsw.UseSelectable = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.cmdBorrHistori)
        Me.GroupBox8.Controls.Add(Me.listURSErr)
        Me.GroupBox8.Controls.Add(Me.Label103)
        Me.GroupBox8.Location = New System.Drawing.Point(179, 149)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(438, 291)
        Me.GroupBox8.TabIndex = 15
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Intents de connexió erronis"
        '
        'cmdBorrHistori
        '
        Me.cmdBorrHistori.Enabled = False
        Me.cmdBorrHistori.Location = New System.Drawing.Point(52, 236)
        Me.cmdBorrHistori.Name = "cmdBorrHistori"
        Me.cmdBorrHistori.Size = New System.Drawing.Size(118, 33)
        Me.cmdBorrHistori.TabIndex = 18
        Me.cmdBorrHistori.Text = "Esborrar historial"
        Me.cmdBorrHistori.UseSelectable = True
        '
        'listURSErr
        '
        Me.listURSErr.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.listURSErr.FullRowSelect = True
        Me.listURSErr.HideSelection = False
        Me.listURSErr.Location = New System.Drawing.Point(52, 34)
        Me.listURSErr.Name = "listURSErr"
        Me.listURSErr.Size = New System.Drawing.Size(351, 196)
        Me.listURSErr.TabIndex = 6
        Me.listURSErr.UseCompatibleStateImageBehavior = False
        Me.listURSErr.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Alies erròni"
        Me.ColumnHeader3.Width = 132
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "PassWord erròni"
        Me.ColumnHeader4.Width = 127
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Nº intents"
        '
        'Label103
        '
        Me.Label103.ForeColor = System.Drawing.Color.Blue
        Me.Label103.Location = New System.Drawing.Point(176, 236)
        Me.Label103.Name = "Label103"
        Me.Label103.Size = New System.Drawing.Size(227, 21)
        Me.Label103.TabIndex = 4
        Me.Label103.Text = "Es conservaran els últims 30 dies."
        Me.Label103.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'scrollMaxtemps
        '
        Me.scrollMaxtemps.Enabled = False
        Me.scrollMaxtemps.Location = New System.Drawing.Point(288, 89)
        Me.scrollMaxtemps.Maximum = 360
        Me.scrollMaxtemps.Name = "scrollMaxtemps"
        Me.scrollMaxtemps.Size = New System.Drawing.Size(19, 20)
        Me.scrollMaxtemps.TabIndex = 12
        Me.scrollMaxtemps.Value = 60
        '
        'txtMaxTemps
        '
        Me.txtMaxTemps.BackColor = System.Drawing.SystemColors.Control
        Me.txtMaxTemps.Enabled = False
        Me.txtMaxTemps.Location = New System.Drawing.Point(230, 87)
        Me.txtMaxTemps.Name = "txtMaxTemps"
        Me.txtMaxTemps.ReadOnly = True
        Me.txtMaxTemps.Size = New System.Drawing.Size(55, 25)
        Me.txtMaxTemps.TabIndex = 14
        Me.txtMaxTemps.TabStop = False
        Me.txtMaxTemps.Text = "10:00:00"
        '
        'Label98
        '
        Me.Label98.Location = New System.Drawing.Point(13, 52)
        Me.Label98.Name = "Label98"
        Me.Label98.Size = New System.Drawing.Size(206, 22)
        Me.Label98.TabIndex = 9
        Me.Label98.Text = "Màxim nº d'intents erronis:"
        Me.Label98.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtIntentsUSR
        '
        Me.txtIntentsUSR.Enabled = False
        Me.txtIntentsUSR.Location = New System.Drawing.Point(229, 51)
        Me.txtIntentsUSR.Name = "txtIntentsUSR"
        Me.txtIntentsUSR.Size = New System.Drawing.Size(79, 25)
        Me.txtIntentsUSR.TabIndex = 10
        '
        'Label102
        '
        Me.Label102.ForeColor = System.Drawing.Color.Blue
        Me.Label102.Location = New System.Drawing.Point(309, 86)
        Me.Label102.Name = "Label102"
        Me.Label102.Size = New System.Drawing.Size(306, 62)
        Me.Label102.TabIndex = 11
        Me.Label102.Text = "Temps que ha de passar per autoritzar una connexió quan la última vegada que s'ha" &
    " intentat accedir va ser errònia."
        '
        'Label101
        '
        Me.Label101.Location = New System.Drawing.Point(13, 88)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(206, 22)
        Me.Label101.TabIndex = 13
        Me.Label101.Text = "Temps Bloqueig:"
        Me.Label101.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBoxCodificacio
        '
        Me.GroupBoxCodificacio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxCodificacio.Controls.Add(Me.lbCaputeTag)
        Me.GroupBoxCodificacio.Controls.Add(Me.chkCaptureTag)
        Me.GroupBoxCodificacio.Controls.Add(Me.lbFileDefActive)
        Me.GroupBoxCodificacio.Controls.Add(Me.chkVDef_activats)
        Me.GroupBoxCodificacio.Controls.Add(Me.GroupCodecAudio)
        Me.GroupBoxCodificacio.Controls.Add(Me.label120)
        Me.GroupBoxCodificacio.Controls.Add(Me.groupBox15)
        Me.GroupBoxCodificacio.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxCodificacio.Location = New System.Drawing.Point(0, 0)
        Me.GroupBoxCodificacio.Name = "GroupBoxCodificacio"
        Me.GroupBoxCodificacio.Size = New System.Drawing.Size(630, 433)
        Me.GroupBoxCodificacio.TabIndex = 23
        Me.GroupBoxCodificacio.TabStop = False
        Me.GroupBoxCodificacio.Text = "Codificació Àudio"
        Me.GroupBoxCodificacio.Visible = False
        '
        'lbCaputeTag
        '
        Me.lbCaputeTag.AutoSize = True
        Me.lbCaputeTag.BackColor = System.Drawing.Color.Transparent
        Me.lbCaputeTag.Location = New System.Drawing.Point(307, 53)
        Me.lbCaputeTag.Name = "lbCaputeTag"
        Me.lbCaputeTag.Size = New System.Drawing.Size(174, 17)
        Me.lbCaputeTag.TabIndex = 242
        Me.lbCaputeTag.Text = "Capturar informació ID3 Tag"
        '
        'chkCaptureTag
        '
        Me.chkCaptureTag.AutoSize = True
        Me.chkCaptureTag.Checked = True
        Me.chkCaptureTag.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCaptureTag.Enabled = False
        Me.chkCaptureTag.Location = New System.Drawing.Point(217, 52)
        Me.chkCaptureTag.Name = "chkCaptureTag"
        Me.chkCaptureTag.Size = New System.Drawing.Size(80, 21)
        Me.chkCaptureTag.TabIndex = 23
        Me.chkCaptureTag.Text = "On"
        Me.chkCaptureTag.UseSelectable = True
        '
        'lbFileDefActive
        '
        Me.lbFileDefActive.AutoSize = True
        Me.lbFileDefActive.BackColor = System.Drawing.Color.Transparent
        Me.lbFileDefActive.Location = New System.Drawing.Point(307, 26)
        Me.lbFileDefActive.Name = "lbFileDefActive"
        Me.lbFileDefActive.Size = New System.Drawing.Size(163, 17)
        Me.lbFileDefActive.TabIndex = 22
        Me.lbFileDefActive.Text = "Tots els fitxers per defecte"
        '
        'chkVDef_activats
        '
        Me.chkVDef_activats.AutoSize = True
        Me.chkVDef_activats.Enabled = False
        Me.chkVDef_activats.Location = New System.Drawing.Point(217, 24)
        Me.chkVDef_activats.Name = "chkVDef_activats"
        Me.chkVDef_activats.Size = New System.Drawing.Size(80, 21)
        Me.chkVDef_activats.TabIndex = 21
        Me.chkVDef_activats.Text = "Off"
        Me.chkVDef_activats.UseSelectable = True
        '
        'GroupCodecAudio
        '
        Me.GroupCodecAudio.Controls.Add(Me.lbLameVer)
        Me.GroupCodecAudio.Controls.Add(Me.pictureBox2)
        Me.GroupCodecAudio.Controls.Add(Me.chkPrivate)
        Me.GroupCodecAudio.Controls.Add(Me.chkOriginal)
        Me.GroupCodecAudio.Controls.Add(Me.chkCRC)
        Me.GroupCodecAudio.Controls.Add(Me.chkCopyright)
        Me.GroupCodecAudio.Controls.Add(Me.label121)
        Me.GroupCodecAudio.Controls.Add(Me.label122)
        Me.GroupCodecAudio.Controls.Add(Me.label123)
        Me.GroupCodecAudio.Controls.Add(Me.cmbCodecAudioChannel)
        Me.GroupCodecAudio.Controls.Add(Me.cmbCodecSampleRate)
        Me.GroupCodecAudio.Controls.Add(Me.cmbCodecBitrate)
        Me.GroupCodecAudio.Enabled = False
        Me.GroupCodecAudio.Location = New System.Drawing.Point(86, 98)
        Me.GroupCodecAudio.Name = "GroupCodecAudio"
        Me.GroupCodecAudio.Size = New System.Drawing.Size(472, 112)
        Me.GroupCodecAudio.TabIndex = 20
        Me.GroupCodecAudio.TabStop = False
        Me.GroupCodecAudio.Text = "Codificar a MP3"
        '
        'lbLameVer
        '
        Me.lbLameVer.AutoSize = True
        Me.lbLameVer.Location = New System.Drawing.Point(41, 169)
        Me.lbLameVer.Name = "lbLameVer"
        Me.lbLameVer.Size = New System.Drawing.Size(69, 17)
        Me.lbLameVer.TabIndex = 36
        Me.lbLameVer.Text = "Versió: 2.3"
        Me.lbLameVer.Visible = False
        '
        'pictureBox2
        '
        Me.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureBox2.Location = New System.Drawing.Point(388, 20)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(77, 69)
        Me.pictureBox2.TabIndex = 35
        Me.pictureBox2.TabStop = False
        '
        'chkPrivate
        '
        Me.chkPrivate.AutoSize = True
        Me.chkPrivate.Location = New System.Drawing.Point(217, 148)
        Me.chkPrivate.Name = "chkPrivate"
        Me.chkPrivate.Size = New System.Drawing.Size(59, 21)
        Me.chkPrivate.TabIndex = 34
        Me.chkPrivate.Text = "Privat"
        Me.chkPrivate.UseVisualStyleBackColor = True
        Me.chkPrivate.Visible = False
        '
        'chkOriginal
        '
        Me.chkOriginal.AutoSize = True
        Me.chkOriginal.Location = New System.Drawing.Point(217, 119)
        Me.chkOriginal.Name = "chkOriginal"
        Me.chkOriginal.Size = New System.Drawing.Size(73, 21)
        Me.chkOriginal.TabIndex = 33
        Me.chkOriginal.Text = "Original"
        Me.chkOriginal.UseVisualStyleBackColor = True
        Me.chkOriginal.Visible = False
        '
        'chkCRC
        '
        Me.chkCRC.AutoSize = True
        Me.chkCRC.Location = New System.Drawing.Point(135, 148)
        Me.chkCRC.Name = "chkCRC"
        Me.chkCRC.Size = New System.Drawing.Size(51, 21)
        Me.chkCRC.TabIndex = 32
        Me.chkCRC.Text = "CRC"
        Me.chkCRC.UseVisualStyleBackColor = True
        Me.chkCRC.Visible = False
        '
        'chkCopyright
        '
        Me.chkCopyright.AutoSize = True
        Me.chkCopyright.Location = New System.Drawing.Point(135, 119)
        Me.chkCopyright.Name = "chkCopyright"
        Me.chkCopyright.Size = New System.Drawing.Size(84, 21)
        Me.chkCopyright.TabIndex = 31
        Me.chkCopyright.Text = "Copyright"
        Me.chkCopyright.UseVisualStyleBackColor = True
        Me.chkCopyright.Visible = False
        '
        'label121
        '
        Me.label121.Location = New System.Drawing.Point(6, 79)
        Me.label121.Name = "label121"
        Me.label121.Size = New System.Drawing.Size(122, 21)
        Me.label121.TabIndex = 30
        Me.label121.Text = "Canals d'audio"
        Me.label121.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'label122
        '
        Me.label122.Location = New System.Drawing.Point(6, 51)
        Me.label122.Name = "label122"
        Me.label122.Size = New System.Drawing.Size(122, 21)
        Me.label122.TabIndex = 29
        Me.label122.Text = "Freqüència (Hz)"
        Me.label122.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'label123
        '
        Me.label123.Location = New System.Drawing.Point(6, 23)
        Me.label123.Name = "label123"
        Me.label123.Size = New System.Drawing.Size(122, 21)
        Me.label123.TabIndex = 28
        Me.label123.Text = "Bitrate (Kbps)"
        Me.label123.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmbCodecAudioChannel
        '
        Me.cmbCodecAudioChannel.FormattingEnabled = True
        Me.cmbCodecAudioChannel.Items.AddRange(New Object() {"STEREO", "JOINT-STEREO", "STEREO FORCED", "MONO"})
        Me.cmbCodecAudioChannel.Location = New System.Drawing.Point(133, 77)
        Me.cmbCodecAudioChannel.Name = "cmbCodecAudioChannel"
        Me.cmbCodecAudioChannel.Size = New System.Drawing.Size(143, 25)
        Me.cmbCodecAudioChannel.TabIndex = 27
        '
        'cmbCodecSampleRate
        '
        Me.cmbCodecSampleRate.FormattingEnabled = True
        Me.cmbCodecSampleRate.Items.AddRange(New Object() {"22050", "32000", "44100", "48000"})
        Me.cmbCodecSampleRate.Location = New System.Drawing.Point(133, 49)
        Me.cmbCodecSampleRate.Name = "cmbCodecSampleRate"
        Me.cmbCodecSampleRate.Size = New System.Drawing.Size(143, 25)
        Me.cmbCodecSampleRate.TabIndex = 26
        '
        'cmbCodecBitrate
        '
        Me.cmbCodecBitrate.FormattingEnabled = True
        Me.cmbCodecBitrate.Items.AddRange(New Object() {"32", "56", "80", "128", "192", "224", "256", "320"})
        Me.cmbCodecBitrate.Location = New System.Drawing.Point(133, 21)
        Me.cmbCodecBitrate.Name = "cmbCodecBitrate"
        Me.cmbCodecBitrate.Size = New System.Drawing.Size(143, 25)
        Me.cmbCodecBitrate.TabIndex = 25
        '
        'label120
        '
        Me.label120.ForeColor = System.Drawing.Color.Blue
        Me.label120.Location = New System.Drawing.Point(111, 79)
        Me.label120.Name = "label120"
        Me.label120.Size = New System.Drawing.Size(427, 20)
        Me.label120.TabIndex = 19
        Me.label120.Text = "Al importar fitxers es codificaran amb la qualitat aquí definida"
        '
        'groupBox15
        '
        Me.groupBox15.Controls.Add(Me.chkRecord)
        Me.groupBox15.Controls.Add(Me.Label104)
        Me.groupBox15.Controls.Add(Me.fraConf)
        Me.groupBox15.Location = New System.Drawing.Point(85, 217)
        Me.groupBox15.Name = "groupBox15"
        Me.groupBox15.Size = New System.Drawing.Size(474, 217)
        Me.groupBox15.TabIndex = 18
        Me.groupBox15.TabStop = False
        Me.groupBox15.Text = "Còpia Testimòni (MSC Logger)"
        '
        'chkRecord
        '
        Me.chkRecord.AutoSize = True
        Me.chkRecord.Enabled = False
        Me.chkRecord.Location = New System.Drawing.Point(134, 87)
        Me.chkRecord.Name = "chkRecord"
        Me.chkRecord.Size = New System.Drawing.Size(141, 15)
        Me.chkRecord.TabIndex = 18
        Me.chkRecord.Text = "Enregistrar per defecte"
        Me.chkRecord.UseSelectable = True
        '
        'Label104
        '
        Me.Label104.ForeColor = System.Drawing.Color.Blue
        Me.Label104.Location = New System.Drawing.Point(23, 24)
        Me.Label104.Name = "Label104"
        Me.Label104.Size = New System.Drawing.Size(427, 52)
        Me.Label104.TabIndex = 17
        Me.Label104.Text = "A les hores on no hi cap enregistrament assignat (apartat Programació Logger) es " &
    "procedirà segons les especificacions aquí configurades."
        '
        'fraConf
        '
        Me.fraConf.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.fraConf.Controls.Add(Me.ComboBoxDuradaDef)
        Me.fraConf.Controls.Add(Me.Label105)
        Me.fraConf.Controls.Add(Me.Label106)
        Me.fraConf.Controls.Add(Me.Label107)
        Me.fraConf.Controls.Add(Me.Label108)
        Me.fraConf.Controls.Add(Me.cmbAudioChannel)
        Me.fraConf.Controls.Add(Me.cmbSampleRate)
        Me.fraConf.Controls.Add(Me.cmbBitrate)
        Me.fraConf.Enabled = False
        Me.fraConf.Location = New System.Drawing.Point(20, 111)
        Me.fraConf.Name = "fraConf"
        Me.fraConf.Size = New System.Drawing.Size(439, 90)
        Me.fraConf.TabIndex = 15
        Me.fraConf.TabStop = False
        Me.fraConf.Text = "Valors per defecte"
        '
        'ComboBoxDuradaDef
        '
        Me.ComboBoxDuradaDef.Enabled = False
        Me.ComboBoxDuradaDef.FormattingEnabled = True
        Me.ComboBoxDuradaDef.Items.AddRange(New Object() {"00:30:00", "01:00:00"})
        Me.ComboBoxDuradaDef.Location = New System.Drawing.Point(330, 56)
        Me.ComboBoxDuradaDef.Name = "ComboBoxDuradaDef"
        Me.ComboBoxDuradaDef.Size = New System.Drawing.Size(100, 25)
        Me.ComboBoxDuradaDef.TabIndex = 15
        '
        'Label105
        '
        Me.Label105.Location = New System.Drawing.Point(229, 59)
        Me.Label105.Name = "Label105"
        Me.Label105.Size = New System.Drawing.Size(95, 21)
        Me.Label105.TabIndex = 25
        Me.Label105.Text = "Durada"
        Me.Label105.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label106
        '
        Me.Label106.Location = New System.Drawing.Point(7, 59)
        Me.Label106.Name = "Label106"
        Me.Label106.Size = New System.Drawing.Size(100, 21)
        Me.Label106.TabIndex = 24
        Me.Label106.Text = "Canals d'audio"
        Me.Label106.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label107
        '
        Me.Label107.Location = New System.Drawing.Point(219, 23)
        Me.Label107.Name = "Label107"
        Me.Label107.Size = New System.Drawing.Size(105, 21)
        Me.Label107.TabIndex = 23
        Me.Label107.Text = "Freqüència (Hz)"
        Me.Label107.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label108
        '
        Me.Label108.Location = New System.Drawing.Point(7, 23)
        Me.Label108.Name = "Label108"
        Me.Label108.Size = New System.Drawing.Size(100, 21)
        Me.Label108.TabIndex = 22
        Me.Label108.Text = "Bitrate (Kbps)"
        Me.Label108.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmbAudioChannel
        '
        Me.cmbAudioChannel.Enabled = False
        Me.cmbAudioChannel.FormattingEnabled = True
        Me.cmbAudioChannel.Items.AddRange(New Object() {"MONO", "STEREO"})
        Me.cmbAudioChannel.Location = New System.Drawing.Point(114, 55)
        Me.cmbAudioChannel.Name = "cmbAudioChannel"
        Me.cmbAudioChannel.Size = New System.Drawing.Size(100, 25)
        Me.cmbAudioChannel.TabIndex = 13
        '
        'cmbSampleRate
        '
        Me.cmbSampleRate.Enabled = False
        Me.cmbSampleRate.FormattingEnabled = True
        Me.cmbSampleRate.Items.AddRange(New Object() {"22050", "32000", "44100", "48000"})
        Me.cmbSampleRate.Location = New System.Drawing.Point(330, 19)
        Me.cmbSampleRate.Name = "cmbSampleRate"
        Me.cmbSampleRate.Size = New System.Drawing.Size(100, 25)
        Me.cmbSampleRate.TabIndex = 12
        '
        'cmbBitrate
        '
        Me.cmbBitrate.Enabled = False
        Me.cmbBitrate.FormattingEnabled = True
        Me.cmbBitrate.Items.AddRange(New Object() {"32", "56", "80", "128", "192", "224", "256", "320"})
        Me.cmbBitrate.Location = New System.Drawing.Point(114, 19)
        Me.cmbBitrate.Name = "cmbBitrate"
        Me.cmbBitrate.Size = New System.Drawing.Size(100, 25)
        Me.cmbBitrate.TabIndex = 11
        '
        'grupAudioUSR
        '
        Me.grupAudioUSR.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grupAudioUSR.Controls.Add(Me.GroupBoxCarpetes)
        Me.grupAudioUSR.Controls.Add(Me.gridAudioFiles)
        Me.grupAudioUSR.Controls.Add(Me.cmdDelAudio)
        Me.grupAudioUSR.Controls.Add(Me.cmdAddAudio)
        Me.grupAudioUSR.Controls.Add(Me.Label11)
        Me.grupAudioUSR.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupAudioUSR.Location = New System.Drawing.Point(0, 0)
        Me.grupAudioUSR.Name = "grupAudioUSR"
        Me.grupAudioUSR.Size = New System.Drawing.Size(630, 433)
        Me.grupAudioUSR.TabIndex = 8
        Me.grupAudioUSR.TabStop = False
        Me.grupAudioUSR.Text = "Fitxers d'àudio"
        Me.grupAudioUSR.Visible = False
        '
        'GroupBoxCarpetes
        '
        Me.GroupBoxCarpetes.Controls.Add(Me.FlowLayoutPanelCarpetes)
        Me.GroupBoxCarpetes.Controls.Add(Me.ButtonAddCarpeta)
        Me.GroupBoxCarpetes.Location = New System.Drawing.Point(39, 33)
        Me.GroupBoxCarpetes.Name = "GroupBoxCarpetes"
        Me.GroupBoxCarpetes.Size = New System.Drawing.Size(547, 133)
        Me.GroupBoxCarpetes.TabIndex = 8
        Me.GroupBoxCarpetes.TabStop = False
        Me.GroupBoxCarpetes.Text = "Carpetes"
        '
        'FlowLayoutPanelCarpetes
        '
        Me.FlowLayoutPanelCarpetes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanelCarpetes.Enabled = False
        Me.FlowLayoutPanelCarpetes.Location = New System.Drawing.Point(107, 28)
        Me.FlowLayoutPanelCarpetes.Name = "FlowLayoutPanelCarpetes"
        Me.FlowLayoutPanelCarpetes.Size = New System.Drawing.Size(413, 81)
        Me.FlowLayoutPanelCarpetes.TabIndex = 2
        '
        'ButtonAddCarpeta
        '
        Me.ButtonAddCarpeta.Enabled = False
        Me.ButtonAddCarpeta.Location = New System.Drawing.Point(12, 28)
        Me.ButtonAddCarpeta.Name = "ButtonAddCarpeta"
        Me.ButtonAddCarpeta.Size = New System.Drawing.Size(71, 28)
        Me.ButtonAddCarpeta.TabIndex = 3
        Me.ButtonAddCarpeta.Text = "Afegir.."
        Me.ButtonAddCarpeta.UseVisualStyleBackColor = True
        '
        'gridAudioFiles
        '
        Me.gridAudioFiles.AllowUserToAddRows = False
        Me.gridAudioFiles.AllowUserToDeleteRows = False
        Me.gridAudioFiles.AllowUserToResizeRows = False
        Me.gridAudioFiles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridAudioFiles.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gridAudioFiles.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gridAudioFiles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.gridAudioFiles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridAudioFiles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.gridAudioFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridAudioFiles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnImageid, Me.ColumnImage, Me.Column_id, Me.Column_nom, Me.Column_visible_cart, Me.ColumnVisible_cont, Me.ColumnCarp, Me.ColumnEnding, Me.Columnph})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridAudioFiles.DefaultCellStyle = DataGridViewCellStyle11
        Me.gridAudioFiles.Enabled = False
        Me.gridAudioFiles.EnableHeadersVisualStyles = False
        Me.gridAudioFiles.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.gridAudioFiles.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gridAudioFiles.Location = New System.Drawing.Point(39, 204)
        Me.gridAudioFiles.Name = "gridAudioFiles"
        Me.gridAudioFiles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridAudioFiles.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.gridAudioFiles.RowHeadersVisible = False
        Me.gridAudioFiles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.gridAudioFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridAudioFiles.Size = New System.Drawing.Size(532, 186)
        Me.gridAudioFiles.TabIndex = 7
        '
        'ColumnImageid
        '
        Me.ColumnImageid.DataPropertyName = "audio_image"
        Me.ColumnImageid.HeaderText = ""
        Me.ColumnImageid.Name = "ColumnImageid"
        Me.ColumnImageid.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColumnImageid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColumnImageid.Visible = False
        Me.ColumnImageid.Width = 20
        '
        'ColumnImage
        '
        Me.ColumnImage.DataPropertyName = "audio_img"
        Me.ColumnImage.HeaderText = ""
        Me.ColumnImage.Name = "ColumnImage"
        Me.ColumnImage.Width = 30
        '
        'Column_id
        '
        Me.Column_id.DataPropertyName = "audio_id"
        Me.Column_id.HeaderText = "ID"
        Me.Column_id.Name = "Column_id"
        Me.Column_id.ReadOnly = True
        Me.Column_id.Width = 20
        '
        'Column_nom
        '
        Me.Column_nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column_nom.DataPropertyName = "audio_nom"
        Me.Column_nom.HeaderText = "Nom"
        Me.Column_nom.Name = "Column_nom"
        '
        'Column_visible_cart
        '
        Me.Column_visible_cart.DataPropertyName = "audio_visible_cart"
        Me.Column_visible_cart.HeaderText = "Cart"
        Me.Column_visible_cart.Name = "Column_visible_cart"
        Me.Column_visible_cart.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column_visible_cart.Width = 60
        '
        'ColumnVisible_cont
        '
        Me.ColumnVisible_cont.DataPropertyName = "audio_visible_cont"
        Me.ColumnVisible_cont.HeaderText = "Cont"
        Me.ColumnVisible_cont.Name = "ColumnVisible_cont"
        Me.ColumnVisible_cont.Width = 60
        '
        'ColumnCarp
        '
        Me.ColumnCarp.DataPropertyName = "audio_carpeta"
        Me.ColumnCarp.HeaderText = "Carpeta"
        Me.ColumnCarp.Name = "ColumnCarp"
        '
        'ColumnEnding
        '
        Me.ColumnEnding.DataPropertyName = "audio_is_ending"
        Me.ColumnEnding.HeaderText = "Ending"
        Me.ColumnEnding.Name = "ColumnEnding"
        Me.ColumnEnding.Width = 60
        '
        'Columnph
        '
        Me.Columnph.DataPropertyName = "audio_is_ph"
        Me.Columnph.HeaderText = "Hour"
        Me.Columnph.Name = "Columnph"
        Me.Columnph.Width = 40
        '
        'cmdDelAudio
        '
        Me.cmdDelAudio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdDelAudio.Enabled = False
        Me.cmdDelAudio.Location = New System.Drawing.Point(377, 398)
        Me.cmdDelAudio.Name = "cmdDelAudio"
        Me.cmdDelAudio.Size = New System.Drawing.Size(164, 26)
        Me.cmdDelAudio.TabIndex = 6
        Me.cmdDelAudio.Text = "Esborrar"
        Me.cmdDelAudio.UseSelectable = True
        '
        'cmdAddAudio
        '
        Me.cmdAddAudio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdAddAudio.Enabled = False
        Me.cmdAddAudio.Location = New System.Drawing.Point(96, 398)
        Me.cmdAddAudio.Name = "cmdAddAudio"
        Me.cmdAddAudio.Size = New System.Drawing.Size(164, 26)
        Me.cmdAddAudio.TabIndex = 5
        Me.cmdAddAudio.Text = "Nou"
        Me.cmdAddAudio.UseSelectable = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(36, 181)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(143, 17)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Llista de fitxers d'àudio"
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.BackColor = System.Drawing.Color.Transparent
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Image = CType(resources.GetObject("cmdExit.Image"), System.Drawing.Image)
        Me.cmdExit.Location = New System.Drawing.Point(946, 78)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(28, 23)
        Me.cmdExit.TabIndex = 5
        Me.cmdExit.UseMnemonic = False
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramaToolStripMenuItem, Me.AjudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(820, 30)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(161, 24)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProgramaToolStripMenuItem
        '
        Me.ProgramaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExit})
        Me.ProgramaToolStripMenuItem.Image = CType(resources.GetObject("ProgramaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ProgramaToolStripMenuItem.Name = "ProgramaToolStripMenuItem"
        Me.ProgramaToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.ProgramaToolStripMenuItem.Text = "Programa"
        '
        'mnuExit
        '
        Me.mnuExit.Image = CType(resources.GetObject("mnuExit.Image"), System.Drawing.Image)
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(102, 22)
        Me.mnuExit.Text = "Sortir"
        '
        'AjudaToolStripMenuItem
        '
        Me.AjudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelp, Me.mnuInternet, Me.mnuAbout})
        Me.AjudaToolStripMenuItem.Image = CType(resources.GetObject("AjudaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AjudaToolStripMenuItem.Name = "AjudaToolStripMenuItem"
        Me.AjudaToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.AjudaToolStripMenuItem.Text = "Ajuda"
        '
        'mnuHelp
        '
        Me.mnuHelp.Image = CType(resources.GetObject("mnuHelp.Image"), System.Drawing.Image)
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.mnuHelp.Size = New System.Drawing.Size(174, 22)
        Me.mnuHelp.Text = "Manual OnLine"
        '
        'mnuInternet
        '
        Me.mnuInternet.Image = CType(resources.GetObject("mnuInternet.Image"), System.Drawing.Image)
        Me.mnuInternet.Name = "mnuInternet"
        Me.mnuInternet.Size = New System.Drawing.Size(174, 22)
        Me.mnuInternet.Text = "MSC a Internet"
        '
        'mnuAbout
        '
        Me.mnuAbout.Image = CType(resources.GetObject("mnuAbout.Image"), System.Drawing.Image)
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(174, 22)
        Me.mnuAbout.Text = "Sobre MSC"
        '
        'picLock
        '
        Me.picLock.Image = CType(resources.GetObject("picLock.Image"), System.Drawing.Image)
        Me.picLock.Location = New System.Drawing.Point(470, 20)
        Me.picLock.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picLock.Name = "picLock"
        Me.picLock.Size = New System.Drawing.Size(52, 38)
        Me.picLock.TabIndex = 236
        Me.picLock.TabStop = False
        Me.picLock.Visible = False
        '
        'picUnLock
        '
        Me.picUnLock.Image = CType(resources.GetObject("picUnLock.Image"), System.Drawing.Image)
        Me.picUnLock.Location = New System.Drawing.Point(412, 20)
        Me.picUnLock.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picUnLock.Name = "picUnLock"
        Me.picUnLock.Size = New System.Drawing.Size(52, 38)
        Me.picUnLock.TabIndex = 237
        Me.picUnLock.TabStop = False
        Me.picUnLock.Visible = False
        '
        'cmdSortir
        '
        Me.cmdSortir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSortir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdSortir.Image = CType(resources.GetObject("cmdSortir.Image"), System.Drawing.Image)
        Me.cmdSortir.ImageSize = 32
        Me.cmdSortir.Location = New System.Drawing.Point(941, 68)
        Me.cmdSortir.Name = "cmdSortir"
        Me.cmdSortir.Size = New System.Drawing.Size(40, 42)
        Me.cmdSortir.TabIndex = 238
        Me.cmdSortir.UseSelectable = True
        '
        'cmdSalvar
        '
        Me.cmdSalvar.ActiveControl = Nothing
        Me.cmdSalvar.Enabled = False
        Me.cmdSalvar.Location = New System.Drawing.Point(344, 68)
        Me.cmdSalvar.Name = "cmdSalvar"
        Me.cmdSalvar.Size = New System.Drawing.Size(317, 43)
        Me.cmdSalvar.TabIndex = 205
        Me.cmdSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdSalvar.TileImage = CType(resources.GetObject("cmdSalvar.TileImage"), System.Drawing.Image)
        Me.cmdSalvar.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdSalvar.UseSelectable = True
        Me.cmdSalvar.UseTileImage = True
        '
        'CmdBloqueix
        '
        Me.CmdBloqueix.Image = CType(resources.GetObject("CmdBloqueix.Image"), System.Drawing.Image)
        Me.CmdBloqueix.ImageSize = 32
        Me.CmdBloqueix.Location = New System.Drawing.Point(294, 72)
        Me.CmdBloqueix.Name = "CmdBloqueix"
        Me.CmdBloqueix.Size = New System.Drawing.Size(35, 35)
        Me.CmdBloqueix.TabIndex = 239
        Me.CmdBloqueix.UseSelectable = True
        '
        'lbAtencio
        '
        Me.lbAtencio.Image = CType(resources.GetObject("lbAtencio.Image"), System.Drawing.Image)
        Me.lbAtencio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbAtencio.ImageSize = 30
        Me.lbAtencio.Location = New System.Drawing.Point(25, 70)
        Me.lbAtencio.Name = "lbAtencio"
        Me.lbAtencio.Size = New System.Drawing.Size(254, 38)
        Me.lbAtencio.TabIndex = 240
        Me.lbAtencio.Text = "Atenció"
        Me.lbAtencio.UseSelectable = True
        Me.lbAtencio.Visible = False
        '
        'lbSaved
        '
        Me.lbSaved.Image = CType(resources.GetObject("lbSaved.Image"), System.Drawing.Image)
        Me.lbSaved.ImageSize = 32
        Me.lbSaved.Location = New System.Drawing.Point(684, 72)
        Me.lbSaved.Name = "lbSaved"
        Me.lbSaved.Size = New System.Drawing.Size(35, 35)
        Me.lbSaved.TabIndex = 241
        Me.lbSaved.UseSelectable = True
        Me.lbSaved.Visible = False
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
        'frmParams
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(1022, 568)
        Me.Controls.Add(Me.pic_logo)
        Me.Controls.Add(Me.lbSaved)
        Me.Controls.Add(Me.lbAtencio)
        Me.Controls.Add(Me.cmdSalvar)
        Me.Controls.Add(Me.CmdBloqueix)
        Me.Controls.Add(Me.cmdSortir)
        Me.Controls.Add(Me.picLock)
        Me.Controls.Add(Me.picUnLock)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(800, 568)
        Me.Name = "frmParams"
        Me.Text = "Paràmetres del sistema"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupCredits.ResumeLayout(False)
        Me.MetroPanel3.ResumeLayout(False)
        Me.groupBox14.ResumeLayout(False)
        Me.groupBox14.PerformLayout()
        Me.GroupBox21.ResumeLayout(False)
        Me.GroupBox21.PerformLayout()
        Me.groupBox20.ResumeLayout(False)
        Me.groupBox20.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.groupBoxCloudPrograms.ResumeLayout(False)
        Me.MetroTabControl1.ResumeLayout(False)
        Me.tabPagePrgCloudPropis.ResumeLayout(False)
        Me.tabPagePrgCloudPropis.PerformLayout()
        CType(Me.dataGridViewProgramsShared, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_cloudUp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPagePrgShareCloud.ResumeLayout(False)
        Me.tabPagePrgShareCloud.PerformLayout()
        CType(Me.dataGridViewProgramsCloud, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_cloudDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupSequencies.ResumeLayout(False)
        Me.grupSequencies.PerformLayout()
        CType(Me.DataGridViewValorsSequ, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBoxStreaming.ResumeLayout(False)
        Me.groupBoxStreaming.PerformLayout()
        Me.groupBoxParamsServer.ResumeLayout(False)
        Me.groupBoxParamsServer.PerformLayout()
        Me.groupBoxQualityServer.ResumeLayout(False)
        Me.GroupInfoSistema.ResumeLayout(False)
        Me.GroupInfoSistema.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.grupWeb.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox13.ResumeLayout(False)
        Me.PanelFTP.ResumeLayout(False)
        Me.PanelFTP.PerformLayout()
        Me.grupConnRemot.ResumeLayout(False)
        Me.grupConnRemot.PerformLayout()
        Me.grupControler.ResumeLayout(False)
        Me.grupControler.PerformLayout()
        Me.grupPath.ResumeLayout(False)
        Me.grupPath.PerformLayout()
        CType(Me.picKO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOK, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupReparar.ResumeLayout(False)
        Me.groupBox17.ResumeLayout(False)
        Me.groupBox17.PerformLayout()
        Me.groupBox16.ResumeLayout(False)
        Me.groupBox16.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.GroupClients.ResumeLayout(False)
        Me.GroupClients.PerformLayout()
        Me.groupBoxCloudShareOptions.ResumeLayout(False)
        Me.groupBoxCloudShareOptions.PerformLayout()
        Me.grupParams.ResumeLayout(False)
        Me.grupParams.PerformLayout()
        Me.MetroPanel1.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupCarp.ResumeLayout(False)
        Me.grupCarp.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grupMoneda.ResumeLayout(False)
        Me.grupMoneda.PerformLayout()
        Me.grupCartut.ResumeLayout(False)
        Me.grupCartut.PerformLayout()
        Me.grupCategories.ResumeLayout(False)
        Me.MetroPanel2.ResumeLayout(False)
        Me.MetroPanel2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grupSOS.ResumeLayout(False)
        Me.grupSOS.PerformLayout()
        Me.grupActiveSos.ResumeLayout(False)
        Me.grupActiveSos.PerformLayout()
        Me.grupDBS.ResumeLayout(False)
        Me.grupDBS.PerformLayout()
        Me.GroupBoxDetallDBS.ResumeLayout(False)
        Me.GroupBoxDetallDBS.PerformLayout()
        Me.grupDirecte.ResumeLayout(False)
        Me.grupDirecte.PerformLayout()
        Me.grupCR.ResumeLayout(False)
        Me.grupCR.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.DataGridViewInstruccionsCR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxUsuaris.ResumeLayout(False)
        Me.GroupBoxUsuaris.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBoxCodificacio.ResumeLayout(False)
        Me.GroupBoxCodificacio.PerformLayout()
        Me.GroupCodecAudio.ResumeLayout(False)
        Me.GroupCodecAudio.PerformLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox15.ResumeLayout(False)
        Me.groupBox15.PerformLayout()
        Me.fraConf.ResumeLayout(False)
        Me.grupAudioUSR.ResumeLayout(False)
        Me.grupAudioUSR.PerformLayout()
        Me.GroupBoxCarpetes.ResumeLayout(False)
        CType(Me.gridAudioFiles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picLock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUnLock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private lbTestsHHit As System.Windows.Forms.Label
    Private lbTestHHitTop As System.Windows.Forms.Label
    Private lbTestHOldTop As System.Windows.Forms.Label
    Private lbTestHOld As System.Windows.Forms.Label
    Private lbTestHTop As System.Windows.Forms.Label
    Private lbTestHBorrInterp As System.Windows.Forms.Label
    Friend WithEvents linkLabelJamendo As System.Windows.Forms.LinkLabel
    Friend label145 As System.Windows.Forms.Label
    Private groupBox20 As System.Windows.Forms.GroupBox
    Friend label140 As System.Windows.Forms.Label
    Friend groupBox17 As System.Windows.Forms.GroupBox
    Private groupBoxCloudShareOptions As System.Windows.Forms.GroupBox
    Private pic_cloudUp As System.Windows.Forms.PictureBox
    Private pic_cloudDown As System.Windows.Forms.PictureBox
    Private label139 As System.Windows.Forms.Label
    Private label54 As System.Windows.Forms.Label
    Private label136 As System.Windows.Forms.Label
    Private cmbProgramesPropis As System.Windows.Forms.ComboBox
    Friend groupBoxCloudPrograms As System.Windows.Forms.GroupBox
    Public WithEvents txtClientKey As System.Windows.Forms.TextBox
    Private lbCientID As System.Windows.Forms.Label
    Private label134 As System.Windows.Forms.Label
    Friend label127 As System.Windows.Forms.Label
    Friend label126 As System.Windows.Forms.Label
    Friend label28 As System.Windows.Forms.Label
    Private groupBoxQualityServer As System.Windows.Forms.GroupBox
    Private label133 As System.Windows.Forms.Label
    Private WithEvents txtServer As System.Windows.Forms.TextBox
    Private label132 As System.Windows.Forms.Label
    Private WithEvents txtPort As System.Windows.Forms.TextBox
    Private label131 As System.Windows.Forms.Label
    Private WithEvents comboBoxServerStream As System.Windows.Forms.ComboBox
    Private WithEvents txtMountpoint As System.Windows.Forms.TextBox
    Private label130 As System.Windows.Forms.Label
    Private label129 As System.Windows.Forms.Label
    Private WithEvents txtPassword As System.Windows.Forms.TextBox
    Private WithEvents txtEstil As System.Windows.Forms.TextBox
    Private label128 As System.Windows.Forms.Label
    Private groupBoxParamsServer As System.Windows.Forms.GroupBox
    Private groupBoxStreaming As System.Windows.Forms.GroupBox
    Private WithEvents cmbLang As System.Windows.Forms.ComboBox
    Private label125 As System.Windows.Forms.Label
    Friend label124 As System.Windows.Forms.Label
    Private lbLastBKP As System.Windows.Forms.Label
    Private groupBox16 As System.Windows.Forms.GroupBox
    Friend GroupCodecAudio As System.Windows.Forms.GroupBox
    Friend WithEvents cmbCodecAudioChannel As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCodecSampleRate As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCodecBitrate As System.Windows.Forms.ComboBox
    Friend GroupBoxCodificacio As System.Windows.Forms.GroupBox
    Friend label123 As System.Windows.Forms.Label
    Friend label122 As System.Windows.Forms.Label
    Friend label121 As System.Windows.Forms.Label
    Friend chkCopyright As System.Windows.Forms.CheckBox
    Friend chkCRC As System.Windows.Forms.CheckBox
    Friend chkOriginal As System.Windows.Forms.CheckBox
    Friend chkPrivate As System.Windows.Forms.CheckBox
    Friend pictureBox2 As System.Windows.Forms.PictureBox
    Friend lbLameVer As System.Windows.Forms.Label
    Friend label120 As System.Windows.Forms.Label
    Private groupBox15 As System.Windows.Forms.GroupBox
    Private label116 As System.Windows.Forms.Label
    Friend label115 As System.Windows.Forms.Label
    Friend WithEvents txtMinusProhivDisc As System.Windows.Forms.TextBox
    Friend label114 As System.Windows.Forms.Label
    Friend WithEvents txtPermanenciaPodcast As System.Windows.Forms.TextBox
    Friend label113 As System.Windows.Forms.Label
    Friend label112 As System.Windows.Forms.Label
    Friend WithEvents txtTwitterKey As System.Windows.Forms.TextBox
    Private label111 As System.Windows.Forms.Label
    Private label53 As System.Windows.Forms.Label
    Private label51 As System.Windows.Forms.Label
    Private label91 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TreeViewParams As System.Windows.Forms.TreeView
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents grupPath As System.Windows.Forms.GroupBox
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents grupCategories As System.Windows.Forms.GroupBox
    Friend WithEvents grupMoneda As System.Windows.Forms.GroupBox
    Friend WithEvents grupConnRemot As System.Windows.Forms.GroupBox
    Friend WithEvents grupControler As System.Windows.Forms.GroupBox
    Friend WithEvents grupDirecte As System.Windows.Forms.GroupBox
    Friend WithEvents grupCartut As System.Windows.Forms.GroupBox
    Friend WithEvents grupDBS As System.Windows.Forms.GroupBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ProgramaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AjudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuInternet As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbNomRadio As System.Windows.Forms.Label
    Friend WithEvents cmdAddLogo As System.Windows.Forms.Button
    Friend WithEvents imgLogo As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNomRadio As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lstDBS As System.Windows.Forms.ListBox
    Friend WithEvents GroupBoxDetallDBS As System.Windows.Forms.GroupBox
    Friend WithEvents txtDBSName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDBSDescip As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDBSPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtDBSUser As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtDBSHost As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbVolfader As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lbMilFader As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lbMilSegSH As System.Windows.Forms.Label
    Friend WithEvents lbMSegOClok As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtIntervRitme As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtHBorrInterp As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txtHHitTop As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents txtHHit As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtHTop As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtOld As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txtHOldTop As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents chkCanviCat As System.Windows.Forms.CheckBox
    Friend WithEvents txtMaxRadiTop As System.Windows.Forms.TextBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents txtNHitOld As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents txtNTopHit As System.Windows.Forms.TextBox
    Friend WithEvents txtMaxRadiHIT As System.Windows.Forms.TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents txtMaxRadiOLD As System.Windows.Forms.TextBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents txtCanvi As System.Windows.Forms.TextBox
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents cmbContraValor As System.Windows.Forms.ComboBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents cmbMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents grupParams As System.Windows.Forms.GroupBox
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents lbInfoProces As System.Windows.Forms.Label
    Friend WithEvents grupCarp As System.Windows.Forms.GroupBox
    Friend WithEvents grupCarpBlocs As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents cmdAddCarpBlocs As System.Windows.Forms.Button
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNumTracs As System.Windows.Forms.TextBox
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents txtNumVots As System.Windows.Forms.TextBox
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents grupWeb As System.Windows.Forms.GroupBox
    Friend WithEvents PanelFTP As System.Windows.Forms.Panel
    Friend WithEvents txtPswFTP As System.Windows.Forms.TextBox
    Friend WithEvents txtUserFTP As System.Windows.Forms.TextBox
    Friend WithEvents txtDirFTP As System.Windows.Forms.TextBox
    Friend WithEvents txtServerFTP As System.Windows.Forms.TextBox
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDBSPort As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents grupSequencies As System.Windows.Forms.GroupBox
    Friend WithEvents ListBoxSequencies As System.Windows.Forms.ListBox
    Friend WithEvents DataGridViewValorsSequ As System.Windows.Forms.DataGridView
    Friend WithEvents ComboBoxSequencies As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ColumnValors As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents lbNovaSequ As System.Windows.Forms.Label
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents grupSOS As System.Windows.Forms.GroupBox
    Friend WithEvents grupActiveSos As System.Windows.Forms.GroupBox
    Friend WithEvents txtMailDesti As System.Windows.Forms.TextBox
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents txtMailRemitent As System.Windows.Forms.TextBox
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents grupCR As System.Windows.Forms.GroupBox
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents txtPasswordCR As System.Windows.Forms.TextBox
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents txtUsuariCR As System.Windows.Forms.TextBox
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Friend WithEvents txtServerMailCR As System.Windows.Forms.TextBox
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Friend WithEvents txtRemitentCR As System.Windows.Forms.TextBox
    Friend WithEvents Label78 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBoxRemoteInstruc As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxListAplic As System.Windows.Forms.ComboBox
    Friend WithEvents txtCodiCR As System.Windows.Forms.TextBox
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Friend WithEvents Label80 As System.Windows.Forms.Label
    Friend WithEvents txtDescripCR As System.Windows.Forms.TextBox
    Friend WithEvents Label82 As System.Windows.Forms.Label
    Friend WithEvents Label81 As System.Windows.Forms.Label
    Friend WithEvents txtIntervalCR As System.Windows.Forms.TextBox
    Friend WithEvents Label83 As System.Windows.Forms.Label
    Friend WithEvents grupAudioUSR As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupClients As System.Windows.Forms.GroupBox
    Public WithEvents Label85 As System.Windows.Forms.Label
    Friend WithEvents LbClientKO As System.Windows.Forms.Label
    Friend WithEvents LbClientOK As System.Windows.Forms.Label
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label86 As System.Windows.Forms.Label
    Friend WithEvents Label87 As System.Windows.Forms.Label
    Friend WithEvents Label88 As System.Windows.Forms.Label
    Friend WithEvents grupReparar As System.Windows.Forms.GroupBox
    Friend WithEvents GroupInfoSistema As System.Windows.Forms.GroupBox
    Friend WithEvents txtInformeSistema As System.Windows.Forms.TextBox
    Friend WithEvents GroupCredits As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents Label95 As System.Windows.Forms.Label
    Friend WithEvents lbVersioBass As System.Windows.Forms.Label
    Friend WithEvents Label97 As System.Windows.Forms.Label
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents lbVerMysql As System.Windows.Forms.Label
    Friend WithEvents Label99 As System.Windows.Forms.Label
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents Label100 As System.Windows.Forms.Label
    Friend WithEvents lbVerDBS As System.Windows.Forms.Label
    Friend WithEvents LinkLbMySql As System.Windows.Forms.LinkLabel
    Friend WithEvents Label92 As System.Windows.Forms.Label
    Friend WithEvents LinkLbLame As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLbBass As System.Windows.Forms.LinkLabel
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents lbVerAplic As System.Windows.Forms.Label
    Friend WithEvents Label93 As System.Windows.Forms.Label
    Friend WithEvents cmbTipProg As System.Windows.Forms.ComboBox
    Friend WithEvents Label96 As System.Windows.Forms.Label
    Friend WithEvents Label94 As System.Windows.Forms.Label
    Friend WithEvents lbInfo As System.Windows.Forms.Label
    Friend WithEvents lbRadForm As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBoxUsuaris As System.Windows.Forms.GroupBox
    Friend WithEvents scrollMaxtemps As System.Windows.Forms.VScrollBar
    Friend WithEvents txtMaxTemps As System.Windows.Forms.TextBox
    Friend WithEvents Label98 As System.Windows.Forms.Label
    Friend WithEvents txtIntentsUSR As System.Windows.Forms.TextBox
    Friend WithEvents Label101 As System.Windows.Forms.Label
    Friend WithEvents Label102 As System.Windows.Forms.Label
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents listURSErr As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label103 As System.Windows.Forms.Label
    Friend WithEvents Label104 As System.Windows.Forms.Label
    Friend WithEvents fraConf As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBoxDuradaDef As System.Windows.Forms.ComboBox
    Friend WithEvents Label105 As System.Windows.Forms.Label
    Friend WithEvents Label106 As System.Windows.Forms.Label
    Friend WithEvents Label107 As System.Windows.Forms.Label
    Friend WithEvents Label108 As System.Windows.Forms.Label
    Friend WithEvents cmbAudioChannel As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSampleRate As System.Windows.Forms.ComboBox
    Friend WithEvents cmbBitrate As System.Windows.Forms.ComboBox
    Friend WithEvents Label109 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTwitter As System.Windows.Forms.TextBox
    Friend WithEvents txtFaceBook As System.Windows.Forms.TextBox
    Friend WithEvents Label110 As System.Windows.Forms.Label
    Friend WithEvents picKO As System.Windows.Forms.PictureBox
    Friend WithEvents picOK As System.Windows.Forms.PictureBox
    Friend WithEvents lbPathMusica As System.Windows.Forms.Label
    Friend WithEvents lbPathAudioUser As System.Windows.Forms.Label
    Friend WithEvents lbPathPautes As System.Windows.Forms.Label
    Friend WithEvents lbPathProgrames As System.Windows.Forms.Label
    Friend WithEvents lbPathPublicitat As System.Windows.Forms.Label
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxSelectQualitatPodcast As System.Windows.Forms.ComboBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents txtURLStreaming As System.Windows.Forms.TextBox
    Friend WithEvents txtWeb As System.Windows.Forms.TextBox
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents picLock As PictureBox
    Friend WithEvents picUnLock As PictureBox
    Friend WithEvents cmdSortir As MetroFramework.Controls.MetroLink
    Friend WithEvents cmdSalvar As MetroFramework.Controls.MetroTile
    Friend WithEvents CmdBloqueix As MetroFramework.Controls.MetroLink
    Friend WithEvents lbAtencio As MetroFramework.Controls.MetroLink
    Friend WithEvents buttonDelCtlLog As MetroFramework.Controls.MetroButton
    Friend WithEvents txtPathLogErr As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cmdTestMailErr As MetroFramework.Controls.MetroButton
    Friend WithEvents txtAternativeDir As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPathArrelAudio As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cmdAddDBS As MetroFramework.Controls.MetroButton
    Friend WithEvents txtPathINI As MetroFramework.Controls.MetroTextBox
    Friend WithEvents labelMltDBS As MetroFramework.Controls.MetroLabel
    Friend WithEvents chkMltDBS As MetroFramework.Controls.MetroToggle
    Friend WithEvents cmdDelDBS As MetroFramework.Controls.MetroButton
    Friend WithEvents sldMSegOClok As MetroFramework.Controls.MetroTrackBar
    Friend WithEvents chkForceHoraExect As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chkBorHistInterp As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents DataGridViewInstruccionsCR As MetroFramework.Controls.MetroGrid
    Friend WithEvents ButtonDelInstruccio As MetroFramework.Controls.MetroButton
    Friend WithEvents ButtonAddInstrucioCR As MetroFramework.Controls.MetroButton
    Friend WithEvents ColumnCodi As DataGridViewTextBoxColumn
    Friend WithEvents ColumnAppDesti As DataGridViewComboBoxColumn
    Friend WithEvents ColumnInstruc As DataGridViewComboBoxColumn
    Friend WithEvents ColumnDescrip As DataGridViewTextBoxColumn
    Friend WithEvents labelCtlPsw As MetroFramework.Controls.MetroLabel
    Friend WithEvents chkCtlPsw As MetroFramework.Controls.MetroToggle
    Friend WithEvents cmdDelSequenc As MetroFramework.Controls.MetroButton
    Friend WithEvents cmdAddSequenc As MetroFramework.Controls.MetroButton
    Friend WithEvents cmdBorrHistori As MetroFramework.Controls.MetroButton
    Friend WithEvents chkRecord As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents MetroPanel3 As MetroFramework.Controls.MetroPanel
    Private WithEvents GroupBox21 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents labelActiveSOS As MetroFramework.Controls.MetroLabel
    Friend WithEvents CheckBoxActiveSOS As MetroFramework.Controls.MetroToggle
    Friend WithEvents dataGridViewProgramsShared As MetroFramework.Controls.MetroGrid
    Friend WithEvents dataGridViewProgramsCloud As MetroFramework.Controls.MetroGrid
    Friend WithEvents cmdActive As MetroFramework.Controls.MetroTile
    Friend WithEvents chk_sharePrograms As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents cmdSalvarOptionsNuvol As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents tabPagePrgCloudPropis As MetroFramework.Controls.MetroTabPage
    Friend WithEvents tabPagePrgShareCloud As MetroFramework.Controls.MetroTabPage
    Friend WithEvents cmdTestFTP As MetroFramework.Controls.MetroButton
    Friend WithEvents gridAudioFiles As MetroFramework.Controls.MetroGrid
    Friend WithEvents cmdDelAudio As MetroFramework.Controls.MetroButton
    Friend WithEvents cmdAddAudio As MetroFramework.Controls.MetroButton
    Friend WithEvents sldVolfader As MetroFramework.Controls.MetroTrackBar
    Friend WithEvents sldMilFader As MetroFramework.Controls.MetroTrackBar
    Friend WithEvents sldMilSegSH As MetroFramework.Controls.MetroTrackBar
    Friend WithEvents txtSenyHora As MetroFramework.Controls.MetroTextBox
    Friend WithEvents buttonSincroWeb As MetroFramework.Controls.MetroButton
    Friend WithEvents chkAllDBS As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chkLastBKP As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents cmdProgresCancel As MetroFramework.Controls.MetroButton
    Friend WithEvents ProgressBar As MetroFramework.Controls.MetroProgressBar
    Friend WithEvents cmdReparIDs As MetroFramework.Controls.MetroButton
    Friend WithEvents chkCTL_USR_Cartux As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chkActvTabProgram As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents chk_SendDevelop As MetroFramework.Controls.MetroToggle
    Friend WithEvents txtStreamCannels As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtStreamSampleRate As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtStreamBitRate As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lbOnline As MetroFramework.Controls.MetroLabel
    Friend WithEvents chkOnLine As MetroFramework.Controls.MetroToggle
    Friend WithEvents lbSaved As MetroFramework.Controls.MetroLink
    Friend WithEvents cmdExportConnection As MetroFramework.Controls.MetroButton
    Friend WithEvents lbCommentDesconnexio As Label
    Friend WithEvents txtComentDesconnexio As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lbDies As Label
    Friend WithEvents txtVDEF_DateOut As TextBox
    Friend WithEvents lbDataOut As Label
    Friend WithEvents lbTarifa As Label
    Friend WithEvents ComboBoxVDef_tarifa As ComboBox
    Friend WithEvents chkVDef_activats As MetroFramework.Controls.MetroToggle
    Friend WithEvents lbFileDefActive As Label
    Friend WithEvents lbCaputeTag As Label
    Friend WithEvents chkCaptureTag As MetroFramework.Controls.MetroToggle
    Friend WithEvents GroupBoxCarpetes As GroupBox
    Friend WithEvents FlowLayoutPanelCarpetes As FlowLayoutPanel
    Friend WithEvents ButtonAddCarpeta As Button
    Friend WithEvents lbPathBackup As Label
    Friend WithEvents pic_logo As PictureBox
    Friend WithEvents ColumnImageid As DataGridViewTextBoxColumn
    Friend WithEvents ColumnImage As DataGridViewImageColumn
    Friend WithEvents Column_id As DataGridViewTextBoxColumn
    Friend WithEvents Column_nom As DataGridViewTextBoxColumn
    Friend WithEvents Column_visible_cart As DataGridViewCheckBoxColumn
    Friend WithEvents ColumnVisible_cont As DataGridViewCheckBoxColumn
    Friend WithEvents ColumnCarp As DataGridViewComboBoxColumn
    Friend WithEvents ColumnEnding As DataGridViewCheckBoxColumn
    Friend WithEvents Columnph As DataGridViewCheckBoxColumn
    Friend WithEvents LbInfoConvida As MetroFramework.Controls.MetroLabel
    Friend WithEvents TxtCodeToShare As MetroFramework.Controls.MetroTextBox
    Friend WithEvents ButtonSetSharePrg As MetroFramework.Controls.MetroTile
    Private WithEvents Label15 As Label
    Friend WithEvents txtCodeShareImport As MetroFramework.Controls.MetroTextBox
    Friend WithEvents dataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents dataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents ColumnFrom As DataGridViewTextBoxColumn
    Friend WithEvents dataGridViewCheckBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ButtonImportProgram As MetroFramework.Controls.MetroTile
    Friend WithEvents Column_prg_id As DataGridViewTextBoxColumn
    Friend WithEvents Column_prg_nom As DataGridViewTextBoxColumn
    Friend WithEvents Column_prg_emissora As DataGridViewTextBoxColumn
    Friend WithEvents Column_prg_hash As DataGridViewTextBoxColumn
    Friend WithEvents Column_prg_state As DataGridViewCheckBoxColumn
    Friend WithEvents ColumnCli_id As DataGridViewTextBoxColumn
    Friend WithEvents Column_prg_delete As DataGridViewButtonColumn
    Friend WithEvents lbInfoPrgCloud As MetroFramework.Controls.MetroLabel
    Friend WithEvents groupBox14 As GroupBox
    Friend WithEvents label52 As Label
    Friend WithEvents linkMysqlBackup As LinkLabel
    Friend WithEvents lbVerMySqlBackup As Label
    Friend WithEvents label84 As Label
End Class
