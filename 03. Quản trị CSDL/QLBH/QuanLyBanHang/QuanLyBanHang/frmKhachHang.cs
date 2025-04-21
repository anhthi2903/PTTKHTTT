using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QuanLyBanHang
{
    public partial class Form1 : Form
    {
        string sCon = "Data Source=DESKTOP-77G8KNL;Initial Catalog=QLBanhang;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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


            //lấy dữ liệu về 
            string sQuerry = "Select * from KhachHang";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuerry, con);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "KhachHang");

            dataGridView1.DataSource = ds.Tables["KhachHang"];

            con.Close();

            try
            {
                con.Open();

                // Truy vấn lấy danh sách mã nhà cung cấp
                string sQuery = "SELECT MaKH FROM KhachHang";
                SqlCommand cmd = new SqlCommand(sQuery, con);

                // Lấy dữ liệu vào DataTable
                SqlDataAdapter adapter1 = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter1.Fill(dt);

                // Điền các mã nhà cung cấp vào comboBox
                comboBoxTenKH.DisplayMember = "MaKH"; // Hiển thị tên cột mã nhà cung cấp
                comboBoxTenKH.ValueMember = "MaKH";   // Giá trị sử dụng là mã nhà cung cấp
                comboBoxTenKH.DataSource = dt;         // Gán dữ liệu vào comboBox
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Xin chào, hẹn gặp lại lần sau!!!", "Thông báo");
        }

        private void btnLuuNCC_Click(object sender, EventArgs e)
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
            //bước 2
            string sMaKH = txtMaKH.Text;
            string sTenKH = txtTenKH.Text;
            string sSdtKH = txtSDTKH.Text;
            string sDiaChiKH = txtDiaChiKH.Text;

            string sQuery = "insert into KhachHang values (@makh, @tenkh, @sdtkh, @diachikkh)";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@makh", sMaKH);
            cmd.Parameters.AddWithValue("@tenkh", sTenKH);
            cmd.Parameters.AddWithValue("@sdtkh", sSdtKH);
            cmd.Parameters.AddWithValue("@diachikkh", sDiaChiKH);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Lưu thành công!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình thêm mới!!!");
            }
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Gán dữ liệu từ hàng được chọn vào các TextBox
                txtMaKH.Text = row.Cells["MaKH"].Value.ToString();
                txtTenKH.Text = row.Cells["TenKH"].Value.ToString();
                txtSDTKH.Text = row.Cells["SDTKH"].Value.ToString();
                txtDiaChiKH.Text = row.Cells["DiaChiKH"].Value.ToString();
            }
            txtMaKH.Enabled = false;
        }

        private void btbSuaNCC_Click(object sender, EventArgs e)
        {
            // Thu thập dữ liệu mới từ các TextBox
            string sMaKH = txtMaKH.Text;
            string sTenKH = txtTenKH.Text;
            string sSdtKH = txtSDTKH.Text;
            string sDiaChiKH = txtDiaChiKH.Text;

            // Chuỗi kết nối
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
                string sQuery = "UPDATE KhachHang SET TenKH = @tenkh, SDTKH = @sdtkh, DiaChiKH = @diachikh WHERE MaKH = @makh";

                // Tạo command và thêm tham số
                SqlCommand cmd = new SqlCommand(sQuery, con);
                cmd.Parameters.AddWithValue("@mancc", sMaKH);
                cmd.Parameters.AddWithValue("@tenncc", sTenKH);
                cmd.Parameters.AddWithValue("@sdtncc", sSdtKH);
                cmd.Parameters.AddWithValue("@diachincc", sDiaChiKH);

                // Thực thi câu lệnh SQL
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cập nhật thông tin khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Gọi lại LoadData để làm mới DataGridView
                    Form1_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Không có thay đổi nào được thực hiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi khi cập nhật thông tin nhà cung cấp!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            string sMaKH = txtMaKH.Text;

            // Hiển thị thông báo xác nhận
            DialogResult dialogResult = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa khách hàng với mã '{sMaKH}' không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                // Chuỗi kết nối
                SqlConnection con = new SqlConnection(sCon);
                try
                {
                    con.Open();

                    // Thực hiện câu lệnh DELETE
                    string sQuery = "DELETE FROM KhachHang WHERE MaKH = @makh";
                    SqlCommand cmd = new SqlCommand(sQuery, con);
                    cmd.Parameters.AddWithValue("@makh", sMaKH);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Gọi lại LoadData để làm mới DataGridView
                        Form1_Load(sender, e);

                        // Xóa thông tin trong TextBox
                        txtMaKH.Clear();
                        txtTenKH.Clear();
                        txtSDTKH.Clear();
                        txtDiaChiKH.Clear();
                        txtMaKH.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy khách hàng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi khi xóa khách hàng!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void btnTimKH_Click(object sender, EventArgs e)
        {
            if (comboBoxTenKH.SelectedIndex >= 0)
            {
                string maKH = comboBoxTenKH.SelectedValue.ToString();
                SqlConnection con = new SqlConnection(sCon);

                try
                {
                    con.Open();

                    // Truy vấn để lấy thông tin chi tiết nhà cung cấp theo mã
                    string sQuery = "SELECT * FROM KhachHang WHERE MaKH = @maKH";
                    SqlCommand cmd = new SqlCommand(sQuery, con);
                    cmd.Parameters.AddWithValue("@maKH", maKH);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtMaKH.Text = reader["MaKH"].ToString();
                        txtTenKH.Text = reader["TenKH"].ToString();
                        txtSDTKH.Text = reader["SDTKH"].ToString();
                        txtDiaChiKH.Text = reader["DiaChiKH"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy khách hàng với mã " + maKH, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mã nhà cung cấp trước khi tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTaoMKH_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(sCon))
                {
                    con.Open();

                    // 1. Gọi hàm fn_maDHMoi() từ SQL Server
                    using (SqlCommand cmd = new SqlCommand("SELECT dbo.f_maKhachHangMoi()", con))
                    {
                        string maKHMoi = (string)cmd.ExecuteScalar(); // Thực thi và lấy giá trị trả về

                        // 2. Hiển thị mã đơn hàng mới trong textbox
                        txtMaKH.Text = maKHMoi;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo mã KH mới: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
