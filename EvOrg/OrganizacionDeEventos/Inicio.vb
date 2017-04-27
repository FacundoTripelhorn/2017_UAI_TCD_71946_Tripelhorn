Imports BLL_Estatica
Imports BLL_Dinamica
Public Class Inicio

    Property Usuario As New Usuario
    Property FamiliaDinamica As New FamiliaDinamica
    Property GrupoPatenteDinamico As New GrupoPatenteDinamico

    Sub New(Optional pUsuario As Usuario = Nothing)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If Not pUsuario Is Nothing Then
            Usuario = pUsuario
        End If
    End Sub

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GrupoPatenteDinamico.MostrarEnMenuStrip(MenuStrip1, Usuario, Me)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ABMUsuario.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ABMFamilia.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ABMPatente.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ABMMaterial.ShowDialog()
    End Sub
End Class