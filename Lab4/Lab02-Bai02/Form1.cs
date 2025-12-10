using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Lab04_Bai02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Nút chọn nơi lưu file (SaveFileDialog).
        /// </summary>
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Filter = "HTML file (*.html)|*.html|All files (*.*)|*.*";
                dlg.FileName = "download.html";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtFilePath.Text = dlg.FileName;
                }
            }
        }

        /// <summary>
        /// Nút Download: tải nội dung trang web về file rồi đọc file hiển thị.
        /// </summary>
        private void btnDownload_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text.Trim();
            string filePath = txtFilePath.Text.Trim();

            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("Vui lòng nhập URL!");
                return;
            }

            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Vui lòng chọn nơi lưu file!");
                return;
            }

            try
            {
                // Tải file HTML về bằng WebClient
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(url, filePath);
                }

                // Đọc lại file vừa tải và hiển thị
                string html = File.ReadAllText(filePath);
                rtbHtml.Text = html;

                MessageBox.Show("Download thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }
    }
}