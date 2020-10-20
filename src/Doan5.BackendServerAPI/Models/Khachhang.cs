using System;
using System.Collections.Generic;

namespace Doan5.BackendServerAPI.Models
{
    public partial class Khachhang
    {
        public Khachhang()
        {
            Binhluan = new HashSet<Binhluan>();
            Dondathang = new HashSet<Dondathang>();
        }

        public string Makhachhang { get; set; }
        public string Hoten { get; set; }
        public string Diachi { get; set; }
        public string Email { get; set; }
        public int? Sdt { get; set; }
        public string Taikhoan { get; set; }
        public string Matkhau { get; set; }

        public virtual ICollection<Binhluan> Binhluan { get; set; }
        public virtual ICollection<Dondathang> Dondathang { get; set; }
    }
}
