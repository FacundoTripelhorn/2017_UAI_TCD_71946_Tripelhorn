Imports BLL_Dinamica
Imports BLL_Estatica
Imports OrganizacionDeEventos

Public Class OrganizarEvento
    Implements IObservador
    Dim vTraductor As Traductor = Traductor.GetInstance
    Dim vEvento As New Evento
    Dim vEventoDinamico As New EventoDinamico
    Dim vTipoDinamico As New TipoEventoDinamico
    Dim vCliente As New Cliente
    Dim vClienteDinamico As New ClienteDinamico


    Private Sub SeleccionarSalonBtn_Click(sender As Object, e As EventArgs) Handles SeleccionarSalonBtn.Click
        Dim SeleccionarSalon As New SeleccionarSalon(vEvento)
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
        CargarTiposDeEvento()
        ActualizarObservador(Me)
    End Sub

    Private Sub CargarTiposDeEvento()
        For Each TipoEvento As TipoEvento In vTipoDinamico.ConsultaTodo
            TipoEventoCombo.Items.Add(TipoEvento)
        Next
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

    Private Sub TipoEventoCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TipoEventoCombo.SelectedIndexChanged
        vEvento.Tipo = TipoEventoCombo.SelectedItem
    End Sub

    Private Sub BuscarClienteBtn_Click(sender As Object, e As EventArgs) Handles BuscarClienteBtn.Click
        If vClienteDinamico.CheckCliente(DNITxt.Text) Then
            vCliente = vClienteDinamico.GetCliente(DNITxt.Text)
            NombreTxt.Text = vCliente.Nombre
            ApellidoTxt.Text = vCliente.Apellido
            TelefonoTxt.Text = vCliente.Telefono
            EmailTxt.Text = vCliente.Email
            vEvento.Cliente = vCliente
        End If
    End Sub

    Private Sub NombreEventoTxt_TextChanged(sender As Object, e As EventArgs) Handles NombreEventoTxt.TextChanged
        vEvento.Nombre = NombreEventoTxt.Text
    End Sub

    Private Sub LocalidadTxt_TextChanged(sender As Object, e As EventArgs) Handles LocalidadTxt.TextChanged
        vEvento.Localidad = LocalidadTxt.Text
    End Sub

    Private Sub GuardarBtn_Click(sender As Object, e As EventArgs) Handles GuardarBtn.Click
        vEvento.Nombre = NombreEventoTxt.Text
        vEvento.Fecha = FechaDTP.Value
        vEvento.CantidadInvitados = CantidadNumeric.Value
        vEvento.Tipo = TipoEventoCombo.SelectedItem
        vEventoDinamico.Alta(vEvento)
    End Sub

    Private Sub CancelarBtn_Click(sender As Object, e As EventArgs) Handles CancelarBtn.Click
        Me.Close()
    End Sub
End Class