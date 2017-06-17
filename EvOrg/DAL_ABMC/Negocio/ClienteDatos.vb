Imports DAL_ABMC
Imports BLL_Estatica
Imports DAL
Public Class ClienteDatos
    Implements IABMC

    Dim vCliente As New Cliente

    Public Sub Alta(Optional pObjeto As Object = Nothing) Implements IABMC.Alta
        Try
            If TypeOf pObjeto Is Cliente Then
                vCliente = DirectCast(pObjeto, Cliente)
                Dim DTable As DataTable = Comando.GetDataTable("Cliente")
                Dim DRow As DataRow = DTable.NewRow
                DRow.ItemArray = {vCliente.DNI, vCliente.Nombre, vCliente.Apellido, vCliente.Telefono, vCliente.Email}
                DTable.Rows.Add(DRow)
                Comando.ActualizarBD("Cliente", DTable)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub Baja(Optional pObjeto As Object = Nothing) Implements IABMC.Baja
        Try
            If TypeOf pObjeto Is Cliente Then
                vCliente = DirectCast(pObjeto, Cliente)
                Dim DTable As DataTable = Comando.GetData("SELECT * FROM Cliente WHERE DNI = " & vCliente.DNI)
                If DTable.Rows.Count > 0 Then DTable.Rows(0).Delete()
                Comando.ActualizarBD("Cliente", DTable)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub Modificacion(Optional pObjeto As Object = Nothing) Implements IABMC.Modificacion
        Try
            If TypeOf pObjeto Is Cliente Then
                vCliente = DirectCast(pObjeto, Cliente)
                Dim DTable As DataTable = Comando.GetData("SELECT * FROM Cliente WHERE DNI = " & vCliente.DNI)
                Dim DRow As DataRow = DTable.NewRow
                DRow.ItemArray = {vCliente.DNI, vCliente.Nombre, vCliente.Apellido, vCliente.Telefono, vCliente.Email}
                If DTable.Rows.Count > 0 Then DTable.Rows(0).ItemArray = DRow.ItemArray
                Comando.ActualizarBD("Cliente", DTable)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Function ConsultaTodo() As List(Of Object) Implements IABMC.ConsultaTodo
        Dim ClienteLista As List(Of Object) = Nothing
        Try
            Dim DTable As DataTable = Comando.GetDataTable("Cliente")
            ClienteLista = New List(Of Object)
            For Each DRow As DataRow In DTable.Rows
                ClienteLista.Add(New Cliente(DRow(0), DRow(1), DRow(2), DRow(3), DRow(4)))
            Next
            Return ClienteLista
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class
