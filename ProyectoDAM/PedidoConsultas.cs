using MySql.Data.MySqlClient;
using ProyectoDAM.Pantallas_Proveedor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDAM
{
    internal class PedidoConsultas
    {
        private ConexionMysql conexionMysql;
        private List<PedidoC> mPedidos;

        public PedidoConsultas()
        {
            conexionMysql = new ConexionMysql();
            mPedidos = new List<PedidoC>();
        }

        public List<PedidoC> GetPedidos(string filtro)
        {
            string QUERY = "SELECT * FROM pedido ";
            MySqlDataReader mReader = null;

            try
            {
                if(filtro != "")
                {
                    QUERY += " WHERE " +
                    "Id_provedor LIKE '% " + filtro + "%' OR " +
                    "Id_pedido LIKE '% " + filtro + "%' OR " +
                    "Producto LIKE '% " + filtro + "%' OR " +
                    "unidades LIKE'% " + filtro + "%';";
                }
                MySqlCommand mComando = new MySqlCommand(QUERY);
                mComando.Connection = conexionMysql.GetConnection();
                mReader = mComando.ExecuteReader();

                PedidoC mPedidoC = null;
                while (mReader.Read())
                {
                    mPedidoC = new PedidoC();
                    mPedidoC.id_prov = mReader.GetInt16("Id_provedor");
                    mPedidoC.id = mReader.GetInt16("Id_pedido");
                    mPedidoC.producto = mReader.GetString("Producto");
                    mPedidoC.unidades = mReader.GetInt16("unidades");
                    mPedidos.Add(mPedidoC);
                }
                
                conexionMysql.GetClose();

            }
            catch (Exception)
            {
                throw;
            }
            return mPedidos;
        }

        internal bool agregarPedido(PedidoC mPedido)
        {
            string INSERT = "INSERT INTO pedido(Id_provedor, Producto, unidades) values (@Id_provedor, @Producto, @unidades)";
            MySqlCommand mCommand = new MySqlCommand(INSERT, conexionMysql.GetConnection());
            mCommand.Parameters.Add(new MySqlParameter("@Id_provedor", mPedido.id_prov));
            mCommand.Parameters.Add(new MySqlParameter("@Producto", mPedido.producto));
            mCommand.Parameters.Add(new MySqlParameter("@unidades", mPedido.unidades));
            
            return mCommand.ExecuteNonQuery() > 0;



        }

        internal bool eliminarPedido(PedidoC mPedido)
        {
            string DELETE = "DELETE FROM pedido WHERE Id_pedido=@Id_pedido;";
            MySqlCommand mCommand = new MySqlCommand(DELETE, conexionMysql.GetConnection());
            mCommand.Parameters.Add(new MySqlParameter("@Id_pedido", mPedido.id));
            
            return mCommand.ExecuteNonQuery() > 0;
        }
    }
}
