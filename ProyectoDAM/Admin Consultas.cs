using MySql.Data.MySqlClient;
using ProyectoDAM.Pantallas_Proveedor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDAM
{
    internal class Admin_Consultas
    {
        private ConexionMysql conexionMysql;
        private List<Admin> mAdministradores;

        public Admin_Consultas()
        {
            conexionMysql = new ConexionMysql();
            mAdministradores = new List<Admin>();

        }

        internal bool agregarAdmin(Admin mAdmin)
        {
            string INSERT = "INSERT INTO Usuario(Nombre, Correo, Contraseña) values (@Nombre, @Correo, @Contraseña)";
            MySqlCommand mCommand = new MySqlCommand(INSERT, conexionMysql.GetConnection());
            mCommand.Parameters.Add(new MySqlParameter("@Nombre", mAdmin.name));
            mCommand.Parameters.Add(new MySqlParameter("@Correo", mAdmin.correo));
            mCommand.Parameters.Add(new MySqlParameter("@Contraseña", mAdmin.contra));
            conexionMysql.GetClose();
            return mCommand.ExecuteNonQuery() > 0;

        }

        internal bool compruebaDatos(string nombre, string pass)
        {
            MySqlDataReader mReader = null;
            string QUERY = "SELECT * FROM Usuario WHERE Nombre= '%" + nombre + "%' and Contraseña = '%" + pass + "%';";
            MySqlCommand mComando = new MySqlCommand(QUERY);
            mComando.Connection = conexionMysql.GetConnection();
            mReader = mComando.ExecuteReader();
            conexionMysql.GetClose();
            return mComando.ExecuteNonQuery() > 0;


        }
    }
}
