using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An2
{
    public class Category
    {
        public Category()
        {
            this.Drink = new HashSet<Drink>();
        }
        [Key]
        public int id_Category { get; set; }
        public string Name_Category { get; set; }
        public virtual ICollection<Drink> Drink { get; set; }
    }
}
