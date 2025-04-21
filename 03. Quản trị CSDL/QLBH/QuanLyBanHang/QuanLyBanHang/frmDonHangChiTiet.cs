using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class frmDonHangChiTiet : Form
    {
        string sCon = "Data Source=DESKTOP-77G8KNL;Initial Catalog=QLBanhang;Integrated Security=True";
        public bool tongTien = false;
        public frmDonHangChiTiet()
        {
            InitializeComponent();
        }
        private string _maDonHang;

        public frmDonHangChiTiet(string maDonHang)
        {
            InitializeComponent();
            _maDonHang = maDonHang;
        }
        private void frmDonHangChiTiet_Load(object sender, EventArgs e)
        {
            LoadDanhSachDonBanHangChiTiet();
            LoadComboBoxMaSanPham();
            //LoadComboBoxMaKhachHang();
            txtMaDH.Text = _maDonHang;
        }
        private void LoadDanhSachDonBanHangChiTiet()
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
            }


            // Load dữ liệu bảng DonBanHangChiTiet
            try
            {
                string sQueryDonHangChiTiet = "SELECT * FROM DonBanHangChiTiet";
                SqlDataAdapter adapterDonHangChiTiet = new SqlDataAdapter(sQueryDonHangChiTiet, con);
                DataSet dsDonHangChiTiet = new DataSet();
                adapterDonHangChiTiet.Fill(dsDonHangChiTiet, "DonBanHangChiTiet");
                dgvDanhSachChiTiet.DataSource = dsDonHangChiTiet.Tables["DonBanHangChiTiet"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu DonBanHangChiTiet: " + ex.Message);
            }
        }

        private void LoadComboBoxMaSanPham()
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
            }



            // Load dữ liệu vào cmbMaSanPham từ bảng SanPham
            try
            {
                string sQuerySanPham = "SELECT MaSP FROM SanPham";  // Truy vấn lấy MaSP từ bảng SanPham
                SqlDataAdapter adapterSanPham = new SqlDataAdapter(sQuerySanPham, con);
                DataTable dtSanPham = new DataTable();
                adapterSanPham.Fill(dtSanPham);

                if (dtSanPham.Rows.Count > 0)
                {
                    cmbMaSanPham.DisplayMember = "MaSP";  // Hiển thị cột MaSP trong ComboBox
                    cmbMaSanPham.ValueMember = "MaSP";    // Gán giá trị thật là MaSP
                    cmbMaSanPham.DataSource = dtSanPham;  // Gắn dữ liệu vào ComboBox
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu mã sản phẩm trong bảng SanPham.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu SanPham: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        // Sự kiện khi chọn mã sản phẩm từ ComboBox
        private void cmbMaSanPham_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbMaSanPham.SelectedValue == null)
            {
                txtTenSanPham.Text = ""; // Xóa nội dung nếu không có giá trị nào được chọn
                return;
            }

            using (SqlConnection con = new SqlConnection(sCon))
            {
                try
                {
                    con.Open();

                    // Lấy mã sản phẩm từ ComboBox
                    string maSP = cmbMaSanPham.SelectedValue.ToString();

                    // Truy vấn SQL
                    string sQuery = "SELECT TenSP FROM SanPham WHERE MaSP = @MaSP";
                    using (SqlCommand cmd = new SqlCommand(sQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@MaSP", maSP);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Hiển thị tên sản phẩm
                                txtTenSanPham.Text = reader["TenSP"].ToString();
                            }
                            else
                            {
                                txtTenSanPham.Text = "";
                                MessageBox.Show("Không tìm thấy sản phẩm với mã này.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lấy tên sản phẩm: " + ex.Message);
                }
            }
        }


        private void cmbMaSanPham_SelectedValueChanged_1(object sender, EventArgs e)
        {
            if (cmbMaSanPham.SelectedValue == null)
            {
                txtTenSanPham.Text = ""; // Xóa nội dung nếu không có giá trị nào được chọn
                return;
            }

            using (SqlConnection con = new SqlConnection(sCon))
            {
                try
                {
                    con.Open();

                    // Lấy mã sản phẩm từ ComboBox
                    string maSP = cmbMaSanPham.SelectedValue.ToString();

                    // Truy vấn SQL
                    //string sQuery = "SELECT TenSP FROM SanPham WHERE MaSP = @MaSP";
                    string sQuery = "SELECT SanPham.TenSP, GiaSanPham.Gia, SanPham.DVT, SanPham.SoLuong " +
                           "FROM SanPham " + "INNER JOIN GiaSanPham ON SanPham.MaSP = GiaSanPham.MaSP " +
                           "WHERE SanPham.MaSP = @MaSP";
                    using (SqlCommand cmd = new SqlCommand(sQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@MaSP", maSP);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Hiển thị tên sản phẩm
                                txtTenSanPham.Text = reader["TenSP"].ToString();
                                txtDonGia.Text = reader["Gia"].ToString();
                                txtDVT.Text = reader["DVT"].ToString();
                                txtSoLuong.Text = reader["SoLuong"].ToString();
                            }
                            else
                            {
                                txtTenSanPham.Text = "";
                                txtDonGia.Text = "";
                                MessageBox.Show("Không tìm thấy sản phẩm với mã này.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lấy tên sản phẩm: " + ex.Message);
                }
            }
        }

        private void btnThemDBHCT_Click(object sender, EventArgs e)
        {

                string maDH = txtMaDH.Text;
            try
            {
                // Lấy dữ liệu từ các TextBox và ComboBox
                string maDHCT = txtMaDBHCT.Text;
                int soLuong = int.Parse(txtSoLuong.Text);
                decimal donGia = decimal.Parse(txtDonGia.Text);
                string dvt = txtDVT.Text;
                string maSP = cmbMaSanPham.SelectedValue.ToString();

                // Thực hiện câu lệnh SQL để thêm dữ liệu
                string insertQuery = "INSERT INTO DonBanHangChiTiet (MaDHCT, SoLuong, DonGia, DVT, MaSP, MaDH) " +
                                     "VALUES (@maDHCT, @SoLuong, @DonGia, @DVT, @MaSP, @MaDH)";

                using (SqlConnection connection = new SqlConnection(sCon))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(insertQuery, connection);
                    command.Parameters.AddWithValue("@MaDHCT", maDHCT);
                    command.Parameters.AddWithValue("@SoLuong", soLuong);
                    command.Parameters.AddWithValue("@DonGia", donGia);
                    command.Parameters.AddWithValue("@DVT", dvt);
                    command.Parameters.AddWithValue("@MaSP", maSP);
                    command.Parameters.AddWithValue("@MaDH", maDH);
                    command.ExecuteNonQuery();
                }

                // Cập nhật lại danh sách đơn hàng chi tiết
                LoadDanhSachDonBanHangChiTiet();
                MessageBox.Show("Thêm mới thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtSoLuong_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnThemDHCT_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(sCon))
                {
                    con.Open();

                    // 1. Gọi hàm fn_maDHMoi() từ SQL Server
                    using (SqlCommand cmd = new SqlCommand("SELECT dbo.fn_maDHCTMoi()", con))
                    {
                        string maDHCTMoi = (string)cmd.ExecuteScalar(); // Thực thi và lấy giá trị trả về

                        // 2. Hiển thị mã đơn hàng mới trong textbox
                        txtMaDBHCT.Text = maDHCTMoi;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo mã đơn hàng mới: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmDonHangChiTiet_FormClosed(object sender, FormClosedEventArgs e)
        {
            tongTien = true;
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối tới DB");
            }

            string sSoLuong = txtSoLuong.Text;
            string sDonGia = txtDonGia.Text;
            string sMaDBHCT = txtMaDH.Text;
            string sQuery = "update donHangBan set SoLuong = @SoLuong, DonGia=@DonGia where maDBHCT = @maDBHCT";

            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@SL", sSoLuong);
            cmd.Parameters.AddWithValue("@maDBHCT", sMaDBHCT);
            cmd.Parameters.AddWithValue("@Dongia", sDonGia);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật");
            }



            string sQuerry = "select * from DonBanHangChiTiet";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuerry, con);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "DonBanHangChiTiet");

            dgvDanhSachChiTiet.DataSource = ds.Tables["DonBanHangChiTiet"];

            con.Close();



        }

        private void btnXoaDBHCT_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn muốn xoá?", "Thông báo", MessageBoxButtons.OKCancel);
            if (ret == DialogResult.OK)
            {
                // Bước 1
                SqlConnection con = new SqlConnection(sCon);
                try
                {
                    con.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");

                }
                //Bước 2
                //Lấy giá trị
                string sMaDBHCT = txtMaDBHCT.Text;

                string sQuery = "delete DonHangChiTiet where MaDBHCT = @maDBHCT";
                SqlCommand cmd = new SqlCommand(sQuery, con);
                cmd.Parameters.AddWithValue("@maDBHCT", sMaDBHCT);


                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xoá thành công!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Xảy ra lỗi trong quá trình xoá");
                }


                string sQuerry = "select * from DonBanHangChiTiet";
                SqlDataAdapter adapter = new SqlDataAdapter(sQuerry, con);

                DataSet ds = new DataSet();

                adapter.Fill(ds, "DonBanHangChiTiet");

                dgvDanhSachChiTiet.DataSource = ds.Tables["DonBanHangChiTiet"];
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmDonBanHang donBanHang = new frmDonBanHang();
            donBanHang.MdiParent = this;
            donBanHang.Show();
        }
    }
}
    
