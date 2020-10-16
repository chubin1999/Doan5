using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Doan5.BackendServerAPI.Data.Entities
{
    //để đặt tên cho entities biết gien ra cái bảng tên gì
    [Table("Danhmucsanphams")]
    public class Danhmucsanpham
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Madanhmuc { get; set; }

        [MaxLength(30)]
        [Column(TypeName = "nvarchar(30)")]
        public string Tendanhmuc { get; set; }

        [MaxLength(20)]
        [Column(TypeName = "nvarchar(20)")]
        public string Mota { get; set; }

        public virtual IEnumerable<Loaisanpham> Loaisanphams { get; set; }
    }
}
