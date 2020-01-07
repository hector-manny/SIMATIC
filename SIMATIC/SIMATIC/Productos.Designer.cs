namespace SIMATIC
{
    partial class Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            this.btnCerrarProducto = new System.Windows.Forms.Label();
            this.pRegistrosProductos = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnModificarProducto = new System.Windows.Forms.Button();
            this.tbPVentaModificar = new System.Windows.Forms.TextBox();
            this.tbPCostoModificar = new System.Windows.Forms.TextBox();
            this.tbUnidadesModificar = new System.Windows.Forms.TextBox();
            this.tbCodigoModificar = new System.Windows.Forms.TextBox();
            this.tbDescripcionModificar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.tbNRCBuscarCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pAddProducto = new System.Windows.Forms.Panel();
            this.btnLimpiarProducto = new System.Windows.Forms.Button();
            this.btnGuardarProducto = new System.Windows.Forms.Button();
            this.tbPrecioVentaProducto = new System.Windows.Forms.TextBox();
            this.tbPrecioCostoProducto = new System.Windows.Forms.TextBox();
            this.tbUnidadesProducto = new System.Windows.Forms.TextBox();
            this.tbCodigoProducto = new System.Windows.Forms.TextBox();
            this.tbDescripcionProducto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistroProducto = new System.Windows.Forms.Button();
            this.btnAddProducto = new System.Windows.Forms.Button();
            this.pRegistrosProductos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pAddProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrarProducto
            // 
            this.btnCerrarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarProducto.AutoSize = true;
            this.btnCerrarProducto.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCerrarProducto.Location = new System.Drawing.Point(888, 8);
            this.btnCerrarProducto.Name = "btnCerrarProducto";
            this.btnCerrarProducto.Size = new System.Drawing.Size(20, 20);
            this.btnCerrarProducto.TabIndex = 12;
            this.btnCerrarProducto.Text = "X";
            this.btnCerrarProducto.Click += new System.EventHandler(this.btnCerrarProducto_Click);
            // 
            // pRegistrosProductos
            // 
            this.pRegistrosProductos.Controls.Add(this.groupBox1);
            this.pRegistrosProductos.Controls.Add(this.btnBuscarProducto);
            this.pRegistrosProductos.Controls.Add(this.tbNRCBuscarCliente);
            this.pRegistrosProductos.Controls.Add(this.label6);
            this.pRegistrosProductos.Controls.Add(this.dataGridView1);
            this.pRegistrosProductos.Location = new System.Drawing.Point(-1, 67);
            this.pRegistrosProductos.Name = "pRegistrosProductos";
            this.pRegistrosProductos.Size = new System.Drawing.Size(909, 514);
            this.pRegistrosProductos.TabIndex = 11;
            this.pRegistrosProductos.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnModificarProducto);
            this.groupBox1.Controls.Add(this.tbPVentaModificar);
            this.groupBox1.Controls.Add(this.tbPCostoModificar);
            this.groupBox1.Controls.Add(this.tbUnidadesModificar);
            this.groupBox1.Controls.Add(this.tbCodigoModificar);
            this.groupBox1.Controls.Add(this.tbDescripcionModificar);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(588, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 499);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modificar";
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnModificarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarProducto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarProducto.Image")));
            this.btnModificarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarProducto.Location = new System.Drawing.Point(30, 418);
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.Size = new System.Drawing.Size(210, 64);
            this.btnModificarProducto.TabIndex = 20;
            this.btnModificarProducto.Text = "       Modificar";
            this.btnModificarProducto.UseVisualStyleBackColor = true;
            // 
            // tbPVentaModificar
            // 
            this.tbPVentaModificar.Location = new System.Drawing.Point(33, 371);
            this.tbPVentaModificar.Name = "tbPVentaModificar";
            this.tbPVentaModificar.Size = new System.Drawing.Size(159, 30);
            this.tbPVentaModificar.TabIndex = 19;
            // 
            // tbPCostoModificar
            // 
            this.tbPCostoModificar.Location = new System.Drawing.Point(30, 298);
            this.tbPCostoModificar.Name = "tbPCostoModificar";
            this.tbPCostoModificar.Size = new System.Drawing.Size(159, 30);
            this.tbPCostoModificar.TabIndex = 18;
            // 
            // tbUnidadesModificar
            // 
            this.tbUnidadesModificar.Location = new System.Drawing.Point(30, 226);
            this.tbUnidadesModificar.Name = "tbUnidadesModificar";
            this.tbUnidadesModificar.Size = new System.Drawing.Size(159, 30);
            this.tbUnidadesModificar.TabIndex = 17;
            // 
            // tbCodigoModificar
            // 
            this.tbCodigoModificar.Location = new System.Drawing.Point(30, 67);
            this.tbCodigoModificar.Name = "tbCodigoModificar";
            this.tbCodigoModificar.Size = new System.Drawing.Size(159, 30);
            this.tbCodigoModificar.TabIndex = 16;
            // 
            // tbDescripcionModificar
            // 
            this.tbDescripcionModificar.Location = new System.Drawing.Point(30, 147);
            this.tbDescripcionModificar.Name = "tbDescripcionModificar";
            this.tbDescripcionModificar.Size = new System.Drawing.Size(159, 30);
            this.tbDescripcionModificar.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Precio de venta:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 23);
            this.label8.TabIndex = 13;
            this.label8.Text = "Precio de costo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(219, 23);
            this.label9.TabIndex = 12;
            this.label9.Text = "Unidades disponibles:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(26, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(264, 23);
            this.label10.TabIndex = 11;
            this.label10.Text = "Descripción del producto:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(26, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 23);
            this.label11.TabIndex = 10;
            this.label11.Text = "Código:";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProducto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarProducto.Image")));
            this.btnBuscarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarProducto.Location = new System.Drawing.Point(287, 43);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(183, 62);
            this.btnBuscarProducto.TabIndex = 3;
            this.btnBuscarProducto.Text = "       Buscar";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            // 
            // tbNRCBuscarCliente
            // 
            this.tbNRCBuscarCliente.Location = new System.Drawing.Point(124, 65);
            this.tbNRCBuscarCliente.Name = "tbNRCBuscarCliente";
            this.tbNRCBuscarCliente.Size = new System.Drawing.Size(141, 26);
            this.tbNRCBuscarCliente.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "NRC:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(521, 387);
            this.dataGridView1.TabIndex = 0;
            // 
            // pAddProducto
            // 
            this.pAddProducto.Controls.Add(this.btnLimpiarProducto);
            this.pAddProducto.Controls.Add(this.btnGuardarProducto);
            this.pAddProducto.Controls.Add(this.tbPrecioVentaProducto);
            this.pAddProducto.Controls.Add(this.tbPrecioCostoProducto);
            this.pAddProducto.Controls.Add(this.tbUnidadesProducto);
            this.pAddProducto.Controls.Add(this.tbCodigoProducto);
            this.pAddProducto.Controls.Add(this.tbDescripcionProducto);
            this.pAddProducto.Controls.Add(this.label5);
            this.pAddProducto.Controls.Add(this.label4);
            this.pAddProducto.Controls.Add(this.label3);
            this.pAddProducto.Controls.Add(this.label2);
            this.pAddProducto.Controls.Add(this.label1);
            this.pAddProducto.Location = new System.Drawing.Point(-1, 77);
            this.pAddProducto.Name = "pAddProducto";
            this.pAddProducto.Size = new System.Drawing.Size(909, 443);
            this.pAddProducto.TabIndex = 10;
            // 
            // btnLimpiarProducto
            // 
            this.btnLimpiarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnLimpiarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarProducto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarProducto.Location = new System.Drawing.Point(365, 300);
            this.btnLimpiarProducto.Name = "btnLimpiarProducto";
            this.btnLimpiarProducto.Size = new System.Drawing.Size(130, 56);
            this.btnLimpiarProducto.TabIndex = 11;
            this.btnLimpiarProducto.Text = "Limpiar";
            this.btnLimpiarProducto.UseVisualStyleBackColor = true;
            // 
            // btnGuardarProducto
            // 
            this.btnGuardarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnGuardarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarProducto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarProducto.Location = new System.Drawing.Point(163, 300);
            this.btnGuardarProducto.Name = "btnGuardarProducto";
            this.btnGuardarProducto.Size = new System.Drawing.Size(128, 56);
            this.btnGuardarProducto.TabIndex = 10;
            this.btnGuardarProducto.Text = "Guardar";
            this.btnGuardarProducto.UseVisualStyleBackColor = true;
            // 
            // tbPrecioVentaProducto
            // 
            this.tbPrecioVentaProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPrecioVentaProducto.Location = new System.Drawing.Point(437, 255);
            this.tbPrecioVentaProducto.Name = "tbPrecioVentaProducto";
            this.tbPrecioVentaProducto.Size = new System.Drawing.Size(159, 26);
            this.tbPrecioVentaProducto.TabIndex = 9;
            // 
            // tbPrecioCostoProducto
            // 
            this.tbPrecioCostoProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPrecioCostoProducto.Location = new System.Drawing.Point(437, 202);
            this.tbPrecioCostoProducto.Name = "tbPrecioCostoProducto";
            this.tbPrecioCostoProducto.Size = new System.Drawing.Size(159, 26);
            this.tbPrecioCostoProducto.TabIndex = 8;
            // 
            // tbUnidadesProducto
            // 
            this.tbUnidadesProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUnidadesProducto.Location = new System.Drawing.Point(437, 153);
            this.tbUnidadesProducto.Name = "tbUnidadesProducto";
            this.tbUnidadesProducto.Size = new System.Drawing.Size(159, 26);
            this.tbUnidadesProducto.TabIndex = 7;
            // 
            // tbCodigoProducto
            // 
            this.tbCodigoProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCodigoProducto.Location = new System.Drawing.Point(437, 67);
            this.tbCodigoProducto.Name = "tbCodigoProducto";
            this.tbCodigoProducto.Size = new System.Drawing.Size(159, 26);
            this.tbCodigoProducto.TabIndex = 6;
            // 
            // tbDescripcionProducto
            // 
            this.tbDescripcionProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescripcionProducto.Location = new System.Drawing.Point(437, 109);
            this.tbDescripcionProducto.Name = "tbDescripcionProducto";
            this.tbDescripcionProducto.Size = new System.Drawing.Size(159, 26);
            this.tbDescripcionProducto.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(159, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio de venta:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(159, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio de costo:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(159, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Unidades:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción del producto:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // btnRegistroProducto
            // 
            this.btnRegistroProducto.BackColor = System.Drawing.Color.LightBlue;
            this.btnRegistroProducto.FlatAppearance.BorderSize = 0;
            this.btnRegistroProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnRegistroProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistroProducto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRegistroProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistroProducto.Image")));
            this.btnRegistroProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistroProducto.Location = new System.Drawing.Point(162, -1);
            this.btnRegistroProducto.Name = "btnRegistroProducto";
            this.btnRegistroProducto.Size = new System.Drawing.Size(163, 62);
            this.btnRegistroProducto.TabIndex = 9;
            this.btnRegistroProducto.Text = "       Registros";
            this.btnRegistroProducto.UseVisualStyleBackColor = false;
            this.btnRegistroProducto.Click += new System.EventHandler(this.btnRegistroProducto_Click);
            // 
            // btnAddProducto
            // 
            this.btnAddProducto.BackColor = System.Drawing.Color.LightBlue;
            this.btnAddProducto.FlatAppearance.BorderSize = 0;
            this.btnAddProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnAddProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProducto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProducto.Image")));
            this.btnAddProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProducto.Location = new System.Drawing.Point(-1, -1);
            this.btnAddProducto.Name = "btnAddProducto";
            this.btnAddProducto.Size = new System.Drawing.Size(163, 62);
            this.btnAddProducto.TabIndex = 8;
            this.btnAddProducto.Text = "       Agregar";
            this.btnAddProducto.UseVisualStyleBackColor = false;
            this.btnAddProducto.Click += new System.EventHandler(this.btnAddProducto_Click);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 611);
            this.Controls.Add(this.btnCerrarProducto);
            this.Controls.Add(this.pRegistrosProductos);
            this.Controls.Add(this.pAddProducto);
            this.Controls.Add(this.btnRegistroProducto);
            this.Controls.Add(this.btnAddProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Productos";
            this.Text = "Productos";
            this.pRegistrosProductos.ResumeLayout(false);
            this.pRegistrosProductos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pAddProducto.ResumeLayout(false);
            this.pAddProducto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnCerrarProducto;
        private System.Windows.Forms.Panel pRegistrosProductos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnModificarProducto;
        private System.Windows.Forms.TextBox tbPVentaModificar;
        private System.Windows.Forms.TextBox tbPCostoModificar;
        private System.Windows.Forms.TextBox tbUnidadesModificar;
        private System.Windows.Forms.TextBox tbCodigoModificar;
        private System.Windows.Forms.TextBox tbDescripcionModificar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.TextBox tbNRCBuscarCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pAddProducto;
        private System.Windows.Forms.Button btnLimpiarProducto;
        private System.Windows.Forms.Button btnGuardarProducto;
        private System.Windows.Forms.TextBox tbPrecioVentaProducto;
        private System.Windows.Forms.TextBox tbPrecioCostoProducto;
        private System.Windows.Forms.TextBox tbUnidadesProducto;
        private System.Windows.Forms.TextBox tbCodigoProducto;
        private System.Windows.Forms.TextBox tbDescripcionProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistroProducto;
        private System.Windows.Forms.Button btnAddProducto;
    }
}