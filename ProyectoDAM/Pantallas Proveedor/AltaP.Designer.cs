namespace ProyectoDAM.Pantallas_Proveedor
{
    partial class AltaP
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
            PanelAltaP = new Panel();
            dgvProvedores = new DataGridView();
            id_prov = new DataGridViewTextBoxColumn();
            nombreprov = new DataGridViewTextBoxColumn();
            celprov = new DataGridViewTextBoxColumn();
            tipop = new DataGridViewTextBoxColumn();
            correoprov = new DataGridViewTextBoxColumn();
            btn_GPA = new Button();
            cmbx_TPA = new ComboBox();
            txt_CelPA = new TextBox();
            txt_CorreoPA = new TextBox();
            txt_NomPA = new TextBox();
            lbl_TPA = new Label();
            lbl_CelPA = new Label();
            lbl_CorreoPA = new Label();
            lbl_NomPA = new Label();
            lbl_Reg = new Label();
            lbl_AltaP = new Label();
            pictureBox1 = new PictureBox();
            PanelAltaP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProvedores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PanelAltaP
            // 
            PanelAltaP.BackColor = Color.LightSkyBlue;
            PanelAltaP.Controls.Add(dgvProvedores);
            PanelAltaP.Controls.Add(btn_GPA);
            PanelAltaP.Controls.Add(cmbx_TPA);
            PanelAltaP.Controls.Add(txt_CelPA);
            PanelAltaP.Controls.Add(txt_CorreoPA);
            PanelAltaP.Controls.Add(txt_NomPA);
            PanelAltaP.Controls.Add(lbl_TPA);
            PanelAltaP.Controls.Add(lbl_CelPA);
            PanelAltaP.Controls.Add(lbl_CorreoPA);
            PanelAltaP.Controls.Add(lbl_NomPA);
            PanelAltaP.Controls.Add(lbl_Reg);
            PanelAltaP.Controls.Add(lbl_AltaP);
            PanelAltaP.Controls.Add(pictureBox1);
            PanelAltaP.Dock = DockStyle.Fill;
            PanelAltaP.Location = new Point(0, 0);
            PanelAltaP.Name = "PanelAltaP";
            PanelAltaP.Size = new Size(888, 500);
            PanelAltaP.TabIndex = 0;
            PanelAltaP.Paint += PanelAltaP_Paint;
            // 
            // dgvProvedores
            // 
            dgvProvedores.BackgroundColor = Color.White;
            dgvProvedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProvedores.Columns.AddRange(new DataGridViewColumn[] { id_prov, nombreprov, celprov, tipop, correoprov });
            dgvProvedores.Location = new Point(70, 266);
            dgvProvedores.Name = "dgvProvedores";
            dgvProvedores.RowHeadersWidth = 51;
            dgvProvedores.Size = new Size(725, 234);
            dgvProvedores.TabIndex = 13;
            // 
            // id_prov
            // 
            id_prov.HeaderText = "ID";
            id_prov.MinimumWidth = 6;
            id_prov.Name = "id_prov";
            id_prov.Width = 80;
            // 
            // nombreprov
            // 
            nombreprov.HeaderText = "Nombre";
            nombreprov.MinimumWidth = 6;
            nombreprov.Name = "nombreprov";
            nombreprov.Width = 150;
            // 
            // celprov
            // 
            celprov.HeaderText = "Cel.";
            celprov.MinimumWidth = 6;
            celprov.Name = "celprov";
            celprov.Width = 150;
            // 
            // tipop
            // 
            tipop.HeaderText = "Tipo Producto";
            tipop.MinimumWidth = 6;
            tipop.Name = "tipop";
            tipop.Width = 150;
            // 
            // correoprov
            // 
            correoprov.HeaderText = "Correo";
            correoprov.MinimumWidth = 6;
            correoprov.Name = "correoprov";
            correoprov.Width = 150;
            // 
            // btn_GPA
            // 
            btn_GPA.BackColor = Color.SkyBlue;
            btn_GPA.Location = new Point(674, 199);
            btn_GPA.Name = "btn_GPA";
            btn_GPA.Size = new Size(121, 57);
            btn_GPA.TabIndex = 12;
            btn_GPA.Text = "Guardar";
            btn_GPA.UseVisualStyleBackColor = false;
            btn_GPA.Click += btn_GPA_Click;
            // 
            // cmbx_TPA
            // 
            cmbx_TPA.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbx_TPA.FormattingEnabled = true;
            cmbx_TPA.Items.AddRange(new object[] { "Périfericos", "Componentes", "Dispositivos" });
            cmbx_TPA.Location = new Point(357, 228);
            cmbx_TPA.Name = "cmbx_TPA";
            cmbx_TPA.Size = new Size(213, 28);
            cmbx_TPA.TabIndex = 10;
            // 
            // txt_CelPA
            // 
            txt_CelPA.Location = new Point(357, 177);
            txt_CelPA.Name = "txt_CelPA";
            txt_CelPA.Size = new Size(213, 27);
            txt_CelPA.TabIndex = 9;
            txt_CelPA.TextChanged += txt_CelPA_TextChanged;
            // 
            // txt_CorreoPA
            // 
            txt_CorreoPA.Location = new Point(357, 129);
            txt_CorreoPA.Name = "txt_CorreoPA";
            txt_CorreoPA.Size = new Size(213, 27);
            txt_CorreoPA.TabIndex = 8;
            // 
            // txt_NomPA
            // 
            txt_NomPA.Location = new Point(357, 78);
            txt_NomPA.Name = "txt_NomPA";
            txt_NomPA.Size = new Size(213, 27);
            txt_NomPA.TabIndex = 7;
            // 
            // lbl_TPA
            // 
            lbl_TPA.AutoSize = true;
            lbl_TPA.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_TPA.Location = new Point(123, 225);
            lbl_TPA.Name = "lbl_TPA";
            lbl_TPA.Size = new Size(158, 31);
            lbl_TPA.TabIndex = 6;
            lbl_TPA.Text = "Tipo Producto";
            // 
            // lbl_CelPA
            // 
            lbl_CelPA.AutoSize = true;
            lbl_CelPA.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_CelPA.Location = new Point(123, 177);
            lbl_CelPA.Name = "lbl_CelPA";
            lbl_CelPA.Size = new Size(85, 31);
            lbl_CelPA.TabIndex = 5;
            lbl_CelPA.Text = "Celular";
            // 
            // lbl_CorreoPA
            // 
            lbl_CorreoPA.AutoSize = true;
            lbl_CorreoPA.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_CorreoPA.Location = new Point(123, 125);
            lbl_CorreoPA.Name = "lbl_CorreoPA";
            lbl_CorreoPA.Size = new Size(82, 31);
            lbl_CorreoPA.TabIndex = 4;
            lbl_CorreoPA.Text = "Correo";
            // 
            // lbl_NomPA
            // 
            lbl_NomPA.AutoSize = true;
            lbl_NomPA.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_NomPA.Location = new Point(123, 78);
            lbl_NomPA.Name = "lbl_NomPA";
            lbl_NomPA.Size = new Size(208, 31);
            lbl_NomPA.TabIndex = 3;
            lbl_NomPA.Text = "Nombre Proveedor";
            // 
            // lbl_Reg
            // 
            lbl_Reg.AutoSize = true;
            lbl_Reg.BackColor = Color.DeepSkyBlue;
            lbl_Reg.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Reg.ForeColor = Color.White;
            lbl_Reg.Location = new Point(719, 17);
            lbl_Reg.Name = "lbl_Reg";
            lbl_Reg.Size = new Size(103, 31);
            lbl_Reg.TabIndex = 2;
            lbl_Reg.Text = "Regresar";
            lbl_Reg.Click += lbl_Reg_Click;
            // 
            // lbl_AltaP
            // 
            lbl_AltaP.AutoSize = true;
            lbl_AltaP.BackColor = Color.DeepSkyBlue;
            lbl_AltaP.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_AltaP.ForeColor = Color.White;
            lbl_AltaP.Location = new Point(405, 9);
            lbl_AltaP.Name = "lbl_AltaP";
            lbl_AltaP.Size = new Size(69, 41);
            lbl_AltaP.TabIndex = 1;
            lbl_AltaP.Text = "Alta";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DeepSkyBlue;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(888, 75);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // AltaP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 500);
            Controls.Add(PanelAltaP);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AltaP";
            Text = "BajaP";
            PanelAltaP.ResumeLayout(false);
            PanelAltaP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProvedores).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelAltaP;
        private Button btn_GPA;
        private ComboBox cmbx_TPA;
        private TextBox txt_CelPA;
        private TextBox txt_CorreoPA;
        private TextBox txt_NomPA;
        private Label lbl_TPA;
        private Label lbl_CelPA;
        private Label lbl_CorreoPA;
        private Label lbl_NomPA;
        private Label lbl_Reg;
        private Label lbl_AltaP;
        private PictureBox pictureBox1;
        private DataGridView dgvProvedores;
        private DataGridViewTextBoxColumn id_prov;
        private DataGridViewTextBoxColumn nombreprov;
        private DataGridViewTextBoxColumn celprov;
        private DataGridViewTextBoxColumn tipop;
        private DataGridViewTextBoxColumn correoprov;
    }
}