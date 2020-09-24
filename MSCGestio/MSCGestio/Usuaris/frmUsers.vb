Option Strict Off
Option Explicit On
Imports MySql.Data.MySqlClient
Public Class frmUsers
    Dim blEnable As Boolean
    Dim blnNouRecord As Boolean

    Private Sub CloseForm()
        If Me.cmdSalvar.Enabled Then
            If MetroFramework.MetroMessageBox.Show(Me, MSG_SAVE_DADES, MSG_ATENCIO, MessageBoxButtons.YesNo, MessageBoxIcon.Information, 100) = DialogResult.Yes Then SaveRecord()
        End If
        MyAPP.CloseSesionClient(Usuari.UsrTipus, DESCRIP_FORM_EDIT_USERS)
        Me.Dispose()
    End Sub

    Private Sub frmUsers_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        CloseForm()
    End Sub

    Private Sub txtIntentsUSR_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNivell.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        If KeyAscii < Asc("0") Or KeyAscii > Asc("9") Then If KeyAscii <> 8 Then KeyAscii = 0
        e.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtIntentsUSR_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Changed()
    End Sub


    Private Sub LockedPantalla(Optional ByVal saved As Boolean = False)
        If Me.cmdSalvar.Enabled = True And saved = False Then
            If MetroFramework.MetroMessageBox.Show(Me, MSG_SAVE_DADES, MSG_ATENCIO, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, 100) = DialogResult.OK Then SaveRecord()
        End If

        blEnable = Not blEnable
        'Me.grupUSR.Enabled = blEnable
        txtAlies.Enabled = blEnable
        txtCompAlies.Enabled = blEnable
        txtPassWord.Enabled = blEnable
        txtCompPsw.Enabled = blEnable
        txtNom.Enabled = blEnable
        chkCaduc.Enabled = blEnable
        'txtCaducUsr.Enabled = blEnable
        txtCaducUsr.Enabled = IIf(chkCaduc.Checked = True, blEnable, False)
        grupLevel.Enabled = blEnable
        lstPrg.Enabled = blEnable

        If blEnable Then
            Me.cmdBloqueix.Image = Me.picUnLock.Image
        Else
            Me.cmdBloqueix.Image = Me.picLock.Image
            Me.cmdSalvar.Enabled = False
            Me.lbNewUser.Visible = False
            'ChangeUsr = False
            blnNouRecord = False
        End If
    End Sub

    Private Sub frmUsers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setLanguageForm()
        ' llistats de programes assignat a un Usr -----
        For N As Short = 0 To 11 ' Nº d'aplicatius
            Me.lstPrg.Items.Insert(N, getNomAplic(N))
        Next
    End Sub

    Dim MSG_ERROR_USER_ALIES As String
    Dim MSG_ERROR_USER_PASSWORD As String
    Dim MSG_ERROR_USER_NOM As String
    Dim MSG_ERROR_USER_PERMISOS As String
    Dim MSG_ERROR_USER_ADMIN As String
    Dim MSG_ERROR_USER_ROL As String
    Dim MSG_ERROR_USER_NOT_DELETE As String

    Dim MSG_ERROR_USER_TEST_NICK As String
    Dim MSG_ERROR_USER_TEST_PSW As String
    Dim MSG_USER_CONFIRM_DELETE As String

    Public Sub setLanguageForm()
        lang.StrForm = Me.Name

        MSG_ERROR_USER_ALIES = lang.getText("MSG_ERROR_USER_ALIES") '"S'ha d'assignar un àlies"
        MSG_ERROR_USER_PASSWORD = lang.getText("MSG_ERROR_USER_PASSWORD") '"S'ha d'assignar un PassWord"
        MSG_ERROR_USER_NOM = lang.getText("MSG_ERROR_USER_NOM") '"S'ha d'assignar un Nom"
        MSG_ERROR_USER_PERMISOS = lang.getText("MSG_ERROR_USER_PERMISOS") '"S'han d'assignar els permisos als programes"
        MSG_ERROR_USER_ADMIN = lang.getText("MSG_ERROR_USER_ADMIN") '"El primer usuari ha de ser Administrador"
        MSG_ERROR_USER_ROL = lang.getText("MSG_ERROR_USER_ROL") '"A Aquest usuari no se li pot degradar el rol"
        MSG_ERROR_USER_TEST_NICK = lang.getText("MSG_ERROR_USER_TEST_NICK") '"No és correcte el nick"
        MSG_ERROR_USER_TEST_PSW = lang.getText("MSG_ERROR_USER_TEST_PSW") '"No és correcte el password"
        MSG_ERROR_USER_NOT_DELETE = lang.getText("MSG_ERROR_USER_NOT_DELETE") '"Aquest usuari no es pot borrar"
        MSG_USER_CONFIRM_DELETE = lang.getText("MSG_USER_CONFIRM_DELETE") '"Segur que vols borrar Aquest usuari?"

        Me.optionLevel_Program.Text = NOM_TIPUS_USER_DEVELOP
        Me.optionLevel_Admin.Text = NOM_TIPUS_USER_ADMIN
        Me.optionLevel_Usuari.Text = NOM_TIPUS_USER_EDITOR
        Me.optionLevel_Convi.Text = NOM_TIPUS_USER_CONVIDAT

        Me.Label4.Text = lang.getText("LABEL_IDENTIFICADOR", True) & ":" '"Identificador:"
        Me.Label7.Text = lang.getText("LABEL_NOM", True) & ":" '"Nom:"
        Me.cmdNou.Text = lang.getText("LABEL_NEW", True) '"Nou"
        Me.cmdBloqueix.Text = lang.getText("LABEL_EDITAR", True) '"Editar"
        Me.cmdBorrar.Text = lang.getText("LABEL_DELETE", True) '"Borrar"
        Me.cmdSalvar.Text = lang.getText("LABEL_SAVE", True) '"Salvar"
        Me.cmdSortir.Text = lang.getText("LABEL_EXIT", True) '"Sortir"	

        Me.TabPage3.Text = lang.getText("TabPage3.Text") '"Dades Usuari"
        Me.Label5.Text = lang.getText("Label5.Text") & ":" '"Àlies, Nick :"
        Me.txtAlies.WaterMark = Me.Label5.Text
        Me.txtCompAlies.WaterMark = Me.Label5.Text
        Me.GroupProgs.Text = lang.getText("GroupProgs.Text") '"Accés a programes o pantalles"
        Me.ColumnHeader1.Text = lang.getText("ColumnHeader1.Text") '"Nom del programa"

        Me.Label20.Text = lang.getText("Label20.Text") '"Les contrasenyes generades aquí caduquen als 7 dies."
        Me.grupLevel.Text = lang.getText("grupLevel.Text") '"Rol de gestió"
        Me.Label9.Text = lang.getText("Label9.Text") & ":" '"Nivell de confiança (0-99):"
        Me.Label8.Text = lang.getText("Label8.Text") & ":" '"Data de caducitat:"
        Me.chkCaduc.Text = lang.getText("chkCaduc.Text") '"Caduca"
        Me.Label6.Text = lang.getText("LABEL_CONTRASENYA", True) & ":" '"Contrasenya:"
        Me.txtPassWord.WaterMark = Me.Label6.Text
        Me.txtCompPsw.WaterMark = Me.Label6.Text
        Me.Label19.Text = lang.getText("Label19.Text") '"repetir"
        Me.Label22.Text = Label19.Text '"repetir"
        Me.TabPage4.Text = lang.getText("LABEL_INSPECTOR", True) '"Inspector"
        Me.Label15.Text = lang.getText("LABEL_ULTIM_PASSWORD_ERR", True) & ":" '"Últim PassWord erroni:"
        Me.Label14.Text = lang.getText("LABEL_DATA_ULT_INTENT_ERR", True) & ":" '"Data últim intent erroni:"
        Me.Label13.Text = lang.getText("Label13.Text") & ":" '"Nº Intents erronis a la última connexió:"
        Me.Label12.Text = lang.getText("LABEL_DATA_ULT_DESCONNEX", True) & ":" '"Data última desconnexió:"
        Me.Label11.Text = lang.getText("LABEL_DATA_ULT_CONNEX", True) & ":" '"Data última connexió:"
        Me.Label10.Text = lang.getText("LABEL_DATA_CREACIO", True) '"Data de creació:"
        'Me.ToolStrip1.Text = "ToolStrip1"
        Me.ToolStripLabel1.Text = lang.getText("LABEL_USER", True) & ":" '"Usuari:"
        Me.lbNewUser.Text = lang.getText("lbNewUser.Text") '"Atenció nou usuari"
        Me.Text = lang.getText("Text") '"Gestió d'usuaris"
        Dim Cmb As New combo
        Cmb.OmpleCombo(Me.cmbUSR, TAULES_DBS.TAULA_USUARIS, TotsCap.CAP)
        cmbUSR.SelectedValue = 0
    End Sub

    Private Sub Changed()
        Me.cmdSalvar.Enabled = blEnable
    End Sub



    Private Sub BuidarPantallaUSR()
        Me.lbID.Text = ""
        Me.txtAlies.Text = ""
        txtCompAlies.Text = ""
        Me.txtPassWord.Text = ""
        txtCompPsw.Text = ""
        Me.txtNom.Text = ""
        Me.txtNivell.Text = CStr(0)
        Me.optionLevel_Convi.Checked = True
        Me.lbDataCrea.Text = ""
        Me.lbDataUltConex.Text = ""
        Me.lbdataUltdesconex.Text = ""
        Me.lbNIntentsErr.Text = ""
        Me.lbDataUltIntErr.Text = ""
        Me.lbPswErr.Text = ""
        Me.txtCaducUsr.Value = System.DateTime.FromOADate(Today.ToOADate + 7)
        Me.chkCaduc.Checked = False
        For N As Short = 0 To Me.lstPrg.Items.Count - 1
            Me.lstPrg.Items.Item(N).Checked = False
        Next
        lstPrg.Refresh()
        Me.Refresh()
    End Sub

    Private Sub cmbUSR_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbUSR.KeyUp
        'Select Case e.KeyCode
        '    Case Keys.Left, Keys.Right, Keys.Up, Keys.Down
        '        Return
        'End Select
        'Dim MyComboBox As system.Windows.Forms.ComboBox = CType(sender, system.Windows.Forms.ComboBox)
        'Dim Origen As TAULES_DBS = TAULES_DBS.TAULA_USUARIS
        'refreshComboBoxKeyUp(MyComboBox, Origen, TotsCap.CAP)
    End Sub

    Private Sub cmbUSR_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbUSR.SelectedIndexChanged
        If blEnable = True Then LockedPantalla()
        Dim id As Integer = Me.cmbUSR.SelectedValue

        If id > 0 Then
            Dim StrSql As String = "SELECT usr_id,AES_DECRYPT(UNHEX(usr_alies),'" & MY_SECRET_KEY_TO_ENCRYPT & "') as usr_alies, " _
                        & "AES_DECRYPT(UNHEX(usr_password),'" & MY_SECRET_KEY_TO_ENCRYPT & "') as usr_password,usr_nom," _
                        & "usr_nivell,usr_tipus,usr_datacreacio,usr_dataultconex,usr_dataultdesconex,usr_intentserr," _
                        & "usr_dataultinternterr,usr_errpsw,usr_caducitat,usr_caducpsw,usr_applications FROM users WHERE usr_id = " & id

            Dim db As New MSC.dbs(Cloud)
            Dim rs As DataTable = db.getTable(StrSql)
            If rs.Rows.Count = 0 Then Exit Sub
            Me.lbID.Text = rs.Rows(0)("usr_id").ToString
            'TODO: Conversió de la mascara errònea.
            Dim Alies As String = ""
            Select Case rs.Rows(0)("usr_alies").GetType.FullName
                Case "System.Byte[]"
                    Alies = System.Text.Encoding.Default.GetString(rs.Rows(0)("usr_alies"))
                Case "System.String"
                    Alies = rs.Rows(0)("usr_alies").ToString
            End Select
            Dim Psw As String = ""
            Select Case rs.Rows(0)("usr_password").GetType.FullName
                Case "System.Byte[]"
                    Psw = System.Text.Encoding.Default.GetString(rs.Rows(0)("usr_password"))
                Case "System.String"
                    Psw = rs.Rows(0)("usr_password").ToString
            End Select

            Me.txtAlies.Text = Alies
            'Me.txtPassWord.Text = Psw
            Me.txtNom.Text = NoNul(rs.Rows(0)("usr_nom").ToString)
            Me.txtNivell.Text = rs.Rows(0)("usr_nivell").ToString
            Select Case rs.Rows(0)("usr_tipus")
                Case NivellUsers.USR_CONVIDAT
                    Me.optionLevel_Convi.Checked = True
                Case NivellUsers.USR_USUARI : Me.optionLevel_Usuari.Checked = True
                Case NivellUsers.USR_ADMINISTRADOR : Me.optionLevel_Admin.Checked = True
                Case NivellUsers.USR_PROGRAMADOR : Me.optionLevel_Program.Checked = True
            End Select
            Me.lbDataCrea.Text = rs.Rows(0)("usr_datacreacio").ToString
            Me.lbDataUltConex.Text = NoNul(rs.Rows(0)("usr_dataultconex").ToString)
            Me.lbdataUltdesconex.Text = NoNul(rs.Rows(0)("usr_dataultdesconex").ToString)
            Me.lbNIntentsErr.Text = rs.Rows(0)("usr_intentserr").ToString
            Me.lbDataUltIntErr.Text = IIf(rs.Rows(0)(10).ToString = "01/01/1970", "", rs.Rows(0)(10).ToString)
            Me.lbPswErr.Text = NoNul(rs.Rows(0)("usr_errpsw").ToString)
            Try
                Me.txtCaducUsr.Value = CDate(NoNul(rs.Rows(0)("usr_caducitat").ToString))
            Catch ex As Exception
                Me.txtCaducUsr.Value = txtCaducUsr.MinDate
            End Try
            Me.chkCaduc.Checked = CBool(IIf((txtCaducUsr.Value > txtCaducUsr.MinDate), 1, 0))
            Dim userFrm As String() = Split(rs.Rows(0)("usr_applications").ToString, ",")

            For i As Integer = 0 To userFrm.Length - 1
                Try
                    Me.lstPrg.Items.Item(i).Checked = userFrm(i)
                Catch ex As Exception
                    Exit For
                End Try
            Next i
            rs.Dispose()
            db = Nothing
            Me.Refresh()
        Else
            BuidarPantallaUSR()
        End If

        cmdBorrar.Enabled = CBool(IIf(id > 0, True, False))
        Me.cmdBloqueix.Enabled = cmdBorrar.Enabled

    End Sub


    Private Sub SaveRecord()
        If Not MyAPP.PermisPerContinuar() Then MetroFramework.MetroMessageBox.Show(Me, MSG_SERVER_CLOSE, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Stop, 100) : Me.Close()
        If MetroFramework.MetroMessageBox.Show(Me, MSG_CONFIRM_SAVE_DADES, MSG_ATENCIO, MessageBoxButtons.YesNo, MessageBoxIcon.Question, 100) = DialogResult.No Then Exit Sub


        Dim USER_Id As Integer = Me.cmbUSR.SelectedValue
        Dim Nom As String = txtNom.Text
        'If ChangeUsr Then
        Dim GMusic, Gestio, Controler, GRipper, GAutomat As Boolean
            Dim Direct, GPubli, Cartutx, Monitor, logger, stream, globa As Boolean
            Dim NSelectPrg As Short
            For p As Short = 0 To 11
                If Me.lstPrg.Items.Item(p).Checked Then NSelectPrg += 1
            Next
            ' Establim Valors 
            Dim Nivell As Short = CShort(Me.txtNivell.Text)

            Dim Datacaduc As Date
            If Me.chkCaduc.Checked = True Then
                Datacaduc = Me.txtCaducUsr.Value
            Else
                Datacaduc = CDate("1899-12-30")
            End If

            Dim Tipus As mdlMscDefines.NivellUsers
            If optionLevel_Convi.Checked Then
                Tipus = NivellUsers.USR_CONVIDAT
            ElseIf Me.optionLevel_Usuari.Checked Then
                Tipus = NivellUsers.USR_USUARI
            ElseIf Me.optionLevel_Admin.Checked Then
                Tipus = NivellUsers.USR_ADMINISTRADOR
            ElseIf Me.optionLevel_Program.Checked Then
                Tipus = NivellUsers.USR_PROGRAMADOR
            End If


            If Len(txtNom.Text) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_USER_NOM, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
                Exit Sub
            ElseIf NSelectPrg = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_USER_PERMISOS, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
                Exit Sub
            ElseIf cmbUSR.Items.Count = 1 And Tipus < mdlMscDefines.NivellUsers.USR_ADMINISTRADOR Then
                MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_USER_ADMIN, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
                Exit Sub
            ElseIf USER_Id = 1 AndAlso Tipus < NivellUsers.USR_ADMINISTRADOR Then
                MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_USER_ROL, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
                Exit Sub
            End If


            Dim strUsrApp As String = ""
            For N As Integer = 0 To 11
                If N > 0 Then strUsrApp += ","
                strUsrApp += CInt(Me.lstPrg.Items.Item(N).Checked).ToString
            Next

        Dim db As New MSC.dbs(Cloud)
        db.IniTransaction()
            If blnNouRecord = True Then
                If txtAlies.Text.Length = 0 Then
                    MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_USER_ALIES, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
                    Exit Sub
                ElseIf txtPassWord.Text.Length = 0 Then
                    MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_USER_PASSWORD, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
                    Exit Sub
                End If
                'Crea un nou usuari
                Dim sCmd As String = "INSERT INTO users ( usr_alies, usr_password, usr_nom, usr_nivell, usr_tipus ,usr_caducitat, usr_caducpsw,usr_datacreacio,usr_applications)"
                sCmd = sCmd & " VALUES ("
                sCmd = sCmd & " HEX(AES_ENCRYPT('" & txtAlies.Text & "','" & MY_SECRET_KEY_TO_ENCRYPT & "')) "
                sCmd = sCmd & ", HEX(AES_ENCRYPT('" & txtPassWord.Text & "','" & MY_SECRET_KEY_TO_ENCRYPT & "')) "
                sCmd = sCmd & ", '" & Nom & "'"
                sCmd = sCmd & ", " & Nivell
                sCmd = sCmd & ", " & Tipus
                sCmd = sCmd & ", '" & Datacaduc.ToString("yyyy-MM-dd HH:mm:ss") & "'"
                sCmd = sCmd & ", '" & Now.AddDays(7).ToString("yyyy-MM-dd HH:mm:ss") & "'" 'NOW()+INTERVAL 7 DAY "
                sCmd = sCmd & ", '" & Now.ToString("yyyy-MM-dd HH:mm:ss") & "'"
                sCmd = sCmd & ", '" & strUsrApp & "'"
                sCmd = sCmd & ");"

                USER_Id = db.New_ID(sCmd)


                'Salva Botons per defecte (cap).
                sCmd = "INSERT INTO botonsurs (botoUsrID)"
                sCmd = sCmd & " VALUES "
                sCmd = sCmd & " ( " & USER_Id
                sCmd = sCmd & ");"
                db.New_ID(sCmd)
            Else
                'Salva dades usuari (UPDATE).
                Dim sCmd As String = "UPDATE users SET"
                If txtAlies.Text.Length > 0 Then sCmd = sCmd & " usr_alies = HEX(AES_ENCRYPT('" & txtAlies.Text & "','" & MY_SECRET_KEY_TO_ENCRYPT & "'))"
                If txtPassWord.Text.Length > 0 Then sCmd = sCmd & ", usr_password = HEX(AES_ENCRYPT('" & txtPassWord.Text & "','" & MY_SECRET_KEY_TO_ENCRYPT & "'))"
                sCmd = sCmd & ", usr_nom = '" & Nom & "'"
                sCmd = sCmd & ", usr_nivell = " & Nivell & ""
                sCmd = sCmd & ", usr_tipus = " & Tipus & ""
                sCmd = sCmd & ", usr_caducitat = '" & Datacaduc.ToString("yyyy-MM-dd HH:mm:ss") & "'"
                sCmd = sCmd & ", usr_applications = '" & strUsrApp & "'"

                sCmd = sCmd & " WHERE usr_id = " & USER_Id & " ;"
                db.Update_ID(sCmd)

            End If
            db.EndTransaction()
            db = Nothing
        'End If

        LockedPantalla(True)

        RefreshDataSet(TAULES_DBS.TAULA_USUARIS)
        Dim Cmb As New combo
        Cmb.OmpleCombo(Me.cmbUSR, TAULES_DBS.TAULA_USUARIS, TotsCap.CAP)
        Me.cmbUSR.SelectedValue = USER_Id
    End Sub

    Private Sub lstPrg_ItemChecked(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lstPrg.ItemChecked
        If Me.cmbUSR.SelectedValue > 0 And blEnable = True Then
            Dim Item As System.Windows.Forms.ListViewItem = e.Item
            If Item.Index = 0 Then

            End If
            Select Case Item.Index
                Case mdlMscDefines.Aplicatius.PRG_GLOBAL
                    For i As Integer = 0 To lstPrg.Items.Count - 1
                        lstPrg.Items(i).Checked = True
                    Next
                Case mdlMscDefines.Aplicatius.PRG_MANT_IMPORT Or mdlMscDefines.Aplicatius.PRG_MANT_PRODUCCIO Or
                     mdlMscDefines.Aplicatius.PRG_MANT_PUBLI Or mdlMscDefines.Aplicatius.PRG_MANT_AUTOMAT Or
                     mdlMscDefines.Aplicatius.PRG_MANT_AUTOMAT

                    If lstPrg.Items.Item(Item.Index).Checked = True Then Me.lstPrg.Items.Item(mdlMscDefines.Aplicatius.PRG_GESTIO).Checked = True
                Case mdlMscDefines.Aplicatius.PRG_STREAM Or mdlMscDefines.Aplicatius.PRG_LOGGER Or
                     mdlMscDefines.Aplicatius.PRG_CONTROLER Or mdlMscDefines.Aplicatius.PRG_DIRECTE

                    optionLevel_Admin.Checked = True
            End Select
            Changed()
        End If


    End Sub

    Private Sub chkCaduc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCaduc.CheckedChanged
        If chkCaduc.Enabled = False Then Exit Sub
        txtCaducUsr.Enabled = chkCaduc.Checked
        If chkCaduc.Checked = True Then txtCaducUsr.Focus()
    End Sub

    Private Sub txtNivell_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNivell.KeyUp
        Try
            If txtNivell.Text > 99 Then txtNivell.Text = 99
        Catch ex As Exception
            txtNivell.Text = 0
        End Try
    End Sub

    Private Sub txtCompAlies_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCompAlies.Validated
        If txtCompAlies.Text <> Me.txtAlies.Text Then
            MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_USER_TEST_NICK, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
            txtCompAlies.Text = ""
            txtAlies.Text = ""
            Me.txtAlies.Focus()
        End If
    End Sub

    Private Sub txtCompPsw_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCompPsw.Validated
        If txtCompPsw.Text <> Me.txtPassWord.Text Then
            MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_USER_TEST_PSW, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
            txtPassWord.Text = ""
            txtCompPsw.Text = ""
            txtPassWord.Focus()
        End If
    End Sub

    Private Sub optionLevel_Convi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optionLevel_Usuari.CheckedChanged, optionLevel_Program.CheckedChanged, optionLevel_Convi.CheckedChanged, optionLevel_Admin.CheckedChanged
        'ChangeUsr = True
        Changed()
    End Sub

    Private Sub txtNivell_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassWord.TextChanged, txtNom.TextChanged, txtNivell.TextChanged, txtCaducUsr.ValueChanged, txtAlies.TextChanged
        'ChangeUsr = True
        Changed()
    End Sub

    Private Sub cmdNou_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNou.Click

        blEnable = False
        LockedPantalla()
        blnNouRecord = True
        BuidarPantallaUSR()
        Me.lbNewUser.Visible = True
        Me.lbDataCrea.Text = CStr(Now)
        Me.txtNom.Focus()
    End Sub

    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
        Dim USER_Id As Integer = Me.cmbUSR.SelectedValue
        If USER_Id = 1 Then
            MetroFramework.MetroMessageBox.Show(Me, MSG_ERROR_USER_NOT_DELETE, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)
            Exit Sub
        End If

        If USER_Id > 1 Then
            MetroFramework.MetroMessageBox.Show(Me, MSG_USER_CONFIRM_DELETE, MSG_ATENCIO, MessageBoxButtons.OK, MessageBoxIcon.Error, 100)

            Dim db As New MSC.dbs(Cloud)
            db.IniTransaction()
            Dim sCmd As String

            sCmd = "DELETE FROM users WHERE usr_id = " & USER_Id & " ;"
            db.Delete_ID(sCmd)
            addCtlRadi(0, CShort(Tipus_Play.CTL_SQL), 0, "00:00:00", 0, 0, Usuari.UsrID, sCmd, 0, False)

            sCmd = "DELETE FROM listaplicatius WHERE lstprg_user = " & USER_Id & " ;"
            db.Delete_ID(sCmd)

            sCmd = "DELETE FROM botonsurs WHERE botoUsrID = " & USER_Id & " ;"
            db.Delete_ID(sCmd)

            db.EndTransaction()
            db = Nothing
            RefreshDataSet(TAULES_DBS.TAULA_USUARIS)
            Dim Cmb As New combo
            Cmb.OmpleCombo(Me.cmbUSR, TAULES_DBS.TAULA_USUARIS, TotsCap.CAP)
        End If
    End Sub

    Private Sub cmdSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalvar.Click
        SaveRecord()
    End Sub

    Private Sub cmdBloqueix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBloqueix.Click
        LockedPantalla()
    End Sub

    Private Sub cmdSortir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSortir.Click
        Me.Close()
    End Sub
End Class