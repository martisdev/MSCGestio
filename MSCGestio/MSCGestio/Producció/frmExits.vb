Option Strict Off
Option Explicit On
Imports System.Drawing.Drawing2D

Public Class frmExits
	Private DragLV As System.Windows.Forms.ListViewItem 'The item being dragged
	Dim InfoMsg As frmTip
	'Dim LListaExits As New msc_dbs.ClasLlistaExits
	
	Private Sub CloseForm()
        If Me.cmdSalvar.Enabled Then
            If MetroFramework.MetroMessageBox.Show(Me, MSG_SAVE_DADES, MSG_ATENCIO, MessageBoxButtons.YesNo, MessageBoxIcon.Information, 100) = DialogResult.Yes Then SaveRecord()
        End If
        If Bass.BASS_ChannelIsActive(StreamHandlePlay) Then Call Bass.BASS_StreamFree(StreamHandlePlay)
		MyAPP.CloseSesionClient(MyAPP.IDSesion_Client, DESCRIP_FORM_EXITS)
		Me.Dispose()
	End Sub
	
	Private Sub frmExits_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		CloseForm()
	End Sub
	
	Private Sub cmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDel.Click
		BorrarTrackllista()
	End Sub
	
	Private Sub BorrarTrackllista()
		Dim StrSql As String = "UPDATE llistaexits"
		StrSql = StrSql & " SET "
		StrSql = StrSql & " tops_activa = 0 "
		StrSql = StrSql & ", tops_dataout = '" & Now.ToString("yyyy-MM-dd HH:mm:ss") & "'"
        StrSql = StrSql & " WHERE tops_id = " & MetroListViewTops.FocusedItem.Tag & " ;"
        Dim db As New MSC.dbs(Cloud)
        db.Update_ID(StrSql)
        db = Nothing
        Me.MetroListViewTops.Items.RemoveAt(MetroListViewTops.FocusedItem.Index)
        Me.cmdDel.Enabled = IIf(Me.MetroListViewTops.Items.Count > 0, True, False)
        Me.cmdSalvar.Enabled = True
        mnuSave.Enabled = True
        RecalculaPosicions()

    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Dim Numintro As Short
        'Necessitem saber en quin nº es vol entrar
        Try
            Numintro = CShort(InputBox(MSG_POSICIO_IN, MSG_POSICIO_IN_TITLE, " "))
        Catch ex As Exception
            'MsgBox("El valor no és vàlid, només s'acepten números", MsgBoxStyle.Exclamation, "Atenció")
            Numintro = MetroListViewTops.Items.Count
        End Try

        Dim IdTema As Short = Me.lstMusicDisp.FocusedItem.Tag
        ' El nº no pot ser més gran que el recompte total
        If Numintro > Me.MetroListViewTops.Items.Count + 1 Then Numintro = MetroListViewTops.Items.Count + 1
        Dim db As New MSC.dbs(Cloud)
        Dim StrSql As String = "select tema_titol, tema_votes,interp_nom FROM temes,interprets Where tema_interp=interp_id AND tema_id=" & IdTema & " ;"
        Dim dt As DataTable = db.getTable(StrSql)

        Dim NewItem As New System.Windows.Forms.ListViewItem
        NewItem.Text = dt.Rows(0)("tema_titol").ToString
        NewItem.Tag = IdTema.ToString
        NewItem.ImageKey = "new"

        Dim subItem As New ListViewItem.ListViewSubItem
        subItem.Text = dt.Rows(0)("interp_nom").ToString : subItem.Tag = "EsNou" : NewItem.SubItems.Add(subItem)
        subItem = New ListViewItem.ListViewSubItem : subItem.Text = Microsoft.VisualBasic.Format(Numintro, "0#") : NewItem.SubItems.Add(subItem)
        subItem = New ListViewItem.ListViewSubItem : subItem.Text = Strings.Format(Now, "yyyy-MM-dd HH:mm:ss") : NewItem.SubItems.Add(subItem)
        subItem = New ListViewItem.ListViewSubItem : subItem.Text = "" : NewItem.SubItems.Add(subItem)
        subItem = New ListViewItem.ListViewSubItem : subItem.Text = "" : NewItem.SubItems.Add(subItem)
        subItem = New ListViewItem.ListViewSubItem : subItem.Text = Microsoft.VisualBasic.Format(Numintro, "0#") : NewItem.SubItems.Add(subItem)
        subItem = New ListViewItem.ListViewSubItem : subItem.Text = Microsoft.VisualBasic.Format(CInt(dt.Rows(0)("tema_votes")), "0#") : NewItem.SubItems.Add(subItem)
        subItem = New ListViewItem.ListViewSubItem : subItem.Text = 0 : NewItem.SubItems.Add(subItem)
        subItem = New ListViewItem.ListViewSubItem : subItem.Text = 0 : NewItem.SubItems.Add(subItem)
        MetroListViewTops.Items.Insert(Numintro - 1, NewItem)
        RecalculaPosicions()

        lstMusicDisp.Items.RemoveAt(lstMusicDisp.FocusedItem.Index)
        Me.cmdSalvar.Enabled = True
        mnuSave.Enabled = True


    End Sub

    'Private Sub CanviPosicio(ByRef PosFinal As Short)
    '    Dim IdTemaP1, NumintroP1 As Short
    '    Dim DataInP1 As Date
    '    Dim Icon1, DataTopP1, temaP1, Interp1 As String
    '    Dim EsNou As Boolean
    '    Dim IdTemaP2, NumintroP2 As Short
    '    Dim DataInP2 As Date
    '    Dim Icon2, DataTopP2, temaP2, Interp2 As String
    '    Dim EsNou2 As Boolean
    '    Dim UltPos As Short
    '    Dim Vots1, Vots2 As Integer
    '    Dim Setmanes1, Setmanes2 As Integer
    '    Dim DV1, DV2 As Integer
    '    UltPos = Me.MetroListViewTops.Items.Count - 1
    '    Do Until UltPos = PosFinal
    '        IdTemaP1 = Me.MetroListViewTops.Items.Item(UltPos - 1).Tag
    '        temaP1 = Me.MetroListViewTops.Items.Item(UltPos - 1).SubItems.Item(1).Text
    '        EsNou = Me.MetroListViewTops.Items.Item(UltPos - 1).SubItems.Item(1).Tag
    '        Interp1 = Me.MetroListViewTops.Items.Item(UltPos - 1).SubItems.Item(2).Text
    '        DataInP1 = CDate(Me.MetroListViewTops.Items.Item(UltPos - 1).SubItems.Item(3).Text)
    '        DataTopP1 = Me.MetroListViewTops.Items.Item(UltPos - 1).SubItems.Item(4).Text
    '        NumintroP1 = CShort(Me.MetroListViewTops.Items.Item(UltPos - 1).SubItems.Item(5).Text)
    '        Vots1 = CInt(Me.MetroListViewTops.Items.Item(UltPos - 1).SubItems.Item(6).Text)
    '        Setmanes1 = CInt(Me.MetroListViewTops.Items.Item(UltPos - 1).SubItems.Item(7).Text)
    '        DV1 = CInt(Me.MetroListViewTops.Items.Item(UltPos - 1).SubItems.Item(8).Text)
    '        Icon1 = Me.MetroListViewTops.Items.Item(UltPos - 1).ImageKey

    '        'agafa els valors de la posició final
    '        IdTemaP2 = Me.MetroListViewTops.Items.Item(UltPos).Tag
    '        temaP2 = Me.MetroListViewTops.Items.Item(UltPos).SubItems.Item(1).Text
    '        EsNou2 = Me.MetroListViewTops.Items.Item(UltPos).SubItems.Item(1).Tag = "EsNou"
    '        Interp2 = Me.MetroListViewTops.Items.Item(UltPos).SubItems.Item(2).Text
    '        DataInP2 = CDate(Me.MetroListViewTops.Items.Item(UltPos).SubItems.Item(3).Text)
    '        DataTopP2 = Me.MetroListViewTops.Items.Item(UltPos).SubItems.Item(4).Text
    '        NumintroP2 = CShort(Me.MetroListViewTops.Items.Item(UltPos).SubItems.Item(5).Text)
    '        Vots2 = CInt(Me.MetroListViewTops.Items.Item(UltPos).SubItems.Item(6).Text)
    '        Setmanes2 = CInt(Me.MetroListViewTops.Items.Item(UltPos).SubItems.Item(7).Text)
    '        DV2 = CInt(Me.MetroListViewTops.Items.Item(UltPos).SubItems.Item(8).Text)
    '        Icon2 = Me.MetroListViewTops.Items.Item(UltPos).ImageKey

    '        'estableix els nous valors            
    '        Me.MetroListViewTops.Items.Item(UltPos - 1).Tag = CStr(IdTemaP2)
    '        Me.MetroListViewTops.Items.Item(UltPos - 1).SubItems.Item(1).Text = temaP2
    '        Me.MetroListViewTops.Items.Item(UltPos - 1).SubItems.Item(1).Tag = IIf(EsNou2 = True, "EsNou", "")
    '        Me.MetroListViewTops.Items.Item(UltPos - 1).SubItems.Item(2).Text = Interp2
    '        Me.MetroListViewTops.Items.Item(UltPos - 1).SubItems.Item(3).Text = CStr(DataInP2)
    '        If (UltPos - 1) = 1 Then DataTopP2 = CStr(Now)
    '        Me.MetroListViewTops.Items.Item(UltPos - 1).SubItems.Item(4).Text = DataTopP2
    '        Me.MetroListViewTops.Items.Item(UltPos - 1).SubItems.Item(5).Text = CStr(NumintroP2)
    '        Me.MetroListViewTops.Items.Item(UltPos - 1).SubItems.Item(6).Text = CStr(Vots2)
    '        Me.MetroListViewTops.Items.Item(UltPos - 1).SubItems.Item(7).Text = CStr(Setmanes2)
    '        Me.MetroListViewTops.Items.Item(UltPos - 1).SubItems.Item(8).Text = CStr(DV2)
    '        Me.MetroListViewTops.Items.Item(UltPos - 1).ImageKey = Icon2

    '        Me.MetroListViewTops.Items.Item(UltPos).Tag = CStr(IdTemaP1)
    '        Me.MetroListViewTops.Items.Item(UltPos).SubItems.Item(1).Text = temaP1
    '        Me.MetroListViewTops.Items.Item(UltPos).SubItems.Item(1).Tag = IIf(EsNou = True, "EsNou", "")
    '        Me.MetroListViewTops.Items.Item(UltPos).SubItems.Item(2).Text = Interp1
    '        Me.MetroListViewTops.Items.Item(UltPos).SubItems.Item(3).Text = CStr(DataInP1)
    '        Me.MetroListViewTops.Items.Item(UltPos).SubItems.Item(4).Text = DataTopP1
    '        Me.MetroListViewTops.Items.Item(UltPos).SubItems.Item(5).Text = CStr(NumintroP1)
    '        Me.MetroListViewTops.Items.Item(UltPos).SubItems.Item(6).Text = CStr(Vots1)
    '        Me.MetroListViewTops.Items.Item(UltPos).SubItems.Item(7).Text = CStr(Setmanes1)
    '        Me.MetroListViewTops.Items.Item(UltPos).SubItems.Item(8).Text = CStr(DV1)
    '        Me.MetroListViewTops.Items.Item(UltPos).ImageKey = Icon1

    '        UltPos = UltPos - 1
    '    Loop
    '    RecalculaPosicions()
    'End Sub

    Private Sub frmExits_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setLanguageForm()
        getMetroListViewTops()

        Dim UsrTipus As Integer = Usuari.UsrTipus
        Me.Text = Me.Text & " " & Params.NomRadio()
        Me.MetroListViewTops.AllowDrop = IIf(UsrTipus > NivellUsers.USR_CONVIDAT, True, False)

        Me.cmdPrint.Enabled = IIf(UsrTipus > NivellUsers.USR_CONVIDAT, True, False)
        'cmdDel.Enabled = IIf(UsrTipus > NivellUsers.USR_CONVIDAT, True, False)
        Me.mnuModif.Enabled = IIf(UsrTipus > NivellUsers.USR_CONVIDAT, True, False)
        Me.cmdBloqueix.Enabled = IIf(UsrTipus > NivellUsers.USR_CONVIDAT, True, False)

        txtDataIn.Value = DateSerial(Now.Year, Now.Month, Now.Day - 1)
        Me.ClientSize = New Size(frm_sice(0), frm_sice(1))
    End Sub

    Dim MSG_POSICIO_IN As String
    Dim MSG_POSICIO_IN_TITLE As String

    Public Sub setLanguageForm()
        lang.StrForm = Me.Name

        MSG_POSICIO_IN = lang.getText("MSG_POSICIO_IN") '"En quina posició entra?, zero equival a entrar la última"
        MSG_POSICIO_IN_TITLE = lang.getText("MSG_POSICIO_IN_TITLE") '"Entrada a la llista d'èxits"

        Me.ColumnHeaderTitol.Text = lang.getText("HEADERTEXT_TITOL", True) '"Títol tema"
        Me.ColumnHeaderInterp.Text = lang.getText("HEADERTEXT_INTERP", True) '"Intèrpret"				
        Me.ColumnHeader6.Text = lang.getText("HEADERTEXT_TITOL", True) '"Títol Tema"
        Me.ColumnHeader7.Text = lang.getText("HEADERTEXT_INTERP", True) '"Intèrpret"		
        Me.ProgarmaToolStripMenuItem.Text = lang.getText("LABEL_PROGRAMA", True) '"Programa"
        Me.mnuExit.Text = lang.getText("LABEL_EXIT", True) '"Sortir"
        Me.ReproductorToolStripMenuItem.Text = lang.getText("LABEL_REPRODUCTOR", True) '"Reproductor"
        Me.mnuPlay.Text = lang.getText("LABEL_PLAY_PAUSA", True) '"Play/Pausa"
        Me.mnuStop.Text = lang.getText("LABEL_STOP", True) '"Stop"
        Me.mnuFinal.Text = lang.getText("LABEL_END_TEMA", True) '"Final Tema"
        Me.EdicióToolStripMenuItem.Text = lang.getText("mnuEdit.Text", True) '"Edició"
        Me.mnuModif.Text = lang.getText("LABEL_MODIFICAR", True) '"Modificar"
        Me.mnuSave.Text = lang.getText("LABEL_SALVAR", True) '"Salvar"
        Me.mnuDel.Text = lang.getText("LABEL_DELETE", True) '"Borrar"
        Me.ToolStripMenuItem8.Text = lang.getText("mnu_Help", True) '"Ajuda"
        Me.mnu_Help.Text = lang.getText("mnuRefHelp.Text", True) '"Manual OnLine"
        Me.cmdSortir.Text = lang.getText("LABEL_EXIT", True) '"Sortir"
        Me.cmdStop.Text = lang.getText("LABEL_STOP", True) '"Stop"
        Me.cmdPlay.Text = lang.getText("LABEL_PLAY_PAUSA", True) '"Play/Pausa"		
        Me.cmdBloqueix.Text = lang.getText("LABEL_EDITAR", True) '"Editar"
        Me.cmdSalvar.Text = lang.getText("LABEL_SALVAR", True) '"Salvar"

        Me.Label4.Text = lang.getText("Label4.Text") '"Index DV: Dies a la llista / nº de vots"
        Me.Label1.Text = lang.getText("Label1.Text") '"Arrossega els temes per canviar l'ordre."
        Me.ColumnHeaderDataIn.Text = lang.getText("LABEL_DATA_IN_", True) '"Data In"
        Me.ColumnHeaderDataTop.Text = lang.getText("LABEL_DATA_TOP", True) '"Data TOP"
        Me.ColumnHeader8.Text = lang.getText("LABEL_DATA_IN", True) '"Data entrada"
        Me.ColumnHeaderNumIn.Text = lang.getText("ColumnHeader9.Text") '"Núm. In"
        Me.ColumnHeaderVots.Text = lang.getText("LABEL_VOTS", True) '"Vots"
        Me.ColumnHeaderSetmames.Text = lang.getText("ColumnHeader11.Text") '"Setmanes"
        Me.ColumnHeaderDV.Text = lang.getText("ColumnHeader12.Text") '"DV"			
        Me.Label3.Text = lang.getText("Label3.Text") '"Busca tots els HITs , TOPs i HITTOPs amb data d'entrada major o igual a l'especificada"
        Me.Label2.Text = lang.getText("LABEL_DATA_ENTRADA", True) '"Data d'entrada"		
        Me.cmdPrint.Text = lang.getText("LABEL_IMPRIMIR_LLISTAT", True) '"Imprimir llistat"
        Me.Text = lang.getText("LABEL_LLISTA_EXITS", True) '"LLista d'èxits"


    End Sub

    Private Sub getMetroListViewTops()
        MetroListViewTops.Items.Clear()
        Dim StrSql As String = "SELECT tops_id,tops_numllista,tops_numintro,tops_datain,tops_datatop," &
                                    "tema_titol,interp_nom,tema_votes," &
                                    " (datediff(NOW(),tops_datain )/7)as setmanes," &
                                    " (datediff(NOW(),tops_datain )/tema_votes)as idx_Dies_vots" &
                                    " FROM `llistaexits`, temes, interprets" &
                                    " WHERE(tops_id = tema_id And tema_interp = interp_id And tops_activa = 1)" &
                                    " ORDER BY tops_numllista,tops_datain DESC;"

        Dim db As New MSC.dbs(Cloud)
        Dim rs As DataTable = db.getTable(StrSql)
        For I As Integer = 0 To rs.Rows.Count - 1
            Dim NumLlista As Short = rs.Rows(I)("tops_numllista")
            Dim NumIntro As Short = rs.Rows(I)("tops_numintro")
            Dim IdTema As Short = rs.Rows(I)("tops_id")
            Dim DataIn As Date = rs.Rows(I)("tops_datain")
            Dim DataTop As Date = rs.Rows(I)("tops_datatop")
            Dim TitolTema As String = rs.Rows(I)("tema_titol")
            Dim Interp As String = rs.Rows(I)("interp_nom")
            Dim Vots As Integer = rs.Rows(I)("tema_votes")
            Dim Setmanes As Integer = rs.Rows(I)("setmanes")
            Dim DV As Integer = 0
            Try
                DV = rs.Rows(I)("idx_Dies_vots")
            Catch ex As Exception
                DV = 0
            End Try
            addLineLlistaExits(NumLlista, IdTema, DataIn, DataTop, NumIntro, False, TitolTema, Interp, Vots, Setmanes, DV)
        Next I
        db = Nothing
        Me.cmdDel.Enabled = IIf(Me.MetroListViewTops.Items.Count > 0, cmdSalvar.Enabled, False)
        Me.mnuDel.Enabled = Me.cmdDel.Enabled
        RecalculaPosicions()
    End Sub

    Private Sub addLineLlistaExits(ByRef NumLlista As Short, ByRef IdTema As Short, ByRef DataIn As Date, ByRef DataTop As Date,
                                    ByRef Numintro As Short, ByRef Nou As Boolean, ByVal TitolTema As String, ByVal Interp As String,
                                   ByVal Vots As Integer, ByVal Setmanes As Integer, ByVal DV As Integer)
        Dim NewItem As System.Windows.Forms.ListViewItem = Me.MetroListViewTops.Items.Add(TitolTema)
        NewItem.Tag = IdTema.ToString
        NewItem.ImageKey = "altres"

        Dim subItem As New ListViewItem.ListViewSubItem
        subItem.Text = Interp : subItem.Tag = IIf(Nou = True, "EsNou", "") : NewItem.SubItems.Add(subItem)
        subItem = New ListViewItem.ListViewSubItem : subItem.Text = Microsoft.VisualBasic.Format(NumLlista, "0#") : NewItem.SubItems.Add(subItem)
        subItem = New ListViewItem.ListViewSubItem : subItem.Text = Strings.Format(DataIn, "yyyy-MM-dd HH:mm:ss") : NewItem.SubItems.Add(subItem)
        subItem = New ListViewItem.ListViewSubItem : subItem.Text = "" : NewItem.SubItems.Add(subItem)
        subItem = New ListViewItem.ListViewSubItem : subItem.Text = IIf(Year(DataTop) = 1970, "", Strings.Format(DataTop, "yyyy-MM-dd HH:mm:ss")) : NewItem.SubItems.Add(subItem)
        subItem = New ListViewItem.ListViewSubItem : subItem.Text = Microsoft.VisualBasic.Format(Numintro, "0#") : NewItem.SubItems.Add(subItem)
        subItem = New ListViewItem.ListViewSubItem : subItem.Text = Microsoft.VisualBasic.Format(Vots, "0#") : NewItem.SubItems.Add(subItem)
        subItem = New ListViewItem.ListViewSubItem : subItem.Text = Setmanes : NewItem.SubItems.Add(subItem)
        subItem = New ListViewItem.ListViewSubItem : subItem.Text = DV : NewItem.SubItems.Add(subItem)


    End Sub

    Private Sub RecalculaPosicions()
        Dim i As Short = 0
        Do Until i > Me.MetroListViewTops.Items.Count - 1
            Me.MetroListViewTops.Items.Item(i).SubItems(2).Text = Microsoft.VisualBasic.Format(i + 1, "0#")
            If i = 0 Then Me.MetroListViewTops.Items.Item(i).ImageKey = "n1"
            i = i + 1
        Loop
    End Sub

    Private Sub addLineListMusicDisp(ByRef id As Short, ByRef TitolTema As String, ByRef Interp As String, ByRef DataIn As Date)
        Dim NewItem As System.Windows.Forms.ListViewItem = Me.lstMusicDisp.Items.Add(TitolTema)
        NewItem.Tag = CStr(id)
        NewItem.SubItems.Insert(1, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, Interp))
        NewItem.SubItems.Insert(2, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, Strings.Format(DataIn, "yyyy-MM-dd HH:mm:ss")))
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalvar.Click
        SaveRecord()
    End Sub

    Private Sub SaveRecord()
        If Not MyAPP.PermisPerContinuar() Then MsgBox(MSG_SERVER_CLOSE, vbOKOnly, MSG_ATENCIO) : Me.Close()

        If MsgBox(MSG_CONFIRM_SAVE_DADES, vbOKCancel, MSG_ATENCIO) = vbCancel Then Exit Sub

        Dim db As New MSC.dbs(Cloud)

        Dim sCmd As String
        For i As Short = 0 To Me.MetroListViewTops.Items.Count - 1
            db.IniTransaction()
            Dim IdTema As Short = MetroListViewTops.Items.Item(i).Tag
            'Dim NumIntro As Integer = MetroListViewTops.Items.Item(i).SubItems.Item(5).Text
            Dim DataTop As String = MetroListViewTops.Items.Item(i).SubItems.Item(4).Text
            'Dim DataIn As String = MetroListViewTops.Items.Item(i).SubItems.Item(3).Text
            If MetroListViewTops.Items.Item(i).SubItems.Item(1).Tag Like "EsNou" Then
                sCmd = "INSERT INTO llistaexits (tops_id, tops_numllista,tops_numintro, tops_datain"
                If i = 0 Then sCmd = sCmd & ", tops_datatop"
                sCmd = sCmd & ") VALUES "
                sCmd = sCmd & " ( " & IdTema
                sCmd = sCmd & " , " & i
                sCmd = sCmd & " , " & i
                sCmd = sCmd & " , '" & Now.ToString("yyyy-MM-dd HH:mm:ss") & "'"
                If i = 0 Then sCmd = sCmd & " , '" & Now.ToString("yyyy-MM-dd HH:mm:ss") & "'"
                sCmd = sCmd & ");"
                db.New_ID(sCmd)

                'S'ha de canviar la categoria a TOP al tema
                sCmd = "UPDATE temes "
                sCmd = sCmd & " SET"
                sCmd = sCmd & " tema_temps = " & CatTemp.TOP_
                sCmd = sCmd & " WHERE tema_id = " & IdTema & " ;"
                db.Update_ID(sCmd)
                MetroListViewTops.Items.Item(i).SubItems.Item(1).Tag = ""
            Else
                'actualitzar posició
                sCmd = "UPDATE llistaexits"
                sCmd = sCmd & " SET "
                sCmd = sCmd & " tops_numllista = " & i
                sCmd = sCmd & ", tops_activa = 1"
                If i = 0 Then sCmd = sCmd & ", tops_datatop = '" & DataTop & "'"
                sCmd = sCmd & " WHERE tops_id = " & IdTema & " ;"

                db.Update_ID(sCmd)
            End If
            db.EndTransaction()
        Next i

        db = Nothing
        Me.cmdSalvar.Enabled = False
    End Sub

    Private Sub MetroListViewTops_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles MetroListViewTops.DragDrop
        'If cmdAdd.Enabled = False Then Exit Sub
        'Realitzem desplaçaments dins la mateixa llista
        Dim liNew As System.Windows.Forms.ListViewItem
        Dim pinfo As ListViewHitTestInfo
        Dim pt As Point
        Dim pti As Point
        Dim hitItem As System.Windows.Forms.ListViewItem
        Dim i As Short
        Dim bNew As Boolean
        On Error Resume Next

        Dim position As New Point(e.X, e.Y)
        position = MetroListViewTops.PointToClient(position)

        hitItem = MetroListViewTops.HitTest(position).Item
        If hitItem Is Nothing Then
            liNew = MetroListViewTops.Items.Insert(MetroListViewTops.Items.Count, MetroListViewTops.Text)
        Else
            liNew = MetroListViewTops.Items.Insert(hitItem.Index, DragLV.Text)
        End If
        liNew.Tag = DragLV.Tag
        liNew.ImageKey = DragLV.ImageKey

        Do Until i = DragLV.SubItems.Count
            If liNew.SubItems.Count > i Then
                liNew.SubItems(i).Text = DragLV.SubItems(i).Text
            Else
                liNew.SubItems.Insert(i, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, DragLV.SubItems(i).Text))
            End If
            liNew.SubItems.Item(i).Tag = DragLV.SubItems.Item(i).Tag
            i = i + 1
        Loop
        If liNew.Index = 0 Then liNew.SubItems.Item(4).Text = Now.ToString("yyyy-MM-dd HH:mm:ss")
        MetroListViewTops.Items.RemoveAt(DragLV.Index)
        liNew.Selected = True
        DragLV = Nothing
        Me.cmdSalvar.Enabled = True
        mnuSave.Enabled = True
        RecalculaPosicions()
    End Sub

    Private Sub MetroListViewTops_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles MetroListViewTops.DragEnter
        If txtDataIn.Enabled Then e.Effect = DragDropEffects.Move
    End Sub

    Private Sub MetroListViewTops_ItemDrag(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles MetroListViewTops.ItemDrag
        If txtDataIn.Enabled Then DoDragDrop(e.Item, DragDropEffects.Move)
    End Sub

    Private Sub MetroListViewTops_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MetroListViewTops.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            DragLV = CType(sender, ListView).GetItemAt(e.X, e.Y)
        ElseIf e.Button = System.Windows.Forms.MouseButtons.Right Then
            Dim id As Short = MetroListViewTops.FocusedItem.Tag
            Dim strText As String = strInfoFitxer(Tipus_Play.CTL_MUSICA, id)
            InfoMsg = New frmTip
            InfoMsg.ShowMessage(strText, "Més info ...", IconStyles.Information, ContentAlignment.MiddleCenter, , , True, , , , , Themes.WinXpStyle, MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub MetroListViewTops_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstMusicDisp.MouseUp, MetroListViewTops.MouseUp
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            InfoMsg.Close()
        End If
    End Sub

    Private Sub lstMusicDisp_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstMusicDisp.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            Dim id As Short = lstMusicDisp.FocusedItem.Tag
            Dim strText As String = strInfoFitxer(Tipus_Play.CTL_MUSICA, id)
            InfoMsg = New frmTip
            InfoMsg.ShowMessage(strText, "Més info ...", IconStyles.Information, ContentAlignment.MiddleCenter, , , True, , , , , Themes.WinXpStyle, MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub cmdSortir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSortir.Click
        Me.Close()
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Dim frmPRT As New frmPrint
        'frmPRT.DefineLlistat(MetroListViewTops, frmPrint.Tipusllistats.LLISTAT_Temes, "Llista d'èxits")
        Try
            frmPRT.Show(Me)
        Catch ex As Exception
            frmPRT.WindowState = FormWindowState.Normal
        End Try
    End Sub

#Region "Player"
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
            'establir quin és el llistat que esta enfocat
            Dim IdTema As Short = 0
            Try
                If MetroListViewTops.Focused = True Then
                    IdTema = MetroListViewTops.SelectedItems(0).Tag
                Else
                    IdTema = Me.lstMusicDisp.SelectedItems(0).Tag
                End If
            Catch ex As Exception
                Exit Sub
            End Try

            Dim strPathFitxer As String = Params.PathMusica & IdTema & ".mp3"
            If Not IO.File.Exists(strPathFitxer) Then MsgBox("El fitxer " & strPathFitxer & " no existeix.", vbCritical, "Error")
            Bass.BASS_ChannelStop(StreamHandlePlay)
            StreamHandlePlay = Bass.BASS_StreamCreateFile(strPathFitxer, 0, 0, 0)
            If StreamHandlePlay = 0 Then
                'Can't play stream
                tmrPlayer.Enabled = False
                Exit Sub
            End If

            If Bass.BASS_ChannelPlay(StreamHandlePlay, False) = False Then
                'Can't play stream
                tmrPlayer.Enabled = False
                Exit Sub
            End If

        End If
        tmrPlayer.Enabled = True
    End Sub

    Private Sub stopFitxer()
        Bass.BASS_ChannelStop(StreamHandlePlay)
    End Sub

    Private Sub cmdPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPlay.Click
        ' Fer unPlay o un stop
        PlayFitxer()
    End Sub

    Private Sub cmdStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStop.Click
        stopFitxer()
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
                Me.mnuStop.Enabled = False
                tmrPlayer.Enabled = False
            Case BASSActive.BASS_ACTIVE_PAUSED
                cmdPlay.Image = Me.picPlay.Image
            Case BASSActive.BASS_ACTIVE_PLAYING
                Me.cmdStop.Enabled = True
                cmdPlay.Image = Me.picPause.Image
                Me.mnuStop.Enabled = True
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
        Dim LimePen As New Pen(Color.Lime, 8)
        Dim PeakPen As New Pen(Color.Red, 8)
        Dim PositionPen As New Pen(Color.Black, 1)
        Dim x As Integer
        graph.SmoothingMode = SmoothingMode.AntiAlias

        ' Pinta Volum dreta i esquerra
        x = (RVol / 32768) * picVuMeter.Width
        If x > picVuMeter.Width Then x = picVuMeter.Width
        graph.DrawLine(LimePen, picVuMeter.Width - x, 8, picVuMeter.Width, 8)

        x = (LVol / 32768) * picVuMeter.Width
        If x > picVuMeter.Width Then x = picVuMeter.Width
        graph.DrawLine(LimePen, picVuMeter.Width - x, 8 + 12, picVuMeter.Width, 8 + 12)

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
            graph.DrawLine(PeakPen, picVuMeter.Width - x, 8, picVuMeter.Width - x - 2, 8)
            graph.DrawLine(PeakPen, picVuMeter.Width - x, 8 + 12, picVuMeter.Width - x - 2, 8 + 12)
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

    Private Sub mnuPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPlay.Click, mnuStop.Click, mnuFinal.Click

        Select Case CType(sender, ToolStripMenuItem).Tag
            Case 1 : PlayFitxer()
            Case 2 : stopFitxer()
            Case 4
                Dim len As Long = Bass.BASS_ChannelGetLength(StreamHandlePlay)
                Dim LenInSeg As Single = Bass.BASS_ChannelBytes2Seconds(StreamHandlePlay, len)
                Bass.BASS_ChannelSetPosition(StreamHandlePlay, CSng(LenInSeg - 20))
        End Select
    End Sub

    Private Sub picVuMeter_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picVuMeter.MouseClick
        'estableix la posicio del ratolí a sobre el Pig
        Dim len As Long = Bass.BASS_ChannelGetLength(StreamHandlePlay)
        Dim bpp As Double = len / CType(Me.picVuMeter.Width, Double) ' bytes per pixel        
        'Quin és el pixel on es troba el ratolí
        Dim pr As Integer = 0
        Dim LocalMousePosition As Point = picVuMeter.PointToClient(System.Windows.Forms.Cursor.Position)
        'Posició on s'ha de desplaçar        
        Dim PosADespla As Single = Bass.BASS_ChannelBytes2Seconds(StreamHandlePlay, CLng(LocalMousePosition.X * bpp))
        'Desplaçar-ho
        Bass.BASS_ChannelSetPosition(StreamHandlePlay, PosADespla)
    End Sub

#End Region

    Private Sub cmdBloqueix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBloqueix.Click
        LockedRecord()
    End Sub

    Private Sub LockedRecord()
        If Me.cmdSalvar.Enabled = True Then
            If MsgBox(MSG_SAVE_DADES, vbOKCancel, MSG_ATENCIO) = MsgBoxResult.Ok Then SaveRecord()
        End If
        Static blEnable As Boolean
        blEnable = Not blEnable
        txtDataIn.Enabled = blEnable
        cmdDel.Enabled = blEnable
        Me.mnuDel.Enabled = blEnable
        If blEnable Then
            Me.cmdBloqueix.Image = Me.picUnLock.Image
        Else
            Me.cmdBloqueix.Image = Me.picLock.Image
            Me.cmdSalvar.Enabled = False
        End If
    End Sub

    Private Sub mnuModif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuModif.Click
        LockedRecord()
    End Sub

    Private Sub mnuSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSave.Click
        SaveRecord()
    End Sub

    Private Sub mnuDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDel.Click
        BorrarTrackllista()
    End Sub

    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub

    Private Sub txtDataIn_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDataIn.ValueChanged
        Me.lstMusicDisp.Items.Clear()
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.AppStarting
        ' Busca tots els HITs , TOPs i HITTOPs amb data d'entrada major o igual a l'especificada
        Dim StrSql As String = "SELECT tema_id, tema_titol, tema_interp,tema_datain FROM temes WHERE (tema_temps = " & CatTemp.HIT_ & " OR tema_temps = " & CatTemp.HITTOP_ & " OR tema_temps = " & CatTemp.TOP_ & ")AND tema_datain >=  '" & Me.txtDataIn.Value.ToString("yyyy/MM/dd") & "' ORDER BY tema_datain DESC"

        Dim db As New MSC.dbs(Cloud)
        Dim rs As DataTable = db.getTable(StrSql)
        For I As Integer = 0 To rs.Rows.Count - 1
            Dim ID As Short = rs.Rows(I)(0)
            Dim Titol As String = NoNul(rs.Rows(I)(1).ToString)
            Dim Interp As String = getNomInterpret(rs.Rows(I)(2))
            Dim DataIn As Date = rs.Rows(I)(3)
            addLineListMusicDisp(ID, Titol, Interp, DataIn)
        Next I
        db = Nothing
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        cmdAdd.Enabled = IIf(Usuari.UsrTipus > mdlMscDefines.NivellUsers.USR_CONVIDAT, IIf(Me.lstMusicDisp.Items.Count > 0, True, False), False)

    End Sub

    Private Sub MetroListViewTops_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MetroListViewTops.Resize
        Try
            Me.MetroListViewTops.Columns(0).Width = MetroListViewTops.Width / 4.5
            Me.MetroListViewTops.Columns(1).Width = MetroListViewTops.Width / 4.5
        Catch ex As Exception
        End Try
    End Sub

    Private Sub lstMusicDisp_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstMusicDisp.Resize
		Try
            lstMusicDisp.Columns(0).Width = lstMusicDisp.Width / 2.7
            lstMusicDisp.Columns(1).Width = lstMusicDisp.Width / 2.7
        Catch ex As Exception
		End Try
	End Sub
	
	Private Sub mnu_Help_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_Help.Click
		Dim Proces As Process = New Process
		Try
			Process.Start(MSC.Help.HELP_GEST_PRODUCCIO_EXITS.ToString)
		Catch ex As Exception
		End Try
	End Sub

    Sub FrmExitsResizeEnd(sender As Object, e As EventArgs) Handles MyBase.ResizeEnd
        Dim FitxerINI As New IniFile
        frm_sice(0) = Me.Width : frm_sice(1) = Me.Height
        FitxerINI.INIWrite(MyAPP.IniFile, "Data Gest", "size", frm_sice(0).ToString & "," & frm_sice(1).ToString)
    End Sub


End Class