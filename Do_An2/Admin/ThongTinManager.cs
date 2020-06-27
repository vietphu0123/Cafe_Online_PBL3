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
    public partial class ThongTinManager : Form
    {
        int id_Local = 0;
        public ThongTinManager(int id)
        {
            id_Local = id;
            InitializeComponent();
            show();
        }

        public void show()
        {

            comboBox1.Items.Add("Nam");
            comboBox1.Items.Add("Nữ");
            comboBox1.SelectedIndex = 0;
            Model1 db = new Model1();
            int id_tk=0;
            foreach (Managers i in db.Manager)
            {
                if (Convert.ToInt32(i.id_Local_Store.ToString()) == id_Local)
                {
                    try
                    {
                        But_Name.Text = i.Name.ToString();
                    }
                    catch(Exception e)
                    {
                        But_Name.Text = "";
                    }
                    try
                    {
                        But_SDT.Text = i.SDT.ToString();
                    }
                    catch (Exception e)
                    {
                        But_SDT.Text = "";
                    }
                    try
                    {
                        textBox3.Text = i.CMND.ToString();

                    }
                    catch (Exception e)
                    {
                        textBox3.Text = "";
                    }
                    try
                    {
                        textBox4.Text = i.Dia_Chi.ToString();
                    }
                    catch (Exception e)
                    {
                        textBox4.Text = "";
                    }
                    try
                    {
                        textBox5.Text = i.Ngay_Vo_Lam.ToString();

                    }
                    catch (Exception e)
                    {
                        textBox5.Text = "";
                    }
                    try
                    {
                        textBox6.Text = i.Ngay_Sinh.ToString();

                    }
                    catch (Exception e)
                    {
                        textBox6.Text = "";
                    }
                   
                   
                 
               
          
                    if (i.Gioi_Tinh == true)
                    {
                        comboBox1.SelectedIndex = 0;
                    }
                    else
                    {
                        comboBox1.SelectedIndex = 1;
                    }
                    id_tk = i.idTaiKhoan;

                }

                

            }
            foreach(TaiKhoan i in db.TaiKhoan)
            {
                if(id_tk==i.idTaiKhoan)
                {
                    textBox1.Text = i.pass.ToString();
                    textBox2.Text = i.TenTaiKhoan.ToString();
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
