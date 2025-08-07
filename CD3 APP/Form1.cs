using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CD3_APP
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=DESKTOP-AB2IUOS;Initial Catalog=\"Quanly CD3\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        private string maBaoCao;

        public Form1(string maBaoCao)
        {
            InitializeComponent();
            this.maBaoCao = maBaoCao;
            LoadBaoCao();
        }

        private void LoadBaoCao()
        {
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
                    string baoCao = $"📆 **Thời gian báo cáo:** {reader["thoiGianBaoCao"]}\n\n" +
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

                    richTextBoxBaoCao.Text = baoCao;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu báo cáo!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                reader.Close();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
