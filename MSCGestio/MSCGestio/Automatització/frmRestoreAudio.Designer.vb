<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRestoreAudio
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
    	Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRestoreAudio))
    	Me.Label1 = New System.Windows.Forms.Label()
    	Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    	Me.cmdAddMusic = New System.Windows.Forms.Button()
    	Me.cmdDelMusic = New System.Windows.Forms.Button()
    	Me.GroupBox2 = New System.Windows.Forms.GroupBox()
    	Me.cmdAddPubli = New System.Windows.Forms.Button()
    	Me.cmdDelPubli = New System.Windows.Forms.Button()
    	Me.GroupBox3 = New System.Windows.Forms.GroupBox()
    	Me.cmdAddPromo = New System.Windows.Forms.Button()
    	Me.cmdPromo = New System.Windows.Forms.Button()
    	Me.GroupBox4 = New System.Windows.Forms.GroupBox()
    	Me.cmdAddJingel = New System.Windows.Forms.Button()
    	Me.cmdDelJingel = New System.Windows.Forms.Button()
    	Me.GroupBox5 = New System.Windows.Forms.GroupBox()
    	Me.Label4 = New System.Windows.Forms.Label()
    	Me.cmdPath = New System.Windows.Forms.Button()
    	Me.txtPath = New System.Windows.Forms.TextBox()
    	Me.Label5 = New System.Windows.Forms.Label()
    	Me.cmdExit = New System.Windows.Forms.Button()
    	Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
    	Me.cmdCancel = New System.Windows.Forms.Button()
    	Me.lbInfoProgress = New System.Windows.Forms.Label()
    	Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
    	Me.GroupBox1.SuspendLayout
    	Me.GroupBox2.SuspendLayout
    	Me.GroupBox3.SuspendLayout
    	Me.GroupBox4.SuspendLayout
    	Me.GroupBox5.SuspendLayout
    	Me.SuspendLayout
    	'
    	'Label1
    	'
    	Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    	Me.Label1.AutoSize = true
    	Me.Label1.ForeColor = System.Drawing.Color.Blue
    	Me.Label1.Location = New System.Drawing.Point(177, 26)
    	Me.Label1.Name = "Label1"
    	Me.Label1.Size = New System.Drawing.Size(419, 13)
    	Me.Label1.TabIndex = 0
    	Me.Label1.Text = "Fer qualsevol operació en aquesta pantalla pot suposar un perill per l'emissió en"& _ 
    	" directe."
    	'
    	'GroupBox1
    	'
    	Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    	Me.GroupBox1.Controls.Add(Me.cmdAddMusic)
    	Me.GroupBox1.Controls.Add(Me.cmdDelMusic)
    	Me.GroupBox1.Location = New System.Drawing.Point(128, 135)
    	Me.GroupBox1.Name = "GroupBox1"
    	Me.GroupBox1.Size = New System.Drawing.Size(528, 66)
    	Me.GroupBox1.TabIndex = 1
    	Me.GroupBox1.TabStop = false
    	Me.GroupBox1.Text = "Música"
    	'
    	'cmdAddMusic
    	'
    	Me.cmdAddMusic.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    	Me.cmdAddMusic.Enabled = false
    	Me.cmdAddMusic.Image = CType(resources.GetObject("cmdAddMusic.Image"),System.Drawing.Image)
    	Me.cmdAddMusic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    	Me.cmdAddMusic.Location = New System.Drawing.Point(334, 19)
    	Me.cmdAddMusic.Name = "cmdAddMusic"
    	Me.cmdAddMusic.Size = New System.Drawing.Size(174, 30)
    	Me.cmdAddMusic.TabIndex = 1
    	Me.cmdAddMusic.Text = "Afegir"
    	Me.cmdAddMusic.UseVisualStyleBackColor = true
    	AddHandler Me.cmdAddMusic.Click, AddressOf Me.CmdAddMusicClick
    	'
    	'cmdDelMusic
    	'
    	Me.cmdDelMusic.Image = CType(resources.GetObject("cmdDelMusic.Image"),System.Drawing.Image)
    	Me.cmdDelMusic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    	Me.cmdDelMusic.Location = New System.Drawing.Point(24, 19)
    	Me.cmdDelMusic.Name = "cmdDelMusic"
    	Me.cmdDelMusic.Size = New System.Drawing.Size(174, 30)
    	Me.cmdDelMusic.TabIndex = 0
    	Me.cmdDelMusic.Text = "Borrar"
    	Me.cmdDelMusic.UseVisualStyleBackColor = true
    	'
    	'GroupBox2
    	'
    	Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    	Me.GroupBox2.Controls.Add(Me.cmdAddPubli)
    	Me.GroupBox2.Controls.Add(Me.cmdDelPubli)
    	Me.GroupBox2.Location = New System.Drawing.Point(128, 216)
    	Me.GroupBox2.Name = "GroupBox2"
    	Me.GroupBox2.Size = New System.Drawing.Size(528, 66)
    	Me.GroupBox2.TabIndex = 2
    	Me.GroupBox2.TabStop = false
    	Me.GroupBox2.Text = "Publicitat"
    	'
    	'cmdAddPubli
    	'
    	Me.cmdAddPubli.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    	Me.cmdAddPubli.Enabled = false
    	Me.cmdAddPubli.Image = CType(resources.GetObject("cmdAddPubli.Image"),System.Drawing.Image)
    	Me.cmdAddPubli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    	Me.cmdAddPubli.Location = New System.Drawing.Point(334, 19)
    	Me.cmdAddPubli.Name = "cmdAddPubli"
    	Me.cmdAddPubli.Size = New System.Drawing.Size(174, 30)
    	Me.cmdAddPubli.TabIndex = 3
    	Me.cmdAddPubli.Text = "Afegir"
    	Me.cmdAddPubli.UseVisualStyleBackColor = true
    	'
    	'cmdDelPubli
    	'
    	Me.cmdDelPubli.Image = CType(resources.GetObject("cmdDelPubli.Image"),System.Drawing.Image)
    	Me.cmdDelPubli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    	Me.cmdDelPubli.Location = New System.Drawing.Point(24, 19)
    	Me.cmdDelPubli.Name = "cmdDelPubli"
    	Me.cmdDelPubli.Size = New System.Drawing.Size(174, 30)
    	Me.cmdDelPubli.TabIndex = 2
    	Me.cmdDelPubli.Text = "Borrar"
    	Me.cmdDelPubli.UseVisualStyleBackColor = true
    	'
    	'GroupBox3
    	'
    	Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    	Me.GroupBox3.Controls.Add(Me.cmdAddPromo)
    	Me.GroupBox3.Controls.Add(Me.cmdPromo)
    	Me.GroupBox3.Location = New System.Drawing.Point(128, 297)
    	Me.GroupBox3.Name = "GroupBox3"
    	Me.GroupBox3.Size = New System.Drawing.Size(528, 66)
    	Me.GroupBox3.TabIndex = 3
    	Me.GroupBox3.TabStop = false
    	Me.GroupBox3.Text = "Promocions"
    	'
    	'cmdAddPromo
    	'
    	Me.cmdAddPromo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    	Me.cmdAddPromo.Enabled = false
    	Me.cmdAddPromo.Image = CType(resources.GetObject("cmdAddPromo.Image"),System.Drawing.Image)
    	Me.cmdAddPromo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    	Me.cmdAddPromo.Location = New System.Drawing.Point(334, 19)
    	Me.cmdAddPromo.Name = "cmdAddPromo"
    	Me.cmdAddPromo.Size = New System.Drawing.Size(174, 30)
    	Me.cmdAddPromo.TabIndex = 3
    	Me.cmdAddPromo.Text = "Afegir"
    	Me.cmdAddPromo.UseVisualStyleBackColor = true
    	'
    	'cmdPromo
    	'
    	Me.cmdPromo.Image = CType(resources.GetObject("cmdPromo.Image"),System.Drawing.Image)
    	Me.cmdPromo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    	Me.cmdPromo.Location = New System.Drawing.Point(24, 19)
    	Me.cmdPromo.Name = "cmdPromo"
    	Me.cmdPromo.Size = New System.Drawing.Size(174, 30)
    	Me.cmdPromo.TabIndex = 2
    	Me.cmdPromo.Text = "Borrar"
    	Me.cmdPromo.UseVisualStyleBackColor = true
    	'
    	'GroupBox4
    	'
    	Me.GroupBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    	Me.GroupBox4.Controls.Add(Me.cmdAddJingel)
    	Me.GroupBox4.Controls.Add(Me.cmdDelJingel)
    	Me.GroupBox4.Location = New System.Drawing.Point(128, 378)
    	Me.GroupBox4.Name = "GroupBox4"
    	Me.GroupBox4.Size = New System.Drawing.Size(528, 66)
    	Me.GroupBox4.TabIndex = 4
    	Me.GroupBox4.TabStop = false
    	Me.GroupBox4.Text = "Jingels"
    	'
    	'cmdAddJingel
    	'
    	Me.cmdAddJingel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    	Me.cmdAddJingel.Enabled = false
    	Me.cmdAddJingel.Image = CType(resources.GetObject("cmdAddJingel.Image"),System.Drawing.Image)
    	Me.cmdAddJingel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    	Me.cmdAddJingel.Location = New System.Drawing.Point(332, 19)
    	Me.cmdAddJingel.Name = "cmdAddJingel"
    	Me.cmdAddJingel.Size = New System.Drawing.Size(174, 30)
    	Me.cmdAddJingel.TabIndex = 3
    	Me.cmdAddJingel.Text = "Afegir"
    	Me.cmdAddJingel.UseVisualStyleBackColor = true
    	'
    	'cmdDelJingel
    	'
    	Me.cmdDelJingel.Image = CType(resources.GetObject("cmdDelJingel.Image"),System.Drawing.Image)
    	Me.cmdDelJingel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    	Me.cmdDelJingel.Location = New System.Drawing.Point(22, 19)
    	Me.cmdDelJingel.Name = "cmdDelJingel"
    	Me.cmdDelJingel.Size = New System.Drawing.Size(174, 30)
    	Me.cmdDelJingel.TabIndex = 2
    	Me.cmdDelJingel.Text = "Borrar"
    	Me.cmdDelJingel.UseVisualStyleBackColor = true
    	'
    	'GroupBox5
    	'
    	Me.GroupBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    	Me.GroupBox5.Controls.Add(Me.Label4)
    	Me.GroupBox5.Controls.Add(Me.cmdPath)
    	Me.GroupBox5.Controls.Add(Me.txtPath)
    	Me.GroupBox5.Location = New System.Drawing.Point(128, 54)
    	Me.GroupBox5.Name = "GroupBox5"
    	Me.GroupBox5.Size = New System.Drawing.Size(528, 66)
    	Me.GroupBox5.TabIndex = 5
    	Me.GroupBox5.TabStop = false
    	Me.GroupBox5.Text = "Origen de les còpies dels fitxer a recuperar"
    	'
    	'Label4
    	'
    	Me.Label4.AutoSize = true
    	Me.Label4.Location = New System.Drawing.Point(20, 32)
    	Me.Label4.Name = "Label4"
    	Me.Label4.Size = New System.Drawing.Size(78, 13)
    	Me.Label4.TabIndex = 16
    	Me.Label4.Text = "Directori origen"
    	'
    	'cmdPath
    	'
    	Me.cmdPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    	Me.cmdPath.Location = New System.Drawing.Point(478, 28)
    	Me.cmdPath.Name = "cmdPath"
    	Me.cmdPath.Size = New System.Drawing.Size(28, 21)
    	Me.cmdPath.TabIndex = 15
    	Me.cmdPath.Text = "..."
    	Me.cmdPath.UseVisualStyleBackColor = true
    	'
    	'txtPath
    	'
    	Me.txtPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
    	    	    	Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    	Me.txtPath.Location = New System.Drawing.Point(112, 28)
    	Me.txtPath.Name = "txtPath"
    	Me.txtPath.Size = New System.Drawing.Size(360, 20)
    	Me.txtPath.TabIndex = 14
    	'
    	'Label5
    	'
    	Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    	Me.Label5.ForeColor = System.Drawing.Color.Blue
    	Me.Label5.Location = New System.Drawing.Point(136, 456)
    	Me.Label5.Name = "Label5"
    	Me.Label5.Size = New System.Drawing.Size(520, 34)
    	Me.Label5.TabIndex = 6
    	Me.Label5.Text = "Per estalviar espai al disc dur podem borrar tots els fitxers que no s'utilitzin "& _ 
    	"actualment. Atenció abans de borrar-los s'ha d'estar segur que ja s'ha fet la se"& _ 
    	"va còpia de seguretat."
    	'
    	'cmdExit
    	'
    	Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    	Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
    	Me.cmdExit.Image = CType(resources.GetObject("cmdExit.Image"),System.Drawing.Image)
    	Me.cmdExit.Location = New System.Drawing.Point(715, 12)
    	Me.cmdExit.Name = "cmdExit"
    	Me.cmdExit.Size = New System.Drawing.Size(45, 41)
    	Me.cmdExit.TabIndex = 7
    	Me.cmdExit.UseVisualStyleBackColor = true
    	'
    	'ProgressBar1
    	'
    	Me.ProgressBar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    	Me.ProgressBar1.Location = New System.Drawing.Point(128, 493)
    	Me.ProgressBar1.Name = "ProgressBar1"
    	Me.ProgressBar1.Size = New System.Drawing.Size(468, 12)
    	Me.ProgressBar1.TabIndex = 8
    	Me.ProgressBar1.Visible = false
    	'
    	'cmdCancel
    	'
    	Me.cmdCancel.Anchor = System.Windows.Forms.AnchorStyles.Right
    	Me.cmdCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.cmdCancel.Location = New System.Drawing.Point(601, 488)
    	Me.cmdCancel.Name = "cmdCancel"
    	Me.cmdCancel.Size = New System.Drawing.Size(55, 19)
    	Me.cmdCancel.TabIndex = 9
    	Me.cmdCancel.Text = "Cancelar"
    	Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.TopCenter
    	Me.cmdCancel.UseVisualStyleBackColor = true
    	Me.cmdCancel.Visible = false
    	'
    	'lbInfoProgress
    	'
    	Me.lbInfoProgress.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    	Me.lbInfoProgress.AutoSize = true
    	Me.lbInfoProgress.Location = New System.Drawing.Point(130, 513)
    	Me.lbInfoProgress.Name = "lbInfoProgress"
    	Me.lbInfoProgress.Size = New System.Drawing.Size(0, 13)
    	Me.lbInfoProgress.TabIndex = 10
    	'
    	'frmRestoreAudio
    	'
    	Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    	Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    	Me.CancelButton = Me.cmdExit
    	Me.ClientSize = New System.Drawing.Size(792, 536)
    	Me.Controls.Add(Me.lbInfoProgress)
    	Me.Controls.Add(Me.cmdCancel)
    	Me.Controls.Add(Me.ProgressBar1)
    	Me.Controls.Add(Me.cmdExit)
    	Me.Controls.Add(Me.Label5)
    	Me.Controls.Add(Me.GroupBox5)
    	Me.Controls.Add(Me.GroupBox4)
    	Me.Controls.Add(Me.GroupBox3)
    	Me.Controls.Add(Me.GroupBox2)
    	Me.Controls.Add(Me.GroupBox1)
    	Me.Controls.Add(Me.Label1)
    	Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
    	Me.MinimumSize = New System.Drawing.Size(800, 570)
    	Me.Name = "frmRestoreAudio"
    	Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    	Me.Text = "Manteniment de fitxers"
    	Me.GroupBox1.ResumeLayout(false)
    	Me.GroupBox2.ResumeLayout(false)
    	Me.GroupBox3.ResumeLayout(false)
    	Me.GroupBox4.ResumeLayout(false)
    	Me.GroupBox5.ResumeLayout(false)
    	Me.GroupBox5.PerformLayout
    	Me.ResumeLayout(false)
    	Me.PerformLayout
    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAddMusic As System.Windows.Forms.Button
    Friend WithEvents cmdDelMusic As System.Windows.Forms.Button
    Friend WithEvents cmdAddPubli As System.Windows.Forms.Button
    Friend WithEvents cmdDelPubli As System.Windows.Forms.Button
    Friend WithEvents cmdAddPromo As System.Windows.Forms.Button
    Friend WithEvents cmdPromo As System.Windows.Forms.Button
    Friend WithEvents cmdAddJingel As System.Windows.Forms.Button
    Friend WithEvents cmdDelJingel As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents lbInfoProgress As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmdPath As System.Windows.Forms.Button
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
End Class
