using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An2
{
    public class Order_detail
    {
        public Order_detail()
        {
            this.ThanhTien = new HashSet<ThanhTien>();
            this.Order = new HashSet<Order>();


        }
        [Key]
        public int id { get; set; }
        public System.Nullable<int> id_Name_SP { get; set; }
        public System.Nullable<int> So_Luong { get; set; }
        public System.Nullable<int> id_Order { get; set; }               
        [ForeignKey("id_Name_SP")]
        public virtual Drink Drink { get; set; }
        [ForeignKey("id_Order")]
        public virtual ICollection<Order> Order { get; set; }
        public virtual ICollection<ThanhTien> ThanhTien { get; set; }

    }
}
