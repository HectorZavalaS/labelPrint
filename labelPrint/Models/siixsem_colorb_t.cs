//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace labelPrint.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class siixsem_colorb_t
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public siixsem_colorb_t()
        {
            this.siixsem_colorsb_td = new HashSet<siixsem_colorsb_td>();
            this.siixsem_colorsb_led2_td = new HashSet<siixsem_colorsb_led2_td>();
        }
    
        public int se_id_cb { get; set; }
        public string se_description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<siixsem_colorsb_td> siixsem_colorsb_td { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<siixsem_colorsb_led2_td> siixsem_colorsb_led2_td { get; set; }
    }
}
