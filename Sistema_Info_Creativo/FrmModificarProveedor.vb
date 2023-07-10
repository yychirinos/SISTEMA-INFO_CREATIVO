Imports System.Data.SqlClient
Public Class FrmModificarProveedor
    Private proveedorID As Integer
    Dim connectionString As String = "Data Source=HECTOR\SQLEXPRESS;Initial Catalog=proveedoresBD;Integrated Security=True"

    Private Sub btnBuscarModificar_Click(sender As Object, e As EventArgs) Handles btnBuscarModificar.Click
        Dim proveedorID As Integer

        If Integer.TryParse(txtModificarId.Text, proveedorID) Then
            ' La conversión fue exitosa, utilizar el valor de proveedorID
            Me.proveedorID = proveedorID
        Else
            ' La conversión falló, mostrar un mensaje de error al usuario
            MessageBox.Show("El valor ingresado en ID Proveedor no es válido.")
            Return
        End If

        ' Consultar la base de datos para obtener los datos del cliente
        Dim query As String = "SELECT * FROM Proveedores WHERE ID_PROVEEDOR = @ID_PROVEEDOR"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@ID_PROVEEDOR", proveedorID)

                connection.Open()
                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        ' Mostrar los datos del cliente en los campos de texto
                        txtModificarNombre.Text = reader("NOMBRE_PROVEEDOR").ToString()
                        cboModificarDepartamento.Text = reader("DEPARTAMENTO").ToString()
                        txtModificarCiudad.Text = reader("CIUDAD").ToString()
                        txtModificarDireccion.Text = reader("DIRECCION").ToString()
                        txtModificarTelefono.Text = reader("TELEFONO").ToString()
                        txtModificarCorreo.Text = reader("CORREO").ToString()
                        cboModificarCategoria.Text = reader("CATEGORIA").ToString()
                        txtModificarId.Enabled = False
                    Else
                        MsgBox("Cliente no encontrado.")
                        txtModificarId.Select()
                        txtModificarId.Text = ""
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub btnModificarDatos_Click(sender As Object, e As EventArgs) Handles btnModificarDatos.Click
        ' Validar que todos los campos estén llenos
        If String.IsNullOrWhiteSpace(txtModificarId.Text) OrElse
       String.IsNullOrWhiteSpace(txtModificarNombre.Text) OrElse
       String.IsNullOrWhiteSpace(txtModificarDireccion.Text) OrElse
       String.IsNullOrWhiteSpace(txtModificarCiudad.Text) OrElse
       String.IsNullOrWhiteSpace(cboModificarDepartamento.Text) OrElse
       String.IsNullOrWhiteSpace(txtModificarTelefono.Text) OrElse
       String.IsNullOrWhiteSpace(txtModificarCorreo.Text) OrElse
       String.IsNullOrWhiteSpace(cboModificarCategoria.Text) Then
            MessageBox.Show("Por favor, Ingrese todos los datos!")
            Return
        End If

        ' Obtener los nuevos valores de los campos de texto
        Dim nuevoNombre As String = txtModificarNombre.Text
        Dim nuevoDepartamento As String = cboModificarDepartamento.Text
        Dim nuevaCiudad As String = txtModificarCiudad.Text
        Dim nuevaDireccion As String = txtModificarDireccion.Text
        Dim nuevoTelefono As String = txtModificarTelefono.Text
        Dim nuevoCorreo As String = txtModificarCorreo.Text
        Dim nuevaCategoria As String = cboModificarCategoria.Text

        ' Cadena de conexión
        Dim connectionString As String = "Data Source=HECTOR\SQLEXPRESS;Initial Catalog=proveedoresBD;Integrated Security=True"

        ' Consulta SQL para llamar al procedimiento almacenado de actualización
        Dim query As String = "Update Proveedores
	set ID_PROVEEDOR = @ID_PROVEEDOR, NOMBRE_PROVEEDOR = @NOMBRE_PROVEEDOR, 
	DEPARTAMENTO = @DEPARTAMENTO, CIUDAD = @CIUDAD, DIRECCION = @DIRECCION, 
	TELEFONO = @TELEFONO, CORREO = @CORREO, CATEGORIA = @CATEGORIA
	where ID_PROVEEDOR = @ID_PROVEEDOR"

        ' Establecer la conexión y ejecutar la consulta
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                ' Asignar los parámetros al comando SQL
                command.Parameters.AddWithValue("@ID_PROVEEDOR", proveedorID)
                command.Parameters.AddWithValue("@NOMBRE_PROVEEDOR", nuevoNombre)
                command.Parameters.AddWithValue("@DEPARTAMENTO", nuevoDepartamento)
                command.Parameters.AddWithValue("@CIUDAD", nuevaCiudad)
                command.Parameters.AddWithValue("@DIRECCION", nuevaDireccion)
                command.Parameters.AddWithValue("@TELEFONO", nuevoTelefono)
                command.Parameters.AddWithValue("@CORREO", nuevoCorreo)
                command.Parameters.AddWithValue("@CATEGORIA", nuevaCategoria)

                connection.Open()
                command.ExecuteNonQuery()

                ' Mostrar mensaje de éxito
                MessageBox.Show("El Proveedor se Modificó correctamente!.")
                Me.Dispose()
            End Using
        End Using
    End Sub

    Private Sub FrmModificarProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtModificarId.Select()
    End Sub

    Private Sub btnCancelarModificar_Click(sender As Object, e As EventArgs) Handles btnCancelarModificar.Click
        Dim resultado As DialogResult = MessageBox.Show("Salir sin hacer cambios?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resultado = DialogResult.Yes Then
            Me.Dispose()
        End If
    End Sub
End Class