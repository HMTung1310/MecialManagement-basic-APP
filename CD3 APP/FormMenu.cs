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


namespace CD3_APP
{

    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            this.Resize += new System.EventHandler(this.FormMenu_Resize);

        }

        // Sự kiện khi FormMenu load
       
        private int CountRecords(string tableName)
        {
            int count = 0;
            string connectionString = "Data Source=DESKTOP-AB2IUOS;Initial Catalog=\"Quanly CD3\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True"; // Cập nhật thông tin kết nối của bạn

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = $"SELECT COUNT(*) FROM {tableName}";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    count = (int)cmd.ExecuteScalar();
                }
            }
            return count;
        }

        // Quản lý thông tin hồ sơ
        private void btnQlTT_Click(object sender, EventArgs e)
        {
            FormTT frmQLTT = new FormTT();
            frmQLTT.Show();
            this.Hide();  // Ẩn FormMenu hiện tại
        }

        // Quản lý lịch tiêm chủng
        private void btnQlLich_Click(object sender, EventArgs e)
        {
            FormLich frmLich = new FormLich();
            frmLich.Show();
            this.Hide();
        }

        // Quản lý thuốc và chế độ điều trị
        private void btnQlthuoc_Click(object sender, EventArgs e)
        {
            FormThuoc frmThuoc = new FormThuoc();
            frmThuoc.Show();
            this.Hide();
        }

        // Quản lý dữ liệu đo lường
        private void btnDo_Click(object sender, EventArgs e)
        {
            FormDo frmDo = new FormDo();
            frmDo.Show();
            this.Hide();
        }

        // Báo cáo sức khoẻ
        private void btnBao_Click(object sender, EventArgs e)
        {
            FormBao frmBao = new FormBao();
            frmBao.Show();
            this.Hide();
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            FormMenu frmmenu= new FormMenu();
            frmmenu.Show();
            this.Hide();
        }
        private void FormMenu_Resize(object sender, EventArgs e)
        {
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            // Giữ cố định chiều rộng panel bên trái
            panel1.Width = formWidth / 5; // 20% chiều rộng form
            panel1.Height = formHeight;

            // Điều chỉnh kích thước và vị trí của các button trong panel
            int buttonHeight = (formHeight - panel2.Height) / 5; // 5 nút chia đều phần còn lại
            btnQlTT.Height = buttonHeight;
            btnQlLich.Height = buttonHeight;
            btnQlthuoc.Height = buttonHeight;
            btnDo.Height = buttonHeight;
            btnBao.Height = buttonHeight;

            // Cập nhật vị trí của các button
            btnQlTT.Top = panel2.Bottom;
            btnQlLich.Top = btnQlTT.Bottom;
            btnQlthuoc.Top = btnQlLich.Bottom;
            btnDo.Top = btnQlthuoc.Bottom;
            btnBao.Top = btnDo.Bottom;

            // Cập nhật font chữ của button theo kích thước form
            float buttonFontSize = Math.Max(12, formWidth * 0.012f);
            btnQlTT.Font = new Font("Microsoft Sans Serif", buttonFontSize, FontStyle.Bold);
            btnQlLich.Font = new Font("Microsoft Sans Serif", buttonFontSize, FontStyle.Bold);
            btnQlthuoc.Font = new Font("Microsoft Sans Serif", buttonFontSize, FontStyle.Bold);
            btnDo.Font = new Font("Microsoft Sans Serif", buttonFontSize, FontStyle.Bold);
            btnBao.Font = new Font("Microsoft Sans Serif", buttonFontSize, FontStyle.Bold);

            // Điều chỉnh panel chứa tiêu đề
            panel3.Width = formWidth - panel1.Width;
            label1.Left = (panel3.Width / 2) - (label1.Width / 2);

            // Tăng kích thước tiêu đề
            float titleFontSize = Math.Max(20, formWidth * 0.02f);
            label1.Font = new Font("Microsoft Sans Serif", titleFontSize, FontStyle.Bold);

            // Căn chỉnh label trên textbox
            label2.Left = panel1.Width + (formWidth - panel1.Width) / 4 - (label2.Width / 2);
            label3.Left = panel1.Width + 2 * (formWidth - panel1.Width) / 4 - (label3.Width / 2);
            label4.Left = panel1.Width + 3 * (formWidth - panel1.Width) / 4 - (label4.Width / 2);

            // Cập nhật font chữ của label
            float labelFontSize = Math.Max(14, formWidth * 0.015f);
            label2.Font = new Font("Microsoft Sans Serif", labelFontSize, FontStyle.Bold);
            label3.Font = new Font("Microsoft Sans Serif", labelFontSize, FontStyle.Bold);
            label4.Font = new Font("Microsoft Sans Serif", labelFontSize, FontStyle.Bold);

            // Tính toán khoảng cách giữa các phần tử
            int spacing = (formWidth - panel1.Width) / 4; // Chia thành 4 khoảng

            // Căn chỉnh textbox và hình ảnh theo khoảng cách
            txtHoso.Left = panel1.Width + spacing - (txtHoso.Width / 2);
            pictureBox2.Left = txtHoso.Left - (pictureBox2.Width / 4);

            txtThuoc.Left = panel1.Width + 2 * spacing - (txtThuoc.Width / 2);
            pictureBox4.Left = txtThuoc.Left - (pictureBox4.Width / 4);

            txtBao.Left = panel1.Width + 3 * spacing - (txtBao.Width / 2);
            pictureBox3.Left = txtBao.Left - (pictureBox3.Width / 4);

            // Điều chỉnh vị trí theo chiều dọc nếu cần
            int topOffset = formHeight / 2 - 50;
            txtHoso.Top = topOffset;
            txtBao.Top = topOffset;
            txtThuoc.Top = topOffset;

            pictureBox2.Top = txtHoso.Bottom + 10;
            pictureBox3.Top = txtBao.Bottom + 10;
            pictureBox4.Top = txtThuoc.Bottom + 10;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormMenu_Load_1(object sender, EventArgs e)
        {

            txtHoso.Text = CountRecords("Benhnhan").ToString(); // Tổng bệnh nhân
            txtThuoc.Text = CountRecords("Thuocdieutri").ToString(); // Tổng thuốc
            txtBao.Text = CountRecords("SuckhoeDinhky").ToString(); // Tổng báo cáo

        }
    }
}





