Public MustInherit Class PatenteAbstractaDinamica
    Public MustOverride Function MostrarEnTreeView(pTreeView As Windows.Forms.TreeView) As Windows.Forms.TreeView
    Public MustOverride Sub MostrarEnMenuStrip(pMenuStrip As Windows.Forms.MenuStrip, pUsuario As BLL_Estatica.Usuario, pFormulario As Windows.Forms.Form)
End Class
