<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAudios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAudios))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lbUltimaRadi = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbDurada = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbClasSubj = New System.Windows.Forms.LinkLabel()
        Me.lbEstil = New System.Windows.Forms.LinkLabel()
        Me.ComboSubj = New System.Windows.Forms.ComboBox()
        Me.ComboEstil = New System.Windows.Forms.ComboBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbID = New System.Windows.Forms.Label()
        Me.picLock = New System.Windows.Forms.PictureBox()
        Me.picUnLock = New System.Windows.Forms.PictureBox()
        Me.txtRitme = New System.Windows.Forms.TextBox()
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
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_Help = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.optionBuscar = New System.Windows.Forms.ToolStripDropDownButton()
        Me.PerIDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerNomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QualsevolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_actives = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdSortir = New System.Windows.Forms.ToolStripButton()
        Me.txtBuscar = New System.Windows.Forms.ToolStripTextBox()
        Me.lbAtencio = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.cmdStop = New System.Windows.Forms.ToolStripButton()
        Me.cmdPlay = New System.Windows.Forms.ToolStripButton()
        Me.lbNou = New System.Windows.Forms.ToolStripLabel()
        Me.lbRitme = New System.Windows.Forms.LinkLabel()
        Me.gridDades = New MetroFramework.Controls.MetroGrid()
        Me.picVuMeter = New System.Windows.Forms.PictureBox()
        Me.picPlay = New System.Windows.Forms.PictureBox()
        Me.picPause = New System.Windows.Forms.PictureBox()
        Me.tmrPlayer = New System.Windows.Forms.Timer(Me.components)
        Me.tmrDetalls = New System.Windows.Forms.Timer(Me.components)
        Me.chkActive = New MetroFramework.Controls.MetroToggle()
        Me.pic_logo = New System.Windows.Forms.PictureBox()
        Me.ColumnID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnNom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnEstil = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ColumnSubj = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ColumnActiva = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ColumnDurada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnRitme = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnDataRadi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.picLock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUnLock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.gridDades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picVuMeter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPause, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbUltimaRadi
        '
        Me.lbUltimaRadi.AutoSize = True
        Me.lbUltimaRadi.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUltimaRadi.Location = New System.Drawing.Point(555, 313)
        Me.lbUltimaRadi.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbUltimaRadi.Name = "lbUltimaRadi"
        Me.lbUltimaRadi.Size = New System.Drawing.Size(0, 13)
        Me.lbUltimaRadi.TabIndex = 153
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(446, 311)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 17)
        Me.Label4.TabIndex = 152
        Me.Label4.Text = "Última radiació"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbDurada
        '
        Me.lbDurada.AutoSize = True
        Me.lbDurada.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDurada.Location = New System.Drawing.Point(223, 313)
        Me.lbDurada.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbDurada.Name = "lbDurada"
        Me.lbDurada.Size = New System.Drawing.Size(57, 13)
        Me.lbDurada.TabIndex = 151
        Me.lbDurada.Text = "00:00:00"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(127, 311)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 17)
        Me.Label3.TabIndex = 150
        Me.Label3.Text = "Durada"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbClasSubj
        '
        Me.lbClasSubj.Location = New System.Drawing.Point(118, 238)
        Me.lbClasSubj.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbClasSubj.Name = "lbClasSubj"
        Me.lbClasSubj.Size = New System.Drawing.Size(101, 17)
        Me.lbClasSubj.TabIndex = 148
        Me.lbClasSubj.TabStop = True
        Me.lbClasSubj.Text = "Clas. Subjectiva"
        Me.lbClasSubj.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbEstil
        '
        Me.lbEstil.Location = New System.Drawing.Point(118, 208)
        Me.lbEstil.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbEstil.Name = "lbEstil"
        Me.lbEstil.Size = New System.Drawing.Size(101, 17)
        Me.lbEstil.TabIndex = 147
        Me.lbEstil.TabStop = True
        Me.lbEstil.Text = "Estil"
        Me.lbEstil.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ComboSubj
        '
        Me.ComboSubj.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboSubj.Enabled = False
        Me.ComboSubj.FormattingEnabled = True
        Me.ComboSubj.Location = New System.Drawing.Point(226, 238)
        Me.ComboSubj.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboSubj.Name = "ComboSubj"
        Me.ComboSubj.Size = New System.Drawing.Size(328, 25)
        Me.ComboSubj.TabIndex = 3
        '
        'ComboEstil
        '
        Me.ComboEstil.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboEstil.Enabled = False
        Me.ComboEstil.FormattingEnabled = True
        Me.ComboEstil.Location = New System.Drawing.Point(226, 205)
        Me.ComboEstil.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboEstil.Name = "ComboEstil"
        Me.ComboEstil.Size = New System.Drawing.Size(328, 25)
        Me.ComboEstil.TabIndex = 2
        '
        'txtNom
        '
        Me.txtNom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNom.Enabled = False
        Me.txtNom.Location = New System.Drawing.Point(226, 174)
        Me.txtNom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(737, 25)
        Me.txtNom.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(118, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 17)
        Me.Label2.TabIndex = 137
        Me.Label2.Text = "Nom:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Location = New System.Drawing.Point(27, 90)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(40, 20)
        Me.cmdExit.TabIndex = 143
        Me.cmdExit.Text = "Button1"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(118, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 17)
        Me.Label1.TabIndex = 136
        Me.Label1.Text = "Identificador:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbID
        '
        Me.lbID.AutoSize = True
        Me.lbID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbID.Location = New System.Drawing.Point(226, 148)
        Me.lbID.Name = "lbID"
        Me.lbID.Size = New System.Drawing.Size(14, 13)
        Me.lbID.TabIndex = 135
        Me.lbID.Text = "0"
        '
        'picLock
        '
        Me.picLock.Image = CType(resources.GetObject("picLock.Image"), System.Drawing.Image)
        Me.picLock.Location = New System.Drawing.Point(927, 209)
        Me.picLock.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picLock.Name = "picLock"
        Me.picLock.Size = New System.Drawing.Size(34, 46)
        Me.picLock.TabIndex = 132
        Me.picLock.TabStop = False
        Me.picLock.Visible = False
        '
        'picUnLock
        '
        Me.picUnLock.Image = CType(resources.GetObject("picUnLock.Image"), System.Drawing.Image)
        Me.picUnLock.Location = New System.Drawing.Point(967, 209)
        Me.picUnLock.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picUnLock.Name = "picUnLock"
        Me.picUnLock.Size = New System.Drawing.Size(37, 44)
        Me.picUnLock.TabIndex = 133
        Me.picUnLock.TabStop = False
        Me.picUnLock.Visible = False
        '
        'txtRitme
        '
        Me.txtRitme.Enabled = False
        Me.txtRitme.Location = New System.Drawing.Point(226, 271)
        Me.txtRitme.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRitme.Name = "txtRitme"
        Me.txtRitme.Size = New System.Drawing.Size(67, 25)
        Me.txtRitme.TabIndex = 6
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgarmaToolStripMenuItem, Me.ReproductorToolStripMenuItem, Me.EdicióToolStripMenuItem, Me.ToolStripMenuItem8})
        Me.MenuStrip1.Location = New System.Drawing.Point(788, 39)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(330, 26)
        Me.MenuStrip1.TabIndex = 157
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
        Me.mnuSave.Image = CType(resources.GetObject("mnuSave.Image"), System.Drawing.Image)
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
        Me.mnuDel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Delete), System.Windows.Forms.Keys)
        Me.mnuDel.Size = New System.Drawing.Size(183, 22)
        Me.mnuDel.Text = "Borrar"
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
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_Help})
        Me.ToolStripMenuItem8.Image = CType(resources.GetObject("ToolStripMenuItem8.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(66, 20)
        Me.ToolStripMenuItem8.Text = "Ajuda"
        '
        'mnu_Help
        '
        Me.mnu_Help.Image = CType(resources.GetObject("mnu_Help.Image"), System.Drawing.Image)
        Me.mnu_Help.Name = "mnu_Help"
        Me.mnu_Help.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.mnu_Help.Size = New System.Drawing.Size(174, 22)
        Me.mnu_Help.Text = "Manual OnLine"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdPrimer, Me.cmdPrevi, Me.cmdSeguent, Me.cmdUltim, Me.lbPosition, Me.ToolStripLabel1, Me.lbRecCount, Me.ToolStripSeparator1, Me.cmdNou, Me.cmdBloqueix, Me.cmdBorrar, Me.cmdSalvar, Me.ToolStripSeparator2, Me.cmdRefrescar, Me.optionBuscar, Me.cmdSortir, Me.txtBuscar, Me.lbAtencio, Me.ToolStripLabel2, Me.cmdStop, Me.cmdPlay, Me.lbNou})
        Me.ToolStrip1.Location = New System.Drawing.Point(23, 78)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1089, 39)
        Me.ToolStrip1.TabIndex = 158
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
        'optionBuscar
        '
        Me.optionBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.optionBuscar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PerIDToolStripMenuItem, Me.PerNomToolStripMenuItem, Me.QualsevolToolStripMenuItem, Me.mnu_actives})
        Me.optionBuscar.Image = CType(resources.GetObject("optionBuscar.Image"), System.Drawing.Image)
        Me.optionBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.optionBuscar.Name = "optionBuscar"
        Me.optionBuscar.Size = New System.Drawing.Size(45, 36)
        Me.optionBuscar.Text = "Buscar"
        '
        'PerIDToolStripMenuItem
        '
        Me.PerIDToolStripMenuItem.Name = "PerIDToolStripMenuItem"
        Me.PerIDToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.PerIDToolStripMenuItem.Text = "Per ID"
        '
        'PerNomToolStripMenuItem
        '
        Me.PerNomToolStripMenuItem.Name = "PerNomToolStripMenuItem"
        Me.PerNomToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.PerNomToolStripMenuItem.Text = "Per Nom"
        '
        'QualsevolToolStripMenuItem
        '
        Me.QualsevolToolStripMenuItem.Checked = True
        Me.QualsevolToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.QualsevolToolStripMenuItem.Name = "QualsevolToolStripMenuItem"
        Me.QualsevolToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.QualsevolToolStripMenuItem.Text = "Qualsevol"
        '
        'mnu_actives
        '
        Me.mnu_actives.Name = "mnu_actives"
        Me.mnu_actives.Size = New System.Drawing.Size(151, 22)
        Me.mnu_actives.Text = "Només actives"
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
        Me.txtBuscar.Size = New System.Drawing.Size(100, 39)
        '
        'lbAtencio
        '
        Me.lbAtencio.Image = CType(resources.GetObject("lbAtencio.Image"), System.Drawing.Image)
        Me.lbAtencio.Name = "lbAtencio"
        Me.lbAtencio.Size = New System.Drawing.Size(139, 36)
        Me.lbAtencio.Text = "No existeix el fitxer"
        Me.lbAtencio.Visible = False
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel2.AutoSize = False
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(88, 36)
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
        Me.cmdStop.Text = "ToolStripButton1"
        '
        'cmdPlay
        '
        Me.cmdPlay.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.cmdPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdPlay.Image = CType(resources.GetObject("cmdPlay.Image"), System.Drawing.Image)
        Me.cmdPlay.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPlay.Name = "cmdPlay"
        Me.cmdPlay.Size = New System.Drawing.Size(36, 36)
        Me.cmdPlay.Text = "ToolStripButton2"
        '
        'lbNou
        '
        Me.lbNou.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNou.ForeColor = System.Drawing.Color.Red
        Me.lbNou.Name = "lbNou"
        Me.lbNou.Size = New System.Drawing.Size(53, 36)
        Me.lbNou.Text = "NOU"
        Me.lbNou.Visible = False
        '
        'lbRitme
        '
        Me.lbRitme.Enabled = False
        Me.lbRitme.Location = New System.Drawing.Point(118, 274)
        Me.lbRitme.Name = "lbRitme"
        Me.lbRitme.Size = New System.Drawing.Size(101, 17)
        Me.lbRitme.TabIndex = 159
        Me.lbRitme.TabStop = True
        Me.lbRitme.Text = "Ritme"
        Me.lbRitme.TextAlign = System.Drawing.ContentAlignment.TopRight
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
        Me.gridDades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnID, Me.ColumnNom, Me.ColumnEstil, Me.ColumnSubj, Me.ColumnActiva, Me.ColumnDurada, Me.ColumnRitme, Me.ColumnDataRadi})
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
        Me.gridDades.Location = New System.Drawing.Point(23, 337)
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
        Me.gridDades.Size = New System.Drawing.Size(1089, 208)
        Me.gridDades.TabIndex = 160
        '
        'picVuMeter
        '
        Me.picVuMeter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picVuMeter.BackColor = System.Drawing.SystemColors.Control
        Me.picVuMeter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picVuMeter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picVuMeter.Location = New System.Drawing.Point(988, 84)
        Me.picVuMeter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picVuMeter.Name = "picVuMeter"
        Me.picVuMeter.Size = New System.Drawing.Size(86, 29)
        Me.picVuMeter.TabIndex = 190
        Me.picVuMeter.TabStop = False
        '
        'picPlay
        '
        Me.picPlay.ErrorImage = CType(resources.GetObject("picPlay.ErrorImage"), System.Drawing.Image)
        Me.picPlay.Image = CType(resources.GetObject("picPlay.Image"), System.Drawing.Image)
        Me.picPlay.Location = New System.Drawing.Point(961, 141)
        Me.picPlay.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picPlay.Name = "picPlay"
        Me.picPlay.Size = New System.Drawing.Size(19, 20)
        Me.picPlay.TabIndex = 191
        Me.picPlay.TabStop = False
        Me.picPlay.Visible = False
        '
        'picPause
        '
        Me.picPause.ErrorImage = CType(resources.GetObject("picPause.ErrorImage"), System.Drawing.Image)
        Me.picPause.Image = CType(resources.GetObject("picPause.Image"), System.Drawing.Image)
        Me.picPause.Location = New System.Drawing.Point(961, 179)
        Me.picPause.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picPause.Name = "picPause"
        Me.picPause.Size = New System.Drawing.Size(19, 18)
        Me.picPause.TabIndex = 192
        Me.picPause.TabStop = False
        Me.picPause.Visible = False
        '
        'tmrPlayer
        '
        Me.tmrPlayer.Interval = 25
        '
        'tmrDetalls
        '
        Me.tmrDetalls.Interval = 1000
        '
        'chkActive
        '
        Me.chkActive.AutoSize = True
        Me.chkActive.Enabled = False
        Me.chkActive.Location = New System.Drawing.Point(471, 129)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(80, 21)
        Me.chkActive.TabIndex = 262
        Me.chkActive.Text = "Off"
        Me.chkActive.UseSelectable = True
        '
        'pic_logo
        '
        Me.pic_logo.Location = New System.Drawing.Point(25, 25)
        Me.pic_logo.Name = "pic_logo"
        Me.pic_logo.Size = New System.Drawing.Size(40, 40)
        Me.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_logo.TabIndex = 263
        Me.pic_logo.TabStop = False
        '
        'ColumnID
        '
        Me.ColumnID.DataPropertyName = "audio_id"
        Me.ColumnID.HeaderText = "ID"
        Me.ColumnID.Name = "ColumnID"
        Me.ColumnID.ReadOnly = True
        '
        'ColumnNom
        '
        Me.ColumnNom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnNom.DataPropertyName = "audio_nom"
        Me.ColumnNom.HeaderText = "Nom"
        Me.ColumnNom.Name = "ColumnNom"
        Me.ColumnNom.ReadOnly = True
        '
        'ColumnEstil
        '
        Me.ColumnEstil.DataPropertyName = "audio_style"
        Me.ColumnEstil.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.ColumnEstil.HeaderText = "Estil"
        Me.ColumnEstil.Name = "ColumnEstil"
        Me.ColumnEstil.ReadOnly = True
        Me.ColumnEstil.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColumnEstil.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'ColumnSubj
        '
        Me.ColumnSubj.DataPropertyName = "audio_subj"
        Me.ColumnSubj.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.ColumnSubj.HeaderText = "Subject"
        Me.ColumnSubj.Name = "ColumnSubj"
        Me.ColumnSubj.ReadOnly = True
        Me.ColumnSubj.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColumnSubj.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'ColumnActiva
        '
        Me.ColumnActiva.DataPropertyName = "audio_actv"
        Me.ColumnActiva.HeaderText = "Activa"
        Me.ColumnActiva.Name = "ColumnActiva"
        Me.ColumnActiva.ReadOnly = True
        Me.ColumnActiva.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColumnActiva.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'ColumnDurada
        '
        Me.ColumnDurada.DataPropertyName = "audio_durada"
        Me.ColumnDurada.HeaderText = "Durada"
        Me.ColumnDurada.Name = "ColumnDurada"
        Me.ColumnDurada.ReadOnly = True
        Me.ColumnDurada.Visible = False
        '
        'ColumnRitme
        '
        Me.ColumnRitme.DataPropertyName = "audio_ritme"
        Me.ColumnRitme.HeaderText = "Ritme"
        Me.ColumnRitme.Name = "ColumnRitme"
        Me.ColumnRitme.ReadOnly = True
        '
        'ColumnDataRadi
        '
        Me.ColumnDataRadi.DataPropertyName = "audio_dataradiacio"
        Me.ColumnDataRadi.HeaderText = "Data Radiació"
        Me.ColumnDataRadi.Name = "ColumnDataRadi"
        Me.ColumnDataRadi.ReadOnly = True
        Me.ColumnDataRadi.Visible = False
        '
        'frmAudios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(1135, 575)
        Me.Controls.Add(Me.pic_logo)
        Me.Controls.Add(Me.chkActive)
        Me.Controls.Add(Me.picVuMeter)
        Me.Controls.Add(Me.picPlay)
        Me.Controls.Add(Me.picPause)
        Me.Controls.Add(Me.gridDades)
        Me.Controls.Add(Me.lbRitme)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.txtRitme)
        Me.Controls.Add(Me.lbUltimaRadi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbDurada)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbClasSubj)
        Me.Controls.Add(Me.lbEstil)
        Me.Controls.Add(Me.ComboSubj)
        Me.Controls.Add(Me.ComboEstil)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbID)
        Me.Controls.Add(Me.picLock)
        Me.Controls.Add(Me.picUnLock)
        Me.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmAudios"
        Me.Padding = New System.Windows.Forms.Padding(23, 78, 23, 26)
        Me.Text = "Manteniment d'Àudio"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        CType(Me.picLock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUnLock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.gridDades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picVuMeter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPause, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbUltimaRadi As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbDurada As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbClasSubj As System.Windows.Forms.LinkLabel
    Friend WithEvents lbEstil As System.Windows.Forms.LinkLabel
    Friend WithEvents ComboSubj As System.Windows.Forms.ComboBox
    Friend WithEvents ComboEstil As System.Windows.Forms.ComboBox
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbID As System.Windows.Forms.Label
    Friend WithEvents picLock As System.Windows.Forms.PictureBox
    Friend WithEvents picUnLock As System.Windows.Forms.PictureBox
    Friend WithEvents txtRitme As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ProgarmaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReproductorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPlay As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuStop As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EdicióToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuModif As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuBuscar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRefresh As System.Windows.Forms.ToolStripMenuItem
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
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdSortir As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuCalcDurada As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbRitme As System.Windows.Forms.LinkLabel
    Friend WithEvents txtBuscar As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents optionBuscar As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents PerIDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PerNomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QualsevolToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents picVuMeter As System.Windows.Forms.PictureBox
    Friend WithEvents picPlay As System.Windows.Forms.PictureBox
    Friend WithEvents picPause As System.Windows.Forms.PictureBox
    Friend WithEvents mnuFinal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmrPlayer As System.Windows.Forms.Timer
    Friend WithEvents tmrDetalls As System.Windows.Forms.Timer
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuEditAudio As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnu_Help As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_actives As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbAtencio As ToolStripLabel
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents cmdStop As ToolStripButton
    Friend WithEvents cmdPlay As ToolStripButton
    Friend WithEvents lbNou As ToolStripLabel
    Friend WithEvents chkActive As MetroFramework.Controls.MetroToggle
    Friend WithEvents gridDades As MetroFramework.Controls.MetroGrid
    Friend WithEvents pic_logo As PictureBox
    Friend WithEvents ColumnID As DataGridViewTextBoxColumn
    Friend WithEvents ColumnNom As DataGridViewTextBoxColumn
    Friend WithEvents ColumnEstil As DataGridViewComboBoxColumn
    Friend WithEvents ColumnSubj As DataGridViewComboBoxColumn
    Friend WithEvents ColumnActiva As DataGridViewCheckBoxColumn
    Friend WithEvents ColumnDurada As DataGridViewTextBoxColumn
    Friend WithEvents ColumnRitme As DataGridViewTextBoxColumn
    Friend WithEvents ColumnDataRadi As DataGridViewTextBoxColumn
End Class
