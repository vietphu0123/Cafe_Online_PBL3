using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An2
{
    public class Local_Store
    {
        public Local_Store()
        {
            this.Manager = new HashSet<Managers>();
        }
        [Key]
        public int id_Local_Store { get; set; }
        public string Name  { get; set; }
        public string Dia_Chi { get; set; }
        public string SDT { get; set; }
        
       
        public virtual ICollection< Managers> Manager { get; set; }



    }
}
