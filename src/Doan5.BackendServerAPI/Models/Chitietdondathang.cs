using System;
using System.Collections.Generic;

namespace Doan5.BackendServerAPI.Models
{
    public partial class Chitietdondathang
    {
        public string Machitietdondathang { get; set; }
        public string Madondathang { get; set; }
        public string Masanpham { get; set; }
        public string Tensanpham { get; set; }
        public int? Soluong { get; set; }
        public int? Dongia { get; set; }
        public string Giamgia { get; set; }

        public virtual Dondathang MadondathangNavigation { get; set; }
        public virtual Sanpham MasanphamNavigation { get; set; }
    }
}
