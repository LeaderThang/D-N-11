using System;
using System.Collections.Generic;

namespace DỰ_ÁN_11.Models
{
    public partial class Ram
    {
        public Ram()
        {
            Sanphamcts = new HashSet<Sanphamct>();
        }

        public string Maram { get; set; } = null!;
        public string Loairam { get; set; } = null!;

        public virtual ICollection<Sanphamct> Sanphamcts { get; set; }
    }
}
