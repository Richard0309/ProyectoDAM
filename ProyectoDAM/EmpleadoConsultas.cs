using MySql.Data.MySqlClient;
using ProyectoDAM.Pantallas_Proveedor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDAM
{
    internal class EmpleadoConsultas
    {
        private ConexionMysql conexionMysql;
        private List<EmpleadoC> mEmpleados;

        public EmpleadoConsultas()
        {
            conexionMysql = new ConexionMysql();
            mEmpleados = new List<EmpleadoC>();
        }

        public List<EmpleadoC > GetEmpleados(string filtro)
        {
            string QUERY = "SELECT * FROM Empleado ";
            MySqlDataReader mReader = null;

            try
            {
                if (filtro != "")
                {
                    QUERY += " WHERE " +
                    "Id_empleado LIKE '%" + filtro + "%' OR " +
                    "Nombre LIKE '% " + filtro + "%' OR " +
                    "Rfc LIKE '% " + filtro + "%' OR " +
                    "NSS LIKE '% " + filtro + "%' OR " +
                    "Sueldo LIKE '%" + filtro + "%' OR " +
                    "cel LIKE '%" + filtro + "%';";
                }
                MySqlCommand mComando = new MySqlCommand(QUERY);
                mComando.Connection = conexionMysql.GetConnection();
                mReader = mComando.ExecuteReader();

                EmpleadoC mEmpleadoC = null;
                while (mReader.Read())
                {
                    mEmpleadoC = new EmpleadoC();

                    mEmpleadoC.id = mReader.GetInt16("Id_empleado");
                    mEmpleadoC.nombre = mReader.GetString("Nombre");
                    mEmpleadoC.rfc = mReader.GetString("Rfc");
                    mEmpleadoC.nss = mReader.GetString("NSS");
                    mEmpleadoC.sueldo = mReader.GetFloat("Sueldo");
                    mEmpleadoC.cel = mReader.GetString("cel");
                    mEmpleados.Add(mEmpleadoC);
                
                }
                mReader.Close();
                
            }
            catch (Exception)
            {
                throw;
            
            }
           
            return mEmpleados;

        }

        internal bool agregarEmpleado(EmpleadoC mEmpleado)
        {
            string INSERT = "INSERT INTO Empleado(Nombre ,RFC, NSS, Sueldo, cel) values (@Nombre, @RFC, @NSS, @Sueldo, @cel)";
            MySqlCommand mCommand = new MySqlCommand(INSERT, conexionMysql.GetConnection());
            mCommand.Parameters.Add(new MySqlParameter("@Nombre", mEmpleado.nombre));
            mCommand.Parameters.Add(new MySqlParameter("@RFC", mEmpleado.rfc));
            mCommand.Parameters.Add(new MySqlParameter("@NSS", mEmpleado.nss));
            mCommand.Parameters.Add(new MySqlParameter("@Sueldo", mEmpleado.sueldo));
            mCommand.Parameters.Add(new MySqlParameter("@cel", mEmpleado.cel));
            return mCommand.ExecuteNonQuery() > 0;
            



        }

        internal bool eliminarEmpleado(EmpleadoC mEmpleado)
        {
            string DELETE = "DELETE FROM Empleado WHERE Id_empleado=@Id_empleado;";
            MySqlCommand mCommand = new MySqlCommand(DELETE, conexionMysql.GetConnection());
            mCommand.Parameters.Add(new MySqlParameter("@Id_empleado", mEmpleado.id));
            
            return mCommand.ExecuteNonQuery() > 0;
            
        }
    }
}
