﻿Imports BLL_Dinamica
Imports BLL_Estatica
Imports Framework
Public Class ABMUsuario

    Property Usuario As New Usuario
    Property UsuarioDinamico As New UsuarioDinamico
    Property FamiliaDinamica As New FamiliaDinamica

    Private Sub ABMUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Actualizar()
    End Sub

    Public Sub Actualizar()
        Try
            Dim vLista As New List(Of VistaUsuario)
            For Each vUsuario As Usuario In UsuarioDinamico.ConsultaTodo
                vLista.Add(New VistaUsuario(vUsuario.IdUsuario, vUsuario.Email))
            Next
            GrillaUsuario.DataSource = Nothing
            GrillaUsuario.DataSource = vLista
            GrillaUsuario.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AltaBtn_Click(sender As Object, e As EventArgs) Handles AltaBtn.Click
        Dim vNuevoUsuario As New NuevoUsuario
        vNuevoUsuario.Modificacion = False
        vNuevoUsuario.ShowDialog()
        Actualizar()
    End Sub

    Private Sub BajaBtn_Click(sender As Object, e As EventArgs) Handles BajaBtn.Click
        Usuario.IdUsuario = DirectCast(GrillaUsuario.SelectedRows(0).DataBoundItem, VistaUsuario).Nombre
        For Each vUsuario As Usuario In UsuarioDinamico.ConsultaTodo
            If vUsuario.IdUsuario = Usuario.IdUsuario Then Usuario = vUsuario
        Next
        UsuarioDinamico.Baja(Usuario)
        Actualizar()
    End Sub

    Private Sub ModificacionBtn_Click(sender As Object, e As EventArgs) Handles ModificacionBtn.Click
        Usuario.IdUsuario = DirectCast(GrillaUsuario.SelectedRows(0).DataBoundItem, VistaUsuario).Nombre
        For Each vUsuario As Usuario In UsuarioDinamico.ConsultaTodo
            If vUsuario.IdUsuario = Usuario.IdUsuario Then Usuario = vUsuario
        Next
        For Each vFamilia As Familia In FamiliaDinamica.ConsultaTodo
            If vFamilia.Nombre = Usuario.Familia.Nombre Then
                Usuario.Familia = vFamilia
            End If
        Next
        Dim vNuevoUsuario As New NuevoUsuario
        vNuevoUsuario.Modificacion = True
        vNuevoUsuario.Usuario = Usuario
        vNuevoUsuario.ShowDialog()
    End Sub
End Class