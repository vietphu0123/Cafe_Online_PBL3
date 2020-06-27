namespace Do_An2
{
    partial class frmManager
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTenQuanLy = new System.Windows.Forms.Label();
            this.lbCurrentTime = new System.Windows.Forms.Label();
            this.lnkDangXuat = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.lnkShowInfoManager = new System.Windows.Forms.LinkLabel();
            this.lnkCompany = new System.Windows.Forms.LinkLabel();
            this.lnkResource = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdOutOfDate = new System.Windows.Forms.RadioButton();
            this.rdNoReceived = new System.Windows.Forms.RadioButton();
            this.rdAllOrder = new System.Windows.Forms.RadioButton();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.lnkSource = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(383, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(507, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hệ Thống Người Quản Lý";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Xin chào quản lý: ";
            // 
            // lbTenQuanLy
            // 
            this.lbTenQuanLy.AutoSize = true;
            this.lbTenQuanLy.Location = new System.Drawing.Point(195, 138);
            this.lbTenQuanLy.Name = "lbTenQuanLy";
            this.lbTenQuanLy.Size = new System.Drawing.Size(20, 17);
            this.lbTenQuanLy.TabIndex = 1;
            this.lbTenQuanLy.Text = "...";
            this.lbTenQuanLy.Click += new System.EventHandler(this.lbTenQuanLy_Click);
            // 
            // lbCurrentTime
            // 
            this.lbCurrentTime.AutoSize = true;
            this.lbCurrentTime.Location = new System.Drawing.Point(66, 106);
            this.lbCurrentTime.Name = "lbCurrentTime";
            this.lbCurrentTime.Size = new System.Drawing.Size(79, 17);
            this.lbCurrentTime.TabIndex = 1;
            this.lbCurrentTime.Text = "Bây giờ: ... ";
            // 
            // lnkDangXuat
            // 
            this.lnkDangXuat.AutoSize = true;
            this.lnkDangXuat.Location = new System.Drawing.Point(274, 138);
            this.lnkDangXuat.Name = "lnkDangXuat";
            this.lnkDangXuat.Size = new System.Drawing.Size(72, 17);
            this.lnkDangXuat.TabIndex = 3;
            this.lnkDangXuat.TabStop = true;
            this.lnkDangXuat.Text = "Dang xuat";
            this.lnkDangXuat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDangXuat_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "DANH MỤC QUẢN LÝ";
            // 
            // lnkShowInfoManager
            // 
            this.lnkShowInfoManager.AutoSize = true;
            this.lnkShowInfoManager.Location = new System.Drawing.Point(66, 219);
            this.lnkShowInfoManager.Name = "lnkShowInfoManager";
            this.lnkShowInfoManager.Size = new System.Drawing.Size(218, 17);
            this.lnkShowInfoManager.TabIndex = 4;
            this.lnkShowInfoManager.TabStop = true;
            this.lnkShowInfoManager.Text = "1. Xem thông tin chi tiết tài khoản";
            this.lnkShowInfoManager.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkShowInfoManager_LinkClicked);
            // 
            // lnkCompany
            // 
            this.lnkCompany.AutoSize = true;
            this.lnkCompany.Location = new System.Drawing.Point(66, 306);
            this.lnkCompany.Name = "lnkCompany";
            this.lnkCompany.Size = new System.Drawing.Size(309, 17);
            this.lnkCompany.TabIndex = 4;
            this.lnkCompany.TabStop = true;
            this.lnkCompany.Text = "3. Quản lý thông tin nhà cung cấp (nguyên liệu)";
            this.lnkCompany.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCompany_LinkClicked);
            // 
            // lnkResource
            // 
            this.lnkResource.AutoSize = true;
            this.lnkResource.Location = new System.Drawing.Point(68, 351);
            this.lnkResource.Name = "lnkResource";
            this.lnkResource.Size = new System.Drawing.Size(238, 17);
            this.lnkResource.TabIndex = 4;
            this.lnkResource.TabStop = true;
            this.lnkResource.Text = "4. Quản lý đơn đặt hàng nguyên liệu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdOutOfDate);
            this.groupBox1.Controls.Add(this.rdNoReceived);
            this.groupBox1.Controls.Add(this.rdAllOrder);
            this.groupBox1.Controls.Add(this.dgvOrder);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(515, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(763, 238);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh mục đơn hàng";
            // 
            // rdOutOfDate
            // 
            this.rdOutOfDate.AutoSize = true;
            this.rdOutOfDate.Location = new System.Drawing.Point(452, 22);
            this.rdOutOfDate.Name = "rdOutOfDate";
            this.rdOutOfDate.Size = new System.Drawing.Size(189, 21);
            this.rdOutOfDate.TabIndex = 2;
            this.rdOutOfDate.TabStop = true;
            this.rdOutOfDate.Text = "đơn đặt hàng quá hạn";
            this.rdOutOfDate.UseVisualStyleBackColor = true;
            this.rdOutOfDate.CheckedChanged += new System.EventHandler(this.rdOutOfDate_CheckedChanged);
            // 
            // rdNoReceived
            // 
            this.rdNoReceived.AutoSize = true;
            this.rdNoReceived.Location = new System.Drawing.Point(216, 22);
            this.rdNoReceived.Name = "rdNoReceived";
            this.rdNoReceived.Size = new System.Drawing.Size(206, 21);
            this.rdNoReceived.TabIndex = 2;
            this.rdNoReceived.TabStop = true;
            this.rdNoReceived.Text = "đơn đặt hàng chưa nhận";
            this.rdNoReceived.UseVisualStyleBackColor = true;
            this.rdNoReceived.CheckedChanged += new System.EventHandler(this.rdNoReceived_CheckedChanged);
            // 
            // rdAllOrder
            // 
            this.rdAllOrder.AutoSize = true;
            this.rdAllOrder.Checked = true;
            this.rdAllOrder.Location = new System.Drawing.Point(22, 22);
            this.rdAllOrder.Name = "rdAllOrder";
            this.rdAllOrder.Size = new System.Drawing.Size(176, 21);
            this.rdAllOrder.TabIndex = 2;
            this.rdAllOrder.TabStop = true;
            this.rdAllOrder.Text = "Tất cả đơn đặt hàng";
            this.rdAllOrder.UseVisualStyleBackColor = true;
            this.rdAllOrder.CheckedChanged += new System.EventHandler(this.rdAllOrder_CheckedChanged);
            // 
            // dgvOrder
            // 
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(50, 57);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowHeadersWidth = 51;
            this.dgvOrder.RowTemplate.Height = 24;
            this.dgvOrder.Size = new System.Drawing.Size(665, 150);
            this.dgvOrder.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = " ";
            // 
            // lnkSource
            // 
            this.lnkSource.AutoSize = true;
            this.lnkSource.Location = new System.Drawing.Point(66, 264);
            this.lnkSource.Name = "lnkSource";
            this.lnkSource.Size = new System.Drawing.Size(150, 17);
            this.lnkSource.TabIndex = 4;
            this.lnkSource.TabStop = true;
            this.lnkSource.Text = "2. Quản lý nguyên liệu";
            this.lnkSource.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCompany_LinkClicked);
            // 
            // frmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 781);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lnkResource);
            this.Controls.Add(this.lnkSource);
            this.Controls.Add(this.lnkCompany);
            this.Controls.Add(this.lnkShowInfoManager);
            this.Controls.Add(this.lnkDangXuat);
            this.Controls.Add(this.lbTenQuanLy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbCurrentTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmManager";
            this.Text = "Trang Quản Lý";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTenQuanLy;
        private System.Windows.Forms.Label lbCurrentTime;
        private System.Windows.Forms.LinkLabel lnkDangXuat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lnkShowInfoManager;
        private System.Windows.Forms.LinkLabel lnkCompany;
        private System.Windows.Forms.LinkLabel lnkResource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdOutOfDate;
        private System.Windows.Forms.RadioButton rdNoReceived;
        private System.Windows.Forms.RadioButton rdAllOrder;
        private System.Windows.Forms.LinkLabel lnkSource;
    }
}