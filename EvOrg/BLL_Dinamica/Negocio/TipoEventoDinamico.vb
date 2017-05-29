Imports DAL_ABMC
Imports BLL_Estatica
Public Class TipoEventoDinamico
    Implements IABMC

    Dim vTipoEventoDatos As New TipoEventoDatos
    Public Sub Alta(Optional pObjeto As Object = Nothing) Implements IABMC.Alta
        vTipoEventoDatos.Alta(pObjeto)
    End Sub

    Public Sub Baja(Optional pObjeto As Object = Nothing) Implements IABMC.Baja
        vTipoEventoDatos.Baja(pObjeto)
    End Sub

    Public Sub Modificacion(Optional pObjeto As Object = Nothing) Implements IABMC.Modificacion
        vTipoEventoDatos.Modificacion(pObjeto)
    End Sub

    Public Function ConsultaTodo() As List(Of Object) Implements IABMC.ConsultaTodo
        Return vTipoEventoDatos.ConsultaTodo()
    End Function

    Public Sub AgregarPaso(pTipoEvento As TipoEvento, pPaso As Paso, pDias As Integer)
        vTipoEventoDatos.AgregarPaso(pTipoEvento, pPaso, pDias)
    End Sub

    Public Sub BorrarPaso(pTipoEvento As TipoEvento, pPaso As Paso)
        vTipoEventoDatos.BorrarPaso(pTipoEvento, pPaso)
    End Sub

    Public Function ConsultaDias(pTipoEvento As TipoEvento, pPaso As Paso) As Integer
        Return vTipoEventoDatos.ConsultaDias(pTipoEvento, pPaso)
    End Function
End Class
