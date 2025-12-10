using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

public class ApiClient
{
    private readonly HttpClient _client;

    // Lưu token sau khi đăng nhập
    public static string Token = "";
    public static string CurrentUsername = "";

    private const string BASE_URL = "https://nt106.uitiot.vn/"; 

    public ApiClient()
    {
        _client = new HttpClient();
        _client.BaseAddress = new Uri(BASE_URL);

        ApplyToken();
    }

    // Tự động gắn Bearer token
    public void ApplyToken()
    {
        if (!string.IsNullOrEmpty(Token))
        {
            _client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", Token);
        }
    }

    //Post
    public async Task<T> PostAsync<T>(string url, object data)
    {
        ApplyToken();

        var json = JsonConvert.SerializeObject(data);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        var res = await _client.PostAsync(url, content);
        var body = await res.Content.ReadAsStringAsync();

        if (!res.IsSuccessStatusCode)
            throw new Exception(body);

        return JsonConvert.DeserializeObject<T>(body);
    }

    // get
    public async Task<T> GetAsync<T>(string url)
    {
        ApplyToken();

        var res = await _client.GetAsync(url);
        var body = await res.Content.ReadAsStringAsync();

        if (!res.IsSuccessStatusCode)
            throw new Exception(body);

        return JsonConvert.DeserializeObject<T>(body);
    }

    public async Task<T> PostFormAsync<T>(string url, Dictionary<string, string> data)
    {
        ApplyToken();

        var content = new FormUrlEncodedContent(data);

        var res = await _client.PostAsync(url, content);
        var body = await res.Content.ReadAsStringAsync();

        if (!res.IsSuccessStatusCode)
            throw new Exception(body);

        return JsonConvert.DeserializeObject<T>(body);
    }

    public async Task DeleteAsync(string url)
    {
        ApplyToken();

        var res = await _client.DeleteAsync(url);
        var body = await res.Content.ReadAsStringAsync();

        if (!res.IsSuccessStatusCode)
            throw new Exception(body);
    }





}
