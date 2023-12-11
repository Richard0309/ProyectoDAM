namespace ProyectoDAM.Pantallas_Inventario
{
    partial class Inventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventario));
            Btn_Login = new Button();
            txt_user = new TextBox();
            pictureBox5 = new PictureBox();
            PanelInv = new Panel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            PanelInv.SuspendLayout();
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
            // 
            // PanelInv
            // 
            PanelInv.Controls.Add(panel1);
            PanelInv.Controls.Add(pictureBox5);
            PanelInv.Dock = DockStyle.Fill;
            PanelInv.Location = new Point(0, 0);
            PanelInv.Name = "PanelInv";
            PanelInv.Size = new Size(850, 525);
            PanelInv.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Location = new Point(2, 372);
            panel1.Name = "panel1";
            panel1.Size = new Size(849, 45);
            panel1.TabIndex = 6;
            // 
            // Inventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(850, 525);
            Controls.Add(Btn_Login);
            Controls.Add(txt_user);
            Controls.Add(PanelInv);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Inventario";
            Text = "Inventario";
            Load += Inventario_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            PanelInv.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Btn_Login;
        private TextBox txt_user;
        private PictureBox pictureBox5;
        private Panel PanelInv;
        private Panel panel1;
    }
}