﻿Public Class Paso
    Property Id As Integer
    Property Descripcion As String
    Property Fecha As Date
    Property Prioridad As String
    Property Tipo As String
    ' Property Evento As Evento

    Sub New()

    End Sub

    Sub New(pId As Integer, pDescripcion As String, Optional pFecha As Date = Nothing, Optional pPrioridad As String = Nothing, Optional pTipo As String = Nothing)
        Id = pId
        Descripcion = pDescripcion
        Fecha = pFecha
        Prioridad = pPrioridad
        Tipo = pTipo
    End Sub

    Sub New(pDescripcion As String, Optional pFecha As Date = Nothing, Optional pPrioridad As String = Nothing, Optional pTipo As String = Nothing)
        Descripcion = pDescripcion
        Fecha = pFecha
        Prioridad = pPrioridad
        Tipo = pTipo
    End Sub
End Class
