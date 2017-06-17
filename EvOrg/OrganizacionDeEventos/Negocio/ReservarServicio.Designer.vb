<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReservarServicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReservarServicio))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.DescripcionTxt = New System.Windows.Forms.TextBox()
        Me.SeleccionarEventoLbl = New System.Windows.Forms.Label()
        Me.EventoCombo = New System.Windows.Forms.ComboBox()
        Me.SeleccionarServicioLbl = New System.Windows.Forms.Label()
        Me.ServicioCombo = New System.Windows.Forms.ComboBox()
        Me.ServicioGPB = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.NombreLbl = New System.Windows.Forms.Label()
        Me.TelefonoLbl = New System.Windows.Forms.Label()
        Me.EmailLbl = New System.Windows.Forms.Label()
        Me.DireccionLbl = New System.Windows.Forms.Label()
        Me.NombreTxt = New System.Windows.Forms.TextBox()
        Me.DireccionTxt = New System.Windows.Forms.TextBox()
        Me.EmailTxt = New System.Windows.Forms.TextBox()
        Me.TelefonoTxt = New System.Windows.Forms.TextBox()
        Me.ObservacionLbl = New System.Windows.Forms.Label()
        Me.ObservacionTxt = New System.Windows.Forms.TextBox()
        Me.PrecioLbl = New System.Windows.Forms.Label()
        Me.PrecioTxt = New System.Windows.Forms.TextBox()
        Me.GrillaServicios = New System.Windows.Forms.DataGridView()
        Me.DescripcionLbl = New System.Windows.Forms.Label()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.AgregarBtn = New System.Windows.Forms.Button()
        Me.BorrarBtn = New System.Windows.Forms.Button()
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
        Me.TableLayoutPanel1.SuspendLayout()
        Me.ServicioGPB.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.GrillaServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.EventoGPB.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 304.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 428.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.DescripcionTxt, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.SeleccionarEventoLbl, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.EventoCombo, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.SeleccionarServicioLbl, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ServicioCombo, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ServicioGPB, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.GrillaServicios, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.DescripcionLbl, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.EventoGPB, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 141.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 107.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(732, 368)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'DescripcionTxt
        '
        Me.DescripcionTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DescripcionTxt.Location = New System.Drawing.Point(3, 220)
        Me.DescripcionTxt.Multiline = True
        Me.DescripcionTxt.Name = "DescripcionTxt"
        Me.DescripcionTxt.Size = New System.Drawing.Size(298, 101)
        Me.DescripcionTxt.TabIndex = 4
        '
        'SeleccionarEventoLbl
        '
        Me.SeleccionarEventoLbl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeleccionarEventoLbl.AutoSize = True
        Me.SeleccionarEventoLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeleccionarEventoLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SeleccionarEventoLbl.Location = New System.Drawing.Point(3, 9)
        Me.SeleccionarEventoLbl.Name = "SeleccionarEventoLbl"
        Me.SeleccionarEventoLbl.Size = New System.Drawing.Size(298, 17)
        Me.SeleccionarEventoLbl.TabIndex = 0
        Me.SeleccionarEventoLbl.Tag = "Seleccionar evento"
        Me.SeleccionarEventoLbl.Text = "Seleccionar evento"
        '
        'EventoCombo
        '
        Me.EventoCombo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EventoCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EventoCombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EventoCombo.FormattingEnabled = True
        Me.EventoCombo.Location = New System.Drawing.Point(3, 29)
        Me.EventoCombo.Name = "EventoCombo"
        Me.EventoCombo.Size = New System.Drawing.Size(298, 24)
        Me.EventoCombo.TabIndex = 1
        '
        'SeleccionarServicioLbl
        '
        Me.SeleccionarServicioLbl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeleccionarServicioLbl.AutoSize = True
        Me.SeleccionarServicioLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeleccionarServicioLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SeleccionarServicioLbl.Location = New System.Drawing.Point(307, 9)
        Me.SeleccionarServicioLbl.Name = "SeleccionarServicioLbl"
        Me.SeleccionarServicioLbl.Size = New System.Drawing.Size(422, 17)
        Me.SeleccionarServicioLbl.TabIndex = 2
        Me.SeleccionarServicioLbl.Tag = "Seleccionar servicio"
        Me.SeleccionarServicioLbl.Text = "Seleccionar servicio"
        '
        'ServicioCombo
        '
        Me.ServicioCombo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ServicioCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ServicioCombo.FormattingEnabled = True
        Me.ServicioCombo.Location = New System.Drawing.Point(307, 29)
        Me.ServicioCombo.Name = "ServicioCombo"
        Me.ServicioCombo.Size = New System.Drawing.Size(422, 21)
        Me.ServicioCombo.TabIndex = 3
        '
        'ServicioGPB
        '
        Me.ServicioGPB.Controls.Add(Me.TableLayoutPanel3)
        Me.ServicioGPB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ServicioGPB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ServicioGPB.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ServicioGPB.Location = New System.Drawing.Point(307, 57)
        Me.ServicioGPB.Name = "ServicioGPB"
        Me.ServicioGPB.Size = New System.Drawing.Size(422, 135)
        Me.ServicioGPB.TabIndex = 201
        Me.ServicioGPB.TabStop = False
        Me.ServicioGPB.Tag = "Datos del servicio"
        Me.ServicioGPB.Text = "Datos del servicio"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 151.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.NombreLbl, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TelefonoLbl, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.EmailLbl, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.DireccionLbl, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.NombreTxt, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.DireccionTxt, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.EmailTxt, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.TelefonoTxt, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.ObservacionLbl, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.ObservacionTxt, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.PrecioLbl, 2, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.PrecioTxt, 3, 3)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 19)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 4
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(416, 113)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'NombreLbl
        '
        Me.NombreLbl.AutoSize = True
        Me.NombreLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NombreLbl.Location = New System.Drawing.Point(3, 0)
        Me.NombreLbl.Name = "NombreLbl"
        Me.NombreLbl.Size = New System.Drawing.Size(67, 28)
        Me.NombreLbl.TabIndex = 0
        Me.NombreLbl.Tag = "Nombre"
        Me.NombreLbl.Text = "Nombre"
        Me.NombreLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TelefonoLbl
        '
        Me.TelefonoLbl.AutoSize = True
        Me.TelefonoLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TelefonoLbl.Location = New System.Drawing.Point(3, 28)
        Me.TelefonoLbl.Name = "TelefonoLbl"
        Me.TelefonoLbl.Size = New System.Drawing.Size(67, 28)
        Me.TelefonoLbl.TabIndex = 1
        Me.TelefonoLbl.Tag = "Telefono"
        Me.TelefonoLbl.Text = "Telefono"
        Me.TelefonoLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EmailLbl
        '
        Me.EmailLbl.AutoSize = True
        Me.EmailLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EmailLbl.Location = New System.Drawing.Point(3, 56)
        Me.EmailLbl.Name = "EmailLbl"
        Me.EmailLbl.Size = New System.Drawing.Size(67, 28)
        Me.EmailLbl.TabIndex = 2
        Me.EmailLbl.Tag = "Email"
        Me.EmailLbl.Text = "Email"
        Me.EmailLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DireccionLbl
        '
        Me.DireccionLbl.AutoSize = True
        Me.DireccionLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DireccionLbl.Location = New System.Drawing.Point(3, 84)
        Me.DireccionLbl.Name = "DireccionLbl"
        Me.DireccionLbl.Size = New System.Drawing.Size(67, 29)
        Me.DireccionLbl.TabIndex = 3
        Me.DireccionLbl.Tag = "Direccion"
        Me.DireccionLbl.Text = "Dirección"
        Me.DireccionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NombreTxt
        '
        Me.NombreTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NombreTxt.Location = New System.Drawing.Point(76, 3)
        Me.NombreTxt.Name = "NombreTxt"
        Me.NombreTxt.Size = New System.Drawing.Size(130, 23)
        Me.NombreTxt.TabIndex = 4
        '
        'DireccionTxt
        '
        Me.DireccionTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DireccionTxt.Location = New System.Drawing.Point(76, 87)
        Me.DireccionTxt.Name = "DireccionTxt"
        Me.DireccionTxt.Size = New System.Drawing.Size(130, 23)
        Me.DireccionTxt.TabIndex = 5
        '
        'EmailTxt
        '
        Me.EmailTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EmailTxt.Location = New System.Drawing.Point(76, 59)
        Me.EmailTxt.Name = "EmailTxt"
        Me.EmailTxt.Size = New System.Drawing.Size(130, 23)
        Me.EmailTxt.TabIndex = 7
        '
        'TelefonoTxt
        '
        Me.TelefonoTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TelefonoTxt.Location = New System.Drawing.Point(76, 31)
        Me.TelefonoTxt.Name = "TelefonoTxt"
        Me.TelefonoTxt.Size = New System.Drawing.Size(130, 23)
        Me.TelefonoTxt.TabIndex = 8
        '
        'ObservacionLbl
        '
        Me.ObservacionLbl.AutoSize = True
        Me.TableLayoutPanel3.SetColumnSpan(Me.ObservacionLbl, 2)
        Me.ObservacionLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ObservacionLbl.Location = New System.Drawing.Point(212, 0)
        Me.ObservacionLbl.Name = "ObservacionLbl"
        Me.ObservacionLbl.Size = New System.Drawing.Size(201, 28)
        Me.ObservacionLbl.TabIndex = 9
        Me.ObservacionLbl.Tag = "Observacion"
        Me.ObservacionLbl.Text = "Observación"
        Me.ObservacionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ObservacionTxt
        '
        Me.TableLayoutPanel3.SetColumnSpan(Me.ObservacionTxt, 2)
        Me.ObservacionTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ObservacionTxt.Location = New System.Drawing.Point(212, 31)
        Me.ObservacionTxt.Multiline = True
        Me.ObservacionTxt.Name = "ObservacionTxt"
        Me.TableLayoutPanel3.SetRowSpan(Me.ObservacionTxt, 2)
        Me.ObservacionTxt.Size = New System.Drawing.Size(201, 50)
        Me.ObservacionTxt.TabIndex = 10
        '
        'PrecioLbl
        '
        Me.PrecioLbl.AutoSize = True
        Me.PrecioLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrecioLbl.Location = New System.Drawing.Point(212, 84)
        Me.PrecioLbl.Name = "PrecioLbl"
        Me.PrecioLbl.Size = New System.Drawing.Size(50, 29)
        Me.PrecioLbl.TabIndex = 11
        Me.PrecioLbl.Tag = "Precio"
        Me.PrecioLbl.Text = "Precio"
        Me.PrecioLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PrecioTxt
        '
        Me.PrecioTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrecioTxt.Location = New System.Drawing.Point(268, 87)
        Me.PrecioTxt.Name = "PrecioTxt"
        Me.PrecioTxt.Size = New System.Drawing.Size(145, 23)
        Me.PrecioTxt.TabIndex = 12
        '
        'GrillaServicios
        '
        Me.GrillaServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaServicios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrillaServicios.Location = New System.Drawing.Point(307, 198)
        Me.GrillaServicios.Name = "GrillaServicios"
        Me.TableLayoutPanel1.SetRowSpan(Me.GrillaServicios, 2)
        Me.GrillaServicios.Size = New System.Drawing.Size(422, 123)
        Me.GrillaServicios.TabIndex = 5
        '
        'DescripcionLbl
        '
        Me.DescripcionLbl.AutoSize = True
        Me.DescripcionLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescripcionLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.DescripcionLbl.Location = New System.Drawing.Point(3, 195)
        Me.DescripcionLbl.Name = "DescripcionLbl"
        Me.DescripcionLbl.Size = New System.Drawing.Size(135, 17)
        Me.DescripcionLbl.TabIndex = 7
        Me.DescripcionLbl.Tag = "Agregar descripcion"
        Me.DescripcionLbl.Text = "Agregar descripción"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel1.SetColumnSpan(Me.TableLayoutPanel4, 2)
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.AgregarBtn, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.BorrarBtn, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 327)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(726, 38)
        Me.TableLayoutPanel4.TabIndex = 12
        '
        'AgregarBtn
        '
        Me.AgregarBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AgregarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AgregarBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgregarBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.AgregarBtn.Location = New System.Drawing.Point(3, 3)
        Me.AgregarBtn.Name = "AgregarBtn"
        Me.AgregarBtn.Size = New System.Drawing.Size(357, 32)
        Me.AgregarBtn.TabIndex = 5
        Me.AgregarBtn.Tag = "Agregar"
        Me.AgregarBtn.Text = "Agregar"
        Me.AgregarBtn.UseVisualStyleBackColor = True
        '
        'BorrarBtn
        '
        Me.BorrarBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BorrarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BorrarBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorrarBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BorrarBtn.Location = New System.Drawing.Point(366, 3)
        Me.BorrarBtn.Name = "BorrarBtn"
        Me.BorrarBtn.Size = New System.Drawing.Size(357, 32)
        Me.BorrarBtn.TabIndex = 6
        Me.BorrarBtn.Tag = "Borrar"
        Me.BorrarBtn.Text = "Borrar"
        Me.BorrarBtn.UseVisualStyleBackColor = True
        '
        'EventoGPB
        '
        Me.EventoGPB.Controls.Add(Me.TableLayoutPanel2)
        Me.EventoGPB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EventoGPB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EventoGPB.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.EventoGPB.Location = New System.Drawing.Point(3, 57)
        Me.EventoGPB.Name = "EventoGPB"
        Me.EventoGPB.Size = New System.Drawing.Size(298, 135)
        Me.EventoGPB.TabIndex = 200
        Me.EventoGPB.TabStop = False
        Me.EventoGPB.Tag = "Datos del evento"
        Me.EventoGPB.Text = "Datos del evento"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TipoEventoLbl, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.FechaLbl, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.CantidadLbl, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.SalonLbl, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.TipoEventoTxt, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.SalonTxt, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.FechaDTP, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.CantidadTxt, 1, 2)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 19)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(292, 113)
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
        Me.SalonLbl.Size = New System.Drawing.Size(144, 29)
        Me.SalonLbl.TabIndex = 3
        Me.SalonLbl.Tag = "Salon"
        Me.SalonLbl.Text = "Salón"
        Me.SalonLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TipoEventoTxt
        '
        Me.TipoEventoTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TipoEventoTxt.Enabled = False
        Me.TipoEventoTxt.Location = New System.Drawing.Point(153, 3)
        Me.TipoEventoTxt.Name = "TipoEventoTxt"
        Me.TipoEventoTxt.Size = New System.Drawing.Size(136, 23)
        Me.TipoEventoTxt.TabIndex = 4
        '
        'SalonTxt
        '
        Me.SalonTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SalonTxt.Enabled = False
        Me.SalonTxt.Location = New System.Drawing.Point(153, 87)
        Me.SalonTxt.Name = "SalonTxt"
        Me.SalonTxt.Size = New System.Drawing.Size(136, 23)
        Me.SalonTxt.TabIndex = 5
        '
        'FechaDTP
        '
        Me.FechaDTP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FechaDTP.Enabled = False
        Me.FechaDTP.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaDTP.Location = New System.Drawing.Point(153, 31)
        Me.FechaDTP.Name = "FechaDTP"
        Me.FechaDTP.Size = New System.Drawing.Size(136, 23)
        Me.FechaDTP.TabIndex = 6
        '
        'CantidadTxt
        '
        Me.CantidadTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CantidadTxt.Enabled = False
        Me.CantidadTxt.Location = New System.Drawing.Point(153, 59)
        Me.CantidadTxt.Name = "CantidadTxt"
        Me.CantidadTxt.Size = New System.Drawing.Size(136, 23)
        Me.CantidadTxt.TabIndex = 7
        '
        'ReservarServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(732, 368)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ReservarServicio"
        Me.Text = "EvOrg"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ServicioGPB.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.GrillaServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.EventoGPB.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents SeleccionarEventoLbl As Label
    Friend WithEvents EventoCombo As ComboBox
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
    Friend WithEvents SeleccionarServicioLbl As Label
    Friend WithEvents ServicioCombo As ComboBox
    Friend WithEvents GrillaServicios As DataGridView
    Friend WithEvents ServicioGPB As GroupBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents NombreLbl As Label
    Friend WithEvents TelefonoLbl As Label
    Friend WithEvents EmailLbl As Label
    Friend WithEvents DireccionLbl As Label
    Friend WithEvents NombreTxt As TextBox
    Friend WithEvents DireccionTxt As TextBox
    Friend WithEvents EmailTxt As TextBox
    Friend WithEvents TelefonoTxt As TextBox
    Friend WithEvents DescripcionTxt As TextBox
    Friend WithEvents ObservacionLbl As Label
    Friend WithEvents ObservacionTxt As TextBox
    Friend WithEvents DescripcionLbl As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents AgregarBtn As Button
    Friend WithEvents BorrarBtn As Button
    Friend WithEvents PrecioLbl As Label
    Friend WithEvents PrecioTxt As TextBox
End Class
