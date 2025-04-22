using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_HSM3.Views
{
    public class DATPHONG
    {
        public int MaDatPhong { get; set; }

        public int? FK_MaKH { get; set; }
       

        public int? FK_MaPhong { get; set; }


        public DateTime? NgayNhan { get; set; }
        public DateTime? NgayTra { get; set; }
        public string MoTa { get; set; }
        public string TrangThai { get; set; }

        public int? FK_MaNV { get; set; }
    }
}