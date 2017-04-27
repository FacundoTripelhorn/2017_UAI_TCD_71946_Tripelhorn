Imports System.Windows.Forms
Imports BLL_Estatica
Imports DAL_ABMC
Imports System.Reflection
Public Class GrupoPatenteDinamico
    Inherits PatenteAbstractaDinamica
    Implements IABMC

    Property GrupoPatenteDatos As New GrupoPatenteDatos
    Public Sub Alta(Optional pObjeto As Object = Nothing) Implements IABMC.Alta
        GrupoPatenteDatos.Alta(pObjeto)
    End Sub

    Public Sub Baja(Optional pObjeto As Object = Nothing) Implements IABMC.Baja
        GrupoPatenteDatos.Baja(pObjeto)
    End Sub

    Public Sub Modificacion(Optional pObjeto As Object = Nothing) Implements IABMC.Modificacion
        GrupoPatenteDatos.Modificacion(pObjeto)
    End Sub

    Public Function ConsultaTodo() As List(Of Object) Implements IABMC.ConsultaTodo
        Return GrupoPatenteDatos.ConsultaTodo()
    End Function

    Public Overrides Function MostrarEnTreeView(pTreeView As TreeView) As TreeView
        Try
            Dim vListaGrupoPatente As New List(Of PatenteAbstracta)
            vListaGrupoPatente = GrupoPatenteDatos.Listar()
            Dim vNode As TreeNode = pTreeView.Nodes.Add(vListaGrupoPatente.Item(0).Nombre)
            vNode.Tag = vListaGrupoPatente.Item(0)
            AgregarHijos(vNode.Tag, vNode)
        Catch ex As Exception

        End Try
        Return pTreeView
    End Function

    Private Sub AgregarHijos(pPadre As GrupoPatente, pTreeNode As TreeNode)
        For Each vPAbstracta As PatenteAbstracta In pPadre.ListaPatentes
            Dim vNode As New TreeNode
            vNode.Text = vPAbstracta.Nombre
            vNode.Tag = vPAbstracta
            pTreeNode.Nodes.Add(vNode)
            If TypeOf vPAbstracta Is GrupoPatente Then
                vNode.Text = vPAbstracta.Nombre
                Dim vGPatente As GrupoPatente
                vGPatente = DirectCast(vPAbstracta, GrupoPatente)
                If Not vGPatente.ListaPatentes Is Nothing Then
                    AgregarHijos(vGPatente, pTreeNode.LastNode)
                End If
            End If
        Next
    End Sub

    Public Overrides Sub MostrarEnMenuStrip(pMenuStrip As MenuStrip, pUsuario As Usuario, pFormulario As Form)
        Dim vLista As New List(Of PatenteAbstracta)
        Dim vFamiliaDatos As New FamiliaDatos
        Dim vUsuarioDinamico As New UsuarioDinamico
        Dim vUsuario As Usuario = vUsuarioDinamico.DevuelveUsuario(pUsuario.IdUsuario)
        vLista = vUsuario.Familia.GetPatentes
        If vLista.Item(0).Nombre = "Patentes del Sistema" Then
            Dim vPSistema As GrupoPatente = DirectCast(vLista.Item(0), GrupoPatente)
            For Each vPAbstracta As PatenteAbstracta In vPSistema.ListaPatentes
                Dim vTool As New ToolStripMenuItem
                vTool.Name = vPAbstracta.Nombre
                vTool.Text = vPAbstracta.Nombre
                vTool.Tag = vPAbstracta
                pMenuStrip.Items.Add(vTool)
                pMenuStrip.Items.Item(vTool.Name).Text = vPAbstracta.Nombre
                If TypeOf vPAbstracta Is GrupoPatente Then
                    AgregarToolStrip(vPAbstracta, vTool, pFormulario)
                End If
            Next
        Else
            For Each vPAbstracta As PatenteAbstracta In vLista
                Dim vTool As New ToolStripMenuItem
                vTool.Name = vPAbstracta.Nombre
                vTool.Tag = vPAbstracta
                pMenuStrip.Items.Add(vTool)
                pMenuStrip.Items.Item(vTool.Name).Text = vPAbstracta.Nombre
                If TypeOf vPAbstracta Is GrupoPatente Then
                    AgregarToolStrip(vPAbstracta, vTool, pFormulario)
                End If
            Next
        End If
    End Sub

    Public Sub AgregarToolStrip(pPAbstracta As PatenteAbstracta, pTool As ToolStripMenuItem, pFormulario As Form)
        Try
            Dim vPadre As GrupoPatente = DirectCast(pPAbstracta, GrupoPatente)
            If Not vPadre.ListaPatentes Is Nothing Then
                For Each vPAbstracta As PatenteAbstracta In vPadre.ListaPatentes
                    Dim vTool As New ToolStripMenuItem
                    vTool.Name = vPAbstracta.Nombre
                    vTool.Text = vPAbstracta.Nombre
                    vTool.Tag = vPAbstracta
                    pTool.DropDownItems.Add(vTool)
                    pTool.DropDownItems.Item(vTool.Name).Text = vPAbstracta.Nombre
                    AddHandler vTool.Click, AddressOf Menu_Click
                    If TypeOf vPAbstracta Is GrupoPatente Then
                        AgregarToolStrip(vPAbstracta, vTool, pFormulario)
                    End If
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub Menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim vSTool As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
        Click(vSTool)
    End Sub
    Private Sub Click(pTool As ToolStripItem)
        Dim vFName As String = "OrganizacionDeEventos." & DirectCast(pTool.Tag, Patente).Formulario.ToString
        Dim vAsm As Assembly = Assembly.GetEntryAssembly
        Dim vTipo As Type = vAsm.GetType(vFName)
        Dim vForm = Activator.CreateInstance(vTipo)
        vForm.ShowDialog()
    End Sub

End Class
