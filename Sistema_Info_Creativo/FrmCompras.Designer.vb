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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtidcompra = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
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
        Me.datagridcompras = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datagridcompras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(827, 54)
        Me.Panel1.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Niagara Engraved", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(131, 23)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "REGISTRAR COMPRA"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Blue
        Me.PictureBox3.Image = Global.Sistema_Info_Creativo.My.Resources.Resources.WhatsApp_Image_2023_06_17_at_7_59_24_PM
        Me.PictureBox3.Location = New System.Drawing.Point(716, 0)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(111, 54)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 23
        Me.PictureBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Id_Compra"
        '
        'txtidcompra
        '
        Me.txtidcompra.Location = New System.Drawing.Point(122, 25)
        Me.txtidcompra.Name = "txtidcompra"
        Me.txtidcompra.Size = New System.Drawing.Size(100, 20)
        Me.txtidcompra.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Id_Empleado"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
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
        Me.GroupBox1.Location = New System.Drawing.Point(7, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(826, 194)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(431, 130)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(113, 20)
        Me.txttotal.TabIndex = 22
        '
        'dtpfecha
        '
        Me.dtpfecha.Location = New System.Drawing.Point(122, 173)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(150, 20)
        Me.dtpfecha.TabIndex = 21
        '
        'txtcantidadarticulo
        '
        Me.txtcantidadarticulo.Location = New System.Drawing.Point(431, 96)
        Me.txtcantidadarticulo.Name = "txtcantidadarticulo"
        Me.txtcantidadarticulo.Size = New System.Drawing.Size(105, 20)
        Me.txtcantidadarticulo.TabIndex = 20
        '
        'txtprecioarticulo
        '
        Me.txtprecioarticulo.Location = New System.Drawing.Point(431, 62)
        Me.txtprecioarticulo.Name = "txtprecioarticulo"
        Me.txtprecioarticulo.Size = New System.Drawing.Size(114, 20)
        Me.txtprecioarticulo.TabIndex = 12
        '
        'txtarticulo
        '
        Me.txtarticulo.Location = New System.Drawing.Point(431, 25)
        Me.txtarticulo.Name = "txtarticulo"
        Me.txtarticulo.Size = New System.Drawing.Size(144, 20)
        Me.txtarticulo.TabIndex = 19
        '
        'txtidarticulo
        '
        Me.txtidarticulo.Location = New System.Drawing.Point(122, 134)
        Me.txtidarticulo.Name = "txtidarticulo"
        Me.txtidarticulo.Size = New System.Drawing.Size(100, 20)
        Me.txtidarticulo.TabIndex = 18
        '
        'txtidproveedor
        '
        Me.txtidproveedor.Location = New System.Drawing.Point(122, 96)
        Me.txtidproveedor.Name = "txtidproveedor"
        Me.txtidproveedor.Size = New System.Drawing.Size(100, 20)
        Me.txtidproveedor.TabIndex = 17
        '
        'txtidempleado
        '
        Me.txtidempleado.Location = New System.Drawing.Point(122, 58)
        Me.txtidempleado.Name = "txtidempleado"
        Me.txtidempleado.Size = New System.Drawing.Size(100, 20)
        Me.txtidempleado.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(321, 134)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Total"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(37, 173)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Fecha_Hora"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(321, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Cantidad Articulo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(321, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Precio Articulo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(321, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Articulo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Id_Proveedor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
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
        Me.GroupBox2.Location = New System.Drawing.Point(342, 284)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(462, 81)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opciones"
        '
        'btnbuscar
        '
        Me.btnbuscar.BackgroundImage = Global.Sistema_Info_Creativo.My.Resources.Resources.vector_find_icon
        Me.btnbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscar.Location = New System.Drawing.Point(214, 22)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(53, 39)
        Me.btnbuscar.TabIndex = 13
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.BackgroundImage = Global.Sistema_Info_Creativo.My.Resources.Resources._32218971
        Me.btneliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btneliminar.Location = New System.Drawing.Point(154, 19)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(54, 42)
        Me.btneliminar.TabIndex = 23
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btnactualizar
        '
        Me.btnactualizar.BackgroundImage = Global.Sistema_Info_Creativo.My.Resources.Resources.Actalizar1
        Me.btnactualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnactualizar.Location = New System.Drawing.Point(83, 22)
        Me.btnactualizar.Name = "btnactualizar"
        Me.btnactualizar.Size = New System.Drawing.Size(57, 39)
        Me.btnactualizar.TabIndex = 23
        Me.btnactualizar.UseVisualStyleBackColor = True
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.Sistema_Info_Creativo.My.Resources.Resources._52_521721_close_cross_sign_in_a_square_button_comments
        Me.PictureBox7.Location = New System.Drawing.Point(273, 22)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(44, 39)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 16
        Me.PictureBox7.TabStop = False
        '
        'btnregistrar
        '
        Me.btnregistrar.BackgroundImage = Global.Sistema_Info_Creativo.My.Resources.Resources.png_transparent_computer_icons_user_profile_symbol_register_button_miscellaneous_blue_logo_thumbnail
        Me.btnregistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnregistrar.Location = New System.Drawing.Point(20, 22)
        Me.btnregistrar.Name = "btnregistrar"
        Me.btnregistrar.Size = New System.Drawing.Size(48, 39)
        Me.btnregistrar.TabIndex = 23
        Me.btnregistrar.UseVisualStyleBackColor = True
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.Sistema_Info_Creativo.My.Resources.Resources._exit
        Me.PictureBox6.Location = New System.Drawing.Point(357, 22)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(45, 39)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 15
        Me.PictureBox6.TabStop = False
        '
        'datagridcompras
        '
        Me.datagridcompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridcompras.Location = New System.Drawing.Point(0, 371)
        Me.datagridcompras.Name = "datagridcompras"
        Me.datagridcompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridcompras.Size = New System.Drawing.Size(835, 127)
        Me.datagridcompras.TabIndex = 12
        '
        'FrmCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(843, 498)
        Me.Controls.Add(Me.datagridcompras)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmCompras"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datagridcompras, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txttotal As TextBox
    Friend WithEvents dtpfecha As DateTimePicker
    Friend WithEvents txtcantidadarticulo As TextBox
    Friend WithEvents txtprecioarticulo As TextBox
    Friend WithEvents txtarticulo As TextBox
    Friend WithEvents txtidarticulo As TextBox
    Friend WithEvents txtidproveedor As TextBox
    Friend WithEvents txtidempleado As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents btnregistrar As Button
    Friend WithEvents datagridcompras As DataGridView
    Friend WithEvents btnactualizar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents btnbuscar As Button
End Class
