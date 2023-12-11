namespace ProyectoDAM.Pantallad_Admin
{
    partial class Inicio_Sesión
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio_Sesión));
            txt_user = new TextBox();
            Txt_pass = new TextBox();
            pictureBox5 = new PictureBox();
            Btn_Login = new Button();
            PanelRA = new Panel();
            lbl_register = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            PanelRA.SuspendLayout();
            SuspendLayout();
            // 
            // txt_user
            // 
            txt_user.Location = new Point(337, 232);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(172, 27);
            txt_user.TabIndex = 6;
            txt_user.Text = "Username";
            // 
            // Txt_pass
            // 
            Txt_pass.Location = new Point(339, 277);
            Txt_pass.Name = "Txt_pass";
            Txt_pass.Size = new Size(170, 27);
            Txt_pass.TabIndex = 7;
            Txt_pass.Text = "Password";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(300, 44);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(266, 266);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // Btn_Login
            // 
            Btn_Login.BackColor = Color.DodgerBlue;
            Btn_Login.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Login.ForeColor = Color.AliceBlue;
            Btn_Login.Location = new Point(337, 362);
            Btn_Login.Name = "Btn_Login";
            Btn_Login.Size = new Size(157, 50);
            Btn_Login.TabIndex = 8;
            Btn_Login.Text = "Login";
            Btn_Login.UseVisualStyleBackColor = false;
            Btn_Login.Click += Btn_Login_Click;
            // 
            // PanelRA
            // 
            PanelRA.Controls.Add(lbl_register);
            PanelRA.Controls.Add(Btn_Login);
            PanelRA.Controls.Add(Txt_pass);
            PanelRA.Controls.Add(txt_user);
            PanelRA.Controls.Add(pictureBox5);
            PanelRA.Dock = DockStyle.Fill;
            PanelRA.Location = new Point(0, 0);
            PanelRA.Name = "PanelRA";
            PanelRA.Size = new Size(888, 500);
            PanelRA.TabIndex = 10;
            PanelRA.Paint += PanelRA_Paint;
            // 
            // lbl_register
            // 
            lbl_register.AutoSize = true;
            lbl_register.BackColor = SystemColors.Window;
            lbl_register.Font = new Font("Segoe UI", 10.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lbl_register.ForeColor = Color.DodgerBlue;
            lbl_register.Location = new Point(377, 322);
            lbl_register.Name = "lbl_register";
            lbl_register.Size = new Size(81, 25);
            lbl_register.TabIndex = 9;
            lbl_register.Text = "Registrar";
            lbl_register.Click += lbl_register_Click;
            // 
            // Inicio_Sesión
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(888, 500);
            Controls.Add(PanelRA);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Inicio_Sesión";
            Text = "Inicio_Sesión";
            Load += Inicio_Sesión_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            PanelRA.ResumeLayout(false);
            PanelRA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txt_user;
        private TextBox Txt_pass;
        private PictureBox pictureBox5;
        private Button Btn_Login;
        private Panel PanelRA;
        private Label lbl_register;
    }
}