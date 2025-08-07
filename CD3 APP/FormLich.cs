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
    public partial class FormLich : Form
    {
        private string connectionString = "Data Source=DESKTOP-AB2IUOS;Initial Catalog=\"Quanly CD3\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public FormLich()
        {
            InitializeComponent();
            txtMaTiem.Visible = false;
            LoadLoaiVacXin();
            LoadBenhNhan();
            load_data();
        }
        private void LoadBenhNhan()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "SELECT maBN, hoTen FROM Benhnhan";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cbhoten.DataSource = dt;
                    cbhoten.DisplayMember = "hoTen";
                    cbhoten.ValueMember = "maBN";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải tên bệnh nhân: " + ex.Message);
            }
        }
        private void TinhTrangThaiTiem()
        {
            DateTime ngayTiem = dtDate.Value.Date;
            DateTime ngayHienTai = DateTime.Today;
            TimeSpan diff = ngayTiem - ngayHienTai;

            if (diff.Days < 0)
                txtNote.Text = "Đã tiêm";
            else if (diff.Days > 0)
                txtNote.Text = $"Chuẩn bị tiêm ({diff.Days} ngày)";
            else
                txtNote.Text = "Đang tiêm";
        }

        private void load_data()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
                try
            {
                string query = @"
            SELECT lt.*, bn.hoTen 
            FROM Lichtiemchung lt
            INNER JOIN BenhNhan bn ON lt.ID_maBN = bn.maBN";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Thêm cột trạng thái tiêm
                dt.Columns.Add("TrangThaiTiem", typeof(string));

                foreach (DataRow row in dt.Rows)
                {
                    DateTime ngayTiem = Convert.ToDateTime(row["ngayTiem"]);
                    int diffDays = (ngayTiem - DateTime.Today).Days;

                    if (diffDays > 0)
                        row["TrangThaiTiem"] = $"Chuẩn bị tiêm ({diffDays} ngày)";
                    else if (diffDays == 0)
                        row["TrangThaiTiem"] = "Đang tiêm";
                    else
                        row["TrangThaiTiem"] = "Đã tiêm xong";
                }

                dataGridView1.DataSource = dt;

                // Sắp xếp cột hiển thị
                dataGridView1.Columns["maTiem"].DisplayIndex = 0;
                dataGridView1.Columns["hoTen"].DisplayIndex = 1;
                dataGridView1.Columns["ngayTiem"].DisplayIndex = 2;
                dataGridView1.Columns["bacSiPhuTrach"].DisplayIndex = 3;
                dataGridView1.Columns["lieuluong"].DisplayIndex = 3;
                dataGridView1.Columns["TrangThaiTiem"].DisplayIndex = 4;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void LoadLoaiVacXin()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "SELECT maThuoc, tenThuoc FROM Thuocdieutri";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbLoaiVacXin.DataSource = dt;
                    cmbLoaiVacXin.DisplayMember = "tenThuoc";
                    cmbLoaiVacXin.ValueMember = "maThuoc";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải loại vắc xin: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"INSERT INTO Lichtiemchung (ngayTiem, loaiVacXin, bacSiPhuTrach, lieuluong, Note, ID_maBN) 
                             VALUES (@ngayTiem, @loaiVacXin, @bacSiPhuTrach, @lieuluong, @Note, @ID_maBN)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ngayTiem", dtDate.Value);
                        cmd.Parameters.AddWithValue("@loaiVacXin", cmbLoaiVacXin.Text); // Lưu tên thuốc
                        cmd.Parameters.AddWithValue("@bacSiPhuTrach", txtPhutrach.Text);
                        cmd.Parameters.AddWithValue("@lieuluong", txtLL.Text);
                        cmd.Parameters.AddWithValue("@Note", txtNote.Text);
                        cmd.Parameters.AddWithValue("@ID_maBN", cbhoten.SelectedValue);

                        con.Open();
                        int rows = cmd.ExecuteNonQuery();
                        MessageBox.Show(rows > 0 ? "Thêm lịch tiêm thành công!" : "Thêm thất bại!");
                    }
                }
                load_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message);
            }
        }
        private void btnFix_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaTiem.Text))
            {
                MessageBox.Show("Vui lòng chọn lịch tiêm cần sửa!");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"UPDATE Lichtiemchung 
                             SET ngayTiem = @ngayTiem, loaiVacXin = @loaiVacXin, 
                                 bacSiPhuTrach = @bacSiPhuTrach, lieuluong = @lieuluong, 
                                 Note = @Note, ID_maBN = @ID_maBN
                             WHERE maTiem = @maTiem";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@maTiem", txtMaTiem.Text);
                        cmd.Parameters.AddWithValue("@ngayTiem", dtDate.Value);
                        cmd.Parameters.AddWithValue("@loaiVacXin", cmbLoaiVacXin.Text); // Sửa tên thuốc
                        cmd.Parameters.AddWithValue("@bacSiPhuTrach", txtPhutrach.Text);
                        cmd.Parameters.AddWithValue("@lieuluong", txtLL.Text);
                        cmd.Parameters.AddWithValue("@Note", txtNote.Text);
                        cmd.Parameters.AddWithValue("@ID_maBN", cbhoten.SelectedValue);

                        con.Open();
                        int rows = cmd.ExecuteNonQuery();
                        MessageBox.Show(rows > 0 ? "Cập nhật thành công!" : "Cập nhật thất bại!");
                    }
                }
                load_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa: " + ex.Message);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaTiem.Text))
            {
                MessageBox.Show("Vui lòng chọn lịch tiêm cần xóa!");
                return;
            }

            var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa lịch tiêm này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM LichTiemChung WHERE maTiem = @maTiem";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@maTiem", txtMaTiem.Text);

                            con.Open();
                            int rows = cmd.ExecuteNonQuery();
                            MessageBox.Show(rows > 0 ? "Xóa thành công!" : "Xóa thất bại!");
                        }
                    }
                    load_data(); // Load lại dữ liệu
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                }
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtMaTiem.Text = row.Cells["maTiem"].Value.ToString();
                dtDate.Value = Convert.ToDateTime(row.Cells["ngayTiem"].Value);
                cmbLoaiVacXin.Text = row.Cells["loaiVacXin"].Value.ToString();
                cbhoten.SelectedValue = row.Cells["ID_maBN"].Value;
                txtPhutrach.Text = row.Cells["bacSiPhuTrach"].Value.ToString();
                txtLL.Text = row.Cells["lieuluong"].Value.ToString();
                txtNote.Text = row.Cells["TrangThaiTiem"].Value.ToString();
            }
        }



        private void btnF5_Click(object sender, EventArgs e)
        {
            load_data();
        }
    }
}
