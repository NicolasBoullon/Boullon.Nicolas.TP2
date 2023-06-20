using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Jugador
    {
        private int id;
        private string nombreJugador;
        private int cantidadDeVictorias;
        private Tirada[] tiradas;
        
        public Jugador()
        {
            this.tiradas = new Tirada[10]; // cambie 10 tiradas en vez de 5
        }

        public Jugador(int id, string nombreJugador, int cantidadDeVictorias):this()
        {
            this.id = id;
            this.nombreJugador = nombreJugador;
            this.cantidadDeVictorias = cantidadDeVictorias;
        }

        public int Id { get => id; set => id = value; }
        public string NombreJugador { get => nombreJugador; set => nombreJugador = value; }
        public int CantidadDeVictorias { get => cantidadDeVictorias; set => cantidadDeVictorias = value; }
        public Tirada[] Tiradas { get => tiradas; set => tiradas = value; }

        public void HacerTirada()
        {
            for (int i = 0; i < this.tiradas.Length; i++)
            {
                Tiradas[i] = Tirada.TirarDados();
            }
        }

        public string MostrarInformacionJugador()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"El jugador: {this.nombreJugador}");
            sb.AppendLine($"Con ID: {this.id}");
            sb.AppendLine($"Total de partidas ganadas: {this.cantidadDeVictorias}");
            return sb.ToString();
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.NombreJugador == j2.NombreJugador;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }

        public static string MostrarTiradas(Jugador j1)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Tirada item in j1.tiradas)
            {
                sb.AppendLine(item.MostrarTirada());
            }
            return sb.ToString();
        }

    }
}
