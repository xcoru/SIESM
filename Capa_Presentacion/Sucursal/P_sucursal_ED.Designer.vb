﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class P_sucursal_ED
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_sucursal_ED))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnBuscar_imagen = New System.Windows.Forms.Button()
        Me.btnlimpiar_campos = New System.Windows.Forms.Button()
        Me.txtTipo = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtfecha = New System.Windows.Forms.TextBox()
        Me.Txtdescripcion = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtConsulta = New System.Windows.Forms.TextBox()
        Me.dgvTabla = New System.Windows.Forms.DataGridView()
        Me.txtid_sucursal = New System.Windows.Forms.TextBox()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnterminar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.ptrimagen = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptrimagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel1.Size = New System.Drawing.Size(738, 580)
        Me.Panel1.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel3.Controls.Add(Me.btnBuscar_imagen)
        Me.Panel3.Controls.Add(Me.btnlimpiar_campos)
        Me.Panel3.Controls.Add(Me.txtTipo)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Controls.Add(Me.txtfecha)
        Me.Panel3.Controls.Add(Me.Txtdescripcion)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.txtConsulta)
        Me.Panel3.Controls.Add(Me.dgvTabla)
        Me.Panel3.Controls.Add(Me.txtid_sucursal)
        Me.Panel3.Controls.Add(Me.btnSiguiente)
        Me.Panel3.Controls.Add(Me.btnAtras)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.txttelefono)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.btnterminar)
        Me.Panel3.Controls.Add(Me.btnGuardar)
        Me.Panel3.Controls.Add(Me.ptrimagen)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.txtdireccion)
        Me.Panel3.Controls.Add(Me.txtNombre)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(5, 54)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(728, 521)
        Me.Panel3.TabIndex = 18
        '
        'btnBuscar_imagen
        '
        Me.btnBuscar_imagen.Enabled = False
        Me.btnBuscar_imagen.Location = New System.Drawing.Point(464, 385)
        Me.btnBuscar_imagen.Name = "btnBuscar_imagen"
        Me.btnBuscar_imagen.Size = New System.Drawing.Size(253, 30)
        Me.btnBuscar_imagen.TabIndex = 89
        Me.btnBuscar_imagen.Text = "Buscar imágen"
        Me.btnBuscar_imagen.UseVisualStyleBackColor = True
        '
        'btnlimpiar_campos
        '
        Me.btnlimpiar_campos.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnlimpiar_campos.Enabled = False
        Me.btnlimpiar_campos.Location = New System.Drawing.Point(335, 434)
        Me.btnlimpiar_campos.Name = "btnlimpiar_campos"
        Me.btnlimpiar_campos.Size = New System.Drawing.Size(162, 30)
        Me.btnlimpiar_campos.TabIndex = 88
        Me.btnlimpiar_campos.Text = "Limpiar campos"
        Me.btnlimpiar_campos.UseVisualStyleBackColor = True
        '
        'txtTipo
        '
        Me.txtTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtTipo.Enabled = False
        Me.txtTipo.FormattingEnabled = True
        Me.txtTipo.Items.AddRange(New Object() {"Sucursal", "Bodega"})
        Me.txtTipo.Location = New System.Drawing.Point(169, 398)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(125, 26)
        Me.txtTipo.TabIndex = 87
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(30, 401)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 18)
        Me.Label9.TabIndex = 86
        Me.Label9.Text = "Tipo:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 475)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(728, 46)
        Me.Panel2.TabIndex = 85
        '
        'txtfecha
        '
        Me.txtfecha.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtfecha.Enabled = False
        Me.txtfecha.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfecha.Location = New System.Drawing.Point(173, 435)
        Me.txtfecha.MaxLength = 20
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(121, 26)
        Me.txtfecha.TabIndex = 84
        Me.txtfecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txtdescripcion
        '
        Me.Txtdescripcion.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Txtdescripcion.Enabled = False
        Me.Txtdescripcion.Location = New System.Drawing.Point(173, 312)
        Me.Txtdescripcion.MaxLength = 300
        Me.Txtdescripcion.Multiline = True
        Me.Txtdescripcion.Name = "Txtdescripcion"
        Me.Txtdescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Txtdescripcion.Size = New System.Drawing.Size(269, 47)
        Me.Txtdescripcion.TabIndex = 83
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Location = New System.Drawing.Point(28, 163)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(691, 10)
        Me.Label10.TabIndex = 82
        '
        'txtConsulta
        '
        Me.txtConsulta.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConsulta.ForeColor = System.Drawing.Color.Green
        Me.txtConsulta.Location = New System.Drawing.Point(277, 6)
        Me.txtConsulta.Name = "txtConsulta"
        Me.txtConsulta.Size = New System.Drawing.Size(174, 26)
        Me.txtConsulta.TabIndex = 81
        Me.txtConsulta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgvTabla
        '
        Me.dgvTabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvTabla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvTabla.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvTabla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTabla.Location = New System.Drawing.Point(28, 35)
        Me.dgvTabla.MultiSelect = False
        Me.dgvTabla.Name = "dgvTabla"
        Me.dgvTabla.ReadOnly = True
        Me.dgvTabla.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvTabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTabla.Size = New System.Drawing.Size(691, 113)
        Me.dgvTabla.TabIndex = 80
        '
        'txtid_sucursal
        '
        Me.txtid_sucursal.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtid_sucursal.Enabled = False
        Me.txtid_sucursal.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid_sucursal.Location = New System.Drawing.Point(173, 189)
        Me.txtid_sucursal.MaxLength = 20
        Me.txtid_sucursal.Name = "txtid_sucursal"
        Me.txtid_sucursal.Size = New System.Drawing.Size(204, 26)
        Me.txtid_sucursal.TabIndex = 78
        Me.txtid_sucursal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Image = Global.Capa_Presentacion.My.Resources.Resources.Forward
        Me.btnSiguiente.Location = New System.Drawing.Point(400, 373)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(42, 36)
        Me.btnSiguiente.TabIndex = 59
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnAtras
        '
        Me.btnAtras.Image = Global.Capa_Presentacion.My.Resources.Resources.Back2
        Me.btnAtras.Location = New System.Drawing.Point(338, 373)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(42, 36)
        Me.btnAtras.TabIndex = 58
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(30, 438)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 18)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Fecha:"
        '
        'txttelefono
        '
        Me.txttelefono.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txttelefono.Enabled = False
        Me.txttelefono.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttelefono.Location = New System.Drawing.Point(173, 365)
        Me.txttelefono.MaxLength = 12
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(121, 26)
        Me.txttelefono.TabIndex = 52
        Me.txttelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(30, 368)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 18)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Teléfono:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 320)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 18)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Descripción:"
        '
        'btnterminar
        '
        Me.btnterminar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnterminar.Location = New System.Drawing.Point(614, 434)
        Me.btnterminar.Name = "btnterminar"
        Me.btnterminar.Size = New System.Drawing.Size(105, 30)
        Me.btnterminar.TabIndex = 46
        Me.btnterminar.Text = "Terminar"
        Me.btnterminar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Location = New System.Drawing.Point(503, 434)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(105, 30)
        Me.btnGuardar.TabIndex = 45
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'ptrimagen
        '
        Me.ptrimagen.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ptrimagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ptrimagen.Location = New System.Drawing.Point(463, 209)
        Me.ptrimagen.Name = "ptrimagen"
        Me.ptrimagen.Size = New System.Drawing.Size(256, 170)
        Me.ptrimagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptrimagen.TabIndex = 44
        Me.ptrimagen.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(525, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 18)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Imágen De Sucursal:"
        '
        'txtdireccion
        '
        Me.txtdireccion.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtdireccion.Enabled = False
        Me.txtdireccion.Location = New System.Drawing.Point(173, 259)
        Me.txtdireccion.MaxLength = 500
        Me.txtdireccion.Multiline = True
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtdireccion.Size = New System.Drawing.Size(269, 47)
        Me.txtdireccion.TabIndex = 42
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(173, 222)
        Me.txtNombre.MaxLength = 100
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtNombre.Size = New System.Drawing.Size(269, 26)
        Me.txtNombre.TabIndex = 41
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 225)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Nombre :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 262)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 18)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Dirección:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 191)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 18)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "ID:"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(5, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(728, 49)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Editar Sucursal"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label6.UseCompatibleTextRendering = True
        '
        'P_sucursal_ED
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(738, 580)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "P_sucursal_ED"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sucursal editar"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgvTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptrimagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtfecha As System.Windows.Forms.TextBox
    Friend WithEvents Txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtConsulta As System.Windows.Forms.TextBox
    Friend WithEvents dgvTabla As System.Windows.Forms.DataGridView
    Friend WithEvents txtid_sucursal As System.Windows.Forms.TextBox
    Friend WithEvents btnSiguiente As System.Windows.Forms.Button
    Friend WithEvents btnAtras As System.Windows.Forms.Button
    Friend WithEvents txttelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnterminar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents ptrimagen As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtdireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTipo As System.Windows.Forms.ComboBox
    Friend WithEvents btnlimpiar_campos As System.Windows.Forms.Button
    Friend WithEvents btnBuscar_imagen As System.Windows.Forms.Button
End Class
