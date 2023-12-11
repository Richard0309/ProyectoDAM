using MySql.Data.MySqlClient;
using ProyectoDAM.Pantallas_Proveedor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDAM
{
    internal class ProveedorConsultas
    {
        private ConexionMysql conexionMysql;
        private List<ProveedorC> mProvedores;

        public ProveedorConsultas()
        {
            conexionMysql = new ConexionMysql();
            mProvedores = new List<ProveedorC>();
        }

        public List<ProveedorC> getProvedores(string filtro)
        {
            string QUERY = "SELECT * FROM Provedor ";
            MySqlDataReader mReader = null;
            try
            {
                if (filtro != "")
                {
                    QUERY += "WHERE " +
                    "Id_provedor LIKE '% " + filtro + "%' OR " +
                    "Nombre LIKE '% " + filtro + "%' OR " +
                    "Cel LIKE '% " + filtro + "%´ OR " +
                    "TipoP LIKE '% " + filtro + "%' OR " +
                    "Correo LIKE '% " + filtro + "%';";


                }
                MySqlCommand mComando = new MySqlCommand(QUERY);
                mComando.Connection = conexionMysql.GetConnection();
                mReader = mComando.ExecuteReader();

                ProveedorC mProveedorC = null;
                while (mReader.Read())
                {
                    mProveedorC = new ProveedorC();
                    mProveedorC.id_prov = mReader.GetInt16("Id_provedor");
                    mProveedorC.proveedor_name = mReader.GetString("Nombre");
                    mProveedorC.celular = mReader.GetString("Cel");
                    mProveedorC.tipoP = mReader.GetString("TipoP");
                    mProveedorC.correo = mReader.GetString("Correo");
                    mProvedores.Add(mProveedorC);

                }
                mReader.Close();
                
            }
            catch (Exception)
            {
                throw;
            }

            
            return mProvedores;

        }

        internal bool agregarProvedor(ProveedorC mProvedor)
        {
            string INSERT = "INSERT INTO Provedor(Nombre ,Cel, TipoP, Correo) values (@Nombre, @Cel, @TipoP, @Correo)";

            MySqlCommand mCommand = new MySqlCommand(INSERT, conexionMysql.GetConnection());
            mCommand.Parameters.Add(new MySqlParameter("@Nombre",mProvedor.proveedor_name));
            mCommand.Parameters.Add(new MySqlParameter("@Cel", mProvedor.celular));
            mCommand.Parameters.Add(new MySqlParameter("@TipoP", mProvedor.tipoP));
            mCommand.Parameters.Add(new MySqlParameter("@Correo", mProvedor.correo));
            
            return mCommand.ExecuteNonQuery()>0;

        }

        internal bool eliminarProvedor(ProveedorC mProvedor)
        {
            string DELETE = "DELETE FROM Provedor WHERE Id_provedor=@Id_provedor;";
            MySqlCommand mCommand = new MySqlCommand(DELETE, conexionMysql.GetConnection());
            mCommand.Parameters.Add(new MySqlParameter("@Id_provedor", mProvedor.id_prov));
           
            return mCommand.ExecuteNonQuery() > 0;
        }
    }
}
