using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI_DA5.Models
{
    public partial class Sanpham
    {
        public Sanpham()
        {
            Binhluan = new HashSet<Binhluan>();
            Chitietdondathang = new HashSet<Chitietdondathang>();
            Chitiethoadon = new HashSet<Chitiethoadon>();
        }

        [Key]
        [StringLength(5)]
        public string Masanpham { get; set; }
        [StringLength(5)]
        public string Maloai { get; set; }
        [StringLength(5)]
        public string Mahang { get; set; }
        [StringLength(50)]
        public string Tensanpham { get; set; }
        public int? Dongia { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Ngaycapnhat { get; set; }
        public int? Soluong { get; set; }
        [StringLength(50)]
        public string Hansudung { get; set; }
        [StringLength(4000)]
        public string Mota { get; set; }
        [StringLength(4000)]
        public string Hinhanh { get; set; }
        [StringLength(30)]
        public string Trongluong { get; set; }
        [StringLength(20)]
        public string Xuatxu { get; set; }

        [ForeignKey(nameof(Mahang))]
        [InverseProperty(nameof(Hangsanxuat.Sanpham))]
        public virtual Hangsanxuat MahangNavigation { get; set; }
        [ForeignKey(nameof(Maloai))]
        [InverseProperty(nameof(Loaisanpham.Sanpham))]
        public virtual Loaisanpham MaloaiNavigation { get; set; }
        [InverseProperty("MasanphamNavigation")]
        public virtual ICollection<Binhluan> Binhluan { get; set; }
        [InverseProperty("MasanphamNavigation")]
        public virtual ICollection<Chitietdondathang> Chitietdondathang { get; set; }
        [InverseProperty("MasanphamNavigation")]
        public virtual ICollection<Chitiethoadon> Chitiethoadon { get; set; }
    }
}
