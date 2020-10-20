using System;
using System.Collections.Generic;

namespace Doan5.BackendServerAPI.Models
{
    public partial class Nhacungcap
    {
        public Nhacungcap()
        {
            Hoadon = new HashSet<Hoadon>();
        }

        public string Manhacungcap { get; set; }
        public string Tennhacungcap { get; set; }
        public string Diachi { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Hoadon> Hoadon { get; set; }
    }
}
