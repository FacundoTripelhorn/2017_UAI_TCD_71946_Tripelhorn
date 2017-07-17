Imports DAL_ABMC
Imports BLL_Estatica
Imports DAL
Public Class ClienteDatos
    Implements IABMC

    Dim vCliente As New Cliente
    Dim vEventoDatos As New EventoDatos

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
                Dim DTEvento As DataTable = Comando.GetData("SELECT * FROM Evento WHERE Cliente = " & vCliente.DNI)
                Dim vListaEventos As List(Of Object) = vEventoDatos.ConsultaTodo
                If DTEvento.Rows.Count > 0 Then
                    For Each DRow As DataRow In DTEvento.Rows
                        For Each Evento In vListaEventos
                            If DirectCast(Evento, Evento).Id = DRow(0) Then
                                vEventoDatos.Baja(Evento)
                            End If
                        Next
                    Next
                End If
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

    Public Function GetCliente(pDNI As Integer) As Cliente
        Dim vCliente As New Cliente
        Try
            Dim DTable As DataTable = Comando.GetData("SELECT * FROM Cliente WHERE DNI = " & pDNI)
            If DTable.Rows.Count > 0 Then
                vCliente.DNI = pDNI
                vCliente.Nombre = DTable.Rows(0).Item(1)
                vCliente.Apellido = DTable.Rows(0).Item(2)
                vCliente.Telefono = DTable.Rows(0).Item(3)
                vCliente.Email = DTable.Rows(0).Item(4)
            End If
            Return vCliente
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function CheckCliente(pDNI As Integer) As Boolean
        Dim DTable As DataTable = Comando.GetData("SELECT * FROM Cliente WHERE DNI = " & pDNI)
        If DTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function CheckEventosCliente(pDNI As Integer) As Boolean
        Dim DTable As DataTable = Comando.GetData("SELECT * FROM Evento WHERE Cliente = " & pDNI)
        If DTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
