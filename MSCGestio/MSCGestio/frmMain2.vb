Public Class frmMain2
    Private Sub frmMain2_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub frmMain2_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Dim myScreens() As Screen = Screen.AllScreens
        If (myScreens.Length > 1) Then
            Dim screen As Screen = Screen.AllScreens(1)
            Me.Left = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width + (screen.Bounds.Width - Me.Width)
            Me.Top = 0
        Else
            Me.Left = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width - Me.Width
            Me.Top = 0
        End If

        Dim targetHeight As Integer = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height - 50
        Me.ClientSize = New Size(Me.ClientSize.Width, targetHeight)
    End Sub
End Class