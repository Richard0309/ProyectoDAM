namespace ProyectoDAM.Pantallas_Inventario
{
    partial class TipoC
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
            panel1 = new Panel();
            lbl_TRAMC = new Label();
            lbl_RAMC = new Label();
            txt_TRAMC = new TextBox();
            cbmx_RAMC = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cbmx_RAMC);
            panel1.Controls.Add(txt_TRAMC);
            panel1.Controls.Add(lbl_RAMC);
            panel1.Controls.Add(lbl_TRAMC);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(392, 279);
            panel1.TabIndex = 0;
            // 
            // lbl_TRAMC
            // 
            lbl_TRAMC.AutoSize = true;
            lbl_TRAMC.Location = new Point(12, 18);
            lbl_TRAMC.Name = "lbl_TRAMC";
            lbl_TRAMC.Size = new Size(75, 20);
            lbl_TRAMC.TabIndex = 0;
            lbl_TRAMC.Text = "Tipo RAM";
            // 
            // lbl_RAMC
            // 
            lbl_RAMC.AutoSize = true;
            lbl_RAMC.Location = new Point(12, 83);
            lbl_RAMC.Name = "lbl_RAMC";
            lbl_RAMC.Size = new Size(41, 20);
            lbl_RAMC.TabIndex = 2;
            lbl_RAMC.Text = "RAM";
            lbl_RAMC.Click += label3_Click;
            // 
            // txt_TRAMC
            // 
            txt_TRAMC.Location = new Point(136, 15);
            txt_TRAMC.Name = "txt_TRAMC";
            txt_TRAMC.Size = new Size(189, 27);
            txt_TRAMC.TabIndex = 3;
            // 
            // cbmx_RAMC
            // 
            cbmx_RAMC.FormattingEnabled = true;
            cbmx_RAMC.Location = new Point(134, 85);
            cbmx_RAMC.Name = "cbmx_RAMC";
            cbmx_RAMC.Size = new Size(191, 28);
            cbmx_RAMC.TabIndex = 4;
            // 
            // TipoC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 279);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TipoC";
            Text = "TipoC";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbl_RAMC;
        private Label lbl_TRAMC;
        private ComboBox cbmx_RAMC;
        private TextBox txt_TRAMC;
    }
}