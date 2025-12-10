using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04_Bai07
{
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
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string email = txtEmail.Text.Trim();
            string firstname = txtFirstname.Text.Trim();
            string lastname = txtLastname.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string birthday = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string language = cbbLanguage.SelectedItem?.ToString() ?? "vi";
            int sex = radioButton1.Checked ? 1 : 0;


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
                    username = username,
                    password = password,
                    email = email,
                    firstname = firstname,
                    lastname = lastname,
                    phone = phone,
                    birthday = birthday,
                    language = language,
                    sex = sex
                };

                // CALL API REGISTER
                var res = await api.PostAsync<RegisterResponse>(
    "/api/v1/user/signup", requestBody);



                MessageBox.Show("Đăng ký thành công!");

                // Quay về FormLogin
                FormLogin login = new FormLogin();
                login.Show();
                this.Close();
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
}
