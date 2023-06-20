using BibliotecaDeClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmDesign
{
    public partial class FormPartida : Form
    {
        public Jugador j1;
        public Jugador j2;
        public CancellationToken cancellationToken;
        public CancellationTokenSource cancellationSource;
        List<Jugador> listJugadores;
        public FormPartida(Jugador jug1, Jugador jug2)
        {
            InitializeComponent();
            listJugadores = SerializadorJson<List<Jugador>>.DeserializarJsonJugador<List<Jugador>>("jugador.json");
            j1 = listJugadores[0];
            j2 = listJugadores[1];
            this.cancellationSource = new CancellationTokenSource();
            this.cancellationToken = this.cancellationSource.Token;
            gpbJugadorUno.Text = j1.NombreJugador;
            gpbJugadorDos.Text = j2.NombreJugador;
           
           
        }

        private async void FormPartida_Load(object sender, EventArgs e)
        {

            //int puntosUno = 0;
            //int puntosDos = 0;
            //int puntosGanador = 0;
            //int puntosPerdedor = 0;
            //bool empate = false;
            //Jugador j1 = new Jugador();
            //Jugador j2 = new Jugador();
            JugarPartida(j1, j2);//iniciamiento de partideishon

            await Task.Delay(8000);
            //string ganador = "";
            //string perdedor = "";
            //puntosUno = PuntosTotalesJugadorUno();
            //puntosDos = PuntosTotalesJugadorDos();
            //bool bandera = false;
            //int puntosUno = 0;
            //int puntosDos = 0;
            //int puntosGanador = 0;
            //int puntosPerdedor = 0;
            //bool empate = false;
            //string ganador = "";
            //string perdedor = "";
            //puntosUno = PuntosTotalesJugadorUno();
            //puntosDos = PuntosTotalesJugadorDos();
            //bool bandera = false;
            //if (puntosUno > puntosDos)
            //{
            //    ganador = j1.NombreJugador;
            //    perdedor = j2.NombreJugador;
            //    puntosGanador = puntosUno;
            //    puntosPerdedor = puntosDos;
            //    bandera = true;
            //}
            //else if (puntosUno < puntosDos)
            //{
            //    ganador = j2.NombreJugador;
            //    perdedor = j1.NombreJugador;
            //    puntosGanador = puntosDos;
            //    puntosPerdedor = puntosUno;
            //    bandera = true;
            //}
            //else
            //{
            //    empate = true;
            //    bandera = true;
            //}

            //Task.Run(() => { abrirFormGanador(ganador, perdedor, puntosGanador, puntosPerdedor, empate); });


        }

        private void abrirFormGanador(string ganador, string perdedor, int puntosGanador, int puntosPerdedor, bool empate)
        {

            FormGanador frmGanador = new FormGanador(ganador, perdedor, puntosGanador, puntosPerdedor, empate);
            frmGanador.ShowDialog();
        }
        private async void JugarPartida(Jugador j1, Jugador j2)
        {

            j1.HacerTirada();
            j2.HacerTirada();
            bool bandera = false;
            for (int i = 0; i < j1.Tiradas.Length; i++)//---- cambie 5 por lenght
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    bandera=true;
                    break;
                }
                lstJ1.Items.Add(j1.Tiradas[i].MostrarTirada());
                //await Task.Delay(200);
                lstJ2.Items.Add(j2.Tiradas[i].MostrarTirada());
                await Task.Delay(500);
                //Task.Delay(1000);
            }
            //await Task.Delay(2000);
            if (!bandera)
            {
                CalcularPuntos();
            }

            if (!bandera)
            {
                int puntosUno = 0;
                int puntosDos = 0;
                int puntosGanador = 0;
                int puntosPerdedor = 0;
                bool empate = false;
                string ganador = "";
                string perdedor = "";
                puntosUno = PuntosTotalesJugadorUno();
                puntosDos = PuntosTotalesJugadorDos();
                bool banderaGanador = false;
                if (puntosUno > puntosDos)
                {
                    ganador = j1.NombreJugador;
                    perdedor = j2.NombreJugador;
                    puntosGanador = puntosUno;
                    puntosPerdedor = puntosDos;
                    banderaGanador = true;
                    j1.CantidadDeVictorias++;
                    JugadorDAO.ActualizarVictoriasJugadorDAO(j1);
                }
                else if (puntosUno < puntosDos)
                {
                    ganador = j2.NombreJugador;
                    perdedor = j1.NombreJugador;
                    puntosGanador = puntosDos;
                    puntosPerdedor = puntosUno;
                    banderaGanador = true;
                    j2.CantidadDeVictorias++;
                    JugadorDAO.ActualizarVictoriasJugadorDAO(j2);
                }
                else
                {
                    empate = true;
                    banderaGanador = true;
                }

                Task.Run(() => { abrirFormGanador(ganador, perdedor, puntosGanador, puntosPerdedor, empate); });
            }

        }

        private int CalcularPuntos()
        {
            //int puntosTotales = 0;
            foreach (Tirada item in j1.Tiradas)
            {
                if (Partida.EsEscalera(item.tiradaDados))
                {
                    lblJ1ModificarEsc.Text = "20";
                    lblJ1ModificarEsc.Enabled = false;
                    continue;

                }
                else if (Partida.EsFull(item.TiradaDados))
                {
                    lblJ1ModificarFull.Text = "30";
                    lblJ1ModificarFull.Enabled = false;
                    continue;
                }
                else if (Partida.EsPoker(item.TiradaDados))
                {
                    lblJ1ModificarPoker.Text = "40";
                    lblJ1ModificarPoker.Enabled = false;
                    continue;
                }
                else if (Partida.EsGenerala(item.TiradaDados))
                {
                    lblJ1ModificarGenerala.Text = "50";
                    lblJ1ModificarGenerala.Enabled = false;
                    continue;
                }
                else
                {
                    //foreach (Tirada t in j1.Tiradas)
                    //{
                    int[] valorYcantMinimo = (Partida.ContarMismoMinimoDado(item.TiradaDados));//saque la T
                                                                                               //int[] valorYcantMaximo = (Partida.ContarMismoMaximoDado(item.TiradaDados));
                    int resultado = valorYcantMinimo[0] * valorYcantMinimo[1];
                    int valorAModificarDelLbl = 0;
                    Array.Sort(item.TiradaDados);
                    //Array.Reverse(item.TiradaDados);
                    //-------------------
                    int cantidadDados = 0;
                    if (ValidarEnabledJ1(valorYcantMinimo[0]))
                    {
                        valorAModificarDelLbl = valorYcantMinimo[0];

                    }
                    else
                    {
                        for (int i = 0; i < item.tiradaDados.Length; i++) //--cambie 5 por lenght
                        {
                            if (ValidarEnabledJ1(item.TiradaDados[i]))
                            {
                                foreach (int dado in item.TiradaDados)
                                {
                                    if (dado == item.TiradaDados[i])
                                    {
                                        cantidadDados++;
                                    }
                                }
                                valorAModificarDelLbl = item.TiradaDados[i];
                                resultado = cantidadDados * item.TiradaDados[i];
                                break;
                            }
                        }
                    }



                    switch (valorAModificarDelLbl)
                    {

                        case 0:
                            break;
                        case 1:
                            lblJ1Modificar1.Text = resultado.ToString();
                            lblJ1Modificar1.Enabled = false;
                            break;

                        case 2:
                            lblJ1Modificar2.Text = resultado.ToString();
                            lblJ1Modificar2.Enabled = false;
                            break;

                        case 3:
                            lblJ1Modificar3.Text = resultado.ToString();
                            lblJ1Modificar3.Enabled = false;
                            break;

                        case 4:
                            if (lblJ1Modificar4.Enabled)
                                lblJ1Modificar4.Text = resultado.ToString();
                            lblJ1Modificar4.Enabled = false;
                            break;

                        case 5:
                            lblJ1Modificar5.Text = resultado.ToString();
                            lblJ1Modificar5.Enabled = false;
                            break;

                        case 6:
                            lblJ1Modificar6.Text = resultado.ToString();
                            lblJ1Modificar6.Enabled = false;
                            break;
                    }
                    //}
                }
            }
            //EVALUA TIRADAS DE JUGADOR 2
            foreach (Tirada item in j2.Tiradas)
            {
                if (Partida.EsEscalera(item.tiradaDados))
                {
                    lblJ2ModificarEsc.Text = "20";
                    lblJ2ModificarEsc.Enabled = false;
                    continue;
                }
                else if (Partida.EsFull(item.TiradaDados))
                {
                    lblJ2ModificarFull.Text = "30";
                    lblJ2ModificarFull.Enabled = false;
                    continue;
                }
                else if (Partida.EsPoker(item.TiradaDados))
                {
                    lblJ2ModificarPoker.Text = "40";
                    lblJ2ModificarPoker.Enabled = false;
                    continue;
                }
                else if (Partida.EsGenerala(item.TiradaDados))
                {
                    lblJ2ModificarGenerala.Text = "50";
                    lblJ2ModificarGenerala.Enabled = false;
                    continue;
                }
                else
                {
                    int[] valorYcantMinimo = (Partida.ContarMismoMinimoDado(item.TiradaDados));//saque la T
                    //int[] valorYcantMaximo = (Partida.ContarMismoMaximoDado(item.TiradaDados));
                    int resultado = valorYcantMinimo[0] * valorYcantMinimo[1];
                    int valorAModificarDelLbl = 0;
                    Array.Sort(item.TiradaDados);
                    //Array.Reverse(item.TiradaDados);
                    //-------------------
                    int cantidadDados = 0;
                    if (ValidarEnabledJ2(valorYcantMinimo[0]))//Evaluo si el numero que mas se repite esta en uso o no
                    {
                        valorAModificarDelLbl = valorYcantMinimo[0];
                    }
                    else
                    {
                        for (int i = 0; i < item.tiradaDados.Length; i++) // --- cambie 5 por lenght
                        {
                            if (ValidarEnabledJ2(item.TiradaDados[i]))
                            {
                                foreach (int dado in item.TiradaDados)
                                {
                                    if (dado == item.TiradaDados[i])
                                    {
                                        cantidadDados++;
                                    }
                                }
                                valorAModificarDelLbl = item.TiradaDados[i];
                                resultado = cantidadDados * item.TiradaDados[i];
                                break;
                            }
                        }
                    }


                    switch (valorAModificarDelLbl)
                    {
                        case 0:
                            break;
                        case 1:
                            lblJ2Modificar1.Text = resultado.ToString();
                            lblJ2Modificar1.Enabled = false;
                            break;

                        case 2:
                            lblJ2Modificar2.Text = resultado.ToString();
                            lblJ2Modificar2.Enabled = false;
                            break;

                        case 3:
                            lblJ2Modificar3.Text = resultado.ToString();
                            lblJ2Modificar3.Enabled = false;
                            break;

                        case 4:
                            lblJ2Modificar4.Text = resultado.ToString();
                            lblJ2Modificar4.Enabled = false;
                            break;

                        case 5:
                            lblJ2Modificar5.Text = resultado.ToString();
                            lblJ2Modificar5.Enabled = false;
                            break;

                        case 6:
                            lblJ2Modificar6.Text = resultado.ToString();
                            lblJ2Modificar6.Enabled = false;
                            break;
                    }
                    // }
                }
            }
            //int puntosUno = 0;
            //int puntosDos = 0;
            //int puntosGanador = 0;
            //int puntosPerdedor = 0;
            //bool empate = false;
            //string ganador = "";
            //string perdedor = "";
            //puntosUno = PuntosTotalesJugadorUno();
            //puntosDos = PuntosTotalesJugadorDos();
            //bool bandera = false;
            //if (puntosUno > puntosDos)
            //{
            //    ganador = j1.NombreJugador;
            //    perdedor = j2.NombreJugador;
            //    puntosGanador = puntosUno;
            //    puntosPerdedor = puntosDos;
            //    bandera = true;
            //}
            //else if (puntosUno < puntosDos)
            //{
            //    ganador = j2.NombreJugador;
            //    perdedor = j1.NombreJugador;
            //    puntosGanador = puntosDos;
            //    puntosPerdedor = puntosUno;
            //    bandera = true;
            //}
            //else
            //{
            //    empate = true;
            //    bandera = true;
            //}

            //Task.Run(() => { abrirFormGanador(ganador, perdedor, puntosGanador, puntosPerdedor, empate); });
            return 0;
        }


        private int PuntosTotalesJugadorUno()
        {
            int AlUno = int.Parse(this.lblJ1Modificar1.Text);
            int AlDos = int.Parse(this.lblJ1Modificar2.Text);
            int AlTres = int.Parse(this.lblJ1Modificar3.Text);
            int AlCuatro = int.Parse(this.lblJ1Modificar4.Text);
            int AlCinco = int.Parse(this.lblJ1Modificar5.Text);
            int AlSeis = int.Parse(this.lblJ1Modificar6.Text);
            int Esc = int.Parse(this.lblJ1ModificarEsc.Text);
            int Full = int.Parse(this.lblJ1ModificarFull.Text);
            int Poker = int.Parse(this.lblJ1ModificarPoker.Text);
            int Generala = int.Parse(this.lblJ1ModificarGenerala.Text);
            int sumaTotal = 0;

            sumaTotal = AlUno + AlDos + AlTres + AlCuatro + AlCinco + AlSeis + Esc + Full + Poker + Generala;
            return sumaTotal;
        }

        private int PuntosTotalesJugadorDos()
        {
            int AlUno = int.Parse(this.lblJ2Modificar1.Text);
            int AlDos = int.Parse(this.lblJ2Modificar2.Text);
            int AlTres = int.Parse(this.lblJ2Modificar3.Text);
            int AlCuatro = int.Parse(this.lblJ2Modificar4.Text);
            int AlCinco = int.Parse(this.lblJ2Modificar5.Text);
            int AlSeis = int.Parse(this.lblJ2Modificar6.Text);
            int Esc = int.Parse(this.lblJ2ModificarEsc.Text);
            int Full = int.Parse(this.lblJ2ModificarFull.Text);
            int Poker = int.Parse(this.lblJ2ModificarPoker.Text);
            int Generala = int.Parse(this.lblJ2ModificarGenerala.Text);
            int sumaTotal = 0;

            sumaTotal = AlUno + AlDos + AlTres + AlCuatro + AlCinco + AlSeis + Esc + Full + Poker + Generala;
            return sumaTotal;
        }

        public bool ValidarEnabledJ1(int num)
        {
            switch (num)
            {
                case 1:
                    if (lblJ1Modificar1.Enabled)
                    {
                        return true;
                    }
                    break;

                case 2:
                    if (lblJ1Modificar2.Enabled)
                    {
                        return true;
                    }
                    break;

                case 3:
                    if (lblJ1Modificar3.Enabled)
                    {
                        return true;
                    }
                    break;

                case 4:
                    if (lblJ1Modificar4.Enabled)
                    {

                        return true;
                    }
                    break;

                case 5:
                    if (lblJ1Modificar5.Enabled)
                    {
                        return true;

                    }
                    break;

                case 6:
                    if (lblJ1Modificar6.Enabled)
                    {

                        return true;
                    }
                    break;
            }

            return false;
        }

        public bool ValidarEnabledJ2(int num)
        {
            switch (num)
            {
                case 1:
                    if (lblJ2Modificar1.Enabled)
                    {
                        return true;
                    }
                    break;

                case 2:
                    if (lblJ2Modificar2.Enabled)
                    {
                        return true;
                    }
                    break;

                case 3:
                    if (lblJ2Modificar3.Enabled)
                    {
                        return true;
                    }
                    break;

                case 4:
                    if (lblJ2Modificar4.Enabled)
                    {

                        return true;
                    }
                    break;

                case 5:
                    if (lblJ2Modificar5.Enabled)
                    {
                        return true;

                    }
                    break;

                case 6:
                    if (lblJ2Modificar6.Enabled)
                    {

                        return true;
                    }
                    break;
            }

            return false;
        }


        public int prueba(int[] tirada)
        {
            int cantidadDados = 0;
            int resultado = 0;
            int puntosTotales = 0;
            foreach (int item in tirada)
            {
                for (int i = 0; i < 6; i++)
                {
                    if (ValidarEnabledJ1(tirada[i]))
                    {
                        foreach (int dado in tirada)
                        {
                            if (dado == tirada[i])
                            {
                                cantidadDados++;
                            }
                        }
                        resultado = cantidadDados * tirada[i];
                        return resultado;
                    }
                }
            }

            return 0;
        }

        private void btnCancelarMesa_Click(object sender, EventArgs e)
        {
            cancellationSource.Cancel();
        }
    }
}
