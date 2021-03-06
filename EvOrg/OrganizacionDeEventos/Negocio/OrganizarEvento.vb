﻿Imports BLL_Dinamica
Imports BLL_Estatica
Imports OrganizacionDeEventos
Imports System.Text.RegularExpressions
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
        If DNITxt.Text <> "" Then
            If vClienteDinamico.CheckCliente(DNITxt.Text) Then
                vCliente = vClienteDinamico.GetCliente(DNITxt.Text)
                NombreTxt.Text = vCliente.Nombre
                ApellidoTxt.Text = vCliente.Apellido
                TelefonoTxt.Text = vCliente.Telefono
                EmailTxt.Text = vCliente.Email
                vEvento.Cliente = vCliente
            End If
        Else
            MessageBox.Show(vTraductor.Traducir("Ingrese el DNI del cliente"), "EvOrg")
        End If
    End Sub

    Private Sub NombreEventoTxt_TextChanged(sender As Object, e As EventArgs) Handles NombreEventoTxt.TextChanged
        vEvento.Nombre = NombreEventoTxt.Text
    End Sub

    Private Sub LocalidadTxt_TextChanged(sender As Object, e As EventArgs) Handles LocalidadTxt.TextChanged
        vEvento.Localidad = LocalidadTxt.Text
    End Sub

    Private Sub GuardarBtn_Click(sender As Object, e As EventArgs) Handles GuardarBtn.Click
        If NombreEventoTxt.Text <> "" And FechaDTP.Value.Date <> Today.Date And CantidadNumeric.Value <> 0 And TipoEventoCombo.Text <> "" Then
            vEvento.Nombre = NombreEventoTxt.Text
            vEvento.Fecha = FechaDTP.Value
            vEvento.CantidadInvitados = CantidadNumeric.Value
            vEvento.Tipo = TipoEventoCombo.SelectedItem
            If vEvento.Salon Is Nothing Then MessageBox.Show(vTraductor.Traducir("Seleccione un salón"), "EvOrg")
            vEventoDinamico.Alta(vEvento)
        Else
            MessageBox.Show(vTraductor.Traducir("Ingrese los datos del evento"), "EvOrg")
        End If
    End Sub

    Private Sub CancelarBtn_Click(sender As Object, e As EventArgs) Handles CancelarBtn.Click
        Me.Close()
    End Sub

    Private Sub DNITxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DNITxt.KeyPress
        If Not (Regex.IsMatch(e.KeyChar, "[0-9\b]")) Then e.KeyChar = Nothing
    End Sub

    Private Sub LocalidadTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LocalidadTxt.KeyPress
        If (Regex.IsMatch(e.KeyChar, "[0-9]")) Then e.KeyChar = Nothing
    End Sub
End Class