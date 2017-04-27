Public Interface IABMC
    Sub Alta(Optional pObjeto As Object = Nothing)
    Sub Baja(Optional pObjeto As Object = Nothing)
    Sub Modificacion(Optional pObjeto As Object = Nothing)
    Function ConsultaTodo() As List(Of Object)
End Interface
