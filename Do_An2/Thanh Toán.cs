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
    public partial class Thanh_Toán : Form
    {
        public delegate void load();
        private load _d;
        int id_Order;
        public load D { get => _d; set => _d = value; }
        public Thanh_Toán(int id_order)
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
            foreach (Cart i in Cart)
            {
                ThanhTien += i.Tien;
            }
            textBox1.Text = ThanhTien.ToString();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Cart;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            foreach(Order i in db.Order)
            {
                if(i.id_Order==id_Order)
                {
                    i.Status = "Null";
                }
            }
            db.SaveChanges();
            MessageBox.Show("đã in hóa đơn và giao hàng thành công");
            Xử_Lý_Giao_Hàng f = new Xử_Lý_Giao_Hàng(2);    
            D();
            this.Dispose();
            this.Close();

        }
    }
}
