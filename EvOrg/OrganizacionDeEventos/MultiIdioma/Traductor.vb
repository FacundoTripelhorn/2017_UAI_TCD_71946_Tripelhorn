Imports OrganizacionDeEventos

Public Class Traductor
    Implements IObservado

#Region "Singleton"
    Private Shared vTraductor As Traductor = Nothing

    Private Sub New()

    End Sub
    Public Shared Function GetInstance() As Traductor
        If vTraductor Is Nothing Then
            vTraductor = New Traductor
        End If
        Return vTraductor
    End Function
#End Region
    Public Property ListaObservador As List(Of IObservador) Implements IObservado.ListaObservador

    Public Sub Notificar() Implements IObservado.Notificar
        For Each vObservador As IObservador In ListaObservador
            vObservador.Update()
        Next
    End Sub

    Public Sub Registrar(pObservador As IObservador) Implements IObservado.Registrar
        If ListaObservador.Count > 0 Then
            For Each vObservador As IObservador In ListaObservador
                If vObservador.ToString = pObservador.ToString Then
                    ListaObservador.Remove(vObservador)
                    Exit For
                End If
            Next
        End If
        ListaObservador.Add(pObservador)
    End Sub
End Class
