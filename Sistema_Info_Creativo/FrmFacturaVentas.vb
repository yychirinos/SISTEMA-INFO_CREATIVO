Imports System.Data.SqlClient
Public Class FrmFacturaVentas
    Private cmbFactura As Object
    Public Property ModuloVariablesPublicas As Object

    Private Sub FrmFacturaVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarComboProductos()
        llenardgvFactura()
        LlenarGrifFacturaFiltrado()
        limpiarcontroles()
    End Sub

    Private Sub limpiarcontroles()
        txtnumfactura.Text = ""
        cmbproducto.SelectedValue = ""
        txtidcliente.Text = ""
        txtidusuario.Text = ""
        txtprecio.Text = ""
        txtcantidad.Text = ""
        txtdescuento.Text = ""
        txttotal.Text = ""
    End Sub

    Sub LlenarComboProductos()
        Dim con As New SqlConnection(My.Settings.INFO_CREATIVO)
        Dim DT As DataTable
        Dim DA As New SqlDataAdapter
        Dim cmd As New SqlCommand
        con.Open()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT ID_PRODUCTO,NOMBRE_PRODUCTO FROM PRODUCTOS"
        cmd.ExecuteNonQuery()
        con.Close()
        DA.SelectCommand = cmd
        DT = New DataTable
        DA.Fill(DT)
        cmbproducto.DataSource = DT
        cmbproducto.DisplayMember = "IdProducto"
        cmbproducto.ValueMember = "NOMBRE_PRODUCTO"


    End Sub
    Sub llenardgvFactura()
        Dim con As New SqlConnection(My.Settings.INFO_CREATIVO)
        Dim da As New SqlDataAdapter()
        Dim dt As New DataTable
        Try
            da = New SqlDataAdapter("select * from Factura", con)
            da.Fill(dt)
            dgvFactura.DataSource = dt

        Catch ex As Exception

        End Try
    End Sub
    Sub LlenarGrifFacturaFiltrado()
        Dim con As New SqlConnection(My.Settings.INFO_CREATIVO)
        Dim DT As DataTable
        Dim DA As New SqlDataAdapter
        Dim cmd As New SqlCommand
        con.Open()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT NumFactura ,Producto ,IdCliente,IdUsuario,Fecha ,Precio,Descuento ,Cantidad
                                   ,Total
                          FROM Factura Where Producto like'%" & txtbuscarpro.Text & "%'"
        cmd.ExecuteNonQuery()
        con.Close()
        DA.SelectCommand = cmd
        DT = New DataTable
        DA.Fill(DT)
        dgvFactura.DataSource = DT
        dgvFactura.AllowUserToAddRows = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles Cmbagregar.Enter

    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        If txtnumfactura.Text = "" Or cmbproducto.Text = "" Or txtidcliente.Text = "" Or txtidusuario.Text = "" Or txtprecio.Text = "" Or txtcantidad.Text = "" Or txtdescuento.Text = "" Or txttotal.Text = "" Then

            MessageBox.Show("Porvafor  llenar todos los campos")
        Else
            Dim con As SqlConnection = New SqlConnection(My.Settings.INFO_CREATIVO)
            Dim cmd As SqlCommand = New SqlCommand("sp_Factura", con)
            con.Open()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@bandera", 1)
            cmd.Parameters.AddWithValue("@NumFactura", txtnumfactura.Text)
            cmd.Parameters.AddWithValue("@Producto", cmbproducto.SelectedValue)
            cmd.Parameters.AddWithValue("@IdCliente", txtidcliente.Text)
            cmd.Parameters.AddWithValue("@IdUsuario", txtidusuario.Text)
            cmd.Parameters.AddWithValue("@Fecha", dtfecha.Value)
            cmd.Parameters.AddWithValue("@Precio", txtprecio.Text)
            cmd.Parameters.AddWithValue("@Cantidad", txtcantidad.Text)
            cmd.Parameters.AddWithValue("@Descuento", txtdescuento.Text)
            cmd.Parameters.AddWithValue("@Total", txttotal.Text)


            cmd.ExecuteNonQuery()
            MessageBox.Show("FACTURA REGISTRADA CORRECTAMENTE")
            con.Close()
        End If
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim pre, Can, desc, tot As Double
        pre = Val(txtprecio.Text)
        Can = Val(txtcantidad.Text)
        pre = pre * Can
        desc = pre * 0.15
        tot = pre - desc
        'txttotal.Text = Val(txtprecio.Text) * Val(txtcantidad.Text) = Val(txtdescuento.Text = txtprecio.Text * 0.155)
        '' MessageBox.Show("El Total A Pagar es " & tot)
        txttotal.Text = txtprecio.Text * txtcantidad.Text - txtdescuento.Text
    End Sub

    Private Sub GroupBox1_Enter_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub txtbuscarpro_TextChanged(sender As Object, e As EventArgs) Handles txtbuscarpro.TextChanged
        If txtbuscarpro.Text <> "" Then
            LlenarGrifFacturaFiltrado()
        Else
            LlenarGrifFacturaFiltrado()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If txtnumfactura.Text = "" Or cmbproducto.Text = "" Or txtidcliente.Text = "" Or txtidusuario.Text = "" Or txtprecio.Text = "" Or txtcantidad.Text = "" Or txtdescuento.Text = "" Or txttotal.Text = "" Then

            MessageBox.Show("Porvafor  llenar todos los campos")
        Else
            Dim con As SqlConnection = New SqlConnection(My.Settings.INFO_CREATIVO)
            Dim cmd As SqlCommand = New SqlCommand("sp_Factura", con)
            con.Open()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@bandera", 2)
            cmd.Parameters.AddWithValue("@NumFactura", txtnumfactura.Text)
            cmd.Parameters.AddWithValue("@Producto", cmbproducto.SelectedValue)
            cmd.Parameters.AddWithValue("@IdCliente", txtidcliente.Text)
            cmd.Parameters.AddWithValue("@IdUsuario", txtidusuario.Text)
            cmd.Parameters.AddWithValue("@Fecha", dtfecha.Value)
            cmd.Parameters.AddWithValue("@Precio", txtprecio.Text)
            cmd.Parameters.AddWithValue("@Cantidad", txtcantidad.Text)
            cmd.Parameters.AddWithValue("@Descuento", txtdescuento.Text)
            cmd.Parameters.AddWithValue("@Total", txttotal.Text)


            cmd.ExecuteNonQuery()
            MessageBox.Show("FACTURA ACTUALIZADA CORRECTAMENTE")
            limpiarcontroles()
            llenardgvFactura()
            con.Close()
        End If
    End Sub

    Private Sub dgvFactura_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFactura.CellContentDoubleClick

    End Sub

    Private Sub dgvFactura_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFactura.CellClick


    End Sub
End Class