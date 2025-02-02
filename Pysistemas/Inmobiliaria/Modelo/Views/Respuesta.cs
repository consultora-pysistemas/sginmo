using System;

namespace Inmobiliaria.Modelo.Views
{
    public class Respuesta
    {
        public string Status { get; set; }
        public string Codigo { get; set; }
        public string Mensaje { get; set; }
        public Object Entity { get; set; }
    }
}
