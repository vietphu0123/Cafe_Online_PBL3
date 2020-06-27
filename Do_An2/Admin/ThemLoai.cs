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
    public partial class ThemLoai : Form
    {
        public ThemLoai()
        {
            InitializeComponent();
        }

        public class luuthongtin
        {
            static public string NameC;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            luuthongtin.NameC = textBox1.Text;

            if (textBox1.Text != "")
            {

                MessageBox.Show("Thêm thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Chưa nhập Name");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
