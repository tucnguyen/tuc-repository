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
    
    public partial class ThuocGroup
    {
        public ThuocGroup()
        {
            this.Thuocs = new HashSet<Thuoc>();
        }
    
        public int Id { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
    
        public virtual ICollection<Thuoc> Thuocs { get; set; }
    }
}
