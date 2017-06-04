Public Class Salon
    Property Id As Integer
    Property Nombre As String
    Property Capacidad As Integer
    Property Email As String
    Property Telefono As Integer
    Property Direccion As Direccion
    Property Descripcion As String
    Property Precio As Decimal

    Sub New()

    End Sub

    Sub New(pNombre As String, pCapacidad As Integer, pEmail As String, pTelefono As Integer, pDireccion As Direccion, pDescripcion As String, pPrecio As Decimal)
        Nombre = pNombre
        Capacidad = pCapacidad
        Email = pEmail
        Telefono = pTelefono
        Direccion = pDireccion
        Descripcion = pDescripcion
        Precio = pPrecio
    End Sub

    Sub New(pId As Integer, pNombre As String, pCapacidad As Integer, pEmail As String, pTelefono As Integer, pDireccion As Direccion, pDescripcion As String, pPrecio As Decimal)
        Id = pId
        Nombre = pNombre
        Capacidad = pCapacidad
        Email = pEmail
        Telefono = pTelefono
        Direccion = pDireccion
        Descripcion = pDescripcion
        Precio = pPrecio
    End Sub
End Class
