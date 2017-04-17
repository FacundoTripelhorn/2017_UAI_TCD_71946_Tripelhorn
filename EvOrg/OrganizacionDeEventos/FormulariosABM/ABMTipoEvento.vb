Public Class ABMTipoEvento
    Private Sub ABMTipoEvento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EvOrgDataSet8.Paso' table. You can move, or remove it, as needed.
        Me.PasoTableAdapter.Fill(Me.EvOrgDataSet8.Paso)
        'TODO: This line of code loads data into the 'EvOrgDataSet7.TipoEvento' table. You can move, or remove it, as needed.
        Me.TipoEventoTableAdapter.Fill(Me.EvOrgDataSet7.TipoEvento)

    End Sub
End Class