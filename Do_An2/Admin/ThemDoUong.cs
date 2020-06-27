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
    public partial class ThemDoUong : Form
    {
        public ThemDoUong()
        {
            InitializeComponent();
            SetCBB();
        }
        public class luuthongtin
        {
            static public string NameD;
            static public string PriceD;
            static public int idC;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            luuthongtin.NameD = textBox1.Text;
            luuthongtin.PriceD = textBox2.Text;
            luuthongtin.idC = ((CBBCategory)comboBox1.SelectedItem).IdC;
            if (textBox1.Text != "")
            {
                if (textBox2.Text != "")
                {
                    MessageBox.Show("Thêm thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Chưa nhập giá");
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập tên");
            }
        }
        public void SetCBB()
        {
            Model1 db = new Model1();

            comboBox1.Items.Add(new CBBCategory
            {
                IdC = 0,
                NameC = "All"
            });

            foreach (Category i in db.Category)
            {
                comboBox1.Items.Add(new CBBCategory
                {
                    IdC = i.id_Category,
                    NameC = i.Name_Category
                });
            }
            comboBox1.SelectedIndex = 0;
        }

    }
}
