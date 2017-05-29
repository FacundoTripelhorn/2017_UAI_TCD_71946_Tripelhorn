Imports DAL_ABMC
Public Class ServicioDinamico
    Implements IABMC

    Dim vServicioDatos As New ServicioDatos
    Public Sub Alta(Optional pObjeto As Object = Nothing) Implements IABMC.Alta
        vServicioDatos.Alta(pObjeto)
    End Sub

    Public Sub Baja(Optional pObjeto As Object = Nothing) Implements IABMC.Baja
        vServicioDatos.Baja(pObjeto)
    End Sub

    Public Sub Modificacion(Optional pObjeto As Object = Nothing) Implements IABMC.Modificacion
        vServicioDatos.Modificacion(pObjeto)
    End Sub

    Public Function ConsultaTodo() As List(Of Object) Implements IABMC.ConsultaTodo
        Return vServicioDatos.ConsultaTodo()
    End Function
End Class
