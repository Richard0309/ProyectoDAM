using MySql.Data.MySqlClient;
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
    public partial class RegistroAdmin : Form
    {
        private List<EmpleadoC> mEmplados;
        private EmpleadoC mEmpleado;
        private EmpleadoConsultas mEmpleadoConsultas;
        private ConexionMysql conexionMysql;
        public RegistroAdmin()
        {
            InitializeComponent();

            mEmplados = new List<EmpleadoC>();
            mEmpleadoConsultas = new EmpleadoConsultas();
            mEmpleado = new EmpleadoC();
            conexionMysql = new ConexionMysql();

            cargarEmpleados();
        }

        private void cargarEmpleados(string filtro = "")
        {
            dgvAdmin.Rows.Clear();
            dgvAdmin.Refresh();
            mEmplados.Clear();
            mEmplados = mEmpleadoConsultas.GetEmpleados(filtro);

            for (int i = 0; i < mEmplados.Count; i++)
            {
                dgvAdmin.RowTemplate.Height = 50;
                dgvAdmin.Rows.Add(
                    mEmplados[i].id,
                    mEmplados[i].nombre,
                    mEmplados[i].rfc,
                    mEmplados[i].nss,
                    mEmplados[i].sueldo,
                    mEmplados[i].cel);

            }
            conexionMysql.GetClose();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!datosCorrectos())
            {
                return;
            }
            cargarDatos();
            if (mEmpleadoConsultas.agregarEmpleado(mEmpleado))
            {
                MessageBox.Show("Alta Correcta");
                cargarEmpleados();
                LimpiarCampos();
            }
            conexionMysql.GetClose();
        }

        private void LimpiarCampos()
        {
            txt_nombre.Text = "";
            txt_cel.Text = "";
            txt_nss.Text = "";
            txt_rfc.Text = "";
            txt_sueldo.Text = "";
            txt_bus.Text = "";
        }

        private void cargarDatos()
        {
            mEmpleado.nombre = txt_nombre.Text.Trim();
            mEmpleado.nss = txt_nss.Text.Trim();
            mEmpleado.rfc = txt_rfc.Text.Trim();
            mEmpleado.cel = txt_cel.Text.Trim();
            mEmpleado.sueldo = float.Parse(txt_sueldo.Text.Trim());
            mEmpleado.id = getFolioIfExists();
        }

        private bool datosCorrectos()
        {
            if (txt_nombre.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el Nombre");
                return false;
            }
            if (txt_cel.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el cel");

                return false;
            }
            if (txt_nss.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el NSS");

                return false;
            }
            if (txt_rfc.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el RFC");

                return false;
            }
            if (txt_sueldo.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el Sueldo");

                return false;
            }
            return true;
        }

        private void AbrirForm(object Inv)
        {
            if (this.PanelAlta.Controls.Count > 0)
            {
                this.PanelAlta.Controls.RemoveAt(0);
            }
            Form fh = Inv as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelAlta.Controls.Add(fh);
            this.PanelAlta.Tag = fh;
            fh.Show();
        }

        private void lbl_reg_Click(object sender, EventArgs e)
        {
            conexionMysql.GetClose();
            AbrirForm(new Inicio_Sesión());
            lbl_admin.Visible = false;
            lbl_alta.Visible = false;
            lbl_filt.Visible = false;
            lbl_reg.Visible = false;
            lbl_cel.Visible = false;
            lbl_sueldo.Visible = false;
            lbl_nss.Visible = false;
            lbl_rfc.Visible = false;
            lbl_nom.Visible = false;


            pictureBox1.Visible = false;
            btn_alta.Visible = false;
            btn_baja.Visible = false;
            btn_buscar.Visible = false;
            txt_nombre.Visible = false;
            txt_bus.Visible = false;
            txt_nss.Visible = false;
            txt_rfc.Visible = false;    
            txt_cel.Visible = false;
            txt_sueldo.Visible=false;
            txt_filtro.Visible = false;

            dgvAdmin.Visible = false;
        }

        private void PanelAlta_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btn_baja_Click(object sender, EventArgs e)
        {
            if (getFolioIfExists() == -1)
            {
                return;
            }

            if (MessageBox.Show("¿Desea dar de baja al empleado?", "Baja Empleado",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cargarDatos();
                if (mEmpleadoConsultas.eliminarEmpleado(mEmpleado))
                {
                    MessageBox.Show("Baja Exitosa");

                    cargarEmpleados();
                    LimpiarCampos();
                }
            }
            conexionMysql.GetClose();

        }
        private int getFolioIfExists()
        {
            if (!txt_bus.Text.Trim().Equals(""))
            {
                if (int.TryParse(txt_bus.Text.Trim(), out int folio))
                {
                    return folio;
                }
                return -1;
            }
            else return -1;
        }

        private void dgvAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvAdmin.Rows[e.RowIndex];
            txt_bus.Text = Convert.ToString(fila.Cells["id_em"].Value);
            txt_nombre.Text = Convert.ToString(fila.Cells["nombreEm"].Value);
            txt_cel.Text = Convert.ToString(fila.Cells["cel"].Value);
            txt_nss.Text = Convert.ToString(fila.Cells["nss"].Value);
            txt_rfc.Text = Convert.ToString(fila.Cells["rfc"].Value);
            txt_sueldo.Text = Convert.ToString(fila.Cells["sueldo"].Value);
        }


        private void txt_filtro_TextChanged(object sender, EventArgs e)
        {
            cargarEmpleados(txt_filtro.Text.Trim());
        }

        private void txt_rfc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
