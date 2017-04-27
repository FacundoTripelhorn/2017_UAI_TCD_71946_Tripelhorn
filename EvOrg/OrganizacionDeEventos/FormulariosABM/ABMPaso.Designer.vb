<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABMPaso
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
        Me.B = New System.Windows.Forms.Button()
        Me.BajaBtn = New System.Windows.Forms.Button()
        Me.ModificacionBtn = New System.Windows.Forms.Button()
        Me.TipoPasoLbl = New System.Windows.Forms.Label()
        Me.TipoPasoCombo = New System.Windows.Forms.ComboBox()
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
        Me.EventoCombo.Size = New System.Drawing.Size(809, 21)
        Me.EventoCombo.TabIndex = 0
        '
        'ElegirEventoLbl
        '
        Me.ElegirEventoLbl.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.ElegirEventoLbl, 2)
        Me.ElegirEventoLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ElegirEventoLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ElegirEventoLbl.Location = New System.Drawing.Point(3, 0)
        Me.ElegirEventoLbl.Name = "ElegirEventoLbl"
        Me.ElegirEventoLbl.Size = New System.Drawing.Size(188, 20)
        Me.ElegirEventoLbl.TabIndex = 1
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
        Me.GrillaPasos.Size = New System.Drawing.Size(543, 139)
        Me.GrillaPasos.TabIndex = 2
        '
        'DescripcionLbl
        '
        Me.DescripcionLbl.AutoSize = True
        Me.DescripcionLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DescripcionLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescripcionLbl.Location = New System.Drawing.Point(3, 223)
        Me.DescripcionLbl.Name = "DescripcionLbl"
        Me.DescripcionLbl.Size = New System.Drawing.Size(87, 30)
        Me.DescripcionLbl.TabIndex = 3
        Me.DescripcionLbl.Text = "Descripción"
        Me.DescripcionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DescripcionTxt
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.DescripcionTxt, 2)
        Me.DescripcionTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DescripcionTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescripcionTxt.Location = New System.Drawing.Point(96, 226)
        Me.DescripcionTxt.Name = "DescripcionTxt"
        Me.DescripcionTxt.Size = New System.Drawing.Size(196, 23)
        Me.DescripcionTxt.TabIndex = 4
        '
        'FechaLbl
        '
        Me.FechaLbl.AutoSize = True
        Me.FechaLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FechaLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaLbl.Location = New System.Drawing.Point(298, 223)
        Me.FechaLbl.Name = "FechaLbl"
        Me.FechaLbl.Size = New System.Drawing.Size(50, 30)
        Me.FechaLbl.TabIndex = 5
        Me.FechaLbl.Text = "Fecha"
        Me.FechaLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FechaDTP
        '
        Me.FechaDTP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FechaDTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaDTP.Location = New System.Drawing.Point(354, 226)
        Me.FechaDTP.Name = "FechaDTP"
        Me.FechaDTP.Size = New System.Drawing.Size(192, 23)
        Me.FechaDTP.TabIndex = 6
        '
        'PrioridadLbl
        '
        Me.PrioridadLbl.AutoSize = True
        Me.PrioridadLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrioridadLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrioridadLbl.Location = New System.Drawing.Point(552, 223)
        Me.PrioridadLbl.Name = "PrioridadLbl"
        Me.PrioridadLbl.Size = New System.Drawing.Size(68, 30)
        Me.PrioridadLbl.TabIndex = 8
        Me.PrioridadLbl.Text = "Prioridad"
        Me.PrioridadLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PrioridadCombo
        '
        Me.PrioridadCombo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrioridadCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PrioridadCombo.FormattingEnabled = True
        Me.PrioridadCombo.Location = New System.Drawing.Point(626, 226)
        Me.PrioridadCombo.Name = "PrioridadCombo"
        Me.PrioridadCombo.Size = New System.Drawing.Size(186, 21)
        Me.PrioridadCombo.TabIndex = 9
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 7
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 198.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 192.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ElegirEventoLbl, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.EventoCombo, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FechaDTP, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.GrillaPasos, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.FechaLbl, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.DescripcionLbl, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.DescripcionTxt, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.PrioridadLbl, 4, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.PrioridadCombo, 5, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Calendario, 5, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.TipoPasoLbl, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TipoPasoCombo, 2, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 145.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(815, 319)
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
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel1.SetColumnSpan(Me.TableLayoutPanel2, 7)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Controls.Add(Me.B, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BajaBtn, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ModificacionBtn, 2, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 256)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(809, 62)
        Me.TableLayoutPanel2.TabIndex = 11
        '
        'B
        '
        Me.B.Dock = System.Windows.Forms.DockStyle.Fill
        Me.B.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B.Location = New System.Drawing.Point(3, 3)
        Me.B.Name = "B"
        Me.B.Size = New System.Drawing.Size(263, 56)
        Me.B.TabIndex = 0
        Me.B.Text = "Agregar"
        Me.B.UseVisualStyleBackColor = True
        '
        'BajaBtn
        '
        Me.BajaBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BajaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BajaBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BajaBtn.Location = New System.Drawing.Point(272, 3)
        Me.BajaBtn.Name = "BajaBtn"
        Me.BajaBtn.Size = New System.Drawing.Size(263, 56)
        Me.BajaBtn.TabIndex = 1
        Me.BajaBtn.Text = "Borrar"
        Me.BajaBtn.UseVisualStyleBackColor = True
        '
        'ModificacionBtn
        '
        Me.ModificacionBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ModificacionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ModificacionBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModificacionBtn.Location = New System.Drawing.Point(541, 3)
        Me.ModificacionBtn.Name = "ModificacionBtn"
        Me.ModificacionBtn.Size = New System.Drawing.Size(265, 56)
        Me.ModificacionBtn.TabIndex = 2
        Me.ModificacionBtn.Text = "Modificar"
        Me.ModificacionBtn.UseVisualStyleBackColor = True
        '
        'TipoPasoLbl
        '
        Me.TipoPasoLbl.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.TipoPasoLbl, 2)
        Me.TipoPasoLbl.Dock = System.Windows.Forms.DockStyle.Left
        Me.TipoPasoLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipoPasoLbl.Location = New System.Drawing.Point(3, 194)
        Me.TipoPasoLbl.Name = "TipoPasoLbl"
        Me.TipoPasoLbl.Size = New System.Drawing.Size(170, 29)
        Me.TipoPasoLbl.TabIndex = 12
        Me.TipoPasoLbl.Text = "Seleccionar Tipo de Paso"
        Me.TipoPasoLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TipoPasoCombo
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.TipoPasoCombo, 3)
        Me.TipoPasoCombo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TipoPasoCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TipoPasoCombo.FormattingEnabled = True
        Me.TipoPasoCombo.Location = New System.Drawing.Point(197, 197)
        Me.TipoPasoCombo.Name = "TipoPasoCombo"
        Me.TipoPasoCombo.Size = New System.Drawing.Size(349, 21)
        Me.TipoPasoCombo.TabIndex = 13
        '
        'ABMPaso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 319)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MinimumSize = New System.Drawing.Size(731, 358)
        Me.Name = "ABMPaso"
        Me.Text = "ABMPaso"
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
    Friend WithEvents B As Button
    Friend WithEvents BajaBtn As Button
    Friend WithEvents ModificacionBtn As Button
    Friend WithEvents TipoPasoLbl As Label
    Friend WithEvents TipoPasoCombo As ComboBox
End Class
