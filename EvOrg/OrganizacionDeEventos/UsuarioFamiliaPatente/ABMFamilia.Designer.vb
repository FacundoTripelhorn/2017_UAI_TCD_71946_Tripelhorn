<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABMFamilia
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ABMFamilia))
        Me.FamiliaTxt = New System.Windows.Forms.TextBox()
        Me.TreePatente = New System.Windows.Forms.TreeView()
        Me.FamiliaListbox = New System.Windows.Forms.ListBox()
        Me.AltaBtn = New System.Windows.Forms.Button()
        Me.BajaBtn = New System.Windows.Forms.Button()
        Me.ModificacionBtn = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.FamiliaLbl = New System.Windows.Forms.Label()
        Me.ListaFamiliasLbl = New System.Windows.Forms.Label()
        Me.SeleccionePatentesLbl = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'FamiliaTxt
        '
        Me.FamiliaTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FamiliaTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FamiliaTxt.Location = New System.Drawing.Point(3, 24)
        Me.FamiliaTxt.Name = "FamiliaTxt"
        Me.FamiliaTxt.Size = New System.Drawing.Size(170, 23)
        Me.FamiliaTxt.TabIndex = 0
        '
        'TreePatente
        '
        Me.TreePatente.CheckBoxes = True
        Me.TreePatente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreePatente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreePatente.Location = New System.Drawing.Point(179, 80)
        Me.TreePatente.Name = "TreePatente"
        Me.TreePatente.Size = New System.Drawing.Size(215, 218)
        Me.TreePatente.TabIndex = 1
        '
        'FamiliaListbox
        '
        Me.FamiliaListbox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FamiliaListbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FamiliaListbox.FormattingEnabled = True
        Me.FamiliaListbox.ItemHeight = 16
        Me.FamiliaListbox.Location = New System.Drawing.Point(3, 80)
        Me.FamiliaListbox.Name = "FamiliaListbox"
        Me.FamiliaListbox.Size = New System.Drawing.Size(170, 218)
        Me.FamiliaListbox.TabIndex = 2
        '
        'AltaBtn
        '
        Me.AltaBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AltaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AltaBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AltaBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.AltaBtn.Location = New System.Drawing.Point(3, 3)
        Me.AltaBtn.Name = "AltaBtn"
        Me.AltaBtn.Size = New System.Drawing.Size(124, 42)
        Me.AltaBtn.TabIndex = 3
        Me.AltaBtn.Tag = "Agregar"
        Me.AltaBtn.Text = "Agregar"
        Me.AltaBtn.UseVisualStyleBackColor = True
        '
        'BajaBtn
        '
        Me.BajaBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BajaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BajaBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BajaBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BajaBtn.Location = New System.Drawing.Point(133, 3)
        Me.BajaBtn.Name = "BajaBtn"
        Me.BajaBtn.Size = New System.Drawing.Size(124, 42)
        Me.BajaBtn.TabIndex = 4
        Me.BajaBtn.Tag = "Eliminar"
        Me.BajaBtn.Text = "Eliminar"
        Me.BajaBtn.UseVisualStyleBackColor = True
        '
        'ModificacionBtn
        '
        Me.ModificacionBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ModificacionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ModificacionBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModificacionBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ModificacionBtn.Location = New System.Drawing.Point(263, 3)
        Me.ModificacionBtn.Name = "ModificacionBtn"
        Me.ModificacionBtn.Size = New System.Drawing.Size(125, 42)
        Me.ModificacionBtn.TabIndex = 5
        Me.ModificacionBtn.Tag = "Modificar"
        Me.ModificacionBtn.Text = "Modificar"
        Me.ModificacionBtn.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.58438!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.41562!))
        Me.TableLayoutPanel1.Controls.Add(Me.FamiliaTxt, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FamiliaLbl, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.FamiliaListbox, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TreePatente, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.ListaFamiliasLbl, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.SeleccionePatentesLbl, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(397, 355)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'FamiliaLbl
        '
        Me.FamiliaLbl.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.FamiliaLbl, 2)
        Me.FamiliaLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FamiliaLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FamiliaLbl.Location = New System.Drawing.Point(3, 0)
        Me.FamiliaLbl.Name = "FamiliaLbl"
        Me.FamiliaLbl.Size = New System.Drawing.Size(391, 21)
        Me.FamiliaLbl.TabIndex = 1
        Me.FamiliaLbl.Tag = "Ingrese el nombre de la familia"
        Me.FamiliaLbl.Text = "Ingrese el nombre de la Familia"
        '
        'ListaFamiliasLbl
        '
        Me.ListaFamiliasLbl.AutoSize = True
        Me.ListaFamiliasLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListaFamiliasLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListaFamiliasLbl.Location = New System.Drawing.Point(3, 51)
        Me.ListaFamiliasLbl.Name = "ListaFamiliasLbl"
        Me.ListaFamiliasLbl.Size = New System.Drawing.Size(170, 26)
        Me.ListaFamiliasLbl.TabIndex = 3
        Me.ListaFamiliasLbl.Tag = "Lista de familias"
        Me.ListaFamiliasLbl.Text = "Lista de Familias"
        '
        'SeleccionePatentesLbl
        '
        Me.SeleccionePatentesLbl.AutoSize = True
        Me.SeleccionePatentesLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SeleccionePatentesLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeleccionePatentesLbl.Location = New System.Drawing.Point(179, 51)
        Me.SeleccionePatentesLbl.Name = "SeleccionePatentesLbl"
        Me.SeleccionePatentesLbl.Size = New System.Drawing.Size(215, 26)
        Me.SeleccionePatentesLbl.TabIndex = 4
        Me.SeleccionePatentesLbl.Tag = "Seleccione las patentes"
        Me.SeleccionePatentesLbl.Text = "Seleccione las patentes"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel1.SetColumnSpan(Me.TableLayoutPanel2, 2)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Controls.Add(Me.AltaBtn, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BajaBtn, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ModificacionBtn, 2, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 304)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(391, 48)
        Me.TableLayoutPanel2.TabIndex = 5
        '
        'ABMFamilia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(397, 355)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ABMFamilia"
        Me.Text = "EvOrg"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FamiliaTxt As TextBox
    Friend WithEvents TreePatente As TreeView
    Friend WithEvents FamiliaListbox As ListBox
    Friend WithEvents AltaBtn As Button
    Friend WithEvents BajaBtn As Button
    Friend WithEvents ModificacionBtn As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents FamiliaLbl As Label
    Friend WithEvents ListaFamiliasLbl As Label
    Friend WithEvents SeleccionePatentesLbl As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
End Class
