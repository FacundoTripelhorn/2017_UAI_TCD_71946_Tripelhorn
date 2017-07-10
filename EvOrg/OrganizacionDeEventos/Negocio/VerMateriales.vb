Imports System.ComponentModel
Imports System.Reflection
Imports BLL_Dinamica
Imports BLL_Estatica
Imports OrganizacionDeEventos

Public Class VerMateriales
    Implements IObservador
    Dim vTraductor As Traductor = Traductor.GetInstance
    Property CallerForm As Form
    Dim vMaterial As Material
    Dim vMaterialDinamico As New MaterialDinamico

    Private Sub VerMateriales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vTraductor.Registrar(Me)
        Actualizar()
        ActualizarObservador(Me)
    End Sub

    Private Sub Actualizar()
        Try
            Dim vLista As New List(Of VistaMaterial)
            For Each Material As Material In vMaterialDinamico.ConsultaTodo
                vLista.Add(New VistaMaterial(Material.Id, Material.Nombre, Material.Cantidad, Material.Precio))
            Next
            GrillaMateriales.DataSource = Nothing
            GrillaMateriales.DataSource = vLista
            GrillaMateriales.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            ActualizarObservador(GrillaMateriales)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AceptarBtn_Click(sender As Object, e As EventArgs) Handles AceptarBtn.Click
        vMaterial = DirectCast(GrillaMateriales.SelectedRows(0).DataBoundItem, Material)
        CType(CallerForm, ReservarMaterial).vMaterial = vMaterial
        CType(CallerForm, ReservarMaterial).IdTxt.Text = vMaterial.Id
        CType(CallerForm, ReservarMaterial).MaterialTxt.Text = vMaterial.Nombre
        CType(CallerForm, ReservarMaterial).CantidadNumeric.Maximum = vMaterial.Cantidad
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

    Private Sub CancelarBtn_Click(sender As Object, e As EventArgs) Handles CancelarBtn.Click
        Me.Close()
    End Sub
End Class