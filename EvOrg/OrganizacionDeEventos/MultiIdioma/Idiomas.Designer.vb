<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Idiomas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Idiomas))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.IdiomaCombo = New System.Windows.Forms.ComboBox()
        Me.IdiomaLbl = New System.Windows.Forms.Label()
        Me.GrillaDiccionario = New System.Windows.Forms.DataGridView()
        Me.ClaveLbl = New System.Windows.Forms.Label()
        Me.ValorLbl = New System.Windows.Forms.Label()
        Me.ClaveTxt = New System.Windows.Forms.TextBox()
        Me.ValorTxt = New System.Windows.Forms.TextBox()
        Me.CambiarValorBtn = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.GuardarBtn = New System.Windows.Forms.Button()
        Me.CancelarBtn = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.GrillaDiccionario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.IdiomaCombo, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.IdiomaLbl, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GrillaDiccionario, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ClaveLbl, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ValorLbl, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ClaveTxt, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ValorTxt, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.CambiarValorBtn, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(579, 278)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'IdiomaCombo
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.IdiomaCombo, 2)
        Me.IdiomaCombo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IdiomaCombo.FormattingEnabled = True
        Me.IdiomaCombo.Location = New System.Drawing.Point(89, 3)
        Me.IdiomaCombo.Name = "IdiomaCombo"
        Me.IdiomaCombo.Size = New System.Drawing.Size(487, 24)
        Me.IdiomaCombo.TabIndex = 1
        '
        'IdiomaLbl
        '
        Me.IdiomaLbl.AutoSize = True
        Me.IdiomaLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IdiomaLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.IdiomaLbl.Location = New System.Drawing.Point(4, 0)
        Me.IdiomaLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.IdiomaLbl.Name = "IdiomaLbl"
        Me.IdiomaLbl.Size = New System.Drawing.Size(78, 28)
        Me.IdiomaLbl.TabIndex = 0
        Me.IdiomaLbl.Tag = "Idioma"
        Me.IdiomaLbl.Text = "Idioma"
        Me.IdiomaLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GrillaDiccionario
        '
        Me.GrillaDiccionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaDiccionario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrillaDiccionario.Location = New System.Drawing.Point(225, 31)
        Me.GrillaDiccionario.Name = "GrillaDiccionario"
        Me.TableLayoutPanel1.SetRowSpan(Me.GrillaDiccionario, 3)
        Me.GrillaDiccionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrillaDiccionario.Size = New System.Drawing.Size(351, 186)
        Me.GrillaDiccionario.TabIndex = 2
        '
        'ClaveLbl
        '
        Me.ClaveLbl.AutoSize = True
        Me.ClaveLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClaveLbl.Location = New System.Drawing.Point(3, 28)
        Me.ClaveLbl.Name = "ClaveLbl"
        Me.ClaveLbl.Size = New System.Drawing.Size(43, 17)
        Me.ClaveLbl.TabIndex = 3
        Me.ClaveLbl.Tag = "Clave"
        Me.ClaveLbl.Text = "Clave"
        '
        'ValorLbl
        '
        Me.ValorLbl.AutoSize = True
        Me.ValorLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ValorLbl.Location = New System.Drawing.Point(3, 58)
        Me.ValorLbl.Name = "ValorLbl"
        Me.ValorLbl.Size = New System.Drawing.Size(41, 17)
        Me.ValorLbl.TabIndex = 4
        Me.ValorLbl.Tag = "Valor"
        Me.ValorLbl.Text = "Valor"
        '
        'ClaveTxt
        '
        Me.ClaveTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ClaveTxt.Enabled = False
        Me.ClaveTxt.Location = New System.Drawing.Point(89, 31)
        Me.ClaveTxt.Name = "ClaveTxt"
        Me.ClaveTxt.Size = New System.Drawing.Size(130, 23)
        Me.ClaveTxt.TabIndex = 5
        '
        'ValorTxt
        '
        Me.ValorTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ValorTxt.Location = New System.Drawing.Point(89, 61)
        Me.ValorTxt.Multiline = True
        Me.ValorTxt.Name = "ValorTxt"
        Me.ValorTxt.Size = New System.Drawing.Size(130, 108)
        Me.ValorTxt.TabIndex = 6
        '
        'CambiarValorBtn
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.CambiarValorBtn, 2)
        Me.CambiarValorBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CambiarValorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CambiarValorBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CambiarValorBtn.Location = New System.Drawing.Point(3, 175)
        Me.CambiarValorBtn.Name = "CambiarValorBtn"
        Me.CambiarValorBtn.Size = New System.Drawing.Size(216, 42)
        Me.CambiarValorBtn.TabIndex = 7
        Me.CambiarValorBtn.Tag = "Cambiar valor"
        Me.CambiarValorBtn.Text = "Cambiar valor"
        Me.CambiarValorBtn.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel1.SetColumnSpan(Me.TableLayoutPanel2, 3)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.GuardarBtn, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.CancelarBtn, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 223)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(573, 52)
        Me.TableLayoutPanel2.TabIndex = 8
        '
        'GuardarBtn
        '
        Me.GuardarBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GuardarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GuardarBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GuardarBtn.Location = New System.Drawing.Point(3, 3)
        Me.GuardarBtn.Name = "GuardarBtn"
        Me.GuardarBtn.Size = New System.Drawing.Size(280, 46)
        Me.GuardarBtn.TabIndex = 0
        Me.GuardarBtn.Tag = "Guardar"
        Me.GuardarBtn.Text = "Guardar"
        Me.GuardarBtn.UseVisualStyleBackColor = True
        '
        'CancelarBtn
        '
        Me.CancelarBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CancelarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelarBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CancelarBtn.Location = New System.Drawing.Point(289, 3)
        Me.CancelarBtn.Name = "CancelarBtn"
        Me.CancelarBtn.Size = New System.Drawing.Size(281, 46)
        Me.CancelarBtn.TabIndex = 1
        Me.CancelarBtn.Tag = "Cancelar"
        Me.CancelarBtn.Text = "Cancelar"
        Me.CancelarBtn.UseVisualStyleBackColor = True
        '
        'Idiomas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(579, 278)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Idiomas"
        Me.Text = "EvOrg"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.GrillaDiccionario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents IdiomaCombo As ComboBox
    Friend WithEvents IdiomaLbl As Label
    Friend WithEvents GrillaDiccionario As DataGridView
    Friend WithEvents ClaveLbl As Label
    Friend WithEvents ValorLbl As Label
    Friend WithEvents ClaveTxt As TextBox
    Friend WithEvents ValorTxt As TextBox
    Friend WithEvents CambiarValorBtn As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents GuardarBtn As Button
    Friend WithEvents CancelarBtn As Button
End Class
