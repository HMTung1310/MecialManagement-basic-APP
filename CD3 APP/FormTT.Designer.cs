using System.Windows.Forms;

namespace CD3_APP
{
    partial class FormTT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTT));
            this.txtTienSu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnF5 = new System.Windows.Forms.Button();
            this.btnDelTT = new System.Windows.Forms.Button();
            this.btnFixTT = new System.Windows.Forms.Button();
            this.btnAddTT = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.PictureBox();
            this.btnBao = new System.Windows.Forms.Button();
            this.btnDo = new System.Windows.Forms.Button();
            this.btnQlthuoc = new System.Windows.Forms.Button();
            this.btnQlLich = new System.Windows.Forms.Button();
            this.btnQlTT = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMabn = new System.Windows.Forms.TextBox();
            this.dtPick = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTienSu
            // 
            this.txtTienSu.Location = new System.Drawing.Point(806, 123);
            this.txtTienSu.Name = "txtTienSu";
            this.txtTienSu.Size = new System.Drawing.Size(270, 26);
            this.txtTienSu.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(802, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "Tiền sử bệnh";
            // 
            // txtDC
            // 
            this.txtDC.Location = new System.Drawing.Point(806, 51);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(270, 26);
            this.txtDC.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(802, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Địa chỉ";
            // 
            // btnF5
            // 
            this.btnF5.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnF5.Location = new System.Drawing.Point(0, 153);
            this.btnF5.Name = "btnF5";
            this.btnF5.Size = new System.Drawing.Size(141, 51);
            this.btnF5.TabIndex = 3;
            this.btnF5.Text = "f5";
            this.btnF5.UseVisualStyleBackColor = true;
            this.btnF5.Click += new System.EventHandler(this.btnF5_Click);
            // 
            // btnDelTT
            // 
            this.btnDelTT.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelTT.Location = new System.Drawing.Point(0, 102);
            this.btnDelTT.Name = "btnDelTT";
            this.btnDelTT.Size = new System.Drawing.Size(141, 51);
            this.btnDelTT.TabIndex = 2;
            this.btnDelTT.Text = "Xoá";
            this.btnDelTT.UseVisualStyleBackColor = true;
            this.btnDelTT.Click += new System.EventHandler(this.btnDelTT_Click);
            // 
            // btnFixTT
            // 
            this.btnFixTT.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFixTT.Location = new System.Drawing.Point(0, 51);
            this.btnFixTT.Name = "btnFixTT";
            this.btnFixTT.Size = new System.Drawing.Size(141, 51);
            this.btnFixTT.TabIndex = 1;
            this.btnFixTT.Text = "Sửa";
            this.btnFixTT.UseVisualStyleBackColor = true;
            this.btnFixTT.Click += new System.EventHandler(this.btnFixTT_Click);
            // 
            // btnAddTT
            // 
            this.btnAddTT.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddTT.Location = new System.Drawing.Point(0, 0);
            this.btnAddTT.Name = "btnAddTT";
            this.btnAddTT.Size = new System.Drawing.Size(141, 51);
            this.btnAddTT.TabIndex = 0;
            this.btnAddTT.Text = "Thêm ";
            this.btnAddTT.UseVisualStyleBackColor = true;
            this.btnAddTT.Click += new System.EventHandler(this.btnAddTT_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(463, 174);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(613, 26);
            this.txtSearch.TabIndex = 36;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnF5);
            this.panel2.Controls.Add(this.btnDelTT);
            this.panel2.Controls.Add(this.btnFixTT);
            this.panel2.Controls.Add(this.btnAddTT);
            this.panel2.Location = new System.Drawing.Point(240, 229);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(141, 288);
            this.panel2.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(528, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Ngày sinh";
            // 
            // txtGT
            // 
            this.txtGT.Location = new System.Drawing.Point(240, 123);
            this.txtGT.Name = "txtGT";
            this.txtGT.Size = new System.Drawing.Size(228, 26);
            this.txtGT.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Giới tính";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(532, 123);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(192, 26);
            this.txtSDT.TabIndex = 26;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(387, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(694, 320);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(240, 51);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(228, 26);
            this.txthoten.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Họ tên";
            // 
            // menu
            // 
            this.menu.Image = ((System.Drawing.Image)(resources.GetObject("menu.Image")));
            this.menu.Location = new System.Drawing.Point(-7, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(223, 123);
            this.menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menu.TabIndex = 6;
            this.menu.TabStop = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // btnBao
            // 
            this.btnBao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBao.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBao.Location = new System.Drawing.Point(0, 410);
            this.btnBao.Name = "btnBao";
            this.btnBao.Size = new System.Drawing.Size(216, 77);
            this.btnBao.TabIndex = 5;
            this.btnBao.Text = "Báo cáo tổng quan hệ thống";
            this.btnBao.UseVisualStyleBackColor = true;
            this.btnBao.Click += new System.EventHandler(this.btnBao_Click);
            // 
            // btnDo
            // 
            this.btnDo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDo.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnDo.Location = new System.Drawing.Point(0, 333);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(216, 77);
            this.btnDo.TabIndex = 4;
            this.btnDo.Text = "Quản lý dữ liệu đo lường";
            this.btnDo.UseVisualStyleBackColor = true;
            this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
            // 
            // btnQlthuoc
            // 
            this.btnQlthuoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQlthuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQlthuoc.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnQlthuoc.Location = new System.Drawing.Point(0, 264);
            this.btnQlthuoc.Name = "btnQlthuoc";
            this.btnQlthuoc.Size = new System.Drawing.Size(216, 69);
            this.btnQlthuoc.TabIndex = 3;
            this.btnQlthuoc.Text = "Quản lý thuốc và chế độ điều trị";
            this.btnQlthuoc.UseVisualStyleBackColor = true;
            this.btnQlthuoc.Click += new System.EventHandler(this.btnQlthuoc_Click);
            // 
            // btnQlLich
            // 
            this.btnQlLich.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQlLich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQlLich.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnQlLich.Location = new System.Drawing.Point(0, 194);
            this.btnQlLich.Name = "btnQlLich";
            this.btnQlLich.Size = new System.Drawing.Size(216, 70);
            this.btnQlLich.TabIndex = 2;
            this.btnQlLich.Text = "Quản lý lịch tiêm chủng";
            this.btnQlLich.UseVisualStyleBackColor = true;
            this.btnQlLich.Click += new System.EventHandler(this.btnQlLich_Click);
            // 
            // btnQlTT
            // 
            this.btnQlTT.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQlTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQlTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnQlTT.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnQlTT.Location = new System.Drawing.Point(0, 123);
            this.btnQlTT.Name = "btnQlTT";
            this.btnQlTT.Size = new System.Drawing.Size(216, 71);
            this.btnQlTT.TabIndex = 1;
            this.btnQlTT.Text = "Quản lý thông tin cơ bản ";
            this.btnQlTT.UseVisualStyleBackColor = true;
            this.btnQlTT.Click += new System.EventHandler(this.btnQlTT_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 123);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(528, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Số điện thoại";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.menu);
            this.panel1.Controls.Add(this.btnBao);
            this.panel1.Controls.Add(this.btnDo);
            this.panel1.Controls.Add(this.btnQlthuoc);
            this.panel1.Controls.Add(this.btnQlLich);
            this.panel1.Controls.Add(this.btnQlTT);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 574);
            this.panel1.TabIndex = 21;
            // 
            // txtMabn
            // 
            this.txtMabn.Location = new System.Drawing.Point(326, 12);
            this.txtMabn.Name = "txtMabn";
            this.txtMabn.Size = new System.Drawing.Size(87, 26);
            this.txtMabn.TabIndex = 38;
            // 
            // dtPick
            // 
            this.dtPick.Location = new System.Drawing.Point(532, 51);
            this.dtPick.Name = "dtPick";
            this.dtPick.Size = new System.Drawing.Size(200, 26);
            this.dtPick.TabIndex = 39;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(283, 168);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(149, 38);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FormTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 574);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtPick);
            this.Controls.Add(this.txtMabn);
            this.Controls.Add(this.txtTienSu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txthoten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FormTT";
            this.Text = "FormQLTT";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTienSu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnF5;
        private System.Windows.Forms.Button btnDelTT;
        private System.Windows.Forms.Button btnFixTT;
        private System.Windows.Forms.Button btnAddTT;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox menu;
        private System.Windows.Forms.Button btnBao;
        private System.Windows.Forms.Button btnDo;
        private System.Windows.Forms.Button btnQlthuoc;
        private System.Windows.Forms.Button btnQlLich;
        private System.Windows.Forms.Button btnQlTT;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMabn;
        private DateTimePicker dtPick;
        private Button btnSearch;
    }
}