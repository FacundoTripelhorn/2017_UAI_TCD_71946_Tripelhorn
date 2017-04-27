Imports DAL_ABMC

Public Class UsuarioDinamico
    Implements IABMC

    Property UsuarioDatos As New UsuarioDatos

    Public Sub Alta(Optional pObjeto As Object = Nothing) Implements IABMC.Alta
        UsuarioDatos.Alta(pObjeto)
    End Sub

    Public Sub Baja(Optional pObjeto As Object = Nothing) Implements IABMC.Baja
        UsuarioDatos.Baja(pObjeto)
    End Sub

    Public Sub Modificacion(Optional pObjeto As Object = Nothing) Implements IABMC.Modificacion
        UsuarioDatos.Modificacion(pObjeto)
    End Sub

    Public Function ConsultaTodo() As List(Of Object) Implements IABMC.ConsultaTodo
        Return UsuarioDatos.ConsultaTodo()
    End Function

    Public Function InicioSesion(Optional pObjeto As Object = Nothing) As Boolean
        Return UsuarioDatos.InicioSesion(pObjeto)
    End Function

    Public Function DevuelveUsuario(pIdUsuario As String) As Object
        Return UsuarioDatos.DevuelveUsuario(pIdUsuario)
    End Function
End Class
