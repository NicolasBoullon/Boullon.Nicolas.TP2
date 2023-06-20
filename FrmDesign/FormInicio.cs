﻿using BibliotecaDeClases;
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
        public delegate void DelegadoMensaje(string mensaje);
        public FormInicio()
        {
            InitializeComponent();
            listJugadores = JugadorDAO.GetJugadores();
            rellenarCMB();
            cmbJugadorDos.Enabled = false;
        }

        public void MensajeError(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
        private void btnMenuPartidas_Click(object sender, EventArgs e)
        {
            tbcInferfazInicio.SelectTab(0);
        }

        private void button2_Click(object sender, EventArgs e)//boton historial
        {
            tbcInferfazInicio.SelectTab(1);

            dtgvRankingVictorias.DataSource = null;
            dtgvRankingVictorias.DataSource = JugadorDAO.TraerRankingDeVictorias();
        }

        private void btnCrearMesa_Click(object sender, EventArgs e)
        {
            string cmbJug1 = cmbJugadorUno.Text;
            string cmbJug2 = cmbJugadorDos.Text;
            List<Jugador> jugAux = new List<Jugador>();

            Jugador j1 = new Jugador();
            Jugador j2 = new Jugador();

            if (cmbJug1 == "" || cmbJug2 == "")
            {
                DelegadoMensaje mensajeError = MensajeError;
                mensajeError("Debe elegir los jugadores primero!");
                return;
            }

            foreach (Jugador jug in listJugadores)
            {
                if (jug.NombreJugador == cmbJug1)
                {
                    j1 = jug;
                }

                if (jug.NombreJugador == cmbJug2)
                {
                    j2 = jug;
                }
            }
            jugAux.Add(j1);
            jugAux.Add(j2);
            SerializadorJson<List<Jugador>>.SerializarJsonJugador("jugador.json", jugAux);
            FormPartida frm = new FormPartida(j1, j2);
            Task.Run(() => { frm.ShowDialog(); });
        }



        private void rellenarCMB()
        {
            listJugadores = JugadorDAO.GetJugadores();
            cmbJugadorUno.Items.Clear();
            cmbJugadorDos.Items.Clear();
            foreach (Jugador item in listJugadores)
            {
                cmbJugadorUno.Items.Add(item.NombreJugador);
                cmbJugadorDos.Items.Add(item.NombreJugador);
            }
        }

        private void cmbJugadorUno_TextChanged(object sender, EventArgs e)
        {
            string jugadorUnoElegido = cmbJugadorUno.Text;
            cmbJugadorDos.Items.Clear();
            foreach (Jugador item in listJugadores)
            {
                cmbJugadorDos.Items.Add(item.NombreJugador);
            }
            cmbJugadorDos.Items.Remove(jugadorUnoElegido);
            cmbJugadorDos.Enabled = true;
        }

        private void btnCrearJugador_Click(object sender, EventArgs e)
        {
            FormCrearJugador frm = new FormCrearJugador();
            frm.ShowDialog();
            rellenarCMB();
        }
    }
}
