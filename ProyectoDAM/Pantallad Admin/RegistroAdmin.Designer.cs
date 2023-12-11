namespace ProyectoDAM.Pantallad_Admin
{
    partial class RegistroAdmin
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
            lbl_admin = new Label();
            lbl_alta = new Label();
            txt_bus = new TextBox();
            txt_nombre = new TextBox();
            btn_buscar = new Button();
            btn_baja = new Button();
            btn_alta = new Button();
            PanelAlta = new Panel();
            lbl_filt = new Label();
            txt_filtro = new TextBox();
            txt_cel = new TextBox();
            txt_sueldo = new TextBox();
            txt_nss = new TextBox();
            txt_rfc = new TextBox();
            lbl_rfc = new Label();
            lbl_nss = new Label();
            lbl_sueldo = new Label();
            lbl_cel = new Label();
            lbl_nom = new Label();
            dgvAdmin = new DataGridView();
            id_em = new DataGridViewTextBoxColumn();
            nombreEm = new DataGridViewTextBoxColumn();
            rfc = new DataGridViewTextBoxColumn();
            nss = new DataGridViewTextBoxColumn();
            sueldo = new DataGridViewTextBoxColumn();
            cel = new DataGridViewTextBoxColumn();
            lbl_reg = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelAlta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdmin).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.CornflowerBlue;
            pictureBox1.Location = new Point(-6, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(894, 62);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lbl_admin
            // 
            lbl_admin.AutoSize = true;
            lbl_admin.BackColor = Color.CornflowerBlue;
            lbl_admin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_admin.ForeColor = Color.White;
            lbl_admin.Location = new Point(362, 9);
            lbl_admin.Name = "lbl_admin";
            lbl_admin.Size = new Size(74, 28);
            lbl_admin.TabIndex = 3;
            lbl_admin.Text = "Admin";
            // 
            // lbl_alta
            // 
            lbl_alta.AutoSize = true;
            lbl_alta.BackColor = Color.White;
            lbl_alta.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_alta.Location = new Point(698, 77);
            lbl_alta.Name = "lbl_alta";
            lbl_alta.Size = new Size(105, 28);
            lbl_alta.TabIndex = 5;
            lbl_alta.Text = "Empleado";
            // 
            // txt_bus
            // 
            txt_bus.Location = new Point(809, 78);
            txt_bus.Name = "txt_bus";
            txt_bus.Size = new Size(56, 27);
            txt_bus.TabIndex = 7;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(479, 77);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(204, 27);
            txt_nombre.TabIndex = 8;
            // 
            // btn_buscar
            // 
            btn_buscar.BackColor = Color.CornflowerBlue;
            btn_buscar.Location = new Point(74, 227);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(121, 34);
            btn_buscar.TabIndex = 10;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = false;
            // 
            // btn_baja
            // 
            btn_baja.BackColor = Color.CornflowerBlue;
            btn_baja.Location = new Point(726, 187);
            btn_baja.Name = "btn_baja";
            btn_baja.Size = new Size(121, 34);
            btn_baja.TabIndex = 11;
            btn_baja.Text = "Baja";
            btn_baja.UseVisualStyleBackColor = false;
            btn_baja.Click += btn_baja_Click;
            // 
            // btn_alta
            // 
            btn_alta.BackColor = Color.CornflowerBlue;
            btn_alta.Location = new Point(726, 130);
            btn_alta.Name = "btn_alta";
            btn_alta.Size = new Size(121, 34);
            btn_alta.TabIndex = 12;
            btn_alta.Text = "Alta";
            btn_alta.TextAlign = ContentAlignment.TopCenter;
            btn_alta.UseVisualStyleBackColor = false;
            btn_alta.Click += button3_Click;
            // 
            // PanelAlta
            // 
            PanelAlta.BackColor = Color.White;
            PanelAlta.Controls.Add(lbl_filt);
            PanelAlta.Controls.Add(txt_filtro);
            PanelAlta.Controls.Add(txt_cel);
            PanelAlta.Controls.Add(txt_sueldo);
            PanelAlta.Controls.Add(txt_nss);
            PanelAlta.Controls.Add(txt_rfc);
            PanelAlta.Controls.Add(lbl_rfc);
            PanelAlta.Controls.Add(lbl_nss);
            PanelAlta.Controls.Add(lbl_sueldo);
            PanelAlta.Controls.Add(lbl_cel);
            PanelAlta.Controls.Add(lbl_nom);
            PanelAlta.Controls.Add(txt_nombre);
            PanelAlta.Controls.Add(btn_baja);
            PanelAlta.Controls.Add(lbl_alta);
            PanelAlta.Controls.Add(dgvAdmin);
            PanelAlta.Controls.Add(btn_buscar);
            PanelAlta.Controls.Add(lbl_reg);
            PanelAlta.Controls.Add(btn_alta);
            PanelAlta.Controls.Add(txt_bus);
            PanelAlta.Controls.Add(pictureBox1);
            PanelAlta.Dock = DockStyle.Fill;
            PanelAlta.Location = new Point(0, 0);
            PanelAlta.Name = "PanelAlta";
            PanelAlta.Size = new Size(888, 500);
            PanelAlta.TabIndex = 14;
            PanelAlta.Paint += PanelAlta_Paint;
            // 
            // lbl_filt
            // 
            lbl_filt.AutoSize = true;
            lbl_filt.BackColor = Color.White;
            lbl_filt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_filt.Location = new Point(12, 73);
            lbl_filt.Name = "lbl_filt";
            lbl_filt.Size = new Size(69, 28);
            lbl_filt.TabIndex = 27;
            lbl_filt.Text = "Filtrar";
            // 
            // txt_filtro
            // 
            txt_filtro.Location = new Point(114, 77);
            txt_filtro.Name = "txt_filtro";
            txt_filtro.Size = new Size(204, 27);
            txt_filtro.TabIndex = 26;
            txt_filtro.TextChanged += txt_filtro_TextChanged;
            // 
            // txt_cel
            // 
            txt_cel.Location = new Point(479, 237);
            txt_cel.Name = "txt_cel";
            txt_cel.Size = new Size(204, 27);
            txt_cel.TabIndex = 25;
            // 
            // txt_sueldo
            // 
            txt_sueldo.Location = new Point(479, 194);
            txt_sueldo.Name = "txt_sueldo";
            txt_sueldo.Size = new Size(204, 27);
            txt_sueldo.TabIndex = 24;
            // 
            // txt_nss
            // 
            txt_nss.Location = new Point(479, 156);
            txt_nss.Name = "txt_nss";
            txt_nss.Size = new Size(204, 27);
            txt_nss.TabIndex = 23;
            // 
            // txt_rfc
            // 
            txt_rfc.Location = new Point(479, 114);
            txt_rfc.Name = "txt_rfc";
            txt_rfc.Size = new Size(204, 27);
            txt_rfc.TabIndex = 22;
            txt_rfc.TextChanged += txt_rfc_TextChanged;
            // 
            // lbl_rfc
            // 
            lbl_rfc.AutoSize = true;
            lbl_rfc.BackColor = Color.White;
            lbl_rfc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_rfc.Location = new Point(362, 113);
            lbl_rfc.Name = "lbl_rfc";
            lbl_rfc.Size = new Size(47, 28);
            lbl_rfc.TabIndex = 21;
            lbl_rfc.Text = "RFC";
            // 
            // lbl_nss
            // 
            lbl_nss.AutoSize = true;
            lbl_nss.BackColor = Color.White;
            lbl_nss.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nss.Location = new Point(362, 152);
            lbl_nss.Name = "lbl_nss";
            lbl_nss.Size = new Size(50, 28);
            lbl_nss.TabIndex = 20;
            lbl_nss.Text = "NSS";
            // 
            // lbl_sueldo
            // 
            lbl_sueldo.AutoSize = true;
            lbl_sueldo.BackColor = Color.White;
            lbl_sueldo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_sueldo.Location = new Point(362, 190);
            lbl_sueldo.Name = "lbl_sueldo";
            lbl_sueldo.Size = new Size(76, 28);
            lbl_sueldo.TabIndex = 19;
            lbl_sueldo.Text = "Sueldo";
            // 
            // lbl_cel
            // 
            lbl_cel.AutoSize = true;
            lbl_cel.BackColor = Color.White;
            lbl_cel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_cel.Location = new Point(362, 233);
            lbl_cel.Name = "lbl_cel";
            lbl_cel.Size = new Size(41, 28);
            lbl_cel.TabIndex = 18;
            lbl_cel.Text = "Cel";
            // 
            // lbl_nom
            // 
            lbl_nom.AutoSize = true;
            lbl_nom.BackColor = Color.White;
            lbl_nom.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nom.Location = new Point(362, 73);
            lbl_nom.Name = "lbl_nom";
            lbl_nom.Size = new Size(89, 28);
            lbl_nom.TabIndex = 17;
            lbl_nom.Text = "Nombre";
            // 
            // dgvAdmin
            // 
            dgvAdmin.BackgroundColor = Color.White;
            dgvAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdmin.Columns.AddRange(new DataGridViewColumn[] { id_em, nombreEm, rfc, nss, sueldo, cel });
            dgvAdmin.Location = new Point(44, 281);
            dgvAdmin.Name = "dgvAdmin";
            dgvAdmin.RowHeadersWidth = 51;
            dgvAdmin.Size = new Size(759, 216);
            dgvAdmin.TabIndex = 16;
            dgvAdmin.CellClick += dgvAdmin_CellContentClick;
            // 
            // id_em
            // 
            id_em.HeaderText = "ID";
            id_em.MinimumWidth = 6;
            id_em.Name = "id_em";
            id_em.Width = 90;
            // 
            // nombreEm
            // 
            nombreEm.HeaderText = "Nombre";
            nombreEm.MinimumWidth = 6;
            nombreEm.Name = "nombreEm";
            nombreEm.ReadOnly = true;
            nombreEm.Width = 125;
            // 
            // rfc
            // 
            rfc.HeaderText = "RFC";
            rfc.MinimumWidth = 6;
            rfc.Name = "rfc";
            rfc.ReadOnly = true;
            rfc.Width = 125;
            // 
            // nss
            // 
            nss.HeaderText = "NSS";
            nss.MinimumWidth = 6;
            nss.Name = "nss";
            nss.ReadOnly = true;
            nss.Width = 125;
            // 
            // sueldo
            // 
            sueldo.HeaderText = "Sueldo";
            sueldo.MinimumWidth = 6;
            sueldo.Name = "sueldo";
            sueldo.ReadOnly = true;
            sueldo.Width = 125;
            // 
            // cel
            // 
            cel.HeaderText = "Cel.";
            cel.MinimumWidth = 6;
            cel.Name = "cel";
            cel.ReadOnly = true;
            cel.Width = 125;
            // 
            // lbl_reg
            // 
            lbl_reg.AutoSize = true;
            lbl_reg.BackColor = Color.CornflowerBlue;
            lbl_reg.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_reg.ForeColor = Color.White;
            lbl_reg.Location = new Point(726, 9);
            lbl_reg.Name = "lbl_reg";
            lbl_reg.Size = new Size(95, 28);
            lbl_reg.TabIndex = 15;
            lbl_reg.Text = "Regresar";
            lbl_reg.Click += lbl_reg_Click;
            // 
            // RegistroAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 500);
            Controls.Add(lbl_admin);
            Controls.Add(PanelAlta);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistroAdmin";
            Text = "RegistroAdmin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PanelAlta.ResumeLayout(false);
            PanelAlta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdmin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbl_admin;
        private Label lbl_alta;
        private TextBox txt_bus;
        private TextBox txt_nombre;
        private Button btn_buscar;
        private Button btn_baja;
        private Button btn_alta;
        private Panel PanelAlta;
        private Label lbl_reg;
        private DataGridView dgvAdmin;
        private DataGridViewTextBoxColumn id_em;
        private DataGridViewTextBoxColumn nombreEm;
        private DataGridViewTextBoxColumn rfc;
        private DataGridViewTextBoxColumn nss;
        private DataGridViewTextBoxColumn sueldo;
        private DataGridViewTextBoxColumn cel;
        private Label lbl_nom;
        private TextBox txt_cel;
        private TextBox txt_sueldo;
        private TextBox txt_nss;
        private TextBox txt_rfc;
        private Label lbl_rfc;
        private Label lbl_nss;
        private Label lbl_sueldo;
        private Label lbl_cel;
        private Label lbl_filt;
        private TextBox txt_filtro;
    }
}