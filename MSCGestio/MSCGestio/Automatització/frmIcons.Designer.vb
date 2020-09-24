<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmIcons
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
        Me.FlowLayoutPanelImages = New System.Windows.Forms.FlowLayoutPanel()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'FlowLayoutPanelImages
        '
        Me.FlowLayoutPanelImages.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanelImages.AutoScroll = True
        Me.FlowLayoutPanelImages.Location = New System.Drawing.Point(5, 21)
        Me.FlowLayoutPanelImages.Name = "FlowLayoutPanelImages"
        Me.FlowLayoutPanelImages.Size = New System.Drawing.Size(310, 86)
        Me.FlowLayoutPanelImages.TabIndex = 0
        '
        'ButtonExit
        '
        Me.ButtonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonExit.Location = New System.Drawing.Point(42, 45)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(55, 19)
        Me.ButtonExit.TabIndex = 1
        Me.ButtonExit.Text = "Exit"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'frmIcons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ButtonExit
        Me.ClientSize = New System.Drawing.Size(325, 117)
        Me.Controls.Add(Me.FlowLayoutPanelImages)
        Me.Controls.Add(Me.ButtonExit)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmIcons"
        Me.ShowInTaskbar = False
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanelImages As FlowLayoutPanel
    Friend WithEvents ButtonExit As Button
End Class
