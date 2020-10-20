using System;
using System.Collections.Generic;

namespace Doan5.BackendServerAPI.Models
{
    public partial class Danhmucsanpham
    {
        public Danhmucsanpham()
        {
            Loaisanpham = new HashSet<Loaisanpham>();
        }

        public string Madanhmuc { get; set; }
        public string Tendanhmuc { get; set; }
        public string Mota { get; set; }

        public virtual ICollection<Loaisanpham> Loaisanpham { get; set; }
    }
}
