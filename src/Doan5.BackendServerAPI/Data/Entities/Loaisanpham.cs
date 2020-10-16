using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Doan5.BackendServerAPI.Data.Entities
{
    [Table("Loaisanphams")]
    public class Loaisanpham
    {
        [Key]
        //Identity: Tăng dần
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Maloai { get; set; }

        public int Madanhmuc { get; set; }
        [ForeignKey ("Madanhmuc")]
        public virtual Danhmucsanpham Danhmucsanpham { get; set; }

        [MaxLength(50)]
        [Column(TypeName = "nvarchar(50)")]
        public string Tenloai { get; set; }

        [MaxLength(50)]
        [Column(TypeName = "nvarchar(50)")]
        public string Mota { get; set; }
       
    }
}
