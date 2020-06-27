using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An2
{
    public class ThanhTien
    {

        [Key]
        public int id_ThanhTien { get; set; }
        public double Total { get; set; }
        public System.Nullable<int> id_Order_Detail { get; set; }
        [ForeignKey("id_Order_Detail")]
        public virtual Order_detail Order_Detail { get; set; }
    }
}
