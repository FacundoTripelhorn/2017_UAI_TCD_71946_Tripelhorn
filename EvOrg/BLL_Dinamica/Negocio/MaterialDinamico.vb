﻿Imports DAL
Imports DAL_ABMC
Imports BLL_Estatica
Public Class MaterialDinamico
    Implements IABMC

    Property MaterialDatos As MaterialDatos

    Sub New()
        Me.MaterialDatos = New MaterialDatos
    End Sub

    Public Sub Alta(Optional pObjeto As Object = Nothing) Implements IABMC.Alta
        Me.MaterialDatos.Alta(pObjeto)
    End Sub

    Public Sub Baja(Optional pObjeto As Object = Nothing) Implements IABMC.Baja
        Me.MaterialDatos.Baja(pObjeto)
    End Sub

    Public Sub Modificacion(Optional pObjeto As Object = Nothing) Implements IABMC.Modificacion
        Me.MaterialDatos.Modificacion(pObjeto)
    End Sub

    Public Function ConsultaTodo() As List(Of Object) Implements IABMC.ConsultaTodo
        Return Me.MaterialDatos.ConsultaTodo()
    End Function
End Class