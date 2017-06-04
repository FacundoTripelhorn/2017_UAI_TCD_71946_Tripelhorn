Imports BLL_Estatica
Imports DAL
Imports DAL_ABMC

Public Class EventoDatos
    Implements IABMC

    Dim vEvento As New Evento
    Public Sub Alta(Optional pObjeto As Object = Nothing) Implements IABMC.Alta
        Try
            If TypeOf pObjeto Is Evento Then
                vEvento = DirectCast(pObjeto, Evento)
                Dim DTable As DataTable = Comando.GetDataTable("Evento")
                Dim DRow As DataRow = DTable.NewRow
                DRow.ItemArray = {vEvento.Id, vEvento.Nombre, vEvento.Fecha, vEvento.CantidadInvitados, vEvento.Tipo.Id, vEvento.Salon.Id, vEvento.Cliente.DNI}
                DTable.Rows.Add(DRow)
                Comando.ActualizarBD("Evento", DTable)
            End If
        Catch ex As Exception
            MsgBox("Error al agregar un nuevo evento")
        End Try
    End Sub

    Public Sub Baja(Optional pObjeto As Object = Nothing) Implements IABMC.Baja
        Try
            If TypeOf pObjeto Is Evento Then
                vEvento = DirectCast(pObjeto, Evento)
                Dim DTable As DataTable = Comando.GetData("SELECT * FROM Evento WHERE Id = " & vEvento.Id)
                If vEvento.ListaMateriales.Count > 0 Then BorrarMateriales(vEvento)
                If vEvento.ListaServicios.Count > 0 Then BorrarServicios(vEvento)
                If vEvento.ListaPasos.Count > 0 Then BorrarPasos(vEvento)
                Comando.ActualizarBD("Evento", DTable)
            End If
        Catch ex As Exception
            MsgBox("Error al eliminar el evento seleccionado")
        End Try
    End Sub

    Private Sub BorrarMateriales(pEvento As Evento)
        Dim DTMateriales As DataTable = Comando.GetData("SELECT * FROM ReservaMaterial WHERE Evento = " & pEvento.Id)
        For Each DRow As DataRow In DTMateriales.Rows
            DRow.Delete()
        Next
        Comando.ActualizarBD("ReservaMaterial", DTMateriales)
    End Sub

    Private Sub BorrarServicios(pEvento As Evento)
        Dim DTServicios As DataTable = Comando.GetData("SELECT * FROM ReservaServicio WHERE Evento = " & pEvento.Id)
        For Each DRow As DataRow In DTServicios.Rows
            DRow.Delete()
        Next
        Comando.ActualizarBD("ReservaServicio", DTServicios)
    End Sub

    Private Sub BorrarPasos(pEvento As Evento)
        Dim DTPasos As DataTable = Comando.GetData("SELECT * FROM EventoPaso WHERE Evento = " & pEvento.Id)
        For Each DRow As DataRow In DTPasos.Rows
            DRow.Delete()
        Next
        Comando.ActualizarBD("EventoPaso", DTPasos)
    End Sub

    Public Sub Modificacion(Optional pObjeto As Object = Nothing) Implements IABMC.Modificacion
        Try
            If TypeOf pObjeto Is Evento Then
                vEvento = DirectCast(pObjeto, Evento)
                Dim DTable As DataTable = Comando.GetData("SELECT * FROM Evento WHERE Id = " & vEvento.Id)
                Dim DRow As DataRow = DTable.NewRow
                DRow.ItemArray = {vEvento.Id, vEvento.Nombre, vEvento.Fecha, vEvento.CantidadInvitados, vEvento.Tipo.Id, vEvento.Salon.Id, vEvento.Cliente.DNI}
                If DTable.Rows.Count > 0 Then DTable.Rows(0).ItemArray = DRow.ItemArray
                Comando.ActualizarBD("Evento", DTable)
            End If
        Catch ex As Exception
            MsgBox("Error al modificar el evento")
        End Try
    End Sub

    Public Function ConsultaTodo() As List(Of Object) Implements IABMC.ConsultaTodo
        Dim vEventoLista As List(Of Object) = Nothing
        Try
            Dim DTable As DataTable = Comando.GetDataTable("Evento")
            vEventoLista = New List(Of Object)
            For Each Drow As DataRow In DTable.Rows
                Dim Evento As New Evento(Drow(0), Drow(1), Drow(2), Drow(3), GetTipoEvento(Drow(4)), GetSalon(Drow(5)), GetCliente(Drow(6)))
                Evento.ListaMateriales = GetMateriales(Evento.Id)
                Evento.ListaServicios = GetServicios(Evento.Id)
                Evento.ListaPasos = GetPasos(Evento.Id)
                vEventoLista.Add(Evento)
            Next
            Return vEventoLista
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Function GetMateriales(pEventoId As Integer) As List(Of Material)
        Dim vLista As New List(Of Material)
        Dim vMaterialDatos As New MaterialDatos
        Dim DTable As DataTable = Comando.GetData("SELECT * FROM ReservaMaterial WHERE Evento = " & pEventoId)
        Dim vMateriales As List(Of Object) = vMaterialDatos.ConsultaTodo
        For Each Drow As DataRow In DTable.Rows
            For Each Material As Material In vMateriales
                If Drow(1) = Material.Id Then
                    vLista.Add(Material)
                End If
            Next
        Next
        Return vLista
    End Function

    Private Function GetServicios(pEventoId As Integer) As List(Of Servicio)
        Dim vLista As New List(Of Servicio)
        Dim vServicioDatos As New ServicioDatos
        Dim DTable As DataTable = Comando.GetData("SELECT * FROM ReservaServicio WHERE Evento = " & pEventoId)
        Dim Servicios As List(Of Object) = vServicioDatos.ConsultaTodo
        For Each Drow As DataRow In DTable.Rows
            For Each Servicio As Servicio In Servicios
                If Drow(1) = Servicio.Id Then
                    vLista.Add(Servicio)
                End If
            Next
        Next
        Return vLista
    End Function

    Private Function GetPasos(pEventoId As Integer) As List(Of Paso)
        Dim vLista As New List(Of Paso)
        Dim vPasoDatos As New PasoDatos
        Dim DTable As DataTable = Comando.GetData("SELECT * FROM EventoPaso WHERE Evento = " & pEventoId)
        Dim Pasos As List(Of Object) = vPasoDatos.ConsultaTodo
        For Each Drow As DataRow In DTable.Rows
            For Each Paso As Paso In Pasos
                If Drow(1) = Paso.Id Then
                    Paso.Fecha = Drow(2)
                    vLista.Add(Paso)
                End If
            Next
        Next
        Return vLista
    End Function

    Private Function GetTipoEvento(pTipoEventoId As Integer) As TipoEvento
        Dim vTipoEvento As New TipoEvento
        Dim vTipoEventoDatos As New TipoEventoDatos
        For Each TipoEvento As TipoEvento In vTipoEventoDatos.ConsultaTodo
            If TipoEvento.Id = pTipoEventoId Then
                vTipoEvento = TipoEvento
            End If
        Next
        Return vTipoEvento
    End Function

    Private Function GetSalon(pSalonId As Integer) As Salon
        Dim vSalon As New Salon
        Dim vSalonDatos As New SalonDatos
        For Each Salon As Salon In vSalonDatos.ConsultaTodo
            If Salon.Id = pSalonId Then
                vSalon = Salon
            End If
        Next
        Return vSalon
    End Function

    Private Function GetCliente(pClienteDNI As Integer) As Cliente
        Dim vCliente As New Cliente
        Dim vClienteDatos As New ClienteDatos
        For Each Cliente As Cliente In vClienteDatos.ConsultaTodo
            If Cliente.DNI = pClienteDNI Then
                vCliente = Cliente
            End If
        Next
        Return vCliente
    End Function

    Public Sub AgregarPaso(pEvento As Evento, pPaso As Paso, pFecha As Date)
        Try
            Dim DTable As DataTable = Comando.GetDataTable("EventoPaso")
            Dim DRow As DataRow = DTable.NewRow
            DRow.ItemArray = {pEvento.Id, pPaso.Id, pFecha}
            DTable.Rows.Add(DRow)
            Comando.ActualizarBD("EventoPaso", DTable)
        Catch ex As Exception
            MsgBox("Error al agregar el paso al evento")
        End Try
    End Sub

    Public Sub BorrarPaso(pEvento As Evento, pPaso As Paso)
        Try
            Dim DTable As DataTable = Comando.GetData("SELECT * FROM EventoPaso WHERE Evento = " & pEvento.Id & " AND Paso = " & pPaso.Id)
            If DTable.Rows.Count > 0 Then DTable.Rows(0).Delete()
            Comando.ActualizarBD("EventoPaso", DTable)
        Catch ex As Exception
            MsgBox("Error al eliminar el paso")
        End Try
    End Sub

    Public Sub ModificarPaso(pEvento As Evento, pPaso As Paso, pFecha As Date)
        Try
            Dim DTable As DataTable = Comando.GetData("SELECT * FROM EventoPaso WHERE Evento = " & pEvento.Id & " AND Paso = " & pPaso.Id)
            If DTable.Rows.Count > 0 Then DTable.Rows(0).Item(2) = pFecha
            Comando.ActualizarBD("EventoPaso", DTable)
        Catch ex As Exception
            MsgBox("Error al modificar el paso")
        End Try
    End Sub
End Class
