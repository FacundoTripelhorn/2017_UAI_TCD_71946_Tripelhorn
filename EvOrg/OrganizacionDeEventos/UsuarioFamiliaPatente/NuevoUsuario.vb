﻿Imports BLL_Dinamica
Imports BLL_Estatica

Public Class NuevoUsuario
    Property Familia As New Familia
    Property FamiliaDinamica As New FamiliaDinamica
    Property Usuario As New Usuario
    Property UsuarioDinamico As New UsuarioDinamico
    Property Alta As New Boolean
    Private Sub NuevoUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim vLista As List(Of Object) = FamiliaDinamica.ConsultaTodo
        For Each vFamilia As Familia In vLista
            FamiliaCombo.Items.Add(vFamilia.Nombre)
        Next
        If Alta = False Then
            IdUsuarioTxt.Text = Usuario.IdUsuario
            IdUsuarioTxt.Enabled = False
            EmailTxt.Text = Usuario.Email
        End If

    End Sub

    Private Sub AceptarBtn_Click(sender As Object, e As EventArgs) Handles AceptarBtn.Click
        If ContraseñaTxt.Text = RContraseñaTxt.Text Then
            Usuario.IdUsuario = IdUsuarioTxt.Text
            Usuario.Email = EmailTxt.Text
            Usuario.Contraseña = ContraseñaTxt.Text
            Dim vLista As List(Of Object) = FamiliaDinamica.ConsultaTodo
            For Each vFamilia As Familia In vLista
                If vFamilia.Nombre = FamiliaCombo.Text Then Familia = vFamilia
            Next
            Usuario.Familia = Familia
            If Alta Then UsuarioDinamico.Alta(Usuario) Else UsuarioDinamico.Modificacion(Usuario)
            Dim ABMUsuario As New ABMUsuario
            ABMUsuario.Actualizar()
            Me.Close()
        End If
    End Sub


    Private Sub CancelarBtn_Click(sender As Object, e As EventArgs) Handles CancelarBtn.Click
        Me.Close()
    End Sub
End Class