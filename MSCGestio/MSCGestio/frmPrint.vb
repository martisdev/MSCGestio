Option Strict Off
Option Explicit On

Imports System.Drawing.Printing
Imports System.Drawing.Drawing2D

Public Class frmPrint
	
	Dim strClient As String
	Dim strFalca As String
	Dim rsFalques As DataTable
	Dim prtDateIn As Date
	Dim prtDateOut As Date
	Dim Tiplist As Tipusllistats
	Dim strTitol As String
	
	Dim llistat As DataGridView
	Dim LineaTexto As Integer
	
	Public Enum Tipusllistats
		LLISTAT_Informe
		LLISTAT_Factura
		LLISTAT_Temes
		LLISTAT_Discos
	End Enum
	
	Public Sub defineReport(ByVal client As String, ByVal falca As String, ByVal dataIn As Date, ByVal dateOut As Date, ByVal rs As DataTable, ByVal intTipList As Tipusllistats)
		strClient = client
		strFalca = falca
		prtDateIn = dataIn
		prtDateOut = dateOut
		Tiplist = intTipList
		rsFalques = rs
	End Sub
	
	Public Sub DefineLlistat(ByVal list As DataGridView, ByVal intTipList As Tipusllistats, ByVal Titol As String)
		llistat = list
		Tiplist = intTipList
		strTitol = Titol
	End Sub

    Private Sub frmPrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		'todo: establir el lleguatge del client
		Dim Cliend_lang As String = lang.Code
		Dim General_lang As String = lang.Code 
		lang.Code = Cliend_lang
		setLanguageForm()
		
		
		Try
			Dim Impressora As String
			For Each Impressora In PrinterSettings.InstalledPrinters
				Me.comboPrinters.Items.Add(Impressora)
			Next
			Me.comboPrinters.SelectedIndex = comboPrinters.FindStringExact(PrintDocument1.PrinterSettings.PrinterName)
		Catch ex As Exception
		End Try
		'Restablir el lleguatge general
		lang.Code = General_lang
		
	End Sub
	
	Dim TXT_CLIENT As String 
	Dim TXT_NOM_FALCA As String
	Dim TXT_NUM_PAGINA As String 
	Dim TXT_DATA_HORA As String 
	Dim TXT_TOTAL_RADIACIONS As String 
	Dim TXT_IMPORT As String 
	Dim TXT_TOTAL_IMPORT As String 
	Dim MSG_HEADER As String 
	
	Public Sub setLanguageForm()
		lang.StrForm = Me.Name
		MSG_HEADER = lang.getText("MSG_HEADER") '"Informe de radiació entre les dates"
		TXT_CLIENT = lang.getText("HEADERTEXT_CLIENT",True) '"Client"
		TXT_NOM_FALCA = lang.getText("TXT_NOM_FALCA") '"Nom Falca"
		TXT_NUM_PAGINA = lang.getText("TXT_PAGINA") '"Pàgina nº"
		TXT_DATA_HORA = lang.getText("HEADERTEXT_DATA",True) '"Data"
		TXT_TOTAL_RADIACIONS = lang.getText("TXT_TOTAL_RADIACIONS") '"Total número de radiacions"
		TXT_IMPORT = lang.getText("LABEL_PREU",True) '"Import" ???
		TXT_TOTAL_IMPORT = lang.getText("TXT_TOTAL_IMPORT") '"Import Total"
		
		'Me.ToolStrip1.Text = "ToolStrip1"
		Me.ToolStripLabel1.Text = lang.getText("ToolStripLabel1.Text") & ":"'"Impressores:"
		Me.cmdConf.Text = lang.getText("cmdConf.Text") '"configurar pàgina"
        Me.cmdPrint.Text = lang.getText("cmdPrint.Text") '"Imprimir"
        'Me.cmdExit.Text = "ToolStripButton1"
        cmdExit.ToolTipText = lang.getText("LABEL_EXIT",True) 
		Me.Text = lang.getText("Text") '"Vista preliminar"			
		
	End Sub
	
	
	Private Sub cmdConf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConf.Click
		PageSetupDialog1.ShowDialog()
	End Sub
	
	Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
		'PrintPreviewDialog1.ShowDialog()
		Try
			PrintDocument1.Print()
		Catch ex As Exception
			Beep			
		End Try
		
	End Sub
	
	Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click, cmdSortir.Click
		Me.Close()
	End Sub
	
	Private Sub comboPrinters_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboPrinters.SelectedIndexChanged
		PrintDocument1.PrinterSettings.PrinterName = comboPrinters.Text
	End Sub
	
	Private Sub PrintDocument1_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PrintDocument1.BeginPrint
		LineaTexto = 0
	End Sub
	
	Dim nrow As Integer = 0
	Dim NPag As Short
	Private Sub InformRadiacio(ByVal PosY As Single, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
		'Inici de la taula, dibuixem la capçalera
		Dim TipoTitolTaula As Font = New Font("Arial", 8, FontStyle.Bold)
		Dim TipoCosTaula As Font = New Font("Arial", 8, FontStyle.Regular)
		Dim TipoTitulosDatos As Font = New Font("Arial", 12, FontStyle.Regular)
		Dim Tamano As SizeF
		
		
		Static PosYTitol As Single = PosY
		If PosYTitol > 0 Then
			PosY = PosYTitol
		End If
		
		' centrándolo en la parte superior de la página
		Dim TxtClent As String = TXT_CLIENT & " : " & strClient
		e.Graphics.DrawString(TxtClent, TipoTitulosDatos, Brushes.Black, e.PageBounds.Width / 4, PosY)
		Tamano = e.Graphics.MeasureString(TxtClent, TipoTitulosDatos)
		If Len(strFalca) > 0 Then
			PosY += Tamano.Height
			Dim TxtFalca As String = TXT_NOM_FALCA & " : " & strFalca
			e.Graphics.DrawString(TxtFalca, TipoTitulosDatos, Brushes.Black, e.PageBounds.Width / 4, PosY)
			Tamano = e.Graphics.MeasureString(TxtFalca, TipoTitulosDatos)
		End If
		PosY += Tamano.Height * 4
		
		
		Dim PosXCol1 As Single = e.PageBounds.Width / 7
		Dim PosXCol2 As Single = e.PageBounds.Width / 2.5
		Dim PosXCol3 As Single = e.PageBounds.Width - 250
		
		NPag = NPag + 1
		e.Graphics.DrawString(TXT_NUM_PAGINA & ": " & NPag, TipoCosTaula, Brushes.Black, PosXCol3, PosY)
		Tamano = e.Graphics.MeasureString(TXT_NUM_PAGINA & ": " & NPag, TipoCosTaula)
		PosY += Tamano.Height * 2
		
		e.Graphics.DrawString(TXT_NOM_FALCA, TipoTitulosDatos, Brushes.Black, PosXCol1, PosY)
		e.Graphics.DrawString(TXT_CLIENT, TipoTitulosDatos, Brushes.Black, PosXCol2, PosY)
		e.Graphics.DrawString(TXT_DATA_HORA, TipoTitulosDatos, Brushes.Black, PosXCol3, PosY)
		
		Tamano = e.Graphics.MeasureString(TXT_NOM_FALCA, TipoTitulosDatos)
		PosY += Tamano.Height * 2
		
		Do
			Dim NomFalca As String = rsFalques.Rows(nrow)(0).ToString
			Dim NomClient As String = rsFalques.Rows(nrow)(1).ToString
			Dim DataRadi As String = rsFalques.Rows(nrow)(2).ToString
			e.Graphics.DrawString(NomFalca, TipoCosTaula, Brushes.Black, PosXCol1, PosY)
			e.Graphics.DrawString(NomClient, TipoCosTaula, Brushes.Black, PosXCol2, PosY)
			e.Graphics.DrawString(DataRadi, TipoCosTaula, Brushes.Black, PosXCol3, PosY)
			
			PosY += Tamano.Height    
			nrow +=1
			'S'ha de comprovar si estem al final del document per canviar de pàgina
			LineaTexto = LineaTexto + 1
			If PosY + 5 > e.MarginBounds.Bottom Then
				'canvi pàgina
				PosY = PosYTitol
				e.HasMorePages = True
				Exit Sub
			End If			
		Loop Until nrow >= rsFalques.Rows.Count
		'For nrow To rsFalques.Rows.Count - 1
			
		'Next 
		
		PosY += Tamano.Height
		e.Graphics.DrawString( TXT_TOTAL_RADIACIONS & " : " & rsFalques.Rows.Count, TipoCosTaula, Brushes.Black, PosXCol3, PosY)
		e.HasMorePages = False
		LineaTexto = 0
		numericUpDown1.Maximum = NPag
		NPag = 0
		nrow = 0
	End Sub
	
	Private Sub FacturaRadiacio(ByVal PosY As Single, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
		'Inici de la taula, dibuixem la capçalera
		Dim TipoTitolTaula As Font = New Font("Arial", 8, FontStyle.Bold)
		Dim TipoCosTaula As Font = New Font("Arial", 8, FontStyle.Regular)
		Dim TipoTitulosDatos As Font = New Font("Arial", 12, FontStyle.Regular)
		Dim Tamano As SizeF
				
		Static PosYTitol As Single = PosY
		If PosYTitol > 0 Then
			PosY = PosYTitol
		End If
		
		' centrándolo en la parte superior de la página
		Dim TxtClent As String = TXT_CLIENT & " : " & strClient
		e.Graphics.DrawString(TxtClent, TipoTitulosDatos, Brushes.Black, e.PageBounds.Width / 4, PosY)
		Tamano = e.Graphics.MeasureString(TxtClent, TipoTitulosDatos)
		If Len(strFalca) > 0 Then
			PosY += Tamano.Height
			Dim TxtFalca As String = TXT_NOM_FALCA & " : " & strFalca
			e.Graphics.DrawString(TxtFalca, TipoTitulosDatos, Brushes.Black, e.PageBounds.Width / 4, PosY)
			Tamano = e.Graphics.MeasureString(TxtFalca, TipoTitulosDatos)
		End If
		
		PosY += Tamano.Height * 4
		
		
		Dim PosXCol1 As Single = e.PageBounds.Width / 7
		Dim PosXCol2 As Single = e.PageBounds.Width / 3
		Dim PosXCol3 As Single = e.PageBounds.Width - 270
		Dim PosXCol4 As Single = e.PageBounds.Width - 150
		NPag = NPag + 1
		e.Graphics.DrawString(TXT_NUM_PAGINA & ": " & NPag, TipoCosTaula, Brushes.Black, PosXCol4, PosY)
		Tamano = e.Graphics.MeasureString(TXT_NUM_PAGINA & ": " & NPag, TipoCosTaula)
		PosY += Tamano.Height * 2
		
		e.Graphics.DrawString(TXT_NOM_FALCA , TipoTitulosDatos, Brushes.Black, PosXCol1, PosY)
		e.Graphics.DrawString(TXT_CLIENT, TipoTitulosDatos, Brushes.Black, PosXCol2, PosY)
		e.Graphics.DrawString(TXT_DATA_HORA, TipoTitulosDatos, Brushes.Black, PosXCol3, PosY)
		e.Graphics.DrawString(TXT_IMPORT, TipoTitulosDatos, Brushes.Black, PosXCol4, PosY)
		
		Tamano = e.Graphics.MeasureString(TXT_NOM_FALCA, TipoTitulosDatos)
		PosY += Tamano.Height * 2
		
		Static ImportTotal As Single		
		Do
			Dim NomFalca As String = rsFalques.Rows(nrow)(0).ToString
			Dim NomClient As String = rsFalques.Rows(nrow)(1).ToString
			Dim DataRadi As String = rsFalques.Rows(nrow)(2).ToString
			Dim Tarifa As Single = rsFalques.Rows(nrow)(3)
			'Dim IdFalca As Short = rsFalques.Rows(nrow)(4)
			
			Dim Import As Single = getImport(DataRadi, Tarifa)
			ImportTotal = ImportTotal + Import
			
			e.Graphics.DrawString(NomFalca, TipoCosTaula, Brushes.Black, PosXCol1, PosY)
			e.Graphics.DrawString(NomClient, TipoCosTaula, Brushes.Black, PosXCol2, PosY)
			e.Graphics.DrawString(DataRadi, TipoCosTaula, Brushes.Black, PosXCol3, PosY)
			e.Graphics.DrawString(Import, TipoCosTaula, Brushes.Black, PosXCol4, PosY)
			Tamano = e.Graphics.MeasureString(NomFalca, TipoCosTaula)
			
			PosY += Tamano.Height	
			nrow +=1
			'S'ha de comprovar si estem al final del document per canviar de pàgina
			LineaTexto = LineaTexto + 1
			If PosY + 5 > e.MarginBounds.Bottom Then
				'canvi pàgina
				PosY = PosYTitol
				e.HasMorePages = True
				Exit Sub
			End If	
		Loop Until nrow >= rsFalques.Rows.Count

		PosY += Tamano.Height
        e.Graphics.DrawString(TXT_TOTAL_RADIACIONS & " : ", TipoCosTaula, Brushes.Black, PosXCol3 - 20, PosY)
        e.Graphics.DrawString(rsFalques.Rows.Count, TipoCosTaula, Brushes.Black, PosXCol4, PosY)
        PosY += Tamano.Height
        e.Graphics.DrawString(TXT_TOTAL_IMPORT & " : ", TipoTitolTaula, Brushes.Black, PosXCol3 - 20, PosY)
        e.Graphics.DrawString(ImportTotal, TipoTitolTaula, Brushes.Black, PosXCol4, PosY)
        e.HasMorePages = False
		LineaTexto = 0
		numericUpDown1.Maximum = NPag
		NPag = 0
		nrow = 0
		ImportTotal = 0
	End Sub
	
	Private Sub reportList(ByVal PosY As Single, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
		Dim TipoTitulosDatos As Font = New Font("Arial", 12, FontStyle.Regular)
		Dim TipoCosTaula As Font = New Font("Arial", 8, FontStyle.Regular)
		Dim Tamano As SizeF	
		
		Static PosYTitol As Single = PosY
		If PosYTitol > 0 Then
			PosY = PosYTitol
		End If
		
		Dim NColsVisibles As Short = 0
		For i As Integer = 0 To llistat.Columns.Count - 1
			If llistat.Columns(i).Visible = True Then
				NColsVisibles = NColsVisibles + 1
			End If
		Next
		
		Dim NCols As Short = llistat.Columns.Count - 1
		Dim proporcio As Double = e.PageBounds.Width / llistat.Width
		Dim PosXCol(NCols) As Single
		'TODO: S'ha de millorar molt la distribució de les columnes
		Dim PoxPos As Single = 0
		For i As Short = 0 To NCols
			If llistat.Columns(i).Visible = True Then
				PosXCol(i) = PoxPos + 10 '((e.PageBounds.Width / NColsVisibles - 800) * i) + 10
				PoxPos = PoxPos + ((llistat.Columns(i).Width - 10) * proporcio)
			Else
				Try
					PosXCol(i) = PosXCol(i - 1)
				Catch ex As Exception
				End Try
			End If
			
		Next i
		
		NPag += 1
		e.Graphics.DrawString(TXT_NUM_PAGINA & ": " & NPag, TipoCosTaula, Brushes.Black, PosXCol(NCols), PosY)
		Tamano = e.Graphics.MeasureString(TXT_NUM_PAGINA & ": " & NPag, TipoCosTaula)
		PosY += Tamano.Height * 2
		
		For N As Short = 0 To NCols
			If llistat.Columns(N).Visible = True Then
				e.Graphics.DrawString(llistat.Columns(N).HeaderText, TipoTitulosDatos, Brushes.Black, PosXCol(N), PosY)
			End If
		Next N
		
		Tamano = e.Graphics.MeasureString(llistat.Columns(0).HeaderText, TipoTitulosDatos)
		PosY += Tamano.Height * 2
		
		Dim ItemsNoms(NCols) As String
		Dim IdVisible As Short = 0
		Do Until LineaTexto >= llistat.Rows.Count - 1
			For f As Short = 0 To NCols
				If llistat.Columns(f).Visible = True Then
					IdVisible = f
					If llistat.Rows(LineaTexto).Cells(f).GetType.Name.ToString = "DataGridViewTextBoxCell" Then
						ItemsNoms(f) = llistat.Rows(LineaTexto).Cells(f).Value.ToString
					ElseIf llistat.Rows(LineaTexto).Cells(f).GetType.Name.ToString = "DataGridViewComboBoxCell" Then
						ItemsNoms(f) = llistat.Rows(LineaTexto).Cells(f).FormattedValue.ToString
					ElseIf llistat.Rows(LineaTexto).Cells(f).GetType.Name.ToString = "DataGridViewCheckBoxCell" Then
						ItemsNoms(f) = IIf(llistat.Rows(LineaTexto).Cells(f).Value.ToString = "1", "Sí", "No")
					End If
					e.Graphics.DrawString(ItemsNoms(f), TipoCosTaula, Brushes.Black, PosXCol(f), PosY)
				End If
				'DataGridViewComboBoxCell, 
			Next f
			Tamano = e.Graphics.MeasureString(ItemsNoms(IdVisible), TipoCosTaula)
			PosY += Tamano.Height
			'S'ha de comprovar si estem al final del document per canviar de pàgina
			LineaTexto = LineaTexto + 1
			If PosY + 5 > e.MarginBounds.Bottom Then
				'canvi pàgina
				PosY = PosYTitol
				e.HasMorePages = True
				Exit Sub
			End If
		Loop
		NCols = Nothing
		ItemsNoms = Nothing
		PosXCol = Nothing
		LineaTexto = 0
		numericUpDown1.Maximum = NPag
		NPag = 0
	End Sub
	
	Private Function getTitolReport() As String
		If Tiplist = Tipusllistats.LLISTAT_Informe Then
			Return MSG_HEADER & " " & prtDateIn.ToString("dd-MM-yyyy") & " i " & prtDateOut.ToString("dd-MM-yyyy")
		ElseIf Tiplist = Tipusllistats.LLISTAT_Factura Then
			Return MSG_HEADER & " " & prtDateIn.ToString("dd-MM-yyyy") & " i " & prtDateOut.ToString("dd-MM-yyyy")
		ElseIf Tiplist = Tipusllistats.LLISTAT_Temes Or Tiplist = Tipusllistats.LLISTAT_Discos Then
			Return strTitol
		Else
			Return ""
		End If
	End Function

    Sub PrintDocument1PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        '' Tipos de letra a usar para los distintos elementos que van a imprimirse		
        Dim TipoTitulo As Font = New Font("Arial", 12, FontStyle.Bold)
        Dim TipoDatos As Font = New Font("Arial", 10, FontStyle.Italic)
        Dim Tamano As SizeF
        '' Brocha y lápiz para los dibujos
        Dim PosY As Single = 10
        Dim PosX As Single = 5

        If Not IsNothing(Params.LogoEmpresa) = True Then
            Dim tmpImage As Image = Params.LogoEmpresa
            Dim scale As Single = 80 / tmpImage.Height

            Dim picCia As Image = scaleImage(tmpImage, scale) 'resizeImageFromImage(tmpImage,80,80)
            e.Graphics.DrawImage(picCia, PosX, PosY)
        End If

        e.Graphics.DrawString(Now.ToString("f"), TipoDatos, Brushes.Black, e.PageBounds.Width - 300, PosY)
        Tamano = e.Graphics.MeasureString(Now.ToString("f"), TipoDatos)
        PosY += Tamano.Height
        Dim NomCia As String = Params.NomRadio()
        e.Graphics.DrawString(NomCia, TipoDatos, Brushes.Black, e.PageBounds.Width - 300, PosY)

        If LineaTexto > 0 Then GoTo LineNextPage
        ' tomamos la posición de la primera línea
        PosY = e.MarginBounds.Y
        ' y dibujamos el título del informe
        Dim Titol As String = getTitolReport()
        Tamano = e.Graphics.MeasureString(Titol, TipoTitulo)
        ' centrándolo en la parte superior de la página
        e.Graphics.DrawString(Titol, TipoTitulo, Brushes.Black, (e.PageBounds.Width - Tamano.Width) / 2, PosY)

        ' Actualizamos la posición vertical
        PosY += Tamano.Height * 2
LineNextPage:
        If Tiplist = Tipusllistats.LLISTAT_Informe Then
            InformRadiacio(PosY, e)
        ElseIf Tiplist = Tipusllistats.LLISTAT_Factura Then
            FacturaRadiacio(PosY, e)
        ElseIf Tiplist = Tipusllistats.LLISTAT_Discos Or Tiplist = Tipusllistats.LLISTAT_Temes Then
            reportList(PosY, e)
        End If
    End Sub


    Sub NumericUpDown1Click(sender As Object, e As EventArgs) Handles numericUpDown1.Click
        Try
            PrintPreviewControl1.StartPage = numericUpDown1.Text - 1
        Catch ex As Exception

        End Try
    End Sub
End Class