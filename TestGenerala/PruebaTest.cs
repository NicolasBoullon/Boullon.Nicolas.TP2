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
        //[TestMethod]
        //public void Test_NumeroRepetido()
        //{
        //    //Arrange : Inicializar las variables
        //    int[] arrayDeNumeros = { 1, 4, 4, 4, 4 };
        //    int expected = 4;

        //    //Act : llamar al metodo a testear
        //    int resutlado = Partida.ContarMismoDado(4,arrayDeNumeros);

        //    //Assert: comprobar el resultado
        //    Assert.AreEqual(expected,resutlado);
        //}

        [TestMethod]
        public void Test_MayorYMenorNumeroRepetido()
        {
            int[] arrayDeNumeros = { 1,2, 3, 4, 5 };
            int[] expected = { 9, 9 };

            int[] resultado = Partida.ContarMismoMinimoDado(arrayDeNumeros);


            Assert.AreEqual(expected, resultado[1]);
        }
    }
}
