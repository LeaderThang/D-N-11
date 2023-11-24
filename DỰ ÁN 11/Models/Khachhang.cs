using System;
using System.Collections.Generic;

namespace DỰ_ÁN_11.Models
{
    public partial class Khachhang
    {
        public Khachhang()
        {
            Hoadoncts = new HashSet<Hoadonct>();
        }

        public int Idkh { get; set; }
        public string Makh { get; set; } = null!;
        public string Tenkh { get; set; } = null!;
        public DateTime? Ngaysinh { get; set; }
        public int? Sdt { get; set; }
        public string? Diachi { get; set; }
        public string? Email { get; set; }

        public virtual ICollection<Hoadonct> Hoadoncts { get; set; }
    }
}
