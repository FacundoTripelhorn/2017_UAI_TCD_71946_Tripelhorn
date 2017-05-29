Imports BLL_Dinamica
Imports BLL_Estatica
Public Class ABMTipoEvento

    Dim vTipoEvento As TipoEvento
    Dim vPaso As Paso
    Dim vTipoEventoDinamico As New TipoEventoDinamico
    Dim vPasoDinamico As New PasoDinamico

    Private Sub ABMTipoEvento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Actualizar()
        PrioridadCombo.Items.Add("Baja")
        PrioridadCombo.Items.Add("Media")
        PrioridadCombo.Items.Add("Alta")
    End Sub

    Public Sub Actualizar()
        Dim vLista As New List(Of VistaTipoEvento)
        For Each TipoEvento As TipoEvento In vTipoEventoDinamico.ConsultaTodo
            vLista.Add(New VistaTipoEvento(TipoEvento.Nombre))
        Next
        GrillaTipoEvento.DataSource = Nothing
        GrillaTipoEvento.DataSource = vLista
    End Sub

    Public Sub ActualizarPasos()
        Dim vLista As New List(Of VistaPasoTE)
        For Each Paso As Paso In VistaATipoEvento.ListaPasos
            vLista.Add(New VistaPasoTE(Paso.Descripcion, vTipoEventoDinamico.ConsultaDias(VistaATipoEvento, Paso), Paso.Prioridad))
        Next
        GrillaPasos.DataSource = Nothing
        GrillaPasos.DataSource = vLista
    End Sub

    Private Sub Limpiar()
        NombreTxt.Text = ""
        DescripcionTxt.Text = ""
        DescripcionTxt2.Text = ""
        DiasNumeric.Value = 0
        PrioridadCombo.Text = ""
    End Sub

    Private Sub AltaBtn_Click(sender As Object, e As EventArgs) Handles AltaBtn.Click
        If Not (NombreTxt.Text = "") Then
            vTipoEvento = New TipoEvento(NombreTxt.Text, DescripcionTxt.Text)
            vTipoEventoDinamico.Alta(vTipoEvento)
            Limpiar()
            Actualizar()
        End If
    End Sub

    Private Sub BajaBtn_Click(sender As Object, e As EventArgs) Handles BajaBtn.Click
        vTipoEvento = VistaATipoEvento()
        vTipoEventoDinamico.Baja(vTipoEvento)
        Limpiar()
        Actualizar()
    End Sub

    Private Sub ModificacionBtn_Click(sender As Object, e As EventArgs) Handles ModificacionBtn.Click
        vTipoEvento.Id = VistaATipoEvento.Id
        vTipoEvento.Nombre = NombreTxt.Text
        vTipoEvento.Descripcion = DescripcionTxt.Text
        vTipoEventoDinamico.Modificacion(vTipoEvento)
        Limpiar()
        Actualizar()
    End Sub

    Private Sub AltaPasoBtn_Click(sender As Object, e As EventArgs) Handles AltaPasoBtn.Click
        If Not (DescripcionTxt2.Text = "" And DiasNumeric.Value = 0 And PrioridadCombo.Text = "") Then
            vPaso = New Paso(SetPasoId(), DescripcionTxt2.Text,, PrioridadCombo.Text, "Genérico")
            vPasoDinamico.Alta(vPaso)
            vTipoEventoDinamico.AgregarPaso(VistaATipoEvento, vPaso, DiasNumeric.Value)
            Limpiar()
            ActualizarPasos()
        Else
            MsgBox("Ingrese los datos del paso")
        End If
    End Sub

    Private Sub BajaPasoBtn_Click(sender As Object, e As EventArgs) Handles BajaPasoBtn.Click
        Try
            vTipoEvento = VistaATipoEvento()
            vPaso = VistaAPaso()
            vTipoEventoDinamico.BorrarPaso(vTipoEvento, vPaso)
            vPasoDinamico.Baja(vPaso)
            ActualizarPasos()
        Catch ex As Exception

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
End Class