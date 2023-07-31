<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmClientes
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.Txtdnicliente = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtcorreo = New System.Windows.Forms.TextBox()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.txtapellidocliente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombreCliente = New System.Windows.Forms.TextBox()
        Me.Txttelefono = New System.Windows.Forms.TextBox()
        Me.cmbtipocliente = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCodCliente = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.label = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnactualizar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.DataGridClientes = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Location = New System.Drawing.Point(3, 1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1211, 66)
        Me.Panel1.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(467, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(241, 49)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "CLIENTES"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Sistema_Info_Creativo.My.Resources.Resources.LOGOTIPO_INFO_CREATIVE1
        Me.PictureBox3.Location = New System.Drawing.Point(1121, 1)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(87, 78)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 24
        Me.PictureBox3.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtdireccion)
        Me.GroupBox1.Controls.Add(Me.Txtdnicliente)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtcorreo)
        Me.GroupBox1.Controls.Add(Me.btnbuscar)
        Me.GroupBox1.Controls.Add(Me.txtapellidocliente)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNombreCliente)
        Me.GroupBox1.Controls.Add(Me.Txttelefono)
        Me.GroupBox1.Controls.Add(Me.cmbtipocliente)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtCodCliente)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.label)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(59, 114)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(1092, 196)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informacion Principal."
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(549, 95)
        Me.txtdireccion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtdireccion.Multiline = True
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(493, 62)
        Me.txtdireccion.TabIndex = 19
        '
        'Txtdnicliente
        '
        Me.Txtdnicliente.Location = New System.Drawing.Point(155, 134)
        Me.Txtdnicliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txtdnicliente.Name = "Txtdnicliente"
        Me.Txtdnicliente.Size = New System.Drawing.Size(200, 22)
        Me.Txtdnicliente.TabIndex = 14
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(435, 114)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 16)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Direccion:"
        '
        'txtcorreo
        '
        Me.txtcorreo.Location = New System.Drawing.Point(843, 22)
        Me.txtcorreo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcorreo.Name = "txtcorreo"
        Me.txtcorreo.Size = New System.Drawing.Size(200, 22)
        Me.txtcorreo.TabIndex = 18
        '
        'btnbuscar
        '
        Me.btnbuscar.BackColor = System.Drawing.Color.Transparent
        Me.btnbuscar.BackgroundImage = Global.Sistema_Info_Creativo.My.Resources.Resources._5c790123003fa702a1d2795b
        Me.btnbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscar.Location = New System.Drawing.Point(285, 28)
        Me.btnbuscar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(29, 26)
        Me.btnbuscar.TabIndex = 12
        Me.btnbuscar.UseVisualStyleBackColor = False
        '
        'txtapellidocliente
        '
        Me.txtapellidocliente.Location = New System.Drawing.Point(155, 95)
        Me.txtapellidocliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtapellidocliente.Name = "txtapellidocliente"
        Me.txtapellidocliente.Size = New System.Drawing.Size(200, 22)
        Me.txtapellidocliente.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(779, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 16)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Correo:"
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Location = New System.Drawing.Point(155, 62)
        Me.txtNombreCliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.Size = New System.Drawing.Size(200, 22)
        Me.txtNombreCliente.TabIndex = 7
        '
        'Txttelefono
        '
        Me.Txttelefono.Location = New System.Drawing.Point(549, 62)
        Me.Txttelefono.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txttelefono.Name = "Txttelefono"
        Me.Txttelefono.Size = New System.Drawing.Size(200, 22)
        Me.Txttelefono.TabIndex = 7
        '
        'cmbtipocliente
        '
        Me.cmbtipocliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtipocliente.FormattingEnabled = True
        Me.cmbtipocliente.Location = New System.Drawing.Point(549, 25)
        Me.cmbtipocliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbtipocliente.Name = "cmbtipocliente"
        Me.cmbtipocliente.Size = New System.Drawing.Size(200, 24)
        Me.cmbtipocliente.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(435, 68)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 16)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Telefono:"
        '
        'txtCodCliente
        '
        Me.txtCodCliente.Location = New System.Drawing.Point(155, 30)
        Me.txtCodCliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCodCliente.Name = "txtCodCliente"
        Me.txtCodCliente.Size = New System.Drawing.Size(115, 22)
        Me.txtCodCliente.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "DNI:"
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Location = New System.Drawing.Point(16, 101)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(69, 16)
        Me.label.TabIndex = 2
        Me.label.Text = "Apellido:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(435, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Tipo Cliente:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cod. Cliente:"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btneliminar)
        Me.Panel3.Controls.Add(Me.btnsalir)
        Me.Panel3.Controls.Add(Me.btncancelar)
        Me.Panel3.Controls.Add(Me.btnactualizar)
        Me.Panel3.Controls.Add(Me.btnguardar)
        Me.Panel3.Location = New System.Drawing.Point(59, 622)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1092, 70)
        Me.Panel3.TabIndex = 16
        '
        'btneliminar
        '
        Me.btneliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminar.Location = New System.Drawing.Point(285, 14)
        Me.btneliminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(117, 39)
        Me.btneliminar.TabIndex = 5
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalir.Location = New System.Drawing.Point(963, 14)
        Me.btnsalir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(99, 39)
        Me.btnsalir.TabIndex = 4
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.Location = New System.Drawing.Point(419, 14)
        Me.btncancelar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(111, 39)
        Me.btncancelar.TabIndex = 3
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnactualizar
        '
        Me.btnactualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnactualizar.Location = New System.Drawing.Point(139, 14)
        Me.btnactualizar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnactualizar.Name = "btnactualizar"
        Me.btnactualizar.Size = New System.Drawing.Size(131, 39)
        Me.btnactualizar.TabIndex = 1
        Me.btnactualizar.Text = "Actualizar"
        Me.btnactualizar.UseVisualStyleBackColor = True
        '
        'btnguardar
        '
        Me.btnguardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.Location = New System.Drawing.Point(17, 14)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(107, 39)
        Me.btnguardar.TabIndex = 0
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'DataGridClientes
        '
        Me.DataGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridClientes.Location = New System.Drawing.Point(59, 336)
        Me.DataGridClientes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridClientes.Name = "DataGridClientes"
        Me.DataGridClientes.RowHeadersWidth = 51
        Me.DataGridClientes.RowTemplate.Height = 24
        Me.DataGridClientes.Size = New System.Drawing.Size(1092, 250)
        Me.DataGridClientes.TabIndex = 17
        '
        'FrmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1211, 732)
        Me.Controls.Add(Me.DataGridClientes)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmClientes"
        Me.Text = "FrmClientes"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.DataGridClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Txtdnicliente As TextBox
    Friend WithEvents btnbuscar As Button
    Friend WithEvents txtapellidocliente As TextBox
    Friend WithEvents txtNombreCliente As TextBox
    Friend WithEvents txtCodCliente As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents label As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Txttelefono As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbtipocliente As ComboBox
    Friend WithEvents txtdireccion As TextBox
    Friend WithEvents txtcorreo As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btneliminar As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents btnactualizar As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents DataGridClientes As DataGridView
    Friend WithEvents Label4 As Label
End Class
