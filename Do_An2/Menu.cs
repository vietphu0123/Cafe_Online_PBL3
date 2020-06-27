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
    public partial class Menu : Form
    {
        int id_TaiKhoan;
        int id_Store;
        public Menu(int id_t,int id_s)
        {
            id_TaiKhoan = id_t;
            id_Store = id_s;
            InitializeComponent();
            menu();
        }
        List<Cart> lt = new List<Cart>();
        private void menu()
        {

            Model1 db = new Model1();
            foreach (Category i in db.Category)
            {
                Button But = new Button();
                But.Name = string.Format(i.Name_Category.ToString());
                But.Tag = string.Format(i.id_Category.ToString());
                But.Text = string.Format(i.Name_Category.ToString());
                But.Size = new Size(197, 50);
                flowLayoutPanel1.Controls.Add(But);
                But.Click += new EventHandler(But_Click);
            }
        }
        private void But_Click(object sender, EventArgs e)
        {

            Model1 db = new Model1();
            flowLayoutPanel2.Controls.Clear();
            foreach (Drink i in db.Drink)
            {
                if (i.id_Category.ToString() == ((Button)sender).Tag.ToString())
                {
                    Button But = new Button();
                    But.Name = string.Format(i.name.ToString());
                    But.Tag = string.Format(i.id_Drink.ToString());
                    But.Text = string.Format(i.name.ToString());
                    But.Size = new Size(520, 50);
                    flowLayoutPanel2.Controls.Add(But);
                    But.Click += new EventHandler(But_Click1);
                }
            }
        }
        private void But_Click1(object sender, EventArgs e)
        {

            bool isEmpty = !lt.Any();
            bool check = false;
            if (isEmpty)
            {

                Model1 db = new Model1();
                double gia = 0;

                foreach (Drink j in db.Drink)
                {
                    if (j.id_Drink == Convert.ToInt32(((Button)sender).Tag))
                    {
                        gia = j.price;
                    }

                }
                lt.Add(new Cart
                {
                    Id = Convert.ToInt32(((Button)sender).Tag),
                    NameSp = ((Button)sender).Name.ToString(),
                    SoLuong = 1,
                    Tien = gia,
                });
                double total = 0;
                foreach (Cart i in lt)
                {
                    total += i.Tien;
                }
                textBox1.Text = total.ToString();
                dataGridView1.DataSource = null;
                var l = lt.Select(p => new { p.NameSp, p.SoLuong, p.Tien });
                dataGridView1.DataSource = l.ToList(); ;
            }
            else
            {
                Model1 db = new Model1();
                double gia = 0;
                foreach (Drink j in db.Drink)
                {

                    if (j.id_Drink == Convert.ToInt32(((Button)sender).Tag))
                    {
                        gia = j.price;
                    }

                }
                for (int i = 0; i <= lt.Count - 1; i++)
                {

                    if (String.Compare(lt[i].Id.ToString(), ((Button)sender).Tag.ToString(), true) == 0)
                    {
                        lt[i].SoLuong += 1;
                        lt[i].Tien = gia * lt[i].SoLuong;
                        check = true;
                    }

                }
                if (check == false)
                {


                    lt.Add(new Cart
                    {
                        Id = Convert.ToInt32(((Button)sender).Tag),          
                        NameSp = ((Button)sender).Name.ToString(),
                        SoLuong = 1,
                        Tien = gia,
                    });

                }
                double total = 0;
                foreach (Cart i in lt)
                {
                    total += i.Tien;
                }
                textBox1.Text = total.ToString();
                dataGridView1.DataSource = null;
                var l = lt.Select(p => new { p.NameSp, p.SoLuong, p.Tien });
                dataGridView1.DataSource = l.ToList(); ;
            }


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Giỏ_Hàng f = new Giỏ_Hàng(lt,id_TaiKhoan,id_Store);
            f.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
            if(r.Count==1)
            {
                for(int i=0;i<lt.Count;i++)
                
                {
                     if(String.Compare(r[0].Cells[0].Value.ToString(),lt[i].NameSp.ToString(),true)==0)
                     {


                        lt[i].Tien = lt[i].Tien / (Convert.ToDouble(lt[i].SoLuong));
                        lt[i].SoLuong -= 1;
                        lt[i].Tien = lt[i].Tien * lt[i].SoLuong;
                        if (lt[i].SoLuong == 0)
                        {
                            lt.Remove(lt[i]);
                        }


                    }
                    
                }
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
            if (r.Count == 1)
            {
                foreach (Cart i in lt)
                {
                    if (String.Compare(r[0].Cells[0].Value.ToString(), i.NameSp.ToString(), true) == 0)
                    {
                        
                            i.Tien=i.Tien/(Convert.ToDouble(i.SoLuong));
                            i.SoLuong += 1;
                            i.Tien = i.Tien * i.SoLuong;
                        
                        
                    }

                }
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login_User f = new Login_User(id_TaiKhoan);
            this.Hide();
            f.ShowDialog();
            this.Dispose();
            this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
