<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsers))
        Me.picLock = New System.Windows.Forms.PictureBox()
        Me.picUnLock = New System.Windows.Forms.PictureBox()
        Me.TabControl2 = New MetroFramework.Controls.MetroTabControl()
        Me.TabPage3 = New MetroFramework.Controls.MetroTabPage()
        Me.txtCompPsw = New MetroFramework.Controls.MetroTextBox()
        Me.txtPassWord = New MetroFramework.Controls.MetroTextBox()
        Me.txtCompAlies = New MetroFramework.Controls.MetroTextBox()
        Me.txtAlies = New MetroFramework.Controls.MetroTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupProgs = New System.Windows.Forms.GroupBox()
        Me.lstPrg = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.grupLevel = New System.Windows.Forms.GroupBox()
        Me.txtNivell = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.optionLevel_Program = New System.Windows.Forms.RadioButton()
        Me.optionLevel_Admin = New System.Windows.Forms.RadioButton()
        Me.optionLevel_Usuari = New System.Windows.Forms.RadioButton()
        Me.optionLevel_Convi = New System.Windows.Forms.RadioButton()
        Me.txtCaducUsr = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chkCaduc = New System.Windows.Forms.CheckBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbID = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TabPage4 = New MetroFramework.Controls.MetroTabPage()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lbPswErr = New System.Windows.Forms.Label()
        Me.lbDataUltIntErr = New System.Windows.Forms.Label()
        Me.lbNIntentsErr = New System.Windows.Forms.Label()
        Me.lbdataUltdesconex = New System.Windows.Forms.Label()
        Me.lbDataUltConex = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbDataCrea = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbUSR = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.cmdNou = New System.Windows.Forms.ToolStripButton()
        Me.cmdBloqueix = New System.Windows.Forms.ToolStripButton()
        Me.cmdBorrar = New System.Windows.Forms.ToolStripButton()
        Me.cmdSalvar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdSortir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.lbNewUser = New System.Windows.Forms.ToolStripLabel()
        Me.pic_logo = New System.Windows.Forms.PictureBox()
        CType(Me.picLock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUnLock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupProgs.SuspendLayout()
        Me.grupLevel.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picLock
        '
        Me.picLock.Image = CType(resources.GetObject("picLock.Image"), System.Drawing.Image)
        Me.picLock.Location = New System.Drawing.Point(460, 17)
        Me.picLock.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picLock.Name = "picLock"
        Me.picLock.Size = New System.Drawing.Size(45, 46)
        Me.picLock.TabIndex = 16
        Me.picLock.TabStop = False
        Me.picLock.Visible = False
        '
        'picUnLock
        '
        Me.picUnLock.Image = CType(resources.GetObject("picUnLock.Image"), System.Drawing.Image)
        Me.picUnLock.Location = New System.Drawing.Point(512, 16)
        Me.picUnLock.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picUnLock.Name = "picUnLock"
        Me.picUnLock.Size = New System.Drawing.Size(47, 44)
        Me.picUnLock.TabIndex = 17
        Me.picUnLock.TabStop = False
        Me.picUnLock.Visible = False
        '
        'TabControl2
        '
        Me.TabControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Location = New System.Drawing.Point(24, 121)
        Me.TabControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(650, 365)
        Me.TabControl2.TabIndex = 1
        Me.TabControl2.UseSelectable = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.txtCompPsw)
        Me.TabPage3.Controls.Add(Me.txtPassWord)
        Me.TabPage3.Controls.Add(Me.txtCompAlies)
        Me.TabPage3.Controls.Add(Me.txtAlies)
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Controls.Add(Me.GroupProgs)
        Me.TabPage3.Controls.Add(Me.Label19)
        Me.TabPage3.Controls.Add(Me.Label20)
        Me.TabPage3.Controls.Add(Me.grupLevel)
        Me.TabPage3.Controls.Add(Me.txtCaducUsr)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.chkCaduc)
        Me.TabPage3.Controls.Add(Me.txtNom)
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.lbID)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.Label22)
        Me.TabPage3.HorizontalScrollbarBarColor = True
        Me.TabPage3.HorizontalScrollbarHighlightOnWheel = False
        Me.TabPage3.HorizontalScrollbarSize = 5
        Me.TabPage3.Location = New System.Drawing.Point(4, 38)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage3.Size = New System.Drawing.Size(642, 323)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Dades Usuari"
        Me.TabPage3.UseVisualStyleBackColor = True
        Me.TabPage3.VerticalScrollbarBarColor = True
        Me.TabPage3.VerticalScrollbarHighlightOnWheel = False
        Me.TabPage3.VerticalScrollbarSize = 7
        '
        'txtCompPsw
        '
        '
        '
        '
        Me.txtCompPsw.CustomButton.Image = Nothing
        Me.txtCompPsw.CustomButton.Location = New System.Drawing.Point(88, 1)
        Me.txtCompPsw.CustomButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCompPsw.CustomButton.Name = ""
        Me.txtCompPsw.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.txtCompPsw.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCompPsw.CustomButton.TabIndex = 1
        Me.txtCompPsw.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCompPsw.CustomButton.UseSelectable = True
        Me.txtCompPsw.CustomButton.Visible = False
        Me.txtCompPsw.DisplayIcon = True
        Me.txtCompPsw.Enabled = False
        Me.txtCompPsw.Icon = CType(resources.GetObject("txtCompPsw.Icon"), System.Drawing.Image)
        Me.txtCompPsw.Lines = New String(-1) {}
        Me.txtCompPsw.Location = New System.Drawing.Point(258, 156)
        Me.txtCompPsw.MaxLength = 32767
        Me.txtCompPsw.Name = "txtCompPsw"
        Me.txtCompPsw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCompPsw.PromptText = "Contrasenya"
        Me.txtCompPsw.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCompPsw.SelectedText = ""
        Me.txtCompPsw.SelectionLength = 0
        Me.txtCompPsw.SelectionStart = 0
        Me.txtCompPsw.ShortcutsEnabled = True
        Me.txtCompPsw.Size = New System.Drawing.Size(112, 25)
        Me.txtCompPsw.TabIndex = 23
        Me.txtCompPsw.UseSelectable = True
        Me.txtCompPsw.WaterMark = "Contrasenya"
        Me.txtCompPsw.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCompPsw.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPassWord
        '
        '
        '
        '
        Me.txtPassWord.CustomButton.Image = Nothing
        Me.txtPassWord.CustomButton.Location = New System.Drawing.Point(88, 1)
        Me.txtPassWord.CustomButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPassWord.CustomButton.Name = ""
        Me.txtPassWord.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.txtPassWord.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPassWord.CustomButton.TabIndex = 1
        Me.txtPassWord.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPassWord.CustomButton.UseSelectable = True
        Me.txtPassWord.CustomButton.Visible = False
        Me.txtPassWord.DisplayIcon = True
        Me.txtPassWord.Enabled = False
        Me.txtPassWord.Icon = CType(resources.GetObject("txtPassWord.Icon"), System.Drawing.Image)
        Me.txtPassWord.Lines = New String(-1) {}
        Me.txtPassWord.Location = New System.Drawing.Point(131, 156)
        Me.txtPassWord.MaxLength = 32767
        Me.txtPassWord.Name = "txtPassWord"
        Me.txtPassWord.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassWord.PromptText = "Contrasenya"
        Me.txtPassWord.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPassWord.SelectedText = ""
        Me.txtPassWord.SelectionLength = 0
        Me.txtPassWord.SelectionStart = 0
        Me.txtPassWord.ShortcutsEnabled = True
        Me.txtPassWord.Size = New System.Drawing.Size(112, 25)
        Me.txtPassWord.TabIndex = 22
        Me.txtPassWord.UseSelectable = True
        Me.txtPassWord.WaterMark = "Contrasenya"
        Me.txtPassWord.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPassWord.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtCompAlies
        '
        '
        '
        '
        Me.txtCompAlies.CustomButton.Image = Nothing
        Me.txtCompAlies.CustomButton.Location = New System.Drawing.Point(88, 1)
        Me.txtCompAlies.CustomButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCompAlies.CustomButton.Name = ""
        Me.txtCompAlies.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.txtCompAlies.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCompAlies.CustomButton.TabIndex = 1
        Me.txtCompAlies.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCompAlies.CustomButton.UseSelectable = True
        Me.txtCompAlies.CustomButton.Visible = False
        Me.txtCompAlies.DisplayIcon = True
        Me.txtCompAlies.Enabled = False
        Me.txtCompAlies.Icon = CType(resources.GetObject("txtCompAlies.Icon"), System.Drawing.Image)
        Me.txtCompAlies.Lines = New String(-1) {}
        Me.txtCompAlies.Location = New System.Drawing.Point(259, 111)
        Me.txtCompAlies.MaxLength = 32767
        Me.txtCompAlies.Name = "txtCompAlies"
        Me.txtCompAlies.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCompAlies.PromptText = "Nom àlies"
        Me.txtCompAlies.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCompAlies.SelectedText = ""
        Me.txtCompAlies.SelectionLength = 0
        Me.txtCompAlies.SelectionStart = 0
        Me.txtCompAlies.ShortcutsEnabled = True
        Me.txtCompAlies.Size = New System.Drawing.Size(112, 25)
        Me.txtCompAlies.TabIndex = 21
        Me.txtCompAlies.UseSelectable = True
        Me.txtCompAlies.WaterMark = "Nom àlies"
        Me.txtCompAlies.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCompAlies.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtAlies
        '
        '
        '
        '
        Me.txtAlies.CustomButton.Image = Nothing
        Me.txtAlies.CustomButton.Location = New System.Drawing.Point(88, 1)
        Me.txtAlies.CustomButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAlies.CustomButton.Name = ""
        Me.txtAlies.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.txtAlies.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtAlies.CustomButton.TabIndex = 1
        Me.txtAlies.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtAlies.CustomButton.UseSelectable = True
        Me.txtAlies.CustomButton.Visible = False
        Me.txtAlies.DisplayIcon = True
        Me.txtAlies.Enabled = False
        Me.txtAlies.Icon = CType(resources.GetObject("txtAlies.Icon"), System.Drawing.Image)
        Me.txtAlies.Lines = New String(-1) {}
        Me.txtAlies.Location = New System.Drawing.Point(131, 112)
        Me.txtAlies.MaxLength = 32767
        Me.txtAlies.Name = "txtAlies"
        Me.txtAlies.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAlies.PromptText = "Nom àlies"
        Me.txtAlies.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAlies.SelectedText = ""
        Me.txtAlies.SelectionLength = 0
        Me.txtAlies.SelectionStart = 0
        Me.txtAlies.ShortcutsEnabled = True
        Me.txtAlies.Size = New System.Drawing.Size(112, 25)
        Me.txtAlies.TabIndex = 20
        Me.txtAlies.UseSelectable = True
        Me.txtAlies.WaterMark = "Nom àlies"
        Me.txtAlies.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtAlies.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(7, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Àlies, Nick :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupProgs
        '
        Me.GroupProgs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupProgs.Controls.Add(Me.lstPrg)
        Me.GroupProgs.Location = New System.Drawing.Point(385, 101)
        Me.GroupProgs.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupProgs.Name = "GroupProgs"
        Me.GroupProgs.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupProgs.Size = New System.Drawing.Size(257, 214)
        Me.GroupProgs.TabIndex = 19
        Me.GroupProgs.TabStop = False
        Me.GroupProgs.Text = "Accés a programes o pantalles"
        '
        'lstPrg
        '
        Me.lstPrg.CheckBoxes = True
        Me.lstPrg.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.lstPrg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstPrg.Enabled = False
        Me.lstPrg.GridLines = True
        Me.lstPrg.Location = New System.Drawing.Point(3, 22)
        Me.lstPrg.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstPrg.Name = "lstPrg"
        Me.lstPrg.Size = New System.Drawing.Size(251, 188)
        Me.lstPrg.TabIndex = 2
        Me.lstPrg.UseCompatibleStateImageBehavior = False
        Me.lstPrg.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nom del programa"
        Me.ColumnHeader1.Width = 170
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label19.Location = New System.Drawing.Point(330, 95)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(36, 13)
        Me.Label19.TabIndex = 17
        Me.Label19.Text = "repetir"
        '
        'Label20
        '
        Me.Label20.ForeColor = System.Drawing.Color.Blue
        Me.Label20.Location = New System.Drawing.Point(17, 282)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(354, 17)
        Me.Label20.TabIndex = 15
        Me.Label20.Text = "Les contrasenyes generades aquí caduquen als 7 dies."
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'grupLevel
        '
        Me.grupLevel.Controls.Add(Me.txtNivell)
        Me.grupLevel.Controls.Add(Me.Label9)
        Me.grupLevel.Controls.Add(Me.optionLevel_Program)
        Me.grupLevel.Controls.Add(Me.optionLevel_Admin)
        Me.grupLevel.Controls.Add(Me.optionLevel_Usuari)
        Me.grupLevel.Controls.Add(Me.optionLevel_Convi)
        Me.grupLevel.Enabled = False
        Me.grupLevel.Location = New System.Drawing.Point(384, 8)
        Me.grupLevel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grupLevel.Name = "grupLevel"
        Me.grupLevel.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grupLevel.Size = New System.Drawing.Size(258, 91)
        Me.grupLevel.TabIndex = 13
        Me.grupLevel.TabStop = False
        Me.grupLevel.Text = "Rol de gestió"
        '
        'txtNivell
        '
        Me.txtNivell.Location = New System.Drawing.Point(167, 153)
        Me.txtNivell.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNivell.Name = "txtNivell"
        Me.txtNivell.Size = New System.Drawing.Size(30, 25)
        Me.txtNivell.TabIndex = 5
        Me.txtNivell.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 157)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(159, 17)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Nivell de confiança (0-99):"
        Me.Label9.Visible = False
        '
        'optionLevel_Program
        '
        Me.optionLevel_Program.Location = New System.Drawing.Point(136, 19)
        Me.optionLevel_Program.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.optionLevel_Program.Name = "optionLevel_Program"
        Me.optionLevel_Program.Size = New System.Drawing.Size(119, 22)
        Me.optionLevel_Program.TabIndex = 3
        Me.optionLevel_Program.Text = "Programador"
        Me.optionLevel_Program.UseVisualStyleBackColor = True
        Me.optionLevel_Program.Visible = False
        '
        'optionLevel_Admin
        '
        Me.optionLevel_Admin.Location = New System.Drawing.Point(17, 63)
        Me.optionLevel_Admin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.optionLevel_Admin.Name = "optionLevel_Admin"
        Me.optionLevel_Admin.Size = New System.Drawing.Size(195, 22)
        Me.optionLevel_Admin.TabIndex = 2
        Me.optionLevel_Admin.Text = "Administrador"
        Me.optionLevel_Admin.UseVisualStyleBackColor = True
        '
        'optionLevel_Usuari
        '
        Me.optionLevel_Usuari.Location = New System.Drawing.Point(17, 41)
        Me.optionLevel_Usuari.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.optionLevel_Usuari.Name = "optionLevel_Usuari"
        Me.optionLevel_Usuari.Size = New System.Drawing.Size(195, 22)
        Me.optionLevel_Usuari.TabIndex = 1
        Me.optionLevel_Usuari.Text = "Usuari"
        Me.optionLevel_Usuari.UseVisualStyleBackColor = True
        '
        'optionLevel_Convi
        '
        Me.optionLevel_Convi.Checked = True
        Me.optionLevel_Convi.Location = New System.Drawing.Point(17, 19)
        Me.optionLevel_Convi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.optionLevel_Convi.Name = "optionLevel_Convi"
        Me.optionLevel_Convi.Size = New System.Drawing.Size(113, 22)
        Me.optionLevel_Convi.TabIndex = 0
        Me.optionLevel_Convi.TabStop = True
        Me.optionLevel_Convi.Text = "Convidat"
        Me.optionLevel_Convi.UseVisualStyleBackColor = True
        '
        'txtCaducUsr
        '
        Me.txtCaducUsr.Enabled = False
        Me.txtCaducUsr.Location = New System.Drawing.Point(131, 239)
        Me.txtCaducUsr.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCaducUsr.MinDate = New Date(1899, 12, 30, 0, 0, 0, 0)
        Me.txtCaducUsr.Name = "txtCaducUsr"
        Me.txtCaducUsr.Size = New System.Drawing.Size(240, 25)
        Me.txtCaducUsr.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(7, 245)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 17)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Data de caducitat:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'chkCaduc
        '
        Me.chkCaduc.AutoSize = True
        Me.chkCaduc.Enabled = False
        Me.chkCaduc.Location = New System.Drawing.Point(131, 200)
        Me.chkCaduc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkCaduc.Name = "chkCaduc"
        Me.chkCaduc.Size = New System.Drawing.Size(70, 21)
        Me.chkCaduc.TabIndex = 10
        Me.chkCaduc.Text = "Caduca"
        Me.chkCaduc.UseVisualStyleBackColor = True
        '
        'txtNom
        '
        Me.txtNom.Enabled = False
        Me.txtNom.Location = New System.Drawing.Point(129, 67)
        Me.txtNom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(242, 25)
        Me.txtNom.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(7, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 17)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Nom:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(7, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Contrasenya:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbID
        '
        Me.lbID.AutoSize = True
        Me.lbID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbID.Location = New System.Drawing.Point(255, 30)
        Me.lbID.Name = "lbID"
        Me.lbID.Size = New System.Drawing.Size(14, 13)
        Me.lbID.TabIndex = 1
        Me.lbID.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(164, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Identificador:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label22.Location = New System.Drawing.Point(330, 139)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(36, 13)
        Me.Label22.TabIndex = 18
        Me.Label22.Text = "repetir"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.PictureBox3)
        Me.TabPage4.Controls.Add(Me.lbPswErr)
        Me.TabPage4.Controls.Add(Me.lbDataUltIntErr)
        Me.TabPage4.Controls.Add(Me.lbNIntentsErr)
        Me.TabPage4.Controls.Add(Me.lbdataUltdesconex)
        Me.TabPage4.Controls.Add(Me.lbDataUltConex)
        Me.TabPage4.Controls.Add(Me.Label15)
        Me.TabPage4.Controls.Add(Me.Label14)
        Me.TabPage4.Controls.Add(Me.Label13)
        Me.TabPage4.Controls.Add(Me.Label12)
        Me.TabPage4.Controls.Add(Me.Label11)
        Me.TabPage4.Controls.Add(Me.lbDataCrea)
        Me.TabPage4.Controls.Add(Me.Label10)
        Me.TabPage4.HorizontalScrollbarBarColor = True
        Me.TabPage4.HorizontalScrollbarHighlightOnWheel = False
        Me.TabPage4.HorizontalScrollbarSize = 5
        Me.TabPage4.Location = New System.Drawing.Point(4, 38)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage4.Size = New System.Drawing.Size(642, 323)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Inspector"
        Me.TabPage4.UseVisualStyleBackColor = True
        Me.TabPage4.VerticalScrollbarBarColor = True
        Me.TabPage4.VerticalScrollbarHighlightOnWheel = False
        Me.TabPage4.VerticalScrollbarSize = 7
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(4, 5)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(57, 65)
        Me.PictureBox3.TabIndex = 12
        Me.PictureBox3.TabStop = False
        '
        'lbPswErr
        '
        Me.lbPswErr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPswErr.Location = New System.Drawing.Point(310, 263)
        Me.lbPswErr.Name = "lbPswErr"
        Me.lbPswErr.Size = New System.Drawing.Size(276, 17)
        Me.lbPswErr.TabIndex = 11
        '
        'lbDataUltIntErr
        '
        Me.lbDataUltIntErr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDataUltIntErr.Location = New System.Drawing.Point(310, 225)
        Me.lbDataUltIntErr.Name = "lbDataUltIntErr"
        Me.lbDataUltIntErr.Size = New System.Drawing.Size(276, 17)
        Me.lbDataUltIntErr.TabIndex = 10
        '
        'lbNIntentsErr
        '
        Me.lbNIntentsErr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNIntentsErr.Location = New System.Drawing.Point(310, 187)
        Me.lbNIntentsErr.Name = "lbNIntentsErr"
        Me.lbNIntentsErr.Size = New System.Drawing.Size(276, 17)
        Me.lbNIntentsErr.TabIndex = 9
        '
        'lbdataUltdesconex
        '
        Me.lbdataUltdesconex.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbdataUltdesconex.Location = New System.Drawing.Point(310, 149)
        Me.lbdataUltdesconex.Name = "lbdataUltdesconex"
        Me.lbdataUltdesconex.Size = New System.Drawing.Size(276, 17)
        Me.lbdataUltdesconex.TabIndex = 8
        '
        'lbDataUltConex
        '
        Me.lbDataUltConex.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDataUltConex.Location = New System.Drawing.Point(310, 111)
        Me.lbDataUltConex.Name = "lbDataUltConex"
        Me.lbDataUltConex.Size = New System.Drawing.Size(276, 17)
        Me.lbDataUltConex.TabIndex = 7
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(24, 263)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(259, 17)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "Últim PassWord erroni:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(24, 225)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(259, 17)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Data últim intent erroni:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(7, 187)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(276, 17)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Nº Intents erronis a la última connexió:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(24, 149)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(259, 17)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Data última desconnexió:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(24, 111)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(259, 17)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Data última connexió:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbDataCrea
        '
        Me.lbDataCrea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDataCrea.Location = New System.Drawing.Point(310, 73)
        Me.lbDataCrea.Name = "lbDataCrea"
        Me.lbDataCrea.Size = New System.Drawing.Size(276, 17)
        Me.lbDataCrea.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(24, 73)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(259, 17)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Data de creació:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmbUSR
        '
        Me.cmbUSR.FormattingEnabled = True
        Me.cmbUSR.Location = New System.Drawing.Point(227, 85)
        Me.cmbUSR.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbUSR.Name = "cmbUSR"
        Me.cmbUSR.Size = New System.Drawing.Size(151, 25)
        Me.cmbUSR.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdNou, Me.cmdBloqueix, Me.cmdBorrar, Me.cmdSalvar, Me.ToolStripSeparator2, Me.cmdSortir, Me.ToolStripLabel1, Me.lbNewUser})
        Me.ToolStrip1.Location = New System.Drawing.Point(23, 78)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(654, 39)
        Me.ToolStrip1.TabIndex = 93
        Me.ToolStrip1.Text = "ToolStrip1"
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
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.AutoSize = False
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(210, 36)
        Me.ToolStripLabel1.Text = "Usuari:"
        Me.ToolStripLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbNewUser
        '
        Me.lbNewUser.Font = New System.Drawing.Font("Segoe UI Symbol", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNewUser.ForeColor = System.Drawing.Color.Red
        Me.lbNewUser.Image = CType(resources.GetObject("lbNewUser.Image"), System.Drawing.Image)
        Me.lbNewUser.Name = "lbNewUser"
        Me.lbNewUser.Size = New System.Drawing.Size(155, 36)
        Me.lbNewUser.Text = "Atenció nou usuari"
        Me.lbNewUser.Visible = False
        '
        'pic_logo
        '
        Me.pic_logo.Image = CType(resources.GetObject("pic_logo.Image"), System.Drawing.Image)
        Me.pic_logo.Location = New System.Drawing.Point(25, 25)
        Me.pic_logo.Name = "pic_logo"
        Me.pic_logo.Size = New System.Drawing.Size(40, 40)
        Me.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_logo.TabIndex = 268
        Me.pic_logo.TabStop = False
        '
        'frmUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 501)
        Me.Controls.Add(Me.pic_logo)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.cmbUSR)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.picLock)
        Me.Controls.Add(Me.picUnLock)
        Me.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmUsers"
        Me.Padding = New System.Windows.Forms.Padding(23, 78, 23, 26)
        Me.Text = "Gestió d'usuaris"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        CType(Me.picLock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUnLock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GroupProgs.ResumeLayout(False)
        Me.grupLevel.ResumeLayout(False)
        Me.grupLevel.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picLock As System.Windows.Forms.PictureBox
    Friend WithEvents picUnLock As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbID As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbUSR As System.Windows.Forms.ComboBox
    Friend WithEvents txtCaducUsr As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents chkCaduc As System.Windows.Forms.CheckBox
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents grupLevel As System.Windows.Forms.GroupBox
    Friend WithEvents optionLevel_Program As System.Windows.Forms.RadioButton
    Friend WithEvents optionLevel_Admin As System.Windows.Forms.RadioButton
    Friend WithEvents optionLevel_Usuari As System.Windows.Forms.RadioButton
    Friend WithEvents optionLevel_Convi As System.Windows.Forms.RadioButton
    Friend WithEvents txtNivell As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lbDataCrea As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lbPswErr As System.Windows.Forms.Label
    Friend WithEvents lbDataUltIntErr As System.Windows.Forms.Label
    Friend WithEvents lbNIntentsErr As System.Windows.Forms.Label
    Friend WithEvents lbdataUltdesconex As System.Windows.Forms.Label
    Friend WithEvents lbDataUltConex As System.Windows.Forms.Label
    Friend WithEvents lstPrg As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdNou As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdBloqueix As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdBorrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdSalvar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdSortir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lbNewUser As System.Windows.Forms.ToolStripLabel
    Friend WithEvents GroupProgs As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl2 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents TabPage3 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents TabPage4 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents txtCompAlies As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtAlies As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtCompPsw As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPassWord As MetroFramework.Controls.MetroTextBox
    Friend WithEvents pic_logo As PictureBox
End Class
