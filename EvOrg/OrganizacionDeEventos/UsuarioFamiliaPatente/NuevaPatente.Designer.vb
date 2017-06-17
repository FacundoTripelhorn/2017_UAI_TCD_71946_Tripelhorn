<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevaPatente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NuevaPatente))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.NombreLbl = New System.Windows.Forms.Label()
        Me.NombreTxt = New System.Windows.Forms.TextBox()
        Me.FormulariosLbl = New System.Windows.Forms.Label()
        Me.FormularioCombo = New System.Windows.Forms.ComboBox()
        Me.AceptarBtn = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.NombreLbl, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.NombreTxt, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FormulariosLbl, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.FormularioCombo, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.AceptarBtn, 0, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(228, 160)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'NombreLbl
        '
        Me.NombreLbl.AutoSize = True
        Me.NombreLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NombreLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.NombreLbl.Location = New System.Drawing.Point(3, 0)
        Me.NombreLbl.Name = "NombreLbl"
        Me.NombreLbl.Size = New System.Drawing.Size(222, 24)
        Me.NombreLbl.TabIndex = 4
        Me.NombreLbl.Tag = "Ingrese el nombre"
        Me.NombreLbl.Text = "Ingrese el nombre"
        Me.NombreLbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'NombreTxt
        '
        Me.NombreTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NombreTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreTxt.Location = New System.Drawing.Point(3, 27)
        Me.NombreTxt.Name = "NombreTxt"
        Me.NombreTxt.Size = New System.Drawing.Size(222, 23)
        Me.NombreTxt.TabIndex = 0
        '
        'FormulariosLbl
        '
        Me.FormulariosLbl.AutoSize = True
        Me.FormulariosLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormulariosLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormulariosLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormulariosLbl.Location = New System.Drawing.Point(3, 56)
        Me.FormulariosLbl.Name = "FormulariosLbl"
        Me.FormulariosLbl.Size = New System.Drawing.Size(222, 24)
        Me.FormulariosLbl.TabIndex = 5
        Me.FormulariosLbl.Tag = "Seleccione el formulario"
        Me.FormulariosLbl.Text = "Seleccione el formulario"
        Me.FormulariosLbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'FormularioCombo
        '
        Me.FormularioCombo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormularioCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FormularioCombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormularioCombo.FormattingEnabled = True
        Me.FormularioCombo.Location = New System.Drawing.Point(3, 83)
        Me.FormularioCombo.Name = "FormularioCombo"
        Me.FormularioCombo.Size = New System.Drawing.Size(222, 24)
        Me.FormularioCombo.TabIndex = 1
        '
        'AceptarBtn
        '
        Me.AceptarBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AceptarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AceptarBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AceptarBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.AceptarBtn.Location = New System.Drawing.Point(3, 112)
        Me.AceptarBtn.Name = "AceptarBtn"
        Me.AceptarBtn.Size = New System.Drawing.Size(222, 45)
        Me.AceptarBtn.TabIndex = 3
        Me.AceptarBtn.Text = "Aceptar"
        Me.AceptarBtn.UseVisualStyleBackColor = True
        '
        'NuevaPatente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(228, 160)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NuevaPatente"
        Me.Text = "EvOrg"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents NombreLbl As Label
    Friend WithEvents NombreTxt As TextBox
    Friend WithEvents FormulariosLbl As Label
    Friend WithEvents FormularioCombo As ComboBox
    Friend WithEvents AceptarBtn As Button
End Class
