//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Inmobiliaria.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class COBROS_VIEW
    {
        public long COBRO_ID { get; set; }
        public System.DateTime FECHA { get; set; }
        public long SOCIO_NEGOCIO_ID { get; set; }
        public string SOCIO_NEGOCIO { get; set; }
        public string RUC { get; set; }
        public string NUMERO_DOCUMENTO_COBRO { get; set; }
        public string ESTADO { get; set; }
        public decimal TOTAL { get; set; }
        public string OBSERVACION { get; set; }
        public string USUARIO_CREACION { get; set; }
        public System.DateTime FECHA_CREACION { get; set; }
        public string USUARIO_MODIFICACION { get; set; }
        public Nullable<System.DateTime> FECHA_MODIFICACION { get; set; }
        public string NUMERO_FACTURA { get; set; }
    }
}
