//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class BenhNhan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BenhNhan()
        {
            this.PhieuKhams = new HashSet<PhieuKham>();
        }
    
        public string maBN { get; set; }
        public string hoTenBN { get; set; }
        public System.DateTime ngaySinh { get; set; }
        public string gioiTinh { get; set; }
        public string diaChi { get; set; }
        public string dienThoai { get; set; }
        public string CCCD { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuKham> PhieuKhams { get; set; }
    }
}
