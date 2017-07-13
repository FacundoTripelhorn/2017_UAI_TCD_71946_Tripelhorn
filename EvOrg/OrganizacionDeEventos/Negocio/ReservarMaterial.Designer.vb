<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReservarMaterial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReservarMaterial))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.SeleccionarEventoLbl = New System.Windows.Forms.Label()
        Me.EventoCombo = New System.Windows.Forms.ComboBox()
        Me.GrillaMateriales = New System.Windows.Forms.DataGridView()
        Me.BuscarMaterialBtn = New System.Windows.Forms.Button()
        Me.MaterialLbl = New System.Windows.Forms.Label()
        Me.CantidadLbl = New System.Windows.Forms.Label()
        Me.FechaLimiteLbl = New System.Windows.Forms.Label()
        Me.MaterialTxt = New System.Windows.Forms.TextBox()
        Me.CantidadNumeric = New System.Windows.Forms.NumericUpDown()
        Me.FechaLimiteDTP = New System.Windows.Forms.DateTimePicker()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TerminarBtn = New System.Windows.Forms.Button()
        Me.VerEventoBtn = New System.Windows.Forms.Button()
        Me.VerDisponibilidadBtn = New System.Windows.Forms.Button()
        Me.AgregarBtn = New System.Windows.Forms.Button()
        Me.IdLbl = New System.Windows.Forms.Label()
        Me.IdTxt = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.GrillaMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CantidadNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.25667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.40862!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.64066!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.69405!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.SeleccionarEventoLbl, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.EventoCombo, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GrillaMateriales, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.BuscarMaterialBtn, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.MaterialLbl, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.CantidadLbl, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.FechaLimiteLbl, 4, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.MaterialTxt, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.CantidadNumeric, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.FechaLimiteDTP, 4, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.IdLbl, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.IdTxt, 1, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 206.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(596, 350)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'SeleccionarEventoLbl
        '
        Me.SeleccionarEventoLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SeleccionarEventoLbl.AutoSize = True
        Me.SeleccionarEventoLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeleccionarEventoLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SeleccionarEventoLbl.Location = New System.Drawing.Point(3, 0)
        Me.SeleccionarEventoLbl.Name = "SeleccionarEventoLbl"
        Me.SeleccionarEventoLbl.Size = New System.Drawing.Size(86, 25)
        Me.SeleccionarEventoLbl.TabIndex = 0
        Me.SeleccionarEventoLbl.Tag = "Seleccionar evento"
        Me.SeleccionarEventoLbl.Text = "Seleccionar evento"
        '
        'EventoCombo
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.EventoCombo, 5)
        Me.EventoCombo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EventoCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EventoCombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EventoCombo.FormattingEnabled = True
        Me.EventoCombo.Location = New System.Drawing.Point(3, 28)
        Me.EventoCombo.Name = "EventoCombo"
        Me.EventoCombo.Size = New System.Drawing.Size(590, 24)
        Me.EventoCombo.TabIndex = 0
        '
        'GrillaMateriales
        '
        Me.GrillaMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableLayoutPanel1.SetColumnSpan(Me.GrillaMateriales, 5)
        Me.GrillaMateriales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrillaMateriales.Location = New System.Drawing.Point(3, 57)
        Me.GrillaMateriales.Name = "GrillaMateriales"
        Me.GrillaMateriales.Size = New System.Drawing.Size(590, 200)
        Me.GrillaMateriales.TabIndex = 2
        '
        'BuscarMaterialBtn
        '
        Me.BuscarMaterialBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BuscarMaterialBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BuscarMaterialBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuscarMaterialBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BuscarMaterialBtn.Location = New System.Drawing.Point(3, 263)
        Me.BuscarMaterialBtn.Name = "BuscarMaterialBtn"
        Me.TableLayoutPanel1.SetRowSpan(Me.BuscarMaterialBtn, 2)
        Me.BuscarMaterialBtn.Size = New System.Drawing.Size(115, 43)
        Me.BuscarMaterialBtn.TabIndex = 1
        Me.BuscarMaterialBtn.Tag = "Buscar material"
        Me.BuscarMaterialBtn.Text = "Buscar material"
        Me.BuscarMaterialBtn.UseVisualStyleBackColor = True
        '
        'MaterialLbl
        '
        Me.MaterialLbl.AutoSize = True
        Me.MaterialLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaterialLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaterialLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.MaterialLbl.Location = New System.Drawing.Point(237, 260)
        Me.MaterialLbl.Name = "MaterialLbl"
        Me.MaterialLbl.Size = New System.Drawing.Size(113, 22)
        Me.MaterialLbl.TabIndex = 4
        Me.MaterialLbl.Tag = "Material"
        Me.MaterialLbl.Text = "Material"
        '
        'CantidadLbl
        '
        Me.CantidadLbl.AutoSize = True
        Me.CantidadLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CantidadLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CantidadLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CantidadLbl.Location = New System.Drawing.Point(356, 260)
        Me.CantidadLbl.Name = "CantidadLbl"
        Me.CantidadLbl.Size = New System.Drawing.Size(122, 22)
        Me.CantidadLbl.TabIndex = 5
        Me.CantidadLbl.Tag = "Cantidad"
        Me.CantidadLbl.Text = "Cantidad"
        '
        'FechaLimiteLbl
        '
        Me.FechaLimiteLbl.AutoSize = True
        Me.FechaLimiteLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FechaLimiteLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaLimiteLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FechaLimiteLbl.Location = New System.Drawing.Point(484, 260)
        Me.FechaLimiteLbl.Name = "FechaLimiteLbl"
        Me.FechaLimiteLbl.Size = New System.Drawing.Size(109, 22)
        Me.FechaLimiteLbl.TabIndex = 6
        Me.FechaLimiteLbl.Tag = "Fecha limite"
        Me.FechaLimiteLbl.Text = "Fecha Limite"
        '
        'MaterialTxt
        '
        Me.MaterialTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaterialTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaterialTxt.Location = New System.Drawing.Point(237, 285)
        Me.MaterialTxt.Name = "MaterialTxt"
        Me.MaterialTxt.Size = New System.Drawing.Size(113, 23)
        Me.MaterialTxt.TabIndex = 8
        '
        'CantidadNumeric
        '
        Me.CantidadNumeric.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CantidadNumeric.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CantidadNumeric.Location = New System.Drawing.Point(356, 285)
        Me.CantidadNumeric.Name = "CantidadNumeric"
        Me.CantidadNumeric.Size = New System.Drawing.Size(122, 23)
        Me.CantidadNumeric.TabIndex = 2
        '
        'FechaLimiteDTP
        '
        Me.FechaLimiteDTP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FechaLimiteDTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaLimiteDTP.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaLimiteDTP.Location = New System.Drawing.Point(484, 285)
        Me.FechaLimiteDTP.Name = "FechaLimiteDTP"
        Me.FechaLimiteDTP.Size = New System.Drawing.Size(109, 23)
        Me.FechaLimiteDTP.TabIndex = 3
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel1.SetColumnSpan(Me.TableLayoutPanel2, 5)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TerminarBtn, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.VerEventoBtn, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.VerDisponibilidadBtn, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.AgregarBtn, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 312)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(590, 35)
        Me.TableLayoutPanel2.TabIndex = 9
        '
        'TerminarBtn
        '
        Me.TerminarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TerminarBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TerminarBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TerminarBtn.Location = New System.Drawing.Point(444, 3)
        Me.TerminarBtn.Name = "TerminarBtn"
        Me.TerminarBtn.Size = New System.Drawing.Size(143, 29)
        Me.TerminarBtn.TabIndex = 7
        Me.TerminarBtn.Tag = "Terminar"
        Me.TerminarBtn.Text = "Terminar"
        Me.TerminarBtn.UseVisualStyleBackColor = True
        '
        'VerEventoBtn
        '
        Me.VerEventoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VerEventoBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VerEventoBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.VerEventoBtn.Location = New System.Drawing.Point(297, 3)
        Me.VerEventoBtn.Name = "VerEventoBtn"
        Me.VerEventoBtn.Size = New System.Drawing.Size(141, 29)
        Me.VerEventoBtn.TabIndex = 6
        Me.VerEventoBtn.Tag = "Ver evento"
        Me.VerEventoBtn.Text = "Ver evento"
        Me.VerEventoBtn.UseVisualStyleBackColor = True
        '
        'VerDisponibilidadBtn
        '
        Me.VerDisponibilidadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VerDisponibilidadBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VerDisponibilidadBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.VerDisponibilidadBtn.Location = New System.Drawing.Point(150, 3)
        Me.VerDisponibilidadBtn.Name = "VerDisponibilidadBtn"
        Me.VerDisponibilidadBtn.Size = New System.Drawing.Size(141, 29)
        Me.VerDisponibilidadBtn.TabIndex = 5
        Me.VerDisponibilidadBtn.Tag = "Ver disponibilidad"
        Me.VerDisponibilidadBtn.Text = "Ver disponibilidad"
        Me.VerDisponibilidadBtn.UseVisualStyleBackColor = True
        '
        'AgregarBtn
        '
        Me.AgregarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AgregarBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgregarBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.AgregarBtn.Location = New System.Drawing.Point(3, 3)
        Me.AgregarBtn.Name = "AgregarBtn"
        Me.AgregarBtn.Size = New System.Drawing.Size(141, 29)
        Me.AgregarBtn.TabIndex = 4
        Me.AgregarBtn.Tag = "Agregar"
        Me.AgregarBtn.Text = "Agregar"
        Me.AgregarBtn.UseVisualStyleBackColor = True
        '
        'IdLbl
        '
        Me.IdLbl.AutoSize = True
        Me.IdLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IdLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.IdLbl.Location = New System.Drawing.Point(124, 260)
        Me.IdLbl.Name = "IdLbl"
        Me.IdLbl.Size = New System.Drawing.Size(107, 22)
        Me.IdLbl.TabIndex = 10
        Me.IdLbl.Tag = "Id"
        Me.IdLbl.Text = "Id"
        '
        'IdTxt
        '
        Me.IdTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IdTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdTxt.Location = New System.Drawing.Point(124, 285)
        Me.IdTxt.Name = "IdTxt"
        Me.IdTxt.Size = New System.Drawing.Size(107, 23)
        Me.IdTxt.TabIndex = 11
        '
        'ReservarMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(596, 350)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ReservarMaterial"
        Me.Text = "EvOrg"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.GrillaMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CantidadNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents SeleccionarEventoLbl As Label
    Friend WithEvents EventoCombo As ComboBox
    Friend WithEvents GrillaMateriales As DataGridView
    Friend WithEvents BuscarMaterialBtn As Button
    Friend WithEvents MaterialLbl As Label
    Friend WithEvents CantidadLbl As Label
    Friend WithEvents FechaLimiteLbl As Label
    Friend WithEvents CantidadNumeric As NumericUpDown
    Friend WithEvents FechaLimiteDTP As DateTimePicker
    Friend WithEvents AgregarBtn As Button
    Friend WithEvents VerDisponibilidadBtn As Button
    Friend WithEvents VerEventoBtn As Button
    Friend WithEvents TerminarBtn As Button
    Public WithEvents MaterialTxt As TextBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents IdLbl As Label
    Friend WithEvents IdTxt As TextBox
End Class
