using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lab04_Bai05
{
    public partial class MainForm : Form
    {
        private readonly ApiService api = new ApiService();

        private Process proc;

        public MainForm()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            txtURL.Text = "https://nt106.uitiot.vn/auth/token";
            txtUsername.Text = "phatpt";
            txtPassword.Text = "123456";
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            lstView.Items.Clear();

            var url = txtURL.Text;
            var username = txtUsername.Text;
            var password = txtPassword.Text;

            lstView.Items.Add("Logging in...");

            var result = await api.LoginAsync(url, username, password);

            if (result.Success)
            {
                lstView.Items.Add("Token Type: " + result.TokenType);
                lstView.Items.Add("Access Token: " + result.AccessToken);
                lstView.Items.Add("Login success");
                try
                {
                    var startInfo = new ProcessStartInfo();

                    startInfo.FileName = "..\\..\\..\\Lab04-Bai06\\bin\\Debug\\Lab04-Bai06.exe";
                    startInfo.Arguments = $"-TokenType \"{result.TokenType}\" -AccessToken {result.AccessToken}";
                    using (proc = Process.Start(startInfo))
                    {
                        proc.WaitForExit();
                        proc = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error opening program: {ex.Message}", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                lstView.Items.Add("Login failed");
                lstView.Items.Add("Detail: " + result.Detail);
                try
                {
                    var startInfo = new ProcessStartInfo();

                    startInfo.FileName = "..\\..\\..\\Lab04-Bai06\\bin\\Debug\\Lab04-Bai06.exe";
                    using (proc = Process.Start(startInfo))
                    {
                        proc.WaitForExit();
                        proc = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error opening program: {ex.Message}", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (proc != null)
            {
                proc.Kill();
                proc.Dispose();
            }
        }
    }
}