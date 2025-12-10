using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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
            //string email = "";
            //string name = "";
            //string phone = "";
            //foreach (var property in data)
            //{
            //    string title = property.Key;
            //    JToken content = property.Value;
            //switch (property.Key)
            //{
            //    case "id":
            //        title = "ID";
            //        break;
            //    case "email":
            //        email = (string) content;
            //        title = "";
            //        content = "";
            //        break;
            //    case "email_verified":
            //        title = "Email";
            //        if ((string)content == "False") content = email + " (Not verified)";
            //        else content = email + " (Verified)";
            //        break;
            //    case "first_name":
            //        title = "";
            //        name = (string)content;
            //        break;
            //    case "last_name":
            //        title = "Name";
            //        content = content + " " + name;
            //        break;
            //    case "avatar":
            //        title = "";
            //        break;
            //    case "sex":
            //        content = ((int)content == 1) ? "Male" : "Female";
            //        break;
            //    case "phone":
            //        phone = (string)content;
            //        title = "";
            //        content = "";
            //        break;
            //    case "phone_verified":
            //        title = "Phone";
            //        if ((string)content == "False") content = phone + " (Not verified)";
            //        else content = phone + " (Verified)";
            //        break;
            //    case "is_active":
            //        title = "Active";
            //        break;
            //    case "is_superuser":
            //        title = "SuperUser";
            //        break;
            //    default:
            //        break;
            //}
            //if (title != "")
            //{
            //    textBox1.Text += $"{title.ToUpper()[0]}{title.Substring(1)} : {content}";
            //    textBox1.Text += Environment.NewLine;
            //}
            if (data.ContainsKey("id"))
                textBox1.Text = $"" +
                    $"Username : {data["username"]}{(((string)data["is_superuser"] == "True") ? " (Super User)" : "")} ({(((string)data["is_active"] == "True") ? "Active" : "Unactive")})\r\n" +
                    $"ID : {data["id"]}\r\nEmail : {data["email"]} ({(((string)data["email_verified"] == "False") ? "Not " : "")}Verified)\r\n" +
                    $"Phone : {data["phone"]} ({(((string)data["phone_verified"] == "False") ? "Not " : "")}Verified)\r\n" +
                    $"Name : {data["last_name"]} {data["first_name"]}\r\n" +
                    $"Sex : {(((int)data["sex"] == 1) ? "Male" : "Female")}\r\n" +
                    $"Birthday : {data["birthday"]}\r\n" +
                    $"Language : {((string)data["language"]).ToUpper()[0]}{((string)data["language"]).Substring(1)}\r\n";
            //}
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
