Public Class ABMPaso
    Private Sub ABMPaso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EvOrgDataSet3.Paso' table. You can move, or remove it, as needed.
        Me.PasoTableAdapter.Fill(Me.EvOrgDataSet3.Paso)

    End Sub
End Class