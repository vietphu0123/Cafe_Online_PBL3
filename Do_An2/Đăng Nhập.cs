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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void But_Create_Acc_Click(object sender, EventArgs e)
        {
            ThêmUser f = new ThêmUser();
            f.ShowDialog();
        }

        private void But_Sign_in_Click(object sender, EventArgs e)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(But_Pass.Text);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
            String haspass = "";
            foreach (byte i in hasData)
            {
                haspass += i;
            }
            Model1 db = new Model1();
            bool check = false;
            foreach (TaiKhoan i in db.TaiKhoan)
            {
                if (String.Compare(But_id.Text.ToString(), i.TenTaiKhoan.ToString(), true) == 0 && haspass== i.pass.ToString()  && i.LoaiTK == "User")
                {

                    
                    check = true;
                    Login_User f = new Login_User(i.idTaiKhoan);
                    this.Hide();
                    f.ShowDialog();
                    this.Dispose();
                    this.Close();

                }
                if (String.Compare(But_id.Text.ToString(), i.TenTaiKhoan.ToString(), true) == 0 && String.Compare(But_Pass.Text.ToString(), i.pass.ToString(), false) == 0 && i.LoaiTK == "Manager")
                {
                    int id_Manager=0;
                    Model1 db1 = new Model1();
                    foreach(Managers j in db1.Manager)
                    {
                        if(i.idTaiKhoan==j.idTaiKhoan)
                        {
                            id_Manager = j.idManager;
                        }
                    }
                    check = true;
                    MessageBox.Show(id_Manager.ToString());
                    Form10 f = new Form10(id_Manager);
                    this.Hide();
                    f.ShowDialog();
                    this.Dispose();
                    this.Close();

                }
                if (String.Compare(But_id.Text.ToString(), i.TenTaiKhoan.ToString(), true) == 0 && String.Compare(But_Pass.Text.ToString(), i.pass.ToString(), false) == 0 && i.LoaiTK == "admin")
                {
                    check = true;
                    Form12 f = new Form12();
                    this.Hide();
                    f.ShowDialog();
                    this.Dispose();
                    this.Close();

                }


            }

            if (check == false)
            {
                MessageBox.Show("sai ten tai khoan hoac mat khau");
                But_id.Text = "";
                But_Pass.Text = "";

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            this.Hide();
            f.ShowDialog();
            this.Dispose();
            this.Close();

        }

        private void But_Forget_Pass_Click(object sender, EventArgs e)
        {
            Đổi_pass f = new Đổi_pass();
            this.Hide();
            this.Dispose();
            f.ShowDialog();
            this.Close();
        }
    }
}
