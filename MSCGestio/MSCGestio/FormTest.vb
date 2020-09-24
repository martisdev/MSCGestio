Public Class FormTest
    Private Sub FormTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ClientSize = New Size(frm_sice(0), frm_sice(1))
    End Sub

    Private Sub FormTest_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        Dim FitxerINI As New IniFile
        frm_sice(0) = Me.Width : frm_sice(1) = Me.Height
        FitxerINI.INIWrite(MyAPP.IniFile, "Data Gest", "size", frm_sice(0).ToString & "," & frm_sice(1).ToString)
    End Sub
End Class