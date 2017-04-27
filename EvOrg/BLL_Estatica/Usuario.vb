Public Class Usuario
    Property IdUsuario As String
    Property Contraseña As String
    Property Email As String
    Property Familia As New Familia

    Sub New()

    End Sub

    Sub New(pId As String)
        IdUsuario = pId
    End Sub

    Sub New(pId As String, pContraseña As String)
        Me.New(pId)
        Contraseña = pContraseña
    End Sub

    Sub New(pId As String, pEmail As String, pContraseña As String)
        Me.New(pId, pContraseña)
        Email = pEmail
    End Sub

    Sub New(pId As String, pEmail As String, pContraseña As String, pFamilia As Familia)
        Me.New(pId, pEmail, pContraseña)
        Familia = pFamilia
    End Sub
End Class
