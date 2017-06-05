<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABMTipoEvento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ABMTipoEvento))
        Me.GrillaTipoEvento = New System.Windows.Forms.DataGridView()
        Me.TiposEventoLbl = New System.Windows.Forms.Label()
        Me.NombreLbl = New System.Windows.Forms.Label()
        Me.DescripcionLbl = New System.Windows.Forms.Label()
        Me.PasosLbl = New System.Windows.Forms.Label()
        Me.GrillaPasos = New System.Windows.Forms.DataGridView()
        Me.NombreTxt = New System.Windows.Forms.TextBox()
        Me.DescripcionTxt = New System.Windows.Forms.TextBox()
        Me.PasoGPB = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.PrioridadCombo = New System.Windows.Forms.ComboBox()
        Me.BajaPasoBtn = New System.Windows.Forms.Button()
        Me.PrioridadLbl = New System.Windows.Forms.Label()
        Me.DescripcionLbl2 = New System.Windows.Forms.Label()
        Me.AltaPasoBtn = New System.Windows.Forms.Button()
        Me.DiasLbl = New System.Windows.Forms.Label()
        Me.DescripcionTxt2 = New System.Windows.Forms.TextBox()
        Me.DiasNumeric = New System.Windows.Forms.NumericUpDown()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.AltaBtn = New System.Windows.Forms.Button()
        Me.BajaBtn = New System.Windows.Forms.Button()
        Me.ModificacionBtn = New System.Windows.Forms.Button()
        CType(Me.GrillaTipoEvento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrillaPasos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PasoGPB.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.DiasNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrillaTipoEvento
        '
        Me.GrillaTipoEvento.AllowUserToAddRows = False
        Me.GrillaTipoEvento.AllowUserToDeleteRows = False
        Me.GrillaTipoEvento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaTipoEvento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrillaTipoEvento.Location = New System.Drawing.Point(3, 26)
        Me.GrillaTipoEvento.Name = "GrillaTipoEvento"
        Me.GrillaTipoEvento.ReadOnly = True
        Me.TableLayoutPanel1.SetRowSpan(Me.GrillaTipoEvento, 5)
        Me.GrillaTipoEvento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrillaTipoEvento.Size = New System.Drawing.Size(143, 245)
        Me.GrillaTipoEvento.TabIndex = 0
        '
        'TiposEventoLbl
        '
        Me.TiposEventoLbl.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.TiposEventoLbl, 2)
        Me.TiposEventoLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TiposEventoLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TiposEventoLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TiposEventoLbl.Location = New System.Drawing.Point(3, 0)
        Me.TiposEventoLbl.Name = "TiposEventoLbl"
        Me.TiposEventoLbl.Size = New System.Drawing.Size(292, 23)
        Me.TiposEventoLbl.TabIndex = 1
        Me.TiposEventoLbl.Text = "Lista de Tipos de Evento"
        '
        'NombreLbl
        '
        Me.NombreLbl.AutoSize = True
        Me.NombreLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NombreLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.NombreLbl.Location = New System.Drawing.Point(152, 23)
        Me.NombreLbl.Name = "NombreLbl"
        Me.NombreLbl.Size = New System.Drawing.Size(143, 20)
        Me.NombreLbl.TabIndex = 2
        Me.NombreLbl.Text = "Nombre"
        '
        'DescripcionLbl
        '
        Me.DescripcionLbl.AutoSize = True
        Me.DescripcionLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DescripcionLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescripcionLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.DescripcionLbl.Location = New System.Drawing.Point(152, 75)
        Me.DescripcionLbl.Name = "DescripcionLbl"
        Me.DescripcionLbl.Size = New System.Drawing.Size(143, 25)
        Me.DescripcionLbl.TabIndex = 3
        Me.DescripcionLbl.Text = "Descripción"
        '
        'PasosLbl
        '
        Me.PasosLbl.AutoSize = True
        Me.PasosLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PasosLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasosLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.PasosLbl.Location = New System.Drawing.Point(301, 0)
        Me.PasosLbl.Name = "PasosLbl"
        Me.PasosLbl.Size = New System.Drawing.Size(414, 23)
        Me.PasosLbl.TabIndex = 4
        Me.PasosLbl.Text = "Lista de Pasos"
        '
        'GrillaPasos
        '
        Me.GrillaPasos.AllowUserToAddRows = False
        Me.GrillaPasos.AllowUserToDeleteRows = False
        Me.GrillaPasos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaPasos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrillaPasos.Location = New System.Drawing.Point(301, 26)
        Me.GrillaPasos.Name = "GrillaPasos"
        Me.GrillaPasos.ReadOnly = True
        Me.TableLayoutPanel1.SetRowSpan(Me.GrillaPasos, 4)
        Me.GrillaPasos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrillaPasos.Size = New System.Drawing.Size(414, 134)
        Me.GrillaPasos.TabIndex = 5
        '
        'NombreTxt
        '
        Me.NombreTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NombreTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreTxt.Location = New System.Drawing.Point(152, 46)
        Me.NombreTxt.Name = "NombreTxt"
        Me.NombreTxt.Size = New System.Drawing.Size(143, 23)
        Me.NombreTxt.TabIndex = 1
        '
        'DescripcionTxt
        '
        Me.DescripcionTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DescripcionTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescripcionTxt.Location = New System.Drawing.Point(152, 103)
        Me.DescripcionTxt.Multiline = True
        Me.DescripcionTxt.Name = "DescripcionTxt"
        Me.TableLayoutPanel1.SetRowSpan(Me.DescripcionTxt, 2)
        Me.DescripcionTxt.Size = New System.Drawing.Size(143, 168)
        Me.DescripcionTxt.TabIndex = 7
        '
        'PasoGPB
        '
        Me.PasoGPB.Controls.Add(Me.TableLayoutPanel3)
        Me.PasoGPB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PasoGPB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasoGPB.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.PasoGPB.Location = New System.Drawing.Point(301, 166)
        Me.PasoGPB.Name = "PasoGPB"
        Me.PasoGPB.Size = New System.Drawing.Size(414, 105)
        Me.PasoGPB.TabIndex = 8
        Me.PasoGPB.TabStop = False
        Me.PasoGPB.Text = "Paso"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 187.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.PrioridadCombo, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.BajaPasoBtn, 2, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.PrioridadLbl, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.DescripcionLbl2, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.AltaPasoBtn, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.DiasLbl, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.DescripcionTxt2, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.DiasNumeric, 1, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 19)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 4
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.92683!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.07317!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.63415!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.36585!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(408, 83)
        Me.TableLayoutPanel3.TabIndex = 8
        '
        'PrioridadCombo
        '
        Me.PrioridadCombo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrioridadCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PrioridadCombo.FormattingEnabled = True
        Me.PrioridadCombo.Location = New System.Drawing.Point(104, 56)
        Me.PrioridadCombo.Name = "PrioridadCombo"
        Me.PrioridadCombo.Size = New System.Drawing.Size(181, 24)
        Me.PrioridadCombo.TabIndex = 5
        '
        'BajaPasoBtn
        '
        Me.BajaPasoBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BajaPasoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BajaPasoBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BajaPasoBtn.Location = New System.Drawing.Point(291, 44)
        Me.BajaPasoBtn.Name = "BajaPasoBtn"
        Me.TableLayoutPanel3.SetRowSpan(Me.BajaPasoBtn, 2)
        Me.BajaPasoBtn.Size = New System.Drawing.Size(114, 36)
        Me.BajaPasoBtn.TabIndex = 6
        Me.BajaPasoBtn.Text = "Borrar Paso"
        Me.BajaPasoBtn.UseVisualStyleBackColor = True
        '
        'PrioridadLbl
        '
        Me.PrioridadLbl.AutoSize = True
        Me.PrioridadLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrioridadLbl.Location = New System.Drawing.Point(3, 53)
        Me.PrioridadLbl.Name = "PrioridadLbl"
        Me.PrioridadLbl.Size = New System.Drawing.Size(95, 30)
        Me.PrioridadLbl.TabIndex = 3
        Me.PrioridadLbl.Text = "Prioridad"
        '
        'DescripcionLbl2
        '
        Me.DescripcionLbl2.AutoSize = True
        Me.DescripcionLbl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DescripcionLbl2.Location = New System.Drawing.Point(3, 0)
        Me.DescripcionLbl2.Name = "DescripcionLbl2"
        Me.DescripcionLbl2.Size = New System.Drawing.Size(95, 27)
        Me.DescripcionLbl2.TabIndex = 0
        Me.DescripcionLbl2.Text = "Descripción"
        '
        'AltaPasoBtn
        '
        Me.AltaPasoBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AltaPasoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AltaPasoBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.AltaPasoBtn.Location = New System.Drawing.Point(291, 3)
        Me.AltaPasoBtn.Name = "AltaPasoBtn"
        Me.TableLayoutPanel3.SetRowSpan(Me.AltaPasoBtn, 2)
        Me.AltaPasoBtn.Size = New System.Drawing.Size(114, 35)
        Me.AltaPasoBtn.TabIndex = 5
        Me.AltaPasoBtn.Text = "Agregar Paso"
        Me.AltaPasoBtn.UseVisualStyleBackColor = True
        '
        'DiasLbl
        '
        Me.DiasLbl.AutoSize = True
        Me.DiasLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DiasLbl.Location = New System.Drawing.Point(3, 27)
        Me.DiasLbl.Name = "DiasLbl"
        Me.TableLayoutPanel3.SetRowSpan(Me.DiasLbl, 2)
        Me.DiasLbl.Size = New System.Drawing.Size(95, 26)
        Me.DiasLbl.TabIndex = 2
        Me.DiasLbl.Text = "Dias"
        '
        'DescripcionTxt2
        '
        Me.DescripcionTxt2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DescripcionTxt2.Location = New System.Drawing.Point(104, 3)
        Me.DescripcionTxt2.Name = "DescripcionTxt2"
        Me.DescripcionTxt2.Size = New System.Drawing.Size(181, 23)
        Me.DescripcionTxt2.TabIndex = 2
        '
        'DiasNumeric
        '
        Me.DiasNumeric.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DiasNumeric.Location = New System.Drawing.Point(104, 30)
        Me.DiasNumeric.Name = "DiasNumeric"
        Me.DiasNumeric.Size = New System.Drawing.Size(181, 23)
        Me.DiasNumeric.TabIndex = 4
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 420.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PasoGPB, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.GrillaPasos, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.NombreLbl, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PasosLbl, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.NombreTxt, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.DescripcionLbl, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.DescripcionTxt, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.GrillaTipoEvento, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TiposEventoLbl, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 6)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 111.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(718, 324)
        Me.TableLayoutPanel1.TabIndex = 9
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel1.SetColumnSpan(Me.TableLayoutPanel2, 3)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Controls.Add(Me.AltaBtn, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BajaBtn, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ModificacionBtn, 2, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 277)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(712, 44)
        Me.TableLayoutPanel2.TabIndex = 9
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
        Me.AltaBtn.Size = New System.Drawing.Size(231, 38)
        Me.AltaBtn.TabIndex = 7
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
        Me.BajaBtn.Location = New System.Drawing.Point(240, 3)
        Me.BajaBtn.Name = "BajaBtn"
        Me.BajaBtn.Size = New System.Drawing.Size(231, 38)
        Me.BajaBtn.TabIndex = 8
        Me.BajaBtn.Text = "Borrar"
        Me.BajaBtn.UseVisualStyleBackColor = True
        '
        'ModificacionBtn
        '
        Me.ModificacionBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ModificacionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ModificacionBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModificacionBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ModificacionBtn.Location = New System.Drawing.Point(477, 3)
        Me.ModificacionBtn.Name = "ModificacionBtn"
        Me.ModificacionBtn.Size = New System.Drawing.Size(232, 38)
        Me.ModificacionBtn.TabIndex = 9
        Me.ModificacionBtn.Text = "Modificar"
        Me.ModificacionBtn.UseVisualStyleBackColor = True
        '
        'ABMTipoEvento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(718, 324)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ABMTipoEvento"
        Me.Text = "EvOrg"
        CType(Me.GrillaTipoEvento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrillaPasos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PasoGPB.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.DiasNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GrillaTipoEvento As DataGridView
    Friend WithEvents TiposEventoLbl As Label
    Friend WithEvents NombreLbl As Label
    Friend WithEvents DescripcionLbl As Label
    Friend WithEvents PasosLbl As Label
    Friend WithEvents GrillaPasos As DataGridView
    Friend WithEvents NombreTxt As TextBox
    Friend WithEvents DescripcionTxt As TextBox
    Friend WithEvents PasoGPB As GroupBox
    Friend WithEvents DescripcionLbl2 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BajaPasoBtn As Button
    Friend WithEvents AltaPasoBtn As Button
    Friend WithEvents PrioridadCombo As ComboBox
    Friend WithEvents PrioridadLbl As Label
    Friend WithEvents DiasLbl As Label
    Friend WithEvents DescripcionTxt2 As TextBox
    Friend WithEvents ModificacionBtn As Button
    Friend WithEvents BajaBtn As Button
    Friend WithEvents AltaBtn As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents DiasNumeric As NumericUpDown
End Class
