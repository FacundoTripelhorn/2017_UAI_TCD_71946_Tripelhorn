Public Class Idioma
    Property Id As Integer
    Property Nombre As String
    Property Diccionario As Dictionary(Of String, String)

    Sub New()

    End Sub

    Sub New(pId As Integer, pNombre As String, pDiccionario As Dictionary(Of String, String))
        Id = pId
        Nombre = pNombre
        Diccionario = pDiccionario
    End Sub

    Sub New(pNombre As String, pDiccionario As Dictionary(Of String, String))
        Nombre = pNombre
        Diccionario = pDiccionario
    End Sub

    Public Overrides Function ToString() As String
        Return Me.Nombre
    End Function
End Class
