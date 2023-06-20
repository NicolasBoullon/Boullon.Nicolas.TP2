using BibliotecaDeClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGenerala
{
    [TestClass]
    public class PruebaTest
    {
     
        [TestMethod]
        public void Test_MayorYMenorNumeroRepetido()
        {
            int[] arrayDeNumeros = { 1,1, 3, 4, 5 };
            int[] expected = { 1, 2 };

            int[] resultado = Partida.ContarMismoMinimoDado(arrayDeNumeros);


            CollectionAssert.AreEqual(expected,resultado);
        }
    }
}
