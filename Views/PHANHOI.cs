using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_HSM3.Views
{
    public class PHANHOI
    {
        public int MaPhanHoi { get; set; }

        public int? FK_MaKH { get; set; }

        public string NoiDung { get; set; }
        public DateTime? NgayGui { get; set; }
    }
}