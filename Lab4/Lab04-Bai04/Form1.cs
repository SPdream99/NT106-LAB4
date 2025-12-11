using System.Text.Json;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net;

namespace Lab04_Bai04;

public partial class Form1 : Form
{
    private readonly string bookingsFile = "bookings.json";

    // 4 phim theo lab1
    private readonly List<Movie> movies = new()
    {
        new Movie
        {
            Name = "Đào, phở và piano",
            Price = 45000,
            Rooms = new[] { 1, 2, 3 },
            Url = "https://moveek.com/phim/dao-pho-va-piano/",
            Poster = "https://cdn.moveek.com/storage/media/cache/tall/65d414474b3ff830746086.jpg"
        },
        new Movie
        {
            Name = "Mai",
            Price = 100000,
            Rooms = new[] { 2, 3 },
            Url = "https://www.cgv.vn/default/mai.html",
            Poster =
                "https://www.cgv.vn/media/catalog/product/cache/1/image/c5f0a1eff4c394a251036189ccddaacd/m/a/mai_teaser_poster_digital_1_.jpg"
        },
        new Movie
        {
            Name = "Gặp lại chị bầu",
            Price = 70000,
            Rooms = new[] { 1 },
            Url = "https://www.cgv.vn/default/gap-lai-chi-bau.html",
            Poster =
                "https://www.cgv.vn/media/catalog/product/cache/1/image/c5f0a1eff4c394a251036189ccddaacd/4/7/470wx700h_5_.jpg"
        },
        new Movie
        {
            Name = "Tarot",
            Price = 90000,
            Rooms = new[] { 3 },
            Url = "https://www.cgv.vn/default/tarot.html",
            Poster =
                "https://www.cgv.vn/media/catalog/product/cache/1/image/c5f0a1eff4c394a251036189ccddaacd/7/0/700x1000-tarot.jpg"
        }
    };

    private readonly List<string> selectedSeats = new();
    private Dictionary<string, List<string>> bookedSeats = new();

    // trạng thái chương trình
    private Movie currentMovie;
    private int currentPrice;

    public Form1()
    {
        InitializeComponent();
        LoadBookings();

        btnLoadPhim.Click += btnLoadPhim_Click;


        // gán event ghế
        foreach (var btn in panel3.Controls.OfType<Button>())
            if (btn.Name.StartsWith("btn"))
                btn.Click += Seat_Click;
    }

    // load file json ghế đã đặt
    private void LoadBookings()
    {
        if (!File.Exists(bookingsFile))
        {
            bookedSeats = new Dictionary<string, List<string>>();
            return;
        }

        var json = File.ReadAllText(bookingsFile);
        bookedSeats = JsonSerializer.Deserialize<Dictionary<string, List<string>>>(json);
    }

    private void SaveBookings()
    {
        var json = JsonSerializer.Serialize(bookedSeats, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(bookingsFile, json);
    }

    private async Task DownloadJsonAsync(string url, string localPath)
    {
        using var http = new HttpClient();
        var json = await http.GetStringAsync(url);
        await File.WriteAllTextAsync(localPath, json);
    }

    private class ExternalMovie
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string Poster { get; set; }
    }

    private async Task<List<ExternalMovie>> CrawlMoviesAsync()
    {
        var http = new HttpClient();
        var html = await http.GetStringAsync("https://betacinemas.vn/phim.htm");
        var list = new List<ExternalMovie>();
        var seen = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        int i = 0;
        while (true)
        {
            int card = html.IndexOf("class=\"product-item", i, StringComparison.OrdinalIgnoreCase);
            if (card < 0) break;

            int posterClass = html.IndexOf("class=\"img-responsive border-radius-20\"", card, StringComparison.OrdinalIgnoreCase);
            string poster = "";
            if (posterClass > -1)
            {
                int src = html.IndexOf("src=\"", posterClass, StringComparison.OrdinalIgnoreCase);
                if (src > -1)
                {
                    src += 5;
                    int srcEnd = html.IndexOf("\"", src, StringComparison.Ordinal);
                    if (srcEnd > src) poster = html.Substring(src, srcEnd - src).Trim();
                }
            }

            int h3 = html.IndexOf("<h3", card, StringComparison.OrdinalIgnoreCase);
            string url = "";
            string title = "";
            if (h3 > -1)
            {
                int href = html.IndexOf("href=\"", h3, StringComparison.OrdinalIgnoreCase);
                if (href > -1)
                {
                    href += 6;
                    int hrefEnd = html.IndexOf("\"", href, StringComparison.Ordinal);
                    if (hrefEnd > href) url = html.Substring(href, hrefEnd - href).Trim();

                    int aStart = html.IndexOf(">", hrefEnd, StringComparison.Ordinal);
                    int aEnd = aStart > -1 ? html.IndexOf("</a>", aStart, StringComparison.OrdinalIgnoreCase) : -1;
                    if (aStart > -1 && aEnd > aStart)
                    {
                        title = WebUtility.HtmlDecode(html.Substring(aStart + 1, aEnd - aStart - 1).Trim());
                    }
                }
            }

            if (!string.IsNullOrWhiteSpace(title) && seen.Add(title))
            {
                list.Add(new ExternalMovie { Name = title, Url = url, Poster = poster });
            }

            i = h3 > -1 ? h3 + 4 : card + 1;
        }

        return list;
    }

    private static string MakeAbsoluteUrl(string baseUrl, string path)
    {
        if (string.IsNullOrWhiteSpace(path)) return "";
        if (path.StartsWith("http", StringComparison.OrdinalIgnoreCase)) return path;
        if (!baseUrl.EndsWith("/")) baseUrl += "/";
        if (path.StartsWith("/")) path = path.Substring(1);
        return baseUrl + path;
    }



    private async void btnLoadPhim_Click(object sender, EventArgs e)
    {
        flowLayoutPanel1.Controls.Clear();
        progressBar1.Value = 10;

        List<ExternalMovie> extMovies = null;
        var localJson = "movies.json";

        if (File.Exists(localJson))
        {
            try
            {
                var json = await File.ReadAllTextAsync(localJson);
                extMovies = JsonSerializer.Deserialize<List<ExternalMovie>>(json) ?? new List<ExternalMovie>();
            }
            catch
            {
                extMovies = new List<ExternalMovie>();
            }
        }

        if (extMovies == null || extMovies.Count == 0)
        {
            extMovies = await CrawlMoviesAsync();
            try
            {
                var json = JsonSerializer.Serialize(extMovies, new JsonSerializerOptions { WriteIndented = true });
                await File.WriteAllTextAsync(localJson, json);
            }
            catch { }
        }

        movies.Clear();
        foreach (var m in extMovies)
        {
            var absoluteUrl = MakeAbsoluteUrl("https://betacinemas.vn", m.Url);
            movies.Add(new Movie
            {
                Name = m.Name,
                Price = 100000,
                Rooms = new[] { 1, 2, 3 },
                Url = absoluteUrl,
                Poster = m.Poster
            });
        }

        progressBar1.Value = 60;

        foreach (var mv in movies)
            AddMovieItem(mv);

        progressBar1.Value = 100;
    }

    // Tạo item phim
    private void AddMovieItem(Movie mv)
    {
        var p = new Panel();
        p.Width = 750;
        p.Height = 200;
        p.BorderStyle = BorderStyle.FixedSingle;

        var pic = new PictureBox();
        pic.Size = new Size(160, 200);
        pic.SizeMode = PictureBoxSizeMode.StretchImage;
        pic.LoadAsync(mv.Poster);
        p.Controls.Add(pic);

        var lbl = new Label();
        lbl.Text = mv.Name;
        lbl.Location = new Point(180, 60);
        lbl.Font = new Font("Segoe UI", 14, FontStyle.Bold);
        lbl.Size = new Size(500, 50);

        lbl.Click += (s, e) => OnMovieSelected(mv);

        p.Controls.Add(lbl);
        flowLayoutPanel1.Controls.Add(p);

        p.Margin = new Padding(0, 10, 0, 10);
    }

    //chọn phim
    private void OnMovieSelected(Movie mv)
    {
        currentMovie = mv;
        currentPrice = mv.Price;

        // mở tab xem chi tiết
        tabControl1.SelectedTab = tabPage1;
        webView21.Source = new Uri(mv.Url);

        // load phòng chiếu
        cbbPhongChieu.Items.Clear();
        foreach (var r in mv.Rooms)
            cbbPhongChieu.Items.Add("Phòng " + r);


        ResetSeatUI();
    }

    // reset màu ghế mỗi lần chọn phim
    private void ResetSeatUI()
    {
        selectedSeats.Clear();

        foreach (var b in panel3.Controls.OfType<Button>())
        {
            b.BackColor = SystemColors.Control;

            var seat = b.Name.Replace("btn", "");
            if (IsSeatBooked(currentMovie.Url, seat))
                b.BackColor = Color.Gray;
        }

        label8.Text = "Tổng tiền: 0 đ";
    }

    private bool IsSeatBooked(string movie, string seat)
    {
        return bookedSeats.ContainsKey(movie) && bookedSeats[movie].Contains(seat);
    }

    // click chọn ghế
    private void Seat_Click(object sender, EventArgs e)
    {
        var b = sender as Button;
        var seat = b.Name.Replace("btn", "");

        // ghế đã đặt rồi thì không chọn được
        if (IsSeatBooked(currentMovie.Url, seat))
        {
            MessageBox.Show("Ghế này đã được đặt trước!");
            return;
        }

        // bỏ chọn
        if (selectedSeats.Contains(seat))
        {
            selectedSeats.Remove(seat);
            b.BackColor = SystemColors.Control;
            UpdatePrice();
            return;
        }

        // tối đa 2 ghế
        if (selectedSeats.Count >= 2)
        {
            MessageBox.Show("Chỉ được chọn tối đa 2 ghế!");
            return;
        }

        selectedSeats.Add(seat);
        b.BackColor = Color.Orange;

        UpdatePrice();
    }


    // tính tiền
    private void UpdatePrice()
    {
        var total = 0;

        foreach (var s in selectedSeats)
            // vớt
            if (s == "A1" || s == "A5" || s == "C1" || s == "C5")
                total += currentPrice / 4;

            // VIP
            else if (s.StartsWith("B") && s != "B1" && s != "B5")
                total += currentPrice * 2;

            // thường
            else
                total += currentPrice;

        label8.Text = "Tổng tiền: " + total.ToString("N0") + " đ";
    }

    //btn đặt vé
    private void btnDatVe_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtTenKH.Text) ||
            string.IsNullOrWhiteSpace(txtSDT.Text) ||
            cbbPhongChieu.SelectedIndex < 0)
        {
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            return;
        }

        if (selectedSeats.Count == 0)
        {
            MessageBox.Show("Bạn chưa chọn ghế!");
            return;
        }

        // lưu ghế vào file json
        if (!bookedSeats.ContainsKey(currentMovie.Url))
            bookedSeats[currentMovie.Url] = new List<string>();

        bookedSeats[currentMovie.Url].AddRange(selectedSeats);
        SaveBookings();

        var msg =
            $"KH: {txtTenKH.Text}\n" +
            $"SĐT: {txtSDT.Text}\n" +
            $"Phim: {currentMovie.Name}\n" +
            $"Phòng Chiếu: {cbbPhongChieu.Text}\n" +
            $"Ghế: {string.Join(", ", selectedSeats)}\n" +
            $"{label8.Text}";

        MessageBox.Show(msg, "ĐẶT VÉ THÀNH CÔNG");
        ResetSeatUI();
    }

    public class Movie
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int[] Rooms { get; set; }
        public string Url { get; set; }
        public string Poster { get; set; }
    }
}