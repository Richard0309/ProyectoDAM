namespace ProyectoDAM.Pantallas_Inventario
{
    partial class MenuInv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuInv));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            lbl_inven = new Label();
            btn_productos = new Button();
            btn_desc = new Button();
            PanelMenuInv = new Panel();
            lbl_reg = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            PanelMenuInv.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.SteelBlue;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(888, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(76, 90);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(261, 176);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(543, 90);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(258, 176);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // lbl_inven
            // 
            lbl_inven.AutoSize = true;
            lbl_inven.BackColor = Color.SteelBlue;
            lbl_inven.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_inven.ForeColor = Color.White;
            lbl_inven.Location = new Point(364, 0);
            lbl_inven.Name = "lbl_inven";
            lbl_inven.Size = new Size(152, 38);
            lbl_inven.TabIndex = 3;
            lbl_inven.Text = "Inventario";
            // 
            // btn_productos
            // 
            btn_productos.BackColor = Color.SkyBlue;
            btn_productos.Location = new Point(123, 283);
            btn_productos.Name = "btn_productos";
            btn_productos.Size = new Size(195, 69);
            btn_productos.TabIndex = 4;
            btn_productos.Text = "Productos";
            btn_productos.UseVisualStyleBackColor = false;
            btn_productos.Click += button1_Click;
            // 
            // btn_desc
            // 
            btn_desc.BackColor = Color.SkyBlue;
            btn_desc.Location = new Point(590, 283);
            btn_desc.Name = "btn_desc";
            btn_desc.Size = new Size(195, 69);
            btn_desc.TabIndex = 5;
            btn_desc.Text = "Descuentos";
            btn_desc.UseVisualStyleBackColor = false;
            btn_desc.Click += btn_desc_Click;
            // 
            // PanelMenuInv
            // 
            PanelMenuInv.BackColor = Color.SteelBlue;
            PanelMenuInv.Controls.Add(pictureBox2);
            PanelMenuInv.Controls.Add(btn_productos);
            PanelMenuInv.Controls.Add(btn_desc);
            PanelMenuInv.Controls.Add(lbl_inven);
            PanelMenuInv.Controls.Add(lbl_reg);
            PanelMenuInv.Controls.Add(pictureBox1);
            PanelMenuInv.Controls.Add(pictureBox3);
            PanelMenuInv.Dock = DockStyle.Fill;
            PanelMenuInv.Location = new Point(0, 0);
            PanelMenuInv.Name = "PanelMenuInv";
            PanelMenuInv.Size = new Size(888, 500);
            PanelMenuInv.TabIndex = 6;
            // 
            // lbl_reg
            // 
            lbl_reg.AutoSize = true;
            lbl_reg.BackColor = Color.SteelBlue;
            lbl_reg.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_reg.ForeColor = Color.White;
            lbl_reg.Location = new Point(655, 0);
            lbl_reg.Name = "lbl_reg";
            lbl_reg.Size = new Size(130, 38);
            lbl_reg.TabIndex = 7;
            lbl_reg.Text = "Regresar";
            lbl_reg.Click += lbl_reg_Click;
            // 
            // MenuInv
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 500);
            Controls.Add(PanelMenuInv);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuInv";
            Text = "MenuInv";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            PanelMenuInv.ResumeLayout(false);
            PanelMenuInv.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label lbl_inven;
        private Button btn_productos;
        private Button btn_desc;
        private Panel PanelMenuInv;
        private Label lbl_reg;
    }
}