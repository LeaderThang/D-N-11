using System;
using System.Collections.Generic;

namespace DỰ_ÁN_11.Models
{
    public partial class Nhanvien
    {
        public Nhanvien()
        {
            Hoadons = new HashSet<Hoadon>();
        }

        public int Idnv { get; set; }
        public string Manv { get; set; } = null!;
        public string? Tennv { get; set; }
        public DateTime? Ngaysinh { get; set; }
        public string? Sdt { get; set; }
        public string? Tentk { get; set; }
        public string? Chucvu { get; set; }
        public string? Diachi { get; set; }
        public string? Cccd { get; set; }
        public string? Email { get; set; }
        public string? Gioitinh { get; set; }
        public string? Thamnien { get; set; }
        public double? Luongcb { get; set; }
        public string? Hinhanh { get; set; }

        public virtual ICollection<Hoadon> Hoadons { get; set; }
    }
}
