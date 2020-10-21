using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI_DA5.Models
{
    public partial class Hoadon
    {
        public Hoadon()
        {
            Chitiethoadon = new HashSet<Chitiethoadon>();
        }

        [Key]
        [StringLength(5)]
        public string Mahoadon { get; set; }
        [StringLength(5)]
        public string Manhanvien { get; set; }
        [StringLength(5)]
        public string Manhacungcap { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Ngaynhap { get; set; }
        public int? Thanhtien { get; set; }

        [ForeignKey(nameof(Manhacungcap))]
        [InverseProperty(nameof(Nhacungcap.Hoadon))]
        public virtual Nhacungcap ManhacungcapNavigation { get; set; }
        [ForeignKey(nameof(Manhanvien))]
        [InverseProperty(nameof(Nhanvien.Hoadon))]
        public virtual Nhanvien ManhanvienNavigation { get; set; }
        [InverseProperty("MahoadonNavigation")]
        public virtual ICollection<Chitiethoadon> Chitiethoadon { get; set; }
    }
}
