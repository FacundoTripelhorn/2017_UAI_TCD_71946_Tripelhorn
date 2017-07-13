Imports BLL_Dinamica
Imports BLL_Estatica
Imports OrganizacionDeEventos

Public Class ABMFamilia
    Implements IObservador
    Dim vTraductor As Traductor = Traductor.GetInstance
    Property FamiliaDinamica As New FamiliaDinamica
    Property Familia As New Familia
    Property GrupoPatenteDinamico As New GrupoPatenteDinamico


    Private Sub ABMFamilia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vTraductor.Registrar(Me)
        Dim vLista As New List(Of Object)
        vLista = GrupoPatenteDinamico.ConsultaTodo()
        GrupoPatenteDinamico.MostrarEnTreeView(TreePatente)
        TreePatente.ExpandAll()
        ActualizarLista()
        ActualizarObservador(Me)
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
            If FamiliaDinamica.CheckFamilia(Familia.Nombre) Then

                If TreePatente.Nodes.Item(0).Checked Then
                    Familia.ListaPatentes.Add(TreePatente.Nodes.Item(0).Tag)
                End If
                AgregarPatentes(Familia, TreePatente.Nodes.Item(0))
                FamiliaDinamica.Alta(Familia)
            Else
                MessageBox.Show(vTraductor.Traducir("El nombre de familia ingresado ya existe"), "EvOrg")
            End If
        Else
                MessageBox.Show(vTraductor.Traducir("La Familia tiene que tener un nombre"), "EvOrg")
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
        UncheckearNodos(TreePatente.Nodes.Item(0))
        Familia.Nombre = FamiliaListbox.SelectedItem.ToString
        Dim vLista As List(Of Object)
        vLista = FamiliaDinamica.ListarPatentes(Familia)

        For Each vPatente As PatenteAbstracta In vLista
            If TypeOf vPatente Is GrupoPatente Then
                Dim vGPatente As GrupoPatente = DirectCast(vPatente, GrupoPatente)
                For Each vNode As TreeNode In TreePatente.Nodes
                    If vGPatente.Nombre = vNode.Text.ToString Then
                        vNode.Checked = True
                        ChequearNodos(vNode, vGPatente.ListaPatentes)
                    End If
                Next
            End If
        Next
        TreePatente.ExpandAll()
    End Sub

    Private Sub ChequearNodos(pNode As TreeNode, pLista As List(Of PatenteAbstracta))
        For Each vPatente As PatenteAbstracta In pLista
            For Each vNode As TreeNode In pNode.Nodes
                If vPatente.Nombre = vNode.Text.ToString Then
                    vNode.Checked = True
                    Dim vGPatente As GrupoPatente
                    If TypeOf vPatente Is GrupoPatente Then
                        vGPatente = DirectCast(vPatente, GrupoPatente)
                        ChequearNodos(vNode, vGPatente.ListaPatentes)
                    End If
                End If
            Next
        Next
    End Sub

    Private Sub UncheckearNodos(pNode As TreeNode)
        For Each vNode As TreeNode In pNode.Nodes
            vNode.Checked = False
            If vNode.Nodes.Count > 0 Then
                UncheckearNodos(vNode)
            End If
        Next
    End Sub

    Private Sub TreePatente_AfterExpand(sender As Object, e As TreeViewEventArgs) Handles TreePatente.AfterExpand
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

    Public Sub ActualizarObservador(Optional pControl As Control = Nothing) Implements IObservador.ActualizarObservador
        For Each vControl As Control In pControl.Controls
            Try
                vControl.Text = vTraductor.IdiomaSeleccionado.Diccionario.Item(vControl.Tag.ToString)
            Catch ex As Exception
            Finally
                If vControl.Controls.Count > 0 Then
                    ActualizarObservador(vControl)
                End If
                If TypeOf vControl Is DataGridView Then
                    For Each vColumna As DataGridViewColumn In DirectCast(vControl, DataGridView).Columns
                        Try
                            vColumna.HeaderText = vTraductor.IdiomaSeleccionado.Diccionario.Item(vColumna.Name)
                        Catch ex As Exception

                        End Try
                    Next
                End If
            End Try
        Next
    End Sub
End Class