//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sql_nhom.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietNhacTra
    {
        public string MaSach { get; set; }
        public decimal SoPhieu { get; set; }
        public Nullable<decimal> DonGiaPhat { get; set; }
    
        public virtual Sach Sach { get; set; }
        public virtual PhieuNhacTra PhieuNhacTra { get; set; }
    }
}
