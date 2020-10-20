using System;
using System.Collections.Generic;

namespace Doan5.BackendServerAPI.Models
{
    public partial class Chitiethoadon
    {
        public string Machitiethoadon { get; set; }
        public string Mahoadon { get; set; }
        public string Masanpham { get; set; }
        public int? Soluong { get; set; }
        public int? Dongia { get; set; }

        public virtual Hoadon MahoadonNavigation { get; set; }
        public virtual Sanpham MasanphamNavigation { get; set; }
    }
}
