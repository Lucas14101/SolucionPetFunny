//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Alojamiento
    {
        public string Rut { get; set; }
        public string NombreMascota { get; set; }
        public int IdTipoMascota { get; set; }
        public int IdTipoAlojamiento { get; set; }
        public System.DateTime FechaIngreso { get; set; }
        public int Dias { get; set; }
    
        public virtual TipoAlojamiento TipoAlojamiento { get; set; }
        public virtual TipoMascota TipoMascota { get; set; }
        public virtual Propietario Propietario { get; set; }
    }
}
