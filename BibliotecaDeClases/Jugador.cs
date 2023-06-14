using System;
using System.Collections.Generic;
using System.Linq;
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

        public Jugador() { }

        public Jugador(int id, string nombreJugador, int cantidadDeVictorias)
        {
            this.id = id;
            this.nombreJugador = nombreJugador;
            this.cantidadDeVictorias = cantidadDeVictorias;
            this.tiradas = new Tirada[5];
        }

        public int Id { get => id; set => id = value; }
        public string NombreJugador { get => nombreJugador; set => nombreJugador = value; }
        public int CantidadDeVictorias { get => cantidadDeVictorias; set => cantidadDeVictorias = value; }
        public Tirada[] Tiradas { get => tiradas; set => tiradas = value; }

        public void TirarDados()
        {
            for (int i = 0; i < tiradas.Length; i++)
            {
                this.tiradas[i] = Tirada.TirarDados();
            }
        }

        //public string MostrarTirada()
        //{
        //    StringBuilder sb = new StringBuilder();
        //    for (int i = 0; i < dados.Length; i++)
        //    {
        //        if (dados.Length - 1 == i)
        //        {
        //            sb.Append($"{dados[i]}");
        //        }
        //        else
        //        {
        //            sb.Append($"{dados[i]} - ");
        //        }
        //    }
        //    return sb.ToString();
        //}

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
            return j1.id == j2.id;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }


    }
}
