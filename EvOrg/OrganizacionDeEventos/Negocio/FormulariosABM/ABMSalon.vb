Imports BLL_Dinamica
Imports BLL_Estatica
Imports System.Text.RegularExpressions
Imports OrganizacionDeEventos

Public Class ABMSalon
    Implements IObservador
    Dim vTraductor As Traductor = Traductor.GetInstance
    Dim vSalon As New Salon
    Dim vDireccion As Direccion
    Dim vSalonDinamico As New SalonDinamico
    Private Sub ABMSalon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vTraductor.Registrar(Me)
        Actualizar()
        ActualizarObservador(Me)
    End Sub

    Public Sub Actualizar()
        Try
            Dim vLista As New List(Of VistaSalon)
            For Each Salon As Salon In vSalonDinamico.ConsultaTodo
                vLista.Add(New VistaSalon(Salon.Nombre, Salon.Capacidad, Salon.Email, Salon.Telefono, Salon.Precio))
            Next
            GrillaSalones.DataSource = Nothing
            GrillaSalones.DataSource = vLista
            GrillaSalones.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            ActualizarObservador(GrillaSalones)
        Catch ex As Exception

        End Try

    End Sub
    Private Sub Limpiar()
        NombreTxt.Text = ""
        CapacidadTxt.Text = ""
        EmailTxt.Text = ""
        TelefonoTxt.Text = ""
        CalleTxt.Text = ""
        NumeroTxt.Text = ""
        LocalidadTxt.Text = ""
        DescripcionTxt.Text = ""
    End Sub
    Private Sub AltaBtn_Click(sender As Object, e As EventArgs) Handles AltaBtn.Click
        Try
            If NombreTxt.Text <> "" And EmailTxt.Text <> "" And TelefonoTxt.Text <> "" And CalleTxt.Text <> "" And NumeroTxt.Text <> "" And LocalidadTxt.Text <> "" Then
                If Regex.IsMatch(EmailTxt.Text, "^[\w._-]+@{1}[\w]+\.[a-z]{2,3}$") Then
                    If Regex.IsMatch(TelefonoTxt.Text, "[0-9]{8,10}") Then
                        vDireccion = New Direccion(CalleTxt.Text, Integer.Parse(NumeroTxt.Text), LocalidadTxt.Text)
                        vSalon = New Salon(NombreTxt.Text, CapacidadTxt.Text, EmailTxt.Text, TelefonoTxt.Text, vDireccion, DescripcionTxt.Text, PrecioTxt.Text)
                        If Not vSalonDinamico.CheckSalon(vSalon.Nombre) Then
                            vSalonDinamico.Alta(vSalon)
                        Else
                            Throw New Exception("El nombre de salón ingresado ya existe")
                        End If
                        Limpiar()
                            Actualizar()
                        Else
                            Throw New Exception("El numero de telefono ingresado es incorrecto")
                    End If
                Else
                    Throw New Exception("El email ingresado es incorrecto")
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
            If GrillaSalones.SelectedRows.Count > 0 Then
                For Each salon As Salon In vSalonDinamico.ConsultaTodo
                    If salon.Nombre = DirectCast(GrillaSalones.SelectedRows(0).DataBoundItem, VistaSalon).Nombre Then
                        vSalon = salon
                        vSalonDinamico.Baja(vSalon)
                        Limpiar()
                        Actualizar()
                    End If
                Next
            Else
                Throw New Exception("Seleccione el salón que desea borrar")
            End If
        Catch ex As Exception
            MessageBox.Show(vTraductor.Traducir(ex.Message), "EvOrg")
        End Try

    End Sub

    Private Sub ModificacionBtn_Click(sender As Object, e As EventArgs) Handles ModificacionBtn.Click
        Try
            If GrillaSalones.SelectedRows.Count > 0 Then

                If Not (NombreTxt.Text = "" And EmailTxt.Text = "" And TelefonoTxt.Text = "" And CalleTxt.Text = "" And NumeroTxt.Text = "" And LocalidadTxt.Text = "") Then
                    If Regex.IsMatch(EmailTxt.Text, "^[\w]+@{1}[\w]+\.[a-z]{2,3}$") Then
                        If Regex.IsMatch(TelefonoTxt.Text, "[0-9]{8,10}") Then
                            For Each salon As Salon In vSalonDinamico.ConsultaTodo
                                If salon.Nombre = DirectCast(GrillaSalones.SelectedRows(0).DataBoundItem, VistaSalon).Nombre Then
                                    vSalon.Id = salon.Id
                                    vSalon.Nombre = NombreTxt.Text
                                    vSalon.Capacidad = CapacidadTxt.Text
                                    vSalon.Email = EmailTxt.Text
                                    vSalon.Telefono = TelefonoTxt.Text
                                    vSalon.Direccion = New Direccion(salon.Direccion.Id, CalleTxt.Text, NumeroTxt.Text, LocalidadTxt.Text)
                                    vSalon.Descripcion = DescripcionTxt.Text
                                    vSalon.Precio = PrecioTxt.Text
                                    vSalonDinamico.Modificacion(vSalon)
                                    Limpiar()
                                    Actualizar()
                                End If
                            Next
                        Else
                            Throw New Exception("El numero de telefono ingresado es incorrecto")
                        End If
                    Else
                        Throw New Exception("El email ingresado es incorrecto")
                    End If
                Else
                    Throw New Exception("Por favor complete todos los campos")
                End If
            Else
                Throw New Exception("Seleccione el salón que desea modificar")
            End If
        Catch ex As Exception
            MessageBox.Show(vTraductor.Traducir(ex.Message), "EvOrg")
        End Try
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
                    LocalidadTxt.Text = salon.Direccion.Localidad
                    PrecioTxt.Text = salon.Precio
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CapacidadTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CapacidadTxt.KeyPress
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

    Private Sub CalleTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CalleTxt.KeyPress
        If (Regex.IsMatch(e.KeyChar, "[0-9]")) Then e.KeyChar = Nothing
    End Sub

    Private Sub LocalidadTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LocalidadTxt.KeyPress
        If (Regex.IsMatch(e.KeyChar, "[0-9]")) Then e.KeyChar = Nothing
    End Sub
End Class