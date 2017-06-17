<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ABMPaso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ABMPaso))
        Me.EventoCombo = New System.Windows.Forms.ComboBox()
        Me.ElegirEventoLbl = New System.Windows.Forms.Label()
        Me.GrillaPasos = New System.Windows.Forms.DataGridView()
        Me.DescripcionLbl = New System.Windows.Forms.Label()
        Me.DescripcionTxt = New System.Windows.Forms.TextBox()
        Me.FechaLbl = New System.Windows.Forms.Label()
        Me.FechaDTP = New System.Windows.Forms.DateTimePicker()
        Me.PrioridadLbl = New System.Windows.Forms.Label()
        Me.PrioridadCombo = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Calendario = New System.Windows.Forms.MonthCalendar()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.AltaBtn = New System.Windows.Forms.Button()
        Me.BajaBtn = New System.Windows.Forms.Button()
        Me.ModificacionBtn = New System.Windows.Forms.Button()
        CType(Me.GrillaPasos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'EventoCombo
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.EventoCombo, 7)
        Me.EventoCombo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EventoCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EventoCombo.FormattingEnabled = True
        Me.EventoCombo.Location = New System.Drawing.Point(3, 23)
        Me.EventoCombo.MinimumSize = New System.Drawing.Size(709, 0)
        Me.EventoCombo.Name = "EventoCombo"
        Me.EventoCombo.Size = New System.Drawing.Size(810, 21)
        Me.EventoCombo.TabIndex = 0
        '
        'ElegirEventoLbl
        '
        Me.ElegirEventoLbl.AutoSize = True
        Me.ElegirEventoLbl.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.SetColumnSpan(Me.ElegirEventoLbl, 2)
        Me.ElegirEventoLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ElegirEventoLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ElegirEventoLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ElegirEventoLbl.Location = New System.Drawing.Point(3, 0)
        Me.ElegirEventoLbl.Name = "ElegirEventoLbl"
        Me.ElegirEventoLbl.Size = New System.Drawing.Size(188, 20)
        Me.ElegirEventoLbl.TabIndex = 1
        Me.ElegirEventoLbl.Tag = "Elegir evento"
        Me.ElegirEventoLbl.Text = "Elegir evento"
        '
        'GrillaPasos
        '
        Me.GrillaPasos.AllowUserToAddRows = False
        Me.GrillaPasos.AllowUserToDeleteRows = False
        Me.GrillaPasos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableLayoutPanel1.SetColumnSpan(Me.GrillaPasos, 5)
        Me.GrillaPasos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrillaPasos.Location = New System.Drawing.Point(3, 52)
        Me.GrillaPasos.Name = "GrillaPasos"
        Me.GrillaPasos.ReadOnly = True
        Me.GrillaPasos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrillaPasos.Size = New System.Drawing.Size(543, 170)
        Me.GrillaPasos.TabIndex = 2
        '
        'DescripcionLbl
        '
        Me.DescripcionLbl.AutoSize = True
        Me.DescripcionLbl.BackColor = System.Drawing.Color.Transparent
        Me.DescripcionLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DescripcionLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescripcionLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.DescripcionLbl.Location = New System.Drawing.Point(3, 225)
        Me.DescripcionLbl.Name = "DescripcionLbl"
        Me.DescripcionLbl.Size = New System.Drawing.Size(87, 24)
        Me.DescripcionLbl.TabIndex = 3
        Me.DescripcionLbl.Tag = "Descripcion"
        Me.DescripcionLbl.Text = "Descripción"
        Me.DescripcionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DescripcionTxt
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.DescripcionTxt, 2)
        Me.DescripcionTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DescripcionTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescripcionTxt.Location = New System.Drawing.Point(96, 228)
        Me.DescripcionTxt.Name = "DescripcionTxt"
        Me.DescripcionTxt.Size = New System.Drawing.Size(196, 23)
        Me.DescripcionTxt.TabIndex = 4
        '
        'FechaLbl
        '
        Me.FechaLbl.AutoSize = True
        Me.FechaLbl.BackColor = System.Drawing.Color.Transparent
        Me.FechaLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FechaLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FechaLbl.Location = New System.Drawing.Point(298, 225)
        Me.FechaLbl.Name = "FechaLbl"
        Me.FechaLbl.Size = New System.Drawing.Size(50, 24)
        Me.FechaLbl.TabIndex = 5
        Me.FechaLbl.Tag = "Fecha"
        Me.FechaLbl.Text = "Fecha"
        Me.FechaLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FechaDTP
        '
        Me.FechaDTP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FechaDTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaDTP.Location = New System.Drawing.Point(354, 228)
        Me.FechaDTP.Name = "FechaDTP"
        Me.FechaDTP.Size = New System.Drawing.Size(192, 23)
        Me.FechaDTP.TabIndex = 6
        '
        'PrioridadLbl
        '
        Me.PrioridadLbl.AutoSize = True
        Me.PrioridadLbl.BackColor = System.Drawing.Color.Transparent
        Me.PrioridadLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrioridadLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrioridadLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.PrioridadLbl.Location = New System.Drawing.Point(552, 225)
        Me.PrioridadLbl.Name = "PrioridadLbl"
        Me.PrioridadLbl.Size = New System.Drawing.Size(68, 24)
        Me.PrioridadLbl.TabIndex = 8
        Me.PrioridadLbl.Tag = "Prioridad"
        Me.PrioridadLbl.Text = "Prioridad"
        Me.PrioridadLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PrioridadCombo
        '
        Me.PrioridadCombo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrioridadCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PrioridadCombo.FormattingEnabled = True
        Me.PrioridadCombo.Location = New System.Drawing.Point(626, 228)
        Me.PrioridadCombo.Name = "PrioridadCombo"
        Me.PrioridadCombo.Size = New System.Drawing.Size(187, 21)
        Me.PrioridadCombo.TabIndex = 9
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 7
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 198.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 193.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ElegirEventoLbl, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.EventoCombo, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FechaDTP, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.GrillaPasos, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.FechaLbl, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.DescripcionLbl, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.DescripcionTxt, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.PrioridadLbl, 4, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.PrioridadCombo, 5, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Calendario, 5, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 176.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(816, 319)
        Me.TableLayoutPanel1.TabIndex = 10
        '
        'Calendario
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.Calendario, 2)
        Me.Calendario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Calendario.Location = New System.Drawing.Point(558, 58)
        Me.Calendario.Name = "Calendario"
        Me.Calendario.TabIndex = 10
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel1.SetColumnSpan(Me.TableLayoutPanel2, 7)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Controls.Add(Me.AltaBtn, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BajaBtn, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ModificacionBtn, 2, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 252)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(810, 64)
        Me.TableLayoutPanel2.TabIndex = 11
        '
        'AltaBtn
        '
        Me.AltaBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AltaBtn.BackColor = System.Drawing.Color.Transparent
        Me.AltaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AltaBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AltaBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.AltaBtn.Location = New System.Drawing.Point(3, 5)
        Me.AltaBtn.Name = "AltaBtn"
        Me.AltaBtn.Size = New System.Drawing.Size(264, 56)
        Me.AltaBtn.TabIndex = 0
        Me.AltaBtn.Tag = "Agregar"
        Me.AltaBtn.Text = "Agregar"
        Me.AltaBtn.UseVisualStyleBackColor = False
        '
        'BajaBtn
        '
        Me.BajaBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BajaBtn.BackColor = System.Drawing.Color.Transparent
        Me.BajaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BajaBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BajaBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BajaBtn.Location = New System.Drawing.Point(273, 5)
        Me.BajaBtn.Name = "BajaBtn"
        Me.BajaBtn.Size = New System.Drawing.Size(264, 56)
        Me.BajaBtn.TabIndex = 1
        Me.BajaBtn.Tag = "Borrar"
        Me.BajaBtn.Text = "Borrar"
        Me.BajaBtn.UseVisualStyleBackColor = False
        '
        'ModificacionBtn
        '
        Me.ModificacionBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ModificacionBtn.BackColor = System.Drawing.Color.Transparent
        Me.ModificacionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ModificacionBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModificacionBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ModificacionBtn.Location = New System.Drawing.Point(543, 5)
        Me.ModificacionBtn.Name = "ModificacionBtn"
        Me.ModificacionBtn.Size = New System.Drawing.Size(264, 56)
        Me.ModificacionBtn.TabIndex = 2
        Me.ModificacionBtn.Tag = "Modificar"
        Me.ModificacionBtn.Text = "Modificar"
        Me.ModificacionBtn.UseVisualStyleBackColor = False
        '
        'ABMPaso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(816, 319)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(832, 358)
        Me.Name = "ABMPaso"
        Me.Text = "EvOrg"
        CType(Me.GrillaPasos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents EventoCombo As ComboBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ElegirEventoLbl As Label
    Friend WithEvents FechaDTP As DateTimePicker
    Friend WithEvents GrillaPasos As DataGridView
    Friend WithEvents FechaLbl As Label
    Friend WithEvents DescripcionLbl As Label
    Friend WithEvents DescripcionTxt As TextBox
    Friend WithEvents PrioridadLbl As Label
    Friend WithEvents PrioridadCombo As ComboBox
    Friend WithEvents Calendario As MonthCalendar
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents AltaBtn As Button
    Friend WithEvents BajaBtn As Button
    Friend WithEvents ModificacionBtn As Button
End Class
