﻿Imports OrganizacionDeEventos

Public Class VerEventos
    Implements IObservador
    Dim vTraductor As Traductor = Traductor.GetInstance

    Public Sub ActualizarObservador(Optional pControl As Control = Nothing) Implements IObservador.ActualizarObservador
        For Each vControl As Control In pControl.Controls
            Try
                vControl.Text = vTraductor.IdiomaSeleccionado.Diccionario.Item(vControl.Tag.ToString)
            Catch ex As Exception
            Finally
                If vControl.Controls.Count > 0 Then
                    ActualizarObservador(vControl)
                End If
                If TypeOf vControl Is DataGridView Then
                    For Each vColumna As DataGridViewColumn In DirectCast(vControl, DataGridView).Columns
                        Try
                            vColumna.HeaderText = vTraductor.IdiomaSeleccionado.Diccionario.Item(vColumna.Name)
                        Catch ex As Exception

                        End Try
                    Next
                End If
            End Try
        Next
    End Sub

    Private Sub VerEventos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vTraductor.Registrar(Me)
        ActualizarObservador(Me)
    End Sub

    Private Sub BorrarEventoBtn_Click(sender As Object, e As EventArgs) Handles BorrarEventoBtn.Click
        MsgBox("Borra un evento de la base de datos")
    End Sub

    Private Sub ModificarEventoBtn_Click(sender As Object, e As EventArgs) Handles ModificarEventoBtn.Click
        MsgBox("Modifica un evento de la base de datos")
    End Sub
End Class