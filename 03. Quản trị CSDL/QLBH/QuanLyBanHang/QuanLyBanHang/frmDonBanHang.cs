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
    public partial class frmDonBanHang : Form
    {
        string sCon = "Data Source=DESKTOP-77G8KNL;Initial Catalog=QLBanhang;Integrated Security=True";
        public bool tongTien = false;
        public frmDonBanHang()
        {
            
            InitializeComponent();
            List<string> loaiDonHangItems = new List<string>
            {
                "0",
                "1"
            };

            // Khởi tạo danh sách giá trị cho ComboBox trạng thái đơn hàng
            List<string> trangThaiDonHangItems = new List<string>
            {
                "Đã giao",
                "Chưa giao"
            };

            // Gán danh sách vào các ComboBox
            cbbLoaiDH.DataSource = loaiDonHangItems;
            cbbTTDH.DataSource = trangThaiDonHangItems;
            if (cbbLoaiDH.SelectedValue != null && decimal.TryParse(txtKhoangCach.Text, out decimal khoangCach))
            {
                string loaiDH = cbbLoaiDH.SelectedValue.ToString();
                decimal phiVanChuyen = 0;

                if (loaiDH == "1") // Loại đơn hàng 1: Tính phí theo khoảng cách
                {
                    if (khoangCach >= 5)
                    {
                        phiVanChuyen = 30000;
                    }
                }

                txtPhiShip.Text = phiVanChuyen.ToString("N0");
            }
            else
            {
                txtPhiShip.Text = "0"; // Hoặc xử lý khác nếu cần
            }

        }
        private void frmDonBanHang_Load(object sender, EventArgs e)
        {
            LoadDanhSachDonBanHang();
            //LoadDanhSachDonBanHangChiTiet();
            LoadComboBoxMaDVGH();
            //LoadComboBoxMaSanPham();
            LoadComboBoxMaKhachHang();
        }
        private void LoadDanhSachDonBanHang()
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
            string sQuerry = "Select * from DonBanHang";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuerry, con);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "DonBanHang");

            dgvDanhSachDonHang.DataSource = ds.Tables["DonBanHang"];

            con.Close();

            string s1Querry = "Select * from DonBanHangChiTiet";
            SqlDataAdapter adapter1 = new SqlDataAdapter(s1Querry, con);

            //DataSet ds1 = new DataSet();

            //adapter1.Fill(ds1, "DonBanHangChiTiet");

            //dgvDanhSachChiTiet.DataSource = ds1.Tables["DonBanHangChiTiet"];

            con.Close();
        }

        //private void LoadDanhSachDonBanHangChiTiet()
        //{
        //    SqlConnection con = new SqlConnection(sCon);
        //    try
        //    {
        //        con.Open();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
        //    }


        //    // Load dữ liệu bảng DonBanHangChiTiet
        //    try
        //    {
        //        string sQueryDonHangChiTiet = "SELECT * FROM DonBanHangChiTiet";
        //        SqlDataAdapter adapterDonHangChiTiet = new SqlDataAdapter(sQueryDonHangChiTiet, con);
        //        DataSet dsDonHangChiTiet = new DataSet();
        //        adapterDonHangChiTiet.Fill(dsDonHangChiTiet, "DonBanHangChiTiet");
        //        dgvDanhSachChiTiet.DataSource = dsDonHangChiTiet.Tables["DonBanHangChiTiet"];
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi khi tải dữ liệu DonBanHangChiTiet: " + ex.Message);
        //    }
        //}
        private void LoadComboBoxMaDVGH()
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

            // Load dữ liệu vào cmbMaDVGH từ DonViGiaoHang
            try
            {
                string sQueryDonViGiaoHang = "SELECT MaDV FROM DonViGiaoHang";
                SqlDataAdapter adapterDonViGiaoHang = new SqlDataAdapter(sQueryDonViGiaoHang, con);
                DataTable dtDonViGiaoHang = new DataTable();
                adapterDonViGiaoHang.Fill(dtDonViGiaoHang);

                // Kiểm tra nếu dữ liệu tồn tại
                if (dtDonViGiaoHang.Rows.Count > 0)
                {
                    cmbMaDVGH.DisplayMember = "MaDV"; // Hiển thị cột MaDV trong ComboBox
                    cmbMaDVGH.ValueMember = "MaDV";   // Gán giá trị thật là MaDV
                    cmbMaDVGH.DataSource = dtDonViGiaoHang; // Gắn dữ liệu vào ComboBox
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu mã đơn vị vận chuyển trong bảng DonViVanChuyen.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu DonViGiaoHang: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        //private void LoadComboBoxMaSanPham()
        //{
        //    SqlConnection con = new SqlConnection(sCon);
        //    try
        //    {
        //        con.Open();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
        //    }



        //    // Load dữ liệu vào cmbMaSanPham từ bảng SanPham
        //    try
        //    {
        //        string sQuerySanPham = "SELECT MaSP FROM SanPham";  // Truy vấn lấy MaSP từ bảng SanPham
        //        SqlDataAdapter adapterSanPham = new SqlDataAdapter(sQuerySanPham, con);
        //        DataTable dtSanPham = new DataTable();
        //        adapterSanPham.Fill(dtSanPham);

        //        if (dtSanPham.Rows.Count > 0)
        //        {
        //            cmbMaSanPham.DisplayMember = "MaSP";  // Hiển thị cột MaSP trong ComboBox
        //            cmbMaSanPham.ValueMember = "MaSP";    // Gán giá trị thật là MaSP
        //            cmbMaSanPham.DataSource = dtSanPham;  // Gắn dữ liệu vào ComboBox
        //        }
        //        else
        //        {
        //            MessageBox.Show("Không có dữ liệu mã sản phẩm trong bảng SanPham.");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi khi tải dữ liệu SanPham: " + ex.Message);
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
        //}
        
        private void LoadComboBoxMaKhachHang()
        {
            // Tạo kết nối đến cơ sở dữ liệu
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open(); // Mở kết nối
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB: " + ex.Message);
                return; // Nếu lỗi, thoát khỏi phương thức
            }

            // Load dữ liệu vào cmbMaKhachHang từ bảng KhachHang
            try
            {
                string sQueryKhachHang = "SELECT MaKH, TenKH FROM KhachHang"; // Truy vấn lấy MaKH và TenKH từ bảng KhachHang
                SqlDataAdapter adapterKhachHang = new SqlDataAdapter(sQueryKhachHang, con);
                DataTable dtKhachHang = new DataTable();
                adapterKhachHang.Fill(dtKhachHang);

                if (dtKhachHang.Rows.Count > 0)
                {
                    cmbMaKH.DisplayMember = "MaKH"; // Hiển thị mã khách hàng trong ComboBox
                    cmbMaKH.ValueMember = "MaKH";   // Gán giá trị thực là MaKH
                    cmbMaKH.DataSource = dtKhachHang; // Gắn dữ liệu vào ComboBox
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu mã khách hàng trong bảng KhachHang.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu KhachHang: " + ex.Message);
            }
            finally
            {
                con.Close(); // Đóng kết nối dù có lỗi hay không
            }
        }


        private void cmbMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaKH.SelectedValue == null)
                return; // Nếu không có lựa chọn, thoát khỏi hàm

            using (SqlConnection con = new SqlConnection(sCon))
            {
                try
                {
                    con.Open();
                    string maKH = cmbMaKH.SelectedValue.ToString();
                    string sQuery = "SELECT TenKH, SDTKH FROM KhachHang WHERE MaKH = @MaKH";
                    using (SqlCommand cmd = new SqlCommand(sQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@MaKH", maKH);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtTenKhachHang.Text = reader["TenKH"].ToString();
                                txtSDTKH.Text = reader["SDTKH"].ToString();
                            }
                            else
                            {
                                txtTenKhachHang.Text = "";
                                txtSDTKH.Text = "";
                                MessageBox.Show("Không tìm thấy khách hàng với mã này.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lấy tên khách hàng: " + ex.Message);
                }
            }
        }

        private void btnThemDonChiTiet_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các control trên form
            string maDonHang = txtMaDonHang.Text;
            string tenKhachHang = txtTenKhachHang.Text;
            string sdtKhachHang = txtSDTKH.Text;
            string maDVGH = cmbMaDVGH.SelectedValue.ToString();
            //decimal khoangCach = decimal.Parse(txtKhoangCach.Text);
            //decimal phiShip = decimal.Parse(txtPhiShip.Text);
            string trangThai = cbbTTDH.SelectedValue.ToString();
            //string loaiDH = cbbLoaiDH.SelectedValue.ToString();
            DateTime ngayLap = dateTimeNgayLap.Value;
            DateTime ngayShip = dateTimeNgayShip.Value;
            string maKH = cmbMaKH.SelectedValue.ToString();
            //decimal tongTien = decimal.Parse(txtTongTienDonHang.Text);
            // Tính phí vận chuyển
            //decimal phiVanChuyen;
            //using (SqlConnection con = new SqlConnection(sCon))
            //{
            //    con.Open();
            //    SqlCommand cmd = new SqlCommand("sp_TinhPhiVanChuyen", con);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.AddWithValue("@LoaiDonHang", loaiDH);
            //    cmd.Parameters.AddWithValue("@KhoangCach", khoangCach);
            //    cmd.Parameters.Add("@PhiVanChuyen", SqlDbType.Decimal).Direction = ParameterDirection.Output;
            //    cmd.ExecuteNonQuery();
            //    phiVanChuyen = (decimal)cmd.Parameters["@PhiVanChuyen"].Value;
            //}
            string loaiDH = cbbLoaiDH.SelectedValue?.ToString(); // Sử dụng ?. để tránh lỗi NullReferenceException
            decimal khoangCach = 0; // Khởi tạo giá trị mặc định
            if (!string.IsNullOrEmpty(txtKhoangCach.Text) && decimal.TryParse(txtKhoangCach.Text, out decimal parsedKhoangCach))
            {
                khoangCach = parsedKhoangCach;
            }

            // Tính phí vận chuyển
            decimal phiVanChuyen = 0;

            if (string.IsNullOrEmpty(loaiDH))
            {
                MessageBox.Show("Vui lòng chọn loại đơn hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Dừng xử lý nếu chưa chọn loại đơn hàng.
            }

            if (loaiDH == "0") // Loại đơn hàng 0: Miễn phí vận chuyển
            {
                phiVanChuyen = 0;
                khoangCach = 0; //Khoảng cách cũng bằng 0
            }
            else if (loaiDH == "1") // Loại đơn hàng 1: Tính phí theo khoảng cách
            {
                if (khoangCach >= 5)
                {
                    phiVanChuyen = 30000;
                }
            }
            else
            {
                MessageBox.Show("Loại đơn hàng không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Dừng xử lý nếu loại đơn hàng không hợp lệ.
            }


            txtPhiShip.Text = phiVanChuyen.ToString("N0");
            txtKhoangCach.Text = khoangCach.ToString();

            decimal tongTienHang = 0;
            using (SqlConnection con = new SqlConnection(sCon))
            {
                try
                {
                    con.Open();
                    string queryTongTienHang = "SELECT ISNULL(SUM(SoLuong * DonGia), 0) FROM DonBanHangChiTiet WHERE MaDH = @MaDH"; // ISNULL xử lý NULL
                    using (SqlCommand cmdTongTienHang = new SqlCommand(queryTongTienHang, con))
                    {
                        cmdTongTienHang.Parameters.AddWithValue("@MaDH", maDonHang);
                        tongTienHang = Convert.ToDecimal(cmdTongTienHang.ExecuteScalar());
                    }

                    // 4. Tính tổng tiền đơn hàng
                    decimal tongTienDonHang = phiVanChuyen + tongTienHang;
                    txtTongTienDonHang.Text = tongTienDonHang.ToString("N0");

                    // 5. Lưu đơn hàng vào database
                    string insertQuery = "INSERT INTO DonBanHang (MaDH, NgayLap, TongTien, LoaiDH, KhoangCach, PhiShip, TrangThaiDonHang, MaKH, MaDV) " +
                                       "VALUES (@MaDH, @NgayLap, @TongTien, @LoaiDH, @KhoangCach, @PhiShip, @TrangThaiDonHang, @MaKH, @MaDV)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@MaDH", maDonHang);
                        cmd.Parameters.AddWithValue("@NgayLap", ngayLap);
                        cmd.Parameters.AddWithValue("@TongTien", tongTienDonHang); // Lưu tổng tiền
                        cmd.Parameters.AddWithValue("@LoaiDH", loaiDH);
                        cmd.Parameters.AddWithValue("@KhoangCach", khoangCach);
                        cmd.Parameters.AddWithValue("@PhiShip", phiVanChuyen);
                        cmd.Parameters.AddWithValue("@TrangThaiDonHang", trangThai);
                        cmd.Parameters.AddWithValue("@MaKH", maKH);
                        cmd.Parameters.AddWithValue("@MaDV", maDVGH);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Đã lưu thông tin đơn hàng thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void btnThemChiTiet_Click(object sender, EventArgs e)
        {
            string maDonHang = txtMaDonHang.Text; // Lấy mã đơn hàng từ control txtMaDonHang
            frmDonHangChiTiet frmDonHangChiTiet = new frmDonHangChiTiet(maDonHang);
            this.Hide();
            frmDonHangChiTiet.ShowDialog();
            this.Show(); 
            
        }


        private void txtTrangThaiDonHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHuyDon_Click(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection(sCon))
            {
                try
                {
                    con.Open();
                    //string updateQuery = "UPDATE DonBanHang SET TrangThaiDonHang = 'Đã hủy' WHERE MaDH = @MaDH";
                    //SqlCommand cmd = new SqlCommand(updateQuery, con);
                    //cmd.Parameters.AddWithValue("@MaDH", txtMaDonHang);
                    //cmd.ExecuteNonQuery();

                    MessageBox.Show("Đã hủy đơn hàng thành công!");

                    // Clear the form after successful cancellation (optional)
                    txtMaDonHang.Text = "";
                    txtTenKhachHang.Text = "";
                    txtSDTKH.Text = "";
                    txtKhoangCach.Text = "";
                    txtTongTienDonHang.Text = "";
                    cbbLoaiDH.SelectedIndex = -1; // Hoặc cbbLoaiDH.SelectedIndex = 0; nếu muốn chọn mặc định
                    cbbTTDH.SelectedIndex = -1; // Hoặc cbbTTDH.SelectedIndex = 0; nếu muốn chọn mặc định
                    cmbMaKH.SelectedIndex = -1;
                    cmbMaDVGH.SelectedIndex = -1;
                    dateTimeNgayLap.Value = DateTime.Now;
                    dateTimeNgayShip.Value = DateTime.Now;
                    txtPhiShip.Text = "";
                    // ... clear other controls
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình hủy đơn hàng: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(sCon))
                {
                    con.Open();

                    // 1. Gọi hàm fn_maDHMoi() từ SQL Server
                    using (SqlCommand cmd = new SqlCommand("SELECT dbo.fn_maDHMoi()", con))
                    {
                        string maDHMoi = (string)cmd.ExecuteScalar(); // Thực thi và lấy giá trị trả về

                        // 2. Hiển thị mã đơn hàng mới trong textbox
                        txtMaDonHang.Text = maDHMoi;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo mã đơn hàng mới: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtKhoangCach_TextChanged(object sender, EventArgs e)
        {
            decimal khoangCach = decimal.Parse(txtKhoangCach.Text);
            string loaiDH = cbbLoaiDH.SelectedValue?.ToString(); // Sử dụng ?. để tránh lỗi NullReferenceException
            
            decimal phiVanChuyen = 0;
            if (string.IsNullOrEmpty(loaiDH))
            {
                MessageBox.Show("Vui lòng chọn loại đơn hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Dừng xử lý nếu chưa chọn loại đơn hàng.
            }

            if (loaiDH == "0") // Loại đơn hàng 0: Miễn phí vận chuyển
            {
                phiVanChuyen = 0;
                khoangCach = 0; //Khoảng cách cũng bằng 0
            }
            else if (loaiDH == "1") // Loại đơn hàng 1: Tính phí theo khoảng cách
            {
                if (khoangCach >= 5)
                {
                    phiVanChuyen = 30000;
                }
            }
            else
            {
                MessageBox.Show("Loại đơn hàng không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Dừng xử lý nếu loại đơn hàng không hợp lệ.
            }
            txtPhiShip.Text = phiVanChuyen.ToString("N0");
        }

        private void txtTongTienDonHang_TextChanged(object sender, EventArgs e)
        {
            //string maDonHang = txtMaDonHang.Text;

            //decimal tongTienHang = 0;
            //using (SqlConnection con = new SqlConnection(sCon))
            //{
            //    try
            //    {
            //        con.Open();
            //        string queryTongTienHang = "SELECT ISNULL(SUM(SoLuong * DonGia), 0) FROM DonBanHangChiTiet WHERE MaDH = @MaDH"; // ISNULL xử lý NULL
            //        using (SqlCommand cmdTongTienHang = new SqlCommand(queryTongTienHang, con))
            //        {
            //            cmdTongTienHang.Parameters.AddWithValue("@MaDH", maDonHang);
            //            tongTienHang = Convert.ToDecimal(cmdTongTienHang.ExecuteScalar());
            //        }

            //        // 4. Tính tổng tiền đơn hàng
            //        decimal tongTienDonHang = phiVanChuyen + tongTienHang;
            //        txtTongTienDonHang.Text = tongTienDonHang.ToString("N0");

            //    }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
        }
    }
}
