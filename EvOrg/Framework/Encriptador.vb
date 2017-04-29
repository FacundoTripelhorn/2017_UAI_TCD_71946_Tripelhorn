Imports System.Security.Cryptography
Imports System.Text
Public Class Encriptador
#Region "Singleton"
    Private Shared vEncriptador As Encriptador = Nothing

    Private Sub New()

    End Sub

    Public Shared Function GetInstance() As Encriptador
        If vEncriptador Is Nothing Then
            vEncriptador = New Encriptador
        End If
        Return vEncriptador
    End Function
#End Region

    Public Function Encriptar(pTexto As String) As String
        Dim vMD5Hash As MD5 = MD5.Create
        Dim vBytes As Byte() = vMD5Hash.ComputeHash(Encoding.UTF8.GetBytes(pTexto))
        Dim vStringBuilder As New StringBuilder
        For i = 0 To vBytes.Length - 1
            vStringBuilder.Append(vBytes(i).ToString("X2"))
        Next

        Return vStringBuilder.ToString
    End Function

    Public Function ValidarHash(pTexto As String, pEncriptado As String) As Boolean
        Dim vNuevoHash As String = Encriptar(pTexto)
        If vNuevoHash = pEncriptado Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
