﻿Imports System.Data.SqlClient
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
        Dim Nombre_Producto As String = Nombre_ProductoTextBox.Text

        If String.IsNullOrWhiteSpace(Nombre_Producto) Then
            MessageBox.Show("Por favor, ingresa un nombre de producto válido.")
            Return
        End If

        Dim connection As New SqlConnection(connectionString)
        connection.Open()

        Dim query As String = "SELECT Stock FROM INVENTARIO WHERE Nombre_Producto = @NombreProducto"
        Dim command As New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@NombreProducto", Nombre_Producto)

        Dim stock As Object = command.ExecuteScalar()

        If stock IsNot Nothing AndAlso Not DBNull.Value.Equals(stock) Then
            StockTextBox.Text = stock.ToString()

        Else
            StockTextBox.Text = "No se encontro el producto o el stock esta vacio"
        End If

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
