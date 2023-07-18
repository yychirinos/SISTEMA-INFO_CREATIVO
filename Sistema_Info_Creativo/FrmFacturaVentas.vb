Imports System.Data.SqlClient
Public Class FrmFacturaVentas
    Private Sub FrmFacturaVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarGrigVentas()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmbdetallefac.Click
        FrmDetalleVenta.ShowDialog()

    End Sub
End Class