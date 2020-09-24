Option Strict Off
Option Explicit On
Public Class frmBuscarDiscos
	
	Public OptAvanç As Boolean ' Per fer recerca avançada
    Public IsClosed As Boolean
    Friend SqlQuery As String = ""

    Dim FormatFitxer As Short
	
	Private Sub cmdMoreFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMoreFind.Click
		If OptAvanç = True Then
			OptAvanç = False
            Me.Height = 300
            cmdMoreFind.Text = LABEL_AVANCAT
			Me.fraAvanç.Visible = OptAvanç
			Me.chkAddResult.Checked = False
		Else
			OptAvanç = True
            Me.Height = 545
            cmdMoreFind.Text = LABEL_SENZILL
			Me.fraAvanç.Visible = OptAvanç
		End If
		Me.txtNomDisc.Focus()
	End Sub

    Private Sub frmBuscarDiscos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
		setLanguageForm()

        If OptAvanç Then Me.Height = 500 : cmdMoreFind.Text = LABEL_SENZILL
        Me.fraAvanç.Visible = OptAvanç
		
	End Sub
	

	
	Public Sub setLanguageForm()
		lang.StrForm = Me.Name
		
		Me.cmdMoreFind.Text = IIf( OptAvanç= False, LABEL_AVANCAT,LABEL_SENZILL).ToString
			
		Me.chkAddResult.Text = lang.getText("LABEL_ADD_RESULT",True)'"Afegir a la recerca anterior"
		Me.fraAvanç.Text = lang.getText("LABEL_RECERCA_ABANCADA",True)'"Recerca avançada"
		Me.GroupBox2.Text = lang.getText("LABEL_FORMAT",True)'"Format"
		Me.ChkIgnoreFormat.Text = lang.getText("ChkIgnoreFormat.Text")'"Ignorar"
		Me.optAltres.Text = lang.getText("FITXER_ALTRES",True)'"Altres"
		Me.optVinil.Text = lang.getText("LABEL_VINIL", True)'"Vinil"
		Me.optK7.Text = lang.getText("LABEL_K7",True)'"K7"
		Me.optMP3.Text = lang.getText("LABEL_MP3",True)'"MP3"
		Me.optCD.Text = lang.getText("LABEL_CD",True)'"CD"
		Me.Label8.Text = lang.getText("LABEL_ANY_PUBLICACIO",True)'"Any publicació"
		Me.Label7.Text = lang.getText("Label7.Text")'"Prestatge"
		Me.Label6.Text = lang.getText("LABEL_PROVEIDOR",True)'"Proveïdor"
		Me.Label5.Text = lang.getText("Label5.Text")'"Companyia"
		Me.Label1.Text = lang.getText("Label1.Text")'"Buscar un disc segons un filtre determinat."
		Me.Label2.Text = lang.getText("Label2.Text")'"Nom del Disc"
		Me.Label3.Text = lang.getText("HEADERTEXT_INTERP",True)'"Intèrpret"
		Me.Label4.Text = lang.getText("HEADERTEXT_ESTIL",True)'"Estil"
		Me.Text = lang.getText("Text") '"Buscar disc ..."

        Dim Cmb As New combo
        Cmb.OmpleCombo(ComboInterp, TAULES_DBS.TAULA_INTERPRETS, TotsCap.TOTS) : ComboInterp.SelectedValue = 0
        Cmb.OmpleCombo(ComboCia, TAULES_DBS.TAULA_DISCOGRAFIQUES, TotsCap.TOTS) : ComboCia.SelectedValue = 0
        Cmb.OmpleCombo(ComboEstil, TAULES_DBS.TAULA_ESTILS, TotsCap.TOTS) : ComboEstil.SelectedValue = 0
        Cmb.OmpleCombo(ComboProveidor, TAULES_DBS.TAULA_PROVEIDORS, TotsCap.TOTS) : ComboProveidor.SelectedValue = 0
        Me.ComboProveidor.Enabled = IIf(Usuari.UsrTipus > NivellUsers.USR_CONVIDAT, True, False)

    End Sub

    Private Sub CmdTancar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdTancar.Click, cmdSortir.Click
        Me.Close()
    End Sub

    Private Sub chkColCIA_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
		Dim IdCol As Short = CShort(CType(sender, CheckBox).Tag)
		frmDiscos.Column(IdCol) = CType(sender, CheckBox).Checked
	End Sub
	
	Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        Static LastQuery As String = ""
        Dim StrSql As String = ""

        If Len(Me.txtNomDisc.Text) > 0 Then
			StrSql = "disc_nom Like '%" & Me.txtNomDisc.Text & "%' "
		End If
		If Me.ComboEstil.SelectedValue > 0 Then
			If Len(StrSql) > 0 Then StrSql = StrSql & " AND "
			StrSql = StrSql & " disc_estil = " & ComboEstil.SelectedValue
			
		End If
		If Me.ComboInterp.SelectedValue > 0 Then
			If Len(StrSql) > 0 Then StrSql = StrSql & " AND "
			StrSql = StrSql & " disc_interpret = " & ComboInterp.SelectedValue
		End If
		If OptAvanç Then
			If Me.ComboCia.SelectedValue > 0 Then
				If Len(StrSql) > 0 Then StrSql = StrSql & " AND "
				StrSql = StrSql & " disc_cia = " & ComboCia.SelectedValue
			End If
			If Me.ComboProveidor.SelectedValue > 0 Then
				If Len(StrSql) > 0 Then StrSql = StrSql & " AND "
				StrSql = StrSql & " disc_propietari = " & ComboProveidor.SelectedValue
			End If
			If Len(Me.txtEstant.Text) > 0 Then
				If Len(StrSql) > 0 Then StrSql = StrSql & " AND "
				StrSql = StrSql & " disc_estanteria Like '" & Me.txtEstant.Text & "'"
			End If
			If Len(Me.txtAnyPubli.Text) > 0 Then
				If Len(StrSql) > 0 Then StrSql = StrSql & " AND "
				StrSql = StrSql & " disc_any Like '" & Me.txtAnyPubli.Text & "'"
			End If
			'format
			If ChkIgnoreFormat.Checked = False Then StrSql = StrSql & " disc_format = " & FormatFitxer
		End If

        Dim AddResult As Boolean = Me.chkAddResult.CheckState

        If Me.chkAddResult.Checked = True And LastQuery.Length > 3 Then
            StrSql = "(" & StrSql & ") OR (" & LastQuery & ")"
        End If
        LastQuery = StrSql

        SqlQuery = StrSql
        Me.txtNomDisc.Focus()

    End Sub
	
	Private Sub optCD_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optCD.CheckedChanged, optAltres.CheckedChanged, optK7.CheckedChanged, optMP3.CheckedChanged, optVinil.CheckedChanged
		FormatFitxer = CType(sender, RadioButton).Tag
	End Sub
	
	Private Sub KeyPress_Combo(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboInterp.KeyPress, ComboCia.KeyPress, ComboEstil.KeyPress, ComboProveidor.KeyPress
		e.KeyChar = UCase(e.KeyChar)
	End Sub
	
	Private Sub KeyUp_Combo(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles _
		ComboInterp.KeyUp, ComboCia.KeyUp, _
		ComboEstil.KeyUp, _
		ComboProveidor.KeyUp
		Select Case e.KeyCode
			Case Keys.Left, Keys.Right, Keys.Up, Keys.Down
				Return
		End Select
		Dim MyComboBox As ComboBox = CType(sender, ComboBox)
		Dim Origen As TAULES_DBS
		
		Select Case MyComboBox.Name
			Case "ComboInterp" : Origen = TAULES_DBS.TAULA_INTERPRETS
			Case "ComboCia" : Origen = TAULES_DBS.TAULA_DISCOGRAFIQUES
			Case "ComboEstil" : Origen = TAULES_DBS.TAULA_ESTILS
			Case "ComboProveidor" : Origen = TAULES_DBS.TAULA_PROVEIDORS
		End Select
		refreshComboBoxKeyUp(MyComboBox, Origen, TotsCap.TOTS)
		
	End Sub
	
	
	Private Sub txtAnyPubli_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAnyPubli.KeyPress
		Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
		If KeyAscii < Asc("0") Or KeyAscii > Asc("9") Then If KeyAscii <> 8 Then KeyAscii = 0
		e.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			e.Handled = True
		End If
	End Sub

    Private Sub cmdAddCodiBar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddCodiBar.Click
        PanelScanCodi.Show()
    End Sub

    Private Sub ButtonHide_Click(sender As Object, e As EventArgs) Handles ButtonHide.Click
        PanelScanCodi.Hide()
    End Sub

    Private Sub ButtonCodiBarres_Click(sender As Object, e As EventArgs)
        SqlQuery = ""
        Me.Close()
    End Sub

    Private Sub buttonSearchCode_Click(sender As Object, e As EventArgs) Handles buttonSearchCode.Click
        Dim StrSql As String = ""
        StrSql = " disc_codibar = '" & Me.txtCodiBarres.Text & "'"
        PanelScanCodi.Hide()
        SqlQuery = StrSql
    End Sub

    Private Sub buttonCancelSearch_Click(sender As Object, e As EventArgs) Handles buttonCancelSearch.Click
        PanelScanCodi.Hide()
    End Sub

    Private Sub txtCodiBarres_TextChanged(sender As Object, e As EventArgs) Handles txtCodiBarres.TextChanged
        picCodiBarres.Image = DrawCodiBarres(StandarsCodiBarres.code39, txtCodiBarres.Text)
    End Sub
End Class