Imports System.Data.SqlClient
Imports System.IO
Imports System.Data.Sql
Imports System.Windows.Forms
Imports System.Configuration
Public Class CreadorBD
#Region "Singleton"
    Private Shared vCreadorBD As CreadorBD = Nothing
    Private Sub New()

    End Sub
    Public Shared Function GetInstance() As CreadorBD
        If vCreadorBD Is Nothing Then
            vCreadorBD = New CreadorBD
        End If
        Return vCreadorBD
    End Function
#End Region

    Dim vFlag = False
    Public Sub Crear()
        Try
            If vFlag = False Then
                CrearString()
                CrearBD()
                vFlag = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub CrearBD()
        Dim vScript As New FileStream(Application.StartupPath & "\EvOrgScript.sql", FileMode.Open)
        Dim vLector As New StreamReader(vScript, New Text.UTF7Encoding)
        Dim vStringConexion As String = ConfigurationManager.ConnectionStrings.Item("MiConexion").ConnectionString
        Dim vStringBuilder As New SqlConnectionStringBuilder
        vStringBuilder.ConnectionString = vStringConexion
        vStringBuilder.InitialCatalog = "master"
        Dim vConexion As New SqlConnection(vStringBuilder.ConnectionString)
        vConexion.Open()
        Dim vComando As New SqlCommand
        Try
            vComando = New SqlCommand("CREATE DATABASE [EvOrg]", vConexion)
            vComando.ExecuteNonQuery()
        Catch ex As Exception

        End Try
        Try
            vConexion.ChangeDatabase("EvOrg")
            vComando.CommandText = vLector.ReadToEnd
            vComando.ExecuteNonQuery()
        Catch ex As Exception

        End Try
        vConexion.Close()
        vLector.Close()
        vScript.Close()
    End Sub

    Public Sub CrearString()
        Try
            Dim vInstance As SqlDataSourceEnumerator = SqlDataSourceEnumerator.Instance
            Dim vDTable As DataTable = vInstance.GetDataSources
            Dim vConfig As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("MiConexion")
            If Not vConfig Is Nothing Then
                Dim vString As String
                Dim vConstructor As New SqlConnectionStringBuilder(vConfig.ConnectionString)
                vConstructor.DataSource = vDTable.Rows(0).Item(0) & "\" & vDTable.Rows(0).Item(1)
                vConstructor.IntegratedSecurity = True
                vString = vConstructor.ConnectionString
                SetConfig(vString)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub SetConfig(pString As String)
        Dim vConfig As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
        Dim vAppSettingSection As ConnectionStringsSection = vConfig.ConnectionStrings
        Dim vSettings As ConnectionStringSettings = vAppSettingSection.ConnectionStrings.Item("MiConexion")
        vSettings.ConnectionString = pString
        vConfig.Save(ConfigurationSaveMode.Modified)
        ConfigurationManager.RefreshSection("connectionStrings")
    End Sub
End Class

