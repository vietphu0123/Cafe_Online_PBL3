namespace Do_An2
{
    partial class QuanLyMenu
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddC = new System.Windows.Forms.Button();
            this.btnDelC = new System.Windows.Forms.Button();
            this.btnAddD = new System.Windows.Forms.Button();
            this.btnDelD = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnUpD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý đồ uống";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(50, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(212, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnAddC
            // 
            this.btnAddC.Location = new System.Drawing.Point(50, 261);
            this.btnAddC.Name = "btnAddC";
            this.btnAddC.Size = new System.Drawing.Size(114, 47);
            this.btnAddC.TabIndex = 2;
            this.btnAddC.Text = "Thêm loại đồ uống";
            this.btnAddC.UseVisualStyleBackColor = true;
            this.btnAddC.Click += new System.EventHandler(this.btnAddC_Click);
            // 
            // btnDelC
            // 
            this.btnDelC.Location = new System.Drawing.Point(187, 261);
            this.btnDelC.Name = "btnDelC";
            this.btnDelC.Size = new System.Drawing.Size(75, 47);
            this.btnDelC.TabIndex = 3;
            this.btnDelC.Text = "Xóa loại đồ uống";
            this.btnDelC.UseVisualStyleBackColor = true;
            this.btnDelC.Click += new System.EventHandler(this.btnDelC_Click);
            // 
            // btnAddD
            // 
            this.btnAddD.Location = new System.Drawing.Point(307, 261);
            this.btnAddD.Name = "btnAddD";
            this.btnAddD.Size = new System.Drawing.Size(98, 47);
            this.btnAddD.TabIndex = 4;
            this.btnAddD.Text = "Thêm đồ uống";
            this.btnAddD.UseVisualStyleBackColor = true;
            this.btnAddD.Click += new System.EventHandler(this.btnAddD_Click);
            // 
            // btnDelD
            // 
            this.btnDelD.Location = new System.Drawing.Point(437, 261);
            this.btnDelD.Name = "btnDelD";
            this.btnDelD.Size = new System.Drawing.Size(95, 47);
            this.btnDelD.TabIndex = 5;
            this.btnDelD.Text = "Xóa đồ uống";
            this.btnDelD.UseVisualStyleBackColor = true;
            this.btnDelD.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(295, 85);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(361, 150);
            this.dataGridView2.TabIndex = 6;
            // 
            // btnUpD
            // 
            this.btnUpD.Location = new System.Drawing.Point(556, 261);
            this.btnUpD.Name = "btnUpD";
            this.btnUpD.Size = new System.Drawing.Size(75, 47);
            this.btnUpD.TabIndex = 7;
            this.btnUpD.Text = "Cập nhật";
            this.btnUpD.UseVisualStyleBackColor = true;
            this.btnUpD.Click += new System.EventHandler(this.btnUpD_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpD);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnDelD);
            this.Controls.Add(this.btnAddD);
            this.Controls.Add(this.btnDelC);
            this.Controls.Add(this.btnAddC);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
   //         this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddC;
        private System.Windows.Forms.Button btnDelC;
        private System.Windows.Forms.Button btnAddD;
        private System.Windows.Forms.Button btnDelD;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnUpD;
    }
}

