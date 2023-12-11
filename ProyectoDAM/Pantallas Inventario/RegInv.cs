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
    public partial class RegInv : Form
    {
        private ProductoC mProducto;
        private ProductoConsultas mProductoConsultas;
        private ConexionMysql conexionMysql;
        public RegInv()
        {
            InitializeComponent();

            mProducto = new ProductoC();
            mProductoConsultas = new ProductoConsultas();
            conexionMysql = new ConexionMysql();
        }

        private void lbl_regP_Click(object sender, EventArgs e)
        {
            conexionMysql.GetClose();
            AbrirForm(new MenuInv());
            lbl_regP.Visible = false;
            lbl_colorp.Visible = false;
            lbl_conp.Visible = false;
            lbl_marcap.Visible = false;
            lbl_matp.Visible = false;
            lbl_nomp.Visible = false;
            lbl_provp.Visible = false;
            lbl_regP.Visible = false;
            lbl_stockp.Visible = false;
            lbl_tipop.Visible = false;
            lbl_precio.Visible = false;
            lbl_conec.Visible = false;
            button1.Visible = false;
            lbl_tituloRegIn.Visible = false;
            cmbx_tipoP.Visible = false;
            txt_coloP.Visible = false;
            txt_conec_p.Visible = false;
            txt_marcaP.Visible = false;
            txt_mat_P.Visible = false;
            txt_precio.Visible=false;
            txt_nomP.Visible = false;
            txt_idP.Visible = false;
            txt_sotckP.Visible = false;
            PanelTipo.Visible = false;
            pictureBox3.Visible = false;
            btn_guar.Visible = false;

        }
        private void AbrirForm(object Inv)
        {
            if (this.PanelRegIn.Controls.Count > 0)
            {
                this.PanelRegIn.Controls.RemoveAt(0);
            }
            Form fh = Inv as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelRegIn.Controls.Add(fh);
            this.PanelRegIn.Tag = fh;
            fh.Show();
        }
        private void AbrirForm2(object Inv)
        {
            if (this.PanelTipo.Controls.Count > 0)
            {
                this.PanelTipo.Controls.RemoveAt(0);
            }
            Form fh = Inv as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelTipo.Controls.Add(fh);
            this.PanelTipo.Tag = fh;
            fh.Show();
        }

        private void PanelTipo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbx_tipoP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbx_tipoP.SelectedIndex == 0)
            {

                //AbrirForm2(new TipoP());

            }
            else
            {
                if (cmbx_tipoP.SelectedIndex == 1)
                {
                    //AbrirForm2(new TipoC());
                }
                else
                {
                    if (cmbx_tipoP.SelectedIndex == 2)
                    {
                        //AbrirForm2(new TipoD());
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexionMysql.GetClose();
            AbrirForm(new ReporteInvcs());
            lbl_regP.Visible = false;
            lbl_colorp.Visible = false;
            lbl_conp.Visible = false;
            lbl_marcap.Visible = false;
            lbl_matp.Visible = false;
            lbl_nomp.Visible = false;
            lbl_provp.Visible = false;
            lbl_regP.Visible = false;
            lbl_stockp.Visible = false;
            lbl_tipop.Visible = false;
            lbl_tituloRegIn.Visible = false;
            lbl_precio.Visible = false;
            cmbx_tipoP.Visible = false;
            txt_coloP.Visible = false;
            txt_conec_p.Visible = false;
            txt_marcaP.Visible = false;
            txt_mat_P.Visible = false;
            txt_nomP.Visible = false;
            txt_idP.Visible = false;
            txt_sotckP.Visible = false;
            txt_precio.Visible = false;
            PanelTipo.Visible = false;
            pictureBox3.Visible = false;
            btn_guar.Visible = false;
            button1.Visible = false;
            lbl_conec.Visible = false;
            button1.Visible = false;
        }

        private void btn_guar_Click(object sender, EventArgs e)
        {
            if (!datosCorrectos())
            {
                return;
            }
            cargarDatos();
            if (mProductoConsultas.agregarProducto(mProducto))
            {
                MessageBox.Show("Alta Correcta");

                LimpiarCampos();
            }
            conexionMysql.GetClose();

        }

        private void LimpiarCampos()
        {
            txt_coloP.Text = "";
            txt_nomP.Text = "";
            txt_mat_P.Text = "";
            txt_marcaP.Text = "";
            txt_sotckP.Text = "";
            txt_idP.Text = "";
            txt_conec_p.Text = "";
            txt_precio.Text = "";

        }

        private void cargarDatos()
        {
            mProducto.id_prov = int.Parse(txt_idP.Text.Trim());
            mProducto.marca = txt_marcaP.Text.Trim();
            mProducto.m_f = txt_mat_P.Text.Trim();
            mProducto.conec = txt_conec_p.Text.Trim();
            mProducto.color = txt_coloP.Text.Trim();
            mProducto.name = txt_nomP.Text.Trim();
            mProducto.stock = int.Parse(txt_sotckP.Text.Trim());
            mProducto.tipo= cmbx_tipoP.Text.Trim();
            mProducto.precio= int.Parse(txt_precio.Text.Trim());

        }

        private bool datosCorrectos()
        {
            if (txt_nomP.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el nombre del producto");
                return false;
            }
            if (txt_coloP.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el color del producto");
                return false;
            }
            if (txt_idP.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el ID del Proveedor");
                return false;
            }
            if (txt_mat_P.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese los materiales de fabricación del producto");
                return false;
            }
            if (txt_sotckP.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el stock del producto");
                return false;
            }
            if (txt_marcaP.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese la marca del producto");
                return false;
            }
            if (txt_conec_p.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese la conexión del producto");
                return false;
            }
            if (txt_precio.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el Precio del Producto");
                return false;
            }
            if (txt_precio.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el Tipo del Producto");
                return false;
            }
            return true;

        }

        private void PanelRegIn_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
