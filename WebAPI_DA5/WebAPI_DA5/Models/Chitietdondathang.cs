using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI_DA5.Models
{
    public partial class Chitietdondathang
    {
        [Key]
        [StringLength(5)]
        public string Machitietdondathang { get; set; }
        [StringLength(5)]
        public string Madondathang { get; set; }
        [StringLength(5)]
        public string Masanpham { get; set; }
        [StringLength(50)]
        public string Tensanpham { get; set; }
        public int? Soluong { get; set; }
        public int? Dongia { get; set; }
        [StringLength(50)]
        public string Giamgia { get; set; }

        [ForeignKey(nameof(Madondathang))]
        [InverseProperty(nameof(Dondathang.Chitietdondathang))]
        public virtual Dondathang MadondathangNavigation { get; set; }
        [ForeignKey(nameof(Masanpham))]
        [InverseProperty(nameof(Sanpham.Chitietdondathang))]
        public virtual Sanpham MasanphamNavigation { get; set; }
    }
}
