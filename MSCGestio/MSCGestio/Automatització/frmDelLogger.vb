'
' Creado por SharpDevelop.
' Usuario: Marti
' Fecha: 19/01/2017
' Hora: 09:13
' 
' Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
'
Public Partial Class frmDelLogger
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub

    Sub CmdExitClick(sender As Object, e As EventArgs) Handles cmdExit.Click, cmdSortir.Click
        Me.Close()
    End Sub

    Dim MSG_DELETED_ROWS_AFECTED As String
    Dim MSG_DELETE_DATES As String
    Dim MSG_DEL_PROGRAMACIO_CADUC As String
    Dim MSG_DEL_PROGRAMACIO As String


    Public Sub setLanguageForm()
        lang.StrForm = Me.Name

        MSG_DELETED_ROWS_AFECTED = lang.getText("MSG_DELETED_ROWS_AFECTED", True) '"Operació realitzada, s'ha borrat {0} registres."		
        MSG_DELETE_DATES = lang.getText("MSG_DELETE_DATES", True) '"Estas segur que vols borrar els registres entre les dates?"
        MSG_DEL_PROGRAMACIO_CADUC = lang.getText("MSG_DEL_PROGRAMACIO_CADUC") '"Segur que vols borrar la programació caducada?"
        MSG_DEL_PROGRAMACIO = lang.getText("MSG_DEL_PROGRAMACIO") '"Segur que vols borrar tota la programació?"


        Me.label8.Text = lang.getText("LABEL_DATA_FI", True) '"Data Fí"
        Me.label11.Text = label8.Text '"Data Fí"

        Me.label9.Text = lang.getText("LABEL_DATA_INICI", True) '"Data Inici"
        Me.label12.Text = label9.Text '"Data Inici"


        Me.cmdDelEntreDates.Text = lang.getText("LABEL_DELETE", True) '"Borrar"
        Me.cmdDelPrograma.Text = lang.getText("LABEL_DELETE", True) '"Borrar"
        Me.cmdDelTot.Text = lang.getText("LABEL_DELETE", True) '"Borrar"
        Me.cmdDelCaduc.Text = lang.getText("LABEL_DELETE", True) '"Borrar"

        Me.MetroTabPage1.Text = lang.getText("LABEL_TOT", True) '"Tot"
        Me.MetroTabPage2.Text = lang.getText("LABEL_CADUCAT", True) '"Caducat"
        Me.MetroTabPage3.Text = lang.getText("LABEL_ENTRE DATES", True) '"Entre Dates"
        Me.MetroTabPage4.Text = lang.getText("LABEL_PROGRAMA", True) '"Programa"

        Me.label10.Text = lang.getText("label10.Text") '"Eliminació de tots els registres del logger programats entre les dates"
        Me.label13.Text = lang.getText("label13.Text") '"Eliminació de tots els registres del logger programats entre les dates assignats al programa"		
        Me.Label1.Text = lang.getText("Label1.Text") '"Eliminació de tots els registres del logger"
        Me.Label2.Text = lang.getText("Label2.Text") '"Eliminació dels registres del logger caducats"

        Me.Text = lang.getText("LABEL_DEL_MASSIVE", True) '"Eliminació Massiva "

        Dim Cmb As New combo
        Cmb.OmpleCombo(Me.ComboBoxProgrames, TAULES_DBS.TAULA_PROGRAMES, TotsCap.CAP) : ComboBoxProgrames.SelectedValue = 0
        Cmb = Nothing
    End Sub

    Sub FrmDelLoggerLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        setLanguageForm()

    End Sub

    Sub CmdDelTotClick(sender As Object, e As EventArgs) Handles cmdDelTot.Click
        If MetroFramework.MetroMessageBox.Show(Me, MSG_DEL_PROGRAMACIO, MSG_ATENCIO, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, 100) = DialogResult.OK Then
            Dim StrSql As String

            StrSql = "DELETE FROM prglogger WHERE log_id <> 1 ;"
            Dim db As New MSC.dbs(Cloud)
            Dim RowsAfect As Integer = db.Delete_ID(StrSql)
            addCtlRadi(0, CShort(Tipus_Play.CTL_SQL), 0, "00:00:00", 0, 0, Usuari.UsrID, StrSql, 0, False)
            db = Nothing
            frmPrgLogger.BuscaItemsCalendari()
            MetroFramework.MetroMessageBox.Show(Me, String.Format(MSG_ROWS_AFFECTED, RowsAfect), MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Information, 100)
        End If
    End Sub

    Sub CmdDelCaducClick(sender As Object, e As EventArgs) Handles cmdDelCaduc.Click
        If MetroFramework.MetroMessageBox.Show(Me, MSG_DEL_PROGRAMACIO_CADUC, MSG_ATENCIO, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, 100) = DialogResult.Cancel Then Exit Sub
        Dim StrSql As String

        StrSql = "DELETE FROM prglogger WHERE log_datereg < '" & Now.ToString("yyyy-MM-dd") & "' AND log_id<>1 ;"
        Dim db As New MSC.dbs(Cloud)
        Dim NumAfect As Integer = db.ExecuteInstruc(StrSql)
        db = Nothing
        frmPrgLogger.BuscaItemsCalendari()
        MetroFramework.MetroMessageBox.Show(Me, String.Format(MSG_ROWS_AFFECTED, NumAfect), My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Information, 100)
    End Sub

    Sub CmdDelEntreDatesClick(sender As Object, e As EventArgs) Handles cmdDelEntreDates.Click
        If MetroFramework.MetroMessageBox.Show(Me, MSG_DELETE_DATES, MSG_ATENCIO, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, 100) = DialogResult.OK Then
            Dim DataIn As Date = New Date(Me.txtDelEntreDataIn.Value.Year, txtDelEntreDataIn.Value.Month, txtDelEntreDataIn.Value.Day, 0, 0, 0)
            Dim dataOut As Date = New Date(Me.txtDelEntreDataOut.Value.Year, txtDelEntreDataOut.Value.Month, txtDelEntreDataOut.Value.Day, 23, 59, 59) 'Me.txtDataOut_data.Value

            Dim SqlStr As String = "DELETE FROM prglogger WHERE Date(log_datereg) BETWEEN '" & DataIn.ToString("yyyy-MM-dd HH:mm:ss") & "' AND '" & dataOut.ToString("yyyy-MM-dd HH:mm:ss") & "' AND log_id<>1 ;"
            addCtlRadi(0, CShort(Tipus_Play.CTL_SQL), 0, "00:00:00", 0, 0, Usuari.UsrID, SqlStr, 0, False)
            Dim db As New MSC.dbs(Cloud)

            Dim RowsAfect As Integer = db.Delete_ID(SqlStr)
            db = Nothing
            frmPrgLogger.BuscaItemsCalendari()
            MetroFramework.MetroMessageBox.Show(Me, String.Format(MSG_DELETED_ROWS_AFECTED, RowsAfect), MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Information, 100)
        End If
    End Sub

    Sub CmdDelProgramaClick(sender As Object, e As EventArgs) Handles cmdDelPrograma.Click
        Dim prg_id As Integer = Me.ComboBoxProgrames.SelectedValue
        If prg_id = 0 Then Exit Sub
        If MetroFramework.MetroMessageBox.Show(Me, MSG_DELETE_DATES, MSG_ATENCIO, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, 100) = DialogResult.OK Then
            Dim DataIn As Date = New Date(Me.txtDelProgramaIn.Value.Year, txtDelProgramaIn.Value.Month, txtDelProgramaIn.Value.Day, 0, 0, 0)
            Dim dataOut As Date = New Date(Me.txtDelProgramaOut.Value.Year, txtDelProgramaOut.Value.Month, txtDelProgramaOut.Value.Day, 23, 59, 59) 'Me.txtDataOut_data.Value

            Dim SqlStr As String = "DELETE FROM prglogger WHERE Date(log_datereg) BETWEEN '" & DataIn.ToString("yyyy-MM-dd HH:mm:ss") & "' AND '" & dataOut.ToString("yyyy-MM-dd HH:mm:ss") & "' AND log_program=" & prg_id & " AND log_id<>1 ;"
            Dim db As New MSC.dbs(Cloud)
            Dim RowsAfect As Integer = db.Delete_ID(SqlStr)
            addCtlRadi(0, CShort(Tipus_Play.CTL_SQL), 0, "00:00:00", 0, 0, Usuari.UsrID, SqlStr, 0, False)
            db = Nothing
            frmPrgLogger.BuscaItemsCalendari()
            MetroFramework.MetroMessageBox.Show(Me, String.Format(MSG_DELETED_ROWS_AFECTED, RowsAfect), MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Information, 100)
        End If
    End Sub
End Class
