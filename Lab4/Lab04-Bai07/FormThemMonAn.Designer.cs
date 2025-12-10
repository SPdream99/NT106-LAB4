namespace Lab04_Bai07
{
    partial class FormThemMonAn
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtTenMonAn = new TextBox();
            txtGia = new TextBox();
            txtDiaChi = new TextBox();
            txtHinhAnh = new TextBox();
            richtxtboxMoTa = new RichTextBox();
            btnClear = new Button();
            btnThem = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightSalmon;
            label1.Location = new Point(221, 65);
            label1.Name = "label1";
            label1.Size = new Size(323, 59);
            label1.TabIndex = 3;
            label1.Text = "Thêm Món Ăn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(95, 151);
            label2.Name = "label2";
            label2.Size = new Size(154, 37);
            label2.TabIndex = 4;
            label2.Text = "Tên món ăn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(95, 222);
            label3.Name = "label3";
            label3.Size = new Size(57, 37);
            label3.TabIndex = 5;
            label3.Text = "Giá";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(95, 292);
            label4.Name = "label4";
            label4.Size = new Size(98, 37);
            label4.TabIndex = 6;
            label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(95, 367);
            label5.Name = "label5";
            label5.Size = new Size(124, 37);
            label5.TabIndex = 7;
            label5.Text = "Hình ảnh";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(95, 443);
            label6.Name = "label6";
            label6.Size = new Size(87, 37);
            label6.TabIndex = 8;
            label6.Text = "Mô tả";
            // 
            // txtTenMonAn
            // 
            txtTenMonAn.Location = new Point(279, 149);
            txtTenMonAn.Name = "txtTenMonAn";
            txtTenMonAn.Size = new Size(376, 39);
            txtTenMonAn.TabIndex = 9;
            // 
            // txtGia
            // 
            txtGia.Location = new Point(279, 220);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(376, 39);
            txtGia.TabIndex = 10;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(279, 290);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(376, 39);
            txtDiaChi.TabIndex = 11;
            // 
            // txtHinhAnh
            // 
            txtHinhAnh.Location = new Point(279, 365);
            txtHinhAnh.Name = "txtHinhAnh";
            txtHinhAnh.Size = new Size(376, 39);
            txtHinhAnh.TabIndex = 12;
            // 
            // richtxtboxMoTa
            // 
            richtxtboxMoTa.Location = new Point(279, 430);
            richtxtboxMoTa.Name = "richtxtboxMoTa";
            richtxtboxMoTa.Size = new Size(376, 192);
            richtxtboxMoTa.TabIndex = 13;
            richtxtboxMoTa.Text = "";
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI Black", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(250, 663);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(150, 57);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI Black", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(484, 663);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(150, 57);
            btnThem.TabIndex = 15;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // FormThemMonAn
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(825, 760);
            Controls.Add(btnThem);
            Controls.Add(btnClear);
            Controls.Add(richtxtboxMoTa);
            Controls.Add(txtHinhAnh);
            Controls.Add(txtDiaChi);
            Controls.Add(txtGia);
            Controls.Add(txtTenMonAn);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormThemMonAn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormThemMonAn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtTenMonAn;
        private TextBox txtGia;
        private TextBox txtDiaChi;
        private TextBox txtHinhAnh;
        private RichTextBox richtxtboxMoTa;
        private Button btnClear;
        private Button btnThem;
    }
}