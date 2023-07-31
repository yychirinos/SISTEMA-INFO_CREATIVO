Imports System.Data.SqlClient
Public Class FrmClientes
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If txtCodCliente.Text = "" Or txtNombreCliente.Text = "" Or txtapellidocliente.Text = "" Or Txtdnicliente.Text = "" Or txtdireccion.Text = "" Then
            MessageBox.Show("debe llenar todos los campos")
        Else
            Dim con As SqlConnection = New SqlConnection(My.Settings.INFO_CREATIVO)
            Dim cmd As SqlCommand = New SqlCommand("sp_Clientes", con)
            con.Open()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@bandera", 1)
            cmd.Parameters.AddWithValue("@codcliente", txtCodCliente.Text)
            cmd.Parameters.AddWithValue("@tipocliente", cmbtipocliente.SelectedValue)
            cmd.Parameters.AddWithValue("@nombres", txtNombreCliente.Text)
            cmd.Parameters.AddWithValue("@apellidos", txtapellidocliente.Text)
            cmd.Parameters.AddWithValue("@dni", Txtdnicliente.Text)
            cmd.Parameters.AddWithValue("@telefono", Txttelefono.Text)
            cmd.Parameters.AddWithValue("@correo", txtcorreo.Text)
            cmd.Parameters.AddWithValue("direccion", txtdireccion.Text)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Cliente guardado correctamente")

            con.Close()
        End If


    End Sub
    'CODIGO PARA LLENAR LA LISTA DESPLEGABLE DE TIPO DE CLIENTE.
    Sub llenarcombotipocliente()
        Dim da As New SqlDataAdapter()
        Dim dt As New DataTable
        Dim con As New SqlConnection(My.Settings.INFO_CREATIVO)
        Try
            da = New SqlDataAdapter("select idtipocliente,destipocliente from TipoCliente", con)
            da.Fill(dt)
            cmbtipocliente.DataSource = dt
            cmbtipocliente.DisplayMember = "destipocliente"
            cmbtipocliente.ValueMember = "idtipocliente"
        Catch ex As Exception

        End Try

    End Sub

    Private Sub FrmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarcombotipocliente()
        'llenargridclientes()
        LlenarGrifClientesFiltrado()


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
        If txtCodCliente.Text = "" Or txtNombreCliente.Text = "" Or txtapellidocliente.Text = "" Or Txtdnicliente.Text = "" Or txtdireccion.Text = "" Then
            MessageBox.Show("debe llenar todos los campos")
        Else
            Dim con As SqlConnection = New SqlConnection(My.Settings.INFO_CREATIVO)
            Dim cmd As SqlCommand = New SqlCommand("sp_Clientes", con)
            con.Open()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@bandera", 2)
            cmd.Parameters.AddWithValue("@codcliente", txtCodCliente.Text)
            cmd.Parameters.AddWithValue("@tipocliente", cmbtipocliente.SelectedValue)
            cmd.Parameters.AddWithValue("@nombres", txtNombreCliente.Text)
            cmd.Parameters.AddWithValue("@apellidos", txtapellidocliente.Text)
            cmd.Parameters.AddWithValue("@dni", Txtdnicliente.Text)
            cmd.Parameters.AddWithValue("@telefono", Txttelefono.Text)
            cmd.Parameters.AddWithValue("@correo", txtcorreo.Text)
            cmd.Parameters.AddWithValue("direccion", txtdireccion.Text)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Actualizacion correcta")

            con.Close()
        End If
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Dim con As New SqlClient.SqlConnection(My.Settings.INFO_CREATIVO)
        con.Open()
        Dim reader As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand("Select * from Clientes where codcliente = '" & txtCodCliente.Text & "'", con)
        reader = cmd.ExecuteReader

        'LLENAR INFORMACION SI YA EXISTE EL CLIENTE
        If reader.Read() Then
            cmbtipocliente.SelectedValue = reader.Item("tipocliente")
            txtNombreCliente.Text = reader.Item("nombres")
            txtapellidocliente.Text = reader.Item("apellidos")
            Txtdnicliente.Text = reader.Item("dni")
            Txttelefono.Text = reader.Item("telefono")
            txtcorreo.Text = reader.Item("correo")
            txtdireccion.Text = reader.Item("direccion")

            btnactualizar.Enabled = True


        Else


            If MsgBox("Este Cliente no esta registrado en la base de datos, desea crearlo?", MsgBoxStyle.Information + vbYesNo) = vbYes Then
                btnguardar.Enabled = True

            Else
                Return
            End If
        End If
        con.Close()

    End Sub
    Sub limpiarcontroles()


        txtNombreCliente.Text = ""
        txtapellidocliente.Text = ""
        Txtdnicliente.Text = ""
        Txttelefono.Text = ""
        txtcorreo.Text = ""
        txtdireccion.Text = ""

        llenarcombotipocliente()

        txtCodCliente.Focus()
    End Sub


    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Dim con As New SqlConnection(My.Settings.INFO_CREATIVO)
        Dim cmd As SqlCommand = New SqlCommand("delete from Clientes
                                                    where codcliente=@codcliente", con)
        con.Open()
        cmd.CommandType = CommandType.Text
        cmd.Parameters.AddWithValue("@codcliente", txtCodCliente.Text)

        If MsgBox("Esta seguro de que quiere eliminar este cliente?", MsgBoxStyle.Information + vbYesNo) = vbYes Then
            cmd.ExecuteNonQuery()
            MessageBox.Show("Cliente eliminado correctamente")
            limpiarcontroles()
        End If
    End Sub
    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        limpiarcontroles()
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Dispose()
        Frm_MenuPrincipal.ShowDialog()

    End Sub

    'Sub llenargridclientes()
    ' Dim con As New SqlConnection(My.Settings.INFO_CREATIVO)
    'Dim da As New SqlDataAdapter()
    'Dim dt As New DataTable
    'Try
    '   da = New SqlDataAdapter("select codcliente [Cod Cliente], Tipocliente [Tipo Cliente], Nombres, Apellidos,DNI, Telefono, Correo, Direccion from Clientes
    '", con)
    '           da.Fill(dt)
    '          DataGridClientes.DataSource = dt
    '
    'Catch ex As Exception

    'End Try
    'End Sub
    '.
    Sub LlenarGrifClientesFiltrado()
        Dim con As New SqlConnection(My.Settings.INFO_CREATIVO)
        Dim DT As DataTable
        Dim DA As New SqlDataAdapter
        Dim cmd As New SqlCommand
        con.Open()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT codcliente [Cod Cliente], Tipocliente [Tipo Cliente], Nombres, Apellidos,DNI, Telefono, Correo, Direccion
                          FROM Clientes Where codcliente like'%" & txtCodCliente.Text & "%'"

        cmd.ExecuteNonQuery()
        con.Close()
        DA.SelectCommand = cmd
        DT = New DataTable
        DA.Fill(DT)
        DataGridClientes.DataSource = DT
        DataGridClientes.AllowUserToAddRows = False
    End Sub

    Private Sub DataGridClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridClientes.CellContentClick

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txtCodCliente_TextChanged(sender As Object, e As EventArgs) Handles txtCodCliente.TextChanged
        If txtCodCliente.Text <> "" Then
            LlenarGrifClientesFiltrado()
        Else
            LlenarGrifClientesFiltrado()
        End If
    End Sub
End Class