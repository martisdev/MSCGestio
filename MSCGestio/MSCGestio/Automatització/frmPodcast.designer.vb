<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPodcast
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPodcast))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.mnuShowActuals = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLlistar = New System.Windows.Forms.ToolStripSplitButton()
        Me.mnuShowAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuShowPendentPubli = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuShowCaduc = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuShowAllRemots = New System.Windows.Forms.ToolStripMenuItem()
        Me.limitDeRegistresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLimit10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLimit20 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLimit30 = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripFTPBotonera = New System.Windows.Forms.ToolStrip()
        Me.cmbAnt = New System.Windows.Forms.ToolStripButton()
        Me.txtPostRecord = New System.Windows.Forms.ToolStripLabel()
        Me.cmbNext = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdConnectFTP = New System.Windows.Forms.ToolStripButton()
        Me.cmdDesConnectFTP = New System.Windows.Forms.ToolStripButton()
        Me.buttonExecTasquestFTP = New System.Windows.Forms.ToolStripButton()
        Me.ColumnFTPPlay = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ColumnFTPSize = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnFTPPath = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnFTPAction = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ColumnFTPChk = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.dataGridViewRemote = New MetroFramework.Controls.MetroGrid()
        Me.ComboBoxTipus = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.label10 = New System.Windows.Forms.Label()
        Me.tableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.ColumnLocalPlay = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ColumnLocalNomFitxer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnLocalSize = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnLocalDataIn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnLocalPath = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtDecrip = New System.Windows.Forms.TextBox()
        Me.cmbFitxer = New System.Windows.Forms.ComboBox()
        Me.ColumnLocalTipus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnLocalNom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnLocalID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.label9 = New System.Windows.Forms.Label()
        Me.dataGridViewLocal = New MetroFramework.Controls.MetroGrid()
        Me.ColumnLocalDataOut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.comboboxGeneralTaskServer = New System.Windows.Forms.ComboBox()
        Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.lbNomFitxer = New System.Windows.Forms.Label()
        Me.lbFileName = New System.Windows.Forms.Label()
        Me.ProgressBarFTP = New MetroFramework.Controls.MetroProgressBar()
        Me.lbInfoFTP = New MetroFramework.Controls.MetroLabel()
        Me.tabPageFTP = New MetroFramework.Controls.MetroTabPage()
        Me.txtPartsProces = New MetroFramework.Controls.MetroLabel()
        Me.tabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.gridDades = New MetroFramework.Controls.MetroGrid()
        Me.ColumnID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnTipus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnOrigen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnDurada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnDataCrea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnDataPubli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnDataOut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnDescrip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnPlayers = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnFile = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chkIN = New MetroFramework.Controls.MetroCheckBox()
        Me.txtDataOut = New MetroFramework.Controls.MetroDateTime()
        Me.txtDataPublicacio = New MetroFramework.Controls.MetroDateTime()
        Me.txtHoraPublicacio = New System.Windows.Forms.DateTimePicker()
        Me.lbDataCrea = New MetroFramework.Controls.MetroLabel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbID = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbDurada = New MetroFramework.Controls.MetroLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.cmbProgrames = New System.Windows.Forms.ComboBox()
        Me.lbIdTipus = New System.Windows.Forms.Label()
        Me.cmdNou = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.lbRecCount = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.lbPosition = New System.Windows.Forms.ToolStripLabel()
        Me.cmdUltim = New System.Windows.Forms.ToolStripButton()
        Me.cmdSeguent = New System.Windows.Forms.ToolStripButton()
        Me.cmdPrevi = New System.Windows.Forms.ToolStripButton()
        Me.cmdPrimer = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.cmdBloqueix = New System.Windows.Forms.ToolStripButton()
        Me.cmdBorrar = New System.Windows.Forms.ToolStripButton()
        Me.cmdSalvar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.OptionBuscar = New System.Windows.Forms.ToolStripDropDownButton()
        Me.mnuFindOpcionsMare = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFindOpcions = New System.Windows.Forms.ToolStripMenuItem()
        Me.pendentsDePublicarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.caducadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdSortir = New System.Windows.Forms.ToolStripButton()
        Me.lbVuMeter = New System.Windows.Forms.ToolStripLabel()
        Me.cmdStop = New System.Windows.Forms.ToolStripButton()
        Me.cmdPlay = New System.Windows.Forms.ToolStripButton()
        Me.lbNou = New System.Windows.Forms.ToolStripLabel()
        Me.mnu_Help = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditAudio = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuDel = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModif = New System.Windows.Forms.ToolStripMenuItem()
        Me.EdicióToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFinal = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCalcDurada = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuStop = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPlay = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReproductorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgarmaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.picPlay = New System.Windows.Forms.PictureBox()
        Me.picPause = New System.Windows.Forms.PictureBox()
        Me.tmrPlayer = New System.Windows.Forms.Timer(Me.components)
        Me.picVuMeter = New System.Windows.Forms.PictureBox()
        Me.picLock = New System.Windows.Forms.PictureBox()
        Me.picUnLock = New System.Windows.Forms.PictureBox()
        Me.cmdEnd = New System.Windows.Forms.Button()
        Me.pic_logo = New System.Windows.Forms.PictureBox()
        Me.toolStripFTPBotonera.SuspendLayout()
        CType(Me.dataGridViewRemote, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tableLayoutPanel2.SuspendLayout()
        CType(Me.dataGridViewLocal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tableLayoutPanel1.SuspendLayout()
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer1.Panel1.SuspendLayout()
        Me.splitContainer1.Panel2.SuspendLayout()
        Me.splitContainer1.SuspendLayout()
        Me.tabPageFTP.SuspendLayout()
        Me.tabPage1.SuspendLayout()
        CType(Me.gridDades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabControl1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picPlay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPause, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picVuMeter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUnLock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuShowActuals
        '
        Me.mnuShowActuals.Name = "mnuShowActuals"
        Me.mnuShowActuals.Size = New System.Drawing.Size(185, 22)
        Me.mnuShowActuals.Tag = "1"
        Me.mnuShowActuals.Text = "Actuals"
        '
        'mnuLlistar
        '
        Me.mnuLlistar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuShowAll, Me.mnuShowActuals, Me.mnuShowPendentPubli, Me.mnuShowCaduc, Me.mnuShowAllRemots, Me.limitDeRegistresToolStripMenuItem})
        Me.mnuLlistar.Image = CType(resources.GetObject("mnuLlistar.Image"), System.Drawing.Image)
        Me.mnuLlistar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuLlistar.Name = "mnuLlistar"
        Me.mnuLlistar.Size = New System.Drawing.Size(70, 22)
        Me.mnuLlistar.Text = "Llistar"
        '
        'mnuShowAll
        '
        Me.mnuShowAll.Checked = True
        Me.mnuShowAll.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuShowAll.Name = "mnuShowAll"
        Me.mnuShowAll.Size = New System.Drawing.Size(185, 22)
        Me.mnuShowAll.Tag = "0"
        Me.mnuShowAll.Text = "Tots"
        '
        'mnuShowPendentPubli
        '
        Me.mnuShowPendentPubli.Name = "mnuShowPendentPubli"
        Me.mnuShowPendentPubli.Size = New System.Drawing.Size(185, 22)
        Me.mnuShowPendentPubli.Tag = "2"
        Me.mnuShowPendentPubli.Text = "Pendents de publicar"
        '
        'mnuShowCaduc
        '
        Me.mnuShowCaduc.Name = "mnuShowCaduc"
        Me.mnuShowCaduc.Size = New System.Drawing.Size(185, 22)
        Me.mnuShowCaduc.Tag = "3"
        Me.mnuShowCaduc.Text = "Caducats"
        '
        'mnuShowAllRemots
        '
        Me.mnuShowAllRemots.Name = "mnuShowAllRemots"
        Me.mnuShowAllRemots.Size = New System.Drawing.Size(185, 22)
        Me.mnuShowAllRemots.Tag = "4"
        Me.mnuShowAllRemots.Text = "Tots els remots"
        '
        'limitDeRegistresToolStripMenuItem
        '
        Me.limitDeRegistresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuLimit10, Me.mnuLimit20, Me.mnuLimit30})
        Me.limitDeRegistresToolStripMenuItem.Name = "limitDeRegistresToolStripMenuItem"
        Me.limitDeRegistresToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.limitDeRegistresToolStripMenuItem.Text = "Limit de registres"
        '
        'mnuLimit10
        '
        Me.mnuLimit10.Checked = True
        Me.mnuLimit10.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuLimit10.Name = "mnuLimit10"
        Me.mnuLimit10.Size = New System.Drawing.Size(86, 22)
        Me.mnuLimit10.Text = "10"
        '
        'mnuLimit20
        '
        Me.mnuLimit20.Name = "mnuLimit20"
        Me.mnuLimit20.Size = New System.Drawing.Size(86, 22)
        Me.mnuLimit20.Text = "20"
        '
        'mnuLimit30
        '
        Me.mnuLimit30.Name = "mnuLimit30"
        Me.mnuLimit30.Size = New System.Drawing.Size(86, 22)
        Me.mnuLimit30.Text = "30"
        '
        'toolStripFTPBotonera
        '
        Me.toolStripFTPBotonera.BackColor = System.Drawing.Color.Transparent
        Me.toolStripFTPBotonera.Enabled = False
        Me.toolStripFTPBotonera.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuLlistar, Me.cmbAnt, Me.txtPostRecord, Me.cmbNext, Me.toolStripSeparator3, Me.cmdConnectFTP, Me.cmdDesConnectFTP, Me.buttonExecTasquestFTP})
        Me.toolStripFTPBotonera.Location = New System.Drawing.Point(0, 0)
        Me.toolStripFTPBotonera.Name = "toolStripFTPBotonera"
        Me.toolStripFTPBotonera.Size = New System.Drawing.Size(971, 25)
        Me.toolStripFTPBotonera.TabIndex = 230
        Me.toolStripFTPBotonera.Text = "Botons de gestió FTP"
        '
        'cmbAnt
        '
        Me.cmbAnt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.cmbAnt.Enabled = False
        Me.cmbAnt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAnt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmbAnt.Name = "cmbAnt"
        Me.cmbAnt.Size = New System.Drawing.Size(23, 22)
        Me.cmbAnt.Text = "<"
        '
        'txtPostRecord
        '
        Me.txtPostRecord.Name = "txtPostRecord"
        Me.txtPostRecord.Size = New System.Drawing.Size(30, 22)
        Me.txtPostRecord.Text = "0/10"
        '
        'cmbNext
        '
        Me.cmbNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.cmbNext.Enabled = False
        Me.cmbNext.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNext.Image = CType(resources.GetObject("cmbNext.Image"), System.Drawing.Image)
        Me.cmbNext.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmbNext.Name = "cmbNext"
        Me.cmbNext.Size = New System.Drawing.Size(23, 22)
        Me.cmbNext.Text = ">"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'cmdConnectFTP
        '
        Me.cmdConnectFTP.Image = CType(resources.GetObject("cmdConnectFTP.Image"), System.Drawing.Image)
        Me.cmdConnectFTP.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdConnectFTP.Name = "cmdConnectFTP"
        Me.cmdConnectFTP.Size = New System.Drawing.Size(124, 22)
        Me.cmdConnectFTP.Text = "Connectar per FTP"
        Me.cmdConnectFTP.Visible = False
        '
        'cmdDesConnectFTP
        '
        Me.cmdDesConnectFTP.Enabled = False
        Me.cmdDesConnectFTP.Image = CType(resources.GetObject("cmdDesConnectFTP.Image"), System.Drawing.Image)
        Me.cmdDesConnectFTP.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdDesConnectFTP.Name = "cmdDesConnectFTP"
        Me.cmdDesConnectFTP.Size = New System.Drawing.Size(83, 22)
        Me.cmdDesConnectFTP.Text = "Tancar FTP"
        Me.cmdDesConnectFTP.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.cmdDesConnectFTP.Visible = False
        '
        'buttonExecTasquestFTP
        '
        Me.buttonExecTasquestFTP.Enabled = False
        Me.buttonExecTasquestFTP.Image = CType(resources.GetObject("buttonExecTasquestFTP.Image"), System.Drawing.Image)
        Me.buttonExecTasquestFTP.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonExecTasquestFTP.Name = "buttonExecTasquestFTP"
        Me.buttonExecTasquestFTP.Size = New System.Drawing.Size(116, 22)
        Me.buttonExecTasquestFTP.Text = "Executar Tasques"
        '
        'ColumnFTPPlay
        '
        Me.ColumnFTPPlay.HeaderText = "Play"
        Me.ColumnFTPPlay.Name = "ColumnFTPPlay"
        Me.ColumnFTPPlay.Width = 30
        '
        'ColumnFTPSize
        '
        Me.ColumnFTPSize.HeaderText = "kb"
        Me.ColumnFTPSize.Name = "ColumnFTPSize"
        Me.ColumnFTPSize.ReadOnly = True
        Me.ColumnFTPSize.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColumnFTPSize.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColumnFTPSize.Width = 50
        '
        'ColumnFTPPath
        '
        Me.ColumnFTPPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnFTPPath.HeaderText = "Fitxer"
        Me.ColumnFTPPath.Name = "ColumnFTPPath"
        Me.ColumnFTPPath.ReadOnly = True
        Me.ColumnFTPPath.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColumnFTPPath.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ColumnFTPAction
        '
        Me.ColumnFTPAction.HeaderText = "Acció"
        Me.ColumnFTPAction.Name = "ColumnFTPAction"
        Me.ColumnFTPAction.Width = 120
        '
        'ColumnFTPChk
        '
        Me.ColumnFTPChk.HeaderText = ""
        Me.ColumnFTPChk.Name = "ColumnFTPChk"
        Me.ColumnFTPChk.Width = 25
        '
        'dataGridViewRemote
        '
        Me.dataGridViewRemote.AllowUserToAddRows = False
        Me.dataGridViewRemote.AllowUserToDeleteRows = False
        Me.dataGridViewRemote.AllowUserToResizeRows = False
        Me.dataGridViewRemote.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataGridViewRemote.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataGridViewRemote.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dataGridViewRemote.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridViewRemote.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dataGridViewRemote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridViewRemote.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnFTPChk, Me.ColumnFTPAction, Me.ColumnFTPPath, Me.ColumnFTPSize, Me.ColumnFTPPlay})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGridViewRemote.DefaultCellStyle = DataGridViewCellStyle2
        Me.dataGridViewRemote.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataGridViewRemote.EnableHeadersVisualStyles = False
        Me.dataGridViewRemote.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dataGridViewRemote.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataGridViewRemote.Location = New System.Drawing.Point(3, 38)
        Me.dataGridViewRemote.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dataGridViewRemote.Name = "dataGridViewRemote"
        Me.dataGridViewRemote.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridViewRemote.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dataGridViewRemote.RowHeadersVisible = False
        Me.dataGridViewRemote.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dataGridViewRemote.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGridViewRemote.Size = New System.Drawing.Size(445, 298)
        Me.dataGridViewRemote.TabIndex = 3
        '
        'ComboBoxTipus
        '
        Me.ComboBoxTipus.Enabled = False
        Me.ComboBoxTipus.FormattingEnabled = True
        Me.ComboBoxTipus.Location = New System.Drawing.Point(663, 31)
        Me.ComboBoxTipus.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBoxTipus.Name = "ComboBoxTipus"
        Me.ComboBoxTipus.Size = New System.Drawing.Size(196, 21)
        Me.ComboBoxTipus.TabIndex = 8
        Me.ComboBoxTipus.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 25)
        Me.Label1.TabIndex = 165
        Me.Label1.Text = "Identificador:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'label10
        '
        Me.label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label10.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.Location = New System.Drawing.Point(3, 0)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(445, 27)
        Me.label10.TabIndex = 2
        Me.label10.Text = "Fitxers Remots"
        Me.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tableLayoutPanel2
        '
        Me.tableLayoutPanel2.ColumnCount = 1
        Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel2.Controls.Add(Me.label10, 0, 0)
        Me.tableLayoutPanel2.Controls.Add(Me.dataGridViewRemote, 0, 1)
        Me.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.tableLayoutPanel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tableLayoutPanel2.Name = "tableLayoutPanel2"
        Me.tableLayoutPanel2.RowCount = 2
        Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel2.Size = New System.Drawing.Size(451, 338)
        Me.tableLayoutPanel2.TabIndex = 3
        '
        'ColumnLocalPlay
        '
        Me.ColumnLocalPlay.HeaderText = "Play"
        Me.ColumnLocalPlay.Name = "ColumnLocalPlay"
        Me.ColumnLocalPlay.ReadOnly = True
        Me.ColumnLocalPlay.Width = 30
        '
        'ColumnLocalNomFitxer
        '
        Me.ColumnLocalNomFitxer.HeaderText = "Nom Fitxer"
        Me.ColumnLocalNomFitxer.Name = "ColumnLocalNomFitxer"
        Me.ColumnLocalNomFitxer.ReadOnly = True
        '
        'ColumnLocalSize
        '
        Me.ColumnLocalSize.HeaderText = "kb"
        Me.ColumnLocalSize.Name = "ColumnLocalSize"
        Me.ColumnLocalSize.ReadOnly = True
        Me.ColumnLocalSize.Width = 50
        '
        'ColumnLocalDataIn
        '
        Me.ColumnLocalDataIn.HeaderText = "Data In"
        Me.ColumnLocalDataIn.Name = "ColumnLocalDataIn"
        Me.ColumnLocalDataIn.ReadOnly = True
        Me.ColumnLocalDataIn.Width = 70
        '
        'ColumnLocalPath
        '
        Me.ColumnLocalPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnLocalPath.HeaderText = "Fitxer"
        Me.ColumnLocalPath.Name = "ColumnLocalPath"
        Me.ColumnLocalPath.ReadOnly = True
        '
        'txtDecrip
        '
        Me.txtDecrip.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDecrip.Enabled = False
        Me.txtDecrip.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!)
        Me.txtDecrip.Location = New System.Drawing.Point(146, 209)
        Me.txtDecrip.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDecrip.MaxLength = 290
        Me.txtDecrip.Multiline = True
        Me.txtDecrip.Name = "txtDecrip"
        Me.txtDecrip.Size = New System.Drawing.Size(822, 63)
        Me.txtDecrip.TabIndex = 6
        '
        'cmbFitxer
        '
        Me.cmbFitxer.Enabled = False
        Me.cmbFitxer.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!)
        Me.cmbFitxer.FormattingEnabled = True
        Me.cmbFitxer.ItemHeight = 17
        Me.cmbFitxer.Location = New System.Drawing.Point(146, 31)
        Me.cmbFitxer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbFitxer.Name = "cmbFitxer"
        Me.cmbFitxer.Size = New System.Drawing.Size(340, 25)
        Me.cmbFitxer.TabIndex = 0
        '
        'ColumnLocalTipus
        '
        Me.ColumnLocalTipus.HeaderText = "Tipus"
        Me.ColumnLocalTipus.Name = "ColumnLocalTipus"
        Me.ColumnLocalTipus.ReadOnly = True
        Me.ColumnLocalTipus.Width = 80
        '
        'ColumnLocalNom
        '
        Me.ColumnLocalNom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnLocalNom.HeaderText = "Nom"
        Me.ColumnLocalNom.Name = "ColumnLocalNom"
        Me.ColumnLocalNom.ReadOnly = True
        '
        'ColumnLocalID
        '
        Me.ColumnLocalID.HeaderText = "ID"
        Me.ColumnLocalID.Name = "ColumnLocalID"
        Me.ColumnLocalID.ReadOnly = True
        Me.ColumnLocalID.Width = 25
        '
        'label9
        '
        Me.label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label9.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.Location = New System.Drawing.Point(3, 0)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(506, 27)
        Me.label9.TabIndex = 1
        Me.label9.Text = "Fitxers Locals"
        Me.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dataGridViewLocal
        '
        Me.dataGridViewLocal.AllowUserToAddRows = False
        Me.dataGridViewLocal.AllowUserToDeleteRows = False
        Me.dataGridViewLocal.AllowUserToResizeRows = False
        Me.dataGridViewLocal.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataGridViewLocal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataGridViewLocal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dataGridViewLocal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridViewLocal.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dataGridViewLocal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridViewLocal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnLocalID, Me.ColumnLocalNom, Me.ColumnLocalTipus, Me.ColumnLocalPath, Me.ColumnLocalDataIn, Me.ColumnLocalDataOut, Me.ColumnLocalSize, Me.ColumnLocalNomFitxer, Me.ColumnLocalPlay})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGridViewLocal.DefaultCellStyle = DataGridViewCellStyle5
        Me.dataGridViewLocal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataGridViewLocal.EnableHeadersVisualStyles = False
        Me.dataGridViewLocal.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dataGridViewLocal.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataGridViewLocal.Location = New System.Drawing.Point(3, 38)
        Me.dataGridViewLocal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dataGridViewLocal.Name = "dataGridViewLocal"
        Me.dataGridViewLocal.ReadOnly = True
        Me.dataGridViewLocal.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridViewLocal.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dataGridViewLocal.RowHeadersVisible = False
        Me.dataGridViewLocal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dataGridViewLocal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGridViewLocal.Size = New System.Drawing.Size(506, 298)
        Me.dataGridViewLocal.TabIndex = 2
        '
        'ColumnLocalDataOut
        '
        Me.ColumnLocalDataOut.HeaderText = "Data Out"
        Me.ColumnLocalDataOut.Name = "ColumnLocalDataOut"
        Me.ColumnLocalDataOut.ReadOnly = True
        '
        'tableLayoutPanel1
        '
        Me.tableLayoutPanel1.ColumnCount = 1
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel1.Controls.Add(Me.label9, 0, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.dataGridViewLocal, 0, 1)
        Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.tableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 2
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(512, 338)
        Me.tableLayoutPanel1.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(836, 177)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(132, 29)
        Me.Label7.TabIndex = 241
        Me.Label7.Text = "accepta HTML"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'comboboxGeneralTaskServer
        '
        Me.comboboxGeneralTaskServer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.comboboxGeneralTaskServer.Enabled = False
        Me.comboboxGeneralTaskServer.FormattingEnabled = True
        Me.comboboxGeneralTaskServer.Location = New System.Drawing.Point(1766, 0)
        Me.comboboxGeneralTaskServer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.comboboxGeneralTaskServer.Name = "comboboxGeneralTaskServer"
        Me.comboboxGeneralTaskServer.Size = New System.Drawing.Size(196, 21)
        Me.comboboxGeneralTaskServer.TabIndex = 233
        '
        'splitContainer1
        '
        Me.splitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.splitContainer1.BackColor = System.Drawing.Color.Transparent
        Me.splitContainer1.Location = New System.Drawing.Point(0, 28)
        Me.splitContainer1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.splitContainer1.Name = "splitContainer1"
        '
        'splitContainer1.Panel1
        '
        Me.splitContainer1.Panel1.Controls.Add(Me.tableLayoutPanel1)
        '
        'splitContainer1.Panel2
        '
        Me.splitContainer1.Panel2.Controls.Add(Me.tableLayoutPanel2)
        Me.splitContainer1.Size = New System.Drawing.Size(968, 338)
        Me.splitContainer1.SplitterDistance = 512
        Me.splitContainer1.SplitterWidth = 5
        Me.splitContainer1.TabIndex = 231
        '
        'lbNomFitxer
        '
        Me.lbNomFitxer.BackColor = System.Drawing.Color.Transparent
        Me.lbNomFitxer.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNomFitxer.Location = New System.Drawing.Point(-8, 276)
        Me.lbNomFitxer.Name = "lbNomFitxer"
        Me.lbNomFitxer.Size = New System.Drawing.Size(143, 29)
        Me.lbNomFitxer.TabIndex = 244
        Me.lbNomFitxer.Text = "Nom Fitxer:"
        Me.lbNomFitxer.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbFileName
        '
        Me.lbFileName.BackColor = System.Drawing.Color.Transparent
        Me.lbFileName.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFileName.Location = New System.Drawing.Point(143, 276)
        Me.lbFileName.Name = "lbFileName"
        Me.lbFileName.Size = New System.Drawing.Size(454, 29)
        Me.lbFileName.TabIndex = 7
        '
        'ProgressBarFTP
        '
        Me.ProgressBarFTP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBarFTP.HideProgressText = False
        Me.ProgressBarFTP.Location = New System.Drawing.Point(627, 370)
        Me.ProgressBarFTP.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ProgressBarFTP.MarqueeAnimationSpeed = 30
        Me.ProgressBarFTP.Name = "ProgressBarFTP"
        Me.ProgressBarFTP.Size = New System.Drawing.Size(341, 24)
        Me.ProgressBarFTP.TabIndex = 236
        Me.ProgressBarFTP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ProgressBarFTP.Visible = False
        '
        'lbInfoFTP
        '
        Me.lbInfoFTP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbInfoFTP.AutoSize = True
        Me.lbInfoFTP.Location = New System.Drawing.Point(0, 370)
        Me.lbInfoFTP.Name = "lbInfoFTP"
        Me.lbInfoFTP.Size = New System.Drawing.Size(137, 19)
        Me.lbInfoFTP.TabIndex = 234
        Me.lbInfoFTP.Text = "Informació del Procés"
        '
        'tabPageFTP
        '
        Me.tabPageFTP.Controls.Add(Me.ProgressBarFTP)
        Me.tabPageFTP.Controls.Add(Me.txtPartsProces)
        Me.tabPageFTP.Controls.Add(Me.lbInfoFTP)
        Me.tabPageFTP.Controls.Add(Me.comboboxGeneralTaskServer)
        Me.tabPageFTP.Controls.Add(Me.toolStripFTPBotonera)
        Me.tabPageFTP.Controls.Add(Me.splitContainer1)
        Me.tabPageFTP.HorizontalScrollbarBarColor = True
        Me.tabPageFTP.HorizontalScrollbarHighlightOnWheel = False
        Me.tabPageFTP.HorizontalScrollbarSize = 4
        Me.tabPageFTP.Location = New System.Drawing.Point(4, 38)
        Me.tabPageFTP.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tabPageFTP.Name = "tabPageFTP"
        Me.tabPageFTP.Size = New System.Drawing.Size(971, 398)
        Me.tabPageFTP.TabIndex = 1
        Me.tabPageFTP.Text = "Tasques al servidor"
        Me.tabPageFTP.VerticalScrollbarBarColor = True
        Me.tabPageFTP.VerticalScrollbarHighlightOnWheel = False
        Me.tabPageFTP.VerticalScrollbarSize = 6
        '
        'txtPartsProces
        '
        Me.txtPartsProces.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPartsProces.Location = New System.Drawing.Point(540, 370)
        Me.txtPartsProces.Name = "txtPartsProces"
        Me.txtPartsProces.Size = New System.Drawing.Size(72, 21)
        Me.txtPartsProces.TabIndex = 235
        Me.txtPartsProces.Text = "1/4"
        Me.txtPartsProces.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.txtPartsProces.Visible = False
        '
        'tabPage1
        '
        Me.tabPage1.Controls.Add(Me.gridDades)
        Me.tabPage1.Controls.Add(Me.chkIN)
        Me.tabPage1.Controls.Add(Me.txtDataOut)
        Me.tabPage1.Controls.Add(Me.txtDataPublicacio)
        Me.tabPage1.Controls.Add(Me.ComboBoxTipus)
        Me.tabPage1.Controls.Add(Me.txtHoraPublicacio)
        Me.tabPage1.Controls.Add(Me.Label7)
        Me.tabPage1.Controls.Add(Me.lbFileName)
        Me.tabPage1.Controls.Add(Me.lbNomFitxer)
        Me.tabPage1.Controls.Add(Me.Label1)
        Me.tabPage1.Controls.Add(Me.txtDecrip)
        Me.tabPage1.Controls.Add(Me.cmbFitxer)
        Me.tabPage1.Controls.Add(Me.lbDataCrea)
        Me.tabPage1.Controls.Add(Me.Label6)
        Me.tabPage1.Controls.Add(Me.Label8)
        Me.tabPage1.Controls.Add(Me.lbID)
        Me.tabPage1.Controls.Add(Me.Label64)
        Me.tabPage1.Controls.Add(Me.Label5)
        Me.tabPage1.Controls.Add(Me.lbDurada)
        Me.tabPage1.Controls.Add(Me.Label2)
        Me.tabPage1.Controls.Add(Me.Label4)
        Me.tabPage1.Controls.Add(Me.Label3)
        Me.tabPage1.HorizontalScrollbarBarColor = True
        Me.tabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.tabPage1.HorizontalScrollbarSize = 4
        Me.tabPage1.Location = New System.Drawing.Point(4, 38)
        Me.tabPage1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Size = New System.Drawing.Size(971, 398)
        Me.tabPage1.TabIndex = 0
        Me.tabPage1.Text = "Detalls fitxer"
        Me.tabPage1.VerticalScrollbarBarColor = True
        Me.tabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.tabPage1.VerticalScrollbarSize = 6
        '
        'gridDades
        '
        Me.gridDades.AllowUserToAddRows = False
        Me.gridDades.AllowUserToDeleteRows = False
        Me.gridDades.AllowUserToResizeRows = False
        Me.gridDades.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridDades.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gridDades.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gridDades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.gridDades.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridDades.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.gridDades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridDades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnID, Me.ColumnTipus, Me.ColumnOrigen, Me.ColumnDurada, Me.ColumnDataCrea, Me.ColumnDataPubli, Me.ColumnDataOut, Me.ColumnDescrip, Me.ColumnPlayers, Me.ColumnFile})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridDades.DefaultCellStyle = DataGridViewCellStyle8
        Me.gridDades.EnableHeadersVisualStyles = False
        Me.gridDades.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.gridDades.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gridDades.Location = New System.Drawing.Point(58, 309)
        Me.gridDades.Name = "gridDades"
        Me.gridDades.ReadOnly = True
        Me.gridDades.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridDades.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.gridDades.RowHeadersVisible = False
        Me.gridDades.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.gridDades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridDades.Size = New System.Drawing.Size(914, 89)
        Me.gridDades.TabIndex = 9
        '
        'ColumnID
        '
        Me.ColumnID.DataPropertyName = "pod_id"
        Me.ColumnID.HeaderText = "ID"
        Me.ColumnID.Name = "ColumnID"
        Me.ColumnID.ReadOnly = True
        Me.ColumnID.Width = 50
        '
        'ColumnTipus
        '
        Me.ColumnTipus.DataPropertyName = "pod_tipusfitxer"
        Me.ColumnTipus.HeaderText = "Tipus Fitxer"
        Me.ColumnTipus.Name = "ColumnTipus"
        Me.ColumnTipus.ReadOnly = True
        Me.ColumnTipus.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColumnTipus.Visible = False
        Me.ColumnTipus.Width = 138
        '
        'ColumnOrigen
        '
        Me.ColumnOrigen.DataPropertyName = "pod_id_origen"
        Me.ColumnOrigen.HeaderText = "Origen"
        Me.ColumnOrigen.Name = "ColumnOrigen"
        Me.ColumnOrigen.ReadOnly = True
        Me.ColumnOrigen.Visible = False
        '
        'ColumnDurada
        '
        Me.ColumnDurada.DataPropertyName = "pod_durada"
        Me.ColumnDurada.HeaderText = "Durada"
        Me.ColumnDurada.Name = "ColumnDurada"
        Me.ColumnDurada.ReadOnly = True
        '
        'ColumnDataCrea
        '
        Me.ColumnDataCrea.DataPropertyName = "pod_datacreacio"
        Me.ColumnDataCrea.HeaderText = "Data Creació"
        Me.ColumnDataCrea.Name = "ColumnDataCrea"
        Me.ColumnDataCrea.ReadOnly = True
        Me.ColumnDataCrea.Width = 150
        '
        'ColumnDataPubli
        '
        Me.ColumnDataPubli.DataPropertyName = "pod_datapubli"
        Me.ColumnDataPubli.HeaderText = "Data Publi"
        Me.ColumnDataPubli.Name = "ColumnDataPubli"
        Me.ColumnDataPubli.ReadOnly = True
        '
        'ColumnDataOut
        '
        Me.ColumnDataOut.DataPropertyName = "pod_dataout"
        Me.ColumnDataOut.HeaderText = "Data Out"
        Me.ColumnDataOut.Name = "ColumnDataOut"
        Me.ColumnDataOut.ReadOnly = True
        Me.ColumnDataOut.Width = 150
        '
        'ColumnDescrip
        '
        Me.ColumnDescrip.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnDescrip.DataPropertyName = "pod_descrip"
        Me.ColumnDescrip.HeaderText = "Descripció"
        Me.ColumnDescrip.Name = "ColumnDescrip"
        Me.ColumnDescrip.ReadOnly = True
        '
        'ColumnPlayers
        '
        Me.ColumnPlayers.DataPropertyName = "pod_numplayers"
        Me.ColumnPlayers.HeaderText = "Players"
        Me.ColumnPlayers.Name = "ColumnPlayers"
        Me.ColumnPlayers.ReadOnly = True
        Me.ColumnPlayers.Visible = False
        '
        'ColumnFile
        '
        Me.ColumnFile.DataPropertyName = "pod_file"
        Me.ColumnFile.HeaderText = "file Name"
        Me.ColumnFile.Name = "ColumnFile"
        Me.ColumnFile.ReadOnly = True
        Me.ColumnFile.Visible = False
        '
        'chkIN
        '
        Me.chkIN.AutoSize = True
        Me.chkIN.Checked = True
        Me.chkIN.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkIN.Enabled = False
        Me.chkIN.Location = New System.Drawing.Point(865, 36)
        Me.chkIN.Name = "chkIN"
        Me.chkIN.Size = New System.Drawing.Size(56, 15)
        Me.chkIN.TabIndex = 249
        Me.chkIN.Text = "Actius"
        Me.chkIN.UseSelectable = True
        Me.chkIN.Visible = False
        '
        'txtDataOut
        '
        Me.txtDataOut.Enabled = False
        Me.txtDataOut.Location = New System.Drawing.Point(146, 169)
        Me.txtDataOut.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDataOut.MinimumSize = New System.Drawing.Size(0, 29)
        Me.txtDataOut.Name = "txtDataOut"
        Me.txtDataOut.Size = New System.Drawing.Size(340, 29)
        Me.txtDataOut.TabIndex = 5
        '
        'txtDataPublicacio
        '
        Me.txtDataPublicacio.Enabled = False
        Me.txtDataPublicacio.Location = New System.Drawing.Point(146, 129)
        Me.txtDataPublicacio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDataPublicacio.MinimumSize = New System.Drawing.Size(0, 29)
        Me.txtDataPublicacio.Name = "txtDataPublicacio"
        Me.txtDataPublicacio.Size = New System.Drawing.Size(261, 29)
        Me.txtDataPublicacio.TabIndex = 3
        '
        'txtHoraPublicacio
        '
        Me.txtHoraPublicacio.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtHoraPublicacio.Enabled = False
        Me.txtHoraPublicacio.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!)
        Me.txtHoraPublicacio.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.txtHoraPublicacio.Location = New System.Drawing.Point(414, 131)
        Me.txtHoraPublicacio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtHoraPublicacio.Name = "txtHoraPublicacio"
        Me.txtHoraPublicacio.ShowUpDown = True
        Me.txtHoraPublicacio.Size = New System.Drawing.Size(82, 25)
        Me.txtHoraPublicacio.TabIndex = 4
        Me.txtHoraPublicacio.Value = New Date(1970, 1, 1, 0, 0, 0, 0)
        '
        'lbDataCrea
        '
        Me.lbDataCrea.AutoSize = True
        Me.lbDataCrea.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lbDataCrea.Location = New System.Drawing.Point(147, 99)
        Me.lbDataCrea.Name = "lbDataCrea"
        Me.lbDataCrea.Size = New System.Drawing.Size(0, 0)
        Me.lbDataCrea.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(2, 209)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 25)
        Me.Label6.TabIndex = 230
        Me.Label6.Text = "Descripció:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 25)
        Me.Label8.TabIndex = 242
        Me.Label8.Text = "Data Creació:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbID
        '
        Me.lbID.AutoSize = True
        Me.lbID.BackColor = System.Drawing.Color.Transparent
        Me.lbID.Font = New System.Drawing.Font("Segoe UI Symbol", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbID.Location = New System.Drawing.Point(146, 7)
        Me.lbID.Name = "lbID"
        Me.lbID.Size = New System.Drawing.Size(14, 13)
        Me.lbID.TabIndex = 164
        Me.lbID.Text = "0"
        '
        'Label64
        '
        Me.Label64.BackColor = System.Drawing.Color.Transparent
        Me.Label64.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.Location = New System.Drawing.Point(2, 180)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(136, 25)
        Me.Label64.TabIndex = 228
        Me.Label64.Text = "Data Sortida:"
        Me.Label64.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(2, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 25)
        Me.Label5.TabIndex = 171
        Me.Label5.Text = "Data Publicacio:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbDurada
        '
        Me.lbDurada.AutoSize = True
        Me.lbDurada.BackColor = System.Drawing.Color.Transparent
        Me.lbDurada.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lbDurada.Location = New System.Drawing.Point(146, 67)
        Me.lbDurada.Name = "lbDurada"
        Me.lbDurada.Size = New System.Drawing.Size(65, 19)
        Me.lbDurada.TabIndex = 1
        Me.lbDurada.Text = "00:00:00"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(495, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 27)
        Me.Label2.TabIndex = 166
        Me.Label2.Text = "Tipus de fitxer:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label2.Visible = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(2, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 25)
        Me.Label4.TabIndex = 169
        Me.Label4.Text = "Durada:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(2, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 25)
        Me.Label3.TabIndex = 167
        Me.Label3.Text = "Fitxer:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tabControl1
        '
        Me.tabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabControl1.Controls.Add(Me.tabPage1)
        Me.tabControl1.Controls.Add(Me.tabPageFTP)
        Me.tabControl1.Location = New System.Drawing.Point(23, 111)
        Me.tabControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(979, 440)
        Me.tabControl1.TabIndex = 257
        Me.tabControl1.UseSelectable = True
        '
        'cmbProgrames
        '
        Me.cmbProgrames.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbProgrames.FormattingEnabled = True
        Me.cmbProgrames.Location = New System.Drawing.Point(510, 69)
        Me.cmbProgrames.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbProgrames.Name = "cmbProgrames"
        Me.cmbProgrames.Size = New System.Drawing.Size(224, 21)
        Me.cmbProgrames.TabIndex = 247
        '
        'lbIdTipus
        '
        Me.lbIdTipus.AutoSize = True
        Me.lbIdTipus.Location = New System.Drawing.Point(864, 111)
        Me.lbIdTipus.Name = "lbIdTipus"
        Me.lbIdTipus.Size = New System.Drawing.Size(13, 13)
        Me.lbIdTipus.TabIndex = 256
        Me.lbIdTipus.Text = "0"
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
        'lbRecCount
        '
        Me.lbRecCount.Name = "lbRecCount"
        Me.lbRecCount.Size = New System.Drawing.Size(13, 36)
        Me.lbRecCount.Text = "0"
        Me.lbRecCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(12, 36)
        Me.ToolStripLabel1.Text = "/"
        '
        'lbPosition
        '
        Me.lbPosition.Name = "lbPosition"
        Me.lbPosition.Size = New System.Drawing.Size(13, 36)
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
        Me.cmdPrevi.Text = "nterior"
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
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdPrimer, Me.cmdPrevi, Me.cmdSeguent, Me.cmdUltim, Me.lbPosition, Me.ToolStripLabel1, Me.lbRecCount, Me.ToolStripSeparator1, Me.cmdNou, Me.cmdBloqueix, Me.cmdBorrar, Me.cmdSalvar, Me.ToolStripSeparator2, Me.cmdRefrescar, Me.OptionBuscar, Me.cmdSortir, Me.lbVuMeter, Me.cmdStop, Me.cmdPlay, Me.lbNou})
        Me.ToolStrip1.Location = New System.Drawing.Point(20, 60)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(982, 39)
        Me.ToolStrip1.TabIndex = 250
        '
        'cmdBloqueix
        '
        Me.cmdBloqueix.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
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
        Me.OptionBuscar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFindOpcionsMare})
        Me.OptionBuscar.Image = CType(resources.GetObject("OptionBuscar.Image"), System.Drawing.Image)
        Me.OptionBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OptionBuscar.Name = "OptionBuscar"
        Me.OptionBuscar.Size = New System.Drawing.Size(45, 36)
        Me.OptionBuscar.Text = "Buscar"
        '
        'mnuFindOpcionsMare
        '
        Me.mnuFindOpcionsMare.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFindOpcions, Me.pendentsDePublicarToolStripMenuItem, Me.caducadesToolStripMenuItem})
        Me.mnuFindOpcionsMare.Name = "mnuFindOpcionsMare"
        Me.mnuFindOpcionsMare.Size = New System.Drawing.Size(118, 22)
        Me.mnuFindOpcionsMare.Text = "Opcions"
        '
        'mnuFindOpcions
        '
        Me.mnuFindOpcions.Name = "mnuFindOpcions"
        Me.mnuFindOpcions.Size = New System.Drawing.Size(185, 22)
        Me.mnuFindOpcions.Tag = "0"
        Me.mnuFindOpcions.Text = "Actuals"
        '
        'pendentsDePublicarToolStripMenuItem
        '
        Me.pendentsDePublicarToolStripMenuItem.Name = "pendentsDePublicarToolStripMenuItem"
        Me.pendentsDePublicarToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.pendentsDePublicarToolStripMenuItem.Tag = "1"
        Me.pendentsDePublicarToolStripMenuItem.Text = "Pendents de publicar"
        '
        'caducadesToolStripMenuItem
        '
        Me.caducadesToolStripMenuItem.Name = "caducadesToolStripMenuItem"
        Me.caducadesToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.caducadesToolStripMenuItem.Tag = "2"
        Me.caducadesToolStripMenuItem.Text = "Caducades"
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
        'lbVuMeter
        '
        Me.lbVuMeter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lbVuMeter.AutoSize = False
        Me.lbVuMeter.Name = "lbVuMeter"
        Me.lbVuMeter.Size = New System.Drawing.Size(100, 36)
        Me.lbVuMeter.Text = "ToolStripLabel2"
        '
        'cmdStop
        '
        Me.cmdStop.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.cmdStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdStop.Enabled = False
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
        Me.lbNou.Font = New System.Drawing.Font("Segoe UI Symbol", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNou.ForeColor = System.Drawing.Color.Red
        Me.lbNou.Name = "lbNou"
        Me.lbNou.Size = New System.Drawing.Size(70, 36)
        Me.lbNou.Text = "NOU"
        Me.lbNou.Visible = False
        '
        'mnu_Help
        '
        Me.mnu_Help.Image = CType(resources.GetObject("mnu_Help.Image"), System.Drawing.Image)
        Me.mnu_Help.Name = "mnu_Help"
        Me.mnu_Help.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.mnu_Help.Size = New System.Drawing.Size(174, 22)
        Me.mnu_Help.Text = "Manual OnLine"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_Help})
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(66, 20)
        Me.ToolStripMenuItem1.Text = "Ajuda"
        '
        'mnuEditAudio
        '
        Me.mnuEditAudio.Enabled = False
        Me.mnuEditAudio.Image = CType(resources.GetObject("mnuEditAudio.Image"), System.Drawing.Image)
        Me.mnuEditAudio.Name = "mnuEditAudio"
        Me.mnuEditAudio.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.mnuEditAudio.Size = New System.Drawing.Size(183, 22)
        Me.mnuEditAudio.Text = "Editar l'àudio"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(180, 6)
        '
        'mnuDel
        '
        Me.mnuDel.Enabled = False
        Me.mnuDel.Image = CType(resources.GetObject("mnuDel.Image"), System.Drawing.Image)
        Me.mnuDel.Name = "mnuDel"
        Me.mnuDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Delete), System.Windows.Forms.Keys)
        Me.mnuDel.Size = New System.Drawing.Size(183, 22)
        Me.mnuDel.Text = "Borrar"
        '
        'mnuNew
        '
        Me.mnuNew.Image = CType(resources.GetObject("mnuNew.Image"), System.Drawing.Image)
        Me.mnuNew.Name = "mnuNew"
        Me.mnuNew.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.mnuNew.Size = New System.Drawing.Size(183, 22)
        Me.mnuNew.Text = "Nou"
        '
        'mnuSave
        '
        Me.mnuSave.Enabled = False
        Me.mnuSave.Name = "mnuSave"
        Me.mnuSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuSave.Size = New System.Drawing.Size(183, 22)
        Me.mnuSave.Text = "Salvar"
        '
        'mnuModif
        '
        Me.mnuModif.Enabled = False
        Me.mnuModif.Name = "mnuModif"
        Me.mnuModif.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.mnuModif.Size = New System.Drawing.Size(183, 22)
        Me.mnuModif.Text = "Modificar"
        '
        'EdicióToolStripMenuItem
        '
        Me.EdicióToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuModif, Me.mnuSave, Me.mnuNew, Me.mnuDel, Me.ToolStripSeparator5, Me.mnuEditAudio})
        Me.EdicióToolStripMenuItem.Image = CType(resources.GetObject("EdicióToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EdicióToolStripMenuItem.Name = "EdicióToolStripMenuItem"
        Me.EdicióToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.EdicióToolStripMenuItem.Text = "Edició"
        '
        'mnuFinal
        '
        Me.mnuFinal.Name = "mnuFinal"
        Me.mnuFinal.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F9), System.Windows.Forms.Keys)
        Me.mnuFinal.Size = New System.Drawing.Size(204, 22)
        Me.mnuFinal.Tag = "3"
        Me.mnuFinal.Text = "Final Tema"
        '
        'mnuCalcDurada
        '
        Me.mnuCalcDurada.Enabled = False
        Me.mnuCalcDurada.Name = "mnuCalcDurada"
        Me.mnuCalcDurada.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F7), System.Windows.Forms.Keys)
        Me.mnuCalcDurada.Size = New System.Drawing.Size(204, 22)
        Me.mnuCalcDurada.Tag = "2"
        Me.mnuCalcDurada.Text = "Calcular Durada"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(201, 6)
        '
        'mnuStop
        '
        Me.mnuStop.Image = CType(resources.GetObject("mnuStop.Image"), System.Drawing.Image)
        Me.mnuStop.Name = "mnuStop"
        Me.mnuStop.ShortcutKeys = System.Windows.Forms.Keys.F7
        Me.mnuStop.Size = New System.Drawing.Size(204, 22)
        Me.mnuStop.Tag = "1"
        Me.mnuStop.Text = "Stop"
        '
        'mnuPlay
        '
        Me.mnuPlay.Image = CType(resources.GetObject("mnuPlay.Image"), System.Drawing.Image)
        Me.mnuPlay.Name = "mnuPlay"
        Me.mnuPlay.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.mnuPlay.Size = New System.Drawing.Size(204, 22)
        Me.mnuPlay.Tag = "0"
        Me.mnuPlay.Text = "Play/Pausa"
        '
        'ReproductorToolStripMenuItem
        '
        Me.ReproductorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPlay, Me.mnuStop, Me.ToolStripSeparator4, Me.mnuCalcDurada, Me.mnuFinal})
        Me.ReproductorToolStripMenuItem.Image = CType(resources.GetObject("ReproductorToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReproductorToolStripMenuItem.Name = "ReproductorToolStripMenuItem"
        Me.ReproductorToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.ReproductorToolStripMenuItem.Text = "Reproductor"
        '
        'mnuExit
        '
        Me.mnuExit.Image = CType(resources.GetObject("mnuExit.Image"), System.Drawing.Image)
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(102, 22)
        Me.mnuExit.Text = "Sortir"
        '
        'ProgarmaToolStripMenuItem
        '
        Me.ProgarmaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExit})
        Me.ProgarmaToolStripMenuItem.Image = CType(resources.GetObject("ProgarmaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ProgarmaToolStripMenuItem.Name = "ProgarmaToolStripMenuItem"
        Me.ProgarmaToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.ProgarmaToolStripMenuItem.Text = "Programa"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgarmaToolStripMenuItem, Me.ReproductorToolStripMenuItem, Me.EdicióToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(672, 30)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(330, 26)
        Me.MenuStrip1.TabIndex = 249
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'picPlay
        '
        Me.picPlay.ErrorImage = CType(resources.GetObject("picPlay.ErrorImage"), System.Drawing.Image)
        Me.picPlay.Image = CType(resources.GetObject("picPlay.Image"), System.Drawing.Image)
        Me.picPlay.Location = New System.Drawing.Point(685, 10)
        Me.picPlay.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picPlay.Name = "picPlay"
        Me.picPlay.Size = New System.Drawing.Size(19, 10)
        Me.picPlay.TabIndex = 254
        Me.picPlay.TabStop = False
        Me.picPlay.Visible = False
        '
        'picPause
        '
        Me.picPause.ErrorImage = CType(resources.GetObject("picPause.ErrorImage"), System.Drawing.Image)
        Me.picPause.Image = CType(resources.GetObject("picPause.Image"), System.Drawing.Image)
        Me.picPause.Location = New System.Drawing.Point(685, 28)
        Me.picPause.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picPause.Name = "picPause"
        Me.picPause.Size = New System.Drawing.Size(19, 16)
        Me.picPause.TabIndex = 255
        Me.picPause.TabStop = False
        Me.picPause.Visible = False
        '
        'tmrPlayer
        '
        Me.tmrPlayer.Interval = 25
        '
        'picVuMeter
        '
        Me.picVuMeter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picVuMeter.BackColor = System.Drawing.Color.Transparent
        Me.picVuMeter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picVuMeter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picVuMeter.Location = New System.Drawing.Point(865, 67)
        Me.picVuMeter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picVuMeter.Name = "picVuMeter"
        Me.picVuMeter.Size = New System.Drawing.Size(100, 26)
        Me.picVuMeter.TabIndex = 253
        Me.picVuMeter.TabStop = False
        '
        'picLock
        '
        Me.picLock.Image = CType(resources.GetObject("picLock.Image"), System.Drawing.Image)
        Me.picLock.Location = New System.Drawing.Point(526, 10)
        Me.picLock.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picLock.Name = "picLock"
        Me.picLock.Size = New System.Drawing.Size(45, 46)
        Me.picLock.TabIndex = 251
        Me.picLock.TabStop = False
        Me.picLock.Visible = False
        '
        'picUnLock
        '
        Me.picUnLock.Image = CType(resources.GetObject("picUnLock.Image"), System.Drawing.Image)
        Me.picUnLock.Location = New System.Drawing.Point(595, 10)
        Me.picUnLock.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picUnLock.Name = "picUnLock"
        Me.picUnLock.Size = New System.Drawing.Size(47, 44)
        Me.picUnLock.TabIndex = 252
        Me.picUnLock.TabStop = False
        Me.picUnLock.Visible = False
        '
        'cmdEnd
        '
        Me.cmdEnd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdEnd.Location = New System.Drawing.Point(1193, 72)
        Me.cmdEnd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdEnd.Name = "cmdEnd"
        Me.cmdEnd.Size = New System.Drawing.Size(21, 22)
        Me.cmdEnd.TabIndex = 248
        Me.cmdEnd.Text = "Button1"
        Me.cmdEnd.UseVisualStyleBackColor = True
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
        'frmPodcast
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdEnd
        Me.ClientSize = New System.Drawing.Size(1022, 575)
        Me.Controls.Add(Me.pic_logo)
        Me.Controls.Add(Me.picVuMeter)
        Me.Controls.Add(Me.cmbProgrames)
        Me.Controls.Add(Me.tabControl1)
        Me.Controls.Add(Me.lbIdTipus)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.picPlay)
        Me.Controls.Add(Me.picPause)
        Me.Controls.Add(Me.picLock)
        Me.Controls.Add(Me.picUnLock)
        Me.Controls.Add(Me.cmdEnd)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPodcast"
        Me.Text = "frmPodcast"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.toolStripFTPBotonera.ResumeLayout(False)
        Me.toolStripFTPBotonera.PerformLayout()
        CType(Me.dataGridViewRemote, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tableLayoutPanel2.ResumeLayout(False)
        CType(Me.dataGridViewLocal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tableLayoutPanel1.ResumeLayout(False)
        Me.splitContainer1.Panel1.ResumeLayout(False)
        Me.splitContainer1.Panel2.ResumeLayout(False)
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer1.ResumeLayout(False)
        Me.tabPageFTP.ResumeLayout(False)
        Me.tabPageFTP.PerformLayout()
        Me.tabPage1.ResumeLayout(False)
        Me.tabPage1.PerformLayout()
        CType(Me.gridDades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabControl1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picPlay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPause, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picVuMeter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUnLock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents mnuShowActuals As ToolStripMenuItem
    Private WithEvents mnuLlistar As ToolStripSplitButton
    Private WithEvents mnuShowAll As ToolStripMenuItem
    Private WithEvents mnuShowPendentPubli As ToolStripMenuItem
    Private WithEvents mnuShowCaduc As ToolStripMenuItem
    Private WithEvents mnuShowAllRemots As ToolStripMenuItem
    Private WithEvents limitDeRegistresToolStripMenuItem As ToolStripMenuItem
    Private WithEvents mnuLimit10 As ToolStripMenuItem
    Private WithEvents mnuLimit20 As ToolStripMenuItem
    Private WithEvents mnuLimit30 As ToolStripMenuItem
    Private WithEvents toolStripFTPBotonera As ToolStrip
    Private WithEvents cmbAnt As ToolStripButton
    Private WithEvents txtPostRecord As ToolStripLabel
    Private WithEvents cmbNext As ToolStripButton
    Private WithEvents toolStripSeparator3 As ToolStripSeparator
    Private WithEvents cmdConnectFTP As ToolStripButton
    Private WithEvents cmdDesConnectFTP As ToolStripButton
    Private WithEvents buttonExecTasquestFTP As ToolStripButton
    Friend WithEvents ColumnFTPPlay As DataGridViewButtonColumn
    Friend WithEvents ColumnFTPSize As DataGridViewTextBoxColumn
    Friend WithEvents ColumnFTPPath As DataGridViewTextBoxColumn
    Friend WithEvents ColumnFTPAction As DataGridViewComboBoxColumn
    Friend WithEvents ColumnFTPChk As DataGridViewCheckBoxColumn
    Friend WithEvents dataGridViewRemote As MetroFramework.Controls.MetroGrid
    Friend WithEvents ComboBoxTipus As ComboBox
    Friend WithEvents Label1 As Label
    Private WithEvents label10 As Label
    Private WithEvents tableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents ColumnLocalPlay As DataGridViewButtonColumn
    Friend WithEvents ColumnLocalNomFitxer As DataGridViewTextBoxColumn
    Friend WithEvents ColumnLocalSize As DataGridViewTextBoxColumn
    Friend WithEvents ColumnLocalDataIn As DataGridViewTextBoxColumn
    Friend WithEvents ColumnLocalPath As DataGridViewTextBoxColumn
    Friend WithEvents txtDecrip As TextBox
    Friend WithEvents ColumnLocalTipus As DataGridViewTextBoxColumn
    Friend WithEvents ColumnLocalNom As DataGridViewTextBoxColumn
    Friend WithEvents ColumnLocalID As DataGridViewTextBoxColumn
    Private WithEvents label9 As Label
    Friend WithEvents dataGridViewLocal As MetroFramework.Controls.MetroGrid
    Friend WithEvents ColumnLocalDataOut As DataGridViewTextBoxColumn
    Private WithEvents tableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label7 As Label
    Private WithEvents comboboxGeneralTaskServer As ComboBox
    Private WithEvents splitContainer1 As SplitContainer
    Private WithEvents lbNomFitxer As Label
    Private WithEvents lbFileName As Label
    Friend WithEvents ProgressBarFTP As MetroFramework.Controls.MetroProgressBar
    Friend WithEvents lbInfoFTP As MetroFramework.Controls.MetroLabel
    Friend WithEvents tabPageFTP As MetroFramework.Controls.MetroTabPage
    Friend WithEvents txtPartsProces As MetroFramework.Controls.MetroLabel
    Friend WithEvents tabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents gridDades As MetroFramework.Controls.MetroGrid
    Friend WithEvents chkIN As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents txtDataOut As MetroFramework.Controls.MetroDateTime
    Friend WithEvents txtDataPublicacio As MetroFramework.Controls.MetroDateTime
    Friend WithEvents txtHoraPublicacio As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbID As Label
    Friend WithEvents Label64 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tabControl1 As MetroFramework.Controls.MetroTabControl
    Private WithEvents cmbProgrames As ComboBox
    Friend WithEvents lbIdTipus As Label
    Friend WithEvents cmdNou As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents lbRecCount As ToolStripLabel
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents lbPosition As ToolStripLabel
    Friend WithEvents cmdUltim As ToolStripButton
    Friend WithEvents cmdSeguent As ToolStripButton
    Friend WithEvents cmdPrevi As ToolStripButton
    Friend WithEvents cmdPrimer As ToolStripButton
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents cmdBloqueix As ToolStripButton
    Friend WithEvents cmdBorrar As ToolStripButton
    Friend WithEvents cmdSalvar As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents cmdRefrescar As ToolStripButton
    Friend WithEvents OptionBuscar As ToolStripDropDownButton
    Private WithEvents mnuFindOpcionsMare As ToolStripMenuItem
    Private WithEvents mnuFindOpcions As ToolStripMenuItem
    Private WithEvents pendentsDePublicarToolStripMenuItem As ToolStripMenuItem
    Private WithEvents caducadesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmdSortir As ToolStripButton
    Friend WithEvents lbVuMeter As ToolStripLabel
    Friend WithEvents cmdStop As ToolStripButton
    Friend WithEvents cmdPlay As ToolStripButton
    Friend WithEvents lbNou As ToolStripLabel
    Public WithEvents mnu_Help As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents mnuEditAudio As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents mnuDel As ToolStripMenuItem
    Friend WithEvents mnuNew As ToolStripMenuItem
    Friend WithEvents mnuSave As ToolStripMenuItem
    Friend WithEvents mnuModif As ToolStripMenuItem
    Friend WithEvents EdicióToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuFinal As ToolStripMenuItem
    Friend WithEvents mnuCalcDurada As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents mnuStop As ToolStripMenuItem
    Friend WithEvents mnuPlay As ToolStripMenuItem
    Friend WithEvents ReproductorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents ProgarmaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents picPlay As PictureBox
    Friend WithEvents picPause As PictureBox
    Friend WithEvents tmrPlayer As Timer
    Friend WithEvents picVuMeter As PictureBox
    Friend WithEvents picLock As PictureBox
    Friend WithEvents picUnLock As PictureBox
    Friend WithEvents cmdEnd As Button
    Friend WithEvents ColumnID As DataGridViewTextBoxColumn
    Friend WithEvents ColumnTipus As DataGridViewTextBoxColumn
    Friend WithEvents ColumnOrigen As DataGridViewTextBoxColumn
    Friend WithEvents ColumnDurada As DataGridViewTextBoxColumn
    Friend WithEvents ColumnDataCrea As DataGridViewTextBoxColumn
    Friend WithEvents ColumnDataPubli As DataGridViewTextBoxColumn
    Friend WithEvents ColumnDataOut As DataGridViewTextBoxColumn
    Friend WithEvents ColumnDescrip As DataGridViewTextBoxColumn
    Friend WithEvents ColumnPlayers As DataGridViewTextBoxColumn
    Friend WithEvents ColumnFile As DataGridViewTextBoxColumn
    Friend WithEvents lbDataCrea As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbDurada As MetroFramework.Controls.MetroLabel
    Friend WithEvents cmbFitxer As ComboBox
    Friend WithEvents pic_logo As PictureBox
End Class
