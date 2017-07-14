Imports DAL_ABMC
Imports BLL_Estatica
Public Class MaterialDinamico
    Implements IABMC

    Dim MaterialDatos As MaterialDatos

    Sub New()
        Me.MaterialDatos = New MaterialDatos
    End Sub

    Public Sub Alta(Optional pObjeto As Object = Nothing) Implements IABMC.Alta
        Me.MaterialDatos.Alta(pObjeto)
    End Sub

    Public Sub Baja(Optional pObjeto As Object = Nothing) Implements IABMC.Baja
        Me.MaterialDatos.Baja(pObjeto)
    End Sub

    Public Sub Modificacion(Optional pObjeto As Object = Nothing) Implements IABMC.Modificacion
        Me.MaterialDatos.Modificacion(pObjeto)
    End Sub

    Public Function ConsultaTodo() As List(Of Object) Implements IABMC.ConsultaTodo
        Return Me.MaterialDatos.ConsultaTodo()
    End Function

    Public Function ConsultaReservas() As List(Of Material)
        Return Me.MaterialDatos.ConsultaReservas()
    End Function

    Public Function CheckMaterial(pId As Integer, pNombre As String) As Boolean
        Return Me.MaterialDatos.CheckMaterial(pId, pNombre)
    End Function
End Class
