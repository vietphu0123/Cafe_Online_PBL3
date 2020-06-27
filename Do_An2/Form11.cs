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
    public partial class Form11 : Form
    {
        int id_Manager;
        public Form11(int id)
        {
            id_Manager = id;
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Nam");
            comboBox1.Items.Add("Nữ");
            comboBox1.SelectedIndex = 0;
            Model1 db = new Model1();
            foreach (Managers i in db.Manager)
            {
                if (i.idTaiKhoan == id_Manager)
                {
                    textBox1.Text = i.Name.ToString();
                    textBox2.Text = i.SDT.ToString();
                    textBox3.Text = i.CMND.ToString();
                    textBox4.Text = i.Dia_Chi.ToString();
                    textBox5.Text = i.Ngay_Vo_Lam.ToString();
                    textBox6.Text = i.Ngay_Sinh.ToString();
                    if (i.Gioi_Tinh == true)
                    {
                        comboBox1.SelectedIndex = 0;
                    }
                    else
                    {
                        comboBox1.SelectedIndex = 1;
                    }
                }
            }
        }
    }
}
