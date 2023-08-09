namespace FORM2.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QuocGia")]
    public partial class QuocGia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QuocGia()
        {
            CauThu = new HashSet<CauThu>();
            CauThu1 = new HashSet<CauThu>();
            TranDau = new HashSet<TranDau>();
        }

        [Key]
        [StringLength(10)]
        public string MaQG { get; set; }

        [Required]
        [StringLength(100)]
        public string TenQG { get; set; }

        [Column(TypeName = "image")]
        public byte[] QuocKy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CauThu> CauThu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CauThu> CauThu1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TranDau> TranDau { get; set; }

        public virtual XepHang XepHang { get; set; }
    }
}
