<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevoUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NuevoUsuario))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.NombreDeUsuarioLbl = New System.Windows.Forms.Label()
        Me.FamiliaLbl = New System.Windows.Forms.Label()
        Me.FamiliaCombo = New System.Windows.Forms.ComboBox()
        Me.IdUsuarioTxt = New System.Windows.Forms.TextBox()
        Me.EmailTxt = New System.Windows.Forms.TextBox()
        Me.ContraseñaTxt = New System.Windows.Forms.TextBox()
        Me.RContraseñaTxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ContraseñaLbl = New System.Windows.Forms.Label()
        Me.RepitaContraseñaLbl = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.AceptarBtn = New System.Windows.Forms.Button()
        Me.CancelarBtn = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.47727!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.52273!))
        Me.TableLayoutPanel1.Controls.Add(Me.NombreDeUsuarioLbl, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.FamiliaLbl, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.FamiliaCombo, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.IdUsuarioTxt, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.EmailTxt, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ContraseñaTxt, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.RContraseñaTxt, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ContraseñaLbl, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.RepitaContraseñaLbl, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 5)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(352, 184)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'NombreDeUsuarioLbl
        '
        Me.NombreDeUsuarioLbl.AutoSize = True
        Me.NombreDeUsuarioLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NombreDeUsuarioLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreDeUsuarioLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.NombreDeUsuarioLbl.Location = New System.Drawing.Point(3, 0)
        Me.NombreDeUsuarioLbl.Name = "NombreDeUsuarioLbl"
        Me.NombreDeUsuarioLbl.Size = New System.Drawing.Size(139, 27)
        Me.NombreDeUsuarioLbl.TabIndex = 7
        Me.NombreDeUsuarioLbl.Tag = "Nombre de usuario"
        Me.NombreDeUsuarioLbl.Text = "Nombre de usuario"
        Me.NombreDeUsuarioLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FamiliaLbl
        '
        Me.FamiliaLbl.AutoSize = True
        Me.FamiliaLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FamiliaLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FamiliaLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FamiliaLbl.Location = New System.Drawing.Point(3, 111)
        Me.FamiliaLbl.Name = "FamiliaLbl"
        Me.FamiliaLbl.Size = New System.Drawing.Size(139, 31)
        Me.FamiliaLbl.TabIndex = 11
        Me.FamiliaLbl.Tag = "Familia"
        Me.FamiliaLbl.Text = "Familia"
        Me.FamiliaLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FamiliaCombo
        '
        Me.FamiliaCombo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FamiliaCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FamiliaCombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FamiliaCombo.FormattingEnabled = True
        Me.FamiliaCombo.Location = New System.Drawing.Point(148, 114)
        Me.FamiliaCombo.Name = "FamiliaCombo"
        Me.FamiliaCombo.Size = New System.Drawing.Size(201, 24)
        Me.FamiliaCombo.TabIndex = 4
        '
        'IdUsuarioTxt
        '
        Me.IdUsuarioTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IdUsuarioTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdUsuarioTxt.Location = New System.Drawing.Point(148, 3)
        Me.IdUsuarioTxt.MaxLength = 18
        Me.IdUsuarioTxt.Name = "IdUsuarioTxt"
        Me.IdUsuarioTxt.Size = New System.Drawing.Size(201, 23)
        Me.IdUsuarioTxt.TabIndex = 0
        '
        'EmailTxt
        '
        Me.EmailTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EmailTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTxt.Location = New System.Drawing.Point(148, 30)
        Me.EmailTxt.Name = "EmailTxt"
        Me.EmailTxt.Size = New System.Drawing.Size(201, 23)
        Me.EmailTxt.TabIndex = 1
        '
        'ContraseñaTxt
        '
        Me.ContraseñaTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContraseñaTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContraseñaTxt.Location = New System.Drawing.Point(148, 57)
        Me.ContraseñaTxt.MaxLength = 16
        Me.ContraseñaTxt.Name = "ContraseñaTxt"
        Me.ContraseñaTxt.Size = New System.Drawing.Size(201, 23)
        Me.ContraseñaTxt.TabIndex = 2
        Me.ContraseñaTxt.UseSystemPasswordChar = True
        '
        'RContraseñaTxt
        '
        Me.RContraseñaTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RContraseñaTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RContraseñaTxt.Location = New System.Drawing.Point(148, 87)
        Me.RContraseñaTxt.MaxLength = 16
        Me.RContraseñaTxt.Name = "RContraseñaTxt"
        Me.RContraseñaTxt.Size = New System.Drawing.Size(201, 23)
        Me.RContraseñaTxt.TabIndex = 3
        Me.RContraseñaTxt.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(3, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 27)
        Me.Label4.TabIndex = 8
        Me.Label4.Tag = "Email"
        Me.Label4.Text = "Correo electrónico"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ContraseñaLbl
        '
        Me.ContraseñaLbl.AutoSize = True
        Me.ContraseñaLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContraseñaLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContraseñaLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ContraseñaLbl.Location = New System.Drawing.Point(3, 54)
        Me.ContraseñaLbl.Name = "ContraseñaLbl"
        Me.ContraseñaLbl.Size = New System.Drawing.Size(139, 30)
        Me.ContraseñaLbl.TabIndex = 9
        Me.ContraseñaLbl.Tag = "Contraseña"
        Me.ContraseñaLbl.Text = "Contraseña"
        Me.ContraseñaLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RepitaContraseñaLbl
        '
        Me.RepitaContraseñaLbl.AutoSize = True
        Me.RepitaContraseñaLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RepitaContraseñaLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RepitaContraseñaLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RepitaContraseñaLbl.Location = New System.Drawing.Point(3, 84)
        Me.RepitaContraseñaLbl.Name = "RepitaContraseñaLbl"
        Me.RepitaContraseñaLbl.Size = New System.Drawing.Size(139, 27)
        Me.RepitaContraseñaLbl.TabIndex = 10
        Me.RepitaContraseñaLbl.Tag = "Repita la contraseña"
        Me.RepitaContraseñaLbl.Text = "Repita la contraseña"
        Me.RepitaContraseñaLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel1.SetColumnSpan(Me.TableLayoutPanel2, 2)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.AceptarBtn, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.CancelarBtn, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 145)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(346, 36)
        Me.TableLayoutPanel2.TabIndex = 10
        '
        'AceptarBtn
        '
        Me.AceptarBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AceptarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AceptarBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AceptarBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.AceptarBtn.Location = New System.Drawing.Point(3, 3)
        Me.AceptarBtn.Name = "AceptarBtn"
        Me.AceptarBtn.Size = New System.Drawing.Size(167, 30)
        Me.AceptarBtn.TabIndex = 5
        Me.AceptarBtn.Tag = "Aceptar"
        Me.AceptarBtn.Text = "Aceptar"
        Me.AceptarBtn.UseVisualStyleBackColor = True
        '
        'CancelarBtn
        '
        Me.CancelarBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelarBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelarBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CancelarBtn.Location = New System.Drawing.Point(176, 3)
        Me.CancelarBtn.Name = "CancelarBtn"
        Me.CancelarBtn.Size = New System.Drawing.Size(167, 30)
        Me.CancelarBtn.TabIndex = 6
        Me.CancelarBtn.Tag = "Cancelar"
        Me.CancelarBtn.Text = "Cancelar"
        Me.CancelarBtn.UseVisualStyleBackColor = True
        '
        'NuevoUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(352, 184)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NuevoUsuario"
        Me.Text = "EvOrg"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents NombreDeUsuarioLbl As Label
    Friend WithEvents FamiliaLbl As Label
    Friend WithEvents FamiliaCombo As ComboBox
    Friend WithEvents IdUsuarioTxt As TextBox
    Friend WithEvents EmailTxt As TextBox
    Friend WithEvents ContraseñaTxt As TextBox
    Friend WithEvents RContraseñaTxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ContraseñaLbl As Label
    Friend WithEvents RepitaContraseñaLbl As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents AceptarBtn As Button
    Friend WithEvents CancelarBtn As Button
End Class
