using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI_DA5.Models
{
    public partial class Danhmucsanpham
    {
        public Danhmucsanpham()
        {
            Loaisanpham = new HashSet<Loaisanpham>();
        }

        [Key]
        [StringLength(5)]
        public string Madanhmuc { get; set; }
        [StringLength(30)]
        public string Tendanhmuc { get; set; }
        [StringLength(20)]
        public string Mota { get; set; }

        [InverseProperty("MadanhmucNavigation")]
        public virtual ICollection<Loaisanpham> Loaisanpham { get; set; }
    }
}
