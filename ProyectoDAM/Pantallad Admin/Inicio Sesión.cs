using MySql.Data.MySqlClient;
using ProyectoDAM.Pantallas_Inventario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDAM.Pantallad_Admin
{
    public partial class Inicio_Sesión : Form
    {
        private Admin mAdmin;
        private Admin_Consultas mAdmin_Consultas;
        private ConexionMysql conexionMysql;

        public Inicio_Sesión()
        {
            InitializeComponent();
            conexionMysql = new ConexionMysql();
            mAdmin = new Admin();
            mAdmin_Consultas = new Admin_Consultas();
        }

        private void Inicio_Sesión_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            string nombre = txt_user.Text;
            string pass = Txt_pass.Text;
            if (!datosCorrectos())
            {
                return;
            }
            conexionMysql.GetConnection();
            MySqlCommand codigo = new MySqlCommand();
            MySqlConnection connection = new MySqlConnection();
            codigo.Connection = conexionMysql.GetConnection();
            codigo.CommandText = ("SELECT * FROM Usuario WHERE Nombre = '" + nombre + "'AND Contraseña = '" + pass + "'");
            MySqlDataReader reader = codigo.ExecuteReader();
            if (reader.Read())
            {
                AbrirForm(new RegistroAdmin());
                pictureBox5.Visible = false;
                txt_user.Visible = false;
                Txt_pass.Visible = false;
                Btn_Login.Visible = false;
                lbl_register.Visible = false;
            }
            else
            {
                MessageBox.Show("Usuario o contraseña no válido");
            }
            conexionMysql.GetClose();
            /*conexionMysql.GetConnection().Close();
            AbrirForm(new RegistroAdmin());
            pictureBox5.Visible = false;
            txt_user.Visible = false;
            Txt_pass.Visible = false;
            Btn_Login.Visible = false;
            lbl_register.Visible = false;*/
        }

        private bool datosCorrectos()
        {
            if (txt_user.Text.Trim().Equals("Username"))
            {
                MessageBox.Show("Ingrese el Nombre");
                return false;
            }
            if (txt_user.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el Nombre");
                return false;
            }
            if (Txt_pass.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el Nombre");
                return false;
            }
            if (Txt_pass.Text.Trim().Equals("Password"))
            {
                MessageBox.Show("Ingrese la contraseña");
                return false;
            }
            return true;
        }

        private void AbrirForm(object Inv)
        {
            if (this.PanelRA.Controls.Count > 0)
            {
                this.PanelRA.Controls.RemoveAt(0);
            }
            Form fh = Inv as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelRA.Controls.Add(fh);
            this.PanelRA.Tag = fh;
            fh.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void lbl_register_Click(object sender, EventArgs e)
        {
            AbrirForm(new Crear_c());
            pictureBox5.Visible = false;
            txt_user.Visible = false;
            Txt_pass.Visible = false;
            Btn_Login.Visible = false;
            lbl_register.Visible = false;
        }

        private void PanelRA_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
