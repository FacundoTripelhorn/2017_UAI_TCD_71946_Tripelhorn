Imports BLL_Dinamica
Imports BLL_Estatica
Imports Framework
Public Class LogIn
    Property Usuario As New Usuario
    Property UsuarioDinamico As New UsuarioDinamico
    Property Base As New CrearBase
    Private Sub AceptarBtn_Click(sender As Object, e As EventArgs) Handles AceptarBtn.Click
        Dim vEncriptar As Encriptador = Encriptador.GetInstance
        Usuario.IdUsuario = UsuarioTxt.Text
        Usuario.Contraseña = vEncriptar.Encriptar(ContraseñaTxt.Text)

        If UsuarioDinamico.InicioSesion(Usuario, ContraseñaTxt.Text) = True Then
            MsgBox("Inicio exitoso")
            Dim vInicio As New Inicio(Usuario)
            vInicio.ShowDialog()
        Else
            ContraseñaTxt.Text = ""
            ErrorLinkLabel.Visible = True
        End If
    End Sub

    Private Sub LogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Base.CrearString()
        Base.CrearBD()
    End Sub
End Class