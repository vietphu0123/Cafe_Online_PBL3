using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An2
{
    [Table("DONDATNGUYENLIEU")]
    public class DONDATNGUYENLIEU
    {
        [Key, Column(Order = 0)]
        public string IdDonDatNguyenLieu { set; get; }
        [Key, Column(Order = 1)]
        public int idManager { set; get; }
        [ForeignKey("idManager")]
        public virtual Managers Manager { set; get; }
        [Key, Column(Order = 2)]
        public string IdNhaCungCap { set; get; }
        //[ForeignKey("IdNhaCungCap"), Column(Order = 0)]            
        //public virtual NHACUNGCAP NhaCungCap { set; get; }
        [Key, Column(Order = 3)]
        public string IdNguyenLieu { set; get; }
        //[ForeignKey("IdNguyenLieu"), Column(Order = 1)]
        //[InverseProperty("DonDatNguyenLieu_key2")]
        //public virtual NHACUNGCAP NhaCungCap2 { set; get; }
        public string SoLuong { set; get; }
        public bool TrangThai { set; get; }
        public DateTime NgayDatHang { set; get; }
        public int ThoiHan { set; get; }

    }
}
