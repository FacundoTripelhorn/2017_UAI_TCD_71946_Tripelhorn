Imports BLL_Dinamica
Imports BLL_Estatica
Public Class LogIn
    Property Usuario As New Usuario
    Property UsuarioDinamico As New UsuarioDinamico
    Private Sub AceptarBtn_Click(sender As Object, e As EventArgs) Handles AceptarBtn.Click
        Usuario.IdUsuario = UsuarioTxt.Text
        Usuario.Contraseña = ContraseñaTxt.Text

        If UsuarioDinamico.InicioSesion(Usuario) = True Then
            MsgBox("Inicio exitoso")
            Dim vInicio As New Inicio(Usuario)
            vInicio.ShowDialog()
        Else
            ContraseñaTxt.Text = ""
            ErrorLinkLabel.Visible = True
        End If
    End Sub


End Class