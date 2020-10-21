using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI_DA5.Models
{
    public partial class Khuyenmai
    {
        [Key]
        [StringLength(5)]
        public string Makhuyenmai { get; set; }
        [StringLength(50)]
        public string Tenkhuyenmai { get; set; }
        [StringLength(20)]
        public string Magiamgia { get; set; }
        public int? Soluong { get; set; }
        [StringLength(20)]
        public string Tinhnangma { get; set; }
        public int? Giakhuyenmai { get; set; }
        [StringLength(20)]
        public string Thoigianbatdau { get; set; }
        [StringLength(20)]
        public string Thoigianketthuc { get; set; }
    }
}
