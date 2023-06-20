using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public static class JugadorDAO
    {
        private static SqlCommand sqlCommand;
        private static SqlConnection sqlConnection;

        static JugadorDAO()
        {
            sqlConnection = new SqlConnection(@"Server=DESKTOP-FFMVAGM\MSSQLSERVER06 ;Database=SEGUNDO_TP_DB ;Trusted_Connection=True;");
            sqlCommand = new SqlCommand();
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.Connection = sqlConnection;
        }


        public static void CrearJugador(string nombreJugador)
        {
            string query = "INSERT INTO JUGADORES VALUES (@nombreJugador, @cantidadDeVictorias)";
            if (!string.IsNullOrEmpty(nombreJugador))
            {
                try
                {
                    sqlConnection.Open();
                    sqlCommand.Parameters.Clear();
                    sqlCommand.CommandText = query;
                    sqlCommand.Parameters.AddWithValue("@nombreJugador", nombreJugador);
                    sqlCommand.Parameters.AddWithValue("@cantidadDeVictorias", 0);
                    sqlCommand.ExecuteNonQuery();
                }
                catch
                {
                    throw new Exception("No se pudo Crear el nuevo usuario");
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
        public static List<Jugador> GetJugadores()
        {
            List<Jugador> list = new List<Jugador>();
            string query = "SELECT * FROM Jugadores";
            try
            {
                sqlConnection.Open();
                sqlCommand.CommandText = query;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    if (!sqlDataReader.IsDBNull(1))
                    {
                        list.Add(new Jugador(sqlDataReader.GetInt32(0), sqlDataReader.GetString(1), sqlDataReader.GetInt32(2)));
                    }
                    else
                    {
                        throw new Exception("Error en la base de datos");
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

        public static List<Jugador> TraerRankingDeVictorias()
        {
            List<Jugador> jugadores = new List<Jugador>();
            string query = "SELECT * FROM Jugadores ORDER BY cantidadDeVictorias DESC";

            try
            {
                sqlConnection.Open();
                sqlCommand.CommandText = query;
                sqlCommand.Parameters.Clear();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    if (!sqlDataReader.IsDBNull(1))
                    {
                        jugadores.Add(new Jugador(sqlDataReader.GetInt32(0), sqlDataReader.GetString(1), sqlDataReader.GetInt32(2)));
                    }
                }
            }
            catch
            {
                throw new Exception("Ocurrio un error al consultar el ranking de victorias");
            }
            finally
            {
                if (sqlCommand is not null && sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
            return jugadores;
        }


        public static void ActualizarVictoriasJugadorDAO(Jugador jugador)
        {
            string query = "UPDATE Jugadores SET cantidadDeVictorias=@cantidadDeVictorias WHERE id=@id";
            try
            {
                sqlConnection.Open();
                sqlCommand.CommandText = query;
                sqlCommand.Parameters.Clear();
                sqlCommand.Parameters.AddWithValue("@cantidadDeVictorias", jugador.CantidadDeVictorias);
                sqlCommand.Parameters.AddWithValue("@id", jugador.Id);
                sqlCommand.ExecuteNonQuery();
            }
            catch
            {
                throw new Exception("Ocurrio un error al consultar el ranking de victorias");
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
