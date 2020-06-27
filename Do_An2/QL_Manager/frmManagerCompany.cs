using System;
using System.Collections;
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
    public partial class frmManagerCompany : Form
    {
        private DataTable dtSource = new DataTable();
        private Dictionary<string, double> dicDanhSachChonNguyenLieu = new Dictionary<string, double>();
        private List<string> lstDanhSachIDNguyenLieu = new List<string>();
        private bool addButtonForDGVSource = false;
        private bool addButtonForDGVCompany = false;
        private List<NHACUNGCAP> arrNhaCungCap = new List<NHACUNGCAP>();
        public int id_Manager;
        public frmManagerCompany(int Id_Manager)
        {
            id_Manager = Id_Manager;
            InitializeComponent();
            fillDataComboSource();
            // Intial header for datatable (nguyenlieu)
            dtSource.Columns.Add("MaNguyenLieu", typeof(string));
            dtSource.Columns.Add("ThongTinNguyenLieu", typeof(string));
            dtSource.Columns.Add("DonGia", typeof(double));
            LoadAllCompany();
        }

        private void LoadAllCompany()
        {
            Model1 db = new Model1();
            var CompanyList = (from company in db.NhaCungCap
                               join nguyenlieu in db.NguyenLieu on company.IdNguyenLieu equals nguyenlieu.IdNguyenLieu
                               orderby company.NgayDangKy descending
                               select new
                               {
                                   MaNhaCungCap = company.IdNhaCungCap,
                                   TenCongTy = company.TenNhaCungCap,
                                   DiaChiCongTy = company.DiaChi,
                                   SDT = company.SoDienThoai,
                                   NguyenLieu = nguyenlieu.TenNguyenLieu,
                                   DonGia = company.Gia,
                                   DangKy = company.NgayDangKy,
                                   hiddenIdNguyenLieu = company.IdNguyenLieu
                               }).ToList();
            dgvAllCompany.DataSource = CompanyList;
            dgvAllCompany.Columns["hiddenIdNguyenLieu"].Visible = false;

            if (!addButtonForDGVCompany)
            {
                DataGridViewCheckBoxColumn optionDelete = new DataGridViewCheckBoxColumn();
                optionDelete.ValueType = typeof(bool);
                optionDelete.Name = "ckDelete";
                optionDelete.HeaderText = "Chon tất cả";
                dgvAllCompany.Columns.Add(optionDelete);
                DataGridViewButtonColumn edit = new DataGridViewButtonColumn();
                edit.HeaderText = "";
                edit.Text = "Chỉ sửa";
                edit.Name = "btnEditCompany";
                edit.UseColumnTextForButtonValue = true;
                dgvAllCompany.Columns.Add(edit);
            }
            addButtonForDGVCompany = true;
            dgvAllCompany.RowHeadersVisible = false;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dicDanhSachChonNguyenLieu.ContainsKey(cbSource.SelectedValue.ToString()))
            {
                MessageBox.Show("Nguyên liệu đã được chọn. Vui lòng kiểm tra!");
                return;
            }
            // 1. cbSource.SelectedValue.ToString()
            // 2. cbSource.Text
            // 3. txtPrice.Text
            // => dgvAllSource                                    
            DataRow dr = dtSource.NewRow();
            dr[0] = cbSource.SelectedValue.ToString();
            dr[1] = cbSource.Text;
            dr[2] = txtPrice.Text;
            dtSource.Rows.Add(dr);

            // binding data
            dgvAllSource.DataSource = dtSource;
            dgvAllSource.RowHeadersVisible = false;
            if (!addButtonForDGVSource)
            {
                DataGridViewButtonColumn delete = new DataGridViewButtonColumn();
                delete.HeaderText = "";
                delete.Text = "Xóa";
                delete.Name = "btnDelete";
                delete.UseColumnTextForButtonValue = true;
                dgvAllSource.Columns.Add(delete);
            }
            addButtonForDGVSource = true;
            // add IdNguyenLieu into "dicDanhSachChonNguyenLieu"
            dicDanhSachChonNguyenLieu.Add(cbSource.SelectedValue.ToString(), Convert.ToDouble(txtPrice.Text));

            // add 
            lstDanhSachIDNguyenLieu.Add(cbSource.SelectedValue.ToString());
        }

        private void btnRegisterCompany_Click(object sender, EventArgs e)
        {
            var db = new Model1();

            List<NHACUNGCAP> listCompany = new List<NHACUNGCAP>();
            foreach (KeyValuePair<string, double> source in dicDanhSachChonNguyenLieu)
            {
                var company = new NHACUNGCAP
                {
                    IdNhaCungCap = txtIDCompany.Text,
                    TenNhaCungCap = txtCompanyName.Text,
                    DiaChi = txtAddress.Text,
                    SoDienThoai = txtPhone.Text,
                    IdNguyenLieu = source.Key,
                    Gia = source.Value,
                    NgayDangKy = DateTime.Now
                };
                listCompany.Add(company);
            }
            db.NhaCungCap.AddRange(listCompany);
            db.SaveChanges();
            LoadAllCompany();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManager mgManager = new frmManager(id_Manager);
            mgManager.ShowDialog();
        }

        private void dgvAllSource_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                string IdNguyenLieu = lstDanhSachIDNguyenLieu[e.RowIndex];
                for (int i = dtSource.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow dr = dtSource.Rows[i];
                    if (dr["MaNguyenLieu"].ToString() == IdNguyenLieu)
                    {
                        dr.Delete();
                        dicDanhSachChonNguyenLieu.Remove(IdNguyenLieu);
                        lstDanhSachIDNguyenLieu.Remove(IdNguyenLieu);
                    }

                }
                dtSource.AcceptChanges();
            }
        }

        private void btnDeleteCompanySelect_Click(object sender, EventArgs e)
        {
            var db = new Model1();
            string message = string.Empty;
            List<NHACUNGCAP> listCompany = new List<NHACUNGCAP>();
            foreach (DataGridViewRow row in dgvAllCompany.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["ckDelete"].Value);
                if (isSelected)
                {
                    var company = new NHACUNGCAP
                    {
                        IdNhaCungCap = row.Cells["MaNhaCungCap"].Value.ToString(),
                        IdNguyenLieu = row.Cells["hiddenIdNguyenLieu"].Value.ToString(),
                    };
                    db.NhaCungCap.Attach(company);
                    listCompany.Add(company);
                    message += Environment.NewLine;
                    message += row.Cells["TenCongTy"].Value.ToString() + " cung cấp nguyên liệu: " + row.Cells["NguyenLieu"].Value.ToString();
                }
            }

            db.NhaCungCap.RemoveRange(listCompany);
            db.SaveChanges();
            LoadAllCompany();
            MessageBox.Show("Thông tin các nguyên liệu của nhà cung cấp đã được xóa:" + message);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string idNhaCungCap = txtFindIdCompany.Text.Trim();
            Model1 db = new Model1();
            var CompanyList = (from company in db.NhaCungCap
                               join nguyenlieu in db.NguyenLieu on company.IdNguyenLieu equals nguyenlieu.IdNguyenLieu
                               where company.IdNhaCungCap.Contains(idNhaCungCap)
                               orderby company.NgayDangKy descending
                               select new
                               {
                                   MaNhaCungCap = company.IdNhaCungCap,
                                   TenCongTy = company.TenNhaCungCap,
                                   DiaChiCongTy = company.DiaChi,
                                   SDT = company.SoDienThoai,
                                   NguyenLieu = nguyenlieu.TenNguyenLieu,
                                   DonGia = company.Gia,
                                   DangKy = company.NgayDangKy,
                                   hiddenIdNguyenLieu = company.IdNguyenLieu
                               }).ToList();
            dgvAllCompany.DataSource = CompanyList;
            dgvAllCompany.Columns["hiddenIdNguyenLieu"].Visible = false;
        }

        private void btnFindCompanyName_Click(object sender, EventArgs e)
        {
            string TenNhaCungCap = txtFindCompanyName.Text.Trim();
            Model1 db = new Model1();
            var CompanyList = (from company in db.NhaCungCap
                               join nguyenlieu in db.NguyenLieu on company.IdNguyenLieu equals nguyenlieu.IdNguyenLieu
                               where company.TenNhaCungCap.Contains(TenNhaCungCap)
                               orderby company.NgayDangKy descending
                               select new
                               {
                                   MaNhaCungCap = company.IdNhaCungCap,
                                   TenCongTy = company.TenNhaCungCap,
                                   DiaChiCongTy = company.DiaChi,
                                   SDT = company.SoDienThoai,
                                   NguyenLieu = nguyenlieu.TenNguyenLieu,
                                   DonGia = company.Gia,
                                   DangKy = company.NgayDangKy,
                                   hiddenIdNguyenLieu = company.IdNguyenLieu
                               }).ToList();
            dgvAllCompany.DataSource = CompanyList;
            dgvAllCompany.Columns["hiddenIdNguyenLieu"].Visible = false;
        }

        private void dgvAllCompany_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
             *MaNhaCungCap = company.IdNhaCungCap,
                                 TenCongTy = company.TenNhaCungCap,
                                 DiaChiCongTy = company.DiaChi,
                                 SDT = company.SoDienThoai,
                                 NguyenLieu = nguyenlieu.TenNguyenLieu,
                                 DonGia = company.Gia,
                                 DangKy = company.NgayDangKy,
                                 hiddenIdNguyenLieu = company.IdNguyenLieu
             */

            /*
            foreach (DataGridViewRow row in dgvAllCompany.Rows)
            {
                string message = string.Empty;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    
                    message += Environment.NewLine;
                    message += cell.Value.ToString();

                }
                MessageBox.Show(message);
            }*/
            /*
            for (int rows = 0; rows < dgvAllCompany.Rows.Count ; rows++)
            {
                string message = string.Empty;
                for (int col = 2; col < dgvAllCompany.Rows[rows].Cells.Count; col++)
                {
                    message += Environment.NewLine;
                    message += dgvAllCompany.Rows[rows].Cells[col].Value.ToString();

                }
                MessageBox.Show(message);
            }*/



            //string maNhaCungCap = 
            if (e.ColumnIndex == 1)
            {
                string idNhaCungCap = dgvAllCompany.Rows[e.RowIndex].Cells[2].Value.ToString();
                string tenCongTy = dgvAllCompany.Rows[e.RowIndex].Cells[3].Value.ToString();
                string diaChiCongTy = dgvAllCompany.Rows[e.RowIndex].Cells[4].Value.ToString();
                string SDT = dgvAllCompany.Rows[e.RowIndex].Cells[5].Value.ToString();
                string idNguyenLieu = dgvAllCompany.Rows[e.RowIndex].Cells[9].Value.ToString();
                string donGia = dgvAllCompany.Rows[e.RowIndex].Cells[7].Value.ToString();
                string ngayDangKy = dgvAllCompany.Rows[e.RowIndex].Cells[8].Value.ToString();

                this.Hide();
                FrmCompanyInfo companyInfo = new FrmCompanyInfo(idNhaCungCap,id_Manager);
                companyInfo.ShowDialog();

                /*
                string message = string.Empty;
                // column "delete" ở vị trí 0
                // column "chỉnh sửa" ở vị trí 1
                // Bắt đầu từ column 2 để lấy dữ liệu

                for (int col = 2; col < dgvAllCompany.Rows[e.RowIndex].Cells.Count; col++)
                {
                    message += Environment.NewLine;
                    message += dgvAllCompany.Rows[e.RowIndex].Cells[col].Value.ToString();

                }
                MessageBox.Show(message);
                */

                //MessageBox.Show("");
                /*
                string IdNguyenLieu = lstDanhSachIDNguyenLieu[e.RowIndex];
                for (int i = dtSource.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow dr = dtSource.Rows[i];
                    if (dr["MaNguyenLieu"].ToString() == IdNguyenLieu)
                    {
                        dr.Delete();
                        dicDanhSachChonNguyenLieu.Remove(IdNguyenLieu);
                        lstDanhSachIDNguyenLieu.Remove(IdNguyenLieu);
                    }

                }
                dtSource.AcceptChanges();
                */
            }
        }
    }

}
