<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LogIn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LogIn))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.UsuarioLbl = New System.Windows.Forms.Label()
        Me.ContraseñaLbl = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.AceptarBtn = New System.Windows.Forms.Button()
        Me.CancelarBtn = New System.Windows.Forms.Button()
        Me.UsuarioTxt = New System.Windows.Forms.TextBox()
        Me.ContraseñaTxt = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.16064!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.83936!))
        Me.TableLayoutPanel1.Controls.Add(Me.UsuarioLbl, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ContraseñaLbl, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.UsuarioTxt, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ContraseñaTxt, 1, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(294, 155)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'UsuarioLbl
        '
        Me.UsuarioLbl.AutoSize = True
        Me.UsuarioLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UsuarioLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsuarioLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.UsuarioLbl.Location = New System.Drawing.Point(3, 23)
        Me.UsuarioLbl.Name = "UsuarioLbl"
        Me.UsuarioLbl.Size = New System.Drawing.Size(112, 31)
        Me.UsuarioLbl.TabIndex = 4
        Me.UsuarioLbl.Tag = "Usuario"
        Me.UsuarioLbl.Text = "Usuario"
        Me.UsuarioLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ContraseñaLbl
        '
        Me.ContraseñaLbl.AutoSize = True
        Me.ContraseñaLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContraseñaLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContraseñaLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ContraseñaLbl.Location = New System.Drawing.Point(3, 54)
        Me.ContraseñaLbl.Name = "ContraseñaLbl"
        Me.ContraseñaLbl.Size = New System.Drawing.Size(112, 28)
        Me.ContraseñaLbl.TabIndex = 5
        Me.ContraseñaLbl.Tag = "Contraseña"
        Me.ContraseñaLbl.Text = "Contraseña"
        Me.ContraseñaLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 104)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(288, 48)
        Me.TableLayoutPanel2.TabIndex = 2
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
        Me.AceptarBtn.Size = New System.Drawing.Size(138, 42)
        Me.AceptarBtn.TabIndex = 2
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
        Me.CancelarBtn.Location = New System.Drawing.Point(147, 3)
        Me.CancelarBtn.Name = "CancelarBtn"
        Me.CancelarBtn.Size = New System.Drawing.Size(138, 42)
        Me.CancelarBtn.TabIndex = 3
        Me.CancelarBtn.Tag = "Cancelar"
        Me.CancelarBtn.Text = "Cancelar"
        Me.CancelarBtn.UseVisualStyleBackColor = True
        '
        'UsuarioTxt
        '
        Me.UsuarioTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UsuarioTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsuarioTxt.Location = New System.Drawing.Point(121, 26)
        Me.UsuarioTxt.MaxLength = 18
        Me.UsuarioTxt.Name = "UsuarioTxt"
        Me.UsuarioTxt.Size = New System.Drawing.Size(170, 23)
        Me.UsuarioTxt.TabIndex = 0
        '
        'ContraseñaTxt
        '
        Me.ContraseñaTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContraseñaTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContraseñaTxt.Location = New System.Drawing.Point(121, 57)
        Me.ContraseñaTxt.MaxLength = 16
        Me.ContraseñaTxt.Name = "ContraseñaTxt"
        Me.ContraseñaTxt.Size = New System.Drawing.Size(170, 23)
        Me.ContraseñaTxt.TabIndex = 1
        Me.ContraseñaTxt.UseSystemPasswordChar = True
        '
        'LogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(294, 155)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LogIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EvOrg"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents UsuarioLbl As Label
    Friend WithEvents ContraseñaLbl As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents AceptarBtn As Button
    Friend WithEvents CancelarBtn As Button
    Friend WithEvents UsuarioTxt As TextBox
    Friend WithEvents ContraseñaTxt As TextBox
End Class
