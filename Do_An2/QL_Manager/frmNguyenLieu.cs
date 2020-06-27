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
    public partial class frmNguyenLieu : Form
    {
        int id_Manager;
        public frmNguyenLieu(int Id_Manager)
        {
            id_Manager = Id_Manager;
            InitializeComponent();
            getDataNguyenLieu();
        }

        #region các biến
        bool themNutXoaVaoDatagridview = false;
        #endregion
        #region Các phương thức
        private void getDataNguyenLieu()
        {
            try
            {
                Model1 db = new Model1();
                var SourceList = (from nguyenlieu in db.NguyenLieu
                                  select new
                                  {
                                      MaNguyenLieu = nguyenlieu.IdNguyenLieu,
                                      NguyenLieu = nguyenlieu.TenNguyenLieu,
                                      DVT = nguyenlieu.DonViTinh
                                  }).ToList();
                dgvAllSource.DataSource = SourceList;
                dgvAllSource.AllowUserToAddRows = false;
                if (!themNutXoaVaoDatagridview)
                {
                    DataGridViewButtonColumn delete = new DataGridViewButtonColumn();
                    delete.HeaderText = "";
                    delete.Text = "Xóa";
                    delete.Name = "btnDelete";
                    delete.UseColumnTextForButtonValue = true;
                    dgvAllSource.Columns.Add(delete);
                    themNutXoaVaoDatagridview = true;
                }
                dgvAllSource.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra. Vui lòng kiểm tra lại! \n Thông tin lỗi:" + ex.Message, "Thông báo lỗi");
            }
        }
        #endregion

        #region event control
        private void btnSave_Click(object sender, EventArgs e)
        {
            string manguyenlieu = txtIdNguyenLieu.Text.Trim();
            string tennguyenlieu = txtTenNguyenLieu.Text.Trim();
            string dvt = txtDonViTinh.Text.Trim();
            if (manguyenlieu == string.Empty)
            {
                // hiển thị thông báo lỗi và dừng thực hiện lưu
                MessageBox.Show("Vui lòng nhập mã nguyên liệu!", "Thông báo lỗi");
                return;
            }
            if (tennguyenlieu == string.Empty)
            {
                // hiển thị thông báo lỗi và dừng thực hiện lưu
                MessageBox.Show("Vui lòng nhập tên nguyên liệu!", "Thông báo lỗi");
                return;
            }
            if (dvt == string.Empty)
            {
                // hiển thị thông báo lỗi và dừng thực hiện lưu
                MessageBox.Show("Vui lòng nhập đơn vị tính!", "Thông báo lỗi");
                return;
            }
            try
            {
                Model1 db = new Model1();
                var nguyenlieu = new NGUYENLIEU
                {
                    IdNguyenLieu = manguyenlieu,
                    TenNguyenLieu = tennguyenlieu,
                    DonViTinh = dvt
                };
                db.NguyenLieu.Add(nguyenlieu);
                db.SaveChanges();
                getDataNguyenLieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra. Vui lòng kiểm tra lại! \n Thông tin lỗi:" + ex.Message, "Thông báo lỗi");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManager mgManager = new frmManager(id_Manager);
            mgManager.ShowDialog();
        }

        private void dgvAllSource_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                string idNguyenLieu = dgvAllSource.Rows[e.RowIndex].Cells["MaNguyenLieu"].Value.ToString();
                // Hiển thị dialog xác nhận việc xóa
                DialogResult result = MessageBox.Show("Bạn có muốn xóa?", "Xác nhận xóa!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                try
                {
                    if (result == DialogResult.Yes)
                    {
                        // Thực hiện xóa nguyên liệu
                        var db = new Model1();
                        var nguyenlieu = new NGUYENLIEU
                        {
                            IdNguyenLieu = idNguyenLieu
                        };
                        db.NguyenLieu.Attach(nguyenlieu);
                        db.NguyenLieu.Remove(nguyenlieu);
                        db.SaveChanges();
                        // hiển thị lại dữ liệu
                        getDataNguyenLieu();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra. Vui lòng kiểm tra lại! \n Thông tin lỗi:" + ex.Message, "Thông báo lỗi");
                }

            }
        }
        #endregion


    }
}
