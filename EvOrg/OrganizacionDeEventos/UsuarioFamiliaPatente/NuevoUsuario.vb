Imports BLL_Dinamica
Imports BLL_Estatica
Imports Framework
Imports System.Text.RegularExpressions
Imports OrganizacionDeEventos

Public Class NuevoUsuario
    Implements IObservador
    Dim vTraductor As Traductor = Traductor.GetInstance
    Property Familia As New Familia
    Property FamiliaDinamica As New FamiliaDinamica
    Property Usuario As New Usuario
    Property UsuarioDinamico As New UsuarioDinamico
    Property Modificacion As New Boolean

    Private Sub NuevoUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vTraductor.Registrar(Me)
        Dim vLista As List(Of Object) = FamiliaDinamica.ConsultaTodo
        For Each vFamilia As Familia In vLista
            FamiliaCombo.Items.Add(vFamilia.Nombre)
        Next
        If Modificacion = True Then
            IdUsuarioTxt.Text = Usuario.IdUsuario
            IdUsuarioTxt.Enabled = False
            EmailTxt.Text = Usuario.Email
        End If
        ActualizarObservador(Me)
    End Sub

    Private Sub AceptarBtn_Click(sender As Object, e As EventArgs) Handles AceptarBtn.Click
        Try
            Dim vEncriptar As Encriptador = Encriptador.GetInstance
            If IdUsuarioTxt.Text <> "" And ContraseñaTxt.Text <> "" And EmailTxt.Text <> "" And RContraseñaTxt.Text <> "" Then
                If ContraseñaTxt.Text = RContraseñaTxt.Text Then
                    If Regex.IsMatch(ContraseñaTxt.Text, "[a-zA-Z0-9]{6,16}") Then
                        If Regex.IsMatch(IdUsuarioTxt.Text, "[a-zA-Z0-9]{6,18}") Then
                            If Regex.IsMatch(EmailTxt.Text, "^[\w]+@{1}[\w]+\.[a-z]{2,3}$") Then
                                Usuario.IdUsuario = IdUsuarioTxt.Text
                                Usuario.Email = EmailTxt.Text
                                Usuario.Contraseña = vEncriptar.Encriptar(ContraseñaTxt.Text)
                                Dim vLista As List(Of Object) = FamiliaDinamica.ConsultaTodo
                                For Each vFamilia As Familia In vLista
                                    If vFamilia.Nombre = FamiliaCombo.Text Then Familia = vFamilia
                                Next
                                Usuario.Familia = Familia
                                If Modificacion Then
                                    UsuarioDinamico.Modificacion(Usuario)
                                Else
                                    Dim vCheckUsuario As Usuario = UsuarioDinamico.DevuelveUsuario(Usuario.IdUsuario)
                                    If vCheckUsuario Is Nothing Then
                                        UsuarioDinamico.Alta(Usuario)
                                    Else
                                        Throw New Exception("El nombre de usuario ingresado ya existe")
                                        ContraseñaTxt.Text = ""
                                        RContraseñaTxt.Text = ""
                                    End If
                                End If
                                Me.Close()
                            Else
                                Throw New Exception("El email ingresado es incorrecto")
                                ContraseñaTxt.Text = ""
                                RContraseñaTxt.Text = ""
                            End If
                        Else
                            Throw New Exception("El nombre de usuario tiene que tener al menos 6 caracteres y solo puede contener letras y números")
                            ContraseñaTxt.Text = ""
                            RContraseñaTxt.Text = ""
                        End If
                    Else
                        Throw New Exception("La contraseña tiene que tener al menos 6 caracteres y solo puede contener letras y números")
                        ContraseñaTxt.Text = ""
                        RContraseñaTxt.Text = ""
                    End If
                Else
                    Throw New Exception("Las contraseñas no coinciden")
                    ContraseñaTxt.Text = ""
                    RContraseñaTxt.Text = ""
                End If
            Else
                Throw New Exception("Ingrese los datos del usuario")
            End If
        Catch ex As Exception
            MessageBox.Show(vtraductor.traducir(ex.Message), "EvOrg")
        End Try

    End Sub

    Private Sub CancelarBtn_Click(sender As Object, e As EventArgs) Handles CancelarBtn.Click
        Me.Close()
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
End Class