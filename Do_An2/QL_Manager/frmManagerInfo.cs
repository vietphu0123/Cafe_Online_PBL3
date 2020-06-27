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
    public partial class frmManagerInfo : Form
    {
        private int _IdUser;
        private int _IdManager;
        private DateTime _Starter;
        private string _Name;
        private string _CMND;
        private string _Address;
        private DateTime _Birthday;
        private string _Phone;
        private bool _Gender;
        public int id_Manager;
        public frmManagerInfo(int IDManager)
        {
            id_Manager = IDManager;
            InitializeComponent();
            ShowInfoManager(IDManager);
        }

        private void ShowInfoManager(int IDManager)
        {
            Model1 db = new Model1();
            foreach (Managers m in db.Manager)
            {
                if (m.idManager == IDManager)
                {
                    _IdUser = m.idTaiKhoan;
                    _IdManager = m.idManager;
                    _Starter = Convert.ToDateTime(m.Ngay_Vo_Lam);
                    _Name = m.Name;
                    _CMND = m.CMND;
                    _Address = m.Dia_Chi;
                    _Birthday = Convert.ToDateTime(m.Ngay_Sinh);
                    _Phone = m.SDT;
                    _Gender = Convert.ToBoolean(m.Gioi_Tinh);
                }
                FillFormManagerInfo();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            FillFormManagerInfo();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            var result = db.Manager.SingleOrDefault(b => b.idManager == _IdManager);
            if (result != null)
            {
                result.Name = txtName.Text;
                result.Ngay_Sinh = Convert.ToDateTime(txtBirthday.Text);
                result.SDT = txtPhone.Text;
                result.Dia_Chi = txtAddress.Text;
                result.CMND = txtCMND.Text;
                result.Gioi_Tinh = rdMale.Checked;
                db.SaveChanges();
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManager mg = new frmManager(id_Manager);
            mg.ShowDialog();
        }

        #region [Khai báo các method]
        private void FillFormManagerInfo()
        {
            // Thong tin tai khoan
            lbUser.Text = _IdUser.ToString();
            lbIDManager.Text = _IdManager.ToString();
            lbStarter.Text = _Starter.ToString();
            // Thong tin ca nhan
            txtName.Text = _Name;
            txtCMND.Text = _CMND;
            txtAddress.Text = _Address;
            txtBirthday.Text = _Birthday.ToString();
            txtPhone.Text = _Phone;
            rdFemale.Checked = true;
            if (_Gender)
            {
                rdMale.Checked = true;
            }
        }

        #endregion       
    }
}
