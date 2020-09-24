<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrgLogger
    Inherits MetroFramework.Forms.MetroForm

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrgLogger))
        Me.cmdSortir = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.cmdExitTool = New System.Windows.Forms.ToolStripButton()
        Me.cmdNou = New System.Windows.Forms.ToolStripButton()
        Me.cmdBloqueix = New System.Windows.Forms.ToolStripButton()
        Me.cmdDelMassive = New System.Windows.Forms.ToolStripButton()
        Me.cmdDel = New System.Windows.Forms.ToolStripButton()
        Me.cmdSalvar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ldNou = New System.Windows.Forms.ToolStripLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProgarmaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.EdicióToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModif = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDel = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_Help = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ImageListCalendar = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBoxInfoCalendar = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbNomDirecte = New System.Windows.Forms.Label()
        Me.lbNomCentral = New System.Windows.Forms.Label()
        Me.PanelCalendar = New System.Windows.Forms.Panel()
        Me.picCalBlau = New System.Windows.Forms.PictureBox()
        Me.picCalTaronja = New System.Windows.Forms.PictureBox()
        Me.picCalendar = New System.Windows.Forms.PictureBox()
        Me.picHores = New System.Windows.Forms.PictureBox()
        Me.buttonResizeCalendarMenys = New System.Windows.Forms.Button()
        Me.buttonResizeCalendarMes = New System.Windows.Forms.Button()
        Me.cmdAnt = New System.Windows.Forms.Button()
        Me.DateTimePickerCalendar = New System.Windows.Forms.DateTimePicker()
        Me.PictureBoxCalendar = New System.Windows.Forms.PictureBox()
        Me.pnlDies = New System.Windows.Forms.Panel()
        Me.lbDll = New System.Windows.Forms.Label()
        Me.lbDts = New System.Windows.Forms.Label()
        Me.lbDres = New System.Windows.Forms.Label()
        Me.lbDj = New System.Windows.Forms.Label()
        Me.lbDv = New System.Windows.Forms.Label()
        Me.lbDs = New System.Windows.Forms.Label()
        Me.lbDg = New System.Windows.Forms.Label()
        Me.cmdActual = New System.Windows.Forms.Button()
        Me.cmdPost = New System.Windows.Forms.Button()
        Me.lbFet = New System.Windows.Forms.Label()
        Me.GroupAssigTemp = New System.Windows.Forms.GroupBox()
        Me.optDataHora = New System.Windows.Forms.RadioButton()
        Me.lbID = New System.Windows.Forms.Label()
        Me.txtDurada = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.txtDataIn = New System.Windows.Forms.DateTimePicker()
        Me.txtDataOut = New System.Windows.Forms.DateTimePicker()
        Me.txtHoraIni = New System.Windows.Forms.DateTimePicker()
        Me.optSetmHora = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.chkPodcasting = New System.Windows.Forms.CheckBox()
        Me.GroupPRG = New System.Windows.Forms.GroupBox()
        Me.ComboBoxProgrames = New System.Windows.Forms.ComboBox()
        Me.chkReEmissio = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupEmissio = New System.Windows.Forms.GroupBox()
        Me.txtHoraRemissio = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ComboDiaSetmanaReEmissor = New System.Windows.Forms.ComboBox()
        Me.txtDataReemissor = New System.Windows.Forms.DateTimePicker()
        Me.optSetmHoraReEmissor = New System.Windows.Forms.RadioButton()
        Me.optDataHoraReEmissor = New System.Windows.Forms.RadioButton()
        Me.chksaveAsPrg = New System.Windows.Forms.CheckBox()
        Me.GroupQualitat = New System.Windows.Forms.GroupBox()
        Me.ComboBoxSelectQualitatRec = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ComboCanalsAudio = New System.Windows.Forms.ComboBox()
        Me.ComboSampleRate = New System.Windows.Forms.ComboBox()
        Me.ComboBitRate = New System.Windows.Forms.ComboBox()
        Me.picLock = New System.Windows.Forms.PictureBox()
        Me.picUnLock = New System.Windows.Forms.PictureBox()
        Me.ProgressBar = New MetroFramework.Controls.MetroProgressBar()
        Me.pic_logo = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBoxInfoCalendar.SuspendLayout()
        Me.PanelCalendar.SuspendLayout()
        CType(Me.picCalBlau, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCalTaronja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCalendar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxCalendar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDies.SuspendLayout()
        Me.GroupAssigTemp.SuspendLayout()
        Me.GroupPRG.SuspendLayout()
        Me.GroupEmissio.SuspendLayout()
        Me.GroupQualitat.SuspendLayout()
        CType(Me.picLock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUnLock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdSortir
        '
        Me.cmdSortir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdSortir.Image = CType(resources.GetObject("cmdSortir.Image"), System.Drawing.Image)
        Me.cmdSortir.Location = New System.Drawing.Point(100, 86)
        Me.cmdSortir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdSortir.Name = "cmdSortir"
        Me.cmdSortir.Size = New System.Drawing.Size(20, 21)
        Me.cmdSortir.TabIndex = 3
        Me.cmdSortir.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdExitTool, Me.cmdNou, Me.cmdBloqueix, Me.cmdDelMassive, Me.cmdDel, Me.cmdSalvar, Me.ToolStripSeparator2, Me.ldNou})
        Me.ToolStrip1.Location = New System.Drawing.Point(23, 78)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(976, 39)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'cmdExitTool
        '
        Me.cmdExitTool.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.cmdExitTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdExitTool.Image = CType(resources.GetObject("cmdExitTool.Image"), System.Drawing.Image)
        Me.cmdExitTool.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdExitTool.Name = "cmdExitTool"
        Me.cmdExitTool.Size = New System.Drawing.Size(36, 36)
        Me.cmdExitTool.Text = "Sortir"
        Me.cmdExitTool.ToolTipText = "Tancar pantalla"
        '
        'cmdNou
        '
        Me.cmdNou.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdNou.Image = CType(resources.GetObject("cmdNou.Image"), System.Drawing.Image)
        Me.cmdNou.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdNou.Name = "cmdNou"
        Me.cmdNou.Size = New System.Drawing.Size(36, 36)
        Me.cmdNou.Text = "Nou ítem"
        '
        'cmdBloqueix
        '
        Me.cmdBloqueix.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdBloqueix.Image = CType(resources.GetObject("cmdBloqueix.Image"), System.Drawing.Image)
        Me.cmdBloqueix.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdBloqueix.Name = "cmdBloqueix"
        Me.cmdBloqueix.Size = New System.Drawing.Size(36, 36)
        Me.cmdBloqueix.Text = "Editar ítem"
        '
        'cmdDelMassive
        '
        Me.cmdDelMassive.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdDelMassive.Enabled = False
        Me.cmdDelMassive.Image = CType(resources.GetObject("cmdDelMassive.Image"), System.Drawing.Image)
        Me.cmdDelMassive.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdDelMassive.Name = "cmdDelMassive"
        Me.cmdDelMassive.Size = New System.Drawing.Size(36, 36)
        Me.cmdDelMassive.Text = "Eliminació massiva del Logger"
        '
        'cmdDel
        '
        Me.cmdDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdDel.Enabled = False
        Me.cmdDel.Image = CType(resources.GetObject("cmdDel.Image"), System.Drawing.Image)
        Me.cmdDel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdDel.Name = "cmdDel"
        Me.cmdDel.Size = New System.Drawing.Size(36, 36)
        Me.cmdDel.Text = "Borrar ítem"
        Me.cmdDel.ToolTipText = "Borrar ítem"
        '
        'cmdSalvar
        '
        Me.cmdSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdSalvar.Enabled = False
        Me.cmdSalvar.Image = CType(resources.GetObject("cmdSalvar.Image"), System.Drawing.Image)
        Me.cmdSalvar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSalvar.Name = "cmdSalvar"
        Me.cmdSalvar.Size = New System.Drawing.Size(36, 36)
        Me.cmdSalvar.Text = "Salvar ítem"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'ldNou
        '
        Me.ldNou.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ldNou.ForeColor = System.Drawing.Color.Red
        Me.ldNou.Name = "ldNou"
        Me.ldNou.Size = New System.Drawing.Size(60, 36)
        Me.ldNou.Text = "NOU"
        Me.ldNou.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgarmaToolStripMenuItem, Me.EdicióToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(771, 29)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(229, 26)
        Me.MenuStrip1.TabIndex = 178
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
        Me.EdicióToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuModif, Me.mnuSave, Me.mnuNew, Me.mnuDel})
        Me.EdicióToolStripMenuItem.Image = CType(resources.GetObject("EdicióToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EdicióToolStripMenuItem.Name = "EdicióToolStripMenuItem"
        Me.EdicióToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.EdicióToolStripMenuItem.Text = "Edició"
        '
        'mnuModif
        '
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
        'ImageListCalendar
        '
        Me.ImageListCalendar.ImageStream = CType(resources.GetObject("ImageListCalendar.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListCalendar.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListCalendar.Images.SetKeyName(0, "Sin título-1.gif")
        Me.ImageListCalendar.Images.SetKeyName(1, "calendar2.gif")
        Me.ImageListCalendar.Images.SetKeyName(2, "calendar_date.png")
        '
        'GroupBoxInfoCalendar
        '
        Me.GroupBoxInfoCalendar.Controls.Add(Me.Label2)
        Me.GroupBoxInfoCalendar.Controls.Add(Me.Label4)
        Me.GroupBoxInfoCalendar.Controls.Add(Me.lbNomDirecte)
        Me.GroupBoxInfoCalendar.Controls.Add(Me.lbNomCentral)
        Me.GroupBoxInfoCalendar.Location = New System.Drawing.Point(13, 578)
        Me.GroupBoxInfoCalendar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBoxInfoCalendar.Name = "GroupBoxInfoCalendar"
        Me.GroupBoxInfoCalendar.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBoxInfoCalendar.Size = New System.Drawing.Size(387, 74)
        Me.GroupBoxInfoCalendar.TabIndex = 231
        Me.GroupBoxInfoCalendar.TabStop = False
        Me.GroupBoxInfoCalendar.Text = "Llegenda del calendari"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(34, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 12)
        Me.Label2.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Orange
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Location = New System.Drawing.Point(34, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 12)
        Me.Label4.TabIndex = 4
        '
        'lbNomDirecte
        '
        Me.lbNomDirecte.AutoSize = True
        Me.lbNomDirecte.Location = New System.Drawing.Point(68, 49)
        Me.lbNomDirecte.Name = "lbNomDirecte"
        Me.lbNomDirecte.Size = New System.Drawing.Size(242, 17)
        Me.lbNomDirecte.TabIndex = 2
        Me.lbNomDirecte.Text = "Enregistrament programat per una data"
        '
        'lbNomCentral
        '
        Me.lbNomCentral.AutoSize = True
        Me.lbNomCentral.Location = New System.Drawing.Point(68, 22)
        Me.lbNomCentral.Name = "lbNomCentral"
        Me.lbNomCentral.Size = New System.Drawing.Size(313, 17)
        Me.lbNomCentral.TabIndex = 1
        Me.lbNomCentral.Text = "Enregistrament programat per un dia de la setmana"
        '
        'PanelCalendar
        '
        Me.PanelCalendar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelCalendar.AutoScroll = True
        Me.PanelCalendar.BackColor = System.Drawing.SystemColors.Window
        Me.PanelCalendar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelCalendar.Controls.Add(Me.picCalBlau)
        Me.PanelCalendar.Controls.Add(Me.picCalTaronja)
        Me.PanelCalendar.Controls.Add(Me.picCalendar)
        Me.PanelCalendar.Controls.Add(Me.picHores)
        Me.PanelCalendar.Location = New System.Drawing.Point(412, 196)
        Me.PanelCalendar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelCalendar.Name = "PanelCalendar"
        Me.PanelCalendar.Size = New System.Drawing.Size(588, 362)
        Me.PanelCalendar.TabIndex = 194
        '
        'picCalBlau
        '
        Me.picCalBlau.Image = CType(resources.GetObject("picCalBlau.Image"), System.Drawing.Image)
        Me.picCalBlau.Location = New System.Drawing.Point(406, 485)
        Me.picCalBlau.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picCalBlau.Name = "picCalBlau"
        Me.picCalBlau.Size = New System.Drawing.Size(83, 48)
        Me.picCalBlau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCalBlau.TabIndex = 37
        Me.picCalBlau.TabStop = False
        Me.picCalBlau.Visible = False
        '
        'picCalTaronja
        '
        Me.picCalTaronja.Image = CType(resources.GetObject("picCalTaronja.Image"), System.Drawing.Image)
        Me.picCalTaronja.Location = New System.Drawing.Point(406, 407)
        Me.picCalTaronja.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picCalTaronja.Name = "picCalTaronja"
        Me.picCalTaronja.Size = New System.Drawing.Size(83, 48)
        Me.picCalTaronja.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCalTaronja.TabIndex = 36
        Me.picCalTaronja.TabStop = False
        Me.picCalTaronja.Visible = False
        '
        'picCalendar
        '
        Me.picCalendar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picCalendar.InitialImage = Nothing
        Me.picCalendar.Location = New System.Drawing.Point(54, 5)
        Me.picCalendar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picCalendar.Name = "picCalendar"
        Me.picCalendar.Size = New System.Drawing.Size(505, 1347)
        Me.picCalendar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCalendar.TabIndex = 3
        Me.picCalendar.TabStop = False
        '
        'picHores
        '
        Me.picHores.Location = New System.Drawing.Point(3, 9)
        Me.picHores.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picHores.Name = "picHores"
        Me.picHores.Size = New System.Drawing.Size(42, 1348)
        Me.picHores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHores.TabIndex = 6
        Me.picHores.TabStop = False
        '
        'buttonResizeCalendarMenys
        '
        Me.buttonResizeCalendarMenys.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonResizeCalendarMenys.Location = New System.Drawing.Point(975, 130)
        Me.buttonResizeCalendarMenys.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.buttonResizeCalendarMenys.Name = "buttonResizeCalendarMenys"
        Me.buttonResizeCalendarMenys.Size = New System.Drawing.Size(21, 25)
        Me.buttonResizeCalendarMenys.TabIndex = 6
        Me.buttonResizeCalendarMenys.Text = "-"
        Me.buttonResizeCalendarMenys.UseVisualStyleBackColor = True
        '
        'buttonResizeCalendarMes
        '
        Me.buttonResizeCalendarMes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonResizeCalendarMes.Location = New System.Drawing.Point(948, 130)
        Me.buttonResizeCalendarMes.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.buttonResizeCalendarMes.Name = "buttonResizeCalendarMes"
        Me.buttonResizeCalendarMes.Size = New System.Drawing.Size(21, 25)
        Me.buttonResizeCalendarMes.TabIndex = 5
        Me.buttonResizeCalendarMes.Text = "+"
        Me.buttonResizeCalendarMes.UseVisualStyleBackColor = True
        '
        'cmdAnt
        '
        Me.cmdAnt.Location = New System.Drawing.Point(461, 130)
        Me.cmdAnt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdAnt.Name = "cmdAnt"
        Me.cmdAnt.Size = New System.Drawing.Size(37, 25)
        Me.cmdAnt.TabIndex = 1
        Me.cmdAnt.Text = "<"
        Me.cmdAnt.UseVisualStyleBackColor = True
        '
        'DateTimePickerCalendar
        '
        Me.DateTimePickerCalendar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DateTimePickerCalendar.Location = New System.Drawing.Point(644, 130)
        Me.DateTimePickerCalendar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DateTimePickerCalendar.Name = "DateTimePickerCalendar"
        Me.DateTimePickerCalendar.Size = New System.Drawing.Size(258, 25)
        Me.DateTimePickerCalendar.TabIndex = 4
        Me.DateTimePickerCalendar.Value = New Date(2010, 1, 26, 0, 0, 0, 0)
        '
        'PictureBoxCalendar
        '
        Me.PictureBoxCalendar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxCalendar.Image = CType(resources.GetObject("PictureBoxCalendar.Image"), System.Drawing.Image)
        Me.PictureBoxCalendar.Location = New System.Drawing.Point(412, 130)
        Me.PictureBoxCalendar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBoxCalendar.Name = "PictureBoxCalendar"
        Me.PictureBoxCalendar.Size = New System.Drawing.Size(33, 32)
        Me.PictureBoxCalendar.TabIndex = 21
        Me.PictureBoxCalendar.TabStop = False
        Me.PictureBoxCalendar.Tag = "2"
        '
        'pnlDies
        '
        Me.pnlDies.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlDies.Controls.Add(Me.lbDll)
        Me.pnlDies.Controls.Add(Me.lbDts)
        Me.pnlDies.Controls.Add(Me.lbDres)
        Me.pnlDies.Controls.Add(Me.lbDj)
        Me.pnlDies.Controls.Add(Me.lbDv)
        Me.pnlDies.Controls.Add(Me.lbDs)
        Me.pnlDies.Controls.Add(Me.lbDg)
        Me.pnlDies.Location = New System.Drawing.Point(461, 159)
        Me.pnlDies.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlDies.Name = "pnlDies"
        Me.pnlDies.Size = New System.Drawing.Size(505, 39)
        Me.pnlDies.TabIndex = 20
        '
        'lbDll
        '
        Me.lbDll.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbDll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDll.Location = New System.Drawing.Point(3, 5)
        Me.lbDll.Name = "lbDll"
        Me.lbDll.Size = New System.Drawing.Size(97, 17)
        Me.lbDll.TabIndex = 12
        Me.lbDll.Text = "Label2"
        Me.lbDll.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbDts
        '
        Me.lbDts.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbDts.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDts.Location = New System.Drawing.Point(62, 5)
        Me.lbDts.Name = "lbDts"
        Me.lbDts.Size = New System.Drawing.Size(97, 17)
        Me.lbDts.TabIndex = 13
        Me.lbDts.Text = "Label5"
        Me.lbDts.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbDres
        '
        Me.lbDres.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbDres.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDres.Location = New System.Drawing.Point(122, 5)
        Me.lbDres.Name = "lbDres"
        Me.lbDres.Size = New System.Drawing.Size(97, 17)
        Me.lbDres.TabIndex = 14
        Me.lbDres.Text = "Label8"
        Me.lbDres.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbDj
        '
        Me.lbDj.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbDj.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDj.Location = New System.Drawing.Point(181, 5)
        Me.lbDj.Name = "lbDj"
        Me.lbDj.Size = New System.Drawing.Size(97, 17)
        Me.lbDj.TabIndex = 15
        Me.lbDj.Text = "Label9"
        Me.lbDj.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbDv
        '
        Me.lbDv.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbDv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDv.Location = New System.Drawing.Point(241, 5)
        Me.lbDv.Name = "lbDv"
        Me.lbDv.Size = New System.Drawing.Size(106, 17)
        Me.lbDv.TabIndex = 16
        Me.lbDv.Text = "Label10"
        Me.lbDv.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbDs
        '
        Me.lbDs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbDs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDs.Location = New System.Drawing.Point(307, 5)
        Me.lbDs.Name = "lbDs"
        Me.lbDs.Size = New System.Drawing.Size(106, 17)
        Me.lbDs.TabIndex = 17
        Me.lbDs.Text = "Label11"
        Me.lbDs.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbDg
        '
        Me.lbDg.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbDg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDg.Location = New System.Drawing.Point(374, 5)
        Me.lbDg.Name = "lbDg"
        Me.lbDg.Size = New System.Drawing.Size(106, 17)
        Me.lbDg.TabIndex = 18
        Me.lbDg.Text = "Label12"
        Me.lbDg.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmdActual
        '
        Me.cmdActual.Location = New System.Drawing.Point(500, 130)
        Me.cmdActual.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdActual.Name = "cmdActual"
        Me.cmdActual.Size = New System.Drawing.Size(59, 25)
        Me.cmdActual.TabIndex = 2
        Me.cmdActual.Text = "Avui"
        Me.cmdActual.UseVisualStyleBackColor = True
        '
        'cmdPost
        '
        Me.cmdPost.Location = New System.Drawing.Point(562, 130)
        Me.cmdPost.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdPost.Name = "cmdPost"
        Me.cmdPost.Size = New System.Drawing.Size(37, 25)
        Me.cmdPost.TabIndex = 3
        Me.cmdPost.Text = ">"
        Me.cmdPost.UseVisualStyleBackColor = True
        '
        'lbFet
        '
        Me.lbFet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFet.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbFet.Image = CType(resources.GetObject("lbFet.Image"), System.Drawing.Image)
        Me.lbFet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbFet.Location = New System.Drawing.Point(161, 548)
        Me.lbFet.Name = "lbFet"
        Me.lbFet.Size = New System.Drawing.Size(154, 25)
        Me.lbFet.TabIndex = 180
        Me.lbFet.Text = "Còpia realitzada"
        Me.lbFet.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbFet.Visible = False
        '
        'GroupAssigTemp
        '
        Me.GroupAssigTemp.Controls.Add(Me.optDataHora)
        Me.GroupAssigTemp.Controls.Add(Me.lbID)
        Me.GroupAssigTemp.Controls.Add(Me.txtDurada)
        Me.GroupAssigTemp.Controls.Add(Me.Label8)
        Me.GroupAssigTemp.Controls.Add(Me.Label61)
        Me.GroupAssigTemp.Controls.Add(Me.txtDataIn)
        Me.GroupAssigTemp.Controls.Add(Me.txtDataOut)
        Me.GroupAssigTemp.Controls.Add(Me.txtHoraIni)
        Me.GroupAssigTemp.Controls.Add(Me.optSetmHora)
        Me.GroupAssigTemp.Controls.Add(Me.Label3)
        Me.GroupAssigTemp.Controls.Add(Me.Label60)
        Me.GroupAssigTemp.Location = New System.Drawing.Point(15, 117)
        Me.GroupAssigTemp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupAssigTemp.Name = "GroupAssigTemp"
        Me.GroupAssigTemp.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupAssigTemp.Size = New System.Drawing.Size(387, 101)
        Me.GroupAssigTemp.TabIndex = 1
        Me.GroupAssigTemp.TabStop = False
        '
        'optDataHora
        '
        Me.optDataHora.AutoSize = True
        Me.optDataHora.Location = New System.Drawing.Point(220, 15)
        Me.optDataHora.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.optDataHora.Name = "optDataHora"
        Me.optDataHora.Size = New System.Drawing.Size(165, 21)
        Me.optDataHora.TabIndex = 2
        Me.optDataHora.Text = "Per una data en concret"
        Me.optDataHora.UseVisualStyleBackColor = True
        '
        'lbID
        '
        Me.lbID.AutoSize = True
        Me.lbID.BackColor = System.Drawing.Color.Chartreuse
        Me.lbID.Location = New System.Drawing.Point(366, 48)
        Me.lbID.Name = "lbID"
        Me.lbID.Size = New System.Drawing.Size(15, 17)
        Me.lbID.TabIndex = 195
        Me.lbID.Text = "0"
        Me.lbID.Visible = False
        '
        'txtDurada
        '
        Me.txtDurada.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.txtDurada.Location = New System.Drawing.Point(275, 70)
        Me.txtDurada.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDurada.MaxDate = New Date(1970, 1, 1, 23, 59, 59, 0)
        Me.txtDurada.MinDate = New Date(1970, 1, 1, 0, 0, 0, 0)
        Me.txtDurada.Name = "txtDurada"
        Me.txtDurada.ShowUpDown = True
        Me.txtDurada.Size = New System.Drawing.Size(96, 25)
        Me.txtDurada.TabIndex = 3
        Me.txtDurada.Value = New Date(1970, 1, 1, 23, 0, 0, 0)
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(202, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 17)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Durada"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Location = New System.Drawing.Point(260, 45)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(13, 17)
        Me.Label61.TabIndex = 232
        Me.Label61.Text = "-"
        '
        'txtDataIn
        '
        Me.txtDataIn.Location = New System.Drawing.Point(47, 39)
        Me.txtDataIn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDataIn.Name = "txtDataIn"
        Me.txtDataIn.Size = New System.Drawing.Size(212, 25)
        Me.txtDataIn.TabIndex = 0
        '
        'txtDataOut
        '
        Me.txtDataOut.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDataOut.Location = New System.Drawing.Point(275, 39)
        Me.txtDataOut.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDataOut.Name = "txtDataOut"
        Me.txtDataOut.Size = New System.Drawing.Size(96, 25)
        Me.txtDataOut.TabIndex = 1
        Me.txtDataOut.Visible = False
        '
        'txtHoraIni
        '
        Me.txtHoraIni.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.txtHoraIni.Location = New System.Drawing.Point(122, 70)
        Me.txtHoraIni.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtHoraIni.MaxDate = New Date(1970, 1, 1, 23, 59, 59, 0)
        Me.txtHoraIni.MinDate = New Date(1970, 1, 1, 0, 0, 0, 0)
        Me.txtHoraIni.Name = "txtHoraIni"
        Me.txtHoraIni.ShowUpDown = True
        Me.txtHoraIni.Size = New System.Drawing.Size(74, 25)
        Me.txtHoraIni.TabIndex = 2
        Me.txtHoraIni.Value = New Date(1970, 1, 1, 23, 0, 0, 0)
        '
        'optSetmHora
        '
        Me.optSetmHora.AutoSize = True
        Me.optSetmHora.Checked = True
        Me.optSetmHora.Location = New System.Drawing.Point(9, 13)
        Me.optSetmHora.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.optSetmHora.Name = "optSetmHora"
        Me.optSetmHora.Size = New System.Drawing.Size(211, 21)
        Me.optSetmHora.TabIndex = 1
        Me.optSetmHora.TabStop = True
        Me.optSetmHora.Text = "Dies de la setmana (Dll, Dt,Dc,..)"
        Me.optSetmHora.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(4, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Hora inici"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label60
        '
        Me.Label60.Location = New System.Drawing.Point(2, 45)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(44, 17)
        Me.Label60.TabIndex = 231
        Me.Label60.Text = "Fecha"
        Me.Label60.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'chkPodcasting
        '
        Me.chkPodcasting.AutoSize = True
        Me.chkPodcasting.Enabled = False
        Me.chkPodcasting.Location = New System.Drawing.Point(20, 552)
        Me.chkPodcasting.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkPodcasting.Name = "chkPodcasting"
        Me.chkPodcasting.Size = New System.Drawing.Size(115, 21)
        Me.chkPodcasting.TabIndex = 19
        Me.chkPodcasting.Text = "Publicar al web"
        Me.chkPodcasting.UseVisualStyleBackColor = True
        '
        'GroupPRG
        '
        Me.GroupPRG.Controls.Add(Me.ComboBoxProgrames)
        Me.GroupPRG.Controls.Add(Me.chkReEmissio)
        Me.GroupPRG.Controls.Add(Me.Label12)
        Me.GroupPRG.Controls.Add(Me.GroupEmissio)
        Me.GroupPRG.Enabled = False
        Me.GroupPRG.Location = New System.Drawing.Point(15, 338)
        Me.GroupPRG.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupPRG.Name = "GroupPRG"
        Me.GroupPRG.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupPRG.Size = New System.Drawing.Size(387, 211)
        Me.GroupPRG.TabIndex = 7
        Me.GroupPRG.TabStop = False
        Me.GroupPRG.Text = "Programa"
        '
        'ComboBoxProgrames
        '
        Me.ComboBoxProgrames.FormattingEnabled = True
        Me.ComboBoxProgrames.Location = New System.Drawing.Point(68, 18)
        Me.ComboBoxProgrames.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBoxProgrames.Name = "ComboBoxProgrames"
        Me.ComboBoxProgrames.Size = New System.Drawing.Size(284, 25)
        Me.ComboBoxProgrames.TabIndex = 0
        '
        'chkReEmissio
        '
        Me.chkReEmissio.AutoSize = True
        Me.chkReEmissio.Location = New System.Drawing.Point(68, 47)
        Me.chkReEmissio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkReEmissio.Name = "chkReEmissio"
        Me.chkReEmissio.Size = New System.Drawing.Size(79, 21)
        Me.chkReEmissio.TabIndex = 1
        Me.chkReEmissio.Text = "Remissió"
        Me.chkReEmissio.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 17)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Nom"
        '
        'GroupEmissio
        '
        Me.GroupEmissio.Controls.Add(Me.txtHoraRemissio)
        Me.GroupEmissio.Controls.Add(Me.Label14)
        Me.GroupEmissio.Controls.Add(Me.Label15)
        Me.GroupEmissio.Controls.Add(Me.Label16)
        Me.GroupEmissio.Controls.Add(Me.ComboDiaSetmanaReEmissor)
        Me.GroupEmissio.Controls.Add(Me.txtDataReemissor)
        Me.GroupEmissio.Controls.Add(Me.optSetmHoraReEmissor)
        Me.GroupEmissio.Controls.Add(Me.optDataHoraReEmissor)
        Me.GroupEmissio.Enabled = False
        Me.GroupEmissio.Location = New System.Drawing.Point(6, 62)
        Me.GroupEmissio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupEmissio.Name = "GroupEmissio"
        Me.GroupEmissio.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupEmissio.Size = New System.Drawing.Size(373, 145)
        Me.GroupEmissio.TabIndex = 9
        Me.GroupEmissio.TabStop = False
        Me.GroupEmissio.Text = "Remissió"
        '
        'txtHoraRemissio
        '
        Me.txtHoraRemissio.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.txtHoraRemissio.Location = New System.Drawing.Point(131, 84)
        Me.txtHoraRemissio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtHoraRemissio.Name = "txtHoraRemissio"
        Me.txtHoraRemissio.ShowUpDown = True
        Me.txtHoraRemissio.Size = New System.Drawing.Size(116, 25)
        Me.txtHoraRemissio.TabIndex = 2
        Me.txtHoraRemissio.Value = New Date(1970, 1, 1, 23, 0, 0, 0)
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(28, 122)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(99, 17)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Dia (el següent)"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(87, 86)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(37, 17)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "Hora"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(87, 50)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(35, 17)
        Me.Label16.TabIndex = 12
        Me.Label16.Text = "Data"
        '
        'ComboDiaSetmanaReEmissor
        '
        Me.ComboDiaSetmanaReEmissor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboDiaSetmanaReEmissor.Enabled = False
        Me.ComboDiaSetmanaReEmissor.FormattingEnabled = True
        Me.ComboDiaSetmanaReEmissor.Location = New System.Drawing.Point(129, 116)
        Me.ComboDiaSetmanaReEmissor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboDiaSetmanaReEmissor.Name = "ComboDiaSetmanaReEmissor"
        Me.ComboDiaSetmanaReEmissor.Size = New System.Drawing.Size(116, 25)
        Me.ComboDiaSetmanaReEmissor.TabIndex = 3
        '
        'txtDataReemissor
        '
        Me.txtDataReemissor.Location = New System.Drawing.Point(131, 50)
        Me.txtDataReemissor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDataReemissor.Name = "txtDataReemissor"
        Me.txtDataReemissor.Size = New System.Drawing.Size(214, 25)
        Me.txtDataReemissor.TabIndex = 1
        '
        'optSetmHoraReEmissor
        '
        Me.optSetmHoraReEmissor.AutoSize = True
        Me.optSetmHoraReEmissor.Location = New System.Drawing.Point(20, 20)
        Me.optSetmHoraReEmissor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.optSetmHoraReEmissor.Name = "optSetmHoraReEmissor"
        Me.optSetmHoraReEmissor.Size = New System.Drawing.Size(133, 21)
        Me.optSetmHoraReEmissor.TabIndex = 14
        Me.optSetmHoraReEmissor.Text = "Dia Setmana/Hora"
        Me.optSetmHoraReEmissor.UseVisualStyleBackColor = True
        '
        'optDataHoraReEmissor
        '
        Me.optDataHoraReEmissor.AutoSize = True
        Me.optDataHoraReEmissor.Checked = True
        Me.optDataHoraReEmissor.Location = New System.Drawing.Point(167, 20)
        Me.optDataHoraReEmissor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.optDataHoraReEmissor.Name = "optDataHoraReEmissor"
        Me.optDataHoraReEmissor.Size = New System.Drawing.Size(87, 21)
        Me.optDataHoraReEmissor.TabIndex = 0
        Me.optDataHoraReEmissor.TabStop = True
        Me.optDataHoraReEmissor.Text = "Data/Hora"
        Me.optDataHoraReEmissor.UseVisualStyleBackColor = True
        '
        'chksaveAsPrg
        '
        Me.chksaveAsPrg.AutoSize = True
        Me.chksaveAsPrg.Location = New System.Drawing.Point(22, 318)
        Me.chksaveAsPrg.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chksaveAsPrg.Name = "chksaveAsPrg"
        Me.chksaveAsPrg.Size = New System.Drawing.Size(266, 21)
        Me.chksaveAsPrg.TabIndex = 0
        Me.chksaveAsPrg.Text = "Salvar com a nova sessió d'un programa"
        Me.chksaveAsPrg.UseVisualStyleBackColor = True
        '
        'GroupQualitat
        '
        Me.GroupQualitat.Controls.Add(Me.ComboBoxSelectQualitatRec)
        Me.GroupQualitat.Controls.Add(Me.Label9)
        Me.GroupQualitat.Controls.Add(Me.Label10)
        Me.GroupQualitat.Controls.Add(Me.Label11)
        Me.GroupQualitat.Controls.Add(Me.ComboCanalsAudio)
        Me.GroupQualitat.Controls.Add(Me.ComboSampleRate)
        Me.GroupQualitat.Controls.Add(Me.ComboBitRate)
        Me.GroupQualitat.Enabled = False
        Me.GroupQualitat.Location = New System.Drawing.Point(15, 220)
        Me.GroupQualitat.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupQualitat.Name = "GroupQualitat"
        Me.GroupQualitat.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupQualitat.Size = New System.Drawing.Size(387, 95)
        Me.GroupQualitat.TabIndex = 2
        Me.GroupQualitat.TabStop = False
        Me.GroupQualitat.Text = "Qualitat"
        '
        'ComboBoxSelectQualitatRec
        '
        Me.ComboBoxSelectQualitatRec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSelectQualitatRec.FormattingEnabled = True
        Me.ComboBoxSelectQualitatRec.Items.AddRange(New Object() {"Valors per defecte", "Alta fidelitat", "Baixa fidelitat"})
        Me.ComboBoxSelectQualitatRec.Location = New System.Drawing.Point(57, 3)
        Me.ComboBoxSelectQualitatRec.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBoxSelectQualitatRec.Name = "ComboBoxSelectQualitatRec"
        Me.ComboBoxSelectQualitatRec.Size = New System.Drawing.Size(182, 25)
        Me.ComboBoxSelectQualitatRec.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(7, 69)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 17)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Canals d'audio"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(202, 38)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 17)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Freqüència (Hz)"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(7, 38)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 17)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Bitrate (Kbps)"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ComboCanalsAudio
        '
        Me.ComboCanalsAudio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboCanalsAudio.FormattingEnabled = True
        Me.ComboCanalsAudio.Items.AddRange(New Object() {"MONO", "STEREO"})
        Me.ComboCanalsAudio.Location = New System.Drawing.Point(122, 65)
        Me.ComboCanalsAudio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboCanalsAudio.Name = "ComboCanalsAudio"
        Me.ComboCanalsAudio.Size = New System.Drawing.Size(74, 25)
        Me.ComboCanalsAudio.TabIndex = 2
        '
        'ComboSampleRate
        '
        Me.ComboSampleRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboSampleRate.FormattingEnabled = True
        Me.ComboSampleRate.Items.AddRange(New Object() {"22050", "32000", "44100", "48000"})
        Me.ComboSampleRate.Location = New System.Drawing.Point(308, 34)
        Me.ComboSampleRate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboSampleRate.Name = "ComboSampleRate"
        Me.ComboSampleRate.Size = New System.Drawing.Size(72, 25)
        Me.ComboSampleRate.TabIndex = 3
        '
        'ComboBitRate
        '
        Me.ComboBitRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBitRate.FormattingEnabled = True
        Me.ComboBitRate.Items.AddRange(New Object() {"8 ", "16", "24", "32", "40", "48", "56", "64", "80", "96", "112", "128", "144", "160", "192", "224", "256", "320"})
        Me.ComboBitRate.Location = New System.Drawing.Point(122, 34)
        Me.ComboBitRate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBitRate.Name = "ComboBitRate"
        Me.ComboBitRate.Size = New System.Drawing.Size(74, 25)
        Me.ComboBitRate.TabIndex = 1
        '
        'picLock
        '
        Me.picLock.Image = CType(resources.GetObject("picLock.Image"), System.Drawing.Image)
        Me.picLock.Location = New System.Drawing.Point(475, 9)
        Me.picLock.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picLock.Name = "picLock"
        Me.picLock.Size = New System.Drawing.Size(45, 46)
        Me.picLock.TabIndex = 232
        Me.picLock.TabStop = False
        Me.picLock.Visible = False
        '
        'picUnLock
        '
        Me.picUnLock.Image = CType(resources.GetObject("picUnLock.Image"), System.Drawing.Image)
        Me.picUnLock.Location = New System.Drawing.Point(526, 11)
        Me.picUnLock.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picUnLock.Name = "picUnLock"
        Me.picUnLock.Size = New System.Drawing.Size(47, 44)
        Me.picUnLock.TabIndex = 233
        Me.picUnLock.TabStop = False
        Me.picUnLock.Visible = False
        '
        'ProgressBar
        '
        Me.ProgressBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar.HideProgressText = False
        Me.ProgressBar.Location = New System.Drawing.Point(672, 86)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(285, 24)
        Me.ProgressBar.TabIndex = 234
        Me.ProgressBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ProgressBar.Visible = False
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
        'frmPrgLogger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdSortir
        Me.ClientSize = New System.Drawing.Size(1022, 575)
        Me.Controls.Add(Me.pic_logo)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.PanelCalendar)
        Me.Controls.Add(Me.GroupBoxInfoCalendar)
        Me.Controls.Add(Me.buttonResizeCalendarMenys)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.buttonResizeCalendarMes)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.cmdAnt)
        Me.Controls.Add(Me.PictureBoxCalendar)
        Me.Controls.Add(Me.lbFet)
        Me.Controls.Add(Me.pnlDies)
        Me.Controls.Add(Me.DateTimePickerCalendar)
        Me.Controls.Add(Me.cmdSortir)
        Me.Controls.Add(Me.GroupAssigTemp)
        Me.Controls.Add(Me.chkPodcasting)
        Me.Controls.Add(Me.cmdActual)
        Me.Controls.Add(Me.GroupQualitat)
        Me.Controls.Add(Me.cmdPost)
        Me.Controls.Add(Me.chksaveAsPrg)
        Me.Controls.Add(Me.GroupPRG)
        Me.Controls.Add(Me.picLock)
        Me.Controls.Add(Me.picUnLock)
        Me.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmPrgLogger"
        Me.Padding = New System.Windows.Forms.Padding(23, 78, 23, 26)
        Me.Text = "Programació de la còpia testimoni (Logger)"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBoxInfoCalendar.ResumeLayout(False)
        Me.GroupBoxInfoCalendar.PerformLayout()
        Me.PanelCalendar.ResumeLayout(False)
        CType(Me.picCalBlau, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCalTaronja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCalendar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxCalendar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDies.ResumeLayout(False)
        Me.GroupAssigTemp.ResumeLayout(False)
        Me.GroupAssigTemp.PerformLayout()
        Me.GroupPRG.ResumeLayout(False)
        Me.GroupPRG.PerformLayout()
        Me.GroupEmissio.ResumeLayout(False)
        Me.GroupEmissio.PerformLayout()
        Me.GroupQualitat.ResumeLayout(False)
        CType(Me.picLock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUnLock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private picCalTaronja As System.Windows.Forms.PictureBox
    Private picCalBlau As System.Windows.Forms.PictureBox
    Private WithEvents buttonResizeCalendarMes As System.Windows.Forms.Button
    Private WithEvents buttonResizeCalendarMenys As System.Windows.Forms.Button
    Friend WithEvents cmdSortir As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdExitTool As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdNou As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdBloqueix As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdDel As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdSalvar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdDelMassive As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ldNou As System.Windows.Forms.ToolStripLabel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ProgarmaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EdicióToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuModif As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ImageListCalendar As System.Windows.Forms.ImageList
    Friend WithEvents PanelCalendar As System.Windows.Forms.Panel
    Friend WithEvents PictureBoxCalendar As System.Windows.Forms.PictureBox
    Friend WithEvents pnlDies As System.Windows.Forms.Panel
    Friend WithEvents lbDll As System.Windows.Forms.Label
    Friend WithEvents lbDts As System.Windows.Forms.Label
    Friend WithEvents lbDres As System.Windows.Forms.Label
    Friend WithEvents lbDj As System.Windows.Forms.Label
    Friend WithEvents lbDv As System.Windows.Forms.Label
    Friend WithEvents lbDs As System.Windows.Forms.Label
    Friend WithEvents lbDg As System.Windows.Forms.Label
    Friend WithEvents cmdActual As System.Windows.Forms.Button
    Friend WithEvents cmdPost As System.Windows.Forms.Button
    Friend WithEvents cmdAnt As System.Windows.Forms.Button
    Friend WithEvents picCalendar As System.Windows.Forms.PictureBox
    Friend WithEvents picHores As System.Windows.Forms.PictureBox
    Friend WithEvents DateTimePickerCalendar As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbFet As System.Windows.Forms.Label
    Friend WithEvents GroupAssigTemp As System.Windows.Forms.GroupBox
    Friend WithEvents lbID As System.Windows.Forms.Label
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents txtDataIn As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDataOut As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtHoraIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents optSetmHora As System.Windows.Forms.RadioButton
    Friend WithEvents optDataHora As System.Windows.Forms.RadioButton
    Friend WithEvents chkPodcasting As System.Windows.Forms.CheckBox
    Friend WithEvents GroupPRG As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBoxProgrames As System.Windows.Forms.ComboBox
    Friend WithEvents GroupEmissio As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ComboDiaSetmanaReEmissor As System.Windows.Forms.ComboBox
    Friend WithEvents txtDataReemissor As System.Windows.Forms.DateTimePicker
    Friend WithEvents optSetmHoraReEmissor As System.Windows.Forms.RadioButton
    Friend WithEvents optDataHoraReEmissor As System.Windows.Forms.RadioButton
    Friend WithEvents chkReEmissio As System.Windows.Forms.CheckBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents chksaveAsPrg As System.Windows.Forms.CheckBox
    Friend WithEvents GroupQualitat As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBoxSelectQualitatRec As System.Windows.Forms.ComboBox
    Friend WithEvents txtDurada As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ComboCanalsAudio As System.Windows.Forms.ComboBox
    Friend WithEvents ComboSampleRate As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBitRate As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBoxInfoCalendar As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbNomDirecte As System.Windows.Forms.Label
    Friend WithEvents lbNomCentral As System.Windows.Forms.Label
    Friend WithEvents picLock As System.Windows.Forms.PictureBox
    Friend WithEvents picUnLock As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnu_Help As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtHoraRemissio As System.Windows.Forms.DateTimePicker
    Friend WithEvents ProgressBar As MetroFramework.Controls.MetroProgressBar
    Friend WithEvents pic_logo As PictureBox
End Class
