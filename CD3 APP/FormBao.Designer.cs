namespace CD3_APP
{
    partial class FormBao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBao));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBao = new System.Windows.Forms.Button();
            this.btnDo = new System.Windows.Forms.Button();
            this.btnQlthuoc = new System.Windows.Forms.Button();
            this.btnQlLich = new System.Windows.Forms.Button();
            this.btnQlTT = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaBaoCao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbMaBN = new System.Windows.Forms.ComboBox();
            this.cbMaDo = new System.Windows.Forms.ComboBox();
            this.cbMaLich = new System.Windows.Forms.ComboBox();
            this.cbMaThuoc = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(169, 83);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(597, 184);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnBao
            // 
            this.btnBao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBao.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBao.Location = new System.Drawing.Point(0, 267);
            this.btnBao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBao.Name = "btnBao";
            this.btnBao.Size = new System.Drawing.Size(144, 50);
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
            this.btnDo.Location = new System.Drawing.Point(0, 217);
            this.btnDo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(144, 50);
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
            this.btnQlthuoc.Location = new System.Drawing.Point(0, 172);
            this.btnQlthuoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQlthuoc.Name = "btnQlthuoc";
            this.btnQlthuoc.Size = new System.Drawing.Size(144, 45);
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
            this.btnQlLich.Location = new System.Drawing.Point(0, 126);
            this.btnQlLich.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQlLich.Name = "btnQlLich";
            this.btnQlLich.Size = new System.Drawing.Size(144, 46);
            this.btnQlLich.TabIndex = 2;
            this.btnQlLich.Text = "Quản lý lịch tiêm chủng";
            this.btnQlLich.UseVisualStyleBackColor = true;
            this.btnQlLich.Click += new System.EventHandler(this.btnQlLich_Click);
            // 
            // btnQlTT
            // 
            this.btnQlTT.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQlTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQlTT.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnQlTT.Location = new System.Drawing.Point(0, 80);
            this.btnQlTT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQlTT.Name = "btnQlTT";
            this.btnQlTT.Size = new System.Drawing.Size(144, 46);
            this.btnQlTT.TabIndex = 1;
            this.btnQlTT.Text = "Quản lý thông tin cơ bản ";
            this.btnQlTT.UseVisualStyleBackColor = true;
            this.btnQlTT.Click += new System.EventHandler(this.btnQlTT_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 80);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 340);
            this.panel1.TabIndex = 27;
            // 
            // menu
            // 
            this.menu.Image = ((System.Drawing.Image)(resources.GetObject("menu.Image")));
            this.menu.Location = new System.Drawing.Point(0, 2);
            this.menu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(144, 78);
            this.menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menu.TabIndex = 6;
            this.menu.TabStop = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(587, 290);
            this.button7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(121, 39);
            this.button7.TabIndex = 30;
            this.button7.Text = "Xuất báo cáo";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(383, 287);
            this.button6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(121, 39);
            this.button6.TabIndex = 29;
            this.button6.Text = "Xoá báo cáo";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(193, 290);
            this.button8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(121, 39);
            this.button8.TabIndex = 31;
            this.button8.Text = "Tạo báo cáo";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "MãBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(563, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Ngày tạo";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(566, 39);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "MãDo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "MãLich";
            // 
            // txtMaBaoCao
            // 
            this.txtMaBaoCao.Location = new System.Drawing.Point(496, 2);
            this.txtMaBaoCao.Name = "txtMaBaoCao";
            this.txtMaBaoCao.Size = new System.Drawing.Size(59, 20);
            this.txtMaBaoCao.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(429, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Mã Thuốc";
            // 
            // cbMaBN
            // 
            this.cbMaBN.FormattingEnabled = true;
            this.cbMaBN.Location = new System.Drawing.Point(169, 42);
            this.cbMaBN.Name = "cbMaBN";
            this.cbMaBN.Size = new System.Drawing.Size(57, 21);
            this.cbMaBN.TabIndex = 44;
            // 
            // cbMaDo
            // 
            this.cbMaDo.FormattingEnabled = true;
            this.cbMaDo.Location = new System.Drawing.Point(257, 42);
            this.cbMaDo.Name = "cbMaDo";
            this.cbMaDo.Size = new System.Drawing.Size(57, 21);
            this.cbMaDo.TabIndex = 45;
            // 
            // cbMaLich
            // 
            this.cbMaLich.FormattingEnabled = true;
            this.cbMaLich.Location = new System.Drawing.Point(346, 42);
            this.cbMaLich.Name = "cbMaLich";
            this.cbMaLich.Size = new System.Drawing.Size(57, 21);
            this.cbMaLich.TabIndex = 46;
            // 
            // cbMaThuoc
            // 
            this.cbMaThuoc.FormattingEnabled = true;
            this.cbMaThuoc.Location = new System.Drawing.Point(432, 42);
            this.cbMaThuoc.Name = "cbMaThuoc";
            this.cbMaThuoc.Size = new System.Drawing.Size(57, 21);
            this.cbMaThuoc.TabIndex = 47;
            // 
            // FormBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 340);
            this.Controls.Add(this.cbMaThuoc);
            this.Controls.Add(this.cbMaLich);
            this.Controls.Add(this.cbMaDo);
            this.Controls.Add(this.cbMaBN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMaBaoCao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormBao";
            this.Text = "FormBao";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBao;
        private System.Windows.Forms.Button btnDo;
        private System.Windows.Forms.Button btnQlthuoc;
        private System.Windows.Forms.Button btnQlLich;
        private System.Windows.Forms.Button btnQlTT;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox menu;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaBaoCao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbMaBN;
        private System.Windows.Forms.ComboBox cbMaDo;
        private System.Windows.Forms.ComboBox cbMaLich;
        private System.Windows.Forms.ComboBox cbMaThuoc;
    }
}