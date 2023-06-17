using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public interface ISerializadoraJson<T> where T : class
    {
        public  T DeserializarJson<T>(string ruta);

        public void SerializarJson<T>(string ruta, T objeto);
       

    }
}
