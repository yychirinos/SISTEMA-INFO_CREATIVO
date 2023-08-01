<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCompras
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtidcompra = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.btncalcular = New System.Windows.Forms.Button()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker()
        Me.txtcantidadarticulo = New System.Windows.Forms.TextBox()
        Me.txtprecioarticulo = New System.Windows.Forms.TextBox()
        Me.txtarticulo = New System.Windows.Forms.TextBox()
        Me.txtidarticulo = New System.Windows.Forms.TextBox()
        Me.txtidproveedor = New System.Windows.Forms.TextBox()
        Me.txtidempleado = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnactualizar = New System.Windows.Forms.Button()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.btnregistrar = New System.Windows.Forms.Button()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.datagridcompra = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datagridcompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1113, 66)
        Me.Panel1.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(318, 8)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(482, 49)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "REGISTRAR COMPRA"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Blue
        Me.PictureBox3.Image = Global.Sistema_Info_Creativo.My.Resources.Resources.LOGOTIPO_INFO_CREATIVE6
        Me.PictureBox3.Location = New System.Drawing.Point(1015, 0)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(96, 99)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 23
        Me.PictureBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Id_Compra"
        '
        'txtidcompra
        '
        Me.txtidcompra.Location = New System.Drawing.Point(163, 31)
        Me.txtidcompra.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidcompra.Name = "txtidcompra"
        Me.txtidcompra.Size = New System.Drawing.Size(132, 22)
        Me.txtidcompra.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(44, 80)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Id_Empleado"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.btnlimpiar)
        Me.GroupBox1.Controls.Add(Me.btncalcular)
        Me.GroupBox1.Controls.Add(Me.txttotal)
        Me.GroupBox1.Controls.Add(Me.dtpfecha)
        Me.GroupBox1.Controls.Add(Me.txtcantidadarticulo)
        Me.GroupBox1.Controls.Add(Me.txtprecioarticulo)
        Me.GroupBox1.Controls.Add(Me.txtarticulo)
        Me.GroupBox1.Controls.Add(Me.txtidarticulo)
        Me.GroupBox1.Controls.Add(Me.txtidproveedor)
        Me.GroupBox1.Controls.Add(Me.txtidempleado)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtidcompra)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 74)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1101, 239)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'btnlimpiar
        '
        Me.btnlimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlimpiar.Location = New System.Drawing.Point(799, 178)
        Me.btnlimpiar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(100, 28)
        Me.btnlimpiar.TabIndex = 25
        Me.btnlimpiar.Text = "Limpiar"
        Me.btnlimpiar.UseVisualStyleBackColor = True
        '
        'btncalcular
        '
        Me.btncalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncalcular.Location = New System.Drawing.Point(799, 143)
        Me.btncalcular.Margin = New System.Windows.Forms.Padding(4)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(100, 28)
        Me.btncalcular.TabIndex = 24
        Me.btncalcular.Text = "Calcular"
        Me.btncalcular.UseVisualStyleBackColor = True
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(584, 169)
        Me.txttotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(181, 22)
        Me.txttotal.TabIndex = 23
        '
        'dtpfecha
        '
        Me.dtpfecha.Location = New System.Drawing.Point(163, 213)
        Me.dtpfecha.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(199, 22)
        Me.dtpfecha.TabIndex = 21
        '
        'txtcantidadarticulo
        '
        Me.txtcantidadarticulo.Location = New System.Drawing.Point(584, 80)
        Me.txtcantidadarticulo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcantidadarticulo.Name = "txtcantidadarticulo"
        Me.txtcantidadarticulo.Size = New System.Drawing.Size(181, 22)
        Me.txtcantidadarticulo.TabIndex = 20
        '
        'txtprecioarticulo
        '
        Me.txtprecioarticulo.Location = New System.Drawing.Point(584, 122)
        Me.txtprecioarticulo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtprecioarticulo.Name = "txtprecioarticulo"
        Me.txtprecioarticulo.Size = New System.Drawing.Size(181, 22)
        Me.txtprecioarticulo.TabIndex = 12
        '
        'txtarticulo
        '
        Me.txtarticulo.Location = New System.Drawing.Point(584, 31)
        Me.txtarticulo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtarticulo.Name = "txtarticulo"
        Me.txtarticulo.Size = New System.Drawing.Size(191, 22)
        Me.txtarticulo.TabIndex = 19
        '
        'txtidarticulo
        '
        Me.txtidarticulo.Location = New System.Drawing.Point(163, 165)
        Me.txtidarticulo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidarticulo.Name = "txtidarticulo"
        Me.txtidarticulo.Size = New System.Drawing.Size(132, 22)
        Me.txtidarticulo.TabIndex = 18
        '
        'txtidproveedor
        '
        Me.txtidproveedor.Location = New System.Drawing.Point(163, 118)
        Me.txtidproveedor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidproveedor.Name = "txtidproveedor"
        Me.txtidproveedor.Size = New System.Drawing.Size(132, 22)
        Me.txtidproveedor.TabIndex = 17
        '
        'txtidempleado
        '
        Me.txtidempleado.Location = New System.Drawing.Point(163, 71)
        Me.txtidempleado.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidempleado.Name = "txtidempleado"
        Me.txtidempleado.Size = New System.Drawing.Size(132, 22)
        Me.txtidempleado.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(428, 169)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 17)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Total"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(49, 213)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 17)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Fecha_Hora"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(428, 80)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(132, 17)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Cantidad Articulo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(428, 122)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Precio Articulo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(428, 34)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Articulo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(44, 127)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Id_Proveedor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(44, 169)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Id_Articulo"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btnbuscar)
        Me.GroupBox2.Controls.Add(Me.btneliminar)
        Me.GroupBox2.Controls.Add(Me.btnactualizar)
        Me.GroupBox2.Controls.Add(Me.PictureBox7)
        Me.GroupBox2.Controls.Add(Me.btnregistrar)
        Me.GroupBox2.Controls.Add(Me.PictureBox6)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(456, 350)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(616, 100)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opciones"
        '
        'btnbuscar
        '
        Me.btnbuscar.BackgroundImage = Global.Sistema_Info_Creativo.My.Resources.Resources.vector_find_icon
        Me.btnbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscar.Location = New System.Drawing.Point(285, 27)
        Me.btnbuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(71, 48)
        Me.btnbuscar.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.btnbuscar, "Buscar.")
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.BackgroundImage = Global.Sistema_Info_Creativo.My.Resources.Resources._32218971
        Me.btneliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btneliminar.Location = New System.Drawing.Point(205, 23)
        Me.btneliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(72, 52)
        Me.btneliminar.TabIndex = 23
        Me.ToolTip1.SetToolTip(Me.btneliminar, "Eliminar.")
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btnactualizar
        '
        Me.btnactualizar.BackgroundImage = Global.Sistema_Info_Creativo.My.Resources.Resources.Actalizar1
        Me.btnactualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnactualizar.Location = New System.Drawing.Point(111, 27)
        Me.btnactualizar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnactualizar.Name = "btnactualizar"
        Me.btnactualizar.Size = New System.Drawing.Size(76, 48)
        Me.btnactualizar.TabIndex = 23
        Me.ToolTip1.SetToolTip(Me.btnactualizar, "Actualizar.")
        Me.btnactualizar.UseVisualStyleBackColor = True
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.Sistema_Info_Creativo.My.Resources.Resources._52_521721_close_cross_sign_in_a_square_button_comments
        Me.PictureBox7.Location = New System.Drawing.Point(364, 27)
        Me.PictureBox7.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(59, 48)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 16
        Me.PictureBox7.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox7, "Cancelar.")
        '
        'btnregistrar
        '
        Me.btnregistrar.BackgroundImage = Global.Sistema_Info_Creativo.My.Resources.Resources.png_transparent_computer_icons_user_profile_symbol_register_button_miscellaneous_blue_logo_thumbnail
        Me.btnregistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnregistrar.Location = New System.Drawing.Point(27, 27)
        Me.btnregistrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnregistrar.Name = "btnregistrar"
        Me.btnregistrar.Size = New System.Drawing.Size(64, 48)
        Me.btnregistrar.TabIndex = 23
        Me.ToolTip1.SetToolTip(Me.btnregistrar, "Guardar.")
        Me.btnregistrar.UseVisualStyleBackColor = True
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.Sistema_Info_Creativo.My.Resources.Resources._exit
        Me.PictureBox6.Location = New System.Drawing.Point(431, 27)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(60, 48)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 15
        Me.PictureBox6.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox6, "Volver al Menu Principal.")
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 100
        Me.ToolTip1.ReshowDelay = 100
        '
        'datagridcompra
        '
        Me.datagridcompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridcompra.Location = New System.Drawing.Point(0, 457)
        Me.datagridcompra.Name = "datagridcompra"
        Me.datagridcompra.RowHeadersWidth = 51
        Me.datagridcompra.RowTemplate.Height = 24
        Me.datagridcompra.Size = New System.Drawing.Size(1110, 205)
        Me.datagridcompra.TabIndex = 12
        '
        'FrmCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1108, 682)
        Me.Controls.Add(Me.datagridcompra)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmCompras"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datagridcompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtidcompra As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dtpfecha As DateTimePicker
    Friend WithEvents txtcantidadarticulo As TextBox
    Friend WithEvents txtprecioarticulo As TextBox
    Friend WithEvents txtarticulo As TextBox
    Friend WithEvents txtidarticulo As TextBox
    Friend WithEvents txtidproveedor As TextBox
    Friend WithEvents txtidempleado As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents btnregistrar As Button
    Friend WithEvents btnactualizar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents btnbuscar As Button
    Friend WithEvents txttotal As TextBox
    Friend WithEvents btncalcular As Button
    Friend WithEvents btnlimpiar As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label11 As Label
    Friend WithEvents datagridcompra As DataGridView
End Class
