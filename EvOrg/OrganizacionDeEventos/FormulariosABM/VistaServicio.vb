Public Class VistaServicio
    Property Nombre As String
    Property Email As String
    Property Telefono As Integer

    Sub New()

    End Sub

    Sub New(pNombre As String, pTelefono As Integer, pEmail As String)
        Nombre = pNombre
        Email = pEmail
        Telefono = pTelefono
    End Sub
End Class
