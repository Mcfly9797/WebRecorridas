//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_RECORRIDAS_SALONES
    {
        public int cs_recorridas { get; set; }
        public int cs_salones { get; set; }
        public bool estado { get; set; }
    
        public virtual TB_RECORRIDAS TB_RECORRIDAS { get; set; }
        public virtual TB_SALONES TB_SALONES { get; set; }
    }
}