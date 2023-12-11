namespace ProyectoDAM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            lblAdmin = new Label();
            lblInv = new Label();
            lblProv = new Label();
            PanelAdmin = new Panel();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(887, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // lblAdmin
            // 
            lblAdmin.AutoSize = true;
            lblAdmin.BackColor = Color.DodgerBlue;
            lblAdmin.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdmin.ForeColor = Color.White;
            lblAdmin.Location = new Point(46, 9);
            lblAdmin.Name = "lblAdmin";
            lblAdmin.Size = new Size(207, 38);
            lblAdmin.TabIndex = 1;
            lblAdmin.Text = "Administrador";
            lblAdmin.Click += lblAdmin_Click_1;
            // 
            // lblInv
            // 
            lblInv.AutoSize = true;
            lblInv.BackColor = Color.DodgerBlue;
            lblInv.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInv.ForeColor = Color.White;
            lblInv.Location = new Point(373, 9);
            lblInv.Name = "lblInv";
            lblInv.Size = new Size(152, 38);
            lblInv.TabIndex = 2;
            lblInv.Text = "Inventario";
            lblInv.Click += lblInv_Click_2;
            // 
            // lblProv
            // 
            lblProv.AutoSize = true;
            lblProv.BackColor = Color.DodgerBlue;
            lblProv.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProv.ForeColor = Color.White;
            lblProv.Location = new Point(680, 9);
            lblProv.Name = "lblProv";
            lblProv.Size = new Size(152, 38);
            lblProv.TabIndex = 3;
            lblProv.Text = "Proveedor";
            lblProv.Click += lblProv_Click;
            // 
            // PanelAdmin
            // 
            PanelAdmin.BackColor = Color.White;
            PanelAdmin.Controls.Add(pictureBox2);
            PanelAdmin.Location = new Point(0, 62);
            PanelAdmin.Name = "PanelAdmin";
            PanelAdmin.Size = new Size(888, 500);
            PanelAdmin.TabIndex = 4;
            PanelAdmin.Paint += PanelAdmin_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(300, 44);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(378, 346);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 562);
            Controls.Add(lblAdmin);
            Controls.Add(lblProv);
            Controls.Add(PanelAdmin);
            Controls.Add(lblInv);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PanelAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblAdmin;
        private Label lblInv;
        private Label lblProv;
        private Panel PanelAdmin;
        private PictureBox pictureBox2;
    }
}
