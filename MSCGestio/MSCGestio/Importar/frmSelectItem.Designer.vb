'
' Creado por SharpDevelop.
' Usuario: Marti
' Fecha: 30/09/2016
' Hora: 07:42
' 
' Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
'
Partial Class frmSelectItem
    Inherits MetroFramework.Forms.MetroForm

    ''' <summary>
    ''' Designer variable used to keep track of non-visual components.
    ''' </summary>
    Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSelectItem))
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.comboBoxOptions = New System.Windows.Forms.ComboBox()
        Me.cmdOk = New MetroFramework.Controls.MetroTile()
        Me.CmdTancar = New MetroFramework.Controls.MetroTile()
        Me.SuspendLayout()
        '
        'label2
        '
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.Red
        Me.label2.Location = New System.Drawing.Point(29, 246)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(257, 22)
        Me.label2.TabIndex = 10
        Me.label2.Text = "Cancel·lar equival a crear-la nova"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(14, 69)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(283, 21)
        Me.label1.TabIndex = 9
        Me.label1.Text = "Selecciona la opció que s'ajusta més"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'comboBoxOptions
        '
        Me.comboBoxOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.comboBoxOptions.FormattingEnabled = True
        Me.comboBoxOptions.Location = New System.Drawing.Point(28, 93)
        Me.comboBoxOptions.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.comboBoxOptions.Name = "comboBoxOptions"
        Me.comboBoxOptions.Size = New System.Drawing.Size(258, 161)
        Me.comboBoxOptions.TabIndex = 8
        '
        'cmdOk
        '
        Me.cmdOk.ActiveControl = Nothing
        Me.cmdOk.Location = New System.Drawing.Point(137, 273)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(149, 41)
        Me.cmdOk.TabIndex = 11
        Me.cmdOk.TileImage = CType(resources.GetObject("cmdOk.TileImage"), System.Drawing.Image)
        Me.cmdOk.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdOk.UseSelectable = True
        Me.cmdOk.UseTileImage = True
        '
        'CmdTancar
        '
        Me.CmdTancar.ActiveControl = Nothing
        Me.CmdTancar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CmdTancar.Location = New System.Drawing.Point(28, 273)
        Me.CmdTancar.Name = "CmdTancar"
        Me.CmdTancar.Size = New System.Drawing.Size(103, 41)
        Me.CmdTancar.TabIndex = 12
        Me.CmdTancar.TileImage = CType(resources.GetObject("CmdTancar.TileImage"), System.Drawing.Image)
        Me.CmdTancar.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CmdTancar.UseSelectable = True
        Me.CmdTancar.UseTileImage = True
        '
        'frmSelectItem
        '
        Me.AcceptButton = Me.cmdOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CmdTancar
        Me.ClientSize = New System.Drawing.Size(307, 336)
        Me.Controls.Add(Me.CmdTancar)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.comboBoxOptions)
        Me.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSelectItem"
        Me.Padding = New System.Windows.Forms.Padding(23, 78, 23, 26)
        Me.Resizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Select options"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.ResumeLayout(False)

    End Sub
    Private comboBoxOptions As System.Windows.Forms.ComboBox
    Private label1 As System.Windows.Forms.Label
    Private label2 As System.Windows.Forms.Label
    Friend WithEvents cmdOk As MetroFramework.Controls.MetroTile
    Friend WithEvents CmdTancar As MetroFramework.Controls.MetroTile
End Class
