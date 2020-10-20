using System;
using System.Collections.Generic;

namespace Doan5.BackendServerAPI.Models
{
    public partial class Hoadon
    {
        public Hoadon()
        {
            Chitiethoadon = new HashSet<Chitiethoadon>();
        }

        public string Mahoadon { get; set; }
        public string Manhanvien { get; set; }
        public string Manhacungcap { get; set; }
        public DateTime? Ngaynhap { get; set; }
        public int? Thanhtien { get; set; }

        public virtual Nhacungcap ManhacungcapNavigation { get; set; }
        public virtual Nhanvien ManhanvienNavigation { get; set; }
        public virtual ICollection<Chitiethoadon> Chitiethoadon { get; set; }
    }
}
