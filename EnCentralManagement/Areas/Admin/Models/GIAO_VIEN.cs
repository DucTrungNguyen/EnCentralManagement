//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EnCentralManagement.Areas.Admin.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class GIAO_VIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GIAO_VIEN()
        {
            this.LOP_HOC = new HashSet<LOP_HOC>();
        }
    
        public string ID { get; set; }
        public string PASS_WORD { get; set; }
        public string HO_TEN { get; set; }
        public Nullable<System.DateTime> NGAY_SINH { get; set; }
        public Nullable<int> GIOI_TINH { get; set; }
        public string DIA_CHI { get; set; }
        public string SO_DIENTHOAI { get; set; }
        public string EMAIL { get; set; }
        public byte[] AVATAR { get; set; }
        public string ID_TRINHDO_GIAOVIEN { get; set; }
        public string ID_TRINHDO_GIANGDAY { get; set; }
        public string GIOI_THIEU { get; set; }
    
        public virtual TRINHDO_GIAOVIEN TRINHDO_GIAOVIEN { get; set; }
        public virtual TRINHDO_LOPHOC TRINHDO_LOPHOC { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOP_HOC> LOP_HOC { get; set; }
    }
}
