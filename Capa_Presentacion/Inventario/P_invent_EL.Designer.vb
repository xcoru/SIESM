﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class P_invent_EL
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_invent_EL))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Txtcondicion = New System.Windows.Forms.TextBox()
        Me.Txtcantidad = New System.Windows.Forms.TextBox()
        Me.Txtproveedor = New System.Windows.Forms.TextBox()
        Me.Txtsucursal = New System.Windows.Forms.TextBox()
        Me.Txtfecha = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txtarticulo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(413, 49)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Eliminar Producto en Inventario"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel3.Controls.Add(Me.Txtcondicion)
        Me.Panel3.Controls.Add(Me.Txtcantidad)
        Me.Panel3.Controls.Add(Me.Txtproveedor)
        Me.Panel3.Controls.Add(Me.Txtsucursal)
        Me.Panel3.Controls.Add(Me.Txtfecha)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Txtarticulo)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 49)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(413, 300)
        Me.Panel3.TabIndex = 19
        '
        'Txtcondicion
        '
        Me.Txtcondicion.Location = New System.Drawing.Point(194, 199)
        Me.Txtcondicion.Name = "Txtcondicion"
        Me.Txtcondicion.Size = New System.Drawing.Size(141, 26)
        Me.Txtcondicion.TabIndex = 45
        '
        'Txtcantidad
        '
        Me.Txtcantidad.Location = New System.Drawing.Point(194, 158)
        Me.Txtcantidad.Name = "Txtcantidad"
        Me.Txtcantidad.Size = New System.Drawing.Size(141, 26)
        Me.Txtcantidad.TabIndex = 44
        '
        'Txtproveedor
        '
        Me.Txtproveedor.Location = New System.Drawing.Point(194, 117)
        Me.Txtproveedor.Name = "Txtproveedor"
        Me.Txtproveedor.Size = New System.Drawing.Size(141, 26)
        Me.Txtproveedor.TabIndex = 43
        '
        'Txtsucursal
        '
        Me.Txtsucursal.Location = New System.Drawing.Point(194, 76)
        Me.Txtsucursal.Name = "Txtsucursal"
        Me.Txtsucursal.Size = New System.Drawing.Size(141, 26)
        Me.Txtsucursal.TabIndex = 42
        '
        'Txtfecha
        '
        Me.Txtfecha.Location = New System.Drawing.Point(194, 237)
        Me.Txtfecha.Name = "Txtfecha"
        Me.Txtfecha.Size = New System.Drawing.Size(141, 26)
        Me.Txtfecha.TabIndex = 41
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(93, 245)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 18)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Fecha:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(93, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 18)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Condición:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(93, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 18)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Cantidad:"
        '
        'Txtarticulo
        '
        Me.Txtarticulo.Location = New System.Drawing.Point(194, 32)
        Me.Txtarticulo.Name = "Txtarticulo"
        Me.Txtarticulo.Size = New System.Drawing.Size(141, 26)
        Me.Txtarticulo.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(93, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 18)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Artículo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(93, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 18)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Proveedor:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(93, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 18)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Sucursal:"
        '
        'P_invent_EL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 349)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label6)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "P_invent_EL"
        Me.Text = "Eliminar Inventario"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Txtarticulo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Txtcondicion As System.Windows.Forms.TextBox
    Friend WithEvents Txtcantidad As System.Windows.Forms.TextBox
    Friend WithEvents Txtproveedor As System.Windows.Forms.TextBox
    Friend WithEvents Txtsucursal As System.Windows.Forms.TextBox
    Friend WithEvents Txtfecha As System.Windows.Forms.TextBox
End Class
