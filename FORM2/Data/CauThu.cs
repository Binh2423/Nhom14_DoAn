namespace FORM2.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CauThu")]
    public partial class CauThu
    {
        [Required]
        [StringLength(10)]
        public string MaQG { get; set; }

        [Key]
        [StringLength(100)]
        public string TenCauThu { get; set; }

        [StringLength(100)]
        public string ViTri { get; set; }

        [Column(TypeName = "image")]
        public byte[] HinhAnhCT { get; set; }

        public int? SoBanThang { get; set; }

        public virtual QuocGia QuocGia { get; set; }

        public virtual QuocGia QuocGia1 { get; set; }
    }
}
