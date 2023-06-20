using BibliotecaDeClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGenerala
{
    [TestClass]
    public class PartidaTest
    {
     
        [TestMethod]
        public void Test_MayorYMenorNumeroRepetido()
        {
            int[] arrayDeNumeros = { 1,1, 3, 4, 5 };
            int[] expected = { 1, 2 };

            int[] resultado = Partida.ContarMismoMinimoDado(arrayDeNumeros);


            CollectionAssert.AreEqual(expected,resultado);
        }


        [TestMethod]
        public void Test_EsGenerala_DeberiaDevolverTrue()
        {
            int[] arrayDeNumeros = { 5, 5, 5, 5, 5 };
            bool expected = true;

            bool resultado = Partida.EsGenerala(arrayDeNumeros);


            Assert.AreEqual(expected, resultado);
        }

        [TestMethod]
        public void Test_EsGenerala_DeberiaDevolverFalse()
        {
            int[] arrayDeNumeros = { 2, 3, 2, 1, 1 };
            bool expected = false;

            bool resultado = Partida.EsGenerala(arrayDeNumeros);


            Assert.AreEqual(expected, resultado);
        }

        [TestMethod]
        public void Test_EsPoker_DeberiaDevolverTrue()
        {
            int[] arrayDeNumeros = { 1, 5, 5, 5, 5 };
            bool expected = true;

            bool resultado = Partida.EsPoker(arrayDeNumeros);


            Assert.AreEqual(expected, resultado);
        }

        [TestMethod]
        public void Test_EsPoker_DeberiaDevolverFalse()
        {
            int[] arrayDeNumeros = { 1, 1, 1, 5, 5 };
            bool expected = false;

            bool resultado = Partida.EsPoker(arrayDeNumeros);


            Assert.AreEqual(expected, resultado);
        }

        [TestMethod]
        public void Test_EsFull_DeberiaDevolverTrue()
        {
            int[] arrayDeNumeros = { 2, 2, 5, 5, 5 };
            bool expected = true;

            bool resultado = Partida.EsFull(arrayDeNumeros);


            Assert.AreEqual(expected, resultado);
        }

        [TestMethod]
        public void Test_EsFull_DeberiaDevolverFalse()
        {
            int[] arrayDeNumeros = { 2, 5, 5, 5, 5 };
            bool expected = false;

            bool resultado = Partida.EsFull(arrayDeNumeros);


            Assert.AreEqual(expected, resultado);
        }

        [TestMethod]
        public void Test_EsEscalera_DeberiaDevolverTrue()
        {
            int[] arrayDeNumeros = { 1, 4, 3, 2, 5 };
            bool expected = true;

            bool resultado = Partida.EsEscalera(arrayDeNumeros);


            Assert.AreEqual(expected, resultado);
        }

        [TestMethod]
        public void Test_EsEscalera_DeberiaDevolverFalse()
        {
            int[] arrayDeNumeros = { 1, 3, 3, 2, 5 };
            bool expected = false;

            bool resultado = Partida.EsEscalera(arrayDeNumeros);


            Assert.AreEqual(expected, resultado);
        }
    }
}
