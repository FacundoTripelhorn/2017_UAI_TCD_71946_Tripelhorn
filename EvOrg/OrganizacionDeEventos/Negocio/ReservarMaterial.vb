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

    Sub New(Optional pEvento As Evento = Nothing)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If Not pEvento Is Nothing Then
            vEvento = pEvento
        End If
    End Sub

    Private Sub ReservarMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vTraductor.Registrar(Me)
        CargarEventos()
        For Each Evento As String In EventoCombo.Items
            If vEvento.Nombre = Evento Then
                EventoCombo.SelectedItem = Evento
                EventoCombo.Enabled = False
            End If
        Next
        Actualizar()
        ActualizarObservador(Me)
    End Sub

    Private Sub CargarEventos()
        For Each Evento As Evento In vEventoDinamico.ConsultaTodo
            EventoCombo.Items.Add(Evento.Nombre)
        Next
    End Sub

    Private Sub Actualizar()
        Try
            Dim vLista As New List(Of Material)
            For Each Material As Material In vEvento.ListaMateriales
                vLista.Add(Material)
            Next
            GrillaMateriales.DataSource = Nothing
            GrillaMateriales.DataSource = vLista
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
        ListaMateriales.Show()
    End Sub

    Private Sub TerminarBtn_Click(sender As Object, e As EventArgs) Handles TerminarBtn.Click
        Me.Close()
    End Sub

    Private Sub AgregarBtn_Click(sender As Object, e As EventArgs) Handles AgregarBtn.Click
        vEvento.ListaMateriales.Add(vMaterial)
        Actualizar()
    End Sub

    Private Sub EventoCombo_SelectedValueChanged(sender As Object, e As EventArgs) Handles EventoCombo.SelectedValueChanged
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