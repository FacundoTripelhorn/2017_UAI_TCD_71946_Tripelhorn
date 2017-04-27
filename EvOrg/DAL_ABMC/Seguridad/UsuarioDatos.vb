Imports BLL_Estatica
Imports DAL_ABMC
Imports DAL

Public Class UsuarioDatos
    Implements IABMC

    Dim vUsuario As New Usuario

    Public Sub Alta(Optional pObjeto As Object = Nothing) Implements IABMC.Alta
        vUsuario = DirectCast(pObjeto, Usuario)
        Try
            Dim DTUsuario As DataTable = Comando.GetData("SELECT * FROM Usuario WHERE Id = '" & vUsuario.IdUsuario & "'")
            Dim DTFamilia As DataTable = Comando.GetData("SELECT * FROM Familia WHERE Id = '" & vUsuario.Familia.Id & "'")

            If DTUsuario.Rows.Count = 0 Then
                Dim DRow As DataRow = DTUsuario.NewRow
                DRow.ItemArray = {vUsuario.IdUsuario, vUsuario.Email, vUsuario.Contraseña, DTFamilia.Rows(0).Item(0)}
                DTUsuario.Rows.Add(DRow)
                Comando.ActualizarBD("Usuario", DTUsuario)
            End If
        Catch ex As Exception
            MsgBox("Error al agregar un nuevo usuario")
        End Try
    End Sub

    Public Sub Baja(Optional pObjeto As Object = Nothing) Implements IABMC.Baja
        vUsuario = DirectCast(pObjeto, Usuario)
        Try
            Dim DTUsuario As DataTable = Comando.GetData("SELECT * FROM Usuario WHERE Id = '" & vUsuario.IdUsuario & "' AND Password = '" & vUsuario.Contraseña & "'")
            If DTUsuario.Rows.Count > 0 Then DTUsuario.Rows(0).Delete()
            Comando.ActualizarBD("Usuario", DTUsuario)
        Catch ex As Exception
            MsgBox("Error al eliminar el usuario seleccionado")
        End Try
    End Sub

    Public Sub Modificacion(Optional pObjeto As Object = Nothing) Implements IABMC.Modificacion
        vUsuario = DirectCast(pObjeto, Usuario)
        Try
            Dim DTUsuario As DataTable = Comando.GetData("SELECT * FROM Usuario WHERE Id = '" & vUsuario.IdUsuario & "' AND Password = '" & vUsuario.Contraseña & "'")
            Dim DRow As DataRow = DTUsuario.NewRow
            DRow.ItemArray = {vUsuario.IdUsuario, vUsuario.Email, vUsuario.Contraseña, vUsuario.Familia.Id}
            If DTUsuario.Rows.Count > 0 Then DTUsuario.Rows(0).ItemArray = DRow.ItemArray
            Comando.ActualizarBD("Usuario", DTUsuario)
        Catch ex As Exception
            MsgBox("Error al eliminar el usuario seleccionado")
        End Try
    End Sub

    Public Function InicioSesion(Optional pObjeto As Object = Nothing) As Boolean
        vUsuario = DirectCast(pObjeto, Usuario)
        Try
            Dim DT As DataTable = Comando.GetData("SELECT * FROM Usuario WHERE Id = '" & vUsuario.IdUsuario & "' AND Password = '" & vUsuario.Contraseña & "'")

            If DT.Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function ConsultaTodo() As List(Of Object) Implements IABMC.ConsultaTodo
        Dim vLista As New List(Of Object)
        Try
            Dim DT As DataTable = Comando.GetDataTable("Usuario")
            If DT.Rows.Count > 0 Then
                For Each DR As DataRow In DT.Rows
                    Dim DTF As DataTable = Comando.GetData("SELECT * FROM Familia WHERE Id = " & DR.Item(3) & "")
                    vLista.Add(New Usuario(DR.Item(0), DR.Item(1), DR.Item(2), New Familia(DTF.Rows(0).Item(1))))
                Next
            End If
        Catch ex As Exception

        End Try
        Return vLista
    End Function

    Public Function DevuelveUsuario(pIdUsuario As String) As Object
        Try
            Dim DTUsuario As DataTable = Comando.GetData("SELECT * FROM Usuario WHERE Id = '" & pIdUsuario & "'")
            If DTUsuario.Rows.Count > 0 Then
                vUsuario.IdUsuario = pIdUsuario
                vUsuario.Email = DTUsuario.Rows(0).Item(1)
                vUsuario.Contraseña = DTUsuario.Rows(0).Item(2)
                Dim DTFamilia As DataTable = Comando.GetData("SELECT * FROM Familia WHERE Id = " & DTUsuario.Rows(0).Item(3))
                Dim vFamilia As New Familia(DTFamilia.Rows(0).Item(0), DTFamilia.Rows(0).Item(1))
                Dim vFamiliaDatos As New FamiliaDatos
                Dim vLista As List(Of Object) = vFamiliaDatos.ListarPatentes(vFamilia)
                For Each vPAbstracta As PatenteAbstracta In vLista
                    vFamilia.ListaPatentes.Add(vPAbstracta)
                Next
                vUsuario.Familia = vFamilia
            End If
        Catch ex As Exception

        End Try
        Return vUsuario
    End Function
End Class
