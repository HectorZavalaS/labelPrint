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
    
    public partial class siixsem_voltageb_t
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public siixsem_voltageb_t()
        {
            this.siixsem_VoltsModel_td = new HashSet<siixsem_VoltsModel_td>();
            this.siixsem_VoltsModel_led2_td = new HashSet<siixsem_VoltsModel_led2_td>();
        }
    
        public int se_id_volt { get; set; }
        public string se_description { get; set; }
        public string se_volt_lbl { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<siixsem_VoltsModel_td> siixsem_VoltsModel_td { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<siixsem_VoltsModel_led2_td> siixsem_VoltsModel_led2_td { get; set; }
    }
}