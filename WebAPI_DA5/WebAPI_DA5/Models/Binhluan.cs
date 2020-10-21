using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI_DA5.Models
{
    public partial class Binhluan
    {
        [Key]
        [StringLength(5)]
        public string Mabinhluan { get; set; }
        [StringLength(5)]
        public string Makhachhang { get; set; }
        [StringLength(5)]
        public string Masanpham { get; set; }
        [StringLength(100)]
        public string Noidungbinhluan { get; set; }
        [StringLength(10)]
        public string Danhgia { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Thoigian { get; set; }

        [ForeignKey(nameof(Makhachhang))]
        [InverseProperty(nameof(Khachhang.Binhluan))]
        public virtual Khachhang MakhachhangNavigation { get; set; }
        [ForeignKey(nameof(Masanpham))]
        [InverseProperty(nameof(Sanpham.Binhluan))]
        public virtual Sanpham MasanphamNavigation { get; set; }
    }
}
