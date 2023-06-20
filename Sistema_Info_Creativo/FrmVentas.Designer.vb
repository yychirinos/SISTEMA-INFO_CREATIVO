<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVentas
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Txtimpuesto = New System.Windows.Forms.TextBox()
        Me.IMPUESTO = New System.Windows.Forms.Label()
        Me.btncalcular = New System.Windows.Forms.Button()
        Me.Txtcantidad = New System.Windows.Forms.TextBox()
        Me.Txtprecio = New System.Windows.Forms.TextBox()
        Me.Txtsuptotal = New System.Windows.Forms.TextBox()
        Me.Txtproducto = New System.Windows.Forms.TextBox()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.Txttotal = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.btnregresar = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.TOTAL = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SUPTOTAL = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(914, 65)
        Me.Panel1.TabIndex = 73
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(325, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(129, 31)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "VENTAS"
        '
        'Txtimpuesto
        '
        Me.Txtimpuesto.Location = New System.Drawing.Point(705, 167)
        Me.Txtimpuesto.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txtimpuesto.Name = "Txtimpuesto"
        Me.Txtimpuesto.Size = New System.Drawing.Size(116, 20)
        Me.Txtimpuesto.TabIndex = 72
        '
        'IMPUESTO
        '
        Me.IMPUESTO.AutoSize = True
        Me.IMPUESTO.BackColor = System.Drawing.Color.Transparent
        Me.IMPUESTO.Location = New System.Drawing.Point(711, 151)
        Me.IMPUESTO.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.IMPUESTO.Name = "IMPUESTO"
        Me.IMPUESTO.Size = New System.Drawing.Size(85, 13)
        Me.IMPUESTO.TabIndex = 71
        Me.IMPUESTO.Text = "IMPUESTO S/V"
        '
        'btncalcular
        '
        Me.btncalcular.BackColor = System.Drawing.SystemColors.Highlight
        Me.btncalcular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btncalcular.Location = New System.Drawing.Point(85, 410)
        Me.btncalcular.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(135, 35)
        Me.btncalcular.TabIndex = 70
        Me.btncalcular.Text = "CALCULAR"
        Me.btncalcular.UseVisualStyleBackColor = False
        '
        'Txtcantidad
        '
        Me.Txtcantidad.Location = New System.Drawing.Point(73, 221)
        Me.Txtcantidad.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txtcantidad.Name = "Txtcantidad"
        Me.Txtcantidad.Size = New System.Drawing.Size(147, 20)
        Me.Txtcantidad.TabIndex = 69
        '
        'Txtprecio
        '
        Me.Txtprecio.Location = New System.Drawing.Point(73, 272)
        Me.Txtprecio.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txtprecio.Name = "Txtprecio"
        Me.Txtprecio.Size = New System.Drawing.Size(147, 20)
        Me.Txtprecio.TabIndex = 68
        '
        'Txtsuptotal
        '
        Me.Txtsuptotal.Location = New System.Drawing.Point(705, 112)
        Me.Txtsuptotal.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txtsuptotal.Name = "Txtsuptotal"
        Me.Txtsuptotal.Size = New System.Drawing.Size(116, 20)
        Me.Txtsuptotal.TabIndex = 67
        '
        'Txtproducto
        '
        Me.Txtproducto.Location = New System.Drawing.Point(73, 160)
        Me.Txtproducto.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txtproducto.Name = "Txtproducto"
        Me.Txtproducto.Size = New System.Drawing.Size(147, 20)
        Me.Txtproducto.TabIndex = 66
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(73, 102)
        Me.txtcodigo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(147, 20)
        Me.txtcodigo.TabIndex = 65
        '
        'Txttotal
        '
        Me.Txttotal.Location = New System.Drawing.Point(705, 222)
        Me.Txttotal.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txttotal.Name = "Txttotal"
        Me.Txttotal.Size = New System.Drawing.Size(116, 20)
        Me.Txttotal.TabIndex = 64
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button6.Location = New System.Drawing.Point(288, 412)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(144, 35)
        Me.Button6.TabIndex = 63
        Me.Button6.Text = "NUEVO"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'btnregresar
        '
        Me.btnregresar.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnregresar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnregresar.Location = New System.Drawing.Point(502, 412)
        Me.btnregresar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnregresar.Name = "btnregresar"
        Me.btnregresar.Size = New System.Drawing.Size(144, 35)
        Me.btnregresar.TabIndex = 62
        Me.btnregresar.Text = "REGRESAR"
        Me.btnregresar.UseVisualStyleBackColor = False
        '
        'btnsalir
        '
        Me.btnsalir.BackColor = System.Drawing.Color.Red
        Me.btnsalir.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnsalir.Location = New System.Drawing.Point(502, 331)
        Me.btnsalir.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(145, 37)
        Me.btnsalir.TabIndex = 61
        Me.btnsalir.Text = "SALIR"
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'TOTAL
        '
        Me.TOTAL.AutoSize = True
        Me.TOTAL.BackColor = System.Drawing.Color.Transparent
        Me.TOTAL.Location = New System.Drawing.Point(711, 206)
        Me.TOTAL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TOTAL.Name = "TOTAL"
        Me.TOTAL.Size = New System.Drawing.Size(95, 13)
        Me.TOTAL.TabIndex = 60
        Me.TOTAL.Text = "TOTAL A PAGAR "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(70, 195)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Cantida"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(73, 256)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Precio"
        '
        'SUPTOTAL
        '
        Me.SUPTOTAL.AutoSize = True
        Me.SUPTOTAL.BackColor = System.Drawing.Color.Transparent
        Me.SUPTOTAL.Location = New System.Drawing.Point(721, 96)
        Me.SUPTOTAL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SUPTOTAL.Name = "SUPTOTAL"
        Me.SUPTOTAL.Size = New System.Drawing.Size(64, 13)
        Me.SUPTOTAL.TabIndex = 57
        Me.SUPTOTAL.Text = "SUPTOTAL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 86)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Codigo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(70, 144)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Producto"
        '
        'FrmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 487)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Txtimpuesto)
        Me.Controls.Add(Me.IMPUESTO)
        Me.Controls.Add(Me.btncalcular)
        Me.Controls.Add(Me.Txtcantidad)
        Me.Controls.Add(Me.Txtprecio)
        Me.Controls.Add(Me.Txtsuptotal)
        Me.Controls.Add(Me.Txtproducto)
        Me.Controls.Add(Me.txtcodigo)
        Me.Controls.Add(Me.Txttotal)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.btnregresar)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.TOTAL)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SUPTOTAL)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmVentas"
        Me.Text = "FrmVentas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Txtimpuesto As TextBox
    Friend WithEvents IMPUESTO As Label
    Friend WithEvents btncalcular As Button
    Friend WithEvents Txtcantidad As TextBox
    Friend WithEvents Txtprecio As TextBox
    Friend WithEvents Txtsuptotal As TextBox
    Friend WithEvents Txtproducto As TextBox
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents Txttotal As TextBox
    Friend WithEvents Button6 As Button
    Friend WithEvents btnregresar As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents TOTAL As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents SUPTOTAL As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
