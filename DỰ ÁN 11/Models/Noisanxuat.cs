using System;
using System.Collections.Generic;

namespace DỰ_ÁN_11.Models
{
    public partial class Noisanxuat
    {
        public Noisanxuat()
        {
            Sanphamcts = new HashSet<Sanphamct>();
        }

        public string Mansx { get; set; } = null!;
        public string Noisanxuat1 { get; set; } = null!;

        public virtual ICollection<Sanphamct> Sanphamcts { get; set; }
    }
}
