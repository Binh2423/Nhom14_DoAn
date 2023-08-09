namespace FORM2.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bang")]
    public partial class Bang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bang()
        {
            XepHang = new HashSet<XepHang>();
        }

        [Key]
        [StringLength(10)]
        public string MaBang { get; set; }

        [StringLength(20)]
        public string TenBang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XepHang> XepHang { get; set; }
    }
}
