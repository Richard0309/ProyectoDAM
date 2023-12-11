namespace ProyectoDAM.Pantallas_Inventario
{
    partial class TipoP
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
            lbl_SisAu = new Label();
            lbl_SisVid = new Label();
            lbl_ES = new Label();
            txt_SVP = new TextBox();
            txt_ESP = new TextBox();
            txt_SAP = new TextBox();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // lbl_SisAu
            // 
            lbl_SisAu.AutoSize = true;
            lbl_SisAu.Location = new Point(12, 57);
            lbl_SisAu.Name = "lbl_SisAu";
            lbl_SisAu.Size = new Size(105, 20);
            lbl_SisAu.TabIndex = 0;
            lbl_SisAu.Text = "Sistema Audio";
            // 
            // lbl_SisVid
            // 
            lbl_SisVid.AutoSize = true;
            lbl_SisVid.Location = new Point(13, 9);
            lbl_SisVid.Name = "lbl_SisVid";
            lbl_SisVid.Size = new Size(96, 20);
            lbl_SisVid.TabIndex = 1;
            lbl_SisVid.Text = "Sistem Video";
            // 
            // lbl_ES
            // 
            lbl_ES.AutoSize = true;
            lbl_ES.Location = new Point(11, 93);
            lbl_ES.Name = "lbl_ES";
            lbl_ES.Size = new Size(119, 20);
            lbl_ES.TabIndex = 2;
            lbl_ES.Text = "Entradas/Salidas";
            // 
            // txt_SVP
            // 
            txt_SVP.Location = new Point(178, 12);
            txt_SVP.Name = "txt_SVP";
            txt_SVP.Size = new Size(138, 27);
            txt_SVP.TabIndex = 3;
            // 
            // txt_ESP
            // 
            txt_ESP.Location = new Point(178, 90);
            txt_ESP.Name = "txt_ESP";
            txt_ESP.Size = new Size(138, 27);
            txt_ESP.TabIndex = 4;
            // 
            // txt_SAP
            // 
            txt_SAP.Location = new Point(178, 54);
            txt_SAP.Name = "txt_SAP";
            txt_SAP.Size = new Size(138, 27);
            txt_SAP.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(354, 142);
            panel1.TabIndex = 6;
            // 
            // TipoP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 142);
            Controls.Add(lbl_ES);
            Controls.Add(txt_SAP);
            Controls.Add(txt_ESP);
            Controls.Add(lbl_SisVid);
            Controls.Add(lbl_SisAu);
            Controls.Add(txt_SVP);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TipoP";
            Text = "TipoP";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_SisAu;
        private Label lbl_SisVid;
        private Label lbl_ES;
        private TextBox txt_SVP;
        private TextBox txt_ESP;
        private TextBox txt_SAP;
        private Panel panel1;
    }
}