Public Class VistaMaterial
    Property Id As Integer
    Property Nombre As String
    Property Cantidad As Integer
    Property Precio As Decimal

    Sub New()

    End Sub

    Sub New(pId As Integer, pNombre As String, pCantidad As Integer, pPrecio As Decimal)
        Me.Id = pId
        Me.Nombre = pNombre
        Me.Cantidad = pCantidad
        Me.Precio = pPrecio
    End Sub
End Class
