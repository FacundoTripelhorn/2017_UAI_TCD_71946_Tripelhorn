<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListaMateriales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListaMateriales))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.MaterialesLbl = New System.Windows.Forms.Label()
        Me.FiltroDTP = New System.Windows.Forms.DateTimePicker()
        Me.GrillaMateriales = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.GrillaMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.BackgroundImage = CType(resources.GetObject("TableLayoutPanel1.BackgroundImage"), System.Drawing.Image)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.93548!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.06452!))
        Me.TableLayoutPanel1.Controls.Add(Me.MaterialesLbl, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.FiltroDTP, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GrillaMateriales, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.4!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.6!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(434, 250)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'MaterialesLbl
        '
        Me.MaterialesLbl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialesLbl.AutoSize = True
        Me.MaterialesLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaterialesLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.MaterialesLbl.Location = New System.Drawing.Point(3, 13)
        Me.MaterialesLbl.Name = "MaterialesLbl"
        Me.MaterialesLbl.Size = New System.Drawing.Size(175, 17)
        Me.MaterialesLbl.TabIndex = 0
        Me.MaterialesLbl.Tag = "Materiales"
        Me.MaterialesLbl.Text = "Materiales"
        '
        'FiltroDTP
        '
        Me.FiltroDTP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FiltroDTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FiltroDTP.Location = New System.Drawing.Point(184, 3)
        Me.FiltroDTP.Name = "FiltroDTP"
        Me.FiltroDTP.Size = New System.Drawing.Size(247, 23)
        Me.FiltroDTP.TabIndex = 1
        '
        'GrillaMateriales
        '
        Me.GrillaMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableLayoutPanel1.SetColumnSpan(Me.GrillaMateriales, 2)
        Me.GrillaMateriales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrillaMateriales.Location = New System.Drawing.Point(3, 33)
        Me.GrillaMateriales.Name = "GrillaMateriales"
        Me.GrillaMateriales.Size = New System.Drawing.Size(428, 214)
        Me.GrillaMateriales.TabIndex = 2
        '
        'ListaMateriales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 250)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ListaMateriales"
        Me.Text = "EvOrg"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.GrillaMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents MaterialesLbl As Label
    Friend WithEvents FiltroDTP As DateTimePicker
    Friend WithEvents GrillaMateriales As DataGridView
End Class
