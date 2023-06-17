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
                if (valorYCant[1] == 1)
                {
                    valorYCant[0] = 9;
                    valorYCant[1] = 9;
                }
            return valorYCant;
        }

        public static int[] ContarMismoMaximoDado(int[] tirada)//{1,1,1,3,3}
        {
            int numeroVecesRepetido = 0;
            int MayorVecesRepetido = 0;
            int[] valorYCant = new int[2];
            int bandera = 0;
            int valorDado = 0;
            //int[] repetidos = new int[tirada.Length];
            for (int i = 7; i > 0; i--)//Representa las caras de los dados
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

        
        //public static int[] MayorDadoRepetido(int[] tirada) //{1,1,1,3,3}
        //{
        //    int bandera = 0;
        //    int[] MayorVecesRepetido = new int[2] { 0, 0 };
        //    int[] vecesRepetido = new int[2];
        //    //int MenorVecesRepetido = 0;
        //    //int numRepetidos = 0;
        //    for (int i = 1; i <= 6; i++)
        //    {
        //        vecesRepetido = ContarMismoDado(i, tirada);
        //        if (bandera == 0 || vecesRepetido[0] > MayorVecesRepetido[0])
        //        {
        //            MayorVecesRepetido = vecesRepetido;
        //            bandera = 1;
        //        }
        //    }
        //    return MayorVecesRepetido;
        //}
    }
}

                //if (bandera == 0 || vecesRepetido > MayorVecesRepetido || vecesRepetido < MenorVecesRepetido)
                //{
                //    if (vecesRepetido > MayorVecesRepetido)
                //    {
                //        MayorVecesRepetido = vecesRepetido;
                //        numRepetidos[0] = MayorVecesRepetido;   
                //    }
                //    else if(vecesRepetido < MenorVecesRepetido)
                //    {
                //        MenorVecesRepetido = vecesRepetido;
                //        numRepetidos[0] = MenorVecesRepetido;
                //    }
                //    bandera = 1;
                //}