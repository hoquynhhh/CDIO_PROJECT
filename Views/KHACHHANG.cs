using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_HSM3.Views
{
    public class KHACHHANG
    {
        public int MaKH { get; set; }
        public string HoTen { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }
        public string CCCD { get; set; }
        public string DiaChi { get; set; }

        public int? FK_MaTK { get; set; }
    }
}