Option Strict Off
Option Explicit On
Public Class frmFrangeHora
	Dim blEnable As Boolean
	'Dim FrangesH As New msc_dbs.ClasFrangesHoraries
	
	Private Sub CloseForm()
		MyAPP.CloseSesionClient(Usuari.UsrTipus,DESCRIP_FORM_FRANGES)
		Me.Dispose()
	End Sub
	
	Private Sub frmFrangeHora_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		CloseForm()
	End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click, cmdSortir.Click
        Me.Close()
    End Sub

    Private Sub TabDies_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TabDies.MouseUp
        LoadFraHora_Dia(TabDies.SelectedIndex + 1)
        Me.grupFranges.Parent = Me.TabDies.TabPages(TabDies.SelectedIndex)
    End Sub

    Private Sub cmdBloqueix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBloqueix.Click
        LockedRecord()
    End Sub

    Private Sub LockedRecord()
        blEnable = Not blEnable
        Me.grupFranges.Enabled = blEnable
        If blEnable Then
            Me.cmdBloqueix.Image = Me.picUnLock.Image
        Else
            Me.cmdBloqueix.Image = Me.picLock.Image
        End If
    End Sub

    Private Sub frmFrangeHora_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        setLanguageForm()
        Dim rs As DataTable = ListIncremTarifFrangHora()
        For i As Integer = 0 To rs.Rows.Count - 1
            Me.ComboH00.Items.Add(rs.Rows(i)(1))
            Me.ComboH01.Items.Add(rs.Rows(i)(1))
            Me.ComboH02.Items.Add(rs.Rows(i)(1))
            Me.ComboH03.Items.Add(rs.Rows(i)(1))
            Me.ComboH04.Items.Add(rs.Rows(i)(1))
            Me.ComboH05.Items.Add(rs.Rows(i)(1))
            Me.ComboH06.Items.Add(rs.Rows(i)(1))
            Me.ComboH07.Items.Add(rs.Rows(i)(1))
            Me.ComboH08.Items.Add(rs.Rows(i)(1))
            Me.ComboH09.Items.Add(rs.Rows(i)(1))
            Me.ComboH10.Items.Add(rs.Rows(i)(1))
            Me.ComboH11.Items.Add(rs.Rows(i)(1))
            Me.ComboH12.Items.Add(rs.Rows(i)(1))
            Me.ComboH13.Items.Add(rs.Rows(i)(1))
            Me.ComboH14.Items.Add(rs.Rows(i)(1))
            Me.ComboH15.Items.Add(rs.Rows(i)(1))
            Me.ComboH16.Items.Add(rs.Rows(i)(1))
            Me.ComboH17.Items.Add(rs.Rows(i)(1))
            Me.ComboH18.Items.Add(rs.Rows(i)(1))
            Me.ComboH19.Items.Add(rs.Rows(i)(1))
            Me.ComboH20.Items.Add(rs.Rows(i)(1))
            Me.ComboH21.Items.Add(rs.Rows(i)(1))
            Me.ComboH22.Items.Add(rs.Rows(i)(1))
            Me.ComboH23.Items.Add(rs.Rows(i)(1))
        Next i
        LoadFraHora_Dia(DiesSemana.DILLUNS)
        cmdBloqueix.Enabled = IIf(Usuari.UsrTipus > NivellUsers.USR_CONVIDAT, True, False)
        rs.Dispose()

    End Sub

    Public Sub setLanguageForm()
        lang.StrForm = Me.Name

        Me.TabPage1.Text = lang.getText("NAME_DILLUNS", True) '"Dilluns"
        Me.TabPage2.Text = lang.getText("NAME_DIMARTS", True) '"Dimarts"
        Me.TabPage3.Text = lang.getText("NAME_DIMECRES", True) '"Dimecres"
        Me.TabPage4.Text = lang.getText("NAME_DIJOUS", True) '"Dijous"
        Me.TabPage5.Text = lang.getText("NAME_DIVENDRES", True) '"Divendres"
        Me.TabPage6.Text = lang.getText("NAME_DISSABTE", True) '"Dissabte"
        Me.TabPage7.Text = lang.getText("NAME_DIUMENGE", True) '"Diumenge"
        Me.Label3.Text = lang.getText("Label3.Text") '"Increment de la tarifa segons la franja"

        Label2.Text = lang.getText("Label2.Text")
        Me.Label1.Text = lang.getText("Label1.Text") ' "Amb la franja podem diferènciar el preu a pagar per una publicitat segons l'audiència d'una hora en concret."
        '"El % de cada franja s'aplicarà per increment a la tarifa." 
        '"Les dades es salven automàticament."
        Me.Text = lang.getText("Text") '"Manteniment de Franges horàries"							
    End Sub

    Private Sub LoadFraHora_Dia(ByVal dia As Short)
        Dim StrSql As String = "SELECT * FROM frangeshoraries WHERE franID = " & dia
        Dim db As New MSC.dbs(Cloud)

        Dim rs As DataTable = db.getTable(StrSql)
        Me.ComboH00.SelectedIndex = rs.Rows(0)(0)
        Me.ComboH01.SelectedIndex = rs.Rows(0)(1)
        Me.ComboH02.SelectedIndex = rs.Rows(0)(2)
        Me.ComboH03.SelectedIndex = rs.Rows(0)(3)
        Me.ComboH04.SelectedIndex = rs.Rows(0)(4)
        Me.ComboH05.SelectedIndex = rs.Rows(0)(5)
        Me.ComboH06.SelectedIndex = rs.Rows(0)(6)
        Me.ComboH07.SelectedIndex = rs.Rows(0)(7)
        Me.ComboH08.SelectedIndex = rs.Rows(0)(8)
        Me.ComboH09.SelectedIndex = rs.Rows(0)(9)
        Me.ComboH10.SelectedIndex = rs.Rows(0)(10)
        Me.ComboH11.SelectedIndex = rs.Rows(0)(11)
        Me.ComboH12.SelectedIndex = rs.Rows(0)(12)
        Me.ComboH13.SelectedIndex = rs.Rows(0)(13)
        Me.ComboH14.SelectedIndex = rs.Rows(0)(14)
        Me.ComboH15.SelectedIndex = rs.Rows(0)(15)
        Me.ComboH16.SelectedIndex = rs.Rows(0)(16)
        Me.ComboH17.SelectedIndex = rs.Rows(0)(17)
        Me.ComboH18.SelectedIndex = rs.Rows(0)(18)
        Me.ComboH19.SelectedIndex = rs.Rows(0)(19)
        Me.ComboH20.SelectedIndex = rs.Rows(0)(20)
        Me.ComboH21.SelectedIndex = rs.Rows(0)(21)
        Me.ComboH22.SelectedIndex = rs.Rows(0)(22)
        Me.ComboH23.SelectedIndex = rs.Rows(0)(23)
        db = Nothing
        rs.Dispose()
    End Sub

    Private Sub ComboH00_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
        ComboH00.SelectedIndexChanged, ComboH01.SelectedIndexChanged, ComboH02.SelectedIndexChanged, ComboH03.SelectedIndexChanged, ComboH04.SelectedIndexChanged, ComboH05.SelectedIndexChanged _
        , ComboH06.SelectedIndexChanged, ComboH07.SelectedIndexChanged, ComboH08.SelectedIndexChanged, ComboH09.SelectedIndexChanged, ComboH10.SelectedIndexChanged _
        , ComboH11.SelectedIndexChanged, ComboH12.SelectedIndexChanged, ComboH13.SelectedIndexChanged, ComboH14.SelectedIndexChanged, ComboH15.SelectedIndexChanged _
        , ComboH16.SelectedIndexChanged, ComboH17.SelectedIndexChanged, ComboH18.SelectedIndexChanged, ComboH19.SelectedIndexChanged, ComboH20.SelectedIndexChanged _
        , ComboH21.SelectedIndexChanged, ComboH22.SelectedIndexChanged, ComboH23.SelectedIndexChanged

        Dim MyCombo As ComboBox = CType(sender, ComboBox)
        MyCombo.BackColor = Choose(MyCombo.SelectedIndex + 1, Color.Yellow, Color.MistyRose, Color.LightSalmon, Color.Salmon, Color.DarkSalmon, Color.Tomato, Color.LightCoral, Color.Coral, Color.OrangeRed, Color.Red)
        Dim Hora As String = MyCombo.Name.ToString.Remove(0, 6)
        If blEnable Then
            Dim NomHora As String = "fran" & Hora & "h"
            Dim sCmd As String = "UPDATE frangeshoraries"
            sCmd = sCmd & " SET "
            sCmd = sCmd & NomHora & " = " & CType(sender, ComboBox).SelectedIndex
            sCmd = sCmd & " WHERE franID = " & TabDies.SelectedIndex + 1 & " ;"
            Dim db As New MSC.dbs(Cloud)
            db.Update_ID(sCmd)
            db = Nothing
        End If
    End Sub
End Class