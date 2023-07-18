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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtnumfactura = New System.Windows.Forms.TextBox()
        Me.txtidcliente = New System.Windows.Forms.TextBox()
        Me.txtfecha = New System.Windows.Forms.TextBox()
        Me.txtidusuario = New System.Windows.Forms.TextBox()
        Me.txtdescuento = New System.Windows.Forms.TextBox()
        Me.txtisv = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.txtsubtotal = New System.Windows.Forms.TextBox()
        Me.cmbdetallefac = New System.Windows.Forms.Button()
        Me.dgvventas = New System.Windows.Forms.DataGridView()
        CType(Me.dgvventas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Num Factura"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "IdCliente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(314, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Descuento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(314, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "SubTotal"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(321, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "ISV"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(321, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Total"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(29, 130)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "IdUsuario"
        '
        'txtnumfactura
        '
        Me.txtnumfactura.Location = New System.Drawing.Point(103, 27)
        Me.txtnumfactura.Name = "txtnumfactura"
        Me.txtnumfactura.Size = New System.Drawing.Size(100, 20)
        Me.txtnumfactura.TabIndex = 8
        '
        'txtidcliente
        '
        Me.txtidcliente.Location = New System.Drawing.Point(103, 62)
        Me.txtidcliente.Name = "txtidcliente"
        Me.txtidcliente.Size = New System.Drawing.Size(100, 20)
        Me.txtidcliente.TabIndex = 9
        '
        'txtfecha
        '
        Me.txtfecha.Location = New System.Drawing.Point(103, 95)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(100, 20)
        Me.txtfecha.TabIndex = 10
        '
        'txtidusuario
        '
        Me.txtidusuario.Location = New System.Drawing.Point(103, 127)
        Me.txtidusuario.Name = "txtidusuario"
        Me.txtidusuario.Size = New System.Drawing.Size(100, 20)
        Me.txtidusuario.TabIndex = 11
        '
        'txtdescuento
        '
        Me.txtdescuento.Location = New System.Drawing.Point(379, 24)
        Me.txtdescuento.Name = "txtdescuento"
        Me.txtdescuento.Size = New System.Drawing.Size(100, 20)
        Me.txtdescuento.TabIndex = 12
        '
        'txtisv
        '
        Me.txtisv.Location = New System.Drawing.Point(379, 59)
        Me.txtisv.Name = "txtisv"
        Me.txtisv.Size = New System.Drawing.Size(100, 20)
        Me.txtisv.TabIndex = 13
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(379, 92)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(100, 20)
        Me.txttotal.TabIndex = 14
        '
        'txtsubtotal
        '
        Me.txtsubtotal.Location = New System.Drawing.Point(379, 130)
        Me.txtsubtotal.Name = "txtsubtotal"
        Me.txtsubtotal.Size = New System.Drawing.Size(100, 20)
        Me.txtsubtotal.TabIndex = 15
        '
        'cmbdetallefac
        '
        Me.cmbdetallefac.Location = New System.Drawing.Point(379, 182)
        Me.cmbdetallefac.Name = "cmbdetallefac"
        Me.cmbdetallefac.Size = New System.Drawing.Size(86, 20)
        Me.cmbdetallefac.TabIndex = 16
        Me.cmbdetallefac.Text = "Detalle Venta"
        Me.cmbdetallefac.UseVisualStyleBackColor = True
        '
        'dgvventas
        '
        Me.dgvventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvventas.Location = New System.Drawing.Point(3, 317)
        Me.dgvventas.Name = "dgvventas"
        Me.dgvventas.Size = New System.Drawing.Size(658, 164)
        Me.dgvventas.TabIndex = 17
        '
        'FrmFacturaVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 493)
        Me.Controls.Add(Me.dgvventas)
        Me.Controls.Add(Me.cmbdetallefac)
        Me.Controls.Add(Me.txtsubtotal)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.txtisv)
        Me.Controls.Add(Me.txtdescuento)
        Me.Controls.Add(Me.txtidusuario)
        Me.Controls.Add(Me.txtfecha)
        Me.Controls.Add(Me.txtidcliente)
        Me.Controls.Add(Me.txtnumfactura)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmFacturaVentas"
        Me.Text = "FrmFacturaVentas"
        CType(Me.dgvventas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtnumfactura As TextBox
    Friend WithEvents txtidcliente As TextBox
    Friend WithEvents txtfecha As TextBox
    Friend WithEvents txtidusuario As TextBox
    Friend WithEvents txtdescuento As TextBox
    Friend WithEvents txtisv As TextBox
    Friend WithEvents txttotal As TextBox
    Friend WithEvents txtsubtotal As TextBox
    Friend WithEvents cmbdetallefac As Button
    Friend WithEvents dgvventas As DataGridView
End Class
