Public Class VistaPaso
    Property Descripcion As String
    Property Fecha As Date
    Property Prioridad As String
    Property Tipo As String

    Sub New()

    End Sub

    Sub New(pDescripcion As String, Optional pFecha As Date = Nothing, Optional pPrioridad As String = Nothing, Optional pTipo As String = Nothing)
        Descripcion = pDescripcion
        Fecha = pFecha
        Prioridad = pPrioridad
        Tipo = pTipo
    End Sub
End Class
