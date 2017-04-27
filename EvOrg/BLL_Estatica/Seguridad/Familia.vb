Public Class Familia
    Property Id As Integer
    Property Nombre As String
    Property ListaPatentes As New List(Of PatenteAbstracta)

    Sub New()

    End Sub

    Sub New(pNombre As String)
        Nombre = pNombre
    End Sub

    Sub New(pId As Integer, pNombre As String)
        Id = pId
        Nombre = pNombre
    End Sub

    Public Function GetPatentes() As List(Of PatenteAbstracta)
        Return ListaPatentes
    End Function
End Class
