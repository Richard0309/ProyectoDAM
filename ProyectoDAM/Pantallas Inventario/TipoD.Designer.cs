namespace ProyectoDAM.Pantallas_Inventario
{
    partial class TipoD
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cmbx_RAMD = new ComboBox();
            txt_TRAMD = new TextBox();
            txt_ESD = new TextBox();
            txt_SVD = new TextBox();
            txt_SAD = new TextBox();
            txt_AlmD = new TextBox();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 16);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Tipo RAM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 62);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 1;
            label2.Text = "RAM";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 99);
            label3.Name = "label3";
            label3.Size = new Size(122, 20);
            label3.TabIndex = 2;
            label3.Text = "Almacenamiento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 141);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 3;
            label4.Text = "Entradas/Salidas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 196);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 4;
            label5.Text = "Sistema Video";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 241);
            label6.Name = "label6";
            label6.Size = new Size(105, 20);
            label6.TabIndex = 5;
            label6.Text = "Sistema Audio";
            // 
            // cmbx_RAMD
            // 
            cmbx_RAMD.FormattingEnabled = true;
            cmbx_RAMD.Location = new Point(155, 62);
            cmbx_RAMD.Name = "cmbx_RAMD";
            cmbx_RAMD.Size = new Size(198, 28);
            cmbx_RAMD.TabIndex = 6;
            // 
            // txt_TRAMD
            // 
            txt_TRAMD.Location = new Point(155, 16);
            txt_TRAMD.Name = "txt_TRAMD";
            txt_TRAMD.Size = new Size(198, 27);
            txt_TRAMD.TabIndex = 7;
            // 
            // txt_ESD
            // 
            txt_ESD.Location = new Point(155, 138);
            txt_ESD.Name = "txt_ESD";
            txt_ESD.Size = new Size(198, 27);
            txt_ESD.TabIndex = 8;
            // 
            // txt_SVD
            // 
            txt_SVD.Location = new Point(155, 189);
            txt_SVD.Name = "txt_SVD";
            txt_SVD.Size = new Size(198, 27);
            txt_SVD.TabIndex = 9;
            // 
            // txt_SAD
            // 
            txt_SAD.Location = new Point(155, 234);
            txt_SAD.Name = "txt_SAD";
            txt_SAD.Size = new Size(198, 27);
            txt_SAD.TabIndex = 10;
            // 
            // txt_AlmD
            // 
            txt_AlmD.Location = new Point(155, 96);
            txt_AlmD.Name = "txt_AlmD";
            txt_AlmD.Size = new Size(198, 27);
            txt_AlmD.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(392, 279);
            panel1.TabIndex = 12;
            // 
            // TipoD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 279);
            Controls.Add(txt_AlmD);
            Controls.Add(txt_SAD);
            Controls.Add(txt_SVD);
            Controls.Add(txt_ESD);
            Controls.Add(txt_TRAMD);
            Controls.Add(cmbx_RAMD);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TipoD";
            Text = "TipoD";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cmbx_RAMD;
        private TextBox txt_TRAMD;
        private TextBox txt_ESD;
        private TextBox txt_SVD;
        private TextBox txt_SAD;
        private TextBox txt_AlmD;
        private Panel panel1;
    }
}