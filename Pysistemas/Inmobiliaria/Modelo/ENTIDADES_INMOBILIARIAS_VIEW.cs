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
    
    public partial class ENTIDADES_INMOBILIARIAS_VIEW
    {
        public long ENTIDAD_INMOBILIARIA_ID { get; set; }
        public string NOMBRE { get; set; }
        public string TIPO { get; set; }
        public string DIRECCION { get; set; }
        public Nullable<int> CANTIDAD_UNIDADES { get; set; }
        public Nullable<int> ANO_CONSTRUCCION { get; set; }
        public Nullable<int> M2_CONSTRUCCION { get; set; }
        public string MEDIDAS_LOTE { get; set; }
        public string CARACTERISTICAS { get; set; }
        public string NUMERO_FINCA { get; set; }
        public string CUENTA_CATASTRAL { get; set; }
        public long PAIS_ID { get; set; }
        public string PAIS { get; set; }
        public long DEPARTAMENTO_ID { get; set; }
        public string DEPARTAMENTO { get; set; }
        public long CIUDAD_ID { get; set; }
        public string CIUDAD { get; set; }
        public long BARRIO_ID { get; set; }
        public string BARRIO { get; set; }
        public string USUARIO_CREACION { get; set; }
        public System.DateTime FECHA_CREACION { get; set; }
        public string USUARIO_MODIFICACION { get; set; }
        public Nullable<System.DateTime> FECHA_MODIFICACION { get; set; }
    }
}
