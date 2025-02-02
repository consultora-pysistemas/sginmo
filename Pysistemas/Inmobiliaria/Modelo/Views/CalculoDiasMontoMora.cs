using System;

namespace Inmobiliaria.Modelo.Views
{
    public class CalculoDiasMontoMora
    {
        public DateTime fechaVencimiento { get; set; }
        public long? diaGracias { get; set; }
        public Decimal montoMoraDia { get; set; }
        public Int64 diasMoras { get; set; }
        public Decimal montoMora { get; set; }
        public DateTime fechaCobro { get; set; }
    }

}
