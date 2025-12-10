namespace Lab04_Bai01
{
    partial class Form1
    {
        /// <summary>
        /// Biến designer.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Giải phóng tài nguyên.
        /// </summary>
        /// <param name="disposing"></param>
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
        /// Hàm khởi tạo các control trên Form.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            txtUrl = new TextBox();
            btnGet = new Button();
            rtbHtml = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 32);
            label1.TabIndex = 0;
            label1.Text = "URL:";
            // 
            // txtUrl
            // 
            txtUrl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUrl.Location = new Point(105, 19);
            txtUrl.Margin = new Padding(4, 5, 4, 5);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(601, 27);
            txtUrl.TabIndex = 1;
            txtUrl.Text = "https://www.google.com";
            // 
            // btnGet
            // 
            btnGet.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGet.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnGet.Location = new Point(715, 15);
            btnGet.Margin = new Padding(4, 5, 4, 5);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(100, 44);
            btnGet.TabIndex = 2;
            btnGet.Text = "GET";
            btnGet.UseVisualStyleBackColor = true;
            btnGet.Click += btnGet_Click;
            // 
            // rtbHtml
            // 
            rtbHtml.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtbHtml.Location = new Point(16, 69);
            rtbHtml.Margin = new Padding(4, 5, 4, 5);
            rtbHtml.Name = "rtbHtml";
            rtbHtml.Size = new Size(797, 603);
            rtbHtml.TabIndex = 3;
            rtbHtml.Text = "";
            rtbHtml.WordWrap = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(831, 692);
            Controls.Add(rtbHtml);
            Controls.Add(btnGet);
            Controls.Add(txtUrl);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Lab04 - Bài 01 - Get HTML";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.RichTextBox rtbHtml;
    }
}