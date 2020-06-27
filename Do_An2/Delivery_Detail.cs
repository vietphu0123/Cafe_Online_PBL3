using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An2
{
   
    public partial class Delivery_Detail : Form
    {
        int id_Order;
        public Delivery_Detail(int id_order)
        {
            id_Order = id_order;
            InitializeComponent();
            load_data(id_Order);
        }
        public void load_data(int id_Order)
        {
            Model1 db = new Model1();
            List<Cart> Cart = new List<Cart>();
            double ThanhTien = 0;
            foreach (Order_detail i in db.Order_Detail)
            {
                if (i.id_Order == id_Order)
                {
                    string Name = "";
                    double total = 0;
                    foreach (Drink p in db.Drink)
                    {
                        if (i.id_Name_SP == p.id_Drink)
                        {
                            Name = p.name;
                        }
                    }
                    foreach (ThanhTien q in db.ThanhTien)
                    {
                        if (i.id == q.id_Order_Detail)
                        {
                            total = q.Total;
                        }
                    }
                    Cart.Add(new Cart
                    {
                        Id = i.id,
                        NameSp = Name,
                        SoLuong = Convert.ToInt32(i.So_Luong.ToString()),
                        Tien = total,
                    });
                }
            }
            foreach(Cart i in Cart)
            {
                ThanhTien += i.Tien;
            }
            textBox1.Text = ThanhTien.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
