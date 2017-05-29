Public Class Direccion
    Property Id As Integer
    Property Calle As String
    Property Numero As Integer
    Property CP As Integer

    Sub New()

    End Sub

    Sub New(pCalle As String, pNumero As Integer, pCP As Integer)
        Calle = pCalle
        Numero = pNumero
        CP = pCP
    End Sub

    Sub New(pId As Integer, pCalle As String, pNumero As Integer, pCP As Integer)
        Id = pId
        Calle = pCalle
        Numero = pNumero
        CP = pCP
    End Sub
End Class
