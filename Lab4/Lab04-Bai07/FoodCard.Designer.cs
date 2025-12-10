namespace Lab04_Bai07
{
    partial class FoodCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            picImage = new PictureBox();
            lblTenMonAn = new Label();
            lblGia = new Label();
            lblDiaChi = new Label();
            lblNguoiDongGop = new Label();
            btnXoa = new Button();
            ((System.ComponentModel.ISupportInitialize)picImage).BeginInit();
            SuspendLayout();
            // 
            // picImage
            // 
            picImage.Dock = DockStyle.Left;
            picImage.Location = new Point(0, 0);
            picImage.Name = "picImage";
            picImage.Size = new Size(380, 345);
            picImage.TabIndex = 0;
            picImage.TabStop = false;
            // 
            // lblTenMonAn
            // 
            lblTenMonAn.AutoSize = true;
            lblTenMonAn.BackColor = Color.Transparent;
            lblTenMonAn.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenMonAn.ForeColor = Color.LightSalmon;
            lblTenMonAn.Location = new Point(428, 16);
            lblTenMonAn.Name = "lblTenMonAn";
            lblTenMonAn.Size = new Size(168, 51);
            lblTenMonAn.TabIndex = 4;
            lblTenMonAn.Text = "Hủ Tiếu";
            // 
            // lblGia
            // 
            lblGia.AutoSize = true;
            lblGia.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGia.Location = new Point(428, 95);
            lblGia.Name = "lblGia";
            lblGia.Size = new Size(63, 37);
            lblGia.TabIndex = 5;
            lblGia.Text = "Giá:";
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiaChi.Location = new Point(428, 160);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(104, 37);
            lblDiaChi.TabIndex = 6;
            lblDiaChi.Text = "Địa chỉ:";
            // 
            // lblNguoiDongGop
            // 
            lblNguoiDongGop.AutoSize = true;
            lblNguoiDongGop.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNguoiDongGop.Location = new Point(428, 226);
            lblNguoiDongGop.Name = "lblNguoiDongGop";
            lblNguoiDongGop.Size = new Size(144, 37);
            lblNguoiDongGop.TabIndex = 7;
            lblNguoiDongGop.Text = "Đóng góp:";
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.MistyRose;
            btnXoa.Font = new Font("Segoe UI Black", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(824, 271);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 57);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // FoodCard
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnXoa);
            Controls.Add(lblNguoiDongGop);
            Controls.Add(lblDiaChi);
            Controls.Add(lblGia);
            Controls.Add(lblTenMonAn);
            Controls.Add(picImage);
            Name = "FoodCard";
            Size = new Size(1012, 345);
            ((System.ComponentModel.ISupportInitialize)picImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picImage;
        private Label lblTenMonAn;
        private Label lblGia;
        private Label lblDiaChi;
        private Label lblNguoiDongGop;
        private Button btnXoa;
    }
}
