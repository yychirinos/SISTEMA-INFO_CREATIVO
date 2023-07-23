Imports System.Data.SqlClient
Public Class FrmFacturaVentas
    Private Sub FrmFacturaVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarGrigVentas()
        LlenarCombo()
    End Sub

    Sub LlenarGrigVentas()

        Dim con As New SqlConnection(My.Settings.INFO_CREATIVO)
        Dim DT As DataTable
        Dim DA As New SqlDataAdapter
        Dim cmd As New SqlCommand
        con.Open()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT NumFactura  ,IdCliente,Fecha ,Descuento ,SubTotal ,ISV ,Total ,IdUsuario FROM FacturaVenta"
        cmd.ExecuteNonQuery()
        con.Close()
        DA.SelectCommand = cmd
        DT = New DataTable
        DA.Fill(DT)
        dgvventas.DataSource = DT
        dgvventas.AllowUserToAddRows = False

    End Sub
    Sub LlenarCombo()
        Dim con As New SqlConnection(My.Settings.INFO_CREATIVO)
        Dim DT As DataTable
        Dim DA As New SqlDataAdapter
        Dim cmd As New SqlCommand
        con.Open()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT NumFactura
      ,IdCliente,
      Fecha,
      Descuento,
     SubTotal,
      ISV,
      Total,
      IdUsuario
  FROM FacturaVenta"
        cmd.ExecuteNonQuery()
        con.Close()
        DA.SelectCommand = cmd
        DT = New DataTable
        DA.Fill(DT)
        ''cmbproductos.DataSource = DT
        ''cmbproductos.DisplayMember = "Descripcion"
        '' cmbproductos.ValueMember = "Idproducto"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmbdetallefac.Click


    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles Cmbagregar.Enter

    End Sub
End Class