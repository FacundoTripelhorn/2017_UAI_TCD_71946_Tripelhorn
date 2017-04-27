Imports BLL_Dinamica
Imports BLL_Estatica

Public Class ABMFamilia
    Property FamiliaDinamica As New FamiliaDinamica
    Property Familia As New Familia
    Property GrupoPatenteDinamico As New GrupoPatenteDinamico


    Private Sub ABMFamilia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim vLista As New List(Of Object)
        vLista = GrupoPatenteDinamico.ConsultaTodo()
        GrupoPatenteDinamico.MostrarEnTreeView(TreePatente)
        ActualizarLista()
    End Sub

    Private Sub ActualizarLista()
        Dim vLista As New List(Of Object)
        FamiliaListbox.Items.Clear()
        vLista = FamiliaDinamica.ConsultaTodo
        For Each vFamilia As Familia In vLista
            FamiliaListbox.Items.Add(vFamilia.Nombre)
        Next
    End Sub

    Private Sub AltaBtn_Click(sender As Object, e As EventArgs) Handles AltaBtn.Click
        If Not FamiliaTxt.Text = "" Then
            Familia.Nombre = FamiliaTxt.Text
            If TreePatente.Nodes.Item(0).Checked Then
                Familia.ListaPatentes.Add(TreePatente.Nodes.Item(0).Tag)
            End If
            AgregarPatentes(Familia, TreePatente.Nodes.Item(0))
            FamiliaDinamica.Alta(Familia)
        Else
            MsgBox("La Familia tiene que tener un nombre")
        End If
        TreePatente.Nodes.Clear()
        ABMFamilia_Load(Nothing, Nothing)
    End Sub

    Private Sub AgregarPatentes(pFamilia As Familia, pTreeNode As TreeNode)
        For Each vNode As TreeNode In pTreeNode.Nodes
            If vNode.Checked Then
                pFamilia.ListaPatentes.Add(vNode.Tag)
            End If
            If Not vNode.Nodes Is Nothing Then
                AgregarPatentes(pFamilia, vNode)
            End If
        Next
    End Sub

    Private Sub TreePatente_AfterCheck(sender As Object, e As TreeViewEventArgs) Handles TreePatente.AfterCheck
        Dim vNode As New TreeNode
        vNode = e.Node
        If vNode.Checked Then
            For Each vHijo As TreeNode In vNode.Nodes
                vHijo.Checked = True
            Next
        Else
            For Each vHijo As TreeNode In vNode.Nodes
                vHijo.Checked = False
            Next
        End If
    End Sub

    Private Sub BajaBtn_Click(sender As Object, e As EventArgs) Handles BajaBtn.Click
        Familia.Nombre = FamiliaListbox.SelectedItem.ToString
        FamiliaDinamica.Baja(Familia)
        ActualizarLista()
    End Sub

    Private Sub ModificacionBtn_Click(sender As Object, e As EventArgs) Handles ModificacionBtn.Click
        Try
            Dim vFamilia As New Familia
            vFamilia.Nombre = FamiliaListbox.SelectedItem.ToString
            If TreePatente.Nodes.Item(0).Checked Then
                vFamilia.ListaPatentes.Add(TreePatente.Nodes.Item(0).Tag)
            End If
            AgregarPatentes(vFamilia, TreePatente.Nodes.Item(0))
            FamiliaDinamica.Modificacion(vFamilia)
            ActualizarLista()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FamiliaListbox_SelectedValueChanged(sender As Object, e As EventArgs) Handles FamiliaListbox.SelectedValueChanged
        TreePatente.Nodes.Item(0).Checked = False
        Familia.Nombre = FamiliaListbox.SelectedItem.ToString
        Dim vLista As List(Of Object)
        vLista = FamiliaDinamica.ListarPatentes(Familia)

        For Each vPatente As PatenteAbstracta In vLista
            For Each vNode As TreeNode In TreePatente.Nodes
                If vPatente.Nombre = vNode.Text.ToString Then
                    vNode.Checked = True
                    ChequearNodos(vNode, vPatente)
                Else
                    ChequearNodos(vNode, vPatente)
                End If
            Next
        Next
        TreePatente.ExpandAll()
    End Sub

    Private Sub ChequearNodos(pNode As TreeNode, pPatente As PatenteAbstracta)
        For Each vNode As TreeNode In pNode.Nodes
            If pPatente.Nombre = vNode.Text.ToString Then
                vNode.Checked = True
                ChequearNodos(vNode, pPatente)
            Else
                ChequearNodos(vNode, pPatente)
            End If
        Next
    End Sub
End Class