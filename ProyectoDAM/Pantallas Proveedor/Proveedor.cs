using MySql.Data.MySqlClient;
using ProyectoDAM.Pantallas_Inventario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDAM.Pantallas_Proveedor
{
    public partial class Proveedor : Form
    {
        private ProveedorC mProvedor;
        private ConexionMysql conexionMysql;
        public Proveedor()
        {
            InitializeComponent();
            mProvedor = new ProveedorC();
            conexionMysql = new ConexionMysql();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            string user = txt_user.Text;
            if (!datosCorrectos())
            {
                return;
            }
            conexionMysql.GetConnection();
            MySqlCommand codigo = new MySqlCommand();
            MySqlConnection connection = new MySqlConnection();
            codigo.Connection = conexionMysql.GetConnection();
            codigo.CommandText = ("SELECT * FROM Empleado WHERE Id_empleado = '" + user + "'");
            MySqlDataReader reader = codigo.ExecuteReader();
            if (reader.Read())
            {
                AbrirForm(new ReporteProv());
                txt_user.Visible = false;
                Btn_Login.Visible = false;
                pictureBox5.Visible = false;
                panel1.Visible = false;
            }
            else
            {
                MessageBox.Show("Usuario no válido");
            }
            conexionMysql.GetClose();
            /*AbrirForm(new ReporteProv());
            Btn_Login.Visible = false;
            txt_user.Visible = false;
            pictureBox5.Visible = false;*/
        }

        private bool datosCorrectos()
        {
            if (txt_user.Text.Trim().Equals("Número de Empleado"))
            {
                MessageBox.Show("Ingrese un Número de Empleado Válido");
                return false;
            }
            if (txt_user.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese un Número de Empleado Válido");
                return false;
            }
            return true;
        }

        private void AbrirForm(object Inv)
        {
            if (this.PanelProv.Controls.Count > 0)
            {
                this.PanelProv.Controls.RemoveAt(0);
            }
            Form fh = Inv as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelProv.Controls.Add(fh);
            this.PanelProv.Tag = fh;
            fh.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
