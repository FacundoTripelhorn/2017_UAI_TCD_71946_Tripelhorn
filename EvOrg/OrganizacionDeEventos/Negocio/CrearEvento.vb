Imports BLL_Dinamica
Imports BLL_Estatica
Public Class CrearEvento

    Dim vEvento As New Evento
    Dim vEventoDinamico As EventoDinamico

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        SeleccionarSalon.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        vEvento.Nombre = "Cumple de Juanito"
        Dim Pasos As New ABMPaso(vEvento)
        Pasos.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ReservarMaterial As New ReservarMaterial(vEvento)
        ReservarMaterial.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ReservarServicio.Show()
    End Sub
End Class