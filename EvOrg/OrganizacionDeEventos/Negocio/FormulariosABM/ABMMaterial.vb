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

    Private Sub Limpiar()
        IdTxt.Text = ""
        NombreTxt.Text = ""
        CantidadNumeric.Value = 0
        PrecioTxt.Text = ""
    End Sub

    Private Sub BtnAlta_Click(sender As Object, e As EventArgs) Handles AltaBtn.Click
        Try
            If IdTxt.Text <> "" And NombreTxt.Text <> "" And CantidadNumeric.Value <> 0 And PrecioTxt.Text <> "" Then
                vMaterial = New Material(IdTxt.Text, NombreTxt.Text, CantidadNumeric.Value, Decimal.Parse(PrecioTxt.Text))
                If Not vMaterialDinamico.CheckMaterial(vMaterial.Id, vMaterial.Nombre) Then
                    vMaterialDinamico.Alta(vMaterial)
                Else
                    Throw New Exception("El nombre o el id del material ingresado ya existe")
                End If
                Limpiar()
                Actualizar()
            Else
                Throw New Exception("Debe ingresar un id, un nombre de material, una cantidad y un precio")
            End If
        Catch ex As Exception
            MessageBox.Show(vTraductor.Traducir(ex.Message), "EvOrg")
        End Try

    End Sub

    Private Sub BtnBaja_Click(sender As Object, e As EventArgs) Handles BajaBtn.Click
        Try
            If GrillaMateriales.SelectedRows.Count > 0 Then
                Dim VistaMaterial As VistaMaterial = DirectCast(GrillaMateriales.SelectedRows(0).DataBoundItem, VistaMaterial)
                For Each Material As Material In vMaterialDinamico.ConsultaTodo
                    If Material.Nombre = VistaMaterial.Nombre Then
                        vMaterial = Material
                    End If
                Next
                If vMaterialDinamico.CheckReservas(vMaterial.Id) Then
                    Dim vOpcion As Integer = MessageBox.Show(vTraductor.Traducir("El material seleccionado tiene reservas pendientes ¿Desea eliminar el material y cancelar las reservas?"), "EvOrg", MessageBoxButtons.YesNo)
                    If vOpcion = DialogResult.Yes Then
                        vMaterialDinamico.Baja(vMaterial)
                        Limpiar()
                        Actualizar()
                    End If
                Else
                    vMaterialDinamico.Baja(vMaterial)
                    Limpiar()
                    Actualizar()
                End If
            Else
                Throw New Exception("Seleccione el material que desea borrar")
            End If
        Catch ex As Exception
            MessageBox.Show(vTraductor.Traducir(ex.Message), "EvOrg")
        End Try
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles ModificacionBtn.Click


        Try
            If GrillaMateriales.SelectedRows.Count > 0 Then
                Dim VistaMaterial As VistaMaterial = DirectCast(GrillaMateriales.SelectedRows(0).DataBoundItem, VistaMaterial)
                For Each Material As Material In vMaterialDinamico.ConsultaTodo
                    If Material.Nombre = VistaMaterial.Nombre Then
                        If IdTxt.Text <> "" And NombreTxt.Text <> "" And CantidadNumeric.Value <> 0 And PrecioTxt.Text <> "" Then
                            vMaterial = Material
                            vMaterial.Nombre = NombreTxt.Text
                            vMaterial.Cantidad = CantidadNumeric.Value
                            vMaterial.Precio = PrecioTxt.Text
                        Else
                            Throw New Exception("Debe ingresar un id, un nombre de material, una cantidad y un precio")
                        End If
                    End If
                Next
                vMaterialDinamico.Modificacion(vMaterial)
                Limpiar()
                Actualizar()
            Else
                Throw New Exception("Seleccione el material que desea modificar")
            End If
        Catch ex As Exception
            MessageBox.Show(vTraductor.Traducir(ex.Message), "EvOrg")
        End Try
    End Sub

    Private Sub GrillaMateriales_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaMateriales.CellClick
        Try
            Dim M As VistaMaterial = DirectCast(GrillaMateriales.SelectedRows(0).DataBoundItem, VistaMaterial)
            IdTxt.Text = M.Id
            NombreTxt.Text = M.Nombre
            CantidadNumeric.Value = M.Cantidad
            PrecioTxt.Text = M.Precio
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

    Private Sub NombreTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NombreTxt.KeyPress
        If (Regex.IsMatch(e.KeyChar, "[0-9]")) Then e.KeyChar = Nothing
    End Sub
End Class
