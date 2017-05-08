Imports BLL_Dinamica
Imports BLL_Estatica
Public Class ABMCliente
    Dim vCliente As Cliente
    Dim vClienteDinamico As New ClienteDinamico
    Private Sub ABMCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GrillaClientes.DataSource = vClienteDinamico.ConsultaTodo
    End Sub

    Private Sub Limpiar()
        DNITxt.Text = ""
        NombreTxt.Text = ""
        ApellidoTxt.Text = ""
        TelefonoTxt.Text = ""
        EmailTxt.Text = ""
    End Sub
    Private Sub AltaBtn_Click(sender As Object, e As EventArgs) Handles AltaBtn.Click
        Try
            vCliente = New Cliente(Integer.Parse(DNITxt.Text), NombreTxt.Text, ApellidoTxt.Text, Integer.Parse(TelefonoTxt.Text), EmailTxt.Text)
            vClienteDinamico.Alta(vCliente)
            Limpiar()
            GrillaClientes.DataSource = vClienteDinamico.ConsultaTodo()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BajaBtn_Click(sender As Object, e As EventArgs) Handles BajaBtn.Click
        vCliente = DirectCast(GrillaClientes.SelectedRows(0).DataBoundItem, Cliente)
        vClienteDinamico.Baja(vCliente)
        Limpiar()
        GrillaClientes.DataSource = vClienteDinamico.ConsultaTodo()
    End Sub

    Private Sub ModificacionBtn_Click(sender As Object, e As EventArgs) Handles ModificacionBtn.Click
        vCliente = DirectCast(GrillaClientes.SelectedRows(0).DataBoundItem, Cliente)
        vCliente.DNI = DNITxt.Text
        vCliente.Nombre = NombreTxt.Text
        vCliente.Apellido = ApellidoTxt.Text
        vCliente.Telefono = TelefonoTxt.Text
        vCliente.Email = EmailTxt.Text
        vClienteDinamico.Modificacion(vCliente)
        Limpiar()
        GrillaClientes.DataSource = vClienteDinamico.ConsultaTodo()
    End Sub

    Private Sub GrillaClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaClientes.CellClick
        Try
            Dim C As Cliente = DirectCast(GrillaClientes.SelectedRows(0).DataBoundItem, Cliente)
            DNITxt.Text = C.DNI
            NombreTxt.Text = C.Nombre
            ApellidoTxt.Text = C.Apellido
            TelefonoTxt.Text = C.Telefono
            EmailTxt.Text = C.Email
        Catch ex As Exception

        End Try
    End Sub
End Class