<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEquival
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEquival))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbIDEquival = New System.Windows.Forms.Label()
        Me.lstInterpEquival = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmdAddEquival = New MetroFramework.Controls.MetroButton()
        Me.cmdDelEquival = New MetroFramework.Controls.MetroButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboEquival = New System.Windows.Forms.ComboBox()
        Me.ComboInterp = New System.Windows.Forms.ComboBox()
        Me.chkForceRecipro = New MetroFramework.Controls.MetroCheckBox()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.picLock = New System.Windows.Forms.PictureBox()
        Me.picUnLock = New System.Windows.Forms.PictureBox()
        Me.CmdBloqueix = New MetroFramework.Controls.MetroLink()
        Me.cmdSortir = New MetroFramework.Controls.MetroLink()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picLock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUnLock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbIDEquival)
        Me.GroupBox1.Controls.Add(Me.lstInterpEquival)
        Me.GroupBox1.Controls.Add(Me.cmdAddEquival)
        Me.GroupBox1.Controls.Add(Me.cmdDelEquival)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboEquival)
        Me.GroupBox1.Controls.Add(Me.ComboInterp)
        Me.GroupBox1.Controls.Add(Me.chkForceRecipro)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(23, 78)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(654, 373)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Equivalències Intèrprets"
        '
        'lbIDEquival
        '
        Me.lbIDEquival.BackColor = System.Drawing.Color.Green
        Me.lbIDEquival.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbIDEquival.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbIDEquival.Location = New System.Drawing.Point(584, 21)
        Me.lbIDEquival.Name = "lbIDEquival"
        Me.lbIDEquival.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbIDEquival.Size = New System.Drawing.Size(21, 17)
        Me.lbIDEquival.TabIndex = 8
        Me.lbIDEquival.Text = "4"
        Me.lbIDEquival.Visible = False
        '
        'lstInterpEquival
        '
        Me.lstInterpEquival.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lstInterpEquival.FullRowSelect = True
        Me.lstInterpEquival.GridLines = True
        Me.lstInterpEquival.Location = New System.Drawing.Point(31, 133)
        Me.lstInterpEquival.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstInterpEquival.Name = "lstInterpEquival"
        Me.lstInterpEquival.Size = New System.Drawing.Size(584, 216)
        Me.lstInterpEquival.TabIndex = 7
        Me.lstInterpEquival.UseCompatibleStateImageBehavior = False
        Me.lstInterpEquival.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Intrèpret"
        Me.ColumnHeader1.Width = 300
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Equivalència"
        Me.ColumnHeader2.Width = 250
        '
        'cmdAddEquival
        '
        Me.cmdAddEquival.Enabled = False
        Me.cmdAddEquival.Location = New System.Drawing.Point(386, 94)
        Me.cmdAddEquival.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdAddEquival.Name = "cmdAddEquival"
        Me.cmdAddEquival.Size = New System.Drawing.Size(229, 31)
        Me.cmdAddEquival.TabIndex = 6
        Me.cmdAddEquival.Text = "Afegir equivalència"
        Me.cmdAddEquival.UseSelectable = True
        '
        'cmdDelEquival
        '
        Me.cmdDelEquival.Enabled = False
        Me.cmdDelEquival.Location = New System.Drawing.Point(31, 94)
        Me.cmdDelEquival.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdDelEquival.Name = "cmdDelEquival"
        Me.cmdDelEquival.Size = New System.Drawing.Size(229, 31)
        Me.cmdDelEquival.TabIndex = 5
        Me.cmdDelEquival.Text = "Borrar equivalència"
        Me.cmdDelEquival.UseSelectable = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(310, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = ">>>"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Aquest intèrpret equival a..."
        '
        'ComboEquival
        '
        Me.ComboEquival.Enabled = False
        Me.ComboEquival.FormattingEnabled = True
        Me.ComboEquival.Location = New System.Drawing.Point(386, 61)
        Me.ComboEquival.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboEquival.Name = "ComboEquival"
        Me.ComboEquival.Size = New System.Drawing.Size(229, 25)
        Me.ComboEquival.TabIndex = 2
        '
        'ComboInterp
        '
        Me.ComboInterp.Enabled = False
        Me.ComboInterp.FormattingEnabled = True
        Me.ComboInterp.Location = New System.Drawing.Point(31, 61)
        Me.ComboInterp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboInterp.Name = "ComboInterp"
        Me.ComboInterp.Size = New System.Drawing.Size(229, 25)
        Me.ComboInterp.TabIndex = 1
        '
        'chkForceRecipro
        '
        Me.chkForceRecipro.AutoSize = True
        Me.chkForceRecipro.Checked = True
        Me.chkForceRecipro.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkForceRecipro.Enabled = False
        Me.chkForceRecipro.Location = New System.Drawing.Point(268, 36)
        Me.chkForceRecipro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkForceRecipro.Name = "chkForceRecipro"
        Me.chkForceRecipro.Size = New System.Drawing.Size(119, 15)
        Me.chkForceRecipro.TabIndex = 0
        Me.chkForceRecipro.Text = "Forçar reciprocitat"
        Me.chkForceRecipro.UseSelectable = True
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Location = New System.Drawing.Point(647, 53)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(16, 17)
        Me.cmdExit.TabIndex = 1
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'picLock
        '
        Me.picLock.Image = CType(resources.GetObject("picLock.Image"), System.Drawing.Image)
        Me.picLock.Location = New System.Drawing.Point(354, 7)
        Me.picLock.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picLock.Name = "picLock"
        Me.picLock.Size = New System.Drawing.Size(45, 46)
        Me.picLock.TabIndex = 3
        Me.picLock.TabStop = False
        Me.picLock.Visible = False
        '
        'picUnLock
        '
        Me.picUnLock.Image = CType(resources.GetObject("picUnLock.Image"), System.Drawing.Image)
        Me.picUnLock.Location = New System.Drawing.Point(405, 9)
        Me.picUnLock.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picUnLock.Name = "picUnLock"
        Me.picUnLock.Size = New System.Drawing.Size(47, 44)
        Me.picUnLock.TabIndex = 4
        Me.picUnLock.TabStop = False
        Me.picUnLock.Visible = False
        '
        'CmdBloqueix
        '
        Me.CmdBloqueix.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdBloqueix.Image = CType(resources.GetObject("CmdBloqueix.Image"), System.Drawing.Image)
        Me.CmdBloqueix.ImageSize = 32
        Me.CmdBloqueix.Location = New System.Drawing.Point(586, 36)
        Me.CmdBloqueix.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CmdBloqueix.Name = "CmdBloqueix"
        Me.CmdBloqueix.Size = New System.Drawing.Size(41, 46)
        Me.CmdBloqueix.TabIndex = 240
        Me.CmdBloqueix.UseSelectable = True
        '
        'cmdSortir
        '
        Me.cmdSortir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSortir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdSortir.Image = CType(resources.GetObject("cmdSortir.Image"), System.Drawing.Image)
        Me.cmdSortir.ImageSize = 32
        Me.cmdSortir.Location = New System.Drawing.Point(634, 36)
        Me.cmdSortir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdSortir.Name = "cmdSortir"
        Me.cmdSortir.Size = New System.Drawing.Size(41, 46)
        Me.cmdSortir.TabIndex = 241
        Me.cmdSortir.UseSelectable = True
        '
        'frmEquival
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(700, 481)
        Me.Controls.Add(Me.cmdSortir)
        Me.Controls.Add(Me.CmdBloqueix)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.picUnLock)
        Me.Controls.Add(Me.picLock)
        Me.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEquival"
        Me.Padding = New System.Windows.Forms.Padding(23, 78, 23, 26)
        Me.Resizable = False
        Me.Text = "Equivalències entre intèrprets"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picLock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUnLock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lstInterpEquival As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboEquival As System.Windows.Forms.ComboBox
    Friend WithEvents ComboInterp As System.Windows.Forms.ComboBox
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents picLock As System.Windows.Forms.PictureBox
    Friend WithEvents picUnLock As System.Windows.Forms.PictureBox
    Public WithEvents lbIDEquival As System.Windows.Forms.Label
    Friend WithEvents CmdBloqueix As MetroFramework.Controls.MetroLink
    Friend WithEvents cmdSortir As MetroFramework.Controls.MetroLink
    Friend WithEvents chkForceRecipro As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents cmdAddEquival As MetroFramework.Controls.MetroButton
    Friend WithEvents cmdDelEquival As MetroFramework.Controls.MetroButton
End Class
