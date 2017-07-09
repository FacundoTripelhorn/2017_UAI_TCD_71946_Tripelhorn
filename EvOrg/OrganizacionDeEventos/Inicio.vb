Imports BLL_Estatica
Imports BLL_Dinamica
Imports System.ComponentModel
Imports OrganizacionDeEventos

Public Class Inicio
    Implements IObservador
    Dim vTraductor As Traductor = Traductor.GetInstance
    Property Usuario As New Usuario
    Property FamiliaDinamica As New FamiliaDinamica
    Property GrupoPatenteDinamico As New GrupoPatenteDinamico
    Dim vIdiomaDinamico As IdiomaDinamico = IdiomaDinamico.GetInstance
    Sub New(Optional pUsuario As Usuario = Nothing)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If Not pUsuario Is Nothing Then
            Usuario = pUsuario
        End If
    End Sub

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GrupoPatenteDinamico.MostrarEnMenuStrip(MenuStrip1, Usuario, Me)
        CargarIdiomas()
        IdiomaCombo.SelectedItem = IdiomaCombo.Items(0)
        vTraductor.Registrar(Me)
        ActualizarObservador(Me)
    End Sub

    Private Sub CargarIdiomas()
        For Each Idioma As Idioma In vIdiomaDinamico.ConsultaTodo
            IdiomaCombo.Items.Add(Idioma)
        Next
    End Sub


    Private Sub Inicio_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MsgBox(vTraductor.Traducir("Cerrando sesion"))
        LogIn.Show()
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
                If TypeOf vControl Is MenuStrip Then
                    For Each vToolStrip As ToolStripMenuItem In DirectCast(vControl, MenuStrip).Items
                        TraducirItems(vToolStrip)
                    Next
                End If
            End Try
        Next
    End Sub

    Private Sub TraducirItems(pTool As ToolStripMenuItem)
        Try
            pTool.Text = vTraductor.IdiomaSeleccionado.Diccionario.Item(pTool.Name)
            For Each vItem As ToolStripDropDownItem In pTool.DropDownItems
                vItem.Text = vTraductor.IdiomaSeleccionado.Diccionario.Item(vItem.Name)
                If vItem.DropDownItems.Count > 0 Then
                    TraducirItems(vItem)
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub IdiomaCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles IdiomaCombo.SelectedIndexChanged
        vTraductor.IdiomaSeleccionado = IdiomaCombo.SelectedItem
    End Sub
End Class