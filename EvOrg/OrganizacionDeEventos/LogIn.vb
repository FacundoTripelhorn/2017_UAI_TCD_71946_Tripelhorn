Imports BLL_Dinamica
Imports BLL_Estatica
Imports Framework
Imports OrganizacionDeEventos
Imports System.Text.RegularExpressions
Public Class LogIn
    Implements IObservador

    Dim vControladorLogin As ControladorLogIn = ControladorLogIn.GetInstance
    Dim vTraductor As Traductor = Traductor.GetInstance
    Dim vContador As Integer

    Private Sub AceptarBtn_Click(sender As Object, e As EventArgs) Handles AceptarBtn.Click
        Try
            If UsuarioTxt.Text <> "" And ContraseñaTxt.Text <> "" Then
                If Regex.IsMatch(UsuarioTxt.Text, "[a-zA-Z0-9]{6,18}") Then
                    If Regex.IsMatch(ContraseñaTxt.Text, "[a-zA-Z0-9]{6,16}") Then
                        If vControladorLogin.Aceptar(UsuarioTxt.Text, ContraseñaTxt.Text) Then
                            Me.Close()
                        Else
                            UsuarioTxt.Text = ""
                            ContraseñaTxt.Text = ""
                        End If
                    Else
                        MessageBox.Show(vTraductor.Traducir("La contraseña tiene que tener al menos 6 caracteres y solo puede contener letras y números"), "EvOrg")
                    End If
                Else
                    MessageBox.Show(vTraductor.Traducir("El nombre de usuario tiene que tener al menos 6 caracteres y solo puede contener letras y números"), "EvOrg")
                End If
            Else
                MessageBox.Show(vTraductor.Traducir("Ingrese usuario y contraseña por favor"), "EvOrg")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CancelarBtn_Click(sender As Object, e As EventArgs) Handles CancelarBtn.Click
        Me.Close()
    End Sub

    Private Sub LogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vTraductor.Registrar(Me)
        ActualizarObservador(Me)
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