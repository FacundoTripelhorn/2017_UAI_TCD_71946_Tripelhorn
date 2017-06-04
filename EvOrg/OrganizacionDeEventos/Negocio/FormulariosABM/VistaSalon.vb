Public Class VistaSalon
    Property Nombre As String
    Property Capacidad As Integer
    Property Email As String
    Property Telefono As Integer
    Property Precio As Decimal
    Sub New()

    End Sub

    Sub New(pNombre As String, pCapacidad As Integer, pEmail As String, pTelefono As Integer, pPrecio As Decimal)
        Nombre = pNombre
        Capacidad = pCapacidad
        Email = pEmail
        Telefono = pTelefono
        Precio = pPrecio
    End Sub
End Class
