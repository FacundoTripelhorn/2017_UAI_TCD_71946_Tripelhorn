Public Interface IObservado
    ReadOnly Property Registrados As List(Of IObservador)
    Sub Registrar(pObservador As IObservador)
    Sub Notificar()
End Interface
