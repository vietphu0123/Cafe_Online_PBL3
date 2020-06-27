using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An2
{
    public class Order
    {
        public Order()
        {
            this.Order_detail = new HashSet<Order_detail>();
        }
       
        [Key]
        public int id_Order { get; set; }
        public string Name { get; set; }
        public string SDT_Nhan { get; set; }
        public string Dia_Chi { get; set; }        
        public DateTime Ngay_Dat { get; set; }
        public string Status { get; set; }
        public string FeedBach { get; set; }
        public System.Nullable<int> id_Local_Store { get; set; }
        public System.Nullable<int> id_Name_User { get; set; }
        [ForeignKey("id_Name_User")]
        public virtual User User { get; set; }
        public virtual ICollection<Order_detail> Order_detail { get; set; }



    }
}
