<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEmpleados
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.cmbsexo = New System.Windows.Forms.ComboBox()
        Me.dtpfechanac = New System.Windows.Forms.DateTimePicker()
        Me.txtapellidos = New System.Windows.Forms.TextBox()
        Me.txtnombres = New System.Windows.Forms.TextBox()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.txtNumEmpleado = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ckactivo = New System.Windows.Forms.CheckBox()
        Me.cmbestadocivil = New System.Windows.Forms.ComboBox()
        Me.txtcargo = New System.Windows.Forms.TextBox()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.txtnivelacademico = New System.Windows.Forms.TextBox()
        Me.txtcorreo = New System.Windows.Forms.TextBox()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.eliminar = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.actualizar = New System.Windows.Forms.Button()
        Me.guardar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Cancelar = New System.Windows.Forms.Button()
        Me.btnactualizar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.btnbuscar)
        Me.GroupBox1.Controls.Add(Me.cmbsexo)
        Me.GroupBox1.Controls.Add(Me.dtpfechanac)
        Me.GroupBox1.Controls.Add(Me.txtapellidos)
        Me.GroupBox1.Controls.Add(Me.txtnombres)
        Me.GroupBox1.Controls.Add(Me.txtDNI)
        Me.GroupBox1.Controls.Add(Me.txtNumEmpleado)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(83, 100)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(723, 229)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informacion Principal."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Sistema_Info_Creativo.My.Resources.Resources._327527
        Me.PictureBox1.Location = New System.Drawing.Point(500, 43)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(115, 135)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'btnbuscar
        '
        Me.btnbuscar.BackColor = System.Drawing.Color.Transparent
        Me.btnbuscar.BackgroundImage = Global.Sistema_Info_Creativo.My.Resources.Resources._5c790123003fa702a1d2795b
        Me.btnbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscar.Location = New System.Drawing.Point(275, 28)
        Me.btnbuscar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(29, 26)
        Me.btnbuscar.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.btnbuscar, "Buscar Empleado.")
        Me.btnbuscar.UseVisualStyleBackColor = False
        '
        'cmbsexo
        '
        Me.cmbsexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbsexo.FormattingEnabled = True
        Me.cmbsexo.Location = New System.Drawing.Point(153, 187)
        Me.cmbsexo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbsexo.Name = "cmbsexo"
        Me.cmbsexo.Size = New System.Drawing.Size(151, 24)
        Me.cmbsexo.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.cmbsexo, "Selecciones un sexo.")
        '
        'dtpfechanac
        '
        Me.dtpfechanac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechanac.Location = New System.Drawing.Point(155, 156)
        Me.dtpfechanac.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpfechanac.Name = "dtpfechanac"
        Me.dtpfechanac.Size = New System.Drawing.Size(149, 22)
        Me.dtpfechanac.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.dtpfechanac, "Ingrese una fecha de nacimiento.")
        '
        'txtapellidos
        '
        Me.txtapellidos.Location = New System.Drawing.Point(155, 124)
        Me.txtapellidos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtapellidos.Name = "txtapellidos"
        Me.txtapellidos.Size = New System.Drawing.Size(200, 22)
        Me.txtapellidos.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.txtapellidos, "Ingrese los apellidos del usuario.")
        '
        'txtnombres
        '
        Me.txtnombres.Location = New System.Drawing.Point(155, 95)
        Me.txtnombres.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtnombres.Name = "txtnombres"
        Me.txtnombres.Size = New System.Drawing.Size(200, 22)
        Me.txtnombres.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.txtnombres, "Ingrese los nombres del empleado.")
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(155, 62)
        Me.txtDNI.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(200, 22)
        Me.txtDNI.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.txtDNI, "Ingrese un DNI. (13 digitos, sin guiones ni espacios)")
        '
        'txtNumEmpleado
        '
        Me.txtNumEmpleado.Location = New System.Drawing.Point(155, 30)
        Me.txtNumEmpleado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNumEmpleado.Name = "txtNumEmpleado"
        Me.txtNumEmpleado.Size = New System.Drawing.Size(100, 22)
        Me.txtNumEmpleado.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.txtNumEmpleado, "Coloque un codigo de empleado.")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Sexo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Fecha Nac:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Apellidos:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombres:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "DNI:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Num. Empleado:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ckactivo)
        Me.GroupBox2.Controls.Add(Me.cmbestadocivil)
        Me.GroupBox2.Controls.Add(Me.txtcargo)
        Me.GroupBox2.Controls.Add(Me.txtdireccion)
        Me.GroupBox2.Controls.Add(Me.txtnivelacademico)
        Me.GroupBox2.Controls.Add(Me.txtcorreo)
        Me.GroupBox2.Controls.Add(Me.txttelefono)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(83, 362)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(723, 231)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informacion Complementaria:"
        '
        'ckactivo
        '
        Me.ckactivo.AutoSize = True
        Me.ckactivo.Location = New System.Drawing.Point(525, 98)
        Me.ckactivo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ckactivo.Name = "ckactivo"
        Me.ckactivo.Size = New System.Drawing.Size(18, 17)
        Me.ckactivo.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.ckactivo, "El empleado esta activo?")
        Me.ckactivo.UseVisualStyleBackColor = True
        '
        'cmbestadocivil
        '
        Me.cmbestadocivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbestadocivil.FormattingEnabled = True
        Me.cmbestadocivil.Location = New System.Drawing.Point(525, 65)
        Me.cmbestadocivil.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbestadocivil.Name = "cmbestadocivil"
        Me.cmbestadocivil.Size = New System.Drawing.Size(121, 24)
        Me.cmbestadocivil.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.cmbestadocivil, "Seleccione un estado civil.")
        '
        'txtcargo
        '
        Me.txtcargo.Location = New System.Drawing.Point(525, 32)
        Me.txtcargo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcargo.Name = "txtcargo"
        Me.txtcargo.Size = New System.Drawing.Size(121, 22)
        Me.txtcargo.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.txtcargo, "Ingrese el cargo que tendra el empleado.")
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(139, 139)
        Me.txtdireccion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtdireccion.Multiline = True
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(507, 62)
        Me.txtdireccion.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.txtdireccion, "Ingrese la direccion del empleado.")
        '
        'txtnivelacademico
        '
        Me.txtnivelacademico.Location = New System.Drawing.Point(139, 98)
        Me.txtnivelacademico.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtnivelacademico.Name = "txtnivelacademico"
        Me.txtnivelacademico.Size = New System.Drawing.Size(200, 22)
        Me.txtnivelacademico.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.txtnivelacademico, "Ingrese el nivel academico.")
        '
        'txtcorreo
        '
        Me.txtcorreo.Location = New System.Drawing.Point(139, 65)
        Me.txtcorreo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcorreo.Name = "txtcorreo"
        Me.txtcorreo.Size = New System.Drawing.Size(200, 22)
        Me.txtcorreo.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.txtcorreo, "Ingrese un correo electronico.")
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(139, 34)
        Me.txttelefono.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(116, 22)
        Me.txttelefono.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.txttelefono, "Ingrese un numero telefonico de 8 digitos.")
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(368, 97)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(129, 16)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Empleado Activo:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(5, 142)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 16)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Direccion:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(5, 103)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(129, 16)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Nivel Academico:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(368, 68)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 16)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Estado Civil:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(368, 38)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 16)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Cargo:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 68)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 16)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Correo:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Telefono:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Location = New System.Drawing.Point(1, -6)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(880, 66)
        Me.Panel1.TabIndex = 3
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Sistema_Info_Creativo.My.Resources.Resources.LOGOTIPO_INFO_CREATIVE1
        Me.PictureBox3.Location = New System.Drawing.Point(793, 2)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(87, 78)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 25
        Me.PictureBox3.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(291, 15)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(295, 49)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "EMPLEADOS"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.Cancelar)
        Me.Panel2.Controls.Add(Me.btnactualizar)
        Me.Panel2.Controls.Add(Me.btnguardar)
        Me.Panel2.Location = New System.Drawing.Point(83, 639)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(723, 70)
        Me.Panel2.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.eliminar)
        Me.Panel3.Controls.Add(Me.btnsalir)
        Me.Panel3.Controls.Add(Me.btncancelar)
        Me.Panel3.Controls.Add(Me.actualizar)
        Me.Panel3.Controls.Add(Me.guardar)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(723, 70)
        Me.Panel3.TabIndex = 4
        '
        'eliminar
        '
        Me.eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eliminar.Location = New System.Drawing.Point(285, 14)
        Me.eliminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.eliminar.Name = "eliminar"
        Me.eliminar.Size = New System.Drawing.Size(117, 39)
        Me.eliminar.TabIndex = 5
        Me.eliminar.Text = "Eliminar"
        Me.ToolTip1.SetToolTip(Me.eliminar, "Eliminar empleado.")
        Me.eliminar.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalir.Location = New System.Drawing.Point(609, 14)
        Me.btnsalir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(99, 39)
        Me.btnsalir.TabIndex = 4
        Me.btnsalir.Text = "Salir"
        Me.ToolTip1.SetToolTip(Me.btnsalir, "Volver al menu principal.")
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
        Me.ToolTip1.SetToolTip(Me.btncancelar, "Cancelar Registro.")
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'actualizar
        '
        Me.actualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.actualizar.Location = New System.Drawing.Point(139, 14)
        Me.actualizar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.actualizar.Name = "actualizar"
        Me.actualizar.Size = New System.Drawing.Size(131, 39)
        Me.actualizar.TabIndex = 1
        Me.actualizar.Text = "Actualizar"
        Me.ToolTip1.SetToolTip(Me.actualizar, "Actualizar informacion del empleado.")
        Me.actualizar.UseVisualStyleBackColor = True
        '
        'guardar
        '
        Me.guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guardar.Location = New System.Drawing.Point(17, 14)
        Me.guardar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.guardar.Name = "guardar"
        Me.guardar.Size = New System.Drawing.Size(107, 39)
        Me.guardar.TabIndex = 0
        Me.guardar.Text = "Guardar"
        Me.ToolTip1.SetToolTip(Me.guardar, "Guardar Empleado.")
        Me.guardar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(285, 14)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 39)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Eliminar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(609, 14)
        Me.Button5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(99, 39)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Salir"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Cancelar
        '
        Me.Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancelar.Location = New System.Drawing.Point(419, 14)
        Me.Cancelar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(111, 39)
        Me.Cancelar.TabIndex = 3
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.UseVisualStyleBackColor = True
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
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 100
        Me.ToolTip1.ReshowDelay = 100
        '
        'FrmEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 738)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmEmpleados"
        Me.Text = "FrmEmpleados"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnbuscar As Button
    Friend WithEvents cmbsexo As ComboBox
    Friend WithEvents dtpfechanac As DateTimePicker
    Friend WithEvents txtapellidos As TextBox
    Friend WithEvents txtnombres As TextBox
    Friend WithEvents txtDNI As TextBox
    Friend WithEvents txtNumEmpleado As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ckactivo As CheckBox
    Friend WithEvents cmbestadocivil As ComboBox
    Friend WithEvents txtcargo As TextBox
    Friend WithEvents txtdireccion As TextBox
    Friend WithEvents txtnivelacademico As TextBox
    Friend WithEvents txtcorreo As TextBox
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Cancelar As Button
    Friend WithEvents btnactualizar As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents eliminar As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents actualizar As Button
    Friend WithEvents guardar As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
