using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace Lab4_WebBrowser
{
    public partial class WebBrowser : Form
    {   // Khai báo đối tượng WebBrowser
        System.Windows.Forms.WebBrowser webBrowser;
        // Danh sách các liên kết đã truy cập
        List<string> links = new List<string>();
        // Số lượng liên kết đã truy cập
        int countlinks = 0;
        public WebBrowser()
        {
            InitializeComponent();
            // Tạo một đối tượng WebBrowser mặc định và thêm vào panel
            webBrowser = new System.Windows.Forms.WebBrowser();
            webBrowser.ScriptErrorsSuppressed = true;
            webBrowser.Dock = DockStyle.Fill;
            pnlBrowser.Controls.Add(webBrowser);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Nếu đã có webBrowser thì không tạo nữa
            if (webBrowser == null)
            {
                webBrowser = new System.Windows.Forms.WebBrowser();
                webBrowser.ScriptErrorsSuppressed = true;
                webBrowser.Dock = DockStyle.Fill;
                pnlBrowser.Controls.Add(webBrowser);
            }
        }

        private System.Windows.Forms.WebBrowser GetWebBrowser()
        {
            return webBrowser;
        }

        // Sửa chữ ký hàm bắt sự kiện cho đúng
        private void btnGo_Click(object sender, EventArgs e)
        {
            if (webBrowser == null)
            {
                webBrowser = new System.Windows.Forms.WebBrowser();
                webBrowser.ScriptErrorsSuppressed = true;
                webBrowser.Dock = DockStyle.Fill;
                pnlBrowser.Controls.Add(webBrowser);
            }

            string address = tbAddress.Text?.Trim();
            if (!string.IsNullOrEmpty(address))
            {
                // Nếu người dùng không nhập schema, thêm http:// mặc định
                if (!address.StartsWith("http://", StringComparison.OrdinalIgnoreCase) && !address.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
                {
                    address = "http://" + address;
                }

                try
                {
                    webBrowser.Navigate(address);
                    // Lưu trữ liên kết đã truy cập vào danh sách
                    links.Add(address);
                    countlinks++;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Navigation error: " + ex.Message);
                }
            }
        }

        private void btnDowHTML_Click(object sender, EventArgs e)
        {
            string url = tbAddress.Text?.Trim();
            string folderPath = tbPath.Text?.Trim();
            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("Please enter a URL.");
                return;
            }
            if (string.IsNullOrEmpty(folderPath))
            {
                MessageBox.Show("Please enter a folder path to save files.");
                return;
            }

            try
            {
                // Tạo thư mục nếu chưa tồn tại
                Directory.CreateDirectory(folderPath);
                // Tải và lưu nguồn của trang web
                DownloadWebsiteSource(url, folderPath);
                MessageBox.Show("Download completed!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Download failed: " + ex.Message);
            }
        }

        // Handler to download only resources (images, scripts, styles)
        private void btnDownResources_Click(object sender, EventArgs e)
        {
            string url = tbAddress.Text?.Trim();
            string folderPath = tbPath.Text?.Trim();
            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("Please enter a URL.");
                return;
            }
            if (string.IsNullOrEmpty(folderPath))
            {
                MessageBox.Show("Please enter a folder path to save files.");
                return;
            }

            try
            {
                Directory.CreateDirectory(folderPath);
                if (!url.StartsWith("http://", StringComparison.OrdinalIgnoreCase) && !url.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
                {
                    url = "http://" + url;
                }

                HtmlWeb web = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument document = web.Load(url);
                Uri baseUri = new Uri(url);
                DownloadSource(document.DocumentNode, folderPath, baseUri);
                MessageBox.Show("Resources downloaded.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Download resources failed: " + ex.Message);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            if (webBrowser != null)
            {
                try
                {
                    webBrowser.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Reload failed: " + ex.Message);
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var dlg = new FolderBrowserDialog())
            {
                dlg.Description = "Select folder to save downloaded files";
                dlg.ShowNewFolderButton = true;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    tbPath.Text = dlg.SelectedPath;
                }
            }
        }

        private void DownloadWebsiteSource(string url, string folderPath)
        {
            // Đảm bảo URL có schema
            if (!url.StartsWith("http://", StringComparison.OrdinalIgnoreCase) && !url.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
            {
                url = "http://" + url;
            }

            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument document = web.Load(url);

            // Lưu trữ nguồn (source) của trang web
            string source = document.DocumentNode.OuterHtml;

            // Lấy tên tệp tin từ URL (tạo tên hợp lệ)
            Uri baseUri = new Uri(url);
            string fileName = baseUri.Host + baseUri.AbsolutePath.Replace('/', '_');
            if (string.IsNullOrEmpty(Path.GetFileName(fileName)))
            {
                fileName = baseUri.Host + "_index";
            }
            // Loại bỏ ký tự không hợp lệ
            foreach (char c in Path.GetInvalidFileNameChars())
            {
                fileName = fileName.Replace(c, '_');
            }

            // Kết hợp đường dẫn thư mục và tên tệp tin
            string filePath = Path.Combine(folderPath, fileName + ".html");
            File.WriteAllText(filePath, source);

            // Download các hình ảnh và file liên quan
            DownloadSource(document.DocumentNode, folderPath, baseUri);
        }


        void DownloadSource(HtmlAgilityPack.HtmlNode node, string folderPath, Uri baseUri)
        {
            if (node.NodeType == HtmlAgilityPack.HtmlNodeType.Element)
            {
                // Kiểm tra các thẻ HTML img, link và script
                if (node.Name == "img" || node.Name == "link" || node.Name == "script")
                {
                    // Lấy thuộc tính src hoặc href của thẻ
                    string sourceUrl = node.GetAttributeValue("src", null) ?? node.GetAttributeValue("href", null);

                    if (!string.IsNullOrEmpty(sourceUrl))
                    {
                        try
                        {
                            // Chuyển URL tương đối thành URL tuyệt đối
                            Uri resourceUri = null;
                            if (Uri.TryCreate(sourceUrl, UriKind.Absolute, out resourceUri) == false)
                            {
                                // relative
                                resourceUri = new Uri(baseUri, sourceUrl);
                            }

                            // Tạo đường dẫn lưu trữ cho tệp tin
                            string fileName = Path.GetFileName(resourceUri.LocalPath);
                            if (string.IsNullOrEmpty(fileName))
                            {
                                // nếu không có tên tệp, dùng host + hash
                                fileName = resourceUri.Host + "_" + Math.Abs(resourceUri.GetHashCode()).ToString();
                            }

                            // Loại bỏ ký tự không hợp lệ
                            foreach (char c in Path.GetInvalidFileNameChars())
                            {
                                fileName = fileName.Replace(c, '_');
                            }

                            string filePath = Path.Combine(folderPath, fileName);

                            // Nếu file đã tồn tại, thêm số để tránh ghi đè
                            int copyIndex = 1;
                            string originalFilePath = filePath;
                            while (File.Exists(filePath))
                            {
                                filePath = Path.Combine(folderPath, Path.GetFileNameWithoutExtension(originalFilePath) + "_" + copyIndex + Path.GetExtension(originalFilePath));
                                copyIndex++;
                            }

                            // Tải và lưu tệp tin
                            using (WebClient client = new WebClient())
                            {
                                client.DownloadFile(resourceUri.AbsoluteUri, filePath);
                            }
                        }
                        catch
                        {
                            // Bỏ qua các lỗi tải về (đường dẫn không hợp lệ, lỗi mạng,...)
                        }
                    }
                }
            }
            foreach (HtmlAgilityPack.HtmlNode childNode in node.ChildNodes)
            {
                DownloadSource(childNode, folderPath, baseUri);
            }
        }

        private void btnViewSource_Click(object sender, EventArgs e)
        {
            string url = tbAddress.Text?.Trim();
            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("Please enter a URL.");
                return;
            }

            try
            {
                // Tải nguồn của trang web
                HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
                HtmlAgilityPack.HtmlDocument document = web.Load(url);
                // Lưu trữ nguồn của trang web vào biến source
                string source = document.DocumentNode.OuterHtml;
                // Hiển thị nguồn trong một cửa sổ Resource
                using (Resource viewSourceForm = new Resource())
                {
                    viewSourceForm.SetSource(source);
                    viewSourceForm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load source: " + ex.Message);
            }
        }
    }
}
