using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Lab04_Bai01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Hàm gửi request đến URL và lấy toàn bộ HTML trả về.
        /// </summary>
        private string GetHtml(string url)
        {
            try
            {
                // Tạo request đến server
                WebRequest request = WebRequest.Create(url);

                // Nhận response
                using (WebResponse response = request.GetResponse())
                {
                    // Lấy stream chứa dữ liệu
                    using (Stream dataStream = response.GetResponseStream())
                    {
                        // Đọc stream bằng StreamReader
                        using (StreamReader reader = new StreamReader(dataStream))
                        {
                            string responseFromServer = reader.ReadToEnd();
                            return responseFromServer;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Nếu có lỗi thì trả về thông báo lỗi
                return "Error: " + ex.Message;
            }
        }

        /// <summary>
        /// Sự kiện khi bấm nút GET.
        /// </summary>
        private void btnGet_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text.Trim();

            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("Vui lòng nhập URL!");
                return;
            }

            string html = GetHtml(url);

            // Hiển thị HTML lên RichTextBox
            rtbHtml.Text = html;
        }
    }
}