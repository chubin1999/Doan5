using System;
using System.Collections.Generic;

namespace Doan5.BackendServerAPI.Models
{
    public partial class Tintuc
    {
        public string Matintuc { get; set; }
        public string Tieude { get; set; }
        public string Mota { get; set; }
        public string Noidung { get; set; }
        public string Anh { get; set; }
        public DateTime? Ngaydang { get; set; }
        public string Nguoidang { get; set; }
    }
}
