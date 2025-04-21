namespace QuanLyBanHang
{
    partial class frmDonHangChiTiet
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThemDHCT = new System.Windows.Forms.Button();
            this.btnThemDBHCT = new System.Windows.Forms.Button();
            this.btnXoaDBHCT = new System.Windows.Forms.Button();
            this.cmbMaSanPham = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMaDH = new System.Windows.Forms.TextBox();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.txtMaDBHCT = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvDanhSachChiTiet = new System.Windows.Forms.DataGridView();
            this.label22 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThemDHCT);
            this.panel2.Controls.Add(this.btnThemDBHCT);
            this.panel2.Controls.Add(this.btnXoaDBHCT);
            this.panel2.Controls.Add(this.cmbMaSanPham);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtMaDH);
            this.panel2.Controls.Add(this.txtTenSanPham);
            this.panel2.Controls.Add(this.txtSoLuong);
            this.panel2.Controls.Add(this.txtDonGia);
            this.panel2.Controls.Add(this.label24);
            this.panel2.Controls.Add(this.txtDVT);
            this.panel2.Controls.Add(this.txtMaDBHCT);
            this.panel2.Location = new System.Drawing.Point(4, 38);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(883, 189);
            this.panel2.TabIndex = 1;
            // 
            // btnThemDHCT
            // 
            this.btnThemDHCT.Location = new System.Drawing.Point(750, 128);
            this.btnThemDHCT.Name = "btnThemDHCT";
            this.btnThemDHCT.Size = new System.Drawing.Size(113, 31);
            this.btnThemDHCT.TabIndex = 5;
            this.btnThemDHCT.Text = "Thêm DHCT";
            this.btnThemDHCT.UseVisualStyleBackColor = true;
            this.btnThemDHCT.Click += new System.EventHandler(this.btnThemDHCT_Click);
            // 
            // btnThemDBHCT
            // 
            this.btnThemDBHCT.Location = new System.Drawing.Point(769, 6);
            this.btnThemDBHCT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemDBHCT.Name = "btnThemDBHCT";
            this.btnThemDBHCT.Size = new System.Drawing.Size(92, 24);
            this.btnThemDBHCT.TabIndex = 3;
            this.btnThemDBHCT.Text = "Thêm";
            this.btnThemDBHCT.UseVisualStyleBackColor = true;
            this.btnThemDBHCT.Click += new System.EventHandler(this.btnThemDBHCT_Click);
            // 
            // btnXoaDBHCT
            // 
            this.btnXoaDBHCT.Location = new System.Drawing.Point(769, 44);
            this.btnXoaDBHCT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaDBHCT.Name = "btnXoaDBHCT";
            this.btnXoaDBHCT.Size = new System.Drawing.Size(92, 24);
            this.btnXoaDBHCT.TabIndex = 3;
            this.btnXoaDBHCT.Text = "Xóa";
            this.btnXoaDBHCT.UseVisualStyleBackColor = true;
            this.btnXoaDBHCT.Click += new System.EventHandler(this.btnXoaDBHCT_Click);
            // 
            // cmbMaSanPham
            // 
            this.cmbMaSanPham.FormattingEnabled = true;
            this.cmbMaSanPham.Location = new System.Drawing.Point(114, 100);
            this.cmbMaSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMaSanPham.Name = "cmbMaSanPham";
            this.cmbMaSanPham.Size = new System.Drawing.Size(129, 24);
            this.cmbMaSanPham.TabIndex = 4;
            this.cmbMaSanPham.SelectedValueChanged += new System.EventHandler(this.cmbMaSanPham_SelectedValueChanged_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(769, 83);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 24);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sửa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 143);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 16);
            this.label17.TabIndex = 0;
            this.label17.Text = "ĐVT";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(350, 103);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 16);
            this.label16.TabIndex = 0;
            this.label16.Text = "Đơn giá";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(348, 63);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 16);
            this.label15.TabIndex = 0;
            this.label15.Text = "Số lượng";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(348, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "Tên sản phẩm";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 106);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Mã sản phẩm";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Mã DBHCT";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(-3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Thông tin sản phẩm";
            // 
            // txtMaDH
            // 
            this.txtMaDH.Location = new System.Drawing.Point(114, 18);
            this.txtMaDH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaDH.Name = "txtMaDH";
            this.txtMaDH.Size = new System.Drawing.Size(130, 22);
            this.txtMaDH.TabIndex = 2;
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Location = new System.Drawing.Point(468, 18);
            this.txtTenSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(130, 22);
            this.txtTenSanPham.TabIndex = 2;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(468, 58);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(130, 22);
            this.txtSoLuong.TabIndex = 2;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged_1);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(468, 103);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(130, 22);
            this.txtDonGia.TabIndex = 2;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 23);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(49, 16);
            this.label24.TabIndex = 1;
            this.label24.Text = "Mã DH";
            // 
            // txtDVT
            // 
            this.txtDVT.Location = new System.Drawing.Point(114, 138);
            this.txtDVT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(130, 22);
            this.txtDVT.TabIndex = 2;
            // 
            // txtMaDBHCT
            // 
            this.txtMaDBHCT.Location = new System.Drawing.Point(114, 57);
            this.txtMaDBHCT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaDBHCT.Name = "txtMaDBHCT";
            this.txtMaDBHCT.Size = new System.Drawing.Size(130, 22);
            this.txtMaDBHCT.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvDanhSachChiTiet);
            this.panel4.Controls.Add(this.label22);
            this.panel4.Location = new System.Drawing.Point(2, 231);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(881, 212);
            this.panel4.TabIndex = 3;
            // 
            // dgvDanhSachChiTiet
            // 
            this.dgvDanhSachChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachChiTiet.Location = new System.Drawing.Point(3, 27);
            this.dgvDanhSachChiTiet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDanhSachChiTiet.Name = "dgvDanhSachChiTiet";
            this.dgvDanhSachChiTiet.RowHeadersWidth = 62;
            this.dgvDanhSachChiTiet.RowTemplate.Height = 28;
            this.dgvDanhSachChiTiet.Size = new System.Drawing.Size(876, 170);
            this.dgvDanhSachChiTiet.TabIndex = 2;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(3, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(170, 16);
            this.label22.TabIndex = 0;
            this.label22.Text = "Danh sách đơn hàng chi tiết";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Đơn hàng chi tiết";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(2, 457);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 51);
            this.panel1.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(733, 513);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 24);
            this.button2.TabIndex = 6;
            this.button2.Text = "Quay về";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmDonHangChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(879, 537);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDonHangChiTiet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDonHangChiTiet";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDonHangChiTiet_FormClosed);
            this.Load += new System.EventHandler(this.frmDonHangChiTiet_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachChiTiet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnThemDBHCT;
        private System.Windows.Forms.Button btnXoaDBHCT;
        private System.Windows.Forms.ComboBox cmbMaSanPham;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMaDH;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.TextBox txtMaDBHCT;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvDanhSachChiTiet;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThemDHCT;
        private System.Windows.Forms.Button button2;
    }
}