namespace Lab04_Bai07;

public partial class FoodCard : UserControl
{
    public FoodCard()
    {
        InitializeComponent();
        picImage.SizeMode = PictureBoxSizeMode.Zoom;
    }

    public string FoodId { get; private set; }
    public event Action OnDeleted;

    public void BindData(FoodModel food)
    {
        FoodId = food.id;
        lblTenMonAn.Text = food.ten_mon_an;
        lblGia.Text = "Giá: " + food.gia;
        lblDiaChi.Text = "Địa chỉ: " + food.dia_chi;
        lblNguoiDongGop.Text = "Đóng góp: " + food.nguoi_dong_gop;

        picImage.ImageLocation = food.hinh_anh;
    }

    private async void btnXoa_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Bạn có chắc muốn xóa món này?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            return;

        try
        {
            var api = new ApiClient();
            await api.DeleteAsync($"api/v1/monan/{FoodId}");

            MessageBox.Show("Xóa món thành công!");

            OnDeleted?.Invoke(); // Báo lên FormMain
            Parent.Controls.Remove(this); // Xóa UI
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi khi xóa món:\n" + ex.Message);
        }
    }
}