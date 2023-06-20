using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDeClases;
namespace TestGenerala
{
    [TestClass]
    public class JugadorTest
    {
        [TestMethod]

        public void Test_DeberiaDevovlerString()
        {
            //Arrange
            string mensaje = "Hola Mundo";
            Jugador j1 = new Jugador(2,"JugadorDePrueba",4);
            string expected = j1.MostrarInformacionJugador();
            //Act
            string resultado = j1.MostrarInformacionJugador();
            //Assert
            Assert.AreEqual(expected, resultado);
        }

    }
}
