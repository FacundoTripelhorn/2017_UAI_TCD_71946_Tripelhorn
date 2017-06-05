<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ABMMaterial
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ABMMaterial))
        Me.GrillaMateriales = New System.Windows.Forms.DataGridView()
        Me.IdLbl = New System.Windows.Forms.Label()
        Me.IdTxt = New System.Windows.Forms.TextBox()
        Me.NombreTxt = New System.Windows.Forms.TextBox()
        Me.NombreLbl = New System.Windows.Forms.Label()
        Me.CantidadLbl = New System.Windows.Forms.Label()
        Me.CantidadNumeric = New System.Windows.Forms.NumericUpDown()
        Me.AltaBtn = New System.Windows.Forms.Button()
        Me.BajaBtn = New System.Windows.Forms.Button()
        Me.ModificacionBtn = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ListaMaterialesLbl = New System.Windows.Forms.Label()
        Me.PrecioULbl = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.PrecioTxt = New System.Windows.Forms.TextBox()
        CType(Me.GrillaMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CantidadNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrillaMateriales
        '
        Me.GrillaMateriales.AllowUserToAddRows = False
        Me.GrillaMateriales.AllowUserToDeleteRows = False
        Me.GrillaMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableLayoutPanel1.SetColumnSpan(Me.GrillaMateriales, 8)
        Me.GrillaMateriales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrillaMateriales.Location = New System.Drawing.Point(3, 32)
        Me.GrillaMateriales.MinimumSize = New System.Drawing.Size(442, 277)
        Me.GrillaMateriales.Name = "GrillaMateriales"
        Me.GrillaMateriales.ReadOnly = True
        Me.GrillaMateriales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrillaMateriales.Size = New System.Drawing.Size(610, 277)
        Me.GrillaMateriales.TabIndex = 0
        '
        'IdLbl
        '
        Me.IdLbl.AutoSize = True
        Me.IdLbl.BackColor = System.Drawing.Color.Transparent
        Me.IdLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IdLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.IdLbl.Location = New System.Drawing.Point(3, 312)
        Me.IdLbl.Name = "IdLbl"
        Me.IdLbl.Size = New System.Drawing.Size(28, 27)
        Me.IdLbl.TabIndex = 1
        Me.IdLbl.Text = "ID"
        Me.IdLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IdTxt
        '
        Me.IdTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IdTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IdTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdTxt.Location = New System.Drawing.Point(37, 315)
        Me.IdTxt.Name = "IdTxt"
        Me.IdTxt.Size = New System.Drawing.Size(70, 23)
        Me.IdTxt.TabIndex = 0
        '
        'NombreTxt
        '
        Me.NombreTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NombreTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NombreTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreTxt.Location = New System.Drawing.Point(178, 315)
        Me.NombreTxt.Name = "NombreTxt"
        Me.NombreTxt.Size = New System.Drawing.Size(94, 23)
        Me.NombreTxt.TabIndex = 1
        '
        'NombreLbl
        '
        Me.NombreLbl.AutoSize = True
        Me.NombreLbl.BackColor = System.Drawing.Color.Transparent
        Me.NombreLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NombreLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.NombreLbl.Location = New System.Drawing.Point(113, 312)
        Me.NombreLbl.Name = "NombreLbl"
        Me.NombreLbl.Size = New System.Drawing.Size(59, 27)
        Me.NombreLbl.TabIndex = 3
        Me.NombreLbl.Text = "Nombre"
        Me.NombreLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CantidadLbl
        '
        Me.CantidadLbl.AutoSize = True
        Me.CantidadLbl.BackColor = System.Drawing.Color.Transparent
        Me.CantidadLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CantidadLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CantidadLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CantidadLbl.Location = New System.Drawing.Point(278, 312)
        Me.CantidadLbl.Name = "CantidadLbl"
        Me.CantidadLbl.Size = New System.Drawing.Size(68, 27)
        Me.CantidadLbl.TabIndex = 5
        Me.CantidadLbl.Text = "Cantidad"
        Me.CantidadLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CantidadNumeric
        '
        Me.CantidadNumeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CantidadNumeric.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CantidadNumeric.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CantidadNumeric.Location = New System.Drawing.Point(352, 315)
        Me.CantidadNumeric.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.CantidadNumeric.Name = "CantidadNumeric"
        Me.CantidadNumeric.Size = New System.Drawing.Size(60, 23)
        Me.CantidadNumeric.TabIndex = 2
        '
        'AltaBtn
        '
        Me.AltaBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AltaBtn.BackColor = System.Drawing.Color.Transparent
        Me.AltaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AltaBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AltaBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.AltaBtn.Location = New System.Drawing.Point(3, 3)
        Me.AltaBtn.Name = "AltaBtn"
        Me.AltaBtn.Size = New System.Drawing.Size(197, 30)
        Me.AltaBtn.TabIndex = 4
        Me.AltaBtn.Text = "Agregar"
        Me.AltaBtn.UseVisualStyleBackColor = False
        '
        'BajaBtn
        '
        Me.BajaBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BajaBtn.BackColor = System.Drawing.Color.Transparent
        Me.BajaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BajaBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BajaBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BajaBtn.Location = New System.Drawing.Point(206, 3)
        Me.BajaBtn.Name = "BajaBtn"
        Me.BajaBtn.Size = New System.Drawing.Size(197, 30)
        Me.BajaBtn.TabIndex = 5
        Me.BajaBtn.Text = "Borrar"
        Me.BajaBtn.UseVisualStyleBackColor = False
        '
        'ModificacionBtn
        '
        Me.ModificacionBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ModificacionBtn.BackColor = System.Drawing.Color.Transparent
        Me.ModificacionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ModificacionBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModificacionBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ModificacionBtn.Location = New System.Drawing.Point(409, 3)
        Me.ModificacionBtn.Name = "ModificacionBtn"
        Me.ModificacionBtn.Size = New System.Drawing.Size(198, 30)
        Me.ModificacionBtn.TabIndex = 6
        Me.ModificacionBtn.Text = "Modificar"
        Me.ModificacionBtn.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 8
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GrillaMateriales, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.IdLbl, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.IdTxt, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.NombreLbl, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.NombreTxt, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.CantidadLbl, 4, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.CantidadNumeric, 5, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ListaMaterialesLbl, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PrecioULbl, 6, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.PrecioTxt, 7, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.354839!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.64516!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(616, 381)
        Me.TableLayoutPanel1.TabIndex = 10
        '
        'ListaMaterialesLbl
        '
        Me.ListaMaterialesLbl.AutoSize = True
        Me.ListaMaterialesLbl.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.SetColumnSpan(Me.ListaMaterialesLbl, 3)
        Me.ListaMaterialesLbl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ListaMaterialesLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListaMaterialesLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ListaMaterialesLbl.Location = New System.Drawing.Point(3, 12)
        Me.ListaMaterialesLbl.Name = "ListaMaterialesLbl"
        Me.ListaMaterialesLbl.Size = New System.Drawing.Size(169, 17)
        Me.ListaMaterialesLbl.TabIndex = 10
        Me.ListaMaterialesLbl.Text = "Lista de Materiales"
        '
        'PrecioULbl
        '
        Me.PrecioULbl.AutoSize = True
        Me.PrecioULbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrecioULbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrecioULbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.PrecioULbl.Location = New System.Drawing.Point(418, 312)
        Me.PrecioULbl.Name = "PrecioULbl"
        Me.PrecioULbl.Size = New System.Drawing.Size(105, 27)
        Me.PrecioULbl.TabIndex = 11
        Me.PrecioULbl.Text = "Precio Unitario"
        Me.PrecioULbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel1.SetColumnSpan(Me.TableLayoutPanel2, 8)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Controls.Add(Me.ModificacionBtn, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BajaBtn, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.AltaBtn, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 342)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(610, 36)
        Me.TableLayoutPanel2.TabIndex = 13
        '
        'PrecioTxt
        '
        Me.PrecioTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrecioTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrecioTxt.Location = New System.Drawing.Point(529, 315)
        Me.PrecioTxt.Name = "PrecioTxt"
        Me.PrecioTxt.Size = New System.Drawing.Size(84, 23)
        Me.PrecioTxt.TabIndex = 3
        '
        'ABMMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(616, 381)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(464, 420)
        Me.Name = "ABMMaterial"
        Me.Text = "EvOrg"
        CType(Me.GrillaMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CantidadNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GrillaMateriales As DataGridView
    Friend WithEvents IdLbl As Label
    Friend WithEvents IdTxt As TextBox
    Friend WithEvents NombreTxt As TextBox
    Friend WithEvents NombreLbl As Label
    Friend WithEvents CantidadLbl As Label
    Friend WithEvents CantidadNumeric As NumericUpDown
    Friend WithEvents AltaBtn As Button
    Friend WithEvents BajaBtn As Button
    Friend WithEvents ModificacionBtn As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ListaMaterialesLbl As Label
    Friend WithEvents PrecioULbl As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents PrecioTxt As TextBox
End Class
