using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An2
{
    public partial class ThêmUser : Form
    {
        public ThêmUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(But_Your_Pass.Text);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
            String haspass = "";
            foreach (byte i in hasData)
            {
                haspass += i;
            }
            Model1 db = new Model1();
            bool a = true;
            bool b = true;
           
            foreach (TaiKhoan i in db.TaiKhoan)
            {
                if (String.Compare(i.TenTaiKhoan.ToString(), But_Name_Login.Text.ToString(), true) == 0)
                {
                    a = false;
                    MessageBox.Show("tên tài khoản đã có");
                }
                
            }

            foreach (User i in db.User)
            {
                if (String.Compare(i.Email.ToString(), But_Email.Text.ToString(), true) == 0)
                {

                    b = false;
                    MessageBox.Show("email đã đăng ký");
                }
                
            }
            if (a == true && b == true)
            {
                TaiKhoan tk = new TaiKhoan();
                tk.TenTaiKhoan = But_Name_Login.Text.ToString();
                tk.pass = haspass;
                tk.LoaiTK = "User";
                db.TaiKhoan.Add(tk);
                db.SaveChanges();
                User us = new User();
                us.Email = But_Email.Text;
                us.Name = But_Name.Text;
                us.idTaiKhoan  = db.TaiKhoan.Max(p => p.idTaiKhoan);               
                db.User.Add(us);
                db.SaveChanges();
                MessageBox.Show("đã tạo thành công");
                this.Close();
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
