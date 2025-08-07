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
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.IO;
namespace CD3_APP
{
    public partial class FormBao : Form
    {
        private string connectionString = "Data Source=DESKTOP-AB2IUOS;Initial Catalog=\"Quanly CD3\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public FormBao()
        {
            InitializeComponent();
            txtMaBaoCao.Visible=false;
            
            LoadComboBoxes();
            LoadData();
            
        }
        private void LoadComboBoxes()
        {
            LoadComboBox(cbMaBN, "SELECT maBN FROM Benhnhan", "maBN");
            LoadComboBox(cbMaDo, "SELECT maChiSo FROM Dulieudoluong", "maChiSo");
            LoadComboBox(cbMaLich, "SELECT maTiem FROM Lichtiemchung", "maTiem");
            LoadComboBox(cbMaThuoc, "SELECT maThuoc FROM Thuocdieutri", "maThuoc");
        }

        private void LoadComboBox(ComboBox cb, string query, string columnName)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cb.DataSource = dt;
                cb.DisplayMember = columnName;
                cb.ValueMember = columnName;
            }
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Truy vấn lấy danh sách báo cáo từ bảng SuckhoeDinhky và các bảng liên quan
                string query = @"
            SELECT 
                skd.maBaoCao, ISNULL(skd.thoiGianBaoCao, '1900-01-01') AS thoiGianBaoCao, skd.ID_maBN,

                -- Thay NULL bằng 0 cho INT
                ISNULL(skd.ID_maDo, 0) AS ID_maDo, 
                ISNULL(skd.ID_maTiem, 0) AS ID_maTiem, 
                ISNULL(skd.ID_maThuoc, 0) AS ID_maThuoc,

                -- Dữ liệu từ bảng Benhnhan
                ISNULL(bn.hoTen, N'Không có dữ liệu') AS hoTen, 
                ISNULL(bn.ngaySinh, '1900-01-01') AS ngaySinh,
                ISNULL(bn.gioiTinh, N'Không có dữ liệu') AS gioiTinh, 
                ISNULL(bn.diaChi, N'Không có dữ liệu') AS diaChi,
                ISNULL(bn.soDienThoai, N'Không có dữ liệu') AS soDienThoai, 
                ISNULL(bn.tienSuBenhTat, N'Không có dữ liệu') AS tienSuBenhTat,

                -- Dữ liệu từ bảng Dulieudoluong
                ISNULL(dl.huyetAp, 0) AS huyetAp,
                ISNULL(dl.nhipTim, 0) AS nhipTim,
                ISNULL(dl.canNang, 0) AS canNang,
                ISNULL(dl.chieuCao, 0) AS chieuCao,
                ISNULL(dl.ngayDo, '1900-01-01') AS ngayDo,
                ISNULL(dl.BMI, 0) AS BMI,

                -- Dữ liệu từ bảng Lichtiemchung
                ISNULL(lt.ngayTiem, '1900-01-01') AS ngayTiem,
                ISNULL(lt.loaiVacXin, N'Không có dữ liệu') AS loaiVacXin,
                ISNULL(lt.bacSiPhuTrach, N'Không có dữ liệu') AS bacSiPhuTrach,
                ISNULL(lt.lieuLuong, 0) AS lieuLuong,
                ISNULL(lt.Note, N'Không có dữ liệu') AS Note,

                -- Dữ liệu từ bảng Thuocdieutri
                ISNULL(td.tenThuoc, N'Không có dữ liệu') AS tenThuoc,
                ISNULL(td.lieuLuong, 0) AS lieuLuong,
                ISNULL(td.cachDung, N'Không có dữ liệu') AS cachDung,
                ISNULL(td.ghiChu, N'Không có dữ liệu') AS ghiChu

            FROM SuckhoeDinhky skd
            JOIN Benhnhan bn ON skd.ID_maBN = bn.maBN
            LEFT JOIN Dulieudoluong dl ON dl.maChiSo = skd.ID_maDo
            LEFT JOIN Lichtiemchung lt ON lt.maTiem = skd.ID_maTiem
            LEFT JOIN Thuocdieutri td ON td.maThuoc = skd.ID_maThuoc
            ORDER BY skd.maBaoCao DESC;";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            string maBN = cbMaBN.SelectedValue.ToString();
            string maDo = cbMaDo.SelectedValue?.ToString();
            string maTiem = cbMaLich.SelectedValue?.ToString();
            string maThuoc = cbMaThuoc.SelectedValue?.ToString();
            string ngayTao = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string insertQuery = @"
        INSERT INTO SuckhoeDinhky (ID_maBN, thoiGianBaoCao, ID_maDo, ID_maTiem, ID_maThuoc)
        VALUES (@MaBN, @NgayTao, @MaDo, @MaTiem, @MaThuoc);";

                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@MaBN", maBN);
                cmd.Parameters.AddWithValue("@NgayTao", ngayTao);
                cmd.Parameters.AddWithValue("@MaDo", string.IsNullOrEmpty(maDo) ? (object)DBNull.Value : maDo);
                cmd.Parameters.AddWithValue("@MaTiem", string.IsNullOrEmpty(maTiem) ? (object)DBNull.Value : maTiem);
                cmd.Parameters.AddWithValue("@MaThuoc", string.IsNullOrEmpty(maThuoc) ? (object)DBNull.Value : maThuoc);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Báo cáo đã được tạo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
        }
        private string GetBaoCaoText(string maBaoCao)
        {
            string connectionString = "Data Source=DESKTOP-AB2IUOS;Initial Catalog=\"Quanly CD3\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            string baoCaoText = "";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT skd.thoiGianBaoCao, bn.hoTen, bn.ngaySinh, bn.gioiTinh, bn.diaChi, bn.soDienThoai, bn.tienSuBenhTat,
                   dl.ngayDo, dl.nhipTim, dl.huyetAp, dl.canNang, dl.chieuCao, dl.BMI,
                   lt.ngayTiem, lt.loaiVacXin, lt.bacSiPhuTrach, lt.lieuLuong, lt.Note,
                   td.tenThuoc, td.lieuLuong, td.cachDung, td.ghiChu
            FROM SuckhoeDinhky skd
            JOIN Benhnhan bn ON skd.ID_maBN = bn.maBN
            LEFT JOIN Dulieudoluong dl ON skd.ID_maDo = dl.maChiSo
            LEFT JOIN Lichtiemchung lt ON skd.ID_maTiem = lt.maTiem
            LEFT JOIN Thuocdieutri td ON skd.ID_maThuoc = td.maThuoc
            WHERE skd.maBaoCao = @MaBaoCao";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaBaoCao", maBaoCao);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    baoCaoText = $"📆 **Thời gian báo cáo:** {reader["thoiGianBaoCao"]}\n\n" +
                        $"🔹 **Thông tin Bệnh nhân:**\n" +
                        $"👤 Họ và tên: {reader["hoTen"]}\n" +
                        $"📅 Ngày sinh: {reader["ngaySinh"]}\n" +
                        $"⚧ Giới tính: {reader["gioiTinh"]}\n" +
                        $"🏡 Địa chỉ: {reader["diaChi"]}\n" +
                        $"📞 Số điện thoại: {reader["soDienThoai"]}\n" +
                        $"⚠ Tiền sử bệnh: {reader["tienSuBenhTat"]}\n\n" +

                        $"📊 **Chỉ số sức khỏe:**\n" +
                        $"📅 Ngày đo: {reader["ngayDo"]}\n" +
                        $"💓 Nhịp tim: {reader["nhipTim"]} bpm\n" +
                        $"💉 Huyết áp: {reader["huyetAp"]}\n" +
                        $"⚖ Cân nặng: {reader["canNang"]} kg\n" +
                        $"📏 Chiều cao: {reader["chieuCao"]} cm\n" +
                        $"⚖ BMI: {reader["BMI"]}\n\n" +

                        $"💉 **Lịch tiêm chủng:**\n" +
                        $"🦠 Vaccine: {reader["loaiVacXin"]}\n" +
                        $"📅 Ngày tiêm: {reader["ngayTiem"]}\n" +
                        $"🩺 Bác sĩ phụ trách: {reader["bacSiPhuTrach"]}\n" +
                        $"💊 Liều lượng: {reader["lieuLuong"]}\n" +
                        $"📝 Ghi chú: {reader["Note"]}\n\n" +

                        $"💊 **Thông tin thuốc:**\n" +
                        $"📋 Tên thuốc: {reader["tenThuoc"]}\n" +
                        $"🔄 Liều lượng: {reader["lieuLuong"]}\n" +
                        $"📜 Cách dùng: {reader["cachDung"]}\n" +
                        $"📝 Ghi chú: {reader["ghiChu"]}\n\n";
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu báo cáo!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                reader.Close();
            }

            return baoCaoText;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn báo cáo chưa
            if (string.IsNullOrEmpty(txtMaBaoCao.Text))
            {
                MessageBox.Show("Vui lòng chọn một báo cáo trước khi xuất!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedMaBaoCao = txtMaBaoCao.Text;

            try
            {
                // Hộp thoại lưu file PDF
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "PDF files (*.pdf)|*.pdf",
                    Title = "Lưu báo cáo dưới dạng PDF",
                    FileName = "BaoCao_SucKhoe.pdf"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy dữ liệu báo cáo từ SQL
                    string baoCaoText = GetBaoCaoText(selectedMaBaoCao);

                    // Tạo tài liệu PDF
                    PdfDocument pdf = new PdfDocument();
                    pdf.Info.Title = "Báo cáo sức khỏe";
                    PdfPage page = pdf.AddPage();
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    XFont titleFont = new XFont("Arial", 16, XFontStyle.Bold);
                    XFont textFont = new XFont("Arial", 12, XFontStyle.Regular);

                    int marginX = 50;
                    int marginY = 50;
                    int lineHeight = 20;
                    int maxWidth = (int)page.Width - (2 * marginX);

                    // Vẽ tiêu đề
                    gfx.DrawString("BÁO CÁO SỨC KHỎE ĐỊNH KỲ", titleFont, XBrushes.Black, new XPoint(marginX, marginY));
                    gfx.DrawString("Ngày tạo: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), textFont, XBrushes.Black, new XPoint(marginX, marginY + lineHeight));

                    // Xuất nội dung báo cáo
                    string[] lines = baoCaoText.Split('\n');
                    int currentY = marginY + 50;

                    foreach (string line in lines)
                    {
                        if (currentY + lineHeight > page.Height - marginY)
                        {
                            // Thêm trang mới nếu hết trang
                            page = pdf.AddPage();
                            gfx = XGraphics.FromPdfPage(page);
                            currentY = marginY;
                        }

                        gfx.DrawString(line, textFont, XBrushes.Black, new XRect(marginX, currentY, maxWidth, lineHeight), XStringFormats.TopLeft);
                        currentY += lineHeight;
                    }

                    // Lưu file PDF
                    pdf.Save(saveFileDialog.FileName);
                    MessageBox.Show("Xuất báo cáo PDF thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất PDF: " + ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtMaBaoCao.Text = row.Cells["maBaoCao"].Value.ToString();
                cbMaBN.SelectedValue = row.Cells["ID_maBN"].Value;
                cbMaDo.SelectedValue = row.Cells["ID_maDo"].Value;
                cbMaLich.SelectedValue = row.Cells["ID_maTiem"].Value;
                cbMaThuoc.SelectedValue = row.Cells["ID_maThuoc"].Value;
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["thoiGianBaoCao"].Value);

                string maBaoCao = row.Cells["maBaoCao"].Value.ToString();
                Form1 formChiTiet = new Form1(maBaoCao);
                formChiTiet.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtMaBaoCao.Text))
            {
                MessageBox.Show("Vui lòng chọn báo cáo cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maBaoCao = txtMaBaoCao.Text;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string deleteQuery = "DELETE FROM SuckhoeDinhky WHERE maBaoCao = @MaBaoCao";
                SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn);
                deleteCmd.Parameters.AddWithValue("@MaBaoCao", maBaoCao);
                deleteCmd.ExecuteNonQuery();

                MessageBox.Show("Báo cáo đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cập nhật lại danh sách sau khi xóa
                LoadData();
            }
        }
    }
}
