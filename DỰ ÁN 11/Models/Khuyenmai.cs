using System;
using System.Collections.Generic;

namespace DỰ_ÁN_11.Models
{
    public partial class Khuyenmai
    {
        public Khuyenmai()
        {
            Hoadoncts = new HashSet<Hoadonct>();
        }

        public string Makm { get; set; } = null!;
        public string? Loaikm { get; set; }
        public string? Thongtinkm { get; set; }

        public virtual ICollection<Hoadonct> Hoadoncts { get; set; }
    }
}
