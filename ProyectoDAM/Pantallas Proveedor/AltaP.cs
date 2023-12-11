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
    public partial class AltaP : Form
    {
        private List<ProveedorC> mProvedores;
        private ProveedorC mProvedor;
        private ProveedorConsultas mProveedorConsultas;
        private ConexionMysql conexionMysql;
        public AltaP()
        {
            InitializeComponent();
            mProvedores = new List<ProveedorC>();
            mProveedorConsultas = new ProveedorConsultas();
            mProvedor = new ProveedorC();
            conexionMysql = new ConexionMysql();

            cargarProvedores();
        }

        private void cargarProvedores(string filtro ="")
        {
            dgvProvedores.Rows.Clear();
            dgvProvedores.Refresh();
            mProvedores.Clear();
            mProvedores = mProveedorConsultas.getProvedores(filtro);

            for (int i = 0; i < mProvedores.Count; i++)
            {
                dgvProvedores.RowTemplate.Height = 50;
                dgvProvedores.Rows.Add(
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
            AbrirForm(new ReporteProv());
            pictureBox1.Visible = false;
            dgvProvedores.Visible = false;
            txt_CelPA.Visible = false;
            txt_CorreoPA.Visible = false;
            txt_NomPA.Visible = false;
            btn_GPA.Visible = false;
            lbl_Reg.Visible = false;
            lbl_AltaP.Visible = false;
            lbl_CelPA.Visible = false;
            lbl_CorreoPA.Visible = false;
            lbl_NomPA.Visible = false;
            lbl_AltaP.Visible = false;
            lbl_TPA.Visible = false;
            cmbx_TPA.Visible = false;

        }
        private void AbrirForm(object Inv)
        {
            if (this.PanelAltaP.Controls.Count > 0)
            {
                this.PanelAltaP.Controls.RemoveAt(0);
            }
            Form fh = Inv as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelAltaP.Controls.Add(fh);
            this.PanelAltaP.Tag = fh;
            fh.Show();
        }

        private void PanelAltaP_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_GPA_Click(object sender, EventArgs e)
        {
            if (!datosCorrectos())
            {
                return;
            }
             cargarDatosProveedor();
            if(mProveedorConsultas.agregarProvedor(mProvedor))
            {
                MessageBox.Show("Alta Correcta");
                cargarProvedores();
                LimpiarCampos();
            }
            conexionMysql.GetClose();
        }

        private void LimpiarCampos()
        {
            txt_NomPA.Text = "";
            txt_CorreoPA.Text = "";
            txt_CelPA.Text="";
        }

        private void cargarDatosProveedor()
        {
            mProvedor.correo=txt_CorreoPA.Text.Trim();
            mProvedor.celular=txt_CelPA.Text.Trim();
            mProvedor.proveedor_name=txt_NomPA.Text.Trim();
            mProvedor.tipoP=cmbx_TPA.Text.Trim();
        }

        private bool datosCorrectos()
        {
            if (txt_NomPA.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el nombre");
                return false;
            }
            if (txt_CorreoPA.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el correo");
                return false;
            }
            if (txt_CelPA.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el celular");
                return false;
            }
            if (cmbx_TPA.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el tipo de producto");
                return false;
            }
            return true;
        }

        private void txt_CelPA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
