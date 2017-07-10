Imports OrganizacionDeEventos
Imports BLL_Dinamica
Imports BLL_Estatica
Public Class Presupuesto
    Implements IObservador
    Dim vTraductor As Traductor = Traductor.GetInstance
    Dim vEvento As Evento
    Dim vEventoDinamico As New EventoDinamico
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

    Private Sub Presupuesto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vTraductor.Registrar(Me)
        ActualizarObservador(Me)
    End Sub

    Private Sub EventoCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles EventoCombo.SelectedIndexChanged
        vEvento = EventoCombo.SelectedItem
        TipoEventoTxt.Text = vEvento.Tipo.Nombre
        FechaDTP.Value = vEvento.Fecha
        CantidadTxt.Text = vEvento.CantidadInvitados
        SalonTxt.Text = vEvento.Salon.Nombre
        ClienteTxt.Text = vEvento.Cliente.Nombre
        CargarMateriales()
        TotalSalonTxt.Text = vEvento.Salon.Precio
        TotalMaterialesTxt.Text = GetTotalMateriales()
        TotalServiciosTxt.Text = GetTotalServicios()
        TotalTxt.Text = TotalSalonTxt.Text + TotalMaterialesTxt.Text + TotalServiciosTxt.Text + 500
    End Sub

    Private Sub CargarEventos()
        For Each Evento As Evento In vEventoDinamico.ConsultaTodo
            EventoCombo.Items.Add(Evento)
        Next
    End Sub

    Private Sub CargarMateriales()
        Dim vLista As New List(Of VistaMaterial)
        For Each Material As Material In vEvento.ListaMateriales
            vLista.Add(New VistaMaterial(Material.Id, Material.Nombre, Material.Cantidad, Material.Precio))
        Next
        GrillaMateriales.DataSource = Nothing
        GrillaMateriales.DataSource = vLista
    End Sub

    Private Sub CargarServicios()
        Dim vLista As New List(Of VistaServicio)
        For Each Servicio As Servicio In vEvento.ListaServicios
            vLista.Add(New VistaServicio(Servicio.Id, Servicio.Telefono, Servicio.Email, Servicio.Precio))
        Next
        GrillaServicios.DataSource = Nothing
        GrillaServicios.DataSource = vLista
    End Sub

    Private Function GetTotalMateriales() As Decimal
        Dim vTotal As Decimal
        For Each Material As Material In vEvento.ListaMateriales
            vTotal += (Material.Cantidad * Material.Precio)
        Next
        Return vTotal
    End Function

    Private Function GetTotalServicios() As Decimal
        Dim vTotal As Decimal
        For Each Servicio As Servicio In vEvento.ListaServicios
            vTotal += Servicio.Precio
        Next
        Return vTotal
    End Function

    Private Sub GuardarBtn_Click(sender As Object, e As EventArgs) Handles GuardarBtn.Click
        MsgBox("Crea un pdf con el presupuesto y lo guarda")
    End Sub

    Private Sub EnviarBtn_Click(sender As Object, e As EventArgs) Handles EnviarBtn.Click
        MsgBox("Crea un pdf con el presupuesto y se lo manda al cliente por mail")
    End Sub

    Private Sub ImprimirBtn_Click(sender As Object, e As EventArgs) Handles ImprimirBtn.Click
        MsgBox("Crea un pdf con el presupuesto y lo imprime")
    End Sub
End Class