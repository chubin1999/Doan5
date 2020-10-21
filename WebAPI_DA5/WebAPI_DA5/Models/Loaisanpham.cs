using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI_DA5.Models
{
    public partial class Loaisanpham
    {
        public Loaisanpham()
        {
            Sanpham = new HashSet<Sanpham>();
        }

        [Key]
        [StringLength(5)]
        public string Maloai { get; set; }
        [StringLength(5)]
        public string Madanhmuc { get; set; }
        [StringLength(50)]
        public string Tenloai { get; set; }
        [StringLength(50)]
        public string Mota { get; set; }

        [ForeignKey(nameof(Madanhmuc))]
        [InverseProperty(nameof(Danhmucsanpham.Loaisanpham))]
        public virtual Danhmucsanpham MadanhmucNavigation { get; set; }
        [InverseProperty("MaloaiNavigation")]
        public virtual ICollection<Sanpham> Sanpham { get; set; }
    }
}
