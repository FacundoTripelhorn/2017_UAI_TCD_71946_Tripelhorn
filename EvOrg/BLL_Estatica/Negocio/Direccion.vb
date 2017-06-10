Public Class Direccion
    Property Id As Integer
    Property Calle As String
    Property Numero As Integer
    Property Localidad As String

    Sub New()

    End Sub

    Sub New(pCalle As String, pNumero As Integer, pLocalidad As String)
        Calle = pCalle
        Numero = pNumero
        Localidad = pLocalidad
    End Sub

    Sub New(pId As Integer, pCalle As String, pNumero As Integer, pLocalidad As String)
        Id = pId
        Calle = pCalle
        Numero = pNumero
        Localidad = pLocalidad
    End Sub
End Class
