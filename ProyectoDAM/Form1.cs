using ProyectoDAM.Pantallad_Admin;
using ProyectoDAM.Pantallas_Inventario;
using ProyectoDAM.Pantallas_Proveedor;
using System.Drawing.Text;
using System.Runtime.CompilerServices;

namespace ProyectoDAM
{
    public partial class Form1 : Form
    {
        private ConexionMysql conexionMysql;
        public Form1()
        {
            InitializeComponent();
            conexionMysql = new ConexionMysql();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_inv_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblinv_Click(object sender, EventArgs e)
        {

        }

        private void lblAdmin_Click(object sender, EventArgs e)
        {

        }

        private void lblInv_Click_1(object sender, EventArgs e)
        {
            AbrirForm(new Inventario());
            pictureBox2.Visible = false;

        }
        private void AbrirForm(object Inv)
        {
            if (this.PanelAdmin.Controls.Count > 0)
            {
                this.PanelAdmin.Controls.RemoveAt(0);
            }
            Form fh = Inv as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelAdmin.Controls.Add(fh);
            this.PanelAdmin.Tag = fh;
            fh.Show();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            AbrirForm(new Inicio_Sesión());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblInv_Click_2(object sender, EventArgs e)
        {
            AbrirForm(new Inventario());
            pictureBox2.Visible = false;
            conexionMysql.GetClose();

        }

        private void lblAdmin_Click_1(object sender, EventArgs e)
        {
            AbrirForm(new Inicio_Sesión());
            conexionMysql.GetClose();

        }

        private void lblProv_Click(object sender, EventArgs e)
        {
            AbrirForm(new Proveedor());
            pictureBox2.Visible = false;
            conexionMysql.GetClose();

        }

        private void PanelAdmin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
