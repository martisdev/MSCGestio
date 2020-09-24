'
' Creado por SharpDevelop.
' Usuario: Marti
' Fecha: 08/09/2016
' Hora: 09:09
' 
' Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
'
Partial Class frmJamendo
    Inherits MetroFramework.Forms.MetroForm

    ''' <summary>
    ''' Designer variable used to keep track of non-visual components.
    ''' </summary>
    Private components As System.ComponentModel.IContainer

    ''' <summary>
    ''' Disposes resources used by the form.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If components IsNot Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    ''' <summary>
    ''' This method is required for Windows Forms designer support.
    ''' Do not change the method contents inside the source code editor. The Forms designer might
    ''' not be able to load this method if it was changed manually.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmJamendo))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.cmdRipper = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFilterBy = New System.Windows.Forms.ToolStripSplitButton()
        Me.popularitatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lesMésPopularsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.delMesToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.deLaSetmanaToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.escoltadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lesMésEscoltadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.delMesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.deLaSetmanaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.bbaixadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lesMesBaixadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.delMesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.deLaSetmanaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.emergentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLimit = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.nomArtistaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtNomArtista = New System.Windows.Forms.ToolStripTextBox()
        Me.nomÀlbumToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtNomAlbum = New System.Windows.Forms.ToolStripTextBox()
        Me.buscarTotToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtBuscarTot = New System.Windows.Forms.ToolStripTextBox()
        Me.cmdBuscar = New System.Windows.Forms.ToolStripButton()
        Me.lbRecCount = New System.Windows.Forms.ToolStripLabel()
        Me.cmdCheck = New System.Windows.Forms.ToolStripButton()
        Me.cmdSortir = New System.Windows.Forms.ToolStripButton()
        Me.lbVuMeter = New System.Windows.Forms.ToolStripLabel()
        Me.cmdStop = New System.Windows.Forms.ToolStripButton()
        Me.cmdPlay = New System.Windows.Forms.ToolStripButton()
        Me.imageListJamendo = New System.Windows.Forms.ImageList(Me.components)
        Me.lsvTrackList = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.picDT_Image = New System.Windows.Forms.PictureBox()
        Me.lbDT_llicencia = New System.Windows.Forms.LinkLabel()
        Me.lbDT_Speed = New System.Windows.Forms.LinkLabel()
        Me.lbDT_acusticelectic = New System.Windows.Forms.LinkLabel()
        Me.lbDT_gender = New System.Windows.Forms.LinkLabel()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label15 = New System.Windows.Forms.Label()
        Me.listTagsVaris = New System.Windows.Forms.FlowLayoutPanel()
        Me.label14 = New System.Windows.Forms.Label()
        Me.listTagsInstruments = New System.Windows.Forms.FlowLayoutPanel()
        Me.label13 = New System.Windows.Forms.Label()
        Me.listTagsEstil = New System.Windows.Forms.FlowLayoutPanel()
        Me.cmbBuscaTracksSimilar = New System.Windows.Forms.Button()
        Me.lbID = New System.Windows.Forms.Label()
        Me.lbDT_Titol = New System.Windows.Forms.Label()
        Me.lbDT_interp = New System.Windows.Forms.LinkLabel()
        Me.label12 = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.lbDT_shareURL = New System.Windows.Forms.LinkLabel()
        Me.label10 = New System.Windows.Forms.Label()
        Me.lbDT_DataPublicacio = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.lbDT_Album = New System.Windows.Forms.LinkLabel()
        Me.label1 = New System.Windows.Forms.Label()
        Me.tmrPlayer = New System.Windows.Forms.Timer(Me.components)
        Me.picPlay = New System.Windows.Forms.PictureBox()
        Me.picPause = New System.Windows.Forms.PictureBox()
        Me.picVuMeter = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuApplication = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAppExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPlayer = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPlay = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStop = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuEndTrack = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHTTPS = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpManual = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUrlJamendo = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdHideExit = New System.Windows.Forms.Button()
        Me.cmdImport = New MetroFramework.Controls.MetroTile()
        Me.pic_logo = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        CType(Me.picDT_Image, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPause, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picVuMeter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdRipper, Me.toolStripSeparator2, Me.mnuFilterBy, Me.cmdBuscar, Me.lbRecCount, Me.cmdCheck, Me.cmdSortir, Me.lbVuMeter, Me.cmdStop, Me.cmdPlay})
        Me.ToolStrip1.Location = New System.Drawing.Point(23, 78)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(976, 39)
        Me.ToolStrip1.TabIndex = 185
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'cmdRipper
        '
        Me.cmdRipper.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdRipper.Enabled = False
        Me.cmdRipper.Image = CType(resources.GetObject("cmdRipper.Image"), System.Drawing.Image)
        Me.cmdRipper.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdRipper.Name = "cmdRipper"
        Me.cmdRipper.Size = New System.Drawing.Size(36, 36)
        Me.cmdRipper.Text = "Importar"
        Me.cmdRipper.ToolTipText = "Importar / Codificar fitxers"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'mnuFilterBy
        '
        Me.mnuFilterBy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuFilterBy.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.popularitatToolStripMenuItem, Me.escoltadesToolStripMenuItem, Me.bbaixadesToolStripMenuItem, Me.emergentsToolStripMenuItem, Me.mnuLimit, Me.nomArtistaToolStripMenuItem, Me.nomÀlbumToolStripMenuItem, Me.buscarTotToolStripMenuItem})
        Me.mnuFilterBy.Image = CType(resources.GetObject("mnuFilterBy.Image"), System.Drawing.Image)
        Me.mnuFilterBy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuFilterBy.Name = "mnuFilterBy"
        Me.mnuFilterBy.Size = New System.Drawing.Size(73, 36)
        Me.mnuFilterBy.Text = "Filtrar per"
        '
        'popularitatToolStripMenuItem
        '
        Me.popularitatToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lesMésPopularsToolStripMenuItem, Me.delMesToolStripMenuItem2, Me.deLaSetmanaToolStripMenuItem2})
        Me.popularitatToolStripMenuItem.Name = "popularitatToolStripMenuItem"
        Me.popularitatToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.popularitatToolStripMenuItem.Text = "Popularitat"
        '
        'lesMésPopularsToolStripMenuItem
        '
        Me.lesMésPopularsToolStripMenuItem.Name = "lesMésPopularsToolStripMenuItem"
        Me.lesMésPopularsToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.lesMésPopularsToolStripMenuItem.Tag = "1"
        Me.lesMésPopularsToolStripMenuItem.Text = "Les més populars"
        '
        'delMesToolStripMenuItem2
        '
        Me.delMesToolStripMenuItem2.Name = "delMesToolStripMenuItem2"
        Me.delMesToolStripMenuItem2.Size = New System.Drawing.Size(165, 22)
        Me.delMesToolStripMenuItem2.Tag = "3"
        Me.delMesToolStripMenuItem2.Text = "Del mes"
        '
        'deLaSetmanaToolStripMenuItem2
        '
        Me.deLaSetmanaToolStripMenuItem2.Name = "deLaSetmanaToolStripMenuItem2"
        Me.deLaSetmanaToolStripMenuItem2.Size = New System.Drawing.Size(165, 22)
        Me.deLaSetmanaToolStripMenuItem2.Tag = "2"
        Me.deLaSetmanaToolStripMenuItem2.Text = "De la setmana"
        '
        'escoltadesToolStripMenuItem
        '
        Me.escoltadesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lesMésEscoltadesToolStripMenuItem, Me.delMesToolStripMenuItem1, Me.deLaSetmanaToolStripMenuItem1})
        Me.escoltadesToolStripMenuItem.Name = "escoltadesToolStripMenuItem"
        Me.escoltadesToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.escoltadesToolStripMenuItem.Text = "Escoltades"
        '
        'lesMésEscoltadesToolStripMenuItem
        '
        Me.lesMésEscoltadesToolStripMenuItem.Name = "lesMésEscoltadesToolStripMenuItem"
        Me.lesMésEscoltadesToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.lesMésEscoltadesToolStripMenuItem.Tag = "4"
        Me.lesMésEscoltadesToolStripMenuItem.Text = "Les més escoltades"
        '
        'delMesToolStripMenuItem1
        '
        Me.delMesToolStripMenuItem1.Name = "delMesToolStripMenuItem1"
        Me.delMesToolStripMenuItem1.Size = New System.Drawing.Size(174, 22)
        Me.delMesToolStripMenuItem1.Tag = "6"
        Me.delMesToolStripMenuItem1.Text = "Del mes"
        '
        'deLaSetmanaToolStripMenuItem1
        '
        Me.deLaSetmanaToolStripMenuItem1.Name = "deLaSetmanaToolStripMenuItem1"
        Me.deLaSetmanaToolStripMenuItem1.Size = New System.Drawing.Size(174, 22)
        Me.deLaSetmanaToolStripMenuItem1.Tag = "5"
        Me.deLaSetmanaToolStripMenuItem1.Text = "De la setmana"
        '
        'bbaixadesToolStripMenuItem
        '
        Me.bbaixadesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lesMesBaixadesToolStripMenuItem, Me.delMesToolStripMenuItem, Me.deLaSetmanaToolStripMenuItem})
        Me.bbaixadesToolStripMenuItem.Name = "bbaixadesToolStripMenuItem"
        Me.bbaixadesToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.bbaixadesToolStripMenuItem.Text = "Baixades"
        '
        'lesMesBaixadesToolStripMenuItem
        '
        Me.lesMesBaixadesToolStripMenuItem.Name = "lesMesBaixadesToolStripMenuItem"
        Me.lesMesBaixadesToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.lesMesBaixadesToolStripMenuItem.Tag = "7"
        Me.lesMesBaixadesToolStripMenuItem.Text = "Les mes baixades"
        '
        'delMesToolStripMenuItem
        '
        Me.delMesToolStripMenuItem.Name = "delMesToolStripMenuItem"
        Me.delMesToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.delMesToolStripMenuItem.Tag = "9"
        Me.delMesToolStripMenuItem.Text = "Del mes"
        '
        'deLaSetmanaToolStripMenuItem
        '
        Me.deLaSetmanaToolStripMenuItem.Name = "deLaSetmanaToolStripMenuItem"
        Me.deLaSetmanaToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.deLaSetmanaToolStripMenuItem.Tag = "8"
        Me.deLaSetmanaToolStripMenuItem.Text = "De la setmana"
        '
        'emergentsToolStripMenuItem
        '
        Me.emergentsToolStripMenuItem.Checked = True
        Me.emergentsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.emergentsToolStripMenuItem.Name = "emergentsToolStripMenuItem"
        Me.emergentsToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.emergentsToolStripMenuItem.Tag = "10"
        Me.emergentsToolStripMenuItem.Text = "Emergents"
        '
        'mnuLimit
        '
        Me.mnuLimit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripMenuItem2, Me.toolStripMenuItem5, Me.toolStripMenuItem6, Me.toolStripMenuItem3, Me.toolStripMenuItem4})
        Me.mnuLimit.Name = "mnuLimit"
        Me.mnuLimit.Size = New System.Drawing.Size(149, 22)
        Me.mnuLimit.Text = "Limitador"
        '
        'toolStripMenuItem2
        '
        Me.toolStripMenuItem2.Name = "toolStripMenuItem2"
        Me.toolStripMenuItem2.Size = New System.Drawing.Size(92, 22)
        Me.toolStripMenuItem2.Text = "10"
        '
        'toolStripMenuItem5
        '
        Me.toolStripMenuItem5.Checked = True
        Me.toolStripMenuItem5.CheckState = System.Windows.Forms.CheckState.Checked
        Me.toolStripMenuItem5.Name = "toolStripMenuItem5"
        Me.toolStripMenuItem5.Size = New System.Drawing.Size(92, 22)
        Me.toolStripMenuItem5.Text = "25"
        '
        'toolStripMenuItem6
        '
        Me.toolStripMenuItem6.Name = "toolStripMenuItem6"
        Me.toolStripMenuItem6.Size = New System.Drawing.Size(92, 22)
        Me.toolStripMenuItem6.Text = "50"
        '
        'toolStripMenuItem3
        '
        Me.toolStripMenuItem3.Name = "toolStripMenuItem3"
        Me.toolStripMenuItem3.Size = New System.Drawing.Size(92, 22)
        Me.toolStripMenuItem3.Text = "100"
        '
        'toolStripMenuItem4
        '
        Me.toolStripMenuItem4.Name = "toolStripMenuItem4"
        Me.toolStripMenuItem4.Size = New System.Drawing.Size(92, 22)
        Me.toolStripMenuItem4.Text = "200"
        '
        'nomArtistaToolStripMenuItem
        '
        Me.nomArtistaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtNomArtista})
        Me.nomArtistaToolStripMenuItem.Name = "nomArtistaToolStripMenuItem"
        Me.nomArtistaToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.nomArtistaToolStripMenuItem.Text = "Buscar Artista:"
        '
        'txtNomArtista
        '
        Me.txtNomArtista.Name = "txtNomArtista"
        Me.txtNomArtista.Size = New System.Drawing.Size(100, 23)
        '
        'nomÀlbumToolStripMenuItem
        '
        Me.nomÀlbumToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtNomAlbum})
        Me.nomÀlbumToolStripMenuItem.Name = "nomÀlbumToolStripMenuItem"
        Me.nomÀlbumToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.nomÀlbumToolStripMenuItem.Text = "Buscar Àlbum"
        '
        'txtNomAlbum
        '
        Me.txtNomAlbum.Name = "txtNomAlbum"
        Me.txtNomAlbum.Size = New System.Drawing.Size(100, 23)
        '
        'buscarTotToolStripMenuItem
        '
        Me.buscarTotToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtBuscarTot})
        Me.buscarTotToolStripMenuItem.Name = "buscarTotToolStripMenuItem"
        Me.buscarTotToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.buscarTotToolStripMenuItem.Text = "Buscar Tot"
        '
        'txtBuscarTot
        '
        Me.txtBuscarTot.Name = "txtBuscarTot"
        Me.txtBuscarTot.Size = New System.Drawing.Size(100, 23)
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Image = CType(resources.GetObject("cmdBuscar.Image"), System.Drawing.Image)
        Me.cmdBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(78, 36)
        Me.cmdBuscar.Text = "Buscar"
        '
        'lbRecCount
        '
        Me.lbRecCount.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRecCount.Name = "lbRecCount"
        Me.lbRecCount.Size = New System.Drawing.Size(16, 36)
        Me.lbRecCount.Text = "0"
        Me.lbRecCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdCheck
        '
        Me.cmdCheck.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdCheck.Image = CType(resources.GetObject("cmdCheck.Image"), System.Drawing.Image)
        Me.cmdCheck.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdCheck.Name = "cmdCheck"
        Me.cmdCheck.Size = New System.Drawing.Size(36, 36)
        Me.cmdCheck.Text = "Seleccionar tot"
        Me.cmdCheck.ToolTipText = "Selecconar tots els fitxers"
        '
        'cmdSortir
        '
        Me.cmdSortir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.cmdSortir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdSortir.Image = CType(resources.GetObject("cmdSortir.Image"), System.Drawing.Image)
        Me.cmdSortir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSortir.Name = "cmdSortir"
        Me.cmdSortir.Size = New System.Drawing.Size(36, 36)
        Me.cmdSortir.Text = "ToolStripButton1"
        '
        'lbVuMeter
        '
        Me.lbVuMeter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lbVuMeter.AutoSize = False
        Me.lbVuMeter.Name = "lbVuMeter"
        Me.lbVuMeter.Size = New System.Drawing.Size(175, 36)
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
        Me.cmdStop.Text = "ToolStripButton2"
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
        'imageListJamendo
        '
        Me.imageListJamendo.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.imageListJamendo.ImageSize = New System.Drawing.Size(128, 128)
        Me.imageListJamendo.TransparentColor = System.Drawing.Color.Transparent
        '
        'lsvTrackList
        '
        Me.lsvTrackList.AllowDrop = True
        Me.lsvTrackList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsvTrackList.CheckBoxes = True
        Me.lsvTrackList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.columnHeader6, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lsvTrackList.FullRowSelect = True
        Me.lsvTrackList.Location = New System.Drawing.Point(23, 121)
        Me.lsvTrackList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lsvTrackList.Name = "lsvTrackList"
        Me.lsvTrackList.Size = New System.Drawing.Size(978, 144)
        Me.lsvTrackList.TabIndex = 1
        Me.lsvTrackList.UseCompatibleStateImageBehavior = False
        Me.lsvTrackList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Títol"
        Me.ColumnHeader1.Width = 200
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Intèrpret"
        Me.ColumnHeader2.Width = 200
        '
        'columnHeader6
        '
        Me.columnHeader6.Text = "Album"
        Me.columnHeader6.Width = 200
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Durada"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Any"
        Me.ColumnHeader4.Width = 40
        '
        'groupBox2
        '
        Me.groupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBox2.Controls.Add(Me.picDT_Image)
        Me.groupBox2.Controls.Add(Me.lbDT_llicencia)
        Me.groupBox2.Controls.Add(Me.lbDT_Speed)
        Me.groupBox2.Controls.Add(Me.lbDT_acusticelectic)
        Me.groupBox2.Controls.Add(Me.lbDT_gender)
        Me.groupBox2.Controls.Add(Me.label4)
        Me.groupBox2.Controls.Add(Me.label3)
        Me.groupBox2.Controls.Add(Me.label2)
        Me.groupBox2.Controls.Add(Me.label15)
        Me.groupBox2.Controls.Add(Me.listTagsVaris)
        Me.groupBox2.Controls.Add(Me.label14)
        Me.groupBox2.Controls.Add(Me.listTagsInstruments)
        Me.groupBox2.Controls.Add(Me.label13)
        Me.groupBox2.Controls.Add(Me.listTagsEstil)
        Me.groupBox2.Controls.Add(Me.cmbBuscaTracksSimilar)
        Me.groupBox2.Controls.Add(Me.lbID)
        Me.groupBox2.Controls.Add(Me.lbDT_Titol)
        Me.groupBox2.Controls.Add(Me.lbDT_interp)
        Me.groupBox2.Controls.Add(Me.label12)
        Me.groupBox2.Controls.Add(Me.label11)
        Me.groupBox2.Controls.Add(Me.lbDT_shareURL)
        Me.groupBox2.Controls.Add(Me.label10)
        Me.groupBox2.Controls.Add(Me.lbDT_DataPublicacio)
        Me.groupBox2.Controls.Add(Me.label9)
        Me.groupBox2.Controls.Add(Me.label8)
        Me.groupBox2.Controls.Add(Me.lbDT_Album)
        Me.groupBox2.Controls.Add(Me.label1)
        Me.groupBox2.Location = New System.Drawing.Point(23, 266)
        Me.groupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.groupBox2.Size = New System.Drawing.Size(978, 247)
        Me.groupBox2.TabIndex = 0
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Detall cançó"
        '
        'picDT_Image
        '
        Me.picDT_Image.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picDT_Image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picDT_Image.Location = New System.Drawing.Point(747, 14)
        Me.picDT_Image.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picDT_Image.Name = "picDT_Image"
        Me.picDT_Image.Size = New System.Drawing.Size(225, 225)
        Me.picDT_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDT_Image.TabIndex = 10
        Me.picDT_Image.TabStop = False
        '
        'lbDT_llicencia
        '
        Me.lbDT_llicencia.AutoSize = True
        Me.lbDT_llicencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDT_llicencia.Location = New System.Drawing.Point(110, 109)
        Me.lbDT_llicencia.Name = "lbDT_llicencia"
        Me.lbDT_llicencia.Size = New System.Drawing.Size(0, 13)
        Me.lbDT_llicencia.TabIndex = 105
        '
        'lbDT_Speed
        '
        Me.lbDT_Speed.AutoSize = True
        Me.lbDT_Speed.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDT_Speed.Location = New System.Drawing.Point(547, 121)
        Me.lbDT_Speed.Name = "lbDT_Speed"
        Me.lbDT_Speed.Size = New System.Drawing.Size(0, 13)
        Me.lbDT_Speed.TabIndex = 104
        '
        'lbDT_acusticelectic
        '
        Me.lbDT_acusticelectic.AutoSize = True
        Me.lbDT_acusticelectic.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDT_acusticelectic.Location = New System.Drawing.Point(547, 92)
        Me.lbDT_acusticelectic.Name = "lbDT_acusticelectic"
        Me.lbDT_acusticelectic.Size = New System.Drawing.Size(0, 13)
        Me.lbDT_acusticelectic.TabIndex = 103
        '
        'lbDT_gender
        '
        Me.lbDT_gender.AutoSize = True
        Me.lbDT_gender.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDT_gender.Location = New System.Drawing.Point(547, 59)
        Me.lbDT_gender.Name = "lbDT_gender"
        Me.lbDT_gender.Size = New System.Drawing.Size(0, 13)
        Me.lbDT_gender.TabIndex = 102
        '
        'label4
        '
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(442, 121)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(98, 17)
        Me.label4.TabIndex = 101
        Me.label4.Text = "speed:"
        Me.label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'label3
        '
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(442, 92)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(98, 17)
        Me.label3.TabIndex = 100
        Me.label3.Text = "acousticelectric:"
        Me.label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'label2
        '
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(442, 59)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(98, 17)
        Me.label2.TabIndex = 99
        Me.label2.Text = "gender:"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'label15
        '
        Me.label15.Location = New System.Drawing.Point(453, 196)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(87, 17)
        Me.label15.TabIndex = 98
        Me.label15.Text = "Tags:"
        Me.label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'listTagsVaris
        '
        Me.listTagsVaris.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.listTagsVaris.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listTagsVaris.Location = New System.Drawing.Point(549, 196)
        Me.listTagsVaris.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.listTagsVaris.Name = "listTagsVaris"
        Me.listTagsVaris.Size = New System.Drawing.Size(192, 43)
        Me.listTagsVaris.TabIndex = 97
        '
        'label14
        '
        Me.label14.Location = New System.Drawing.Point(442, 143)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(98, 17)
        Me.label14.TabIndex = 96
        Me.label14.Text = "Instruments:"
        Me.label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'listTagsInstruments
        '
        Me.listTagsInstruments.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.listTagsInstruments.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listTagsInstruments.Location = New System.Drawing.Point(549, 143)
        Me.listTagsInstruments.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.listTagsInstruments.Name = "listTagsInstruments"
        Me.listTagsInstruments.Size = New System.Drawing.Size(192, 47)
        Me.listTagsInstruments.TabIndex = 95
        '
        'label13
        '
        Me.label13.Location = New System.Drawing.Point(14, 199)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(87, 17)
        Me.label13.TabIndex = 94
        Me.label13.Text = "Estil:"
        Me.label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'listTagsEstil
        '
        Me.listTagsEstil.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.listTagsEstil.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listTagsEstil.Location = New System.Drawing.Point(110, 199)
        Me.listTagsEstil.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.listTagsEstil.Name = "listTagsEstil"
        Me.listTagsEstil.Size = New System.Drawing.Size(325, 40)
        Me.listTagsEstil.TabIndex = 93
        '
        'cmbBuscaTracksSimilar
        '
        Me.cmbBuscaTracksSimilar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbBuscaTracksSimilar.Image = CType(resources.GetObject("cmbBuscaTracksSimilar.Image"), System.Drawing.Image)
        Me.cmbBuscaTracksSimilar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmbBuscaTracksSimilar.Location = New System.Drawing.Point(499, 21)
        Me.cmbBuscaTracksSimilar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbBuscaTracksSimilar.Name = "cmbBuscaTracksSimilar"
        Me.cmbBuscaTracksSimilar.Size = New System.Drawing.Size(182, 30)
        Me.cmbBuscaTracksSimilar.TabIndex = 90
        Me.cmbBuscaTracksSimilar.Text = "Buscar semblants"
        Me.cmbBuscaTracksSimilar.UseVisualStyleBackColor = True
        '
        'lbID
        '
        Me.lbID.BackColor = System.Drawing.Color.Lime
        Me.lbID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbID.Location = New System.Drawing.Point(700, 20)
        Me.lbID.Name = "lbID"
        Me.lbID.Size = New System.Drawing.Size(37, 30)
        Me.lbID.TabIndex = 91
        Me.lbID.Text = "0"
        Me.lbID.Visible = False
        '
        'lbDT_Titol
        '
        Me.lbDT_Titol.AutoSize = True
        Me.lbDT_Titol.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDT_Titol.Location = New System.Drawing.Point(110, 21)
        Me.lbDT_Titol.Name = "lbDT_Titol"
        Me.lbDT_Titol.Size = New System.Drawing.Size(0, 13)
        Me.lbDT_Titol.TabIndex = 87
        '
        'lbDT_interp
        '
        Me.lbDT_interp.AutoSize = True
        Me.lbDT_interp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDT_interp.Location = New System.Drawing.Point(110, 44)
        Me.lbDT_interp.Name = "lbDT_interp"
        Me.lbDT_interp.Size = New System.Drawing.Size(0, 13)
        Me.lbDT_interp.TabIndex = 86
        '
        'label12
        '
        Me.label12.Location = New System.Drawing.Point(3, 43)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(98, 17)
        Me.label12.TabIndex = 85
        Me.label12.Text = "Intèrpret"
        Me.label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'label11
        '
        Me.label11.Location = New System.Drawing.Point(14, 20)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(87, 17)
        Me.label11.TabIndex = 84
        Me.label11.Text = "Títol"
        Me.label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbDT_shareURL
        '
        Me.lbDT_shareURL.AutoSize = True
        Me.lbDT_shareURL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDT_shareURL.Location = New System.Drawing.Point(110, 169)
        Me.lbDT_shareURL.Name = "lbDT_shareURL"
        Me.lbDT_shareURL.Size = New System.Drawing.Size(0, 13)
        Me.lbDT_shareURL.TabIndex = 12
        '
        'label10
        '
        Me.label10.Location = New System.Drawing.Point(14, 169)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(87, 17)
        Me.label10.TabIndex = 11
        Me.label10.Text = "Link:"
        Me.label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbDT_DataPublicacio
        '
        Me.lbDT_DataPublicacio.AutoSize = True
        Me.lbDT_DataPublicacio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDT_DataPublicacio.Location = New System.Drawing.Point(110, 139)
        Me.lbDT_DataPublicacio.Name = "lbDT_DataPublicacio"
        Me.lbDT_DataPublicacio.Size = New System.Drawing.Size(0, 13)
        Me.lbDT_DataPublicacio.TabIndex = 9
        '
        'label9
        '
        Me.label9.Location = New System.Drawing.Point(3, 140)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(98, 17)
        Me.label9.TabIndex = 8
        Me.label9.Text = "Data publicació:"
        Me.label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'label8
        '
        Me.label8.Location = New System.Drawing.Point(3, 109)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(98, 17)
        Me.label8.TabIndex = 6
        Me.label8.Text = "Llicència:"
        Me.label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbDT_Album
        '
        Me.lbDT_Album.AutoSize = True
        Me.lbDT_Album.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDT_Album.Location = New System.Drawing.Point(110, 76)
        Me.lbDT_Album.Name = "lbDT_Album"
        Me.lbDT_Album.Size = New System.Drawing.Size(0, 13)
        Me.lbDT_Album.TabIndex = 5
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(14, 77)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(87, 17)
        Me.label1.TabIndex = 4
        Me.label1.Text = "Album:"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tmrPlayer
        '
        Me.tmrPlayer.Interval = 25
        '
        'picPlay
        '
        Me.picPlay.ErrorImage = CType(resources.GetObject("picPlay.ErrorImage"), System.Drawing.Image)
        Me.picPlay.Image = CType(resources.GetObject("picPlay.Image"), System.Drawing.Image)
        Me.picPlay.Location = New System.Drawing.Point(1056, 447)
        Me.picPlay.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picPlay.Name = "picPlay"
        Me.picPlay.Size = New System.Drawing.Size(19, 20)
        Me.picPlay.TabIndex = 193
        Me.picPlay.TabStop = False
        Me.picPlay.Visible = False
        '
        'picPause
        '
        Me.picPause.ErrorImage = CType(resources.GetObject("picPause.ErrorImage"), System.Drawing.Image)
        Me.picPause.Image = CType(resources.GetObject("picPause.Image"), System.Drawing.Image)
        Me.picPause.Location = New System.Drawing.Point(1056, 472)
        Me.picPause.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picPause.Name = "picPause"
        Me.picPause.Size = New System.Drawing.Size(19, 18)
        Me.picPause.TabIndex = 194
        Me.picPause.TabStop = False
        Me.picPause.Visible = False
        '
        'picVuMeter
        '
        Me.picVuMeter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picVuMeter.BackColor = System.Drawing.SystemColors.Control
        Me.picVuMeter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picVuMeter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picVuMeter.Location = New System.Drawing.Point(786, 85)
        Me.picVuMeter.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.picVuMeter.Name = "picVuMeter"
        Me.picVuMeter.Size = New System.Drawing.Size(175, 26)
        Me.picVuMeter.TabIndex = 206
        Me.picVuMeter.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuApplication, Me.mnuPlayer, Me.mnuHelp})
        Me.MenuStrip1.Location = New System.Drawing.Point(739, 30)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(262, 24)
        Me.MenuStrip1.TabIndex = 207
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuApplication
        '
        Me.mnuApplication.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAppExit})
        Me.mnuApplication.Image = CType(resources.GetObject("mnuApplication.Image"), System.Drawing.Image)
        Me.mnuApplication.Name = "mnuApplication"
        Me.mnuApplication.Size = New System.Drawing.Size(87, 20)
        Me.mnuApplication.Text = "Programa"
        '
        'mnuAppExit
        '
        Me.mnuAppExit.Image = CType(resources.GetObject("mnuAppExit.Image"), System.Drawing.Image)
        Me.mnuAppExit.Name = "mnuAppExit"
        Me.mnuAppExit.Size = New System.Drawing.Size(102, 22)
        Me.mnuAppExit.Text = "Sortir"
        '
        'mnuPlayer
        '
        Me.mnuPlayer.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPlay, Me.mnuStop, Me.ToolStripSeparator6, Me.mnuEndTrack})
        Me.mnuPlayer.Image = CType(resources.GetObject("mnuPlayer.Image"), System.Drawing.Image)
        Me.mnuPlayer.Name = "mnuPlayer"
        Me.mnuPlayer.Size = New System.Drawing.Size(101, 20)
        Me.mnuPlayer.Text = "Reproductor"
        '
        'mnuPlay
        '
        Me.mnuPlay.Image = CType(resources.GetObject("mnuPlay.Image"), System.Drawing.Image)
        Me.mnuPlay.Name = "mnuPlay"
        Me.mnuPlay.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.mnuPlay.Size = New System.Drawing.Size(176, 22)
        Me.mnuPlay.Tag = "1"
        Me.mnuPlay.Text = "Play/Pausa"
        '
        'mnuStop
        '
        Me.mnuStop.Image = CType(resources.GetObject("mnuStop.Image"), System.Drawing.Image)
        Me.mnuStop.Name = "mnuStop"
        Me.mnuStop.ShortcutKeys = System.Windows.Forms.Keys.F7
        Me.mnuStop.Size = New System.Drawing.Size(176, 22)
        Me.mnuStop.Tag = "2"
        Me.mnuStop.Text = "Stop"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(173, 6)
        '
        'mnuEndTrack
        '
        Me.mnuEndTrack.Image = CType(resources.GetObject("mnuEndTrack.Image"), System.Drawing.Image)
        Me.mnuEndTrack.Name = "mnuEndTrack"
        Me.mnuEndTrack.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F9), System.Windows.Forms.Keys)
        Me.mnuEndTrack.Size = New System.Drawing.Size(176, 22)
        Me.mnuEndTrack.Tag = "3"
        Me.mnuEndTrack.Text = "Final Tema"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHTTPS, Me.mnuHelpManual, Me.mnuUrlJamendo})
        Me.mnuHelp.Image = CType(resources.GetObject("mnuHelp.Image"), System.Drawing.Image)
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(66, 20)
        Me.mnuHelp.Text = "Ajuda"
        '
        'mnuHTTPS
        '
        Me.mnuHTTPS.Checked = True
        Me.mnuHTTPS.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuHTTPS.Name = "mnuHTTPS"
        Me.mnuHTTPS.Size = New System.Drawing.Size(200, 22)
        Me.mnuHTTPS.Text = "Connexió segura HTTPS"
        '
        'mnuHelpManual
        '
        Me.mnuHelpManual.Image = CType(resources.GetObject("mnuHelpManual.Image"), System.Drawing.Image)
        Me.mnuHelpManual.Name = "mnuHelpManual"
        Me.mnuHelpManual.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.mnuHelpManual.Size = New System.Drawing.Size(200, 22)
        Me.mnuHelpManual.Text = "Manual OnLine"
        '
        'mnuUrlJamendo
        '
        Me.mnuUrlJamendo.Name = "mnuUrlJamendo"
        Me.mnuUrlJamendo.Size = New System.Drawing.Size(200, 22)
        Me.mnuUrlJamendo.Text = "www.jamendo.com"
        '
        'cmdHideExit
        '
        Me.cmdHideExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdHideExit.Location = New System.Drawing.Point(26, 236)
        Me.cmdHideExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdHideExit.Name = "cmdHideExit"
        Me.cmdHideExit.Size = New System.Drawing.Size(36, 22)
        Me.cmdHideExit.TabIndex = 208
        Me.cmdHideExit.Text = "Button1"
        Me.cmdHideExit.UseVisualStyleBackColor = True
        '
        'cmdImport
        '
        Me.cmdImport.ActiveControl = Nothing
        Me.cmdImport.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdImport.Location = New System.Drawing.Point(403, 520)
        Me.cmdImport.Name = "cmdImport"
        Me.cmdImport.Size = New System.Drawing.Size(301, 43)
        Me.cmdImport.TabIndex = 204
        Me.cmdImport.Text = "Import"
        Me.cmdImport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdImport.TileImage = CType(resources.GetObject("cmdImport.TileImage"), System.Drawing.Image)
        Me.cmdImport.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdImport.UseSelectable = True
        Me.cmdImport.UseTileImage = True
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
        'frmJamendo
        '
        Me.AcceptButton = Me.cmdImport
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdHideExit
        Me.ClientSize = New System.Drawing.Size(1022, 575)
        Me.Controls.Add(Me.pic_logo)
        Me.Controls.Add(Me.cmdImport)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.picVuMeter)
        Me.Controls.Add(Me.lsvTrackList)
        Me.Controls.Add(Me.picPlay)
        Me.Controls.Add(Me.picPause)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.cmdHideExit)
        Me.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmJamendo"
        Me.Padding = New System.Windows.Forms.Padding(23, 78, 23, 26)
        Me.Text = "Import from Jamendo.com"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        CType(Me.picDT_Image, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPause, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picVuMeter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents toolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents toolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents lbDT_llicencia As System.Windows.Forms.LinkLabel
    Private label2 As System.Windows.Forms.Label
    Private label3 As System.Windows.Forms.Label
    Private label4 As System.Windows.Forms.Label
    Private WithEvents lbDT_gender As System.Windows.Forms.LinkLabel
    Private WithEvents lbDT_acusticelectic As System.Windows.Forms.LinkLabel
    Private WithEvents lbDT_Speed As System.Windows.Forms.LinkLabel
    Friend lbRecCount As System.Windows.Forms.ToolStripLabel
    Private WithEvents txtBuscarTot As System.Windows.Forms.ToolStripTextBox
    Private buscarTotToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents txtNomAlbum As System.Windows.Forms.ToolStripTextBox
    Private nomÀlbumToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents txtNomArtista As System.Windows.Forms.ToolStripTextBox
    Private nomArtistaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private columnHeader6 As System.Windows.Forms.ColumnHeader
    Private listTagsVaris As System.Windows.Forms.FlowLayoutPanel
    Private label15 As System.Windows.Forms.Label
    Private listTagsInstruments As System.Windows.Forms.FlowLayoutPanel
    Private label14 As System.Windows.Forms.Label
    Private listTagsEstil As System.Windows.Forms.FlowLayoutPanel
    Private label13 As System.Windows.Forms.Label
    Private lbID As System.Windows.Forms.Label
    Private WithEvents cmbBuscaTracksSimilar As System.Windows.Forms.Button
    Friend label11 As System.Windows.Forms.Label
    Friend label12 As System.Windows.Forms.Label
    Private WithEvents lbDT_interp As System.Windows.Forms.LinkLabel
    Private lbDT_Titol As System.Windows.Forms.Label
    Friend picPause As System.Windows.Forms.PictureBox
    Friend picPlay As System.Windows.Forms.PictureBox
    Private WithEvents toolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents toolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents toolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Private mnuLimit As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents delMesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents deLaSetmanaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents lesMesBaixadesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private bbaixadesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents delMesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents deLaSetmanaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents lesMésEscoltadesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private escoltadesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents delMesToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents deLaSetmanaToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents lesMésPopularsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents emergentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdCheck As System.Windows.Forms.ToolStripButton
    Private label9 As System.Windows.Forms.Label
    Private lbDT_DataPublicacio As System.Windows.Forms.Label
    Private picDT_Image As System.Windows.Forms.PictureBox
    Private label10 As System.Windows.Forms.Label
    Private WithEvents lbDT_shareURL As System.Windows.Forms.LinkLabel
    Private label8 As System.Windows.Forms.Label
    Private label1 As System.Windows.Forms.Label
    Private WithEvents lbDT_Album As System.Windows.Forms.LinkLabel
    Friend ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Private WithEvents toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdRipper As System.Windows.Forms.ToolStripButton
    Private groupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tmrPlayer As System.Windows.Forms.Timer
    'Friend cmdPlay As System.Windows.Forms.ToolStripButton
    'Friend cmdStop As System.Windows.Forms.ToolStripButton
    Friend WithEvents lsvTrackList As System.Windows.Forms.ListView
    Private WithEvents cmdBuscar As System.Windows.Forms.ToolStripButton
    Private popularitatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents mnuFilterBy As System.Windows.Forms.ToolStripSplitButton
    Private imageListJamendo As System.Windows.Forms.ImageList
    Friend ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdSortir As ToolStripButton
    Friend WithEvents lbVuMeter As ToolStripLabel
    Friend WithEvents cmdStop As ToolStripButton
    Friend WithEvents cmdPlay As ToolStripButton
    Friend WithEvents picVuMeter As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuApplication As ToolStripMenuItem
    Friend WithEvents mnuAppExit As ToolStripMenuItem
    Friend WithEvents mnuPlayer As ToolStripMenuItem
    Friend WithEvents mnuPlay As ToolStripMenuItem
    Friend WithEvents mnuStop As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents mnuEndTrack As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Private WithEvents mnuHTTPS As ToolStripMenuItem
    Public WithEvents mnuHelpManual As ToolStripMenuItem
    Friend WithEvents cmdHideExit As Button
    Friend WithEvents mnuUrlJamendo As ToolStripMenuItem
    Friend WithEvents cmdImport As MetroFramework.Controls.MetroTile
    Friend WithEvents pic_logo As PictureBox
End Class
