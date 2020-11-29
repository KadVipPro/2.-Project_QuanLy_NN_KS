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
    
    public partial class CHI_TIET_HOA_DON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CHI_TIET_HOA_DON()
        {
            this.DICH_VU = new HashSet<DICH_VU>();
        }
    
        public int ID_HOA_DON { get; set; }
        public int ID_PHONG { get; set; }
        public Nullable<System.DateTime> NgayNhanPhong { get; set; }
        public Nullable<System.DateTime> NgayTraPhong { get; set; }
        public Nullable<decimal> TienPhong { get; set; }
        public Nullable<decimal> TienDichVu { get; set; }
        public Nullable<decimal> PhuThu { get; set; }
        public Nullable<decimal> ThanhTien { get; set; }
        public string GhiChu { get; set; }
    
        public virtual HOA_DON HOA_DON { get; set; }
        public virtual PHONG PHONG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DICH_VU> DICH_VU { get; set; }
    }
}