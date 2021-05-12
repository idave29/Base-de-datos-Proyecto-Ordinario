
namespace Proyecto_Ordinario
{
    partial class Empleados
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnBuscar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.btnModificar = new FontAwesome.Sharp.IconButton();
            this.btnBorrar = new FontAwesome.Sharp.IconButton();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.btnUltimo = new FontAwesome.Sharp.IconButton();
            this.btnPrimero = new FontAwesome.Sharp.IconButton();
            this.btnSiguiente = new FontAwesome.Sharp.IconButton();
            this.btnAnterior = new FontAwesome.Sharp.IconButton();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtAM = new System.Windows.Forms.TextBox();
            this.txtAP = new System.Windows.Forms.TextBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lbC = new System.Windows.Forms.Label();
            this.lbAM = new System.Windows.Forms.Label();
            this.lbAP = new System.Windows.Forms.Label();
            this.lbN = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.lbContra = new System.Windows.Forms.Label();
            this.lbNac = new System.Windows.Forms.Label();
            this.lbIdpuesto = new System.Windows.Forms.Label();
            this.lbsueldo = new System.Windows.Forms.Label();
            this.cmbPuesto = new System.Windows.Forms.ComboBox();
            this.puestosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiendaTecDataSetPuestos = new Proyecto_Ordinario.TiendaTecDataSetPuestos();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnQuery = new FontAwesome.Sharp.IconButton();
            this.puestosTableAdapter = new Proyecto_Ordinario.TiendaTecDataSetPuestosTableAdapters.PuestosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puestosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaTecDataSetPuestos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(464, 57);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(320, 270);
            this.dataGridView1.TabIndex = 44;
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
            this.BtnBuscar.Location = new System.Drawing.Point(235, 15);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(35, 32);
            this.BtnBuscar.TabIndex = 43;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            this.btnGuardar.IconColor = System.Drawing.Color.Green;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 20;
            this.btnGuardar.Location = new System.Drawing.Point(172, 15);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(35, 32);
            this.btnGuardar.TabIndex = 42;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.AutoSize = true;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnModificar.IconColor = System.Drawing.Color.Orange;
            this.btnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificar.IconSize = 20;
            this.btnModificar.Location = new System.Drawing.Point(121, 15);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(35, 32);
            this.btnModificar.TabIndex = 41;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.AutoSize = true;
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.btnBorrar.IconColor = System.Drawing.Color.Red;
            this.btnBorrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBorrar.IconSize = 20;
            this.btnBorrar.Location = new System.Drawing.Point(64, 15);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(35, 32);
            this.btnBorrar.TabIndex = 40;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSize = true;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnAgregar.IconColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.IconSize = 20;
            this.btnAgregar.Location = new System.Drawing.Point(9, 15);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(35, 32);
            this.btnAgregar.TabIndex = 39;
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
            this.btnUltimo.Location = new System.Drawing.Point(673, 334);
            this.btnUltimo.Margin = new System.Windows.Forms.Padding(4);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(35, 32);
            this.btnUltimo.TabIndex = 38;
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
            this.btnPrimero.Location = new System.Drawing.Point(545, 334);
            this.btnPrimero.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(35, 32);
            this.btnPrimero.TabIndex = 37;
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
            this.btnSiguiente.Location = new System.Drawing.Point(631, 334);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(4);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(35, 32);
            this.btnSiguiente.TabIndex = 36;
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
            this.btnAnterior.Location = new System.Drawing.Point(588, 334);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(35, 32);
            this.btnAnterior.TabIndex = 35;
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // txtC
            // 
            this.txtC.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC.Location = new System.Drawing.Point(207, 263);
            this.txtC.Margin = new System.Windows.Forms.Padding(4);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(248, 27);
            this.txtC.TabIndex = 34;
            // 
            // txtAM
            // 
            this.txtAM.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAM.Location = new System.Drawing.Point(207, 212);
            this.txtAM.Margin = new System.Windows.Forms.Padding(4);
            this.txtAM.Name = "txtAM";
            this.txtAM.Size = new System.Drawing.Size(248, 27);
            this.txtAM.TabIndex = 33;
            // 
            // txtAP
            // 
            this.txtAP.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAP.Location = new System.Drawing.Point(207, 162);
            this.txtAP.Margin = new System.Windows.Forms.Padding(4);
            this.txtAP.Name = "txtAP";
            this.txtAP.Size = new System.Drawing.Size(248, 27);
            this.txtAP.TabIndex = 32;
            // 
            // txtN
            // 
            this.txtN.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN.Location = new System.Drawing.Point(207, 111);
            this.txtN.Margin = new System.Windows.Forms.Padding(4);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(248, 27);
            this.txtN.TabIndex = 31;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(207, 57);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(248, 27);
            this.txtId.TabIndex = 30;
            // 
            // lbC
            // 
            this.lbC.AutoSize = true;
            this.lbC.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbC.Location = new System.Drawing.Point(123, 267);
            this.lbC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbC.Name = "lbC";
            this.lbC.Size = new System.Drawing.Size(72, 21);
            this.lbC.TabIndex = 29;
            this.lbC.Text = "Correo:";
            // 
            // lbAM
            // 
            this.lbAM.AutoSize = true;
            this.lbAM.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAM.Location = new System.Drawing.Point(39, 212);
            this.lbAM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAM.Name = "lbAM";
            this.lbAM.Size = new System.Drawing.Size(161, 21);
            this.lbAM.TabIndex = 28;
            this.lbAM.Text = "Apellido Materno:";
            // 
            // lbAP
            // 
            this.lbAP.AutoSize = true;
            this.lbAP.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAP.Location = new System.Drawing.Point(43, 166);
            this.lbAP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAP.Name = "lbAP";
            this.lbAP.Size = new System.Drawing.Size(154, 21);
            this.lbAP.TabIndex = 27;
            this.lbAP.Text = "Apellido Paterno:";
            // 
            // lbN
            // 
            this.lbN.AutoSize = true;
            this.lbN.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbN.Location = new System.Drawing.Point(92, 114);
            this.lbN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbN.Name = "lbN";
            this.lbN.Size = new System.Drawing.Size(106, 21);
            this.lbN.TabIndex = 26;
            this.lbN.Text = "Nombre (s):";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(165, 60);
            this.lbId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(33, 21);
            this.lbId.TabIndex = 25;
            this.lbId.Text = "ID:";
            // 
            // txtContra
            // 
            this.txtContra.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContra.Location = new System.Drawing.Point(207, 449);
            this.txtContra.Margin = new System.Windows.Forms.Padding(4);
            this.txtContra.Name = "txtContra";
            this.txtContra.PasswordChar = '*';
            this.txtContra.Size = new System.Drawing.Size(248, 27);
            this.txtContra.TabIndex = 52;
            // 
            // txtSueldo
            // 
            this.txtSueldo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSueldo.Location = new System.Drawing.Point(207, 311);
            this.txtSueldo.Margin = new System.Windows.Forms.Padding(4);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(248, 27);
            this.txtSueldo.TabIndex = 49;
            // 
            // lbContra
            // 
            this.lbContra.AutoSize = true;
            this.lbContra.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContra.Location = new System.Drawing.Point(81, 453);
            this.lbContra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbContra.Name = "lbContra";
            this.lbContra.Size = new System.Drawing.Size(114, 21);
            this.lbContra.TabIndex = 48;
            this.lbContra.Text = "Contraseña:";
            // 
            // lbNac
            // 
            this.lbNac.AutoSize = true;
            this.lbNac.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNac.Location = new System.Drawing.Point(61, 402);
            this.lbNac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNac.Name = "lbNac";
            this.lbNac.Size = new System.Drawing.Size(136, 21);
            this.lbNac.TabIndex = 47;
            this.lbNac.Text = "Fecha de Nac:";
            // 
            // lbIdpuesto
            // 
            this.lbIdpuesto.AutoSize = true;
            this.lbIdpuesto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdpuesto.Location = new System.Drawing.Point(103, 357);
            this.lbIdpuesto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIdpuesto.Name = "lbIdpuesto";
            this.lbIdpuesto.Size = new System.Drawing.Size(94, 21);
            this.lbIdpuesto.TabIndex = 46;
            this.lbIdpuesto.Text = "ID Puesto:";
            // 
            // lbsueldo
            // 
            this.lbsueldo.AutoSize = true;
            this.lbsueldo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsueldo.Location = new System.Drawing.Point(125, 319);
            this.lbsueldo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbsueldo.Name = "lbsueldo";
            this.lbsueldo.Size = new System.Drawing.Size(70, 21);
            this.lbsueldo.TabIndex = 45;
            this.lbsueldo.Text = "Sueldo:";
            // 
            // cmbPuesto
            // 
            this.cmbPuesto.DataSource = this.puestosBindingSource;
            this.cmbPuesto.DisplayMember = "Descripcion";
            this.cmbPuesto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPuesto.FormattingEnabled = true;
            this.cmbPuesto.Location = new System.Drawing.Point(207, 353);
            this.cmbPuesto.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPuesto.Name = "cmbPuesto";
            this.cmbPuesto.Size = new System.Drawing.Size(248, 29);
            this.cmbPuesto.TabIndex = 53;
            this.cmbPuesto.ValueMember = "Id_Puesto";
            // 
            // puestosBindingSource
            // 
            this.puestosBindingSource.DataMember = "Puestos";
            this.puestosBindingSource.DataSource = this.tiendaTecDataSetPuestos;
            // 
            // tiendaTecDataSetPuestos
            // 
            this.tiendaTecDataSetPuestos.DataSetName = "TiendaTecDataSetPuestos";
            this.tiendaTecDataSetPuestos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Century Gothic", 12F);
            this.dateTimePicker1.CustomFormat = "MM-dd-yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(207, 402);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(138, 27);
            this.dateTimePicker1.TabIndex = 55;
            this.dateTimePicker1.Value = new System.DateTime(2021, 5, 7, 0, 0, 0, 0);
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
            this.btnQuery.Location = new System.Drawing.Point(749, 17);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(35, 32);
            this.btnQuery.TabIndex = 80;
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // puestosTableAdapter
            // 
            this.puestosTableAdapter.ClearBeforeFill = true;
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbPuesto);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.lbContra);
            this.Controls.Add(this.lbNac);
            this.Controls.Add(this.lbIdpuesto);
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
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtAM);
            this.Controls.Add(this.txtAP);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lbC);
            this.Controls.Add(this.lbAM);
            this.Controls.Add(this.lbAP);
            this.Controls.Add(this.lbN);
            this.Controls.Add(this.lbId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Empleados";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.Empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puestosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaTecDataSetPuestos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtAM;
        private System.Windows.Forms.TextBox txtAP;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lbC;
        private System.Windows.Forms.Label lbAM;
        private System.Windows.Forms.Label lbAP;
        private System.Windows.Forms.Label lbN;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.Label lbContra;
        private System.Windows.Forms.Label lbNac;
        private System.Windows.Forms.Label lbIdpuesto;
        private System.Windows.Forms.Label lbsueldo;
        private System.Windows.Forms.ComboBox cmbPuesto;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private FontAwesome.Sharp.IconButton btnQuery;
        private TiendaTecDataSetPuestos tiendaTecDataSetPuestos;
        private System.Windows.Forms.BindingSource puestosBindingSource;
        private TiendaTecDataSetPuestosTableAdapters.PuestosTableAdapter puestosTableAdapter;
    }
}