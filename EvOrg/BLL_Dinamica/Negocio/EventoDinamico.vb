Imports DAL_ABMC
Imports BLL_Estatica
Public Class EventoDinamico
    Implements IABMC

    Dim vEventoDatos As New EventoDatos
    Public Sub Alta(Optional pObjeto As Object = Nothing) Implements IABMC.Alta
        vEventoDatos.Alta(pObjeto)
    End Sub

    Public Sub Baja(Optional pObjeto As Object = Nothing) Implements IABMC.Baja
        vEventoDatos.Baja(pObjeto)
    End Sub

    Public Sub Modificacion(Optional pObjeto As Object = Nothing) Implements IABMC.Modificacion
        vEventoDatos.Modificacion(pObjeto)
    End Sub

    Public Function ConsultaTodo() As List(Of Object) Implements IABMC.ConsultaTodo
        Return vEventoDatos.ConsultaTodo()
    End Function

    Public Sub AgregarPaso(pEvento As Evento, pPaso As Paso, pFecha As Date)
        vEventoDatos.AgregarPaso(pEvento, pPaso, pFecha)
    End Sub
End Class
