<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCtlRadia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCtlRadia))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lbAltres = New System.Windows.Forms.Label()
        Me.lbPrg = New System.Windows.Forms.Label()
        Me.lbMusic = New System.Windows.Forms.Label()
        Me.lbPubli = New System.Windows.Forms.Label()
        Me.lbRecCound = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.cmdSortir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.cmdStop = New System.Windows.Forms.ToolStripButton()
        Me.cmdPlay = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.cmdBuscar = New System.Windows.Forms.ToolStripSplitButton()
        Me.mnuBuscaOpcions = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEstadistica = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdPrint = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.cmdBorrar = New System.Windows.Forms.ToolStripButton()
        Me.txtDataInBar = New System.Windows.Forms.DateTimePicker()
        Me.txtDataDel = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbAudioFiles = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBoxArxius = New System.Windows.Forms.GroupBox()
        Me.chkFilesUser = New MetroFramework.Controls.MetroCheckBox()
        Me.chkControl = New MetroFramework.Controls.MetroCheckBox()
        Me.chkSistema = New MetroFramework.Controls.MetroCheckBox()
        Me.chkProgram = New MetroFramework.Controls.MetroCheckBox()
        Me.chkPubli = New MetroFramework.Controls.MetroCheckBox()
        Me.chkMusic = New MetroFramework.Controls.MetroCheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chk_Col_7 = New MetroFramework.Controls.MetroCheckBox()
        Me.chk_Col_6 = New MetroFramework.Controls.MetroCheckBox()
        Me.chk_Col_5 = New MetroFramework.Controls.MetroCheckBox()
        Me.chk_Col_4 = New MetroFramework.Controls.MetroCheckBox()
        Me.chk_Col_3 = New MetroFramework.Controls.MetroCheckBox()
        Me.chk_Col_0 = New MetroFramework.Controls.MetroCheckBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.txtDataOut = New MetroFramework.Controls.MetroDateTime()
        Me.txtDataIn = New MetroFramework.Controls.MetroDateTime()
        Me.cmdConsulta = New MetroFramework.Controls.MetroTile()
        Me.ChkTots = New MetroFramework.Controls.MetroCheckBox()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.DataGridViewHistorial = New MetroFramework.Controls.MetroGrid()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnImage = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ColumnTFitxer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnDataRadi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnUser = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ColumnPauta = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ColumnPlay = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ColumnEdit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.picPlay = New System.Windows.Forms.PictureBox()
        Me.picPause = New System.Windows.Forms.PictureBox()
        Me.tmrPlayer = New System.Windows.Forms.Timer(Me.components)
        Me.picVuMeter = New System.Windows.Forms.PictureBox()
        Me.imgListMnu = New System.Windows.Forms.ImageList(Me.components)
        Me.pic_logo = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBoxArxius.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.DataGridViewHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPause, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picVuMeter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbAltres
        '
        Me.lbAltres.AutoSize = True
        Me.lbAltres.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAltres.Location = New System.Drawing.Point(734, 64)
        Me.lbAltres.Name = "lbAltres"
        Me.lbAltres.Size = New System.Drawing.Size(14, 13)
        Me.lbAltres.TabIndex = 13
        Me.lbAltres.Text = "0"
        '
        'lbPrg
        '
        Me.lbPrg.AutoSize = True
        Me.lbPrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPrg.Location = New System.Drawing.Point(488, 64)
        Me.lbPrg.Name = "lbPrg"
        Me.lbPrg.Size = New System.Drawing.Size(14, 13)
        Me.lbPrg.TabIndex = 12
        Me.lbPrg.Text = "0"
        '
        'lbMusic
        '
        Me.lbMusic.AutoSize = True
        Me.lbMusic.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMusic.Location = New System.Drawing.Point(489, 27)
        Me.lbMusic.Name = "lbMusic"
        Me.lbMusic.Size = New System.Drawing.Size(14, 13)
        Me.lbMusic.TabIndex = 11
        Me.lbMusic.Text = "0"
        '
        'lbPubli
        '
        Me.lbPubli.AutoSize = True
        Me.lbPubli.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPubli.Location = New System.Drawing.Point(242, 64)
        Me.lbPubli.Name = "lbPubli"
        Me.lbPubli.Size = New System.Drawing.Size(14, 13)
        Me.lbPubli.TabIndex = 8
        Me.lbPubli.Text = "0"
        '
        'lbRecCound
        '
        Me.lbRecCound.AutoSize = True
        Me.lbRecCound.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRecCound.Location = New System.Drawing.Point(243, 27)
        Me.lbRecCound.Name = "lbRecCound"
        Me.lbRecCound.Size = New System.Drawing.Size(14, 13)
        Me.lbRecCound.TabIndex = 7
        Me.lbRecCound.Text = "0"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(618, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(113, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Nº Altres:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(331, 64)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(142, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Nº de Programes:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(328, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Nº de Cançons:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(60, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nº de Falques Publi.:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(83, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nº de registres:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Image = CType(resources.GetObject("cmdExit.Image"), System.Drawing.Image)
        Me.cmdExit.Location = New System.Drawing.Point(885, 95)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(21, 22)
        Me.cmdExit.TabIndex = 6
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ImageList.Images.SetKeyName(0, "controllerNoConnect.gif")
        Me.ImageList.Images.SetKeyName(1, "promo")
        Me.ImageList.Images.SetKeyName(2, "music")
        Me.ImageList.Images.SetKeyName(3, "publi")
        Me.ImageList.Images.SetKeyName(4, "jingel")
        Me.ImageList.Images.SetKeyName(5, "program")
        Me.ImageList.Images.SetKeyName(6, "users.ico")
        Me.ImageList.Images.SetKeyName(7, "controlerSiConnect.ico")
        Me.ImageList.Images.SetKeyName(8, "params.gif")
        Me.ImageList.Images.SetKeyName(9, "sound.png")
        Me.ImageList.Images.SetKeyName(10, "warning.png")
        Me.ImageList.Images.SetKeyName(11, "stop.png")
        Me.ImageList.Images.SetKeyName(12, "rss.png")
        Me.ImageList.Images.SetKeyName(13, "code.png")
        Me.ImageList.Images.SetKeyName(14, "thumbtack.png")
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdSortir, Me.ToolStripButton1, Me.ToolStripLabel2, Me.cmdStop, Me.cmdPlay, Me.ToolStripLabel1, Me.ToolStripLabel3, Me.cmdBuscar, Me.ToolStripSeparator1, Me.cmdPrint, Me.ToolStripSeparator2, Me.ToolStripLabel4, Me.ToolStripLabel5, Me.cmdBorrar})
        Me.ToolStrip1.Location = New System.Drawing.Point(20, 60)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(982, 39)
        Me.ToolStrip1.TabIndex = 65
        Me.ToolStrip1.Text = "ToolStrip1"
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
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel2.AutoSize = False
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(95, 36)
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
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.AutoSize = False
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(70, 36)
        Me.ToolStripLabel1.Text = "Fecha Inicio"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.AutoSize = False
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(185, 36)
        '
        'cmdBuscar
        '
        Me.cmdBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdBuscar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBuscaOpcions, Me.mnuEstadistica})
        Me.cmdBuscar.Image = CType(resources.GetObject("cmdBuscar.Image"), System.Drawing.Image)
        Me.cmdBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(48, 36)
        Me.cmdBuscar.Text = "Buscar"
        '
        'mnuBuscaOpcions
        '
        Me.mnuBuscaOpcions.Name = "mnuBuscaOpcions"
        Me.mnuBuscaOpcions.Size = New System.Drawing.Size(130, 22)
        Me.mnuBuscaOpcions.Text = "Opcions ..."
        '
        'mnuEstadistica
        '
        Me.mnuEstadistica.Name = "mnuEstadistica"
        Me.mnuEstadistica.Size = New System.Drawing.Size(130, 22)
        Me.mnuEstadistica.Text = "Estadística"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'cmdPrint
        '
        Me.cmdPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdPrint.Enabled = False
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
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.AutoSize = False
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(97, 36)
        Me.ToolStripLabel4.Text = "Borrar anteriores a"
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.AutoSize = False
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(85, 36)
        '
        'cmdBorrar
        '
        Me.cmdBorrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdBorrar.Image = CType(resources.GetObject("cmdBorrar.Image"), System.Drawing.Image)
        Me.cmdBorrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(36, 36)
        Me.cmdBorrar.Text = "Borrar"
        Me.cmdBorrar.ToolTipText = "Borrar historial"
        '
        'txtDataInBar
        '
        Me.txtDataInBar.Location = New System.Drawing.Point(106, 70)
        Me.txtDataInBar.Name = "txtDataInBar"
        Me.txtDataInBar.Size = New System.Drawing.Size(175, 20)
        Me.txtDataInBar.TabIndex = 0
        '
        'txtDataDel
        '
        Me.txtDataDel.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDataDel.Location = New System.Drawing.Point(481, 70)
        Me.txtDataDel.Name = "txtDataDel"
        Me.txtDataDel.Size = New System.Drawing.Size(80, 20)
        Me.txtDataDel.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbAudioFiles)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lbAltres)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.lbPrg)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lbMusic)
        Me.GroupBox1.Controls.Add(Me.lbRecCound)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.lbPubli)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Symbol", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(150, 46)
        Me.GroupBox1.TabIndex = 68
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Estadística"
        '
        'lbAudioFiles
        '
        Me.lbAudioFiles.AutoSize = True
        Me.lbAudioFiles.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAudioFiles.Location = New System.Drawing.Point(734, 27)
        Me.lbAudioFiles.Name = "lbAudioFiles"
        Me.lbAudioFiles.Size = New System.Drawing.Size(14, 13)
        Me.lbAudioFiles.TabIndex = 15
        Me.lbAudioFiles.Text = "0"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(615, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Nº Audio Files:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(75, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Llistar de ..."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(359, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "fins a ..."
        '
        'GroupBoxArxius
        '
        Me.GroupBoxArxius.Controls.Add(Me.chkFilesUser)
        Me.GroupBoxArxius.Controls.Add(Me.chkControl)
        Me.GroupBoxArxius.Controls.Add(Me.chkSistema)
        Me.GroupBoxArxius.Controls.Add(Me.chkProgram)
        Me.GroupBoxArxius.Controls.Add(Me.chkPubli)
        Me.GroupBoxArxius.Controls.Add(Me.chkMusic)
        Me.GroupBoxArxius.Enabled = False
        Me.GroupBoxArxius.Location = New System.Drawing.Point(78, 55)
        Me.GroupBoxArxius.Name = "GroupBoxArxius"
        Me.GroupBoxArxius.Size = New System.Drawing.Size(669, 45)
        Me.GroupBoxArxius.TabIndex = 4
        Me.GroupBoxArxius.TabStop = False
        Me.GroupBoxArxius.Text = "filtrar ..."
        '
        'chkFilesUser
        '
        Me.chkFilesUser.AutoSize = True
        Me.chkFilesUser.Checked = True
        Me.chkFilesUser.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFilesUser.Location = New System.Drawing.Point(342, 19)
        Me.chkFilesUser.Name = "chkFilesUser"
        Me.chkFilesUser.Size = New System.Drawing.Size(93, 15)
        Me.chkFilesUser.TabIndex = 11
        Me.chkFilesUser.Text = "Fitxers Usuari"
        Me.chkFilesUser.UseSelectable = True
        '
        'chkControl
        '
        Me.chkControl.AutoSize = True
        Me.chkControl.Checked = True
        Me.chkControl.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkControl.Location = New System.Drawing.Point(585, 19)
        Me.chkControl.Name = "chkControl"
        Me.chkControl.Size = New System.Drawing.Size(63, 15)
        Me.chkControl.TabIndex = 13
        Me.chkControl.Text = "Control"
        Me.chkControl.UseSelectable = True
        '
        'chkSistema
        '
        Me.chkSistema.AutoSize = True
        Me.chkSistema.Checked = True
        Me.chkSistema.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSistema.Location = New System.Drawing.Point(478, 19)
        Me.chkSistema.Name = "chkSistema"
        Me.chkSistema.Size = New System.Drawing.Size(64, 15)
        Me.chkSistema.TabIndex = 12
        Me.chkSistema.Text = "Sistema"
        Me.chkSistema.UseSelectable = True
        '
        'chkProgram
        '
        Me.chkProgram.AutoSize = True
        Me.chkProgram.Checked = True
        Me.chkProgram.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkProgram.Location = New System.Drawing.Point(234, 19)
        Me.chkProgram.Name = "chkProgram"
        Me.chkProgram.Size = New System.Drawing.Size(80, 15)
        Me.chkProgram.TabIndex = 10
        Me.chkProgram.Text = "Programes"
        Me.chkProgram.UseSelectable = True
        '
        'chkPubli
        '
        Me.chkPubli.AutoSize = True
        Me.chkPubli.Checked = True
        Me.chkPubli.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPubli.Location = New System.Drawing.Point(118, 19)
        Me.chkPubli.Name = "chkPubli"
        Me.chkPubli.Size = New System.Drawing.Size(73, 15)
        Me.chkPubli.TabIndex = 9
        Me.chkPubli.Text = "Publicitat"
        Me.chkPubli.UseSelectable = True
        '
        'chkMusic
        '
        Me.chkMusic.AutoSize = True
        Me.chkMusic.Checked = True
        Me.chkMusic.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMusic.Location = New System.Drawing.Point(14, 19)
        Me.chkMusic.Name = "chkMusic"
        Me.chkMusic.Size = New System.Drawing.Size(61, 15)
        Me.chkMusic.TabIndex = 8
        Me.chkMusic.Text = "Música"
        Me.chkMusic.UseSelectable = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chk_Col_7)
        Me.GroupBox2.Controls.Add(Me.chk_Col_6)
        Me.GroupBox2.Controls.Add(Me.chk_Col_5)
        Me.GroupBox2.Controls.Add(Me.chk_Col_4)
        Me.GroupBox2.Controls.Add(Me.chk_Col_3)
        Me.GroupBox2.Controls.Add(Me.chk_Col_0)
        Me.GroupBox2.Location = New System.Drawing.Point(78, 106)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(669, 44)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Columnes Visibles"
        '
        'chk_Col_7
        '
        Me.chk_Col_7.AutoSize = True
        Me.chk_Col_7.Checked = True
        Me.chk_Col_7.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Col_7.Location = New System.Drawing.Point(426, 19)
        Me.chk_Col_7.Name = "chk_Col_7"
        Me.chk_Col_7.Size = New System.Drawing.Size(56, 15)
        Me.chk_Col_7.TabIndex = 20
        Me.chk_Col_7.Tag = "12"
        Me.chk_Col_7.Text = "Usuari"
        Me.chk_Col_7.UseSelectable = True
        '
        'chk_Col_6
        '
        Me.chk_Col_6.AutoSize = True
        Me.chk_Col_6.Checked = True
        Me.chk_Col_6.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Col_6.Location = New System.Drawing.Point(329, 19)
        Me.chk_Col_6.Name = "chk_Col_6"
        Me.chk_Col_6.Size = New System.Drawing.Size(81, 15)
        Me.chk_Col_6.TabIndex = 19
        Me.chk_Col_6.Tag = "11"
        Me.chk_Col_6.Text = "Rec. Count"
        Me.chk_Col_6.UseSelectable = True
        '
        'chk_Col_5
        '
        Me.chk_Col_5.AutoSize = True
        Me.chk_Col_5.Checked = True
        Me.chk_Col_5.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Col_5.Location = New System.Drawing.Point(242, 19)
        Me.chk_Col_5.Name = "chk_Col_5"
        Me.chk_Col_5.Size = New System.Drawing.Size(72, 15)
        Me.chk_Col_5.TabIndex = 18
        Me.chk_Col_5.Tag = "10"
        Me.chk_Col_5.Text = "Tmp Max"
        Me.chk_Col_5.UseSelectable = True
        '
        'chk_Col_4
        '
        Me.chk_Col_4.AutoSize = True
        Me.chk_Col_4.Checked = True
        Me.chk_Col_4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Col_4.Location = New System.Drawing.Point(163, 19)
        Me.chk_Col_4.Name = "chk_Col_4"
        Me.chk_Col_4.Size = New System.Drawing.Size(63, 15)
        Me.chk_Col_4.TabIndex = 17
        Me.chk_Col_4.Tag = "9"
        Me.chk_Col_4.Text = "N. Error"
        Me.chk_Col_4.UseSelectable = True
        '
        'chk_Col_3
        '
        Me.chk_Col_3.AutoSize = True
        Me.chk_Col_3.Checked = True
        Me.chk_Col_3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Col_3.Location = New System.Drawing.Point(85, 19)
        Me.chk_Col_3.Name = "chk_Col_3"
        Me.chk_Col_3.Size = New System.Drawing.Size(61, 15)
        Me.chk_Col_3.TabIndex = 16
        Me.chk_Col_3.Tag = "8"
        Me.chk_Col_3.Text = "N. Bloc"
        Me.chk_Col_3.UseSelectable = True
        '
        'chk_Col_0
        '
        Me.chk_Col_0.AutoSize = True
        Me.chk_Col_0.Checked = True
        Me.chk_Col_0.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Col_0.Location = New System.Drawing.Point(14, 19)
        Me.chk_Col_0.Name = "chk_Col_0"
        Me.chk_Col_0.Size = New System.Drawing.Size(51, 15)
        Me.chk_Col_0.TabIndex = 15
        Me.chk_Col_0.Tag = "0"
        Me.chk_Col_0.Text = "Típus"
        Me.chk_Col_0.UseSelectable = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(20, 99)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtDataOut)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtDataIn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdConsulta)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ChkTots)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label11)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label12)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBoxArxius)
        Me.SplitContainer1.Panel1Collapsed = True
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(982, 456)
        Me.SplitContainer1.SplitterDistance = 156
        Me.SplitContainer1.TabIndex = 69
        '
        'txtDataOut
        '
        Me.txtDataOut.Location = New System.Drawing.Point(420, 8)
        Me.txtDataOut.MinimumSize = New System.Drawing.Size(4, 29)
        Me.txtDataOut.Name = "txtDataOut"
        Me.txtDataOut.Size = New System.Drawing.Size(200, 29)
        Me.txtDataOut.TabIndex = 10
        '
        'txtDataIn
        '
        Me.txtDataIn.Location = New System.Drawing.Point(142, 8)
        Me.txtDataIn.MinimumSize = New System.Drawing.Size(4, 29)
        Me.txtDataIn.Name = "txtDataIn"
        Me.txtDataIn.Size = New System.Drawing.Size(200, 29)
        Me.txtDataIn.TabIndex = 9
        '
        'cmdConsulta
        '
        Me.cmdConsulta.ActiveControl = Nothing
        Me.cmdConsulta.Location = New System.Drawing.Point(626, 8)
        Me.cmdConsulta.Name = "cmdConsulta"
        Me.cmdConsulta.Size = New System.Drawing.Size(121, 37)
        Me.cmdConsulta.TabIndex = 8
        Me.cmdConsulta.TileImage = CType(resources.GetObject("cmdConsulta.TileImage"), System.Drawing.Image)
        Me.cmdConsulta.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdConsulta.UseSelectable = True
        Me.cmdConsulta.UseTileImage = True
        '
        'ChkTots
        '
        Me.ChkTots.AutoSize = True
        Me.ChkTots.Checked = True
        Me.ChkTots.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkTots.Location = New System.Drawing.Point(92, 38)
        Me.ChkTots.Name = "ChkTots"
        Me.ChkTots.Size = New System.Drawing.Size(138, 15)
        Me.ChkTots.TabIndex = 7
        Me.ChkTots.Text = "Mostrar tots els arxius"
        Me.ChkTots.UseSelectable = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.DataGridViewHistorial)
        Me.SplitContainer2.Panel1.Controls.Add(Me.picPlay)
        Me.SplitContainer2.Panel1.Controls.Add(Me.picPause)
        Me.SplitContainer2.Panel1.Controls.Add(Me.cmdExit)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer2.Panel2Collapsed = True
        Me.SplitContainer2.Size = New System.Drawing.Size(982, 456)
        Me.SplitContainer2.SplitterDistance = 354
        Me.SplitContainer2.TabIndex = 69
        '
        'DataGridViewHistorial
        '
        Me.DataGridViewHistorial.AllowUserToAddRows = False
        Me.DataGridViewHistorial.AllowUserToDeleteRows = False
        Me.DataGridViewHistorial.AllowUserToResizeRows = False
        Me.DataGridViewHistorial.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridViewHistorial.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridViewHistorial.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridViewHistorial.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewHistorial.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewHistorial.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.ColumnImage, Me.ColumnTFitxer, Me.ColumnID, Me.Column4, Me.ColumnDataRadi, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.ColumnUser, Me.ColumnPauta, Me.ColumnPlay, Me.ColumnEdit})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewHistorial.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewHistorial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewHistorial.EnableHeadersVisualStyles = False
        Me.DataGridViewHistorial.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.DataGridViewHistorial.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridViewHistorial.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewHistorial.Name = "DataGridViewHistorial"
        Me.DataGridViewHistorial.ReadOnly = True
        Me.DataGridViewHistorial.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewHistorial.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewHistorial.RowHeadersVisible = False
        Me.DataGridViewHistorial.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridViewHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewHistorial.Size = New System.Drawing.Size(982, 456)
        Me.DataGridViewHistorial.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "ctl_id"
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        Me.Column1.Width = 40
        '
        'ColumnImage
        '
        Me.ColumnImage.HeaderText = "Tipus"
        Me.ColumnImage.Name = "ColumnImage"
        Me.ColumnImage.ReadOnly = True
        Me.ColumnImage.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColumnImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ColumnImage.Width = 40
        '
        'ColumnTFitxer
        '
        Me.ColumnTFitxer.DataPropertyName = "ctl_tipfitxer"
        Me.ColumnTFitxer.HeaderText = "T.Fitxer"
        Me.ColumnTFitxer.Name = "ColumnTFitxer"
        Me.ColumnTFitxer.ReadOnly = True
        Me.ColumnTFitxer.Visible = False
        '
        'ColumnID
        '
        Me.ColumnID.DataPropertyName = "ctl_fitxer"
        Me.ColumnID.HeaderText = "ID Fitxer"
        Me.ColumnID.Name = "ColumnID"
        Me.ColumnID.ReadOnly = True
        Me.ColumnID.Visible = False
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.DataPropertyName = "ctl_fitxerstr"
        Me.Column4.HeaderText = "Nom"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'ColumnDataRadi
        '
        Me.ColumnDataRadi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnDataRadi.DataPropertyName = "ctl_dataradiacio"
        Me.ColumnDataRadi.HeaderText = "Data Radiació"
        Me.ColumnDataRadi.Name = "ColumnDataRadi"
        Me.ColumnDataRadi.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "ctl_numbloc"
        Me.Column6.HeaderText = "N. Bloc"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "ctl_nivellerr"
        Me.Column7.HeaderText = "N. Error"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "ctl_maxtemps"
        Me.Column8.HeaderText = "Tmp Max"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "ctl_reccount"
        Me.Column9.HeaderText = "Rec. Count"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'ColumnUser
        '
        Me.ColumnUser.DataPropertyName = "ctl_usr"
        Me.ColumnUser.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.ColumnUser.HeaderText = "Usuari"
        Me.ColumnUser.Name = "ColumnUser"
        Me.ColumnUser.ReadOnly = True
        '
        'ColumnPauta
        '
        Me.ColumnPauta.DataPropertyName = "ctl_pauta"
        Me.ColumnPauta.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.ColumnPauta.HeaderText = "Pauta"
        Me.ColumnPauta.Name = "ColumnPauta"
        Me.ColumnPauta.ReadOnly = True
        '
        'ColumnPlay
        '
        Me.ColumnPlay.HeaderText = "Play"
        Me.ColumnPlay.Name = "ColumnPlay"
        Me.ColumnPlay.ReadOnly = True
        Me.ColumnPlay.Text = "Play"
        Me.ColumnPlay.Width = 40
        '
        'ColumnEdit
        '
        Me.ColumnEdit.HeaderText = "Editar"
        Me.ColumnEdit.Name = "ColumnEdit"
        Me.ColumnEdit.ReadOnly = True
        Me.ColumnEdit.Text = "Edit"
        Me.ColumnEdit.Width = 40
        '
        'picPlay
        '
        Me.picPlay.ErrorImage = CType(resources.GetObject("picPlay.ErrorImage"), System.Drawing.Image)
        Me.picPlay.Image = CType(resources.GetObject("picPlay.Image"), System.Drawing.Image)
        Me.picPlay.Location = New System.Drawing.Point(762, 421)
        Me.picPlay.Name = "picPlay"
        Me.picPlay.Size = New System.Drawing.Size(16, 15)
        Me.picPlay.TabIndex = 193
        Me.picPlay.TabStop = False
        Me.picPlay.Visible = False
        '
        'picPause
        '
        Me.picPause.ErrorImage = CType(resources.GetObject("picPause.ErrorImage"), System.Drawing.Image)
        Me.picPause.Image = CType(resources.GetObject("picPause.Image"), System.Drawing.Image)
        Me.picPause.Location = New System.Drawing.Point(762, 450)
        Me.picPause.Name = "picPause"
        Me.picPause.Size = New System.Drawing.Size(16, 14)
        Me.picPause.TabIndex = 194
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
        Me.picVuMeter.Location = New System.Drawing.Point(865, 68)
        Me.picVuMeter.Name = "picVuMeter"
        Me.picVuMeter.Size = New System.Drawing.Size(95, 25)
        Me.picVuMeter.TabIndex = 195
        Me.picVuMeter.TabStop = False
        '
        'imgListMnu
        '
        Me.imgListMnu.ImageStream = CType(resources.GetObject("imgListMnu.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgListMnu.TransparentColor = System.Drawing.Color.Transparent
        Me.imgListMnu.Images.SetKeyName(0, "file-import.png")
        Me.imgListMnu.Images.SetKeyName(1, "headphones.png")
        Me.imgListMnu.Images.SetKeyName(2, "stop-circle.png")
        Me.imgListMnu.Images.SetKeyName(3, "music-r.png")
        Me.imgListMnu.Images.SetKeyName(4, "music.png")
        Me.imgListMnu.Images.SetKeyName(5, "microphone.png")
        Me.imgListMnu.Images.SetKeyName(6, "thumbtack.png")
        Me.imgListMnu.Images.SetKeyName(7, "money-bill-wave.png")
        Me.imgListMnu.Images.SetKeyName(8, "calendar-alt-r.png")
        Me.imgListMnu.Images.SetKeyName(9, "print.png")
        Me.imgListMnu.Images.SetKeyName(10, "alarm-clock.png")
        Me.imgListMnu.Images.SetKeyName(11, "file-audio.png")
        Me.imgListMnu.Images.SetKeyName(12, "cog-solid.png")
        Me.imgListMnu.Images.SetKeyName(13, "calendar-alt.png")
        Me.imgListMnu.Images.SetKeyName(14, "calendar-alt-r.png")
        Me.imgListMnu.Images.SetKeyName(15, "calendar-alt.png")
        Me.imgListMnu.Images.SetKeyName(16, "broadcast-tower.png")
        Me.imgListMnu.Images.SetKeyName(17, "power-off.png")
        Me.imgListMnu.Images.SetKeyName(18, "info.png")
        Me.imgListMnu.Images.SetKeyName(19, "bullhorn.png")
        Me.imgListMnu.Images.SetKeyName(20, "file-audio_blue.png")
        Me.imgListMnu.Images.SetKeyName(21, "file-audio_green.png")
        Me.imgListMnu.Images.SetKeyName(22, "file-audio_orange.png")
        Me.imgListMnu.Images.SetKeyName(23, "microphone_blue.png")
        Me.imgListMnu.Images.SetKeyName(24, "microphone_green.png")
        Me.imgListMnu.Images.SetKeyName(25, "microphone_orange.png")
        Me.imgListMnu.Images.SetKeyName(26, "music_blue.png")
        Me.imgListMnu.Images.SetKeyName(27, "music_green.png")
        Me.imgListMnu.Images.SetKeyName(28, "music_orange.png")
        Me.imgListMnu.Images.SetKeyName(29, "speaker_blue.png")
        Me.imgListMnu.Images.SetKeyName(30, "speaker_green.png")
        Me.imgListMnu.Images.SetKeyName(31, "speaker_orange.png")
        '
        'pic_logo
        '
        Me.pic_logo.Image = CType(resources.GetObject("pic_logo.Image"), System.Drawing.Image)
        Me.pic_logo.Location = New System.Drawing.Point(25, 23)
        Me.pic_logo.Name = "pic_logo"
        Me.pic_logo.Size = New System.Drawing.Size(40, 40)
        Me.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_logo.TabIndex = 266
        Me.pic_logo.TabStop = False
        '
        'frmCtlRadia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(1022, 575)
        Me.Controls.Add(Me.pic_logo)
        Me.Controls.Add(Me.picVuMeter)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.txtDataDel)
        Me.Controls.Add(Me.txtDataInBar)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(806, 573)
        Me.Name = "frmCtlRadia"
        Me.Text = "Control de radiació"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBoxArxius.ResumeLayout(False)
        Me.GroupBoxArxius.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.DataGridViewHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPause, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picVuMeter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbAltres As System.Windows.Forms.Label
    Friend WithEvents lbPrg As System.Windows.Forms.Label
    Friend WithEvents lbMusic As System.Windows.Forms.Label
    Friend WithEvents lbPubli As System.Windows.Forms.Label
    Friend WithEvents lbRecCound As System.Windows.Forms.Label
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Public WithEvents ImageList As System.Windows.Forms.ImageList
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdBorrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdSortir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmdPlay As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdStop As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtDataInBar As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDataDel As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel5 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBoxArxius As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents cmdBuscar As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents mnuBuscaOpcions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEstadistica As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents tmrPlayer As System.Windows.Forms.Timer
    Friend WithEvents picPlay As System.Windows.Forms.PictureBox
    Friend WithEvents picPause As System.Windows.Forms.PictureBox
    Friend WithEvents picVuMeter As System.Windows.Forms.PictureBox
    Friend WithEvents ChkTots As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents cmdConsulta As MetroFramework.Controls.MetroTile
    Friend WithEvents chkControl As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chkSistema As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chkProgram As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chkPubli As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chkMusic As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chk_Col_7 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chk_Col_6 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chk_Col_5 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chk_Col_4 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chk_Col_3 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chk_Col_0 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents txtDataOut As MetroFramework.Controls.MetroDateTime
    Friend WithEvents txtDataIn As MetroFramework.Controls.MetroDateTime
    Friend WithEvents DataGridViewHistorial As MetroFramework.Controls.MetroGrid
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents ColumnImage As DataGridViewImageColumn
    Friend WithEvents ColumnTFitxer As DataGridViewTextBoxColumn
    Friend WithEvents ColumnID As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents ColumnDataRadi As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents ColumnUser As DataGridViewComboBoxColumn
    Friend WithEvents ColumnPauta As DataGridViewComboBoxColumn
    Friend WithEvents ColumnPlay As DataGridViewButtonColumn
    Friend WithEvents ColumnEdit As DataGridViewButtonColumn
    Friend WithEvents chkFilesUser As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents lbAudioFiles As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents imgListMnu As ImageList
    Friend WithEvents pic_logo As PictureBox
End Class
