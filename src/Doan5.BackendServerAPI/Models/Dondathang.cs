using System;
using System.Collections.Generic;

namespace Doan5.BackendServerAPI.Models
{
    public partial class Dondathang
    {
        public Dondathang()
        {
            Chitietdondathang = new HashSet<Chitietdondathang>();
        }

        public string Madondathang { get; set; }
        public string Makhachhang { get; set; }
        public string Manhanvien { get; set; }
        public DateTime? Ngaydat { get; set; }
        public string Tenkhachhang { get; set; }
        public string Trangthai { get; set; }
        public string Diachinhanhang { get; set; }
        public int? Sodienthoai { get; set; }
        public string Ghichu { get; set; }
        public int? Thanhtien { get; set; }

        public virtual Khachhang MakhachhangNavigation { get; set; }
        public virtual Nhanvien ManhanvienNavigation { get; set; }
        public virtual ICollection<Chitietdondathang> Chitietdondathang { get; set; }
    }
}
