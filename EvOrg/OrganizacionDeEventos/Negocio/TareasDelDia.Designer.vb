<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TareasDelDia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TareasDelDia))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GrillaTareas = New System.Windows.Forms.DataGridView()
        Me.TareaNuevaBtn = New System.Windows.Forms.Button()
        Me.TareaTerminadaBtn = New System.Windows.Forms.Button()
        Me.TareasDelDiaLbl = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.GrillaTareas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GrillaTareas, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TareaNuevaBtn, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TareaTerminadaBtn, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TareasDelDiaLbl, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 182.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(472, 261)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'GrillaTareas
        '
        Me.GrillaTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableLayoutPanel1.SetColumnSpan(Me.GrillaTareas, 2)
        Me.GrillaTareas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrillaTareas.Location = New System.Drawing.Point(3, 33)
        Me.GrillaTareas.Name = "GrillaTareas"
        Me.GrillaTareas.Size = New System.Drawing.Size(466, 176)
        Me.GrillaTareas.TabIndex = 0
        '
        'TareaNuevaBtn
        '
        Me.TareaNuevaBtn.BackColor = System.Drawing.Color.Transparent
        Me.TareaNuevaBtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TareaNuevaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TareaNuevaBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TareaNuevaBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TareaNuevaBtn.Location = New System.Drawing.Point(3, 215)
        Me.TareaNuevaBtn.Name = "TareaNuevaBtn"
        Me.TareaNuevaBtn.Size = New System.Drawing.Size(230, 43)
        Me.TareaNuevaBtn.TabIndex = 1
        Me.TareaNuevaBtn.Tag = "Tarea nueva"
        Me.TareaNuevaBtn.Text = "Tarea nueva"
        Me.TareaNuevaBtn.UseVisualStyleBackColor = False
        '
        'TareaTerminadaBtn
        '
        Me.TareaTerminadaBtn.BackColor = System.Drawing.Color.Transparent
        Me.TareaTerminadaBtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TareaTerminadaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TareaTerminadaBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TareaTerminadaBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TareaTerminadaBtn.Location = New System.Drawing.Point(239, 215)
        Me.TareaTerminadaBtn.Name = "TareaTerminadaBtn"
        Me.TareaTerminadaBtn.Size = New System.Drawing.Size(230, 43)
        Me.TareaTerminadaBtn.TabIndex = 2
        Me.TareaTerminadaBtn.Tag = "Tarea terminada"
        Me.TareaTerminadaBtn.Text = "Tarea terminada"
        Me.TareaTerminadaBtn.UseVisualStyleBackColor = False
        '
        'TareasDelDiaLbl
        '
        Me.TareasDelDiaLbl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TareasDelDiaLbl.AutoSize = True
        Me.TareasDelDiaLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TareasDelDiaLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TareasDelDiaLbl.Location = New System.Drawing.Point(3, 13)
        Me.TareasDelDiaLbl.Name = "TareasDelDiaLbl"
        Me.TareasDelDiaLbl.Size = New System.Drawing.Size(230, 17)
        Me.TareasDelDiaLbl.TabIndex = 3
        Me.TareasDelDiaLbl.Tag = "Tareas del día"
        Me.TareasDelDiaLbl.Text = "Tareas del día"
        '
        'TareasDelDia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(472, 261)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TareasDelDia"
        Me.Text = "EvOrg"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.GrillaTareas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GrillaTareas As DataGridView
    Friend WithEvents TareaNuevaBtn As Button
    Friend WithEvents TareaTerminadaBtn As Button
    Friend WithEvents TareasDelDiaLbl As Label
End Class
