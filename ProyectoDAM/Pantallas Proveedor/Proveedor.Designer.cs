namespace ProyectoDAM.Pantallas_Proveedor
{
    partial class Proveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proveedor));
            Btn_Login = new Button();
            txt_user = new TextBox();
            pictureBox5 = new PictureBox();
            PanelProv = new Panel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            PanelProv.SuspendLayout();
            SuspendLayout();
            // 
            // Btn_Login
            // 
            Btn_Login.BackColor = Color.DodgerBlue;
            Btn_Login.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Login.ForeColor = Color.AliceBlue;
            Btn_Login.Location = new Point(337, 274);
            Btn_Login.Name = "Btn_Login";
            Btn_Login.Size = new Size(157, 50);
            Btn_Login.TabIndex = 8;
            Btn_Login.Text = "Login";
            Btn_Login.UseVisualStyleBackColor = false;
            Btn_Login.Click += Btn_Login_Click;
            // 
            // txt_user
            // 
            txt_user.Location = new Point(337, 232);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(172, 27);
            txt_user.TabIndex = 6;
            txt_user.Text = "Número de Empleado";
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
            // PanelProv
            // 
            PanelProv.Controls.Add(panel1);
            PanelProv.Controls.Add(Btn_Login);
            PanelProv.Controls.Add(txt_user);
            PanelProv.Controls.Add(pictureBox5);
            PanelProv.Dock = DockStyle.Fill;
            PanelProv.Location = new Point(0, 0);
            PanelProv.Name = "PanelProv";
            PanelProv.Size = new Size(888, 500);
            PanelProv.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Location = new Point(2, 379);
            panel1.Name = "panel1";
            panel1.Size = new Size(885, 43);
            panel1.TabIndex = 9;
            // 
            // Proveedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(888, 500);
            Controls.Add(PanelProv);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Proveedor";
            Text = "Proveedor";
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            PanelProv.ResumeLayout(false);
            PanelProv.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button Btn_Login;
        private TextBox txt_user;
        private PictureBox pictureBox5;
        private Panel PanelProv;
        private Panel panel1;
    }
}