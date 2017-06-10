Imports System.ComponentModel
Imports System.Reflection
Imports BLL_Dinamica
Imports BLL_Estatica
Imports OrganizacionDeEventos

Public Class VerMateriales
    Property CallerForm As Form
    Dim vMaterial As Material
    Dim vMaterialDinamico As New MaterialDinamico

    Private Sub VerMateriales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Actualizar()
    End Sub

    Private Sub Actualizar()
        Try
            GrillaMateriales.DataSource = Nothing
            GrillaMateriales.DataSource = vMaterialDinamico.ConsultaTodo()
            GrillaMateriales.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AceptarBtn_Click(sender As Object, e As EventArgs) Handles AceptarBtn.Click
        vMaterial = DirectCast(GrillaMateriales.SelectedRows(0).DataBoundItem, Material)
        CType(CallerForm, ReservarMaterial).vMaterial = vMaterial
        CType(CallerForm, ReservarMaterial).MaterialTxt.Text = vMaterial.Nombre
        Me.Close()
    End Sub
End Class