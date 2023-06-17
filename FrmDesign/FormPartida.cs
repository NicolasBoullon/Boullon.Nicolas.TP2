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
        public FormPartida()
        {
            InitializeComponent();

        }

        private void FormPartida_Load(object sender, EventArgs e)
        {
            Jugador j1 = new Jugador();
            Jugador j2 = new Jugador();
            JugarPartida(j1, j2);

        }

        private void JugarPartida(Jugador j1, Jugador j2)
        {
            j1.HacerTirada();
            j2.HacerTirada();

            for (int i = 0; i < 5; i++)
            {
                lstJ1.Items.Add(j1.Tiradas[i].MostrarTirada());
                lstJ2.Items.Add(j2.Tiradas[i].MostrarTirada());
            }

            CalcularPuntos(j1, j2);

        }


        private int CalcularPuntos(Jugador j1, Jugador j2)
        {
            int puntosTotales = 0;
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
                        Array.Reverse(item.TiradaDados);
                    //-------------------
                        int cantidadDados = 0;
                    if (ValidarEnabledJ1(valorYcantMinimo[0]))
                    {
                        valorAModificarDelLbl = valorYcantMinimo[0];

                    }
                    else
                    {
                        for (int i = 0; i <5; i++) 
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

                        //else if (valorYcantMinimo[1] > 1)
                        //{
                            
                        //}
                        //else if (ValidarEnabledJ1(valorYcantMaximo[0]))
                        //{
                        //    valorAModificarDelLbl = valorYcantMaximo[0];
                        //    resultado = valorYcantMaximo[0] * valorYcantMaximo[1];
                        //}
                        //else if (valorYcantMinimo[0] == 9 && valorYcantMinimo[1] == 9 && valorYcantMinimo[1] == 1)
                        //{
                        //    bool sePuede = false;
                        //    int[] tiradaAOrdenar = item.TiradaDados;
                        //    Array.Sort(tiradaAOrdenar);
                        //    while (!sePuede)
                        //    {
                        //        foreach (int entero in tiradaAOrdenar)
                        //        {
                        //            if (ValidarEnabledJ1(entero))
                        //            {

                        //                sePuede=true;
                        //                valorAModificarDelLbl = entero;
                        //                resultado = entero;
                        //                break;
                        //            }
                        //        }
                        //    }
                        //}
                        //else
                        //{
                        //    continue; // hacer que busque el siguiente que no se repita o el siguiente minimo                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             
                        //}

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
                    Array.Reverse(item.TiradaDados);
                        //-------------------
                    int cantidadDados = 0;
                    if (ValidarEnabledJ2(valorYcantMinimo[0]))//Evaluo si el numero que mas se repite esta en uso o no
                    {
                        valorAModificarDelLbl = valorYcantMinimo[0];
                    }
                    else
                    {
                        for (int i = 0; i < 5; i++)
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
                    //else if (valorYcantMinimo[0] == 9 && valorYcantMinimo[1] == 9 && valorYcantMinimo[1] == 1)
                    //{
                    //    bool sePuede = false;
                    //    int[] tiradaAOrdenar = item.TiradaDados;
                    //    Array.Sort(tiradaAOrdenar);
                    //    while (!sePuede)
                    //    {
                    //        foreach (int entero in tiradaAOrdenar)
                    //        {
                    //            if (ValidarEnabledJ1(entero))
                    //            {

                    //                sePuede = true;
                    //                valorAModificarDelLbl = entero;
                    //                resultado = entero;
                    //                break;
                    //            }
                    //        }
                    //    }
                    //}
                    //else
                    //{
                    //    continue;
                    //}

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

            return 0;
        }


        //public int Ordenar(int[] ints)
        //{
        //    return (a - b);
        //}


    public  bool ValidarEnabledJ1(int num)
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


        public  int prueba(int[] tirada)
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

            return  0;
        }

    }
}
