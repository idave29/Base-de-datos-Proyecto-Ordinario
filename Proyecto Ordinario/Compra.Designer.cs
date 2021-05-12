
namespace Proyecto_Ordinario
{
    partial class Compra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiendaTecDataSet4 = new Proyecto_Ordinario.TiendaTecDataSet4();
            this.cmbSucursal = new System.Windows.Forms.ComboBox();
            this.sucursalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiendaTecDataSet3 = new Proyecto_Ordinario.TiendaTecDataSet3();
            this.lbsueldo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lbS = new System.Windows.Forms.Label();
            this.lbIva = new System.Windows.Forms.Label();
            this.lbFH = new System.Windows.Forms.Label();
            this.lbN = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.cmbProd = new System.Windows.Forms.ComboBox();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiendaTecDataSet = new Proyecto_Ordinario.TiendaTecDataSet();
            this.lbProd = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbTotalFinal = new System.Windows.Forms.Label();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiendaTecDataSet5 = new Proyecto_Ordinario.TiendaTecDataSet5();
            this.lbEmpl = new System.Windows.Forms.Label();
            this.btnQuery = new FontAwesome.Sharp.IconButton();
            this.BtnBuscar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.btnModificar = new FontAwesome.Sharp.IconButton();
            this.btnBorrar = new FontAwesome.Sharp.IconButton();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.btnUltimo = new FontAwesome.Sharp.IconButton();
            this.btnPrimero = new FontAwesome.Sharp.IconButton();
            this.btnSiguiente = new FontAwesome.Sharp.IconButton();
            this.btnAnterior = new FontAwesome.Sharp.IconButton();
            this.rdbProd = new System.Windows.Forms.RadioButton();
            this.rdbTicket = new System.Windows.Forms.RadioButton();
            this.lbSubtotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iconMostrar = new FontAwesome.Sharp.IconButton();
            this.btnCrearT = new FontAwesome.Sharp.IconButton();
            this.productosTableAdapter = new Proyecto_Ordinario.TiendaTecDataSetTableAdapters.ProductosTableAdapter();
            this.tiendaTecDataSet1 = new Proyecto_Ordinario.TiendaTecDataSet1();
            this.tiendaTecDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sucursalesTableAdapter = new Proyecto_Ordinario.TiendaTecDataSet3TableAdapters.SucursalesTableAdapter();
            this.clientesTableAdapter = new Proyecto_Ordinario.TiendaTecDataSet4TableAdapters.ClientesTableAdapter();
            this.empleadosTableAdapter = new Proyecto_Ordinario.TiendaTecDataSet5TableAdapters.EmpleadosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaTecDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaTecDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaTecDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaTecDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaTecDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaTecDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCliente
            // 
            this.cmbCliente.DataSource = this.clientesBindingSource;
            this.cmbCliente.DisplayMember = "Correo";
            this.cmbCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(135, 315);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(187, 25);
            this.cmbCliente.TabIndex = 101;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.tiendaTecDataSet4;
            // 
            // tiendaTecDataSet4
            // 
            this.tiendaTecDataSet4.DataSetName = "TiendaTecDataSet4";
            this.tiendaTecDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.DataSource = this.sucursalesBindingSource;
            this.cmbSucursal.DisplayMember = "Nombre_Sucursal";
            this.cmbSucursal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSucursal.FormattingEnabled = true;
            this.cmbSucursal.Location = new System.Drawing.Point(135, 257);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(187, 25);
            this.cmbSucursal.TabIndex = 100;
            // 
            // sucursalesBindingSource
            // 
            this.sucursalesBindingSource.DataMember = "Sucursales";
            this.sucursalesBindingSource.DataSource = this.tiendaTecDataSet3;
            // 
            // tiendaTecDataSet3
            // 
            this.tiendaTecDataSet3.DataSetName = "TiendaTecDataSet3";
            this.tiendaTecDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbsueldo
            // 
            this.lbsueldo.AutoSize = true;
            this.lbsueldo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsueldo.Location = new System.Drawing.Point(74, 318);
            this.lbsueldo.Name = "lbsueldo";
            this.lbsueldo.Size = new System.Drawing.Size(58, 17);
            this.lbsueldo.TabIndex = 99;
            this.lbsueldo.Text = "Cliente:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(331, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(240, 219);
            this.dataGridView1.TabIndex = 98;
            // 
            // txtIva
            // 
            this.txtIva.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIva.Location = new System.Drawing.Point(135, 287);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(60, 23);
            this.txtIva.TabIndex = 88;
            this.txtIva.Text = "0";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(135, 153);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(187, 23);
            this.txtCantidad.TabIndex = 86;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(135, 57);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(187, 23);
            this.txtId.TabIndex = 85;
            // 
            // lbS
            // 
            this.lbS.AutoSize = true;
            this.lbS.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbS.Location = new System.Drawing.Point(70, 259);
            this.lbS.Name = "lbS";
            this.lbS.Size = new System.Drawing.Size(63, 17);
            this.lbS.TabIndex = 84;
            this.lbS.Text = "Sucursal:";
            // 
            // lbIva
            // 
            this.lbIva.AutoSize = true;
            this.lbIva.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIva.Location = new System.Drawing.Point(94, 289);
            this.lbIva.Name = "lbIva";
            this.lbIva.Size = new System.Drawing.Size(33, 17);
            this.lbIva.TabIndex = 83;
            this.lbIva.Text = "IVA:";
            // 
            // lbFH
            // 
            this.lbFH.AutoSize = true;
            this.lbFH.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFH.Location = new System.Drawing.Point(47, 228);
            this.lbFH.Name = "lbFH";
            this.lbFH.Size = new System.Drawing.Size(86, 17);
            this.lbFH.TabIndex = 82;
            this.lbFH.Text = "Fecha-Hora:";
            // 
            // lbN
            // 
            this.lbN.AutoSize = true;
            this.lbN.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbN.Location = new System.Drawing.Point(59, 153);
            this.lbN.Name = "lbN";
            this.lbN.Size = new System.Drawing.Size(75, 17);
            this.lbN.TabIndex = 81;
            this.lbN.Text = "Cantidad:";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(52, 59);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(82, 17);
            this.lbId.TabIndex = 80;
            this.lbId.Text = "Folio Ticket:";
            // 
            // cmbProd
            // 
            this.cmbProd.DataSource = this.productosBindingSource;
            this.cmbProd.DisplayMember = "Producto";
            this.cmbProd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProd.FormattingEnabled = true;
            this.cmbProd.Location = new System.Drawing.Point(135, 120);
            this.cmbProd.Name = "cmbProd";
            this.cmbProd.Size = new System.Drawing.Size(187, 25);
            this.cmbProd.TabIndex = 105;
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.tiendaTecDataSet;
            // 
            // tiendaTecDataSet
            // 
            this.tiendaTecDataSet.DataSetName = "TiendaTecDataSet";
            this.tiendaTecDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbProd
            // 
            this.lbProd.AutoSize = true;
            this.lbProd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProd.Location = new System.Drawing.Point(62, 123);
            this.lbProd.Name = "lbProd";
            this.lbProd.Size = new System.Drawing.Size(72, 17);
            this.lbProd.TabIndex = 104;
            this.lbProd.Text = "Producto:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Century Gothic", 12F);
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy hh:mm:ss";
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(135, 228);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(147, 23);
            this.dateTimePicker1.TabIndex = 107;
            this.dateTimePicker1.Value = new System.DateTime(2021, 5, 7, 0, 0, 0, 0);
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(400, 367);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(43, 17);
            this.lbTotal.TabIndex = 108;
            this.lbTotal.Text = "Total:";
            // 
            // lbTotalFinal
            // 
            this.lbTotalFinal.AutoSize = true;
            this.lbTotalFinal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalFinal.Location = new System.Drawing.Point(446, 367);
            this.lbTotalFinal.Name = "lbTotalFinal";
            this.lbTotalFinal.Size = new System.Drawing.Size(16, 17);
            this.lbTotalFinal.TabIndex = 109;
            this.lbTotalFinal.Text = "--";
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.DataSource = this.empleadosBindingSource;
            this.cmbEmpleado.DisplayMember = "Correo";
            this.cmbEmpleado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(135, 349);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(187, 25);
            this.cmbEmpleado.TabIndex = 111;
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataMember = "Empleados";
            this.empleadosBindingSource.DataSource = this.tiendaTecDataSet5;
            // 
            // tiendaTecDataSet5
            // 
            this.tiendaTecDataSet5.DataSetName = "TiendaTecDataSet5";
            this.tiendaTecDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbEmpl
            // 
            this.lbEmpl.AutoSize = true;
            this.lbEmpl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpl.Location = new System.Drawing.Point(56, 351);
            this.lbEmpl.Name = "lbEmpl";
            this.lbEmpl.Size = new System.Drawing.Size(79, 17);
            this.lbEmpl.TabIndex = 110;
            this.lbEmpl.Text = "Empleado:";
            // 
            // btnQuery
            // 
            this.btnQuery.AutoSize = true;
            this.btnQuery.FlatAppearance.BorderSize = 0;
            this.btnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuery.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.btnQuery.IconColor = System.Drawing.Color.Black;
            this.btnQuery.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQuery.IconSize = 20;
            this.btnQuery.Location = new System.Drawing.Point(535, 53);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(26, 26);
            this.btnQuery.TabIndex = 102;
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.AutoSize = true;
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.BtnBuscar.IconColor = System.Drawing.Color.Black;
            this.BtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBuscar.IconSize = 20;
            this.BtnBuscar.Location = new System.Drawing.Point(168, 11);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(26, 26);
            this.BtnBuscar.TabIndex = 97;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardar.IconColor = System.Drawing.Color.Green;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 20;
            this.btnGuardar.Location = new System.Drawing.Point(121, 11);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(26, 26);
            this.btnGuardar.TabIndex = 96;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.AutoSize = true;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnModificar.IconColor = System.Drawing.Color.Orange;
            this.btnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificar.IconSize = 20;
            this.btnModificar.Location = new System.Drawing.Point(82, 11);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(26, 26);
            this.btnModificar.TabIndex = 95;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.AutoSize = true;
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnBorrar.IconColor = System.Drawing.Color.Red;
            this.btnBorrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBorrar.IconSize = 20;
            this.btnBorrar.Location = new System.Drawing.Point(44, 11);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(26, 26);
            this.btnBorrar.TabIndex = 94;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSize = true;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnAgregar.IconColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.IconSize = 25;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(11, 11);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(31, 31);
            this.btnAgregar.TabIndex = 93;
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.AutoSize = true;
            this.btnUltimo.FlatAppearance.BorderSize = 0;
            this.btnUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUltimo.IconChar = FontAwesome.Sharp.IconChar.SortAmountDown;
            this.btnUltimo.IconColor = System.Drawing.Color.Black;
            this.btnUltimo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUltimo.IconSize = 20;
            this.btnUltimo.Location = new System.Drawing.Point(488, 310);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(26, 26);
            this.btnUltimo.TabIndex = 92;
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnPrimero
            // 
            this.btnPrimero.AutoSize = true;
            this.btnPrimero.FlatAppearance.BorderSize = 0;
            this.btnPrimero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimero.IconChar = FontAwesome.Sharp.IconChar.SortAmountUp;
            this.btnPrimero.IconColor = System.Drawing.Color.Black;
            this.btnPrimero.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrimero.IconSize = 20;
            this.btnPrimero.Location = new System.Drawing.Point(392, 310);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(26, 26);
            this.btnPrimero.TabIndex = 91;
            this.btnPrimero.UseVisualStyleBackColor = true;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.AutoSize = true;
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.btnSiguiente.IconColor = System.Drawing.Color.Black;
            this.btnSiguiente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSiguiente.IconSize = 20;
            this.btnSiguiente.Location = new System.Drawing.Point(456, 310);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(26, 26);
            this.btnSiguiente.TabIndex = 90;
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.AutoSize = true;
            this.btnAnterior.FlatAppearance.BorderSize = 0;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.btnAnterior.IconColor = System.Drawing.Color.Black;
            this.btnAnterior.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAnterior.IconSize = 20;
            this.btnAnterior.Location = new System.Drawing.Point(424, 310);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(26, 26);
            this.btnAnterior.TabIndex = 89;
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // rdbProd
            // 
            this.rdbProd.AutoSize = true;
            this.rdbProd.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbProd.Location = new System.Drawing.Point(11, 102);
            this.rdbProd.Margin = new System.Windows.Forms.Padding(2);
            this.rdbProd.Name = "rdbProd";
            this.rdbProd.Size = new System.Drawing.Size(96, 21);
            this.rdbProd.TabIndex = 112;
            this.rdbProd.TabStop = true;
            this.rdbProd.Text = "Productos:";
            this.rdbProd.UseVisualStyleBackColor = true;
            // 
            // rdbTicket
            // 
            this.rdbTicket.AutoSize = true;
            this.rdbTicket.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTicket.Location = new System.Drawing.Point(11, 207);
            this.rdbTicket.Margin = new System.Windows.Forms.Padding(2);
            this.rdbTicket.Name = "rdbTicket";
            this.rdbTicket.Size = new System.Drawing.Size(70, 21);
            this.rdbTicket.TabIndex = 113;
            this.rdbTicket.TabStop = true;
            this.rdbTicket.Text = "Ticket:";
            this.rdbTicket.UseVisualStyleBackColor = true;
            // 
            // lbSubtotal
            // 
            this.lbSubtotal.AutoSize = true;
            this.lbSubtotal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubtotal.Location = new System.Drawing.Point(446, 349);
            this.lbSubtotal.Name = "lbSubtotal";
            this.lbSubtotal.Size = new System.Drawing.Size(16, 17);
            this.lbSubtotal.TabIndex = 115;
            this.lbSubtotal.Text = "--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(376, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 114;
            this.label2.Text = "Subtotal:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 17);
            this.label1.TabIndex = 116;
            this.label1.Text = "%";
            // 
            // iconMostrar
            // 
            this.iconMostrar.BackColor = System.Drawing.SystemColors.Control;
            this.iconMostrar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconMostrar.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.iconMostrar.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.iconMostrar.IconColor = System.Drawing.Color.MediumSeaGreen;
            this.iconMostrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMostrar.IconSize = 22;
            this.iconMostrar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.iconMostrar.Location = new System.Drawing.Point(234, 286);
            this.iconMostrar.Margin = new System.Windows.Forms.Padding(2);
            this.iconMostrar.Name = "iconMostrar";
            this.iconMostrar.Size = new System.Drawing.Size(71, 24);
            this.iconMostrar.TabIndex = 117;
            this.iconMostrar.Text = "Total";
            this.iconMostrar.UseVisualStyleBackColor = false;
            this.iconMostrar.Click += new System.EventHandler(this.iconMostrar_Click);
            // 
            // btnCrearT
            // 
            this.btnCrearT.BackColor = System.Drawing.SystemColors.Control;
            this.btnCrearT.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearT.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCrearT.IconChar = FontAwesome.Sharp.IconChar.AlignJustify;
            this.btnCrearT.IconColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCrearT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCrearT.IconSize = 22;
            this.btnCrearT.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnCrearT.Location = new System.Drawing.Point(210, 11);
            this.btnCrearT.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearT.Name = "btnCrearT";
            this.btnCrearT.Size = new System.Drawing.Size(142, 24);
            this.btnCrearT.TabIndex = 118;
            this.btnCrearT.Text = "Detalles Ticket";
            this.btnCrearT.UseVisualStyleBackColor = false;
            this.btnCrearT.Click += new System.EventHandler(this.btnCrearT_Click);
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // tiendaTecDataSet1
            // 
            this.tiendaTecDataSet1.DataSetName = "TiendaTecDataSet1";
            this.tiendaTecDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tiendaTecDataSet1BindingSource
            // 
            this.tiendaTecDataSet1BindingSource.DataSource = this.tiendaTecDataSet1;
            this.tiendaTecDataSet1BindingSource.Position = 0;
            // 
            // sucursalesTableAdapter
            // 
            this.sucursalesTableAdapter.ClearBeforeFill = true;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // empleadosTableAdapter
            // 
            this.empleadosTableAdapter.ClearBeforeFill = true;
            // 
            // Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.btnCrearT);
            this.Controls.Add(this.iconMostrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbSubtotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdbTicket);
            this.Controls.Add(this.rdbProd);
            this.Controls.Add(this.cmbEmpleado);
            this.Controls.Add(this.lbEmpl);
            this.Controls.Add(this.lbTotalFinal);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbProd);
            this.Controls.Add(this.lbProd);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.cmbSucursal);
            this.Controls.Add(this.lbsueldo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.btnPrimero);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.txtIva);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lbS);
            this.Controls.Add(this.lbIva);
            this.Controls.Add(this.lbFH);
            this.Controls.Add(this.lbN);
            this.Controls.Add(this.lbId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Compra";
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.Compra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaTecDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaTecDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaTecDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaTecDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaTecDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaTecDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnQuery;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.ComboBox cmbSucursal;
        private System.Windows.Forms.Label lbsueldo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnModificar;
        private FontAwesome.Sharp.IconButton btnBorrar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private FontAwesome.Sharp.IconButton btnUltimo;
        private FontAwesome.Sharp.IconButton btnPrimero;
        private FontAwesome.Sharp.IconButton btnSiguiente;
        private FontAwesome.Sharp.IconButton btnAnterior;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lbS;
        private System.Windows.Forms.Label lbIva;
        private System.Windows.Forms.Label lbFH;
        private System.Windows.Forms.Label lbN;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.ComboBox cmbProd;
        private System.Windows.Forms.Label lbProd;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbTotalFinal;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.Label lbEmpl;
        private System.Windows.Forms.RadioButton rdbProd;
        private System.Windows.Forms.RadioButton rdbTicket;
        private System.Windows.Forms.Label lbSubtotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconMostrar;
        private FontAwesome.Sharp.IconButton btnCrearT;
        private TiendaTecDataSet tiendaTecDataSet;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private TiendaTecDataSetTableAdapters.ProductosTableAdapter productosTableAdapter;
        private System.Windows.Forms.BindingSource tiendaTecDataSet1BindingSource;
        private TiendaTecDataSet1 tiendaTecDataSet1;
        private TiendaTecDataSet3 tiendaTecDataSet3;
        private System.Windows.Forms.BindingSource sucursalesBindingSource;
        private TiendaTecDataSet3TableAdapters.SucursalesTableAdapter sucursalesTableAdapter;
        private TiendaTecDataSet4 tiendaTecDataSet4;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private TiendaTecDataSet4TableAdapters.ClientesTableAdapter clientesTableAdapter;
        private TiendaTecDataSet5 tiendaTecDataSet5;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private TiendaTecDataSet5TableAdapters.EmpleadosTableAdapter empleadosTableAdapter;
    }
}