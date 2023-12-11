namespace ProyectoDAM.Pantallas_Inventario
{
    partial class ReporteInvcs
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
            PanelInventario = new Panel();
            btn_Agrega = new Button();
            txt_filt = new TextBox();
            lbl_filt = new Label();
            lbl_ID = new Label();
            btn_borrar = new Button();
            txt_Id = new TextBox();
            dgvProductos = new DataGridView();
            id_product = new DataGridViewTextBoxColumn();
            id_prov = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            color = new DataGridViewTextBoxColumn();
            mat_fab = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            marca = new DataGridViewTextBoxColumn();
            tipo = new DataGridViewTextBoxColumn();
            conexion = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            PanelInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PanelInventario
            // 
            PanelInventario.BackColor = Color.LightSkyBlue;
            PanelInventario.Controls.Add(btn_Agrega);
            PanelInventario.Controls.Add(txt_filt);
            PanelInventario.Controls.Add(lbl_filt);
            PanelInventario.Controls.Add(lbl_ID);
            PanelInventario.Controls.Add(btn_borrar);
            PanelInventario.Controls.Add(txt_Id);
            PanelInventario.Controls.Add(dgvProductos);
            PanelInventario.Controls.Add(label2);
            PanelInventario.Controls.Add(label1);
            PanelInventario.Controls.Add(pictureBox1);
            PanelInventario.Dock = DockStyle.Fill;
            PanelInventario.Location = new Point(0, 0);
            PanelInventario.Name = "PanelInventario";
            PanelInventario.Size = new Size(800, 450);
            PanelInventario.TabIndex = 0;
            PanelInventario.Paint += PanelInventario_Paint;
            // 
            // btn_Agrega
            // 
            btn_Agrega.Location = new Point(631, 69);
            btn_Agrega.Name = "btn_Agrega";
            btn_Agrega.Size = new Size(94, 29);
            btn_Agrega.TabIndex = 9;
            btn_Agrega.Text = "Agregar Producto";
            btn_Agrega.UseVisualStyleBackColor = true;
            btn_Agrega.Click += btn_Agrega_Click;
            // 
            // txt_filt
            // 
            txt_filt.Location = new Point(174, 130);
            txt_filt.Name = "txt_filt";
            txt_filt.Size = new Size(262, 27);
            txt_filt.TabIndex = 8;
            txt_filt.TextChanged += txt_filt_TextChanged;
            // 
            // lbl_filt
            // 
            lbl_filt.AutoSize = true;
            lbl_filt.BackColor = Color.LightSkyBlue;
            lbl_filt.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_filt.ForeColor = Color.White;
            lbl_filt.Location = new Point(28, 124);
            lbl_filt.Name = "lbl_filt";
            lbl_filt.Size = new Size(79, 31);
            lbl_filt.TabIndex = 7;
            lbl_filt.Text = "Filtrar";
            // 
            // lbl_ID
            // 
            lbl_ID.AutoSize = true;
            lbl_ID.BackColor = Color.LightSkyBlue;
            lbl_ID.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_ID.ForeColor = Color.White;
            lbl_ID.Location = new Point(28, 63);
            lbl_ID.Name = "lbl_ID";
            lbl_ID.Size = new Size(143, 31);
            lbl_ID.TabIndex = 6;
            lbl_ID.Text = "ID Producto";
            // 
            // btn_borrar
            // 
            btn_borrar.Location = new Point(351, 68);
            btn_borrar.Name = "btn_borrar";
            btn_borrar.Size = new Size(94, 29);
            btn_borrar.TabIndex = 5;
            btn_borrar.Text = "Borrar";
            btn_borrar.UseVisualStyleBackColor = true;
            btn_borrar.Click += btn_borrar_Click;
            // 
            // txt_Id
            // 
            txt_Id.Location = new Point(196, 69);
            txt_Id.Name = "txt_Id";
            txt_Id.Size = new Size(125, 27);
            txt_Id.TabIndex = 4;
            // 
            // dgvProductos
            // 
            dgvProductos.BackgroundColor = Color.White;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { id_product, id_prov, nombre, color, mat_fab, precio, marca, tipo, conexion });
            dgvProductos.Location = new Point(0, 189);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(800, 249);
            dgvProductos.TabIndex = 3;
            dgvProductos.CellClick += dgvProductos_CellClick;
            // 
            // id_product
            // 
            id_product.HeaderText = "ID";
            id_product.MinimumWidth = 6;
            id_product.Name = "id_product";
            id_product.Width = 125;
            // 
            // id_prov
            // 
            id_prov.HeaderText = "ID Prov";
            id_prov.MinimumWidth = 6;
            id_prov.Name = "id_prov";
            id_prov.Width = 125;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            nombre.Width = 125;
            // 
            // color
            // 
            color.HeaderText = "Color";
            color.MinimumWidth = 6;
            color.Name = "color";
            color.ReadOnly = true;
            color.Width = 125;
            // 
            // mat_fab
            // 
            mat_fab.HeaderText = "M/F";
            mat_fab.MinimumWidth = 6;
            mat_fab.Name = "mat_fab";
            mat_fab.ReadOnly = true;
            mat_fab.Width = 125;
            // 
            // precio
            // 
            precio.HeaderText = "Precio";
            precio.MinimumWidth = 6;
            precio.Name = "precio";
            precio.ReadOnly = true;
            precio.Width = 125;
            // 
            // marca
            // 
            marca.HeaderText = "Marca";
            marca.MinimumWidth = 6;
            marca.Name = "marca";
            marca.ReadOnly = true;
            marca.Width = 125;
            // 
            // tipo
            // 
            tipo.HeaderText = "Tipo";
            tipo.MinimumWidth = 6;
            tipo.Name = "tipo";
            tipo.ReadOnly = true;
            tipo.Width = 125;
            // 
            // conexion
            // 
            conexion.HeaderText = "Conexión";
            conexion.MinimumWidth = 6;
            conexion.Name = "conexion";
            conexion.Width = 125;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SteelBlue;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(642, 18);
            label2.Name = "label2";
            label2.Size = new Size(106, 31);
            label2.TabIndex = 2;
            label2.Text = "Regresar";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SteelBlue;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(312, 18);
            label1.Name = "label1";
            label1.Size = new Size(124, 31);
            label1.TabIndex = 1;
            label1.Text = "Inventario";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.SteelBlue;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 63);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // ReporteInvcs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PanelInventario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReporteInvcs";
            Text = "ReporteInvcs";
            PanelInventario.ResumeLayout(false);
            PanelInventario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelInventario;
        private Label label1;
        private PictureBox pictureBox1;
        private DataGridView dgvProductos;
        private Label label2;
        private DataGridViewTextBoxColumn id_product;
        private DataGridViewTextBoxColumn id_prov;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn color;
        private DataGridViewTextBoxColumn mat_fab;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn marca;
        private DataGridViewTextBoxColumn tipo;
        private DataGridViewTextBoxColumn conexion;
        private Label lbl_ID;
        private Button btn_borrar;
        private TextBox txt_Id;
        private TextBox txt_filt;
        private Label lbl_filt;
        private Button btn_Agrega;
    }
}