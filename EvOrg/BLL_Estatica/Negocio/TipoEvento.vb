Public Class TipoEvento
    Property Id As Integer
    Property Nombre As String
    Property Descripcion As String
    Property ListaPasos As New List(Of Paso)

    Sub New()

    End Sub

    Sub New(pNombre As String, pDescripcion As String)
        Nombre = pNombre
        Descripcion = pDescripcion
    End Sub

    Sub New(pId As Integer, pNombre As String, pDescripcion As String)
        Id = pId
        Nombre = pNombre
        Descripcion = pDescripcion
    End Sub
End Class
