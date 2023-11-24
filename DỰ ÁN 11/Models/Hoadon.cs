using System;
using System.Collections.Generic;

namespace DỰ_ÁN_11.Models
{
    public partial class Hoadon
    {
        public Hoadon()
        {
            Hoadoncts = new HashSet<Hoadonct>();
        }

        public string Mahd { get; set; } = null!;
        public string Manv { get; set; } = null!;

        public virtual Nhanvien ManvNavigation { get; set; } = null!;
        public virtual ICollection<Hoadonct> Hoadoncts { get; set; }
    }
}
