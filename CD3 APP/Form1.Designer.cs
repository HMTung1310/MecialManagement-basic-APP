namespace CD3_APP
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.RichTextBox richTextBoxBaoCao;
        private System.Windows.Forms.Button btnDong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.richTextBoxBaoCao = new System.Windows.Forms.RichTextBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // richTextBoxBaoCao
            // 
            this.richTextBoxBaoCao.Location = new System.Drawing.Point(12, 12);
            this.richTextBoxBaoCao.Name = "richTextBoxBaoCao";
            this.richTextBoxBaoCao.ReadOnly = true;
            this.richTextBoxBaoCao.Size = new System.Drawing.Size(776, 380);
            this.richTextBoxBaoCao.TabIndex = 0;
            this.richTextBoxBaoCao.Text = "";

            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(340, 400);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(120, 40);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.richTextBoxBaoCao);
            this.Name = "Form1";
            this.Text = "Báo Cáo Sức Khỏe";
            this.ResumeLayout(false);
        }

        #endregion
    }
}
