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
    public partial class Information_User : Form
    {
        public delegate void load(object sender, EventArgs e);
        private load _d;
        int id_TaiKhoan;

       

        public Information_User(int id)
        {
            id_TaiKhoan = id;
            InitializeComponent();
        }
        public load D { get => _d; set => _d = value; }

        private void Form8_Load(object sender, EventArgs e)
        {
            int id_User = 0;
            Model1 db = new Model1();
            foreach (User i in db.User)
            {
                if (i.idTaiKhoan == id_TaiKhoan)
                {
                    id_User = i.id_Name_User;
                }
            }
            
            comboBox1.Items.Add("Nam");
            comboBox1.Items.Add("Nữ");
            comboBox1.SelectedIndex = 0;
            foreach (User i in db.User)
            {
                if (i.idTaiKhoan.ToString() == id_User.ToString())
                {
                    But_Name.Text = i.Name.ToString();
                    But_Email.Text = i.Email.ToString();
                    try
                    {
                        But_SDT.Text = i.SDT.ToString();
                    }
                    catch (Exception E)
                    {
                        But_SDT.Text = "";
                    }
                    try
                    {
                        But_Dia_Chi.Text = i.Dia_Chi.ToString();
                    }
                    catch (Exception E)
                    {
                        But_Dia_Chi.Text = "";

                    }

                    try
                    {
                        textBox5.Text = i.Ngay_Sinh.ToString();

                    }
                    catch (Exception E)
                    {
                        textBox5.Text = "";
                    }

                    try
                    {
                        if (i.Gioi_Tinh.Value)
                        {
                            comboBox1.SelectedIndex = 0;

                        }
                        else
                        {
                            comboBox1.SelectedIndex = 1;
                        }

                    }
                    catch (Exception E)
                    {
                        comboBox1.SelectedIndex = 0;

                    }


                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id_User = 0;
            Model1 db = new Model1();
            foreach (User i in db.User)
            {
                if (i.idTaiKhoan == id_TaiKhoan)
                {
                    id_User = i.id_Name_User;
                }
            }
            foreach (User i in db.User)
            {
                if (i.idTaiKhoan.ToString() == id_User.ToString())
                {
                    i.SDT = But_SDT.Text.ToString();
                    i.Dia_Chi = But_Dia_Chi.Text.ToString();
                    i.Ngay_Sinh = Convert.ToDateTime(textBox5.Text.ToString());
                    if (comboBox1.SelectedItem == "Nam")
                    {
                        i.Gioi_Tinh = true;
                    }
                    else
                    {
                        i.Gioi_Tinh = false;
                    }



                }
            }
            db.SaveChanges();
            MessageBox.Show("lưu thông tin thành công");
            D(sender,e);
            Login_User f = new Login_User(id_User);
            this.Hide();
            this.Dispose();
            f.ShowDialog();
            this.Close();


        }
    }
}
