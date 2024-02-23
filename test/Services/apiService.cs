using test.Models;

namespace test.Services
{
    public class apiService
    {
        public T Get<T>(string api) where T : class
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(AppSetting.Config.APIBaseAddress);
                var response = client.GetAsync($"{api}").Result;

                if (response.IsSuccessStatusCode)
                {
                    var result = response.Content.ReadFromJsonAsync<T>().Result;
                    return result;
                }
            }
            return null;
        }

        public bool Post<T>(string api, T value) where T : class
        {
            var result = false;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(AppSetting.Config.APIBaseAddress);
                var response = client.PostAsJsonAsync($"{api}", value).Result;

                if (response.IsSuccessStatusCode)
                {
                    result = true;
                }
            }
            return result;
        }
    }
}
