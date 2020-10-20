using System;
using System.Collections.Generic;

namespace Doan5.BackendServerAPI.Models
{
    public partial class Sanpham
    {
        public Sanpham()
        {
            Binhluan = new HashSet<Binhluan>();
            Chitietdondathang = new HashSet<Chitietdondathang>();
            Chitiethoadon = new HashSet<Chitiethoadon>();
        }

        public string Masanpham { get; set; }
        public string Maloai { get; set; }
        public string Mahang { get; set; }
        public string Tensanpham { get; set; }
        public int? Dongia { get; set; }
        public DateTime? Ngaycapnhat { get; set; }
        public int? Soluong { get; set; }
        public string Hansudung { get; set; }
        public string Mota { get; set; }
        public string Hinhanh { get; set; }
        public string Trongluong { get; set; }
        public string Xuatxu { get; set; }

        public virtual Hangsanxuat MahangNavigation { get; set; }
        public virtual Loaisanpham MaloaiNavigation { get; set; }
        public virtual ICollection<Binhluan> Binhluan { get; set; }
        public virtual ICollection<Chitietdondathang> Chitietdondathang { get; set; }
        public virtual ICollection<Chitiethoadon> Chitiethoadon { get; set; }
    }
}
