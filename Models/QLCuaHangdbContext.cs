using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BOHOPUB2HAND.Models
{
    public partial class QLCuaHangdbContext : DbContext
    {
        public QLCuaHangdbContext()
            : base("name=DemodbContext")
        {
        }
        public virtual DbSet<Nhanvien> Nhanviens { get; set; }
        public virtual DbSet<Hanghoa> Hanghoas { get; set; }
        public virtual DbSet<Khachhang> Khachhangs { get; set; }
        public virtual DbSet<Nhacungcap> Nhacungcaps { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
