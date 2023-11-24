using System;
using System.Collections.Generic;

namespace DỰ_ÁN_11.Models
{
    public partial class Khohang
    {
        public string Masp { get; set; } = null!;
        public int Idsp { get; set; }
        public int Soluong { get; set; }

        public virtual Sanpham MaspNavigation { get; set; } = null!;
    }
}
