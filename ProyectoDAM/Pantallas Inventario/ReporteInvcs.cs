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
    public partial class ReporteInvcs : Form
    {
        private List<ProductoC> mProductos;
        private ProductoC mProducto;
        private ProductoConsultas mProductoConsultas;
        private ConexionMysql conexionMysql;

        public ReporteInvcs()
        {
            InitializeComponent();

            mProductos = new List<ProductoC>();
            mProducto = new ProductoC();
            mProductoConsultas = new ProductoConsultas();
            conexionMysql = new ConexionMysql();

            cargarProductos();
        }

        private void cargarProductos(string filtro = "")
        {
            dgvProductos.Rows.Clear();
            dgvProductos.Refresh();
            mProductos.Clear();
            mProductos = mProductoConsultas.GetProductos(filtro);

            for (int i = 0; i < mProductos.Count; i++)
            {
                dgvProductos.RowTemplate.Height = 50;
                dgvProductos.Rows.Add(
                mProductos[i].id_produc,
                mProductos[i].id_prov,
                mProductos[i].name,
                mProductos[i].color,
                mProductos[i].m_f,
                mProductos[i].precio,
                mProductos[i].marca,
                mProductos[i].tipo,
                mProductos[i].conec);

            }
            conexionMysql.GetClose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            conexionMysql.GetClose();
            AbrirForm(new MenuInv());
            pictureBox1.Visible = false;
            dgvProductos.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            lbl_filt.Visible = false;
            txt_filt.Visible = false;
            txt_Id.Visible = false;
            lbl_ID.Visible = false;
            btn_borrar.Visible = false;
        }
        private void AbrirForm(object Inv)
        {
            if (this.PanelInventario.Controls.Count > 0)
            {
                this.PanelInventario.Controls.RemoveAt(0);
            }
            Form fh = Inv as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelInventario.Controls.Add(fh);
            this.PanelInventario.Tag = fh;
            fh.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (getFolioIfExists() == -1)
            {
                return;
            }

            if (MessageBox.Show("¿Desea borrar este producto?", "Borrar Producto",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cargarDatos();
                if (mProductoConsultas.eliminarProducto(mProducto))
                {
                    MessageBox.Show("Producto Borrado");

                    cargarProductos();
                    LimpiarCampos();
                }
            }
            conexionMysql.GetClose();
        }

        private void LimpiarCampos()
        {
            txt_Id.Text = "";
        }

        private void cargarDatos()
        {
            mProducto.id_produc = getFolioIfExists();
        }

        private int getFolioIfExists()
        {
            if (!txt_Id.Text.Trim().Equals(""))
            {
                if (int.TryParse(txt_Id.Text.Trim(), out int folio))
                {
                    return folio;
                }
                return -1;
            }
            else return -1;
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];
            txt_Id.Text = Convert.ToString(fila.Cells["id_product"].Value);
        }

        private void txt_filt_TextChanged(object sender, EventArgs e)
        {
            cargarProductos(txt_filt.Text.Trim());
        }

        private void btn_Agrega_Click(object sender, EventArgs e)
        {
            conexionMysql.GetClose();
            AbrirForm(new RegInv());
            pictureBox1.Visible = false;
            dgvProductos.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            lbl_filt.Visible = false;
            txt_filt.Visible = false;
            txt_Id.Visible = false;
            lbl_ID.Visible = false;
            btn_borrar.Visible = false;
            
        }
        

        private void PanelInventario_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
