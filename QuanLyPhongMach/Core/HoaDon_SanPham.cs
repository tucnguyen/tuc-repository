//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core
{
    using System;
    using System.Collections.Generic;
    
    public partial class HoaDon_SanPham
    {
        public int Id { get; set; }
        public int IdHoaDon { get; set; }
        public int IdSanPham { get; set; }
        public long Gia { get; set; }
        public int SoLuong { get; set; }
        public long TongTien { get; set; }
    
        public virtual HoaDon HoaDon { get; set; }
        public virtual SanPham SanPham { get; set; }
    }
}
