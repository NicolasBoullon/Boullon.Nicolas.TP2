using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Partida
    {
        private string jugadorUno;
        private string jugadorDos;
        private int cantidadPuntosJugadorUno;
        private int cantidadPuntosJugadorDos;
        private string jugadorGanador;
        private DateTime horaJugada;

        public Partida(string jugadorUno, string jugadorDos, int cantidadPuntosJugadorUno, int cantidadPuntosJugadorDos, string jugadorGanador, DateTime horaJugada)
        {
            this.jugadorUno = jugadorUno;
            this.jugadorDos = jugadorDos;
            this.cantidadPuntosJugadorUno = cantidadPuntosJugadorUno;
            this.cantidadPuntosJugadorDos = cantidadPuntosJugadorDos;
            this.jugadorGanador = jugadorGanador;
            this.horaJugada = horaJugada;
        }

        public string JugadorUno { get => jugadorUno; set => jugadorUno = value; }
        public string JugadorDos { get => jugadorDos; set => jugadorDos = value; }
        public int CantidadPuntosJugadorUno { get => cantidadPuntosJugadorUno; set => cantidadPuntosJugadorUno = value; }
        public int CantidadPuntosJugadorDos { get => cantidadPuntosJugadorDos; set => cantidadPuntosJugadorDos = value; }
        public string JugadorGanador { get => jugadorGanador; set => jugadorGanador = value; }
        public DateTime HoraJugada { get => horaJugada; set => horaJugada = value; }
    }
}
