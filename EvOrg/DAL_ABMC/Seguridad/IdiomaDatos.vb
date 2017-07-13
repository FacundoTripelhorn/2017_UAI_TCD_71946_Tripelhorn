Imports DAL_ABMC
Imports BLL_Estatica
Imports DAL
Public Class IdiomaDatos
    Implements IABMC

#Region "Singleton"
    Private Shared vIdiomaDatos As IdiomaDatos = Nothing
    Private Sub New()

    End Sub
    Public Shared Function GetInstance() As IdiomaDatos
        If vIdiomaDatos Is Nothing Then
            vIdiomaDatos = New IdiomaDatos
        End If
        Return vIdiomaDatos
    End Function
#End Region
    Dim vIdioma As Idioma
    Public Sub Alta(Optional pObjeto As Object = Nothing) Implements IABMC.Alta
        If TypeOf pObjeto Is Idioma Then
            vIdioma = DirectCast(pObjeto, Idioma)
            Dim DTable As DataTable = Comando.GetDataTable("Idioma")
            If DTable.Rows.Count > 0 Then
                vIdioma.Id = DTable.Rows(DTable.Rows.Count - 1).Item(0) + 1
            Else
                vIdioma.Id = 1
            End If
            Dim DRow As DataRow = DTable.NewRow
            DRow.ItemArray = {vIdioma.Id, vIdioma.Nombre}
            DTable.Rows.Add(DRow)
            AgregarDiccionario(vIdioma)
            Comando.ActualizarBD("Idioma", DTable)
        End If
    End Sub

    Private Sub AgregarDiccionario(pIdioma As Idioma)
        Try
            Dim DTable As DataTable = Comando.GetDataTable("IdiomaDiccionario")
            Dim DTDiccionario As DataTable = Comando.GetDataTable("Diccionario")

            For Each Item In pIdioma.Diccionario
                For Each DRDiccionario As DataRow In DTDiccionario.Rows
                    If Item.Key = DRDiccionario(1) Then
                        Dim DRow As DataRow = DTable.NewRow
                        DRow.ItemArray = {pIdioma.Id, DRDiccionario(0), Item.Value}
                        DTable.Rows.Add(DRow)
                    End If
                Next
            Next
            Comando.ActualizarBD("IdiomaDiccionario", DTable)
        Catch ex As Exception

        End Try
    End Sub

    Public Sub Baja(Optional pObjeto As Object = Nothing) Implements IABMC.Baja
        If TypeOf pObjeto Is Idioma Then
            vIdioma = DirectCast(pObjeto, Idioma)
            Dim DTable As DataTable = Comando.GetData("SELECT * FROM Idioma WHERE Id = " & vIdioma.Id)
            If DTable.Rows.Count > 0 Then
                DTable.Rows(0).Delete()
            End If
            BorrarDiccionario(vIdioma)
            Comando.ActualizarBD("Idioma", DTable)
        End If
    End Sub

    Private Sub BorrarDiccionario(pIdioma As Idioma)
        Dim DTable As DataTable = Comando.GetData("SELECT * FROM IdiomaDiccionario WHERE Idioma = " & pIdioma.Id)
        For Each DRow As DataRow In DTable.Rows
            DRow.Delete()
        Next
        Comando.ActualizarBD("IdiomaDiccionario", DTable)
    End Sub

    Public Sub Modificacion(Optional pObjeto As Object = Nothing) Implements IABMC.Modificacion
        If TypeOf pObjeto Is Idioma Then
            vIdioma = DirectCast(pObjeto, Idioma)
            Dim DTable As DataTable = Comando.GetDataTable("SELECT * FROM Idioma WHERE Id = " & vIdioma.Id)
            If DTable.Rows.Count > 0 Then
                DTable.Rows(0).ItemArray = {vIdioma.Id, vIdioma.Nombre}
            End If

            Comando.ActualizarBD("Idioma", DTable)
        End If
    End Sub

    Private Sub ModificarDiccionario(pIdioma As Idioma)
        Dim DTable As DataTable = Comando.GetData("SELECT * FROM IdiomaDiccionario WHERE Idioma = " & pIdioma.Id)
        DTable.PrimaryKey = {DTable.Columns(0), DTable.Columns(1)}
        Dim DTDiccionario As DataTable = Comando.GetDataTable("Diccionario")
        For Each Item In pIdioma.Diccionario
            For Each DRow As DataRow In DTDiccionario.Rows
                If Item.Key = DRow.Item(0) Then
                    DTable.Rows.Find(DRow(0)).Item(2) = Item.Value
                End If
            Next
        Next
        Comando.ActualizarBD("IdiomaDiccionario", DTable)
    End Sub

    Public Function ConsultaTodo() As List(Of Object) Implements IABMC.ConsultaTodo
        Dim vLista As New List(Of Object)
        Try
            Dim DTable As DataTable = Comando.GetDataTable("Idioma")
            For Each Drow As DataRow In DTable.Rows
                Dim Idioma As New Idioma(Drow(0), Drow(1), CargarDiccionario(Drow(0)))
                vLista.Add(Idioma)
            Next
            Return vLista
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Function CargarDiccionario(pIdIdioma As Integer) As Dictionary(Of String, String)
        Try
            Dim vDiccionario As New Dictionary(Of String, String)
            Dim DTable As DataTable = Comando.GetData("SELECT * FROM IdiomaDiccionario WHERE Idioma = " & pIdIdioma)
            Dim DTDiccionario As DataTable = Comando.GetDataTable("Diccionario")
            DTDiccionario.PrimaryKey = {DTDiccionario.Columns(0)}
            For Each DRow As DataRow In DTable.Rows
                vDiccionario.Add(DTDiccionario.Rows.Find(DRow(1)).Item(1), DRow(2))
            Next
            Return vDiccionario
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function CheckIdioma(pNombre As String) As String
        Dim DTable As DataTable = Comando.GetData("SELECT * FROM Idioma WHERE Nombre = '" & pNombre & "'")
        If DTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
