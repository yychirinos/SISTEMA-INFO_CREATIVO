<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUSUARIOS
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
        Me.txtcorreo = New System.Windows.Forms.TextBox()
        Me.txtcontrasena = New System.Windows.Forms.TextBox()
        Me.txidusuario = New System.Windows.Forms.TextBox()
        Me.txtnumempleado = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btningresar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtnivelacceso = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtestadoactivo = New System.Windows.Forms.TextBox()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NumEmpleados "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "IDUSUARIO"
        '
        'txtcorreo
        '
        Me.txtcorreo.Location = New System.Drawing.Point(154, 266)
        Me.txtcorreo.Multiline = True
        Me.txtcorreo.Name = "txtcorreo"
        Me.txtcorreo.Size = New System.Drawing.Size(239, 26)
        Me.txtcorreo.TabIndex = 10
        '
        'txtcontrasena
        '
        Me.txtcontrasena.Location = New System.Drawing.Point(163, 200)
        Me.txtcontrasena.Name = "txtcontrasena"
        Me.txtcontrasena.Size = New System.Drawing.Size(100, 22)
        Me.txtcontrasena.TabIndex = 8
        '
        'txidusuario
        '
        Me.txidusuario.Location = New System.Drawing.Point(163, 150)
        Me.txidusuario.Name = "txidusuario"
        Me.txidusuario.Size = New System.Drawing.Size(100, 22)
        Me.txidusuario.TabIndex = 7
        '
        'txtnumempleado
        '
        Me.txtnumempleado.Location = New System.Drawing.Point(163, 110)
        Me.txtnumempleado.Name = "txtnumempleado"
        Me.txtnumempleado.Size = New System.Drawing.Size(100, 22)
        Me.txtnumempleado.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 269)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "CORREO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "CONTRASEÑA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 16)
        Me.Label3.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Location = New System.Drawing.Point(12, 11)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(574, 66)
        Me.Panel1.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(162, 16)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "REGISTRE SU USUARIO"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Niagara Engraved", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(4, 10)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 29)
        Me.Label10.TabIndex = 24
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Blue
        Me.PictureBox3.Image = Global.Sistema_Info_Creativo.My.Resources.Resources.WhatsApp_Image_2023_06_17_at_7_59_24_PM
        Me.PictureBox3.Location = New System.Drawing.Point(424, 0)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(148, 66)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 23
        Me.PictureBox3.TabStop = False
        '
        'btningresar
        '
        Me.btningresar.BackgroundImage = Global.Sistema_Info_Creativo.My.Resources.Resources.png_transparent_computer_icons_button_register_button_blue_text_rectangle_thumbnail
        Me.btningresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btningresar.Location = New System.Drawing.Point(12, 469)
        Me.btningresar.Name = "btningresar"
        Me.btningresar.Size = New System.Drawing.Size(159, 62)
        Me.btningresar.TabIndex = 5
        Me.btningresar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(33, 347)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 16)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "NIVEL ACCESO"
        '
        'txtnivelacceso
        '
        Me.txtnivelacceso.Location = New System.Drawing.Point(163, 341)
        Me.txtnivelacceso.Name = "txtnivelacceso"
        Me.txtnivelacceso.Size = New System.Drawing.Size(100, 22)
        Me.txtnivelacceso.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(31, 409)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 16)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "ESTADO ACTIVO"
        '
        'txtestadoactivo
        '
        Me.txtestadoactivo.Location = New System.Drawing.Point(163, 403)
        Me.txtestadoactivo.Name = "txtestadoactivo"
        Me.txtestadoactivo.Size = New System.Drawing.Size(100, 22)
        Me.txtestadoactivo.TabIndex = 14
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(197, 469)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(107, 62)
        Me.btnsalir.TabIndex = 15
        Me.btnsalir.Text = "SALIR "
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'FrmUSUARIOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 535)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.txtestadoactivo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtnivelacceso)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btningresar)
        Me.Controls.Add(Me.txtcorreo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtcontrasena)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txidusuario)
        Me.Controls.Add(Me.txtnumempleado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Name = "FrmUSUARIOS"
        Me.Text = "FrmUSUARIOS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btningresar As Button
    Friend WithEvents txtcorreo As TextBox
    Friend WithEvents txtcontrasena As TextBox
    Friend WithEvents txidusuario As TextBox
    Friend WithEvents txtnumempleado As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtnivelacceso As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtestadoactivo As TextBox
    Friend WithEvents btnsalir As Button
End Class
