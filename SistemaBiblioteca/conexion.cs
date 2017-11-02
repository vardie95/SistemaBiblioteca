using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca
{
    class Conexion
    {
        private MySqlConnection con;
        private MySqlCommand command;
        private MySqlDataReader reader;

        public Conexion(string pConexion)
        {
            con = new MySqlConnection(pConexion);
            command = new MySqlCommand();
            command.Connection = con;
        }

        public Boolean Abrir()
        {
            try
            {
                con.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Boolean Cerrar()
        {
            try
            {
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Boolean CargarQuery(String pQuery)
        {
            try
            {
                command.CommandText = pQuery;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IDataReader GetSalida()
        {
            reader = command.ExecuteReader();
            return reader;

        }
    }
}
