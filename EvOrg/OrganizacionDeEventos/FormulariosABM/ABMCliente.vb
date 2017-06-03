Imports BLL_Dinamica
Imports BLL_Estatica
Imports System.Text.RegularExpressions
Public Class ABMCliente
    Dim vCliente As Cliente
    Dim vClienteDinamico As New ClienteDinamico
    Private Sub ABMCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Actualizar()

    End Sub

    Private Sub Actualizar()
        GrillaClientes.DataSource = Nothing
        GrillaClientes.DataSource = vClienteDinamico.ConsultaTodo
        GrillaClientes.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
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
            If Regex.IsMatch(DNITxt.Text, "[0-9]*") Then
                If Regex.IsMatch(NombreTxt.Text, "^([A-ZÁÉÍÓÚ]{1}[a-zñáéíóú]+[\s]*)+$") And Regex.IsMatch(ApellidoTxt.Text, "^([A-ZÁÉÍÓÚ]{1}[a-zñáéíóú]+[\s]*)+$") Then
                    If Regex.IsMatch(TelefonoTxt.Text, "^11\d{8}") Then
                        If Regex.IsMatch(EmailTxt.Text, "^[\w]+@{1}[\w]+\.[a-z]{2,3}$") Then
                            vCliente = New Cliente(Integer.Parse(DNITxt.Text), NombreTxt.Text, ApellidoTxt.Text, Integer.Parse(TelefonoTxt.Text), EmailTxt.Text)
                            vClienteDinamico.Alta(vCliente)
                            Limpiar()
                            GrillaClientes.DataSource = vClienteDinamico.ConsultaTodo()
                        Else
                            MsgBox("El email ingresado es incorecto")
                        End If
                    Else
                        MsgBox("Número de telefono incorrecto")
                    End If
                Else
                        MsgBox("Error al ingresar nombre y apellido")
                End If
            Else
                MsgBox("DNI incorrecto")
            End If
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
        If Regex.IsMatch(DNITxt.Text, "[0-9]*") Then
            If Regex.IsMatch(NombreTxt.Text, "^([A-ZÁÉÍÓÚ]{1}[a-zñáéíóú]+[\s]*)+$") And Regex.IsMatch(ApellidoTxt.Text, "^([A-ZÁÉÍÓÚ]{1}[a-zñáéíóú]+[\s]*)+$") Then
                If Regex.IsMatch(TelefonoTxt.Text, "^11\d{8}") Then
                    If Regex.IsMatch(EmailTxt.Text, "^[\w]+@{1}[\w]+\.[a-z]{2,3}$") Then
                        vCliente = DirectCast(GrillaClientes.SelectedRows(0).DataBoundItem, Cliente)
                        vCliente.DNI = DNITxt.Text
                        vCliente.Nombre = NombreTxt.Text
                        vCliente.Apellido = ApellidoTxt.Text
                        vCliente.Telefono = TelefonoTxt.Text
                        vCliente.Email = EmailTxt.Text
                        vClienteDinamico.Modificacion(vCliente)
                        Limpiar()
                        GrillaClientes.DataSource = vClienteDinamico.ConsultaTodo()
                    Else
                        MsgBox("El email ingresado es incorecto")
                    End If
                Else
                    MsgBox("Número de telefono incorrecto")
                End If
            Else
                MsgBox("Error al ingresar nombre y apellido")
            End If
        Else
            MsgBox("DNI incorrecto")
        End If
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