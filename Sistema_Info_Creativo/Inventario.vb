Imports System.Data.SqlClient
Public Class Inventario
    Dim connectionString As String = "Data Source=DESKTOP-50ALDBO;Initial Catalog=InfoCreativos;Integrated Security=True"

    Private Sub INVENTARIO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InfoCreativosDataSet.INVENTARIO' table. You can move, or remove it, as needed.
        Me.INVENTARIOTableAdapter.Fill(Me.InfoCreativosDataSet.INVENTARIO)

    End Sub

    Private INVENTARIOBindingSource1 As New BindingSource()
    Sub llenarGridINVENTARIO()
        Dim consulta As String = "SELECT * FROM INVENTARIO"
        Dim adapter As New SqlDataAdapter(consulta, connectionString)
        Dim dt As New DataTable
        adapter.Fill(dt)
        dgvINVENTARIO.DataSource = dt
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click

        Dim id_inventario As String = txtid_inventario.Text

        Dim connection As New SqlConnection(connectionString)
        connection.Open()
        Dim query As String = "SELECT * FROM INVENTARIO WHERE id_inventario = @id_inventario"
        Dim command As New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@id_inventario", id_inventario)
        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.Read() Then

            Id_ProductoTextBox.Text = reader("Id_Producto").ToString()
            Nombre_ProductoTextBox.Text = reader("Nombre_Producto").ToString()
            dtpfecharegistro.Value = Convert.ToDateTime(reader("Fecha_Registro"))
            StockTextBox.Text = reader("Stock").ToString()
        Else
            MessageBox.Show("No se encontró el registro.")
        End If

        reader.Close()
        connection.Close()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Dispose()
        Frm_MenuPrincipal.ShowDialog()
    End Sub
    Private Sub LimpiarCampos()

        txtid_inventario.Text = ""
        Id_ProductoTextBox.Text = ""
        Nombre_ProductoTextBox.Text = ""
        dtpfecharegistro.Value = DateTime.Now
        StockTextBox.Text = ""
    End Sub
End Class
