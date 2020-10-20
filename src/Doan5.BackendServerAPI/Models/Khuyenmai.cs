using System;
using System.Collections.Generic;

namespace Doan5.BackendServerAPI.Models
{
    public partial class Khuyenmai
    {
        public string Makhuyenmai { get; set; }
        public string Tenkhuyenmai { get; set; }
        public string Magiamgia { get; set; }
        public int? Soluong { get; set; }
        public string Tinhnangma { get; set; }
        public int? Giakhuyenmai { get; set; }
        public string Thoigianbatdau { get; set; }
        public string Thoigianketthuc { get; set; }
    }
}
