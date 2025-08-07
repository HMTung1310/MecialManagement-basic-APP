namespace CD3_APP
{
    partial class FormDo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDo));
            this.dtDo = new System.Windows.Forms.DateTimePicker();
            this.menu = new System.Windows.Forms.PictureBox();
            this.btnBao = new System.Windows.Forms.Button();
            this.btnDo = new System.Windows.Forms.Button();
            this.btnQlthuoc = new System.Windows.Forms.Button();
            this.btnQlLich = new System.Windows.Forms.Button();
            this.btnQlTT = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnF5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtHeartrate = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtBMI = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmaDo = new System.Windows.Forms.TextBox();
            this.cbBenhnhan = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtDo
            // 
            this.dtDo.Location = new System.Drawing.Point(547, 81);
            this.dtDo.Margin = new System.Windows.Forms.Padding(2);
            this.dtDo.Name = "dtDo";
            this.dtDo.Size = new System.Drawing.Size(192, 20);
            this.dtDo.TabIndex = 53;
            // 
            // menu
            // 
            this.menu.Image = ((System.Drawing.Image)(resources.GetObject("menu.Image")));
            this.menu.Location = new System.Drawing.Point(2, 2);
            this.menu.Margin = new System.Windows.Forms.Padding(2);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(139, 78);
            this.menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menu.TabIndex = 39;
            this.menu.TabStop = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // btnBao
            // 
            this.btnBao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBao.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBao.Location = new System.Drawing.Point(0, 267);
            this.btnBao.Margin = new System.Windows.Forms.Padding(2);
            this.btnBao.Name = "btnBao";
            this.btnBao.Size = new System.Drawing.Size(141, 50);
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
            this.btnDo.Margin = new System.Windows.Forms.Padding(2);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(141, 50);
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
            this.btnQlthuoc.Margin = new System.Windows.Forms.Padding(2);
            this.btnQlthuoc.Name = "btnQlthuoc";
            this.btnQlthuoc.Size = new System.Drawing.Size(141, 45);
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
            this.btnQlLich.Margin = new System.Windows.Forms.Padding(2);
            this.btnQlLich.Name = "btnQlLich";
            this.btnQlLich.Size = new System.Drawing.Size(141, 46);
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
            this.btnQlTT.Margin = new System.Windows.Forms.Padding(2);
            this.btnQlTT.Name = "btnQlTT";
            this.btnQlTT.Size = new System.Drawing.Size(141, 46);
            this.btnQlTT.TabIndex = 1;
            this.btnQlTT.Text = "Quản lý thông tin cơ bản ";
            this.btnQlTT.UseVisualStyleBackColor = true;
            this.btnQlTT.Click += new System.EventHandler(this.btnQlTT_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 80);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(544, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Nhịp tim";
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Top;
            this.button8.Location = new System.Drawing.Point(0, 66);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(91, 33);
            this.button8.TabIndex = 2;
            this.button8.Text = "Xoá";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.Location = new System.Drawing.Point(0, 33);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(91, 33);
            this.button7.TabIndex = 1;
            this.button7.Text = "Sửa";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnF5);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Location = new System.Drawing.Point(161, 150);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(91, 203);
            this.panel2.TabIndex = 48;
            // 
            // btnF5
            // 
            this.btnF5.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnF5.Location = new System.Drawing.Point(0, 99);
            this.btnF5.Margin = new System.Windows.Forms.Padding(2);
            this.btnF5.Name = "btnF5";
            this.btnF5.Size = new System.Drawing.Size(91, 33);
            this.btnF5.TabIndex = 3;
            this.btnF5.Text = "F5";
            this.btnF5.UseVisualStyleBackColor = true;
            this.btnF5.Click += new System.EventHandler(this.btnF5_Click);
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.Location = new System.Drawing.Point(0, 0);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(91, 33);
            this.button6.TabIndex = 0;
            this.button6.Text = "Thêm ";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(279, 113);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(407, 20);
            this.txtSearch.TabIndex = 51;
            // 
            // txtHeartrate
            // 
            this.txtHeartrate.Location = new System.Drawing.Point(547, 29);
            this.txtHeartrate.Margin = new System.Windows.Forms.Padding(2);
            this.txtHeartrate.Name = "txtHeartrate";
            this.txtHeartrate.Size = new System.Drawing.Size(178, 20);
            this.txtHeartrate.TabIndex = 50;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(447, 29);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(2);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(74, 20);
            this.txtWeight.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(447, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Cân nặng";
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(173, 81);
            this.txtH.Margin = new System.Windows.Forms.Padding(2);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(150, 20);
            this.txtH.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Huyết áp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(544, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Ngày đo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(273, 150);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(463, 195);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(359, 30);
            this.txtHeight.Margin = new System.Windows.Forms.Padding(2);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(73, 20);
            this.txtHeight.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Chiều cao";
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
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(141, 363);
            this.panel1.TabIndex = 39;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(173, 111);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(79, 25);
            this.btnSearch.TabIndex = 54;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtBMI
            // 
            this.txtBMI.Location = new System.Drawing.Point(359, 81);
            this.txtBMI.Margin = new System.Windows.Forms.Padding(2);
            this.txtBMI.Name = "txtBMI";
            this.txtBMI.Size = new System.Drawing.Size(162, 20);
            this.txtBMI.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(356, 63);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 55;
            this.label6.Text = "BMI";
            // 
            // txtmaDo
            // 
            this.txtmaDo.Location = new System.Drawing.Point(287, 2);
            this.txtmaDo.Margin = new System.Windows.Forms.Padding(2);
            this.txtmaDo.Name = "txtmaDo";
            this.txtmaDo.Size = new System.Drawing.Size(65, 20);
            this.txtmaDo.TabIndex = 57;
            // 
            // cbBenhnhan
            // 
            this.cbBenhnhan.FormattingEnabled = true;
            this.cbBenhnhan.Location = new System.Drawing.Point(173, 29);
            this.cbBenhnhan.Name = "cbBenhnhan";
            this.cbBenhnhan.Size = new System.Drawing.Size(121, 21);
            this.cbBenhnhan.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(170, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 59;
            this.label7.Text = "Bệnh nhân";
            // 
            // FormDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 363);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbBenhnhan);
            this.Controls.Add(this.txtmaDo);
            this.Controls.Add(this.txtBMI);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtDo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtHeartrate);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormDo";
            this.Text = "FormDo";
            ((System.ComponentModel.ISupportInitialize)(this.menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtDo;
        private System.Windows.Forms.PictureBox menu;
        private System.Windows.Forms.Button btnBao;
        private System.Windows.Forms.Button btnDo;
        private System.Windows.Forms.Button btnQlthuoc;
        private System.Windows.Forms.Button btnQlLich;
        private System.Windows.Forms.Button btnQlTT;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtHeartrate;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtBMI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmaDo;
        private System.Windows.Forms.Button btnF5;
        private System.Windows.Forms.ComboBox cbBenhnhan;
        private System.Windows.Forms.Label label7;
    }
}