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
    
    public partial class LOAI_QUYET_DINH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAI_QUYET_DINH()
        {
            this.QUYETDINH_KHENTHUONG_KYLUAT = new HashSet<QUYETDINH_KHENTHUONG_KYLUAT>();
        }
    
        public int ID { get; set; }
        public string TenLoaiQD { get; set; }
        public string TrangThai { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QUYETDINH_KHENTHUONG_KYLUAT> QUYETDINH_KHENTHUONG_KYLUAT { get; set; }
    }
}