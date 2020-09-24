<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEsdeveniment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEsdeveniment))
        Me.TabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.TabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.cmdNew = New MetroFramework.Controls.MetroTile()
        Me.cmdSave = New MetroFramework.Controls.MetroTile()
        Me.lbAtencio = New System.Windows.Forms.Label()
        Me.grupEsdev = New System.Windows.Forms.GroupBox()
        Me.lbNou = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtHoraRadi = New System.Windows.Forms.DateTimePicker()
        Me.chkForceHora = New System.Windows.Forms.CheckBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDataRadi = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbFitxer = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbTipFitxer = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkIN = New System.Windows.Forms.CheckBox()
        Me.TabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.ListEsdev = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.cmdDelCaduc = New MetroFramework.Controls.MetroButton()
        Me.cmdDelSelect = New MetroFramework.Controls.MetroButton()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdSortir = New MetroFramework.Controls.MetroLink()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.grupEsdev.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(9, 99)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(668, 369)
        Me.TabControl1.TabIndex = 0
        Me.TabControl1.UseSelectable = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.cmdNew)
        Me.TabPage1.Controls.Add(Me.cmdSave)
        Me.TabPage1.Controls.Add(Me.lbAtencio)
        Me.TabPage1.Controls.Add(Me.grupEsdev)
        Me.TabPage1.HorizontalScrollbarBarColor = True
        Me.TabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.TabPage1.HorizontalScrollbarSize = 5
        Me.TabPage1.Location = New System.Drawing.Point(4, 38)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage1.Size = New System.Drawing.Size(660, 327)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Programar"
        Me.TabPage1.UseVisualStyleBackColor = True
        Me.TabPage1.VerticalScrollbarBarColor = True
        Me.TabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.TabPage1.VerticalScrollbarSize = 7
        '
        'cmdNew
        '
        Me.cmdNew.ActiveControl = Nothing
        Me.cmdNew.Location = New System.Drawing.Point(73, 39)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(168, 49)
        Me.cmdNew.TabIndex = 36
        Me.cmdNew.Text = "Nou"
        Me.cmdNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdNew.TileImage = CType(resources.GetObject("cmdNew.TileImage"), System.Drawing.Image)
        Me.cmdNew.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdNew.UseSelectable = True
        Me.cmdNew.UseTileImage = True
        '
        'cmdSave
        '
        Me.cmdSave.ActiveControl = Nothing
        Me.cmdSave.Enabled = False
        Me.cmdSave.Location = New System.Drawing.Point(405, 39)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(183, 49)
        Me.cmdSave.TabIndex = 35
        Me.cmdSave.Text = "Salvar"
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdSave.TileImage = CType(resources.GetObject("cmdSave.TileImage"), System.Drawing.Image)
        Me.cmdSave.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSave.UseSelectable = True
        Me.cmdSave.UseTileImage = True
        '
        'lbAtencio
        '
        Me.lbAtencio.AutoSize = True
        Me.lbAtencio.ForeColor = System.Drawing.Color.Red
        Me.lbAtencio.Location = New System.Drawing.Point(139, 9)
        Me.lbAtencio.Name = "lbAtencio"
        Me.lbAtencio.Size = New System.Drawing.Size(382, 17)
        Me.lbAtencio.TabIndex = 34
        Me.lbAtencio.Text = "Atenció: després de reproduïr aquest fitxer es posarà en pausa."
        Me.lbAtencio.Visible = False
        '
        'grupEsdev
        '
        Me.grupEsdev.Controls.Add(Me.lbNou)
        Me.grupEsdev.Controls.Add(Me.Label7)
        Me.grupEsdev.Controls.Add(Me.txtHoraRadi)
        Me.grupEsdev.Controls.Add(Me.chkForceHora)
        Me.grupEsdev.Controls.Add(Me.txtNom)
        Me.grupEsdev.Controls.Add(Me.Label5)
        Me.grupEsdev.Controls.Add(Me.Label4)
        Me.grupEsdev.Controls.Add(Me.txtDataRadi)
        Me.grupEsdev.Controls.Add(Me.Label3)
        Me.grupEsdev.Controls.Add(Me.cmbFitxer)
        Me.grupEsdev.Controls.Add(Me.Label2)
        Me.grupEsdev.Controls.Add(Me.cmbTipFitxer)
        Me.grupEsdev.Controls.Add(Me.Label1)
        Me.grupEsdev.Controls.Add(Me.chkIN)
        Me.grupEsdev.Enabled = False
        Me.grupEsdev.Location = New System.Drawing.Point(75, 105)
        Me.grupEsdev.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grupEsdev.Name = "grupEsdev"
        Me.grupEsdev.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grupEsdev.Size = New System.Drawing.Size(511, 222)
        Me.grupEsdev.TabIndex = 33
        Me.grupEsdev.TabStop = False
        '
        'lbNou
        '
        Me.lbNou.AutoSize = True
        Me.lbNou.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNou.ForeColor = System.Drawing.Color.Red
        Me.lbNou.Location = New System.Drawing.Point(143, 12)
        Me.lbNou.Name = "lbNou"
        Me.lbNou.Size = New System.Drawing.Size(61, 25)
        Me.lbNou.TabIndex = 121
        Me.lbNou.Text = "NOU"
        Me.lbNou.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(240, 169)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(194, 17)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "NO abans de 5 min. hora actual"
        '
        'txtHoraRadi
        '
        Me.txtHoraRadi.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.txtHoraRadi.Location = New System.Drawing.Point(139, 165)
        Me.txtHoraRadi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtHoraRadi.Name = "txtHoraRadi"
        Me.txtHoraRadi.ShowUpDown = True
        Me.txtHoraRadi.Size = New System.Drawing.Size(95, 25)
        Me.txtHoraRadi.TabIndex = 8
        '
        'chkForceHora
        '
        Me.chkForceHora.AutoSize = True
        Me.chkForceHora.Location = New System.Drawing.Point(139, 198)
        Me.chkForceHora.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkForceHora.Name = "chkForceHora"
        Me.chkForceHora.Size = New System.Drawing.Size(165, 21)
        Me.chkForceHora.TabIndex = 9
        Me.chkForceHora.Text = "Forçar hora de radiació"
        Me.chkForceHora.UseVisualStyleBackColor = True
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(139, 42)
        Me.txtNom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(357, 25)
        Me.txtNom.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(2, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 17)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Nom:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(2, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 17)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Hora:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtDataRadi
        '
        Me.txtDataRadi.Location = New System.Drawing.Point(139, 132)
        Me.txtDataRadi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDataRadi.Name = "txtDataRadi"
        Me.txtDataRadi.Size = New System.Drawing.Size(239, 25)
        Me.txtDataRadi.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(2, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 17)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Data:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmbFitxer
        '
        Me.cmbFitxer.FormattingEnabled = True
        Me.cmbFitxer.Location = New System.Drawing.Point(139, 102)
        Me.cmbFitxer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbFitxer.Name = "cmbFitxer"
        Me.cmbFitxer.Size = New System.Drawing.Size(357, 25)
        Me.cmbFitxer.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(2, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 17)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Fitxer:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmbTipFitxer
        '
        Me.cmbTipFitxer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipFitxer.FormattingEnabled = True
        Me.cmbTipFitxer.Location = New System.Drawing.Point(139, 72)
        Me.cmbTipFitxer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbTipFitxer.Name = "cmbTipFitxer"
        Me.cmbTipFitxer.Size = New System.Drawing.Size(210, 25)
        Me.cmbTipFitxer.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(2, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 17)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Tipus de fitxers:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'chkIN
        '
        Me.chkIN.AutoSize = True
        Me.chkIN.Checked = True
        Me.chkIN.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkIN.Location = New System.Drawing.Point(357, 76)
        Me.chkIN.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkIN.Name = "chkIN"
        Me.chkIN.Size = New System.Drawing.Size(145, 21)
        Me.chkIN.TabIndex = 5
        Me.chkIN.Text = "Només fitxers actius"
        Me.chkIN.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ListEsdev)
        Me.TabPage2.Controls.Add(Me.cmdDelCaduc)
        Me.TabPage2.Controls.Add(Me.cmdDelSelect)
        Me.TabPage2.HorizontalScrollbarBarColor = True
        Me.TabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.TabPage2.HorizontalScrollbarSize = 5
        Me.TabPage2.Location = New System.Drawing.Point(4, 38)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage2.Size = New System.Drawing.Size(660, 327)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Llistat"
        Me.TabPage2.UseVisualStyleBackColor = True
        Me.TabPage2.VerticalScrollbarBarColor = True
        Me.TabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.TabPage2.VerticalScrollbarSize = 7
        '
        'ListEsdev
        '
        Me.ListEsdev.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListEsdev.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.columnHeader4})
        Me.ListEsdev.FullRowSelect = True
        Me.ListEsdev.LargeImageList = Me.ImageList
        Me.ListEsdev.Location = New System.Drawing.Point(13, 50)
        Me.ListEsdev.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListEsdev.Name = "ListEsdev"
        Me.ListEsdev.Size = New System.Drawing.Size(638, 262)
        Me.ListEsdev.SmallImageList = Me.ImageList
        Me.ListEsdev.TabIndex = 3
        Me.ListEsdev.UseCompatibleStateImageBehavior = False
        Me.ListEsdev.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nom"
        Me.ColumnHeader1.Width = 195
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "T. Fitxer"
        Me.ColumnHeader2.Width = 150
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Data Radiació"
        Me.ColumnHeader3.Width = 125
        '
        'columnHeader4
        '
        Me.columnHeader4.Text = "Forçar"
        Me.columnHeader4.Width = 50
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ImageList.Images.SetKeyName(0, "Fx")
        Me.ImageList.Images.SetKeyName(1, "music")
        Me.ImageList.Images.SetKeyName(2, "promo")
        Me.ImageList.Images.SetKeyName(3, "jingel")
        Me.ImageList.Images.SetKeyName(4, "publi")
        Me.ImageList.Images.SetKeyName(5, "program")
        '
        'cmdDelCaduc
        '
        Me.cmdDelCaduc.Location = New System.Drawing.Point(333, 4)
        Me.cmdDelCaduc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdDelCaduc.Name = "cmdDelCaduc"
        Me.cmdDelCaduc.Size = New System.Drawing.Size(182, 38)
        Me.cmdDelCaduc.TabIndex = 2
        Me.cmdDelCaduc.Text = "Borrar caducats"
        Me.cmdDelCaduc.UseSelectable = True
        '
        'cmdDelSelect
        '
        Me.cmdDelSelect.Location = New System.Drawing.Point(145, 4)
        Me.cmdDelSelect.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdDelSelect.Name = "cmdDelSelect"
        Me.cmdDelSelect.Size = New System.Drawing.Size(182, 38)
        Me.cmdDelSelect.TabIndex = 1
        Me.cmdDelSelect.Text = "Borrar sel·lecció"
        Me.cmdDelSelect.UseSelectable = True
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Location = New System.Drawing.Point(645, 43)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(19, 27)
        Me.cmdExit.TabIndex = 1
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(23, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(654, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Programa qualsevol tipus de fitxer a una hora en concret."
        '
        'cmdSortir
        '
        Me.cmdSortir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSortir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdSortir.Image = CType(resources.GetObject("cmdSortir.Image"), System.Drawing.Image)
        Me.cmdSortir.ImageSize = 32
        Me.cmdSortir.Location = New System.Drawing.Point(636, 29)
        Me.cmdSortir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdSortir.Name = "cmdSortir"
        Me.cmdSortir.Size = New System.Drawing.Size(41, 46)
        Me.cmdSortir.TabIndex = 242
        Me.cmdSortir.UseSelectable = True
        '
        'frmEsdeveniment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(700, 481)
        Me.Controls.Add(Me.cmdSortir)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEsdeveniment"
        Me.Padding = New System.Windows.Forms.Padding(23, 78, 23, 26)
        Me.Resizable = False
        Me.Text = "Programar esdeveniments"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.grupEsdev.ResumeLayout(False)
        Me.grupEsdev.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private columnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents grupEsdev As System.Windows.Forms.GroupBox
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDataRadi As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbFitxer As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbTipFitxer As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkIN As System.Windows.Forms.CheckBox
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents chkForceHora As System.Windows.Forms.CheckBox
    Friend WithEvents txtHoraRadi As System.Windows.Forms.DateTimePicker
    Friend WithEvents ListEsdev As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Public WithEvents ImageList As System.Windows.Forms.ImageList
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbAtencio As System.Windows.Forms.Label
    Friend WithEvents lbNou As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents TabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents TabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents cmdSortir As MetroFramework.Controls.MetroLink
    Friend WithEvents cmdSave As MetroFramework.Controls.MetroTile
    Friend WithEvents cmdNew As MetroFramework.Controls.MetroTile
    Friend WithEvents cmdDelCaduc As MetroFramework.Controls.MetroButton
    Friend WithEvents cmdDelSelect As MetroFramework.Controls.MetroButton
End Class
