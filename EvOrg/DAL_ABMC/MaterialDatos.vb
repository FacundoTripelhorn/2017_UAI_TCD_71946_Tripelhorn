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

                DRow.ItemArray = {vMaterial.Id, vMaterial.Nombre, vMaterial.Cantidad}
                DTable.Rows.Add(DRow)
                Comando.ActualizarBD("Material", DTable)
            End If
        Catch ex As Exception
            MsgBox("ERROR AL INGRESAR EL MATERIAL")
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
            MsgBox("ERROR AL BORRAR EL MATERIAL")
        End Try
    End Sub

    Public Sub Modificacion(Optional pObjeto As Object = Nothing) Implements IABMC.Modificacion
        Try
            If TypeOf pObjeto Is Material Then
                vMaterial = DirectCast(pObjeto, Material)
                Dim DTable As DataTable = Comando.GetData("SELECT * FROM Material WHERE Id = '" & vMaterial.Id & "'")
                Dim DRow As DataRow = DTable.NewRow
                DRow.ItemArray = {vMaterial.Id, vMaterial.Nombre, vMaterial.Cantidad}
                If DTable.Rows.Count > 0 Then DTable.Rows(0).ItemArray = DRow.ItemArray
                Comando.ActualizarBD("Material", DTable)
                ConsultaTodo()
            End If
        Catch ex As Exception
            MsgBox("ERROR AL MODIFICAR EL MATERIAL")
        End Try
    End Sub

    Public Function ConsultaTodo() As List(Of Object) Implements IABMC.ConsultaTodo
        Dim MaterialLista As List(Of Object) = Nothing
        Try
            Dim DTable As DataTable = Comando.GetDataTable("Material")
            MaterialLista = New List(Of Object)
            If DTable.Rows.Count > 0 Then
                For Each DRow As DataRow In DTable.Rows
                    MaterialLista.Add(New Material(DRow.Item(0), DRow.Item(1), DRow.Item(2)))
                Next
            End If
            Return MaterialLista
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class
