Imports BLL_Dinamica
Imports BLL_Estatica
Imports OrganizacionDeEventos

Public Class ABMTipoEvento
    Implements IObservador
    Dim vTraductor As Traductor = Traductor.GetInstance
    Dim vTipoEvento As TipoEvento
    Dim vPaso As Paso
    Dim vTipoEventoDinamico As New TipoEventoDinamico
    Dim vPasoDinamico As New PasoDinamico

    Private Sub ABMTipoEvento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vTraductor.Registrar(Me)
        Actualizar()
        PrioridadCombo.Items.Add(vTraductor.Traducir("Baja"))
        PrioridadCombo.Items.Add(vTraductor.Traducir("Media"))
        PrioridadCombo.Items.Add(vTraductor.Traducir("Alta"))
        ActualizarObservador(Me)
    End Sub

    Public Sub Actualizar()
        Dim vLista As New List(Of VistaTipoEvento)
        For Each TipoEvento As TipoEvento In vTipoEventoDinamico.ConsultaTodo
            vLista.Add(New VistaTipoEvento(TipoEvento.Nombre))
        Next
        GrillaTipoEvento.DataSource = Nothing
        GrillaTipoEvento.DataSource = vLista
        GrillaTipoEvento.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        ActualizarObservador(Me)
    End Sub

    Public Sub ActualizarPasos()
        Dim vLista As New List(Of VistaPasoTE)
        For Each Paso As Paso In VistaATipoEvento.ListaPasos
            vLista.Add(New VistaPasoTE(Paso.Descripcion, vTipoEventoDinamico.ConsultaDias(VistaATipoEvento, Paso), Paso.Prioridad))
        Next
        GrillaPasos.DataSource = Nothing
        GrillaPasos.DataSource = vLista
        GrillaPasos.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        ActualizarObservador(Me)
    End Sub

    Private Sub Limpiar()
        NombreTxt.Text = ""
        DescripcionTxt.Text = ""
        DescripcionTxt2.Text = ""
        DiasNumeric.Value = 0
        PrioridadCombo.Text = ""
    End Sub

    Private Sub AltaBtn_Click(sender As Object, e As EventArgs) Handles AltaBtn.Click
        Try
            If Not (NombreTxt.Text = "") Then
                vTipoEvento = New TipoEvento(NombreTxt.Text, DescripcionTxt.Text)
                If Not vTipoEventoDinamico.CheckTipoEvento(vTipoEvento.Nombre) Then
                    vTipoEventoDinamico.Alta(vTipoEvento)
                Else
                    Throw New Exception("El nombre del tipo de evento ingresado ya existe")
                End If
                Limpiar()
                    Actualizar()
                Else
                    Throw New Exception("Ingrese el nombre")
            End If
        Catch ex As Exception
            MessageBox.Show(vTraductor.Traducir(ex.Message), "EvOrg")
        End Try
    End Sub

    Private Sub BajaBtn_Click(sender As Object, e As EventArgs) Handles BajaBtn.Click
        Try
            If GrillaTipoEvento.SelectedRows.Count > 0 Then
                vTipoEvento = VistaATipoEvento()
                If vTipoEventoDinamico.CheckEventos(vTipoEvento.Id) Then
                    MessageBox.Show(vTraductor.Traducir("Como el tipo de evento seleccionado tiene eventos relacionados se deshabilitará hasta que se realicen o cancelen estos eventos"))
                    vTipoEventoDinamico.DeshabilitarTipo(vTipoEvento.Id)
                Else
                    vTipoEventoDinamico.Baja(vTipoEvento)
                End If
                Limpiar()
                Actualizar()
                ActualizarPasos()
            Else
                    Throw New Exception("Seleccione el tipo de evento que desea borrar")
            End If
        Catch ex As Exception
            MessageBox.Show(vTraductor.Traducir(ex.Message), "EvOrg")
        End Try
    End Sub

    Private Sub ModificacionBtn_Click(sender As Object, e As EventArgs) Handles ModificacionBtn.Click
        Try
            If GrillaTipoEvento.SelectedRows.Count > 0 Then
                vTipoEvento.Id = VistaATipoEvento.Id
                vTipoEvento.Nombre = NombreTxt.Text
                vTipoEvento.Descripcion = DescripcionTxt.Text
                vTipoEventoDinamico.Modificacion(vTipoEvento)
                Limpiar()
                Actualizar()
            Else
                Throw New Exception("Seleccione el tipo de evento que desea modificar")
            End If
        Catch ex As Exception
            MessageBox.Show(vTraductor.Traducir(ex.Message), "EvOrg")
        End Try

    End Sub

    Private Sub AltaPasoBtn_Click(sender As Object, e As EventArgs) Handles AltaPasoBtn.Click
        Try
            If GrillaTipoEvento.SelectedRows.Count > 0 Then
                If DescripcionTxt2.Text <> "" And DiasNumeric.Value <> 0 And PrioridadCombo.Text <> "" Then
                    vPaso = New Paso(SetPasoId(), DescripcionTxt2.Text,, PrioridadCombo.Text, "Generico")
                    If Not vPasoDinamico.CheckPasoTipoEvento(vPaso.Descripcion) Then
                        vPasoDinamico.Alta(vPaso)
                        vTipoEventoDinamico.AgregarPaso(VistaATipoEvento, vPaso, DiasNumeric.Value)
                    Else
                        Throw New Exception("El paso ingresado ya existe en el tipo de evento seleccionado")
                    End If
                    Limpiar()
                    ActualizarPasos()
                Else
                    Throw New Exception("Ingrese los datos del paso")
                End If
            Else
                Throw New Exception("Seleccione un tipo de evento")
            End If
        Catch ex As Exception
            MessageBox.Show(vTraductor.Traducir(ex.Message), "EvOrg")
        End Try
    End Sub

    Private Sub BajaPasoBtn_Click(sender As Object, e As EventArgs) Handles BajaPasoBtn.Click
        Try
            If GrillaPasos.SelectedRows.Count > 0 Then
                vTipoEvento = VistaATipoEvento()
                vPaso = VistaAPaso()
                vTipoEventoDinamico.BorrarPaso(vTipoEvento, vPaso)
                vPasoDinamico.Baja(vPaso)
                ActualizarPasos()
            Else
                Throw New Exception("Seleccione el paso que desea borrar")
            End If
        Catch ex As Exception
            MessageBox.Show(vTraductor.Traducir(ex.Message), "EvOrg")
        End Try
    End Sub

    Private Function VistaATipoEvento() As TipoEvento
        Try
            Dim vTEvento As New TipoEvento
            For Each TipoEvento As TipoEvento In vTipoEventoDinamico.ConsultaTodo
                If TipoEvento.Nombre = DirectCast(GrillaTipoEvento.SelectedRows(0).DataBoundItem, VistaTipoEvento).Nombre Then
                    vTEvento = TipoEvento
                End If
            Next
            Return vTEvento
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Function VistaAPaso() As Paso
        Try
            Dim vP As New Paso
            For Each Paso As Paso In vPasoDinamico.ConsultaTodo
                If Paso.Descripcion = DirectCast(GrillaPasos.SelectedRows(0).DataBoundItem, VistaPasoTE).Descripcion Then
                    vP = Paso
                End If
            Next
            Return vP
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Function SetPasoId() As Integer
        Try
            Dim vId As New Integer
            For Each Paso As Paso In vPasoDinamico.ConsultaTodo
                vId = Paso.Id
            Next
            Return vId + 1
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Sub GrillaTipoEvento_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaTipoEvento.CellClick
        ActualizarPasos()
        Dim vTE As TipoEvento = VistaATipoEvento()
        NombreTxt.Text = vTE.Nombre
        DescripcionTxt.Text = vTE.Descripcion
    End Sub

    Private Sub GrillaPasos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaPasos.CellClick
        Dim vP As Paso = VistaAPaso()
        DescripcionTxt2.Text = vP.Descripcion
        DiasNumeric.Value = DirectCast(GrillaPasos.SelectedRows(0).DataBoundItem, VistaPasoTE).Dias
        PrioridadCombo.SelectedItem = vP.Prioridad
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