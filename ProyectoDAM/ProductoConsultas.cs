using MySql.Data.MySqlClient;
using ProyectoDAM.Pantallas_Proveedor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDAM
{
    internal class ProductoConsultas
    {
        private ConexionMysql conexionMysql;
        private List<ProductoC> mProductos;

        public ProductoConsultas()
        {
            conexionMysql = new ConexionMysql();
            mProductos = new List<ProductoC>();
        }

        

        internal List<ProductoC> GetProductos(string filtro)
        {
            string QUERY = "SELECT * FROM Producto ";
            MySqlDataReader mReader = null;

            try 
            {
                if (filtro != "")
                {
                    QUERY += " WHERE " +
                    "Id_producto LIKE '%" + filtro + "%' OR " +
                    "Id_provedor LIKE '%" + filtro + "%' OR " +
                    "Nombre LIKE '% " + filtro + "%' OR " +
                    "Color LIKE '% " + filtro + "%' OR " +
                    "Mat_fab LIKE '% " + filtro + "%' OR " +
                    "precio LIKE '% " + filtro + "%' OR " +
                    "Marca LIKE '% " + filtro + "%' OR " +
                    "Tipo LIKE '% " + filtro + "%' OR " +
                    "Conexion LIKE '% " + filtro + "%' OR " +
                    "Descripcion LIKE '% " + filtro + "%';";

                }
                MySqlCommand mComando = new MySqlCommand(QUERY);
                mComando.Connection = conexionMysql.GetConnection();
                mReader = mComando.ExecuteReader();

                ProductoC mProductoC = null;
                while (mReader.Read())
                {
                    mProductoC = new ProductoC();
                    mProductoC.id_produc = mReader.GetInt16("Id_producto");
                    mProductoC.id_prov = mReader.GetInt16("Id_provedor");
                    mProductoC.name = mReader.GetString("Nombre");
                    mProductoC.color = mReader.GetString("Color");
                    mProductoC.m_f = mReader.GetString("Mat_fab");
                    mProductoC.precio = mReader.GetInt16("precio");
                    mProductoC.marca = mReader.GetString("Marca");
                    mProductoC.tipo = mReader.GetString("Tipo");
                    mProductoC.conec = mReader.GetString("Conexion");
                    mProductos.Add(mProductoC);
                }
                mReader.Close();
                

            }
            catch (Exception)
            {
                throw;
            }
            
            return mProductos;
        }
        internal bool agregarProducto(ProductoC mProducto)
        {
            string INSERT = "INSERT INTO Producto(Id_provedor ,Nombre, Color, Mat_fab, precio, Marca, Tipo, Conexion) values (@Id_provedor, @Nombre, @Color, @Mat_fab, @precio, @Marca, @Tipo, @Conexion)";
            MySqlCommand mCommand = new MySqlCommand(INSERT, conexionMysql.GetConnection());
            mCommand.Parameters.Add(new MySqlParameter("@Id_provedor", mProducto.id_prov));
            mCommand.Parameters.Add(new MySqlParameter("@Nombre", mProducto.name));
            mCommand.Parameters.Add(new MySqlParameter("@Color", mProducto.color));
            mCommand.Parameters.Add(new MySqlParameter("@Mat_fab", mProducto.m_f));
            mCommand.Parameters.Add(new MySqlParameter("@precio", mProducto.precio));
            mCommand.Parameters.Add(new MySqlParameter("@Marca", mProducto.marca));
            mCommand.Parameters.Add(new MySqlParameter("@Tipo", mProducto.tipo));
            mCommand.Parameters.Add(new MySqlParameter("@Conexion", mProducto.conec));
            
            return mCommand.ExecuteNonQuery() > 0;


        }

        internal bool modificarPrecio(ProductoC mProducto)
        {
            string UPDATE = "UPDATE Producto SET " +
                "precio=@precio " +
                "WHERE Id_producto = @Id_producto;";
            MySqlCommand mCommand = new MySqlCommand(UPDATE, conexionMysql.GetConnection());
            mCommand.Parameters.Add(new MySqlParameter("@precio", mProducto.precio));
            mCommand.Parameters.Add(new MySqlParameter("@Id_producto", mProducto.id_produc));
            
            return mCommand.ExecuteNonQuery() > 0;
        }

        internal bool eliminarProducto(ProductoC mProducto)
        {
            string DELETE = "DELETE FROM Producto WHERE Id_producto=@Id_producto;";
            MySqlCommand mCommand = new MySqlCommand(DELETE, conexionMysql.GetConnection());
            mCommand.Parameters.Add(new MySqlParameter("@Id_producto", mProducto.id_produc));
          
            return mCommand.ExecuteNonQuery() > 0;
        }
    }
}
