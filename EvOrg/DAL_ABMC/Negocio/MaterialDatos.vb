Imports DAL
Imports BLL_Estatica
Imports DAL_ABMC

Public Class MaterialDatos
    Implements IABMC

    Dim vMaterial As Material
    Public Sub Alta(Optional pObjeto As Object = Nothing) Implements IABMC.Alta
        Try
            If TypeOf pObjeto Is Material Then
                vMaterial = pObjeto
                Dim DTable As DataTable = Comando.GetDataTable("Material")
                Dim DRow As DataRow = DTable.NewRow

                DRow.ItemArray = {vMaterial.Id, vMaterial.Nombre, vMaterial.Cantidad, vMaterial.Precio}
                DTable.Rows.Add(DRow)
                Comando.ActualizarBD("Material", DTable)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub AltaMaterialTemporal(pMaterial As Material)
        Try
            Dim DTable As DataTable = Comando.GetDataTable("MaterialTemporal")
            Dim DRow As DataRow = DTable.NewRow

            DRow.ItemArray = {pMaterial.Id, pMaterial.Nombre}
            DTable.Rows.Add(DRow)
            Comando.ActualizarBD("MaterialTemporal", DTable)
        Catch ex As Exception
        End Try
    End Sub

    Public Sub Baja(Optional pObjeto As Object = Nothing) Implements IABMC.Baja
        Try
            If TypeOf pObjeto Is Material Then
                vMaterial = DirectCast(pObjeto, Material)
                Dim DTable As DataTable = Comando.GetData("SELECT * FROM Material WHERE Id = '" & vMaterial.Id & "'")
                If DTable.Rows.Count > 0 Then DTable.Rows(0).Delete()
                Comando.ActualizarBD("Material", DTable)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub Modificacion(Optional pObjeto As Object = Nothing) Implements IABMC.Modificacion
        Try
            If TypeOf pObjeto Is Material Then
                vMaterial = DirectCast(pObjeto, Material)
                Dim DTable As DataTable = Comando.GetData("SELECT * FROM Material WHERE Id = '" & vMaterial.Id & "'")
                Dim DRow As DataRow = DTable.NewRow
                DRow.ItemArray = {vMaterial.Id, vMaterial.Nombre, vMaterial.Cantidad, vMaterial.Precio}
                If DTable.Rows.Count > 0 Then DTable.Rows(0).ItemArray = DRow.ItemArray
                Comando.ActualizarBD("Material", DTable)
                ConsultaTodo()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Function ConsultaTodo() As List(Of Object) Implements IABMC.ConsultaTodo
        Dim MaterialLista As List(Of Object) = Nothing
        Try
            Dim DTable As DataTable = Comando.GetDataTable("Material")
            Dim DTMT As DataTable = Comando.GetDataTable("MaterialTemporal")
            MaterialLista = New List(Of Object)
            If DTable.Rows.Count > 0 Or DTMT.Rows.Count > 0 Then
                For Each DRow As DataRow In DTable.Rows
                    MaterialLista.Add(New Material(DRow(0), DRow(1), DRow(2), Decimal.Parse(DRow(3))))
                Next
                For Each DRow As DataRow In DTMT.Rows
                    MaterialLista.Add(New Material(DRow(0), DRow(1), 0, 0))
                Next
            End If
            Return MaterialLista
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function ConsultaReservas() As List(Of Material)
        Dim MaterialLista As New List(Of Material)
        Try
            Dim DTable As DataTable = Comando.GetDataTable("Material")
            Dim DTReserva As DataTable = Comando.GetDataTable("ReservaMaterial")
            Dim DTEvento As DataTable = Comando.GetDataTable("Evento")
            DTEvento.PrimaryKey = {DTEvento.Columns(0)}
            If DTReserva.Rows.Count > 0 Then
                For Each Drow As DataRow In DTable.Rows
                    For Each DRReserva As DataRow In DTReserva.Rows
                        If Drow(0) = DRReserva(1) Then
                            MaterialLista.Add(New Material(Drow(0), Drow(1), DRReserva(2), Date.Parse(DRReserva(3)), DTEvento.Rows.Find(DRReserva(0)).Item(2)))
                        End If
                    Next
                Next
            End If
            Return MaterialLista
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class
