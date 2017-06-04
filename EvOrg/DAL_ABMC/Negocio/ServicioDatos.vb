Imports DAL_ABMC
Imports BLL_Estatica
Imports DAL
Public Class ServicioDatos
    Implements IABMC

    Dim vServicio As New Servicio
    Public Sub Alta(Optional pObjeto As Object = Nothing) Implements IABMC.Alta
        Try
            If TypeOf pObjeto Is Servicio Then
                vServicio = DirectCast(pObjeto, Servicio)
                Dim DTable As DataTable = Comando.GetDataTable("Servicio")
                Dim DTDireccion As DataTable = Comando.GetDataTable("DireccionServicio")
                Dim DRDireccion As DataRow = DTDireccion.NewRow
                vServicio.Direccion.Id = GetDireccionId(DTDireccion)
                DRDireccion.ItemArray = {vServicio.Direccion.Id, vServicio.Direccion.Calle, vServicio.Direccion.Numero, vServicio.Direccion.CP}
                DTDireccion.Rows.Add(DRDireccion)
                Dim DRow As DataRow = DTable.NewRow
                DRow.ItemArray = {vServicio.Id, vServicio.Nombre, vServicio.Telefono, vServicio.Direccion.Id, vServicio.Email, vServicio.Observacion, vServicio.Precio}
                DTable.Rows.Add(DRow)
                Comando.ActualizarBD("DireccionServicio", DTDireccion)
                Comando.ActualizarBD("Servicio", DTable)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Function GetDireccionId(pDTable As DataTable) As Integer
        Dim vId As New Integer
        For Each DRow As DataRow In pDTable.Rows
            vId = DRow(0)
        Next
        Return vId + 1
    End Function

    Public Sub Baja(Optional pObjeto As Object = Nothing) Implements IABMC.Baja
        Try
            If TypeOf pObjeto Is Servicio Then
                vServicio = DirectCast(pObjeto, Servicio)
                Dim DTable As DataTable = Comando.GetData("SELECT * FROM Servicio WHERE Id = " & vServicio.Id)
                If DTable.Rows.Count > 0 Then DTable.Rows(0).Delete()
                Comando.ActualizarBD("Servicio", DTable)
            End If
        Catch ex As Exception
            MsgBox("Error al borrar el servicio seleccionado")
        End Try
    End Sub

    Public Sub Modificacion(Optional pObjeto As Object = Nothing) Implements IABMC.Modificacion
        Try
            If TypeOf pObjeto Is Servicio Then
                vServicio = DirectCast(pObjeto, Servicio)
                Dim DTable As DataTable = Comando.GetData("SELECT * FROM Servicio WHERE Id = " & vServicio.Id)
                Dim DTDireccion As DataTable = Comando.GetData("SELECT * FROM DireccionServicio WHERE Id = " & vServicio.Direccion.Id)
                Dim DRDireccion As DataRow = DTDireccion.NewRow
                DRDireccion.ItemArray = {vServicio.Direccion.Id, vServicio.Direccion.Calle, vServicio.Direccion.Numero, vServicio.Direccion.CP}
                If DTDireccion.Rows.Count > 0 Then DTDireccion.Rows(0).ItemArray = DRDireccion.ItemArray
                Dim DRow As DataRow = DTable.NewRow
                DRow.ItemArray = {vServicio.Id, vServicio.Nombre, vServicio.Telefono, vServicio.Direccion.Id, vServicio.Email, vServicio.Observacion, vServicio.Precio}
                If DTable.Rows.Count > 0 Then DTable.Rows(0).ItemArray = DRow.ItemArray
                Comando.ActualizarBD("DireccionServicio", DTDireccion)
                Comando.ActualizarBD("Servicio", DTable)
            End If
        Catch ex As Exception
            MsgBox("Error al modificar el servicio seleccionado")
        End Try
    End Sub

    Public Function ConsultaTodo() As List(Of Object) Implements IABMC.ConsultaTodo
        Dim ServicioLista As List(Of Object) = Nothing
        Try
            Dim DTable As DataTable = Comando.GetDataTable("Servicio")
            Dim DTDireccion As DataTable = Comando.GetDataTable("DireccionServicio")
            Dim Direccion As New Direccion
            ServicioLista = New List(Of Object)
            For Each DRow As DataRow In DTable.Rows
                For Each DRDireccion As DataRow In DTDireccion.Rows
                    If DRDireccion(0) = DRow(3) Then Direccion = New Direccion(DRDireccion(0), DRDireccion(1), DRDireccion(2), DRDireccion(3))
                Next
                ServicioLista.Add(New Servicio(DRow(0), DRow(1), DRow(2), Direccion, DRow(4), DRow(5), DRow(6)))
            Next
            Return ServicioLista
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class
