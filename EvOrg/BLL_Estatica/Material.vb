Public Class Material
#Region "Propiedades"
    Property Id As Integer
    Property Nombre As String
    Property Cantidad As Integer
#End Region

#Region "Constructores"
    Sub New()

    End Sub

    Sub New(pId As Integer, pNombre As String)
        Me.Id = pId
        Me.Nombre = pNombre
    End Sub

    Sub New(pId As Integer, pNombre As String, pCantidad As Integer)
        Me.Id = pId
        Me.Nombre = pNombre
        Me.Cantidad = pCantidad
    End Sub
#End Region
End Class
