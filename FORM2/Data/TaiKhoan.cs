namespace FORM2.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [Key]
        [Column("TaiKhoan")]
        [StringLength(100)]
        public string TaiKhoan1 { get; set; }

        [Required]
        [StringLength(100)]
        public string MauKhau { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }
    }
}
