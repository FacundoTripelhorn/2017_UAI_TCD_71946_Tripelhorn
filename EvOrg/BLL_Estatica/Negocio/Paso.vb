Public Class Paso
    Property Id As Integer
    Property Descripcion As String
    Property Fecha As Date
    Property Prioridad As Prioridades
    Property Tipo As TipoPaso

    Public Enum Prioridades
        Baja
        Media
        Alta
    End Enum

    Public Enum TipoPaso
        Concreto
        Genérico
    End Enum

    Sub New()

    End Sub

    Sub New(pId As Integer, pDescripcion As String, Optional pFecha As Date = Nothing, Optional pPrioridad As Prioridades = Nothing, Optional pTipo As TipoPaso = Nothing)
        Id = pId
        Descripcion = pDescripcion
        Fecha = pFecha
        Prioridad = pPrioridad
        Tipo = pTipo
    End Sub
End Class
