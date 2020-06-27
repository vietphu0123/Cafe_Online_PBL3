    using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An2
{
    class CreateDB : CreateDatabaseIfNotExists<Model1>
    {
        protected override void Seed(Model1 context)
        {
            
            context.Order.Add(new Order
            {
                id_Order = 1,
                Name = "phu",
                SDT_Nhan = "000000111",
                Dia_Chi = "AAA",
                Ngay_Dat = new DateTime(2000, 12, 12, 12, 1, 10),
                Status = "ROI",
                FeedBach = "NULL",
                
            });

        }
    }
}
