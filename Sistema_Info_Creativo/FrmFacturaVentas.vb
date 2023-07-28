Imports System.Data.SqlClient
Public Class FrmFacturaVentas
    Private Sub FrmFacturaVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles Cmbagregar.Enter

    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        If txtnumfactura.Text = "" Or cmbproducto.Text = "" Or txtidcliente.Text = "" Or txtidusuario.Text = "" Or txtprecio.Text = "" Or txtcantidad.Text = Or txtdescuento.Text = "" Or txttotal.Text = "" Then

            MessageBox.Show("Porvafor  llenar todos los campos")
        Else
            Dim con As SqlConnection = New SqlConnection(My.Settings.INFO_CREATIVO)
            Dim cmd As SqlCommand = New SqlCommand("sp_Factura", con)
            con.Open()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@bandera", 1)
            cmd.Parameters.AddWithValue("@NumFactura", txtnumfactura.Text)
            cmd.Parameters.AddWithValue("@Producto", cmbproducto.SelectedValue.Item)
            cmd.Parameters.AddWithValue("@IdCliente", txtidcliente.Text)
            cmd.Parameters.AddWithValue("@IdUsuario", txtidusuario.Text)
            cmd.Parameters.AddWithValue("@Fecha", dtfecha.Value)
            cmd.Parameters.AddWithValue("@Precio", txtprecio.Text)
            cmd.Parameters.AddWithValue("@Descuento", txtdescuento.Text)
            cmd.Parameters.AddWithValue("@Total", txttotal.Text)

            cmd.ExecuteNonQuery()
            MessageBox.Show("FACTURA REGISTRADA CORRECTAMENTE")
            con.Close()
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class