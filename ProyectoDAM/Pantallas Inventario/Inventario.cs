using MySql.Data.MySqlClient;
using ProyectoDAM.Pantallad_Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProyectoDAM.Pantallas_Inventario
{
    public partial class Inventario : Form
    {
        private ProductoC mProducto;
        private ConexionMysql conexionMysql;
        public Inventario()
        {
            InitializeComponent();

            mProducto = new ProductoC();
            conexionMysql = new ConexionMysql();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Inventario_Load(object sender, EventArgs e)
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
                AbrirForm(new MenuInv());
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
            /*AbrirForm(new MenuInv());
            txt_user.Visible = false;
            Btn_Login.Visible = false;
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
            if (this.PanelInv.Controls.Count > 0)
            {
                this.PanelInv.Controls.RemoveAt(0);
            }
            Form fh = Inv as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelInv.Controls.Add(fh);
            this.PanelInv.Tag = fh;
            fh.Show();
        }
        
    }
}
