using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Project_HSM3.Views
{
    public class HMSDBContext : DbContext
    {
        public HMSDBContext() : base("name=ChuoiKN") { }
        public DbSet<CTHD> cthd { get; set; }
        public DbSet<DATPHONG> datphong { get; set; }
        public DbSet<DICHVU> dichvu { get; set; }
        public DbSet<HOADON> hoadon { get; set; }
        public DbSet<KHACHHANG> khachhang { get; set; }
        public DbSet<NHANVIEN> nhanvien { get; set; }
        public DbSet<PHANHOI> phanhoi { get; set; }
        public DbSet<PHONG> phong { get; set; }
        public DbSet<SUDUNGDICHVU> sudungdichvu { get; set; }
        public DbSet<TAIKHOAN> taikhoan { get; set; }


    }
}