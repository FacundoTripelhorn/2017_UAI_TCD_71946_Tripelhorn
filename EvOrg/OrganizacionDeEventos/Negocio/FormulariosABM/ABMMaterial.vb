Imports BLL_Dinamica
Imports BLL_Estatica
Imports System.Text.RegularExpressions
Imports OrganizacionDeEventos

Public Class ABMMaterial
    Implements IObservador
    Dim vTraductor As Traductor = Traductor.GetInstance
    Dim vMaterial As Material
    Dim vMaterialDinamico As New MaterialDinamico

    Private Sub ABMMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vTraductor.Registrar(Me)
        Actualizar()
        ActualizarObservador(Me)
    End Sub

    Private Sub Actualizar()
        Try
            GrillaMateriales.DataSource = Nothing
            GrillaMateriales.DataSource = vMaterialDinamico.ConsultaTodo()
            GrillaMateriales.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            ActualizarObservador(GrillaMateriales)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Limpiar()
        IdTxt.Text = ""
        NombreTxt.Text = ""
        CantidadNumeric.Value = 0
        PrecioTxt.Text = ""
    End Sub

    Private Sub BtnAlta_Click(sender As Object, e As EventArgs) Handles AltaBtn.Click
        Try
            If Not (IdTxt.Text = "" And NombreTxt.Text = "" And CantidadNumeric.Value = 0 And PrecioTxt.Text = "") Then
                vMaterial = New Material(IdTxt.Text, NombreTxt.Text, CantidadNumeric.Value, PrecioTxt.Text)
                vMaterialDinamico.Alta(vMaterial)
                Limpiar()
                Actualizar()
            Else
                Throw New Exception("Debe ingresar un id, un nombre de material y una cantidad")
            End If
        Catch ex As Exception
            MessageBox.Show(vTraductor.Traducir(ex.Message), "EvOrg", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BtnBaja_Click(sender As Object, e As EventArgs) Handles BajaBtn.Click
        vMaterial = DirectCast(GrillaMateriales.SelectedRows(0).DataBoundItem, Material)
        vMaterialDinamico.Baja(vMaterial)
        Limpiar()
        Actualizar()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles ModificacionBtn.Click
        vMaterial = DirectCast(GrillaMateriales.SelectedRows(0).DataBoundItem, Material)
        vMaterial.Nombre = NombreTxt.Text
        vMaterial.Cantidad = CantidadNumeric.Value
        vMaterial.Precio = PrecioTxt.Text
        vMaterialDinamico.Modificacion(vMaterial)
        Limpiar()
        Actualizar()
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

    Private Sub IdTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles IdTxt.KeyPress
        If Not (Regex.IsMatch(e.KeyChar, "[0-9\b]")) Then e.KeyChar = Nothing
    End Sub

    Private Sub PrecioTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PrecioTxt.KeyPress
        If Not (Regex.IsMatch(e.KeyChar, "[0-9\b,]")) Then e.KeyChar = Nothing
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
