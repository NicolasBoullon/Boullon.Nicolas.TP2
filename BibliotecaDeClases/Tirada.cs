using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Tirada
    {
        public int[] tiradaDados;

        public Tirada()
        {
            this.tiradaDados = new int[5];
        }
        public int[] TiradaDados { get => tiradaDados; set => tiradaDados = value; }


        public static Tirada TirarDados()
        {
            Tirada tirarDados = new Tirada();
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                tirarDados.tiradaDados[i] = random.Next(1, 7);
                
            }
            return tirarDados;
        }


        public  string MostrarTirada()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 4; i++)
            {
                sb.Append(TiradaDados[i] + "-");

            }
            sb.Append(TiradaDados[4]);
            
            return sb.ToString();
        }
    }
}
