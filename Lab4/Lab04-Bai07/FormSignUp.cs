namespace Lab04_Bai07;

public partial class FormSignUp : Form
{
    public FormSignUp()
    {
        InitializeComponent();
        // Thêm ngôn ngữ
        cbbLanguage.Items.Add("vi");
        cbbLanguage.Items.Add("en");
        cbbLanguage.SelectedIndex = 0;

        // Set mặc định giới tính
        radioButton1.Checked = true; // Male
    }

    private void label1_Click(object sender, EventArgs e)
    {
    }

    private async void btnSubmit_Click(object sender, EventArgs e)
    {
        // Lấy dữ liệu từ form
        var username = txtUsername.Text.Trim();
        var password = txtPassword.Text.Trim();
        var email = txtEmail.Text.Trim();
        var firstname = txtFirstname.Text.Trim();
        var lastname = txtLastname.Text.Trim();
        var phone = txtPhone.Text.Trim();
        var birthday = dateTimePicker1.Value.ToString("yyyy-MM-dd");
        var language = cbbLanguage.SelectedItem?.ToString() ?? "vi";
        var sex = radioButton1.Checked ? 1 : 0;


        // Kiểm tra rỗng
        if (username == "" || password == "" || email == "")
        {
            MessageBox.Show("Vui lòng nhập Username, Password và Email!");
            return;
        }

        try
        {
            var api = new ApiClient();

            var requestBody = new
            {
                username,
                password,
                email,
                firstname,
                lastname,
                phone,
                birthday,
                language,
                sex
            };

            // CALL API REGISTER
            var res = await api.PostAsync<RegisterResponse>(
                "/api/v1/user/signup", requestBody);


            MessageBox.Show("Đăng ký thành công!");

            // Quay về FormLogin
            var login = new FormLogin();
            login.Show();
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Đăng ký thất bại!\n" + ex.Message);
        }
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        txtUsername.Clear();
        txtPassword.Clear();
        txtEmail.Clear();
        txtFirstname.Clear();
        txtLastname.Clear();
        txtPhone.Clear();
        cbbLanguage.SelectedIndex = 0;
        radioButton1.Checked = true;
        dateTimePicker1.Value = DateTime.Now;
    }
}