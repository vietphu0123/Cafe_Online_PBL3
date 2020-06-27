using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An2
{
    public class Drink
    {
        public Drink()
        {
            this.Order_Detail = new HashSet<Order_detail>();
        }
        [Key]
        public int id_Drink { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public int id_Category { get; set; }
        [ForeignKey("id_Category")]
        public virtual Category Category { get; set; }
        public virtual ICollection<Order_detail> Order_Detail { get; set; }


    }
}
