namespace Lab04_Bai07
{
    partial class FormRandomMon
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
            pictureBox1 = new PictureBox();
            lblNguoiDongGop = new Label();
            lblDiaChi = new Label();
            lblGia = new Label();
            lblTenMonAn = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(339, 314);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblNguoiDongGop
            // 
            lblNguoiDongGop.AutoSize = true;
            lblNguoiDongGop.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNguoiDongGop.Location = new Point(399, 244);
            lblNguoiDongGop.Name = "lblNguoiDongGop";
            lblNguoiDongGop.Size = new Size(144, 37);
            lblNguoiDongGop.TabIndex = 11;
            lblNguoiDongGop.Text = "Đóng góp:";
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiaChi.Location = new Point(399, 178);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(104, 37);
            lblDiaChi.TabIndex = 10;
            lblDiaChi.Text = "Địa chỉ:";
            // 
            // lblGia
            // 
            lblGia.AutoSize = true;
            lblGia.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGia.Location = new Point(399, 113);
            lblGia.Name = "lblGia";
            lblGia.Size = new Size(63, 37);
            lblGia.TabIndex = 9;
            lblGia.Text = "Giá:";
            // 
            // lblTenMonAn
            // 
            lblTenMonAn.AutoSize = true;
            lblTenMonAn.BackColor = Color.Transparent;
            lblTenMonAn.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenMonAn.ForeColor = Color.LightSalmon;
            lblTenMonAn.Location = new Point(399, 34);
            lblTenMonAn.Name = "lblTenMonAn";
            lblTenMonAn.Size = new Size(143, 45);
            lblTenMonAn.TabIndex = 8;
            lblTenMonAn.Text = "Hủ Tiếu";
            // 
            // FormRandomMon
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(975, 314);
            Controls.Add(lblNguoiDongGop);
            Controls.Add(lblDiaChi);
            Controls.Add(lblGia);
            Controls.Add(lblTenMonAn);
            Controls.Add(pictureBox1);
            Name = "FormRandomMon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRandomMon";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblNguoiDongGop;
        private Label lblDiaChi;
        private Label lblGia;
        private Label lblTenMonAn;
    }
}