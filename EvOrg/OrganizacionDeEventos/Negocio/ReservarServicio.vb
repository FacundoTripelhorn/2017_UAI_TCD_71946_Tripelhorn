Imports OrganizacionDeEventos
Imports BLL_Estatica
Imports BLL_Dinamica
Public Class ReservarServicio
    Implements IObservador
    Dim vTraductor As Traductor = Traductor.GetInstance
    Dim vEvento As Evento
    Dim vEventoDinamico As New EventoDinamico
    Dim vServicio As Servicio
    Dim vServicioDinamico As New ServicioDinamico
    Dim vFlag As Boolean = False

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Sub New(ByRef pEvento As Evento)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        vEvento = pEvento
        EventoCombo.SelectedItem() = vEvento
        EventoCombo.Enabled = False
        vFlag = True
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

    Private Sub ReservarServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vTraductor.Registrar(Me)
        CargarEventos()
        ActualizarObservador(Me)
    End Sub

    Private Sub CargarEventos()
        For Each Evento As Evento In vEventoDinamico.ConsultaTodo
            EventoCombo.Items.Add(Evento)
        Next
    End Sub

    Private Sub CargarServicios()
        For Each Servicio As Servicio In vServicioDinamico.ConsultaTodo
            ServicioCombo.Items.Add(Servicio)
        Next
    End Sub

    Private Sub EventoCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles EventoCombo.SelectedIndexChanged
        vEvento = EventoCombo.SelectedItem
        TipoEventoTxt.Text = vEvento.Tipo.Nombre
        FechaDTP.Value = vEvento.Fecha
        CantidadTxt.Text = vEvento.CantidadInvitados
        SalonTxt.Text = vEvento.Salon.Nombre
    End Sub

    Private Sub ServicioCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ServicioCombo.SelectedIndexChanged
        vServicio = ServicioCombo.SelectedItem
        NombreTxt.Text = vServicio.Nombre
        TelefonoTxt.Text = vServicio.Telefono
        PrecioTxt.Text = vServicio.Precio
        ObservacionTxt.Text = vServicio.Observacion
        DireccionTxt.Text = vServicio.Direccion.Calle & " " & vServicio.Direccion.Numero
        EmailTxt.Text = vServicio.Email
    End Sub

    Private Sub AgregarBtn_Click(sender As Object, e As EventArgs) Handles AgregarBtn.Click
        MsgBox("Se agrega un servicio al evento seleccionado")
    End Sub

    Private Sub BorrarBtn_Click(sender As Object, e As EventArgs) Handles BorrarBtn.Click
        MsgBox("Se borra un servicio de la lista de servicios reservados")
    End Sub
End Class