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
    
    public partial class QUYET_DINH_TUYEN_DUNG
    {
        public int ID_NV { get; set; }
        public Nullable<int> ID_PHONG_BAN { get; set; }
        public Nullable<System.DateTime> NgayQDTD { get; set; }
        public string ThoiGianThuViec { get; set; }
        public Nullable<decimal> MucLuongThuViec { get; set; }
        public string NoiQDTD { get; set; }
        public string TrangThai { get; set; }
    
        public virtual NHAN_VIEN NHAN_VIEN { get; set; }
        public virtual PHONG_BAN PHONG_BAN { get; set; }
    }
}
