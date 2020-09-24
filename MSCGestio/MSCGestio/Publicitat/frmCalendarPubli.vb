'
' Creado por SharpDevelop.
' Usuario: Marti
' Fecha: 15/09/2017
' Hora: 12:39
' 
' Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
'
Public Partial Class frmCalendarPubli
	
	Dim ShowCalendar As listCalendar = listCalendar.Setmana
	
	Dim UnitatMin As Double		
	Dim UnitatDies As Integer
	Dim PuntIniXDies(7) As Integer
	Dim MargeItems As Integer = 2
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub

    Sub FrmCalendarPubliLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        setLanguageForm()
        PictureBoxCalendar.Image = Me.ImageListCalendar.Images(2)
        ShowCalendar = listCalendar.Setmana

        Me.dtpDetallData.Value = Now()
        dtpDataRadi.Value = Now()
        Me.ClientSize = New Size(frm_sice(0), frm_sice(1))
        PintaHores()
        PintaCalendar()

    End Sub

    Private Sub PintaDies()
        If ShowCalendar = listCalendar.Setmana Then
            Dim Monday As Date = Me.dtpDataRadi.Value.AddDays(-Weekday(Me.dtpDataRadi.Value, FirstDayOfWeek.Monday) + 1)
            For i As Integer = 0 To 6
                Try
                    Dim labelDia As Label = CType(pnlDies.Controls(i), Label)

                    Dim x As Integer = ((pnlDies.Width / 7) * i)
                    labelDia.Location = New Point(x, 5)
                    labelDia.Size = New Size((pnlDies.Width / 7), 13)

                    Dim DataLabel As Date = Monday.AddDays(i)
                    Dim Str As String = ""
                    If pnlDies.Width < 500 Then
                        Str = DataLabel.ToString("ddd") & " ( " & DataLabel.ToString("dd") & ") "
                    ElseIf pnlDies.Width < 700 Then
                        Str = DataLabel.ToString("ddd") & " ( " & DataLabel.ToString("d MMM") & ") "
                    Else
                        Str = DataLabel.ToString("dddd") & " ( " & DataLabel.ToString("d MMM") & ") "
                    End If
                    labelDia.Text = Str
                    labelDia.Tag = DataLabel
                    labelDia.Visible = True
                    If DateDiff(DateInterval.Day, DataLabel, Me.dtpDataRadi.Value) = 0 Then
                        labelDia.ForeColor = Color.Blue
                    Else
                        labelDia.ForeColor = Color.Black
                    End If
                Catch ex As Exception
                End Try
            Next
        Else
            For i As Integer = 0 To 6
                Dim labelDia As Label = CType(pnlDies.Controls(i), Label)
                labelDia.Visible = False
            Next
            Dim labelDia2 As Label = CType(pnlDies.Controls(3), Label)
            labelDia2.Visible = True
            labelDia2.Text = Me.dtpDataRadi.Value.ToString("dddd") & " ( " & Me.dtpDataRadi.Value.ToString("d  MMM") & ") "
            labelDia2.Location = New Point((pnlDies.Width / 3), 5)
            labelDia2.Size = New Size((pnlDies.Width / 3), 13)
        End If
        pnlDies.Refresh()

    End Sub

    Private Sub PintaHores()
        'Pinta Hores
        picHores.Image = Nothing
        Dim bitmap As Bitmap = New Bitmap(picHores.Width, Me.picHores.Height)
        Dim g As Graphics = Nothing
        g = Graphics.FromImage(bitmap)
        Dim ColorMalla As Color = Color.FromArgb(193, 193, 193)
        Dim p As Pen = New Pen(ColorMalla)

        Dim UnitatTemps As Integer = picHores.Height / 96
        Dim y As Integer = UnitatTemps
        Dim Min As Integer = 0
        Do Until y >= picHores.Height
            If picHores.Height > 2000 Then
                g.DrawLine(p, picHores.Width - 6, y, picHores.Width, y)
                Dim ts As TimeSpan = New TimeSpan(0, Min, 0)
                Min += 15
                Dim str As String = String.Format("{0:00}:{1:00}", ts.Hours, ts.Minutes)
                g.DrawString(str, New Font("Microsoft Sans Serif", 8, FontStyle.Regular), Brushes.Black, 0, y - 6)
            Else
                If y Mod (UnitatTemps * 2) = 0 Then
                    g.DrawLine(p, picHores.Width - 6, y, picHores.Width, y)
                    Dim ts As TimeSpan = New TimeSpan(0, Min, 0)
                    Min += 30
                    Dim str As String = String.Format("{0:00}:{1:00}", ts.Hours, ts.Minutes)
                    g.DrawString(str, New Font("Microsoft Sans Serif", 8, FontStyle.Regular), Brushes.Black, 0, y - 6)
                Else
                    g.DrawLine(p, picHores.Width - 4, y, picHores.Width, y)
                End If
            End If

            y = y + UnitatTemps
        Loop


        If Not p Is Nothing Then
            p.Dispose()
        End If
        If Not g Is Nothing Then
            g.Dispose()
        End If

        Me.picHores.Image = bitmap
    End Sub

    Sub FrmCalendarPubliResize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Try
            PintaDies()
            PintaCalendar()
        Catch ex As Exception
        End Try
    End Sub

    Sub CmbExitClick(sender As Object, e As EventArgs) Handles cmdExitTool.Click, cmbExit.Click
        Me.Close()
    End Sub

    Sub ButtonResizeCalendarMesClick(sender As Object, e As EventArgs) Handles buttonResizeCalendarMes.Click, buttonResizeCalendarMenys.Click

        If CType(sender, Button).Text = "+" Then
            If picHores.Height > 4000 Then Exit Sub
            picHores.Height = picHores.Height + 384

        Else
            If picHores.Height < 500 Then Exit Sub
            picHores.Height = picHores.Height - 384
        End If

        picCalendar.Height = picHores.Height
        PintaHores()
        PintaCalendar()
    End Sub

    Private Sub PintaCalendar()
        picCalendar.Image = Nothing
        Dim bitmap As Bitmap = New Bitmap(picCalendar.Width, Me.picCalendar.Height)
        Dim g As Graphics = Nothing
        g = Graphics.FromImage(bitmap)
        Dim ColorMalla As Color = Color.FromArgb(193, 193, 193)
        Dim p As Pen = New Pen(ColorMalla)

        Dim Unitat As Integer = (picCalendar.Height / 96)
        UnitatMin = (Unitat / 30) * 2
        Dim y As Integer = Unitat
        Dim Min As Integer = 0
        g.DrawLine(p, 0, 0, picCalendar.Width, 0)
        Do Until y >= picCalendar.Height
            If y Mod (Unitat * 2) = 0 Then
                g.DrawLine(p, 0, y, picCalendar.Width, y)
            End If
            y += Unitat
        Loop


        Dim Dia As Integer = 0
        Dim x As Integer = 0
        If ShowCalendar = listCalendar.Setmana Then
            UnitatDies = picCalendar.Width / 49
            For i As Integer = 0 To 6
                x = (picCalendar.Width / 7) * i
                g.DrawLine(p, x, 0, x, picCalendar.Height)
                PuntIniXDies(Dia) = x + MargeItems
                Dia += 1
            Next
        Else
            UnitatDies = picCalendar.Width / 9
            For i As Integer = 0 To 2
                x = (picCalendar.Width / 3) * i
                g.DrawLine(p, x, 0, x, picCalendar.Height)
            Next
        End If
        g.DrawLine(p, CInt(picCalendar.Width - 1), 0, CInt(picCalendar.Width - 1), picCalendar.Height)


        If Not p Is Nothing Then
            p.Dispose()
        End If
        If Not g Is Nothing Then
            g.Dispose()
        End If

        Me.picCalendar.Image = bitmap

        'repinta els items del calendari
        PintaItemsCalendar()
    End Sub


    Sub PictureBoxCalendarClick(sender As Object, e As EventArgs) Handles PictureBoxCalendar.Click
        ToolTip1.RemoveAll()
        If ShowCalendar = listCalendar.Dia Then
            PictureBoxCalendar.Image = Me.ImageListCalendar.Images(2)
            '           PictureBoxCalendar.Tag = 1
            ShowCalendar = listCalendar.Setmana
            ToolTip1.SetToolTip(cmdAnt, cmdAnt_Setmana_ToolTip)
            ToolTip1.SetToolTip(cmdActual, cmdActual_ToolTip)
            ToolTip1.SetToolTip(cmdPost, cmdPost_Setmana_ToolTip)
        Else
            PictureBoxCalendar.Image = Me.ImageListCalendar.Images(1)
            '          PictureBoxCalendar.Tag = 2
            ShowCalendar = listCalendar.Dia
            ToolTip1.SetToolTip(cmdAnt, cmdAnt_Dia_ToolTip)
            ToolTip1.SetToolTip(cmdActual, cmdActual_ToolTip)
            ToolTip1.SetToolTip(cmdPost, cmdPost_Dia_ToolTip)
        End If
        PintaHores()
        PintaCalendar()
        BuscaItemsCalendari()
    End Sub

    Dim cmdAnt_Dia_ToolTip As String
    Dim cmdAnt_Setmana_ToolTip As String
    Dim cmdActual_ToolTip As String
    Dim cmdPost_Dia_ToolTip As String
    Dim cmdPost_Setmana_ToolTip As String
    Dim LABEL_REP_LOCUTOR As String
    Dim LABEL_REP_PRODUCTE As String

    Public Sub setLanguageForm()
        lang.StrForm = Me.Name

        LABEL_REP_LOCUTOR = lang.getText("LABEL_REP_LOCUTOR") '"Repetició Locutor"
        LABEL_REP_PRODUCTE = lang.getText("LABEL_REP_PRODUCTE") '"Repetició Producte"
        Me.ToolTip1.SetToolTip(picLocutor, LABEL_REP_LOCUTOR)
        Me.ToolTip1.SetToolTip(picProduc, LABEL_REP_PRODUCTE)

        cmdAnt_Dia_ToolTip = lang.getText("LABEL_UN_DIA_ABANS", True) '"Un dia abans"
        cmdAnt_Setmana_ToolTip = lang.getText("LABEL_UNA_SETMANA_ABANS", True) '"Una setmana abans"
        cmdActual_ToolTip = lang.getText("LABEL_GOTO_AVUI", True) '"Vés a avui"
        cmdPost_Dia_ToolTip = lang.getText("LABEL_UN_DIA_DESPRES", True) '"Un dia després"
        cmdPost_Setmana_ToolTip = lang.getText("LABEL_UNA_SETMANA_DESPRES", True) '"Una setmana després"

        ToolTip1.SetToolTip(cmdAnt, cmdAnt_Setmana_ToolTip)
        ToolTip1.SetToolTip(cmdActual, cmdActual_ToolTip)
        ToolTip1.SetToolTip(cmdPost, cmdPost_Setmana_ToolTip)

        'cmdSalvar.ToolTipText = lang.getText("LABEL_SALVAR_ITEM", True)
        cmdBorrar.ToolTipText = lang.getText("LABEL_DELETE", True) '"Borrar"
        lbInfoSave.ToolTipText = MSG_SAVED_DATA
        Me.cmdActual.Text = lang.getText("LABEL_AVUI", True) '"Avui"

        Me.cmdExitTool.ToolTipText = lang.getText("LABEL_TANCAR_PANTALLA", True) '"Tancar pantalla"
        Me.cmdBloqueix.Text = lang.getText("LABEL_EDIT_ITEM", True) '"Editar ítem"

        Me.ProgarmaToolStripMenuItem.Text = lang.getText("LABEL_PROGRAMA", True) '"Programa"
        Me.mnuExit.Text = lang.getText("LABEL_EXIT", True) '"Sortir"
        Me.AjudaToolStripMenuItem.Text = lang.getText("mnu_Help", True) '"Ajuda"
        Me.mnu_Help.Text = lang.getText("mnuRefHelp.Text", True) '"Manual OnLine"

        Me.Text = lang.getText("Text") ' Calendari Publicitat

        Dim cmb As New combo
        cmb.OmpleCombo(Me.cmbListHoresDetall, TAULES_DBS.TAULA_BlocsPublicitat, TotsCap.NO_ADD)
    End Sub

    Friend Sub BuscaItemsCalendari()
        ' Buscar la pauta per tot el dia seleccionat
        Dim toolTip As String = ""
        Dim Nom As String = ""
        'Dim dateIni As Date
        'Dim Durada As TimeSpan
        'Dim TipAssg As Integer
        Dim StrSql As String = ""
        Dim dTable As DataTable = Nothing
        Dim db As New MSC.dbs(Cloud)

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.AppStarting
        picCalendar.Controls.Clear()

        PintaDies()
        Dim dataRadi As Date = New Date(dtpDataRadi.Value.Year, dtpDataRadi.Value.Month, dtpDataRadi.Value.Day, 0, 0, 0)


        Dim data_in As Date '= dataRadi.AddDays(-(dataRadi.DayOfWeek() - 1))
        Dim data_out As Date '= data_in.AddDays(6)

        If ShowCalendar = listCalendar.Setmana Then
            Dim dayDiff As Integer = Weekday(dataRadi, FirstDayOfWeek.Monday) - DayOfWeek.Monday
            data_in = dataRadi.AddDays(-dayDiff)
            data_out = data_in.AddDays(6)
        Else
            data_in = dataRadi
            data_out = dataRadi
        End If
        Do While (data_in <= data_out)
            Dim DiaSem As Integer = Weekday(data_in, vbMonday)
            Dim tbBlocs As DataTable = BlocsPublicitat()
            For i As Integer = 0 To tbBlocs.Rows.Count - 1
                Dim nomBloc As String = tbBlocs.Rows(i)("blocID").ToString
                Dim HoraBloc As String = tbBlocs.Rows(i)("blocNom").ToString

                Dim Origen As String = "SELECT falques.falc_id, falques.falc_nom, clients.cli_nom, producte.produc_nom, falques.falc_locutor, falques.falc_producte, falques.falc_durada "
                Origen = Origen + "FROM ((clients INNER JOIN falques ON clients.cli_id = falques.falc_client) "
                Origen = Origen + "INNER JOIN producte ON falques.falc_producte = producte.produc_id) "
                Origen = Origen + "INNER JOIN radiaciofalques" & DiaSem & " ON falques.falc_id = radiaciofalques" & DiaSem & ".radiID"
                Origen = Origen + " WHERE (((radiaciofalques" & DiaSem & "." & nomBloc & ")= 1 ) AND ((falques.falc_datain)<= '" & Strings.Format(data_in, "yyyy/MM/dd") & "') AND ((falques.falc_dataout)>= '" & Strings.Format(data_in, "yyyy/MM/dd") & "' AND falques.falc_activa=1)) ORDER BY radiaciofalques" & DiaSem & ".radiOrdre ;"
                dTable = db.getTable(Origen)
                Dim oldlocutor As Integer = 0
                Dim oldProduc As Integer = 0
                Dim Bloc As String = ""
                For N As Integer = 0 To dTable.Rows.Count - 1
                    Bloc = Strings.Format(data_in, "yyyyMMdd") & "blc" & HoraBloc
                    Dim publi_id As Integer = CInt(dTable.Rows(N)("falc_id"))
                    Dim publi_nom As String = dTable.Rows(N)("falc_nom").ToString
                    Dim ErrLoc As Boolean = False
                    If oldlocutor <> 0 AndAlso CInt(dTable.Rows(N)("falc_locutor")) = oldlocutor Then
                        ErrLoc = True
                    End If
                    Dim ErrPro As Boolean = False
                    If oldProduc <> 0 AndAlso CInt(dTable.Rows(N)("falc_producte")) = oldProduc Then
                        ErrPro = True
                    End If
                    'Pintem tots els anuncis que trobem					
                    NewPanelPubli(publi_id, publi_nom, data_in, HoraBloc, publi_nom & " " & data_in, ErrLoc, ErrPro, Bloc)
                    oldlocutor = CInt(dTable.Rows(N)("falc_locutor"))
                    oldProduc = CInt(dTable.Rows(N)("falc_producte"))

                Next
            Next

            data_in = data_in.AddDays(1)
        Loop
        PintaItemsCalendar()
    End Sub

    Private Sub NewPanelPubli(Publi_id As Integer, nom As String, data_radi As Date, HoraBloc As String, toolTip As String, ErrorLocutor As Boolean, ErrorProduc As Boolean, nbloc As String)
        Dim b_minut As String
        Select Case HoraBloc.Substring(3, 2)
            Case "00" : b_minut = "05"
            Case "15" : b_minut = "20"
            Case "30" : b_minut = "40"
            Case "45" : b_minut = "50"
        End Select
        Dim Bloc As String = "radi" & HoraBloc.Substring(0, 2) & b_minut

        'Dim PanelPubli As New Panel
        Dim PanelPubli As New MetroFramework.Controls.MetroPanel
        PanelPubli.Name = Publi_id.ToString & data_radi.ToString("yyyy/MM/dd") & Bloc
        PanelPubli.Tag = nbloc
        'Dim LbLink As New LinkLabel
        Dim LbLink As New MetroFramework.Controls.MetroLink
        'LbLink.Name = "LbLink"
        LbLink.Text = nom
        LbLink.Tag = Publi_id
        LbLink.TextAlign = ContentAlignment.MiddleCenter
        LbLink.Parent = PanelPubli
        LbLink.Dock = DockStyle.Top
        'LbLink.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
        '                            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        LbLink.UseCustomBackColor = True
        LbLink.BackColor = Color.Transparent

        LbLink.FontSize = MetroFramework.MetroLinkSize.Small

        LbLink.AllowDrop = True
        AddHandler LbLink.MouseDown, AddressOf MouseDown_falca
        AddHandler LbLink.MouseHover, AddressOf linkPubli_MouseHover

        AddHandler PanelPubli.MouseLeave, AddressOf PanelPubli_MouseLeave
        'AddHandler LbLink.MouseLeave, AddressOf PanelPubli_MouseLeave

        Me.ToolTip1.SetToolTip(LbLink, toolTip)
        Me.ToolTip1.SetToolTip(PanelPubli, toolTip)

        Dim lbDataProg As New Label
        lbDataProg.Name = "lbDataProg"
        Dim dtTime As DateTime = Convert.ToDateTime(HoraBloc)
        Dim new_date As DateTime = New DateTime(data_radi.Year, data_radi.Month, data_radi.Day, dtTime.Hour, dtTime.Minute, 0)
        lbDataProg.Text = new_date.ToString

        lbDataProg.Visible = False
        lbDataProg.Tag = Publi_id
        lbDataProg.Parent = PanelPubli
        '------------------
        If ErrorLocutor = True Then
            Dim lnkLocu As New MetroFramework.Controls.MetroLink
            'lnkLocu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            lnkLocu.Image = Me.picLocutor.Image
            lnkLocu.Location = New System.Drawing.Point(4, 18)
            lnkLocu.Name = "lnkLocu"
            lnkLocu.Size = New System.Drawing.Size(23, 23)
            lnkLocu.TabIndex = 201
            lnkLocu.UseSelectable = True
            lnkLocu.Parent = PanelPubli
            lnkLocu.Visible = True
            lnkLocu.UseCustomBackColor = True
            lnkLocu.BackColor = Color.Transparent
            Me.ToolTip1.SetToolTip(lnkLocu, LABEL_REP_LOCUTOR)
            AddHandler lnkLocu.MouseLeave, AddressOf PanelPubli_MouseLeave
        End If
        If ErrorProduc = True Then
            Dim lnkBrand As New MetroFramework.Controls.MetroLink
            'lnkBrand.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            lnkBrand.Image = Me.picProduc.Image
            lnkBrand.Location = New System.Drawing.Point(25, 18)
            lnkBrand.Name = "lnkBrand"
            lnkBrand.Size = New System.Drawing.Size(23, 23)
            lnkBrand.TabIndex = 201
            lnkBrand.UseSelectable = True
            lnkBrand.Parent = PanelPubli
            lnkBrand.Visible = True
            lnkBrand.UseCustomBackColor = True
            lnkBrand.BackColor = Color.Transparent
            Me.ToolTip1.SetToolTip(lnkBrand, LABEL_REP_PRODUCTE)
            AddHandler lnkBrand.MouseLeave, AddressOf PanelPubli_MouseLeave
        End If
        '-------------
        PanelPubli.UseCustomBackColor = True
        PanelPubli.BackColor = getColorFrangeHoraria(new_date)
        PanelPubli.Size = New System.Drawing.Size(23, 20)
        'PanelPubli.MinimumSize = New System.Drawing.Size(20, 10)
        'PanelPubli.MaximumSize = New System.Drawing.Size(23, 20)
        PanelPubli.BorderStyle = BorderStyle.FixedSingle
        PanelPubli.Parent = Me.picCalendar

    End Sub

    Private Sub PintaItemsCalendar()
        Dim desplaca As Integer = 0
        For Each MyPanel As Control In picCalendar.Controls
            If (TypeOf MyPanel Is MetroFramework.Controls.MetroPanel) Then
                MyPanel.Visible = True
                Static Old_date As Date
                Dim Duration As Integer = 18
                Dim DataProg As Date = CDate(CType(MyPanel.Controls("lbDataProg"), Label).Text)
                If Old_date = DataProg Then
                    desplaca += 21
                Else
                    desplaca = 0
                End If
                Old_date = DataProg
                Dim nd As Short = 3
                If ShowCalendar = listCalendar.Setmana Then nd = 7
                MyPanel.Size = New Size(((UnitatDies * nd) / 5) - (MargeItems * 2), Duration * UnitatMin)

                Dim x As Integer = (picCalendar.Width / 3) + 2
                If ShowCalendar = listCalendar.Setmana Then x = PuntIniXDies(Weekday(DataProg, FirstDayOfWeek.Monday) - 1)

                Dim y As Integer = (DataProg.Hour * 60 + DataProg.Minute) * UnitatMin + (UnitatMin * 30)
                MyPanel.Location = New Point(x + desplaca, y)
            End If
        Next
    End Sub

    Sub DtpDataRadiValueChanged(sender As Object, e As EventArgs) Handles dtpDataRadi.ValueChanged
        BuscaItemsCalendari()
    End Sub

    Dim panelMove As MetroFramework.Controls.MetroPanel
    'Dim panelMove As Panel
    Private Sub MouseDown_falca(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        lbInfoSave.Visible = False
        Dim Mylabel As MetroFramework.Controls.MetroLink = CType(sender, MetroFramework.Controls.MetroLink)
        panelMove = CType(Mylabel.Parent, MetroFramework.Controls.MetroPanel)
        Mylabel.DoDragDrop(Mylabel, DragDropEffects.Copy)
        Dim DataProg As Date
        Dim id_publi As Integer = 0
        picLocutor.Visible = False
        picProduc.Visible = False
        Try
            For i As Integer = 0 To panelMove.Controls.Count - 1
                Dim MyControl As Control = panelMove.Controls(i)
                If (MyControl.GetType() Is GetType(Label)) Then
                    DataProg = CDate(CType(panelMove.Controls(i), Label).Text)
                    id_publi = CInt(CType(panelMove.Controls(i), Label).Tag)
                ElseIf (MyControl.GetType() Is GetType(MetroFramework.Controls.MetroLink)) And MyControl.Name = "lnkLocu" Then
                    picLocutor.Visible = True
                ElseIf (MyControl.GetType() Is GetType(MetroFramework.Controls.MetroLink)) And MyControl.Name = "lnkBrand" Then
                    picProduc.Visible = True
                End If
            Next
        Catch ex As Exception
            Exit Sub
        End Try

        Me.lbNomDetall.Text = Mylabel.Text
        lbNomDetall.Tag = id_publi
        Me.dtpDetallData.Value = DataProg
        Me.dtpDetallData.Tag = DataProg
        Dim b_minut As String
        Select Case DataProg.ToString("mm")
            Case "00" : b_minut = "05"
            Case "15" : b_minut = "20"
            Case "30" : b_minut = "40"
            Case "45" : b_minut = "50"
        End Select
        Dim Bloc As String = "radi" & DataProg.ToString("HH") & b_minut
        Me.cmbListHoresDetall.SelectedValue = Bloc
        Me.cmbListHoresDetall.Tag = Bloc
    End Sub

    Sub PicCalendarDragEnter(sender As Object, e As DragEventArgs) Handles picCalendar.DragEnter
        If Not IsNothing(panelMove) Then
            e.Effect = DragDropEffects.Copy
            Dim LocalMousePosition As Point = picCalendar.PointToClient(System.Windows.Forms.Cursor.Position)
            panelMove.Location = LocalMousePosition
        End If


        'If e.Data.GetDataPresent(GetType(MetroFramework.Controls.MetroLink)) Or e.Data.GetDataPresent(GetType(MetroFramework.Controls.MetroPanel)) Then
        '    e.Effect = DragDropEffects.Copy
        '    Dim LocalMousePosition As Point = picCalendar.PointToClient(System.Windows.Forms.Cursor.Position)
        '    panelMove.Location = LocalMousePosition
        'Else
        '    e.Effect = DragDropEffects.None
        'End If

    End Sub

    Sub PicCalendarDragDrop(sender As Object, e As DragEventArgs) Handles picCalendar.DragDrop
        'canviar valors 
        Dim DataProg As Date
        Dim id_publi As Integer = 0
        For i As Integer = 0 To panelMove.Controls.Count - 1
            Dim MyControl As Control = panelMove.Controls(i)
            If (MyControl.GetType() Is GetType(Label)) Then
                DataProg = CDate(CType(panelMove.Controls(i), Label).Text)
                id_publi = CInt(CType(panelMove.Controls(i), Label).Tag)
            End If
        Next

        Dim LocalMousePosition As Point = picCalendar.PointToClient(System.Windows.Forms.Cursor.Position)
        Dim minut As Integer = (LocalMousePosition.Y / UnitatMin)
        Dim ts As TimeSpan = New TimeSpan(0, minut, 0)
        'Ajustar al quart d'hora corresponent
        Dim MyMinute As Integer = 0
        Select Case ts.Minutes
            Case 0 To 10 : MyMinute = 0
            Case 11 To 20 : MyMinute = 15
            Case 21 To 40 : MyMinute = 30
            Case 41 To 59 : MyMinute = 45
        End Select
        'valor antic
        Dim Old_diaset As Integer = Weekday(DataProg, FirstDayOfWeek.Monday)

        Dim b_minut As String
        Select Case DataProg.ToString("mm")
            Case "00" : b_minut = "05"
            Case "15" : b_minut = "20"
            Case "30" : b_minut = "40"
            Case "45" : b_minut = "50"
        End Select

        Dim old_Bloc As String = "radi" & DataProg.Hour.ToString("00") & b_minut
        'nous valor	
        Dim new_date As Date
        If ShowCalendar = listCalendar.Setmana Then
            'Buscar la data segons la nova posició
            Dim actualDia As Integer = Weekday(DataProg, FirstDayOfWeek.Monday)
            Dim pixDia As Integer = Me.picCalendar.Width / 49
            Dim proxDia As Integer = Math.Truncate((LocalMousePosition.X / pixDia) / 7) + 1
            Dim diadiff As Integer
            If actualDia > proxDia Then
                diadiff = actualDia - proxDia
                new_date = New DateTime(DataProg.Year, DataProg.Month, DataProg.Day, ts.Hours, MyMinute, 0)
                new_date = new_date.AddDays(-diadiff)
            Else
                diadiff = proxDia - actualDia
                new_date = New DateTime(DataProg.Year, DataProg.Month, DataProg.Day, ts.Hours, MyMinute, 0)
                new_date = new_date.AddDays(diadiff)
            End If
        Else
            new_date = New DateTime(DataProg.Year, DataProg.Month, DataProg.Day, ts.Hours, MyMinute, 0)
        End If
        For i As Integer = 0 To panelMove.Controls.Count - 1
            Dim MyControl As Control = panelMove.Controls(i)
            If (MyControl.GetType() Is GetType(Label)) Then
                CType(panelMove.Controls(i), Label).Text = new_date
            End If
        Next

        Dim y As Integer = (new_date.Hour * 60 + new_date.Minute) * UnitatMin + (UnitatMin * 30)
        panelMove.Location = New Point(LocalMousePosition.X, y)
        panelMove.BackColor = getColorFrangeHoraria(new_date)

        'salvar valors
        Dim DiaSetmana As Integer = Weekday(new_date, FirstDayOfWeek.Monday)
        Select Case new_date.ToString("mm")
            Case "00" : b_minut = "05"
            Case "15" : b_minut = "20"
            Case "30" : b_minut = "40"
            Case "45" : b_minut = "50"
        End Select
        Dim Bloc As String = "radi" & new_date.Hour.ToString("00") & b_minut
        panelMove.Tag = new_date.ToString("yyyyMMdd") & "blc" & new_date.Hour.ToString("00") & ":" & b_minut

        ChangeBloc(old_Bloc, Old_diaset, Bloc, 51, id_publi, DiaSetmana)

        'Repinta tot el nou bloc
        Dim desplaca As Integer = 0
        For Each MyPanel As Control In picCalendar.Controls
            If MyPanel.Tag.ToString = panelMove.Tag.ToString Then
                'És del mateix bloc                
                Dim x As Integer = (picCalendar.Width / 3) + 2
                If ShowCalendar = listCalendar.Setmana Then x = PuntIniXDies(Weekday(DataProg, FirstDayOfWeek.Monday) - 1)
                MyPanel.Location = New Point(x + desplaca, y)
                desplaca += 21
            End If
        Next
        panelMove = Nothing
    End Sub

    Sub CmdBloqueixClick(sender As Object, e As EventArgs) Handles cmdBloqueix.Click
        LockedRecord()
    End Sub

    Dim blEnable As Boolean = False
    Private Sub LockedRecord()
        '		If Me.cmdSalvar.Enabled = True And saved = False Then
        '			If MsgBox(MSG_SAVE_DADES, vbOKCancel, MSG_ATENCIO) = MsgBoxResult.Ok Then SaveRecord()
        '		End If
        blEnable = Not blEnable

        Me.picCalendar.AllowDrop = blEnable
        cmbListHoresDetall.Enabled = blEnable
        dtpDetallData.Enabled = blEnable
        cmdBorrar.Enabled = blEnable
        If blEnable Then
            Me.cmdBloqueix.Image = Me.picUnLock.Image
        Else
            Me.cmdBloqueix.Image = Me.picLock.Image
            Me.cmdSalvar.Enabled = False
        End If
    End Sub

    Private Sub Changed()
        If blEnable = True Then Me.cmdSalvar.Enabled = True
    End Sub

    Sub CmdSalvarClick(sender As Object, e As EventArgs) Handles cmdSalvar.Click
        Dim Old_bloc As String = Me.cmbListHoresDetall.Tag
        Dim Bloc As String = Me.cmbListHoresDetall.SelectedValue

        Dim old_diaSet As Integer = Weekday(dtpDetallData.Tag, FirstDayOfWeek.Monday)
        Dim diaSet As Integer = Weekday(dtpDetallData.Value, FirstDayOfWeek.Monday)

        Dim id As String = Me.lbNomDetall.Tag

        ChangeBloc(Old_bloc, old_diaSet, Bloc, 50, id, diaSet)
        'pinta el panel		
        Dim hora As Integer = CInt(cmbListHoresDetall.Text.Substring(0, 2))
        Dim minut As Integer = CInt(cmbListHoresDetall.Text.Substring(3, 2))
        Dim new_date As Date = New DateTime(dtpDetallData.Value.Year, dtpDetallData.Value.Month, dtpDetallData.Value.Day, hora, minut, 0)

        Dim name_panel As String = id & dtpDetallData.Value.ToString("yyyy/MM/dd") & Old_bloc

        For Each MyPanel As Control In picCalendar.Controls
            If (TypeOf MyPanel Is MetroFramework.Controls.MetroPanel) Then
                If MyPanel.Name = name_panel Then
                    Dim y As Integer = (new_date.Hour * 60 + new_date.Minute) * UnitatMin + (UnitatMin * 30)
                    Dim x As Integer = (picCalendar.Width / 3) + 2
                    If ShowCalendar = listCalendar.Setmana Then x = PuntIniXDies(Weekday(new_date, FirstDayOfWeek.Monday) - 1)
                    MyPanel.Location = New Point(x + 60, y)
                    MyPanel.BackColor = getColorFrangeHoraria(new_date)
                    MyPanel.Tag = new_date.ToString("yyyyMMdd") & "blc" & new_date.Hour.ToString("00") & ":" & minut
                    For i As Integer = 0 To MyPanel.Controls.Count - 1
                        Dim MyControl As Control = MyPanel.Controls(i)
                        If (MyControl.GetType.Name = "Label") Then
                            MyControl.Text = new_date
                            'CType(panelMove.Controls(i), Label).Text = new_date
                            Exit For
                        End If
                    Next
                End If
            End If
        Next
    End Sub

    Private Sub ChangeBloc(Old_bloc As String, old_diaSet As Integer, Bloc As String, Ordre As String, id As Integer, diaSet As Integer)
        Dim db As New MSC.dbs(Cloud)
        db.IniTransaction()
        Dim StrSql As String = "UPDATE radiaciofalques" & old_diaSet
        StrSql = StrSql & " SET "
        StrSql = StrSql & " " & Old_bloc & " = 0"
        StrSql = StrSql & " WHERE radiID = " & id & " ;"

        db.Update_ID(StrSql)
        StrSql = "UPDATE radiaciofalques" & diaSet
        StrSql = StrSql & " SET "
        StrSql = StrSql & " " & Bloc & " = 1"
        StrSql = StrSql & ", radiOrdre = " & Ordre
        StrSql = StrSql & " WHERE radiID = " & id & " ;"

        db.Update_ID(StrSql)
        db.EndTransaction()
        db = Nothing
        lbInfoSave.Visible = True
    End Sub

    Sub DtpDetallDataValueChanged(sender As Object, e As EventArgs) Handles dtpDetallData.ValueChanged
        Changed()
    End Sub

    Sub CmbListHoresDetallSelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbListHoresDetall.SelectedIndexChanged
        Changed()
    End Sub

    Sub CmdBorrarClick(sender As Object, e As EventArgs) Handles cmdBorrar.Click
        Dim id As String = Me.lbNomDetall.Tag
        If id = 0 Then Exit Sub
        If MsgBox(MSG_CONFIRM_DELETE_DADES, MsgBoxStyle.OkCancel, MSG_ATENCIO) = MsgBoxResult.Cancel Then Exit Sub
        Dim diaSet As Integer = Weekday(dtpDetallData.Value, FirstDayOfWeek.Monday)
        Dim Bloc As String = Me.cmbListHoresDetall.SelectedValue
        Dim StrSql As String = "UPDATE radiaciofalques" & diaSet
        StrSql = StrSql & " SET "
        StrSql = StrSql & " " & Bloc & " = 0"
        StrSql = StrSql & " WHERE radiID = " & id & " ;"
        Dim db As New MSC.dbs(Cloud)
        db.Update_ID(StrSql)
        db = Nothing
        Dim name_panel As String = id & dtpDetallData.Value.ToString("yyyy/MM/dd") & Bloc
        For Each MyPanel As Control In picCalendar.Controls
            If (TypeOf MyPanel Is Panel) Then
                If MyPanel.Name = name_panel Then
                    picCalendar.Controls.Remove(MyPanel)
                    Me.lbNomDetall.Text = ""
                    Me.lbNomDetall.Tag = 0
                    Exit For
                End If
            End If
        Next
    End Sub

    Sub CmdPostClick(sender As Object, e As EventArgs) Handles cmdPost.Click
        If ShowCalendar = listCalendar.Setmana Then
            Me.dtpDataRadi.Value = Me.dtpDataRadi.Value.AddDays(7)
        Else
            Me.dtpDataRadi.Value = Me.dtpDataRadi.Value.AddDays(1)
        End If
    End Sub

    Sub CmdAntClick(sender As Object, e As EventArgs) Handles cmdAnt.Click
        If ShowCalendar = listCalendar.Setmana Then
            Me.dtpDataRadi.Value = Me.dtpDataRadi.Value.AddDays(-7)
        Else
            Me.dtpDataRadi.Value = Me.dtpDataRadi.Value.AddDays(-1)
        End If
    End Sub

    Private Sub frmCalendarPubli_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        Dim FitxerINI As New IniFile
        frm_sice(0) = Me.Width : frm_sice(1) = Me.Height
        FitxerINI.INIWrite(MyAPP.IniFile, "Data Gest", "size", frm_sice(0).ToString & "," & frm_sice(1).ToString)
    End Sub

    Private Sub linkPubli_MouseHover(sender As Object, e As EventArgs)
        'Mostra detall
        Try
            Dim MyLink As MetroFramework.Controls.MetroLink = CType(sender, MetroFramework.Controls.MetroLink)
            Dim MyPanel As MetroFramework.Controls.MetroPanel = CType(MyLink.Parent, MetroFramework.Controls.MetroPanel)
            MyPanel.Size = New System.Drawing.Size(90, 40)
        Catch ex As Exception
        End Try

    End Sub

    Private Sub PanelPubli_MouseLeave(sender As Object, e As EventArgs)
        'Amaga detall
        Try
            Dim MyPanel As MetroFramework.Controls.MetroPanel
            If sender.GetType Is GetType(MetroFramework.Controls.MetroPanel) Then
                MyPanel = CType(sender, MetroFramework.Controls.MetroPanel)
            Else
                Dim lk As Control = CType(sender, Control)
                MyPanel = CType(lk.Parent, MetroFramework.Controls.MetroPanel)
            End If
            MyPanel.Size = New System.Drawing.Size(23, 20)

        Catch ex As Exception
        End Try

    End Sub
End Class
