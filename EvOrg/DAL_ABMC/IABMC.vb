Public Interface IABMC
    Sub Alta(Optional Objeto As Object = Nothing)
    Sub Baja(Optional Objeto As Object = Nothing)
    Sub Modificacion(Optional Objeto As Object = Nothing)
    Function ConsultaTodo() As List(Of Object)
End Interface
