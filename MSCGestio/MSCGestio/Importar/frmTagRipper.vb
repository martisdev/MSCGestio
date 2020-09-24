Public Class frmTagRipper
    Friend MyimportFrm As frmImport

    Public Sub LoadValorsTrack()
		On Error Resume Next
        'Me.lbNomTrack.Text = GetFileName(frmImport.lsvTrackList.FocusedItem.Tag.ToString , True)
        Me.lbNomTrack.Text = MyimportFrm.lsvTrackList.SelectedItems(0).Text
        Me.txtTitol.Text = MyimportFrm.lsvTrackList.SelectedItems(0).Text
        Me.txtInterpret.Text = MyimportFrm.lsvTrackList.SelectedItems(0).SubItems.Item(1).Text
        Me.txtAny.Text = MyimportFrm.lsvTrackList.SelectedItems(0).SubItems.Item(3).Text
        Me.lbID.Text = CStr(MyimportFrm.lsvTrackList.SelectedItems(0).Index)
        Me.cmdOK.Enabled = False
        Me.Show(MyimportFrm)
    End Sub
	
	Private Sub txtAny_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAny.KeyPress
		Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
		If KeyAscii < Asc("0") Or KeyAscii > Asc("9") Then If KeyAscii <> 8 Then KeyAscii = 0
		e.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			e.Handled = True
		End If
	End Sub
	
	Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click        
		Try
            MyimportFrm.lsvTrackList.Items.Item(CShort(lbID.Text)).Text = Trim(Me.txtTitol.Text)
            MyimportFrm.lsvTrackList.Items.Item(CShort(lbID.Text)).SubItems.Item(1).Text = Trim(Me.txtInterpret.Text)
            MyimportFrm.lsvTrackList.Items.Item(CShort(lbID.Text)).SubItems.Item(3).Text = Trim(Me.txtAny.Text)
            Me.cmdOK.Enabled = False
		Catch ex As Exception
		End Try
	End Sub
	
	Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
		Me.Close()
	End Sub
	
	Private Sub Click_mnuCapture(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTítolIntèrpret.Click, mnuCapturarIntèrpretTítol.Click, mnuCapturarTítolIntèrpret.Click
		Dim Index As Short = CShort(CType(sender, ToolStripMenuItem).Tag)
		Dim separador As String = Choose(mnuEditListComboBoxSeparadors.SelectedIndex+1, "-","_", "/","\").ToString 
		Dim StrInterp As String = ""
		Dim StrTitol As String = ""
		Dim ArrayValues(4) As String
		Select Case Index
			Case 0
				StrInterp = Me.txtTitol.Text
				StrTitol = Me.txtInterpret.Text
			Case 1
				ParseDelimStr(Me.lbNomTrack.Text, separador, ArrayValues)
				StrInterp = ArrayValues(1)
				StrTitol = ArrayValues(2)
			Case 2
				ParseDelimStr(Me.lbNomTrack.Text, separador, ArrayValues)
				StrTitol = ArrayValues(1)
				StrInterp = ArrayValues(2)
		End Select
		Try
			txtTitol.Text = StrTitol.Trim
			txtInterpret.Text = StrInterp.Trim
			Me.cmdOK.Enabled = True			
		Catch ex As Exception
			
		End Try
		
	End Sub
	
	Private Sub txtTitol_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTitol.TextChanged, txtAny.TextChanged, txtInterpret.TextChanged
		Me.cmdOK.Enabled = True
	End Sub
	
	Private Sub frmTagRipper_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Me.Dispose()
    End Sub
	
	Private Sub frmTagRipper_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
		setLanguageForm()
		If My.Settings.TXT_CAPITALIZE Then
			Me.txtTitol.CharacterCasing = CharacterCasing.Upper
			Me.txtInterpret.CharacterCasing = CharacterCasing.Upper
		End If
		mnuEditListComboBoxSeparadors.SelectedIndex = 0
	End Sub
	
	Public Sub setLanguageForm()
		lang.StrForm = Me.Name
		
		Me.mnuTítolIntèrpret.Text = lang.getText("LABEL_TITOL_INTERPRET",True) '"Títol<>Intèrpret"
		Me.mnuCapturarIntèrpretTítol.Text = lang.getText("LABEL_CAPTURA_INTERP_TITOL",True) '"Capturar: Intèrpret - Títol"
		Me.mnuCapturarTítolIntèrpret.Text = lang.getText("CAPTURA_TITOL_INTERP",True) '"Capturar: Títol - Intèrpret"
		Me.Label3.Text = lang.getText("HEADERTEXT_ANY",True) '"Any"
		Me.Label2.Text = lang.getText("HEADERTEXT_INTERP",True) '"Intèrpret"
		Me.Label1.Text = lang.getText("HEADERTEXT_TITOL",True) '"Títol"
		Me.cmdOK.Text = lang.getText("LABEL_SALVAR",True) '"Salvar"
		Me.cmdCancelar.Text = lang.getText("LABEL_EXIT",True) '"Sortir"
		Me.Text = lang.getText("Text") '"Modificar valors ..."
		
	End Sub
End Class