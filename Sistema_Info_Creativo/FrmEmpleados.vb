Imports System.Data.SqlClient
Public Class FrmEmpleados
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click, guardar.Click
        If txtNumEmpleado.Text = "" Or txtnombres.Text = "" Or txtapellidos.Text = "" Or txtDNI.Text = "" Or txtdireccion.Text = "" Or txtcargo.Text = "" Or txtnivelacademico.Text = "" Then
            MessageBox.Show("debe llenar todos los campos")
        Else
            Dim con As SqlConnection = New SqlConnection(My.Settings.INFO_CREATIVO)
            Dim cmd As SqlCommand = New SqlCommand("sp_Empleados", con)
            con.Open()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@bandera", 1)
            cmd.Parameters.AddWithValue("@numempleado", txtNumEmpleado.Text)
            cmd.Parameters.AddWithValue("@dni", txtDNI.Text)
            cmd.Parameters.AddWithValue("@nombres", txtnombres.Text)
            cmd.Parameters.AddWithValue("@apellidos", txtapellidos.Text)
            cmd.Parameters.AddWithValue("@telefono", txttelefono.Text)
            cmd.Parameters.AddWithValue("@correo", txtcorreo.Text)
            cmd.Parameters.AddWithValue("@direccion", txtdireccion.Text)
            cmd.Parameters.AddWithValue("@cargo", txtcargo.Text)
            cmd.Parameters.AddWithValue("@sexo", cmbsexo.SelectedValue)
            cmd.Parameters.AddWithValue("@estadocivil", cmbestadocivil.SelectedValue)
            cmd.Parameters.AddWithValue("@nivelacademico", txtnivelacademico.Text)
            cmd.Parameters.AddWithValue("@fechanac", dtpfechanac.Value)
            Dim activo As Boolean
            If ckactivo.Checked = True Then
                activo = 1
            Else
                activo = 0
            End If

            cmd.Parameters.AddWithValue("@activo", activo)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Empleado guardado correctamente")

            con.Close()
        End If
    End Sub

    'CODIGO PARA LLENAR LA LISTA DESPLEGABLE DE SEXOS.
    Sub llenarcombosexo()
        Dim da As New SqlDataAdapter()
        Dim dt As New DataTable
        Dim con As New SqlConnection(My.Settings.INFO_CREATIVO)
        Try
            da = New SqlDataAdapter("select idsexo,descripcion from ListadoSexos", con)
            da.Fill(dt)
            cmbsexo.DataSource = dt
            cmbsexo.DisplayMember = "descripcion"
            cmbsexo.ValueMember = "idsexo"
        Catch ex As Exception

        End Try

    End Sub

    'CODIGO PARA LLENAR LA LISTA DESPLEGABLE DE ESTADO CIVIL.
    Sub llenarcomboestadocivil()
        Dim da As New SqlDataAdapter()
        Dim dt As New DataTable
        Dim con As New SqlConnection(My.Settings.INFO_CREATIVO)
        Try
            da = New SqlDataAdapter("select idestadocivil,desestadocivil from ListadoEstadoCivil", con)
            da.Fill(dt)
            cmbestadocivil.DataSource = dt
            cmbestadocivil.DisplayMember = "desestadocivil"
            cmbestadocivil.ValueMember = "idestadocivil"
        Catch ex As Exception

        End Try

    End Sub

    'CODIGO PARA LIMPIAR TODOS LOS CAMPOS.
    Sub limpiarcontroles()

        txtDNI.Text = ""
        txtnombres.Text = ""
        txtapellidos.Text = ""

        dtpfechanac.Value = System.DateTime.Today

        txttelefono.Text = ""
        txtcorreo.Text = ""
        txtdireccion.Text = ""
        txtcargo.Text = ""
        txtnivelacademico.Text = ""

        llenarcomboestadocivil()
        llenarcombosexo()

        ckactivo.Checked = False

        txtNumEmpleado.Focus()
    End Sub

    Private Sub actualizar_Click(sender As Object, e As EventArgs) Handles actualizar.Click
        If txtNumEmpleado.Text = "" Or txtnombres.Text = "" Or txtapellidos.Text = "" Or txtDNI.Text = "" Or txtdireccion.Text = "" Or txtcargo.Text = "" Or txtnivelacademico.Text = "" Then
            MessageBox.Show("Debe llenar todos los campos")
        Else

            Dim con As SqlConnection = New SqlConnection(My.Settings.INFO_CREATIVO)
            Dim cmd As SqlCommand = New SqlCommand("sp_Empleados", con)
            con.Open()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@bandera", 2)
            cmd.Parameters.AddWithValue("@numempleado", txtNumEmpleado.Text)
            cmd.Parameters.AddWithValue("@dni", txtDNI.Text)
            cmd.Parameters.AddWithValue("@nombres", txtnombres.Text)
            cmd.Parameters.AddWithValue("@apellidos", txtapellidos.Text)
            cmd.Parameters.AddWithValue("@telefono", txttelefono.Text)
            cmd.Parameters.AddWithValue("@correo", txtcorreo.Text)
            cmd.Parameters.AddWithValue("@direccion", txtdireccion.Text)
            cmd.Parameters.AddWithValue("@cargo", txtcargo.Text)
            cmd.Parameters.AddWithValue("@sexo", cmbsexo.SelectedValue)
            cmd.Parameters.AddWithValue("@estadocivil", cmbestadocivil.SelectedValue)
            cmd.Parameters.AddWithValue("@nivelacademico", txtnivelacademico.Text)
            cmd.Parameters.AddWithValue("@fechanac", dtpfechanac.Value)
            Dim activo As Boolean
            If ckactivo.Checked = True Then
                activo = 1
            Else
                activo = 0
            End If

            cmd.Parameters.AddWithValue("@activo", activo)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Empleado actualizado correctamente")
            limpiarcontroles()

            con.Close()
        End If


    End Sub

    Private Sub eliminar_Click(sender As Object, e As EventArgs) Handles eliminar.Click
        Dim con As New SqlConnection(My.Settings.INFO_CREATIVO)
        Dim cmd As SqlCommand = New SqlCommand("delete from Empleados
                                                    where numempleado=@numempleado", con)
        con.Open()
        cmd.CommandType = CommandType.Text
        cmd.Parameters.AddWithValue("@numempleado", txtNumEmpleado.Text)

        If MsgBox("Esta seguro de que quiere eliminar este empleado?", MsgBoxStyle.Information + vbYesNo) = vbYes Then
            cmd.ExecuteNonQuery()
            MessageBox.Show("Empleado eliminado correctamente")
            limpiarcontroles()
        End If
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        limpiarcontroles()
    End Sub



    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Dispose()
    End Sub

    Private Sub FrmEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        llenarcombosexo()
        llenarcomboestadocivil()
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Dim con As New SqlClient.SqlConnection(My.Settings.INFO_CREATIVO)
        con.Open()
        Dim reader As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand("Select * from Empleados where numempleado = '" & txtNumEmpleado.Text & "'", con)
        reader = cmd.ExecuteReader

        'LLENAR INFORMACION SI EXISTE EMPLEADO
        If reader.Read() Then
            txtDNI.Text = reader.Item("dni")
            txtnombres.Text = reader.Item("nombres")
            txtapellidos.Text = reader.Item("apellidos")
            dtpfechanac.Value = reader.Item("fechanac")
            cmbsexo.SelectedValue = reader.Item("sexo")

            txttelefono.Text = reader.Item("telefono")
            txtcorreo.Text = reader.Item("correo")
            txtnivelacademico.Text = reader.Item("nivelacademico")
            txtdireccion.Text = reader.Item("direccion")
            txtcargo.Text = reader.Item("cargo")
            cmbestadocivil.SelectedValue = reader.Item("estadocivil")

            If reader.Item("activo") = True Then
                ckactivo.Checked = True
            Else
                ckactivo.Checked = False
            End If

            btnactualizar.Enabled = True


        Else


            If MsgBox("Este Empleado no esta registrado en la base de datos, desea crearlo?", MsgBoxStyle.Information + vbYesNo) = vbYes Then
                btnguardar.Enabled = True

            Else
                Return
            End If
        End If
        con.Close()

    End Sub

End Class