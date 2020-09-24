Imports System.Threading

Namespace My
	
	' StartupNextInstance: se desencadena cuando se inicia una aplicación de instancia única y la aplicación ya está activa. 
	' NetworkAvailabilityChanged: se desencadena cuando la conexión de red está conectada o desconectada.
	
	'at MSCGestio.My.MyApplication.MyApplication_Startup(Object sender, StartupEventArgs e)\r\n   
	'at Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase.OnStartup(StartupEventArgs eventArgs)\r\n   
	'at Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase.DoApplicationModel()\r\n   
	'at Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase.Run(String[] commandLine)\r\n   
	'at MSCGestio.My.MyApplication.Main(String[] Args) in 17d14f5c-a337-4978-8281-53493378c1071.vb:line 81\r\n   
	'at System.AppDomain._nExecuteAssembly(Assembly assembly, String[] args)\r\n   
	'at System.AppDomain.ExecuteAssembly(String assemblyFile, Evidence assemblySecurity, String[] args)\r\n   
	'at Microsoft.VisualStudio.HostingProcess.HostProc.RunUsersAssembly()\r\n   
	'at System.Threading.ThreadHelper.ThreadStart_Context(Object state)\r\n   
	'at System.Threading.ExecutionContext.Run(ExecutionContext executionContext, ContextCallback callback, Object state)\r\n   
	'at System.Threading.ThreadHelper.ThreadStart()"
	
	Partial Friend Class MyApplication

        Const MIN_VER_DBS As String = "4.1"
        'Const NAME_APLIC As Short = Aplicatius.PRG_GESTIO

        Private Sub MyApplication_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown
			CloseMyApp()
		End Sub
		
		Private Sub MyApplication_Startup(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup
			'TODO: Controlar els resultats de la connexió msc.ini, dbs i usuari
			
			MyAPP = New MSC.Control.MSC_Aplic
			MyAPP.AplicActual = Aplicatius.PRG_GESTIO
			Dim PathAppData As String = System.Environment.GetFolderPath(System.Environment.SpecialFolder.CommonApplicationData ) & "\" & My.Application.info.CompanyName 
			If io.Directory.Exists (PathAppData )= False Then
				IO.Directory.CreateDirectory ( PathAppData)
			End If
			MyAPP.IniFile = PathAppData   & "\msc.ini"

            'Controlem Llicències i establim els valors per la connexió DBS
            Dim result As ErrorsConnect = CType(MyAPP.IniAplic(), ErrorsConnect)
            Select Case result
				Case ErrorsConnect.Err_NO_ERROR 'OK Continuem.                
				Case ErrorsConnect.Err_NO_CONNECT_TO_SERVER : End
				Case ErrorsConnect.Err_INI_NO_EXIST : End
				Case ErrorsConnect.Err_STOP : End
			End Select
			If MyAPP.TestVersionDBS(MIN_VER_DBS) = False Then CloseMyApp()

            'Atenció: Perillos segons la capacitat de processament del sistema.
            Dim filIniDataSet As Thread
			filIniDataSet = New Thread(AddressOf IniDataSet)
			filIniDataSet.IsBackground = True
			filIniDataSet.Priority = ThreadPriority.Highest
			filIniDataSet.Start()
			
			'control d'usuaris            
			Usuari = New MSC.User(MyAPP)
			If Usuari.UsrErrNum > 0 Then
				CloseMyApp() : End
			End If
			
			Params = New Parametres.clsParams
            Lang = New MSC.UserLanguage(Params.Lang)
            Lang.StrApp = My.Application.Info.AssemblyName

            My.Application.ChangeUICulture(lang.Code)

            If MyAPP.UPDATESYSTEM = True AndAlso Cloud.IsActive = True Then
                Dim frmSincro As New frmUpdateCloud(True)
                frmSincro.ShowDialog()
            End If


            If MyAPP.NovaConnex(getNomAplic(Aplicatius.PRG_GESTIO), Usuari.UsrNom, True) = False Then CloseMyApp() : End

            'Iniciem el sistema de registre d'errors
            MyAPP.Error_MSC = New MSC.Control.MSC_Error(Params.ActvSrvEmergenci, Params.ErrEmail, Params.NomRadio, Params.SendToDevelop, BETA_VERSION)

            RegisterBass()

		End Sub
		
		Private Sub MyApplication_UnhandledException(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs) Handles Me.UnhandledException
			
			'Registra les exepcions no controlades.
			Dim ex As Exception = e.Exception
			Dim InfoErr As Boolean = True
			Dim ForceMailInDebug As Boolean = False
			Dim InCrash As Boolean = True
			MyAPP.Error_MSC.SalvarExcepcioNoControlada(ex , , InCrash,ForceMailInDebug,InfoErr )
				
			'End
			CloseMyApp()
		End Sub

        Private Sub CloseMyApp()

            If Usuari IsNot Nothing AndAlso Usuari.UsrID > 0 Then Usuari.EndUserSession(Usuari.UsrID)
            MyAPP.CloseSesionClient(MyAPP.IDSesion_Client)
            End

        End Sub

    End Class
	
End Namespace

