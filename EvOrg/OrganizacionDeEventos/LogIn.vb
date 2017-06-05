Imports BLL_Dinamica
Imports BLL_Estatica
Imports Framework
Public Class LogIn
    Dim vControladorLogin As ControladorLogIn = ControladorLogIn.GetInstance
    Dim vContador As Integer

    Private Sub AceptarBtn_Click(sender As Object, e As EventArgs) Handles AceptarBtn.Click
        Try
            If Not (UsuarioTxt.Text = "" And ContraseñaTxt.Text = "") Then
                If vControladorLogin.Aceptar(UsuarioTxt.Text, ContraseñaTxt.Text) Then
                    Me.Close()
                Else
                    UsuarioTxt.Text = ""
                    ContraseñaTxt.Text = ""
                End If
            Else
                MsgBox("Ingrese usuario y contraseña por favor")

                'If vContador = 3 Then
                'MsgBox("Desea restablecer su contraseña?")
                'End If
                'vContador += 1
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CancelarBtn_Click(sender As Object, e As EventArgs) Handles CancelarBtn.Click
        Me.Close()
    End Sub
End Class