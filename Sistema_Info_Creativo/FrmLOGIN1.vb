Imports System.Data.SqlClient
Public Class Frmlogin
    Private Sub FrmLOGIN1_Click(sender As Object, e As EventArgs) Handles MyBase.Click

    End Sub

    Private Sub Btningresar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtcontrasena_TextChanged(sender As Object, e As EventArgs) Handles txtcontrasena.TextChanged

    End Sub

    Private Sub FrmLOGIN1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btningresar_Click_1(sender As Object, e As EventArgs) Handles btningresar.Click
        Dim con As New SqlClient.SqlConnection(My.Settings.INFO_CREATIVO)
        con.Open()
        Dim reader As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand("SELECT REGISTROUSUARIO, contrasena FROM  USUARIO Where USUARIO = '" & txtusuario.Text & "' and contrasena = '" & txtcontrasena.Text & "' and estadoactivo = 1", con)

        reader = cmd.ExecuteReader

        If reader.Read Then
            MessageBox.Show("Bienvenido '" & txtusuario.Text & "'")
        Else
            MessageBox.Show("Usuario o contraseña incorrectos")

        End If
    End Sub
End Class

