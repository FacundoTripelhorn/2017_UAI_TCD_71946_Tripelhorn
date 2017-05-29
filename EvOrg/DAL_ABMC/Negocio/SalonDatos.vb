Imports DAL_ABMC
Imports BLL_Estatica
Imports DAL
Public Class SalonDatos
    Implements IABMC

    Dim vSalon As Salon
    Public Sub Alta(Optional pObjeto As Object = Nothing) Implements IABMC.Alta
        Try
            If TypeOf pObjeto Is Salon Then
                vSalon = DirectCast(pObjeto, Salon)
                Dim DTSalon As DataTable = Comando.GetDataTable("Salon")
                Dim DTDireccion As DataTable = Comando.GetDataTable("DireccionSalon")
                Dim DRDireccion As DataRow = DTDireccion.NewRow
                vSalon.Direccion.Id = GetDireccionId(DTDireccion)
                DRDireccion.ItemArray = {vSalon.Direccion.Id, vSalon.Direccion.Calle, vSalon.Direccion.Numero, vSalon.Direccion.CP}
                DTDireccion.Rows.Add(DRDireccion)
                Dim DRSalon As DataRow = DTSalon.NewRow
                DRSalon.ItemArray = {vSalon.Id, vSalon.Nombre, vSalon.Capacidad, vSalon.Email, vSalon.Telefono, vSalon.Direccion.Id, vSalon.Descripcion}
                DTSalon.Rows.Add(DRSalon)
                Comando.ActualizarBD("DireccionSalon", DTDireccion)
                Comando.ActualizarBD("Salon", DTSalon)
            End If
        Catch ex As Exception
            MsgBox("Error al agregar un nuevo Salon")
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
            If TypeOf pObjeto Is Salon Then
                vSalon = DirectCast(pObjeto, Salon)
                Dim DTable As DataTable = Comando.GetData("SELECT * FROM Salon WHERE Id = " & vSalon.Id)
                If DTable.Rows.Count > 0 Then DTable.Rows(0).Delete()
                Comando.ActualizarBD("Salon", DTable)
            End If
        Catch ex As Exception
            MsgBox("Error al borrar el salon seleccionado")
        End Try
    End Sub

    Public Sub Modificacion(Optional pObjeto As Object = Nothing) Implements IABMC.Modificacion
        Try
            If TypeOf pObjeto Is Salon Then
                vSalon = DirectCast(pObjeto, Salon)
                Dim DTable As DataTable = Comando.GetData("SELECT * FROM Salon WHERE Id = " & vSalon.Id)
                Dim DTDireccion As DataTable = Comando.GetData("SELECT * FROM DireccionSalon WHERE Id = " & vSalon.Direccion.Id)
                Dim DRDireccion As DataRow = DTDireccion.NewRow
                DRDireccion.ItemArray = {vSalon.Direccion.Id, vSalon.Direccion.Calle, vSalon.Direccion.Numero, vSalon.Direccion.CP}
                If DTDireccion.Rows.Count > 0 Then DTDireccion.Rows(0).ItemArray = DRDireccion.ItemArray
                Dim DRow As DataRow = DTable.NewRow
                DRow.ItemArray = {vSalon.Id, vSalon.Nombre, vSalon.Capacidad, vSalon.Email, vSalon.Telefono, vSalon.Direccion.Id, vSalon.Descripcion}
                If DTable.Rows.Count > 0 Then DTable.Rows(0).ItemArray = DRow.ItemArray
                Comando.ActualizarBD("DireccionSalon", DTDireccion)
                Comando.ActualizarBD("Salon", DTable)
            End If
        Catch ex As Exception
            MsgBox("Error al modificar el salón seleccionado")
        End Try
    End Sub

    Public Function ConsultaTodo() As List(Of Object) Implements IABMC.ConsultaTodo
        Dim SalonLista As List(Of Object) = Nothing
        Try
            Dim DTable As DataTable = Comando.GetDataTable("Salon")
            Dim DTDireccion As DataTable = Comando.GetDataTable("DireccionSalon")
            Dim Direccion As New Direccion
            SalonLista = New List(Of Object)
            For Each DRow As DataRow In DTable.Rows
                For Each DRDireccion As DataRow In DTDireccion.Rows
                    If DRDireccion(0) = DRow(5) Then Direccion = New Direccion(DRDireccion(0), DRDireccion(1), DRDireccion(2), DRDireccion(3))
                Next
                SalonLista.Add(New Salon(DRow(0), DRow(1), DRow(2), DRow(3), DRow(4), Direccion, DRow(6)))
            Next
            Return SalonLista
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class
