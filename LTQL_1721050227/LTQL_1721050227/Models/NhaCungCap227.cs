using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace LTQL_1721050227.Models
{
    public class NhaCungCap227
    {
        [Key]
        [Display(Name = "Mã Nhà Cung Cấp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaNhaCungcap { get; set; }
        [Display(Name = "Tên Nhà Cung Cấp")]
        [StringLength(50)]
        public string TenNhaCungCap { get; set; }
        public ICollection<NTTHSanPham227> NTTHSanPham227s { get; set; }
    }
}