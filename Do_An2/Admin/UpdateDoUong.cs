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
    public partial class UpdateDoUong : Form
    {

        int id_drink;
        public UpdateDoUong(int id)
        {
            id_drink = id;
            InitializeComponent();
            SetCBB();
        }
        public void SetCBB()
        {
            Model1 db = new Model1();
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
        private void Form4_Load(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            foreach (Drink i in db.Drink)
            {
                if (i.id_Drink == id_drink)
                {

                    textBox1.Text = i.name;
                    textBox2.Text = i.price.ToString();
                    CBBCategory temp = new CBBCategory();
                    foreach (CBBCategory j in comboBox1.Items)
                    {
                        if (j.IdC == i.id_Category)
                        {
                            temp = j;
                        }
                    }
                    int index = comboBox1.Items.IndexOf(temp);
                    comboBox1.SelectedIndex = index;
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
