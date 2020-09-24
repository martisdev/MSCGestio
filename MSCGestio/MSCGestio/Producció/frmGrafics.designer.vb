<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGrafics
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGrafics))
        Me.tabpanel = New MetroFramework.Controls.MetroTabControl()
        Me.TabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.cmdRadiaInterp = New MetroFramework.Controls.MetroButton()
        Me.cmdRadiaEstil = New MetroFramework.Controls.MetroButton()
        Me.cmdRadiaIdioma = New MetroFramework.Controls.MetroButton()
        Me.txtIntervalDate = New System.Windows.Forms.MonthCalendar()
        Me.TabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.chkPautaIn = New MetroFramework.Controls.MetroCheckBox()
        Me.cmdDBSAny = New MetroFramework.Controls.MetroButton()
        Me.cmdDBSRitme = New MetroFramework.Controls.MetroButton()
        Me.cmdDBSTemp = New MetroFramework.Controls.MetroButton()
        Me.cmdDBSSubj = New MetroFramework.Controls.MetroButton()
        Me.cmdDBSIdioma = New MetroFramework.Controls.MetroButton()
        Me.cmdDBSInterp = New MetroFramework.Controls.MetroButton()
        Me.cmdDBSEstil = New MetroFramework.Controls.MetroButton()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.picGraf = New System.Windows.Forms.PictureBox()
        Me.cmdSortir = New MetroFramework.Controls.MetroLink()
        Me.pic_logo = New System.Windows.Forms.PictureBox()
        Me.tabpanel.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.picGraf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabpanel
        '
        Me.tabpanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tabpanel.Controls.Add(Me.TabPage1)
        Me.tabpanel.Controls.Add(Me.TabPage2)
        Me.tabpanel.Location = New System.Drawing.Point(26, 68)
        Me.tabpanel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tabpanel.Name = "tabpanel"
        Me.tabpanel.SelectedIndex = 0
        Me.tabpanel.Size = New System.Drawing.Size(230, 477)
        Me.tabpanel.TabIndex = 0
        Me.tabpanel.UseSelectable = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.cmdRadiaInterp)
        Me.TabPage1.Controls.Add(Me.cmdRadiaEstil)
        Me.TabPage1.Controls.Add(Me.cmdRadiaIdioma)
        Me.TabPage1.Controls.Add(Me.txtIntervalDate)
        Me.TabPage1.HorizontalScrollbarBarColor = True
        Me.TabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.TabPage1.HorizontalScrollbarSize = 4
        Me.TabPage1.Location = New System.Drawing.Point(4, 38)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage1.Size = New System.Drawing.Size(222, 435)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Radiació"
        Me.TabPage1.UseVisualStyleBackColor = True
        Me.TabPage1.VerticalScrollbarBarColor = True
        Me.TabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.TabPage1.VerticalScrollbarSize = 6
        '
        'cmdRadiaInterp
        '
        Me.cmdRadiaInterp.Location = New System.Drawing.Point(27, 296)
        Me.cmdRadiaInterp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdRadiaInterp.Name = "cmdRadiaInterp"
        Me.cmdRadiaInterp.Size = New System.Drawing.Size(171, 43)
        Me.cmdRadiaInterp.TabIndex = 3
        Me.cmdRadiaInterp.Text = "Estadística per Intèrprets"
        Me.cmdRadiaInterp.UseSelectable = True
        '
        'cmdRadiaEstil
        '
        Me.cmdRadiaEstil.Location = New System.Drawing.Point(27, 245)
        Me.cmdRadiaEstil.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdRadiaEstil.Name = "cmdRadiaEstil"
        Me.cmdRadiaEstil.Size = New System.Drawing.Size(171, 43)
        Me.cmdRadiaEstil.TabIndex = 2
        Me.cmdRadiaEstil.Text = "Estadística per Estils"
        Me.cmdRadiaEstil.UseSelectable = True
        '
        'cmdRadiaIdioma
        '
        Me.cmdRadiaIdioma.Location = New System.Drawing.Point(27, 194)
        Me.cmdRadiaIdioma.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdRadiaIdioma.Name = "cmdRadiaIdioma"
        Me.cmdRadiaIdioma.Size = New System.Drawing.Size(171, 43)
        Me.cmdRadiaIdioma.TabIndex = 1
        Me.cmdRadiaIdioma.Text = "Estadística per Idiomes"
        Me.cmdRadiaIdioma.UseSelectable = True
        '
        'txtIntervalDate
        '
        Me.txtIntervalDate.Location = New System.Drawing.Point(27, 16)
        Me.txtIntervalDate.Margin = New System.Windows.Forms.Padding(10, 12, 10, 12)
        Me.txtIntervalDate.MaxSelectionCount = 365
        Me.txtIntervalDate.Name = "txtIntervalDate"
        Me.txtIntervalDate.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.chkPautaIn)
        Me.TabPage2.Controls.Add(Me.cmdDBSAny)
        Me.TabPage2.Controls.Add(Me.cmdDBSRitme)
        Me.TabPage2.Controls.Add(Me.cmdDBSTemp)
        Me.TabPage2.Controls.Add(Me.cmdDBSSubj)
        Me.TabPage2.Controls.Add(Me.cmdDBSIdioma)
        Me.TabPage2.Controls.Add(Me.cmdDBSInterp)
        Me.TabPage2.Controls.Add(Me.cmdDBSEstil)
        Me.TabPage2.HorizontalScrollbarBarColor = True
        Me.TabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.TabPage2.HorizontalScrollbarSize = 4
        Me.TabPage2.Location = New System.Drawing.Point(4, 38)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage2.Size = New System.Drawing.Size(222, 435)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "DBS"
        Me.TabPage2.UseVisualStyleBackColor = True
        Me.TabPage2.VerticalScrollbarBarColor = True
        Me.TabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.TabPage2.VerticalScrollbarSize = 6
        '
        'chkPautaIn
        '
        Me.chkPautaIn.AutoSize = True
        Me.chkPautaIn.Location = New System.Drawing.Point(21, 372)
        Me.chkPautaIn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkPautaIn.Name = "chkPautaIn"
        Me.chkPautaIn.Size = New System.Drawing.Size(164, 15)
        Me.chkPautaIn.TabIndex = 11
        Me.chkPautaIn.Text = "Només inclosos a la pauta."
        Me.chkPautaIn.UseSelectable = True
        '
        'cmdDBSAny
        '
        Me.cmdDBSAny.Location = New System.Drawing.Point(12, 321)
        Me.cmdDBSAny.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdDBSAny.Name = "cmdDBSAny"
        Me.cmdDBSAny.Size = New System.Drawing.Size(197, 43)
        Me.cmdDBSAny.TabIndex = 10
        Me.cmdDBSAny.Text = "Estadística per Any Publicació"
        Me.cmdDBSAny.UseSelectable = True
        '
        'cmdDBSRitme
        '
        Me.cmdDBSRitme.Location = New System.Drawing.Point(12, 270)
        Me.cmdDBSRitme.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdDBSRitme.Name = "cmdDBSRitme"
        Me.cmdDBSRitme.Size = New System.Drawing.Size(197, 43)
        Me.cmdDBSRitme.TabIndex = 9
        Me.cmdDBSRitme.Text = "Estadística per Ritme"
        Me.cmdDBSRitme.UseSelectable = True
        '
        'cmdDBSTemp
        '
        Me.cmdDBSTemp.Location = New System.Drawing.Point(12, 219)
        Me.cmdDBSTemp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdDBSTemp.Name = "cmdDBSTemp"
        Me.cmdDBSTemp.Size = New System.Drawing.Size(197, 43)
        Me.cmdDBSTemp.TabIndex = 8
        Me.cmdDBSTemp.Text = "Estadística per Clas. Temporal"
        Me.cmdDBSTemp.UseSelectable = True
        '
        'cmdDBSSubj
        '
        Me.cmdDBSSubj.Location = New System.Drawing.Point(12, 168)
        Me.cmdDBSSubj.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdDBSSubj.Name = "cmdDBSSubj"
        Me.cmdDBSSubj.Size = New System.Drawing.Size(197, 43)
        Me.cmdDBSSubj.TabIndex = 7
        Me.cmdDBSSubj.Text = "Estadística per Clas. Subjectiva"
        Me.cmdDBSSubj.UseSelectable = True
        '
        'cmdDBSIdioma
        '
        Me.cmdDBSIdioma.Location = New System.Drawing.Point(12, 117)
        Me.cmdDBSIdioma.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdDBSIdioma.Name = "cmdDBSIdioma"
        Me.cmdDBSIdioma.Size = New System.Drawing.Size(197, 43)
        Me.cmdDBSIdioma.TabIndex = 6
        Me.cmdDBSIdioma.Text = "Estadística per Idiomes"
        Me.cmdDBSIdioma.UseSelectable = True
        '
        'cmdDBSInterp
        '
        Me.cmdDBSInterp.Location = New System.Drawing.Point(12, 67)
        Me.cmdDBSInterp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdDBSInterp.Name = "cmdDBSInterp"
        Me.cmdDBSInterp.Size = New System.Drawing.Size(197, 43)
        Me.cmdDBSInterp.TabIndex = 5
        Me.cmdDBSInterp.Text = "Estadística per Intèrprets"
        Me.cmdDBSInterp.UseSelectable = True
        '
        'cmdDBSEstil
        '
        Me.cmdDBSEstil.Location = New System.Drawing.Point(12, 16)
        Me.cmdDBSEstil.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdDBSEstil.Name = "cmdDBSEstil"
        Me.cmdDBSEstil.Size = New System.Drawing.Size(197, 43)
        Me.cmdDBSEstil.TabIndex = 4
        Me.cmdDBSEstil.Text = "Estadística per Estils"
        Me.cmdDBSEstil.UseSelectable = True
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.Location = New System.Drawing.Point(967, 77)
        Me.cmdClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(20, 19)
        Me.cmdClose.TabIndex = 2
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'picGraf
        '
        Me.picGraf.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picGraf.Location = New System.Drawing.Point(268, 104)
        Me.picGraf.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picGraf.Name = "picGraf"
        Me.picGraf.Size = New System.Drawing.Size(728, 441)
        Me.picGraf.TabIndex = 17
        Me.picGraf.TabStop = False
        '
        'cmdSortir
        '
        Me.cmdSortir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSortir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdSortir.Image = CType(resources.GetObject("cmdSortir.Image"), System.Drawing.Image)
        Me.cmdSortir.ImageSize = 32
        Me.cmdSortir.Location = New System.Drawing.Point(955, 50)
        Me.cmdSortir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdSortir.Name = "cmdSortir"
        Me.cmdSortir.Size = New System.Drawing.Size(41, 46)
        Me.cmdSortir.TabIndex = 243
        Me.cmdSortir.UseSelectable = True
        '
        'pic_logo
        '
        Me.pic_logo.Image = CType(resources.GetObject("pic_logo.Image"), System.Drawing.Image)
        Me.pic_logo.Location = New System.Drawing.Point(25, 25)
        Me.pic_logo.Name = "pic_logo"
        Me.pic_logo.Size = New System.Drawing.Size(40, 40)
        Me.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_logo.TabIndex = 266
        Me.pic_logo.TabStop = False
        '
        'frmGrafics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdClose
        Me.ClientSize = New System.Drawing.Size(1022, 575)
        Me.Controls.Add(Me.pic_logo)
        Me.Controls.Add(Me.cmdSortir)
        Me.Controls.Add(Me.picGraf)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.tabpanel)
        Me.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmGrafics"
        Me.Padding = New System.Windows.Forms.Padding(23, 78, 23, 26)
        Me.Text = "Gràfics"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.tabpanel.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.picGraf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtIntervalDate As System.Windows.Forms.MonthCalendar
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents picGraf As System.Windows.Forms.PictureBox
    Friend WithEvents tabpanel As MetroFramework.Controls.MetroTabControl
    Friend WithEvents TabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents TabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents cmdRadiaInterp As MetroFramework.Controls.MetroButton
    Friend WithEvents cmdRadiaEstil As MetroFramework.Controls.MetroButton
    Friend WithEvents cmdRadiaIdioma As MetroFramework.Controls.MetroButton
    Friend WithEvents cmdDBSIdioma As MetroFramework.Controls.MetroButton
    Friend WithEvents cmdDBSInterp As MetroFramework.Controls.MetroButton
    Friend WithEvents cmdDBSEstil As MetroFramework.Controls.MetroButton
    Friend WithEvents cmdDBSAny As MetroFramework.Controls.MetroButton
    Friend WithEvents cmdDBSRitme As MetroFramework.Controls.MetroButton
    Friend WithEvents cmdDBSTemp As MetroFramework.Controls.MetroButton
    Friend WithEvents cmdDBSSubj As MetroFramework.Controls.MetroButton
    Friend WithEvents cmdSortir As MetroFramework.Controls.MetroLink
    Friend WithEvents chkPautaIn As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents pic_logo As PictureBox
End Class
