﻿Imports OrganizacionDeEventos

Public Class TareasDelDia
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

    Private Sub TareasDelDia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vTraductor.Registrar(Me)
        ActualizarObservador(Me)
        TareasDelDiaLbl.Text = TareasDelDiaLbl.Text & " " & Today.Day & "/" & Today.Month & "/" & Today.Year
    End Sub

    Private Sub TareaNuevaBtn_Click(sender As Object, e As EventArgs) Handles TareaNuevaBtn.Click
        MsgBox("Agrega una tarea a la lista")
    End Sub

    Private Sub TareaTerminadaBtn_Click(sender As Object, e As EventArgs) Handles TareaTerminadaBtn.Click
        MsgBox("Elimina una tarea")
    End Sub
End Class