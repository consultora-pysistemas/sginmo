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
    
    public partial class CIUDADES
    {
        public CIUDADES()
        {
            this.BARRIOS_CIUDADES = new HashSet<BARRIOS_CIUDADES>();
            this.CIUDADES_DEPARTAMENTOS = new HashSet<CIUDADES_DEPARTAMENTOS>();
            this.ENTIDADES_INMOBILIARIAS = new HashSet<ENTIDADES_INMOBILIARIAS>();
            this.PROPIEDADES = new HashSet<PROPIEDADES>();
        }
    
        public long CIUDAD_ID { get; set; }
        public string CIUDAD { get; set; }
        public string USUARIO_CREACION { get; set; }
        public System.DateTime FECHA_CREACION { get; set; }
        public string USUARIO_MODIFICACION { get; set; }
        public Nullable<System.DateTime> FECHA_MODIFICACION { get; set; }
    
        public virtual ICollection<BARRIOS_CIUDADES> BARRIOS_CIUDADES { get; set; }
        public virtual ICollection<CIUDADES_DEPARTAMENTOS> CIUDADES_DEPARTAMENTOS { get; set; }
        public virtual ICollection<ENTIDADES_INMOBILIARIAS> ENTIDADES_INMOBILIARIAS { get; set; }
        public virtual ICollection<PROPIEDADES> PROPIEDADES { get; set; }
    }
}
