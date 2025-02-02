using System;
using System.Diagnostics;

namespace Inmobiliaria.Utilidades.Seguridad
{
    public class PysistemasLogger
    {
        private readonly string _nombreClase;

        public PysistemasLogger(string nombreClaseOrigen)
        {
            _nombreClase = nombreClaseOrigen;
        }

        public static void Log(string mensaje,string nombreClase)
        {
            Trace.WriteLine(string.Format(nombreClase + "-" + "{0:yyyy-MM-dd HH:mm:ss}", DateTime.Now, nombreClase) + "-" + mensaje);
            Trace.Flush();
        }
    }


}
