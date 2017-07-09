<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrganizarEvento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrganizarEvento))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.SeleccionarTipoFechaLbl = New System.Windows.Forms.Label()
        Me.TipoEventoCombo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CantidadNumeric = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LocalidadTxt = New System.Windows.Forms.TextBox()
        Me.ClienteGPB = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.DNILbl = New System.Windows.Forms.Label()
        Me.DNITxt = New System.Windows.Forms.TextBox()
        Me.BuscarClienteBtn = New System.Windows.Forms.Button()
        Me.NombreLbl = New System.Windows.Forms.Label()
        Me.ApellidoLbl = New System.Windows.Forms.Label()
        Me.NombreTxt = New System.Windows.Forms.TextBox()
        Me.ApellidoTxt = New System.Windows.Forms.TextBox()
        Me.TelefonoLbl = New System.Windows.Forms.Label()
        Me.TelefonoTxt = New System.Windows.Forms.TextBox()
        Me.EmailLbl = New System.Windows.Forms.Label()
        Me.EmailTxt = New System.Windows.Forms.TextBox()
        Me.FechaDTP = New System.Windows.Forms.DateTimePicker()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.ReservarMaterialBtn = New System.Windows.Forms.Button()
        Me.ReservarServicioBtn = New System.Windows.Forms.Button()
        Me.SeleccionarSalonBtn = New System.Windows.Forms.Button()
        Me.VerPasosBtn = New System.Windows.Forms.Button()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.GuardarBtn = New System.Windows.Forms.Button()
        Me.CancelarBtn = New System.Windows.Forms.Button()
        Me.NombreEventoLbl = New System.Windows.Forms.Label()
        Me.NombreEventoTxt = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.CantidadNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClienteGPB.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 153.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 217.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.SeleccionarTipoFechaLbl, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TipoEventoCombo, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.CantidadNumeric, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LocalidadTxt, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.ClienteGPB, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.FechaDTP, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.NombreEventoLbl, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.NombreEventoTxt, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 124.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(570, 342)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'SeleccionarTipoFechaLbl
        '
        Me.SeleccionarTipoFechaLbl.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.SeleccionarTipoFechaLbl, 2)
        Me.SeleccionarTipoFechaLbl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SeleccionarTipoFechaLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SeleccionarTipoFechaLbl.Location = New System.Drawing.Point(5, 40)
        Me.SeleccionarTipoFechaLbl.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.SeleccionarTipoFechaLbl.Name = "SeleccionarTipoFechaLbl"
        Me.SeleccionarTipoFechaLbl.Size = New System.Drawing.Size(260, 17)
        Me.SeleccionarTipoFechaLbl.TabIndex = 12
        Me.SeleccionarTipoFechaLbl.Tag = "Seleccionar tipo y fecha del evento"
        Me.SeleccionarTipoFechaLbl.Text = "Seleccionar tipo y fecha del evento"
        '
        'TipoEventoCombo
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.TipoEventoCombo, 2)
        Me.TipoEventoCombo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TipoEventoCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TipoEventoCombo.FormattingEnabled = True
        Me.TipoEventoCombo.Location = New System.Drawing.Point(4, 61)
        Me.TipoEventoCombo.Margin = New System.Windows.Forms.Padding(4)
        Me.TipoEventoCombo.Name = "TipoEventoCombo"
        Me.TipoEventoCombo.Size = New System.Drawing.Size(262, 24)
        Me.TipoEventoCombo.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(4, 89)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 30)
        Me.Label2.TabIndex = 13
        Me.Label2.Tag = "Cantidad de invitados"
        Me.Label2.Text = "Cantidad de invitados"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CantidadNumeric
        '
        Me.CantidadNumeric.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CantidadNumeric.Location = New System.Drawing.Point(157, 93)
        Me.CantidadNumeric.Margin = New System.Windows.Forms.Padding(4)
        Me.CantidadNumeric.Name = "CantidadNumeric"
        Me.CantidadNumeric.Size = New System.Drawing.Size(109, 23)
        Me.CantidadNumeric.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(274, 89)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 30)
        Me.Label3.TabIndex = 14
        Me.Label3.Tag = "Localidad"
        Me.Label3.Text = "Localidad"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LocalidadTxt
        '
        Me.LocalidadTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LocalidadTxt.Location = New System.Drawing.Point(357, 93)
        Me.LocalidadTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.LocalidadTxt.Name = "LocalidadTxt"
        Me.LocalidadTxt.Size = New System.Drawing.Size(209, 23)
        Me.LocalidadTxt.TabIndex = 3
        '
        'ClienteGPB
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.ClienteGPB, 4)
        Me.ClienteGPB.Controls.Add(Me.TableLayoutPanel2)
        Me.ClienteGPB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ClienteGPB.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClienteGPB.Location = New System.Drawing.Point(4, 123)
        Me.ClienteGPB.Margin = New System.Windows.Forms.Padding(4)
        Me.ClienteGPB.Name = "ClienteGPB"
        Me.ClienteGPB.Padding = New System.Windows.Forms.Padding(4)
        Me.ClienteGPB.Size = New System.Drawing.Size(562, 116)
        Me.ClienteGPB.TabIndex = 10
        Me.ClienteGPB.TabStop = False
        Me.ClienteGPB.Tag = "Datos del cliente"
        Me.ClienteGPB.Text = "Datos del cliente"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 6
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.DNILbl, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.DNITxt, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BuscarClienteBtn, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.NombreLbl, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.ApellidoLbl, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.NombreTxt, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.ApellidoTxt, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TelefonoLbl, 4, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TelefonoTxt, 5, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.EmailLbl, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.EmailTxt, 1, 2)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(4, 20)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(554, 92)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'DNILbl
        '
        Me.DNILbl.AutoSize = True
        Me.DNILbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DNILbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.DNILbl.Location = New System.Drawing.Point(4, 0)
        Me.DNILbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DNILbl.Name = "DNILbl"
        Me.DNILbl.Size = New System.Drawing.Size(58, 35)
        Me.DNILbl.TabIndex = 15
        Me.DNILbl.Tag = "DNI"
        Me.DNILbl.Text = "DNI"
        Me.DNILbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DNITxt
        '
        Me.DNITxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DNITxt.Location = New System.Drawing.Point(70, 4)
        Me.DNITxt.Margin = New System.Windows.Forms.Padding(4)
        Me.DNITxt.Name = "DNITxt"
        Me.DNITxt.Size = New System.Drawing.Size(120, 23)
        Me.DNITxt.TabIndex = 4
        '
        'BuscarClienteBtn
        '
        Me.TableLayoutPanel2.SetColumnSpan(Me.BuscarClienteBtn, 4)
        Me.BuscarClienteBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BuscarClienteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BuscarClienteBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BuscarClienteBtn.Location = New System.Drawing.Point(198, 4)
        Me.BuscarClienteBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.BuscarClienteBtn.Name = "BuscarClienteBtn"
        Me.BuscarClienteBtn.Size = New System.Drawing.Size(352, 27)
        Me.BuscarClienteBtn.TabIndex = 5
        Me.BuscarClienteBtn.Tag = "Buscar cliente"
        Me.BuscarClienteBtn.Text = "Buscar cliente"
        Me.BuscarClienteBtn.UseVisualStyleBackColor = True
        '
        'NombreLbl
        '
        Me.NombreLbl.AutoSize = True
        Me.NombreLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NombreLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.NombreLbl.Location = New System.Drawing.Point(4, 35)
        Me.NombreLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.NombreLbl.Name = "NombreLbl"
        Me.NombreLbl.Size = New System.Drawing.Size(58, 29)
        Me.NombreLbl.TabIndex = 16
        Me.NombreLbl.Tag = "Nombre"
        Me.NombreLbl.Text = "Nombre"
        Me.NombreLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ApellidoLbl
        '
        Me.ApellidoLbl.AutoSize = True
        Me.ApellidoLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ApellidoLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ApellidoLbl.Location = New System.Drawing.Point(198, 35)
        Me.ApellidoLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ApellidoLbl.Name = "ApellidoLbl"
        Me.ApellidoLbl.Size = New System.Drawing.Size(80, 29)
        Me.ApellidoLbl.TabIndex = 18
        Me.ApellidoLbl.Tag = "Apellido"
        Me.ApellidoLbl.Text = "Apellido"
        Me.ApellidoLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NombreTxt
        '
        Me.NombreTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NombreTxt.Enabled = False
        Me.NombreTxt.Location = New System.Drawing.Point(70, 39)
        Me.NombreTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.NombreTxt.Name = "NombreTxt"
        Me.NombreTxt.Size = New System.Drawing.Size(120, 23)
        Me.NombreTxt.TabIndex = 17
        '
        'ApellidoTxt
        '
        Me.ApellidoTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ApellidoTxt.Enabled = False
        Me.ApellidoTxt.Location = New System.Drawing.Point(286, 39)
        Me.ApellidoTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.ApellidoTxt.Name = "ApellidoTxt"
        Me.ApellidoTxt.Size = New System.Drawing.Size(86, 23)
        Me.ApellidoTxt.TabIndex = 19
        '
        'TelefonoLbl
        '
        Me.TelefonoLbl.AutoSize = True
        Me.TelefonoLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TelefonoLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TelefonoLbl.Location = New System.Drawing.Point(380, 35)
        Me.TelefonoLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TelefonoLbl.Name = "TelefonoLbl"
        Me.TelefonoLbl.Size = New System.Drawing.Size(64, 29)
        Me.TelefonoLbl.TabIndex = 2
        Me.TelefonoLbl.Tag = "Telefono"
        Me.TelefonoLbl.Text = "Teléfono"
        Me.TelefonoLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TelefonoTxt
        '
        Me.TelefonoTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TelefonoTxt.Enabled = False
        Me.TelefonoTxt.Location = New System.Drawing.Point(452, 39)
        Me.TelefonoTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.TelefonoTxt.Name = "TelefonoTxt"
        Me.TelefonoTxt.Size = New System.Drawing.Size(98, 23)
        Me.TelefonoTxt.TabIndex = 21
        '
        'EmailLbl
        '
        Me.EmailLbl.AutoSize = True
        Me.EmailLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EmailLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.EmailLbl.Location = New System.Drawing.Point(4, 64)
        Me.EmailLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EmailLbl.Name = "EmailLbl"
        Me.EmailLbl.Size = New System.Drawing.Size(58, 28)
        Me.EmailLbl.TabIndex = 22
        Me.EmailLbl.Tag = "Email"
        Me.EmailLbl.Text = "Email"
        Me.EmailLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EmailTxt
        '
        Me.TableLayoutPanel2.SetColumnSpan(Me.EmailTxt, 5)
        Me.EmailTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EmailTxt.Enabled = False
        Me.EmailTxt.Location = New System.Drawing.Point(70, 68)
        Me.EmailTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.EmailTxt.Name = "EmailTxt"
        Me.EmailTxt.Size = New System.Drawing.Size(480, 23)
        Me.EmailTxt.TabIndex = 23
        '
        'FechaDTP
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.FechaDTP, 2)
        Me.FechaDTP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FechaDTP.Location = New System.Drawing.Point(274, 61)
        Me.FechaDTP.Margin = New System.Windows.Forms.Padding(4)
        Me.FechaDTP.Name = "FechaDTP"
        Me.FechaDTP.Size = New System.Drawing.Size(292, 23)
        Me.FechaDTP.TabIndex = 1
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel1.SetColumnSpan(Me.TableLayoutPanel3, 4)
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.ReservarMaterialBtn, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.ReservarServicioBtn, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.SeleccionarSalonBtn, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.VerPasosBtn, 3, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 246)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(564, 36)
        Me.TableLayoutPanel3.TabIndex = 14
        '
        'ReservarMaterialBtn
        '
        Me.ReservarMaterialBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReservarMaterialBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ReservarMaterialBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ReservarMaterialBtn.Location = New System.Drawing.Point(4, 4)
        Me.ReservarMaterialBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.ReservarMaterialBtn.Name = "ReservarMaterialBtn"
        Me.ReservarMaterialBtn.Size = New System.Drawing.Size(133, 28)
        Me.ReservarMaterialBtn.TabIndex = 8
        Me.ReservarMaterialBtn.Tag = "Reservar material"
        Me.ReservarMaterialBtn.Text = "Reservar material"
        Me.ReservarMaterialBtn.UseVisualStyleBackColor = True
        '
        'ReservarServicioBtn
        '
        Me.ReservarServicioBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReservarServicioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ReservarServicioBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ReservarServicioBtn.Location = New System.Drawing.Point(145, 4)
        Me.ReservarServicioBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.ReservarServicioBtn.Name = "ReservarServicioBtn"
        Me.ReservarServicioBtn.Size = New System.Drawing.Size(133, 28)
        Me.ReservarServicioBtn.TabIndex = 9
        Me.ReservarServicioBtn.Tag = "Reservar servicio"
        Me.ReservarServicioBtn.Text = "Reservar servicio"
        Me.ReservarServicioBtn.UseVisualStyleBackColor = True
        '
        'SeleccionarSalonBtn
        '
        Me.SeleccionarSalonBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SeleccionarSalonBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SeleccionarSalonBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SeleccionarSalonBtn.Location = New System.Drawing.Point(286, 4)
        Me.SeleccionarSalonBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.SeleccionarSalonBtn.Name = "SeleccionarSalonBtn"
        Me.SeleccionarSalonBtn.Size = New System.Drawing.Size(133, 28)
        Me.SeleccionarSalonBtn.TabIndex = 6
        Me.SeleccionarSalonBtn.Tag = "Seleccionar salon"
        Me.SeleccionarSalonBtn.Text = "Seleccionar salón"
        Me.SeleccionarSalonBtn.UseVisualStyleBackColor = True
        '
        'VerPasosBtn
        '
        Me.VerPasosBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VerPasosBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VerPasosBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.VerPasosBtn.Location = New System.Drawing.Point(427, 4)
        Me.VerPasosBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.VerPasosBtn.Name = "VerPasosBtn"
        Me.VerPasosBtn.Size = New System.Drawing.Size(133, 28)
        Me.VerPasosBtn.TabIndex = 7
        Me.VerPasosBtn.Tag = "Ver pasos"
        Me.VerPasosBtn.Text = "Ver pasos"
        Me.VerPasosBtn.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel1.SetColumnSpan(Me.TableLayoutPanel4, 4)
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.GuardarBtn, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.CancelarBtn, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 288)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(564, 51)
        Me.TableLayoutPanel4.TabIndex = 15
        '
        'GuardarBtn
        '
        Me.GuardarBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GuardarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GuardarBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GuardarBtn.Location = New System.Drawing.Point(4, 4)
        Me.GuardarBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.GuardarBtn.Name = "GuardarBtn"
        Me.GuardarBtn.Size = New System.Drawing.Size(274, 43)
        Me.GuardarBtn.TabIndex = 10
        Me.GuardarBtn.Tag = "Guardar"
        Me.GuardarBtn.Text = "Guardar"
        Me.GuardarBtn.UseVisualStyleBackColor = True
        '
        'CancelarBtn
        '
        Me.CancelarBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CancelarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelarBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CancelarBtn.Location = New System.Drawing.Point(286, 4)
        Me.CancelarBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.CancelarBtn.Name = "CancelarBtn"
        Me.CancelarBtn.Size = New System.Drawing.Size(274, 43)
        Me.CancelarBtn.TabIndex = 11
        Me.CancelarBtn.Tag = "Cancelar"
        Me.CancelarBtn.Text = "Cancelar"
        Me.CancelarBtn.UseVisualStyleBackColor = True
        '
        'NombreEventoLbl
        '
        Me.NombreEventoLbl.AutoSize = True
        Me.NombreEventoLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NombreEventoLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.NombreEventoLbl.Location = New System.Drawing.Point(3, 0)
        Me.NombreEventoLbl.Name = "NombreEventoLbl"
        Me.NombreEventoLbl.Size = New System.Drawing.Size(147, 30)
        Me.NombreEventoLbl.TabIndex = 16
        Me.NombreEventoLbl.Tag = "Nombre del evento"
        Me.NombreEventoLbl.Text = "Nombre del evento"
        Me.NombreEventoLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NombreEventoTxt
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.NombreEventoTxt, 3)
        Me.NombreEventoTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NombreEventoTxt.Location = New System.Drawing.Point(156, 3)
        Me.NombreEventoTxt.Name = "NombreEventoTxt"
        Me.NombreEventoTxt.Size = New System.Drawing.Size(411, 23)
        Me.NombreEventoTxt.TabIndex = 17
        '
        'OrganizarEvento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(570, 342)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "OrganizarEvento"
        Me.Text = "EvOrg"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.CantidadNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClienteGPB.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents SeleccionarTipoFechaLbl As Label
    Friend WithEvents TipoEventoCombo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CantidadNumeric As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents LocalidadTxt As TextBox
    Friend WithEvents ClienteGPB As GroupBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents DNILbl As Label
    Friend WithEvents BuscarClienteBtn As Button
    Friend WithEvents NombreLbl As Label
    Friend WithEvents DNITxt As TextBox
    Friend WithEvents NombreTxt As TextBox
    Friend WithEvents ApellidoLbl As Label
    Friend WithEvents ApellidoTxt As TextBox
    Friend WithEvents TelefonoLbl As Label
    Friend WithEvents TelefonoTxt As TextBox
    Friend WithEvents EmailLbl As Label
    Friend WithEvents EmailTxt As TextBox
    Friend WithEvents FechaDTP As DateTimePicker
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents ReservarMaterialBtn As Button
    Friend WithEvents ReservarServicioBtn As Button
    Friend WithEvents SeleccionarSalonBtn As Button
    Friend WithEvents VerPasosBtn As Button
    Friend WithEvents GuardarBtn As Button
    Friend WithEvents CancelarBtn As Button
    Friend WithEvents NombreEventoLbl As Label
    Friend WithEvents NombreEventoTxt As TextBox
End Class
