Public Class Material
    Property Id As Integer
    Property Nombre As String
    Property Cantidad As Integer
    Property Precio As Decimal
    Property Fecha As Date

    Sub New()

    End Sub

    Sub New(pId As Integer, pNombre As String)
        Me.Id = pId
        Me.Nombre = pNombre
    End Sub

    Sub New(pId As Integer, pNombre As String, pCantidad As Integer, pPrecio As Decimal)
        Me.Id = pId
        Me.Nombre = pNombre
        Me.Cantidad = pCantidad
        Me.Precio = pPrecio
    End Sub

    Sub New(pId As Integer, pNombre As String, pCantidad As Integer, pPrecio As Decimal, pFecha As Date)
        Me.Id = pId
        Me.Nombre = pNombre
        Me.Cantidad = pCantidad
        Me.Precio = pPrecio
        Me.Fecha = pFecha
    End Sub

    Sub New(pId As Integer, pNombre As String, pCantidad As Integer, pFecha As Date)
        Me.Id = pId
        Me.Nombre = pNombre
        Me.Cantidad = pCantidad
        Me.Fecha = pFecha
    End Sub
End Class
