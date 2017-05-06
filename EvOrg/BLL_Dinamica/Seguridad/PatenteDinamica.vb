Imports System.Windows.Forms
Imports BLL_Estatica
Imports DAL_ABMC

Public Class PatenteDinamica
    Inherits PatenteAbstractaDinamica
    Implements IABMC

    Dim PatenteDatos As New PatenteDatos

    Public Sub Alta(Optional pObjeto As Object = Nothing) Implements IABMC.Alta
        PatenteDatos.Alta(pObjeto)
    End Sub

    Public Sub Baja(Optional pObjeto As Object = Nothing) Implements IABMC.Baja
        PatenteDatos.Baja(pObjeto)
    End Sub

    Public Sub Modificacion(Optional pObjeto As Object = Nothing) Implements IABMC.Modificacion
        PatenteDatos.Modificacion(pObjeto)
    End Sub

    Public Overrides Sub MostrarEnMenuStrip(pMenuStrip As MenuStrip, pUsuario As Usuario, pFormulario As Form)
        Throw New NotImplementedException()
    End Sub

    Public Function ConsultaTodo() As List(Of Object) Implements IABMC.ConsultaTodo
        Return PatenteDatos.ConsultaTodo()
    End Function

    Public Overrides Function MostrarEnTreeView(pTreeView As TreeView) As TreeView
        Throw New NotImplementedException()
    End Function
End Class
