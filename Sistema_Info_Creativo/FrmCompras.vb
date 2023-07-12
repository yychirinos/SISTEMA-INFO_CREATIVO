Imports System.Data.SqlClient
Public Class FrmCompras
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnregistrar.Click
        If txtidcompra.Text = "" Or txtidempleado.Text = "" Or txtidproveedor.Text = "" Or txtidarticulo.Text = "" Or txtarticulo.Text = "" Or txtprecioarticulo.Text = "" Or txtcantidadarticulo.Text = "" Or txttotal.Text = "" Then

            MessageBox.Show("Porvafor  llenar todos los campos")
        Else
            Dim con As SqlConnection = New SqlConnection(My.Settings.INFO_CREATIVO)
            Dim cmd As SqlCommand = New SqlCommand("sp_COMPRAS", con)
            con.Open()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@bandera", 1)
            cmd.Parameters.AddWithValue("@ID_COMPRA", txtidcompra.Text)
            cmd.Parameters.AddWithValue("@ID_EMPLEADO", txtidempleado.Text)
            cmd.Parameters.AddWithValue("@ID_PROVEEDOR", txtidproveedor.Text)
            cmd.Parameters.AddWithValue("@ID_ARTICULO", txtidarticulo.Text)
            cmd.Parameters.AddWithValue("@ARTICULO", txtarticulo.Text)
            cmd.Parameters.AddWithValue("@PRECIO_ARTICULO", txtprecioarticulo.Text)
            cmd.Parameters.AddWithValue("@CANTIDAD_ARTICULO", txtcantidadarticulo.Text)
            cmd.Parameters.AddWithValue("@FECHA_HORA ", dtpfecha.Value)
            cmd.Parameters.AddWithValue("@TOTAL", txttotal.Text)

            cmd.ExecuteNonQuery()
            MessageBox.Show("COMPRA REGISTRADA CORRECTAMENTE")
            con.Close()
        End If

    End Sub
    Sub llenardatagrigcompras()
        Dim con As New SqlConnection(My.Settings.INFO_CREATIVO)
        Dim da As New SqlDataAdapter()
        Dim dt As New DataTable
        Try
            da = New SqlDataAdapter("select * from COMPRAS", con)
            da.Fill(dt)
            datagridcompras.DataSource = dt

        Catch ex As Exception

        End Try
    End Sub
    Private Sub FrmCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenardatagrigcompras()
    End Sub

    Private Sub datagriv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
        If txtidcompra.Text = "" Or txtidempleado.Text = "" Or txtidproveedor.Text = "" Or txtidarticulo.Text = "" Or txtarticulo.Text = "" Or txtprecioarticulo.Text = "" Or txtcantidadarticulo.Text = "" Or txttotal.Text = "" Then

            MessageBox.Show("Porvafor  llenar todos los campos")
        Else

            Dim con As SqlConnection = New SqlConnection(My.Settings.INFO_CREATIVO)
            Dim cmd As SqlCommand = New SqlCommand("SP_COMPRAS", con)
            con.Open()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@BANDERA", 2)
            cmd.Parameters.AddWithValue("@ID_COMPRA", txtidcompra.Text)
            cmd.Parameters.AddWithValue("@ID_EMPLEADO", txtidempleado.Text)
            cmd.Parameters.AddWithValue("@ID_PROVEEDOR", txtidproveedor.Text)
            cmd.Parameters.AddWithValue("@ID_ARTICULO", txtidarticulo.Text)
            cmd.Parameters.AddWithValue("@ARTICULO", txtarticulo.Text)
            cmd.Parameters.AddWithValue("@PRECIO_ARTICULO", txtprecioarticulo.Text)
            cmd.Parameters.AddWithValue("@CANTIDAD_ARTICULO", txtcantidadarticulo.Text)
            cmd.Parameters.AddWithValue("@FECHA_HORA", dtpfecha.Value)
            cmd.Parameters.AddWithValue("@TOTAL", txttotal.Text)

            cmd.ExecuteNonQuery()
            MessageBox.Show("LOS DATOS SE ACTUALIZARON CORRECTAMENTE")
            limpiarcontroles()
            llenardatagrigcompras()
            con.Close()
        End If
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Dim con As New SqlConnection(My.Settings.INFO_CREATIVO)
        Dim cmd As SqlCommand = New SqlCommand("delete from COMPRAS
                                                  where ID_COMPRA=@ID_COMPRA", con)
        con.Open()
        cmd.CommandType = CommandType.Text
        cmd.Parameters.AddWithValue("@ID_COMPRA", txtidcompra.Text)

        If MsgBox("Esta seguro de que quiere eliminar este cliente?", MsgBoxStyle.Information + vbYesNo) = vbYes Then
            cmd.ExecuteNonQuery()
            MessageBox.Show("Cliente eliminado correctamente")
            limpiarcontroles()
        End If
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Dim con As New SqlClient.SqlConnection(My.Settings.INFO_CREATIVO)
        con.Open()
        Dim reader As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand("Select * from COMPRAS where ID_COMPRA= '" & txtidcompra.Text & "'", con)
        reader = cmd.ExecuteReader


        If reader.Read() Then

            txtidcompra.Text = reader.Item("id_compra")
            txtidempleado.Text = reader.Item("id_empleado")
            txtidproveedor.Text = reader.Item("id_proveedor")
            txtidarticulo.Text = reader.Item("id_articulo")
            txtprecioarticulo.Text = reader.Item("precio_articulo")
            txtarticulo.Text = reader.Item("articulo")
            txttotal.Text = reader.Item("total")
            txtcantidadarticulo.Text = reader.Item("cantidad_articulo")

            btnactualizar.Enabled = True


        Else


            If MsgBox("Este Cliente no esta registrado en la base de datos, desea crearlo?", MsgBoxStyle.Information + vbYesNo) = vbYes Then
                btnregistrar.Enabled = True

            Else
                Return
            End If
        End If
        con.Close()


    End Sub
    Sub limpiarcontroles()

        txtidcompra.Text = ""
        txtidempleado.Text = ""
        txtidproveedor.Text = ""
        txtidarticulo.Text = ""
        txtprecioarticulo.Text = ""
        txtarticulo.Text = ""
        txttotal.Text = ""
        txtcantidadarticulo.Text = ""

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Me.Dispose()
        Frm_MenuPrincipal.ShowDialog()
    End Sub

    Private Sub datagridcompras_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridcompras.CellContentClick

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        limpiarcontroles()
    End Sub

    Private Sub btntotal_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txtprecioarticulo_TextChanged(sender As Object, e As EventArgs) Handles txtprecioarticulo.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        txttotal.Text = Val(txtcantidadarticulo.Text) * Val(txtprecioarticulo.Text)
    End Sub

    Private Sub txtcantidadarticulo_TextChanged(sender As Object, e As EventArgs) Handles txtcantidadarticulo.TextChanged

    End Sub

    Private Sub txtarticulo_TextChanged(sender As Object, e As EventArgs) Handles txtarticulo.TextChanged

    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        txtcantidadarticulo.Clear()
        txtprecioarticulo.Clear()
        txttotal.Text = ""
        txtcantidadarticulo.Focus()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub txttotal_TextChanged(sender As Object, e As EventArgs) Handles txttotal.TextChanged

    End Sub
End Class