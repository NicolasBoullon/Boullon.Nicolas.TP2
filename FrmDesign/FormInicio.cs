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
    public partial class FormInicio : Form
    {
        List<Jugador> listJugadores;
        public FormInicio()
        {
            InitializeComponent();
            listJugadores = JugadorDAO.GetJugadores();
            rellenarCMB();
        }

        private void btnMenuPartidas_Click(object sender, EventArgs e)
        {
            tbcInferfazInicio.SelectTab(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbcInferfazInicio.SelectTab(1);
        }

        private void btnCrearMesa_Click(object sender, EventArgs e)
        {
            Jugador j1 = new Jugador();
            Jugador j2 = new Jugador();

            foreach (Jugador item in listJugadores)
            {
                j1 = item;
                j2 = item;
            }
            FormPartida frm = new FormPartida(j1,j2);
            Task.Run(() => { frm.ShowDialog(); });

            
        }


        private void rellenarCMB()
        {
            foreach (Jugador item in listJugadores)
            {
                cmbJugadorUno.Items.Add(item.NombreJugador);
                cmbJugadorDos.Items.Add(item.NombreJugador);
            }
        }
    }
}
