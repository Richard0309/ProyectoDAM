namespace ProyectoDAM.Pantallas_Inventario
{
    partial class Descuentoscs
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
            pictureBox1 = new PictureBox();
            lbl_tit = new Label();
            label2 = new Label();
            lbl_prod = new Label();
            txt_prod = new TextBox();
            txt_desc = new TextBox();
            btn_asig = new Button();
            lbl_desc = new Label();
            lbl_reg = new Label();
            PanelDescR = new Panel();
            txt_filt = new TextBox();
            lbl_filt = new Label();
            dgvDesc = new DataGridView();
            id_produc = new DataGridViewTextBoxColumn();
            nom_produc = new DataGridViewTextBoxColumn();
            tipo = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelDescR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDesc).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.SteelBlue;
            pictureBox1.Location = new Point(1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(887, 70);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lbl_tit
            // 
            lbl_tit.AutoSize = true;
            lbl_tit.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_tit.Location = new Point(302, 9);
            lbl_tit.Name = "lbl_tit";
            lbl_tit.Size = new Size(167, 38);
            lbl_tit.TabIndex = 2;
            lbl_tit.Text = "Descuentos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 147);
            label2.Name = "label2";
            label2.Size = new Size(0, 38);
            label2.TabIndex = 3;
            // 
            // lbl_prod
            // 
            lbl_prod.AutoSize = true;
            lbl_prod.BackColor = Color.LightSkyBlue;
            lbl_prod.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_prod.Location = new Point(102, 74);
            lbl_prod.Name = "lbl_prod";
            lbl_prod.Size = new Size(47, 38);
            lbl_prod.TabIndex = 4;
            lbl_prod.Text = "ID";
            // 
            // txt_prod
            // 
            txt_prod.Location = new Point(168, 85);
            txt_prod.Name = "txt_prod";
            txt_prod.Size = new Size(111, 27);
            txt_prod.TabIndex = 5;
            // 
            // txt_desc
            // 
            txt_desc.Location = new Point(628, 85);
            txt_desc.Name = "txt_desc";
            txt_desc.Size = new Size(111, 27);
            txt_desc.TabIndex = 6;
            // 
            // btn_asig
            // 
            btn_asig.BackColor = Color.SkyBlue;
            btn_asig.Location = new Point(760, 76);
            btn_asig.Name = "btn_asig";
            btn_asig.Size = new Size(98, 45);
            btn_asig.TabIndex = 8;
            btn_asig.Text = "Asignar";
            btn_asig.UseVisualStyleBackColor = false;
            btn_asig.Click += btn_asig_Click;
            // 
            // lbl_desc
            // 
            lbl_desc.AutoSize = true;
            lbl_desc.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_desc.Location = new Point(359, 74);
            lbl_desc.Name = "lbl_desc";
            lbl_desc.Size = new Size(263, 38);
            lbl_desc.TabIndex = 9;
            lbl_desc.Text = "Asignar Descuento";
            lbl_desc.Click += label4_Click;
            // 
            // lbl_reg
            // 
            lbl_reg.AutoSize = true;
            lbl_reg.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_reg.Location = new Point(609, 9);
            lbl_reg.Name = "lbl_reg";
            lbl_reg.Size = new Size(130, 38);
            lbl_reg.TabIndex = 10;
            lbl_reg.Text = "Regresar";
            lbl_reg.Click += label5_Click;
            // 
            // PanelDescR
            // 
            PanelDescR.BackColor = Color.LightSkyBlue;
            PanelDescR.Controls.Add(txt_filt);
            PanelDescR.Controls.Add(lbl_filt);
            PanelDescR.Controls.Add(dgvDesc);
            PanelDescR.Controls.Add(btn_asig);
            PanelDescR.Controls.Add(lbl_desc);
            PanelDescR.Controls.Add(txt_prod);
            PanelDescR.Controls.Add(txt_desc);
            PanelDescR.Controls.Add(lbl_prod);
            PanelDescR.Dock = DockStyle.Fill;
            PanelDescR.Location = new Point(0, 0);
            PanelDescR.Name = "PanelDescR";
            PanelDescR.Size = new Size(888, 500);
            PanelDescR.TabIndex = 11;
            PanelDescR.Paint += PanelDescR_Paint;
            // 
            // txt_filt
            // 
            txt_filt.Location = new Point(244, 186);
            txt_filt.Name = "txt_filt";
            txt_filt.Size = new Size(447, 27);
            txt_filt.TabIndex = 12;
            txt_filt.TextChanged += txt_filt_TextChanged;
            // 
            // lbl_filt
            // 
            lbl_filt.AutoSize = true;
            lbl_filt.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_filt.Location = new Point(142, 175);
            lbl_filt.Name = "lbl_filt";
            lbl_filt.Size = new Size(96, 38);
            lbl_filt.TabIndex = 11;
            lbl_filt.Text = "Filtrar";
            // 
            // dgvDesc
            // 
            dgvDesc.BackgroundColor = Color.White;
            dgvDesc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDesc.Columns.AddRange(new DataGridViewColumn[] { id_produc, nom_produc, tipo, precio });
            dgvDesc.Location = new Point(142, 224);
            dgvDesc.Name = "dgvDesc";
            dgvDesc.RowHeadersWidth = 51;
            dgvDesc.Size = new Size(549, 238);
            dgvDesc.TabIndex = 10;
            dgvDesc.CellClick += dgvDesc_CellClick;
            // 
            // id_produc
            // 
            id_produc.HeaderText = "ID";
            id_produc.MinimumWidth = 6;
            id_produc.Name = "id_produc";
            id_produc.ReadOnly = true;
            id_produc.Width = 125;
            // 
            // nom_produc
            // 
            nom_produc.HeaderText = "Nombre";
            nom_produc.MinimumWidth = 6;
            nom_produc.Name = "nom_produc";
            nom_produc.ReadOnly = true;
            nom_produc.Width = 125;
            // 
            // tipo
            // 
            tipo.HeaderText = "Tipo";
            tipo.MinimumWidth = 6;
            tipo.Name = "tipo";
            tipo.ReadOnly = true;
            tipo.Width = 125;
            // 
            // precio
            // 
            precio.HeaderText = "Precio";
            precio.MinimumWidth = 6;
            precio.Name = "precio";
            precio.ReadOnly = true;
            precio.Width = 125;
            // 
            // Descuentoscs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 500);
            Controls.Add(lbl_reg);
            Controls.Add(label2);
            Controls.Add(lbl_tit);
            Controls.Add(pictureBox1);
            Controls.Add(PanelDescR);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Descuentoscs";
            Text = "Descuentoscs";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PanelDescR.ResumeLayout(false);
            PanelDescR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDesc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbl_tit;
        private Label label2;
        private Label lbl_prod;
        private TextBox txt_prod;
        private TextBox txt_desc;
        private Button btn_asig;
        private Label lbl_desc;
        private Label lbl_reg;
        private Panel PanelDescR;
        private DataGridView dgvDesc;
        private DataGridViewTextBoxColumn id_produc;
        private DataGridViewTextBoxColumn nom_produc;
        private DataGridViewTextBoxColumn tipo;
        private DataGridViewTextBoxColumn precio;
        private TextBox txt_filt;
        private Label lbl_filt;
    }
}