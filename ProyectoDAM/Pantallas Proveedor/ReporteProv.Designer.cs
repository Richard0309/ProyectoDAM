namespace ProyectoDAM.Pantallas_Proveedor
{
    partial class ReporteProv
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
            PanelRegP = new Panel();
            dgvP = new DataGridView();
            id_prov = new DataGridViewTextBoxColumn();
            nombreprov = new DataGridViewTextBoxColumn();
            celprov = new DataGridViewTextBoxColumn();
            tipop = new DataGridViewTextBoxColumn();
            correoprov = new DataGridViewTextBoxColumn();
            btn_BajaP = new Button();
            btn_OpcionesM = new Button();
            btn_AltaP = new Button();
            txt_BuscP = new TextBox();
            lbl_merc = new Label();
            lbl_altaP = new Label();
            lbl_buscP = new Label();
            lbl_Reg = new Label();
            lbl_TitP = new Label();
            pictureBox1 = new PictureBox();
            lbl_filt = new Label();
            txt_filtrar = new TextBox();
            PanelRegP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PanelRegP
            // 
            PanelRegP.BackColor = Color.LightSkyBlue;
            PanelRegP.Controls.Add(txt_filtrar);
            PanelRegP.Controls.Add(lbl_filt);
            PanelRegP.Controls.Add(dgvP);
            PanelRegP.Controls.Add(btn_BajaP);
            PanelRegP.Controls.Add(btn_OpcionesM);
            PanelRegP.Controls.Add(btn_AltaP);
            PanelRegP.Controls.Add(txt_BuscP);
            PanelRegP.Controls.Add(lbl_merc);
            PanelRegP.Controls.Add(lbl_altaP);
            PanelRegP.Controls.Add(lbl_buscP);
            PanelRegP.Controls.Add(lbl_Reg);
            PanelRegP.Controls.Add(lbl_TitP);
            PanelRegP.Controls.Add(pictureBox1);
            PanelRegP.Dock = DockStyle.Fill;
            PanelRegP.Location = new Point(0, 0);
            PanelRegP.Name = "PanelRegP";
            PanelRegP.Size = new Size(888, 500);
            PanelRegP.TabIndex = 0;
            PanelRegP.Paint += PanelRegP_Paint;
            // 
            // dgvP
            // 
            dgvP.BackgroundColor = Color.White;
            dgvP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvP.Columns.AddRange(new DataGridViewColumn[] { id_prov, nombreprov, celprov, tipop, correoprov });
            dgvP.Location = new Point(92, 263);
            dgvP.Name = "dgvP";
            dgvP.RowHeadersWidth = 51;
            dgvP.Size = new Size(712, 234);
            dgvP.TabIndex = 15;
            dgvP.CellClick += dgvP_CellClick;
            // 
            // id_prov
            // 
            id_prov.HeaderText = "ID";
            id_prov.MinimumWidth = 6;
            id_prov.Name = "id_prov";
            id_prov.ReadOnly = true;
            id_prov.Width = 60;
            // 
            // nombreprov
            // 
            nombreprov.HeaderText = "Nombre";
            nombreprov.MinimumWidth = 6;
            nombreprov.Name = "nombreprov";
            nombreprov.ReadOnly = true;
            nombreprov.Width = 150;
            // 
            // celprov
            // 
            celprov.HeaderText = "Cel";
            celprov.MinimumWidth = 6;
            celprov.Name = "celprov";
            celprov.ReadOnly = true;
            celprov.Width = 150;
            // 
            // tipop
            // 
            tipop.HeaderText = "Tipo Producto";
            tipop.MinimumWidth = 6;
            tipop.Name = "tipop";
            tipop.ReadOnly = true;
            tipop.Width = 150;
            // 
            // correoprov
            // 
            correoprov.HeaderText = "Correo";
            correoprov.MinimumWidth = 6;
            correoprov.Name = "correoprov";
            correoprov.ReadOnly = true;
            correoprov.Width = 150;
            // 
            // btn_BajaP
            // 
            btn_BajaP.BackColor = Color.SkyBlue;
            btn_BajaP.Location = new Point(414, 84);
            btn_BajaP.Name = "btn_BajaP";
            btn_BajaP.Size = new Size(94, 29);
            btn_BajaP.TabIndex = 12;
            btn_BajaP.Text = "Baja";
            btn_BajaP.UseVisualStyleBackColor = false;
            btn_BajaP.Click += btn_BajaP_Click;
            // 
            // btn_OpcionesM
            // 
            btn_OpcionesM.BackColor = Color.SkyBlue;
            btn_OpcionesM.Location = new Point(591, 218);
            btn_OpcionesM.Name = "btn_OpcionesM";
            btn_OpcionesM.Size = new Size(94, 29);
            btn_OpcionesM.TabIndex = 11;
            btn_OpcionesM.Text = "Opciones";
            btn_OpcionesM.UseVisualStyleBackColor = false;
            btn_OpcionesM.Click += btn_OpcionesM_Click;
            // 
            // btn_AltaP
            // 
            btn_AltaP.BackColor = Color.SkyBlue;
            btn_AltaP.Location = new Point(353, 218);
            btn_AltaP.Name = "btn_AltaP";
            btn_AltaP.Size = new Size(94, 29);
            btn_AltaP.TabIndex = 10;
            btn_AltaP.Text = "Alta";
            btn_AltaP.UseVisualStyleBackColor = false;
            btn_AltaP.Click += btn_AltaP_Click;
            // 
            // txt_BuscP
            // 
            txt_BuscP.Location = new Point(318, 83);
            txt_BuscP.Name = "txt_BuscP";
            txt_BuscP.Size = new Size(77, 27);
            txt_BuscP.TabIndex = 7;
            // 
            // lbl_merc
            // 
            lbl_merc.AutoSize = true;
            lbl_merc.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_merc.Location = new Point(453, 213);
            lbl_merc.Name = "lbl_merc";
            lbl_merc.Size = new Size(120, 31);
            lbl_merc.TabIndex = 6;
            lbl_merc.Text = "Mercancía";
            // 
            // lbl_altaP
            // 
            lbl_altaP.AutoSize = true;
            lbl_altaP.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_altaP.Location = new Point(172, 218);
            lbl_altaP.Name = "lbl_altaP";
            lbl_altaP.Size = new Size(165, 31);
            lbl_altaP.TabIndex = 5;
            lbl_altaP.Text = "Alta Proveedor";
            // 
            // lbl_buscP
            // 
            lbl_buscP.AutoSize = true;
            lbl_buscP.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_buscP.Location = new Point(155, 79);
            lbl_buscP.Name = "lbl_buscP";
            lbl_buscP.Size = new Size(146, 31);
            lbl_buscP.TabIndex = 3;
            lbl_buscP.Text = "ID Proveedor";
            // 
            // lbl_Reg
            // 
            lbl_Reg.AutoSize = true;
            lbl_Reg.BackColor = Color.DeepSkyBlue;
            lbl_Reg.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Reg.ForeColor = Color.White;
            lbl_Reg.Location = new Point(674, 22);
            lbl_Reg.Name = "lbl_Reg";
            lbl_Reg.Size = new Size(103, 31);
            lbl_Reg.TabIndex = 2;
            lbl_Reg.Text = "Regresar";
            lbl_Reg.Click += lbl_Reg_Click;
            // 
            // lbl_TitP
            // 
            lbl_TitP.AutoSize = true;
            lbl_TitP.BackColor = Color.DeepSkyBlue;
            lbl_TitP.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_TitP.ForeColor = Color.White;
            lbl_TitP.Location = new Point(343, 22);
            lbl_TitP.Name = "lbl_TitP";
            lbl_TitP.Size = new Size(140, 31);
            lbl_TitP.TabIndex = 1;
            lbl_TitP.Text = "Proveedores";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DeepSkyBlue;
            pictureBox1.Location = new Point(0, -8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(888, 82);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lbl_filt
            // 
            lbl_filt.AutoSize = true;
            lbl_filt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_filt.Location = new Point(191, 177);
            lbl_filt.Name = "lbl_filt";
            lbl_filt.Size = new Size(73, 31);
            lbl_filt.TabIndex = 16;
            lbl_filt.Text = "Filtrar";
            // 
            // txt_filtrar
            // 
            txt_filtrar.Location = new Point(353, 177);
            txt_filtrar.Name = "txt_filtrar";
            txt_filtrar.Size = new Size(287, 27);
            txt_filtrar.TabIndex = 17;
            txt_filtrar.TextChanged += txt_filtrar_TextChanged;
            // 
            // ReporteProv
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 500);
            Controls.Add(PanelRegP);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReporteProv";
            Text = "ReporteProv";
            PanelRegP.ResumeLayout(false);
            PanelRegP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvP).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelRegP;
        private Label lbl_Reg;
        private Label lbl_TitP;
        private PictureBox pictureBox1;
        private Button btn_BajaP;
        private Button btn_OpcionesM;
        private Button btn_AltaP;
        private TextBox txt_BuscP;
        private Label lbl_merc;
        private Label lbl_altaP;
        private Label lbl_buscP;
        private DataGridView dgvP;
        private DataGridViewTextBoxColumn id_prov;
        private DataGridViewTextBoxColumn nombreprov;
        private DataGridViewTextBoxColumn celprov;
        private DataGridViewTextBoxColumn tipop;
        private DataGridViewTextBoxColumn correoprov;
        private TextBox txt_filtrar;
        private Label lbl_filt;
    }
}