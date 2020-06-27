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
    public partial class QuanLyOrder : Form
    {
        int id_order;
        public QuanLyOrder()
        {            
            InitializeComponent();
            menu();
        }
        private void menu()
        {

            Model1 db = new Model1();
            foreach (Local_Store i in db.Local_Store)
            {
                Button But = new Button();
                But.Name = string.Format(i.Name.ToString());
                But.Tag = string.Format(i.id_Local_Store.ToString());
                But.Text = string.Format(i.Name.ToString());
                But.Size = new Size(197, 50);
                flowLayoutPanel2.Controls.Add(But);
                But.Click += new EventHandler(But_Click);
            }
        }
        private void But_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            List<Order> temp = new List<Order>();
            foreach (Order i in db.Order)
            {
                if (i.id_Local_Store.ToString() == ((Button)sender).Tag.ToString())
                {
                    temp.Add(i);
                }
            }
            var l = temp.Select(p => new { p.id_Order, p.Name, p.SDT_Nhan, p.Ngay_Dat, p.Dia_Chi, p.FeedBach,p.Status });
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = l.ToList();
        }
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Model1 db = new Model1();
            List<Cart> Cart = new List<Cart>();
            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
            if (r.Count == 1)
            {
                foreach (Order_detail i in db.Order_Detail)
                {
                    if (i.id_Order == Convert.ToInt32(r[0].Cells[0].Value))
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
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Cart;
        }
    }
}
