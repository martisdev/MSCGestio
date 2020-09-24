<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTagRipper
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTagRipper))
        Me.fratag = New System.Windows.Forms.GroupBox()
        Me.txtAny = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuTítolIntèrpret = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCapturarIntèrpretTítol = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCapturarTítolIntèrpret = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditListComboBoxSeparadors = New System.Windows.Forms.ToolStripComboBox()
        Me.txtInterpret = New System.Windows.Forms.TextBox()
        Me.txtTitol = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbNomTrack = New System.Windows.Forms.Label()
        Me.lbID = New System.Windows.Forms.Label()
        Me.cmdCancelar = New MetroFramework.Controls.MetroTile()
        Me.cmdOK = New MetroFramework.Controls.MetroTile()
        Me.fratag.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'fratag
        '
        Me.fratag.BackColor = System.Drawing.Color.Transparent
        Me.fratag.Controls.Add(Me.txtAny)
        Me.fratag.Controls.Add(Me.txtInterpret)
        Me.fratag.Controls.Add(Me.txtTitol)
        Me.fratag.Controls.Add(Me.Label3)
        Me.fratag.Controls.Add(Me.Label2)
        Me.fratag.Controls.Add(Me.Label1)
        Me.fratag.ForeColor = System.Drawing.SystemColors.WindowText
        Me.fratag.Location = New System.Drawing.Point(5, 78)
        Me.fratag.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.fratag.Name = "fratag"
        Me.fratag.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.fratag.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fratag.Size = New System.Drawing.Size(391, 156)
        Me.fratag.TabIndex = 3
        Me.fratag.TabStop = False
        '
        'txtAny
        '
        Me.txtAny.AcceptsReturn = True
        Me.txtAny.BackColor = System.Drawing.SystemColors.Window
        Me.txtAny.ContextMenuStrip = Me.ContextMenuStrip1
        Me.txtAny.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAny.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAny.Location = New System.Drawing.Point(86, 105)
        Me.txtAny.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAny.MaxLength = 0
        Me.txtAny.Name = "txtAny"
        Me.txtAny.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAny.Size = New System.Drawing.Size(132, 25)
        Me.txtAny.TabIndex = 4
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTítolIntèrpret, Me.mnuCapturarIntèrpretTítol, Me.mnuCapturarTítolIntèrpret, Me.mnuEditListComboBoxSeparadors})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(206, 97)
        '
        'mnuTítolIntèrpret
        '
        Me.mnuTítolIntèrpret.Name = "mnuTítolIntèrpret"
        Me.mnuTítolIntèrpret.Size = New System.Drawing.Size(205, 22)
        Me.mnuTítolIntèrpret.Tag = "0"
        Me.mnuTítolIntèrpret.Text = "Títol<>Intèrpret"
        '
        'mnuCapturarIntèrpretTítol
        '
        Me.mnuCapturarIntèrpretTítol.Name = "mnuCapturarIntèrpretTítol"
        Me.mnuCapturarIntèrpretTítol.Size = New System.Drawing.Size(205, 22)
        Me.mnuCapturarIntèrpretTítol.Tag = "1"
        Me.mnuCapturarIntèrpretTítol.Text = "Capturar: Intèrpret - Títol"
        '
        'mnuCapturarTítolIntèrpret
        '
        Me.mnuCapturarTítolIntèrpret.Name = "mnuCapturarTítolIntèrpret"
        Me.mnuCapturarTítolIntèrpret.Size = New System.Drawing.Size(205, 22)
        Me.mnuCapturarTítolIntèrpret.Tag = "2"
        Me.mnuCapturarTítolIntèrpret.Text = "Capturar: Títol - Intèrpret"
        '
        'mnuEditListComboBoxSeparadors
        '
        Me.mnuEditListComboBoxSeparadors.Items.AddRange(New Object() {"Separador = -", "Separador = _", "Separador = /", "Separador = \"})
        Me.mnuEditListComboBoxSeparadors.Name = "mnuEditListComboBoxSeparadors"
        Me.mnuEditListComboBoxSeparadors.Size = New System.Drawing.Size(121, 23)
        '
        'txtInterpret
        '
        Me.txtInterpret.AcceptsReturn = True
        Me.txtInterpret.BackColor = System.Drawing.SystemColors.Window
        Me.txtInterpret.ContextMenuStrip = Me.ContextMenuStrip1
        Me.txtInterpret.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtInterpret.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtInterpret.Location = New System.Drawing.Point(86, 62)
        Me.txtInterpret.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtInterpret.MaxLength = 0
        Me.txtInterpret.Name = "txtInterpret"
        Me.txtInterpret.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtInterpret.Size = New System.Drawing.Size(299, 25)
        Me.txtInterpret.TabIndex = 3
        '
        'txtTitol
        '
        Me.txtTitol.AcceptsReturn = True
        Me.txtTitol.BackColor = System.Drawing.SystemColors.Window
        Me.txtTitol.ContextMenuStrip = Me.ContextMenuStrip1
        Me.txtTitol.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTitol.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTitol.Location = New System.Drawing.Point(86, 18)
        Me.txtTitol.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTitol.MaxLength = 0
        Me.txtTitol.Name = "txtTitol"
        Me.txtTitol.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTitol.Size = New System.Drawing.Size(299, 25)
        Me.txtTitol.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label3.Location = New System.Drawing.Point(6, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(73, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Any"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label2.Location = New System.Drawing.Point(6, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Intèrpret"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(73, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Títol"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbNomTrack
        '
        Me.lbNomTrack.AutoSize = True
        Me.lbNomTrack.BackColor = System.Drawing.Color.Transparent
        Me.lbNomTrack.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lbNomTrack.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbNomTrack.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lbNomTrack.Location = New System.Drawing.Point(93, 57)
        Me.lbNomTrack.Name = "lbNomTrack"
        Me.lbNomTrack.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbNomTrack.Size = New System.Drawing.Size(0, 17)
        Me.lbNomTrack.TabIndex = 2
        '
        'lbID
        '
        Me.lbID.BackColor = System.Drawing.Color.Green
        Me.lbID.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbID.Location = New System.Drawing.Point(325, 14)
        Me.lbID.Name = "lbID"
        Me.lbID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbID.Size = New System.Drawing.Size(24, 35)
        Me.lbID.TabIndex = 11
        Me.lbID.Text = "00"
        Me.lbID.Visible = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.ActiveControl = Nothing
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(91, 241)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(103, 41)
        Me.cmdCancelar.TabIndex = 14
        Me.cmdCancelar.TileImage = CType(resources.GetObject("cmdCancelar.TileImage"), System.Drawing.Image)
        Me.cmdCancelar.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdCancelar.UseSelectable = True
        Me.cmdCancelar.UseTileImage = True
        '
        'cmdOK
        '
        Me.cmdOK.ActiveControl = Nothing
        Me.cmdOK.Location = New System.Drawing.Point(200, 241)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(149, 41)
        Me.cmdOK.TabIndex = 13
        Me.cmdOK.TileImage = CType(resources.GetObject("cmdOK.TileImage"), System.Drawing.Image)
        Me.cmdOK.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdOK.UseSelectable = True
        Me.cmdOK.UseTileImage = True
        '
        'frmTagRipper
        '
        Me.AcceptButton = Me.cmdOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(408, 297)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.lbID)
        Me.Controls.Add(Me.lbNomTrack)
        Me.Controls.Add(Me.fratag)
        Me.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTagRipper"
        Me.Padding = New System.Windows.Forms.Padding(23, 78, 23, 26)
        Me.Resizable = False
        Me.Text = "Modificar valors ..."
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.fratag.ResumeLayout(False)
        Me.fratag.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private mnuEditListComboBoxSeparadors As System.Windows.Forms.ToolStripComboBox
    Public WithEvents fratag As System.Windows.Forms.GroupBox
    Public WithEvents txtAny As System.Windows.Forms.TextBox
    Public WithEvents txtInterpret As System.Windows.Forms.TextBox
    Public WithEvents txtTitol As System.Windows.Forms.TextBox
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents lbNomTrack As System.Windows.Forms.Label
    Public WithEvents lbID As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuTítolIntèrpret As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCapturarIntèrpretTítol As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCapturarTítolIntèrpret As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdCancelar As MetroFramework.Controls.MetroTile
    Friend WithEvents cmdOK As MetroFramework.Controls.MetroTile
End Class
