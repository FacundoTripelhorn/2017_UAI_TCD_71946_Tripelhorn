Imports DAL_ABMC
Public Class IdiomaDinamico
    Implements IABMC

#Region "Singleton"
    Private Shared vIdiomaDinamico As IdiomaDinamico = Nothing
    Private Sub New()

    End Sub
    Public Shared Function GetInstance() As IdiomaDinamico
        If vIdiomaDinamico Is Nothing Then
            vIdiomaDinamico = New IdiomaDinamico
        End If
        Return vIdiomaDinamico
    End Function
#End Region

    Dim vIdiomaDatos As IdiomaDatos = IdiomaDatos.GetInstance

    Public Sub Alta(Optional pObjeto As Object = Nothing) Implements IABMC.Alta
        vIdiomaDatos.Alta(pObjeto)
    End Sub

    Public Sub Baja(Optional pObjeto As Object = Nothing) Implements IABMC.Baja
        vIdiomaDatos.Baja(pObjeto)
    End Sub

    Public Sub Modificacion(Optional pObjeto As Object = Nothing) Implements IABMC.Modificacion
        vIdiomaDatos.Modificacion(pObjeto)
    End Sub

    Public Function ConsultaTodo() As List(Of Object) Implements IABMC.ConsultaTodo
        Return vIdiomaDatos.ConsultaTodo()
    End Function
End Class
