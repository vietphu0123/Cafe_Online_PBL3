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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            QuanLyMenu f = new QuanLyMenu();
            f.TopLevel = false;
            panel2.Controls.Add(f);
            f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Quản_Lý_Các_Cửa_Hàng f = new Quản_Lý_Các_Cửa_Hàng();
            f.TopLevel = false;
            panel2.Controls.Add(f);
            f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            QuanLyOrder  f = new QuanLyOrder();
            f.TopLevel = false;
            panel2.Controls.Add(f);
            f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManager mg = new frmManager(idmanager);
            mg.ShowDialog();
        }
    }
}
