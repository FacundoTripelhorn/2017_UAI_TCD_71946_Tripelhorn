Imports DAL_ABMC
Imports BLL_Estatica
Imports DAL

Public Class GrupoPatenteDatos
    Implements IABMC
    Dim vGrupoPatente As GrupoPatente

    Public Sub Alta(Optional pObjeto As Object = Nothing) Implements IABMC.Alta
        If TypeOf pObjeto Is GrupoPatente Then
            vGrupoPatente = DirectCast(pObjeto, GrupoPatente)
        End If

        Try
            Dim DTGPatente As DataTable = Comando.GetDataTable("GrupoPatente")
            Dim DRow As DataRow = DTGPatente.NewRow
            DRow.ItemArray = {vGrupoPatente.Id, vGrupoPatente.Nombre, vGrupoPatente.Padre}
            DTGPatente.Rows.Add(DRow)
            Comando.ActualizarBD("GrupoPatente", DTGPatente)
        Catch ex As Exception
            MsgBox("Error al crear el GrupoPatente")
        End Try
    End Sub

    Public Sub Baja(Optional pObjeto As Object = Nothing) Implements IABMC.Baja
        If TypeOf pObjeto Is GrupoPatente Then
            vGrupoPatente = DirectCast(pObjeto, GrupoPatente)
        End If

        Try
            Dim DTGPatente As DataTable = Comando.GetDataTable("SELECT * FROM GrupoPatente WHERE Id = '" & vGrupoPatente.Id & "'")
            If DTGPatente.Rows.Count > 0 Then
                If Not vGrupoPatente.ListaPatentes Is Nothing Then
                    BajaHijosPatente(vGrupoPatente.Id)
                    BajaHijosGrupoPatente(vGrupoPatente.Id)
                End If
                DTGPatente.Rows(0).Delete()
            End If
            Comando.ActualizarBD("GrupoPatente", DTGPatente)
        Catch ex As Exception
            MsgBox("Error al eliminar el GrupoPatente")
        End Try
    End Sub

    Private Sub BajaHijosPatente(pPadreId As Integer)
        Try
            Dim DTPatente As DataTable = Comando.GetData("SELECT * FROM Patente WHERE Padre = '" & pPadreId & "'")
            For Each DRowP As DataRow In DTPatente.Rows
                Dim DTFPatente As DataTable = Comando.GetData("SELECT * FROM FamiliaPatente WHERE Patente = '" & DRowP.Item(0) & "'")
                For Each DRowFP As DataRow In DTFPatente.Rows
                    DRowFP.Delete()
                Next
                Comando.ActualizarBD("FamiliaPatente", DTFPatente)
                DRowP.Delete()
            Next
            Comando.ActualizarBD("Patente", DTPatente)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BajaHijosGrupoPatente(pPadreId As Integer)
        Try
            Dim DTGPatente As DataTable = Comando.GetData("SELECT * FROM GrupoPatente WHERE Padre = '" & pPadreId & "'")
            For Each DRowGP As DataRow In DTGPatente.Rows
                Dim DTFGPatente As DataTable = Comando.GetData("SELECT * FROM FamiliaGrupoPatente WHERE GrupoPatente = '" & DRowGP.Item(0) & "'")
                For Each DRowFGP As DataRow In DTFGPatente.Rows
                    DRowFGP.Delete()
                Next
                Comando.ActualizarBD("FamiliaGrupoPatente", DTFGPatente)
                DRowGP.Delete()
            Next
            Comando.ActualizarBD("GrupoPatente", DTGPatente)
        Catch ex As Exception

        End Try
    End Sub
    Public Sub Modificacion(Optional pObjeto As Object = Nothing) Implements IABMC.Modificacion
        If TypeOf pObjeto Is GrupoPatente Then
            vGrupoPatente = DirectCast(pObjeto, GrupoPatente)
        End If

        Try
            Dim DTGPatente As DataTable = Comando.GetData("SELECT * FROM GrupoPatente WHERE Id = '" & vGrupoPatente.Id & "'")
            Dim DRow As DataRow = DTGPatente.NewRow
            DRow.Item(0) = vGrupoPatente.Id
            DRow.Item(1) = vGrupoPatente.Nombre
            If DTGPatente.Rows.Count > 0 Then DTGPatente.Rows(0).ItemArray = DRow.ItemArray
            Comando.ActualizarBD("GrupoPatente", DTGPatente)
        Catch ex As Exception
            MsgBox("Error al modificar el GrupoPatente")
        End Try
    End Sub

    Public Function ConsultaTodo() As List(Of Object) Implements IABMC.ConsultaTodo
        Dim vLista As New List(Of Object)
        Dim DT As DataTable = Comando.GetDataTable("GrupoPatente")
        If DT.Rows.Count > 0 Then
            For Each DR As DataRow In DT.Rows
                If TypeOf DR.Item(2) Is DBNull Then
                    Dim Padre As New GrupoPatente(DR.Item(0), DR.ItemArray(1))
                    vLista.Add(Padre)
                    AgregarHijosPatente(Padre)
                    AgregarHijosGrupoPatente(Padre)
                Else
                    Continue For
                End If
            Next
        End If
        Return vLista
    End Function

    Public Function Listar() As List(Of PatenteAbstracta)
        Dim vLista As New List(Of PatenteAbstracta)
        Dim DT As DataTable = Comando.GetDataTable("GrupoPatente")
        If DT.Rows.Count > 0 Then
            For Each DR As DataRow In DT.Rows
                If TypeOf DR.Item(2) Is DBNull Then
                    Dim Padre As New GrupoPatente(DR.Item(0), DR.ItemArray(1))
                    vLista.Add(Padre)
                    AgregarHijosPatente(Padre)
                    AgregarHijosGrupoPatente(Padre)
                Else
                    Continue For
                End If
            Next
        End If
        Return vLista
    End Function

    Private Sub AgregarHijosPatente(pPadre As GrupoPatente)
        Try
            Dim DTPatente As DataTable = Comando.GetData("SELECT * FROM Patente WHERE Padre = '" & pPadre.Id & "'")
            If DTPatente.Rows.Count > 0 Then
                For Each DRow As DataRow In DTPatente.Rows
                    pPadre.ListaPatentes.Add(New Patente(DRow.Item(0), DRow.Item(1), DRow.Item(2), DRow.Item(3)))
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AgregarHijosGrupoPatente(pPadre As GrupoPatente)
        Try
            Dim DTGPatente As DataTable = Comando.GetData("SELECT * FROM GrupoPatente WHERE Padre = '" & pPadre.Id & "'")
            If DTGPatente.Rows.Count > 0 Then
                For Each DRow As DataRow In DTGPatente.Rows
                    Dim vGPatente As New GrupoPatente(DRow.Item(0), DRow.Item(1), DRow.Item(2))
                    pPadre.ListaPatentes.Add(vGPatente)
                    AgregarHijosPatente(vGPatente)
                    AgregarHijosGrupoPatente(vGPatente)
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
