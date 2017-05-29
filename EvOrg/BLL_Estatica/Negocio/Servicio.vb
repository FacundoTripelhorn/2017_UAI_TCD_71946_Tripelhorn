Public Class Servicio
    Property Id As Integer
    Property Nombre As String
    Property Telefono As Integer
    Property Direccion As Direccion
    Property Email As String
    Property Observacion As String

    Sub New()

    End Sub

    Sub New(pNombre As String, pTelefono As Integer, pDireccion As Direccion, pEmail As String, pObservacion As String)
        Nombre = pNombre
        Telefono = pTelefono
        Direccion = pDireccion
        Email = pEmail
        Observacion = pObservacion
    End Sub

    Sub New(pId As Integer, pNombre As String, pTelefono As Integer, pDireccion As Direccion, pEmail As String, pObservacion As String)
        Id = pId
        Nombre = pNombre
        Telefono = pTelefono
        Direccion = pDireccion
        Email = pEmail
        Observacion = pObservacion
    End Sub
End Class
