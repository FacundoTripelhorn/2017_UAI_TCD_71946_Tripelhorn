Public Class Evento
    Property Id As Integer
    Property Nombre As String
    Property Fecha As Date
    Property CantidadInvitados As Integer
    Property Tipo As TipoEvento
    Property Salon As Salon
    Property Cliente As Cliente
    Property ListaServicios As List(Of Servicio)
    Property ListaMateriales As List(Of Material)
    Property ListaPasos As List(Of Paso)

    Sub New()

    End Sub

    Sub New(pNombre As String, pFecha As Date, pCantidadInvitados As Integer, pTipo As TipoEvento, pCliente As Cliente)
        Nombre = pNombre
        Fecha = pFecha
        CantidadInvitados = pCantidadInvitados
        Tipo = pTipo
        Cliente = pCliente
    End Sub

    Sub New(pId As Integer, pNombre As String, pFecha As Date, pCantidadInvitados As Integer, pTipo As TipoEvento, pSalon As Salon, pCliente As Cliente)
        Id = pId
        Nombre = pNombre
        Fecha = pFecha
        CantidadInvitados = pCantidadInvitados
        Tipo = pTipo
        Salon = pSalon
        Cliente = pCliente
    End Sub
End Class
