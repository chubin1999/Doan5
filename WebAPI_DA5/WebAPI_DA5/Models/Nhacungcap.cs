using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI_DA5.Models
{
    public partial class Nhacungcap
    {
        public Nhacungcap()
        {
            Hoadon = new HashSet<Hoadon>();
        }

        [Key]
        [StringLength(5)]
        public string Manhacungcap { get; set; }
        [StringLength(50)]
        public string Tennhacungcap { get; set; }
        [StringLength(50)]
        public string Diachi { get; set; }
        [StringLength(50)]
        public string Email { get; set; }

        [InverseProperty("ManhacungcapNavigation")]
        public virtual ICollection<Hoadon> Hoadon { get; set; }
    }
}
