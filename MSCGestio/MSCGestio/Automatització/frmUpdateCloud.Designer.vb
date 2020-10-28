<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUpdateCloud
    Inherits MetroFramework.Forms.MetroForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUpdateCloud))
        Me.MetroProgressSpinnerCloud = New MetroFramework.Controls.MetroProgressSpinner()
        Me.lbInfoProcess = New MetroFramework.Controls.MetroLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pic_logo = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroProgressSpinnerCloud
        '
        Me.MetroProgressSpinnerCloud.Location = New System.Drawing.Point(47, 19)
        Me.MetroProgressSpinnerCloud.Maximum = 100
        Me.MetroProgressSpinnerCloud.Name = "MetroProgressSpinnerCloud"
        Me.MetroProgressSpinnerCloud.Size = New System.Drawing.Size(287, 287)
        Me.MetroProgressSpinnerCloud.TabIndex = 0
        Me.MetroProgressSpinnerCloud.UseSelectable = True
        '
        'lbInfoProcess
        '
        Me.lbInfoProcess.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lbInfoProcess.Location = New System.Drawing.Point(18, 319)
        Me.lbInfoProcess.Name = "lbInfoProcess"
        Me.lbInfoProcess.Size = New System.Drawing.Size(345, 43)
        Me.lbInfoProcess.TabIndex = 1
        Me.lbInfoProcess.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MetroProgressSpinnerCloud)
        Me.GroupBox1.Controls.Add(Me.lbInfoProcess)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(380, 374)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'pic_logo
        '
        Me.pic_logo.Image = CType(resources.GetObject("pic_logo.Image"), System.Drawing.Image)
        Me.pic_logo.Location = New System.Drawing.Point(9, 18)
        Me.pic_logo.Name = "pic_logo"
        Me.pic_logo.Size = New System.Drawing.Size(40, 40)
        Me.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_logo.TabIndex = 267
        Me.pic_logo.TabStop = False
        '
        'frmUpdateCloud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 446)
        Me.Controls.Add(Me.pic_logo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmUpdateCloud"
        Me.Resizable = False
        Me.Text = "Sincronitzant amb el Núvol"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroProgressSpinnerCloud As MetroFramework.Controls.MetroProgressSpinner
    Friend WithEvents lbInfoProcess As MetroFramework.Controls.MetroLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents pic_logo As PictureBox
End Class
