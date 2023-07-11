Imports System.Data.SqlClient

Public Class FrmUSUARIOS
    Private Sub btningresar_Click(sender As Object, e As EventArgs) Handles btningresar.Click
        Dim connectionString As String = "Data Source=LAPTOP-97BEOULP\SQLEXPRESS;Initial Catalog=INFO_CREATIVO;Integrated Security=True"

        ' Obtener los valores del formulario
        Dim NumEmpleado As String = txtnumempleado.Text
        Dim idusuario As String = txidusuario.Text
        Dim contraseña As String = txtcontrasena.Text
        Dim correo As String = txtcorreo.Text
        Dim nivelacceso As String = txtnivelacceso.Text
        Dim estadoactivo As String = txtestadoactivo.Text
        ' Crear la consulta SQL para insertar los datos
        Dim query As String = "INSERT INTO  REGISTROUSUARIO (numempleado,idusuario,contrasena ,correo,vivelacceso,estadoactivo) VALUES (@numepleado,@idusuario, @contrasena,@correo @nivelacceso,@estadoactivo)"

        ' Establecer la conexión con la base de datos
        Using connection As New SqlConnection(connectionString)
            ' Crear el objeto SqlCommand
            Using command As New SqlCommand(query, connection)
                ' Agregar parámetros a la consulta
                command.Parameters.AddWithValue("@numempleado", NumEmpleado)
                command.Parameters.AddWithValue("@idusuario", idusuario)
                command.Parameters.AddWithValue("@contrasena", contraseña)
                command.Parameters.AddWithValue("@correo", correo)
                command.Parameters.AddWithValue("@nivelacceso", nivelacceso)
                command.Parameters.AddWithValue("@estadoactivo", estadoactivo)
                ' Abrir la conexión
                connection.Open()

                ' Ejecutar la consulta
                command.ExecuteNonQuery()

                ' Cerrar la conexión
                connection.Close()
            End Using
        End Using

        ' Limpiar los campos del formulario después de guardar los datos
        txtnumempleado.Text = ""
        txidusuario.Text = ""
        txtcontrasena.Text = ""
        txtcorreo.Text = ""
        txtnivelacceso.Text = ""
        txtestadoactivo.Text = ""
        MessageBox.Show("Datos guardados correctamente.")
    End Sub


End Class