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
    public partial class FormGanador : Form 
    {
        List<Jugador> listJugador;
        List<Partida> listPartida = new List<Partida>();
        private string gan;
        private string per;
        private int pGan;
        private int pPerd;
        private bool emp;
        public FormGanador(string ganador, string perdedor, int puntosGanador, int puntosPerdedor, bool empate)
        {
            InitializeComponent();
             gan = ganador;
             per = perdedor;
             pGan= puntosGanador;
             pPerd = puntosPerdedor;
             emp = empate;

            listJugador = JugadorDAO.GetJugadores();
        }

        private void FormGanador_Load(object sender, EventArgs e)
        {
            mostrarResultados(gan, per, pGan, pPerd, emp);
            SerializadorJson<List<Partida>> serial = new SerializadorJson<List<Partida>>();
            Partida partida = new Partida(gan, per, pGan, pPerd, DateTime.Now);
            if (!File.Exists("partidas.json"))
            {
                listPartida.Add(partida);
                serial.SerializarJson<List<Partida>>("partidas.json", listPartida);
            }
            else
            {
                listPartida = serial.DeserializarJson<List<Partida>>("partidas.json");
                listPartida.Add(new Partida(gan, per, pGan, pPerd, DateTime.Now));
                serial.SerializarJson("partidas.json", listPartida);

            }
        }

        private void mostrarResultados(string ganador, string perdedor, int puntosGanador, int puntosPerdedor, bool empate)
        {
            lblGanador.Text = $"Ganador: {ganador}  Puntos: {puntosGanador}";
            lblPerdedor.Text = $"Perdedor: {perdedor}  Puntos: {puntosPerdedor}";
        }
    }
}
