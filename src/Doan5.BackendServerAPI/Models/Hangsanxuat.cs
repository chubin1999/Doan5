using System;
using System.Collections.Generic;

namespace Doan5.BackendServerAPI.Models
{
    public partial class Hangsanxuat
    {
        public Hangsanxuat()
        {
            Sanpham = new HashSet<Sanpham>();
        }

        public string Mahang { get; set; }
        public string Tenhang { get; set; }
        public string Mota { get; set; }

        public virtual ICollection<Sanpham> Sanpham { get; set; }
    }
}
