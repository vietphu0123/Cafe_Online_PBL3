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
    public partial class Đổi_pass : Form
    {
        public Đổi_pass()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {





            Login f = new Login();
            this.Hide();
            this.Dispose();
            f.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            this.Dispose();
            f.ShowDialog();
            this.Close();
        }
    }
}
