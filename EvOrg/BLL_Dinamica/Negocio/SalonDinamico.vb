Imports DAL_ABMC
Public Class SalonDinamico
    Implements IABMC

    Dim vSalonDatos As New SalonDatos
    Public Sub Alta(Optional pObjeto As Object = Nothing) Implements IABMC.Alta
        vSalonDatos.Alta(pObjeto)
    End Sub

    Public Sub Baja(Optional pObjeto As Object = Nothing) Implements IABMC.Baja
        vSalonDatos.Baja(pObjeto)
    End Sub

    Public Sub Modificacion(Optional pObjeto As Object = Nothing) Implements IABMC.Modificacion
        vSalonDatos.Modificacion(pObjeto)
    End Sub

    Public Function ConsultaTodo() As List(Of Object) Implements IABMC.ConsultaTodo
        Return vSalonDatos.ConsultaTodo()
    End Function

    Public Function CheckSalon(pNombre As String) As Boolean
        Return vSalonDatos.CheckSalon(pNombre)
    End Function
End Class
