<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInformRadia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInformRadia))
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.txtIntervalData = New System.Windows.Forms.MonthCalendar()
        Me.cmdInform = New MetroFramework.Controls.MetroTile()
        Me.cmdFactura = New MetroFramework.Controls.MetroTile()
        Me.ComboPubli = New System.Windows.Forms.ComboBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboClient = New System.Windows.Forms.ComboBox()
        Me.cmdSortir = New MetroFramework.Controls.MetroLink()
        Me.pic_logo = New System.Windows.Forms.PictureBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.Location = New System.Drawing.Point(974, 62)
        Me.cmdClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(25, 18)
        Me.cmdClose.TabIndex = 3
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 88)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtIntervalData)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdInform)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdFactura)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ComboPubli)
        Me.SplitContainer1.Panel2.Controls.Add(Me.label2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ComboClient)
        Me.SplitContainer1.Size = New System.Drawing.Size(1017, 475)
        Me.SplitContainer1.SplitterDistance = 604
        Me.SplitContainer1.SplitterWidth = 5
        Me.SplitContainer1.TabIndex = 4
        '
        'txtIntervalData
        '
        Me.txtIntervalData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIntervalData.CalendarDimensions = New System.Drawing.Size(3, 2)
        Me.txtIntervalData.Location = New System.Drawing.Point(10, 56)
        Me.txtIntervalData.Margin = New System.Windows.Forms.Padding(10, 12, 10, 12)
        Me.txtIntervalData.MaxSelectionCount = 365
        Me.txtIntervalData.Name = "txtIntervalData"
        Me.txtIntervalData.TabIndex = 0
        '
        'cmdInform
        '
        Me.cmdInform.ActiveControl = Nothing
        Me.cmdInform.Location = New System.Drawing.Point(104, 166)
        Me.cmdInform.Name = "cmdInform"
        Me.cmdInform.Size = New System.Drawing.Size(235, 56)
        Me.cmdInform.TabIndex = 6
        Me.cmdInform.Text = "Informe de radiació"
        Me.cmdInform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdInform.TileImage = CType(resources.GetObject("cmdInform.TileImage"), System.Drawing.Image)
        Me.cmdInform.UseSelectable = True
        Me.cmdInform.UseTileImage = True
        '
        'cmdFactura
        '
        Me.cmdFactura.ActiveControl = Nothing
        Me.cmdFactura.Location = New System.Drawing.Point(104, 248)
        Me.cmdFactura.Name = "cmdFactura"
        Me.cmdFactura.Size = New System.Drawing.Size(235, 56)
        Me.cmdFactura.TabIndex = 7
        Me.cmdFactura.Text = "Factura de radiació"
        Me.cmdFactura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdFactura.TileImage = CType(resources.GetObject("cmdFactura.TileImage"), System.Drawing.Image)
        Me.cmdFactura.UseSelectable = True
        Me.cmdFactura.UseTileImage = True
        '
        'ComboPubli
        '
        Me.ComboPubli.FormattingEnabled = True
        Me.ComboPubli.Location = New System.Drawing.Point(104, 110)
        Me.ComboPubli.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboPubli.Name = "ComboPubli"
        Me.ComboPubli.Size = New System.Drawing.Size(235, 25)
        Me.ComboPubli.TabIndex = 3
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(17, 114)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(80, 17)
        Me.label2.TabIndex = 2
        Me.label2.Text = "Publicitat"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(17, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Client"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ComboClient
        '
        Me.ComboClient.FormattingEnabled = True
        Me.ComboClient.Location = New System.Drawing.Point(104, 56)
        Me.ComboClient.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboClient.Name = "ComboClient"
        Me.ComboClient.Size = New System.Drawing.Size(235, 25)
        Me.ComboClient.TabIndex = 0
        '
        'cmdSortir
        '
        Me.cmdSortir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSortir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdSortir.Image = CType(resources.GetObject("cmdSortir.Image"), System.Drawing.Image)
        Me.cmdSortir.ImageSize = 32
        Me.cmdSortir.Location = New System.Drawing.Point(959, 39)
        Me.cmdSortir.Name = "cmdSortir"
        Me.cmdSortir.Size = New System.Drawing.Size(40, 42)
        Me.cmdSortir.TabIndex = 22
        Me.cmdSortir.UseSelectable = True
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
        'frmInformRadia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdClose
        Me.ClientSize = New System.Drawing.Size(1022, 575)
        Me.Controls.Add(Me.pic_logo)
        Me.Controls.Add(Me.cmdSortir)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.cmdClose)
        Me.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmInformRadia"
        Me.Text = "Informes de radiació falques publicitàries"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents txtIntervalData As System.Windows.Forms.MonthCalendar
    Friend WithEvents ComboPubli As System.Windows.Forms.ComboBox
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboClient As System.Windows.Forms.ComboBox
    Friend WithEvents cmdInform As MetroFramework.Controls.MetroTile
    Friend WithEvents cmdFactura As MetroFramework.Controls.MetroTile
    Friend WithEvents cmdSortir As MetroFramework.Controls.MetroLink
    Friend WithEvents pic_logo As PictureBox
End Class
