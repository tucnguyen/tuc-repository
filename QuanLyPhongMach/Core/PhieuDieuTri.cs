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
    
    public partial class PhieuDieuTri
    {
        public PhieuDieuTri()
        {
            this.PhieuDieuTri_Thuoc = new HashSet<PhieuDieuTri_Thuoc>();
        }
    
        public int Id { get; set; }
        public int IdPet { get; set; }
        public int IdUser { get; set; }
        public string Ma { get; set; }
        public Nullable<double> TrongLuong { get; set; }
        public Nullable<double> NhietDo { get; set; }
        public bool IsKhamBenh { get; set; }
        public bool IsChich_UongThuoc { get; set; }
        public bool IsTruyenDichTinhMach { get; set; }
        public string Khac { get; set; }
        public string LoiDanDo { get; set; }
        public long TongTien { get; set; }
        public string CreateBy { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public bool DeleteFlag { get; set; }
    
        public virtual Pet Pet { get; set; }
        public virtual ICollection<PhieuDieuTri_Thuoc> PhieuDieuTri_Thuoc { get; set; }
        public virtual User User { get; set; }
    }
}
