Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic

Public Class frmRestoreAudio
	Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As Integer, ByVal hwndCallback As Integer) As Integer
	Public CDDrive As String
	Dim Cancelled As Boolean
	
	Private Sub CloseForm()
		'If Me.ToolbarEdit.Buttons.Item(4).Enabled Then
		'    If MsgBox("Vols salvar les modificacions?", vbOKCancel) = vbOK Then SaveRecord()
		'End If
		
		MyAPP.CloseSesionClient(MyAPP.IDSesion_Client,DESCRIP_FORM_MANT_AUDIO)
		Me.Dispose()
	End Sub
	
	Private Sub frmRestoreAudio_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		CloseForm()
	End Sub
	
	Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
		Me.Close()        
	End Sub
	
	Private Sub frmRestoreAudio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		setLanguageForm()
		' busca la lletra del CD
		'Dim allDrives = "", r = "", JustOneDrive As String = ""
		'Dim pos As Short
		'Dim DriveType As Integer
		'Dim CDfound As Short
		'allDrives = "                         " 'Space$(64)
		'r = CStr(GetLogicalDriveStrings(Len(allDrives), allDrives))
		'allDrives = VB.Left(allDrives, CInt(r))
		'Do
		'    pos = InStr(allDrives, Chr(0))
		'    If pos Then
		'        JustOneDrive = VB.Left(allDrives, pos)
		'        allDrives = Mid(allDrives, pos + 1, Len(allDrives))
		'        DriveType = GetDriveType(JustOneDrive)
		'        If DriveType = DRIVE_CDROM Then
		'            CDfound = True
		'            Exit Do
		'        End If
		'    End If
		'Loop Until allDrives = "" Or DriveType = DRIVE_CDROM
		'If CDfound Then
		'    CDDrive = UCase(JustOneDrive)
		'    CDDrive = VB.Left(CDDrive, 3)
		'Else
		'    '??????? deshabilitar botons
		'End If
		
		GroupBox3.Text = Params.NomAudio1
		GroupBox4.Text = Params.NomAudio2
		'TODO: ERROR I CREAR combo amb les unitats de disc dur
		'lbEpaiHD.Text = EspaiLliureEx("c:\")
		
		
	End Sub
	
	Dim MSG_SURE_DELETE_FILES As String 
	
	Public Sub setLanguageForm()
		lang.StrForm = Me.Name	
		
		MSG_SURE_DELETE_FILES = "Segur que vols iniciar el procediment de borrar fitxers?"
		
		Me.cmdAddMusic.Text = lang.getText("LABEL_ADD",True) '"Afegir"
		Me.cmdAddPubli.Text = lang.getText("LABEL_ADD",True) '"Afegir"
		Me.cmdAddPromo.Text = lang.getText("LABEL_ADD",True) '"Afegir"
		Me.cmdAddJingel.Text = lang.getText("LABEL_ADD",True) '"Afegir"		
		Me.cmdDelMusic.Text = lang.getText("LABEL_DELETE",True) '"Borrar"
		Me.cmdDelPubli.Text = lang.getText("LABEL_DELETE",True) '"Borrar"
		Me.cmdPromo.Text = lang.getText("LABEL_DELETE",True) '"Borrar"
		Me.cmdDelJingel.Text = lang.getText("LABEL_DELETE",True) '"Borrar"		
		Me.GroupBox1.Text = lang.getText("FITXER_MUSICA",True) '"Música"
		Me.GroupBox2.Text = lang.getText("FITXER_PUBLICITAT",True) '"Publicitat"
		'Me.GroupBox3.Text = "Promocions"		
		'Me.GroupBox4.Text = "Jingels"
		Me.cmdCancel.Text = lang.getText("CANCELAR",True) '"Cancelar"
		
		Me.Label1.Text = lang.getText("Label1.Text") '"Fer qualsevol operació en aquesta pantalla pot suposar un perill per l'emissió en directe."
		Me.GroupBox5.Text = lang.getText("GroupBox5.Text") '"Origen de les còpies dels fitxer a recuperar"
		Me.Label4.Text = lang.getText("Label4.Text") '"Directori origen"
		'Me.cmdPath.Text = "..."
		Me.Label5.Text = lang.getText("Label5.Text") '"Per estalviar espai al disc dur podem borrar tots els fitxers que no s'utilitzin actualment. Atenció abans de borrar-los s'ha d'estar segur que ja s'ha fet la seva còpia de seguretat."		
		Me.Text = lang.getText("Text") '"Manteniment de fitxers"
				
	End Sub
	
	
	Private Sub cmdDelMusic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelMusic.Click    
		Dim path As String
		Dim PathDesti As String
		Dim rs As DataTable        
		Dim Origen As String
		Dim num As Short
		Cancelled = False
		AmbTasquesPendents = True
		If MsgBox(MSG_SURE_DELETE_FILES, MsgBoxStyle.OkCancel, MSG_ATENCIO) = MsgBoxResult.Cancel Then Exit Sub
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.AppStarting
		
		path = Params.PathMusica
		Origen = "SELECT temes.tema_id, backups.bkp_nom"
		Origen = Origen & " FROM backups INNER JOIN temes ON backups.bkp_id = temes.tema_Backup"
		Origen = Origen & " Where (((temes.tema_pautain) = 0)) ;"
		Dim db As New MSC.dbs
		rs = db.getTable(Origen)
		'repassar tots del fitxer
		Me.ProgressBar1.Visible = True
		Me.cmdCancel.Visible = True
		ProgressBar1.Maximum = rs.Rows.Count
		Me.Refresh()
		For i As Integer = 0 To rs.Rows.Count - 1
			PathDesti = path & rs.Rows(i)(0).ToString & ".mp3"
			ProgressBar1.Value = i - 1
			lbInfoProgress.Text = "Comprovant fitxer: " & PathDesti & "."
			If IO.File.Exists(PathDesti) Then
				lbInfoProgress.Text = "Eliminant fitxer: " & PathDesti & "."
				System.Windows.Forms.Application.DoEvents()
				Try
					IO.File.Delete(PathDesti)
					num = num + 1
				Catch ex As IO.IOException
				End Try
			End If
			If Cancelled Then Exit For
		Next i
		Me.ProgressBar1.Visible = False
		Me.cmdCancel.Visible = False
		lbInfoProgress.Text = ""
		AmbTasquesPendents = False
		rs.Dispose()
		db = Nothing
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
		MsgBox( String.Format(MSG_ROWS_AFFECTED,num) , MsgBoxStyle.Information, My.Application.Info.AssemblyName)
		
	End Sub
	
	Private Sub cmdDelPubli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelPubli.Click
		Dim path As String
		Dim PathDesti As String
		Dim rs As DataTable
		Dim Origen As String
		Dim num As Short
		Cancelled = False
		AmbTasquesPendents = True
		If MsgBox(MSG_SURE_DELETE_FILES, MsgBoxStyle.OkCancel, MSG_ATENCIO) = MsgBoxResult.Cancel Then Exit Sub
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.AppStarting
		
		path = Params.PathPublicitat & "\"
		Origen = "SELECT falques.falc_id, backups.bkp_nom"
		Origen = Origen & " FROM falques INNER JOIN backups ON falques.falc_backup = backups.bkp_id"
		Origen = Origen & " Where (((falques.falc_activa) = 0)) ORDER BY backups.bkp_nom;"
		Dim db As New MSC.dbs
		rs = db.getTable(Origen)
		'repassar tots del fitxer
		Me.ProgressBar1.Visible = True
		Me.cmdCancel.Visible = True
		ProgressBar1.Maximum = rs.Rows.Count
		Me.Refresh()
		For i As Integer = 0 To rs.Rows.Count - 1
			PathDesti = path & rs.Rows(i)(0).ToString & ".mp3"
			ProgressBar1.Value = i - 1
			lbInfoProgress.Text = "Comprovant fitxer: " & PathDesti & "."
			If IO.File.Exists(PathDesti) Then
				lbInfoProgress.Text = "Eliminant fitxer: " & PathDesti & "."
				System.Windows.Forms.Application.DoEvents()
				Try
					IO.File.Delete(PathDesti)
					num = num + 1
				Catch ex As IO.IOException
				End Try
			End If
			If Cancelled Then Exit For
		Next i
		Me.ProgressBar1.Visible = False
		Me.cmdCancel.Visible = False
		lbInfoProgress.Text = ""
		AmbTasquesPendents = False
		rs.Dispose()
		db = Nothing
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
		MsgBox( String.Format(MSG_ROWS_AFFECTED,num) , MsgBoxStyle.Information, My.Application.Info.AssemblyName)
		
	End Sub
	
	Private Sub cmdPromo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPromo.Click
		Dim path As String
		Dim PathDesti As String = ""
		Dim rs As DataTable
		Dim Origen As String
		Dim num As Short
		Cancelled = False
		AmbTasquesPendents = True
		If MsgBox(MSG_SURE_DELETE_FILES, MsgBoxStyle.OkCancel, MSG_ATENCIO) = MsgBoxResult.Cancel Then Exit Sub
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.AppStarting
		
		path = Params.PathPromos & "\"
		Origen = "SELECT promos.promo_id, backups.bkp_nom, promos.promo_activ"
		Origen = Origen & " FROM backups INNER JOIN promos ON backups.bkp_id = promos.promo_backup"
		Origen = Origen & " Where (((promos.promo_activ) = 0)) ORDER BY backups.bkp_nom ;"
		Dim db As New MSC.dbs
		rs = db.getTable(Origen)
		'repassar tots del fitxer
		Me.ProgressBar1.Visible = True
		Me.cmdCancel.Visible = True
		ProgressBar1.Maximum = rs.Rows.Count
		Me.Refresh()
		For i As Integer = 0 To rs.Rows.Count - 1
			PathDesti = path & rs.Rows(i)(0).ToString & ".mp3"
			ProgressBar1.Value = i - 1
			lbInfoProgress.Text = "Comprovant fitxer: " & PathDesti & "."
			If IO.File.Exists(PathDesti) Then
				lbInfoProgress.Text = "Eliminant fitxer: " & PathDesti & "."
				System.Windows.Forms.Application.DoEvents()
				Try
					IO.File.Delete(PathDesti)
					num = num + 1
				Catch ex As IO.IOException
				End Try
			End If
			If Cancelled Then Exit For
		Next i
		Me.ProgressBar1.Visible = False
		Me.cmdCancel.Visible = False
		lbInfoProgress.Text = ""
		AmbTasquesPendents = False
		rs.Dispose()
		db = Nothing
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
		MsgBox( String.Format(MSG_ROWS_AFFECTED,num) , MsgBoxStyle.Information, My.Application.Info.AssemblyName)
		
	End Sub
	
	Private Sub cmdDelJingel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelJingel.Click
		Dim path As String
		Dim PathDesti As String
		Dim rs As DataTable
		Dim Origen As String
		Dim num As Short
		Cancelled = False
		AmbTasquesPendents = True
		If MsgBox(MSG_SURE_DELETE_FILES, MsgBoxStyle.OkCancel, MSG_ATENCIO) = MsgBoxResult.Cancel Then Exit Sub
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.AppStarting
		
		path = Params.PathJingels & "\"
		Origen = "SELECT jingels.jing_id, backups.bkp_nom"
		Origen = Origen & " FROM jingels INNER JOIN backups ON jingels.jing_backup = backups.bkp_id"
		Origen = Origen & " Where (((jingels.jing_activa) = 0)) ORDER BY backups.bkp_nom ;"
		Dim db As New MSC.dbs
		rs = db.getTable(Origen)
		'repassar tots del fitxer
		Me.ProgressBar1.Visible = True
		Me.cmdCancel.Visible = True
		ProgressBar1.Maximum = rs.Rows.Count
		Me.Refresh()
		For i As Integer = 0 To rs.Rows.Count - 1
			PathDesti = path & rs.Rows(i)(0).ToString & ".mp3"
			ProgressBar1.Value = i - 1
			lbInfoProgress.Text = "Comprovant fitxer: " & PathDesti & "."
			If IO.File.Exists(PathDesti) Then
				lbInfoProgress.Text = "Eliminant fitxer: " & PathDesti & "."
				System.Windows.Forms.Application.DoEvents()
				Try
					IO.File.Delete(PathDesti)
					num = num + 1
				Catch ex As IO.IOException
				End Try
			End If
			If Cancelled Then Exit For
		Next i
		Me.ProgressBar1.Visible = False
		Me.cmdCancel.Visible = False
		lbInfoProgress.Text = ""
		AmbTasquesPendents = False
		rs.Dispose()
		db = Nothing
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
		MsgBox( String.Format(MSG_ROWS_AFFECTED,num) , MsgBoxStyle.Information, My.Application.Info.AssemblyName)
		
	End Sub
	
	Private Sub cmdAddMusic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddMusic.Click        
		Dim returnstring As Object = Nothing
		Dim path, Backup As String
		Dim PathDesti, PathOrigen As String
		Dim rs As DataTable
		Dim Origen As String
		Dim ret As Object
		Dim num As Short
		Cancelled = False
		AmbTasquesPendents = True
		If MsgBox(MSG_SURE_DELETE_FILES, MsgBoxStyle.OkCancel, MSG_ATENCIO) = MsgBoxResult.Cancel Then Exit Sub
		
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.AppStarting
		Me.cmdExit.Enabled = False
		
		path = Params.PathMusica & "\"
		Origen = "SELECT temes.tema_id, backups.back_nom"
		Origen = Origen & " FROM backups INNER JOIN temes ON backups.bkp_id = temes.tema_backup"
		Origen = Origen & " Where (((temes.tema_pautain) = 1)) ;"
		Dim db As New MSC.dbs
		rs = db.getTable(Origen)
		
		'repassar tots els fitxers
		Me.ProgressBar1.Visible = True
		Me.cmdCancel.Visible = True
		ProgressBar1.Maximum = rs.Rows.Count
		Me.Refresh()
		
		For i As Integer = 0 To rs.Rows.Count - 1
			PathDesti = path & rs.Rows(i)(0).ToString & ".mp3"
			ProgressBar1.Value = i
			lbInfoProgress.Text = "Comprovant fitxer: " & PathDesti & "."
			If IO.File.Exists(PathDesti) Then
				lbInfoProgress.Text = "Carregant fitxer: " & PathDesti & "."
				PathOrigen = CDDrive & rs.Rows(i)(0).ToString & ".mp3"
				If Not IO.File.Exists(PathOrigen) Then
					Backup = rs.Rows(i)(1).ToString
					ret = mciSendString("set CDAudio door open", returnstring, 127, 0)
					If MsgBox("Introduïu el CD Backup amb l'etiqueta: " & Backup & ".", MsgBoxStyle.OkCancel, "Atenció") = MsgBoxResult.Cancel Then GoTo LineEnd
					ret = mciSendString("set CDAudio door closed", returnstring, 127, 0)
				End If
				System.Windows.Forms.Application.DoEvents()
				Try
					IO.File.Copy(PathOrigen, PathDesti)
					num = num + 1
				Catch ex As IO.IOException
				End Try
			End If
			If Cancelled Then Exit For
		Next i
		LineEnd:
		Me.ProgressBar1.Visible = False
		Me.cmdCancel.Visible = False
		lbInfoProgress.Text = ""
		AmbTasquesPendents = False
		Me.cmdExit.Enabled = True
		rs.Dispose()
		db = Nothing
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
		MsgBox( String.Format(MSG_ROWS_AFFECTED,num) , MsgBoxStyle.Information, My.Application.Info.AssemblyName)
		
	End Sub
	
	Private Sub cmdAddPubli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddPubli.Click
		Dim returnstring As Object = Nothing
		Dim path, Backup As String
		Dim PathDesti, PathOrigen As String
		Dim rs As DataTable
		Dim Origen As String
		Dim ret As Object
		Dim num As Short
		Cancelled = False
		AmbTasquesPendents = True
		If MsgBox(MSG_SURE_DELETE_FILES, MsgBoxStyle.OkCancel, MSG_ATENCIO) = MsgBoxResult.Cancel Then Exit Sub
		
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.AppStarting
		Me.cmdExit.Enabled = False
		path = Params.PathPublicitat & "\"
		Origen = "SELECT falques.falc_id, backups.back_nom"
		Origen = Origen & " FROM falques INNER JOIN backups ON falques.falc_backup = backups.bkp_id"
		Origen = Origen & " Where (((falques.falc_activa) = 1 )) ORDER BY backups.back_nom;"
		Dim db As New MSC.dbs
		rs = db.getTable(Origen)
		'repassar tots els fitxers
		Me.ProgressBar1.Visible = True
		Me.cmdCancel.Visible = True
		ProgressBar1.Maximum = rs.Rows.Count
		Me.Refresh()
		For i As Integer = 0 To rs.Rows.Count - 1
			PathDesti = path & rs.Rows(i)(0).ToString & ".mp3"
			ProgressBar1.Value = i
			lbInfoProgress.Text = "Comprovant fitxer: " & PathDesti & "."
			If IO.File.Exists(PathDesti) Then
				lbInfoProgress.Text = "Carregant fitxer: " & PathDesti & "."
				PathOrigen = CDDrive & rs.Rows(i)(0).ToString & ".mp3"
				If Not IO.File.Exists(PathOrigen) Then
					Backup = rs.Rows(i)(1).ToString
					ret = mciSendString("set CDAudio door open", returnstring, 127, 0)
					If MsgBox("Introduïu el CD Backup amb l'etiqueta: " & Backup & ".", MsgBoxStyle.OkCancel, "Atenció") = MsgBoxResult.Cancel Then GoTo LineEnd
					ret = mciSendString("set CDAudio door closed", returnstring, 127, 0)
				End If
				System.Windows.Forms.Application.DoEvents()
				Try
					IO.File.Copy(PathOrigen, PathDesti)
					num = num + 1
				Catch ex As IO.IOException
				End Try
			End If
			If Cancelled Then Exit For
		Next i
		LineEnd:
		Me.ProgressBar1.Visible = False
		Me.cmdCancel.Visible = False
		lbInfoProgress.Text = ""
		AmbTasquesPendents = False
		rs.Dispose()
		db = Nothing
		Me.cmdExit.Enabled = True
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
		MsgBox( String.Format(MSG_ROWS_AFFECTED,num) , MsgBoxStyle.Information, My.Application.Info.AssemblyName)
		
	End Sub
	
	Private Sub cmdAddPromo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddPromo.Click
		Dim returnstring As Object = Nothing
		Dim path, Backup As String
		Dim PathDesti, PathOrigen As String
		Dim rs As DataTable
		Dim Origen As String
		Dim ret As Object
		Dim num As Short
		Cancelled = False
		AmbTasquesPendents = True
		If MsgBox(MSG_SURE_DELETE_FILES, MsgBoxStyle.OkCancel, MSG_ATENCIO) = MsgBoxResult.Cancel Then Exit Sub
		
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.AppStarting
		Me.cmdExit.Enabled = False
		path = Params.PathPromos & "\"
		Origen = "SELECT promos.promo_id, backups.back_nom, promos.promo_activ"
		Origen = Origen & " FROM backups INNER JOIN promos ON backups.backID = promos.promo_backup"
		Origen = Origen & " Where (((promos.promo_activ) = 1)) ORDER BY backups.back_nom ;"
		Dim db As New MSC.dbs
		rs = db.getTable(Origen)
		'repassar tots els fitxers    
		Me.ProgressBar1.Visible = True
		Me.cmdCancel.Visible = True
		ProgressBar1.Maximum = rs.Rows.Count
		Me.Refresh()
		For i As Integer = 0 To rs.Rows.Count - 1
			PathDesti = path & rs.Rows(i)(0).ToString & ".mp3"
			ProgressBar1.Value = i
			lbInfoProgress.Text = "Comprovant fitxer: " & PathDesti & "."
			If IO.File.Exists(PathDesti) Then
				lbInfoProgress.Text = "Carregant fitxer: " & PathDesti & "."
				PathOrigen = CDDrive & rs.Rows(i)(0).ToString & ".mp3"
				If Not IO.File.Exists(PathOrigen) Then
					Backup = rs.Rows(i)(1).ToString
					ret = mciSendString("set CDAudio door open", returnstring, 127, 0)
					If MsgBox("Introduïu el CD Backup amb l'etiqueta: " & Backup & ".", MsgBoxStyle.OkCancel, "Atenció") = MsgBoxResult.Cancel Then GoTo LineEnd
					ret = mciSendString("set CDAudio door closed", returnstring, 127, 0)
				End If
				System.Windows.Forms.Application.DoEvents()
				Try
					IO.File.Copy(PathOrigen, PathDesti)
					num = num + 1
				Catch ex As IO.IOException
				End Try
			End If
			If Cancelled Then Exit For
		Next i
		LineEnd:
		Me.ProgressBar1.Visible = False
		Me.cmdCancel.Visible = False
		lbInfoProgress.Text = ""
		AmbTasquesPendents = False
		rs.Dispose()
		db = Nothing
		Me.cmdExit.Enabled = True
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
		MsgBox( String.Format(MSG_ROWS_AFFECTED,num) , MsgBoxStyle.Information, My.Application.Info.AssemblyName)
		
	End Sub
	
	Private Sub cmdAddJingel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddJingel.Click
		Dim returnstring As Object = Nothing
		Dim path, Backup As String
		Dim PathDesti, PathOrigen As String
		Dim rs As DataTable
		Dim Origen As String
		Dim ret As Object
		Dim num As Short
		Cancelled = False
		AmbTasquesPendents = True
		If MsgBox(MSG_SURE_DELETE_FILES, MsgBoxStyle.OkCancel, MSG_ATENCIO) = MsgBoxResult.Cancel Then Exit Sub
		
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.AppStarting
		Me.cmdExit.Enabled = False
		
		path = Params.PathJingels & "\"
		Origen = "SELECT jingels.jing_id, backups.back_nom"
		Origen = Origen & " FROM jingels INNER JOIN backups ON jingels.jing_backup = backups.back_id"
		Origen = Origen & " Where (((jingels.jing_activa) = 1)) ORDER BY backups.back_nom ;"
		Dim db As New MSC.dbs
		rs = db.getTable(Origen)
		
		'repassar tots els fitxers    
		Me.ProgressBar1.Visible = True
		Me.cmdCancel.Visible = True
		ProgressBar1.Maximum = rs.Rows.Count
		Me.Refresh()
		For i As Integer = 0 To rs.Rows.Count - 1
			PathDesti = path & rs.Rows(i)(0).ToString & ".mp3"
			ProgressBar1.Value = i
			lbInfoProgress.Text = "Comprovant fitxer: " & PathDesti & "."
			If IO.File.Exists(PathDesti) Then
				lbInfoProgress.Text = "Carregant fitxer: " & PathDesti & "."
				PathOrigen = CDDrive & rs.Rows(i)(0).ToString & ".mp3"
				If Not IO.File.Exists(PathOrigen) Then
					Backup = rs.Rows(i)(1).ToString
					ret = mciSendString("set CDAudio door open", returnstring, 127, 0)
					If MsgBox("Introduïu el CD Backup amb l'etiqueta: " & Backup & ".", MsgBoxStyle.OkCancel, "Atenció") = MsgBoxResult.Cancel Then GoTo LineEnd
					ret = mciSendString("set CDAudio door closed", returnstring, 127, 0)
				End If
				System.Windows.Forms.Application.DoEvents()
				Try
					IO.File.Copy(PathOrigen, PathDesti)
					num = num + 1
				Catch ex As IO.IOException
				End Try
			End If
			If Cancelled Then Exit For
		Next i
		LineEnd:
		Me.ProgressBar1.Visible = False
		Me.cmdCancel.Visible = False
		lbInfoProgress.Text = ""
		AmbTasquesPendents = False
		rs.Dispose()
		db = Nothing
		Me.cmdExit.Enabled = True
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
		MsgBox( String.Format(MSG_ROWS_AFFECTED,num) , MsgBoxStyle.Information, My.Application.Info.AssemblyName)
		
	End Sub
	
	Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
		Cancelled = True
	End Sub
	
	Private Sub cmdPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPath.Click
		FolderBrowserDialog1.Description = MSG_SELECT_DIR
		If FolderBrowserDialog1.ShowDialog() = system.Windows.Forms.DialogResult.OK Then
			Me.txtPath.Text = FolderBrowserDialog1.SelectedPath
		End If
		Me.cmdAddJingel.Enabled = IIf(Len(txtPath.Text) > 2, True, False)
		Me.cmdAddMusic.Enabled = Me.cmdAddJingel.Enabled
		Me.cmdAddPromo.Enabled = Me.cmdAddJingel.Enabled
		Me.cmdAddPubli.Enabled = Me.cmdAddJingel.Enabled
	End Sub
	
	Sub CmdAddMusicClick(sender As Object, e As EventArgs)
		
	End Sub
End Class