namespace ProyectoDAM.Pantallad_Admin
{
    partial class Alta_Empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alta_Empleado));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lbl_admin = new Label();
            lbl_nom = new Label();
            lbl_rfc = new Label();
            lbl_nss = new Label();
            lbl_cel = new Label();
            lbl_sueldo = new Label();
            txt_nom = new TextBox();
            txt_rfc = new TextBox();
            txt_nss = new TextBox();
            txt_cel = new TextBox();
            txt_sueldo = new TextBox();
            btn_alta = new Button();
            PanelF = new Panel();
            dgvEmpleado = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NombreEm = new DataGridViewTextBoxColumn();
            Sueldo = new DataGridViewTextBoxColumn();
            NSS = new DataGridViewTextBoxColumn();
            RFC = new DataGridViewTextBoxColumn();
            Cel = new DataGridViewTextBoxColumn();
            lbl_regresar = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            PanelF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleado).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(849, 63);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // lbl_admin
            // 
            lbl_admin.AutoSize = true;
            lbl_admin.BackColor = Color.DodgerBlue;
            lbl_admin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_admin.ForeColor = Color.White;
            lbl_admin.Location = new Point(326, 9);
            lbl_admin.Name = "lbl_admin";
            lbl_admin.Size = new Size(74, 28);
            lbl_admin.TabIndex = 3;
            lbl_admin.Text = "Admin";
            // 
            // lbl_nom
            // 
            lbl_nom.AutoSize = true;
            lbl_nom.BackColor = Color.LightSkyBlue;
            lbl_nom.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_nom.Location = new Point(132, 68);
            lbl_nom.Name = "lbl_nom";
            lbl_nom.Size = new Size(89, 28);
            lbl_nom.TabIndex = 4;
            lbl_nom.Text = "Nombre";
            lbl_nom.Click += label2_Click;
            // 
            // lbl_rfc
            // 
            lbl_rfc.AutoSize = true;
            lbl_rfc.BackColor = Color.LightSkyBlue;
            lbl_rfc.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_rfc.Location = new Point(135, 105);
            lbl_rfc.Name = "lbl_rfc";
            lbl_rfc.Size = new Size(47, 28);
            lbl_rfc.TabIndex = 5;
            lbl_rfc.Text = "RFC";
            // 
            // lbl_nss
            // 
            lbl_nss.AutoSize = true;
            lbl_nss.BackColor = Color.LightSkyBlue;
            lbl_nss.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_nss.Location = new Point(132, 153);
            lbl_nss.Name = "lbl_nss";
            lbl_nss.Size = new Size(50, 28);
            lbl_nss.TabIndex = 6;
            lbl_nss.Text = "NSS";
            // 
            // lbl_cel
            // 
            lbl_cel.AutoSize = true;
            lbl_cel.BackColor = Color.LightSkyBlue;
            lbl_cel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_cel.Location = new Point(132, 186);
            lbl_cel.Name = "lbl_cel";
            lbl_cel.Size = new Size(41, 28);
            lbl_cel.TabIndex = 7;
            lbl_cel.Text = "Cel";
            lbl_cel.Click += label5_Click;
            // 
            // lbl_sueldo
            // 
            lbl_sueldo.AutoSize = true;
            lbl_sueldo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_sueldo.Location = new Point(132, 215);
            lbl_sueldo.Name = "lbl_sueldo";
            lbl_sueldo.Size = new Size(76, 28);
            lbl_sueldo.TabIndex = 8;
            lbl_sueldo.Text = "Sueldo";
            // 
            // txt_nom
            // 
            txt_nom.Location = new Point(261, 72);
            txt_nom.Name = "txt_nom";
            txt_nom.Size = new Size(250, 27);
            txt_nom.TabIndex = 9;
            // 
            // txt_rfc
            // 
            txt_rfc.Location = new Point(261, 105);
            txt_rfc.Name = "txt_rfc";
            txt_rfc.Size = new Size(250, 27);
            txt_rfc.TabIndex = 10;
            // 
            // txt_nss
            // 
            txt_nss.Location = new Point(261, 153);
            txt_nss.Name = "txt_nss";
            txt_nss.Size = new Size(250, 27);
            txt_nss.TabIndex = 11;
            // 
            // txt_cel
            // 
            txt_cel.Location = new Point(261, 186);
            txt_cel.Name = "txt_cel";
            txt_cel.Size = new Size(250, 27);
            txt_cel.TabIndex = 12;
            // 
            // txt_sueldo
            // 
            txt_sueldo.Location = new Point(261, 219);
            txt_sueldo.Name = "txt_sueldo";
            txt_sueldo.Size = new Size(250, 27);
            txt_sueldo.TabIndex = 13;
            // 
            // btn_alta
            // 
            btn_alta.BackColor = Color.SkyBlue;
            btn_alta.Location = new Point(547, 96);
            btn_alta.Name = "btn_alta";
            btn_alta.Size = new Size(112, 39);
            btn_alta.TabIndex = 14;
            btn_alta.Text = "Dar de alta";
            btn_alta.UseVisualStyleBackColor = false;
            btn_alta.Click += btn_alta_Click;
            // 
            // PanelF
            // 
            PanelF.BackColor = Color.LightSkyBlue;
            PanelF.Controls.Add(dgvEmpleado);
            PanelF.Controls.Add(lbl_regresar);
            PanelF.Controls.Add(txt_sueldo);
            PanelF.Controls.Add(pictureBox2);
            PanelF.Controls.Add(lbl_sueldo);
            PanelF.Location = new Point(0, -4);
            PanelF.Name = "PanelF";
            PanelF.Size = new Size(859, 490);
            PanelF.TabIndex = 15;
            PanelF.Paint += PanelF_Paint;
            // 
            // dgvEmpleado
            // 
            dgvEmpleado.BackgroundColor = Color.White;
            dgvEmpleado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleado.Columns.AddRange(new DataGridViewColumn[] { ID, NombreEm, Sueldo, NSS, RFC, Cel });
            dgvEmpleado.GridColor = Color.LightSkyBlue;
            dgvEmpleado.Location = new Point(12, 271);
            dgvEmpleado.Name = "dgvEmpleado";
            dgvEmpleado.RowHeadersWidth = 51;
            dgvEmpleado.Size = new Size(805, 188);
            dgvEmpleado.TabIndex = 14;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 60;
            // 
            // NombreEm
            // 
            NombreEm.HeaderText = "Nombre";
            NombreEm.MinimumWidth = 6;
            NombreEm.Name = "NombreEm";
            NombreEm.Width = 400;
            // 
            // Sueldo
            // 
            Sueldo.HeaderText = "Sueldo";
            Sueldo.MinimumWidth = 6;
            Sueldo.Name = "Sueldo";
            Sueldo.Width = 400;
            // 
            // NSS
            // 
            NSS.HeaderText = "NSS";
            NSS.MinimumWidth = 6;
            NSS.Name = "NSS";
            NSS.Width = 400;
            // 
            // RFC
            // 
            RFC.HeaderText = "RFC";
            RFC.MinimumWidth = 6;
            RFC.Name = "RFC";
            RFC.Width = 400;
            // 
            // Cel
            // 
            Cel.HeaderText = "CEL.";
            Cel.MinimumWidth = 6;
            Cel.Name = "Cel";
            Cel.Width = 200;
            // 
            // lbl_regresar
            // 
            lbl_regresar.AutoSize = true;
            lbl_regresar.BackColor = Color.DodgerBlue;
            lbl_regresar.ForeColor = Color.White;
            lbl_regresar.Location = new Point(705, 16);
            lbl_regresar.Name = "lbl_regresar";
            lbl_regresar.Size = new Size(67, 20);
            lbl_regresar.TabIndex = 0;
            lbl_regresar.Text = "Regresar";
            lbl_regresar.Click += lbl_regresar_Click;
            // 
            // Alta_Empleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 486);
            Controls.Add(btn_alta);
            Controls.Add(txt_cel);
            Controls.Add(txt_nss);
            Controls.Add(txt_rfc);
            Controls.Add(txt_nom);
            Controls.Add(lbl_cel);
            Controls.Add(lbl_nss);
            Controls.Add(lbl_rfc);
            Controls.Add(lbl_nom);
            Controls.Add(lbl_admin);
            Controls.Add(pictureBox1);
            Controls.Add(PanelF);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Alta_Empleado";
            Text = "Alta_Em";
            Load += Alta_Em_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            PanelF.ResumeLayout(false);
            PanelF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lbl_admin;
        private Label lbl_nom;
        private Label lbl_rfc;
        private Label lbl_nss;
        private Label lbl_cel;
        private Label lbl_sueldo;
        private TextBox txt_nom;
        private TextBox txt_rfc;
        private TextBox txt_nss;
        private TextBox txt_cel;
        private TextBox txt_sueldo;
        private Button btn_alta;
        private Panel PanelF;
        private Label lbl_regresar;
        private DataGridView dgvEmpleado;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NombreEm;
        private DataGridViewTextBoxColumn Sueldo;
        private DataGridViewTextBoxColumn NSS;
        private DataGridViewTextBoxColumn RFC;
        private DataGridViewTextBoxColumn Cel;
    }
}