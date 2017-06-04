<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ABMCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ABMCliente))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ApellidoTxt = New System.Windows.Forms.TextBox()
        Me.NombreTxt = New System.Windows.Forms.TextBox()
        Me.DNILbl = New System.Windows.Forms.Label()
        Me.NombreLbl = New System.Windows.Forms.Label()
        Me.ApellidoLbl = New System.Windows.Forms.Label()
        Me.DNITxt = New System.Windows.Forms.TextBox()
        Me.TelefonoLbl = New System.Windows.Forms.Label()
        Me.EmailLbl = New System.Windows.Forms.Label()
        Me.TelefonoTxt = New System.Windows.Forms.TextBox()
        Me.EmailTxt = New System.Windows.Forms.TextBox()
        Me.AltaBtn = New System.Windows.Forms.Button()
        Me.BajaBtn = New System.Windows.Forms.Button()
        Me.ModificacionBtn = New System.Windows.Forms.Button()
        Me.ListaClientesLbl = New System.Windows.Forms.Label()
        Me.GrillaClientes = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.GrillaClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 594.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.20074!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.20074!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.22677!))
        Me.TableLayoutPanel1.Controls.Add(Me.ApellidoTxt, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.NombreTxt, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.DNILbl, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.NombreLbl, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ApellidoLbl, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.DNITxt, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TelefonoLbl, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.EmailLbl, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.TelefonoTxt, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.EmailTxt, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.AltaBtn, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.BajaBtn, 2, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.ModificacionBtn, 3, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.ListaClientesLbl, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GrillaClientes, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(863, 219)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'ApellidoTxt
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.ApellidoTxt, 2)
        Me.ApellidoTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ApellidoTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApellidoTxt.Location = New System.Drawing.Point(689, 93)
        Me.ApellidoTxt.Name = "ApellidoTxt"
        Me.ApellidoTxt.Size = New System.Drawing.Size(171, 23)
        Me.ApellidoTxt.TabIndex = 7
        '
        'NombreTxt
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.NombreTxt, 2)
        Me.NombreTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NombreTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreTxt.Location = New System.Drawing.Point(689, 63)
        Me.NombreTxt.Name = "NombreTxt"
        Me.NombreTxt.Size = New System.Drawing.Size(171, 23)
        Me.NombreTxt.TabIndex = 6
        '
        'DNILbl
        '
        Me.DNILbl.AutoSize = True
        Me.DNILbl.BackColor = System.Drawing.Color.Transparent
        Me.DNILbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DNILbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DNILbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.DNILbl.Location = New System.Drawing.Point(597, 30)
        Me.DNILbl.Name = "DNILbl"
        Me.DNILbl.Size = New System.Drawing.Size(86, 30)
        Me.DNILbl.TabIndex = 0
        Me.DNILbl.Text = "DNI"
        Me.DNILbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NombreLbl
        '
        Me.NombreLbl.AutoSize = True
        Me.NombreLbl.BackColor = System.Drawing.Color.Transparent
        Me.NombreLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NombreLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.NombreLbl.Location = New System.Drawing.Point(597, 60)
        Me.NombreLbl.Name = "NombreLbl"
        Me.NombreLbl.Size = New System.Drawing.Size(86, 30)
        Me.NombreLbl.TabIndex = 1
        Me.NombreLbl.Text = "Nombre"
        Me.NombreLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ApellidoLbl
        '
        Me.ApellidoLbl.AutoSize = True
        Me.ApellidoLbl.BackColor = System.Drawing.Color.Transparent
        Me.ApellidoLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ApellidoLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApellidoLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ApellidoLbl.Location = New System.Drawing.Point(597, 90)
        Me.ApellidoLbl.Name = "ApellidoLbl"
        Me.ApellidoLbl.Size = New System.Drawing.Size(86, 30)
        Me.ApellidoLbl.TabIndex = 2
        Me.ApellidoLbl.Text = "Apellido"
        Me.ApellidoLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DNITxt
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.DNITxt, 2)
        Me.DNITxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DNITxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DNITxt.Location = New System.Drawing.Point(689, 33)
        Me.DNITxt.Name = "DNITxt"
        Me.DNITxt.Size = New System.Drawing.Size(171, 23)
        Me.DNITxt.TabIndex = 3
        '
        'TelefonoLbl
        '
        Me.TelefonoLbl.AutoSize = True
        Me.TelefonoLbl.BackColor = System.Drawing.Color.Transparent
        Me.TelefonoLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TelefonoLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelefonoLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TelefonoLbl.Location = New System.Drawing.Point(597, 120)
        Me.TelefonoLbl.Name = "TelefonoLbl"
        Me.TelefonoLbl.Size = New System.Drawing.Size(86, 30)
        Me.TelefonoLbl.TabIndex = 4
        Me.TelefonoLbl.Text = "Telefono"
        Me.TelefonoLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EmailLbl
        '
        Me.EmailLbl.AutoSize = True
        Me.EmailLbl.BackColor = System.Drawing.Color.Transparent
        Me.EmailLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EmailLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.EmailLbl.Location = New System.Drawing.Point(597, 150)
        Me.EmailLbl.Name = "EmailLbl"
        Me.EmailLbl.Size = New System.Drawing.Size(86, 30)
        Me.EmailLbl.TabIndex = 5
        Me.EmailLbl.Text = "E-mail"
        Me.EmailLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TelefonoTxt
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.TelefonoTxt, 2)
        Me.TelefonoTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TelefonoTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelefonoTxt.Location = New System.Drawing.Point(689, 123)
        Me.TelefonoTxt.Name = "TelefonoTxt"
        Me.TelefonoTxt.Size = New System.Drawing.Size(171, 23)
        Me.TelefonoTxt.TabIndex = 8
        '
        'EmailTxt
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.EmailTxt, 2)
        Me.EmailTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EmailTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTxt.Location = New System.Drawing.Point(689, 153)
        Me.EmailTxt.Name = "EmailTxt"
        Me.EmailTxt.Size = New System.Drawing.Size(171, 23)
        Me.EmailTxt.TabIndex = 9
        '
        'AltaBtn
        '
        Me.AltaBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AltaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AltaBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AltaBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.AltaBtn.Location = New System.Drawing.Point(597, 183)
        Me.AltaBtn.Name = "AltaBtn"
        Me.AltaBtn.Size = New System.Drawing.Size(86, 33)
        Me.AltaBtn.TabIndex = 10
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
        Me.BajaBtn.Location = New System.Drawing.Point(689, 183)
        Me.BajaBtn.Name = "BajaBtn"
        Me.BajaBtn.Size = New System.Drawing.Size(86, 33)
        Me.BajaBtn.TabIndex = 11
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
        Me.ModificacionBtn.Location = New System.Drawing.Point(781, 183)
        Me.ModificacionBtn.Name = "ModificacionBtn"
        Me.ModificacionBtn.Size = New System.Drawing.Size(79, 33)
        Me.ModificacionBtn.TabIndex = 12
        Me.ModificacionBtn.Text = "Modificar"
        Me.ModificacionBtn.UseVisualStyleBackColor = True
        '
        'ListaClientesLbl
        '
        Me.ListaClientesLbl.AutoSize = True
        Me.ListaClientesLbl.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.SetColumnSpan(Me.ListaClientesLbl, 4)
        Me.ListaClientesLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListaClientesLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListaClientesLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ListaClientesLbl.Location = New System.Drawing.Point(3, 0)
        Me.ListaClientesLbl.Name = "ListaClientesLbl"
        Me.ListaClientesLbl.Size = New System.Drawing.Size(857, 30)
        Me.ListaClientesLbl.TabIndex = 13
        Me.ListaClientesLbl.Text = "Lista de Clientes"
        Me.ListaClientesLbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'GrillaClientes
        '
        Me.GrillaClientes.AllowUserToAddRows = False
        Me.GrillaClientes.AllowUserToDeleteRows = False
        Me.GrillaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrillaClientes.Location = New System.Drawing.Point(3, 33)
        Me.GrillaClientes.Name = "GrillaClientes"
        Me.GrillaClientes.ReadOnly = True
        Me.TableLayoutPanel1.SetRowSpan(Me.GrillaClientes, 6)
        Me.GrillaClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrillaClientes.Size = New System.Drawing.Size(588, 183)
        Me.GrillaClientes.TabIndex = 14
        '
        'ABMCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(863, 219)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(680, 247)
        Me.Name = "ABMCliente"
        Me.Text = "EvOrg"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.GrillaClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ApellidoTxt As TextBox
    Friend WithEvents NombreTxt As TextBox
    Friend WithEvents DNILbl As Label
    Friend WithEvents NombreLbl As Label
    Friend WithEvents ApellidoLbl As Label
    Friend WithEvents DNITxt As TextBox
    Friend WithEvents TelefonoLbl As Label
    Friend WithEvents EmailLbl As Label
    Friend WithEvents TelefonoTxt As TextBox
    Friend WithEvents EmailTxt As TextBox
    Friend WithEvents AltaBtn As Button
    Friend WithEvents BajaBtn As Button
    Friend WithEvents ModificacionBtn As Button
    Friend WithEvents ListaClientesLbl As Label
    Friend WithEvents GrillaClientes As DataGridView
End Class
