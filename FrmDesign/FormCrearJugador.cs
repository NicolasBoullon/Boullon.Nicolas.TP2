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
    public partial class FormCrearJugador : Form
    {
        List<Jugador> listJugadores;
        public FormCrearJugador()
        {
            InitializeComponent();
            listJugadores = JugadorDAO.GetJugadores();
        }

        private void txtCrearJugador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                MessageBox.Show("Solo Ingresar Letras");
                e.Handled = true;
            }
        }

        private void btnAceptarCrearJugador_Click(object sender, EventArgs e)
        {
            string nombreJugador = txtCrearJugador.Text;
            if (!VerificarJugador(nombreJugador))
            {
                JugadorDAO.CrearJugador(nombreJugador);
                this.Close();
            }
            else
            {
                MessageBox.Show("Jugador ya existente. Ingrese otro nombre");
            }
        }


        private bool VerificarJugador(string nombreCompleto)
        {
            foreach (Jugador jug in listJugadores)
            {
                if (jug.NombreJugador == nombreCompleto)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
