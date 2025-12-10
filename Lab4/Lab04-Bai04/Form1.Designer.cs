namespace Lab04_Bai04
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            progressBar1 = new ProgressBar();
            btnLoadPhim = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            tabPage2 = new TabPage();
            label8 = new Label();
            btnDatVe = new Button();
            panel3 = new Panel();
            btnC5 = new Button();
            btnB5 = new Button();
            btnC4 = new Button();
            btnB4 = new Button();
            btnC3 = new Button();
            btnB3 = new Button();
            btnC2 = new Button();
            btnB2 = new Button();
            btnC1 = new Button();
            btnB1 = new Button();
            btnA5 = new Button();
            btnA4 = new Button();
            btnA3 = new Button();
            btnA2 = new Button();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            btnA1 = new Button();
            cbbPhongChieu = new ComboBox();
            txtSDT = new TextBox();
            txtTenKH = new TextBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            tabPage2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(progressBar1);
            panel1.Controls.Add(btnLoadPhim);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(681, 905);
            panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(21, 158);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(636, 713);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 93);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(666, 46);
            progressBar1.TabIndex = 1;
            // 
            // btnLoadPhim
            // 
            btnLoadPhim.BackColor = Color.Coral;
            btnLoadPhim.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLoadPhim.Location = new Point(12, 12);
            btnLoadPhim.Name = "btnLoadPhim";
            btnLoadPhim.Size = new Size(290, 62);
            btnLoadPhim.TabIndex = 0;
            btnLoadPhim.Text = "Tải Danh Sách Phim";
            btnLoadPhim.UseVisualStyleBackColor = false;
            btnLoadPhim.Click += btnLoadPhim_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(687, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1480, 899);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(webView21);
            tabPage1.Location = new Point(8, 46);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1464, 845);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Chi Tiết Phim";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.BackColor = Color.SeaShell;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Dock = DockStyle.Fill;
            webView21.Location = new Point(3, 3);
            webView21.Name = "webView21";
            webView21.Size = new Size(1458, 839);
            webView21.TabIndex = 0;
            webView21.ZoomFactor = 1D;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(btnDatVe);
            tabPage2.Controls.Add(panel3);
            tabPage2.Controls.Add(cbbPhongChieu);
            tabPage2.Controls.Add(txtSDT);
            tabPage2.Controls.Add(txtTenKH);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(label14);
            tabPage2.Location = new Point(8, 46);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1464, 845);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Đặt Vé";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font(".VnVogueH", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(1086, 387);
            label8.Name = "label8";
            label8.Size = new Size(227, 51);
            label8.TabIndex = 16;
            label8.Text = "Tổng Tiền:";
            // 
            // btnDatVe
            // 
            btnDatVe.BackColor = Color.LightSkyBlue;
            btnDatVe.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDatVe.Location = new Point(1188, 580);
            btnDatVe.Name = "btnDatVe";
            btnDatVe.Size = new Size(196, 70);
            btnDatVe.TabIndex = 11;
            btnDatVe.Text = "Đặt Vé";
            btnDatVe.UseVisualStyleBackColor = false;
            btnDatVe.Click += btnDatVe_Click;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(btnC5);
            panel3.Controls.Add(btnB5);
            panel3.Controls.Add(btnC4);
            panel3.Controls.Add(btnB4);
            panel3.Controls.Add(btnC3);
            panel3.Controls.Add(btnB3);
            panel3.Controls.Add(btnC2);
            panel3.Controls.Add(btnB2);
            panel3.Controls.Add(btnC1);
            panel3.Controls.Add(btnB1);
            panel3.Controls.Add(btnA5);
            panel3.Controls.Add(btnA4);
            panel3.Controls.Add(btnA3);
            panel3.Controls.Add(btnA2);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(btnA1);
            panel3.Location = new Point(155, 338);
            panel3.Name = "panel3";
            panel3.Size = new Size(863, 452);
            panel3.TabIndex = 15;
            // 
            // btnC5
            // 
            btnC5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnC5.Location = new Point(720, 322);
            btnC5.Name = "btnC5";
            btnC5.Size = new Size(80, 73);
            btnC5.TabIndex = 31;
            btnC5.Text = "5";
            btnC5.UseVisualStyleBackColor = true;
            // 
            // btnB5
            // 
            btnB5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnB5.Location = new Point(720, 187);
            btnB5.Name = "btnB5";
            btnB5.Size = new Size(80, 73);
            btnB5.TabIndex = 30;
            btnB5.Text = "5";
            btnB5.UseVisualStyleBackColor = true;
            // 
            // btnC4
            // 
            btnC4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnC4.Location = new Point(570, 322);
            btnC4.Name = "btnC4";
            btnC4.Size = new Size(80, 73);
            btnC4.TabIndex = 29;
            btnC4.Text = "4";
            btnC4.UseVisualStyleBackColor = true;
            // 
            // btnB4
            // 
            btnB4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnB4.Location = new Point(570, 187);
            btnB4.Name = "btnB4";
            btnB4.Size = new Size(80, 73);
            btnB4.TabIndex = 28;
            btnB4.Text = "4";
            btnB4.UseVisualStyleBackColor = true;
            // 
            // btnC3
            // 
            btnC3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnC3.Location = new Point(421, 322);
            btnC3.Name = "btnC3";
            btnC3.Size = new Size(80, 73);
            btnC3.TabIndex = 27;
            btnC3.Text = "3";
            btnC3.UseVisualStyleBackColor = true;
            // 
            // btnB3
            // 
            btnB3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnB3.Location = new Point(421, 187);
            btnB3.Name = "btnB3";
            btnB3.Size = new Size(80, 73);
            btnB3.TabIndex = 26;
            btnB3.Text = "3";
            btnB3.UseVisualStyleBackColor = true;
            // 
            // btnC2
            // 
            btnC2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnC2.Location = new Point(277, 322);
            btnC2.Name = "btnC2";
            btnC2.Size = new Size(80, 73);
            btnC2.TabIndex = 25;
            btnC2.Text = "2";
            btnC2.UseVisualStyleBackColor = true;
            // 
            // btnB2
            // 
            btnB2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnB2.Location = new Point(277, 187);
            btnB2.Name = "btnB2";
            btnB2.Size = new Size(80, 73);
            btnB2.TabIndex = 24;
            btnB2.Text = "2";
            btnB2.UseVisualStyleBackColor = true;
            // 
            // btnC1
            // 
            btnC1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnC1.Location = new Point(135, 322);
            btnC1.Name = "btnC1";
            btnC1.Size = new Size(80, 73);
            btnC1.TabIndex = 23;
            btnC1.Text = "1";
            btnC1.UseVisualStyleBackColor = true;
            // 
            // btnB1
            // 
            btnB1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnB1.Location = new Point(135, 187);
            btnB1.Name = "btnB1";
            btnB1.Size = new Size(80, 73);
            btnB1.TabIndex = 22;
            btnB1.Text = "1";
            btnB1.UseVisualStyleBackColor = true;
            // 
            // btnA5
            // 
            btnA5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnA5.Location = new Point(720, 63);
            btnA5.Name = "btnA5";
            btnA5.Size = new Size(80, 73);
            btnA5.TabIndex = 21;
            btnA5.Text = "5";
            btnA5.UseVisualStyleBackColor = true;
            // 
            // btnA4
            // 
            btnA4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnA4.Location = new Point(570, 63);
            btnA4.Name = "btnA4";
            btnA4.Size = new Size(80, 73);
            btnA4.TabIndex = 20;
            btnA4.Text = "4";
            btnA4.UseVisualStyleBackColor = true;
            // 
            // btnA3
            // 
            btnA3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnA3.Location = new Point(421, 63);
            btnA3.Name = "btnA3";
            btnA3.Size = new Size(80, 73);
            btnA3.TabIndex = 19;
            btnA3.Text = "3";
            btnA3.UseVisualStyleBackColor = true;
            // 
            // btnA2
            // 
            btnA2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnA2.Location = new Point(277, 63);
            btnA2.Name = "btnA2";
            btnA2.Size = new Size(80, 73);
            btnA2.TabIndex = 18;
            btnA2.Text = "2";
            btnA2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font(".VnBodoniH", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(38, 331);
            label9.Name = "label9";
            label9.Size = new Size(59, 64);
            label9.TabIndex = 17;
            label9.Text = "C";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font(".VnBodoniH", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(38, 196);
            label10.Name = "label10";
            label10.Size = new Size(64, 64);
            label10.TabIndex = 16;
            label10.Text = "B";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font(".VnBodoniH", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(38, 72);
            label11.Name = "label11";
            label11.Size = new Size(64, 64);
            label11.TabIndex = 15;
            label11.Text = "A";
            // 
            // btnA1
            // 
            btnA1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnA1.Location = new Point(135, 63);
            btnA1.Name = "btnA1";
            btnA1.Size = new Size(80, 73);
            btnA1.TabIndex = 0;
            btnA1.Text = "1";
            btnA1.UseVisualStyleBackColor = true;
            // 
            // cbbPhongChieu
            // 
            cbbPhongChieu.FormattingEnabled = true;
            cbbPhongChieu.Location = new Point(323, 206);
            cbbPhongChieu.Name = "cbbPhongChieu";
            cbbPhongChieu.Size = new Size(242, 40);
            cbbPhongChieu.TabIndex = 14;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(323, 129);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(323, 39);
            txtSDT.TabIndex = 13;
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(323, 55);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(323, 39);
            txtTenKH.TabIndex = 12;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(80, 129);
            label12.Name = "label12";
            label12.Size = new Size(193, 40);
            label12.TabIndex = 10;
            label12.Text = "Số Điện Thoại";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(80, 203);
            label13.Name = "label13";
            label13.Size = new Size(179, 40);
            label13.TabIndex = 9;
            label13.Text = "Phòng Chiếu";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(80, 55);
            label14.Name = "label14";
            label14.Size = new Size(222, 40);
            label14.TabIndex = 8;
            label14.Text = "Tên Khách Hàng";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(2179, 928);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private FlowLayoutPanel flowLayoutPanel1;
        private ProgressBar progressBar1;
        private Button btnLoadPhim;
        private Label label8;
        private Button btnDatVe;
        private Panel panel3;
        private Button btnC5;
        private Button btnB5;
        private Button btnC4;
        private Button btnB4;
        private Button btnC3;
        private Button btnB3;
        private Button btnC2;
        private Button btnB2;
        private Button btnC1;
        private Button btnB1;
        private Button btnA5;
        private Button btnA4;
        private Button btnA3;
        private Button btnA2;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button btnA1;
        private ComboBox cbbPhongChieu;
        private TextBox txtSDT;
        private TextBox txtTenKH;
        private Label label12;
        private Label label13;
        private Label label14;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    }
}
