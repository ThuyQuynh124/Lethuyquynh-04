using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Lethuyquynh_04.Models
{
    [Table("NhanViens")]
    public class NhanVien
    {
        [Key]
        [StringLength(50)]
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public int MaTinhThanh { get; set; }
        public virtual ICollection<TinhThanh> TinhThanhs { get; set; }

    }
}