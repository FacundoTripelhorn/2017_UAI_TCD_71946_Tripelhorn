Imports BLL_Estatica
Imports DAL
Imports DAL_ABMC

Public Class TipoEventoDatos
    Implements IABMC

    Dim vTipoEvento As New TipoEvento
    Public Sub Alta(Optional pObjeto As Object = Nothing) Implements IABMC.Alta
        Try
            If TypeOf pObjeto Is TipoEvento Then
                vTipoEvento = DirectCast(pObjeto, TipoEvento)
                Dim DTTE As DataTable = Comando.GetDataTable("TipoEvento")
                Dim DRow As DataRow = DTTE.NewRow
                DRow.ItemArray = {vTipoEvento.Id, vTipoEvento.Nombre, vTipoEvento.Descripcion}
                DTTE.Rows.Add(DRow)
                Comando.ActualizarBD("TipoEvento", DTTE)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub Baja(Optional pObjeto As Object = Nothing) Implements IABMC.Baja
        Try
            If TypeOf pObjeto Is TipoEvento Then
                vTipoEvento = DirectCast(pObjeto, TipoEvento)
                Dim DTTE As DataTable = Comando.GetData("SELECT * FROM TipoEvento WHERE Id = " & vTipoEvento.Id)
                If DTTE.Rows.Count > 0 Then DTTE.Rows(0).Delete()
                Dim DTP As DataTable = Comando.GetDataTable("Paso")
                For Each DRow As DataRow In DTP.Rows
                    For Each Paso As Paso In vTipoEvento.ListaPasos
                        If DRow(0) = Paso.Id Then DRow.Delete()
                    Next
                Next
                Dim DTTEP As DataTable = Comando.GetData("SELECT * From TipoEventoPaso WHERE TipoEv = " & vTipoEvento.Id)
                If DTTEP.Rows.Count > 0 Then
                    For Each DRow As DataRow In DTTEP.Rows
                        DRow.Delete()
                    Next
                End If
                Comando.ActualizarBD("TipoEvento", DTTE)
                Comando.ActualizarBD("Paso", DTP)
                Comando.ActualizarBD("TipoEventoPaso", DTTEP)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub Modificacion(Optional pObjeto As Object = Nothing) Implements IABMC.Modificacion
        Try
            If TypeOf pObjeto Is TipoEvento Then
                vTipoEvento = DirectCast(pObjeto, TipoEvento)
                Dim DTTE As DataTable = Comando.GetData("SELECT * FROM TipoEvento WHERE Id = " & vTipoEvento.Id)
                Dim DRTE As DataRow = DTTE.NewRow
                DRTE.ItemArray = {vTipoEvento.Id, vTipoEvento.Nombre, vTipoEvento.Descripcion}
                If DTTE.Rows.Count > 0 Then DTTE.Rows(0).ItemArray = DRTE.ItemArray
                Comando.ActualizarBD("TipoEvento", DTTE)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Function ConsultaTodo() As List(Of Object) Implements IABMC.ConsultaTodo
        Dim TipoEventoLista As List(Of Object) = Nothing
        Try
            Dim DTTipoEvento As DataTable = Comando.GetDataTable("TipoEvento")
            TipoEventoLista = New List(Of Object)
            For Each DRow As DataRow In DTTipoEvento.Rows
                Dim vTEvento As New TipoEvento(DRow(0), DRow(1), DRow(2))
                vTEvento.ListaPasos = CargarPasos(vTEvento.Id)
                TipoEventoLista.Add(vTEvento)
            Next
            Return TipoEventoLista
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Function CargarPasos(pTipoEventoId As Integer) As List(Of Paso)
        Dim ListaPasos As New List(Of Paso)
        Dim DTPaso As DataTable = Comando.GetDataTable("Paso")
        Dim DTIntermedia As DataTable = Comando.GetDataTable("TipoEventoPaso")

        For Each DRIntermedia As DataRow In DTIntermedia.Rows
            If pTipoEventoId = DRIntermedia(0) Then
                For Each DRPaso As DataRow In DTPaso.Rows
                    If DRIntermedia(1) = DRPaso(0) Then
                        Dim vPaso As New Paso(DRPaso(0), DRPaso(1), , DRPaso(2), DRPaso(3))
                        ListaPasos.Add(vPaso)
                    End If
                Next
            End If
        Next
        Return ListaPasos
    End Function

    Public Sub AgregarPaso(pTipoEvento As TipoEvento, pPaso As Paso, pDias As Integer)
        Try
            Dim DTable As DataTable = Comando.GetDataTable("TipoEventoPaso")
            Dim DRow As DataRow = DTable.NewRow
            DRow.ItemArray = {pTipoEvento.Id, pPaso.Id, pDias}
            DTable.Rows.Add(DRow)
            Comando.ActualizarBD("TipoEventoPaso", DTable)
        Catch ex As Exception
        End Try
    End Sub

    Public Sub BorrarPaso(pTipoEvento As TipoEvento, pPaso As Paso)
        Try
            Dim DTable As DataTable = Comando.GetData("SELECT * FROM TipoEventoPaso WHERE TipoEv = " & pTipoEvento.Id & " AND Paso = " & pPaso.Id)
            If DTable.Rows.Count > 0 Then DTable.Rows(0).Delete()
            Comando.ActualizarBD("TipoEventoPaso", DTable)
        Catch ex As Exception
        End Try
    End Sub

    Public Function ConsultaDias(pTipoEvento As TipoEvento, pPaso As Paso) As Integer
        Dim vDias As Integer
        Dim DTable As DataTable = Comando.GetData("SELECT * FROM TipoEventoPaso WHERE TipoEv = " & pTipoEvento.Id & " AND Paso = " & pPaso.Id)
        If DTable.Rows.Count > 0 Then vDias = DTable.Rows(0).Item(2)
        Return vDias
    End Function
End Class
