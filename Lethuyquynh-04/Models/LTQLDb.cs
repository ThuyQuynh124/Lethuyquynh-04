using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Lethuyquynh_04.Models
{
    public partial class LTQLDb : DbContext
    {
        public LTQLDb()
            : base("name=LTQLDb")
        {
        }
        public virtual DbSet<TinhThanh> TinhThanhs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TinhThanh>()
             .Property(e => e.MaTinhThanh);

            modelBuilder.Entity<TinhThanh>()
              .Property(e => e.TenTinhThanh);

            modelBuilder.Entity<NhanVien>()
             .Property(e => e.MaNhanVien)
             .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
              .Property(e => e.TenNhanVien);

        }
    }
}
