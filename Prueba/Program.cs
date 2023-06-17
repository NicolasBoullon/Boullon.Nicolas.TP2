using BibliotecaDeClases;


namespace Prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Jugador j1 = new Jugador();

            //j1.HacerTirada();
            int[] tirada = { 3, 3, 2, 2, 3 };

            //Console.WriteLine(Jugador.MostrarTiradas(j1));
            //int[] prueba = Partida.ContarMismoMinimoDado(tirada);
            int[] pruebaDos = Partida.ContarMismoMaximoDado(tirada);
            int resultado;
            resultado = prueba(tirada);
            Console.WriteLine(resultado);
           // Console.Write($"El numero que mas se repite es: { prueba[0]} - Y se repite:{ prueba[1]} veces");
            Console.Write($"El numero que mas se repite es: { pruebaDos[0]} - Y se repite:{ pruebaDos[1]} veces");
        }


        public static int prueba(int[] tirada)
        {
            int cantidadDados = 0;
            int resultado = 0;
            int puntosTotales = 0;
            foreach (int item in tirada)
            {
                for (int i = 0; i < 6; i++)
                {
                    
                        foreach (int dado in tirada)
                        {
                            if (dado == tirada[i])
                            {
                                cantidadDados++;
                            }
                        }
                        resultado = cantidadDados * tirada[i];
                        return resultado;
                    
                }
            }

            return 0;
        }


    }
}