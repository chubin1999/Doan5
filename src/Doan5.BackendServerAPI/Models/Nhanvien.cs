using System;
using System.Collections.Generic;

namespace Doan5.BackendServerAPI.Models
{
    public partial class Nhanvien
    {
        public Nhanvien()
        {
            Dondathang = new HashSet<Dondathang>();
            Hoadon = new HashSet<Hoadon>();
        }

        public string Manhanvien { get; set; }
        public string Tennhanvien { get; set; }
        public string Ngaysinh { get; set; }
        public string Quequan { get; set; }
        public int? Sochungminhthu { get; set; }
        public int? Sodienthoai { get; set; }
        public string Chucvu { get; set; }

        public virtual ICollection<Dondathang> Dondathang { get; set; }
        public virtual ICollection<Hoadon> Hoadon { get; set; }
    }
}
