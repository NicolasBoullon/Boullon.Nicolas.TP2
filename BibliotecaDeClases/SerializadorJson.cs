using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class SerializadorJson<T>: ISerializadoraJson<T> where T : class
    {
        public  T DeserializarJson<T>(string ruta)
        {
            try
            {
                string objetoJson = File.ReadAllText(ruta);

                T objeto = JsonSerializer.Deserialize<T>(objetoJson);

                return objeto;
            }
            catch
            {
                throw new Exception("Hubo un error al Deserializar en formato Json");
            }
        }
        public  void SerializarJson<T>(string ruta, T objeto)
        {
            try
            {
                JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions();
                jsonSerializerOptions.WriteIndented = true;

                string objetoJson = JsonSerializer.Serialize(objeto, jsonSerializerOptions);

                File.WriteAllText(ruta, objetoJson);

            }
            catch
            {

                throw new Exception("Hubo un error al Serializar en formato Json");
            }
        }
    }
}
