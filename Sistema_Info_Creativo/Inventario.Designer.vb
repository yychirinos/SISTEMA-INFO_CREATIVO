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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtid_inventario = New System.Windows.Forms.TextBox()
        Me.dgvINVENTARIO = New System.Windows.Forms.DataGridView()
        Me.Id_ProductoTextBox = New System.Windows.Forms.TextBox()
        Me.Nombre_ProductoTextBox = New System.Windows.Forms.TextBox()
        Me.StockTextBox = New System.Windows.Forms.TextBox()
        Me.dtpfecharegistro = New System.Windows.Forms.DateTimePicker()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.InfoCreativosDataSet = New Sistema_Info_Creativo.InfoCreativosDataSet()
        Me.INVENTARIOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.INVENTARIOTableAdapter = New Sistema_Info_Creativo.InfoCreativosDataSetTableAdapters.INVENTARIOTableAdapter()
        Me.TableAdapterManager = New Sistema_Info_Creativo.InfoCreativosDataSetTableAdapters.TableAdapterManager()
        Me.IdinventarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaRegistroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Label1 = New System.Windows.Forms.Label()
        Id_ProductoLabel = New System.Windows.Forms.Label()
        Nombre_ProductoLabel = New System.Windows.Forms.Label()
        StockLabel = New System.Windows.Forms.Label()
        Fecha_RegistroLabel = New System.Windows.Forms.Label()
        CType(Me.dgvINVENTARIO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InfoCreativosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INVENTARIOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(9, 96)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(67, 13)
        Label1.TabIndex = 29
        Label1.Text = "id_inventario"
        '
        'Id_ProductoLabel
        '
        Id_ProductoLabel.AutoSize = True
        Id_ProductoLabel.Location = New System.Drawing.Point(9, 122)
        Id_ProductoLabel.Name = "Id_ProductoLabel"
        Id_ProductoLabel.Size = New System.Drawing.Size(65, 13)
        Id_ProductoLabel.TabIndex = 18
        Id_ProductoLabel.Text = "Id Producto:"
        '
        'Nombre_ProductoLabel
        '
        Nombre_ProductoLabel.AutoSize = True
        Nombre_ProductoLabel.Location = New System.Drawing.Point(9, 148)
        Nombre_ProductoLabel.Name = "Nombre_ProductoLabel"
        Nombre_ProductoLabel.Size = New System.Drawing.Size(93, 13)
        Nombre_ProductoLabel.TabIndex = 20
        Nombre_ProductoLabel.Text = "Nombre Producto:"
        '
        'StockLabel
        '
        StockLabel.AutoSize = True
        StockLabel.Location = New System.Drawing.Point(9, 174)
        StockLabel.Name = "StockLabel"
        StockLabel.Size = New System.Drawing.Size(38, 13)
        StockLabel.TabIndex = 22
        StockLabel.Text = "Stock:"
        '
        'Fecha_RegistroLabel
        '
        Fecha_RegistroLabel.AutoSize = True
        Fecha_RegistroLabel.Location = New System.Drawing.Point(281, 93)
        Fecha_RegistroLabel.Name = "Fecha_RegistroLabel"
        Fecha_RegistroLabel.Size = New System.Drawing.Size(82, 13)
        Fecha_RegistroLabel.TabIndex = 24
        Fecha_RegistroLabel.Text = "Fecha Registro:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label2.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label2.Location = New System.Drawing.Point(201, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 30)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "INVENTARIO"
        '
        'txtid_inventario
        '
        Me.txtid_inventario.Location = New System.Drawing.Point(108, 93)
        Me.txtid_inventario.Name = "txtid_inventario"
        Me.txtid_inventario.Size = New System.Drawing.Size(150, 20)
        Me.txtid_inventario.TabIndex = 30
        '
        'dgvINVENTARIO
        '
        Me.dgvINVENTARIO.AutoGenerateColumns = False
        Me.dgvINVENTARIO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvINVENTARIO.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdinventarioDataGridViewTextBoxColumn, Me.IdProductoDataGridViewTextBoxColumn, Me.NombreProductoDataGridViewTextBoxColumn, Me.StockDataGridViewTextBoxColumn, Me.FechaRegistroDataGridViewTextBoxColumn})
        Me.dgvINVENTARIO.DataSource = Me.INVENTARIOBindingSource
        Me.dgvINVENTARIO.Location = New System.Drawing.Point(12, 208)
        Me.dgvINVENTARIO.Name = "dgvINVENTARIO"
        Me.dgvINVENTARIO.Size = New System.Drawing.Size(581, 128)
        Me.dgvINVENTARIO.TabIndex = 26
        '
        'Id_ProductoTextBox
        '
        Me.Id_ProductoTextBox.Location = New System.Drawing.Point(108, 119)
        Me.Id_ProductoTextBox.Name = "Id_ProductoTextBox"
        Me.Id_ProductoTextBox.Size = New System.Drawing.Size(150, 20)
        Me.Id_ProductoTextBox.TabIndex = 19
        '
        'Nombre_ProductoTextBox
        '
        Me.Nombre_ProductoTextBox.Location = New System.Drawing.Point(108, 145)
        Me.Nombre_ProductoTextBox.Name = "Nombre_ProductoTextBox"
        Me.Nombre_ProductoTextBox.Size = New System.Drawing.Size(150, 20)
        Me.Nombre_ProductoTextBox.TabIndex = 21
        '
        'StockTextBox
        '
        Me.StockTextBox.Location = New System.Drawing.Point(108, 171)
        Me.StockTextBox.Name = "StockTextBox"
        Me.StockTextBox.Size = New System.Drawing.Size(150, 20)
        Me.StockTextBox.TabIndex = 23
        '
        'dtpfecharegistro
        '
        Me.dtpfecharegistro.Location = New System.Drawing.Point(369, 90)
        Me.dtpfecharegistro.Name = "dtpfecharegistro"
        Me.dtpfecharegistro.Size = New System.Drawing.Size(195, 20)
        Me.dtpfecharegistro.TabIndex = 25
        '
        'btnSalir
        '
        Me.btnSalir.BackgroundImage = CType(resources.GetObject("btnSalir.BackgroundImage"), System.Drawing.Image)
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSalir.Location = New System.Drawing.Point(329, 367)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(47, 46)
        Me.btnSalir.TabIndex = 32
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(491, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 76)
        Me.Button1.TabIndex = 28
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.BackgroundImage = CType(resources.GetObject("BtnBuscar.BackgroundImage"), System.Drawing.Image)
        Me.BtnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBuscar.Location = New System.Drawing.Point(240, 367)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(52, 46)
        Me.BtnBuscar.TabIndex = 27
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'InfoCreativosDataSet
        '
        Me.InfoCreativosDataSet.DataSetName = "InfoCreativosDataSet"
        Me.InfoCreativosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'INVENTARIOBindingSource
        '
        Me.INVENTARIOBindingSource.DataMember = "INVENTARIO"
        Me.INVENTARIOBindingSource.DataSource = Me.InfoCreativosDataSet
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
        'IdinventarioDataGridViewTextBoxColumn
        '
        Me.IdinventarioDataGridViewTextBoxColumn.DataPropertyName = "id_inventario"
        Me.IdinventarioDataGridViewTextBoxColumn.HeaderText = "id_inventario"
        Me.IdinventarioDataGridViewTextBoxColumn.Name = "IdinventarioDataGridViewTextBoxColumn"
        Me.IdinventarioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdProductoDataGridViewTextBoxColumn
        '
        Me.IdProductoDataGridViewTextBoxColumn.DataPropertyName = "Id_Producto"
        Me.IdProductoDataGridViewTextBoxColumn.HeaderText = "Id_Producto"
        Me.IdProductoDataGridViewTextBoxColumn.Name = "IdProductoDataGridViewTextBoxColumn"
        '
        'NombreProductoDataGridViewTextBoxColumn
        '
        Me.NombreProductoDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Producto"
        Me.NombreProductoDataGridViewTextBoxColumn.HeaderText = "Nombre_Producto"
        Me.NombreProductoDataGridViewTextBoxColumn.Name = "NombreProductoDataGridViewTextBoxColumn"
        '
        'StockDataGridViewTextBoxColumn
        '
        Me.StockDataGridViewTextBoxColumn.DataPropertyName = "Stock"
        Me.StockDataGridViewTextBoxColumn.HeaderText = "Stock"
        Me.StockDataGridViewTextBoxColumn.Name = "StockDataGridViewTextBoxColumn"
        '
        'FechaRegistroDataGridViewTextBoxColumn
        '
        Me.FechaRegistroDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Registro"
        Me.FechaRegistroDataGridViewTextBoxColumn.HeaderText = "Fecha_Registro"
        Me.FechaRegistroDataGridViewTextBoxColumn.Name = "FechaRegistroDataGridViewTextBoxColumn"
        '
        'Inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 481)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.txtid_inventario)
        Me.Controls.Add(Me.Button1)
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
        Me.Name = "Inventario"
        Me.Text = "Inventario"
        CType(Me.dgvINVENTARIO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InfoCreativosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INVENTARIOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSalir As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtid_inventario As TextBox
    Friend WithEvents Button1 As Button
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
End Class
