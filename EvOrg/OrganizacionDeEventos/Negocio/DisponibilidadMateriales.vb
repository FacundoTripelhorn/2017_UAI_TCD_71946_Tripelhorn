Imports OrganizacionDeEventos
Imports BLL_Dinamica
Imports BLL_Estatica
Public Class DisponibilidadMateriales
    Implements IObservador
    Dim vTraductor As Traductor = Traductor.GetInstance
    Dim vMaterial As Material
    Dim vMaterialDinamico As New MaterialDinamico
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

    Private Sub ListaMateriales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vTraductor.Registrar(Me)
        GrillaMateriales.DataSource = GetMateriales()
        GrillaMateriales.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        ActualizarObservador(Me)
    End Sub

    Private Function GetMateriales() As List(Of VistaMaterial)
        Dim vLista As List(Of Material) = vMaterialDinamico.ConsultaReservas
        Dim vListaMateriales As List(Of Object) = vMaterialDinamico.ConsultaTodo
        Dim vListaVista As New List(Of VistaMaterial)

        For Each material As Material In vListaMateriales
            For Each reserva As Material In vLista
                If material.Id = reserva.Id And reserva.FechaDesde < FiltroDTP.Value And reserva.FechaHasta > FiltroDTP.Value Then
                    material.Cantidad = material.Cantidad - reserva.Cantidad

                End If
            Next
            vListaVista.Add(New VistaMaterial(material.Id, material.Nombre, material.Cantidad, material.Precio))
        Next
        Return vListaVista
    End Function

    Private Sub FiltroDTP_TextChanged(sender As Object, e As EventArgs) Handles FiltroDTP.TextChanged
        GrillaMateriales.DataSource = GetMateriales()
    End Sub
End Class