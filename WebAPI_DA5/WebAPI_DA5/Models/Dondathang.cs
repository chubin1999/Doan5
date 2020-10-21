using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI_DA5.Models
{
    public partial class Dondathang
    {
        public Dondathang()
        {
            Chitietdondathang = new HashSet<Chitietdondathang>();
        }

        [Key]
        [StringLength(5)]
        public string Madondathang { get; set; }
        [StringLength(5)]
        public string Makhachhang { get; set; }
        [StringLength(5)]
        public string Manhanvien { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Ngaydat { get; set; }
        [StringLength(50)]
        public string Tenkhachhang { get; set; }
        [StringLength(10)]
        public string Trangthai { get; set; }
        [StringLength(50)]
        public string Diachinhanhang { get; set; }
        public int? Sodienthoai { get; set; }
        [StringLength(50)]
        public string Ghichu { get; set; }
        public int? Thanhtien { get; set; }

        [ForeignKey(nameof(Makhachhang))]
        [InverseProperty(nameof(Khachhang.Dondathang))]
        public virtual Khachhang MakhachhangNavigation { get; set; }
        [ForeignKey(nameof(Manhanvien))]
        [InverseProperty(nameof(Nhanvien.Dondathang))]
        public virtual Nhanvien ManhanvienNavigation { get; set; }
        [InverseProperty("MadondathangNavigation")]
        public virtual ICollection<Chitietdondathang> Chitietdondathang { get; set; }
    }
}
