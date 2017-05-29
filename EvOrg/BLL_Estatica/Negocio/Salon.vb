Public Class Salon
    Property Id As Integer
    Property Nombre As String
    Property Capacidad As Integer
    Property Email As String
    Property Telefono As Integer
    Property Direccion As Direccion
    Property Descripcion As String

    Sub New()

    End Sub

    Sub New(pNombre As String, pCapacidad As Integer, pEmail As String, pTelefono As Integer, pDireccion As Direccion, pDescripcion As String)
        Nombre = pNombre
        Capacidad = pCapacidad
        Email = pEmail
        Telefono = pTelefono
        Direccion = pDireccion
        Descripcion = pDescripcion
    End Sub

    Sub New(pId As Integer, pNombre As String, pCapacidad As Integer, pEmail As String, pTelefono As Integer, pDireccion As Direccion, pDescripcion As String)
        Id = pId
        Nombre = pNombre
        Capacidad = pCapacidad
        Email = pEmail
        Telefono = pTelefono
        Direccion = pDireccion
        Descripcion = pDescripcion
    End Sub
End Class
