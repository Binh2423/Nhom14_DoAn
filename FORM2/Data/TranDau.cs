namespace FORM2.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TranDau")]
    public partial class TranDau
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaQG { get; set; }

        public int? TySo1 { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaQG2 { get; set; }

        public int? TySo2 { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime NgayDa { get; set; }

        public virtual QuocGia QuocGia { get; set; }

        public virtual QuocGia2 QuocGia2 { get; set; }
    }
}
