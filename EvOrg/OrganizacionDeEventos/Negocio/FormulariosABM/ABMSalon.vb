Imports BLL_Dinamica
Imports BLL_Estatica
Imports System.Text.RegularExpressions
Public Class ABMSalon

    Dim vSalon As Salon
    Dim vDireccion As Direccion
    Dim vSalonDinamico As New salonDinamico
    Private Sub ABMSalon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Actualizar()
    End Sub

    Public Sub Actualizar()
        Dim vLista As New List(Of VistaSalon)
        For Each Salon As Salon In vSalonDinamico.ConsultaTodo
            vLista.Add(New VistaSalon(Salon.Nombre, Salon.Capacidad, Salon.Email, Salon.Telefono, Salon.Precio))
        Next
        GrillaSalones.DataSource = Nothing
        GrillaSalones.DataSource = vLista
        GrillaSalones.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub
    Private Sub Limpiar()
        NombreTxt.Text = ""
        CapacidadTxt.Text = ""
        EmailTxt.Text = ""
        TelefonoTxt.Text = ""
        CalleTxt.Text = ""
        NumeroTxt.Text = ""
        CPTxt.Text = ""
        DescripcionTxt.Text = ""
    End Sub
    Private Sub AltaBtn_Click(sender As Object, e As EventArgs) Handles AltaBtn.Click
        If Not (NombreTxt.Text = "" And CapacidadTxt.Text = "" And EmailTxt.Text = "" And TelefonoTxt.Text = "") Then
            If Not (CalleTxt.Text = "" And NumeroTxt.Text = "" And CPTxt.Text = "") Then
                If Regex.IsMatch(EmailTxt.Text, "^[\w]+@{1}[\w]+\.[a-z]{2,3}$") Then
                    If Regex.IsMatch(TelefonoTxt.Text, "[0-9]{8,10}") Then
                        vDireccion = New Direccion(CalleTxt.Text, NumeroTxt.Text, CPTxt.Text)
                        vSalon = New Salon(NombreTxt.Text, CapacidadTxt.Text, EmailTxt.Text, TelefonoTxt.Text, vDireccion, DescripcionTxt.Text, PrecioTxt.Text)
                        vSalonDinamico.Alta(vSalon)
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
        For Each salon As Salon In vSalonDinamico.ConsultaTodo
            If salon.Nombre = DirectCast(GrillaSalones.SelectedRows(0).DataBoundItem, VistaSalon).Nombre Then
                vSalon = salon
                vSalonDinamico.Baja(vSalon)
                Limpiar()
                Actualizar()
            End If
        Next
    End Sub

    Private Sub ModificacionBtn_Click(sender As Object, e As EventArgs) Handles ModificacionBtn.Click
        If Regex.IsMatch(EmailTxt.Text, "^[\w]+@{1}[\w]+\.[a-z]{2,3}$") Then
            If Regex.IsMatch(TelefonoTxt.Text, "[0-9]{8,10}") Then
                For Each salon As Salon In vSalonDinamico.ConsultaTodo
                    If salon.Nombre = DirectCast(GrillaSalones.SelectedRows(0).DataBoundItem, VistaSalon).Nombre Then
                        vSalon.Id = salon.Id
                        vSalon.Nombre = NombreTxt.Text
                        vSalon.Capacidad = CapacidadTxt.Text
                        vSalon.Email = EmailTxt.Text
                        vSalon.Telefono = TelefonoTxt.Text
                        vSalon.Direccion = New Direccion(CalleTxt.Text, NumeroTxt.Text, CPTxt.Text)
                        vSalon.Descripcion = DescripcionTxt.Text
                        vSalon.Precio = PrecioTxt.Text
                        vSalonDinamico.Modificacion(vSalon)
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

    Private Sub GrillaSalones_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaSalones.CellClick
        Try
            For Each salon As Salon In vSalonDinamico.ConsultaTodo
                If salon.Nombre = DirectCast(GrillaSalones.SelectedRows(0).DataBoundItem, VistaSalon).Nombre Then
                    NombreTxt.Text = salon.Nombre
                    CapacidadTxt.Text = salon.Capacidad
                    EmailTxt.Text = salon.Email
                    TelefonoTxt.Text = salon.Telefono
                    DescripcionTxt.Text = salon.Descripcion
                    CalleTxt.Text = salon.Direccion.Calle
                    NumeroTxt.Text = salon.Direccion.Numero
                    CPTxt.Text = salon.Direccion.CP
                    PrecioTxt.Text = salon.Precio
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CapacidadTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CapacidadTxt.KeyPress
        If Not (Regex.IsMatch(e.KeyChar, "[0-9\b]")) Then e.KeyChar = Nothing
    End Sub

    Private Sub CPTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CPTxt.KeyPress
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