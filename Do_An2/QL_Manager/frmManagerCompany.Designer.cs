namespace Do_An2
{
    partial class frmManagerCompany
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbSource = new System.Windows.Forms.ComboBox();
            this.btnRegisterCompany = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvAllSource = new System.Windows.Forms.DataGridView();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtIDCompany = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDeleteCompanySelect = new System.Windows.Forms.Button();
            this.btnFindCompanyName = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvAllCompany = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFindCompanyName = new System.Windows.Forms.TextBox();
            this.txtFindIdCompany = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllCompany)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(731, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản Lý Nhà Cung Cấp Nguyên Liệu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.cbSource);
            this.groupBox1.Controls.Add(this.btnRegisterCompany);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtCompanyName);
            this.groupBox1.Controls.Add(this.txtIDCompany);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(78, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1276, 308);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đăng ký nhà cung cấp nguyên liệu mới";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(153, 251);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(248, 34);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Đăng ký nguyên liệu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbSource
            // 
            this.cbSource.FormattingEnabled = true;
            this.cbSource.Location = new System.Drawing.Point(153, 178);
            this.cbSource.Name = "cbSource";
            this.cbSource.Size = new System.Drawing.Size(248, 24);
            this.cbSource.TabIndex = 5;
            // 
            // btnRegisterCompany
            // 
            this.btnRegisterCompany.Location = new System.Drawing.Point(1101, 109);
            this.btnRegisterCompany.Name = "btnRegisterCompany";
            this.btnRegisterCompany.Size = new System.Drawing.Size(151, 110);
            this.btnRegisterCompany.TabIndex = 5;
            this.btnRegisterCompany.Text = "Đăng ký";
            this.btnRegisterCompany.UseVisualStyleBackColor = true;
            this.btnRegisterCompany.Click += new System.EventHandler(this.btnRegisterCompany_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvAllSource);
            this.groupBox2.Location = new System.Drawing.Point(445, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(635, 250);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh mục nguyên liệu";
            // 
            // dgvAllSource
            // 
            this.dgvAllSource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllSource.Location = new System.Drawing.Point(7, 36);
            this.dgvAllSource.Name = "dgvAllSource";
            this.dgvAllSource.RowHeadersWidth = 51;
            this.dgvAllSource.RowTemplate.Height = 24;
            this.dgvAllSource.Size = new System.Drawing.Size(622, 189);
            this.dgvAllSource.TabIndex = 0;
            this.dgvAllSource.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllSource_CellContentClick);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(153, 214);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(248, 22);
            this.txtPrice.TabIndex = 3;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(153, 143);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(248, 22);
            this.txtPhone.TabIndex = 3;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(153, 109);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(248, 22);
            this.txtAddress.TabIndex = 3;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(153, 71);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(248, 22);
            this.txtCompanyName.TabIndex = 3;
            // 
            // txtIDCompany
            // 
            this.txtIDCompany.Location = new System.Drawing.Point(153, 35);
            this.txtIDCompany.Name = "txtIDCompany";
            this.txtIDCompany.Size = new System.Drawing.Size(248, 22);
            this.txtIDCompany.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số điện thoại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên nhà cung cấp:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Đơn giá:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nguyên liệu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã nhà cung cấp:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDeleteCompanySelect);
            this.groupBox3.Controls.Add(this.btnFindCompanyName);
            this.groupBox3.Controls.Add(this.btnFind);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.dgvAllCompany);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtFindCompanyName);
            this.groupBox3.Controls.Add(this.txtFindIdCompany);
            this.groupBox3.Location = new System.Drawing.Point(78, 419);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1276, 374);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách nhà cung cấp nguyên liệu";
            // 
            // btnDeleteCompanySelect
            // 
            this.btnDeleteCompanySelect.Location = new System.Drawing.Point(1060, 74);
            this.btnDeleteCompanySelect.Name = "btnDeleteCompanySelect";
            this.btnDeleteCompanySelect.Size = new System.Drawing.Size(177, 33);
            this.btnDeleteCompanySelect.TabIndex = 5;
            this.btnDeleteCompanySelect.Text = "Xóa các mục đã chọn";
            this.btnDeleteCompanySelect.UseVisualStyleBackColor = true;
            this.btnDeleteCompanySelect.Click += new System.EventHandler(this.btnDeleteCompanySelect_Click);
            // 
            // btnFindCompanyName
            // 
            this.btnFindCompanyName.Location = new System.Drawing.Point(473, 61);
            this.btnFindCompanyName.Name = "btnFindCompanyName";
            this.btnFindCompanyName.Size = new System.Drawing.Size(75, 23);
            this.btnFindCompanyName.TabIndex = 4;
            this.btnFindCompanyName.Text = "Tìm";
            this.btnFindCompanyName.UseVisualStyleBackColor = true;
            this.btnFindCompanyName.Click += new System.EventHandler(this.btnFindCompanyName_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(473, 29);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Tìm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Tìm theo tên nhà cung cấp:";
            // 
            // dgvAllCompany
            // 
            this.dgvAllCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllCompany.Location = new System.Drawing.Point(32, 113);
            this.dgvAllCompany.Name = "dgvAllCompany";
            this.dgvAllCompany.RowHeadersWidth = 51;
            this.dgvAllCompany.RowTemplate.Height = 24;
            this.dgvAllCompany.Size = new System.Drawing.Size(1205, 206);
            this.dgvAllCompany.TabIndex = 0;
            this.dgvAllCompany.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllCompany_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Tìm theo mã nhà cung cấp:";
            // 
            // txtFindCompanyName
            // 
            this.txtFindCompanyName.Location = new System.Drawing.Point(229, 61);
            this.txtFindCompanyName.Name = "txtFindCompanyName";
            this.txtFindCompanyName.Size = new System.Drawing.Size(223, 22);
            this.txtFindCompanyName.TabIndex = 3;
            // 
            // txtFindIdCompany
            // 
            this.txtFindIdCompany.Location = new System.Drawing.Point(229, 29);
            this.txtFindIdCompany.Name = "txtFindIdCompany";
            this.txtFindIdCompany.Size = new System.Drawing.Size(223, 22);
            this.txtFindIdCompany.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(604, 813);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(227, 34);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Trở lại trang quản lý";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmManagerCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 885);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmManagerCompany";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhà cung cấp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllCompany)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtIDCompany;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegisterCompany;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvAllSource;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvAllCompany;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFindIdCompany;
        private System.Windows.Forms.Button btnDeleteCompanySelect;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnFindCompanyName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFindCompanyName;
    }
}