<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmFacturaVentas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtnumfactura = New System.Windows.Forms.TextBox()
        Me.txtidcliente = New System.Windows.Forms.TextBox()
        Me.txtdescuento = New System.Windows.Forms.TextBox()
        Me.Cmbagregar = New System.Windows.Forms.GroupBox()
        Me.txtidusuario = New System.Windows.Forms.TextBox()
        Me.cmbproducto = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtfecha = New System.Windows.Forms.DateTimePicker()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtbuscarpro = New System.Windows.Forms.TextBox()
        Me.dgvFactura = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.Cmbagregar.SuspendLayout()
        CType(Me.dgvFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Num Factura"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 121)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "IdCliente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 207)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 108)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Descuento"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 166)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "IdUsuario"
        '
        'txtnumfactura
        '
        Me.txtnumfactura.Location = New System.Drawing.Point(121, 34)
        Me.txtnumfactura.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnumfactura.Name = "txtnumfactura"
        Me.txtnumfactura.Size = New System.Drawing.Size(132, 22)
        Me.txtnumfactura.TabIndex = 8
        '
        'txtidcliente
        '
        Me.txtidcliente.Location = New System.Drawing.Point(121, 116)
        Me.txtidcliente.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidcliente.Name = "txtidcliente"
        Me.txtidcliente.Size = New System.Drawing.Size(132, 22)
        Me.txtidcliente.TabIndex = 9
        '
        'txtdescuento
        '
        Me.txtdescuento.Location = New System.Drawing.Point(137, 100)
        Me.txtdescuento.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdescuento.Name = "txtdescuento"
        Me.txtdescuento.Size = New System.Drawing.Size(132, 22)
        Me.txtdescuento.TabIndex = 12
        '
        'Cmbagregar
        '
        Me.Cmbagregar.Controls.Add(Me.btnbuscar)
        Me.Cmbagregar.Controls.Add(Me.txtidusuario)
        Me.Cmbagregar.Controls.Add(Me.cmbproducto)
        Me.Cmbagregar.Controls.Add(Me.Label5)
        Me.Cmbagregar.Controls.Add(Me.dtfecha)
        Me.Cmbagregar.Controls.Add(Me.Label1)
        Me.Cmbagregar.Controls.Add(Me.txtnumfactura)
        Me.Cmbagregar.Controls.Add(Me.Label2)
        Me.Cmbagregar.Controls.Add(Me.txtidcliente)
        Me.Cmbagregar.Controls.Add(Me.Label3)
        Me.Cmbagregar.Controls.Add(Me.Label8)
        Me.Cmbagregar.Location = New System.Drawing.Point(28, 127)
        Me.Cmbagregar.Margin = New System.Windows.Forms.Padding(4)
        Me.Cmbagregar.Name = "Cmbagregar"
        Me.Cmbagregar.Padding = New System.Windows.Forms.Padding(4)
        Me.Cmbagregar.Size = New System.Drawing.Size(392, 267)
        Me.Cmbagregar.TabIndex = 18
        Me.Cmbagregar.TabStop = False
        Me.Cmbagregar.Text = "Datos"
        '
        'txtidusuario
        '
        Me.txtidusuario.Location = New System.Drawing.Point(121, 155)
        Me.txtidusuario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidusuario.Name = "txtidusuario"
        Me.txtidusuario.Size = New System.Drawing.Size(132, 22)
        Me.txtidusuario.TabIndex = 15
        '
        'cmbproducto
        '
        Me.cmbproducto.FormattingEnabled = True
        Me.cmbproducto.Location = New System.Drawing.Point(121, 75)
        Me.cmbproducto.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbproducto.Name = "cmbproducto"
        Me.cmbproducto.Size = New System.Drawing.Size(135, 24)
        Me.cmbproducto.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 79)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Producto"
        '
        'dtfecha
        '
        Me.dtfecha.Location = New System.Drawing.Point(119, 207)
        Me.dtfecha.Margin = New System.Windows.Forms.Padding(4)
        Me.dtfecha.Name = "dtfecha"
        Me.dtfecha.Size = New System.Drawing.Size(196, 22)
        Me.dtfecha.TabIndex = 12
        '
        'btnagregar
        '
        Me.btnagregar.Location = New System.Drawing.Point(455, 366)
        Me.btnagregar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(100, 28)
        Me.btnagregar.TabIndex = 19
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(696, 366)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(100, 28)
        Me.btnEliminar.TabIndex = 20
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 31)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 16)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Precio"
        '
        'txtprecio
        '
        Me.txtprecio.Location = New System.Drawing.Point(137, 36)
        Me.txtprecio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(132, 22)
        Me.txtprecio.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 68)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 16)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Cantidad"
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(137, 68)
        Me.txtcantidad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(132, 22)
        Me.txtcantidad.TabIndex = 24
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(290, 136)
        Me.btnCalcular.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(100, 28)
        Me.btnCalcular.TabIndex = 25
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 148)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 16)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Total"
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(137, 139)
        Me.txttotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(132, 22)
        Me.txttotal.TabIndex = 27
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(25, 437)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 16)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Buscar Producto:"
        '
        'txtbuscarpro
        '
        Me.txtbuscarpro.Location = New System.Drawing.Point(142, 434)
        Me.txtbuscarpro.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbuscarpro.Name = "txtbuscarpro"
        Me.txtbuscarpro.Size = New System.Drawing.Size(175, 22)
        Me.txtbuscarpro.TabIndex = 28
        '
        'dgvFactura
        '
        Me.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFactura.Location = New System.Drawing.Point(28, 471)
        Me.dgvFactura.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvFactura.Name = "dgvFactura"
        Me.dgvFactura.RowHeadersWidth = 51
        Me.dgvFactura.Size = New System.Drawing.Size(1010, 197)
        Me.dgvFactura.TabIndex = 30
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btnCalcular)
        Me.GroupBox1.Controls.Add(Me.txttotal)
        Me.GroupBox1.Controls.Add(Me.txtprecio)
        Me.GroupBox1.Controls.Add(Me.txtcantidad)
        Me.GroupBox1.Controls.Add(Me.txtdescuento)
        Me.GroupBox1.Location = New System.Drawing.Point(503, 127)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(414, 188)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Facturacion"
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(575, 366)
        Me.btnActualizar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(100, 28)
        Me.btnActualizar.TabIndex = 32
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(817, 366)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(935, 366)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 28)
        Me.Button2.TabIndex = 34
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Location = New System.Drawing.Point(3, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1064, 71)
        Me.Panel1.TabIndex = 35
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Sistema_Info_Creativo.My.Resources.Resources.LOGOTIPO_INFO_CREATIVE1
        Me.PictureBox3.Location = New System.Drawing.Point(977, 0)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(87, 87)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 25
        Me.PictureBox3.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(232, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(594, 49)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "FACTURACION DE VENTAS"
        '
        'btnbuscar
        '
        Me.btnbuscar.BackColor = System.Drawing.Color.Transparent
        Me.btnbuscar.BackgroundImage = Global.Sistema_Info_Creativo.My.Resources.Resources._5c790123003fa702a1d2795b
        Me.btnbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscar.Location = New System.Drawing.Point(275, 32)
        Me.btnbuscar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(29, 26)
        Me.btnbuscar.TabIndex = 36
        Me.btnbuscar.UseVisualStyleBackColor = False
        '
        'FrmFacturaVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1066, 703)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvFactura)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtbuscarpro)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.Cmbagregar)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmFacturaVentas"
        Me.Text = "FrmFacturaVentas"
        Me.Cmbagregar.ResumeLayout(False)
        Me.Cmbagregar.PerformLayout()
        CType(Me.dgvFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtnumfactura As TextBox
    Friend WithEvents txtidcliente As TextBox
    Friend WithEvents txtdescuento As TextBox
    Friend WithEvents Cmbagregar As GroupBox
    Friend WithEvents dtfecha As DateTimePicker
    Friend WithEvents btnagregar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents cmbproducto As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txttotal As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtbuscarpro As TextBox
    Friend WithEvents dgvFactura As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnActualizar As Button
    Friend WithEvents txtidusuario As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label14 As Label
    Friend WithEvents btnbuscar As Button
End Class
