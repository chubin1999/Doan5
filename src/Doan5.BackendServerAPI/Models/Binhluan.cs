using System;
using System.Collections.Generic;

namespace Doan5.BackendServerAPI.Models
{
    public partial class Binhluan
    {
        public string Mabinhluan { get; set; }
        public string Makhachhang { get; set; }
        public string Masanpham { get; set; }
        public string Noidungbinhluan { get; set; }
        public string Danhgia { get; set; }
        public DateTime? Thoigian { get; set; }

        public virtual Khachhang MakhachhangNavigation { get; set; }
        public virtual Sanpham MasanphamNavigation { get; set; }
    }
}
