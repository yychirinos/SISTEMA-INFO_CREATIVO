Imports System.Data.SqlClient

Public Class Frm_MenuPrincipal
    Private Sub Frm_MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True

        ActivarMenu()

    End Sub


    Sub ActivarMenu()

        Dim con As SqlClient.SqlConnection
        Dim SQLcon As String

        'Ocultar opciones principales
        For Each opcion As ToolStripItem In MenuStrip1.Items
            opcion.Visible = False

        Next

        'ocultar opciones desplegables

        For Each opcion As ToolStripItem In AplicacionToolStripMenuItem.DropDownItems
            opcion.Visible = False

        Next

        For Each opcion As ToolStripItem In MantenimientoToolStripMenuItem.DropDownItems
            opcion.Visible = False

        Next

        For Each opcion As ToolStripItem In TransaccionesToolStripMenuItem.DropDownItems
            opcion.Visible = False

        Next

        For Each opcion As ToolStripItem In ReportesToolStripMenuItem.DropDownItems
            opcion.Visible = False

        Next

        For Each opcion As ToolStripItem In AyudaToolStripMenuItem.DropDownItems
            opcion.Visible = False

        Next

        SQLcon = My.Settings.INFO_CREATIVO
        con = New SqlClient.SqlConnection(SQLcon)

        con.Open()
        Dim cmd As SqlCommand = New SqlCommand("SELECT nivelacceso, opcion, descripcion FROM MenuApp where nivelacceso = '" & VariablesPublicas.nivelacceso & "'", con)
        cmd.CommandType = CommandType.Text
        cmd.Parameters.AddWithValue("@bandera", 1)
        cmd.Parameters.AddWithValue("@nivelacceso", VariablesPublicas.nivelacceso)


        Using r = cmd.ExecuteReader
            If r.HasRows Then
                While (r.Read()) 'mientras el lector encuentre datos
                    For Each opcion As ToolStripItem In MenuStrip1.Items
                        If r.GetString(2).Trim = opcion.Name.Trim Then
                            opcion.Visible = True
                            Exit For
                        End If
                    Next

                    'HABILITAR MENU APLICACION
                    For Each opcion As ToolStripItem In AplicacionToolStripMenuItem.DropDownItems
                        If r.GetString(2).Trim = opcion.Name.Trim Then
                            opcion.Visible = True

                        End If
                    Next
                    'HABILITAR MENU MANTENIMIENTO
                    For Each opcion As ToolStripItem In MantenimientoToolStripMenuItem.DropDownItems
                        If r.GetString(2).Trim = opcion.Name.Trim Then
                            opcion.Visible = True

                        End If
                    Next

                    'HABILITAR MENU TRANSACCIONES
                    For Each opcion As ToolStripItem In TransaccionesToolStripMenuItem.DropDownItems
                        If r.GetString(2).Trim = opcion.Name.Trim Then
                            opcion.Visible = True

                        End If
                    Next
                    'HABILITAR MENU REPORTES
                    For Each opcion As ToolStripItem In ReportesToolStripMenuItem.DropDownItems
                        If r.GetString(2).Trim = opcion.Name.Trim Then
                            opcion.Visible = True

                        End If
                    Next
                    'HABILITAR MENU AYUDA
                    For Each opcion As ToolStripItem In AyudaToolStripMenuItem.DropDownItems
                        If r.GetString(2).Trim = opcion.Name.Trim Then
                            opcion.Visible = True

                        End If
                    Next

                End While

            End If
        End Using

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        lblhora.Text = DateTime.Now.ToString("hh:mm:ss ")
        lblfecha.Text = DateTime.Now.ToLongDateString()

    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem.Click
        Me.Dispose()
        FrmEmpleados.ShowDialog()

    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Me.Dispose()
        FrmClientes.ShowDialog()

    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        Me.Dispose()
        FrmUSUARIOS.ShowDialog()

    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        Me.Dispose()
        FrmAgregarProveedor.ShowDialog()
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click
        Me.Dispose()
        FrmVentas.ShowDialog()
    End Sub

    Private Sub ComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprasToolStripMenuItem.Click
        Me.Dispose()
        FrmCompras.ShowDialog()
    End Sub
End Class

