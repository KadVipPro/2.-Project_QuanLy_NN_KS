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
    
    public partial class CHI_TIET_CHAM_CONG
    {
        public int ID_CHAM_CONG { get; set; }
        public int ID_NHAN_VIEN { get; set; }
        public Nullable<double> SoGioLam { get; set; }
    
        public virtual CHAM_CONG CHAM_CONG { get; set; }
        public virtual NHAN_VIEN NHAN_VIEN { get; set; }
    }
}
