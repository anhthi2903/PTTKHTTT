namespace QuanLyBanHang
{
    partial class Form1
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
            this.labelKH = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSDTKH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiaChiKH = new System.Windows.Forms.TextBox();
            this.btnTaoMKH = new System.Windows.Forms.Button();
            this.btnLuuNCC = new System.Windows.Forms.Button();
            this.btbSuaKH = new System.Windows.Forms.Button();
            this.btnXoaKH = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxTenKH = new System.Windows.Forms.ComboBox();
            this.btnTimKH = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelKH
            // 
            this.labelKH.AutoSize = true;
            this.labelKH.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKH.Location = new System.Drawing.Point(237, 9);
            this.labelKH.Name = "labelKH";
            this.labelKH.Size = new System.Drawing.Size(315, 25);
            this.labelKH.TabIndex = 0;
            this.labelKH.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã khách hàng";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(34, 98);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(114, 22);
            this.txtMaKH.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên khách hàng";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(228, 98);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(114, 22);
            this.txtTenKH.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(450, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Số điện thoại";
            // 
            // txtSDTKH
            // 
            this.txtSDTKH.Location = new System.Drawing.Point(438, 98);
            this.txtSDTKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDTKH.Name = "txtSDTKH";
            this.txtSDTKH.Size = new System.Drawing.Size(114, 22);
            this.txtSDTKH.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(642, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Địa chỉ";
            // 
            // txtDiaChiKH
            // 
            this.txtDiaChiKH.Location = new System.Drawing.Point(645, 98);
            this.txtDiaChiKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiaChiKH.Name = "txtDiaChiKH";
            this.txtDiaChiKH.Size = new System.Drawing.Size(114, 22);
            this.txtDiaChiKH.TabIndex = 4;
            // 
            // btnTaoMKH
            // 
            this.btnTaoMKH.Location = new System.Drawing.Point(328, 169);
            this.btnTaoMKH.Name = "btnTaoMKH";
            this.btnTaoMKH.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnTaoMKH.Size = new System.Drawing.Size(106, 23);
            this.btnTaoMKH.TabIndex = 5;
            this.btnTaoMKH.Text = "Tạo mã KH";
            this.btnTaoMKH.UseVisualStyleBackColor = true;
            this.btnTaoMKH.Click += new System.EventHandler(this.btnTaoMKH_Click);
            // 
            // btnLuuNCC
            // 
            this.btnLuuNCC.Location = new System.Drawing.Point(479, 169);
            this.btnLuuNCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuuNCC.Name = "btnLuuNCC";
            this.btnLuuNCC.Size = new System.Drawing.Size(73, 27);
            this.btnLuuNCC.TabIndex = 6;
            this.btnLuuNCC.Text = "Lưu";
            this.btnLuuNCC.UseVisualStyleBackColor = true;
            this.btnLuuNCC.Click += new System.EventHandler(this.btnLuuNCC_Click);
            // 
            // btbSuaKH
            // 
            this.btbSuaKH.Location = new System.Drawing.Point(585, 169);
            this.btbSuaKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btbSuaKH.Name = "btbSuaKH";
            this.btbSuaKH.Size = new System.Drawing.Size(73, 27);
            this.btbSuaKH.TabIndex = 7;
            this.btbSuaKH.Text = "Sửa";
            this.btbSuaKH.UseVisualStyleBackColor = true;
            // 
            // btnXoaKH
            // 
            this.btnXoaKH.Location = new System.Drawing.Point(697, 167);
            this.btnXoaKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaKH.Name = "btnXoaKH";
            this.btnXoaKH.Size = new System.Drawing.Size(73, 27);
            this.btnXoaKH.TabIndex = 8;
            this.btnXoaKH.Text = "Xóa";
            this.btnXoaKH.UseVisualStyleBackColor = true;
            this.btnXoaKH.Click += new System.EventHandler(this.btnXoaKH_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tên khách hàng";
            // 
            // comboBoxTenKH
            // 
            this.comboBoxTenKH.FormattingEnabled = true;
            this.comboBoxTenKH.Location = new System.Drawing.Point(168, 217);
            this.comboBoxTenKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxTenKH.Name = "comboBoxTenKH";
            this.comboBoxTenKH.Size = new System.Drawing.Size(174, 24);
            this.comboBoxTenKH.TabIndex = 9;
            // 
            // btnTimKH
            // 
            this.btnTimKH.Location = new System.Drawing.Point(377, 215);
            this.btnTimKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKH.Name = "btnTimKH";
            this.btnTimKH.Size = new System.Drawing.Size(100, 27);
            this.btnTimKH.TabIndex = 10;
            this.btnTimKH.Text = "Tìm kiếm";
            this.btnTimKH.UseVisualStyleBackColor = true;
            this.btnTimKH.Click += new System.EventHandler(this.btnTimKH_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 279);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(691, 137);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnTimKH);
            this.Controls.Add(this.comboBoxTenKH);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnXoaKH);
            this.Controls.Add(this.btbSuaKH);
            this.Controls.Add(this.btnLuuNCC);
            this.Controls.Add(this.btnTaoMKH);
            this.Controls.Add(this.txtDiaChiKH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSDTKH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelKH);
            this.Name = "Form1";
            this.Text = "Khách hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSDTKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiaChiKH;
        private System.Windows.Forms.Button btnTaoMKH;
        private System.Windows.Forms.Button btnLuuNCC;
        private System.Windows.Forms.Button btbSuaKH;
        private System.Windows.Forms.Button btnXoaKH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxTenKH;
        private System.Windows.Forms.Button btnTimKH;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}