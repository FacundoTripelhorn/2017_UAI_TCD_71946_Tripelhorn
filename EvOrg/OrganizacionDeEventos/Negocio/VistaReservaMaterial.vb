Public Class VistaReservaMaterial
    Property Nombre As String
    Property Cantidad As Integer
    Property FechaLimite As Date

    Sub New()

    End Sub

    Sub New(pNombre As String, pCantidad As Integer, pFechaLimite As Date)
        Nombre = pNombre
        Cantidad = pCantidad
        FechaLimite = pFechaLimite
    End Sub
End Class
