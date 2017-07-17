Imports BLL_Dinamica
Imports BLL_Estatica
Imports System.Text.RegularExpressions
Imports OrganizacionDeEventos

Public Class ABMCliente
    Implements IObservador
    Dim vTraductor As Traductor = Traductor.GetInstance
    Dim vCliente As Cliente
    Dim vClienteDinamico As New ClienteDinamico
    Private Sub ABMCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vTraductor.Registrar(Me)
        Actualizar()
        Me.ActualizarObservador(Me)
    End Sub

    Private Sub Actualizar()
        Try
            Dim vLista As List(Of Object) = vClienteDinamico.ConsultaTodo
            GrillaClientes.DataSource = Nothing
            GrillaClientes.DataSource = vLista
            GrillaClientes.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            ActualizarObservador(GrillaClientes)
        Catch ex As Exception

        End Try
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
            If DNITxt.Text <> "" And NombreTxt.Text <> "" And ApellidoTxt.Text <> "" And TelefonoTxt.Text <> "" And EmailTxt.Text <> "" Then
                If Regex.IsMatch(NombreTxt.Text, "^([A-ZÁÉÍÓÚ]{1}[a-zñáéíóú]+[\s]*)+$") And Regex.IsMatch(ApellidoTxt.Text, "^([A-ZÁÉÍÓÚ]{1}[a-zñáéíóú]+[\s]*)+$") Then
                    If Regex.IsMatch(TelefonoTxt.Text, "[0-9]{8,10}") Then
                        If Regex.IsMatch(EmailTxt.Text, "^[\w._-]+@{1}[\w]+\.[a-z]{2,3}$") Then
                            vCliente = New Cliente(Integer.Parse(DNITxt.Text), NombreTxt.Text, ApellidoTxt.Text, Integer.Parse(TelefonoTxt.Text), EmailTxt.Text)
                            If Not vClienteDinamico.CheckCliente(vCliente.DNI) Then
                                vClienteDinamico.Alta(vCliente)
                                Limpiar()
                                Actualizar()
                            Else
                                Throw New Exception("El DNI del cliente ingresado ya existe")
                            End If
                        Else
                                Throw New Exception("El email ingresado es incorrecto")
                        End If
                    Else
                        Throw New Exception("El numero de telefono ingresado es incorrecto")
                    End If
                Else
                    Throw New Exception("Nombre o apellido ingresados incorrectos")
                End If
            Else
                Throw New Exception("Por favor complete todos los campos")
            End If
        Catch ex As Exception
            MessageBox.Show(vTraductor.Traducir(ex.Message), "EvOrg")
        End Try
    End Sub

    Private Sub BajaBtn_Click(sender As Object, e As EventArgs) Handles BajaBtn.Click
        Try
            If GrillaClientes.SelectedRows.Count > 0 Then
                vCliente = DirectCast(GrillaClientes.SelectedRows(0).DataBoundItem, Cliente)
                If vClienteDinamico.CheckEventosCliente(vCliente.DNI) Then
                    Dim vOpcion As Integer = MessageBox.Show(vTraductor.Traducir("El cliente seleccionado tiene eventos relacionados ¿Desea borrar al cliente junto con sus eventos?"), "EvOrg", MessageBoxButtons.YesNo)
                    If vOpcion = DialogResult.Yes Then
                        vClienteDinamico.Baja(vCliente)
                        Limpiar()
                        Actualizar()
                    End If
                Else
                    vClienteDinamico.Baja(vCliente)
                    Limpiar()
                    Actualizar()
                End If
            Else
                Throw New Exception("Seleccione el cliente que desea borrar")
            End If
        Catch ex As Exception
            MessageBox.Show(vTraductor.Traducir(ex.Message), "EvOrg")
        End Try
    End Sub

    Private Sub ModificacionBtn_Click(sender As Object, e As EventArgs) Handles ModificacionBtn.Click
        Try
            If GrillaClientes.SelectedRows.Count > 0 Then
                If Regex.IsMatch(DNITxt.Text, "[0-9]*") Then
                    If Regex.IsMatch(NombreTxt.Text, "^([A-ZÁÉÍÓÚ]{1}[a-zñáéíóú]+[\s]*)+$") And Regex.IsMatch(ApellidoTxt.Text, "^([A-ZÁÉÍÓÚ]{1}[a-zñáéíóú]+[\s]*)+$") Then
                        If Regex.IsMatch(TelefonoTxt.Text, "[0-9]{8,10}") Then
                            If Regex.IsMatch(EmailTxt.Text, "^[\w._-]+@{1}[\w]+\.[a-z]{2,3}$") Then
                                vCliente = DirectCast(GrillaClientes.SelectedRows(0).DataBoundItem, Cliente)
                                vCliente.DNI = DNITxt.Text
                                vCliente.Nombre = NombreTxt.Text
                                vCliente.Apellido = ApellidoTxt.Text
                                vCliente.Telefono = TelefonoTxt.Text
                                vCliente.Email = EmailTxt.Text
                                vClienteDinamico.Modificacion(vCliente)
                                Limpiar()
                                Actualizar()
                            Else
                                Throw New Exception("El email ingresado es incorrecto")
                            End If
                        Else
                            Throw New Exception("El numero de telefono ingresado es incorrecto")
                        End If
                    Else
                        Throw New Exception("Nombre o apellido incorrectos")
                    End If
                Else
                    Throw New Exception("DNI incorrecto, no puede contener letras")
                End If
            Else
                Throw New Exception("Seleccione el cliente que desea modificar")
            End If
        Catch ex As Exception
            MessageBox.Show(vTraductor.Traducir(ex.Message), "EvOrg")
        End Try
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

    Private Sub DNITxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DNITxt.KeyPress
        If Not (Regex.IsMatch(e.KeyChar, "[0-9\b]")) Then e.KeyChar = Nothing
    End Sub

    Private Sub TelefonoTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TelefonoTxt.KeyPress
        If Not (Regex.IsMatch(e.KeyChar, "[0-9\b]")) Then e.KeyChar = Nothing
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

    Private Sub NombreTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NombreTxt.KeyPress
        If (Regex.IsMatch(e.KeyChar, "[0-9]")) Then e.KeyChar = Nothing
    End Sub

    Private Sub ApellidoTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ApellidoTxt.KeyPress
        If (Regex.IsMatch(e.KeyChar, "[0-9]")) Then e.KeyChar = Nothing
    End Sub
End Class