//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_QuanLy_NN_KS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class REQUEST
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public REQUEST()
        {
            this.CHAM_CONG = new HashSet<CHAM_CONG>();
        }
    
        public int ID { get; set; }
        public Nullable<int> ID_TK { get; set; }
        public Nullable<int> ID_LoaiRequest { get; set; }
        public string GhiChu { get; set; }
        public string TrangThai { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHAM_CONG> CHAM_CONG { get; set; }
        public virtual LOAI_REQUEST LOAI_REQUEST { get; set; }
        public virtual TAI_KHOAN TAI_KHOAN { get; set; }
    }
}
