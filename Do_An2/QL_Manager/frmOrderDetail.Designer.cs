namespace Do_An2
{
    partial class frmOrderDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdChuaNhan = new System.Windows.Forms.RadioButton();
            this.rdDaNhan = new System.Windows.Forms.RadioButton();
            this.lbMaDonHang = new System.Windows.Forms.Label();
            this.lbIdManager = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvNguyenLieuDatHang = new System.Windows.Forms.DataGridView();
            this.lbNgayDatHang = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbThoiHan = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNhanHang = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguyenLieuDatHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(261, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(374, 51);
            this.label10.TabIndex = 10;
            this.label10.Text = "Chi Tiết Đơn Hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdChuaNhan);
            this.groupBox2.Controls.Add(this.rdDaNhan);
            this.groupBox2.Controls.Add(this.lbMaDonHang);
            this.groupBox2.Controls.Add(this.lbIdManager);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.lbNgayDatHang);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lbThoiHan);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(59, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(817, 528);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết đơn đặt hàng";
            // 
            // rdChuaNhan
            // 
            this.rdChuaNhan.AutoSize = true;
            this.rdChuaNhan.Location = new System.Drawing.Point(425, 76);
            this.rdChuaNhan.Name = "rdChuaNhan";
            this.rdChuaNhan.Size = new System.Drawing.Size(98, 21);
            this.rdChuaNhan.TabIndex = 8;
            this.rdChuaNhan.TabStop = true;
            this.rdChuaNhan.Text = "Chưa nhận";
            this.rdChuaNhan.UseVisualStyleBackColor = true;
            // 
            // rdDaNhan
            // 
            this.rdDaNhan.AutoSize = true;
            this.rdDaNhan.Location = new System.Drawing.Point(259, 76);
            this.rdDaNhan.Name = "rdDaNhan";
            this.rdDaNhan.Size = new System.Drawing.Size(83, 21);
            this.rdDaNhan.TabIndex = 8;
            this.rdDaNhan.TabStop = true;
            this.rdDaNhan.Text = "Đã nhận";
            this.rdDaNhan.UseVisualStyleBackColor = true;
            // 
            // lbMaDonHang
            // 
            this.lbMaDonHang.AutoSize = true;
            this.lbMaDonHang.Location = new System.Drawing.Point(147, 38);
            this.lbMaDonHang.Name = "lbMaDonHang";
            this.lbMaDonHang.Size = new System.Drawing.Size(20, 17);
            this.lbMaDonHang.TabIndex = 2;
            this.lbMaDonHang.Text = "...";
            // 
            // lbIdManager
            // 
            this.lbIdManager.AutoSize = true;
            this.lbIdManager.Location = new System.Drawing.Point(555, 40);
            this.lbIdManager.Name = "lbIdManager";
            this.lbIdManager.Size = new System.Drawing.Size(20, 17);
            this.lbIdManager.TabIndex = 2;
            this.lbIdManager.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(476, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Id quản lý:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvNguyenLieuDatHang);
            this.groupBox4.Location = new System.Drawing.Point(40, 183);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(750, 374);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách nguyên liệu đặt hàng";
            // 
            // dgvNguyenLieuDatHang
            // 
            this.dgvNguyenLieuDatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNguyenLieuDatHang.Location = new System.Drawing.Point(32, 29);
            this.dgvNguyenLieuDatHang.Name = "dgvNguyenLieuDatHang";
            this.dgvNguyenLieuDatHang.RowHeadersWidth = 51;
            this.dgvNguyenLieuDatHang.RowTemplate.Height = 24;
            this.dgvNguyenLieuDatHang.Size = new System.Drawing.Size(681, 317);
            this.dgvNguyenLieuDatHang.TabIndex = 0;
            // 
            // lbNgayDatHang
            // 
            this.lbNgayDatHang.AutoSize = true;
            this.lbNgayDatHang.Location = new System.Drawing.Point(164, 124);
            this.lbNgayDatHang.Name = "lbNgayDatHang";
            this.lbNgayDatHang.Size = new System.Drawing.Size(20, 17);
            this.lbNgayDatHang.TabIndex = 2;
            this.lbNgayDatHang.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày đặt hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tình trạng đơn hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã đơn hàng:";
            // 
            // lbThoiHan
            // 
            this.lbThoiHan.AutoSize = true;
            this.lbThoiHan.Location = new System.Drawing.Point(346, 40);
            this.lbThoiHan.Name = "lbThoiHan";
            this.lbThoiHan.Size = new System.Drawing.Size(20, 17);
            this.lbThoiHan.TabIndex = 2;
            this.lbThoiHan.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Thời hạn:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(174, 701);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(227, 34);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Trở lại trang quản lý";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNhanHang
            // 
            this.btnNhanHang.Location = new System.Drawing.Point(484, 701);
            this.btnNhanHang.Name = "btnNhanHang";
            this.btnNhanHang.Size = new System.Drawing.Size(227, 34);
            this.btnNhanHang.TabIndex = 12;
            this.btnNhanHang.Text = "Xác nhận đã nhận hàng";
            this.btnNhanHang.UseVisualStyleBackColor = true;
            this.btnNhanHang.Click += new System.EventHandler(this.btnNhanHang_Click);
            // 
            // frmOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 760);
            this.Controls.Add(this.btnNhanHang);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label10);
            this.Name = "frmOrderDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết đơn hàng";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguyenLieuDatHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdChuaNhan;
        private System.Windows.Forms.RadioButton rdDaNhan;
        private System.Windows.Forms.Label lbMaDonHang;
        private System.Windows.Forms.Label lbIdManager;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvNguyenLieuDatHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbThoiHan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNhanHang;
        private System.Windows.Forms.Label lbNgayDatHang;
        private System.Windows.Forms.Label label3;
    }
}