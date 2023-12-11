using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDAM.Pantallad_Admin
{
    public partial class Alta_Empleado : Form
    {
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lbl_regresar_Click(object sender, EventArgs e)
        {
            AbrirForm(new RegistroAdmin());
            btn_alta.Visible = false;
            lbl_admin.Visible = false;
            lbl_cel.Visible = false;
            lbl_nom.Visible = false;
            lbl_nss.Visible = false;
            lbl_regresar.Visible = false;
            lbl_rfc.Visible = false;
            lbl_sueldo.Visible = false;
            dgvEmpleado.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            txt_cel.Visible = false;
            txt_nom.Visible = false;
            txt_rfc.Visible = false;
            txt_sueldo.Visible = false;
            txt_nss.Visible = false;
        }
        private void AbrirForm(object Inv)
        {
            if (this.PanelF.Controls.Count > 0)
            {
                this.PanelF.Controls.RemoveAt(0);
            }
            Form fh = Inv as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelF.Controls.Add(fh);
            this.PanelF.Tag = fh;
            fh.Show();
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {

        }

        private void listview_alta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Alta_Em_Load(object sender, EventArgs e)
        {

        }

        private void PanelF_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
