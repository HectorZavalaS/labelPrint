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
    
    public partial class siixsem_pcb_count_m_td
    {
        public int se_id { get; set; }
        public int se_id_dj { get; set; }
        public int se_id_spec { get; set; }
        public int se_count { get; set; }
    
        public virtual siixsem_DjHist_t siixsem_DjHist_t { get; set; }
        public virtual siixsem_lblModel_spec_td siixsem_lblModel_spec_td { get; set; }
    }
}
