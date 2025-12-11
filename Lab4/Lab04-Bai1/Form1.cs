using System.Net;

namespace Lab04_Bai01;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    /// <summary>
    ///     Hàm gửi request đến URL và lấy toàn bộ HTML trả về.
    /// </summary>
    private string GetHtml(string url)
    {
        try
        {
            // Tạo request đến server
            var request = WebRequest.Create(url);

            // Nhận response
            using (var response = request.GetResponse())
            {
                // Lấy stream chứa dữ liệu
                using (var dataStream = response.GetResponseStream())
                {
                    // Đọc stream bằng StreamReader
                    using (var reader = new StreamReader(dataStream))
                    {
                        var responseFromServer = reader.ReadToEnd();
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
    ///     Sự kiện khi bấm nút GET.
    /// </summary>
    private void btnGet_Click(object sender, EventArgs e)
    {
        var url = txtUrl.Text.Trim();

        if (string.IsNullOrEmpty(url))
        {
            MessageBox.Show("Vui lòng nhập URL!");
            return;
        }

        var html = GetHtml(url);

        // Hiển thị HTML lên RichTextBox
        rtbHtml.Text = html;
    }
}