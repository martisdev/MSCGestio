Imports System.Data
Imports System.IO
Imports System.Reflection
Imports System.Windows.Forms

Namespace MetroFramework.Localization
    Friend Class MetroLocalize
        Private languageDataset As DataSet

        Public Function DefaultLanguage() As String
            Return "en"
        End Function

        Public Function CurrentLanguage() As String
            Dim language As String = Application.CurrentCulture.TwoLetterISOLanguageName

            If language.Length = 0 Then
                language = DefaultLanguage()
            End If

            Return language.ToLower()
        End Function

        Public Sub New(ByVal ctrlName As String)
            importManifestResource(ctrlName)
        End Sub

        Public Sub New(ByVal ctrl As Control)
            importManifestResource(ctrl.Name)
        End Sub

        Private Sub importManifestResource(ByVal ctrlName As String)
            Dim callingAssembly As Assembly = Assembly.GetCallingAssembly()
            Dim localizationFilename As String = callingAssembly.GetName().Name & ".Localization." & CurrentLanguage() & "." & ctrlName & ".xml"
            Dim xmlStream As Stream = callingAssembly.GetManifestResourceStream(localizationFilename)

            If xmlStream Is Nothing Then
                localizationFilename = callingAssembly.GetName().Name & ".Localization." & DefaultLanguage() & "." & ctrlName & ".xml"
                xmlStream = callingAssembly.GetManifestResourceStream(localizationFilename)
            End If

            If languageDataset Is Nothing Then languageDataset = New DataSet()

            If xmlStream IsNot Nothing Then
                Dim importDataset As DataSet = New DataSet()
                importDataset.ReadXml(xmlStream)
                languageDataset.Merge(importDataset)
                xmlStream.Close()
            End If
        End Sub

        Private Function convertVar(ByVal var As Object) As String
            If var Is Nothing Then Return ""
            Return var.ToString()
        End Function

        Public Function translate(ByVal key As String) As String
            If (String.IsNullOrEmpty(key)) Then
                Return ""
            End If

            If languageDataset Is Nothing Then
                Return "~" & key
            End If

            If languageDataset.Tables("Localization") Is Nothing Then
                Return "~" & key
            End If

            Dim languageRows As DataRow() = languageDataset.Tables("Localization").[Select]("Key='" & key & "'")

            If languageRows.Length <= 0 Then
                Return "~" & key
            End If

            Return languageRows(0)("Value").ToString()
        End Function

        Public Function translate(ByVal key As String, ByVal var1 As Object) As String
            Dim str As String = translate(key)
            Return str.Replace("#1", convertVar(var1))
        End Function

        Public Function translate(ByVal key As String, ByVal var1 As Object, ByVal var2 As Object) As String
            Dim str As String = translate(key)
            str = str.Replace("#1", convertVar(var1))
            Return str.Replace("#2", convertVar(var2))
        End Function

        Public Function getValue(ByVal key As String, ByVal var1 As Object, ByVal var2 As Object, ByVal var3 As Object) As String
            Dim str As String = translate(key)
            str = str.Replace("#1", convertVar(var1))
            str = str.Replace("#2", convertVar(var2))
            Return str.Replace("#3", convertVar(var3))
        End Function

        Public Function getValue(ByVal key As String, ByVal var1 As Object, ByVal var2 As Object, ByVal var3 As Object, ByVal var4 As Object) As String
            Dim str As String = translate(key)
            str = str.Replace("#1", convertVar(var1))
            str = str.Replace("#2", convertVar(var2))
            str = str.Replace("#3", convertVar(var3))
            Return str.Replace("#4", convertVar(var4))
        End Function

        Public Function getValue(ByVal key As String, ByVal var1 As Object, ByVal var2 As Object, ByVal var3 As Object, ByVal var4 As Object, ByVal var5 As Object) As String
            Dim str As String = translate(key)
            str = str.Replace("#1", convertVar(var1))
            str = str.Replace("#2", convertVar(var2))
            str = str.Replace("#3", convertVar(var3))
            str = str.Replace("#4", convertVar(var4))
            Return str.Replace("#5", convertVar(var5))
        End Function
    End Class
End Namespace

