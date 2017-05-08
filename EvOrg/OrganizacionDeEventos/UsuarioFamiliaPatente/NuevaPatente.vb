Imports System.ComponentModel
Imports System.Reflection
Public Class NuevaPatente
    Private Sub NuevaPatente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim vAsm As Assembly = Assembly.GetExecutingAssembly
        For Each vTipo As Type In vAsm.GetTypes
            If vTipo.IsSubclassOf(GetType(Form)) Then
                Me.FormularioCombo.Items.Add(vTipo.Name)
            End If
        Next
    End Sub

    Public Function Nombre() As String
        Return NombreTxt.Text
    End Function

    Public Function Formulario() As String
        Return FormularioCombo.SelectedItem
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class