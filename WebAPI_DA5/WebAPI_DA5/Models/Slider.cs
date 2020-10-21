using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI_DA5.Models
{
    public partial class Slider
    {
        [Key]
        [StringLength(5)]
        public string Maslider { get; set; }
        [StringLength(50)]
        public string Tenslider { get; set; }
        [StringLength(1000)]
        public string Hinhanh { get; set; }
        [StringLength(100)]
        public string Mota { get; set; }
    }
}
