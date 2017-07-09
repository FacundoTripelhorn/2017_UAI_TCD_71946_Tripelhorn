Imports DAL_ABMC
Imports BLL_Estatica
Public Class ClienteDinamico
    Implements IABMC

    Dim ClienteDatos As ClienteDatos

    Sub New()
        ClienteDatos = New ClienteDatos
    End Sub
    Public Sub Alta(Optional pObjeto As Object = Nothing) Implements IABMC.Alta
        ClienteDatos.Alta(pObjeto)
    End Sub

    Public Sub Baja(Optional pObjeto As Object = Nothing) Implements IABMC.Baja
        ClienteDatos.Baja(pObjeto)
    End Sub

    Public Sub Modificacion(Optional pObjeto As Object = Nothing) Implements IABMC.Modificacion
        ClienteDatos.Modificacion(pObjeto)
    End Sub

    Public Function ConsultaTodo() As List(Of Object) Implements IABMC.ConsultaTodo
        Return ClienteDatos.ConsultaTodo()
    End Function

    Public Function GetCliente(pDNI As Integer) As Cliente
        Return ClienteDatos.GetCliente(pDNI)
    End Function

    Public Function CheckCliente(pDNI As Integer) As Boolean
        Return ClienteDatos.CheckCliente(pDNI)
    End Function
End Class
