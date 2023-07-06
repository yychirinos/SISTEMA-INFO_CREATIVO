Imports System.Data.SqlClient

Public Class FrmUSUARIOS
    Private Sub btningresar_Click(sender As Object, e As EventArgs) Handles btningresar.Click
        Dim connectionString As String = "Data Source=LAPTOP-97BEOULP\SQLEXPRESS;Initial Catalog=INFO_CREATIVO;Integrated Security=True"

        ' Obtener los valores del formulario
        Dim ID As String = txtid.Text
        Dim nombre As String = txtnombre.Text
        Dim apellido As String = txtapellido.Text
        Dim telefono As String = txttelefono.Text
        Dim correo As String = txtcorreo.Text
        ' Crear la consulta SQL para insertar los datos
        Dim query As String = "INSERT INTO  REGISTROUSUARIO (id,nombre,apellido,telefono,correo) VALUES (@id,@nombre, @apellido, @telefono@correo)"

        ' Establecer la conexión con la base de datos
        Using connection As New SqlConnection(connectionString)
            ' Crear el objeto SqlCommand
            Using command As New SqlCommand(query, connection)
                ' Agregar parámetros a la consulta
                command.Parameters.AddWithValue("@id", ID)
                command.Parameters.AddWithValue("@Nombre", nombre)
                command.Parameters.AddWithValue("@apellido", apellido)
                command.Parameters.AddWithValue("@telefono", telefono)
                command.Parameters.AddWithValue("@correo", correo)
                ' Abrir la conexión
                connection.Open()

                ' Ejecutar la consulta
                command.ExecuteNonQuery()

                ' Cerrar la conexión
                connection.Close()
            End Using
        End Using

        ' Limpiar los campos del formulario después de guardar los datos
        txtid.Text = ""
        txtnombre.Text = ""
        txtapellido.Text = ""
        txttelefono.Text = ""
        txtcorreo.Text = ""
        MessageBox.Show("Datos guardados correctamente.")
    End Sub


End Class