Imports BLL_Dinamica
Imports BLL_Estatica
Imports OrganizacionDeEventos

Public Class Traductor
    Implements IObservado

#Region "Singleton"
    Private Shared vTraductor As Traductor

    Private Sub New()
    End Sub

    Public Shared Function GetInstance() As Traductor
        If vTraductor Is Nothing Then
            vTraductor = New Traductor
            vTraductor.IdiomaSeleccionado = vTraductor.GetIdiomas().Item(0)
        End If
        Return vTraductor
    End Function

    Public Function Traducir(pTraducible As String) As String
        If Me.IdiomaSeleccionado.Diccionario.ContainsKey(pTraducible) Then
            Return Me.IdiomaSeleccionado.Diccionario(pTraducible)
        Else
            Return pTraducible
        End If
    End Function
#End Region

    Private vIdiomaSeleccionado As Idioma
    Public Property IdiomaSeleccionado() As Idioma
        Get
            Return vIdiomaSeleccionado
        End Get
        Set(ByVal value As Idioma)
            If vIdiomaSeleccionado Is Nothing OrElse vIdiomaSeleccionado.Nombre <> value.Nombre Then
                vIdiomaSeleccionado = value
                Notificar()
            End If
        End Set
    End Property

    Dim vListaRegistrados As New List(Of IObservador)
    Dim vIdiomaDinamico As IdiomaDinamico = IdiomaDinamico.GetInstance

    Public ReadOnly Property Registrados As List(Of IObservador) Implements IObservado.Registrados
        Get
            Return vListaRegistrados
        End Get
    End Property

    Public Sub Notificar() Implements IObservado.Notificar
        For Each vRegistrado As IObservador In vListaRegistrados
            vRegistrado.ActualizarObservador(vRegistrado)
        Next
    End Sub

    Public Sub Registrar(pObservador As IObservador) Implements IObservado.Registrar
        If vListaRegistrados.Count > 0 Then
            For Each vRegistrado As IObservador In vListaRegistrados
                If vRegistrado.ToString = pObservador.ToString Then
                    vListaRegistrados.Remove(vRegistrado)
                    Exit For
                End If
            Next
        End If
        vListaRegistrados.Add(pObservador)
    End Sub

    Public Function GetIdiomas() As List(Of Idioma)
        Try
            Dim vLista As New List(Of Idioma)
            For Each vIdioma As Idioma In vIdiomaDinamico.ConsultaTodo
                vLista.Add(vIdioma)
            Next
            Return vLista
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Sub AltaIdioma(pNombre As String, pDiccionario As Dictionary(Of String, String))
        Dim vIdioma As New Idioma(pNombre, pDiccionario)
        vIdiomaDinamico.Alta(vIdioma)
    End Sub

    Public Sub BajaIdioma(pIdioma As Idioma)
        vIdiomaDinamico.Baja(pIdioma)
    End Sub

    Public Sub ModificacionIdioma(pIdioma As Idioma)
        vIdiomaDinamico.Modificacion(pIdioma)
    End Sub
End Class
