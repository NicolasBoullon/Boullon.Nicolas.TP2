using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDeClases;
namespace TestGenerala
{
    [TestClass]
    public class UsuarioTest
    {
        [TestMethod]

        public void Test_DeberiaComprobarUsuario()
        {
            string user = "Nicolas Boullon";
            string pass = "prueba123";
            bool expected = true;

            bool resultado = Usuario.VerificarUsuarioExistente(user, pass);

            Assert.AreEqual(expected, resultado); 
        }


        [TestMethod]

        public void Test_DeberiaConseguirUsuario_YConfirmarTypeOff()
        {
            string user = "Nicolas Boullon";
            string pass = "prueba123";
            
            Usuario resultado = Usuario.ConseguirUsuario(user, pass);

            Assert.AreEqual(typeof(Usuario), resultado.GetType());
        }
    }
}
