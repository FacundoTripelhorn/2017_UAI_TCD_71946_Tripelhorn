<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Presupuesto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Presupuesto))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.SeleccionarEventoLbl = New System.Windows.Forms.Label()
        Me.ServiciosContratadosLbl = New System.Windows.Forms.Label()
        Me.MaterialesReservadosLbl = New System.Windows.Forms.Label()
        Me.TotalServiciosTxt = New System.Windows.Forms.TextBox()
        Me.TotalServiciosLbl = New System.Windows.Forms.Label()
        Me.TotalMaterialesTxt = New System.Windows.Forms.TextBox()
        Me.TotalMaterialesLbl = New System.Windows.Forms.Label()
        Me.TotalSalonTxt = New System.Windows.Forms.TextBox()
        Me.TotalSalonLbl = New System.Windows.Forms.Label()
        Me.EventoCombo = New System.Windows.Forms.ComboBox()
        Me.EventoGPB = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TipoEventoLbl = New System.Windows.Forms.Label()
        Me.FechaLbl = New System.Windows.Forms.Label()
        Me.CantidadLbl = New System.Windows.Forms.Label()
        Me.SalonLbl = New System.Windows.Forms.Label()
        Me.TipoEventoTxt = New System.Windows.Forms.TextBox()
        Me.SalonTxt = New System.Windows.Forms.TextBox()
        Me.FechaDTP = New System.Windows.Forms.DateTimePicker()
        Me.CantidadTxt = New System.Windows.Forms.TextBox()
        Me.ClienteTxt = New System.Windows.Forms.TextBox()
        Me.ClienteLbl = New System.Windows.Forms.Label()
        Me.GrillaServicios = New System.Windows.Forms.DataGridView()
        Me.GrillaMateriales = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TotalTxt = New System.Windows.Forms.TextBox()
        Me.TotalLbl = New System.Windows.Forms.Label()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.ImprimirBtn = New System.Windows.Forms.Button()
        Me.EnviarBtn = New System.Windows.Forms.Button()
        Me.GuardarBtn = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.EventoGPB.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.GrillaServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrillaMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 169.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 141.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.SeleccionarEventoLbl, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ServiciosContratadosLbl, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.MaterialesReservadosLbl, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TotalServiciosTxt, 5, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TotalServiciosLbl, 4, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TotalMaterialesTxt, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TotalMaterialesLbl, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TotalSalonTxt, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TotalSalonLbl, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.EventoCombo, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.EventoGPB, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GrillaServicios, 4, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.GrillaMateriales, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 4, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 0, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 147.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(798, 275)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'SeleccionarEventoLbl
        '
        Me.SeleccionarEventoLbl.AutoSize = True
        Me.SeleccionarEventoLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SeleccionarEventoLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SeleccionarEventoLbl.Location = New System.Drawing.Point(3, 0)
        Me.SeleccionarEventoLbl.Name = "SeleccionarEventoLbl"
        Me.SeleccionarEventoLbl.Size = New System.Drawing.Size(130, 32)
        Me.SeleccionarEventoLbl.TabIndex = 0
        Me.SeleccionarEventoLbl.Tag = "Seleccionar evento"
        Me.SeleccionarEventoLbl.Text = "Seleccionar evento"
        Me.SeleccionarEventoLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ServiciosContratadosLbl
        '
        Me.ServiciosContratadosLbl.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.ServiciosContratadosLbl, 2)
        Me.ServiciosContratadosLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ServiciosContratadosLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ServiciosContratadosLbl.Location = New System.Drawing.Point(554, 32)
        Me.ServiciosContratadosLbl.Name = "ServiciosContratadosLbl"
        Me.ServiciosContratadosLbl.Size = New System.Drawing.Size(241, 24)
        Me.ServiciosContratadosLbl.TabIndex = 7
        Me.ServiciosContratadosLbl.Tag = "Servicios contratados"
        Me.ServiciosContratadosLbl.Text = "Servicios contratados"
        '
        'MaterialesReservadosLbl
        '
        Me.MaterialesReservadosLbl.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.MaterialesReservadosLbl, 2)
        Me.MaterialesReservadosLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaterialesReservadosLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.MaterialesReservadosLbl.Location = New System.Drawing.Point(308, 32)
        Me.MaterialesReservadosLbl.Name = "MaterialesReservadosLbl"
        Me.MaterialesReservadosLbl.Size = New System.Drawing.Size(240, 24)
        Me.MaterialesReservadosLbl.TabIndex = 6
        Me.MaterialesReservadosLbl.Tag = "Materiales reservados"
        Me.MaterialesReservadosLbl.Text = "Materiales reservados"
        '
        'TotalServiciosTxt
        '
        Me.TotalServiciosTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TotalServiciosTxt.Enabled = False
        Me.TotalServiciosTxt.Location = New System.Drawing.Point(695, 206)
        Me.TotalServiciosTxt.Name = "TotalServiciosTxt"
        Me.TotalServiciosTxt.Size = New System.Drawing.Size(100, 23)
        Me.TotalServiciosTxt.TabIndex = 11
        '
        'TotalServiciosLbl
        '
        Me.TotalServiciosLbl.AutoSize = True
        Me.TotalServiciosLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TotalServiciosLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TotalServiciosLbl.Location = New System.Drawing.Point(554, 203)
        Me.TotalServiciosLbl.Name = "TotalServiciosLbl"
        Me.TotalServiciosLbl.Size = New System.Drawing.Size(135, 28)
        Me.TotalServiciosLbl.TabIndex = 9
        Me.TotalServiciosLbl.Tag = "Total de servicios"
        Me.TotalServiciosLbl.Text = "Total de servicios: $"
        Me.TotalServiciosLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TotalMaterialesTxt
        '
        Me.TotalMaterialesTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TotalMaterialesTxt.Enabled = False
        Me.TotalMaterialesTxt.Location = New System.Drawing.Point(460, 206)
        Me.TotalMaterialesTxt.Name = "TotalMaterialesTxt"
        Me.TotalMaterialesTxt.Size = New System.Drawing.Size(88, 23)
        Me.TotalMaterialesTxt.TabIndex = 10
        '
        'TotalMaterialesLbl
        '
        Me.TotalMaterialesLbl.AutoSize = True
        Me.TotalMaterialesLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TotalMaterialesLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TotalMaterialesLbl.Location = New System.Drawing.Point(308, 203)
        Me.TotalMaterialesLbl.Name = "TotalMaterialesLbl"
        Me.TotalMaterialesLbl.Size = New System.Drawing.Size(146, 28)
        Me.TotalMaterialesLbl.TabIndex = 8
        Me.TotalMaterialesLbl.Tag = "Total de materiales"
        Me.TotalMaterialesLbl.Text = "Total de materiales: $"
        Me.TotalMaterialesLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TotalSalonTxt
        '
        Me.TotalSalonTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TotalSalonTxt.Enabled = False
        Me.TotalSalonTxt.Location = New System.Drawing.Point(139, 206)
        Me.TotalSalonTxt.Name = "TotalSalonTxt"
        Me.TotalSalonTxt.Size = New System.Drawing.Size(163, 23)
        Me.TotalSalonTxt.TabIndex = 12
        '
        'TotalSalonLbl
        '
        Me.TotalSalonLbl.AutoSize = True
        Me.TotalSalonLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TotalSalonLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TotalSalonLbl.Location = New System.Drawing.Point(3, 203)
        Me.TotalSalonLbl.Name = "TotalSalonLbl"
        Me.TotalSalonLbl.Size = New System.Drawing.Size(130, 28)
        Me.TotalSalonLbl.TabIndex = 13
        Me.TotalSalonLbl.Tag = "Total del salon"
        Me.TotalSalonLbl.Text = "Total del salón:    $"
        Me.TotalSalonLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EventoCombo
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.EventoCombo, 5)
        Me.EventoCombo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EventoCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EventoCombo.FormattingEnabled = True
        Me.EventoCombo.Location = New System.Drawing.Point(139, 3)
        Me.EventoCombo.Name = "EventoCombo"
        Me.EventoCombo.Size = New System.Drawing.Size(656, 24)
        Me.EventoCombo.TabIndex = 0
        '
        'EventoGPB
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.EventoGPB, 2)
        Me.EventoGPB.Controls.Add(Me.TableLayoutPanel2)
        Me.EventoGPB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EventoGPB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EventoGPB.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.EventoGPB.Location = New System.Drawing.Point(3, 35)
        Me.EventoGPB.Name = "EventoGPB"
        Me.TableLayoutPanel1.SetRowSpan(Me.EventoGPB, 2)
        Me.EventoGPB.Size = New System.Drawing.Size(299, 165)
        Me.EventoGPB.TabIndex = 3
        Me.EventoGPB.TabStop = False
        Me.EventoGPB.Tag = "Datos del evento"
        Me.EventoGPB.Text = "Datos del evento"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 143.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TipoEventoLbl, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.FechaLbl, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.CantidadLbl, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.SalonLbl, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.TipoEventoTxt, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.SalonTxt, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.FechaDTP, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.CantidadTxt, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.ClienteTxt, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.ClienteLbl, 0, 4)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 19)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(293, 143)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'TipoEventoLbl
        '
        Me.TipoEventoLbl.AutoSize = True
        Me.TipoEventoLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TipoEventoLbl.Location = New System.Drawing.Point(3, 0)
        Me.TipoEventoLbl.Name = "TipoEventoLbl"
        Me.TipoEventoLbl.Size = New System.Drawing.Size(144, 28)
        Me.TipoEventoLbl.TabIndex = 0
        Me.TipoEventoLbl.Tag = "Tipo de evento"
        Me.TipoEventoLbl.Text = "Tipo de evento"
        Me.TipoEventoLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FechaLbl
        '
        Me.FechaLbl.AutoSize = True
        Me.FechaLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FechaLbl.Location = New System.Drawing.Point(3, 28)
        Me.FechaLbl.Name = "FechaLbl"
        Me.FechaLbl.Size = New System.Drawing.Size(144, 28)
        Me.FechaLbl.TabIndex = 1
        Me.FechaLbl.Tag = "Fecha"
        Me.FechaLbl.Text = "Fecha"
        Me.FechaLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CantidadLbl
        '
        Me.CantidadLbl.AutoSize = True
        Me.CantidadLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CantidadLbl.Location = New System.Drawing.Point(3, 56)
        Me.CantidadLbl.Name = "CantidadLbl"
        Me.CantidadLbl.Size = New System.Drawing.Size(144, 28)
        Me.CantidadLbl.TabIndex = 2
        Me.CantidadLbl.Tag = "Cantidad de invitados"
        Me.CantidadLbl.Text = "Cantidad de invitados"
        Me.CantidadLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SalonLbl
        '
        Me.SalonLbl.AutoSize = True
        Me.SalonLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SalonLbl.Location = New System.Drawing.Point(3, 84)
        Me.SalonLbl.Name = "SalonLbl"
        Me.SalonLbl.Size = New System.Drawing.Size(144, 28)
        Me.SalonLbl.TabIndex = 3
        Me.SalonLbl.Tag = "Salón"
        Me.SalonLbl.Text = "Salón"
        Me.SalonLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TipoEventoTxt
        '
        Me.TipoEventoTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TipoEventoTxt.Enabled = False
        Me.TipoEventoTxt.Location = New System.Drawing.Point(153, 3)
        Me.TipoEventoTxt.Name = "TipoEventoTxt"
        Me.TipoEventoTxt.Size = New System.Drawing.Size(137, 23)
        Me.TipoEventoTxt.TabIndex = 4
        '
        'SalonTxt
        '
        Me.SalonTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SalonTxt.Enabled = False
        Me.SalonTxt.Location = New System.Drawing.Point(153, 87)
        Me.SalonTxt.Name = "SalonTxt"
        Me.SalonTxt.Size = New System.Drawing.Size(137, 23)
        Me.SalonTxt.TabIndex = 5
        '
        'FechaDTP
        '
        Me.FechaDTP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FechaDTP.Enabled = False
        Me.FechaDTP.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaDTP.Location = New System.Drawing.Point(153, 31)
        Me.FechaDTP.Name = "FechaDTP"
        Me.FechaDTP.Size = New System.Drawing.Size(137, 23)
        Me.FechaDTP.TabIndex = 6
        '
        'CantidadTxt
        '
        Me.CantidadTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CantidadTxt.Enabled = False
        Me.CantidadTxt.Location = New System.Drawing.Point(153, 59)
        Me.CantidadTxt.Name = "CantidadTxt"
        Me.CantidadTxt.Size = New System.Drawing.Size(137, 23)
        Me.CantidadTxt.TabIndex = 7
        '
        'ClienteTxt
        '
        Me.ClienteTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ClienteTxt.Enabled = False
        Me.ClienteTxt.Location = New System.Drawing.Point(153, 115)
        Me.ClienteTxt.Name = "ClienteTxt"
        Me.ClienteTxt.Size = New System.Drawing.Size(137, 23)
        Me.ClienteTxt.TabIndex = 8
        '
        'ClienteLbl
        '
        Me.ClienteLbl.AutoSize = True
        Me.ClienteLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ClienteLbl.Location = New System.Drawing.Point(3, 112)
        Me.ClienteLbl.Name = "ClienteLbl"
        Me.ClienteLbl.Size = New System.Drawing.Size(144, 31)
        Me.ClienteLbl.TabIndex = 9
        Me.ClienteLbl.Tag = "Cliente"
        Me.ClienteLbl.Text = "Cliente"
        Me.ClienteLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GrillaServicios
        '
        Me.GrillaServicios.AllowUserToAddRows = False
        Me.GrillaServicios.AllowUserToDeleteRows = False
        Me.GrillaServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableLayoutPanel1.SetColumnSpan(Me.GrillaServicios, 2)
        Me.GrillaServicios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrillaServicios.Location = New System.Drawing.Point(554, 59)
        Me.GrillaServicios.Name = "GrillaServicios"
        Me.GrillaServicios.ReadOnly = True
        Me.GrillaServicios.Size = New System.Drawing.Size(241, 141)
        Me.GrillaServicios.TabIndex = 5
        '
        'GrillaMateriales
        '
        Me.GrillaMateriales.AllowUserToAddRows = False
        Me.GrillaMateriales.AllowUserToDeleteRows = False
        Me.GrillaMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableLayoutPanel1.SetColumnSpan(Me.GrillaMateriales, 2)
        Me.GrillaMateriales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrillaMateriales.Location = New System.Drawing.Point(308, 59)
        Me.GrillaMateriales.Name = "GrillaMateriales"
        Me.GrillaMateriales.ReadOnly = True
        Me.GrillaMateriales.Size = New System.Drawing.Size(240, 141)
        Me.GrillaMateriales.TabIndex = 4
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel1.SetColumnSpan(Me.TableLayoutPanel3, 2)
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.80083!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.19917!))
        Me.TableLayoutPanel3.Controls.Add(Me.TotalTxt, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TotalLbl, 0, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(554, 242)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(241, 30)
        Me.TableLayoutPanel3.TabIndex = 16
        '
        'TotalTxt
        '
        Me.TotalTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TotalTxt.Enabled = False
        Me.TotalTxt.Location = New System.Drawing.Point(70, 3)
        Me.TotalTxt.Name = "TotalTxt"
        Me.TotalTxt.Size = New System.Drawing.Size(168, 23)
        Me.TotalTxt.TabIndex = 15
        '
        'TotalLbl
        '
        Me.TotalLbl.AutoSize = True
        Me.TotalLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TotalLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TotalLbl.Location = New System.Drawing.Point(3, 0)
        Me.TotalLbl.Name = "TotalLbl"
        Me.TotalLbl.Size = New System.Drawing.Size(61, 30)
        Me.TotalLbl.TabIndex = 14
        Me.TotalLbl.Tag = "Total"
        Me.TotalLbl.Text = "Total:  $"
        Me.TotalLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.ColumnCount = 3
        Me.TableLayoutPanel1.SetColumnSpan(Me.TableLayoutPanel4, 4)
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.Controls.Add(Me.ImprimirBtn, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.EnviarBtn, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.GuardarBtn, 0, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 234)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(545, 38)
        Me.TableLayoutPanel4.TabIndex = 20
        '
        'ImprimirBtn
        '
        Me.ImprimirBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ImprimirBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ImprimirBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ImprimirBtn.Location = New System.Drawing.Point(365, 3)
        Me.ImprimirBtn.Name = "ImprimirBtn"
        Me.ImprimirBtn.Size = New System.Drawing.Size(177, 32)
        Me.ImprimirBtn.TabIndex = 3
        Me.ImprimirBtn.Tag = "Imprimir"
        Me.ImprimirBtn.Text = "Imprimir"
        Me.ImprimirBtn.UseVisualStyleBackColor = True
        '
        'EnviarBtn
        '
        Me.EnviarBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EnviarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EnviarBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.EnviarBtn.Location = New System.Drawing.Point(184, 3)
        Me.EnviarBtn.Name = "EnviarBtn"
        Me.EnviarBtn.Size = New System.Drawing.Size(175, 32)
        Me.EnviarBtn.TabIndex = 2
        Me.EnviarBtn.Tag = "Enviar"
        Me.EnviarBtn.Text = "Enviar"
        Me.EnviarBtn.UseVisualStyleBackColor = True
        '
        'GuardarBtn
        '
        Me.GuardarBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GuardarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GuardarBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GuardarBtn.Location = New System.Drawing.Point(3, 3)
        Me.GuardarBtn.Name = "GuardarBtn"
        Me.GuardarBtn.Size = New System.Drawing.Size(175, 32)
        Me.GuardarBtn.TabIndex = 1
        Me.GuardarBtn.Tag = "Guardar"
        Me.GuardarBtn.Text = "Guardar"
        Me.GuardarBtn.UseVisualStyleBackColor = True
        '
        'Presupuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(798, 275)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Presupuesto"
        Me.Text = "EvOrg"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.EventoGPB.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.GrillaServicios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrillaMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents SeleccionarEventoLbl As Label
    Friend WithEvents EventoCombo As ComboBox
    Friend WithEvents ServiciosContratadosLbl As Label
    Friend WithEvents MaterialesReservadosLbl As Label
    Friend WithEvents TotalServiciosTxt As TextBox
    Friend WithEvents TotalServiciosLbl As Label
    Friend WithEvents TotalMaterialesTxt As TextBox
    Friend WithEvents TotalMaterialesLbl As Label
    Friend WithEvents TotalSalonTxt As TextBox
    Friend WithEvents TotalSalonLbl As Label
    Friend WithEvents TotalLbl As Label
    Friend WithEvents TotalTxt As TextBox
    Friend WithEvents EventoGPB As GroupBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TipoEventoLbl As Label
    Friend WithEvents FechaLbl As Label
    Friend WithEvents CantidadLbl As Label
    Friend WithEvents SalonLbl As Label
    Friend WithEvents TipoEventoTxt As TextBox
    Friend WithEvents SalonTxt As TextBox
    Friend WithEvents FechaDTP As DateTimePicker
    Friend WithEvents CantidadTxt As TextBox
    Friend WithEvents GrillaServicios As DataGridView
    Friend WithEvents GrillaMateriales As DataGridView
    Friend WithEvents ClienteTxt As TextBox
    Friend WithEvents ClienteLbl As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents ImprimirBtn As Button
    Friend WithEvents EnviarBtn As Button
    Friend WithEvents GuardarBtn As Button
End Class
