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
    
    public partial class QUYETDINH_KHENTHUONG_KYLUAT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QUYETDINH_KHENTHUONG_KYLUAT()
        {
            this.KHENTHUONG_KYLUAT_CANHAN = new HashSet<KHENTHUONG_KYLUAT_CANHAN>();
            this.KHENTHUONG_KYLUAT_TAPTHE = new HashSet<KHENTHUONG_KYLUAT_TAPTHE>();
        }
    
        public int ID { get; set; }
        public Nullable<int> ID_LOAI_QD { get; set; }
        public Nullable<System.DateTime> NgayApDung { get; set; }
        public string NoiDungQuyetDinh { get; set; }
        public string TrangThai { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHENTHUONG_KYLUAT_CANHAN> KHENTHUONG_KYLUAT_CANHAN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHENTHUONG_KYLUAT_TAPTHE> KHENTHUONG_KYLUAT_TAPTHE { get; set; }
        public virtual LOAI_QUYET_DINH LOAI_QUYET_DINH { get; set; }
    }
}
