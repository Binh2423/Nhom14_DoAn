using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace FORM2.Data
{
    public partial class QLBD : DbContext
    {
        public QLBD()
            : base("name=QLBD7")
        {
        }

        public virtual DbSet<Bang> Bang { get; set; }
        public virtual DbSet<CauThu> CauThu { get; set; }
        public virtual DbSet<QuocGia> QuocGia { get; set; }
        public virtual DbSet<QuocGia2> QuocGia2 { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoan { get; set; }
        public virtual DbSet<TranDau> TranDau { get; set; }
        public virtual DbSet<XepHang> XepHang { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bang>()
                .Property(e => e.MaBang)
                .IsUnicode(false);

            modelBuilder.Entity<Bang>()
                .HasMany(e => e.XepHang)
                .WithRequired(e => e.Bang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CauThu>()
                .Property(e => e.MaQG)
                .IsUnicode(false);

            modelBuilder.Entity<QuocGia>()
                .Property(e => e.MaQG)
                .IsUnicode(false);

            modelBuilder.Entity<QuocGia>()
                .HasMany(e => e.CauThu)
                .WithRequired(e => e.QuocGia)
                .HasForeignKey(e => e.MaQG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<QuocGia>()
                .HasMany(e => e.CauThu1)
                .WithRequired(e => e.QuocGia1)
                .HasForeignKey(e => e.MaQG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<QuocGia>()
                .HasMany(e => e.TranDau)
                .WithRequired(e => e.QuocGia)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<QuocGia>()
                .HasOptional(e => e.XepHang)
                .WithRequired(e => e.QuocGia);

            modelBuilder.Entity<QuocGia2>()
                .Property(e => e.MaQG2)
                .IsUnicode(false);

            modelBuilder.Entity<QuocGia2>()
                .HasMany(e => e.TranDau)
                .WithRequired(e => e.QuocGia2)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.TaiKhoan1)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.MauKhau)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<TranDau>()
                .Property(e => e.MaQG)
                .IsUnicode(false);

            modelBuilder.Entity<TranDau>()
                .Property(e => e.MaQG2)
                .IsUnicode(false);

            modelBuilder.Entity<XepHang>()
                .Property(e => e.MaQG)
                .IsUnicode(false);

            modelBuilder.Entity<XepHang>()
                .Property(e => e.MaBang)
                .IsUnicode(false);
        }
    }
}
