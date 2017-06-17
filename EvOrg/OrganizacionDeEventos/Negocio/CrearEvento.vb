Imports BLL_Dinamica
Imports BLL_Estatica
Imports OrganizacionDeEventos

Public Class CrearEvento
    Implements IObservador
    Dim vTraductor As Traductor = Traductor.GetInstance
    Dim vEvento As New Evento
    Dim vEventoDinamico As EventoDinamico

    Private Sub SeleccionarSalonBtn_Click(sender As Object, e As EventArgs) Handles SeleccionarSalonBtn.Click
        SeleccionarSalon.Show()
    End Sub

    Private Sub VerPasosBtn_Click(sender As Object, e As EventArgs) Handles VerPasosBtn.Click
        Dim Pasos As New ABMPaso(vEvento)
        Pasos.Show()
    End Sub

    Private Sub ReservarMaterialBtn_Click(sender As Object, e As EventArgs) Handles ReservarMaterialBtn.Click
        Dim ReservarMaterial As New ReservarMaterial(vEvento)
        ReservarMaterial.Show()
    End Sub

    Private Sub ReservarServicioBtn_Click(sender As Object, e As EventArgs) Handles ReservarServicioBtn.Click
        ReservarServicio.Show()
    End Sub

    Private Sub CrearEvento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vTraductor.Registrar(Me)
        ActualizarObservador(Me)
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