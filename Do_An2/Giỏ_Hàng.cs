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
    public partial class Giỏ_Hàng : Form
    {
        List<Cart> lca = new List<Cart>();
        int id_TaiKhoan;
        int id_Store;
        public Giỏ_Hàng(List<Cart> list,int id_t,int id_s)
        {
            id_TaiKhoan = id_t;
            id_Store = id_s;
            lca = list;
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lca;
            double total = 0;
            foreach (Cart i in lca)
            {
                total += i.Tien;
            }
            textBox6.Text = total.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            DateTime now =  DateTime.Now;
            int id_User=0;
            foreach (User i in db.User)
            {
                if (i.idTaiKhoan == id_TaiKhoan)
                {
                    id_User = i.id_Name_User;
                }
            }

            db.Order.Add(new Order
            {
                Name = textBox3.Text.ToString(),
                SDT_Nhan = textBox4.Text.ToString(),
                Dia_Chi = textBox2.Text.ToString(),
                Ngay_Dat = now,
                Status = "No",
                FeedBach = textBox5.Text.ToString(),
                id_Name_User = id_User,
                id_Local_Store = id_Store,

            });
            db.SaveChanges();


            foreach (Cart i in lca)
            {
                db.Order_Detail.Add(new Order_detail{
                    id_Name_SP=i.Id,
                    So_Luong=i.SoLuong,
                    id_Order= db.Order.Max(p => p.id_Order),

            });

                
            }
            db.SaveChanges();

            foreach(Order_detail i in db.Order_Detail)
            {
                double total = 0;
                foreach(Drink j in db.Drink)
                {
                    if(i.id_Name_SP==j.id_Drink)
                    {
                        total = j.price * Convert.ToDouble(i.So_Luong);
                        db.ThanhTien.Add(new ThanhTien
                        {
                            id_Order_Detail = i.id,
                            Total=total,
                        });
                    }
                }
                
            }
            db.SaveChanges();
            MessageBox.Show("đã thêm thành công");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Dispose();
            this.Close();
        }
    }
}
