using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;


namespace Lab04_Bai04
{
    public partial class Form1 : Form
    {
        public class Movie
        {
            public string Name { get; set; }
            public int Price { get; set; }
            public int[] Rooms { get; set; }
            public string Url { get; set; }
            public string Poster { get; set; }
        }

        // 4 phim theo lab1
        List<Movie> movies = new List<Movie>
        {
            new Movie {
                Name = "Đào, phở và piano",
                Price = 45000,
                Rooms = new[]{1,2,3},
                Url = "https://moveek.com/phim/dao-pho-va-piano/",
                Poster = "https://cdn.moveek.com/storage/media/cache/tall/65d414474b3ff830746086.jpg"
            },
            new Movie {
                Name = "Mai",
                Price = 100000,
                Rooms = new[]{2,3},
                Url = "https://www.cgv.vn/default/mai.html",
                Poster = "https://www.cgv.vn/media/catalog/product/cache/1/image/c5f0a1eff4c394a251036189ccddaacd/m/a/mai_teaser_poster_digital_1_.jpg"
            },
            new Movie {
                Name = "Gặp lại chị bầu",
                Price = 70000,
                Rooms = new[]{1},
                Url = "https://www.cgv.vn/default/gap-lai-chi-bau.html",
                Poster = "https://www.cgv.vn/media/catalog/product/cache/1/image/c5f0a1eff4c394a251036189ccddaacd/4/7/470wx700h_5_.jpg"
            },
            new Movie {
                Name = "Tarot",
                Price = 90000,
                Rooms = new[]{3},
                Url = "https://www.cgv.vn/default/tarot.html",
                Poster = "https://www.cgv.vn/media/catalog/product/cache/1/image/c5f0a1eff4c394a251036189ccddaacd/7/0/700x1000-tarot.jpg"
            }
        };

        // trạng thái chương trình
        Movie currentMovie;
        int currentPrice = 0;

        List<string> selectedSeats = new List<string>();
        Dictionary<string, List<string>> bookedSeats = new Dictionary<string, List<string>>();

        string bookingsFile = "bookings.json";

        public Form1()
        {
            InitializeComponent();
            LoadBookings();

            btnLoadPhim.Click += btnLoadPhim_Click;
            btnDatVe.Click += btnDatVe_Click;

            // gán event ghế
            foreach (var btn in panel3.Controls.OfType<Button>())
            {
                if (btn.Name.StartsWith("btn"))
                    btn.Click += Seat_Click;
            }
        }

        // load file json ghế đã đặt
        void LoadBookings()
        {
            if (!File.Exists(bookingsFile))
            {
                bookedSeats = new Dictionary<string, List<string>>();
                return;
            }

            string json = File.ReadAllText(bookingsFile);
            bookedSeats = JsonSerializer.Deserialize<Dictionary<string, List<string>>>(json);
        }

        void SaveBookings()
        {
            string json = JsonSerializer.Serialize(bookedSeats, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(bookingsFile, json);
        }

        private void btnLoadPhim_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            progressBar1.Value = 20;

            foreach (var mv in movies)
                AddMovieItem(mv);

            progressBar1.Value = 100;
        }

        // Tạo item phim
        private void AddMovieItem(Movie mv)
        {
            Panel p = new Panel();
            p.Width = 750;     
            p.Height = 200;    
            p.BorderStyle = BorderStyle.FixedSingle;

            PictureBox pic = new PictureBox();
            pic.Size = new Size(160, 200);  
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.LoadAsync(mv.Poster);
            p.Controls.Add(pic);

            Label lbl = new Label();
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

                string seat = b.Name.Replace("btn", "");
                if (IsSeatBooked(currentMovie.Name, seat))
                    b.BackColor = Color.Gray;
            }

            label8.Text = "Tổng tiền: 0 đ";
        }

        bool IsSeatBooked(string movie, string seat)
        {
            return bookedSeats.ContainsKey(movie) && bookedSeats[movie].Contains(seat);
        }

        // click chọn ghế
        private void Seat_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            string seat = b.Name.Replace("btn", "");

            // ghế đã đặt rồi thì không chọn được
            if (IsSeatBooked(currentMovie.Name, seat))
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
            int total = 0;

            foreach (var s in selectedSeats)
            {
                // vớt
                if (s == "A1" || s == "A5" || s == "C1" || s == "C5")
                    total += currentPrice / 4;

                // VIP
                else if (s.StartsWith("B") && s != "B1" && s != "B5")
                    total += currentPrice * 2;

                // thường
                else
                    total += currentPrice;
            }

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
            if (!bookedSeats.ContainsKey(currentMovie.Name))
                bookedSeats[currentMovie.Name] = new List<string>();

            bookedSeats[currentMovie.Name].AddRange(selectedSeats);
            SaveBookings();

            string msg =
                $"KH: {txtTenKH.Text}\n" +
                $"SĐT: {txtSDT.Text}\n" +
                $"Phim: {currentMovie.Name}\n" +
                $"Phòng Chiếu: {cbbPhongChieu.Text}\n" +
                $"Ghế: {string.Join(", ", selectedSeats)}\n" +
                $"{label8.Text}";

            MessageBox.Show(msg, "ĐẶT VÉ THÀNH CÔNG");

            ResetSeatUI();
        }
    }
    
}
