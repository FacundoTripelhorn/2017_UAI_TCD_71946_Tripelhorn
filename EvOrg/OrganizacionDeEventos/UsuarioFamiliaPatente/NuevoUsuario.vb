Imports BLL_Dinamica
Imports BLL_Estatica
Imports Framework
Imports System.Text.RegularExpressions
Public Class NuevoUsuario
    Property Familia As New Familia
    Property FamiliaDinamica As New FamiliaDinamica
    Property Usuario As New Usuario
    Property UsuarioDinamico As New UsuarioDinamico
    Property Modificacion As New Boolean

    Private Sub NuevoUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim vLista As List(Of Object) = FamiliaDinamica.ConsultaTodo
        For Each vFamilia As Familia In vLista
            FamiliaCombo.Items.Add(vFamilia.Nombre)
        Next
        If Modificacion = True Then
            IdUsuarioTxt.Text = Usuario.IdUsuario
            IdUsuarioTxt.Enabled = False
            EmailTxt.Text = Usuario.Email
        End If
    End Sub

    Private Sub AceptarBtn_Click(sender As Object, e As EventArgs) Handles AceptarBtn.Click
        Dim vEncriptar As Encriptador = Encriptador.GetInstance
        If ContraseñaTxt.Text = RContraseñaTxt.Text And Regex.IsMatch(ContraseñaTxt.Text, "[a-zA-Z0-9._]{6,16}") And Regex.IsMatch(RContraseñaTxt.Text, "[a-zA-Z0-9._]{6,16}") Then
            If Regex.IsMatch(IdUsuarioTxt.Text, "[a-zA-Z0-9_.]{6,18}") Then
                If Regex.IsMatch(EmailTxt.Text, "^[\w]+@{1}[\w]+\.[a-z]{2,3}$") Then
                    Usuario.IdUsuario = IdUsuarioTxt.Text
                    Usuario.Email = EmailTxt.Text
                    Usuario.Contraseña = vEncriptar.Encriptar(ContraseñaTxt.Text)
                    Dim vLista As List(Of Object) = FamiliaDinamica.ConsultaTodo
                    For Each vFamilia As Familia In vLista
                        If vFamilia.Nombre = FamiliaCombo.Text Then Familia = vFamilia
                    Next
                    Usuario.Familia = Familia
                    If Modificacion Then UsuarioDinamico.Modificacion(Usuario) Else UsuarioDinamico.Alta(Usuario)
                    Me.Close()
                Else
                    MsgBox("El email ingresado es incorrecto")
                End If
            Else
                MsgBox("El nombre de usuario es incorrecto")
            End If
        Else
            MsgBox("Las contraseña es incorrecta")
            ContraseñaTxt.Text = ""
            RContraseñaTxt.Text = ""
        End If
    End Sub

    Private Sub CancelarBtn_Click(sender As Object, e As EventArgs) Handles CancelarBtn.Click
        Me.Close()
    End Sub


End Class