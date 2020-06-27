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
    public partial class QuanLyMenu : Form
    {
        public QuanLyMenu()
        {
            InitializeComponent();
            Model1 db = new Model1();
            dataGridView1.DataSource = db.Category.ToList();
            var list = db.Drink.Select(p => new { p.name, p.price, p.Category.Name_Category });
            dataGridView2.DataSource = list.ToList();

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnAddC_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            ThemLoai f = new ThemLoai();
            f.ShowDialog();
            db.Category.Add(new Category { Name_Category = ThemLoai.luuthongtin.NameC.ToString() });
            db.SaveChanges();
            dataGridView1.DataSource = db.Category.ToList();

        }

        private void btnDelC_Click(object sender, EventArgs e)
        {

            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
            Model1 db = new Model1();
            //list
            string name = r[0].Cells["Name_Category"].Value.ToString();
            MessageBox.Show(name);
            foreach (Category i in db.Category)
            {
                if (String.Compare(name, i.Name_Category.ToString(), true) == 0)
                {
                    MessageBox.Show("aa");
                    db.Category.Remove(i);
                }
            }
            db.SaveChanges();
            dataGridView1.DataSource = db.Category.ToList();
        }

        private void btnAddD_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            ThemDoUong f3 = new ThemDoUong();
            f3.ShowDialog();
            try
            {
                db.Drink.Add(new Drink
                {
                    name = ThemDoUong.luuthongtin.NameD.ToString(),
                    price = (double)Convert.ToInt32(ThemDoUong.luuthongtin.PriceD.ToString()),
                    id_Category = ThemDoUong.luuthongtin.idC
                });

            }
            catch (Exception E)
            {
                MessageBox.Show("chưa có thông tin");
            }
            db.SaveChanges();
            var list = db.Drink.Select(p => new { p.name, p.price, p.Category.Name_Category });
            dataGridView2.DataSource = list.ToList();


        }

        private void btnUpD_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dataGridView2.SelectedRows;
            Model1 db = new Model1();
            if (r.Count == 1)
            {
                foreach (Drink i in db.Drink)
                {
                    if (String.Compare(i.name.ToString(), r[0].Cells[0].Value.ToString(), false) == 0)
                    {

                        UpdateDoUong f4 = new UpdateDoUong(i.id_Drink);
                        f4.ShowDialog();
                    }
                }

            }





        }

    }
}