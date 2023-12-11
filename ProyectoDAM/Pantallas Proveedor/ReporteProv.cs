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
    public partial class ReporteProv : Form
    {
        private List<ProveedorC> mProvedores;
        private ProveedorC mProvedor;
        private ProveedorConsultas mProveedorConsultas;
        private ConexionMysql conexionMysql;
        public ReporteProv()
        {
            InitializeComponent();
            mProvedores = new List<ProveedorC>();
            mProvedor = new ProveedorC();
            mProveedorConsultas = new ProveedorConsultas();
            conexionMysql = new ConexionMysql();

            cargarProvedores();

        }

        private void cargarProvedores(string filtro = "")
        {
            dgvP.Rows.Clear();
            dgvP.Refresh();
            mProvedores.Clear();
            mProvedores = mProveedorConsultas.getProvedores(filtro);

            for (int i = 0; i < mProvedores.Count; i++)
            {
                dgvP.RowTemplate.Height = 50;
                dgvP.Rows.Add(
                    mProvedores[i].id_prov,
                    mProvedores[i].proveedor_name,
                    mProvedores[i].celular,
                    mProvedores[i].tipoP,
                    mProvedores[i].correo);
            }
            conexionMysql.GetClose();
        }

        private void lbl_Reg_Click(object sender, EventArgs e)
        {
            conexionMysql.GetClose();
            AbrirForm(new Proveedor());
            pictureBox1.Visible = false;
            lbl_altaP.Visible = false;

            lbl_buscP.Visible = false;
            lbl_merc.Visible = false;
            lbl_Reg.Visible = false;
            lbl_TitP.Visible = false;
            lbl_filt.Visible = false;
            txt_filtrar.Visible = false;
            txt_BuscP.Visible = false;
            btn_AltaP.Visible = false;
            btn_BajaP.Visible = false;
           
            btn_OpcionesM.Visible = false;
            dgvP.Visible = false;

        }
        private void AbrirForm(object Inv)
        {
            if (this.PanelRegP.Controls.Count > 0)
            {
                this.PanelRegP.Controls.RemoveAt(0);
            }
            Form fh = Inv as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelRegP.Controls.Add(fh);
            this.PanelRegP.Tag = fh;
            fh.Show();
        }

        private void btn_AltaP_Click(object sender, EventArgs e)
        {
            AbrirForm(new AltaP());
            pictureBox1.Visible = false;
            lbl_altaP.Visible = false;

            lbl_buscP.Visible = false;
            lbl_merc.Visible = false;
            lbl_Reg.Visible = false;
            lbl_TitP.Visible = false;
            lbl_filt.Visible = false;
            txt_filtrar.Visible = false;
            txt_BuscP.Visible = false;
            btn_AltaP.Visible = false;
            btn_BajaP.Visible = false;
            btn_OpcionesM.Visible = false;
            dgvP.Visible = false;
        }

        private void btn_OpcionesM_Click(object sender, EventArgs e)
        {
            AbrirForm(new MercancíaR());
            pictureBox1.Visible = false;
            lbl_altaP.Visible = false;

            lbl_buscP.Visible = false;
            lbl_merc.Visible = false;
            lbl_Reg.Visible = false;
            lbl_TitP.Visible = false;
            lbl_filt.Visible = false;
            txt_filtrar.Visible = false;

            txt_BuscP.Visible = false;
            btn_AltaP.Visible = false;
            btn_BajaP.Visible = false;
            btn_OpcionesM.Visible = false;
            dgvP.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void PanelRegP_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvP.Rows[e.RowIndex];
            txt_BuscP.Text = Convert.ToString(fila.Cells["id_prov"].Value);
        }

        private void btn_BajaP_Click(object sender, EventArgs e)
        {

            if (getFolioIfExists() == -1)
            {
                return;
            }

            if (MessageBox.Show("¿Desea dar de baja al empleado?", "Baja Empleado",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cargarDatos();
                if (mProveedorConsultas.eliminarProvedor(mProvedor))
                {
                    MessageBox.Show("Baja Exitosa");

                    cargarProvedores();
                    LimpiarCampos();
                }
            }
            conexionMysql.GetClose();
        }

        private void LimpiarCampos()
        {
            txt_BuscP.Text = "";
        }

        private void cargarDatos()
        {
            mProvedor.id_prov = getFolioIfExists();
        }

        private int getFolioIfExists()
        {
            if (!txt_BuscP.Text.Trim().Equals(""))
            {
                if (int.TryParse(txt_BuscP.Text.Trim(), out int folio))
                {
                    return folio;
                }
                return -1;
            }
            else return -1;
        }

        private void txt_filtrar_TextChanged(object sender, EventArgs e)
        {
            cargarProvedores(txt_filtrar.Text.Trim());
        }
    }
}
