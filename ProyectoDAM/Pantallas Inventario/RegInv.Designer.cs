namespace ProyectoDAM.Pantallas_Inventario
{
    partial class RegInv
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
            panel1 = new Panel();
            PanelRegIn = new Panel();
            txt_precio = new TextBox();
            lbl_precio = new Label();
            lbl_conec = new Label();
            button1 = new Button();
            btn_guar = new Button();
            txt_conec_p = new TextBox();
            PanelTipo = new Panel();
            cmbx_tipoP = new ComboBox();
            lbl_tipop = new Label();
            lbl_conp = new Label();
            lbl_marcap = new Label();
            lbl_stockp = new Label();
            lbl_matp = new Label();
            lbl_provp = new Label();
            lbl_colorp = new Label();
            txt_coloP = new TextBox();
            txt_idP = new TextBox();
            txt_mat_P = new TextBox();
            txt_sotckP = new TextBox();
            txt_marcaP = new TextBox();
            txt_nomP = new TextBox();
            lbl_nomp = new Label();
            lbl_regP = new Label();
            lbl_tituloRegIn = new Label();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            PanelRegIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(PanelRegIn);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // PanelRegIn
            // 
            PanelRegIn.BackColor = Color.SkyBlue;
            PanelRegIn.Controls.Add(txt_precio);
            PanelRegIn.Controls.Add(lbl_precio);
            PanelRegIn.Controls.Add(lbl_conec);
            PanelRegIn.Controls.Add(button1);
            PanelRegIn.Controls.Add(btn_guar);
            PanelRegIn.Controls.Add(txt_conec_p);
            PanelRegIn.Controls.Add(PanelTipo);
            PanelRegIn.Controls.Add(cmbx_tipoP);
            PanelRegIn.Controls.Add(lbl_tipop);
            PanelRegIn.Controls.Add(lbl_conp);
            PanelRegIn.Controls.Add(lbl_marcap);
            PanelRegIn.Controls.Add(lbl_stockp);
            PanelRegIn.Controls.Add(lbl_matp);
            PanelRegIn.Controls.Add(lbl_provp);
            PanelRegIn.Controls.Add(lbl_colorp);
            PanelRegIn.Controls.Add(txt_coloP);
            PanelRegIn.Controls.Add(txt_idP);
            PanelRegIn.Controls.Add(txt_mat_P);
            PanelRegIn.Controls.Add(txt_sotckP);
            PanelRegIn.Controls.Add(txt_marcaP);
            PanelRegIn.Controls.Add(txt_nomP);
            PanelRegIn.Controls.Add(lbl_nomp);
            PanelRegIn.Controls.Add(lbl_regP);
            PanelRegIn.Controls.Add(lbl_tituloRegIn);
            PanelRegIn.Controls.Add(pictureBox3);
            PanelRegIn.Dock = DockStyle.Fill;
            PanelRegIn.Location = new Point(0, 0);
            PanelRegIn.Name = "PanelRegIn";
            PanelRegIn.Size = new Size(800, 450);
            PanelRegIn.TabIndex = 18;
            PanelRegIn.Paint += PanelRegIn_Paint;
            // 
            // txt_precio
            // 
            txt_precio.Location = new Point(204, 142);
            txt_precio.Name = "txt_precio";
            txt_precio.Size = new Size(138, 27);
            txt_precio.TabIndex = 29;
            // 
            // lbl_precio
            // 
            lbl_precio.AutoSize = true;
            lbl_precio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_precio.Location = new Point(12, 145);
            lbl_precio.Name = "lbl_precio";
            lbl_precio.Size = new Size(52, 20);
            lbl_precio.TabIndex = 28;
            lbl_precio.Text = "Precio";
            // 
            // lbl_conec
            // 
            lbl_conec.AutoSize = true;
            lbl_conec.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_conec.Location = new Point(12, 421);
            lbl_conec.Name = "lbl_conec";
            lbl_conec.Size = new Size(74, 20);
            lbl_conec.TabIndex = 27;
            lbl_conec.Text = "Conexión";
            // 
            // button1
            // 
            button1.BackColor = Color.SkyBlue;
            button1.Location = new Point(627, 60);
            button1.Name = "button1";
            button1.Size = new Size(122, 44);
            button1.TabIndex = 25;
            button1.Text = "Ver Inventario";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btn_guar
            // 
            btn_guar.BackColor = Color.LightSkyBlue;
            btn_guar.Location = new Point(502, 60);
            btn_guar.Name = "btn_guar";
            btn_guar.Size = new Size(76, 44);
            btn_guar.TabIndex = 24;
            btn_guar.Text = "Guardar";
            btn_guar.UseVisualStyleBackColor = false;
            btn_guar.Click += btn_guar_Click;
            // 
            // txt_conec_p
            // 
            txt_conec_p.Location = new Point(204, 415);
            txt_conec_p.Name = "txt_conec_p";
            txt_conec_p.Size = new Size(138, 27);
            txt_conec_p.TabIndex = 23;
            // 
            // PanelTipo
            // 
            PanelTipo.Location = new Point(396, 163);
            PanelTipo.Name = "PanelTipo";
            PanelTipo.Size = new Size(392, 279);
            PanelTipo.TabIndex = 22;
            PanelTipo.Paint += PanelTipo_Paint;
            // 
            // cmbx_tipoP
            // 
            cmbx_tipoP.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbx_tipoP.FormattingEnabled = true;
            cmbx_tipoP.Items.AddRange(new object[] { "Périfericos", "Componentes", "Dispositivos" });
            cmbx_tipoP.Location = new Point(502, 125);
            cmbx_tipoP.Name = "cmbx_tipoP";
            cmbx_tipoP.Size = new Size(134, 28);
            cmbx_tipoP.TabIndex = 21;
            cmbx_tipoP.SelectedIndexChanged += cmbx_tipoP_SelectedIndexChanged;
            // 
            // lbl_tipop
            // 
            lbl_tipop.AutoSize = true;
            lbl_tipop.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_tipop.Location = new Point(416, 125);
            lbl_tipop.Name = "lbl_tipop";
            lbl_tipop.Size = new Size(40, 20);
            lbl_tipop.TabIndex = 20;
            lbl_tipop.Text = "Tipo";
            // 
            // lbl_conp
            // 
            lbl_conp.AutoSize = true;
            lbl_conp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_conp.Location = new Point(11, 383);
            lbl_conp.Name = "lbl_conp";
            lbl_conp.Size = new Size(52, 20);
            lbl_conp.TabIndex = 17;
            lbl_conp.Text = "Marca";
            // 
            // lbl_marcap
            // 
            lbl_marcap.AutoSize = true;
            lbl_marcap.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_marcap.Location = new Point(12, 382);
            lbl_marcap.Name = "lbl_marcap";
            lbl_marcap.Size = new Size(52, 20);
            lbl_marcap.TabIndex = 16;
            lbl_marcap.Text = "Marca";
            // 
            // lbl_stockp
            // 
            lbl_stockp.AutoSize = true;
            lbl_stockp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_stockp.Location = new Point(12, 334);
            lbl_stockp.Name = "lbl_stockp";
            lbl_stockp.Size = new Size(47, 20);
            lbl_stockp.TabIndex = 15;
            lbl_stockp.Text = "Stock";
            // 
            // lbl_matp
            // 
            lbl_matp.AutoSize = true;
            lbl_matp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_matp.Location = new Point(12, 229);
            lbl_matp.Name = "lbl_matp";
            lbl_matp.Size = new Size(186, 20);
            lbl_matp.TabIndex = 14;
            lbl_matp.Text = "Materiales de Fabricación";
            // 
            // lbl_provp
            // 
            lbl_provp.AutoSize = true;
            lbl_provp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_provp.Location = new Point(11, 189);
            lbl_provp.Name = "lbl_provp";
            lbl_provp.Size = new Size(101, 20);
            lbl_provp.TabIndex = 13;
            lbl_provp.Text = "ID Proveedor";
            lbl_provp.UseWaitCursor = true;
            // 
            // lbl_colorp
            // 
            lbl_colorp.AutoSize = true;
            lbl_colorp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_colorp.Location = new Point(12, 105);
            lbl_colorp.Name = "lbl_colorp";
            lbl_colorp.Size = new Size(46, 20);
            lbl_colorp.TabIndex = 11;
            lbl_colorp.Text = "Color";
            // 
            // txt_coloP
            // 
            txt_coloP.Location = new Point(208, 102);
            txt_coloP.Name = "txt_coloP";
            txt_coloP.Size = new Size(138, 27);
            txt_coloP.TabIndex = 9;
            // 
            // txt_idP
            // 
            txt_idP.Location = new Point(204, 182);
            txt_idP.Name = "txt_idP";
            txt_idP.Size = new Size(138, 27);
            txt_idP.TabIndex = 8;
            // 
            // txt_mat_P
            // 
            txt_mat_P.Location = new Point(204, 226);
            txt_mat_P.Multiline = true;
            txt_mat_P.Name = "txt_mat_P";
            txt_mat_P.Size = new Size(138, 83);
            txt_mat_P.TabIndex = 7;
            // 
            // txt_sotckP
            // 
            txt_sotckP.Location = new Point(204, 334);
            txt_sotckP.Name = "txt_sotckP";
            txt_sotckP.Size = new Size(138, 27);
            txt_sotckP.TabIndex = 6;
            // 
            // txt_marcaP
            // 
            txt_marcaP.Location = new Point(204, 382);
            txt_marcaP.Name = "txt_marcaP";
            txt_marcaP.Size = new Size(138, 27);
            txt_marcaP.TabIndex = 5;
            // 
            // txt_nomP
            // 
            txt_nomP.Location = new Point(208, 56);
            txt_nomP.Name = "txt_nomP";
            txt_nomP.Size = new Size(138, 27);
            txt_nomP.TabIndex = 4;
            // 
            // lbl_nomp
            // 
            lbl_nomp.AutoSize = true;
            lbl_nomp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nomp.Location = new Point(12, 56);
            lbl_nomp.Name = "lbl_nomp";
            lbl_nomp.Size = new Size(160, 20);
            lbl_nomp.TabIndex = 3;
            lbl_nomp.Text = "Nombre del Producto";
            // 
            // lbl_regP
            // 
            lbl_regP.AutoSize = true;
            lbl_regP.BackColor = Color.SteelBlue;
            lbl_regP.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_regP.ForeColor = Color.White;
            lbl_regP.Location = new Point(693, 16);
            lbl_regP.Name = "lbl_regP";
            lbl_regP.Size = new Size(95, 28);
            lbl_regP.TabIndex = 2;
            lbl_regP.Text = "Regresar";
            lbl_regP.Click += lbl_regP_Click;
            // 
            // lbl_tituloRegIn
            // 
            lbl_tituloRegIn.AutoSize = true;
            lbl_tituloRegIn.BackColor = Color.SteelBlue;
            lbl_tituloRegIn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_tituloRegIn.ForeColor = Color.White;
            lbl_tituloRegIn.Location = new Point(332, 14);
            lbl_tituloRegIn.Name = "lbl_tituloRegIn";
            lbl_tituloRegIn.Size = new Size(124, 31);
            lbl_tituloRegIn.TabIndex = 1;
            lbl_tituloRegIn.Text = "Inventario";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.SteelBlue;
            pictureBox3.Location = new Point(0, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(800, 51);
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // RegInv
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegInv";
            Text = "RegInv";
            panel1.ResumeLayout(false);
            PanelRegIn.ResumeLayout(false);
            PanelRegIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel PanelRegIn;
        private Button btn_guar;
        private TextBox txt_conec_p;
        private Panel PanelTipo;
        private ComboBox cmbx_tipoP;
        private Label lbl_tipop;
        private Label lbl_conp;
        private Label lbl_marcap;
        private Label lbl_stockp;
        private Label lbl_matp;
        private Label lbl_provp;
        private Label lbl_colorp;
        private TextBox txt_coloP;
        private TextBox txt_idP;
        private TextBox txt_mat_P;
        private TextBox txt_sotckP;
        private TextBox txt_marcaP;
        private TextBox txt_nomP;
        private Label lbl_nomp;
        private Label lbl_regP;
        private Label lbl_tituloRegIn;
        private PictureBox pictureBox3;
        private Button button1;
        private Label lbl_conec;
        private TextBox txt_precio;
        private Label lbl_precio;
    }
}