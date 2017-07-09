<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SeleccionarSalon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SeleccionarSalon))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.DireccionGrp = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.CalleLbl = New System.Windows.Forms.Label()
        Me.NumeroLbl = New System.Windows.Forms.Label()
        Me.LocalidadLbl = New System.Windows.Forms.Label()
        Me.CalleTxt = New System.Windows.Forms.TextBox()
        Me.NumeroTxt = New System.Windows.Forms.TextBox()
        Me.LocalidadTxt = New System.Windows.Forms.TextBox()
        Me.GrillaSalones = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.FiltroLocalidadBtn = New System.Windows.Forms.Button()
        Me.AceptarBtn = New System.Windows.Forms.Button()
        Me.CancelarBtn = New System.Windows.Forms.Button()
        Me.VerTodosBtn = New System.Windows.Forms.Button()
        Me.GMapa = New GMap.NET.WindowsForms.GMapControl()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.DireccionGrp.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.GrillaSalones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 532.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.DireccionGrp, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GrillaSalones, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.GMapa, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(874, 396)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'DireccionGrp
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.DireccionGrp, 2)
        Me.DireccionGrp.Controls.Add(Me.TableLayoutPanel3)
        Me.DireccionGrp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DireccionGrp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DireccionGrp.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.DireccionGrp.Location = New System.Drawing.Point(3, 293)
        Me.DireccionGrp.Name = "DireccionGrp"
        Me.DireccionGrp.Size = New System.Drawing.Size(868, 52)
        Me.DireccionGrp.TabIndex = 22
        Me.DireccionGrp.TabStop = False
        Me.DireccionGrp.Tag = "Direccion"
        Me.DireccionGrp.Text = "Dirección"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel3.ColumnCount = 6
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 191.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.CalleLbl, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.NumeroLbl, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.LocalidadLbl, 4, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.CalleTxt, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.NumeroTxt, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.LocalidadTxt, 5, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 19)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(862, 30)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'CalleLbl
        '
        Me.CalleLbl.AutoSize = True
        Me.CalleLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CalleLbl.Location = New System.Drawing.Point(3, 0)
        Me.CalleLbl.Name = "CalleLbl"
        Me.CalleLbl.Size = New System.Drawing.Size(47, 30)
        Me.CalleLbl.TabIndex = 0
        Me.CalleLbl.Tag = "Calle"
        Me.CalleLbl.Text = "Calle"
        Me.CalleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NumeroLbl
        '
        Me.NumeroLbl.AutoSize = True
        Me.NumeroLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NumeroLbl.Location = New System.Drawing.Point(460, 0)
        Me.NumeroLbl.Name = "NumeroLbl"
        Me.NumeroLbl.Size = New System.Drawing.Size(58, 30)
        Me.NumeroLbl.TabIndex = 1
        Me.NumeroLbl.Tag = "Numero"
        Me.NumeroLbl.Text = "Número"
        Me.NumeroLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LocalidadLbl
        '
        Me.LocalidadLbl.AutoSize = True
        Me.LocalidadLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LocalidadLbl.Location = New System.Drawing.Point(596, 0)
        Me.LocalidadLbl.Name = "LocalidadLbl"
        Me.LocalidadLbl.Size = New System.Drawing.Size(72, 30)
        Me.LocalidadLbl.TabIndex = 2
        Me.LocalidadLbl.Tag = "Localidad"
        Me.LocalidadLbl.Text = "Localidad"
        Me.LocalidadLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CalleTxt
        '
        Me.CalleTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CalleTxt.Enabled = False
        Me.CalleTxt.Location = New System.Drawing.Point(56, 3)
        Me.CalleTxt.Name = "CalleTxt"
        Me.CalleTxt.Size = New System.Drawing.Size(398, 23)
        Me.CalleTxt.TabIndex = 7
        '
        'NumeroTxt
        '
        Me.NumeroTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NumeroTxt.Enabled = False
        Me.NumeroTxt.Location = New System.Drawing.Point(524, 3)
        Me.NumeroTxt.Name = "NumeroTxt"
        Me.NumeroTxt.Size = New System.Drawing.Size(66, 23)
        Me.NumeroTxt.TabIndex = 8
        '
        'LocalidadTxt
        '
        Me.LocalidadTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LocalidadTxt.Enabled = False
        Me.LocalidadTxt.Location = New System.Drawing.Point(674, 3)
        Me.LocalidadTxt.Name = "LocalidadTxt"
        Me.LocalidadTxt.Size = New System.Drawing.Size(185, 23)
        Me.LocalidadTxt.TabIndex = 9
        '
        'GrillaSalones
        '
        Me.GrillaSalones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaSalones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrillaSalones.Location = New System.Drawing.Point(3, 3)
        Me.GrillaSalones.Name = "GrillaSalones"
        Me.GrillaSalones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrillaSalones.Size = New System.Drawing.Size(526, 284)
        Me.GrillaSalones.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel1.SetColumnSpan(Me.TableLayoutPanel2, 2)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.FiltroLocalidadBtn, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.AceptarBtn, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.CancelarBtn, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.VerTodosBtn, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 351)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(868, 42)
        Me.TableLayoutPanel2.TabIndex = 4
        '
        'FiltroLocalidadBtn
        '
        Me.FiltroLocalidadBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FiltroLocalidadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FiltroLocalidadBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FiltroLocalidadBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FiltroLocalidadBtn.Location = New System.Drawing.Point(437, 3)
        Me.FiltroLocalidadBtn.Name = "FiltroLocalidadBtn"
        Me.FiltroLocalidadBtn.Size = New System.Drawing.Size(211, 36)
        Me.FiltroLocalidadBtn.TabIndex = 5
        Me.FiltroLocalidadBtn.Tag = "Filtrar por localidad"
        Me.FiltroLocalidadBtn.Text = "Filtrar por localidad"
        Me.FiltroLocalidadBtn.UseVisualStyleBackColor = True
        '
        'AceptarBtn
        '
        Me.AceptarBtn.BackColor = System.Drawing.Color.Transparent
        Me.AceptarBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AceptarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AceptarBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AceptarBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.AceptarBtn.Location = New System.Drawing.Point(3, 3)
        Me.AceptarBtn.Name = "AceptarBtn"
        Me.AceptarBtn.Size = New System.Drawing.Size(211, 36)
        Me.AceptarBtn.TabIndex = 2
        Me.AceptarBtn.Tag = "Aceptar"
        Me.AceptarBtn.Text = "Aceptar"
        Me.AceptarBtn.UseVisualStyleBackColor = False
        '
        'CancelarBtn
        '
        Me.CancelarBtn.BackColor = System.Drawing.Color.Transparent
        Me.CancelarBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CancelarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelarBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelarBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CancelarBtn.Location = New System.Drawing.Point(654, 3)
        Me.CancelarBtn.Name = "CancelarBtn"
        Me.CancelarBtn.Size = New System.Drawing.Size(211, 36)
        Me.CancelarBtn.TabIndex = 3
        Me.CancelarBtn.Tag = "Cancelar"
        Me.CancelarBtn.Text = "Cancelar"
        Me.CancelarBtn.UseVisualStyleBackColor = False
        '
        'VerTodosBtn
        '
        Me.VerTodosBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VerTodosBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VerTodosBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VerTodosBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.VerTodosBtn.Location = New System.Drawing.Point(220, 3)
        Me.VerTodosBtn.Name = "VerTodosBtn"
        Me.VerTodosBtn.Size = New System.Drawing.Size(211, 36)
        Me.VerTodosBtn.TabIndex = 4
        Me.VerTodosBtn.Tag = "Ver todos"
        Me.VerTodosBtn.Text = "Ver todos"
        Me.VerTodosBtn.UseVisualStyleBackColor = True
        '
        'GMapa
        '
        Me.GMapa.Bearing = 0!
        Me.GMapa.CanDragMap = True
        Me.GMapa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GMapa.EmptyTileColor = System.Drawing.Color.Navy
        Me.GMapa.GrayScaleMode = False
        Me.GMapa.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow
        Me.GMapa.LevelsKeepInMemmory = 5
        Me.GMapa.Location = New System.Drawing.Point(535, 3)
        Me.GMapa.MarkersEnabled = True
        Me.GMapa.MaxZoom = 2
        Me.GMapa.MinZoom = 18
        Me.GMapa.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter
        Me.GMapa.Name = "GMapa"
        Me.GMapa.NegativeMode = False
        Me.GMapa.PolygonsEnabled = True
        Me.GMapa.RetryLoadTile = 0
        Me.GMapa.RoutesEnabled = True
        Me.GMapa.ScaleMode = GMap.NET.WindowsForms.ScaleModes.[Integer]
        Me.GMapa.SelectedAreaFillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.GMapa.ShowTileGridLines = False
        Me.GMapa.Size = New System.Drawing.Size(336, 284)
        Me.GMapa.TabIndex = 5
        Me.GMapa.Zoom = 18.0R
        '
        'SeleccionarSalon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(874, 396)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SeleccionarSalon"
        Me.Text = "EvOrg"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.DireccionGrp.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.GrillaSalones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GrillaSalones As DataGridView
    Friend WithEvents AceptarBtn As Button
    Friend WithEvents CancelarBtn As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents GMapa As GMap.NET.WindowsForms.GMapControl
    Friend WithEvents DireccionGrp As GroupBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents CalleLbl As Label
    Friend WithEvents NumeroLbl As Label
    Friend WithEvents LocalidadLbl As Label
    Friend WithEvents CalleTxt As TextBox
    Friend WithEvents NumeroTxt As TextBox
    Friend WithEvents LocalidadTxt As TextBox
    Friend WithEvents FiltroLocalidadBtn As Button
    Friend WithEvents VerTodosBtn As Button
End Class
