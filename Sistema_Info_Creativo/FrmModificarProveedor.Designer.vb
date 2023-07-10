<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificarProveedor
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtModificarId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtModificarNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboModificarCategoria = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboModificarDepartamento = New System.Windows.Forms.ComboBox()
        Me.txtModificarCiudad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtModificarCorreo = New System.Windows.Forms.TextBox()
        Me.txtModificarTelefono = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtModificarDireccion = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnCancelarModificar = New System.Windows.Forms.Button()
        Me.btnModificarDatos = New System.Windows.Forms.Button()
        Me.btnBuscarModificar = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Location = New System.Drawing.Point(-1, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(606, 58)
        Me.Panel1.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(138, 12)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(379, 32)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "MODIFICAR PROVEEDOR"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBuscarModificar)
        Me.GroupBox1.Controls.Add(Me.txtModificarId)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtModificarNombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cboModificarCategoria)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cboModificarDepartamento)
        Me.GroupBox1.Controls.Add(Me.txtModificarCiudad)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtModificarCorreo)
        Me.GroupBox1.Controls.Add(Me.txtModificarTelefono)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtModificarDireccion)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(577, 359)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Obligatorios :"
        '
        'txtModificarId
        '
        Me.txtModificarId.BackColor = System.Drawing.Color.White
        Me.txtModificarId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModificarId.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtModificarId.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtModificarId.Location = New System.Drawing.Point(169, 28)
        Me.txtModificarId.Name = "txtModificarId"
        Me.txtModificarId.Size = New System.Drawing.Size(324, 22)
        Me.txtModificarId.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(55, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 16)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "ID Proveedor :"
        '
        'txtModificarNombre
        '
        Me.txtModificarNombre.BackColor = System.Drawing.Color.White
        Me.txtModificarNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModificarNombre.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtModificarNombre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtModificarNombre.Location = New System.Drawing.Point(169, 66)
        Me.txtModificarNombre.Name = "txtModificarNombre"
        Me.txtModificarNombre.Size = New System.Drawing.Size(383, 22)
        Me.txtModificarNombre.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(14, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nombre Proveedor :"
        '
        'cboModificarCategoria
        '
        Me.cboModificarCategoria.BackColor = System.Drawing.Color.White
        Me.cboModificarCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboModificarCategoria.ForeColor = System.Drawing.SystemColors.InfoText
        Me.cboModificarCategoria.FormattingEnabled = True
        Me.cboModificarCategoria.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cboModificarCategoria.Items.AddRange(New Object() {"Accesorios para computadoras", "Componentes de hardware", "Periféricos", "Software", "Computadoras portátiles", "Computadoras de escritorio", "Tabletas", "Impresoras y escáneres", "Almacenamiento de datos", "Redes y conectividad"})
        Me.cboModificarCategoria.Location = New System.Drawing.Point(169, 321)
        Me.cboModificarCategoria.Name = "cboModificarCategoria"
        Me.cboModificarCategoria.Size = New System.Drawing.Size(383, 24)
        Me.cboModificarCategoria.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gray
        Me.Label8.Location = New System.Drawing.Point(78, 321)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 16)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Categoría :"
        '
        'cboModificarDepartamento
        '
        Me.cboModificarDepartamento.BackColor = System.Drawing.Color.White
        Me.cboModificarDepartamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboModificarDepartamento.ForeColor = System.Drawing.SystemColors.InfoText
        Me.cboModificarDepartamento.FormattingEnabled = True
        Me.cboModificarDepartamento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cboModificarDepartamento.Items.AddRange(New Object() {"Atlántida", "Colón", "Comayagua", "Copán", "Cortés", "El Paraíso", "Francisco Morazán", "Gracias a Dios", "Intibucá", "Islas de la Bahía", "La Paz", "Lempira", "Ocotepeque", "Olancho", "Santa Bárbara", "Valle", "Yoro"})
        Me.cboModificarDepartamento.Location = New System.Drawing.Point(169, 104)
        Me.cboModificarDepartamento.Name = "cboModificarDepartamento"
        Me.cboModificarDepartamento.Size = New System.Drawing.Size(383, 24)
        Me.cboModificarDepartamento.TabIndex = 12
        '
        'txtModificarCiudad
        '
        Me.txtModificarCiudad.BackColor = System.Drawing.Color.White
        Me.txtModificarCiudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModificarCiudad.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtModificarCiudad.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtModificarCiudad.Location = New System.Drawing.Point(169, 143)
        Me.txtModificarCiudad.Name = "txtModificarCiudad"
        Me.txtModificarCiudad.Size = New System.Drawing.Size(383, 22)
        Me.txtModificarCiudad.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(100, 279)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Correo :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gray
        Me.Label7.Location = New System.Drawing.Point(49, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Departamento :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(85, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Teléfono :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(98, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Ciudad :"
        '
        'txtModificarCorreo
        '
        Me.txtModificarCorreo.BackColor = System.Drawing.Color.White
        Me.txtModificarCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModificarCorreo.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtModificarCorreo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtModificarCorreo.Location = New System.Drawing.Point(169, 279)
        Me.txtModificarCorreo.Name = "txtModificarCorreo"
        Me.txtModificarCorreo.Size = New System.Drawing.Size(383, 22)
        Me.txtModificarCorreo.TabIndex = 5
        '
        'txtModificarTelefono
        '
        Me.txtModificarTelefono.BackColor = System.Drawing.Color.White
        Me.txtModificarTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModificarTelefono.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtModificarTelefono.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtModificarTelefono.Location = New System.Drawing.Point(169, 239)
        Me.txtModificarTelefono.Name = "txtModificarTelefono"
        Me.txtModificarTelefono.Size = New System.Drawing.Size(383, 22)
        Me.txtModificarTelefono.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(80, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Dirección :"
        '
        'txtModificarDireccion
        '
        Me.txtModificarDireccion.BackColor = System.Drawing.Color.White
        Me.txtModificarDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModificarDireccion.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtModificarDireccion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtModificarDireccion.Location = New System.Drawing.Point(169, 180)
        Me.txtModificarDireccion.Multiline = True
        Me.txtModificarDireccion.Name = "txtModificarDireccion"
        Me.txtModificarDireccion.Size = New System.Drawing.Size(383, 40)
        Me.txtModificarDireccion.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnCancelarModificar)
        Me.GroupBox2.Controls.Add(Me.btnModificarDatos)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 481)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(577, 73)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        '
        'btnCancelarModificar
        '
        Me.btnCancelarModificar.BackColor = System.Drawing.Color.DarkOrange
        Me.btnCancelarModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelarModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelarModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarModificar.ForeColor = System.Drawing.Color.White
        Me.btnCancelarModificar.Location = New System.Drawing.Point(211, 19)
        Me.btnCancelarModificar.Name = "btnCancelarModificar"
        Me.btnCancelarModificar.Size = New System.Drawing.Size(147, 40)
        Me.btnCancelarModificar.TabIndex = 18
        Me.btnCancelarModificar.Text = "Cancelar"
        Me.btnCancelarModificar.UseVisualStyleBackColor = False
        '
        'btnModificarDatos
        '
        Me.btnModificarDatos.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnModificarDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnModificarDatos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificarDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarDatos.ForeColor = System.Drawing.Color.White
        Me.btnModificarDatos.Location = New System.Drawing.Point(405, 19)
        Me.btnModificarDatos.Name = "btnModificarDatos"
        Me.btnModificarDatos.Size = New System.Drawing.Size(147, 40)
        Me.btnModificarDatos.TabIndex = 16
        Me.btnModificarDatos.Text = "Aplicar Cambios"
        Me.btnModificarDatos.UseVisualStyleBackColor = False
        '
        'btnBuscarModificar
        '
        Me.btnBuscarModificar.BackColor = System.Drawing.Color.Transparent
        Me.btnBuscarModificar.BackgroundImage = Global.Sistema_Info_Creativo.My.Resources.Resources._5c790123003fa702a1d2795b2
        Me.btnBuscarModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscarModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscarModificar.Location = New System.Drawing.Point(513, 19)
        Me.btnBuscarModificar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscarModificar.Name = "btnBuscarModificar"
        Me.btnBuscarModificar.Size = New System.Drawing.Size(39, 40)
        Me.btnBuscarModificar.TabIndex = 18
        Me.btnBuscarModificar.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = Global.Sistema_Info_Creativo.My.Resources.Resources.LOGOTIPO_INFO_CREATIVE3
        Me.PictureBox3.Location = New System.Drawing.Point(536, 0)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(65, 66)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 26
        Me.PictureBox3.TabStop = False
        '
        'FrmModificarProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(601, 595)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.Name = "FrmModificarProveedor"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Proveedor"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnBuscarModificar As Button
    Friend WithEvents txtModificarId As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtModificarNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cboModificarCategoria As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cboModificarDepartamento As ComboBox
    Friend WithEvents txtModificarCiudad As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtModificarCorreo As TextBox
    Friend WithEvents txtModificarTelefono As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtModificarDireccion As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnCancelarModificar As Button
    Friend WithEvents btnModificarDatos As Button
End Class
