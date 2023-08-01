<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Productos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Productos))
        Me.dgvproductos = New System.Windows.Forms.DataGridView()
        Me.IdProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModeloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreProveedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUnitarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioMayoristaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaRegistroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InfoCreativosDataSet = New Sistema_Info_Creativo.InfoCreativosDataSet()
        Me.dtpFechaRegistro = New System.Windows.Forms.DateTimePicker()
        Me.CmbCategoria = New System.Windows.Forms.ComboBox()
        Me.txtNombreProducto = New System.Windows.Forms.TextBox()
        Me.txtDescripcionProducto = New System.Windows.Forms.TextBox()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.txtPrecioUnitario = New System.Windows.Forms.TextBox()
        Me.txtPrecioMayorista = New System.Windows.Forms.TextBox()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.txtIdProducto = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProductosTableAdapter = New Sistema_Info_Creativo.InfoCreativosDataSetTableAdapters.ProductosTableAdapter()
        Me.TableAdapterManager = New Sistema_Info_Creativo.InfoCreativosDataSetTableAdapters.TableAdapterManager()
        Me.cmbProveedor = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.Btnsalir = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.dgvproductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InfoCreativosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvproductos
        '
        Me.dgvproductos.AutoGenerateColumns = False
        Me.dgvproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvproductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProductoDataGridViewTextBoxColumn, Me.NombreProductoDataGridViewTextBoxColumn, Me.DescripcionProductoDataGridViewTextBoxColumn, Me.CategoriaDataGridViewTextBoxColumn, Me.ModeloDataGridViewTextBoxColumn, Me.NombreProveedorDataGridViewTextBoxColumn, Me.PrecioUnitarioDataGridViewTextBoxColumn, Me.PrecioMayoristaDataGridViewTextBoxColumn, Me.StockDataGridViewTextBoxColumn, Me.FechaRegistroDataGridViewTextBoxColumn})
        Me.dgvproductos.DataSource = Me.ProductosBindingSource
        Me.dgvproductos.Location = New System.Drawing.Point(2, 408)
        Me.dgvproductos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvproductos.Name = "dgvproductos"
        Me.dgvproductos.RowHeadersWidth = 51
        Me.dgvproductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvproductos.Size = New System.Drawing.Size(951, 203)
        Me.dgvproductos.TabIndex = 59
        '
        'IdProductoDataGridViewTextBoxColumn
        '
        Me.IdProductoDataGridViewTextBoxColumn.DataPropertyName = "Id_Producto"
        Me.IdProductoDataGridViewTextBoxColumn.HeaderText = "Id_Producto"
        Me.IdProductoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdProductoDataGridViewTextBoxColumn.Name = "IdProductoDataGridViewTextBoxColumn"
        Me.IdProductoDataGridViewTextBoxColumn.Width = 125
        '
        'NombreProductoDataGridViewTextBoxColumn
        '
        Me.NombreProductoDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Producto"
        Me.NombreProductoDataGridViewTextBoxColumn.HeaderText = "Nombre_Producto"
        Me.NombreProductoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombreProductoDataGridViewTextBoxColumn.Name = "NombreProductoDataGridViewTextBoxColumn"
        Me.NombreProductoDataGridViewTextBoxColumn.Width = 125
        '
        'DescripcionProductoDataGridViewTextBoxColumn
        '
        Me.DescripcionProductoDataGridViewTextBoxColumn.DataPropertyName = "Descripcion_Producto"
        Me.DescripcionProductoDataGridViewTextBoxColumn.HeaderText = "Descripcion_Producto"
        Me.DescripcionProductoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DescripcionProductoDataGridViewTextBoxColumn.Name = "DescripcionProductoDataGridViewTextBoxColumn"
        Me.DescripcionProductoDataGridViewTextBoxColumn.Width = 125
        '
        'CategoriaDataGridViewTextBoxColumn
        '
        Me.CategoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria"
        Me.CategoriaDataGridViewTextBoxColumn.HeaderText = "Categoria"
        Me.CategoriaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CategoriaDataGridViewTextBoxColumn.Name = "CategoriaDataGridViewTextBoxColumn"
        Me.CategoriaDataGridViewTextBoxColumn.Width = 125
        '
        'ModeloDataGridViewTextBoxColumn
        '
        Me.ModeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo"
        Me.ModeloDataGridViewTextBoxColumn.HeaderText = "Modelo"
        Me.ModeloDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ModeloDataGridViewTextBoxColumn.Name = "ModeloDataGridViewTextBoxColumn"
        Me.ModeloDataGridViewTextBoxColumn.Width = 125
        '
        'NombreProveedorDataGridViewTextBoxColumn
        '
        Me.NombreProveedorDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Proveedor"
        Me.NombreProveedorDataGridViewTextBoxColumn.HeaderText = "Nombre_Proveedor"
        Me.NombreProveedorDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombreProveedorDataGridViewTextBoxColumn.Name = "NombreProveedorDataGridViewTextBoxColumn"
        Me.NombreProveedorDataGridViewTextBoxColumn.Width = 125
        '
        'PrecioUnitarioDataGridViewTextBoxColumn
        '
        Me.PrecioUnitarioDataGridViewTextBoxColumn.DataPropertyName = "Precio_Unitario"
        Me.PrecioUnitarioDataGridViewTextBoxColumn.HeaderText = "Precio_Unitario"
        Me.PrecioUnitarioDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PrecioUnitarioDataGridViewTextBoxColumn.Name = "PrecioUnitarioDataGridViewTextBoxColumn"
        Me.PrecioUnitarioDataGridViewTextBoxColumn.Width = 125
        '
        'PrecioMayoristaDataGridViewTextBoxColumn
        '
        Me.PrecioMayoristaDataGridViewTextBoxColumn.DataPropertyName = "Precio_Mayorista"
        Me.PrecioMayoristaDataGridViewTextBoxColumn.HeaderText = "Precio_Mayorista"
        Me.PrecioMayoristaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PrecioMayoristaDataGridViewTextBoxColumn.Name = "PrecioMayoristaDataGridViewTextBoxColumn"
        Me.PrecioMayoristaDataGridViewTextBoxColumn.Width = 125
        '
        'StockDataGridViewTextBoxColumn
        '
        Me.StockDataGridViewTextBoxColumn.DataPropertyName = "Stock"
        Me.StockDataGridViewTextBoxColumn.HeaderText = "Stock"
        Me.StockDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StockDataGridViewTextBoxColumn.Name = "StockDataGridViewTextBoxColumn"
        Me.StockDataGridViewTextBoxColumn.Width = 125
        '
        'FechaRegistroDataGridViewTextBoxColumn
        '
        Me.FechaRegistroDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Registro"
        Me.FechaRegistroDataGridViewTextBoxColumn.HeaderText = "Fecha_Registro"
        Me.FechaRegistroDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FechaRegistroDataGridViewTextBoxColumn.Name = "FechaRegistroDataGridViewTextBoxColumn"
        Me.FechaRegistroDataGridViewTextBoxColumn.Width = 125
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "Productos"
        Me.ProductosBindingSource.DataSource = Me.InfoCreativosDataSet
        '
        'InfoCreativosDataSet
        '
        Me.InfoCreativosDataSet.DataSetName = "InfoCreativosDataSet"
        Me.InfoCreativosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtpFechaRegistro
        '
        Me.dtpFechaRegistro.Location = New System.Drawing.Point(434, 224)
        Me.dtpFechaRegistro.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpFechaRegistro.Name = "dtpFechaRegistro"
        Me.dtpFechaRegistro.Size = New System.Drawing.Size(189, 22)
        Me.dtpFechaRegistro.TabIndex = 56
        '
        'CmbCategoria
        '
        Me.CmbCategoria.FormattingEnabled = True
        Me.CmbCategoria.Items.AddRange(New Object() {"Computadoras", "Accesorios para computadoras", "Audio", "Scanners", "Almacenamiento", "Redes", "Impresoras", ""})
        Me.CmbCategoria.Location = New System.Drawing.Point(371, 106)
        Me.CmbCategoria.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmbCategoria.Name = "CmbCategoria"
        Me.CmbCategoria.Size = New System.Drawing.Size(135, 24)
        Me.CmbCategoria.TabIndex = 55
        '
        'txtNombreProducto
        '
        Me.txtNombreProducto.Location = New System.Drawing.Point(163, 144)
        Me.txtNombreProducto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNombreProducto.Name = "txtNombreProducto"
        Me.txtNombreProducto.Size = New System.Drawing.Size(135, 22)
        Me.txtNombreProducto.TabIndex = 49
        '
        'txtDescripcionProducto
        '
        Me.txtDescripcionProducto.Location = New System.Drawing.Point(163, 183)
        Me.txtDescripcionProducto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDescripcionProducto.Name = "txtDescripcionProducto"
        Me.txtDescripcionProducto.Size = New System.Drawing.Size(556, 22)
        Me.txtDescripcionProducto.TabIndex = 48
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(584, 104)
        Me.txtModelo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(135, 22)
        Me.txtModelo.TabIndex = 47
        '
        'txtPrecioUnitario
        '
        Me.txtPrecioUnitario.Location = New System.Drawing.Point(119, 272)
        Me.txtPrecioUnitario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPrecioUnitario.Name = "txtPrecioUnitario"
        Me.txtPrecioUnitario.Size = New System.Drawing.Size(112, 22)
        Me.txtPrecioUnitario.TabIndex = 45
        '
        'txtPrecioMayorista
        '
        Me.txtPrecioMayorista.Location = New System.Drawing.Point(399, 272)
        Me.txtPrecioMayorista.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPrecioMayorista.Name = "txtPrecioMayorista"
        Me.txtPrecioMayorista.Size = New System.Drawing.Size(107, 22)
        Me.txtPrecioMayorista.TabIndex = 44
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(584, 272)
        Me.txtStock.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(135, 22)
        Me.txtStock.TabIndex = 43
        '
        'txtIdProducto
        '
        Me.txtIdProducto.Location = New System.Drawing.Point(163, 107)
        Me.txtIdProducto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtIdProducto.Name = "txtIdProducto"
        Me.txtIdProducto.Size = New System.Drawing.Size(81, 22)
        Me.txtIdProducto.TabIndex = 42
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(320, 226)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 16)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Fecha Registro"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 275)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 16)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Precio Unitario"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(520, 275)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 16)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Stock"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(276, 275)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 16)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Precio Mayoritario"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 231)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 16)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Nombre Proveedor"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(520, 108)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 16)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Modelo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(276, 108)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 16)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Categoria"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 152)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 16)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Nombre Producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 192)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 16)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Descripcion Producto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 115)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 16)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Id Producto"
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.comprasTableAdapter = Nothing
        Me.TableAdapterManager.EMPLEADOSTableAdapter = Nothing
        Me.TableAdapterManager.INVENTARIOTableAdapter = Nothing
        Me.TableAdapterManager.ListadoEstadoCivilTableAdapter = Nothing
        Me.TableAdapterManager.ListadoSexosTableAdapter = Nothing
        Me.TableAdapterManager.MenuAppTableAdapter = Nothing
        Me.TableAdapterManager.ProductosTableAdapter = Me.ProductosTableAdapter
        Me.TableAdapterManager.ProveedoresTableAdapter = Nothing
        Me.TableAdapterManager.REGISTROUSUARIOTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sistema_Info_Creativo.InfoCreativosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'cmbProveedor
        '
        Me.cmbProveedor.FormattingEnabled = True
        Me.cmbProveedor.Items.AddRange(New Object() {"LA UNIVERSAL", "TECHNOMALL", "SKYTECH", "TECH SOLUTIONS", "MICROSOFT", "JETSTEREO", "CODAC", "PCSMART"})
        Me.cmbProveedor.Location = New System.Drawing.Point(163, 216)
        Me.cmbProveedor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbProveedor.Name = "cmbProveedor"
        Me.cmbProveedor.Size = New System.Drawing.Size(135, 24)
        Me.cmbProveedor.TabIndex = 60
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(3, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(951, 68)
        Me.Panel1.TabIndex = 61
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 100
        Me.ToolTip1.ReshowDelay = 100
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Sistema_Info_Creativo.My.Resources.Resources.LOGOTIPO_INFO_CREATIVE7
        Me.PictureBox1.Location = New System.Drawing.Point(861, -5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 113)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackgroundImage = CType(resources.GetObject("BtnEliminar.BackgroundImage"), System.Drawing.Image)
        Me.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEliminar.Location = New System.Drawing.Point(458, 330)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(49, 53)
        Me.BtnEliminar.TabIndex = 54
        Me.ToolTip1.SetToolTip(Me.BtnEliminar, "Eliminar Producto.")
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'Btnsalir
        '
        Me.Btnsalir.BackgroundImage = CType(resources.GetObject("Btnsalir.BackgroundImage"), System.Drawing.Image)
        Me.Btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btnsalir.Location = New System.Drawing.Point(527, 330)
        Me.Btnsalir.Margin = New System.Windows.Forms.Padding(4)
        Me.Btnsalir.Name = "Btnsalir"
        Me.Btnsalir.Size = New System.Drawing.Size(45, 53)
        Me.Btnsalir.TabIndex = 53
        Me.ToolTip1.SetToolTip(Me.Btnsalir, "Volver al Menu Principal.")
        Me.Btnsalir.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.BackgroundImage = CType(resources.GetObject("BtnBuscar.BackgroundImage"), System.Drawing.Image)
        Me.BtnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBuscar.Location = New System.Drawing.Point(387, 330)
        Me.BtnBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(51, 53)
        Me.BtnBuscar.TabIndex = 52
        Me.ToolTip1.SetToolTip(Me.BtnBuscar, "Buscar Producto.")
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackgroundImage = CType(resources.GetObject("BtnGuardar.BackgroundImage"), System.Drawing.Image)
        Me.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnGuardar.Location = New System.Drawing.Point(316, 330)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(51, 53)
        Me.BtnGuardar.TabIndex = 51
        Me.ToolTip1.SetToolTip(Me.BtnGuardar, "Guardar Producto.")
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackgroundImage = CType(resources.GetObject("BtnNuevo.BackgroundImage"), System.Drawing.Image)
        Me.BtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNuevo.Location = New System.Drawing.Point(238, 330)
        Me.BtnNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(44, 53)
        Me.BtnNuevo.TabIndex = 50
        Me.ToolTip1.SetToolTip(Me.BtnNuevo, "Cancelar Registro.")
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(330, 10)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(290, 49)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "PRODUCTOS"
        '
        'Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 631)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmbProveedor)
        Me.Controls.Add(Me.dgvproductos)
        Me.Controls.Add(Me.dtpFechaRegistro)
        Me.Controls.Add(Me.CmbCategoria)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.Btnsalir)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.txtNombreProducto)
        Me.Controls.Add(Me.txtDescripcionProducto)
        Me.Controls.Add(Me.txtModelo)
        Me.Controls.Add(Me.txtPrecioUnitario)
        Me.Controls.Add(Me.txtPrecioMayorista)
        Me.Controls.Add(Me.txtStock)
        Me.Controls.Add(Me.txtIdProducto)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Productos"
        Me.Text = "Productos"
        CType(Me.dgvproductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InfoCreativosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvproductos As DataGridView
    Friend WithEvents dtpFechaRegistro As DateTimePicker
    Friend WithEvents CmbCategoria As ComboBox
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents Btnsalir As Button
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents txtNombreProducto As TextBox
    Friend WithEvents txtDescripcionProducto As TextBox
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents txtPrecioUnitario As TextBox
    Friend WithEvents txtPrecioMayorista As TextBox
    Friend WithEvents txtStock As TextBox
    Friend WithEvents txtIdProducto As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents InfoCreativosDataSet As InfoCreativosDataSet
    Friend WithEvents ProductosBindingSource As BindingSource
    Friend WithEvents ProductosTableAdapter As InfoCreativosDataSetTableAdapters.ProductosTableAdapter
    Friend WithEvents TableAdapterManager As InfoCreativosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdProductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreProductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionProductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoriaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ModeloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreProveedorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioUnitarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioMayoristaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaRegistroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents cmbProveedor As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label11 As Label
End Class
