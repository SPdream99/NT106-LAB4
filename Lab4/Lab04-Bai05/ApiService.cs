using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Lab04_Bai05
{
    public class ApiService
    {
        private readonly HttpClient _client = new HttpClient();

        public async Task<(bool Success, string TokenType, string AccessToken, string Detail, string root)>
            LoginAsync(string url, string username, string password)
        {
            var form = new MultipartFormDataContent
            {
                { new StringContent(username), "username" },
                { new StringContent(password), "password" }
            };
            var response = await _client.PostAsync(url, form);
            var json = await response.Content.ReadAsStringAsync();

            try
            {
                var doc = JObject.Parse(json);

                if (response.IsSuccessStatusCode)
                    return (
                        true,
                        doc["token_type"].ToString(),
                        doc["access_token"].ToString(),
                        null,
                        json
                    );

                var detail = doc["detail"].ToString();
                return (false, null, null, detail, null);
            }
            catch
            {
                return (false, null, null, "Invalid JSON response", null);
            }
        }
    }
}