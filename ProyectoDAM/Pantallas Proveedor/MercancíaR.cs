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
    public partial class MercancíaR : Form
    {
        private List<PedidoC> mPedidos;
        private PedidoC mPedido;
        private PedidoConsultas mPedidoConsultas;
        private ConexionMysql conexionMysql;
        public MercancíaR()
        {
            InitializeComponent();
            mPedidos = new List<PedidoC>();
            mPedidoConsultas = new PedidoConsultas();
            mPedido = new PedidoC();
            conexionMysql = new ConexionMysql();

            cargarPedidos();
        }

        private void cargarPedidos(string filtro = "")
        {
            dgvPedidos.Rows.Clear();
            dgvPedidos.Refresh();
            mPedidos.Clear();
            mPedidos = mPedidoConsultas.GetPedidos(filtro);

            for (int i = 0; i < mPedidos.Count; i++)
            {
                dgvPedidos.RowTemplate.Height = 50;
                dgvPedidos.Rows.Add(
                    mPedidos[i].id_prov,
                    mPedidos[i].id,
                    mPedidos[i].producto,
                    mPedidos[i].unidades);
            }
            conexionMysql.GetClose();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            conexionMysql.GetClose();
            AbrirForm(new ReporteProv());
            pictureBox1.Visible = false;
            lbl_Merc.Visible = false;
            lbl_PedidoP.Visible = false;
            lbl_ProducP.Visible = false;
            lbl_ProvP.Visible = false;
            lbl_RegP.Visible = false;
            lbl_UnidadesP.Visible = false;
            txt_IdPedidoP.Visible = false;
            txt_ProducP.Visible = false;
            txt_idP.Visible = false;
            txt_UniP.Visible = false;
            txt_filtrar.Visible = false;
            txt_IdPedidoP.Visible = false;
            btn_DevP.Visible = false;
            Solicitar_P.Visible = false;
            dgvPedidos.Visible = false;
            lbl_filt.Visible = false;

        }
        private void AbrirForm(object Inv)
        {
            if (this.PanelPedido.Controls.Count > 0)
            {
                this.PanelPedido.Controls.RemoveAt(0);
            }
            Form fh = Inv as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelPedido.Controls.Add(fh);
            this.PanelPedido.Tag = fh;
            fh.Show();
        }

        private void PanelPedido_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Solicitar_P_Click(object sender, EventArgs e)
        {
            if (!datosCorrectos())
            {
                return;
            }
            cargardatosM();
            if (mPedidoConsultas.agregarPedido(mPedido))
            {
                MessageBox.Show("Pedido Exitoso");
                cargarPedidos();
                LimpiarCampos();
            }
            conexionMysql.GetClose();
        }

        private void LimpiarCampos()
        {
            txt_UniP.Text = "";
            txt_idP.Text = "";
            txt_ProducP.Text = "";
        }

        private bool datosCorrectos()
        {
            if (txt_idP.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el ID del provedor");
                return false;
            }
            if (txt_ProducP.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el producto a pedir");
                return false;
            }
            if (txt_UniP.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese las unidades a pedir");
                return false;
            }
            return true;
        }

        private void cargardatosM()
        {
            mPedido.unidades = int.Parse(txt_UniP.Text.Trim());
            mPedido.producto = txt_ProducP.Text.Trim();
            mPedido.id_prov = int.Parse(txt_idP.Text.Trim());
        }

        private void txt_filtrar_TextChanged(object sender, EventArgs e)
        {
            cargarPedidos(txt_filtrar.Text.Trim());
        }

        private void dgvPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvPedidos.Rows[e.RowIndex];
            txt_idP.Text = Convert.ToString(fila.Cells["id_prov"].Value);
            txt_IdPedidoP.Text = Convert.ToString(fila.Cells["id_pedido"].Value);
            txt_ProducP.Text = Convert.ToString(fila.Cells["producto"].Value);
            txt_UniP.Text = Convert.ToString(fila.Cells["unidades"].Value);


        }
        private int getFolioIfExists()
        {
            if (!txt_IdPedidoP.Text.Trim().Equals(""))
            {
                if (int.TryParse(txt_IdPedidoP.Text.Trim(), out int folio))
                {
                    return folio;
                }
                return -1;
            }
            else return -1;
        }

        private void btn_DevP_Click(object sender, EventArgs e)
        {
            if (getFolioIfExists() == -1)
            {
                return;
            }

            if (MessageBox.Show("¿Desea devolverve ese pedido?", "Devolver Pedido",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cargarDatos();
                if (mPedidoConsultas.eliminarPedido(mPedido))
                {
                    MessageBox.Show("Devolución Exitosa");

                    cargarPedidos();
                    LimpiarCampos();
                }
            }
            conexionMysql.GetClose();
        }

        private void cargarDatos()
        {
            mPedido.id=getFolioIfExists();
            mPedido.id_prov = int.Parse(txt_idP.Text.Trim());
            mPedido.unidades = int .Parse (txt_UniP.Text.Trim());
            mPedido.producto = txt_ProducP.Text.Trim();
        }
    }
}
