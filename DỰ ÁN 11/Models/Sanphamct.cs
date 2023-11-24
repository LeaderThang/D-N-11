using System;
using System.Collections.Generic;

namespace DỰ_ÁN_11.Models
{
    public partial class Sanphamct
    {
        public Sanphamct()
        {
            Hoadoncts = new HashSet<Hoadonct>();
        }

        public int Id { get; set; }
        public string Maspct { get; set; } = null!;
        public string Mamau { get; set; } = null!;
        public string Masp { get; set; } = null!;
        public string Maram { get; set; } = null!;
        public string Mansx { get; set; } = null!;
        public DateTime? Ngaynhap { get; set; }
        public int? Soluong { get; set; }
        public double? Gianhap { get; set; }

        public virtual Mausac MamauNavigation { get; set; } = null!;
        public virtual Noisanxuat MansxNavigation { get; set; } = null!;
        public virtual Ram MaramNavigation { get; set; } = null!;
        public virtual Sanpham MaspNavigation { get; set; } = null!;
        public virtual ICollection<Hoadonct> Hoadoncts { get; set; }
    }
}
