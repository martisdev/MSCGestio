Option Strict Off
Option Explicit On

Imports VB = Microsoft.VisualBasic
Public Class frmBKPDBS

    Private Sub CloseForm()
        MyAPP.CloseSesionClient(MyAPP.IDSesion_Client, DESCRIP_FORM_BKP_DBS)
        Me.Dispose()
    End Sub

    Private Sub frmBKPDBS_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim Cancel As Boolean = e.Cancel
        Dim UnloadMode As System.Windows.Forms.CloseReason = e.CloseReason
        Select Case UnloadMode
            Case CloseReason.UserClosing
                If Me.cmdSortir.Enabled = False Then
                    WindowState = System.Windows.Forms.FormWindowState.Minimized
                    Cancel = True
                Else
                    CloseForm()
                End If
            Case System.Windows.Forms.CloseReason.TaskManagerClosing
                MetroFramework.MetroMessageBox.Show(Me, MSG_NO_STOP_APP, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
                Cancel = True
                WindowState = System.Windows.Forms.FormWindowState.Minimized
            Case System.Windows.Forms.CloseReason.WindowsShutDown
                CloseForm()
            Case Else                
                Cancel = True
                WindowState = System.Windows.Forms.FormWindowState.Minimized
        End Select
        e.Cancel = Cancel

    End Sub

    Private Sub tmrAtencio_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrAtencio.Tick
        If Me.lbAtencio.ForeColor = Color.Blue Then
            lbAtencio.ForeColor = Color.Red
        Else
            lbAtencio.ForeColor = Color.Blue
        End If
    End Sub

    Private Sub cmdDesti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDesti.ButtonClick
        If folderBrowserDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Me.txtDesti.Text = folderBrowserDialog1.SelectedPath
        End If
        Me.cmdBKP.Enabled = IIf(Len(txtDesti.Text) > 0, True, False)
    End Sub


    Private Sub cmdBKP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBKP.Click

        If Len(txtDesti.Text) = 0 Then MetroFramework.MetroMessageBox.Show(Me, MSG_NEED_DESTI, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100) : Exit Sub
        Dim NomFitxerBKP As String = ""
        Me.cmdBKP.Enabled = False
        Me.cmdSortir.Enabled = False
        AmbTasquesPendents = True

        If MetroFramework.MetroMessageBox.Show(Me, MSG_SURE_INI_BKP, MSG_ATENCIO, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, 100) = DialogResult.OK Then
            Dim db As New MSC.dbs(Cloud)
            Dim sCmd As String = ""
            If Me.chkDelCtlRadia.Checked = True Then
                sCmd = "DELETE FROM controlradiacio WHERE ctl_dataradiacio < '" & Date.Today.AddDays(-14).ToString("yyyy-MM-dd") & "' ;"
                db.Delete_ID(sCmd)
            End If
            If Me.chkDelConnex.Checked = True Then
                sCmd = "DELETE FROM connexions WHERE connex_actv=0;"
                db.Delete_ID(sCmd)
            End If
            addCtlRadi(0, CShort(Tipus_Play.CTL_SQL), 0, "00:00:00", 0, 0, Usuari.UsrID, sCmd, 0, False)
            NomFitxerBKP = "MSC_" & Now.ToString("yyyyMMdd HHmm") & ".sql"
            Dim PathToExport As String = txtDesti.Text & "\" & NomFitxerBKP

            Dim tables As New List(Of String)
            If Me.chk_excludeTables.Checked = True Then
                tables.Add("connexions")
                tables.Add("erroruser")
                tables.Add("controlradiacio")
                db.ExportBackup(PathToExport, tables, Me.chk_excludeTables.Checked)
            Else
                db.ExportBackup(PathToExport)
            End If


            db = Nothing
            progressBKP.Value = 0
            lbBkpInfoProcess.Text = ""
            MetroFramework.MetroMessageBox.Show(Me, MSG_END_BKP, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information, 100)
        End If
        Me.cmdBKP.Enabled = True
        Me.cmdSortir.Enabled = True
        AmbTasquesPendents = False

    End Sub


    Private Sub InfoBkpProcess(ByVal newStatus As String)
        Try
            Dim msg() As String = Split(newStatus, ",")

            If IsNumeric(msg(0)) Then progressBKP.Maximum = CInt(msg(0))
            If IsNumeric(msg(1)) Then progressBKP.Value = CInt(msg(1))
            lbBkpInfoProcess.Text = String.Format(MSG_UPDATE_DATA, msg(3))

            My.Application.DoEvents()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub cmdRestore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRestore.Click
        Me.cmdRestore.Enabled = False
        Me.cmdSortir.Enabled = False
        AmbTasquesPendents = True

        If MetroFramework.MetroMessageBox.Show(Me, MSG_SURE_RESTORE, MSG_ATENCIO, MessageBoxButtons.YesNo, MessageBoxIcon.Question, 100) = DialogResult.Yes Then
            Dim PathFromRestore As String = Me.txtOrigen.Text
            If IO.File.Exists(PathFromRestore) Then
                Dim bkp As New Backup
                AddHandler bkp.StatusChanged, AddressOf InfoBkpProcess
                bkp.ImportDataBase(PathFromRestore)
                Application.DoEvents()

                progressBKP.Value = 0
                lbBkpInfoProcess.Text = ""
                If Cloud.IsActive Then
                    Dim frmSincro As New frmUpdateCloud(True)
                    frmSincro.ShowDialog()
                End If
                IniDataSet()
                MetroFramework.MetroMessageBox.Show(Me, MSG_END_RESTORE, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Information, 100)
                Me.txtOrigen.Text = ""
                Me.cmdRestore.Enabled = False
            End If
        End If
        Me.cmdRestore.Enabled = True
        Me.cmdSortir.Enabled = True
        AmbTasquesPendents = False
    End Sub

    Private Sub cmdOrigen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOrigen.ButtonClick
        Me.cmdRestore.Enabled = False
        Me.openFileDialog1.Filter = LABEL_FITXER & " SQL (*.sql) |*.sql"
        openFileDialog1.Multiselect = False
        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Me.txtOrigen.Text = openFileDialog1.FileName
        End If
        Me.cmdRestore.Enabled = CBool(Len(txtOrigen.Text) >= 3)
    End Sub

    Private Sub cmdSortir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSortir.Click
        Me.Close()
    End Sub

    Sub FrmBKPDBSLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        setLanguageForm()
    End Sub



    Dim MSG_NEED_DESTI As String = "És necessari un destí"
	Dim MSG_SURE_INI_BKP As String = "Segur que vols iniciar la còpia de seguretat?"
	Dim MSG_END_BKP As String = "Final de la còpia de seguretat"
	Dim MSG_SURE_RESTORE As String = "Segur que vols restaurar la còpia de seguretat?"
    Dim MSG_END_RESTORE As String = "Final de la restauració"
    Dim LABEL_FITXER As String

    Friend Sub setLanguageForm()
    	lang.StrForm = Me.Name
    	
    	MSG_NEED_DESTI = lang.getText("MSG_NEED_DESTI") '"És necessari un destí"
    	MSG_SURE_INI_BKP = lang.getText("MSG_SURE_INI_BKP") '"Segur que vols iniciar la còpia de seguretat?"
    	MSG_END_BKP = lang.getText("MSG_END_BKP") '"Final de la còpia de seguretat"
    	MSG_SURE_RESTORE = lang.getText("MSG_SURE_RESTORE") 
		MSG_END_RESTORE = lang.getText("MSG_END_RESTORE")
        LABEL_FITXER = lang.getText("LABEL_FITXER", True)
        Me.TabPage1.Text = lang.getText("TabPage1.Text") '"Salvar Dades"
        Me.groupBox2.Text = lang.getText("LABEL_OPCIONS",True) '"Opcions"
    	Me.chkZip.Text = lang.getText("chkZip.Text") '"Comprimir en ZIP"
    	Me.chkEncrip.Text = lang.getText("chkEncrip.Text") '"Encriptar"
    	Me.groupBox3.Text = lang.getText("groupBox3.Text") '"Tasques prèvies"
    	Me.chkDelConnex.Text = lang.getText("chkDelConnex.Text") '"Borrar l'historial de connexions"
        Me.chkDelCtlRadia.Text = lang.getText("chkDelCtlRadia.Text") '"Borrar l'historial de radiació més antic de dues setmanes"
        chk_excludeTables.Text = lang.getText("chk_excludeTables.Text") '"Exclude tables log (connections, radiation control, error users connections)"
        Me.Label1.Text = lang.getText("LABEL_DIR_DESTI", True) & ":" '"Directori destí:"
        Me.TabPage2.Text = lang.getText("TabPage2.Text") '"Restaurar Dades"

        Me.Label2.Text = lang.getText("Label2.Text") & " :" '"Fitxer a restaurar :"
    	Me.lbAtencio.Text = lang.getText("lbAtencio.Text") '"Fer qualsevol operació en aquesta pantalla pot suposar un perill per tot el sistema MSC."
    	FolderBrowserDialog1.Description = lang.getText("FolderBrowserDialog1.Description") '"Selecciona un directori"
    	openFileDialog1.Title  = lang.getText("MSG_SELECT_DIR",True) '"Selecciona un directori"
    	Me.Text = lang.getText("Text") '"Còpies de seguretat de la base de dades"
    	
	End Sub

    Private Sub linkWebHelp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

        Dim Proces As Process = New Process
        Try
            Process.Start(MSC.Help.HELP_GEST_AUTOMATITZACIO_BACKUP_DBS.ToString)
        Catch ex As Exception
        End Try
    End Sub
End Class