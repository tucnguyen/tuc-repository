﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QuanLyPhongMachEntities : DbContext
    {
        public QuanLyPhongMachEntities()
            : base("name=QuanLyPhongMachEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<KhachHangGroup> KhachHangGroups { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<PetGroup> PetGroups { get; set; }
        public DbSet<PhieuDieuTri_Thuoc> PhieuDieuTri_Thuoc { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<Thuoc> Thuocs { get; set; }
        public DbSet<ThuocGroup> ThuocGroups { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserGroup> UserGroups { get; set; }
        public DbSet<PhieuDieuTri> PhieuDieuTris { get; set; }
    }
}
