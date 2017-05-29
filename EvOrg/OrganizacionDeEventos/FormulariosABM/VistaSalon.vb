Public Class VistaSalon
    Property Nombre As String
    Property Capacidad As Integer
    Property Email As String
    Property Telefono As Integer

    Sub New()

    End Sub

    Sub New(pNombre As String, pCapacidad As Integer, pEmail As String, pTelefono As Integer)
        Nombre = pNombre
        Capacidad = pCapacidad
        Email = pEmail
        Telefono = pTelefono
    End Sub
End Class
