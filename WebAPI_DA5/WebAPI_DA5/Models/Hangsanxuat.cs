using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI_DA5.Models
{
    public partial class Hangsanxuat
    {
        public Hangsanxuat()
        {
            Sanpham = new HashSet<Sanpham>();
        }

        [Key]
        [StringLength(5)]
        public string Mahang { get; set; }
        [StringLength(50)]
        public string Tenhang { get; set; }
        [StringLength(50)]
        public string Mota { get; set; }

        [InverseProperty("MahangNavigation")]
        public virtual ICollection<Sanpham> Sanpham { get; set; }
    }
}
