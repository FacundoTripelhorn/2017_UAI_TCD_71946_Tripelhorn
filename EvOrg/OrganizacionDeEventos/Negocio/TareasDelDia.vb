Public Class TareasDelDia
    Private Sub TareasDelDia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Tareas del día " & Today.Day & "/" & Today.Month & "/" & Today.Year
    End Sub
End Class