Imports System.IO
Imports System.Net
Imports GMap.NET
Imports GMap.NET.MapProviders
Imports BLL_Dinamica
Imports BLL_Estatica
Imports OrganizacionDeEventos

Public Class SeleccionarSalon
    Implements IObservador
    Dim vTraductor As Traductor = Traductor.GetInstance
    Dim vSalon As Salon
    Dim vSalonDinamico As New SalonDinamico
    Private Sub SeleccionarSalon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vTraductor.Registrar(Me)
        Actualizar()
        SetGMap()
        GMapa.SetPositionByKeywords("Av. San Juan 951, Capital Federal, Argentina")
        GMapa.Overlays.Clear()
        For Each Salon As Salon In vSalonDinamico.ConsultaTodo
            AddMarkers(Salon.Direccion.Calle & " " & Salon.Direccion.Numero & ", " & Salon.Direccion.Localidad & ", Argentina")
        Next
        ActualizarObservador(Me)
    End Sub

    Public Sub Actualizar()
        Try
            Dim vLista As New List(Of VistaSalon)
            For Each Salon As Salon In vSalonDinamico.ConsultaTodo
                vLista.Add(New VistaSalon(Salon.Nombre, Salon.Capacidad, Salon.Email, Salon.Telefono, Salon.Precio))
            Next
            GrillaSalones.DataSource = Nothing
            GrillaSalones.DataSource = vLista
            GrillaSalones.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SetGMap()
        GMapa.DragButton = MouseButtons.Left
        GMapa.MapProvider = GMapProviders.GoogleMap
        Global.GMap.NET.GMaps.Instance.Mode = Global.GMap.NET.AccessMode.ServerOnly
        GMapa.ShowCenter = False
        GMapa.MinZoom = 0
        GMapa.MaxZoom = 24
        GMapa.Zoom = 16
    End Sub

    Public Sub AddMarkers(pDireccion As String)
        Dim Markers As New GMap.NET.WindowsForms.GMapOverlay("Markers")
        Dim Marker As New WindowsForms.Markers.GMarkerGoogle(GetLatLong(pDireccion), WindowsForms.Markers.GMarkerGoogleType.red)
        Markers.Markers.Add(Marker)
        GMapa.Overlays.Add(Markers)
    End Sub

    Public Function GetLatLong(pDireccion As String) As PointLatLng
        Dim vStatus As New GeoCoderStatusCode
        Return GMapProviders.GoogleMap.GetPoint(pDireccion, vStatus)
    End Function


    Private Sub GrillaSalones_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaSalones.CellClick
        Try
            For Each salon As Salon In vSalonDinamico.ConsultaTodo
                If salon.Nombre = DirectCast(GrillaSalones.SelectedRows(0).DataBoundItem, VistaSalon).Nombre Then
                    CalleTxt.Text = salon.Direccion.Calle
                    NumeroTxt.Text = salon.Direccion.Numero
                    LocalidadTxt.Text = salon.Direccion.Localidad
                    GMapa.SetPositionByKeywords(salon.Direccion.Calle & " " & salon.Direccion.Numero & ", " & salon.Direccion.Localidad & ", Argentina")
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Public Sub ActualizarObservador(Optional pControl As Control = Nothing) Implements IObservador.ActualizarObservador
        For Each vControl As Control In pControl.Controls
            Try
                vControl.Text = vTraductor.IdiomaSeleccionado.Diccionario.Item(vControl.Tag.ToString)
            Catch ex As Exception
            Finally
                If vControl.Controls.Count > 0 Then
                    ActualizarObservador(vControl)
                End If
                If TypeOf vControl Is DataGridView Then
                    For Each vColumna As DataGridViewColumn In DirectCast(vControl, DataGridView).Columns
                        Try
                            vColumna.HeaderText = vTraductor.IdiomaSeleccionado.Diccionario.Item(vColumna.Name)
                        Catch ex As Exception

                        End Try
                    Next
                End If
            End Try
        Next
    End Sub
End Class