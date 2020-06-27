using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An2
{
    public class Managers
    {
        
        [Key]
        public int idManager { get; set; }
        public string Name { get; set; }
        public string SDT { get; set; }
        public string CMND { get; set; }
        public string Dia_Chi { get; set; }
        [Column(TypeName = "Date")]
        public System.Nullable<DateTime> Ngay_Vo_Lam { get; set; }
        [Column(TypeName = "Date")]
        public System.Nullable<DateTime> Ngay_Sinh { get; set; }
        public System.Nullable<bool> Gioi_Tinh { get; set; }
        public int id_Local_Store { get; set; }
        [Index(IsUnique = true)]
        public int idTaiKhoan { get; set; }
        [ForeignKey("idTaiKhoan")]
        public virtual TaiKhoan TaiKhoan { get; set; }
        [ForeignKey("id_Local_Store")]
        public virtual Local_Store Local_Store { get; set; }

    }
}
