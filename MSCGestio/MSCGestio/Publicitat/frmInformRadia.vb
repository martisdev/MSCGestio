Option Strict Off
Option Explicit On

Public Class frmInformRadia
	'Dim CtlRadiacio As New msc_dbs.ClasControlRadi
	Private Sub CloseForm()
		MyAPP.CloseSesionClient(MyAPP.IDSesion_Client, DESCRIP_FORM_INFORMES)
		Me.Dispose()
	End Sub
	
	Private Sub frmInformRadia_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		CloseForm()
	End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click, cmdSortir.Click
        Me.Close()
    End Sub

    Private Sub frmInformRadia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		setLanguageForm()

        Me.txtIntervalData.MaxDate = DateSerial(Now.Year, Now.Month, Now.Day + 1)
        Me.ClientSize = New Size(frm_sice(0), frm_sice(1))
    End Sub
	
	Dim MSG_ERROR_REGISTRE As String 
	Dim MSG_ERROR_CLIENT As String
	Public Sub setLanguageForm()
		lang.StrForm = Me.Name
		
		MSG_ERROR_REGISTRE = lang.getText("MSG_ERROR_REGISTRE") '"No hi ha cap registre per imprimir"
		MSG_ERROR_CLIENT = lang.getText("MSG_ERROR_CLIENT") '"No hi ha cap client seleccionat"
		
		Me.label2.Text = lang.getText("FITXER_PUBLICITAT",True) '"Publicitat"
		Me.Label1.Text = lang.getText("HEADERTEXT_CLIENT",True) '"Client"

		Me.cmdFactura.Text =  lang.getText("cmdFactura.Text") '"Factura de radiació"
		Me.cmdInform.Text = lang.getText("cmdInform.Text") '"Informe de radiació"
		Me.Text = lang.getText("Text") '"Informes de radiació falques publicitàries"

        Dim Cmb As New combo
        Cmb.OmpleCombo(ComboClient, TAULES_DBS.TAULA_CLIENTS, TotsCap.CAP) : ComboClient.SelectedValue = 0
        Cmb.OmpleCombo(ComboPubli, TAULES_DBS.TAULA_PUBLICITAT, TotsCap.TOTS) : ComboPubli.SelectedValue = 0

    End Sub
	
	
	Private Sub ComboClient_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboClient.KeyPress, ComboPubli.KeyPress
		e.KeyChar = UCase(e.KeyChar)
	End Sub
	
	Private Sub ComboClient_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboClient.SelectedIndexChanged
		Dim StrSql As String = "falc_client = " & ComboClient.SelectedValue
		'If ComboClient.SelectedValue = 0 Then StrSql = ""
		Dim Cmb As New combo
		Cmb.OmpleCombo(ComboPubli, TAULES_DBS.TAULA_PUBLICITAT, TotsCap.TOTS, StrSql)
	End Sub
	
	Private Sub cmdInform_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInform.Click
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.AppStarting
        If Not MyAPP.PermisPerContinuar() Then MetroFramework.MetroMessageBox.Show(Me, MSG_SERVER_CLOSE, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Stop, 100) : Me.Close()
        Dim DataIn As Date = txtIntervalData.SelectionStart
        Dim DataOut As Date = txtIntervalData.SelectionEnd
        If DataOut.ToShortDateString = Now.ToShortDateString Then DataOut = DataOut.AddDays(1)
        Dim ClientID As Integer = ComboClient.SelectedValue
        If ClientID Then
            Dim falcaID As Integer = ComboPubli.SelectedValue
            Dim Origen As String = "SELECT falques.falc_nom, clients.cli_nom, controlradiacio.ctl_dataradiacio "
            Origen = Origen + "FROM (falques INNER JOIN controlradiacio ON falques.falc_id = controlradiacio.ctl_fitxer) INNER JOIN clients ON falques.falc_client = clients.cli_id "
            Origen = Origen + "WHERE (((controlradiacio.ctl_tipfitxer)=3) AND ((clients.cli_id)= " & ClientID & ")) AND controlradiacio.ctl_dataradiacio >= '" & DataIn.ToString("yyyy-MM-dd") & "' AND controlradiacio.ctl_dataradiacio <= '" & DataOut.ToString("yyyy-MM-dd") & "' "

            If falcaID Then
                Origen = Origen + " AND ((controlradiacio.ctl_fitxer)= " & falcaID & ") ORDER BY controlradiacio.ctl_dataradiacio;"
            Else
                Origen = Origen + " ORDER BY controlradiacio.ctl_dataradiacio;"
            End If
            Dim db As New MSC.dbs(Cloud)
            Dim rs As DataTable = db.getTable(Origen)
            If rs.Rows.Count > 0 Then
                Dim frmPRT As New frmPrint
                frmPRT.defineReport(ComboClient.Text, IIf(falcaID = 0, "", ComboPubli.Text), DataIn, DataOut, rs, frmPrint.Tipusllistats.LLISTAT_Informe)
                Try
                    frmPRT.Show(Me)
                Catch ex As Exception
                    frmPRT.WindowState = FormWindowState.Normal
                End Try
            Else
                MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_REGISTRE, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
            End If
            db = Nothing
            rs.Dispose()
        Else
            MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_CLIENT, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
        End If
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub cmdFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFactura.Click
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.AppStarting
        If Not MyAPP.PermisPerContinuar() Then MetroFramework.MetroMessageBox.Show(Me, MSG_SERVER_CLOSE, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Stop, 100) : Me.Close()
        Dim DataIn As Date = txtIntervalData.SelectionStart
        Dim DataOut As Date = txtIntervalData.SelectionEnd
        If DataOut.ToShortDateString = Now.ToShortDateString Then DataOut = DataOut.AddDays(1)
        Dim ClientID As Integer = Me.ComboClient.SelectedValue
        If ClientID Then
            Dim falcaID As Integer = ComboPubli.SelectedValue
            Dim Origen As String = "SELECT falques.falc_nom, clients.cli_nom, controlradiacio.ctl_dataradiacio, tarifes.tarif_preu,falques.falc_id"
            Origen = Origen + " FROM ((falques INNER JOIN controlradiacio ON falques.falc_id = controlradiacio.ctl_fitxer) INNER JOIN clients ON falques.falc_client = clients.cli_id) INNER JOIN tarifes ON falques.falc_tarifa = tarifes.tarif_id"
            Origen = Origen + " WHERE (((controlradiacio.ctl_tipfitxer)=3) AND ((clients.cli_id)= " & ClientID & ")) AND controlradiacio.ctl_dataradiacio >= '" & DataIn.ToString("yyyy-MM-dd") & "' AND controlradiacio.ctl_dataradiacio <= '" & DataOut.ToString("yyyy-MM-dd") & "' "

            If falcaID Then
                Origen = Origen + " AND ((controlradiacio.ctl_fitxer)= " & falcaID & ") ORDER BY controlradiacio.ctl_dataradiacio;"
            Else
                Origen = Origen + " ORDER BY controlradiacio.ctl_dataradiacio;"
            End If
            Dim db As New MSC.dbs(Cloud)
            Dim rs As DataTable = db.getTable(Origen)
            If rs.Rows.Count > 0 Then
                Dim frmPRT As New frmPrint
                frmPRT.defineReport(ComboClient.Text, IIf(falcaID = 0, "", ComboPubli.Text), DataIn, DataOut, rs, frmPrint.Tipusllistats.LLISTAT_Factura)
                Try
                    frmPRT.Show(Me)
                Catch ex As Exception
                    frmPRT.WindowState = FormWindowState.Normal
                End Try
            Else
                MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_REGISTRE, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
            End If
            db = Nothing
            rs.Dispose()
        Else
            MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_REGISTRE, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
        End If
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Sub ComboClient_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboClient.KeyUp
		Select Case e.KeyCode
			Case Keys.Left, Keys.Right, Keys.Up, Keys.Down
				Return
		End Select
		Dim MyComboBox As ComboBox = CType(sender, ComboBox)
		Dim Origen As TAULES_DBS = TAULES_DBS.TAULA_CLIENTS
		refreshComboBoxKeyUp(MyComboBox, Origen, TotsCap.CAP)
	End Sub

    Private Sub frmInformRadia_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        Dim FitxerINI As New IniFile
        frm_sice(0) = Me.Width : frm_sice(1) = Me.Height
        FitxerINI.INIWrite(MyAPP.IniFile, "Data Gest", "size", frm_sice(0).ToString & "," & frm_sice(1).ToString)
    End Sub
End Class