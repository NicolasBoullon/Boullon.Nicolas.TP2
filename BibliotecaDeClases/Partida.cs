using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Partida
    {
        private string jugadorGanador;
        private string jugadorPerdedor;
        private int cantidadPuntosJugadorUno;
        private int cantidadPuntosJugadorDos;
        private DateTime horaJugada;

        public Partida(string jugadorGanador, string jugadorPerdedor, int cantidadPuntosJugadorUno, int cantidadPuntosJugadorDos, DateTime horaJugada)
        {
            this.jugadorGanador = jugadorGanador;
            this.jugadorPerdedor = jugadorPerdedor;
            this.cantidadPuntosJugadorUno = cantidadPuntosJugadorUno;
            this.cantidadPuntosJugadorDos = cantidadPuntosJugadorDos;
            this.horaJugada = horaJugada;
        }

        public string JugadorGanador { get => jugadorGanador; set => jugadorGanador = value; }
        public string JugadorPerdedor { get => jugadorPerdedor; set => jugadorPerdedor = value; }
        public int CantidadPuntosJugadorUno { get => cantidadPuntosJugadorUno; set => cantidadPuntosJugadorUno = value; }
        public int CantidadPuntosJugadorDos { get => cantidadPuntosJugadorDos; set => cantidadPuntosJugadorDos = value; }
        public DateTime HoraJugada { get => horaJugada; set => horaJugada = value; }


        public static bool EsEscalera(int[] tirada)
        {
            if((tirada.Contains(1) || tirada.Contains(6)) && tirada.Contains(2) && tirada.Contains(3) && 
                tirada.Contains(4) && tirada.Contains(5))
            {
                return true;
            }

            return false;
        }

        public static bool EsFull(int[] tirada)
        {
            bool hayTres = false;
            bool hayDos = false;
            int contador = 0;
            bool esFull = false;
            
                for (int i = 0; i < tirada.Length; i++)
                {
                    contador = 0;
                    for (int j = 0; j < tirada.Length; j++)
                    {
                        if (tirada[i] == tirada[j])
                        {
                            contador++;
                        }
                    }
                    if (contador == 3)
                    {
                    hayTres = true;
                    }
                    else if (contador == 2)
                    {
                    hayDos = true;
                    }
                }
                if (hayTres && hayDos)
                {
                    esFull = true;
                }
            
            return esFull;
        }

        public static bool EsPoker(int[] tirada)
        {
            int contador = 0;
            bool esPoker = false;
            for (int i = 0; i < tirada.Length; i++)
            {
                contador = 0;
                for (int j = 0; j < tirada.Length; j++)
                {
                    if (tirada[i] == tirada[j])
                    {
                        contador++;
                    }
                }
            }

            if (contador == 4)
            {
                esPoker = true;
            }

            return esPoker;
        }

        public static bool EsGenerala(int[] tirada)
        {
            int contador = 0;
            bool esGenerala = false;
            for (int i = 0; i < tirada.Length; i++)
            {
                contador = 0;
                for (int j = 0; j < tirada.Length; j++)
                {
                    if (tirada[i] == tirada[j])
                    {
                        contador++;
                    }
                }
            }

            if (contador == 5)
            {
                esGenerala = true;
            }

            return esGenerala;

        }

        public static int[] ContarMismoMinimoDado(int[] tirada)//{1,1,1,3,3}
        {
            int numeroVecesRepetido = 0;
            int MayorVecesRepetido = 0;
            int[] valorYCant = new int[2];    
            int bandera = 0;
            int valorDado = 0;
            //int[] repetidos = new int[tirada.Length];
            for (int i = 1; i < 7; i++)//Representa las caras de los dados
            {
                numeroVecesRepetido = 0;
                for (int j = 0; j < tirada.Length; j++)
                {
                    if (tirada[j] == i)
                    {
                        numeroVecesRepetido++;
                        valorDado = tirada[j];
                    }
                }

                if (bandera == 0 || numeroVecesRepetido > MayorVecesRepetido)
                {
                    MayorVecesRepetido = numeroVecesRepetido;
                    valorYCant[0] = valorDado;
                    valorYCant[1] = numeroVecesRepetido;
                    bandera = 1;
                }
            }
            return valorYCant;
        }

    }
}