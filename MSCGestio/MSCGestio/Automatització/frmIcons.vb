Public Class frmIcons
    Friend ID As Integer

    Private Sub frmIcons_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 0 To frmMain.imgListMnu.Images.Count - 1
            Dim my_img As Image = frmMain.imgListMnu.Images(i)
            Dim my_pig As New PictureBox
            my_pig.Image = my_img
            my_pig.Size = New System.Drawing.Size(40, 40)

            AddHandler my_pig.Click, AddressOf imgSelect_Click
            my_pig.Parent = FlowLayoutPanelImages
        Next
    End Sub

    Private Sub imgSelect_Click(sender As Object, e As EventArgs)
        Dim my_img As PictureBox = CType(sender, PictureBox)
        ID = FlowLayoutPanelImages.Controls.GetChildIndex(my_img)
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class