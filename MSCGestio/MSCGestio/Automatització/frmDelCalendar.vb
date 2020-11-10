Imports System.Threading.Tasks
Public Class frmDelCalendar

    Private Sub cmdDelTot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelTot.Click

        If MetroFramework.MetroMessageBox.Show(Me, MSG_DELETE_ALL, MSG_ATENCIO, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, 100) = DialogResult.OK Then
            Dim db As New MSC.dbs(Cloud)
            Dim SqlStr As String = ""
            SqlStr = "DELETE FROM listpautes WHERE listpauta_sessio<>0 ;"
            db.Delete_ID(SqlStr)
            SqlStr = "TRUNCATE calendari ;"
            Dim RowsAfect As Integer = db.Delete_ID(SqlStr)
            addCtlRadi(0, CShort(Tipus_Play.CTL_SQL), 0, "00:00:00", 0, 0, Usuari.UsrID, SqlStr, 0, False)
            db = Nothing
            frmCalendari.BuscaItemsCalendari()
            MetroFramework.MetroMessageBox.Show(Me, MSG_ALL_ITEM_DEL, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Information, 100)
        End If
    End Sub


    Private Sub UpdateProgress(value As Integer)
        ProgressSpinnerCaducats.Value = value
    End Sub

    Private Async Function DeleteCalendar(SqlCondi As String, progress As IProgress(Of Integer)) As Task(Of Integer)
        Dim db As New MSC.dbs(Cloud)
        'Esborrem les pautes depenents
        Dim dtPautesBorrar As DataTable = db.getTable("SELECT cal_pauta FROM calendari " & SqlCondi & " ;")
        If IsNothing(dtPautesBorrar) = False AndAlso dtPautesBorrar.Rows.Count > 0 Then
            ProgressSpinnerCaducats.Maximum = dtPautesBorrar.Rows.Count
            For i As Integer = 0 To dtPautesBorrar.Rows.Count - 1
                Dim pauta_id As Integer = CInt(dtPautesBorrar.Rows(i)("cal_pauta"))
                If pauta_id > 1 Then db.Delete_ID("DELETE FROM listpautes WHERE `listpauta_id`=" & pauta_id & " ;")
                UpdateProgress(i)
                Me.Refresh()
            Next i

        End If
        Dim StrSql As String = "DELETE FROM calendari " & SqlCondi & " ;"
        Dim RowsAfect As Integer = db.Delete_ID(StrSql)
        addCtlRadi(0, CShort(Tipus_Play.CTL_SQL), 0, "00:00:00", 0, 0, Usuari.UsrID, StrSql, 0, False)
        db = Nothing
        Return RowsAfect
    End Function

    Private Async Sub cmdDelCaduc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelCaduc.Click
        If MetroFramework.MetroMessageBox.Show(Me, MSG_DELETE_CADUC, MSG_ATENCIO, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, 100) = DialogResult.OK Then
            cmdDelCaduc.Enabled = False
            ProgressSpinnerCaducats.Visible = True
            Dim progressIndicator As New Progress(Of Integer)(AddressOf UpdateProgress)
            Dim SqlCondi As String = "WHERE cal_data < '" & Now.AddHours(-1).ToString("yyyy-MM-dd HH:mm:ss") & "'"
            Dim RowsAfect As Integer = Await DeleteCalendar(SqlCondi, progressIndicator)

            ProgressSpinnerCaducats.Visible = False
            MetroFramework.MetroMessageBox.Show(Me, String.Format(MSG_DELETED_ROWS_AFECTED, RowsAfect), MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Information, 100)
            cmdDelCaduc.Enabled = True

            frmCalendari.BuscaItemsCalendari()
        End If

        '-----------------------------------
        'If MetroFramework.MetroMessageBox.Show(Me, MSG_DELETE_CADUC, MSG_ATENCIO, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, 100) = DialogResult.OK Then
        '    ProgressSpinnerCaducats.Visible = True
        '    Dim SqlCondi As String = "WHERE cal_data < '" & Now.AddHours(-1).ToString("yyyy-MM-dd HH:mm:ss") & "'"
        '    Dim db As New MSC.dbs(Cloud)
        '    'Esborrem les pautes depenents
        '    Dim dtPautesBorrar As DataTable = db.getTable("SELECT cal_pauta FROM calendari " & SqlCondi & " ;")
        '    If IsNothing(dtPautesBorrar) = False AndAlso dtPautesBorrar.Rows.Count > 0 Then
        '        ProgressSpinnerCaducats.Maximum = dtPautesBorrar.Rows.Count
        '        For i As Integer = 0 To dtPautesBorrar.Rows.Count - 1
        '            Dim pauta_id As Integer = CInt(dtPautesBorrar.Rows(i)("cal_pauta"))
        '            If pauta_id > 1 Then db.Delete_ID("DELETE FROM listpautes WHERE `listpauta_id`=" & pauta_id & " ;")
        '            ProgressSpinnerCaducats.Value = i
        '            Me.Refresh()
        '        Next i

        '    End If
        '    Dim StrSql As String = "DELETE FROM calendari " & SqlCondi & " ;"
        '    Dim RowsAfect As Integer = db.Delete_ID(StrSql)
        '    addCtlRadi(0, CShort(Tipus_Play.CTL_SQL), 0, "00:00:00", 0, 0, Usuari.UsrID, StrSql, 0, False)
        '    db = Nothing
        '    frmCalendari.BuscaItemsCalendari()
        '    ProgressSpinnerCaducats.Visible = False
        '    MetroFramework.MetroMessageBox.Show(Me, String.Format(MSG_DELETED_ROWS_AFECTED, RowsAfect), MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Information, 100)
        'End If
    End Sub

    Private Sub cmdDelDiaHora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelDiaHora.Click
        'Primer buscar el dia seleccionat
        Dim Dia As Short = 0
        For d As Short = 0 To 6
            If CType(Me.GrupDies.Controls(d), RadioButton).Checked Then
                Dia = CShort(CType(Me.GrupDies.Controls(d), RadioButton).Tag)
                Exit For
            End If
        Next d
        'Segon busquem la hora
        Dim Hora As Short = 0
        For H As Short = 0 To 23
            If CType(Me.GrupHores.Controls(H), RadioButton).Checked Then
                Hora = CShort(CType(Me.GrupHores.Controls(H), RadioButton).Text)
                Exit For
            End If
        Next H
        Dim db As New MSC.dbs(Cloud)
        Dim StrCondi As String = ""
        Dim DataIn As Date = Me.txtDataIn.Value
        Dim RowsAfect As Integer = 0
        Do
            If Weekday(DataIn, FirstDayOfWeek.Monday) = Dia Then
                StrCondi = "WHERE Date(cal_data)='" & DataIn.ToString("yyyy-MM-dd") & "' AND Hour(cal_data)=" & Hora & " AND cal_tipassig=0;"
                'Esborrem les pautes depenents
                Dim dtPautesBorrar As DataTable = db.getTable("SELECT cal_pauta FROM calendari " & StrCondi & "' ;")
                If IsNothing(dtPautesBorrar) = False Then
                    For i As Integer = 0 To dtPautesBorrar.Rows.Count - 1
                        Dim pauta_id As Integer = CInt(dtPautesBorrar.Rows(i)("cal_pauta"))
                        If pauta_id > 1 Then db.Delete_ID("DELETE FROM listpautes WHERE `listpauta_id`=" & pauta_id & " ;") ' la 1 no es pot borrar mai
                    Next i
                End If

                RowsAfect = RowsAfect + db.Delete_ID("DELETE FROM calendari " & StrCondi & " ;")
            End If
            DataIn = DataIn.AddDays(1)
            If DataIn > Me.txtDataOut.Value Then Exit Do
        Loop
        addCtlRadi(0, CShort(Tipus_Play.CTL_SQL), 0, "00:00:00", 0, 0, Usuari.UsrID, "DELETE FROM calendari Dia Hora", 0, False)
        db = Nothing
        frmCalendari.BuscaItemsCalendari()

        MetroFramework.MetroMessageBox.Show(Me, String.Format(MSG_DELETED_ROWS_AFECTED, RowsAfect), MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Information, 100)

    End Sub

    Private Sub txtDataIn_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.txtDataOut.MinDate = Me.txtDataIn.Value
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click, cmdSortir.Click
        'frmCalendari.BuscaHoresCalendar(frmCalendari.MonthCalendar1.SelectionStart)
        Me.Close()
    End Sub

    Sub CmdDelEntreDates_Click(sender As Object, e As EventArgs) Handles cmdDelEntreDates.Click

        If MetroFramework.MetroMessageBox.Show(Me, MSG_DELETE_DATES, MSG_ATENCIO, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, 100) = DialogResult.OK Then
            Dim DataIn As Date = New Date(Me.txtDelEntreDataIn.Value.Year, txtDelEntreDataIn.Value.Month, txtDelEntreDataIn.Value.Day, 0, 0, 0)
            Dim dataOut As Date = New Date(Me.txtDelEntreDataOut.Value.Year, txtDelEntreDataOut.Value.Month, txtDelEntreDataOut.Value.Day, 23, 59, 59) 'Me.txtDataOut_data.Value

            Dim SqlStr As String = "DELETE FROM calendari WHERE Date(cal_data) BETWEEN '" & DataIn.ToString("yyyy-MM-dd HH:mm:ss") & "' AND '" & dataOut.ToString("yyyy-MM-dd HH:mm:ss") & "' ;"

            Dim db As New MSC.dbs(Cloud)
            Dim dtPautesBorrar As DataTable = db.getTable("SELECT cal_pauta FROM calendari WHERE Date(cal_data) BETWEEN '" & DataIn.ToString("yyyy-MM-dd HH:mm:ss") & "' AND '" & dataOut.ToString("yyyy-MM-dd HH:mm:ss") & "' ;")
            If IsNothing(dtPautesBorrar) = False Then
                For i As Integer = 0 To dtPautesBorrar.Rows.Count - 1
                    Dim pauta_id As Integer = CInt(dtPautesBorrar.Rows(i)("cal_pauta"))
                    If pauta_id > 1 Then db.Delete_ID("DELETE FROM listpautes WHERE `listpauta_id`=" & pauta_id & " ;")
                Next i
            End If

            Dim RowsAfect As Integer = db.Delete_ID(SqlStr)
            addCtlRadi(0, CShort(Tipus_Play.CTL_SQL), 0, "00:00:00", 0, 0, Usuari.UsrID, SqlStr, 0, False)
            db = Nothing
            frmCalendari.BuscaItemsCalendari()
            MetroFramework.MetroMessageBox.Show(Me, String.Format(MSG_DELETED_ROWS_AFECTED, RowsAfect), MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Information, 100)
        End If
    End Sub


    Dim MSG_ALL_ITEM_DEL As String
    Dim MSG_DELETED_ROWS_AFECTED As String
    Dim MSG_DELETE_ALL As String
    Dim MSG_DELETE_CADUC As String
    Dim MSG_DELETE_DATE As String
    Dim MSG_DELETE_DATES As String

    Public Sub setLanguageForm()
        Lang.StrForm = Me.Name

        MSG_ALL_ITEM_DEL = Lang.getText("MSG_ALL_ITEM_DEL") '"Tots els ítems borrats"
        MSG_DELETED_ROWS_AFECTED = Lang.getText("MSG_DELETED_ROWS_AFECTED", True) '"Operació realitzada, s'ha borrat {0} registres."
        MSG_DELETE_ALL = Lang.getText("MSG_DELETE_ALL") '"Estas segur que vols borrar tot el calendari?"
        MSG_DELETE_CADUC = Lang.getText("MSG_DELETE_CADUC") '"Segur que vols borrar els ítem caducats del calendari?"
        MSG_DELETE_DATE = Lang.getText("MSG_DELETE_DATE") '"Estas segur que vols borrar els registres assignats a una data?"
        MSG_DELETE_DATES = Lang.getText("MSG_DELETE_DATES", True) '"Estas segur que vols borrar els registres entre les dates?"

        Me.MetroTabPage1.Text = Lang.getText("LABEL_TOT", True) '"Tot"
        Me.MetroTabPage2.Text = Lang.getText("LABEL_CADUCAT", True) '"Caducat"		
        Me.MetroTabPage3.Text = Lang.getText("TabPage3.Text") '"Dia-Hora"
        Me.MetroTabPage5.Text = Lang.getText("LABEL_PER_DATA", True) '"Per una Data"
        MetroTabPage6.Text = Lang.getText("LABEL_PROGRAMA", True) '"Programa"



        Me.cmdDelTot.Text = Lang.getText("LABEL_DELETE", True) '"Borrar"
        Me.cmdDelCaduc.Text = Lang.getText("LABEL_DELETE", True) '"Borrar"		
        Me.cmdDelDiaHora.Text = Lang.getText("LABEL_DELETE", True) '"Borrar"        
        Me.cmdDelEntreDates.Text = Lang.getText("LABEL_DELETE", True) '"Borrar"
        cmdDelPrograma.Text = Lang.getText("LABEL_DELETE", True) '"Borrar"



        Me.GrupHores.Text = Lang.getText("GrupHores.Text") '"Hores dia"
        Me.GrupDies.Text = Lang.getText("GrupDies.Text") '"Dies Setmana"


        'Dim nomDies() As String =   My.Application.Culture.DateTimeFormat.DayNames		
        Me.RadioButton7.Text = Lang.getText("NAME_DIUMENGE", True) '"Diumenge"
        Me.RadioButton6.Text = Lang.getText("NAME_DISSABTE", True) '"Dissabte"
        Me.RadioButton5.Text = Lang.getText("NAME_DIVENDRES", True) '"Divendres"
        Me.RadioButton4.Text = Lang.getText("NAME_DIJOUS", True) '"Dijous"
        Me.RadioButton3.Text = Lang.getText("NAME_DIMECRES", True) '"Dimecres"
        Me.RadioButton2.Text = Lang.getText("NAME_DIMARTS", True)  '"Dimarts"
        Me.RadioButton1.Text = Lang.getText("NAME_DILLUNS", True) ''"Dilluns"

        Me.label9.Text = Lang.getText("LABEL_DATA_INICI", True) '"Data Inici"
        Me.label8.Text = Lang.getText("LABEL_DATA_FI", True) '"Data Fí"

        Me.label12.Text = Lang.getText("LABEL_DATA_INICI", True) '"Data Inici"
        Me.label11.Text = Lang.getText("LABEL_DATA_FI", True) '"Data Fí"

        Me.Label3.Text = Lang.getText("LABEL_DATA_INICI", True) '"Data Inici"
        Me.Label4.Text = Lang.getText("LABEL_DATA_FI", True) '"Data Fí"

        Me.Label1.Text = Lang.getText("Label1.Text") '"Eliminació de tots els registres del calendari"
        Me.Label2.Text = Lang.getText("Label2.Text") '"Eliminació dels registres del calendari caducats"
        Me.label10.Text = Lang.getText("label10.Text") '"Eliminació de tots els registres del calendari programats entre les dates"
        label13.Text = Lang.getText("label13.Text") '"Eliminació de tots els registres del calendari programats entre les dates assignats al programa"

        Me.Text = Lang.getText("LABEL_DEL_MASSIVE", True) '"Eliminació Massiva"

        Dim Cmb As New combo
        Cmb.OmpleCombo(Me.ComboBoxProgrames, TAULES_DBS.TAULA_PROGRAMES, TotsCap.CAP) : ComboBoxProgrames.SelectedValue = 0
        Cmb = Nothing

    End Sub


    Sub FrmDelCalendarLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        setLanguageForm()


    End Sub

    Sub CmdDelProgramaClick(sender As Object, e As EventArgs) Handles cmdDelPrograma.Click
        Dim prg_id As Integer = CInt(Me.ComboBoxProgrames.SelectedValue)
        If prg_id = 0 Then Exit Sub

        If MetroFramework.MetroMessageBox.Show(Me, MSG_DELETE_DATES, MSG_ATENCIO, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, 100) = DialogResult.OK Then
            Dim DataIn As Date = New Date(Me.txtDelProgramaIn.Value.Year, txtDelProgramaIn.Value.Month, txtDelProgramaIn.Value.Day, 0, 0, 0)
            Dim dataOut As Date = New Date(Me.txtDelProgramaOut.Value.Year, txtDelProgramaOut.Value.Month, txtDelProgramaOut.Value.Day, 23, 59, 59) 'Me.txtDataOut_data.Value

            Dim SqlStr As String = "DELETE FROM calendari WHERE Date(cal_data) BETWEEN '" & DataIn.ToString("yyyy-MM-dd HH:mm:ss") & "' AND '" & dataOut.ToString("yyyy-MM-dd HH:mm:ss") & "' AND cal_prog=" & prg_id & " ;"

            Dim db As New MSC.dbs(Cloud)
            Dim dtPautesBorrar As DataTable = db.getTable("SELECT cal_pauta FROM calendari WHERE Date(cal_data) BETWEEN '" & DataIn.ToString("yyyy-MM-dd HH:mm:ss") & "' AND '" & dataOut.ToString("yyyy-MM-dd HH:mm:ss") & "' AND cal_prog=" & prg_id & ";")
            If IsNothing(dtPautesBorrar) = False Then
                For i As Integer = 0 To dtPautesBorrar.Rows.Count - 1
                    Dim pauta_id As Integer = CInt(dtPautesBorrar.Rows(i)("cal_pauta"))
                    If pauta_id > 1 Then db.Delete_ID("DELETE FROM listpautes WHERE `listpauta_id`=" & pauta_id & " ;")
                Next i
            End If

            Dim RowsAfect As Integer = db.Delete_ID(SqlStr)
            addCtlRadi(0, CShort(Tipus_Play.CTL_SQL), 0, "00:00:00", 0, 0, Usuari.UsrID, SqlStr, 0, False)
            db = Nothing
            frmCalendari.BuscaItemsCalendari()
            MetroFramework.MetroMessageBox.Show(Me, String.Format(MSG_DELETED_ROWS_AFECTED, RowsAfect), MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Information, 100)
        End If
    End Sub
End Class