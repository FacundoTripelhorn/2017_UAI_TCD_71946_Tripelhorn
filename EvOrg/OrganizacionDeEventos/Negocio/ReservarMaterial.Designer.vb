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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EventoCombo = New System.Windows.Forms.ComboBox()
        Me.GrillaMateriales = New System.Windows.Forms.DataGridView()
        Me.BuscarMaterialBtn = New System.Windows.Forms.Button()
        Me.MaterialLbl = New System.Windows.Forms.Label()
        Me.CantidadLbl = New System.Windows.Forms.Label()
        Me.FechaLimiteLbl = New System.Windows.Forms.Label()
        Me.MaterialTxt = New System.Windows.Forms.TextBox()
        Me.CantidadNumeric = New System.Windows.Forms.NumericUpDown()
        Me.FechaLimiteDTP = New System.Windows.Forms.DateTimePicker()
        Me.AgregarBtn = New System.Windows.Forms.Button()
        Me.VerDisponibilidadBtn = New System.Windows.Forms.Button()
        Me.VerEventoBtn = New System.Windows.Forms.Button()
        Me.TerminarBtn = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.GrillaMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CantidadNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.EventoCombo, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GrillaMateriales, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.BuscarMaterialBtn, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.MaterialLbl, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.CantidadLbl, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.FechaLimiteLbl, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.MaterialTxt, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.CantidadNumeric, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.FechaLimiteDTP, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.AgregarBtn, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.VerDisponibilidadBtn, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.VerEventoBtn, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.TerminarBtn, 3, 5)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 211.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(596, 350)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(3, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleccionar evento"
        '
        'EventoCombo
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.EventoCombo, 4)
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
        Me.TableLayoutPanel1.SetColumnSpan(Me.GrillaMateriales, 4)
        Me.GrillaMateriales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrillaMateriales.Location = New System.Drawing.Point(3, 57)
        Me.GrillaMateriales.Name = "GrillaMateriales"
        Me.GrillaMateriales.Size = New System.Drawing.Size(590, 205)
        Me.GrillaMateriales.TabIndex = 2
        '
        'BuscarMaterialBtn
        '
        Me.BuscarMaterialBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BuscarMaterialBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BuscarMaterialBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuscarMaterialBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BuscarMaterialBtn.Location = New System.Drawing.Point(3, 268)
        Me.BuscarMaterialBtn.Name = "BuscarMaterialBtn"
        Me.TableLayoutPanel1.SetRowSpan(Me.BuscarMaterialBtn, 2)
        Me.BuscarMaterialBtn.Size = New System.Drawing.Size(143, 43)
        Me.BuscarMaterialBtn.TabIndex = 1
        Me.BuscarMaterialBtn.Text = "Buscar material"
        Me.BuscarMaterialBtn.UseVisualStyleBackColor = True
        '
        'MaterialLbl
        '
        Me.MaterialLbl.AutoSize = True
        Me.MaterialLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaterialLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaterialLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.MaterialLbl.Location = New System.Drawing.Point(152, 265)
        Me.MaterialLbl.Name = "MaterialLbl"
        Me.MaterialLbl.Size = New System.Drawing.Size(143, 17)
        Me.MaterialLbl.TabIndex = 4
        Me.MaterialLbl.Text = "Material"
        '
        'CantidadLbl
        '
        Me.CantidadLbl.AutoSize = True
        Me.CantidadLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CantidadLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CantidadLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CantidadLbl.Location = New System.Drawing.Point(301, 265)
        Me.CantidadLbl.Name = "CantidadLbl"
        Me.CantidadLbl.Size = New System.Drawing.Size(143, 17)
        Me.CantidadLbl.TabIndex = 5
        Me.CantidadLbl.Text = "Cantidad"
        '
        'FechaLimiteLbl
        '
        Me.FechaLimiteLbl.AutoSize = True
        Me.FechaLimiteLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FechaLimiteLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaLimiteLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FechaLimiteLbl.Location = New System.Drawing.Point(450, 265)
        Me.FechaLimiteLbl.Name = "FechaLimiteLbl"
        Me.FechaLimiteLbl.Size = New System.Drawing.Size(143, 17)
        Me.FechaLimiteLbl.TabIndex = 6
        Me.FechaLimiteLbl.Text = "Fecha Limite"
        '
        'MaterialTxt
        '
        Me.MaterialTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaterialTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaterialTxt.Location = New System.Drawing.Point(152, 285)
        Me.MaterialTxt.Name = "MaterialTxt"
        Me.MaterialTxt.Size = New System.Drawing.Size(143, 23)
        Me.MaterialTxt.TabIndex = 8
        '
        'CantidadNumeric
        '
        Me.CantidadNumeric.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CantidadNumeric.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CantidadNumeric.Location = New System.Drawing.Point(301, 285)
        Me.CantidadNumeric.Name = "CantidadNumeric"
        Me.CantidadNumeric.Size = New System.Drawing.Size(143, 23)
        Me.CantidadNumeric.TabIndex = 2
        '
        'FechaLimiteDTP
        '
        Me.FechaLimiteDTP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FechaLimiteDTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaLimiteDTP.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaLimiteDTP.Location = New System.Drawing.Point(450, 285)
        Me.FechaLimiteDTP.Name = "FechaLimiteDTP"
        Me.FechaLimiteDTP.Size = New System.Drawing.Size(143, 23)
        Me.FechaLimiteDTP.TabIndex = 3
        '
        'AgregarBtn
        '
        Me.AgregarBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AgregarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AgregarBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgregarBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.AgregarBtn.Location = New System.Drawing.Point(3, 317)
        Me.AgregarBtn.Name = "AgregarBtn"
        Me.AgregarBtn.Size = New System.Drawing.Size(143, 30)
        Me.AgregarBtn.TabIndex = 4
        Me.AgregarBtn.Text = "Agregar"
        Me.AgregarBtn.UseVisualStyleBackColor = True
        '
        'VerDisponibilidadBtn
        '
        Me.VerDisponibilidadBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VerDisponibilidadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VerDisponibilidadBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VerDisponibilidadBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.VerDisponibilidadBtn.Location = New System.Drawing.Point(152, 317)
        Me.VerDisponibilidadBtn.Name = "VerDisponibilidadBtn"
        Me.VerDisponibilidadBtn.Size = New System.Drawing.Size(143, 30)
        Me.VerDisponibilidadBtn.TabIndex = 5
        Me.VerDisponibilidadBtn.Text = "Ver disponibilidad"
        Me.VerDisponibilidadBtn.UseVisualStyleBackColor = True
        '
        'VerEventoBtn
        '
        Me.VerEventoBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VerEventoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VerEventoBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VerEventoBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.VerEventoBtn.Location = New System.Drawing.Point(301, 317)
        Me.VerEventoBtn.Name = "VerEventoBtn"
        Me.VerEventoBtn.Size = New System.Drawing.Size(143, 30)
        Me.VerEventoBtn.TabIndex = 6
        Me.VerEventoBtn.Text = "Ver evento"
        Me.VerEventoBtn.UseVisualStyleBackColor = True
        '
        'TerminarBtn
        '
        Me.TerminarBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TerminarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TerminarBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TerminarBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TerminarBtn.Location = New System.Drawing.Point(450, 317)
        Me.TerminarBtn.Name = "TerminarBtn"
        Me.TerminarBtn.Size = New System.Drawing.Size(143, 30)
        Me.TerminarBtn.TabIndex = 7
        Me.TerminarBtn.Text = "Terminar"
        Me.TerminarBtn.UseVisualStyleBackColor = True
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
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
End Class
