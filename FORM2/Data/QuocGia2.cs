namespace FORM2.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class QuocGia2
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QuocGia2()
        {
            TranDau = new HashSet<TranDau>();
        }

        [Key]
        [StringLength(10)]
        public string MaQG2 { get; set; }

        [StringLength(100)]
        public string TenQG { get; set; }

        [Column(TypeName = "image")]
        public byte[] QuocKy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TranDau> TranDau { get; set; }
    }
}
