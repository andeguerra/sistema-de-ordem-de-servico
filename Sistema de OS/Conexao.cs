using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_OS
{
    internal class Conexao
    {
        public static MySqlConnection conn;
        public static bool Conectar()
        {
            string Servidor = "localhost";
            string Usuario = "root";
            string Senha = "";
            string BaseDados = "northwindbn23";
            string MySQL =
                string.Format("server={0};database={1};uid={2};pwd={3}",
                    Servidor, BaseDados, Usuario, Senha);
            try
            {
                if (conn == null)
                {
                    conn = new MySqlConnection(MySQL);
                    conn.Open();
                }
                else
                {
                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public static void Desconectar()
        {
            conn.Close();
        }
    }
}
