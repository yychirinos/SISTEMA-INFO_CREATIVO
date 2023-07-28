<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFacturaVentas
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtnumfactura = New System.Windows.Forms.TextBox()
        Me.txtidcliente = New System.Windows.Forms.TextBox()
        Me.txtidusuario = New System.Windows.Forms.TextBox()
        Me.txtdescuento = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.Cmbagregar = New System.Windows.Forms.GroupBox()
        Me.dtfecha = New System.Windows.Forms.DateTimePicker()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgvventas = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbproducto = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.Cmbagregar.SuspendLayout()
        CType(Me.dgvventas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Num Factura"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "IdCliente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(210, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(491, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Descuento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(501, 124)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Total"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 135)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "IdUsuario"
        '
        'txtnumfactura
        '
        Me.txtnumfactura.Location = New System.Drawing.Point(91, 28)
        Me.txtnumfactura.Name = "txtnumfactura"
        Me.txtnumfactura.Size = New System.Drawing.Size(100, 20)
        Me.txtnumfactura.TabIndex = 8
        '
        'txtidcliente
        '
        Me.txtidcliente.Location = New System.Drawing.Point(91, 91)
        Me.txtidcliente.Name = "txtidcliente"
        Me.txtidcliente.Size = New System.Drawing.Size(100, 20)
        Me.txtidcliente.TabIndex = 9
        '
        'txtidusuario
        '
        Me.txtidusuario.Location = New System.Drawing.Point(91, 128)
        Me.txtidusuario.Name = "txtidusuario"
        Me.txtidusuario.Size = New System.Drawing.Size(100, 20)
        Me.txtidusuario.TabIndex = 11
        '
        'txtdescuento
        '
        Me.txtdescuento.Location = New System.Drawing.Point(566, 80)
        Me.txtdescuento.Name = "txtdescuento"
        Me.txtdescuento.Size = New System.Drawing.Size(100, 20)
        Me.txtdescuento.TabIndex = 12
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(566, 121)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(100, 20)
        Me.txttotal.TabIndex = 14
        '
        'Cmbagregar
        '
        Me.Cmbagregar.Controls.Add(Me.cmbproducto)
        Me.Cmbagregar.Controls.Add(Me.Label5)
        Me.Cmbagregar.Controls.Add(Me.dtfecha)
        Me.Cmbagregar.Controls.Add(Me.Label1)
        Me.Cmbagregar.Controls.Add(Me.txtnumfactura)
        Me.Cmbagregar.Controls.Add(Me.Label2)
        Me.Cmbagregar.Controls.Add(Me.txtidcliente)
        Me.Cmbagregar.Controls.Add(Me.Label3)
        Me.Cmbagregar.Controls.Add(Me.Label8)
        Me.Cmbagregar.Controls.Add(Me.txtidusuario)
        Me.Cmbagregar.Location = New System.Drawing.Point(12, 12)
        Me.Cmbagregar.Name = "Cmbagregar"
        Me.Cmbagregar.Size = New System.Drawing.Size(473, 175)
        Me.Cmbagregar.TabIndex = 18
        Me.Cmbagregar.TabStop = False
        Me.Cmbagregar.Text = "GroupBox1"
        '
        'dtfecha
        '
        Me.dtfecha.Location = New System.Drawing.Point(253, 31)
        Me.dtfecha.Name = "dtfecha"
        Me.dtfecha.Size = New System.Drawing.Size(148, 20)
        Me.dtfecha.TabIndex = 12
        '
        'btnagregar
        '
        Me.btnagregar.Location = New System.Drawing.Point(21, 224)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(75, 23)
        Me.btnagregar.TabIndex = 19
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(146, 224)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Eliminar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgvventas
        '
        Me.dgvventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvventas.Location = New System.Drawing.Point(5, 286)
        Me.dgvventas.Name = "dgvventas"
        Me.dgvventas.Size = New System.Drawing.Size(706, 164)
        Me.dgvventas.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(495, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Precio"
        '
        'txtprecio
        '
        Me.txtprecio.Location = New System.Drawing.Point(566, 28)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(100, 20)
        Me.txtprecio.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Producto"
        '
        'cmbproducto
        '
        Me.cmbproducto.FormattingEnabled = True
        Me.cmbproducto.Location = New System.Drawing.Point(89, 56)
        Me.cmbproducto.Name = "cmbproducto"
        Me.cmbproducto.Size = New System.Drawing.Size(102, 21)
        Me.cmbproducto.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(491, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Cantidad"
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(566, 54)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtcantidad.TabIndex = 24
        '
        'FrmFacturaVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 453)
        Me.Controls.Add(Me.txtcantidad)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtprecio)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.Cmbagregar)
        Me.Controls.Add(Me.dgvventas)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.txtdescuento)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Name = "FrmFacturaVentas"
        Me.Text = "FrmFacturaVentas"
        Me.Cmbagregar.ResumeLayout(False)
        Me.Cmbagregar.PerformLayout()
        CType(Me.dgvventas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtnumfactura As TextBox
    Friend WithEvents txtidcliente As TextBox
    Friend WithEvents txtidusuario As TextBox
    Friend WithEvents txtdescuento As TextBox
    Friend WithEvents txttotal As TextBox
    Friend WithEvents Cmbagregar As GroupBox
    Friend WithEvents dtfecha As DateTimePicker
    Friend WithEvents btnagregar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents dgvventas As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents cmbproducto As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtcantidad As TextBox
End Class
