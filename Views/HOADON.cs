using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_HSM3.Views
{
    public class HOADON
    {
        public int MaHD { get; set; }

        public int? FK_MaDatPhong { get; set; }       

        public DateTime? NgayThanhToan { get; set; }
        public decimal? TongTien { get; set; }
        public string PhuongThuc { get; set; }
    }
}