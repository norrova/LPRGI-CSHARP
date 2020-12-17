using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Nutget_Exo
{
    public class ApiHelper<T>
    {
        public static async Task<T> GetRequestAsync(Uri uri)
        {
            using (var vHttpClient = new HttpClient())
            {
                HttpResponseMessage response;
                try
                {
                    response = await vHttpClient.GetAsync(uri);
                    response.EnsureSuccessStatusCode();
                    string contentResponse = await response.Content.ReadAsStringAsync();
                    T objectContent = JsonConvert.DeserializeObject<T>(contentResponse);

                    return objectContent;
                }
                catch (HttpRequestException)
                {
                    throw;
                }
            }
        }

        public static async Task<T> PostRequestAsync(Uri uri, T obj)
        {
            using (var vHttpClient = new HttpClient())
            {
                HttpResponseMessage response;
                try
                {
                    string jsonContent = JsonConvert.SerializeObject(obj);

                    response = await vHttpClient.PostAsync(uri, new StringContent(jsonContent));
                    response.EnsureSuccessStatusCode();
                    string contentResponse = await response.Content.ReadAsStringAsync();
                    T objectContent = JsonConvert.DeserializeObject<T>(contentResponse);

                    return objectContent;
                }
                catch (HttpRequestException)
                {
                    throw;
                }
            }
        }
    }
}