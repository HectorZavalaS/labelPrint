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
    
    public partial class siixsem_lblModel_spec_Led2_td
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public siixsem_lblModel_spec_Led2_td()
        {
            this.siixsem_pcb_count_sm_td = new HashSet<siixsem_pcb_count_sm_td>();
        }
    
        public int se_id_spec { get; set; }
        public int se_id_model { get; set; }
        public int se_id_side { get; set; }
        public int se_id_flx { get; set; }
        public int se_id_color { get; set; }
        public int se_id_volt { get; set; }
        public int se_id_label { get; set; }
        public Nullable<int> se_id_rev { get; set; }
        public int se_id_genLbl_user { get; set; }
        public int se_cant_lbl { get; set; }
        public int se_init_lbl_folio { get; set; }
        public int se_curr_lbl_folio { get; set; }
        public int se_last_lbl_folio { get; set; }
        public System.DateTime se_date_vigence { get; set; }
        public int se_is_valid { get; set; }
        public string se_dj_no { get; set; }
        public string se_assy_name { get; set; }
        public System.DateTime se_date_plan { get; set; }
        public int se_is_remaining { get; set; }
        public int se_id_flx1 { get; set; }
        public int se_id_color1 { get; set; }
        public int se_id_volt1 { get; set; }
        public string se_dj_group { get; set; }
        public int se_generate_Excel { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<siixsem_pcb_count_sm_td> siixsem_pcb_count_sm_td { get; set; }
    }
}