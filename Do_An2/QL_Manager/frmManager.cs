using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An2
{
    public partial class frmManager : Form
    {
        public int id_Manager;
        public frmManager(int Id_Manager)
        {
            InitializeComponent();
            lbCurrentTime.Text = "Bây giờ: " + DateTime.Now.ToString();
            // Khi đăng nhâp xong
            // Thì form đăng nhập phải thiết lập giá trị cho biến IDManager
            // Tạm thời gán bằng 1 (đây là IdManager đã có trong table Manager)
            id_Manager = Id_Manager;
            getNameManager();
            getDataOrder();
        }

        private void getDataOrder()
        {
            Model1 db = new Model1();
            var OrderList = (from order in db.DonDatHang
                             join manager in db.Manager on order.idManager equals manager.idManager
                             join company in db.NhaCungCap on order.IdNhaCungCap equals company.IdNhaCungCap
                             join source in db.NguyenLieu on order.IdNguyenLieu equals source.IdNguyenLieu
                             where order.IdNguyenLieu == company.IdNguyenLieu
                             select new
                             {
                                 MaDon = order.IdDonDatNguyenLieu,
                                 QuanLy = manager.Name,
                                 NhaCungCap = company.TenNhaCungCap,
                                 NguyenLieu = source.TenNguyenLieu
                             }).ToList();
            dgvOrder.DataSource = OrderList;
            dgvOrder.Refresh();
        }

        private void getNameManager() 
        {
            Model1 db = new Model1();
            foreach (Managers m in db.Manager)
            {
                if (m.idManager == id_Manager)
                {
                    lbTenQuanLy.Text = m.Name;
                }

            }
        }

        private void lnkDangXuat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Đăng Xuất");

        }

        private void rdNoReceived_CheckedChanged(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            var OrderList = (from order in db.DonDatHang
                             join manager in db.Manager on order.idManager equals manager.idManager
                             join company in db.NhaCungCap on order.IdNhaCungCap equals company.IdNhaCungCap
                             join source in db.NguyenLieu on order.IdNguyenLieu equals source.IdNguyenLieu
                             where order.IdNguyenLieu == company.IdNguyenLieu & !order.TrangThai
                             select new
                             {
                                 MaDon = order.IdDonDatNguyenLieu,
                                 QuanLy = manager.Name,
                                 NhaCungCap = company.TenNhaCungCap,
                                 NguyenLieu = source.TenNguyenLieu
                             }).ToList();
            dgvOrder.DataSource = OrderList;
            dgvOrder.Refresh();
        }

        private void rdAllOrder_CheckedChanged(object sender, EventArgs e)
        {
            getDataOrder();
        }

        private void rdOutOfDate_CheckedChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            Model1 db = new Model1();
            var OrderList = (from order in db.DonDatHang
                             join manager in db.Manager on order.idManager equals manager.idManager
                             join company in db.NhaCungCap on order.IdNhaCungCap equals company.IdNhaCungCap
                             join source in db.NguyenLieu on order.IdNguyenLieu equals source.IdNguyenLieu
                             where order.IdNguyenLieu == company.IdNguyenLieu
                             & DbFunctions.AddDays(today, -order.ThoiHan) > order.NgayDatHang
                             & !order.TrangThai

                             select new
                             {
                                 MaDon = order.IdDonDatNguyenLieu,
                                 QuanLy = manager.Name,
                                 NhaCungCap = company.TenNhaCungCap,
                                 NguyenLieu = source.TenNguyenLieu
                             }).ToList();
            dgvOrder.DataSource = OrderList;
            dgvOrder.RowHeadersVisible = false;
            dgvOrder.Refresh();
        }

        private void lnkShowInfoManager_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmManagerInfo mg = new frmManagerInfo(id_Manager);
            mg.ShowDialog();

        }

        private void lnkCompany_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmManagerCompany mgCompany = new frmManagerCompany(id_Manager);
            mgCompany.ShowDialog();
        }

        private void lbTenQuanLy_Click(object sender, EventArgs e)
        {

        }
    }
}
