Imports BLL_Dinamica
Imports BLL_Estatica
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
            vLista.Add(New VistaServicio(Servicio.Nombre, Servicio.Telefono, Servicio.Email))
        Next
        GrillaServicios.DataSource = Nothing
        GrillaServicios.DataSource = vLista
    End Sub
    Private Sub Limpiar()
        NombreTxt.Text = ""
        EmailTxt.Text = ""
        TelefonoTxt.Text = ""
        CalleTxt.Text = ""
        NumeroTxt.Text = ""
        CPTxt.Text = ""
        ObservacionTxt.Text = ""
    End Sub

    Private Sub AltaBtn_Click(sender As Object, e As EventArgs) Handles AltaBtn.Click
        If Not (NombreTxt.Text = "" And EmailTxt.Text = "" And TelefonoTxt.Text = "") Then
            If Not (CalleTxt.Text = "" And NumeroTxt.Text = "" And CPTxt.Text = "") Then
                vDireccion = New Direccion(CalleTxt.Text, NumeroTxt.Text, CPTxt.Text)
                vServicio = New Servicio(NombreTxt.Text, TelefonoTxt.Text, vDireccion, EmailTxt.Text, ObservacionTxt.Text)
                vServicioDinamico.Alta(vServicio)
                Limpiar()
                Actualizar()
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
        For Each Servicio As Salon In vServicioDinamico.ConsultaTodo
            If Servicio.Nombre = DirectCast(GrillaServicios.SelectedRows(0).DataBoundItem, VistaServicio).Nombre Then
                vServicio.Id = Servicio.Id
                vServicio.Nombre = NombreTxt.Text
                vServicio.Email = EmailTxt.Text
                vServicio.Telefono = TelefonoTxt.Text
                vServicio.Direccion = New Direccion(CalleTxt.Text, NumeroTxt.Text, CPTxt.Text)
                vServicio.Observacion = ObservacionTxt.Text
                vServicioDinamico.Modificacion(vServicio)
                Limpiar()
                Actualizar()
            End If
        Next
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
                CPTxt.Text = Servicio.Direccion.CP
            End If
        Next
    End Sub
End Class