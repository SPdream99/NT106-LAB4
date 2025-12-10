using Newtonsoft.Json;


namespace Lab04_Bai07
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
           


        }

        // btn đăng nhập
        private async void BtnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Vui lòng nhập Username và Password!");
                return;
            }

            try
            {
                var api = new ApiClient();

                var body = new
                {
                    username = username,
                    password = password
                };

                var form = new Dictionary<string, string>
{
    { "username", username },
    { "password", password }
};

                var res = await api.PostFormAsync<LoginResponse>("auth/token", form);

                ApiClient.Token = res.access_token;   // Lưu token để dùng API sau này
                ApiClient.CurrentUsername = username;

                MessageBox.Show("Đăng nhập thành công!");

                // mở FormMain
                FormMain main = new FormMain(ApiClient.CurrentUsername);
                main.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đăng nhập thất bại!\n" + ex.Message);
            }
        }

        // ==== BUTTON ĐĂNG KÝ ====
        private void BtnDangKy_Click(object sender, EventArgs e)
        {
            FormSignUp f = new FormSignUp();
            f.Show();
            this.Hide();
        }
    }
}
