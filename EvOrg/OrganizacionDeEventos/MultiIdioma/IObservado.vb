Public Interface IObservado

    Property ListaObservador As List(Of IObservador)
    Sub Registrar(pObservador As IObservador)
    Sub Notificar()
End Interface
