Imports BLL_Estatica
Imports DAL
Imports DAL_ABMC

Public Class FamiliaDatos
    Implements IABMC
    Dim vFamilia As Familia

    Public Sub Alta(Optional pObjeto As Object = Nothing) Implements IABMC.Alta
        If TypeOf pObjeto Is Familia Then
            vFamilia = DirectCast(pObjeto, Familia)
        End If
        Try
            Dim DTFamilia As DataTable = Comando.GetDataTable("Familia")
            Dim DRow As DataRow = DTFamilia.NewRow
            DRow.Item(1) = vFamilia.Nombre
            DTFamilia.Rows.Add(DRow)
            Comando.ActualizarBD("Familia", DTFamilia)
            AgregarPatentes(vFamilia)
        Catch ex As Exception
            MsgBox("Error al crear la Familia")
        End Try
    End Sub

    Public Sub Baja(Optional pObjeto As Object = Nothing) Implements IABMC.Baja
        If TypeOf pObjeto Is Familia Then
            vFamilia = DirectCast(pObjeto, Familia)
        End If
        Try
            Dim DTFamilia As DataTable = Comando.GetData("SELECT * FROM Familia WHERE Nombre = '" & vFamilia.Nombre & "'")
            If DTFamilia.Rows.Count > 0 Then
                vFamilia.Id = DTFamilia.Rows(0).Item(0)
                BorrarPatentes(vFamilia.Id)
                DTFamilia.Rows(0).Delete()
                Comando.ActualizarBD("Familia", DTFamilia)
            End If
        Catch ex As Exception
            MsgBox("Error al eliminar la Familia")
        End Try
    End Sub

    Public Sub Modificacion(Optional pObjeto As Object = Nothing) Implements IABMC.Modificacion
        If TypeOf pObjeto Is Familia Then
            vFamilia = DirectCast(pObjeto, Familia)
        End If

        Try
            Dim DTFamilia As DataTable = Comando.GetData("SELECT * FROM Familia WHERE Nombre = '" & vFamilia.Nombre & "'")
            If DTFamilia.Rows.Count > 0 Then
                vFamilia.Id = DTFamilia.Rows(0).Item(0)
                BorrarPatentes(vFamilia.Id)
                AgregarPatentes(vFamilia)
                Comando.ActualizarBD("Familia", DTFamilia)
            End If
        Catch ex As Exception
            MsgBox("Error al modificar la Familia")
        End Try
    End Sub

    Private Sub AgregarPatentes(pFamilia As Familia)
        Dim DTFGPatente As DataTable = Comando.GetDataTable("FamiliaGrupoPatente")
        Dim DTFPatente As DataTable = Comando.GetDataTable("FamiliaPatente")
        Dim DTFamilia As DataTable = Comando.GetData("SELECT * FROM Familia WHERE Nombre = '" & pFamilia.Nombre & "'")
        pFamilia.Id = DTFamilia.Rows(0).Item(0)
        For Each vPAbstracta As PatenteAbstracta In pFamilia.ListaPatentes
            If TypeOf vPAbstracta Is GrupoPatente Then
                Dim DRowFGP As DataRow = DTFGPatente.NewRow
                DRowFGP.ItemArray = {pFamilia.Id, vPAbstracta.Id, vPAbstracta.Padre}
                DTFGPatente.Rows.Add(DRowFGP)
            ElseIf TypeOf vPAbstracta Is Patente Then
                Dim vPatente = DirectCast(vPAbstracta, Patente)
                Dim DRowFP As DataRow = DTFPatente.NewRow
                DRowFP.ItemArray = {pFamilia.Id, vPatente.Id, vPatente.Padre}
                DTFPatente.Rows.Add(DRowFP)
            End If
        Next
        Comando.ActualizarBD("FamiliaGrupoPatente", DTFGPatente)
        Comando.ActualizarBD("FamiliaPatente", DTFPatente)
    End Sub

    Private Sub BorrarPatentes(pFamiliaId As Integer)
        Dim DTFPatente As DataTable = Comando.GetData("SELECT * FROM FamiliaPatente WHERE Familia = '" & pFamiliaId & "'")
        For Each DRow As DataRow In DTFPatente.Rows
            DRow.Delete()
        Next
        Comando.ActualizarBD("FamiliaPatente", DTFPatente)

        Dim DTFGPatente As DataTable = Comando.GetData("SELECT * FROM FamiliaGrupoPatente WHERE Familia = '" & pFamiliaId & "'")
        For Each DRow As DataRow In DTFGPatente.Rows
            DRow.Delete()
        Next
        Comando.ActualizarBD("FamiliaGrupoPatente", DTFGPatente)
    End Sub

    Public Function ConsultaTodo() As List(Of Object) Implements IABMC.ConsultaTodo
        Dim vLista As New List(Of Object)
        Dim DT As DataTable = Comando.GetDataTable("Familia")
        If DT.Rows.Count > 0 Then
            For Each DR As DataRow In DT.Rows
                vLista.Add(New Familia(DR.Item(0), DR.Item(1)))
            Next
        End If
        Return vLista
    End Function

    Public Function ListarPatentes(pObjeto As Object) As List(Of Object)
        Dim vLista As New List(Of Object)
        Dim vFamilia As Familia
        Dim vUsuario As New Usuario

        If TypeOf pObjeto Is Familia Then
            vFamilia = DirectCast(pObjeto, Familia)
            Dim DT As DataTable = Comando.GetData("SELECT * FROM Familia WHERE Nombre = '" & vFamilia.Nombre & "'")
            If DT.Rows.Count > 0 Then
                vUsuario.Familia.Id = DT.Rows(0).Item(0)
                vUsuario.Familia.Nombre = DT.Rows(0).Item(1)
            End If
        ElseIf TypeOf pObjeto Is Usuario Then
            vUsuario = DirectCast(pObjeto, Usuario)
        End If

        Try
            Dim DTFGPatente As DataTable = Comando.GetData("SELECT * FROM FamiliaGrupoPatente WHERE Familia = " & vUsuario.Familia.Id)
            Dim DTFPatente As DataTable = Comando.GetData("SELECT * FROM FamiliaPatente WHERE Familia = " & vUsuario.Familia.Id)
            If DTFGPatente.Rows.Count > 0 Then
                If DTFGPatente.Rows(0).Item(2) = 1 Then
                    Dim DTGPatente As DataTable = Comando.GetData("SELECT * FROM GrupoPatente WHERE Id = 1")
                    Dim vPadre As New GrupoPatente(DTGPatente.Rows(0).Item(0), DTGPatente.Rows(0).Item(1), 1)
                    vLista.Add(vPadre)
                    AgregarHijosGrupo(vPadre, vUsuario.Familia.Id)
                Else
                    Dim DTFGPTemporal As DataTable = Comando.GetData("SELECT * FROM FamiliaGrupoPatente WHERE Familia = '" & vUsuario.Familia.Id & "' AND Padre = 1")
                    For Each DRowFGP As DataRow In DTFGPTemporal.Rows
                        Dim DTGPatente As DataTable = Comando.GetData("SELECT * FROM GrupoPatente WHERE Id = '" & DRowFGP.Item(1) & "'")
                        Dim vPadre As New GrupoPatente(DTGPatente.Rows(0).Item(0), DTGPatente.Rows(0).Item(1), DTGPatente.Rows(0).Item(2))
                        vLista.Add(vPadre)
                        AgregarHijosGrupo(vPadre, vUsuario.Familia.Id)
                    Next
                End If
            Else
                If DTFPatente.Rows.Count > 0 Then
                    For Each DRow As DataRow In DTFPatente.Rows
                        If DRow.Item(2) = 1 Then
                            Dim DTGPatente As DataTable = Comando.GetData("SELECT * FROM GrupoPatente WHERE Id = 1")
                            Dim vPadre As New GrupoPatente(DTGPatente.Rows(0).Item(0), DTGPatente.Rows(0).Item(1), 1)
                            vLista.Add(vPadre)
                            AgregarHijosGrupo(vPadre, vUsuario.Familia.Id)
                        End If
                    Next
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return vLista
    End Function

    Public Sub AgregarHijosGrupo(pPadre As GrupoPatente, pFamilia As Integer)
        Dim DTFGPatente As DataTable = Comando.GetData("SELECT * FROM FamiliaGrupoPatente where Familia = '" & pFamilia & "' and Padre='" & pPadre.Id & "'")
        If DTFGPatente.Rows.Count > 0 Then
            Try
                AgregarHijosPatente(pPadre, pFamilia)
                Dim DTGPatente As DataTable = Comando.GetData("SELECT * FROM GrupoPatente WHERE Padre = '" & pPadre.Id & "'")
                If DTGPatente.Rows.Count > 0 Then
                    For Each Hijo As DataRow In DTGPatente.Rows
                        Dim Hijo2 As GrupoPatente
                        Hijo2 = New GrupoPatente(Hijo.Item(0), Hijo.Item(1), Hijo.Item(2))
                        Dim DTFGPatente2 As DataTable = Comando.GetData("SELECT * FROM FamiliaGrupoPatente WHERE Familia = '" & pFamilia & "' AND GrupoPatente='" & Hijo2.Id & "'")
                        If DTFGPatente2.Rows.Count > 0 Then
                            pPadre.ListaPatentes.Add(Hijo2)
                        End If

                        Dim DTGPatente2 As New DataTable
                        DTGPatente2 = Comando.GetData("SELECT * FROM GrupoPatente WHERE Padre=" & Hijo2.Id)
                        If DTGPatente2.Rows.Count > 0 Then
                            AgregarHijosGrupo(Hijo2, pFamilia)
                        Else
                            AgregarHijosPatente(Hijo2, pFamilia)
                        End If
                    Next
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            AgregarHijosPatente(pPadre, pFamilia)
        End If
    End Sub

    Public Sub AgregarHijosPatente(pPadre As GrupoPatente, pFamilia As Integer)
        Dim DTFPatente As DataTable = Comando.GetData("SELECT * FROM FamiliaPatente WHERE Familia = '" & pFamilia & "' AND Padre = '" & pPadre.Id & "'")
        If DTFPatente.Rows.Count > 0 Then
            Try
                Dim DTPatente As DataTable = Comando.GetData("SELECT * FROM Patente WHERE Padre=" & pPadre.Id)
                If DTPatente.Rows.Count > 0 Then
                    For Each DRowP As DataRow In DTPatente.Rows
                        Dim DTFPatente2 As DataTable = Comando.GetData("SELECT * FROM FamiliaPatente WHERE Familia='" & pFamilia & "' AND Patente='" & DRowP.Item(0) & "'")
                        If DTFPatente2.Rows.Count > 0 Then
                            pPadre.ListaPatentes.Add(New Patente(DRowP.Item(0), DRowP.Item(1), DRowP.Item(2), DRowP.Item(3)))
                        End If
                    Next
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub
End Class
