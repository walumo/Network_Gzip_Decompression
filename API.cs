using System.Net.Http;
using System.Net.Http.Headers;

namespace Network
{
    static class API
    {
        public static HttpClient Client { get; set; }

        public static void InitializeClient()
        {
            Client = new HttpClient();
            Client.DefaultRequestHeaders.Accept.Clear();
            Client.DefaultRequestHeaders.AcceptEncoding.Add(new StringWithQualityHeaderValue("gzip"));
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
