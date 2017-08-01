using ClashSharp.Interface;
using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.Extensions.Configuration;

namespace ClashSharp.Util
{
    public class ApiClient : IApiClient
    {
        private HttpService _httpSvc = new HttpService();
        private string _cocApiToken = new ConfigurationBuilder().AddJsonFile("app.secrets.json").Build()["clashApiKey"];

        public async Task<T> Get<T>(string url) where T : new()
        {
            string jsonData = string.Empty;
            var returnValue = new T();

            try
            {
                jsonData = await _httpSvc.GetJsonAsync(_cocApiToken, url);
                returnValue = JsonConvert.DeserializeObject<T>(jsonData);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return returnValue;
        }
    }
}
