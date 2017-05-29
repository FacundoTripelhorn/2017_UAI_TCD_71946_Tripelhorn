Imports BLL_Dinamica
Imports BLL_Estatica
Public Class ABMMaterial
    Dim vMaterial As Material
    Dim vMaterialDinamico As New MaterialDinamico

    Private Sub ABMMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GrillaMateriales.DataSource = Nothing
        GrillaMateriales.DataSource = vMaterialDinamico.ConsultaTodo()
    End Sub

    Private Sub Limpiar()
        IdTxt.Text = ""
        NombreTxt.Text = ""
        CantidadNumeric.Value = 0
    End Sub

    Private Sub BtnAlta_Click(sender As Object, e As EventArgs) Handles AltaBtn.Click
        If Not (IdTxt.Text = "" And NombreTxt.Text = "" And CantidadNumeric.Value = 0) Then
            vMaterial = New Material(IdTxt.Text, NombreTxt.Text, CantidadNumeric.Value)
            vMaterialDinamico.Alta(vMaterial)
            Limpiar()
            GrillaMateriales.DataSource = vMaterialDinamico.ConsultaTodo()
        Else
            MessageBox.Show("Debe ingresar un id, un nombre de material y una cantidad", "EvOrg", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub BtnBaja_Click(sender As Object, e As EventArgs) Handles BajaBtn.Click
        vMaterial = DirectCast(GrillaMateriales.SelectedRows(0).DataBoundItem, Material)
        vMaterialDinamico.Baja(vMaterial)
        Limpiar()
        GrillaMateriales.DataSource = vMaterialDinamico.ConsultaTodo()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles ModificacionBtn.Click
        vMaterial = DirectCast(GrillaMateriales.SelectedRows(0).DataBoundItem, Material)
        vMaterial.Nombre = NombreTxt.Text
        vMaterial.Cantidad = CantidadNumeric.Value
        vMaterialDinamico.Modificacion(vMaterial)
        Limpiar()
        GrillaMateriales.DataSource = vMaterialDinamico.ConsultaTodo()
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
