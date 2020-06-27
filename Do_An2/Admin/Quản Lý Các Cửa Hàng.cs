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
    public partial class Quản_Lý_Các_Cửa_Hàng : Form
    {
        public Quản_Lý_Các_Cửa_Hàng()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thêm_Cửa_Hàng f = new Thêm_Cửa_Hàng();
            f.Show1 += new Thêm_Cửa_Hàng.show(show);
            f.ShowDialog();
           
        }
        public void show ()
        {
            Model1 db = new Model1();
            var list = db.Local_Store.Select(p => new { p.id_Local_Store, p.Name,p.Dia_Chi, p.SDT });
            dataGridView1.DataSource = list.ToList();
        }

        private void Quản_Lý_Các_Cửa_Hàng_Load(object sender, EventArgs e)
        {
            show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            
            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
            bool check = false;
            Model1 db = new Model1();
            if (r.Count == 1)
            {
                foreach (Managers i in db.Manager)
                {
                    if (Convert.ToInt32(r[0].Cells[0].Value.ToString()) == i.id_Local_Store)
                    {
                        check = true;
                        

                    }
                   
                }
                
            }
            if(check==true)
            {
                ThongTinManager f = new ThongTinManager(Convert.ToInt32(r[0].Cells[0].Value.ToString()));
                f.ShowDialog();
            }
            else
            {
                TaoTKManager f = new TaoTKManager(Convert.ToInt32(r[0].Cells[0].Value.ToString()));
                f.ShowDialog();
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            
            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
            int id_tk = 0;
            foreach(Local_Store i in db.Local_Store)
            {

                if(Convert.ToInt32(r[0].Cells[0].Value.ToString())==i.id_Local_Store)
                {
                    db.Local_Store.Remove(i);
                    
                }
                foreach(Managers j in db.Manager)
                {
                    if(i.id_Local_Store==j.id_Local_Store)
                    {
                        id_tk = j.idTaiKhoan;
                    }
                }
            }
        
            foreach(TaiKhoan i in db.TaiKhoan)
            {
                if(i.idTaiKhoan==id_tk)
                {
                    db.TaiKhoan.Remove(i);
                }

            }
            db.SaveChanges();
            var list = db.Local_Store.Select(p => new { p.id_Local_Store, p.Name, p.SDT });
            dataGridView1.DataSource = list.ToList();
        }
    }
}
