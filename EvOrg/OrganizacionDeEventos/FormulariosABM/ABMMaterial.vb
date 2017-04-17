Imports BLL_Dinamica
Imports BLL_Estatica
Public Class ABMMaterial
    Dim Material As Material
    Dim MaterialD As New MaterialDinamico

    Private Sub ABMMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GrillaMateriales.DataSource = MaterialD.ConsultaTodo()
    End Sub

    Private Sub Limpiar()
        IdTxt.Text = ""
        NombreTxt.Text = ""
        CantidadNumeric.Value = 0
    End Sub

    Private Sub BtnAlta_Click(sender As Object, e As EventArgs) Handles AltaBtn.Click
        Material = New Material(IdTxt.Text, NombreTxt.Text, CantidadNumeric.Value)
        MaterialD.Alta(Material)
        Limpiar()
        GrillaMateriales.DataSource = MaterialD.ConsultaTodo()
    End Sub

    Private Sub BtnBaja_Click(sender As Object, e As EventArgs) Handles BajaBtn.Click
        Material = DirectCast(GrillaMateriales.SelectedRows(0).DataBoundItem, Material)
        MaterialD.Baja(Material)
        Limpiar()
        GrillaMateriales.DataSource = MaterialD.ConsultaTodo()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles ModificacionBtn.Click
        Material = DirectCast(GrillaMateriales.SelectedRows(0).DataBoundItem, Material)
        Material.Nombre = NombreTxt.Text
        Material.Cantidad = CantidadNumeric.Value
        MaterialD.Modificacion(Material)
        Limpiar()
        GrillaMateriales.DataSource = MaterialD.ConsultaTodo()
    End Sub

    Private Sub GrillaMateriales_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaMateriales.CellEnter

    End Sub

    Private Sub GrillaMateriales_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaMateriales.CellClick
        Try
            Dim M As Material = DirectCast(GrillaMateriales.SelectedRows(0).DataBoundItem, Material)
            IdTxt.Text = M.Id
            NombreTxt.Text = M.Nombre
            CantidadNumeric.Value = M.Cantidad
        Catch ex As Exception
        End Try
    End Sub
End Class
