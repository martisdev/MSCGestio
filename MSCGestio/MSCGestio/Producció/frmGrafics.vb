Option Strict Off
Option Explicit On

Imports System.Drawing.Drawing2D

Public Class frmGrafics
	Dim isTemp As Boolean
	
	Private Sub CloseForm()
		MyAPP.CloseSesionClient(MyAPP.IDSesion_Client, DESCRIP_FORM_GRAFICS)
		Me.Dispose()
	End Sub
	
	Private Sub frmGrafics_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		CloseForm()
	End Sub
	
	Private Sub cmdRadiaIdioma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRadiaIdioma.Click
		Dim StrTitol As String = String.Format(MSG_GRAFIC_RADIATS_ENTRE_DATES,Me.txtIntervalDate.SelectionStart, Me.txtIntervalDate.SelectionEnd)
		Dim StrSql As String = "SELECT idiomes.nom_nadiu, COUNT(*) AS ColSum"
		StrSql = StrSql + " FROM idiomes INNER JOIN (temes INNER JOIN controlradiacio ON temes.tema_id = controlradiacio.ctl_fitxer)ON idiomes.id_lang = temes.tema_idioma"
		StrSql = StrSql + " WHERE (((controlradiacio.ctl_tipfitxer)=2)) AND controlradiacio.ctl_dataradiacio between '" & Strings.Format(Me.txtIntervalDate.SelectionStart, "yyyy/MM/dd") & "' AND '" & Strings.Format(Me.txtIntervalDate.SelectionEnd, "yyyy/MM/dd") & "'"
		StrSql = StrSql + " GROUP BY idiomes.nom_nadiu ORDER BY ColSum DESC;"
		PintarGrafica(StrSql, StrTitol)
	End Sub
	
	Private Sub cmdRadiaEstil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRadiaEstil.Click
		Dim StrTitol As String = String.Format(MSG_GRAFIC_RADIATS_ENTRE_DATES,Me.txtIntervalDate.SelectionStart, Me.txtIntervalDate.SelectionEnd)
		Dim StrSql As String = "SELECT " & _
								  "estils.estil_nom , COUNT(*) AS ColSum " & _
								"FROM style_relationships " & _
								  " INNER JOIN estils " & _
								   " ON style_relationships.style_relationships_style = estils.estil_id " & _
								  "INNER JOIN controlradiacio " & _
								   " ON controlradiacio.ctl_fitxer = style_relationships.style_relationships_fitxer " & _
								"where " & _
								"(((controlradiacio.ctl_tipfitxer)=2)) " & _
								 "   AND controlradiacio.ctl_dataradiacio between '" & Strings.Format(Me.txtIntervalDate.SelectionStart, "yyyy/MM/dd") & "' AND '" & Strings.Format(Me.txtIntervalDate.SelectionEnd, "yyyy/MM/dd") & "'" & _    
								"GROUP BY estils.estil_nom " & _
								"ORDER BY ColSum DESC;"
										
'		Dim StrSql As String = "SELECT estils.estil_nom, COUNT(*) AS ColSum"
'		StrSql = StrSql + " FROM estils INNER JOIN (temes INNER JOIN controlradiacio ON temes.tema_id = controlradiacio.ctl_fitxer)ON estils.estil_id = temes.tema_estil"
'		StrSql = StrSql + " WHERE (((controlradiacio.ctl_tipfitxer)=2)) AND controlradiacio.ctl_dataradiacio between '" & Strings.Format(Me.txtIntervalDate.SelectionStart, "yyyy/MM/dd") & "' AND '" & Strings.Format(Me.txtIntervalDate.SelectionEnd, "yyyy/MM/dd") & "'"
'		StrSql = StrSql + " GROUP BY estils.estil_nom ORDER BY ColSum DESC;"
		PintarGrafica(StrSql, StrTitol)
	End Sub
	
	Private Sub cmdRadiaInterp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRadiaInterp.Click
		Dim StrTitol As String = String.Format(MSG_GRAFIC_RADIATS_ENTRE_DATES,Me.txtIntervalDate.SelectionStart, Me.txtIntervalDate.SelectionEnd)
		Dim StrSql As String = "SELECT interprets.interp_nom, COUNT(*) AS ColSum"
		StrSql = StrSql + " FROM interprets INNER JOIN (temes INNER JOIN controlradiacio ON temes.tema_id = controlradiacio.ctl_fitxer)ON interprets.interp_id = temes.tema_Interp"
		StrSql = StrSql + " WHERE (((controlradiacio.ctl_tipfitxer)=2)) AND controlradiacio.ctl_dataradiacio between '" & Strings.Format(Me.txtIntervalDate.SelectionStart, "yyyy/MM/dd") & "' AND '" & Strings.Format(Me.txtIntervalDate.SelectionEnd, "yyyy/MM/dd") & "'"
		StrSql = StrSql + " GROUP BY interprets.interp_nom ORDER BY ColSum DESC;"
		PintarGrafica(StrSql, StrTitol)
	End Sub
	
	Private Sub cmdDBSInterp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDBSInterp.Click
		Dim StrTitol As String = MSG_GRAFIC_INTERPRET
		If Me.chkPautaIn.Checked = True Then StrTitol = StrTitol + MSG_GRAFIC_ONLY_IN
		
		Dim StrSql As String = "SELECT interprets.interp_nom, COUNT(*) AS ColSum FROM interprets"
		StrSql = StrSql + " INNER JOIN temes  ON interprets.interp_id = temes.tema_Interp"
		If Me.chkPautaIn.Checked = True Then StrSql = StrSql + " WHERE temes.tema_pautain = 1"
		StrSql = StrSql + " GROUP BY interprets.interp_nom ORDER BY ColSum DESC;"
		PintarGrafica(StrSql, StrTitol)
	End Sub
	
	Private Sub cmdDBSIdioma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDBSIdioma.Click
		Dim StrTitol As String = MSG_GRAFIC_IDIOMA
		If Me.chkPautaIn.Checked = True Then StrTitol = StrTitol + MSG_GRAFIC_ONLY_IN
		
		Dim StrSql As String = "SELECT idiomes.nom_nadiu, COUNT(*) AS ColSum FROM idiomes"
		StrSql = StrSql + " INNER JOIN temes  ON idiomes.id_lang = temes.tema_idioma"
		If Me.chkPautaIn.Checked = True Then StrSql = StrSql + " WHERE temes.tema_pautain = 1"
		StrSql = StrSql + " GROUP BY idiomes.nom_nadiu ORDER BY ColSum DESC;"
		PintarGrafica(StrSql, StrTitol)
	End Sub
	
	Private Sub cmdDBSSubj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDBSSubj.Click
		Dim StrTitol As String = MSG_GRAFIC_CLAS_SUBJ
		If Me.chkPautaIn.Checked = True Then StrTitol = StrTitol + MSG_GRAFIC_ONLY_IN
		
		Dim StrSql As String = "SELECT subjectiv.subj_nom, COUNT(*) AS ColSum FROM subjectiv"
		StrSql = StrSql + " INNER JOIN temes  ON subjectiv.subj_id = temes.tema_subj"
		If Me.chkPautaIn.Checked = True Then StrSql = StrSql + " WHERE temes.tema_pautain = 1"
		StrSql = StrSql + " GROUP BY subjectiv.subj_nom ORDER BY ColSum DESC;"
		PintarGrafica(StrSql, StrTitol)
	End Sub
	
	Private Sub cmdDBSTemp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDBSTemp.Click
		Dim StrTitol As String = MSG_GRAFIC_CLAS_TEMP
		If Me.chkPautaIn.Checked = True Then StrTitol = StrTitol + MSG_GRAFIC_ONLY_IN
		
		Dim StrSql As String = "SELECT temes.tema_temps, COUNT(*) AS ColSum FROM temes"
		If Me.chkPautaIn.Checked = True Then StrSql = StrSql + " WHERE temes.tema_pautain = 1"
		StrSql = StrSql + " GROUP BY temes.tema_temps ORDER BY ColSum DESC"
		isTemp = True
		PintarGrafica(StrSql, StrTitol)
	End Sub
	
	Private Sub cmdDBSRitme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDBSRitme.Click
		Dim StrTitol As String = MSG_GRAFIC_RITME
		If Me.chkPautaIn.Checked = True Then StrTitol = StrTitol + MSG_GRAFIC_ONLY_IN
		
		Dim StrSql As String = "SELECT temes.tema_ritme, COUNT(*) AS ColSum FROM temes"
		If Me.chkPautaIn.Checked = True Then StrSql = StrSql + " WHERE temes.tema_pautain = 1"
		StrSql = StrSql + " GROUP BY temes.tema_ritme ORDER BY ColSum DESC;"
		PintarGrafica(StrSql, StrTitol)
	End Sub
	
	Private Sub cmdDBSAny_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDBSAny.Click
		Dim StrTitol As String = MSG_GRAFIC_ANY
		If Me.chkPautaIn.Checked = True Then StrTitol = StrTitol + MSG_GRAFIC_ONLY_IN
		'TODO: s'ha de millorar la sentència per fer intervals d'anys
		Dim StrSql As String = "SELECT temes.tema_any, COUNT(*) AS ColSum FROM temes"
		If Me.chkPautaIn.Checked = True Then StrSql = StrSql + " WHERE temes.tema_pautain = 1"
		StrSql = StrSql + " GROUP BY temes.tema_any ORDER BY ColSum DESC;"
		PintarGrafica(StrSql, StrTitol)
	End Sub
	
	Private Sub cmdDBSEstil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDBSEstil.Click
		Dim StrTitol As String = MSG_GRAFIC_CLAS_ESTIL
		If Me.chkPautaIn.Checked = True Then StrTitol = StrTitol + MSG_GRAFIC_ONLY_IN
		
		Dim StrSql As String = "SELECT " & _
 								"estils.estil_nom, COUNT(*) AS ColSum " & _
								"FROM temes " & _
 								" INNER JOIN style_relationships " & _
  								"  ON temes.tema_id = style_relationships.style_relationships_fitxer " & _
  								"INNER JOIN estils " & _
   								" ON style_relationships.style_relationships_style = estils.estil_id " & _
								"GROUP BY estils.estil_nom ORDER BY ColSum DESC" 
		
'		Dim StrSql As String = "SELECT estils.estil_nom, COUNT(*) AS ColSum FROM estils"
'		StrSql = StrSql + " INNER JOIN temes  ON estils.estil_id = temes.tema_estil"
'		StrSql = StrSql + " GROUP BY estils.estil_nom ORDER BY ColSum DESC;"
		PintarGrafica(StrSql, StrTitol)
	End Sub
	
	Private Sub PintarGrafica(ByVal StrSql As String, ByVal strTitol As String)
		Dim bit As Bitmap = New Bitmap(picGraf.Width, picGraf.Height)
		Dim graph As Graphics = Graphics.FromImage(bit)
		Dim TipoTitulo As Font = New Font("Arial", 10, FontStyle.Bold)
		Dim PosY As Single
		Dim rs As DataTable
        Dim db As New MSC.dbs(Cloud)
        rs = db.getTable(StrSql)
		
		
		If rs.Rows.Count = 0 Then
			graph.DrawString(MSG_NO_RESULT, TipoTitulo, Brushes.Black, 20, PosY)
			picGraf.Image = bit
			Exit Sub
		End If        
		
		Dim Tamano As SizeF = graph.MeasureString(strTitol, TipoTitulo)
		graph.DrawString(strTitol, TipoTitulo, Brushes.Black, 20, PosY)
		
		' Actualizamos la posición vertical
		PosY += Tamano.Height * 2
		
		' Alto de una línea de texto normal
		Dim TipoTexto As Font = New Font("Courier New", 10, FontStyle.Italic)
		Dim AltoLinea As Single = TipoTexto.GetHeight(graph)
		
		PosY += AltoLinea * 2
		' y actualizamos la posición vertical
		Dim SumTotal As Integer
		For a As Integer = 0 To rs.Rows.Count - 1
			SumTotal = SumTotal + rs.Rows(a)(1)
		Next a
		
		Dim ColorPen As Pen = Pens.AliceBlue
		Dim strPrg As String
		
		For b As Integer = 0 To rs.Rows.Count - 1
			Dim PosX As Single = Me.picGraf.Left - 200
			Dim Valor As Single = (rs.Rows(b)(1) / SumTotal)
			If Valor < 0.01 Then
				Dim ValRest As Single
				Do Until b = (rs.Rows.Count - 1)
					ValRest = ValRest + rs.Rows(b)(1)
					b = b + 1
				Loop
				strPrg = NAME_ALTRES & " - " & Strings.Format(ValRest / SumTotal, "0.00%")
			Else
				Dim Nom As String
				If isTemp = True Then
					Nom = Choose(rs.Rows(b)(0), "HIT", "OLD", "OLDTOP", "TOP", "HITTOP")
				Else
					Nom = Trim$(rs.Rows(b)(0))
				End If
				strPrg = Nom & " - " & Strings.Format(rs.Rows(b)(1) / SumTotal, "0.00%")
			End If
			graph.DrawString(strPrg, TipoTexto, Brushes.Black, PosX, PosY + AltoLinea)
			PosX += graph.MeasureString(strPrg, TipoTexto).Width + 10
			
			Select Case Valor
				Case Is > 0.8 : ColorPen = New Pen(Color.Red, 15)
				Case Is > 0.65 : ColorPen = New Pen(Color.Tomato, 15)
				Case Is > 0.5 : ColorPen = New Pen(Color.LightCoral, 15)
				Case Is > 0.3 : ColorPen = New Pen(Color.Salmon, 15)
				Case Is > 0.15 : ColorPen = New Pen(Color.Gold, 15)
				Case Is > 0.05 : ColorPen = New Pen(Color.Yellow, 15)
				Case Else : ColorPen = New Pen(Color.Lime, 15)
			End Select
			
			graph.DrawLine(ColorPen, bit.Width - 300, PosY + AltoLinea + 10, bit.Width - 300 + (Valor * bit.Width), PosY + AltoLinea + 10)
			PosY = PosY + 20
			
		Next b
		rs.Dispose()
		db = Nothing
		isTemp = False
		picGraf.Image = bit
		Try
			ColorPen.Dispose()
			graph.Dispose()
		Catch ex As Exception
		Finally
			ColorPen = Nothing
			bit = Nothing
			graph = Nothing
		End Try
		
	End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click, cmdSortir.Click
        Me.Close()
    End Sub

    Private Sub frmGrafics_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		setLanguageForm()
        Me.txtIntervalDate.MaxDate = Now
        Me.ClientSize = New Size(frm_sice(0), frm_sice(1))
    End Sub
	
	Dim MSG_GRAFIC_RADIATS_ENTRE_DATES As String
	Dim MSG_GRAFIC_INTERPRET As String
	Dim MSG_GRAFIC_IDIOMA As String
	Dim MSG_GRAFIC_CLAS_SUBJ As String
	Dim MSG_GRAFIC_CLAS_TEMP As String
	Dim MSG_GRAFIC_CLAS_ESTIL As String
	Dim MSG_GRAFIC_RITME As String
	Dim MSG_GRAFIC_ANY As String
	Dim MSG_GRAFIC_ONLY_IN As String 
	Dim MSG_NO_RESULT As String 
	Dim NAME_ALTRES As String 
	
	Public Sub setLanguageForm()
		lang.StrForm = Me.Name
		
		MSG_GRAFIC_RADIATS_ENTRE_DATES =  lang.getText("MSG_GRAFIC_RADIATS_ENTRE_DATES") '"Temes radiats del {0} al {1}."
		MSG_GRAFIC_INTERPRET = lang.getText("MSG_GRAFIC_INTERPRET") '"Estadística dels temes segons l'intèrpret."
		MSG_GRAFIC_IDIOMA = lang.getText("MSG_GRAFIC_IDIOMA") '"Estadística dels temes segons l'Idioma."
		MSG_GRAFIC_CLAS_SUBJ = lang.getText("MSG_GRAFIC_CLAS_SUBJ") '"Estadística dels temes segons la classificació Subjectiva."
		MSG_GRAFIC_CLAS_TEMP = lang.getText("MSG_GRAFIC_CLAS_TEMP") '"Estadística dels temes segons la classificació Temporal."
		MSG_GRAFIC_CLAS_ESTIL = lang.getText("MSG_GRAFIC_CLAS_ESTIL") '"Estadística dels temes segons la classificació Estilítica."
		MSG_GRAFIC_RITME = lang.getText("MSG_GRAFIC_RITME") '"Estadística dels temes segons el Ritme."
		MSG_GRAFIC_ANY = lang.getText("MSG_GRAFIC_ANY") '"Estadística dels temes segons l'any de Publicació."
		MSG_GRAFIC_ONLY_IN = " " & lang.getText("MSG_GRAFIC_ONLY_IN") '"(només dins pautes)"
		MSG_NO_RESULT = lang.getText("MSG_NO_RESULT") '"No hi han resultats"
		NAME_ALTRES = lang.getText("FITXER_ALTRES",True) '"ALTRES"
		
		Me.TabPage1.Text = lang.getText("TabPage1.Text") '"Radiació"
		
		
		
		Me.TabPage2.Text = lang.getText("TabPage2.Text") '"DBS"
		Me.chkPautaIn.Text = lang.getText("LABEL_ONLY_ACTIVES",True) '"Només inclosos a la pauta."
		Me.cmdDBSAny.Text = lang.getText("cmdDBSAny.Text") '"Estadística per Any Publicació"
		Me.cmdDBSRitme.Text = lang.getText("cmdDBSRitme.Text") '"Estadística per Ritme"
		Me.cmdDBSTemp.Text = lang.getText("cmdDBSTemp.Text") '"Estadística per Clas. Temporal"
		Me.cmdDBSSubj.Text = lang.getText("cmdDBSSubj.Text") '"Estadística per Clas. Subjectiva"
		Me.cmdRadiaIdioma.Text = lang.getText("cmdRadiaIdioma.Text") '"Estadística per Idiomes"
		Me.cmdDBSIdioma.Text = cmdRadiaIdioma.Text  '"Estadística per Idiomes"
		Me.cmdRadiaInterp.Text = lang.getText("cmdRadiaInterp.Text") '"Estadística per Intèrprets"
		Me.cmdDBSInterp.Text = cmdRadiaInterp.Text  '"Estadística per Intèrprets"
		
		Me.cmdRadiaEstil.Text = lang.getText("cmdRadiaEstil.Text") '"Estadística per Estils"
		Me.cmdDBSEstil.Text = cmdRadiaEstil.Text '"Estadística per Estils"
		Me.Text = lang.getText("LABEL_ESTADISTICA",True) '"Estadística"
		
		
	End Sub

    Private Sub frmGrafics_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        Dim FitxerINI As New IniFile
        frm_sice(0) = Me.Width : frm_sice(1) = Me.Height
        FitxerINI.INIWrite(MyAPP.IniFile, "Data Gest", "size", frm_sice(0).ToString & "," & frm_sice(1).ToString)
    End Sub
End Class