Imports System.Data.SqlClient
Public Class Comando
    Private Shared vObjComando As SqlCommand

    Private Shared Function ObjComando(pSelectCommand As String, pConexion As SqlConnection) As SqlCommand
        vObjComando = New SqlCommand
        vObjComando.CommandText = pSelectCommand
        vObjComando.CommandType = CommandType.Text
        vObjComando.Connection = pConexion
        Return vObjComando
    End Function

    Public Shared Function GetDataTable(pTablaNombre As String) As DataTable
        Dim DAdapter As New SqlDataAdapter
        Dim DTable As New DataTable
        DAdapter.SelectCommand = Comando.ObjComando("SELECT * FROM " & pTablaNombre, Conexion.ObjConexion())
        DAdapter.Fill(DTable)
        Return DTable
    End Function

    Public Shared Function GetData(pSelectCommand As String) As DataTable
        Dim DAdapter As New SqlDataAdapter
        Dim DTable As New DataTable
        DAdapter.SelectCommand = Comando.ObjComando(pSelectCommand, Conexion.ObjConexion())
        DAdapter.Fill(DTable)
        Return DTable
    End Function

    Public Shared Sub ActualizarBD(pTablaNombre As String, pDTable As DataTable)
        Dim DAdapter As New SqlDataAdapter
        DAdapter.SelectCommand = Comando.ObjComando("SELECT * FROM " & pTablaNombre, Conexion.ObjConexion())
        Dim CBuilder As New SqlCommandBuilder(DAdapter)
        DAdapter.InsertCommand = CBuilder.GetInsertCommand
        DAdapter.UpdateCommand = CBuilder.GetUpdateCommand
        DAdapter.DeleteCommand = CBuilder.GetDeleteCommand
        DAdapter.Update(pDTable)
    End Sub
End Class
