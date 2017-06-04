Public Class VistaPasoTE
    Property Descripcion As String
    Property Dias As Integer
    Property Prioridad As String

    Sub New()

    End Sub

    Sub New(pDescripcion As String, pDias As Integer, pPrioridad As String)
        Descripcion = pDescripcion
        Dias = pDias
        Prioridad = pPrioridad
    End Sub
End Class
