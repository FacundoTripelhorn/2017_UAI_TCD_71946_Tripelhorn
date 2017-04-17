Public Class o
    Private Sub o_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EvOrgDataSet6.Servicio' table. You can move, or remove it, as needed.
        Me.ServicioTableAdapter1.Fill(Me.EvOrgDataSet6.Servicio)
        'TODO: This line of code loads data into the 'EvOrgDataSet5.Servicio' table. You can move, or remove it, as needed.
        Me.ServicioTableAdapter.Fill(Me.EvOrgDataSet5.Servicio)

    End Sub
End Class