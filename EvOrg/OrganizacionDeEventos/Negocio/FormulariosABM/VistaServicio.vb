Public Class VistaServicio
    Property Nombre As String
    Property Email As String
    Property Telefono As Integer
    Property Precio As Decimal
    Sub New()

    End Sub

    Sub New(pNombre As String, pTelefono As Integer, pEmail As String, pPrecio As Decimal)
        Nombre = pNombre
        Email = pEmail
        Telefono = pTelefono
        Precio = pPrecio
    End Sub
End Class
