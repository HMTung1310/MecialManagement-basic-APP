using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CD3_APP
{
    public partial class FormDo : Form
    {
        private string connectionString = "Data Source=DESKTOP-AB2IUOS;Initial Catalog=\"Quanly CD3\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        private int selectedId = -1; // ID của dữ liệu đo lường được chọn

        public FormDo()
        {

            InitializeComponent();
            txtmaDo.Visible = false;

            load_data();
            LoadBenhNhan();
        }

        
        private void load_data()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"
    SELECT d.*, b.hoTen 
    FROM DuLieudoluong d
    INNER JOIN Benhnhan b ON d.ID_maBN = b.maBN";
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

                    cbBenhnhan.DataSource = dt;
                    cbBenhnhan.DisplayMember = "hoTen";
                    cbBenhnhan.ValueMember = "maBN";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải tên bệnh nhân: " + ex.Message);
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

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Kiểm tra nếu bảng trống, reset ID về 1
                    string checkEmptyQuery = "SELECT COUNT(*) FROM DuLieudoluong";
                    using (SqlCommand checkCmd = new SqlCommand(checkEmptyQuery, con))
                    {
                        int count = (int)checkCmd.ExecuteScalar();
                        if (count == 0)
                        {
                            string resetIdentityQuery = "DBCC CHECKIDENT ('DuLieudoluong', RESEED, 0)";
                            using (SqlCommand resetCmd = new SqlCommand(resetIdentityQuery, con))
                            {
                                resetCmd.ExecuteNonQuery();
                            }
                        }
                    }

                    // Thêm cả ID_maBN
                    string query = @"INSERT INTO DuLieudoluong (huyetAp, nhipTim, canNang, chieuCao, ngayDo, BMI, ID_maBN) 
                             VALUES (@huyetAp, @nhipTim, @canNang, @chieuCao, @ngayDo, @BMI, @ID_maBN)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@huyetAp", txtH.Text);
                        cmd.Parameters.AddWithValue("@nhipTim", txtHeartrate.Text);
                        cmd.Parameters.AddWithValue("@canNang", float.Parse(txtWeight.Text));
                        cmd.Parameters.AddWithValue("@chieuCao", float.Parse(txtHeight.Text));
                        cmd.Parameters.AddWithValue("@ngayDo", dtDo.Value);
                        cmd.Parameters.AddWithValue("@BMI", txtBMI.Text);
                        cmd.Parameters.AddWithValue("@ID_maBN", cbBenhnhan.SelectedValue); // Mã bệnh nhân từ combobox

                        int rows = cmd.ExecuteNonQuery();
                        MessageBox.Show(rows > 0 ? "Thêm dữ liệu thành công!" : "Thêm không thành công!");
                    }
                }
                load_data();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
            {
                MessageBox.Show("Vui lòng chọn dữ liệu để cập nhật!");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"UPDATE DuLieudoluong 
                             SET huyetAp = @huyetAp, 
                                 nhipTim = @nhipTim, 
                                 canNang = @canNang, 
                                 chieuCao = @chieuCao, 
                                 ngayDo = @ngayDo, 
                                 BMI = @BMI,
                                 ID_maBN = @ID_maBN
                             WHERE maChiSo = @maChiSo";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@maChiSo", selectedId);
                        cmd.Parameters.AddWithValue("@huyetAp", txtH.Text);
                        cmd.Parameters.AddWithValue("@nhipTim", txtHeartrate.Text);
                        cmd.Parameters.AddWithValue("@canNang", float.Parse(txtWeight.Text));
                        cmd.Parameters.AddWithValue("@chieuCao", float.Parse(txtHeight.Text));
                        cmd.Parameters.AddWithValue("@ngayDo", dtDo.Value);
                        cmd.Parameters.AddWithValue("@BMI", txtBMI.Text);
                        cmd.Parameters.AddWithValue("@ID_maBN", cbBenhnhan.SelectedValue); // Lấy mã bệnh nhân từ combobox

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy dữ liệu để cập nhật!");
                        }
                    }
                }

                load_data();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
            }
        }

        private void ClearFields()
        {
            txtH.Text = "";
            txtHeartrate.Text = "";
            txtWeight.Text = "";
            txtHeight.Text = "";
            dtDo.Value = DateTime.Now;
            txtBMI.Text = "";
            selectedId = -1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
            {
                MessageBox.Show("Vui lòng chọn dữ liệu để xóa!");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM DuLieudoluong WHERE maChiSo = @maChiSo";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@maChiSo", selectedId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Xóa thành công!");
                    load_data();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                }
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                selectedId = Convert.ToInt32(row.Cells["maChiSo"].Value);
                txtH.Text = row.Cells["huyetAp"].Value.ToString();
                txtHeartrate.Text = row.Cells["nhipTim"].Value.ToString();
                txtWeight.Text = row.Cells["canNang"].Value.ToString();
                txtHeight.Text = row.Cells["chieuCao"].Value.ToString();
                dtDo.Value = Convert.ToDateTime(row.Cells["ngayDo"].Value);
                txtBMI.Text = row.Cells["BMI"].Value.ToString();
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Vui lòng nhập thông tin để tìm kiếm!");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM DuLieudoluong WHERE huyetAp LIKE @search";

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
                            MessageBox.Show("Không tìm thấy dữ liệu!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                if (int.TryParse(row.Cells["maChiSo"].Value.ToString(), out int id))
                {
                    selectedId = id;
                    txtmaDo.Text = selectedId.ToString();
                    txtH.Text = row.Cells["huyetAp"].Value.ToString();
                    txtHeartrate.Text = row.Cells["nhipTim"].Value.ToString();
                    txtWeight.Text = row.Cells["canNang"].Value.ToString();
                    txtHeight.Text = row.Cells["chieuCao"].Value.ToString();
                    dtDo.Value = Convert.ToDateTime(row.Cells["ngayDo"].Value);
                    txtBMI.Text = row.Cells["BMI"].Value.ToString();

                    // Gán lại combobox bệnh nhân (nếu bạn có cột ID_maBN trong DataGridView)
                    cbBenhnhan.SelectedValue = row.Cells["ID_maBN"].Value;
                }
            }
        }

        private void btnF5_Click(object sender, EventArgs e)
        {
            load_data();
        }

      
    }
}
