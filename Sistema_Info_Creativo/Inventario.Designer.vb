<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventario
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
        Dim Label1 As System.Windows.Forms.Label
        Dim Id_ProductoLabel As System.Windows.Forms.Label
        Dim Nombre_ProductoLabel As System.Windows.Forms.Label
        Dim StockLabel As System.Windows.Forms.Label
        Dim Fecha_RegistroLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventario))
        Me.txtid_inventario = New System.Windows.Forms.TextBox()
        Me.dgvINVENTARIO = New System.Windows.Forms.DataGridView()
        Me.IdinventarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaRegistroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INVENTARIOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InfoCreativosDataSet = New Sistema_Info_Creativo.InfoCreativosDataSet()
        Me.Id_ProductoTextBox = New System.Windows.Forms.TextBox()
        Me.Nombre_ProductoTextBox = New System.Windows.Forms.TextBox()
        Me.StockTextBox = New System.Windows.Forms.TextBox()
        Me.dtpfecharegistro = New System.Windows.Forms.DateTimePicker()
        Me.INVENTARIOTableAdapter = New Sistema_Info_Creativo.InfoCreativosDataSetTableAdapters.INVENTARIOTableAdapter()
        Me.TableAdapterManager = New Sistema_Info_Creativo.InfoCreativosDataSetTableAdapters.TableAdapterManager()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Id_ProductoLabel = New System.Windows.Forms.Label()
        Nombre_ProductoLabel = New System.Windows.Forms.Label()
        StockLabel = New System.Windows.Forms.Label()
        Fecha_RegistroLabel = New System.Windows.Forms.Label()
        CType(Me.dgvINVENTARIO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INVENTARIOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InfoCreativosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(12, 118)
        Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(83, 16)
        Label1.TabIndex = 29
        Label1.Text = "id_inventario"
        '
        'Id_ProductoLabel
        '
        Id_ProductoLabel.AutoSize = True
        Id_ProductoLabel.Location = New System.Drawing.Point(12, 150)
        Id_ProductoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Id_ProductoLabel.Name = "Id_ProductoLabel"
        Id_ProductoLabel.Size = New System.Drawing.Size(78, 16)
        Id_ProductoLabel.TabIndex = 18
        Id_ProductoLabel.Text = "Id Producto:"
        '
        'Nombre_ProductoLabel
        '
        Nombre_ProductoLabel.AutoSize = True
        Nombre_ProductoLabel.Location = New System.Drawing.Point(12, 182)
        Nombre_ProductoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Nombre_ProductoLabel.Name = "Nombre_ProductoLabel"
        Nombre_ProductoLabel.Size = New System.Drawing.Size(116, 16)
        Nombre_ProductoLabel.TabIndex = 20
        Nombre_ProductoLabel.Text = "Nombre Producto:"
        '
        'StockLabel
        '
        StockLabel.AutoSize = True
        StockLabel.Location = New System.Drawing.Point(12, 214)
        StockLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        StockLabel.Name = "StockLabel"
        StockLabel.Size = New System.Drawing.Size(44, 16)
        StockLabel.TabIndex = 22
        StockLabel.Text = "Stock:"
        '
        'Fecha_RegistroLabel
        '
        Fecha_RegistroLabel.AutoSize = True
        Fecha_RegistroLabel.Location = New System.Drawing.Point(375, 114)
        Fecha_RegistroLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Fecha_RegistroLabel.Name = "Fecha_RegistroLabel"
        Fecha_RegistroLabel.Size = New System.Drawing.Size(102, 16)
        Fecha_RegistroLabel.TabIndex = 24
        Fecha_RegistroLabel.Text = "Fecha Registro:"
        '
        'txtid_inventario
        '
        Me.txtid_inventario.Location = New System.Drawing.Point(144, 114)
        Me.txtid_inventario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtid_inventario.Name = "txtid_inventario"
        Me.txtid_inventario.Size = New System.Drawing.Size(199, 22)
        Me.txtid_inventario.TabIndex = 30
        '
        'dgvINVENTARIO
        '
        Me.dgvINVENTARIO.AutoGenerateColumns = False
        Me.dgvINVENTARIO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvINVENTARIO.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdinventarioDataGridViewTextBoxColumn, Me.IdProductoDataGridViewTextBoxColumn, Me.NombreProductoDataGridViewTextBoxColumn, Me.StockDataGridViewTextBoxColumn, Me.FechaRegistroDataGridViewTextBoxColumn})
        Me.dgvINVENTARIO.DataSource = Me.INVENTARIOBindingSource
        Me.dgvINVENTARIO.Location = New System.Drawing.Point(16, 256)
        Me.dgvINVENTARIO.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvINVENTARIO.Name = "dgvINVENTARIO"
        Me.dgvINVENTARIO.RowHeadersWidth = 51
        Me.dgvINVENTARIO.Size = New System.Drawing.Size(775, 158)
        Me.dgvINVENTARIO.TabIndex = 26
        '
        'IdinventarioDataGridViewTextBoxColumn
        '
        Me.IdinventarioDataGridViewTextBoxColumn.DataPropertyName = "id_inventario"
        Me.IdinventarioDataGridViewTextBoxColumn.HeaderText = "id_inventario"
        Me.IdinventarioDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdinventarioDataGridViewTextBoxColumn.Name = "IdinventarioDataGridViewTextBoxColumn"
        Me.IdinventarioDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdinventarioDataGridViewTextBoxColumn.Width = 125
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
        'INVENTARIOBindingSource
        '
        Me.INVENTARIOBindingSource.DataMember = "INVENTARIO"
        Me.INVENTARIOBindingSource.DataSource = Me.InfoCreativosDataSet
        '
        'InfoCreativosDataSet
        '
        Me.InfoCreativosDataSet.DataSetName = "InfoCreativosDataSet"
        Me.InfoCreativosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Id_ProductoTextBox
        '
        Me.Id_ProductoTextBox.Location = New System.Drawing.Point(144, 146)
        Me.Id_ProductoTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Id_ProductoTextBox.Name = "Id_ProductoTextBox"
        Me.Id_ProductoTextBox.Size = New System.Drawing.Size(199, 22)
        Me.Id_ProductoTextBox.TabIndex = 19
        '
        'Nombre_ProductoTextBox
        '
        Me.Nombre_ProductoTextBox.Location = New System.Drawing.Point(144, 178)
        Me.Nombre_ProductoTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Nombre_ProductoTextBox.Name = "Nombre_ProductoTextBox"
        Me.Nombre_ProductoTextBox.Size = New System.Drawing.Size(199, 22)
        Me.Nombre_ProductoTextBox.TabIndex = 21
        '
        'StockTextBox
        '
        Me.StockTextBox.Location = New System.Drawing.Point(144, 210)
        Me.StockTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.StockTextBox.Name = "StockTextBox"
        Me.StockTextBox.Size = New System.Drawing.Size(199, 22)
        Me.StockTextBox.TabIndex = 23
        '
        'dtpfecharegistro
        '
        Me.dtpfecharegistro.Location = New System.Drawing.Point(492, 111)
        Me.dtpfecharegistro.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpfecharegistro.Name = "dtpfecharegistro"
        Me.dtpfecharegistro.Size = New System.Drawing.Size(259, 22)
        Me.dtpfecharegistro.TabIndex = 25
        '
        'INVENTARIOTableAdapter
        '
        Me.INVENTARIOTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.comprasTableAdapter = Nothing
        Me.TableAdapterManager.EMPLEADOSTableAdapter = Nothing
        Me.TableAdapterManager.INVENTARIOTableAdapter = Me.INVENTARIOTableAdapter
        Me.TableAdapterManager.ListadoEstadoCivilTableAdapter = Nothing
        Me.TableAdapterManager.ListadoSexosTableAdapter = Nothing
        Me.TableAdapterManager.MenuAppTableAdapter = Nothing
        Me.TableAdapterManager.ProductosTableAdapter = Nothing
        Me.TableAdapterManager.ProveedoresTableAdapter = Nothing
        Me.TableAdapterManager.REGISTROUSUARIOTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sistema_Info_Creativo.InfoCreativosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(-2, -4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(810, 68)
        Me.Panel1.TabIndex = 33
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
        Me.PictureBox1.Location = New System.Drawing.Point(731, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 105)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.BackgroundImage = CType(resources.GetObject("btnSalir.BackgroundImage"), System.Drawing.Image)
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSalir.Location = New System.Drawing.Point(439, 452)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(63, 57)
        Me.btnSalir.TabIndex = 32
        Me.ToolTip1.SetToolTip(Me.btnSalir, "Volver al Menu Principal.")
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.BackgroundImage = CType(resources.GetObject("BtnBuscar.BackgroundImage"), System.Drawing.Image)
        Me.BtnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBuscar.Location = New System.Drawing.Point(320, 452)
        Me.BtnBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(69, 57)
        Me.BtnBuscar.TabIndex = 27
        Me.ToolTip1.SetToolTip(Me.BtnBuscar, "Buscar Producto.")
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(264, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(299, 49)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "INVENTARIO"
        '
        'Inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 592)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.txtid_inventario)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.dgvINVENTARIO)
        Me.Controls.Add(Id_ProductoLabel)
        Me.Controls.Add(Me.Id_ProductoTextBox)
        Me.Controls.Add(Nombre_ProductoLabel)
        Me.Controls.Add(Me.Nombre_ProductoTextBox)
        Me.Controls.Add(StockLabel)
        Me.Controls.Add(Me.StockTextBox)
        Me.Controls.Add(Fecha_RegistroLabel)
        Me.Controls.Add(Me.dtpfecharegistro)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Inventario"
        Me.Text = "Inventario"
        CType(Me.dgvINVENTARIO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INVENTARIOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InfoCreativosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSalir As Button
    Friend WithEvents txtid_inventario As TextBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents dgvINVENTARIO As DataGridView
    Friend WithEvents Id_ProductoTextBox As TextBox
    Friend WithEvents Nombre_ProductoTextBox As TextBox
    Friend WithEvents StockTextBox As TextBox
    Friend WithEvents dtpfecharegistro As DateTimePicker
    Friend WithEvents InfoCreativosDataSet As InfoCreativosDataSet
    Friend WithEvents INVENTARIOBindingSource As BindingSource
    Friend WithEvents INVENTARIOTableAdapter As InfoCreativosDataSetTableAdapters.INVENTARIOTableAdapter
    Friend WithEvents TableAdapterManager As InfoCreativosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdinventarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdProductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreProductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaRegistroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label4 As Label
End Class
