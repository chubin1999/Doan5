using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI_DA5.Models
{
    public partial class Nhanvien
    {
        public Nhanvien()
        {
            Dondathang = new HashSet<Dondathang>();
            Hoadon = new HashSet<Hoadon>();
        }

        [Key]
        [StringLength(5)]
        public string Manhanvien { get; set; }
        [StringLength(50)]
        public string Tennhanvien { get; set; }
        [StringLength(50)]
        public string Ngaysinh { get; set; }
        [StringLength(60)]
        public string Quequan { get; set; }
        public int? Sochungminhthu { get; set; }
        public int? Sodienthoai { get; set; }
        [StringLength(30)]
        public string Chucvu { get; set; }

        [InverseProperty("ManhanvienNavigation")]
        public virtual ICollection<Dondathang> Dondathang { get; set; }
        [InverseProperty("ManhanvienNavigation")]
        public virtual ICollection<Hoadon> Hoadon { get; set; }
    }
}
