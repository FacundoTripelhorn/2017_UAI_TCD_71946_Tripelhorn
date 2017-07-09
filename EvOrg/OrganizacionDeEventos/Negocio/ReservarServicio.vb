﻿Imports OrganizacionDeEventos
Imports BLL_Estatica
Public Class ReservarServicio
    Implements IObservador
    Dim vTraductor As Traductor = Traductor.GetInstance
    Dim vEvento As Evento

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Sub New(ByRef pEvento As Evento)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        vEvento = pEvento
    End Sub

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

    Private Sub ReservarServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vTraductor.Registrar(Me)
        ActualizarObservador(Me)
    End Sub
End Class