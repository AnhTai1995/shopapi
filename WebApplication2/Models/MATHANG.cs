//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MATHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MATHANG()
        {
            this.CHITIETMATHANGs = new HashSet<CHITIETMATHANG>();
        }
    
        public int ID { get; set; }
        public string TenMH { get; set; }
        public int IDSubLoaiHang { get; set; }
        public string URLHinhAnh1 { get; set; }
        public string URLHinhAnh2 { get; set; }
        public string URLHinhAnh3 { get; set; }
        public Nullable<bool> STATUS { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETMATHANG> CHITIETMATHANGs { get; set; }
        public virtual SUBLOAIHANG SUBLOAIHANG { get; set; }
    }
}
