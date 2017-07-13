Imports DAL_ABMC
Public Class PasoDinamico
    Implements IABMC

    Dim PasoDatos As PasoDatos

    Sub New()
        PasoDatos = New PasoDatos
    End Sub
    Public Sub Alta(Optional pObjeto As Object = Nothing) Implements IABMC.Alta
        PasoDatos.Alta(pObjeto)
    End Sub

    Public Sub Baja(Optional pObjeto As Object = Nothing) Implements IABMC.Baja
        PasoDatos.Baja(pObjeto)
    End Sub

    Public Sub Modificacion(Optional pObjeto As Object = Nothing) Implements IABMC.Modificacion
        PasoDatos.Modificacion(pObjeto)
    End Sub

    Public Function ConsultaTodo() As List(Of Object) Implements IABMC.ConsultaTodo
        Return PasoDatos.ConsultaTodo()
    End Function

    Public Function CheckPaso(pDescripcion As String) As Boolean
        Return PasoDatos.CheckPaso(pDescripcion)
    End Function

    Public Function CheckPasoTipoEvento(pDescripcion As String) As Boolean
        Return PasoDatos.CheckPasoTipoEvento(pDescripcion)
    End Function
End Class
