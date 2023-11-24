using System;
using System.Collections.Generic;

namespace DỰ_ÁN_11.Models
{
    public partial class Hoadonct
    {
        public string Mahd { get; set; } = null!;
        public string Maspct { get; set; } = null!;
        public string Makh { get; set; } = null!;
        public string Makm { get; set; } = null!;
        public double? Dongia { get; set; }
        public int? Soluong { get; set; }
        public double? Tienkhachdua { get; set; }
        public double? Tientralai { get; set; }
        public DateTime? Ngaymua { get; set; }
        public string? Hinhthucthanhtoan { get; set; }
        public double? Tongtien { get; set; }
        public string? Ghichu { get; set; }
        public string? Giamgia { get; set; }
        public int? Trangthai { get; set; }

        public virtual Hoadon MahdNavigation { get; set; } = null!;
        public virtual Khachhang MakhNavigation { get; set; } = null!;
        public virtual Khuyenmai MakmNavigation { get; set; } = null!;
        public virtual Sanphamct MaspctNavigation { get; set; } = null!;
    }
}
