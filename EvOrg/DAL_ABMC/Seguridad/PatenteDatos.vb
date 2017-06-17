Imports BLL_Estatica
Imports DAL_ABMC
Imports DAL

Public Class PatenteDatos
    Implements IABMC

    Dim vPatente As Patente

    Public Sub Alta(Optional pObjeto As Object = Nothing) Implements IABMC.Alta
        vPatente = DirectCast(pObjeto, Patente)
        Try
            Dim DTPatente As DataTable = Comando.GetDataTable("Patente")
            Dim DRow As DataRow = DTPatente.NewRow
            DRow.ItemArray = {vPatente.Id, vPatente.Nombre, vPatente.Formulario, vPatente.Padre}
            DTPatente.Rows.Add(DRow)
            Comando.ActualizarBD("Patente", DTPatente)
        Catch ex As Exception
        End Try
    End Sub

    Public Sub Baja(Optional pObjeto As Object = Nothing) Implements IABMC.Baja
        vPatente = DirectCast(pObjeto, Patente)
        Try
            Dim DTPatente As DataTable = Comando.GetData("SELECT * FROM Patente WHERE Id = '" & vPatente.Id & "'")
            Dim DTFPatente As DataTable
            For Each DRow As DataRow In DTPatente.Rows
                DTFPatente = Comando.GetData("SELECT * FROM FamiliaPatente WHERE Patente = '" & vPatente.Id & "'")
                For Each DRow2 As DataRow In DTFPatente.Rows
                    DRow2.Delete()
                Next
                Comando.ActualizarBD("FamiliaPatente", DTFPatente)
                DRow.Delete()
            Next

            If DTPatente.Rows.Count > 0 Then DTPatente.Rows(0).Delete()
            Comando.ActualizarBD("Patente", DTPatente)
        Catch ex As Exception
        End Try
    End Sub

    Public Sub Modificacion(Optional pObjeto As Object = Nothing) Implements IABMC.Modificacion
        vPatente = DirectCast(pObjeto, Patente)
        Try
            Dim DTPatente As DataTable = Comando.GetData("SELECT * FROM Patente WHERE Id = '" & vPatente.Id & "'")
            Dim DRow As DataRow = DTPatente.NewRow
            DRow.ItemArray = {vPatente.Id, vPatente.Nombre, vPatente.Formulario, vPatente.Padre}
            If DTPatente.Rows.Count > 0 Then DTPatente.Rows(0).ItemArray = DRow.ItemArray
            Comando.ActualizarBD("Patente", DTPatente)
        Catch ex As Exception
        End Try
    End Sub

    Public Function ConsultaTodo() As List(Of Object) Implements IABMC.ConsultaTodo
        Dim vLista As New List(Of Object)
        Dim DT As DataTable = Comando.GetDataTable("Patente")
        If DT.Rows.Count > 0 Then
            For Each DR As DataRow In DT.Rows
                vLista.Add(New Patente(DR.Item(0), DR.Item(1), DR.Item(2), DR.Item(3)))
            Next
        End If
        Return vLista
    End Function
End Class
