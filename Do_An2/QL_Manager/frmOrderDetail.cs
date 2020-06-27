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
    public partial class frmOrderDetail : Form
    {
        int id_Manager;
        public frmOrderDetail(string madonhang,int Id_Manager)
        {
            id_Manager = Id_Manager;
            InitializeComponent();
            // Hiển thị thông tin chi tiết đơn hàng
            HienThiChiTietDonHang(madonhang);
        }
        #region phương thức
        private void HienThiChiTietDonHang(string madonhang)
        {
            try
            {
                lbMaDonHang.Text = madonhang;
                Model1 db = new Model1();
                // 
                var OrderList = (from order in db.DonDatHang
                                 join manager in db.Manager on order.idManager equals manager.idManager
                                 where order.IdDonDatNguyenLieu == madonhang
                                 orderby order.NgayDatHang descending, order.IdDonDatNguyenLieu descending
                                 select new
                                 {
                                     QuanLy = manager.Name,
                                     TinhTrang = order.TrangThai,
                                     NgayDat = order.NgayDatHang,
                                     ThoiHanNhan = order.ThoiHan
                                 }).Distinct().ToList();
                OrderList.ForEach(row =>
                {
                    lbIdManager.Text = row.QuanLy;
                    lbThoiHan.Text = row.ThoiHanNhan.ToString();
                    lbNgayDatHang.Text = row.NgayDat.ToString();
                    if (row.TinhTrang)
                    {
                        rdDaNhan.Checked = true;
                    }
                    else
                    {
                        rdChuaNhan.Checked = true;
                    }
                });


                var OrderInfoList = (from order in db.DonDatHang
                                     join manager in db.Manager on order.idManager equals manager.idManager
                                     join nguyenlieu in db.NguyenLieu on order.IdNguyenLieu equals nguyenlieu.IdNguyenLieu
                                     join company in db.NhaCungCap on order.IdNhaCungCap equals company.IdNhaCungCap
                                     where company.IdNguyenLieu == nguyenlieu.IdNguyenLieu && order.IdDonDatNguyenLieu == madonhang
                                     orderby order.NgayDatHang descending, order.IdDonDatNguyenLieu descending
                                     select new
                                     {
                                         NhaCungCap = company.TenNhaCungCap,
                                         NguyenLieu = nguyenlieu.TenNguyenLieu + " (" + nguyenlieu.DonViTinh + ")",
                                         SoLuongDatHang = order.SoLuong,
                                         DonGia = company.Gia
                                     }).Distinct().ToList();
                dgvNguyenLieuDatHang.DataSource = OrderInfoList;
                dgvNguyenLieuDatHang.Refresh();
                dgvNguyenLieuDatHang.RowHeadersVisible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra. Vui lòng kiểm tra lại! \n Thông tin lỗi:" + ex.Message, "Thông báo lỗi");
            }
        }

        // Đây là phương thức dùng để đóng form frmCompanyInfo
        // Và hiển thị form frmManagerCompany
        private void BackFormManagerCompany()
        {
            this.Hide();
            frmManager mgManager = new frmManager(id_Manager);
            mgManager.ShowDialog();
        }
        #endregion

        private void btnNhanHang_Click(object sender, EventArgs e)
        {
            try
            {
                string madonhang = lbMaDonHang.Text;
                Model1 db = new Model1();
                var Orderlist = db.DonDatHang.Where(f => f.IdDonDatNguyenLieu.Contains(madonhang)).ToList();
                Orderlist.ForEach(order =>
                {
                    order.TrangThai = true;
                });
                db.SaveChanges();
                // quay lai trang quản lý
                BackFormManagerCompany();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra. Vui lòng kiểm tra lại! \n Thông tin lỗi:" + ex.Message, "Thông báo lỗi");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BackFormManagerCompany();
        }
    }
}
