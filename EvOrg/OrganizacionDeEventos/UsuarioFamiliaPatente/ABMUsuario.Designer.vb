﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABMUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ABMUsuario))
        Me.ListaUsuariosLbl = New System.Windows.Forms.Label()
        Me.AltaBtn = New System.Windows.Forms.Button()
        Me.BajaBtn = New System.Windows.Forms.Button()
        Me.ModificacionBtn = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.GrillaUsuario = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.GrillaUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaUsuariosLbl
        '
        Me.ListaUsuariosLbl.AutoSize = True
        Me.ListaUsuariosLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListaUsuariosLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListaUsuariosLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ListaUsuariosLbl.Location = New System.Drawing.Point(3, 0)
        Me.ListaUsuariosLbl.Name = "ListaUsuariosLbl"
        Me.ListaUsuariosLbl.Size = New System.Drawing.Size(329, 26)
        Me.ListaUsuariosLbl.TabIndex = 1
        Me.ListaUsuariosLbl.Tag = "Lista de usuarios"
        Me.ListaUsuariosLbl.Text = "Lista de Usuarios"
        Me.ListaUsuariosLbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft
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
        Me.AltaBtn.Size = New System.Drawing.Size(103, 32)
        Me.AltaBtn.TabIndex = 2
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
        Me.BajaBtn.Location = New System.Drawing.Point(112, 3)
        Me.BajaBtn.Name = "BajaBtn"
        Me.BajaBtn.Size = New System.Drawing.Size(103, 32)
        Me.BajaBtn.TabIndex = 3
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
        Me.ModificacionBtn.Location = New System.Drawing.Point(221, 3)
        Me.ModificacionBtn.Name = "ModificacionBtn"
        Me.ModificacionBtn.Size = New System.Drawing.Size(105, 32)
        Me.ModificacionBtn.TabIndex = 4
        Me.ModificacionBtn.Tag = "Modificar"
        Me.ModificacionBtn.Text = "Modificar"
        Me.ModificacionBtn.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ListaUsuariosLbl, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.GrillaUsuario, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(335, 319)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Controls.Add(Me.ModificacionBtn, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.AltaBtn, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BajaBtn, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 278)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(329, 38)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'GrillaUsuario
        '
        Me.GrillaUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaUsuario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrillaUsuario.Location = New System.Drawing.Point(3, 29)
        Me.GrillaUsuario.Name = "GrillaUsuario"
        Me.GrillaUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrillaUsuario.Size = New System.Drawing.Size(329, 243)
        Me.GrillaUsuario.TabIndex = 0
        '
        'ABMUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(335, 319)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ABMUsuario"
        Me.Text = "EvOrg"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.GrillaUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListaUsuariosLbl As Label
    Friend WithEvents AltaBtn As Button
    Friend WithEvents BajaBtn As Button
    Friend WithEvents ModificacionBtn As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents GrillaUsuario As DataGridView
End Class
