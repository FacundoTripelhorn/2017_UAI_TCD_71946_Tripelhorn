Imports DAL_ABMC
Imports BLL_Estatica
Imports DAL

Public Class PasoDatos
    Implements IABMC

    Dim vPaso As Paso

    Public Sub Alta(Optional pObjeto As Object = Nothing) Implements IABMC.Alta
        Try
            If TypeOf pObjeto Is Paso Then
                vPaso = DirectCast(pObjeto, Paso)
                Dim DTable As DataTable = Comando.GetDataTable("Paso")
                Dim DRow As DataRow = DTable.NewRow
                DRow.ItemArray = {vPaso.Id, vPaso.Descripcion, vPaso.Prioridad, vPaso.Tipo}
                DTable.Rows.Add(DRow)
                Comando.ActualizarBD("Paso", DTable)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub Baja(Optional pObjeto As Object = Nothing) Implements IABMC.Baja
        Try
            If TypeOf pObjeto Is Paso Then
                vPaso = DirectCast(pObjeto, Paso)
                Dim DTable As DataTable = Comando.GetData("SELECT * FROM Paso WHERE Id = " & vPaso.Id)
                If DTable.Rows.Count > 0 Then DTable.Rows(0).Delete()
                Comando.ActualizarBD("Paso", DTable)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub Modificacion(Optional pObjeto As Object = Nothing) Implements IABMC.Modificacion
        Try
            If TypeOf pObjeto Is Paso Then
                vPaso = DirectCast(pObjeto, Paso)
                Dim DTable As DataTable = Comando.GetData("SELECT * FROM Paso WHERE Id = " & vPaso.Id)
                Dim DRow As DataRow = DTable.NewRow
                DRow.ItemArray = {vPaso.Id, vPaso.Descripcion, vPaso.Prioridad, vPaso.Tipo}
                If DTable.Rows.Count > 0 Then DTable.Rows(0).ItemArray = DRow.ItemArray
                Comando.ActualizarBD("Paso", DTable)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Function ConsultaTodo() As List(Of Object) Implements IABMC.ConsultaTodo
        Dim PasoLista As List(Of Object) = Nothing
        Try
            Dim DTable As DataTable = Comando.GetDataTable("Paso")
            PasoLista = New List(Of Object)
            For Each DRow As DataRow In DTable.Rows
                PasoLista.Add(New Paso(DRow(0), DRow(1), , DRow(2), DRow(3)))
            Next
            Return PasoLista
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Function GetEvento(pPasoId) As Evento
        Dim vEvento As New Evento
        Dim vEventoDatos As New EventoDatos
        For Each Evento As Evento In vEventoDatos.ConsultaTodo
            For Each Paso As Paso In Evento.ListaPasos
                If pPasoId = Paso.Id And Paso.Tipo = "Concreto" Then
                    vEvento = Evento
                End If
            Next
        Next
        Return vEvento
    End Function

    Public Function CheckPaso(pDescripcion As String) As Boolean
        Dim DTable As DataTable = Comando.GetData("SELECT * FROM Paso WHERE Descripcion = '" & pDescripcion & "'")
        If DTable.Rows.Count > 0 Then
            Dim DTEvento As DataTable = Comando.GetData("SELECT * FROM EventoPaso WHERE Paso = " & DTable.Rows(0).Item(0))
            If DTEvento.Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function CheckPasoTipoEvento(pDescripcion As String) As Boolean
        Dim DTable As DataTable = Comando.GetData("SELECT * FROM Paso WHERE Descripcion = '" & pDescripcion & "'")
        If DTable.Rows.Count > 0 Then
            Dim DTEvento As DataTable = Comando.GetData("SELECT * FROM TipoEventoPaso WHERE Paso = " & DTable.Rows(0).Item(0))
            If DTEvento.Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function
End Class
