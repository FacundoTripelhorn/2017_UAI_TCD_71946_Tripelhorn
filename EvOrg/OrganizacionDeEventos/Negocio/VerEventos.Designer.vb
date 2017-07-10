<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerEventos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VerEventos))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GrillaEventos = New System.Windows.Forms.DataGridView()
        Me.BorrarEventoBtn = New System.Windows.Forms.Button()
        Me.ModificarEventoBtn = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.GrillaEventos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GrillaEventos, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BorrarEventoBtn, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ModificarEventoBtn, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.6092!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.3908!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(442, 304)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'GrillaEventos
        '
        Me.GrillaEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableLayoutPanel1.SetColumnSpan(Me.GrillaEventos, 2)
        Me.GrillaEventos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrillaEventos.Location = New System.Drawing.Point(3, 3)
        Me.GrillaEventos.Name = "GrillaEventos"
        Me.GrillaEventos.Size = New System.Drawing.Size(436, 242)
        Me.GrillaEventos.TabIndex = 0
        '
        'BorrarEventoBtn
        '
        Me.BorrarEventoBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BorrarEventoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BorrarEventoBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorrarEventoBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BorrarEventoBtn.Location = New System.Drawing.Point(3, 251)
        Me.BorrarEventoBtn.Name = "BorrarEventoBtn"
        Me.BorrarEventoBtn.Size = New System.Drawing.Size(215, 50)
        Me.BorrarEventoBtn.TabIndex = 2
        Me.BorrarEventoBtn.Tag = "Borrar evento"
        Me.BorrarEventoBtn.Text = "Borrar evento"
        Me.BorrarEventoBtn.UseVisualStyleBackColor = True
        '
        'ModificarEventoBtn
        '
        Me.ModificarEventoBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ModificarEventoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ModificarEventoBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModificarEventoBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ModificarEventoBtn.Location = New System.Drawing.Point(224, 251)
        Me.ModificarEventoBtn.Name = "ModificarEventoBtn"
        Me.ModificarEventoBtn.Size = New System.Drawing.Size(215, 50)
        Me.ModificarEventoBtn.TabIndex = 3
        Me.ModificarEventoBtn.Tag = "Modificar evento"
        Me.ModificarEventoBtn.Text = "Modificar evento"
        Me.ModificarEventoBtn.UseVisualStyleBackColor = True
        '
        'VerEventos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(442, 304)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VerEventos"
        Me.Text = "EvOrg"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.GrillaEventos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BorrarEventoBtn As Button
    Friend WithEvents ModificarEventoBtn As Button
    Friend WithEvents GrillaEventos As DataGridView
End Class
