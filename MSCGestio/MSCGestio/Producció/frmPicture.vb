Public Class frmPicture

    Private Sub FormPicture_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub FormPicture_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Height = Me.PictureBoxPersona.Image.Height + 22
        Me.Width = Me.PictureBoxPersona.Image.Width + 5
        Me.Text = lang.getText("LABEL_IMATGE",True) '"Imatge"
    End Sub

    Private Sub PictureBoxPersona_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBoxPersona.DoubleClick
        Me.Close()
    End Sub
End Class