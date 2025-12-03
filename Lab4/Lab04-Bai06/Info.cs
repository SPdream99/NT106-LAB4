using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;

namespace Lab04_Bai06
{
    public partial class Info : Form
    {
        HttpClient client;
        public Info(string tokenType, string accessToken)
        {
            InitializeComponent();
            client = new HttpClient();
            this.Load += (s,e) => infoGet(tokenType, accessToken);
        }

        // Xem như đây là một cli app, khi mà nhận được token thì bật form kết quả lên

        async void infoGet(string tokenType, string accessToken)
        {
            client.DefaultRequestHeaders.Authorization = new
            System.Net.Http.Headers.AuthenticationHeaderValue(tokenType, accessToken);

            var getUserUrl = "https://nt106.uitiot.vn/api/v1/user/me";
            var getUserResponse = await client.GetAsync(getUserUrl);
            var getUserResponseString = await
            getUserResponse.Content.ReadAsStringAsync();
            JObject data = JObject.Parse(getUserResponseString);

            foreach (var property in data)
            {
                textBox1.Text += $"{property.Key} : {property.Value}";
            }
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
