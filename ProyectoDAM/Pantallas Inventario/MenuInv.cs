using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDAM.Pantallas_Inventario
{
    public partial class MenuInv : Form
    {
        private ConexionMysql conexionMysql;
        public MenuInv()
        {
            InitializeComponent();
            conexionMysql = new ConexionMysql();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirForm(new ReporteInvcs());
            lbl_inven.Visible = false;
            lbl_reg.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            btn_desc.Visible = false;
            btn_productos.Visible = false;


        }
        private void AbrirForm(object Inv)
        {
            if (this.PanelMenuInv.Controls.Count > 0)
            {
                this.PanelMenuInv.Controls.RemoveAt(0);
            }
            Form fh = Inv as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelMenuInv.Controls.Add(fh);
            this.PanelMenuInv.Tag = fh;
            fh.Show();
        }

        private void lbl_reg_Click(object sender, EventArgs e)
        {
            conexionMysql.GetClose();
            AbrirForm(new Inventario());
            lbl_inven.Visible = false;
            lbl_reg.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            btn_desc.Visible = false;
            btn_productos.Visible = false;
        }

        private void btn_desc_Click(object sender, EventArgs e)
        {
            AbrirForm(new Descuentoscs());
            lbl_inven.Visible = false;
            lbl_reg.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            btn_desc.Visible = false;
            btn_productos.Visible = false;
        }
    }
}
