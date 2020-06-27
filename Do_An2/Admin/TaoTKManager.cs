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
    public partial class TaoTKManager : Form
    {
        int id_Local = 0;
        public TaoTKManager(int id)
        {
            id_Local = id;
            InitializeComponent();
        }

        private void TaoTKManager_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            bool check = true;
          







            foreach (TaiKhoan i in db.TaiKhoan)
            {
                if(String.Compare(i.TenTaiKhoan.ToString(),textBox1.Text.ToString(),true)==0)
                {
                    check = false;
                    MessageBox.Show("tài khoản đã có");
                    textBox1.Clear();
                    textBox2.Clear();

                }
                
            }
            if(check)
            {
                db.TaiKhoan.Add(new TaiKhoan
                {
                    TenTaiKhoan = textBox1.Text.ToString(),
                    pass = textBox1.Text.ToString(),
                    LoaiTK = "Manager",

                });
                db.SaveChanges();
                db.Manager.Add(new Managers
                {
                    id_Local_Store = id_Local,
                    idTaiKhoan = db.TaiKhoan.Max(p => (p.idTaiKhoan)),

                });
                db.SaveChanges();
                MessageBox.Show("Tạo Thanh công");
                this.Dispose();
                this.Close();
            }
        }
    }
}
