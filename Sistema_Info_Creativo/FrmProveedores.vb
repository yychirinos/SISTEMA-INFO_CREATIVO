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
        Dim connectionString As String = "Data Source=LAPTOP-3LMQAO4P;Initial Catalog=InfoCreativos;Integrated Security=True"

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
        Me.Dispose()
        Frm_MenuPrincipal.ShowDialog()
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

    Private Sub FiltrarProveedores(filtro As String)
        dtProveedores.DefaultView.RowFilter = filtro
    End Sub

    Private Sub LimpiarFiltros()
        txtBuscarID.Text = ""
        txtBuscarNombre.Text = ""
        txtBuscarTelefono.Text = ""

        ' Mostrar todos los proveedores
        dtProveedores.DefaultView.RowFilter = ""
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarFiltros()
    End Sub

    Private Sub btnNuevoProveedor_Click(sender As Object, e As EventArgs) Handles btnNuevoProveedor.Click
        ' Mostrar el formulario de agregar proveedores
        FrmAgregarProveedor.ShowDialog()
    End Sub

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
        ' Llamar al método CargarProveedores en FrmProveedores para actualizar la lista de proveedores
        Dim frmProveedores As FrmProveedores = DirectCast(Application.OpenForms("FrmProveedores"), FrmProveedores)
        frmProveedores.CargarProveedores()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        FrmModificarProveedor.Show()
    End Sub
End Class