namespace Lab04_Bai07;

public partial class FormMain : Form
{
    private List<FoodModel> allFoods = new();
    private bool isLoading = true;
    private List<FoodModel> myFoods = new();

    private int pageAll = 1;
    private int pageMy = 1;

    private int pageSize = 5;


    public FormMain(string username)
    {
        InitializeComponent();
        lblWelcome.Text = $"Welcome, {username}";
    }

    private async void FormMain_Load(object sender, EventArgs e)
    {
        isLoading = true;
        comboBox1.Items.Add(5);
        comboBox1.Items.Add(10);
        comboBox1.Items.Add(20);
        comboBox1.SelectedIndex = 0;


        await LoadAllFoods();
        await LoadMyFoods();
        UpdatePageLabel();

        isLoading = false;
    }


    // LOAD ALL FOODS (GET)
    private async Task LoadAllFoods()
    {
        try
        {
            ShowProgress();

            var api = new ApiClient();
            var body = new { page = 1, pageSize = 9999 };

            var res = await api.PostAsync<FoodListResponse>("api/v1/monan/all", body);

            allFoods = res.data ?? new List<FoodModel>();

            ApplyPaginationAll();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi load ALL món:\n" + ex.Message);
        }
        finally
        {
            HideProgress(); // ← TẮT PROGRESS
        }
    }


    // LOAD MY FOODS (GET)

    private async Task LoadMyFoods()
    {
        try
        {
            ShowProgress();

            var api = new ApiClient();
            var body = new { page = 1, pageSize = 9999 };

            var res = await api.PostAsync<FoodListResponse>("api/v1/monan/my-dishes", body);

            myFoods = res.data ?? new List<FoodModel>();

            ApplyPaginationMyFoods();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi load MY DISHES:\n" + ex.Message);
        }
        finally
        {
            HideProgress();
        }
    }

    private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        pageSize = Convert.ToInt32(comboBox1.SelectedItem);
        await LoadAllFoods();
        await LoadMyFoods();
    }


    // RANDOM FOOD
    private async void btnAnGiGio_Click(object sender, EventArgs e)
    {
        List<FoodModel> source;

        // Nếu đang ở tab ALL (tabControl1 index = 0)
        if (tabControl1.SelectedIndex == 0)
            source = allFoods;
        else // tab MY (index = 1)
            source = myFoods;

        if (source == null || source.Count == 0)
        {
            MessageBox.Show("Không có món nào để random!");
            return;
        }

        // Random
        var rd = new Random();
        var pick = source[rd.Next(source.Count)];

        // Mở form random
        var frm = new FormRandomMon(pick);
        frm.ShowDialog();
    }

    private void btnThemMonAn_Click(object sender, EventArgs e)
    {
        var add = new FormThemMonAn();
        add.ShowDialog();

        _ = LoadAllFoods();
        _ = LoadMyFoods();
    }

    private void toolStripStatusLabel2_Click(object sender, EventArgs e)
    {
        ApiClient.Token = "";
        MessageBox.Show("Bạn đã đăng xuất!");

        var login = new FormLogin();
        login.Show();
        Close();
    }

    private async void btnNext_Click(object sender, EventArgs e)
    {
        ShowProgress();

        if (tabControl1.SelectedIndex == 0)
        {
            pageAll++;
            await LoadAllFoods();
        }
        else
        {
            pageMy++;
            await LoadMyFoods();
        }

        UpdatePageLabel();

        HideProgress();
    }

    private async void btnPrev_Click(object sender, EventArgs e)
    {
        ShowProgress();

        if (tabControl1.SelectedIndex == 0)
        {
            if (pageAll > 1)
            {
                pageAll--;
                await LoadAllFoods();
            }
        }
        else
        {
            if (pageMy > 1)
            {
                pageMy--;
                await LoadMyFoods();
            }
        }

        UpdatePageLabel();

        HideProgress();
    }

    private void ApplyPaginationAll()
    {
        flowAll.Controls.Clear();

        var paged = allFoods
            .Skip((pageAll - 1) * pageSize)
            .Take(pageSize)
            .ToList();

        foreach (var f in paged)
        {
            var card = new FoodCard();
            card.BindData(f);

            card.OnDeleted += async () =>
            {
                await LoadAllFoods();
                await LoadMyFoods();
            };

            flowAll.Controls.Add(card);
        }
    }

    private void ApplyPaginationMyFoods()
    {
        flowDongGop.Controls.Clear();

        var paged = myFoods
            .Skip((pageMy - 1) * pageSize)
            .Take(pageSize)
            .ToList();

        foreach (var f in paged)
        {
            var card = new FoodCard();
            card.BindData(f);

            card.OnDeleted += async () =>
            {
                await LoadMyFoods();
                await LoadAllFoods();
            };

            flowDongGop.Controls.Add(card);
        }
    }

    private void UpdatePageLabel()
    {
        if (tabControl1.SelectedIndex == 0)
            lblPage.Text = $"Page {pageAll}";
        else
            lblPage.Text = $"Page {pageMy}";
    }

    private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
    {
        UpdatePageLabel();
    }

    private void toolStripProgressBar1_Click(object sender, EventArgs e)
    {
    }

    private void ShowProgress()
    {
        progressBar1.Visible = true;
    }

    private void HideProgress()
    {
        progressBar1.Visible = false;
    }
}