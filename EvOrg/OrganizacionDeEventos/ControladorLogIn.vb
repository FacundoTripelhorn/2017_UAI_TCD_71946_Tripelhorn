Imports Framework
Imports BLL_Dinamica
Imports BLL_Estatica
Public Class ControladorLogIn
#Region "Singleton"
    Private Shared vControladorLogIn As ControladorLogIn = Nothing
    Private Sub New()

    End Sub
    Public Shared Function GetInstance() As ControladorLogIn
        If vControladorLogIn Is Nothing Then
            Dim vCreadorBD As CreadorBD = CreadorBD.GetInstance
            vCreadorBD.Crear()
            vControladorLogIn = New ControladorLogIn
        End If
        Return vControladorLogIn
    End Function
#End Region

    Public Function Aceptar(pUsuario As String, pContraseña As String) As Boolean
        Try
            Dim vUsuario As New Usuario
            Dim vUsuarioDinamico As New UsuarioDinamico
            Dim vEncriptar As Encriptador = Encriptador.GetInstance
            vUsuario.IdUsuario = pUsuario
            vUsuario.Contraseña = vEncriptar.Encriptar(pContraseña)

            If vUsuarioDinamico.InicioSesion(vUsuario, pContraseña) = True Then
                Dim vInicio As New Inicio(vUsuario)
                vInicio.Show()
            Else
                Throw New Exception(MsgBox("Usuario y/o contraseña incorrectos"))
            End If
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
