using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An2
{
    [Table("NGUYENLIEU")]
    public class NGUYENLIEU
    {
        [Key]
        public string IdNguyenLieu { set; get; }
        public string TenNguyenLieu { set; get; }
        public string DonViTinh { set; get; }
        public virtual ICollection<NHACUNGCAP> NhaCungCap { set; get; }
    }
}
