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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new System.Windows.Forms.Label();
            txtUrl = new System.Windows.Forms.TextBox();
            btnGet = new System.Windows.Forms.Button();
            rtbHtml = new System.Windows.Forms.RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)), System.Drawing.GraphicsUnit.Point, ((byte)0));
            label1.Location = new System.Drawing.Point(13, 15);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(84, 32);
            label1.TabIndex = 0;
            label1.Text = "URL:";
            // 
            // txtUrl
            // 
            txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            txtUrl.Location = new System.Drawing.Point(105, 19);
            txtUrl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new System.Drawing.Size(601, 27);
            txtUrl.TabIndex = 1;
            txtUrl.Text = "https://www.google.com";
            // 
            // btnGet
            // 
            btnGet.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            btnGet.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)), System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnGet.Location = new System.Drawing.Point(715, 15);
            btnGet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnGet.Name = "btnGet";
            btnGet.Size = new System.Drawing.Size(100, 44);
            btnGet.TabIndex = 2;
            btnGet.Text = "GET";
            btnGet.UseVisualStyleBackColor = true;
            btnGet.Click += btnGet_Click;
            // 
            // rtbHtml
            // 
            rtbHtml.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            rtbHtml.Location = new System.Drawing.Point(16, 69);
            rtbHtml.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            rtbHtml.Name = "rtbHtml";
            rtbHtml.Size = new System.Drawing.Size(797, 603);
            rtbHtml.TabIndex = 3;
            rtbHtml.Text = "";
            rtbHtml.WordWrap = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = ((System.Drawing.Image)resources.GetObject("$this.BackgroundImage"));
            ClientSize = new System.Drawing.Size(831, 692);
            Controls.Add(rtbHtml);
            Controls.Add(btnGet);
            Controls.Add(txtUrl);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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