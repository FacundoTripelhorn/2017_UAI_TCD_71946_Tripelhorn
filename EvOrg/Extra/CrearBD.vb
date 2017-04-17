Imports System.Data.SqlClient
Imports System.IO
Imports System.Data.Sql
Imports System.Windows.Forms
Imports System.Configuration
Public Class CrearBD
    Public Function CargarServidores() As List(Of String)
        Dim Instance As SqlDataSourceEnumerator = SqlDataSourceEnumerator.Instance
        Dim DTable As DataTable = Instance.GetDataSources
        Dim ListaDeServidores As New List(Of String)
        For Each DRow As DataRow In DTable.Rows
            ListaDeServidores.Add(DRow.Item(0) & "\" & DRow(1))
        Next
        Return ListaDeServidores
    End Function

    Public Sub CrearBase()

        Dim vScript As New FileStream(Application.StartupPath & "\EvOrgScript.sql", FileMode.Open)
        Dim vLector As New StreamReader(vScript)
        Dim vStringConexion As String = ConfigurationManager.ConnectionStrings.Item("MiConexion").ConnectionString
        Dim vStringBuilder As New SqlConnectionStringBuilder
        vStringBuilder.ConnectionString = vStringConexion
        vStringBuilder.InitialCatalog = "master"
        Dim vConexion As New SqlConnection(vStringBuilder.ConnectionString)
        vConexion.Open()
        Try
            Dim vComando As New SqlCommand("CREATE DATABASE [EvOrg]", vConexion)
            vComando.ExecuteNonQuery()
            vConexion.ChangeDatabase("EvOrg")
            vComando.CommandText = vLector.ReadToEnd
            vComando.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        vConexion.Close()
        vLector.Close()
        vScript.Close()
    End Sub

    Public Sub CrearString(Optional pServidor As String = Nothing)
        Try
            Dim vConfig As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("MiConexion")
            If Not vConfig Is Nothing Then
                Dim vString As String
                Dim vConstructor As New SqlConnectionStringBuilder(vConfig.ConnectionString)
                vConstructor.DataSource = pServidor
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
