using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI_DA5.Models
{
    public partial class Khachhang
    {
        public Khachhang()
        {
            Binhluan = new HashSet<Binhluan>();
            Dondathang = new HashSet<Dondathang>();
        }

        [Key]
        [StringLength(5)]
        public string Makhachhang { get; set; }
        [StringLength(50)]
        public string Hoten { get; set; }
        [StringLength(50)]
        public string Diachi { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        public int? Sdt { get; set; }
        [StringLength(50)]
        public string Taikhoan { get; set; }
        [StringLength(50)]
        public string Matkhau { get; set; }

        [InverseProperty("MakhachhangNavigation")]
        public virtual ICollection<Binhluan> Binhluan { get; set; }
        [InverseProperty("MakhachhangNavigation")]
        public virtual ICollection<Dondathang> Dondathang { get; set; }
    }
}
