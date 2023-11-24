using System;
using System.Collections.Generic;

namespace DỰ_ÁN_11.Models
{
    public partial class Sanpham
    {
        public Sanpham()
        {
            Sanphamcts = new HashSet<Sanphamct>();
        }

        public int Idsp { get; set; }
        public string Masp { get; set; } = null!;
        public string? Tensp { get; set; }
        public string? Thuonghieu { get; set; }
        public string? Chip { get; set; }
        public string? Camera { get; set; }
        public int? Kichthuoc { get; set; }
        public string? Chatlieu { get; set; }
        public string? Hedieuhanh { get; set; }
        public string? Dungluongpin { get; set; }
        public double? Gia { get; set; }
        public int? Trangthai { get; set; }
        public string? Hinhsp { get; set; }

        public virtual ICollection<Sanphamct> Sanphamcts { get; set; }
    }
}
