using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An2
{
    
        [Table("NHACUNGCAP")]
        public class NHACUNGCAP
        {
            [Key, Column(Order = 0)]
            public string IdNhaCungCap { set; get; }
            public string TenNhaCungCap { set; get; }
            public string DiaChi { set; get; }
            public string SoDienThoai { set; get; }
            [Key, Column(Order = 1)]
            public string IdNguyenLieu { set; get; }
            [ForeignKey("IdNguyenLieu")]
            public virtual NGUYENLIEU NguyenLieu { set; get; }
            public double Gia { set; get; }
            public DateTime NgayDangKy { set; get; }
            public List<DONDATNGUYENLIEU> DonDatNguyenLieu { set; get; }

        

    }
}
