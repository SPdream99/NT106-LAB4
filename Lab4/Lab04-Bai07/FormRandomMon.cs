namespace Lab04_Bai07;

public partial class FormRandomMon : Form
{
    private readonly FoodModel food;

    public FormRandomMon(FoodModel f)
    {
        InitializeComponent();
        food = f;
        Bind(food);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
    }

    // Hàm nhận dữ liệu món ăn từ FormMain
    public void Bind(FoodModel f)
    {
        // Tên món ăn
        lblTenMonAn.Text = $"ĂN {f.ten_mon_an.ToUpper()} ĐI!!!";

        // Giá
        lblGia.Text = "Giá: " + f.gia;

        // Địa điểm
        lblDiaChi.Text = "Địa chỉ: " + f.dia_chi;

        // Người đóng góp
        lblNguoiDongGop.Text = "Đăng bởi: " + f.nguoi_dong_gop;

        // Hình ảnh
        if (!string.IsNullOrEmpty(f.hinh_anh))
            try
            {
                pictureBox1.ImageLocation = f.hinh_anh;
            }
            catch
            {
                pictureBox1.Image = null;
            }
    }
}