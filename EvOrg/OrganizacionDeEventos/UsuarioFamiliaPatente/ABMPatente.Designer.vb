﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABMPatente
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ABMPatente))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TreePatente = New System.Windows.Forms.TreeView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AgregarPatenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarGrupoDePatentesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarElementoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AceptarBtn = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TreePatente, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.AceptarBtn, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(362, 305)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TreePatente
        '
        Me.TreePatente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreePatente.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TreePatente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreePatente.Location = New System.Drawing.Point(3, 3)
        Me.TreePatente.Name = "TreePatente"
        Me.TreePatente.Size = New System.Drawing.Size(356, 244)
        Me.TreePatente.TabIndex = 1
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarPatenteToolStripMenuItem, Me.AgregarGrupoDePatentesToolStripMenuItem, Me.EliminarElementoToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(217, 70)
        '
        'AgregarPatenteToolStripMenuItem
        '
        Me.AgregarPatenteToolStripMenuItem.Name = "AgregarPatenteToolStripMenuItem"
        Me.AgregarPatenteToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.AgregarPatenteToolStripMenuItem.Tag = "Agregar patente"
        Me.AgregarPatenteToolStripMenuItem.Text = "Agregar Patente"
        '
        'AgregarGrupoDePatentesToolStripMenuItem
        '
        Me.AgregarGrupoDePatentesToolStripMenuItem.Name = "AgregarGrupoDePatentesToolStripMenuItem"
        Me.AgregarGrupoDePatentesToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.AgregarGrupoDePatentesToolStripMenuItem.Tag = "Agregar grupo de patentes"
        Me.AgregarGrupoDePatentesToolStripMenuItem.Text = "Agregar Grupo de Patentes"
        '
        'EliminarElementoToolStripMenuItem
        '
        Me.EliminarElementoToolStripMenuItem.Name = "EliminarElementoToolStripMenuItem"
        Me.EliminarElementoToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.EliminarElementoToolStripMenuItem.Tag = "Eliminar elemento"
        Me.EliminarElementoToolStripMenuItem.Text = "Eliminar Elemento"
        '
        'AceptarBtn
        '
        Me.AceptarBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AceptarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AceptarBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AceptarBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.AceptarBtn.Location = New System.Drawing.Point(3, 253)
        Me.AceptarBtn.Name = "AceptarBtn"
        Me.AceptarBtn.Size = New System.Drawing.Size(356, 49)
        Me.AceptarBtn.TabIndex = 2
        Me.AceptarBtn.Tag = "Aceptar"
        Me.AceptarBtn.Text = "Aceptar"
        Me.AceptarBtn.UseVisualStyleBackColor = True
        '
        'ABMPatente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(362, 305)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ABMPatente"
        Me.Text = "EvOrg"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TreePatente As TreeView
    Friend WithEvents AceptarBtn As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents AgregarPatenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarGrupoDePatentesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarElementoToolStripMenuItem As ToolStripMenuItem
End Class
