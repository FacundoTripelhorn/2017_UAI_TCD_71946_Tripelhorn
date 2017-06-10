Imports BLL_Dinamica
Imports BLL_Estatica
Imports System.Text.RegularExpressions
Public Class ABMServicio

    Dim vServicio As Servicio
    Dim vDireccion As Direccion
    Dim vServicioDinamico As New ServicioDinamico
    Private Sub ABMServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Actualizar()
    End Sub

    Public Sub Actualizar()
        Dim vLista As New List(Of VistaServicio)
        For Each Servicio As Servicio In vServicioDinamico.ConsultaTodo
            vLista.Add(New VistaServicio(Servicio.Nombre, Servicio.Telefono, Servicio.Email, Servicio.Precio))
        Next
        GrillaServicios.DataSource = Nothing
        GrillaServicios.DataSource = vLista
        GrillaServicios.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub
    Private Sub Limpiar()
        NombreTxt.Text = ""
        EmailTxt.Text = ""
        TelefonoTxt.Text = ""
        CalleTxt.Text = ""
        NumeroTxt.Text = ""
        LocalidadTxt.Text = ""
        ObservacionTxt.Text = ""
        PrecioTxt.Text = ""
    End Sub

    Private Sub AltaBtn_Click(sender As Object, e As EventArgs) Handles AltaBtn.Click
        If Not (NombreTxt.Text = "" And EmailTxt.Text = "" And TelefonoTxt.Text = "") Then
            If Not (CalleTxt.Text = "" And NumeroTxt.Text = "" And LocalidadTxt.Text = "") Then
                If Regex.IsMatch(EmailTxt.Text, "^[\w]+@{1}[\w]+\.[a-z]{2,3}$") Then
                    If Regex.IsMatch(TelefonoTxt.Text, "[0-9]{8,10}") Then
                        vDireccion = New Direccion(CalleTxt.Text, NumeroTxt.Text, LocalidadTxt.Text)
                        vServicio = New Servicio(NombreTxt.Text, TelefonoTxt.Text, vDireccion, EmailTxt.Text, ObservacionTxt.Text, PrecioTxt.Text)
                        vServicioDinamico.Alta(vServicio)
                        Limpiar()
                        Actualizar()
                    Else
                        MsgBox("El teléfono ingresado es incorrecto")
                    End If
                Else
                    MsgBox("El email ingresado es incorrecto")
                End If
            End If
        End If
    End Sub

    Private Sub BajaBtn_Click(sender As Object, e As EventArgs) Handles BajaBtn.Click
        For Each Servicio As Servicio In vServicioDinamico.ConsultaTodo
            If Servicio.Nombre = DirectCast(GrillaServicios.SelectedRows(0).DataBoundItem, VistaServicio).Nombre Then
                vServicio = Servicio
                vServicioDinamico.Baja(vServicio)
                Limpiar()
                Actualizar()
            End If
        Next
    End Sub

    Private Sub ModificacionBtn_Click(sender As Object, e As EventArgs) Handles ModificacionBtn.Click
        If (Regex.IsMatch(EmailTxt.Text, "^[\w]+@{1}[\w]+\.[a-z]{2,3}$")) Then
            If (Regex.IsMatch(TelefonoTxt.Text, "^[0-9]{8,10}")) Then
                For Each Servicio As Servicio In vServicioDinamico.ConsultaTodo
                    If Servicio.Nombre = DirectCast(GrillaServicios.SelectedRows(0).DataBoundItem, VistaServicio).Nombre Then
                        vDireccion = New Direccion(Servicio.Direccion.Id, CalleTxt.Text, NumeroTxt.Text, LocalidadTxt.Text)
                        vServicio = New Servicio(Servicio.Id, NombreTxt.Text, TelefonoTxt.Text, vDireccion, EmailTxt.Text, ObservacionTxt.Text, PrecioTxt.Text)
                        vServicioDinamico.Modificacion(vServicio)
                        Limpiar()
                        Actualizar()
                    End If
                Next
            Else
                MsgBox("El teléfono ingresado es incorrecto")
            End If
        Else
            MsgBox("El email ingresado es incorrecto")
        End If
    End Sub

    Private Sub GrillaServicios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaServicios.CellClick
        For Each Servicio As Servicio In vServicioDinamico.ConsultaTodo
            If Servicio.Nombre = DirectCast(GrillaServicios.SelectedRows(0).DataBoundItem, VistaServicio).Nombre Then
                NombreTxt.Text = Servicio.Nombre
                EmailTxt.Text = Servicio.Email
                TelefonoTxt.Text = Servicio.Telefono
                ObservacionTxt.Text = Servicio.Observacion
                CalleTxt.Text = Servicio.Direccion.Calle
                NumeroTxt.Text = Servicio.Direccion.Numero
                LocalidadTxt.Text = Servicio.Direccion.Localidad
                PrecioTxt.Text = Servicio.Precio
            End If
        Next
    End Sub

    Private Sub CPTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LocalidadTxt.KeyPress
        If Not (Regex.IsMatch(e.KeyChar, "[0-9\b]")) Then e.KeyChar = Nothing
    End Sub

    Private Sub NumeroTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NumeroTxt.KeyPress
        If Not (Regex.IsMatch(e.KeyChar, "[0-9\b]")) Then e.KeyChar = Nothing
    End Sub

    Private Sub TelefonoTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TelefonoTxt.KeyPress
        If Not (Regex.IsMatch(e.KeyChar, "[0-9\b]")) Then e.KeyChar = Nothing
    End Sub

    Private Sub PrecioTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PrecioTxt.KeyPress
        If Not (Regex.IsMatch(e.KeyChar, "[0-9\b,]")) Then e.KeyChar = Nothing
    End Sub
End Class