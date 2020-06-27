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
    public partial class frmManagerOrder : Form
    {
        int id_Manager;
        public frmManagerOrder(string idNhaCungCap,int Id_Manager)
        {
            id_Manager = Id_Manager;
            InitializeComponent();
            ShowCompany(idNhaCungCap);
        }

        private void ShowCompany(string idNhaCungCap)
        {
            txtIDCompany.Text = idNhaCungCap;
            txtIDCompany.Enabled = false;
            txtPrice.Text = "";
            fillDataComboSource();

            Model1 db = new Model1();
            List<string> listIdNguyenLieu = new List<string>();
            bool fillCompanyDetail = false;
            foreach (NHACUNGCAP m in db.NhaCungCap)
            {
                if (m.IdNhaCungCap == idNhaCungCap)
                {
                    listIdNguyenLieu.Add(m.IdNguyenLieu);
                    if (!fillCompanyDetail)
                    {
                        txtCompanyName.Text = m.TenNhaCungCap;
                        txtAddress.Text = m.DiaChi;
                        txtPhone.Text = m.SoDienThoai;
                        fillCompanyDetail = true;
                    }
                }
            }
            fillNguyenLieuInfo(idNhaCungCap, listIdNguyenLieu);
        }

        private void fillNguyenLieuInfo(string idNhaCungCap, List<string> listIdNguyenLieu)
        {
            Model1 db = new Model1();
            var SourceList = (from nguyenlieu in db.NguyenLieu
                              join company in db.NhaCungCap on nguyenlieu.IdNguyenLieu equals company.IdNguyenLieu
                              where company.IdNhaCungCap == idNhaCungCap
                              //where listIdNguyenLieu.Contains(nguyenlieu.IdNguyenLieu)                              
                              select new
                              {
                                  MaNguyenLieu = nguyenlieu.IdNguyenLieu,
                                  ThongTinNguyenLieu = nguyenlieu.TenNguyenLieu + " (" + nguyenlieu.DonViTinh + ")",
                                  DonGia = company.Gia
                              }).ToList();
            dgvAllSource.DataSource = SourceList;
        }

        private void fillDataComboSource()
        {
            Model1 db = new Model1();
            var SourceList = (from sources in db.NguyenLieu
                              select new
                              {
                                  MaNguyenLieu = sources.IdNguyenLieu,
                                  ThongTinNguyenLieu = sources.TenNguyenLieu + " (" + sources.DonViTinh + ")"
                              }).ToList();


            cbSource.DataSource = SourceList;
            cbSource.ValueMember = "MaNguyenLieu";
            cbSource.DisplayMember = "ThongTinNguyenLieu";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManagerCompany mgManagerCompany = new frmManagerCompany(id_Manager);
            mgManagerCompany.ShowDialog();
        }
    }
}
