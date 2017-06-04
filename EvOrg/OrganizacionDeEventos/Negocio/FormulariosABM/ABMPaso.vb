Imports BLL_Dinamica
Imports BLL_Estatica
Public Class ABMPaso
    Dim vPaso As Paso
    Dim vPasoDinamico As New PasoDinamico
    Dim vEvento As Evento
    Dim vEventoDinamico As New EventoDinamico

    Private Sub ABMPaso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Calendario.RemoveAllAnnuallyBoldedDates()
            CargarPrioridadCombo()
            CargarEventos()
            Actualizar()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CargarPrioridadCombo()
        PrioridadCombo.Items.Add("Baja")
        PrioridadCombo.Items.Add("Media")
        PrioridadCombo.Items.Add("Alta")
    End Sub

    Private Sub CargarEventos()
        For Each Evento As Evento In vEventoDinamico.ConsultaTodo
            EventoCombo.Items.Add(Evento.Nombre)
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
            If Evento.Nombre = EventoCombo.SelectedItem Then
                vEvento = Evento

            End If
        Next

        For Each Paso As Paso In vEvento.ListaPasos
            vLista.Add(New VistaPaso(Paso.Descripcion, Paso.Fecha, Paso.Prioridad, Paso.Tipo))
        Next

        GrillaPasos.DataSource = Nothing
        GrillaPasos.DataSource = vLista
        GrillaPasos.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
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
        If Not (EventoCombo.Text = "") Then
            If Not (DescripcionTxt.Text = "" And FechaDTP.Value > Date.Now And PrioridadCombo.Text = "") Then
                vPaso = New Paso(GetPasoId(), DescripcionTxt.Text, FechaDTP.Value, PrioridadCombo.Text, "Concreto")
                vPasoDinamico.Alta(vPaso)
                vEventoDinamico.AgregarPaso(vEvento, vPaso, FechaDTP.Value)
                vEvento.ListaPasos.Add(vPaso)
                AgregarFechaACalendario(vPaso.Fecha)
                Calendario.UpdateBoldedDates()
                Limpiar()
                Actualizar()
            Else
                MsgBox("Ingrese los datos del paso")
            End If
        Else
            MsgBox("Seleccione un evento")
        End If
    End Sub

    Private Sub BajaBtn_Click(sender As Object, e As EventArgs) Handles BajaBtn.Click
        vPaso = VistaAPaso()
        vEventoDinamico.BorrarPaso(vEvento, vPaso)
        vPasoDinamico.Baja(vPaso)
        BorrarFechaDeCalendario(vPaso.Fecha)
        Calendario.UpdateBoldedDates()
        Limpiar()
        Actualizar()
    End Sub

    Private Sub ModificacionBtn_Click(sender As Object, e As EventArgs) Handles ModificacionBtn.Click
        Try
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
        Catch ex As Exception
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
End Class