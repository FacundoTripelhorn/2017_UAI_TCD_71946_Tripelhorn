﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ABMServicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ABMServicio))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ListaServiciosLbl = New System.Windows.Forms.Label()
        Me.GrillaServicios = New System.Windows.Forms.DataGridView()
        Me.EmailTxt = New System.Windows.Forms.TextBox()
        Me.EmailLbl = New System.Windows.Forms.Label()
        Me.NombreLbl = New System.Windows.Forms.Label()
        Me.NombreTxt = New System.Windows.Forms.TextBox()
        Me.TelefonoTxt = New System.Windows.Forms.TextBox()
        Me.TelefonoLbl = New System.Windows.Forms.Label()
        Me.ObservacionTxt = New System.Windows.Forms.TextBox()
        Me.ObservacionLbl = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.AltaBtn = New System.Windows.Forms.Button()
        Me.BajaBtn = New System.Windows.Forms.Button()
        Me.ModificacionBtn = New System.Windows.Forms.Button()
        Me.DireccionGrp = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.CalleLbl = New System.Windows.Forms.Label()
        Me.NumeroLbl = New System.Windows.Forms.Label()
        Me.CPLbl = New System.Windows.Forms.Label()
        Me.CalleTxt = New System.Windows.Forms.TextBox()
        Me.NumeroTxt = New System.Windows.Forms.TextBox()
        Me.CPTxt = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.GrillaServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.DireccionGrp.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ListaServiciosLbl, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GrillaServicios, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.EmailTxt, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.EmailLbl, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.NombreLbl, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.NombreTxt, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TelefonoTxt, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TelefonoLbl, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.ObservacionTxt, 4, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ObservacionLbl, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.DireccionGrp, 0, 5)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 183.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(627, 395)
        Me.TableLayoutPanel1.TabIndex = 15
        '
        'ListaServiciosLbl
        '
        Me.ListaServiciosLbl.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.ListaServiciosLbl, 6)
        Me.ListaServiciosLbl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ListaServiciosLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListaServiciosLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ListaServiciosLbl.Location = New System.Drawing.Point(3, 15)
        Me.ListaServiciosLbl.Name = "ListaServiciosLbl"
        Me.ListaServiciosLbl.Size = New System.Drawing.Size(621, 17)
        Me.ListaServiciosLbl.TabIndex = 1
        Me.ListaServiciosLbl.Text = "Lista de Servicios"
        '
        'GrillaServicios
        '
        Me.GrillaServicios.AllowUserToAddRows = False
        Me.GrillaServicios.AllowUserToDeleteRows = False
        Me.GrillaServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableLayoutPanel1.SetColumnSpan(Me.GrillaServicios, 4)
        Me.GrillaServicios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrillaServicios.Location = New System.Drawing.Point(3, 35)
        Me.GrillaServicios.Name = "GrillaServicios"
        Me.GrillaServicios.ReadOnly = True
        Me.TableLayoutPanel1.SetRowSpan(Me.GrillaServicios, 2)
        Me.GrillaServicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrillaServicios.Size = New System.Drawing.Size(345, 203)
        Me.GrillaServicios.TabIndex = 11
        '
        'EmailTxt
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.EmailTxt, 3)
        Me.EmailTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EmailTxt.Location = New System.Drawing.Point(76, 269)
        Me.EmailTxt.Name = "EmailTxt"
        Me.EmailTxt.Size = New System.Drawing.Size(272, 20)
        Me.EmailTxt.TabIndex = 3
        '
        'EmailLbl
        '
        Me.EmailLbl.AutoSize = True
        Me.EmailLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EmailLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.EmailLbl.Location = New System.Drawing.Point(3, 266)
        Me.EmailLbl.Name = "EmailLbl"
        Me.EmailLbl.Size = New System.Drawing.Size(67, 32)
        Me.EmailLbl.TabIndex = 7
        Me.EmailLbl.Text = "E-mail"
        Me.EmailLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NombreLbl
        '
        Me.NombreLbl.AutoSize = True
        Me.NombreLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NombreLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.NombreLbl.Location = New System.Drawing.Point(3, 241)
        Me.NombreLbl.Name = "NombreLbl"
        Me.NombreLbl.Size = New System.Drawing.Size(67, 25)
        Me.NombreLbl.TabIndex = 2
        Me.NombreLbl.Text = "Nombre"
        Me.NombreLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NombreTxt
        '
        Me.NombreTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NombreTxt.Location = New System.Drawing.Point(76, 244)
        Me.NombreTxt.Name = "NombreTxt"
        Me.NombreTxt.Size = New System.Drawing.Size(119, 20)
        Me.NombreTxt.TabIndex = 1
        '
        'TelefonoTxt
        '
        Me.TelefonoTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TelefonoTxt.Location = New System.Drawing.Point(276, 244)
        Me.TelefonoTxt.Name = "TelefonoTxt"
        Me.TelefonoTxt.Size = New System.Drawing.Size(72, 20)
        Me.TelefonoTxt.TabIndex = 2
        '
        'TelefonoLbl
        '
        Me.TelefonoLbl.AutoSize = True
        Me.TelefonoLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TelefonoLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelefonoLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TelefonoLbl.Location = New System.Drawing.Point(201, 241)
        Me.TelefonoLbl.Name = "TelefonoLbl"
        Me.TelefonoLbl.Size = New System.Drawing.Size(69, 25)
        Me.TelefonoLbl.TabIndex = 6
        Me.TelefonoLbl.Text = "Teléfono"
        Me.TelefonoLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ObservacionTxt
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.ObservacionTxt, 2)
        Me.ObservacionTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ObservacionTxt.Location = New System.Drawing.Point(354, 61)
        Me.ObservacionTxt.Multiline = True
        Me.ObservacionTxt.Name = "ObservacionTxt"
        Me.TableLayoutPanel1.SetRowSpan(Me.ObservacionTxt, 3)
        Me.ObservacionTxt.Size = New System.Drawing.Size(270, 234)
        Me.ObservacionTxt.TabIndex = 7
        '
        'ObservacionLbl
        '
        Me.ObservacionLbl.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.ObservacionLbl, 2)
        Me.ObservacionLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ObservacionLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ObservacionLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ObservacionLbl.Location = New System.Drawing.Point(354, 32)
        Me.ObservacionLbl.Name = "ObservacionLbl"
        Me.ObservacionLbl.Size = New System.Drawing.Size(270, 26)
        Me.ObservacionLbl.TabIndex = 5
        Me.ObservacionLbl.Text = "Observación"
        Me.ObservacionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel1.SetColumnSpan(Me.TableLayoutPanel2, 6)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Controls.Add(Me.AltaBtn, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BajaBtn, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ModificacionBtn, 2, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 357)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(621, 35)
        Me.TableLayoutPanel2.TabIndex = 20
        '
        'AltaBtn
        '
        Me.AltaBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AltaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AltaBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AltaBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.AltaBtn.Location = New System.Drawing.Point(3, 3)
        Me.AltaBtn.Name = "AltaBtn"
        Me.AltaBtn.Size = New System.Drawing.Size(201, 29)
        Me.AltaBtn.TabIndex = 8
        Me.AltaBtn.Text = "Agregar"
        Me.AltaBtn.UseVisualStyleBackColor = True
        '
        'BajaBtn
        '
        Me.BajaBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BajaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BajaBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BajaBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BajaBtn.Location = New System.Drawing.Point(210, 3)
        Me.BajaBtn.Name = "BajaBtn"
        Me.BajaBtn.Size = New System.Drawing.Size(201, 29)
        Me.BajaBtn.TabIndex = 9
        Me.BajaBtn.Text = "Borrar"
        Me.BajaBtn.UseVisualStyleBackColor = True
        '
        'ModificacionBtn
        '
        Me.ModificacionBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ModificacionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ModificacionBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModificacionBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ModificacionBtn.Location = New System.Drawing.Point(417, 3)
        Me.ModificacionBtn.Name = "ModificacionBtn"
        Me.ModificacionBtn.Size = New System.Drawing.Size(201, 29)
        Me.ModificacionBtn.TabIndex = 10
        Me.ModificacionBtn.Text = "Modificar"
        Me.ModificacionBtn.UseVisualStyleBackColor = True
        '
        'DireccionGrp
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.DireccionGrp, 6)
        Me.DireccionGrp.Controls.Add(Me.TableLayoutPanel3)
        Me.DireccionGrp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DireccionGrp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DireccionGrp.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.DireccionGrp.Location = New System.Drawing.Point(3, 301)
        Me.DireccionGrp.Name = "DireccionGrp"
        Me.DireccionGrp.Size = New System.Drawing.Size(621, 50)
        Me.DireccionGrp.TabIndex = 21
        Me.DireccionGrp.TabStop = False
        Me.DireccionGrp.Text = "Dirección"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 6
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 259.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 216.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.CalleLbl, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.NumeroLbl, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.CPLbl, 4, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.CalleTxt, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.NumeroTxt, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.CPTxt, 5, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 19)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(615, 28)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'CalleLbl
        '
        Me.CalleLbl.AutoSize = True
        Me.CalleLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CalleLbl.Location = New System.Drawing.Point(3, 0)
        Me.CalleLbl.Name = "CalleLbl"
        Me.CalleLbl.Size = New System.Drawing.Size(67, 28)
        Me.CalleLbl.TabIndex = 0
        Me.CalleLbl.Text = "Calle"
        Me.CalleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NumeroLbl
        '
        Me.NumeroLbl.AutoSize = True
        Me.NumeroLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NumeroLbl.Location = New System.Drawing.Point(335, 0)
        Me.NumeroLbl.Name = "NumeroLbl"
        Me.NumeroLbl.Size = New System.Drawing.Size(59, 28)
        Me.NumeroLbl.TabIndex = 1
        Me.NumeroLbl.Text = "Número"
        Me.NumeroLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CPLbl
        '
        Me.CPLbl.AutoSize = True
        Me.CPLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CPLbl.Location = New System.Drawing.Point(497, 0)
        Me.CPLbl.Name = "CPLbl"
        Me.CPLbl.Size = New System.Drawing.Size(42, 28)
        Me.CPLbl.TabIndex = 2
        Me.CPLbl.Text = "C. P."
        Me.CPLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CalleTxt
        '
        Me.CalleTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CalleTxt.Location = New System.Drawing.Point(76, 3)
        Me.CalleTxt.Name = "CalleTxt"
        Me.CalleTxt.Size = New System.Drawing.Size(253, 23)
        Me.CalleTxt.TabIndex = 4
        '
        'NumeroTxt
        '
        Me.NumeroTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NumeroTxt.Location = New System.Drawing.Point(400, 3)
        Me.NumeroTxt.Name = "NumeroTxt"
        Me.NumeroTxt.Size = New System.Drawing.Size(91, 23)
        Me.NumeroTxt.TabIndex = 5
        '
        'CPTxt
        '
        Me.CPTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CPTxt.Location = New System.Drawing.Point(545, 3)
        Me.CPTxt.Name = "CPTxt"
        Me.CPTxt.Size = New System.Drawing.Size(210, 23)
        Me.CPTxt.TabIndex = 6
        '
        'ABMServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(627, 395)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(16, 434)
        Me.Name = "ABMServicio"
        Me.Text = "EvOrg"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.GrillaServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.DireccionGrp.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ListaServiciosLbl As Label
    Friend WithEvents GrillaServicios As DataGridView
    Friend WithEvents EmailTxt As TextBox
    Friend WithEvents EmailLbl As Label
    Friend WithEvents NombreLbl As Label
    Friend WithEvents NombreTxt As TextBox
    Friend WithEvents TelefonoTxt As TextBox
    Friend WithEvents TelefonoLbl As Label
    Friend WithEvents ObservacionTxt As TextBox
    Friend WithEvents ObservacionLbl As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents AltaBtn As Button
    Friend WithEvents BajaBtn As Button
    Friend WithEvents ModificacionBtn As Button
    Friend WithEvents DireccionGrp As GroupBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents CalleLbl As Label
    Friend WithEvents NumeroLbl As Label
    Friend WithEvents CPLbl As Label
    Friend WithEvents CalleTxt As TextBox
    Friend WithEvents NumeroTxt As TextBox
    Friend WithEvents CPTxt As TextBox
End Class
