Option Strict Off
Option Explicit On

Public Class frmCtlRadia
	
	Dim InfoMsg As frmTip
	
	Private Sub CloseForm()
		
		If StreamHandlePlay <> 0 Then stopFitxer()
		MyAPP.CloseSesionClient(MyAPP.IDSesion_Client, DESCRIP_FORM_CTL_RADIA)
		Me.Dispose()
		
	End Sub
	
	Private Sub frmCtlRadia_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		CloseForm()
	End Sub
	
	Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click, cmdSortir.Click
		Me.Close()
	End Sub
	
	Private Sub frmCtlRadia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' paràmetres generals                		

        setLanguageForm()
		
		Me.cmdBorrar.Enabled = IIf(Usuari.UsrTipus > NivellUsers.USR_USUARI, True, False)        
		
		'----------
		Me.txtDataInBar.Value = DateSerial(Now.Year, Now.Month, Now.Day - 7)
		Me.txtDataOut.Value = Date.Now
		Me.txtDataOut.MaxDate = DateSerial(Now.Year, Now.Month, Now.Day + 1)
		Me.txtDataDel.MaxDate = DateSerial(Now.Year, Now.Month, Now.Day - 7)
		Me.txtDataDel.Value = DateSerial(Now.Year, Now.Month, Now.Day - 30)
        '-----------


        Me.DataGridViewHistorial.Columns("ColumnEdit").Visible = CBool(ProgEditAudio.Length > 0)
        Me.ClientSize = New Size(frm_sice(0), frm_sice(1))

    End Sub
	
	Dim MSG_CONFIMA_BORRAR_HISTORIAL As String 
	Dim MSG_DADES_BORRADES As String
	Dim LABEL_CTL_RADIACIO As String
	Dim MSG_WRITE_TITOL As String 
	Dim MSG_ONE_OPTION_ACTIVE As String 
	
	Public Sub setLanguageForm()
		lang.StrForm = Me.Name
		
		MSG_CONFIMA_BORRAR_HISTORIAL = lang.getText("MSG_CONFIMA_BORRAR_HISTORIAL") '"Segur que vols borrar l'històrial de radiació fins la data: {0} ? (no fer-ho si hi han informes de radiació pendents)."
		MSG_DADES_BORRADES = lang.getText("MSG_DADES_BORRADES") '"Dades Borrades"
		LABEL_CTL_RADIACIO = lang.getText("LABEL_CONTROL_RADIACIO",True) '"Control de radiació"
		MSG_WRITE_TITOL = lang.getText("MSG_ESCRIU_TITOL",True) '"Escriu un títol pel llistat"
		MSG_ONE_OPTION_ACTIVE = lang.getText("MSG_ONE_OPTION_ACTIVE") '"Almenys una opció ha d'estar activada"
		
		Me.Label10.Text = lang.getText("Label10.Text") & ":" '"Nº Altres:"
		Me.Label9.Text = lang.getText("Label9.Text") & ":"'"Nº de Programes:"
		Me.Label8.Text = lang.getText("Label8.Text") & ":"'"Nº de Cançons:"
		Me.Label2.Text = lang.getText("Label2.Text") & ":"'"Nº de Falques Publi.:"
		Me.Label1.Text = lang.getText("Label1.Text") & ":"'"Nº de registres:"
		Me.ColumnImage.HeaderText = lang.getText("LABEL_TIPUS",True) '"Tipus"
		Me.ColumnTFitxer.HeaderText = lang.getText("LABEL_T_FITXER",True) '"T. Fitxer"
		Me.ColumnID.HeaderText = lang.getText("ColumnID.HeaderText") '"ID Fitxer"
		Me.Column4.HeaderText = lang.getText("LABEL_NOM",True) '"Nom"
		Me.ColumnDataRadi.HeaderText = lang.getText("LABEL_DATA_RADIACIO",True) '"Data Radiació"

        Me.ColumnUser.HeaderText = lang.getText("LABEL_USER",True) '"Usuari"
		Me.ColumnPauta.HeaderText = lang.getText("HEADERTEXT_PAUTA",True) '"Pauta"
		Me.ColumnPlay.HeaderText = lang.getText("LABEL_PLAY",True) '"Play"
		Me.ColumnEdit.HeaderText = lang.getText("LABEL_EDITAR",True) '"Editar"
		Me.cmdSortir.Text = lang.getText("LABEL_EXIT",True) '"Sortir"
		Me.cmdPlay.Text = lang.getText("LABEL_PLAY_PAUSA",True) '"Play/Pausa"
		Me.cmdStop.Text = lang.getText("LABEL_STOP",True) '"Stop"
		Me.ToolStripLabel1.Text = lang.getText("LABEL_DATA_INICI",True) '"Data Inici"
		Me.cmdBuscar.Text = lang.getText("LABEL_BUSCAR",True) '"Buscar"
		Me.mnuBuscaOpcions.Text = lang.getText("LABEL_OPCIONS",True) & " ..." '"Opcions ..."
		Me.mnuEstadistica.Text = lang.getText("LABEL_ESTADISTICA",True) '"Estadística"
		
		Me.cmdPrint.Text = lang.getText("LABEL_IMPRIMIR_LLISTAT",True) '"Imprimir llistat"
		Me.ToolStripLabel4.Text = lang.getText("ToolStripLabel4.Text") '"Borrar anteriors a"
		Me.cmdBorrar.ToolTipText = lang.getText("LABEL_DEL_HISTORIAL",True) '"Borrar historial"
		Me.GroupBox1.Text = mnuEstadistica.Text '"Estadística"
		Me.Label11.Text = lang.getText("Label11.Text") & " ..."'"Llistar de ..."
		Me.Label12.Text = lang.getText("Label12.Text") & " ..."'"fins a ..."
		Me.GroupBoxArxius.Text = lang.getText("GroupBoxArxius.Text") & " ..."'"filtrar ..."
		Me.chkProgram.Text = lang.getText("NAME_PROGRAMES",True) '"Programes"
		Me.chkPubli.Text = lang.getText("HEADERTEXT_PUBLICITAT",True) '"Publicitat"
		Me.chkMusic.Text = lang.getText("FITXER_MUSICA",True) '"Música"
		chkSistema.Text = lang.getText("chkSistema.Text") '"Sistema"
		chkControl.Text = lang.getText("chkControl.Text") '"Control"
		Me.GroupBox2.Text = lang.getText("LABEL_COLUMN_VISIBLES",True) '"Columnes Visibles"
		Me.chk_Col_7.Text = lang.getText("LABEL_USER",True) '"Usuari"
		Me.chk_Col_6.Text = lang.getText("chk_Col_6.Text") '"Rec. Count"
		Me.Column9.HeaderText = chk_Col_6.Text  '"Rec. Count"
		Me.chk_Col_5.Text = lang.getText("chk_Col_5.Text") '"Tmp Max"
		Me.Column8.HeaderText = chk_Col_5.Text '"Tmp Max"
		Me.chk_Col_4.Text = lang.getText("chk_Col_4.Text") '"N. Error"
		Me.Column7.HeaderText = chk_Col_4.Text '"N. Error"
		Me.chk_Col_3.Text = lang.getText("chk_Col_3.Text") '"N. Bloc"
		Me.Column6.HeaderText = chk_Col_3.Text '"N. Bloc"
		Me.chk_Col_0.Text = lang.getText("LABEL_TIPUS",True) '"Típus"
        Me.ChkTots.Text = lang.getText("ChkTots.Text") '"Mostrar tots els arxius"
        chkFilesUser.Text = lang.getText("FITXER_AUDIO", True) '"Fitxers Usuari"

        Me.Text = lang.getText("LABEL_CTL_RADIACIO") '"Control de radiació"		

        Dim Cmb As New combo
        Cmb.OmpleCombo(Me.ColumnUser, TAULES_DBS.TAULA_USUARIS, TotsCap.CAP)
        Cmb.OmpleCombo(Me.ColumnPauta, TAULES_DBS.TAULA_PAUTES, TotsCap.CAP)

        Me.Refresh()
    End Sub
	
	Private Sub cmdConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsulta.Click, cmdBuscar.Click
		
		Dim StrSql As String = ""
		Dim WHERE As String
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		'   Construcció de la sentència SQL --------
		If ChkTots.Checked = False Then
            If Me.chkFilesUser.CheckState Then StrSql = "ctl_tipfitxer > 600 " '& mdlMscDefines.Tipus_Play.CTL_AUDIO_USR
            If Me.chkMusic.Checked Then
				If Len(StrSql) > 0 Then StrSql = StrSql & " Or "
				StrSql = StrSql & "ctl_tipfitxer = " & mdlMscDefines.Tipus_Play.CTL_MUSICA
			End If
            If Me.chkProgram.Checked Then
                If Len(StrSql) > 0 Then StrSql = StrSql & " Or "
                StrSql = StrSql & "ctl_tipfitxer = " & mdlMscDefines.Tipus_Play.CTL_PROGRAMA
            End If
            If Me.chkPubli.Checked Then
				If Len(StrSql) > 0 Then StrSql = StrSql & " Or "
				StrSql = StrSql & "ctl_tipfitxer = " & mdlMscDefines.Tipus_Play.CTL_PUBLICITAT
			End If
			If Me.chkSistema.Checked Then
				If Len(StrSql) > 0 Then StrSql = StrSql & " Or "
				StrSql = StrSql & "ctl_tipfitxer = " & mdlMscDefines.Tipus_Play.CTL_SISTEMA
			End If
			If Me.chkControl.Checked Then
				If Len(StrSql) > 0 Then StrSql = StrSql & " Or "
                StrSql = StrSql & "ctl_tipfitxer = " & mdlMscDefines.Tipus_Play.CTL_INFO_CONTROL
                StrSql = StrSql & " OR ctl_tipfitxer = " & mdlMscDefines.Tipus_Play.CTL_SQL
                StrSql = StrSql & " OR ctl_tipfitxer = " & mdlMscDefines.Tipus_Play.CTL_META_MARK
            End If
		End If
		WHERE = "((controlradiacio.ctl_dataradiacio) Between '" & Me.txtDataIn.Value.ToString("yyyy-MM-dd 00:00:00") & "' And '" & txtDataOut.Value.ToString("yyyy-MM-dd 23:59:59") & "')"
		If Len(StrSql) > 0 Then
			StrSql = "(" & StrSql & ") And (" & WHERE & ")"
		Else
			StrSql = WHERE
		End If
        Dim db As New MSC.dbs(Cloud)
        StrSql = "SELECT ctl_id,ctl_tipfitxer,ctl_fitxer,ctl_fitxerstr,ctl_dataradiacio,ctl_numbloc,ctl_nivellerr,ctl_maxtemps,ctl_reccount,ctl_usr,ctl_pauta FROM controlradiacio WHERE " & StrSql & " ORDER BY ctl_dataradiacio "
		
		DataGridViewHistorial.DataSource = db.getTable(StrSql)
		
		db = Nothing
        Dim NAudioFiles As Short
        Dim NMusic As Short
		Dim NPubli As Short

        Dim NFx As Short
		Dim NPrg As Short

        Me.lbMusic.Text = CStr(0)
		Me.lbPubli.Text = CStr(0)
        Me.lbAudioFiles.Text = CStr(0)
        Me.lbAltres.Text = CStr(0)
		Me.lbPrg.Text = CStr(0)
		
		Me.lbRecCound.Text = DataGridViewHistorial.Rows.Count
		For i As Integer = 0 To DataGridViewHistorial.Rows.Count - 1
            Dim TipFitxer As Integer = DataGridViewHistorial.Rows(i).Cells("ColumnTFitxer").Value
            Dim MyImage As Image
            Select Case TipFitxer
                Case Tipus_Play.CTL_SISTEMA : NFx += 1 : MyImage = New Bitmap(ImageList.Images(0))
                Case Tipus_Play.CTL_MUSICA : NMusic += 1 : MyImage = New Bitmap(imgListMnu.Images(4))
                Case Tipus_Play.CTL_PUBLICITAT : NPubli += 1 : MyImage = New Bitmap(imgListMnu.Images(7))
                Case Tipus_Play.CTL_PROGRAMA : NPrg += 1 : MyImage = New Bitmap(imgListMnu.Images(5))
                Case Tipus_Play.CTL_ESPERA : MyImage = New Bitmap(ImageList.Images(10))
                Case Tipus_Play.CTL_INFO_CONTROL : MyImage = New Bitmap(ImageList.Images(10))
                Case Tipus_Play.CTL_META_STOP : MyImage = New Bitmap(ImageList.Images(11))
                Case Tipus_Play.CTL_URL_STREAM : MyImage = New Bitmap(ImageList.Images(12))
                Case Tipus_Play.CTL_SQL : MyImage = New Bitmap(ImageList.Images(13))
                Case Tipus_Play.CTL_META_MARK : MyImage = New Bitmap(ImageList.Images(14))
                Case > 600 'Tipus_Play.CTL_AUDIO_USR
                    NAudioFiles += 1
                    Dim lstAU_id As Integer = TipFitxer - 600
                    MyImage = New Bitmap(imgListMnu.Images(getLogoAudioUser(lstAU_id)))
                Case Else : MyImage = New Bitmap(ImageList.Images(10))
            End Select
            DataGridViewHistorial.Rows(i).Cells("ColumnImage").Value = New Bitmap(MyImage)
            DataGridViewHistorial.Rows(i).Cells("ColumnPlay").Value = "Play"
            DataGridViewHistorial.Rows(i).Cells("ColumnEdit").Value = "Edit"
        Next i

        If CDbl(lbRecCound.Text) > 0 Then
            Me.lbMusic.Text = NMusic & "  (" & Microsoft.VisualBasic.Format(NMusic / CDbl(lbRecCound.Text), "0.00%") & ")"
            Me.lbPubli.Text = NPubli & "  (" & Microsoft.VisualBasic.Format(NPubli / CDbl(lbRecCound.Text), "0.00%") & ")"
            Me.lbAltres.Text = NFx & "  (" & Microsoft.VisualBasic.Format(NFx / CDbl(lbRecCound.Text), "0.00%") & ")"
            Me.lbPrg.Text = NPrg & "  (" & Microsoft.VisualBasic.Format(NPrg / CDbl(lbRecCound.Text), "0.00%") & ")"
            Me.lbAudioFiles.Text = NAudioFiles & "  (" & Microsoft.VisualBasic.Format(NPrg / CDbl(lbRecCound.Text), "0.00%") & ")"
        End If
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
		Me.cmdPrint.Enabled = (DataGridViewHistorial.Rows.Count > 0)
	End Sub
	
	Private Sub cmdDelCtl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.AppStarting
        Dim DataMax As Date = Me.txtDataDel.Value

        If MetroFramework.MetroMessageBox.Show(Me, String.Format(MSG_CONFIMA_BORRAR_HISTORIAL, Microsoft.VisualBasic.Format(DataMax, "long date")), MSG_ATENCIO, MessageBoxButtons.YesNo, MessageBoxIcon.Question, 120) = MsgBoxResult.No Then Exit Sub

        Dim sCmd As String = "DELETE FROM controlradiacio WHERE ctl_dataradiacio < '" & DataMax.ToString("yyyy-MM-dd") & "' ;"
        Dim db As New MSC.dbs(Cloud)
        db.Delete_ID(sCmd)
        addCtlRadi(0, CShort(Tipus_Play.CTL_SQL), 0, "00:00:00", 0, 0, Usuari.UsrID, sCmd, 0, False)
        db = Nothing
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        MetroFramework.MetroMessageBox.Show(Me, MSG_DADES_BORRADES, My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Information, 100)

    End Sub

    Private Sub DataGridViewHistorial_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs)
        '???
    End Sub

    Private Sub lstHistorial_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            Dim Tipus As Tipus_Play, id As Integer
            Dim Caracters As String
            Dim strText As String
            On Error Resume Next

            Tipus = Me.DataGridViewHistorial.CurrentRow.Cells("ColumnTFitxer").Value '  lstHistorial.FocusedItem.SubItems.Item(1).Tag
            id = Me.DataGridViewHistorial.CurrentRow.Cells("ColumnID").Value
            strText = strInfoFitxer(Tipus, id)
            InfoMsg = New frmTip
            InfoMsg.ShowMessage(strText, MSG_MORE_INFO, IconStyles.Information, ContentAlignment.MiddleCenter, , , True, , , , , Themes.WinXpStyle, MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub lstHistorial_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            InfoMsg.Close()
        End If
    End Sub

    Private Sub ButtonPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click

        Dim frmPRT As New frmPrint
        Dim StrTitol As String = InputBox(MSG_WRITE_TITOL, MSG_ATENCIO, LABEL_CTL_RADIACIO)
        If Len(StrTitol) < 2 Then StrTitol = LABEL_CTL_RADIACIO
        frmPRT.DefineLlistat(DataGridViewHistorial, frmPrint.Tipusllistats.LLISTAT_Temes, StrTitol)

        Try
            frmPRT.Show(Me)
        Catch ex As Exception
            frmPRT.WindowState = FormWindowState.Normal
        End Try

    End Sub

    Private Sub chk_Col_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Col_0.CheckedChanged, chk_Col_3.CheckedChanged, chk_Col_4.CheckedChanged, chk_Col_5.CheckedChanged, chk_Col_6.CheckedChanged, chk_Col_7.CheckedChanged
        Try
            Dim ColId As Integer = CType(sender, CheckBox).Tag
            DataGridViewHistorial.Columns(ColId).Visible = CType(sender, CheckBox).Checked
            DataGridViewHistorial.Columns("Column1").Visible = False
        Catch ex As Exception
        End Try
    End Sub

    Private Sub chkTipFitxer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMusic.CheckedChanged, chkProgram.CheckedChanged, chkPubli.CheckedChanged, chkSistema.CheckedChanged, chkControl.CheckedChanged
        If chkMusic.Checked = False AndAlso chkFilesUser.Checked = False AndAlso chkProgram.Checked = False AndAlso chkPubli.Checked = False AndAlso Me.chkControl.Checked = False AndAlso Me.chkSistema.Checked = False Then
            MetroFramework.MetroMessageBox.Show(Me, MSG_ONE_OPTION_ACTIVE, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, 100)
            CType(sender, CheckBox).Checked = True
        End If
    End Sub

    Private Sub ChkTots_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkTots.CheckedChanged
        GroupBoxArxius.Enabled = Not ChkTots.Checked
    End Sub

    Private Sub txtDataInBar_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDataInBar.ValueChanged
        Me.txtDataIn.Value = txtDataInBar.Value
        'txtDataOut.Value = Now.AddDays(1)
    End Sub

    Private Sub mnuBuscaOpcions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBuscaOpcions.Click
        mnuBuscaOpcions.Checked = Not mnuBuscaOpcions.Checked
        Me.SplitContainer1.Panel1Collapsed = Not mnuBuscaOpcions.Checked
    End Sub

    Private Sub mnuEstadistica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEstadistica.Click
        mnuEstadistica.Checked = Not mnuEstadistica.Checked
        SplitContainer2.Panel2Collapsed = Not mnuEstadistica.Checked
    End Sub

    Private Sub SetPositionAndPlay(DateToPlay As Date)
        Dim DirMagatzem As String = Params.PathSaveLogger
        Dim NomFitxer As String = DateToPlay.ToString("yyyy-MM-dd")
        Dim ListFitxer As String = DirMagatzem & "\" & NomFitxer & "*.mp3"
        Dim Fitxer As String = Dir(ListFitxer)
        Dim cont As Short
        Dim HoraRec As String

        Do While Len(Fitxer)
            HoraRec = Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(Fitxer, 17), 6)
            Dim Hora As Short = CShort(HoraRec.Chars(0) & HoraRec.Chars(1))
            Dim minuts As Short = CShort(HoraRec.Chars(2) & HoraRec.Chars(3))
            Dim segons As Short = CShort(HoraRec.Chars(4) & HoraRec.Chars(5))
            Dim strPathFitxer As String = DirMagatzem & "\" & Fitxer
            If Hora = DateToPlay.Hour Then
                'Mateixa hora però s'ha d'ajustar el minut
                If StreamHandlePlay <> 0 Then Bass.BASS_StreamFree(StreamHandlePlay)
                StreamHandlePlay = Bass.BASS_StreamCreateFile(strPathFitxer, 0, 0, 0)
                Dim difMinut As Single = -(((minuts - DateToPlay.Minute) * 60) - DateToPlay.Second)
                'Sha de saber la durada 
                Dim Length As Long = Bass.BASS_ChannelGetLength(StreamHandlePlay)
                Dim SeconsLength As Single = Bass.BASS_ChannelBytes2Seconds(StreamHandlePlay, Length)

                If difMinut < SeconsLength Then
                    Bass.BASS_ChannelPlay(StreamHandlePlay, False)
                    Bass.BASS_ChannelSetPosition(StreamHandlePlay, CSng(difMinut))
                    tmrPlayer.Enabled = True
                    Exit Sub
                Else
                    'És el següent fitxer (ens hem pasat de minut de reproducció)
                End If
            End If

            cont = cont + 1
            Fitxer = Dir()
        Loop
        tmrPlayer.Enabled = False
    End Sub

    Private Sub DataGridViewHistorial_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewHistorial.CellContentClick
        If Me.DataGridViewHistorial.Columns(e.ColumnIndex).Name = "ColumnPlay" Then
            'Buscar en els fitxers del logger
            Dim DataBuscar As Date = DataGridViewHistorial.Rows(e.RowIndex).Cells("ColumnDataRadi").Value
            SetPositionAndPlay(DataBuscar)
        ElseIf Me.DataGridViewHistorial.Columns(e.ColumnIndex).Name = "ColumnEdit" Then
            Bass.BASS_ChannelStop(StreamHandlePlay)
            Bass.BASS_StreamFree(StreamHandlePlay)
            If ProgEditAudio.Length > 0 Then
                Dim PathFitxer As String = ""
                Dim DataBuscar As Date = DataGridViewHistorial.Rows(e.RowIndex).Cells("ColumnDataRadi").Value
                Dim DirMagatzem As String = Params.PathSaveLogger
                Dim NomFitxer As String = DataBuscar.ToString("yyyy-MM-dd")
                Dim ListFitxer As String = DirMagatzem & "\" & NomFitxer & "*.mp3"
                Dim Fitxer As String = Dir(ListFitxer)
                Dim cont As Short
                Dim HoraRec As String
                Do While Len(Fitxer)
                    HoraRec = Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(Fitxer, 17), 6)
                    Dim Hora As Short = CShort(HoraRec.Chars(0) & HoraRec.Chars(1))
                    Dim minuts As Short = CShort(HoraRec.Chars(2) & HoraRec.Chars(3))
                    Dim segons As Short = CShort(HoraRec.Chars(4) & HoraRec.Chars(5))
                    Dim strPathFitxer As String = DirMagatzem & "\" & Fitxer
                    If Hora = DataBuscar.Hour Then
                        'Mateixa hora però s'ha d'ajustar el minut
                        If StreamHandlePlay <> 0 Then Bass.BASS_StreamFree(StreamHandlePlay)
                        StreamHandlePlay = Bass.BASS_StreamCreateFile(strPathFitxer, 0, 0, 0)
                        Dim difMinut As Single = -(((minuts - DataBuscar.Minute) * 60) - DataBuscar.Second)
                        'Sha de saber la durada 
                        Dim Length As Long = Bass.BASS_ChannelGetLength(StreamHandlePlay)
                        Dim SeconsLength As Single = Bass.BASS_ChannelBytes2Seconds(StreamHandlePlay, Length)

                        If difMinut < SeconsLength Then
                            PathFitxer = Chr(34) & strPathFitxer & Chr(34)
                            Exit Do
                        Else
                            'És el següent fitxer (ens hem pasat de minut de reproducció)
                        End If
                    End If

                    cont = cont + 1
                    Fitxer = Dir()
                    System.Windows.Forms.Application.DoEvents()
                Loop

                If PathFitxer.Length < 3 Then Exit Sub
                Dim p As System.Diagnostics.Process = New System.Diagnostics.Process()
                p.StartInfo.Arguments = PathFitxer.Trim
                p.StartInfo.FileName = ProgEditAudio
                Try
                    p.Start()
                Catch ex As Exception
                End Try
            End If
        End If
    End Sub


    Dim VolMax As Single
	Dim Atack As Integer = 50
	Dim StreamHandlePlay As Integer
	Dim InSrolling As Boolean
	Dim isActive As Un4seen.Bass.BASSActive
	
	Private Sub PlayFitxer()
		isActive = Bass.BASS_ChannelIsActive(StreamHandlePlay)
        If isActive = BASSActive.BASS_ACTIVE_PLAYING Then
            Bass.BASS_ChannelPause(StreamHandlePlay)
        ElseIf isActive = BASSActive.BASS_ACTIVE_PAUSED Then
            Bass.BASS_ChannelPlay(StreamHandlePlay, False)
        Else
            Try
                Dim DataBuscar As Date = DataGridViewHistorial.SelectedRows(0).Cells("ColumnDataRadi").Value
                SetPositionAndPlay(DataBuscar)
            Catch ex As Exception
                Exit Sub
            End Try
        End If
    End Sub
	
	Private Sub PauseFitxer()
		If isActive = BASSActive.BASS_ACTIVE_PLAYING Then Bass.BASS_ChannelPause(StreamHandlePlay)
	End Sub
	
	Private Sub stopFitxer()
		Bass.BASS_ChannelStop(StreamHandlePlay)
		Bass.BASS_StreamFree(StreamHandlePlay)
	End Sub
	
	Private Sub tmrPlayer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPlayer.Tick
		Dim RealVol As Integer
		Dim LVol As Integer
		Dim RVol As Integer
		Dim vol As Integer = 0
		
		isActive = Bass.BASS_ChannelIsActive(StreamHandlePlay)
		Select Case isActive
			Case BASSActive.BASS_ACTIVE_STOPPED
				Me.cmdStop.Enabled = False
				cmdPlay.Image = Me.picPlay.Image
				'Me.mnuStop.Enabled = False
				tmrPlayer.Enabled = False
			Case BASSActive.BASS_ACTIVE_PAUSED
				cmdPlay.Image = Me.picPlay.Image
			Case BASSActive.BASS_ACTIVE_PLAYING
				Me.cmdStop.Enabled = True
				cmdPlay.Image = Me.picPause.Image
				'Me.mnuStop.Enabled = True
		End Select
		
		vol = Bass.BASS_ChannelGetLevel(StreamHandlePlay)
		If vol < 0 Then vol = 0
		LVol = Un4seen.Bass.Utils.HighWord(vol)
		RVol = Un4seen.Bass.Utils.LowWord(vol)
		RealVol = (LVol + RVol) / 2 'Volum màxim = 32768
		If VolMax < RealVol Then
			VolMax = RealVol
		Else
			' s'ha de trobar la fórmula logarítmica (valor màxim 32769 )
			If VolMax > 32000 Then
				VolMax = VolMax - (10 * Atack)
			ElseIf VolMax > 30000 Then
				VolMax = VolMax - (15 * Atack)
			ElseIf VolMax > 25000 Then
				VolMax = VolMax - (25 * Atack)
			ElseIf VolMax > 20000 Then
				VolMax = VolMax - (35 * Atack)
			ElseIf VolMax > 10000 Then
				VolMax = VolMax - (50 * Atack)
			Else
				VolMax = VolMax - (100 * Atack)
			End If
		End If
		If isActive = BASSActive.BASS_ACTIVE_STOPPED Or isActive = BASSActive.BASS_ACTIVE_PAUSED Then LVol = 4 : RVol = 4
		
		'---------------------------------------------
		Dim bit As Bitmap = New Bitmap(picVuMeter.Width, picVuMeter.Height)
		Dim graph As Graphics = Graphics.FromImage(bit)
		Dim LimePen As New Pen(Color.Lime, 5)
		Dim PeakPen As New Pen(Color.Red, 5)
		Dim PositionPen As New Pen(Color.Black, 1)
		Dim x As Integer
		graph.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
		
		' Pinta Volum dreta i esquerra
		x = (RVol / 32768) * picVuMeter.Width
		If x > picVuMeter.Width Then x = picVuMeter.Width
		graph.DrawLine(LimePen, picVuMeter.Width - x, 4, picVuMeter.Width, 4)
		
		x = (LVol / 32768) * picVuMeter.Width
		If x > picVuMeter.Width Then x = picVuMeter.Width
		graph.DrawLine(LimePen, picVuMeter.Width - x, 8 + 4, picVuMeter.Width, 8 + 4)
		
		'Pinta posició
		Dim pos As Long = Bass.BASS_ChannelGetPosition(StreamHandlePlay)
		Dim len As Long = Bass.BASS_ChannelGetLength(StreamHandlePlay)
		Dim bpp As Double = len / CType(Me.picVuMeter.Width, Double) ' bytes per pixel        
		' position (x) where to draw the line, Integer)
		x = CType(Math.Round(pos / bpp), Double)
		graph.DrawLine(PositionPen, x, 0, x, Me.picVuMeter.Height - 1)
		
		If VolMax > 0 Then
			'Pinta peak
			x = (VolMax / 32768) * picVuMeter.Width
			If x > picVuMeter.Width Then x = picVuMeter.Width
			graph.DrawLine(PeakPen, picVuMeter.Width - x, 4, picVuMeter.Width - x - 2, 4)
			graph.DrawLine(PeakPen, picVuMeter.Width - x, 8 + 4, picVuMeter.Width - x - 2, 8 + 4)
		End If
		
		'draw the visual onto the picturebox
		picVuMeter.Image = bit
		Try
			LimePen.Dispose()
			PeakPen.Dispose()
			graph.Dispose()
		Catch ex As Exception
		Finally
			LimePen = Nothing
			PeakPen = Nothing
			bit = Nothing
			graph = Nothing
		End Try
		
	End Sub
	
	Private Sub cmdPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPlay.Click
		PlayFitxer()
	End Sub
	
	Private Sub cmdStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStop.Click
		stopFitxer()
	End Sub
	
	Private Sub picVuMeter_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picVuMeter.MouseClick
		'estableix la posicio del ratolí a sobre el Pig
		Dim len As Long = Bass.BASS_ChannelGetLength(StreamHandlePlay)
		Dim bpp As Double = len / CType(Me.picVuMeter.Width, Double) ' bytes per pixel        
		'Quin és el pixel on es troba el ratolí
		Dim pr As Integer = 0
		Dim LocalMousePosition As Point = picVuMeter.PointToClient(system.Windows.Forms.Cursor.Position)
		'Posició on s'ha de desplaçar        
		Dim PosADespla As Single = Bass.BASS_ChannelBytes2Seconds(StreamHandlePlay, CLng(LocalMousePosition.X * bpp))
		'Desplaçar-ho
		Bass.BASS_ChannelSetPosition(StreamHandlePlay, PosADespla)
	End Sub

    Private Sub frmCtlRadia_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        Dim FitxerINI As New IniFile
        frm_sice(0) = Me.Width : frm_sice(1) = Me.Height
        FitxerINI.INIWrite(MyAPP.IniFile, "Data Gest", "size", frm_sice(0).ToString & "," & frm_sice(1).ToString)
    End Sub
End Class