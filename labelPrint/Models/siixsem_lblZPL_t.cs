//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace labelPrint.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class siixsem_lblZPL_t
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public siixsem_lblZPL_t()
        {
            this.siixsem_lblTemplates_t = new HashSet<siixsem_lblTemplates_t>();
        }
    
        public int se_id_zpl { get; set; }
        public string se_name { get; set; }
        public string se_str_zpl_one { get; set; }
        public string se_str_zpl_two { get; set; }
        public string se_str_zpl_preview { get; set; }
        public string se_str_zpl_two_zt610 { get; set; }
        public string se_str_zpl_two_cab { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<siixsem_lblTemplates_t> siixsem_lblTemplates_t { get; set; }
    }
}
