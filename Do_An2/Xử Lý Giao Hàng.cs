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
    public partial class Xử_Lý_Giao_Hàng : Form
    {
        int id_Manager;
        public Xử_Lý_Giao_Hàng(int id_manager)
        {
            id_Manager = id_manager;
            InitializeComponent();
            radioButton1.Checked = true;
        }
        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true)
            {
                panel1.Controls.Clear();
                Delivery f = new Delivery(id_Manager);
                f.TopLevel = false;
                panel1.Controls.Add(f);
                f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                f.Dock = DockStyle.Fill;
                f.Show();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked==true)
            {
                
                    panel1.Controls.Clear();
                    Giao_Hàng f = new Giao_Hàng(id_Manager);
                    f.TopLevel = false;
                    panel1.Controls.Add(f);
                    f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    f.Dock = DockStyle.Fill;
                    f.Show();
                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
