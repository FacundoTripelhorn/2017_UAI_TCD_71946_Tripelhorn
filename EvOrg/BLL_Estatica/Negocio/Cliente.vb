Public Class Cliente
    Property DNI As Integer
    Property Nombre As String
    Property Apellido As String
    Property Telefono As Integer
    Property Email As String

    Sub New()

    End Sub

    Sub New(pDNI As Integer, pNombre As String, pApellido As String, pTelefono As Integer, pEmail As String)
        DNI = pDNI
        Nombre = pNombre
        Apellido = pApellido
        Telefono = pTelefono
        Email = pEmail
    End Sub

End Class
