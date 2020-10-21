using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI_DA5.Models
{
    public partial class Chitiethoadon
    {
        [Key]
        [StringLength(5)]
        public string Machitiethoadon { get; set; }
        [StringLength(5)]
        public string Mahoadon { get; set; }
        [StringLength(5)]
        public string Masanpham { get; set; }
        public int? Soluong { get; set; }
        public int? Dongia { get; set; }

        [ForeignKey(nameof(Mahoadon))]
        [InverseProperty(nameof(Hoadon.Chitiethoadon))]
        public virtual Hoadon MahoadonNavigation { get; set; }
        [ForeignKey(nameof(Masanpham))]
        [InverseProperty(nameof(Sanpham.Chitiethoadon))]
        public virtual Sanpham MasanphamNavigation { get; set; }
    }
}
