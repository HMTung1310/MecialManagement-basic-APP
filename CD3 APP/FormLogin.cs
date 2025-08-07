using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CD3_APP
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        // Xử lý sự kiện khi nhấn nút đăng nhập
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Chuỗi kết nối theo yêu cầu
            string connectionString = "Data Source=DESKTOP-AB2IUOS;Initial Catalog=\"Quanly CD3\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            // Lấy giá trị nhập từ giao diện
            string username = txtTaiKhoan.Text.Trim();
            string password = txtMatKhau.Text.Trim();

            // Kiểm tra nhập rỗng (tùy chọn)
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kết nối và kiểm tra thông tin đăng nhập
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // Đặt đúng tên bảng (taikhoan) và cột (TaiKhoan, MatKhau)
                    string query = "SELECT COUNT(1) FROM dbo.taikhoan WHERE TaiKhoan = @TaiKhoan AND MatKhau = @MatKhau";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Thêm tham số đúng tên
                        cmd.Parameters.AddWithValue("@TaiKhoan", username);
                        cmd.Parameters.AddWithValue("@MatKhau", password);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        if (count == 1)
                        {
                            // Đăng nhập thành công, chuyển sang Form chính (FormMenu)
                            FormMenu mainForm = new FormMenu();
                            mainForm.Show();
                            this.Hide();  // Ẩn form đăng nhập hiện tại
                        }
                        else
                        {
                            MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Xử lý sự kiện khi click pictureBox3 nếu cần
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            // Xử lý khi form load nếu cần
        }
    }
}
