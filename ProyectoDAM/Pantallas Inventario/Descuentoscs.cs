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
    public partial class Descuentoscs : Form
    {
        private List<ProductoC> mProductos;
        private ProductoC mProducto;
        private ConexionMysql conexionMysql;

        private ProductoConsultas mProductoConsultas;
        public Descuentoscs()
        {
            InitializeComponent();

            mProductos = new List<ProductoC>();
            mProductoConsultas = new ProductoConsultas();
            mProducto = new ProductoC();
            conexionMysql = new ConexionMysql();

            cargarProductos();
        }
        private void cargarProductos(string filtro = "")
        {
            dgvDesc.Rows.Clear();
            dgvDesc.Refresh();
            mProductos.Clear();
            mProductos = mProductoConsultas.GetProductos(filtro);

            for (int i = 0; i < mProductos.Count; i++)
            {
                dgvDesc.RowTemplate.Height = 50;
                dgvDesc.Rows.Add(
                mProductos[i].id_produc,
                mProductos[i].name,
                mProductos[i].color,
                mProductos[i].precio);

            }
            conexionMysql.GetClose();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            AbrirForm(new MenuInv());
            lbl_desc.Visible = false;
            lbl_prod.Visible = false;
            lbl_reg.Visible = false;
            lbl_tit.Visible = false;
            txt_desc.Visible = false;
            txt_prod.Visible = false;
            btn_asig.Visible = false;
            lbl_filt.Visible = false;
            txt_filt.Visible = false;
            pictureBox1.Visible = false;
            dgvDesc.Visible = false;
        }
        private void AbrirForm(object Inv)
        {
            if (this.PanelDescR.Controls.Count > 0)
            {
                this.PanelDescR.Controls.RemoveAt(0);
            }
            Form fh = Inv as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelDescR.Controls.Add(fh);
            this.PanelDescR.Tag = fh;
            fh.Show();
        }

        private void PanelDescR_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvDesc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvDesc.Rows[e.RowIndex];
            txt_desc.Text = Convert.ToString(fila.Cells["precio"].Value);
            txt_prod.Text = Convert.ToString(fila.Cells["id_produc"].Value);
        }

        private void btn_asig_Click(object sender, EventArgs e)
        {
            if (!datosCorrectos())
            {
                return;
            }
            cargarDatos();
            if (mProductoConsultas.modificarPrecio(mProducto))
            {
                MessageBox.Show("Descuento Asignado");

                cargarProductos();
                LimpiarCampos();
            }
            conexionMysql.GetClose();
        }

        private void LimpiarCampos()
        {
            txt_desc.Text = "";
            txt_prod.Text = "";
        }

        private void cargarDatos()
        {
            mProducto.precio = int.Parse(txt_desc.Text.Trim());
            mProducto.id_produc = getFolioIfExists();

        }

        private int getFolioIfExists()
        {
            if (!txt_prod.Text.Trim().Equals(""))
            {
                if (int.TryParse(txt_prod.Text.Trim(), out int folio))
                {
                    return folio;
                }
                return -1;
            }
            else return -1;
        }

        private bool datosCorrectos()
        {
            if (txt_desc.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el cambio de precio");
                return false;
            }
            return true;
        }

        private void txt_filt_TextChanged(object sender, EventArgs e)
        {
            cargarProductos (txt_filt.Text.Trim() );
        }
    }
}
