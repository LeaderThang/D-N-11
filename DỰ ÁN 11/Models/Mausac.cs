using System;
using System.Collections.Generic;

namespace DỰ_ÁN_11.Models
{
    public partial class Mausac
    {
        public Mausac()
        {
            Sanphamcts = new HashSet<Sanphamct>();
        }

        public string Mamau { get; set; } = null!;
        public string Tenmau { get; set; } = null!;

        public virtual ICollection<Sanphamct> Sanphamcts { get; set; }
    }
}
