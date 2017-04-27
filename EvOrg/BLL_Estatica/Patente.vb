Public Class Patente
    Inherits PatenteAbstracta
    Property Formulario As String
    Sub New()

    End Sub

    Sub New(pId As Integer, pNombre As String, pFormulario As String, Optional pPadre As Integer = 1)
        Id = pId
        Nombre = pNombre
        Formulario = pFormulario
        Padre = pPadre
    End Sub
End Class
