namespace ProyectoDAM.Pantallas_Proveedor
{
    partial class MercancíaR
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
            PanelPedido = new Panel();
            txt_filtrar = new TextBox();
            lbl_filt = new Label();
            Solicitar_P = new Button();
            dgvPedidos = new DataGridView();
            id_prov = new DataGridViewTextBoxColumn();
            id_pedido = new DataGridViewTextBoxColumn();
            producto = new DataGridViewTextBoxColumn();
            unidades = new DataGridViewTextBoxColumn();
            txt_IdPedidoP = new TextBox();
            btn_DevP = new Button();
            txt_UniP = new TextBox();
            txt_ProducP = new TextBox();
            txt_idP = new TextBox();
            lbl_ProducP = new Label();
            lbl_UnidadesP = new Label();
            lbl_PedidoP = new Label();
            lbl_ProvP = new Label();
            lbl_RegP = new Label();
            lbl_Merc = new Label();
            pictureBox1 = new PictureBox();
            PanelPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PanelPedido
            // 
            PanelPedido.BackColor = Color.LightSkyBlue;
            PanelPedido.Controls.Add(txt_filtrar);
            PanelPedido.Controls.Add(lbl_filt);
            PanelPedido.Controls.Add(Solicitar_P);
            PanelPedido.Controls.Add(dgvPedidos);
            PanelPedido.Controls.Add(txt_IdPedidoP);
            PanelPedido.Controls.Add(btn_DevP);
            PanelPedido.Controls.Add(txt_UniP);
            PanelPedido.Controls.Add(txt_ProducP);
            PanelPedido.Controls.Add(txt_idP);
            PanelPedido.Controls.Add(lbl_ProducP);
            PanelPedido.Controls.Add(lbl_UnidadesP);
            PanelPedido.Controls.Add(lbl_PedidoP);
            PanelPedido.Controls.Add(lbl_ProvP);
            PanelPedido.Controls.Add(lbl_RegP);
            PanelPedido.Controls.Add(lbl_Merc);
            PanelPedido.Controls.Add(pictureBox1);
            PanelPedido.Dock = DockStyle.Fill;
            PanelPedido.Location = new Point(0, 0);
            PanelPedido.Name = "PanelPedido";
            PanelPedido.Size = new Size(888, 500);
            PanelPedido.TabIndex = 0;
            PanelPedido.Paint += PanelPedido_Paint;
            // 
            // txt_filtrar
            // 
            txt_filtrar.Location = new Point(411, 190);
            txt_filtrar.Name = "txt_filtrar";
            txt_filtrar.Size = new Size(189, 27);
            txt_filtrar.TabIndex = 16;
            txt_filtrar.TextChanged += txt_filtrar_TextChanged;
            // 
            // lbl_filt
            // 
            lbl_filt.AutoSize = true;
            lbl_filt.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_filt.Location = new Point(343, 190);
            lbl_filt.Name = "lbl_filt";
            lbl_filt.Size = new Size(59, 23);
            lbl_filt.TabIndex = 15;
            lbl_filt.Text = "Filtrar";
            // 
            // Solicitar_P
            // 
            Solicitar_P.BackColor = Color.SkyBlue;
            Solicitar_P.Location = new Point(411, 138);
            Solicitar_P.Name = "Solicitar_P";
            Solicitar_P.Size = new Size(170, 40);
            Solicitar_P.TabIndex = 14;
            Solicitar_P.Text = "Solicitar";
            Solicitar_P.UseVisualStyleBackColor = false;
            Solicitar_P.Click += Solicitar_P_Click;
            // 
            // dgvPedidos
            // 
            dgvPedidos.BackgroundColor = Color.White;
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Columns.AddRange(new DataGridViewColumn[] { id_prov, id_pedido, producto, unidades });
            dgvPedidos.Location = new Point(162, 223);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.RowHeadersWidth = 51;
            dgvPedidos.Size = new Size(552, 274);
            dgvPedidos.TabIndex = 13;
            dgvPedidos.CellClick += dgvPedidos_CellClick;
            // 
            // id_prov
            // 
            id_prov.HeaderText = "ID Provedor";
            id_prov.MinimumWidth = 6;
            id_prov.Name = "id_prov";
            id_prov.ReadOnly = true;
            id_prov.Width = 125;
            // 
            // id_pedido
            // 
            id_pedido.HeaderText = "ID Pedido";
            id_pedido.MinimumWidth = 6;
            id_pedido.Name = "id_pedido";
            id_pedido.Width = 125;
            // 
            // producto
            // 
            producto.HeaderText = "Producto";
            producto.MinimumWidth = 6;
            producto.Name = "producto";
            producto.Width = 125;
            // 
            // unidades
            // 
            unidades.HeaderText = "Unidades";
            unidades.MinimumWidth = 6;
            unidades.Name = "unidades";
            unidades.Width = 125;
            // 
            // txt_IdPedidoP
            // 
            txt_IdPedidoP.Location = new Point(687, 72);
            txt_IdPedidoP.Name = "txt_IdPedidoP";
            txt_IdPedidoP.Size = new Size(189, 27);
            txt_IdPedidoP.TabIndex = 12;
            // 
            // btn_DevP
            // 
            btn_DevP.BackColor = Color.SkyBlue;
            btn_DevP.Location = new Point(706, 118);
            btn_DevP.Name = "btn_DevP";
            btn_DevP.Size = new Size(170, 40);
            btn_DevP.TabIndex = 11;
            btn_DevP.Text = "Devolver Pedido";
            btn_DevP.UseVisualStyleBackColor = false;
            btn_DevP.Click += btn_DevP_Click;
            // 
            // txt_UniP
            // 
            txt_UniP.Location = new Point(202, 155);
            txt_UniP.Name = "txt_UniP";
            txt_UniP.Size = new Size(189, 27);
            txt_UniP.TabIndex = 9;
            // 
            // txt_ProducP
            // 
            txt_ProducP.Location = new Point(202, 108);
            txt_ProducP.Name = "txt_ProducP";
            txt_ProducP.Size = new Size(189, 27);
            txt_ProducP.TabIndex = 8;
            // 
            // txt_idP
            // 
            txt_idP.Location = new Point(202, 68);
            txt_idP.Name = "txt_idP";
            txt_idP.Size = new Size(189, 27);
            txt_idP.TabIndex = 7;
            // 
            // lbl_ProducP
            // 
            lbl_ProducP.AutoSize = true;
            lbl_ProducP.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_ProducP.Location = new Point(11, 108);
            lbl_ProducP.Name = "lbl_ProducP";
            lbl_ProducP.Size = new Size(154, 23);
            lbl_ProducP.TabIndex = 6;
            lbl_ProducP.Text = "Nombre Producto";
            // 
            // lbl_UnidadesP
            // 
            lbl_UnidadesP.AutoSize = true;
            lbl_UnidadesP.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_UnidadesP.Location = new Point(11, 155);
            lbl_UnidadesP.Name = "lbl_UnidadesP";
            lbl_UnidadesP.Size = new Size(84, 23);
            lbl_UnidadesP.TabIndex = 5;
            lbl_UnidadesP.Text = "Unidades";
            // 
            // lbl_PedidoP
            // 
            lbl_PedidoP.AutoSize = true;
            lbl_PedidoP.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_PedidoP.Location = new Point(590, 71);
            lbl_PedidoP.Name = "lbl_PedidoP";
            lbl_PedidoP.Size = new Size(91, 23);
            lbl_PedidoP.TabIndex = 4;
            lbl_PedidoP.Text = " Id Pedido";
            // 
            // lbl_ProvP
            // 
            lbl_ProvP.AutoSize = true;
            lbl_ProvP.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_ProvP.Location = new Point(11, 68);
            lbl_ProvP.Name = "lbl_ProvP";
            lbl_ProvP.Size = new Size(115, 23);
            lbl_ProvP.TabIndex = 3;
            lbl_ProvP.Text = "ID Proveedor";
            // 
            // lbl_RegP
            // 
            lbl_RegP.AutoSize = true;
            lbl_RegP.BackColor = Color.DeepSkyBlue;
            lbl_RegP.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_RegP.ForeColor = Color.White;
            lbl_RegP.Location = new Point(713, 26);
            lbl_RegP.Name = "lbl_RegP";
            lbl_RegP.Size = new Size(80, 23);
            lbl_RegP.TabIndex = 2;
            lbl_RegP.Text = "Regresar";
            lbl_RegP.Click += label2_Click;
            // 
            // lbl_Merc
            // 
            lbl_Merc.AutoSize = true;
            lbl_Merc.BackColor = Color.DeepSkyBlue;
            lbl_Merc.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Merc.ForeColor = Color.White;
            lbl_Merc.Location = new Point(343, 19);
            lbl_Merc.Name = "lbl_Merc";
            lbl_Merc.Size = new Size(124, 31);
            lbl_Merc.TabIndex = 1;
            lbl_Merc.Text = "Mercancía";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DeepSkyBlue;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(894, 68);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // MercancíaR
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 500);
            Controls.Add(PanelPedido);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MercancíaR";
            Text = "MercancíaR";
            PanelPedido.ResumeLayout(false);
            PanelPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelPedido;
        private Label lbl_ProducP;
        private Label lbl_UnidadesP;
        private Label lbl_PedidoP;
        private Label lbl_ProvP;
        private Label lbl_RegP;
        private Label lbl_Merc;
        private PictureBox pictureBox1;
        private TextBox txt_IdPedidoP;
        private Button btn_DevP;
        private TextBox txt_UniP;
        private TextBox txt_ProducP;
        private TextBox txt_idP;
        private DataGridView dgvPedidos;
        private DataGridViewTextBoxColumn id_prov;
        private DataGridViewTextBoxColumn id_pedido;
        private DataGridViewTextBoxColumn producto;
        private DataGridViewTextBoxColumn unidades;
        private Button Solicitar_P;
        private TextBox txt_filtrar;
        private Label lbl_filt;
    }
}