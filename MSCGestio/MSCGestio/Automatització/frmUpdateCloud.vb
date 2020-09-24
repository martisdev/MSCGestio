Public Class frmUpdateCloud
    Dim TotalSync As Boolean
    Public Sub New(Total As Boolean)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        TotalSync = Total
    End Sub

    Private Sub frmUpdateCloud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AmbTasquesPendents = True
        setLanguageForm()

        Me.Show()

        Dim bkp As New Backup
        AddHandler bkp.StatusChanged, AddressOf InfoCloudProcess
        Dim result As Boolean = True
        If TotalSync = True Then
            result = bkp.SincroDBSTotalCloud()
        Else
            result = bkp.SincroDBSWebCloud()
        End If
        AmbTasquesPendents = False
        If result = True Then
            Me.DialogResult = DialogResult.OK
        Else
            Me.DialogResult = DialogResult.Cancel
        End If
        Me.Close()

    End Sub

    Private Sub InfoCloudProcess(ByVal newStatus As String)
        Try
            Dim msg() As String = Split(newStatus, ",")


            If msg(2) = "1" Then
                If IsNumeric(msg(0)) Then MetroProgressSpinnerCloud.Maximum = CInt(msg(0))
                If IsNumeric(msg(1)) Then MetroProgressSpinnerCloud.Value = CInt(msg(1))
                lbInfoProcess.Text = String.Format(MSG_UPDATE_DATA, msg(3))
            Else
                MetroProgressSpinnerCloud.Value = 0
                If IsNumeric(msg(0)) Then MetroProgressGeneralCloud.Maximum = CInt(msg(0))
                If IsNumeric(msg(1)) Then MetroProgressGeneralCloud.Value = CInt(msg(1))
                lbInfoProcess.Text = String.Format(MSG_UPDATE_TABLE, msg(3))
            End If

            My.Application.DoEvents()
        Catch ex As Exception
        End Try

    End Sub

    Dim MSG_UPDATE_TABLE As String = ""

    Public Sub setLanguageForm()
        Lang.StrForm = Me.Name

        lbInfoProcess.Text = Lang.getText("lbInfoProcess.Text") '"Sincronitza les dades"
        MSG_UPDATE_TABLE = Lang.getText("MSG_UPDATE_TABLE") '"Updating table {0}"

        Me.Text = Lang.getText("Text") '"Sincronitzant amb el núvol"

    End Sub
End Class