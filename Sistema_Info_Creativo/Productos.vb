Imports System.Data.SqlClient
Public Class Productos
    Dim connectionString As String = "Data Source=DESKTOP-50ALDBO;Initial Catalog=InfoCreativos;Integrated Security=True"
    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InfoCreativosDataSet.Productos' table. You can move, or remove it, as needed.
        Me.ProductosTableAdapter.Fill(Me.InfoCreativosDataSet.Productos)
        llenarGridProductos()
    End Sub


    Private ProductoBindingsource As New BindingSource()
    Sub llenarGridProductos()
        Dim consulta As String = "SELECT * FROM Productos"
        Dim adapter As New SqlDataAdapter(consulta, connectionString)
        Dim dt As New DataTable
        adapter.Fill(dt)
        dgvproductos.DataSource = dt
    End Sub

    Private Sub NuevoButton_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click

        LimpiarCampos()
    End Sub

    Private Sub GuardarButton_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        Dim Id_Producto As String = txtIdProducto.Text
        Dim Nombre_Producto As String = txtNombreProducto.Text
        Dim Descripcion_Producto As String = txtDescripcionProducto.Text
        Dim Categoria As String = CmbCategoria.Text
        Dim Modelo As String = txtModelo.Text
        Dim Nombre_Proveedor As String = txtNombreProveedor.Text
        Dim Fecha_Registro As DateTime = dtpFechaRegistro.Value
        Dim Precio_Unitario As Decimal = Decimal.Parse(txtPrecioUnitario.Text)
        Dim Precio_Mayorista As Decimal = Decimal.Parse(txtPrecioMayorista.Text)
        Dim Stock As Integer = Integer.Parse(txtStock.Text)


        Dim connection As New SqlConnection(connectionString)
        connection.Open()
        Dim query As String = "INSERT INTO Productos (Id_Producto, Nombre_Producto, Descripcion_Producto, Categoria, Modelo, Nombre_Proveedor, Fecha_Registro, Precio_Unitario, Precio_Mayorista, Stock) VALUES (@Id_Producto, @Nombre_Producto, @Descripcion_Producto, @Categoria, @Modelo, @Nombre_Proveedor, @Fecha_Registro, @Precio_Unitario, @Precio_Mayorista, @Stock)"
        Dim command As New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@Id_Producto", Id_Producto)
        command.Parameters.AddWithValue("@Nombre_Producto", Nombre_Producto)
        command.Parameters.AddWithValue("@Descripcion_Producto", Descripcion_Producto)
        command.Parameters.AddWithValue("@Categoria", Categoria)
        command.Parameters.AddWithValue("@Modelo", Modelo)
        command.Parameters.AddWithValue("@Nombre_Proveedor", Nombre_Proveedor)
        command.Parameters.AddWithValue("@Precio_Unitario", Precio_Unitario)
        command.Parameters.AddWithValue("@Precio_Mayorista", Precio_Mayorista)
        command.Parameters.AddWithValue("@Stock", Stock)
        command.Parameters.AddWithValue("@Fecha_Registro", Fecha_Registro)
        command.ExecuteNonQuery()

        connection.Close()
        MessageBox.Show("Registro guardado correctamente.")
        LimpiarCampos()
        llenarGridProductos()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click

        Dim id_Producto As String = txtIdProducto.Text

        Dim connection As New SqlConnection(connectionString)
        connection.Open()
        Dim query As String = "SELECT * FROM Productos WHERE Id_Producto = @Id_Producto"
        Dim command As New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@Id_Producto", id_Producto)
        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.Read() Then

            txtNombreProducto.Text = reader("Nombre_Producto").ToString()
            txtDescripcionProducto.Text = reader("Descripcion_Producto").ToString()
            CmbCategoria.Text = reader("Categoria").ToString()
            txtModelo.Text = reader("Modelo").ToString()
            txtNombreProveedor.Text = reader("Nombre_Proveedor").ToString()
            dtpFechaRegistro.Value = Convert.ToDateTime(reader("Fecha_Registro"))
            txtPrecioUnitario.Text = reader("Precio_Unitario").ToString()
            txtPrecioMayorista.Text = reader("Precio_Mayorista").ToString()
            txtStock.Text = reader("Stock").ToString()
        Else
            MessageBox.Show("No se encontró el registro.")
        End If

        reader.Close()
        connection.Close()
    End Sub

    Private Sub EliminarButton_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click

        Dim Id_Producto As String = txtIdProducto.Text

        Dim connection As New SqlConnection(connectionString)
        connection.Open()
        Dim query As String = "DELETE FROM Productos WHERE Id_Producto = @Id_Producto"
        Dim command As New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@Id_Producto", Id_Producto)
        command.ExecuteNonQuery()
        connection.Close()

        MessageBox.Show("Registro eliminado correctamente.")
        LimpiarCampos()
        llenarGridProductos()
    End Sub

    Private Sub SalirButton_Click(sender As Object, e As EventArgs) Handles Btnsalir.Click

        Me.Dispose()
        Frm_MenuPrincipal.ShowDialog()
    End Sub

    Private Sub LimpiarCampos()

        txtIdProducto.Text = ""
        txtNombreProducto.Text = ""
        txtDescripcionProducto.Text = ""
        CmbCategoria.Text = ""
        txtModelo.Text = ""
        txtNombreProveedor.Text = ""
        dtpFechaRegistro.Value = DateTime.Now
        txtPrecioUnitario.Text = ""
        txtPrecioMayorista.Text = ""
        txtStock.Text = ""
    End Sub

    Private Sub dgvproductos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvproductos.CellContentClick

    End Sub
End Class
