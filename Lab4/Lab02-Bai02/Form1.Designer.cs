namespace Lab04_Bai02
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            txtUrl = new TextBox();
            btnDownload = new Button();
            label2 = new Label();
            txtFilePath = new TextBox();
            btnBrowse = new Button();
            rtbHtml = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // txtUrl
            // 
            resources.ApplyResources(txtUrl, "txtUrl");
            txtUrl.Name = "txtUrl";
            // 
            // btnDownload
            // 
            resources.ApplyResources(btnDownload, "btnDownload");
            btnDownload.Name = "btnDownload";
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += btnDownload_Click;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // txtFilePath
            // 
            resources.ApplyResources(txtFilePath, "txtFilePath");
            txtFilePath.Name = "txtFilePath";
            // 
            // btnBrowse
            // 
            resources.ApplyResources(btnBrowse, "btnBrowse");
            btnBrowse.Name = "btnBrowse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // rtbHtml
            // 
            resources.ApplyResources(rtbHtml, "rtbHtml");
            rtbHtml.Name = "rtbHtml";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(rtbHtml);
            Controls.Add(btnBrowse);
            Controls.Add(txtFilePath);
            Controls.Add(label2);
            Controls.Add(btnDownload);
            Controls.Add(txtUrl);
            Controls.Add(label1);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.RichTextBox rtbHtml;
    }
}