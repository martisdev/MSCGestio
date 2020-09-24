Option Strict Off
Option Explicit On

Imports Freedb

Public Class frmCDDBMultipleResult
	Dim m_SelectedQueryResult As QueryResult
	Dim m_results As QueryResultCollection
	
	Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
		Me.DialogResult = system.Windows.Forms.DialogResult.Cancel
	End Sub
	
	Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click
		OptionOK()
	End Sub
	
	Private Sub OptionOK()
		m_SelectedQueryResult = m_results(lstMltCDDB.SelectedIndex)
		Me.DialogResult = system.Windows.Forms.DialogResult.OK
	End Sub
	
	Public Property SelectedQueryResult() As QueryResult
		Get
			Return m_SelectedQueryResult
		End Get
		Set(ByVal m_SelectedQueryResult As QueryResult)
		End Set
	End Property
	
	Public Sub CDDBMultipleResult(ByVal results As QueryResultCollection)
		m_results = results
		For Each qr As QueryResult In m_results
			lstMltCDDB.Items.Add(qr.Title & " - " & qr.Artist & " - " & qr.Category)
		Next
	End Sub
	
	Private Sub lstMltCDDB_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstMltCDDB.DoubleClick
		OptionOK()
	End Sub
	
	Private Sub frmCDDBMultipleResult_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		Me.Dispose()
	End Sub

    Sub FrmCDDBMultipleResultLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        setLanguageForm()
    End Sub

    Public Sub setLanguageForm()
		lang.StrForm = Me.Name
		
		Me.Label1.Text = lang.getText("Label1.Text") '"S'han trobat múltiples entrades. Selecciona'n una ..."
		Me.cmdOK.Text = MSG_OK
		Me.cmdCancel.Text = lang.getText("CANCELAR",True)' "Cancelar"
		Me.Text =  lang.getText("LABEL_CDDB",True) '"CDDB"		
		
	End Sub
End Class