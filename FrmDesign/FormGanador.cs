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
    public partial class FormGanador : Form
    {
        List<Jugador> listJugador;
        public FormGanador(string ganador, string perdedor, int puntosGanador, int puntosPerdedor, bool empate)
        {
            InitializeComponent();

            listJugador = JugadorDAO.GetJugadores();
            mostrarResultados(ganador, perdedor, puntosGanador, puntosPerdedor, empate);
            
            foreach (Jugador jug in listJugador)
            {
                if (jug.NombreJugador == ganador)
                {
                    jug.CantidadDeVictorias++;
                    JugadorDAO.ActualizarVictoriasJugadorDAO(jug);
                }
            }

        }

        private void FormGanador_Load(object sender, EventArgs e)
        {
        }

        private void mostrarResultados(string ganador, string perdedor, int puntosGanador, int puntosPerdedor, bool empate)
        {
            lblGanador.Text = $"Ganador: {ganador}  Puntos: {puntosGanador}";
            lblPerdedor.Text = $"Perdedor: {perdedor}  Puntos: {puntosPerdedor}";
        }
    }
}
