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

namespace CD3_APP
{
    public partial class FormTT : Form
    {
        private string connectionString = "Data Source=DESKTOP-AB2IUOS;Initial Catalog=\"Quanly CD3\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
       
        public FormTT()
        {
            InitializeComponent();
            txtMabn.Visible = false;

            load_data();
        }
        private void load_data()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Benhnhan";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }
        private void btnQlTT_Click(object sender, EventArgs e)
        {
            FormTT frmQLTT = new FormTT();
            frmQLTT.Show();
            this.Hide();  
        }

        private void btnQlLich_Click(object sender, EventArgs e)
        {
            FormLich frmLich = new FormLich();
            frmLich.Show();
            this.Hide();
        }

        private void btnQlthuoc_Click(object sender, EventArgs e)
        {

            FormThuoc frmThuoc = new FormThuoc();
            frmThuoc.Show();
            this.Hide();
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            FormDo frmDo = new FormDo();
            frmDo.Show();
            this.Hide();
        }

        private void btnBao_Click(object sender, EventArgs e)
        {
            FormBao frmBao = new FormBao();
            frmBao.Show();
            this.Hide();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            FormMenu frmmenu = new FormMenu();
            frmmenu.Show();
            this.Hide();
        }

        private void btnAddTT_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Kiểm tra nếu bảng trống, reset ID về 1
                    string checkEmptyQuery = "SELECT COUNT(*) FROM Benhnhan";
                    using (SqlCommand checkCmd = new SqlCommand(checkEmptyQuery, con))
                    {
                        int count = (int)checkCmd.ExecuteScalar();
                        if (count == 0)
                        {
                            string resetIdentityQuery = "DBCC CHECKIDENT ('Benhnhan', RESEED, 0)";
                            using (SqlCommand resetCmd = new SqlCommand(resetIdentityQuery, con))
                            {
                                resetCmd.ExecuteNonQuery();
                            }
                        }
                    }

                    // Câu lệnh INSERT dữ liệu bệnh nhân
                    string query = @"INSERT INTO Benhnhan (hoTen, ngaySinh, gioiTinh, diaChi, soDienThoai, tienSuBenhTat) 
                            VALUES (@hoTen, @ngaySinh, @gioiTinh, @diaChi, @soDienThoai, @tienSu)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@hoTen", txthoten.Text);
                        cmd.Parameters.AddWithValue("@ngaySinh", dtPick.Value);
                        cmd.Parameters.AddWithValue("@gioiTinh", txtGT.Text);
                        cmd.Parameters.AddWithValue("@diaChi", txtDC.Text);
                        cmd.Parameters.AddWithValue("@soDienThoai", txtSDT.Text);
                        cmd.Parameters.AddWithValue("@tienSu", string.IsNullOrEmpty(txtTienSu.Text) ? (object)DBNull.Value : txtTienSu.Text);

                        int rows = cmd.ExecuteNonQuery();
                        MessageBox.Show(rows > 0 ? "Thêm bệnh nhân thành công!" : "Thêm không thành công!");
                    }
                }
                load_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message);
            }
        }

        private void btnFixTT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMabn.Text))
            {
                MessageBox.Show("Vui lòng chọn bệnh nhân để cập nhật!");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"UPDATE Benhnhan 
                             SET hoTen = @HoTen, 
                                 ngaySinh = @NgaySinh, 
                                 gioiTinh = @GioiTinh, 
                                 diaChi = @DiaChi, 
                                 soDienThoai = @SDT, 
                                 tienSuBenhTat = @TienSuBenh 
                             WHERE maBN = @MaBN";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaBN", int.Parse(txtMabn.Text)); // Mã bệnh nhân đã chọn
                        cmd.Parameters.AddWithValue("@HoTen", txthoten.Text);
                        cmd.Parameters.AddWithValue("@NgaySinh", dtPick.Value);
                        cmd.Parameters.AddWithValue("@GioiTinh", txtGT.Text);
                        cmd.Parameters.AddWithValue("@DiaChi", txtDC.Text);
                        cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);
                        cmd.Parameters.AddWithValue("@TienSuBenh", string.IsNullOrEmpty(txtTienSu.Text) ? (object)DBNull.Value : txtTienSu.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật thông tin thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy bệnh nhân để cập nhật!");
                        }
                    }
                }

                load_data(); // Cập nhật lại DataGridView sau khi sửa
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
            }
        }

        private void ClearFields()
        {
            txtMabn.Text = "";
            txthoten.Text = "";
            dtPick.Value = DateTime.Now; // Đặt lại DateTimePicker về ngày hiện tại
            txtGT.Text = "";
            txtDC.Text = "";
            txtSDT.Text = "";
            txtTienSu.Text = "";
        }

        private void btnDelTT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMabn.Text))
            {
                MessageBox.Show("Vui lòng chọn bệnh nhân để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hỏi xác nhận trước khi xóa
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa bệnh nhân này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM Benhnhan WHERE maBN = @MaBN";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@MaBN", int.Parse(txtMabn.Text));

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Xóa bệnh nhân thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy bệnh nhân để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }

                    load_data(); // Cập nhật lại DataGridView sau khi xóa
                    ClearFields(); // Xóa dữ liệu trên TextBox sau khi xóa thành công
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa bệnh nhân: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnF5_Click(object sender, EventArgs e)
        {
            load_data();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Vui lòng nhập thông tin để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT * FROM Benhnhan 
                             WHERE hoTen LIKE @search OR soDienThoai LIKE @search";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@search", "%" + searchText + "%");

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            dataGridView1.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy bệnh nhân nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Đảm bảo click vào ô hợp lệ
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Gán dữ liệu vào TextBox (kiểm tra NULL để tránh lỗi)
                txtMabn.Text = row.Cells["maBN"].Value?.ToString() ?? "";
                txthoten.Text = row.Cells["hoTen"].Value?.ToString() ?? "";

                // Kiểm tra nếu ngày sinh NULL thì để trống
                if (row.Cells["ngaySinh"].Value != DBNull.Value)
                {
                    dtPick.Value = Convert.ToDateTime(row.Cells["ngaySinh"].Value);
                }
                else
                {
                    dtPick.Value = DateTime.Now; // Nếu NULL thì hiển thị ngày hiện tại
                }

                txtGT.Text = row.Cells["gioiTinh"].Value?.ToString() ?? "";
                txtDC.Text = row.Cells["diaChi"].Value?.ToString() ?? "";
                txtSDT.Text = row.Cells["soDienThoai"].Value?.ToString() ?? "";
                txtTienSu.Text = row.Cells["tienSuBenhTat"].Value?.ToString() ?? "";

                // Hiển thị thông báo để kiểm tra
                Console.WriteLine($"Chọn bệnh nhân: {txtMabn.Text}");
            }
        }

      
    }

}
