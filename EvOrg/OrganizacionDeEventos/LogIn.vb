Imports BLL_Dinamica
Imports BLL_Estatica
Imports Framework
Public Class LogIn
    Dim vControladorLogin As ControladorLogIn = ControladorLogIn.GetInstance

    Private Sub AceptarBtn_Click(sender As Object, e As EventArgs) Handles AceptarBtn.Click
        Try
            If Not (UsuarioTxt.Text = "" And ContraseñaTxt.Text = "") Then
                If vControladorLogin.Aceptar(UsuarioTxt.Text, ContraseñaTxt.Text) Then
                    Me.Close()
                Else
                    UsuarioTxt.Text = ""
                    ContraseñaTxt.Text = ""
                    ErrorLinkLabel.Visible = True
                End If
            Else
                MsgBox("Ingrese usuario y contraseña por favor")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ErrorLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ErrorLinkLabel.LinkClicked
        MessageBox.Show("Por favor vuelva a ingresar usuario y contraseña", "Error")
    End Sub
End Class