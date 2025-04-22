using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project_HSM3.Views
{
    public class PHONG
    {
        public int MaPhong { get; set; }
        public string TenPhong { get; set; }
        public string LoaiPhong { get; set; }
        public decimal? GiaPhong { get; set; }
        public int? SucChua { get; set; }
        public string MoTa { get; set; }
        [Required]
        public string TrangThai { get; set; }
    }
}