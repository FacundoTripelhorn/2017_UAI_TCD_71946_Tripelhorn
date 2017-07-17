Imports DAL_ABMC

Public Class FamiliaDinamica
    Implements IABMC

    Dim FamiliaDatos As New FamiliaDatos

    Public Sub Alta(Optional pObjeto As Object = Nothing) Implements IABMC.Alta
        FamiliaDatos.Alta(pObjeto)
    End Sub

    Public Sub Baja(Optional pObjeto As Object = Nothing) Implements IABMC.Baja
        FamiliaDatos.Baja(pObjeto)
    End Sub

    Public Sub Modificacion(Optional pObjeto As Object = Nothing) Implements IABMC.Modificacion
        FamiliaDatos.Modificacion(pObjeto)
    End Sub

    Public Function ConsultaTodo() As List(Of Object) Implements IABMC.ConsultaTodo
        Return FamiliaDatos.ConsultaTodo()
    End Function

    Public Function CheckFamilia(pNombre As String) As String
        Return FamiliaDatos.CheckFamilia(pNombre)
    End Function

    Public Function ListarPatentes(pObjeto As Object) As List(Of Object)
        Return FamiliaDatos.ListarPatentes(pObjeto)
    End Function

    Public Function CheckUsuarios(pId As Integer) As Boolean
        Return FamiliaDatos.CheckUsuarios(pId)
    End Function
End Class
