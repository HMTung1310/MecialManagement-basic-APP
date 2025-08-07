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
using static System.Windows.Forms.AxHost;

namespace CD3_APP
{
    public partial class FormThuoc : Form
    {
        private string connectionString = "Data Source=DESKTOP-AB2IUOS;Initial Catalog=\"Quanly CD3\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public FormThuoc()
        {
            InitializeComponent();
            txtMaThuoc.Visible = false;

            load_data();
        }
        private void load_data()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Thuocdieutri";
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
        private void btnAddTT_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "INSERT INTO Thuocdieutri (TenThuoc, LieuLuong, CachDung, GhiChu) VALUES (@TenThuoc, @LieuLuong, @CachDung, @GhiChu)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@TenThuoc", txtten.Text);
                        cmd.Parameters.AddWithValue("@LieuLuong", txtLL.Text);
                        cmd.Parameters.AddWithValue("@CachDung", txtDC.Text);
                        cmd.Parameters.AddWithValue("@GhiChu", txtNote.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Thêm thành công!");
                load_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message);
            }
        }


        private void btnFixTT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaThuoc.Text))
            {
                MessageBox.Show("Vui lòng chọn bệnh nhân để cập nhật!");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "UPDATE Thuocdieutri SET TenThuoc=@TenThuoc, LieuLuong=@LieuLuong, CachDung=@CachDung, GhiChu=@GhiChu WHERE MaThuoc=@MaThuoc";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@MaThuoc", int.Parse(txtMaThuoc.Text));
                        cmd.Parameters.AddWithValue("@TenThuoc", txtten.Text);
                        cmd.Parameters.AddWithValue("@LieuLuong", txtLL.Text);
                        cmd.Parameters.AddWithValue("@CachDung", txtDC.Text);
                        cmd.Parameters.AddWithValue("@GhiChu", txtNote.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Cập nhật thành công!");
                load_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa: " + ex.Message);
            }
        }


        private void btnDel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaThuoc.Text))
            {
                MessageBox.Show("Vui lòng chọn thuốc để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hỏi xác nhận trước khi xóa
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa thuốc này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM Thuocdieutri WHERE MaThuoc = @MaThuoc";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@MaThuoc", txtMaThuoc.Text); // Truyền trực tiếp mã thuốc (chuỗi)

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Xóa thuốc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy thuốc để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }

                    load_data();  // Cập nhật lại danh sách thuốc trong DataGridView
                    ClearFields(); // Xóa dữ liệu trên TextBox sau khi xóa thành công
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa thuốc: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ClearFields()
        {
            txtMaThuoc.Text = "";
            txtten.Text = "";
            txtLL.Text = "";
            txtDC.Text = "";
            txtNote.Text = "";
        }


        private void btnF5_Click(object sender, EventArgs e)
        {
            load_data();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower(); // Lấy từ khóa nhập vào

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["TenThuoc"].Value != null && row.Cells["TenThuoc"].Value.ToString().ToLower().Contains(keyword) ||
                    row.Cells["MaThuoc"].Value != null && row.Cells["MaThuoc"].Value.ToString().ToLower().Contains(keyword))
                {
                    row.Visible = true;  // Hiển thị dòng tìm thấy
                }
                else
                {
                    row.Visible = false; // Ẩn dòng không liên quan
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtMaThuoc.Text = row.Cells["MaThuoc"].Value.ToString(); // Lấy mã thuốc (chuỗi)
                txtten.Text = row.Cells["TenThuoc"].Value.ToString();
                txtLL.Text = row.Cells["LieuLuong"].Value.ToString();
                txtDC.Text = row.Cells["CachDung"].Value.ToString();
                txtNote.Text = row.Cells["GhiChu"].Value.ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtMaThuoc.Text = row.Cells["MaThuoc"].Value?.ToString() ?? "";
                txtten.Text = row.Cells["TenThuoc"].Value?.ToString() ?? "";
                txtLL.Text = row.Cells["LieuLuong"].Value?.ToString() ?? "";
                txtDC.Text = row.Cells["CachDung"].Value?.ToString() ?? "";
                txtNote.Text = row.Cells["GhiChu"].Value?.ToString() ?? "";
            }
        }
    }
}
