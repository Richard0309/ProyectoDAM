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
    public partial class Crear_c : Form
    {
        private Admin mAdmin;
        private Admin_Consultas mAdmin_Consultas;
        private ConexionMysql conexionMysql;
        public Crear_c()
        {
            InitializeComponent();

            mAdmin_Consultas = new Admin_Consultas();
            mAdmin = new Admin();
            conexionMysql = new ConexionMysql();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            AbrirForm(new Inicio_Sesión());
            txt_nom.Visible = false;
            txt_correo.Visible = false;
            txt_contraseña.Visible = false;
            lbl_contraseña.Visible = false;
            lbl_correo.Visible = false;
            lbl_nom.Visible = false;
            lbl_registro.Visible = false;
            lbl_regresar.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            btn_cuardar.Visible = false;
            conexionMysql.GetClose();
        }
        private void AbrirForm(object Inv)
        {
            if (this.Panel_Crear.Controls.Count > 0)
            {
                this.Panel_Crear.Controls.RemoveAt(0);
            }
            Form fh = Inv as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Panel_Crear.Controls.Add(fh);
            this.Panel_Crear.Tag = fh;
            fh.Show();
        }

        private void btn_cuardar_Click(object sender, EventArgs e)
        {

            if (!datosCorrectos())
            {
                return;
            }
            cargarDatos();
            if (mAdmin_Consultas.agregarAdmin(mAdmin))
            {
                MessageBox.Show("Alta Correcta");
                
                LimpiarCampos();
            }
            conexionMysql.GetClose();
        }

        private void LimpiarCampos()
        {
            txt_contraseña.Text = "";
            txt_correo.Text = "";
            txt_nom.Text = "";
        }

        private void cargarDatos()
        {
            mAdmin.name = txt_nom.Text.Trim();
            mAdmin.correo = txt_correo.Text.Trim();
            mAdmin.contra=txt_contraseña.Text.Trim();
        }

        private bool datosCorrectos()
        {
            if (txt_nom.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el Nombre");
                return false;
            }
            if (txt_correo.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el Correo");
                return false;
            }
            if (txt_contraseña.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese la contraseña");
                return false;
            }
            return true;
        }
    }
}
