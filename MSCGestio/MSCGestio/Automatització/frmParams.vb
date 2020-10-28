Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Imports MySql.Data.MySqlClient
Imports System.Net.Mail
Imports System.Net

Public Class frmParams

    Private Enum Catparams
        PARAM_PARAMS
        PARAM_PATH
        PARAM_MONEDA
        PARAM_DIRECT
        PARAM_CATEGO
        PARAM_AUTOFADER
        PARAM_SEQUENCIES
        PARAM_CONTROLER
        PARAM_CONNEX_REMOT
        PARAM_CARTUT
        PARAM_FITXERS_USR
        PARAM_DBS
        PARAM_WEB
        PARAM_SOS
        PARAM_CR
        PARAM_CLIENTS
        PARAM_REPARAR
        PARAM_SISTEM_INFO
        PARAM_CREDITS
        PARAM_USUARIS
        PARAM_LOGGER
        PARAM_STREAM
        PARAM_CLOUD
        PARAM_CLOUD_PRG
    End Enum
    ' PARAM_AUTOFADER = Obsolete

    Private Structure ColecDBS
        Dim NomDBS As String
        Dim DescripDBS As String
        Dim HostDBS As String
        Dim PortDBS As String
        'Dim DNSDBS As String
        Dim UsrDBS As String
        Dim PswDBS As String
        'blModif As Boolean
        Dim blDelete As Boolean
    End Structure


    Dim DBS_Col() As ColecDBS
    Dim ChangeMltDBS As Boolean
    Dim blNewDBS As Boolean
    Dim blEnable As Boolean
    Dim Cancelled As Boolean
    'multiple servidor
    Dim MlpDBS As Boolean
    Dim INIFile As New IniFile

    Private Structure SequenciaPauta
        Dim Seq_ID As Integer
        Dim Seq_Nom As String
        Dim seq_Valors() As Integer
        Dim Seq_NEW As Boolean
    End Structure

    Dim SeqPau() As SequenciaPauta
    Dim SeqValorsChanged As Boolean = False

    Private Sub CloseForm()
        If Me.cmdSalvar.Enabled Then
            If MetroFramework.MetroMessageBox.Show(Me, MSG_SAVE_DADES, My.Application.Info.AssemblyName, MessageBoxButtons.YesNo, MessageBoxIcon.Information, 100) = DialogResult.Yes Then SaveRecord()
        End If
        MyAPP.CloseSesionClient(MyAPP.IDSesion_Client, DESCRIP_FORM_PARAMS)
        Me.Dispose()
    End Sub

    Private Sub frmParams_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        CloseForm()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSortir.Click, cmdExit.Click
        Me.Close()
    End Sub

    Private Sub LokedControls()
        blEnable = Not blEnable

        chkCaptureTag.Enabled = blEnable
        chkVDef_activats.Enabled = blEnable

        'Me.grupAudioUSR.Enabled = blEnable
        lbSaved.Visible = False
        GroupBoxCarpetes.Enabled = blEnable
        ButtonAddCarpeta.Enabled = blEnable
        FlowLayoutPanelCarpetes.Enabled = blEnable
        Me.gridAudioFiles.Enabled = blEnable
        gridAudioFiles.Enabled = blEnable
        cmdAddAudio.Enabled = blEnable
        cmdDelAudio.Enabled = blEnable

        'Me.grupCartut.Enabled = blEnable
        chkActvTabProgram.Enabled = blEnable
        chkCTL_USR_Cartux.Enabled = blEnable

        'Me.grupCategories.Enabled = blEnable
        txtHTop.Enabled = blEnable
        txtHHit.Enabled = blEnable
        txtHHitTop.Enabled = blEnable
        txtHOldTop.Enabled = blEnable
        txtOld.Enabled = blEnable
        chkCanviCat.Enabled = blEnable
        txtNTopHit.Enabled = blEnable
        txtNHitOld.Enabled = blEnable
        txtMaxRadiTop.Enabled = blEnable
        txtMaxRadiHIT.Enabled = blEnable
        txtMaxRadiOLD.Enabled = blEnable

        'Me.grupConnRemot.Enabled = blEnable
        sldVolfader.Enabled = blEnable
        sldMilFader.Enabled = blEnable

        'Me.grupControler.Enabled = blEnable
        txtSenyHora.Enabled = blEnable
        sldMilSegSH.Enabled = blEnable
        'Me.grupDBS.Enabled = blEnable
        chkMltDBS.Enabled = blEnable
        GroupBoxDetallDBS.Enabled = blEnable
        cmdAddDBS.Enabled = blEnable
        Me.txtPathINI.Enabled = blEnable

        'Me.grupDirecte.Enabled = blEnable
        sldMSegOClok.Enabled = blEnable
        txtIntervRitme.Enabled = blEnable
        txtHBorrInterp.Enabled = blEnable
        chkBorHistInterp.Enabled = blEnable
        chkForceHoraExect.Enabled = blEnable
        txtMinusProhivDisc.Enabled = blEnable

        'Me.grupMoneda.Enabled = blEnable
        cmbMoneda.Enabled = blEnable
        cmbContraValor.Enabled = blEnable
        txtCanvi.Enabled = blEnable
        ComboBoxVDef_tarifa.Enabled = blEnable
        txtVDEF_DateOut.Enabled = blEnable

        'Me.grupPath.Enabled = blEnable
        txtPathArrelAudio.Enabled = blEnable
        Me.txtAternativeDir.Enabled = blEnable

        'Me.grupEmissora.Enabled = blEnable
        txtNomRadio.Enabled = blEnable
        cmdAddLogo.Enabled = blEnable
        txtURLStreaming.Enabled = blEnable
        Me.txtWeb.Enabled = blEnable
        Me.txtFaceBook.Enabled = blEnable
        Me.txtTwitter.Enabled = blEnable
        Me.txtTwitterKey.Enabled = blEnable
        cmbLang.Enabled = blEnable
        Me.txtComentDesconnexio.Enabled = blEnable
        'Me.grupParams.Enabled = blEnable        
        cmdAddCarpBlocs.Enabled = blEnable
        grupCarpBlocs.Enabled = blEnable

        'Me.grupSequencies.Enabled = blEnable
        cmdAddSequenc.Enabled = blEnable
        cmdDelSequenc.Enabled = blEnable
        ComboBoxSequencies.Enabled = blEnable
        DataGridViewValorsSequ.Enabled = blEnable
        Button1.Enabled = blEnable
        Button2.Enabled = blEnable
        lbNovaSequ.Visible = False

        'Me.grupWeb.Enabled = blEnable	
        Me.GroupBox4.Enabled = (Cloud.ClientType = Cloud.client_type.RADIO_WITH_SERVICES And blEnable)
        txtServerFTP.Enabled = blEnable
        txtDirFTP.Enabled = blEnable
        txtUserFTP.Enabled = blEnable
        txtPswFTP.Enabled = blEnable
        cmdTestFTP.Enabled = blEnable
        ComboBoxSelectQualitatPodcast.Enabled = blEnable
        Me.txtPermanenciaPodcast.Enabled = blEnable
        Me.GroupBox3.Enabled = (Cloud.ClientType = Cloud.client_type.RADIO_WITH_SERVICES And blEnable)
        txtNumTracs.Enabled = blEnable
        txtNumVots.Enabled = blEnable

        'Me.grupSOS.Enabled = blEnable
        CheckBoxActiveSOS.Enabled = blEnable
        txtMailDesti.Enabled = blEnable
        Me.chk_SendDevelop.Enabled = blEnable
        cmdTestMailErr.Enabled = blEnable
        Me.txtPathLogErr.Enabled = blEnable
        buttonDelCtlLog.Enabled = blEnable

        'Me.grupCR.Enabled = blEnable
        txtRemitentCR.Enabled = blEnable
        txtServerMailCR.Enabled = blEnable
        txtUsuariCR.Enabled = blEnable
        txtPasswordCR.Enabled = blEnable
        txtIntervalCR.Enabled = blEnable
        txtCodiCR.Enabled = blEnable
        ComboBoxListAplic.Enabled = blEnable
        ComboBoxRemoteInstruc.Enabled = blEnable
        txtDescripCR.Enabled = blEnable
        ButtonAddInstrucioCR.Enabled = blEnable
        ButtonDelInstruccio.Enabled = blEnable

        'Me.GroupClients.Enabled = blEnable		
        txtClientKey.Enabled = blEnable
        cmdActive.Enabled = blEnable
        groupBoxCloudPrograms.Enabled = (Cloud.IsActive And blEnable)
        groupBoxCloudShareOptions.Enabled = Cloud.IsActive And blEnable
        groupBoxStreaming.Enabled = (Cloud.IsActive And blEnable)
        grupWeb.Enabled = (Cloud.IsActive And blEnable)
        chkOnLine.Enabled = blEnable

        'Me.grupReparar.Enabled = blEnable
        cmdReparIDs.Enabled = blEnable
        Me.buttonSincroWeb.Enabled = (Cloud.IsActive And blEnable = True)
        Me.chkAllDBS.Enabled = (Cloud.IsActive And blEnable = True)

        ' Grup Calendari
        cmbTipProg.Enabled = blEnable
        ' grup Usuaris
        chkCtlPsw.Enabled = blEnable
        txtIntentsUSR.Enabled = blEnable
        txtMaxTemps.Enabled = blEnable
        scrollMaxtemps.Enabled = blEnable
        cmdBorrHistori.Enabled = blEnable


        'Grup Codificació àudio
        GroupCodecAudio.Enabled = blEnable
        'Part Logger
        chkRecord.Enabled = blEnable
        Me.fraConf.Enabled = chkRecord.Checked
        Me.cmbSampleRate.Enabled = blEnable
        Me.cmbBitrate.Enabled = blEnable
        Me.cmbAudioChannel.Enabled = blEnable
        Me.ComboBoxDuradaDef.Enabled = blEnable

        'grup dades: AutoBackup
        chkLastBKP.Enabled = blEnable

        'Streaming
        Me.groupBoxParamsServer.Enabled = (Cloud.ClientType = Cloud.client_type.RADIO_WITH_SERVICES And blEnable)
        Me.groupBoxQualityServer.Enabled = (Cloud.ClientType = Cloud.client_type.RADIO_WITH_SERVICES And blEnable)


        If blEnable Then
            Me.CmdBloqueix.Image = Me.picUnLock.Image
        Else
            Me.CmdBloqueix.Image = Me.picLock.Image
            Me.cmdSalvar.Enabled = False
            SeqValorsChanged = False
            change_Cartutx = False
            change_ConnexCentral = False
            change_CtlRemot = False
            change_CtlUsers = False
            change_DirMagatzem = False
            change_Emergencies = False
            change_EncoderAudio = False
            change_IntegraWeb = False
            change_Moneda = False
            change_MSCControler = False
            change_MSCDirecte = False
            change_ParamsGenerals = False
            change_ReglesMusic = False
            change_SequenciPautes = False
            change_SistemDades = False
            change_Streaming = False
        End If
        Me.Refresh()
    End Sub

    Private Sub CmdBloqueix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdBloqueix.Click
        LokedControls()
    End Sub



    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub

    Private Sub mnuHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHelp.Click
        Dim Proces As Process = New Process
        Try
            Process.Start(MSC.Help.HELP_GEST_AUTOMATITZACIO_PARAMETRES.ToString)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub mnuInternet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuInternet.Click
        Dim Proces As Process = New Process
        Try
            Process.Start(MSC.Help.WEB_DEF_MSC.ToString)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub mnuAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAbout.Click
        Try
            FrmSplash.Show(Me)
        Catch ex As Exception
            FrmSplash.WindowState = FormWindowState.Normal
        End Try

    End Sub

    Private Sub lstDBS_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstDBS.SelectedIndexChanged
        Dim IdDBS As Short
        On Error Resume Next
        IdDBS = Me.lstDBS.SelectedIndex
        Me.txtDBSHost.Text = DBS_Col(IdDBS).HostDBS
        Me.txtDBSName.Text = DBS_Col(IdDBS).NomDBS
        Me.txtDBSPort.Text = DBS_Col(IdDBS).PortDBS
        Me.txtDBSDescip.Text = DBS_Col(IdDBS).DescripDBS
        Me.txtDBSUser.Text = DBS_Col(IdDBS).UsrDBS 'Strings.Format(DBS_Col(IdDBS).UsrDBS, "@@@@@@@@@@")
        Me.txtDBSPassword.Text = DBS_Col(IdDBS).PswDBS 'Strings.Format(DBS_Col(IdDBS).PswDBS, "@@@@@@@@@@")
        Me.cmdDelDBS.Enabled = True
        cmdExportConnection.Enabled = True
        blNewDBS = False

    End Sub

    Private Sub cmdAddDBS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddDBS.Click
        If blNewDBS Then Exit Sub
        Me.lstDBS.SelectedIndex = Me.lstDBS.Items.Add(MSG_NEW_CONNECTION)

        'UPGRADE_WARNING: Lower bound of array DBS_Col was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
        ReDim Preserve DBS_Col(Me.lstDBS.Items.Count + 1)
        BorraPantallaDBS()
        Me.txtDBSDescip.Focus()
        blNewDBS = True
        cmdAddDBS.Enabled = False

    End Sub

    Private Sub cmdDelDBS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelDBS.Click
        DBS_Col(Me.lstDBS.SelectedIndex + 1).blDelete = True
        Me.lstDBS.Items.RemoveAt(Me.lstDBS.SelectedIndex)
        BorraPantallaDBS()
        ChangeMltDBS = True
        Changed()
    End Sub

    Private Sub BorraPantallaDBS()
        Me.txtDBSHost.Text = ""
        Me.txtDBSName.Text = ""
        'Me.txtDNSName.Text = ""
        Me.txtDBSDescip.Text = ""
        Me.txtDBSUser.Text = ""
        Me.txtDBSPassword.Text = ""
        Me.cmdDelDBS.Enabled = False
    End Sub

    Private Sub Changed()
        Me.cmdSalvar.Enabled = blEnable
    End Sub

    Private Sub KeyUp_txtDBS(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDBSUser.KeyUp, txtDBSPort.KeyUp, txtDBSPassword.KeyUp, txtDBSName.KeyUp, txtDBSHost.KeyUp, txtDBSDescip.KeyUp
        ModifOrNewDBS()
    End Sub

    Private Sub TextChanged_txtDBS(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDBSName.TextChanged, txtDBSUser.TextChanged, txtDBSPort.TextChanged, txtDBSPassword.TextChanged, txtDBSHost.TextChanged, txtDBSDescip.TextChanged
        Changed()
    End Sub

    Private Sub ModifOrNewDBS()
        If blNewDBS Then
            DBS_Col(Me.lstDBS.Items.Count - 1).HostDBS = Me.txtDBSHost.Text
            DBS_Col(Me.lstDBS.Items.Count - 1).NomDBS = Me.txtDBSName.Text
            DBS_Col(Me.lstDBS.Items.Count - 1).PortDBS = Me.txtDBSPort.Text
            DBS_Col(Me.lstDBS.Items.Count - 1).DescripDBS = Me.txtDBSDescip.Text
            DBS_Col(Me.lstDBS.Items.Count - 1).UsrDBS = Me.txtDBSUser.Text
            DBS_Col(Me.lstDBS.Items.Count - 1).PswDBS = Me.txtDBSPassword.Text
        Else
            DBS_Col(Me.lstDBS.SelectedIndex).HostDBS = Me.txtDBSHost.Text
            DBS_Col(Me.lstDBS.SelectedIndex).NomDBS = Me.txtDBSName.Text
            DBS_Col(Me.lstDBS.SelectedIndex).PortDBS = Me.txtDBSPort.Text
            DBS_Col(Me.lstDBS.SelectedIndex).DescripDBS = Me.txtDBSDescip.Text
            DBS_Col(Me.lstDBS.SelectedIndex).UsrDBS = Me.txtDBSUser.Text
            DBS_Col(Me.lstDBS.SelectedIndex).PswDBS = Me.txtDBSPassword.Text
        End If
        ChangeMltDBS = True
    End Sub

    Private Sub TestPathAudios(ByVal lb As Label, ByVal Path As String, ByVal NomAudio As String)
        If IO.Directory.Exists(Path) Then
            lb.Text = String.Format(LABEL_DIR_OK, NomAudio)
            lb.Image = Me.picOK.Image
        Else
            lb.Text = String.Format(LABEL_DIR_KO, NomAudio)
            lb.Image = Me.picKO.Image
        End If

    End Sub

    'funcions de carregar paràmetres

#Region "LOAD_Params"

    Private Sub TreeViewParams_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeViewParams.AfterSelect

        lbAtencio.Visible = False
        Me.grupAudioUSR.Visible = False
        Me.grupCartut.Visible = False
        Me.grupCategories.Visible = False
        Me.grupConnRemot.Visible = False
        Me.grupControler.Visible = False
        Me.grupDBS.Visible = False
        Me.grupDirecte.Visible = False
        Me.grupMoneda.Visible = False
        Me.grupPath.Visible = False
        Me.grupWeb.Visible = False
        Me.grupParams.Visible = False
        grupSequencies.Visible = False
        Me.grupSOS.Visible = False
        Me.grupCR.Visible = False
        GroupClients.Visible = False
        grupReparar.Visible = False
        Me.GroupClients.Visible = False
        Me.GroupInfoSistema.Visible = False
        GroupCredits.Visible = False
        GroupBoxUsuaris.Visible = False
        GroupBoxCodificacio.Visible = False
        groupBoxStreaming.Visible = False
        GroupClients.Visible = False
        groupBoxCloudPrograms.Visible = False

        If e.Node.ForeColor = Color.Gray Then loadVal_RegServCloud() : GroupClients.Visible = True : Exit Sub

        Dim folder As Short = CShort(TreeViewParams.SelectedNode.Tag)
        Select Case folder
            Case Catparams.PARAM_PARAMS : loadVal_ParamsGenerals() : grupParams.Visible = True
            Case Catparams.PARAM_PATH : loadVal_DirMagatzem() : Me.grupPath.Visible = True
            Case Catparams.PARAM_MONEDA : loadVal_Moneda() : Me.grupMoneda.Visible = True
            Case Catparams.PARAM_DIRECT : loadVal_MSCDirecte() : Me.grupDirecte.Visible = True
            Case Catparams.PARAM_CATEGO : loadVal_ReglesMusic() : Me.grupCategories.Visible = True
            Case Catparams.PARAM_SEQUENCIES : loadVal_SequenciPautes() : Me.grupSequencies.Visible = True : ListBoxSequencies.Focus()
            Case Catparams.PARAM_CONTROLER : loadVal_MSCControler() : Me.grupControler.Visible = True
            Case Catparams.PARAM_CONNEX_REMOT : loadVal_ConnexCentral() : Me.grupConnRemot.Visible = True
            Case Catparams.PARAM_CARTUT : loadVal_Cartutx() : Me.grupCartut.Visible = True
            Case Catparams.PARAM_FITXERS_USR : loadVal_FitxerAudio() : Me.grupAudioUSR.Visible = True
            Case Catparams.PARAM_DBS : loadVal_ConnextAcces() : Me.grupDBS.Visible = True : lstDBS.Focus()
            Case Catparams.PARAM_SOS : loadVal_Emergencies() : Me.grupSOS.Visible = True
            Case Catparams.PARAM_CR : loadVal_CtlRemot() : Me.grupCR.Visible = True
            Case Catparams.PARAM_CLIENTS : GroupClients.Visible = True
            Case Catparams.PARAM_REPARAR : loadVal_SistemDades() : grupReparar.Visible = True
            Case Catparams.PARAM_SISTEM_INFO : loadVal_InfoSistem() : GroupInfoSistema.Visible = True
            Case Catparams.PARAM_CREDITS : loadVal_Credits() : GroupCredits.Visible = True
            Case Catparams.PARAM_USUARIS : loadVal_CtlUsers() : GroupBoxUsuaris.Visible = True
            Case Catparams.PARAM_LOGGER : loadVal_EncoderAudio() : GroupBoxCodificacio.Visible = True
            Case Catparams.PARAM_CLOUD : loadVal_RegServCloud() : GroupClients.Visible = True
            Case Catparams.PARAM_CLOUD_PRG : groupBoxCloudPrograms.Visible = True
            Case Catparams.PARAM_STREAM : loadVal_Streaming() : groupBoxStreaming.Visible = True
            Case Catparams.PARAM_WEB : loadVal_IntegraWeb() : Me.grupWeb.Visible = True
        End Select
    End Sub

    Dim change_ParamsGenerals As Boolean = False
    Private Sub loadVal_ParamsGenerals()

        Try
            ''  Emissora
            Me.imgLogo.Image = Params.LogoEmpresa
            Me.txtNomRadio.Text = NoNul(Params.NomRadio)
            Me.txtWeb.Text = NoNul(Params.Web)
            Me.txtFaceBook.Text = Params.FaceBook
            Me.txtTwitter.Text = Params.Twitter
            Me.txtTwitterKey.Text = Params.TwitterKey
            ' idioma interficie  

            Me.cmbLang.SelectedValue = Params.Lang
            'Emissió per defecte

            cmbTipProg.SelectedValue = Params.ProgramacioDefecte
            Me.txtComentDesconnexio.Text = Params.CommentDesconnexio

            Dim NomCarp() As String = Split(Params.NomsCarpetaBlocs, ",")
            grupCarpBlocs.Controls.Clear()
            Dim txtCasella As TextBox
            For i As Integer = 0 To NomCarp.Length - 1
                If NomCarp(i).Length > 0 Then
                    txtCasella = New TextBox
                    txtCasella.Text = NomCarp(i).ToString
                    txtCasella.Parent = grupCarpBlocs
                    AddHandler txtCasella.TextChanged, AddressOf ParamsGenerals_TextChanged
                End If
            Next

            Dim taula As DataTable = CreateTableCarpetes()
            Dim row As DataRow = Nothing
            Dim NomCarpAU() As String = Split(Params.NomsCarpetaAudiosUser, ",")
            FlowLayoutPanelCarpetes.Controls.Clear()
            'ColumnCarp.Items.Clear()            
            For i As Integer = 0 To NomCarpAU.Length - 1
                If NomCarp(i).Length > 0 Then
                    txtCasella = New TextBox
                    txtCasella.Text = NomCarpAU(i).ToString
                    txtCasella.Parent = FlowLayoutPanelCarpetes
                    AddHandler txtCasella.TextChanged, AddressOf ParamsGenerals_TextChanged

                    row = taula.NewRow() : row("carpeta_id") = i : row("carpeta_nom") = NomCarpAU(i).ToString : taula.Rows.Add(row)
                End If
            Next
            With ColumnCarp
                .DataSource = taula
                .DisplayMember = "carpeta_nom"
                .ValueMember = "carpeta_id"
            End With
            'cloud
            chkOnLine.Checked = Params.OnLine
            change_ParamsGenerals = False

        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_ACCES_DBS & " : " & ex.Message, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
        End Try

    End Sub

    Dim change_DirMagatzem As Boolean = False
    Private Sub loadVal_DirMagatzem()

        Try
            If Params.IsAlternativeDir = True Then
                Dim db As New MSC.dbs(Cloud)
                Dim SqlStr As String = "SELECT params_valor FROM config_params WHERE params_id=" & CONFIG.paramPathArrelAudios
                Me.txtPathArrelAudio.Text = db.ExecuteScalar(SqlStr)
                txtPathArrelAudio.BackColor = Color.Orange
            Else
                Me.txtPathArrelAudio.Text = Params.PathArrelAudios
            End If

            Me.txtAternativeDir.Text = INIFile.INIRead(MyAPP.IniFile, "Data Control", "AlternativeDir", "")
            If Params.IsAlternativeDir = True Then
                'todo:
                Me.lbAtencio.Visible = True
                Me.lbAtencio.Text = MSG_ALTERNATIVE_DIR
            End If
            change_DirMagatzem = False
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_ACCES_DBS & " : " & ex.Message, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
        End Try

    End Sub

    Dim change_Moneda As Boolean = False
    Private Sub loadVal_Moneda()

        Try
            Dim Cmb As New combo
            Cmb.OmpleCombo(ComboBoxVDef_tarifa, TAULES_DBS.TAULA_TARIFES, TotsCap.CAP) : ComboBoxVDef_tarifa.SelectedValue = Params.TarifaDef
            txtVDEF_DateOut.Text = Params.DaysDateOut
            Me.cmbMoneda.SelectedValue = Params.Moneda
            Me.cmbContraValor.SelectedValue = Params.ContraValor
            Me.txtCanvi.Text = Params.Canvi
            change_Moneda = False
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_ACCES_DBS & " : " & ex.Message, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
        End Try

    End Sub

    Dim change_MSCDirecte As Boolean = False
    Private Sub loadVal_MSCDirecte()

        Try
            'Me.sldSegIniLoad.Value = Params.SegIniLoad
            'Me.lbSegIniLoad.Text = Me.sldSegIniLoad.Value


            Me.sldMSegOClok.Value = Params.MSegOClock
            Me.lbMSegOClok.Text = Me.sldMSegOClok.Value
            Me.chkForceHoraExect.Checked = Params.FHExacte
            chkBorHistInterp.Checked = Params.BorInterpIni

            change_MSCDirecte = False
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_ACCES_DBS & " : " & ex.Message, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
        End Try

    End Sub

    Dim change_ReglesMusic As Boolean = False
    Private Sub loadVal_ReglesMusic()
        ''  Música

        Dim db As New MSC.dbs(Cloud)
        'Try

        Me.txtHTop.Text = Params.HoresTop
        Dim HTop As Integer = 0
        Try
            HTop = CInt(db.ExecuteScalar("SELECT hour(SEC_TO_TIME(SUM(TIME_TO_SEC(tema_durada)))) AS TOTAL FROM  `temes`where tema_pautain=1 and tema_temps=5 ;"))
        Catch ex As Exception
            HTop = 0
        End Try
        lbTestHTop.Text = HTop.ToString & " " & LABEL_DISPONIBLES
        Me.txtHHitTop.Text = Params.HoresHitTop

        Dim HHitTop As Integer = 0
        Try
            HHitTop = CInt(db.ExecuteScalar("SELECT hour(SEC_TO_TIME(SUM(TIME_TO_SEC(tema_durada)))) AS TOTAL FROM  `temes`where tema_pautain=1 and tema_temps=4 ;"))
        Catch ex As Exception
            HHitTop = 0
        End Try
        Me.lbTestHHitTop.Text = HHitTop.ToString & " " & LABEL_DISPONIBLES

        Me.txtHHit.Text = Params.HoresHit
        Dim HHit As Integer = 0
        Try
            HHit = CInt(db.ExecuteScalar("SELECT hour(SEC_TO_TIME(SUM(TIME_TO_SEC(tema_durada)))) AS TOTAL FROM  `temes`where tema_pautain=1 and tema_temps=3 ;"))
        Catch ex As Exception
            HHit = 0
        End Try
        Me.lbTestsHHit.Text = HHit.ToString & " " & LABEL_DISPONIBLES

        Me.txtOld.Text = Params.HoresOld
        Dim HOld As Integer = 0
        Try
            HOld = CInt(db.ExecuteScalar("SELECT hour(SEC_TO_TIME(SUM(TIME_TO_SEC(tema_durada)))) AS TOTAL FROM  `temes`where tema_pautain=1 and tema_temps=1 ;"))
        Catch ex As Exception
            HOld = 0
        End Try
        Me.lbTestHOld.Text = HOld.ToString & " " & LABEL_DISPONIBLES

        Me.txtHOldTop.Text = Params.HoresOldTop
        Dim HOldTop As Integer = 0
        Try
            HOldTop = CInt(db.ExecuteScalar("SELECT hour(SEC_TO_TIME(SUM(TIME_TO_SEC(tema_durada)))) AS TOTAL FROM  `temes`where tema_pautain=1 and tema_temps=2 ;"))
        Catch ex As Exception
            HOldTop = 0
        End Try
        Me.lbTestHOldTop.Text = HOldTop.ToString & " " & LABEL_DISPONIBLES

        Me.txtHBorrInterp.Text = Params.HoresBorrInterp
        Dim HBorrInterp As Integer = 0
        Try
            HBorrInterp = CInt(db.ExecuteScalar("SELECT hour(SEC_TO_TIME(SUM(TIME_TO_SEC(tema_durada)))) AS TOTAL FROM (SELECT tema_durada FROM `temes`where tema_pautain=1 group by tema_interp) as taula"))
        Catch ex As Exception
            HBorrInterp = 0
        End Try
        lbTestHBorrInterp.Text = HBorrInterp.ToString & " " & LABEL_DISPONIBLES

        txtMinusProhivDisc.Text = Params.MinutsDiscProhivit
        Me.txtIntervRitme.Text = Params.IntervRitme
        Me.chkCanviCat.Checked = Params.CanviCat

        Me.txtNTopHit.Text = Params.NTopHit
        Me.txtNHitOld.Text = Params.NHitOld
        Me.txtMaxRadiHIT.Text = Params.MaxRadiHit
        Me.txtMaxRadiTop.Text = Params.MaxRadiTop
        Me.txtMaxRadiOLD.Text = Params.MaxRadiOld
        change_ReglesMusic = False
        'Catch ex As Exception		
        '	MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_ACCES_DBS & " : " & ex.Message, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)            
        'End Try
        db = Nothing
    End Sub


    Dim change_SequenciPautes As Boolean = False
    Private Sub loadVal_SequenciPautes()
        'Secció Seqüències Pautes

        Try
            ompleSeqLlistat()
            change_SequenciPautes = False
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_ACCES_DBS & " : " & ex.Message, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
        End Try
    End Sub

    Dim change_MSCControler As Boolean = False
    Private Sub loadVal_MSCControler()

        Try
            Me.txtSenyHora.Text = Params.PathSenyalHora

            Me.sldMilSegSH.Value = Params.MilSegSH
            Me.lbMilSegSH.Text = Me.sldMilSegSH.Value


            change_MSCControler = False
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_ACCES_DBS & " : " & ex.Message, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
        End Try

    End Sub

    Dim change_ConnexCentral As Boolean = False
    Private Sub loadVal_ConnexCentral()
        Try
            Me.sldVolfader.Value = Params.VolFader
            Me.lbVolfader.Text = Me.sldVolfader.Value

            Me.sldMilFader.Value = Params.MilFader
            Me.lbMilFader.Text = Me.sldMilFader.Value
            change_ConnexCentral = False
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_ACCES_DBS & " : " & ex.Message, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
        End Try

    End Sub

    Dim change_Cartutx As Boolean = False
    Private Sub loadVal_Cartutx()

        Try
            chkCTL_USR_Cartux.Checked = Params.CtlUsrCartut
            Me.chkActvTabProgram.Checked = Params.ActvTabProgram
            change_Cartutx = False
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_ACCES_DBS & " : " & ex.Message, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
        End Try

    End Sub
    'Només lectura
    Private Sub loadVal_FitxerAudio()

        Try
            ListAudioUser()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_ACCES_DBS & " : " & ex.Message, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
        End Try
    End Sub

    Private Function CreateTableCarpetes()
        Dim taula As New DataTable
        Dim column As DataColumn
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Int32")
        column.ColumnName = "carpeta_id"
        taula.Columns.Add(column)

        column = New DataColumn()
        column.DataType = Type.GetType("System.String")
        column.ColumnName = "carpeta_nom"
        taula.Columns.Add(column)
        Return taula
    End Function

    Private Sub loadVal_ConnextAcces()
        '   Secció Accés al Servidor

        Try
            MlpDBS = CBool(INIFile.INIRead(MyAPP.IniFile, "Data key", "MLP_DBS", "0"))
            Me.chkMltDBS.Checked = IIf(MlpDBS = True, 1, 0)
            Dim CLIENT_SECRET_KEY As String = INIFile.INIRead(MyAPP.IniFile, "Data key", "CLIENT_SECRET_KEY", "")
            For i As Short = 0 To 10
                Dim DescripDBS As String = INIFile.INIRead(MyAPP.IniFile, "Data Connect", "DB_Descrip" & i, "")
                If DescripDBS.Length > 0 Then
                    ReDim Preserve DBS_Col(i + 1)
                    DBS_Col(i).DescripDBS = DescripDBS
                    Me.lstDBS.Items.Add(DescripDBS)
                    DBS_Col(i).HostDBS = INIFile.INIRead(MyAPP.IniFile, "Data Connect", "DB_SERVER" & i, "")
                    DBS_Col(i).PortDBS = INIFile.INIRead(MyAPP.IniFile, "Data Connect", "DB_PORT" & i, "3306")
                    DBS_Col(i).NomDBS = INIFile.INIRead(MyAPP.IniFile, "Data Connect", "DB_NAME" & i, "")
                    Dim Usr As String = DecryptRJ256(Cloud.MSC_PRI_SECRET_KEY, CLIENT_SECRET_KEY, INIFile.INIRead(MyAPP.IniFile, "Data Connect", "DB_USER" & i, ""))
                    DBS_Col(i).UsrDBS = Usr.Trim(Chr(0))
                    Dim psw As String = DecryptRJ256(Cloud.MSC_PRI_SECRET_KEY, CLIENT_SECRET_KEY, INIFile.INIRead(MyAPP.IniFile, "Data Connect", "DB_PSW" & i, ""))
                    DBS_Col(i).PswDBS = psw.Trim(Chr(0))
                Else
                    Exit For
                End If
            Next
            txtPathINI.Text = MyAPP.IniFile
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_ACCES_DBS & " : " & ex.Message, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
        End Try
    End Sub

    Dim change_IntegraWeb As Boolean = False
    Private Sub loadVal_IntegraWeb()
        'Secció servidor Web
        Try
            If Cloud.ClientType <> Cloud.client_type.RADIO_WITH_SERVICES Then
                lbAtencio.Visible = True
                lbAtencio.Text = MSG_ADVANCED_SERVICE_DISABLED
            End If

            txtServerFTP.Text = Cloud.ServerFTP
            txtDirFTP.Text = Cloud.DirRemote
            txtUserFTP.Text = Cloud.UserFTP
            txtPswFTP.Text = Cloud.PswFTP 'Microsoft.VisualBasic.Format(Params.PswFTP , "@@@@@@@@")
            ComboBoxSelectQualitatPodcast.SelectedIndex = Cloud.QSamplePodcast
            txtPermanenciaPodcast.Text = Cloud.DiesPermanenciaPodcast

            Me.txtNumTracs.Text = Params.NumTracsVotWeb
            Me.txtNumVots.Text = Params.NumVotWebTorn
            change_IntegraWeb = False
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_ACCES_DBS & " : " & ex.Message, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
        End Try
    End Sub

    Dim change_Emergencies As Boolean = False
    Private Sub loadVal_Emergencies()
        'Secció Servei d'enviament d'errors

        Try
            Me.txtMailRemitent.Text = MSC.Help.FROM_EMAIL_MSC.ToString
            Me.txtMailDesti.Text = Params.ErrEmail
            Me.CheckBoxActiveSOS.Checked = Params.ActvSrvEmergenci
            Me.txtPathLogErr.Text = MyAPP.Error_MSC.PathFitxerLogError
            Me.chk_SendDevelop.Checked = Params.SendToDevelop
            change_Emergencies = False
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_ACCES_DBS & " : " & ex.Message, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
        End Try

    End Sub

    Dim change_CtlRemot As Boolean = False
    Private Sub loadVal_CtlRemot()
        'Secció Control Remot via E-mail

        Try
            txtRemitentCR.Text = Params.RemitentCR
            txtServerMailCR.Text = Params.MailServerCR
            txtUsuariCR.Text = Params.UserNameCR
            txtPasswordCR.Text = Params.PasswordCR
            txtIntervalCR.Text = Params.intervalCR

            Dim db As New MSC.dbs(Cloud)
            Me.DataGridViewInstruccionsCR.DataSource = db.getTable("SELECT * FROM `listinstruccions`;")
            change_CtlRemot = False
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_ACCES_DBS & " : " & ex.Message, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
        End Try
    End Sub

    Dim change_SistemDades As Boolean = False
    Private Sub loadVal_SistemDades()
        'Secció Dades: Auto Backup

        Try
            Me.lbLastBKP.Text = LABEL_LAST_BKP & ": " & Params.LastBackup.ToString
            Dim diff As Integer = DateDiff(DateInterval.Day, Now, Params.LastBackup)
            If diff > 30 Then
                Me.lbLastBKP.Visible = False
                Me.chkLastBKP.Checked = False
            Else
                Me.lbLastBKP.Visible = True
                Me.chkLastBKP.Checked = True
            End If
            change_SistemDades = False
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_ACCES_DBS & " : " & ex.Message, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
        End Try

    End Sub

    'Només lectura
    Private Sub loadVal_InfoSistem()
        'TODO: Generar l'informe

        Try
            txtInformeSistema.Text = GetVariablesEntorn() 'MyAPP.GetVariablesEntorn() 

        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_ACCES_DBS & " : " & ex.Message, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
        End Try
    End Sub

    'Només lectura
    Private Sub loadVal_Credits()
        'Secció Crèdits

        Try
            Dim db As New MSC.dbs(Cloud)
            Me.lbVerDBS.Text = Params.VersioDBS
            lbVerMysql.Text = db.ExecuteScalar("select version();")
            lbVersioBass.Text = Bass.BASS_GetVersion(4).ToString
            lbVerAplic.Text = My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Revision
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_ACCES_DBS & " : " & ex.Message, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
        End Try
    End Sub

    Dim change_CtlUsers As Boolean = False
    Private Sub loadVal_CtlUsers()
        'Secció Usuaris        

        Try
            Me.chkCtlPsw.Checked = Params.AtvPSW
            Me.txtMaxTemps.Text = Params.TempPasPoxConex
            Me.txtIntentsUSR.Text = Params.IntentsUsers
            RefreshListConnexErr()
            change_CtlUsers = False
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_ACCES_DBS & " : " & ex.Message, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
        End Try
    End Sub

    Dim change_EncoderAudio As Boolean = False
    Private Sub loadVal_EncoderAudio()
        'Secció Codificació Àudio 

        Try
            Dim db As New MSC.dbs(Cloud)
            cmbCodecBitrate.Text = Params.BitRate
            Me.cmbCodecSampleRate.Text = Params.SampleRate
            Me.cmbCodecAudioChannel.Text = Params.Channels
            Me.chkVDef_activats.Checked = Params.FilesActives
            chkCaptureTag.Checked = Params.ID3Tag
            '        Me.chkCopyright.Checked = False
            '        Me.chkPrivate.Checked = False
            '        Me.chkCRC.Checked = False
            '        Me.chkOriginal.Checked = False

            Dim SqlStr As String = "SELECT log_defrec,log_bitrate, log_samplerate, log_canals, log_durada FROM prglogger WHERE log_id=1"
            Dim rsLogDef As DataTable = db.getTable(SqlStr)

            Me.chkRecord.Checked = CBool(rsLogDef.Rows(0)("log_defrec"))
            Try
                Me.cmbBitrate.SelectedIndex = cmbBitrate.FindStringExact(rsLogDef.Rows(0)("log_bitrate"))
                Me.cmbSampleRate.SelectedIndex = cmbSampleRate.FindStringExact(rsLogDef.Rows(0)("log_samplerate"))
                Me.cmbAudioChannel.SelectedIndex = CInt(rsLogDef.Rows(0)("log_canals")) - 1
            Catch ex As Exception
            End Try
            ComboBoxDuradaDef.Text = rsLogDef.Rows(0)("log_durada").ToString
            rsLogDef.Dispose()
            change_EncoderAudio = False
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_ACCES_DBS & " : " & ex.Message, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
        End Try
    End Sub

    Dim change_Streaming As Boolean = False
    Private Sub loadVal_Streaming()
        'Secció Streaming

        Try
            If Cloud.ClientType <> Cloud.client_type.RADIO_WITH_SERVICES Then
                lbAtencio.Visible = True
                lbAtencio.Text = MSG_ADVANCED_SERVICE_DISABLED
            End If
            txtURLStreaming.Text = Cloud.StreamUrl
            Me.txtStreamSampleRate.Text = Cloud.StreamSampleRate
            Me.txtStreamBitRate.Text = Cloud.StreamBitRate
            Me.txtStreamCannels.Text = IIf(Cloud.Streamchannels = 1, "MONO", "STEREO")
            Me.comboBoxServerStream.SelectedIndex = Cloud.StreamServerType

            Me.txtServer.Text = Cloud.StreamServer
            Me.txtPort.Text = CStr(Cloud.StreamPort)
            Me.txtMountpoint.Text = Cloud.StreamMountPoint
            Me.txtPassword.Text = Cloud.StreamPassword
            Me.txtEstil.Text = Params.StreamStyle
            change_Streaming = False
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_ACCES_DBS & " : " & ex.Message, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
        End Try
    End Sub

    'Es salva per altres m'etodes
    Private Sub loadVal_RegServCloud()
        'Secció Clients     		
        Try
            Me.txtClientKey.Text = Params.ClientKey()
            Me.lbCientID.Text = Params.ClientID

            setClientControls(Cloud.IsActive) 'testKey()
            If Cloud.IsActive = True Then
                loadVal_PrgShare()
                loadVal_Streaming()
                loadVal_IntegraWeb()
            End If

        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_ACCES_DBS & " : " & ex.Message, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
        End Try
    End Sub

    Private Sub loadVal_PrgShare()
        'Cloud Programes
        If Cloud.ClientType = Cloud.client_type.RADIO_WITH_SERVICES Then
            Try
                If Cloud.IsActive = True Then
                    'Comparteix Programes                    
                    Me.chk_sharePrograms.Checked = Cloud.IsClientSharePrg()
                    If Me.chk_sharePrograms.Checked = True Then
                        ShowProgramsNuvolPropis()
                        ShowProgramesNuvolImportats()
                        TreeViewParams.Nodes(3).Nodes(0).Nodes(0).ForeColor = Color.Black
                    End If
                End If

            Catch ex As Exception
                MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_ACCES_DBS & " : " & ex.Message, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
            End Try
        Else
            lbAtencio.Visible = True
            lbAtencio.Text = MSG_ADVANCED_SERVICE_DISABLED
        End If
    End Sub

#End Region

    Private Sub frmParams_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
#If HideJamendo = "1" Then
        groupBox20.Visible = False
#End If
        'groupBox20.Visible = True 'ENABLE_JAMENDO
        setLanguageForm()

        Dim cmb As New combo
        cmb.OmpleCombo(Me.cmbTipProg, TAULES_DBS.TAULA_TIPUS_EMISSIO, TotsCap.NO_ADD, "NoLoad")
        cmb.OmpleCombo(cmbMoneda, TAULES_DBS.TAULA_MONEDES, TotsCap.CAP)
        cmb.OmpleCombo(cmbContraValor, TAULES_DBS.TAULA_MONEDES, TotsCap.CAP)
        cmb.OmpleCombo(ComboBoxVDef_tarifa, TAULES_DBS.TAULA_TARIFES, TotsCap.CAP) : ComboBoxVDef_tarifa.SelectedValue = Params.TarifaDef

        cmb.OmpleCombo(cmbProgramesPropis, TAULES_DBS.TAULA_PROGRAMES, TotsCap.CAP, "prg_propia=1")
        cmb.OmpleCombo(Me.ColumnAppDesti, TAULES_DBS.TAULA_APLICACIONS, TotsCap.NO_ADD)
        cmb.OmpleCombo(Me.ColumnInstruc, TAULES_DBS.TAULA_REMOTE_INSTRUCCIONS, TotsCap.NO_ADD)
        cmb.OmpleCombo(Me.ComboBoxListAplic, TAULES_DBS.TAULA_APLICACIONS, TotsCap.NO_ADD)
        cmb.OmpleCombo(Me.cmbLang, TAULES_DBS.TAULA_LANG_INTERFACE, TotsCap.NO_ADD)
        blEnable = True
        LokedControls()

        Me.ClientSize = New Size(frm_sice(0), frm_sice(1))
    End Sub

    Private Sub ListAudioUser()
        gridAudioFiles.Rows.Clear()
        Dim db As New MSC.dbs(Cloud)
        Dim dtAudioUsers As DataTable = db.getTable("SELECT * FROM listaudio;")
        For i As Integer = 0 To dtAudioUsers.Rows.Count - 1
            Dim id As Integer = CInt(dtAudioUsers.Rows(i)("audio_id"))
            Dim nom As String = dtAudioUsers.Rows(i)("audio_nom").ToString
            Dim Vcart As Integer = CInt(dtAudioUsers.Rows(i)("audio_visible_cart"))
            Dim Vcont As Integer = CInt(dtAudioUsers.Rows(i)("audio_visible_cont"))
            Dim carp As Integer = CInt(dtAudioUsers.Rows(i)("audio_carpeta"))
            Dim IsEnd As Integer = CInt(dtAudioUsers.Rows(i)("audio_is_ending"))
            Dim IsPh As Integer = CInt(dtAudioUsers.Rows(i)("audio_is_ph"))
            Dim img As Integer = CInt(dtAudioUsers.Rows(i)("audio_image"))
            ' Make a bitmap for the result.
            Dim MyImage As Image = New Bitmap(frmMain.imgListMnu.Images(img))

            gridAudioFiles.Rows.Add(img, resizeImage(MyImage, 16), id, nom, Vcart, Vcont, carp, IsEnd, IsPh)
        Next
        db = Nothing
    End Sub


#Region "Lang"

    Dim MSG_NEW_CONNECTION As String
    Dim LABEL_DIR_OK As String
    Dim LABEL_DIR_KO As String
    Dim LABEL_LAST_BKP As String
    Dim LABEL_VAR_PROGRAMARI As String
    Dim LABEL_VAR_V_APP As String
    Dim LABEL_VAR_V_DBS As String
    Dim LABEL_VAR__V_MYSQL As String
    Dim LABEL_VAR_TIME_ACCES_DBS As String
    Dim LABEL_VAR_V_AUDIO As String
    Dim LABEL_VAR_NOM_SO As String
    Dim LABEL_VAR_PLATAFORMA_SO As String
    Dim LABEL_VAR_V_FRAMEWORK As String
    Dim LABEL_VAR_MAQUINARI As String
    Dim LABEL_VAR_NOM_PC As String
    Dim LABEL_VAR_CPU As String
    Dim LABEL_VAR_CLOCK As String
    Dim LABEL_VAR_RAM As String
    Dim LABEL_VAR_ENABLE_INTERNET As String
    'Dim LABEL_DIR As String 
    Dim LABEL_DISPONIBLES As String

    Dim MSG_ERROR_ACCES_DBS As String
    Dim MSG_CONFIRM_DEL_FILE As String
    Dim MSG_BUSCAR As String
    Dim FolderBrowserDialog1_Description As String
    Dim FILTER_Mapa_bits As String = "Mapa de bits"
    Dim FILTER_IMATGES As String
    Dim MSG_OP_IRREVERSIBLE As String
    Dim MSG_PROCCES_WORK As String = "Realitzant {0}/{1} feines"
    Dim MSG_END_ROWS_AFECTED As String
    Dim MSG_CANCELED As String
    Dim MSG_MODIF_PARAM As String
    Dim INBOX_NOM_SEQUENCIA As String
    Dim NOVA_SEQUENCIA As String
    Dim MSG_SEQUENCIA_NO_DELETE_DEF As String
    Dim MSG_SEQUENCIA_NO_DELETE_USING As String
    Dim MSG_TEST_MAIL_ERROR_BODY As String
    Dim MSG_TEST_MAIL_ERROR_MAIL As String
    Dim MSG_CONTROL_REMOT_CODI As String
    Dim MSG_CONTROL_REMOT_DESTI As String
    Dim MSG_CONTROL_REMOT_INSTRUCCIO As String
    Dim MSG_CONTROL_REMOT_DEL As String
    Dim MSG_ERROR_KEY As String
    Dim MSG_NOT_CREATED_USER As String
    Dim MSG_ERROR_DEL_FILE_LOGERROR As String
    Dim MSG_DEL_LOGERROR As String
    Dim MSG_IMPORT_PRG_OK As String
    Dim MSG_DELETE_HISTORY As String


    Public Sub setLanguageForm()
        Lang.StrForm = Me.Name

        MSG_DELETE_HISTORY = Lang.getText("MSG_DELETE_HISTORY") '""Segur que vols borrar el historial de connexions errònies?""
        MSG_NEW_CONNECTION = Lang.getText("MSG_NEW_CONNECTION") '"Nova Connexió"
        MSG_ERROR_ACCES_DBS = Lang.getText("MSG_ERROR_ACCES_DBS") '"Error al accedir a les dades, fagi una reconstrucció del paràmetres esencials"        
        MSG_CONFIRM_DEL_FILE = Lang.getText("MSG_CONFIRM_DEL_FILE") '"Segur que vols borrar els fitxers: {0}?"
        LABEL_DIR_OK = "     " & Lang.getText("LABEL_DIR_OK") '"Directori correctament assignat per {0}"
        LABEL_DIR_KO = "     " & Lang.getText("LABEL_DIR_KO") '"Directori NO localitzat per {0}"		
        LABEL_LAST_BKP = Lang.getText("LABEL_LAST_BKP") '"Última còpia de seguretat"

        LABEL_VAR_PROGRAMARI = Lang.getText("LABEL_VAR_PROGRAMARI") '"Programari"
        LABEL_VAR_V_APP = Lang.getText("LABEL_VAR_V_APP") '"Versió de l'aplicació"
        LABEL_VAR_V_DBS = Lang.getText("LABEL_VAR_V_DBS") '"Versió DBS"
        LABEL_VAR__V_MYSQL = Lang.getText("LABEL_VAR__V_MYSQL") '"Versió MySql Server" 		
        LABEL_VAR_TIME_ACCES_DBS = Lang.getText("LABEL_VAR_TIME_ACCES_DBS") '"Temps accés dbs"
        LABEL_VAR_V_AUDIO = Lang.getText("LABEL_VAR_V_AUDIO") '"Versió llibreria d'àudio"
        LABEL_VAR_NOM_SO = Lang.getText("LABEL_VAR_NOM_SO") '"Nom del Sistema Operatiu"
        LABEL_VAR_PLATAFORMA_SO = Lang.getText("LABEL_VAR_PLATAFORMA_SO") '"Plataforma Sistema Operatiu"
        LABEL_VAR_V_FRAMEWORK = Lang.getText("LABEL_VAR_V_FRAMEWORK") '"Versió .NET Framework"
        LABEL_VAR_MAQUINARI = Lang.getText("LABEL_VAR_MAQUINARI") '"Maquinari"
        LABEL_VAR_NOM_PC = Lang.getText("LABEL_VAR_NOM_PC") '"Nom de PC"
        LABEL_VAR_CPU = Lang.getText("LABEL_VAR_CPU") '"CPU Model"
        LABEL_VAR_CLOCK = Lang.getText("LABEL_VAR_CLOCK") '"CPU Clock"
        LABEL_VAR_RAM = Lang.getText("LABEL_VAR_RAM") '"Memòria RAM"
        LABEL_VAR_ENABLE_INTERNET = Lang.getText("LABEL_VAR_ENABLE_INTERNET") '"Connexió Internet"
        LABEL_DISPONIBLES = Lang.getText("LABEL_DISPONIBLES", True) '"disponibles"

        MSG_BUSCAR = Lang.getText("LABEL_BUSCAR", True) & " ..." '"Buscar ..."
        FolderBrowserDialog1_Description = Lang.getText("MSG_SELECT_DIR", True) ' "Selecciona un directori"
        FILTER_Mapa_bits = Lang.getText("FILTER_Mapa_bits") ' "Mapa de bits"
        FILTER_IMATGES = Lang.getText("FILTER_IMATGES") ' "Imatges"
        MSG_OP_IRREVERSIBLE = Lang.getText("MSG_OP_IRREVERSIBLE") ' "Operació irreversible, segur que vols continuar?"
        MSG_PROCCES_WORK = Lang.getText("MSG_PROCCES_WORK") ' "Realitzant {0}/{1} feines"
        MSG_END_ROWS_AFECTED = Lang.getText("MSG_END_ROWS_AFECTED") ' "S'ha Finalitzat la operació, s'han modificat {0} registres."
        MSG_CANCELED = Lang.getText("MSG_CANCELED") ' "Operació cancelada"
        MSG_MODIF_PARAM = Lang.getText("MSG_MODIF_PARAM") ' "Atenció es modificaran els paràmetres, vols continuar?"
        INBOX_NOM_SEQUENCIA = Lang.getText("INBOX_NOM_SEQUENCIA") ' "Nom de la seqüència"
        NOVA_SEQUENCIA = Lang.getText("NOVA_SEQUENCIA") ' "Nova seqüència"
        MSG_SEQUENCIA_NO_DELETE_DEF = Lang.getText("MSG_SEQUENCIA_NO_DELETE_DEF") ' "Aquesta seqüència no es pot borrar"
        MSG_SEQUENCIA_NO_DELETE_USING = Lang.getText("MSG_SEQUENCIA_NO_DELETE_USING") ' "Aquesta seqüència no es pot borrar, s'util·litza a les reemissions de programes "
        MSG_TEST_MAIL_ERROR_BODY = Lang.getText("MSG_TEST_MAIL_ERROR_BODY") ' "Això és un correu test, si has rebut aquest correu vol dir que el sistema d'emergències funciona"
        MSG_TEST_MAIL_ERROR_MAIL = Lang.getText("MSG_TEST_MAIL_ERROR_MAIL") ' "S'ha d'introduïr un correu vàlid"
        MSG_CONTROL_REMOT_CODI = Lang.getText("MSG_CONTROL_REMOT_CODI") ' "S'ha d'especificar un valor al codi"
        MSG_CONTROL_REMOT_DESTI = Lang.getText("MSG_CONTROL_REMOT_DESTI") ' "S'ha d'especificar una aplicació destí"
        MSG_CONTROL_REMOT_INSTRUCCIO = Lang.getText("MSG_CONTROL_REMOT_INSTRUCCIO") ' "S'ha d'especificar una Instrucció"
        MSG_CONTROL_REMOT_DEL = Lang.getText("MSG_CONTROL_REMOT_DEL") ' "Seleccioneu en el llistat la instrucció a borrar"
        MSG_ERROR_KEY = Lang.getText("MSG_ERROR_KEY") ' "La clau NO és correcte"
        MSG_NOT_CREATED_USER = Lang.getText("MSG_NOT_CREATED_USER") ' "No es pot activar el control d'usuaris si no hi ha cap usuari creat"
        MSG_ERROR_DEL_FILE_LOGERROR = Lang.getText("MSG_ERROR_DEL_FILE_LOGERROR") ' "Encara no s'ha creat el fitxer (No s'han registrat errors)"
        MSG_DEL_LOGERROR = Lang.getText("MSG_DEL_LOGERROR") ' "Segur que voleu borrar l'historial d'errors?"

        GroupBoxUsuaris.Text = Lang.getText("GroupBoxUsuaris.Text") '"Control d'Usuaris"


        Me.grupAudioUSR.Text = Lang.getText("FITXER_AUDIO", True) ' "Fitxers d'àudio"

        Me.grupMoneda.Text = Lang.getText("FITXER_PUBLICITAT", True)

        Me.lbDies.Text = Lang.getText("lbDies.Text") '"dies"
        Me.lbDataOut.Text = Lang.getText("lbDataOut.Text") '"Data sortida: avui + "
        Me.lbTarifa.Text = Lang.getText("lbTarifa.Text") '"Tarifa per defecte"

        lbFileDefActive.Text = Lang.getText("lbFileDefActive.Text")
        lbCaputeTag.Text = Lang.getText("lbCaputeTag.Text")
        Me.grupSequencies.Text = Lang.getText("grupSequencies.Text") ' "Seqüències Pautes"
        Me.grupConnRemot.Text = Lang.getText("grupConnRemot.Text") ' "Connexió Emissora Central"
        Me.grupDBS.Text = Lang.getText("grupDBS.Text") ' "Connexió d'accés"
        Me.grupWeb.Text = Lang.getText("grupWeb.Text") ' "Integració web"
        Me.grupSOS.Text = Lang.getText("grupSOS.Text") ' "Servei d'emergència"
        Me.labelActiveSOS.Text = grupSOS.Text ' "Activar servei d'emergència"
        Me.GroupInfoSistema.Text = Lang.getText("GroupInfoSistema.Text") ' "Informació del Sistema"
        Me.GroupCredits.Text = Lang.getText("GroupCredits.Text") ' "Crèdits"


        TreeViewParams.Nodes(0).Text = Lang.getText("LABEL_PARAMETRES", True) ' "Paràmetres"
        TreeViewParams.Nodes(0).Nodes(0).Text = Lang.getText("TreeViewParams.Nodes(0).Text") ' "Directoris"		
        TreeViewParams.Nodes(0).Nodes(1).Text = Lang.getText("GroupBoxCodificacio.Text") ' "Codificació Àudio"
        TreeViewParams.Nodes(0).Nodes(2).Text = grupAudioUSR.Text ' "Fitxers d'àudio"
        TreeViewParams.Nodes(0).Nodes(3).Text = grupMoneda.Text ' "Publicitat"		
        TreeViewParams.Nodes(0).Nodes(4).Text = Lang.getText("NAME_PRG_DIRECTE", True) ' "MSC Directe"
        TreeViewParams.Nodes(0).Nodes(4).Nodes(0).Text = Lang.getText("TreeViewParams.Nodes(3).Text") ' "regles"
        TreeViewParams.Nodes(0).Nodes(4).Nodes(1).Text = grupSequencies.Text ' "Seqüències Pautes"        
        TreeViewParams.Nodes(0).Nodes(5).Text = Lang.getText("NAME_PRG_CONTROLER", True) ' "MSC Controler"
        TreeViewParams.Nodes(0).Nodes(5).Nodes(0).Text = grupConnRemot.Text ' "Connexió Emissora Central"
        TreeViewParams.Nodes(0).Nodes(5).Nodes(1).Text = Lang.getText("LABEL_CONTROL_REMOT", True) ' "Control Remot"		
        TreeViewParams.Nodes(0).Nodes(6).Text = Lang.getText("NAME_PRG_CARTUTX", True) ' "MSC Cartutxeres"
        TreeViewParams.Nodes(0).Nodes(7).Text = Me.grupDBS.Text ' "Connexió d'accés"
        TreeViewParams.Nodes(0).Nodes(8).Text = grupSOS.Text ' "Servei d'emergència"
        TreeViewParams.Nodes(1).Text = Lang.getText("TreeViewParams.Nodes(16).Text") ' "Dades"
        TreeViewParams.Nodes(2).Text = Lang.getText("HEADERTEXT_USUARI", True) ' "Usuaris"
        TreeViewParams.Nodes(3).Text = Lang.getText("LABEL_SERVICES_MSC", True) '"Services MSC-Soft"
        TreeViewParams.Nodes(3).Nodes(0).Text = Lang.getText("LABEL_NUVOL_COMUNITARI", True) '"Núvol Comunitari"'lang.getText("TreeViewParams.Nodes(17).Text")' "Usuaris"
        TreeViewParams.Nodes(3).Nodes(0).Nodes(0).Text = Lang.getText("NAME_PROGRAMES", True) '"Programes"
        TreeViewParams.Nodes(3).Nodes(1).Text = grupWeb.Text ' "Integració web"
        TreeViewParams.Nodes(3).Nodes(2).Text = Lang.getText("LABEL_STREAM", True) ' "Streaming"		
        TreeViewParams.Nodes(4).Text = GroupCredits.Text ' "Crèdits"
        TreeViewParams.Nodes(4).Nodes(0).Text = Lang.getText("LABEL_EQUIPAT_AMB", True) & " ..." ' "Equipat amb ..."
        TreeViewParams.Nodes(4).Nodes(1).Text = GroupInfoSistema.Text ' "Informació del Sistema"

        Me.grupParams.Text = Lang.getText("LABEL_PARAMS_GENERALS", True) ' "Paràmetres generals"
        Me.GroupBox6.Text = Lang.getText("GroupBox6.Text") ' "Emissora"
        Me.label124.Text = Lang.getText("label124.Text") & ":" ' "Adreça web" & ":"
        Me.label111.Text = Lang.getText("LABEL_TWITTER_KEY", True) & ":" ' "Twitter Key" & ":"
        Me.Label50.Text = Lang.getText("LABEL_STREAM", True) & ":" ' "Streaming" & ":"
        Me.Label110.Text = Lang.getText("LABEL_TWITTER", True) & ":" ' "Twitter" & ":"
        Me.Label2.Text = Lang.getText("LABEL_FACEBOOK", True) & ":" ' "FaceBook" & ":"
        Me.cmdAddLogo.Text = Lang.getText("cmdAddLogo.Text") & ":" ' "Afegir logo"
        Me.lbNomRadio.Text = Lang.getText("lbNomRadio.Text") & ":" ' "Nom de la ràdio" & ":"
        Me.Label1.Text = Lang.getText("Label1.Text") & ":" ' "Logo" & ":"
        Me.GroupBox1.Text = Lang.getText("LABEL_CALENDAR", True) ' "Calendari"
        Me.Label94.Text = Lang.getText("Label94.Text") & ":" ' "Programació per defecte" & ":"
        Me.Label96.Text = Lang.getText("Label96.Text") ' "La durada per defecte és d'una hora (No modificable)"
        Me.lbInfo.Text = MSG_SYSTEM_STANBY_DIRECTE ' "Sistemes en standby, la continuïtat és responsabilitat del tècnic."
        Me.lbRadForm.Text = Lang.getText("lbRadForm.Text") ' "Ràdio Fórmula musical, segons els paràmetres de la pauta per defecte."
        Me.grupCarp.Text = Lang.getText("grupCarp.Text") ' "Temàtiques dels blocs musicals"
        Me.Label57.Text = Lang.getText("Label57.Text") ' "Les caselles sense nom es borraran"
        Me.cmdAddCarpBlocs.Text = Lang.getText("LABEL_ADD", True) & "..." ' "Afegir" & "..."

        Me.Label46.Text = Lang.getText("Label46.Text") & ":" ' "Relació de canvi" & ":"
        Me.Label45.Text = Lang.getText("Label45.Text") & ":" ' "Contra Valor" & ":"
        Me.Label44.Text = Lang.getText("Label44.Text") & ":" ' "Moneda amb que es treballa" & ":"

        Me.grupCartut.Text = Lang.getText("NAME_PRG_CARTUTX", True) ' "MSC Cartutxeres"
        Me.Label58.Text = Lang.getText("Label58.Text") ' "Ha d'estar activat el control d'usuaris. Per configurar-lo aneu a manteniment d'usuaris."
        Me.chkCTL_USR_Cartux.Text = Lang.getText("chkCTL_USR_Cartux.Text") ' "Control d'usuaris a les cartutxeres"
        Me.chkActvTabProgram.Text = Lang.getText("chkActvTabProgram.Text") ' "Tenir accesibilitat a les sessions dels programes"
        Me.grupCategories.Text = Lang.getText("grupCategories.Text") ' "Comptadors Musicals"
        Me.Label43.Text = Lang.getText("Label43.Text") & ":" ' "Nº Màxim de radiacions per un OLD" & ":"
        Me.Label42.Text = Lang.getText("Label42.Text") & ":" ' "Nº Màxim de radiacions per un HIT" & ":"
        Me.Label41.Text = Lang.getText("Label41.Text") & ":" ' "Nº Màxim de radiacions per un TOP" & ":"
        Me.Label40.Text = Lang.getText("Label40.Text") ' "A una cançó podem forçar-li el número màxim de radiacion segons la seva categoria, passat aquestes radiacions deixarà d'estar activa. S'ha d'activar aquesta opció a cada cançó en concret."
        Me.GroupBox2.Text = Lang.getText("GroupBox2.Text") ' "Canvi automàtic de categoria"
        Me.Label38.Text = Lang.getText("Label38.Text") & ":" ' "Nº de radiacions per passar de Hit a Old" & ":"
        Me.Label37.Text = Lang.getText("Label37.Text") & ":" ' "Nº de radiacions per passar de Top a Hit" & ":"
        Me.chkCanviCat.Text = Lang.getText("chkCanviCat.Text") ' "Activa el canvi automàtic"
        Me.Label39.Text = Lang.getText("Label39.Text") ' "La categoria HitTop i OldTop s'interpreten com a Hit i Old respectivament."
        Me.Label36.Text = Lang.getText("Label36.Text") & ":" ' "OLD" & ":"
        Me.Label35.Text = Lang.getText("Label35.Text") & ":" ' "OLTTOP" & ":"
        Me.Label34.Text = Lang.getText("Label34.Text") & ":" ' "HITTOP" & ":"
        Me.Label33.Text = Lang.getText("Label33.Text") & ":" ' "HIT" & ":"
        Me.Label32.Text = Lang.getText("LABEL_TOP", True) & ":" ' "TOP" & ":"
        Me.Label31.Text = Lang.getText("Label31.Text") ' "Número de hores que han de passar fins que una cançó no torni a sonar. Segons la 'classificació temporal' de la cançó podem definir un interval diferent."

        Me.buttonDelCtlLog.Text = Lang.getText("LABEL_DELETE", True) '"Borrar"		
        Me.cmdDelDBS.Text = Lang.getText("LABEL_DELETE", True) '"Borrar"
        Me.cmdDelSequenc.Text = Lang.getText("LABEL_DELETE", True) '"Borrar"
        Me.cmdDelAudio.Text = Lang.getText("LABEL_DELETE", True) '"Borrar"
        cmdExportConnection.Text = Lang.getText("LABEL_EXPORT", True) '"Exportar"

        Me.label51.Text = Lang.getText("LABEL_LOCALITZACIO", True) & ":" ' "Localització" & ":"
        Me.label53.Text = label51.Text ' "Localització" & ":"

        Me.Label86.Text = Lang.getText("Label86.Text") ' "Utilitzeu aquesta funció per assabentar-vos al moment de qualsevol pèrdua de continuïtat de la programació"
        Label87.Text = Lang.getText("Label87.Text") '"Utilitzant la configuració per defecte esteu acceptant enviar l'informe d'error al desenvolupador d'aquesta suite, aquest es compromet a utilitzar les dades única i exclusivament per millorar la aplicació."
        Label20.Text = Lang.getText("Label20.Text") '"No s'envia cap informació de l'usuari ni del sistema, només un informe de l'error que ha provocat l'aturada descontrolada. Podeu visualitzar la totalitat de la informació enviada en el fitxer 'ctlMSC.log'."
        Me.Label74.Text = Lang.getText("Label74.Text") ' "És possible varis correus separats per comes"
        Me.Label72.Text = Lang.getText("Label72.Text") ' "Correu destí"
        Me.Label71.Text = Lang.getText("Label71.Text") ' "Correu remitent"
        Me.MetroLabel1.Text = Lang.getText("MetroLabel1.Text") ' "Send errors to developer"

        Me.grupPath.Text = Lang.getText("grupPath.Text") ' "Directoris Magatzem"

        Me.Label47.Text = Lang.getText("Label47.Text") & ":" ' "Directori arrel dels fitxers d'àudio:"		

        Me.Label8.Text = Lang.getText("LABEL_PORT", True) & ":" ' "Port" & ":"

        Me.Label10.Text = Lang.getText("LABEL_CONTRASENYA", True) & ":" ' "Contrasenya" & ":"
        Me.Label9.Text = Lang.getText("LABEL_USER", True) & ":" ' "Usuari" & ":"
        Me.Label7.Text = Lang.getText("LABEL_HOST", True)  ' "Host o IP" & ":"
        Me.Label6.Text = Lang.getText("LABEL_NOM_DBS", True) & ":" ' "Nom DBS" & ":"
        Me.Label5.Text = Lang.getText("LABEL_DESCRIPCIO", True) ' "Descripció"
        Me.Label4.Text = Lang.getText("Label4.Text") ' "Llistat de connexions possibles"
        Me.labelMltDBS.Text = Lang.getText("chkMltDBS.Text") ' "Accés a múltiples connexions"
        Me.grupDirecte.Text = Lang.getText("NAME_PRG_DIRECTE", True) ' "MSC Directe"
        Me.label114.Text = Lang.getText("label114.Text") ' "Si el valor és 0 equival a no s'establir la prohibició."
        Me.label115.Text = Lang.getText("label115.Text") ' "Minuts que han de passar per poder repetir un disc"
        Me.Label25.Text = Lang.getText("Label25.Text") ' "Aquest valor no hauria de ser superior al valor més petit d'hores que han de passar per repetir una cançó segons la seva categoria (veure ""Comptadors"")."
        Me.Label24.Text = Lang.getText("Label24.Text") & ":" ' "Hores que han de passar per poder repetir un intèrpret" & ":"
        Me.Label23.Text = Lang.getText("Label23.Text") ' "El paràmetre ""Interval Ritme"" expressa la tolerància del filtratge del ritme. Ex: si assignem un interval de 20 , al filtrar cançons d'un ritme de 100 BPMs tolerarà ritmes de 80 fins a 120. "
        Me.Label22.Text = Lang.getText("Label22.Text") & ":" ' "Interval Ritme" & ":"
        Me.chkBorHistInterp.Text = Lang.getText("chkBorHistInterp.Text") ' "Borrar historial d' intèrprets al iniciar el programa."
        Me.Label21.Text = Lang.getText("Label21.Text") ' "Milisegons de retard per ajustar l'inici de la pauta a l'inici d'hora."
        Me.chkForceHoraExect.Text = Lang.getText("chkForceHoraExect.Text") ' "Forçar la recerca d'un tema per quadar la hora al final."
        Me.grupCR.Text = Lang.getText("grupCR.Text") ' "Control Remot (via e-mail)"
        Me.Label83.Text = Lang.getText("Label83.Text") & ":" ' "Interval de refesc (seg.)"
        Me.GroupBox5.Text = Lang.getText("GroupBox5.Text") ' "Llistat d'instruccions" & ":"
        Me.Label82.Text = Lang.getText("LABEL_DESCRIPCIO", True) & ":" ' "Descripció" & ":"
        Me.Label81.Text = Lang.getText("LABEL_CODI", True) & ":" ' "Codi" & ":"
        Me.Label79.Text = Lang.getText("LABEL_APLICACIO", True) & ":" ' "Aplicació" & ":"
        Me.Label80.Text = Lang.getText("LABEL_INSTRUCCIO", True) & ":" ' "Instrucció" & ":"
        Me.ButtonAddInstrucioCR.Text = Lang.getText("ButtonAddInstrucioCR.Text") ' "Afegir instrucció"
        Me.ButtonDelInstruccio.Text = Lang.getText("ButtonDelInstruccio.Text") ' "Borrar instrucció"
        Me.ColumnCodi.HeaderText = Lang.getText("LABEL_CODI", True) ' "Codi"
        Me.ColumnAppDesti.HeaderText = Lang.getText("ColumnAppDesti.HeaderText") ' "Aplic Destí"
        Me.ColumnInstruc.HeaderText = Lang.getText("LABEL_INSTRUCCIO", True) ' "Instrucció"
        Me.ColumnDescrip.HeaderText = Lang.getText("LABEL_DESCRIPCIO", True) ' "Descripció"
        Me.Label78.Text = Lang.getText("Label78.Text") ' "Per activar-lo  introduïu un correu vàlid ."
        Me.Label77.Text = Lang.getText("Label77.Text") ' "Contrasenya Mail"
        Me.Label76.Text = Lang.getText("Label76.Text") ' "Usuari Mail"
        Me.Label75.Text = Lang.getText("Label75.Text") ' "Servidor Mail entrant"
        Me.Label73.Text = Lang.getText("Label73.Text") ' "Control del remitent"

        Me.label116.Text = Lang.getText("label116.Text") ' "Seqüència per defecte de la emissió automàtica de programes"
        Me.Label69.Text = Lang.getText("Label69.Text") ' "Valors del llistat"
        Me.Label68.Text = Lang.getText("Label68.Text") ' "Llistat de seqüències disponibles"
        Me.lbNovaSequ.Text = Lang.getText("lbNovaSequ.Text") ' "NOVA"

        Me.cmdAddSequenc.Text = Lang.getText("cmdAddSequenc.Text") ' "Nova"
        Me.ColumnValors.HeaderText = Lang.getText("ColumnValors.HeaderText") ' "Valor"
        Me.GroupBox8.Text = Lang.getText("GroupBox8.Text") ' "Intents de connexió erronis"
        Me.ColumnHeader3.Text = Lang.getText("ColumnHeader3.Text") ' "Alies erròni"
        Me.ColumnHeader4.Text = Lang.getText("ColumnHeader4.Text") ' "PassWord erròni"
        Me.ColumnHeader5.Text = Lang.getText("ColumnHeader5.Text") ' "Nº intents"
        Me.Label103.Text = Lang.getText("Label103.Text") '  "Es conservaran els últims 30 dies."
        Me.cmdBorrHistori.Text = Lang.getText("LABEL_DEL_HISTORIAL", True) ' "Borrar historial"
        Me.labelCtlPsw.Text = Lang.getText("chkCtlPsw.Text") '  "control d'usuaris activat"
        Me.Label98.Text = Lang.getText("Label98.Text") & ":" ' "Màxim nº d'intents erronis:"
        Me.Label101.Text = Lang.getText("Label101.Text") & ":" ' "Temps Bloqueig" & ":"
        Me.Label102.Text = Lang.getText("Label102.Text") ' "Temps que ha de passar per autoritzar una connexió quan la última vegada que s'ha intentat accedir va ser errònia."
        Me.GroupBoxCodificacio.Text = Lang.getText("GroupBoxCodificacio.Text") ' "Codificació Àudio"
        Me.GroupCodecAudio.Text = Lang.getText("GroupCodecAudio.Text") ' "Codificar a MP3"
        'Me.lbLameVer.Text = "Versió: 2.3"		
        Me.chkCRC.Text = Lang.getText("chkCRC.Text") ' "CRC"
        Me.chkCopyright.Text = Lang.getText("chkCopyright.Text") ' "Copyright"
        Me.label121.Text = Lang.getText("LABEL_CANALS_AUDIO", True) ' "Canals d'audio"
        Me.label122.Text = Lang.getText("LABEL_FREQUENCIA_HZ", True) ' "Freqüència (Hz)"
        Me.label123.Text = Lang.getText("LABEL_BITRATE", True) & " (Kbps)" ' "Bitrate (Kbps)"
        Me.label120.Text = Lang.getText("label120.Text") ' "Al importar fitxers es codificaran amb la qualitat aquí definida"
        Me.groupBox15.Text = Lang.getText("groupBox15.Text") ' "Còpia Testimòni (MSC Logger)"
        Me.Label104.Text = Lang.getText("Label104.Text") ' "A les hores on no hi cap enregistrament assignat (apartat Programació Logger) es procedirà segons les especificacions aquí configurades."
        Me.fraConf.Text = Lang.getText("LABEL_VALOR_DEFECTE", True) ' "Valors per defecte"
        Me.Label105.Text = Lang.getText("HEADERTEXT_DURADA", True) ' "Durada"
        Me.Label106.Text = Lang.getText("LABEL_CANALS_AUDIO", True) ' "Canals d'audio"		
        Me.Label107.Text = Lang.getText("LABEL_FREQUENCIA_HZ", True) ' "Freqüència (Hz)"
        Me.Label108.Text = Lang.getText("LABEL_BITRATE", True) ' "Bitrate (Kbps)"
        Me.chkRecord.Text = Lang.getText("chkRecord.Text") ' "Enregistrar per defecte"

        Me.groupBox14.Text = Lang.getText("groupBox14.Text") ' "Còpies de seguretat"
        Me.GroupBox9.Text = Lang.getText("GroupBox9.Text") ' "Llibreries d'àudio"
        'Me.Label92.Text = "LAME is a high quality MPEG Audio Layer III (MP3) encoder licensed under the LGPL."
        'Me.LinkLbLame.Text = "http://lame.sourceforge.net"
        'Me.LinkLbBass.Text = "http://www.un4seen.com/"
        'Me.Label95.Text = "Lame_enc"
        'Me.lbVersioBass.Text = "2.4"
        Me.Label97.Text = Lang.getText("Label97.Text") & ":" ' "Bass Audio Library " & ":"
        Me.GroupBox10.Text = Lang.getText("GroupBox10.Text") ' "Servidor de dades"
        'Me.Label56.Text = "The world's most popular open source database"
        'Me.LinkLbMySql.Text = "http://www.mysql.com/"
        'Me.lbVerMysql.Text = "5.5"
        Me.Label99.Text = Lang.getText("Label99.Text") & ":" ' "MySQL Server " & ":"

        Me.Label109.Text = Lang.getText("Label109.Text") & ":" ' "Informe del sistema" & ":"
        Me.GroupBox11.Text = Lang.getText("GroupBox11.Text") ' "Versions"
        'Me.lbVerAplic.Text = "7.5"
        Me.Label93.Text = LABEL_VAR_V_APP & " : " ' "Versió de la aplicació" & " : "
        Me.Label100.Text = Lang.getText("Label100.Text") & " : " ' "Versió de la DBS" & " : "
        'Me.lbVerDBS.Text = "5.6"
        groupBox20.Text = Lang.getText("groupBox20.Text") '"Free music downloads"

        Me.cmdAddAudio.Text = Lang.getText("LABEL_NEW", True) ' "Nou"
        Me.Label11.Text = Lang.getText("Label11.Text") ' "Llista de fitxers d'àudio."
        GroupBoxCarpetes.Text = Lang.getText("LABEL_FOLDERS", True) ' "Carpetes"
        ButtonAddCarpeta.Text = Lang.getText("LABEL_ADD", True) & "..."
        ColumnCarp.HeaderText = GroupBoxCarpetes.Text
        Column_nom.HeaderText = Lang.getText("LABEL_NOM", True)
        ColumnEnding.HeaderText = Lang.getText("LABEL_ENDINGS", True)
        Columnph.ToolTipText = Lang.getText("FITXER_PRESENTA_HORA", True)
        Columnph.HeaderText = Lang.getText("HEADERTEXT_HORA", True)
        Me.GroupBox3.Text = Lang.getText("GroupBox3.Text") ' "Ràdio-Activa"
        Me.Label61.Text = Lang.getText("Label61.Text") ' "La audiència pot escollir les cançons mitjançant la Web. La activació d'aquesta funció depèn de cada pauta"
        Me.Label60.Text = Lang.getText("Label60.Text") & ":" ' "Nº de votacions per torn" & ":"
        Me.Label59.Text = Lang.getText("Label59.Text") & ":" ' "Nº de cançons a escollir" & ":"
        Me.GroupBox4.Text = Lang.getText("GroupBox4.Text") ' "Servidor Web Potcasting"
        Me.label113.Text = Lang.getText("label113.Text") ' "Data Caducitat = Data Publicació + dies"
        Me.label112.Text = Lang.getText("label112.Text") ' "Dies de permanència"
        Me.GroupBox13.Text = Lang.getText("GroupBox13.Text") ' "Resamplejar arxius"
        Me.Label19.Text = Lang.getText("LABEL_QUALITAT", True) ' "Qualitat"		
        Me.cmdTestFTP.Text = Lang.getText("cmdTestFTP.Text") ' "Test FTP"		
        Me.Label66.Text = Lang.getText("LABEL_CONTRASENYA", True) ' "Contrasenya"
        Me.Label65.Text = Lang.getText("LABEL_USER", True) ' "Usuari"
        Me.Label64.Text = Lang.getText("Label64.Text") ' "Directori del servidor"
        Me.Label63.Text = Lang.getText("Label63.Text") ' "Servidor FTP"		

        Me.Label88.Text = Lang.getText("Label88.Text") ' "La configuració de la targeta de so i el canal d'entrada s'ha de gestionar directament en el programa MSC Controller i en el PC que gestiona la continuïtat."

        Me.Label14.Text = Lang.getText("Label14.Text") & " :" ' "Milisegons d'espera per fer el fader" & " :"
        Me.Label13.Text = Lang.getText("Label13.Text") ' "Augmenta o disminueix el temps que tarda en fer un Fader In o Fader Out. "
        Me.Label12.Text = Lang.getText("Label12.Text") & ":" ' "Velocitat de Fader" & ":"
        Me.grupControler.Text = Lang.getText("NAME_PRG_CONTROLER", True) ' "MSC Controler"
        Me.label91.Text = Lang.getText("label91.Text") & ":" ' "Sincronització dels senyals horaris" & ":"
        Me.Label18.Text = Lang.getText("Label18.Text") ' "Atenció, el fitxer dels senyals horaris no pot tenir una durada superior a 1 minut."
        Me.Label17.Text = Lang.getText("Label17.Text") ' "Fitxer senyals horaris"
        Me.Label16.Text = Lang.getText("Label16.Text") ' "Milisegons adicionals per avançar el punt d'inici dels senyals horaris "
        Me.grupReparar.Text = Lang.getText("grupReparar.Text") ' "Sistema de Dades"
        Me.groupBox16.Text = Lang.getText("groupBox16.Text") ' "Còpies automàtiques de la base de dades"
        'Me.lbLastBKP.Text = "Última còpia : 2015-05-05 11:30:00"
        Me.chkLastBKP.Text = Lang.getText("chkLastBKP.Text") ' "Activar la còpia automàtica"
        Me.GroupBox12.Text = Lang.getText("GroupBox12.Text") ' "Reparar"
        Me.cmdReparIDs.Text = Lang.getText("cmdReparIDs.Text") ' "Reparar IDs depenents"
        Me.Label55.Text = Lang.getText("Label55.Text") ' "Repara les dependències errònies de la BBDD."

        groupBox17.Text = Lang.getText("groupBox17.Text") '"Resincronitzar Web"
        chkAllDBS.Text = Lang.getText("chkAllDBS.Text")
        Me.buttonSincroWeb.Text = Lang.getText("buttonSincroWeb.Text") '"Resincronitzar"
        label140.Text = Lang.getText("label140.Text") '"Sincronitza les dades compartides"				

        Me.ProgramaToolStripMenuItem.Text = Lang.getText("LABEL_PROGRAMA", True) ' "Programa"

        Me.mnuExit.Text = Lang.getText("LABEL_EXIT", True) ' "Sortir"
        Me.AjudaToolStripMenuItem.Text = Lang.getText("mnu_Help", True) ' "Referent a " & "... "
        Me.mnuHelp.Text = Lang.getText("mnuRefHelp.Text", True) ' "Manual OnLine"
        Me.mnuInternet.Text = Lang.getText("mnuRefWeb.Text", True) ' "MSC a Internet"
        Me.mnuAbout.Text = Lang.getText("mnuRefMSC.Text", True) ' "Sobre MSC"
        Me.label125.Text = Lang.getText("LABEL_IDIOMA_INTERFICIE", True) & ":" 'Idioma Interfície:

        'streaming

        Me.groupBoxQualityServer.Text = Lang.getText("LABEL_QUALITAT_STREAMING", True) '"Qualitat streaming"
        Me.groupBoxParamsServer.Text = Lang.getText("LABEL_PARAMS_SERVER", True) '"Paràmetres del servidor"

        Me.label128.Text = Lang.getText("HEADERTEXT_ESTIL", True) '"Estil"
        Me.label129.Text = Lang.getText("label129.Text") '"Tipus de servidor:"
        Me.label130.Text = Lang.getText("LABEL_PASSWORD", True) & ":" '"Password:"
        Me.label131.Text = Lang.getText("LABEL_MOUNT_POINT", True) & ":" '"Mount Point:"
        Me.label132.Text = Lang.getText("LABEL_PORT", True) & ":" '"Port:"
        Me.label133.Text = Lang.getText("LABEL_SERVER", True) & ":" '"Servidor:"
        Me.label28.Text = Lang.getText("LABEL_CANALS_AUDIO", True) '"Canals d'audio"
        Me.label126.Text = Lang.getText("LABEL_FREQUENCIA_HZ", True) '"Freqüència (Hz)"
        Me.label127.Text = Lang.getText("LABEL_BITRATE", True) '"Bitrate (Kbps)"
        label134.Text = Lang.getText("label134.Text") & ":" '"Directori local alternatiu"
        Label47.Text = Lang.getText("LABEL_DIR_ROOT_AUDIOS", True) & ":"

        'Núvol
        Me.GroupClients.Text = Lang.getText("GroupClients.Text") ' "Registre del servei"
        Me.LbClientOK.Text = Lang.getText("LbClientOK.Text") ' "Client amb seveis avançats"
        Me.LbClientKO.Text = Lang.getText("MSG_ADVANCED_SERVICE_DISABLED", True) ' "Serveis avançats desactivats"
        Me.cmdActive.Text = Lang.getText("cmdActive.Text") ' "Activació"		
        Me.Label85.Text = Lang.getText("Label85.Text") & ":" ' "Clau Activació" & ":"
        lbOnline.Text = Lang.getText("lbOnline.Text") 'Active sincronation online

        Label15.Text = Lang.getText("Label15.Text") & ":" '"Codi per compartir:"
        LbInfoConvida.Text = Lang.getText("LbInfoConvida.Text") '"Dona aquest codi a l'emissora amb qui vols compartir aquest programa"
        Column_prg_state.HeaderText = Lang.getText("LABEL_ACTIVA", True) '"Active"
        lbInfoPrgCloud.Text = Lang.getText("lbInfoPrgCloud.Text") '"Enganxa el codi que t'han proporcionat"
        ColumnFrom.HeaderText = Lang.getText("ColumnFrom.HeaderText") '"From"
        'todo:
        groupBoxCloudPrograms.Text = Lang.getText("groupBoxCloudPrograms.Text") '"Programes compartits"

        chk_sharePrograms.Text = Lang.getText("chk_sharePrograms.Text") '"Compartir Programes"

        tabPagePrgShareCloud.Text = Lang.getText("tabPagePrgShareCloud.Text") '"Programes del Núvol"
        tabPagePrgCloudPropis.Text = Lang.getText("tabPagePrgCloudPropis.Text") '"Programes Propis a compartir"

        label54.Text = Lang.getText("NAME_PROGRAMES", True) '"Programa"

        label136.Text = Lang.getText("label136.Text") '"Programes propis compartits"        
        label139.Text = Lang.getText("label139.Text") '"Programes importats procedents del núvol"
        MSG_IMPORT_PRG_OK = Lang.getText("MSG_IMPORT_PRG_OK") '"S'ha importat el programa"
        'columnes grids
        Me.Column_prg_nom.HeaderText = Lang.getText("LABEL_NOM", True) '"Nom"
        Me.Column_prg_emissora.HeaderText = GroupBox6.Text '"Emissora"
        Me.dataGridViewTextBoxColumn2.HeaderText = Lang.getText("LABEL_NOM", True) '"Nom"

        Me.Text = Lang.getText("LABEL_PARAMS_SISTEMA", True) ' "Paràmetres del sistema"



    End Sub

#End Region

    Private Function GetVariablesEntorn() As String
        Dim osInfo As OperatingSystem = Environment.OSVersion
        Dim verInfo As Version = osInfo.Version
        Dim TxtEntorn As String = ""
        Dim OS As New ClientInfo

        Dim StrBitsOS As String = "X32"
        If Utils.Is64Bit = True Then StrBitsOS = "X64"
        Try

            TxtEntorn = "---::: " & LABEL_VAR_PROGRAMARI & " :::--- " & vbCrLf &
                LABEL_VAR_V_APP & " : " & lbVerAplic.Text & " " & StrBitsOS & " " & IIf(BETA_VERSION = True, "BETA", "") & vbCrLf &
                LABEL_VAR_V_DBS & " : " & Me.lbVerDBS.Text & vbCrLf &
                LABEL_VAR__V_MYSQL & " : " & lbVerMysql.Text & vbCrLf

            Dim db As New MSC.dbs(Cloud)
            db.ExecuteScalar("SELECT NOW()")
            TxtEntorn += LABEL_VAR_TIME_ACCES_DBS & " :" & db.TempsResposta.TotalMilliseconds & " Milisegons" & vbCrLf
            TxtEntorn += LABEL_VAR_V_AUDIO & " : " & Bass.BASS_GetVersion(4).ToString & vbCrLf &
                LABEL_VAR_NOM_SO & " : " & My.Computer.Info.OSFullName & vbCrLf &
                LABEL_VAR_PLATAFORMA_SO & " : " & My.Computer.Info.OSPlatform & " / " & OS.SystemType & vbCrLf &
                LABEL_VAR_V_FRAMEWORK & " : " & System.Environment.Version.ToString & vbCrLf &
                "---::: " & LABEL_VAR_MAQUINARI & " :::--- " & vbCrLf &
                LABEL_VAR_NOM_PC & " : " & OS.ComputerName & vbCrLf &
                LABEL_VAR_CPU & " : " & OS.CPUManufacturer & " " & OS.CPUName & vbCrLf &
                LABEL_VAR_CLOCK & " : " & String.Format(" {0:0.00} GHz x " & OS.CPUNumCores, OS.CPUClock / 1000, 1) & vbCrLf &
                LABEL_VAR_RAM & " : " & FormatNumber(My.Computer.Info.TotalPhysicalMemory / 1073741824, 2) & " GB Total / " & FormatNumber(My.Computer.Info.AvailablePhysicalMemory / 1073741824, 2) & " GB Utilitzada" & vbCrLf &
                LABEL_VAR_ENABLE_INTERNET & " : " & IIf(InternetEnable() = True, MSG_YES, MSG_NOT)
        Catch ex As Exception

        End Try

        Return TxtEntorn

    End Function

    Private Function testKey() As Boolean
        Dim client_id As Integer = Me.lbCientID.Text
        Dim client_key As String = Me.txtClientKey.Text
        'test si hi connexió a Internet
        If InternetEnable() = True Then
            If Cloud.TestClient(client_id, client_key) = True Then
                Me.lbCientID.Text = client_id
                setClientControls(True)
                Return True
            Else
                Me.lbCientID.Text = 0
                setClientControls(False)
                Return False
            End If

        Else
            Me.lbCientID.Text = 0
            LbClientKO.Visible = True
            LbClientOK.Visible = False
            cmdActive.Enabled = True
            Return False
        End If
    End Function

    Sub setClientControls(isClient As Boolean)

        LbClientKO.Visible = Not isClient
        LbClientOK.Visible = isClient
        cmdActive.Enabled = isClient
        chkOnLine.Checked = isClient
        If isClient = True Then
            TreeViewParams.Nodes(3).Nodes(0).ForeColor = Color.Black 'CLOUD
            If chk_sharePrograms.Checked = True Then
                TreeViewParams.Nodes(3).Nodes(0).Nodes(0).ForeColor = Color.Black 'Programes
            Else
                TreeViewParams.Nodes(3).Nodes(0).Nodes(0).ForeColor = Color.Gray
            End If
            TreeViewParams.Nodes(3).Nodes(1).ForeColor = Color.Black 'ftp
            TreeViewParams.Nodes(3).Nodes(2).ForeColor = Color.Black 'stream
        Else
            TreeViewParams.Nodes(3).Nodes(0).ForeColor = Color.Gray
            TreeViewParams.Nodes(3).Nodes(0).Nodes(0).ForeColor = Color.Gray
            TreeViewParams.Nodes(3).Nodes(1).ForeColor = Color.Gray
            TreeViewParams.Nodes(3).Nodes(2).ForeColor = Color.Gray
        End If

    End Sub


    Private Sub chkMltDBS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMltDBS.CheckedChanged
        MlpDBS = Me.chkMltDBS.Checked
        ChangeMltDBS = True
        Changed()
    End Sub

    Private Sub cmdAddAudio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddAudio.Click

        gridAudioFiles.AllowUserToAddRows = True
        gridAudioFiles.FirstDisplayedScrollingRowIndex = gridAudioFiles.NewRowIndex
        Me.gridAudioFiles.Rows(gridAudioFiles.NewRowIndex).Selected = True
        'Me.gridAudioFiles.Rows(gridAudioFiles.NewRowIndex).Cells(0).Value = 0
        Changed()
    End Sub

    Private Sub cmdDelAudio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelAudio.Click
        If gridAudioFiles.Rows.Count > 0 Then
            Me.gridAudioFiles.CurrentRow.DefaultCellStyle.BackColor = Color.Red
            Changed()
        End If
    End Sub

    Private Sub chkActvTabProgram_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkActvTabProgram.CheckedChanged
        change_Cartutx = True
        Changed()
    End Sub

    Private Sub cmbInPuts_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Changed()
    End Sub

    Private Sub cmdPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSenyHora.ButtonClick
        With OpenFileDialog1
            .Multiselect = False
            .Filter = "Mpeg Layer 3 (*.mp3)|*.mp3"
            '.InitDir = "C:\"
            .Title = MSG_BUSCAR
            If .ShowDialog = System.Windows.Forms.DialogResult.OK Then
                txtSenyHora.Text = .FileName
                change_MSCControler = True
                Changed()
            End If
        End With
    End Sub

    Private Sub sldMilSegSH_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.lbMilSegSH.Text = Me.sldMilSegSH.Value
        change_MSCControler = True
        Changed()
    End Sub

    'Private Sub sldSegIniLoad_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Me.lbSegIniLoad.Text = Me.sldSegIniLoad.Value
    '    Changed()
    'End Sub

    Private Sub chkForceHoraExect_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkForceHoraExect.CheckedChanged
        change_MSCDirecte = True
        Changed()
    End Sub

    Private Sub chkBorHistInterp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBorHistInterp.CheckedChanged
        change_MSCDirecte = True
        Changed()
    End Sub

    Private Sub cmdPathArrel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPathArrelAudio.ButtonClick
        FolderBrowserDialog1.Description = FolderBrowserDialog1_Description
        If FolderBrowserDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Me.txtPathArrelAudio.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub cmdAddLogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddLogo.Click
        Dim Filtre As String
        Filtre = FILTER_Mapa_bits & "(*.bmp)|*.bmp|"
        Filtre = Filtre + FILTER_IMATGES & " GIF(*.gif)|*.gif|"
        Filtre = Filtre + FILTER_IMATGES & " GPEG(*.jpg) |*.jpg"

        With OpenFileDialog1
            .Title = MSG_BUSCAR
            .Multiselect = False
            .Filter = Filtre
            If .ShowDialog = System.Windows.Forms.DialogResult.OK Then
                Me.imgLogo.Image = resizeImageFromPath(.FileName, MAX_WIDTH_LOGO, MAX_HEIDTH_LOGO)
                change_ParamsGenerals = True
                Changed()
            End If
        End With
    End Sub

    Private Sub cmdReparIDs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReparIDs.Click
        'TODO: Error en el procediment
        Dim Dt As DataTable
        Dim db As New MSC.dbs(Cloud)
        Dim NumModif As Integer
        Dim idMinDisc As Short
        On Error GoTo ErrorLine

        If MetroFramework.MetroMessageBox.Show(Me, MSG_OP_IRREVERSIBLE, MSG_ATENCIO, MessageBoxButtons.OKCancel, MessageBoxIcon.Error, 100) = DialogResult.Cancel Then Exit Sub
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.AppStarting
        Me.cmdExit.Enabled = False
        Me.mnuExit.Enabled = False
        cmdProgresCancel.Visible = True
        Cancelled = False
        Me.ProgressBar.Visible = True

        'Primerament tots els temes amb temInterpID = 0 el canviem a 1
        ProgressBar.Maximum = 50
        Dim NumProcces As Short = 1
        Dim MaxProcces As Short = 5
        Me.lbInfoProces.Text = String.Format(MSG_PROCCES_WORK, 1, 5)
        ProgressBar.Value = 25
        System.Windows.Forms.Application.DoEvents()
        NumModif = UpdateReparaIdsDepenets("temes", "tema_interp = 1", "tema_interp = 0")
        ProgressBar.Value = 50
        System.Windows.Forms.Application.DoEvents()
        '-------------------------------------------------------------
        'Repasar-nos tots i assegurar-nos que existeixen, sinó temInterpID = 1
        Dt = db.getTable("SELECT tema_id,tema_interp FROM temes ;")
        Me.lbInfoProces.Text = String.Format(MSG_PROCCES_WORK, 2, 5)
        ProgressBar.Maximum = Dt.Rows.Count
        ProgressBar.Value = 0
        For i As Integer = 0 To Dt.Rows.Count - 1
            If Dt.Rows(i)("tema_interp") = 0 Then
                Dim id As Integer = CInt(Dt.Rows(i)("tema_id"))
                NumModif = NumModif + UpdateReparaIdsDepenets("temes", "tema_interp = 1", "tema_id = " & id)
            End If
            ProgressBar.Value = i
            System.Windows.Forms.Application.DoEvents()
            If Cancelled Then GoTo ErrorLine
        Next
        '-------------------------------------------------------------
        'repasar-nos tots els temDiscID i assegurar-nos que existeix el dics, sinó temDiscID = 1

        'Trobar el primer disc de la llista                
        idMinDisc = db.ExecuteScalar("SELECT Min(disc_id) FROM discos ;")

        Dt = db.getTable("SELECT tema_id,tema_disc FROM temes ;")
        Me.lbInfoProces.Text = String.Format(MSG_PROCCES_WORK, 3, 5)
        ProgressBar.Maximum = Dt.Rows.Count
        ProgressBar.Value = 0
        For i As Integer = 0 To Dt.Rows.Count - 1
            If Dt.Rows(i)("tema_disc") = 0 Then
                Dim id As Integer = CInt(Dt.Rows(i)("tema_id"))
                NumModif = NumModif + UpdateReparaIdsDepenets("temes", "tema_disc = " & idMinDisc, "tema_id = " & id)
            End If
            ProgressBar.Value = i
            System.Windows.Forms.Application.DoEvents()
            If Cancelled Then GoTo ErrorLine
        Next


        '-------------------------------------------------------------
        'repasar-nos tots els discos i assegurar-nos que existeix el discosInterpID, sinó discosInterpID = 1        
        Dt = db.getTable("SELECT disc_id,disc_interpret FROM discos ;")
        Me.lbInfoProces.Text = String.Format(MSG_PROCCES_WORK, 4, 5)
        ProgressBar.Maximum = Dt.Rows.Count
        ProgressBar.Value = 0
        For i As Integer = 0 To Dt.Rows.Count - 1
            If Dt.Rows(i)("disc_interpret") = 0 Then
                Dim id As Integer = CInt(Dt.Rows(i)("disc_id"))
                NumModif = NumModif + UpdateReparaIdsDepenets("discos", "disc_interpret = 1 ", "disc_id = " & id)
            End If
            ProgressBar.Value = i
            System.Windows.Forms.Application.DoEvents()
            If Cancelled Then GoTo ErrorLine
        Next

        '------------------------------------------------------
        'repasar-nos tots les falques i assegurar-nos que existeix el tarifaID, sinó tarifaID = 1

        Dt = db.getTable("SELECT falc_id,falc_tarifa FROM falques")
        Me.lbInfoProces.Text = String.Format(MSG_PROCCES_WORK, 5, 5)
        ProgressBar.Maximum = Dt.Rows.Count
        ProgressBar.Value = 0

        For i As Integer = 0 To Dt.Rows.Count - 1
            If Dt.Rows(i)("falc_id") = 0 Then
                Dim id As Integer = CInt(Dt.Rows(i)("falc_id"))
                NumModif = NumModif + UpdateReparaIdsDepenets("falques", "falc_tarifa = 1 ", "falc_id = " & id)
            End If
            ProgressBar.Value = i
            System.Windows.Forms.Application.DoEvents()
            If Cancelled Then GoTo ErrorLine
        Next

        '------------------------------------------------------        
        Dt = Nothing
        db = Nothing

        Me.ProgressBar.Visible = False
        Me.lbInfoProces.Text = ""
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Me.cmdExit.Enabled = True
        Me.mnuExit.Enabled = True
        cmdProgresCancel.Visible = False
        MetroFramework.MetroMessageBox.Show(Me, String.Format(MSG_END_ROWS_AFECTED, NumModif), My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Information, 100)
        Exit Sub
ErrorLine:
        Me.ProgressBar.Visible = False
        Me.lbInfoProces.Text = ""
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Me.cmdExit.Enabled = True
        Me.mnuExit.Enabled = True
        cmdProgresCancel.Visible = False
        MetroFramework.MetroMessageBox.Show(Me, MSG_CANCELED, My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Information, 100)

    End Sub


    Public Function UpdateReparaIdsDepenets(ByRef Taula As String, ByRef StrSet As String, ByRef strWhere As String) As Integer
        Dim StrSql As String

        StrSql = "UPDATE " & Taula
        StrSql = StrSql & " SET "
        StrSql = StrSql & StrSet

        StrSql = StrSql & " WHERE " & strWhere & " ;"
        Dim db As New MSC.dbs(Cloud)
        Dim ret As Integer = db.Update_ID(StrSql)
        db = Nothing
        Return ret
    End Function

    Private Sub cmdProgresCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdProgresCancel.Click
        Cancelled = True
    End Sub

    Private Sub cmdSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalvar.Click
        If MetroFramework.MetroMessageBox.Show(Me, MSG_MODIF_PARAM, My.Application.Info.AssemblyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, 100) = DialogResult.OK Then SaveRecord()
    End Sub

    Private Sub SaveRecord()

        If Not MyAPP.PermisPerContinuar() Then MetroFramework.MetroMessageBox.Show(Me, MSG_SERVER_CLOSE, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Stop, 100) : Me.Close()

        If change_IntegraWeb = True Then
            Params.NumTracsVotWeb = txtNumTracs.Text
            Params.NumVotWebTorn = txtNumVots.Text
        End If

        If change_MSCControler = True Then
            Params.PathSenyalHora = Me.txtSenyHora.Text
            Params.MilSegSH = sldMilSegSH.Value
        End If

        If change_SistemDades = True Then
            'Salva Autobackup
            If Me.chkLastBKP.Checked = True Then
                Params.LastBackup = Now.AddDays(-24)
            Else
                Params.LastBackup = Now.AddYears(10)
            End If
        End If


        If change_ParamsGenerals = True Then
            Params.NomRadio = Me.txtNomRadio.Text
            Params.Web = Me.txtWeb.Text
            Params.LogoEmpresa = imgLogo.Image
            Params.FaceBook = Me.txtFaceBook.Text
            Params.Twitter = Me.txtTwitter.Text
            Params.TwitterKey = Me.txtTwitterKey.Text
            Params.ProgramacioDefecte = cmbTipProg.SelectedValue
            Params.CommentDesconnexio = Me.txtComentDesconnexio.Text
            Params.Lang = Me.cmbLang.SelectedValue
            Dim NomCarpBlocs() As String = Nothing
            Dim d As Integer = 0
            For i As Short = 0 To Me.grupCarpBlocs.Controls.Count - 1
                If grupCarpBlocs.Controls(i).Text.Length > 0 Then
                    ReDim Preserve NomCarpBlocs(d)
                    NomCarpBlocs(d) = grupCarpBlocs.Controls(i).Text
                    d += 1
                End If
            Next i
            Params.NomsCarpetaBlocs = Join(NomCarpBlocs, ",")

            Dim NomCarpAudioUser() As String = Nothing
            d = 0
            For i As Short = 0 To Me.FlowLayoutPanelCarpetes.Controls.Count - 1
                If FlowLayoutPanelCarpetes.Controls(i).Text.Length > 0 Then
                    ReDim Preserve NomCarpAudioUser(d)
                    NomCarpAudioUser(d) = FlowLayoutPanelCarpetes.Controls(i).Text
                    d += 1
                End If
            Next i
            Params.NomsCarpetaAudiosUser = Join(NomCarpAudioUser, ",")

            Params.OnLine = chkOnLine.Checked
        End If

        If change_SequenciPautes = True Then
            Params.Sequencia_Programs = Me.ComboBoxSequencies.SelectedValue
        End If

        If change_Moneda = True Then
            Params.Moneda = cmbMoneda.SelectedValue
            Params.ContraValor = cmbContraValor.SelectedValue
            Params.Canvi = CDbl(Me.txtCanvi.Text)
            Params.DaysDateOut = Me.txtVDEF_DateOut.Text
            Params.TarifaDef = Me.ComboBoxVDef_tarifa.SelectedValue
        End If


        If change_Cartutx = True Then
            'Cartutxeres
            Params.ActvTabProgram = chkActvTabProgram.Checked
            Params.CtlUsrCartut = chkCTL_USR_Cartux.Checked
        End If

        If change_ReglesMusic = True Then
            Params.HoresTop = CShort(txtHTop.Text)
            Params.HoresHitTop = CShort(Me.txtHHitTop.Text)
            Params.HoresHit = CShort(Me.txtHHit.Text)
            Params.HoresOld = CShort(Me.txtOld.Text)
            Params.HoresOldTop = CShort(Me.txtHOldTop.Text)
            Params.HoresBorrInterp = Me.txtHBorrInterp.Text
            Params.IntervRitme = Me.txtIntervRitme.Text
            Params.MinutsDiscProhivit = txtMinusProhivDisc.Text
            Params.CanviCat = Me.chkCanviCat.Checked
            Params.NTopHit = Me.txtNTopHit.Text
            Params.NHitOld = Me.txtNHitOld.Text
            Params.MaxRadiTop = txtMaxRadiTop.Text
            Params.MaxRadiHit = txtMaxRadiHIT.Text
            Params.MaxRadiOld = txtMaxRadiOLD.Text

        End If

        If change_Emergencies = True Then
            'Servei d'emergència
            Params.ActvSrvEmergenci = Me.CheckBoxActiveSOS.Checked
            Params.ErrEmail = Me.txtMailDesti.Text
            Params.SendToDevelop = Me.chk_SendDevelop.Checked
        End If

        If change_DirMagatzem = True Then
            Params.PathArrelAudios = Me.txtPathArrelAudio.Text
            INIFile.INIWrite(MyAPP.IniFile, "Data Control", "AlternativeDir", Me.txtAternativeDir.Text)
        End If

        If change_MSCDirecte = True Then
            'Params.SegIniLoad = sldSegIniLoad.Value
            Params.MSegOClock = sldMSegOClok.Value
            Params.FHExacte = chkForceHoraExect.Checked
            Params.BorInterpIni = chkBorHistInterp.Checked
        End If

        If change_CtlRemot = True Then
            'Control Remot
            Params.RemitentCR = txtRemitentCR.Text
            Params.MailServerCR = txtServerMailCR.Text
            Params.UserNameCR = txtUsuariCR.Text
            Params.PasswordCR = txtPasswordCR.Text
            Params.intervalCR = Me.txtIntervalCR.Text
        End If

        If change_CtlUsers = True Then
            'Conrol Usuaris
            Params.IntentsUsers = Me.txtIntentsUSR.Text
            Params.TempPasPoxConex = Me.txtMaxTemps.Text
            Params.AtvPSW = Me.chkCtlPsw.Checked
        End If

        If change_Streaming = True Then
            'Streaming            
            Params.StreamStyle = Me.txtEstil.Text
        End If

        If change_EncoderAudio = True Then
            'Secció Codificació Àudio (Importacions del ripper)		
            Params.BitRate = cmbCodecBitrate.Text
            Params.SampleRate = Me.cmbCodecSampleRate.Text
            Params.Channels = Me.cmbCodecAudioChannel.Text
            Params.FilesActives = chkVDef_activats.Checked
            Params.ID3Tag = chkCaptureTag.Checked
        End If

        If change_ConnexCentral = True Then
            Params.VolFader = sldVolfader.Value
            Params.MilFader = sldMilFader.Value
        End If


        Params.SaveParams(change_Cartutx, change_ConnexCentral, change_CtlRemot, change_CtlUsers, change_DirMagatzem, change_Emergencies, change_EncoderAudio, change_IntegraWeb, change_Moneda, change_MSCControler, change_MSCDirecte, change_ParamsGenerals, change_ReglesMusic, change_SequenciPautes, change_SistemDades, change_Streaming)
        'salva el llistat de tipus d'audio        

        Dim db As New MSC.dbs(Cloud)
        Dim StrSql As String

        For i As Integer = 0 To Me.gridAudioFiles.Rows.Count - 1
            If Me.gridAudioFiles.Rows(i).DefaultCellStyle.BackColor = Color.Green Then
                Dim psNom As String = AddSlashes(Me.gridAudioFiles.Rows(i).Cells("Column_nom").Value.ToString)
                Dim cart As Integer = Me.gridAudioFiles.Rows(i).Cells("ColumnCarp").Value
                Dim pbVisible_cart As Boolean = Me.gridAudioFiles.Rows(i).Cells("Column_visible_cart").Value
                Dim pbVisible_cont As Boolean = Me.gridAudioFiles.Rows(i).Cells("ColumnVisible_cont").Value
                Dim pbIsEnding As Boolean = Me.gridAudioFiles.Rows(i).Cells("ColumnEnding").Value
                Dim img_id As Integer = Me.gridAudioFiles.Rows(i).Cells("ColumnImageid").Value
                Dim is_ph As Boolean = Me.gridAudioFiles.Rows(i).Cells("Columnph").Value
                If IsNumeric(Me.gridAudioFiles.Rows(i).Cells("Column_id").Value) = True Then
                    'update
                    Dim pi_id As Integer = Me.gridAudioFiles.Rows(i).Cells("Column_id").Value
                    StrSql = "UPDATE listaudio  SET "
                    StrSql = StrSql & " audio_nom = '" & psNom & "'"
                    StrSql = StrSql & " , audio_visible_cart = " & CShort(IIf(pbVisible_cart, 1, 0))
                    StrSql = StrSql & " , audio_visible_cont = " & CShort(IIf(pbVisible_cont, 1, 0))
                    StrSql = StrSql & " , audio_carpeta = " & cart.ToString
                    StrSql = StrSql & " , audio_is_ending = " & CShort(IIf(pbIsEnding, 1, 0))
                    StrSql = StrSql & " , audio_is_ph = " & CShort(IIf(is_ph, 1, 0))
                    StrSql = StrSql & " , audio_image = " & img_id.ToString
                    StrSql = StrSql & " WHERE audio_id = " & pi_id & " ;"

                    db.Update_ID(StrSql)
                Else
                    'Insert
                    StrSql = "INSERT INTO listaudio (audio_nom, audio_visible_cart, audio_visible_cont, audio_carpeta, audio_is_ending, audio_image,audio_is_ph)"
                    StrSql = StrSql & " VALUES "
                    StrSql = StrSql & " ( '" & psNom & "', " & CShort(IIf(pbVisible_cart, 1, 0)) & "," & CShort(IIf(pbVisible_cont, 1, 0)) & ", " & cart.ToString & ", " & CShort(IIf(pbIsEnding, 1, 0)) & ", " & img_id.ToString & ", " & CShort(IIf(is_ph, 1, 0)) & " );"

                    Dim new_id As Integer = db.New_ID(StrSql)
                    Me.gridAudioFiles.Rows(i).Cells("Column_id").Value = new_id
                    StrSql = "ALTER TABLE botonsurs ADD COLUMN boto_au" & new_id & " TINYINT(1) NOT NULL DEFAULT 0 ;"
                    db.New_ID(StrSql)
                End If
            ElseIf Me.gridAudioFiles.Rows(i).DefaultCellStyle.BackColor = Color.Red Then
                Dim pi_id As Integer = Me.gridAudioFiles.Rows(i).Cells("Column_id").Value
                StrSql = "DELETE FROM listaudio WHERE audio_id=" & pi_id

                db.Delete_ID(StrSql)
                StrSql = "ALTER TABLE botonsurs DROP COLUMN boto_au" & pi_id & " ;"
                db.Delete_ID(StrSql)
                addCtlRadi(0, CShort(Tipus_Play.CTL_SQL), 0, "00:00:00", 0, 0, Usuari.UsrID, StrSql, 0, False)

            End If
        Next i
        ListAudioUser()
        RefreshDataSet(TAULES_DBS.TAULA_LIST_AUDIO_USERS)
        'frmMain.CarregaListAudio()


        'salvar Valors per defecte del logger
        StrSql = "UPDATE prglogger SET "
        StrSql = StrSql & " log_bitrate = '" & Me.cmbBitrate.Text & "'"
        StrSql = StrSql & ", log_samplerate = '" & Me.cmbSampleRate.Text & "'"
        StrSql = StrSql & ", log_defrec = " & CShort(IIf(Me.chkRecord.Checked, 1, 0))
        StrSql = StrSql & ", log_canals = " & Me.cmbAudioChannel.SelectedIndex + 1
        StrSql = StrSql & ", log_durada = '" & ComboBoxDuradaDef.Text & "'"

        StrSql = StrSql & " WHERE log_id = 1 ;"
        db.Update_ID(StrSql)

        Dim e As Short
        If ChangeMltDBS Then
            'Salvar les múltiples DBS
            INIFile.INIWrite(MyAPP.IniFile, "Data key", "MLP_DBS", IIf(Me.chkMltDBS.Checked, 1, 0))
            Dim CLIENT_SECRET_KEY As String = INIFile.INIRead(MyAPP.IniFile, "Data key", "CLIENT_SECRET_KEY", "")
            'S'ha de borrar tot l'apatat 'Date Files' per despés tornar-lo a ecriure'l
            INIFile.INIDelete(MyAPP.IniFile, "Data Files")
            For i As Integer = 0 To Me.lstDBS.Items.Count - 1
                If Not IsNothing(DBS_Col) AndAlso Not DBS_Col(i).blDelete Then
                    INIFile.INIWrite(MyAPP.IniFile, "Data Connect", "DB_Descrip" & e, DBS_Col(i).DescripDBS) ': lstDBS.Items.Add(DBS_Col(i).DescripDBS) ' VB6.SetItemString(Me.lstDBS, i - 1, DBS_Col(i).DescripDBS))
                    INIFile.INIWrite(MyAPP.IniFile, "Data Connect", "DB_NAME" & e, DBS_Col(i).NomDBS)
                    INIFile.INIWrite(MyAPP.IniFile, "Data Connect", "DB_SERVER" & e, DBS_Col(i).HostDBS)
                    INIFile.INIWrite(MyAPP.IniFile, "Data Connect", "DB_PORT" & e, DBS_Col(i).PortDBS)
                    INIFile.INIWrite(MyAPP.IniFile, "Data Connect", "DB_USER" & e, EncryptRJ256(Cloud.MSC_PRI_SECRET_KEY, CLIENT_SECRET_KEY, DBS_Col(i).UsrDBS))
                    INIFile.INIWrite(MyAPP.IniFile, "Data Connect", "DB_PSW" & e, EncryptRJ256(Cloud.MSC_PRI_SECRET_KEY, CLIENT_SECRET_KEY, DBS_Col(i).PswDBS))
                    e = e + 1
                End If
            Next
        End If

        If SeqValorsChanged = True Then
            For z As Integer = 0 To SeqPau.Length - 1
                Dim Nom As String = SeqPau(z).Seq_Nom
                Dim Valors As String = ""
                If SeqPau(z).seq_Valors IsNot Nothing Then
                    For i As Integer = 0 To SeqPau(z).seq_Valors.Length - 1
                        If SeqPau(z).seq_Valors(i) > 0 Then
                            If Valors.Length > 0 Then Valors = Valors & ","
                            Valors = Valors & SeqPau(z).seq_Valors(i)
                        End If
                    Next
                    If SeqPau(z).Seq_NEW = True Then
                        'INSERT
                        StrSql = "INSERT INTO sequencia_pauta SET seq_nom='" & Nom & "', seq_valors='" & Valors & "'"
                    Else
                        'UPDATE
                        Dim seq_ID As Integer = SeqPau(z).Seq_ID
                        StrSql = "UPDATE sequencia_pauta SET  seq_nom = '" & Nom & "', seq_valors='" & Valors & "' WHERE seq_id=" & seq_ID & ";"
                    End If
                    db.ExecuteInstruc(StrSql)
                End If
            Next
        End If
        db = Nothing
        LokedControls()
        lbSaved.Visible = True
    End Sub

    Private Sub txtHTop_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPermanenciaPodcast.KeyPress, txtOld.KeyPress, txtNumVots.KeyPress, txtNumTracs.KeyPress, txtNTopHit.KeyPress, txtNHitOld.KeyPress, txtMaxRadiTop.KeyPress, txtMaxRadiOLD.KeyPress, txtMaxRadiHIT.KeyPress, txtIntervRitme.KeyPress, txtHTop.KeyPress, txtHOldTop.KeyPress, txtHHitTop.KeyPress, txtHHit.KeyPress, txtHBorrInterp.KeyPress



        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        If KeyAscii < Asc("0") Or KeyAscii > Asc("9") Then If KeyAscii <> 8 Then KeyAscii = 0
        e.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtCanvi_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCanvi.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        If KeyAscii = 44 Or KeyAscii = 46 Then
            KeyAscii = 44
        ElseIf KeyAscii < Asc("0") Or KeyAscii > Asc("9") Then
            If KeyAscii <> 8 Then KeyAscii = 0
        End If
        e.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            e.Handled = True
        End If

    End Sub



    Private Sub cmbMoneda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMoneda.SelectedIndexChanged, cmbContraValor.SelectedIndexChanged
        change_Moneda = True
        Changed()
    End Sub

    Private Sub cmdAddCarpBlocs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddCarpBlocs.Click
        Dim NouTxt As New TextBox
        NouTxt.Parent = Me.grupCarpBlocs
        AddHandler NouTxt.TextChanged, AddressOf ParamsGenerals_TextChanged
    End Sub

    Private Sub chkCTL_USR_Cartux_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCTL_USR_Cartux.CheckedChanged
        change_Cartutx = True
        Changed()
    End Sub

    Private Sub txtServerFTP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtServerFTP.TextChanged, txtUserFTP.TextChanged, txtPswFTP.TextChanged, txtDirFTP.TextChanged
        change_IntegraWeb = True
        Changed()
    End Sub

    Private Sub cmdTestFTP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTestFTP.Click

        'TODO: transforma la URL a IP i connectar per aquesta.
        'Dim IPEntry As IPHostEntry = Dns.GetHostAddresses(Me.txtServerFTP.Text)		
        'Dim client As FtpClient = New FtpClient(IPEntry, Me.txtUserFTP.Text, txtPswFTP.Text)

        Dim client As FtpClient = New FtpClient("Ftp://" & Me.txtServerFTP.Text.ToLower, Me.txtUserFTP.Text, txtPswFTP.Text)
        Dim dirFTP As FtpDirectory = client.ListDirectory()
        If dirFTP Is Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, MSG_FTP_ERROR_CONNECT & " " & client.ErrorDescrip, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
        Else
            MetroFramework.MetroMessageBox.Show(Me, MSG_FTP_CONNECT_OK, My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Information, 100)
        End If
        dirFTP = Nothing
        client = Nothing
    End Sub

    Private Sub ListBoxSequencies_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBoxSequencies.SelectedIndexChanged
        Dim seq_index As Integer = ListBoxSequencies.SelectedIndex
        If SeqPau(seq_index).seq_Valors Is Nothing Then Exit Sub
        Dim Valors() As Integer = SeqPau(seq_index).seq_Valors
        DataGridViewValorsSequ.DataSource = getDTFromArray(Valors)
        cmdSalvar.Enabled = False
    End Sub

    Private Function getDTFromArray(ByVal ValArray() As Integer) As DataTable
        Dim dt As DataTable
        dt = New DataTable
        With dt
            Dim column As DataColumn = New DataColumn
            column.DataType = System.Type.GetType("System.Decimal")
            column.AllowDBNull = False
            column.ColumnName = "columnaID"
            column.DefaultValue = 1

            .Columns.Add(column)

            For i As Integer = 0 To ValArray.Length - 1
                Dim row As DataRow
                Try
                    If CInt(ValArray(i)) > 0 Then
                        row = .NewRow() : row("columnaID") = CInt(ValArray(i)) : .Rows.Add(row)
                    End If
                Catch ex As Exception
                End Try
            Next
            Return dt
        End With

    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.DataGridViewValorsSequ.AllowUserToAddRows = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DataGridViewValorsSequ.AllowUserToDeleteRows = True
        Try
            Dim row As DataGridViewRow = DataGridViewValorsSequ.CurrentRow
            DataGridViewValorsSequ.Rows.Remove(row)
        Catch ex As Exception
        End Try
        DataGridViewValorsSequ.AllowUserToDeleteRows = False
        OmpleValorsSequencia()
    End Sub

    Private Sub OmpleValorsSequencia()
        Dim Index_Seq As Integer = ListBoxSequencies.SelectedIndex
        ReDim SeqPau(Index_Seq).seq_Valors(DataGridViewValorsSequ.Rows.Count)
        For i As Integer = 0 To DataGridViewValorsSequ.RowCount - 1
            If DataGridViewValorsSequ.Rows(i).Cells(0).Value > 0 Then
                SeqPau(Index_Seq).seq_Valors(i) = DataGridViewValorsSequ.Rows(i).Cells(0).Value
            End If
        Next
        Changed()
        SeqValorsChanged = True

    End Sub

    Private Sub cmdAddSequenc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddSequenc.Click

        Dim NomSeq As String = InputBox(INBOX_NOM_SEQUENCIA, NOVA_SEQUENCIA, "")
        If NomSeq.Length = 0 Then Exit Sub
        ReDim Preserve SeqPau(SeqPau.Length)
        SeqPau(SeqPau.Length - 1).Seq_ID = 0
        SeqPau(SeqPau.Length - 1).Seq_Nom = NomSeq
        SeqPau(SeqPau.Length - 1).Seq_NEW = True
        Do Until Me.DataGridViewValorsSequ.Rows.Count = 0
            Dim row As DataGridViewRow = DataGridViewValorsSequ.Rows(0)
            DataGridViewValorsSequ.Rows.Remove(row)
        Loop
        DataGridViewValorsSequ.AllowUserToAddRows = True
        DataGridViewValorsSequ.Select()
        ListBoxSequencies.SelectedIndex = ListBoxSequencies.Items.Add(NomSeq)
        lbNovaSequ.Visible = True
        SeqValorsChanged = True
        Changed()
    End Sub

    Private Sub cmdDelSequenc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelSequenc.Click

        Dim Seq_Id As Integer = SeqPau(ListBoxSequencies.SelectedIndex).Seq_ID

        If Seq_Id = 1 Then MetroFramework.MetroMessageBox.Show(Me, MSG_SEQUENCIA_NO_DELETE_DEF, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100) : Exit Sub
        If Seq_Id = ComboBoxSequencies.SelectedValue Then MetroFramework.MetroMessageBox.Show(Me, MSG_SEQUENCIA_NO_DELETE_USING, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100) : Exit Sub

        Dim db As New MSC.dbs(Cloud)
        Dim StrSql As String = "DELETE FROM sequencia_pauta WHERE seq_id=" & Seq_Id & ";"
        db.Delete_ID(StrSql)
        addCtlRadi(0, CShort(Tipus_Play.CTL_SQL), 0, "00:00:00", 0, 0, Usuari.UsrID, StrSql, 0, False)
        ompleSeqLlistat()
        db = Nothing
    End Sub

    Private Sub CheckBoxActiveSOS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxActiveSOS.CheckedChanged
        Me.grupActiveSos.Enabled = Me.CheckBoxActiveSOS.Checked
        change_Emergencies = True
        Changed()
    End Sub

    Private Sub cmdTestMailErr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTestMailErr.Click
        'Envia correu d'emergència
        'Dim AssumpteTxt As String = Params.NomRadio & " Prg:" & My.Application.Info.AssemblyName
        Dim AssumpteTxt As String = My.Application.Info.AssemblyName

        Dim BodyTxt As String = " Aplic: " & My.Application.Info.AssemblyName & " V" & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build & vbCrLf
        BodyTxt = BodyTxt & " Descrip: " & MSG_TEST_MAIL_ERROR_BODY & vbCrLf
        BodyTxt = BodyTxt & " Date: " & Now.ToString("yyyy-MM-dd HH:mm:ss") & vbCrLf
        Dim MailTo As String = txtMailDesti.Text

        If IsEmail(MailTo) = False Then
            MetroFramework.MetroMessageBox.Show(Me, MSG_TEST_MAIL_ERROR_MAIL, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
            txtMailDesti.Focus()
            Exit Sub
        End If
        Dim message As New MailMessage(MSC.Help.FROM_EMAIL_MSC.ToString, MailTo, AssumpteTxt, BodyTxt)
        Dim emailClient As New SmtpClient(MSC.Help.EMAIL_SERVER_MSC.ToString)
        emailClient.Credentials = New Net.NetworkCredential(MSC.Help.FROM_EMAIL_MSC.ToString, MSC.Help.PSW_FROM_EMAIL_MSC.ToString)
        emailClient.Port = MSC.Help.EMAIL_SERVER_PORT_MSC.ToString
        Try
            emailClient.Send(message)
            'TODO: mostrar missatge OK
        Catch ex As Exception
            'TODO: mostrar missatge KO
        End Try

        '        Dim SmtpServer As New SmtpClient()
        '        Dim mail As New MailMessage()
        '        SmtpServer.Credentials = New _
        'Net.NetworkCredential("username@gmail.com", "password")
        '        SmtpServer.Port = 587
        '        SmtpServer.Host = "smtp.gmail.com"
        '        mail = New MailMessage()
        '        mail.From = New MailAddress("YOURusername@gmail.com")
        '        mail.To.Add("TOADDRESS")
        '        mail.Subject = "Test Mail"
        '        mail.Body = "This is for testing SMTP mail from GMAIL"
        '        SmtpServer.Send(mail)
    End Sub

    Private Sub ComboBoxListAplic_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxListAplic.SelectedIndexChanged

        Dim columID As String = "ir_ID"
        Dim columNom As String = "ir_nom"
        Dim taula As DataTable = InstruccionsRemotes(ComboBoxListAplic.SelectedValue)

        With ComboBoxRemoteInstruc
            .DataSource = taula
            .DisplayMember = columNom
            .ValueMember = columID
        End With
    End Sub

    Private Sub txtCodiCR_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIntervalCR.KeyPress, txtCodiCR.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        If KeyAscii < Asc("0") Or KeyAscii > Asc("9") Then If KeyAscii <> 8 Then KeyAscii = 0
        e.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            e.Handled = True
        End If

    End Sub

    Private Sub ButtonAddInstrucioCR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAddInstrucioCR.Click
        If IsNumeric(Me.txtCodiCR.Text) = False Then
            MetroFramework.MetroMessageBox.Show(Me, MSG_CONTROL_REMOT_CODI, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
            txtCodiCR.Focus()
            Return
        ElseIf ComboBoxListAplic.SelectedValue = 0 Then
            MetroFramework.MetroMessageBox.Show(Me, MSG_CONTROL_REMOT_DESTI, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
            ComboBoxListAplic.Focus()
            Return
        ElseIf ComboBoxRemoteInstruc.SelectedValue = 0 Then
            MetroFramework.MetroMessageBox.Show(Me, MSG_CONTROL_REMOT_INSTRUCCIO, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
            ComboBoxRemoteInstruc.Focus()
            Return
        End If

        Dim db As New MSC.dbs(Cloud)
        Dim Codi As Integer = CInt(Me.txtCodiCR.Text)
        Dim App As Integer = CInt(ComboBoxListAplic.SelectedValue)
        Dim Instruc As Integer = CInt(ComboBoxRemoteInstruc.SelectedValue)
        Dim Descrip As String = AddSlashes(Me.txtDescripCR.Text)
        Dim StrSql As String = "INSERT INTO listinstruccions " &
            "(instruc_id, instruc_app, instruc_accio,instruc_descrip) VALUES " &
            "(" & Codi & ", " & App & ", " & Instruc & ",'" & Descrip & "' );"
        db.New_ID(StrSql)
        'Afegim el registre al llistat
        'Dim row As DataGridViewRow = New DataGridViewRow()
        'row.CreateCells(DataGridViewInstruccionsCR)

        'row.Cells(0).Value = Codi
        'row.Cells(1).Value = App
        'row.Cells(2).Value = Instruc
        'row.Cells(3).Value = Descrip
        'DataGridViewInstruccionsCR.Rows.Add(row)
        Me.DataGridViewInstruccionsCR.DataSource = db.getTable("SELECT * FROM `listinstruccions`;")
        db = Nothing

    End Sub

    Private Sub ButtonDelInstruccio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDelInstruccio.Click

        Dim id As Integer = 0
        If DataGridViewInstruccionsCR.SelectedRows.Count = 0 Then
            MetroFramework.MetroMessageBox.Show(Me, MSG_CONTROL_REMOT_DEL, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
            Return
        End If
        id = CInt(DataGridViewInstruccionsCR.SelectedRows(0).Cells("ColumnCodi").Value)
        Dim db As New MSC.dbs(Cloud)
        Dim StrSql As String = "DELETE FROM listinstruccions WHERE instruc_id=" & id & ";"
        Dim Afect As Integer = db.Delete_ID(StrSql)
        addCtlRadi(0, CShort(Tipus_Play.CTL_SQL), 0, "00:00:00", 0, 0, Usuari.UsrID, StrSql, 0, False)
        If Afect > 0 Then Me.DataGridViewInstruccionsCR.DataSource = db.getTable("SELECT * FROM `listinstruccions`;")
        db = Nothing
    End Sub

    Private Sub txtCodiCR_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIntervalCR.LostFocus, txtCodiCR.LostFocus

        If Not IsNumeric(CType(sender, TextBox).Text) Then
            CType(sender, TextBox).Text = 0
        End If
    End Sub

    Private Sub cmdActive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdActive.Click
        Dim db As New MSC.dbs(Cloud)
        Dim StrSql As String = ""

        If txtClientKey.Text.Length > 10 AndAlso Me.lbCientID.Text = 0 Then
            'S'ha de salvar la nova clau entrada
            Dim client_key As String = Me.txtClientKey.Text
            Dim user As String = getMD5Hash(Params.NomRadio)
            Dim cl_id As Integer = Cloud.Register(client_key, user, Params.Lang, GENERAL_VERSION)
            Me.lbCientID.Text = cl_id.ToString
            Me.chkOnLine.Checked = True

            StrSql = "UPDATE config_params SET params_valor='" & Me.lbCientID.Text & "' WHERE params_id=" & CONFIG.paramClientID & " ;"
            db.Update_ID(StrSql)
            StrSql = "UPDATE config_params SET params_valor= HEX(AES_ENCRYPT('" & Me.txtClientKey.Text & "','" & Cloud.MSC_PRI_SECRET_KEY & "')) WHERE params_id=" & CONFIG.paramClientKey & " ;"
            db.Update_ID(StrSql)
            If Cloud.TestClient(cl_id, client_key) = False Then
                StrSql = "UPDATE config_params SET params_valor='0' WHERE params_id=" & CONFIG.paramClientID & " ;"
                db.Update_ID(StrSql)
                StrSql = "UPDATE config_params SET params_valor='' WHERE params_id=" & CONFIG.paramClientKey & " ;"
                db.Update_ID(StrSql)
                MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_KEY, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
                txtClientKey.Text = ""
            End If
        End If
        db = Nothing
    End Sub

    Private Sub txtMailDesti_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMailDesti.TextChanged
        change_Emergencies = True
        Changed()
    End Sub

    Private Sub ompleSeqLlistat()
        ListBoxSequencies.Items.Clear()
        Dim db As New MSC.dbs(Cloud)
        Dim dt_seq As DataTable = db.getTable("SELECT * FROM `sequencia_pauta`")
        SeqPau = Nothing
        For i As Integer = 0 To dt_seq.Rows.Count - 1
            ReDim Preserve SeqPau(i)
            SeqPau(i).Seq_ID = dt_seq.Rows(i)("seq_id")
            SeqPau(i).Seq_Nom = dt_seq.Rows(i)("seq_nom")
            SeqPau(i).Seq_NEW = False
            ListBoxSequencies.Items.Add(SeqPau(i).Seq_Nom)
            Dim valorsArray() As String = Split(dt_seq.Rows(i)("seq_valors"), ",")
            ReDim Preserve SeqPau(i).seq_Valors(valorsArray.Length - 1)
            For n As Integer = 0 To valorsArray.Length - 1
                SeqPau(i).seq_Valors(n) = CInt(valorsArray(n))
            Next
        Next
        Dim cmb As New combo
        cmb.OmpleCombo(ColumnValors, TAULES_DBS.TAULA_TIPUS_PLAY, TotsCap.NO_ADD)
        cmb.OmpleCombo(ComboBoxSequencies, TAULES_DBS.TAULA_SEQUENCIES_PAUTA, TotsCap.NO_ADD)
        'OmpleCombo(ListBoxSequencies, TAULES_DBS.TAULA_SEQUENCIES_PAUTA, TotsCap.NO_ADD)
        ComboBoxSequencies.SelectedValue = Params.Sequencia_Programs
        db = Nothing
    End Sub

    Private Sub DataGridViewValorsSequ_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewValorsSequ.CellEndEdit
        OmpleValorsSequencia()
    End Sub


    Private Sub LinkLbMySql_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLbMySql.LinkClicked, LinkLbLame.LinkClicked, LinkLbBass.LinkClicked, linkLabelJamendo.LinkClicked, LinkLabel1.LinkClicked
        Dim url As String = CType(sender, LinkLabel).Text
        Dim Proces As Process = New Process
        Try
            Process.Start(url)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmbTipProg_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipProg.SelectedIndexChanged
        Select Case cmbTipProg.SelectedValue
            Case Tipus_Emissio.TIP_AUTOMATIC
                Me.lbInfo.Visible = False
                lbRadForm.Visible = True
                Me.txtComentDesconnexio.Visible = False
                Me.lbCommentDesconnexio.Visible = False
            Case Tipus_Emissio.TIP_CONEX_CENTRAL
                lbRadForm.Visible = False
                Me.lbInfo.Visible = True
                Me.lbInfo.Text = MSG_SYSTEM_STANBY_CENTRAL
                Me.txtComentDesconnexio.Visible = True
                Me.lbCommentDesconnexio.Visible = True
        End Select
        change_ParamsGenerals = True
        Changed()
    End Sub

    Private Sub cmdBorrHistori_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrHistori.Click
        If MetroFramework.MetroMessageBox.Show(Me, MSG_DELETE_HISTORY, MSG_ATENCIO, MessageBoxButtons.OKCancel, MessageBoxIcon.Error, 100) = DialogResult.Cancel Then Exit Sub

        Dim sCmd As String = "DELETE FROM erroruser WHERE errusr_data < '" & Now.AddDays(-30).ToString("yyyy-MM-dd HH:mm:ss") & "';"
        Dim db As New MSC.dbs(Cloud)
        db.Delete_ID(sCmd)
        addCtlRadi(0, CShort(Tipus_Play.CTL_SQL), 0, "00:00:00", 0, 0, Usuari.UsrID, sCmd, 0, False)
        db = Nothing
        listURSErr.Items.Clear()
        RefreshListConnexErr()
    End Sub

    Private Sub RefreshListConnexErr()
        Dim id, Nintent As Short
        Dim Nick, PSW As String
        Dim DataErr As Date

        Dim db As New MSC.dbs(Cloud)

        Dim sCmd As String = "SELECT * FROM erroruser;"
        Dim rsusrErr As DataTable = db.getTable(sCmd)
        Dim row As DataRow
        For Each row In rsusrErr.Rows
            id = CShort(row(0))
            Nick = NoNul(row(1).ToString)
            PSW = NoNul(row(2).ToString)
            Nintent = CShort(row(3))
            DataErr = CDate(NoNul(row(4)))
            AddElementList(id, Nick, PSW, Nintent, DataErr)
        Next row
        db = Nothing
        rsusrErr.Dispose()
    End Sub

    Private Sub AddElementList(ByRef id As Short, ByRef Nick As String, ByRef PSW As String, ByRef NIntents As Short, ByRef DataErr As Date)
        Dim ElementX As System.Windows.Forms.ListViewItem
        Dim subElementoX As System.Windows.Forms.ListViewItem.ListViewSubItem ' subelement
        ElementX = Me.listURSErr.Items.Add(Nick)
        ElementX.Tag = CStr(id)
        subElementoX = ElementX.SubItems.Add(PSW)
        subElementoX = ElementX.SubItems.Add(CStr(NIntents))
        subElementoX = ElementX.SubItems.Add(CStr(DataErr))
    End Sub

    Private Sub scrollMaxtemps_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles scrollMaxtemps.Scroll
        Me.txtMaxTemps.Text = TimeSerial(0, 360 - scrollMaxtemps.Value, 0)
        change_CtlUsers = True
        Changed()
    End Sub

    Private Sub chkCtlPsw_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCtlPsw.CheckedChanged
        Dim colec() As DataRow = dsClient.Tables("users").Select("")
        If colec.Length = 0 And chkCtlPsw.Checked = True Then
            MetroFramework.MetroMessageBox.Show(Me, MSG_NOT_CREATED_USER, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
            chkCtlPsw.Checked = False
        End If
        change_CtlUsers = True
        Changed()
    End Sub

    Private Sub txtIntentsUSR_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIntentsUSR.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        If KeyAscii < Asc("0") Or KeyAscii > Asc("9") Then If KeyAscii <> 8 Then KeyAscii = 0
        e.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtIntentsUSR_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIntentsUSR.TextChanged
        change_CtlUsers = True
        Changed()
    End Sub

    Private Sub chkRecord_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRecord.CheckedChanged
        Me.fraConf.Enabled = chkRecord.Checked
        Changed()
    End Sub

    Private Sub cmbBitrate_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
                                                                                            cmbBitrate.SelectedIndexChanged,
                                                                                            cmbAudioChannel.SelectedIndexChanged,
                                                                                            cmbSampleRate.SelectedIndexChanged,
                                                                                            ComboBoxDuradaDef.SelectedIndexChanged
        Changed()
    End Sub

    Private Sub txtPathArrelAudio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPathArrelAudio.TextChanged

        Try
            If txtPathArrelAudio.Enabled = True Then
                Params.PathArrelAudios = txtPathArrelAudio.Text
                Dim separador As String = "\"
                If Params.PathArrelAudios.IndexOf("\") = -1 Then separador = "/"
                Params.PathProgrames = Params.PathArrelAudios & separador & DIR_PROGRAMES & separador
                Params.PathMusica = Params.PathArrelAudios & separador & DIR_MUSICA & separador
                Params.PathPublicitat = Params.PathArrelAudios & separador & DIR_PUBLICITAT & separador
                Params.PathDefPauta = Params.PathArrelAudios & separador & DIR_PAUTES & separador
                Params.PathAudioUser = Params.PathArrelAudios & separador & DIR_AUDIOUSER & separador
                Params.PathBackups = Params.PathArrelAudios & separador & DIR_BACKUPS & separador

                change_DirMagatzem = True
                Changed()
            End If
            TestPathAudios(lbPathMusica, Params.PathMusica, getNomFitxer(Tipus_Play.CTL_MUSICA))
            TestPathAudios(Me.lbPathAudioUser, Params.PathAudioUser, Lang.getText("FITXER_AUDIO", True))
            TestPathAudios(Me.lbPathPautes, Params.PathDefPauta, "Pautes")
            TestPathAudios(Me.lbPathProgrames, Params.PathProgrames, getNomFitxer(Tipus_Play.CTL_PROGRAMA))
            TestPathAudios(Me.lbPathPublicitat, Params.PathPublicitat, getNomFitxer(Tipus_Play.CTL_PUBLICITAT))
            TestPathAudios(Me.lbPathBackup, Params.PathBackups, Lang.getText("LABEL_BACKUP", True))
        Catch ex As Exception
            TestPathAudios(lbPathMusica, "", getNomFitxer(Tipus_Play.CTL_MUSICA))
            TestPathAudios(Me.lbPathAudioUser, "", Lang.getText("FITXER_AUDIO", True))
            TestPathAudios(Me.lbPathPautes, "", "Pautes")
            TestPathAudios(Me.lbPathProgrames, "", getNomFitxer(Tipus_Play.CTL_PROGRAMA))
            TestPathAudios(Me.lbPathPublicitat, "", getNomFitxer(Tipus_Play.CTL_PUBLICITAT))
            TestPathAudios(Me.lbPathBackup, Params.PathBackups, Lang.getText("LABEL_BACKUP", True))
        End Try
    End Sub

    Private Sub ComboBoxSelectQualitatPodcast_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxSelectQualitatPodcast.SelectedIndexChanged
        change_IntegraWeb = True
        Changed()
    End Sub

    Sub LinkMysqlBackupLinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Sub Button3Click(sender As Object, e As EventArgs) Handles txtPathLogErr.ButtonClick
        If IO.File.Exists(Me.txtPathLogErr.Text) = False Then
            MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_DEL_FILE_LOGERROR, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100) : Exit Sub
        End If
        Dim p As System.Diagnostics.Process = New System.Diagnostics.Process()
        p.StartInfo.Arguments = Me.txtPathLogErr.Text
        p.StartInfo.FileName = "notepad.exe"
        p.Start()
    End Sub

    Sub ButtonOpenINIClick(sender As Object, e As EventArgs) Handles txtPathINI.ButtonClick

        Dim p As System.Diagnostics.Process = New System.Diagnostics.Process()
        p.StartInfo.Arguments = Me.txtPathINI.Text
        p.StartInfo.FileName = "notepad.exe"
        p.Start()
    End Sub

    Sub ButtonDelCtlLogClick(sender As Object, e As EventArgs) Handles buttonDelCtlLog.Click

        If MetroFramework.MetroMessageBox.Show(Me, MSG_DEL_LOGERROR, MSG_ATENCIO, MessageBoxButtons.YesNo, MessageBoxIcon.Question, 100) = DialogResult.No Then Exit Sub
        Try
            IO.File.Delete(Me.txtPathLogErr.Text)
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
            Throw
        End Try

    End Sub

    Sub TxtMinusProhivDiscTextChanged(sender As Object, e As EventArgs)
        Changed()
    End Sub

    Sub TxtMinusProhivDiscKeyPress(sender As Object, e As KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        If KeyAscii < Asc("0") Or KeyAscii > Asc("9") Then If KeyAscii <> 8 Then KeyAscii = 0
        e.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Sub CmbCodecBitrateSelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCodecSampleRate.SelectedIndexChanged, cmbCodecBitrate.SelectedIndexChanged, cmbCodecAudioChannel.SelectedIndexChanged
        change_EncoderAudio = True
        Changed()
    End Sub

    Sub ChkLastBKPCheckedChanged(sender As Object, e As EventArgs) Handles chkLastBKP.CheckedChanged
        If chkLastBKP.Enabled = False Then Exit Sub
        If Me.chkLastBKP.Checked = True Then
            'params.LastBackup = Now.AddDays (-24)
            Me.lbLastBKP.Visible = True
        Else
            'params.LastBackup = Now.AddYears (10)
            Me.lbLastBKP.Visible = False
        End If
        change_SistemDades = True
        Changed()
    End Sub

    Sub CmbLangSelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLang.SelectedIndexChanged
        If blEnable = True Then
            Lang = New MSC.UserLanguage(Me.cmbLang.SelectedValue)
            Lang.StrApp = My.Application.Info.AssemblyName
            My.Application.ChangeUICulture(Lang.Code)
            setLanguageGlobal()
            Dim myForms As FormCollection = Application.OpenForms
            For Each frmName As Form In myForms
                If MethodExist(frmName, "setLanguageForm") = True Then
                    'ok
                End If
            Next
            change_ParamsGenerals = True
            Changed()

        End If
    End Sub



    Sub GridAudioFilesCellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles gridAudioFiles.CellValueChanged
        If gridAudioFiles.Rows.Count > 0 Then
            Me.gridAudioFiles.CurrentRow.DefaultCellStyle.BackColor = Color.Green
            Changed()
        End If

    End Sub

    Sub ComboBoxServerStreamSelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBoxServerStream.SelectedIndexChanged
        Me.txtMountpoint.Enabled = (Me.comboBoxServerStream.SelectedIndex = 2)
        Changed()
    End Sub

    Sub TxtPortKeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPort.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        If KeyAscii < Asc("0") Or KeyAscii > Asc("9") Then If KeyAscii <> 8 Then KeyAscii = 0
        e.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Sub Streaming_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBoxServerStream.SelectedValueChanged
        change_Streaming = True
        Changed()
    End Sub

    Sub TxtServerTextChanged(sender As Object, e As EventArgs) Handles txtServer.TextChanged, txtPort.TextChanged, txtPassword.TextChanged, txtMountpoint.TextChanged, txtEstil.TextChanged
        change_Streaming = True
        Changed()
    End Sub


    Sub CmdPathAlternativeClick(sender As Object, e As EventArgs) Handles txtAternativeDir.ButtonClick
        FolderBrowserDialog1.Description = FolderBrowserDialog1_Description
        If FolderBrowserDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Me.txtAternativeDir.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Sub TxtClientKeyTextChanged(sender As Object, e As EventArgs) Handles txtClientKey.TextChanged
        cmdActive.Enabled = True
        LbClientOK.Visible = False
        LbClientKO.Visible = True
    End Sub

#Region "Programes núvol"


    Private Sub ButtonSetSharePrg_Click(sender As Object, e As EventArgs) Handles ButtonSetSharePrg.Click
        If cmbProgramesPropis.SelectedValue = 0 Then Exit Sub
        Dim prg_id As Integer = cmbProgramesPropis.SelectedValue
        Dim StrSql As String = "SELECT `prg_hash`,`prg_descripcio`,`prg_tematica`,`prg_durada` FROM `programes` WHERE `prg_id`=" & prg_id & " ;"
        Dim db As New MSC.dbs(Cloud)
        Dim codiShare As String = mdlCodeDecode.getMD5Hash(Now())
        Dim dtprg As DataTable = db.getTable(StrSql)
        Dim hash_prg As String = dtprg.Rows(0)("prg_hash").ToString
        If hash_prg.Length = 0 Then
            hash_prg = generateHashProgram(cmbProgramesPropis.Text)
            StrSql = "UPDATE programes SET prg_hash='" & hash_prg & "' WHERE `prg_id`=" & prg_id & " ;"
            db.Update_ID(StrSql)

            Dim descrip As String = TractarStrings(dtprg.Rows(0)("prg_descripcio").ToString())
            Dim tags As String = TractarStrings(getAllTags(prg_id, Tipus_Fitxers.FITXER_PROGRAMA))
            Dim Durada As String = dtprg.Rows(0)("prg_durada").ToString
            Dim Tematica As String = TractarStrings(getNomTematica(dtprg.Rows(0)("prg_tematica")))
            Cloud.InsertProgramToShare(cmbProgramesPropis.Text, descrip, tags, Tematica, Durada, hash_prg)
        End If
        Cloud.InsertRelationPrgToShare(codiShare, hash_prg)
        TxtCodeToShare.Text = codiShare
        ShowProgramsNuvolPropis()
    End Sub

    Sub Chk_shareProgramsCheckedChanged(sender As Object, e As EventArgs) Handles chk_sharePrograms.CheckedChanged
        If Me.chk_sharePrograms.Checked = True Then
            TreeViewParams.Nodes(3).Nodes(0).Nodes(0).ForeColor = Color.Black
        Else
            TreeViewParams.Nodes(3).Nodes(0).Nodes(0).ForeColor = Color.Gray
        End If
        cmdSalvarOptionsNuvol.Enabled = True
    End Sub

    Sub DataGridViewProgramsSharedCellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridViewProgramsShared.CellContentClick
        Dim hash_prg As String = Me.dataGridViewProgramsShared.Rows(e.RowIndex).Cells("column_prg_hash").Value
        Dim Cli_id As Integer = Me.dataGridViewProgramsShared.Rows(e.RowIndex).Cells("columnCli_id").Value
        If Me.dataGridViewProgramsShared.Columns(e.ColumnIndex).Name = "Column_prg_delete" Then
            'Borrar relació al núbol            
            Cloud.deletetRelationPrgToShare(hash_prg, Cli_id)

            addCtlRadi(0, CShort(Tipus_Play.CTL_SQL), 0, "00:00:00", 0, 0, Usuari.UsrID, "DELETE relation WHERE program =" & hash_prg & " AND client " & Cli_id, 0, False)
            'Borrar pantalla
            Me.dataGridViewProgramsShared.Rows.RemoveAt(e.RowIndex)
        ElseIf Me.dataGridViewProgramsShared.Columns(e.ColumnIndex).Name = "Column_prg_state" Then
            'canvi d'estat
            Dim state As Boolean = CBool(Me.dataGridViewProgramsShared.Rows(e.RowIndex).Cells("Column_prg_state").Value)
            Cloud.ChangeStateRelationPrgToShare(hash_prg, Cli_id, Not state)
        End If
        Changed()
    End Sub

    Private Sub ShowProgramsNuvolPropis()
        'en el núvol
        dataGridViewProgramsShared.Rows.Clear()
        dataGridViewProgramsShared.AllowUserToAddRows = True
        Dim dtprg As DataTable = Cloud.getProgramsOwn()
        For i As Integer = 0 To dtprg.Rows.Count - 1
            Dim prg_id As Integer = CInt(dtprg.Rows(i)("prg_id"))
            Dim prg_Hash As String = NoNul(dtprg.Rows(i)("prg_hash"))
            Dim nom As String = dtprg.Rows(i)("prg_nom").ToString
            Dim Emissora As String = dtprg.Rows(i)("cli_nom").ToString
            Dim Client_id As Integer = CInt(dtprg.Rows(i)("cli_id"))
            Dim state As Boolean = CBool(dtprg.Rows(i)("relation_active"))

            Dim newTimeRecord As DataGridViewRow = dataGridViewProgramsShared.Rows(dataGridViewProgramsShared.NewRowIndex).Clone
            newTimeRecord.Cells(0).Value = prg_id
            newTimeRecord.Cells(1).Value = nom
            newTimeRecord.Cells(2).Value = Emissora
            newTimeRecord.Cells(3).Value = prg_Hash
            newTimeRecord.Cells(4).Value = state
            newTimeRecord.Cells(5).Value = Client_id
            newTimeRecord.Cells(6).Value = LABEL_DELETE

            dataGridViewProgramsShared.Rows.Add(newTimeRecord)
        Next i
        dataGridViewProgramsShared.AllowUserToAddRows = False
    End Sub

    Private Sub ShowProgramesNuvolImportats()
        dataGridViewProgramsCloud.Rows.Clear()

        'Dim Sqlstr As String = "SELECT prg_id, prg_nom, prg_hash FROM programes where prg_propia=0 and length(prg_hash)>0;"
        Dim dtprg As DataTable = Cloud.getProgramsForeign()
        For i As Integer = 0 To dtprg.Rows.Count - 1
            Dim prg_id As Integer = dtprg.Rows(i)("prg_id")
            Dim prg_Hash As String = NoNul(dtprg.Rows(i)("prg_hash"))
            Dim nom As String = dtprg.Rows(i)("prg_nom").ToString
            Dim Emissora As String = dtprg.Rows(i)("cli_nom").ToString

            dataGridViewProgramsCloud.Rows.Add(New String() {prg_id, nom, Emissora, prg_Hash})
        Next i
    End Sub

    Sub ButtonImportProgramClick(sender As Object, e As EventArgs) Handles ButtonImportProgram.Click
        'crear el programa localment, partint de les dades del núbol       


        Dim dataPrgImport As DataTable = Cloud.SetClientOnRelation(txtCodeShareImport.Text)
        If dataPrgImport.Rows.Count > 0 Then
            Dim db As New MSC.dbs(Cloud)
            'TODO: insertar també tags i temàtica
            Dim tags As String = dataPrgImport.Rows(0)("prg_tags").ToString
            Dim tematica As String = dataPrgImport.Rows(0)("prg_tematica").ToString
            Dim strsql As String = "INSERT INTO programes SET " &
                "prg_nom='" & AddSlashes(dataPrgImport.Rows(0)("prg_nom").ToString) & "'" &
                ", prg_descripcio='" & AddSlashes(dataPrgImport.Rows(0)("prg_descrip").ToString) & "'" &
                ", prg_durada='" & dataPrgImport.Rows(0)("prg_durada").ToString & "'" &
                ", `prg_hash`='" & dataPrgImport.Rows(0)("prg_hash").ToString & "'" &
                ", `prg_facebook`=''" &
                ", `prg_twitter`=''" &
                ", `prg_twitter_key`=''" &
                ", `prg_propia`=0" &
                ", `prg_atv`=1" &
                ";"
            db.New_ID(strsql)
            MetroFramework.MetroMessageBox.Show(Me, MSG_IMPORT_PRG_OK, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Information, 100)
            RefreshDataSet(TAULES_DBS.TAULA_PROGRAMES)
            ShowProgramesNuvolImportats()
            db = Nothing
        End If
    End Sub

#End Region

    Sub ButtonSincroWebClick(sender As Object, e As EventArgs) Handles buttonSincroWeb.Click
        Me.buttonSincroWeb.Enabled = False

        Dim frmSincro As New frmUpdateCloud(chkAllDBS.Checked)

        If frmSincro.ShowDialog() = DialogResult.OK Then
            MetroFramework.MetroMessageBox.Show(Me, MSG_SAVED_DATA, My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Information, 100)
        Else
            MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_SAVE_DADES, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
        End If
        Me.buttonSincroWeb.Enabled = True
    End Sub


    Sub CmdSalvarOptionsNuvolClick(sender As Object, e As EventArgs) Handles cmdSalvarOptionsNuvol.Click

        Cloud.SetShareProgramms(Me.chk_sharePrograms.Checked)
        cmdSalvarOptionsNuvol.Enabled = False
        MetroFramework.MetroMessageBox.Show(Me, MSG_SAVED_DATA, My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Information, 100)
    End Sub

    Sub ComboBoxSequenciesSelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSequencies.SelectedIndexChanged
        change_SequenciPautes = True
        Changed()
    End Sub

    Sub ParamsGenerals_TextChanged(sender As Object, e As EventArgs) Handles txtWeb.TextChanged, txtTwitterKey.TextChanged, txtTwitter.TextChanged, txtNomRadio.TextChanged, txtFaceBook.TextChanged
        change_ParamsGenerals = True
        Changed()
    End Sub


    Sub DirMagatzem_TextChanged(sender As Object, e As EventArgs) Handles txtAternativeDir.TextChanged
        change_DirMagatzem = True
        Changed()
    End Sub

    Sub ReglesMusic_TextChanged(sender As Object, e As EventArgs) Handles txtOld.TextChanged, txtNTopHit.TextChanged, txtNHitOld.TextChanged, txtMinusProhivDisc.TextChanged, txtMaxRadiTop.TextChanged, txtMaxRadiOLD.TextChanged, txtMaxRadiHIT.TextChanged, txtIntervRitme.TextChanged, txtHTop.TextChanged, txtHOldTop.TextChanged, txtHHitTop.TextChanged, txtHHit.TextChanged, txtHBorrInterp.TextChanged
        change_ReglesMusic = True
        Changed()
    End Sub

    Sub ChkCanviCatClick(sender As Object, e As EventArgs) Handles chkCanviCat.Click
        change_ReglesMusic = True
        Changed()
    End Sub

    Sub CtlRemot_TextChanged(sender As Object, e As EventArgs) Handles txtUsuariCR.TextChanged, txtServerMailCR.TextChanged, txtRemitentCR.TextChanged, txtPasswordCR.TextChanged, txtIntervalCR.TextChanged
        change_CtlRemot = True
        Changed()
    End Sub

    Sub TxtPermanenciaPodcastTextChanged(sender As Object, e As EventArgs) Handles txtPermanenciaPodcast.TextChanged, txtNumVots.TextChanged, txtNumTracs.TextChanged
        change_IntegraWeb = True
        Changed()
    End Sub

    Sub TxtCanviTextChanged(sender As Object, e As EventArgs) Handles txtCanvi.TextChanged
        change_Moneda = True
        Changed()
    End Sub

    Private Sub sldMSegOClok_Scroll(sender As Object, e As ScrollEventArgs) Handles sldMSegOClok.Scroll
        Me.lbMSegOClok.Text = Me.sldMSegOClok.Value
        change_MSCDirecte = True
        Changed()
    End Sub

    Private Sub sldMilFader_Scroll(sender As Object, e As ScrollEventArgs) Handles sldMilFader.Scroll
        Me.lbMilFader.Text = Me.sldMilFader.Value
        change_ConnexCentral = True
        Changed()
    End Sub

    Private Sub sldMilSegSH_Scroll(sender As Object, e As ScrollEventArgs) Handles sldMilSegSH.Scroll
        Me.lbMilSegSH.Text = Me.sldMilSegSH.Value
        change_MSCControler = True
        Changed()
    End Sub

    Private Sub sldVolfader_Scroll(sender As Object, e As ScrollEventArgs) Handles sldVolfader.Scroll
        Me.lbVolfader.Text = sldVolfader.Value
        change_ConnexCentral = True
        Changed()
    End Sub

    Private Sub frmParams_ResizeEnd(sender As Object, e As EventArgs) Handles MyBase.ResizeEnd
        Dim FitxerINI As New IniFile
        frm_sice(0) = Me.Width : frm_sice(1) = Me.Height
        FitxerINI.INIWrite(MyAPP.IniFile, "Data Gest", "size", frm_sice(0).ToString & "," & frm_sice(1).ToString)
    End Sub

    Private Sub chk_SendDevelop_CheckedChanged(sender As Object, e As EventArgs) Handles chk_SendDevelop.CheckedChanged
        change_Emergencies = True
        Changed()
    End Sub

    Private Sub chkOnLine_CheckedChanged(sender As Object, e As EventArgs) Handles chkOnLine.CheckedChanged
        change_ParamsGenerals = True
        Changed()
    End Sub

    Private Sub cmdExportConnection_Click(sender As Object, e As EventArgs) Handles cmdExportConnection.Click
        FolderBrowserDialog1.Description = FolderBrowserDialog1_Description
        If FolderBrowserDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim initVector As String = "Bla3212EWMND12es"
            Dim DirTosave As String = FolderBrowserDialog1.SelectedPath
            Dim FiletempToencript As String = IO.Path.GetTempPath & "connection.tmp"
            Dim FitxerINI As New IniFile
            Dim MySecretKey As String = FitxerINI.INIRead(MyAPP.IniFile, "Data key", "CLIENT_SECRET_KEY", "")
            Dim INdx As Integer = Me.lstDBS.SelectedIndex
            FitxerINI.INIWrite(FiletempToencript, "Data Connect", "DB_Descrip0", DBS_Col(INdx).DescripDBS) ': lstDBS.Items.Add(DBS_Col(i).DescripDBS) ' VB6.SetItemString(Me.lstDBS, i - 1, DBS_Col(i).DescripDBS))
            FitxerINI.INIWrite(FiletempToencript, "Data Connect", "DB_NAME0", DBS_Col(INdx).NomDBS)
            Dim MyHost As String = DBS_Col(INdx).HostDBS.Trim
            If MyHost = "localhost" Then MyHost = mdlSistOper.GetIPAddress()
            FitxerINI.INIWrite(FiletempToencript, "Data Connect", "DB_Descrip0", DBS_Col(INdx).DescripDBS)
            FitxerINI.INIWrite(FiletempToencript, "Data Connect", "DB_SERVER0", MyHost)
            FitxerINI.INIWrite(FiletempToencript, "Data Connect", "DB_PORT0", DBS_Col(INdx).PortDBS)
            FitxerINI.INIWrite(FiletempToencript, "Data Connect", "DB_NAME0", DBS_Col(INdx).NomDBS)
            FitxerINI.INIWrite(FiletempToencript, "Data Connect", "DB_USER0", DBS_Col(INdx).UsrDBS)
            FitxerINI.INIWrite(FiletempToencript, "Data Connect", "DB_PSW0", DBS_Col(INdx).PswDBS)
            FitxerINI.INIWrite(FiletempToencript, "Data key", "CLIENT_SECRET_KEY", MySecretKey)


            Dim FileToSave As String = DirTosave & "\connection.mscconf"

            mdlCodeDecode.AESEncryptFile(FiletempToencript, FileToSave, Cloud.MSC_PRI_SECRET_KEY, "dasdasdasd", initVector)
            MetroFramework.MetroMessageBox.Show(Me, FileToSave, My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Information, 100)

        End If
    End Sub

    Private Sub txtComentDesconnexio_TextChanged(sender As Object, e As EventArgs) Handles txtComentDesconnexio.TextChanged

        change_ParamsGenerals = True
        Changed()
    End Sub

    Private Sub chkVDef_activats_CheckedChanged(sender As Object, e As EventArgs) Handles chkVDef_activats.CheckedChanged, chkCaptureTag.CheckedChanged
        change_EncoderAudio = True
        Changed()
    End Sub

    Private Sub txtVDEF_DateOut_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtVDEF_DateOut.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        If KeyAscii < Asc("0") Or KeyAscii > Asc("9") Then If KeyAscii <> 8 Then KeyAscii = 0
        e.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtVDEF_DateOut_TextChanged(sender As Object, e As EventArgs) Handles txtVDEF_DateOut.TextChanged
        change_Moneda = True
        Changed()
    End Sub

    Private Sub ComboBoxVDef_tarifa_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBoxVDef_tarifa.SelectedValueChanged
        change_Moneda = True
        Changed()
    End Sub

    Private Sub ButtonAddCarpeta_Click(sender As Object, e As EventArgs) Handles ButtonAddCarpeta.Click
        Dim NouTxt As New TextBox
        NouTxt.Parent = Me.FlowLayoutPanelCarpetes
        AddHandler NouTxt.TextChanged, AddressOf ParamsGenerals_TextChanged
    End Sub

    Private Sub gridAudioFiles_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridAudioFiles.CellContentClick
        If gridAudioFiles.Columns(e.ColumnIndex).Name = "ColumnEnding" Then
            For I As Integer = 0 To gridAudioFiles.Rows.Count - 1
                gridAudioFiles.Rows(I).Cells("ColumnEnding").Value = 0
            Next
            gridAudioFiles.Rows(e.RowIndex).Cells("ColumnEnding").Value = 1
            gridAudioFiles.Rows(e.RowIndex).Cells("ColumnVisible_cont").Value = 1
        ElseIf gridAudioFiles.Columns(e.ColumnIndex).Name = "ColumnImage" Then
            Dim frmImg As New frmIcons
            If frmImg.ShowDialog = DialogResult.OK Then
                Dim My_id As Integer = frmImg.ID
                Dim MyImage As Image = New Bitmap(frmMain.imgListMnu.Images(My_id))
                gridAudioFiles.Rows(e.RowIndex).Cells("ColumnImage").Value = resizeImage(MyImage, 16)
                Me.gridAudioFiles.Rows(e.RowIndex).Cells("ColumnImageid").Value = My_id
            End If
        ElseIf gridAudioFiles.Columns(e.ColumnIndex).Name = "Columnph" Then
            For I As Integer = 0 To gridAudioFiles.Rows.Count - 1
                gridAudioFiles.Rows(I).Cells("Columnph").Value = 0
            Next
            gridAudioFiles.Rows(e.RowIndex).Cells("Columnph").Value = 1
            gridAudioFiles.Rows(e.RowIndex).Cells("ColumnVisible_cont").Value = 1

        End If
    End Sub

    Private Sub TxtCodeToShare_ButtonClick(sender As Object, e As EventArgs) Handles TxtCodeToShare.ButtonClick
        My.Computer.Clipboard.SetText(Me.TxtCodeToShare.Text)
    End Sub
End Class