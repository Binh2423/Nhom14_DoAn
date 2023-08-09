namespace FORM2.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("XepHang")]
    public partial class XepHang
    {
        public short DD { get; set; }

        public short Thang { get; set; }

        public short Hoa { get; set; }

        public short Thua { get; set; }

        public short BT { get; set; }

        public short SBT { get; set; }

        public short HS { get; set; }

        public short Diem { get; set; }

        [Key]
        [StringLength(10)]
        public string MaQG { get; set; }

        [Required]
        [StringLength(10)]
        public string MaBang { get; set; }

        public virtual Bang Bang { get; set; }

        public virtual QuocGia QuocGia { get; set; }
    }
}
