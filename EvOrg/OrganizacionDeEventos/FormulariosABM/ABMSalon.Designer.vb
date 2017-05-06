<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABMSalon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ABMSalon))
        Me.GrillaSalones = New System.Windows.Forms.DataGridView()
        Me.ListaSalonesLbl = New System.Windows.Forms.Label()
        Me.NombreLbl = New System.Windows.Forms.Label()
        Me.CapacidadLbl = New System.Windows.Forms.Label()
        Me.DescripcionLbl = New System.Windows.Forms.Label()
        Me.TelefonoLbl = New System.Windows.Forms.Label()
        Me.EmailLbl = New System.Windows.Forms.Label()
        Me.NombreTxt = New System.Windows.Forms.TextBox()
        Me.CapacidadTxt = New System.Windows.Forms.TextBox()
        Me.DescripcionTxt = New System.Windows.Forms.TextBox()
        Me.EmailTxt = New System.Windows.Forms.TextBox()
        Me.TelefonoTxt = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.AltaBtn = New System.Windows.Forms.Button()
        Me.BajaBtn = New System.Windows.Forms.Button()
        Me.ModificacionBtn = New System.Windows.Forms.Button()
        Me.DireccionGrp = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.CalleLbl = New System.Windows.Forms.Label()
        Me.NumeroLbl = New System.Windows.Forms.Label()
        Me.CPLbl = New System.Windows.Forms.Label()
        Me.CalleTxt = New System.Windows.Forms.TextBox()
        Me.NumeroTxt = New System.Windows.Forms.TextBox()
        Me.CPTxt = New System.Windows.Forms.TextBox()
        CType(Me.GrillaSalones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.DireccionGrp.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrillaSalones
        '
        Me.GrillaSalones.AllowUserToAddRows = False
        Me.GrillaSalones.AllowUserToDeleteRows = False
        Me.GrillaSalones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableLayoutPanel1.SetColumnSpan(Me.GrillaSalones, 4)
        Me.GrillaSalones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrillaSalones.Location = New System.Drawing.Point(3, 35)
        Me.GrillaSalones.Name = "GrillaSalones"
        Me.GrillaSalones.ReadOnly = True
        Me.TableLayoutPanel1.SetRowSpan(Me.GrillaSalones, 2)
        Me.GrillaSalones.Size = New System.Drawing.Size(545, 203)
        Me.GrillaSalones.TabIndex = 0
        '
        'ListaSalonesLbl
        '
        Me.ListaSalonesLbl.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.ListaSalonesLbl, 6)
        Me.ListaSalonesLbl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ListaSalonesLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListaSalonesLbl.Location = New System.Drawing.Point(3, 15)
        Me.ListaSalonesLbl.Name = "ListaSalonesLbl"
        Me.ListaSalonesLbl.Size = New System.Drawing.Size(757, 17)
        Me.ListaSalonesLbl.TabIndex = 1
        Me.ListaSalonesLbl.Text = "Lista de Salones"
        '
        'NombreLbl
        '
        Me.NombreLbl.AutoSize = True
        Me.NombreLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NombreLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreLbl.Location = New System.Drawing.Point(3, 241)
        Me.NombreLbl.Name = "NombreLbl"
        Me.NombreLbl.Size = New System.Drawing.Size(67, 27)
        Me.NombreLbl.TabIndex = 2
        Me.NombreLbl.Text = "Nombre"
        Me.NombreLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CapacidadLbl
        '
        Me.CapacidadLbl.AutoSize = True
        Me.CapacidadLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CapacidadLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CapacidadLbl.Location = New System.Drawing.Point(355, 241)
        Me.CapacidadLbl.Name = "CapacidadLbl"
        Me.CapacidadLbl.Size = New System.Drawing.Size(75, 27)
        Me.CapacidadLbl.TabIndex = 4
        Me.CapacidadLbl.Text = "Capacidad"
        Me.CapacidadLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DescripcionLbl
        '
        Me.DescripcionLbl.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.DescripcionLbl, 2)
        Me.DescripcionLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DescripcionLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescripcionLbl.Location = New System.Drawing.Point(554, 32)
        Me.DescripcionLbl.Name = "DescripcionLbl"
        Me.DescripcionLbl.Size = New System.Drawing.Size(206, 26)
        Me.DescripcionLbl.TabIndex = 5
        Me.DescripcionLbl.Text = "Descripción"
        Me.DescripcionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TelefonoLbl
        '
        Me.TelefonoLbl.AutoSize = True
        Me.TelefonoLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TelefonoLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelefonoLbl.Location = New System.Drawing.Point(355, 268)
        Me.TelefonoLbl.Name = "TelefonoLbl"
        Me.TelefonoLbl.Size = New System.Drawing.Size(75, 30)
        Me.TelefonoLbl.TabIndex = 6
        Me.TelefonoLbl.Text = "Teléfono"
        Me.TelefonoLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EmailLbl
        '
        Me.EmailLbl.AutoSize = True
        Me.EmailLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EmailLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailLbl.Location = New System.Drawing.Point(3, 268)
        Me.EmailLbl.Name = "EmailLbl"
        Me.EmailLbl.Size = New System.Drawing.Size(67, 30)
        Me.EmailLbl.TabIndex = 7
        Me.EmailLbl.Text = "E-mail"
        Me.EmailLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NombreTxt
        '
        Me.NombreTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NombreTxt.Location = New System.Drawing.Point(76, 244)
        Me.NombreTxt.Name = "NombreTxt"
        Me.NombreTxt.Size = New System.Drawing.Size(273, 20)
        Me.NombreTxt.TabIndex = 8
        '
        'CapacidadTxt
        '
        Me.CapacidadTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CapacidadTxt.Location = New System.Drawing.Point(436, 244)
        Me.CapacidadTxt.Name = "CapacidadTxt"
        Me.CapacidadTxt.Size = New System.Drawing.Size(112, 20)
        Me.CapacidadTxt.TabIndex = 9
        '
        'DescripcionTxt
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.DescripcionTxt, 2)
        Me.DescripcionTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DescripcionTxt.Location = New System.Drawing.Point(554, 61)
        Me.DescripcionTxt.Multiline = True
        Me.DescripcionTxt.Name = "DescripcionTxt"
        Me.TableLayoutPanel1.SetRowSpan(Me.DescripcionTxt, 3)
        Me.DescripcionTxt.Size = New System.Drawing.Size(206, 234)
        Me.DescripcionTxt.TabIndex = 10
        '
        'EmailTxt
        '
        Me.EmailTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EmailTxt.Location = New System.Drawing.Point(76, 271)
        Me.EmailTxt.Name = "EmailTxt"
        Me.EmailTxt.Size = New System.Drawing.Size(273, 20)
        Me.EmailTxt.TabIndex = 11
        '
        'TelefonoTxt
        '
        Me.TelefonoTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TelefonoTxt.Location = New System.Drawing.Point(436, 271)
        Me.TelefonoTxt.Name = "TelefonoTxt"
        Me.TelefonoTxt.Size = New System.Drawing.Size(112, 20)
        Me.TelefonoTxt.TabIndex = 12
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.BackgroundImage = CType(resources.GetObject("TableLayoutPanel1.BackgroundImage"), System.Drawing.Image)
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 279.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 118.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ListaSalonesLbl, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TelefonoTxt, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.GrillaSalones, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.EmailTxt, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.EmailLbl, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.NombreLbl, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.NombreTxt, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.CapacidadTxt, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.CapacidadLbl, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TelefonoLbl, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.DescripcionTxt, 4, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.DescripcionLbl, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.DireccionGrp, 0, 5)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 183.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(763, 396)
        Me.TableLayoutPanel1.TabIndex = 14
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel1.SetColumnSpan(Me.TableLayoutPanel2, 6)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Controls.Add(Me.AltaBtn, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BajaBtn, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ModificacionBtn, 2, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 357)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(757, 36)
        Me.TableLayoutPanel2.TabIndex = 20
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
        Me.AltaBtn.Size = New System.Drawing.Size(246, 30)
        Me.AltaBtn.TabIndex = 0
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
        Me.BajaBtn.Location = New System.Drawing.Point(255, 3)
        Me.BajaBtn.Name = "BajaBtn"
        Me.BajaBtn.Size = New System.Drawing.Size(246, 30)
        Me.BajaBtn.TabIndex = 1
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
        Me.ModificacionBtn.Location = New System.Drawing.Point(507, 3)
        Me.ModificacionBtn.Name = "ModificacionBtn"
        Me.ModificacionBtn.Size = New System.Drawing.Size(247, 30)
        Me.ModificacionBtn.TabIndex = 2
        Me.ModificacionBtn.Text = "Modificar"
        Me.ModificacionBtn.UseVisualStyleBackColor = True
        '
        'DireccionGrp
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.DireccionGrp, 6)
        Me.DireccionGrp.Controls.Add(Me.TableLayoutPanel3)
        Me.DireccionGrp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DireccionGrp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DireccionGrp.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.DireccionGrp.Location = New System.Drawing.Point(3, 301)
        Me.DireccionGrp.Name = "DireccionGrp"
        Me.DireccionGrp.Size = New System.Drawing.Size(757, 50)
        Me.DireccionGrp.TabIndex = 21
        Me.DireccionGrp.TabStop = False
        Me.DireccionGrp.Text = "Dirección"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel3.ColumnCount = 6
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 330.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 147.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.CalleLbl, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.NumeroLbl, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.CPLbl, 4, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.CalleTxt, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.NumeroTxt, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.CPTxt, 5, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 19)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(751, 28)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'CalleLbl
        '
        Me.CalleLbl.AutoSize = True
        Me.CalleLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CalleLbl.Location = New System.Drawing.Point(3, 0)
        Me.CalleLbl.Name = "CalleLbl"
        Me.CalleLbl.Size = New System.Drawing.Size(67, 28)
        Me.CalleLbl.TabIndex = 0
        Me.CalleLbl.Text = "Calle"
        Me.CalleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NumeroLbl
        '
        Me.NumeroLbl.AutoSize = True
        Me.NumeroLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NumeroLbl.Location = New System.Drawing.Point(406, 0)
        Me.NumeroLbl.Name = "NumeroLbl"
        Me.NumeroLbl.Size = New System.Drawing.Size(58, 28)
        Me.NumeroLbl.TabIndex = 1
        Me.NumeroLbl.Text = "Número"
        Me.NumeroLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CPLbl
        '
        Me.CPLbl.AutoSize = True
        Me.CPLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CPLbl.Location = New System.Drawing.Point(561, 0)
        Me.CPLbl.Name = "CPLbl"
        Me.CPLbl.Size = New System.Drawing.Size(40, 28)
        Me.CPLbl.TabIndex = 2
        Me.CPLbl.Text = "C. P."
        Me.CPLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CalleTxt
        '
        Me.CalleTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CalleTxt.Location = New System.Drawing.Point(76, 3)
        Me.CalleTxt.Name = "CalleTxt"
        Me.CalleTxt.Size = New System.Drawing.Size(324, 23)
        Me.CalleTxt.TabIndex = 3
        '
        'NumeroTxt
        '
        Me.NumeroTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NumeroTxt.Location = New System.Drawing.Point(470, 3)
        Me.NumeroTxt.Name = "NumeroTxt"
        Me.NumeroTxt.Size = New System.Drawing.Size(85, 23)
        Me.NumeroTxt.TabIndex = 4
        '
        'CPTxt
        '
        Me.CPTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CPTxt.Location = New System.Drawing.Point(607, 3)
        Me.CPTxt.Name = "CPTxt"
        Me.CPTxt.Size = New System.Drawing.Size(141, 23)
        Me.CPTxt.TabIndex = 5
        '
        'ABMSalon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 396)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MaximumSize = New System.Drawing.Size(779, 435)
        Me.MinimumSize = New System.Drawing.Size(779, 435)
        Me.Name = "ABMSalon"
        Me.Text = "ABMSalón"
        CType(Me.GrillaSalones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.DireccionGrp.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GrillaSalones As DataGridView
    Friend WithEvents ListaSalonesLbl As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TelefonoTxt As TextBox
    Friend WithEvents EmailTxt As TextBox
    Friend WithEvents EmailLbl As Label
    Friend WithEvents NombreLbl As Label
    Friend WithEvents NombreTxt As TextBox
    Friend WithEvents CapacidadTxt As TextBox
    Friend WithEvents CapacidadLbl As Label
    Friend WithEvents TelefonoLbl As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents AltaBtn As Button
    Friend WithEvents BajaBtn As Button
    Friend WithEvents ModificacionBtn As Button
    Friend WithEvents DescripcionTxt As TextBox
    Friend WithEvents DescripcionLbl As Label
    Friend WithEvents DireccionGrp As GroupBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents CalleLbl As Label
    Friend WithEvents NumeroLbl As Label
    Friend WithEvents CPLbl As Label
    Friend WithEvents CalleTxt As TextBox
    Friend WithEvents NumeroTxt As TextBox
    Friend WithEvents CPTxt As TextBox
End Class
