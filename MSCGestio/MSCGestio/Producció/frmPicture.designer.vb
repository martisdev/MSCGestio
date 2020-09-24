<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPicture
    Inherits System.Windows.Forms.Form

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
        Me.PictureBoxPersona = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBoxPersona, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxPersona
        '
        Me.PictureBoxPersona.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxPersona.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBoxPersona.Location = New System.Drawing.Point(0, 0)
        Me.PictureBoxPersona.Name = "PictureBoxPersona"
        Me.PictureBoxPersona.Size = New System.Drawing.Size(272, 289)
        Me.PictureBoxPersona.TabIndex = 1
        Me.PictureBoxPersona.TabStop = False
        '
        'frmPicture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(272, 289)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBoxPersona)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPicture"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Imatge"
        CType(Me.PictureBoxPersona, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBoxPersona As System.Windows.Forms.PictureBox
End Class
