Imports System.ComponentModel
Imports System.Reflection
Imports OrganizacionDeEventos

Public Class NuevaPatente
    Implements IObservador
    Dim vTraductor As Traductor = Traductor.GetInstance
    Private Sub NuevaPatente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vTraductor.Registrar(me)
        Dim vAsm As Assembly = Assembly.GetExecutingAssembly
        For Each vTipo As Type In vAsm.GetTypes
            If vTipo.IsSubclassOf(GetType(Form)) Then
                Me.FormularioCombo.Items.Add(vTipo.Name)
            End If
        Next
        ActualizarObservador(Me)
    End Sub

    Public Function Nombre() As String
        Return NombreTxt.Text
    End Function

    Public Function Formulario() As String
        Return FormularioCombo.SelectedItem
    End Function

    Private Sub AceptarBtn_Click(sender As Object, e As EventArgs) Handles AceptarBtn.Click
        Me.Close()
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
End Class