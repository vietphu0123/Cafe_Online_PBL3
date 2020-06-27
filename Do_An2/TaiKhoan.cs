using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An2
{
    public class TaiKhoan
    {
        public TaiKhoan()
        {
            this.User = new HashSet<User>();
            this.Manager = new HashSet<Managers>();
        }
        [Key]
        public int idTaiKhoan { get; set; }
        public string TenTaiKhoan { get; set; }
        public string pass { get; set; }
        public string LoaiTK { get; set; }
        public virtual ICollection<Managers> Manager { get; set; }
        public virtual ICollection<User> User { get; set; }
    }
}
