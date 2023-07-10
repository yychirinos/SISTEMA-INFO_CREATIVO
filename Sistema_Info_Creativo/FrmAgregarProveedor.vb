Imports System.Data.SqlClient
Public Class FrmAgregarProveedor
    Public Event ProveedorAgregado As EventHandler
    Dim connectionString As String = "Data Source=HECTOR\SQLEXPRESS;Initial Catalog=proveedoresBD;Integrated Security=True"

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim resultado As DialogResult = MessageBox.Show("Salir sin agregar Proveedor?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resultado = DialogResult.Yes Then
            Dim frmProveedores As FrmProveedores = DirectCast(Application.OpenForms("FrmProveedores"), FrmProveedores)
            frmProveedores.CargarProveedores()
            Me.Dispose()
        End If
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        ' Validar que todos los campos estén llenos
        If String.IsNullOrWhiteSpace(txtIdProveedor.Text) OrElse
       String.IsNullOrWhiteSpace(txtNombreProveedor.Text) OrElse
       String.IsNullOrWhiteSpace(txtDireccionProveedor.Text) OrElse
       String.IsNullOrWhiteSpace(txtCiudadProveedor.Text) OrElse
       String.IsNullOrWhiteSpace(cboDepartamento.Text) OrElse
       String.IsNullOrWhiteSpace(txtTelefonoProveedor.Text) OrElse
       String.IsNullOrWhiteSpace(txtCorreoProveedor.Text) OrElse
       String.IsNullOrWhiteSpace(cboCategoriaProveedor.Text) Then
            MessageBox.Show("Por favor, Ingrese todos los datos!")
            Return
        End If

        Try
            Dim ID_PROVEEDOR As Integer
            If Integer.TryParse(txtIdProveedor.Text, ID_PROVEEDOR) Then
            Else
                MessageBox.Show("El valor ingresado en ID PROVEEDOR no es válido.")
                Return
            End If

            ' Obtener los valores de los campos de texto
            Dim NOMBRE_PROVEEDOR As String = txtNombreProveedor.Text
            Dim DEPARTAMENTO As String = cboDepartamento.Text
            Dim CIUDAD As String = txtCiudadProveedor.Text
            Dim DIRECCION As String = txtDireccionProveedor.Text
            Dim TELEFONO As String = txtTelefonoProveedor.Text
            Dim CORREO As String = txtCorreoProveedor.Text
            Dim CATEGORIA As String = cboCategoriaProveedor.Text

            ' Cadena de conexión
            Dim connectionString As String = "Data Source=HECTOR\SQLEXPRESS;Initial Catalog=proveedoresBD;Integrated Security=True"

            ' Consulta SQL para la inserción
            Dim query As String = "INSERT INTO Proveedores (ID_PROVEEDOR,NOMBRE_PROVEEDOR,DEPARTAMENTO,CIUDAD,DIRECCION,TELEFONO,CORREO,CATEGORIA) " &
                              "VALUES (@ID_PROVEEDOR,@NOMBRE_PROVEEDOR,@DEPARTAMENTO,@CIUDAD,@DIRECCION,@TELEFONO,@CORREO,@CATEGORIA)"

            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@ID_PROVEEDOR", ID_PROVEEDOR)
                    command.Parameters.AddWithValue("@NOMBRE_PROVEEDOR", NOMBRE_PROVEEDOR)
                    command.Parameters.AddWithValue("@DEPARTAMENTO", DEPARTAMENTO)
                    command.Parameters.AddWithValue("@CIUDAD", CIUDAD)
                    command.Parameters.AddWithValue("@DIRECCION", DIRECCION)
                    command.Parameters.AddWithValue("@TELEFONO", TELEFONO)
                    command.Parameters.AddWithValue("@CORREO", CORREO)
                    command.Parameters.AddWithValue("@CATEGORIA", CATEGORIA)

                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using

            LimpiarCampos()
            MsgBox("Nuevo Proveedor ingresado con éxito.")
            Me.Dispose()


        Catch ex As SqlException
            ' Manejo de excepciones de SQL
            Dim errorCollection As SqlErrorCollection = ex.Errors
            For Each sqlError As SqlError In errorCollection
                Console.WriteLine("Número de error: " & sqlError.Number)
                Console.WriteLine("Mensaje: " & sqlError.Message)
                Console.WriteLine("Estado: " & sqlError.State)
                Console.WriteLine("Procedimiento almacenado: " & sqlError.Procedure)
                Console.WriteLine("Línea: " & sqlError.LineNumber)
            Next

            ' Mostrar un mensaje de error al usuario u otra acción de manejo de errores
            MessageBox.Show("Proveedor ya existe!.")
        End Try
    End Sub

    Private Sub LimpiarCampos()
        ' Limpiar todos los campos de texto
        txtIdProveedor.Text = ""
        txtNombreProveedor.Text = ""
        txtDireccionProveedor.Text = ""
        txtCiudadProveedor.Text = ""
        cboDepartamento.Text = ""
        txtTelefonoProveedor.Text = ""
        txtCorreoProveedor.Text = ""
        cboCategoriaProveedor.Text = ""
    End Sub
End Class