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
    
    public partial class siixsem_densities_t
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public siixsem_densities_t()
        {
            this.siixsem_datamatrix_t = new HashSet<siixsem_datamatrix_t>();
        }
    
        public int se_id_density { get; set; }
        public double se_density { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<siixsem_datamatrix_t> siixsem_datamatrix_t { get; set; }
    }
}
