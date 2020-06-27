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
    public partial class Thêm_Cửa_Hàng : Form
    {
        public delegate void show();
        private show _show;

        public show Show1 { get => _show; set => _show = value; }

        public Thêm_Cửa_Hàng()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            db.Local_Store.Add(new Local_Store {
                Name = textBox1.Text.ToString(),
                Dia_Chi = textBox2.Text.ToString(),
                SDT=textBox3.Text.ToString(),

            });
            db.SaveChanges();
            MessageBox.Show("Thêm thành công");
            Show1();
            this.Dispose();
            this.Close();


        }
    }
}
