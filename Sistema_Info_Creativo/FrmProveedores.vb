Imports System.Data.SqlClient
Public Class FrmProveedores
    Private dtProveedores As New DataTable()
    Private Sub FrmProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarProveedores()
    End Sub

    Public Sub CargarProveedores()
        ' Limpiar el DataTable antes de cargar los proveedores
        dtProveedores.Clear()
        ' Cadena de conexión
        Dim connectionString As String = "Data Source=HECTOR\SQLEXPRESS;Initial Catalog=proveedoresBD;Integrated Security=True"

        ' Consulta SQL para seleccionar los proveedores
        Dim query As String = "SELECT ID_PROVEEDOR, NOMBRE_PROVEEDOR, DEPARTAMENTO, CIUDAD, DIRECCION, TELEFONO, CORREO, CATEGORIA FROM Proveedores"

        ' Establecer la conexión y ejecutar la consulta
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                ' Crear un DataAdapter para llenar el DataTable
                Dim adapter As New SqlDataAdapter(command)
                adapter.Fill(dtProveedores)
            End Using
        End Using

        ' Asignar el DataTable como origen de datos del DataGridView
        dgProveedores.DataSource = dtProveedores
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dim resultado As DialogResult = MessageBox.Show("¿Está seguro que desea Salir de Proveedores?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resultado = DialogResult.Yes Then
            Me.Dispose()
        End If
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Dim idProveedor As Integer = 0
        If Integer.TryParse(txtBuscarID.Text, idProveedor) Then
            FiltrarProveedores("ID_PROVEEDOR = " & idProveedor)
        Else
            FiltrarProveedores("ID_PROVEEDOR IS NULL")
        End If

        Dim nombreProveedor As String = txtBuscarNombre.Text.Trim()
        If nombreProveedor <> "" Then
            FiltrarProveedores("NOMBRE_PROVEEDOR LIKE '%" & nombreProveedor & "%'")
        End If

        Dim telefonoProveedor As String = txtBuscarTelefono.Text.Trim()
        If telefonoProveedor <> "" Then
            FiltrarProveedores("TELEFONO = '" & telefonoProveedor & "'")
        End If
    End Sub
End Class