Imports BLL_Dinamica
Imports BLL_Estatica
Imports OrganizacionDeEventos

Public Class ABMPatente
    Implements IObservador
    Dim vTraductor As Traductor = Traductor.GetInstance
    Property PatenteDinamica As New PatenteDinamica
    Property Patente As New Patente
    Property GrupoPatenteDinamico As New GrupoPatenteDinamico
    Property GrupoPatente As New GrupoPatente

    Private Sub ABMPatente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vTraductor.Registrar(Me)
        Dim vLista As New List(Of Object)
        vLista = GrupoPatenteDinamico.ConsultaTodo()
        GrupoPatenteDinamico.MostrarEnTreeView(TreePatente)
        ActualizarObservador(Me)
        ActualizarObservador(ContextMenuStrip1)
    End Sub

    Private Sub AgregarPatenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarPatenteToolStripMenuItem.Click
        Dim vSNode As TreeNode = TreePatente.SelectedNode
        Try
            If TypeOf vSNode.Tag Is GrupoPatente Then
                Dim fNuevaPatente As New NuevaPatente
                fNuevaPatente.ShowDialog()

                Dim vNombre As String = fNuevaPatente.Nombre
                Dim vFormulario As String = fNuevaPatente.Formulario
                Dim vPadre As GrupoPatente = vSNode.Tag
                If vNombre.Length > 0 And vFormulario.Length > 0 Then
                    Patente.Nombre = vNombre
                    Patente.Formulario = vFormulario
                    Patente.Padre = vPadre.Id

                    Dim vNNode As New TreeNode
                    vNNode.Name = vNombre
                    vNNode.Tag = Patente
                    vSNode.Nodes.Add(vNNode)
                    vPadre.ListaPatentes.Add(Patente)
                    PatenteDinamica.Alta(Patente)
                    TreePatente.Nodes.Clear()
                    ABMPatente_Load(Nothing, Nothing)
                    TreePatente.ExpandAll()
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub AgregarGrupoDePatentesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarGrupoDePatentesToolStripMenuItem.Click
        Dim vSNode As TreeNode = TreePatente.SelectedNode
        If TypeOf vSNode.Tag Is GrupoPatente Then
            Dim vPadre As GrupoPatente = vSNode.Tag
            Dim vNombre As String = InputBox(vTraductor.Traducir("Ingrese el nombre del Grupo: "))
            If vNombre.Length > 0 Then
                Dim vNNode As New TreeNode
                vNNode.Text = vNombre
                GrupoPatente.Nombre = vNombre
                vNNode.Tag = GrupoPatente
                vSNode.Nodes.Add(vNNode)
                vPadre.ListaPatentes.Add(GrupoPatente)
                GrupoPatente.Padre = vPadre.Id
                GrupoPatenteDinamico.Alta(GrupoPatente)
                TreePatente.Nodes.Clear()
                ABMPatente_Load(Nothing, Nothing)
                TreePatente.ExpandAll()
            End If
        End If
    End Sub

    Private Sub EliminarElementoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarElementoToolStripMenuItem.Click
        Try
            Dim vSNode As TreeNode = TreePatente.SelectedNode

            If TypeOf vSNode.Tag Is GrupoPatente Then
                If Not vSNode.Parent Is Nothing Then
                    Dim vPadre As GrupoPatente = vSNode.Parent.Tag()
                    vSNode.Remove()
                    vPadre.ListaPatentes.Remove(vSNode.Tag)
                    If TypeOf vSNode.Tag Is GrupoPatente Then
                        GrupoPatenteDinamico.Baja((vSNode.Tag))
                    Else
                        PatenteDinamica.Baja(vSNode.Tag)
                    End If
                End If
            Else
                vSNode.Remove()
                PatenteDinamica.Baja(vSNode.Tag)
            End If
        Catch ex As Exception
            MessageBox.Show(vTraductor.Traducir("Error al eliminar el elemento seleccionado"), "EvOrg")
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles AceptarBtn.Click
        Me.Close()
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


            End Try

        Next
        If TypeOf pControl Is ContextMenuStrip Then
            For Each vItem As ToolStripMenuItem In DirectCast(pControl, ContextMenuStrip).Items
                Try
                    vItem.Text = vTraductor.IdiomaSeleccionado.Diccionario.Item(vItem.Tag)
                Catch ex As Exception

                End Try
            Next
        End If
    End Sub
End Class