<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogIn
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.UsuarioLbl = New System.Windows.Forms.Label()
        Me.ContraseñaLbl = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.AceptarBtn = New System.Windows.Forms.Button()
        Me.CancelarBtn = New System.Windows.Forms.Button()
        Me.UsuarioTxt = New System.Windows.Forms.TextBox()
        Me.ContraseñaTxt = New System.Windows.Forms.TextBox()
        Me.ErrorLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.16064!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.83936!))
        Me.TableLayoutPanel1.Controls.Add(Me.UsuarioLbl, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ContraseñaLbl, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.UsuarioTxt, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ContraseñaTxt, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ErrorLinkLabel, 0, 3)
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
        Me.UsuarioLbl.Location = New System.Drawing.Point(3, 23)
        Me.UsuarioLbl.Name = "UsuarioLbl"
        Me.UsuarioLbl.Size = New System.Drawing.Size(112, 31)
        Me.UsuarioLbl.TabIndex = 0
        Me.UsuarioLbl.Text = "Usuario"
        Me.UsuarioLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ContraseñaLbl
        '
        Me.ContraseñaLbl.AutoSize = True
        Me.ContraseñaLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContraseñaLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContraseñaLbl.Location = New System.Drawing.Point(3, 54)
        Me.ContraseñaLbl.Name = "ContraseñaLbl"
        Me.ContraseñaLbl.Size = New System.Drawing.Size(112, 28)
        Me.ContraseñaLbl.TabIndex = 1
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
        Me.AceptarBtn.Location = New System.Drawing.Point(3, 3)
        Me.AceptarBtn.Name = "AceptarBtn"
        Me.AceptarBtn.Size = New System.Drawing.Size(138, 42)
        Me.AceptarBtn.TabIndex = 0
        Me.AceptarBtn.Text = "Aceptar"
        Me.AceptarBtn.UseVisualStyleBackColor = True
        '
        'CancelarBtn
        '
        Me.CancelarBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelarBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelarBtn.Location = New System.Drawing.Point(147, 3)
        Me.CancelarBtn.Name = "CancelarBtn"
        Me.CancelarBtn.Size = New System.Drawing.Size(138, 42)
        Me.CancelarBtn.TabIndex = 1
        Me.CancelarBtn.Text = "Cancelar"
        Me.CancelarBtn.UseVisualStyleBackColor = True
        '
        'UsuarioTxt
        '
        Me.UsuarioTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UsuarioTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsuarioTxt.Location = New System.Drawing.Point(121, 26)
        Me.UsuarioTxt.Name = "UsuarioTxt"
        Me.UsuarioTxt.Size = New System.Drawing.Size(170, 23)
        Me.UsuarioTxt.TabIndex = 3
        '
        'ContraseñaTxt
        '
        Me.ContraseñaTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContraseñaTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContraseñaTxt.Location = New System.Drawing.Point(121, 57)
        Me.ContraseñaTxt.Name = "ContraseñaTxt"
        Me.ContraseñaTxt.Size = New System.Drawing.Size(170, 23)
        Me.ContraseñaTxt.TabIndex = 4
        Me.ContraseñaTxt.UseSystemPasswordChar = True
        '
        'ErrorLinkLabel
        '
        Me.ErrorLinkLabel.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.ErrorLinkLabel, 2)
        Me.ErrorLinkLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ErrorLinkLabel.Location = New System.Drawing.Point(3, 82)
        Me.ErrorLinkLabel.Name = "ErrorLinkLabel"
        Me.ErrorLinkLabel.Size = New System.Drawing.Size(288, 19)
        Me.ErrorLinkLabel.TabIndex = 5
        Me.ErrorLinkLabel.TabStop = True
        Me.ErrorLinkLabel.Text = "Usuario o Contraseña incorrectos"
        Me.ErrorLinkLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.ErrorLinkLabel.Visible = False
        '
        'LogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 155)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "LogIn"
        Me.Text = "LogIn"
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
    Friend WithEvents ErrorLinkLabel As LinkLabel
End Class
