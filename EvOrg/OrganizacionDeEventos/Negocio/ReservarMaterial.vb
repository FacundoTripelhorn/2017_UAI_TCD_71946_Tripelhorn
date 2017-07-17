Imports BLL_Dinamica
Imports BLL_Estatica
Imports OrganizacionDeEventos

Public Class ReservarMaterial
    Implements IObservador
    Dim vTraductor As Traductor = Traductor.GetInstance
    Dim vEvento As Evento
    Dim vEventoDinamico As New EventoDinamico
    Property vMaterial As Material
    Dim vMaterialDinamico As New MaterialDinamico
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
        If Not pEvento Is Nothing Then
            vEvento = pEvento
            vFlag = True
        End If
    End Sub

    Private Sub ReservarMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vTraductor.Registrar(Me)
        CargarEventos()

        If Not vEvento Is Nothing Then
            CargarMateriales()
            For Each Evento As Evento In EventoCombo.Items
                If vEvento.Id = Evento.Id Then
                    EventoCombo.SelectedItem = Evento
                    EventoCombo.Enabled = False
                End If
            Next
        End If
        Actualizar()
        ActualizarObservador(Me)
    End Sub

    Private Sub CargarMateriales()
        Try
            GrillaMateriales.DataSource = vEvento.ListaMateriales
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CargarEventos()
        For Each Evento As Evento In vEventoDinamico.ConsultaTodo
            EventoCombo.Items.Add(Evento)
        Next
    End Sub

    Private Sub ActualizarEvento()
        For Each Evento As Evento In vEventoDinamico.ConsultaTodo
            If Evento.Id = vEvento.Id Then
                vEvento = Evento
            End If
        Next
    End Sub

    Private Sub Actualizar()
        Try
            Dim vLista As New List(Of VistaReservaMaterial)
            ActualizarEvento()
            For Each Material As Material In vEvento.ListaMateriales
                vLista.Add(New VistaReservaMaterial(Material.Nombre, Material.Cantidad, Material.FechaDesde))
            Next
            GrillaMateriales.DataSource = Nothing
            GrillaMateriales.DataSource = vLista
            GrillaMateriales.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            ActualizarObservador(GrillaMateriales)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BuscarMaterial_Click(sender As Object, e As EventArgs) Handles BuscarMaterialBtn.Click
        Dim VerMateriales As New VerMateriales
        VerMateriales.CallerForm = Me
        VerMateriales.Show()
    End Sub

    Private Sub VerDisponibilidad_Click(sender As Object, e As EventArgs) Handles VerDisponibilidadBtn.Click
        Dim Disponibilidad As New DisponibilidadMateriales
        Disponibilidad.Show()
    End Sub

    Private Sub TerminarBtn_Click(sender As Object, e As EventArgs) Handles TerminarBtn.Click
        Me.Close()
    End Sub

    Private Sub AgregarBtn_Click(sender As Object, e As EventArgs) Handles AgregarBtn.Click
        If IdTxt.Text <> "" And MaterialTxt.Text <> "" And CantidadNumeric.Value <> 0 And FechaLimiteDTP.Value.Date <> Date.Today.Date Then
            Dim Material As New Material
            If vMaterial Is Nothing Then vMaterial = New Material
            vMaterial.Id = IdTxt.Text
            vMaterial.Nombre = MaterialTxt.Text
            vMaterial.Cantidad = CantidadNumeric.Value
            vMaterial.FechaDesde = FechaLimiteDTP.Value
            vMaterial.FechaHasta = vEvento.Fecha
            If Not vFlag Then
                vEventoDinamico.ReservarMaterial(vEvento, vMaterial)
            Else
                vEvento.ListaMateriales.Add(vMaterial)
            End If
            Actualizar()
        Else
            MessageBox.Show(vTraductor.Traducir("Ingrese los datos del material a reservar"), "EvOrg")
        End If
    End Sub

    Private Sub EventoCombo_SelectedValueChanged(sender As Object, e As EventArgs) Handles EventoCombo.SelectedValueChanged
        vEvento = EventoCombo.SelectedItem
        CargarMateriales
        Actualizar()
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