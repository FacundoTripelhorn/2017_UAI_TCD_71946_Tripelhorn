Imports BLL_Dinamica
Imports BLL_Estatica
Imports OrganizacionDeEventos

Public Class ABMPaso
    Implements IObservador
    Dim vTraductor As Traductor = Traductor.GetInstance
    Dim vPaso As Paso
    Dim vPasoDinamico As New PasoDinamico
    Dim vEvento As Evento
    Dim vEventoDinamico As New EventoDinamico

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
        End If
    End Sub

    Private Sub ABMPaso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vTraductor.Registrar(Me)
        Calendario.RemoveAllAnnuallyBoldedDates()
        CargarPrioridadCombo()
        CargarEventos()
        Try
            For Each Evento As Evento In EventoCombo.Items
                If vEvento.Nombre = Evento.Nombre Then
                    EventoCombo.SelectedItem = Evento
                    EventoCombo.Enabled = False
                End If
                Actualizar()
            Next
        Catch ex As Exception
        End Try
        ActualizarObservador(Me)
    End Sub

    Private Sub CargarPrioridadCombo()
        PrioridadCombo.Items.Add(vTraductor.Traducir("Baja"))
        PrioridadCombo.Items.Add(vTraductor.Traducir("Media"))
        PrioridadCombo.Items.Add(vTraductor.Traducir("Alta"))
    End Sub

    Private Sub CargarEventos()
        For Each Evento As Evento In vEventoDinamico.ConsultaTodo
            EventoCombo.Items.Add(Evento)
        Next
    End Sub
    Private Sub Limpiar()
        EventoCombo.Text = ""
        DescripcionTxt.Text = ""
        FechaDTP.Value = Today
        PrioridadCombo.Text = ""
    End Sub

    Private Sub Actualizar()
        Dim vLista As New List(Of VistaPaso)
        For Each Evento As Evento In vEventoDinamico.ConsultaTodo
            If Evento.Nombre = EventoCombo.Text Then
                vEvento = Evento
            End If
        Next

        For Each Paso As Paso In vEvento.ListaPasos
            vLista.Add(New VistaPaso(Paso.Descripcion, Paso.Fecha, Paso.Prioridad, Paso.Tipo))
        Next

        GrillaPasos.DataSource = Nothing
        GrillaPasos.DataSource = vLista
        GrillaPasos.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        ActualizarObservador(GrillaPasos)
    End Sub

    Private Sub AgregarFechaACalendario(pFecha As Date)
        If pFecha <> "01/01/0001" Then
            Calendario.AddBoldedDate(pFecha)
        End If
    End Sub

    Private Sub BorrarFechaDeCalendario(pFecha As Date)
        If pFecha <> "01/01/0001" Then
            Calendario.RemoveBoldedDate(pFecha)
        End If
    End Sub

    Private Function GetPasoId() As Integer
        Dim vId As New Integer
        For Each Paso As Paso In vPasoDinamico.ConsultaTodo
            vId = Paso.Id
        Next
        Return vId + 1
    End Function


    Private Sub AltaBtn_Click(sender As Object, e As EventArgs) Handles AltaBtn.Click
        Try
            If EventoCombo.Text <> "" Then
                If DescripcionTxt.Text <> "" And FechaDTP.Value > Date.Now And PrioridadCombo.Text <> "" Then
                    vPaso = New Paso(GetPasoId(), DescripcionTxt.Text, FechaDTP.Value, PrioridadCombo.Text, "Concreto")
                    If Not vPasoDinamico.CheckPaso(vPaso.Descripcion) Then
                        vPasoDinamico.Alta(vPaso)
                        vEventoDinamico.AgregarPaso(vEvento, vPaso, FechaDTP.Value)
                        vEvento.ListaPasos.Add(vPaso)
                        AgregarFechaACalendario(vPaso.Fecha)
                        Calendario.UpdateBoldedDates()
                    Else
                        Throw New Exception("El paso ingresado ya existe en el evento seleccionado")
                    End If
                    Limpiar()
                    Actualizar()
                Else
                    Throw New Exception("Ingrese los datos del paso")
                End If
            Else
                Throw New Exception("Seleccione un evento")
            End If
        Catch ex As Exception
            MessageBox.Show(vTraductor.Traducir(ex.Message), "EvOrg")
        End Try

    End Sub

    Private Sub BajaBtn_Click(sender As Object, e As EventArgs) Handles BajaBtn.Click
        Try
            If GrillaPasos.SelectedRows.Count > 0 Then
                vPaso = VistaAPaso()
                vEventoDinamico.BorrarPaso(vEvento, vPaso)
                vPasoDinamico.Baja(vPaso)
                BorrarFechaDeCalendario(vPaso.Fecha)
                Calendario.UpdateBoldedDates()
                Limpiar()
                Actualizar()
            Else
                Throw New Exception("Seleccione el paso que desea borrar")
            End If
        Catch ex As Exception
            MessageBox.Show(vTraductor.Traducir(ex.Message), "EvOrg")
        End Try
    End Sub

    Private Sub ModificacionBtn_Click(sender As Object, e As EventArgs) Handles ModificacionBtn.Click
        Try
            If GrillaPasos.SelectedRows.Count > 0 Then
                If DescripcionTxt.Text <> "" And FechaDTP.Value > Date.Now And PrioridadCombo.Text <> "" Then
                    vPaso = VistaAPaso()
                    vEvento.ListaPasos.Remove(vPaso)
                    If vPaso.Fecha <> FechaDTP.Value Then
                        BorrarFechaDeCalendario(vPaso.Fecha)
                        AgregarFechaACalendario(FechaDTP.Value)
                        Calendario.UpdateBoldedDates()
                    End If
                    vPaso.Descripcion = DescripcionTxt.Text
                    vPaso.Fecha = FechaDTP.Value
                    vPaso.Prioridad = PrioridadCombo.SelectedItem
                    vPasoDinamico.Modificacion(vPaso)
                    vEventoDinamico.ModificarPaso(vEvento, vPaso, FechaDTP.Value)
                    vEvento.ListaPasos.Add(vPaso)
                    Limpiar()
                    Actualizar()
                Else
                    Throw New Exception("Ingrese los datos del paso")
                End If
            Else
                    Throw New Exception("Seleccione el paso que desea modificar")
            End If
        Catch ex As Exception
            MessageBox.Show(vTraductor.Traducir(ex.Message), "EvOrg")
        End Try
    End Sub

    Private Function VistaAPaso() As Paso
        Dim vP As New Paso
        For Each Paso As Paso In vPasoDinamico.ConsultaTodo
            If Paso.Descripcion = DirectCast(GrillaPasos.SelectedRows(0).DataBoundItem, VistaPaso).Descripcion Then
                vP = Paso
                For Each vPaso As Paso In vEvento.ListaPasos
                    If vPaso.Id = vP.Id Then vP.Fecha = vPaso.Fecha
                Next
            End If
        Next
        Return vP
    End Function

    Private Sub EventoCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles EventoCombo.SelectedIndexChanged
        Actualizar()
        Calendario.RemoveAllAnnuallyBoldedDates()
        For Each Paso As Paso In vEvento.ListaPasos
            AgregarFechaACalendario(Paso.Fecha)
        Next
        Calendario.UpdateBoldedDates()
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

    Private Sub GrillaPasos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaPasos.CellClick
        DescripcionTxt.Text = DirectCast(GrillaPasos.SelectedRows(0).DataBoundItem, VistaPaso).Descripcion
        FechaDTP.Value = DirectCast(GrillaPasos.SelectedRows(0).DataBoundItem, VistaPaso).Fecha
        PrioridadCombo.SelectedItem = DirectCast(GrillaPasos.SelectedRows(0).DataBoundItem, VistaPaso).Prioridad
    End Sub
End Class