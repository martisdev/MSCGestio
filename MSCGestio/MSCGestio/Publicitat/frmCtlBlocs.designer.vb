<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCtlBlocs
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCtlBlocs))
        Me.cmdExit = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtDataDadiacio = New System.Windows.Forms.DateTimePicker
        Me.cmbListHores = New System.Windows.Forms.ComboBox
        Me.lbFrange = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ListBlocs = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.cmdAddBuffer = New System.Windows.Forms.Button
        Me.cmdAddBlocs = New System.Windows.Forms.Button
        Me.ListBuffer = New System.Windows.Forms.ListView
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Image = CType(resources.GetObject("cmdExit.Image"), System.Drawing.Image)
        Me.cmdExit.Location = New System.Drawing.Point(735, 5)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(45, 41)
        Me.cmdExit.TabIndex = 7
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtDataDadiacio)
        Me.GroupBox1.Controls.Add(Me.cmbListHores)
        Me.GroupBox1.Controls.Add(Me.lbFrange)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(714, 137)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(358, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Bloc de publicitat"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(56, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Seleccionar dia:"
        '
        'txtDataDadiacio
        '
        Me.txtDataDadiacio.Location = New System.Drawing.Point(148, 33)
        Me.txtDataDadiacio.Name = "txtDataDadiacio"
        Me.txtDataDadiacio.Size = New System.Drawing.Size(192, 20)
        Me.txtDataDadiacio.TabIndex = 4
        '
        'cmbListHores
        '
        Me.cmbListHores.FormattingEnabled = True
        Me.cmbListHores.Location = New System.Drawing.Point(452, 33)
        Me.cmbListHores.Name = "cmbListHores"
        Me.cmbListHores.Size = New System.Drawing.Size(158, 21)
        Me.cmbListHores.TabIndex = 3
        '
        'lbFrange
        '
        Me.lbFrange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbFrange.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFrange.Location = New System.Drawing.Point(625, 27)
        Me.lbFrange.Name = "lbFrange"
        Me.lbFrange.Size = New System.Drawing.Size(82, 32)
        Me.lbFrange.TabIndex = 2
        Me.lbFrange.Text = "Franja"
        Me.lbFrange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(27, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(622, 61)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'ListBlocs
        '
        Me.ListBlocs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBlocs.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.ListBlocs.FullRowSelect = True
        Me.ListBlocs.Location = New System.Drawing.Point(16, 179)
        Me.ListBlocs.Name = "ListBlocs"
        Me.ListBlocs.Size = New System.Drawing.Size(765, 148)
        Me.ListBlocs.TabIndex = 12
        Me.ListBlocs.UseCompatibleStateImageBehavior = False
        Me.ListBlocs.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nom"
        Me.ColumnHeader1.Width = 116
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Client"
        Me.ColumnHeader2.Width = 124
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Producte"
        Me.ColumnHeader3.Width = 116
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Locutor"
        Me.ColumnHeader4.Width = 118
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Durada"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Bloc Inicial"
        Me.ColumnHeader6.Width = 78
        '
        'cmdAddBuffer
        '
        Me.cmdAddBuffer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdAddBuffer.Enabled = False
        Me.cmdAddBuffer.Image = CType(resources.GetObject("cmdAddBuffer.Image"), System.Drawing.Image)
        Me.cmdAddBuffer.Location = New System.Drawing.Point(228, 333)
        Me.cmdAddBuffer.Name = "cmdAddBuffer"
        Me.cmdAddBuffer.Size = New System.Drawing.Size(152, 37)
        Me.cmdAddBuffer.TabIndex = 13
        Me.cmdAddBuffer.UseVisualStyleBackColor = True
        '
        'cmdAddBlocs
        '
        Me.cmdAddBlocs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdAddBlocs.Enabled = False
        Me.cmdAddBlocs.Image = CType(resources.GetObject("cmdAddBlocs.Image"), System.Drawing.Image)
        Me.cmdAddBlocs.Location = New System.Drawing.Point(412, 333)
        Me.cmdAddBlocs.Name = "cmdAddBlocs"
        Me.cmdAddBlocs.Size = New System.Drawing.Size(152, 37)
        Me.cmdAddBlocs.TabIndex = 14
        Me.cmdAddBlocs.UseVisualStyleBackColor = True
        '
        'ListBuffer
        '
        Me.ListBuffer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBuffer.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12})
        Me.ListBuffer.FullRowSelect = True
        Me.ListBuffer.Location = New System.Drawing.Point(16, 388)
        Me.ListBuffer.Name = "ListBuffer"
        Me.ListBuffer.Size = New System.Drawing.Size(765, 135)
        Me.ListBuffer.TabIndex = 16
        Me.ListBuffer.UseCompatibleStateImageBehavior = False
        Me.ListBuffer.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Nom"
        Me.ColumnHeader7.Width = 113
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Client"
        Me.ColumnHeader8.Width = 120
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Producte"
        Me.ColumnHeader9.Width = 123
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Locutor"
        Me.ColumnHeader10.Width = 119
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Durada"
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Bloc Inicial"
        Me.ColumnHeader12.Width = 78
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(151, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Falques del bloc seleccionat"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(146, 373)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(259, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Falques pendents d'assignar a un bloc ( No salvades)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(361, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(417, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Arrossega les falques per establir l'ordre correlatiu dins del bloc en el qual ha" & _
            "n de sonar."
        '
        'frmCtlBlocs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(792, 535)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListBuffer)
        Me.Controls.Add(Me.cmdAddBlocs)
        Me.Controls.Add(Me.cmdAddBuffer)
        Me.Controls.Add(Me.ListBlocs)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdExit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(800, 569)
        Me.Name = "frmCtlBlocs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Control dels blocs publicitaris"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbFrange As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ListBlocs As System.Windows.Forms.ListView
    Friend WithEvents cmdAddBuffer As System.Windows.Forms.Button
    Friend WithEvents cmdAddBlocs As System.Windows.Forms.Button
    Friend WithEvents ListBuffer As System.Windows.Forms.ListView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmbListHores As System.Windows.Forms.ComboBox
    Friend WithEvents txtDataDadiacio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
