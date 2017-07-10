Public Class Material
    Property Id As Integer
    Property Nombre As String
    Property Cantidad As Integer
    Property Precio As Decimal
    Property FechaDesde As Date
    Property FechaHasta As Date

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

    Sub New(pId As Integer, pNombre As String, pCantidad As Integer, pPrecio As Decimal, pFechaDesde As Date, pFechaHasta As Date)
        Me.Id = pId
        Me.Nombre = pNombre
        Me.Cantidad = pCantidad
        Me.Precio = pPrecio
        Me.FechaDesde = pFechaDesde
        Me.FechaHasta = pFechaHasta
    End Sub

    Sub New(pId As Integer, pNombre As String, pCantidad As Integer, pFechaDesde As Date, pFechaHasta As Date)
        Me.Id = pId
        Me.Nombre = pNombre
        Me.Cantidad = pCantidad
        Me.FechaDesde = pFechaDesde
        Me.FechaHasta = pFechaHasta
    End Sub
End Class
