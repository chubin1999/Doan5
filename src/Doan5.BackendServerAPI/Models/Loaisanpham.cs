using System;
using System.Collections.Generic;

namespace Doan5.BackendServerAPI.Models
{
    public partial class Loaisanpham
    {
        public Loaisanpham()
        {
            Sanpham = new HashSet<Sanpham>();
        }

        public string Maloai { get; set; }
        public string Madanhmuc { get; set; }
        public string Tenloai { get; set; }
        public string Mota { get; set; }

        public virtual Danhmucsanpham MadanhmucNavigation { get; set; }
        public virtual ICollection<Sanpham> Sanpham { get; set; }
    }
}
