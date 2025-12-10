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
    public partial class FormThemMonAn : Form
    {
        public FormThemMonAn()
        {
            InitializeComponent();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTenMonAn.Clear();
            txtGia.Clear();
            txtDiaChi.Clear();
            txtHinhAnh.Clear();
            richtxtboxMoTa.Clear();
        }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // validation
                if (string.IsNullOrWhiteSpace(txtTenMonAn.Text) ||
                    string.IsNullOrWhiteSpace(txtGia.Text) ||
                    string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
                    string.IsNullOrWhiteSpace(txtHinhAnh.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thiếu dữ liệu",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtGia.Text.Trim(), out int gia))
                {
                    MessageBox.Show("Giá phải là số nguyên!", "Sai định dạng",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // tạo body gửi api
                var body = new
                {
                    ten_mon_an = txtTenMonAn.Text.Trim(),
                    gia = gia,
                    mo_ta = richtxtboxMoTa.Text.Trim(),
                    hinh_anh = txtHinhAnh.Text.Trim(),
                    dia_chi = txtDiaChi.Text.Trim()
                };

                var api = new ApiClient();
                var res = await api.PostAsync<FoodModel>("api/v1/monan/add", body);

                MessageBox.Show("Thêm món ăn thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close(); // Đóng form sau khi thêm xong
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm món ăn:\n" + ex.Message,
                    "Lỗi API", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
