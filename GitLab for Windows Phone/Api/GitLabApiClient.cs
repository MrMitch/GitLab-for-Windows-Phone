using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;
using Newtonsoft.Json;

namespace GitLab_for_Windows_Phone.Api
{
    public class GitLabApiClient
    {
        public string ServerAddress { get; private set; }
        public string Token { get; private set; }

        public GitLabApiClient(string serverAddress, string token)
        {
            ServerAddress = serverAddress;
            Token = token;
        }

        public async Task<T> Get<T>(string url, IDictionary<string, object> parameters)
        {
            var response = await SendRequest("get", url, parameters);

            return await DecodeResponse<T>(response);
        }

        public async Task<T> Post<T>(string url, IDictionary<string, object> parameters)
        {
            var response = await SendRequest("post", url, parameters);

            return await DecodeResponse<T>(response);
        }

        public async Task<T> Delete<T>(string url)
        {
            var response = await SendRequest("delete", url, null);

            return await DecodeResponse<T>(response);
        }

        private async Task<T> DecodeResponse<T>(HttpResponseMessage response)
        {
            if (response == null || !response.IsSuccessStatusCode)
            {
                return default(T);
            }

            var payload = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(payload);
        }

        private async Task<HttpResponseMessage> SendRequest(string method, string uri, IEnumerable<KeyValuePair<string, object>> parameters)
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri(ServerAddress),
                Timeout = new TimeSpan(0,0,0,30)
            };
            client.DefaultRequestHeaders.Add("PRIVATE-TOKEN", Token);

            HttpResponseMessage response = null;
            switch (method.ToLowerInvariant())
            {
                case "get":
                    var queryString = String.Empty;
                    if (parameters != null)
                    {
                        queryString = parameters.Aggregate(new StringBuilder("?"), 
                            (stringBuilder, kv) => stringBuilder.AppendFormat("{0}={1}&", kv.Key, kv.Value), 
                            stringBuilder => stringBuilder.ToString().TrimEnd(new []{'&'}));
                    }

                    response = await client.GetAsync("/api/v3/" + uri + queryString);
                    break;
                case "post":
                    var body = JsonConvert.SerializeObject(parameters);
                    response = await client.PostAsync("/api/v3/" + uri, new StringContent(body, Encoding.UTF8, "application/json"));
                    break;
                case "delete":
                    response = await client.DeleteAsync("/api/v3" + uri);
                    break;
                default: 
                    //throw new ArgumentException("Unsupported method", "method");
                    break;
            }
            
            return response;
        }
    }
}
