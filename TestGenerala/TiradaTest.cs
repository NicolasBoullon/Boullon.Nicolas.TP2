using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDeClases;
namespace TestGenerala
{
    [TestClass]
    public class TiradaTest
    {
        [TestMethod]

        public void Test_DeberiaGenerarTirada()
        {
            Tirada tiradaResultado = new Tirada();

            tiradaResultado = Tirada.TirarDados();
         
            Assert.AreEqual(typeof(Tirada), tiradaResultado.GetType());
        }

        [TestMethod]

        public void Test_DeberiaDevolverString()
        {
            Tirada tirada = new Tirada();
            tirada = Tirada.TirarDados();

            string expected = tirada.MostrarTirada();
            Assert.AreEqual(typeof(string),expected.GetType());
        }
    }
}
