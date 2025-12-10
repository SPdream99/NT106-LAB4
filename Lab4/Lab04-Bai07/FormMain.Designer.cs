namespace Lab04_Bai07
{
    partial class FormMain
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
            btnAnGiGio = new Button();
            btnThemMonAn = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            flowAll = new FlowLayoutPanel();
            tabPage2 = new TabPage();
            flowDongGop = new FlowLayoutPanel();
            statusStrip1 = new StatusStrip();
            lblWelcome = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            progressBar1 = new ToolStripProgressBar();
            comboBox1 = new ComboBox();
            label8 = new Label();
            lblPage = new Label();
            btnPrev = new Button();
            btnNext = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightSalmon;
            label1.Location = new Point(22, 37);
            label1.Name = "label1";
            label1.Size = new Size(368, 59);
            label1.TabIndex = 2;
            label1.Text = "Hôm Nay Ăn Gì?";
            // 
            // btnAnGiGio
            // 
            btnAnGiGio.BackColor = Color.LightSalmon;
            btnAnGiGio.Font = new Font("Segoe UI Black", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnGiGio.Location = new Point(466, 37);
            btnAnGiGio.Name = "btnAnGiGio";
            btnAnGiGio.Size = new Size(200, 83);
            btnAnGiGio.TabIndex = 8;
            btnAnGiGio.Text = "Ăn gì giờ?";
            btnAnGiGio.UseVisualStyleBackColor = false;
            btnAnGiGio.Click += btnAnGiGio_Click;
            // 
            // btnThemMonAn
            // 
            btnThemMonAn.BackColor = Color.LightSalmon;
            btnThemMonAn.Font = new Font("Segoe UI Black", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThemMonAn.Location = new Point(714, 37);
            btnThemMonAn.Name = "btnThemMonAn";
            btnThemMonAn.Size = new Size(242, 83);
            btnThemMonAn.TabIndex = 9;
            btnThemMonAn.Text = "Thêm Món Ăn";
            btnThemMonAn.UseVisualStyleBackColor = false;
            btnThemMonAn.Click += btnThemMonAn_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(22, 133);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1034, 954);
            tabControl1.TabIndex = 10;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(flowAll);
            tabPage1.Location = new Point(8, 46);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1018, 900);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "All";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // flowAll
            // 
            flowAll.AutoScroll = true;
            flowAll.Dock = DockStyle.Fill;
            flowAll.Location = new Point(3, 3);
            flowAll.Name = "flowAll";
            flowAll.Size = new Size(1012, 894);
            flowAll.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(flowDongGop);
            tabPage2.Location = new Point(8, 46);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1018, 538);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Tôi đóng góp";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // flowDongGop
            // 
            flowDongGop.AutoScroll = true;
            flowDongGop.Dock = DockStyle.Fill;
            flowDongGop.Location = new Point(3, 3);
            flowDongGop.Name = "flowDongGop";
            flowDongGop.Size = new Size(1012, 532);
            flowDongGop.TabIndex = 0;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(32, 32);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblWelcome, toolStripStatusLabel2, progressBar1 });
            statusStrip1.Location = new Point(0, 1161);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1088, 42);
            statusStrip1.TabIndex = 17;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblWelcome
            // 
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(165, 32);
            lblWelcome.Text = "Welcome, Bao";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.ForeColor = SystemColors.Highlight;
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(123, 32);
            toolStripStatusLabel2.Text = "Đăng xuất";
            toolStripStatusLabel2.Click += toolStripStatusLabel2_Click;
            // 
            // progressBar1
            // 
            progressBar1.MarqueeAnimationSpeed = 30;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(100, 30);
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.Visible = false;
            progressBar1.Click += toolStripProgressBar1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(962, 1093);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(68, 40);
            comboBox1.TabIndex = 24;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(841, 1101);
            label8.Name = "label8";
            label8.Size = new Size(115, 32);
            label8.TabIndex = 23;
            label8.Text = "Page Size";
            // 
            // lblPage
            // 
            lblPage.AutoSize = true;
            lblPage.Location = new Point(202, 1101);
            lblPage.Name = "lblPage";
            lblPage.Size = new Size(65, 32);
            lblPage.TabIndex = 0;
            lblPage.Text = "Page";
            // 
            // btnPrev
            // 
            btnPrev.Location = new Point(30, 1094);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(150, 46);
            btnPrev.TabIndex = 25;
            btnPrev.Text = "Trước";
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += btnPrev_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(305, 1094);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(150, 46);
            btnNext.TabIndex = 26;
            btnNext.Text = "Sau";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(1088, 1203);
            Controls.Add(btnNext);
            Controls.Add(btnPrev);
            Controls.Add(lblPage);
            Controls.Add(comboBox1);
            Controls.Add(label8);
            Controls.Add(statusStrip1);
            Controls.Add(tabControl1);
            Controls.Add(btnThemMonAn);
            Controls.Add(btnAnGiGio);
            Controls.Add(label1);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMain";
            Load += FormMain_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAnGiGio;
        private Button btnThemMonAn;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private FlowLayoutPanel flowAll;
        private FlowLayoutPanel flowDongGop;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblWelcome;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripProgressBar progressBar1;
        private ComboBox comboBox1;
        private Label label8;
        private Label lblPage;
        private Button btnPrev;
        private Button btnNext;
    }
}