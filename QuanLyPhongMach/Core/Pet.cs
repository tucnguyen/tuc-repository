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
    
    public partial class Pet
    {
        public Pet()
        {
            this.PhieuDieuTris = new HashSet<PhieuDieuTri>();
        }
    
        public int Id { get; set; }
        public int IdGroup { get; set; }
        public int IdKhachHang { get; set; }
        public string Ten { get; set; }
        public string Giong { get; set; }
        public string GioiTinh { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public Nullable<double> TrongLuong { get; set; }
        public string GhiChu { get; set; }
        public string CreateBy { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public bool DeleteFlag { get; set; }
    
        public virtual KhachHang KhachHang { get; set; }
        public virtual PetGroup PetGroup { get; set; }
        public virtual ICollection<PhieuDieuTri> PhieuDieuTris { get; set; }
    }
}
