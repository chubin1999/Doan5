using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI_DA5.Models
{
    public partial class Tintuc
    {
        [Key]
        [StringLength(5)]
        public string Matintuc { get; set; }
        [StringLength(50)]
        public string Tieude { get; set; }
        [StringLength(100)]
        public string Mota { get; set; }
        [StringLength(3000)]
        public string Noidung { get; set; }
        [StringLength(1000)]
        public string Anh { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Ngaydang { get; set; }
        [StringLength(50)]
        public string Nguoidang { get; set; }
    }
}
