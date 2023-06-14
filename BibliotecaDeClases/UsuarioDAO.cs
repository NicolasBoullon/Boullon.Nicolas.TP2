using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class UsuarioDAO
    {
        private static SqlCommand sqlCommand;
        private static SqlConnection sqlConnection;

        static UsuarioDAO()
        {
            sqlConnection = new SqlConnection(@"Server=DESKTOP-FFMVAGM\MSSQLSERVER06 ;Database=SEGUNDO_TP_DB; Trusted_Connection=True;");
            sqlCommand = new SqlCommand();
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.Connection = sqlConnection;
        }

        public static List<Usuario> GetUsuarios()
        {
            List<Usuario> list = new List<Usuario>();
            string query = "SELECT * FROM USUARIOS";
            try
            {
                sqlConnection.Open();
                sqlCommand.CommandText = query;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    if (!sqlDataReader.IsDBNull(1) || !sqlDataReader.IsDBNull(2) || !sqlDataReader.IsDBNull(3) && !sqlDataReader.IsDBNull(4))
                    {
                        list.Add(new Usuario(sqlDataReader.GetInt32(0), sqlDataReader.GetString(1), sqlDataReader.GetString(2), sqlDataReader.GetString(3)));
                    }
                    else
                    {
                        throw new Exception("Error al leer la base de datos");
                    }
                }
                return list;
            }
            catch (Exception)
            {
                throw new Exception("No se pudo leer de la base de datos");
            }
            finally
            {
                if (sqlCommand is not null && sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }

    }
}
