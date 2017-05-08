Imports System.Configuration
Imports System.Data.SqlClient

Public Class Conexion
    Private Shared vObjConexion As SqlConnection

    Public Shared Function ObjConexion() As SqlConnection
        If vObjConexion Is Nothing Then
            vObjConexion = New SqlConnection
        End If
        Dim vString As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("MiConexion")
        vObjConexion.ConnectionString = vString.ConnectionString
        Return vObjConexion
    End Function
End Class
