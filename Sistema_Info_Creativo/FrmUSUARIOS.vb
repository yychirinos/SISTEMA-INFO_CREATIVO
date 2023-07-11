Imports System.Data.SqlClient

Public Class FrmUSUARIOS
    Private Sub guardar_Click(sender As Object, e As EventArgs) Handles guardar.Click
        If txtnumempleado.Text = "" Or txtusuario.Text = "" Or txtcontraseña.Text = "" Or txtcorreo.Text = "" Or txtnivelacceso.Text = "" Then
            MessageBox.Show("debe llenar todos los campos")
        Else
            Dim con As SqlConnection = New SqlConnection(My.Settings.INFO_CREATIVO)
            Dim cmd As SqlCommand = New SqlCommand("sp_REGISTROUSUARIO", con)
            con.Open()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@bandera", 1)
            cmd.Parameters.AddWithValue("@numempleado", txtnumempleado.Text)
            cmd.Parameters.AddWithValue("@idusuario", txtusuario.Text)
            cmd.Parameters.AddWithValue("@contrasena", txtcontraseña.Text)
            cmd.Parameters.AddWithValue("@correo", txtcorreo.Text)
            cmd.Parameters.AddWithValue("@nivelacceso", txtnivelacceso.Text)

            Dim activo As Boolean
            If ckactivo.Checked = True Then
                activo = 1
            Else
                activo = 0
            End If

            cmd.Parameters.AddWithValue("@estadoactivo", activo)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Usuario guardado correctamente")

            con.Close()
        End If
    End Sub

    Private Sub actualizar_Click(sender As Object, e As EventArgs) Handles actualizar.Click
        If txtnumempleado.Text = "" Or txtusuario.Text = "" Or txtcontraseña.Text = "" Or txtcorreo.Text = "" Or txtnivelacceso.Text = "" Then
            MessageBox.Show("debe llenar todos los campos")
        Else
            Dim con As SqlConnection = New SqlConnection(My.Settings.INFO_CREATIVO)
            Dim cmd As SqlCommand = New SqlCommand("sp_REGISTROUSUARIO", con)
            con.Open()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@bandera", 2)
            cmd.Parameters.AddWithValue("@numempleado", txtnumempleado.Text)
            cmd.Parameters.AddWithValue("@idusuario", txtusuario.Text)
            cmd.Parameters.AddWithValue("@contrasena", txtcontraseña.Text)
            cmd.Parameters.AddWithValue("@correo", txtcorreo.Text)
            cmd.Parameters.AddWithValue("@nivelacceso", txtnivelacceso.Text)

            Dim activo As Boolean
            If Ckactivo.Checked = True Then
                activo = 1
            Else
                activo = 0
            End If

            cmd.Parameters.AddWithValue("@estadoactivo", activo)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Usuario actualizado correctamente")

            con.Close()
        End If
    End Sub
    Sub limpiarcontroles()

        txtusuario.Text = ""
        txtcontraseña.Text = ""
        txtcorreo.Text = ""
        txtnivelacceso.Text = ""

        Ckactivo.Checked = False

        txtnumempleado.Focus()
    End Sub

    Private Sub eliminar_Click(sender As Object, e As EventArgs) Handles eliminar.Click
        Dim con As New SqlConnection(My.Settings.INFO_CREATIVO)
        Dim cmd As SqlCommand = New SqlCommand("delete from REGISTROUSUARIO
                                                    where numempleado=@numempleado", con)
        con.Open()
        cmd.CommandType = CommandType.Text
        cmd.Parameters.AddWithValue("@numempleado", txtnumempleado.Text)

        If MsgBox("Esta seguro de que quiere eliminar este empleado?", MsgBoxStyle.Information + vbYesNo) = vbYes Then
            cmd.ExecuteNonQuery()
            MessageBox.Show("Usuario eliminado correctamente")
            limpiarcontroles()
        End If

    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        limpiarcontroles()

    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Dispose()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim con As New SqlClient.SqlConnection(My.Settings.INFO_CREATIVO)
        con.Open()
        Dim reader As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand("Select * from REGISTROUSUARIO where numempleado = '" & txtnumempleado.Text & "'", con)
        reader = cmd.ExecuteReader

        'LLENAR INFORMACION SI EXISTE EMPLEADO
        If reader.Read() Then
            txtusuario.Text = reader.Item("idusuario")
            txtcontraseña.Text = reader.Item("contrasena")
            txtcorreo.Text = reader.Item("correo")
            txtnivelacceso.Text = reader.Item("nivelacceso")
            txtcorreo.Text = reader.Item("correo")


            If reader.Item("estadoactivo") = True Then
                Ckactivo.Checked = True
            Else
                Ckactivo.Checked = False
            End If

            actualizar.Enabled = True


        Else


            If MsgBox("Este Usuario no esta registrado en la base de datos, desea crearlo?", MsgBoxStyle.Information + vbYesNo) = vbYes Then
                guardar.Enabled = True

            Else
                Return
            End If
        End If
        con.Close()

    End Sub

End Class