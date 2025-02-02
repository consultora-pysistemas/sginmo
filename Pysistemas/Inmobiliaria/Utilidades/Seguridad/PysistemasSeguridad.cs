using System;
using System.Text;

namespace Inmobiliaria.Utilidades.Seguridad
{
    public class PysistemasSeguridad
    {
        public static string Encriptar(string clave)
        {
            string result = string.Empty;
            byte[] encryted = Encoding.Unicode.GetBytes(clave);
            result = Convert.ToBase64String(encryted);
            return result;
        }

        public static string Desencriptar(string clave)
        {
            string result = string.Empty;
            byte[] decryted = Convert.FromBase64String(clave);
            result = Encoding.Unicode.GetString(decryted);
            return result;
        }


        public static string ObtenerSerialActivacion()
        {
            return Guid.NewGuid().ToString();
        }

        public static string ObtenerNombreEstacion()
        {
            return Environment.MachineName;
        }

        public static string ObtenerVersion()
        {
            return typeof(PysistemasSeguridad).Assembly.GetName().Version.ToString();
        }
    }
}
