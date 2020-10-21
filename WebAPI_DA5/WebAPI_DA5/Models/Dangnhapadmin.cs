using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI_DA5.Models
{
    public partial class Dangnhapadmin
    {
        [Key]
        [StringLength(5)]
        public string Maadmin { get; set; }
        [StringLength(50)]
        public string Taikhoanadmin { get; set; }
        [StringLength(50)]
        public string Matkhauadmin { get; set; }
        [StringLength(50)]
        public string Tenadmin { get; set; }
        public int? Sodienthoaiadmin { get; set; }
    }
}
