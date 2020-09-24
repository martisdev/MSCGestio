Option Strict Off
Option Explicit On

Public Class frmEquival
	
	'Dim EquivalInterp As New msc_dbs.ClasEquivalInterp
	
	Private Sub CloseForm()
		MyAPP.CloseSesionClient(MyAPP.IDSesion_Client, DESCRIP_FORM_EQUIVAL)
		Me.Dispose()
	End Sub
	
	Private Sub frmEquival_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		CloseForm()
	End Sub
	
	Private Sub CmdBloqueix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdBloqueix.Click
		Static blEnable As Boolean
		blEnable = Not blEnable
		Me.chkForceRecipro.Enabled = blEnable
		Me.ComboEquival.Enabled = blEnable
		Me.ComboInterp.Enabled = blEnable
		Me.cmdAddEquival.Enabled = blEnable
		Me.cmdDelEquival.Enabled = blEnable
		If blEnable Then
			Me.CmdBloqueix.Image = Me.picUnLock.Image
		Else
			Me.CmdBloqueix.Image = Me.picLock.Image
		End If
		
	End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click, cmdSortir.Click
        Me.Close()
    End Sub

    Private Sub frmEquival_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		setLanguageForm()

        Dim db As New MSC.dbs(Cloud)
        Dim StrSql As String = "SELECT `equivalencies`.`equiv_id`, `interprets`.`interp_nom` as nomInterp, `interprets_1`.`interp_nom` as nomEquivalInterp"
		StrSql = StrSql & " FROM `equivalencies`, `interprets`, `interprets` AS `interprets_1`"
		StrSql = StrSql & " WHERE `equivalencies`.`equiv_valor` = `interprets`.`interp_id`"
		StrSql = StrSql & "AND `equivalencies`.`equiv_contravalor` = `interprets_1`.`interp_id`"
		Dim rsEquival As DataTable = db.getTable(StrSql)
		
		For I As Integer = 0 To rsEquival.Rows.Count - 1
			Dim ID As Short = rsEquival.Rows(I)("equiv_id")
			Dim interp As String = rsEquival.Rows(I)("nomInterp").ToString
			Dim interpEquival As String = rsEquival.Rows(I)("nomEquivalInterp").ToString
			Me.lbIDEquival.Text = rsEquival.Rows(I)(0).ToString
			addLineListEquival(ID, interp, interpEquival)
		Next I
		db = Nothing
	End Sub
	
	Public Sub setLanguageForm()		
		lang.StrForm = Me.Name
	
		Me.GroupBox1.Text = lang.getText("GroupBox1.Text") '"Equivalències Intèrprets"
		Me.ColumnHeader1.Text = lang.getText("HEADERTEXT_INTERP",True) '"Intèrpret"
		Me.ColumnHeader2.Text = lang.getText("ColumnHeader2.Text") '"Equivalència"
		Me.cmdAddEquival.Text = lang.getText("cmdAddEquival.Text") '"Afegir equivalència"
		Me.cmdDelEquival.Text = lang.getText("cmdDelEquival.Text") '"Borrar equivalència"
		Me.Label1.Text = lang.getText("Label1.Text") & " ..." '"Aquest intèrpret equival a..."
		Me.chkForceRecipro.Text = lang.getText("chkForceRecipro.Text") '"Forçar reciprocitat"
		Me.Text = lang.getText("Text") '"Equivalències entre intèrprets"

        Dim Cmb As New combo
        Cmb.OmpleCombo(ComboInterp, TAULES_DBS.TAULA_INTERPRETS, TotsCap.CAP)
        Cmb.OmpleCombo(ComboEquival, TAULES_DBS.TAULA_INTERPRETS, TotsCap.CAP)
        Me.CmdBloqueix.Enabled = IIf(Usuari.UsrTipus > mdlMscDefines.NivellUsers.USR_CONVIDAT, True, False)
    End Sub	
	
	Private Sub addLineListEquival(ByVal id As Short, ByVal Interp As String, ByVal EquivalInterp As String)
		Dim NewItem As System.Windows.Forms.ListViewItem
		NewItem = Me.lstInterpEquival.Items.Add(Interp)
		NewItem.Tag = CStr(id)
		If NewItem.SubItems.Count > 1 Then
			NewItem.SubItems(1).Text = EquivalInterp
		Else
			NewItem.SubItems.Insert(1, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, EquivalInterp))
		End If
	End Sub
	
	Private Sub KeyPress_CombosEquival(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboEquival.KeyPress, ComboInterp.KeyPress
		e.KeyChar = UCase(e.KeyChar)
	End Sub
	
	
	Private Sub cmdDelEquival_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelEquival.Click
        If Not MyAPP.PermisPerContinuar() Then MetroFramework.MetroMessageBox.Show(Me, MSG_SERVER_CLOSE, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Stop, 100) : Me.Close()
        Try
			Dim id As Short = Me.lstInterpEquival.FocusedItem.Tag
            Dim db As New MSC.dbs(Cloud)
            Dim StrSql As String = "DELETE FROM equivalencies WHERE equiv_id=" & id.ToString
            db.Delete_ID(StrSql)
            addCtlRadi(0, CShort(Tipus_Play.CTL_SQL), 0, "00:00:00", 0, 0, Usuari.UsrID, StrSql, 0, False)
            db = Nothing
			Me.lstInterpEquival.Items.RemoveAt((Me.lstInterpEquival.FocusedItem.Index))
		Catch
			lstInterpEquival.Focus()
			Return
		End Try
	End Sub
	
	Private Sub cmdAddEquival_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddEquival.Click
		Dim valorID As Short
		Dim ContraValorID As Short
		Dim id As Integer
        If Not MyAPP.PermisPerContinuar() Then MetroFramework.MetroMessageBox.Show(Me, MSG_SERVER_CLOSE, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Stop, 100) : Me.Close()
        'id = CDbl(Me.lbIDEquival.Text) + 1
        valorID = ComboInterp.SelectedValue
		ContraValorID = ComboEquival.SelectedValue
        Dim db As New MSC.dbs(Cloud)
        Dim SqlStr As String = "INSERT FROM equivalencies (equiv_valor,equiv_contravalor) VALUES (" & valorID & "," & ContraValorID & ")"
		id = db.New_ID(SqlStr)
		addLineListEquival(id, (Me.ComboInterp.Text), (Me.ComboEquival.Text))
		If Me.chkForceRecipro.CheckState = CheckState.Checked Then
			SqlStr = "INSERT FROM equivalencies (equiv_valor,equiv_contravalor) VALUES (" & ContraValorID & "," & valorID & ")"
			id = db.New_ID(SqlStr)
			addLineListEquival(id, (Me.ComboEquival.Text), (Me.ComboInterp.Text))
		End If
		db = Nothing
	End Sub
	
	Private Sub ComboEquival_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboEquival.KeyUp, ComboInterp.KeyUp
		Select Case e.KeyCode
			Case Keys.Left, Keys.Right, Keys.Up, Keys.Down
				Return
		End Select
		Dim MyComboBox As ComboBox = CType(sender, ComboBox)
		Dim Origen As TAULES_DBS = TAULES_DBS.TAULA_INTERPRETS
		refreshComboBoxKeyUp(MyComboBox, Origen, TotsCap.CAP)
		
	End Sub
End Class