Public Class VistaDiccionario
    Property Clave As String
    Property Valor As String

    Sub New()

    End Sub

    Sub New(pClave As String, pValor As String)
        Clave = pClave
        Valor = pValor
    End Sub
End Class
