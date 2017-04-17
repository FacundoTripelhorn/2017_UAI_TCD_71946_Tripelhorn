Public Class ABMSalon
    Private Sub ABMSalón_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EvOrgDataSet4.Salon' table. You can move, or remove it, as needed.
        Me.SalonTableAdapter.Fill(Me.EvOrgDataSet4.Salon)

    End Sub
End Class