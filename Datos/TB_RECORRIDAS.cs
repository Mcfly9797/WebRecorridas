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
    
    public partial class TB_RECORRIDAS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_RECORRIDAS()
        {
            this.TB_RECORRIDAS_SALONES = new HashSet<TB_RECORRIDAS_SALONES>();
        }
    
        public int id { get; set; }
        public int cs_soportista { get; set; }
        public System.DateTime fecha { get; set; }
        public string detalle { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_RECORRIDAS_SALONES> TB_RECORRIDAS_SALONES { get; set; }
        public virtual TB_USER_IT TB_USER_IT { get; set; }
    }
}