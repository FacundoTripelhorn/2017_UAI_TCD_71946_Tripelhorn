Public Class GrupoPatente
    Inherits PatenteAbstracta

    Property ListaPatentes As New List(Of PatenteAbstracta)

    Sub New()

    End Sub

    Sub New(pId As Integer, pNombre As String, Optional pPadre As Integer = 1)
        Id = pId
        Nombre = pNombre
        Padre = pPadre
    End Sub
End Class
